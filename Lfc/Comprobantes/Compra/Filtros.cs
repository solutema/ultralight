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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.ComboBox EntradaTipo;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label label3;
                internal Lui.Forms.ComboBox EntradaEstado;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lcc.Entrada.RangoFechas EntradaFechas;
                internal Lcc.Entrada.CodigoDetalle EntradaProveedor;

                private void InitializeComponent()
                {
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaProveedor = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
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
                        this.EntradaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(137, 3);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.TemporaryReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
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
                        this.EntradaTipo.Size = new System.Drawing.Size(440, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.TextKey = "PD";
                        this.EntradaTipo.PlaceholderText = "";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
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
                        // EntradaProveedor
                        // 
                        this.EntradaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProveedor.AutoSize = true;
                        this.EntradaProveedor.AutoTab = true;
                        this.EntradaProveedor.CanCreate = false;
                        this.EntradaProveedor.DataTextField = "nombre_visible";
                        this.EntradaProveedor.ExtraDetailFields = null;
                        this.EntradaProveedor.Filter = "(tipo&2)=2";
                        this.EntradaProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaProveedor.FreeTextCode = "";
                        this.EntradaProveedor.DataValueField = "id_persona";
                        this.EntradaProveedor.Location = new System.Drawing.Point(137, 63);
                        this.EntradaProveedor.MaxLength = 200;
                        this.EntradaProveedor.Name = "EntradaProveedor";
                        this.EntradaProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProveedor.TemporaryReadOnly = false;
                        this.EntradaProveedor.Required = false;
                        this.EntradaProveedor.Size = new System.Drawing.Size(440, 25);
                        this.EntradaProveedor.TabIndex = 5;
                        this.EntradaProveedor.Table = "personas";
                        this.EntradaProveedor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaProveedor.Text = "0";
                        this.EntradaProveedor.TextDetail = "";
                        this.EntradaProveedor.PlaceholderText = "";
                        this.EntradaProveedor.ToolTipText = "";
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
                        // EntradaEstado
                        // 
                        this.EntradaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstado.AutoSize = true;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.DetailField = null;
                        this.EntradaEstado.Filter = null;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEstado.KeyField = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(137, 33);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.TemporaryReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "N/A|0"};
                        this.EntradaEstado.Size = new System.Drawing.Size(440, 24);
                        this.EntradaEstado.TabIndex = 3;
                        this.EntradaEstado.Table = null;
                        this.EntradaEstado.Text = "N/A";
                        this.EntradaEstado.TextKey = "0";
                        this.EntradaEstado.PlaceholderText = "";
                        this.EntradaEstado.ToolTipText = "";
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
                        this.tableLayoutPanel1.Controls.Add(this.EntradaEstado, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaProveedor, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTipo, 1, 0);
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
                        this.EntradaFechas.AutoSize = true;
                        this.EntradaFechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechas.Location = new System.Drawing.Point(137, 94);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.TemporaryReadOnly = false;
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

                private void EntradaTipo_TextChanged(object sender, System.EventArgs e)
                {
                        switch (EntradaTipo.TextKey) {
                                case "NP":
                                        EntradaEstado.SetData = new string[] {
                                                "Todos|-2",
                                                "No pedidos|-1",
						"Pedidos|100",
                                                "Cancelados|200"
					};
                                        EntradaEstado.Enabled = true;
                                        break;
                                case "PD":
                                        EntradaEstado.SetData = new string[] {
                                                "Todos|-2",
						"Sin especificar|0",
						"No recibidos|-1",
						"Recibidos|100"
					};
                                        EntradaEstado.Enabled = true;
                                        break;
                                default:
                                        EntradaEstado.SetData = new string[] { "N/A|-1" };
                                        EntradaEstado.Enabled = false;
                                        break;
                        }

                }

                private void FormPedidosFiltros_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        EntradaTipo_TextChanged(sender, e);
                }

        }
}