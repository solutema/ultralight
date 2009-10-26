// Copyright 2004-2009 South Bridge S.R.L.
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
using System.Collections;
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
                        this.txtPendiente = new Lui.Forms.TextBox();
                        this.txtTotal = new Lui.Forms.TextBox();
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
                        this.txtPendiente.AutoNav = true;
                        this.txtPendiente.AutoTab = true;
                        this.txtPendiente.DataType = Lui.Forms.DataTypes.Money;
                        this.txtPendiente.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPendiente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPendiente.Location = new System.Drawing.Point(44, 84);
                        this.txtPendiente.MaxLenght = 32767;
                        this.txtPendiente.Name = "txtPendiente";
                        this.txtPendiente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPendiente.ReadOnly = true;
                        this.txtPendiente.Size = new System.Drawing.Size(88, 20);
                        this.txtPendiente.TabIndex = 56;
                        this.txtPendiente.TabStop = false;
                        this.txtPendiente.Text = "0.00";
                        this.txtPendiente.TipWhenBlank = "";
                        this.txtPendiente.ToolTipText = "";
                        // 
                        // EntradaTotal
                        // 
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTotal.Location = new System.Drawing.Point(44, 60);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "EntradaTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.ReadOnly = true;
                        this.txtTotal.Size = new System.Drawing.Size(88, 20);
                        this.txtTotal.TabIndex = 54;
                        this.txtTotal.TabStop = false;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
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
                        this.Controls.Add(this.txtPendiente);
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label2);
                        this.Name = "Inicio";
                        this.Text = "Pedidos: Listado";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox txtPendiente;
                internal Lui.Forms.TextBox txtTotal;
                internal Label Label6;
                internal Label Label2;
        }
}
