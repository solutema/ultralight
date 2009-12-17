namespace Lcc.Edicion.Articulos
{
        partial class Denominacion
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
                        this.encabezado1 = new Lcc.Controles.Encabezado();
                        this.EntradaCategoria = new Lui.Forms.DetailBox();
                        this.campo1 = new Lcc.Controles.Datos.Campo();
                        this.EntradaMarca = new Lui.Forms.DetailBox();
                        this.campo2 = new Lcc.Controles.Datos.Campo();
                        this.EntradaModelo = new Lui.Forms.TextBox();
                        this.campo3 = new Lcc.Controles.Datos.Campo();
                        this.EntradaSerie = new Lui.Forms.TextBox();
                        this.campo4 = new Lcc.Controles.Datos.Campo();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.campo5 = new Lcc.Controles.Datos.Campo();
                        this.EntradaDescripcion = new Lui.Forms.TextBox();
                        this.campo6 = new Lcc.Controles.Datos.Campo();
                        this.contenedorCampos1 = new Lcc.Controles.ContenedorCampos();
                        this.campo1.SuspendLayout();
                        this.campo2.SuspendLayout();
                        this.campo3.SuspendLayout();
                        this.campo4.SuspendLayout();
                        this.campo5.SuspendLayout();
                        this.campo6.SuspendLayout();
                        this.contenedorCampos1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // encabezado1
                        // 
                        this.encabezado1.AutoHeight = true;
                        this.encabezado1.AutoNav = true;
                        this.encabezado1.Location = new System.Drawing.Point(2, 3);
                        this.encabezado1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.encabezado1.Name = "encabezado1";
                        this.encabezado1.ReadOnly = false;
                        this.encabezado1.Size = new System.Drawing.Size(499, 23);
                        this.encabezado1.TabIndex = 5;
                        this.encabezado1.Text = "Denomicación";
                        // 
                        // EntradaCategoria
                        // 
                        this.EntradaCategoria.AutoHeight = false;
                        this.EntradaCategoria.AutoTab = true;
                        this.EntradaCategoria.CanCreate = true;
                        this.EntradaCategoria.DetailField = "nombre";
                        this.EntradaCategoria.Dock = System.Windows.Forms.DockStyle.Right;
                        this.EntradaCategoria.ExtraDetailFields = null;
                        this.EntradaCategoria.Filter = "";
                        this.EntradaCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCategoria.FreeTextCode = "";
                        this.EntradaCategoria.KeyField = "id_cat_articulo";
                        this.EntradaCategoria.Location = new System.Drawing.Point(67, 0);
                        this.EntradaCategoria.MaxLength = 200;
                        this.EntradaCategoria.Name = "EntradaCategoria";
                        this.EntradaCategoria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCategoria.ReadOnly = false;
                        this.EntradaCategoria.Required = true;
                        this.EntradaCategoria.SelectOnFocus = false;
                        this.EntradaCategoria.Size = new System.Drawing.Size(430, 24);
                        this.EntradaCategoria.TabIndex = 10;
                        this.EntradaCategoria.Table = "cat_articulos";
                        this.EntradaCategoria.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCategoria.Text = "0";
                        this.EntradaCategoria.TextDetail = "";
                        this.EntradaCategoria.TextInt = 0;
                        this.EntradaCategoria.TipWhenBlank = "";
                        this.EntradaCategoria.ToolTipText = "Rubro o categoría";
                        // 
                        // campo1
                        // 
                        this.campo1.AutoHeight = true;
                        this.campo1.AutoNav = true;
                        this.campo1.Controls.Add(this.EntradaCategoria);
                        this.campo1.LabelWidth = 67;
                        this.campo1.Location = new System.Drawing.Point(3, 32);
                        this.campo1.Name = "campo1";
                        this.campo1.Orientation = System.Windows.Forms.Orientation.Horizontal;
                        this.campo1.ReadOnly = false;
                        this.campo1.Size = new System.Drawing.Size(497, 24);
                        this.campo1.TabIndex = 0;
                        this.campo1.Text = "Categoría";
                        // 
                        // EntradaMarca
                        // 
                        this.EntradaMarca.AutoHeight = false;
                        this.EntradaMarca.AutoTab = true;
                        this.EntradaMarca.CanCreate = true;
                        this.EntradaMarca.DetailField = "nombre";
                        this.EntradaMarca.Dock = System.Windows.Forms.DockStyle.Right;
                        this.EntradaMarca.ExtraDetailFields = null;
                        this.EntradaMarca.Filter = "";
                        this.EntradaMarca.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMarca.FreeTextCode = "";
                        this.EntradaMarca.KeyField = "id_marca";
                        this.EntradaMarca.Location = new System.Drawing.Point(67, 0);
                        this.EntradaMarca.MaxLength = 200;
                        this.EntradaMarca.Name = "EntradaMarca";
                        this.EntradaMarca.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMarca.ReadOnly = false;
                        this.EntradaMarca.Required = false;
                        this.EntradaMarca.SelectOnFocus = false;
                        this.EntradaMarca.Size = new System.Drawing.Size(430, 24);
                        this.EntradaMarca.TabIndex = 12;
                        this.EntradaMarca.Table = "marcas";
                        this.EntradaMarca.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaMarca.Text = "0";
                        this.EntradaMarca.TextDetail = "";
                        this.EntradaMarca.TextInt = 0;
                        this.EntradaMarca.TipWhenBlank = "Sin especificar";
                        this.EntradaMarca.ToolTipText = "";
                        // 
                        // campo2
                        // 
                        this.campo2.AutoHeight = true;
                        this.campo2.AutoNav = true;
                        this.campo2.Controls.Add(this.EntradaMarca);
                        this.campo2.LabelWidth = 67;
                        this.campo2.Location = new System.Drawing.Point(3, 62);
                        this.campo2.Name = "campo2";
                        this.campo2.Orientation = System.Windows.Forms.Orientation.Horizontal;
                        this.campo2.ReadOnly = false;
                        this.campo2.Size = new System.Drawing.Size(497, 24);
                        this.campo2.TabIndex = 1;
                        this.campo2.Text = "Marca";
                        // 
                        // EntradaModelo
                        // 
                        this.EntradaModelo.AutoHeight = false;
                        this.EntradaModelo.AutoNav = true;
                        this.EntradaModelo.AutoTab = true;
                        this.EntradaModelo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaModelo.DecimalPlaces = -1;
                        this.EntradaModelo.Dock = System.Windows.Forms.DockStyle.Right;
                        this.EntradaModelo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaModelo.Location = new System.Drawing.Point(67, 0);
                        this.EntradaModelo.MaxLenght = 32767;
                        this.EntradaModelo.MultiLine = false;
                        this.EntradaModelo.Name = "EntradaModelo";
                        this.EntradaModelo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModelo.PasswordChar = '\0';
                        this.EntradaModelo.Prefijo = "";
                        this.EntradaModelo.ReadOnly = false;
                        this.EntradaModelo.SelectOnFocus = false;
                        this.EntradaModelo.Size = new System.Drawing.Size(430, 24);
                        this.EntradaModelo.Sufijo = "";
                        this.EntradaModelo.TabIndex = 14;
                        this.EntradaModelo.TextRaw = "";
                        this.EntradaModelo.TipWhenBlank = "";
                        this.EntradaModelo.ToolTipText = "";
                        // 
                        // campo3
                        // 
                        this.campo3.AutoHeight = true;
                        this.campo3.AutoNav = true;
                        this.campo3.Controls.Add(this.EntradaModelo);
                        this.campo3.LabelWidth = 67;
                        this.campo3.Location = new System.Drawing.Point(3, 92);
                        this.campo3.Name = "campo3";
                        this.campo3.Orientation = System.Windows.Forms.Orientation.Horizontal;
                        this.campo3.ReadOnly = false;
                        this.campo3.Size = new System.Drawing.Size(497, 24);
                        this.campo3.TabIndex = 2;
                        this.campo3.Text = "Modelo";
                        // 
                        // EntradaSerie
                        // 
                        this.EntradaSerie.AutoHeight = false;
                        this.EntradaSerie.AutoNav = true;
                        this.EntradaSerie.AutoTab = true;
                        this.EntradaSerie.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaSerie.DecimalPlaces = -1;
                        this.EntradaSerie.Dock = System.Windows.Forms.DockStyle.Right;
                        this.EntradaSerie.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaSerie.Location = new System.Drawing.Point(67, 0);
                        this.EntradaSerie.MaxLenght = 32767;
                        this.EntradaSerie.MultiLine = false;
                        this.EntradaSerie.Name = "EntradaSerie";
                        this.EntradaSerie.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSerie.PasswordChar = '\0';
                        this.EntradaSerie.Prefijo = "";
                        this.EntradaSerie.ReadOnly = false;
                        this.EntradaSerie.SelectOnFocus = false;
                        this.EntradaSerie.Size = new System.Drawing.Size(430, 24);
                        this.EntradaSerie.Sufijo = "";
                        this.EntradaSerie.TabIndex = 16;
                        this.EntradaSerie.TextRaw = "";
                        this.EntradaSerie.TipWhenBlank = "";
                        this.EntradaSerie.ToolTipText = "";
                        // 
                        // campo4
                        // 
                        this.campo4.AutoHeight = true;
                        this.campo4.AutoNav = true;
                        this.campo4.Controls.Add(this.EntradaSerie);
                        this.campo4.LabelWidth = 67;
                        this.campo4.Location = new System.Drawing.Point(3, 122);
                        this.campo4.Name = "campo4";
                        this.campo4.Orientation = System.Windows.Forms.Orientation.Horizontal;
                        this.campo4.ReadOnly = false;
                        this.campo4.Size = new System.Drawing.Size(497, 24);
                        this.campo4.TabIndex = 3;
                        this.campo4.Text = "Serie";
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.AutoHeight = false;
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Dock = System.Windows.Forms.DockStyle.Right;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(67, 0);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(430, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 18;
                        this.EntradaNombre.TextRaw = "";
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "Nombre completo del artículo";
                        // 
                        // campo5
                        // 
                        this.campo5.AutoHeight = true;
                        this.campo5.AutoNav = true;
                        this.campo5.Controls.Add(this.EntradaNombre);
                        this.campo5.LabelWidth = 67;
                        this.campo5.Location = new System.Drawing.Point(3, 152);
                        this.campo5.Name = "campo5";
                        this.campo5.Orientation = System.Windows.Forms.Orientation.Horizontal;
                        this.campo5.ReadOnly = false;
                        this.campo5.Size = new System.Drawing.Size(497, 24);
                        this.campo5.TabIndex = 4;
                        this.campo5.Text = "Nombre";
                        // 
                        // EntradaDescripcion
                        // 
                        this.EntradaDescripcion.AutoHeight = false;
                        this.EntradaDescripcion.AutoNav = true;
                        this.EntradaDescripcion.AutoTab = true;
                        this.EntradaDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDescripcion.DecimalPlaces = -1;
                        this.EntradaDescripcion.Dock = System.Windows.Forms.DockStyle.Right;
                        this.EntradaDescripcion.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDescripcion.Location = new System.Drawing.Point(67, 0);
                        this.EntradaDescripcion.MaxLenght = 32767;
                        this.EntradaDescripcion.MultiLine = true;
                        this.EntradaDescripcion.Name = "EntradaDescripcion";
                        this.EntradaDescripcion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDescripcion.PasswordChar = '\0';
                        this.EntradaDescripcion.Prefijo = "";
                        this.EntradaDescripcion.ReadOnly = false;
                        this.EntradaDescripcion.SelectOnFocus = false;
                        this.EntradaDescripcion.Size = new System.Drawing.Size(430, 64);
                        this.EntradaDescripcion.Sufijo = "";
                        this.EntradaDescripcion.TabIndex = 24;
                        this.EntradaDescripcion.TextRaw = "";
                        this.EntradaDescripcion.TipWhenBlank = "";
                        this.EntradaDescripcion.ToolTipText = "Descripción larga";
                        // 
                        // campo6
                        // 
                        this.campo6.AutoHeight = true;
                        this.campo6.AutoNav = true;
                        this.campo6.Controls.Add(this.EntradaDescripcion);
                        this.campo6.LabelWidth = 67;
                        this.campo6.Location = new System.Drawing.Point(3, 182);
                        this.campo6.Name = "campo6";
                        this.campo6.Orientation = System.Windows.Forms.Orientation.Horizontal;
                        this.campo6.ReadOnly = false;
                        this.campo6.Size = new System.Drawing.Size(497, 64);
                        this.campo6.TabIndex = 6;
                        this.campo6.Text = "Descripción";
                        // 
                        // contenedorCampos1
                        // 
                        this.contenedorCampos1.AutoHeight = true;
                        this.contenedorCampos1.Controls.Add(this.encabezado1);
                        this.contenedorCampos1.Controls.Add(this.campo1);
                        this.contenedorCampos1.Controls.Add(this.campo2);
                        this.contenedorCampos1.Controls.Add(this.campo3);
                        this.contenedorCampos1.Controls.Add(this.campo4);
                        this.contenedorCampos1.Controls.Add(this.campo5);
                        this.contenedorCampos1.Controls.Add(this.campo6);
                        this.contenedorCampos1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.contenedorCampos1.Location = new System.Drawing.Point(0, 0);
                        this.contenedorCampos1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.contenedorCampos1.Name = "contenedorCampos1";
                        this.contenedorCampos1.Size = new System.Drawing.Size(503, 249);
                        this.contenedorCampos1.TabIndex = 4;
                        // 
                        // Denominacion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.contenedorCampos1);
                        this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                        this.Name = "Denominacion";
                        this.Size = new System.Drawing.Size(503, 244);
                        this.campo1.ResumeLayout(false);
                        this.campo1.PerformLayout();
                        this.campo2.ResumeLayout(false);
                        this.campo2.PerformLayout();
                        this.campo3.ResumeLayout(false);
                        this.campo3.PerformLayout();
                        this.campo4.ResumeLayout(false);
                        this.campo4.PerformLayout();
                        this.campo5.ResumeLayout(false);
                        this.campo5.PerformLayout();
                        this.campo6.ResumeLayout(false);
                        this.campo6.PerformLayout();
                        this.contenedorCampos1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                private Lcc.Controles.Encabezado encabezado1;
                private Lui.Forms.DetailBox EntradaCategoria;
                private Lcc.Controles.Datos.Campo campo1;
                private Lui.Forms.DetailBox EntradaMarca;
                private Lcc.Controles.Datos.Campo campo2;
                private Lui.Forms.TextBox EntradaModelo;
                private Lcc.Controles.Datos.Campo campo3;
                private Lui.Forms.TextBox EntradaSerie;
                private Lcc.Controles.Datos.Campo campo4;
                private Lui.Forms.TextBox EntradaNombre;
                private Lcc.Controles.Datos.Campo campo5;
                private Lui.Forms.TextBox EntradaDescripcion;
                private Lcc.Controles.Datos.Campo campo6;
                private Lcc.Controles.ContenedorCampos contenedorCampos1;
        }
}
