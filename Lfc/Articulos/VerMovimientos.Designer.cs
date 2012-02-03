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
using System.Linq;
using System.Text;

namespace Lfc.Articulos
{
        public partial class VerMovimientos
        {
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de Windows Forms

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.Listado = new Lui.Forms.ListView();
                        this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.desde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.hacia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.saldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ListadoPedidos = new Lui.Forms.ListView();
                        this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Label1 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // lvItems
                        // 
                        this.Listado.AllowColumnReorder = true;
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fecha,
            this.cantidad,
            this.desde,
            this.hacia,
            this.saldo,
            this.obs});
                        this.Listado.FullRowSelect = true;
                        this.Listado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.Listado.HideSelection = false;
                        this.Listado.Location = new System.Drawing.Point(8, 28);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "lvItems";
                        this.Listado.Size = new System.Drawing.Size(608, 135);
                        this.Listado.TabIndex = 52;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        this.id.Width = 0;
                        // 
                        // fecha
                        // 
                        this.fecha.Text = "Fecha";
                        this.fecha.Width = 155;
                        // 
                        // cantidad
                        // 
                        this.cantidad.Text = "Cantidad";
                        this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.cantidad.Width = 80;
                        // 
                        // desde
                        // 
                        this.desde.Text = "Origen";
                        this.desde.Width = 100;
                        // 
                        // hacia
                        // 
                        this.hacia.Text = "Destino";
                        this.hacia.Width = 100;
                        // 
                        // saldo
                        // 
                        this.saldo.Text = "Saldo";
                        this.saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.saldo.Width = 80;
                        // 
                        // obs
                        // 
                        this.obs.Text = "Obs.";
                        this.obs.Width = 480;
                        // 
                        // lvPedidos
                        // 
                        this.ListadoPedidos.AllowColumnReorder = true;
                        this.ListadoPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListadoPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListadoPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader6,
            this.ColumnHeader4,
            this.ColumnHeader5});
                        this.ListadoPedidos.FullRowSelect = true;
                        this.ListadoPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListadoPedidos.HideSelection = false;
                        this.ListadoPedidos.Location = new System.Drawing.Point(8, 191);
                        this.ListadoPedidos.MultiSelect = false;
                        this.ListadoPedidos.Name = "lvPedidos";
                        this.ListadoPedidos.Size = new System.Drawing.Size(608, 104);
                        this.ListadoPedidos.TabIndex = 53;
                        this.ListadoPedidos.UseCompatibleStateImageBehavior = false;
                        this.ListadoPedidos.View = System.Windows.Forms.View.Details;
                        this.ListadoPedidos.DoubleClick += new System.EventHandler(this.lvPedidos_DoubleClick);
                        // 
                        // ColumnHeader1
                        // 
                        this.ColumnHeader1.Text = "Cód";
                        this.ColumnHeader1.Width = 0;
                        // 
                        // ColumnHeader2
                        // 
                        this.ColumnHeader2.Text = "Proveedor";
                        this.ColumnHeader2.Width = 240;
                        // 
                        // ColumnHeader3
                        // 
                        this.ColumnHeader3.Text = "Pedido";
                        this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader3.Width = 126;
                        // 
                        // ColumnHeader6
                        // 
                        this.ColumnHeader6.Text = "Fecha";
                        this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader6.Width = 120;
                        // 
                        // ColumnHeader4
                        // 
                        this.ColumnHeader4.Text = "Cantidad";
                        this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader4.Width = 96;
                        // 
                        // ColumnHeader5
                        // 
                        this.ColumnHeader5.Text = "Precio";
                        this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader5.Width = 96;
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.Location = new System.Drawing.Point(8, 8);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(608, 20);
                        this.Label1.TabIndex = 54;
                        this.Label1.Text = "Listado de Movimientos de Stock para este Artículo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.Location = new System.Drawing.Point(8, 171);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(608, 20);
                        this.Label2.TabIndex = 55;
                        this.Label2.Text = "Pedidos Activos";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // VerMovimientos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(624, 364);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.ListadoPedidos);
                        this.Controls.Add(this.Listado);
                        this.Name = "VerMovimientos";
                        this.Text = "Artículos: Detalle de Entrada y Salida";
                        this.Activated += new System.EventHandler(this.FormArticulosMovimDetalles_Activated);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.ListadoPedidos, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.ListView Listado;
                internal System.Windows.Forms.ColumnHeader id;
                internal System.Windows.Forms.ColumnHeader fecha;
                internal System.Windows.Forms.ColumnHeader cantidad;
                internal System.Windows.Forms.ColumnHeader obs;
                internal System.Windows.Forms.ColumnHeader saldo;
                internal Lui.Forms.ListView ListadoPedidos;
                internal System.Windows.Forms.ColumnHeader ColumnHeader1;
                internal System.Windows.Forms.ColumnHeader ColumnHeader2;
                internal System.Windows.Forms.ColumnHeader ColumnHeader3;
                internal System.Windows.Forms.ColumnHeader ColumnHeader4;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label2;
                internal System.Windows.Forms.ColumnHeader ColumnHeader5;
                internal System.Windows.Forms.ColumnHeader ColumnHeader6;
                internal System.Windows.Forms.ColumnHeader desde;
                internal System.Windows.Forms.ColumnHeader hacia;
        }
}