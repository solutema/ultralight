// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Bancos.Cheques
{
        public partial class Inicio : Lui.Forms.ListingForm
        {

                protected internal int m_Estado = -2;
                protected internal int m_Banco, m_Cliente, m_Sucursal;
                protected internal bool m_Emitidos = false;
                protected internal double Total = 0, SinCobrar = 0;
                protected internal Lfx.Types.DateRange m_Fechas = new Lfx.Types.DateRange("*");

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "bancos_cheques";
                        KeyField = new Lfx.Data.FormField("bancos_cheques.id_cheque", "Cód.", Lfx.Data.InputFieldTypes.Serial, 20);
                        OrderBy = "bancos_cheques.fecha DESC";
                        FormFields = new Lfx.Data.FormField[]
			{
                                new Lfx.Data.FormField("bancos_cheques.prefijo", "Prefijo", Lfx.Data.InputFieldTypes.Text, 80),
				new Lfx.Data.FormField("bancos_cheques.numero", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("bancos_cheques.fechaemision", "Fecha Emision", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("bancos_cheques.emitidopor", "Emitido por", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("bancos_cheques.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("bancos_cheques.fechacobro", "Fecha de Cobro", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("bancos_cheques.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("bancos_cheques.id_banco", "Banco", Lfx.Data.InputFieldTypes.Relation, 120),
				new Lfx.Data.FormField("bancos_cheques.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
                                new Lfx.Data.FormField("bancos_cheques.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 320)
			};
                        Listado.CheckBoxes = true;
                        BotonFiltrar.Visible = true;
                }

                public bool Emitidos
                {
                        get
                        {
                                return m_Emitidos;
                        }
                        set
                        {
                                m_Emitidos = value;

                                if (m_Emitidos == false) {
                                        DepositarPagar.Text = "Depositar";
                                        BotonCrear.Text = "Efectivizar";
                                } else {
                                        DepositarPagar.Text = "Pagar";
                                        BotonCrear.Text = "Emitir";
                                }
                        }
                }

                public override void RefreshList()
                {
                        string TextoSql;

                        if (this.Emitidos)
                                TextoSql = "emitido=1";
                        else
                                TextoSql = "emitido=0";

                        if (m_Estado == -2)
                                TextoSql += " AND estado IN (0, 5)";
                        if (m_Estado >= 0)
                                TextoSql += " AND estado=" + m_Estado.ToString();

                        if (m_Sucursal > 0)
                                TextoSql += " AND id_sucursal=" + m_Sucursal.ToString();

                        if (m_Banco > 0)
                                TextoSql += " AND id_banco=" + m_Banco.ToString();

                        if (m_Cliente > 0)
                                TextoSql += " AND id_cliente=" + m_Cliente.ToString();

                        if (m_Fechas.HasRange)
                                TextoSql += " AND fechaemision BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + "  00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59'";

                        this.CurrentFilter = TextoSql;

                        base.RefreshList();
                }

                public override void ItemAdded(ListViewItem itm)
                {
                        itm.SubItems[1].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[1].Text).ToString("0000");
                        itm.SubItems[2].Text = Lfx.Types.Parsing.ParseInt(itm.SubItems[2].Text).ToString("00000000");
                        
                        Total += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[5].Text);
                        itm.SubItems[8].Text = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM bancos WHERE id_banco=" + Lfx.Types.Parsing.ParseInt(itm.SubItems[8].Text).ToString());
                        
                        switch (itm.SubItems[9].Text) {
                                case "0":
                                case "-":
                                case "":
                                        if (m_Emitidos)
                                                itm.SubItems[9].Text = "A pagar";
                                        else
                                                itm.SubItems[9].Text = "A cobrar";
                                        if (string.Compare(Lfx.Types.Formatting.FormatDateTimeSql(itm.SubItems[6].Text).ToString(), Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now).ToString()) <= 0)
                                                itm.ForeColor = System.Drawing.Color.Green;
                                        else
                                                itm.ForeColor = System.Drawing.Color.Black;
                                        SinCobrar += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[5].Text);
                                        break;
                                case "5":
                                        itm.SubItems[9].Text = "Depositado";
                                        SinCobrar += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[5].Text);
                                        break;
                                case "10":
                                        if (m_Emitidos)
                                                itm.SubItems[9].Text = "Pagado";
                                        else
                                                itm.SubItems[9].Text = "Cobrado";
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                        break;
                                case "11":
                                        itm.SubItems[9].Text = "Entregado";
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                        break;
                                case "90":
                                        itm.SubItems[9].Text = "Anulado";
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                        itm.Font = new Font(itm.Font, FontStyle.Strikeout);
                                        break;
                        }
                }

                public override Lfx.Types.OperationResult OnCreate()
                {
                        if (this.Emitidos == false) {
                                return Efectivizar();
                        } else {
                                this.Workspace.RunTime.Execute("CREAR CHEQUE");
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override Lfx.Types.OperationResult OnDelete(int[] itemIds)
                {
                        if (Lui.Login.LoginData.ValidateAccess(this.Workspace.CurrentUser, "bancos.cheques.delete")) {
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("¿Desea anular los cheques seleccionados?", "Pregunta");
                                if (Pregunta.ShowDialog() == DialogResult.OK) {
                                        Lfx.Data.SqlUpdateBuilder Actua = new Lfx.Data.SqlUpdateBuilder("bancos_cheques");
                                        Actua.Fields.AddWithValue("estado", 90);
                                        Actua.WhereClause = new Lfx.Data.SqlWhereBuilder("id_cheque IN (" + Lfx.Types.Strings.Ints2CSV(itemIds, ",") + ")");
                                        this.DataView.Execute(Actua);
                                        //this.Workspace.DefaultDataBase.Execute("UPDATE bancos_cheques SET estado=90 WHERE id_cheque IN (" + Lfx.Types.Strings.Ints2CSV(itemIds, ",") + ")");
                                        this.RefreshList();
                                        return new Lfx.Types.SuccessOperationResult();
                                }
                        }
                        return new Lfx.Types.CancelOperationResult();
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult filtrarReturn = base.OnFilter();
                        if (filtrarReturn.Success == true) {
                                Bancos.Cheques.Filtros FormularioFiltros = new Bancos.Cheques.Filtros();
                                FormularioFiltros.Workspace = this.Workspace;
                                if (this.Emitidos) {
                                        FormularioFiltros.EntradaEstado.SetData = new string[] {
                                        "Todos|-1",
                                        "A pagar y depositados|-2",
                                        "A pagar|0",
                                        "Depositado|5",
                                        "Pagado|10",
                                        "Anulado|90"};
                                } else {
                                        FormularioFiltros.EntradaEstado.SetData = new string[] {
                                        "Todos|-1",
                                        "A cobrar y depositados|-2",
                                        "A cobrar|0",
                                        "Depositado|5",
                                        "Cobrado|10",
                                        "Anulado|90"};
                                }
                                FormularioFiltros.EntradaEstado.TextKey = m_Estado.ToString();
                                FormularioFiltros.EntradaSucursal.TextInt = m_Sucursal;
                                FormularioFiltros.EntradaBanco.TextInt = m_Banco;
                                FormularioFiltros.EntradaPersona.TextInt = m_Cliente;
                                FormularioFiltros.EntradaFechas.Rango = m_Fechas;

                                FormularioFiltros.ShowDialog();
                                if (FormularioFiltros.DialogResult == DialogResult.OK) {
                                        m_Estado = Lfx.Types.Parsing.ParseInt(FormularioFiltros.EntradaEstado.TextKey);
                                        m_Sucursal = FormularioFiltros.EntradaSucursal.TextInt;
                                        m_Banco = FormularioFiltros.EntradaBanco.TextInt;
                                        m_Cliente = FormularioFiltros.EntradaPersona.TextInt;
                                        m_Fechas = FormularioFiltros.EntradaFechas.Rango;
                                        RefreshList();
                                        filtrarReturn.Success = true;
                                } else {
                                        filtrarReturn.Success = false;
                                }
                        }
                        return filtrarReturn;
                }

                public override void Fill(Lfx.Data.SqlSelectBuilder command)
                {
                        Total = 0;
                        SinCobrar = 0;
                        base.Fill(command);

                        EntradaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaSinCobrar.Text = Lfx.Types.Formatting.FormatCurrency(SinCobrar, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }

                private Lfx.Types.OperationResult Efectivizar()
                {
                        Lfc.Bancos.Cheques.Efectivizar Efectivizar = new Lfc.Bancos.Cheques.Efectivizar();
                        Efectivizar.Workspace = this.Workspace;

                        double Total = 0;
                        int Cantidad = 0;
                        System.Text.StringBuilder ListaCheques = new System.Text.StringBuilder();
                        System.Text.StringBuilder ListaChequesId = new System.Text.StringBuilder();

                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (itm.Checked && (itm.SubItems[9].Text == "A cobrar" || itm.SubItems[9].Text == "Depositado")) {
                                        Cantidad++;
                                        Lfx.Data.Row Cheque = this.Workspace.DefaultDataBase.Row("bancos_cheques", "id_cheque", Lfx.Types.Parsing.ParseInt(itm.Text));
                                        Total += System.Convert.ToDouble(Cheque["importe"]);
                                        if (ListaCheques.Length == 0) {
                                                ListaCheques.Append(System.Convert.ToString(Cheque["numero"]));
                                                ListaChequesId.Append(Cheque["id_cheque"].ToString());
                                        } else {
                                                ListaCheques.Append("," + System.Convert.ToString(Cheque["numero"]));
                                                ListaChequesId.Append("," + Cheque["id_cheque"].ToString());
                                        }
                                }
                        }

                        if (ListaChequesId.Length > 0 && Total > 0) {
                                Efectivizar.txtCantidad.Text = Cantidad.ToString();
                                Efectivizar.txtSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                Efectivizar.ListaCheques = ListaCheques.ToString();
                                Efectivizar.ListaChequesId = ListaChequesId.ToString();
                                Efectivizar.ShowDialog();
                                this.RefreshList();
                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.FailureOperationResult("Por favor marque uno o más cheques a efectivizar.");
                        }
                }

                private void FormCuentaCheques_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F5:
                                        e.Handled = true;
                                        if (DepositarPagar.Visible && DepositarPagar.Enabled)
                                                DepositarPagar.PerformClick();
                                        break;
                        }
                }

                private void DepositarPagar_Click(object sender, System.EventArgs e)
                {
                        if (this.Emitidos == false) {
                                //Depositar
                                int[] Codigos = this.CodigosSeleccionados;
                                if (Codigos == null) {
                                        Lui.Forms.MessageBox.Show("Debe seleccionar uno o más cheques.", "Error");
                                } else {
                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Al depositar un cheque en una cuenta bancaria propia, puede marcarlo como depositado para control interno.\nSirve sólamente para depositos en cuentas propias. Para depósitos en cuentas de terceros utilice la opción 'Efectivizar'.", "¿Desea marcar los cheques seleccionados como depositados?");
                                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                                this.Workspace.DefaultDataBase.Execute("UPDATE bancos_cheques SET estado=5 WHERE estado=0 AND id_cheque IN (" + Lfx.Types.Strings.Ints2CSV(Codigos, ",") + ")");
                                                this.RefreshList();
                                        }
                                }
                        } else {
                                Lfx.Types.OperationResult Res = this.Pagar();
                                if (Res.Success == false && Res.Message != null)
                                        Lui.Forms.MessageBox.Show(Res.Message, "Error");
                        }
                }

                private Lfx.Types.OperationResult Pagar()
                {
                        int IdCuentaOrigen = 0;
                        System.Collections.ArrayList Cheques = new System.Collections.ArrayList();
                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (itm.Checked && (itm.SubItems[9].Text == "A pagar")) {
                                        Cheques.Add(itm.Text);
                                        if (IdCuentaOrigen == 0)
                                                IdCuentaOrigen = this.Workspace.DefaultDataBase.FieldInt("SELECT id_cuenta FROM chequeras WHERE (SELECT numero FROM bancos_cheques WHERE id_cheque=" + itm.Text + ") BETWEEN desde AND hasta AND estado=1");
                                }
                        }

                        if (Cheques.Count > 0) {
                                Bancos.Cheques.Pagar FormPagar = new Bancos.Cheques.Pagar();
                                FormPagar.Workspace = this.Workspace;
                                FormPagar.EntradaCuentaOrigen.TextInt = IdCuentaOrigen;
                                if (FormPagar.Mostrar(Cheques) == DialogResult.OK) {
                                        this.RefreshList();
                                        return new Lfx.Types.SuccessOperationResult();
                                } else {
                                        return new Lfx.Types.OperationResult(false);
                                }
                        } else {
                                return new Lfx.Types.FailureOperationResult("Por favor marque uno o más cheques a pagar.");
                        }
                }
        }
}