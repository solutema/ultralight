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

namespace Lfc.Alicuotas
{
        public partial class Editar
        {
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaPorcentaje;
                internal Lui.Forms.TextBox EntradaImporteMinimo;
                private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el diseñador

                private void InitializeComponent()
                {
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaPorcentaje = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaImporteMinimo = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(120, 0);
                        this.EntradaNombre.MaxLength = 200;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(436, 24);
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(0, 0);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(116, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPorcentaje
                        // 
                        this.EntradaPorcentaje.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaPorcentaje.Location = new System.Drawing.Point(120, 32);
                        this.EntradaPorcentaje.Name = "EntradaPorcentaje";
                        this.EntradaPorcentaje.ReadOnly = false;
                        this.EntradaPorcentaje.Size = new System.Drawing.Size(104, 24);
                        this.EntradaPorcentaje.Sufijo = "%";
                        this.EntradaPorcentaje.TabIndex = 3;
                        this.EntradaPorcentaje.Text = "0.0000";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(0, 32);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(116, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Porcentaje";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 64);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(116, 24);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Importe Mínimo";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImporteMinimo
                        // 
                        this.EntradaImporteMinimo.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporteMinimo.Location = new System.Drawing.Point(120, 64);
                        this.EntradaImporteMinimo.Name = "EntradaImporteMinimo";
                        this.EntradaImporteMinimo.ReadOnly = false;
                        this.EntradaImporteMinimo.Size = new System.Drawing.Size(104, 24);
                        this.EntradaImporteMinimo.TabIndex = 5;
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.EntradaImporteMinimo);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaPorcentaje);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(561, 93);
                        this.ResumeLayout(false);

                }
                #endregion
        }
}
