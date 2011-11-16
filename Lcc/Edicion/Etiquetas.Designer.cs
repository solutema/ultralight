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

namespace Lcc.Edicion
{
        partial class Etiquetas
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
                        this.Lista = new Lui.Forms.ListView();
                        this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.GroupLabel = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // Lista
                        // 
                        this.Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Lista.CheckBoxes = true;
                        this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre});
                        this.Lista.FullRowSelect = true;
                        this.Lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.Lista.LabelWrap = false;
                        this.Lista.Location = new System.Drawing.Point(2, 28);
                        this.Lista.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.Lista.MultiSelect = false;
                        this.Lista.Name = "Lista";
                        this.Lista.Size = new System.Drawing.Size(237, 144);
                        this.Lista.TabIndex = 0;
                        this.Lista.UseCompatibleStateImageBehavior = false;
                        this.Lista.View = System.Windows.Forms.View.Details;
                        this.Lista.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.Lista_ItemChecked);
                        // 
                        // Id
                        // 
                        this.Id.Width = 24;
                        // 
                        // Nombre
                        // 
                        this.Nombre.Width = 200;
                        // 
                        // GroupLabel
                        // 
                        this.GroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.GroupLabel.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.GroupLabel.Location = new System.Drawing.Point(0, 0);
                        this.GroupLabel.Name = "GroupLabel";
                        this.GroupLabel.Size = new System.Drawing.Size(240, 24);
                        this.GroupLabel.TabIndex = 2;
                        this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.GroupLabel.UseMnemonic = false;
                        // 
                        // Etiquetas
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.GroupLabel);
                        this.Controls.Add(this.Lista);
                        this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.Name = "Etiquetas";
                        this.Size = new System.Drawing.Size(240, 173);
                        this.Controls.SetChildIndex(this.Lista, 0);
                        this.Controls.SetChildIndex(this.GroupLabel, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.ListView Lista;
                private System.Windows.Forms.ColumnHeader Id;
                private System.Windows.Forms.ColumnHeader Nombre;
                private Lui.Forms.Label GroupLabel;
        }
}
