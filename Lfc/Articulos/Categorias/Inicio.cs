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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos.Categorias
{
        public partial class Inicio : Lfc.FormularioListado
        {
                internal string m_Stock = "*";
                internal decimal m_ValorizacionCostoTotal = 0;

                public Inicio()
                {
                        this.Definicion = new Lfx.Data.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Articulos.Categoria),

                                TableName = "articulos_categorias",
                                KeyColumnName = new Lfx.Data.FormField("articulos_categorias.id_categoria", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                GroupBy = new Lfx.Data.FormField("articulos_categorias.id_categoria", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Joins = new qGen.JoinCollection() { new qGen.Join("articulos", "articulos_categorias.id_categoria") },
                                OrderBy = "articulos_categorias.nombre",
                                Columns = new Lfx.Data.FormFieldCollection()
			        {
				        new Lfx.Data.FormField("articulos_categorias.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
				        new Lfx.Data.FormField("articulos_categorias.stock_minimo", "Stock Mín", Lfx.Data.InputFieldTypes.Numeric, 96),
				        new Lfx.Data.FormField("articulos_categorias.cache_stock_actual", "Stock Act", Lfx.Data.InputFieldTypes.Numeric, 96),
                                        new Lfx.Data.FormField("articulos_categorias.cache_costo", "Valorización", Lfx.Data.InputFieldTypes.Numeric, 96),
                                        new Lfx.Data.FormField("0", "Valorización %", Lfx.Data.InputFieldTypes.Numeric, 96)
			        },
                                Filters = new List<Lfx.Data.IFilter>()
                                {
                                        new Lfx.Data.SetFilter("Stock Actual", "articulos_categorias.cache_stock_actual", new string[] { "Todos|*", "Con faltantes|f" }, "*")
                                }
                        };
                        
                        this.HabilitarFiltrar = true;
                }


                public override void FiltersChanged()
                {
                        this.CustomFilters.Clear();

                        if (((Lfx.Data.SetFilter)(this.Definicion.Filters[0])).CurrentValue == "f")
                                CustomFilters.AddWithValue("articulos_categorias.stock_minimo>0 AND articulos_categorias.stock_minimo>(SELECT SUM(articulos.stock_actual) FROM articulos WHERE articulos_categorias.id_categoria=id_categoria)");

                        base.FiltersChanged();
                }


                protected override void OnBeginRefreshList()
                {
                        IDbTransaction Trans = this.Connection.BeginTransaction();
                        this.Connection.Execute("UPDATE articulos_categorias SET cache_stock_actual=(SELECT SUM(stock_actual) FROM articulos WHERE articulos.id_categoria=articulos_categorias.id_categoria), cache_costo=(SELECT SUM(stock_actual*costo) FROM articulos WHERE articulos.id_categoria=articulos_categorias.id_categoria)");
                        Trans.Commit();
                        m_ValorizacionCostoTotal = this.Connection.FieldDecimal("SELECT SUM(cache_costo) FROM articulos_categorias");
                }


                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        decimal ValPct;
                        if (m_ValorizacionCostoTotal <= 0)
                                ValPct = 0;
                        else
                                ValPct = System.Convert.ToDecimal(row["cache_costo"]) / m_ValorizacionCostoTotal * 100;
                        item.SubItems["0"].Text = Lfx.Types.Formatting.FormatNumber(ValPct, 2) + "%";

                        if (row.Fields["cache_stock_actual"].ValueDouble < row.Fields["stock_minimo"].ValueDouble)
                                item.ForeColor = System.Drawing.Color.Red;
                }
        }
}