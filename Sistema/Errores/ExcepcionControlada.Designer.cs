#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lazaro.Errores
{
        partial class ExcepcionControlada
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcepcionControlada));
                        this.BotonCerrar = new System.Windows.Forms.Button();
                        this.EtiquetaDescripcion = new Lui.Forms.Label();
                        this.EtiquetaTitulo = new Lui.Forms.Label();
                        this.EtiquetaMasInformacion = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.BotonAmpliar = new System.Windows.Forms.Button();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // BotonCerrar
                        // 
                        this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCerrar.Location = new System.Drawing.Point(372, 140);
                        this.BotonCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.BotonCerrar.Name = "BotonCerrar";
                        this.BotonCerrar.Size = new System.Drawing.Size(81, 28);
                        this.BotonCerrar.TabIndex = 7;
                        this.BotonCerrar.Text = "Continuar";
                        this.BotonCerrar.UseVisualStyleBackColor = true;
                        this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
                        // 
                        // EtiquetaDescripcion
                        // 
                        this.EtiquetaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
                        this.EtiquetaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.EtiquetaDescripcion.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaDescripcion.Location = new System.Drawing.Point(72, 55);
                        this.EtiquetaDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                        this.EtiquetaDescripcion.Name = "EtiquetaDescripcion";
                        this.EtiquetaDescripcion.Padding = new System.Windows.Forms.Padding(3);
                        this.EtiquetaDescripcion.Size = new System.Drawing.Size(382, 38);
                        this.EtiquetaDescripcion.TabIndex = 6;
                        this.EtiquetaDescripcion.Text = "Lázaro encontró un problema.";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
                        this.EtiquetaTitulo.LabelStyle = Lui.Forms.LabelStyles.Header2;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(72, 21);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(381, 28);
                        this.EtiquetaTitulo.TabIndex = 5;
                        this.EtiquetaTitulo.Text = "Informe de Error";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaMasInformacion
                        // 
                        this.EtiquetaMasInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaMasInformacion.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaMasInformacion.Location = new System.Drawing.Point(72, 101);
                        this.EtiquetaMasInformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                        this.EtiquetaMasInformacion.Name = "EtiquetaMasInformacion";
                        this.EtiquetaMasInformacion.Size = new System.Drawing.Size(381, 111);
                        this.EtiquetaMasInformacion.TabIndex = 9;
                        this.EtiquetaMasInformacion.Text = ".";
                        this.EtiquetaMasInformacion.Visible = false;
                        this.EtiquetaMasInformacion.TextChanged += new System.EventHandler(this.EtiquetaMasInformacion_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label1.Location = new System.Drawing.Point(72, 99);
                        this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(381, 35);
                        this.label1.TabIndex = 10;
                        this.label1.Text = "La operación ha sido cancelada. Si no puede solucionar el problema, póngase en co" +
                            "ntacto con el administrador.";
                        // 
                        // BotonAmpliar
                        // 
                        this.BotonAmpliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAmpliar.Location = new System.Drawing.Point(72, 140);
                        this.BotonAmpliar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.BotonAmpliar.Name = "BotonAmpliar";
                        this.BotonAmpliar.Size = new System.Drawing.Size(99, 28);
                        this.BotonAmpliar.TabIndex = 11;
                        this.BotonAmpliar.Text = "Más información";
                        this.BotonAmpliar.UseVisualStyleBackColor = true;
                        this.BotonAmpliar.Visible = false;
                        this.BotonAmpliar.Click += new System.EventHandler(this.BotonAmpliar_Click);
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                        this.pictureBox1.Location = new System.Drawing.Point(27, 28);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(37, 40);
                        this.pictureBox1.TabIndex = 12;
                        this.pictureBox1.TabStop = false;
                        // 
                        // ExcepcionControlada
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(476, 192);
                        this.ControlBox = false;
                        this.Controls.Add(this.pictureBox1);
                        this.Controls.Add(this.BotonAmpliar);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.BotonCerrar);
                        this.Controls.Add(this.EtiquetaDescripcion);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.EtiquetaMasInformacion);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.MaximizeBox = false;
                        this.MinimizeBox = false;
                        this.Name = "ExcepcionControlada";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Error";
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                public System.Windows.Forms.Button BotonCerrar;
                public Lui.Forms.Label EtiquetaDescripcion;
                private Lui.Forms.Label EtiquetaTitulo;
                public Lui.Forms.Label EtiquetaMasInformacion;
                public Lui.Forms.Label label1;
                public System.Windows.Forms.Button BotonAmpliar;
                private System.Windows.Forms.PictureBox pictureBox1;
        }
}
