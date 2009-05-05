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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
	public class WorkspaceSelectorForm : Lui.Forms.DialogForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox Espacios;
		private System.ComponentModel.IContainer components = null;
		private string m_WorkspaceName = null;

                public WorkspaceSelectorForm()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
			CancelCommandButton.Text = "Cancelar";
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
                        this.label1 = new System.Windows.Forms.Label();
                        this.Espacios = new System.Windows.Forms.ListBox();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(258, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(366, 8);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.Location = new System.Drawing.Point(16, 16);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(444, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Por favor seleccione el espacio de trabajo:";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Espacios
                        // 
                        this.Espacios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Espacios.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Espacios.ItemHeight = 15;
                        this.Espacios.Location = new System.Drawing.Point(16, 40);
                        this.Espacios.Name = "Espacios";
                        this.Espacios.Size = new System.Drawing.Size(444, 150);
                        this.Espacios.Sorted = true;
                        this.Espacios.TabIndex = 1;
                        this.Espacios.SelectedValueChanged += new System.EventHandler(this.Espacios_SelectedValueChanged);
                        // 
                        // WorkspaceSelectorForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 274);
                        this.Controls.Add(this.Espacios);
                        this.Controls.Add(this.label1);
                        this.Name = "WorkspaceSelectorForm";
                        this.Text = "Espacio de trabajo";
                        this.Activated += new System.EventHandler(this.WorkspaceSelectorForm_Activated);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkspaceSelectorForm_KeyDown);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.Espacios, 0);
                        this.ResumeLayout(false);

		}
		#endregion

                private void WorkspaceSelectorForm_Activated(object sender, System.EventArgs e)
		{
			Espacios.Items.Clear();
			System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationDataFolder);
			foreach (System.IO.FileInfo NombreEspacio in Dir.GetFiles("*.lwf"))
			{
				string Nombre = NombreEspacio.Name.Replace(".lwf", "");
				if (Nombre == "default")
					Nombre = "Predeterminado";
				if (Nombre == Nombre.ToLower() || Nombre == Nombre.ToUpper())
					Nombre = Lfx.Types.Strings.ULCase(Nombre);

				Espacios.Items.Add(Nombre);
				if (Nombre == "Predeterminado")
					Espacios.SelectedIndex = Espacios.Items.Count - 1;
			}
			if (Espacios.Items.Count > 0 && Espacios.SelectedIndex < 0)
				Espacios.SelectedIndex = 0;
		}

		private void Espacios_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (Espacios.SelectedItem != null)
			{
				m_WorkspaceName = Espacios.SelectedItem.ToString();
				OkButton.Enabled = true;
			}
			else
			{
				OkButton.Enabled = false;
			}

		}

		public string WorkspaceName
		{
			get
			{
				if (m_WorkspaceName == "Predeterminado")
					return "default";
				else
					return m_WorkspaceName;
			}
		}

                private void WorkspaceSelectorForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control == false && e.Alt == false)
			{
				switch (e.KeyCode)
				{
					case Keys.Return:
						e.Handled = true;
						if (OkButton.Enabled && OkButton.Visible)
							OkButton_Click(sender, e);
						break;
				}
			}
		}
	}
}