#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                #region Código generado por el Diseñador de Windows Forms

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        this.EtiquetaRetrasados = new System.Windows.Forms.Label();
                        this.EtiquetasTerminados = new System.Windows.Forms.Label();
                        this.EtiquetaActivos = new System.Windows.Forms.Label();
                        this.EtiquetaNuevos = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // Listado
                        // 
                        this.Listado.Size = new System.Drawing.Size(544, 473);
                        // 
                        // EtiquetaRetrasados
                        // 
                        this.EtiquetaRetrasados.AutoSize = true;
                        this.EtiquetaRetrasados.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaRetrasados.ForeColor = System.Drawing.Color.Crimson;
                        this.EtiquetaRetrasados.Location = new System.Drawing.Point(8, 144);
                        this.EtiquetaRetrasados.Name = "EtiquetaRetrasados";
                        this.EtiquetaRetrasados.Size = new System.Drawing.Size(80, 13);
                        this.EtiquetaRetrasados.TabIndex = 52;
                        this.EtiquetaRetrasados.Text = "0 retrasados";
                        this.EtiquetaRetrasados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetasTerminados
                        // 
                        this.EtiquetasTerminados.AutoSize = true;
                        this.EtiquetasTerminados.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetasTerminados.ForeColor = System.Drawing.Color.Green;
                        this.EtiquetasTerminados.Location = new System.Drawing.Point(8, 124);
                        this.EtiquetasTerminados.Name = "EtiquetasTerminados";
                        this.EtiquetasTerminados.Size = new System.Drawing.Size(82, 13);
                        this.EtiquetasTerminados.TabIndex = 53;
                        this.EtiquetasTerminados.Text = "0 terminados";
                        this.EtiquetasTerminados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaActivos
                        // 
                        this.EtiquetaActivos.AutoSize = true;
                        this.EtiquetaActivos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaActivos.Location = new System.Drawing.Point(8, 104);
                        this.EtiquetaActivos.Name = "EtiquetaActivos";
                        this.EtiquetaActivos.Size = new System.Drawing.Size(57, 13);
                        this.EtiquetaActivos.TabIndex = 54;
                        this.EtiquetaActivos.Text = "0 activos";
                        this.EtiquetaActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaNuevos
                        // 
                        this.EtiquetaNuevos.AutoSize = true;
                        this.EtiquetaNuevos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaNuevos.Location = new System.Drawing.Point(8, 84);
                        this.EtiquetaNuevos.Name = "EtiquetaNuevos";
                        this.EtiquetaNuevos.Size = new System.Drawing.Size(58, 13);
                        this.EtiquetaNuevos.TabIndex = 55;
                        this.EtiquetaNuevos.Text = "0 nuevos";
                        this.EtiquetaNuevos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Inicio
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.EtiquetaNuevos);
                        this.Controls.Add(this.EtiquetaActivos);
                        this.Controls.Add(this.EtiquetasTerminados);
                        this.Controls.Add(this.EtiquetaRetrasados);
                        this.Name = "Inicio";
                        this.Text = "Tickets: Listado";
                        this.WorkspaceChanged += new System.EventHandler(this.FormTicketsInicio_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.EtiquetaRetrasados, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.EtiquetasTerminados, 0);
                        this.Controls.SetChildIndex(this.EtiquetaActivos, 0);
                        this.Controls.SetChildIndex(this.EtiquetaNuevos, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Label EtiquetaRetrasados;
                private Label EtiquetasTerminados;
                private Label EtiquetaActivos;
                private Label EtiquetaNuevos;

        }
}
