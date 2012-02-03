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
                        this.EntradaTarjeta = new Lcc.Entrada.CodigoDetalle();
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
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.FieldName = null;
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.Location = new System.Drawing.Point(160, 0);
                        this.EntradaNumero.MaxLength = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.PlaceholderText = null;
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(112, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 1;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(0, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(160, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Número";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label4
                        // 
                        this.label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label4.Location = new System.Drawing.Point(0, 28);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(160, 24);
                        this.label4.TabIndex = 2;
                        this.label4.Text = "Medio de Pago";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTarjeta
                        // 
                        this.EntradaTarjeta.AutoNav = true;
                        this.EntradaTarjeta.CanCreate = false;
                        this.EntradaTarjeta.DataTextField = "nombre";
                        this.EntradaTarjeta.DataValueField = "id_tarjeta";
                        this.EntradaTarjeta.ExtraDetailFields = "";
                        this.EntradaTarjeta.FieldName = null;
                        this.EntradaTarjeta.Filter = "";
                        this.EntradaTarjeta.FreeTextCode = "";
                        this.EntradaTarjeta.Location = new System.Drawing.Point(160, 28);
                        this.EntradaTarjeta.MaxLength = 200;
                        this.EntradaTarjeta.Name = "EntradaTarjeta";
                        this.EntradaTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarjeta.PlaceholderText = "Sucursal";
                        this.EntradaTarjeta.ReadOnly = false;
                        this.EntradaTarjeta.Required = true;
                        this.EntradaTarjeta.Size = new System.Drawing.Size(480, 24);
                        this.EntradaTarjeta.TabIndex = 3;
                        this.EntradaTarjeta.Table = "tarjetas";
                        this.EntradaTarjeta.Text = "0";
                        this.EntradaTarjeta.TextDetail = "";
                        // 
                        // label10
                        // 
                        this.label10.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label10.Location = new System.Drawing.Point(0, 56);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(160, 24);
                        this.label10.TabIndex = 4;
                        this.label10.Text = "Plan";
                        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPlan
                        // 
                        this.EntradaPlan.AutoNav = true;
                        this.EntradaPlan.CanCreate = true;
                        this.EntradaPlan.DataTextField = "nombre";
                        this.EntradaPlan.DataValueField = "id_plan";
                        this.EntradaPlan.ExtraDetailFields = "";
                        this.EntradaPlan.FieldName = null;
                        this.EntradaPlan.Filter = "";
                        this.EntradaPlan.FreeTextCode = "";
                        this.EntradaPlan.Location = new System.Drawing.Point(160, 56);
                        this.EntradaPlan.MaxLength = 200;
                        this.EntradaPlan.Name = "EntradaPlan";
                        this.EntradaPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPlan.PlaceholderText = "Impresora";
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
                        this.label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label1.Location = new System.Drawing.Point(0, 84);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(160, 24);
                        this.label1.TabIndex = 6;
                        this.label1.Text = "Fecha de Presentación";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaPresentacion
                        // 
                        this.EntradaFechaPresentacion.AutoNav = true;
                        this.EntradaFechaPresentacion.DataType = Lui.Forms.DataTypes.DateTime;
                        this.EntradaFechaPresentacion.DecimalPlaces = -1;
                        this.EntradaFechaPresentacion.FieldName = null;
                        this.EntradaFechaPresentacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaPresentacion.Location = new System.Drawing.Point(160, 84);
                        this.EntradaFechaPresentacion.MaxLength = 32767;
                        this.EntradaFechaPresentacion.MultiLine = false;
                        this.EntradaFechaPresentacion.Name = "EntradaFechaPresentacion";
                        this.EntradaFechaPresentacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaPresentacion.PasswordChar = '\0';
                        this.EntradaFechaPresentacion.PlaceholderText = null;
                        this.EntradaFechaPresentacion.Prefijo = "";
                        this.EntradaFechaPresentacion.ReadOnly = false;
                        this.EntradaFechaPresentacion.SelectOnFocus = true;
                        this.EntradaFechaPresentacion.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaPresentacion.Sufijo = "";
                        this.EntradaFechaPresentacion.TabIndex = 7;
                        // 
                        // label2
                        // 
                        this.label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label2.Location = new System.Drawing.Point(0, 112);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(160, 24);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "Fecha de Acreditación";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaAcreditacion
                        // 
                        this.EntradaFechaAcreditacion.AutoNav = true;
                        this.EntradaFechaAcreditacion.DataType = Lui.Forms.DataTypes.DateTime;
                        this.EntradaFechaAcreditacion.DecimalPlaces = -1;
                        this.EntradaFechaAcreditacion.FieldName = null;
                        this.EntradaFechaAcreditacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaAcreditacion.Location = new System.Drawing.Point(160, 112);
                        this.EntradaFechaAcreditacion.MaxLength = 32767;
                        this.EntradaFechaAcreditacion.MultiLine = false;
                        this.EntradaFechaAcreditacion.Name = "EntradaFechaAcreditacion";
                        this.EntradaFechaAcreditacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaAcreditacion.PasswordChar = '\0';
                        this.EntradaFechaAcreditacion.PlaceholderText = null;
                        this.EntradaFechaAcreditacion.Prefijo = "";
                        this.EntradaFechaAcreditacion.ReadOnly = false;
                        this.EntradaFechaAcreditacion.SelectOnFocus = true;
                        this.EntradaFechaAcreditacion.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaAcreditacion.Sufijo = "";
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
                        this.Controls.Add(this.EntradaTarjeta);
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
                internal Lcc.Entrada.CodigoDetalle EntradaTarjeta;
                internal Lui.Forms.Label label10;
                internal Lcc.Entrada.CodigoDetalle EntradaPlan;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaFechaPresentacion;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaAcreditacion;
        }
}
