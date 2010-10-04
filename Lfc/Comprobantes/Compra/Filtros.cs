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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Compra
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
                internal Lui.Forms.ComboBox txtTipo;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label label3;
                internal Lui.Forms.ComboBox txtEstado;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lcc.Entrada.RangoFechas EntradaFechas;
                internal Lcc.Entrada.CodigoDetalle txtProveedor;

                private void InitializeComponent()
                {
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtProveedor = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaFechas = new Lcc.Entrada.RangoFechas();
                        this.tableLayoutPanel1.SuspendLayout();
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
                        // EntradaTipo
                        // 
                        this.txtTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTipo.AutoHeight = true;
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.DetailField = null;
                        this.txtTipo.Filter = null;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTipo.KeyField = null;
                        this.txtTipo.Location = new System.Drawing.Point(137, 3);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "EntradaTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Notas de Pedido|NP",
        "Pedidos|PD",
        "Remitos|R",
        "Facturas A|FA",
        "Facturas B|FB",
        "Facturas C|FC",
        "Facturas E|FE",
        "Facturas M|FM",
        "Facturas (todas)|FP",
        "Todo|*"};
                        this.txtTipo.Size = new System.Drawing.Size(440, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Table = null;
                        this.txtTipo.Text = "Pedidos";
                        this.txtTipo.TextKey = "PD";
                        this.txtTipo.TextRaw = "Pedidos";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(3, 0);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(128, 24);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Tipo";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtProveedor
                        // 
                        this.txtProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtProveedor.AutoHeight = true;
                        this.txtProveedor.AutoTab = true;
                        this.txtProveedor.CanCreate = false;
                        this.txtProveedor.DetailField = "nombre_visible";
                        this.txtProveedor.ExtraDetailFields = null;
                        this.txtProveedor.Filter = "(tipo&2)=2";
                        this.txtProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtProveedor.FreeTextCode = "";
                        this.txtProveedor.KeyField = "id_persona";
                        this.txtProveedor.Location = new System.Drawing.Point(137, 63);
                        this.txtProveedor.MaxLength = 200;
                        this.txtProveedor.Name = "txtProveedor";
                        this.txtProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtProveedor.ReadOnly = false;
                        this.txtProveedor.Required = false;
                        this.txtProveedor.Size = new System.Drawing.Size(440, 25);
                        this.txtProveedor.TabIndex = 5;
                        this.txtProveedor.Table = "personas";
                        this.txtProveedor.TeclaDespuesDeEnter = "{tab}";
                        this.txtProveedor.Text = "0";
                        this.txtProveedor.TextDetail = "";
                        this.txtProveedor.TipWhenBlank = "";
                        this.txtProveedor.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(128, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Proveedor";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 91);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(128, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Fecha";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtEstado
                        // 
                        this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtEstado.AutoHeight = true;
                        this.txtEstado.AutoNav = true;
                        this.txtEstado.AutoTab = true;
                        this.txtEstado.DetailField = null;
                        this.txtEstado.Filter = null;
                        this.txtEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEstado.KeyField = null;
                        this.txtEstado.Location = new System.Drawing.Point(137, 33);
                        this.txtEstado.MaxLenght = 32767;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.SetData = new string[] {
        "N/A|0"};
                        this.txtEstado.Size = new System.Drawing.Size(440, 24);
                        this.txtEstado.TabIndex = 3;
                        this.txtEstado.Table = null;
                        this.txtEstado.Text = "N/A";
                        this.txtEstado.TextKey = "0";
                        this.txtEstado.TextRaw = "N/A";
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(3, 30);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(128, 24);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "Estado";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFechas, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.txtEstado, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.txtProveedor, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.txtTipo, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 28);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 4;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 252);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaFechas
                        // 
                        this.EntradaFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechas.AutoHeight = true;
                        this.EntradaFechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechas.Location = new System.Drawing.Point(137, 94);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.ReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(440, 30);
                        this.EntradaFechas.TabIndex = 7;
                        this.EntradaFechas.ToolTipText = "";
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.WorkspaceChanged += new System.EventHandler(this.FormPedidosFiltros_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }


                #endregion

                private void txtTipo_TextChanged(object sender, System.EventArgs e)
                {
                        switch (txtTipo.TextKey) {
                                case "NP":
                                        txtEstado.SetData = new string[] {
                                                "Todos|-2",
                                                "No pedidos|-1",
						"Pedidos|100",
                                                "Cancelados|200"
					};
                                        txtEstado.Enabled = true;
                                        break;
                                case "PD":
                                        txtEstado.SetData = new string[] {
                                                "Todos|-2",
						"Sin especificar|0",
						"No recibidos|-1",
						"Recibidos|100"
					};
                                        txtEstado.Enabled = true;
                                        break;
                                default:
                                        txtEstado.SetData = new string[] { "N/A|-1" };
                                        txtEstado.Enabled = false;
                                        break;
                        }

                }

                private void FormPedidosFiltros_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        txtTipo_TextChanged(sender, e);
                }

        }
}