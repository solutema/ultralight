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
using System.Collections.Generic;
using System.Text;

namespace Lfc.Bancos.Cheques
{
        public partial class Efectivizar : Lui.Forms.DialogForm
        {
                #region Código generado por el Diseñador de Windows Forms

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
                internal Lui.Forms.TextBox txtSubTotal;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label lblLabel1;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox txtTotal;
                internal System.Windows.Forms.Label Label8;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.DetailBox txtCuentaDestino;
                internal Lui.Forms.TextBox txtCantidad;

                private void InitializeComponent()
                {
                        this.txtSubTotal = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtCantidad = new Lui.Forms.TextBox();
                        this.lblLabel1 = new System.Windows.Forms.Label();
                        this.txtGestionDeCobro = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtCuentaDestino = new Lui.Forms.DetailBox();
                        this.txtImpuestos = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
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
                        // txtSubTotal
                        // 
                        this.txtSubTotal.AutoNav = true;
                        this.txtSubTotal.AutoTab = true;
                        this.txtSubTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtSubTotal.Location = new System.Drawing.Point(412, 68);
                        this.txtSubTotal.MaxLenght = 32767;
                        this.txtSubTotal.Name = "txtSubTotal";
                        this.txtSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSubTotal.Prefijo = "$";
                        this.txtSubTotal.ReadOnly = true;
                        this.txtSubTotal.Size = new System.Drawing.Size(108, 24);
                        this.txtSubTotal.TabIndex = 4;
                        this.txtSubTotal.TabStop = false;
                        this.txtSubTotal.Text = "0.00";
                        this.txtSubTotal.TipWhenBlank = "";
                        this.txtSubTotal.ToolTipText = "";
                        this.txtSubTotal.TextChanged += new System.EventHandler(this.txtImportes_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(236, 68);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(176, 24);
                        this.Label1.TabIndex = 3;
                        this.Label1.Text = "cheque(s) por un total de";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCantidad
                        // 
                        this.txtCantidad.AutoNav = true;
                        this.txtCantidad.AutoTab = true;
                        this.txtCantidad.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCantidad.Location = new System.Drawing.Point(172, 68);
                        this.txtCantidad.MaxLenght = 32767;
                        this.txtCantidad.Name = "txtCantidad";
                        this.txtCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCantidad.ReadOnly = true;
                        this.txtCantidad.Size = new System.Drawing.Size(56, 24);
                        this.txtCantidad.TabIndex = 2;
                        this.txtCantidad.TabStop = false;
                        this.txtCantidad.Text = "0";
                        this.txtCantidad.TipWhenBlank = "";
                        this.txtCantidad.ToolTipText = "";
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblLabel1.Location = new System.Drawing.Point(60, 68);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(112, 24);
                        this.lblLabel1.TabIndex = 1;
                        this.lblLabel1.Text = "Acreditación de";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtGestionDeCobro
                        // 
                        this.txtGestionDeCobro.AutoNav = true;
                        this.txtGestionDeCobro.AutoTab = true;
                        this.txtGestionDeCobro.DataType = Lui.Forms.DataTypes.Money;
                        this.txtGestionDeCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtGestionDeCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtGestionDeCobro.Location = new System.Drawing.Point(412, 100);
                        this.txtGestionDeCobro.MaxLenght = 32767;
                        this.txtGestionDeCobro.Name = "txtGestionDeCobro";
                        this.txtGestionDeCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.txtGestionDeCobro.Prefijo = "$";
                        this.txtGestionDeCobro.ReadOnly = false;
                        this.txtGestionDeCobro.Size = new System.Drawing.Size(108, 24);
                        this.txtGestionDeCobro.TabIndex = 6;
                        this.txtGestionDeCobro.Text = "0.00";
                        this.txtGestionDeCobro.TipWhenBlank = "";
                        this.txtGestionDeCobro.ToolTipText = "";
                        this.txtGestionDeCobro.TextChanged += new System.EventHandler(this.txtImportes_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(276, 100);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(132, 24);
                        this.Label2.TabIndex = 5;
                        this.Label2.Text = "- Gestión de cobro";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTotal.Location = new System.Drawing.Point(212, 196);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "EntradaTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.Prefijo = "$";
                        this.txtTotal.ReadOnly = false;
                        this.txtTotal.Size = new System.Drawing.Size(136, 28);
                        this.txtTotal.TabIndex = 10;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
                        // 
                        // Label8
                        // 
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(60, 196);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(160, 28);
                        this.Label8.TabIndex = 9;
                        this.Label8.Text = "Se van a acreditar";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(60, 232);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(160, 24);
                        this.Label3.TabIndex = 11;
                        this.Label3.Text = "En la siguiente cuenta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCuentaDestino
                        // 
                        this.txtCuentaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCuentaDestino.AutoTab = true;
                        this.txtCuentaDestino.CanCreate = false;
                        this.txtCuentaDestino.DetailField = "nombre";
                        this.txtCuentaDestino.ExtraDetailFields = null;
                        this.txtCuentaDestino.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCuentaDestino.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCuentaDestino.FreeTextCode = "";
                        this.txtCuentaDestino.KeyField = "id_cuenta";
                        this.txtCuentaDestino.Location = new System.Drawing.Point(212, 232);
                        this.txtCuentaDestino.MaxLength = 200;
                        this.txtCuentaDestino.Name = "txtCuentaDestino";
                        this.txtCuentaDestino.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCuentaDestino.ReadOnly = false;
                        this.txtCuentaDestino.Required = true;
                        this.txtCuentaDestino.SelectOnFocus = false;
                        this.txtCuentaDestino.Size = new System.Drawing.Size(348, 24);
                        this.txtCuentaDestino.TabIndex = 12;
                        this.txtCuentaDestino.Table = "cuentas";
                        this.txtCuentaDestino.TeclaDespuesDeEnter = "{tab}";
                        this.txtCuentaDestino.Text = "0";
                        this.txtCuentaDestino.TextDetail = "";
                        this.txtCuentaDestino.TextInt = 0;
                        this.txtCuentaDestino.TipWhenBlank = "";
                        this.txtCuentaDestino.ToolTipText = "";
                        // 
                        // txtImpuestos
                        // 
                        this.txtImpuestos.AutoNav = true;
                        this.txtImpuestos.AutoTab = true;
                        this.txtImpuestos.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImpuestos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImpuestos.Location = new System.Drawing.Point(412, 128);
                        this.txtImpuestos.MaxLenght = 32767;
                        this.txtImpuestos.Name = "txtImpuestos";
                        this.txtImpuestos.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImpuestos.Prefijo = "$";
                        this.txtImpuestos.ReadOnly = false;
                        this.txtImpuestos.Size = new System.Drawing.Size(108, 24);
                        this.txtImpuestos.TabIndex = 8;
                        this.txtImpuestos.Text = "0.00";
                        this.txtImpuestos.TipWhenBlank = "";
                        this.txtImpuestos.ToolTipText = "";
                        this.txtImpuestos.TextChanged += new System.EventHandler(this.txtImportes_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label4.Location = new System.Drawing.Point(276, 128);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(132, 24);
                        this.label4.TabIndex = 7;
                        this.label4.Text = "- Otros gastos";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label5.Location = new System.Drawing.Point(20, 16);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(596, 36);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Convertirá el valor de un cheque en efectivo o realizará un depósito bancario en " +
                            "una cuenta propia.";
                        // 
                        // Efectivizar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.txtImpuestos);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.txtCuentaDestino);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.txtGestionDeCobro);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtSubTotal);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtCantidad);
                        this.Controls.Add(this.lblLabel1);
                        this.Name = "Efectivizar";
                        this.Text = "Acreditar";
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.TextBox txtGestionDeCobro;
                internal Lui.Forms.TextBox txtImpuestos;
                internal System.Windows.Forms.Label label4;
                internal System.Windows.Forms.Label label5;
        }
}
