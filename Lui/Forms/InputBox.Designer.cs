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

namespace Lui.Forms
{
        public partial class InputBox
        {
                private Lui.Forms.Label EtiquetaInfo;
                private Button OkButton;
                private TextBox Texto;
                private Button CancelBtn;
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
                        this.EtiquetaInfo = new Lui.Forms.Label();
                        this.CancelBtn = new Lui.Forms.Button();
                        this.Texto = new Lui.Forms.TextBox();
                        this.OkButton = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // EtiquetaInfo
                        // 
                        this.EtiquetaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaInfo.Location = new System.Drawing.Point(28, 24);
                        this.EtiquetaInfo.Name = "EtiquetaInfo";
                        this.EtiquetaInfo.Size = new System.Drawing.Size(312, 192);
                        this.EtiquetaInfo.TabIndex = 3;
                        // 
                        // CancelBtn
                        // 
                        this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelBtn.Image = null;
                        this.CancelBtn.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelBtn.Location = new System.Drawing.Point(352, 64);
                        this.CancelBtn.Name = "CancelBtn";
                        this.CancelBtn.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelBtn.ReadOnly = false;
                        this.CancelBtn.Size = new System.Drawing.Size(96, 32);
                        this.CancelBtn.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelBtn.Subtext = "Tecla";
                        this.CancelBtn.TabIndex = 2;
                        this.CancelBtn.Text = "Cancelar";
                        this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
                        // 
                        // Texto
                        // 
                        this.Texto.ForceCase = Lui.Forms.TextCasing.None;
                        this.Texto.Location = new System.Drawing.Point(24, 224);
                        this.Texto.Name = "Texto";
                        this.Texto.Padding = new System.Windows.Forms.Padding(2);
                        this.Texto.ReadOnly = false;
                        this.Texto.Size = new System.Drawing.Size(424, 24);
                        this.Texto.TabIndex = 0;
                        this.Texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Texto_KeyDown);
                        // 
                        // OkButton
                        // 
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(352, 24);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(96, 32);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "Tecla";
                        this.OkButton.TabIndex = 1;
                        this.OkButton.Text = "Aceptar";
                        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                        // 
                        // InputBox
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 274);
                        this.ControlBox = false;
                        this.Controls.Add(this.CancelBtn);
                        this.Controls.Add(this.Texto);
                        this.Controls.Add(this.OkButton);
                        this.Controls.Add(this.EtiquetaInfo);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "InputBox";
                        this.Text = "Ingreso de datos";
                        this.ResumeLayout(false);

                }

        }
}
