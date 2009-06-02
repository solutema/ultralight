namespace Lcc.Controles.Datos
{
        partial class Campo
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
                        this.NombreCampo = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // NombreCampo
                        // 
                        this.NombreCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.NombreCampo.AutoEllipsis = true;
                        this.NombreCampo.AutoSize = true;
                        this.NombreCampo.Location = new System.Drawing.Point(0, 0);
                        this.NombreCampo.Name = "NombreCampo";
                        this.NombreCampo.Padding = new System.Windows.Forms.Padding(2);
                        this.NombreCampo.Size = new System.Drawing.Size(63, 19);
                        this.NombreCampo.TabIndex = 0;
                        this.NombreCampo.Text = "Nombre";
                        this.NombreCampo.UseMnemonic = false;
                        // 
                        // Campo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.NombreCampo);
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.Name = "Campo";
                        this.Size = new System.Drawing.Size(320, 200);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Label NombreCampo;
        }
}
