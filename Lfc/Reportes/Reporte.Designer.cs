// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lfc.Reportes
{
        partial class Reporte
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
                        this.ListViewReporte = new System.Windows.Forms.ListView();
                        this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
                        this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
                        this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
                        this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
                        this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
                        this.BotonActualizar = new Lui.Forms.Button();
                        this.EntradaExpandirGrupos = new Lui.Forms.ComboBox();
                        this.SuspendLayout();
                        // 
                        // ListViewReporte
                        // 
                        this.ListViewReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListViewReporte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
                        this.ListViewReporte.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListViewReporte.Location = new System.Drawing.Point(12, 44);
                        this.ListViewReporte.Name = "ListViewReporte";
                        this.ListViewReporte.Size = new System.Drawing.Size(744, 424);
                        this.ListViewReporte.TabIndex = 2;
                        this.ListViewReporte.UseCompatibleStateImageBehavior = false;
                        this.ListViewReporte.View = System.Windows.Forms.View.Details;
                        // 
                        // BotonActualizar
                        // 
                        this.BotonActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonActualizar.AutoHeight = false;
                        this.BotonActualizar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonActualizar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonActualizar.Image = null;
                        this.BotonActualizar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonActualizar.Location = new System.Drawing.Point(668, 12);
                        this.BotonActualizar.Name = "BotonActualizar";
                        this.BotonActualizar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonActualizar.ReadOnly = false;
                        this.BotonActualizar.Size = new System.Drawing.Size(84, 24);
                        this.BotonActualizar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonActualizar.Subtext = "Tecla";
                        this.BotonActualizar.TabIndex = 1;
                        this.BotonActualizar.Text = "Actualizar";
                        this.BotonActualizar.ToolTipText = "";
                        this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
                        // 
                        // EntradaExpandirGrupos
                        // 
                        this.EntradaExpandirGrupos.AutoHeight = false;
                        this.EntradaExpandirGrupos.AutoNav = true;
                        this.EntradaExpandirGrupos.AutoTab = true;
                        this.EntradaExpandirGrupos.DetailField = null;
                        this.EntradaExpandirGrupos.Filter = null;
                        this.EntradaExpandirGrupos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaExpandirGrupos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaExpandirGrupos.KeyField = null;
                        this.EntradaExpandirGrupos.Location = new System.Drawing.Point(124, 12);
                        this.EntradaExpandirGrupos.MaxLenght = 32767;
                        this.EntradaExpandirGrupos.Name = "EntradaExpandirGrupos";
                        this.EntradaExpandirGrupos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaExpandirGrupos.ReadOnly = false;
                        this.EntradaExpandirGrupos.SetData = new string[] {
        "Mostrar detalles|1",
        "Sólo subtotales|0"};
                        this.EntradaExpandirGrupos.Size = new System.Drawing.Size(148, 24);
                        this.EntradaExpandirGrupos.TabIndex = 0;
                        this.EntradaExpandirGrupos.Table = null;
                        this.EntradaExpandirGrupos.Text = "Sólo subtotales";
                        this.EntradaExpandirGrupos.TextKey = "0";
                        this.EntradaExpandirGrupos.TextRaw = "Sólo subtotales";
                        this.EntradaExpandirGrupos.TipWhenBlank = "";
                        this.EntradaExpandirGrupos.ToolTipText = "";
                        // 
                        // Reporte
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.EntradaExpandirGrupos);
                        this.Controls.Add(this.BotonActualizar);
                        this.Controls.Add(this.ListViewReporte);
                        this.Name = "Reporte";
                        this.Text = "Reporte";
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.ListView ListViewReporte;
                private Lui.Forms.Button BotonActualizar;
                private System.Windows.Forms.ColumnHeader columnHeader1;
                private System.Windows.Forms.ColumnHeader columnHeader2;
                private System.Windows.Forms.ColumnHeader columnHeader3;
                private System.Windows.Forms.ColumnHeader columnHeader4;
                private System.Windows.Forms.ColumnHeader columnHeader5;
                internal Lui.Forms.ComboBox EntradaExpandirGrupos;
        }
}