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

                private Lui.Forms.TextBox EntradaTotal;
                private Lui.Forms.TextBox EntradaActivos;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label3;


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.

                private void InitializeComponent()
                {
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.EntradaActivos = new Lui.Forms.TextBox();
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
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(32, 140);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(104, 24);
                        this.EntradaTotal.TabIndex = 52;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        // 
                        // txtActivos
                        // 
                        this.EntradaActivos.AutoNav = true;
                        this.EntradaActivos.AutoTab = true;
                        this.EntradaActivos.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaActivos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaActivos.Location = new System.Drawing.Point(32, 88);
                        this.EntradaActivos.MaxLenght = 32767;
                        this.EntradaActivos.Name = "txtActivos";
                        this.EntradaActivos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaActivos.Prefijo = "$";
                        this.EntradaActivos.ReadOnly = true;
                        this.EntradaActivos.Size = new System.Drawing.Size(104, 24);
                        this.EntradaActivos.TabIndex = 53;
                        this.EntradaActivos.TabStop = false;
                        this.EntradaActivos.Text = "0.00";
                        this.EntradaActivos.TipWhenBlank = "";
                        this.EntradaActivos.ToolTipText = "";
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
                        this.Controls.Add(this.EntradaActivos);
                        this.Controls.Add(this.EntradaTotal);
                        this.Name = "Inicio";
                        this.Text = "Cajas: Listado";
                        this.ResumeLayout(false);

                }
                #endregion
        }
}
