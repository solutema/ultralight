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

namespace Lfc.Cupones.Cupones
{
        public class Filtros : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Filtros()
                        : base()
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
                internal System.Windows.Forms.Label Label16;
                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label Label14;
                internal System.Windows.Forms.Label lblFecha1;
                internal System.Windows.Forms.Label Label15;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox txtTarjeta;
                internal Lui.Forms.TextBox txtPlanInteres;
                internal Lui.Forms.TextBox txtPlanCuotas;
                internal Lui.Forms.DetailBox txtPlan;
                internal Lui.Forms.DetailBox txtCliente;
                internal Label label3;
                private Panel panel1;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lcc.Controles.RangoFechas EntradaFechas;
                internal Lui.Forms.ComboBox txtEstado;

                private void InitializeComponent()
                {
                        this.txtTarjeta = new Lui.Forms.DetailBox();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.txtPlanInteres = new Lui.Forms.TextBox();
                        this.Label14 = new System.Windows.Forms.Label();
                        this.txtPlanCuotas = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.txtPlan = new Lui.Forms.DetailBox();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaFechas = new Lcc.Controles.RangoFechas();
                        this.panel1.SuspendLayout();
                        this.tableLayoutPanel1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(354, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(474, 8);
                        // 
                        // txtTarjeta
                        // 
                        this.txtTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTarjeta.AutoHeight = true;
                        this.txtTarjeta.AutoTab = true;
                        this.txtTarjeta.CanCreate = false;
                        this.txtTarjeta.DetailField = "nombre";
                        this.txtTarjeta.ExtraDetailFields = null;
                        this.txtTarjeta.Filter = "tipo=4";
                        this.txtTarjeta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTarjeta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTarjeta.FreeTextCode = "";
                        this.txtTarjeta.KeyField = "id_formapago";
                        this.txtTarjeta.Location = new System.Drawing.Point(85, 3);
                        this.txtTarjeta.MaxLength = 200;
                        this.txtTarjeta.Name = "txtTarjeta";
                        this.txtTarjeta.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTarjeta.ReadOnly = false;
                        this.txtTarjeta.Required = true;
                        this.txtTarjeta.SelectOnFocus = false;
                        this.txtTarjeta.Size = new System.Drawing.Size(456, 24);
                        this.txtTarjeta.TabIndex = 1;
                        this.txtTarjeta.Table = "formaspago";
                        this.txtTarjeta.TeclaDespuesDeEnter = "{tab}";
                        this.txtTarjeta.Text = "0";
                        this.txtTarjeta.TextDetail = "";
                        this.txtTarjeta.TextInt = 0;
                        this.txtTarjeta.TipWhenBlank = "";
                        this.txtTarjeta.ToolTipText = "";
                        this.txtTarjeta.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label16.Location = new System.Drawing.Point(3, 0);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(76, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Tarjeta";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label11.Location = new System.Drawing.Point(3, 90);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(76, 24);
                        this.Label11.TabIndex = 5;
                        this.Label11.Text = "Estado";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPlanInteres
                        // 
                        this.txtPlanInteres.AutoHeight = false;
                        this.txtPlanInteres.AutoNav = true;
                        this.txtPlanInteres.AutoTab = true;
                        this.txtPlanInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.txtPlanInteres.DecimalPlaces = -1;
                        this.txtPlanInteres.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPlanInteres.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPlanInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPlanInteres.Location = new System.Drawing.Point(200, 0);
                        this.txtPlanInteres.MaxLenght = 32767;
                        this.txtPlanInteres.MultiLine = false;
                        this.txtPlanInteres.Name = "txtPlanInteres";
                        this.txtPlanInteres.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPlanInteres.PasswordChar = '\0';
                        this.txtPlanInteres.Prefijo = "";
                        this.txtPlanInteres.ReadOnly = true;
                        this.txtPlanInteres.SelectOnFocus = true;
                        this.txtPlanInteres.Size = new System.Drawing.Size(56, 24);
                        this.txtPlanInteres.Sufijo = "";
                        this.txtPlanInteres.TabIndex = 3;
                        this.txtPlanInteres.TabStop = false;
                        this.txtPlanInteres.Text = "0.00";
                        this.txtPlanInteres.TextRaw = "0.00";
                        this.txtPlanInteres.TipWhenBlank = "";
                        this.txtPlanInteres.ToolTipText = "";
                        // 
                        // Label14
                        // 
                        this.Label14.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label14.Location = new System.Drawing.Point(144, 0);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(56, 24);
                        this.Label14.TabIndex = 2;
                        this.Label14.Text = "Interés";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPlanCuotas
                        // 
                        this.txtPlanCuotas.AutoHeight = false;
                        this.txtPlanCuotas.AutoNav = true;
                        this.txtPlanCuotas.AutoTab = true;
                        this.txtPlanCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPlanCuotas.DecimalPlaces = -1;
                        this.txtPlanCuotas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPlanCuotas.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPlanCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPlanCuotas.Location = new System.Drawing.Point(76, 0);
                        this.txtPlanCuotas.MaxLenght = 32767;
                        this.txtPlanCuotas.MultiLine = false;
                        this.txtPlanCuotas.Name = "txtPlanCuotas";
                        this.txtPlanCuotas.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPlanCuotas.PasswordChar = '\0';
                        this.txtPlanCuotas.Prefijo = "";
                        this.txtPlanCuotas.ReadOnly = true;
                        this.txtPlanCuotas.SelectOnFocus = true;
                        this.txtPlanCuotas.Size = new System.Drawing.Size(56, 24);
                        this.txtPlanCuotas.Sufijo = "";
                        this.txtPlanCuotas.TabIndex = 1;
                        this.txtPlanCuotas.TabStop = false;
                        this.txtPlanCuotas.Text = "1";
                        this.txtPlanCuotas.TextRaw = "1";
                        this.txtPlanCuotas.TipWhenBlank = "";
                        this.txtPlanCuotas.ToolTipText = "";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblFecha1.Location = new System.Drawing.Point(20, 0);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(56, 24);
                        this.lblFecha1.TabIndex = 0;
                        this.lblFecha1.Text = "Cuotas";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPlan
                        // 
                        this.txtPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPlan.AutoHeight = true;
                        this.txtPlan.AutoTab = true;
                        this.txtPlan.CanCreate = false;
                        this.txtPlan.DetailField = "nombre";
                        this.txtPlan.ExtraDetailFields = null;
                        this.txtPlan.Filter = "";
                        this.txtPlan.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPlan.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPlan.FreeTextCode = "";
                        this.txtPlan.KeyField = "id_plan";
                        this.txtPlan.Location = new System.Drawing.Point(85, 33);
                        this.txtPlan.MaxLength = 200;
                        this.txtPlan.Name = "txtPlan";
                        this.txtPlan.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPlan.ReadOnly = false;
                        this.txtPlan.Required = false;
                        this.txtPlan.SelectOnFocus = false;
                        this.txtPlan.Size = new System.Drawing.Size(456, 24);
                        this.txtPlan.TabIndex = 3;
                        this.txtPlan.Table = "tarjetas_planes";
                        this.txtPlan.TeclaDespuesDeEnter = "{tab}";
                        this.txtPlan.Text = "0";
                        this.txtPlan.TextDetail = "";
                        this.txtPlan.TextInt = 0;
                        this.txtPlan.TipWhenBlank = "";
                        this.txtPlan.ToolTipText = "";
                        this.txtPlan.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
                        // 
                        // Label15
                        // 
                        this.Label15.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label15.Location = new System.Drawing.Point(3, 30);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(76, 24);
                        this.Label15.TabIndex = 2;
                        this.Label15.Text = "Plan";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCliente
                        // 
                        this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCliente.AutoHeight = true;
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.CanCreate = false;
                        this.txtCliente.DetailField = "nombre_visible";
                        this.txtCliente.ExtraDetailFields = null;
                        this.txtCliente.Filter = "";
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCliente.FreeTextCode = "";
                        this.txtCliente.KeyField = "id_persona";
                        this.txtCliente.Location = new System.Drawing.Point(85, 123);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = false;
                        this.txtCliente.SelectOnFocus = false;
                        this.txtCliente.Size = new System.Drawing.Size(456, 24);
                        this.txtCliente.TabIndex = 8;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(3, 120);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(76, 24);
                        this.Label1.TabIndex = 7;
                        this.Label1.Text = "Cliente";
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
                        this.txtEstado.Location = new System.Drawing.Point(85, 93);
                        this.txtEstado.MaxLenght = 32767;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.SetData = new string[] {
        "No Cobrados|-2",
        "Sin Presentar|0",
        "Cancelados|1",
        "Rechazados|2",
        "Presentados|10",
        "Acreditados|20",
        "Todos|-1"};
                        this.txtEstado.Size = new System.Drawing.Size(180, 24);
                        this.txtEstado.TabIndex = 6;
                        this.txtEstado.Table = null;
                        this.txtEstado.Text = "No Cobrados";
                        this.txtEstado.TextKey = "-2";
                        this.txtEstado.TextRaw = "No Cobrados";
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(3, 150);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(76, 24);
                        this.label3.TabIndex = 9;
                        this.label3.Text = "Fecha";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.lblFecha1);
                        this.panel1.Controls.Add(this.txtPlanCuotas);
                        this.panel1.Controls.Add(this.Label14);
                        this.panel1.Controls.Add(this.txtPlanInteres);
                        this.panel1.Location = new System.Drawing.Point(85, 63);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(260, 24);
                        this.panel1.TabIndex = 4;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFechas, 1, 5);
                        this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.txtCliente, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.txtEstado, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label16, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label15, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label11, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
                        this.tableLayoutPanel1.Controls.Add(this.txtTarjeta, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.txtPlan, 1, 1);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 6;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 288);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaFechas
                        // 
                        this.EntradaFechas.AutoHeight = true;
                        this.EntradaFechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechas.Location = new System.Drawing.Point(85, 153);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.ReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(455, 30);
                        this.EntradaFechas.TabIndex = 10;
                        this.EntradaFechas.ToolTipText = "";
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(594, 375);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Text = "Tarjetas: Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.panel1.ResumeLayout(false);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }


                #endregion

                private void txtTarjeta_TextChanged(System.Object sender, System.EventArgs e)
                {
                        txtPlan.Filter = "id_tarjeta=" + txtTarjeta.TextInt.ToString() + " OR id_tarjeta IS NULL";
                }


                private void txtPlan_TextChanged(object sender, System.EventArgs e)
                {
                        Lfx.Data.Row row = this.DataBase.Row("tarjetas_planes", "id_plan", txtPlan.TextInt);
                        if (row != null) {
                                txtPlanCuotas.Text = System.Convert.ToString(row["cuotas"]);
                                txtPlanInteres.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(row["interes"]));
                        }
                        else {
                                txtPlanCuotas.Text = "";
                                txtPlanInteres.Text = "";
                        }
                }
        }
}