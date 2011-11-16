#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lfc.Articulos.Situaciones
{
        public partial class Editar
        {
                internal Lui.Forms.Label label9;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label Label5;

                #region Código generado por el diseñador

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

                private void InitializeComponent()
                {
                        this.label9 = new Lui.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaCuentaStock = new Lui.Forms.ComboBox();
                        this.EntradaFacturable = new Lui.Forms.ComboBox();
                        this.label1 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaDeposito = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(12, 48);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(120, 24);
                        this.label9.TabIndex = 2;
                        this.label9.Text = "Cuenta stock";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.Location = new System.Drawing.Point(136, 16);
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(336, 24);
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 16);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(120, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCuentaStock
                        // 
                        this.EntradaCuentaStock.AlwaysExpanded = false;
                        this.EntradaCuentaStock.AutoNav = true;
                        this.EntradaCuentaStock.AutoTab = true;
                        this.EntradaCuentaStock.Location = new System.Drawing.Point(136, 48);
                        this.EntradaCuentaStock.Name = "EntradaCuentaStock";
                        this.EntradaCuentaStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCuentaStock.ReadOnly = false;
                        this.EntradaCuentaStock.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaCuentaStock.Size = new System.Drawing.Size(88, 24);
                        this.EntradaCuentaStock.TabIndex = 3;
                        this.EntradaCuentaStock.TextKey = "0";
                        // 
                        // EntradaFacturable
                        // 
                        this.EntradaFacturable.AlwaysExpanded = false;
                        this.EntradaFacturable.AutoNav = true;
                        this.EntradaFacturable.AutoTab = true;
                        this.EntradaFacturable.Location = new System.Drawing.Point(136, 80);
                        this.EntradaFacturable.Name = "EntradaFacturable";
                        this.EntradaFacturable.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFacturable.ReadOnly = false;
                        this.EntradaFacturable.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaFacturable.Size = new System.Drawing.Size(88, 24);
                        this.EntradaFacturable.TabIndex = 5;
                        this.EntradaFacturable.TextKey = "0";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(12, 80);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(120, 24);
                        this.label1.TabIndex = 4;
                        this.label1.Text = "Facturable";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(12, 112);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(120, 24);
                        this.label2.TabIndex = 6;
                        this.label2.Text = "Nº de depósito";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDeposito
                        // 
                        this.EntradaDeposito.AutoNav = true;
                        this.EntradaDeposito.AutoTab = true;
                        this.EntradaDeposito.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaDeposito.DecimalPlaces = -1;
                        this.EntradaDeposito.Location = new System.Drawing.Point(136, 112);
                        this.EntradaDeposito.MultiLine = false;
                        this.EntradaDeposito.Name = "EntradaDeposito";
                        this.EntradaDeposito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDeposito.ReadOnly = false;
                        this.EntradaDeposito.SelectOnFocus = false;
                        this.EntradaDeposito.Size = new System.Drawing.Size(52, 24);
                        this.EntradaDeposito.TabIndex = 7;
                        this.EntradaDeposito.Text = "0";
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaDeposito);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaFacturable);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaCuentaStock);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(488, 237);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.EntradaCuentaStock, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaFacturable, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaDeposito, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.ComboBox EntradaCuentaStock;
                internal Lui.Forms.ComboBox EntradaFacturable;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaDeposito;
        }
}
