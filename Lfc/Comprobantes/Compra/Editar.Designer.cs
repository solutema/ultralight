#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lfc.Comprobantes.Compra
{
        partial class Editar
        {
                /// <summary> 
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary> 
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de componentes

                /// <summary> 
                /// Método necesario para admitir el Diseñador. No se puede modificar 
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.EtiquetaTitulo = new Lui.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.EntradaFormaPago = new Lui.Forms.ComboBox();
                        this.label8 = new Lui.Forms.Label();
                        this.EntradaFecha = new Lui.Forms.TextBox();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.EntradaHaciaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.EntradaProductos = new Lcc.Entrada.Articulos.MatrizDetalleComprobante();
                        this.EntradaProveedor = new Lcc.Entrada.CodigoDetalle();
                        this.label7 = new Lui.Forms.Label();
                        this.EtiquetaHaciaSituacion = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.BotonObs = new Lui.Forms.Button();
                        this.BotonConvertir = new Lui.Forms.Button();
                        this.EntradaOtrosGastos = new Lui.Forms.TextBox();
                        this.EntradaCancelado = new Lui.Forms.TextBox();
                        this.EntradaGastosEnvio = new Lui.Forms.TextBox();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.EntradaObs = new System.Windows.Forms.TextBox();
                        this.label9 = new Lui.Forms.Label();
                        this.label6 = new Lui.Forms.Label();
                        this.EtiquetaEstado = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Contenedor = new System.Windows.Forms.Panel();
                        this.Contenedor.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTitulo.LabelStyle = Lui.Forms.LabelStyles.Header1;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(641, 40);
                        this.EtiquetaTitulo.TabIndex = 1;
                        this.EtiquetaTitulo.Text = "Comprobante";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = false;
                        this.EntradaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.FieldName = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(384, 44);
                        this.EntradaTipo.MaxLength = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.PlaceholderText = null;
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Factura A|FA",
        "Factura B|FB",
        "Factura C|FC",
        "Factura E|FE",
        "Factura M|FM",
        "Remito|R",
        "Nota Pedido|NP",
        "Pedido|PD"};
                        this.EntradaTipo.Size = new System.Drawing.Size(92, 25);
                        this.EntradaTipo.TabIndex = 17;
                        this.EntradaTipo.TextKey = "FA";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipoPvNumero_TextChanged);
                        // 
                        // EntradaFormaPago
                        // 
                        this.EntradaFormaPago.AlwaysExpanded = false;
                        this.EntradaFormaPago.AutoNav = true;
                        this.EntradaFormaPago.AutoTab = true;
                        this.EntradaFormaPago.FieldName = null;
                        this.EntradaFormaPago.Location = new System.Drawing.Point(296, 72);
                        this.EntradaFormaPago.MaxLength = 32767;
                        this.EntradaFormaPago.Name = "EntradaFormaPago";
                        this.EntradaFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPago.PlaceholderText = null;
                        this.EntradaFormaPago.ReadOnly = false;
                        this.EntradaFormaPago.SetData = new string[] {
        "Si|3",
        "No|0"};
                        this.EntradaFormaPago.Size = new System.Drawing.Size(58, 25);
                        this.EntradaFormaPago.TabIndex = 23;
                        this.EntradaFormaPago.TextKey = "0";
                        // 
                        // label8
                        // 
                        this.label8.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label8.Location = new System.Drawing.Point(192, 72);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(104, 24);
                        this.label8.TabIndex = 22;
                        this.label8.Text = "Controla Pago";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFecha
                        // 
                        this.EntradaFecha.AutoNav = true;
                        this.EntradaFecha.AutoTab = true;
                        this.EntradaFecha.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFecha.DecimalPlaces = -1;
                        this.EntradaFecha.FieldName = null;
                        this.EntradaFecha.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFecha.Location = new System.Drawing.Point(80, 72);
                        this.EntradaFecha.MaxLength = 32767;
                        this.EntradaFecha.MultiLine = false;
                        this.EntradaFecha.Name = "EntradaFecha";
                        this.EntradaFecha.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFecha.PasswordChar = '\0';
                        this.EntradaFecha.PlaceholderText = null;
                        this.EntradaFecha.Prefijo = "";
                        this.EntradaFecha.ReadOnly = false;
                        this.EntradaFecha.SelectOnFocus = true;
                        this.EntradaFecha.Size = new System.Drawing.Size(100, 24);
                        this.EntradaFecha.Sufijo = "";
                        this.EntradaFecha.TabIndex = 21;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.FieldName = null;
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.Location = new System.Drawing.Point(480, 44);
                        this.EntradaPV.MaxLength = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.PlaceholderText = null;
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 18;
                        this.EntradaPV.Text = "0";
                        this.EntradaPV.TextChanged += new System.EventHandler(this.EntradaTipoPvNumero_TextChanged);
                        // 
                        // EntradaHaciaSituacion
                        // 
                        this.EntradaHaciaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaHaciaSituacion.AutoNav = true;
                        this.EntradaHaciaSituacion.AutoTab = true;
                        this.EntradaHaciaSituacion.CanCreate = false;
                        this.EntradaHaciaSituacion.DataTextField = "nombre";
                        this.EntradaHaciaSituacion.DataValueField = "id_situacion";
                        this.EntradaHaciaSituacion.ExtraDetailFields = "";
                        this.EntradaHaciaSituacion.FieldName = null;
                        this.EntradaHaciaSituacion.Filter = "deposito>0";
                        this.EntradaHaciaSituacion.FreeTextCode = "";
                        this.EntradaHaciaSituacion.Location = new System.Drawing.Point(444, 72);
                        this.EntradaHaciaSituacion.MaxLength = 200;
                        this.EntradaHaciaSituacion.Name = "EntradaHaciaSituacion";
                        this.EntradaHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHaciaSituacion.PlaceholderText = null;
                        this.EntradaHaciaSituacion.ReadOnly = false;
                        this.EntradaHaciaSituacion.Required = true;
                        this.EntradaHaciaSituacion.Size = new System.Drawing.Size(197, 24);
                        this.EntradaHaciaSituacion.TabIndex = 25;
                        this.EntradaHaciaSituacion.Table = "articulos_situaciones";
                        this.EntradaHaciaSituacion.Text = "0";
                        this.EntradaHaciaSituacion.TextDetail = "";
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.FieldName = null;
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.Location = new System.Drawing.Point(540, 44);
                        this.EntradaNumero.MaxLength = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.PlaceholderText = null;
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(100, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 19;
                        this.EntradaNumero.TextChanged += new System.EventHandler(this.EntradaTipoPvNumero_TextChanged);
                        this.EntradaNumero.Leave += new System.EventHandler(this.EntradaNumero_Leave);
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
                        this.EntradaProductos.Location = new System.Drawing.Point(0, 104);
                        this.EntradaProductos.LockPrice = false;
                        this.EntradaProductos.LockQuantity = false;
                        this.EntradaProductos.LockText = false;
                        this.EntradaProductos.MaxLength = 200;
                        this.EntradaProductos.Name = "EntradaProductos";
                        this.EntradaProductos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProductos.Precio = Lcc.Entrada.Articulos.Precios.Costo;
                        this.EntradaProductos.ReadOnly = false;
                        this.EntradaProductos.ShowStock = false;
                        this.EntradaProductos.Size = new System.Drawing.Size(642, 200);
                        this.EntradaProductos.TabIndex = 26;
                        this.EntradaProductos.ObtenerDatosSeguimiento += new System.EventHandler(this.EntradaProductos_ObtenerDatosSeguimiento);
                        // 
                        // EntradaProveedor
                        // 
                        this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProveedor.AutoNav = true;
                        this.EntradaProveedor.AutoTab = true;
                        this.EntradaProveedor.CanCreate = true;
                        this.EntradaProveedor.DataTextField = "nombre_visible";
                        this.EntradaProveedor.DataValueField = "id_persona";
                        this.EntradaProveedor.ExtraDetailFields = "";
                        this.EntradaProveedor.FieldName = null;
                        this.EntradaProveedor.Filter = "(tipo&2)=2";
                        this.EntradaProveedor.FreeTextCode = "";
                        this.EntradaProveedor.Location = new System.Drawing.Point(80, 44);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.PlaceholderText = null;
                        this.EntradaProveedor.ReadOnly = false;
                        this.EntradaProveedor.Required = true;
                        this.EntradaProveedor.Size = new System.Drawing.Size(228, 24);
                        this.EntradaProveedor.TabIndex = 15;
                        this.EntradaProveedor.Table = "personas";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        // 
                        // label7
                        // 
                        this.label7.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label7.Location = new System.Drawing.Point(0, 72);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(80, 24);
                        this.label7.TabIndex = 20;
                        this.label7.Text = "Fecha";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaHaciaSituacion
                        // 
                        this.EtiquetaHaciaSituacion.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaHaciaSituacion.Location = new System.Drawing.Point(372, 72);
                        this.EtiquetaHaciaSituacion.Name = "EtiquetaHaciaSituacion";
                        this.EtiquetaHaciaSituacion.Size = new System.Drawing.Size(68, 24);
                        this.EtiquetaHaciaSituacion.TabIndex = 24;
                        this.EtiquetaHaciaSituacion.Text = "Destino";
                        this.EtiquetaHaciaSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(320, 44);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(64, 24);
                        this.Label2.TabIndex = 16;
                        this.Label2.Text = "Número";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(0, 44);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(80, 24);
                        this.Label3.TabIndex = 14;
                        this.Label3.Text = "Proveedor";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = true;
                        this.EntradaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.FieldName = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(288, 311);
                        this.EntradaEstado.MaxLength = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.PlaceholderText = null;
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "N/A|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(164, 21);
                        this.EntradaEstado.TabIndex = 55;
                        this.EntradaEstado.TextKey = "0";
                        // 
                        // BotonObs
                        // 
                        this.BotonObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonObs.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonObs.Image = null;
                        this.BotonObs.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonObs.Location = new System.Drawing.Point(116, 368);
                        this.BotonObs.Name = "BotonObs";
                        this.BotonObs.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonObs.ReadOnly = false;
                        this.BotonObs.Size = new System.Drawing.Size(108, 32);
                        this.BotonObs.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonObs.Subtext = "F7";
                        this.BotonObs.TabIndex = 62;
                        this.BotonObs.Text = "Observac.";
                        this.BotonObs.Click += new System.EventHandler(this.BotonObs_Click);
                        // 
                        // BotonConvertir
                        // 
                        this.BotonConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonConvertir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonConvertir.Image = null;
                        this.BotonConvertir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonConvertir.Location = new System.Drawing.Point(0, 368);
                        this.BotonConvertir.Name = "BotonConvertir";
                        this.BotonConvertir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonConvertir.ReadOnly = false;
                        this.BotonConvertir.Size = new System.Drawing.Size(108, 32);
                        this.BotonConvertir.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonConvertir.Subtext = "F4";
                        this.BotonConvertir.TabIndex = 60;
                        this.BotonConvertir.Text = "Convertir";
                        this.BotonConvertir.Click += new System.EventHandler(this.BotonConvertir_Click);
                        // 
                        // EntradaOtrosGastos
                        // 
                        this.EntradaOtrosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaOtrosGastos.AutoNav = true;
                        this.EntradaOtrosGastos.AutoTab = true;
                        this.EntradaOtrosGastos.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaOtrosGastos.DecimalPlaces = -1;
                        this.EntradaOtrosGastos.FieldName = null;
                        this.EntradaOtrosGastos.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaOtrosGastos.Location = new System.Drawing.Point(116, 340);
                        this.EntradaOtrosGastos.MaxLength = 32767;
                        this.EntradaOtrosGastos.MultiLine = false;
                        this.EntradaOtrosGastos.Name = "EntradaOtrosGastos";
                        this.EntradaOtrosGastos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaOtrosGastos.PasswordChar = '\0';
                        this.EntradaOtrosGastos.PlaceholderText = null;
                        this.EntradaOtrosGastos.Prefijo = "$";
                        this.EntradaOtrosGastos.ReadOnly = false;
                        this.EntradaOtrosGastos.SelectOnFocus = true;
                        this.EntradaOtrosGastos.Size = new System.Drawing.Size(104, 24);
                        this.EntradaOtrosGastos.Sufijo = "";
                        this.EntradaOtrosGastos.TabIndex = 53;
                        this.EntradaOtrosGastos.Text = "0.00";
                        // 
                        // EntradaCancelado
                        // 
                        this.EntradaCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCancelado.AutoNav = true;
                        this.EntradaCancelado.AutoTab = true;
                        this.EntradaCancelado.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCancelado.DecimalPlaces = -1;
                        this.EntradaCancelado.FieldName = null;
                        this.EntradaCancelado.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCancelado.Location = new System.Drawing.Point(516, 372);
                        this.EntradaCancelado.MaxLength = 32767;
                        this.EntradaCancelado.MultiLine = false;
                        this.EntradaCancelado.Name = "EntradaCancelado";
                        this.EntradaCancelado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCancelado.PasswordChar = '\0';
                        this.EntradaCancelado.PlaceholderText = null;
                        this.EntradaCancelado.Prefijo = "$";
                        this.EntradaCancelado.ReadOnly = false;
                        this.EntradaCancelado.SelectOnFocus = true;
                        this.EntradaCancelado.Size = new System.Drawing.Size(124, 28);
                        this.EntradaCancelado.Sufijo = "";
                        this.EntradaCancelado.TabIndex = 59;
                        this.EntradaCancelado.TabStop = false;
                        this.EntradaCancelado.Text = "0.00";
                        // 
                        // EntradaGastosEnvio
                        // 
                        this.EntradaGastosEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaGastosEnvio.AutoNav = true;
                        this.EntradaGastosEnvio.AutoTab = true;
                        this.EntradaGastosEnvio.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaGastosEnvio.DecimalPlaces = -1;
                        this.EntradaGastosEnvio.FieldName = null;
                        this.EntradaGastosEnvio.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaGastosEnvio.Location = new System.Drawing.Point(116, 312);
                        this.EntradaGastosEnvio.MaxLength = 32767;
                        this.EntradaGastosEnvio.MultiLine = false;
                        this.EntradaGastosEnvio.Name = "EntradaGastosEnvio";
                        this.EntradaGastosEnvio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaGastosEnvio.PasswordChar = '\0';
                        this.EntradaGastosEnvio.PlaceholderText = null;
                        this.EntradaGastosEnvio.Prefijo = "$";
                        this.EntradaGastosEnvio.ReadOnly = false;
                        this.EntradaGastosEnvio.SelectOnFocus = true;
                        this.EntradaGastosEnvio.Size = new System.Drawing.Size(104, 24);
                        this.EntradaGastosEnvio.Sufijo = "";
                        this.EntradaGastosEnvio.TabIndex = 51;
                        this.EntradaGastosEnvio.Text = "0.00";
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.FieldName = null;
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.Location = new System.Drawing.Point(516, 340);
                        this.EntradaTotal.MaxLength = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.PlaceholderText = null;
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = false;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(124, 28);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 57;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaObs.Location = new System.Drawing.Point(224, 340);
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Size = new System.Drawing.Size(32, 23);
                        this.EntradaObs.TabIndex = 61;
                        this.EntradaObs.Visible = false;
                        // 
                        // label9
                        // 
                        this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label9.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label9.Location = new System.Drawing.Point(0, 340);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(116, 24);
                        this.label9.TabIndex = 52;
                        this.label9.Text = "Otros Gastos";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.label6.LabelStyle = Lui.Forms.LabelStyles.Big;
                        this.label6.Location = new System.Drawing.Point(412, 372);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(104, 28);
                        this.label6.TabIndex = 58;
                        this.label6.Text = "Cancelado";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaEstado
                        // 
                        this.EtiquetaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaEstado.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaEstado.Location = new System.Drawing.Point(226, 312);
                        this.EtiquetaEstado.Name = "EtiquetaEstado";
                        this.EtiquetaEstado.Size = new System.Drawing.Size(60, 24);
                        this.EtiquetaEstado.TabIndex = 54;
                        this.EtiquetaEstado.Text = "Estado";
                        this.EtiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label1.Location = new System.Drawing.Point(0, 312);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(116, 24);
                        this.label1.TabIndex = 50;
                        this.label1.Text = "Gastos de Envío";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Big;
                        this.Label4.Location = new System.Drawing.Point(412, 340);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(104, 28);
                        this.Label4.TabIndex = 56;
                        this.Label4.Text = "Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Contenedor
                        // 
                        this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Contenedor.Controls.Add(this.EntradaObs);
                        this.Contenedor.Controls.Add(this.EntradaEstado);
                        this.Contenedor.Controls.Add(this.EtiquetaTitulo);
                        this.Contenedor.Controls.Add(this.BotonObs);
                        this.Contenedor.Controls.Add(this.Label3);
                        this.Contenedor.Controls.Add(this.BotonConvertir);
                        this.Contenedor.Controls.Add(this.Label2);
                        this.Contenedor.Controls.Add(this.EntradaOtrosGastos);
                        this.Contenedor.Controls.Add(this.EtiquetaHaciaSituacion);
                        this.Contenedor.Controls.Add(this.EntradaCancelado);
                        this.Contenedor.Controls.Add(this.label7);
                        this.Contenedor.Controls.Add(this.EntradaGastosEnvio);
                        this.Contenedor.Controls.Add(this.EntradaProveedor);
                        this.Contenedor.Controls.Add(this.EntradaTotal);
                        this.Contenedor.Controls.Add(this.EntradaProductos);
                        this.Contenedor.Controls.Add(this.EntradaNumero);
                        this.Contenedor.Controls.Add(this.label9);
                        this.Contenedor.Controls.Add(this.EntradaHaciaSituacion);
                        this.Contenedor.Controls.Add(this.label6);
                        this.Contenedor.Controls.Add(this.EntradaPV);
                        this.Contenedor.Controls.Add(this.EtiquetaEstado);
                        this.Contenedor.Controls.Add(this.EntradaFecha);
                        this.Contenedor.Controls.Add(this.label1);
                        this.Contenedor.Controls.Add(this.label8);
                        this.Contenedor.Controls.Add(this.Label4);
                        this.Contenedor.Controls.Add(this.EntradaFormaPago);
                        this.Contenedor.Controls.Add(this.EntradaTipo);
                        this.Contenedor.Location = new System.Drawing.Point(0, 0);
                        this.Contenedor.Name = "Contenedor";
                        this.Contenedor.Size = new System.Drawing.Size(640, 400);
                        this.Contenedor.TabIndex = 0;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.Contenedor);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.Controls.SetChildIndex(this.Contenedor, 0);
                        this.Contenedor.ResumeLayout(false);
                        this.Contenedor.PerformLayout();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label EtiquetaTitulo;
                internal Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.ComboBox EntradaFormaPago;
                internal Lui.Forms.Label label8;
                internal Lui.Forms.TextBox EntradaFecha;
                internal Lui.Forms.TextBox EntradaPV;
                internal Lcc.Entrada.CodigoDetalle EntradaHaciaSituacion;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lcc.Entrada.Articulos.MatrizDetalleComprobante EntradaProductos;
                internal Lcc.Entrada.CodigoDetalle EntradaProveedor;
                internal Lui.Forms.Label label7;
                internal Lui.Forms.Label EtiquetaHaciaSituacion;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal Lui.Forms.Button BotonObs;
                internal Lui.Forms.Button BotonConvertir;
                internal Lui.Forms.TextBox EntradaOtrosGastos;
                internal Lui.Forms.TextBox EntradaCancelado;
                internal Lui.Forms.TextBox EntradaGastosEnvio;
                internal Lui.Forms.TextBox EntradaTotal;
                internal System.Windows.Forms.TextBox EntradaObs;
                internal Lui.Forms.Label label9;
                internal Lui.Forms.Label label6;
                internal Lui.Forms.Label EtiquetaEstado;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.Label Label4;
                private System.Windows.Forms.Panel Contenedor;
        }
}
