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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Lcc.Entrada
{
        public partial class MatrizControlesEntrada<T>
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

                private void InitializeComponent()
                {
                        this.PanelGrilla = new System.Windows.Forms.Panel();
                        this.SuspendLayout();
                        // 
                        // PanelGrilla
                        // 
                        this.PanelGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelGrilla.AutoScroll = true;
                        this.PanelGrilla.AutoScrollMargin = new System.Drawing.Size(20, 0);
                        this.PanelGrilla.Location = new System.Drawing.Point(0, 0);
                        this.PanelGrilla.Name = "PanelGrilla";
                        this.PanelGrilla.Size = new System.Drawing.Size(536, 180);
                        this.PanelGrilla.TabIndex = 999;
                        // 
                        // MatrizControlesEntrada
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.Controls.Add(this.PanelGrilla);
                        this.Name = "MatrizControlesEntrada";
                        this.Size = new System.Drawing.Size(536, 180);
                        this.Controls.SetChildIndex(this.PanelGrilla, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                internal System.Windows.Forms.Panel PanelGrilla;
        }
}
