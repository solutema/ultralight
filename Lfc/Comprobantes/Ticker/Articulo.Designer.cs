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

namespace Lfc.Comprobantes.Ticker
{
        partial class Articulo
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

                #region Código generado por el Diseñador de componentes

                /// <summary> 
                /// Método necesario para admitir el Diseñador. No se puede modificar 
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.Imagen = new System.Windows.Forms.PictureBox();
                        this.Etiqueta = new System.Windows.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Imagen
                        // 
                        this.Imagen.Location = new System.Drawing.Point(0, 0);
                        this.Imagen.Name = "Imagen";
                        this.Imagen.Size = new System.Drawing.Size(136, 116);
                        this.Imagen.TabIndex = 0;
                        this.Imagen.TabStop = false;
                        // 
                        // Etiqueta
                        // 
                        this.Etiqueta.AutoEllipsis = true;
                        this.Etiqueta.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.Etiqueta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Etiqueta.Location = new System.Drawing.Point(0, 153);
                        this.Etiqueta.Name = "Etiqueta";
                        this.Etiqueta.Size = new System.Drawing.Size(210, 40);
                        this.Etiqueta.TabIndex = 1;
                        this.Etiqueta.Text = "Artículo";
                        this.Etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.Etiqueta.UseMnemonic = false;
                        // 
                        // Articulo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.White;
                        this.Controls.Add(this.Etiqueta);
                        this.Controls.Add(this.Imagen);
                        this.Name = "Articulo";
                        this.Size = new System.Drawing.Size(210, 193);
                        ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.PictureBox Imagen;
                private System.Windows.Forms.Label Etiqueta;
        }
}
