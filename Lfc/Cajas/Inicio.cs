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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cajas
{
        public partial class Inicio : Lui.Forms.AccountForm
        {
                public int m_Caja = 999, m_Concepto, m_TipoConcepto, m_Direccion;
                public string m_ConceptoStr;

                public Inicio()
                        : base()
                {
                        InitializeComponent();

                        m_Tabla = "cajas_movim";
                        m_Fechas = new Lfx.Types.DateRange("dia-0");
                        FilterButton.Visible = true;

                        m_FormFields = new Lfx.Data.FormField[] {
                                new Lfx.Data.FormField("cajas_movim.id_movim", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                new Lfx.Data.FormField("cajas_movim.id_caja", "Caja", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 160),
                                new Lfx.Data.FormField("cajas_movim.fecha", "Fecha.", Lfx.Data.InputFieldTypes.Date, 96),
                                new Lfx.Data.FormField("cajas_movim.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("cajas_movim.saldo", "Saldo", Lfx.Data.InputFieldTypes.Currency, 96),
                                new Lfx.Data.FormField("cajas_movim.comprob", "Comprobante", Lfx.Data.InputFieldTypes.Text, 160),
                                new Lfx.Data.FormField("cajas_movim.id_comprob", "Factura", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.id_recibo", "Recibo", Lfx.Data.InputFieldTypes.Relation, 0),
                                new Lfx.Data.FormField("cajas_movim.obs", "Obs.", Lfx.Data.InputFieldTypes.Text, 320)
                        };
                }

                public override Lfx.Data.SqlSelectBuilder SelectCommand()
                {
                        m_SelectCommand = new Lfx.Data.SqlSelectBuilder("cajas_movim");
                        m_SelectCommand.Joins.Add(new Lfx.Data.Join("personas", "cajas_movim.id_cliente=personas.id_persona"));
                        m_SelectCommand.Fields = "cajas_movim.id_movim, cajas_movim.id_caja, cajas_movim.id_concepto, cajas_movim.concepto, cajas_movim.fecha, cajas_movim.importe, cajas_movim.saldo, cajas_movim.comprob, cajas_movim.id_comprob, cajas_movim.id_recibo, cajas_movim.obs, personas.nombre_visible";
                        if (m_TipoConcepto > 0)
                                m_SelectCommand.Joins.Add(new Lfx.Data.Join("conceptos", "cajas_movim.id_concepto=conceptos.id_concepto"));

                        string TextoWhere;

                        if (m_Direccion == 1)
                                TextoWhere = "cajas_movim.importe>0";
                        else if (m_Direccion == 2)
                                TextoWhere = "cajas_movim.importe<0";
                        else
                                TextoWhere ="TRUE";

                        if (m_Caja > 0)
                                TextoWhere += " AND cajas_movim.id_caja = " + m_Caja.ToString();

                        if (m_Cliente > 0)
                                TextoWhere += " AND cajas_movim.id_cliente=" + m_Cliente.ToString();

                        if (m_Concepto > 0)
                                TextoWhere += " AND cajas_movim.id_concepto=" + m_Concepto.ToString();
                        else if (m_Concepto == -1 && m_ConceptoStr != null && m_ConceptoStr.Length > 0)
                                TextoWhere += " AND cajas_movim.concepto LIKE '%" + m_ConceptoStr + "%'";

                        if (m_TipoConcepto > 0)
                                TextoWhere += " AND conceptos.grupo=" + m_TipoConcepto.ToString();

                        if (m_Fechas.HasRange)
                                TextoWhere += " AND cajas_movim.fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59'";

                        m_SelectCommand.WhereClause = new Lfx.Data.SqlWhereBuilder(TextoWhere);
                        m_SelectCommand.Order = "cajas_movim.id_movim";
                        return m_SelectCommand;
                }

                public override Lfx.Types.OperationResult RefreshList()
                {
                        Lfx.Types.OperationResult mostrarReturn = base.RefreshList();

                        if (mostrarReturn.Success == true) {
                                if (m_Tabla.Length > 0) {
                                        System.Data.DataTable Movimientos = this.Workspace.DefaultDataBase.Select(this.SelectCommand());
                                        ListViewItem itm = null;
                                        double Transporte = 0, Ingresos = 0, Egresos = 0, Saldo = 0;

                                        ListViewItem CurItem = null;
                                        if (ItemList.SelectedItems.Count > 0)
                                                CurItem = ((ListViewItem)(ItemList.SelectedItems[0].Clone()));
                                        else
                                                CurItem = null;

                                        ItemList.BeginUpdate();
                                        ItemList.Items.Clear();

                                        Transporte = 0;
                                        System.DateTime FechaFrom = m_Fechas.HasRange ? m_Fechas.From : new System.DateTime(1900, 1, 1);
                                        if (m_Caja == 0) {
                                                // Calculo el transporte combinado de todas las cajas
                                                DataTable Cajas = this.Workspace.DefaultDataBase.Select("SELECT id_caja FROM cajas");
                                                foreach (System.Data.DataRow Caja in Cajas.Rows) {
                                                        Transporte += Math.Round(this.Workspace.DefaultDataBase.FieldDouble("SELECT saldo FROM " + m_Tabla + " WHERE  id_caja=" + Caja["id_caja"].ToString() + " AND fecha<'" + Lfx.Types.Formatting.FormatDateSql(FechaFrom).ToString() + " 00:00:00' ORDER BY id_movim DESC"), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                }
                                        } else {
                                                // Calculo el transporte de una cuenta
                                                Transporte = Math.Round(this.Workspace.DefaultDataBase.FieldDouble("SELECT saldo FROM " + m_Tabla + " WHERE  id_caja=" + m_Caja.ToString() + " AND fecha<'" + Lfx.Types.Formatting.FormatDateSql(FechaFrom) + " 00:00:00' ORDER BY id_movim DESC LIMIT 1"), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        }
                                        Saldo = Transporte;
                                        if (Movimientos.Rows.Count > 0) {
                                                foreach (System.Data.DataRow Movimiento in Movimientos.Rows) {
                                                        itm = ItemList.Items.Add(System.Convert.ToString(Movimiento["id_movim"]));
                                                        if (System.Convert.ToDouble(Movimiento["importe"]) == 0)
                                                                itm.BackColor = System.Drawing.Color.Aquamarine;

                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDate(Movimiento["fecha"])));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Movimiento["concepto"])));
                                                        double Importe = Math.Round(System.Convert.ToDouble(Movimiento["importe"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                        if (Importe < 0) {
                                                                Egresos -= Importe;
                                                                Saldo += Importe;
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "-"));
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(-System.Convert.ToDouble(Movimiento["importe"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        } else {
                                                                Ingresos += Importe;
                                                                Saldo += Importe;
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Movimiento["importe"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, "-"));
                                                        }
                                                        Saldo = Math.Round(Saldo, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Movimiento["saldo"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                        /* if (m_Caja > 0 && m_Concepto == 0 && m_TipoConcepto == 0 && Math.Abs(System.Convert.ToDouble(Movimiento["saldo"]) - Saldo) > 0.01)
                                                        {
                                                                itm.BackColor = System.Drawing.Color.Pink;
                                                                //Existe un desfasaje en el saldo... cancelo esto, recalculo y vuelvo a hacer un refresh
                                                                Lui.Forms.MessageBox.Show("Se encontró un problema con el transporte de saldos en la cuenta (diferencia de " + Lfx.Types.Formatting.FormatCurrency(Math.Abs(System.Convert.ToDouble(Movimiento["saldo"]) - Saldo), 4) + " en el movimiento Nº " + Movimiento["id_movim"].ToString() + "). El proceso de reparación automático puede demorar algunos minutos.", "Error");

                                                                Lfx.Data.DataBase Conexion = this.Workspace.GetDataBase();
                                                                Conexion.BeginTransaction();
								
                                                                TextoSql = "SELECT cajas_movim.id_movim, cajas_movim.id_caja, cajas_movim.id_concepto, cajas_movim.concepto, cajas_movim.fecha, cajas_movim.importe, cajas_movim.saldo, cajas_movim.comprob, cajas_movim.id_comprob, cajas_movim.id_recibo, cajas_movim.obs, personas.nombre_visible FROM cajas_movim LEFT JOIN personas ON cajas_movim.id_cliente=personas.id_persona";
                                                                TextoSql += " WHERE cajas_movim.id_caja=" + m_Caja.ToString();
                                                                if (m_Fecha1.Length > 0)
                                                                        TextoSql += " AND cajas_movim.fecha>='" + Lfx.Types.Formatting.FormatDateSql(m_Fecha1) + " 00:00:00'";
                                                                TextoSql += " ORDER BY cajas_movim.id_movim";

                                                                Transporte = Math.Round(Conexion.FieldDouble("SELECT saldo FROM " + m_Tabla + " WHERE  id_caja=" + m_Caja.ToString() + " AND fecha<'" + Lfx.Types.Formatting.FormatDateSql(m_Fecha1) + "' ORDER BY id_movim DESC"), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                                Saldo = Transporte;
                                                                Movimientos = Conexion.Select(TextoSql);
                                                                foreach (System.Data.DataRow MovRecalc in Movimientos.Rows)
                                                                {
                                                                        if(MovRecalc["id_movim"].ToString() == "34660")
                                                                                System.Threading.Thread.Sleep(10);
                                                                        double SubImp = Math.Round(System.Convert.ToDouble(MovRecalc["importe"]), this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal);
                                                                        Saldo = Math.Round(Saldo + SubImp, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal);
                                                                        string Sql = "UPDATE cajas_movim SET saldo=" + Lfx.Types.Formatting.FormatCurrencySql(Saldo, this.Workspace.CurrentConfig.Currency.DecimalPlacesFinal, true) + " WHERE id_movim=" + MovRecalc["id_movim"].ToString();
                                                                        Conexion.Execute(Sql);
                                                                }
                                                                Conexion.Commit();
                                                                return this.RefreshList();
                                                        }
                                                        */
                                                        if (System.Convert.ToString(Movimiento["comprob"]).Length > 0)
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Movimiento["comprob"])));
                                                        else if (this.Workspace.SlowLink == false && Lfx.Data.DataBase.ConvertDBNullToZero(Movimiento["id_comprob"]) != 0)
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lbl.Comprobantes.Comprobante.NumeroCompleto(this.Workspace.DefaultDataView, Lfx.Data.DataBase.ConvertDBNullToZero(Movimiento["id_comprob"]))));
                                                        else if (this.Workspace.SlowLink == false && Lfx.Data.DataBase.ConvertDBNullToZero(Movimiento["id_recibo"]) != 0)
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lbl.Comprobantes.Comprobante.FacturasDeUnRecibo(this.Workspace.DefaultDataView, Lfx.Data.DataBase.ConvertDBNullToZero(Movimiento["id_recibo"]))));
                                                        else
                                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, ""));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Movimiento["nombre_visible"])));
                                                        itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Movimiento["obs"])));
                                                        if (CurItem != null) {
                                                                if (itm.Text == CurItem.Text) {
                                                                        itm.Selected = true;
                                                                        itm.Focused = true;
                                                                }
                                                        }
                                                }
                                        }

                                        EtiquetaIngresos.Text = Lfx.Types.Formatting.FormatCurrency(Ingresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        EtiquetaEgresos.Text = Lfx.Types.Formatting.FormatCurrency(Egresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        if (m_Cliente > 0) {
                                                EtiquetaTransporte.Text = Lfx.Types.Formatting.FormatCurrency(0, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                EtiquetaSaldo.Text = Lfx.Types.Formatting.FormatCurrency(Ingresos - Egresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        } else {
                                                EtiquetaTransporte.Text = Lfx.Types.Formatting.FormatCurrency(Transporte, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                                EtiquetaSaldo.Text = Lfx.Types.Formatting.FormatCurrency(Transporte + Ingresos - Egresos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        }

                                        if (m_Caja > 0)
                                                this.Text = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cajas WHERE id_caja=" + m_Caja.ToString());
                                        else
                                                this.Text = "Caja";

                                        ItemList.EndUpdate();
                                        ItemList.Focus();

                                        if (ItemList.Items.Count > 0) {
                                                ItemList.Items[0].Focused = true;
                                                ItemList.Items[0].Selected = true;
                                        }
                                }
                        }

                        return mostrarReturn;
                }


                public override Lfx.Types.OperationResult Filter()
                {
                        Cajas.Filtros FormularioFiltros = new Cajas.Filtros();
                        FormularioFiltros.EntradaCaja.Text = m_Caja.ToString();
                        FormularioFiltros.Fechas.Rango = m_Fechas;

                        if (m_Cliente == -1)
                                FormularioFiltros.txtPersona.Text = FormularioFiltros.txtPersona.FreeTextCode;
                        else
                                FormularioFiltros.txtPersona.TextInt = m_Cliente;
                        if (m_Concepto == -1)
                                FormularioFiltros.txtConcepto.Text = FormularioFiltros.txtConcepto.FreeTextCode;
                        else
                                FormularioFiltros.txtConcepto.TextInt = m_Concepto;

                        FormularioFiltros.txtTipoConcepto.TextKey = m_TipoConcepto.ToString();

                        FormularioFiltros.txtDireccion.TextKey = m_Direccion.ToString();
                        if (m_Concepto == -1)
                                FormularioFiltros.txtConcepto.TextDetail = m_ConceptoStr.ToString();

                        FormularioFiltros.Owner = this;
                        if (FormularioFiltros.ShowDialog() == DialogResult.OK) {
                                m_Caja = FormularioFiltros.EntradaCaja.TextInt;
                                m_Fechas = FormularioFiltros.Fechas.Rango;
                                if (m_Caja > 0)
                                        EtiquetaTitulo.Text = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cajas WHERE id_caja=" + m_Caja.ToString());
                                else
                                        EtiquetaTitulo.Text = "Movimientos de Cajas";
                                if (FormularioFiltros.txtPersona.Text == FormularioFiltros.txtPersona.FreeTextCode)
                                        m_Cliente = -1;
                                else
                                        m_Cliente = FormularioFiltros.txtPersona.TextInt;
                                if (FormularioFiltros.txtConcepto.Text == FormularioFiltros.txtConcepto.FreeTextCode)
                                        m_Concepto = -1;
                                else
                                        m_Concepto = FormularioFiltros.txtConcepto.TextInt;
                                m_Direccion = Lfx.Types.Parsing.ParseInt(FormularioFiltros.txtDireccion.TextKey);
                                if (m_Concepto == -1)
                                        m_ConceptoStr = FormularioFiltros.txtConcepto.TextDetail;

                                m_TipoConcepto = Lfx.Types.Parsing.ParseInt(FormularioFiltros.txtTipoConcepto.TextKey);

                                return RefreshList();
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }


                public override Lfx.Types.OperationResult Print()
                {
                        Cajas.Listado FormularioListado = new Cajas.Listado();
                        FormularioListado.MdiParent = this.MdiParent;
                        FormularioListado.Show();
                        FormularioListado.m_Caja = m_Caja;
                        FormularioListado.m_Fechas = m_Fechas;
                        FormularioListado.m_Concepto = m_Concepto;
                        FormularioListado.m_TipoConcepto = m_TipoConcepto;
                        FormularioListado.m_Persona = m_Cliente;
                        FormularioListado.m_Direccion = m_Direccion;
                        FormularioListado.RefreshList();
                        return new Lfx.Types.SuccessOperationResult();
                }


                private void cmdIngreso_Click(object sender, System.EventArgs e)
                {
                        if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "accounts.write")) {
                                Cajas.IngresoEgreso FormularioIngreso = new Cajas.IngresoEgreso();
                                FormularioIngreso.Caja = m_Caja;
                                FormularioIngreso.SaldoActual = Lfx.Types.Parsing.ParseCurrency(EtiquetaSaldo.Text);
                                FormularioIngreso.Ingreso = true;
                                if (FormularioIngreso.ShowDialog() == DialogResult.OK)
                                        this.RefreshList();
                        }
                }


                private void cmdEgreso_Click(object sender, System.EventArgs e)
                {
                        if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "accounts.write")) {
                                Cajas.IngresoEgreso FormularioEgreso = new Cajas.IngresoEgreso();
                                FormularioEgreso.Caja = m_Caja;
                                FormularioEgreso.SaldoActual = Lfx.Types.Parsing.ParseCurrency(EtiquetaSaldo.Text);
                                FormularioEgreso.Ingreso = false;
                                if (FormularioEgreso.ShowDialog() == DialogResult.OK)
                                        this.RefreshList();
                        }
                }


                private void Inicio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F3:
                                        e.Handled = true;
                                        if (cmdIngreso.Enabled && cmdIngreso.Visible)
                                                cmdIngreso.PerformClick();
                                        break;
                                case Keys.F4:
                                        e.Handled = true;
                                        if (cmdEgreso.Enabled && cmdEgreso.Visible)
                                                cmdEgreso.PerformClick();
                                        break;
                                case Keys.F5:
                                        e.Handled = true;
                                        if (cmdMovim.Enabled && cmdMovim.Visible)
                                                cmdMovim.PerformClick();
                                        break;
                                case Keys.F7:
                                        e.Handled = true;
                                        if (cmdArqueo.Enabled && cmdArqueo.Visible)
                                                cmdArqueo.PerformClick();
                                        break;
                        }

                }


                private void Inicio_Activated(object sender, System.EventArgs e)
                {
                        this.RefreshList();
                }


                private void cmdMovim_Click(object sender, System.EventArgs e)
                {
                        if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "accounts.write")) {
                                Cajas.Movimiento FormularioMovimiento = new Cajas.Movimiento();
                                FormularioMovimiento.txtOrigen.TextInt = m_Caja;
                                FormularioMovimiento.txtConcepto.Text = "30000";
                                if (FormularioMovimiento.ShowDialog() == DialogResult.OK)
                                        this.RefreshList();
                        }
                }


                private void cmdArqueo_Click(object sender, System.EventArgs e)
                {
                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Si confirma que el saldo de la cuenta es el indicado se asentará una marca de 'Arqueo', para su propio control.", "¿Confirma que el saldo de la cuenta es de $ " + EtiquetaSaldo.Text + "?");
                        Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                Lbl.Cajas.Caja Caja = new Lbl.Cajas.Caja(this.Workspace.DefaultDataView, m_Caja);
                                Caja.Movimiento(false, null, "Arqueo - Saldo: " + EtiquetaSaldo.Text, new Lbl.Personas.Persona(Caja.DataView, this.Workspace.CurrentUser.Id), 0, null, null, null, null);
                                this.RefreshList();
                        } else {
                                Lui.Forms.MessageBox.Show("Verifique el saldo de la cuenta y si es necesario realice un ajuste.", "Arqueo");
                        }
                }
        }
}