#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lcc.Entrada
{
        public partial class CodigoDetalle
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
                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.EntradaCodigo = new System.Windows.Forms.TextBox();
                        this.MiContextMenu = new System.Windows.Forms.ContextMenu();
                        this.MenuItemBuscadorRapido = new System.Windows.Forms.MenuItem();
                        this.MenuItem2 = new System.Windows.Forms.MenuItem();
                        this.MenuItemCopiarCodigo = new System.Windows.Forms.MenuItem();
                        this.MenuItemCopiarNombre = new System.Windows.Forms.MenuItem();
                        this.MenuItem3 = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegar = new System.Windows.Forms.MenuItem();
                        this.MenuItem5 = new System.Windows.Forms.MenuItem();
                        this.MenuItemEditar = new System.Windows.Forms.MenuItem();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaFreeText = new System.Windows.Forms.TextBox();
                        this.TimerActualizar = new System.Windows.Forms.Timer(this.components);
                        this.SuspendLayout();
                        // 
                        // EntradaCodigo
                        // 
                        this.EntradaCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.EntradaCodigo.ContextMenu = this.MiContextMenu;
                        this.EntradaCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                        this.EntradaCodigo.Location = new System.Drawing.Point(4, 4);
                        this.EntradaCodigo.MaxLength = 32;
                        this.EntradaCodigo.Name = "EntradaCodigo";
                        this.EntradaCodigo.Size = new System.Drawing.Size(52, 16);
                        this.EntradaCodigo.TabIndex = 0;
                        this.EntradaCodigo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
                        this.EntradaCodigo.DoubleClick += new System.EventHandler(this.TextBox1_DoubleClick);
                        this.EntradaCodigo.GotFocus += new System.EventHandler(this.TextBox1_GotFocus);
                        this.EntradaCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
                        this.EntradaCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
                        this.EntradaCodigo.LostFocus += new System.EventHandler(this.TextBox1_LostFocus);
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
                        this.Label1.AutoEllipsis = true;
                        this.Label1.ContextMenu = this.MiContextMenu;
                        this.Label1.Location = new System.Drawing.Point(60, 4);
                        this.Label1.Margin = new System.Windows.Forms.Padding(3);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(466, 16);
                        this.Label1.TabIndex = 50;
                        this.Label1.UseMnemonic = false;
                        this.Label1.Click += new System.EventHandler(this.Label1_Click);
                        this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
                        // 
                        // EntradaFreeText
                        // 
                        this.EntradaFreeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFreeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.EntradaFreeText.ContextMenu = this.MiContextMenu;
                        this.EntradaFreeText.Location = new System.Drawing.Point(60, 4);
                        this.EntradaFreeText.MaxLength = 200;
                        this.EntradaFreeText.Name = "EntradaFreeText";
                        this.EntradaFreeText.Size = new System.Drawing.Size(466, 16);
                        this.EntradaFreeText.TabIndex = 1;
                        this.EntradaFreeText.Visible = false;
                        this.EntradaFreeText.WordWrap = false;
                        this.EntradaFreeText.GotFocus += new System.EventHandler(this.EntradaFreeText_GotFocus);
                        this.EntradaFreeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaFreeText_KeyDown);
                        this.EntradaFreeText.LostFocus += new System.EventHandler(this.EntradaFreeText_LostFocus);
                        // 
                        // TimerActualizar
                        // 
                        this.TimerActualizar.Interval = 200;
                        this.TimerActualizar.Tick += new System.EventHandler(this.TimerActualizar_Tick);
                        // 
                        // CodigoDetalle
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.Controls.Add(this.EntradaCodigo);
                        this.Controls.Add(this.EntradaFreeText);
                        this.Controls.Add(this.Label1);
                        this.Name = "CodigoDetalle";
                        this.Size = new System.Drawing.Size(530, 24);
                        this.Enter += new System.EventHandler(this.DetailBox_Enter);
                        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetailBox_KeyPress);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaFreeText, 0);
                        this.Controls.SetChildIndex(this.EntradaCodigo, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                protected System.Windows.Forms.TextBox EntradaCodigo;
                internal Lui.Forms.Label Label1;
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
                private System.Windows.Forms.Timer TimerActualizar;
        }
}
