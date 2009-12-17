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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lfc.Bancos.Chequeras
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                #region Código generado por el Diseñador de Windows Forms

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

                private Lui.Forms.TextBox txtTotal;


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.

                private void InitializeComponent()
                {
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // lvItems
                        // 
                        this.Listado.Name = "lvItems";
                        this.Listado.Size = new System.Drawing.Size(646, 566);
                        // 
                        // CreateButton
                        // 
                        this.BotonCrear.DockPadding.All = 2;
                        this.BotonCrear.Name = "CreateButton";
                        // 
                        // FiltersButton
                        // 
                        this.BotonFiltrar.DockPadding.All = 2;
                        this.BotonFiltrar.Name = "FiltersButton";
                        this.BotonFiltrar.Visible = true;
                        // 
                        // PrintButton
                        // 
                        this.BotonImprimir.DockPadding.All = 2;
                        this.BotonImprimir.Name = "PrintButton";
                        // 
                        // EntradaTotal
                        // 
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.DockPadding.All = 2;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTotal.Location = new System.Drawing.Point(8, 92);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "EntradaTotal";
                        this.txtTotal.ReadOnly = false;
                        this.txtTotal.Size = new System.Drawing.Size(128, 28);
                        this.txtTotal.TabIndex = 52;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.ToolTipText = "";
                        this.txtTotal.Workspace = null;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.txtTotal);
                        this.Name = "Inicio";
                        this.ResumeLayout(false);

                }

                #endregion

        }
}
