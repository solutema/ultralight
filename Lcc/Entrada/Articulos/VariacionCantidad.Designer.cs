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

namespace Lcc.Entrada.Articulos
{
        partial class VariacionCantidad
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
                        this.EntradaVariacion = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCantidad.AutoNav = true;
                        this.EntradaCantidad.AutoTab = true;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaCantidad.DecimalPlaces = -1;
                        this.EntradaCantidad.FieldName = null;
                        this.EntradaCantidad.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCantidad.Location = new System.Drawing.Point(368, 0);
                        this.EntradaCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaCantidad.MaxLength = 32767;
                        this.EntradaCantidad.MultiLine = false;
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.EntradaCantidad.PasswordChar = '\0';
                        this.EntradaCantidad.PlaceholderText = null;
                        this.EntradaCantidad.Prefijo = "";
                        this.EntradaCantidad.ReadOnly = false;
                        this.EntradaCantidad.SelectOnFocus = true;
                        this.EntradaCantidad.Size = new System.Drawing.Size(112, 24);
                        this.EntradaCantidad.Sufijo = "";
                        this.EntradaCantidad.TabIndex = 54;
                        this.EntradaCantidad.Text = "1.0000";
                        this.EntradaCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaCantidad_KeyDown);
                        this.EntradaCantidad.TextChanged += new System.EventHandler(this.EntradaVariacionCantidad_TextChanged);
                        // 
                        // EntradaVariacion
                        // 
                        this.EntradaVariacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaVariacion.AutoNav = true;
                        this.EntradaVariacion.AutoTab = true;
                        this.EntradaVariacion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaVariacion.DecimalPlaces = -1;
                        this.EntradaVariacion.FieldName = null;
                        this.EntradaVariacion.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaVariacion.Location = new System.Drawing.Point(0, 0);
                        this.EntradaVariacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaVariacion.MaxLength = 32767;
                        this.EntradaVariacion.MultiLine = false;
                        this.EntradaVariacion.Name = "EntradaVariacion";
                        this.EntradaVariacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.EntradaVariacion.PasswordChar = '\0';
                        this.EntradaVariacion.PlaceholderText = null;
                        this.EntradaVariacion.Prefijo = "";
                        this.EntradaVariacion.ReadOnly = false;
                        this.EntradaVariacion.SelectOnFocus = false;
                        this.EntradaVariacion.Size = new System.Drawing.Size(364, 24);
                        this.EntradaVariacion.Sufijo = "";
                        this.EntradaVariacion.TabIndex = 53;
                        this.EntradaVariacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaVariacion_KeyDown);
                        this.EntradaVariacion.TextChanged += new System.EventHandler(this.EntradaVariacionCantidad_TextChanged);
                        // 
                        // VariacionCantidad
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.EntradaVariacion);
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.Name = "VariacionCantidad";
                        this.Size = new System.Drawing.Size(480, 24);
                        this.Controls.SetChildIndex(this.EntradaVariacion, 0);
                        this.Controls.SetChildIndex(this.EntradaCantidad, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.TextBox EntradaCantidad;
                private Lui.Forms.TextBox EntradaVariacion;
        }
}
