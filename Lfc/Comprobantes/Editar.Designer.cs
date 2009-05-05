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

namespace Lfc.Comprobantes
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms
                public Editar()
                        : base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        lblTitulo.Font = Lws.Config.Display.CurrentTemplate.DefaultHeaderFont;
                        lblTitulo.BackColor = Lws.Config.Display.CurrentTemplate.HeaderBackground;
                        lblTitulo.ForeColor = Lws.Config.Display.CurrentTemplate.HeaderText;
                }

                private void InitializeComponent()
                {
                        this.ProductArray = new Lui.Forms.ProductArray();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtVendedor = new Lui.Forms.DetailBox();
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtSubTotal = new Lui.Forms.TextBox();
                        this.txtDescuento = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.txtInteres = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtCuotas = new Lui.Forms.TextBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.txtValorCuota = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.PrintButton = new Lui.Forms.Button();
                        this.cmdObs = new Lui.Forms.Button();
                        this.cmdConvertir = new Lui.Forms.Button();
                        this.txtComprobanteID = new System.Windows.Forms.TextBox();
                        this.cmdMasDatos = new Lui.Forms.Button();
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
                        this.ProductArray.Workspace = null;
                        this.ProductArray.TotalChanged += new System.EventHandler(this.ProductArray_TotalChanged);
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
                        // txtCliente
                        // 
                        this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.CanCreate = true;
                        this.txtCliente.DetailField = "nombre_visible";
                        this.txtCliente.ExtraDetailFields = null;
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCliente.FreeTextCode = "";
                        this.txtCliente.KeyField = "id_persona";
                        this.txtCliente.Location = new System.Drawing.Point(356, 52);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = true;
                        this.txtCliente.Size = new System.Drawing.Size(264, 24);
                        this.txtCliente.TabIndex = 4;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
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
                        // txtVendedor
                        // 
                        this.txtVendedor.AutoTab = true;
                        this.txtVendedor.CanCreate = true;
                        this.txtVendedor.DetailField = "nombre_visible";
                        this.txtVendedor.ExtraDetailFields = null;
                        this.txtVendedor.Filter = "(tipo&4)=4";
                        this.txtVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtVendedor.FreeTextCode = "";
                        this.txtVendedor.KeyField = "id_persona";
                        this.txtVendedor.Location = new System.Drawing.Point(80, 52);
                        this.txtVendedor.MaxLength = 200;
                        this.txtVendedor.Name = "txtVendedor";
                        this.txtVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtVendedor.ReadOnly = false;
                        this.txtVendedor.Required = true;
                        this.txtVendedor.Size = new System.Drawing.Size(212, 24);
                        this.txtVendedor.TabIndex = 2;
                        this.txtVendedor.Table = "personas";
                        this.txtVendedor.TeclaDespuesDeEnter = "{tab}";
                        this.txtVendedor.Text = "0";
                        this.txtVendedor.TextDetail = "";
                        this.txtVendedor.TextInt = 0;
                        this.txtVendedor.TipWhenBlank = "";
                        this.txtVendedor.ToolTipText = "";
                        // 
                        // txtTotal
                        // 
                        this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTotal.Location = new System.Drawing.Point(540, 376);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "txtTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.Prefijo = "$";
                        this.txtTotal.ReadOnly = false;
                        this.txtTotal.Size = new System.Drawing.Size(144, 32);
                        this.txtTotal.TabIndex = 41;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
                        this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
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
                        this.txtSubTotal.AutoNav = true;
                        this.txtSubTotal.AutoTab = true;
                        this.txtSubTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtSubTotal.Location = new System.Drawing.Point(72, 356);
                        this.txtSubTotal.MaxLenght = 32767;
                        this.txtSubTotal.Name = "txtSubTotal";
                        this.txtSubTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSubTotal.Prefijo = "$";
                        this.txtSubTotal.ReadOnly = true;
                        this.txtSubTotal.Size = new System.Drawing.Size(92, 24);
                        this.txtSubTotal.TabIndex = 22;
                        this.txtSubTotal.TabStop = false;
                        this.txtSubTotal.Text = "0.00";
                        this.txtSubTotal.TipWhenBlank = "";
                        this.txtSubTotal.ToolTipText = "";
                        this.txtSubTotal.TextChanged += new System.EventHandler(this.CambioValores);
                        // 
                        // txtDescuento
                        // 
                        this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtDescuento.AutoNav = true;
                        this.txtDescuento.AutoTab = true;
                        this.txtDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.txtDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDescuento.Location = new System.Drawing.Point(232, 356);
                        this.txtDescuento.MaxLenght = 32767;
                        this.txtDescuento.Name = "txtDescuento";
                        this.txtDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescuento.ReadOnly = false;
                        this.txtDescuento.Size = new System.Drawing.Size(76, 24);
                        this.txtDescuento.Sufijo = "%";
                        this.txtDescuento.TabIndex = 24;
                        this.txtDescuento.Text = "0.00";
                        this.txtDescuento.TipWhenBlank = "";
                        this.txtDescuento.ToolTipText = "";
                        this.txtDescuento.TextChanged += new System.EventHandler(this.CambioValores);
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
                        this.txtInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtInteres.AutoNav = true;
                        this.txtInteres.AutoTab = true;
                        this.txtInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.txtInteres.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtInteres.Location = new System.Drawing.Point(232, 384);
                        this.txtInteres.MaxLenght = 32767;
                        this.txtInteres.Name = "txtInteres";
                        this.txtInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.txtInteres.ReadOnly = false;
                        this.txtInteres.Size = new System.Drawing.Size(76, 24);
                        this.txtInteres.Sufijo = "%";
                        this.txtInteres.TabIndex = 26;
                        this.txtInteres.Text = "0.00";
                        this.txtInteres.TipWhenBlank = "";
                        this.txtInteres.ToolTipText = "";
                        this.txtInteres.TextChanged += new System.EventHandler(this.CambioValores);
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
                        this.txtCuotas.AutoNav = true;
                        this.txtCuotas.AutoTab = true;
                        this.txtCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCuotas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCuotas.Location = new System.Drawing.Point(52, 0);
                        this.txtCuotas.MaxLenght = 2;
                        this.txtCuotas.Name = "txtCuotas";
                        this.txtCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCuotas.ReadOnly = false;
                        this.txtCuotas.Size = new System.Drawing.Size(32, 24);
                        this.txtCuotas.TabIndex = 28;
                        this.txtCuotas.Text = "0";
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
                        this.txtValorCuota.AutoNav = true;
                        this.txtValorCuota.AutoTab = true;
                        this.txtValorCuota.DataType = Lui.Forms.DataTypes.Money;
                        this.txtValorCuota.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtValorCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtValorCuota.Location = new System.Drawing.Point(108, 0);
                        this.txtValorCuota.MaxLenght = 32767;
                        this.txtValorCuota.Name = "txtValorCuota";
                        this.txtValorCuota.Padding = new System.Windows.Forms.Padding(2);
                        this.txtValorCuota.Prefijo = "$";
                        this.txtValorCuota.ReadOnly = true;
                        this.txtValorCuota.Size = new System.Drawing.Size(80, 24);
                        this.txtValorCuota.TabIndex = 30;
                        this.txtValorCuota.TabStop = false;
                        this.txtValorCuota.Text = "0.00";
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
                        this.PrintButton.Click += new System.EventHandler(this.cmdImprimir_Click);
                        // 
                        // cmdObs
                        // 
                        this.cmdObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdObs.Image = null;
                        this.cmdObs.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdObs.Location = new System.Drawing.Point(208, 420);
                        this.cmdObs.Name = "cmdObs";
                        this.cmdObs.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdObs.ReadOnly = false;
                        this.cmdObs.Size = new System.Drawing.Size(96, 44);
                        this.cmdObs.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdObs.Subtext = "F7";
                        this.cmdObs.TabIndex = 52;
                        this.cmdObs.Text = "Observac.";
                        this.cmdObs.ToolTipText = "";
                        this.cmdObs.Click += new System.EventHandler(this.cmdObs_Click);
                        // 
                        // cmdConvertir
                        // 
                        this.cmdConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdConvertir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdConvertir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdConvertir.Image = null;
                        this.cmdConvertir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdConvertir.Location = new System.Drawing.Point(8, 420);
                        this.cmdConvertir.Name = "cmdConvertir";
                        this.cmdConvertir.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdConvertir.ReadOnly = false;
                        this.cmdConvertir.Size = new System.Drawing.Size(96, 44);
                        this.cmdConvertir.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdConvertir.Subtext = "F4";
                        this.cmdConvertir.TabIndex = 50;
                        this.cmdConvertir.Text = "Convertir";
                        this.cmdConvertir.ToolTipText = "";
                        this.cmdConvertir.Click += new System.EventHandler(this.cmdConvertir_Click);
                        // 
                        // txtComprobanteID
                        // 
                        this.txtComprobanteID.Location = new System.Drawing.Point(0, 12);
                        this.txtComprobanteID.Name = "txtComprobanteID";
                        this.txtComprobanteID.Size = new System.Drawing.Size(28, 23);
                        this.txtComprobanteID.TabIndex = 52;
                        this.txtComprobanteID.Visible = false;
                        // 
                        // cmdMasDatos
                        // 
                        this.cmdMasDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdMasDatos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdMasDatos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdMasDatos.Image = null;
                        this.cmdMasDatos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdMasDatos.Location = new System.Drawing.Point(108, 420);
                        this.cmdMasDatos.Name = "cmdMasDatos";
                        this.cmdMasDatos.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdMasDatos.ReadOnly = false;
                        this.cmdMasDatos.Size = new System.Drawing.Size(96, 44);
                        this.cmdMasDatos.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdMasDatos.Subtext = "F5";
                        this.cmdMasDatos.TabIndex = 51;
                        this.cmdMasDatos.Text = "Más Datos";
                        this.cmdMasDatos.ToolTipText = "";
                        this.cmdMasDatos.Click += new System.EventHandler(this.cmdMasDatos_Click);
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
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPV.Location = new System.Drawing.Point(652, 52);
                        this.txtPV.MaxLenght = 2;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPV.ReadOnly = false;
                        this.txtPV.Size = new System.Drawing.Size(32, 24);
                        this.txtPV.TabIndex = 6;
                        this.txtPV.Text = "0";
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
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.PnlCuotas);
                        this.Controls.Add(this.txtPV);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.lblTitulo);
                        this.Controls.Add(this.cmdMasDatos);
                        this.Controls.Add(this.txtCliente);
                        this.Controls.Add(this.txtComprobanteID);
                        this.Controls.Add(this.cmdConvertir);
                        this.Controls.Add(this.cmdObs);
                        this.Controls.Add(this.PrintButton);
                        this.Controls.Add(this.txtInteres);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.txtDescuento);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtSubTotal);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtVendedor);
                        this.Controls.Add(this.ProductArray);
                        this.Name = "Editar";
                        this.Text = "Comprobante";
                        this.Load += new System.EventHandler(this.FormComprobanteEditar_Load);
                        this.WorkspaceChanged += new System.EventHandler(this.FormComprobanteEditar_WorkspaceChanged);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormComprobanteEditar_KeyDown);
                        this.Controls.SetChildIndex(this.ProductArray, 0);
                        this.Controls.SetChildIndex(this.txtVendedor, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.txtTotal, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtSubTotal, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.txtDescuento, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.txtInteres, 0);
                        this.Controls.SetChildIndex(this.PrintButton, 0);
                        this.Controls.SetChildIndex(this.cmdObs, 0);
                        this.Controls.SetChildIndex(this.cmdConvertir, 0);
                        this.Controls.SetChildIndex(this.txtComprobanteID, 0);
                        this.Controls.SetChildIndex(this.txtCliente, 0);
                        this.Controls.SetChildIndex(this.cmdMasDatos, 0);
                        this.Controls.SetChildIndex(this.lblTitulo, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.txtPV, 0);
                        this.Controls.SetChildIndex(this.PnlCuotas, 0);
                        this.PnlCuotas.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                public Lui.Forms.ProductArray ProductArray;
                internal System.Windows.Forms.Label Label3;
                public Lui.Forms.DetailBox txtCliente;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox txtVendedor;
                internal Lui.Forms.TextBox txtTotal;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.TextBox txtSubTotal;
                internal Lui.Forms.TextBox txtDescuento;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.TextBox txtInteres;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox txtCuotas;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.TextBox txtValorCuota;
                internal System.Windows.Forms.Label Label9;
                internal Lui.Forms.Button PrintButton;
                internal Lui.Forms.Button cmdObs;
                internal Lui.Forms.Button cmdConvertir;
                internal System.Windows.Forms.TextBox txtComprobanteID;
                internal Lui.Forms.Button cmdMasDatos;
                internal System.Windows.Forms.Label lblTitulo;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox txtPV;

                #endregion
                private System.Windows.Forms.Panel PnlCuotas;
        }
}