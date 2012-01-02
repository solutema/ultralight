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

namespace Lui.Forms
{
	partial class ProgressForm
	{
		#region Código generado por el Diseñador de Windows Forms

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

                private Lui.Forms.Label EtiquetaNombreOperacion;
                private System.Windows.Forms.ProgressBar ProgressBar;
                private System.Windows.Forms.PictureBox PictureBox1;
                private Lui.Forms.Label EtiquetaDescripcion;
		private Lui.Forms.Label EtiquetaEstado;

		private void InitializeComponent()
		{
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
                        this.EtiquetaNombreOperacion = new Lui.Forms.Label();
                        this.EtiquetaDescripcion = new Lui.Forms.Label();
                        this.ProgressBar = new System.Windows.Forms.ProgressBar();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.EtiquetaEstado = new Lui.Forms.Label();
                        this.BotonCancelar = new Lui.Forms.LinkLabel();
                        this.EtiquetaOtrasOperaciones = new Lui.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // EtiquetaNombreOperacion
                        // 
                        this.EtiquetaNombreOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaNombreOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.EtiquetaNombreOperacion.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.EtiquetaNombreOperacion.Location = new System.Drawing.Point(88, 24);
                        this.EtiquetaNombreOperacion.Name = "EtiquetaNombreOperacion";
                        this.EtiquetaNombreOperacion.Size = new System.Drawing.Size(364, 44);
                        this.EtiquetaNombreOperacion.TabIndex = 0;
                        this.EtiquetaNombreOperacion.Text = "Procesando...";
                        this.EtiquetaNombreOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaDescripcion
                        // 
                        this.EtiquetaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaDescripcion.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaDescripcion.Location = new System.Drawing.Point(88, 108);
                        this.EtiquetaDescripcion.Name = "EtiquetaDescripcion";
                        this.EtiquetaDescripcion.Size = new System.Drawing.Size(364, 78);
                        this.EtiquetaDescripcion.TabIndex = 2;
                        this.EtiquetaDescripcion.Text = "Por favor aguarde mientras se completan las operaciones.";
                        // 
                        // ProgressBar
                        // 
                        this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ProgressBar.Location = new System.Drawing.Point(84, 246);
                        this.ProgressBar.Name = "ProgressBar";
                        this.ProgressBar.Size = new System.Drawing.Size(368, 20);
                        this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                        this.ProgressBar.TabIndex = 3;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(20, 24);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(56, 60);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.PictureBox1.TabIndex = 5;
                        this.PictureBox1.TabStop = false;
                        // 
                        // EtiquetaEstado
                        // 
                        this.EtiquetaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaEstado.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaEstado.Location = new System.Drawing.Point(88, 196);
                        this.EtiquetaEstado.Name = "EtiquetaEstado";
                        this.EtiquetaEstado.Size = new System.Drawing.Size(364, 44);
                        this.EtiquetaEstado.TabIndex = 0;
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCancelar.Location = new System.Drawing.Point(356, 164);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Size = new System.Drawing.Size(96, 20);
                        this.BotonCancelar.TabIndex = 0;
                        this.BotonCancelar.TabStop = true;
                        this.BotonCancelar.Text = "Cancelar";
                        this.BotonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        this.BotonCancelar.Visible = false;
                        this.BotonCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonCancelar_LinkClicked);
                        // 
                        // EtiquetaOtrasOperaciones
                        // 
                        this.EtiquetaOtrasOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaOtrasOperaciones.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaOtrasOperaciones.Location = new System.Drawing.Point(88, 72);
                        this.EtiquetaOtrasOperaciones.Name = "EtiquetaOtrasOperaciones";
                        this.EtiquetaOtrasOperaciones.Size = new System.Drawing.Size(364, 32);
                        this.EtiquetaOtrasOperaciones.TabIndex = 6;
                        // 
                        // ProgressForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 292);
                        this.ControlBox = false;
                        this.Controls.Add(this.EtiquetaOtrasOperaciones);
                        this.Controls.Add(this.BotonCancelar);
                        this.Controls.Add(this.ProgressBar);
                        this.Controls.Add(this.EtiquetaEstado);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.EtiquetaDescripcion);
                        this.Controls.Add(this.EtiquetaNombreOperacion);
                        this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "ProgressForm";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Progreso";
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

		}


		#endregion

                private LinkLabel BotonCancelar;
                private Label EtiquetaOtrasOperaciones;
	}
}
