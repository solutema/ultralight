#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lcc.Edicion.Comprobantes
{
        partial class Pago
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
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.PanelImporte = new System.Windows.Forms.Panel();
                        this.PanelChequePropio = new System.Windows.Forms.Panel();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaFechaCobro = new Lui.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaFechaEmision = new Lui.Forms.TextBox();
                        this.EntradaNumeroCheque = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.PanelTitulo = new System.Windows.Forms.Panel();
                        this.FrameTitulo = new Lui.Forms.Frame();
                        this.PanelCaja = new System.Windows.Forms.Panel();
                        this.label9 = new System.Windows.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.PanelEfectivo = new System.Windows.Forms.Panel();
                        this.label8 = new System.Windows.Forms.Label();
                        this.PanelTarjeta = new System.Windows.Forms.Panel();
                        this.EntradaAutorizacion = new Lui.Forms.TextBox();
                        this.EntradaCupon = new Lui.Forms.TextBox();
                        this.EntradaInteres = new Lui.Forms.TextBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.EntradaCuotas = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaPlan = new Lcc.Entrada.CodigoDetalle();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.PanelObs = new System.Windows.Forms.Panel();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label20 = new System.Windows.Forms.Label();
                        this.PanelCuentaCorriente = new System.Windows.Forms.Panel();
                        this.label7 = new System.Windows.Forms.Label();
                        this.PanelFormaDePago = new System.Windows.Forms.Panel();
                        this.EntradaFormaDePago = new Lcc.Entrada.CodigoDetalle();
                        this.label13 = new System.Windows.Forms.Label();
                        this.label12 = new System.Windows.Forms.Label();
                        this.PanelSeparadorInferior = new System.Windows.Forms.Panel();
                        this.PanelChequeTerceros = new System.Windows.Forms.Panel();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaChequeTerceros = new Lcc.Entrada.CodigoDetalle();
                        this.PanelValor = new System.Windows.Forms.Panel();
                        this.EtiquetaPagoConValor = new System.Windows.Forms.Label();
                        this.EntradaValor = new Lcc.Entrada.CodigoDetalle();
                        this.PanelImporte.SuspendLayout();
                        this.PanelChequePropio.SuspendLayout();
                        this.PanelTitulo.SuspendLayout();
                        this.PanelCaja.SuspendLayout();
                        this.PanelEfectivo.SuspendLayout();
                        this.PanelTarjeta.SuspendLayout();
                        this.PanelObs.SuspendLayout();
                        this.PanelCuentaCorriente.SuspendLayout();
                        this.PanelFormaDePago.SuspendLayout();
                        this.PanelChequeTerceros.SuspendLayout();
                        this.PanelValor.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaImporte.Location = new System.Drawing.Point(140, 0);
                        this.EntradaImporte.MaxLenght = 32767;
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.PasswordChar = '\0';
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.TemporaryReadOnly = false;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(116, 24);
                        this.EntradaImporte.Sufijo = "";
                        this.EntradaImporte.TabIndex = 1;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TipWhenBlank = "";
                        this.EntradaImporte.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(0, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(136, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Importe";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelImporte
                        // 
                        this.PanelImporte.Controls.Add(this.EntradaImporte);
                        this.PanelImporte.Controls.Add(this.label1);
                        this.PanelImporte.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelImporte.Location = new System.Drawing.Point(0, 66);
                        this.PanelImporte.Name = "PanelImporte";
                        this.PanelImporte.Size = new System.Drawing.Size(460, 30);
                        this.PanelImporte.TabIndex = 2;
                        // 
                        // PanelChequePropio
                        // 
                        this.PanelChequePropio.Controls.Add(this.label2);
                        this.PanelChequePropio.Controls.Add(this.EntradaFechaCobro);
                        this.PanelChequePropio.Controls.Add(this.label3);
                        this.PanelChequePropio.Controls.Add(this.label6);
                        this.PanelChequePropio.Controls.Add(this.EntradaFechaEmision);
                        this.PanelChequePropio.Controls.Add(this.EntradaNumeroCheque);
                        this.PanelChequePropio.Controls.Add(this.lblFecha1);
                        this.PanelChequePropio.Controls.Add(this.EntradaBanco);
                        this.PanelChequePropio.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelChequePropio.Location = new System.Drawing.Point(0, 128);
                        this.PanelChequePropio.Name = "PanelChequePropio";
                        this.PanelChequePropio.Size = new System.Drawing.Size(460, 134);
                        this.PanelChequePropio.TabIndex = 4;
                        this.PanelChequePropio.Visible = false;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(136, 24);
                        this.label2.TabIndex = 0;
                        this.label2.Text = "Banco";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaCobro
                        // 
                        this.EntradaFechaCobro.AutoNav = true;
                        this.EntradaFechaCobro.AutoTab = true;
                        this.EntradaFechaCobro.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaCobro.DecimalPlaces = -1;
                        this.EntradaFechaCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechaCobro.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaCobro.Location = new System.Drawing.Point(140, 96);
                        this.EntradaFechaCobro.MaxLenght = 32767;
                        this.EntradaFechaCobro.MultiLine = false;
                        this.EntradaFechaCobro.Name = "EntradaFechaCobro";
                        this.EntradaFechaCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaCobro.PasswordChar = '\0';
                        this.EntradaFechaCobro.Prefijo = "";
                        this.EntradaFechaCobro.TemporaryReadOnly = false;
                        this.EntradaFechaCobro.SelectOnFocus = true;
                        this.EntradaFechaCobro.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaCobro.Sufijo = "";
                        this.EntradaFechaCobro.TabIndex = 7;
                        this.EntradaFechaCobro.TipWhenBlank = "";
                        this.EntradaFechaCobro.ToolTipText = "";
                        this.EntradaFechaCobro.Enter += new System.EventHandler(this.EntradaFechaCobro_Enter);
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(0, 32);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(136, 24);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "Número";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(0, 96);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(140, 24);
                        this.label6.TabIndex = 6;
                        this.label6.Text = "Fecha de cobro";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaEmision
                        // 
                        this.EntradaFechaEmision.AutoNav = true;
                        this.EntradaFechaEmision.AutoTab = true;
                        this.EntradaFechaEmision.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaEmision.DecimalPlaces = -1;
                        this.EntradaFechaEmision.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechaEmision.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaEmision.Location = new System.Drawing.Point(140, 64);
                        this.EntradaFechaEmision.MaxLenght = 32767;
                        this.EntradaFechaEmision.MultiLine = false;
                        this.EntradaFechaEmision.Name = "EntradaFechaEmision";
                        this.EntradaFechaEmision.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaEmision.PasswordChar = '\0';
                        this.EntradaFechaEmision.Prefijo = "";
                        this.EntradaFechaEmision.TemporaryReadOnly = false;
                        this.EntradaFechaEmision.SelectOnFocus = true;
                        this.EntradaFechaEmision.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaEmision.Sufijo = "";
                        this.EntradaFechaEmision.TabIndex = 5;
                        this.EntradaFechaEmision.TipWhenBlank = "";
                        this.EntradaFechaEmision.ToolTipText = "";
                        this.EntradaFechaEmision.Enter += new System.EventHandler(this.EntradaFechaEmision_Enter);
                        // 
                        // EntradaNumeroCheque
                        // 
                        this.EntradaNumeroCheque.AutoSize = false;
                        this.EntradaNumeroCheque.AutoNav = true;
                        this.EntradaNumeroCheque.AutoTab = true;
                        this.EntradaNumeroCheque.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaNumeroCheque.DecimalPlaces = -1;
                        this.EntradaNumeroCheque.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaNumeroCheque.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumeroCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumeroCheque.Location = new System.Drawing.Point(140, 32);
                        this.EntradaNumeroCheque.MaxLenght = 32767;
                        this.EntradaNumeroCheque.MultiLine = false;
                        this.EntradaNumeroCheque.Name = "EntradaNumeroCheque";
                        this.EntradaNumeroCheque.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumeroCheque.PasswordChar = '\0';
                        this.EntradaNumeroCheque.Prefijo = "";
                        this.EntradaNumeroCheque.TemporaryReadOnly = false;
                        this.EntradaNumeroCheque.SelectOnFocus = true;
                        this.EntradaNumeroCheque.Size = new System.Drawing.Size(176, 24);
                        this.EntradaNumeroCheque.Sufijo = "";
                        this.EntradaNumeroCheque.TabIndex = 3;
                        this.EntradaNumeroCheque.Text = "0";
                        this.EntradaNumeroCheque.TipWhenBlank = "";
                        this.EntradaNumeroCheque.ToolTipText = "Estado para esta chequera.";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(0, 64);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(140, 24);
                        this.lblFecha1.TabIndex = 4;
                        this.lblFecha1.Text = "Fecha de emisión";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DataTextField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Filter = "";
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.DataValueField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(140, 0);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.TemporaryReadOnly = false;
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.Size = new System.Drawing.Size(320, 24);
                        this.EntradaBanco.TabIndex = 1;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TextInt = 0;
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
                        // 
                        // PanelTitulo
                        // 
                        this.PanelTitulo.Controls.Add(this.FrameTitulo);
                        this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelTitulo.Location = new System.Drawing.Point(0, 32);
                        this.PanelTitulo.Name = "PanelTitulo";
                        this.PanelTitulo.Size = new System.Drawing.Size(460, 34);
                        this.PanelTitulo.TabIndex = 1;
                        // 
                        // FrameTitulo
                        // 
                        this.FrameTitulo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.FrameTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FrameTitulo.Location = new System.Drawing.Point(0, 0);
                        this.FrameTitulo.Name = "FrameTitulo";
                        this.FrameTitulo.Padding = new System.Windows.Forms.Padding(2);
                        this.FrameTitulo.TemporaryReadOnly = false;
                        this.FrameTitulo.Size = new System.Drawing.Size(460, 32);
                        this.FrameTitulo.TabIndex = 0;
                        this.FrameTitulo.TabStop = false;
                        this.FrameTitulo.Text = "frame1";
                        this.FrameTitulo.ToolTipText = "";
                        // 
                        // PanelCaja
                        // 
                        this.PanelCaja.Controls.Add(this.label9);
                        this.PanelCaja.Controls.Add(this.EntradaCaja);
                        this.PanelCaja.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelCaja.Location = new System.Drawing.Point(0, 262);
                        this.PanelCaja.Name = "PanelCaja";
                        this.PanelCaja.Size = new System.Drawing.Size(460, 56);
                        this.PanelCaja.TabIndex = 5;
                        this.PanelCaja.Visible = false;
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(0, 0);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(440, 20);
                        this.label9.TabIndex = 0;
                        this.label9.Text = "Pago mediante débito en la siguiente cuenta";
                        // 
                        // EntradaCaja
                        // 
                        this.EntradaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DataTextField = "nombre";
                        this.EntradaCaja.ExtraDetailFields = null;
                        this.EntradaCaja.Filter = "";
                        this.EntradaCaja.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCaja.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.DataValueField = "id_caja";
                        this.EntradaCaja.Location = new System.Drawing.Point(140, 20);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.TemporaryReadOnly = false;
                        this.EntradaCaja.Required = true;
                        this.EntradaCaja.Size = new System.Drawing.Size(320, 24);
                        this.EntradaCaja.TabIndex = 1;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.TextInt = 0;
                        this.EntradaCaja.TipWhenBlank = "";
                        this.EntradaCaja.ToolTipText = "";
                        // 
                        // PanelEfectivo
                        // 
                        this.PanelEfectivo.Controls.Add(this.label8);
                        this.PanelEfectivo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelEfectivo.Location = new System.Drawing.Point(0, 318);
                        this.PanelEfectivo.Name = "PanelEfectivo";
                        this.PanelEfectivo.Size = new System.Drawing.Size(460, 32);
                        this.PanelEfectivo.TabIndex = 6;
                        this.PanelEfectivo.Visible = false;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 0);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(456, 20);
                        this.label8.TabIndex = 0;
                        this.label8.Text = "Pago en efectivo, con débito de la caja diaria.";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // PanelTarjeta
                        // 
                        this.PanelTarjeta.Controls.Add(this.EntradaAutorizacion);
                        this.PanelTarjeta.Controls.Add(this.EntradaCupon);
                        this.PanelTarjeta.Controls.Add(this.EntradaInteres);
                        this.PanelTarjeta.Controls.Add(this.Label14);
                        this.PanelTarjeta.Controls.Add(this.EntradaCuotas);
                        this.PanelTarjeta.Controls.Add(this.label4);
                        this.PanelTarjeta.Controls.Add(this.EntradaPlan);
                        this.PanelTarjeta.Controls.Add(this.Label10);
                        this.PanelTarjeta.Controls.Add(this.Label11);
                        this.PanelTarjeta.Controls.Add(this.Label15);
                        this.PanelTarjeta.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelTarjeta.Location = new System.Drawing.Point(0, 350);
                        this.PanelTarjeta.Name = "PanelTarjeta";
                        this.PanelTarjeta.Size = new System.Drawing.Size(460, 130);
                        this.PanelTarjeta.TabIndex = 7;
                        this.PanelTarjeta.Visible = false;
                        // 
                        // EntradaAutorizacion
                        // 
                        this.EntradaAutorizacion.AutoNav = true;
                        this.EntradaAutorizacion.AutoTab = true;
                        this.EntradaAutorizacion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAutorizacion.DecimalPlaces = -1;
                        this.EntradaAutorizacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaAutorizacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAutorizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaAutorizacion.Location = new System.Drawing.Point(140, 100);
                        this.EntradaAutorizacion.MaxLenght = 32767;
                        this.EntradaAutorizacion.MultiLine = false;
                        this.EntradaAutorizacion.Name = "EntradaAutorizacion";
                        this.EntradaAutorizacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAutorizacion.PasswordChar = '\0';
                        this.EntradaAutorizacion.Prefijo = "";
                        this.EntradaAutorizacion.TemporaryReadOnly = false;
                        this.EntradaAutorizacion.SelectOnFocus = true;
                        this.EntradaAutorizacion.Size = new System.Drawing.Size(164, 24);
                        this.EntradaAutorizacion.Sufijo = "";
                        this.EntradaAutorizacion.TabIndex = 11;
                        this.EntradaAutorizacion.TipWhenBlank = "";
                        this.EntradaAutorizacion.ToolTipText = "";
                        // 
                        // EntradaCupon
                        // 
                        this.EntradaCupon.AutoNav = true;
                        this.EntradaCupon.AutoTab = true;
                        this.EntradaCupon.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCupon.DecimalPlaces = -1;
                        this.EntradaCupon.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCupon.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCupon.Location = new System.Drawing.Point(140, 68);
                        this.EntradaCupon.MaxLenght = 32767;
                        this.EntradaCupon.MultiLine = false;
                        this.EntradaCupon.Name = "EntradaCupon";
                        this.EntradaCupon.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCupon.PasswordChar = '\0';
                        this.EntradaCupon.Prefijo = "";
                        this.EntradaCupon.TemporaryReadOnly = false;
                        this.EntradaCupon.SelectOnFocus = true;
                        this.EntradaCupon.Size = new System.Drawing.Size(164, 24);
                        this.EntradaCupon.Sufijo = "";
                        this.EntradaCupon.TabIndex = 9;
                        this.EntradaCupon.TipWhenBlank = "";
                        this.EntradaCupon.ToolTipText = "";
                        // 
                        // EntradaInteres
                        // 
                        this.EntradaInteres.AutoNav = true;
                        this.EntradaInteres.AutoTab = true;
                        this.EntradaInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaInteres.DecimalPlaces = -1;
                        this.EntradaInteres.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaInteres.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaInteres.Location = new System.Drawing.Point(368, 60);
                        this.EntradaInteres.MaxLenght = 32767;
                        this.EntradaInteres.MultiLine = false;
                        this.EntradaInteres.Name = "EntradaInteres";
                        this.EntradaInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaInteres.PasswordChar = '\0';
                        this.EntradaInteres.Prefijo = "";
                        this.EntradaInteres.TemporaryReadOnly = true;
                        this.EntradaInteres.SelectOnFocus = true;
                        this.EntradaInteres.Size = new System.Drawing.Size(80, 24);
                        this.EntradaInteres.Sufijo = "%";
                        this.EntradaInteres.TabIndex = 7;
                        this.EntradaInteres.TabStop = false;
                        this.EntradaInteres.Text = "0.00";
                        this.EntradaInteres.TipWhenBlank = "";
                        this.EntradaInteres.ToolTipText = "";
                        // 
                        // Label14
                        // 
                        this.Label14.Location = new System.Drawing.Point(300, 28);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(68, 24);
                        this.Label14.TabIndex = 6;
                        this.Label14.Text = "Interés";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCuotas
                        // 
                        this.EntradaCuotas.AutoNav = true;
                        this.EntradaCuotas.AutoTab = true;
                        this.EntradaCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCuotas.DecimalPlaces = -1;
                        this.EntradaCuotas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCuotas.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCuotas.Location = new System.Drawing.Point(228, 28);
                        this.EntradaCuotas.MaxLenght = 32767;
                        this.EntradaCuotas.MultiLine = false;
                        this.EntradaCuotas.Name = "EntradaCuotas";
                        this.EntradaCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuotas.PasswordChar = '\0';
                        this.EntradaCuotas.Prefijo = "";
                        this.EntradaCuotas.TemporaryReadOnly = true;
                        this.EntradaCuotas.SelectOnFocus = true;
                        this.EntradaCuotas.Size = new System.Drawing.Size(60, 24);
                        this.EntradaCuotas.Sufijo = "";
                        this.EntradaCuotas.TabIndex = 5;
                        this.EntradaCuotas.TabStop = false;
                        this.EntradaCuotas.Text = "0";
                        this.EntradaCuotas.TipWhenBlank = "";
                        this.EntradaCuotas.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(156, 28);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(72, 24);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "Cuotas";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPlan
                        // 
                        this.EntradaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPlan.AutoTab = true;
                        this.EntradaPlan.CanCreate = false;
                        this.EntradaPlan.DataTextField = "nombre";
                        this.EntradaPlan.ExtraDetailFields = null;
                        this.EntradaPlan.Filter = "";
                        this.EntradaPlan.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaPlan.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPlan.FreeTextCode = "";
                        this.EntradaPlan.DataValueField = "id_plan";
                        this.EntradaPlan.Location = new System.Drawing.Point(140, 0);
                        this.EntradaPlan.MaxLength = 200;
                        this.EntradaPlan.Name = "EntradaPlan";
                        this.EntradaPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPlan.TemporaryReadOnly = false;
                        this.EntradaPlan.Required = false;
                        this.EntradaPlan.Size = new System.Drawing.Size(320, 24);
                        this.EntradaPlan.TabIndex = 3;
                        this.EntradaPlan.Table = "tarjetas_planes";
                        this.EntradaPlan.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaPlan.Text = "0";
                        this.EntradaPlan.TextDetail = "";
                        this.EntradaPlan.TextInt = 0;
                        this.EntradaPlan.TipWhenBlank = "";
                        this.EntradaPlan.ToolTipText = "";
                        this.EntradaPlan.TextChanged += new System.EventHandler(this.EntradaPlan_TextChanged);
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(0, 100);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(136, 24);
                        this.Label10.TabIndex = 10;
                        this.Label10.Text = "Autorización";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(0, 68);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(136, 24);
                        this.Label11.TabIndex = 8;
                        this.Label11.Text = "Número de Cupón";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(0, 0);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(136, 24);
                        this.Label15.TabIndex = 2;
                        this.Label15.Text = "Plan";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelObs
                        // 
                        this.PanelObs.Controls.Add(this.EntradaObs);
                        this.PanelObs.Controls.Add(this.Label20);
                        this.PanelObs.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelObs.Location = new System.Drawing.Point(0, 592);
                        this.PanelObs.Name = "PanelObs";
                        this.PanelObs.Size = new System.Drawing.Size(460, 58);
                        this.PanelObs.TabIndex = 8;
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.Location = new System.Drawing.Point(140, 0);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = false;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.TemporaryReadOnly = false;
                        this.EntradaObs.SelectOnFocus = true;
                        this.EntradaObs.Size = new System.Drawing.Size(320, 52);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 1;
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
                        // 
                        // Label20
                        // 
                        this.Label20.Location = new System.Drawing.Point(0, 0);
                        this.Label20.Name = "Label20";
                        this.Label20.Size = new System.Drawing.Size(136, 24);
                        this.Label20.TabIndex = 0;
                        this.Label20.Text = "Observaciones";
                        this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelCuentaCorriente
                        // 
                        this.PanelCuentaCorriente.Controls.Add(this.label7);
                        this.PanelCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelCuentaCorriente.Location = new System.Drawing.Point(0, 96);
                        this.PanelCuentaCorriente.Name = "PanelCuentaCorriente";
                        this.PanelCuentaCorriente.Size = new System.Drawing.Size(460, 32);
                        this.PanelCuentaCorriente.TabIndex = 3;
                        this.PanelCuentaCorriente.Visible = false;
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(0, 0);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(456, 20);
                        this.label7.TabIndex = 0;
                        this.label7.Text = "Se va a enviar saldo a la cuenta corriente del cliente.";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // PanelFormaDePago
                        // 
                        this.PanelFormaDePago.Controls.Add(this.EntradaFormaDePago);
                        this.PanelFormaDePago.Controls.Add(this.label13);
                        this.PanelFormaDePago.Controls.Add(this.label12);
                        this.PanelFormaDePago.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelFormaDePago.Location = new System.Drawing.Point(0, 0);
                        this.PanelFormaDePago.Name = "PanelFormaDePago";
                        this.PanelFormaDePago.Size = new System.Drawing.Size(460, 32);
                        this.PanelFormaDePago.TabIndex = 0;
                        this.PanelFormaDePago.Visible = false;
                        // 
                        // EntradaFormaDePago
                        // 
                        this.EntradaFormaDePago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFormaDePago.AutoTab = true;
                        this.EntradaFormaDePago.CanCreate = true;
                        this.EntradaFormaDePago.DataTextField = "nombre";
                        this.EntradaFormaDePago.ExtraDetailFields = null;
                        this.EntradaFormaDePago.Filter = "pagos=1";
                        this.EntradaFormaDePago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFormaDePago.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFormaDePago.FreeTextCode = "";
                        this.EntradaFormaDePago.DataValueField = "id_formapago";
                        this.EntradaFormaDePago.Location = new System.Drawing.Point(136, 0);
                        this.EntradaFormaDePago.MaxLength = 200;
                        this.EntradaFormaDePago.Name = "EntradaFormaDePago";
                        this.EntradaFormaDePago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaDePago.TemporaryReadOnly = false;
                        this.EntradaFormaDePago.Required = true;
                        this.EntradaFormaDePago.Size = new System.Drawing.Size(324, 24);
                        this.EntradaFormaDePago.TabIndex = 1;
                        this.EntradaFormaDePago.Table = "formaspago";
                        this.EntradaFormaDePago.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaFormaDePago.Text = "0";
                        this.EntradaFormaDePago.TextDetail = "";
                        this.EntradaFormaDePago.TextInt = 0;
                        this.EntradaFormaDePago.TipWhenBlank = "";
                        this.EntradaFormaDePago.ToolTipText = "";
                        this.EntradaFormaDePago.TextChanged += new System.EventHandler(this.EntradaFormaDePago_TextChanged);
                        // 
                        // label13
                        // 
                        this.label13.Location = new System.Drawing.Point(0, 32);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(456, 20);
                        this.label13.TabIndex = 2;
                        this.label13.Text = "Cambie la forma de pago usando la tecla \"Barra Espaciadora\".";
                        this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label12
                        // 
                        this.label12.Location = new System.Drawing.Point(0, 0);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(136, 24);
                        this.label12.TabIndex = 0;
                        this.label12.Text = "Forma de pago";
                        this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelSeparadorInferior
                        // 
                        this.PanelSeparadorInferior.BackColor = System.Drawing.SystemColors.ControlDark;
                        this.PanelSeparadorInferior.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelSeparadorInferior.Location = new System.Drawing.Point(0, 650);
                        this.PanelSeparadorInferior.Name = "PanelSeparadorInferior";
                        this.PanelSeparadorInferior.Size = new System.Drawing.Size(460, 2);
                        this.PanelSeparadorInferior.TabIndex = 10;
                        // 
                        // PanelChequeTerceros
                        // 
                        this.PanelChequeTerceros.Controls.Add(this.label5);
                        this.PanelChequeTerceros.Controls.Add(this.EntradaChequeTerceros);
                        this.PanelChequeTerceros.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelChequeTerceros.Location = new System.Drawing.Point(0, 480);
                        this.PanelChequeTerceros.Name = "PanelChequeTerceros";
                        this.PanelChequeTerceros.Size = new System.Drawing.Size(460, 56);
                        this.PanelChequeTerceros.TabIndex = 11;
                        this.PanelChequeTerceros.Visible = false;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(440, 20);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Pago con cheque de terceros";
                        // 
                        // EntradaChequeTerceros
                        // 
                        this.EntradaChequeTerceros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaChequeTerceros.AutoTab = true;
                        this.EntradaChequeTerceros.CanCreate = true;
                        this.EntradaChequeTerceros.DataTextField = "nombre";
                        this.EntradaChequeTerceros.ExtraDetailFields = null;
                        this.EntradaChequeTerceros.Filter = "emitido=0 AND estado=0";
                        this.EntradaChequeTerceros.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaChequeTerceros.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaChequeTerceros.FreeTextCode = "";
                        this.EntradaChequeTerceros.DataValueField = "id_cheque";
                        this.EntradaChequeTerceros.Location = new System.Drawing.Point(140, 20);
                        this.EntradaChequeTerceros.MaxLength = 200;
                        this.EntradaChequeTerceros.Name = "EntradaChequeTerceros";
                        this.EntradaChequeTerceros.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaChequeTerceros.TemporaryReadOnly = false;
                        this.EntradaChequeTerceros.Required = true;
                        this.EntradaChequeTerceros.Size = new System.Drawing.Size(320, 24);
                        this.EntradaChequeTerceros.TabIndex = 1;
                        this.EntradaChequeTerceros.Table = "bancos_cheques";
                        this.EntradaChequeTerceros.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaChequeTerceros.Text = "0";
                        this.EntradaChequeTerceros.TextDetail = "";
                        this.EntradaChequeTerceros.TextInt = 0;
                        this.EntradaChequeTerceros.TipWhenBlank = "";
                        this.EntradaChequeTerceros.ToolTipText = "";
                        this.EntradaChequeTerceros.TextChanged += new System.EventHandler(this.EntradaChequeTerceros_TextChanged);
                        // 
                        // PanelValor
                        // 
                        this.PanelValor.Controls.Add(this.EtiquetaPagoConValor);
                        this.PanelValor.Controls.Add(this.EntradaValor);
                        this.PanelValor.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelValor.Location = new System.Drawing.Point(0, 536);
                        this.PanelValor.Name = "PanelValor";
                        this.PanelValor.Size = new System.Drawing.Size(460, 56);
                        this.PanelValor.TabIndex = 12;
                        this.PanelValor.Visible = false;
                        // 
                        // EtiquetaPagoConValor
                        // 
                        this.EtiquetaPagoConValor.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaPagoConValor.Name = "EtiquetaPagoConValor";
                        this.EtiquetaPagoConValor.Size = new System.Drawing.Size(440, 20);
                        this.EtiquetaPagoConValor.TabIndex = 0;
                        this.EtiquetaPagoConValor.Text = "Pago con ...";
                        // 
                        // EntradaValor
                        // 
                        this.EntradaValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaValor.AutoTab = true;
                        this.EntradaValor.CanCreate = true;
                        this.EntradaValor.DataTextField = "nombre";
                        this.EntradaValor.ExtraDetailFields = null;
                        this.EntradaValor.Filter = "estado=0";
                        this.EntradaValor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaValor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaValor.FreeTextCode = "";
                        this.EntradaValor.DataValueField = "id_valor";
                        this.EntradaValor.Location = new System.Drawing.Point(140, 20);
                        this.EntradaValor.MaxLength = 200;
                        this.EntradaValor.Name = "EntradaValor";
                        this.EntradaValor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaValor.TemporaryReadOnly = false;
                        this.EntradaValor.Required = true;
                        this.EntradaValor.Size = new System.Drawing.Size(320, 24);
                        this.EntradaValor.TabIndex = 1;
                        this.EntradaValor.Table = "pagos_valores";
                        this.EntradaValor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaValor.Text = "0";
                        this.EntradaValor.TextDetail = "";
                        this.EntradaValor.TextInt = 0;
                        this.EntradaValor.TipWhenBlank = "";
                        this.EntradaValor.ToolTipText = "";
                        this.EntradaValor.TextChanged += new System.EventHandler(this.EntradaValor_TextChanged);
                        // 
                        // Pago
                        // 
                        this.Controls.Add(this.PanelSeparadorInferior);
                        this.Controls.Add(this.PanelObs);
                        this.Controls.Add(this.PanelValor);
                        this.Controls.Add(this.PanelChequeTerceros);
                        this.Controls.Add(this.PanelTarjeta);
                        this.Controls.Add(this.PanelEfectivo);
                        this.Controls.Add(this.PanelCaja);
                        this.Controls.Add(this.PanelChequePropio);
                        this.Controls.Add(this.PanelCuentaCorriente);
                        this.Controls.Add(this.PanelImporte);
                        this.Controls.Add(this.PanelTitulo);
                        this.Controls.Add(this.PanelFormaDePago);
                        this.Name = "Pago";
                        this.Size = new System.Drawing.Size(460, 697);
                        this.PanelImporte.ResumeLayout(false);
                        this.PanelChequePropio.ResumeLayout(false);
                        this.PanelTitulo.ResumeLayout(false);
                        this.PanelCaja.ResumeLayout(false);
                        this.PanelEfectivo.ResumeLayout(false);
                        this.PanelTarjeta.ResumeLayout(false);
                        this.PanelObs.ResumeLayout(false);
                        this.PanelCuentaCorriente.ResumeLayout(false);
                        this.PanelFormaDePago.ResumeLayout(false);
                        this.PanelChequeTerceros.ResumeLayout(false);
                        this.PanelValor.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.TextBox EntradaImporte;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Panel PanelImporte;
                private System.Windows.Forms.Panel PanelChequePropio;
                private System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaCobro;
                private System.Windows.Forms.Label label3;
                internal System.Windows.Forms.Label label6;
                public Lui.Forms.TextBox EntradaFechaEmision;
                internal Lui.Forms.TextBox EntradaNumeroCheque;
                internal System.Windows.Forms.Label lblFecha1;
                private System.Windows.Forms.Panel PanelTitulo;
                private Lui.Forms.Frame FrameTitulo;
                private System.Windows.Forms.Panel PanelCaja;
                private System.Windows.Forms.Panel PanelEfectivo;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Panel PanelTarjeta;
                public Lui.Forms.TextBox EntradaAutorizacion;
                public Lui.Forms.TextBox EntradaCupon;
                public Lui.Forms.TextBox EntradaInteres;
                internal System.Windows.Forms.Label Label14;
                public Lui.Forms.TextBox EntradaCuotas;
                internal System.Windows.Forms.Label label4;
                public Lcc.Entrada.CodigoDetalle EntradaPlan;
                internal System.Windows.Forms.Label Label10;
                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label Label15;
                private System.Windows.Forms.Panel PanelObs;
                private System.Windows.Forms.Label label9;
                public Lui.Forms.TextBox EntradaObs;
                internal System.Windows.Forms.Label Label20;
                private System.Windows.Forms.Panel PanelCuentaCorriente;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.Panel PanelFormaDePago;
                private System.Windows.Forms.Label label13;
                private System.Windows.Forms.Label label12;
                private System.Windows.Forms.Panel PanelSeparadorInferior;
                public Lcc.Entrada.CodigoDetalle EntradaCaja;
                public Lcc.Entrada.CodigoDetalle EntradaBanco;
                internal Lcc.Entrada.CodigoDetalle EntradaFormaDePago;
                private System.Windows.Forms.Panel PanelChequeTerceros;
                private System.Windows.Forms.Label label5;
                public Lcc.Entrada.CodigoDetalle EntradaChequeTerceros;
                private System.Windows.Forms.Panel PanelValor;
                private System.Windows.Forms.Label EtiquetaPagoConValor;
                public Lcc.Entrada.CodigoDetalle EntradaValor;
        }
}
