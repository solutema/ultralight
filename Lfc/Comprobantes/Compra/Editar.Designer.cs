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

namespace Lfc.Comprobantes.Compra
{
        public partial class Editar : Lui.Forms.EditForm
        {

                #region Código generado por el Diseñador de Windows Forms
                private void InitializeComponent()
                {
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaProveedor = new Lui.Forms.DetailBox();
                        this.EntradaProductos = new Lui.Forms.ProductArray();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.EntradaObs = new System.Windows.Forms.TextBox();
                        this.cmdConvertir = new Lui.Forms.Button();
                        this.cmdObs = new Lui.Forms.Button();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.lblHaciaSituacion = new System.Windows.Forms.Label();
                        this.EntradaHaciaSituacion = new Lui.Forms.DetailBox();
                        this.EtiquetaTitulo = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.EntradaGastosEnvio = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaCancelado = new Lui.Forms.TextBox();
                        this.EntradaFecha = new Lui.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.label8 = new System.Windows.Forms.Label();
                        this.EntradaFormaPago = new Lui.Forms.ComboBox();
                        this.EntradaOtrosGastos = new Lui.Forms.TextBox();
                        this.label9 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(592, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(700, 8);
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 56);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(80, 24);
                        this.Label3.TabIndex = 1;
                        this.Label3.Text = "Proveedor";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaProveedor
                        // 
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
                        this.EntradaProveedor.Location = new System.Drawing.Point(88, 56);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.ReadOnly = false;
                        this.EntradaProveedor.Required = true;
                        this.EntradaProveedor.SelectOnFocus = true;
                        this.EntradaProveedor.Size = new System.Drawing.Size(244, 24);
                        this.EntradaProveedor.TabIndex = 2;
                        this.EntradaProveedor.Table = "personas";
                        this.EntradaProveedor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        this.EntradaProveedor.TextInt = 0;
                        this.EntradaProveedor.TipWhenBlank = "";
                        this.EntradaProveedor.ToolTipText = "";
                        // 
                        // EntradaProductos
                        // 
                        this.EntradaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProductos.AutoAgregar = false;
                        this.EntradaProductos.AutoScroll = true;
                        this.EntradaProductos.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.EntradaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaProductos.Changed = false;
                        this.EntradaProductos.Count = 0;
                        this.EntradaProductos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaProductos.FreeTextCode = "*";
                        this.EntradaProductos.Location = new System.Drawing.Point(8, 116);
                        this.EntradaProductos.LockPrice = false;
                        this.EntradaProductos.LockQuantity = false;
                        this.EntradaProductos.LockText = false;
                        this.EntradaProductos.MaxLength = 200;
                        this.EntradaProductos.Name = "EntradaProductos";
                        this.EntradaProductos.Precio = Lui.Forms.Product.Precios.Costo;
                        this.EntradaProductos.ShowStock = false;
                        this.EntradaProductos.Size = new System.Drawing.Size(792, 228);
                        this.EntradaProductos.TabIndex = 13;
                        this.EntradaProductos.Workspace = null;
                        this.EntradaProductos.TotalChanged += new System.EventHandler(this.RecalcularTotal);
                        this.EntradaProductos.AskForSerials += new System.EventHandler(this.EntradaProductos_AskForSerials);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(340, 56);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(60, 24);
                        this.Label2.TabIndex = 3;
                        this.Label2.Text = "Número";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNumero.AutoHeight = false;
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(556, 56);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(244, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 6;
                        this.EntradaNumero.TextRaw = "";
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        this.EntradaNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Location = new System.Drawing.Point(0, 384);
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Size = new System.Drawing.Size(32, 23);
                        this.EntradaObs.TabIndex = 49;
                        this.EntradaObs.Visible = false;
                        // 
                        // cmdConvertir
                        // 
                        this.cmdConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdConvertir.AutoHeight = false;
                        this.cmdConvertir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdConvertir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdConvertir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdConvertir.Image = null;
                        this.cmdConvertir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdConvertir.Location = new System.Drawing.Point(108, 421);
                        this.cmdConvertir.Name = "cmdConvertir";
                        this.cmdConvertir.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdConvertir.ReadOnly = false;
                        this.cmdConvertir.Size = new System.Drawing.Size(104, 44);
                        this.cmdConvertir.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdConvertir.Subtext = "F4";
                        this.cmdConvertir.TabIndex = 48;
                        this.cmdConvertir.Text = "Convertir";
                        this.cmdConvertir.ToolTipText = "Puede convertir este comprobante en Nota de Pedido, Pedido o Arribo.";
                        this.cmdConvertir.Click += new System.EventHandler(this.cmdConvertir_Click);
                        // 
                        // cmdObs
                        // 
                        this.cmdObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdObs.AutoHeight = false;
                        this.cmdObs.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdObs.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdObs.Image = null;
                        this.cmdObs.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdObs.Location = new System.Drawing.Point(412, 421);
                        this.cmdObs.Name = "cmdObs";
                        this.cmdObs.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdObs.ReadOnly = false;
                        this.cmdObs.Size = new System.Drawing.Size(104, 44);
                        this.cmdObs.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdObs.Subtext = "F7";
                        this.cmdObs.TabIndex = 49;
                        this.cmdObs.Text = "Observac.";
                        this.cmdObs.ToolTipText = "Ver las observaciones del comprobante.";
                        this.cmdObs.Click += new System.EventHandler(this.cmdObs_Click);
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(548, 348);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(104, 28);
                        this.Label4.TabIndex = 20;
                        this.Label4.Text = "Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTotal.AutoHeight = false;
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(652, 348);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = true;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(148, 28);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 21;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TextRaw = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AutoHeight = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(400, 56);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Remito|R",
        "Nota Pedido|NP",
        "Pedido|PD"};
                        this.EntradaTipo.Size = new System.Drawing.Size(92, 24);
                        this.EntradaTipo.TabIndex = 4;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.Text = "Factura A";
                        this.EntradaTipo.TextKey = "A";
                        this.EntradaTipo.TextRaw = "Factura A";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        // 
                        // lblHaciaSituacion
                        // 
                        this.lblHaciaSituacion.Location = new System.Drawing.Point(412, 84);
                        this.lblHaciaSituacion.Name = "lblHaciaSituacion";
                        this.lblHaciaSituacion.Size = new System.Drawing.Size(68, 24);
                        this.lblHaciaSituacion.TabIndex = 11;
                        this.lblHaciaSituacion.Text = "Destino";
                        this.lblHaciaSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaHaciaSituacion
                        // 
                        this.EntradaHaciaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaHaciaSituacion.AutoHeight = false;
                        this.EntradaHaciaSituacion.AutoTab = true;
                        this.EntradaHaciaSituacion.CanCreate = false;
                        this.EntradaHaciaSituacion.DetailField = "nombre";
                        this.EntradaHaciaSituacion.ExtraDetailFields = null;
                        this.EntradaHaciaSituacion.Filter = "deposito>0";
                        this.EntradaHaciaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaHaciaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaHaciaSituacion.FreeTextCode = "";
                        this.EntradaHaciaSituacion.KeyField = "id_situacion";
                        this.EntradaHaciaSituacion.Location = new System.Drawing.Point(480, 84);
                        this.EntradaHaciaSituacion.MaxLength = 200;
                        this.EntradaHaciaSituacion.Name = "EntradaHaciaSituacion";
                        this.EntradaHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHaciaSituacion.ReadOnly = false;
                        this.EntradaHaciaSituacion.Required = true;
                        this.EntradaHaciaSituacion.SelectOnFocus = true;
                        this.EntradaHaciaSituacion.Size = new System.Drawing.Size(320, 24);
                        this.EntradaHaciaSituacion.TabIndex = 12;
                        this.EntradaHaciaSituacion.Table = "articulos_situaciones";
                        this.EntradaHaciaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaHaciaSituacion.Text = "0";
                        this.EntradaHaciaSituacion.TextDetail = "";
                        this.EntradaHaciaSituacion.TextInt = 0;
                        this.EntradaHaciaSituacion.TipWhenBlank = "";
                        this.EntradaHaciaSituacion.ToolTipText = "";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(8, 8);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(792, 40);
                        this.EtiquetaTitulo.TabIndex = 0;
                        this.EtiquetaTitulo.Text = "Comprobante";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoHeight = false;
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(496, 56);
                        this.EntradaPV.MaxLenght = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 5;
                        this.EntradaPV.Text = "0";
                        this.EntradaPV.TextRaw = "0";
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        // 
                        // EntradaGastosEnvio
                        // 
                        this.EntradaGastosEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaGastosEnvio.AutoHeight = false;
                        this.EntradaGastosEnvio.AutoNav = true;
                        this.EntradaGastosEnvio.AutoTab = true;
                        this.EntradaGastosEnvio.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaGastosEnvio.DecimalPlaces = -1;
                        this.EntradaGastosEnvio.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaGastosEnvio.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGastosEnvio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaGastosEnvio.Location = new System.Drawing.Point(124, 352);
                        this.EntradaGastosEnvio.MaxLenght = 32767;
                        this.EntradaGastosEnvio.MultiLine = false;
                        this.EntradaGastosEnvio.Name = "EntradaGastosEnvio";
                        this.EntradaGastosEnvio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGastosEnvio.PasswordChar = '\0';
                        this.EntradaGastosEnvio.Prefijo = "$";
                        this.EntradaGastosEnvio.ReadOnly = false;
                        this.EntradaGastosEnvio.SelectOnFocus = true;
                        this.EntradaGastosEnvio.Size = new System.Drawing.Size(104, 24);
                        this.EntradaGastosEnvio.Sufijo = "";
                        this.EntradaGastosEnvio.TabIndex = 15;
                        this.EntradaGastosEnvio.Text = "0.00";
                        this.EntradaGastosEnvio.TextRaw = "0.00";
                        this.EntradaGastosEnvio.TipWhenBlank = "";
                        this.EntradaGastosEnvio.ToolTipText = "";
                        this.EntradaGastosEnvio.TextChanged += new System.EventHandler(this.RecalcularTotal);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label1.Location = new System.Drawing.Point(8, 352);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(116, 24);
                        this.label1.TabIndex = 14;
                        this.label1.Text = "Gastos de Envío";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaEstado.AutoHeight = false;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.DetailField = null;
                        this.EntradaEstado.Filter = null;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.KeyField = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(300, 352);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "N/A|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(164, 24);
                        this.EntradaEstado.TabIndex = 19;
                        this.EntradaEstado.Table = null;
                        this.EntradaEstado.Text = "N/A";
                        this.EntradaEstado.TextKey = "0";
                        this.EntradaEstado.TextRaw = "N/A";
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label5.Location = new System.Drawing.Point(240, 352);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(60, 24);
                        this.label5.TabIndex = 18;
                        this.label5.Text = "Estado";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label6.Location = new System.Drawing.Point(548, 380);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(104, 28);
                        this.label6.TabIndex = 22;
                        this.label6.Text = "Cancelado";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaCancelado
                        // 
                        this.EntradaCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCancelado.AutoHeight = false;
                        this.EntradaCancelado.AutoNav = true;
                        this.EntradaCancelado.AutoTab = true;
                        this.EntradaCancelado.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCancelado.DecimalPlaces = -1;
                        this.EntradaCancelado.Font = new System.Drawing.Font("Bitstream Vera Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCancelado.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCancelado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCancelado.Location = new System.Drawing.Point(652, 380);
                        this.EntradaCancelado.MaxLenght = 32767;
                        this.EntradaCancelado.MultiLine = false;
                        this.EntradaCancelado.Name = "EntradaCancelado";
                        this.EntradaCancelado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCancelado.PasswordChar = '\0';
                        this.EntradaCancelado.Prefijo = "$";
                        this.EntradaCancelado.ReadOnly = true;
                        this.EntradaCancelado.SelectOnFocus = true;
                        this.EntradaCancelado.Size = new System.Drawing.Size(148, 28);
                        this.EntradaCancelado.Sufijo = "";
                        this.EntradaCancelado.TabIndex = 23;
                        this.EntradaCancelado.TabStop = false;
                        this.EntradaCancelado.Text = "0.00";
                        this.EntradaCancelado.TextRaw = "0.00";
                        this.EntradaCancelado.TipWhenBlank = "";
                        this.EntradaCancelado.ToolTipText = "";
                        // 
                        // EntradaFecha
                        // 
                        this.EntradaFecha.AutoHeight = false;
                        this.EntradaFecha.AutoNav = true;
                        this.EntradaFecha.AutoTab = true;
                        this.EntradaFecha.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFecha.DecimalPlaces = -1;
                        this.EntradaFecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFecha.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFecha.Location = new System.Drawing.Point(88, 84);
                        this.EntradaFecha.MaxLenght = 32767;
                        this.EntradaFecha.MultiLine = false;
                        this.EntradaFecha.Name = "EntradaFecha";
                        this.EntradaFecha.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFecha.PasswordChar = '\0';
                        this.EntradaFecha.Prefijo = "";
                        this.EntradaFecha.ReadOnly = false;
                        this.EntradaFecha.SelectOnFocus = true;
                        this.EntradaFecha.Size = new System.Drawing.Size(100, 24);
                        this.EntradaFecha.Sufijo = "";
                        this.EntradaFecha.TabIndex = 8;
                        this.EntradaFecha.TextRaw = "";
                        this.EntradaFecha.TipWhenBlank = "";
                        this.EntradaFecha.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(8, 84);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(80, 24);
                        this.label7.TabIndex = 7;
                        this.label7.Text = "Fecha";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(200, 84);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(104, 24);
                        this.label8.TabIndex = 9;
                        this.label8.Text = "Controla Pago";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFormaPago
                        // 
                        this.EntradaFormaPago.AutoHeight = false;
                        this.EntradaFormaPago.AutoNav = true;
                        this.EntradaFormaPago.AutoTab = true;
                        this.EntradaFormaPago.DetailField = null;
                        this.EntradaFormaPago.Filter = null;
                        this.EntradaFormaPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFormaPago.KeyField = null;
                        this.EntradaFormaPago.Location = new System.Drawing.Point(304, 84);
                        this.EntradaFormaPago.MaxLenght = 32767;
                        this.EntradaFormaPago.Name = "EntradaFormaPago";
                        this.EntradaFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPago.ReadOnly = false;
                        this.EntradaFormaPago.SetData = new string[] {
        "Si|3",
        "No|0"};
                        this.EntradaFormaPago.Size = new System.Drawing.Size(72, 24);
                        this.EntradaFormaPago.TabIndex = 10;
                        this.EntradaFormaPago.Table = null;
                        this.EntradaFormaPago.Text = "No";
                        this.EntradaFormaPago.TextKey = "0";
                        this.EntradaFormaPago.TextRaw = "No";
                        this.EntradaFormaPago.TipWhenBlank = "";
                        this.EntradaFormaPago.ToolTipText = "";
                        // 
                        // EntradaOtrosGastos
                        // 
                        this.EntradaOtrosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaOtrosGastos.AutoHeight = false;
                        this.EntradaOtrosGastos.AutoNav = true;
                        this.EntradaOtrosGastos.AutoTab = true;
                        this.EntradaOtrosGastos.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaOtrosGastos.DecimalPlaces = -1;
                        this.EntradaOtrosGastos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaOtrosGastos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaOtrosGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaOtrosGastos.Location = new System.Drawing.Point(124, 380);
                        this.EntradaOtrosGastos.MaxLenght = 32767;
                        this.EntradaOtrosGastos.MultiLine = false;
                        this.EntradaOtrosGastos.Name = "EntradaOtrosGastos";
                        this.EntradaOtrosGastos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaOtrosGastos.PasswordChar = '\0';
                        this.EntradaOtrosGastos.Prefijo = "$";
                        this.EntradaOtrosGastos.ReadOnly = false;
                        this.EntradaOtrosGastos.SelectOnFocus = true;
                        this.EntradaOtrosGastos.Size = new System.Drawing.Size(104, 24);
                        this.EntradaOtrosGastos.Sufijo = "";
                        this.EntradaOtrosGastos.TabIndex = 17;
                        this.EntradaOtrosGastos.Text = "0.00";
                        this.EntradaOtrosGastos.TextRaw = "0.00";
                        this.EntradaOtrosGastos.TipWhenBlank = "";
                        this.EntradaOtrosGastos.ToolTipText = "";
                        this.EntradaOtrosGastos.TextChanged += new System.EventHandler(this.RecalcularTotal);
                        // 
                        // label9
                        // 
                        this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label9.Location = new System.Drawing.Point(8, 380);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(116, 24);
                        this.label9.TabIndex = 16;
                        this.label9.Text = "Otros Gastos";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(808, 473);
                        this.Controls.Add(this.cmdObs);
                        this.Controls.Add(this.cmdConvertir);
                        this.Controls.Add(this.EntradaOtrosGastos);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.EntradaFormaPago);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaFecha);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EntradaCancelado);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.EntradaGastosEnvio);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.lblHaciaSituacion);
                        this.Controls.Add(this.EntradaHaciaSituacion);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaProductos);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaProveedor);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Name = "Editar";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPedidosEditar_KeyDown);
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.Controls.SetChildIndex(this.EntradaProveedor, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaProductos, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.EntradaHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.lblHaciaSituacion, 0);
                        this.Controls.SetChildIndex(this.EntradaPV, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaGastosEnvio, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.EntradaCancelado, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.EntradaFecha, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.EntradaFormaPago, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaEstado, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.EntradaOtrosGastos, 0);
                        this.Controls.SetChildIndex(this.cmdConvertir, 0);
                        this.Controls.SetChildIndex(this.cmdObs, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
		#endregion

                internal System.Windows.Forms.Label EtiquetaTitulo;
                internal Lui.Forms.TextBox EntradaPV;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaGastosEnvio;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal System.Windows.Forms.Label label5;
                internal System.Windows.Forms.Label label6;
                internal Lui.Forms.TextBox EntradaCancelado;
                internal Lui.Forms.TextBox EntradaFecha;
                internal System.Windows.Forms.Label label7;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.DetailBox EntradaProveedor;
                internal Lui.Forms.ProductArray EntradaProductos;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox EntradaNumero;
                internal System.Windows.Forms.TextBox EntradaObs;
                internal Lui.Forms.Button cmdConvertir;
                internal Lui.Forms.Button cmdObs;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaTotal;
                internal Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.DetailBox EntradaHaciaSituacion;
                internal System.Windows.Forms.Label lblHaciaSituacion;
                internal System.Windows.Forms.Label label8;
                internal Lui.Forms.ComboBox EntradaFormaPago;
                internal Lui.Forms.TextBox EntradaOtrosGastos;
                internal System.Windows.Forms.Label label9;
        }
}
