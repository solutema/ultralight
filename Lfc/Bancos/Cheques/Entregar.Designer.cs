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

namespace Lfc.Bancos.Cheques
{
        public partial class Entregar
        {
                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el diseñador
                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaCantidad = new Lui.Forms.TextBox();
                        this.lblLabel1 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaPersona = new Lcc.Entrada.CodigoDetalle();
                        this.label6 = new Lui.Forms.Label();
                        this.EtiquetaTitulo = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(24, 176);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(112, 24);
                        this.label3.TabIndex = 7;
                        this.label3.Text = "En concepto de";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.Location = new System.Drawing.Point(136, 176);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Required = false;
                        this.EntradaConcepto.Size = new System.Drawing.Size(472, 24);
                        this.EntradaConcepto.TabIndex = 8;
                        this.EntradaConcepto.NombreTipo = "Lbl.Cajas.Concepto";
                        this.EntradaConcepto.Text = "0";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Location = new System.Drawing.Point(136, 208);
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Size = new System.Drawing.Size(472, 72);
                        this.EntradaObs.TabIndex = 10;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(24, 208);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(112, 24);
                        this.Label4.TabIndex = 9;
                        this.Label4.Text = "Observaciones";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSubTotal
                        // 
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.Location = new System.Drawing.Point(376, 112);
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.Size = new System.Drawing.Size(108, 24);
                        this.EntradaSubTotal.TabIndex = 4;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(200, 112);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(176, 24);
                        this.Label1.TabIndex = 3;
                        this.Label1.Text = "cheque(s) por un total de";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCantidad.Location = new System.Drawing.Point(136, 112);
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCantidad.TabIndex = 2;
                        this.EntradaCantidad.TabStop = false;
                        this.EntradaCantidad.Text = "0";
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.Location = new System.Drawing.Point(24, 112);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(112, 24);
                        this.lblLabel1.TabIndex = 1;
                        this.lblLabel1.Text = "Entrega de";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(24, 144);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(112, 24);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "A";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // gDetailBox1
                        // 
                        this.EntradaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPersona.AutoTab = true;
                        this.EntradaPersona.CanCreate = true;
                        this.EntradaPersona.Filter = "";
                        this.EntradaPersona.Location = new System.Drawing.Point(136, 144);
                        this.EntradaPersona.MaxLength = 200;
                        this.EntradaPersona.Name = "gDetailBox1";
                        this.EntradaPersona.Required = false;
                        this.EntradaPersona.Size = new System.Drawing.Size(472, 24);
                        this.EntradaPersona.TabIndex = 6;
                        this.EntradaPersona.NombreTipo = "Lbl.Personas.Persona";
                        this.EntradaPersona.Text = "0";
                        // 
                        // label6
                        // 
                        this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label6.Location = new System.Drawing.Point(24, 56);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(584, 48);
                        this.label6.TabIndex = 54;
                        this.label6.Text = "Va a realizar un egreso del cheque sin efectivizar (por ejemplo, al realizar un p" +
    "ago con cheques de terceros).";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.AutoSize = true;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(24, 24);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(218, 30);
                        this.EtiquetaTitulo.TabIndex = 53;
                        this.EtiquetaTitulo.Text = "Entrega de cheque(s)";
                        this.EtiquetaTitulo.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        // 
                        // Entregar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 371);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaPersona);
                        this.Controls.Add(this.EntradaSubTotal);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.lblLabel1);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EntradaConcepto);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "Entregar";
                        this.Text = "Entrega de cheque(s)";
                        this.Controls.SetChildIndex(this.EntradaConcepto, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.Controls.SetChildIndex(this.lblLabel1, 0);
                        this.Controls.SetChildIndex(this.EntradaCantidad, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaSubTotal, 0);
                        this.Controls.SetChildIndex(this.EntradaPersona, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion


                internal Lui.Forms.Label label3;
                internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaCantidad;
                internal Lui.Forms.Label lblLabel1;
                internal Lui.Forms.Label label2;
                internal Lcc.Entrada.CodigoDetalle EntradaPersona;
                private System.ComponentModel.IContainer components = null;
                private Lui.Forms.Label label6;
                private Lui.Forms.Label EtiquetaTitulo;
        }
}
