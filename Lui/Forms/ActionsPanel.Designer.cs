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
        partial class ActionsPanel
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
                        this.PanelPrimario = new System.Windows.Forms.FlowLayoutPanel();
                        this.PanelSecundario = new System.Windows.Forms.FlowLayoutPanel();
                        this.SuspendLayout();
                        // 
                        // PanelPrimario
                        // 
                        this.PanelPrimario.Dock = System.Windows.Forms.DockStyle.Right;
                        this.PanelPrimario.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                        this.PanelPrimario.Location = new System.Drawing.Point(240, 0);
                        this.PanelPrimario.Name = "PanelPrimario";
                        this.PanelPrimario.Size = new System.Drawing.Size(362, 130);
                        this.PanelPrimario.TabIndex = 0;
                        this.PanelPrimario.WrapContents = false;
                        // 
                        // PanelSecundario
                        // 
                        this.PanelSecundario.Dock = System.Windows.Forms.DockStyle.Left;
                        this.PanelSecundario.Location = new System.Drawing.Point(0, 0);
                        this.PanelSecundario.Name = "PanelSecundario";
                        this.PanelSecundario.Size = new System.Drawing.Size(232, 130);
                        this.PanelSecundario.TabIndex = 1;
                        this.PanelSecundario.WrapContents = false;
                        // 
                        // ActionsPanel
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.PanelPrimario);
                        this.Controls.Add(this.PanelSecundario);
                        this.Name = "ActionsPanel";
                        this.Size = new System.Drawing.Size(602, 130);
                        this.ResumeLayout(false);
                }

                #endregion

                private System.Windows.Forms.FlowLayoutPanel PanelPrimario;
                private System.Windows.Forms.FlowLayoutPanel PanelSecundario;
        }
}
