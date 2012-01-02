#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lfc.Personas.Usuarios
{
        public partial class Editar
        {
                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el diseñador
                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.EntradaAcceso = new Lui.Forms.ComboBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.EntradaContrasena = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.Listado = new Lui.Forms.ListView();
                        this.ColCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.BotonAgregar = new Lui.Forms.Button();
                        this.BotonQuitar = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // EntradaAcceso
                        // 
                        this.EntradaAcceso.AlwaysExpanded = true;
                        this.EntradaAcceso.AutoNav = true;
                        this.EntradaAcceso.AutoSize = true;
                        this.EntradaAcceso.AutoTab = true;
                        this.EntradaAcceso.FieldName = null;
                        this.EntradaAcceso.Location = new System.Drawing.Point(128, 0);
                        this.EntradaAcceso.MaxLength = 32767;
                        this.EntradaAcceso.Name = "EntradaAcceso";
                        this.EntradaAcceso.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAcceso.PlaceholderText = null;
                        this.EntradaAcceso.ReadOnly = false;
                        this.EntradaAcceso.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaAcceso.Size = new System.Drawing.Size(72, 36);
                        this.EntradaAcceso.TabIndex = 1;
                        this.EntradaAcceso.TextKey = "1";
                        // 
                        // Label6
                        // 
                        this.Label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(0, 0);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(128, 24);
                        this.Label6.TabIndex = 0;
                        this.Label6.Text = "Permitir Acceso";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaContrasena
                        // 
                        this.EntradaContrasena.AutoNav = true;
                        this.EntradaContrasena.AutoTab = true;
                        this.EntradaContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasena.DecimalPlaces = -1;
                        this.EntradaContrasena.FieldName = null;
                        this.EntradaContrasena.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasena.Location = new System.Drawing.Point(348, 0);
                        this.EntradaContrasena.MaxLength = 32767;
                        this.EntradaContrasena.MultiLine = false;
                        this.EntradaContrasena.Name = "EntradaContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.PlaceholderText = null;
                        this.EntradaContrasena.Prefijo = "";
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.SelectOnFocus = false;
                        this.EntradaContrasena.Size = new System.Drawing.Size(132, 24);
                        this.EntradaContrasena.Sufijo = "";
                        this.EntradaContrasena.TabIndex = 3;
                        // 
                        // label1
                        // 
                        this.label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label1.Location = new System.Drawing.Point(220, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(128, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Contraseña";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Listado
                        // 
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColCod,
            this.ColNombre,
            this.ColNivel,
            this.ColItems});
                        this.Listado.FullRowSelect = true;
                        this.Listado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.Listado.LabelWrap = false;
                        this.Listado.Location = new System.Drawing.Point(0, 44);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "Listado";
                        this.Listado.Size = new System.Drawing.Size(636, 316);
                        this.Listado.Sorting = System.Windows.Forms.SortOrder.Ascending;
                        this.Listado.TabIndex = 4;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        this.Listado.DoubleClick += new System.EventHandler(this.Listado_DoubleClick);
                        // 
                        // ColCod
                        // 
                        this.ColCod.Text = "Cod";
                        this.ColCod.Width = 0;
                        // 
                        // ColNombre
                        // 
                        this.ColNombre.Text = "Objeto";
                        this.ColNombre.Width = 160;
                        // 
                        // ColNivel
                        // 
                        this.ColNivel.Text = "Operaciones";
                        this.ColNivel.Width = 263;
                        // 
                        // ColItems
                        // 
                        this.ColItems.Text = "Elementos";
                        this.ColItems.Width = 320;
                        // 
                        // BotonAgregar
                        // 
                        this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregar.Image = null;
                        this.BotonAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregar.Location = new System.Drawing.Point(532, 368);
                        this.BotonAgregar.Name = "BotonAgregar";
                        this.BotonAgregar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregar.ReadOnly = false;
                        this.BotonAgregar.Size = new System.Drawing.Size(104, 28);
                        this.BotonAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAgregar.Subtext = "F6";
                        this.BotonAgregar.TabIndex = 6;
                        this.BotonAgregar.Text = "Agregar";
                        this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // BotonQuitar
                        // 
                        this.BotonQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonQuitar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitar.Image = null;
                        this.BotonQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitar.Location = new System.Drawing.Point(420, 368);
                        this.BotonQuitar.Name = "BotonQuitar";
                        this.BotonQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitar.ReadOnly = false;
                        this.BotonQuitar.Size = new System.Drawing.Size(104, 28);
                        this.BotonQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitar.Subtext = "";
                        this.BotonQuitar.TabIndex = 5;
                        this.BotonQuitar.Text = "Quitar";
                        this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.BotonQuitar);
                        this.Controls.Add(this.BotonAgregar);
                        this.Controls.Add(this.Listado);
                        this.Controls.Add(this.EntradaContrasena);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaAcceso);
                        this.Controls.Add(this.Label6);
                        this.MinimumSize = new System.Drawing.Size(640, 400);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.EntradaAcceso, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaContrasena, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonAgregar, 0);
                        this.Controls.SetChildIndex(this.BotonQuitar, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                private System.Windows.Forms.ColumnHeader ColNivel;
                private System.Windows.Forms.ColumnHeader ColItems;
                private Lui.Forms.Button BotonAgregar;
                private Lui.Forms.Button BotonQuitar;
                private Lui.Forms.ComboBox EntradaAcceso;
                private Lui.Forms.Label Label6;
                private Lui.Forms.Label label1;
                private Lui.Forms.TextBox EntradaContrasena;
                private Lui.Forms.ListView Listado;
                private System.Windows.Forms.ColumnHeader ColCod;
                private System.Windows.Forms.ColumnHeader ColNombre;
                private System.ComponentModel.IContainer components = null;
        }
}
