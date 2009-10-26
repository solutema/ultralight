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

namespace Lfc
{
        partial class Etiquetas
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
                        this.EntradaEtiquetas = new Lcc.Controles.Datos.Etiquetas();
                        this.EtiquetaTitulo = new System.Windows.Forms.Label();
                        this.EntradaComentarios = new Lcc.Controles.Datos.Comentarios();
                        this.label1 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(384, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(504, 8);
                        // 
                        // EntradaEtiquetas
                        // 
                        this.EntradaEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEtiquetas.AutoHeight = true;
                        this.EntradaEtiquetas.AutoNav = true;
                        this.EntradaEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEtiquetas.Location = new System.Drawing.Point(464, 36);
                        this.EntradaEtiquetas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.EntradaEtiquetas.Name = "EntradaEtiquetas";
                        this.EntradaEtiquetas.ReadOnly = false;
                        this.EntradaEtiquetas.Size = new System.Drawing.Size(152, 260);
                        this.EntradaEtiquetas.TabIndex = 3;
                        this.EntradaEtiquetas.Text = "etiquetas1";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(464, 12);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(152, 20);
                        this.EtiquetaTitulo.TabIndex = 2;
                        this.EtiquetaTitulo.Text = "Etiquetas";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaComentarios
                        // 
                        this.EntradaComentarios.AutoHeight = true;
                        this.EntradaComentarios.AutoNav = true;
                        this.EntradaComentarios.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaComentarios.Location = new System.Drawing.Point(8, 36);
                        this.EntradaComentarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaComentarios.Name = "EntradaComentarios";
                        this.EntradaComentarios.ReadOnly = false;
                        this.EntradaComentarios.Size = new System.Drawing.Size(444, 260);
                        this.EntradaComentarios.TabIndex = 1;
                        this.EntradaComentarios.Text = "comentarios1";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(8, 12);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(444, 20);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Comentarios";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Etiquetas
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(624, 364);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaComentarios);
                        this.Controls.Add(this.EntradaEtiquetas);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Name = "Etiquetas";
                        this.Text = "Etiquetas";
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.Controls.SetChildIndex(this.EntradaEtiquetas, 0);
                        this.Controls.SetChildIndex(this.EntradaComentarios, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lcc.Controles.Datos.Etiquetas EntradaEtiquetas;
                private System.Windows.Forms.Label EtiquetaTitulo;
                protected internal Lcc.Controles.Datos.Comentarios EntradaComentarios;
                private System.Windows.Forms.Label label1;
        }
}