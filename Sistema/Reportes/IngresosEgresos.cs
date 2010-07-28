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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Reportes
{
        public class IngresosEgresos : Lui.Forms.ChildForm
        {

                private string Fecha1Sql = "";
                private string Fecha2Sql = "";
                internal Lui.Forms.Button ChartButton;
                internal Lui.Forms.TextBox txtCompraMateriales;
                internal System.Windows.Forms.Label label25;
                internal Lui.Forms.TextBox txtCostoCapital;
                internal System.Windows.Forms.Label label26;
                internal System.Windows.Forms.Label label27;
                internal Lui.Forms.Button cmdCostoCapital;
                internal Lui.Forms.Button cmdCostoMateriales;
                internal Lui.Forms.Button cmdIngresosOtros;
                internal Lui.Forms.TextBox txtIngresosOtros;
                internal System.Windows.Forms.Label label24;
                internal Label label4;
                internal Label label8;
                internal Label label12;
                internal Label label14;
                internal Lui.Forms.TextBox txtGestionCobro;
                internal Lui.Forms.Button cmdGestionCobro;
                internal Lui.Forms.Button PorTipo;

                #region Código generado por el Diseñador de Windows Forms

                public IngresosEgresos()
                        : base()
                {
                        InitializeComponent();
                }

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


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox txtFacturacion;
                internal Lui.Forms.TextBox txtCosto;
                internal Lui.Forms.TextBox txtGastosFijos;
                internal Lui.Forms.TextBox txtGastosVariables;
                internal Lui.Forms.TextBox txtOtrosEgresos;
                internal Lui.Forms.ListView lvItems;
                internal System.Windows.Forms.ColumnHeader id;
                internal System.Windows.Forms.ColumnHeader fecha;
                internal System.Windows.Forms.ColumnHeader concepto;
                internal System.Windows.Forms.ColumnHeader comprob;
                internal Lui.Forms.Button cmdGastosFijos;
                internal Lui.Forms.Button cmdGastosVariables;
                internal Lui.Forms.Button cmdOtrosEgresos;
                internal System.Windows.Forms.ColumnHeader importe;
                internal System.Windows.Forms.ColumnHeader cuenta;
                internal System.Windows.Forms.ColumnHeader obs;
                internal Lui.Forms.TextBox txtCobros;
                internal System.Windows.Forms.Label Label10;
                internal Lui.Forms.Button cmdCobros;
                internal Lui.Forms.TextBox txtDiferenciaNeta;
                internal System.Windows.Forms.Label Label9;
                internal Lui.Forms.TextBox txtDiferenciaBruta;
                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label Label13;
                internal System.Windows.Forms.Label Label15;
                internal System.Windows.Forms.Label Label16;
                internal System.Windows.Forms.Label Label17;
                internal System.Windows.Forms.Label Label18;
                internal System.Windows.Forms.Label Label20;
                internal Lui.Forms.TextBox txtFecha1;
                internal Lui.Forms.TextBox txtFecha2;
                internal System.Windows.Forms.Label Label22;
                internal System.Windows.Forms.Label lblDiferenciaBrutaPct;
                internal System.Windows.Forms.Label lblDiferenciaNetaPct;
                internal Lui.Forms.Button PrintButton;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtFacturacion = new Lui.Forms.TextBox();
                        this.txtCosto = new Lui.Forms.TextBox();
                        this.txtGastosFijos = new Lui.Forms.TextBox();
                        this.txtGastosVariables = new Lui.Forms.TextBox();
                        this.txtOtrosEgresos = new Lui.Forms.TextBox();
                        this.cmdGastosFijos = new Lui.Forms.Button();
                        this.cmdGastosVariables = new Lui.Forms.Button();
                        this.cmdOtrosEgresos = new Lui.Forms.Button();
                        this.lvItems = new Lui.Forms.ListView();
                        this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.concepto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.importe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.cuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.comprob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.txtCobros = new Lui.Forms.TextBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.cmdCobros = new Lui.Forms.Button();
                        this.txtDiferenciaNeta = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.txtDiferenciaBruta = new Lui.Forms.TextBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.Label13 = new System.Windows.Forms.Label();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.Label17 = new System.Windows.Forms.Label();
                        this.Label18 = new System.Windows.Forms.Label();
                        this.Label20 = new System.Windows.Forms.Label();
                        this.txtFecha1 = new Lui.Forms.TextBox();
                        this.txtFecha2 = new Lui.Forms.TextBox();
                        this.Label22 = new System.Windows.Forms.Label();
                        this.lblDiferenciaBrutaPct = new System.Windows.Forms.Label();
                        this.lblDiferenciaNetaPct = new System.Windows.Forms.Label();
                        this.PrintButton = new Lui.Forms.Button();
                        this.ChartButton = new Lui.Forms.Button();
                        this.PorTipo = new Lui.Forms.Button();
                        this.txtCompraMateriales = new Lui.Forms.TextBox();
                        this.label25 = new System.Windows.Forms.Label();
                        this.cmdCostoCapital = new Lui.Forms.Button();
                        this.txtCostoCapital = new Lui.Forms.TextBox();
                        this.label26 = new System.Windows.Forms.Label();
                        this.label27 = new System.Windows.Forms.Label();
                        this.cmdCostoMateriales = new Lui.Forms.Button();
                        this.cmdIngresosOtros = new Lui.Forms.Button();
                        this.txtIngresosOtros = new Lui.Forms.TextBox();
                        this.label24 = new System.Windows.Forms.Label();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label8 = new System.Windows.Forms.Label();
                        this.label12 = new System.Windows.Forms.Label();
                        this.label14 = new System.Windows.Forms.Label();
                        this.txtGestionCobro = new Lui.Forms.TextBox();
                        this.cmdGestionCobro = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(12, 12);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(44, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Entre";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(16, 68);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(172, 24);
                        this.Label2.TabIndex = 28;
                        this.Label2.Text = "Facturación Total";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(16, 428);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(172, 24);
                        this.Label3.TabIndex = 10;
                        this.Label3.Text = "Compra de Materiales";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(16, 220);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(172, 24);
                        this.Label5.TabIndex = 16;
                        this.Label5.Text = "Gastos Fijos";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(16, 248);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(172, 24);
                        this.Label6.TabIndex = 19;
                        this.Label6.Text = "Gastos Variables";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(16, 276);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(172, 24);
                        this.Label7.TabIndex = 22;
                        this.Label7.Text = "Otros Egresos";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFacturacion
                        // 
                        this.txtFacturacion.AutoHeight = false;
                        this.txtFacturacion.AutoNav = true;
                        this.txtFacturacion.AutoTab = true;
                        this.txtFacturacion.DataType = Lui.Forms.DataTypes.Money;
                        this.txtFacturacion.DecimalPlaces = -1;
                        this.txtFacturacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFacturacion.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFacturacion.Location = new System.Drawing.Point(188, 68);
                        this.txtFacturacion.MaxLenght = 32767;
                        this.txtFacturacion.MultiLine = false;
                        this.txtFacturacion.Name = "txtFacturacion";
                        this.txtFacturacion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFacturacion.PasswordChar = '\0';
                        this.txtFacturacion.Prefijo = "";
                        this.txtFacturacion.ReadOnly = true;
                        this.txtFacturacion.SelectOnFocus = true;
                        this.txtFacturacion.Size = new System.Drawing.Size(104, 24);
                        this.txtFacturacion.Sufijo = "";
                        this.txtFacturacion.TabIndex = 29;
                        this.txtFacturacion.TabStop = false;
                        this.txtFacturacion.Text = "0.00";
                        this.txtFacturacion.TextRaw = "0.00";
                        this.txtFacturacion.TipWhenBlank = "";
                        this.txtFacturacion.ToolTipText = "";
                        this.txtFacturacion.GotFocus += new System.EventHandler(this.txtFacturacion_GotFocus);
                        // 
                        // txtCosto
                        // 
                        this.txtCosto.AutoHeight = false;
                        this.txtCosto.AutoNav = true;
                        this.txtCosto.AutoTab = true;
                        this.txtCosto.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCosto.DecimalPlaces = -1;
                        this.txtCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCosto.Location = new System.Drawing.Point(188, 96);
                        this.txtCosto.MaxLenght = 32767;
                        this.txtCosto.MultiLine = false;
                        this.txtCosto.Name = "txtCosto";
                        this.txtCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCosto.PasswordChar = '\0';
                        this.txtCosto.Prefijo = "";
                        this.txtCosto.ReadOnly = true;
                        this.txtCosto.SelectOnFocus = true;
                        this.txtCosto.Size = new System.Drawing.Size(104, 24);
                        this.txtCosto.Sufijo = "";
                        this.txtCosto.TabIndex = 31;
                        this.txtCosto.TabStop = false;
                        this.txtCosto.Text = "0.00";
                        this.txtCosto.TextRaw = "0.00";
                        this.txtCosto.TipWhenBlank = "";
                        this.txtCosto.ToolTipText = "";
                        // 
                        // txtGastosFijos
                        // 
                        this.txtGastosFijos.AutoHeight = false;
                        this.txtGastosFijos.AutoNav = true;
                        this.txtGastosFijos.AutoTab = true;
                        this.txtGastosFijos.DataType = Lui.Forms.DataTypes.Money;
                        this.txtGastosFijos.DecimalPlaces = -1;
                        this.txtGastosFijos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtGastosFijos.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtGastosFijos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtGastosFijos.Location = new System.Drawing.Point(188, 220);
                        this.txtGastosFijos.MaxLenght = 32767;
                        this.txtGastosFijos.MultiLine = false;
                        this.txtGastosFijos.Name = "txtGastosFijos";
                        this.txtGastosFijos.Padding = new System.Windows.Forms.Padding(2);
                        this.txtGastosFijos.PasswordChar = '\0';
                        this.txtGastosFijos.Prefijo = "";
                        this.txtGastosFijos.ReadOnly = true;
                        this.txtGastosFijos.SelectOnFocus = true;
                        this.txtGastosFijos.Size = new System.Drawing.Size(104, 24);
                        this.txtGastosFijos.Sufijo = "";
                        this.txtGastosFijos.TabIndex = 17;
                        this.txtGastosFijos.TabStop = false;
                        this.txtGastosFijos.Text = "0.00";
                        this.txtGastosFijos.TextRaw = "0.00";
                        this.txtGastosFijos.TipWhenBlank = "";
                        this.txtGastosFijos.ToolTipText = "";
                        // 
                        // txtGastosVariables
                        // 
                        this.txtGastosVariables.AutoHeight = false;
                        this.txtGastosVariables.AutoNav = true;
                        this.txtGastosVariables.AutoTab = true;
                        this.txtGastosVariables.DataType = Lui.Forms.DataTypes.Money;
                        this.txtGastosVariables.DecimalPlaces = -1;
                        this.txtGastosVariables.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtGastosVariables.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtGastosVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtGastosVariables.Location = new System.Drawing.Point(188, 248);
                        this.txtGastosVariables.MaxLenght = 32767;
                        this.txtGastosVariables.MultiLine = false;
                        this.txtGastosVariables.Name = "txtGastosVariables";
                        this.txtGastosVariables.Padding = new System.Windows.Forms.Padding(2);
                        this.txtGastosVariables.PasswordChar = '\0';
                        this.txtGastosVariables.Prefijo = "";
                        this.txtGastosVariables.ReadOnly = true;
                        this.txtGastosVariables.SelectOnFocus = true;
                        this.txtGastosVariables.Size = new System.Drawing.Size(104, 24);
                        this.txtGastosVariables.Sufijo = "";
                        this.txtGastosVariables.TabIndex = 20;
                        this.txtGastosVariables.TabStop = false;
                        this.txtGastosVariables.Text = "0.00";
                        this.txtGastosVariables.TextRaw = "0.00";
                        this.txtGastosVariables.TipWhenBlank = "";
                        this.txtGastosVariables.ToolTipText = "";
                        // 
                        // txtOtrosEgresos
                        // 
                        this.txtOtrosEgresos.AutoHeight = false;
                        this.txtOtrosEgresos.AutoNav = true;
                        this.txtOtrosEgresos.AutoTab = true;
                        this.txtOtrosEgresos.DataType = Lui.Forms.DataTypes.Money;
                        this.txtOtrosEgresos.DecimalPlaces = -1;
                        this.txtOtrosEgresos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtOtrosEgresos.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtOtrosEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtOtrosEgresos.Location = new System.Drawing.Point(188, 276);
                        this.txtOtrosEgresos.MaxLenght = 32767;
                        this.txtOtrosEgresos.MultiLine = false;
                        this.txtOtrosEgresos.Name = "txtOtrosEgresos";
                        this.txtOtrosEgresos.Padding = new System.Windows.Forms.Padding(2);
                        this.txtOtrosEgresos.PasswordChar = '\0';
                        this.txtOtrosEgresos.Prefijo = "";
                        this.txtOtrosEgresos.ReadOnly = true;
                        this.txtOtrosEgresos.SelectOnFocus = true;
                        this.txtOtrosEgresos.Size = new System.Drawing.Size(104, 24);
                        this.txtOtrosEgresos.Sufijo = "";
                        this.txtOtrosEgresos.TabIndex = 23;
                        this.txtOtrosEgresos.TabStop = false;
                        this.txtOtrosEgresos.Text = "0.00";
                        this.txtOtrosEgresos.TextRaw = "0.00";
                        this.txtOtrosEgresos.TipWhenBlank = "";
                        this.txtOtrosEgresos.ToolTipText = "";
                        // 
                        // cmdGastosFijos
                        // 
                        this.cmdGastosFijos.AutoHeight = false;
                        this.cmdGastosFijos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdGastosFijos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdGastosFijos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdGastosFijos.Image = null;
                        this.cmdGastosFijos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdGastosFijos.Location = new System.Drawing.Point(296, 220);
                        this.cmdGastosFijos.Name = "cmdGastosFijos";
                        this.cmdGastosFijos.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdGastosFijos.ReadOnly = false;
                        this.cmdGastosFijos.Size = new System.Drawing.Size(28, 24);
                        this.cmdGastosFijos.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdGastosFijos.Subtext = "";
                        this.cmdGastosFijos.TabIndex = 18;
                        this.cmdGastosFijos.Text = "...";
                        this.cmdGastosFijos.ToolTipText = "";
                        this.cmdGastosFijos.Click += new System.EventHandler(this.cmdGastosFijos_Click);
                        // 
                        // cmdGastosVariables
                        // 
                        this.cmdGastosVariables.AutoHeight = false;
                        this.cmdGastosVariables.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdGastosVariables.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdGastosVariables.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdGastosVariables.Image = null;
                        this.cmdGastosVariables.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdGastosVariables.Location = new System.Drawing.Point(296, 248);
                        this.cmdGastosVariables.Name = "cmdGastosVariables";
                        this.cmdGastosVariables.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdGastosVariables.ReadOnly = false;
                        this.cmdGastosVariables.Size = new System.Drawing.Size(28, 24);
                        this.cmdGastosVariables.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdGastosVariables.Subtext = "";
                        this.cmdGastosVariables.TabIndex = 21;
                        this.cmdGastosVariables.Text = "...";
                        this.cmdGastosVariables.ToolTipText = "";
                        this.cmdGastosVariables.Click += new System.EventHandler(this.cmdGastosVariables_Click);
                        // 
                        // cmdOtrosEgresos
                        // 
                        this.cmdOtrosEgresos.AutoHeight = false;
                        this.cmdOtrosEgresos.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdOtrosEgresos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdOtrosEgresos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdOtrosEgresos.Image = null;
                        this.cmdOtrosEgresos.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdOtrosEgresos.Location = new System.Drawing.Point(296, 276);
                        this.cmdOtrosEgresos.Name = "cmdOtrosEgresos";
                        this.cmdOtrosEgresos.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdOtrosEgresos.ReadOnly = false;
                        this.cmdOtrosEgresos.Size = new System.Drawing.Size(28, 24);
                        this.cmdOtrosEgresos.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdOtrosEgresos.Subtext = "";
                        this.cmdOtrosEgresos.TabIndex = 24;
                        this.cmdOtrosEgresos.Text = "...";
                        this.cmdOtrosEgresos.ToolTipText = "";
                        this.cmdOtrosEgresos.Click += new System.EventHandler(this.cmdOtrosEgresos_Click);
                        // 
                        // lvItems
                        // 
                        this.lvItems.AllowColumnReorder = true;
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fecha,
            this.concepto,
            this.importe,
            this.cuenta,
            this.comprob,
            this.obs});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvItems.HideSelection = false;
                        this.lvItems.Location = new System.Drawing.Point(352, 8);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(332, 522);
                        this.lvItems.TabIndex = 37;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        this.lvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItems_KeyDown);
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        this.id.Width = 0;
                        // 
                        // fecha
                        // 
                        this.fecha.Text = "Fecha";
                        this.fecha.Width = 86;
                        // 
                        // concepto
                        // 
                        this.concepto.Text = "Concepto";
                        this.concepto.Width = 240;
                        // 
                        // importe
                        // 
                        this.importe.Text = "Importe";
                        this.importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.importe.Width = 86;
                        // 
                        // cuenta
                        // 
                        this.cuenta.Text = "Caja";
                        this.cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.cuenta.Width = 46;
                        // 
                        // comprob
                        // 
                        this.comprob.Text = "Comprob.";
                        this.comprob.Width = 96;
                        // 
                        // obs
                        // 
                        this.obs.Text = "Obs.";
                        this.obs.Width = 240;
                        // 
                        // txtCobros
                        // 
                        this.txtCobros.AutoHeight = false;
                        this.txtCobros.AutoNav = true;
                        this.txtCobros.AutoTab = true;
                        this.txtCobros.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCobros.DecimalPlaces = -1;
                        this.txtCobros.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCobros.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCobros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCobros.Location = new System.Drawing.Point(188, 372);
                        this.txtCobros.MaxLenght = 32767;
                        this.txtCobros.MultiLine = false;
                        this.txtCobros.Name = "txtCobros";
                        this.txtCobros.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCobros.PasswordChar = '\0';
                        this.txtCobros.Prefijo = "";
                        this.txtCobros.ReadOnly = true;
                        this.txtCobros.SelectOnFocus = true;
                        this.txtCobros.Size = new System.Drawing.Size(104, 24);
                        this.txtCobros.Sufijo = "";
                        this.txtCobros.TabIndex = 5;
                        this.txtCobros.TabStop = false;
                        this.txtCobros.Text = "0.00";
                        this.txtCobros.TextRaw = "0.00";
                        this.txtCobros.TipWhenBlank = "";
                        this.txtCobros.ToolTipText = "";
                        // 
                        // Label10
                        // 
                        this.Label10.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label10.Location = new System.Drawing.Point(16, 372);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(172, 24);
                        this.Label10.TabIndex = 4;
                        this.Label10.Text = "Ingresos por Cobros";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdCobros
                        // 
                        this.cmdCobros.AutoHeight = false;
                        this.cmdCobros.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdCobros.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdCobros.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCobros.Image = null;
                        this.cmdCobros.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdCobros.Location = new System.Drawing.Point(296, 372);
                        this.cmdCobros.Name = "cmdCobros";
                        this.cmdCobros.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCobros.ReadOnly = false;
                        this.cmdCobros.Size = new System.Drawing.Size(28, 24);
                        this.cmdCobros.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdCobros.Subtext = "";
                        this.cmdCobros.TabIndex = 6;
                        this.cmdCobros.Text = "...";
                        this.cmdCobros.ToolTipText = "";
                        this.cmdCobros.Click += new System.EventHandler(this.cmdCobros_Click);
                        // 
                        // txtDiferenciaNeta
                        // 
                        this.txtDiferenciaNeta.AutoHeight = false;
                        this.txtDiferenciaNeta.AutoNav = true;
                        this.txtDiferenciaNeta.AutoTab = true;
                        this.txtDiferenciaNeta.DataType = Lui.Forms.DataTypes.Money;
                        this.txtDiferenciaNeta.DecimalPlaces = -1;
                        this.txtDiferenciaNeta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDiferenciaNeta.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtDiferenciaNeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDiferenciaNeta.Location = new System.Drawing.Point(188, 320);
                        this.txtDiferenciaNeta.MaxLenght = 32767;
                        this.txtDiferenciaNeta.MultiLine = false;
                        this.txtDiferenciaNeta.Name = "txtDiferenciaNeta";
                        this.txtDiferenciaNeta.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDiferenciaNeta.PasswordChar = '\0';
                        this.txtDiferenciaNeta.Prefijo = "";
                        this.txtDiferenciaNeta.ReadOnly = true;
                        this.txtDiferenciaNeta.SelectOnFocus = true;
                        this.txtDiferenciaNeta.Size = new System.Drawing.Size(104, 24);
                        this.txtDiferenciaNeta.Sufijo = "";
                        this.txtDiferenciaNeta.TabIndex = 26;
                        this.txtDiferenciaNeta.TabStop = false;
                        this.txtDiferenciaNeta.Text = "0.00";
                        this.txtDiferenciaNeta.TextRaw = "0.00";
                        this.txtDiferenciaNeta.TipWhenBlank = "";
                        this.txtDiferenciaNeta.ToolTipText = "";
                        // 
                        // Label9
                        // 
                        this.Label9.Location = new System.Drawing.Point(16, 320);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(172, 24);
                        this.Label9.TabIndex = 25;
                        this.Label9.Text = "Margen Final";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtDiferenciaBruta
                        // 
                        this.txtDiferenciaBruta.AutoHeight = false;
                        this.txtDiferenciaBruta.AutoNav = true;
                        this.txtDiferenciaBruta.AutoTab = true;
                        this.txtDiferenciaBruta.DataType = Lui.Forms.DataTypes.Money;
                        this.txtDiferenciaBruta.DecimalPlaces = -1;
                        this.txtDiferenciaBruta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDiferenciaBruta.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtDiferenciaBruta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDiferenciaBruta.Location = new System.Drawing.Point(188, 160);
                        this.txtDiferenciaBruta.MaxLenght = 32767;
                        this.txtDiferenciaBruta.MultiLine = false;
                        this.txtDiferenciaBruta.Name = "txtDiferenciaBruta";
                        this.txtDiferenciaBruta.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDiferenciaBruta.PasswordChar = '\0';
                        this.txtDiferenciaBruta.Prefijo = "";
                        this.txtDiferenciaBruta.ReadOnly = true;
                        this.txtDiferenciaBruta.SelectOnFocus = true;
                        this.txtDiferenciaBruta.Size = new System.Drawing.Size(104, 24);
                        this.txtDiferenciaBruta.Sufijo = "";
                        this.txtDiferenciaBruta.TabIndex = 33;
                        this.txtDiferenciaBruta.TabStop = false;
                        this.txtDiferenciaBruta.Text = "0.00";
                        this.txtDiferenciaBruta.TextRaw = "0.00";
                        this.txtDiferenciaBruta.TipWhenBlank = "";
                        this.txtDiferenciaBruta.ToolTipText = "";
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(16, 160);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(172, 24);
                        this.Label11.TabIndex = 32;
                        this.Label11.Text = "Margen Bruto";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label13
                        // 
                        this.Label13.BackColor = System.Drawing.Color.Silver;
                        this.Label13.Location = new System.Drawing.Point(8, 308);
                        this.Label13.Name = "Label13";
                        this.Label13.Size = new System.Drawing.Size(280, 2);
                        this.Label13.TabIndex = 27;
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(4, 160);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(12, 24);
                        this.Label15.TabIndex = 37;
                        this.Label15.Text = "=";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(4, 220);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(12, 24);
                        this.Label16.TabIndex = 11;
                        this.Label16.Text = "-";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label17
                        // 
                        this.Label17.Location = new System.Drawing.Point(4, 248);
                        this.Label17.Name = "Label17";
                        this.Label17.Size = new System.Drawing.Size(12, 24);
                        this.Label17.TabIndex = 15;
                        this.Label17.Text = "-";
                        this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label18
                        // 
                        this.Label18.Location = new System.Drawing.Point(4, 276);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(12, 24);
                        this.Label18.TabIndex = 23;
                        this.Label18.Text = "-";
                        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label20
                        // 
                        this.Label20.Location = new System.Drawing.Point(4, 320);
                        this.Label20.Name = "Label20";
                        this.Label20.Size = new System.Drawing.Size(12, 24);
                        this.Label20.TabIndex = 28;
                        this.Label20.Text = "=";
                        this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // txtFecha1
                        // 
                        this.txtFecha1.AutoHeight = false;
                        this.txtFecha1.AutoNav = true;
                        this.txtFecha1.AutoTab = true;
                        this.txtFecha1.DataType = Lui.Forms.DataTypes.Date;
                        this.txtFecha1.DecimalPlaces = -1;
                        this.txtFecha1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha1.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtFecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFecha1.Location = new System.Drawing.Point(56, 12);
                        this.txtFecha1.MaxLenght = 32767;
                        this.txtFecha1.MultiLine = false;
                        this.txtFecha1.Name = "txtFecha1";
                        this.txtFecha1.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha1.PasswordChar = '\0';
                        this.txtFecha1.Prefijo = "";
                        this.txtFecha1.ReadOnly = false;
                        this.txtFecha1.SelectOnFocus = true;
                        this.txtFecha1.Size = new System.Drawing.Size(92, 24);
                        this.txtFecha1.Sufijo = "";
                        this.txtFecha1.TabIndex = 1;
                        this.txtFecha1.TextRaw = "";
                        this.txtFecha1.TipWhenBlank = "";
                        this.txtFecha1.ToolTipText = "";
                        this.txtFecha1.LostFocus += new System.EventHandler(this.txtFecha12_LostFocus);
                        // 
                        // txtFecha2
                        // 
                        this.txtFecha2.AutoHeight = false;
                        this.txtFecha2.AutoNav = true;
                        this.txtFecha2.AutoTab = true;
                        this.txtFecha2.DataType = Lui.Forms.DataTypes.Date;
                        this.txtFecha2.DecimalPlaces = -1;
                        this.txtFecha2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha2.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtFecha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFecha2.Location = new System.Drawing.Point(192, 12);
                        this.txtFecha2.MaxLenght = 32767;
                        this.txtFecha2.MultiLine = false;
                        this.txtFecha2.Name = "txtFecha2";
                        this.txtFecha2.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha2.PasswordChar = '\0';
                        this.txtFecha2.Prefijo = "";
                        this.txtFecha2.ReadOnly = false;
                        this.txtFecha2.SelectOnFocus = true;
                        this.txtFecha2.Size = new System.Drawing.Size(92, 24);
                        this.txtFecha2.Sufijo = "";
                        this.txtFecha2.TabIndex = 3;
                        this.txtFecha2.TextRaw = "";
                        this.txtFecha2.TipWhenBlank = "";
                        this.txtFecha2.ToolTipText = "";
                        this.txtFecha2.LostFocus += new System.EventHandler(this.txtFecha12_LostFocus);
                        // 
                        // Label22
                        // 
                        this.Label22.Location = new System.Drawing.Point(148, 12);
                        this.Label22.Name = "Label22";
                        this.Label22.Size = new System.Drawing.Size(44, 24);
                        this.Label22.TabIndex = 2;
                        this.Label22.Text = "y";
                        this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDiferenciaBrutaPct
                        // 
                        this.lblDiferenciaBrutaPct.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblDiferenciaBrutaPct.Location = new System.Drawing.Point(296, 160);
                        this.lblDiferenciaBrutaPct.Name = "lblDiferenciaBrutaPct";
                        this.lblDiferenciaBrutaPct.Size = new System.Drawing.Size(48, 24);
                        this.lblDiferenciaBrutaPct.TabIndex = 34;
                        this.lblDiferenciaBrutaPct.Text = "0%";
                        this.lblDiferenciaBrutaPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblDiferenciaNetaPct
                        // 
                        this.lblDiferenciaNetaPct.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblDiferenciaNetaPct.Location = new System.Drawing.Point(296, 320);
                        this.lblDiferenciaNetaPct.Name = "lblDiferenciaNetaPct";
                        this.lblDiferenciaNetaPct.Size = new System.Drawing.Size(48, 24);
                        this.lblDiferenciaNetaPct.TabIndex = 27;
                        this.lblDiferenciaNetaPct.Text = "0%";
                        this.lblDiferenciaNetaPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
                        this.PrintButton.Location = new System.Drawing.Point(8, 498);
                        this.PrintButton.Name = "PrintButton";
                        this.PrintButton.Padding = new System.Windows.Forms.Padding(2);
                        this.PrintButton.ReadOnly = false;
                        this.PrintButton.Size = new System.Drawing.Size(96, 28);
                        this.PrintButton.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.PrintButton.Subtext = "F8";
                        this.PrintButton.TabIndex = 38;
                        this.PrintButton.Text = "Imprimir";
                        this.PrintButton.ToolTipText = "";
                        this.PrintButton.Click += new System.EventHandler(this.cmdImprimir_Click);
                        // 
                        // ChartButton
                        // 
                        this.ChartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ChartButton.AutoHeight = false;
                        this.ChartButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.ChartButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ChartButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.ChartButton.Image = null;
                        this.ChartButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.ChartButton.Location = new System.Drawing.Point(112, 498);
                        this.ChartButton.Name = "ChartButton";
                        this.ChartButton.Padding = new System.Windows.Forms.Padding(2);
                        this.ChartButton.ReadOnly = false;
                        this.ChartButton.Size = new System.Drawing.Size(96, 28);
                        this.ChartButton.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.ChartButton.Subtext = "";
                        this.ChartButton.TabIndex = 39;
                        this.ChartButton.Text = "Graficar";
                        this.ChartButton.ToolTipText = "";
                        this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
                        // 
                        // PorTipo
                        // 
                        this.PorTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PorTipo.AutoHeight = false;
                        this.PorTipo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.PorTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.PorTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.PorTipo.Image = null;
                        this.PorTipo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.PorTipo.Location = new System.Drawing.Point(216, 498);
                        this.PorTipo.Name = "PorTipo";
                        this.PorTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.PorTipo.ReadOnly = false;
                        this.PorTipo.Size = new System.Drawing.Size(96, 28);
                        this.PorTipo.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.PorTipo.Subtext = "F8";
                        this.PorTipo.TabIndex = 40;
                        this.PorTipo.Text = "Por Tipo";
                        this.PorTipo.ToolTipText = "";
                        this.PorTipo.Click += new System.EventHandler(this.PorTipo_Click);
                        // 
                        // txtCompraMateriales
                        // 
                        this.txtCompraMateriales.AutoHeight = false;
                        this.txtCompraMateriales.AutoNav = true;
                        this.txtCompraMateriales.AutoTab = true;
                        this.txtCompraMateriales.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCompraMateriales.DecimalPlaces = -1;
                        this.txtCompraMateriales.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCompraMateriales.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCompraMateriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCompraMateriales.Location = new System.Drawing.Point(188, 428);
                        this.txtCompraMateriales.MaxLenght = 32767;
                        this.txtCompraMateriales.MultiLine = false;
                        this.txtCompraMateriales.Name = "txtCompraMateriales";
                        this.txtCompraMateriales.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCompraMateriales.PasswordChar = '\0';
                        this.txtCompraMateriales.Prefijo = "";
                        this.txtCompraMateriales.ReadOnly = true;
                        this.txtCompraMateriales.SelectOnFocus = true;
                        this.txtCompraMateriales.Size = new System.Drawing.Size(104, 24);
                        this.txtCompraMateriales.Sufijo = "";
                        this.txtCompraMateriales.TabIndex = 11;
                        this.txtCompraMateriales.TabStop = false;
                        this.txtCompraMateriales.Text = "0.00";
                        this.txtCompraMateriales.TextRaw = "0.00";
                        this.txtCompraMateriales.TipWhenBlank = "";
                        this.txtCompraMateriales.ToolTipText = "";
                        // 
                        // label25
                        // 
                        this.label25.Location = new System.Drawing.Point(16, 96);
                        this.label25.Name = "label25";
                        this.label25.Size = new System.Drawing.Size(172, 24);
                        this.label25.TabIndex = 30;
                        this.label25.Text = "Costo Materiales";
                        this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdCostoCapital
                        // 
                        this.cmdCostoCapital.AutoHeight = false;
                        this.cmdCostoCapital.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdCostoCapital.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdCostoCapital.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCostoCapital.Image = null;
                        this.cmdCostoCapital.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdCostoCapital.Location = new System.Drawing.Point(296, 192);
                        this.cmdCostoCapital.Name = "cmdCostoCapital";
                        this.cmdCostoCapital.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCostoCapital.ReadOnly = false;
                        this.cmdCostoCapital.Size = new System.Drawing.Size(28, 24);
                        this.cmdCostoCapital.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdCostoCapital.Subtext = "";
                        this.cmdCostoCapital.TabIndex = 15;
                        this.cmdCostoCapital.Text = "...";
                        this.cmdCostoCapital.ToolTipText = "";
                        this.cmdCostoCapital.Click += new System.EventHandler(this.cmdCostoCapital_Click);
                        // 
                        // txtCostoCapital
                        // 
                        this.txtCostoCapital.AutoHeight = false;
                        this.txtCostoCapital.AutoNav = true;
                        this.txtCostoCapital.AutoTab = true;
                        this.txtCostoCapital.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCostoCapital.DecimalPlaces = -1;
                        this.txtCostoCapital.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCostoCapital.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCostoCapital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCostoCapital.Location = new System.Drawing.Point(188, 192);
                        this.txtCostoCapital.MaxLenght = 32767;
                        this.txtCostoCapital.MultiLine = false;
                        this.txtCostoCapital.Name = "txtCostoCapital";
                        this.txtCostoCapital.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCostoCapital.PasswordChar = '\0';
                        this.txtCostoCapital.Prefijo = "";
                        this.txtCostoCapital.ReadOnly = true;
                        this.txtCostoCapital.SelectOnFocus = true;
                        this.txtCostoCapital.Size = new System.Drawing.Size(104, 24);
                        this.txtCostoCapital.Sufijo = "";
                        this.txtCostoCapital.TabIndex = 14;
                        this.txtCostoCapital.TabStop = false;
                        this.txtCostoCapital.Text = "0.00";
                        this.txtCostoCapital.TextRaw = "0.00";
                        this.txtCostoCapital.TipWhenBlank = "";
                        this.txtCostoCapital.ToolTipText = "";
                        // 
                        // label26
                        // 
                        this.label26.Location = new System.Drawing.Point(4, 192);
                        this.label26.Name = "label26";
                        this.label26.Size = new System.Drawing.Size(12, 24);
                        this.label26.TabIndex = 53;
                        this.label26.Text = "-";
                        this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label27
                        // 
                        this.label27.Location = new System.Drawing.Point(16, 192);
                        this.label27.Name = "label27";
                        this.label27.Size = new System.Drawing.Size(172, 24);
                        this.label27.TabIndex = 13;
                        this.label27.Text = "Costo Capital";
                        this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdCostoMateriales
                        // 
                        this.cmdCostoMateriales.AutoHeight = false;
                        this.cmdCostoMateriales.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdCostoMateriales.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdCostoMateriales.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCostoMateriales.Image = null;
                        this.cmdCostoMateriales.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdCostoMateriales.Location = new System.Drawing.Point(296, 428);
                        this.cmdCostoMateriales.Name = "cmdCostoMateriales";
                        this.cmdCostoMateriales.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCostoMateriales.ReadOnly = false;
                        this.cmdCostoMateriales.Size = new System.Drawing.Size(28, 24);
                        this.cmdCostoMateriales.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdCostoMateriales.Subtext = "";
                        this.cmdCostoMateriales.TabIndex = 12;
                        this.cmdCostoMateriales.Text = "...";
                        this.cmdCostoMateriales.ToolTipText = "";
                        this.cmdCostoMateriales.Click += new System.EventHandler(this.cmdCostoMateriales_Click);
                        // 
                        // cmdIngresosOtros
                        // 
                        this.cmdIngresosOtros.AutoHeight = false;
                        this.cmdIngresosOtros.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdIngresosOtros.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdIngresosOtros.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdIngresosOtros.Image = null;
                        this.cmdIngresosOtros.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdIngresosOtros.Location = new System.Drawing.Point(296, 400);
                        this.cmdIngresosOtros.Name = "cmdIngresosOtros";
                        this.cmdIngresosOtros.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdIngresosOtros.ReadOnly = false;
                        this.cmdIngresosOtros.Size = new System.Drawing.Size(28, 24);
                        this.cmdIngresosOtros.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdIngresosOtros.Subtext = "";
                        this.cmdIngresosOtros.TabIndex = 9;
                        this.cmdIngresosOtros.Text = "...";
                        this.cmdIngresosOtros.ToolTipText = "";
                        this.cmdIngresosOtros.Click += new System.EventHandler(this.cmdIngresosOtros_Click);
                        // 
                        // txtIngresosOtros
                        // 
                        this.txtIngresosOtros.AutoHeight = false;
                        this.txtIngresosOtros.AutoNav = true;
                        this.txtIngresosOtros.AutoTab = true;
                        this.txtIngresosOtros.DataType = Lui.Forms.DataTypes.Money;
                        this.txtIngresosOtros.DecimalPlaces = -1;
                        this.txtIngresosOtros.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtIngresosOtros.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtIngresosOtros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtIngresosOtros.Location = new System.Drawing.Point(188, 400);
                        this.txtIngresosOtros.MaxLenght = 32767;
                        this.txtIngresosOtros.MultiLine = false;
                        this.txtIngresosOtros.Name = "txtIngresosOtros";
                        this.txtIngresosOtros.Padding = new System.Windows.Forms.Padding(2);
                        this.txtIngresosOtros.PasswordChar = '\0';
                        this.txtIngresosOtros.Prefijo = "";
                        this.txtIngresosOtros.ReadOnly = true;
                        this.txtIngresosOtros.SelectOnFocus = true;
                        this.txtIngresosOtros.Size = new System.Drawing.Size(104, 24);
                        this.txtIngresosOtros.Sufijo = "";
                        this.txtIngresosOtros.TabIndex = 8;
                        this.txtIngresosOtros.TabStop = false;
                        this.txtIngresosOtros.Text = "0.00";
                        this.txtIngresosOtros.TextRaw = "0.00";
                        this.txtIngresosOtros.TipWhenBlank = "";
                        this.txtIngresosOtros.ToolTipText = "";
                        // 
                        // label24
                        // 
                        this.label24.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label24.Location = new System.Drawing.Point(16, 400);
                        this.label24.Name = "label24";
                        this.label24.Size = new System.Drawing.Size(172, 24);
                        this.label24.TabIndex = 7;
                        this.label24.Text = "Otros Ingresos";
                        this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label4
                        // 
                        this.label4.BackColor = System.Drawing.Color.Silver;
                        this.label4.Location = new System.Drawing.Point(12, 152);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(280, 1);
                        this.label4.TabIndex = 69;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(4, 96);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(12, 24);
                        this.label8.TabIndex = 70;
                        this.label8.Text = "-";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label12
                        // 
                        this.label12.Location = new System.Drawing.Point(4, 124);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(12, 24);
                        this.label12.TabIndex = 73;
                        this.label12.Text = "-";
                        this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label14
                        // 
                        this.label14.Location = new System.Drawing.Point(16, 124);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(172, 24);
                        this.label14.TabIndex = 71;
                        this.label14.Text = "Gestión de Cobro";
                        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtGestionCobro
                        // 
                        this.txtGestionCobro.AutoHeight = false;
                        this.txtGestionCobro.AutoNav = true;
                        this.txtGestionCobro.AutoTab = true;
                        this.txtGestionCobro.DataType = Lui.Forms.DataTypes.Money;
                        this.txtGestionCobro.DecimalPlaces = -1;
                        this.txtGestionCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtGestionCobro.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtGestionCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtGestionCobro.Location = new System.Drawing.Point(188, 124);
                        this.txtGestionCobro.MaxLenght = 32767;
                        this.txtGestionCobro.MultiLine = false;
                        this.txtGestionCobro.Name = "txtGestionCobro";
                        this.txtGestionCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.txtGestionCobro.PasswordChar = '\0';
                        this.txtGestionCobro.Prefijo = "";
                        this.txtGestionCobro.ReadOnly = true;
                        this.txtGestionCobro.SelectOnFocus = true;
                        this.txtGestionCobro.Size = new System.Drawing.Size(104, 24);
                        this.txtGestionCobro.Sufijo = "";
                        this.txtGestionCobro.TabIndex = 72;
                        this.txtGestionCobro.TabStop = false;
                        this.txtGestionCobro.Text = "0.00";
                        this.txtGestionCobro.TextRaw = "0.00";
                        this.txtGestionCobro.TipWhenBlank = "";
                        this.txtGestionCobro.ToolTipText = "";
                        // 
                        // cmdGestionCobro
                        // 
                        this.cmdGestionCobro.AutoHeight = false;
                        this.cmdGestionCobro.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdGestionCobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdGestionCobro.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdGestionCobro.Image = null;
                        this.cmdGestionCobro.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdGestionCobro.Location = new System.Drawing.Point(296, 124);
                        this.cmdGestionCobro.Name = "cmdGestionCobro";
                        this.cmdGestionCobro.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdGestionCobro.ReadOnly = false;
                        this.cmdGestionCobro.Size = new System.Drawing.Size(28, 24);
                        this.cmdGestionCobro.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdGestionCobro.Subtext = "";
                        this.cmdGestionCobro.TabIndex = 74;
                        this.cmdGestionCobro.Text = "...";
                        this.cmdGestionCobro.ToolTipText = "";
                        this.cmdGestionCobro.Click += new System.EventHandler(this.cmdGestionCobro_Click);
                        // 
                        // IngresosEgresos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 535);
                        this.Controls.Add(this.cmdGestionCobro);
                        this.Controls.Add(this.label12);
                        this.Controls.Add(this.label14);
                        this.Controls.Add(this.txtGestionCobro);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.cmdIngresosOtros);
                        this.Controls.Add(this.txtIngresosOtros);
                        this.Controls.Add(this.label24);
                        this.Controls.Add(this.cmdCostoMateriales);
                        this.Controls.Add(this.txtCompraMateriales);
                        this.Controls.Add(this.cmdCobros);
                        this.Controls.Add(this.txtCobros);
                        this.Controls.Add(this.Label10);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.lvItems);
                        this.Controls.Add(this.cmdCostoCapital);
                        this.Controls.Add(this.txtCostoCapital);
                        this.Controls.Add(this.label26);
                        this.Controls.Add(this.label27);
                        this.Controls.Add(this.label25);
                        this.Controls.Add(this.PorTipo);
                        this.Controls.Add(this.ChartButton);
                        this.Controls.Add(this.PrintButton);
                        this.Controls.Add(this.txtFecha2);
                        this.Controls.Add(this.txtFecha1);
                        this.Controls.Add(this.txtDiferenciaBruta);
                        this.Controls.Add(this.txtDiferenciaNeta);
                        this.Controls.Add(this.cmdOtrosEgresos);
                        this.Controls.Add(this.cmdGastosVariables);
                        this.Controls.Add(this.cmdGastosFijos);
                        this.Controls.Add(this.txtOtrosEgresos);
                        this.Controls.Add(this.txtGastosVariables);
                        this.Controls.Add(this.txtGastosFijos);
                        this.Controls.Add(this.txtCosto);
                        this.Controls.Add(this.txtFacturacion);
                        this.Controls.Add(this.lblDiferenciaNetaPct);
                        this.Controls.Add(this.lblDiferenciaBrutaPct);
                        this.Controls.Add(this.Label22);
                        this.Controls.Add(this.Label20);
                        this.Controls.Add(this.Label18);
                        this.Controls.Add(this.Label17);
                        this.Controls.Add(this.Label16);
                        this.Controls.Add(this.Label15);
                        this.Controls.Add(this.Label13);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.Label9);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.KeyPreview = true;
                        this.Name = "IngresosEgresos";
                        this.Text = "Reporte Ingresos y Egresos";
                        this.Load += new System.EventHandler(this.FormRepRentabilidad_Load);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRepRentabilidad_KeyDown);
                        this.ResumeLayout(false);

                }


                #endregion

                public void MostrarReporte()
                {
                        double Facturas = this.DataBase.FieldDouble("SELECT SUM(total) FROM comprob WHERE tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM') AND compra=0 AND impresa>0 AND anulada=0 AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                        double NotasCredito = this.DataBase.FieldDouble("SELECT SUM(total) FROM comprob WHERE tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM') AND compra=0 AND impresa>0 AND anulada=0 AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");

                        double Costo = this.DataBase.FieldDouble("SELECT SUM(costo*cantidad) FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM') AND comprob.compra=0 AND comprob.impresa>0 AND comprob.numero>0 AND comprob.anulada=0 AND comprob_detalle.precio>0 AND comprob.fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                        double CostoNotasCredito = this.DataBase.FieldDouble("SELECT SUM(costo*cantidad) FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM') AND comprob.compra=0 AND comprob.impresa>0 AND comprob.numero>0 AND comprob.anulada=0 AND comprob.fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                        
                        double GestionCobro = -this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE id_concepto=24010 AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");

                        double Facturacion = Facturas - NotasCredito;
                        txtFacturacion.Text = Lfx.Types.Formatting.FormatCurrency(Facturacion, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtFacturacion.Tag = "Facturas: " + Lfx.Types.Formatting.FormatCurrency(Facturas, this.Workspace.CurrentConfig.Moneda.Decimales) + " - Notas de Crédito: " + Lfx.Types.Formatting.FormatCurrency(NotasCredito, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtCosto.Text = Lfx.Types.Formatting.FormatCurrency(Costo - CostoNotasCredito, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtCosto.Tag = "Facturas: " + Lfx.Types.Formatting.FormatCurrency(Costo, this.Workspace.CurrentConfig.Moneda.Decimales) + " - Notas de Crédito: " + Lfx.Types.Formatting.FormatCurrency(CostoNotasCredito, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtGestionCobro.Text = Lfx.Types.Formatting.FormatCurrency(GestionCobro, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtDiferenciaBruta.Text = Lfx.Types.Formatting.FormatCurrency(Facturacion - Costo + CostoNotasCredito - GestionCobro, this.Workspace.CurrentConfig.Moneda.Decimales);

                        txtCostoCapital.Text = Lfx.Types.Formatting.FormatCurrency(-(this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=220) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'")), this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtGastosFijos.Text = Lfx.Types.Formatting.FormatCurrency(-(this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=230) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'")), this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtGastosVariables.Text = Lfx.Types.Formatting.FormatCurrency(-(this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=240) AND id_concepto NOT IN (24010) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'")), this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtOtrosEgresos.Text = Lfx.Types.Formatting.FormatCurrency(-(this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE importe<0 AND id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo NOT IN (110, 210, 220, 230, 240, 300)) AND id_concepto<>26030 AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'")), this.Workspace.CurrentConfig.Moneda.Decimales);

                        if (Facturacion == 0)
                                lblDiferenciaBrutaPct.Text = "N/A";
                        else
                                lblDiferenciaBrutaPct.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtDiferenciaBruta.Text) / Lfx.Types.Parsing.ParseCurrency(txtFacturacion.Text) * 100, 1) + "%";

                        txtDiferenciaNeta.Text = Lfx.Types.Formatting.FormatCurrency(
                                        Lfx.Types.Parsing.ParseCurrency(txtDiferenciaBruta.Text)
                                        /* + Lfx.Types.Parsing.ParseCurrency(txtIngresosOtros.Text)
                                        - Lfx.Types.Parsing.ParseCurrency(txtCostoMateriales.Text) */
                                        - Lfx.Types.Parsing.ParseCurrency(txtCostoCapital.Text)
                                        - Lfx.Types.Parsing.ParseCurrency(txtGastosFijos.Text)
                                        - Lfx.Types.Parsing.ParseCurrency(txtGastosVariables.Text)
                                        - Lfx.Types.Parsing.ParseCurrency(txtOtrosEgresos.Text),
                                        this.Workspace.CurrentConfig.Moneda.Decimales);

                        if (Facturacion == 0)
                                lblDiferenciaNetaPct.Text = "N/A";
                        else
                                lblDiferenciaNetaPct.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtDiferenciaNeta.Text) / Lfx.Types.Parsing.ParseCurrency(txtFacturacion.Text) * 100, 1) + "%";


                        //Ingresos y egresos
                        txtCobros.Text = Lfx.Types.Formatting.FormatCurrency(Math.Abs(this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE (id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=110) OR id_concepto=26030 ) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'")), this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtIngresosOtros.Text = Lfx.Types.Formatting.FormatCurrency(Math.Abs(this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE importe>0 AND id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo NOT IN (110, 210, 220, 230, 240, 300)) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'")), this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtCompraMateriales.Text = Lfx.Types.Formatting.FormatCurrency(-this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=210) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'"), this.Workspace.CurrentConfig.Moneda.Decimales);

                }


                private void FormRepRentabilidad_Load(System.Object sender, System.EventArgs e)
                {
                        txtFecha1.Text = System.DateTime.Now.AddDays(-7).ToString("01/MM/yyyy");
                        txtFecha1.SelectionStart = 0;
                        txtFecha1.SelectionLength = txtFecha1.Text.Length;

                        txtFecha12_LostFocus(null, null);
                }


                public void MostrarDetalles(string Sql)
                {
                        lvItems.BeginUpdate();
                        lvItems.Items.Clear();

                        System.Data.DataTable Detalles = this.DataBase.Select(Sql);
                        foreach (System.Data.DataRow Detalle in Detalles.Rows) {
                                ListViewItem itm = lvItems.Items.Add(System.Convert.ToString(Detalle["id_movim"]));
                                itm.SubItems.Add(Lfx.Types.Formatting.FormatDate(Detalle["fecha"]));
                                itm.SubItems.Add(System.Convert.ToString(Detalle["concepto"]));
                                itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Detalle["importe"]), this.Workspace.CurrentConfig.Moneda.Decimales));
                                itm.SubItems.Add(System.Convert.ToString(Detalle["id_caja"]));
                                itm.SubItems.Add(System.Convert.ToString(Detalle["comprob"]));
                                itm.SubItems.Add(System.Convert.ToString(Detalle["obs"]));
                        }

                        lvItems.EndUpdate();
                }


                private void cmdOtrosEgresos_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE importe<0 AND id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo NOT IN (110, 210, 220, 230, 240, 300)) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }


                private void cmdGastosVariables_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=240) AND id_concepto NOT IN (24010) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }


                private void cmdCostoCapital_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=220) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }

                private void cmdCostoMateriales_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=210) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }


                private void cmdGastosFijos_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=230) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }


                private void cmdCobros_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=110) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }

                private void cmdIngresosOtros_Click(object sender, System.EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE importe>0 AND id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo NOT IN (110, 210, 220, 230, 240, 300)) AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }


                private void txtFecha12_LostFocus(object sender, System.EventArgs e)
                {
                        string sFecha1 = txtFecha1.Text;
                        string sFecha2 = txtFecha2.Text;
                        if (sFecha2.Length == 0 && sFecha1.Length > 0) {
                                sFecha2 = sFecha1;
                                sFecha2 = DateTime.DaysInMonth(Lfx.Types.Parsing.ParseInt(sFecha2.Substring(6, 4)), Lfx.Types.Parsing.ParseInt(sFecha2.Substring(3, 2))).ToString().PadLeft(2, '0') + sFecha2.Substring(2, sFecha2.Length - 2);
                                txtFecha2.Text = sFecha2;
                                txtFecha2.SelectionStart = 0;
                                txtFecha2.SelectionLength = txtFecha2.Text.Length;
                        }
                        if (sFecha2.Length > 0 && sFecha1.Length > 0) {
                                Fecha1Sql = Lfx.Types.Formatting.FormatDateSql(sFecha1).ToString() + " 00:00:00";
                                Fecha2Sql = Lfx.Types.Formatting.FormatDateSql(sFecha2).ToString() + " 23:59:59";
                                MostrarReporte();
                        }
                }


                private void lvItems_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Up:
                                        if (lvItems.Items.Count == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        } else if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0].Index == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        }
                                        break;
                                case Keys.Down:
                                        if (lvItems.Items.Count == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        } else if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0].Index == lvItems.Items.Count - 1) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        }
                                        break;
                        }

                }


                private void FormRepRentabilidad_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Escape:
                                        e.Handled = true;
                                        this.Close();
                                        break;
                                case Keys.F8:
                                        e.Handled = true;
                                        if (PrintButton.Visible && PrintButton.Enabled) {
                                                PrintButton.PerformClick();
                                        }
                                        break;
                        }

                }


                private void txtFacturacion_GotFocus(object sender, System.EventArgs e)
                {
                        txtFacturacion.ShowBalloon(System.Convert.ToString(txtFacturacion.Tag));
                }


                private void cmdImprimir_Click(System.Object sender, System.EventArgs e)
                {
                        Lui.Printing.ItemPrint ImprimirItem = new Lui.Printing.ItemPrint();
                        ImprimirItem.TamanoFuente = -2;
                        ImprimirItem.Titulo = "Reporte de Ingresos y Gastos - " + txtFecha1.Text + " al " + txtFecha2.Text;
                        ImprimirItem.AgregarPar("+ Ingresos por Facturación", Lfx.Types.Currency.CurrencySymbol + " " + txtFacturacion.Text, 1);
                        ImprimirItem.AgregarPar("- Costo de la Facturación", Lfx.Types.Currency.CurrencySymbol + " " + txtCosto.Text, 1);
                        ImprimirItem.AgregarPar("= Diferencia Bruta", Lfx.Types.Currency.CurrencySymbol + " " + txtDiferenciaBruta.Text + " (" + lblDiferenciaBrutaPct.Text + "%)", 1);
                        ImprimirItem.AgregarPar("-", "", 1);
                        ImprimirItem.AgregarPar("+ Ingresos por cobros", Lfx.Types.Currency.CurrencySymbol + " " + txtCobros.Text, 1);
                        ImprimirItem.AgregarPar("+ Otros ingresos", Lfx.Types.Currency.CurrencySymbol + " " + txtIngresosOtros.Text, 1);
                        ImprimirItem.AgregarPar("- Compra materiales", Lfx.Types.Currency.CurrencySymbol + " " + txtCompraMateriales.Text, 1);
                        ImprimirItem.AgregarPar("- Costo capital", Lfx.Types.Currency.CurrencySymbol + " " + txtCostoCapital.Text, 1);
                        ImprimirItem.AgregarPar("- Gastos Fijos", Lfx.Types.Currency.CurrencySymbol + " " + txtGastosFijos.Text, 1);
                        ImprimirItem.AgregarPar("- Gastos Variables", Lfx.Types.Currency.CurrencySymbol + " " + txtGastosVariables.Text, 1);
                        ImprimirItem.AgregarPar("- Otros Egresos", Lfx.Types.Currency.CurrencySymbol + " " + txtOtrosEgresos.Text, 1);
                        ImprimirItem.AgregarPar("-", "", 1);
                        ImprimirItem.AgregarPar("= Diferencia Neta Aprox.", Lfx.Types.Currency.CurrencySymbol + " " + txtDiferenciaNeta.Text + " (" + lblDiferenciaNetaPct.Text + "%)", 1);

                        // Determino la impresora que le corresponde
                        string sImpresora = "";
                        Lui.Printing.PrinterSelectionDialog OSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog();
                        OSeleccionarImpresora.VistaPrevia = true;
                        if (OSeleccionarImpresora.ShowDialog() == DialogResult.OK) {
                                sImpresora = OSeleccionarImpresora.SelectedPrinter;
                        }

                        if (sImpresora == "lazaro!preview") {
                                ImprimirItem.PrintController = new System.Drawing.Printing.PreviewPrintController();
                                Lui.Printing.PrintPreviewForm VistaPrevia = new Lui.Printing.PrintPreviewForm();
                                VistaPrevia.PrintPreview.Document = ImprimirItem;
                                VistaPrevia.MdiParent = this.MdiParent;
                                VistaPrevia.Show();
                        } else {
                                if (sImpresora.Length > 0) {
                                        ImprimirItem.PrinterSettings.PrinterName = sImpresora;
                                }

                                ImprimirItem.PrintController = new System.Drawing.Printing.StandardPrintController();
                                ImprimirItem.Print();
                        }

                }

                private void ChartButton_Click(object sender, System.EventArgs e)
                {
                        Lazaro.Reportes.Facturacion ChartFact = new Lazaro.Reportes.Facturacion();
                        ChartFact.MdiParent = this.MdiParent;
                        ChartFact.Show();
                }

                private void PorTipo_Click(object sender, System.EventArgs e)
                {
                        lvItems.BeginUpdate();
                        lvItems.Items.Clear();

                        double Resultado = 0;
                        Resultado += MostrarTipo(100);
                        Resultado += MostrarTipo(110);
                        Resultado += MostrarTipo(230);
                        Resultado += MostrarTipo(240);
                        Resultado += MostrarTipo(200);
                        Resultado += MostrarTipo(260);
                        Resultado += MostrarTipo(250);
                        Resultado += MostrarTipo(210);
                        Resultado += MostrarTipo(220);
                        Resultado += MostrarTipo(231);
                        Resultado += MostrarTipo(300);

                        ListViewItem itm = null;
                        itm = lvItems.Items.Add(System.Convert.ToString("total"));
                        itm.SubItems.Add("-");
                        itm.SubItems.Add("Total");
                        itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Resultado, this.Workspace.CurrentConfig.Moneda.Decimales));
                        itm.SubItems.Add("-");
                        itm.SubItems.Add("-");
                        itm.SubItems.Add("-");

                        lvItems.EndUpdate();
                }

                private double MostrarTipo(int idTipo)
                {
                        double Monto = this.DataBase.FieldDouble("SELECT SUM(importe) FROM cajas_movim WHERE id_concepto IN (SELECT id_concepto FROM conceptos WHERE grupo=" + idTipo.ToString() + ") AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                        string NombreConcepto = "?";
                        switch (idTipo) {
                                case 0:
                                        NombreConcepto = "-";
                                        break;
                                case 110:
                                        NombreConcepto = "Cobros";
                                        break;
                                case 100:
                                        NombreConcepto = "Otros ingresos";
                                        break;
                                case 230:
                                        NombreConcepto = "Gastos fijos";
                                        break;
                                case 240:
                                        NombreConcepto = "Gastos variables";
                                        break;
                                case 200:
                                        NombreConcepto = "Otros gastos";
                                        break;
                                case 260:
                                        NombreConcepto = "Pérdida";
                                        break;
                                case 250:
                                        NombreConcepto = "Reinversión";
                                        break;
                                case 210:
                                        NombreConcepto = "Costo materiales";
                                        break;
                                case 220:
                                        NombreConcepto = "Costo capital";
                                        break;
                                case 231:
                                        NombreConcepto = "Sueldos y salarios";
                                        break;
                                case 300:
                                        NombreConcepto = "Movimientos y ajustes";
                                        break;
                                default:
                                        NombreConcepto = "???";
                                        break;
                        }

                        ListViewItem itm = null;
                        itm = lvItems.Items.Add(System.Convert.ToString(idTipo.ToString()));
                        itm.SubItems.Add("-");
                        itm.SubItems.Add(NombreConcepto);
                        itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Monto, this.Workspace.CurrentConfig.Moneda.Decimales));
                        itm.SubItems.Add("-");
                        itm.SubItems.Add("-");
                        itm.SubItems.Add("-");

                        return Monto;
                }

                private void cmdGestionCobro_Click(object sender, EventArgs e)
                {
                        MostrarDetalles("SELECT * FROM cajas_movim WHERE id_concepto=24010 AND fecha BETWEEN '" + Fecha1Sql + "' AND '" + Fecha2Sql + "'");
                }
        }
}