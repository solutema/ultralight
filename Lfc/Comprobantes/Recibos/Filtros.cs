// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lfc.Comprobantes.Recibos
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
                internal Lui.Forms.DetailBox txtVendedor;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.ComboBox EntradaTipo;
                internal Label label3;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lcc.Controles.RangoFechas EntradaFechas;
                internal Lui.Forms.DetailBox txtSucursal;

                private void InitializeComponent()
                {
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtVendedor = new Lui.Forms.DetailBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtSucursal = new Lui.Forms.DetailBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaFechas = new Lcc.Controles.RangoFechas();
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
                        // EntradaCliente
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
                        this.txtCliente.Location = new System.Drawing.Point(133, 63);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "EntradaCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = false;
                        this.txtCliente.SelectOnFocus = true;
                        this.txtCliente.Size = new System.Drawing.Size(448, 24);
                        this.txtCliente.TabIndex = 5;
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
                        this.Label2.Location = new System.Drawing.Point(3, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(124, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Cliente";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(3, 120);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(124, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Fecha";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaVendedor
                        // 
                        this.txtVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtVendedor.AutoHeight = true;
                        this.txtVendedor.AutoTab = true;
                        this.txtVendedor.CanCreate = false;
                        this.txtVendedor.DetailField = "nombre_visible";
                        this.txtVendedor.ExtraDetailFields = null;
                        this.txtVendedor.Filter = "(tipo&4)=4";
                        this.txtVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtVendedor.FreeTextCode = "";
                        this.txtVendedor.KeyField = "id_persona";
                        this.txtVendedor.Location = new System.Drawing.Point(133, 93);
                        this.txtVendedor.MaxLength = 200;
                        this.txtVendedor.Name = "EntradaVendedor";
                        this.txtVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtVendedor.ReadOnly = false;
                        this.txtVendedor.Required = false;
                        this.txtVendedor.SelectOnFocus = true;
                        this.txtVendedor.Size = new System.Drawing.Size(448, 24);
                        this.txtVendedor.TabIndex = 7;
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
                        this.Label5.Location = new System.Drawing.Point(3, 90);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(124, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "Vendedor";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSucursal
                        // 
                        this.txtSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtSucursal.AutoHeight = true;
                        this.txtSucursal.AutoTab = true;
                        this.txtSucursal.CanCreate = false;
                        this.txtSucursal.DetailField = "nombre";
                        this.txtSucursal.ExtraDetailFields = null;
                        this.txtSucursal.Filter = "";
                        this.txtSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSucursal.FreeTextCode = "";
                        this.txtSucursal.KeyField = "id_sucursal";
                        this.txtSucursal.Location = new System.Drawing.Point(133, 33);
                        this.txtSucursal.MaxLength = 200;
                        this.txtSucursal.Name = "txtSucursal";
                        this.txtSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSucursal.ReadOnly = false;
                        this.txtSucursal.Required = false;
                        this.txtSucursal.SelectOnFocus = true;
                        this.txtSucursal.Size = new System.Drawing.Size(448, 24);
                        this.txtSucursal.TabIndex = 3;
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
                        this.label7.Location = new System.Drawing.Point(3, 30);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(124, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Sucursal";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AutoHeight = true;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(133, 3);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "De cobro|0",
        "De pago|1"};
                        this.EntradaTipo.Size = new System.Drawing.Size(168, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.Text = "De cobro";
                        this.EntradaTipo.TextKey = "0";
                        this.EntradaTipo.TextRaw = "De cobro";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(3, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(124, 24);
                        this.label3.TabIndex = 0;
                        this.label3.Text = "Tipo";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.EntradaFechas, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.txtSucursal, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.txtCliente, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTipo, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.Label5, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.txtVendedor, 1, 3);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 5;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 280);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // EntradaFechas
                        // 
                        this.EntradaFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechas.AutoHeight = true;
                        this.EntradaFechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechas.Location = new System.Drawing.Point(133, 123);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.ReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(448, 30);
                        this.EntradaFechas.TabIndex = 9;
                        this.EntradaFechas.ToolTipText = "";
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion
       }
}