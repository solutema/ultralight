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

namespace Lfc
{
        partial class FormularioEdicion
        {
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

                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.BotonGuardar = new Lui.Forms.Button();
                        this.BotonCancelar = new Lui.Forms.Button();
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.BotonImprimir = new Lui.Forms.Button();
                        this.BotonComentarios = new System.Windows.Forms.LinkLabel();
                        this.BotonHistorial = new System.Windows.Forms.LinkLabel();
                        this.SplitContainer = new System.Windows.Forms.SplitContainer();
                        this.TablaElementosEstandar = new System.Windows.Forms.TableLayoutPanel();
                        this.EntradaImagen = new Lcc.Entrada.Imagen();
                        this.EntradaTags = new Lcc.Edicion.MatrizTags();
                        this.EntradaComentarios = new Lcc.Edicion.Comentarios();
                        this.LowerPanel.SuspendLayout();
                        this.SplitContainer.Panel2.SuspendLayout();
                        this.SplitContainer.SuspendLayout();
                        this.TablaElementosEstandar.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // BotonGuardar
                        // 
                        this.BotonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonGuardar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonGuardar.Image = null;
                        this.BotonGuardar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonGuardar.Location = new System.Drawing.Point(568, 8);
                        this.BotonGuardar.Name = "BotonGuardar";
                        this.BotonGuardar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonGuardar.Size = new System.Drawing.Size(104, 44);
                        this.BotonGuardar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonGuardar.Subtext = "F9";
                        this.BotonGuardar.TabIndex = 100;
                        this.BotonGuardar.Text = "Guardar";
                        this.BotonGuardar.ToolTipText = "";
                        this.BotonGuardar.Click += new System.EventHandler(this.SaveButton_Click);
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCancelar.Image = null;
                        this.BotonCancelar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCancelar.Location = new System.Drawing.Point(680, 8);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCancelar.Size = new System.Drawing.Size(104, 44);
                        this.BotonCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonCancelar.Subtext = "Esc";
                        this.BotonCancelar.TabIndex = 101;
                        this.BotonCancelar.Text = "Cancelar";
                        this.BotonCancelar.ToolTipText = "";
                        this.BotonCancelar.Click += new System.EventHandler(this.CancelButton_Click);
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.BotonImprimir);
                        this.LowerPanel.Controls.Add(this.BotonComentarios);
                        this.LowerPanel.Controls.Add(this.BotonHistorial);
                        this.LowerPanel.Controls.Add(this.BotonCancelar);
                        this.LowerPanel.Controls.Add(this.BotonGuardar);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 413);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(792, 60);
                        this.LowerPanel.TabIndex = 100;
                        // 
                        // BotonImprimir
                        // 
                        this.BotonImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonImprimir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonImprimir.Image = null;
                        this.BotonImprimir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonImprimir.Location = new System.Drawing.Point(456, 8);
                        this.BotonImprimir.Name = "BotonImprimir";
                        this.BotonImprimir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonImprimir.Size = new System.Drawing.Size(104, 44);
                        this.BotonImprimir.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonImprimir.Subtext = "F8";
                        this.BotonImprimir.TabIndex = 102;
                        this.BotonImprimir.Text = "Imprimir";
                        this.BotonImprimir.ToolTipText = "";
                        this.BotonImprimir.Click += new System.EventHandler(this.BotonImprimir_Click);
                        // 
                        // BotonComentarios
                        // 
                        this.BotonComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonComentarios.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonComentarios.Location = new System.Drawing.Point(12, 32);
                        this.BotonComentarios.Name = "BotonComentarios";
                        this.BotonComentarios.Size = new System.Drawing.Size(88, 16);
                        this.BotonComentarios.TabIndex = 104;
                        this.BotonComentarios.TabStop = true;
                        this.BotonComentarios.Text = "Comentarios";
                        this.BotonComentarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonComentarios.Visible = false;
                        this.BotonComentarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonComentarios_LinkClicked);
                        // 
                        // BotonHistorial
                        // 
                        this.BotonHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonHistorial.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonHistorial.Location = new System.Drawing.Point(12, 16);
                        this.BotonHistorial.Name = "BotonHistorial";
                        this.BotonHistorial.Size = new System.Drawing.Size(88, 16);
                        this.BotonHistorial.TabIndex = 103;
                        this.BotonHistorial.TabStop = true;
                        this.BotonHistorial.Text = "Historial";
                        this.BotonHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.BotonHistorial.Visible = false;
                        this.BotonHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonHistorial_LinkClicked);
                        // 
                        // SplitContainer
                        // 
                        this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.SplitContainer.Location = new System.Drawing.Point(0, 0);
                        this.SplitContainer.Name = "SplitContainer";
                        // 
                        // SplitContainer.Panel1
                        // 
                        this.SplitContainer.Panel1.AutoScroll = true;
                        this.SplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(16);
                        this.SplitContainer.Panel1MinSize = 120;
                        // 
                        // SplitContainer.Panel2
                        // 
                        this.SplitContainer.Panel2.Controls.Add(this.TablaElementosEstandar);
                        this.SplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(12);
                        this.SplitContainer.Panel2MinSize = 120;
                        this.SplitContainer.Size = new System.Drawing.Size(792, 408);
                        this.SplitContainer.SplitterDistance = 544;
                        this.SplitContainer.TabIndex = 0;
                        this.SplitContainer.TabStop = false;
                        this.SplitContainer.Visible = false;
                        // 
                        // TablaElementosEstandar
                        // 
                        this.TablaElementosEstandar.ColumnCount = 1;
                        this.TablaElementosEstandar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.TablaElementosEstandar.Controls.Add(this.EntradaImagen, 0, 0);
                        this.TablaElementosEstandar.Controls.Add(this.EntradaTags, 0, 2);
                        this.TablaElementosEstandar.Controls.Add(this.EntradaComentarios, 0, 1);
                        this.TablaElementosEstandar.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.TablaElementosEstandar.Location = new System.Drawing.Point(12, 12);
                        this.TablaElementosEstandar.Margin = new System.Windows.Forms.Padding(0);
                        this.TablaElementosEstandar.Name = "TablaElementosEstandar";
                        this.TablaElementosEstandar.RowCount = 3;
                        this.TablaElementosEstandar.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaElementosEstandar.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaElementosEstandar.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaElementosEstandar.Size = new System.Drawing.Size(220, 384);
                        this.TablaElementosEstandar.TabIndex = 1;
                        // 
                        // EntradaImagen
                        // 
                        this.EntradaImagen.AutoNav = true;
                        this.EntradaImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImagen.Location = new System.Drawing.Point(0, 0);
                        this.EntradaImagen.Margin = new System.Windows.Forms.Padding(0);
                        this.EntradaImagen.MaximumSize = new System.Drawing.Size(320, 240);
                        this.EntradaImagen.MinimumSize = new System.Drawing.Size(240, 160);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImagen.Size = new System.Drawing.Size(308, 160);
                        this.EntradaImagen.TabIndex = 1;
                        this.EntradaImagen.Text = "Imagen";
                        this.EntradaImagen.ToolTipText = "";
                        // 
                        // EntradaTags
                        // 
                        this.EntradaTags.AutoNav = true;
                        this.EntradaTags.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaTags.Location = new System.Drawing.Point(0, 312);
                        this.EntradaTags.Margin = new System.Windows.Forms.Padding(0);
                        this.EntradaTags.MaximumSize = new System.Drawing.Size(320, 480);
                        this.EntradaTags.MinimumSize = new System.Drawing.Size(240, 160);
                        this.EntradaTags.Name = "EntradaTags";
                        this.EntradaTags.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTags.Size = new System.Drawing.Size(308, 480);
                        this.EntradaTags.TabIndex = 3;
                        this.EntradaTags.Text = "Otros atributos";
                        this.EntradaTags.ToolTipText = "";
                        // 
                        // EntradaComentarios
                        // 
                        this.EntradaComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaComentarios.AutoNav = true;
                        this.EntradaComentarios.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaComentarios.Location = new System.Drawing.Point(0, 160);
                        this.EntradaComentarios.Margin = new System.Windows.Forms.Padding(0);
                        this.EntradaComentarios.MaximumSize = new System.Drawing.Size(320, 480);
                        this.EntradaComentarios.MinimumSize = new System.Drawing.Size(240, 152);
                        this.EntradaComentarios.Name = "EntradaComentarios";
                        this.EntradaComentarios.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComentarios.Size = new System.Drawing.Size(308, 152);
                        this.EntradaComentarios.TabIndex = 2;
                        this.EntradaComentarios.Text = "Comentarios";
                        this.EntradaComentarios.ToolTipText = "";
                        // 
                        // FormularioEdicion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(792, 473);
                        this.Controls.Add(this.SplitContainer);
                        this.Controls.Add(this.LowerPanel);
                        this.Name = "FormularioEdicion";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Editar";
                        this.Closing += new System.ComponentModel.CancelEventHandler(this.EditForm_Closing);
                        this.Load += new System.EventHandler(this.EditForm_Load);
                        this.LowerPanel.ResumeLayout(false);
                        this.SplitContainer.Panel2.ResumeLayout(false);
                        this.SplitContainer.ResumeLayout(false);
                        this.TablaElementosEstandar.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.Button BotonGuardar;
                private Lui.Forms.Button BotonCancelar;
                private System.Windows.Forms.Panel LowerPanel;
                private System.Windows.Forms.LinkLabel BotonHistorial;
                private System.Windows.Forms.SplitContainer SplitContainer;
                private System.Windows.Forms.LinkLabel BotonComentarios;
                private Lui.Forms.Button BotonImprimir;
                private System.Windows.Forms.TableLayoutPanel TablaElementosEstandar;
                private Lcc.Entrada.Imagen EntradaImagen;
                private Lcc.Edicion.MatrizTags EntradaTags;
                private Lcc.Edicion.Comentarios EntradaComentarios;
        }
}