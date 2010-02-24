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
	public partial class AccountForm : Lui.Forms.ChildForm
	{
                protected internal string m_Tabla;
                public int m_Cliente;
                public Lfx.Types.DateRange m_Fechas = new Lfx.Types.DateRange("dia-0");
		protected Lfx.Data.SqlSelectBuilder m_SelectCommand;
		protected Lfx.Data.FormField[] m_FormFields;

                public AccountForm()
                {
                        InitializeComponent();

                        LowerPanel.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
                        EtiquetaTitulo.BackColor = Lws.Config.Display.CurrentTemplate.Header2Background;
                        EtiquetaTitulo.ForeColor = Lws.Config.Display.CurrentTemplate.Header2Text;
                }

		public virtual Lfx.Types.OperationResult RefreshList()
		{
			return new Lfx.Types.SuccessOperationResult();
		}


		public virtual Lfx.Types.OperationResult Print()
		{
			return new Lfx.Types.SuccessOperationResult();
		}


		public virtual void Cancel()
		{
			this.Close();
		}


		public virtual Lfx.Types.OperationResult Filter()
		{
			return new Lfx.Types.SuccessOperationResult();
		}


		private void cmdImprimir_Click(object sender, System.EventArgs e)
		{
			Print();
		}

		private void cmdFiltros_Click(object sender, System.EventArgs e)
		{
			Filter();
		}

		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			Cancel();
		}

		public virtual Lfx.Data.SqlSelectBuilder SelectCommand()
		{
			return null;
		}

                public virtual void ShowExportDialog()
                {
                        Lui.Forms.ListingFormExport OFormExportar = new Lui.Forms.ListingFormExport();
			OFormExportar.Workspace = this.Workspace;
			OFormExportar.Nombre = this.Text.Replace(":", "");
			OFormExportar.FormFields = m_FormFields;
			OFormExportar.SelectCommand = this.SelectCommand();
			OFormExportar.ShowDialog();
                }

		private void AccountForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false)
			{
				switch (e.KeyCode)
				{
					case Keys.R:
                                                if (e.Control == true && e.Shift == false) {
                                                        e.Handled = true;
                                                        this.ShowExportDialog();
                                                }
						break;
					case Keys.Escape:
						e.Handled = true;
						if (CancelCommandButton.Enabled && CancelCommandButton.Visible)
							CancelCommandButton.PerformClick();
						break;
					case Keys.F2:
						e.Handled = true;
						if (FilterButton.Enabled && FilterButton.Visible)
							FilterButton.PerformClick();
						break;
					case Keys.F9:
						e.Handled = true;
                                                this.RefreshList();
						break;
					case Keys.F8:
						e.Handled = true;
						if (PrintButton.Enabled && PrintButton.Visible)
							PrintButton.PerformClick();
						break;
				}

			}
		}


		private void lvItems_DoubleClick(object sender, System.EventArgs e)
		{
			Edit(CodigoSeleccionado());
		}


		private void lvItems_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0] == System.Convert.ToByte(Keys.Return))
			{
				e.Handled = true;
				Edit(CodigoSeleccionado());
			}
		}


                internal int CodigoSeleccionado()
                {
                        if (ItemList.SelectedItems.Count > 0) {
                                return int.Parse(ItemList.SelectedItems[0].Text);
                        }
                        return 0;
                }


		public virtual Lfx.Types.OperationResult Edit(int lCodigo)
		{
			return new Lfx.Types.SuccessOperationResult();
		}


		private void AccountForm_Activated(object sender, System.EventArgs e)
		{
			this.RefreshList();
		}

		private void lvItems_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up:
					if (ItemList.Items.Count == 0)
					{
						e.Handled = true;
						System.Windows.Forms.SendKeys.Send("+{tab}");
					}
					else if (ItemList.SelectedItems.Count > 0 && ItemList.SelectedItems[0].Index == 0)
					{
						e.Handled = true;
						System.Windows.Forms.SendKeys.Send("+{tab}");
					}
					break;

				case Keys.Down:
					if (ItemList.Items.Count == 0)
					{
						e.Handled = true;
						System.Windows.Forms.SendKeys.Send("{tab}");
					}
					else if (ItemList.SelectedItems.Count > 0 && ItemList.SelectedItems[0].Index == ItemList.Items.Count - 1)
					{
						e.Handled = true;
						System.Windows.Forms.SendKeys.Send("{tab}");
					}
					break;
			}
		}
	}
}