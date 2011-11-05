#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
        partial class YesNo
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
                        this.EtiquetaSi = new System.Windows.Forms.Label();
                        this.EtiquetaNo = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EtiquetaSi
                        // 
                        this.EtiquetaSi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaSi.AutoEllipsis = true;
                        this.EtiquetaSi.BackColor = System.Drawing.SystemColors.Highlight;
                        this.EtiquetaSi.ForeColor = System.Drawing.SystemColors.HighlightText;
                        this.EtiquetaSi.Location = new System.Drawing.Point(2, 2);
                        this.EtiquetaSi.Name = "EtiquetaSi";
                        this.EtiquetaSi.Size = new System.Drawing.Size(19, 20);
                        this.EtiquetaSi.TabIndex = 0;
                        this.EtiquetaSi.Text = "Sí";
                        this.EtiquetaSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaSi.Click += new System.EventHandler(this.EtiquetaSi_Click);
                        // 
                        // EtiquetaNo
                        // 
                        this.EtiquetaNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaNo.AutoEllipsis = true;
                        this.EtiquetaNo.Location = new System.Drawing.Point(24, 2);
                        this.EtiquetaNo.Name = "EtiquetaNo";
                        this.EtiquetaNo.Size = new System.Drawing.Size(25, 20);
                        this.EtiquetaNo.TabIndex = 1;
                        this.EtiquetaNo.Text = "No";
                        this.EtiquetaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaNo.Click += new System.EventHandler(this.EtiquetaNo_Click);
                        // 
                        // YesNo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.EtiquetaNo);
                        this.Controls.Add(this.EtiquetaSi);
                        this.Name = "YesNo";
                        this.Size = new System.Drawing.Size(55, 24);
                        this.Controls.SetChildIndex(this.EtiquetaSi, 0);
                        this.Controls.SetChildIndex(this.EtiquetaNo, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Label EtiquetaSi;
                private System.Windows.Forms.Label EtiquetaNo;
        }
}
