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

namespace Lfc.Articulos
{
        public partial class Inicio
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

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.Button BotonMovim;

                private void InitializeComponent()
                {
                        this.BotonMovim = new Lui.Forms.Button();
                        this.Frame = new Lui.Forms.Frame();
                        this.EntradatValorizacionPvp = new Lui.Forms.TextBox();
                        this.EntradaValorizacionCosto = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.Frame.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // cmdMovim
                        // 
                        this.BotonMovim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonMovim.AutoHeight = false;
                        this.BotonMovim.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonMovim.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonMovim.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonMovim.Image = null;
                        this.BotonMovim.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonMovim.Location = new System.Drawing.Point(12, 284);
                        this.BotonMovim.Name = "cmdMovim";
                        this.BotonMovim.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonMovim.ReadOnly = false;
                        this.BotonMovim.Size = new System.Drawing.Size(112, 32);
                        this.BotonMovim.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonMovim.Subtext = "F5";
                        this.BotonMovim.TabIndex = 51;
                        this.BotonMovim.Text = "Movimiento";
                        this.BotonMovim.ToolTipText = "";
                        this.BotonMovim.Click += new System.EventHandler(this.BotonMovim_Click);
                        // 
                        // Frame
                        // 
                        this.Frame.AutoHeight = false;
                        this.Frame.Controls.Add(this.EntradatValorizacionPvp);
                        this.Frame.Controls.Add(this.EntradaValorizacionCosto);
                        this.Frame.Controls.Add(this.label2);
                        this.Frame.Controls.Add(this.label3);
                        this.Frame.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Frame.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame.Location = new System.Drawing.Point(8, 72);
                        this.Frame.Name = "Frame";
                        this.Frame.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame.ReadOnly = false;
                        this.Frame.Size = new System.Drawing.Size(128, 140);
                        this.Frame.TabIndex = 54;
                        this.Frame.TabStop = false;
                        this.Frame.Text = "Valorización";
                        this.Frame.ToolTipText = "";
                        // 
                        // EntradatValorizacionPvp
                        // 
                        this.EntradatValorizacionPvp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradatValorizacionPvp.AutoHeight = false;
                        this.EntradatValorizacionPvp.AutoNav = true;
                        this.EntradatValorizacionPvp.AutoTab = true;
                        this.EntradatValorizacionPvp.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradatValorizacionPvp.DecimalPlaces = -1;
                        this.EntradatValorizacionPvp.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradatValorizacionPvp.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradatValorizacionPvp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradatValorizacionPvp.Location = new System.Drawing.Point(20, 112);
                        this.EntradatValorizacionPvp.MaxLenght = 32767;
                        this.EntradatValorizacionPvp.MultiLine = false;
                        this.EntradatValorizacionPvp.Name = "EntradatValorizacionPvp";
                        this.EntradatValorizacionPvp.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradatValorizacionPvp.PasswordChar = '\0';
                        this.EntradatValorizacionPvp.Prefijo = "$";
                        this.EntradatValorizacionPvp.ReadOnly = true;
                        this.EntradatValorizacionPvp.SelectOnFocus = true;
                        this.EntradatValorizacionPvp.Size = new System.Drawing.Size(108, 23);
                        this.EntradatValorizacionPvp.Sufijo = "";
                        this.EntradatValorizacionPvp.TabIndex = 5;
                        this.EntradatValorizacionPvp.TabStop = false;
                        this.EntradatValorizacionPvp.Text = "0.00";
                        this.EntradatValorizacionPvp.TextRaw = "0.00";
                        this.EntradatValorizacionPvp.TipWhenBlank = "";
                        this.EntradatValorizacionPvp.ToolTipText = "";
                        // 
                        // txtValorCosto
                        // 
                        this.EntradaValorizacionCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaValorizacionCosto.AutoHeight = false;
                        this.EntradaValorizacionCosto.AutoNav = true;
                        this.EntradaValorizacionCosto.AutoTab = true;
                        this.EntradaValorizacionCosto.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaValorizacionCosto.DecimalPlaces = -1;
                        this.EntradaValorizacionCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaValorizacionCosto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaValorizacionCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaValorizacionCosto.Location = new System.Drawing.Point(20, 52);
                        this.EntradaValorizacionCosto.MaxLenght = 32767;
                        this.EntradaValorizacionCosto.MultiLine = false;
                        this.EntradaValorizacionCosto.Name = "txtValorCosto";
                        this.EntradaValorizacionCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaValorizacionCosto.PasswordChar = '\0';
                        this.EntradaValorizacionCosto.Prefijo = "$";
                        this.EntradaValorizacionCosto.ReadOnly = true;
                        this.EntradaValorizacionCosto.SelectOnFocus = true;
                        this.EntradaValorizacionCosto.Size = new System.Drawing.Size(108, 22);
                        this.EntradaValorizacionCosto.Sufijo = "";
                        this.EntradaValorizacionCosto.TabIndex = 4;
                        this.EntradaValorizacionCosto.TabStop = false;
                        this.EntradaValorizacionCosto.Text = "0.00";
                        this.EntradaValorizacionCosto.TextRaw = "0.00";
                        this.EntradaValorizacionCosto.TipWhenBlank = "";
                        this.EntradaValorizacionCosto.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Location = new System.Drawing.Point(4, 32);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(124, 23);
                        this.label2.TabIndex = 1;
                        this.label2.Text = "A precio de costo";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label3
                        // 
                        this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label3.Location = new System.Drawing.Point(4, 88);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(124, 23);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "A PVP";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.BotonMovim);
                        this.Controls.Add(this.Frame);
                        this.Name = "Inicio";
                        this.Text = "Artículos: Listado";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArticulosInicio_KeyDown);
                        this.Controls.SetChildIndex(this.Frame, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonMovim, 0);
                        this.Frame.ResumeLayout(false);
                        this.Frame.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Frame Frame;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label3;
                internal Lui.Forms.TextBox EntradaValorizacionCosto;
                internal Lui.Forms.TextBox EntradatValorizacionPvp;
        }
}
