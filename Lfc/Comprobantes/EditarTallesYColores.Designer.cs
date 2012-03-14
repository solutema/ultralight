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

namespace Lfc.Comprobantes
{
        partial class EditarTallesYColores
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

                #region Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.textBox1 = new Lui.Forms.TextBox();
                        this.textBox2 = new Lui.Forms.TextBox();
                        this.textBox3 = new Lui.Forms.TextBox();
                        this.textBox4 = new Lui.Forms.TextBox();
                        this.textBox5 = new Lui.Forms.TextBox();
                        this.textBox6 = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // textBox1
                        // 
                        this.textBox1.Location = new System.Drawing.Point(24, 24);
                        this.textBox1.Name = "textBox1";
                        this.textBox1.Size = new System.Drawing.Size(316, 24);
                        this.textBox1.TabIndex = 51;
                        // 
                        // textBox2
                        // 
                        this.textBox2.Location = new System.Drawing.Point(348, 24);
                        this.textBox2.Name = "textBox2";
                        this.textBox2.Size = new System.Drawing.Size(108, 24);
                        this.textBox2.TabIndex = 52;
                        // 
                        // textBox3
                        // 
                        this.textBox3.Location = new System.Drawing.Point(348, 56);
                        this.textBox3.Name = "textBox3";
                        this.textBox3.Size = new System.Drawing.Size(108, 24);
                        this.textBox3.TabIndex = 54;
                        // 
                        // textBox4
                        // 
                        this.textBox4.Location = new System.Drawing.Point(24, 56);
                        this.textBox4.Name = "textBox4";
                        this.textBox4.Size = new System.Drawing.Size(316, 24);
                        this.textBox4.TabIndex = 53;
                        // 
                        // textBox5
                        // 
                        this.textBox5.Location = new System.Drawing.Point(348, 88);
                        this.textBox5.Name = "textBox5";
                        this.textBox5.Size = new System.Drawing.Size(108, 24);
                        this.textBox5.TabIndex = 56;
                        // 
                        // textBox6
                        // 
                        this.textBox6.Location = new System.Drawing.Point(24, 88);
                        this.textBox6.Name = "textBox6";
                        this.textBox6.Size = new System.Drawing.Size(316, 24);
                        this.textBox6.TabIndex = 55;
                        // 
                        // EditarTallesYColores
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(474, 294);
                        this.Controls.Add(this.textBox5);
                        this.Controls.Add(this.textBox6);
                        this.Controls.Add(this.textBox3);
                        this.Controls.Add(this.textBox4);
                        this.Controls.Add(this.textBox2);
                        this.Controls.Add(this.textBox1);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "EditarTallesYColores";
                        this.Text = "Talles y colores";
                        this.Controls.SetChildIndex(this.textBox1, 0);
                        this.Controls.SetChildIndex(this.textBox2, 0);
                        this.Controls.SetChildIndex(this.textBox4, 0);
                        this.Controls.SetChildIndex(this.textBox3, 0);
                        this.Controls.SetChildIndex(this.textBox6, 0);
                        this.Controls.SetChildIndex(this.textBox5, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.TextBox textBox1;
                private Lui.Forms.TextBox textBox2;
                private Lui.Forms.TextBox textBox3;
                private Lui.Forms.TextBox textBox4;
                private Lui.Forms.TextBox textBox5;
                private Lui.Forms.TextBox textBox6;

        }
}
