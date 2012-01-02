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

namespace Lui.Printing
{
        public partial class PrintPreviewForm
        {
                public System.Windows.Forms.PrintPreviewControl PrintPreview;
                internal Lui.Forms.Button CancelCommandButton;
                internal Lui.Forms.Button SaveButton;
                internal System.Windows.Forms.Panel LowerPanel;
                internal Lui.Forms.Button BotonZoom;

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
                        this.PrintPreview = new System.Windows.Forms.PrintPreviewControl();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.SaveButton = new Lui.Forms.Button();
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.BotonZoom = new Lui.Forms.Button();
                        this.LowerPanel.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // PrintPreview
                        // 
                        this.PrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                        this.PrintPreview.Location = new System.Drawing.Point(0, 0);
                        this.PrintPreview.Name = "PrintPreview";
                        this.PrintPreview.Size = new System.Drawing.Size(616, 344);
                        this.PrintPreview.TabIndex = 500;
                        this.PrintPreview.UseAntiAlias = true;
                        this.PrintPreview.Zoom = 1;
                        this.PrintPreview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintPreview_KeyDown);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.DockPadding.All = 2;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(524, 6);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.TemporaryReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(84, 40);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 111;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.SaveButton.DockPadding.All = 2;
                        this.SaveButton.Image = null;
                        this.SaveButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.SaveButton.Location = new System.Drawing.Point(432, 6);
                        this.SaveButton.Name = "SaveButton";
                        this.SaveButton.TemporaryReadOnly = false;
                        this.SaveButton.Size = new System.Drawing.Size(84, 40);
                        this.SaveButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.SaveButton.Subtext = "F8";
                        this.SaveButton.TabIndex = 110;
                        this.SaveButton.Text = "Imprimir";
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.BotonZoom);
                        this.LowerPanel.Controls.Add(this.SaveButton);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 353);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(616, 52);
                        this.LowerPanel.TabIndex = 106;
                        // 
                        // BotonZoom
                        // 
                        this.BotonZoom.DockPadding.All = 2;
                        this.BotonZoom.Image = null;
                        this.BotonZoom.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonZoom.Location = new System.Drawing.Point(8, 6);
                        this.BotonZoom.Name = "BotonZoom";
                        this.BotonZoom.TemporaryReadOnly = false;
                        this.BotonZoom.Size = new System.Drawing.Size(84, 40);
                        this.BotonZoom.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonZoom.Subtext = "F2";
                        this.BotonZoom.TabIndex = 101;
                        this.BotonZoom.Text = "Zoom";
                        this.BotonZoom.Click += new System.EventHandler(this.BotonZoom_Click);
                        // 
                        // PrintPreviewForm
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(616, 405);
                        this.Controls.Add(this.LowerPanel);
                        this.Controls.Add(this.PrintPreview);
                        this.KeyPreview = true;
                        this.Name = "PrintPreviewForm";
                        this.Text = "Vista Previa";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVistaPrevia_KeyDown);
                        this.LowerPanel.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion
        }
}
