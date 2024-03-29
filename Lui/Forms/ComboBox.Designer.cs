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

namespace Lui.Forms
{
        public partial class ComboBox
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

                #region	Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBox));
                        this.ItemList = new System.Windows.Forms.ListBox();
                        this.TimerOcultarPopup = new System.Windows.Forms.Timer(this.components);
                        this.ImagenSiguiente = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagenSiguiente)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // TextBox1
                        // 
                        this.TextBox1.BackColor = System.Drawing.Color.White;
                        this.TextBox1.ForeColor = System.Drawing.Color.Black;
                        this.TextBox1.Margin = new System.Windows.Forms.Padding(1);
                        this.TextBox1.ReadOnly = true;
                        this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
                        this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemList_KeyDown);
                        // 
                        // ItemList
                        // 
                        this.ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ItemList.ForeColor = System.Drawing.SystemColors.InfoText;
                        this.ItemList.IntegralHeight = false;
                        this.ItemList.ItemHeight = 17;
                        this.ItemList.Location = new System.Drawing.Point(4, 4);
                        this.ItemList.Margin = new System.Windows.Forms.Padding(1);
                        this.ItemList.Name = "ItemList";
                        this.ItemList.Size = new System.Drawing.Size(452, 75);
                        this.ItemList.TabIndex = 5;
                        this.ItemList.TabStop = false;
                        this.ItemList.Visible = false;
                        this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedValueChanged);
                        this.ItemList.VisibleChanged += new System.EventHandler(this.ItemList_VisibleChanged);
                        this.ItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemList_KeyDown);
                        // 
                        // TimerOcultarPopup
                        // 
                        this.TimerOcultarPopup.Tick += new System.EventHandler(this.TimerOcultarPopup_Tick);
                        // 
                        // ImagenSiguiente
                        // 
                        this.ImagenSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ImagenSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.ImagenSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("ImagenSiguiente.Image")));
                        this.ImagenSiguiente.Location = new System.Drawing.Point(444, 4);
                        this.ImagenSiguiente.Name = "ImagenSiguiente";
                        this.ImagenSiguiente.Size = new System.Drawing.Size(12, 20);
                        this.ImagenSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.ImagenSiguiente.TabIndex = 6;
                        this.ImagenSiguiente.TabStop = false;
                        this.ImagenSiguiente.Click += new System.EventHandler(this.ImagenSiguiente_Click);
                        this.ImagenSiguiente.DoubleClick += new System.EventHandler(this.ImagenSiguiente_DoubleClick);
                        // 
                        // ComboBox
                        // 
                        this.Controls.Add(this.ImagenSiguiente);
                        this.Controls.Add(this.ItemList);
                        this.Name = "ComboBox";
                        this.SizeChanged += new System.EventHandler(this.ComboBox_SizeChanged);
                        this.Enter += new System.EventHandler(this.ComboBox_Enter);
                        this.Leave += new System.EventHandler(this.ComboBox_Leave);
                        this.Controls.SetChildIndex(this.ItemList, 0);
                        this.Controls.SetChildIndex(this.TextBox1, 0);
                        this.Controls.SetChildIndex(this.ImagenSiguiente, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.ImagenSiguiente)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                protected System.Windows.Forms.ListBox ItemList;
                protected System.Windows.Forms.Timer TimerOcultarPopup;
                private System.Windows.Forms.PictureBox ImagenSiguiente;

        }
}
