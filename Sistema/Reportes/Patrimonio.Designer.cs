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

namespace Lazaro.Reportes
{
        partial class Patrimonio
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
                    this.label1 = new System.Windows.Forms.Label();
                    this.note1 = new Lui.Forms.Note();
                    this.txtActivosCuentas = new Lui.Forms.TextBox();
                    this.txtFuturosTarjetas = new Lui.Forms.TextBox();
                    this.label2 = new System.Windows.Forms.Label();
                    this.txtActivosStock = new Lui.Forms.TextBox();
                    this.label3 = new System.Windows.Forms.Label();
                    this.txtFuturosPedidos = new Lui.Forms.TextBox();
                    this.label4 = new System.Windows.Forms.Label();
                    this.txtPasivosCheques = new Lui.Forms.TextBox();
                    this.label7 = new System.Windows.Forms.Label();
                    this.txtPasivosCuentas = new Lui.Forms.TextBox();
                    this.note2 = new Lui.Forms.Note();
                    this.label8 = new System.Windows.Forms.Label();
                    this.note3 = new Lui.Forms.Note();
                    this.txtActivosSubtotal = new Lui.Forms.TextBox();
                    this.label5 = new System.Windows.Forms.Label();
                    this.txtPasivosSubtotal = new Lui.Forms.TextBox();
                    this.label6 = new System.Windows.Forms.Label();
                    this.txtFuturosSubtotal = new Lui.Forms.TextBox();
                    this.label9 = new System.Windows.Forms.Label();
                    this.txtPatrimonioActual = new Lui.Forms.TextBox();
                    this.label10 = new System.Windows.Forms.Label();
                    this.note4 = new Lui.Forms.Note();
                    this.txtPatrimonioFuturo = new Lui.Forms.TextBox();
                    this.label11 = new System.Windows.Forms.Label();
                    this.txtActivosActualesFuturos = new Lui.Forms.TextBox();
                    this.label12 = new System.Windows.Forms.Label();
                    this.txtPasivosStock = new Lui.Forms.TextBox();
                    this.label13 = new System.Windows.Forms.Label();
                    this.txtCC = new Lui.Forms.TextBox();
                    this.label14 = new System.Windows.Forms.Label();
                    this.SuspendLayout();
                    // 
                    // label1
                    // 
                    this.label1.Location = new System.Drawing.Point(32, 52);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(232, 24);
                    this.label1.TabIndex = 0;
                    this.label1.Text = "Dinero en cuentas";
                    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label1.UseMnemonic = false;
                    // 
                    // note1
                    // 
                    this.note1.AutoHeight = false;
                    this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.note1.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.note1.Location = new System.Drawing.Point(16, 16);
                    this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note1.Name = "note1";
                    this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note1.ReadOnly = false;
                    this.note1.Size = new System.Drawing.Size(356, 36);
                    this.note1.TabIndex = 1;
                    this.note1.Text = "note1";
                    this.note1.Title = "Activos";
                    this.note1.ToolTipText = "";
                    // 
                    // txtActivosCuentas
                    // 
                    this.txtActivosCuentas.AutoHeight = false;
                    this.txtActivosCuentas.AutoNav = true;
                    this.txtActivosCuentas.AutoTab = true;
                    this.txtActivosCuentas.DataType = Lui.Forms.DataTypes.Money;
                    this.txtActivosCuentas.DecimalPlaces = -1;
                    this.txtActivosCuentas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtActivosCuentas.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtActivosCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtActivosCuentas.Location = new System.Drawing.Point(268, 52);
                    this.txtActivosCuentas.MaxLenght = 32767;
                    this.txtActivosCuentas.MultiLine = false;
                    this.txtActivosCuentas.Name = "txtActivosCuentas";
                    this.txtActivosCuentas.Padding = new System.Windows.Forms.Padding(2);
                    this.txtActivosCuentas.PasswordChar = '\0';
                    this.txtActivosCuentas.Prefijo = "$";
                    this.txtActivosCuentas.ReadOnly = true;
                    this.txtActivosCuentas.SelectOnFocus = true;
                    this.txtActivosCuentas.Size = new System.Drawing.Size(100, 24);
                    this.txtActivosCuentas.Sufijo = "";
                    this.txtActivosCuentas.TabIndex = 2;
                    this.txtActivosCuentas.Text = "0.00";
                    this.txtActivosCuentas.TextRaw = "0.00";
                    this.txtActivosCuentas.TipWhenBlank = "";
                    this.txtActivosCuentas.ToolTipText = "";
                    // 
                    // txtFuturosTarjetas
                    // 
                    this.txtFuturosTarjetas.AutoHeight = false;
                    this.txtFuturosTarjetas.AutoNav = true;
                    this.txtFuturosTarjetas.AutoTab = true;
                    this.txtFuturosTarjetas.DataType = Lui.Forms.DataTypes.Money;
                    this.txtFuturosTarjetas.DecimalPlaces = -1;
                    this.txtFuturosTarjetas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtFuturosTarjetas.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtFuturosTarjetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtFuturosTarjetas.Location = new System.Drawing.Point(640, 52);
                    this.txtFuturosTarjetas.MaxLenght = 32767;
                    this.txtFuturosTarjetas.MultiLine = false;
                    this.txtFuturosTarjetas.Name = "txtFuturosTarjetas";
                    this.txtFuturosTarjetas.Padding = new System.Windows.Forms.Padding(2);
                    this.txtFuturosTarjetas.PasswordChar = '\0';
                    this.txtFuturosTarjetas.Prefijo = "$";
                    this.txtFuturosTarjetas.ReadOnly = true;
                    this.txtFuturosTarjetas.SelectOnFocus = true;
                    this.txtFuturosTarjetas.Size = new System.Drawing.Size(100, 24);
                    this.txtFuturosTarjetas.Sufijo = "";
                    this.txtFuturosTarjetas.TabIndex = 4;
                    this.txtFuturosTarjetas.Text = "0.00";
                    this.txtFuturosTarjetas.TextRaw = "0.00";
                    this.txtFuturosTarjetas.TipWhenBlank = "";
                    this.txtFuturosTarjetas.ToolTipText = "";
                    // 
                    // label2
                    // 
                    this.label2.Location = new System.Drawing.Point(404, 52);
                    this.label2.Name = "label2";
                    this.label2.Size = new System.Drawing.Size(232, 24);
                    this.label2.TabIndex = 3;
                    this.label2.Text = "Presentaciones de tarjetas";
                    this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label2.UseMnemonic = false;
                    // 
                    // txtActivosStock
                    // 
                    this.txtActivosStock.AutoHeight = false;
                    this.txtActivosStock.AutoNav = true;
                    this.txtActivosStock.AutoTab = true;
                    this.txtActivosStock.DataType = Lui.Forms.DataTypes.Money;
                    this.txtActivosStock.DecimalPlaces = -1;
                    this.txtActivosStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtActivosStock.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtActivosStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtActivosStock.Location = new System.Drawing.Point(268, 80);
                    this.txtActivosStock.MaxLenght = 32767;
                    this.txtActivosStock.MultiLine = false;
                    this.txtActivosStock.Name = "txtActivosStock";
                    this.txtActivosStock.Padding = new System.Windows.Forms.Padding(2);
                    this.txtActivosStock.PasswordChar = '\0';
                    this.txtActivosStock.Prefijo = "$";
                    this.txtActivosStock.ReadOnly = true;
                    this.txtActivosStock.SelectOnFocus = true;
                    this.txtActivosStock.Size = new System.Drawing.Size(100, 24);
                    this.txtActivosStock.Sufijo = "";
                    this.txtActivosStock.TabIndex = 6;
                    this.txtActivosStock.Text = "0.00";
                    this.txtActivosStock.TextRaw = "0.00";
                    this.txtActivosStock.TipWhenBlank = "";
                    this.txtActivosStock.ToolTipText = "";
                    // 
                    // label3
                    // 
                    this.label3.Location = new System.Drawing.Point(32, 80);
                    this.label3.Name = "label3";
                    this.label3.Size = new System.Drawing.Size(232, 24);
                    this.label3.TabIndex = 5;
                    this.label3.Text = "Stock";
                    this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label3.UseMnemonic = false;
                    // 
                    // txtFuturosPedidos
                    // 
                    this.txtFuturosPedidos.AutoHeight = false;
                    this.txtFuturosPedidos.AutoNav = true;
                    this.txtFuturosPedidos.AutoTab = true;
                    this.txtFuturosPedidos.DataType = Lui.Forms.DataTypes.Money;
                    this.txtFuturosPedidos.DecimalPlaces = -1;
                    this.txtFuturosPedidos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtFuturosPedidos.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtFuturosPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtFuturosPedidos.Location = new System.Drawing.Point(640, 114);
                    this.txtFuturosPedidos.MaxLenght = 32767;
                    this.txtFuturosPedidos.MultiLine = false;
                    this.txtFuturosPedidos.Name = "txtFuturosPedidos";
                    this.txtFuturosPedidos.Padding = new System.Windows.Forms.Padding(2);
                    this.txtFuturosPedidos.PasswordChar = '\0';
                    this.txtFuturosPedidos.Prefijo = "$";
                    this.txtFuturosPedidos.ReadOnly = true;
                    this.txtFuturosPedidos.SelectOnFocus = true;
                    this.txtFuturosPedidos.Size = new System.Drawing.Size(100, 24);
                    this.txtFuturosPedidos.Sufijo = "";
                    this.txtFuturosPedidos.TabIndex = 8;
                    this.txtFuturosPedidos.Text = "0.00";
                    this.txtFuturosPedidos.TextRaw = "0.00";
                    this.txtFuturosPedidos.TipWhenBlank = "";
                    this.txtFuturosPedidos.ToolTipText = "";
                    // 
                    // label4
                    // 
                    this.label4.Location = new System.Drawing.Point(404, 114);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(232, 24);
                    this.label4.TabIndex = 7;
                    this.label4.Text = "Mercadería en tránsito";
                    this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label4.UseMnemonic = false;
                    // 
                    // txtPasivosCheques
                    // 
                    this.txtPasivosCheques.AutoHeight = false;
                    this.txtPasivosCheques.AutoNav = true;
                    this.txtPasivosCheques.AutoTab = true;
                    this.txtPasivosCheques.DataType = Lui.Forms.DataTypes.Money;
                    this.txtPasivosCheques.DecimalPlaces = -1;
                    this.txtPasivosCheques.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtPasivosCheques.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtPasivosCheques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtPasivosCheques.Location = new System.Drawing.Point(268, 260);
                    this.txtPasivosCheques.MaxLenght = 32767;
                    this.txtPasivosCheques.MultiLine = false;
                    this.txtPasivosCheques.Name = "txtPasivosCheques";
                    this.txtPasivosCheques.Padding = new System.Windows.Forms.Padding(2);
                    this.txtPasivosCheques.PasswordChar = '\0';
                    this.txtPasivosCheques.Prefijo = "$";
                    this.txtPasivosCheques.ReadOnly = true;
                    this.txtPasivosCheques.SelectOnFocus = true;
                    this.txtPasivosCheques.Size = new System.Drawing.Size(100, 24);
                    this.txtPasivosCheques.Sufijo = "";
                    this.txtPasivosCheques.TabIndex = 13;
                    this.txtPasivosCheques.Text = "0.00";
                    this.txtPasivosCheques.TextRaw = "0.00";
                    this.txtPasivosCheques.TipWhenBlank = "";
                    this.txtPasivosCheques.ToolTipText = "";
                    // 
                    // label7
                    // 
                    this.label7.Location = new System.Drawing.Point(32, 260);
                    this.label7.Name = "label7";
                    this.label7.Size = new System.Drawing.Size(232, 24);
                    this.label7.TabIndex = 12;
                    this.label7.Text = "Cheques emitidos";
                    this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label7.UseMnemonic = false;
                    // 
                    // txtPasivosCuentas
                    // 
                    this.txtPasivosCuentas.AutoHeight = false;
                    this.txtPasivosCuentas.AutoNav = true;
                    this.txtPasivosCuentas.AutoTab = true;
                    this.txtPasivosCuentas.DataType = Lui.Forms.DataTypes.Money;
                    this.txtPasivosCuentas.DecimalPlaces = -1;
                    this.txtPasivosCuentas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtPasivosCuentas.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtPasivosCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtPasivosCuentas.Location = new System.Drawing.Point(268, 204);
                    this.txtPasivosCuentas.MaxLenght = 32767;
                    this.txtPasivosCuentas.MultiLine = false;
                    this.txtPasivosCuentas.Name = "txtPasivosCuentas";
                    this.txtPasivosCuentas.Padding = new System.Windows.Forms.Padding(2);
                    this.txtPasivosCuentas.PasswordChar = '\0';
                    this.txtPasivosCuentas.Prefijo = "$";
                    this.txtPasivosCuentas.ReadOnly = true;
                    this.txtPasivosCuentas.SelectOnFocus = true;
                    this.txtPasivosCuentas.Size = new System.Drawing.Size(100, 24);
                    this.txtPasivosCuentas.Sufijo = "";
                    this.txtPasivosCuentas.TabIndex = 11;
                    this.txtPasivosCuentas.Text = "0.00";
                    this.txtPasivosCuentas.TextRaw = "0.00";
                    this.txtPasivosCuentas.TipWhenBlank = "";
                    this.txtPasivosCuentas.ToolTipText = "";
                    // 
                    // note2
                    // 
                    this.note2.AutoHeight = false;
                    this.note2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.note2.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.note2.Location = new System.Drawing.Point(16, 168);
                    this.note2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note2.Name = "note2";
                    this.note2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note2.ReadOnly = false;
                    this.note2.Size = new System.Drawing.Size(356, 36);
                    this.note2.TabIndex = 10;
                    this.note2.Text = "note2";
                    this.note2.Title = "Pasivos";
                    this.note2.ToolTipText = "";
                    // 
                    // label8
                    // 
                    this.label8.Location = new System.Drawing.Point(32, 204);
                    this.label8.Name = "label8";
                    this.label8.Size = new System.Drawing.Size(232, 24);
                    this.label8.TabIndex = 9;
                    this.label8.Text = "Descubiertos en cuentas";
                    this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label8.UseMnemonic = false;
                    // 
                    // note3
                    // 
                    this.note3.AutoHeight = false;
                    this.note3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.note3.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.note3.Location = new System.Drawing.Point(388, 16);
                    this.note3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note3.Name = "note3";
                    this.note3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note3.ReadOnly = false;
                    this.note3.Size = new System.Drawing.Size(356, 36);
                    this.note3.TabIndex = 18;
                    this.note3.Text = "note3";
                    this.note3.Title = "Futuros";
                    this.note3.ToolTipText = "";
                    // 
                    // txtActivosSubtotal
                    // 
                    this.txtActivosSubtotal.AutoHeight = false;
                    this.txtActivosSubtotal.AutoNav = true;
                    this.txtActivosSubtotal.AutoTab = true;
                    this.txtActivosSubtotal.DataType = Lui.Forms.DataTypes.Money;
                    this.txtActivosSubtotal.DecimalPlaces = -1;
                    this.txtActivosSubtotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtActivosSubtotal.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtActivosSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtActivosSubtotal.Location = new System.Drawing.Point(268, 112);
                    this.txtActivosSubtotal.MaxLenght = 32767;
                    this.txtActivosSubtotal.MultiLine = false;
                    this.txtActivosSubtotal.Name = "txtActivosSubtotal";
                    this.txtActivosSubtotal.Padding = new System.Windows.Forms.Padding(2);
                    this.txtActivosSubtotal.PasswordChar = '\0';
                    this.txtActivosSubtotal.Prefijo = "$";
                    this.txtActivosSubtotal.ReadOnly = true;
                    this.txtActivosSubtotal.SelectOnFocus = true;
                    this.txtActivosSubtotal.Size = new System.Drawing.Size(100, 24);
                    this.txtActivosSubtotal.Sufijo = "";
                    this.txtActivosSubtotal.TabIndex = 20;
                    this.txtActivosSubtotal.Text = "0.00";
                    this.txtActivosSubtotal.TextRaw = "0.00";
                    this.txtActivosSubtotal.TipWhenBlank = "";
                    this.txtActivosSubtotal.ToolTipText = "";
                    // 
                    // label5
                    // 
                    this.label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label5.Location = new System.Drawing.Point(32, 112);
                    this.label5.Name = "label5";
                    this.label5.Size = new System.Drawing.Size(232, 24);
                    this.label5.TabIndex = 19;
                    this.label5.Text = "Subtotal";
                    this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label5.UseMnemonic = false;
                    // 
                    // txtPasivosSubtotal
                    // 
                    this.txtPasivosSubtotal.AutoHeight = false;
                    this.txtPasivosSubtotal.AutoNav = true;
                    this.txtPasivosSubtotal.AutoTab = true;
                    this.txtPasivosSubtotal.DataType = Lui.Forms.DataTypes.Money;
                    this.txtPasivosSubtotal.DecimalPlaces = -1;
                    this.txtPasivosSubtotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtPasivosSubtotal.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtPasivosSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtPasivosSubtotal.Location = new System.Drawing.Point(268, 292);
                    this.txtPasivosSubtotal.MaxLenght = 32767;
                    this.txtPasivosSubtotal.MultiLine = false;
                    this.txtPasivosSubtotal.Name = "txtPasivosSubtotal";
                    this.txtPasivosSubtotal.Padding = new System.Windows.Forms.Padding(2);
                    this.txtPasivosSubtotal.PasswordChar = '\0';
                    this.txtPasivosSubtotal.Prefijo = "$";
                    this.txtPasivosSubtotal.ReadOnly = true;
                    this.txtPasivosSubtotal.SelectOnFocus = true;
                    this.txtPasivosSubtotal.Size = new System.Drawing.Size(100, 24);
                    this.txtPasivosSubtotal.Sufijo = "";
                    this.txtPasivosSubtotal.TabIndex = 22;
                    this.txtPasivosSubtotal.Text = "0.00";
                    this.txtPasivosSubtotal.TextRaw = "0.00";
                    this.txtPasivosSubtotal.TipWhenBlank = "";
                    this.txtPasivosSubtotal.ToolTipText = "";
                    // 
                    // label6
                    // 
                    this.label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label6.Location = new System.Drawing.Point(32, 292);
                    this.label6.Name = "label6";
                    this.label6.Size = new System.Drawing.Size(232, 24);
                    this.label6.TabIndex = 21;
                    this.label6.Text = "Subtotal";
                    this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label6.UseMnemonic = false;
                    // 
                    // txtFuturosSubtotal
                    // 
                    this.txtFuturosSubtotal.AutoHeight = false;
                    this.txtFuturosSubtotal.AutoNav = true;
                    this.txtFuturosSubtotal.AutoTab = true;
                    this.txtFuturosSubtotal.DataType = Lui.Forms.DataTypes.Money;
                    this.txtFuturosSubtotal.DecimalPlaces = -1;
                    this.txtFuturosSubtotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtFuturosSubtotal.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtFuturosSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtFuturosSubtotal.Location = new System.Drawing.Point(640, 146);
                    this.txtFuturosSubtotal.MaxLenght = 32767;
                    this.txtFuturosSubtotal.MultiLine = false;
                    this.txtFuturosSubtotal.Name = "txtFuturosSubtotal";
                    this.txtFuturosSubtotal.Padding = new System.Windows.Forms.Padding(2);
                    this.txtFuturosSubtotal.PasswordChar = '\0';
                    this.txtFuturosSubtotal.Prefijo = "$";
                    this.txtFuturosSubtotal.ReadOnly = true;
                    this.txtFuturosSubtotal.SelectOnFocus = true;
                    this.txtFuturosSubtotal.Size = new System.Drawing.Size(100, 24);
                    this.txtFuturosSubtotal.Sufijo = "";
                    this.txtFuturosSubtotal.TabIndex = 24;
                    this.txtFuturosSubtotal.Text = "0.00";
                    this.txtFuturosSubtotal.TextRaw = "0.00";
                    this.txtFuturosSubtotal.TipWhenBlank = "";
                    this.txtFuturosSubtotal.ToolTipText = "";
                    // 
                    // label9
                    // 
                    this.label9.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label9.Location = new System.Drawing.Point(404, 146);
                    this.label9.Name = "label9";
                    this.label9.Size = new System.Drawing.Size(232, 24);
                    this.label9.TabIndex = 23;
                    this.label9.Text = "Subtotal (futuros)";
                    this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label9.UseMnemonic = false;
                    // 
                    // txtPatrimonioActual
                    // 
                    this.txtPatrimonioActual.AutoHeight = false;
                    this.txtPatrimonioActual.AutoNav = true;
                    this.txtPatrimonioActual.AutoTab = true;
                    this.txtPatrimonioActual.DataType = Lui.Forms.DataTypes.Money;
                    this.txtPatrimonioActual.DecimalPlaces = -1;
                    this.txtPatrimonioActual.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtPatrimonioActual.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtPatrimonioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtPatrimonioActual.Location = new System.Drawing.Point(644, 266);
                    this.txtPatrimonioActual.MaxLenght = 32767;
                    this.txtPatrimonioActual.MultiLine = false;
                    this.txtPatrimonioActual.Name = "txtPatrimonioActual";
                    this.txtPatrimonioActual.Padding = new System.Windows.Forms.Padding(2);
                    this.txtPatrimonioActual.PasswordChar = '\0';
                    this.txtPatrimonioActual.Prefijo = "$";
                    this.txtPatrimonioActual.ReadOnly = true;
                    this.txtPatrimonioActual.SelectOnFocus = true;
                    this.txtPatrimonioActual.Size = new System.Drawing.Size(100, 24);
                    this.txtPatrimonioActual.Sufijo = "";
                    this.txtPatrimonioActual.TabIndex = 26;
                    this.txtPatrimonioActual.Text = "0.00";
                    this.txtPatrimonioActual.TextRaw = "0.00";
                    this.txtPatrimonioActual.TipWhenBlank = "";
                    this.txtPatrimonioActual.ToolTipText = "";
                    // 
                    // label10
                    // 
                    this.label10.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label10.Location = new System.Drawing.Point(408, 266);
                    this.label10.Name = "label10";
                    this.label10.Size = new System.Drawing.Size(232, 24);
                    this.label10.TabIndex = 25;
                    this.label10.Text = "Actual";
                    this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label10.UseMnemonic = false;
                    // 
                    // note4
                    // 
                    this.note4.AutoHeight = false;
                    this.note4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.note4.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.note4.Location = new System.Drawing.Point(392, 230);
                    this.note4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note4.Name = "note4";
                    this.note4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note4.ReadOnly = false;
                    this.note4.Size = new System.Drawing.Size(356, 36);
                    this.note4.TabIndex = 27;
                    this.note4.Text = "note4";
                    this.note4.Title = "Patrimonio";
                    this.note4.ToolTipText = "";
                    // 
                    // txtPatrimonioFuturo
                    // 
                    this.txtPatrimonioFuturo.AutoHeight = false;
                    this.txtPatrimonioFuturo.AutoNav = true;
                    this.txtPatrimonioFuturo.AutoTab = true;
                    this.txtPatrimonioFuturo.DataType = Lui.Forms.DataTypes.Money;
                    this.txtPatrimonioFuturo.DecimalPlaces = -1;
                    this.txtPatrimonioFuturo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtPatrimonioFuturo.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtPatrimonioFuturo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtPatrimonioFuturo.Location = new System.Drawing.Point(644, 294);
                    this.txtPatrimonioFuturo.MaxLenght = 32767;
                    this.txtPatrimonioFuturo.MultiLine = false;
                    this.txtPatrimonioFuturo.Name = "txtPatrimonioFuturo";
                    this.txtPatrimonioFuturo.Padding = new System.Windows.Forms.Padding(2);
                    this.txtPatrimonioFuturo.PasswordChar = '\0';
                    this.txtPatrimonioFuturo.Prefijo = "$";
                    this.txtPatrimonioFuturo.ReadOnly = true;
                    this.txtPatrimonioFuturo.SelectOnFocus = true;
                    this.txtPatrimonioFuturo.Size = new System.Drawing.Size(100, 24);
                    this.txtPatrimonioFuturo.Sufijo = "";
                    this.txtPatrimonioFuturo.TabIndex = 29;
                    this.txtPatrimonioFuturo.Text = "0.00";
                    this.txtPatrimonioFuturo.TextRaw = "0.00";
                    this.txtPatrimonioFuturo.TipWhenBlank = "";
                    this.txtPatrimonioFuturo.ToolTipText = "";
                    // 
                    // label11
                    // 
                    this.label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label11.Location = new System.Drawing.Point(408, 294);
                    this.label11.Name = "label11";
                    this.label11.Size = new System.Drawing.Size(232, 24);
                    this.label11.TabIndex = 28;
                    this.label11.Text = "Futuro";
                    this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label11.UseMnemonic = false;
                    // 
                    // txtActivosActualesFuturos
                    // 
                    this.txtActivosActualesFuturos.AutoHeight = false;
                    this.txtActivosActualesFuturos.AutoNav = true;
                    this.txtActivosActualesFuturos.AutoTab = true;
                    this.txtActivosActualesFuturos.DataType = Lui.Forms.DataTypes.Money;
                    this.txtActivosActualesFuturos.DecimalPlaces = -1;
                    this.txtActivosActualesFuturos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtActivosActualesFuturos.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtActivosActualesFuturos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtActivosActualesFuturos.Location = new System.Drawing.Point(640, 178);
                    this.txtActivosActualesFuturos.MaxLenght = 32767;
                    this.txtActivosActualesFuturos.MultiLine = false;
                    this.txtActivosActualesFuturos.Name = "txtActivosActualesFuturos";
                    this.txtActivosActualesFuturos.Padding = new System.Windows.Forms.Padding(2);
                    this.txtActivosActualesFuturos.PasswordChar = '\0';
                    this.txtActivosActualesFuturos.Prefijo = "$";
                    this.txtActivosActualesFuturos.ReadOnly = true;
                    this.txtActivosActualesFuturos.SelectOnFocus = true;
                    this.txtActivosActualesFuturos.Size = new System.Drawing.Size(100, 24);
                    this.txtActivosActualesFuturos.Sufijo = "";
                    this.txtActivosActualesFuturos.TabIndex = 33;
                    this.txtActivosActualesFuturos.Text = "0.00";
                    this.txtActivosActualesFuturos.TextRaw = "0.00";
                    this.txtActivosActualesFuturos.TipWhenBlank = "";
                    this.txtActivosActualesFuturos.ToolTipText = "";
                    // 
                    // label12
                    // 
                    this.label12.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label12.Location = new System.Drawing.Point(404, 178);
                    this.label12.Name = "label12";
                    this.label12.Size = new System.Drawing.Size(232, 24);
                    this.label12.TabIndex = 32;
                    this.label12.Text = "Subtotal (actuales y futuros)";
                    this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label12.UseMnemonic = false;
                    // 
                    // txtPasivosStock
                    // 
                    this.txtPasivosStock.AutoHeight = false;
                    this.txtPasivosStock.AutoNav = true;
                    this.txtPasivosStock.AutoTab = true;
                    this.txtPasivosStock.DataType = Lui.Forms.DataTypes.Money;
                    this.txtPasivosStock.DecimalPlaces = -1;
                    this.txtPasivosStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtPasivosStock.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtPasivosStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtPasivosStock.Location = new System.Drawing.Point(268, 232);
                    this.txtPasivosStock.MaxLenght = 32767;
                    this.txtPasivosStock.MultiLine = false;
                    this.txtPasivosStock.Name = "txtPasivosStock";
                    this.txtPasivosStock.Padding = new System.Windows.Forms.Padding(2);
                    this.txtPasivosStock.PasswordChar = '\0';
                    this.txtPasivosStock.Prefijo = "$";
                    this.txtPasivosStock.ReadOnly = true;
                    this.txtPasivosStock.SelectOnFocus = true;
                    this.txtPasivosStock.Size = new System.Drawing.Size(100, 24);
                    this.txtPasivosStock.Sufijo = "";
                    this.txtPasivosStock.TabIndex = 35;
                    this.txtPasivosStock.Text = "0.00";
                    this.txtPasivosStock.TextRaw = "0.00";
                    this.txtPasivosStock.TipWhenBlank = "";
                    this.txtPasivosStock.ToolTipText = "";
                    // 
                    // label13
                    // 
                    this.label13.Location = new System.Drawing.Point(32, 232);
                    this.label13.Name = "label13";
                    this.label13.Size = new System.Drawing.Size(232, 24);
                    this.label13.TabIndex = 34;
                    this.label13.Text = "Descubiertos en stock";
                    this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label13.UseMnemonic = false;
                    // 
                    // txtCC
                    // 
                    this.txtCC.AutoHeight = false;
                    this.txtCC.AutoNav = true;
                    this.txtCC.AutoTab = true;
                    this.txtCC.DataType = Lui.Forms.DataTypes.Money;
                    this.txtCC.DecimalPlaces = -1;
                    this.txtCC.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                    this.txtCC.ForceCase = Lui.Forms.TextCasing.None;
                    this.txtCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                    this.txtCC.Location = new System.Drawing.Point(640, 83);
                    this.txtCC.MaxLenght = 32767;
                    this.txtCC.MultiLine = false;
                    this.txtCC.Name = "txtCC";
                    this.txtCC.Padding = new System.Windows.Forms.Padding(2);
                    this.txtCC.PasswordChar = '\0';
                    this.txtCC.Prefijo = "$";
                    this.txtCC.ReadOnly = true;
                    this.txtCC.SelectOnFocus = true;
                    this.txtCC.Size = new System.Drawing.Size(100, 24);
                    this.txtCC.Sufijo = "";
                    this.txtCC.TabIndex = 37;
                    this.txtCC.Text = "0.00";
                    this.txtCC.TextRaw = "0.00";
                    this.txtCC.TipWhenBlank = "";
                    this.txtCC.ToolTipText = "";
                    this.txtCC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                    // 
                    // label14
                    // 
                    this.label14.Location = new System.Drawing.Point(404, 83);
                    this.label14.Name = "label14";
                    this.label14.Size = new System.Drawing.Size(232, 24);
                    this.label14.TabIndex = 36;
                    this.label14.Text = "Cuentas corrientes";
                    this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label14.UseMnemonic = false;
                    this.label14.Click += new System.EventHandler(this.label14_Click);
                    // 
                    // Patrimonio
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(757, 391);
                    this.Controls.Add(this.txtCC);
                    this.Controls.Add(this.label14);
                    this.Controls.Add(this.txtPasivosStock);
                    this.Controls.Add(this.label13);
                    this.Controls.Add(this.txtActivosActualesFuturos);
                    this.Controls.Add(this.label12);
                    this.Controls.Add(this.txtPatrimonioFuturo);
                    this.Controls.Add(this.label11);
                    this.Controls.Add(this.note4);
                    this.Controls.Add(this.txtPatrimonioActual);
                    this.Controls.Add(this.label10);
                    this.Controls.Add(this.txtFuturosSubtotal);
                    this.Controls.Add(this.label9);
                    this.Controls.Add(this.txtPasivosSubtotal);
                    this.Controls.Add(this.label6);
                    this.Controls.Add(this.txtActivosSubtotal);
                    this.Controls.Add(this.label5);
                    this.Controls.Add(this.note3);
                    this.Controls.Add(this.txtPasivosCheques);
                    this.Controls.Add(this.label7);
                    this.Controls.Add(this.txtPasivosCuentas);
                    this.Controls.Add(this.note2);
                    this.Controls.Add(this.label8);
                    this.Controls.Add(this.txtFuturosPedidos);
                    this.Controls.Add(this.label4);
                    this.Controls.Add(this.txtActivosStock);
                    this.Controls.Add(this.label3);
                    this.Controls.Add(this.txtFuturosTarjetas);
                    this.Controls.Add(this.label2);
                    this.Controls.Add(this.txtActivosCuentas);
                    this.Controls.Add(this.note1);
                    this.Controls.Add(this.label1);
                    this.Name = "Patrimonio";
                    this.Text = "Patrimonio";
                    this.WorkspaceChanged += new System.EventHandler(this.Patrimonio_WorkspaceChanged);
                    this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.Label label1;
                private Lui.Forms.Note note1;
                private Lui.Forms.TextBox txtActivosCuentas;
                private Lui.Forms.TextBox txtFuturosTarjetas;
                private System.Windows.Forms.Label label2;
                private Lui.Forms.TextBox txtActivosStock;
                private System.Windows.Forms.Label label3;
                private Lui.Forms.TextBox txtFuturosPedidos;
                private System.Windows.Forms.Label label4;
                private Lui.Forms.TextBox txtPasivosCheques;
                private System.Windows.Forms.Label label7;
                private Lui.Forms.TextBox txtPasivosCuentas;
                private Lui.Forms.Note note2;
                private System.Windows.Forms.Label label8;
                private Lui.Forms.Note note3;
                private Lui.Forms.TextBox txtActivosSubtotal;
                private System.Windows.Forms.Label label5;
                private Lui.Forms.TextBox txtPasivosSubtotal;
                private System.Windows.Forms.Label label6;
                private Lui.Forms.TextBox txtFuturosSubtotal;
                private System.Windows.Forms.Label label9;
                private Lui.Forms.TextBox txtPatrimonioActual;
                private System.Windows.Forms.Label label10;
                private Lui.Forms.Note note4;
                private Lui.Forms.TextBox txtPatrimonioFuturo;
                private System.Windows.Forms.Label label11;
                private Lui.Forms.TextBox txtActivosActualesFuturos;
                private System.Windows.Forms.Label label12;
                private Lui.Forms.TextBox txtPasivosStock;
                private System.Windows.Forms.Label label13;
                private Lui.Forms.TextBox txtCC;
                private System.Windows.Forms.Label label14;
        }
}