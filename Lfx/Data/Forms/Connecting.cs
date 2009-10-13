// Copyright 2004-2009 South Bridge S.R.L.
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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lfx.Data.Forms
{
	/// <summary>
	/// Descripción breve de Connecting.
	/// </summary>
	public class Connecting: System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Connecting()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connecting));
                        this.label1 = new System.Windows.Forms.Label();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.Location = new System.Drawing.Point(72, 16);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(306, 64);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Estableciendo conexión con el servidor SQL. Por favor aguarde.";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                        this.pictureBox1.Location = new System.Drawing.Point(16, 16);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(47, 64);
                        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.pictureBox1.TabIndex = 1;
                        this.pictureBox1.TabStop = false;
                        // 
                        // Connecting
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(394, 98);
                        this.ControlBox = false;
                        this.Controls.Add(this.pictureBox1);
                        this.Controls.Add(this.label1);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        this.Name = "Connecting";
                        this.Opacity = 0.9;
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Estado de la conexión";
                        this.TopMost = true;
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

		}
		#endregion

		public string StatusText
		{
			get
			{
				return label1.Text;
			}
			set
			{
				label1.Text = value;
			}
		}
	}
}
