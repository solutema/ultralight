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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cajas
{
        public partial class IngresoEgreso : Lui.Forms.DialogForm
        {
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

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaComprobante = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaPersona = new Lcc.Entrada.CodigoDetalle();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaNuevoSaldo = new Lui.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
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
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoSize = false;
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaImporte.Location = new System.Drawing.Point(116, 84);
                        this.EntradaImporte.MaxLenght = 32767;
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.PasswordChar = '\0';
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.ReadOnly = false;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(108, 24);
                        this.EntradaImporte.Sufijo = "";
                        this.EntradaImporte.TabIndex = 5;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TipWhenBlank = "";
                        this.EntradaImporte.ToolTipText = "";
                        this.EntradaImporte.TextChanged += new System.EventHandler(this.EntradaImporte_TextChanged);
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
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoSize = false;
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.DataTextField = "nombre";
                        this.EntradaConcepto.ExtraDetailFields = null;
                        this.EntradaConcepto.Filter = "es=1";
                        this.EntradaConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConcepto.FreeTextCode = "*";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(116, 52);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.ReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.Size = new System.Drawing.Size(500, 24);
                        this.EntradaConcepto.TabIndex = 3;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        this.EntradaConcepto.TipWhenBlank = "";
                        this.EntradaConcepto.ToolTipText = "";
                        // 
                        // EntradaComprobante
                        // 
                        this.EntradaComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaComprobante.AutoSize = false;
                        this.EntradaComprobante.AutoNav = true;
                        this.EntradaComprobante.AutoTab = true;
                        this.EntradaComprobante.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaComprobante.DecimalPlaces = -1;
                        this.EntradaComprobante.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaComprobante.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaComprobante.Location = new System.Drawing.Point(116, 148);
                        this.EntradaComprobante.MaxLenght = 32767;
                        this.EntradaComprobante.MultiLine = false;
                        this.EntradaComprobante.Name = "EntradaComprobante";
                        this.EntradaComprobante.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComprobante.PasswordChar = '\0';
                        this.EntradaComprobante.Prefijo = "";
                        this.EntradaComprobante.ReadOnly = false;
                        this.EntradaComprobante.SelectOnFocus = true;
                        this.EntradaComprobante.Size = new System.Drawing.Size(500, 24);
                        this.EntradaComprobante.Sufijo = "";
                        this.EntradaComprobante.TabIndex = 9;
                        this.EntradaComprobante.TipWhenBlank = "";
                        this.EntradaComprobante.ToolTipText = "";
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
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoSize = false;
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.Location = new System.Drawing.Point(116, 180);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(500, 116);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 11;
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
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
                        // EntradaPersona
                        // 
                        this.EntradaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPersona.AutoSize = false;
                        this.EntradaPersona.AutoTab = true;
                        this.EntradaPersona.CanCreate = true;
                        this.EntradaPersona.DataTextField = "nombre_visible";
                        this.EntradaPersona.ExtraDetailFields = null;
                        this.EntradaPersona.Filter = "";
                        this.EntradaPersona.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPersona.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPersona.FreeTextCode = "";
                        this.EntradaPersona.DataValueField = "id_persona";
                        this.EntradaPersona.Location = new System.Drawing.Point(116, 116);
                        this.EntradaPersona.MaxLength = 200;
                        this.EntradaPersona.Name = "EntradaPersona";
                        this.EntradaPersona.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPersona.ReadOnly = false;
                        this.EntradaPersona.Required = true;
                        this.EntradaPersona.Size = new System.Drawing.Size(500, 24);
                        this.EntradaPersona.TabIndex = 7;
                        this.EntradaPersona.Table = "personas";
                        this.EntradaPersona.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaPersona.Text = "0";
                        this.EntradaPersona.TextDetail = "";
                        this.EntradaPersona.TipWhenBlank = "";
                        this.EntradaPersona.ToolTipText = "";
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
                        // EntradaCaja
                        // 
                        this.EntradaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCaja.AutoSize = false;
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DataTextField = "nombre";
                        this.EntradaCaja.ExtraDetailFields = null;
                        this.EntradaCaja.Filter = "";
                        this.EntradaCaja.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCaja.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCaja.FreeTextCode = "*";
                        this.EntradaCaja.DataValueField = "id_caja";
                        this.EntradaCaja.Location = new System.Drawing.Point(116, 20);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.ReadOnly = false;
                        this.EntradaCaja.Required = true;
                        this.EntradaCaja.Size = new System.Drawing.Size(500, 24);
                        this.EntradaCaja.TabIndex = 1;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.TipWhenBlank = "";
                        this.EntradaCaja.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(20, 20);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(96, 24);
                        this.label6.TabIndex = 0;
                        this.label6.Text = "Caja";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNuevoSaldo
                        // 
                        this.EntradaNuevoSaldo.AutoSize = false;
                        this.EntradaNuevoSaldo.AutoNav = true;
                        this.EntradaNuevoSaldo.AutoTab = true;
                        this.EntradaNuevoSaldo.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaNuevoSaldo.DecimalPlaces = -1;
                        this.EntradaNuevoSaldo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNuevoSaldo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNuevoSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNuevoSaldo.Location = new System.Drawing.Point(352, 84);
                        this.EntradaNuevoSaldo.MaxLenght = 32767;
                        this.EntradaNuevoSaldo.MultiLine = false;
                        this.EntradaNuevoSaldo.Name = "EntradaNuevoSaldo";
                        this.EntradaNuevoSaldo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNuevoSaldo.PasswordChar = '\0';
                        this.EntradaNuevoSaldo.Prefijo = "$";
                        this.EntradaNuevoSaldo.ReadOnly = true;
                        this.EntradaNuevoSaldo.SelectOnFocus = true;
                        this.EntradaNuevoSaldo.Size = new System.Drawing.Size(120, 24);
                        this.EntradaNuevoSaldo.Sufijo = "";
                        this.EntradaNuevoSaldo.TabIndex = 52;
                        this.EntradaNuevoSaldo.TabStop = false;
                        this.EntradaNuevoSaldo.Text = "0.00";
                        this.EntradaNuevoSaldo.TipWhenBlank = "";
                        this.EntradaNuevoSaldo.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(256, 84);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(96, 24);
                        this.label7.TabIndex = 51;
                        this.label7.Text = "Nuevo Saldo";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // IngresoEgreso
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.EntradaNuevoSaldo);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaCaja);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EntradaPersona);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaComprobante);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaConcepto);
                        this.Controls.Add(this.EntradaImporte);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Name = "IngresoEgreso";
                        this.Text = "Caja: Movimiento";
                        this.WorkspaceChanged += new System.EventHandler(this.IngresoEgreso_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaImporte, 0);
                        this.Controls.SetChildIndex(this.EntradaConcepto, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaComprobante, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaPersona, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.EntradaCaja, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.EntradaNuevoSaldo, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
                internal Lui.Forms.TextBox EntradaComprobante;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.TextBox EntradaObs;
                internal System.Windows.Forms.Label Label4;
                internal Lcc.Entrada.CodigoDetalle EntradaPersona;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaImporte;
                internal Lcc.Entrada.CodigoDetalle EntradaCaja;
                internal Label label6;
                internal Lui.Forms.TextBox EntradaNuevoSaldo;
                internal Label label7;
        }
}
