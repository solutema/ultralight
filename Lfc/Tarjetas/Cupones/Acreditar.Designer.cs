#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Lfc.Cupones.Cupones
{
        public partial class Acreditar
        {
                private System.ComponentModel.IContainer components = null;

                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label lblLabel1;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.Frame Frame1;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox txtCupones;
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal Lui.Forms.TextBox EntradaComisionTarjeta;
                internal Lui.Forms.TextBox EntradaComisionPlan;
                internal Lui.Forms.TextBox EntradaComisionUsuario;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.ComboBox txtFormaPago;
                internal Label lblComisionUsuarioPct;
                internal Label lblComisionPlanPct;
                internal Label lblComisionTarjetaPct;
                internal Lui.Forms.TextBox EntradaTotal;

                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        this.txtFormaPago = new Lui.Forms.ComboBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.txtCupones = new Lui.Forms.TextBox();
                        this.lblLabel1 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.EntradaComisionTarjeta = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.EntradaComisionPlan = new Lui.Forms.TextBox();
                        this.EntradaComisionUsuario = new Lui.Forms.TextBox();
                        this.lblComisionTarjetaPct = new System.Windows.Forms.Label();
                        this.lblComisionUsuarioPct = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.lblComisionPlanPct = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Frame1.SuspendLayout();
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
                        // txtFormaPago
                        // 
                        this.txtFormaPago.AutoNav = true;
                        this.txtFormaPago.AutoTab = true;
                        this.txtFormaPago.DetailField = null;
                        this.txtFormaPago.Filter = null;
                        this.txtFormaPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFormaPago.KeyField = null;
                        this.txtFormaPago.Location = new System.Drawing.Point(188, 256);
                        this.txtFormaPago.MaxLenght = 32767;
                        this.txtFormaPago.Name = "txtFormaPago";
                        this.txtFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFormaPago.SetData = new string[] {
        "Efectivo|1",
        "Cheque|2",
        "Depósito en Cuenta|6"};
                        this.txtFormaPago.Size = new System.Drawing.Size(200, 24);
                        this.txtFormaPago.TabIndex = 17;
                        this.txtFormaPago.Table = null;
                        this.txtFormaPago.TextKey = "6";
                        this.txtFormaPago.TipWhenBlank = "";
                        this.txtFormaPago.ToolTipText = "";
                        // 
                        // Label11
                        // 
                        this.Label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label11.Location = new System.Drawing.Point(56, 256);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(132, 24);
                        this.Label11.TabIndex = 16;
                        this.Label11.Text = "Pago";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCupones
                        // 
                        this.txtCupones.AutoNav = true;
                        this.txtCupones.AutoTab = true;
                        this.txtCupones.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCupones.DecimalPlaces = -1;
                        this.txtCupones.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCupones.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCupones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCupones.Location = new System.Drawing.Point(132, 20);
                        this.txtCupones.MaxLenght = 32767;
                        this.txtCupones.MultiLine = false;
                        this.txtCupones.Name = "txtCupones";
                        this.txtCupones.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCupones.PasswordChar = '\0';
                        this.txtCupones.Prefijo = "";
                        this.txtCupones.SelectOnFocus = true;
                        this.txtCupones.Size = new System.Drawing.Size(56, 24);
                        this.txtCupones.Sufijo = "";
                        this.txtCupones.TabIndex = 1;
                        this.txtCupones.TabStop = false;
                        this.txtCupones.Text = "0";
                        this.txtCupones.TipWhenBlank = "";
                        this.txtCupones.ToolTipText = "";
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblLabel1.Location = new System.Drawing.Point(20, 20);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(112, 24);
                        this.lblLabel1.TabIndex = 0;
                        this.lblLabel1.Text = "Acreditación de";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(192, 20);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(168, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "cupones por un total de";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSubTotal
                        // 
                        this.EntradaSubTotal.AutoNav = true;
                        this.EntradaSubTotal.AutoTab = true;
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.DecimalPlaces = -1;
                        this.EntradaSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaSubTotal.Location = new System.Drawing.Point(360, 20);
                        this.EntradaSubTotal.MaxLenght = 32767;
                        this.EntradaSubTotal.MultiLine = false;
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubTotal.PasswordChar = '\0';
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.SelectOnFocus = true;
                        this.EntradaSubTotal.Size = new System.Drawing.Size(100, 24);
                        this.EntradaSubTotal.Sufijo = "";
                        this.EntradaSubTotal.TabIndex = 3;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        this.EntradaSubTotal.TipWhenBlank = "";
                        this.EntradaSubTotal.ToolTipText = "";
                        // 
                        // EntradaComisionTarjeta
                        // 
                        this.EntradaComisionTarjeta.AutoNav = true;
                        this.EntradaComisionTarjeta.AutoTab = true;
                        this.EntradaComisionTarjeta.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaComisionTarjeta.DecimalPlaces = -1;
                        this.EntradaComisionTarjeta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaComisionTarjeta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComisionTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaComisionTarjeta.Location = new System.Drawing.Point(116, 36);
                        this.EntradaComisionTarjeta.MaxLenght = 32767;
                        this.EntradaComisionTarjeta.MultiLine = false;
                        this.EntradaComisionTarjeta.Name = "EntradaComisionTarjeta";
                        this.EntradaComisionTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComisionTarjeta.PasswordChar = '\0';
                        this.EntradaComisionTarjeta.Prefijo = "$";
                        this.EntradaComisionTarjeta.SelectOnFocus = true;
                        this.EntradaComisionTarjeta.Size = new System.Drawing.Size(108, 24);
                        this.EntradaComisionTarjeta.Sufijo = "";
                        this.EntradaComisionTarjeta.TabIndex = 6;
                        this.EntradaComisionTarjeta.TabStop = false;
                        this.EntradaComisionTarjeta.Text = "0.00";
                        this.EntradaComisionTarjeta.TipWhenBlank = "";
                        this.EntradaComisionTarjeta.ToolTipText = "";
                        this.EntradaComisionTarjeta.TextChanged += new System.EventHandler(this.EntradaComisionTarjeta_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(8, 36);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(112, 24);
                        this.Label2.TabIndex = 5;
                        this.Label2.Text = "De las Tarjetas";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame1
                        // 
                        this.Frame1.Controls.Add(this.EntradaComisionTarjeta);
                        this.Frame1.Controls.Add(this.EntradaComisionPlan);
                        this.Frame1.Controls.Add(this.EntradaComisionUsuario);
                        this.Frame1.Controls.Add(this.lblComisionTarjetaPct);
                        this.Frame1.Controls.Add(this.lblComisionUsuarioPct);
                        this.Frame1.Controls.Add(this.Label4);
                        this.Frame1.Controls.Add(this.lblComisionPlanPct);
                        this.Frame1.Controls.Add(this.Label3);
                        this.Frame1.Controls.Add(this.Label2);
                        this.Frame1.Controls.Add(this.Label5);
                        this.Frame1.Controls.Add(this.Label7);
                        this.Frame1.Controls.Add(this.Label6);
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame1.Location = new System.Drawing.Point(12, 56);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.Size = new System.Drawing.Size(608, 136);
                        this.Frame1.TabIndex = 4;
                        this.Frame1.TabStop = false;
                        this.Frame1.Text = "Comisiones y Otros Decuentos";
                        this.Frame1.ToolTipText = "";
                        // 
                        // EntradaComisionPlan
                        // 
                        this.EntradaComisionPlan.AutoNav = true;
                        this.EntradaComisionPlan.AutoTab = true;
                        this.EntradaComisionPlan.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaComisionPlan.DecimalPlaces = -1;
                        this.EntradaComisionPlan.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaComisionPlan.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComisionPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaComisionPlan.Location = new System.Drawing.Point(116, 68);
                        this.EntradaComisionPlan.MaxLenght = 32767;
                        this.EntradaComisionPlan.MultiLine = false;
                        this.EntradaComisionPlan.Name = "EntradaComisionPlan";
                        this.EntradaComisionPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComisionPlan.PasswordChar = '\0';
                        this.EntradaComisionPlan.Prefijo = "$";
                        this.EntradaComisionPlan.SelectOnFocus = true;
                        this.EntradaComisionPlan.Size = new System.Drawing.Size(108, 24);
                        this.EntradaComisionPlan.Sufijo = "";
                        this.EntradaComisionPlan.TabIndex = 9;
                        this.EntradaComisionPlan.TabStop = false;
                        this.EntradaComisionPlan.Text = "0.00";
                        this.EntradaComisionPlan.TipWhenBlank = "";
                        this.EntradaComisionPlan.ToolTipText = "";
                        this.EntradaComisionPlan.TextChanged += new System.EventHandler(this.EntradaComisionPlan_TextChanged);
                        // 
                        // EntradaComisionUsuario
                        // 
                        this.EntradaComisionUsuario.AutoNav = true;
                        this.EntradaComisionUsuario.AutoTab = true;
                        this.EntradaComisionUsuario.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaComisionUsuario.DecimalPlaces = -1;
                        this.EntradaComisionUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaComisionUsuario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComisionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaComisionUsuario.Location = new System.Drawing.Point(116, 100);
                        this.EntradaComisionUsuario.MaxLenght = 32767;
                        this.EntradaComisionUsuario.MultiLine = false;
                        this.EntradaComisionUsuario.Name = "EntradaComisionUsuario";
                        this.EntradaComisionUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComisionUsuario.PasswordChar = '\0';
                        this.EntradaComisionUsuario.Prefijo = "$";
                        this.EntradaComisionUsuario.SelectOnFocus = true;
                        this.EntradaComisionUsuario.Size = new System.Drawing.Size(108, 24);
                        this.EntradaComisionUsuario.Sufijo = "";
                        this.EntradaComisionUsuario.TabIndex = 12;
                        this.EntradaComisionUsuario.Text = "0.00";
                        this.EntradaComisionUsuario.TipWhenBlank = "";
                        this.EntradaComisionUsuario.ToolTipText = "";
                        this.EntradaComisionUsuario.TextChanged += new System.EventHandler(this.EntradaComisionUsuario_TextChanged);
                        // 
                        // lblComisionTarjetaPct
                        // 
                        this.lblComisionTarjetaPct.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblComisionTarjetaPct.Location = new System.Drawing.Point(228, 36);
                        this.lblComisionTarjetaPct.Name = "lblComisionTarjetaPct";
                        this.lblComisionTarjetaPct.Size = new System.Drawing.Size(76, 24);
                        this.lblComisionTarjetaPct.TabIndex = 8;
                        this.lblComisionTarjetaPct.Text = "(0%)";
                        this.lblComisionTarjetaPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblComisionUsuarioPct
                        // 
                        this.lblComisionUsuarioPct.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblComisionUsuarioPct.Location = new System.Drawing.Point(228, 100);
                        this.lblComisionUsuarioPct.Name = "lblComisionUsuarioPct";
                        this.lblComisionUsuarioPct.Size = new System.Drawing.Size(76, 24);
                        this.lblComisionUsuarioPct.TabIndex = 10;
                        this.lblComisionUsuarioPct.Text = "(0%)";
                        this.lblComisionUsuarioPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(8, 100);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(112, 24);
                        this.Label4.TabIndex = 11;
                        this.Label4.Text = "Otros";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblComisionPlanPct
                        // 
                        this.lblComisionPlanPct.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblComisionPlanPct.Location = new System.Drawing.Point(228, 68);
                        this.lblComisionPlanPct.Name = "lblComisionPlanPct";
                        this.lblComisionPlanPct.Size = new System.Drawing.Size(76, 24);
                        this.lblComisionPlanPct.TabIndex = 9;
                        this.lblComisionPlanPct.Text = "(0%)";
                        this.lblComisionPlanPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(8, 68);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(112, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "De los Planes";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label5.Location = new System.Drawing.Point(324, 36);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(276, 24);
                        this.Label5.TabIndex = 7;
                        this.Label5.Text = "(Comisiones normales de las tarjetas)";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label7.Location = new System.Drawing.Point(324, 100);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(276, 24);
                        this.Label7.TabIndex = 13;
                        this.Label7.Text = "(Otros descuentos no contemplados)";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(324, 68);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(276, 24);
                        this.Label6.TabIndex = 10;
                        this.Label6.Text = "(Comisiones adicionales de algunos planes)";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(188, 220);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(136, 28);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 15;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        this.EntradaTotal.TextChanged += new System.EventHandler(this.EntradaTotal_TextChanged);
                        // 
                        // Label8
                        // 
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(56, 220);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(132, 28);
                        this.Label8.TabIndex = 14;
                        this.Label8.Text = "Total a Acreditar";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Acreditar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.EntradaSubTotal);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtCupones);
                        this.Controls.Add(this.lblLabel1);
                        this.Controls.Add(this.txtFormaPago);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.Frame1);
                        this.Name = "Acreditar";
                        this.Text = "Tarjetas de Crédito y Débito: Acreditación";
                        this.Controls.SetChildIndex(this.Frame1, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.txtFormaPago, 0);
                        this.Controls.SetChildIndex(this.lblLabel1, 0);
                        this.Controls.SetChildIndex(this.txtCupones, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaSubTotal, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion
        }
}