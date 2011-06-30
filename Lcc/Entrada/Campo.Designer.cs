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

namespace Lcc.Entrada
{
        partial class Campo
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
                        this.FieldLabel = new System.Windows.Forms.Label();
                        this.FieldData = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // FieldLabel
                        // 
                        this.FieldLabel.AutoSize = true;
                        this.FieldLabel.Location = new System.Drawing.Point(-2, 3);
                        this.FieldLabel.Name = "FieldLabel";
                        this.FieldLabel.Size = new System.Drawing.Size(37, 15);
                        this.FieldLabel.TabIndex = 0;
                        this.FieldLabel.Text = "label";
                        // 
                        // FieldData
                        // 
                        this.FieldData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FieldData.AutoNav = true;
                        this.FieldData.AutoTab = true;
                        this.FieldData.DataType = Lui.Forms.DataTypes.FreeText;
                        this.FieldData.DecimalPlaces = -1;
                        this.FieldData.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FieldData.ForceCase = Lui.Forms.TextCasing.None;
                        this.FieldData.Location = new System.Drawing.Point(60, 0);
                        this.FieldData.MaxLenght = 32767;
                        this.FieldData.MultiLine = false;
                        this.FieldData.Name = "FieldData";
                        this.FieldData.Padding = new System.Windows.Forms.Padding(2);
                        this.FieldData.PasswordChar = '\0';
                        this.FieldData.Prefijo = "";
                        this.FieldData.TemporaryReadOnly = false;
                        this.FieldData.SelectOnFocus = true;
                        this.FieldData.Size = new System.Drawing.Size(366, 24);
                        this.FieldData.Sufijo = "";
                        this.FieldData.TabIndex = 0;
                        this.FieldData.Text = "0";
                        this.FieldData.PlaceholderText = "";
                        this.FieldData.ToolTipText = "";
                        // 
                        // Campo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.FieldData);
                        this.Controls.Add(this.FieldLabel);
                        this.Margin = new System.Windows.Forms.Padding(0);
                        this.Name = "Campo";
                        this.Padding = new System.Windows.Forms.Padding(0);
                        this.Size = new System.Drawing.Size(426, 24);
                        this.Controls.SetChildIndex(this.FieldLabel, 0);
                        this.Controls.SetChildIndex(this.FieldData, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Label FieldLabel;
                private Lui.Forms.TextBox FieldData;
        }
}
