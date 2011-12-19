#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                // Limpiar los recursos que se están utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
                        this.Label3 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.ListaFacturas = new Lui.Forms.ListView();
                        this.FacturasId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasPendiente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EtiquetaFacturasImporte = new Lui.Forms.Label();
                        this.BotonAgregarFactura = new Lui.Forms.Button();
                        this.BotonQuitarFactura = new Lui.Forms.Button();
                        this.PanelValores = new System.Windows.Forms.Panel();
                        this.LabelAgregarValores = new System.Windows.Forms.Label();
                        this.ListaValores = new Lui.Forms.ListView();
                        this.ValoresTipoPagoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ValoresTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ValoresImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ValoresObs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.BotonAgregarValor = new Lui.Forms.Button();
                        this.BotonQuitarValor = new Lui.Forms.Button();
                        this.Label4 = new Lui.Forms.Label();
                        this.EtiquetaValoresImporte = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.EtiquetaTitulo = new Lui.Forms.Label();
                        this.EntradaConceptoTexto = new Lui.Forms.TextBox();
                        this.label6 = new Lui.Forms.Label();
                        this.TablaCentral = new System.Windows.Forms.TableLayoutPanel();
                        this.PanelComprob = new System.Windows.Forms.Panel();
                        this.LabelAgregarFacturas = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.PanelValores.SuspendLayout();
                        this.TablaCentral.SuspendLayout();
                        this.PanelComprob.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Label3
                        // 
                        this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
                        this.Label3.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.Label3.Location = new System.Drawing.Point(0, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(372, 20);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Este recibo cancela los siguientes comprobantes:";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(224, 44);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(80, 24);
                        this.Label1.TabIndex = 4;
                        this.Label1.Text = "Vendedor";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaVendedor
                        // 
                        this.EntradaVendedor.AutoNav = true;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.ExtraDetailFields = "";
                        this.EntradaVendedor.FieldName = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.Location = new System.Drawing.Point(304, 44);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.PlaceholderText = null;
                        this.EntradaVendedor.ReadOnly = false;
                        this.EntradaVendedor.Required = true;
                        this.EntradaVendedor.Size = new System.Drawing.Size(200, 24);
                        this.EntradaVendedor.TabIndex = 5;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(0, 44);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(76, 24);
                        this.Label2.TabIndex = 1;
                        this.Label2.Text = "Número";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.FieldName = null;
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.Location = new System.Drawing.Point(112, 44);
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
                        this.EntradaNumero.TabIndex = 3;
                        // 
                        // ListaFacturas
                        // 
                        this.ListaFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FacturasId,
            this.FacturasNumero,
            this.FacturasFecha,
            this.FacturasImporte,
            this.FacturasPendiente,
            this.FacturasCliente});
                        this.ListaFacturas.FullRowSelect = true;
                        this.ListaFacturas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaFacturas.HideSelection = false;
                        this.ListaFacturas.Location = new System.Drawing.Point(0, 28);
                        this.ListaFacturas.MultiSelect = false;
                        this.ListaFacturas.Name = "ListaFacturas";
                        this.ListaFacturas.Size = new System.Drawing.Size(376, 292);
                        this.ListaFacturas.Sorting = System.Windows.Forms.SortOrder.Ascending;
                        this.ListaFacturas.TabIndex = 9;
                        this.ListaFacturas.UseCompatibleStateImageBehavior = false;
                        this.ListaFacturas.View = System.Windows.Forms.View.Details;
                        this.ListaFacturas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaFacturas_KeyDown);
                        // 
                        // FacturasId
                        // 
                        this.FacturasId.Text = "Id";
                        this.FacturasId.Width = 0;
                        // 
                        // FacturasNumero
                        // 
                        this.FacturasNumero.Text = "Nro.";
                        this.FacturasNumero.Width = 120;
                        // 
                        // FacturasFecha
                        // 
                        this.FacturasFecha.Text = "Fecha";
                        this.FacturasFecha.Width = 90;
                        // 
                        // FacturasImporte
                        // 
                        this.FacturasImporte.Text = "Importe";
                        this.FacturasImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.FacturasImporte.Width = 72;
                        // 
                        // FacturasPendiente
                        // 
                        this.FacturasPendiente.Text = "Pendiente";
                        this.FacturasPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.FacturasPendiente.Width = 72;
                        // 
                        // FacturasCliente
                        // 
                        this.FacturasCliente.Text = "Cliente";
                        this.FacturasCliente.Width = 300;
                        // 
                        // EtiquetaFacturasImporte
                        // 
                        this.EtiquetaFacturasImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaFacturasImporte.LabelStyle = Lui.Forms.LabelStyles.Bigger;
                        this.EtiquetaFacturasImporte.Location = new System.Drawing.Point(260, 328);
                        this.EtiquetaFacturasImporte.Name = "EtiquetaFacturasImporte";
                        this.EtiquetaFacturasImporte.Size = new System.Drawing.Size(112, 31);
                        this.EtiquetaFacturasImporte.TabIndex = 12;
                        this.EtiquetaFacturasImporte.Text = "$ 0.00";
                        this.EtiquetaFacturasImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // BotonAgregarFactura
                        // 
                        this.BotonAgregarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAgregarFactura.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregarFactura.Image = null;
                        this.BotonAgregarFactura.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregarFactura.Location = new System.Drawing.Point(0, 328);
                        this.BotonAgregarFactura.Name = "BotonAgregarFactura";
                        this.BotonAgregarFactura.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregarFactura.ReadOnly = false;
                        this.BotonAgregarFactura.Size = new System.Drawing.Size(100, 31);
                        this.BotonAgregarFactura.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAgregarFactura.Subtext = "F2";
                        this.BotonAgregarFactura.TabIndex = 10;
                        this.BotonAgregarFactura.Text = "Agregar";
                        this.BotonAgregarFactura.Click += new System.EventHandler(this.BotonFacturasAgregar_Click);
                        // 
                        // BotonQuitarFactura
                        // 
                        this.BotonQuitarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonQuitarFactura.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarFactura.Image = null;
                        this.BotonQuitarFactura.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarFactura.Location = new System.Drawing.Point(108, 328);
                        this.BotonQuitarFactura.Name = "BotonQuitarFactura";
                        this.BotonQuitarFactura.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarFactura.ReadOnly = false;
                        this.BotonQuitarFactura.Size = new System.Drawing.Size(100, 31);
                        this.BotonQuitarFactura.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonQuitarFactura.Subtext = "F3";
                        this.BotonQuitarFactura.TabIndex = 11;
                        this.BotonQuitarFactura.Text = "Quitar";
                        this.BotonQuitarFactura.Visible = false;
                        this.BotonQuitarFactura.Click += new System.EventHandler(this.BotonFacturasQuitar_Click);
                        // 
                        // PanelValores
                        // 
                        this.PanelValores.Controls.Add(this.LabelAgregarValores);
                        this.PanelValores.Controls.Add(this.ListaValores);
                        this.PanelValores.Controls.Add(this.BotonAgregarValor);
                        this.PanelValores.Controls.Add(this.BotonQuitarValor);
                        this.PanelValores.Controls.Add(this.Label4);
                        this.PanelValores.Controls.Add(this.EtiquetaValoresImporte);
                        this.PanelValores.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.PanelValores.Location = new System.Drawing.Point(381, 3);
                        this.PanelValores.Name = "PanelValores";
                        this.PanelValores.Size = new System.Drawing.Size(372, 359);
                        this.PanelValores.TabIndex = 1;
                        this.PanelValores.Text = "Valores";
                        // 
                        // LabelAgregarValores
                        // 
                        this.LabelAgregarValores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelAgregarValores.BackColor = System.Drawing.SystemColors.Info;
                        this.LabelAgregarValores.ForeColor = System.Drawing.SystemColors.InfoText;
                        this.LabelAgregarValores.Location = new System.Drawing.Point(4, 56);
                        this.LabelAgregarValores.Margin = new System.Windows.Forms.Padding(0);
                        this.LabelAgregarValores.Name = "LabelAgregarValores";
                        this.LabelAgregarValores.Padding = new System.Windows.Forms.Padding(12);
                        this.LabelAgregarValores.Size = new System.Drawing.Size(364, 244);
                        this.LabelAgregarValores.TabIndex = 19;
                        this.LabelAgregarValores.Text = "Seleccione uno o más valores (pagos) que componen este recibo.";
                        this.LabelAgregarValores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.LabelAgregarValores.Click += new System.EventHandler(this.LabelAgregarValores_Click);
                        // 
                        // ListaValores
                        // 
                        this.ListaValores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaValores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValoresTipoPagoId,
            this.ValoresTipoPago,
            this.ValoresImporte,
            this.ValoresObs});
                        this.ListaValores.FullRowSelect = true;
                        this.ListaValores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaValores.HideSelection = false;
                        this.ListaValores.Location = new System.Drawing.Point(0, 28);
                        this.ListaValores.MultiSelect = false;
                        this.ListaValores.Name = "ListaValores";
                        this.ListaValores.Size = new System.Drawing.Size(372, 292);
                        this.ListaValores.TabIndex = 15;
                        this.ListaValores.UseCompatibleStateImageBehavior = false;
                        this.ListaValores.View = System.Windows.Forms.View.Details;
                        this.ListaValores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaValores_KeyDown);
                        // 
                        // ValoresTipoPagoId
                        // 
                        this.ValoresTipoPagoId.Text = "TipoPago";
                        this.ValoresTipoPagoId.Width = 0;
                        // 
                        // ValoresTipoPago
                        // 
                        this.ValoresTipoPago.Text = "Tipo";
                        this.ValoresTipoPago.Width = 160;
                        // 
                        // ValoresImporte
                        // 
                        this.ValoresImporte.Text = "Importe";
                        this.ValoresImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ValoresImporte.Width = 96;
                        // 
                        // ValoresObs
                        // 
                        this.ValoresObs.Text = "Obs";
                        this.ValoresObs.Width = 500;
                        // 
                        // BotonAgregarValor
                        // 
                        this.BotonAgregarValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAgregarValor.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregarValor.Image = null;
                        this.BotonAgregarValor.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregarValor.Location = new System.Drawing.Point(0, 328);
                        this.BotonAgregarValor.Name = "BotonAgregarValor";
                        this.BotonAgregarValor.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregarValor.ReadOnly = false;
                        this.BotonAgregarValor.Size = new System.Drawing.Size(100, 31);
                        this.BotonAgregarValor.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAgregarValor.Subtext = "F4";
                        this.BotonAgregarValor.TabIndex = 16;
                        this.BotonAgregarValor.Text = "Agregar";
                        this.BotonAgregarValor.Click += new System.EventHandler(this.BotonValoresAgregar_Click);
                        // 
                        // BotonQuitarValor
                        // 
                        this.BotonQuitarValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonQuitarValor.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarValor.Image = null;
                        this.BotonQuitarValor.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarValor.Location = new System.Drawing.Point(108, 328);
                        this.BotonQuitarValor.Name = "BotonQuitarValor";
                        this.BotonQuitarValor.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarValor.ReadOnly = false;
                        this.BotonQuitarValor.Size = new System.Drawing.Size(100, 31);
                        this.BotonQuitarValor.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonQuitarValor.Subtext = "F5";
                        this.BotonQuitarValor.TabIndex = 17;
                        this.BotonQuitarValor.Text = "Quitar";
                        this.BotonQuitarValor.Click += new System.EventHandler(this.BotonValoresQuitar_Click);
                        // 
                        // Label4
                        // 
                        this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.Label4.Location = new System.Drawing.Point(0, 0);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(372, 20);
                        this.Label4.TabIndex = 14;
                        this.Label4.Text = "Y está compuesto por los siguientes valores:";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaValoresImporte
                        // 
                        this.EtiquetaValoresImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaValoresImporte.LabelStyle = Lui.Forms.LabelStyles.Bigger;
                        this.EtiquetaValoresImporte.Location = new System.Drawing.Point(260, 328);
                        this.EtiquetaValoresImporte.Name = "EtiquetaValoresImporte";
                        this.EtiquetaValoresImporte.Size = new System.Drawing.Size(112, 31);
                        this.EtiquetaValoresImporte.TabIndex = 18;
                        this.EtiquetaValoresImporte.Text = "$ 0.00";
                        this.EtiquetaValoresImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(512, 44);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(52, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "Cliente";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoNav = true;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.ExtraDetailFields = "";
                        this.EntradaCliente.FieldName = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.Location = new System.Drawing.Point(564, 44);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.PlaceholderText = null;
                        this.EntradaCliente.ReadOnly = false;
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(192, 24);
                        this.EntradaCliente.TabIndex = 7;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTitulo.LabelStyle = Lui.Forms.LabelStyles.Header1;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(756, 40);
                        this.EtiquetaTitulo.TabIndex = 0;
                        this.EtiquetaTitulo.Text = "Recibo";
                        this.EtiquetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaConceptoTexto
                        // 
                        this.EntradaConceptoTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConceptoTexto.AutoNav = true;
                        this.EntradaConceptoTexto.AutoTab = true;
                        this.EntradaConceptoTexto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaConceptoTexto.DecimalPlaces = -1;
                        this.EntradaConceptoTexto.FieldName = null;
                        this.EntradaConceptoTexto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaConceptoTexto.Location = new System.Drawing.Point(84, 72);
                        this.EntradaConceptoTexto.MaxLength = 32767;
                        this.EntradaConceptoTexto.MultiLine = false;
                        this.EntradaConceptoTexto.Name = "EntradaConceptoTexto";
                        this.EntradaConceptoTexto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConceptoTexto.PasswordChar = '\0';
                        this.EntradaConceptoTexto.PlaceholderText = null;
                        this.EntradaConceptoTexto.Prefijo = "";
                        this.EntradaConceptoTexto.ReadOnly = false;
                        this.EntradaConceptoTexto.SelectOnFocus = true;
                        this.EntradaConceptoTexto.Size = new System.Drawing.Size(344, 24);
                        this.EntradaConceptoTexto.Sufijo = "";
                        this.EntradaConceptoTexto.TabIndex = 9;
                        // 
                        // label6
                        // 
                        this.label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label6.Location = new System.Drawing.Point(0, 72);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(84, 24);
                        this.label6.TabIndex = 8;
                        this.label6.Text = "Descipción";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // TablaCentral
                        // 
                        this.TablaCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.TablaCentral.ColumnCount = 2;
                        this.TablaCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        this.TablaCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        this.TablaCentral.Controls.Add(this.PanelValores, 1, 0);
                        this.TablaCentral.Controls.Add(this.PanelComprob, 0, 0);
                        this.TablaCentral.Location = new System.Drawing.Point(0, 108);
                        this.TablaCentral.Name = "TablaCentral";
                        this.TablaCentral.RowCount = 1;
                        this.TablaCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                        this.TablaCentral.Size = new System.Drawing.Size(756, 365);
                        this.TablaCentral.TabIndex = 10;
                        // 
                        // PanelComprob
                        // 
                        this.PanelComprob.Controls.Add(this.LabelAgregarFacturas);
                        this.PanelComprob.Controls.Add(this.Label3);
                        this.PanelComprob.Controls.Add(this.ListaFacturas);
                        this.PanelComprob.Controls.Add(this.EtiquetaFacturasImporte);
                        this.PanelComprob.Controls.Add(this.BotonQuitarFactura);
                        this.PanelComprob.Controls.Add(this.BotonAgregarFactura);
                        this.PanelComprob.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.PanelComprob.Location = new System.Drawing.Point(3, 3);
                        this.PanelComprob.Name = "PanelComprob";
                        this.PanelComprob.Size = new System.Drawing.Size(372, 359);
                        this.PanelComprob.TabIndex = 2;
                        // 
                        // LabelAgregarFacturas
                        // 
                        this.LabelAgregarFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelAgregarFacturas.BackColor = System.Drawing.SystemColors.Info;
                        this.LabelAgregarFacturas.ForeColor = System.Drawing.SystemColors.InfoText;
                        this.LabelAgregarFacturas.Location = new System.Drawing.Point(4, 56);
                        this.LabelAgregarFacturas.Margin = new System.Windows.Forms.Padding(0);
                        this.LabelAgregarFacturas.Name = "LabelAgregarFacturas";
                        this.LabelAgregarFacturas.Padding = new System.Windows.Forms.Padding(12);
                        this.LabelAgregarFacturas.Size = new System.Drawing.Size(364, 244);
                        this.LabelAgregarFacturas.TabIndex = 13;
                        this.LabelAgregarFacturas.Text = resources.GetString("LabelAgregarFacturas.Text");
                        this.LabelAgregarFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.LabelAgregarFacturas.Click += new System.EventHandler(this.LabelAgregarFacturas_Click);
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.FieldName = null;
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.Location = new System.Drawing.Point(76, 44);
                        this.EntradaPV.MaxLength = 32767;
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
                        this.EntradaPV.TabIndex = 2;
                        // 
                        // label7
                        // 
                        this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.label7.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label7.Location = new System.Drawing.Point(440, 72);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(76, 24);
                        this.label7.TabIndex = 10;
                        this.label7.Text = "Concepto";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoNav = true;
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.DataTextField = "nombre";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.ExtraDetailFields = "";
                        this.EntradaConcepto.FieldName = null;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.FreeTextCode = "";
                        this.EntradaConcepto.Location = new System.Drawing.Point(516, 72);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.PlaceholderText = "Sin especificar";
                        this.EntradaConcepto.ReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.Size = new System.Drawing.Size(240, 24);
                        this.EntradaConcepto.TabIndex = 11;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaConcepto);
                        this.Controls.Add(this.EntradaConceptoTexto);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.TablaCentral);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.EntradaCliente);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EntradaVendedor);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(756, 474);
                        this.Controls.SetChildIndex(this.EntradaVendedor, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.TablaCentral, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.EntradaPV, 0);
                        this.Controls.SetChildIndex(this.EntradaConceptoTexto, 0);
                        this.Controls.SetChildIndex(this.EntradaConcepto, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.PanelValores.ResumeLayout(false);
                        this.TablaCentral.ResumeLayout(false);
                        this.PanelComprob.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }


                #endregion

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.IContainer components = null;
                private Lui.Forms.Label Label3;
                private Lui.Forms.Label Label1;
                private Lcc.Entrada.CodigoDetalle EntradaVendedor;
                private Lui.Forms.Label Label2;
                private Lui.Forms.TextBox EntradaNumero;
                private Lui.Forms.ListView ListaFacturas;
                private Lui.Forms.Button BotonAgregarFactura;
                private System.Windows.Forms.Panel PanelValores;
                private Lui.Forms.ListView ListaValores;
                private Lui.Forms.Label EtiquetaFacturasImporte;
                private Lui.Forms.Button BotonQuitarFactura;
                private Lui.Forms.Label EtiquetaValoresImporte;
                private Lui.Forms.Button BotonAgregarValor;
                private Lui.Forms.Button BotonQuitarValor;
                private System.Windows.Forms.ColumnHeader FacturasId;
                private System.Windows.Forms.ColumnHeader FacturasNumero;
                private System.Windows.Forms.ColumnHeader FacturasFecha;
                private System.Windows.Forms.ColumnHeader FacturasPendiente;
                private System.Windows.Forms.ColumnHeader FacturasCliente;
                private System.Windows.Forms.ColumnHeader ValoresTipoPagoId;
                private System.Windows.Forms.ColumnHeader ValoresTipoPago;
                private System.Windows.Forms.ColumnHeader ValoresImporte;
                private System.Windows.Forms.ColumnHeader ValoresObs;
                private System.Windows.Forms.ColumnHeader FacturasImporte;
                private Lui.Forms.Label Label4;
                private Lui.Forms.Label Label5;
                private Lcc.Entrada.CodigoDetalle EntradaCliente;
                private Lui.Forms.Label EtiquetaTitulo;
                private Lui.Forms.TextBox EntradaConceptoTexto;
                private TableLayoutPanel TablaCentral;
                private Lui.Forms.TextBox EntradaPV;
                private Lcc.Entrada.CodigoDetalle EntradaConcepto;
                private Lui.Forms.Label label6;
                private Lui.Forms.Label label7;
                private Panel PanelComprob;
                private Label LabelAgregarValores;
                private Label LabelAgregarFacturas;

        }
}
