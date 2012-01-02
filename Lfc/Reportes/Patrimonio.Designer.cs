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

namespace Lfc.Reportes
{
        public partial class Patrimonio
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
                    this.label1 = new Lui.Forms.Label();
                    this.note1 = new Lui.Forms.Note();
                    this.EntradaActivosCajas = new Lui.Forms.TextBox();
                    this.EntradaFuturosTarjetas = new Lui.Forms.TextBox();
                    this.label2 = new Lui.Forms.Label();
                    this.EntradaActivosStock = new Lui.Forms.TextBox();
                    this.label3 = new Lui.Forms.Label();
                    this.EntradaFuturosPedidos = new Lui.Forms.TextBox();
                    this.label4 = new Lui.Forms.Label();
                    this.EntradaPasivosCheques = new Lui.Forms.TextBox();
                    this.label7 = new Lui.Forms.Label();
                    this.EntradaPasivosCajas = new Lui.Forms.TextBox();
                    this.note2 = new Lui.Forms.Note();
                    this.label8 = new Lui.Forms.Label();
                    this.note3 = new Lui.Forms.Note();
                    this.EntradaActivosSubtotal = new Lui.Forms.TextBox();
                    this.label5 = new Lui.Forms.Label();
                    this.EntradaPasivosSubtotal = new Lui.Forms.TextBox();
                    this.label6 = new Lui.Forms.Label();
                    this.EntradaFuturosSubtotal = new Lui.Forms.TextBox();
                    this.label9 = new Lui.Forms.Label();
                    this.EntradaPatrimonioActual = new Lui.Forms.TextBox();
                    this.label10 = new Lui.Forms.Label();
                    this.note4 = new Lui.Forms.Note();
                    this.EntradaPatrimonioFuturo = new Lui.Forms.TextBox();
                    this.label11 = new Lui.Forms.Label();
                    this.EntradaActivosActualesFuturos = new Lui.Forms.TextBox();
                    this.label12 = new Lui.Forms.Label();
                    this.EntradaPasivosStock = new Lui.Forms.TextBox();
                    this.label13 = new Lui.Forms.Label();
                    this.EntradaCC = new Lui.Forms.TextBox();
                    this.label14 = new Lui.Forms.Label();
                    this.SuspendLayout();
                    // 
                    // label1
                    // 
                    this.label1.Location = new System.Drawing.Point(32, 52);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(232, 24);
                    this.label1.TabIndex = 0;
                    this.label1.Text = "Dinero en cajas";
                    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label1.UseMnemonic = false;
                    // 
                    // note1
                    // 
                    this.note1.AutoSize = false;
                    this.note1.Location = new System.Drawing.Point(16, 16);
                    this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note1.Name = "note1";
                    this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note1.TemporaryReadOnly = false;
                    this.note1.Size = new System.Drawing.Size(356, 36);
                    this.note1.TabIndex = 1;
                    this.note1.Text = "note1";
                    this.note1.Title = "Activos";
                    // 
                    // EntradaActivosCajas
                    // 
                    this.EntradaActivosCajas.AutoSize = false;
                    this.EntradaActivosCajas.AutoNav = true;
                    this.EntradaActivosCajas.AutoTab = true;
                    this.EntradaActivosCajas.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaActivosCajas.DecimalPlaces = -1;
                    this.EntradaActivosCajas.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaActivosCajas.Location = new System.Drawing.Point(268, 52);
                    this.EntradaActivosCajas.MultiLine = false;
                    this.EntradaActivosCajas.Name = "EntradaActivosCajas";
                    this.EntradaActivosCajas.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaActivosCajas.Prefijo = "$";
                    this.EntradaActivosCajas.TemporaryReadOnly = true;
                    this.EntradaActivosCajas.SelectOnFocus = true;
                    this.EntradaActivosCajas.Size = new System.Drawing.Size(100, 24);
                    this.EntradaActivosCajas.TabIndex = 2;
                    this.EntradaActivosCajas.Text = "0.00";
                    // 
                    // txtFuturosTarjetas
                    // 
                    this.EntradaFuturosTarjetas.AutoSize = false;
                    this.EntradaFuturosTarjetas.AutoNav = true;
                    this.EntradaFuturosTarjetas.AutoTab = true;
                    this.EntradaFuturosTarjetas.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaFuturosTarjetas.DecimalPlaces = -1;
                    this.EntradaFuturosTarjetas.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaFuturosTarjetas.Location = new System.Drawing.Point(640, 52);
                    this.EntradaFuturosTarjetas.MultiLine = false;
                    this.EntradaFuturosTarjetas.Name = "txtFuturosTarjetas";
                    this.EntradaFuturosTarjetas.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaFuturosTarjetas.Prefijo = "$";
                    this.EntradaFuturosTarjetas.TemporaryReadOnly = true;
                    this.EntradaFuturosTarjetas.SelectOnFocus = true;
                    this.EntradaFuturosTarjetas.Size = new System.Drawing.Size(100, 24);
                    this.EntradaFuturosTarjetas.TabIndex = 4;
                    this.EntradaFuturosTarjetas.Text = "0.00";
                    // 
                    // label2
                    // 
                    this.label2.Location = new System.Drawing.Point(404, 52);
                    this.label2.Name = "label2";
                    this.label2.Size = new System.Drawing.Size(232, 24);
                    this.label2.TabIndex = 3;
                    this.label2.Text = "Presentaciones de cupones";
                    this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label2.UseMnemonic = false;
                    // 
                    // txtActivosStock
                    // 
                    this.EntradaActivosStock.AutoSize = false;
                    this.EntradaActivosStock.AutoNav = true;
                    this.EntradaActivosStock.AutoTab = true;
                    this.EntradaActivosStock.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaActivosStock.DecimalPlaces = -1;
                    this.EntradaActivosStock.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaActivosStock.Location = new System.Drawing.Point(268, 80);
                    this.EntradaActivosStock.MultiLine = false;
                    this.EntradaActivosStock.Name = "txtActivosStock";
                    this.EntradaActivosStock.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaActivosStock.Prefijo = "$";
                    this.EntradaActivosStock.TemporaryReadOnly = true;
                    this.EntradaActivosStock.SelectOnFocus = true;
                    this.EntradaActivosStock.Size = new System.Drawing.Size(100, 24);
                    this.EntradaActivosStock.TabIndex = 6;
                    this.EntradaActivosStock.Text = "0.00";
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
                    this.EntradaFuturosPedidos.AutoSize = false;
                    this.EntradaFuturosPedidos.AutoNav = true;
                    this.EntradaFuturosPedidos.AutoTab = true;
                    this.EntradaFuturosPedidos.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaFuturosPedidos.DecimalPlaces = -1;
                    this.EntradaFuturosPedidos.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaFuturosPedidos.Location = new System.Drawing.Point(640, 114);
                    this.EntradaFuturosPedidos.MultiLine = false;
                    this.EntradaFuturosPedidos.Name = "txtFuturosPedidos";
                    this.EntradaFuturosPedidos.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaFuturosPedidos.Prefijo = "$";
                    this.EntradaFuturosPedidos.TemporaryReadOnly = true;
                    this.EntradaFuturosPedidos.SelectOnFocus = true;
                    this.EntradaFuturosPedidos.Size = new System.Drawing.Size(100, 24);
                    this.EntradaFuturosPedidos.TabIndex = 8;
                    this.EntradaFuturosPedidos.Text = "0.00";
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
                    this.EntradaPasivosCheques.AutoSize = false;
                    this.EntradaPasivosCheques.AutoNav = true;
                    this.EntradaPasivosCheques.AutoTab = true;
                    this.EntradaPasivosCheques.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaPasivosCheques.DecimalPlaces = -1;
                    this.EntradaPasivosCheques.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaPasivosCheques.Location = new System.Drawing.Point(268, 260);
                    this.EntradaPasivosCheques.MultiLine = false;
                    this.EntradaPasivosCheques.Name = "txtPasivosCheques";
                    this.EntradaPasivosCheques.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaPasivosCheques.Prefijo = "$";
                    this.EntradaPasivosCheques.TemporaryReadOnly = true;
                    this.EntradaPasivosCheques.SelectOnFocus = true;
                    this.EntradaPasivosCheques.Size = new System.Drawing.Size(100, 24);
                    this.EntradaPasivosCheques.TabIndex = 13;
                    this.EntradaPasivosCheques.Text = "0.00";
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
                    // EntradaPasivosCajas
                    // 
                    this.EntradaPasivosCajas.AutoSize = false;
                    this.EntradaPasivosCajas.AutoNav = true;
                    this.EntradaPasivosCajas.AutoTab = true;
                    this.EntradaPasivosCajas.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaPasivosCajas.DecimalPlaces = -1;
                    this.EntradaPasivosCajas.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaPasivosCajas.Location = new System.Drawing.Point(268, 204);
                    this.EntradaPasivosCajas.MultiLine = false;
                    this.EntradaPasivosCajas.Name = "EntradaPasivosCajas";
                    this.EntradaPasivosCajas.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaPasivosCajas.Prefijo = "$";
                    this.EntradaPasivosCajas.TemporaryReadOnly = true;
                    this.EntradaPasivosCajas.SelectOnFocus = true;
                    this.EntradaPasivosCajas.Size = new System.Drawing.Size(100, 24);
                    this.EntradaPasivosCajas.TabIndex = 11;
                    this.EntradaPasivosCajas.Text = "0.00";
                    // 
                    // note2
                    // 
                    this.note2.AutoSize = false;
                    this.note2.Location = new System.Drawing.Point(16, 168);
                    this.note2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note2.Name = "note2";
                    this.note2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note2.TemporaryReadOnly = false;
                    this.note2.Size = new System.Drawing.Size(356, 36);
                    this.note2.TabIndex = 10;
                    this.note2.Text = "note2";
                    this.note2.Title = "Pasivos";
                    // 
                    // label8
                    // 
                    this.label8.Location = new System.Drawing.Point(32, 204);
                    this.label8.Name = "label8";
                    this.label8.Size = new System.Drawing.Size(232, 24);
                    this.label8.TabIndex = 9;
                    this.label8.Text = "Descubiertos en cajas";
                    this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.label8.UseMnemonic = false;
                    // 
                    // note3
                    // 
                    this.note3.AutoSize = false;
                    this.note3.Location = new System.Drawing.Point(388, 16);
                    this.note3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note3.Name = "note3";
                    this.note3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note3.TemporaryReadOnly = false;
                    this.note3.Size = new System.Drawing.Size(356, 36);
                    this.note3.TabIndex = 18;
                    this.note3.Text = "note3";
                    this.note3.Title = "Futuros";
                    // 
                    // txtActivosSubtotal
                    // 
                    this.EntradaActivosSubtotal.AutoSize = false;
                    this.EntradaActivosSubtotal.AutoNav = true;
                    this.EntradaActivosSubtotal.AutoTab = true;
                    this.EntradaActivosSubtotal.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaActivosSubtotal.DecimalPlaces = -1;
                    this.EntradaActivosSubtotal.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaActivosSubtotal.Location = new System.Drawing.Point(268, 112);
                    this.EntradaActivosSubtotal.MultiLine = false;
                    this.EntradaActivosSubtotal.Name = "txtActivosSubtotal";
                    this.EntradaActivosSubtotal.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaActivosSubtotal.Prefijo = "$";
                    this.EntradaActivosSubtotal.TemporaryReadOnly = true;
                    this.EntradaActivosSubtotal.SelectOnFocus = true;
                    this.EntradaActivosSubtotal.Size = new System.Drawing.Size(100, 24);
                    this.EntradaActivosSubtotal.TabIndex = 20;
                    this.EntradaActivosSubtotal.Text = "0.00";
                    // 
                    // label5
                    // 
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
                    this.EntradaPasivosSubtotal.AutoSize = false;
                    this.EntradaPasivosSubtotal.AutoNav = true;
                    this.EntradaPasivosSubtotal.AutoTab = true;
                    this.EntradaPasivosSubtotal.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaPasivosSubtotal.DecimalPlaces = -1;
                    this.EntradaPasivosSubtotal.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaPasivosSubtotal.Location = new System.Drawing.Point(268, 292);
                    this.EntradaPasivosSubtotal.MultiLine = false;
                    this.EntradaPasivosSubtotal.Name = "txtPasivosSubtotal";
                    this.EntradaPasivosSubtotal.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaPasivosSubtotal.Prefijo = "$";
                    this.EntradaPasivosSubtotal.TemporaryReadOnly = true;
                    this.EntradaPasivosSubtotal.SelectOnFocus = true;
                    this.EntradaPasivosSubtotal.Size = new System.Drawing.Size(100, 24);
                    this.EntradaPasivosSubtotal.TabIndex = 22;
                    this.EntradaPasivosSubtotal.Text = "0.00";
                    // 
                    // label6
                    // 
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
                    this.EntradaFuturosSubtotal.AutoSize = false;
                    this.EntradaFuturosSubtotal.AutoNav = true;
                    this.EntradaFuturosSubtotal.AutoTab = true;
                    this.EntradaFuturosSubtotal.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaFuturosSubtotal.DecimalPlaces = -1;
                    this.EntradaFuturosSubtotal.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaFuturosSubtotal.Location = new System.Drawing.Point(640, 146);
                    this.EntradaFuturosSubtotal.MultiLine = false;
                    this.EntradaFuturosSubtotal.Name = "txtFuturosSubtotal";
                    this.EntradaFuturosSubtotal.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaFuturosSubtotal.Prefijo = "$";
                    this.EntradaFuturosSubtotal.TemporaryReadOnly = true;
                    this.EntradaFuturosSubtotal.SelectOnFocus = true;
                    this.EntradaFuturosSubtotal.Size = new System.Drawing.Size(100, 24);
                    this.EntradaFuturosSubtotal.TabIndex = 24;
                    this.EntradaFuturosSubtotal.Text = "0.00";
                    // 
                    // label9
                    // 
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
                    this.EntradaPatrimonioActual.AutoSize = false;
                    this.EntradaPatrimonioActual.AutoNav = true;
                    this.EntradaPatrimonioActual.AutoTab = true;
                    this.EntradaPatrimonioActual.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaPatrimonioActual.DecimalPlaces = -1;
                    this.EntradaPatrimonioActual.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaPatrimonioActual.Location = new System.Drawing.Point(644, 266);
                    this.EntradaPatrimonioActual.MultiLine = false;
                    this.EntradaPatrimonioActual.Name = "txtPatrimonioActual";
                    this.EntradaPatrimonioActual.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaPatrimonioActual.Prefijo = "$";
                    this.EntradaPatrimonioActual.TemporaryReadOnly = true;
                    this.EntradaPatrimonioActual.SelectOnFocus = true;
                    this.EntradaPatrimonioActual.Size = new System.Drawing.Size(100, 24);
                    this.EntradaPatrimonioActual.TabIndex = 26;
                    this.EntradaPatrimonioActual.Text = "0.00";
                    // 
                    // label10
                    // 
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
                    this.note4.AutoSize = false;
                    this.note4.Location = new System.Drawing.Point(392, 230);
                    this.note4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    this.note4.Name = "note4";
                    this.note4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.note4.TemporaryReadOnly = false;
                    this.note4.Size = new System.Drawing.Size(356, 36);
                    this.note4.TabIndex = 27;
                    this.note4.Text = "note4";
                    this.note4.Title = "Patrimonio";
                    // 
                    // txtPatrimonioFuturo
                    // 
                    this.EntradaPatrimonioFuturo.AutoSize = false;
                    this.EntradaPatrimonioFuturo.AutoNav = true;
                    this.EntradaPatrimonioFuturo.AutoTab = true;
                    this.EntradaPatrimonioFuturo.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaPatrimonioFuturo.DecimalPlaces = -1;
                    this.EntradaPatrimonioFuturo.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaPatrimonioFuturo.Location = new System.Drawing.Point(644, 294);
                    this.EntradaPatrimonioFuturo.MultiLine = false;
                    this.EntradaPatrimonioFuturo.Name = "txtPatrimonioFuturo";
                    this.EntradaPatrimonioFuturo.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaPatrimonioFuturo.Prefijo = "$";
                    this.EntradaPatrimonioFuturo.TemporaryReadOnly = true;
                    this.EntradaPatrimonioFuturo.SelectOnFocus = true;
                    this.EntradaPatrimonioFuturo.Size = new System.Drawing.Size(100, 24);
                    this.EntradaPatrimonioFuturo.TabIndex = 29;
                    this.EntradaPatrimonioFuturo.Text = "0.00";
                    // 
                    // label11
                    // 
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
                    this.EntradaActivosActualesFuturos.AutoSize = false;
                    this.EntradaActivosActualesFuturos.AutoNav = true;
                    this.EntradaActivosActualesFuturos.AutoTab = true;
                    this.EntradaActivosActualesFuturos.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaActivosActualesFuturos.DecimalPlaces = -1;
                    this.EntradaActivosActualesFuturos.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaActivosActualesFuturos.Location = new System.Drawing.Point(640, 178);
                    this.EntradaActivosActualesFuturos.MultiLine = false;
                    this.EntradaActivosActualesFuturos.Name = "txtActivosActualesFuturos";
                    this.EntradaActivosActualesFuturos.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaActivosActualesFuturos.Prefijo = "$";
                    this.EntradaActivosActualesFuturos.TemporaryReadOnly = true;
                    this.EntradaActivosActualesFuturos.SelectOnFocus = true;
                    this.EntradaActivosActualesFuturos.Size = new System.Drawing.Size(100, 24);
                    this.EntradaActivosActualesFuturos.TabIndex = 33;
                    this.EntradaActivosActualesFuturos.Text = "0.00";
                    // 
                    // label12
                    // 
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
                    this.EntradaPasivosStock.AutoSize = false;
                    this.EntradaPasivosStock.AutoNav = true;
                    this.EntradaPasivosStock.AutoTab = true;
                    this.EntradaPasivosStock.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaPasivosStock.DecimalPlaces = -1;
                    this.EntradaPasivosStock.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaPasivosStock.Location = new System.Drawing.Point(268, 232);
                    this.EntradaPasivosStock.MultiLine = false;
                    this.EntradaPasivosStock.Name = "txtPasivosStock";
                    this.EntradaPasivosStock.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaPasivosStock.Prefijo = "$";
                    this.EntradaPasivosStock.TemporaryReadOnly = true;
                    this.EntradaPasivosStock.SelectOnFocus = true;
                    this.EntradaPasivosStock.Size = new System.Drawing.Size(100, 24);
                    this.EntradaPasivosStock.TabIndex = 35;
                    this.EntradaPasivosStock.Text = "0.00";
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
                    this.EntradaCC.AutoSize = false;
                    this.EntradaCC.AutoNav = true;
                    this.EntradaCC.AutoTab = true;
                    this.EntradaCC.DataType = Lui.Forms.DataTypes.Currency;
                    this.EntradaCC.DecimalPlaces = -1;
                    this.EntradaCC.ForceCase = Lui.Forms.TextCasing.None;
                    this.EntradaCC.Location = new System.Drawing.Point(640, 83);
                    this.EntradaCC.MultiLine = false;
                    this.EntradaCC.Name = "txtCC";
                    this.EntradaCC.Padding = new System.Windows.Forms.Padding(2);
                    this.EntradaCC.Prefijo = "$";
                    this.EntradaCC.TemporaryReadOnly = true;
                    this.EntradaCC.SelectOnFocus = true;
                    this.EntradaCC.Size = new System.Drawing.Size(100, 24);
                    this.EntradaCC.TabIndex = 37;
                    this.EntradaCC.Text = "0.00";
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
                    // 
                    // Patrimonio
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(757, 391);
                    this.Controls.Add(this.EntradaCC);
                    this.Controls.Add(this.label14);
                    this.Controls.Add(this.EntradaPasivosStock);
                    this.Controls.Add(this.label13);
                    this.Controls.Add(this.EntradaActivosActualesFuturos);
                    this.Controls.Add(this.label12);
                    this.Controls.Add(this.EntradaPatrimonioFuturo);
                    this.Controls.Add(this.label11);
                    this.Controls.Add(this.note4);
                    this.Controls.Add(this.EntradaPatrimonioActual);
                    this.Controls.Add(this.label10);
                    this.Controls.Add(this.EntradaFuturosSubtotal);
                    this.Controls.Add(this.label9);
                    this.Controls.Add(this.EntradaPasivosSubtotal);
                    this.Controls.Add(this.label6);
                    this.Controls.Add(this.EntradaActivosSubtotal);
                    this.Controls.Add(this.label5);
                    this.Controls.Add(this.note3);
                    this.Controls.Add(this.EntradaPasivosCheques);
                    this.Controls.Add(this.label7);
                    this.Controls.Add(this.EntradaPasivosCajas);
                    this.Controls.Add(this.note2);
                    this.Controls.Add(this.label8);
                    this.Controls.Add(this.EntradaFuturosPedidos);
                    this.Controls.Add(this.label4);
                    this.Controls.Add(this.EntradaActivosStock);
                    this.Controls.Add(this.label3);
                    this.Controls.Add(this.EntradaFuturosTarjetas);
                    this.Controls.Add(this.label2);
                    this.Controls.Add(this.EntradaActivosCajas);
                    this.Controls.Add(this.note1);
                    this.Controls.Add(this.label1);
                    this.Name = "Patrimonio";
                    this.Text = "Patrimonio";
                    this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.Label label1;
                private Lui.Forms.Note note1;
                private Lui.Forms.TextBox EntradaActivosCajas;
                private Lui.Forms.TextBox EntradaFuturosTarjetas;
                private Lui.Forms.Label label2;
                private Lui.Forms.TextBox EntradaActivosStock;
                private Lui.Forms.Label label3;
                private Lui.Forms.TextBox EntradaFuturosPedidos;
                private Lui.Forms.Label label4;
                private Lui.Forms.TextBox EntradaPasivosCheques;
                private Lui.Forms.Label label7;
                private Lui.Forms.TextBox EntradaPasivosCajas;
                private Lui.Forms.Note note2;
                private Lui.Forms.Label label8;
                private Lui.Forms.Note note3;
                private Lui.Forms.TextBox EntradaActivosSubtotal;
                private Lui.Forms.Label label5;
                private Lui.Forms.TextBox EntradaPasivosSubtotal;
                private Lui.Forms.Label label6;
                private Lui.Forms.TextBox EntradaFuturosSubtotal;
                private Lui.Forms.Label label9;
                private Lui.Forms.TextBox EntradaPatrimonioActual;
                private Lui.Forms.Label label10;
                private Lui.Forms.Note note4;
                private Lui.Forms.TextBox EntradaPatrimonioFuturo;
                private Lui.Forms.Label label11;
                private Lui.Forms.TextBox EntradaActivosActualesFuturos;
                private Lui.Forms.Label label12;
                private Lui.Forms.TextBox EntradaPasivosStock;
                private Lui.Forms.Label label13;
                private Lui.Forms.TextBox EntradaCC;
                private Lui.Forms.Label label14;
        }
}
