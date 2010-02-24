namespace Lcc.Edicion
{
        partial class FormularioImagen
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
                        this.EntradaImagen = new Lcc.Edicion.Imagen();
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
                        // EntradaImagen
                        // 
                        this.EntradaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaImagen.AutoHeight = true;
                        this.EntradaImagen.AutoNav = true;
                        this.EntradaImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImagen.Location = new System.Drawing.Point(8, 8);
                        this.EntradaImagen.Name = "EntradaImagen";
                        this.EntradaImagen.ReadOnly = false;
                        this.EntradaImagen.Size = new System.Drawing.Size(620, 298);
                        this.EntradaImagen.TabIndex = 51;
                        // 
                        // FormularioImagen
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.EntradaImagen);
                        this.Name = "FormularioImagen";
                        this.Text = "Imagen";
                        this.Controls.SetChildIndex(this.EntradaImagen, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                public Imagen EntradaImagen;

        }
}