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

namespace Lfc.Comprobantes.Recibos
{
        partial class EditarPago
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

                #region Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.Pago = new Lcc.Edicion.Comprobantes.Pago();
                        this.SuspendLayout();
                        // 
                        // Pago
                        // 
                        this.Pago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Pago.FormaDePagoEditable = true;
                        this.Pago.FormaDePagoVisible = true;
                        this.Pago.ImporteEditable = true;
                        this.Pago.ImporteVisible = true;
                        this.Pago.Location = new System.Drawing.Point(24, 24);
                        this.Pago.Name = "Pago";
                        this.Pago.ObsVisible = true;
                        this.Pago.Size = new System.Drawing.Size(464, 368);
                        this.Pago.TabIndex = 0;
                        this.Pago.Text = "Detalles del pago";
                        this.Pago.TituloVisible = true;
                        // 
                        // EditarPago
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(510, 452);
                        this.Controls.Add(this.Pago);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "EditarPago";
                        this.Text = "Editar pago";
                        this.Controls.SetChildIndex(this.Pago, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                public Lcc.Edicion.Comprobantes.Pago Pago;

        }
}
