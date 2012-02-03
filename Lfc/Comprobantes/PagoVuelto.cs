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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public class PagoVuelto : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public PagoVuelto()
                        :
                        base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        OkButton.Visible = false;
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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaTotal;
                internal Lui.Forms.TextBox EntradaPago;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.TextBox EntradaCambio;
                internal Lui.Forms.Label Label3;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;

                private void InitializeComponent()
                {
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.EntradaPago = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaCambio = new Lui.Forms.TextBox();
                        this.Label3 = new Lui.Forms.Label();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(178, 8);
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(298, 8);
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(48, 92);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(164, 32);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Importe a Cobrar";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.FieldName = null;
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.Location = new System.Drawing.Point(212, 92);
                        this.EntradaTotal.MaxLength = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.PlaceholderText = null;
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = false;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(152, 32);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 1;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        // 
                        // EntradaPago
                        // 
                        this.EntradaPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.EntradaPago.AutoNav = true;
                        this.EntradaPago.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaPago.DecimalPlaces = -1;
                        this.EntradaPago.FieldName = null;
                        this.EntradaPago.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPago.Location = new System.Drawing.Point(212, 140);
                        this.EntradaPago.MaxLength = 32767;
                        this.EntradaPago.MultiLine = false;
                        this.EntradaPago.Name = "EntradaPago";
                        this.EntradaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPago.PasswordChar = '\0';
                        this.EntradaPago.PlaceholderText = null;
                        this.EntradaPago.Prefijo = "$";
                        this.EntradaPago.ReadOnly = false;
                        this.EntradaPago.SelectOnFocus = true;
                        this.EntradaPago.Size = new System.Drawing.Size(152, 32);
                        this.EntradaPago.Sufijo = "";
                        this.EntradaPago.TabIndex = 3;
                        this.EntradaPago.Text = "0.00";
                        this.EntradaPago.TextChanged += new System.EventHandler(this.EntradaPago_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(48, 140);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(164, 32);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Pago del Cliente";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCambio
                        // 
                        this.EntradaCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.EntradaCambio.AutoNav = true;
                        this.EntradaCambio.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCambio.DecimalPlaces = -1;
                        this.EntradaCambio.FieldName = null;
                        this.EntradaCambio.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCambio.Location = new System.Drawing.Point(212, 216);
                        this.EntradaCambio.MaxLength = 32767;
                        this.EntradaCambio.MultiLine = false;
                        this.EntradaCambio.Name = "EntradaCambio";
                        this.EntradaCambio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCambio.PasswordChar = '\0';
                        this.EntradaCambio.PlaceholderText = null;
                        this.EntradaCambio.Prefijo = "$";
                        this.EntradaCambio.ReadOnly = false;
                        this.EntradaCambio.SelectOnFocus = true;
                        this.EntradaCambio.Size = new System.Drawing.Size(152, 32);
                        this.EntradaCambio.Sufijo = "";
                        this.EntradaCambio.TabIndex = 6;
                        this.EntradaCambio.TabStop = false;
                        this.EntradaCambio.Text = "0.00";
                        this.EntradaCambio.Visible = false;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(48, 216);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(164, 32);
                        this.Label3.TabIndex = 5;
                        this.Label3.Text = "Cambio";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.PictureBox1.Location = new System.Drawing.Point(36, 192);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(344, 4);
                        this.PictureBox1.TabIndex = 51;
                        this.PictureBox1.TabStop = false;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(24, 28);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(372, 20);
                        this.Label4.TabIndex = 52;
                        this.Label4.Text = "Escriba el importe recibido para calcular el cambio.";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(24, 48);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(372, 20);
                        this.Label5.TabIndex = 53;
                        this.Label5.Text = "O pulse la tecla <Esc> para cancelar.";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // PagoVuelto
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(418, 355);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.EntradaCambio);
                        this.Controls.Add(this.EntradaPago);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label1);
                        this.Name = "PagoVuelto";
                        this.Text = "Pago: Cambio";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaPago, 0);
                        this.Controls.SetChildIndex(this.EntradaCambio, 0);
                        this.Controls.SetChildIndex(this.PictureBox1, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                public decimal Total
                {
                        get
                        {
                                return EntradaTotal.ValueDecimal;
                        }
                        set
                        {
                                EntradaTotal.ValueDecimal = value;
                        }
                }

                private void EntradaPago_TextChanged(object sender, System.EventArgs e)
                {
                        EntradaCambio.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(EntradaPago.Text) - Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text), Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales);
                        EntradaCambio.Visible = Lfx.Types.Parsing.ParseCurrency(EntradaCambio.Text) >= 0;
                }
        }
}
