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
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaNombreSing = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaStockMinimo = new Lui.Forms.TextBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.EntradaItem = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaGarantia = new Lui.Forms.TextBox();
                        this.label20 = new System.Windows.Forms.Label();
                        this.EntradaSeguimiento = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.EntradaRubro = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaWeb = new Lui.Forms.ComboBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.EntradaCosto = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaItemStock = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
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
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(140, 0);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(612, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // Label5
                        // 
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
                        this.EntradaNombreSing.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombreSing.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombreSing.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombreSing.Location = new System.Drawing.Point(140, 28);
                        this.EntradaNombreSing.MaxLenght = 32767;
                        this.EntradaNombreSing.MultiLine = false;
                        this.EntradaNombreSing.Name = "EntradaNombreSing";
                        this.EntradaNombreSing.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombreSing.PasswordChar = '\0';
                        this.EntradaNombreSing.Prefijo = "";
                        this.EntradaNombreSing.SelectOnFocus = false;
                        this.EntradaNombreSing.Size = new System.Drawing.Size(612, 24);
                        this.EntradaNombreSing.Sufijo = "";
                        this.EntradaNombreSing.TabIndex = 3;
                        this.EntradaNombreSing.PlaceholderText = "";
                        this.EntradaNombreSing.ToolTipText = "";
                        // 
                        // Label1
                        // 
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
                        this.EntradaStockMinimo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockMinimo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockMinimo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaStockMinimo.Location = new System.Drawing.Point(140, 56);
                        this.EntradaStockMinimo.MaxLenght = 32767;
                        this.EntradaStockMinimo.MultiLine = false;
                        this.EntradaStockMinimo.Name = "EntradaStockMinimo";
                        this.EntradaStockMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMinimo.PasswordChar = '\0';
                        this.EntradaStockMinimo.Prefijo = "";
                        this.EntradaStockMinimo.SelectOnFocus = true;
                        this.EntradaStockMinimo.Size = new System.Drawing.Size(72, 24);
                        this.EntradaStockMinimo.Sufijo = "";
                        this.EntradaStockMinimo.TabIndex = 5;
                        this.EntradaStockMinimo.Text = "0";
                        this.EntradaStockMinimo.PlaceholderText = "";
                        this.EntradaStockMinimo.ToolTipText = "";
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(0, 56);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(140, 24);
                        this.Label11.TabIndex = 4;
                        this.Label11.Text = "Stock Mínimo";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaItem
                        // 
                        this.EntradaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaItem.AutoNav = true;
                        this.EntradaItem.AutoTab = true;
                        this.EntradaItem.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaItem.DecimalPlaces = -1;
                        this.EntradaItem.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaItem.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaItem.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaItem.Location = new System.Drawing.Point(224, 36);
                        this.EntradaItem.MaxLenght = 32767;
                        this.EntradaItem.MultiLine = false;
                        this.EntradaItem.Name = "EntradaItem";
                        this.EntradaItem.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaItem.PasswordChar = '\0';
                        this.EntradaItem.Prefijo = "";
                        this.EntradaItem.SelectOnFocus = true;
                        this.EntradaItem.Size = new System.Drawing.Size(108, 24);
                        this.EntradaItem.Sufijo = "";
                        this.EntradaItem.TabIndex = 1;
                        this.EntradaItem.TabStop = false;
                        this.EntradaItem.Text = "0";
                        this.EntradaItem.PlaceholderText = "";
                        this.EntradaItem.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.Location = new System.Drawing.Point(12, 36);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(212, 24);
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
                        this.EntradaGarantia.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGarantia.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGarantia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaGarantia.Location = new System.Drawing.Point(140, 168);
                        this.EntradaGarantia.MaxLenght = 32767;
                        this.EntradaGarantia.MultiLine = false;
                        this.EntradaGarantia.Name = "EntradaGarantia";
                        this.EntradaGarantia.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGarantia.PasswordChar = '\0';
                        this.EntradaGarantia.Prefijo = "";
                        this.EntradaGarantia.SelectOnFocus = true;
                        this.EntradaGarantia.Size = new System.Drawing.Size(104, 24);
                        this.EntradaGarantia.Sufijo = "meses";
                        this.EntradaGarantia.TabIndex = 13;
                        this.EntradaGarantia.Text = "0";
                        this.EntradaGarantia.PlaceholderText = "";
                        this.EntradaGarantia.ToolTipText = "Precio de costo o de compra.";
                        // 
                        // label20
                        // 
                        this.label20.Location = new System.Drawing.Point(0, 168);
                        this.label20.Name = "label20";
                        this.label20.Size = new System.Drawing.Size(140, 24);
                        this.label20.TabIndex = 12;
                        this.label20.Text = "Garantía";
                        this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSeguimiento
                        // 
                        this.EntradaSeguimiento.AlwaysExpanded = false;
                        this.EntradaSeguimiento.AutoNav = true;
                        this.EntradaSeguimiento.AutoTab = true;
                        this.EntradaSeguimiento.DetailField = null;
                        this.EntradaSeguimiento.Filter = null;
                        this.EntradaSeguimiento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSeguimiento.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSeguimiento.KeyField = null;
                        this.EntradaSeguimiento.Location = new System.Drawing.Point(140, 112);
                        this.EntradaSeguimiento.MaxLenght = 32767;
                        this.EntradaSeguimiento.Name = "EntradaSeguimiento";
                        this.EntradaSeguimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSeguimiento.SetData = new string[] {
        "Ninguno|0",
        "Por Números de Serie|3",
        "Por Variaciones|5"};
                        this.EntradaSeguimiento.Size = new System.Drawing.Size(236, 24);
                        this.EntradaSeguimiento.TabIndex = 9;
                        this.EntradaSeguimiento.Table = null;
                        this.EntradaSeguimiento.TextKey = "0";
                        this.EntradaSeguimiento.PlaceholderText = "";
                        this.EntradaSeguimiento.ToolTipText = "";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 112);
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
                        this.EntradaRubro.Filter = "";
                        this.EntradaRubro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaRubro.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaRubro.FreeTextCode = "";
                        this.EntradaRubro.Location = new System.Drawing.Point(140, 140);
                        this.EntradaRubro.MaxLength = 200;
                        this.EntradaRubro.Name = "EntradaRubro";
                        this.EntradaRubro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRubro.Required = true;
                        this.EntradaRubro.Size = new System.Drawing.Size(392, 24);
                        this.EntradaRubro.TabIndex = 11;
                        this.EntradaRubro.Table = "articulos_rubros";
                        this.EntradaRubro.Text = "0";
                        this.EntradaRubro.TextDetail = "";
                        this.EntradaRubro.PlaceholderText = "Sin especificar";
                        this.EntradaRubro.ToolTipText = "";
                        // 
                        // EntradaWeb
                        // 
                        this.EntradaWeb.AlwaysExpanded = false;
                        this.EntradaWeb.AutoNav = true;
                        this.EntradaWeb.AutoTab = true;
                        this.EntradaWeb.DetailField = null;
                        this.EntradaWeb.Filter = null;
                        this.EntradaWeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaWeb.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaWeb.KeyField = null;
                        this.EntradaWeb.Location = new System.Drawing.Point(140, 84);
                        this.EntradaWeb.MaxLenght = 32767;
                        this.EntradaWeb.Name = "EntradaWeb";
                        this.EntradaWeb.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaWeb.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaWeb.Size = new System.Drawing.Size(108, 24);
                        this.EntradaWeb.TabIndex = 7;
                        this.EntradaWeb.Table = null;
                        this.EntradaWeb.TextKey = "0";
                        this.EntradaWeb.PlaceholderText = "";
                        this.EntradaWeb.ToolTipText = "";
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(0, 84);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(140, 24);
                        this.Label7.TabIndex = 6;
                        this.Label7.Text = "Publicar en la Web*";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(0, 140);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(140, 24);
                        this.label9.TabIndex = 10;
                        this.label9.Text = "Rubro";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame2
                        // 
                        this.Frame2.Controls.Add(this.Label3);
                        this.Frame2.Controls.Add(this.EntradaItem);
                        this.Frame2.Controls.Add(this.EntradaStockActual);
                        this.Frame2.Controls.Add(this.Label2);
                        this.Frame2.Controls.Add(this.EntradaCosto);
                        this.Frame2.Controls.Add(this.Label4);
                        this.Frame2.Controls.Add(this.EntradaItemStock);
                        this.Frame2.Controls.Add(this.Label6);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame2.Location = new System.Drawing.Point(308, 188);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.Size = new System.Drawing.Size(348, 156);
                        this.Frame2.TabIndex = 1;
                        this.Frame2.TabStop = false;
                        this.Frame2.Text = "Estadsticas";
                        this.Frame2.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.Location = new System.Drawing.Point(12, 92);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(212, 24);
                        this.Label3.TabIndex = 4;
                        this.Label3.Text = "Stock Actual";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.AutoTab = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaStockActual.Location = new System.Drawing.Point(224, 92);
                        this.EntradaStockActual.MaxLenght = 32767;
                        this.EntradaStockActual.MultiLine = false;
                        this.EntradaStockActual.Name = "EntradaStockActual";
                        this.EntradaStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual.PasswordChar = '\0';
                        this.EntradaStockActual.Prefijo = "";
                        this.EntradaStockActual.SelectOnFocus = true;
                        this.EntradaStockActual.Size = new System.Drawing.Size(108, 24);
                        this.EntradaStockActual.Sufijo = "";
                        this.EntradaStockActual.TabIndex = 5;
                        this.EntradaStockActual.TabStop = false;
                        this.EntradaStockActual.Text = "0";
                        this.EntradaStockActual.PlaceholderText = "";
                        this.EntradaStockActual.ToolTipText = "";
                        // 
                        // EntradaCosto
                        // 
                        this.EntradaCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCosto.AutoNav = true;
                        this.EntradaCosto.AutoTab = true;
                        this.EntradaCosto.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCosto.DecimalPlaces = -1;
                        this.EntradaCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCosto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCosto.Location = new System.Drawing.Point(224, 120);
                        this.EntradaCosto.MaxLenght = 32767;
                        this.EntradaCosto.MultiLine = false;
                        this.EntradaCosto.Name = "EntradaCosto";
                        this.EntradaCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCosto.PasswordChar = '\0';
                        this.EntradaCosto.Prefijo = "$";
                        this.EntradaCosto.SelectOnFocus = true;
                        this.EntradaCosto.Size = new System.Drawing.Size(108, 24);
                        this.EntradaCosto.Sufijo = "";
                        this.EntradaCosto.TabIndex = 7;
                        this.EntradaCosto.TabStop = false;
                        this.EntradaCosto.Text = "0.00";
                        this.EntradaCosto.PlaceholderText = "";
                        this.EntradaCosto.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Location = new System.Drawing.Point(12, 120);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(212, 24);
                        this.Label4.TabIndex = 6;
                        this.Label4.Text = "Costo del Stock";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaItemStock
                        // 
                        this.EntradaItemStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaItemStock.AutoNav = true;
                        this.EntradaItemStock.AutoTab = true;
                        this.EntradaItemStock.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaItemStock.DecimalPlaces = -1;
                        this.EntradaItemStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaItemStock.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaItemStock.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaItemStock.Location = new System.Drawing.Point(224, 64);
                        this.EntradaItemStock.MaxLenght = 32767;
                        this.EntradaItemStock.MultiLine = false;
                        this.EntradaItemStock.Name = "EntradaItemStock";
                        this.EntradaItemStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaItemStock.PasswordChar = '\0';
                        this.EntradaItemStock.Prefijo = "";
                        this.EntradaItemStock.SelectOnFocus = true;
                        this.EntradaItemStock.Size = new System.Drawing.Size(108, 24);
                        this.EntradaItemStock.Sufijo = "";
                        this.EntradaItemStock.TabIndex = 3;
                        this.EntradaItemStock.TabStop = false;
                        this.EntradaItemStock.Text = "0";
                        this.EntradaItemStock.PlaceholderText = "";
                        this.EntradaItemStock.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.Location = new System.Drawing.Point(12, 64);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(212, 24);
                        this.Label6.TabIndex = 2;
                        this.Label6.Text = "Artículos con Stock";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
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
                        this.Size = new System.Drawing.Size(752, 349);
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
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaStockMinimo;
                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.Frame Frame2;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaNombreSing;
                internal Lui.Forms.TextBox EntradaItem;
                internal Lui.Forms.TextBox EntradaStockActual;
                internal Lui.Forms.TextBox EntradaCosto;
                internal Lui.Forms.TextBox EntradaItemStock;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.ComboBox EntradaWeb;
                internal System.Windows.Forms.Label Label7;
                private Lcc.Entrada.CodigoDetalle EntradaRubro;
                internal System.Windows.Forms.Label label9;
                internal Lui.Forms.ComboBox EntradaSeguimiento;
                internal System.Windows.Forms.Label label8;
                internal Lui.Forms.TextBox EntradaGarantia;
                internal System.Windows.Forms.Label label20;
        }
}
