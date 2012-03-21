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
using System.Text;

namespace Lcc.Entrada.Articulos
{
        public partial class MatrizDetalleComprobante
        {
                /// <summary> 
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary> 
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        this.EtiquetaHeaderDetalle = new Lui.Forms.Label();
                        this.EtiquetaHeaderUnitario = new Lui.Forms.Label();
                        this.EtiquetaHeaderDescuento = new Lui.Forms.Label();
                        this.EtiquetaHeaderCantidad = new Lui.Forms.Label();
                        this.EtiquetaHeaderImporte = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EtiquetaHeaderDetalle
                        // 
                        this.EtiquetaHeaderDetalle.AutoEllipsis = true;
                        this.EtiquetaHeaderDetalle.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaHeaderDetalle.Name = "EtiquetaHeaderDetalle";
                        this.EtiquetaHeaderDetalle.Size = new System.Drawing.Size(176, 18);
                        this.EtiquetaHeaderDetalle.TabIndex = 999;
                        this.EtiquetaHeaderDetalle.Text = " Detalle";
                        this.EtiquetaHeaderDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaHeaderDetalle.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        this.EtiquetaHeaderDetalle.UseMnemonic = false;
                        // 
                        // EtiquetaHeaderUnitario
                        // 
                        this.EtiquetaHeaderUnitario.AutoEllipsis = true;
                        this.EtiquetaHeaderUnitario.Location = new System.Drawing.Point(180, 0);
                        this.EtiquetaHeaderUnitario.Name = "EtiquetaHeaderUnitario";
                        this.EtiquetaHeaderUnitario.Size = new System.Drawing.Size(64, 18);
                        this.EtiquetaHeaderUnitario.TabIndex = 999;
                        this.EtiquetaHeaderUnitario.Text = " Precio";
                        this.EtiquetaHeaderUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaHeaderUnitario.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        this.EtiquetaHeaderUnitario.UseMnemonic = false;
                        // 
                        // EtiquetaHeaderDescuento
                        // 
                        this.EtiquetaHeaderDescuento.AutoEllipsis = true;
                        this.EtiquetaHeaderDescuento.Location = new System.Drawing.Point(200, 0);
                        this.EtiquetaHeaderDescuento.Name = "EtiquetaHeaderDescuento";
                        this.EtiquetaHeaderDescuento.Size = new System.Drawing.Size(64, 18);
                        this.EtiquetaHeaderDescuento.TabIndex = 999;
                        this.EtiquetaHeaderDescuento.Text = " Desc.";
                        this.EtiquetaHeaderDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaHeaderDescuento.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        this.EtiquetaHeaderDescuento.UseMnemonic = false;
                        // 
                        // EtiquetaHeaderCantidad
                        // 
                        this.EtiquetaHeaderCantidad.AutoEllipsis = true;
                        this.EtiquetaHeaderCantidad.Location = new System.Drawing.Point(248, 0);
                        this.EtiquetaHeaderCantidad.Name = "EtiquetaHeaderCantidad";
                        this.EtiquetaHeaderCantidad.Size = new System.Drawing.Size(72, 18);
                        this.EtiquetaHeaderCantidad.TabIndex = 999;
                        this.EtiquetaHeaderCantidad.Text = " Cant.";
                        this.EtiquetaHeaderCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaHeaderCantidad.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        this.EtiquetaHeaderCantidad.UseMnemonic = false;
                        // 
                        // EtiquetaHeaderImporte
                        // 
                        this.EtiquetaHeaderImporte.AutoEllipsis = true;
                        this.EtiquetaHeaderImporte.Location = new System.Drawing.Point(324, 0);
                        this.EtiquetaHeaderImporte.Name = "EtiquetaHeaderImporte";
                        this.EtiquetaHeaderImporte.Size = new System.Drawing.Size(80, 18);
                        this.EtiquetaHeaderImporte.TabIndex = 999;
                        this.EtiquetaHeaderImporte.Text = " Importe";
                        this.EtiquetaHeaderImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaHeaderImporte.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        this.EtiquetaHeaderImporte.UseMnemonic = false;
                        // 
                        // MatrizDetalleComprobante
                        // 
                        this.Controls.Add(this.EtiquetaHeaderDescuento);
                        this.Controls.Add(this.EtiquetaHeaderImporte);
                        this.Controls.Add(this.EtiquetaHeaderCantidad);
                        this.Controls.Add(this.EtiquetaHeaderUnitario);
                        this.Controls.Add(this.EtiquetaHeaderDetalle);
                        this.Name = "MatrizDetalleComprobante";
                        this.Enter += new System.EventHandler(this.ProductArray_Enter);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderDetalle, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderUnitario, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderCantidad, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderImporte, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderDescuento, 0);
                        this.ResumeLayout(false);

                }

                private Lui.Forms.Label EtiquetaHeaderDetalle;
                private Lui.Forms.Label EtiquetaHeaderUnitario;
                private Lui.Forms.Label EtiquetaHeaderDescuento;
                private Lui.Forms.Label EtiquetaHeaderCantidad;
                private Lui.Forms.Label EtiquetaHeaderImporte;
        }
}
