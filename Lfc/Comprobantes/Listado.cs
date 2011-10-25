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

namespace Lfc.Comprobantes
{
        public partial class Listado : Lfc.FormularioListadoTexto
        {
                internal string m_Tipo = "F", m_Letra = "*";
                internal Lfx.Types.DateRange m_Fechas = null;
                internal string m_Estado = "";
                internal int m_Sucursal = 0, m_Cliente = 0, m_Vendedor = 0, m_Anuladas = 1, m_PV = 0, m_FormaPago = 0;
                internal decimal m_MontoDesde = 0, m_MontoHasta = 0;
                internal string m_Agrupar = "";
                internal Lfx.FileFormats.Office.Spreadsheet.Sheet ReportSheet;

                public Listado()
                {
                        InitializeComponent();
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
                                                FiltroSql += " AND comprob.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM')";
                                        else
                                                FiltroSql += " AND comprob.tipo_fac='NC" + m_Letra + "'";
                                        break;

                                case "ND":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND comprob.tipo_fac IN ('NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroSql += " AND comprob.tipo_fac='ND" + m_Letra + "'";
                                        break;

                                case "NCD":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND comprob.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroSql += " AND (comprob.tipo_fac='NC" + m_Letra + "' OR comprob.tipo_fac='ND" + m_Letra + "')";
                                        break;

                                case "F":
                                        if (m_Letra == "*")
                                                FiltroSql += " AND comprob.tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM')";
                                        else
                                                FiltroSql += " AND comprob.tipo_fac='F" + m_Letra + "'";
                                        break;

                                case "T":
                                        FiltroSql += " AND comprob.tipo_fac='T'";
                                        break;

                                default:
                                        if (m_Letra == "*")
                                                FiltroSql += " AND comprob.tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NCA', 'NCB', 'NCC', 'NCE', 'NCM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')";
                                        else
                                                FiltroSql += " AND (comprob.tipo_fac='F" + m_Letra + "' OR comprob.tipo_fac='NC" + m_Letra + "' OR comprob.tipo_fac='ND" + m_Letra + "')";
                                        break;
                        }

                        if (m_Cliente > 0)
                                FiltroSql += " AND (comprob.id_cliente='" + m_Cliente.ToString() + "')";

                        if (m_Vendedor > 0)
                                FiltroSql += " AND (comprob.id_vendedor='" + m_Vendedor.ToString() + "')";

                        if (m_FormaPago > 0)
                                FiltroSql += " AND (comprob.id_formapago='" + m_FormaPago.ToString() + "')";

                        if (m_Sucursal > 0)
                                FiltroSql += " AND (comprob.id_sucursal='" + m_Sucursal.ToString() + "')";

                        if (m_PV > 0)
                                FiltroSql += " AND (comprob.pv='" + m_PV.ToString() + "')";

                        FiltroSql += " AND comprob.total<>0";

                        if (m_Fechas.HasRange)
                                FiltroSql += " AND (comprob.fecha BETWEEN '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.From) + " 00:00:00' AND '" + Lfx.Types.Formatting.FormatDateSql(m_Fechas.To) + " 23:59:59')";

                        switch (m_Estado) {
                                case "0":
                                        FiltroSql += " AND comprob.impresa=1 AND comprob.numero>0";
                                        break;

                                case "1":
                                        FiltroSql += " AND comprob.impresa=1 AND comprob.numero>0 AND (comprob.cancelado>=comprob.total)";
                                        break;

                                case "2":
                                        FiltroSql += " AND comprob.impresa=1 AND comprob.numero>0 AND (comprob.cancelado<comprob.total)";
                                        break;

                                case "3":
                                        FiltroSql += " AND comprob.impresa=1 AND comprob.numero>0";
                                        break;
                        }

                        if (m_Anuladas == 0)
                                FiltroSql += " AND comprob.anulada=0";

                        if (m_MontoDesde != 0 && m_MontoHasta != 0)
                                FiltroSql += " AND comprob.total BETWEEN " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde) + " AND " + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta);
                        else if (m_MontoDesde != 0)
                                FiltroSql += " AND comprob.total>=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoDesde);
                        else if (m_MontoHasta != 0)
                                FiltroSql += " AND comprob.total<=" + Lfx.Types.Formatting.FormatCurrencySql(m_MontoHasta);

                        return FiltroSql;
                }

                private Lfx.Types.OperationResult MostrarPorMarcaOProveedor(string Filtros)
                {
                        string TextoSql = null;
                        string FiltrosCompletos = null;

                        FiltrosCompletos = "comprob.id_comprob=comprob_detalle.id_comprob AND comprob_detalle.id_articulo=articulos.id_articulo AND " + Filtros;
                        TextoSql = "SELECT SUM(comprob_detalle.costo*cantidad) AS totalcosto, COUNT(comprob.id_comprob) AS cantfact, SUM(comprob_detalle.importe*(1-comprob.descuento/100)*(1+comprob.interes/100)) AS total, SUM(comprob_detalle.cantidad) AS cantart, articulos.id_marca, articulos.id_proveedor, articulos.id_articulo, articulos.id_categoria, DAYOFWEEK(comprob.fecha), DAYOFMONTH(comprob.fecha), MONTH(comprob.fecha)";
                        TextoSql += " FROM comprob, comprob_detalle, articulos WHERE " + FiltrosCompletos;
                        TextoSql += " GROUP BY " + m_Agrupar;
                        TextoSql += " ORDER BY total DESC";

                        System.Data.DataTable Comprobs = this.Connection.Select(TextoSql);

                        ReportSheet = new Lfx.FileFormats.Office.Spreadsheet.Sheet("Listado de Comprobantes - Fecha " + m_Fechas.From + " al " + m_Fechas.To);
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Detalle", 320));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Artículos", 80, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Facturas", 80, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Costo", 120, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Importe", 120, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Pendiente", 120, Lfx.Types.StringAlignment.Far));
                        ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Diferencia", 120, Lfx.Types.StringAlignment.Far));

                        decimal Total = 0, TotalCosto = 0;
                        decimal TotalNC = 0, TotalNCCosto = 0;
                        decimal Diferencia = 0;

                        foreach (System.Data.DataRow Comrob in Comprobs.Rows) {
                                Lfx.FileFormats.Office.Spreadsheet.Row Reng = new Lfx.FileFormats.Office.Spreadsheet.Row();

                                FiltrosCompletos = "comprob.tipo_fac IN('NCA', 'NCB', 'NCC', 'NCE', 'NCM') AND comprob.id_comprob=comprob_detalle.id_comprob AND comprob_detalle.id_articulo=articulos.id_articulo AND " + Filtros;

                                switch (m_Agrupar) {
                                        case "articulos.id_marca":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_marca"]);
                                                break;

                                        case "articulos.id_proveedor":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_proveedor"]);
                                                break;

                                        case "articulos.id_articulo":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_articulo"]);
                                                break;

                                        case "articulos.id_categoria":
                                                FiltrosCompletos += " AND " + m_Agrupar + "=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_categoria"]);
                                                break;
                                }

                                TotalNC = this.Connection.FieldDecimal("SELECT SUM(comprob_detalle.importe*(1-comprob.descuento/100)*(1+comprob.interes/100)) AS total FROM comprob, comprob_detalle, articulos WHERE " + FiltrosCompletos + " GROUP BY comprob.id_comprob");
                                TotalNCCosto = this.Connection.FieldDecimal("SELECT SUM(comprob_detalle.costo) AS total FROM comprob, comprob_detalle, articulos WHERE " + FiltrosCompletos + " GROUP BY " + m_Agrupar);
                                string Detalle = null;

                                switch (m_Agrupar) {
                                        case "articulos.id_proveedor":
                                                Detalle = this.Connection.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_proveedor"]).ToString());
                                                break;

                                        case "articulos.id_marca":
                                                Detalle = this.Connection.FieldString("SELECT nombre FROM marcas WHERE id_marca=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_marca"]).ToString());
                                                break;

                                        case "articulos.id_articulo":
                                                Detalle = this.Connection.FieldString("SELECT nombre FROM articulos WHERE id_articulo=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_articulo"]).ToString());
                                                break;

                                        case "articulos.id_categoria":
                                                Detalle = this.Connection.FieldString("SELECT nombre FROM articulos_categorias WHERE id_categoria=" + Lfx.Data.Connection.ConvertDBNullToZero(Comrob["id_categoria"]).ToString());
                                                break;
                                }

                                decimal ComprobTotal = System.Convert.ToDecimal(Comrob["total"]) - TotalNC;
                                decimal ComprobTotalCosto = System.Convert.ToDecimal(Comrob["totalcosto"]) - TotalNCCosto;
                                decimal ComprobDiferencia = ComprobTotal - ComprobTotalCosto;

                                if (Detalle == null || Detalle.Length == 0)
                                        Detalle = "(Sin especificar)";

                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Detalle));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Comrob["cantart"]), this.Workspace.CurrentConfig.Productos.DecimalesStock)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToInt32(Comrob["cantfact"])));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatCurrency(ComprobTotalCosto, this.Workspace.CurrentConfig.Moneda.Decimales)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatCurrency(ComprobTotal, this.Workspace.CurrentConfig.Moneda.Decimales)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatCurrency(ComprobDiferencia, this.Workspace.CurrentConfig.Moneda.Decimales)));

                                Total += ComprobTotal;
                                TotalCosto += ComprobTotalCosto;
                                ReportSheet.Rows.Add(Reng);
                                Diferencia += ComprobDiferencia;
                        }

                        Lfx.FileFormats.Office.Spreadsheet.Row RengTotal = new Lfx.FileFormats.Office.Spreadsheet.Row();
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell("Total"));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(" "));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(" "));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(TotalCosto));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Total));
                        RengTotal.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Diferencia));
                        ReportSheet.Rows.Add(RengTotal);

                        ReportListView.FromSheet(ReportSheet);
                        this.Report = new Lfx.FileFormats.Office.Spreadsheet.Workbook();
                        this.Report.Sheets.Add(ReportSheet);

                        return new Lfx.Types.SuccessOperationResult();
                }

                private Lfx.Types.OperationResult MostrarNormal(string Filtros)
                {
                        string TextoSql = null;
                        string ColumnaTotal = "total";

                        // Filtros = "comprob.id_comprob=comprob_detalle.id_comprob AND comprob_detalle.id_articulo=articulos.id_articulo AND " & Filtros
                        switch (m_Agrupar) {
                                case "":
                                        TextoSql = "SELECT comprob.*";
                                        break;

                                default:
                                        TextoSql = "SELECT comprob.*, DAYOFWEEK(comprob.fecha), DAYOFMONTH(comprob.fecha), MONTH(comprob.fecha), SUM(comprob.total) AS sumtotal";
                                        break;
                        }

                        TextoSql += " FROM comprob WHERE " + Filtros;
                        if (m_Agrupar.Length > 0)
                                TextoSql += " GROUP BY " + m_Agrupar;
                        else
                                TextoSql += " GROUP BY comprob.id_comprob";
                        TextoSql += " ORDER BY ";

                        if (m_Agrupar.Length > 0) {
                                TextoSql += "sumtotal DESC, ";
                                ColumnaTotal = "sumtotal";
                        }

                        TextoSql += "RIGHT(comprob.tipo_fac, 1), comprob.pv, comprob.numero";

                        System.Data.DataTable Comprobs = this.Connection.Select(TextoSql);

                        decimal Total = 0, SubTotal = 0;
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
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Cancelado", 160, Lfx.Types.StringAlignment.Far));
                        } else {
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Item", 480));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Importe", 160, Lfx.Types.StringAlignment.Far));
                                ReportSheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader("Cancelado", 160, Lfx.Types.StringAlignment.Far));
                        }

                        string NombreGrupo = null;
                        foreach (System.Data.DataRow Comprob in Comprobs.Rows) {
                                Lfx.FileFormats.Office.Spreadsheet.Row Reng = new Lfx.FileFormats.Office.Spreadsheet.Row();

                                if (m_Agrupar.Length > 0 && Comprob[Lfx.Data.Connection.GetFieldName(m_Agrupar)].ToString() != UltimoValorAgrupar) {
                                        UltimoValorAgrupar = Comprob[Lfx.Data.Connection.GetFieldName(m_Agrupar)].ToString();

                                        if (SubTotal > 0) {
                                                Lfx.FileFormats.Office.Spreadsheet.Row SubTotal1 = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                                SubTotal1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(NombreGrupo));
                                                SubTotal1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(SubTotal, this.Workspace.CurrentConfig.Moneda.Decimales)));
                                                ReportSheet.Rows.Add(SubTotal1);
                                                SubTotal = 0;
                                        }

                                        switch (m_Agrupar) {
                                                case "comprob.id_vendedor":
                                                case "comprob.id_cliente":
                                                        if (UltimoValorAgrupar.Length > 0)
                                                                NombreGrupo = this.Connection.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + UltimoValorAgrupar);
                                                        else
                                                                NombreGrupo = "(Sin especificar)";
                                                        break;

                                                case "comprob.id_formapago":
                                                        if (UltimoValorAgrupar.Length > 0)
                                                                NombreGrupo = this.Connection.FieldString("SELECT nombre FROM formaspago WHERE id_formapago=" + UltimoValorAgrupar);
                                                        else
                                                                NombreGrupo = "(Sin especificar)";

                                                        break;

                                                case "DAYOFWEEK(comprob.fecha)":
                                                        switch (System.Convert.ToInt32(Comprob[Lfx.Data.Connection.GetFieldName(m_Agrupar)])) {
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

                                                case "DAYOFMONTH(comprob.fecha)":
                                                        NombreGrupo = System.Convert.ToDateTime(Comprob["fecha"]).ToString("dd-MM-yyyy");
                                                        break;

                                                case "MONTH(comprob.fecha)":
                                                        NombreGrupo = System.Convert.ToDateTime(Comprob["fecha"]).ToString("MMMM");
                                                        break;

                                                default:
                                                        NombreGrupo = UltimoValorAgrupar;
                                                        break;
                                        }
                                }

                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lfx.Types.Formatting.FormatDate(Comprob["fecha"])));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToString(Comprob["tipo_fac"]).PadRight(3).Substring(0, 3)));
                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToInt32(Comprob["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(Comprob["numero"]).ToString("00000000")));

                                if (System.Convert.ToInt32(Comprob["anulada"]) != 0) {
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell("ANULADA"));
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell((double)0));
                                        // No suma al total
                                } else {
                                        Lfx.Data.Row Cliente = this.Connection.Row("personas", "id_persona", System.Convert.ToInt32(Comprob["id_cliente"]));
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Cliente["nombre_visible"].ToString()));
                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Cliente["cuit"].ToString()));

                                        switch (System.Convert.ToString(Comprob["tipo_fac"])) {
                                                case "NCA":
                                                case "NCB":
                                                case "NCC":
                                                case "NCE":
                                                case "NCM":
                                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(-System.Convert.ToDouble(Comprob[ColumnaTotal])));
                                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDouble(Comprob["cancelado"])));
                                                        Total -= System.Convert.ToDecimal(Comprob[ColumnaTotal]);
                                                        SubTotal -= System.Convert.ToDecimal(Comprob[ColumnaTotal]);
                                                        break;

                                                default:
                                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDouble(Comprob[ColumnaTotal])));
                                                        Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDouble(Comprob["cancelado"])));
                                                        Total += System.Convert.ToDecimal(Comprob[ColumnaTotal]);
                                                        SubTotal += System.Convert.ToDecimal(Comprob[ColumnaTotal]);
                                                        break;
                                        }
                                }

                                if (m_Agrupar.Length == 0)
                                        ReportSheet.Rows.Add(Reng);
                        }

                        if (m_Agrupar.Length > 0 && SubTotal > 0) {
                                Lfx.FileFormats.Office.Spreadsheet.Row SubTotal2 = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                SubTotal2.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(NombreGrupo));
                                SubTotal2.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(SubTotal, this.Workspace.CurrentConfig.Moneda.Decimales)));
                                ReportSheet.Rows.Add(SubTotal2);
                                SubTotal = 0;
                        }

                        Lfx.FileFormats.Office.Spreadsheet.Row Total1 = new Lfx.FileFormats.Office.Spreadsheet.Row();
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell("Total"));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(""));
                        Total1.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(Total, this.Workspace.CurrentConfig.Moneda.Decimales)));
                        ReportSheet.Rows.Add(Total1);

                        ReportListView.FromSheet(ReportSheet);
                        this.Report = new Lfx.FileFormats.Office.Spreadsheet.Workbook();
                        this.Report.Sheets.Add(ReportSheet);

                        return new Lfx.Types.SuccessOperationResult();
                }

                private void EntradaAgrupar_TextChanged(System.Object sender, System.EventArgs e)
                {
                        if (this.Visible) {
                                string NuevoAgrupar = EntradaAgrupar.TextKey;

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