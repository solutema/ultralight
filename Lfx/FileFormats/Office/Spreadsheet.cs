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
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace Lfx.FileFormats.Office.Spreadsheet
{
	public enum SaveFormats
	{
		ExcelXml,
		Html,
		Text
	}

        public enum PrintMode
        {
                Automatic,
                MsOffice,
                OpenOffice,
        }

        internal static class ExternalPrograms
        {
                internal static class OpenOffice
                {
                        internal static string GetPath()
                        {
                                // FIXME: versión Linux
                                string Res = null;
                                RegistryKey ProgKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OpenOffice.org\OpenOffice.org", false);
                                if (ProgKey != null) {

                                        foreach (string Version in ProgKey.GetSubKeyNames()) {
                                                RegistryKey ProgVersionKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OpenOffice.org\OpenOffice.org\" + Version, false);
                                                if (ProgVersionKey != null && ProgVersionKey.GetValue("Path") != null) {
                                                        Res = System.IO.Path.GetDirectoryName(ProgVersionKey.GetValue("Path").ToString());
                                                        ProgVersionKey.Close();
                                                        break;
                                                }
                                                ProgVersionKey.Close();
                                        }
                                        ProgKey.Close();
                                        if (Res != null && Res.Substring(Res.Length - 1, 1) != System.IO.Path.DirectorySeparatorChar.ToString())
                                                Res += System.IO.Path.DirectorySeparatorChar;
                                }
                                return Res;
                        }

                        internal static bool IsCalcInstalled()
                        {
                                string SofficePath = GetPath();
                                if (SofficePath != null)
                                        return System.IO.File.Exists(SofficePath + "scalc.exe");
                                else
                                        return false;
                        }

                        internal static void PrintWithCalc(string fileName)
                        {
                                string SofficePath = GetPath();
                                if (SofficePath != null) {
                                        Lfx.Environment.Shell.Execute(SofficePath + "scalc.exe", @"-pt """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Normal, false);
                                }
                        }
                }

                internal static class MsOffice
                {
                        internal static string GetPath()
                        {
                                if (Lfx.Environment.SystemInformation.Platform != Lfx.Environment.SystemInformation.Platforms.Windows)
                                        return null;

                                string Res = null;
                                RegistryKey ProgKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Office", false);
                                if (ProgKey != null) {

                                        foreach (string Version in ProgKey.GetSubKeyNames()) {
                                                RegistryKey ProgVersionKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Office\" + Version + @"\Excel\InstallRoot", false);
                                                if (ProgVersionKey != null) {
                                                        if (ProgVersionKey.GetValue("Path") != null) {
                                                                Res = System.IO.Path.GetDirectoryName(ProgVersionKey.GetValue("Path").ToString());
                                                                ProgVersionKey.Close();
                                                                break;
                                                        }
                                                        ProgVersionKey.Close();
                                                }
                                        }
                                        ProgKey.Close();
                                        if (Res != null && Res.Substring(Res.Length - 1, 1) != System.IO.Path.DirectorySeparatorChar.ToString())
                                                Res += System.IO.Path.DirectorySeparatorChar;
                                }
                                return Res;
                        }

                        internal static bool IsExcelInstalled()
                        {
                                string OfficePath = GetPath();
                                if (OfficePath != null)
                                        return System.IO.File.Exists(OfficePath + "excel.exe");
                                else
                                        return false;
                        }

                        internal static void PrintWithExcel(string fileName)
                        {
                                string OfficePath = GetPath();
                                if (OfficePath != null) {
                                        Lfx.Environment.Shell.Execute(OfficePath + "excel.exe", @"/e """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Normal, false);
                                }
                        }
                }
        }

	public class Workbook
	{
		public System.Collections.Generic.List<Sheet> Sheets = new List<Sheet>();

		public void SaveTo(string fileName, SaveFormats format)
		{
			SaveTo(fileName, format, null);
		}

                public void Print()
                {
                        this.Print(PrintMode.Automatic);
                }

                public void Print(PrintMode printMode)
                {
                        PrintMode FinalPrintMode = printMode;
                        if (FinalPrintMode == PrintMode.Automatic) {
                                if (ExternalPrograms.MsOffice.IsExcelInstalled())
                                        FinalPrintMode = PrintMode.MsOffice;
                                else if (ExternalPrograms.OpenOffice.IsCalcInstalled())
                                        FinalPrintMode = PrintMode.OpenOffice;
                        }

                        switch (FinalPrintMode) {
                                case PrintMode.OpenOffice:
                                        string TempCalcFileName = Lfx.Environment.Folders.TemporaryFolder + System.IO.Path.GetFileName(System.IO.Path.GetRandomFileName()) + ".xml";
                                        this.SaveTo(TempCalcFileName, SaveFormats.ExcelXml);
                                        ExternalPrograms.OpenOffice.PrintWithCalc(TempCalcFileName);
                                        break;
                                case PrintMode.MsOffice:
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
			switch(format)
			{
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
			Result.AppendLine(@"body, table, td { font-family: Helvetica, Sans Serif; font-size: medium }");
			Result.AppendLine(@".StyleTable, table { border-collapse: collapse; empty-cells: show; border: 1px solid gray }");
			Result.AppendLine(@".StyleHeader, th { background-color: #C5D9F1; font-weight: bold }");
			Result.AppendLine(@".StyleData, tr { }");
			Result.AppendLine(@"caption { font-size: large }");
			Result.AppendLine(@"</style>");

			Result.AppendLine("<body>");
			if (sheet == null)
			{
				//All sheets
				foreach (Sheet sht in Sheets)
				{
					Result.AppendLine(sht.ToHTML());
				}
			}
			else
			{
				//One sheet
				Result.AppendLine(sheet.ToHTML());
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

			if (sheet == null)
			{
				//All sheets
				foreach (Sheet sht in Sheets)
				{
					Result.AppendLine(sht.ToExcelXml());
				}
			}
			else
			{
				//One sheet
				Result.AppendLine(sheet.ToExcelXml());
			}

			Result.AppendLine("</Workbook>");

			return Result.ToString();
		}

		public Sheet GetSheetByName(string name)
		{
			foreach (Sheet sht in Sheets)
			{
				if (sht.Name == name)
					return sht;
			}
			return null;
		}
	}

	public class Sheet
	{
		public string Name = "untitled";
		public System.Collections.Generic.List<ColumnHeader> ColumnHeaders = new List<ColumnHeader>();
		public System.Collections.Generic.List<Row> Rows = new List<Row>();
                public Workbook Workbook;
                public System.Drawing.Color BackColor = System.Drawing.Color.Empty;
                public System.Drawing.Color ForeColor = System.Drawing.Color.Empty;

		public Sheet(string name)
		{
			this.Name = name;
		}

		public int Width
		{
			get
			{
				int Result = this.ColumnHeaders.Count;
				foreach (Row rw in this.Rows)
				{
					if (rw.Cells.Count > Result)
						Result = rw.Cells.Count;
				}
				return Result;
			}
		}

                public System.Windows.Forms.ListView ToListView()
                {
                        System.Windows.Forms.ListView Result = new System.Windows.Forms.ListView();
                        Result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        Result.LabelEdit = false;
                        Result.LabelWrap = false;
                        return this.ToListView(Result);
                }

                public System.Windows.Forms.ListView ToListView(System.Windows.Forms.ListView initialListView)
                {
                        initialListView.SuspendLayout();
                        initialListView.BeginUpdate();

                        initialListView.Items.Clear();
                        initialListView.View = System.Windows.Forms.View.Details;
                        initialListView.FullRowSelect = true;
                        initialListView.GridLines = true;
                        initialListView.Groups.Clear();

                        if (this.BackColor != System.Drawing.Color.Empty)
                                initialListView.BackColor = this.BackColor;
                        if (this.ForeColor != System.Drawing.Color.Empty)
                                initialListView.ForeColor = this.ForeColor;

                        if (this.ColumnHeaders != null) {
                                initialListView.Columns.Clear();
                                foreach (ColumnHeader ch in this.ColumnHeaders) {
                                        System.Windows.Forms.ColumnHeader Col = initialListView.Columns.Add(ch.Text, ch.Width);
                                        switch (ch.TextAlignment) {
                                                case Lfx.Types.StringAlignment.Near:
                                                        Col.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                                                        break;
                                                case Lfx.Types.StringAlignment.Far:
                                                        Col.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                                                        break;
                                        }
                                }
                        }

                        System.Windows.Forms.ListViewGroup LastGroup = null;

                        foreach (Row rw in this.Rows) {
                                if (rw is HeaderRow) {
                                        LastGroup = new System.Windows.Forms.ListViewGroup(rw.Cells[0].Content.ToString());
                                        initialListView.Groups.Add(LastGroup);
                                } else {
                                        System.Windows.Forms.ListViewItem Itm = new System.Windows.Forms.ListViewItem();

                                        if (rw is AggregationRow) {
                                                //Itm.BackColor = System.Drawing.Color.LightGray;
                                                Itm.Font = new System.Drawing.Font(Itm.Font, System.Drawing.FontStyle.Bold);
                                        }

                                        if (LastGroup != null) {
                                                Itm.Group = LastGroup;
                                        }

                                        if (rw.BackColor != System.Drawing.Color.Empty)
                                                Itm.BackColor = rw.BackColor;
                                        if (rw.ForeColor != System.Drawing.Color.Empty)
                                                Itm.ForeColor = rw.ForeColor;

                                        int i = 0;
                                        foreach (Cell cl in rw.Cells) {
                                                string CellString = "";
                                                if (cl.Content != null) {
                                                        switch (cl.Content.GetType().ToString()) {
                                                                case "System.Single":
                                                                case "System.Decimal":
                                                                case "System.Double":
                                                                        CellString += Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(cl.Content), 2);
                                                                        break;
                                                                case "System.Integer":
                                                                case "System.Int16":
                                                                case "System.Int32":
                                                                case "System.Int64":
                                                                        CellString += cl.Content.ToString();
                                                                        break;
                                                                case "System.DateTime":
                                                                        DateTime clContent = (DateTime)cl.Content;
                                                                        if (clContent.Hour == 0 && clContent.Minute == 0 && clContent.Second == 0)
                                                                                CellString += clContent.ToString(Lfx.Types.Formatting.DateTime.DefaultDateFormat);
                                                                        else
                                                                                CellString += clContent.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat);
                                                                        break;
                                                                case "System.String":
                                                                        CellString += cl.Content.ToString();
                                                                        break;
                                                        }
                                                }
                                                if (i == 0)
                                                        Itm.Text = CellString;
                                                else
                                                        Itm.SubItems.Add(CellString);
                                                i++;
                                        }
                                        initialListView.Items.Add(Itm);
                                }
                        }
                        initialListView.EndUpdate();
                        initialListView.ResumeLayout();

                        return initialListView;
                }

		protected internal string ToHTML()
		{
			System.Text.StringBuilder Result = new StringBuilder();

			Result.AppendLine(@"<table width=""100%"" class=""StyleTable"">");
			Result.AppendLine("<caption>" + this.Name + "</caption>");

			//Column headers
			Result.AppendLine("<tr>");
			foreach (ColumnHeader ch in this.ColumnHeaders)
			{
				Result.AppendLine(@"<th class=""StyleHeader"">" + ch.Text + "</th>");
			}
			Result.AppendLine("</tr>");

			//Data
			Result.AppendLine("<tbody>");
			foreach (Row rw in this.Rows)
			{
				Result.AppendLine("<tr>");
				foreach (Cell cl in rw.Cells)
				{
					string CellString = @"<td class=""StyleData"">";
					if (cl.Content != null)
					{
						switch (cl.Content.GetType().ToString())
						{
							case "System.Single":
							case "System.Decimal":
							case "System.Double":
								CellString += Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(cl.Content), 8);
								break;
							case "System.Integer":
							case "System.Int16":
							case "System.Int32":
							case "System.Int64":
								CellString += cl.Content.ToString();
								break;
							case "System.DateTime":
								CellString += cl.Content.ToString();
								break;
							case "System.String":
								CellString += cl.Content.ToString();
								break;
						}
					}
					CellString += "</td>";
					Result.AppendLine(CellString);
				}
				Result.AppendLine("</tr>");
			}
			Result.AppendLine("</tbody>");
			Result.AppendLine("</table>");

			return Result.ToString();
		}

		protected internal string ToExcelXml()
		{
			System.Text.StringBuilder Result = new StringBuilder();

			if(this.Name != null && this.Name.Length > 0)
				Result.AppendLine(@"<Worksheet ss:Name=""" + this.Name.Substring(0, this.Name.Length > 31 ? 31 : this.Name.Length) + @""">");
			else
				Result.AppendLine(@"<Worksheet ss:Name=""sin título"">");
			Result.AppendLine(@"<ss:Table>");

			//Column headers
			int i = 0;
			foreach (ColumnHeader ch in this.ColumnHeaders)
			{
				string ColDef = @"<ss:Column ss:Index=""" + (++i).ToString() + @"""";
				if(ch.Width > 0)
					ColDef += @" ss:Width=""" + ch.Width.ToString() + @"""";
				ColDef += @" ss:AutoFitWidth=""1""/>";
				Result.AppendLine(ColDef);
			}

			Result.AppendLine(@"<ss:Row>");
			foreach (ColumnHeader ch in this.ColumnHeaders)
			{
				Result.AppendLine(@"<ss:Cell ss:StyleID=""StyleHeader""><Data ss:Type=""String"">" + ch.Text + @"</Data></ss:Cell>");
			}
			Result.AppendLine(@"</ss:Row>");

			//Data
			foreach (Row rw in this.Rows)
			{
				Result.AppendLine(@"<ss:Row>");
				foreach (Cell cl in rw.Cells)
				{
					string CellString = @"<ss:Cell ss:StyleID=""StyleData""";
					if (cl.Formula != null)
						CellString += @" ss:Formula=""" + cl.Formula.ToString() + @"""";

					CellString += ">";
					if(cl.Content != null)
					{
						switch (cl.Content.GetType().ToString())
						{
							case "System.Single":
							case "System.Decimal":
							case "System.Double":
								CellString += @"<Data ss:Type=""Number"">" + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(cl.Content), 8) + @"</Data>";
								break;
							case "System.Integer":
							case "System.Int16":
							case "System.Int32":
							case "System.Int64":
								CellString += @"<Data ss:Type=""Number"">" + cl.Content.ToString() + @"</Data>";
								break;
							case "System.DateTime":
                                                                CellString += @"<Data ss:Type=""String"">";
                                                                DateTime clContent = (DateTime)cl.Content;
                                                                if (clContent.Hour == 0 && clContent.Minute == 0 && clContent.Second == 0)
                                                                        CellString += clContent.ToString(Lfx.Types.Formatting.DateTime.DefaultDateFormat);
                                                                else
                                                                        CellString += clContent.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat);
                                                                CellString += @"</Data>";
								break;
							case "System.String":
								CellString += @"<Data ss:Type=""String"">" + cl.Content.ToString() + @"</Data>";
								break;
						}
					}
					CellString += @"</ss:Cell>";
					Result.AppendLine(CellString);
				}
				Result.AppendLine(@"</ss:Row>");
			}
			Result.AppendLine(@"</ss:Table>");
			Result.AppendLine(@"</Worksheet>");

			return Result.ToString();
		}

                public void Sort(int column, bool ascending)
                {
                        if (ascending) {
                                this.Rows.Sort(delegate(Row r1, Row r2)
                                {
                                        return r1.Cells[column].CompareTo(r2.Cells[column]);
                                });
                        } else {
                                this.Rows.Sort(delegate(Row r1, Row r2)
                                {
                                        return r2.Cells[column].CompareTo(r1.Cells[column]);
                                });
                        }
                }
	}

	public class ColumnHeader
	{
		public string Text = null;
		public int Width = 0;
                public Lfx.Types.StringAlignment TextAlignment = Lfx.Types.StringAlignment.Near;

		public ColumnHeader(string text)
		{
			this.Text = text;
		}


		public ColumnHeader(string text, int width)
			:this(text)
		{
			this.Width = width;
		}

                public ColumnHeader(string text, int width, Lfx.Types.StringAlignment textAlignment)
                        : this(text, width)
                {
                        this.TextAlignment = textAlignment;
                }
	}

	public class Row
	{
		public System.Collections.Generic.List<Cell> Cells = new List<Cell>();
                public System.Drawing.Color BackColor = System.Drawing.Color.Empty;
                public System.Drawing.Color ForeColor = System.Drawing.Color.Empty;

                public override string ToString()
                {
                        string Res = null;
                        foreach (Cell Cl in Cells) {
                                if (Res == null)
                                        Res = "Row cells: " + Cl.ToString();
                                else
                                        Res += "; " + Cl.ToString();
                        }
                        return Res;
                }
	}

        public class HeaderRow : Row
        {
                public HeaderRow(string text)
                        : base()
                {
                        this.Cells.Add(new Cell(text));
                }
        }

        public class AggregationRow : Row
        {
        }

	public class Cell : System.IComparable<Cell>
	{
		public object Content = null;
		public object Formula = null;

		public Cell(object content)
		{
			this.Content = content;
		}

		public Cell(Formula formula)
		{
			this.Formula = formula;
		}

                public Cell(Formula formula, object altContent)
                {
                        this.Formula = formula;
                        this.Content = altContent;
                }

                public override string ToString()
                {
                        if (this.Content != null)
                                return this.Content.ToString();
                        else if (this.Formula != null)
                                return this.Formula.ToString();
                        else
                                return "(empty cell)";
                }

                public int CompareTo(Cell cl2)
                {
                        if (this.Content == null || cl2.Content == null)
                                return 0;
                        else if (this.Content is double && cl2.Content is double)
                                return ((double)(this.Content)).CompareTo(cl2.Content);
                        else if (this.Content is int && cl2.Content is int)
                                return ((int)(this.Content)).CompareTo(cl2.Content);
                        else if (this.Content is string && cl2.Content is string)
                                return ((string)(this.Content)).CompareTo(cl2.Content);
                        else
                                return 0;
                }
	}

	public class Formula
	{
		public string Text;

		public Formula(string text)
		{
			this.Text = text;
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
