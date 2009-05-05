// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lui.Forms.AuxForms
{
        partial class ProductDetail
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
                        this.cmdCancelar = new Lui.Forms.Button();
                        this.cmdAceptar = new Lui.Forms.Button();
                        this.label1 = new System.Windows.Forms.Label();
                        this.txtSerials = new Lui.Forms.TextBox();
                        this.txtDescuento = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.fieldTags1 = new Lui.Forms.FieldTags();
                        this.SuspendLayout();
                        // 
                        // cmdCancelar
                        // 
                        this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCancelar.Image = null;
                        this.cmdCancelar.ImagePos = Lui.Forms.ImagePositions.Middle;
                        this.cmdCancelar.Location = new System.Drawing.Point(396, 252);
                        this.cmdCancelar.Name = "cmdCancelar";
                        this.cmdCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCancelar.ReadOnly = false;
                        this.cmdCancelar.Size = new System.Drawing.Size(100, 44);
                        this.cmdCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdCancelar.Subtext = "Esc";
                        this.cmdCancelar.TabIndex = 4;
                        this.cmdCancelar.Text = "Cancelar";
                        this.cmdCancelar.ToolTipText = "";
                        // 
                        // cmdAceptar
                        // 
                        this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdAceptar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdAceptar.Image = null;
                        this.cmdAceptar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdAceptar.Location = new System.Drawing.Point(288, 252);
                        this.cmdAceptar.Name = "cmdAceptar";
                        this.cmdAceptar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdAceptar.ReadOnly = false;
                        this.cmdAceptar.Size = new System.Drawing.Size(100, 44);
                        this.cmdAceptar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdAceptar.Subtext = "F9";
                        this.cmdAceptar.TabIndex = 3;
                        this.cmdAceptar.Text = "Aceptar";
                        this.cmdAceptar.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(20, 48);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(124, 24);
                        this.label1.TabIndex = 5;
                        this.label1.Text = "Nros. de serie";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSerials
                        // 
                        this.txtSerials.AutoNav = true;
                        this.txtSerials.AutoTab = true;
                        this.txtSerials.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtSerials.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtSerials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtSerials.Location = new System.Drawing.Point(152, 48);
                        this.txtSerials.MaxLenght = 32767;
                        this.txtSerials.Name = "txtSerials";
                        this.txtSerials.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSerials.ReadOnly = false;
                        this.txtSerials.Size = new System.Drawing.Size(340, 24);
                        this.txtSerials.TabIndex = 6;
                        this.txtSerials.TipWhenBlank = "";
                        this.txtSerials.ToolTipText = "";
                        // 
                        // txtDescuento
                        // 
                        this.txtDescuento.AutoNav = true;
                        this.txtDescuento.AutoTab = true;
                        this.txtDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.txtDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDescuento.Location = new System.Drawing.Point(152, 16);
                        this.txtDescuento.MaxLenght = 32767;
                        this.txtDescuento.Name = "txtDescuento";
                        this.txtDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescuento.ReadOnly = false;
                        this.txtDescuento.Size = new System.Drawing.Size(96, 24);
                        this.txtDescuento.Sufijo = "%";
                        this.txtDescuento.TabIndex = 8;
                        this.txtDescuento.Text = "0.00";
                        this.txtDescuento.TipWhenBlank = "";
                        this.txtDescuento.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(20, 16);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(124, 24);
                        this.label2.TabIndex = 7;
                        this.label2.Text = "Descuento";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // fieldTags1
                        // 
                        this.fieldTags1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.fieldTags1.Location = new System.Drawing.Point(24, 88);
                        this.fieldTags1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.fieldTags1.Name = "fieldTags1";
                        this.fieldTags1.Size = new System.Drawing.Size(468, 164);
                        this.fieldTags1.TabIndex = 9;
                        this.fieldTags1.Text = "Atributos especiales";
                        // 
                        // ProductDetail
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.ClientSize = new System.Drawing.Size(508, 309);
                        this.ControlBox = false;
                        this.Controls.Add(this.fieldTags1);
                        this.Controls.Add(this.txtDescuento);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.txtSerials);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.cmdCancelar);
                        this.Controls.Add(this.cmdAceptar);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Name = "ProductDetail";
                        this.Text = "Detalles del artículo";
                        this.ResumeLayout(false);

                }

                #endregion

                internal Button cmdCancelar;
                internal Button cmdAceptar;
                private System.Windows.Forms.Label label1;
                private TextBox txtSerials;
                private TextBox txtDescuento;
                private System.Windows.Forms.Label label2;
                private FieldTags fieldTags1;
        }
}