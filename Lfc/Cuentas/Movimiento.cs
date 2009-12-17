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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cuentas
{
        public class Movimiento : Lui.Forms.DialogForm
        {
                public int iMonedaOrigen;
                public int iMonedaDestino;
                public Lfx.Data.Row MonedaOrigen, MonedaDestino;
                internal System.Windows.Forms.Label label7;

                #region Código generado por el Diseñador de Windows Forms

                public Movimiento()
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
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.TextBox txtImporte;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.DetailBox txtConcepto;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox txtObs;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox txtComprob;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.DetailBox txtDestino;
                internal Lui.Forms.DetailBox txtOrigen;
                internal Lui.Forms.TextBox txtImporteDestino;
                internal System.Windows.Forms.Label lblImporteDestino;

                private void InitializeComponent()
                {
                        this.txtDestino = new Lui.Forms.DetailBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtImporte = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtConcepto = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtObs = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtComprob = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtOrigen = new Lui.Forms.DetailBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.txtImporteDestino = new Lui.Forms.TextBox();
                        this.lblImporteDestino = new System.Windows.Forms.Label();
                        this.label7 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.DockPadding.All = 2;
                        this.OkButton.Name = "OkButton";
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.DockPadding.All = 2;
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        // 
                        // txtDestino
                        // 
                        this.txtDestino.AutoTab = true;
                        this.txtDestino.CanCreate = false;
                        this.txtDestino.DetailField = "nombre";
                        this.txtDestino.DockPadding.All = 2;
                        this.txtDestino.ExtraDetailFields = null;
                        this.txtDestino.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtDestino.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDestino.FreeTextCode = "";
                        this.txtDestino.KeyField = "id_cuenta";
                        this.txtDestino.Location = new System.Drawing.Point(112, 100);
                        this.txtDestino.MaxLength = 200;
                        this.txtDestino.Name = "txtDestino";
                        this.txtDestino.ReadOnly = false;
                        this.txtDestino.Required = false;
                        this.txtDestino.Size = new System.Drawing.Size(356, 24);
                        this.txtDestino.TabIndex = 3;
                        this.txtDestino.Table = "cuentas";
                        this.txtDestino.TeclaDespuesDeEnter = "{tab}";
                        this.txtDestino.Text = "0";
                        this.txtDestino.TextDetail = "";
                        this.txtDestino.TextInt = 0;
                        this.txtDestino.ToolTipText = "";
                        this.txtDestino.TextChanged += new System.EventHandler(this.txtOrigenDestino_TextChanged);
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(16, 100);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(96, 24);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Destino";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtImporte
                        // 
                        this.txtImporte.AutoNav = true;
                        this.txtImporte.AutoTab = true;
                        this.txtImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImporte.DockPadding.All = 2;
                        this.txtImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtImporte.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtImporte.Location = new System.Drawing.Point(112, 132);
                        this.txtImporte.MaxLenght = 32767;
                        this.txtImporte.Name = "txtImporte";
                        this.txtImporte.Prefijo = "$";
                        this.txtImporte.ReadOnly = false;
                        this.txtImporte.Size = new System.Drawing.Size(108, 24);
                        this.txtImporte.TabIndex = 5;
                        this.txtImporte.Text = "0.00";
                        this.txtImporte.ToolTipText = "";
                        this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(16, 132);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(96, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Importe";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtConcepto
                        // 
                        this.txtConcepto.AutoTab = true;
                        this.txtConcepto.CanCreate = false;
                        this.txtConcepto.DetailField = "nombre";
                        this.txtConcepto.DockPadding.All = 2;
                        this.txtConcepto.ExtraDetailFields = null;
                        this.txtConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtConcepto.FreeTextCode = "*";
                        this.txtConcepto.KeyField = "id_concepto";
                        this.txtConcepto.Location = new System.Drawing.Point(112, 164);
                        this.txtConcepto.MaxLength = 200;
                        this.txtConcepto.Name = "txtConcepto";
                        this.txtConcepto.ReadOnly = false;
                        this.txtConcepto.Required = true;
                        this.txtConcepto.Size = new System.Drawing.Size(356, 24);
                        this.txtConcepto.TabIndex = 9;
                        this.txtConcepto.Table = "cuentas_conceptos";
                        this.txtConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.txtConcepto.Text = "0";
                        this.txtConcepto.TextDetail = "";
                        this.txtConcepto.TextInt = 0;
                        this.txtConcepto.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(16, 164);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(96, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Concepto";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtObs
                        // 
                        this.txtObs.AutoNav = true;
                        this.txtObs.AutoTab = true;
                        this.txtObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtObs.DockPadding.All = 2;
                        this.txtObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtObs.Location = new System.Drawing.Point(112, 228);
                        this.txtObs.MaxLenght = 32767;
                        this.txtObs.MultiLine = true;
                        this.txtObs.Name = "txtObs";
                        this.txtObs.ReadOnly = false;
                        this.txtObs.SelectOnFocus = false;
                        this.txtObs.Size = new System.Drawing.Size(464, 92);
                        this.txtObs.TabIndex = 13;
                        this.txtObs.ToolTipText = "";
                        this.txtObs.Enter += new System.EventHandler(this.txtObs_Enter);
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(16, 228);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(96, 24);
                        this.Label4.TabIndex = 12;
                        this.Label4.Text = "Obs.";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtComprob
                        // 
                        this.txtComprob.AutoNav = true;
                        this.txtComprob.AutoTab = true;
                        this.txtComprob.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtComprob.DockPadding.All = 2;
                        this.txtComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtComprob.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtComprob.Location = new System.Drawing.Point(112, 196);
                        this.txtComprob.MaxLenght = 32767;
                        this.txtComprob.Name = "txtComprob";
                        this.txtComprob.ReadOnly = false;
                        this.txtComprob.Size = new System.Drawing.Size(240, 24);
                        this.txtComprob.TabIndex = 11;
                        this.txtComprob.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(16, 196);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(96, 24);
                        this.Label5.TabIndex = 10;
                        this.Label5.Text = "Comprobante";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtOrigen
                        // 
                        this.txtOrigen.AutoTab = true;
                        this.txtOrigen.CanCreate = false;
                        this.txtOrigen.DetailField = "nombre";
                        this.txtOrigen.DockPadding.All = 2;
                        this.txtOrigen.ExtraDetailFields = null;
                        this.txtOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtOrigen.FreeTextCode = "";
                        this.txtOrigen.KeyField = "id_cuenta";
                        this.txtOrigen.Location = new System.Drawing.Point(112, 68);
                        this.txtOrigen.MaxLength = 200;
                        this.txtOrigen.Name = "txtOrigen";
                        this.txtOrigen.ReadOnly = true;
                        this.txtOrigen.Required = false;
                        this.txtOrigen.Size = new System.Drawing.Size(356, 24);
                        this.txtOrigen.TabIndex = 1;
                        this.txtOrigen.Table = "cuentas";
                        this.txtOrigen.TabStop = false;
                        this.txtOrigen.TeclaDespuesDeEnter = "{tab}";
                        this.txtOrigen.Text = "0";
                        this.txtOrigen.TextDetail = "";
                        this.txtOrigen.TextInt = 0;
                        this.txtOrigen.ToolTipText = "";
                        this.txtOrigen.TextChanged += new System.EventHandler(this.txtOrigenDestino_TextChanged);
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(16, 68);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(96, 24);
                        this.Label6.TabIndex = 0;
                        this.Label6.Text = "Origen";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtImporteDestino
                        // 
                        this.txtImporteDestino.AutoNav = true;
                        this.txtImporteDestino.AutoTab = true;
                        this.txtImporteDestino.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImporteDestino.DockPadding.All = 2;
                        this.txtImporteDestino.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtImporteDestino.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtImporteDestino.Location = new System.Drawing.Point(244, 132);
                        this.txtImporteDestino.MaxLenght = 32767;
                        this.txtImporteDestino.Name = "txtImporteDestino";
                        this.txtImporteDestino.Prefijo = "$";
                        this.txtImporteDestino.ReadOnly = false;
                        this.txtImporteDestino.Size = new System.Drawing.Size(108, 24);
                        this.txtImporteDestino.TabIndex = 7;
                        this.txtImporteDestino.Text = "0.00";
                        this.txtImporteDestino.ToolTipText = "";
                        this.txtImporteDestino.Visible = false;
                        // 
                        // lblImporteDestino
                        // 
                        this.lblImporteDestino.Location = new System.Drawing.Point(220, 132);
                        this.lblImporteDestino.Name = "lblImporteDestino";
                        this.lblImporteDestino.Size = new System.Drawing.Size(24, 24);
                        this.lblImporteDestino.TabIndex = 6;
                        this.lblImporteDestino.Text = "->";
                        this.lblImporteDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.lblImporteDestino.Visible = false;
                        // 
                        // label7
                        // 
                        this.label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.label7.Location = new System.Drawing.Point(16, 16);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(560, 36);
                        this.label7.TabIndex = 51;
                        this.label7.Text = "Va a realizar un movimiento de dinero entre una cuenta y otra. Esto generará un e" +
                                "greso en la cuenta de origen y un ingreso en la cuenta de destino.";
                        // 
                        // FormCuentaCajaMovim
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(594, 403);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.txtImporteDestino);
                        this.Controls.Add(this.lblImporteDestino);
                        this.Controls.Add(this.txtOrigen);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtComprob);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.txtConcepto);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtImporte);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtDestino);
                        this.Controls.Add(this.Label3);
                        this.Name = "FormCuentaCajaMovim";
                        this.ResumeLayout(false);

                }


                #endregion

                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();

                        int iOrigen = txtOrigen.TextInt;
                        int iDestino = txtDestino.TextInt;

                        if (iOrigen == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Cuenta de Origen." + Environment.NewLine;
                        }
                        if (iDestino == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Cuenta de Destino." + Environment.NewLine;
                        }
                        if (Lfx.Types.Parsing.ParseCurrency(txtImporte.Text) <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el importe." + Environment.NewLine;
                        }
                        if (txtConcepto.TextInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el Concepto." + Environment.NewLine;
                        }

                        if (aceptarReturn.Success == true) {
                                double Importe = Lfx.Types.Parsing.ParseCurrency(txtImporte.Text);
                                DataView.BeginTransaction();
                                Lbl.Cuentas.CuentaRegular CuentaOrigen = new Lbl.Cuentas.CuentaRegular(DataView, iOrigen);
                                CuentaOrigen.Movimiento(false, txtConcepto.TextInt, txtConcepto.TextDetail, this.Workspace.CurrentUser.Id, -Importe, txtObs.Text, 0, 0, txtComprob.Text);
                                if (txtImporteDestino.Visible)
                                        Importe = Lfx.Types.Parsing.ParseCurrency(txtImporteDestino.Text);
                                Lbl.Cuentas.CuentaRegular CuentaDestino = new Lbl.Cuentas.CuentaRegular(DataView, iDestino);
                                CuentaDestino.Movimiento(false, txtConcepto.TextInt, txtConcepto.TextDetail, this.Workspace.CurrentUser.Id, Importe, txtObs.Text, 0, 0, txtComprob.Text);
                                DataView.Commit();
                        }
                        return aceptarReturn;
                }


                private void txtObs_Enter(object sender, System.EventArgs e)
                {
                        int iOrigen = txtOrigen.TextInt;
                        int iDestino = txtDestino.TextInt;
                        if (txtObs.Text.Length == 0 && iOrigen != 0 && iDestino != 0) {
                                txtObs.Text = "Movimiento entre " + this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cuentas WHERE id_cuenta=" + iOrigen.ToString()) + " y " + this.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM cuentas WHERE id_cuenta=" + iDestino.ToString());
                        }
                }


                private void txtOrigenDestino_TextChanged(object sender, System.EventArgs e)
                {
                        iMonedaOrigen = this.Workspace.DefaultDataBase.FieldInt("SELECT id_moneda FROM cuentas WHERE id_cuenta=" + txtOrigen.TextInt);
                        iMonedaDestino = this.Workspace.DefaultDataBase.FieldInt("SELECT id_moneda FROM cuentas WHERE id_cuenta=" + txtDestino.TextInt);
                        MonedaOrigen = this.Workspace.DefaultDataBase.Row("monedas", "id_moneda", iMonedaOrigen);
                        MonedaDestino = this.Workspace.DefaultDataBase.Row("monedas", "id_moneda", iMonedaDestino);
                        if (MonedaOrigen != null && MonedaDestino != null) {
                                txtImporte.Prefijo = System.Convert.ToString(MonedaOrigen["signo"]);
                                txtImporteDestino.Prefijo = System.Convert.ToString(MonedaDestino["signo"]);
                                if (System.Convert.ToInt32(MonedaOrigen["id_moneda"]) != System.Convert.ToInt32(MonedaDestino["id_moneda"])) {
                                        txtImporteDestino.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtImporte.Text) * System.Convert.ToDouble(MonedaDestino["cotizacion"]) / System.Convert.ToDouble(MonedaOrigen["cotizacion"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                        txtImporteDestino.Visible = true;
                                        lblImporteDestino.Visible = true;
                                        txtImporteDestino.ShowBalloon("Se realiza una conversin de moneda segn la cotización " + System.Convert.ToString(MonedaOrigen["signo"]) + " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(MonedaOrigen["cotizacion"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces) + " = " + System.Convert.ToString(MonedaDestino["signo"]) + " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(MonedaDestino["cotizacion"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces));
                                } else {
                                        txtImporteDestino.Visible = false;
                                        lblImporteDestino.Visible = false;
                                }
                        } else {
                                txtImporteDestino.Visible = false;
                                lblImporteDestino.Visible = false;
                        }
                }


                private void txtImporte_TextChanged(object sender, System.EventArgs e)
                {
                        if (MonedaOrigen != null && MonedaDestino != null) {
                                if (System.Convert.ToInt32(MonedaOrigen["id_moneda"]) != System.Convert.ToInt32(MonedaDestino["id_moneda"]))
                                        txtImporteDestino.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtImporte.Text) * System.Convert.ToDouble(MonedaDestino["cotizacion"]) / System.Convert.ToDouble(MonedaOrigen["cotizacion"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        }
                }

        }
}