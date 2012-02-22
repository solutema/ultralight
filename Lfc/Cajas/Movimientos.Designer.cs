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

namespace Lfc.Cajas
{
        public partial class Movimientos
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
                        this.BotonIngreso = new Lui.Forms.Button();
                        this.BotonEgreso = new Lui.Forms.Button();
                        this.BotonMovim = new Lui.Forms.Button();
                        this.BotonArqueo = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // BotonIngreso
                        // 
                        this.BotonIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonIngreso.AutoSize = false;
                        this.BotonIngreso.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonIngreso.Image = null;
                        this.BotonIngreso.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonIngreso.Location = new System.Drawing.Point(12, 352);
                        this.BotonIngreso.Name = "BotonIngreso";
                        this.BotonIngreso.Size = new System.Drawing.Size(96, 40);
                        this.BotonIngreso.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonIngreso.Subtext = "F3";
                        this.BotonIngreso.TabIndex = 40;
                        this.BotonIngreso.Text = "Ingreso";
                        this.BotonIngreso.Click += new System.EventHandler(this.BotonIngreso_Click);
                        // 
                        // BotonEgreso
                        // 
                        this.BotonEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonEgreso.AutoSize = false;
                        this.BotonEgreso.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonEgreso.Image = null;
                        this.BotonEgreso.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonEgreso.Location = new System.Drawing.Point(120, 352);
                        this.BotonEgreso.Name = "BotonEgreso";
                        this.BotonEgreso.Size = new System.Drawing.Size(96, 40);
                        this.BotonEgreso.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonEgreso.Subtext = "F4";
                        this.BotonEgreso.TabIndex = 41;
                        this.BotonEgreso.Text = "Egreso";
                        this.BotonEgreso.Click += new System.EventHandler(this.BotonEgreso_Click);
                        // 
                        // BotonMovim
                        // 
                        this.BotonMovim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonMovim.AutoSize = false;
                        this.BotonMovim.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonMovim.Image = null;
                        this.BotonMovim.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonMovim.Location = new System.Drawing.Point(12, 388);
                        this.BotonMovim.Name = "BotonMovim";
                        this.BotonMovim.Size = new System.Drawing.Size(96, 40);
                        this.BotonMovim.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonMovim.Subtext = "F5";
                        this.BotonMovim.TabIndex = 42;
                        this.BotonMovim.Text = "Movim.";
                        this.BotonMovim.Click += new System.EventHandler(this.BotonMovimiento_Click);
                        // 
                        // BotonArqueo
                        // 
                        this.BotonArqueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonArqueo.AutoSize = false;
                        this.BotonArqueo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonArqueo.Image = null;
                        this.BotonArqueo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonArqueo.Location = new System.Drawing.Point(120, 388);
                        this.BotonArqueo.Name = "BotonArqueo";
                        this.BotonArqueo.Size = new System.Drawing.Size(96, 40);
                        this.BotonArqueo.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonArqueo.Subtext = "F7";
                        this.BotonArqueo.TabIndex = 43;
                        this.BotonArqueo.Text = "Arqueo";
                        this.BotonArqueo.Click += new System.EventHandler(this.BotonArqueo_Click);
                        // 
                        // Inicio
                        // 
                        this.PanelAcciones.Controls.Add(this.BotonMovim);
                        this.PanelAcciones.Controls.Add(this.BotonIngreso);
                        this.PanelAcciones.Controls.Add(this.BotonEgreso);
                        this.PanelAcciones.Controls.Add(this.BotonArqueo);
                        this.Name = "Inicio";
                        this.ResumeLayout(false);
                }

                #endregion

                internal Lui.Forms.Button BotonIngreso;
                internal Lui.Forms.Button BotonEgreso;
                internal Lui.Forms.Button BotonMovim;
                internal Lui.Forms.Button BotonArqueo;
        }
}
