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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Compra
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
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.

                private void InitializeComponent()
                {
                        this.EntradaPendiente = new Lui.Forms.TextBox();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // lvItems
                        // 
                        this.Listado.Size = new System.Drawing.Size(546, 466);
                        // 
                        // txtPendiente
                        // 
                        this.EntradaPendiente.AutoNav = true;
                        this.EntradaPendiente.AutoTab = true;
                        this.EntradaPendiente.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaPendiente.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPendiente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPendiente.Location = new System.Drawing.Point(44, 84);
                        this.EntradaPendiente.MaxLenght = 32767;
                        this.EntradaPendiente.Name = "txtPendiente";
                        this.EntradaPendiente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPendiente.ReadOnly = true;
                        this.EntradaPendiente.Size = new System.Drawing.Size(88, 20);
                        this.EntradaPendiente.TabIndex = 56;
                        this.EntradaPendiente.TabStop = false;
                        this.EntradaPendiente.Text = "0.00";
                        this.EntradaPendiente.TipWhenBlank = "";
                        this.EntradaPendiente.ToolTipText = "";
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTotal.Location = new System.Drawing.Point(44, 60);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.ReadOnly = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(88, 20);
                        this.EntradaTotal.TabIndex = 54;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(8, 84);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(44, 20);
                        this.Label6.TabIndex = 55;
                        this.Label6.Text = "Pend.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(8, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(44, 20);
                        this.Label2.TabIndex = 53;
                        this.Label2.Text = "Total";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.EntradaPendiente);
                        this.Controls.Add(this.EntradaTotal);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label2);
                        this.Name = "Inicio";
                        this.Text = "Pedidos: Listado";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaPendiente;
                internal Lui.Forms.TextBox EntradaTotal;
                internal Label Label6;
                internal Label Label2;
        }
}
