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

namespace Lfc.Articulos
{
        partial class VerConformacion
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
                        this.ListaConformacion = new Lui.Forms.ListView();
                        this.ColSituacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.label10 = new Lui.Forms.Label();
                        this.EtiquetaTitulo = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // ListaConformacion
                        // 
                        this.ListaConformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaConformacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaConformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColSituacion,
            this.ColCantidad});
                        this.ListaConformacion.FullRowSelect = true;
                        this.ListaConformacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaConformacion.LabelWrap = false;
                        this.ListaConformacion.Location = new System.Drawing.Point(24, 104);
                        this.ListaConformacion.MultiSelect = false;
                        this.ListaConformacion.Name = "ListaConformacion";
                        this.ListaConformacion.Size = new System.Drawing.Size(640, 280);
                        this.ListaConformacion.TabIndex = 0;
                        this.ListaConformacion.UseCompatibleStateImageBehavior = false;
                        this.ListaConformacion.View = System.Windows.Forms.View.Details;
                        // 
                        // ColSituacion
                        // 
                        this.ColSituacion.Text = "Situación";
                        this.ColSituacion.Width = 480;
                        // 
                        // ColCantidad
                        // 
                        this.ColCantidad.Text = "Cantidad";
                        this.ColCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColCantidad.Width = 120;
                        // 
                        // label10
                        // 
                        this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label10.Location = new System.Drawing.Point(24, 64);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(640, 24);
                        this.label10.TabIndex = 106;
                        this.label10.Text = "Las existencias actuales de este artículo están conformadas de la siguiente maner" +
    "a:";
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.AutoSize = true;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(24, 24);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(320, 30);
                        this.EtiquetaTitulo.TabIndex = 105;
                        this.EtiquetaTitulo.Text = "Conformación de las existencias";
                        this.EtiquetaTitulo.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        // 
                        // VerConformacion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(689, 473);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.ListaConformacion);
                        this.Controls.Add(this.label10);
                        this.Name = "VerConformacion";
                        this.Text = "Artículos: Conformación de las existencias";
                        this.Controls.SetChildIndex(this.label10, 0);
                        this.Controls.SetChildIndex(this.ListaConformacion, 0);
                        this.Controls.SetChildIndex(this.EtiquetaTitulo, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.ListView ListaConformacion;
                private System.Windows.Forms.ColumnHeader ColSituacion;
                private System.Windows.Forms.ColumnHeader ColCantidad;
                private Lui.Forms.Label label10;
                private Lui.Forms.Label EtiquetaTitulo;
        }
}