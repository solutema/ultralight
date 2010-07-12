#region License
// Copyright 2004-2010 South Bridge S.R.L.
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

namespace Lui.Forms
{
        public partial class DetailBox
        {
                #region Código generado por el Diseñador de Windows Forms

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.TextBox1 = new System.Windows.Forms.TextBox();
                        this.MiContextMenu = new System.Windows.Forms.ContextMenu();
                        this.MenuItemBuscadorRapido = new System.Windows.Forms.MenuItem();
                        this.MenuItem2 = new System.Windows.Forms.MenuItem();
                        this.MenuItemCopiarCodigo = new System.Windows.Forms.MenuItem();
                        this.MenuItemCopiarNombre = new System.Windows.Forms.MenuItem();
                        this.MenuItem3 = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegar = new System.Windows.Forms.MenuItem();
                        this.MenuItem5 = new System.Windows.Forms.MenuItem();
                        this.MenuItemEditar = new System.Windows.Forms.MenuItem();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaFreeText = new System.Windows.Forms.TextBox();
                        this.SuspendLayout();
                        // 
                        // TextBox1
                        // 
                        this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                        this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.TextBox1.ContextMenu = this.MiContextMenu;
                        this.TextBox1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.TextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                        this.TextBox1.Location = new System.Drawing.Point(4, 4);
                        this.TextBox1.MaxLength = 32;
                        this.TextBox1.Multiline = false;
                        this.TextBox1.Name = "TextBox1";
                        this.TextBox1.Size = new System.Drawing.Size(51, 21);
                        this.TextBox1.TabIndex = 0;
                        this.TextBox1.LostFocus += new System.EventHandler(this.TextBox1_LostFocus);
                        this.TextBox1.DoubleClick += new System.EventHandler(this.TextBox1_DoubleClick);
                        this.TextBox1.GotFocus += new System.EventHandler(this.TextBox1_GotFocus);
                        this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
                        this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
                        this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
                        // 
                        // MiContextMenu
                        // 
                        this.MiContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemBuscadorRapido,
            this.MenuItem2,
            this.MenuItemCopiarCodigo,
            this.MenuItemCopiarNombre,
            this.MenuItem3,
            this.MenuItemPegar,
            this.MenuItem5,
            this.MenuItemEditar});
                        this.MiContextMenu.Popup += new System.EventHandler(this.ContextMenu_Popup);
                        // 
                        // MenuItemBuscadorRapido
                        // 
                        this.MenuItemBuscadorRapido.DefaultItem = true;
                        this.MenuItemBuscadorRapido.Index = 0;
                        this.MenuItemBuscadorRapido.Text = "Seleccionar de una Lista";
                        this.MenuItemBuscadorRapido.Click += new System.EventHandler(this.MenuItemBuscadorRapido_Click);
                        // 
                        // MenuItem2
                        // 
                        this.MenuItem2.Index = 1;
                        this.MenuItem2.Text = "-";
                        // 
                        // MenuItemCopiarCodigo
                        // 
                        this.MenuItemCopiarCodigo.Index = 2;
                        this.MenuItemCopiarCodigo.Text = "Copiar el Código";
                        this.MenuItemCopiarCodigo.Click += new System.EventHandler(this.MenuItemCopiarCodigo_Click);
                        // 
                        // MenuItemCopiarNombre
                        // 
                        this.MenuItemCopiarNombre.Index = 3;
                        this.MenuItemCopiarNombre.Text = "Copiar el Nombre";
                        this.MenuItemCopiarNombre.Click += new System.EventHandler(this.MenuItemCopiarNombre_Click);
                        // 
                        // MenuItem3
                        // 
                        this.MenuItem3.Index = 4;
                        this.MenuItem3.Text = "-";
                        // 
                        // MenuItemPegar
                        // 
                        this.MenuItemPegar.Index = 5;
                        this.MenuItemPegar.Text = "Pegar";
                        this.MenuItemPegar.Click += new System.EventHandler(this.MenuItemPegar_Click);
                        // 
                        // MenuItem5
                        // 
                        this.MenuItem5.Index = 6;
                        this.MenuItem5.Text = "-";
                        // 
                        // MenuItemEditar
                        // 
                        this.MenuItemEditar.Index = 7;
                        this.MenuItemEditar.Text = "Editar";
                        this.MenuItemEditar.Click += new System.EventHandler(this.MenuItemEditar_Click);
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                        this.Label1.ContextMenu = this.MiContextMenu;
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Label1.Location = new System.Drawing.Point(58, 4);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(280, 21);
                        this.Label1.TabIndex = 50;
                        this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
                        this.Label1.Click += new System.EventHandler(this.Label1_Click);
                        // 
                        // txtFreeText
                        // 
                        this.EntradaFreeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFreeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                        this.EntradaFreeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.EntradaFreeText.ContextMenu = this.MiContextMenu;
                        this.EntradaFreeText.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFreeText.Location = new System.Drawing.Point(58, 4);
                        this.EntradaFreeText.MaxLength = 200;
                        this.EntradaFreeText.Name = "txtFreeText";
                        this.EntradaFreeText.Size = new System.Drawing.Size(280, 16);
                        this.EntradaFreeText.TabIndex = 1;
                        this.EntradaFreeText.Visible = false;
                        this.EntradaFreeText.WordWrap = false;
                        this.EntradaFreeText.LostFocus += new System.EventHandler(this.txtFreeText_LostFocus);
                        this.EntradaFreeText.GotFocus += new System.EventHandler(this.txtFreeText_GotFocus);
                        this.EntradaFreeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFreeText_KeyDown);
                        // 
                        // DetailBox
                        // 
                        this.Controls.Add(this.TextBox1);
                        this.Controls.Add(this.EntradaFreeText);
                        this.Controls.Add(this.Label1);
                        this.Name = "DetailBox";
                        this.Size = new System.Drawing.Size(343, 29);
                        this.Enter += new System.EventHandler(this.DetailBox_Enter);
                        this.FontChanged += new System.EventHandler(this.DetailBox_FontChanged);
                        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetailBox_KeyPress);
                        this.ForeColorChanged += new System.EventHandler(this.DetailBox_ForeColorChanged);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                protected System.Windows.Forms.TextBox TextBox1;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.TextBox EntradaFreeText;
                internal System.Windows.Forms.MenuItem MenuItemCopiarCodigo;
                internal System.Windows.Forms.MenuItem MenuItemCopiarNombre;
                internal System.Windows.Forms.MenuItem MenuItem3;
                internal System.Windows.Forms.MenuItem MenuItemPegar;
                internal System.Windows.Forms.MenuItem MenuItem5;
                internal System.Windows.Forms.MenuItem MenuItemEditar;
                internal System.Windows.Forms.MenuItem MenuItemBuscadorRapido;
                internal System.Windows.Forms.MenuItem MenuItem2;
                internal System.Windows.Forms.ContextMenu MiContextMenu;
        }
}
