#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label label1;
                internal System.Windows.Forms.Label label2;
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
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaPorcentaje = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaImporteMinimo = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoSize = false;
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(120, 0);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(384, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
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
                        this.EntradaPorcentaje.AutoSize = false;
                        this.EntradaPorcentaje.AutoNav = true;
                        this.EntradaPorcentaje.AutoTab = true;
                        this.EntradaPorcentaje.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaPorcentaje.DecimalPlaces = -1;
                        this.EntradaPorcentaje.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPorcentaje.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPorcentaje.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPorcentaje.Location = new System.Drawing.Point(120, 32);
                        this.EntradaPorcentaje.MaxLenght = 32767;
                        this.EntradaPorcentaje.MultiLine = false;
                        this.EntradaPorcentaje.Name = "EntradaPorcentaje";
                        this.EntradaPorcentaje.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPorcentaje.PasswordChar = '\0';
                        this.EntradaPorcentaje.Prefijo = "";
                        this.EntradaPorcentaje.ReadOnly = false;
                        this.EntradaPorcentaje.SelectOnFocus = true;
                        this.EntradaPorcentaje.Size = new System.Drawing.Size(100, 24);
                        this.EntradaPorcentaje.Sufijo = "%";
                        this.EntradaPorcentaje.TabIndex = 3;
                        this.EntradaPorcentaje.Text = "0.0000";
                        this.EntradaPorcentaje.TipWhenBlank = "";
                        this.EntradaPorcentaje.ToolTipText = "";
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
                        this.EntradaImporteMinimo.AutoSize = false;
                        this.EntradaImporteMinimo.AutoNav = true;
                        this.EntradaImporteMinimo.AutoTab = true;
                        this.EntradaImporteMinimo.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporteMinimo.DecimalPlaces = -1;
                        this.EntradaImporteMinimo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaImporteMinimo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporteMinimo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaImporteMinimo.Location = new System.Drawing.Point(120, 64);
                        this.EntradaImporteMinimo.MaxLenght = 32767;
                        this.EntradaImporteMinimo.MultiLine = false;
                        this.EntradaImporteMinimo.Name = "EntradaImporteMinimo";
                        this.EntradaImporteMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporteMinimo.PasswordChar = '\0';
                        this.EntradaImporteMinimo.Prefijo = "";
                        this.EntradaImporteMinimo.ReadOnly = false;
                        this.EntradaImporteMinimo.SelectOnFocus = true;
                        this.EntradaImporteMinimo.Size = new System.Drawing.Size(100, 24);
                        this.EntradaImporteMinimo.Sufijo = "";
                        this.EntradaImporteMinimo.TabIndex = 5;
                        this.EntradaImporteMinimo.Text = "0.00";
                        this.EntradaImporteMinimo.TipWhenBlank = "";
                        this.EntradaImporteMinimo.ToolTipText = "";
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
                        this.Size = new System.Drawing.Size(504, 93);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaPorcentaje, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaImporteMinimo, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion
        }
}