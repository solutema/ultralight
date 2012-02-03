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

using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class WorkspaceSelectorForm
        {
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null)
                                        components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                private System.ComponentModel.IContainer components = null;

                #region Código generado por el diseñador

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkspaceSelectorForm));
                        this.label1 = new Lui.Forms.Label();
                        this.Espacios = new System.Windows.Forms.ListBox();
                        this.PanelLogo = new Lui.Forms.Panel();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.PanelLogo.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        this.label1.Location = new System.Drawing.Point(124, 24);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(400, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Seleccione el espacio de trabajo";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Espacios
                        // 
                        this.Espacios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Espacios.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Espacios.IntegralHeight = false;
                        this.Espacios.ItemHeight = 15;
                        this.Espacios.Location = new System.Drawing.Point(124, 52);
                        this.Espacios.Name = "Espacios";
                        this.Espacios.Size = new System.Drawing.Size(400, 156);
                        this.Espacios.Sorted = true;
                        this.Espacios.TabIndex = 1;
                        this.Espacios.SelectedValueChanged += new System.EventHandler(this.Espacios_SelectedValueChanged);
                        this.Espacios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Espacios_KeyDown);
                        // 
                        // PanelLogo
                        // 
                        this.PanelLogo.BackColor = System.Drawing.Color.White;
                        this.PanelLogo.Controls.Add(this.PictureBox1);
                        this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Left;
                        this.PanelLogo.Location = new System.Drawing.Point(0, 0);
                        this.PanelLogo.Name = "PanelLogo";
                        this.PanelLogo.Size = new System.Drawing.Size(100, 248);
                        this.PanelLogo.TabIndex = 52;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(20, 112);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(37, 120);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.PictureBox1.TabIndex = 51;
                        this.PictureBox1.TabStop = false;
                        // 
                        // WorkspaceSelectorForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(546, 312);
                        this.Controls.Add(this.Espacios);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.PanelLogo);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "WorkspaceSelectorForm";
                        this.Text = "Espacio de trabajo";
                        this.Controls.SetChildIndex(this.PanelLogo, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.Espacios, 0);
                        this.PanelLogo.ResumeLayout(false);
                        this.PanelLogo.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }
                #endregion

                private Lui.Forms.Label label1;
                private System.Windows.Forms.ListBox Espacios;
                private Lui.Forms.Panel PanelLogo;
                internal PictureBox PictureBox1;
        }
}
