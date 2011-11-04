#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBox));
                        this.ImagenMasMenos = new Lui.Forms.Label();
                        this.ItemList = new System.Windows.Forms.ListBox();
                        this.SuspendLayout();
                        // 
                        // TextBox1
                        // 
                        this.TextBox1.ReadOnly = true;
                        this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemList_KeyDown);
                        // 
                        // ImagenMasMenos
                        // 
                        this.ImagenMasMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.ImagenMasMenos.BackColor = System.Drawing.Color.Gray;
                        this.ImagenMasMenos.ForeColor = System.Drawing.Color.White;
                        this.ImagenMasMenos.Image = ((System.Drawing.Image)(resources.GetObject("ImagenMasMenos.Image")));
                        this.ImagenMasMenos.Location = new System.Drawing.Point(446, 3);
                        this.ImagenMasMenos.Margin = new System.Windows.Forms.Padding(1);
                        this.ImagenMasMenos.Name = "ImagenMasMenos";
                        this.ImagenMasMenos.Size = new System.Drawing.Size(10, 30);
                        this.ImagenMasMenos.TabIndex = 4;
                        this.ImagenMasMenos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.ImagenMasMenos.Click += new System.EventHandler(this.ImagenMasMenos_Click);
                        this.ImagenMasMenos.DoubleClick += new System.EventHandler(this.ImagenMasMenos_DoubleClick);
                        // 
                        // ItemList
                        // 
                        this.ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ItemList.ForeColor = System.Drawing.SystemColors.InfoText;
                        this.ItemList.ItemHeight = 15;
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
                        // ComboBox
                        // 
                        this.Controls.Add(this.ImagenMasMenos);
                        this.Controls.Add(this.ItemList);
                        this.Name = "ComboBox";
                        this.Size = new System.Drawing.Size(460, 24);
                        this.SizeChanged += new System.EventHandler(this.ComboBox_SizeChanged);
                        this.Enter += new System.EventHandler(this.ComboBox_Enter);
                        this.Leave += new System.EventHandler(this.ComboBox_Leave);
                        this.Controls.SetChildIndex(this.ItemList, 0);
                        this.Controls.SetChildIndex(this.ImagenMasMenos, 0);
                        this.Controls.SetChildIndex(this.TextBox1, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label ImagenMasMenos;
                internal System.Windows.Forms.ListBox ItemList;

        }
}
