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
                        this.ListaConformacion = new Lcc.Controles.ListView();
                        this.articulo = new System.Windows.Forms.ColumnHeader();
                        this.serie = new System.Windows.Forms.ColumnHeader();
                        this.SuspendLayout();
                        // 
                        // ListaConformacion
                        // 
                        this.ListaConformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaConformacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaConformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.articulo,
            this.serie});
                        this.ListaConformacion.FullRowSelect = true;
                        this.ListaConformacion.GridLines = true;
                        this.ListaConformacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.ListaConformacion.LabelWrap = false;
                        this.ListaConformacion.Location = new System.Drawing.Point(8, 8);
                        this.ListaConformacion.MultiSelect = false;
                        this.ListaConformacion.Name = "ListaConformacion";
                        this.ListaConformacion.Size = new System.Drawing.Size(676, 400);
                        this.ListaConformacion.TabIndex = 0;
                        this.ListaConformacion.UseCompatibleStateImageBehavior = false;
                        this.ListaConformacion.View = System.Windows.Forms.View.Details;
                        // 
                        // articulo
                        // 
                        this.articulo.Text = "Artículo";
                        this.articulo.Width = 320;
                        // 
                        // serie
                        // 
                        this.serie.Width = 320;
                        // 
                        // VerConformacion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.ListaConformacion);
                        this.Name = "VerConformacion";
                        this.Text = "Conformación del stock";
                        this.Controls.SetChildIndex(this.ListaConformacion, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lcc.Controles.ListView ListaConformacion;
                private System.Windows.Forms.ColumnHeader articulo;
                private System.Windows.Forms.ColumnHeader serie;
        }
}