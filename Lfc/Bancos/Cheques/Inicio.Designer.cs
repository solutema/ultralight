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

namespace Lfc.Bancos.Cheques
{
        public partial class Inicio
        {
                #region Código generado por el Diseñador de Windows Forms

                // Limpiar los recursos que se están utilizando.
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

                private void InitializeComponent()
                {
                        this.DepositarPagar = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // DepositarPagar
                        // 
                        this.DepositarPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.DepositarPagar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.DepositarPagar.Image = null;
                        this.DepositarPagar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.DepositarPagar.Location = new System.Drawing.Point(12, 283);
                        this.DepositarPagar.Name = "DepositarPagar";
                        this.DepositarPagar.Padding = new System.Windows.Forms.Padding(2);
                        this.DepositarPagar.Size = new System.Drawing.Size(96, 29);
                        this.DepositarPagar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.DepositarPagar.Subtext = "F5";
                        this.DepositarPagar.TabIndex = 56;
                        this.DepositarPagar.Text = "Depositar";
                        this.DepositarPagar.Click += new System.EventHandler(this.DepositarPagar_Click);
                        // 
                        // Inicio
                        // 
                        this.PanelAcciones.Controls.Add(this.DepositarPagar);
                        this.Name = "Listado de Cheques";
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Button DepositarPagar;
        }
}
