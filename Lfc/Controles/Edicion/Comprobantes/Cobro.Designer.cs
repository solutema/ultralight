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

namespace Lfc.Controles.Edicion.Comprobantes
{
        partial class Cobro
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
                        this.PanelCheque = new System.Windows.Forms.Panel();
                        this.EntradaEmisor = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaFechaCobro = new Lui.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaFechaEmision = new Lui.Forms.TextBox();
                        this.EntradaNumeroCheque = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.EntradaBanco = new Lui.Forms.DetailBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.PanelTitulo = new System.Windows.Forms.Panel();
                        this.FrameTitulo = new Lui.Forms.Frame();
                        this.PanelCuenta = new System.Windows.Forms.Panel();
                        this.label9 = new System.Windows.Forms.Label();
                        this.EntradaCuenta = new Lui.Forms.DetailBox();
                        this.PanelEfectivo = new System.Windows.Forms.Panel();
                        this.label8 = new System.Windows.Forms.Label();
                        this.PanelTarjeta = new System.Windows.Forms.Panel();
                        this.EntradaAutorizacion = new Lui.Forms.TextBox();
                        this.EntradaCupon = new Lui.Forms.TextBox();
                        this.EntradaInteres = new Lui.Forms.TextBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.EntradaCuotas = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaPlan = new Lui.Forms.DetailBox();
                        this.EntradaTarjeta = new Lui.Forms.DetailBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.PanelObs = new System.Windows.Forms.Panel();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.Label20 = new System.Windows.Forms.Label();
                        this.PanelCuentaCorriente = new System.Windows.Forms.Panel();
                        this.label7 = new System.Windows.Forms.Label();
                        this.PanelFormaDePago = new System.Windows.Forms.Panel();
                        this.label13 = new System.Windows.Forms.Label();
                        this.label12 = new System.Windows.Forms.Label();
                        this.EntradaFormaDePago = new Lui.Forms.TextBox();
                        this.PanelSeparadorInferior = new System.Windows.Forms.Panel();
                        this.PanelImporte.SuspendLayout();
                        this.PanelCheque.SuspendLayout();
                        this.PanelTitulo.SuspendLayout();
                        this.PanelCuenta.SuspendLayout();
                        this.PanelEfectivo.SuspendLayout();
                        this.PanelTarjeta.SuspendLayout();
                        this.PanelObs.SuspendLayout();
                        this.PanelCuentaCorriente.SuspendLayout();
                        this.PanelFormaDePago.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.DetailField = "";
                        this.EntradaImporte.Filter = "";
                        this.EntradaImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaImporte.KeyField = "";
                        this.EntradaImporte.Location = new System.Drawing.Point(140, 0);
                        this.EntradaImporte.MaxLenght = 32767;
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.PasswordChar = '\0';
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.ReadOnly = false;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.SetData = new string[] {
        ""};
                        this.EntradaImporte.Size = new System.Drawing.Size(116, 24);
                        this.EntradaImporte.Sufijo = "";
                        this.EntradaImporte.TabIndex = 1;
                        this.EntradaImporte.Table = "";
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TextKey = "";
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
                        this.PanelImporte.Location = new System.Drawing.Point(2, 72);
                        this.PanelImporte.Name = "PanelImporte";
                        this.PanelImporte.Size = new System.Drawing.Size(456, 30);
                        this.PanelImporte.TabIndex = 2;
                        // 
                        // PanelCheque
                        // 
                        this.PanelCheque.Controls.Add(this.EntradaEmisor);
                        this.PanelCheque.Controls.Add(this.label2);
                        this.PanelCheque.Controls.Add(this.EntradaFechaCobro);
                        this.PanelCheque.Controls.Add(this.label3);
                        this.PanelCheque.Controls.Add(this.label6);
                        this.PanelCheque.Controls.Add(this.EntradaFechaEmision);
                        this.PanelCheque.Controls.Add(this.EntradaNumeroCheque);
                        this.PanelCheque.Controls.Add(this.lblFecha1);
                        this.PanelCheque.Controls.Add(this.EntradaBanco);
                        this.PanelCheque.Controls.Add(this.label5);
                        this.PanelCheque.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelCheque.Location = new System.Drawing.Point(2, 134);
                        this.PanelCheque.Name = "PanelCheque";
                        this.PanelCheque.Size = new System.Drawing.Size(456, 166);
                        this.PanelCheque.TabIndex = 4;
                        this.PanelCheque.Visible = false;
                        // 
                        // EntradaEmisor
                        // 
                        this.EntradaEmisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmisor.AutoNav = true;
                        this.EntradaEmisor.AutoTab = true;
                        this.EntradaEmisor.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmisor.DecimalPlaces = -1;
                        this.EntradaEmisor.DetailField = null;
                        this.EntradaEmisor.Filter = null;
                        this.EntradaEmisor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmisor.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmisor.KeyField = null;
                        this.EntradaEmisor.Location = new System.Drawing.Point(140, 32);
                        this.EntradaEmisor.MaxLenght = 32767;
                        this.EntradaEmisor.MultiLine = false;
                        this.EntradaEmisor.Name = "EntradaEmisor";
                        this.EntradaEmisor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmisor.PasswordChar = '\0';
                        this.EntradaEmisor.Prefijo = "";
                        this.EntradaEmisor.ReadOnly = false;
                        this.EntradaEmisor.SelectOnFocus = true;
                        this.EntradaEmisor.SetData = new string[0];
                        this.EntradaEmisor.Size = new System.Drawing.Size(316, 24);
                        this.EntradaEmisor.Sufijo = "";
                        this.EntradaEmisor.TabIndex = 3;
                        this.EntradaEmisor.Table = null;
                        this.EntradaEmisor.TextKey = "";
                        this.EntradaEmisor.TipWhenBlank = "";
                        this.EntradaEmisor.ToolTipText = "Estado para esta chequera.";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 64);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(136, 24);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Banco";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaCobro
                        // 
                        this.EntradaFechaCobro.AutoNav = true;
                        this.EntradaFechaCobro.AutoTab = true;
                        this.EntradaFechaCobro.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaCobro.DecimalPlaces = -1;
                        this.EntradaFechaCobro.DetailField = null;
                        this.EntradaFechaCobro.Filter = null;
                        this.EntradaFechaCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaCobro.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaCobro.KeyField = null;
                        this.EntradaFechaCobro.Location = new System.Drawing.Point(140, 128);
                        this.EntradaFechaCobro.MaxLenght = 32767;
                        this.EntradaFechaCobro.MultiLine = false;
                        this.EntradaFechaCobro.Name = "EntradaFechaCobro";
                        this.EntradaFechaCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaCobro.PasswordChar = '\0';
                        this.EntradaFechaCobro.Prefijo = "";
                        this.EntradaFechaCobro.ReadOnly = false;
                        this.EntradaFechaCobro.SelectOnFocus = true;
                        this.EntradaFechaCobro.SetData = new string[] {
        ""};
                        this.EntradaFechaCobro.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaCobro.Sufijo = "";
                        this.EntradaFechaCobro.TabIndex = 9;
                        this.EntradaFechaCobro.Table = null;
                        this.EntradaFechaCobro.TextKey = "";
                        this.EntradaFechaCobro.TipWhenBlank = "";
                        this.EntradaFechaCobro.ToolTipText = "";
                        this.EntradaFechaCobro.Enter += new System.EventHandler(this.EntradaFechaCobro_Enter);
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(0, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(136, 24);
                        this.label3.TabIndex = 0;
                        this.label3.Text = "Número";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(0, 128);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(140, 24);
                        this.label6.TabIndex = 8;
                        this.label6.Text = "Fecha de cobro";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaEmision
                        // 
                        this.EntradaFechaEmision.AutoNav = true;
                        this.EntradaFechaEmision.AutoTab = true;
                        this.EntradaFechaEmision.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaEmision.DecimalPlaces = -1;
                        this.EntradaFechaEmision.DetailField = null;
                        this.EntradaFechaEmision.Filter = null;
                        this.EntradaFechaEmision.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaEmision.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaEmision.KeyField = null;
                        this.EntradaFechaEmision.Location = new System.Drawing.Point(140, 96);
                        this.EntradaFechaEmision.MaxLenght = 32767;
                        this.EntradaFechaEmision.MultiLine = false;
                        this.EntradaFechaEmision.Name = "EntradaFechaEmision";
                        this.EntradaFechaEmision.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaEmision.PasswordChar = '\0';
                        this.EntradaFechaEmision.Prefijo = "";
                        this.EntradaFechaEmision.ReadOnly = false;
                        this.EntradaFechaEmision.SelectOnFocus = true;
                        this.EntradaFechaEmision.SetData = new string[] {
        ""};
                        this.EntradaFechaEmision.Size = new System.Drawing.Size(112, 24);
                        this.EntradaFechaEmision.Sufijo = "";
                        this.EntradaFechaEmision.TabIndex = 7;
                        this.EntradaFechaEmision.Table = null;
                        this.EntradaFechaEmision.TextKey = "";
                        this.EntradaFechaEmision.TipWhenBlank = "";
                        this.EntradaFechaEmision.ToolTipText = "";
                        // 
                        // EntradaNumeroCheque
                        // 
                        this.EntradaNumeroCheque.AutoNav = true;
                        this.EntradaNumeroCheque.AutoTab = true;
                        this.EntradaNumeroCheque.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumeroCheque.DecimalPlaces = -1;
                        this.EntradaNumeroCheque.DetailField = null;
                        this.EntradaNumeroCheque.Filter = null;
                        this.EntradaNumeroCheque.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumeroCheque.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumeroCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumeroCheque.KeyField = null;
                        this.EntradaNumeroCheque.Location = new System.Drawing.Point(140, 0);
                        this.EntradaNumeroCheque.MaxLenght = 32767;
                        this.EntradaNumeroCheque.MultiLine = false;
                        this.EntradaNumeroCheque.Name = "EntradaNumeroCheque";
                        this.EntradaNumeroCheque.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumeroCheque.PasswordChar = '\0';
                        this.EntradaNumeroCheque.Prefijo = "";
                        this.EntradaNumeroCheque.ReadOnly = false;
                        this.EntradaNumeroCheque.SelectOnFocus = true;
                        this.EntradaNumeroCheque.SetData = new string[0];
                        this.EntradaNumeroCheque.Size = new System.Drawing.Size(196, 24);
                        this.EntradaNumeroCheque.Sufijo = "";
                        this.EntradaNumeroCheque.TabIndex = 1;
                        this.EntradaNumeroCheque.Table = null;
                        this.EntradaNumeroCheque.TextKey = "";
                        this.EntradaNumeroCheque.TipWhenBlank = "";
                        this.EntradaNumeroCheque.ToolTipText = "Estado para esta chequera.";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(0, 96);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(140, 24);
                        this.lblFecha1.TabIndex = 6;
                        this.lblFecha1.Text = "Fecha de emisión";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DetailField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Filter = null;
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.KeyField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(140, 64);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.ReadOnly = false;
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.SelectOnFocus = false;
                        this.EntradaBanco.Size = new System.Drawing.Size(316, 24);
                        this.EntradaBanco.TabIndex = 5;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TextInt = 0;
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 32);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(136, 24);
                        this.label5.TabIndex = 2;
                        this.label5.Text = "Emisor";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelTitulo
                        // 
                        this.PanelTitulo.Controls.Add(this.FrameTitulo);
                        this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelTitulo.Location = new System.Drawing.Point(2, 38);
                        this.PanelTitulo.Name = "PanelTitulo";
                        this.PanelTitulo.Size = new System.Drawing.Size(456, 34);
                        this.PanelTitulo.TabIndex = 1;
                        // 
                        // FrameTitulo
                        // 
                        this.FrameTitulo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.FrameTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FrameTitulo.Location = new System.Drawing.Point(0, 0);
                        this.FrameTitulo.Name = "FrameTitulo";
                        this.FrameTitulo.Padding = new System.Windows.Forms.Padding(2);
                        this.FrameTitulo.ReadOnly = false;
                        this.FrameTitulo.Size = new System.Drawing.Size(456, 32);
                        this.FrameTitulo.TabIndex = 0;
                        this.FrameTitulo.TabStop = false;
                        this.FrameTitulo.Text = "frame1";
                        this.FrameTitulo.ToolTipText = "";
                        // 
                        // PanelCuenta
                        // 
                        this.PanelCuenta.Controls.Add(this.label9);
                        this.PanelCuenta.Controls.Add(this.EntradaCuenta);
                        this.PanelCuenta.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelCuenta.Location = new System.Drawing.Point(2, 300);
                        this.PanelCuenta.Name = "PanelCuenta";
                        this.PanelCuenta.Size = new System.Drawing.Size(456, 56);
                        this.PanelCuenta.TabIndex = 5;
                        this.PanelCuenta.Visible = false;
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(0, 0);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(440, 20);
                        this.label9.TabIndex = 0;
                        this.label9.Text = "Cobro mediante acreditación en la siguiente cuenta";
                        // 
                        // EntradaCuenta
                        // 
                        this.EntradaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCuenta.AutoTab = true;
                        this.EntradaCuenta.CanCreate = true;
                        this.EntradaCuenta.DetailField = "nombre";
                        this.EntradaCuenta.ExtraDetailFields = null;
                        this.EntradaCuenta.Filter = null;
                        this.EntradaCuenta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCuenta.FreeTextCode = "";
                        this.EntradaCuenta.KeyField = "id_cuenta";
                        this.EntradaCuenta.Location = new System.Drawing.Point(140, 20);
                        this.EntradaCuenta.MaxLength = 200;
                        this.EntradaCuenta.Name = "EntradaCuenta";
                        this.EntradaCuenta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuenta.ReadOnly = false;
                        this.EntradaCuenta.Required = true;
                        this.EntradaCuenta.SelectOnFocus = false;
                        this.EntradaCuenta.Size = new System.Drawing.Size(316, 24);
                        this.EntradaCuenta.TabIndex = 1;
                        this.EntradaCuenta.Table = "cuentas";
                        this.EntradaCuenta.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCuenta.Text = "0";
                        this.EntradaCuenta.TextDetail = "";
                        this.EntradaCuenta.TextInt = 0;
                        this.EntradaCuenta.TipWhenBlank = "";
                        this.EntradaCuenta.ToolTipText = "";
                        // 
                        // PanelEfectivo
                        // 
                        this.PanelEfectivo.Controls.Add(this.label8);
                        this.PanelEfectivo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelEfectivo.Location = new System.Drawing.Point(2, 356);
                        this.PanelEfectivo.Name = "PanelEfectivo";
                        this.PanelEfectivo.Size = new System.Drawing.Size(456, 32);
                        this.PanelEfectivo.TabIndex = 6;
                        this.PanelEfectivo.Visible = false;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 0);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(456, 20);
                        this.label8.TabIndex = 0;
                        this.label8.Text = "Cobro en efectivo, con acreditación en la caja diaria.";
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
                        this.PanelTarjeta.Controls.Add(this.EntradaTarjeta);
                        this.PanelTarjeta.Controls.Add(this.Label10);
                        this.PanelTarjeta.Controls.Add(this.Label11);
                        this.PanelTarjeta.Controls.Add(this.Label15);
                        this.PanelTarjeta.Controls.Add(this.Label16);
                        this.PanelTarjeta.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelTarjeta.Location = new System.Drawing.Point(2, 388);
                        this.PanelTarjeta.Name = "PanelTarjeta";
                        this.PanelTarjeta.Size = new System.Drawing.Size(456, 166);
                        this.PanelTarjeta.TabIndex = 7;
                        this.PanelTarjeta.Visible = false;
                        // 
                        // EntradaAutorizacion
                        // 
                        this.EntradaAutorizacion.AutoNav = true;
                        this.EntradaAutorizacion.AutoTab = true;
                        this.EntradaAutorizacion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAutorizacion.DecimalPlaces = -1;
                        this.EntradaAutorizacion.DetailField = null;
                        this.EntradaAutorizacion.Filter = null;
                        this.EntradaAutorizacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaAutorizacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAutorizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaAutorizacion.KeyField = null;
                        this.EntradaAutorizacion.Location = new System.Drawing.Point(140, 132);
                        this.EntradaAutorizacion.MaxLenght = 32767;
                        this.EntradaAutorizacion.MultiLine = false;
                        this.EntradaAutorizacion.Name = "EntradaAutorizacion";
                        this.EntradaAutorizacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAutorizacion.PasswordChar = '\0';
                        this.EntradaAutorizacion.Prefijo = "";
                        this.EntradaAutorizacion.ReadOnly = false;
                        this.EntradaAutorizacion.SelectOnFocus = true;
                        this.EntradaAutorizacion.SetData = new string[] {
        ""};
                        this.EntradaAutorizacion.Size = new System.Drawing.Size(164, 24);
                        this.EntradaAutorizacion.Sufijo = "";
                        this.EntradaAutorizacion.TabIndex = 11;
                        this.EntradaAutorizacion.Table = null;
                        this.EntradaAutorizacion.TextKey = "";
                        this.EntradaAutorizacion.TipWhenBlank = "";
                        this.EntradaAutorizacion.ToolTipText = "";
                        // 
                        // EntradaCupon
                        // 
                        this.EntradaCupon.AutoNav = true;
                        this.EntradaCupon.AutoTab = true;
                        this.EntradaCupon.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCupon.DecimalPlaces = -1;
                        this.EntradaCupon.DetailField = null;
                        this.EntradaCupon.Filter = null;
                        this.EntradaCupon.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCupon.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCupon.KeyField = null;
                        this.EntradaCupon.Location = new System.Drawing.Point(140, 100);
                        this.EntradaCupon.MaxLenght = 32767;
                        this.EntradaCupon.MultiLine = false;
                        this.EntradaCupon.Name = "EntradaCupon";
                        this.EntradaCupon.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCupon.PasswordChar = '\0';
                        this.EntradaCupon.Prefijo = "";
                        this.EntradaCupon.ReadOnly = false;
                        this.EntradaCupon.SelectOnFocus = true;
                        this.EntradaCupon.SetData = new string[] {
        ""};
                        this.EntradaCupon.Size = new System.Drawing.Size(164, 24);
                        this.EntradaCupon.Sufijo = "";
                        this.EntradaCupon.TabIndex = 9;
                        this.EntradaCupon.Table = null;
                        this.EntradaCupon.TextKey = "";
                        this.EntradaCupon.TipWhenBlank = "";
                        this.EntradaCupon.ToolTipText = "";
                        // 
                        // EntradaInteres
                        // 
                        this.EntradaInteres.AutoNav = true;
                        this.EntradaInteres.AutoTab = true;
                        this.EntradaInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaInteres.DecimalPlaces = -1;
                        this.EntradaInteres.DetailField = null;
                        this.EntradaInteres.Filter = null;
                        this.EntradaInteres.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaInteres.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaInteres.KeyField = null;
                        this.EntradaInteres.Location = new System.Drawing.Point(368, 60);
                        this.EntradaInteres.MaxLenght = 32767;
                        this.EntradaInteres.MultiLine = false;
                        this.EntradaInteres.Name = "EntradaInteres";
                        this.EntradaInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaInteres.PasswordChar = '\0';
                        this.EntradaInteres.Prefijo = "";
                        this.EntradaInteres.ReadOnly = true;
                        this.EntradaInteres.SelectOnFocus = true;
                        this.EntradaInteres.SetData = new string[] {
        ""};
                        this.EntradaInteres.Size = new System.Drawing.Size(80, 24);
                        this.EntradaInteres.Sufijo = "%";
                        this.EntradaInteres.TabIndex = 7;
                        this.EntradaInteres.Table = null;
                        this.EntradaInteres.TabStop = false;
                        this.EntradaInteres.Text = "0.00";
                        this.EntradaInteres.TextKey = "";
                        this.EntradaInteres.TipWhenBlank = "";
                        this.EntradaInteres.ToolTipText = "";
                        // 
                        // Label14
                        // 
                        this.Label14.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label14.Location = new System.Drawing.Point(300, 60);
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
                        this.EntradaCuotas.DetailField = null;
                        this.EntradaCuotas.Filter = null;
                        this.EntradaCuotas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCuotas.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCuotas.KeyField = null;
                        this.EntradaCuotas.Location = new System.Drawing.Point(228, 60);
                        this.EntradaCuotas.MaxLenght = 32767;
                        this.EntradaCuotas.MultiLine = false;
                        this.EntradaCuotas.Name = "EntradaCuotas";
                        this.EntradaCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuotas.PasswordChar = '\0';
                        this.EntradaCuotas.Prefijo = "";
                        this.EntradaCuotas.ReadOnly = true;
                        this.EntradaCuotas.SelectOnFocus = true;
                        this.EntradaCuotas.SetData = new string[] {
        ""};
                        this.EntradaCuotas.Size = new System.Drawing.Size(60, 24);
                        this.EntradaCuotas.Sufijo = "";
                        this.EntradaCuotas.TabIndex = 5;
                        this.EntradaCuotas.Table = null;
                        this.EntradaCuotas.TabStop = false;
                        this.EntradaCuotas.Text = "0";
                        this.EntradaCuotas.TextKey = "";
                        this.EntradaCuotas.TipWhenBlank = "";
                        this.EntradaCuotas.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label4.Location = new System.Drawing.Point(156, 60);
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
                        this.EntradaPlan.DetailField = "nombre";
                        this.EntradaPlan.ExtraDetailFields = null;
                        this.EntradaPlan.Filter = null;
                        this.EntradaPlan.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPlan.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPlan.FreeTextCode = "";
                        this.EntradaPlan.KeyField = "id_plan";
                        this.EntradaPlan.Location = new System.Drawing.Point(140, 32);
                        this.EntradaPlan.MaxLength = 200;
                        this.EntradaPlan.Name = "EntradaPlan";
                        this.EntradaPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPlan.ReadOnly = false;
                        this.EntradaPlan.Required = false;
                        this.EntradaPlan.SelectOnFocus = true;
                        this.EntradaPlan.Size = new System.Drawing.Size(316, 24);
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
                        // EntradaTarjeta
                        // 
                        this.EntradaTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTarjeta.AutoTab = true;
                        this.EntradaTarjeta.CanCreate = false;
                        this.EntradaTarjeta.DetailField = "nombre";
                        this.EntradaTarjeta.ExtraDetailFields = null;
                        this.EntradaTarjeta.Filter = "";
                        this.EntradaTarjeta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTarjeta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTarjeta.FreeTextCode = "";
                        this.EntradaTarjeta.KeyField = "id_tarjeta";
                        this.EntradaTarjeta.Location = new System.Drawing.Point(140, 0);
                        this.EntradaTarjeta.MaxLength = 200;
                        this.EntradaTarjeta.Name = "EntradaTarjeta";
                        this.EntradaTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTarjeta.ReadOnly = false;
                        this.EntradaTarjeta.Required = true;
                        this.EntradaTarjeta.SelectOnFocus = true;
                        this.EntradaTarjeta.Size = new System.Drawing.Size(316, 24);
                        this.EntradaTarjeta.TabIndex = 1;
                        this.EntradaTarjeta.Table = "tarjetas";
                        this.EntradaTarjeta.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaTarjeta.Text = "0";
                        this.EntradaTarjeta.TextDetail = "";
                        this.EntradaTarjeta.TextInt = 0;
                        this.EntradaTarjeta.TipWhenBlank = "";
                        this.EntradaTarjeta.ToolTipText = "";
                        this.EntradaTarjeta.TextChanged += new System.EventHandler(this.EntradaTarjeta_TextChanged);
                        // 
                        // Label10
                        // 
                        this.Label10.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label10.Location = new System.Drawing.Point(0, 132);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(136, 24);
                        this.Label10.TabIndex = 10;
                        this.Label10.Text = "Autorización";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label11.Location = new System.Drawing.Point(0, 100);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(136, 24);
                        this.Label11.TabIndex = 8;
                        this.Label11.Text = "Lote/Cupón";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label15
                        // 
                        this.Label15.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label15.Location = new System.Drawing.Point(0, 32);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(136, 24);
                        this.Label15.TabIndex = 2;
                        this.Label15.Text = "Plan";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label16
                        // 
                        this.Label16.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label16.Location = new System.Drawing.Point(0, 0);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(136, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Tarjeta";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelObs
                        // 
                        this.PanelObs.Controls.Add(this.EntradaObs);
                        this.PanelObs.Controls.Add(this.Label20);
                        this.PanelObs.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelObs.Location = new System.Drawing.Point(2, 554);
                        this.PanelObs.Name = "PanelObs";
                        this.PanelObs.Size = new System.Drawing.Size(456, 58);
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
                        this.EntradaObs.DetailField = null;
                        this.EntradaObs.Filter = null;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.KeyField = null;
                        this.EntradaObs.Location = new System.Drawing.Point(140, 0);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.MultiLine = false;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = true;
                        this.EntradaObs.SetData = new string[] {
        ""};
                        this.EntradaObs.Size = new System.Drawing.Size(316, 52);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 1;
                        this.EntradaObs.Table = null;
                        this.EntradaObs.TextKey = "";
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
                        this.PanelCuentaCorriente.Location = new System.Drawing.Point(2, 102);
                        this.PanelCuentaCorriente.Name = "PanelCuentaCorriente";
                        this.PanelCuentaCorriente.Size = new System.Drawing.Size(456, 32);
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
                        this.PanelFormaDePago.Controls.Add(this.label13);
                        this.PanelFormaDePago.Controls.Add(this.label12);
                        this.PanelFormaDePago.Controls.Add(this.EntradaFormaDePago);
                        this.PanelFormaDePago.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelFormaDePago.Location = new System.Drawing.Point(2, 2);
                        this.PanelFormaDePago.Name = "PanelFormaDePago";
                        this.PanelFormaDePago.Size = new System.Drawing.Size(456, 36);
                        this.PanelFormaDePago.TabIndex = 0;
                        this.PanelFormaDePago.Visible = false;
                        // 
                        // label13
                        // 
                        this.label13.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                        // EntradaFormaDePago
                        // 
                        this.EntradaFormaDePago.AutoNav = true;
                        this.EntradaFormaDePago.AutoTab = true;
                        this.EntradaFormaDePago.DataType = Lui.Forms.DataTypes.Set;
                        this.EntradaFormaDePago.DecimalPlaces = -1;
                        this.EntradaFormaDePago.DetailField = "";
                        this.EntradaFormaDePago.Filter = "";
                        this.EntradaFormaDePago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFormaDePago.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFormaDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFormaDePago.KeyField = "";
                        this.EntradaFormaDePago.Location = new System.Drawing.Point(140, 0);
                        this.EntradaFormaDePago.MaxLenght = 32767;
                        this.EntradaFormaDePago.MultiLine = false;
                        this.EntradaFormaDePago.Name = "EntradaFormaDePago";
                        this.EntradaFormaDePago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaDePago.PasswordChar = '\0';
                        this.EntradaFormaDePago.Prefijo = "";
                        this.EntradaFormaDePago.ReadOnly = false;
                        this.EntradaFormaDePago.SelectOnFocus = true;
                        this.EntradaFormaDePago.SetData = new string[] {
        "Efectivo|1",
        "Cheque|2",
        "Tarjeta|4",
        "Acreditación en Cuenta|6"};
                        this.EntradaFormaDePago.Size = new System.Drawing.Size(216, 24);
                        this.EntradaFormaDePago.Sufijo = "";
                        this.EntradaFormaDePago.TabIndex = 1;
                        this.EntradaFormaDePago.Table = "";
                        this.EntradaFormaDePago.Text = "Efectivo";
                        this.EntradaFormaDePago.TextKey = "1";
                        this.EntradaFormaDePago.TipWhenBlank = "";
                        this.EntradaFormaDePago.ToolTipText = "";
                        this.EntradaFormaDePago.TextChanged += new System.EventHandler(this.EntradaFormaDePago_TextChanged);
                        this.EntradaFormaDePago.Leave += new System.EventHandler(this.EntradaFormaDePago_Leave);
                        this.EntradaFormaDePago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaFormaDePago_KeyPress);
                        this.EntradaFormaDePago.Enter += new System.EventHandler(this.EntradaFormaDePago_Enter);
                        // 
                        // PanelSeparadorInferior
                        // 
                        this.PanelSeparadorInferior.BackColor = System.Drawing.SystemColors.ControlDark;
                        this.PanelSeparadorInferior.Dock = System.Windows.Forms.DockStyle.Top;
                        this.PanelSeparadorInferior.Location = new System.Drawing.Point(2, 612);
                        this.PanelSeparadorInferior.Name = "PanelSeparadorInferior";
                        this.PanelSeparadorInferior.Size = new System.Drawing.Size(456, 2);
                        this.PanelSeparadorInferior.TabIndex = 9;
                        // 
                        // Cobro
                        // 
                        this.Controls.Add(this.PanelSeparadorInferior);
                        this.Controls.Add(this.PanelObs);
                        this.Controls.Add(this.PanelTarjeta);
                        this.Controls.Add(this.PanelEfectivo);
                        this.Controls.Add(this.PanelCuenta);
                        this.Controls.Add(this.PanelCheque);
                        this.Controls.Add(this.PanelCuentaCorriente);
                        this.Controls.Add(this.PanelImporte);
                        this.Controls.Add(this.PanelTitulo);
                        this.Controls.Add(this.PanelFormaDePago);
                        this.Name = "Cobro";
                        this.Size = new System.Drawing.Size(460, 629);
                        this.Controls.SetChildIndex(this.PanelFormaDePago, 0);
                        this.Controls.SetChildIndex(this.PanelTitulo, 0);
                        this.Controls.SetChildIndex(this.PanelImporte, 0);
                        this.Controls.SetChildIndex(this.PanelCuentaCorriente, 0);
                        this.Controls.SetChildIndex(this.PanelCheque, 0);
                        this.Controls.SetChildIndex(this.PanelCuenta, 0);
                        this.Controls.SetChildIndex(this.PanelEfectivo, 0);
                        this.Controls.SetChildIndex(this.PanelTarjeta, 0);
                        this.Controls.SetChildIndex(this.PanelObs, 0);
                        this.Controls.SetChildIndex(this.PanelSeparadorInferior, 0);
                        this.PanelImporte.ResumeLayout(false);
                        this.PanelCheque.ResumeLayout(false);
                        this.PanelTitulo.ResumeLayout(false);
                        this.PanelCuenta.ResumeLayout(false);
                        this.PanelEfectivo.ResumeLayout(false);
                        this.PanelTarjeta.ResumeLayout(false);
                        this.PanelObs.ResumeLayout(false);
                        this.PanelCuentaCorriente.ResumeLayout(false);
                        this.PanelFormaDePago.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaImporte;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Panel PanelImporte;
                private System.Windows.Forms.Panel PanelCheque;
                private System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaCobro;
                private System.Windows.Forms.Label label3;
                internal System.Windows.Forms.Label label6;
                internal Lui.Forms.TextBox EntradaFechaEmision;
                internal Lui.Forms.TextBox EntradaNumeroCheque;
                internal System.Windows.Forms.Label lblFecha1;
                internal Lui.Forms.DetailBox EntradaBanco;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.Panel PanelTitulo;
                private Lui.Forms.Frame FrameTitulo;
                private System.Windows.Forms.Panel PanelCuenta;
                internal Lui.Forms.DetailBox EntradaCuenta;
                private System.Windows.Forms.Panel PanelEfectivo;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Panel PanelTarjeta;
                public Lui.Forms.TextBox EntradaAutorizacion;
                public Lui.Forms.TextBox EntradaCupon;
                public Lui.Forms.TextBox EntradaInteres;
                internal System.Windows.Forms.Label Label14;
                public Lui.Forms.TextBox EntradaCuotas;
                internal System.Windows.Forms.Label label4;
                public Lui.Forms.DetailBox EntradaPlan;
                public Lui.Forms.DetailBox EntradaTarjeta;
                internal System.Windows.Forms.Label Label10;
                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label Label15;
                internal System.Windows.Forms.Label Label16;
                private System.Windows.Forms.Panel PanelObs;
                private System.Windows.Forms.Label label9;
                public Lui.Forms.TextBox EntradaObs;
                internal System.Windows.Forms.Label Label20;
                private System.Windows.Forms.Panel PanelCuentaCorriente;
                private System.Windows.Forms.Label label7;
                internal Lui.Forms.TextBox EntradaEmisor;
                private System.Windows.Forms.Panel PanelFormaDePago;
                private System.Windows.Forms.Label label13;
                private System.Windows.Forms.Label label12;
                private Lui.Forms.TextBox EntradaFormaDePago;
                private System.Windows.Forms.Panel PanelSeparadorInferior;
        }
}
