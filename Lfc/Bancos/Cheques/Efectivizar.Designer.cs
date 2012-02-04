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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal Lui.Forms.Label lblLabel1;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.TextBox EntradaTotal;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaCajaDestino;

                private void InitializeComponent()
                {
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.lblLabel1 = new Lui.Forms.Label();
                        this.EntradaGestionDeCobro = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label8 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaCajaDestino = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaImpuestos = new Lui.Forms.TextBox();
                        this.label4 = new Lui.Forms.Label();
                        this.label5 = new Lui.Forms.Label();
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
                        // EntradaSubTotal
                        // 
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSubTotal.Location = new System.Drawing.Point(332, 68);
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.ReadOnly = false;
                        this.EntradaSubTotal.Size = new System.Drawing.Size(108, 24);
                        this.EntradaSubTotal.TabIndex = 4;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        this.EntradaSubTotal.TextChanged += new System.EventHandler(this.EntradaImportes_TextChanged);
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.Location = new System.Drawing.Point(60, 68);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(296, 24);
                        this.lblLabel1.TabIndex = 1;
                        this.lblLabel1.Text = "Acreditación de cheque por un valor de";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGestionDeCobro
                        // 
                        this.EntradaGestionDeCobro.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaGestionDeCobro.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGestionDeCobro.Location = new System.Drawing.Point(332, 100);
                        this.EntradaGestionDeCobro.Name = "EntradaGestionDeCobro";
                        this.EntradaGestionDeCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGestionDeCobro.Prefijo = "$";
                        this.EntradaGestionDeCobro.ReadOnly = false;
                        this.EntradaGestionDeCobro.Size = new System.Drawing.Size(108, 24);
                        this.EntradaGestionDeCobro.TabIndex = 6;
                        this.EntradaGestionDeCobro.Text = "0.00";
                        this.EntradaGestionDeCobro.TextChanged += new System.EventHandler(this.EntradaImportes_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(188, 100);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(132, 24);
                        this.Label2.TabIndex = 5;
                        this.Label2.Text = "- Gestión de Cobro";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.Location = new System.Drawing.Point(212, 196);
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = false;
                        this.EntradaTotal.Size = new System.Drawing.Size(136, 28);
                        this.EntradaTotal.TabIndex = 10;
                        this.EntradaTotal.Text = "0.00";
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(60, 196);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(160, 28);
                        this.Label8.TabIndex = 9;
                        this.Label8.Text = "Se van a acreditar";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(60, 232);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(160, 24);
                        this.Label3.TabIndex = 11;
                        this.Label3.Text = "En la siguiente cuenta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCajaDestino
                        // 
                        this.EntradaCajaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCajaDestino.CanCreate = false;
                        this.EntradaCajaDestino.DataTextField = "nombre";
                        this.EntradaCajaDestino.DataValueField = "id_caja";
                        this.EntradaCajaDestino.ExtraDetailFields = "";
                        this.EntradaCajaDestino.Filter = "";
                        this.EntradaCajaDestino.FreeTextCode = "";
                        this.EntradaCajaDestino.Location = new System.Drawing.Point(212, 232);
                        this.EntradaCajaDestino.MaxLength = 200;
                        this.EntradaCajaDestino.Name = "EntradaCajaDestino";
                        this.EntradaCajaDestino.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCajaDestino.ReadOnly = false;
                        this.EntradaCajaDestino.Required = true;
                        this.EntradaCajaDestino.Size = new System.Drawing.Size(348, 24);
                        this.EntradaCajaDestino.TabIndex = 12;
                        this.EntradaCajaDestino.Table = "cajas";
                        this.EntradaCajaDestino.Text = "0";
                        this.EntradaCajaDestino.TextDetail = "";
                        // 
                        // EntradaImpuestos
                        // 
                        this.EntradaImpuestos.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImpuestos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImpuestos.Location = new System.Drawing.Point(332, 128);
                        this.EntradaImpuestos.Name = "EntradaImpuestos";
                        this.EntradaImpuestos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImpuestos.Prefijo = "$";
                        this.EntradaImpuestos.ReadOnly = false;
                        this.EntradaImpuestos.Size = new System.Drawing.Size(108, 24);
                        this.EntradaImpuestos.TabIndex = 8;
                        this.EntradaImpuestos.Text = "0.00";
                        this.EntradaImpuestos.TextChanged += new System.EventHandler(this.EntradaImportes_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(188, 128);
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
                        this.Controls.Add(this.EntradaCajaDestino);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaImpuestos);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaGestionDeCobro);
                        this.Controls.Add(this.EntradaSubTotal);
                        this.Controls.Add(this.lblLabel1);
                        this.Name = "Efectivizar";
                        this.Text = "Efectivizar";
                        this.Controls.SetChildIndex(this.lblLabel1, 0);
                        this.Controls.SetChildIndex(this.EntradaSubTotal, 0);
                        this.Controls.SetChildIndex(this.EntradaGestionDeCobro, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaImpuestos, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaCajaDestino, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.TextBox EntradaGestionDeCobro;
                internal Lui.Forms.TextBox EntradaImpuestos;
                internal Lui.Forms.Label label4;
                internal Lui.Forms.Label label5;
        }
}
