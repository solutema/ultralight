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

namespace Lfc.Comprobantes
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.ProductArray = new Lcc.Entrada.Articulos.MatrizDetalleComprobante();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaSubTotal = new Lui.Forms.TextBox();
                        this.EntradaDescuento = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EntradaInteres = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaCuotas = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.EntradaValorCuota = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.BotonObs = new Lui.Forms.Button();
                        this.BotonConvertir = new Lui.Forms.Button();
                        this.EntradaComprobanteId = new System.Windows.Forms.TextBox();
                        this.BotonMasDatos = new Lui.Forms.Button();
                        this.lblTitulo = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.PnlCuotas = new System.Windows.Forms.Panel();
                        this.EntradaIva = new Lui.Forms.TextBox();
                        this.EtiquetaIva = new System.Windows.Forms.Label();
                        this.PnlCuotas.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // ProductArray
                        // 
                        this.ProductArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ProductArray.AutoNav = true;
                        this.ProductArray.AutoScroll = true;
                        this.ProductArray.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.ProductArray.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ProductArray.FreeTextCode = "*";
                        this.ProductArray.Location = new System.Drawing.Point(0, 100);
                        this.ProductArray.LockPrice = false;
                        this.ProductArray.LockQuantity = false;
                        this.ProductArray.LockText = false;
                        this.ProductArray.MaxLength = 200;
                        this.ProductArray.Name = "ProductArray";
                        this.ProductArray.Padding = new System.Windows.Forms.Padding(2);
                        this.ProductArray.Precio = Lcc.Entrada.Articulos.Precios.Pvp;
                        this.ProductArray.ShowStock = true;
                        this.ProductArray.Size = new System.Drawing.Size(600, 208);
                        this.ProductArray.TabIndex = 20;
                        this.ProductArray.ToolTipText = "";
                        this.ProductArray.TotalChanged += new System.EventHandler(this.ProductArray_TotalChanged);
                        this.ProductArray.AskForSerials += new System.EventHandler(this.ProductArray_AskForSerials);
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(248, 44);
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
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.ExtraDetailFields = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(304, 44);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(232, 24);
                        this.EntradaCliente.TabIndex = 4;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TipWhenBlank = "";
                        this.EntradaCliente.ToolTipText = "";
                        this.EntradaCliente.TextChanged += new System.EventHandler(this.EntradaCliente_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(0, 44);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(72, 24);
                        this.Label1.TabIndex = 1;
                        this.Label1.Text = "Vendedor";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.AutoNav = true;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.ExtraDetailFields = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.Location = new System.Drawing.Point(72, 44);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.Required = true;
                        this.EntradaVendedor.Size = new System.Drawing.Size(168, 24);
                        this.EntradaVendedor.TabIndex = 2;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        this.EntradaVendedor.TipWhenBlank = "";
                        this.EntradaVendedor.ToolTipText = "";
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(456, 336);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(144, 32);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 41;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        this.EntradaTotal.TextChanged += new System.EventHandler(this.EntradaTotal_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(392, 336);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(64, 32);
                        this.Label4.TabIndex = 40;
                        this.Label4.Text = "Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label5.Location = new System.Drawing.Point(0, 312);
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
                        this.EntradaSubTotal.AutoTab = true;
                        this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaSubTotal.DecimalPlaces = -1;
                        this.EntradaSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaSubTotal.Location = new System.Drawing.Point(64, 312);
                        this.EntradaSubTotal.MaxLenght = 32767;
                        this.EntradaSubTotal.MultiLine = false;
                        this.EntradaSubTotal.Name = "EntradaSubTotal";
                        this.EntradaSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSubTotal.PasswordChar = '\0';
                        this.EntradaSubTotal.Prefijo = "$";
                        this.EntradaSubTotal.SelectOnFocus = true;
                        this.EntradaSubTotal.Size = new System.Drawing.Size(92, 24);
                        this.EntradaSubTotal.Sufijo = "";
                        this.EntradaSubTotal.TabIndex = 22;
                        this.EntradaSubTotal.TabStop = false;
                        this.EntradaSubTotal.Text = "0.00";
                        this.EntradaSubTotal.TipWhenBlank = "";
                        this.EntradaSubTotal.ToolTipText = "";
                        this.EntradaSubTotal.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // EntradaDescuento
                        // 
                        this.EntradaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaDescuento.AutoNav = true;
                        this.EntradaDescuento.AutoTab = true;
                        this.EntradaDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaDescuento.DecimalPlaces = -1;
                        this.EntradaDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescuento.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescuento.Location = new System.Drawing.Point(224, 312);
                        this.EntradaDescuento.MaxLenght = 32767;
                        this.EntradaDescuento.MultiLine = false;
                        this.EntradaDescuento.Name = "EntradaDescuento";
                        this.EntradaDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescuento.PasswordChar = '\0';
                        this.EntradaDescuento.Prefijo = "";
                        this.EntradaDescuento.SelectOnFocus = true;
                        this.EntradaDescuento.Size = new System.Drawing.Size(76, 24);
                        this.EntradaDescuento.Sufijo = "%";
                        this.EntradaDescuento.TabIndex = 24;
                        this.EntradaDescuento.Text = "0.0000";
                        this.EntradaDescuento.TipWhenBlank = "";
                        this.EntradaDescuento.ToolTipText = "";
                        this.EntradaDescuento.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.Location = new System.Drawing.Point(164, 312);
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
                        this.EntradaInteres.AutoTab = true;
                        this.EntradaInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaInteres.DecimalPlaces = -1;
                        this.EntradaInteres.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaInteres.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaInteres.Location = new System.Drawing.Point(224, 340);
                        this.EntradaInteres.MaxLenght = 32767;
                        this.EntradaInteres.MultiLine = false;
                        this.EntradaInteres.Name = "EntradaInteres";
                        this.EntradaInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaInteres.PasswordChar = '\0';
                        this.EntradaInteres.Prefijo = "";
                        this.EntradaInteres.SelectOnFocus = true;
                        this.EntradaInteres.Size = new System.Drawing.Size(76, 24);
                        this.EntradaInteres.Sufijo = "%";
                        this.EntradaInteres.TabIndex = 26;
                        this.EntradaInteres.Text = "0.0000";
                        this.EntradaInteres.TipWhenBlank = "";
                        this.EntradaInteres.ToolTipText = "";
                        this.EntradaInteres.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label7
                        // 
                        this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label7.Location = new System.Drawing.Point(164, 340);
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
                        this.EntradaCuotas.AutoTab = true;
                        this.EntradaCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCuotas.DecimalPlaces = -1;
                        this.EntradaCuotas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCuotas.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCuotas.Location = new System.Drawing.Point(52, 0);
                        this.EntradaCuotas.MaxLenght = 2;
                        this.EntradaCuotas.MultiLine = false;
                        this.EntradaCuotas.Name = "EntradaCuotas";
                        this.EntradaCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuotas.PasswordChar = '\0';
                        this.EntradaCuotas.Prefijo = "";
                        this.EntradaCuotas.SelectOnFocus = true;
                        this.EntradaCuotas.Size = new System.Drawing.Size(32, 24);
                        this.EntradaCuotas.Sufijo = "";
                        this.EntradaCuotas.TabIndex = 28;
                        this.EntradaCuotas.Text = "0";
                        this.EntradaCuotas.TipWhenBlank = "";
                        this.EntradaCuotas.ToolTipText = "";
                        this.EntradaCuotas.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
                        this.EntradaValorCuota.AutoTab = true;
                        this.EntradaValorCuota.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaValorCuota.DecimalPlaces = -1;
                        this.EntradaValorCuota.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaValorCuota.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaValorCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaValorCuota.Location = new System.Drawing.Point(108, 0);
                        this.EntradaValorCuota.MaxLenght = 32767;
                        this.EntradaValorCuota.MultiLine = false;
                        this.EntradaValorCuota.Name = "EntradaValorCuota";
                        this.EntradaValorCuota.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaValorCuota.PasswordChar = '\0';
                        this.EntradaValorCuota.Prefijo = "$";
                        this.EntradaValorCuota.SelectOnFocus = true;
                        this.EntradaValorCuota.Size = new System.Drawing.Size(80, 24);
                        this.EntradaValorCuota.Sufijo = "";
                        this.EntradaValorCuota.TabIndex = 30;
                        this.EntradaValorCuota.TabStop = false;
                        this.EntradaValorCuota.Text = "0.00";
                        this.EntradaValorCuota.TipWhenBlank = "";
                        this.EntradaValorCuota.ToolTipText = "";
                        // 
                        // Label9
                        // 
                        this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label9.Location = new System.Drawing.Point(84, 0);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(24, 24);
                        this.Label9.TabIndex = 29;
                        this.Label9.Text = "de";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // BotonObs
                        // 
                        this.BotonObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonObs.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonObs.Image = null;
                        this.BotonObs.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonObs.Location = new System.Drawing.Point(224, 372);
                        this.BotonObs.Name = "BotonObs";
                        this.BotonObs.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonObs.Size = new System.Drawing.Size(108, 28);
                        this.BotonObs.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonObs.Subtext = "F7";
                        this.BotonObs.TabIndex = 52;
                        this.BotonObs.Text = "Observac.";
                        this.BotonObs.ToolTipText = "";
                        this.BotonObs.Click += new System.EventHandler(this.BotonObs_Click);
                        // 
                        // BotonConvertir
                        // 
                        this.BotonConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonConvertir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonConvertir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonConvertir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonConvertir.Image = null;
                        this.BotonConvertir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonConvertir.Location = new System.Drawing.Point(0, 372);
                        this.BotonConvertir.Name = "BotonConvertir";
                        this.BotonConvertir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonConvertir.Size = new System.Drawing.Size(108, 28);
                        this.BotonConvertir.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonConvertir.Subtext = "F4";
                        this.BotonConvertir.TabIndex = 50;
                        this.BotonConvertir.Text = "Convertir";
                        this.BotonConvertir.ToolTipText = "";
                        this.BotonConvertir.Click += new System.EventHandler(this.BotonConvertir_Click);
                        // 
                        // EntradaComprobanteId
                        // 
                        this.EntradaComprobanteId.Location = new System.Drawing.Point(8, 373);
                        this.EntradaComprobanteId.Name = "EntradaComprobanteId";
                        this.EntradaComprobanteId.Size = new System.Drawing.Size(28, 23);
                        this.EntradaComprobanteId.TabIndex = 52;
                        this.EntradaComprobanteId.Visible = false;
                        // 
                        // BotonMasDatos
                        // 
                        this.BotonMasDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonMasDatos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonMasDatos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonMasDatos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonMasDatos.Image = null;
                        this.BotonMasDatos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonMasDatos.Location = new System.Drawing.Point(112, 372);
                        this.BotonMasDatos.Name = "BotonMasDatos";
                        this.BotonMasDatos.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonMasDatos.Size = new System.Drawing.Size(108, 28);
                        this.BotonMasDatos.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonMasDatos.Subtext = "F5";
                        this.BotonMasDatos.TabIndex = 51;
                        this.BotonMasDatos.Text = "Más Datos";
                        this.BotonMasDatos.ToolTipText = "";
                        this.BotonMasDatos.Click += new System.EventHandler(this.BotonMasDatos_Click);
                        // 
                        // lblTitulo
                        // 
                        this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.lblTitulo.Location = new System.Drawing.Point(0, 0);
                        this.lblTitulo.Name = "lblTitulo";
                        this.lblTitulo.Size = new System.Drawing.Size(600, 36);
                        this.lblTitulo.TabIndex = 0;
                        this.lblTitulo.Text = "Comprobante";
                        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(544, 44);
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
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(568, 44);
                        this.EntradaPV.MaxLenght = 2;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(32, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 6;
                        this.EntradaPV.Text = "0";
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        // 
                        // PnlCuotas
                        // 
                        this.PnlCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PnlCuotas.Controls.Add(this.Label8);
                        this.PnlCuotas.Controls.Add(this.EntradaCuotas);
                        this.PnlCuotas.Controls.Add(this.Label9);
                        this.PnlCuotas.Controls.Add(this.EntradaValorCuota);
                        this.PnlCuotas.Location = new System.Drawing.Point(308, 312);
                        this.PnlCuotas.Name = "PnlCuotas";
                        this.PnlCuotas.Size = new System.Drawing.Size(188, 24);
                        this.PnlCuotas.TabIndex = 27;
                        // 
                        // EntradaIva
                        // 
                        this.EntradaIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaIva.AutoNav = true;
                        this.EntradaIva.AutoTab = true;
                        this.EntradaIva.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaIva.DecimalPlaces = -1;
                        this.EntradaIva.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaIva.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaIva.Location = new System.Drawing.Point(64, 340);
                        this.EntradaIva.MaxLenght = 32767;
                        this.EntradaIva.MultiLine = false;
                        this.EntradaIva.Name = "EntradaIva";
                        this.EntradaIva.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaIva.PasswordChar = '\0';
                        this.EntradaIva.Prefijo = "$";
                        this.EntradaIva.SelectOnFocus = true;
                        this.EntradaIva.Size = new System.Drawing.Size(92, 24);
                        this.EntradaIva.Sufijo = "";
                        this.EntradaIva.TabIndex = 54;
                        this.EntradaIva.TabStop = false;
                        this.EntradaIva.Text = "0.00";
                        this.EntradaIva.TipWhenBlank = "";
                        this.EntradaIva.ToolTipText = "";
                        this.EntradaIva.Visible = false;
                        // 
                        // EtiquetaIva
                        // 
                        this.EtiquetaIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaIva.Location = new System.Drawing.Point(0, 340);
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
                        this.Controls.Add(this.BotonObs);
                        this.Controls.Add(this.BotonMasDatos);
                        this.Controls.Add(this.BotonConvertir);
                        this.Controls.Add(this.PnlCuotas);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.lblTitulo);
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
                        this.Controls.Add(this.ProductArray);
                        this.MinimumSize = new System.Drawing.Size(600, 400);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(600, 400);
                        this.Controls.SetChildIndex(this.ProductArray, 0);
                        this.Controls.SetChildIndex(this.EntradaVendedor, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaSubTotal, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.EntradaDescuento, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaInteres, 0);
                        this.Controls.SetChildIndex(this.EntradaComprobanteId, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.lblTitulo, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaPV, 0);
                        this.Controls.SetChildIndex(this.PnlCuotas, 0);
                        this.Controls.SetChildIndex(this.BotonConvertir, 0);
                        this.Controls.SetChildIndex(this.BotonMasDatos, 0);
                        this.Controls.SetChildIndex(this.BotonObs, 0);
                        this.Controls.SetChildIndex(this.EtiquetaIva, 0);
                        this.Controls.SetChildIndex(this.EntradaIva, 0);
                        this.PnlCuotas.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                public Lcc.Entrada.Articulos.MatrizDetalleComprobante ProductArray;
                internal System.Windows.Forms.Label Label3;
                public Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal System.Windows.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                internal Lui.Forms.TextBox EntradaTotal;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaSubTotal;
                internal Lui.Forms.TextBox EntradaDescuento;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.TextBox EntradaInteres;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaCuotas;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.TextBox EntradaValorCuota;
                internal System.Windows.Forms.Label Label9;
                internal Lui.Forms.Button BotonObs;
                internal Lui.Forms.Button BotonConvertir;
                internal System.Windows.Forms.TextBox EntradaComprobanteId;
                internal Lui.Forms.Button BotonMasDatos;
                internal System.Windows.Forms.Label lblTitulo;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaPV;
                private System.Windows.Forms.Panel PnlCuotas;
                internal Lui.Forms.TextBox EntradaIva;
                internal System.Windows.Forms.Label EtiquetaIva;
        }
}