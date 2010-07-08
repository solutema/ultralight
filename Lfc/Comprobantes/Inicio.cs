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
                        DataTableName = "comprob";
                        KeyField = new Lfx.Data.FormField("comprob.id_comprob", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("personas", "comprob.id_cliente=personas.id_persona"));
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("comprob.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 40),
				new Lfx.Data.FormField("CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0'))", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("comprob.total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("comprob.impresa", "Impresa", Lfx.Data.InputFieldTypes.Bool, 0),
				new Lfx.Data.FormField("comprob.anulada", "Anulada", Lfx.Data.InputFieldTypes.Bool, 0),
				new Lfx.Data.FormField("comprob.total-comprob.cancelado", "Pendiente", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("comprob.id_vendedor", "Vendedor", Lfx.Data.InputFieldTypes.Relation, 160),
				new Lfx.Data.FormField("comprob.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 160),
                                
			};
                        OrderBy = "comprob.id_comprob DESC";
                        ExtraSearchFields = new Lfx.Data.FormField[] {
                                new Lfx.Data.FormField("series", "Series")
                        };

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
                                        m_PV = Lfx.Types.Parsing.ParseInt(FormFiltros.txtPV.Text);
                                        m_MontoDesde = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaMontoDesde.Text);
                                        m_MontoHasta = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaMontoHasta.Text);
                                        m_Tipo = FormFiltros.txtTipo.TextKey;
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
                                                this.Workspace.RunTime.Execute("CREAR FB");
                                        else
                                                this.Workspace.RunTime.Execute("CREAR F" + m_Letra);
                                        break;
                                case "NC":
                                case "NCD":
                                        if (m_Letra == "*")
                                                this.Workspace.RunTime.Execute("CREAR NCB");
                                        else
                                                this.Workspace.RunTime.Execute("CREAR NC" + m_Letra);
                                        break;
                                case "ND":
                                        if (m_Letra == "*")
                                                this.Workspace.RunTime.Execute("CREAR NDB");
                                        else
                                                this.Workspace.RunTime.Execute("CREAR ND" + m_Letra);
                                        break;
                                default:
                                        this.Workspace.RunTime.Execute("CREAR " + m_Tipo);
                                        break;
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void BeginRefreshList()
                {
                        if (System.Text.RegularExpressions.Regex.IsMatch(SearchText, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$")) {
                                this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(SearchText).ToString();
                        } else if (System.Text.RegularExpressions.Regex.IsMatch(SearchText, @"^[0-3]\d(-|/)[0-1]\d$")) {
                                this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(SearchText + System.DateTime.Now.ToString("yyyy")).ToString();
                        }

                        this.CustomFilters.Clear();
                        this.CustomFilters.AddWithValue("compra", 0);

                        switch (m_Tipo) {
                                case "":
                                case "*":
                                        Listado.Columns[8].Width = 0;
                                        break;

                                case "NC":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM')");
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "NC" + m_Letra);
                                        break;

                                case "ND":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac IN ('NDA', 'NDB', 'NDC', 'NDE', 'NDM')");
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "ND" + m_Letra);
                                        break;

                                case "NCD":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')");
                                        else
                                                this.CustomFilters.AddWithValue("(comprob.tipo_fac='NC" + m_Letra + "' OR comprob.tipo_fac='ND" + m_Letra + "')");
                                        break;

                                case "F":
                                        Listado.Columns[8].Width = 80;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM')");
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "F" + m_Letra);
                                        break;

                                case "T":
                                        Listado.Columns[8].Width = 80;
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "T");
                                        break;

                                case "FNCND":
                                        Listado.Columns[8].Width = 0;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')");
                                        else
                                                this.CustomFilters.AddWithValue("(comprob.tipo_fac='F" + m_Letra + "' OR comprob.tipo_fac='NC" + m_Letra + "' OR comprob.tipo_fac='ND" + m_Letra + "')");
                                        break;

                                default:
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", m_Tipo);
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", m_Tipo + m_Letra);
                                        break;
                        }

                        if (m_Vendedor > 0)
                                this.CustomFilters.AddWithValue("comprob.id_vendedor", m_Vendedor);

                        if (SearchText != null && SearchText.Length == 0) {
                                if (m_Sucursal > 0)
                                        this.CustomFilters.AddWithValue("comprob.id_sucursal", m_Sucursal);

                                if (m_FormaPago > 0)
                                        this.CustomFilters.AddWithValue("comprob.id_formapago", m_FormaPago);

                                if (m_Cliente > 0)
                                        this.CustomFilters.AddWithValue("comprob.id_cliente", m_Cliente);

                                if (m_PV > 0)
                                        this.CustomFilters.AddWithValue("comprob.pv", m_PV);

                                if (m_Fechas.HasRange)
                                        this.CustomFilters.AddWithValue("(fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59')");
                        }

                        switch (m_Estado) {
                                case "0":
                                        // Nada
                                        break;
                                case "1":
                                        this.CustomFilters.AddWithValue("impresa=1 AND (cancelado>=total) AND total>0");
                                        break;
                                case "2":
                                        this.CustomFilters.AddWithValue("impresa=1 AND (cancelado<total) AND total>0");
                                        break;
                                case "3":
                                        this.CustomFilters.AddWithValue("impresa", 1);
                                        break;
                        }

                        if (m_Anuladas == 0)
                                this.CustomFilters.AddWithValue("anulada", 0);

                        if(m_MontoDesde != 0 && m_MontoHasta != 0)
                                this.CustomFilters.AddWithValue("total BETWEEN " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde) + " AND " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta));
                        else if(m_MontoDesde != 0)
                                this.CustomFilters.AddWithValue("total>=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde));
                        else if (m_MontoHasta != 0)
                                this.CustomFilters.AddWithValue("total<=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta));
                }

                public override Lfx.Types.OperationResult OnEdit(int lCodigo)
                {
                        string sTipo = this.DataBase.FieldString("SELECT tipo_fac FROM comprob WHERE id_comprob=" + lCodigo.ToString());
                        this.Workspace.RunTime.Execute("EDITAR " + sTipo + " " + lCodigo.ToString());
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void Fill(qGen.Select command)
                {
                        base.Fill(command);
                        double dTotal = 0;
                        double dPendiente = 0;

                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (itm.SubItems[7].Text != "Si" && itm.SubItems[6].Text != "No") {
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
                                        Lfx.Data.Row Vend = this.DataBase.Tables["personas"].FastRows[IdVendedor];
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