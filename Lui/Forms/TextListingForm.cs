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

namespace Lui.Forms
{
	public partial class TextListingForm :
	    Lui.Forms.ChildForm
	{
		public System.Text.StringBuilder ListingContent = new System.Text.StringBuilder();
                public Lfx.FileFormats.Office.Spreadsheet.Workbook Report;

		public virtual Lfx.Types.OperationResult RefreshList()
		{
			return new Lfx.Types.SuccessOperationResult();
		}

                public virtual Lfx.Types.OperationResult Print()
                {
                        Lfx.Types.OperationResult imprimirReturn = new Lfx.Types.SuccessOperationResult();

                        if (ListingContent != null && ListingContent.Length > 0) {
                                // Determino la impresora que le corresponde
                                string Impresora = this.Workspace.CurrentConfig.Printing.PreferredPrinter("Listados");

                                // Si es de carga manual, presento el formulario correspondiente
                                if (this.Workspace.CurrentConfig.Printing.PrinterFeed("Listados", "auto") == "manual") {
                                        Lbl.Impresion.ManualFeedDialog OFormFacturaCargaManual = new Lbl.Impresion.ManualFeedDialog();
                                        OFormFacturaCargaManual.DocumentName = "Papel para Listado";

                                        // Muestro el nombre de la impresora
                                        if (Impresora.Length > 0) {
                                                OFormFacturaCargaManual.PrinterName = Impresora;
                                        } else {
                                                System.Drawing.Printing.PrinterSettings
                                                    objPrint = new System.Drawing.Printing.PrinterSettings();
                                                OFormFacturaCargaManual.PrinterName = objPrint.PrinterName;
                                        }

                                        if (OFormFacturaCargaManual.ShowDialog() == DialogResult.Cancel)
                                                return new Lfx.Types.FailureOperationResult("Operación cancelada");
                                }

                                Lfx.Printing.TextPrint Documento = new Lfx.Printing.TextPrint(ListingContent.ToString());

                                if (Impresora.Length > 0)
                                        Documento.PrinterSettings.PrinterName = Impresora;

                                Documento.DocumentName = this.Text;

                                // Documento.PrintController = New System.Drawing.Printing.StandardPrintController
                                Documento.DefaultPageSettings.Margins.Left = 0;
                                Documento.DefaultPageSettings.Margins.Top = 0;
                                Documento.DefaultPageSettings.Margins.Right = 0;
                                Documento.DefaultPageSettings.Margins.Bottom = 0;
                                //TODO: fuente más pequeña para listados más anchos
                                Documento.Font = new Font("Courier New", 10, FontStyle.Bold);

                                try {
                                        Documento.Print();
                                } catch (Exception ex) {
                                        return new Lfx.Types.FailureOperationResult(ex.Message);
                                }
                        } else if (this.Report != null) {
                                ListingFormExport ExportForm = new ListingFormExport();
                                ExportForm.Report = this.Report;
                                ExportForm.Nombre = this.Text.Replace(":", "");
                                ExportForm.ShowDialog();
                        } else {
                                imprimirReturn.Success = false;
                                imprimirReturn.Message += "El listado no contiene datos.";
                        }

                        return imprimirReturn;
                }

		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmdMostrar_Click(object sender, System.EventArgs e)
		{
			RefreshList();
		}

		private void FormListado_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F7:
					e.Handled = true;
					if (cmdCopiar.Enabled && cmdCopiar.Visible)
						cmdCopiar.PerformClick();
					break;

				case Keys.F8:
					e.Handled = true;
					if (PrintButton.Enabled && PrintButton.Visible)
						PrintButton.PerformClick();
					break;

				case Keys.F9:
					e.Handled = true;
					if (cmdMostrar.Enabled && cmdMostrar.Visible)
						cmdMostrar.PerformClick();
					break;

				case Keys.Escape:
					this.Close();
					break;
			}
		}

		private void cmdImprimir_Click(object sender, System.EventArgs e)
		{
			if (RefreshList().Success == true)
			{
				Lfx.Types.OperationResult Res = this.Print();
				if (Res.Success == false && Res.Message != null)
					Lui.Forms.MessageBox.Show(Res.Message, "Error");
			}
		}

		private void cmdCopiar_Click(object sender, System.EventArgs e)
		{
			Clipboard.SetDataObject(ListingContent.ToString());
		}
	}
}