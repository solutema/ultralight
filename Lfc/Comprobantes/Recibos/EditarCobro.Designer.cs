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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
        public partial class EditarCobro : Lui.Forms.DialogForm
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

                internal void InitializeComponent()
                {
                        this.Cobro = new Lcc.Edicion.Comprobantes.Cobro();
                        this.SuspendLayout();
                        // 
                        // Cobro
                        // 
                        this.Cobro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Cobro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Cobro.FormaDePagoEditable = true;
                        this.Cobro.FormaDePagoVisible = true;
                        this.Cobro.ImporteEditable = true;
                        this.Cobro.ImporteVisible = true;
                        this.Cobro.Location = new System.Drawing.Point(24, 24);
                        this.Cobro.Name = "Cobro";
                        this.Cobro.ObsEditable = true;
                        this.Cobro.ObsVisible = true;
                        this.Cobro.Size = new System.Drawing.Size(464, 361);
                        this.Cobro.TabIndex = 0;
                        this.Cobro.Text = "Detalles del cobro";
                        this.Cobro.TituloVisible = true;
                        // 
                        // EditarCobro
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(510, 452);
                        this.Controls.Add(this.Cobro);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "EditarCobro";
                        this.Text = "Cobro";
                        this.Controls.SetChildIndex(this.Cobro, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                public Lcc.Edicion.Comprobantes.Cobro Cobro;
        }
}
