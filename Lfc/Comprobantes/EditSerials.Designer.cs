﻿namespace Lfc.Comprobantes
{
        partial class EditSerials
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
                        this.ListaSeries = new Lcc.Controles.ListView();
                        this.serie = new System.Windows.Forms.ColumnHeader();
                        this.EntradaSeries = new Lcc.Controles.TextBox();
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
                        this.EntradaSeries.Multiline = true;
                        this.EntradaSeries.Name = "EntradaSeries";
                        this.EntradaSeries.SelectOnFocus = true;
                        this.EntradaSeries.Size = new System.Drawing.Size(456, 216);
                        this.EntradaSeries.TabIndex = 0;
                        this.EntradaSeries.TipWhenBlank = null;
                        this.EntradaSeries.ToolTipText = null;
                        // 
                        // EditSerials
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(474, 294);
                        this.Controls.Add(this.ListaSeries);
                        this.Controls.Add(this.EntradaSeries);
                        this.Name = "EditSerials";
                        this.Text = "Editar Nº de Serie";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditSerials_KeyDown);
                        this.Controls.SetChildIndex(this.EntradaSeries, 0);
                        this.Controls.SetChildIndex(this.ListaSeries, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lcc.Controles.ListView ListaSeries;
                private Lcc.Controles.TextBox EntradaSeries;
                private System.Windows.Forms.ColumnHeader serie;
        }
}