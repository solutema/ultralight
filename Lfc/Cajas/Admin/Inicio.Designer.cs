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

namespace Lfc.Cajas.Admin
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
                private Lui.Forms.TextBox txtActivos;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label3;


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.

                private void InitializeComponent()
                {
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.txtActivos = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.Size = new System.Drawing.Size(646, 566);
                        // 
                        // EntradaTotal
                        // 
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTotal.Location = new System.Drawing.Point(32, 140);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "EntradaTotal";
                        this.txtTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTotal.Prefijo = "$";
                        this.txtTotal.ReadOnly = true;
                        this.txtTotal.Size = new System.Drawing.Size(104, 24);
                        this.txtTotal.TabIndex = 52;
                        this.txtTotal.TabStop = false;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.TipWhenBlank = "";
                        this.txtTotal.ToolTipText = "";
                        // 
                        // txtActivos
                        // 
                        this.txtActivos.AutoNav = true;
                        this.txtActivos.AutoTab = true;
                        this.txtActivos.DataType = Lui.Forms.DataTypes.Money;
                        this.txtActivos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtActivos.Location = new System.Drawing.Point(32, 88);
                        this.txtActivos.MaxLenght = 32767;
                        this.txtActivos.Name = "txtActivos";
                        this.txtActivos.Padding = new System.Windows.Forms.Padding(2);
                        this.txtActivos.Prefijo = "$";
                        this.txtActivos.ReadOnly = true;
                        this.txtActivos.Size = new System.Drawing.Size(104, 24);
                        this.txtActivos.TabIndex = 53;
                        this.txtActivos.TabStop = false;
                        this.txtActivos.Text = "0.00";
                        this.txtActivos.TipWhenBlank = "";
                        this.txtActivos.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(8, 68);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(128, 20);
                        this.label2.TabIndex = 54;
                        this.label2.Text = "Activos";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(8, 120);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(128, 20);
                        this.label3.TabIndex = 55;
                        this.label3.Text = "Total";
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.txtActivos);
                        this.Controls.Add(this.txtTotal);
                        this.Name = "Inicio";
                        this.Text = "Cajas: Listado";
                        this.ResumeLayout(false);

                }
                #endregion
        }
}
