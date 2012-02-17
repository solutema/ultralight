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

namespace Lfc.Log
{
        partial class Editar
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
                        this.ListaHistoral = new Lui.Forms.ListView();
                        this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColAccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColDatos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.formHeader1 = new Lui.Forms.FormHeader();
                        this.TimerRefrescar = new System.Windows.Forms.Timer(this.components);
                        this.SuspendLayout();
                        // 
                        // ListaHistoral
                        // 
                        this.ListaHistoral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaHistoral.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaHistoral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColFecha,
            this.ColPersona,
            this.ColAccion,
            this.ColDatos});
                        this.ListaHistoral.FullRowSelect = true;
                        this.ListaHistoral.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaHistoral.Location = new System.Drawing.Point(24, 88);
                        this.ListaHistoral.MultiSelect = false;
                        this.ListaHistoral.Name = "ListaHistoral";
                        this.ListaHistoral.Size = new System.Drawing.Size(696, 272);
                        this.ListaHistoral.TabIndex = 0;
                        this.ListaHistoral.UseCompatibleStateImageBehavior = false;
                        this.ListaHistoral.View = System.Windows.Forms.View.Details;
                        this.ListaHistoral.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaHistoral_KeyDown);
                        this.ListaHistoral.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaHistoral_MouseDoubleClick);
                        // 
                        // ColFecha
                        // 
                        this.ColFecha.Text = "Fecha";
                        this.ColFecha.Width = 205;
                        // 
                        // ColPersona
                        // 
                        this.ColPersona.Text = "Usuario";
                        this.ColPersona.Width = 160;
                        // 
                        // ColAccion
                        // 
                        this.ColAccion.Text = "Accion";
                        this.ColAccion.Width = 151;
                        // 
                        // ColDatos
                        // 
                        this.ColDatos.Text = "Datos";
                        this.ColDatos.Width = 600;
                        // 
                        // formHeader1
                        // 
                        this.formHeader1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.formHeader1.Location = new System.Drawing.Point(0, 0);
                        this.formHeader1.Name = "formHeader1";
                        this.formHeader1.Size = new System.Drawing.Size(738, 64);
                        this.formHeader1.TabIndex = 101;
                        this.formHeader1.Text = "Historial";
                        // 
                        // TimerRefrescar
                        // 
                        this.TimerRefrescar.Enabled = true;
                        this.TimerRefrescar.Interval = 500;
                        this.TimerRefrescar.Tick += new System.EventHandler(this.TimerRefrescar_Tick);
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(738, 443);
                        this.Controls.Add(this.formHeader1);
                        this.Controls.Add(this.ListaHistoral);
                        this.Name = "Editar";
                        this.Text = "Historial";
                        this.Controls.SetChildIndex(this.ListaHistoral, 0);
                        this.Controls.SetChildIndex(this.formHeader1, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.ListView ListaHistoral;
                private System.Windows.Forms.ColumnHeader ColFecha;
                private System.Windows.Forms.ColumnHeader ColPersona;
                private System.Windows.Forms.ColumnHeader ColAccion;
                private System.Windows.Forms.ColumnHeader ColDatos;
                private Lui.Forms.FormHeader formHeader1;
                private System.Windows.Forms.Timer TimerRefrescar;
        }
}