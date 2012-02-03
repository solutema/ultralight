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
        public partial class MasInfo : Lui.Forms.ChildDialogForm
        {
                private Lbl.Articulos.Articulo m_Articulo;

                public MasInfo()
                {
                        InitializeComponent();
                }

                public Lbl.Articulos.Articulo Articulo
                {
                        get
                        {
                                return m_Articulo;
                        }
                        set
                        {
                                m_Articulo = value;

                                if (m_Articulo != null) {
                                        if (m_Articulo.FechaAlta != null)
                                                EntradaFechaCreado.Text = m_Articulo.FechaAlta.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern);
                                        else
                                                EntradaFechaCreado.Text = "";
                                        if (m_Articulo.FechaPrecio != null)
                                                EntradaFechaPrecio.Text = m_Articulo.FechaPrecio.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern);
                                        else
                                                EntradaFechaPrecio.Text = "";
                                        decimal PrecioUltComp = this.Connection.FieldDecimal("SELECT comprob_detalle.precio FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.compra=1 AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND id_articulo=" + m_Articulo.Id.ToString() + " GROUP BY comprob.id_comprob ORDER BY comprob_detalle.id_comprob_detalle DESC");
                                        EntradaCostoUltimaCompra.Text = Lfx.Types.Formatting.FormatCurrency(PrecioUltComp, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto);

                                        // Podra hacer esto con una subconsulta, pero la versión de MySql que estamos utilizando
                                        // no permite la cláusula LIMIT dentro de una subconsulta IN ()
                                        PrecioUltComp = 0;
                                        System.Data.DataTable UltimasCompras = this.Connection.Select("SELECT comprob_detalle.precio, comprob.id_comprob FROM comprob, comprob_detalle WHERE comprob.id_comprob=comprob_detalle.id_comprob AND comprob.compra=1 AND comprob.tipo_fac IN ('R', 'FA', 'FB', 'FC', 'FE', 'FM') AND comprob.compra=1 AND comprob_detalle.id_articulo=" + m_Articulo.Id.ToString() + " ORDER BY comprob.fecha DESC LIMIT 5");

                                        if (UltimasCompras.Rows.Count > 0) {
                                                foreach (System.Data.DataRow Compra in UltimasCompras.Rows) {
                                                        PrecioUltComp += System.Convert.ToDecimal(Compra["precio"]);
                                                }

                                                PrecioUltComp = PrecioUltComp / UltimasCompras.Rows.Count;
                                                EntradaCostoUltimas5Compras.Text = Lfx.Types.Formatting.FormatCurrency(PrecioUltComp, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto);
                                        }

                                        System.Data.DataTable Precios = this.Connection.Select("SELECT fecha, costo, pvp FROM articulos_precios WHERE id_articulo=" + m_Articulo.Id.ToString() + " ORDER BY fecha DESC LIMIT 100");
                                        lvItems.Items.Clear();

                                        foreach (System.Data.DataRow Precio in Precios.Rows) {
                                                ListViewItem Itm = lvItems.Items.Add(Lfx.Types.Formatting.FormatDate(Precio["fecha"]));
                                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDecimal(Precio["costo"]), Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesCosto)));
                                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDecimal(Precio["pvp"]), Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales)));
                                        }
                                }
                        }
                }
        }
}