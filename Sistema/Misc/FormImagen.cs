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
namespace Lazaro
{
	public class FormImagen : Lui.Forms.Form
	{

		#region Código generado por el Diseñador de Windows Forms

		public FormImagen()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent

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
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.PictureBox Imagen;

		private void InitializeComponent()
		{
			this.Imagen = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// Imagen
			// 
			this.Imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.Imagen.Location = new System.Drawing.Point(4, 4);
			this.Imagen.Name = "Imagen";
			this.Imagen.Size = new System.Drawing.Size(464, 376);
			this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Imagen.TabIndex = 0;
			this.Imagen.TabStop = false;
			// 
			// FormImagen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(472, 385);
			this.Controls.Add(this.Imagen);
			this.KeyPreview = true;
			this.Name = "FormImagen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Imagen";
			this.ResumeLayout(false);

			base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(FormImagen_KeyPress);
		}


		#endregion

		private void FormImagen_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0] == System.Convert.ToByte(Keys.Escape)) {
				e.Handled = true;
				this.Close();
			}
		}

	}
}
