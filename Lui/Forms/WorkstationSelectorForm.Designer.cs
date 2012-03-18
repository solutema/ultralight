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
        public partial class WorkstationSelectorForm
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

                #region Designer generated code

                private void InitializeComponent()
                {
                        this.Listado = new Lui.Forms.ListView();
                        this.NombreEstacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreEstacion,
            this.Nombre});
                        this.Listado.FullRowSelect = true;
                        this.Listado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.Listado.HideSelection = false;
                        this.Listado.LabelWrap = false;
                        this.Listado.Location = new System.Drawing.Point(8, 8);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "Listado";
                        this.Listado.Size = new System.Drawing.Size(460, 196);
                        this.Listado.TabIndex = 0;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        // 
                        // NombreEstacion
                        // 
                        this.NombreEstacion.Text = "Estación";
                        this.NombreEstacion.Width = 0;
                        // 
                        // Nombre
                        // 
                        this.Nombre.Text = "Estación";
                        this.Nombre.Width = 320;
                        // 
                        // WorkstationSelectorForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 274);
                        this.Controls.Add(this.Listado);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "WorkstationSelectorForm";
                        this.Text = "Seleccionar equipo";
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.ResumeLayout(false);

                }
                #endregion
        }
}