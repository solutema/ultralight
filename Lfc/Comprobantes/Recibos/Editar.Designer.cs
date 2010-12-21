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
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.frmFacturas = new Lui.Forms.Frame();
                        this.ListaFacturas = new Lui.Forms.ListView();
                        this.FacturasId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasPendiente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.FacturasCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EtiquetaFacturasImporte = new System.Windows.Forms.Label();
                        this.BotonAgregarFactura = new Lui.Forms.Button();
                        this.BotonQuitarFactura = new Lui.Forms.Button();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.ListaValores = new Lui.Forms.ListView();
                        this.ValoresTipoPagoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ValoresTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ValoresImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ValoresObs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.BotonAgregarValor = new Lui.Forms.Button();
                        this.BotonQuitarValor = new Lui.Forms.Button();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EtiquetaValoresImporte = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.EtiquetaTitulo = new System.Windows.Forms.Label();
                        this.EntradaConceptoTexto = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.TablaCentral = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.frmFacturas.SuspendLayout();
                        this.Frame1.SuspendLayout();
                        this.TablaCentral.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(8, 28);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(296, 16);
                        this.Label3.TabIndex = 8;
                        this.Label3.Text = "Este recibo cancela las siguientes comprob:";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
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
                        this.EntradaVendedor.ExtraDetailFields = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.Location = new System.Drawing.Point(304, 44);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.Required = true;
                        this.EntradaVendedor.Size = new System.Drawing.Size(200, 24);
                        this.EntradaVendedor.TabIndex = 5;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        this.EntradaVendedor.TipWhenBlank = "";
                        this.EntradaVendedor.ToolTipText = "";
                        // 
                        // Label2
                        // 
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
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(112, 44);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(100, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 3;
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        // 
                        // frmFacturas
                        // 
                        this.frmFacturas.Controls.Add(this.Label3);
                        this.frmFacturas.Controls.Add(this.ListaFacturas);
                        this.frmFacturas.Controls.Add(this.EtiquetaFacturasImporte);
                        this.frmFacturas.Controls.Add(this.BotonAgregarFactura);
                        this.frmFacturas.Controls.Add(this.BotonQuitarFactura);
                        this.frmFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.frmFacturas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.frmFacturas.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.frmFacturas.Location = new System.Drawing.Point(7, 7);
                        this.frmFacturas.Name = "frmFacturas";
                        this.frmFacturas.Padding = new System.Windows.Forms.Padding(2);
                        this.frmFacturas.Size = new System.Drawing.Size(368, 350);
                        this.frmFacturas.TabIndex = 0;
                        this.frmFacturas.TabStop = false;
                        this.frmFacturas.Text = "Facturas";
                        this.frmFacturas.ToolTipText = "";
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
                        this.ListaFacturas.GridLines = true;
                        this.ListaFacturas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaFacturas.HideSelection = false;
                        this.ListaFacturas.Location = new System.Drawing.Point(8, 48);
                        this.ListaFacturas.MultiSelect = false;
                        this.ListaFacturas.Name = "ListaFacturas";
                        this.ListaFacturas.Size = new System.Drawing.Size(352, 264);
                        this.ListaFacturas.Sorting = System.Windows.Forms.SortOrder.Ascending;
                        this.ListaFacturas.TabIndex = 9;
                        this.ListaFacturas.UseCompatibleStateImageBehavior = false;
                        this.ListaFacturas.View = System.Windows.Forms.View.Details;
                        this.ListaFacturas.GotFocus += new System.EventHandler(this.ListaFacturas_GotFocus);
                        this.ListaFacturas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFacturas_KeyDown);
                        this.ListaFacturas.LostFocus += new System.EventHandler(this.ListaFacturas_LostFocus);
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
                        this.EtiquetaFacturasImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaFacturasImporte.Location = new System.Drawing.Point(248, 322);
                        this.EtiquetaFacturasImporte.Name = "EtiquetaFacturasImporte";
                        this.EtiquetaFacturasImporte.Size = new System.Drawing.Size(112, 24);
                        this.EtiquetaFacturasImporte.TabIndex = 12;
                        this.EtiquetaFacturasImporte.Text = "$ 0.00";
                        this.EtiquetaFacturasImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // BotonAgregarFactura
                        // 
                        this.BotonAgregarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAgregarFactura.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregarFactura.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAgregarFactura.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAgregarFactura.Image = null;
                        this.BotonAgregarFactura.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregarFactura.Location = new System.Drawing.Point(8, 320);
                        this.BotonAgregarFactura.Name = "BotonAgregarFactura";
                        this.BotonAgregarFactura.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregarFactura.Size = new System.Drawing.Size(84, 28);
                        this.BotonAgregarFactura.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAgregarFactura.Subtext = "F2";
                        this.BotonAgregarFactura.TabIndex = 10;
                        this.BotonAgregarFactura.Text = "Agregar";
                        this.BotonAgregarFactura.ToolTipText = "";
                        this.BotonAgregarFactura.Click += new System.EventHandler(this.BotonFacturasAgregar_Click);
                        // 
                        // BotonQuitarFactura
                        // 
                        this.BotonQuitarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonQuitarFactura.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarFactura.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitarFactura.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitarFactura.Image = null;
                        this.BotonQuitarFactura.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarFactura.Location = new System.Drawing.Point(96, 320);
                        this.BotonQuitarFactura.Name = "BotonQuitarFactura";
                        this.BotonQuitarFactura.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarFactura.Size = new System.Drawing.Size(84, 28);
                        this.BotonQuitarFactura.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonQuitarFactura.Subtext = "F3";
                        this.BotonQuitarFactura.TabIndex = 11;
                        this.BotonQuitarFactura.Text = "Quitar";
                        this.BotonQuitarFactura.ToolTipText = "";
                        this.BotonQuitarFactura.Visible = false;
                        this.BotonQuitarFactura.Click += new System.EventHandler(this.BotonFacturasQuitar_Click);
                        // 
                        // Frame1
                        // 
                        this.Frame1.Controls.Add(this.ListaValores);
                        this.Frame1.Controls.Add(this.BotonAgregarValor);
                        this.Frame1.Controls.Add(this.BotonQuitarValor);
                        this.Frame1.Controls.Add(this.Label4);
                        this.Frame1.Controls.Add(this.EtiquetaValoresImporte);
                        this.Frame1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame1.Location = new System.Drawing.Point(381, 7);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.Size = new System.Drawing.Size(368, 350);
                        this.Frame1.TabIndex = 1;
                        this.Frame1.TabStop = false;
                        this.Frame1.Text = "Valores";
                        this.Frame1.ToolTipText = "";
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
                        this.ListaValores.GridLines = true;
                        this.ListaValores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaValores.Location = new System.Drawing.Point(8, 48);
                        this.ListaValores.MultiSelect = false;
                        this.ListaValores.Name = "ListaValores";
                        this.ListaValores.Size = new System.Drawing.Size(352, 264);
                        this.ListaValores.TabIndex = 15;
                        this.ListaValores.UseCompatibleStateImageBehavior = false;
                        this.ListaValores.View = System.Windows.Forms.View.Details;
                        this.ListaValores.GotFocus += new System.EventHandler(this.ListaValores_GotFocus);
                        this.ListaValores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaValores_KeyDown);
                        this.ListaValores.LostFocus += new System.EventHandler(this.ListaValores_LostFocus);
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
                        this.BotonAgregarValor.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAgregarValor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAgregarValor.Image = null;
                        this.BotonAgregarValor.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregarValor.Location = new System.Drawing.Point(8, 320);
                        this.BotonAgregarValor.Name = "BotonAgregarValor";
                        this.BotonAgregarValor.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregarValor.Size = new System.Drawing.Size(84, 28);
                        this.BotonAgregarValor.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAgregarValor.Subtext = "F4";
                        this.BotonAgregarValor.TabIndex = 16;
                        this.BotonAgregarValor.Text = "Agregar";
                        this.BotonAgregarValor.ToolTipText = "";
                        this.BotonAgregarValor.Click += new System.EventHandler(this.BotonValoresAgregar_Click);
                        // 
                        // BotonQuitarValor
                        // 
                        this.BotonQuitarValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonQuitarValor.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarValor.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitarValor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitarValor.Image = null;
                        this.BotonQuitarValor.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarValor.Location = new System.Drawing.Point(96, 320);
                        this.BotonQuitarValor.Name = "BotonQuitarValor";
                        this.BotonQuitarValor.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarValor.Size = new System.Drawing.Size(84, 28);
                        this.BotonQuitarValor.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonQuitarValor.Subtext = "F5";
                        this.BotonQuitarValor.TabIndex = 17;
                        this.BotonQuitarValor.Text = "Quitar";
                        this.BotonQuitarValor.ToolTipText = "";
                        this.BotonQuitarValor.Click += new System.EventHandler(this.BotonValoresQuitar_Click);
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Location = new System.Drawing.Point(8, 28);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(348, 16);
                        this.Label4.TabIndex = 14;
                        this.Label4.Text = "Y está compuesto por los siguientes valores:";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaValoresImporte
                        // 
                        this.EtiquetaValoresImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaValoresImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaValoresImporte.Location = new System.Drawing.Point(248, 322);
                        this.EtiquetaValoresImporte.Name = "EtiquetaValoresImporte";
                        this.EtiquetaValoresImporte.Size = new System.Drawing.Size(112, 24);
                        this.EtiquetaValoresImporte.TabIndex = 18;
                        this.EtiquetaValoresImporte.Text = "$ 0.00";
                        this.EtiquetaValoresImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Label5
                        // 
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
                        this.EntradaCliente.ExtraDetailFields = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(564, 44);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.Required = true;
                        this.EntradaCliente.Size = new System.Drawing.Size(192, 24);
                        this.EntradaCliente.TabIndex = 7;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TipWhenBlank = "";
                        this.EntradaCliente.ToolTipText = "";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EtiquetaTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
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
                        this.EntradaConceptoTexto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaConceptoTexto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaConceptoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaConceptoTexto.Location = new System.Drawing.Point(84, 72);
                        this.EntradaConceptoTexto.MaxLenght = 32767;
                        this.EntradaConceptoTexto.MultiLine = false;
                        this.EntradaConceptoTexto.Name = "EntradaConceptoTexto";
                        this.EntradaConceptoTexto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConceptoTexto.PasswordChar = '\0';
                        this.EntradaConceptoTexto.Prefijo = "";
                        this.EntradaConceptoTexto.SelectOnFocus = true;
                        this.EntradaConceptoTexto.Size = new System.Drawing.Size(344, 24);
                        this.EntradaConceptoTexto.Sufijo = "";
                        this.EntradaConceptoTexto.TabIndex = 9;
                        this.EntradaConceptoTexto.TipWhenBlank = "";
                        this.EntradaConceptoTexto.ToolTipText = "";
                        // 
                        // label6
                        // 
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
                        this.TablaCentral.Controls.Add(this.frmFacturas, 0, 0);
                        this.TablaCentral.Controls.Add(this.Frame1, 1, 0);
                        this.TablaCentral.Location = new System.Drawing.Point(0, 108);
                        this.TablaCentral.Margin = new System.Windows.Forms.Padding(4);
                        this.TablaCentral.Name = "TablaCentral";
                        this.TablaCentral.Padding = new System.Windows.Forms.Padding(4);
                        this.TablaCentral.RowCount = 1;
                        this.TablaCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                        this.TablaCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
                        this.TablaCentral.Size = new System.Drawing.Size(756, 364);
                        this.TablaCentral.TabIndex = 10;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(76, 44);
                        this.EntradaPV.MaxLenght = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(32, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 2;
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
                        this.EntradaConcepto.ExtraDetailFields = null;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConcepto.FreeTextCode = "";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(516, 72);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.Size = new System.Drawing.Size(240, 24);
                        this.EntradaConcepto.TabIndex = 11;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        this.EntradaConcepto.TipWhenBlank = "Sin especificar";
                        this.EntradaConcepto.ToolTipText = "";
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
                        this.Size = new System.Drawing.Size(756, 473);
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
                        this.frmFacturas.ResumeLayout(false);
                        this.frmFacturas.PerformLayout();
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.TablaCentral.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }


                #endregion

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.IContainer components = null;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lui.Forms.Frame frmFacturas;
                internal Lui.Forms.ListView ListaFacturas;
                internal Lui.Forms.Button BotonAgregarFactura;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.ListView ListaValores;
                internal System.Windows.Forms.Label EtiquetaFacturasImporte;
                internal Lui.Forms.Button BotonQuitarFactura;
                internal System.Windows.Forms.Label EtiquetaValoresImporte;
                internal Lui.Forms.Button BotonAgregarValor;
                internal Lui.Forms.Button BotonQuitarValor;
                internal System.Windows.Forms.ColumnHeader FacturasId;
                internal System.Windows.Forms.ColumnHeader FacturasNumero;
                internal System.Windows.Forms.ColumnHeader FacturasFecha;
                internal System.Windows.Forms.ColumnHeader FacturasPendiente;
                internal System.Windows.Forms.ColumnHeader FacturasCliente;
                internal System.Windows.Forms.ColumnHeader ValoresTipoPagoId;
                internal System.Windows.Forms.ColumnHeader ValoresTipoPago;
                internal System.Windows.Forms.ColumnHeader ValoresImporte;
                internal System.Windows.Forms.ColumnHeader ValoresObs;
                internal System.Windows.Forms.ColumnHeader FacturasImporte;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label5;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                private System.Windows.Forms.Label EtiquetaTitulo;
                internal Lui.Forms.TextBox EntradaConceptoTexto;
                internal Label label6;
                private TableLayoutPanel TablaCentral;
                internal Lui.Forms.TextBox EntradaPV;
                internal Label label7;
                internal Lcc.Entrada.CodigoDetalle EntradaConcepto;

        }
}
