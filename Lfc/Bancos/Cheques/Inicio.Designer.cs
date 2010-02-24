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

namespace Lfc.Bancos.Cheques
{
        public partial class Inicio : Lui.Forms.ListingForm
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

                private void InitializeComponent()
                {
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaTotal = new Lui.Forms.TextBox();
                        this.DepositarPagar = new Lui.Forms.Button();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaSinCobrar = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.Size = new System.Drawing.Size(544, 472);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(8, 68);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(124, 20);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Total";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTotal
                        // 
                        this.EntradaTotal.AutoHeight = false;
                        this.EntradaTotal.AutoNav = true;
                        this.EntradaTotal.AutoTab = true;
                        this.EntradaTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaTotal.DecimalPlaces = -1;
                        this.EntradaTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTotal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTotal.Location = new System.Drawing.Point(32, 88);
                        this.EntradaTotal.MaxLenght = 32767;
                        this.EntradaTotal.MultiLine = false;
                        this.EntradaTotal.Name = "EntradaTotal";
                        this.EntradaTotal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTotal.PasswordChar = '\0';
                        this.EntradaTotal.Prefijo = "$";
                        this.EntradaTotal.ReadOnly = true;
                        this.EntradaTotal.SelectOnFocus = true;
                        this.EntradaTotal.Size = new System.Drawing.Size(100, 24);
                        this.EntradaTotal.Sufijo = "";
                        this.EntradaTotal.TabIndex = 3;
                        this.EntradaTotal.TabStop = false;
                        this.EntradaTotal.Text = "0.00";
                        this.EntradaTotal.TextRaw = "0.00";
                        this.EntradaTotal.TipWhenBlank = "";
                        this.EntradaTotal.ToolTipText = "";
                        // 
                        // DepositarPagar
                        // 
                        this.DepositarPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.DepositarPagar.AutoHeight = false;
                        this.DepositarPagar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.DepositarPagar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.DepositarPagar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.DepositarPagar.Image = null;
                        this.DepositarPagar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.DepositarPagar.Location = new System.Drawing.Point(12, 283);
                        this.DepositarPagar.Name = "DepositarPagar";
                        this.DepositarPagar.Padding = new System.Windows.Forms.Padding(2);
                        this.DepositarPagar.ReadOnly = false;
                        this.DepositarPagar.Size = new System.Drawing.Size(112, 32);
                        this.DepositarPagar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.DepositarPagar.Subtext = "F5";
                        this.DepositarPagar.TabIndex = 56;
                        this.DepositarPagar.Text = "Depositar";
                        this.DepositarPagar.ToolTipText = "";
                        this.DepositarPagar.Click += new System.EventHandler(this.DepositarPagar_Click);
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(8, 124);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(124, 20);
                        this.label1.TabIndex = 4;
                        this.label1.Text = "Sin cobrar";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSinCobrar
                        // 
                        this.EntradaSinCobrar.AutoHeight = false;
                        this.EntradaSinCobrar.AutoNav = true;
                        this.EntradaSinCobrar.AutoTab = true;
                        this.EntradaSinCobrar.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaSinCobrar.DecimalPlaces = -1;
                        this.EntradaSinCobrar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSinCobrar.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSinCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaSinCobrar.Location = new System.Drawing.Point(32, 144);
                        this.EntradaSinCobrar.MaxLenght = 32767;
                        this.EntradaSinCobrar.MultiLine = false;
                        this.EntradaSinCobrar.Name = "EntradaSinCobrar";
                        this.EntradaSinCobrar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSinCobrar.PasswordChar = '\0';
                        this.EntradaSinCobrar.Prefijo = "$";
                        this.EntradaSinCobrar.ReadOnly = true;
                        this.EntradaSinCobrar.SelectOnFocus = true;
                        this.EntradaSinCobrar.Size = new System.Drawing.Size(100, 24);
                        this.EntradaSinCobrar.Sufijo = "";
                        this.EntradaSinCobrar.TabIndex = 5;
                        this.EntradaSinCobrar.TabStop = false;
                        this.EntradaSinCobrar.Text = "0.00";
                        this.EntradaSinCobrar.TextRaw = "0.00";
                        this.EntradaSinCobrar.TipWhenBlank = "";
                        this.EntradaSinCobrar.ToolTipText = "";
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 472);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaSinCobrar);
                        this.Controls.Add(this.DepositarPagar);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaTotal);
                        this.Name = "Inicio";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
                        this.Controls.SetChildIndex(this.EntradaTotal, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.DepositarPagar, 0);
                        this.Controls.SetChildIndex(this.EntradaSinCobrar, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox EntradaTotal;
                internal Lui.Forms.Button DepositarPagar;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaSinCobrar;
        }
}
