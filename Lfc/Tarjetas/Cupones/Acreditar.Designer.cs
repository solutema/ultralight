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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Lfc.Tarjetas.Cupones
{
        public partial class Acreditar
        {
                private System.ComponentModel.IContainer components = null;

                internal Lui.Forms.Label Label11;
                internal Lui.Forms.Label lblLabel1;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.Label Label6;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.TextBox txtCupones;
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal Lui.Forms.TextBox EntradaComisionTarjeta;
                internal Lui.Forms.TextBox EntradaComisionPlan;
                internal Lui.Forms.TextBox EntradaComisionUsuario;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.ComboBox txtFormaPago;
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
                        this.Label11 = new Lui.Forms.Label();
                        this.txtCupones = new Lui.Forms.TextBox();
                        this.lblLabel1 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.EntradaComisionTarjeta = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.EntradaComisionPlan = new Lui.Forms.TextBox();
                        this.EntradaComisionUsuario = new Lui.Forms.TextBox();
                        this.lblComisionTarjetaPct = new Lui.Forms.Label();
                        this.lblComisionUsuarioPct = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.lblComisionPlanPct = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.Label6 = new Lui.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label8 = new Lui.Forms.Label();
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
                        this.txtFormaPago.AlwaysExpanded = true;
                        this.txtFormaPago.AutoSize = true;
                        this.txtFormaPago.Location = new System.Drawing.Point(188, 244);
                        this.txtFormaPago.Name = "txtFormaPago";
                        this.txtFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFormaPago.ReadOnly = false;
                        this.txtFormaPago.SetData = new string[] {
        "Efectivo|1",
        "Cheque|2",
        "Depósito en Cuenta|6"};
                        this.txtFormaPago.Size = new System.Drawing.Size(200, 51);
                        this.txtFormaPago.TabIndex = 17;
                        this.txtFormaPago.TextKey = "6";
                        // 
                        // Label11
                        // 
                        this.Label11.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label11.Location = new System.Drawing.Point(56, 244);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(132, 24);
                        this.Label11.TabIndex = 16;
                        this.Label11.Text = "Pago";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCupones
                        // 
                        this.txtCupones.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCupones.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCupones.Location = new System.Drawing.Point(132, 20);
                        this.txtCupones.Name = "txtCupones";
                        this.txtCupones.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCupones.ReadOnly = false;
                        this.txtCupones.Size = new System.Drawing.Size(56, 24);
                        this.txtCupones.TabIndex = 1;
                        this.txtCupones.TabStop = false;
                        this.txtCupones.Text = "0";
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.lblLabel1.Location = new System.Drawing.Point(20, 20);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(112, 24);
                        this.lblLabel1.TabIndex = 0;
                        this.lblLabel1.Text = "Acreditación de";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(192, 20);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(168, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "cupones por un total de";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSubTotal
                        // 
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSubTotal.Location = new System.Drawing.Point(360, 20);
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.ReadOnly = false;
                        this.EntradaSubTotal.Size = new System.Drawing.Size(100, 24);
                        this.EntradaSubTotal.TabIndex = 3;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        // 
                        // EntradaComisionTarjeta
                        // 
                        this.EntradaComisionTarjeta.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaComisionTarjeta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComisionTarjeta.Location = new System.Drawing.Point(116, 36);
                        this.EntradaComisionTarjeta.Name = "EntradaComisionTarjeta";
                        this.EntradaComisionTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComisionTarjeta.Prefijo = "$";
                        this.EntradaComisionTarjeta.ReadOnly = false;
                        this.EntradaComisionTarjeta.Size = new System.Drawing.Size(108, 24);
                        this.EntradaComisionTarjeta.TabIndex = 6;
                        this.EntradaComisionTarjeta.TabStop = false;
                        this.EntradaComisionTarjeta.Text = "0.00";
                        this.EntradaComisionTarjeta.TextChanged += new System.EventHandler(this.EntradaComisionTarjeta_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(8, 36);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(112, 24);
                        this.Label2.TabIndex = 5;
                        this.Label2.Text = "De las Tarjetas";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame1
                        // 
                        this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame1.Location = new System.Drawing.Point(12, 56);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.Size = new System.Drawing.Size(608, 136);
                        this.Frame1.TabIndex = 4;
                        this.Frame1.TabStop = false;
                        this.Frame1.Text = "Comisiones y Otros Decuentos";
                        // 
                        // EntradaComisionPlan
                        // 
                        this.EntradaComisionPlan.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaComisionPlan.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComisionPlan.Location = new System.Drawing.Point(116, 68);
                        this.EntradaComisionPlan.Name = "EntradaComisionPlan";
                        this.EntradaComisionPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComisionPlan.Prefijo = "$";
                        this.EntradaComisionPlan.ReadOnly = false;
                        this.EntradaComisionPlan.Size = new System.Drawing.Size(108, 24);
                        this.EntradaComisionPlan.TabIndex = 9;
                        this.EntradaComisionPlan.TabStop = false;
                        this.EntradaComisionPlan.Text = "0.00";
                        this.EntradaComisionPlan.TextChanged += new System.EventHandler(this.EntradaComisionPlan_TextChanged);
                        // 
                        // EntradaComisionUsuario
                        // 
                        this.EntradaComisionUsuario.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaComisionUsuario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComisionUsuario.Location = new System.Drawing.Point(116, 100);
                        this.EntradaComisionUsuario.Name = "EntradaComisionUsuario";
                        this.EntradaComisionUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComisionUsuario.Prefijo = "$";
                        this.EntradaComisionUsuario.ReadOnly = false;
                        this.EntradaComisionUsuario.Size = new System.Drawing.Size(108, 24);
                        this.EntradaComisionUsuario.TabIndex = 12;
                        this.EntradaComisionUsuario.Text = "0.00";
                        this.EntradaComisionUsuario.TextChanged += new System.EventHandler(this.EntradaComisionUsuario_TextChanged);
                        // 
                        // lblComisionTarjetaPct
                        // 
                        this.lblComisionTarjetaPct.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.lblComisionTarjetaPct.Location = new System.Drawing.Point(228, 36);
                        this.lblComisionTarjetaPct.Name = "lblComisionTarjetaPct";
                        this.lblComisionTarjetaPct.Size = new System.Drawing.Size(76, 24);
                        this.lblComisionTarjetaPct.TabIndex = 8;
                        this.lblComisionTarjetaPct.Text = "(0%)";
                        this.lblComisionTarjetaPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblComisionUsuarioPct
                        // 
                        this.lblComisionUsuarioPct.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.lblComisionUsuarioPct.Location = new System.Drawing.Point(228, 100);
                        this.lblComisionUsuarioPct.Name = "lblComisionUsuarioPct";
                        this.lblComisionUsuarioPct.Size = new System.Drawing.Size(76, 24);
                        this.lblComisionUsuarioPct.TabIndex = 10;
                        this.lblComisionUsuarioPct.Text = "(0%)";
                        this.lblComisionUsuarioPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(8, 100);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(112, 24);
                        this.Label4.TabIndex = 11;
                        this.Label4.Text = "Otros";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblComisionPlanPct
                        // 
                        this.lblComisionPlanPct.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.lblComisionPlanPct.Location = new System.Drawing.Point(228, 68);
                        this.lblComisionPlanPct.Name = "lblComisionPlanPct";
                        this.lblComisionPlanPct.Size = new System.Drawing.Size(76, 24);
                        this.lblComisionPlanPct.TabIndex = 9;
                        this.lblComisionPlanPct.Text = "(0%)";
                        this.lblComisionPlanPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(8, 68);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(112, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "De los Planes";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.Label5.Location = new System.Drawing.Point(308, 36);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(292, 24);
                        this.Label5.TabIndex = 7;
                        this.Label5.Text = "(Comisiones normales de las tarjetas)";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.Label7.Location = new System.Drawing.Point(308, 100);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(292, 24);
                        this.Label7.TabIndex = 13;
                        this.Label7.Text = "(Otros descuentos no contemplados)";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.Label6.Location = new System.Drawing.Point(308, 68);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(292, 24);
                        this.Label6.TabIndex = 10;
                        this.Label6.Text = "(Comisiones adicionales de algunos planes)";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.Location = new System.Drawing.Point(188, 208);
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = false;
                        this.EntradaTotal.Size = new System.Drawing.Size(136, 28);
                        this.EntradaTotal.TabIndex = 15;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TextChanged += new System.EventHandler(this.EntradaTotal_TextChanged);
                        // 
                        // Label8
                        // 
                        this.Label8.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(56, 208);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(132, 28);
                        this.Label8.TabIndex = 14;
                        this.Label8.Text = "Total a Acreditar";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Acreditar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 372);
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
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label lblComisionUsuarioPct;
                internal Lui.Forms.Label lblComisionPlanPct;
                internal Lui.Forms.Label lblComisionTarjetaPct;
        }
}
