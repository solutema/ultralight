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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class EditHistory : Lui.Forms.ChildDialogForm
        {
                public string Tabla;
                public int ItemId;

                public EditHistory()
                {
                        InitializeComponent();

                        this.OkButton.Visible = false;
                }

                public void Mostrar(Lbl.ElementoDeDatos elemento)
                {
                        this.Text = "Historial de " + elemento.ToString();
                        this.Mostrar(elemento.TablaDatos, elemento.Id);
                }

                public void Mostrar(string tabla, int itemId) {
                        this.Tabla = tabla;
                        this.ItemId = itemId;
                        
                        System.Data.DataTable LogsTable = this.DataView.DataBase.Select("SELECT * FROM sys_log WHERE tabla='" + this.Tabla + "' AND item_id=" + this.ItemId.ToString() + " ORDER BY fecha DESC");
                        Lbl.ColeccionGenerica<Lbl.Sys.Log.Entry> Logs = new Lbl.ColeccionGenerica<Lbl.Sys.Log.Entry>(this.DataView, LogsTable);
                        for (int i = 0; i < Logs.Count; i++) {
                                Lbl.Sys.Log.Entry Log = Logs[i];
                                Lfx.Data.Row Usuario = this.DataView.Tables["personas"].FastRows[Log.IdUsuario];
                                ListViewItem Itm = ListaHistoral.Items.Add(Log.Fecha.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                                Itm.SubItems.Add(Usuario.Fields["nombre_visible"].Value.ToString());
                                Itm.SubItems.Add(Log.Comando.ToString());
                                Itm.SubItems.Add(Log.ToString());
                        }
                }
        }
}