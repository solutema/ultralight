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
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public partial class Inicio : Lfc.FormularioListado
        {
                protected internal string m_Letra = "*";
                protected internal Lfx.Types.DateRange m_Fechas = new Lfx.Types.DateRange("mes-0");
                protected internal string m_Estado = "0";
                protected internal int m_Sucursal, m_FormaPago, m_Cliente, m_Vendedor, m_Anuladas = 1, m_PV = 0;
                protected internal decimal m_MontoDesde = 0, m_MontoHasta = 0;

                public Inicio()
                {
                        this.Definicion = new Lbl.Listados.Listado()
                        {
                                ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteConArticulos),

                                NombreTabla = "comprob",
                                KeyField = new Lfx.Data.FormField("comprob.id_comprob", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Joins = new qGen.JoinCollection() { new qGen.Join("personas", "comprob.id_cliente=personas.id_persona") },
                                FormFields = new Lfx.Data.FormFieldCollection()
			        {
				        new Lfx.Data.FormField("comprob.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 40),
				        new Lfx.Data.FormField("CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0')) AS numero", "Número", Lfx.Data.InputFieldTypes.Text, 120),
				        new Lfx.Data.FormField("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				        new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 320),
				        new Lfx.Data.FormField("comprob.total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
				        new Lfx.Data.FormField("comprob.impresa", "Impresa", Lfx.Data.InputFieldTypes.Bool, 0),
				        new Lfx.Data.FormField("comprob.anulada", "Anulada", Lfx.Data.InputFieldTypes.Bool, 0),
				        new Lfx.Data.FormField("comprob.total-comprob.cancelado AS pendiente", "Pendiente", Lfx.Data.InputFieldTypes.Currency, 96),
				        new Lfx.Data.FormField("comprob.id_vendedor", "Vendedor", Lfx.Data.InputFieldTypes.Relation, 160),
				        new Lfx.Data.FormField("comprob.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 160),
                                
			        },

                                ExtraSearchFields = new Lfx.Data.FormFieldCollection() {
                                        new Lfx.Data.FormField("series", "Series")
                                },

                                OrderBy = "comprob.id_comprob DESC"
                        };

                        this.Definicion.FormFields["total"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;
                        this.Definicion.FormFields["pendiente"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;

                        this.Contadores.Add(new Lfc.Contador("Total", Lui.Forms.DataTypes.Currency));
                        this.Contadores.Add(new Lfc.Contador("Pendiente", Lui.Forms.DataTypes.Currency));

                        this.HabilitarFiltrar = true;
                        this.HabilitarImprimir = true;

                        if (this.HasWorkspace)
                                m_Sucursal = this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada;
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


                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult ResultadoFiltrar = base.OnFilter();

                        if (ResultadoFiltrar.Success == true) {
                                using (Comprobantes.Filtros FormFiltros = new Comprobantes.Filtros()) {
                                        FormFiltros.Connection = this.Connection;
                                        FormFiltros.EntradaTipo.TextKey = this.Definicion.ElementoTipo.ToString();
                                        FormFiltros.EntradaPv.Text = m_PV.ToString();
                                        FormFiltros.EntradaLetra.TextKey = m_Letra;
                                        FormFiltros.EntradaSucursal.TextInt = m_Sucursal;
                                        FormFiltros.EntradaFormaPago.TextInt = m_FormaPago;
                                        FormFiltros.EntradaCliente.TextInt = m_Cliente;
                                        FormFiltros.EntradaVendedor.TextInt = m_Vendedor;
                                        FormFiltros.EntradaFechas.Rango = m_Fechas;
                                        FormFiltros.EntradaEstado.TextKey = m_Estado;
                                        FormFiltros.EntradaAnuladas.TextKey = m_Anuladas.ToString();
                                        FormFiltros.EntradaMontoDesde.ValueDecimal= m_MontoDesde;
                                        FormFiltros.EntradaMontoHasta.ValueDecimal = m_MontoHasta;
                                        FormFiltros.Owner = this;
                                        FormFiltros.ShowDialog();

                                        if (FormFiltros.DialogResult == DialogResult.OK) {
                                                m_Sucursal = FormFiltros.EntradaSucursal.TextInt;
                                                m_FormaPago = FormFiltros.EntradaFormaPago.TextInt;
                                                m_Cliente = FormFiltros.EntradaCliente.TextInt;
                                                m_Vendedor = FormFiltros.EntradaVendedor.TextInt;
                                                m_Fechas = FormFiltros.EntradaFechas.Rango;
                                                m_Estado = FormFiltros.EntradaEstado.TextKey;
                                                m_Anuladas = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaAnuladas.TextKey);
                                                m_PV = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaPv.Text);
                                                m_MontoDesde = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaMontoDesde.Text);
                                                m_MontoHasta = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaMontoHasta.Text);
                                                this.Definicion.ElementoTipo = Lbl.Instanciador.InferirTipo(FormFiltros.EntradaTipo.TextKey);
                                                m_Letra = FormFiltros.EntradaLetra.TextKey;

                                                this.RefreshList();
                                                ResultadoFiltrar.Success = true;
                                        } else {
                                                ResultadoFiltrar.Success = false;
                                        }
                                }
                        }

                        return ResultadoFiltrar;
                }

                public override Lfx.Types.OperationResult OnCreate()
                {
                        this.Workspace.RunTime.Execute("CREAR " + this.Definicion.ElementoTipo.ToString() + " " + this.Letra);
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override string SearchText
                {
                        get
                        {
                                return base.SearchText;
                        }
                        set
                        {
                                if (value == null) {
                                        base.SearchText = null;
                                } else if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[0-3]\d(-|/)[0-1]\d(-|/)(\d{2}|\d{4})$")) {
                                        this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(value).ToString();
                                } else if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[0-3]\d(-|/)[0-1]\d$")) {
                                        this.SearchText = Lfx.Types.Formatting.FormatDateTimeSql(value + System.DateTime.Now.ToString("yyyy")).ToString();
                                } else {
                                        base.SearchText = value;
                                }
                        }
                }

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();
                        this.CustomFilters.AddWithValue("compra", 0);

                        switch (this.Definicion.ElementoTipo.ToString()) {
                                case "Lbl.Comprobantes.NotaDeCredito":
                                        this.Definicion.FormFields["pendiente"].Visible = true;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "NCA", "NCB", "NCC", "NCE", "NCM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "NC" + m_Letra);
                                        break;

                                case "Lbl.Comprobantes.NotaDeDebito":
                                        this.Definicion.FormFields["pendiente"].Visible = true;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "NDA", "NDB", "NDC", "NDE", "NDM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "ND" + m_Letra);
                                        break;

                                case "Lbl.Comprobantes.Factura":
                                        this.Definicion.FormFields["pendiente"].Visible = true;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FE", "FM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "F" + m_Letra);
                                        break;

                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                        this.Definicion.FormFields["pendiente"].Visible = true;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FE", "FM", "NCA", "NCB", "NCC", "NCE", "NCM", "NDA", "NDB", "NDC", "NDE", "NDM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "F" + m_Letra, "NC" + m_Letra, "ND" + m_Letra});
                                        break;

                                case "Lbl.Comprobantes.Presupuesto":
                                        this.Definicion.FormFields["pendiente"].Visible = false;
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "PS");
                                        break;

                                case "Lbl.Comprobantes.Remito":
                                        this.Definicion.FormFields["pendiente"].Visible = false;
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "R");
                                        break;

                                case "Lbl.Comprobantes.Ticket":
                                        this.Definicion.FormFields["pendiente"].Visible = true;
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "T");
                                        break;

                                default:
                                        throw new NotImplementedException("No se reconoce el tipo de comprobante " + this.Definicion.ElementoTipo.ToString());
                        }

                        if (m_Vendedor > 0)
                                this.CustomFilters.AddWithValue("comprob.id_vendedor", m_Vendedor);

                        if (SearchText == null) {
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

                        this.UpdateFormFields();

                        base.OnBeginRefreshList();
                }

                protected override Lfx.Types.OperationResult OnEdit(int lCodigo)
                {
                        string sTipo = this.Connection.FieldString("SELECT tipo_fac FROM comprob WHERE id_comprob=" + lCodigo.ToString());
                        this.Workspace.RunTime.Execute("EDITAR " + sTipo + " " + lCodigo.ToString());
                        return new Lfx.Types.SuccessOperationResult();
                }

                protected override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        if (row.Fields["anulada"].ValueInt == 0 && row.Fields["impresa"].ValueInt != 0) {
                                string TipoComprob = row.Fields["tipo_fac"].ValueString;
                                if (TipoComprob.Length >= 2 && TipoComprob.Substring(0, 2) == "NC")
                                        this.Contadores[0].AddValue(-row.Fields["total"].ValueDecimal);
                                else
                                        this.Contadores[0].AddValue(row.Fields["total"].ValueDecimal);
                        }

                        if (row.Fields["anulada"].ValueInt != 0) {
                                // Si está anulada, la tacho
                                itm.Font = new Font("Bitstream Vera Sans", 10, FontStyle.Strikeout);
                        } else if (row.Fields["impresa"].ValueInt == 0) {
                                // No impresa, en gris
                                itm.ForeColor = System.Drawing.Color.Gray;
                        } else if (this.Definicion.ElementoTipo != typeof(Lbl.Comprobantes.Presupuesto) && row.Fields["pendiente"].ValueDecimal > 0) {
                                // Impaga, en rojo
                                this.Contadores[1].AddValue(row.Fields["pendiente"].ValueDecimal);
                                itm.ForeColor = System.Drawing.Color.Red;
                        }

                        int IdVendedor = row.Fields["id_vendedor"].ValueInt;
                        if (IdVendedor > 0) {
                                Lfx.Data.Row Vend = this.Connection.Tables["personas"].FastRows[IdVendedor];
                                if (Vend != null)
                                        itm.SubItems["id_vendedor"].Text = Vend.Fields["nombre_visible"].Value.ToString();
                        }
                }
        }
}