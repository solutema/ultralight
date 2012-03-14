#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tarjetas.Cupones
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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.Label Label16;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.Label Label14;
                internal Lui.Forms.Label lblFecha1;
                internal Lui.Forms.Label Label15;
                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaFormaDePago;
                internal Lui.Forms.TextBox txtPlanInteres;
                internal Lui.Forms.TextBox txtPlanCuotas;
                internal Lcc.Entrada.CodigoDetalle EntradaPlan;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Label label3;
                private Panel panel1;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lcc.Entrada.RangoFechas EntradaFechas;
                internal Lui.Forms.ComboBox EntradaEstado;

                private void InitializeComponent()
                {
                        this.EntradaFormaDePago = new Lcc.Entrada.CodigoDetalle();
                        this.Label16 = new Lui.Forms.Label();
                        this.Label11 = new Lui.Forms.Label();
                        this.txtPlanInteres = new Lui.Forms.TextBox();
                        this.Label14 = new Lui.Forms.Label();
                        this.txtPlanCuotas = new Lui.Forms.TextBox();
                        this.lblFecha1 = new Lui.Forms.Label();
                        this.EntradaPlan = new Lcc.Entrada.CodigoDetalle();
                        this.Label15 = new Lui.Forms.Label();
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.label3 = new Lui.Forms.Label();
                        this.panel1 = new Lui.Forms.Panel();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaFechas = new Lcc.Entrada.RangoFechas();
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
                        this.EntradaFormaDePago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFormaDePago.AutoSize = true;
                        this.EntradaFormaDePago.CanCreate = false;
                        this.EntradaFormaDePago.DataTextField = "nombre";
                        this.EntradaFormaDePago.Filter = "tipo=4";
                        this.EntradaFormaDePago.FreeTextCode = "";
                        this.EntradaFormaDePago.DataValueField = "id_formapago";
                        this.EntradaFormaDePago.Location = new System.Drawing.Point(85, 3);
                        this.EntradaFormaDePago.MaxLength = 200;
                        this.EntradaFormaDePago.Name = "txtTarjeta";
                        this.EntradaFormaDePago.Required = true;
                        this.EntradaFormaDePago.Size = new System.Drawing.Size(456, 24);
                        this.EntradaFormaDePago.TabIndex = 1;
                        this.EntradaFormaDePago.Table = "formaspago";
                        this.EntradaFormaDePago.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaFormaDePago.Text = "0";
                        this.EntradaFormaDePago.TextDetail = "";
                        this.EntradaFormaDePago.ValueInt = 0;
                        this.EntradaFormaDePago.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(3, 0);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(76, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Tarjeta";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(3, 90);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(76, 24);
                        this.Label11.TabIndex = 5;
                        this.Label11.Text = "Estado";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPlanInteres
                        // 
                        this.txtPlanInteres.AutoSize = false;
                        this.txtPlanInteres.DataType = Lui.Forms.DataTypes.Float;
                        this.txtPlanInteres.Location = new System.Drawing.Point(200, 0);
                        this.txtPlanInteres.Name = "txtPlanInteres";
                        this.txtPlanInteres.TemporaryReadOnly = true;
                        this.txtPlanInteres.Size = new System.Drawing.Size(56, 24);
                        this.txtPlanInteres.TabIndex = 3;
                        this.txtPlanInteres.TabStop = false;
                        this.txtPlanInteres.Text = "0.00";
                        // 
                        // Label14
                        // 
                        this.Label14.Location = new System.Drawing.Point(144, 0);
                        this.Label14.Name = "Label14";
                        this.Label14.Size = new System.Drawing.Size(56, 24);
                        this.Label14.TabIndex = 2;
                        this.Label14.Text = "Interés";
                        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPlanCuotas
                        // 
                        this.txtPlanCuotas.AutoSize = false;
                        this.txtPlanCuotas.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPlanCuotas.Location = new System.Drawing.Point(76, 0);
                        this.txtPlanCuotas.Name = "txtPlanCuotas";
                        this.txtPlanCuotas.TemporaryReadOnly = true;
                        this.txtPlanCuotas.Size = new System.Drawing.Size(56, 24);
                        this.txtPlanCuotas.TabIndex = 1;
                        this.txtPlanCuotas.TabStop = false;
                        this.txtPlanCuotas.Text = "1";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(20, 0);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(56, 24);
                        this.lblFecha1.TabIndex = 0;
                        this.lblFecha1.Text = "Cuotas";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPlan
                        // 
                        this.EntradaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPlan.AutoSize = true;
                        this.EntradaPlan.CanCreate = false;
                        this.EntradaPlan.DataTextField = "nombre";
                        this.EntradaPlan.Filter = "";
                        this.EntradaPlan.FreeTextCode = "";
                        this.EntradaPlan.DataValueField = "id_plan";
                        this.EntradaPlan.Location = new System.Drawing.Point(85, 33);
                        this.EntradaPlan.MaxLength = 200;
                        this.EntradaPlan.Name = "txtPlan";
                        this.EntradaPlan.Required = false;
                        this.EntradaPlan.Size = new System.Drawing.Size(456, 24);
                        this.EntradaPlan.TabIndex = 3;
                        this.EntradaPlan.Table = "tarjetas_planes";
                        this.EntradaPlan.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaPlan.Text = "0";
                        this.EntradaPlan.TextDetail = "";
                        this.EntradaPlan.ValueInt = 0;
                        this.EntradaPlan.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(3, 30);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(76, 24);
                        this.Label15.TabIndex = 2;
                        this.Label15.Text = "Plan";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoSize = true;
                        this.EntradaCliente.CanCreate = false;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(85, 123);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "txtCliente";
                        this.EntradaCliente.Required = false;
                        this.EntradaCliente.Size = new System.Drawing.Size(456, 24);
                        this.EntradaCliente.TabIndex = 8;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.ValueInt = 0;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 120);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(76, 24);
                        this.Label1.TabIndex = 7;
                        this.Label1.Text = "Cliente";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AutoSize = true;
                        this.EntradaEstado.Location = new System.Drawing.Point(85, 93);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.SetData = new string[] {
        "No Cobrados|-2",
        "Sin presentar|0",
        "Cancelados|1",
        "Rechazados|2",
        "Presentados|10",
        "Acreditados|20",
        "Todos|-1"};
                        this.EntradaEstado.Size = new System.Drawing.Size(180, 24);
                        this.EntradaEstado.TabIndex = 6;
                        this.EntradaEstado.Text = "No Cobrados";
                        this.EntradaEstado.TextKey = "-2";
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
                        this.tableLayoutPanel1.Controls.Add(this.EntradaCliente, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstado, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label16, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label15, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label11, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFormaDePago, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaPlan, 1, 1);
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
                        this.EntradaFechas.AutoSize = true;
                        this.EntradaFechas.Location = new System.Drawing.Point(85, 153);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Size = new System.Drawing.Size(455, 30);
                        this.EntradaFechas.TabIndex = 10;
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
                        EntradaPlan.Filter = "id_tarjeta=" + EntradaFormaDePago.ValueInt.ToString() + " OR id_tarjeta IS NULL";
                }


                private void txtPlan_TextChanged(object sender, System.EventArgs e)
                {
                        Lfx.Data.Row row = this.Connection.Row("tarjetas_planes", "id_plan", EntradaPlan.ValueInt);
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
