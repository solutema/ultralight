#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lcc.Entrada
{
        public partial class Telefono
        {
                /// <summary> 
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary> 
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                private Lui.Forms.TextBox EntradaNombre;
                private Lui.Forms.TextBox EntradaCaracteristica;
                private Lui.Forms.TextBox EntradaNumero;
                private Lui.Forms.Label label1;
                private Lui.Forms.Label label2;

                private void InitializeComponent()
                {
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.EntradaCaracteristica = new Lui.Forms.TextBox();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.Location = new System.Drawing.Point(352, 0);
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.SelectOnFocus = true;
                        this.EntradaNombre.Size = new System.Drawing.Size(108, 24);
                        this.EntradaNombre.TabIndex = 4;
                        this.EntradaNombre.PlaceholderText = "Lugar";
                        this.EntradaNombre.TextChanged += new System.EventHandler(this.Entradas_TextChanged);
                        // 
                        // EntradaCaracteristica
                        // 
                        this.EntradaCaracteristica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaCaracteristica.AutoNav = true;
                        this.EntradaCaracteristica.AutoTab = true;
                        this.EntradaCaracteristica.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCaracteristica.DecimalPlaces = -1;
                        this.EntradaCaracteristica.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCaracteristica.Location = new System.Drawing.Point(12, 0);
                        this.EntradaCaracteristica.MultiLine = false;
                        this.EntradaCaracteristica.Name = "EntradaCaracteristica";
                        this.EntradaCaracteristica.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaracteristica.SelectOnFocus = true;
                        this.EntradaCaracteristica.Size = new System.Drawing.Size(60, 24);
                        this.EntradaCaracteristica.TabIndex = 1;
                        this.EntradaCaracteristica.PlaceholderText = "Característica";
                        this.EntradaCaracteristica.TextChanged += new System.EventHandler(this.Entradas_TextChanged);
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.Location = new System.Drawing.Point(84, 0);
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(268, 24);
                        this.EntradaNumero.TabIndex = 3;
                        this.EntradaNumero.PlaceholderText = "Número Telefónico";
                        this.EntradaNumero.TextChanged += new System.EventHandler(this.Entradas_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.label1.Location = new System.Drawing.Point(0, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(12, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "(";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.label2.Location = new System.Drawing.Point(72, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(12, 24);
                        this.label2.TabIndex = 2;
                        this.label2.Text = ")";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Telefono
                        // 
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.EntradaCaracteristica);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Name = "Telefono";
                        this.Size = new System.Drawing.Size(460, 24);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.EntradaCaracteristica, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
        }
}
