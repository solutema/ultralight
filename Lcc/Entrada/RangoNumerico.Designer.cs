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

namespace Lcc.Entrada
{
        partial class RangoNumerico
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
                        this.EntradaValor1 = new Lui.Forms.TextBox();
                        this.EntradaValor2 = new Lui.Forms.TextBox();
                        this.label8 = new Lui.Forms.Label();
                        this.label7 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaValor1
                        // 
                        this.EntradaValor1.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaValor1.DecimalPlaces = 2;
                        this.EntradaValor1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaValor1.Location = new System.Drawing.Point(56, 0);
                        this.EntradaValor1.Name = "EntradaValor1";
                        this.EntradaValor1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaValor1.ReadOnly = false;
                        this.EntradaValor1.Size = new System.Drawing.Size(108, 24);
                        this.EntradaValor1.TabIndex = 5;
                        this.EntradaValor1.Text = "0.00";
                        // 
                        // EntradaValor2
                        // 
                        this.EntradaValor2.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaValor2.DecimalPlaces = 2;
                        this.EntradaValor2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaValor2.Location = new System.Drawing.Point(196, 0);
                        this.EntradaValor2.Name = "EntradaValor2";
                        this.EntradaValor2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaValor2.ReadOnly = false;
                        this.EntradaValor2.Size = new System.Drawing.Size(108, 24);
                        this.EntradaValor2.TabIndex = 7;
                        this.EntradaValor2.Text = "0.00";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 0);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(56, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "entre";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(164, 0);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(32, 24);
                        this.label7.TabIndex = 6;
                        this.label7.Text = "y";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // RangoNumerico
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.EntradaValor1);
                        this.Controls.Add(this.EntradaValor2);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label7);
                        this.Name = "RangoNumerico";
                        this.Size = new System.Drawing.Size(304, 24);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaValor2, 0);
                        this.Controls.SetChildIndex(this.EntradaValor1, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaValor1;
                internal Lui.Forms.TextBox EntradaValor2;
                internal Lui.Forms.Label label8;
                internal Lui.Forms.Label label7;
        }
}
