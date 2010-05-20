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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public class Filtros : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Filtros()
                        :
                    base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.DetailBox txtCliente;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.ComboBox txtEstado;
                internal Lui.Forms.ComboBox txtTipo;
                internal Lui.Forms.DetailBox txtVendedor;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.ComboBox txtAnuladas;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.DetailBox txtSucursal;
                internal System.Windows.Forms.Label label8;
                internal Lui.Forms.DetailBox txtFormaPago;
                internal Lui.Forms.ComboBox txtLetra;
                internal Label Label9;
                internal Lui.Forms.TextBox txtPV;
                internal Lcc.Controles.RangoFechas EntradaFechas;
                private TableLayoutPanel tableLayoutPanel1;
                private TableLayoutPanel tableLayoutPanel2;
                internal Label label10;
                private TableLayoutPanel tableLayoutPanel3;
                internal Lui.Forms.TextBox EntradaMontoHasta;
                internal Lui.Forms.TextBox EntradaMontoDesde;
                internal Label label12;
                internal Label label11;
                internal System.Windows.Forms.Label Label6;

                private void InitializeComponent()
                {
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtVendedor = new Lui.Forms.DetailBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtAnuladas = new Lui.Forms.ComboBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.txtSucursal = new Lui.Forms.DetailBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtFormaPago = new Lui.Forms.DetailBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.txtLetra = new Lui.Forms.ComboBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.txtPV = new Lui.Forms.TextBox();
                        this.EntradaFechas = new Lcc.Controles.RangoFechas();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.label10 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaMontoHasta = new Lui.Forms.TextBox();
                        this.EntradaMontoDesde = new Lui.Forms.TextBox();
                        this.label12 = new System.Windows.Forms.Label();
                        this.label11 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
                        this.tableLayoutPanel1.SuspendLayout();
                        this.tableLayoutPanel3.SuspendLayout();
                        this.tableLayoutPanel2.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // txtCliente
                        // 
                        this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCliente.AutoHeight = false;
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.CanCreate = false;
                        this.txtCliente.DetailField = "nombre_visible";
                        this.txtCliente.ExtraDetailFields = null;
                        this.txtCliente.Filter = "";
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCliente.FreeTextCode = "";
                        this.txtCliente.KeyField = "id_persona";
                        this.txtCliente.Location = new System.Drawing.Point(137, 151);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = false;
                        this.txtCliente.SelectOnFocus = true;
                        this.txtCliente.Size = new System.Drawing.Size(446, 24);
                        this.txtCliente.TabIndex = 11;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 148);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(128, 24);
                        this.Label2.TabIndex = 10;
                        this.Label2.Text = "Cliente";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 268);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(128, 24);
                        this.Label1.TabIndex = 18;
                        this.Label1.Text = "Fecha";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtEstado
                        // 
                        this.txtEstado.AutoHeight = true;
                        this.txtEstado.AutoNav = true;
                        this.txtEstado.AutoTab = true;
                        this.txtEstado.DetailField = null;
                        this.txtEstado.Filter = null;
                        this.txtEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtEstado.KeyField = null;
                        this.txtEstado.Location = new System.Drawing.Point(137, 211);
                        this.txtEstado.MaxLenght = 32767;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.SetData = new string[] {
        "Todas|0",
        "Sólo las Impresas|3",
        "Sólo las Pagas|1",
        "Sólo las Impresas e Impagas|2"};
                        this.txtEstado.Size = new System.Drawing.Size(248, 24);
                        this.txtEstado.TabIndex = 15;
                        this.txtEstado.Table = null;
                        this.txtEstado.Text = "Todas";
                        this.txtEstado.TextKey = "0";
                        this.txtEstado.TextRaw = "Todas";
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(3, 208);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(128, 24);
                        this.Label3.TabIndex = 14;
                        this.Label3.Text = "Estado";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoHeight = true;
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.DetailField = null;
                        this.txtTipo.Filter = null;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.KeyField = null;
                        this.txtTipo.Location = new System.Drawing.Point(3, 3);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Facturas|F",
        "Tickets|T",
        "Notas de Crédito|NC",
        "Notas de Débito|ND",
        "Notas de Crédito y Débito|NCD",
        "Presupuestos|PS",
        "Remitos|R"};
                        this.txtTipo.Size = new System.Drawing.Size(180, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Table = null;
                        this.txtTipo.Text = "Facturas";
                        this.txtTipo.TextKey = "F";
                        this.txtTipo.TextRaw = "Facturas";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(3, 88);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(128, 24);
                        this.Label4.TabIndex = 6;
                        this.Label4.Text = "Tipo";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtVendedor
                        // 
                        this.txtVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtVendedor.AutoHeight = false;
                        this.txtVendedor.AutoTab = true;
                        this.txtVendedor.CanCreate = false;
                        this.txtVendedor.DetailField = "nombre_visible";
                        this.txtVendedor.ExtraDetailFields = null;
                        this.txtVendedor.Filter = "(tipo&4)=4";
                        this.txtVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtVendedor.FreeTextCode = "";
                        this.txtVendedor.KeyField = "id_persona";
                        this.txtVendedor.Location = new System.Drawing.Point(137, 181);
                        this.txtVendedor.MaxLength = 200;
                        this.txtVendedor.Name = "txtVendedor";
                        this.txtVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtVendedor.ReadOnly = false;
                        this.txtVendedor.Required = false;
                        this.txtVendedor.SelectOnFocus = true;
                        this.txtVendedor.Size = new System.Drawing.Size(446, 24);
                        this.txtVendedor.TabIndex = 13;
                        this.txtVendedor.Table = "personas";
                        this.txtVendedor.TeclaDespuesDeEnter = "{tab}";
                        this.txtVendedor.Text = "0";
                        this.txtVendedor.TextDetail = "";
                        this.txtVendedor.TextInt = 0;
                        this.txtVendedor.TipWhenBlank = "";
                        this.txtVendedor.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(3, 178);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(128, 24);
                        this.Label5.TabIndex = 12;
                        this.Label5.Text = "Vendedor";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtAnuladas
                        // 
                        this.txtAnuladas.AutoHeight = true;
                        this.txtAnuladas.AutoNav = true;
                        this.txtAnuladas.AutoTab = true;
                        this.txtAnuladas.DetailField = null;
                        this.txtAnuladas.Filter = null;
                        this.txtAnuladas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtAnuladas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtAnuladas.KeyField = null;
                        this.txtAnuladas.Location = new System.Drawing.Point(137, 241);
                        this.txtAnuladas.MaxLenght = 32767;
                        this.txtAnuladas.Name = "txtAnuladas";
                        this.txtAnuladas.Padding = new System.Windows.Forms.Padding(2);
                        this.txtAnuladas.ReadOnly = false;
                        this.txtAnuladas.SetData = new string[] {
        "Ocultar|0",
        "Mostrar|1"};
                        this.txtAnuladas.Size = new System.Drawing.Size(248, 24);
                        this.txtAnuladas.TabIndex = 17;
                        this.txtAnuladas.Table = null;
                        this.txtAnuladas.Text = "Ocultar";
                        this.txtAnuladas.TextKey = "0";
                        this.txtAnuladas.TextRaw = "Ocultar";
                        this.txtAnuladas.TipWhenBlank = "";
                        this.txtAnuladas.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(3, 238);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(128, 24);
                        this.Label6.TabIndex = 16;
                        this.Label6.Text = "Anuladas";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSucursal
                        // 
                        this.txtSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtSucursal.AutoHeight = false;
                        this.txtSucursal.AutoTab = true;
                        this.txtSucursal.CanCreate = false;
                        this.txtSucursal.DetailField = "nombre";
                        this.txtSucursal.ExtraDetailFields = null;
                        this.txtSucursal.Filter = "";
                        this.txtSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSucursal.FreeTextCode = "";
                        this.txtSucursal.KeyField = "id_sucursal";
                        this.txtSucursal.Location = new System.Drawing.Point(137, 3);
                        this.txtSucursal.MaxLength = 200;
                        this.txtSucursal.Name = "txtSucursal";
                        this.txtSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSucursal.ReadOnly = false;
                        this.txtSucursal.Required = false;
                        this.txtSucursal.SelectOnFocus = true;
                        this.txtSucursal.Size = new System.Drawing.Size(446, 24);
                        this.txtSucursal.TabIndex = 1;
                        this.txtSucursal.Table = "sucursales";
                        this.txtSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.txtSucursal.Text = "0";
                        this.txtSucursal.TextDetail = "";
                        this.txtSucursal.TextInt = 0;
                        this.txtSucursal.TipWhenBlank = "";
                        this.txtSucursal.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(3, 0);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(128, 24);
                        this.label7.TabIndex = 0;
                        this.label7.Text = "Sucursal";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFormaPago
                        // 
                        this.txtFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtFormaPago.AutoHeight = false;
                        this.txtFormaPago.AutoTab = true;
                        this.txtFormaPago.CanCreate = false;
                        this.txtFormaPago.DetailField = "nombre";
                        this.txtFormaPago.ExtraDetailFields = null;
                        this.txtFormaPago.Filter = "";
                        this.txtFormaPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFormaPago.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFormaPago.FreeTextCode = "";
                        this.txtFormaPago.KeyField = "id_formapago";
                        this.txtFormaPago.Location = new System.Drawing.Point(137, 33);
                        this.txtFormaPago.MaxLength = 200;
                        this.txtFormaPago.Name = "txtFormaPago";
                        this.txtFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFormaPago.ReadOnly = false;
                        this.txtFormaPago.Required = false;
                        this.txtFormaPago.SelectOnFocus = true;
                        this.txtFormaPago.Size = new System.Drawing.Size(446, 24);
                        this.txtFormaPago.TabIndex = 3;
                        this.txtFormaPago.Table = "formaspago";
                        this.txtFormaPago.TeclaDespuesDeEnter = "{tab}";
                        this.txtFormaPago.Text = "0";
                        this.txtFormaPago.TextDetail = "";
                        this.txtFormaPago.TextInt = 0;
                        this.txtFormaPago.TipWhenBlank = "";
                        this.txtFormaPago.ToolTipText = "";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(3, 60);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(128, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Monto";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtLetra
                        // 
                        this.txtLetra.AutoHeight = true;
                        this.txtLetra.AutoNav = true;
                        this.txtLetra.AutoTab = true;
                        this.txtLetra.DetailField = null;
                        this.txtLetra.Filter = null;
                        this.txtLetra.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtLetra.KeyField = null;
                        this.txtLetra.Location = new System.Drawing.Point(189, 3);
                        this.txtLetra.MaxLenght = 32767;
                        this.txtLetra.Name = "txtLetra";
                        this.txtLetra.Padding = new System.Windows.Forms.Padding(2);
                        this.txtLetra.ReadOnly = false;
                        this.txtLetra.SetData = new string[] {
        "Todas|*",
        "A|A",
        "B|B",
        "C|C",
        "E|E",
        "M|M"};
                        this.txtLetra.Size = new System.Drawing.Size(84, 24);
                        this.txtLetra.TabIndex = 0;
                        this.txtLetra.Table = null;
                        this.txtLetra.Text = "Todas";
                        this.txtLetra.TextKey = "*";
                        this.txtLetra.TextRaw = "Todas";
                        this.txtLetra.TipWhenBlank = "";
                        this.txtLetra.ToolTipText = "";
                        // 
                        // Label9
                        // 
                        this.Label9.Location = new System.Drawing.Point(3, 118);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(128, 24);
                        this.Label9.TabIndex = 8;
                        this.Label9.Text = "PV";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPV
                        // 
                        this.txtPV.AutoHeight = false;
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPV.DecimalPlaces = -1;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPV.Location = new System.Drawing.Point(137, 121);
                        this.txtPV.MaxLenght = 32767;
                        this.txtPV.MultiLine = false;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPV.PasswordChar = '\0';
                        this.txtPV.Prefijo = "";
                        this.txtPV.ReadOnly = false;
                        this.txtPV.SelectOnFocus = true;
                        this.txtPV.Size = new System.Drawing.Size(44, 24);
                        this.txtPV.Sufijo = "";
                        this.txtPV.TabIndex = 9;
                        this.txtPV.Text = "0";
                        this.txtPV.TextRaw = "0";
                        this.txtPV.TipWhenBlank = "";
                        this.txtPV.ToolTipText = "";
                        // 
                        // EntradaFechas
                        // 
                        this.EntradaFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechas.AutoHeight = true;
                        this.EntradaFechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechas.Location = new System.Drawing.Point(137, 271);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.ReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(446, 30);
                        this.EntradaFechas.TabIndex = 19;
                        this.EntradaFechas.ToolTipText = "";
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFechas, 1, 9);
                        this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.txtPV, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.txtAnuladas, 1, 8);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.txtEstado, 1, 7);
                        this.tableLayoutPanel1.Controls.Add(this.txtVendedor, 1, 6);
                        this.tableLayoutPanel1.Controls.Add(this.Label9, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.txtCliente, 1, 5);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 5);
                        this.tableLayoutPanel1.Controls.Add(this.txtSucursal, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label5, 0, 6);
                        this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 7);
                        this.tableLayoutPanel1.Controls.Add(this.Label6, 0, 8);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 9);
                        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.txtFormaPago, 1, 1);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 10;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 366);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // label10
                        // 
                        this.label10.Location = new System.Drawing.Point(3, 30);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(128, 24);
                        this.label10.TabIndex = 2;
                        this.label10.Text = "Pago";
                        this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel3
                        // 
                        this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel3.ColumnCount = 4;
                        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel3.Controls.Add(this.EntradaMontoHasta, 3, 0);
                        this.tableLayoutPanel3.Controls.Add(this.EntradaMontoDesde, 1, 0);
                        this.tableLayoutPanel3.Controls.Add(this.label12, 2, 0);
                        this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
                        this.tableLayoutPanel3.Location = new System.Drawing.Point(134, 60);
                        this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
                        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
                        this.tableLayoutPanel3.RowCount = 1;
                        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel3.Size = new System.Drawing.Size(452, 28);
                        this.tableLayoutPanel3.TabIndex = 5;
                        // 
                        // EntradaMontoHasta
                        // 
                        this.EntradaMontoHasta.AutoHeight = false;
                        this.EntradaMontoHasta.AutoNav = true;
                        this.EntradaMontoHasta.AutoTab = true;
                        this.EntradaMontoHasta.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaMontoHasta.DecimalPlaces = -1;
                        this.EntradaMontoHasta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaMontoHasta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMontoHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaMontoHasta.Location = new System.Drawing.Point(214, 3);
                        this.EntradaMontoHasta.MaxLenght = 32767;
                        this.EntradaMontoHasta.MultiLine = false;
                        this.EntradaMontoHasta.Name = "EntradaMontoHasta";
                        this.EntradaMontoHasta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMontoHasta.PasswordChar = '\0';
                        this.EntradaMontoHasta.Prefijo = "$";
                        this.EntradaMontoHasta.ReadOnly = false;
                        this.EntradaMontoHasta.SelectOnFocus = true;
                        this.EntradaMontoHasta.Size = new System.Drawing.Size(109, 24);
                        this.EntradaMontoHasta.Sufijo = "";
                        this.EntradaMontoHasta.TabIndex = 3;
                        this.EntradaMontoHasta.Text = "0.00";
                        this.EntradaMontoHasta.TextRaw = "0.00";
                        this.EntradaMontoHasta.TipWhenBlank = "";
                        this.EntradaMontoHasta.ToolTipText = "";
                        // 
                        // EntradaMontoDesde
                        // 
                        this.EntradaMontoDesde.AutoHeight = false;
                        this.EntradaMontoDesde.AutoNav = true;
                        this.EntradaMontoDesde.AutoTab = true;
                        this.EntradaMontoDesde.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaMontoDesde.DecimalPlaces = -1;
                        this.EntradaMontoDesde.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaMontoDesde.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMontoDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaMontoDesde.Location = new System.Drawing.Point(62, 3);
                        this.EntradaMontoDesde.MaxLenght = 32767;
                        this.EntradaMontoDesde.MultiLine = false;
                        this.EntradaMontoDesde.Name = "EntradaMontoDesde";
                        this.EntradaMontoDesde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMontoDesde.PasswordChar = '\0';
                        this.EntradaMontoDesde.Prefijo = "$";
                        this.EntradaMontoDesde.ReadOnly = false;
                        this.EntradaMontoDesde.SelectOnFocus = true;
                        this.EntradaMontoDesde.Size = new System.Drawing.Size(114, 24);
                        this.EntradaMontoDesde.Sufijo = "";
                        this.EntradaMontoDesde.TabIndex = 1;
                        this.EntradaMontoDesde.Text = "0.00";
                        this.EntradaMontoDesde.TextRaw = "0.00";
                        this.EntradaMontoDesde.TipWhenBlank = "";
                        this.EntradaMontoDesde.ToolTipText = "";
                        // 
                        // label12
                        // 
                        this.label12.Location = new System.Drawing.Point(182, 0);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(26, 24);
                        this.label12.TabIndex = 2;
                        this.label12.Text = "y";
                        this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label11
                        // 
                        this.label11.Location = new System.Drawing.Point(3, 0);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(53, 24);
                        this.label11.TabIndex = 0;
                        this.label11.Text = "entre";
                        this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel2
                        // 
                        this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel2.AutoSize = true;
                        this.tableLayoutPanel2.ColumnCount = 2;
                        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel2.Controls.Add(this.txtTipo, 0, 0);
                        this.tableLayoutPanel2.Controls.Add(this.txtLetra, 1, 0);
                        this.tableLayoutPanel2.Location = new System.Drawing.Point(134, 88);
                        this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
                        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
                        this.tableLayoutPanel2.RowCount = 1;
                        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 30);
                        this.tableLayoutPanel2.TabIndex = 7;
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 454);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Text = "Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.tableLayoutPanel1.PerformLayout();
                        this.tableLayoutPanel3.ResumeLayout(false);
                        this.tableLayoutPanel2.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                private void txtTipo_TextChanged(object sender, EventArgs e)
                {
                        txtLetra.Enabled = (txtTipo.TextKey == "F" || txtTipo.TextKey == "NC" || txtTipo.TextKey == "ND" || txtTipo.TextKey == "NCD");
                }
        }
}