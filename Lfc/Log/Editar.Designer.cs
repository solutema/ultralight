#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
                        this.ListaHistoral = new Lui.Forms.ListView();
                        this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColAccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColDatos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(384, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(504, 8);
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
                        this.ListaHistoral.Location = new System.Drawing.Point(8, 8);
                        this.ListaHistoral.MultiSelect = false;
                        this.ListaHistoral.Name = "ListaHistoral";
                        this.ListaHistoral.Size = new System.Drawing.Size(608, 288);
                        this.ListaHistoral.TabIndex = 0;
                        this.ListaHistoral.UseCompatibleStateImageBehavior = false;
                        this.ListaHistoral.View = System.Windows.Forms.View.Details;
                        // 
                        // ColFecha
                        // 
                        this.ColFecha.Text = "Fecha";
                        this.ColFecha.Width = 139;
                        // 
                        // ColPersona
                        // 
                        this.ColPersona.Text = "Usuario";
                        this.ColPersona.Width = 160;
                        // 
                        // ColAccion
                        // 
                        this.ColAccion.Text = "Accion";
                        this.ColAccion.Width = 80;
                        // 
                        // ColDatos
                        // 
                        this.ColDatos.Text = "Datos";
                        this.ColDatos.Width = 600;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(624, 362);
                        this.Controls.Add(this.ListaHistoral);
                        this.Name = "Editar";
                        this.Text = "Historial";
                        this.Controls.SetChildIndex(this.ListaHistoral, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.ListView ListaHistoral;
                private System.Windows.Forms.ColumnHeader ColFecha;
                private System.Windows.Forms.ColumnHeader ColPersona;
                private System.Windows.Forms.ColumnHeader ColAccion;
                private System.Windows.Forms.ColumnHeader ColDatos;
        }
}