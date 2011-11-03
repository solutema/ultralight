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
using System.Text;

namespace Lazaro.Pres.Spreadsheet
{
        public class Workbook
        {
                public System.Collections.Generic.List<Sheet> Sheets = new List<Sheet>();

                public void SaveTo(string fileName, SaveFormats format)
                {
                        SaveTo(fileName, format, null);
                }

                public void Print()
                {
                        this.Print(PrintModes.Automatic);
                }

                public void Print(PrintModes printMode)
                {
                        PrintModes FinalPrintMode = printMode;
                        if (FinalPrintMode == PrintModes.Automatic) {
                                if (ExternalPrograms.MsOffice.IsExcelInstalled())
                                        FinalPrintMode = PrintModes.MsOffice;
                                else if (ExternalPrograms.OpenOffice.IsCalcInstalled())
                                        FinalPrintMode = PrintModes.OpenOffice;
                        }

                        switch (FinalPrintMode) {
                                case PrintModes.OpenOffice:
                                        string TempCalcFileName = Lfx.Environment.Folders.TemporaryFolder + System.IO.Path.GetFileName(System.IO.Path.GetRandomFileName()) + ".xml";
                                        this.SaveTo(TempCalcFileName, SaveFormats.ExcelXml);
                                        ExternalPrograms.OpenOffice.PrintWithCalc(TempCalcFileName);
                                        break;
                                case PrintModes.MsOffice:
                                        string TempExcelFileName = Lfx.Environment.Folders.TemporaryFolder + System.IO.Path.GetFileName(System.IO.Path.GetRandomFileName()) + ".xml";
                                        this.SaveTo(TempExcelFileName, SaveFormats.ExcelXml);
                                        ExternalPrograms.MsOffice.PrintWithExcel(TempExcelFileName);
                                        break;
                                default:
                                        throw new NotImplementedException();
                        }
                }

                public void SaveTo(string fileName, SaveFormats format, Sheet sheet)
                {
                        System.IO.StreamWriter wr = new System.IO.StreamWriter(new System.IO.FileStream(fileName, System.IO.FileMode.Create));
                        switch (format) {
                                case SaveFormats.ExcelXml:
                                        wr.Write(this.ToExcelXml(sheet));
                                        break;
                                case SaveFormats.Html:
                                        wr.Write(this.ToHtml(sheet));
                                        break;
                        }
                        wr.Close();
                }

                protected internal string ToHtml(Sheet sheet)
                {
                        System.Text.StringBuilder Result = new StringBuilder();
                        Result.AppendLine("<html>");
                        Result.AppendLine(@"<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />");
                        Result.AppendLine(@"<style>");
                        Result.AppendLine(@"@media print { body { margin: 0; padding: 0 } }");
                        Result.AppendLine(@"body, table, td { font-family: Trebuchet MS, Helvetica, Sans Serif; font-size: 10pt; }");
                        Result.AppendLine(@".StyleTable, table { border-collapse: collapse; empty-cells: show; border: 1px solid gray; }");
                        Result.AppendLine(@".StyleTableCaption, caption { font-size: large; background-color: #C5D900; padding: 4px; }");
                        Result.AppendLine(@".StyleTableHead, thead { display: table-header-group; }");
                        Result.AppendLine(@".StyleColumnHeader, th { padding: 2px; background-color: #C5D9F1; font-weight: bold; }");
                        Result.AppendLine(@".StyleDataRow, tr { page-break-inside: avoid; background-color: white; border-bottom: 1px solid silver; }");
                        Result.AppendLine(@".StyleDataCell, td { padding: 2px; }");
                        Result.AppendLine(@"</style>");

                        Result.AppendLine("<body>");
                        if (sheet == null) {
                                //All sheets
                                foreach (Sheet sht in Sheets) {
                                        Result.AppendLine(sht.ToHtml());
                                }
                        } else {
                                //One sheet
                                Result.AppendLine(sheet.ToHtml());
                        }

                        Result.AppendLine("</body>");
                        Result.AppendLine("</html>");

                        return Result.ToString();
                }

                protected internal string ToExcelXml(Sheet sheet)
                {
                        System.Text.StringBuilder Result = new StringBuilder();

                        Result.AppendLine(@"<?xml version=""1.0""?>");
                        Result.AppendLine(@"<?mso-application progid=""Excel.Sheet""?>");
                        Result.AppendLine(@"<Workbook xmlns:x=""urn:schemas-microsoft-com:office:excel"" xmlns=""urn:schemas-microsoft-com:office:spreadsheet"" xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">");
                        Result.AppendLine(@" <Styles>");
                        Result.AppendLine(@"  <Style ss:ID=""Default"" ss:Name=""Normal"">");
                        Result.AppendLine(@"   <Alignment ss:Vertical=""Bottom""/>");
                        Result.AppendLine(@"   <Borders/>");
                        Result.AppendLine(@"   <Font/>");
                        Result.AppendLine(@"   <Interior/>");
                        Result.AppendLine(@"   <NumberFormat/>");
                        Result.AppendLine(@"   <Protection/>");
                        Result.AppendLine(@"  </Style>");
                        Result.AppendLine(@"  <Style ss:ID=""StyleData"">");
                        Result.AppendLine(@"  </Style>");
                        Result.AppendLine(@"  <Style ss:ID=""StyleHeader"">");
                        Result.AppendLine(@"   <Font x:Family=""Swiss"" ss:Bold=""1""/>");
                        Result.AppendLine(@"   <Interior ss:Color=""#C5D9F1"" ss:Pattern=""Solid""/>");
                        Result.AppendLine(@"  </Style>");
                        Result.AppendLine(@" </Styles>");

                        if (sheet == null) {
                                //All sheets
                                foreach (Sheet sht in Sheets) {
                                        Result.AppendLine(sht.ToExcelXml());
                                }
                        } else {
                                //One sheet
                                Result.AppendLine(sheet.ToExcelXml());
                        }

                        Result.AppendLine("</Workbook>");

                        return Result.ToString();
                }

                public Sheet GetSheetByName(string name)
                {
                        foreach (Sheet sht in Sheets) {
                                if (sht.Name == name)
                                        return sht;
                        }
                        return null;
                }
        }
}
