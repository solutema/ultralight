#region License
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
#endregion

namespace Lcc.WinForms
{
        partial class ActionForm
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionForm));
                        this.ActionPanel = new Lcc.WinForms.ActionPanel();
                        this.Body = new System.Windows.Forms.Panel();
                        this.FormHeader = new Lcc.WinForms.FormHeader();
                        this.SuspendLayout();
                        // 
                        // ActionPanel
                        // 
                        this.ActionPanel.BackColor = System.Drawing.Color.SlateGray;
                        this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.ActionPanel.Location = new System.Drawing.Point(0, 320);
                        this.ActionPanel.Name = "ActionPanel";
                        this.ActionPanel.Size = new System.Drawing.Size(640, 80);
                        this.ActionPanel.TabIndex = 5;
                        // 
                        // Body
                        // 
                        this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Body.Location = new System.Drawing.Point(0, 52);
                        this.Body.Name = "Body";
                        this.Body.Size = new System.Drawing.Size(640, 264);
                        this.Body.TabIndex = 7;
                        // 
                        // FormHeader
                        // 
                        this.FormHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FormHeader.BackgroundImage")));
                        this.FormHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
                        this.FormHeader.Location = new System.Drawing.Point(0, 0);
                        this.FormHeader.Name = "FormHeader";
                        this.FormHeader.Size = new System.Drawing.Size(640, 48);
                        this.FormHeader.TabIndex = 8;
                        // 
                        // ActionForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.FormHeader);
                        this.Controls.Add(this.Body);
                        this.Controls.Add(this.ActionPanel);
                        this.Name = "ActionForm";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.ResumeLayout(false);

                }

                #endregion

                protected internal ActionPanel ActionPanel;
                protected internal System.Windows.Forms.Panel Body;
                protected internal FormHeader FormHeader;
        }
}
