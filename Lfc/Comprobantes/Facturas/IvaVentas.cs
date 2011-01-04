#region License
// Copyright 2004-2010 Ernesto N. Carrea
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

using System.Windows.Forms;

namespace Lfc.Comprobantes.Facturas
{
        public class IvaVentas : Lfc.FormularioListado
        {
                protected internal Lfx.Types.DateRange m_Fecha = new Lfx.Types.DateRange("mes-1");
                protected internal int m_Sucursal, m_Anuladas = 1, m_PV = 0;
                protected internal string m_Letra = "*";

                public IvaVentas()
                {
                        this.ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteFacturable);

                        this.NombreTabla = "comprob";
                        this.KeyField = new Lfx.Data.FormField("comprob.id_comprob", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("personas", "comprob.id_cliente=personas.id_persona"));
                        this.Joins.Add(new qGen.Join("situaciones", "personas.id_situacion=situaciones.id_situacion"));
                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("comprob.fecha", "Fecha", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("comprob.tipo_fac", "Tipo", Lfx.Data.InputFieldTypes.Text, 40),
				new Lfx.Data.FormField("CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0')) AS numero", "Número", Lfx.Data.InputFieldTypes.Text, 140),
				new Lfx.Data.FormField("personas.nombre_visible", "Cliente", Lfx.Data.InputFieldTypes.Text, 300),
				new Lfx.Data.FormField("personas.cuit", "CUIT", Lfx.Data.InputFieldTypes.Text, 140),
				new Lfx.Data.FormField("situaciones.nombrecorto AS situacion", "Cond. IVA", Lfx.Data.InputFieldTypes.Text, 100),
				new Lfx.Data.FormField("comprob.total*(1-anulada) AS gravado", "Gravado", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("comprob.total*(1-anulada) AS total", "Total", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("comprob.anulada", "Anulada", Lfx.Data.InputFieldTypes.Bool, 0),                                
			};

                        this.FormFields["gravado"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;
                        this.FormFields["total"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;

                        this.OrderBy = "comprob.pv, comprob.numero";

                        this.Contadores.Add(new Lfc.Contador("Total", Lui.Forms.DataTypes.Currency));

                        this.HabilitarFiltrar = true;
                        this.HabilitarImprimir = true;
                        this.HabilitarBusqueda = false;
                        this.HabilitarCrear = false;

                        if (this.HasWorkspace)
                                m_Sucursal = this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada;

                        this.Text = "Libro IVA Ventas";
                }


                public override Lfx.Types.OperationResult OnFilter()
                {
                        Lfx.Types.OperationResult ResultadoFiltrar = base.OnFilter();

                        if (ResultadoFiltrar.Success == true) {
                                using (Lfc.Comprobantes.Filtros FormFiltros = new Lfc.Comprobantes.Filtros()) {
                                        FormFiltros.Connection = this.Connection;
                                        FormFiltros.EntradaTipo.ReadOnly = true;
                                        FormFiltros.EntradaTipo.TextKey = this.ElementoTipo.ToString();
                                        FormFiltros.EntradaPv.Text = m_PV.ToString();
                                        FormFiltros.EntradaLetra.TextKey = m_Letra;
                                        FormFiltros.EntradaSucursal.TextInt = m_Sucursal;
                                        FormFiltros.EntradaFormaPago.ReadOnly = true;
                                        FormFiltros.EntradaFormaPago.TextInt = 0;
                                        FormFiltros.EntradaCliente.ReadOnly = true;
                                        FormFiltros.EntradaCliente.TextInt = 0;
                                        FormFiltros.EntradaVendedor.ReadOnly = true;
                                        FormFiltros.EntradaVendedor.TextInt = 0;
                                        FormFiltros.EntradaFechas.Rango = m_Fecha;
                                        FormFiltros.EntradaEstado.ReadOnly = true;
                                        FormFiltros.EntradaEstado.TextKey = "3";
                                        FormFiltros.EntradaAnuladas.TextKey = m_Anuladas.ToString();
                                        FormFiltros.EntradaMontoDesde.ReadOnly = true;
                                        FormFiltros.EntradaMontoHasta.ReadOnly = true;
                                        FormFiltros.Owner = this;
                                        FormFiltros.ShowDialog();

                                        if (FormFiltros.DialogResult == DialogResult.OK) {
                                                m_Sucursal = FormFiltros.EntradaSucursal.TextInt;
                                                m_Fecha = FormFiltros.EntradaFechas.Rango;
                                                m_Anuladas = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaAnuladas.TextKey);
                                                m_PV = Lfx.Types.Parsing.ParseInt(FormFiltros.EntradaPv.Text);
                                                this.ElementoTipo = Lbl.Instanciador.InferirTipo(FormFiltros.EntradaTipo.TextKey);
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

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();
                        this.CustomFilters.AddWithValue("compra", 0);

                        switch (this.ElementoTipo.ToString()) {
                                case "Lbl.Comprobantes.NotaDeCredito":
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "NCA", "NCB", "NCC", "NCE", "NCM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "NC" + m_Letra);
                                        break;

                                case "Lbl.Comprobantes.NotaDeDebito":
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "NDA", "NDB", "NDC", "NDE", "NDM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "ND" + m_Letra);
                                        break;

                                case "Lbl.Comprobantes.Factura":
                                        this.FormFields["pendiente"].Visible = true;
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FE", "FM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", "F" + m_Letra);
                                        break;

                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                        if (m_Letra == "*")
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FE", "FM", "NCA", "NCB", "NCC", "NCE", "NCM", "NDA", "NDB", "NDC", "NDE", "NDM" });
                                        else
                                                this.CustomFilters.AddWithValue("comprob.tipo_fac", qGen.ComparisonOperators.In, new string[] { "F" + m_Letra, "NC" + m_Letra, "ND" + m_Letra });
                                        break;

                                case "Lbl.Comprobantes.Presupuesto":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "PS");
                                        break;

                                case "Lbl.Comprobantes.Remito":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "R");
                                        break;

                                case "Lbl.Comprobantes.Ticket":
                                        this.CustomFilters.AddWithValue("comprob.tipo_fac", "T");
                                        break;

                                default:
                                        throw new System.NotImplementedException("No se reconoce el tipo de comprobante " + this.ElementoTipo.ToString());
                        }

                        if (m_Sucursal > 0)
                                this.CustomFilters.AddWithValue("comprob.id_sucursal", m_Sucursal);

                        if (m_PV > 0)
                                this.CustomFilters.AddWithValue("comprob.pv", m_PV);

                        if (m_Fecha.HasRange)
                                this.CustomFilters.AddWithValue("(fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fecha.To) + " 23:59:59')");

                        this.CustomFilters.AddWithValue("impresa", 1);

                        this.UpdateFormFields();

                        base.OnBeginRefreshList();
                }

                protected override Lfx.Types.OperationResult OnEdit(int lCodigo)
                {
                        string Tipo = this.Connection.FieldString("SELECT tipo_fac FROM comprob WHERE id_comprob=" + lCodigo.ToString());
                        this.Workspace.RunTime.Execute("EDITAR " + Tipo + " " + lCodigo.ToString());
                        return new Lfx.Types.SuccessOperationResult();
                }

                protected override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        if (row.Fields["anulada"].ValueInt != 0) {
                                // Si está anulada, la tacho
                                itm.SubItems["nombre_visible"].Text = "Anulada";
                                itm.Font = new System.Drawing.Font("Bitstream Vera Sans", 10, System.Drawing.FontStyle.Strikeout);
                        }

                        base.OnItemAdded(itm, row);
                }

                protected override Lfx.FileFormats.Office.Spreadsheet.Row FormatRow(int itemId, Lfx.Data.Row row, Lfx.FileFormats.Office.Spreadsheet.Sheet sheet, Lfx.Data.FormFieldCollection useFields)
                {
                        Lfx.FileFormats.Office.Spreadsheet.Row Res = base.FormatRow(itemId, row, sheet, useFields);

                        if (row.Fields["anulada"].ValueInt != 0)
                                Res.Cells[4].Content = "ANULADA";

                        return Res;
                }
        }
}
