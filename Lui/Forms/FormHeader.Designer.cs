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

namespace Lui.Forms
{
        partial class FormHeader
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

                #region Código generado por el Diseñador de componentes

                /// <summary> 
                /// Método necesario para admitir el Diseñador. No se puede modificar 
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.ImageIcon = new System.Windows.Forms.PictureBox();
                        this.LabelColor = new System.Windows.Forms.Label();
                        this.LabelColor2 = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.LabelCaption = new Lui.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // ImageIcon
                        // 
                        this.ImageIcon.Image = global::Lui.Properties.Resources.form;
                        this.ImageIcon.Location = new System.Drawing.Point(32, 16);
                        this.ImageIcon.Name = "ImageIcon";
                        this.ImageIcon.Size = new System.Drawing.Size(32, 32);
                        this.ImageIcon.TabIndex = 1;
                        this.ImageIcon.TabStop = false;
                        // 
                        // LabelColor
                        // 
                        this.LabelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelColor.BackColor = System.Drawing.Color.Sienna;
                        this.LabelColor.Location = new System.Drawing.Point(320, 8);
                        this.LabelColor.Name = "LabelColor";
                        this.LabelColor.Size = new System.Drawing.Size(128, 16);
                        this.LabelColor.TabIndex = 2;
                        this.LabelColor.UseMnemonic = false;
                        // 
                        // LabelColor2
                        // 
                        this.LabelColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelColor2.BackColor = System.Drawing.Color.SaddleBrown;
                        this.LabelColor2.Location = new System.Drawing.Point(320, 0);
                        this.LabelColor2.Name = "LabelColor2";
                        this.LabelColor2.Size = new System.Drawing.Size(128, 8);
                        this.LabelColor2.TabIndex = 3;
                        this.LabelColor2.UseMnemonic = false;
                        // 
                        // label1
                        // 
                        this.label1.BackColor = System.Drawing.Color.Tan;
                        this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.label1.Location = new System.Drawing.Point(0, 63);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(600, 1);
                        this.label1.TabIndex = 4;
                        this.label1.UseMnemonic = false;
                        this.label1.Visible = false;
                        // 
                        // LabelCaption
                        // 
                        this.LabelCaption.AutoSize = true;
                        this.LabelCaption.Location = new System.Drawing.Point(72, 16);
                        this.LabelCaption.Name = "LabelCaption";
                        this.LabelCaption.Size = new System.Drawing.Size(210, 30);
                        this.LabelCaption.TabIndex = 0;
                        this.LabelCaption.Text = "Título del formulario";
                        this.LabelCaption.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        this.LabelCaption.UseMnemonic = false;
                        // 
                        // FormHeader
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.Controls.Add(this.LabelColor2);
                        this.Controls.Add(this.LabelColor);
                        this.Controls.Add(this.ImageIcon);
                        this.Controls.Add(this.LabelCaption);
                        this.Controls.Add(this.label1);
                        this.Name = "FormHeader";
                        this.Size = new System.Drawing.Size(600, 64);
                        ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Label LabelCaption;
                private System.Windows.Forms.PictureBox ImageIcon;
                private System.Windows.Forms.Label LabelColor;
                private System.Windows.Forms.Label LabelColor2;
                private System.Windows.Forms.Label label1;
        }
}
