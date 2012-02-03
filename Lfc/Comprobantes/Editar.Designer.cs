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

namespace Lfc.Comprobantes
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.EntradaProductos = new Lcc.Entrada.Articulos.MatrizDetalleComprobante();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.EntradaDescuento = new Lui.Forms.TextBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.EntradaInteres = new Lui.Forms.TextBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaCuotas = new Lui.Forms.TextBox();
                        this.Label8 = new Lui.Forms.Label();
                        this.EntradaValorCuota = new Lui.Forms.TextBox();
                        this.Label9 = new Lui.Forms.Label();
                        this.EntradaComprobanteId = new System.Windows.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.PnlCuotas = new Lui.Forms.Panel();
                        this.EntradaIva = new Lui.Forms.TextBox();
                        this.EtiquetaIva = new Lui.Forms.Label();
                        this.PnlCuotas.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaProductos
                        // 
                        this.EntradaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProductos.AutoNav = true;
                        this.EntradaProductos.AutoScroll = true;
                        this.EntradaProductos.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.EntradaProductos.FieldName = null;
                        this.EntradaProductos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaProductos.FreeTextCode = "*";
                        this.EntradaProductos.Location = new System.Drawing.Point(0, 32);
                        this.EntradaProductos.LockPrice = false;
                        this.EntradaProductos.LockQuantity = false;
                        this.EntradaProductos.LockText = false;
                        this.EntradaProductos.Name = "EntradaProductos";
                        this.EntradaProductos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProductos.Precio = Lcc.Entrada.Articulos.Precios.Pvp;
                        this.EntradaProductos.ReadOnly = false;
                        this.EntradaProductos.ShowStock = true;
                        this.EntradaProductos.Size = new System.Drawing.Size(640, 264);
                        this.EntradaProductos.TabIndex = 20;
                        this.EntradaProductos.TotalChanged += new System.EventHandler(this.ProductArray_TotalChanged);
                        this.EntradaProductos.ObtenerDatosSeguimiento += new System.EventHandler(this.ProductArray_ObtenerDatosSeguimiento);
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(248, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(56, 24);
                        this.Label3.TabIndex = 3;
                        this.Label3.Text = "Cliente";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoNav = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.ExtraDetailFields = "";
                        this.EntradaCliente.FieldName = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.Location = new System.Drawing.Point(304, 0);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.PlaceholderText = null;
                        this.EntradaCliente.ReadOnly = false;
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(272, 24);
                        this.EntradaCliente.TabIndex = 4;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TextChanged += new System.EventHandler(this.EntradaCliente_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(0, 0);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(72, 24);
                        this.Label1.TabIndex = 1;
                        this.Label1.Text = "Vendedor";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.AutoNav = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.ExtraDetailFields = "";
                        this.EntradaVendedor.FieldName = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.Location = new System.Drawing.Point(72, 0);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.PlaceholderText = null;
                        this.EntradaVendedor.ReadOnly = false;
                        this.EntradaVendedor.Required = true;
                        this.EntradaVendedor.Size = new System.Drawing.Size(168, 24);
                        this.EntradaVendedor.TabIndex = 2;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.FieldName = null;
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.Location = new System.Drawing.Point(496, 328);
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.PlaceholderText = null;
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = false;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(144, 32);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 41;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TextChanged += new System.EventHandler(this.EntradaTotal_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Big;
                        this.Label4.Location = new System.Drawing.Point(416, 328);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(80, 32);
                        this.Label4.TabIndex = 40;
                        this.Label4.Text = "Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(0, 304);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(64, 24);
                        this.Label5.TabIndex = 21;
                        this.Label5.Text = "Subtotal";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSubTotal
                        // 
                        this.EntradaSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaSubTotal.AutoNav = true;
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.DecimalPlaces = -1;
                        this.EntradaSubTotal.FieldName = null;
                        this.EntradaSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSubTotal.Location = new System.Drawing.Point(64, 304);
                        this.EntradaSubTotal.MultiLine = false;
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubTotal.PasswordChar = '\0';
                        this.EntradaSubTotal.PlaceholderText = null;
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.ReadOnly = false;
                        this.EntradaSubTotal.SelectOnFocus = true;
                        this.EntradaSubTotal.Size = new System.Drawing.Size(92, 24);
                        this.EntradaSubTotal.Sufijo = "";
                        this.EntradaSubTotal.TabIndex = 22;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        this.EntradaSubTotal.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // EntradaDescuento
                        // 
                        this.EntradaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaDescuento.AutoNav = true;
                        this.EntradaDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaDescuento.DecimalPlaces = -1;
                        this.EntradaDescuento.FieldName = null;
                        this.EntradaDescuento.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescuento.Location = new System.Drawing.Point(224, 304);
                        this.EntradaDescuento.MultiLine = false;
                        this.EntradaDescuento.Name = "EntradaDescuento";
                        this.EntradaDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescuento.PasswordChar = '\0';
                        this.EntradaDescuento.PlaceholderText = null;
                        this.EntradaDescuento.Prefijo = "";
                        this.EntradaDescuento.ReadOnly = false;
                        this.EntradaDescuento.SelectOnFocus = true;
                        this.EntradaDescuento.Size = new System.Drawing.Size(76, 24);
                        this.EntradaDescuento.Sufijo = "%";
                        this.EntradaDescuento.TabIndex = 24;
                        this.EntradaDescuento.Text = "0.0000";
                        this.EntradaDescuento.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(164, 304);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(60, 24);
                        this.Label6.TabIndex = 23;
                        this.Label6.Text = "Descto.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaInteres
                        // 
                        this.EntradaInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaInteres.AutoNav = true;
                        this.EntradaInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaInteres.DecimalPlaces = -1;
                        this.EntradaInteres.FieldName = null;
                        this.EntradaInteres.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaInteres.Location = new System.Drawing.Point(224, 332);
                        this.EntradaInteres.MultiLine = false;
                        this.EntradaInteres.Name = "EntradaInteres";
                        this.EntradaInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaInteres.PasswordChar = '\0';
                        this.EntradaInteres.PlaceholderText = null;
                        this.EntradaInteres.Prefijo = "";
                        this.EntradaInteres.ReadOnly = false;
                        this.EntradaInteres.SelectOnFocus = true;
                        this.EntradaInteres.Size = new System.Drawing.Size(76, 24);
                        this.EntradaInteres.Sufijo = "%";
                        this.EntradaInteres.TabIndex = 26;
                        this.EntradaInteres.Text = "0.0000";
                        this.EntradaInteres.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label7
                        // 
                        this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label7.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label7.Location = new System.Drawing.Point(164, 332);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(60, 24);
                        this.Label7.TabIndex = 25;
                        this.Label7.Text = "Recargo";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCuotas
                        // 
                        this.EntradaCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaCuotas.AutoNav = true;
                        this.EntradaCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCuotas.DecimalPlaces = -1;
                        this.EntradaCuotas.FieldName = null;
                        this.EntradaCuotas.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCuotas.Location = new System.Drawing.Point(52, 0);
                        this.EntradaCuotas.MaxLength = 2;
                        this.EntradaCuotas.MultiLine = false;
                        this.EntradaCuotas.Name = "EntradaCuotas";
                        this.EntradaCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuotas.PasswordChar = '\0';
                        this.EntradaCuotas.PlaceholderText = null;
                        this.EntradaCuotas.Prefijo = "";
                        this.EntradaCuotas.ReadOnly = false;
                        this.EntradaCuotas.SelectOnFocus = true;
                        this.EntradaCuotas.Size = new System.Drawing.Size(32, 24);
                        this.EntradaCuotas.Sufijo = "";
                        this.EntradaCuotas.TabIndex = 28;
                        this.EntradaCuotas.Text = "0";
                        this.EntradaCuotas.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label8.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(0, 0);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(52, 24);
                        this.Label8.TabIndex = 27;
                        this.Label8.Text = "Cuotas";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaValorCuota
                        // 
                        this.EntradaValorCuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaValorCuota.AutoNav = true;
                        this.EntradaValorCuota.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaValorCuota.DecimalPlaces = -1;
                        this.EntradaValorCuota.FieldName = null;
                        this.EntradaValorCuota.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaValorCuota.Location = new System.Drawing.Point(108, 0);
                        this.EntradaValorCuota.MultiLine = false;
                        this.EntradaValorCuota.Name = "EntradaValorCuota";
                        this.EntradaValorCuota.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaValorCuota.PasswordChar = '\0';
                        this.EntradaValorCuota.PlaceholderText = null;
                        this.EntradaValorCuota.Prefijo = "$";
                        this.EntradaValorCuota.ReadOnly = false;
                        this.EntradaValorCuota.SelectOnFocus = true;
                        this.EntradaValorCuota.Size = new System.Drawing.Size(80, 24);
                        this.EntradaValorCuota.Sufijo = "";
                        this.EntradaValorCuota.TabIndex = 30;
                        this.EntradaValorCuota.TabStop = false;
                        this.EntradaValorCuota.Text = "0.00";
                        // 
                        // Label9
                        // 
                        this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label9.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label9.Location = new System.Drawing.Point(84, 0);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(24, 24);
                        this.Label9.TabIndex = 29;
                        this.Label9.Text = "de";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaComprobanteId
                        // 
                        this.EntradaComprobanteId.Location = new System.Drawing.Point(608, 344);
                        this.EntradaComprobanteId.Name = "EntradaComprobanteId";
                        this.EntradaComprobanteId.Size = new System.Drawing.Size(28, 23);
                        this.EntradaComprobanteId.TabIndex = 52;
                        this.EntradaComprobanteId.Visible = false;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label2.Location = new System.Drawing.Point(584, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(24, 24);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "PV";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.FieldName = null;
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.Location = new System.Drawing.Point(608, 0);
                        this.EntradaPV.MaxLength = 2;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.PlaceholderText = null;
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(32, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 6;
                        this.EntradaPV.Text = "0";
                        // 
                        // PnlCuotas
                        // 
                        this.PnlCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PnlCuotas.Controls.Add(this.Label8);
                        this.PnlCuotas.Controls.Add(this.EntradaCuotas);
                        this.PnlCuotas.Controls.Add(this.Label9);
                        this.PnlCuotas.Controls.Add(this.EntradaValorCuota);
                        this.PnlCuotas.Location = new System.Drawing.Point(308, 304);
                        this.PnlCuotas.Name = "PnlCuotas";
                        this.PnlCuotas.Size = new System.Drawing.Size(188, 24);
                        this.PnlCuotas.TabIndex = 27;
                        // 
                        // EntradaIva
                        // 
                        this.EntradaIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaIva.AutoNav = true;
                        this.EntradaIva.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaIva.DecimalPlaces = -1;
                        this.EntradaIva.FieldName = null;
                        this.EntradaIva.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaIva.Location = new System.Drawing.Point(64, 332);
                        this.EntradaIva.MultiLine = false;
                        this.EntradaIva.Name = "EntradaIva";
                        this.EntradaIva.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaIva.PasswordChar = '\0';
                        this.EntradaIva.PlaceholderText = null;
                        this.EntradaIva.Prefijo = "$";
                        this.EntradaIva.ReadOnly = false;
                        this.EntradaIva.SelectOnFocus = true;
                        this.EntradaIva.Size = new System.Drawing.Size(92, 24);
                        this.EntradaIva.Sufijo = "";
                        this.EntradaIva.TabIndex = 54;
                        this.EntradaIva.TabStop = false;
                        this.EntradaIva.Text = "0.00";
                        this.EntradaIva.Visible = false;
                        // 
                        // EtiquetaIva
                        // 
                        this.EtiquetaIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaIva.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.EtiquetaIva.Location = new System.Drawing.Point(0, 332);
                        this.EtiquetaIva.Name = "EtiquetaIva";
                        this.EtiquetaIva.Size = new System.Drawing.Size(64, 24);
                        this.EtiquetaIva.TabIndex = 53;
                        this.EtiquetaIva.Text = "IVA";
                        this.EtiquetaIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaIva.Visible = false;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaIva);
                        this.Controls.Add(this.EtiquetaIva);
                        this.Controls.Add(this.PnlCuotas);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaCliente);
                        this.Controls.Add(this.EntradaComprobanteId);
                        this.Controls.Add(this.EntradaInteres);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaDescuento);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.EntradaSubTotal);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaVendedor);
                        this.Controls.Add(this.EntradaProductos);
                        this.MinimumSize = new System.Drawing.Size(600, 360);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 360);
                        this.PnlCuotas.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lcc.Entrada.Articulos.MatrizDetalleComprobante EntradaProductos;
                internal Lui.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                internal Lui.Forms.TextBox EntradaTotal;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal Lui.Forms.TextBox EntradaDescuento;
                internal Lui.Forms.Label Label6;
                internal Lui.Forms.TextBox EntradaInteres;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaCuotas;
                internal Lui.Forms.Label Label8;
                internal Lui.Forms.TextBox EntradaValorCuota;
                internal Lui.Forms.Label Label9;
                internal System.Windows.Forms.TextBox EntradaComprobanteId;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaPV;
                internal Lui.Forms.Panel PnlCuotas;
                internal Lui.Forms.TextBox EntradaIva;
                internal Lui.Forms.Label EtiquetaIva;
        }
}
