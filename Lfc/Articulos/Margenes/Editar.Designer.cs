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

namespace Lfc.Articulos.Margenes
{
        public partial class Editar
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

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.EntradaPorcentaje = new Lui.Forms.TextBox();
                        this.Label12 = new Lui.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaPredet = new Lui.Forms.ComboBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaPorcentaje
                        // 
                        this.EntradaPorcentaje.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaPorcentaje.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPorcentaje.Location = new System.Drawing.Point(140, 32);
                        this.EntradaPorcentaje.Name = "EntradaPorcentaje";
                        this.EntradaPorcentaje.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPorcentaje.ReadOnly = false;
                        this.EntradaPorcentaje.Size = new System.Drawing.Size(108, 24);
                        this.EntradaPorcentaje.TabIndex = 3;
                        this.EntradaPorcentaje.Text = "0.0000";
                        // 
                        // Label12
                        // 
                        this.Label12.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label12.Location = new System.Drawing.Point(0, 32);
                        this.Label12.Name = "Label12";
                        this.Label12.Size = new System.Drawing.Size(140, 24);
                        this.Label12.TabIndex = 2;
                        this.Label12.Text = "Porcentaje";
                        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(140, 0);
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(404, 24);
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(0, 0);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(140, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPredet
                        // 
                        this.EntradaPredet.AlwaysExpanded = true;
                        this.EntradaPredet.AutoSize = true;
                        this.EntradaPredet.Location = new System.Drawing.Point(140, 64);
                        this.EntradaPredet.Name = "EntradaPredet";
                        this.EntradaPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPredet.ReadOnly = false;
                        this.EntradaPredet.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaPredet.Size = new System.Drawing.Size(108, 36);
                        this.EntradaPredet.TabIndex = 5;
                        this.EntradaPredet.TextKey = "0";
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label7.Location = new System.Drawing.Point(0, 64);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(140, 24);
                        this.Label7.TabIndex = 4;
                        this.Label7.Text = "Predeterminado";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaPredet);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaPorcentaje);
                        this.Controls.Add(this.Label12);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(556, 297);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.TextBox EntradaPorcentaje;
                internal Lui.Forms.Label Label12;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.ComboBox EntradaPredet;
                internal Lui.Forms.Label Label7;
        }
}
