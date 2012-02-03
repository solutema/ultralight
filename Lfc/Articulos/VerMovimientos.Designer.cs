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
                        this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColDesde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColHacia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColObs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ListadoPedidos = new Lui.Forms.ListView();
                        this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Label2 = new Lui.Forms.Label();
                        this.formHeader1 = new Lui.Forms.FormHeader();
                        this.ColSeguimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.AllowColumnReorder = true;
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColFecha,
            this.ColCantidad,
            this.ColSeguimiento,
            this.ColDesde,
            this.ColHacia,
            this.ColSaldo,
            this.ColObs});
                        this.Listado.FullRowSelect = true;
                        this.Listado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.Listado.HideSelection = false;
                        this.Listado.Location = new System.Drawing.Point(24, 88);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "Listado";
                        this.Listado.Size = new System.Drawing.Size(576, 64);
                        this.Listado.TabIndex = 52;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        // 
                        // ColId
                        // 
                        this.ColId.Text = "Cód";
                        this.ColId.Width = 0;
                        // 
                        // ColFecha
                        // 
                        this.ColFecha.Text = "Fecha";
                        this.ColFecha.Width = 155;
                        // 
                        // ColCantidad
                        // 
                        this.ColCantidad.Text = "Cantidad";
                        this.ColCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColCantidad.Width = 80;
                        // 
                        // ColDesde
                        // 
                        this.ColDesde.Text = "Origen";
                        this.ColDesde.Width = 100;
                        // 
                        // ColHacia
                        // 
                        this.ColHacia.Text = "Destino";
                        this.ColHacia.Width = 100;
                        // 
                        // ColSaldo
                        // 
                        this.ColSaldo.Text = "Saldo";
                        this.ColSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColSaldo.Width = 80;
                        // 
                        // ColObs
                        // 
                        this.ColObs.Text = "Obs.";
                        this.ColObs.Width = 480;
                        // 
                        // ListadoPedidos
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
                        this.ListadoPedidos.Location = new System.Drawing.Point(24, 200);
                        this.ListadoPedidos.MultiSelect = false;
                        this.ListadoPedidos.Name = "ListadoPedidos";
                        this.ListadoPedidos.Size = new System.Drawing.Size(576, 87);
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
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        this.Label2.Location = new System.Drawing.Point(24, 163);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(576, 37);
                        this.Label2.TabIndex = 55;
                        this.Label2.Text = "Pedidos Activos";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // formHeader1
                        // 
                        this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.formHeader1.Location = new System.Drawing.Point(0, 0);
                        this.formHeader1.Name = "formHeader1";
                        this.formHeader1.Size = new System.Drawing.Size(624, 64);
                        this.formHeader1.TabIndex = 101;
                        this.formHeader1.Text = "Movimientos de existencias";
                        // 
                        // ColSeguimiento
                        // 
                        this.ColSeguimiento.Text = "Seguimiento";
                        this.ColSeguimiento.Width = 160;
                        // 
                        // VerMovimientos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(624, 364);
                        this.Controls.Add(this.formHeader1);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.ListadoPedidos);
                        this.Controls.Add(this.Listado);
                        this.Name = "VerMovimientos";
                        this.Text = "Artículos: Detalle de Entrada y Salida";
                        this.Activated += new System.EventHandler(this.FormArticulosMovimDetalles_Activated);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.ListadoPedidos, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.formHeader1, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.ListView Listado;
                internal System.Windows.Forms.ColumnHeader ColId;
                internal System.Windows.Forms.ColumnHeader ColFecha;
                internal System.Windows.Forms.ColumnHeader ColCantidad;
                internal System.Windows.Forms.ColumnHeader ColObs;
                internal System.Windows.Forms.ColumnHeader ColSaldo;
                internal Lui.Forms.ListView ListadoPedidos;
                internal System.Windows.Forms.ColumnHeader ColumnHeader1;
                internal System.Windows.Forms.ColumnHeader ColumnHeader2;
                internal System.Windows.Forms.ColumnHeader ColumnHeader3;
                internal System.Windows.Forms.ColumnHeader ColumnHeader4;
                internal Lui.Forms.Label Label2;
                internal System.Windows.Forms.ColumnHeader ColumnHeader5;
                internal System.Windows.Forms.ColumnHeader ColumnHeader6;
                internal System.Windows.Forms.ColumnHeader ColDesde;
                internal System.Windows.Forms.ColumnHeader ColHacia;
                private Lui.Forms.FormHeader formHeader1;
                private System.Windows.Forms.ColumnHeader ColSeguimiento;
        }
}