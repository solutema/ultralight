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

namespace Lui.Forms
{
	partial class ProgressForm
	{
		#region Código generado por el Diseñador de Windows Forms

		public ProgressForm()
		{
			InitializeComponent();
		}

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

		private System.ComponentModel.IContainer components = null;

		internal System.Windows.Forms.Label lblOperacionNombre;
                public System.Windows.Forms.ProgressBar ProgressBar;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label lblTexto;
		private System.Windows.Forms.Label lblOperacion;

		private void InitializeComponent()
		{
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
                        this.lblOperacionNombre = new System.Windows.Forms.Label();
                        this.lblTexto = new System.Windows.Forms.Label();
                        this.ProgressBar = new System.Windows.Forms.ProgressBar();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.lblOperacion = new System.Windows.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // lblOperacionNombre
                        // 
                        this.lblOperacionNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblOperacionNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.lblOperacionNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblOperacionNombre.Location = new System.Drawing.Point(88, 20);
                        this.lblOperacionNombre.Name = "lblOperacionNombre";
                        this.lblOperacionNombre.Size = new System.Drawing.Size(372, 60);
                        this.lblOperacionNombre.TabIndex = 0;
                        this.lblOperacionNombre.Text = "Procesando...";
                        this.lblOperacionNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblTexto
                        // 
                        this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblTexto.Location = new System.Drawing.Point(88, 88);
                        this.lblTexto.Name = "lblTexto";
                        this.lblTexto.Size = new System.Drawing.Size(372, 116);
                        this.lblTexto.TabIndex = 2;
                        this.lblTexto.Text = "Por favor aguarde mientras se completan las operaciones.";
                        // 
                        // ProgressBar
                        // 
                        this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ProgressBar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ProgressBar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.ProgressBar.Location = new System.Drawing.Point(84, 260);
                        this.ProgressBar.Name = "ProgressBar";
                        this.ProgressBar.Size = new System.Drawing.Size(376, 20);
                        this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                        this.ProgressBar.TabIndex = 3;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(20, 20);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(56, 60);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.PictureBox1.TabIndex = 5;
                        this.PictureBox1.TabStop = false;
                        // 
                        // lblOperacion
                        // 
                        this.lblOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblOperacion.Location = new System.Drawing.Point(88, 208);
                        this.lblOperacion.Name = "lblOperacion";
                        this.lblOperacion.Size = new System.Drawing.Size(372, 44);
                        this.lblOperacion.TabIndex = 0;
                        // 
                        // ProgressForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 294);
                        this.ControlBox = false;
                        this.Controls.Add(this.ProgressBar);
                        this.Controls.Add(this.lblOperacion);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.lblTexto);
                        this.Controls.Add(this.lblOperacionNombre);
                        this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        this.Name = "ProgressForm";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Progreso";
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

		}


		#endregion
	}
}