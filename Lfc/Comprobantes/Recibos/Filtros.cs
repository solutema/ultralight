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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.Label label7;
                internal Lui.Forms.ComboBox EntradaTipo;
                internal Label label3;
                private TableLayoutPanel tableLayoutPanel1;
                internal Lcc.Entrada.RangoFechas EntradaFechas;
                internal Lcc.Entrada.CodigoDetalle EntradaSucursal;

                private void InitializeComponent()
                {
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.label3 = new Lui.Forms.Label();
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
                        // txtCliente
                        // 
                        this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCliente.AutoSize = true;
                        this.EntradaCliente.AutoNav = true;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = false;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.ExtraDetailFields = null;
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(133, 63);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "txtCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.TemporaryReadOnly = false;
                        this.EntradaCliente.Required = false;
                        this.EntradaCliente.Size = new System.Drawing.Size(448, 24);
                        this.EntradaCliente.TabIndex = 5;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
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
                        this.EntradaVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaVendedor.AutoSize = true;
                        this.EntradaVendedor.AutoNav = true;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = false;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.ExtraDetailFields = null;
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.Location = new System.Drawing.Point(133, 93);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.TemporaryReadOnly = false;
                        this.EntradaVendedor.Required = false;
                        this.EntradaVendedor.Size = new System.Drawing.Size(448, 24);
                        this.EntradaVendedor.TabIndex = 7;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
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
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSucursal.AutoSize = true;
                        this.EntradaSucursal.AutoNav = true;
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.CanCreate = false;
                        this.EntradaSucursal.DataTextField = "nombre";
                        this.EntradaSucursal.ExtraDetailFields = null;
                        this.EntradaSucursal.Filter = "";
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.DataValueField = "id_sucursal";
                        this.EntradaSucursal.Location = new System.Drawing.Point(133, 33);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.TemporaryReadOnly = false;
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(448, 24);
                        this.EntradaSucursal.TabIndex = 3;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
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
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.Location = new System.Drawing.Point(133, 3);
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.TemporaryReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "De cobro|0",
        "De pago|1"};
                        this.EntradaTipo.Size = new System.Drawing.Size(168, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Text = "De cobro";
                        this.EntradaTipo.TextKey = "0";
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
                        this.tableLayoutPanel1.Controls.Add(this.EntradaSucursal, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaCliente, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTipo, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.Label5, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaVendedor, 1, 3);
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
                        this.EntradaFechas.AutoSize = true;
                        this.EntradaFechas.Location = new System.Drawing.Point(133, 123);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.TemporaryReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(448, 30);
                        this.EntradaFechas.TabIndex = 9;
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
