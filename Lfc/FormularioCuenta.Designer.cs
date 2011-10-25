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

namespace Lfc
{
	partial class FormularioCuenta
	{
		#region Código generado por el Diseñador de Windows Forms

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


                private System.ComponentModel.IContainer components = null;

		private void InitializeComponent()
		{
                        this.lblTitulo = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EtiquetaCantidad
                        // 
                        // 
                        // lblTitulo
                        // 
                        this.lblTitulo.Location = new System.Drawing.Point(8, 8);
                        this.lblTitulo.Name = "lblTitulo";
                        this.lblTitulo.Size = new System.Drawing.Size(208, 72);
                        this.lblTitulo.TabIndex = 68;
                        this.lblTitulo.Text = "Cuentas Corrientes";
                        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.lblTitulo.UseMnemonic = false;
                        // 
                        // FormularioCuenta
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoSize = true;
                        this.ClientSize = new System.Drawing.Size(792, 472);
                        this.Controls.Add(this.lblTitulo);
                        this.Name = "FormularioCuenta";
                        this.Text = "Caja";
                        this.Controls.SetChildIndex(this.EtiquetaCantidad, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonCancelar, 0);
                        this.Controls.SetChildIndex(this.BotonFiltrar, 0);
                        this.Controls.SetChildIndex(this.BotonImprimir, 0);
                        this.Controls.SetChildIndex(this.lblTitulo, 0);
                        this.ResumeLayout(false);

		}


		#endregion

                internal Lui.Forms.Label lblTitulo;

        }
}
