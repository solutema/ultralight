// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
                internal Lui.Forms.Button cmdMovim;

                private void InitializeComponent()
                {
                        this.cmdMovim = new Lui.Forms.Button();
                        this.Frame = new Lui.Forms.Frame();
                        this.txtValorPVP = new Lui.Forms.TextBox();
                        this.txtValorCosto = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.Frame.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // cmdMovim
                        // 
                        this.cmdMovim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdMovim.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdMovim.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdMovim.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdMovim.Image = null;
                        this.cmdMovim.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdMovim.Location = new System.Drawing.Point(12, 284);
                        this.cmdMovim.Name = "cmdMovim";
                        this.cmdMovim.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdMovim.ReadOnly = false;
                        this.cmdMovim.Size = new System.Drawing.Size(112, 32);
                        this.cmdMovim.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdMovim.Subtext = "F5";
                        this.cmdMovim.TabIndex = 51;
                        this.cmdMovim.Text = "Movimiento";
                        this.cmdMovim.ToolTipText = "";
                        this.cmdMovim.Click += new System.EventHandler(this.cmdMovim_Click);
                        // 
                        // Frame
                        // 
                        this.Frame.Controls.Add(this.txtValorPVP);
                        this.Frame.Controls.Add(this.txtValorCosto);
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
                        // txtValorPVP
                        // 
                        this.txtValorPVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtValorPVP.AutoNav = true;
                        this.txtValorPVP.AutoTab = true;
                        this.txtValorPVP.DataType = Lui.Forms.DataTypes.Money;
                        this.txtValorPVP.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtValorPVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtValorPVP.Location = new System.Drawing.Point(20, 112);
                        this.txtValorPVP.MaxLenght = 32767;
                        this.txtValorPVP.Name = "txtValorPVP";
                        this.txtValorPVP.Padding = new System.Windows.Forms.Padding(2);
                        this.txtValorPVP.Prefijo = "$";
                        this.txtValorPVP.ReadOnly = true;
                        this.txtValorPVP.Size = new System.Drawing.Size(108, 23);
                        this.txtValorPVP.TabIndex = 5;
                        this.txtValorPVP.TabStop = false;
                        this.txtValorPVP.Text = "0.00";
                        this.txtValorPVP.TipWhenBlank = "";
                        this.txtValorPVP.ToolTipText = "";
                        // 
                        // txtValorCosto
                        // 
                        this.txtValorCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtValorCosto.AutoNav = true;
                        this.txtValorCosto.AutoTab = true;
                        this.txtValorCosto.DataType = Lui.Forms.DataTypes.Money;
                        this.txtValorCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtValorCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtValorCosto.Location = new System.Drawing.Point(20, 52);
                        this.txtValorCosto.MaxLenght = 32767;
                        this.txtValorCosto.Name = "txtValorCosto";
                        this.txtValorCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtValorCosto.Prefijo = "$";
                        this.txtValorCosto.ReadOnly = true;
                        this.txtValorCosto.Size = new System.Drawing.Size(108, 22);
                        this.txtValorCosto.TabIndex = 4;
                        this.txtValorCosto.TabStop = false;
                        this.txtValorCosto.Text = "0.00";
                        this.txtValorCosto.TipWhenBlank = "";
                        this.txtValorCosto.ToolTipText = "";
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
                        this.Controls.Add(this.Frame);
                        this.Controls.Add(this.cmdMovim);
                        this.Name = "Inicio";
                        this.Text = "Artículos: Listado";
                        this.WorkspaceChanged += new System.EventHandler(this.Inicio_WorkspaceChanged);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArticulosInicio_KeyDown);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.cmdMovim, 0);
                        this.Controls.SetChildIndex(this.Frame, 0);
                        this.Frame.ResumeLayout(false);
                        this.Frame.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Frame Frame;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label3;
                internal Lui.Forms.TextBox txtValorCosto;
                internal Lui.Forms.TextBox txtValorPVP;
        }
}
