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

namespace Lui.Forms
{
        public partial class TextBox
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

                #region	Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.MiContextMenu = new System.Windows.Forms.ContextMenu();
                        this.MenuItemCopiar = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegar = new System.Windows.Forms.MenuItem();
                        this.MenuItem4 = new System.Windows.Forms.MenuItem();
                        this.MenuItemCalculadora = new System.Windows.Forms.MenuItem();
                        this.MenuItemHoy = new System.Windows.Forms.MenuItem();
                        this.MenuItemAyer = new System.Windows.Forms.MenuItem();
                        this.MenuItemCalendario = new System.Windows.Forms.MenuItem();
                        this.MenuItemEditor = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegadoRapido = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegadoRapidoAgregar = new System.Windows.Forms.MenuItem();
                        this.EtiquetaPrefijo = new System.Windows.Forms.Label();
                        this.EtiquetaSufijo = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // TextBox1
                        // 
                        this.TextBox1.BackColor = System.Drawing.Color.White;
                        this.TextBox1.ForeColor = System.Drawing.Color.Black;
                        this.TextBox1.Size = new System.Drawing.Size(376, 18);
                        this.TextBox1.FontChanged += new System.EventHandler(this.TextBox1_FontChanged);
                        // 
                        // MiContextMenu
                        // 
                        this.MiContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemCopiar,
            this.MenuItemPegar,
            this.MenuItemPegadoRapido,
            this.MenuItem4,
            this.MenuItemEditor,
            this.MenuItemCalculadora,
            this.MenuItemHoy,
            this.MenuItemAyer,
            this.MenuItemCalendario});
                        this.MiContextMenu.Popup += new System.EventHandler(this.MiContextMenu_Popup);
                        // 
                        // MenuItemCopiar
                        // 
                        this.MenuItemCopiar.Index = 0;
                        this.MenuItemCopiar.Text = "Copiar";
                        this.MenuItemCopiar.Click += new System.EventHandler(this.MenuItemCopiar_Click);
                        // 
                        // MenuItemPegar
                        // 
                        this.MenuItemPegar.Index = 1;
                        this.MenuItemPegar.Text = "Pegar";
                        this.MenuItemPegar.Click += new System.EventHandler(this.MenuItemPegar_Click);
                        // 
                        // MenuItem4
                        // 
                        this.MenuItem4.Index = 3;
                        this.MenuItem4.Text = "-";
                        // 
                        // MenuItemCalculadora
                        // 
                        this.MenuItemCalculadora.Index = 5;
                        this.MenuItemCalculadora.Text = "Calculadora";
                        this.MenuItemCalculadora.Click += new System.EventHandler(this.MenuItemCalculadora_Click);
                        // 
                        // MenuItemHoy
                        // 
                        this.MenuItemHoy.Index = 6;
                        this.MenuItemHoy.Text = "Hoy";
                        this.MenuItemHoy.Click += new System.EventHandler(this.MenuItemHoy_Click);
                        // 
                        // MenuItemAyer
                        // 
                        this.MenuItemAyer.Index = 7;
                        this.MenuItemAyer.Text = "Ayer";
                        this.MenuItemAyer.Click += new System.EventHandler(this.MenuItemAyer_Click);
                        // 
                        // MenuItemCalendario
                        // 
                        this.MenuItemCalendario.Index = 8;
                        this.MenuItemCalendario.Text = "Calendario";
                        // 
                        // MenuItemEditor
                        // 
                        this.MenuItemEditor.Index = 4;
                        this.MenuItemEditor.Text = "Editor Extendido";
                        this.MenuItemEditor.Click += new System.EventHandler(this.MenuItemEditor_Click);
                        // 
                        // MenuItemPegadoRapido
                        // 
                        this.MenuItemPegadoRapido.Index = 2;
                        this.MenuItemPegadoRapido.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemPegadoRapidoAgregar});
                        this.MenuItemPegadoRapido.Text = "Pegado Rápido";
                        this.MenuItemPegadoRapido.Popup += new System.EventHandler(this.MenuItemPegadoRapido_Popup);
                        // 
                        // MenuItemPegadoRapidoAgregar
                        // 
                        this.MenuItemPegadoRapidoAgregar.Index = 0;
                        this.MenuItemPegadoRapidoAgregar.Text = "&Agregar al menú de Pegado Rápido";
                        this.MenuItemPegadoRapidoAgregar.Click += new System.EventHandler(this.MenuItemPegadoRapidoAgregar_Click);
                        // 
                        // EtiquetaPrefijo
                        // 
                        this.EtiquetaPrefijo.AutoSize = true;
                        this.EtiquetaPrefijo.Location = new System.Drawing.Point(3, 3);
                        this.EtiquetaPrefijo.Name = "EtiquetaPrefijo";
                        this.EtiquetaPrefijo.Padding = new System.Windows.Forms.Padding(0);
                        this.EtiquetaPrefijo.Size = new System.Drawing.Size(0, 17);
                        this.EtiquetaPrefijo.TabIndex = 3;
                        this.EtiquetaPrefijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaPrefijo.UseMnemonic = false;
                        this.EtiquetaPrefijo.Visible = false;
                        // 
                        // EtiquetaSufijo
                        // 
                        this.EtiquetaSufijo.AutoSize = true;
                        this.EtiquetaSufijo.Location = new System.Drawing.Point(373, 3);
                        this.EtiquetaSufijo.Name = "EtiquetaSufijo";
                        this.EtiquetaPrefijo.Padding = new System.Windows.Forms.Padding(0);
                        this.EtiquetaSufijo.Size = new System.Drawing.Size(0, 17);
                        this.EtiquetaSufijo.TabIndex = 4;
                        this.EtiquetaSufijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaSufijo.UseMnemonic = false;
                        this.EtiquetaSufijo.Visible = false;
                        // 
                        // TextBox
                        // 
                        this.Controls.Add(this.EtiquetaPrefijo);
                        this.Controls.Add(this.EtiquetaSufijo);
                        this.Name = "TextBox";
                        this.Size = new System.Drawing.Size(384, 24);
                        this.Controls.SetChildIndex(this.EtiquetaSufijo, 0);
                        this.Controls.SetChildIndex(this.EtiquetaPrefijo, 0);
                        this.Controls.SetChildIndex(this.TextBox1, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal System.Windows.Forms.Label EtiquetaPrefijo;
                internal System.Windows.Forms.Label EtiquetaSufijo;
                internal System.Windows.Forms.MenuItem MenuItem4;
                internal System.Windows.Forms.MenuItem MenuItemCopiar;
                internal System.Windows.Forms.MenuItem MenuItemPegar;
                internal System.Windows.Forms.MenuItem MenuItemCalculadora;
                internal System.Windows.Forms.MenuItem MenuItemCalendario;
                internal System.Windows.Forms.MenuItem MenuItemEditor;
                internal System.Windows.Forms.ContextMenu MiContextMenu;
                internal System.Windows.Forms.MenuItem MenuItemHoy;
                internal System.Windows.Forms.MenuItem MenuItemAyer;
        }
}
