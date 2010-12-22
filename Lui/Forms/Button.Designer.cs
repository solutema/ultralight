#region License
// Copyright 2004-2010 Ernesto N. Carrea
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
using System.Windows.Forms;
using System.Text;

namespace Lui.Forms
{
        public partial class Button
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

                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.MainText = new System.Windows.Forms.Label();
                        this.SubText = new System.Windows.Forms.Label();
                        this.IconPicture = new System.Windows.Forms.PictureBox();
                        this.SuspendLayout();
                        // 
                        // MainText
                        // 
                        this.MainText.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(231)), ((System.Byte)(226)), ((System.Byte)(222)));
                        this.MainText.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.MainText.ForeColor = System.Drawing.Color.Black;
                        this.MainText.Location = new System.Drawing.Point(4, 4);
                        this.MainText.Name = "MainText";
                        this.MainText.Size = new System.Drawing.Size(312, 60);
                        this.MainText.TabIndex = 1;
                        this.MainText.Text = "Command asdasd";
                        this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.MainText.Click += new System.EventHandler(this.MainText_Click);
                        this.MainText.DoubleClick += new System.EventHandler(this.MainText_DoubleClick);
                        this.MainText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainText_MouseDown);
                        // 
                        // SubText
                        // 
                        this.SubText.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(198)), ((System.Byte)(190)), ((System.Byte)(176)));
                        this.SubText.Font = new System.Drawing.Font("Bitstream Vera Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.SubText.Location = new System.Drawing.Point(4, 68);
                        this.SubText.Name = "SubText";
                        this.SubText.Size = new System.Drawing.Size(312, 8);
                        this.SubText.TabIndex = 2;
                        this.SubText.Text = "Tecla";
                        this.SubText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                        this.SubText.Visible = false;
                        this.SubText.Click += new System.EventHandler(this.SubText_Click);
                        this.SubText.DoubleClick += new System.EventHandler(this.SubText_DoubleClick);
                        // 
                        // IconPicture
                        // 
                        this.IconPicture.BackColor = System.Drawing.Color.Transparent;
                        this.IconPicture.Location = new System.Drawing.Point(4, 4);
                        this.IconPicture.Name = "IconPicture";
                        this.IconPicture.Size = new System.Drawing.Size(44, 40);
                        this.IconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.IconPicture.TabIndex = 3;
                        this.IconPicture.TabStop = false;
                        this.IconPicture.Visible = false;
                        // 
                        // Button
                        // 
                        this.Controls.Add(this.IconPicture);
                        this.Controls.Add(this.SubText);
                        this.Controls.Add(this.MainText);
                        this.DockPadding.All = 2;
                        this.Name = "Button";
                        this.Size = new System.Drawing.Size(320, 80);
                        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button_KeyPress);
                        //base, no this!
                        base.Click += new System.EventHandler(this.Button_Click);
                        this.LostFocus += new System.EventHandler(this.Button_LostFocus);
                        this.GotFocus += new System.EventHandler(this.Button_GotFocus);
                        this.SizeChanged += new System.EventHandler(this.Button_SizeChanged);
                        //base, no this!
                        base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_KeyDown);
                        this.DoubleClick += new System.EventHandler(this.Button_DoubleClick);
                        this.ResumeLayout(false);

                }


                #endregion

                private System.Windows.Forms.Label MainText;
                private System.Windows.Forms.Label SubText;
                private System.Windows.Forms.PictureBox IconPicture;
        }
}
