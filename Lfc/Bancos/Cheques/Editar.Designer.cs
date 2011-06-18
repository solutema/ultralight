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

namespace Lfc.Bancos.Cheques
{
        partial class Editar
        {
                private System.ComponentModel.IContainer components = null;

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
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.label5 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaFechaCobro = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaFechaEmision = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaEmisor
                        // 
                        this.EntradaEmisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmisor.AutoSize = false;
                        this.EntradaEmisor.AutoNav = true;
                        this.EntradaEmisor.AutoTab = true;
                        this.EntradaEmisor.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmisor.DecimalPlaces = -1;
                        this.EntradaEmisor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmisor.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmisor.Location = new System.Drawing.Point(140, 0);
                        this.EntradaEmisor.MaxLenght = 32767;
                        this.EntradaEmisor.MultiLine = false;
                        this.EntradaEmisor.Name = "EntradaEmisor";
                        this.EntradaEmisor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmisor.PasswordChar = '\0';
                        this.EntradaEmisor.Prefijo = "";
                        this.EntradaEmisor.TemporaryReadOnly = false;
                        this.EntradaEmisor.SelectOnFocus = true;
                        this.EntradaEmisor.Size = new System.Drawing.Size(372, 24);
                        this.EntradaEmisor.Sufijo = "";
                        this.EntradaEmisor.TabIndex = 1;
                        this.EntradaEmisor.TipWhenBlank = "";
                        this.EntradaEmisor.ToolTipText = "Estado para esta chequera.";
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoSize = false;
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(140, 64);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.TemporaryReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(172, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 5;
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoSize = false;
                        this.EntradaBanco.AutoNav = true;
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DataTextField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Filter = "";
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.DataValueField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(140, 32);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.TemporaryReadOnly = false;
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.Size = new System.Drawing.Size(372, 24);
                        this.EntradaBanco.TabIndex = 3;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(140, 24);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Emisor";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(0, 64);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(140, 24);
                        this.Label3.TabIndex = 4;
                        this.Label3.Text = "Número";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 32);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(140, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaCobro
                        // 
                        this.EntradaFechaCobro.AutoSize = false;
                        this.EntradaFechaCobro.AutoNav = true;
                        this.EntradaFechaCobro.AutoTab = true;
                        this.EntradaFechaCobro.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaCobro.DecimalPlaces = -1;
                        this.EntradaFechaCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaCobro.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaCobro.Location = new System.Drawing.Point(140, 128);
                        this.EntradaFechaCobro.MaxLenght = 32767;
                        this.EntradaFechaCobro.MultiLine = false;
                        this.EntradaFechaCobro.Name = "EntradaFechaCobro";
                        this.EntradaFechaCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaCobro.PasswordChar = '\0';
                        this.EntradaFechaCobro.Prefijo = "";
                        this.EntradaFechaCobro.TemporaryReadOnly = false;
                        this.EntradaFechaCobro.SelectOnFocus = true;
                        this.EntradaFechaCobro.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaCobro.Sufijo = "";
                        this.EntradaFechaCobro.TabIndex = 9;
                        this.EntradaFechaCobro.TipWhenBlank = "";
                        this.EntradaFechaCobro.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 128);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(140, 24);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "Fecha de cobro";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaEmision
                        // 
                        this.EntradaFechaEmision.AutoSize = false;
                        this.EntradaFechaEmision.AutoNav = true;
                        this.EntradaFechaEmision.AutoTab = true;
                        this.EntradaFechaEmision.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaEmision.DecimalPlaces = -1;
                        this.EntradaFechaEmision.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaEmision.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaEmision.Location = new System.Drawing.Point(140, 96);
                        this.EntradaFechaEmision.MaxLenght = 32767;
                        this.EntradaFechaEmision.MultiLine = false;
                        this.EntradaFechaEmision.Name = "EntradaFechaEmision";
                        this.EntradaFechaEmision.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaEmision.PasswordChar = '\0';
                        this.EntradaFechaEmision.Prefijo = "";
                        this.EntradaFechaEmision.TemporaryReadOnly = false;
                        this.EntradaFechaEmision.SelectOnFocus = true;
                        this.EntradaFechaEmision.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaEmision.Sufijo = "";
                        this.EntradaFechaEmision.TabIndex = 7;
                        this.EntradaFechaEmision.TipWhenBlank = "";
                        this.EntradaFechaEmision.ToolTipText = "";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(0, 96);
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
                        this.AutoSize = true;
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.EntradaFechaCobro);
                        this.Controls.Add(this.EntradaFechaEmision);
                        this.Controls.Add(this.EntradaEmisor);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.lblFecha1);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label3);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(512, 157);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.lblFecha1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaBanco, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.EntradaEmisor, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaEmision, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaCobro, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaEmisor;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lcc.Entrada.CodigoDetalle EntradaBanco;
                internal System.Windows.Forms.Label label5;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaFechaCobro;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaEmision;
                internal System.Windows.Forms.Label lblFecha1;
        }
}