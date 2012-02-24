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
                private Lui.Forms.FormHeader formHeader1;
                internal System.Windows.Forms.PictureBox PictureBox1;

                private void InitializeComponent()
                {
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.EntradaPago = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaCambio = new Lui.Forms.TextBox();
                        this.Label3 = new Lui.Forms.Label();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.formHeader1 = new Lui.Forms.FormHeader();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label1.Location = new System.Drawing.Point(48, 92);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(164, 32);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Importe a cobrar";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Bigger;
                        this.EntradaTotal.Location = new System.Drawing.Point(212, 92);
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.Size = new System.Drawing.Size(152, 32);
                        this.EntradaTotal.TabIndex = 1;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        // 
                        // EntradaPago
                        // 
                        this.EntradaPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.EntradaPago.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaPago.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Bigger;
                        this.EntradaPago.Location = new System.Drawing.Point(212, 140);
                        this.EntradaPago.Name = "EntradaPago";
                        this.EntradaPago.Prefijo = "$";
                        this.EntradaPago.Size = new System.Drawing.Size(152, 32);
                        this.EntradaPago.TabIndex = 3;
                        this.EntradaPago.Text = "0.00";
                        this.EntradaPago.TextChanged += new System.EventHandler(this.EntradaPago_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label2.Location = new System.Drawing.Point(48, 140);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(164, 32);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Pago recibido";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCambio
                        // 
                        this.EntradaCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.EntradaCambio.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCambio.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Bigger;
                        this.EntradaCambio.Location = new System.Drawing.Point(212, 216);
                        this.EntradaCambio.Name = "EntradaCambio";
                        this.EntradaCambio.Prefijo = "$";
                        this.EntradaCambio.Size = new System.Drawing.Size(152, 32);
                        this.EntradaCambio.TabIndex = 6;
                        this.EntradaCambio.TabStop = false;
                        this.EntradaCambio.Text = "0.00";
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
                        this.Label3.Location = new System.Drawing.Point(48, 216);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(164, 32);
                        this.Label3.TabIndex = 5;
                        this.Label3.Text = "Cambio a entregar";
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
                        // formHeader1
                        // 
                        this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.formHeader1.Location = new System.Drawing.Point(0, 0);
                        this.formHeader1.Name = "formHeader1";
                        this.formHeader1.Size = new System.Drawing.Size(418, 64);
                        this.formHeader1.TabIndex = 60;
                        this.formHeader1.Text = "Cambio";
                        // 
                        // PagoVuelto
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(418, 355);
                        this.Controls.Add(this.formHeader1);
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
                        this.Controls.SetChildIndex(this.formHeader1, 0);
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
                }
        }
}
