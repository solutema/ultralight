#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lcc.Entrada
{
        partial class Filtros
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
                        this.TablaFiltros = new System.Windows.Forms.TableLayoutPanel();
                        this.PanelInferior = new System.Windows.Forms.FlowLayoutPanel();
                        this.BotonAplicar = new Lui.Forms.Button();
                        this.PanelInferior.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // TablaFiltros
                        // 
                        this.TablaFiltros.AutoSize = true;
                        this.TablaFiltros.ColumnCount = 2;
                        this.TablaFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.TablaFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.TablaFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.TablaFiltros.Location = new System.Drawing.Point(4, 4);
                        this.TablaFiltros.Name = "TablaFiltros";
                        this.TablaFiltros.RowCount = 1;
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
                        this.TablaFiltros.Size = new System.Drawing.Size(391, 241);
                        this.TablaFiltros.TabIndex = 0;
                        // 
                        // PanelInferior
                        // 
                        this.PanelInferior.AutoSize = true;
                        this.PanelInferior.Controls.Add(this.BotonAplicar);
                        this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.PanelInferior.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                        this.PanelInferior.Location = new System.Drawing.Point(4, 245);
                        this.PanelInferior.Name = "PanelInferior";
                        this.PanelInferior.Size = new System.Drawing.Size(391, 30);
                        this.PanelInferior.TabIndex = 1;
                        // 
                        // BotonAplicar
                        // 
                        this.BotonAplicar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAplicar.Image = null;
                        this.BotonAplicar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAplicar.Location = new System.Drawing.Point(304, 3);
                        this.BotonAplicar.Name = "BotonAplicar";
                        this.BotonAplicar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAplicar.ReadOnly = false;
                        this.BotonAplicar.Size = new System.Drawing.Size(84, 24);
                        this.BotonAplicar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAplicar.Subtext = "Tecla";
                        this.BotonAplicar.TabIndex = 0;
                        this.BotonAplicar.Text = "Aplicar";
                        this.BotonAplicar.Click += new System.EventHandler(this.BotonAplicar_Click);
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoScroll = true;
                        this.AutoSize = true;
                        this.Controls.Add(this.TablaFiltros);
                        this.Controls.Add(this.PanelInferior);
                        this.Name = "Filtros";
                        this.Padding = new System.Windows.Forms.Padding(4);
                        this.Size = new System.Drawing.Size(399, 279);
                        this.PanelInferior.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                protected System.Windows.Forms.TableLayoutPanel TablaFiltros;
                private System.Windows.Forms.FlowLayoutPanel PanelInferior;
                private Lui.Forms.Button BotonAplicar;
        }
}
