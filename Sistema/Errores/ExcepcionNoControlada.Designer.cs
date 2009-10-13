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

namespace Lazaro.Errores
{
        partial class ExcepcionNoControlada
        {
                /// <summary>
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcepcionNoControlada));
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        this.EtiquetaTitulo = new System.Windows.Forms.Label();
                        this.EtiquetaDescripcion = new System.Windows.Forms.Label();
                        this.BotonCerrar = new System.Windows.Forms.Button();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                        this.pictureBox1.Location = new System.Drawing.Point(36, 32);
                        this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(33, 33);
                        this.pictureBox1.TabIndex = 0;
                        this.pictureBox1.TabStop = false;
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
                        this.EtiquetaTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(96, 24);
                        this.EtiquetaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(508, 32);
                        this.EtiquetaTitulo.TabIndex = 1;
                        this.EtiquetaTitulo.Text = "Reporte de Error";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaDescripcion
                        // 
                        this.EtiquetaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaDescripcion.Location = new System.Drawing.Point(96, 64);
                        this.EtiquetaDescripcion.Name = "EtiquetaDescripcion";
                        this.EtiquetaDescripcion.Size = new System.Drawing.Size(508, 84);
                        this.EtiquetaDescripcion.TabIndex = 2;
                        this.EtiquetaDescripcion.Text = "Lázaro encontró un problema y está generando un reporte. Por favor aguarde un mom" +
                            "ento.";
                        // 
                        // BotonCerrar
                        // 
                        this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCerrar.Enabled = false;
                        this.BotonCerrar.Location = new System.Drawing.Point(496, 114);
                        this.BotonCerrar.Name = "BotonCerrar";
                        this.BotonCerrar.Size = new System.Drawing.Size(108, 32);
                        this.BotonCerrar.TabIndex = 3;
                        this.BotonCerrar.Text = "Continuar";
                        this.BotonCerrar.UseVisualStyleBackColor = true;
                        this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
                        // 
                        // ExcepcionNoControlada
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 172);
                        this.ControlBox = false;
                        this.Controls.Add(this.BotonCerrar);
                        this.Controls.Add(this.EtiquetaDescripcion);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.pictureBox1);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.MaximizeBox = false;
                        this.MinimizeBox = false;
                        this.Name = "ExcepcionNoControlada";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Error";
                        this.TopMost = true;
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.PictureBox pictureBox1;
                private System.Windows.Forms.Label EtiquetaTitulo;
                public System.Windows.Forms.Label EtiquetaDescripcion;
                public System.Windows.Forms.Button BotonCerrar;
        }
}