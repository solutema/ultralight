#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lfc.Cajas
{
        public partial class Movimiento
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
                        this.EntradaDestino = new Lcc.Entrada.CodigoDetalle();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaComprob = new Lui.Forms.TextBox();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaOrigen = new Lcc.Entrada.CodigoDetalle();
                        this.Label6 = new Lui.Forms.Label();
                        this.EntradaImporteDestino = new Lui.Forms.TextBox();
                        this.lblImporteDestino = new Lui.Forms.Label();
                        this.label7 = new Lui.Forms.Label();
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
                        // EntradaDestino
                        // 
                        this.EntradaDestino.AutoTab = true;
                        this.EntradaDestino.CanCreate = false;
                        this.EntradaDestino.DataTextField = "nombre";
                        this.EntradaDestino.DockPadding.All = 2;
                        this.EntradaDestino.FreeTextCode = "";
                        this.EntradaDestino.DataValueField = "id_caja";
                        this.EntradaDestino.Location = new System.Drawing.Point(112, 100);
                        this.EntradaDestino.MaxLength = 200;
                        this.EntradaDestino.Name = "EntradaDestino";
                        this.EntradaDestino.TemporaryReadOnly = false;
                        this.EntradaDestino.Required = false;
                        this.EntradaDestino.Size = new System.Drawing.Size(356, 24);
                        this.EntradaDestino.TabIndex = 3;
                        this.EntradaDestino.Table = "cajas";
                        this.EntradaDestino.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaDestino.Text = "0";
                        this.EntradaDestino.TextDetail = "";
                        this.EntradaDestino.TextChanged += new System.EventHandler(this.EntradaOrigenDestino_TextChanged);
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
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporte.DockPadding.All = 2;
                        this.EntradaImporte.Location = new System.Drawing.Point(112, 132);
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.TemporaryReadOnly = false;
                        this.EntradaImporte.Size = new System.Drawing.Size(108, 24);
                        this.EntradaImporte.TabIndex = 5;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TextChanged += new System.EventHandler(this.EntradaImporte_TextChanged);
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
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = false;
                        this.EntradaConcepto.DataTextField = "nombre";
                        this.EntradaConcepto.DockPadding.All = 2;
                        this.EntradaConcepto.FreeTextCode = "*";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(112, 164);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.TemporaryReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.Size = new System.Drawing.Size(356, 24);
                        this.EntradaConcepto.TabIndex = 9;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
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
                        // EntradaObs
                        // 
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DockPadding.All = 2;
                        this.EntradaObs.Location = new System.Drawing.Point(112, 228);
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.TemporaryReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(464, 92);
                        this.EntradaObs.TabIndex = 13;
                        this.EntradaObs.Enter += new System.EventHandler(this.EntradaObs_Enter);
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
                        // EntradaComprob
                        // 
                        this.EntradaComprob.AutoNav = true;
                        this.EntradaComprob.AutoTab = true;
                        this.EntradaComprob.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaComprob.DockPadding.All = 2;
                        this.EntradaComprob.Location = new System.Drawing.Point(112, 196);
                        this.EntradaComprob.Name = "EntradaComprob";
                        this.EntradaComprob.TemporaryReadOnly = false;
                        this.EntradaComprob.Size = new System.Drawing.Size(240, 24);
                        this.EntradaComprob.TabIndex = 11;
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
                        // EntradaOrigen
                        // 
                        this.EntradaOrigen.AutoTab = true;
                        this.EntradaOrigen.CanCreate = false;
                        this.EntradaOrigen.DataTextField = "nombre";
                        this.EntradaOrigen.DockPadding.All = 2;
                        this.EntradaOrigen.FreeTextCode = "";
                        this.EntradaOrigen.DataValueField = "id_caja";
                        this.EntradaOrigen.Location = new System.Drawing.Point(112, 68);
                        this.EntradaOrigen.MaxLength = 200;
                        this.EntradaOrigen.Name = "EntradaOrigen";
                        this.EntradaOrigen.TemporaryReadOnly = true;
                        this.EntradaOrigen.Required = false;
                        this.EntradaOrigen.Size = new System.Drawing.Size(356, 24);
                        this.EntradaOrigen.TabIndex = 1;
                        this.EntradaOrigen.Table = "cajas";
                        this.EntradaOrigen.TabStop = false;
                        this.EntradaOrigen.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaOrigen.Text = "0";
                        this.EntradaOrigen.TextDetail = "";
                        this.EntradaOrigen.TextChanged += new System.EventHandler(this.EntradaOrigenDestino_TextChanged);
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
                        // EntradaImporteDestino
                        // 
                        this.EntradaImporteDestino.AutoNav = true;
                        this.EntradaImporteDestino.AutoTab = true;
                        this.EntradaImporteDestino.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporteDestino.DockPadding.All = 2;
                        this.EntradaImporteDestino.Location = new System.Drawing.Point(244, 132);
                        this.EntradaImporteDestino.Name = "EntradaImporteDestino";
                        this.EntradaImporteDestino.Prefijo = "$";
                        this.EntradaImporteDestino.TemporaryReadOnly = false;
                        this.EntradaImporteDestino.Size = new System.Drawing.Size(108, 24);
                        this.EntradaImporteDestino.TabIndex = 7;
                        this.EntradaImporteDestino.Text = "0.00";
                        this.EntradaImporteDestino.Visible = false;
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
                        this.label7.Location = new System.Drawing.Point(16, 16);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(560, 36);
                        this.label7.TabIndex = 51;
                        this.label7.Text = "Va a realizar un movimiento de dinero entre una cuenta y otra. Esto generará un e" +
                                "greso en la cuenta de origen y un ingreso en la cuenta de destino.";
                        // 
                        // Movimiento
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(594, 403);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaImporteDestino);
                        this.Controls.Add(this.lblImporteDestino);
                        this.Controls.Add(this.EntradaOrigen);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaComprob);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.EntradaConcepto);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaImporte);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaDestino);
                        this.Controls.Add(this.Label3);
                        this.Name = "Movimiento";
                        this.ResumeLayout(false);

                }

                #endregion

                protected Lui.Forms.Label Label3;
                protected Lui.Forms.TextBox EntradaImporte;
                protected Lui.Forms.Label Label2;
                protected internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
                protected Lui.Forms.Label Label1;
                protected Lui.Forms.TextBox EntradaObs;
                protected Lui.Forms.Label Label4;
                protected Lui.Forms.TextBox EntradaComprob;
                protected Lui.Forms.Label Label5;
                protected Lui.Forms.Label Label6;
                protected internal Lcc.Entrada.CodigoDetalle EntradaDestino;
                protected internal Lcc.Entrada.CodigoDetalle EntradaOrigen;
                protected Lui.Forms.TextBox EntradaImporteDestino;
                protected Lui.Forms.Label lblImporteDestino;
                protected int iMonedaOrigen;
                protected int iMonedaDestino;
                protected Lfx.Data.Row MonedaOrigen, MonedaDestino;
                protected Lui.Forms.Label label7;
        }
}
