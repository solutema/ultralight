#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
                public Editar()
                        : base()
                {
                        InitializeComponent();

                        this.ElementType = typeof(Lbl.Comprobantes.ComprobanteConArticulos);
                        lblTitulo.Font = Lfx.Config.Display.CurrentTemplate.DefaultHeaderFont;
                        lblTitulo.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        lblTitulo.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;
                }

                private void InitializeComponent()
                {
                        this.ProductArray = new Lui.Forms.ProductArray();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaCliente = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaVendedor = new Lui.Forms.DetailBox();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtSubTotal = new Lui.Forms.TextBox();
                        this.EntradaDescuento = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EntradaInteres = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtCuotas = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.txtValorCuota = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.PrintButton = new Lui.Forms.Button();
                        this.BotonObs = new Lui.Forms.Button();
                        this.BotonConvertir = new Lui.Forms.Button();
                        this.txtComprobanteID = new System.Windows.Forms.TextBox();
                        this.BotonMasDatos = new Lui.Forms.Button();
                        this.lblTitulo = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtPV = new Lui.Forms.TextBox();
                        this.PnlCuotas = new System.Windows.Forms.Panel();
                        this.PnlCuotas.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(476, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(584, 8);
                        // 
                        // ProductArray
                        // 
                        this.ProductArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ProductArray.AutoAgregar = false;
                        this.ProductArray.AutoScroll = true;
                        this.ProductArray.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.ProductArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.ProductArray.Changed = false;
                        this.ProductArray.Count = 0;
                        this.ProductArray.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ProductArray.FreeTextCode = "*";
                        this.ProductArray.Location = new System.Drawing.Point(8, 108);
                        this.ProductArray.LockPrice = false;
                        this.ProductArray.LockQuantity = false;
                        this.ProductArray.LockText = false;
                        this.ProductArray.MaxLength = 200;
                        this.ProductArray.Name = "ProductArray";
                        this.ProductArray.Precio = Lui.Forms.Product.Precios.PVP;
                        this.ProductArray.ShowStock = true;
                        this.ProductArray.Size = new System.Drawing.Size(676, 240);
                        this.ProductArray.TabIndex = 20;
                        this.ProductArray.TotalChanged += new System.EventHandler(this.ProductArray_TotalChanged);
                        this.ProductArray.AskForSerials += new System.EventHandler(this.ProductArray_AskForSerials);
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(300, 52);
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
                        this.EntradaCliente.AutoHeight = false;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DetailField = "nombre_visible";
                        this.EntradaCliente.ExtraDetailFields = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.KeyField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(356, 52);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.ReadOnly = false;
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.SelectOnFocus = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(264, 24);
                        this.EntradaCliente.TabIndex = 4;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TextInt = 0;
                        this.EntradaCliente.TipWhenBlank = "";
                        this.EntradaCliente.ToolTipText = "";
                        this.EntradaCliente.TextChanged += new System.EventHandler(this.EntradaCliente_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(8, 52);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(72, 24);
                        this.Label1.TabIndex = 1;
                        this.Label1.Text = "Vendedor";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.AutoHeight = false;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DetailField = "nombre_visible";
                        this.EntradaVendedor.ExtraDetailFields = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.KeyField = "id_persona";
                        this.EntradaVendedor.Location = new System.Drawing.Point(80, 52);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.ReadOnly = false;
                        this.EntradaVendedor.Required = true;
                        this.EntradaVendedor.SelectOnFocus = true;
                        this.EntradaVendedor.Size = new System.Drawing.Size(212, 24);
                        this.EntradaVendedor.TabIndex = 2;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        this.EntradaVendedor.TextInt = 0;
                        this.EntradaVendedor.TipWhenBlank = "";
                        this.EntradaVendedor.ToolTipText = "";
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTotal.AutoHeight = false;
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(540, 376);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = false;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(144, 32);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 41;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TextRaw = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        this.EntradaTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(476, 376);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(64, 32);
                        this.Label4.TabIndex = 40;
                        this.Label4.Text = "Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label5.Location = new System.Drawing.Point(8, 356);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(64, 24);
                        this.Label5.TabIndex = 21;
                        this.Label5.Text = "Subtotal";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSubTotal
                        // 
                        this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtSubTotal.AutoHeight = false;
                        this.txtSubTotal.AutoNav = true;
                        this.txtSubTotal.AutoTab = true;
                        this.txtSubTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtSubTotal.DecimalPlaces = -1;
                        this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSubTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtSubTotal.Location = new System.Drawing.Point(72, 356);
                        this.txtSubTotal.MaxLenght = 32767;
                        this.txtSubTotal.MultiLine = false;
                        this.txtSubTotal.Name = "txtSubTotal";
                        this.txtSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSubTotal.PasswordChar = '\0';
                        this.txtSubTotal.Prefijo = "$";
                        this.txtSubTotal.ReadOnly = true;
                        this.txtSubTotal.SelectOnFocus = true;
                        this.txtSubTotal.Size = new System.Drawing.Size(92, 24);
                        this.txtSubTotal.Sufijo = "";
                        this.txtSubTotal.TabIndex = 22;
                        this.txtSubTotal.TabStop = false;
                        this.txtSubTotal.Text = "0.00";
                        this.txtSubTotal.TextRaw = "0.00";
                        this.txtSubTotal.TipWhenBlank = "";
                        this.txtSubTotal.ToolTipText = "";
                        this.txtSubTotal.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // txtDescuento
                        // 
                        this.EntradaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaDescuento.AutoHeight = false;
                        this.EntradaDescuento.AutoNav = true;
                        this.EntradaDescuento.AutoTab = true;
                        this.EntradaDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaDescuento.DecimalPlaces = -1;
                        this.EntradaDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDescuento.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescuento.Location = new System.Drawing.Point(232, 356);
                        this.EntradaDescuento.MaxLenght = 32767;
                        this.EntradaDescuento.MultiLine = false;
                        this.EntradaDescuento.Name = "txtDescuento";
                        this.EntradaDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescuento.PasswordChar = '\0';
                        this.EntradaDescuento.Prefijo = "";
                        this.EntradaDescuento.ReadOnly = false;
                        this.EntradaDescuento.SelectOnFocus = true;
                        this.EntradaDescuento.Size = new System.Drawing.Size(76, 24);
                        this.EntradaDescuento.Sufijo = "%";
                        this.EntradaDescuento.TabIndex = 24;
                        this.EntradaDescuento.Text = "0.00";
                        this.EntradaDescuento.TextRaw = "0.00";
                        this.EntradaDescuento.TipWhenBlank = "";
                        this.EntradaDescuento.ToolTipText = "";
                        this.EntradaDescuento.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.Location = new System.Drawing.Point(172, 356);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(60, 24);
                        this.Label6.TabIndex = 23;
                        this.Label6.Text = "Descto.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtInteres
                        // 
                        this.EntradaInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaInteres.AutoHeight = false;
                        this.EntradaInteres.AutoNav = true;
                        this.EntradaInteres.AutoTab = true;
                        this.EntradaInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaInteres.DecimalPlaces = -1;
                        this.EntradaInteres.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaInteres.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaInteres.Location = new System.Drawing.Point(232, 384);
                        this.EntradaInteres.MaxLenght = 32767;
                        this.EntradaInteres.MultiLine = false;
                        this.EntradaInteres.Name = "txtInteres";
                        this.EntradaInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaInteres.PasswordChar = '\0';
                        this.EntradaInteres.Prefijo = "";
                        this.EntradaInteres.ReadOnly = false;
                        this.EntradaInteres.SelectOnFocus = true;
                        this.EntradaInteres.Size = new System.Drawing.Size(76, 24);
                        this.EntradaInteres.Sufijo = "%";
                        this.EntradaInteres.TabIndex = 26;
                        this.EntradaInteres.Text = "0.00";
                        this.EntradaInteres.TextRaw = "0.00";
                        this.EntradaInteres.TipWhenBlank = "";
                        this.EntradaInteres.ToolTipText = "";
                        this.EntradaInteres.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // Label7
                        // 
                        this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label7.Location = new System.Drawing.Point(172, 384);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(60, 24);
                        this.Label7.TabIndex = 25;
                        this.Label7.Text = "Recargo";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCuotas
                        // 
                        this.txtCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtCuotas.AutoHeight = false;
                        this.txtCuotas.AutoNav = true;
                        this.txtCuotas.AutoTab = true;
                        this.txtCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCuotas.DecimalPlaces = -1;
                        this.txtCuotas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCuotas.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCuotas.Location = new System.Drawing.Point(52, 0);
                        this.txtCuotas.MaxLenght = 2;
                        this.txtCuotas.MultiLine = false;
                        this.txtCuotas.Name = "txtCuotas";
                        this.txtCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCuotas.PasswordChar = '\0';
                        this.txtCuotas.Prefijo = "";
                        this.txtCuotas.ReadOnly = false;
                        this.txtCuotas.SelectOnFocus = true;
                        this.txtCuotas.Size = new System.Drawing.Size(32, 24);
                        this.txtCuotas.Sufijo = "";
                        this.txtCuotas.TabIndex = 28;
                        this.txtCuotas.Text = "0";
                        this.txtCuotas.TextRaw = "0";
                        this.txtCuotas.TipWhenBlank = "";
                        this.txtCuotas.ToolTipText = "";
                        this.txtCuotas.TextChanged += new System.EventHandler(this.CambioValores);
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
                        // txtValorCuota
                        // 
                        this.txtValorCuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtValorCuota.AutoHeight = false;
                        this.txtValorCuota.AutoNav = true;
                        this.txtValorCuota.AutoTab = true;
                        this.txtValorCuota.DataType = Lui.Forms.DataTypes.Money;
                        this.txtValorCuota.DecimalPlaces = -1;
                        this.txtValorCuota.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtValorCuota.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtValorCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtValorCuota.Location = new System.Drawing.Point(108, 0);
                        this.txtValorCuota.MaxLenght = 32767;
                        this.txtValorCuota.MultiLine = false;
                        this.txtValorCuota.Name = "txtValorCuota";
                        this.txtValorCuota.Padding = new System.Windows.Forms.Padding(2);
                        this.txtValorCuota.PasswordChar = '\0';
                        this.txtValorCuota.Prefijo = "$";
                        this.txtValorCuota.ReadOnly = true;
                        this.txtValorCuota.SelectOnFocus = true;
                        this.txtValorCuota.Size = new System.Drawing.Size(80, 24);
                        this.txtValorCuota.Sufijo = "";
                        this.txtValorCuota.TabIndex = 30;
                        this.txtValorCuota.TabStop = false;
                        this.txtValorCuota.Text = "0.00";
                        this.txtValorCuota.TextRaw = "0.00";
                        this.txtValorCuota.TipWhenBlank = "";
                        this.txtValorCuota.ToolTipText = "";
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
                        // PrintButton
                        // 
                        this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PrintButton.AutoHeight = false;
                        this.PrintButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.PrintButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PrintButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.PrintButton.Image = null;
                        this.PrintButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.PrintButton.Location = new System.Drawing.Point(308, 420);
                        this.PrintButton.Name = "PrintButton";
                        this.PrintButton.Padding = new System.Windows.Forms.Padding(2);
                        this.PrintButton.ReadOnly = false;
                        this.PrintButton.Size = new System.Drawing.Size(96, 44);
                        this.PrintButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.PrintButton.Subtext = "F8";
                        this.PrintButton.TabIndex = 53;
                        this.PrintButton.Text = "Imprimir";
                        this.PrintButton.ToolTipText = "";
                        this.PrintButton.Click += new System.EventHandler(this.BotonImprimir_Click);
                        // 
                        // BotonObs
                        // 
                        this.BotonObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonObs.AutoHeight = false;
                        this.BotonObs.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonObs.Image = null;
                        this.BotonObs.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonObs.Location = new System.Drawing.Point(208, 420);
                        this.BotonObs.Name = "BotonObs";
                        this.BotonObs.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonObs.ReadOnly = false;
                        this.BotonObs.Size = new System.Drawing.Size(96, 44);
                        this.BotonObs.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonObs.Subtext = "F7";
                        this.BotonObs.TabIndex = 52;
                        this.BotonObs.Text = "Observac.";
                        this.BotonObs.ToolTipText = "";
                        this.BotonObs.Click += new System.EventHandler(this.BotonObs_Click);
                        // 
                        // BotonConvertir
                        // 
                        this.BotonConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonConvertir.AutoHeight = false;
                        this.BotonConvertir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonConvertir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonConvertir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonConvertir.Image = null;
                        this.BotonConvertir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonConvertir.Location = new System.Drawing.Point(8, 420);
                        this.BotonConvertir.Name = "BotonConvertir";
                        this.BotonConvertir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonConvertir.ReadOnly = false;
                        this.BotonConvertir.Size = new System.Drawing.Size(96, 44);
                        this.BotonConvertir.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonConvertir.Subtext = "F4";
                        this.BotonConvertir.TabIndex = 50;
                        this.BotonConvertir.Text = "Convertir";
                        this.BotonConvertir.ToolTipText = "";
                        this.BotonConvertir.Click += new System.EventHandler(this.BotonConvertir_Click);
                        // 
                        // txtComprobanteID
                        // 
                        this.txtComprobanteID.Location = new System.Drawing.Point(0, 12);
                        this.txtComprobanteID.Name = "txtComprobanteID";
                        this.txtComprobanteID.Size = new System.Drawing.Size(28, 23);
                        this.txtComprobanteID.TabIndex = 52;
                        this.txtComprobanteID.Visible = false;
                        // 
                        // BotonMasDatos
                        // 
                        this.BotonMasDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonMasDatos.AutoHeight = false;
                        this.BotonMasDatos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonMasDatos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonMasDatos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonMasDatos.Image = null;
                        this.BotonMasDatos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonMasDatos.Location = new System.Drawing.Point(108, 420);
                        this.BotonMasDatos.Name = "BotonMasDatos";
                        this.BotonMasDatos.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonMasDatos.ReadOnly = false;
                        this.BotonMasDatos.Size = new System.Drawing.Size(96, 44);
                        this.BotonMasDatos.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
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
                        this.lblTitulo.Location = new System.Drawing.Point(8, 8);
                        this.lblTitulo.Name = "lblTitulo";
                        this.lblTitulo.Size = new System.Drawing.Size(676, 36);
                        this.lblTitulo.TabIndex = 0;
                        this.lblTitulo.Text = "Comprobante";
                        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(628, 52);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(24, 24);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "PV";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPV
                        // 
                        this.txtPV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPV.AutoHeight = false;
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPV.DecimalPlaces = -1;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPV.Location = new System.Drawing.Point(652, 52);
                        this.txtPV.MaxLenght = 2;
                        this.txtPV.MultiLine = false;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPV.PasswordChar = '\0';
                        this.txtPV.Prefijo = "";
                        this.txtPV.ReadOnly = false;
                        this.txtPV.SelectOnFocus = true;
                        this.txtPV.Size = new System.Drawing.Size(32, 24);
                        this.txtPV.Sufijo = "";
                        this.txtPV.TabIndex = 6;
                        this.txtPV.Text = "0";
                        this.txtPV.TextRaw = "0";
                        this.txtPV.TipWhenBlank = "";
                        this.txtPV.ToolTipText = "";
                        // 
                        // PnlCuotas
                        // 
                        this.PnlCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PnlCuotas.Controls.Add(this.Label8);
                        this.PnlCuotas.Controls.Add(this.txtCuotas);
                        this.PnlCuotas.Controls.Add(this.Label9);
                        this.PnlCuotas.Controls.Add(this.txtValorCuota);
                        this.PnlCuotas.Location = new System.Drawing.Point(316, 356);
                        this.PnlCuotas.Name = "PnlCuotas";
                        this.PnlCuotas.Size = new System.Drawing.Size(188, 24);
                        this.PnlCuotas.TabIndex = 27;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.PrintButton);
                        this.Controls.Add(this.BotonObs);
                        this.Controls.Add(this.BotonMasDatos);
                        this.Controls.Add(this.BotonConvertir);
                        this.Controls.Add(this.PnlCuotas);
                        this.Controls.Add(this.txtPV);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.lblTitulo);
                        this.Controls.Add(this.EntradaCliente);
                        this.Controls.Add(this.txtComprobanteID);
                        this.Controls.Add(this.EntradaInteres);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaDescuento);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtSubTotal);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaVendedor);
                        this.Controls.Add(this.ProductArray);
                        this.Name = "Editar";
                        this.Text = "Comprobante";
                        this.WorkspaceChanged += new System.EventHandler(this.FormComprobanteEditar_WorkspaceChanged);
                        this.Load += new System.EventHandler(this.FormComprobanteEditar_Load);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormComprobanteEditar_KeyDown);
                        this.Controls.SetChildIndex(this.ProductArray, 0);
                        this.Controls.SetChildIndex(this.EntradaVendedor, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtSubTotal, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.EntradaDescuento, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaInteres, 0);
                        this.Controls.SetChildIndex(this.txtComprobanteID, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.lblTitulo, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.txtPV, 0);
                        this.Controls.SetChildIndex(this.PnlCuotas, 0);
                        this.Controls.SetChildIndex(this.BotonConvertir, 0);
                        this.Controls.SetChildIndex(this.BotonMasDatos, 0);
                        this.Controls.SetChildIndex(this.BotonObs, 0);
                        this.Controls.SetChildIndex(this.PrintButton, 0);
                        this.PnlCuotas.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                public Lui.Forms.ProductArray ProductArray;
                internal System.Windows.Forms.Label Label3;
                public Lui.Forms.DetailBox EntradaCliente;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox EntradaVendedor;
                internal Lui.Forms.TextBox EntradaTotal;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox txtSubTotal;
                internal Lui.Forms.TextBox EntradaDescuento;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.TextBox EntradaInteres;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox txtCuotas;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.TextBox txtValorCuota;
                internal System.Windows.Forms.Label Label9;
                internal Lui.Forms.Button PrintButton;
                internal Lui.Forms.Button BotonObs;
                internal Lui.Forms.Button BotonConvertir;
                internal System.Windows.Forms.TextBox txtComprobanteID;
                internal Lui.Forms.Button BotonMasDatos;
                internal System.Windows.Forms.Label lblTitulo;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox txtPV;

                #endregion
                private System.Windows.Forms.Panel PnlCuotas;
        }
}