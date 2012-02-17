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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Log
{
        public partial class Editar : Lui.Forms.ChildDialogForm
        {
                public string Tabla;
                public int ItemId;

                public Editar()
                {
                        InitializeComponent();

                        this.OkButton.Visible = false;
                }

                public void Mostrar(Lbl.ElementoDeDatos elemento)
                {
                        this.Text = "Historial de " + elemento.ToString();
                        this.Mostrar(elemento.TablaDatos, elemento.Id);
                }

                public void Mostrar(string tabla, int itemId)
                {
                        this.Tabla = tabla;
                        this.ItemId = itemId;
                }

                private void TimerRefrescar_Tick(object sender, EventArgs e)
                {
                        TimerRefrescar.Stop();

                        ListaHistoral.SuspendLayout();
                        ListaHistoral.BeginUpdate();

                        System.Data.DataTable LogsTable = this.Connection.Select("SELECT * FROM sys_log WHERE tabla='" + this.Tabla + "' AND item_id=" + this.ItemId.ToString() + " ORDER BY fecha DESC");
                        Lbl.ColeccionGenerica<Lbl.Sys.Log.Entrada> Logs = new Lbl.ColeccionGenerica<Lbl.Sys.Log.Entrada>(this.Connection, LogsTable);
                        for (int i = 0; i < Logs.Count; i++) {
                                Lbl.Sys.Log.Entrada Log = Logs[i];
                                Lfx.Data.Row Usuario = this.Connection.Tables["personas"].FastRows[Log.IdUsuario];
                                ListViewItem Itm = ListaHistoral.Items.Add(Lfx.Types.Formatting.FormatSmartDateAndTime(Log.Fecha));
                                if (Usuario == null)
                                        Itm.SubItems.Add("");
                                else
                                        Itm.SubItems.Add(Usuario.Fields["nombre_visible"].Value.ToString());
                                switch (Log.Comando) {
                                        case Lbl.Sys.Log.Acciones.Save:
                                                Itm.SubItems.Add("Guardar");
                                                break;
                                        case Lbl.Sys.Log.Acciones.Print:
                                                Itm.SubItems.Add("Imprimir");
                                                break;
                                        case Lbl.Sys.Log.Acciones.Delete:
                                                Itm.SubItems.Add("Eliminar");
                                                break;
                                        case Lbl.Sys.Log.Acciones.DeleteAndRevert:
                                                Itm.SubItems.Add("Eliminar y revertir");
                                                break;
                                        case Lbl.Sys.Log.Acciones.LogOn:
                                                Itm.SubItems.Add("Ingreso al sistema");
                                                break;
                                        default:
                                                Itm.SubItems.Add(Log.Comando.ToString());
                                                break;
                                }

                                Itm.SubItems.Add(Log.Explain(false));
                                Itm.Tag = Log;

                                if (ListaHistoral.Items.Count == 200) {
                                        // Muestro un parcial
                                        ListaHistoral.EndUpdate();
                                        System.Windows.Forms.Application.DoEvents();
                                        ListaHistoral.BeginUpdate();
                                }
                        }

                        ColDatos.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

                        ListaHistoral.EndUpdate();
                        ListaHistoral.ResumeLayout(true);
                }

                private void ListaHistoral_MouseDoubleClick(object sender, MouseEventArgs e)
                {
                        MostrarSeleccionado();
                }

                private void ListaHistoral_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.Control == false && e.Shift == false && e.Alt == false) {
                                switch(e.KeyCode) {
                                        case Keys.Return:
                                                e.Handled = true;
                                                MostrarSeleccionado();
                                                break;
                                }
                        }
                }


                private void MostrarSeleccionado()
                {
                        if (ListaHistoral.SelectedItems.Count == 0)
                                return;

                        Lbl.Sys.Log.Entrada Log = ListaHistoral.SelectedItems[0].Tag as Lbl.Sys.Log.Entrada;
                        if (Log == null)
                                return;

                        Lui.Forms.MessageBox.Show(Log.Explain(true), "Acción");
                }
        }
}
