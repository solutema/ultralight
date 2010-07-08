#region License
// Copyright 2004-2010 South Bridge S.R.L.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// Este programa es software libre; puede distribuirlo y/o moficiarlo de
// acuerdo a los términos de la Licencia Pública General de GNU (GNU
// General Public License), como la publica la Fundación para el Software
// Libre (Free Software Foundation), tanto la versión 3 de la Licencia
// como (a su elección) cualquier versión posterior.
//
// Este programa se distribuye con la esperanza de que sea útil, pero SIN
// GARANTÍA ALGUNA; ni siquiera la garantía MERCANTIL implícita y sin
// garantizar su CONVENIENCIA PARA UN PROPÓSITO PARTICULAR. Véase la
// Licencia Pública General de GNU para más detalles. 
//
// Debería haber recibido una copia de la Licencia Pública General junto
// con este programa. Si no ha sido así, vea <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.CuentasCorrientes
{
        public partial class Inicio : Lui.Forms.AccountForm
        {
                private int m_Grupo = 0;

                public Inicio()
                        : base()
                {
                        InitializeComponent();

                        this.ColIngreso.Text = "Crédito";
                        this.ColEgreso.Text = "Débito";

                        FilterButton.Visible = true;
                        m_Fechas = new Lfx.Types.DateRange("*");
                }

                public override Lfx.Types.OperationResult Edit(int lCodigo)
                {
                        if (m_Cliente == 0) {
                                m_Cliente = lCodigo;
                                RefreshList();
                        } else {
                                Lfx.Data.Row Movim = this.DataBase.Tables["ctacte"].FastRows[lCodigo];
                                if (Movim != null) {
                                        if (Movim["id_recibo"] != null) {
                                                int IdRecibo = System.Convert.ToInt32(Movim["id_recibo"]);
                                                this.Workspace.RunTime.Execute("EDITAR RECIBO " + IdRecibo.ToString());
                                        }
                                        if (Movim["id_comprob"] != null) {
                                                int IdFactura = System.Convert.ToInt32(Movim["id_comprob"]);
                                                this.Workspace.RunTime.Execute("EDITAR COMPROB " + IdFactura.ToString());
                                        }
                                }
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }


                public override Lfx.Types.OperationResult RefreshList()
                {
                        Lfx.Types.OperationResult mostrarReturn = base.RefreshList();

                        if (mostrarReturn.Success == true) {
                                if (m_Cliente > 0)
                                        MostrarCliente();
                                else
                                        MostrarResumen();
                        }
                        return mostrarReturn;
                }


                private void MostrarResumen()
                {
                        this.Text = "Resumen de Cuenta Corriente";

                        ItemList.BeginUpdate();
                        ItemList.Items.Clear();

                        ItemList.Columns[1].Width = 0;
                        ItemList.Columns[2].Text = "Cliente";
                        ItemList.Columns[2].Width = 480;
                        ItemList.Columns[3].Width = 0;
                        ItemList.Columns[4].Width = 0;
                        ItemList.Columns[6].Width = 0;
                        ItemList.Columns[7].Width = 0;
                        ItemList.Columns[8].Width = 320;

                        m_SelectCommand = new qGen.Select("personas");
                        m_SelectCommand.Joins.Clear();
                        m_SelectCommand.Joins.Add(new qGen.Join("ctacte", "personas.id_persona=ctacte.id_cliente"));
                        m_SelectCommand.Fields = "personas.id_persona, personas.nombre_visible, SUM(ctacte.importe) AS saldo";

                        qGen.Where Where = new qGen.Where();
                        if (m_Fechas != null && m_Fechas.HasRange)
                                Where.AddWithValue("fecha", m_Fechas.From, m_Fechas.To);
                        if (m_Grupo != 0)
                                Where.AddWithValue("personas.id_grupo", m_Grupo);
                        m_SelectCommand.WhereClause = Where;
                        m_SelectCommand.Group = "personas.id_persona";
                        m_SelectCommand.Order = "personas.nombre_visible";

                        m_FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("id_persona", "Cód. Cliente", Lfx.Data.InputFieldTypes.Serial, 0),
				new Lfx.Data.FormField("nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("saldo", "Saldo", Lfx.Data.InputFieldTypes.Currency, 160)
			};

                        double Total = 0;
                        DataTable Clientes = this.DataBase.Select(this.SelectCommand());
                        foreach (System.Data.DataRow Cliente in Clientes.Rows) {
                                double Saldo = Cliente["saldo"] is DBNull ? 0 : System.Convert.ToDouble(Cliente["saldo"]);
                                if (Saldo != 0) {
                                        ListViewItem itm = ItemList.Items.Add(System.Convert.ToString(Cliente["id_persona"]));
                                        itm.SubItems.Add("fecha");
                                        itm.SubItems.Add(System.Convert.ToString(Cliente["nombre_visible"]));
                                        Total += Saldo;
                                        itm.SubItems.Add("-");
                                        itm.SubItems.Add("-");
                                        itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Saldo, Workspace.CurrentConfig.Currency.DecimalPlaces));
                                        itm.SubItems.Add("");
                                        itm.SubItems.Add("");
                                        itm.SubItems.Add("");
                                }
                        }

                        ItemList.EndUpdate();
                        ItemList.Focus();
                        if (ItemList.Items.Count > 0) {
                                ItemList.Items[0].Focused = true;
                                ItemList.Items[0].Selected = true;
                        }

                        EtiquetaSaldo.Text = Lfx.Types.Formatting.FormatCurrency(Total, Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EtiquetaTransporte.Text = "-";
                        EtiquetaIngresos.Text = "-";
                        EtiquetaEgresos.Text = "-";
                }


                public override qGen.Select SelectCommand()
                {
                        return m_SelectCommand;
                }


                private void MostrarCliente()
                {
                        m_FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("ctacte.id_movim", "Cód.", Lfx.Data.InputFieldTypes.Integer, 0),
				new Lfx.Data.FormField("ctacte.fecha", "Fecha", Lfx.Data.InputFieldTypes.DateTime, 96),
				new Lfx.Data.FormField("ctacte.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("ctacte.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 120),
				new Lfx.Data.FormField("0", "0", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("ctacte.saldo", "saldo", Lfx.Data.InputFieldTypes.Currency, 120),
				new Lfx.Data.FormField("ctacte.id_comprob", "Comprobante", Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("ctacte.id_persona", "Persona", Lfx.Data.InputFieldTypes.Text, 160),
                                new Lfx.Data.FormField("ctacte.obs", "Obs.", Lfx.Data.InputFieldTypes.Memo, 320)
			};

                        m_SelectCommand = new qGen.Select("ctacte");

                        m_SelectCommand.Fields = "ctacte.id_movim, ctacte.fecha, ctacte.concepto, ctacte.importe, 0, ctacte.saldo, ctacte.id_comprob, ctacte.id_cliente, ctacte.obs";
                        qGen.Where Where = new qGen.Where();
                        if (m_Fechas.HasRange)
                                Where.AddWithValue("ctacte.fecha", m_Fechas.From, m_Fechas.To);

                        Where.AddWithValue("ctacte.id_cliente", m_Cliente);

                        m_SelectCommand.Group = "ctacte.id_movim";
                        m_SelectCommand.WhereClause = Where;
                        m_SelectCommand.Order = "ctacte.id_movim";

                        System.Data.DataTable Registros = this.DataBase.Select(this.SelectCommand());
                        ListViewItem itm = null;
                        double dTransporte = 0, dIngresos = 0, dEgresos = 0;

                        ListViewItem CurItem = null;
                        if (ItemList.SelectedItems.Count > 0)
                                CurItem = ((ListViewItem)(ItemList.SelectedItems[0].Clone()));
                        else
                                CurItem = null;

                        ItemList.BeginUpdate();
                        ItemList.Items.Clear();

                        ItemList.Columns[1].Width = 86;
                        ItemList.Columns[2].Text = "Concepto";
                        ItemList.Columns[2].Width = 240;
                        ItemList.Columns[3].Width = 86;
                        ItemList.Columns[4].Width = 86;
                        ItemList.Columns[6].Width = 104;
                        ItemList.Columns[7].Width = 120;
                        ItemList.Columns[8].Width = 240;

                        if (Registros.Rows.Count > 0) {
                                foreach (System.Data.DataRow Registro in Registros.Rows) {
                                        itm = ItemList.Items.Add(System.Convert.ToString(Registro["id_movim"]));
                                        itm.SubItems.Add(Lfx.Types.Formatting.FormatDate(Registro["fecha"]));
                                        itm.SubItems.Add(System.Convert.ToString(Registro["concepto"]));
                                        if (System.Convert.ToDouble(Registro["importe"]) > 0) {
                                                dIngresos += System.Convert.ToDouble(Registro["importe"]);
                                                itm.SubItems.Add("-");
                                                itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Registro["importe"]), Workspace.CurrentConfig.Currency.DecimalPlaces));
                                        } else {
                                                dEgresos += Math.Abs(System.Convert.ToDouble(Registro["importe"]));
                                                itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(-System.Convert.ToDouble(Registro["importe"]), Workspace.CurrentConfig.Currency.DecimalPlaces));
                                                itm.SubItems.Add("-");
                                        }
                                        //UltimoSaldo = System.Convert.ToDouble(Registro["saldo"]);
                                        itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Registro["saldo"]), Workspace.CurrentConfig.Currency.DecimalPlaces));
                                        int IdComprob = Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_comprob"]);
                                        if (IdComprob != 0)
                                                itm.SubItems.Add(Lbl.Comprobantes.Comprobante.NumeroCompleto(this.DataBase, IdComprob));
                                        else
                                                itm.SubItems.Add("");
                                        itm.SubItems.Add("");
                                        itm.SubItems.Add(System.Convert.ToString(Registro["obs"]));
                                }
                                if (CurItem != null) {
                                        if (itm.Text == CurItem.Text)
                                                itm.Selected = true; itm.Focused = true;
                                }
                        }

                        if (m_Fechas.HasRange)
                                dTransporte = Workspace.DefaultDataBase.FieldDouble("SELECT saldo FROM ctacte WHERE fecha<'" + Lfx.Types.Formatting.FormatDateTimeSql(m_Fechas.From).ToString() + "' ORDER BY fecha DESC");
                        else
                                dTransporte = 0;
                        EtiquetaTransporte.Text = Lfx.Types.Formatting.FormatCurrency(dTransporte, Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EtiquetaIngresos.Text = Lfx.Types.Formatting.FormatCurrency(dIngresos, Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EtiquetaEgresos.Text = Lfx.Types.Formatting.FormatCurrency(dEgresos, Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EtiquetaSaldo.Text = Lfx.Types.Formatting.FormatCurrency(dTransporte + dIngresos - dEgresos, Workspace.CurrentConfig.Currency.DecimalPlaces);

                        ItemList.EndUpdate();
                        ItemList.Focus();
                        if (ItemList.Items.Count > 0) {
                                ItemList.Items[0].Focused = true;
                                ItemList.Items[0].Selected = true;
                        }
                }


                public override Lfx.Types.OperationResult Print()
                {
                        this.ShowExportDialog();
                        return new Lfx.Types.SuccessOperationResult();
                }


                public override Lfx.Types.OperationResult Filter()
                {
                        Lfx.Types.OperationResult Res = base.Filter();
                        if (Res.Success == true) {
                                Filtros FormularioFiltros = new Filtros();
                                FormularioFiltros.EntradaCliente.TextInt = m_Cliente;
                                FormularioFiltros.EntradaGrupo.TextInt = m_Grupo;
                                FormularioFiltros.EntradaFechas.Rango = m_Fechas;

                                FormularioFiltros.ShowDialog();
                                if (FormularioFiltros.DialogResult == DialogResult.OK) {
                                        m_Cliente = FormularioFiltros.EntradaCliente.TextInt;
                                        m_Grupo = FormularioFiltros.EntradaGrupo.TextInt;
                                        m_Fechas = FormularioFiltros.EntradaFechas.Rango;
                                        RefreshList();
                                        Res.Success = true;
                                } else {
                                        Res.Success = false;
                                }
                        }
                        return Res;
                }


                private void BotonNotaCred_Click(object sender, System.EventArgs e)
                {
                        if (m_Cliente > 0) {
                                Lfc.Comprobantes.Facturas.Editar OFormNota = ((Lfc.Comprobantes.Facturas.Editar)(this.Workspace.RunTime.Execute("CREAR NCB")));
                                if (OFormNota != null)
                                        OFormNota.EntradaCliente.Text = m_Cliente.ToString();
                        } else {
                                Lui.Forms.MessageBox.Show("Debe seleccionar una persona. Utilice la opción Filtros (tecla <F2>).", "Error");
                        }
                }


                private void BotonNotaDeb_Click(object sender, System.EventArgs e)
                {
                        if (m_Cliente > 0) {
                                Lfc.Comprobantes.Facturas.Editar OFormNota = ((Lfc.Comprobantes.Facturas.Editar)(this.Workspace.RunTime.Execute("CREAR NDB")));
                                if (OFormNota != null)
                                        OFormNota.EntradaCliente.Text = m_Cliente.ToString();
                        } else {
                                Lui.Forms.MessageBox.Show("Debe seleccionar una persona. Utilice la opción Filtros (tecla <F2>).", "Error");
                        }
                }


                private void Inicio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F3:
                                        e.Handled = true;
                                        if (cmdNotaCred.Enabled && cmdNotaCred.Visible) {
                                                cmdNotaCred.PerformClick();
                                        }
                                        break;
                                case Keys.F4:
                                        e.Handled = true;
                                        if (cmdNotaDeb.Enabled && cmdNotaDeb.Visible) {
                                                cmdNotaDeb.PerformClick();
                                        }
                                        break;
                                case Keys.F5:
                                        e.Handled = true;
                                        if (cmdAjuste.Enabled && cmdAjuste.Visible) {
                                                cmdAjuste.PerformClick();
                                        }
                                        break;

                                case Keys.F6:
                                        if (e.Shift) {
                                                if (m_Cliente != 0) {
                                                        // Recalculo la cuenta del cliente
                                                        Lbl.Personas.Persona Cliente = new Lbl.Personas.Persona(this.DataBase, m_Cliente);
                                                        Cliente.CuentaCorriente.Recalcular();
                                                        this.MostrarCliente();
                                                }
                                                e.Handled = true;
                                        }
                                        break;
                        }

                }


                private void BotonAjuste_Click(object sender, System.EventArgs e)
                {
                        if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "ctacte.write")) {
                                Ajuste OAjuste = new Ajuste();
                                OAjuste.Owner = this;
                                OAjuste.SaldoActual = Lfx.Types.Parsing.ParseCurrency(EtiquetaSaldo.Text);
                                if (OAjuste.ShowDialog() == DialogResult.OK) {
                                        double Importe = Lfx.Types.Parsing.ParseCurrency(OAjuste.txtImporte.Text);
                                        if (Importe == 0) {
                                                Lui.Forms.MessageBox.Show("El Importe debe ser mayor o menor que cero.", "Error");
                                        } else {
                                                int Cliente = 0;
                                                if (m_Cliente != 0)
                                                        Cliente = m_Cliente;
                                                else if (ItemList.SelectedItems.Count == 1)
                                                        Cliente = Lfx.Types.Parsing.ParseInt(ItemList.SelectedItems[0].Text);
                                                else
                                                        Lui.Forms.MessageBox.Show("Debe seleccionar un cliente", "Ajuste");

                                                if (Cliente > 0) {
                                                        Lbl.CuentasCorrientes.CuentaCorriente CtaCte = new Lbl.CuentasCorrientes.CuentaCorriente(this.DataBase, Cliente);
                                                        CtaCte.Movimiento(false, OAjuste.EntradaConcepto.TextInt, OAjuste.EntradaConcepto.TextDetail, Importe, OAjuste.txtObs.Text, 0, 0, false);
                                                        this.RefreshList();
                                                }
                                        }
                                }
                        }
                }

                private void Inicio_WorkspaceChanged(object sender, EventArgs e)
                {
                        if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "ctacte.read") == false)
                                this.Close();
                }
        }
}