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

namespace Lcc.Entrada.AuxForms
{
        partial class ImagenRecorte
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

                #region Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.EntradaImagen = new System.Windows.Forms.PictureBox();
                        this.MenuEntradImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
                        this.copiarAlPortapapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.guardarEnUnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.BotonGuardar = new Lui.Forms.Button();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaRatio = new Lui.Forms.ComboBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.BotonSinRecorte = new Lui.Forms.Button();
                        this.panel1 = new System.Windows.Forms.Panel();
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).BeginInit();
                        this.MenuEntradImagen.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.ContextMenuStrip = this.MenuEntradImagen;
                        this.EntradaImagen.Location = new System.Drawing.Point(12, 48);
                        this.EntradaImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.Size = new System.Drawing.Size(556, 292);
                        this.EntradaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        this.EntradaImagen.TabIndex = 0;
                        this.EntradaImagen.TabStop = false;
                        this.EntradaImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.EntradaImagen_Paint);
                        this.EntradaImagen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EntradaImagen_MouseDown);
                        this.EntradaImagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EntradaImagen_MouseMove);
                        this.EntradaImagen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EntradaImagen_MouseUp);
                        // 
                        // MenuEntradImagen
                        // 
                        this.MenuEntradImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarAlPortapapelesToolStripMenuItem,
            this.guardarEnUnArchivoToolStripMenuItem});
                        this.MenuEntradImagen.Name = "MenuEntradImagen";
                        this.MenuEntradImagen.Size = new System.Drawing.Size(193, 48);
                        // 
                        // copiarAlPortapapelesToolStripMenuItem
                        // 
                        this.copiarAlPortapapelesToolStripMenuItem.Name = "copiarAlPortapapelesToolStripMenuItem";
                        this.copiarAlPortapapelesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
                        this.copiarAlPortapapelesToolStripMenuItem.Text = "&Copiar al portapapeles";
                        this.copiarAlPortapapelesToolStripMenuItem.Click += new System.EventHandler(this.copiarAlPortapapelesToolStripMenuItem_Click);
                        // 
                        // guardarEnUnArchivoToolStripMenuItem
                        // 
                        this.guardarEnUnArchivoToolStripMenuItem.Name = "guardarEnUnArchivoToolStripMenuItem";
                        this.guardarEnUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
                        this.guardarEnUnArchivoToolStripMenuItem.Text = "&Guardar en un archivo";
                        this.guardarEnUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarEnUnArchivoToolStripMenuItem_Click);
                        // 
                        // BotonGuardar
                        // 
                        this.BotonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonGuardar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonGuardar.Image = null;
                        this.BotonGuardar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonGuardar.Location = new System.Drawing.Point(471, 10);
                        this.BotonGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.BotonGuardar.Name = "BotonGuardar";
                        this.BotonGuardar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.BotonGuardar.Size = new System.Drawing.Size(104, 36);
                        this.BotonGuardar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonGuardar.Subtext = "";
                        this.BotonGuardar.TabIndex = 3;
                        this.BotonGuardar.Text = "Aceptar";
                        this.BotonGuardar.ToolTipText = "";
                        this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(12, 12);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(557, 32);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Arrastre el mouse para seleccionar el área de la imagen a utilizar. Utilice el bo" +
                            "tón del medio para mover la selección.";
                        // 
                        // EntradaRatio
                        // 
                        this.EntradaRatio.AutoNav = true;
                        this.EntradaRatio.AutoSize = true;
                        this.EntradaRatio.AutoTab = true;
                        this.EntradaRatio.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaRatio.Location = new System.Drawing.Point(96, 4);
                        this.EntradaRatio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaRatio.MaxLenght = 32767;
                        this.EntradaRatio.Name = "EntradaRatio";
                        this.EntradaRatio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.EntradaRatio.SetData = new string[] {
        "1:1|1",
        "4:3|1.333333",
        "Libre|0"};
                        this.EntradaRatio.Size = new System.Drawing.Size(136, 22);
                        this.EntradaRatio.TabIndex = 1;
                        this.EntradaRatio.Text = "Libre";
                        this.EntradaRatio.TextKey = "0";
                        this.EntradaRatio.PlaceholderText = "";
                        this.EntradaRatio.ToolTipText = "";
                        this.EntradaRatio.TextChanged += new System.EventHandler(this.EntradaRatio_TextChanged);
                        // 
                        // label2
                        // 
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(8, 4);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(88, 20);
                        this.label2.TabIndex = 0;
                        this.label2.Text = "Selección";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonSinRecorte
                        // 
                        this.BotonSinRecorte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonSinRecorte.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSinRecorte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonSinRecorte.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonSinRecorte.Image = null;
                        this.BotonSinRecorte.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSinRecorte.Location = new System.Drawing.Point(362, 10);
                        this.BotonSinRecorte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.BotonSinRecorte.Name = "BotonSinRecorte";
                        this.BotonSinRecorte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.BotonSinRecorte.Size = new System.Drawing.Size(104, 36);
                        this.BotonSinRecorte.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSinRecorte.Subtext = "";
                        this.BotonSinRecorte.TabIndex = 2;
                        this.BotonSinRecorte.Text = "Sin Recorte";
                        this.BotonSinRecorte.ToolTipText = "";
                        this.BotonSinRecorte.Click += new System.EventHandler(this.BotonSinRecorte_Click);
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.label2);
                        this.panel1.Controls.Add(this.EntradaRatio);
                        this.panel1.Controls.Add(this.BotonSinRecorte);
                        this.panel1.Controls.Add(this.BotonGuardar);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.panel1.Location = new System.Drawing.Point(0, 346);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(582, 56);
                        this.panel1.TabIndex = 1;
                        // 
                        // ImagenRecorte
                        // 
                        this.AcceptButton = this.BotonGuardar;
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoSize = true;
                        this.ClientSize = new System.Drawing.Size(582, 402);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.EntradaImagen);
                        this.Controls.Add(this.label1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.MinimumSize = new System.Drawing.Size(480, 400);
                        this.Name = "ImagenRecorte";
                        this.ShowIcon = false;
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Recortar Imagen";
                        ((System.ComponentModel.ISupportInitialize)(this.EntradaImagen)).EndInit();
                        this.MenuEntradImagen.ResumeLayout(false);
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.PictureBox EntradaImagen;
                internal Lui.Forms.Button BotonGuardar;
                private System.Windows.Forms.Label label1;
                private Lui.Forms.ComboBox EntradaRatio;
                private System.Windows.Forms.Label label2;
                internal Lui.Forms.Button BotonSinRecorte;
                private System.Windows.Forms.ContextMenuStrip MenuEntradImagen;
                private System.Windows.Forms.ToolStripMenuItem copiarAlPortapapelesToolStripMenuItem;
                private System.Windows.Forms.ToolStripMenuItem guardarEnUnArchivoToolStripMenuItem;
                private System.Windows.Forms.Panel panel1;
        }
}