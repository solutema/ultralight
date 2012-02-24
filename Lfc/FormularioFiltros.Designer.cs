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
                        this.ControlFiltros = new Lcc.Entrada.Filtros();
                        this.formHeader1 = new Lui.Forms.FormHeader();
                        this.SuspendLayout();
                        // 
                        // ControlFiltros
                        // 
                        this.ControlFiltros.AutoScroll = true;
                        this.ControlFiltros.AutoScrollMargin = new System.Drawing.Size(0, 24);
                        this.ControlFiltros.AutoSize = true;
                        this.ControlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ControlFiltros.Location = new System.Drawing.Point(0, 64);
                        this.ControlFiltros.Name = "ControlFiltros";
                        this.ControlFiltros.ShowApplyButton = false;
                        this.ControlFiltros.Size = new System.Drawing.Size(634, 244);
                        this.ControlFiltros.TabIndex = 0;
                        // 
                        // formHeader1
                        // 
                        this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.formHeader1.Location = new System.Drawing.Point(0, 0);
                        this.formHeader1.Name = "formHeader1";
                        this.formHeader1.Size = new System.Drawing.Size(634, 64);
                        this.formHeader1.TabIndex = 51;
                        this.formHeader1.Text = "Filtros";
                        // 
                        // FormularioFiltros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoSize = true;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.ControlFiltros);
                        this.Controls.Add(this.formHeader1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.MaximumSize = new System.Drawing.Size(1000, 720);
                        this.MinimumSize = new System.Drawing.Size(480, 320);
                        this.Name = "FormularioFiltros";
                        this.Text = "Filtros";
                        this.Controls.SetChildIndex(this.formHeader1, 0);
                        this.Controls.SetChildIndex(this.ControlFiltros, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lcc.Entrada.Filtros ControlFiltros;
                private Lui.Forms.FormHeader formHeader1;

        }
}
