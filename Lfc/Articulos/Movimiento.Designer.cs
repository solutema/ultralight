#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.ComboBox EntradaMovimiento;
                internal Lui.Forms.TextBox EntradaCantidad;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.TextBox EntradaStockActual;
                internal Lui.Forms.TextBox EntradaStockResult;
                internal Lcc.Entrada.CodigoDetalle EntradaDesdeSituacion;
                internal Lui.Forms.Label Label7;
                internal Lcc.Entrada.CodigoDetalle EntradaHaciaSituacion;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.TextBox EntradaStockResult2;
                internal Lui.Forms.TextBox EntradaStockActual2;
                internal Lui.Forms.Label lblDesdeSituacion;
                internal Lui.Forms.Label lblHaciaSituacion;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.Label Label6;
                public Lcc.Entrada.Articulos.DetalleComprobante EntradaArticulo;
                internal Lui.Forms.Label lblStockFlecha2;
                internal Lui.Forms.Label lblStockFlecha;

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
                        this.Label1 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaMovimiento = new Lui.Forms.ComboBox();
                        this.EntradaCantidad = new Lui.Forms.TextBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.lblDesdeSituacion = new Lui.Forms.Label();
                        this.lblHaciaSituacion = new Lui.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.EntradaStockResult = new Lui.Forms.TextBox();
                        this.EntradaDesdeSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaHaciaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label8 = new Lui.Forms.Label();
                        this.EntradaStockResult2 = new Lui.Forms.TextBox();
                        this.EntradaStockActual2 = new Lui.Forms.TextBox();
                        this.lblStockFlecha = new Lui.Forms.Label();
                        this.lblStockFlecha2 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.Label6 = new Lui.Forms.Label();
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
                        this.Label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(32, 76);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(108, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Artículo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(32, 132);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(108, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Cantidad";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(32, 320);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(108, 24);
                        this.Label3.TabIndex = 20;
                        this.Label3.Text = "Obs.";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(32, 32);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(108, 24);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Movimiento";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMovimiento
                        // 
                        this.EntradaMovimiento.AlwaysExpanded = true;
                        this.EntradaMovimiento.AutoNav = true;
                        this.EntradaMovimiento.AutoSize = true;
                        this.EntradaMovimiento.AutoTab = true;
                        this.EntradaMovimiento.FieldName = null;
                        this.EntradaMovimiento.Location = new System.Drawing.Point(140, 32);
                        this.EntradaMovimiento.MaxLength = 32767;
                        this.EntradaMovimiento.Name = "EntradaMovimiento";
                        this.EntradaMovimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMovimiento.PlaceholderText = null;
                        this.EntradaMovimiento.ReadOnly = false;
                        this.EntradaMovimiento.SetData = new string[] {
        "Entrada|e",
        "Salida|s"};
                        this.EntradaMovimiento.Size = new System.Drawing.Size(192, 36);
                        this.EntradaMovimiento.TabIndex = 1;
                        this.EntradaMovimiento.TextKey = "e";
                        this.EntradaMovimiento.TextChanged += new System.EventHandler(this.EntradaMovimiento_TextChanged);
                        // 
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.AutoNav = true;
                        this.EntradaCantidad.AutoTab = true;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaCantidad.DecimalPlaces = -1;
                        this.EntradaCantidad.FieldName = null;
                        this.EntradaCantidad.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCantidad.Location = new System.Drawing.Point(140, 132);
                        this.EntradaCantidad.MaxLength = 32767;
                        this.EntradaCantidad.MultiLine = false;
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCantidad.PasswordChar = '\0';
                        this.EntradaCantidad.PlaceholderText = null;
                        this.EntradaCantidad.Prefijo = "";
                        this.EntradaCantidad.ReadOnly = false;
                        this.EntradaCantidad.SelectOnFocus = true;
                        this.EntradaCantidad.Size = new System.Drawing.Size(96, 24);
                        this.EntradaCantidad.Sufijo = "";
                        this.EntradaCantidad.TabIndex = 5;
                        this.EntradaCantidad.Text = "0.00";
                        this.EntradaCantidad.TextChanged += new System.EventHandler(this.EntradaArticulo_TextChanged);
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.FieldName = null;
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.Location = new System.Drawing.Point(140, 320);
                        this.EntradaObs.MaxLength = 32767;
                        this.EntradaObs.MultiLine = false;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.PlaceholderText = null;
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = true;
                        this.EntradaObs.Size = new System.Drawing.Size(456, 24);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 21;
                        // 
                        // lblDesdeSituacion
                        // 
                        this.lblDesdeSituacion.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.lblDesdeSituacion.Location = new System.Drawing.Point(140, 252);
                        this.lblDesdeSituacion.Name = "lblDesdeSituacion";
                        this.lblDesdeSituacion.Size = new System.Drawing.Size(168, 24);
                        this.lblDesdeSituacion.TabIndex = 12;
                        this.lblDesdeSituacion.Text = "Situación 1";
                        this.lblDesdeSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHaciaSituacion
                        // 
                        this.lblHaciaSituacion.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.lblHaciaSituacion.Location = new System.Drawing.Point(140, 284);
                        this.lblHaciaSituacion.Name = "lblHaciaSituacion";
                        this.lblHaciaSituacion.Size = new System.Drawing.Size(168, 24);
                        this.lblHaciaSituacion.TabIndex = 16;
                        this.lblHaciaSituacion.Text = "Situación 2";
                        this.lblHaciaSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.AutoTab = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.FieldName = null;
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.Location = new System.Drawing.Point(308, 252);
                        this.EntradaStockActual.MaxLength = 32767;
                        this.EntradaStockActual.MultiLine = false;
                        this.EntradaStockActual.Name = "EntradaStockActual";
                        this.EntradaStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual.PasswordChar = '\0';
                        this.EntradaStockActual.PlaceholderText = null;
                        this.EntradaStockActual.Prefijo = "";
                        this.EntradaStockActual.ReadOnly = false;
                        this.EntradaStockActual.SelectOnFocus = true;
                        this.EntradaStockActual.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockActual.Sufijo = "";
                        this.EntradaStockActual.TabIndex = 13;
                        this.EntradaStockActual.TabStop = false;
                        // 
                        // EntradaStockResult
                        // 
                        this.EntradaStockResult.AutoNav = true;
                        this.EntradaStockResult.AutoTab = true;
                        this.EntradaStockResult.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockResult.DecimalPlaces = -1;
                        this.EntradaStockResult.FieldName = null;
                        this.EntradaStockResult.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockResult.Location = new System.Drawing.Point(428, 252);
                        this.EntradaStockResult.MaxLength = 32767;
                        this.EntradaStockResult.MultiLine = false;
                        this.EntradaStockResult.Name = "EntradaStockResult";
                        this.EntradaStockResult.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockResult.PasswordChar = '\0';
                        this.EntradaStockResult.PlaceholderText = null;
                        this.EntradaStockResult.Prefijo = "";
                        this.EntradaStockResult.ReadOnly = false;
                        this.EntradaStockResult.SelectOnFocus = true;
                        this.EntradaStockResult.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockResult.Sufijo = "";
                        this.EntradaStockResult.TabIndex = 15;
                        this.EntradaStockResult.TabStop = false;
                        // 
                        // EntradaDesdeSituacion
                        // 
                        this.EntradaDesdeSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDesdeSituacion.AutoNav = true;
                        this.EntradaDesdeSituacion.AutoTab = true;
                        this.EntradaDesdeSituacion.CanCreate = false;
                        this.EntradaDesdeSituacion.DataTextField = "nombre";
                        this.EntradaDesdeSituacion.DataValueField = "id_situacion";
                        this.EntradaDesdeSituacion.ExtraDetailFields = "";
                        this.EntradaDesdeSituacion.FieldName = null;
                        this.EntradaDesdeSituacion.Filter = "";
                        this.EntradaDesdeSituacion.FreeTextCode = "";
                        this.EntradaDesdeSituacion.Location = new System.Drawing.Point(140, 164);
                        this.EntradaDesdeSituacion.MaxLength = 200;
                        this.EntradaDesdeSituacion.Name = "EntradaDesdeSituacion";
                        this.EntradaDesdeSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesdeSituacion.PlaceholderText = null;
                        this.EntradaDesdeSituacion.ReadOnly = false;
                        this.EntradaDesdeSituacion.Required = true;
                        this.EntradaDesdeSituacion.Size = new System.Drawing.Size(456, 24);
                        this.EntradaDesdeSituacion.TabIndex = 7;
                        this.EntradaDesdeSituacion.Table = "articulos_situaciones";
                        this.EntradaDesdeSituacion.Text = "0";
                        this.EntradaDesdeSituacion.TextDetail = "";
                        this.EntradaDesdeSituacion.TextChanged += new System.EventHandler(this.EntradaDesdeHaciaSituacion_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label7.Location = new System.Drawing.Point(32, 164);
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
                        this.EntradaHaciaSituacion.AutoNav = true;
                        this.EntradaHaciaSituacion.AutoTab = true;
                        this.EntradaHaciaSituacion.CanCreate = false;
                        this.EntradaHaciaSituacion.DataTextField = "nombre";
                        this.EntradaHaciaSituacion.DataValueField = "id_situacion";
                        this.EntradaHaciaSituacion.ExtraDetailFields = "";
                        this.EntradaHaciaSituacion.FieldName = null;
                        this.EntradaHaciaSituacion.Filter = "";
                        this.EntradaHaciaSituacion.FreeTextCode = "";
                        this.EntradaHaciaSituacion.Location = new System.Drawing.Point(140, 196);
                        this.EntradaHaciaSituacion.MaxLength = 200;
                        this.EntradaHaciaSituacion.Name = "EntradaHaciaSituacion";
                        this.EntradaHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHaciaSituacion.PlaceholderText = null;
                        this.EntradaHaciaSituacion.ReadOnly = false;
                        this.EntradaHaciaSituacion.Required = true;
                        this.EntradaHaciaSituacion.Size = new System.Drawing.Size(456, 24);
                        this.EntradaHaciaSituacion.TabIndex = 9;
                        this.EntradaHaciaSituacion.Table = "articulos_situaciones";
                        this.EntradaHaciaSituacion.Text = "0";
                        this.EntradaHaciaSituacion.TextDetail = "";
                        this.EntradaHaciaSituacion.TextChanged += new System.EventHandler(this.EntradaDesdeHaciaSituacion_TextChanged);
                        // 
                        // Label8
                        // 
                        this.Label8.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(32, 196);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(108, 24);
                        this.Label8.TabIndex = 8;
                        this.Label8.Text = "Destino";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockResult2
                        // 
                        this.EntradaStockResult2.AutoNav = true;
                        this.EntradaStockResult2.AutoTab = true;
                        this.EntradaStockResult2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockResult2.DecimalPlaces = -1;
                        this.EntradaStockResult2.FieldName = null;
                        this.EntradaStockResult2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockResult2.Location = new System.Drawing.Point(428, 284);
                        this.EntradaStockResult2.MaxLength = 32767;
                        this.EntradaStockResult2.MultiLine = false;
                        this.EntradaStockResult2.Name = "EntradaStockResult2";
                        this.EntradaStockResult2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockResult2.PasswordChar = '\0';
                        this.EntradaStockResult2.PlaceholderText = null;
                        this.EntradaStockResult2.Prefijo = "";
                        this.EntradaStockResult2.ReadOnly = false;
                        this.EntradaStockResult2.SelectOnFocus = true;
                        this.EntradaStockResult2.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockResult2.Sufijo = "";
                        this.EntradaStockResult2.TabIndex = 19;
                        this.EntradaStockResult2.TabStop = false;
                        // 
                        // EntradaStockActual2
                        // 
                        this.EntradaStockActual2.AutoNav = true;
                        this.EntradaStockActual2.AutoTab = true;
                        this.EntradaStockActual2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaStockActual2.DecimalPlaces = -1;
                        this.EntradaStockActual2.FieldName = null;
                        this.EntradaStockActual2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual2.Location = new System.Drawing.Point(308, 284);
                        this.EntradaStockActual2.MaxLength = 32767;
                        this.EntradaStockActual2.MultiLine = false;
                        this.EntradaStockActual2.Name = "EntradaStockActual2";
                        this.EntradaStockActual2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual2.PasswordChar = '\0';
                        this.EntradaStockActual2.PlaceholderText = null;
                        this.EntradaStockActual2.Prefijo = "";
                        this.EntradaStockActual2.ReadOnly = false;
                        this.EntradaStockActual2.SelectOnFocus = true;
                        this.EntradaStockActual2.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockActual2.Sufijo = "";
                        this.EntradaStockActual2.TabIndex = 17;
                        this.EntradaStockActual2.TabStop = false;
                        // 
                        // lblStockFlecha
                        // 
                        this.lblStockFlecha.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.lblStockFlecha.Location = new System.Drawing.Point(404, 252);
                        this.lblStockFlecha.Name = "lblStockFlecha";
                        this.lblStockFlecha.Size = new System.Drawing.Size(24, 24);
                        this.lblStockFlecha.TabIndex = 14;
                        this.lblStockFlecha.Text = "->";
                        this.lblStockFlecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblStockFlecha2
                        // 
                        this.lblStockFlecha2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.lblStockFlecha2.Location = new System.Drawing.Point(404, 284);
                        this.lblStockFlecha2.Name = "lblStockFlecha2";
                        this.lblStockFlecha2.Size = new System.Drawing.Size(24, 24);
                        this.lblStockFlecha2.TabIndex = 18;
                        this.lblStockFlecha2.Text = "->";
                        this.lblStockFlecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(308, 232);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(96, 20);
                        this.Label5.TabIndex = 10;
                        this.Label5.Text = "Antes";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        // 
                        // Label6
                        // 
                        this.Label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(428, 232);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(96, 20);
                        this.Label6.TabIndex = 11;
                        this.Label6.Text = "Después";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        // 
                        // EntradaArticulo
                        // 
                        this.EntradaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaArticulo.AutoNav = true;
                        this.EntradaArticulo.CantidadSoloLectura = false;
                        this.EntradaArticulo.ControlStock = Lcc.Entrada.Articulos.ControlesSock.Ambos;
                        this.EntradaArticulo.DataTextField = null;
                        this.EntradaArticulo.DataValueField = null;
                        this.EntradaArticulo.FieldName = null;
                        this.EntradaArticulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaArticulo.FreeTextCode = "";
                        this.EntradaArticulo.Location = new System.Drawing.Point(140, 76);
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
                        this.EntradaArticulo.Size = new System.Drawing.Size(456, 24);
                        this.EntradaArticulo.TabIndex = 3;
                        this.EntradaArticulo.Table = null;
                        this.EntradaArticulo.Text = "0";
                        this.EntradaArticulo.TextDetail = "";
                        this.EntradaArticulo.PrecioCantidadChanged += new System.EventHandler(this.EntradaArticulo_PrecioCantidadChanged);
                        this.EntradaArticulo.ObtenerDatosSeguimiento += new System.EventHandler(this.EntradaArticulo_ObtenerDatosSeguimiento);
                        // 
                        // Movimiento
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 419);
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
                        this.PerformLayout();

                }

                #endregion
        }
}
