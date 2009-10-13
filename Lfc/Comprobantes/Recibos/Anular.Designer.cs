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

namespace Lfc.Comprobantes.Recibos
{
        partial class Anular
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
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EtiquetaAviso = new System.Windows.Forms.Label();
                        this.EntradaCliente = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaFecha = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(168, 52);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(16, 24);
                        this.Label7.TabIndex = 4;
                        this.Label7.Text = "-";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoHeight = false;
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(108, 52);
                        this.EntradaPV.MaxLenght = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(60, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 3;
                        this.EntradaPV.Text = "1";
                        this.EntradaPV.TextRaw = "1";
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        this.EntradaPV.TextChanged += new System.EventHandler(this.EntradaNumeroTipoPV);
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoHeight = false;
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(184, 52);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(100, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 5;
                        this.EntradaNumero.Text = "0";
                        this.EntradaNumero.TextRaw = "0";
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        this.EntradaNumero.TextChanged += new System.EventHandler(this.EntradaNumeroTipoPV);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(24, 52);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(84, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Número";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AutoHeight = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(108, 24);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "De Pago|RCP",
        "De Cobro|RC"};
                        this.EntradaTipo.Size = new System.Drawing.Size(176, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.Text = "De Cobro";
                        this.EntradaTipo.TextKey = "RC";
                        this.EntradaTipo.TextRaw = "De Cobro";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaNumeroTipoPV);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(24, 24);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(84, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Tipo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaAviso
                        // 
                        this.EtiquetaAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaAviso.Location = new System.Drawing.Point(112, 200);
                        this.EtiquetaAviso.Name = "EtiquetaAviso";
                        this.EtiquetaAviso.Size = new System.Drawing.Size(496, 56);
                        this.EtiquetaAviso.TabIndex = 12;
                        // 
                        // EntradaCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoHeight = false;
                        this.EntradaCliente.AutoNav = true;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCliente.DecimalPlaces = -1;
                        this.EntradaCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCliente.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCliente.Location = new System.Drawing.Point(108, 172);
                        this.EntradaCliente.MaxLenght = 32767;
                        this.EntradaCliente.MultiLine = false;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.PasswordChar = '\0';
                        this.EntradaCliente.Prefijo = "";
                        this.EntradaCliente.ReadOnly = true;
                        this.EntradaCliente.SelectOnFocus = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(476, 24);
                        this.EntradaCliente.Sufijo = "";
                        this.EntradaCliente.TabIndex = 11;
                        this.EntradaCliente.TabStop = false;
                        this.EntradaCliente.TextRaw = "";
                        this.EntradaCliente.TipWhenBlank = "";
                        this.EntradaCliente.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(24, 172);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(84, 24);
                        this.Label4.TabIndex = 10;
                        this.Label4.Text = "Cliente";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoHeight = false;
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaImporte.Location = new System.Drawing.Point(108, 144);
                        this.EntradaImporte.MaxLenght = 32767;
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.PasswordChar = '\0';
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.ReadOnly = true;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(128, 24);
                        this.EntradaImporte.Sufijo = "";
                        this.EntradaImporte.TabIndex = 9;
                        this.EntradaImporte.TabStop = false;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TextRaw = "0.00";
                        this.EntradaImporte.TipWhenBlank = "";
                        this.EntradaImporte.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(24, 144);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(84, 24);
                        this.Label5.TabIndex = 8;
                        this.Label5.Text = "Importe";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFecha
                        // 
                        this.EntradaFecha.AutoHeight = false;
                        this.EntradaFecha.AutoNav = true;
                        this.EntradaFecha.AutoTab = true;
                        this.EntradaFecha.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaFecha.DecimalPlaces = -1;
                        this.EntradaFecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFecha.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFecha.Location = new System.Drawing.Point(108, 116);
                        this.EntradaFecha.MaxLenght = 32767;
                        this.EntradaFecha.MultiLine = false;
                        this.EntradaFecha.Name = "EntradaFecha";
                        this.EntradaFecha.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFecha.PasswordChar = '\0';
                        this.EntradaFecha.Prefijo = "";
                        this.EntradaFecha.ReadOnly = true;
                        this.EntradaFecha.SelectOnFocus = true;
                        this.EntradaFecha.Size = new System.Drawing.Size(128, 24);
                        this.EntradaFecha.Sufijo = "";
                        this.EntradaFecha.TabIndex = 7;
                        this.EntradaFecha.TabStop = false;
                        this.EntradaFecha.TextRaw = "";
                        this.EntradaFecha.TipWhenBlank = "";
                        this.EntradaFecha.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(24, 116);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(84, 24);
                        this.Label3.TabIndex = 6;
                        this.Label3.Text = "Fecha";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Anular
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.ControlBox = true;
                        this.Controls.Add(this.EtiquetaAviso);
                        this.Controls.Add(this.EntradaCliente);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaImporte);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.EntradaFecha);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label1);
                        this.Name = "Anular";
                        this.Text = "Anular";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.EntradaPV, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaFecha, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaImporte, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.EtiquetaAviso, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaPV;
                internal Lui.Forms.TextBox EntradaNumero;
                internal System.Windows.Forms.Label Label2;
                public Lui.Forms.ComboBox EntradaTipo;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label EtiquetaAviso;
                internal Lui.Forms.TextBox EntradaCliente;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaImporte;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaFecha;
                internal System.Windows.Forms.Label Label3;
        }
}