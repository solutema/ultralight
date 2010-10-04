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

namespace Lfc.Cajas
{
        public partial class Inicio
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

                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.cmdIngreso = new Lui.Forms.Button();
                        this.cmdEgreso = new Lui.Forms.Button();
                        this.cmdMovim = new Lui.Forms.Button();
                        this.cmdArqueo = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // cmdIngreso
                        // 
                        this.cmdIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdIngreso.AutoHeight = false;
                        this.cmdIngreso.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdIngreso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdIngreso.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdIngreso.Image = null;
                        this.cmdIngreso.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdIngreso.Location = new System.Drawing.Point(12, 256);
                        this.cmdIngreso.Name = "cmdIngreso";
                        this.cmdIngreso.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdIngreso.ReadOnly = false;
                        this.cmdIngreso.Size = new System.Drawing.Size(108, 29);
                        this.cmdIngreso.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdIngreso.Subtext = "F3";
                        this.cmdIngreso.TabIndex = 40;
                        this.cmdIngreso.Text = "Ingreso";
                        this.cmdIngreso.ToolTipText = "";
                        this.cmdIngreso.Click += new System.EventHandler(this.BotonIngreso_Click);
                        // 
                        // cmdEgreso
                        // 
                        this.cmdEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdEgreso.AutoHeight = false;
                        this.cmdEgreso.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdEgreso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdEgreso.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdEgreso.Image = null;
                        this.cmdEgreso.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdEgreso.Location = new System.Drawing.Point(12, 288);
                        this.cmdEgreso.Name = "cmdEgreso";
                        this.cmdEgreso.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdEgreso.ReadOnly = false;
                        this.cmdEgreso.Size = new System.Drawing.Size(108, 29);
                        this.cmdEgreso.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdEgreso.Subtext = "F4";
                        this.cmdEgreso.TabIndex = 41;
                        this.cmdEgreso.Text = "Egreso";
                        this.cmdEgreso.ToolTipText = "";
                        this.cmdEgreso.Click += new System.EventHandler(this.BotonEgreso_Click);
                        // 
                        // cmdMovim
                        // 
                        this.cmdMovim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdMovim.AutoHeight = false;
                        this.cmdMovim.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdMovim.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdMovim.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdMovim.Image = null;
                        this.cmdMovim.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdMovim.Location = new System.Drawing.Point(12, 320);
                        this.cmdMovim.Name = "cmdMovim";
                        this.cmdMovim.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdMovim.ReadOnly = false;
                        this.cmdMovim.Size = new System.Drawing.Size(108, 29);
                        this.cmdMovim.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdMovim.Subtext = "F5";
                        this.cmdMovim.TabIndex = 42;
                        this.cmdMovim.Text = "Movim.";
                        this.cmdMovim.ToolTipText = "";
                        this.cmdMovim.Click += new System.EventHandler(this.BotonMovimiento_Click);
                        // 
                        // cmdArqueo
                        // 
                        this.cmdArqueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdArqueo.AutoHeight = false;
                        this.cmdArqueo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdArqueo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdArqueo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdArqueo.Image = null;
                        this.cmdArqueo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdArqueo.Location = new System.Drawing.Point(12, 352);
                        this.cmdArqueo.Name = "cmdArqueo";
                        this.cmdArqueo.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdArqueo.ReadOnly = false;
                        this.cmdArqueo.Size = new System.Drawing.Size(108, 29);
                        this.cmdArqueo.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdArqueo.Subtext = "F7";
                        this.cmdArqueo.TabIndex = 43;
                        this.cmdArqueo.Text = "Arqueo";
                        this.cmdArqueo.ToolTipText = "";
                        this.cmdArqueo.Click += new System.EventHandler(this.BotonArqueo_Click);
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.cmdMovim);
                        this.Controls.Add(this.cmdIngreso);
                        this.Controls.Add(this.cmdEgreso);
                        this.Controls.Add(this.cmdArqueo);
                        this.Name = "Inicio";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
                        this.Controls.SetChildIndex(this.EtiquetaIngresos, 0);
                        this.Controls.SetChildIndex(this.EtiquetaEgresos, 0);
                        this.Controls.SetChildIndex(this.EtiquetaSaldo, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTransporte, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.Controls.SetChildIndex(this.ItemList, 0);
                        this.Controls.SetChildIndex(this.cmdArqueo, 0);
                        this.Controls.SetChildIndex(this.cmdEgreso, 0);
                        this.Controls.SetChildIndex(this.cmdIngreso, 0);
                        this.Controls.SetChildIndex(this.cmdMovim, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Button cmdIngreso;
                internal Lui.Forms.Button cmdEgreso;
                internal Lui.Forms.Button cmdMovim;
                internal Lui.Forms.Button cmdArqueo;
        }
}
