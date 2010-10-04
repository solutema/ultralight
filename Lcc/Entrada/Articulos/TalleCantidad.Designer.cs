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

namespace Lcc.Edicion.Articulos
{
        partial class TalleCantidad
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
                        this.EntradaCantidad = new Lui.Forms.TextBox();
                        this.EntradaTalle = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaColor
                        // 
                        this.EntradaCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCantidad.AutoHeight = false;
                        this.EntradaCantidad.AutoNav = true;
                        this.EntradaCantidad.AutoTab = true;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaCantidad.DecimalPlaces = -1;
                        this.EntradaCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCantidad.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCantidad.Location = new System.Drawing.Point(368, 0);
                        this.EntradaCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaCantidad.MaxLenght = 32767;
                        this.EntradaCantidad.MultiLine = false;
                        this.EntradaCantidad.Name = "EntradaColor";
                        this.EntradaCantidad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.EntradaCantidad.PasswordChar = '\0';
                        this.EntradaCantidad.Prefijo = "";
                        this.EntradaCantidad.ReadOnly = false;
                        this.EntradaCantidad.SelectOnFocus = true;
                        this.EntradaCantidad.Size = new System.Drawing.Size(112, 24);
                        this.EntradaCantidad.Sufijo = "";
                        this.EntradaCantidad.TabIndex = 54;
                        this.EntradaCantidad.Text = "0.0000";
                        this.EntradaCantidad.TextRaw = "0.0000";
                        this.EntradaCantidad.TipWhenBlank = "";
                        this.EntradaCantidad.ToolTipText = "";
                        // 
                        // EntradaTalle
                        // 
                        this.EntradaTalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTalle.AutoHeight = false;
                        this.EntradaTalle.AutoNav = true;
                        this.EntradaTalle.AutoTab = true;
                        this.EntradaTalle.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTalle.DecimalPlaces = -1;
                        this.EntradaTalle.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTalle.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTalle.Location = new System.Drawing.Point(0, 0);
                        this.EntradaTalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaTalle.MaxLenght = 32767;
                        this.EntradaTalle.MultiLine = false;
                        this.EntradaTalle.Name = "EntradaTalle";
                        this.EntradaTalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.EntradaTalle.PasswordChar = '\0';
                        this.EntradaTalle.Prefijo = "";
                        this.EntradaTalle.ReadOnly = false;
                        this.EntradaTalle.SelectOnFocus = true;
                        this.EntradaTalle.Size = new System.Drawing.Size(364, 24);
                        this.EntradaTalle.Sufijo = "";
                        this.EntradaTalle.TabIndex = 53;
                        this.EntradaTalle.TextRaw = "";
                        this.EntradaTalle.TipWhenBlank = "";
                        this.EntradaTalle.ToolTipText = "";
                        // 
                        // TalleColor
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.EntradaTalle);
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.Name = "TalleColor";
                        this.Size = new System.Drawing.Size(480, 24);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.TextBox EntradaCantidad;
                private Lui.Forms.TextBox EntradaTalle;
        }
}
