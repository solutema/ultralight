#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lui.Printing
{
        public partial class PrinterSelectionDialog : Lui.Forms.DialogForm
	{
		private Lbl.Impresion.Impresora m_Resultado = null;
                protected string m_ExtraItems = "";
		private System.Windows.Forms.ColumnHeader NombreVisible;
                public bool MuestraImpresorasDeWindows = true, MuestraImpresorasLazaro = true;

                public PrinterSelectionDialog()
                {
                        InitializeComponent();
                }


                private void AgregarImpresora(Lbl.Impresion.Impresora impresora)
                {
                        ListViewItem Itm = Listado.Items.Add(impresora.Id.ToString());
                        Itm.SubItems.Add(impresora.Nombre);
                        Itm.Tag = impresora;

                        if (impresora == m_Resultado) {
                                if (Listado.SelectedItems.Count > 0)
                                        Listado.SelectedItems[0].Selected = false;

                                Itm.Selected = true;
                                Itm.Focused = true;
                        }
                }

		private void FormSeleccionarImpresora_Activated(object sender, System.EventArgs e)
		{
			Listado.Items.Clear();

                        if (MuestraImpresorasLazaro) {
                                Lbl.ColeccionGenerica<Lbl.Impresion.Impresora> Impresoras = Lbl.Sys.Config.Actual.Impresion.Impresoras;
                                if (Impresoras != null) {
                                        foreach (Lbl.Impresion.Impresora Impresora in Impresoras) {
                                                this.AgregarImpresora(Impresora);
                                        }
                                }
                        }

                        if (MuestraImpresorasDeWindows) {
                                foreach (string NombreImpresora in PrinterSettings.InstalledPrinters) {
                                        //PrinterSettings PrinterInfo = new PrinterSettings();
                                        //PrinterInfo.PrinterName = Impresora;

                                        Lbl.Impresion.Impresora Impr = Lbl.Impresion.Impresora.InstanciarImpresoraLocal(this.Connection, NombreImpresora);
                                        this.AgregarImpresora(Impr);
                                }
                        }
			
			Listado.Columns[1].Width = -2;
			if(Listado.Items.Count > 0 && Listado.SelectedItems.Count == 0) {
				Listado.Items[0].Selected = true;
				Listado.Items[0].Focused = true;
			}
		}


                public override Lfx.Types.OperationResult Ok()
                {
                        if (Listado.SelectedItems != null && Listado.SelectedItems.Count > 0)
                                m_Resultado = Listado.SelectedItems[0].Tag as Lbl.Impresion.Impresora;

                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                        return base.Ok();
                }


		private void Listado_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return) {
				e.Handled = true;
				this.Ok();
			}
		}


		private void Listado_DoubleClick(object sender, System.EventArgs e)
		{
			this.Ok();
		}

		public Lbl.Impresion.Impresora SelectedPrinter
		{
			get
			{
				return m_Resultado;
			}
			set
			{
				m_Resultado = value;
			}
		}
	}
}