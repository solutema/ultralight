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

namespace Lcc.Edicion
{
        partial class MatrizCampos : ControlEdicion
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
                        this.FieldContainer = new System.Windows.Forms.FlowLayoutPanel();
                        this.GroupLabel = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // FieldContainer
                        // 
                        this.FieldContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FieldContainer.AutoScroll = true;
                        this.FieldContainer.Location = new System.Drawing.Point(0, 20);
                        this.FieldContainer.Margin = new System.Windows.Forms.Padding(4);
                        this.FieldContainer.Name = "FieldContainer";
                        this.FieldContainer.Size = new System.Drawing.Size(460, 64);
                        this.FieldContainer.TabIndex = 0;
                        this.FieldContainer.ClientSizeChanged += new System.EventHandler(this.FieldContainer_ClientSizeChanged);
                        this.FieldContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FieldContainer_ControlAdded);
                        // 
                        // GroupLabel
                        // 
                        this.GroupLabel.AutoSize = true;
                        this.GroupLabel.Location = new System.Drawing.Point(0, 0);
                        this.GroupLabel.Name = "GroupLabel";
                        this.GroupLabel.Size = new System.Drawing.Size(70, 15);
                        this.GroupLabel.TabIndex = 1;
                        this.GroupLabel.Text = "fieldgroup";
                        this.GroupLabel.UseMnemonic = false;
                        // 
                        // MatrizCampos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.GroupLabel);
                        this.Controls.Add(this.FieldContainer);
                        this.Name = "MatrizCampos";
                        this.Controls.SetChildIndex(this.FieldContainer, 0);
                        this.Controls.SetChildIndex(this.GroupLabel, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                public System.Windows.Forms.FlowLayoutPanel FieldContainer;
                private System.Windows.Forms.Label GroupLabel;
        }
}
