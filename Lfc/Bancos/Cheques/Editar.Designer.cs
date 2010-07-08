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

namespace Lfc.Bancos.Cheques
{
        partial class Editar
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
                        this.EntradaEmisor = new Lui.Forms.TextBox();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.EntradaBanco = new Lui.Forms.DetailBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaFechaCobro = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaFechaEmision = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(568, 10);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(680, 10);
                        // 
                        // EntradaEmisor
                        // 
                        this.EntradaEmisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmisor.AutoNav = true;
                        this.EntradaEmisor.AutoTab = true;
                        this.EntradaEmisor.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmisor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmisor.Location = new System.Drawing.Point(160, 20);
                        this.EntradaEmisor.MaxLenght = 32767;
                        this.EntradaEmisor.Name = "EntradaEmisor";
                        this.EntradaEmisor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmisor.ReadOnly = false;
                        this.EntradaEmisor.Size = new System.Drawing.Size(608, 24);
                        this.EntradaEmisor.TabIndex = 1;
                        this.EntradaEmisor.TipWhenBlank = "";
                        this.EntradaEmisor.ToolTipText = "Estado para esta chequera.";
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(160, 84);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.Size = new System.Drawing.Size(172, 24);
                        this.EntradaNumero.TabIndex = 5;
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DetailField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.KeyField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(160, 52);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.ReadOnly = false;
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.SelectOnFocus = false;
                        this.EntradaBanco.Size = new System.Drawing.Size(608, 24);
                        this.EntradaBanco.TabIndex = 3;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TextInt = 0;
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(20, 20);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(140, 24);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Emisor";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 84);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(140, 24);
                        this.Label3.TabIndex = 4;
                        this.Label3.Text = "Número";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 52);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(140, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaCobro
                        // 
                        this.EntradaFechaCobro.AutoNav = true;
                        this.EntradaFechaCobro.AutoTab = true;
                        this.EntradaFechaCobro.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaCobro.Location = new System.Drawing.Point(160, 148);
                        this.EntradaFechaCobro.MaxLenght = 32767;
                        this.EntradaFechaCobro.Name = "EntradaFechaCobro";
                        this.EntradaFechaCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaCobro.ReadOnly = false;
                        this.EntradaFechaCobro.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaCobro.TabIndex = 9;
                        this.EntradaFechaCobro.TipWhenBlank = "";
                        this.EntradaFechaCobro.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(20, 148);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(140, 24);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "Fecha de cobro";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaEmision
                        // 
                        this.EntradaFechaEmision.AutoNav = true;
                        this.EntradaFechaEmision.AutoTab = true;
                        this.EntradaFechaEmision.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaEmision.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaEmision.Location = new System.Drawing.Point(160, 116);
                        this.EntradaFechaEmision.MaxLenght = 32767;
                        this.EntradaFechaEmision.Name = "EntradaFechaEmision";
                        this.EntradaFechaEmision.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaEmision.ReadOnly = false;
                        this.EntradaFechaEmision.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaEmision.TabIndex = 7;
                        this.EntradaFechaEmision.TipWhenBlank = "";
                        this.EntradaFechaEmision.ToolTipText = "";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(20, 116);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(140, 24);
                        this.lblFecha1.TabIndex = 6;
                        this.lblFecha1.Text = "Fecha de emisión";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(792, 473);
                        this.Controls.Add(this.EntradaFechaCobro);
                        this.Controls.Add(this.EntradaFechaEmision);
                        this.Controls.Add(this.EntradaEmisor);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.lblFecha1);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Name = "Editar";
                        this.Text = "Cheque";
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.TextBox EntradaEmisor;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lui.Forms.DetailBox EntradaBanco;
                internal System.Windows.Forms.Label label5;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaFechaCobro;
                internal System.Windows.Forms.Label label2;
                public Lui.Forms.TextBox EntradaFechaEmision;
                internal System.Windows.Forms.Label lblFecha1;
        }
}