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

namespace Lfc.Articulos
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Frame2 = new Lui.Forms.Frame();
                        this.EntradaCosto = new Lui.Forms.TextBox();
                        this.EntradaMargen = new Lui.Forms.ComboBox();
                        this.BotonInfoCosto = new Lui.Forms.Button();
                        this.EntradaPvp = new Lui.Forms.TextBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.Label8 = new Lui.Forms.Label();
                        this.EtiquetaAlicuota = new Lui.Forms.Label();
                        this.Label10 = new Lui.Forms.Label();
                        this.label17 = new Lui.Forms.Label();
                        this.EntradaUnidad = new Lui.Forms.ComboBox();
                        this.EntradaUsaStock = new Lui.Forms.ComboBox();
                        this.BotonReceta = new Lui.Forms.Button();
                        this.BotonUnidad = new Lui.Forms.Button();
                        this.label19 = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaStockMinimo = new Lui.Forms.TextBox();
                        this.Label11 = new Lui.Forms.Label();
                        this.Label9 = new Lui.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.EtiquetaCodigo1 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaCodigo1 = new Lui.Forms.TextBox();
                        this.EntradaCodigo4 = new Lui.Forms.TextBox();
                        this.EntradaCodigo3 = new Lui.Forms.TextBox();
                        this.EntradaCodigo2 = new Lui.Forms.TextBox();
                        this.EtiquetaCodigo4 = new Lui.Forms.Label();
                        this.EtiquetaCodigo3 = new Lui.Forms.Label();
                        this.EtiquetaCodigo2 = new Lui.Forms.Label();
                        this.EntradaDestacado = new Lui.Forms.ComboBox();
                        this.EntradaWeb = new Lui.Forms.ComboBox();
                        this.EntradaModelo = new Lui.Forms.TextBox();
                        this.EntradaGarantia = new Lui.Forms.TextBox();
                        this.EntradaCategoria = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaMarca = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaDescripcion2 = new Lui.Forms.TextBox();
                        this.EntradaUrl = new Lui.Forms.TextBox();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaSerie = new Lui.Forms.TextBox();
                        this.label20 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label13 = new Lui.Forms.Label();
                        this.Label15 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.Label18 = new Lui.Forms.Label();
                        this.Label16 = new Lui.Forms.Label();
                        this.Label12 = new Lui.Forms.Label();
                        this.Frame3 = new Lui.Forms.Frame();
                        this.label21 = new Lui.Forms.Label();
                        this.EntradaSeguimiento = new Lui.Forms.ComboBox();
                        this.label14 = new Lui.Forms.Label();
                        this.EntradaProveedor = new Lcc.Entrada.CodigoDetalle();
                        this.Frame2.SuspendLayout();
                        this.Frame3.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Frame2
                        // 
                        this.Frame2.Controls.Add(this.EntradaCosto);
                        this.Frame2.Controls.Add(this.EntradaMargen);
                        this.Frame2.Controls.Add(this.BotonInfoCosto);
                        this.Frame2.Controls.Add(this.EntradaPvp);
                        this.Frame2.Controls.Add(this.Label6);
                        this.Frame2.Controls.Add(this.EntradaCaja);
                        this.Frame2.Controls.Add(this.Label8);
                        this.Frame2.Controls.Add(this.EtiquetaAlicuota);
                        this.Frame2.Controls.Add(this.Label10);
                        this.Frame2.Controls.Add(this.label17);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame2.Location = new System.Drawing.Point(0, 352);
                        this.Frame2.Margin = new System.Windows.Forms.Padding(0);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.Size = new System.Drawing.Size(360, 280);
                        this.Frame2.TabIndex = 32;
                        this.Frame2.Text = "Precio y Costo";
                        // 
                        // EntradaCosto
                        // 
                        this.EntradaCosto.AutoNav = true;
                        this.EntradaCosto.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCosto.DecimalPlaces = -1;
                        this.EntradaCosto.FieldName = null;
                        this.EntradaCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCosto.Location = new System.Drawing.Point(136, 40);
                        this.EntradaCosto.MaxLength = 32767;
                        this.EntradaCosto.MultiLine = false;
                        this.EntradaCosto.Name = "EntradaCosto";
                        this.EntradaCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCosto.PasswordChar = '\0';
                        this.EntradaCosto.PlaceholderText = "Precio de costo o de compra.";
                        this.EntradaCosto.Prefijo = "$";
                        this.EntradaCosto.ReadOnly = false;
                        this.EntradaCosto.SelectOnFocus = true;
                        this.EntradaCosto.Size = new System.Drawing.Size(108, 24);
                        this.EntradaCosto.Sufijo = "";
                        this.EntradaCosto.TabIndex = 1;
                        this.EntradaCosto.Text = "0.00";
                        this.EntradaCosto.GotFocus += new System.EventHandler(this.EntradaCosto_GotFocus);
                        this.EntradaCosto.TextChanged += new System.EventHandler(this.EntradaCostoMargen_TextChanged);
                        // 
                        // EntradaMargen
                        // 
                        this.EntradaMargen.AlwaysExpanded = true;
                        this.EntradaMargen.AutoNav = true;
                        this.EntradaMargen.FieldName = null;
                        this.EntradaMargen.Location = new System.Drawing.Point(136, 72);
                        this.EntradaMargen.MaxLength = 32767;
                        this.EntradaMargen.Name = "EntradaMargen";
                        this.EntradaMargen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargen.PlaceholderText = "Márgenes predefinidos";
                        this.EntradaMargen.ReadOnly = false;
                        this.EntradaMargen.SetData = new string[] {
        "Otro|-1"};
                        this.EntradaMargen.Size = new System.Drawing.Size(224, 96);
                        this.EntradaMargen.TabIndex = 4;
                        this.EntradaMargen.TextKey = "-1";
                        this.EntradaMargen.TextChanged += new System.EventHandler(this.EntradaCostoMargen_TextChanged);
                        // 
                        // BotonInfoCosto
                        // 
                        this.BotonInfoCosto.AutoNav = true;
                        this.BotonInfoCosto.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonInfoCosto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonInfoCosto.Image = null;
                        this.BotonInfoCosto.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonInfoCosto.Location = new System.Drawing.Point(244, 40);
                        this.BotonInfoCosto.Name = "BotonInfoCosto";
                        this.BotonInfoCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonInfoCosto.ReadOnly = false;
                        this.BotonInfoCosto.Size = new System.Drawing.Size(28, 24);
                        this.BotonInfoCosto.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonInfoCosto.Subtext = "";
                        this.BotonInfoCosto.TabIndex = 2;
                        this.BotonInfoCosto.Text = "...";
                        this.BotonInfoCosto.Click += new System.EventHandler(this.BotonMasInfo_Click);
                        // 
                        // EntradaPvp
                        // 
                        this.EntradaPvp.AutoNav = true;
                        this.EntradaPvp.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaPvp.DecimalPlaces = -1;
                        this.EntradaPvp.FieldName = null;
                        this.EntradaPvp.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPvp.Location = new System.Drawing.Point(136, 184);
                        this.EntradaPvp.MaxLength = 32767;
                        this.EntradaPvp.MultiLine = false;
                        this.EntradaPvp.Name = "EntradaPvp";
                        this.EntradaPvp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPvp.PasswordChar = '\0';
                        this.EntradaPvp.PlaceholderText = "Precio de venta al público. Puede dejar el PVP en blanco y utilizar un márgen pre" +
    "definido a continuación";
                        this.EntradaPvp.Prefijo = "$";
                        this.EntradaPvp.ReadOnly = false;
                        this.EntradaPvp.SelectOnFocus = true;
                        this.EntradaPvp.Size = new System.Drawing.Size(96, 24);
                        this.EntradaPvp.Sufijo = "";
                        this.EntradaPvp.TabIndex = 6;
                        this.EntradaPvp.Text = "0.00";
                        this.EntradaPvp.TextChanged += new System.EventHandler(this.EntradaPvp_TextChanged);
                        // 
                        // Label6
                        // 
                        this.Label6.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(8, 40);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(120, 24);
                        this.Label6.TabIndex = 0;
                        this.Label6.Text = "Precio de costo";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaCaja
                        // 
                        this.EntradaCaja.AutoNav = true;
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DataTextField = "nombre";
                        this.EntradaCaja.DataValueField = "id_caja";
                        this.EntradaCaja.ExtraDetailFields = "";
                        this.EntradaCaja.FieldName = null;
                        this.EntradaCaja.Filter = "id_caja>999";
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.Location = new System.Drawing.Point(136, 248);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.PlaceholderText = "Sin especificar";
                        this.EntradaCaja.ReadOnly = false;
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(224, 24);
                        this.EntradaCaja.TabIndex = 13;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        // 
                        // Label8
                        // 
                        this.Label8.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(8, 72);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(120, 24);
                        this.Label8.TabIndex = 3;
                        this.Label8.Text = "Margen";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaAlicuota
                        // 
                        this.EtiquetaAlicuota.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.EtiquetaAlicuota.Location = new System.Drawing.Point(136, 216);
                        this.EtiquetaAlicuota.Name = "EtiquetaAlicuota";
                        this.EtiquetaAlicuota.Size = new System.Drawing.Size(224, 24);
                        this.EtiquetaAlicuota.TabIndex = 7;
                        this.EtiquetaAlicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label10
                        // 
                        this.Label10.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label10.Location = new System.Drawing.Point(8, 184);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(120, 24);
                        this.Label10.TabIndex = 5;
                        this.Label10.Text = "Precio de venta";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // label17
                        // 
                        this.label17.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label17.Location = new System.Drawing.Point(8, 248);
                        this.label17.Name = "label17";
                        this.label17.Size = new System.Drawing.Size(120, 24);
                        this.label17.TabIndex = 12;
                        this.label17.Text = "Caja asociada";
                        this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaUnidad
                        // 
                        this.EntradaUnidad.AlwaysExpanded = true;
                        this.EntradaUnidad.AutoNav = true;
                        this.EntradaUnidad.AutoSize = true;
                        this.EntradaUnidad.FieldName = null;
                        this.EntradaUnidad.Location = new System.Drawing.Point(176, 104);
                        this.EntradaUnidad.MaxLength = 32767;
                        this.EntradaUnidad.Name = "EntradaUnidad";
                        this.EntradaUnidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUnidad.PlaceholderText = "¿El artículo usa control de stock?";
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
                        this.EntradaUnidad.TabIndex = 4;
                        this.EntradaUnidad.TextKey = "u";
                        this.EntradaUnidad.Enter += new System.EventHandler(this.EntradaPvp_Enter);
                        // 
                        // EntradaUsaStock
                        // 
                        this.EntradaUsaStock.AlwaysExpanded = true;
                        this.EntradaUsaStock.AutoNav = true;
                        this.EntradaUsaStock.AutoSize = true;
                        this.EntradaUsaStock.FieldName = null;
                        this.EntradaUsaStock.Location = new System.Drawing.Point(176, 40);
                        this.EntradaUsaStock.MaxLength = 32767;
                        this.EntradaUsaStock.Name = "EntradaUsaStock";
                        this.EntradaUsaStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsaStock.PlaceholderText = "¿El artículo usa control de stock?";
                        this.EntradaUsaStock.ReadOnly = false;
                        this.EntradaUsaStock.SetData = new string[] {
        "No|0",
        "Normal|1",
        "Compuesto|2"};
                        this.EntradaUsaStock.Size = new System.Drawing.Size(120, 51);
                        this.EntradaUsaStock.TabIndex = 1;
                        this.EntradaUsaStock.TextKey = "1";
                        this.EntradaUsaStock.TextChanged += new System.EventHandler(this.EntradaUsaStock_TextChanged);
                        // 
                        // BotonReceta
                        // 
                        this.BotonReceta.AutoNav = true;
                        this.BotonReceta.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonReceta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonReceta.Image = null;
                        this.BotonReceta.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonReceta.Location = new System.Drawing.Point(298, 42);
                        this.BotonReceta.Name = "BotonReceta";
                        this.BotonReceta.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonReceta.ReadOnly = false;
                        this.BotonReceta.Size = new System.Drawing.Size(28, 24);
                        this.BotonReceta.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonReceta.Subtext = "";
                        this.BotonReceta.TabIndex = 2;
                        this.BotonReceta.Text = "...";
                        this.BotonReceta.Visible = false;
                        this.BotonReceta.Click += new System.EventHandler(this.BotonReceta_Click);
                        // 
                        // BotonUnidad
                        // 
                        this.BotonUnidad.AutoNav = true;
                        this.BotonUnidad.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonUnidad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonUnidad.Image = null;
                        this.BotonUnidad.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonUnidad.Location = new System.Drawing.Point(298, 106);
                        this.BotonUnidad.Name = "BotonUnidad";
                        this.BotonUnidad.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonUnidad.ReadOnly = false;
                        this.BotonUnidad.Size = new System.Drawing.Size(28, 24);
                        this.BotonUnidad.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonUnidad.Subtext = "";
                        this.BotonUnidad.TabIndex = 5;
                        this.BotonUnidad.Text = "...";
                        this.BotonUnidad.Click += new System.EventHandler(this.BotonUnidad_Click);
                        // 
                        // label19
                        // 
                        this.label19.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label19.Location = new System.Drawing.Point(8, 104);
                        this.label19.Name = "label19";
                        this.label19.Size = new System.Drawing.Size(160, 24);
                        this.label19.TabIndex = 3;
                        this.label19.Text = "Unidad";
                        this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label7.Location = new System.Drawing.Point(8, 40);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(160, 24);
                        this.Label7.TabIndex = 0;
                        this.Label7.Text = "Control existencias";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaStockMinimo
                        // 
                        this.EntradaStockMinimo.AutoNav = true;
                        this.EntradaStockMinimo.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaStockMinimo.DecimalPlaces = -1;
                        this.EntradaStockMinimo.FieldName = null;
                        this.EntradaStockMinimo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockMinimo.Location = new System.Drawing.Point(176, 280);
                        this.EntradaStockMinimo.MaxLength = 32767;
                        this.EntradaStockMinimo.MultiLine = false;
                        this.EntradaStockMinimo.Name = "EntradaStockMinimo";
                        this.EntradaStockMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMinimo.PasswordChar = '\0';
                        this.EntradaStockMinimo.PlaceholderText = "Stock mínimo o crítico";
                        this.EntradaStockMinimo.Prefijo = "";
                        this.EntradaStockMinimo.ReadOnly = false;
                        this.EntradaStockMinimo.SelectOnFocus = true;
                        this.EntradaStockMinimo.Size = new System.Drawing.Size(96, 24);
                        this.EntradaStockMinimo.Sufijo = "";
                        this.EntradaStockMinimo.TabIndex = 9;
                        this.EntradaStockMinimo.Text = "0.00";
                        // 
                        // Label11
                        // 
                        this.Label11.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label11.Location = new System.Drawing.Point(8, 280);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(160, 24);
                        this.Label11.TabIndex = 8;
                        this.Label11.Text = "Punto de reposición";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label9
                        // 
                        this.Label9.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label9.Location = new System.Drawing.Point(8, 312);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(160, 24);
                        this.Label9.TabIndex = 10;
                        this.Label9.Text = "Existencias";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.FieldName = null;
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.Location = new System.Drawing.Point(176, 312);
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
                        this.EntradaStockActual.TabIndex = 11;
                        this.EntradaStockActual.TabStop = false;
                        this.EntradaStockActual.Text = "0.00";
                        this.EntradaStockActual.TextChanged += new System.EventHandler(this.EntradaStockActual_TextChanged);
                        // 
                        // EtiquetaCodigo1
                        // 
                        this.EtiquetaCodigo1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.EtiquetaCodigo1.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaCodigo1.Name = "EtiquetaCodigo1";
                        this.EtiquetaCodigo1.Size = new System.Drawing.Size(104, 24);
                        this.EtiquetaCodigo1.TabIndex = 0;
                        this.EtiquetaCodigo1.Text = "Código 1";
                        this.EtiquetaCodigo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(0, 96);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(104, 24);
                        this.Label5.TabIndex = 16;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo1
                        // 
                        this.EntradaCodigo1.AutoNav = true;
                        this.EntradaCodigo1.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo1.DecimalPlaces = -1;
                        this.EntradaCodigo1.FieldName = null;
                        this.EntradaCodigo1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo1.Location = new System.Drawing.Point(104, 0);
                        this.EntradaCodigo1.MaxLength = 50;
                        this.EntradaCodigo1.MultiLine = false;
                        this.EntradaCodigo1.Name = "EntradaCodigo1";
                        this.EntradaCodigo1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo1.PasswordChar = '\0';
                        this.EntradaCodigo1.PlaceholderText = null;
                        this.EntradaCodigo1.Prefijo = "";
                        this.EntradaCodigo1.ReadOnly = false;
                        this.EntradaCodigo1.SelectOnFocus = true;
                        this.EntradaCodigo1.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo1.Sufijo = "";
                        this.EntradaCodigo1.TabIndex = 1;
                        // 
                        // EntradaCodigo4
                        // 
                        this.EntradaCodigo4.AutoNav = true;
                        this.EntradaCodigo4.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo4.DecimalPlaces = -1;
                        this.EntradaCodigo4.FieldName = null;
                        this.EntradaCodigo4.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo4.Location = new System.Drawing.Point(796, 0);
                        this.EntradaCodigo4.MaxLength = 50;
                        this.EntradaCodigo4.MultiLine = false;
                        this.EntradaCodigo4.Name = "EntradaCodigo4";
                        this.EntradaCodigo4.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo4.PasswordChar = '\0';
                        this.EntradaCodigo4.PlaceholderText = null;
                        this.EntradaCodigo4.Prefijo = "";
                        this.EntradaCodigo4.ReadOnly = false;
                        this.EntradaCodigo4.SelectOnFocus = true;
                        this.EntradaCodigo4.Size = new System.Drawing.Size(140, 24);
                        this.EntradaCodigo4.Sufijo = "";
                        this.EntradaCodigo4.TabIndex = 7;
                        // 
                        // EntradaCodigo3
                        // 
                        this.EntradaCodigo3.AutoNav = true;
                        this.EntradaCodigo3.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo3.DecimalPlaces = -1;
                        this.EntradaCodigo3.FieldName = null;
                        this.EntradaCodigo3.ForceCase = Lui.Forms.TextCasing.UpperCase;
                        this.EntradaCodigo3.Location = new System.Drawing.Point(564, 0);
                        this.EntradaCodigo3.MaxLength = 50;
                        this.EntradaCodigo3.MultiLine = false;
                        this.EntradaCodigo3.Name = "EntradaCodigo3";
                        this.EntradaCodigo3.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo3.PasswordChar = '\0';
                        this.EntradaCodigo3.PlaceholderText = null;
                        this.EntradaCodigo3.Prefijo = "";
                        this.EntradaCodigo3.ReadOnly = false;
                        this.EntradaCodigo3.SelectOnFocus = true;
                        this.EntradaCodigo3.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo3.Sufijo = "";
                        this.EntradaCodigo3.TabIndex = 5;
                        // 
                        // EntradaCodigo2
                        // 
                        this.EntradaCodigo2.AutoNav = true;
                        this.EntradaCodigo2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo2.DecimalPlaces = -1;
                        this.EntradaCodigo2.FieldName = null;
                        this.EntradaCodigo2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo2.Location = new System.Drawing.Point(336, 0);
                        this.EntradaCodigo2.MaxLength = 50;
                        this.EntradaCodigo2.MultiLine = false;
                        this.EntradaCodigo2.Name = "EntradaCodigo2";
                        this.EntradaCodigo2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo2.PasswordChar = '\0';
                        this.EntradaCodigo2.PlaceholderText = null;
                        this.EntradaCodigo2.Prefijo = "";
                        this.EntradaCodigo2.ReadOnly = false;
                        this.EntradaCodigo2.SelectOnFocus = true;
                        this.EntradaCodigo2.Size = new System.Drawing.Size(132, 24);
                        this.EntradaCodigo2.Sufijo = "";
                        this.EntradaCodigo2.TabIndex = 3;
                        // 
                        // EtiquetaCodigo4
                        // 
                        this.EtiquetaCodigo4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.EtiquetaCodigo4.Location = new System.Drawing.Point(712, 0);
                        this.EtiquetaCodigo4.Name = "EtiquetaCodigo4";
                        this.EtiquetaCodigo4.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo4.TabIndex = 6;
                        this.EtiquetaCodigo4.Text = "Código 4";
                        this.EtiquetaCodigo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaCodigo3
                        // 
                        this.EtiquetaCodigo3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.EtiquetaCodigo3.Location = new System.Drawing.Point(480, 0);
                        this.EtiquetaCodigo3.Name = "EtiquetaCodigo3";
                        this.EtiquetaCodigo3.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo3.TabIndex = 4;
                        this.EtiquetaCodigo3.Text = "Código 3";
                        this.EtiquetaCodigo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaCodigo2
                        // 
                        this.EtiquetaCodigo2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.EtiquetaCodigo2.Location = new System.Drawing.Point(252, 0);
                        this.EtiquetaCodigo2.Name = "EtiquetaCodigo2";
                        this.EtiquetaCodigo2.Size = new System.Drawing.Size(84, 24);
                        this.EtiquetaCodigo2.TabIndex = 2;
                        this.EtiquetaCodigo2.Text = "Código 2";
                        this.EtiquetaCodigo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDestacado
                        // 
                        this.EntradaDestacado.AlwaysExpanded = true;
                        this.EntradaDestacado.AutoNav = true;
                        this.EntradaDestacado.AutoSize = true;
                        this.EntradaDestacado.FieldName = null;
                        this.EntradaDestacado.Location = new System.Drawing.Point(104, 272);
                        this.EntradaDestacado.MaxLength = 32767;
                        this.EntradaDestacado.Name = "EntradaDestacado";
                        this.EntradaDestacado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDestacado.PlaceholderText = null;
                        this.EntradaDestacado.ReadOnly = false;
                        this.EntradaDestacado.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaDestacado.Size = new System.Drawing.Size(64, 36);
                        this.EntradaDestacado.TabIndex = 25;
                        this.EntradaDestacado.TextKey = "0";
                        // 
                        // EntradaWeb
                        // 
                        this.EntradaWeb.AlwaysExpanded = true;
                        this.EntradaWeb.AutoNav = true;
                        this.EntradaWeb.AutoSize = true;
                        this.EntradaWeb.FieldName = null;
                        this.EntradaWeb.Location = new System.Drawing.Point(280, 272);
                        this.EntradaWeb.MaxLength = 32767;
                        this.EntradaWeb.Name = "EntradaWeb";
                        this.EntradaWeb.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaWeb.PlaceholderText = null;
                        this.EntradaWeb.ReadOnly = false;
                        this.EntradaWeb.SetData = new string[] {
        "Siempre|1",
        "Sólo si hay Stock o Pedidos|2",
        "Nunca|0"};
                        this.EntradaWeb.Size = new System.Drawing.Size(212, 51);
                        this.EntradaWeb.TabIndex = 27;
                        this.EntradaWeb.TextKey = "2";
                        // 
                        // EntradaModelo
                        // 
                        this.EntradaModelo.AutoNav = true;
                        this.EntradaModelo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaModelo.DecimalPlaces = -1;
                        this.EntradaModelo.FieldName = null;
                        this.EntradaModelo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaModelo.Location = new System.Drawing.Point(104, 64);
                        this.EntradaModelo.MaxLength = 32767;
                        this.EntradaModelo.MultiLine = false;
                        this.EntradaModelo.Name = "EntradaModelo";
                        this.EntradaModelo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModelo.PasswordChar = '\0';
                        this.EntradaModelo.PlaceholderText = null;
                        this.EntradaModelo.Prefijo = "";
                        this.EntradaModelo.ReadOnly = false;
                        this.EntradaModelo.SelectOnFocus = false;
                        this.EntradaModelo.Size = new System.Drawing.Size(352, 24);
                        this.EntradaModelo.Sufijo = "";
                        this.EntradaModelo.TabIndex = 13;
                        this.EntradaModelo.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EntradaGarantia
                        // 
                        this.EntradaGarantia.AutoNav = true;
                        this.EntradaGarantia.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaGarantia.DecimalPlaces = -1;
                        this.EntradaGarantia.FieldName = null;
                        this.EntradaGarantia.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGarantia.Location = new System.Drawing.Point(604, 272);
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
                        this.EntradaGarantia.TabIndex = 29;
                        this.EntradaGarantia.Text = "0";
                        // 
                        // EntradaCategoria
                        // 
                        this.EntradaCategoria.AutoNav = true;
                        this.EntradaCategoria.AutoTab = true;
                        this.EntradaCategoria.CanCreate = true;
                        this.EntradaCategoria.DataTextField = "nombre";
                        this.EntradaCategoria.DataValueField = "id_categoria";
                        this.EntradaCategoria.ExtraDetailFields = "";
                        this.EntradaCategoria.FieldName = null;
                        this.EntradaCategoria.Filter = "";
                        this.EntradaCategoria.FreeTextCode = "";
                        this.EntradaCategoria.Location = new System.Drawing.Point(104, 32);
                        this.EntradaCategoria.MaxLength = 200;
                        this.EntradaCategoria.Name = "EntradaCategoria";
                        this.EntradaCategoria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCategoria.PlaceholderText = "Rubro o categoría";
                        this.EntradaCategoria.ReadOnly = false;
                        this.EntradaCategoria.Required = true;
                        this.EntradaCategoria.Size = new System.Drawing.Size(352, 24);
                        this.EntradaCategoria.TabIndex = 9;
                        this.EntradaCategoria.Table = "articulos_categorias";
                        this.EntradaCategoria.Text = "0";
                        this.EntradaCategoria.TextDetail = "";
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
                        this.EntradaMarca.ExtraDetailFields = "";
                        this.EntradaMarca.FieldName = null;
                        this.EntradaMarca.Filter = "";
                        this.EntradaMarca.FreeTextCode = "";
                        this.EntradaMarca.Location = new System.Drawing.Point(552, 32);
                        this.EntradaMarca.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaMarca.MaxLength = 200;
                        this.EntradaMarca.Name = "EntradaMarca";
                        this.EntradaMarca.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMarca.PlaceholderText = "Sin especificar";
                        this.EntradaMarca.ReadOnly = false;
                        this.EntradaMarca.Required = false;
                        this.EntradaMarca.Size = new System.Drawing.Size(216, 24);
                        this.EntradaMarca.TabIndex = 11;
                        this.EntradaMarca.Table = "marcas";
                        this.EntradaMarca.Text = "0";
                        this.EntradaMarca.TextDetail = "";
                        this.EntradaMarca.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EntradaDescripcion2
                        // 
                        this.EntradaDescripcion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDescripcion2.AutoNav = true;
                        this.EntradaDescripcion2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion2.DecimalPlaces = -1;
                        this.EntradaDescripcion2.FieldName = null;
                        this.EntradaDescripcion2.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDescripcion2.Location = new System.Drawing.Point(512, 160);
                        this.EntradaDescripcion2.MaxLength = 32767;
                        this.EntradaDescripcion2.MultiLine = true;
                        this.EntradaDescripcion2.Name = "EntradaDescripcion2";
                        this.EntradaDescripcion2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion2.PasswordChar = '\0';
                        this.EntradaDescripcion2.PlaceholderText = "Descripción larga";
                        this.EntradaDescripcion2.Prefijo = "";
                        this.EntradaDescripcion2.ReadOnly = false;
                        this.EntradaDescripcion2.SelectOnFocus = false;
                        this.EntradaDescripcion2.Size = new System.Drawing.Size(256, 104);
                        this.EntradaDescripcion2.Sufijo = "";
                        this.EntradaDescripcion2.TabIndex = 23;
                        // 
                        // EntradaUrl
                        // 
                        this.EntradaUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUrl.AutoNav = true;
                        this.EntradaUrl.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaUrl.DecimalPlaces = -1;
                        this.EntradaUrl.FieldName = null;
                        this.EntradaUrl.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUrl.Location = new System.Drawing.Point(104, 128);
                        this.EntradaUrl.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaUrl.MaxLength = 32767;
                        this.EntradaUrl.MultiLine = false;
                        this.EntradaUrl.Name = "EntradaUrl";
                        this.EntradaUrl.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUrl.PasswordChar = '\0';
                        this.EntradaUrl.PlaceholderText = "Dirección de la página web del producto.";
                        this.EntradaUrl.Prefijo = "";
                        this.EntradaUrl.ReadOnly = false;
                        this.EntradaUrl.SelectOnFocus = false;
                        this.EntradaUrl.Size = new System.Drawing.Size(480, 24);
                        this.EntradaUrl.Sufijo = "";
                        this.EntradaUrl.TabIndex = 19;
                        // 
                        // EntradaDescripcion
                        // 
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.FieldName = null;
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.Caption;
                        this.EntradaDescripcion.Location = new System.Drawing.Point(104, 160);
                        this.EntradaDescripcion.MaxLength = 32767;
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "EntradaDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.PasswordChar = '\0';
                        this.EntradaDescripcion.PlaceholderText = "Descripción larga";
                        this.EntradaDescripcion.Prefijo = "";
                        this.EntradaDescripcion.ReadOnly = false;
                        this.EntradaDescripcion.SelectOnFocus = false;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(292, 104);
                        this.EntradaDescripcion.Sufijo = "";
                        this.EntradaDescripcion.TabIndex = 21;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.FieldName = null;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.Location = new System.Drawing.Point(104, 96);
                        this.EntradaNombre.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaNombre.MaxLength = 200;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.PlaceholderText = "Nombre completo del artículo";
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(480, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 17;
                        this.EntradaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaNombre_KeyPress);
                        // 
                        // EntradaSerie
                        // 
                        this.EntradaSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSerie.AutoNav = true;
                        this.EntradaSerie.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaSerie.DecimalPlaces = -1;
                        this.EntradaSerie.FieldName = null;
                        this.EntradaSerie.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSerie.Location = new System.Drawing.Point(552, 64);
                        this.EntradaSerie.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaSerie.MaxLength = 32767;
                        this.EntradaSerie.MultiLine = false;
                        this.EntradaSerie.Name = "EntradaSerie";
                        this.EntradaSerie.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSerie.PasswordChar = '\0';
                        this.EntradaSerie.PlaceholderText = null;
                        this.EntradaSerie.Prefijo = "";
                        this.EntradaSerie.ReadOnly = false;
                        this.EntradaSerie.SelectOnFocus = false;
                        this.EntradaSerie.Size = new System.Drawing.Size(216, 24);
                        this.EntradaSerie.Sufijo = "";
                        this.EntradaSerie.TabIndex = 15;
                        this.EntradaSerie.TextChanged += new System.EventHandler(this.EntradaCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // label20
                        // 
                        this.label20.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label20.Location = new System.Drawing.Point(512, 272);
                        this.label20.Name = "label20";
                        this.label20.Size = new System.Drawing.Size(92, 24);
                        this.label20.TabIndex = 28;
                        this.label20.Text = "Garantía";
                        this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(0, 32);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(104, 24);
                        this.Label2.TabIndex = 8;
                        this.Label2.Text = "Categoría";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label13
                        // 
                        this.Label13.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label13.Location = new System.Drawing.Point(0, 160);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(104, 24);
                        this.Label13.TabIndex = 20;
                        this.Label13.Text = "Descripción";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label15.Location = new System.Drawing.Point(0, 272);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(104, 24);
                        this.Label15.TabIndex = 24;
                        this.Label15.Text = "Destacado";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(0, 64);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(104, 24);
                        this.Label3.TabIndex = 12;
                        this.Label3.Text = "Modelo";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(472, 64);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(80, 24);
                        this.Label4.TabIndex = 14;
                        this.Label4.Text = "Serie";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(472, 32);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(80, 24);
                        this.Label1.TabIndex = 10;
                        this.Label1.Text = "Marca";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label18
                        // 
                        this.Label18.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label18.Location = new System.Drawing.Point(408, 160);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(100, 56);
                        this.Label18.TabIndex = 22;
                        this.Label18.Text = "Descrip. Extendida";
                        // 
                        // Label16
                        // 
                        this.Label16.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label16.Location = new System.Drawing.Point(184, 272);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(96, 24);
                        this.Label16.TabIndex = 26;
                        this.Label16.Text = "Publicar";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label12
                        // 
                        this.Label12.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label12.Location = new System.Drawing.Point(0, 128);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(104, 24);
                        this.Label12.TabIndex = 18;
                        this.Label12.Text = "URL";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame3
                        // 
                        this.Frame3.Controls.Add(this.BotonReceta);
                        this.Frame3.Controls.Add(this.Label7);
                        this.Frame3.Controls.Add(this.EntradaUnidad);
                        this.Frame3.Controls.Add(this.EntradaUsaStock);
                        this.Frame3.Controls.Add(this.BotonUnidad);
                        this.Frame3.Controls.Add(this.label19);
                        this.Frame3.Controls.Add(this.label21);
                        this.Frame3.Controls.Add(this.EntradaSeguimiento);
                        this.Frame3.Controls.Add(this.Label11);
                        this.Frame3.Controls.Add(this.Label9);
                        this.Frame3.Controls.Add(this.EntradaStockMinimo);
                        this.Frame3.Controls.Add(this.EntradaStockActual);
                        this.Frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame3.Location = new System.Drawing.Point(372, 352);
                        this.Frame3.Margin = new System.Windows.Forms.Padding(0);
                        this.Frame3.Name = "Frame3";
                        this.Frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame3.Size = new System.Drawing.Size(348, 336);
                        this.Frame3.TabIndex = 33;
                        this.Frame3.Text = "Existencias";
                        // 
                        // label21
                        // 
                        this.label21.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label21.Location = new System.Drawing.Point(8, 200);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(160, 24);
                        this.label21.TabIndex = 6;
                        this.label21.Text = "Seguimiento";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaSeguimiento
                        // 
                        this.EntradaSeguimiento.AlwaysExpanded = true;
                        this.EntradaSeguimiento.AutoNav = true;
                        this.EntradaSeguimiento.AutoSize = true;
                        this.EntradaSeguimiento.FieldName = null;
                        this.EntradaSeguimiento.Location = new System.Drawing.Point(176, 200);
                        this.EntradaSeguimiento.MaxLength = 32767;
                        this.EntradaSeguimiento.Name = "EntradaSeguimiento";
                        this.EntradaSeguimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSeguimiento.PlaceholderText = null;
                        this.EntradaSeguimiento.ReadOnly = false;
                        this.EntradaSeguimiento.SetData = new string[] {
        "Predeterminado|0",
        "Ninguno|1",
        "Por Números de Serie|3",
        "Por Variaciones|5"};
                        this.EntradaSeguimiento.Size = new System.Drawing.Size(164, 66);
                        this.EntradaSeguimiento.TabIndex = 7;
                        this.EntradaSeguimiento.TextKey = "0";
                        this.EntradaSeguimiento.TextChanged += new System.EventHandler(this.EntradaSeguimiento_TextChanged);
                        // 
                        // label14
                        // 
                        this.label14.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label14.Location = new System.Drawing.Point(512, 304);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(92, 24);
                        this.label14.TabIndex = 30;
                        this.label14.Text = "Proveedor";
                        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaProveedor
                        // 
                        this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProveedor.AutoNav = true;
                        this.EntradaProveedor.AutoTab = true;
                        this.EntradaProveedor.CanCreate = true;
                        this.EntradaProveedor.DataTextField = "nombre";
                        this.EntradaProveedor.DataValueField = "id_marca";
                        this.EntradaProveedor.ExtraDetailFields = "";
                        this.EntradaProveedor.FieldName = null;
                        this.EntradaProveedor.Filter = "";
                        this.EntradaProveedor.FreeTextCode = "";
                        this.EntradaProveedor.Location = new System.Drawing.Point(604, 304);
                        this.EntradaProveedor.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.PlaceholderText = "Sin especificar";
                        this.EntradaProveedor.ReadOnly = false;
                        this.EntradaProveedor.Required = false;
                        this.EntradaProveedor.Size = new System.Drawing.Size(164, 24);
                        this.EntradaProveedor.TabIndex = 31;
                        this.EntradaProveedor.Table = "marcas";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label14);
                        this.Controls.Add(this.EntradaProveedor);
                        this.Controls.Add(this.Frame2);
                        this.Controls.Add(this.EntradaCodigo1);
                        this.Controls.Add(this.Frame3);
                        this.Controls.Add(this.EntradaCodigo4);
                        this.Controls.Add(this.EntradaCodigo3);
                        this.Controls.Add(this.EntradaCodigo2);
                        this.Controls.Add(this.Label18);
                        this.Controls.Add(this.EtiquetaCodigo4);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EtiquetaCodigo3);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EtiquetaCodigo2);
                        this.Controls.Add(this.EntradaDestacado);
                        this.Controls.Add(this.EntradaWeb);
                        this.Controls.Add(this.EntradaModelo);
                        this.Controls.Add(this.EntradaGarantia);
                        this.Controls.Add(this.label20);
                        this.Controls.Add(this.EntradaSerie);
                        this.Controls.Add(this.EntradaCategoria);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.EntradaMarca);
                        this.Controls.Add(this.EntradaDescripcion);
                        this.Controls.Add(this.EntradaDescripcion2);
                        this.Controls.Add(this.EntradaUrl);
                        this.Controls.Add(this.EtiquetaCodigo1);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label12);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label13);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label15);
                        this.Controls.Add(this.Label16);
                        this.MinimumSize = new System.Drawing.Size(768, 688);
                        this.Name = "Editar";
                        this.Padding = new System.Windows.Forms.Padding(0);
                        this.Size = new System.Drawing.Size(768, 688);
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.Frame3.ResumeLayout(false);
                        this.Frame3.PerformLayout();
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
                internal Lui.Forms.Frame Frame3;
                internal Lui.Forms.ComboBox EntradaSeguimiento;
                internal Lui.Forms.Label label21;
                internal Lui.Forms.Label label14;
                internal Lcc.Entrada.CodigoDetalle EntradaProveedor;
        }
}
