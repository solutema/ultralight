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

namespace Lui.Forms
{
        public partial class Calendar
        {
                internal System.Windows.Forms.Label lblMes;
                internal System.Windows.Forms.Label lblDia7;
                internal System.Windows.Forms.Label lblDia6;
                internal System.Windows.Forms.Label lblDia5;
                internal System.Windows.Forms.Label lblDia4;
                internal System.Windows.Forms.Label lblDia3;
                internal System.Windows.Forms.Label lblDia2;
                internal System.Windows.Forms.Label lblDia1;
                internal System.Windows.Forms.PictureBox pctFondo;

                #region Código generado por el Diseñador de Windows Forms

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
                        this.lblMes = new System.Windows.Forms.Label();
                        this.lblDia7 = new System.Windows.Forms.Label();
                        this.lblDia6 = new System.Windows.Forms.Label();
                        this.lblDia5 = new System.Windows.Forms.Label();
                        this.lblDia4 = new System.Windows.Forms.Label();
                        this.lblDia3 = new System.Windows.Forms.Label();
                        this.lblDia2 = new System.Windows.Forms.Label();
                        this.lblDia1 = new System.Windows.Forms.Label();
                        this.pctFondo = new System.Windows.Forms.PictureBox();
                        this.SuspendLayout();
                        // 
                        // lblMes
                        // 
                        this.lblMes.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblMes.BackColor = Lfx.Config.Display.CurrentTemplate.ControlBackground;
                        this.lblMes.Location = new System.Drawing.Point(8, 8);
                        this.lblMes.Name = "lblMes";
                        this.lblMes.Size = new System.Drawing.Size(220, 24);
                        this.lblMes.TabIndex = 101;
                        this.lblMes.Text = "Septiembre de 2004";
                        this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia7
                        // 
                        this.lblDia7.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia7.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia7.Location = new System.Drawing.Point(200, 36);
                        this.lblDia7.Name = "lblDia7";
                        this.lblDia7.Size = new System.Drawing.Size(28, 20);
                        this.lblDia7.TabIndex = 100;
                        this.lblDia7.Text = "S";
                        this.lblDia7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia6
                        // 
                        this.lblDia6.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia6.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia6.Location = new System.Drawing.Point(168, 36);
                        this.lblDia6.Name = "lblDia6";
                        this.lblDia6.Size = new System.Drawing.Size(28, 20);
                        this.lblDia6.TabIndex = 99;
                        this.lblDia6.Text = "Vi";
                        this.lblDia6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia5
                        // 
                        this.lblDia5.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia5.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia5.Location = new System.Drawing.Point(136, 36);
                        this.lblDia5.Name = "lblDia5";
                        this.lblDia5.Size = new System.Drawing.Size(28, 20);
                        this.lblDia5.TabIndex = 98;
                        this.lblDia5.Text = "Ju";
                        this.lblDia5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia4
                        // 
                        this.lblDia4.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia4.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia4.Location = new System.Drawing.Point(104, 36);
                        this.lblDia4.Name = "lblDia4";
                        this.lblDia4.Size = new System.Drawing.Size(28, 20);
                        this.lblDia4.TabIndex = 97;
                        this.lblDia4.Text = "Mi";
                        this.lblDia4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia3
                        // 
                        this.lblDia3.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia3.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia3.Location = new System.Drawing.Point(72, 36);
                        this.lblDia3.Name = "lblDia3";
                        this.lblDia3.Size = new System.Drawing.Size(28, 20);
                        this.lblDia3.TabIndex = 96;
                        this.lblDia3.Text = "Ma";
                        this.lblDia3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia2
                        // 
                        this.lblDia2.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia2.Location = new System.Drawing.Point(40, 36);
                        this.lblDia2.Name = "lblDia2";
                        this.lblDia2.Size = new System.Drawing.Size(28, 20);
                        this.lblDia2.TabIndex = 95;
                        this.lblDia2.Text = "Lu";
                        this.lblDia2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblDia1
                        // 
                        this.lblDia1.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.lblDia1.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
                        this.lblDia1.Location = new System.Drawing.Point(8, 36);
                        this.lblDia1.Name = "lblDia1";
                        this.lblDia1.Size = new System.Drawing.Size(28, 20);
                        this.lblDia1.TabIndex = 94;
                        this.lblDia1.Text = "Do";
                        this.lblDia1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // pctFondo
                        // 
                        this.pctFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                        this.pctFondo.Location = new System.Drawing.Point(4, 4);
                        this.pctFondo.Name = "pctFondo";
                        this.pctFondo.Size = new System.Drawing.Size(228, 204);
                        this.pctFondo.TabIndex = 102;
                        this.pctFondo.TabStop = false;
                        // 
                        // Calendar
                        // 
                        this.Controls.Add(this.lblMes);
                        this.Controls.Add(this.lblDia7);
                        this.Controls.Add(this.lblDia6);
                        this.Controls.Add(this.lblDia5);
                        this.Controls.Add(this.lblDia4);
                        this.Controls.Add(this.lblDia3);
                        this.Controls.Add(this.lblDia2);
                        this.Controls.Add(this.lblDia1);
                        this.Controls.Add(this.pctFondo);
                        this.DockPadding.All = 2;
                        this.Name = "Calendar";
                        this.Size = new System.Drawing.Size(236, 212);
                        this.ResumeLayout(false);

                        base.GotFocus += new System.EventHandler(Calendar_GotFocus);
                        base.LostFocus += new System.EventHandler(Calendar_LostFocus);
                        base.Resize += new System.EventHandler(Calendar_Resize);
                        base.KeyDown += new System.Windows.Forms.KeyEventHandler(Calendar_KeyDown);
                }


                #endregion
        }
}
