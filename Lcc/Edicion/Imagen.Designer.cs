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

namespace Lcc.Entrada
{
        public partial class Imagen
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
                        if (this.Arch != null)
                                this.Arch.Dispose();

                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.EntradaImagen = new System.Windows.Forms.PictureBox();
                        this.MenuImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
                        this.guardarEnarchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.copiarAlPortapapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.BotonQuitarImagen = new Lui.Forms.Button();
                        this.BotonSeleccionarImagen = new Lui.Forms.Button();
                        this.BotonCapturarImagen = new Lui.Forms.Button();
                        this.GroupLabel = new System.Windows.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).BeginInit();
                        this.MenuImagen.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaImagen.BackColor = System.Drawing.Color.White;
                        this.EntradaImagen.ContextMenuStrip = this.MenuImagen;
                        this.EntradaImagen.Location = new System.Drawing.Point(0, 27);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.Size = new System.Drawing.Size(140, 130);
                        this.EntradaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        this.EntradaImagen.TabIndex = 100;
                        this.EntradaImagen.TabStop = false;
                        // 
                        // MenuImagen
                        // 
                        this.MenuImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarEnarchivoToolStripMenuItem,
            this.copiarAlPortapapelesToolStripMenuItem});
                        this.MenuImagen.Name = "MenuImagen";
                        this.MenuImagen.Size = new System.Drawing.Size(193, 70);
                        // 
                        // guardarEnarchivoToolStripMenuItem
                        // 
                        this.guardarEnarchivoToolStripMenuItem.Name = "guardarEnarchivoToolStripMenuItem";
                        this.guardarEnarchivoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
                        this.guardarEnarchivoToolStripMenuItem.Text = "Guardar en &archivo...";
                        this.guardarEnarchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarEnarchivoToolStripMenuItem_Click);
                        // 
                        // copiarAlPortapapelesToolStripMenuItem
                        // 
                        this.copiarAlPortapapelesToolStripMenuItem.Name = "copiarAlPortapapelesToolStripMenuItem";
                        this.copiarAlPortapapelesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
                        this.copiarAlPortapapelesToolStripMenuItem.Text = "&Copiar al portapapeles";
                        this.copiarAlPortapapelesToolStripMenuItem.Click += new System.EventHandler(this.copiarAlPortapapelesToolStripMenuItem_Click);
                        // 
                        // BotonQuitarImagen
                        // 
                        this.BotonQuitarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonQuitarImagen.AutoSize = false;
                        this.BotonQuitarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitarImagen.Image = null;
                        this.BotonQuitarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitarImagen.Location = new System.Drawing.Point(143, 133);
                        this.BotonQuitarImagen.Name = "BotonQuitarImagen";
                        this.BotonQuitarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitarImagen.ReadOnly = false;
                        this.BotonQuitarImagen.Size = new System.Drawing.Size(96, 26);
                        this.BotonQuitarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitarImagen.Subtext = "";
                        this.BotonQuitarImagen.TabIndex = 2;
                        this.BotonQuitarImagen.Text = "Sin Imagen";
                        this.BotonQuitarImagen.ToolTipText = "";
                        this.BotonQuitarImagen.Click += new System.EventHandler(this.BotonQuitarImagen_Click);
                        // 
                        // BotonSeleccionarImagen
                        // 
                        this.BotonSeleccionarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonSeleccionarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSeleccionarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonSeleccionarImagen.Image = null;
                        this.BotonSeleccionarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSeleccionarImagen.Location = new System.Drawing.Point(143, 82);
                        this.BotonSeleccionarImagen.Name = "BotonSeleccionarImagen";
                        this.BotonSeleccionarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSeleccionarImagen.ReadOnly = false;
                        this.BotonSeleccionarImagen.Size = new System.Drawing.Size(96, 40);
                        this.BotonSeleccionarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSeleccionarImagen.Subtext = "";
                        this.BotonSeleccionarImagen.TabIndex = 1;
                        this.BotonSeleccionarImagen.Text = "Desde Archivo";
                        this.BotonSeleccionarImagen.ToolTipText = "";
                        this.BotonSeleccionarImagen.Click += new System.EventHandler(this.BotonSeleccionarImagen_Click);
                        // 
                        // BotonCapturarImagen
                        // 
                        this.BotonCapturarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCapturarImagen.AutoSize = false;
                        this.BotonCapturarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCapturarImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCapturarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCapturarImagen.Image = null;
                        this.BotonCapturarImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCapturarImagen.Location = new System.Drawing.Point(143, 38);
                        this.BotonCapturarImagen.Name = "BotonCapturarImagen";
                        this.BotonCapturarImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCapturarImagen.ReadOnly = false;
                        this.BotonCapturarImagen.Size = new System.Drawing.Size(96, 40);
                        this.BotonCapturarImagen.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonCapturarImagen.Subtext = "";
                        this.BotonCapturarImagen.TabIndex = 0;
                        this.BotonCapturarImagen.Text = "Desde Dispositivo";
                        this.BotonCapturarImagen.ToolTipText = "";
                        this.BotonCapturarImagen.Click += new System.EventHandler(this.BotonCapturarImagen_Click);
                        // 
                        // GroupLabel
                        // 
                        this.GroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.GroupLabel.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.GroupLabel.Location = new System.Drawing.Point(0, 0);
                        this.GroupLabel.Name = "GroupLabel";
                        this.GroupLabel.Size = new System.Drawing.Size(236, 24);
                        this.GroupLabel.TabIndex = 2;
                        this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.GroupLabel.UseMnemonic = false;
                        // 
                        // Imagen
                        // 
                        this.Controls.Add(this.GroupLabel);
                        this.Controls.Add(this.EntradaImagen);
                        this.Controls.Add(this.BotonQuitarImagen);
                        this.Controls.Add(this.BotonSeleccionarImagen);
                        this.Controls.Add(this.BotonCapturarImagen);
                        this.Name = "Imagen";
                        this.Size = new System.Drawing.Size(240, 160);
                        this.Controls.SetChildIndex(this.BotonCapturarImagen, 0);
                        this.Controls.SetChildIndex(this.BotonSeleccionarImagen, 0);
                        this.Controls.SetChildIndex(this.BotonQuitarImagen, 0);
                        this.Controls.SetChildIndex(this.EntradaImagen, 0);
                        this.Controls.SetChildIndex(this.GroupLabel, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).EndInit();
                        this.MenuImagen.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                internal Lui.Forms.Button BotonCapturarImagen;
                private System.Windows.Forms.ContextMenuStrip MenuImagen;
                private System.Windows.Forms.ToolStripMenuItem guardarEnarchivoToolStripMenuItem;
                private System.Windows.Forms.ToolStripMenuItem copiarAlPortapapelesToolStripMenuItem;
                private System.Windows.Forms.Label GroupLabel;
        }
}
