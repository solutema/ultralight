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

namespace Lfc.Tarjetas.Cupones
{
        public partial class Editar
        {
		private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Designer generated code

                private void InitializeComponent()
                {
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.Label3 = new Lui.Forms.Label();
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaFormaPago = new Lcc.Entrada.CodigoDetalle();
                        this.label10 = new Lui.Forms.Label();
                        this.EntradaPlan = new Lcc.Entrada.CodigoDetalle();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaFechaPresentacion = new Lui.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaFechaAcreditacion = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.Location = new System.Drawing.Point(160, 0);
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.Size = new System.Drawing.Size(112, 24);
                        this.EntradaNumero.TabIndex = 1;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(0, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(160, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Número";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 28);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(160, 24);
                        this.label4.TabIndex = 2;
                        this.label4.Text = "Forma de pago";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFormaPago
                        // 
                        this.EntradaFormaPago.CanCreate = false;
                        this.EntradaFormaPago.DataTextField = "nombre";
                        this.EntradaFormaPago.DataValueField = "id_formapago";
                        this.EntradaFormaPago.ExtraDetailFields = "";
                        this.EntradaFormaPago.Filter = "";
                        this.EntradaFormaPago.FreeTextCode = "";
                        this.EntradaFormaPago.Location = new System.Drawing.Point(160, 28);
                        this.EntradaFormaPago.MaxLength = 200;
                        this.EntradaFormaPago.Name = "EntradaFormaPago";
                        this.EntradaFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPago.PlaceholderText = "Forma de pago";
                        this.EntradaFormaPago.ReadOnly = false;
                        this.EntradaFormaPago.Required = true;
                        this.EntradaFormaPago.Size = new System.Drawing.Size(480, 24);
                        this.EntradaFormaPago.TabIndex = 3;
                        this.EntradaFormaPago.Table = "formaspago";
                        this.EntradaFormaPago.Text = "0";
                        this.EntradaFormaPago.TextDetail = "";
                        // 
                        // label10
                        // 
                        this.label10.Location = new System.Drawing.Point(0, 56);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(160, 24);
                        this.label10.TabIndex = 4;
                        this.label10.Text = "Plan";
                        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPlan
                        // 
                        this.EntradaPlan.CanCreate = true;
                        this.EntradaPlan.DataTextField = "nombre";
                        this.EntradaPlan.DataValueField = "id_plan";
                        this.EntradaPlan.ExtraDetailFields = "";
                        this.EntradaPlan.Filter = "";
                        this.EntradaPlan.FreeTextCode = "";
                        this.EntradaPlan.Location = new System.Drawing.Point(160, 56);
                        this.EntradaPlan.MaxLength = 200;
                        this.EntradaPlan.Name = "EntradaPlan";
                        this.EntradaPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPlan.PlaceholderText = "Plan";
                        this.EntradaPlan.ReadOnly = false;
                        this.EntradaPlan.Required = true;
                        this.EntradaPlan.Size = new System.Drawing.Size(480, 24);
                        this.EntradaPlan.TabIndex = 5;
                        this.EntradaPlan.Table = "tarjetas_planes";
                        this.EntradaPlan.Text = "0";
                        this.EntradaPlan.TextDetail = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(0, 84);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(160, 24);
                        this.label1.TabIndex = 6;
                        this.label1.Text = "Fecha de presentación";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaPresentacion
                        // 
                        this.EntradaFechaPresentacion.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaPresentacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaPresentacion.Location = new System.Drawing.Point(160, 84);
                        this.EntradaFechaPresentacion.Name = "EntradaFechaPresentacion";
                        this.EntradaFechaPresentacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaPresentacion.ReadOnly = false;
                        this.EntradaFechaPresentacion.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaPresentacion.TabIndex = 7;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 112);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(160, 24);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "Fecha de acreditación";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaAcreditacion
                        // 
                        this.EntradaFechaAcreditacion.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaAcreditacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaAcreditacion.Location = new System.Drawing.Point(160, 112);
                        this.EntradaFechaAcreditacion.Name = "EntradaFechaAcreditacion";
                        this.EntradaFechaAcreditacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaAcreditacion.ReadOnly = false;
                        this.EntradaFechaAcreditacion.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaAcreditacion.TabIndex = 9;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaFechaAcreditacion);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaFechaPresentacion);
                        this.Controls.Add(this.EntradaPlan);
                        this.Controls.Add(this.label10);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaFormaPago);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaNumero);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.TextBox EntradaNumero;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label label4;
                internal Lcc.Entrada.CodigoDetalle EntradaFormaPago;
                internal Lui.Forms.Label label10;
                internal Lcc.Entrada.CodigoDetalle EntradaPlan;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaFechaPresentacion;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaAcreditacion;
        }
}
