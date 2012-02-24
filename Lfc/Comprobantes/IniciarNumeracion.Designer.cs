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
        partial class IniciarNumeracion
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
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaPv = new Lui.Forms.TextBox();
                        this.EntradaDesde = new Lui.Forms.TextBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.LabelAyuda = new Lui.Forms.Label();
                        this.formHeader1 = new Lui.Forms.FormHeader();
                        this.SuspendLayout();
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(316, 88);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(132, 24);
                        this.label4.TabIndex = 2;
                        this.label4.Text = "Punto de Venta";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = true;
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.Location = new System.Drawing.Point(152, 88);
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.SetData = new string[] {
        "Facturas A|A",
        "Facturas B|B",
        "Facturas C|C",
        "Facturas E|E",
        "Facturas M|M",
        "Remitos|R"};
                        this.EntradaTipo.Size = new System.Drawing.Size(144, 91);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.TextKey = "B";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipoPvDesde_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(316, 120);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(132, 24);
                        this.Label7.TabIndex = 4;
                        this.Label7.Text = "Próximo Número";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPv
                        // 
                        this.EntradaPv.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPv.Location = new System.Drawing.Point(448, 88);
                        this.EntradaPv.Name = "EntradaPv";
                        this.EntradaPv.Size = new System.Drawing.Size(52, 24);
                        this.EntradaPv.TabIndex = 3;
                        this.EntradaPv.Text = "1";
                        this.EntradaPv.TextChanged += new System.EventHandler(this.EntradaTipoPvDesde_TextChanged);
                        // 
                        // EntradaDesde
                        // 
                        this.EntradaDesde.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaDesde.Location = new System.Drawing.Point(448, 120);
                        this.EntradaDesde.Name = "EntradaDesde";
                        this.EntradaDesde.Size = new System.Drawing.Size(100, 24);
                        this.EntradaDesde.TabIndex = 5;
                        this.EntradaDesde.Text = "0";
                        this.EntradaDesde.TextChanged += new System.EventHandler(this.EntradaTipoPvDesde_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(24, 88);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(128, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Comprobante";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelAyuda
                        // 
                        this.LabelAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelAyuda.AutoEllipsis = true;
                        this.LabelAyuda.Location = new System.Drawing.Point(24, 192);
                        this.LabelAyuda.Name = "LabelAyuda";
                        this.LabelAyuda.Size = new System.Drawing.Size(576, 92);
                        this.LabelAyuda.TabIndex = 6;
                        this.LabelAyuda.Text = "...";
                        // 
                        // formHeader1
                        // 
                        this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.formHeader1.Location = new System.Drawing.Point(0, 0);
                        this.formHeader1.Name = "formHeader1";
                        this.formHeader1.Size = new System.Drawing.Size(624, 64);
                        this.formHeader1.TabIndex = 101;
                        this.formHeader1.Text = "Iniciar numeración";
                        // 
                        // IniciarNumeracion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(624, 362);
                        this.Controls.Add(this.formHeader1);
                        this.Controls.Add(this.LabelAyuda);
                        this.Controls.Add(this.EntradaPv);
                        this.Controls.Add(this.EntradaDesde);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label1);
                        this.Name = "IniciarNumeracion";
                        this.Text = "Iniciar Numeración";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaDesde, 0);
                        this.Controls.SetChildIndex(this.EntradaPv, 0);
                        this.Controls.SetChildIndex(this.LabelAyuda, 0);
                        this.Controls.SetChildIndex(this.formHeader1, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label label4;
                public Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaPv;
                internal Lui.Forms.TextBox EntradaDesde;
                internal Lui.Forms.Label Label1;
                private Lui.Forms.Label LabelAyuda;
                private Lui.Forms.FormHeader formHeader1;
        }
}
