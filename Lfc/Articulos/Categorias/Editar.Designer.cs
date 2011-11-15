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

namespace Lfc.Articulos.Categorias
{
        public partial class Editar
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

                private void InitializeComponent()
                {
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaNombreSing = new Lui.Forms.TextBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaStockMinimo = new Lui.Forms.TextBox();
                        this.Label11 = new Lui.Forms.Label();
                        this.EntradaItem = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaGarantia = new Lui.Forms.TextBox();
                        this.label20 = new Lui.Forms.Label();
                        this.EntradaSeguimiento = new Lui.Forms.ComboBox();
                        this.label8 = new Lui.Forms.Label();
                        this.EntradaRubro = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaWeb = new Lui.Forms.ComboBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.label9 = new Lui.Forms.Label();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.EntradaCosto = new Lui.Forms.TextBox();
                        this.EntradaItemStock = new Lui.Forms.TextBox();
                        this.label10 = new Lui.Forms.Label();
                        this.EntradaAlicuota = new Lcc.Entrada.CodigoDetalle();
                        this.Frame2.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.FieldName = null;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.Location = new System.Drawing.Point(140, 0);
                        this.EntradaNombre.MaxLength = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.PlaceholderText = null;
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(497, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(0, 0);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(140, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombreSing
                        // 
                        this.EntradaNombreSing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombreSing.AutoNav = true;
                        this.EntradaNombreSing.AutoTab = true;
                        this.EntradaNombreSing.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombreSing.DecimalPlaces = -1;
                        this.EntradaNombreSing.FieldName = null;
                        this.EntradaNombreSing.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombreSing.Location = new System.Drawing.Point(140, 28);
                        this.EntradaNombreSing.MaxLength = 32767;
                        this.EntradaNombreSing.MultiLine = false;
                        this.EntradaNombreSing.Name = "EntradaNombreSing";
                        this.EntradaNombreSing.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombreSing.PasswordChar = '\0';
                        this.EntradaNombreSing.PlaceholderText = null;
                        this.EntradaNombreSing.Prefijo = "";
                        this.EntradaNombreSing.ReadOnly = false;
                        this.EntradaNombreSing.SelectOnFocus = false;
                        this.EntradaNombreSing.Size = new System.Drawing.Size(497, 24);
                        this.EntradaNombreSing.Sufijo = "";
                        this.EntradaNombreSing.TabIndex = 3;
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(0, 28);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(140, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Nombre elemento";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockMinimo
                        // 
                        this.EntradaStockMinimo.AutoNav = true;
                        this.EntradaStockMinimo.AutoTab = true;
                        this.EntradaStockMinimo.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaStockMinimo.DecimalPlaces = -1;
                        this.EntradaStockMinimo.FieldName = null;
                        this.EntradaStockMinimo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockMinimo.Location = new System.Drawing.Point(140, 56);
                        this.EntradaStockMinimo.MaxLength = 32767;
                        this.EntradaStockMinimo.MultiLine = false;
                        this.EntradaStockMinimo.Name = "EntradaStockMinimo";
                        this.EntradaStockMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMinimo.PasswordChar = '\0';
                        this.EntradaStockMinimo.PlaceholderText = null;
                        this.EntradaStockMinimo.Prefijo = "";
                        this.EntradaStockMinimo.ReadOnly = false;
                        this.EntradaStockMinimo.SelectOnFocus = true;
                        this.EntradaStockMinimo.Size = new System.Drawing.Size(72, 24);
                        this.EntradaStockMinimo.Sufijo = "";
                        this.EntradaStockMinimo.TabIndex = 5;
                        this.EntradaStockMinimo.Text = "0";
                        // 
                        // Label11
                        // 
                        this.Label11.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label11.Location = new System.Drawing.Point(0, 56);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(140, 24);
                        this.Label11.TabIndex = 4;
                        this.Label11.Text = "Stock mínimo";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaItem
                        // 
                        this.EntradaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaItem.AutoNav = true;
                        this.EntradaItem.AutoTab = true;
                        this.EntradaItem.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaItem.DecimalPlaces = -1;
                        this.EntradaItem.FieldName = null;
                        this.EntradaItem.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaItem.Location = new System.Drawing.Point(184, 36);
                        this.EntradaItem.MaxLength = 32767;
                        this.EntradaItem.MultiLine = false;
                        this.EntradaItem.Name = "EntradaItem";
                        this.EntradaItem.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaItem.PasswordChar = '\0';
                        this.EntradaItem.PlaceholderText = null;
                        this.EntradaItem.Prefijo = "";
                        this.EntradaItem.ReadOnly = false;
                        this.EntradaItem.SelectOnFocus = true;
                        this.EntradaItem.Size = new System.Drawing.Size(108, 24);
                        this.EntradaItem.Sufijo = "";
                        this.EntradaItem.TabIndex = 1;
                        this.EntradaItem.TabStop = false;
                        this.EntradaItem.Text = "0";
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(12, 36);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(168, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Artículos";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaGarantia
                        // 
                        this.EntradaGarantia.AutoNav = true;
                        this.EntradaGarantia.AutoTab = true;
                        this.EntradaGarantia.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaGarantia.DecimalPlaces = -1;
                        this.EntradaGarantia.FieldName = null;
                        this.EntradaGarantia.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGarantia.Location = new System.Drawing.Point(140, 236);
                        this.EntradaGarantia.MaxLength = 32767;
                        this.EntradaGarantia.MultiLine = false;
                        this.EntradaGarantia.Name = "EntradaGarantia";
                        this.EntradaGarantia.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGarantia.PasswordChar = '\0';
                        this.EntradaGarantia.PlaceholderText = "Precio de costo o de compra.";
                        this.EntradaGarantia.Prefijo = "";
                        this.EntradaGarantia.ReadOnly = false;
                        this.EntradaGarantia.SelectOnFocus = true;
                        this.EntradaGarantia.Size = new System.Drawing.Size(104, 24);
                        this.EntradaGarantia.Sufijo = "meses";
                        this.EntradaGarantia.TabIndex = 15;
                        this.EntradaGarantia.Text = "0";
                        // 
                        // label20
                        // 
                        this.label20.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label20.Location = new System.Drawing.Point(0, 236);
                        this.label20.Name = "label20";
                        this.label20.Size = new System.Drawing.Size(140, 24);
                        this.label20.TabIndex = 14;
                        this.label20.Text = "Garantía";
                        this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSeguimiento
                        // 
                        this.EntradaSeguimiento.AlwaysExpanded = true;
                        this.EntradaSeguimiento.AutoNav = true;
                        this.EntradaSeguimiento.AutoSize = true;
                        this.EntradaSeguimiento.AutoTab = true;
                        this.EntradaSeguimiento.FieldName = null;
                        this.EntradaSeguimiento.Location = new System.Drawing.Point(140, 124);
                        this.EntradaSeguimiento.MaxLength = 32767;
                        this.EntradaSeguimiento.Name = "EntradaSeguimiento";
                        this.EntradaSeguimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSeguimiento.PlaceholderText = null;
                        this.EntradaSeguimiento.ReadOnly = false;
                        this.EntradaSeguimiento.SetData = new string[] {
        "Ninguno|0",
        "Por Números de Serie|3",
        "Por Variaciones|5"};
                        this.EntradaSeguimiento.Size = new System.Drawing.Size(187, 51);
                        this.EntradaSeguimiento.TabIndex = 9;
                        this.EntradaSeguimiento.TextKey = "0";
                        // 
                        // label8
                        // 
                        this.label8.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label8.Location = new System.Drawing.Point(0, 124);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(140, 24);
                        this.label8.TabIndex = 8;
                        this.label8.Text = "Seguimiento";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaRubro
                        // 
                        this.EntradaRubro.AutoNav = true;
                        this.EntradaRubro.AutoTab = true;
                        this.EntradaRubro.CanCreate = true;
                        this.EntradaRubro.DataTextField = "nombre";
                        this.EntradaRubro.DataValueField = "id_rubro";
                        this.EntradaRubro.ExtraDetailFields = "";
                        this.EntradaRubro.FieldName = null;
                        this.EntradaRubro.Filter = "";
                        this.EntradaRubro.FreeTextCode = "";
                        this.EntradaRubro.Location = new System.Drawing.Point(140, 180);
                        this.EntradaRubro.MaxLength = 200;
                        this.EntradaRubro.Name = "EntradaRubro";
                        this.EntradaRubro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRubro.PlaceholderText = "Sin especificar";
                        this.EntradaRubro.ReadOnly = false;
                        this.EntradaRubro.Required = true;
                        this.EntradaRubro.Size = new System.Drawing.Size(304, 24);
                        this.EntradaRubro.TabIndex = 11;
                        this.EntradaRubro.Table = "articulos_rubros";
                        this.EntradaRubro.Text = "0";
                        this.EntradaRubro.TextDetail = "";
                        // 
                        // EntradaWeb
                        // 
                        this.EntradaWeb.AlwaysExpanded = true;
                        this.EntradaWeb.AutoNav = true;
                        this.EntradaWeb.AutoSize = true;
                        this.EntradaWeb.AutoTab = true;
                        this.EntradaWeb.FieldName = null;
                        this.EntradaWeb.Location = new System.Drawing.Point(140, 84);
                        this.EntradaWeb.MaxLength = 32767;
                        this.EntradaWeb.Name = "EntradaWeb";
                        this.EntradaWeb.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaWeb.PlaceholderText = null;
                        this.EntradaWeb.ReadOnly = false;
                        this.EntradaWeb.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaWeb.Size = new System.Drawing.Size(108, 36);
                        this.EntradaWeb.TabIndex = 7;
                        this.EntradaWeb.TextKey = "0";
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label7.Location = new System.Drawing.Point(0, 84);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(140, 24);
                        this.Label7.TabIndex = 6;
                        this.Label7.Text = "Publicar en la web*";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label9
                        // 
                        this.label9.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label9.Location = new System.Drawing.Point(0, 180);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(140, 24);
                        this.label9.TabIndex = 10;
                        this.label9.Text = "Rubro";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame2
                        // 
                        this.Frame2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame2.Controls.Add(this.Label3);
                        this.Frame2.Controls.Add(this.Label2);
                        this.Frame2.Controls.Add(this.Label4);
                        this.Frame2.Controls.Add(this.EntradaItem);
                        this.Frame2.Controls.Add(this.EntradaStockActual);
                        this.Frame2.Controls.Add(this.Label6);
                        this.Frame2.Controls.Add(this.EntradaCosto);
                        this.Frame2.Controls.Add(this.EntradaItemStock);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame2.Location = new System.Drawing.Point(336, 244);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(300, 152);
                        this.Frame2.TabIndex = 50;
                        this.Frame2.TabStop = false;
                        this.Frame2.Text = "Estadsticas";
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(12, 92);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(168, 24);
                        this.Label3.TabIndex = 4;
                        this.Label3.Text = "Stock actual";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(12, 120);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(168, 24);
                        this.Label4.TabIndex = 6;
                        this.Label4.Text = "Costo del stock";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.AutoTab = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.FieldName = null;
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.Location = new System.Drawing.Point(184, 92);
                        this.EntradaStockActual.MaxLength = 32767;
                        this.EntradaStockActual.MultiLine = false;
                        this.EntradaStockActual.Name = "EntradaStockActual";
                        this.EntradaStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual.PasswordChar = '\0';
                        this.EntradaStockActual.PlaceholderText = null;
                        this.EntradaStockActual.Prefijo = "";
                        this.EntradaStockActual.ReadOnly = false;
                        this.EntradaStockActual.SelectOnFocus = true;
                        this.EntradaStockActual.Size = new System.Drawing.Size(108, 24);
                        this.EntradaStockActual.Sufijo = "";
                        this.EntradaStockActual.TabIndex = 5;
                        this.EntradaStockActual.TabStop = false;
                        this.EntradaStockActual.Text = "0";
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(12, 64);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(168, 24);
                        this.Label6.TabIndex = 2;
                        this.Label6.Text = "Artículos con stock";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCosto
                        // 
                        this.EntradaCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCosto.AutoNav = true;
                        this.EntradaCosto.AutoTab = true;
                        this.EntradaCosto.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCosto.DecimalPlaces = -1;
                        this.EntradaCosto.FieldName = null;
                        this.EntradaCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCosto.Location = new System.Drawing.Point(184, 120);
                        this.EntradaCosto.MaxLength = 32767;
                        this.EntradaCosto.MultiLine = false;
                        this.EntradaCosto.Name = "EntradaCosto";
                        this.EntradaCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCosto.PasswordChar = '\0';
                        this.EntradaCosto.PlaceholderText = null;
                        this.EntradaCosto.Prefijo = "$";
                        this.EntradaCosto.ReadOnly = false;
                        this.EntradaCosto.SelectOnFocus = true;
                        this.EntradaCosto.Size = new System.Drawing.Size(108, 24);
                        this.EntradaCosto.Sufijo = "";
                        this.EntradaCosto.TabIndex = 7;
                        this.EntradaCosto.TabStop = false;
                        this.EntradaCosto.Text = "0.00";
                        // 
                        // EntradaItemStock
                        // 
                        this.EntradaItemStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaItemStock.AutoNav = true;
                        this.EntradaItemStock.AutoTab = true;
                        this.EntradaItemStock.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaItemStock.DecimalPlaces = -1;
                        this.EntradaItemStock.FieldName = null;
                        this.EntradaItemStock.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaItemStock.Location = new System.Drawing.Point(184, 64);
                        this.EntradaItemStock.MaxLength = 32767;
                        this.EntradaItemStock.MultiLine = false;
                        this.EntradaItemStock.Name = "EntradaItemStock";
                        this.EntradaItemStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaItemStock.PasswordChar = '\0';
                        this.EntradaItemStock.PlaceholderText = null;
                        this.EntradaItemStock.Prefijo = "";
                        this.EntradaItemStock.ReadOnly = false;
                        this.EntradaItemStock.SelectOnFocus = true;
                        this.EntradaItemStock.Size = new System.Drawing.Size(108, 24);
                        this.EntradaItemStock.Sufijo = "";
                        this.EntradaItemStock.TabIndex = 3;
                        this.EntradaItemStock.TabStop = false;
                        this.EntradaItemStock.Text = "0";
                        // 
                        // label10
                        // 
                        this.label10.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label10.Location = new System.Drawing.Point(0, 208);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(140, 24);
                        this.label10.TabIndex = 12;
                        this.label10.Text = "Alícuota";
                        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAlicuota
                        // 
                        this.EntradaAlicuota.AutoNav = true;
                        this.EntradaAlicuota.AutoTab = true;
                        this.EntradaAlicuota.CanCreate = true;
                        this.EntradaAlicuota.DataTextField = "nombre";
                        this.EntradaAlicuota.DataValueField = "id_alicuota";
                        this.EntradaAlicuota.ExtraDetailFields = "";
                        this.EntradaAlicuota.FieldName = null;
                        this.EntradaAlicuota.Filter = "";
                        this.EntradaAlicuota.FreeTextCode = "";
                        this.EntradaAlicuota.Location = new System.Drawing.Point(140, 208);
                        this.EntradaAlicuota.MaxLength = 200;
                        this.EntradaAlicuota.Name = "EntradaAlicuota";
                        this.EntradaAlicuota.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlicuota.PlaceholderText = "Sin especificar";
                        this.EntradaAlicuota.ReadOnly = false;
                        this.EntradaAlicuota.Required = true;
                        this.EntradaAlicuota.Size = new System.Drawing.Size(304, 24);
                        this.EntradaAlicuota.TabIndex = 13;
                        this.EntradaAlicuota.Table = "alicuotas";
                        this.EntradaAlicuota.Text = "0";
                        this.EntradaAlicuota.TextDetail = "";
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label10);
                        this.Controls.Add(this.EntradaAlicuota);
                        this.Controls.Add(this.EntradaGarantia);
                        this.Controls.Add(this.Frame2);
                        this.Controls.Add(this.label20);
                        this.Controls.Add(this.EntradaSeguimiento);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.EntradaRubro);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaWeb);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaNombreSing);
                        this.Controls.Add(this.EntradaStockMinimo);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.Controls.SetChildIndex(this.EntradaStockMinimo, 0);
                        this.Controls.SetChildIndex(this.EntradaNombreSing, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.EntradaWeb, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaRubro, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaSeguimiento, 0);
                        this.Controls.SetChildIndex(this.label20, 0);
                        this.Controls.SetChildIndex(this.Frame2, 0);
                        this.Controls.SetChildIndex(this.EntradaGarantia, 0);
                        this.Controls.SetChildIndex(this.EntradaAlicuota, 0);
                        this.Controls.SetChildIndex(this.label10, 0);
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaStockMinimo;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Frame Frame2;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaNombreSing;
                internal Lui.Forms.TextBox EntradaItem;
                internal Lui.Forms.TextBox EntradaStockActual;
                internal Lui.Forms.TextBox EntradaCosto;
                internal Lui.Forms.TextBox EntradaItemStock;
                internal Lui.Forms.Label Label6;
                internal Lui.Forms.ComboBox EntradaWeb;
                internal Lui.Forms.Label Label7;
                private Lcc.Entrada.CodigoDetalle EntradaRubro;
                internal Lui.Forms.Label label9;
                internal Lui.Forms.ComboBox EntradaSeguimiento;
                internal Lui.Forms.Label label8;
                internal Lui.Forms.TextBox EntradaGarantia;
                internal Lui.Forms.Label label20;
                internal Lui.Forms.Label label10;
                private Lcc.Entrada.CodigoDetalle EntradaAlicuota;
        }
}
