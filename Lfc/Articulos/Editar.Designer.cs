// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Articulos
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Frame3 = new Lui.Forms.Frame();
                        this.EntradaImagen = new System.Windows.Forms.PictureBox();
                        this.BotonQuitarImagen = new Lui.Forms.Button();
                        this.BotonSeleccionarImagen = new Lui.Forms.Button();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.BotonUnidad = new Lui.Forms.Button();
                        this.EntradaUnidad = new Lui.Forms.ComboBox();
                        this.label19 = new System.Windows.Forms.Label();
                        this.EntradaMargen = new Lui.Forms.ComboBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.EntradaCosto = new Lui.Forms.TextBox();
                        this.EntradaUsaStock = new Lui.Forms.ComboBox();
                        this.EntradaStockMinimo = new Lui.Forms.TextBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.BotonInfoCosto = new Lui.Forms.Button();
                        this.EntradaPvp = new Lui.Forms.TextBox();
                        this.BotonArticuloVerMovimientos = new Lui.Forms.Button();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.EntradaStockActual = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.EntradaCuenta = new Lui.Forms.DetailBox();
                        this.label17 = new System.Windows.Forms.Label();
                        this.EntradaProveedor = new Lui.Forms.DetailBox();
                        this.EntradaCategoria = new Lui.Forms.DetailBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.EntradaMarca = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaDestacado = new Lui.Forms.ComboBox();
                        this.Label13 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaCodigo4 = new Lui.Forms.TextBox();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.EtiquetaCodigo4 = new System.Windows.Forms.Label();
                        this.EntradaCodigo3 = new Lui.Forms.TextBox();
                        this.EtiquetaCodigo3 = new System.Windows.Forms.Label();
                        this.EntradaDescripcion2 = new Lui.Forms.TextBox();
                        this.EntradaCodigo2 = new Lui.Forms.TextBox();
                        this.EtiquetaCodigo2 = new System.Windows.Forms.Label();
                        this.EntradaCodigo1 = new Lui.Forms.TextBox();
                        this.EtiquetaCodigo1 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaWeb = new Lui.Forms.ComboBox();
                        this.Label18 = new System.Windows.Forms.Label();
                        this.EntradaUrl = new Lui.Forms.TextBox();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.Label12 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaSerie = new Lui.Forms.TextBox();
                        this.EntradaModelo = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.cmdDescripcion = new Lui.Forms.Button();
                        this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
                        this.Frame4 = new Lui.Forms.Frame();
                        this.EntradaTags = new Lui.Forms.FieldTags();
                        this.frame5 = new Lui.Forms.Frame();
                        this.etiquetas1 = new Lcc.Controles.Datos.Etiquetas();
                        this.Frame3.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).BeginInit();
                        this.Frame2.SuspendLayout();
                        this.Frame1.SuspendLayout();
                        this.flowLayoutPanel1.SuspendLayout();
                        this.Frame4.SuspendLayout();
                        this.frame5.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(697, 7);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(805, 7);
                        // 
                        // Frame3
                        // 
                        this.Frame3.AutoHeight = false;
                        this.Frame3.Controls.Add(this.EntradaImagen);
                        this.Frame3.Controls.Add(this.BotonQuitarImagen);
                        this.Frame3.Controls.Add(this.BotonSeleccionarImagen);
                        this.Frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame3.Location = new System.Drawing.Point(467, 340);
                        this.Frame3.Name = "Frame3";
                        this.Frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame3.ReadOnly = false;
                        this.Frame3.Size = new System.Drawing.Size(292, 168);
                        this.Frame3.TabIndex = 2;
                        this.Frame3.Text = "Imagen";
                        this.Frame3.ToolTipText = "";
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.BackColor = System.Drawing.Color.White;
                        this.EntradaImagen.Location = new System.Drawing.Point(10, 30);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.Size = new System.Drawing.Size(160, 120);
                        this.EntradaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.EntradaImagen.TabIndex = 100;
                        this.EntradaImagen.TabStop = false;
                        // 
                        // BotonQuitarImagen
                        // 
                        this.BotonQuitarImagen.AutoHeight = false;
                        this.BotonQuitarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitarImagen.Image = null;
                        this.BotonQuitarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarImagen.Location = new System.Drawing.Point(178, 118);
                        this.BotonQuitarImagen.Name = "BotonQuitarImagen";
                        this.BotonQuitarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarImagen.ReadOnly = false;
                        this.BotonQuitarImagen.Size = new System.Drawing.Size(108, 32);
                        this.BotonQuitarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonQuitarImagen.Subtext = "F5";
                        this.BotonQuitarImagen.TabIndex = 99;
                        this.BotonQuitarImagen.Text = "Quitar";
                        this.BotonQuitarImagen.ToolTipText = "";
                        this.BotonQuitarImagen.Click += new System.EventHandler(this.cmdImagenQuitar_Click);
                        // 
                        // BotonSeleccionarImagen
                        // 
                        this.BotonSeleccionarImagen.AutoHeight = false;
                        this.BotonSeleccionarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSeleccionarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonSeleccionarImagen.Image = null;
                        this.BotonSeleccionarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSeleccionarImagen.Location = new System.Drawing.Point(178, 82);
                        this.BotonSeleccionarImagen.Name = "BotonSeleccionarImagen";
                        this.BotonSeleccionarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSeleccionarImagen.ReadOnly = false;
                        this.BotonSeleccionarImagen.Size = new System.Drawing.Size(108, 32);
                        this.BotonSeleccionarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonSeleccionarImagen.Subtext = "F4";
                        this.BotonSeleccionarImagen.TabIndex = 98;
                        this.BotonSeleccionarImagen.Text = "Seleccionar";
                        this.BotonSeleccionarImagen.ToolTipText = "";
                        this.BotonSeleccionarImagen.Click += new System.EventHandler(this.cmdImagen_Click);
                        // 
                        // Frame2
                        // 
                        this.Frame2.AutoHeight = false;
                        this.Frame2.Controls.Add(this.BotonUnidad);
                        this.Frame2.Controls.Add(this.EntradaUnidad);
                        this.Frame2.Controls.Add(this.label19);
                        this.Frame2.Controls.Add(this.EntradaMargen);
                        this.Frame2.Controls.Add(this.Label8);
                        this.Frame2.Controls.Add(this.EntradaCosto);
                        this.Frame2.Controls.Add(this.EntradaUsaStock);
                        this.Frame2.Controls.Add(this.EntradaStockMinimo);
                        this.Frame2.Controls.Add(this.Label11);
                        this.Frame2.Controls.Add(this.Label7);
                        this.Frame2.Controls.Add(this.Label6);
                        this.Frame2.Controls.Add(this.BotonInfoCosto);
                        this.Frame2.Controls.Add(this.EntradaPvp);
                        this.Frame2.Controls.Add(this.BotonArticuloVerMovimientos);
                        this.Frame2.Controls.Add(this.Label10);
                        this.Frame2.Controls.Add(this.EntradaStockActual);
                        this.Frame2.Controls.Add(this.Label9);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame2.Location = new System.Drawing.Point(7, 340);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(454, 168);
                        this.Frame2.TabIndex = 1;
                        this.Frame2.Text = "Precio y Stock";
                        this.Frame2.ToolTipText = "";
                        // 
                        // BotonUnidad
                        // 
                        this.BotonUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonUnidad.AutoHeight = false;
                        this.BotonUnidad.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonUnidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonUnidad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonUnidad.Image = null;
                        this.BotonUnidad.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonUnidad.Location = new System.Drawing.Point(197, 132);
                        this.BotonUnidad.Name = "BotonUnidad";
                        this.BotonUnidad.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonUnidad.ReadOnly = false;
                        this.BotonUnidad.Size = new System.Drawing.Size(28, 24);
                        this.BotonUnidad.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonUnidad.Subtext = "";
                        this.BotonUnidad.TabIndex = 14;
                        this.BotonUnidad.Text = "...";
                        this.BotonUnidad.ToolTipText = "Ver historial de movimientos de stock";
                        this.BotonUnidad.Click += new System.EventHandler(this.cmdUnidad_Click);
                        // 
                        // EntradaUnidad
                        // 
                        this.EntradaUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUnidad.AutoHeight = false;
                        this.EntradaUnidad.AutoNav = true;
                        this.EntradaUnidad.AutoTab = true;
                        this.EntradaUnidad.DetailField = null;
                        this.EntradaUnidad.Filter = null;
                        this.EntradaUnidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaUnidad.KeyField = null;
                        this.EntradaUnidad.Location = new System.Drawing.Point(84, 132);
                        this.EntradaUnidad.MaxLenght = 32767;
                        this.EntradaUnidad.Name = "EntradaUnidad";
                        this.EntradaUnidad.Padding = new System.Windows.Forms.Padding(2);
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
                        this.EntradaUnidad.Size = new System.Drawing.Size(113, 24);
                        this.EntradaUnidad.TabIndex = 13;
                        this.EntradaUnidad.Table = null;
                        this.EntradaUnidad.Text = "Unidades";
                        this.EntradaUnidad.TextKey = "u";
                        this.EntradaUnidad.TextRaw = "Unidades";
                        this.EntradaUnidad.TipWhenBlank = "";
                        this.EntradaUnidad.ToolTipText = "¿El artículo usa control de stock?";
                        this.EntradaUnidad.Enter += new System.EventHandler(this.txtPVP_Enter);
                        // 
                        // label19
                        // 
                        this.label19.Location = new System.Drawing.Point(8, 132);
                        this.label19.Name = "label19";
                        this.label19.Size = new System.Drawing.Size(76, 24);
                        this.label19.TabIndex = 12;
                        this.label19.Text = "Unidad";
                        this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMargen
                        // 
                        this.EntradaMargen.AutoHeight = false;
                        this.EntradaMargen.AutoNav = true;
                        this.EntradaMargen.AutoTab = true;
                        this.EntradaMargen.DetailField = null;
                        this.EntradaMargen.Filter = null;
                        this.EntradaMargen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMargen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaMargen.KeyField = null;
                        this.EntradaMargen.Location = new System.Drawing.Point(84, 68);
                        this.EntradaMargen.MaxLenght = 32767;
                        this.EntradaMargen.Name = "EntradaMargen";
                        this.EntradaMargen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargen.ReadOnly = false;
                        this.EntradaMargen.SetData = new string[] {
        "Otro|-1"};
                        this.EntradaMargen.Size = new System.Drawing.Size(276, 24);
                        this.EntradaMargen.TabIndex = 6;
                        this.EntradaMargen.Table = null;
                        this.EntradaMargen.Text = "Otro";
                        this.EntradaMargen.TextKey = "-1";
                        this.EntradaMargen.TextRaw = "Otro";
                        this.EntradaMargen.TipWhenBlank = "";
                        this.EntradaMargen.ToolTipText = "Márgenes predefinidos";
                        this.EntradaMargen.TextChanged += new System.EventHandler(this.txtCostoMargen_TextChanged);
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(8, 68);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(76, 24);
                        this.Label8.TabIndex = 5;
                        this.Label8.Text = "Margen";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCosto
                        // 
                        this.EntradaCosto.AutoHeight = false;
                        this.EntradaCosto.AutoNav = true;
                        this.EntradaCosto.AutoTab = true;
                        this.EntradaCosto.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCosto.DecimalPlaces = -1;
                        this.EntradaCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCosto.Location = new System.Drawing.Point(84, 36);
                        this.EntradaCosto.MaxLenght = 32767;
                        this.EntradaCosto.MultiLine = false;
                        this.EntradaCosto.Name = "EntradaCosto";
                        this.EntradaCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCosto.PasswordChar = '\0';
                        this.EntradaCosto.Prefijo = "";
                        this.EntradaCosto.ReadOnly = false;
                        this.EntradaCosto.SelectOnFocus = true;
                        this.EntradaCosto.Size = new System.Drawing.Size(96, 24);
                        this.EntradaCosto.Sufijo = "";
                        this.EntradaCosto.TabIndex = 1;
                        this.EntradaCosto.Text = "0.00";
                        this.EntradaCosto.TextRaw = "0.00";
                        this.EntradaCosto.TipWhenBlank = "";
                        this.EntradaCosto.ToolTipText = "Precio de costo o de compra.";
                        this.EntradaCosto.TextChanged += new System.EventHandler(this.txtCostoMargen_TextChanged);
                        this.EntradaCosto.GotFocus += new System.EventHandler(this.txtCosto_GotFocus);
                        // 
                        // EntradaUsaStock
                        // 
                        this.EntradaUsaStock.AutoHeight = false;
                        this.EntradaUsaStock.AutoNav = true;
                        this.EntradaUsaStock.AutoTab = true;
                        this.EntradaUsaStock.DetailField = null;
                        this.EntradaUsaStock.Filter = null;
                        this.EntradaUsaStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaUsaStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaUsaStock.KeyField = null;
                        this.EntradaUsaStock.Location = new System.Drawing.Point(84, 100);
                        this.EntradaUsaStock.MaxLenght = 32767;
                        this.EntradaUsaStock.Name = "EntradaUsaStock";
                        this.EntradaUsaStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsaStock.ReadOnly = false;
                        this.EntradaUsaStock.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaUsaStock.Size = new System.Drawing.Size(48, 24);
                        this.EntradaUsaStock.TabIndex = 8;
                        this.EntradaUsaStock.Table = null;
                        this.EntradaUsaStock.Text = "Si";
                        this.EntradaUsaStock.TextKey = "1";
                        this.EntradaUsaStock.TextRaw = "Si";
                        this.EntradaUsaStock.TipWhenBlank = "";
                        this.EntradaUsaStock.ToolTipText = "¿El artículo usa control de stock?";
                        // 
                        // EntradaStockMinimo
                        // 
                        this.EntradaStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaStockMinimo.AutoHeight = false;
                        this.EntradaStockMinimo.AutoNav = true;
                        this.EntradaStockMinimo.AutoTab = true;
                        this.EntradaStockMinimo.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaStockMinimo.DecimalPlaces = -1;
                        this.EntradaStockMinimo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockMinimo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockMinimo.Location = new System.Drawing.Point(330, 132);
                        this.EntradaStockMinimo.MaxLenght = 32767;
                        this.EntradaStockMinimo.MultiLine = false;
                        this.EntradaStockMinimo.Name = "EntradaStockMinimo";
                        this.EntradaStockMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMinimo.PasswordChar = '\0';
                        this.EntradaStockMinimo.Prefijo = "";
                        this.EntradaStockMinimo.ReadOnly = false;
                        this.EntradaStockMinimo.SelectOnFocus = true;
                        this.EntradaStockMinimo.Size = new System.Drawing.Size(88, 24);
                        this.EntradaStockMinimo.Sufijo = "";
                        this.EntradaStockMinimo.TabIndex = 16;
                        this.EntradaStockMinimo.Text = "0.00";
                        this.EntradaStockMinimo.TextRaw = "0.00";
                        this.EntradaStockMinimo.TipWhenBlank = "";
                        this.EntradaStockMinimo.ToolTipText = "Stock mínimo o crítico";
                        // 
                        // Label11
                        // 
                        this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label11.Location = new System.Drawing.Point(234, 132);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(96, 24);
                        this.Label11.TabIndex = 15;
                        this.Label11.Text = "Stock Mínimo";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(8, 100);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(76, 24);
                        this.Label7.TabIndex = 7;
                        this.Label7.Text = "Usa Stock";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(8, 36);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(76, 24);
                        this.Label6.TabIndex = 0;
                        this.Label6.Text = "Costo";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonInfoCosto
                        // 
                        this.BotonInfoCosto.AutoHeight = false;
                        this.BotonInfoCosto.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonInfoCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonInfoCosto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonInfoCosto.Image = null;
                        this.BotonInfoCosto.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonInfoCosto.Location = new System.Drawing.Point(180, 36);
                        this.BotonInfoCosto.Name = "BotonInfoCosto";
                        this.BotonInfoCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonInfoCosto.ReadOnly = false;
                        this.BotonInfoCosto.Size = new System.Drawing.Size(28, 24);
                        this.BotonInfoCosto.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonInfoCosto.Subtext = "";
                        this.BotonInfoCosto.TabIndex = 2;
                        this.BotonInfoCosto.Text = "...";
                        this.BotonInfoCosto.ToolTipText = "Ver más datos sobre el precio";
                        this.BotonInfoCosto.Click += new System.EventHandler(this.cmdInfo_Click);
                        // 
                        // EntradaPvp
                        // 
                        this.EntradaPvp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPvp.AutoHeight = false;
                        this.EntradaPvp.AutoNav = true;
                        this.EntradaPvp.AutoTab = true;
                        this.EntradaPvp.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaPvp.DecimalPlaces = -1;
                        this.EntradaPvp.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPvp.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPvp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPvp.Location = new System.Drawing.Point(338, 36);
                        this.EntradaPvp.MaxLenght = 32767;
                        this.EntradaPvp.MultiLine = false;
                        this.EntradaPvp.Name = "EntradaPvp";
                        this.EntradaPvp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPvp.PasswordChar = '\0';
                        this.EntradaPvp.Prefijo = "";
                        this.EntradaPvp.ReadOnly = false;
                        this.EntradaPvp.SelectOnFocus = true;
                        this.EntradaPvp.Size = new System.Drawing.Size(108, 24);
                        this.EntradaPvp.Sufijo = "";
                        this.EntradaPvp.TabIndex = 4;
                        this.EntradaPvp.Text = "0.00";
                        this.EntradaPvp.TextRaw = "0.00";
                        this.EntradaPvp.TipWhenBlank = "";
                        this.EntradaPvp.ToolTipText = "Precio de venta al público. Puede dejar el PVP en blanco y utilizar un márgen pre" +
                            "definido a continuación";
                        this.EntradaPvp.TextChanged += new System.EventHandler(this.txtPVP_TextChanged);
                        // 
                        // BotonArticuloVerMovimientos
                        // 
                        this.BotonArticuloVerMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonArticuloVerMovimientos.AutoHeight = false;
                        this.BotonArticuloVerMovimientos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonArticuloVerMovimientos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonArticuloVerMovimientos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonArticuloVerMovimientos.Image = null;
                        this.BotonArticuloVerMovimientos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonArticuloVerMovimientos.Location = new System.Drawing.Point(418, 100);
                        this.BotonArticuloVerMovimientos.Name = "BotonArticuloVerMovimientos";
                        this.BotonArticuloVerMovimientos.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonArticuloVerMovimientos.ReadOnly = false;
                        this.BotonArticuloVerMovimientos.Size = new System.Drawing.Size(28, 24);
                        this.BotonArticuloVerMovimientos.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonArticuloVerMovimientos.Subtext = "";
                        this.BotonArticuloVerMovimientos.TabIndex = 11;
                        this.BotonArticuloVerMovimientos.Text = "...";
                        this.BotonArticuloVerMovimientos.ToolTipText = "Ver historial de movimientos de stock";
                        this.BotonArticuloVerMovimientos.Click += new System.EventHandler(this.cmdArticulosMovimDetalles_Click);
                        this.BotonArticuloVerMovimientos.GotFocus += new System.EventHandler(this.cmdArticulosMovimDetalles_GotFocus);
                        // 
                        // Label10
                        // 
                        this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label10.Location = new System.Drawing.Point(306, 36);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(32, 24);
                        this.Label10.TabIndex = 3;
                        this.Label10.Text = "PVP";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockActual
                        // 
                        this.EntradaStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaStockActual.AutoHeight = false;
                        this.EntradaStockActual.AutoNav = true;
                        this.EntradaStockActual.AutoTab = true;
                        this.EntradaStockActual.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaStockActual.DecimalPlaces = -1;
                        this.EntradaStockActual.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockActual.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaStockActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockActual.Location = new System.Drawing.Point(330, 100);
                        this.EntradaStockActual.MaxLenght = 32767;
                        this.EntradaStockActual.MultiLine = false;
                        this.EntradaStockActual.Name = "EntradaStockActual";
                        this.EntradaStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockActual.PasswordChar = '\0';
                        this.EntradaStockActual.Prefijo = "";
                        this.EntradaStockActual.ReadOnly = true;
                        this.EntradaStockActual.SelectOnFocus = true;
                        this.EntradaStockActual.Size = new System.Drawing.Size(88, 24);
                        this.EntradaStockActual.Sufijo = "";
                        this.EntradaStockActual.TabIndex = 10;
                        this.EntradaStockActual.TabStop = false;
                        this.EntradaStockActual.Text = "0.00";
                        this.EntradaStockActual.TextRaw = "0.00";
                        this.EntradaStockActual.TipWhenBlank = "";
                        this.EntradaStockActual.ToolTipText = "";
                        this.EntradaStockActual.TextChanged += new System.EventHandler(this.txtStockActual_TextChanged);
                        // 
                        // Label9
                        // 
                        this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label9.Location = new System.Drawing.Point(234, 100);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(96, 24);
                        this.Label9.TabIndex = 9;
                        this.Label9.Text = "Stock Actual";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame1
                        // 
                        this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame1.AutoHeight = false;
                        this.Frame1.Controls.Add(this.EntradaCuenta);
                        this.Frame1.Controls.Add(this.label17);
                        this.Frame1.Controls.Add(this.EntradaProveedor);
                        this.Frame1.Controls.Add(this.EntradaCategoria);
                        this.Frame1.Controls.Add(this.Label14);
                        this.Frame1.Controls.Add(this.EntradaMarca);
                        this.Frame1.Controls.Add(this.Label2);
                        this.Frame1.Controls.Add(this.EntradaDestacado);
                        this.Frame1.Controls.Add(this.Label13);
                        this.Frame1.Controls.Add(this.Label3);
                        this.Frame1.Controls.Add(this.EntradaCodigo4);
                        this.Frame1.Controls.Add(this.Label15);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo4);
                        this.Frame1.Controls.Add(this.EntradaCodigo3);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo3);
                        this.Frame1.Controls.Add(this.EntradaDescripcion2);
                        this.Frame1.Controls.Add(this.EntradaCodigo2);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo2);
                        this.Frame1.Controls.Add(this.EntradaCodigo1);
                        this.Frame1.Controls.Add(this.EtiquetaCodigo1);
                        this.Frame1.Controls.Add(this.Label1);
                        this.Frame1.Controls.Add(this.EntradaWeb);
                        this.Frame1.Controls.Add(this.Label18);
                        this.Frame1.Controls.Add(this.EntradaUrl);
                        this.Frame1.Controls.Add(this.Label16);
                        this.Frame1.Controls.Add(this.Label12);
                        this.Frame1.Controls.Add(this.EntradaNombre);
                        this.Frame1.Controls.Add(this.Label5);
                        this.Frame1.Controls.Add(this.EntradaSerie);
                        this.Frame1.Controls.Add(this.EntradaModelo);
                        this.Frame1.Controls.Add(this.Label4);
                        this.Frame1.Controls.Add(this.EntradaDescripcion);
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame1.Location = new System.Drawing.Point(7, 7);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.ReadOnly = false;
                        this.Frame1.Size = new System.Drawing.Size(881, 327);
                        this.Frame1.TabIndex = 0;
                        this.Frame1.Text = "Detalles de Artículo";
                        this.Frame1.ToolTipText = "";
                        // 
                        // EntradaCuenta
                        // 
                        this.EntradaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCuenta.AutoHeight = false;
                        this.EntradaCuenta.AutoTab = true;
                        this.EntradaCuenta.CanCreate = true;
                        this.EntradaCuenta.DetailField = "nombre";
                        this.EntradaCuenta.ExtraDetailFields = null;
                        this.EntradaCuenta.Filter = "id_cuenta>999";
                        this.EntradaCuenta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCuenta.FreeTextCode = "";
                        this.EntradaCuenta.KeyField = "id_cuenta";
                        this.EntradaCuenta.Location = new System.Drawing.Point(640, 296);
                        this.EntradaCuenta.MaxLength = 200;
                        this.EntradaCuenta.Name = "EntradaCuenta";
                        this.EntradaCuenta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuenta.ReadOnly = false;
                        this.EntradaCuenta.Required = false;
                        this.EntradaCuenta.SelectOnFocus = false;
                        this.EntradaCuenta.Size = new System.Drawing.Size(232, 24);
                        this.EntradaCuenta.TabIndex = 30;
                        this.EntradaCuenta.Table = "cuentas";
                        this.EntradaCuenta.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCuenta.Text = "0";
                        this.EntradaCuenta.TextDetail = "";
                        this.EntradaCuenta.TextInt = 0;
                        this.EntradaCuenta.TipWhenBlank = "Sin especificar";
                        this.EntradaCuenta.ToolTipText = "";
                        // 
                        // label17
                        // 
                        this.label17.Location = new System.Drawing.Point(520, 296);
                        this.label17.Name = "label17";
                        this.label17.Size = new System.Drawing.Size(120, 24);
                        this.label17.TabIndex = 29;
                        this.label17.Text = "Cuenta asociada";
                        this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaProveedor
                        // 
                        this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProveedor.AutoHeight = false;
                        this.EntradaProveedor.AutoTab = true;
                        this.EntradaProveedor.CanCreate = true;
                        this.EntradaProveedor.DetailField = "nombre_visible";
                        this.EntradaProveedor.ExtraDetailFields = null;
                        this.EntradaProveedor.Filter = "(tipo&2)=2";
                        this.EntradaProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaProveedor.FreeTextCode = "";
                        this.EntradaProveedor.KeyField = "id_persona";
                        this.EntradaProveedor.Location = new System.Drawing.Point(516, 152);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.ReadOnly = false;
                        this.EntradaProveedor.Required = false;
                        this.EntradaProveedor.SelectOnFocus = false;
                        this.EntradaProveedor.Size = new System.Drawing.Size(357, 24);
                        this.EntradaProveedor.TabIndex = 21;
                        this.EntradaProveedor.Table = "personas";
                        this.EntradaProveedor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        this.EntradaProveedor.TextInt = 0;
                        this.EntradaProveedor.TipWhenBlank = "Sin especificar";
                        this.EntradaProveedor.ToolTipText = "";
                        // 
                        // EntradaCategoria
                        // 
                        this.EntradaCategoria.AutoHeight = false;
                        this.EntradaCategoria.AutoTab = true;
                        this.EntradaCategoria.CanCreate = true;
                        this.EntradaCategoria.DetailField = "nombre";
                        this.EntradaCategoria.ExtraDetailFields = null;
                        this.EntradaCategoria.Filter = "";
                        this.EntradaCategoria.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCategoria.FreeTextCode = "";
                        this.EntradaCategoria.KeyField = "id_cat_articulo";
                        this.EntradaCategoria.Location = new System.Drawing.Point(84, 68);
                        this.EntradaCategoria.MaxLength = 200;
                        this.EntradaCategoria.Name = "EntradaCategoria";
                        this.EntradaCategoria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCategoria.ReadOnly = false;
                        this.EntradaCategoria.Required = true;
                        this.EntradaCategoria.SelectOnFocus = false;
                        this.EntradaCategoria.Size = new System.Drawing.Size(292, 24);
                        this.EntradaCategoria.TabIndex = 9;
                        this.EntradaCategoria.Table = "cat_articulos";
                        this.EntradaCategoria.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCategoria.Text = "0";
                        this.EntradaCategoria.TextDetail = "";
                        this.EntradaCategoria.TextInt = 0;
                        this.EntradaCategoria.TipWhenBlank = "";
                        this.EntradaCategoria.ToolTipText = "Rubro o categoría";
                        this.EntradaCategoria.TextChanged += new System.EventHandler(this.txtCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // Label14
                        // 
                        this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label14.Location = new System.Drawing.Point(436, 152);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(80, 24);
                        this.Label14.TabIndex = 20;
                        this.Label14.Text = "Proveedor";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMarca
                        // 
                        this.EntradaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaMarca.AutoHeight = false;
                        this.EntradaMarca.AutoTab = true;
                        this.EntradaMarca.CanCreate = true;
                        this.EntradaMarca.DetailField = "nombre";
                        this.EntradaMarca.ExtraDetailFields = null;
                        this.EntradaMarca.Filter = "";
                        this.EntradaMarca.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMarca.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMarca.FreeTextCode = "";
                        this.EntradaMarca.KeyField = "id_marca";
                        this.EntradaMarca.Location = new System.Drawing.Point(444, 68);
                        this.EntradaMarca.MaxLength = 200;
                        this.EntradaMarca.Name = "EntradaMarca";
                        this.EntradaMarca.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMarca.ReadOnly = false;
                        this.EntradaMarca.Required = false;
                        this.EntradaMarca.SelectOnFocus = false;
                        this.EntradaMarca.Size = new System.Drawing.Size(429, 24);
                        this.EntradaMarca.TabIndex = 11;
                        this.EntradaMarca.Table = "marcas";
                        this.EntradaMarca.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaMarca.Text = "0";
                        this.EntradaMarca.TextDetail = "";
                        this.EntradaMarca.TextInt = 0;
                        this.EntradaMarca.TipWhenBlank = "Sin especificar";
                        this.EntradaMarca.ToolTipText = "";
                        this.EntradaMarca.TextChanged += new System.EventHandler(this.txtCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(8, 68);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(76, 24);
                        this.Label2.TabIndex = 8;
                        this.Label2.Text = "Categoría";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDestacado
                        // 
                        this.EntradaDestacado.AutoHeight = false;
                        this.EntradaDestacado.AutoNav = true;
                        this.EntradaDestacado.AutoTab = true;
                        this.EntradaDestacado.DetailField = null;
                        this.EntradaDestacado.Filter = null;
                        this.EntradaDestacado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDestacado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDestacado.KeyField = null;
                        this.EntradaDestacado.Location = new System.Drawing.Point(84, 296);
                        this.EntradaDestacado.MaxLenght = 32767;
                        this.EntradaDestacado.Name = "EntradaDestacado";
                        this.EntradaDestacado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDestacado.ReadOnly = false;
                        this.EntradaDestacado.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaDestacado.Size = new System.Drawing.Size(64, 24);
                        this.EntradaDestacado.TabIndex = 26;
                        this.EntradaDestacado.Table = null;
                        this.EntradaDestacado.Text = "No";
                        this.EntradaDestacado.TextKey = "0";
                        this.EntradaDestacado.TextRaw = "No";
                        this.EntradaDestacado.TipWhenBlank = "";
                        this.EntradaDestacado.ToolTipText = "";
                        // 
                        // Label13
                        // 
                        this.Label13.Location = new System.Drawing.Point(8, 184);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(76, 24);
                        this.Label13.TabIndex = 22;
                        this.Label13.Text = "Descrip.";
                        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 96);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(76, 24);
                        this.Label3.TabIndex = 12;
                        this.Label3.Text = "Modelo";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo4
                        // 
                        this.EntradaCodigo4.AutoHeight = false;
                        this.EntradaCodigo4.AutoNav = true;
                        this.EntradaCodigo4.AutoTab = true;
                        this.EntradaCodigo4.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo4.DecimalPlaces = -1;
                        this.EntradaCodigo4.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCodigo4.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCodigo4.Location = new System.Drawing.Point(556, 36);
                        this.EntradaCodigo4.MaxLenght = 32767;
                        this.EntradaCodigo4.MultiLine = false;
                        this.EntradaCodigo4.Name = "EntradaCodigo4";
                        this.EntradaCodigo4.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo4.PasswordChar = '\0';
                        this.EntradaCodigo4.Prefijo = "";
                        this.EntradaCodigo4.ReadOnly = false;
                        this.EntradaCodigo4.SelectOnFocus = true;
                        this.EntradaCodigo4.Size = new System.Drawing.Size(104, 24);
                        this.EntradaCodigo4.Sufijo = "";
                        this.EntradaCodigo4.TabIndex = 7;
                        this.EntradaCodigo4.TextRaw = "";
                        this.EntradaCodigo4.TipWhenBlank = "";
                        this.EntradaCodigo4.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(8, 296);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(76, 24);
                        this.Label15.TabIndex = 25;
                        this.Label15.Text = "Destacado";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaCodigo4
                        // 
                        this.EtiquetaCodigo4.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaCodigo4.Location = new System.Drawing.Point(500, 36);
                        this.EtiquetaCodigo4.Name = "EtiquetaCodigo4";
                        this.EtiquetaCodigo4.Size = new System.Drawing.Size(56, 24);
                        this.EtiquetaCodigo4.TabIndex = 6;
                        this.EtiquetaCodigo4.Text = "Código 4";
                        this.EtiquetaCodigo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo3
                        // 
                        this.EntradaCodigo3.AutoHeight = false;
                        this.EntradaCodigo3.AutoNav = true;
                        this.EntradaCodigo3.AutoTab = true;
                        this.EntradaCodigo3.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo3.DecimalPlaces = -1;
                        this.EntradaCodigo3.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCodigo3.ForceCase = Lui.Forms.TextCasing.UpperCase;
                        this.EntradaCodigo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCodigo3.Location = new System.Drawing.Point(392, 36);
                        this.EntradaCodigo3.MaxLenght = 32767;
                        this.EntradaCodigo3.MultiLine = false;
                        this.EntradaCodigo3.Name = "EntradaCodigo3";
                        this.EntradaCodigo3.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo3.PasswordChar = '\0';
                        this.EntradaCodigo3.Prefijo = "";
                        this.EntradaCodigo3.ReadOnly = false;
                        this.EntradaCodigo3.SelectOnFocus = true;
                        this.EntradaCodigo3.Size = new System.Drawing.Size(104, 24);
                        this.EntradaCodigo3.Sufijo = "";
                        this.EntradaCodigo3.TabIndex = 5;
                        this.EntradaCodigo3.TextRaw = "";
                        this.EntradaCodigo3.TipWhenBlank = "";
                        this.EntradaCodigo3.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EtiquetaCodigo3
                        // 
                        this.EtiquetaCodigo3.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaCodigo3.Location = new System.Drawing.Point(336, 36);
                        this.EtiquetaCodigo3.Name = "EtiquetaCodigo3";
                        this.EtiquetaCodigo3.Size = new System.Drawing.Size(56, 24);
                        this.EtiquetaCodigo3.TabIndex = 4;
                        this.EtiquetaCodigo3.Text = "Código 3";
                        this.EtiquetaCodigo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDescripcion2
                        // 
                        this.EntradaDescripcion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaDescripcion2.AutoHeight = false;
                        this.EntradaDescripcion2.AutoNav = true;
                        this.EntradaDescripcion2.AutoTab = true;
                        this.EntradaDescripcion2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion2.DecimalPlaces = -1;
                        this.EntradaDescripcion2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescripcion2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescripcion2.Location = new System.Drawing.Point(556, 184);
                        this.EntradaDescripcion2.MaxLenght = 32767;
                        this.EntradaDescripcion2.MultiLine = true;
                        this.EntradaDescripcion2.Name = "EntradaDescripcion2";
                        this.EntradaDescripcion2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion2.PasswordChar = '\0';
                        this.EntradaDescripcion2.Prefijo = "";
                        this.EntradaDescripcion2.ReadOnly = false;
                        this.EntradaDescripcion2.SelectOnFocus = false;
                        this.EntradaDescripcion2.Size = new System.Drawing.Size(317, 108);
                        this.EntradaDescripcion2.Sufijo = "";
                        this.EntradaDescripcion2.TabIndex = 25;
                        this.EntradaDescripcion2.TextRaw = "";
                        this.EntradaDescripcion2.TipWhenBlank = "";
                        this.EntradaDescripcion2.ToolTipText = "Descripción larga";
                        // 
                        // EntradaCodigo2
                        // 
                        this.EntradaCodigo2.AutoHeight = false;
                        this.EntradaCodigo2.AutoNav = true;
                        this.EntradaCodigo2.AutoTab = true;
                        this.EntradaCodigo2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo2.DecimalPlaces = -1;
                        this.EntradaCodigo2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCodigo2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCodigo2.Location = new System.Drawing.Point(228, 36);
                        this.EntradaCodigo2.MaxLenght = 32767;
                        this.EntradaCodigo2.MultiLine = false;
                        this.EntradaCodigo2.Name = "EntradaCodigo2";
                        this.EntradaCodigo2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo2.PasswordChar = '\0';
                        this.EntradaCodigo2.Prefijo = "";
                        this.EntradaCodigo2.ReadOnly = false;
                        this.EntradaCodigo2.SelectOnFocus = true;
                        this.EntradaCodigo2.Size = new System.Drawing.Size(104, 24);
                        this.EntradaCodigo2.Sufijo = "";
                        this.EntradaCodigo2.TabIndex = 3;
                        this.EntradaCodigo2.TextRaw = "";
                        this.EntradaCodigo2.TipWhenBlank = "";
                        this.EntradaCodigo2.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EtiquetaCodigo2
                        // 
                        this.EtiquetaCodigo2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaCodigo2.Location = new System.Drawing.Point(172, 36);
                        this.EtiquetaCodigo2.Name = "EtiquetaCodigo2";
                        this.EtiquetaCodigo2.Size = new System.Drawing.Size(56, 24);
                        this.EtiquetaCodigo2.TabIndex = 2;
                        this.EtiquetaCodigo2.Text = "Código 2";
                        this.EtiquetaCodigo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo1
                        // 
                        this.EntradaCodigo1.AutoHeight = false;
                        this.EntradaCodigo1.AutoNav = true;
                        this.EntradaCodigo1.AutoTab = true;
                        this.EntradaCodigo1.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo1.DecimalPlaces = -1;
                        this.EntradaCodigo1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCodigo1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCodigo1.Location = new System.Drawing.Point(64, 36);
                        this.EntradaCodigo1.MaxLenght = 32767;
                        this.EntradaCodigo1.MultiLine = false;
                        this.EntradaCodigo1.Name = "EntradaCodigo1";
                        this.EntradaCodigo1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo1.PasswordChar = '\0';
                        this.EntradaCodigo1.Prefijo = "";
                        this.EntradaCodigo1.ReadOnly = false;
                        this.EntradaCodigo1.SelectOnFocus = true;
                        this.EntradaCodigo1.Size = new System.Drawing.Size(104, 24);
                        this.EntradaCodigo1.Sufijo = "";
                        this.EntradaCodigo1.TabIndex = 1;
                        this.EntradaCodigo1.TextRaw = "";
                        this.EntradaCodigo1.TipWhenBlank = "";
                        this.EntradaCodigo1.ToolTipText = "Puede escribir hasta 4 códigos diferentes para el mismo artículo";
                        // 
                        // EtiquetaCodigo1
                        // 
                        this.EtiquetaCodigo1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaCodigo1.Location = new System.Drawing.Point(8, 36);
                        this.EtiquetaCodigo1.Name = "EtiquetaCodigo1";
                        this.EtiquetaCodigo1.Size = new System.Drawing.Size(56, 24);
                        this.EtiquetaCodigo1.TabIndex = 0;
                        this.EtiquetaCodigo1.Text = "Código 1";
                        this.EtiquetaCodigo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(392, 68);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(52, 24);
                        this.Label1.TabIndex = 10;
                        this.Label1.Text = "Marca";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaWeb
                        // 
                        this.EntradaWeb.AutoHeight = false;
                        this.EntradaWeb.AutoNav = true;
                        this.EntradaWeb.AutoTab = true;
                        this.EntradaWeb.DetailField = null;
                        this.EntradaWeb.Filter = null;
                        this.EntradaWeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaWeb.KeyField = null;
                        this.EntradaWeb.Location = new System.Drawing.Point(300, 296);
                        this.EntradaWeb.MaxLenght = 32767;
                        this.EntradaWeb.Name = "EntradaWeb";
                        this.EntradaWeb.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaWeb.ReadOnly = false;
                        this.EntradaWeb.SetData = new string[] {
        "Siempre|1",
        "Sólo si hay Stock o Pedidos|2",
        "Nunca|0"};
                        this.EntradaWeb.Size = new System.Drawing.Size(208, 24);
                        this.EntradaWeb.TabIndex = 28;
                        this.EntradaWeb.Table = null;
                        this.EntradaWeb.Text = "Sólo si hay Stock o Pedidos";
                        this.EntradaWeb.TextKey = "2";
                        this.EntradaWeb.TextRaw = "Sólo si hay Stock o Pedidos";
                        this.EntradaWeb.TipWhenBlank = "";
                        this.EntradaWeb.ToolTipText = "";
                        // 
                        // Label18
                        // 
                        this.Label18.Location = new System.Drawing.Point(480, 184);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(76, 32);
                        this.Label18.TabIndex = 24;
                        this.Label18.Text = "Descrip. Extendida";
                        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaUrl
                        // 
                        this.EntradaUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUrl.AutoHeight = false;
                        this.EntradaUrl.AutoNav = true;
                        this.EntradaUrl.AutoTab = true;
                        this.EntradaUrl.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaUrl.DecimalPlaces = -1;
                        this.EntradaUrl.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaUrl.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaUrl.Location = new System.Drawing.Point(84, 152);
                        this.EntradaUrl.MaxLenght = 32767;
                        this.EntradaUrl.MultiLine = false;
                        this.EntradaUrl.Name = "EntradaUrl";
                        this.EntradaUrl.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUrl.PasswordChar = '\0';
                        this.EntradaUrl.Prefijo = "";
                        this.EntradaUrl.ReadOnly = false;
                        this.EntradaUrl.SelectOnFocus = false;
                        this.EntradaUrl.Size = new System.Drawing.Size(345, 24);
                        this.EntradaUrl.Sufijo = "";
                        this.EntradaUrl.TabIndex = 19;
                        this.EntradaUrl.TextRaw = "";
                        this.EntradaUrl.TipWhenBlank = "";
                        this.EntradaUrl.ToolTipText = "Dirección de la página web del producto.";
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(160, 296);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(144, 24);
                        this.Label16.TabIndex = 27;
                        this.Label16.Text = "Publicar en la Web";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label12
                        // 
                        this.Label12.Location = new System.Drawing.Point(8, 152);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(76, 24);
                        this.Label12.TabIndex = 18;
                        this.Label12.Text = "URL";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoHeight = false;
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(84, 124);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(789, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 17;
                        this.EntradaNombre.TextRaw = "";
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "Nombre completo del artículo";
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
                        this.EntradaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(8, 124);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(76, 24);
                        this.Label5.TabIndex = 16;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSerie
                        // 
                        this.EntradaSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSerie.AutoHeight = false;
                        this.EntradaSerie.AutoNav = true;
                        this.EntradaSerie.AutoTab = true;
                        this.EntradaSerie.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaSerie.DecimalPlaces = -1;
                        this.EntradaSerie.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSerie.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaSerie.Location = new System.Drawing.Point(444, 96);
                        this.EntradaSerie.MaxLenght = 32767;
                        this.EntradaSerie.MultiLine = false;
                        this.EntradaSerie.Name = "EntradaSerie";
                        this.EntradaSerie.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSerie.PasswordChar = '\0';
                        this.EntradaSerie.Prefijo = "";
                        this.EntradaSerie.ReadOnly = false;
                        this.EntradaSerie.SelectOnFocus = false;
                        this.EntradaSerie.Size = new System.Drawing.Size(429, 24);
                        this.EntradaSerie.Sufijo = "";
                        this.EntradaSerie.TabIndex = 15;
                        this.EntradaSerie.TextRaw = "";
                        this.EntradaSerie.TipWhenBlank = "";
                        this.EntradaSerie.ToolTipText = "";
                        this.EntradaSerie.TextChanged += new System.EventHandler(this.txtCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // EntradaModelo
                        // 
                        this.EntradaModelo.AutoHeight = false;
                        this.EntradaModelo.AutoNav = true;
                        this.EntradaModelo.AutoTab = true;
                        this.EntradaModelo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaModelo.DecimalPlaces = -1;
                        this.EntradaModelo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaModelo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaModelo.Location = new System.Drawing.Point(84, 96);
                        this.EntradaModelo.MaxLenght = 32767;
                        this.EntradaModelo.MultiLine = false;
                        this.EntradaModelo.Name = "EntradaModelo";
                        this.EntradaModelo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModelo.PasswordChar = '\0';
                        this.EntradaModelo.Prefijo = "";
                        this.EntradaModelo.ReadOnly = false;
                        this.EntradaModelo.SelectOnFocus = false;
                        this.EntradaModelo.Size = new System.Drawing.Size(292, 24);
                        this.EntradaModelo.Sufijo = "";
                        this.EntradaModelo.TabIndex = 13;
                        this.EntradaModelo.TextRaw = "";
                        this.EntradaModelo.TipWhenBlank = "";
                        this.EntradaModelo.ToolTipText = "";
                        this.EntradaModelo.TextChanged += new System.EventHandler(this.txtCategoriaMarcaModeloSerie_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(392, 96);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(52, 24);
                        this.Label4.TabIndex = 14;
                        this.Label4.Text = "Serie";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDescripcion
                        // 
                        this.EntradaDescripcion.AutoHeight = false;
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.AutoTab = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescripcion.Location = new System.Drawing.Point(84, 184);
                        this.EntradaDescripcion.MaxLenght = 32767;
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "EntradaDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.PasswordChar = '\0';
                        this.EntradaDescripcion.Prefijo = "";
                        this.EntradaDescripcion.ReadOnly = false;
                        this.EntradaDescripcion.SelectOnFocus = false;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(384, 104);
                        this.EntradaDescripcion.Sufijo = "";
                        this.EntradaDescripcion.TabIndex = 23;
                        this.EntradaDescripcion.TextRaw = "";
                        this.EntradaDescripcion.TipWhenBlank = "";
                        this.EntradaDescripcion.ToolTipText = "Descripción larga";
                        // 
                        // cmdDescripcion
                        // 
                        this.cmdDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdDescripcion.AutoHeight = false;
                        this.cmdDescripcion.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdDescripcion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdDescripcion.Image = null;
                        this.cmdDescripcion.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdDescripcion.Location = new System.Drawing.Point(421, 477);
                        this.cmdDescripcion.Name = "cmdDescripcion";
                        this.cmdDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdDescripcion.ReadOnly = false;
                        this.cmdDescripcion.Size = new System.Drawing.Size(104, 44);
                        this.cmdDescripcion.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdDescripcion.Subtext = "F7";
                        this.cmdDescripcion.TabIndex = 50;
                        this.cmdDescripcion.Text = "Descripción";
                        this.cmdDescripcion.ToolTipText = "";
                        this.cmdDescripcion.Click += new System.EventHandler(this.cmdDescripcion_Click);
                        // 
                        // flowLayoutPanel1
                        // 
                        this.flowLayoutPanel1.AutoScroll = true;
                        this.flowLayoutPanel1.Controls.Add(this.Frame1);
                        this.flowLayoutPanel1.Controls.Add(this.Frame2);
                        this.flowLayoutPanel1.Controls.Add(this.Frame3);
                        this.flowLayoutPanel1.Controls.Add(this.Frame4);
                        this.flowLayoutPanel1.Controls.Add(this.frame5);
                        this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
                        this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
                        this.flowLayoutPanel1.Size = new System.Drawing.Size(913, 530);
                        this.flowLayoutPanel1.TabIndex = 0;
                        // 
                        // Frame4
                        // 
                        this.Frame4.AutoHeight = false;
                        this.Frame4.Controls.Add(this.EntradaTags);
                        this.Frame4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame4.Location = new System.Drawing.Point(7, 514);
                        this.Frame4.Name = "Frame4";
                        this.Frame4.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame4.ReadOnly = false;
                        this.Frame4.Size = new System.Drawing.Size(453, 143);
                        this.Frame4.TabIndex = 3;
                        this.Frame4.Text = "Atributos";
                        this.Frame4.ToolTipText = "";
                        // 
                        // EntradaTags
                        // 
                        this.EntradaTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaTags.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTags.Location = new System.Drawing.Point(8, 28);
                        this.EntradaTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaTags.Name = "EntradaTags";
                        this.EntradaTags.Size = new System.Drawing.Size(436, 108);
                        this.EntradaTags.TabIndex = 32;
                        this.EntradaTags.Text = "Atributos especiales";
                        // 
                        // frame5
                        // 
                        this.frame5.AutoHeight = false;
                        this.frame5.Controls.Add(this.etiquetas1);
                        this.frame5.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame5.Location = new System.Drawing.Point(466, 514);
                        this.frame5.Name = "frame5";
                        this.frame5.Padding = new System.Windows.Forms.Padding(2);
                        this.frame5.ReadOnly = false;
                        this.frame5.Size = new System.Drawing.Size(380, 184);
                        this.frame5.TabIndex = 4;
                        this.frame5.Text = "Etiquetas";
                        this.frame5.ToolTipText = "";
                        // 
                        // etiquetas1
                        // 
                        this.etiquetas1.AutoHeight = false;
                        this.etiquetas1.AutoNav = true;
                        this.etiquetas1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.etiquetas1.Location = new System.Drawing.Point(11, 29);
                        this.etiquetas1.Name = "etiquetas1";
                        this.etiquetas1.Padding = new System.Windows.Forms.Padding(2);
                        this.etiquetas1.ReadOnly = false;
                        this.etiquetas1.Size = new System.Drawing.Size(364, 137);
                        this.etiquetas1.TabIndex = 1;
                        this.etiquetas1.Text = "etiquetas1";
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(913, 530);
                        this.Controls.Add(this.cmdDescripcion);
                        this.Controls.Add(this.flowLayoutPanel1);
                        this.Name = "Editar";
                        this.WorkspaceChanged += new System.EventHandler(this.FormArticulosEditar_WorkspaceChanged);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArticulosEditar_KeyDown);
                        this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
                        this.Controls.SetChildIndex(this.cmdDescripcion, 0);
                        this.Frame3.ResumeLayout(false);
                        this.Frame3.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).EndInit();
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.flowLayoutPanel1.ResumeLayout(false);
                        this.Frame4.ResumeLayout(false);
                        this.Frame4.PerformLayout();
                        this.frame5.ResumeLayout(false);
                        this.frame5.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
                private Lui.Forms.Frame Frame4;
                private Lui.Forms.FieldTags EntradaTags;
                internal Lui.Forms.ComboBox EntradaUnidad;
                internal System.Windows.Forms.Label label19;
                internal Lui.Forms.Button BotonUnidad;
                internal Lui.Forms.Button BotonQuitarImagen;
                internal System.Windows.Forms.PictureBox EntradaImagen;
                internal Lui.Forms.Button BotonSeleccionarImagen;
                internal System.Windows.Forms.Label Label15;
                internal Lui.Forms.TextBox EntradaCodigo4;
                internal System.Windows.Forms.Label EtiquetaCodigo4;
                internal Lui.Forms.TextBox EntradaCodigo3;
                internal System.Windows.Forms.Label EtiquetaCodigo3;
                internal Lui.Forms.TextBox EntradaCodigo2;
                internal System.Windows.Forms.Label EtiquetaCodigo2;
                internal Lui.Forms.TextBox EntradaCodigo1;
                internal System.Windows.Forms.Label EtiquetaCodigo1;
                internal Lui.Forms.DetailBox EntradaProveedor;
                internal System.Windows.Forms.Label Label14;
                internal Lui.Forms.TextBox EntradaDescripcion;
                internal System.Windows.Forms.Label Label13;
                internal Lui.Forms.TextBox EntradaUrl;
                internal System.Windows.Forms.Label Label12;
                internal Lui.Forms.Frame Frame3;
                internal Lui.Forms.TextBox EntradaStockMinimo;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.TextBox EntradaPvp;
                internal System.Windows.Forms.Label Label10;
                internal Lui.Forms.TextBox EntradaStockActual;
                internal System.Windows.Forms.Label Label9;
                internal Lui.Forms.ComboBox EntradaMargen;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.ComboBox EntradaUsaStock;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaCosto;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.Frame Frame2;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaSerie;
                internal Lui.Forms.TextBox EntradaModelo;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.DetailBox EntradaCategoria;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox EntradaMarca;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.ComboBox EntradaDestacado;
                internal Lui.Forms.Button BotonArticuloVerMovimientos;
                internal Lui.Forms.Button BotonInfoCosto;
                internal System.Windows.Forms.Label Label16;
                internal Lui.Forms.ComboBox EntradaWeb;
                internal Lui.Forms.Button cmdDescripcion;
                internal Lui.Forms.TextBox EntradaDescripcion2;
                internal System.Windows.Forms.Label Label18;
                internal Lui.Forms.DetailBox EntradaCuenta;
                internal System.Windows.Forms.Label label17;
                private Lui.Forms.Frame frame5;
                private Lcc.Controles.Datos.Etiquetas etiquetas1;
        }
}
