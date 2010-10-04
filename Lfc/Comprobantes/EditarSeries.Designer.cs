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

namespace Lfc.Comprobantes
{
        partial class EditarSeries
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
                        this.ListaSeries = new Lui.Forms.ListView();
                        this.serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EntradaSeries = new Lui.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // ListaSeries
                        // 
                        this.ListaSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serie});
                        this.ListaSeries.FullRowSelect = true;
                        this.ListaSeries.GridLines = true;
                        this.ListaSeries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.ListaSeries.LabelWrap = false;
                        this.ListaSeries.Location = new System.Drawing.Point(8, 8);
                        this.ListaSeries.MultiSelect = false;
                        this.ListaSeries.Name = "ListaSeries";
                        this.ListaSeries.Size = new System.Drawing.Size(456, 216);
                        this.ListaSeries.TabIndex = 0;
                        this.ListaSeries.UseCompatibleStateImageBehavior = false;
                        this.ListaSeries.View = System.Windows.Forms.View.Details;
                        this.ListaSeries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaSeries_KeyDown);
                        // 
                        // serie
                        // 
                        this.serie.Text = "Nº de Serie";
                        this.serie.Width = 452;
                        // 
                        // EntradaSeries
                        // 
                        this.EntradaSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSeries.AutoHeight = true;
                        this.EntradaSeries.AutoNav = true;
                        this.EntradaSeries.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaSeries.Location = new System.Drawing.Point(8, 8);
                        this.EntradaSeries.MultiLine = true;
                        this.EntradaSeries.Name = "EntradaSeries";
                        this.EntradaSeries.SelectOnFocus = true;
                        this.EntradaSeries.Size = new System.Drawing.Size(456, 216);
                        this.EntradaSeries.TabIndex = 0;
                        this.EntradaSeries.TipWhenBlank = null;
                        this.EntradaSeries.ToolTipText = null;
                        // 
                        // EditarSeries
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(474, 294);
                        this.Controls.Add(this.ListaSeries);
                        this.Controls.Add(this.EntradaSeries);
                        this.Name = "EditarSeries";
                        this.Text = "Editar Nº de Serie";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditarSeries_KeyDown);
                        this.Controls.SetChildIndex(this.EntradaSeries, 0);
                        this.Controls.SetChildIndex(this.ListaSeries, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.ListView ListaSeries;
                private Lui.Forms.TextBox EntradaSeries;
                private System.Windows.Forms.ColumnHeader serie;
        }
}