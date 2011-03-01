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
                        this.MenuItem2 = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegar = new System.Windows.Forms.MenuItem();
                        this.MenuItem4 = new System.Windows.Forms.MenuItem();
                        this.MenuItemCalculadora = new System.Windows.Forms.MenuItem();
                        this.MenuItemHoy = new System.Windows.Forms.MenuItem();
                        this.MenuItemAyer = new System.Windows.Forms.MenuItem();
                        this.MenuItemCalendario = new System.Windows.Forms.MenuItem();
                        this.MenuItemEditor = new System.Windows.Forms.MenuItem();
                        this.menuItem1 = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegadoRapido = new System.Windows.Forms.MenuItem();
                        this.MenuItemPegadoRapidoAgregar = new System.Windows.Forms.MenuItem();
                        this.EtiquetaPrefijo = new System.Windows.Forms.Label();
                        this.EtiquetaSufijo = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // MiContextMenu
                        // 
                        this.MiContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItemCopiar,
            this.MenuItem2,
            this.MenuItemPegar,
            this.MenuItem4,
            this.MenuItemCalculadora,
            this.MenuItemHoy,
            this.MenuItemAyer,
            this.MenuItemCalendario,
            this.MenuItemEditor,
            this.menuItem1,
            this.MenuItemPegadoRapido});
                        this.MiContextMenu.Popup += new System.EventHandler(this.MiContextMenu_Popup);
                        // 
                        // MenuItemCopiar
                        // 
                        this.MenuItemCopiar.Index = 0;
                        this.MenuItemCopiar.Text = "Copiar";
                        this.MenuItemCopiar.Click += new System.EventHandler(this.MenuItemCopiar_Click);
                        // 
                        // MenuItem2
                        // 
                        this.MenuItem2.Index = 1;
                        this.MenuItem2.Text = "-";
                        // 
                        // MenuItemPegar
                        // 
                        this.MenuItemPegar.Index = 2;
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
                        this.MenuItemCalculadora.Index = 4;
                        this.MenuItemCalculadora.Text = "Calculadora";
                        this.MenuItemCalculadora.Click += new System.EventHandler(this.MenuItemCalculadora_Click);
                        // 
                        // MenuItemHoy
                        // 
                        this.MenuItemHoy.Index = 5;
                        this.MenuItemHoy.Text = "Hoy";
                        this.MenuItemHoy.Click += new System.EventHandler(this.MenuItemHoy_Click);
                        // 
                        // MenuItemAyer
                        // 
                        this.MenuItemAyer.Index = 6;
                        this.MenuItemAyer.Text = "Ayer";
                        this.MenuItemAyer.Click += new System.EventHandler(this.MenuItemAyer_Click);
                        // 
                        // MenuItemCalendario
                        // 
                        this.MenuItemCalendario.Index = 7;
                        this.MenuItemCalendario.Text = "Calendario";
                        // 
                        // MenuItemEditor
                        // 
                        this.MenuItemEditor.Index = 8;
                        this.MenuItemEditor.Text = "Editor Extendido";
                        this.MenuItemEditor.Click += new System.EventHandler(this.MenuItemEditor_Click);
                        // 
                        // menuItem1
                        // 
                        this.menuItem1.Index = 9;
                        this.menuItem1.Text = "-";
                        // 
                        // MenuItemPegadoRapido
                        // 
                        this.MenuItemPegadoRapido.Index = 10;
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
                        // lblPrefijo
                        // 
                        this.EtiquetaPrefijo.AutoSize = true;
                        this.EtiquetaPrefijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                        this.EtiquetaPrefijo.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaPrefijo.Location = new System.Drawing.Point(4, 2);
                        this.EtiquetaPrefijo.Name = "lblPrefijo";
                        this.EtiquetaPrefijo.Size = new System.Drawing.Size(0, 13);
                        this.EtiquetaPrefijo.TabIndex = 3;
                        this.EtiquetaPrefijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaPrefijo.UseMnemonic = false;
                        this.EtiquetaPrefijo.Visible = false;
                        // 
                        // lblSufijo
                        // 
                        this.EtiquetaSufijo.AutoSize = true;
                        this.EtiquetaSufijo.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaSufijo.Location = new System.Drawing.Point(368, 4);
                        this.EtiquetaSufijo.Name = "lblSufijo";
                        this.EtiquetaSufijo.Size = new System.Drawing.Size(0, 13);
                        this.EtiquetaSufijo.TabIndex = 4;
                        this.EtiquetaSufijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaSufijo.UseMnemonic = false;
                        this.EtiquetaSufijo.Visible = false;
                        // 
                        // TextBox
                        // 
			this.FontChanged += new System.EventHandler(this.TextBox_FontChanged);
                        this.Controls.Add(this.EtiquetaPrefijo);
                        this.Controls.Add(this.EtiquetaSufijo);
                        this.Name = "TextBox";
                        this.Size = new System.Drawing.Size(384, 40);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal System.Windows.Forms.Label EtiquetaPrefijo;
                internal System.Windows.Forms.Label EtiquetaSufijo;
                internal System.Windows.Forms.MenuItem MenuItem2;
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
