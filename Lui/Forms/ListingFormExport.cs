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

namespace Lui.Forms
{
	public partial class ListingFormExport : Lui.Forms.DialogForm
	{
		public Lfx.Data.SqlSelectBuilder SelectCommand;
		public Lfx.Data.FormField[] FormFields;
		public Lfx.Data.FormField KeyField;
		public string Nombre = "Datos Exportados del sistema Lázaro";
                public Lfx.FileFormats.Office.Spreadsheet.Workbook Report = null;

		private string GetFileName(Lfx.FileFormats.Office.Spreadsheet.SaveFormats Tipo)
		{
			SaveFileDialog DialogoGuardar = new SaveFileDialog();
			DialogoGuardar.OverwritePrompt = true;
			DialogoGuardar.ValidateNames = true;
			DialogoGuardar.CheckPathExists = true;
			switch (Tipo)
			{
				case Lfx.FileFormats.Office.Spreadsheet.SaveFormats.Html:
					DialogoGuardar.DefaultExt = ".html";
					DialogoGuardar.Filter = "Formato HTML|*.htm;*.html";
					break;
				case Lfx.FileFormats.Office.Spreadsheet.SaveFormats.ExcelXml:
					DialogoGuardar.DefaultExt = ".xls";
					DialogoGuardar.Filter = "Formato XML de Microsoft Excel|*.xls";
					break;
			}

			DialogoGuardar.FileName = Nombre;
			if (DialogoGuardar.ShowDialog() == DialogResult.OK)
				return DialogoGuardar.FileName;
			else
				return "";
		}


		public Lfx.FileFormats.Office.Spreadsheet.Workbook ToWorkbook()
		{
			Lfx.FileFormats.Office.Spreadsheet.Workbook Planilla = new Lfx.FileFormats.Office.Spreadsheet.Workbook();
			Planilla.Sheets.Add(new Lfx.FileFormats.Office.Spreadsheet.Sheet(Nombre));

			// Exporto los encabezados de columna
			if(KeyField != null && KeyField.Width > 28) {
				Planilla.Sheets[0].ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader(KeyField.Label, KeyField.Width));
			}

                        if (FormFields != null) {
                                for (int i = 0; i <= FormFields.Length - 1; i++) {
                                        if (FormFields[i].Width > 28) {
                                                Planilla.Sheets[0].ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader(FormFields[i].Label, FormFields[i].Width));
                                        }
                                }
                        }

			// Exporto los renglones
			System.Data.DataTable Tabla = this.DataView.DataBase.Select(this.SelectCommand);
			foreach (System.Data.DataRow Registro in Tabla.Rows)
			{
				Lfx.FileFormats.Office.Spreadsheet.Row Reng = new Lfx.FileFormats.Office.Spreadsheet.Row();

				for(int i = KeyField == null ? 0 : -1; i < FormFields.Length; i++)
				{
					Lfx.Data.FormField ThisField;
					if(i == -1)
						ThisField = KeyField;
					else
						ThisField = FormFields[i];

					int FieldNum = KeyField == null ? i : i + 1;

					if(ThisField.Width > 28)
					{
						string TextoSubItem;
						TextoSubItem = Registro[FieldNum].ToString();

						switch(ThisField.DataType)
						{
                                                        case Lfx.Data.InputFieldTypes.Text:
                                                        case Lfx.Data.InputFieldTypes.Memo:
								Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(TextoSubItem));
								break;
                                                        case Lfx.Data.InputFieldTypes.Serial:
                                                        case Lfx.Data.InputFieldTypes.Integer:
								Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToInt32(Registro[FieldNum])));
								break;
                                                        case Lfx.Data.InputFieldTypes.Numeric:
                                                        case Lfx.Data.InputFieldTypes.Currency:
								Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDouble(Registro[FieldNum])));
								break;
                                                        case Lfx.Data.InputFieldTypes.DateTime:
                                                        case Lfx.Data.InputFieldTypes.Date:
								Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDateTime(Registro[FieldNum])));
								break;
                                                        case Lfx.Data.InputFieldTypes.Bool:
                                                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToBoolean(Registro[FieldNum])));
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.Binary:
                                                        case Lfx.Data.InputFieldTypes.Image:
                                                                Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(Registro[FieldNum]));
                                                                break;
							default:
								if(Lfx.Types.Strings.IsNumericFloat(TextoSubItem))
									Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(System.Convert.ToDouble(Registro[FieldNum])));
								else
									Reng.Cells.Add(new Lfx.FileFormats.Office.Spreadsheet.Cell(TextoSubItem));
								break;
						}
					}
				}
				Planilla.Sheets[0].Rows.Add(Reng);
			}

			return Planilla;
		}


                internal void Export(Lfx.FileFormats.Office.Spreadsheet.SaveFormats Tipo)
		{
			string FileName = this.GetFileName(Tipo);
                        if (FileName.Length > 0) {
                                if (this.Report == null)
                                        this.Report = this.ToWorkbook();
                                try {
                                        this.Report.SaveTo(FileName, Tipo);
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                } catch (Exception ex) {
                                        Lui.Forms.MessageBox.Show(ex.Message, "Error");
                                }
                        }
		}

                internal void Print()
                {
                        if (this.Report == null)
                                this.Report = this.ToWorkbook();
                        this.Report.Print();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                }


		private void cmdHTML_Click(object sender, System.EventArgs e)
		{
			Export(Lfx.FileFormats.Office.Spreadsheet.SaveFormats.Html);
		}


		private void cmdExcel_Click(object sender, System.EventArgs e)
		{
			Export(Lfx.FileFormats.Office.Spreadsheet.SaveFormats.ExcelXml);
		}


		private void FormTablaInicioExportar_Load(object sender, System.EventArgs e)
		{
			OkButton.Visible = false;
		}

                private void cmdImprimir_Click(object sender, EventArgs e)
                {
                        Print();
                }
	}
}