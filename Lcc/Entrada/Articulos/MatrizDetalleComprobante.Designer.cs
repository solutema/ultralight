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
using System.Text;

namespace Lcc.Entrada.Articulos
{
        public partial class MatrizDetalleComprobante
        {
                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.lblHeaderDetalle = new System.Windows.Forms.Label();
                        this.lblHeaderUnitario = new System.Windows.Forms.Label();
                        this.lblHeaderCantidad = new System.Windows.Forms.Label();
                        this.lblHeaderImporte = new System.Windows.Forms.Label();
                        this.PanelGrilla = new System.Windows.Forms.Panel();
                        this.SuspendLayout();
                        // 
                        // lblHeaderDetalle
                        // 
                        this.lblHeaderDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderDetalle.Location = new System.Drawing.Point(0, 0);
                        this.lblHeaderDetalle.Name = "lblHeaderDetalle";
                        this.lblHeaderDetalle.Size = new System.Drawing.Size(176, 18);
                        this.lblHeaderDetalle.TabIndex = 999;
                        this.lblHeaderDetalle.Text = " Detalle";
                        this.lblHeaderDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderUnitario
                        // 
                        this.lblHeaderUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderUnitario.Location = new System.Drawing.Point(180, 0);
                        this.lblHeaderUnitario.Name = "lblHeaderUnitario";
                        this.lblHeaderUnitario.Size = new System.Drawing.Size(64, 18);
                        this.lblHeaderUnitario.TabIndex = 999;
                        this.lblHeaderUnitario.Text = " Precio";
                        this.lblHeaderUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderCantidad
                        // 
                        this.lblHeaderCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderCantidad.Location = new System.Drawing.Point(248, 0);
                        this.lblHeaderCantidad.Name = "lblHeaderCantidad";
                        this.lblHeaderCantidad.Size = new System.Drawing.Size(72, 18);
                        this.lblHeaderCantidad.TabIndex = 999;
                        this.lblHeaderCantidad.Text = " Cant";
                        this.lblHeaderCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeaderImporte
                        // 
                        this.lblHeaderImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                        this.lblHeaderImporte.Location = new System.Drawing.Point(324, 0);
                        this.lblHeaderImporte.Name = "lblHeaderImporte";
                        this.lblHeaderImporte.Size = new System.Drawing.Size(80, 18);
                        this.lblHeaderImporte.TabIndex = 999;
                        this.lblHeaderImporte.Text = " Importe";
                        this.lblHeaderImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
                        // ProductArray
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.BackColor = System.Drawing.SystemColors.Control;
                        this.Controls.Add(this.PanelGrilla);
                        this.Controls.Add(this.lblHeaderImporte);
                        this.Controls.Add(this.lblHeaderCantidad);
                        this.Controls.Add(this.lblHeaderUnitario);
                        this.Controls.Add(this.lblHeaderDetalle);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Name = "ProductArray";
                        this.Size = new System.Drawing.Size(536, 180);
                        this.Resize += new System.EventHandler(this.ProductArray_Resize);
                        this.Enter += new System.EventHandler(this.ProductArray_Enter);
                        this.ResumeLayout(false);

                }


                #endregion

                internal System.Windows.Forms.Label lblHeaderDetalle;
                internal System.Windows.Forms.Label lblHeaderUnitario;
                internal System.Windows.Forms.Label lblHeaderCantidad;
                internal System.Windows.Forms.Label lblHeaderImporte;
                internal System.Windows.Forms.Panel PanelGrilla;
        }
}
