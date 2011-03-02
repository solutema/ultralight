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

namespace Lfc.Comprobantes
{
        partial class EditarSeguimiento
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
                        this.VariacionesCantidades = new Lcc.Entrada.Articulos.MatrizVariacionCantidad();
                        this.ListaDatosSeguimiento = new Lui.Forms.ListView();
                        this.Variacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.VariacionCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EtiquetaArticulo = new Lui.Forms.Label();
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
                        // VariacionesCantidades
                        // 
                        this.VariacionesCantidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.VariacionesCantidades.AutoNav = true;
                        this.VariacionesCantidades.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.VariacionesCantidades.EsNumeroDeSerie = false;
                        this.VariacionesCantidades.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.VariacionesCantidades.Location = new System.Drawing.Point(16, 40);
                        this.VariacionesCantidades.Name = "VariacionesCantidades";
                        this.VariacionesCantidades.Padding = new System.Windows.Forms.Padding(2);
                        this.VariacionesCantidades.Size = new System.Drawing.Size(604, 256);
                        this.VariacionesCantidades.TabIndex = 0;
                        this.VariacionesCantidades.ToolTipText = "";
                        // 
                        // ListaDatosSeguimiento
                        // 
                        this.ListaDatosSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaDatosSeguimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaDatosSeguimiento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Variacion,
            this.VariacionCantidad});
                        this.ListaDatosSeguimiento.FullRowSelect = true;
                        this.ListaDatosSeguimiento.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaDatosSeguimiento.HideSelection = false;
                        this.ListaDatosSeguimiento.Location = new System.Drawing.Point(16, 40);
                        this.ListaDatosSeguimiento.MultiSelect = false;
                        this.ListaDatosSeguimiento.Name = "ListaDatosSeguimiento";
                        this.ListaDatosSeguimiento.Size = new System.Drawing.Size(600, 256);
                        this.ListaDatosSeguimiento.TabIndex = 1;
                        this.ListaDatosSeguimiento.UseCompatibleStateImageBehavior = false;
                        this.ListaDatosSeguimiento.View = System.Windows.Forms.View.Details;
                        // 
                        // Variacion
                        // 
                        this.Variacion.Text = "Variación";
                        this.Variacion.Width = 461;
                        // 
                        // VariacionCantidad
                        // 
                        this.VariacionCantidad.Text = "Cantidad";
                        this.VariacionCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.VariacionCantidad.Width = 96;
                        // 
                        // EtiquetaArticulo
                        // 
                        this.EtiquetaArticulo.AutoEllipsis = true;
                        this.EtiquetaArticulo.Location = new System.Drawing.Point(16, 16);
                        this.EtiquetaArticulo.Name = "EtiquetaArticulo";
                        this.EtiquetaArticulo.Size = new System.Drawing.Size(600, 24);
                        this.EtiquetaArticulo.TabIndex = 51;
                        this.EtiquetaArticulo.Text = "Seleccione artículos";
                        this.EtiquetaArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaArticulo.UseMnemonic = false;
                        // 
                        // EditarSeguimiento
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.EtiquetaArticulo);
                        this.Controls.Add(this.ListaDatosSeguimiento);
                        this.Controls.Add(this.VariacionesCantidades);
                        this.Name = "EditarSeguimiento";
                        this.Text = "Datos de Seguimiento";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditarSeries_KeyDown);
                        this.Controls.SetChildIndex(this.VariacionesCantidades, 0);
                        this.Controls.SetChildIndex(this.ListaDatosSeguimiento, 0);
                        this.Controls.SetChildIndex(this.EtiquetaArticulo, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lcc.Entrada.Articulos.MatrizVariacionCantidad VariacionesCantidades;
                private Lui.Forms.ListView ListaDatosSeguimiento;
                private System.Windows.Forms.ColumnHeader Variacion;
                private System.Windows.Forms.ColumnHeader VariacionCantidad;
                private Lui.Forms.Label EtiquetaArticulo;

        }
}