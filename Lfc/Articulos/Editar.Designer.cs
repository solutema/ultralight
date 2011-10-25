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

namespace Lfc.Articulos
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Frame2 = new Lui.Forms.Frame();
                        this.EntradaMargen = new Lui.Forms.ComboBox();
                        this.EntradaCosto = new Lui.Forms.TextBox();
                        this.BotonInfoCosto = new Lui.Forms.Button();
                        this.EntradaPvp = new Lui.Forms.TextBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.EtiquetaAlicuota = new Lui.Forms.Label();
                        this.Label8 = new Lui.Forms.Label();
                        this.Label10 = new Lui.Forms.Label();
                        this.EntradaUnidad = new Lui.Forms.ComboBox();
                        this.EntradaUsaStock = new Lui.Forms.ComboBox();
                        this.BotonReceta = new Lui.Forms.Button();
                        this.BotonUnidad = new Lui.Forms.Button();
                        this.label19 = new Lui.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.label17 = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaStockMinimo = new Lui.Forms.TextBox();
                        this.Label11 = new Lui.Forms.Label();
                        this.Label9 = new Lui.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.EntradaDestacado = new Lui.Forms.ComboBox();
                        this.EntradaWeb = new Lui.Forms.ComboBox();
                        this.EntradaModelo = new Lui.Forms.TextBox();
                        this.EntradaGarantia = new Lui.Forms.TextBox();
                        this.EntradaCodigo4 = new Lui.Forms.TextBox();
                        this.EntradaProveedor = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaCategoria = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaMarca = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaCodigo3 = new Lui.Forms.TextBox();
                        this.EntradaDescripcion2 = new Lui.Forms.TextBox();
                        this.EntradaCodigo2 = new Lui.Forms.TextBox();
                        this.EntradaCodigo1 = new Lui.Forms.TextBox();
                        this.EntradaUrl = new Lui.Forms.TextBox();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaSerie = new Lui.Forms.TextBox();
                        this.EtiquetaCodigo1 = new Lui.Forms.Label();
                        this.EtiquetaCodigo4 = new Lui.Forms.Label();
                        this.EtiquetaCodigo3 = new Lui.Forms.Label();
                        this.EtiquetaCodigo2 = new Lui.Forms.Label();
                        this.label20 = new Lui.Forms.Label();
                        this.Label14 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label13 = new Lui.Forms.Label();
                        this.Label15 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.Label18 = new Lui.Forms.Label();
                        this.Label16 = new Lui.Forms.Label();
                        this.Label12 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.frame3 = new Lui.Forms.Frame();
                        this.BotonConformacion = new Lui.Forms.LinkLabel();
                        this.BotonHistorial = new Lui.Forms.LinkLabel();
                        this.Frame2.SuspendLayout();
                        this.Frame1.SuspendLayout();
                        this.frame3.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Frame2
                        // 
                        this.Frame2.Controls.Add(this.EntradaMargen);
                        this.Frame2.Controls.Add(this.EntradaCosto);
                        this.Frame2.Controls.Add(this.BotonInfoCosto);
                        this.Frame2.Controls.Add(this.EntradaPvp);
                        this.Frame2.Controls.Add(this.Label6);
                        this.Frame2.Controls.Add(this.EtiquetaAlicuota);
                        this.Frame2.Controls.Add(this.Label8);
                        this.Frame2.Controls.Add(this.Label10);
                        this.Frame2.Location = new System.Drawing.Point(0, 352);
                        this.Frame2.Margin = new System.Windows.Forms.Padding(0);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(356, 196);
                        this.Frame2.TabIndex = 1;
                        this.Frame2.Text = "Precio y Stock";
                        this.Frame2.ToolTipText = "";
                        // 
                        // EntradaMargen
                        // 
                        this.EntradaMargen.AlwaysExpanded = true;
                        this.EntradaMargen.AutoNav = true;
                        this.EntradaMargen.AutoTab = true;
                        this.EntradaMargen.Location = new System.Drawing.Point(76, 64);
                        this.EntradaMargen.Name = "EntradaMargen";
                        this.EntradaMargen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargen.PlaceholderText = "";
                        this.EntradaMargen.ReadOnly = false;
                        this.EntradaMargen.SetData = new string[] {
        "Otro|-1"};
                        this.EntradaMargen.Size = new System.Drawing.Size(276, 96);
                        this.EntradaMargen.TabIndex = 4;
                        this.EntradaMargen.TextKey = "-1";
                        this.EntradaMargen.ToolTipText = "Márgenes predefinidos";
                        this.EntradaMargen.TextChanged += new System.EventHandler(this.EntradaCostoMargen_TextChanged);
                        // 
                        // EntradaCosto
                        // 
                        this.EntradaCosto.AutoNav = true;
                        this.EntradaCosto.AutoTab = true;
                        this.EntradaCosto.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCosto.DecimalPlaces = -1;
                        this.EntradaCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCosto.Location = new System.Drawing.Point(76, 32);
                        this.EntradaCosto.MultiLine = false;
                        this.EntradaCosto.Name = "EntradaCosto";
                        this.EntradaCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCosto.PlaceholderText = "";
                        this.EntradaCosto.Prefijo = "$";
                        this.EntradaCosto.ReadOnly = false;
                        this.EntradaCosto.SelectOnFocus = true;
                        this.EntradaCosto.Size = new System.Drawing.Size(108, 24);
                        this.EntradaCosto.TabIndex = 1;
                        this.EntradaCosto.Text = "0.00";
                        this.EntradaCosto.ToolTipText = "Precio de costo o de compra.";
                        this.EntradaCosto.GotFocus += new System.EventHandler(this.EntradaCosto_GotFocus);
                        this.EntradaCosto.TextChanged += new System.EventHandler(this.EntradaCostoMargen_TextChanged);
                        // 
                        // BotonInfoCosto
                        // 
                        this.BotonInfoCosto.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonInfoCosto.Image = null;
                        this.BotonInfoCosto.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonInfoCosto.Location = new System.Drawing.Point(184, 32);
                        this.BotonInfoCosto.Name = "BotonInfoCosto";
                        this.BotonInfoCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonInfoCosto.ReadOnly = false;
                        this.BotonInfoCosto.Size = new System.Drawing.Size(28, 24);
                        this.BotonInfoCosto.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonInfoCosto.Subtext = "";
                        this.BotonInfoCosto.TabIndex = 2;
                        this.BotonInfoCosto.Text = "...";
                        this.BotonInfoCosto.ToolTipText = "Ver más datos sobre el precio";
                        this.BotonInfoCosto.Click += new System.EventHandler(this.BotonMasInfo_Click);
                        // 
                        // EntradaPvp
                        // 
                        this.EntradaPvp.AutoNav = true;
                        this.EntradaPvp.AutoTab = true;
                        this.EntradaPvp.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaPvp.DecimalPlaces = -1;
                        this.EntradaPvp.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPvp.Location = new System.Drawing.Point(76, 168);
                        this.EntradaPvp.MultiLine = false;
                        this.EntradaPvp.Name = "EntradaPvp";
                        this.EntradaPvp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPvp.PlaceholderText = "";
                        this.EntradaPvp.Prefijo = "$";
                        this.EntradaPvp.ReadOnly = false;
                        this.EntradaPvp.SelectOnFocus = true;
                        this.EntradaPvp.Size = new System.Drawing.Size(108, 24);
                        this.EntradaPvp.TabIndex = 6;
                        this.EntradaPvp.Text = "0.00";
                        this.EntradaPvp.ToolTipText = "Precio de venta al público. Puede dejar el PVP en blanco y utilizar un márgen pre" +
                            "definido a continuación";
                        this.EntradaPvp.TextChanged += new System.EventHandler(this.EntradaPvp_TextChanged);
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(0, 32);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(76, 24);
                        this.Label6.TabIndex = 0;
                        this.Label6.Text = "Costo";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaAlicuota
                        // 
                        this.EtiquetaAlicuota.Location = new System.Drawing.Point(188, 168);
                        this.EtiquetaAlicuota.Name = "EtiquetaAlicuota";
                        this.EtiquetaAlicuota.Size = new System.Drawing.Size(164, 24);
                        this.EtiquetaAlicuota.TabIndex = 7;
                        this.EtiquetaAlicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(0, 64);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(76, 24);
                        this.Label8.TabIndex = 3;
                        this.Label8.Text = "Margen";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(0, 168);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(76, 24);
                        this.Label10.TabIndex = 5;
                        this.Label10.Text = "PVP";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaUnidad
                        // 
                        this.EntradaUnidad.AlwaysExpanded = true;
                        this.EntradaUnidad.AutoNav = true;
                        this.EntradaUnidad.AutoSize = true;
                        this.EntradaUnidad.AutoTab = true;
                        this.EntradaUnidad.Location = new System.Drawing.Point(324, 32);
                        this.EntradaUnidad.Name = "EntradaUnidad";
                        this.EntradaUnidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUnidad.PlaceholderText = "";
                        this.EntradaUnidad.ReadOnly = false;
                        this.EntradaUnidad.SetData = new string[] {
        "N/A|",
        "Unidades|u",
        "Bolsas|bolsa",
        "Baldes|balde",
        "Rollos|rollo",
        "Cajas|caja",
        "Fajos|fajo",
        "Metros|m",
        "Metros²|m²",
        "Metros³|m³",
        "Centímetros|cm",
        "Centímetros³|cm³",
        "Litros|l",
        "Kg|kg"};
                        this.EntradaUnidad.Size = new System.Drawing.Size(120, 81);
                        this.EntradaUnidad.TabIndex = 10;
                        this.EntradaUnidad.TextKey = "u";
                        this.EntradaUnidad.ToolTipText = "¿El artículo usa control de stock?";
                        this.EntradaUnidad.Enter += new System.EventHandler(this.EntradaPvp_Enter);
                        // 
                        // EntradaUsaStock
                        // 
                        this.EntradaUsaStock.AlwaysExpanded = true;
                        this.EntradaUsaStock.AutoNav = true;
                        this.EntradaUsaStock.AutoSize = true;
                        this.EntradaUsaStock.AutoTab = true;
                        this.EntradaUsaStock.Location = new System.Drawing.Point(80, 32);
                        this.EntradaUsaStock.Name = "EntradaUsaStock";
                        this.EntradaUsaStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsaStock.PlaceholderText = "";
                        this.EntradaUsaStock.ReadOnly = false;
                        this.EntradaUsaStock.SetData = new string[] {
        "No|0",
        "Normal|1",
        "Compuesto|2"};
                        this.EntradaUsaStock.Size = new System.Drawing.Size(120, 51);
                        this.EntradaUsaStock.TabIndex = 1;
                        this.EntradaUsaStock.TextKey = "1";
                        this.EntradaUsaStock.ToolTipText = "¿El artículo usa control de stock?";
                        this.EntradaUsaStock.TextChanged += new System.EventHandler(this.EntradaUsaStock_TextChanged);
                        // 
                        // BotonReceta
                        // 
                        this.BotonReceta.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonReceta.Image = null;
                        this.BotonReceta.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonReceta.Location = new System.Drawing.Point(202, 34);
                        this.BotonReceta.Name = "BotonReceta";
                        this.BotonReceta.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonReceta.ReadOnly = false;
                        this.BotonReceta.Size = new System.Drawing.Size(28, 24);
                        this.BotonReceta.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonReceta.Subtext = "";
                        this.BotonReceta.TabIndex = 2;
                        this.BotonReceta.Text = "...";
                        this.BotonReceta.ToolTipText = "Ver receta";
                        this.BotonReceta.Visible = false;
                        this.BotonReceta.Click += new System.EventHandler(this.BotonReceta_Click);
                        // 
                        // BotonUnidad
                        // 
                        this.BotonUnidad.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonUnidad.Image = null;
                        this.BotonUnidad.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonUnidad.Location = new System.Drawing.Point(446, 34);
                        this.BotonUnidad.Name = "BotonUnidad";
                        this.BotonUnidad.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonUnidad.ReadOnly = false;
                        this.BotonUnidad.Size = new System.Drawing.Size(28, 24);
                        this.BotonUnidad.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonUnidad.Subtext = "";
                        this.BotonUnidad.TabIndex = 11;
                        this.BotonUnidad.Text = "...";
                        this.BotonUnidad.ToolTipText = "Ver historial de movimientos de stock";
                        this.BotonUnidad.Click += new System.EventHandler(this.BotonUnidad_Click);
                        // 
                        // label19
                        // 
                        this.label19.Location = new System.Drawing.Point(244, 32);
                        this.label19.Name = "label19";
                        this.label19.Size = new System.Drawing.Size(80, 24);
                        this.label19.TabIndex = 9;
                        this.label19.Text = "Unidad";
                        this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCaja
                        // 
                        this.EntradaCaja.AutoNav = true;
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DataTextField = "nombre";
                        this.EntradaCaja.DataValueField = "id_caja";
                        this.EntradaCaja.ExtraDetailFields = null;
                        this.EntradaCaja.Filter = "id_caja>999";
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.Location = new System.Drawing.Point(116, 168);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.PlaceholderText = "Sin especificar";
                        this.EntradaCaja.ReadOnly = false;
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(296, 24);
                        this.EntradaCaja.TabIndex = 13;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.ToolTipText = "";
                        // 
                        // label17
                        // 
                        this.label17.Location = new System.Drawing.Point(-4, 168);
                        this.label17.Name = "label17";
                        this.label17.Size = new System.Drawing.Size(116, 24);
                        this.label17.TabIndex = 12;
                        this.label17.Text = "Caja asociada";
                        this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(0, 32);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(80, 24);
                        this.Label7.TabIndex = 0;
                        this.Label7.Text = "Usa Stock";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockMinimo
                        // 
                        this.EntradaStockMinimo.AutoNav = true;
                        this.EntradaStockMinimo.AutoTab = true;
                        this.EntradaStockMinimo.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaStockMinimo.DecimalPlaces = -1;
                        this.EntradaStockMinimo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockMinimo.Location = new System.Drawing.Point(100, 92);
                        this.EntradaStockMinimo.MultiLine = false;
                        this.EntradaStockMinimo.Name = "EntradaStockMinimo";
                        this.EntradaStockMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMinimo.PlaceholderText = "";
                        this.EntradaStockMinimo.ReadOnly = false;
                        this.EntradaStockMinimo.SelectOnFocus = true;
                        this.EntradaStockMinimo.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockMinimo.TabIndex = 4;
                        this.EntradaStockMinimo.Text = "0.00";
                        this.EntradaStockMinimo.ToolTipText = "Stock mínimo o crítico";
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(0, 92);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(96, 24);
                        this.Label11.TabIndex = 3;
                        this.Label11.Text = "Stock Mínimo";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label9
                        // 
                        this.Label9.Location = new System.Drawing.Point(0, 124);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(96, 24);
                        this.Label9.TabIndex = 5;
                        this.Label9.Text = "Stock Actual";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.AutoTab = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.Location = new System.Drawing.Point(100, 124);
                        this.EntradaStockActual.MultiLine = false;
                        this.EntradaStockActual.Name = "EntradaStockActual";
                        this.EntradaStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual.PlaceholderText = "";
                        this.EntradaStockActual.ReadOnly = false;
                        this.EntradaStockActual.SelectOnFocus = true;
                        this.EntradaStockActual.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockActual.TabIndex = 6;
                        this.EntradaStockActual.TabStop = false;
                        this.EntradaStockActual.Text = "0.00";
                        this.EntradaStockActual.ToolTipText = "";
                        this.EntradaStockActual.TextChanged += new System.EventHandler(this.EntradaStockActual_TextChanged);
                        // 
                        // Frame1
                        // 
                        this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame1.Controls.Add(this.EntradaDestacado);
                        this.Frame1.Controls.Add(this.EntradaWeb);
                        this.Frame1.Controls.Add(this.EntradaModelo);
                        this.Frame1.Controls.Add(this.EntradaGarantia);
                        this.Frame1.Controls.Add(this.EntradaCodigo4);
                        this.Frame1.Controls.Add(this.EntradaProveedor);
                        this.Frame1.Controls.Add(this.EntradaCategoria);
                        this.Frame1.Controls.Add(this.EntradaMarca);
                        this.Frame1.Controls.Add(this.EntradaCodigo3);
                        this.Frame1.Controls.Add(this.EntradaDescripcion2);
                        this.Frame1.Controls.Add(this.EntradaCodigo2);
                        this.Frame1.Controls.Add(this.EntradaCodigo1);
                        this.Frame1.Controls.Add(this.EntradaUrl);
                        this.Frame1.Controls.Add(this.EntradaDescripcion);
                        this.Frame1.Controls.Add(this.EntradaNombre);
                        this.Frame1.Controls.Add(this.EntradaSerie);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo1);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo4);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo3);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo2);
                        this.Frame1.Controls.Add(this.label20);
                        this.Frame1.Controls.Add(this.Label14);
                        this.Frame1.Controls.Add(this.Label2);
                        this.Frame1.Controls.Add(this.Label13);
                        this.Frame1.Controls.Add(this.Label15);
                        this.Frame1.Controls.Add(this.Label3);
                        this.Frame1.Controls.Add(this.Label4);
                        this.Frame1.Controls.Add(this.Label1);
                        this.Frame1.Controls.Add(this.Label18);
                        this.Frame1.Controls.Add(this.Label16);
                        this.Frame1.Controls.Add(this.Label12);
                        this.Frame1.Controls.Add(this.Label5);
                        this.Frame1.Location = new System.Drawing.Point(0, 0);
                        this.Frame1.Margin = new System.Windows.Forms.Padding(0);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.ReadOnly = false;
                        this.Frame1.Size = new System.Drawing.Size(986, 348);
                        this.Frame1.TabIndex = 0;
                        this.Frame1.Text = "Detalles de Artículo";
                        this.Frame1.ToolTipText = "";
                        // 
                        // EntradaDestacado
                        // 
                        this.EntradaDestacado.AlwaysExpanded = true;
                        this.EntradaDestacado.AutoNav = true;
                        this.EntradaDestacado.AutoSize = true;
                        this.EntradaDestacado.AutoTab = true;
                        this.EntradaDestacado.Location = new System.Drawing.Point(76, 292);
                        this.EntradaDestacado.Name = "EntradaDestacado";
                        this.EntradaDestacado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDestacado.PlaceholderText = "";
                        this.EntradaDestacado.ReadOnly = false;
                        this.EntradaDestacado.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaDestacado.Size = new System.Drawing.Size(64, 36);
                        this.EntradaDestacado.TabIndex = 23;
                        this.EntradaDestacado.TextKey = "0";
                        this.EntradaDestacado.ToolTipText = "";
                        // 
                        // EntradaWeb
                        // 
                        this.EntradaWeb.AlwaysExpanded = true;
                        this.EntradaWeb.AutoNav = true;
                        this.EntradaWeb.AutoSize = true;
                        this.EntradaWeb.AutoTab = true;
                        this.EntradaWeb.Location = new System.Drawing.Point(228, 292);
                        this.EntradaWeb.Name = "EntradaWeb";
                        this.EntradaWeb.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaWeb.PlaceholderText = "";
                        this.EntradaWeb.ReadOnly = false;
                        this.EntradaWeb.SetData = new string[] {
        "Siempre|1",
        "Sólo si hay Stock o Pedidos|2",
        "Nunca|0"};
                        this.EntradaWeb.Size = new System.Drawing.Size(212, 51);
                        this.EntradaWeb.TabIndex = 25;
                        this.EntradaWeb.TextKey = "2";
                        this.EntradaWeb.ToolTipText = "";
                        // 
                        // EntradaModelo
                        // 
                        this.EntradaModelo.AutoNav = true;
                        this.EntradaModelo.AutoTab = true;
                        this.EntradaModelo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaModelo.DecimalPlaces = -1;
                        this.EntradaModelo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaModelo.Location = new System.Drawing.Point(76, 92);
                        this.EntradaModelo.MultiLine = false;
                        this.EntradaModelo.Name = "EntradaModelo";
                        this.EntradaModelo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModelo.PlaceholderText = "";
                        this.EntradaModelo.ReadOnly = false;
                        this.EntradaModelo.SelectOnFocus = false;
                        this.EntradaModelo.Size = new System.Drawing.Size(292, 24);
                        this.EntradaModelo.TabIndex = 9;
                        this.EntradaModelo.ToolTipText = "";
                        this.EntradaModelo.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EntradaGarantia
                        // 
                        this.EntradaGarantia.AutoNav = true;
                        this.EntradaGarantia.AutoTab = true;
                        this.EntradaGarantia.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaGarantia.DecimalPlaces = -1;
                        this.EntradaGarantia.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGarantia.Location = new System.Drawing.Point(536, 292);
                        this.EntradaGarantia.MultiLine = false;
                        this.EntradaGarantia.Name = "EntradaGarantia";
                        this.EntradaGarantia.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGarantia.PlaceholderText = "";
                        this.EntradaGarantia.ReadOnly = false;
                        this.EntradaGarantia.SelectOnFocus = true;
                        this.EntradaGarantia.Size = new System.Drawing.Size(104, 24);
                        this.EntradaGarantia.Sufijo = "meses";
                        this.EntradaGarantia.TabIndex = 27;
                        this.EntradaGarantia.Text = "0";
                        this.EntradaGarantia.ToolTipText = "Precio de costo o de compra.";
                        // 
                        // EntradaCodigo4
                        // 
                        this.EntradaCodigo4.AutoNav = true;
                        this.EntradaCodigo4.AutoTab = true;
                        this.EntradaCodigo4.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo4.DecimalPlaces = -1;
                        this.EntradaCodigo4.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo4.Location = new System.Drawing.Point(772, 32);
                        this.EntradaCodigo4.MultiLine = false;
                        this.EntradaCodigo4.Name = "EntradaCodigo4";
                        this.EntradaCodigo4.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo4.PlaceholderText = "";
                        this.EntradaCodigo4.ReadOnly = false;
                        this.EntradaCodigo4.SelectOnFocus = true;
                        this.EntradaCodigo4.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo4.TabIndex = 3;
                        this.EntradaCodigo4.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EntradaProveedor
                        // 
                        this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProveedor.AutoNav = true;
                        this.EntradaProveedor.AutoTab = true;
                        this.EntradaProveedor.CanCreate = true;
                        this.EntradaProveedor.DataTextField = "nombre_visible";
                        this.EntradaProveedor.DataValueField = "id_persona";
                        this.EntradaProveedor.ExtraDetailFields = null;
                        this.EntradaProveedor.Filter = "(tipo&2)=2";
                        this.EntradaProveedor.FreeTextCode = "";
                        this.EntradaProveedor.Location = new System.Drawing.Point(613, 148);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.PlaceholderText = "Sin especificar";
                        this.EntradaProveedor.ReadOnly = false;
                        this.EntradaProveedor.Required = false;
                        this.EntradaProveedor.Size = new System.Drawing.Size(373, 24);
                        this.EntradaProveedor.TabIndex = 17;
                        this.EntradaProveedor.Table = "personas";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        this.EntradaProveedor.ToolTipText = "";
                        // 
                        // EntradaCategoria
                        // 
                        this.EntradaCategoria.AutoNav = true;
                        this.EntradaCategoria.AutoTab = true;
                        this.EntradaCategoria.CanCreate = true;
                        this.EntradaCategoria.DataTextField = "nombre";
                        this.EntradaCategoria.DataValueField = "id_categoria";
                        this.EntradaCategoria.ExtraDetailFields = null;
                        this.EntradaCategoria.Filter = "";
                        this.EntradaCategoria.FreeTextCode = "";
                        this.EntradaCategoria.Location = new System.Drawing.Point(76, 64);
                        this.EntradaCategoria.MaxLength = 200;
                        this.EntradaCategoria.Name = "EntradaCategoria";
                        this.EntradaCategoria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCategoria.PlaceholderText = "";
                        this.EntradaCategoria.ReadOnly = false;
                        this.EntradaCategoria.Required = true;
                        this.EntradaCategoria.Size = new System.Drawing.Size(292, 24);
                        this.EntradaCategoria.TabIndex = 5;
                        this.EntradaCategoria.Table = "articulos_categorias";
                        this.EntradaCategoria.Text = "0";
                        this.EntradaCategoria.TextDetail = "";
                        this.EntradaCategoria.ToolTipText = "Rubro o categoría";
                        this.EntradaCategoria.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EntradaMarca
                        // 
                        this.EntradaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaMarca.AutoNav = true;
                        this.EntradaMarca.AutoTab = true;
                        this.EntradaMarca.CanCreate = true;
                        this.EntradaMarca.DataTextField = "nombre";
                        this.EntradaMarca.DataValueField = "id_marca";
                        this.EntradaMarca.ExtraDetailFields = null;
                        this.EntradaMarca.Filter = "";
                        this.EntradaMarca.FreeTextCode = "";
                        this.EntradaMarca.Location = new System.Drawing.Point(436, 64);
                        this.EntradaMarca.MaxLength = 200;
                        this.EntradaMarca.Name = "EntradaMarca";
                        this.EntradaMarca.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMarca.PlaceholderText = "Sin especificar";
                        this.EntradaMarca.ReadOnly = false;
                        this.EntradaMarca.Required = false;
                        this.EntradaMarca.Size = new System.Drawing.Size(550, 24);
                        this.EntradaMarca.TabIndex = 7;
                        this.EntradaMarca.Table = "marcas";
                        this.EntradaMarca.Text = "0";
                        this.EntradaMarca.TextDetail = "";
                        this.EntradaMarca.ToolTipText = "";
                        this.EntradaMarca.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EntradaCodigo3
                        // 
                        this.EntradaCodigo3.AutoNav = true;
                        this.EntradaCodigo3.AutoTab = true;
                        this.EntradaCodigo3.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo3.DecimalPlaces = -1;
                        this.EntradaCodigo3.ForceCase = Lui.Forms.TextCasing.UpperCase;
                        this.EntradaCodigo3.Location = new System.Drawing.Point(540, 32);
                        this.EntradaCodigo3.MultiLine = false;
                        this.EntradaCodigo3.Name = "EntradaCodigo3";
                        this.EntradaCodigo3.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo3.PlaceholderText = "";
                        this.EntradaCodigo3.ReadOnly = false;
                        this.EntradaCodigo3.SelectOnFocus = true;
                        this.EntradaCodigo3.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo3.TabIndex = 1;
                        this.EntradaCodigo3.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EntradaDescripcion2
                        // 
                        this.EntradaDescripcion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDescripcion2.AutoNav = true;
                        this.EntradaDescripcion2.AutoTab = true;
                        this.EntradaDescripcion2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion2.DecimalPlaces = -1;
                        this.EntradaDescripcion2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion2.Location = new System.Drawing.Point(484, 180);
                        this.EntradaDescripcion2.MultiLine = true;
                        this.EntradaDescripcion2.Name = "EntradaDescripcion2";
                        this.EntradaDescripcion2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion2.PlaceholderText = "";
                        this.EntradaDescripcion2.ReadOnly = false;
                        this.EntradaDescripcion2.SelectOnFocus = false;
                        this.EntradaDescripcion2.Size = new System.Drawing.Size(502, 104);
                        this.EntradaDescripcion2.TabIndex = 21;
                        this.EntradaDescripcion2.ToolTipText = "Descripción larga";
                        // 
                        // EntradaCodigo2
                        // 
                        this.EntradaCodigo2.AutoNav = true;
                        this.EntradaCodigo2.AutoTab = true;
                        this.EntradaCodigo2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo2.DecimalPlaces = -1;
                        this.EntradaCodigo2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo2.Location = new System.Drawing.Point(312, 32);
                        this.EntradaCodigo2.MultiLine = false;
                        this.EntradaCodigo2.Name = "EntradaCodigo2";
                        this.EntradaCodigo2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo2.PlaceholderText = "";
                        this.EntradaCodigo2.ReadOnly = false;
                        this.EntradaCodigo2.SelectOnFocus = true;
                        this.EntradaCodigo2.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo2.TabIndex = 3;
                        this.EntradaCodigo2.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EntradaCodigo1
                        // 
                        this.EntradaCodigo1.AutoNav = true;
                        this.EntradaCodigo1.AutoTab = true;
                        this.EntradaCodigo1.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo1.DecimalPlaces = -1;
                        this.EntradaCodigo1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo1.Location = new System.Drawing.Point(84, 32);
                        this.EntradaCodigo1.MultiLine = false;
                        this.EntradaCodigo1.Name = "EntradaCodigo1";
                        this.EntradaCodigo1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo1.PlaceholderText = "";
                        this.EntradaCodigo1.ReadOnly = false;
                        this.EntradaCodigo1.SelectOnFocus = true;
                        this.EntradaCodigo1.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo1.TabIndex = 1;
                        this.EntradaCodigo1.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EntradaUrl
                        // 
                        this.EntradaUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUrl.AutoNav = true;
                        this.EntradaUrl.AutoTab = true;
                        this.EntradaUrl.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaUrl.DecimalPlaces = -1;
                        this.EntradaUrl.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUrl.Location = new System.Drawing.Point(76, 148);
                        this.EntradaUrl.MultiLine = false;
                        this.EntradaUrl.Name = "EntradaUrl";
                        this.EntradaUrl.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUrl.PlaceholderText = "";
                        this.EntradaUrl.ReadOnly = false;
                        this.EntradaUrl.SelectOnFocus = false;
                        this.EntradaUrl.Size = new System.Drawing.Size(450, 24);
                        this.EntradaUrl.TabIndex = 15;
                        this.EntradaUrl.ToolTipText = "Dirección de la página web del producto.";
                        // 
                        // EntradaDescripcion
                        // 
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.AutoTab = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion.Location = new System.Drawing.Point(76, 180);
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "EntradaDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.PlaceholderText = "";
                        this.EntradaDescripcion.ReadOnly = false;
                        this.EntradaDescripcion.SelectOnFocus = false;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(320, 104);
                        this.EntradaDescripcion.TabIndex = 19;
                        this.EntradaDescripcion.ToolTipText = "Descripción larga";
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.Location = new System.Drawing.Point(76, 120);
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(910, 24);
                        this.EntradaNombre.TabIndex = 13;
                        this.EntradaNombre.ToolTipText = "Nombre completo del artículo";
                        this.EntradaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaNombre_KeyPress);
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.EntradaNombre_TextChanged);
                        // 
                        // EntradaSerie
                        // 
                        this.EntradaSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSerie.AutoNav = true;
                        this.EntradaSerie.AutoTab = true;
                        this.EntradaSerie.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaSerie.DecimalPlaces = -1;
                        this.EntradaSerie.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSerie.Location = new System.Drawing.Point(436, 92);
                        this.EntradaSerie.MultiLine = false;
                        this.EntradaSerie.Name = "EntradaSerie";
                        this.EntradaSerie.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSerie.PlaceholderText = "";
                        this.EntradaSerie.ReadOnly = false;
                        this.EntradaSerie.SelectOnFocus = false;
                        this.EntradaSerie.Size = new System.Drawing.Size(550, 24);
                        this.EntradaSerie.TabIndex = 11;
                        this.EntradaSerie.ToolTipText = "";
                        this.EntradaSerie.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EtiquetaCodigo1
                        // 
                        this.EtiquetaCodigo1.Location = new System.Drawing.Point(0, 32);
                        this.EtiquetaCodigo1.Name = "EtiquetaCodigo1";
                        this.EtiquetaCodigo1.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo1.TabIndex = 0;
                        this.EtiquetaCodigo1.Text = "Código 1";
                        this.EtiquetaCodigo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaCodigo4
                        // 
                        this.EtiquetaCodigo4.Location = new System.Drawing.Point(688, 32);
                        this.EtiquetaCodigo4.Name = "EtiquetaCodigo4";
                        this.EtiquetaCodigo4.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo4.TabIndex = 2;
                        this.EtiquetaCodigo4.Text = "Código 4";
                        this.EtiquetaCodigo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaCodigo3
                        // 
                        this.EtiquetaCodigo3.Location = new System.Drawing.Point(456, 32);
                        this.EtiquetaCodigo3.Name = "EtiquetaCodigo3";
                        this.EtiquetaCodigo3.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo3.TabIndex = 4;
                        this.EtiquetaCodigo3.Text = "Código 3";
                        this.EtiquetaCodigo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaCodigo2
                        // 
                        this.EtiquetaCodigo2.Location = new System.Drawing.Point(228, 32);
                        this.EtiquetaCodigo2.Name = "EtiquetaCodigo2";
                        this.EtiquetaCodigo2.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo2.TabIndex = 2;
                        this.EtiquetaCodigo2.Text = "Código 2";
                        this.EtiquetaCodigo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label20
                        // 
                        this.label20.Location = new System.Drawing.Point(460, 292);
                        this.label20.Name = "label20";
                        this.label20.Size = new System.Drawing.Size(76, 24);
                        this.label20.TabIndex = 26;
                        this.label20.Text = "Garantía";
                        this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label14
                        // 
                        this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label14.Location = new System.Drawing.Point(533, 148);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(80, 24);
                        this.Label14.TabIndex = 16;
                        this.Label14.Text = "Proveedor";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(0, 64);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(76, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Categoría";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label13
                        // 
                        this.Label13.Location = new System.Drawing.Point(0, 180);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(76, 24);
                        this.Label13.TabIndex = 18;
                        this.Label13.Text = "Descrip.";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(0, 292);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(76, 24);
                        this.Label15.TabIndex = 22;
                        this.Label15.Text = "Destacado";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(0, 92);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(76, 24);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Modelo";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(384, 92);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(52, 24);
                        this.Label4.TabIndex = 10;
                        this.Label4.Text = "Serie";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(384, 64);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(52, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Marca";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label18
                        // 
                        this.Label18.Location = new System.Drawing.Point(404, 180);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(76, 32);
                        this.Label18.TabIndex = 20;
                        this.Label18.Text = "Descrip. Extendida";
                        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(156, 292);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(72, 24);
                        this.Label16.TabIndex = 24;
                        this.Label16.Text = "Publicar";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label12
                        // 
                        this.Label12.Location = new System.Drawing.Point(0, 148);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(76, 24);
                        this.Label12.TabIndex = 14;
                        this.Label12.Text = "URL";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(0, 120);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(76, 24);
                        this.Label5.TabIndex = 12;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // frame3
                        // 
                        this.frame3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame3.Controls.Add(this.EntradaCaja);
                        this.frame3.Controls.Add(this.BotonConformacion);
                        this.frame3.Controls.Add(this.BotonHistorial);
                        this.frame3.Controls.Add(this.BotonReceta);
                        this.frame3.Controls.Add(this.EntradaStockActual);
                        this.frame3.Controls.Add(this.EntradaUnidad);
                        this.frame3.Controls.Add(this.EntradaUsaStock);
                        this.frame3.Controls.Add(this.BotonUnidad);
                        this.frame3.Controls.Add(this.EntradaStockMinimo);
                        this.frame3.Controls.Add(this.label17);
                        this.frame3.Controls.Add(this.Label7);
                        this.frame3.Controls.Add(this.label19);
                        this.frame3.Controls.Add(this.Label11);
                        this.frame3.Controls.Add(this.Label9);
                        this.frame3.Location = new System.Drawing.Point(372, 352);
                        this.frame3.Margin = new System.Windows.Forms.Padding(0);
                        this.frame3.Name = "frame3";
                        this.frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.frame3.ReadOnly = false;
                        this.frame3.Size = new System.Drawing.Size(612, 192);
                        this.frame3.TabIndex = 2;
                        this.frame3.TabStop = false;
                        this.frame3.Text = "Stock";
                        this.frame3.ToolTipText = "";
                        // 
                        // BotonConformacion
                        // 
                        this.BotonConformacion.Location = new System.Drawing.Point(288, 124);
                        this.BotonConformacion.Name = "BotonConformacion";
                        this.BotonConformacion.Size = new System.Drawing.Size(100, 24);
                        this.BotonConformacion.TabIndex = 8;
                        this.BotonConformacion.TabStop = true;
                        this.BotonConformacion.Text = "Conformación";
                        this.BotonConformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonConformacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonConformacion_LinkClicked);
                        // 
                        // BotonHistorial
                        // 
                        this.BotonHistorial.Location = new System.Drawing.Point(204, 124);
                        this.BotonHistorial.Name = "BotonHistorial";
                        this.BotonHistorial.Size = new System.Drawing.Size(76, 24);
                        this.BotonHistorial.TabIndex = 7;
                        this.BotonHistorial.TabStop = true;
                        this.BotonHistorial.Text = "Historial";
                        this.BotonHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonHistorial_LinkClicked);
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.frame3);
                        this.Controls.Add(this.Frame2);
                        this.Controls.Add(this.Frame1);
                        this.MinimumSize = new System.Drawing.Size(640, 560);
                        this.Name = "Editar";
                        this.Padding = new System.Windows.Forms.Padding(0);
                        this.Size = new System.Drawing.Size(987, 560);
                        this.Controls.SetChildIndex(this.Frame1, 0);
                        this.Controls.SetChildIndex(this.Frame2, 0);
                        this.Controls.SetChildIndex(this.frame3, 0);
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.frame3.ResumeLayout(false);
                        this.frame3.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.ComboBox EntradaUnidad;
                internal Lui.Forms.Label label19;
                internal Lui.Forms.Button BotonUnidad;
                internal Lui.Forms.Label Label15;
                internal Lui.Forms.TextBox EntradaCodigo4;
                internal Lui.Forms.Label EtiquetaCodigo4;
                internal Lui.Forms.TextBox EntradaCodigo3;
                internal Lui.Forms.Label EtiquetaCodigo3;
                internal Lui.Forms.TextBox EntradaCodigo2;
                internal Lui.Forms.Label EtiquetaCodigo2;
                internal Lui.Forms.TextBox EntradaCodigo1;
                internal Lui.Forms.Label EtiquetaCodigo1;
                internal Lcc.Entrada.CodigoDetalle EntradaProveedor;
                internal Lui.Forms.Label Label14;
                internal Lui.Forms.TextBox EntradaDescripcion;
                internal Lui.Forms.Label Label13;
                internal Lui.Forms.TextBox EntradaUrl;
                internal Lui.Forms.Label Label12;
                internal Lui.Forms.TextBox EntradaStockMinimo;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.TextBox EntradaPvp;
                internal Lui.Forms.Label Label10;
                internal Lui.Forms.TextBox EntradaStockActual;
                internal Lui.Forms.Label Label9;
                internal Lui.Forms.ComboBox EntradaMargen;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.ComboBox EntradaUsaStock;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaCosto;
                internal Lui.Forms.Label Label6;
                internal Lui.Forms.Frame Frame2;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaSerie;
                internal Lui.Forms.TextBox EntradaModelo;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaCategoria;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaMarca;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.ComboBox EntradaDestacado;
                internal Lui.Forms.Button BotonInfoCosto;
                internal Lui.Forms.Label Label16;
                internal Lui.Forms.ComboBox EntradaWeb;
                internal Lui.Forms.TextBox EntradaDescripcion2;
                internal Lui.Forms.Label Label18;
                internal Lcc.Entrada.CodigoDetalle EntradaCaja;
                internal Lui.Forms.Label label17;
                internal Lui.Forms.TextBox EntradaGarantia;
                internal Lui.Forms.Label label20;
                internal Lui.Forms.Button BotonReceta;
                internal Lui.Forms.Label EtiquetaAlicuota;
                private Lui.Forms.Frame frame3;
                private Lui.Forms.LinkLabel BotonConformacion;
                private Lui.Forms.LinkLabel BotonHistorial;
        }
}
