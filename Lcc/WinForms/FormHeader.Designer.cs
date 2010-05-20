// Copyright 2004-2010 South Bridge S.R.L.
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

namespace Lcc.WinForms
{
        partial class FormHeader
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
                        this.LabelHeader = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // LabelHeader
                        // 
                        this.LabelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelHeader.AutoEllipsis = true;
                        this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
                        this.LabelHeader.ForeColor = System.Drawing.Color.White;
                        this.LabelHeader.Location = new System.Drawing.Point(2, 0);
                        this.LabelHeader.Name = "LabelHeader";
                        this.LabelHeader.Size = new System.Drawing.Size(522, 32);
                        this.LabelHeader.TabIndex = 1;
                        this.LabelHeader.Text = "Título de la ventana";
                        this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.LabelHeader.UseMnemonic = false;
                        // 
                        // FormHeader
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackgroundImage = global::Lcc.Properties.Resources.Header;
                        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.Controls.Add(this.LabelHeader);
                        this.Name = "FormHeader";
                        this.Size = new System.Drawing.Size(577, 35);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label LabelHeader;
        }
}
