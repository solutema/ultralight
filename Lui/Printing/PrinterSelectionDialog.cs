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

namespace Lui.Printing
{
	public class PrinterSelectionDialog : Lui.Forms.DialogForm
	{

		internal string m_Resultado = "";
		internal string m_ExtraItems = "";
		private System.Windows.Forms.ColumnHeader NombreVisible;
		private bool m_VistaPrevia;

		#region Código generado por el Diseñador de Windows Forms

		public PrinterSelectionDialog()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
                internal Lui.Forms.ListView lvItems;
		private System.Windows.Forms.ColumnHeader Nombre;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
                        this.lvItems = new Lui.Forms.ListView();
			this.Nombre = new System.Windows.Forms.ColumnHeader();
			this.NombreVisible = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.DockPadding.All = 2;
			this.OkButton.Location = new System.Drawing.Point(164, 8);
			this.OkButton.Name = "OkButton";
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Location = new System.Drawing.Point(268, 8);
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// lvItems
			// 
			this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.Nombre,
																					  this.NombreVisible});
			this.lvItems.FullRowSelect = true;
			this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvItems.HideSelection = false;
			this.lvItems.Location = new System.Drawing.Point(8, 8);
			this.lvItems.Name = "lvItems";
			this.lvItems.Size = new System.Drawing.Size(360, 172);
			this.lvItems.TabIndex = 0;
			this.lvItems.View = System.Windows.Forms.View.Details;
			this.lvItems.DoubleClick += new System.EventHandler(this.lvItems_DoubleClick);
			this.lvItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvItems_KeyUp);
			// 
			// Nombre
			// 
			this.Nombre.Text = "Nombre";
			this.Nombre.Width = 0;
			// 
			// NombreVisible
			// 
			this.NombreVisible.Text = "Nombre";
			this.NombreVisible.Width = 300;
			// 
			// PrinterSelectionDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(374, 239);
			this.Controls.Add(this.lvItems);
			this.Name = "PrinterSelectionDialog";
			this.Text = "Seleccionar Impresora";
			this.Activated += new System.EventHandler(this.FormSeleccionarImpresora_Activated);
			this.ResumeLayout(false);

		}


		#endregion

		public bool VistaPrevia
		{
			get
			{
				return m_VistaPrevia;
			}
			set
			{
				m_VistaPrevia = value;
			}
		}

		private void FormSeleccionarImpresora_Activated(object sender, System.EventArgs e)
		{
			lvItems.Items.Clear();
			if(m_VistaPrevia) {
				ListViewItem itm = new ListViewItem("lazaro!preview");
				itm.SubItems.Add("Mostrar Vista Previa en Pantalla");
				lvItems.Items.Add(itm);
			}

			foreach(string Impresora in System.Drawing.Printing.PrinterSettings.InstalledPrinters) {
				ListViewItem Itm = lvItems.Items.Add(Impresora);
                                if (Impresora.Length > 1 && Impresora.Substring(0, 2) == @"\\" && Impresora.IndexOf(@"|") == -1) {
                                        string NombreImpresora = Impresora.Substring(2, Impresora.Length - 2);
                                        string Estacion = Lfx.Types.Strings.GetNextToken(ref NombreImpresora, @"\");
                                        Itm.SubItems.Add(NombreImpresora + " en " + Lfx.Types.Strings.ULCase(Estacion) + " (impresora remota)");
                                } else {
                                        Itm.SubItems.Add(Impresora + " (impresora local)");
                                }

				if(Impresora == m_Resultado) {
					if(lvItems.SelectedItems.Count > 0)
						lvItems.SelectedItems[0].Selected = false;

					Itm.Selected = true;
					Itm.Focused = true;
				}
			}
			string Extras = Lfx.Types.Strings.GetNextToken(ref m_ExtraItems, ",");
			while(Extras.Length > 0) {
				ListViewItem Itm = lvItems.Items.Add(Extras);
				if(Extras.IndexOf(@"|") != -1) {
					string NombreVisible = Extras;
					string NombreOculto = Lfx.Types.Strings.GetNextToken(ref NombreVisible, @"|");
					Itm.Text = NombreOculto;
					Itm.SubItems.Add(NombreVisible);
				} else {
					Itm.SubItems.Add(Extras);
				}
				if(Extras == m_Resultado) {
					if(lvItems.SelectedItems.Count > 0)
						lvItems.SelectedItems[0].Selected = false;

					Itm.Selected = true;
					Itm.Focused = true;
				}
				Extras = Lfx.Types.Strings.GetNextToken(ref m_ExtraItems, ",");
			}
			lvItems.Columns[1].Width = -2;
			if(lvItems.Items.Count > 0 && lvItems.SelectedItems.Count == 0) {
				lvItems.Items[0].Selected = true;
				lvItems.Items[0].Focused = true;
			}
		}


		public override Lfx.Types.OperationResult Ok()
		{
			if(lvItems.SelectedItems != null) {
				m_Resultado = lvItems.SelectedItems[0].Text;
				if(m_Resultado == "Mostrar Vista Previa en Pantalla")
					m_Resultado = "lazaro!preview";
			}
			this.DialogResult = DialogResult.OK;
			this.Hide();
			return new Lfx.Types.SuccessOperationResult();
		}


		private void lvItems_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return) {
				e.Handled = true;
				this.Ok();
			}
		}


		private void lvItems_DoubleClick(object sender, System.EventArgs e)
		{
			this.Ok();
		}

		public string SelectedPrinter
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

		public string ExtraItems
		{
			get
			{
				return m_ExtraItems;
			}
			set
			{
				m_ExtraItems = value;
			}
		}


	}
}