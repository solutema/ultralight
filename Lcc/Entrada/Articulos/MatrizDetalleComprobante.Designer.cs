#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
                        this.EtiquetaHeaderDetalle = new System.Windows.Forms.Label();
                        this.EtiquetaHeaderUnitario = new System.Windows.Forms.Label();
                        this.EtiquetaHeaderCantidad = new System.Windows.Forms.Label();
                        this.EtiquetaHeaderImporte = new System.Windows.Forms.Label();

                        this.SuspendLayout();
                        // 
                        // lblHeaderDetalle
                        // 
                        this.EtiquetaHeaderDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.EtiquetaHeaderDetalle.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaHeaderDetalle.Location = new System.Drawing.Point(0, 0);
                        this.EtiquetaHeaderDetalle.Name = "lblHeaderDetalle";
                        this.EtiquetaHeaderDetalle.Size = new System.Drawing.Size(176, 18);
                        this.EtiquetaHeaderDetalle.TabIndex = 999;
                        this.EtiquetaHeaderDetalle.Text = " Detalle";
                        this.EtiquetaHeaderDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderUnitario
                        // 
                        this.EtiquetaHeaderUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.EtiquetaHeaderUnitario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaHeaderUnitario.Location = new System.Drawing.Point(180, 0);
                        this.EtiquetaHeaderUnitario.Name = "lblHeaderUnitario";
                        this.EtiquetaHeaderUnitario.Size = new System.Drawing.Size(64, 18);
                        this.EtiquetaHeaderUnitario.TabIndex = 999;
                        this.EtiquetaHeaderUnitario.Text = " Precio";
                        this.EtiquetaHeaderUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderCantidad
                        // 
                        this.EtiquetaHeaderCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.EtiquetaHeaderCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaHeaderCantidad.Location = new System.Drawing.Point(248, 0);
                        this.EtiquetaHeaderCantidad.Name = "lblHeaderCantidad";
                        this.EtiquetaHeaderCantidad.Size = new System.Drawing.Size(72, 18);
                        this.EtiquetaHeaderCantidad.TabIndex = 999;
                        this.EtiquetaHeaderCantidad.Text = " Cant";
                        this.EtiquetaHeaderCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderImporte
                        // 
                        this.EtiquetaHeaderImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.EtiquetaHeaderImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaHeaderImporte.Location = new System.Drawing.Point(324, 0);
                        this.EtiquetaHeaderImporte.Name = "lblHeaderImporte";
                        this.EtiquetaHeaderImporte.Size = new System.Drawing.Size(80, 18);
                        this.EtiquetaHeaderImporte.TabIndex = 999;
                        this.EtiquetaHeaderImporte.Text = " Importe";
                        this.EtiquetaHeaderImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelGrilla
                        // 
                        this.PanelGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelGrilla.AutoScroll = true;
                        this.PanelGrilla.AutoScrollMargin = new System.Drawing.Size(20, 0);
                        this.PanelGrilla.Location = new System.Drawing.Point(0, 20);
                        this.PanelGrilla.Name = "PanelGrilla";
                        this.PanelGrilla.Size = new System.Drawing.Size(536, 160);
                        this.PanelGrilla.TabIndex = 999;
                        // 
                        // MatrizDetalleComprobante
                        // 
                        this.Controls.Add(this.EtiquetaHeaderDetalle);
                        this.Controls.Add(this.EtiquetaHeaderUnitario);
                        this.Controls.Add(this.EtiquetaHeaderCantidad);
                        this.Controls.Add(this.EtiquetaHeaderImporte);
                        this.Size = new System.Drawing.Size(536, 180);
                        this.Enter += new System.EventHandler(this.ProductArray_Enter);
                        this.Resize += new System.EventHandler(this.ProductArray_Resize);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderDetalle, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderUnitario, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderCantidad, 0);
                        this.Controls.SetChildIndex(this.EtiquetaHeaderImporte, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                private System.Windows.Forms.Label EtiquetaHeaderDetalle;
                private System.Windows.Forms.Label EtiquetaHeaderUnitario;
                private System.Windows.Forms.Label EtiquetaHeaderCantidad;
                private System.Windows.Forms.Label EtiquetaHeaderImporte;
        }
}
