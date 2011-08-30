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

using System.Windows.Forms;

namespace Lfc
{
        public partial class FormularioFiltros : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.ContenedorPrincipal = new System.Windows.Forms.Panel();
                        this.TablaFiltros = new System.Windows.Forms.TableLayoutPanel();
                        this.ContenedorPrincipal.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // ContenedorPrincipal
                        // 
                        this.ContenedorPrincipal.AutoScroll = true;
                        this.ContenedorPrincipal.Controls.Add(this.TablaFiltros);
                        this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
                        this.ContenedorPrincipal.Name = "ContenedorPrincipal";
                        this.ContenedorPrincipal.Size = new System.Drawing.Size(634, 312);
                        this.ContenedorPrincipal.TabIndex = 0;
                        // 
                        // TablaFiltros
                        // 
                        this.TablaFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.TablaFiltros.AutoSize = true;
                        this.TablaFiltros.ColumnCount = 2;
                        this.TablaFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.TablaFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.TablaFiltros.Location = new System.Drawing.Point(24, 20);
                        this.TablaFiltros.Name = "TablaFiltros";
                        this.TablaFiltros.RowCount = 1;
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 285F));
                        this.TablaFiltros.Size = new System.Drawing.Size(586, 285);
                        this.TablaFiltros.TabIndex = 0;
                        // 
                        // FormularioFiltros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.ContenedorPrincipal);
                        this.Name = "FormularioFiltros";
                        this.Text = "Filtros";
                        this.Controls.SetChildIndex(this.ContenedorPrincipal, 0);
                        this.ContenedorPrincipal.ResumeLayout(false);
                        this.ContenedorPrincipal.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private Panel ContenedorPrincipal;
                protected TableLayoutPanel TablaFiltros;
        }
}
