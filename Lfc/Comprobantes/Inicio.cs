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

namespace Lfc.Comprobantes
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                protected internal string m_Tipo = "FNCND", m_Letra = "*";
                protected internal Lfx.Types.DateRange m_Fechas;
                protected internal string m_Estado = "0";
                protected internal int m_Sucursal, m_FormaPago, m_Cliente, m_Vendedor, m_Anuladas = 1, m_PV = 0;
                protected internal double m_MontoDesde = 0, m_MontoHasta = 0;

                public Inicio()
                        : base()
                {
                        InitializeComponent();

                        m_Fechas = new Lfx.Types.DateRange("mes-0");
                        DataTableName = "facturas";
                        KeyField = new Lfx.Data.FormField("facturas.id_factura", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        ExtraDataTableNames = "personas";
                        Relations = "facturas.id_cliente=personas.id_persona";
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("facturas.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 40),
				new Lfx.Data.FormField("facturas.numero", "Número", Lfx.Data.InputFieldTypes.Integer, 96, "00000000"),
				new Lfx.Data.FormField("facturas.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("facturas.total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("facturas.impresa", "Impresa", Lfx.Data.InputFieldTypes.Bool, 0),
				new Lfx.Data.FormField("facturas.anulada", "Anulada", Lfx.Data.InputFieldTypes.Bool, 0),
				new Lfx.Data.FormField("facturas.total-facturas.cancelado", "Pendiente", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("facturas.id_vendedor", "Vendedor", Lfx.Data.InputFieldTypes.Relation, 160),
				new Lfx.Data.FormField("facturas.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 160)
			};
                        OrderBy = "facturas.id_factura DESC";

                        BotonFiltrar.Visible = true;
                        BotonImprimir.Visible = true;
                }

                public string Tipo
                {
                        get
                        {
                                return m_Tipo;
                        }
                        set
                        {
                                m_Tipo = value;
                        }
                }

                public string Letra
                {
                        get
                        {
                                return m_Letra;
                        }
                        set
                        {
                                m_Letra = value;
                        }
                }

                public override Lfx.Types.OperationResult OnPrint(bool selectPrinter)
                {
                        Comprobantes.FormComprobantesListado FormListado = new Comprobantes.FormComprobantesListado();
                        FormListado.Workspace = this.Workspace;
                        FormListado.MdiParent = this.MdiParent;
                        FormListado.m_Tipo = m_Tipo;
                        FormListado.m_Letra = m_Letra;
                        FormListado.m_Cliente = m_Cliente;
                        FormListado.m_Vendedor = m_Vendedor;
                        FormListado.m_Sucursal = m_Sucursal;
                        FormListado.m_Anuladas = m_Anuladas;
                        FormListado.m_PV = m_PV;
                        FormListado.m_FormaPago = m_FormaPago;
                        FormListado.m_MontoDesde = m_MontoDesde;
                        FormListado.m_MontoHasta = m_MontoHasta;

                        if (m_Estado == "0")
                                FormListado.m_Estado = "3";
                        else
                                FormListado.m_Estado = m_Estado;

                        FormListado.m_Fechas = m_Fechas;
                        FormListado.Show();
                        FormListado.RefreshList();
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult ResultadoFiltrar = base.OnFilter();

                        if (ResultadoFiltrar.Success == true) {
                                Comprobantes.Filtros FormFiltros = new Comprobantes.Filtros();

                                FormFiltros.Workspace = this.Workspace;
                                FormFiltros.txtTipo.TextKey = m_Tipo;
                                FormFiltros.txtPV.Text = m_PV.ToString();
                                FormFiltros.txtLetra.TextKey = m_Letra;
                                FormFiltros.txtSucursal.TextInt = m_Sucursal;
                                FormFiltros.txtFormaPago.TextInt = m_FormaPago;
                                FormFiltros.txtCliente.TextInt = m_Cliente;
                                FormFiltros.txtVendedor.TextInt = m_Vendedor;
                                FormFiltros.EntradaFechas.Rango = m_Fechas;
                                FormFiltros.txtEstado.TextKey = m_Estado;
                                FormFiltros.txtAnuladas.TextKey = m_Anuladas.ToString();
                                FormFiltros.EntradaMontoDesde.Text = Lfx.Types.Formatting.FormatCurrency(m_MontoDesde, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                FormFiltros.EntradaMontoHasta.Text = Lfx.Types.Formatting.FormatCurrency(m_MontoHasta, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                FormFiltros.Owner = this;
                                FormFiltros.ShowDialog();

                                if (FormFiltros.DialogResult == DialogResult.OK) {
                                        m_Sucursal = FormFiltros.txtSucursal.TextInt;
                                        m_FormaPago = FormFiltros.txtFormaPago.TextInt;
                                        m_Cliente = FormFiltros.txtCliente.TextInt;
                                        m_Vendedor = FormFiltros.txtVendedor.TextInt;
                                        m_Fechas = FormFiltros.EntradaFechas.Rango;
                                        m_Estado = FormFiltros.txtEstado.TextKey;
                                        m_Anuladas = Lfx.Types.Parsing.ParseInt(FormFiltros.txtAnuladas.TextKey);
                                        m_Tipo = FormFiltros.txtTipo.TextKey;
                                        m_PV = Lfx.Types.Parsing.ParseInt(FormFiltros.txtPV.Text);
                                        m_MontoDesde = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaMontoDesde.Text);
                                        m_MontoHasta = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaMontoHasta.Text);
                                        m_Letra = FormFiltros.txtLetra.TextKey;

                                        this.RefreshList();
                                        ResultadoFiltrar.Success = true;
                                } else {
                                        ResultadoFiltrar.Success = false;
                                }
                                FormFiltros = null;
                        }

                        return ResultadoFiltrar;
                }

                public override Lfx.Types.OperationResult OnCreate()
                {
                        switch (m_Tipo) {
                                case "F":
                                        if (m_Letra == "*")
                                                this.Workspace.RunTime.Execute("CREAR " + m_Letra);
                                        else
                                                this.Workspace.RunTime.Execute("CREAR B");
                                        break;
                                case "NC":
                                case "NCD":
                                        if (m_Letra == "*")
                                                this.Workspace.RunTime.Execute("CREAR NC" + m_Letra);
                                        else
                                                this.Workspace.RunTime.Execute("CREAR NCB");
                                        break;
                                case "ND":
                                        if (m_Letra == "*")
                                                this.Workspace.RunTime.Execute("CREAR ND" + m_Letra);
                                        else
                                                this.Workspace.RunTime.Execute("CREAR NDB");
                                        break;
                                default:
                                        this.Workspace.RunTime.Execute("CREAR " + m_Tipo);
                                        break;
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void BeginRefreshList()
                {
                        string FiltroTemp = null;

                        if (System.Text.RegularExpressions.Regex.IsMatch(SearchText, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$")) {
                                this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(SearchText).ToString();
                        } else if (System.Text.RegularExpressions.Regex.IsMatch(SearchText, @"^[0-3]\d(-|/)[0-1]\d$")) {
                                this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(SearchText + System.DateTime.Now.ToString("yyyy")).ToString();
                        }

                        FiltroTemp = "compra=0";

                        switch (m_Tipo) {
                                case "":
                                case "*":
                                        Listado.Columns[8].Width = 0;
                                        break;

                                case "NC":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                FiltroTemp += " AND facturas.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM')";
                                        else
                                                FiltroTemp += " AND facturas.tipo_fac='NC" + m_Letra + "'";
                                        break;

                                case "ND":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                FiltroTemp += " AND facturas.tipo_fac IN ('NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroTemp += " AND facturas.tipo_fac='ND" + m_Letra + "'";
                                        break;

                                case "NCD":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                FiltroTemp += " AND facturas.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroTemp += " AND (facturas.tipo_fac='NC" + m_Letra + "' OR facturas.tipo_fac='ND" + m_Letra + "')";
                                        break;

                                case "F":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                FiltroTemp += " AND facturas.tipo_fac IN ('A', 'B', 'C', 'E', 'M')";
                                        else
                                                FiltroTemp += " AND facturas.tipo_fac='" + m_Letra + "'";
                                        break;

                                case "T":
                                        Listado.Columns[8].Width = 80;
                                        FiltroTemp += " AND facturas.tipo_fac='T'";
                                        break;

                                case "FNCND":
                                        Listado.Columns[8].Width = 0;
                                        if (m_Letra == "*")
                                                FiltroTemp += " AND facturas.tipo_fac IN ('A', 'B', 'C', 'E', 'M', 'NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroTemp += " AND (facturas.tipo_fac='" + m_Letra + "' OR facturas.tipo_fac='NC" + m_Letra + "' OR facturas.tipo_fac='ND" + m_Letra + "')";
                                        break;

                                default:
                                        if (m_Letra == "*")
                                                FiltroTemp += " AND facturas.tipo_fac='" + m_Tipo + "'";
                                        else
                                                FiltroTemp += " AND facturas.tipo_fac='" + m_Tipo + m_Letra + "'";
                                        break;
                        }

                        if (m_Vendedor > 0)
                                FiltroTemp += " AND (facturas.id_vendedor='" + m_Vendedor.ToString() + "')";

                        if (SearchText != null && SearchText.Length == 0) {
                                if (m_Sucursal > 0)
                                        FiltroTemp += " AND (facturas.id_sucursal='" + m_Sucursal.ToString() + "')";

                                if (m_FormaPago > 0)
                                        FiltroTemp += " AND (facturas.id_formapago='" + m_FormaPago.ToString() + "')";

                                if (m_Cliente > 0)
                                        FiltroTemp += " AND (facturas.id_cliente='" + m_Cliente.ToString() + "')";

                                if (m_PV > 0)
                                        FiltroTemp += " AND (facturas.pv='" + m_PV.ToString() + "')";

                                if (m_Fechas.HasRange)
                                        FiltroTemp += " AND (fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59')";
                        }

                        switch (m_Estado) {
                                case "0":
                                        // Nada
                                        break;
                                case "1":
                                        FiltroTemp += " AND impresa=1 AND (cancelado>=total) AND total>0";
                                        break;
                                case "2":
                                        FiltroTemp += " AND impresa=1 AND (cancelado<total) AND total>0";
                                        break;
                                case "3":
                                        FiltroTemp += " AND impresa=1";
                                        break;
                        }

                        if (m_Anuladas == 0)
                                FiltroTemp += " AND anulada=0";

                        if(m_MontoDesde != 0 && m_MontoHasta != 0)
                                FiltroTemp += " AND total BETWEEN " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde) + " AND " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta);
                        else if(m_MontoDesde != 0)
                                FiltroTemp += " AND total>=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde);
                        else if (m_MontoHasta != 0)
                                FiltroTemp += " AND total<=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta);

                        this.CurrentFilter = FiltroTemp;
                }

                public override Lfx.Types.OperationResult OnEdit(int lCodigo)
                {
                        string sTipo = this.Workspace.DefaultDataBase.FieldString("SELECT tipo_fac FROM facturas WHERE id_factura=" + lCodigo.ToString());
                        this.Workspace.RunTime.Execute("EDITAR " + sTipo + " " + lCodigo.ToString());
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void Fill(Lfx.Data.SqlSelectBuilder command)
                {
                        base.Fill(command);
                        double dTotal = 0;
                        double dPendiente = 0;

                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (itm.SubItems[7].Text != "1" && itm.SubItems[6].Text != "0") {
                                        // SubItems(7) == 1 significa que el comprobante está anulado
                                        // SubItems(6) != 0 significa que el comprobante está impreso
                                        if (itm.SubItems[1].Text.Length >= 2 && itm.SubItems[1].Text.Substring(0, 2) == "NC")
                                                dTotal -= Lfx.Types.Parsing.ParseCurrency(itm.SubItems[5].Text);
                                        else
                                                dTotal += Lfx.Types.Parsing.ParseCurrency(itm.SubItems[5].Text);
                                }

                                if (Lfx.Types.Parsing.ParseBool(itm.SubItems[7].Text)) {
                                        // Si está anulada, la tacho
                                        itm.Font = new Font("Bitstream Vera Sans", 10, FontStyle.Strikeout);
                                } else if (Lfx.Types.Parsing.ParseBool(itm.SubItems[6].Text) == false) {
                                        // No impresa, en gris
                                        itm.ForeColor = System.Drawing.Color.Gray;
                                } else if (m_Tipo != "PS" && Lfx.Types.Parsing.ParseCurrency(itm.SubItems[8].Text) > 0) {
                                        // Impaga, en rojo
                                        dPendiente = dPendiente + Lfx.Types.Parsing.ParseCurrency(itm.SubItems[8].Text.Replace(",", "."));
                                        itm.SubItems[8].Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(itm.SubItems[8].Text.Replace(",", ".")), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        itm.ForeColor = System.Drawing.Color.Red;
                                }

                                int IdVendedor = Lfx.Types.Parsing.ParseInt(itm.SubItems[9].Text);
                                if (IdVendedor > 0) {
                                        Lfx.Data.Row Vend = this.DataView.Tables["personas"].FastRows[IdVendedor];
                                        if (Vend != null)
                                                itm.SubItems[9].Text = Vend.Fields["nombre_visible"].Value.ToString();
                                }
                        }

                        txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(dTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtPendiente.Text = Lfx.Types.Formatting.FormatCurrency(dPendiente, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }

                private void FormComprobantesInicio_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        m_Sucursal = this.Workspace.CurrentConfig.Company.CurrentBranch;
                }
        }
}