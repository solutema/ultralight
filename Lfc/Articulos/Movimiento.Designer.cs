#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Articulos
{
        public partial class Movimiento
        {
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.ComboBox EntradaMovimiento;
                internal Lui.Forms.TextBox EntradaCantidad;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.TextBox EntradaStockActual;
                internal Lui.Forms.TextBox EntradaStockResult;
                internal Lcc.Entrada.CodigoDetalle EntradaDesdeSituacion;
                internal System.Windows.Forms.Label Label7;
                internal Lcc.Entrada.CodigoDetalle EntradaHaciaSituacion;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.TextBox EntradaStockResult2;
                internal Lui.Forms.TextBox EntradaStockActual2;
                internal System.Windows.Forms.Label lblDesdeSituacion;
                internal System.Windows.Forms.Label lblHaciaSituacion;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label6;
                public Lcc.Entrada.Articulos.DetalleComprobante EntradaArticulo;
                internal System.Windows.Forms.Label lblStockFlecha2;
                internal System.Windows.Forms.Label lblStockFlecha;

                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }

                        base.Dispose(disposing);
                }

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaMovimiento = new Lui.Forms.ComboBox();
                        this.EntradaCantidad = new Lui.Forms.TextBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.lblDesdeSituacion = new System.Windows.Forms.Label();
                        this.lblHaciaSituacion = new System.Windows.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.EntradaStockResult = new Lui.Forms.TextBox();
                        this.EntradaDesdeSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaHaciaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.EntradaStockResult2 = new Lui.Forms.TextBox();
                        this.EntradaStockActual2 = new Lui.Forms.TextBox();
                        this.lblStockFlecha = new System.Windows.Forms.Label();
                        this.lblStockFlecha2 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EntradaArticulo = new Lcc.Entrada.Articulos.DetalleComprobante();
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
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(16, 16);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(108, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Artículo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(16, 48);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(108, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Cantidad";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(16, 272);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(108, 24);
                        this.Label3.TabIndex = 20;
                        this.Label3.Text = "Obs.";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(16, 84);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(108, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "Movimiento";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMovimiento
                        // 
                        this.EntradaMovimiento.AutoSize = false;
                        this.EntradaMovimiento.AutoNav = true;
                        this.EntradaMovimiento.AutoTab = true;
                        this.EntradaMovimiento.DetailField = null;
                        this.EntradaMovimiento.Filter = null;
                        this.EntradaMovimiento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaMovimiento.KeyField = null;
                        this.EntradaMovimiento.Location = new System.Drawing.Point(124, 84);
                        this.EntradaMovimiento.MaxLenght = 32767;
                        this.EntradaMovimiento.Name = "EntradaMovimiento";
                        this.EntradaMovimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMovimiento.ReadOnly = false;
                        this.EntradaMovimiento.SetData = new string[] {
        " |*",
        "Entrada|e",
        "Salida|s"};
                        this.EntradaMovimiento.Size = new System.Drawing.Size(192, 24);
                        this.EntradaMovimiento.TabIndex = 5;
                        this.EntradaMovimiento.Table = null;
                        this.EntradaMovimiento.Text = " ";
                        this.EntradaMovimiento.TextKey = "*";
                        this.EntradaMovimiento.TipWhenBlank = "";
                        this.EntradaMovimiento.ToolTipText = "";
                        this.EntradaMovimiento.TextChanged += new System.EventHandler(this.EntradaMovimiento_TextChanged);
                        // 
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.AutoSize = false;
                        this.EntradaCantidad.AutoNav = true;
                        this.EntradaCantidad.AutoTab = true;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaCantidad.DecimalPlaces = -1;
                        this.EntradaCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCantidad.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCantidad.Location = new System.Drawing.Point(124, 48);
                        this.EntradaCantidad.MaxLenght = 32767;
                        this.EntradaCantidad.MultiLine = false;
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCantidad.PasswordChar = '\0';
                        this.EntradaCantidad.Prefijo = "";
                        this.EntradaCantidad.ReadOnly = false;
                        this.EntradaCantidad.SelectOnFocus = true;
                        this.EntradaCantidad.Size = new System.Drawing.Size(96, 24);
                        this.EntradaCantidad.Sufijo = "";
                        this.EntradaCantidad.TabIndex = 3;
                        this.EntradaCantidad.Text = "0.0000";
                        this.EntradaCantidad.TipWhenBlank = "";
                        this.EntradaCantidad.ToolTipText = "";
                        this.EntradaCantidad.TextChanged += new System.EventHandler(this.EntradaArticulo_TextChanged);
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
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.Location = new System.Drawing.Point(124, 272);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = false;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = true;
                        this.EntradaObs.Size = new System.Drawing.Size(496, 24);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 21;
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
                        // 
                        // lblDesdeSituacion
                        // 
                        this.lblDesdeSituacion.Location = new System.Drawing.Point(40, 204);
                        this.lblDesdeSituacion.Name = "lblDesdeSituacion";
                        this.lblDesdeSituacion.Size = new System.Drawing.Size(168, 24);
                        this.lblDesdeSituacion.TabIndex = 12;
                        this.lblDesdeSituacion.Text = "Situación 1";
                        this.lblDesdeSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHaciaSituacion
                        // 
                        this.lblHaciaSituacion.Location = new System.Drawing.Point(40, 236);
                        this.lblHaciaSituacion.Name = "lblHaciaSituacion";
                        this.lblHaciaSituacion.Size = new System.Drawing.Size(168, 24);
                        this.lblHaciaSituacion.TabIndex = 16;
                        this.lblHaciaSituacion.Text = "Situación 2";
                        this.lblHaciaSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.AutoSize = false;
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.AutoTab = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockActual.Location = new System.Drawing.Point(208, 204);
                        this.EntradaStockActual.MaxLenght = 32767;
                        this.EntradaStockActual.MultiLine = false;
                        this.EntradaStockActual.Name = "EntradaStockActual";
                        this.EntradaStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual.PasswordChar = '\0';
                        this.EntradaStockActual.Prefijo = "";
                        this.EntradaStockActual.ReadOnly = true;
                        this.EntradaStockActual.SelectOnFocus = true;
                        this.EntradaStockActual.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockActual.Sufijo = "";
                        this.EntradaStockActual.TabIndex = 13;
                        this.EntradaStockActual.TabStop = false;
                        this.EntradaStockActual.TipWhenBlank = "";
                        this.EntradaStockActual.ToolTipText = "";
                        // 
                        // EntradaStockResult
                        // 
                        this.EntradaStockResult.AutoSize = false;
                        this.EntradaStockResult.AutoNav = true;
                        this.EntradaStockResult.AutoTab = true;
                        this.EntradaStockResult.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockResult.DecimalPlaces = -1;
                        this.EntradaStockResult.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockResult.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockResult.Location = new System.Drawing.Point(328, 204);
                        this.EntradaStockResult.MaxLenght = 32767;
                        this.EntradaStockResult.MultiLine = false;
                        this.EntradaStockResult.Name = "EntradaStockResult";
                        this.EntradaStockResult.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockResult.PasswordChar = '\0';
                        this.EntradaStockResult.Prefijo = "";
                        this.EntradaStockResult.ReadOnly = true;
                        this.EntradaStockResult.SelectOnFocus = true;
                        this.EntradaStockResult.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockResult.Sufijo = "";
                        this.EntradaStockResult.TabIndex = 15;
                        this.EntradaStockResult.TabStop = false;
                        this.EntradaStockResult.ToolTipText = "";
                        // 
                        // EntradaDesdeSituacion
                        // 
                        this.EntradaDesdeSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDesdeSituacion.AutoSize = false;
                        this.EntradaDesdeSituacion.AutoNav = true;
                        this.EntradaDesdeSituacion.AutoTab = true;
                        this.EntradaDesdeSituacion.CanCreate = false;
                        this.EntradaDesdeSituacion.DataTextField = "nombre";
                        this.EntradaDesdeSituacion.ExtraDetailFields = "";
                        this.EntradaDesdeSituacion.Filter = "";
                        this.EntradaDesdeSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDesdeSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaDesdeSituacion.FreeTextCode = "";
                        this.EntradaDesdeSituacion.DataValueField = "id_situacion";
                        this.EntradaDesdeSituacion.Location = new System.Drawing.Point(124, 116);
                        this.EntradaDesdeSituacion.MaxLength = 200;
                        this.EntradaDesdeSituacion.Name = "EntradaDesdeSituacion";
                        this.EntradaDesdeSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesdeSituacion.ReadOnly = false;
                        this.EntradaDesdeSituacion.Required = true;
                        this.EntradaDesdeSituacion.Size = new System.Drawing.Size(496, 24);
                        this.EntradaDesdeSituacion.TabIndex = 7;
                        this.EntradaDesdeSituacion.Table = "articulos_situaciones";
                        this.EntradaDesdeSituacion.Text = "0";
                        this.EntradaDesdeSituacion.TextDetail = "";
                        this.EntradaDesdeSituacion.TipWhenBlank = "";
                        this.EntradaDesdeSituacion.ToolTipText = "";
                        this.EntradaDesdeSituacion.TextChanged += new System.EventHandler(this.EntradaDesdeHaciaSituacion_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(16, 116);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(108, 24);
                        this.Label7.TabIndex = 6;
                        this.Label7.Text = "Origen";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaHaciaSituacion
                        // 
                        this.EntradaHaciaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaHaciaSituacion.AutoSize = false;
                        this.EntradaHaciaSituacion.AutoNav = true;
                        this.EntradaHaciaSituacion.AutoTab = true;
                        this.EntradaHaciaSituacion.CanCreate = false;
                        this.EntradaHaciaSituacion.DataTextField = "nombre";
                        this.EntradaHaciaSituacion.ExtraDetailFields = "";
                        this.EntradaHaciaSituacion.Filter = "";
                        this.EntradaHaciaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaHaciaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaHaciaSituacion.FreeTextCode = "";
                        this.EntradaHaciaSituacion.DataValueField = "id_situacion";
                        this.EntradaHaciaSituacion.Location = new System.Drawing.Point(124, 148);
                        this.EntradaHaciaSituacion.MaxLength = 200;
                        this.EntradaHaciaSituacion.Name = "EntradaHaciaSituacion";
                        this.EntradaHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHaciaSituacion.ReadOnly = false;
                        this.EntradaHaciaSituacion.Required = true;
                        this.EntradaHaciaSituacion.Size = new System.Drawing.Size(496, 24);
                        this.EntradaHaciaSituacion.TabIndex = 9;
                        this.EntradaHaciaSituacion.Table = "articulos_situaciones";
                        this.EntradaHaciaSituacion.Text = "0";
                        this.EntradaHaciaSituacion.TextDetail = "";
                        this.EntradaHaciaSituacion.TipWhenBlank = "";
                        this.EntradaHaciaSituacion.ToolTipText = "";
                        this.EntradaHaciaSituacion.TextChanged += new System.EventHandler(this.EntradaDesdeHaciaSituacion_TextChanged);
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(16, 148);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(108, 24);
                        this.Label8.TabIndex = 8;
                        this.Label8.Text = "Destino";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockResult2
                        // 
                        this.EntradaStockResult2.AutoSize = false;
                        this.EntradaStockResult2.AutoNav = true;
                        this.EntradaStockResult2.AutoTab = true;
                        this.EntradaStockResult2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockResult2.DecimalPlaces = -1;
                        this.EntradaStockResult2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockResult2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockResult2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockResult2.Location = new System.Drawing.Point(328, 236);
                        this.EntradaStockResult2.MaxLenght = 32767;
                        this.EntradaStockResult2.MultiLine = false;
                        this.EntradaStockResult2.Name = "EntradaStockResult2";
                        this.EntradaStockResult2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockResult2.PasswordChar = '\0';
                        this.EntradaStockResult2.Prefijo = "";
                        this.EntradaStockResult2.ReadOnly = true;
                        this.EntradaStockResult2.SelectOnFocus = true;
                        this.EntradaStockResult2.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockResult2.Sufijo = "";
                        this.EntradaStockResult2.TabIndex = 19;
                        this.EntradaStockResult2.TabStop = false;
                        this.EntradaStockResult2.TipWhenBlank = "";
                        this.EntradaStockResult2.ToolTipText = "";
                        // 
                        // EntradaStockActual2
                        // 
                        this.EntradaStockActual2.AutoSize = false;
                        this.EntradaStockActual2.AutoNav = true;
                        this.EntradaStockActual2.AutoTab = true;
                        this.EntradaStockActual2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockActual2.DecimalPlaces = -1;
                        this.EntradaStockActual2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockActual2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockActual2.Location = new System.Drawing.Point(208, 236);
                        this.EntradaStockActual2.MaxLenght = 32767;
                        this.EntradaStockActual2.MultiLine = false;
                        this.EntradaStockActual2.Name = "EntradaStockActual2";
                        this.EntradaStockActual2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual2.PasswordChar = '\0';
                        this.EntradaStockActual2.Prefijo = "";
                        this.EntradaStockActual2.ReadOnly = true;
                        this.EntradaStockActual2.SelectOnFocus = true;
                        this.EntradaStockActual2.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockActual2.Sufijo = "";
                        this.EntradaStockActual2.TabIndex = 17;
                        this.EntradaStockActual2.TabStop = false;
                        this.EntradaStockActual2.TipWhenBlank = "";
                        this.EntradaStockActual2.ToolTipText = "";
                        // 
                        // lblStockFlecha
                        // 
                        this.lblStockFlecha.Location = new System.Drawing.Point(304, 204);
                        this.lblStockFlecha.Name = "lblStockFlecha";
                        this.lblStockFlecha.Size = new System.Drawing.Size(24, 24);
                        this.lblStockFlecha.TabIndex = 14;
                        this.lblStockFlecha.Text = "->";
                        this.lblStockFlecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblStockFlecha2
                        // 
                        this.lblStockFlecha2.Location = new System.Drawing.Point(304, 236);
                        this.lblStockFlecha2.Name = "lblStockFlecha2";
                        this.lblStockFlecha2.Size = new System.Drawing.Size(24, 24);
                        this.lblStockFlecha2.TabIndex = 18;
                        this.lblStockFlecha2.Text = "->";
                        this.lblStockFlecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label5
                        // 
                        this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label5.Location = new System.Drawing.Point(208, 188);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(96, 16);
                        this.Label5.TabIndex = 10;
                        this.Label5.Text = "Antes";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        // 
                        // Label6
                        // 
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(328, 188);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(96, 16);
                        this.Label6.TabIndex = 11;
                        this.Label6.Text = "Después";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        // 
                        // EntradaArticulo
                        // 
                        this.EntradaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaArticulo.AutoSize = false;
                        this.EntradaArticulo.AutoNav = true;
                        this.EntradaArticulo.CantidadSoloLectura = false;
                        this.EntradaArticulo.ControlStock = Lcc.Entrada.Articulos.ControlesSock.Ambos;
                        this.EntradaArticulo.DataTextField = null;
                        this.EntradaArticulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaArticulo.FreeTextCode = "";
                        this.EntradaArticulo.DataValueField = null;
                        this.EntradaArticulo.Location = new System.Drawing.Point(124, 16);
                        this.EntradaArticulo.MaxLength = 200;
                        this.EntradaArticulo.MuestraPrecio = false;
                        this.EntradaArticulo.MuestraStock = false;
                        this.EntradaArticulo.Name = "EntradaArticulo";
                        this.EntradaArticulo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaArticulo.PermiteCrear = false;
                        this.EntradaArticulo.Precio = Lcc.Entrada.Articulos.Precios.Pvp;
                        this.EntradaArticulo.PrecioSoloLectura = false;
                        this.EntradaArticulo.ProductoSoloLectura = false;
                        this.EntradaArticulo.ReadOnly = false;
                        this.EntradaArticulo.Required = true;
                        this.EntradaArticulo.Size = new System.Drawing.Size(496, 24);
                        this.EntradaArticulo.TabIndex = 1;
                        this.EntradaArticulo.Table = null;
                        this.EntradaArticulo.Text = "0";
                        this.EntradaArticulo.TextDetail = "";
                        this.EntradaArticulo.ToolTipText = "";
                        // 
                        // Movimiento
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.EntradaArticulo);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.lblStockFlecha2);
                        this.Controls.Add(this.lblStockFlecha);
                        this.Controls.Add(this.EntradaStockResult2);
                        this.Controls.Add(this.EntradaStockActual2);
                        this.Controls.Add(this.EntradaHaciaSituacion);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.EntradaDesdeSituacion);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaStockResult);
                        this.Controls.Add(this.EntradaStockActual);
                        this.Controls.Add(this.lblHaciaSituacion);
                        this.Controls.Add(this.lblDesdeSituacion);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.EntradaMovimiento);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Name = "Movimiento";
                        this.Text = "Artículos: Entrada y Salida";
                        this.WorkspaceChanged += new System.EventHandler(this.FormArticulosMovim_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaMovimiento, 0);
                        this.Controls.SetChildIndex(this.EntradaCantidad, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.Controls.SetChildIndex(this.lblDesdeSituacion, 0);
                        this.Controls.SetChildIndex(this.lblHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.EntradaStockActual, 0);
                        this.Controls.SetChildIndex(this.EntradaStockResult, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaDesdeSituacion, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.EntradaHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.EntradaStockActual2, 0);
                        this.Controls.SetChildIndex(this.EntradaStockResult2, 0);
                        this.Controls.SetChildIndex(this.lblStockFlecha, 0);
                        this.Controls.SetChildIndex(this.lblStockFlecha2, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.EntradaArticulo, 0);
                        this.ResumeLayout(false);

                }

                #endregion
        }
}