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
                internal double m_ValorizacionCostoTotal = 0;

                public Inicio()
                {
                        this.ElementoTipo = typeof(Lbl.Articulos.Categoria);

                        this.NombreTabla = "articulos_categorias";
                        this.KeyField = new Lfx.Data.FormField("articulos_categorias.id_categoria", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.Joins.Add(new qGen.Join("articulos", "articulos_categorias.id_categoria"));
                        this.GroupBy = KeyField;
                        this.OrderBy = "articulos_categorias.nombre";
                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("articulos_categorias.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("articulos_categorias.stock_minimo", "Stock Mín", Lfx.Data.InputFieldTypes.Numeric, 96),
				new Lfx.Data.FormField("articulos_categorias.cache_stock_actual", "Stock Act", Lfx.Data.InputFieldTypes.Numeric, 96),
                                new Lfx.Data.FormField("articulos_categorias.cache_costo", "Valorización", Lfx.Data.InputFieldTypes.Numeric, 96),
                                new Lfx.Data.FormField("0", "Valorización %", Lfx.Data.InputFieldTypes.Numeric, 96)
			};
                        
                        this.HabilitarFiltrar = true;
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        switch (m_Stock)
                        {
                                case "*":
                                        m_Stock = "f";
                                        break;

                                default:
                                        m_Stock = "*";
                                        break;
                        }

                        switch (m_Stock)
                        {
                                case "f":
                                        this.CustomFilters.Clear();
					CustomFilters.AddWithValue("articulos_categorias.stock_minimo>0 AND articulos_categorias.stock_minimo>(SELECT SUM(articulos.stock_actual) FROM articulos WHERE articulos_categorias.id_categoria=id_categoria)");
                                        break;

                                default:
					CustomFilters.Clear();
                                        break;
                        }

                        this.RefreshList();
                        return new Lfx.Types.SuccessOperationResult();
                }

                protected override void OnBeginRefreshList()
                {
                        this.Connection.BeginTransaction();
                        this.Connection.Execute("UPDATE articulos_categorias SET cache_stock_actual=(SELECT SUM(stock_actual) FROM articulos WHERE articulos.id_categoria=articulos_categorias.id_categoria), cache_costo=(SELECT SUM(stock_actual*costo) FROM articulos WHERE articulos.id_categoria=articulos_categorias.id_categoria)");
                        this.Connection.Commit();
                        m_ValorizacionCostoTotal = this.Connection.FieldDouble("SELECT SUM(cache_costo) FROM articulos_categorias");
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        double ValPct;
                        if (m_ValorizacionCostoTotal <= 0)
                                ValPct = 0;
                        else
                                ValPct = System.Convert.ToDouble(row["cache_costo"]) / m_ValorizacionCostoTotal * 100;
                        item.SubItems["0"].Text = Lfx.Types.Formatting.FormatNumber(ValPct, 2) + "%";

                        if (row.Fields["cache_stock_actual"].ValueDouble < row.Fields["stock_minimo"].ValueDouble)
                                item.ForeColor = System.Drawing.Color.Red;
                }
        }
}