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

namespace Lui.Forms
{
        public partial class Control
        {
                private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de componentes

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.ControlCaption = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // ControlCaption
                        // 
                        this.ControlCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ControlCaption.AutoSize = true;
                        this.ControlCaption.Location = new System.Drawing.Point(4, 4);
                        this.ControlCaption.Name = "ControlCaption";
                        this.ControlCaption.Size = new System.Drawing.Size(0, 20);
                        this.ControlCaption.TabIndex = 0;
                        this.ControlCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.ControlCaption.Visible = false;
                        // 
                        // Control
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.Controls.Add(this.ControlCaption);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Name = "Control";
                        this.Padding = new System.Windows.Forms.Padding(2);
                        this.Size = new System.Drawing.Size(460, 84);
                        this.TabStopChanged += new System.EventHandler(this.Control_TabStopChanged);
                        this.Leave += new System.EventHandler(this.Control_Leave);
                        this.Resize += new System.EventHandler(this.Control_Resize);
                        this.Enter += new System.EventHandler(this.Control_Enter);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                internal System.Windows.Forms.Label ControlCaption;
        }
}