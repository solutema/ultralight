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

namespace Lfc.Comprobantes
{
        public partial class FormComprobantesListado : Lui.Forms.TextListingForm
        {
                internal string m_Tipo = "F", m_Letra = "*";
                internal Lfx.Types.DateRange m_Fechas;
                internal string m_Estado = "";
                internal int m_Sucursal = 0, m_Cliente, m_Vendedor, m_Anuladas = 1, m_PV = 0, m_FormaPago;
                internal double m_MontoDesde = 0, m_MontoHasta = 0;
                internal string m_Agrupar = "";
                internal Lfx.FileFormats.Office.Spreadsheet.Sheet ReportSheet;

                public FormComprobantesListado()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                }

                public override Lfx.Types.OperationResult RefreshList()
                {
                        Lfx.Types.OperationResult mostrarReturn = base.RefreshList();

                        if (mostrarReturn.Success == true) {
                                if (m_Agrupar.Length >= 10 && m_Agrupar.Substring(0, 10) == "articulos.") {
                                        string Filtro = FiltrosComunes();
                                        return MostrarPorMarcaOProveedor(Filtro);
                                } else {
                                        string Filtro = FiltrosComunes();
                                        return MostrarNormal(Filtro);
                                }
                        }

                        return mostrarReturn;
                }

                private string FiltrosComunes()
                {
                        string FiltroSql = "compra=0";

                        switch (m_Tipo) {
                                case "NC":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND facturas.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM')";
                                        else
                                                FiltroSql += " AND facturas.tipo_fac='NC" + m_Letra + "'";
                                        break;

                                case "ND":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND facturas.tipo_fac IN ('NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroSql += " AND facturas.tipo_fac='ND" + m_Letra + "'";
                                        break;

                                case "NCD":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND facturas.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroSql += " AND (facturas.tipo_fac='NC" + m_Letra + "' OR facturas.tipo_fac='ND" + m_Letra + "')";
                                        break;

                                case "F":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND facturas.tipo_fac IN ('A', 'B', 'C', 'E', 'M')";
                                        else
                                                FiltroSql += " AND facturas.tipo_fac='" + m_Letra + "'";
                                        break;

                                case "T":
                                        FiltroSql += " AND facturas.tipo_fac='T'";
                                        break;

                                default:
                                        if (m_Letra == "*")
                                                FiltroSql += " AND facturas.tipo_fac IN ('A', 'B', 'C', 'E', 'M', 'NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroSql += " AND (facturas.tipo_fac='" + m_Letra + "' OR facturas.tipo_fac='NC" + m_Letra + "' OR facturas.tipo_fac='ND" + m_Letra + "')";
                                        break;
                        }

                        if (m_Cliente > 0)
                                FiltroSql += " AND (facturas.id_cliente='" + m_Cliente.ToString() + "')";

                        if (m_Vendedor > 0)
                                FiltroSql += " AND (facturas.id_vendedor='" + m_Vendedor.ToString() + "')";

                        if (m_FormaPago > 0)
                                FiltroSql += " AND (facturas.id_formapago='" + m_FormaPago.ToString() + "')";

                        if (m_Sucursal > 0)
                                FiltroSql += " AND (facturas.id_sucursal='" + m_Sucursal.ToString() + "')";

                        if (m_PV > 0)
                                FiltroSql += " AND (facturas.pv='" + m_PV.ToString() + "')";

                        FiltroSql += " AND facturas.total<>0";

                        if (m_Fechas.HasRange)
                                FiltroSql += " AND (facturas.fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59')";

                        switch (m_Estado) {
                                case "0":
                                        FiltroSql += " AND facturas.impresa=1 AND facturas.numero>0";
                                        break;

                                case "1":
                                        FiltroSql += " AND facturas.impresa=1 AND facturas.numero>0 AND (facturas.cancelado>=facturas.total)";
                                        break;

                                case "2":
                                        FiltroSql += " AND facturas.impresa=1 AND facturas.numero>0 AND (facturas.cancelado<facturas.total)";
                                        break;

                                case "3":
                                        FiltroSql += " AND facturas.impresa=1 AND facturas.numero>0";
                                        break;
                        }

                        if (m_Anuladas == 0)
                                FiltroSql += " AND facturas.anulada=0";

                        if (m_MontoDesde != 0 && m_MontoHasta != 0)
                                FiltroSql += " AND facturas.total BETWEEN " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde) + " AND " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta);
                        else if (m_MontoDesde != 0)
                                FiltroSql += " AND facturas.total>=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde);
                        else if (m_MontoHasta != 0)
                                FiltroSql += " AND facturas.total<=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta);

                        return FiltroSql;
                }

                private Lfx.Types.OperationResult MostrarPorMarcaOProveedor(string Filtros)
                {
                        string TextoSql = null;
                        string FiltrosCompletos = null;

                        FiltrosCompletos = "facturas.id_factura=facturas_detalle.id_factura AND facturas_detalle.id_articulo=articulos.id_articulo AND " + Filtros;
                        TextoSql = "SELECT SUM(facturas_detalle.costo*cantidad) AS totalcosto, COUNT(facturas.id_factura) AS cantfact, SUM(facturas_detalle.importe*(1-facturas.descuento/100)*(1+facturas.interes/100)) AS total, SUM(facturas_detalle.cantidad) AS cantart, articulos.id_marca, articulos.id_proveedor, articulos.id_articulo, articulos.id_cat_articulo, DAYOFWEEK(facturas.fecha), DAYOFMONTH(facturas.fecha), MONTH(facturas.fecha)";
                        TextoSql += " FROM facturas, facturas_detalle, articulos WHERE " + FiltrosCompletos;
                        TextoSql += " GROUP BY " + m_Agrupar;
                        TextoSql += " ORDER BY total DESC";

                        System.Data.DataTable TmpTabla = this.Workspace.DefaultDataBase.Select(TextoSql);

                        ReportSheet = new Lfx.FileFormats.Office.Spreadsheet.Sheet("Listado de Comprobantes - Fecha " + m_Fechas.From + " al " + m_Fechas.To);
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Detalle", 320));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Artículos", 80, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Facturas", 80, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Costo", 120, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Importe", 120, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Diferencia", 120, Lfx.Types.StringAlignment.Far));

                        double Total = 0;
                        double TotalCosto = 0;
                        double TotalNC = 0;
                        double TotalNCCosto = 0;
                        double Diferencia = 0;

                        foreach (System.Data.DataRow row in TmpTabla.Rows) {
                                Lfx.FileFormats.Office.Spreadsheet.Row Reng = new Lfx.FileFormats.Office.Spreadsheet.Row();

                                FiltrosCompletos = "facturas.tipo_fac IN('NCA', 'NCB', 'NCC', 'NCE', 'NCM') AND facturas.id_factura=facturas_detalle.id_factura AND facturas_detalle.id_articulo=articulos.id_articulo AND " + Filtros;

                                switch (m_Agrupar) {
                                        case "articulos.id_marca":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_marca"]);
                                                break;

                                        case "articulos.id_proveedor":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_proveedor"]);
                                                break;

                                        case "articulos.id_articulo":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_articulo"]);
                                                break;

                                        case "articulos.id_cat_articulo":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_cat_articulo"]);
                                                break;
                                }

                                TotalNC = this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(facturas_detalle.importe*(1-facturas.descuento/100)*(1+facturas.interes/100)) AS total FROM facturas, facturas_detalle, articulos WHERE " + FiltrosCompletos + " GROUP BY facturas.id_factura");
                                TotalNCCosto = this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(facturas_detalle.costo) AS total FROM facturas, facturas_detalle, articulos WHERE " + FiltrosCompletos + " GROUP BY " + m_Agrupar);
                                string Detalle = null;

                                switch (m_Agrupar) {
                                        case "articulos.id_proveedor":
                                                Detalle = this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_proveedor"]).ToString());
                                                break;

                                        case "articulos.id_marca":
                                                Detalle = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM marcas WHERE id_marca=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_marca"]).ToString());
                                                break;

                                        case "articulos.id_articulo":
                                                Detalle = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM articulos WHERE id_articulo=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_articulo"]).ToString());
                                                break;

                                        case "articulos.id_cat_articulo":
                                                Detalle = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cat_articulos WHERE id_cat_articulo=" + Lfx.Data.DataBase.ConvertDBNullToZero(row["id_cat_articulo"]).ToString());
                                                break;
                                }

                                double rowTotal = System.Convert.ToDouble(row["total"]) - TotalNC;
                                double RowTotalCosto = System.Convert.ToDouble(row["totalcosto"]) - TotalNCCosto;
                                double rowDiferencia = rowTotal - RowTotalCosto;

                                if (Detalle == null || Detalle.Length == 0)
                                        Detalle = "(Sin especificar)";

                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Detalle));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(row["cantart"]), this.Workspace.CurrentConfig.Products.StockDecimalPlaces)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToInt32(row["cantfact"])));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatCurrency(RowTotalCosto, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatCurrency(rowTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatCurrency(rowDiferencia, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));

                                Total += rowTotal;
                                TotalCosto += RowTotalCosto;
                                ReportSheet.Rows.Add(Reng);
                                Diferencia += rowDiferencia;
                        }

                        Lfx.FileFormats.Office.Spreadsheet.Row RengTotal = new Lfx.FileFormats.Office.Spreadsheet.Row();
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell("Total"));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(" "));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(" "));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Total));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(TotalCosto));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Diferencia));
                        ReportSheet.Rows.Add(RengTotal);

                        ReportSheet.ToListView(ReportListView);
                        this.Report = new Lfx.FileFormats.Office.Spreadsheet.Workbook();
                        this.Report.Sheets.Add(ReportSheet);

                        return new Lfx.Types.SuccessOperationResult();
                }

                private Lfx.Types.OperationResult MostrarNormal(string Filtros)
                {
                        string TextoSql = null;
                        string ColumnaTotal = "total";

                        // Filtros = "facturas.id_factura=facturas_detalle.id_factura AND facturas_detalle.id_articulo=articulos.id_articulo AND " & Filtros
                        switch (m_Agrupar) {
                                case "":
                                        TextoSql = "SELECT facturas.*";
                                        break;

                                default:
                                        TextoSql = "SELECT facturas.*, DAYOFWEEK(facturas.fecha), DAYOFMONTH(facturas.fecha), MONTH(facturas.fecha), SUM(facturas.total) AS sumtotal";
                                        break;
                        }

                        TextoSql += " FROM facturas WHERE " + Filtros;
                        if (m_Agrupar.Length > 0)
                                TextoSql += " GROUP BY " + m_Agrupar;
                        else
                                TextoSql += " GROUP BY facturas.id_factura";
                        TextoSql += " ORDER BY ";

                        if (m_Agrupar.Length > 0) {
                                TextoSql += "sumtotal DESC, ";
                                ColumnaTotal = "sumtotal";
                        }

                        TextoSql += "RIGHT(facturas.tipo_fac, 1), facturas.pv, facturas.numero";

                        System.Data.DataTable TmpTabla = this.Workspace.DefaultDataBase.Select(TextoSql);

                        double Total = 0;
                        double SubTotal = 0;
                        //double Diferencia = 0;
                        string UltimoValorAgrupar = "slfadf*af*df*asdf";

                        ReportSheet = new Lfx.FileFormats.Office.Spreadsheet.Sheet("Listado de Comprobantes - Fecha " + m_Fechas.From + " al " + m_Fechas.To);
                        if (m_Agrupar.Length == 0) {
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Fecha", 100));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Tipo", 48));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Número", 120));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Cliente", 240));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("CUIT", 120));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Importe", 160, Lfx.Types.StringAlignment.Far));
                        } else {
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Item", 480));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Importe", 160, Lfx.Types.StringAlignment.Far));
                        }

                        string NombreGrupo = null;
                        foreach (System.Data.DataRow row in TmpTabla.Rows) {
                                Lfx.FileFormats.Office.Spreadsheet.Row Reng = new Lfx.FileFormats.Office.Spreadsheet.Row();

                                if (m_Agrupar.Length > 0 && row[Lfx.Data.DataBase.GetFieldName(m_Agrupar)].ToString() != UltimoValorAgrupar) {
                                        UltimoValorAgrupar = row[Lfx.Data.DataBase.GetFieldName(m_Agrupar)].ToString();

                                        if (SubTotal > 0) {
                                                Lfx.FileFormats.Office.Spreadsheet.Row SubTotal1 = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                                SubTotal1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(NombreGrupo));
                                                SubTotal1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(SubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                                ReportSheet.Rows.Add(SubTotal1);
                                                SubTotal = 0;
                                        }

                                        switch (m_Agrupar) {
                                                case "facturas.id_vendedor":
                                                case "facturas.id_cliente":
                                                        if (UltimoValorAgrupar.Length > 0)
                                                                NombreGrupo = this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + UltimoValorAgrupar);
                                                        else
                                                                NombreGrupo = "(Sin especificar)";
                                                        break;

                                                case "facturas.id_formapago":
                                                        if (UltimoValorAgrupar.Length > 0)
                                                                NombreGrupo = this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM formaspago WHERE id_formapago=" + UltimoValorAgrupar);
                                                        else
                                                                NombreGrupo = "(Sin especificar)";

                                                        break;

                                                case "DAYOFWEEK(facturas.fecha)":
                                                        switch (System.Convert.ToInt32(row[Lfx.Data.DataBase.GetFieldName(m_Agrupar)])) {
                                                                case 1:
                                                                        NombreGrupo = "Domingo";
                                                                        break;
                                                                case 2:
                                                                        NombreGrupo = "Lunes";
                                                                        break;
                                                                case 3:
                                                                        NombreGrupo = "Martes";
                                                                        break;
                                                                case 4:
                                                                        NombreGrupo = "Miércoles";
                                                                        break;
                                                                case 5:
                                                                        NombreGrupo = "Jueves";
                                                                        break;
                                                                case 6:
                                                                        NombreGrupo = "Viernes";
                                                                        break;
                                                                case 7:
                                                                        NombreGrupo = "Sábado";
                                                                        break;
                                                        }
                                                        break;

                                                case "DAYOFMONTH(facturas.fecha)":
                                                        NombreGrupo = System.Convert.ToDateTime(row["fecha"]).ToString("dd-MM-yyyy");
                                                        break;

                                                case "MONTH(facturas.fecha)":
                                                        NombreGrupo = System.Convert.ToDateTime(row["fecha"]).ToString("MMMM");
                                                        break;

                                                default:
                                                        NombreGrupo = UltimoValorAgrupar;
                                                        break;
                                        }
                                }

                                System.Text.StringBuilder Renglon = new System.Text.StringBuilder();
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatDate(row["fecha"])));
                                Renglon.Append(Lfx.Types.Formatting.FormatDate(row["fecha"]) + " ");
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToString(row["tipo_fac"]).PadRight(3).Substring(0, 3)));
                                Renglon.Append(System.Convert.ToString(row["tipo_fac"]).PadRight(3).Substring(0, 3) + " ");
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToInt32(row["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(row["numero"]).ToString("00000000")));
                                Renglon.Append(System.Convert.ToInt32(row["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(row["numero"]).ToString("00000000") + " ");

                                if (System.Convert.ToInt32(row["anulada"]) != 0) {
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell("ANULADA"));
                                        Renglon.Append("ANULADA".PadRight(25) + " ");
                                        Renglon.Append("              ");
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell((double)0));
                                        Renglon.Append(Lfx.Types.Formatting.FormatCurrency(0, this.Workspace.CurrentConfig.Currency.DecimalPlaces).PadLeft(10));
                                        // No suma al total
                                } else {
                                        Lfx.Data.Row Cliente = this.Workspace.DefaultDataBase.Row("personas", "id_persona", System.Convert.ToInt32(row["id_cliente"]));
                                        Renglon.Append(System.Convert.ToString(Cliente["nombre_visible"]).PadRight(25).Substring(0, 25) + " ");
                                        Renglon.Append(System.Convert.ToString(Cliente["cuit"]).PadRight(13).Substring(0, 13) + " ");
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Cliente["nombre_visible"].ToString()));
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Cliente["cuit"].ToString()));

                                        switch (System.Convert.ToString(row["tipo_fac"])) {
                                                case "NCA":
                                                case "NCB":
                                                case "NCC":
                                                case "NCE":
                                                case "NCM":
                                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(-System.Convert.ToDouble(row[ColumnaTotal])));
                                                        Renglon.Append(("(" + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(row[ColumnaTotal]), this.Workspace.CurrentConfig.Currency.DecimalPlaces) + ")").PadLeft(10));
                                                        Total -= System.Convert.ToDouble(row[ColumnaTotal]);
                                                        SubTotal -= System.Convert.ToDouble(row[ColumnaTotal]);
                                                        break;

                                                default:
                                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDouble(row[ColumnaTotal])));
                                                        Renglon.Append(Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(row[ColumnaTotal]), this.Workspace.CurrentConfig.Currency.DecimalPlaces).PadLeft(10));
                                                        Total += System.Convert.ToDouble(row[ColumnaTotal]);
                                                        SubTotal += System.Convert.ToDouble(row[ColumnaTotal]);
                                                        break;
                                        }
                                }

                                if (m_Agrupar.Length == 0)
                                        ReportSheet.Rows.Add(Reng);
                        }

                        if (m_Agrupar.Length > 0 && SubTotal > 0) {
                                Lfx.FileFormats.Office.Spreadsheet.Row SubTotal2 = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                SubTotal2.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(NombreGrupo));
                                SubTotal2.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(SubTotal, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                ReportSheet.Rows.Add(SubTotal2);
                                SubTotal = 0;
                        }

                        Lfx.FileFormats.Office.Spreadsheet.Row Total1 = new Lfx.FileFormats.Office.Spreadsheet.Row();
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell("Total"));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                        ReportSheet.Rows.Add(Total1);

                        ReportSheet.ToListView(ReportListView);
                        this.Report = new Lfx.FileFormats.Office.Spreadsheet.Workbook();
                        this.Report.Sheets.Add(ReportSheet);

                        return new Lfx.Types.SuccessOperationResult();
                }

                private void txtAgrupar_TextChanged(System.Object sender, System.EventArgs e)
                {
                        if (this.Visible) {
                                string NuevoAgrupar = txtAgrupar.TextKey;

                                if (NuevoAgrupar == "*")
                                        NuevoAgrupar = "";

                                if (NuevoAgrupar != m_Agrupar) {
                                        m_Agrupar = NuevoAgrupar;
                                        this.RefreshList();
                                }
                        }
                }
        }
}