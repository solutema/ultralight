#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.CuentasCorrientes
{
        public partial class Ajuste
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
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaDireccion = new Lui.Forms.ComboBox();
                        this.label5 = new Lui.Forms.Label();
                        this.EntradaNuevoSaldo = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
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
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoSize = false;
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.DataTextField = "nombre";
                        this.EntradaConcepto.ExtraDetailFields = null;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.FreeTextCode = "*";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(120, 24);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.TemporaryReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.Size = new System.Drawing.Size(496, 24);
                        this.EntradaConcepto.TabIndex = 1;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        this.EntradaConcepto.Leave += new System.EventHandler(this.EntradaConcepto_Leave);
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoSize = false;
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.Location = new System.Drawing.Point(120, 56);
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.TemporaryReadOnly = false;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(128, 24);
                        this.EntradaImporte.TabIndex = 3;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TextChanged += new System.EventHandler(this.EntradaImporte_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(24, 56);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(96, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Importe";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(24, 24);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(96, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Concepto";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoSize = false;
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.Location = new System.Drawing.Point(120, 120);
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.TemporaryReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(496, 92);
                        this.EntradaObs.TabIndex = 7;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(24, 120);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(96, 24);
                        this.Label4.TabIndex = 6;
                        this.Label4.Text = "Obs.";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDireccion
                        // 
                        this.EntradaDireccion.AutoSize = false;
                        this.EntradaDireccion.AutoNav = true;
                        this.EntradaDireccion.AutoTab = true;
                        this.EntradaDireccion.Location = new System.Drawing.Point(120, 88);
                        this.EntradaDireccion.Name = "EntradaDireccion";
                        this.EntradaDireccion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDireccion.TemporaryReadOnly = false;
                        this.EntradaDireccion.SetData = new string[] {
        "Débito|1",
        "Crédito|0"};
                        this.EntradaDireccion.Size = new System.Drawing.Size(128, 24);
                        this.EntradaDireccion.TabIndex = 5;
                        this.EntradaDireccion.Text = "Débito";
                        this.EntradaDireccion.TextKey = "1";
                        this.EntradaDireccion.TextChanged += new System.EventHandler(this.EntradaDireccion_TextChanged);
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(24, 88);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(96, 24);
                        this.label5.TabIndex = 4;
                        this.label5.Text = "Dirección";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNuevoSaldo
                        // 
                        this.EntradaNuevoSaldo.AutoSize = false;
                        this.EntradaNuevoSaldo.AutoNav = true;
                        this.EntradaNuevoSaldo.AutoTab = true;
                        this.EntradaNuevoSaldo.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaNuevoSaldo.DecimalPlaces = -1;
                        this.EntradaNuevoSaldo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNuevoSaldo.Location = new System.Drawing.Point(376, 56);
                        this.EntradaNuevoSaldo.MultiLine = false;
                        this.EntradaNuevoSaldo.Name = "EntradaNuevoSaldo";
                        this.EntradaNuevoSaldo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNuevoSaldo.Prefijo = "$";
                        this.EntradaNuevoSaldo.TemporaryReadOnly = true;
                        this.EntradaNuevoSaldo.SelectOnFocus = true;
                        this.EntradaNuevoSaldo.Size = new System.Drawing.Size(128, 24);
                        this.EntradaNuevoSaldo.TabIndex = 52;
                        this.EntradaNuevoSaldo.TabStop = false;
                        this.EntradaNuevoSaldo.Text = "0.00";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(280, 56);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(96, 24);
                        this.label3.TabIndex = 51;
                        this.label3.Text = "Nuevo Saldo";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Ajuste
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 375);
                        this.Controls.Add(this.EntradaNuevoSaldo);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EntradaDireccion);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaConcepto);
                        this.Controls.Add(this.EntradaImporte);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Name = "Ajuste";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaImporte, 0);
                        this.Controls.SetChildIndex(this.EntradaConcepto, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.EntradaDireccion, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaNuevoSaldo, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
                internal Lui.Forms.TextBox EntradaImporte;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label label5;
                internal Lui.Forms.ComboBox EntradaDireccion;
                internal Lui.Forms.TextBox EntradaNuevoSaldo;
                internal Lui.Forms.Label label3;
        }
}
