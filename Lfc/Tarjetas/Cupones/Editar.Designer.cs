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
                        this.Label3 = new System.Windows.Forms.Label();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaTarjeta = new Lcc.Entrada.CodigoDetalle();
                        this.label10 = new System.Windows.Forms.Label();
                        this.EntradaPlan = new Lcc.Entrada.CodigoDetalle();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaFechaPresentacion = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaFechaAcreditacion = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNumero.Location = new System.Drawing.Point(160, 0);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(112, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 1;
                        this.EntradaNumero.PlaceholderText = "";
                        this.EntradaNumero.ToolTipText = "";
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
                        this.label4.Text = "Medio de Pago";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTarjeta
                        // 
                        this.EntradaTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTarjeta.AutoNav = true;
                        this.EntradaTarjeta.AutoTab = true;
                        this.EntradaTarjeta.CanCreate = false;
                        this.EntradaTarjeta.DataTextField = "nombre";
                        this.EntradaTarjeta.DataValueField = "id_tarjeta";
                        this.EntradaTarjeta.ExtraDetailFields = null;
                        this.EntradaTarjeta.Filter = "";
                        this.EntradaTarjeta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTarjeta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTarjeta.FreeTextCode = "";
                        this.EntradaTarjeta.Location = new System.Drawing.Point(160, 28);
                        this.EntradaTarjeta.MaxLength = 200;
                        this.EntradaTarjeta.Name = "EntradaTarjeta";
                        this.EntradaTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarjeta.ReadOnly = false;
                        this.EntradaTarjeta.Required = true;
                        this.EntradaTarjeta.Size = new System.Drawing.Size(480, 24);
                        this.EntradaTarjeta.TabIndex = 3;
                        this.EntradaTarjeta.Table = "tarjetas";
                        this.EntradaTarjeta.Text = "0";
                        this.EntradaTarjeta.TextDetail = "";
                        this.EntradaTarjeta.PlaceholderText = "Todas";
                        this.EntradaTarjeta.ToolTipText = "Sucursal";
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
                        this.EntradaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPlan.AutoNav = true;
                        this.EntradaPlan.AutoTab = true;
                        this.EntradaPlan.CanCreate = true;
                        this.EntradaPlan.DataTextField = "nombre";
                        this.EntradaPlan.DataValueField = "id_plan";
                        this.EntradaPlan.ExtraDetailFields = null;
                        this.EntradaPlan.Filter = "";
                        this.EntradaPlan.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPlan.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPlan.FreeTextCode = "";
                        this.EntradaPlan.Location = new System.Drawing.Point(160, 56);
                        this.EntradaPlan.MaxLength = 200;
                        this.EntradaPlan.Name = "EntradaPlan";
                        this.EntradaPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPlan.ReadOnly = false;
                        this.EntradaPlan.Required = true;
                        this.EntradaPlan.Size = new System.Drawing.Size(480, 24);
                        this.EntradaPlan.TabIndex = 5;
                        this.EntradaPlan.Table = "tarjetas_planes";
                        this.EntradaPlan.Text = "0";
                        this.EntradaPlan.TextDetail = "";
                        this.EntradaPlan.PlaceholderText = "Ninguna";
                        this.EntradaPlan.ToolTipText = "Impresora";
                        // 
                        // label1
                        // 
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
                        this.EntradaFechaPresentacion.AutoTab = true;
                        this.EntradaFechaPresentacion.DataType = Lui.Forms.DataTypes.DateTime;
                        this.EntradaFechaPresentacion.DecimalPlaces = -1;
                        this.EntradaFechaPresentacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaPresentacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFechaPresentacion.Location = new System.Drawing.Point(160, 84);
                        this.EntradaFechaPresentacion.MaxLenght = 32767;
                        this.EntradaFechaPresentacion.MultiLine = false;
                        this.EntradaFechaPresentacion.Name = "EntradaFechaPresentacion";
                        this.EntradaFechaPresentacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaPresentacion.PasswordChar = '\0';
                        this.EntradaFechaPresentacion.Prefijo = "";
                        this.EntradaFechaPresentacion.ReadOnly = false;
                        this.EntradaFechaPresentacion.SelectOnFocus = true;
                        this.EntradaFechaPresentacion.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaPresentacion.Sufijo = "";
                        this.EntradaFechaPresentacion.TabIndex = 7;
                        this.EntradaFechaPresentacion.PlaceholderText = "";
                        this.EntradaFechaPresentacion.ToolTipText = "";
                        // 
                        // label2
                        // 
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
                        this.EntradaFechaAcreditacion.AutoTab = true;
                        this.EntradaFechaAcreditacion.DataType = Lui.Forms.DataTypes.DateTime;
                        this.EntradaFechaAcreditacion.DecimalPlaces = -1;
                        this.EntradaFechaAcreditacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaAcreditacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaAcreditacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFechaAcreditacion.Location = new System.Drawing.Point(160, 112);
                        this.EntradaFechaAcreditacion.MaxLenght = 32767;
                        this.EntradaFechaAcreditacion.MultiLine = false;
                        this.EntradaFechaAcreditacion.Name = "EntradaFechaAcreditacion";
                        this.EntradaFechaAcreditacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaAcreditacion.PasswordChar = '\0';
                        this.EntradaFechaAcreditacion.Prefijo = "";
                        this.EntradaFechaAcreditacion.ReadOnly = false;
                        this.EntradaFechaAcreditacion.SelectOnFocus = true;
                        this.EntradaFechaAcreditacion.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaAcreditacion.Sufijo = "";
                        this.EntradaFechaAcreditacion.TabIndex = 9;
                        this.EntradaFechaAcreditacion.PlaceholderText = "";
                        this.EntradaFechaAcreditacion.ToolTipText = "";
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
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaTarjeta, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.label10, 0);
                        this.Controls.SetChildIndex(this.EntradaPlan, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaPresentacion, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaAcreditacion, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                internal Lui.Forms.TextBox EntradaNumero;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label label4;
                internal Lcc.Entrada.CodigoDetalle EntradaTarjeta;
                internal System.Windows.Forms.Label label10;
                internal Lcc.Entrada.CodigoDetalle EntradaPlan;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaFechaPresentacion;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaAcreditacion;
        }
}
