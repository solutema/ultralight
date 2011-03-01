#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
        public partial class Inicio : Lfc.FormularioListado
        {
                protected internal int m_Estado = -2;
                protected internal int m_Banco, m_Cliente, m_Sucursal;
                protected internal bool m_Emitidos = false;
                protected internal Lfx.Types.DateRange m_Fechas = new Lfx.Types.DateRange("*");

                public Inicio()
                {
                        this.ElementoTipo = typeof(Lbl.Bancos.Cheque);

                        InitializeComponent();

                        this.NombreTabla = "bancos_cheques";
                        this.KeyField = new Lfx.Data.FormField("bancos_cheques.id_cheque", "Cód.", Lfx.Data.InputFieldTypes.Serial, 20);
                        this.OrderBy = "bancos_cheques.fecha DESC";
                        this.Joins.Add(new qGen.Join("bancos", "bancos_cheques.id_banco=bancos.id_banco"));

                        Lbl.ColeccionCodigoDetalle EstadosCheques;
                        if (m_Emitidos) {
                                EstadosCheques = new Lbl.ColeccionCodigoDetalle()
                                { 
                                        {0, "A Pagar"},
                                        {5, "Depositado"},
                                        {10, "Pagado"},
                                        {11, "Entregado"},
                                        {90, "Anulado"}
                                };
                        } else {
                                EstadosCheques = new Lbl.ColeccionCodigoDetalle()
                                { 
                                        {0, "A Cobrar"},
                                        {5, "Depositado"},
                                        {10, "Cobrado"},
                                        {11, "Entregado"},
                                        {90, "Anulado"}
                                };
                        }

                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("bancos_cheques.numero", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("bancos_cheques.fechaemision", "Fecha Emision", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("bancos_cheques.emitidopor", "Emitido por", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("bancos_cheques.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("bancos_cheques.fechacobro", "Fecha de Cobro", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("bancos_cheques.concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("bancos.nombre", "Banco", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("bancos_cheques.estado", "Estado", 96, EstadosCheques),
                                new Lfx.Data.FormField("bancos_cheques.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 320)
			};

                        this.Contadores.Add(new Contador("Total", Lui.Forms.DataTypes.Currency));
                        this.Contadores.Add(new Contador("Sin Cobrar", Lui.Forms.DataTypes.Currency));

                        Listado.CheckBoxes = true;
                        this.HabilitarFiltrar = true;
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

                protected override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        itm.SubItems["numero"].Text = row.Fields["numero"].ValueInt.ToString("00000000");

                        decimal Importe = row.Fields["importe"].ValueDecimal;
                        this.Contadores[0].AddValue(Importe);
                        
                        switch (row.Fields["estado"].ValueInt) {
                                case 0:
                                        if (m_Emitidos)
                                                itm.SubItems["estado"].Text = "A pagar";
                                        else
                                                itm.SubItems["estado"].Text = "A cobrar";
                                        if (DateTime.Compare(row.Fields["fechacobro"].ValueDateTime, System.DateTime.Now) <= 0)
                                                itm.ForeColor = System.Drawing.Color.Green;
                                        else
                                                itm.ForeColor = System.Drawing.Color.Black;
                                        this.Contadores[1].AddValue(Importe);
                                        break;
                                case 5:
                                        itm.SubItems["estado"].Text = "Depositado";
                                        this.Contadores[1].AddValue(Importe);
                                        break;
                                case 10:
                                        if (m_Emitidos)
                                                itm.SubItems["estado"].Text = "Pagado";
                                        else
                                                itm.SubItems["estado"].Text = "Cobrado";
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                        break;
                                case 11:
                                        itm.SubItems["estado"].Text = "Entregado";
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                        break;
                                case 90:
                                        itm.SubItems["estado"].Text = "Anulado";
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
                                this.Workspace.RunTime.Execute("CREAR RCP");
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override Lfx.Types.OperationResult OnDelete(Lbl.ListaIds itemIds)
                {
                        this.Connection.BeginTransaction();
                        qGen.Update Actua = new qGen.Update("bancos_cheques");
                        Actua.Fields.AddWithValue("estado", 90);
                        Actua.WhereClause = new qGen.Where("id_cheque", qGen.ComparisonOperators.In, itemIds);
                        this.Connection.Execute(Actua);
                        this.Connection.Commit();

                        this.RefreshList();

                        return base.OnDelete(itemIds);
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult filtrarReturn = base.OnFilter();
                        if (filtrarReturn.Success == true) {
                                using (Bancos.Cheques.Filtros FormFiltros = new Bancos.Cheques.Filtros()) {
                                        FormFiltros.Connection = this.Connection;
                                        if (this.Emitidos) {
                                                FormFiltros.EntradaEstado.SetData = new string[] {
                                        "Todos|-1",
                                        "A pagar y depositados|-2",
                                        "A pagar|0",
                                        "Depositado|5",
                                        "Pagado|10",
                                        "Anulado|90"};
                                        } else {
                                                FormFiltros.EntradaEstado.SetData = new string[] {
                                        "Todos|-1",
                                        "A cobrar y depositados|-2",
                                        "A cobrar|0",
                                        "Depositado|5",
                                        "Cobrado|10",
                                        "Anulado|90"};
                                        }
                                        FormFiltros.EntradaEstado.TextKey = m_Estado.ToString();
                                        FormFiltros.EntradaSucursal.TextInt = m_Sucursal;
                                        FormFiltros.EntradaBanco.TextInt = m_Banco;
                                        FormFiltros.EntradaPersona.TextInt = m_Cliente;
                                        FormFiltros.EntradaFechas.Rango = m_Fechas;

                                        FormFiltros.ShowDialog();
                                        if (FormFiltros.DialogResult == DialogResult.OK) {
                                                m_Estado = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaEstado.TextKey);
                                                m_Sucursal = FormFiltros.EntradaSucursal.TextInt;
                                                m_Banco = FormFiltros.EntradaBanco.TextInt;
                                                m_Cliente = FormFiltros.EntradaPersona.TextInt;
                                                m_Fechas = FormFiltros.EntradaFechas.Rango;
                                                RefreshList();
                                                filtrarReturn.Success = true;
                                        } else {
                                                filtrarReturn.Success = false;
                                        }
                                }
                        }
                        return filtrarReturn;
                }

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();

                        if (this.Emitidos)
                                this.CustomFilters.AddWithValue("bancos_cheques.emitido", 1);
                        else
                                this.CustomFilters.AddWithValue("bancos_cheques.emitido", 0);

                        if (m_Estado == -2)
                                this.CustomFilters.AddWithValue("bancos_cheques.estado IN (0, 5)");
                        if (m_Estado >= 0)
                                this.CustomFilters.AddWithValue("bancos_cheques.estado", m_Estado);

                        if (m_Sucursal > 0)
                                this.CustomFilters.AddWithValue("bancos_cheques.id_sucursal", m_Sucursal);

                        if (m_Banco > 0)
                                this.CustomFilters.AddWithValue("bancos_cheques.id_banco", m_Banco);

                        if (m_Cliente > 0)
                                this.CustomFilters.AddWithValue("bancos_cheques.id_cliente", m_Cliente);

                        if (m_Fechas.HasRange)
                                this.CustomFilters.AddWithValue("bancos_cheques.fechaemision BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + "  00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59'");
                }

                private Lfx.Types.OperationResult Efectivizar()
                {
                        Lfc.Bancos.Cheques.Efectivizar Efectivizar = new Lfc.Bancos.Cheques.Efectivizar();

                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (itm.Checked && (itm.SubItems["estado"].Text == "A cobrar" || itm.SubItems["estado"].Text == "Depositado")) {
                                        int IdCheque = Lfx.Types.Parsing.ParseInt(itm.Text);
                                        Lbl.Bancos.Cheque Ch  =new Lbl.Bancos.Cheque(this.Connection, IdCheque);
                                        Efectivizar.EntradaSubTotal.ValueDecimal = Ch.Importe;
                                        Efectivizar.Cheque = Ch;
                                        if (Efectivizar.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                                return new Lfx.Types.CancelOperationResult();
                                }
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }


                private void DepositarPagar_Click(object sender, System.EventArgs e)
                {
                        if (this.Emitidos == false) {
                                //Depositar
                                Lbl.ListaIds Codigos = this.CodigosSeleccionados;
                                if (Codigos == null || Codigos.Count == 0) {
                                        Lui.Forms.MessageBox.Show("Debe seleccionar uno o más cheques.", "Error");
                                } else {
                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Al depositar un cheque en una cuenta bancaria propia, puede marcarlo como depositado para control interno.\nSirve sólamente para depositos en cajas propias. Para depósitos en cajas de terceros utilice la opción 'Efectivizar'.", "¿Desea marcar los cheques seleccionados como depositados?");
                                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                                this.Connection.BeginTransaction();
                                                qGen.Update Depo = new qGen.Update("bancos_cheques");
                                                Depo.Fields.AddWithValue("estado", 5);
                                                Depo.WhereClause = new qGen.Where();
                                                Depo.WhereClause.AddWithValue("estado", 0);
                                                Depo.WhereClause.AddWithValue("id_cheque", qGen.ComparisonOperators.In, Codigos);
                                                this.Connection.Execute(Depo);
                                                this.Connection.Commit();
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
                        int IdCajaOrigen = 0;
                        List<string> Cheques = new List<string>();
                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (itm.Checked && (itm.SubItems["estado"].Text == "A pagar")) {
                                        Cheques.Add(itm.Text);
                                        if (IdCajaOrigen == 0)
                                                IdCajaOrigen = this.Connection.FieldInt("SELECT id_caja FROM chequeras WHERE (SELECT numero FROM bancos_cheques WHERE id_cheque=" + itm.Text + ") BETWEEN desde AND hasta AND estado=1");
                                }
                        }

                        if (Cheques.Count > 0) {
                                Bancos.Cheques.Pagar FormPagar = new Bancos.Cheques.Pagar();
                                FormPagar.EntradaCajaOrigen.TextInt = IdCajaOrigen;
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