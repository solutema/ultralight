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

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cupones.Cupones
{
        public class Acreditar : Lui.Forms.DialogForm
        {

                internal bool IgnorarCambios;

                #region Código generado por el Diseñador de Windows Forms

                public Acreditar()
                        : base()
                {


                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
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
                internal Lui.Forms.TextBox txtSubTotal;
                internal Lui.Forms.TextBox txtComisionTarjeta;
                internal Lui.Forms.TextBox txtComisionPlan;
                internal Lui.Forms.TextBox txtComisionUsuario;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.ComboBox txtFormaPago;
                internal Label lblComisionUsuarioPct;
                internal Label lblComisionPlanPct;
                internal Label lblComisionTarjetaPct;
                internal Lui.Forms.TextBox txtTotal;

                private void InitializeComponent()
                {
                        this.txtFormaPago = new Lui.Forms.ComboBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.txtCupones = new Lui.Forms.TextBox();
                        this.lblLabel1 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtSubTotal = new Lui.Forms.TextBox();
                        this.txtComisionTarjeta = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.txtComisionPlan = new Lui.Forms.TextBox();
                        this.txtComisionUsuario = new Lui.Forms.TextBox();
                        this.lblComisionTarjetaPct = new System.Windows.Forms.Label();
                        this.lblComisionUsuarioPct = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.lblComisionPlanPct = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtTotal = new Lui.Forms.TextBox();
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
                        // EntradaFormaPago
                        // 
                        this.txtFormaPago.AutoNav = true;
                        this.txtFormaPago.AutoTab = true;
                        this.txtFormaPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFormaPago.Location = new System.Drawing.Point(188, 256);
                        this.txtFormaPago.MaxLenght = 32767;
                        this.txtFormaPago.Name = "EntradaFormaPago";
                        this.txtFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFormaPago.ReadOnly = false;
                        this.txtFormaPago.SetData = new string[] {
        "Efectivo|1",
        "Cheque|2",
        "Depósito en Cuenta|6"};
                        this.txtFormaPago.Size = new System.Drawing.Size(200, 24);
                        this.txtFormaPago.TabIndex = 17;
                        this.txtFormaPago.Text = "Depósito en Cuenta";
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
                        this.txtCupones.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCupones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCupones.Location = new System.Drawing.Point(132, 20);
                        this.txtCupones.MaxLenght = 32767;
                        this.txtCupones.Name = "txtCupones";
                        this.txtCupones.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCupones.ReadOnly = true;
                        this.txtCupones.Size = new System.Drawing.Size(56, 24);
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
                        // txtSubTotal
                        // 
                        this.txtSubTotal.AutoNav = true;
                        this.txtSubTotal.AutoTab = true;
                        this.txtSubTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtSubTotal.Location = new System.Drawing.Point(360, 20);
                        this.txtSubTotal.MaxLenght = 32767;
                        this.txtSubTotal.Name = "txtSubTotal";
                        this.txtSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSubTotal.Prefijo = "$";
                        this.txtSubTotal.ReadOnly = true;
                        this.txtSubTotal.Size = new System.Drawing.Size(100, 24);
                        this.txtSubTotal.TabIndex = 3;
                        this.txtSubTotal.TabStop = false;
                        this.txtSubTotal.Text = "0.00";
                        this.txtSubTotal.TipWhenBlank = "";
                        this.txtSubTotal.ToolTipText = "";
                        // 
                        // txtComisionTarjeta
                        // 
                        this.txtComisionTarjeta.AutoNav = true;
                        this.txtComisionTarjeta.AutoTab = true;
                        this.txtComisionTarjeta.DataType = Lui.Forms.DataTypes.Money;
                        this.txtComisionTarjeta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtComisionTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtComisionTarjeta.Location = new System.Drawing.Point(116, 36);
                        this.txtComisionTarjeta.MaxLenght = 32767;
                        this.txtComisionTarjeta.Name = "txtComisionTarjeta";
                        this.txtComisionTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.txtComisionTarjeta.Prefijo = "$";
                        this.txtComisionTarjeta.ReadOnly = true;
                        this.txtComisionTarjeta.Size = new System.Drawing.Size(108, 24);
                        this.txtComisionTarjeta.TabIndex = 6;
                        this.txtComisionTarjeta.TabStop = false;
                        this.txtComisionTarjeta.Text = "0.00";
                        this.txtComisionTarjeta.TipWhenBlank = "";
                        this.txtComisionTarjeta.ToolTipText = "";
                        this.txtComisionTarjeta.TextChanged += new System.EventHandler(this.txtComisionTarjeta_TextChanged);
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
                        this.Frame1.Controls.Add(this.txtComisionTarjeta);
                        this.Frame1.Controls.Add(this.txtComisionPlan);
                        this.Frame1.Controls.Add(this.txtComisionUsuario);
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
                        this.Frame1.ReadOnly = false;
                        this.Frame1.Size = new System.Drawing.Size(608, 136);
                        this.Frame1.TabIndex = 4;
                        this.Frame1.TabStop = false;
                        this.Frame1.Text = "Comisiones y Otros Decuentos";
                        this.Frame1.ToolTipText = "";
                        // 
                        // txtComisionPlan
                        // 
                        this.txtComisionPlan.AutoNav = true;
                        this.txtComisionPlan.AutoTab = true;
                        this.txtComisionPlan.DataType = Lui.Forms.DataTypes.Money;
                        this.txtComisionPlan.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtComisionPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtComisionPlan.Location = new System.Drawing.Point(116, 68);
                        this.txtComisionPlan.MaxLenght = 32767;
                        this.txtComisionPlan.Name = "txtComisionPlan";
                        this.txtComisionPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.txtComisionPlan.Prefijo = "$";
                        this.txtComisionPlan.ReadOnly = true;
                        this.txtComisionPlan.Size = new System.Drawing.Size(108, 24);
                        this.txtComisionPlan.TabIndex = 9;
                        this.txtComisionPlan.TabStop = false;
                        this.txtComisionPlan.Text = "0.00";
                        this.txtComisionPlan.TipWhenBlank = "";
                        this.txtComisionPlan.ToolTipText = "";
                        this.txtComisionPlan.TextChanged += new System.EventHandler(this.txtComisionPlan_TextChanged);
                        // 
                        // txtComisionUsuario
                        // 
                        this.txtComisionUsuario.AutoNav = true;
                        this.txtComisionUsuario.AutoTab = true;
                        this.txtComisionUsuario.DataType = Lui.Forms.DataTypes.Money;
                        this.txtComisionUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtComisionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtComisionUsuario.Location = new System.Drawing.Point(116, 100);
                        this.txtComisionUsuario.MaxLenght = 32767;
                        this.txtComisionUsuario.Name = "txtComisionUsuario";
                        this.txtComisionUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.txtComisionUsuario.Prefijo = "$";
                        this.txtComisionUsuario.ReadOnly = false;
                        this.txtComisionUsuario.Size = new System.Drawing.Size(108, 24);
                        this.txtComisionUsuario.TabIndex = 12;
                        this.txtComisionUsuario.Text = "0.00";
                        this.txtComisionUsuario.TipWhenBlank = "";
                        this.txtComisionUsuario.ToolTipText = "";
                        this.txtComisionUsuario.TextChanged += new System.EventHandler(this.txtComisionUsuario_TextChanged);
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
                        // EntradaTotal
                        // 
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTotal.Location = new System.Drawing.Point(188, 220);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "EntradaTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.Prefijo = "$";
                        this.txtTotal.ReadOnly = false;
                        this.txtTotal.Size = new System.Drawing.Size(136, 28);
                        this.txtTotal.TabIndex = 15;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
                        this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
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
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.txtSubTotal);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtCupones);
                        this.Controls.Add(this.lblLabel1);
                        this.Controls.Add(this.txtFormaPago);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.Frame1);
                        this.Name = "Acreditar";
                        this.Text = "Tarjetas de Crédito y Débito: Acreditación";
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.ResumeLayout(false);

                }


                #endregion

                private void txtTotal_TextChanged(object sender, System.EventArgs e)
                {
                        if (IgnorarCambios == false) {
                                IgnorarCambios = true;
                                txtComisionUsuario.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) - Lfx.Types.Parsing.ParseCurrency(txtTotal.Text) - Lfx.Types.Parsing.ParseDouble(txtComisionTarjeta.Text) - Lfx.Types.Parsing.ParseDouble(txtComisionPlan.Text), this.Workspace.CurrentConfig.Moneda.Decimales);
                                IgnorarCambios = false;
                        }
                }

                private void txtComisionTarjeta_TextChanged(object sender, EventArgs e)
                {
                        lblComisionTarjetaPct.Text = "(" + Lfx.Types.Formatting.FormatNumber(Lfx.Types.Parsing.ParseCurrency(txtComisionTarjeta.Text) / Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) * 100, 2) + "%)";
                }

                private void txtComisionPlan_TextChanged(object sender, EventArgs e)
                {
                        lblComisionPlanPct.Text = "(" + Lfx.Types.Formatting.FormatNumber(Lfx.Types.Parsing.ParseCurrency(txtComisionPlan.Text) / Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) * 100, 2) + "%)";
                }

                private void txtComisionUsuario_TextChanged(object sender, System.EventArgs e)
                {
                        lblComisionUsuarioPct.Text = "(" + Lfx.Types.Formatting.FormatNumber(Lfx.Types.Parsing.ParseCurrency(txtComisionUsuario.Text) / Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) * 100, 2) + "%)";
                        if (IgnorarCambios == false) {
                                IgnorarCambios = true;
                                txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) - Lfx.Types.Parsing.ParseDouble(txtComisionTarjeta.Text) - Lfx.Types.Parsing.ParseDouble(txtComisionPlan.Text) - Lfx.Types.Parsing.ParseDouble(txtComisionUsuario.Text), this.Workspace.CurrentConfig.Moneda.Decimales);
                                IgnorarCambios = false;
                        }
                }

        }
}
