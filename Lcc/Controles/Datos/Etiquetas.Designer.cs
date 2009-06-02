namespace Lcc.Controles.Datos
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
                        this.Lista = new Lcc.Controles.ListView();
                        this.Id = new System.Windows.Forms.ColumnHeader();
                        this.Nombre = new System.Windows.Forms.ColumnHeader();
                        this.SuspendLayout();
                        // 
                        // Lista
                        // 
                        this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Lista.CheckBoxes = true;
                        this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre});
                        this.Lista.FullRowSelect = true;
                        this.Lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.Lista.LabelWrap = false;
                        this.Lista.Location = new System.Drawing.Point(2, 2);
                        this.Lista.MultiSelect = false;
                        this.Lista.Name = "Lista";
                        this.Lista.Size = new System.Drawing.Size(316, 196);
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
                        this.Nombre.Width = 316;
                        // 
                        // Etiquetas
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.Lista);
                        this.Name = "Etiquetas";
                        this.Size = new System.Drawing.Size(320, 200);
                        this.Controls.SetChildIndex(this.Lista, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lcc.Controles.ListView Lista;
                private System.Windows.Forms.ColumnHeader Id;
                private System.Windows.Forms.ColumnHeader Nombre;
        }
}
