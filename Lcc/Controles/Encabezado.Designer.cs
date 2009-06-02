namespace Lcc.Controles
{
        partial class Encabezado
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
                        this.Subraya = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // Subraya
                        // 
                        this.Subraya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Subraya.BackColor = System.Drawing.Color.Gray;
                        this.Subraya.Location = new System.Drawing.Point(0, 21);
                        this.Subraya.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                        this.Subraya.Name = "Subraya";
                        this.Subraya.Size = new System.Drawing.Size(390, 1);
                        this.Subraya.TabIndex = 1;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(4, 4);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(35, 13);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "label1";
                        // 
                        // Encabezado
                        // 
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.Subraya);
                        this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.Name = "Encabezado";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Label Subraya;
                private System.Windows.Forms.Label label1;
        }
}
