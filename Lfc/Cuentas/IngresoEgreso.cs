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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cuentas
{
        public class IngresoEgreso : Lui.Forms.DialogForm
        {
                protected internal int m_Id;
                protected internal bool m_Ingreso = true;
                internal Lui.Forms.DetailBox txtCuenta;
                internal Label label6;
                protected internal int m_Cuenta = 999;

                #region Código generado por el Diseñador de Windows Forms

                public IngresoEgreso()
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
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.DetailBox txtConcepto;
                internal Lui.Forms.TextBox txtComprob;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.TextBox txtObs;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.DetailBox txtPersona;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox txtImporte;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtImporte = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtConcepto = new Lui.Forms.DetailBox();
                        this.txtComprob = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtObs = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtPersona = new Lui.Forms.DetailBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtCuenta = new Lui.Forms.DetailBox();
                        this.label6 = new System.Windows.Forms.Label();
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
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 52);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(96, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Concepto";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtImporte
                        // 
                        this.txtImporte.AutoHeight = false;
                        this.txtImporte.AutoNav = true;
                        this.txtImporte.AutoTab = true;
                        this.txtImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImporte.DecimalPlaces = -1;
                        this.txtImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImporte.Location = new System.Drawing.Point(116, 84);
                        this.txtImporte.MaxLenght = 32767;
                        this.txtImporte.MultiLine = false;
                        this.txtImporte.Name = "txtImporte";
                        this.txtImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImporte.PasswordChar = '\0';
                        this.txtImporte.Prefijo = "$";
                        this.txtImporte.ReadOnly = false;
                        this.txtImporte.SelectOnFocus = true;
                        this.txtImporte.Size = new System.Drawing.Size(108, 24);
                        this.txtImporte.Sufijo = "";
                        this.txtImporte.TabIndex = 5;
                        this.txtImporte.Text = "0.00";
                        this.txtImporte.TextRaw = "0.00";
                        this.txtImporte.TipWhenBlank = "";
                        this.txtImporte.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(20, 84);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(96, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Importe";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtConcepto
                        // 
                        this.txtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtConcepto.AutoHeight = false;
                        this.txtConcepto.AutoTab = true;
                        this.txtConcepto.CanCreate = true;
                        this.txtConcepto.DetailField = "nombre";
                        this.txtConcepto.ExtraDetailFields = null;
                        this.txtConcepto.Filter = "es=1";
                        this.txtConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtConcepto.FreeTextCode = "*";
                        this.txtConcepto.KeyField = "id_concepto";
                        this.txtConcepto.Location = new System.Drawing.Point(116, 52);
                        this.txtConcepto.MaxLength = 200;
                        this.txtConcepto.Name = "txtConcepto";
                        this.txtConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtConcepto.ReadOnly = false;
                        this.txtConcepto.Required = true;
                        this.txtConcepto.SelectOnFocus = true;
                        this.txtConcepto.Size = new System.Drawing.Size(500, 24);
                        this.txtConcepto.TabIndex = 3;
                        this.txtConcepto.Table = "cuentas_conceptos";
                        this.txtConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.txtConcepto.Text = "0";
                        this.txtConcepto.TextDetail = "";
                        this.txtConcepto.TextInt = 0;
                        this.txtConcepto.TipWhenBlank = "";
                        this.txtConcepto.ToolTipText = "";
                        // 
                        // txtComprob
                        // 
                        this.txtComprob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtComprob.AutoHeight = false;
                        this.txtComprob.AutoNav = true;
                        this.txtComprob.AutoTab = true;
                        this.txtComprob.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtComprob.DecimalPlaces = -1;
                        this.txtComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtComprob.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtComprob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtComprob.Location = new System.Drawing.Point(116, 148);
                        this.txtComprob.MaxLenght = 32767;
                        this.txtComprob.MultiLine = false;
                        this.txtComprob.Name = "txtComprob";
                        this.txtComprob.Padding = new System.Windows.Forms.Padding(2);
                        this.txtComprob.PasswordChar = '\0';
                        this.txtComprob.Prefijo = "";
                        this.txtComprob.ReadOnly = false;
                        this.txtComprob.SelectOnFocus = true;
                        this.txtComprob.Size = new System.Drawing.Size(500, 24);
                        this.txtComprob.Sufijo = "";
                        this.txtComprob.TabIndex = 9;
                        this.txtComprob.TextRaw = "";
                        this.txtComprob.TipWhenBlank = "";
                        this.txtComprob.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 148);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(96, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Comprobante";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtObs
                        // 
                        this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtObs.AutoHeight = false;
                        this.txtObs.AutoNav = true;
                        this.txtObs.AutoTab = true;
                        this.txtObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtObs.DecimalPlaces = -1;
                        this.txtObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtObs.Location = new System.Drawing.Point(116, 180);
                        this.txtObs.MaxLenght = 32767;
                        this.txtObs.MultiLine = true;
                        this.txtObs.Name = "txtObs";
                        this.txtObs.Padding = new System.Windows.Forms.Padding(2);
                        this.txtObs.PasswordChar = '\0';
                        this.txtObs.Prefijo = "";
                        this.txtObs.ReadOnly = false;
                        this.txtObs.SelectOnFocus = false;
                        this.txtObs.Size = new System.Drawing.Size(500, 116);
                        this.txtObs.Sufijo = "";
                        this.txtObs.TabIndex = 11;
                        this.txtObs.TextRaw = "";
                        this.txtObs.TipWhenBlank = "";
                        this.txtObs.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(20, 180);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(96, 24);
                        this.Label4.TabIndex = 10;
                        this.Label4.Text = "Obs.";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPersona
                        // 
                        this.txtPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPersona.AutoHeight = false;
                        this.txtPersona.AutoTab = true;
                        this.txtPersona.CanCreate = true;
                        this.txtPersona.DetailField = "nombre_visible";
                        this.txtPersona.ExtraDetailFields = null;
                        this.txtPersona.Filter = "";
                        this.txtPersona.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPersona.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPersona.FreeTextCode = "";
                        this.txtPersona.KeyField = "id_persona";
                        this.txtPersona.Location = new System.Drawing.Point(116, 116);
                        this.txtPersona.MaxLength = 200;
                        this.txtPersona.Name = "txtPersona";
                        this.txtPersona.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPersona.ReadOnly = false;
                        this.txtPersona.Required = true;
                        this.txtPersona.SelectOnFocus = true;
                        this.txtPersona.Size = new System.Drawing.Size(500, 24);
                        this.txtPersona.TabIndex = 7;
                        this.txtPersona.Table = "personas";
                        this.txtPersona.TeclaDespuesDeEnter = "{tab}";
                        this.txtPersona.Text = "0";
                        this.txtPersona.TextDetail = "";
                        this.txtPersona.TextInt = 0;
                        this.txtPersona.TipWhenBlank = "";
                        this.txtPersona.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(20, 116);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(96, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "Persona";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCuenta
                        // 
                        this.txtCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCuenta.AutoHeight = false;
                        this.txtCuenta.AutoTab = true;
                        this.txtCuenta.CanCreate = true;
                        this.txtCuenta.DetailField = "nombre";
                        this.txtCuenta.ExtraDetailFields = null;
                        this.txtCuenta.Filter = "";
                        this.txtCuenta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCuenta.FreeTextCode = "*";
                        this.txtCuenta.KeyField = "id_cuenta";
                        this.txtCuenta.Location = new System.Drawing.Point(116, 20);
                        this.txtCuenta.MaxLength = 200;
                        this.txtCuenta.Name = "txtCuenta";
                        this.txtCuenta.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCuenta.ReadOnly = false;
                        this.txtCuenta.Required = true;
                        this.txtCuenta.SelectOnFocus = true;
                        this.txtCuenta.Size = new System.Drawing.Size(500, 24);
                        this.txtCuenta.TabIndex = 1;
                        this.txtCuenta.Table = "cuentas";
                        this.txtCuenta.TeclaDespuesDeEnter = "{tab}";
                        this.txtCuenta.Text = "0";
                        this.txtCuenta.TextDetail = "";
                        this.txtCuenta.TextInt = 0;
                        this.txtCuenta.TipWhenBlank = "";
                        this.txtCuenta.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(20, 20);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(96, 24);
                        this.label6.TabIndex = 0;
                        this.label6.Text = "Cuenta";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // IngresoEgreso
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.txtCuenta);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.txtPersona);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.txtObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtComprob);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtConcepto);
                        this.Controls.Add(this.txtImporte);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Name = "IngresoEgreso";
                        this.Text = "Cuenta: Movimiento";
                        this.WorkspaceChanged += new System.EventHandler(this.FormCuentaCajaIngreso_WorkspaceChanged);
                        this.ResumeLayout(false);

                }


                #endregion

                public int Cuenta
                {
                        get
                        {
                                return txtCuenta.TextInt;
                        }
                        set
                        {
                                m_Cuenta = value;
                                txtCuenta.TextInt = value;
                        }
                }

                public bool Ingreso
                {
                        get
                        {
                                return m_Ingreso;
                        }
                        set
                        {
                                m_Ingreso = value;
                                if (m_Ingreso) {
                                        this.Text = "Cuenta: Ingreso";
                                        txtConcepto.Filter = "(es=1 OR es=0)";
                                } else {
                                        this.Text = "Cuenta: Egreso";
                                        txtConcepto.Filter = "(es=2 OR es=0)";
                                }
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();
                        aceptarReturn.Success = true;

                        if (Lfx.Types.Parsing.ParseCurrency(txtImporte.Text) <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el importe." + Environment.NewLine;
                        }

                        if (txtCuenta.TextInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Cuenta." + Environment.NewLine;
                        }

                        if (txtConcepto.TextInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el Concepto." + Environment.NewLine;
                        }

                        if (aceptarReturn.Success == true) {
                                Lbl.Cuentas.CuentaRegular Cuenta = new Lbl.Cuentas.CuentaRegular(this.Workspace.DefaultDataView, this.Cuenta);
                                if (m_Ingreso)
                                        Cuenta.Movimiento(false, txtConcepto.TextInt, txtConcepto.TextDetail, txtPersona.TextInt, Lfx.Types.Parsing.ParseCurrency(txtImporte.Text), txtObs.Text, 0, 0, txtComprob.Text);
                                else
                                        Cuenta.Movimiento(false, txtConcepto.TextInt, txtConcepto.TextDetail, txtPersona.TextInt, -Lfx.Types.Parsing.ParseCurrency(txtImporte.Text), txtObs.Text, 0, 0, txtComprob.Text);
                        }
                        return aceptarReturn;
                }

                private void FormCuentaCajaIngreso_WorkspaceChanged(object sender, EventArgs e)
                {
                        txtPersona.Text = this.Workspace.CurrentUser.Id.ToString();
                }
        }
}