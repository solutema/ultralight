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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos
{
        public partial class VerMovimientos : Lui.Forms.ChildDialogForm
        {
                private Lbl.ColeccionCodigoDetalle SituacionCache = new Lbl.ColeccionCodigoDetalle();

                public VerMovimientos()
                {
                        InitializeComponent();
                }

                public void Mostrar(Lbl.Articulos.Articulo articulo)
                {
                        Listado.BeginUpdate();
                        Listado.Items.Clear();

                        this.formHeader1.Text = "Movimientos de " + articulo.ToString();

                        System.Data.DataTable Detalles = this.Connection.Select("SELECT id_movim, id_articulo, desdesituacion, haciasituacion, cantidad, series, fecha, saldo, obs FROM articulos_movim WHERE id_articulo=" + articulo.Id.ToString() + " ORDER BY fecha");

                        ListViewItem itm = null;
                        foreach (System.Data.DataRow Detalle in Detalles.Rows) {
                                string DesdeSituacion = "Público";
                                string HaciaSituacion = "Público";

                                Detalle["desdesituacion"] = Lfx.Data.Connection.ConvertDBNullToZero(Detalle["desdesituacion"]);
                                Detalle["haciasituacion"] = Lfx.Data.Connection.ConvertDBNullToZero(Detalle["haciasituacion"]);

                                if (System.Convert.ToInt32(Detalle["desdesituacion"]) != 0) {
                                        if (SituacionCache.ContainsKey(System.Convert.ToInt32(Detalle["desdesituacion"])) == false)
                                                SituacionCache[System.Convert.ToInt32(Detalle["desdesituacion"])] = this.Connection.FieldString("SELECT nombre FROM articulos_situaciones WHERE id_situacion=" + Detalle["desdesituacion"].ToString());
                                        DesdeSituacion = SituacionCache[(int)Detalle["desdesituacion"]];
                                }

                                if (System.Convert.ToInt32(Detalle["haciasituacion"]) != 0) {
                                        if (SituacionCache.ContainsKey((int)Detalle["haciasituacion"]) == false)
                                                SituacionCache[(int)Detalle["haciasituacion"]] = this.Connection.FieldString("SELECT nombre FROM articulos_situaciones WHERE id_situacion=" + Detalle["haciasituacion"].ToString());
                                        HaciaSituacion = SituacionCache[(int)Detalle["haciasituacion"]];
                                }

                                itm = Listado.Items.Add(System.Convert.ToString(Detalle["id_movim"]));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDateAndTime(System.Convert.ToDateTime(Detalle["fecha"]))));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Detalle["cantidad"]), Lfx.Workspace.Master.CurrentConfig.Productos.DecimalesStock)));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Detalle["series"].ToString()));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, DesdeSituacion));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, HaciaSituacion));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Detalle["saldo"]), Lfx.Workspace.Master.CurrentConfig.Productos.DecimalesStock)));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Detalle["obs"])));
                        }
                        Listado.EndUpdate();
                        if (itm != null) {
                                itm.Selected = true;
                                itm.Focused = true;
                                itm.EnsureVisible();
                        }

                        ListadoPedidos.BeginUpdate();
                        ListadoPedidos.Items.Clear();
                        System.Data.DataTable Pedidos = this.Connection.Select(@"SELECT comprob.id_comprob, comprob.fecha, comprob.id_cliente, comprob.tipo_fac, comprob.numero, comprob_detalle.cantidad, comprob_detalle.precio, comprob.estado
				FROM comprob, comprob_detalle
				WHERE comprob.id_comprob=comprob_detalle.id_comprob
					AND comprob.compra=1
					AND comprob.tipo_fac='PD'
				    AND comprob.estado=50
					AND comprob_detalle.id_articulo=" + articulo.Id.ToString() + @"
				ORDER BY comprob.fecha");

                        itm = null;
                        foreach (System.Data.DataRow Pedido in Pedidos.Rows) {
                                itm = ListadoPedidos.Items.Add(System.Convert.ToString(Pedido["id_comprob"]));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, this.Connection.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Lfx.Data.Connection.ConvertDBNullToZero(Pedido["id_cliente"]).ToString())));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(Pedido["numero"])));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatDateAndTime(System.Convert.ToDateTime(Pedido["fecha"]))));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Pedido["cantidad"]), Lfx.Workspace.Master.CurrentConfig.Productos.DecimalesStock)));
                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Pedido["precio"]), Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto)));
                                switch (System.Convert.ToInt32(Pedido["estado"])) {
                                        case 50:
                                                itm.ForeColor = System.Drawing.Color.DarkOrange;
                                                break;
                                        case 100:
                                                itm.ForeColor = System.Drawing.Color.DarkGreen;
                                                break;
                                        case 200:
                                                itm.ForeColor = System.Drawing.Color.DarkRed;
                                                itm.Font = new Font(itm.Font, System.Drawing.FontStyle.Strikeout);
                                                break;
                                }
                        }
                        ListadoPedidos.EndUpdate();
                        if (itm != null) {
                                itm.Selected = true;
                                itm.Focused = true;
                                itm.EnsureVisible();
                        }
                }

                private void lvPedidos_DoubleClick(object sender, System.EventArgs e)
                {
                        if (ListadoPedidos.SelectedItems.Count > 0) {
                                ListViewItem Itm = ListadoPedidos.SelectedItems[0];
                                Lfx.Workspace.Master.RunTime.Execute("EDITAR PD " + Itm.Text);
                        }
                }

                private void FormArticulosMovimDetalles_Activated(object sender, System.EventArgs e)
                {
                        if (Listado.SelectedItems.Count > 0) {
                                Listado.SelectedItems[0].Selected = true;
                                Listado.SelectedItems[0].Focused = true;
                                Listado.SelectedItems[0].EnsureVisible();
                        }
                }
        }
}