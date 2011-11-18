#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lcc.Edicion
{
        partial class Comentarios
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
                        this.ListaComentarios = new Lui.Forms.ListView();
                        this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColComentario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EntradaComentario = new Lui.Forms.TextBox();
                        this.BotonAgregar = new Lui.Forms.Button();
                        this.GroupLabel = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // ListaComentarios
                        // 
                        this.ListaComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaComentarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColFecha,
            this.ColPersona,
            this.ColComentario});
                        this.ListaComentarios.FullRowSelect = true;
                        this.ListaComentarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaComentarios.LabelWrap = false;
                        this.ListaComentarios.Location = new System.Drawing.Point(0, 27);
                        this.ListaComentarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.ListaComentarios.MultiSelect = false;
                        this.ListaComentarios.Name = "ListaComentarios";
                        this.ListaComentarios.Size = new System.Drawing.Size(552, 205);
                        this.ListaComentarios.TabIndex = 50;
                        this.ListaComentarios.TabStop = false;
                        this.ListaComentarios.UseCompatibleStateImageBehavior = false;
                        this.ListaComentarios.View = System.Windows.Forms.View.Details;
                        this.ListaComentarios.SizeChanged += new System.EventHandler(this.ListaComentarios_SizeChanged);
                        // 
                        // ColId
                        // 
                        this.ColId.Text = "Cód.";
                        this.ColId.Width = 0;
                        // 
                        // ColFecha
                        // 
                        this.ColFecha.Text = "Fecha";
                        this.ColFecha.Width = 74;
                        // 
                        // ColPersona
                        // 
                        this.ColPersona.Text = "Usuario";
                        this.ColPersona.Width = 74;
                        // 
                        // ColComentario
                        // 
                        this.ColComentario.Text = "Comentario";
                        this.ColComentario.Width = 640;
                        // 
                        // EntradaComentario
                        // 
                        this.EntradaComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaComentario.AutoNav = true;
                        this.EntradaComentario.AutoTab = true;
                        this.EntradaComentario.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaComentario.DecimalPlaces = -1;
                        this.EntradaComentario.FieldName = null;
                        this.EntradaComentario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaComentario.Location = new System.Drawing.Point(0, 236);
                        this.EntradaComentario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.EntradaComentario.MaxLength = 32767;
                        this.EntradaComentario.MultiLine = false;
                        this.EntradaComentario.Name = "EntradaComentario";
                        this.EntradaComentario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaComentario.PasswordChar = '\0';
                        this.EntradaComentario.PlaceholderText = null;
                        this.EntradaComentario.Prefijo = "";
                        this.EntradaComentario.ReadOnly = false;
                        this.EntradaComentario.SelectOnFocus = true;
                        this.EntradaComentario.Size = new System.Drawing.Size(464, 24);
                        this.EntradaComentario.Sufijo = "";
                        this.EntradaComentario.TabIndex = 0;
                        this.EntradaComentario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaComentario_KeyDown);
                        this.EntradaComentario.TextChanged += new System.EventHandler(this.EntradaComentario_TextChanged);
                        // 
                        // BotonAgregar
                        // 
                        this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregar.Enabled = false;
                        this.BotonAgregar.Image = null;
                        this.BotonAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregar.Location = new System.Drawing.Point(468, 236);
                        this.BotonAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.BotonAgregar.Name = "BotonAgregar";
                        this.BotonAgregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.BotonAgregar.ReadOnly = false;
                        this.BotonAgregar.Size = new System.Drawing.Size(85, 24);
                        this.BotonAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAgregar.Subtext = "Tecla";
                        this.BotonAgregar.TabIndex = 1;
                        this.BotonAgregar.TabStop = false;
                        this.BotonAgregar.Text = "Agregar";
                        this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // GroupLabel
                        // 
                        this.GroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.GroupLabel.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.GroupLabel.Location = new System.Drawing.Point(0, 0);
                        this.GroupLabel.Name = "GroupLabel";
                        this.GroupLabel.Size = new System.Drawing.Size(553, 24);
                        this.GroupLabel.TabIndex = 51;
                        this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.GroupLabel.UseMnemonic = false;
                        // 
                        // Comentarios
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.Controls.Add(this.GroupLabel);
                        this.Controls.Add(this.BotonAgregar);
                        this.Controls.Add(this.EntradaComentario);
                        this.Controls.Add(this.ListaComentarios);
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.Name = "Comentarios";
                        this.Size = new System.Drawing.Size(552, 260);
                        this.Controls.SetChildIndex(this.ListaComentarios, 0);
                        this.Controls.SetChildIndex(this.EntradaComentario, 0);
                        this.Controls.SetChildIndex(this.BotonAgregar, 0);
                        this.Controls.SetChildIndex(this.GroupLabel, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.ListView ListaComentarios;
                private Lui.Forms.TextBox EntradaComentario;
                private Lui.Forms.Button BotonAgregar;
                private System.Windows.Forms.ColumnHeader ColId;
                private System.Windows.Forms.ColumnHeader ColFecha;
                private System.Windows.Forms.ColumnHeader ColPersona;
                private System.Windows.Forms.ColumnHeader ColComentario;
                private Lui.Forms.Label GroupLabel;
        }
}
