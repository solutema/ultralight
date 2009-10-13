// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos.Categorias
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                internal string m_Stock = "*";

                public Inicio()
                        : base()
                {
                        InitializeComponent();

                        DataTableName = "cat_articulos";
                        KeyField = new Lfx.Data.FormField("cat_articulos.id_cat_articulo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        Joins.Add(new Lfx.Data.Join("articulos", "cat_articulos.id_cat_articulo"));
                        GroupBy = KeyField;
                        OrderBy = "cat_articulos.nombre";
                        FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("cat_articulos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("cat_articulos.stock_minimo", "Stock Mín", Lfx.Data.InputFieldTypes.Numeric, 96),
				new Lfx.Data.FormField("cat_articulos.cache_stock_actual", "Stock Act", Lfx.Data.InputFieldTypes.Numeric, 96)
			};
                        BotonFiltrar.Visible = true;
                }

                public override Lfx.Types.OperationResult OnCreate()
                {
                        this.Workspace.RunTime.Execute("CREAR ARTICULO_CATEG");
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult OnEdit(int Codigo)
                {
                        this.Workspace.RunTime.Execute("EDITAR ARTICULO_CATEG " + Codigo.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        return new Lfx.Types.SuccessOperationResult();
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
					CurrentFilter = "cat_articulos.stock_minimo>0 AND cat_articulos.stock_minimo>(SELECT SUM(articulos.stock_actual) FROM articulos WHERE cat_articulos.id_cat_articulo=id_cat_articulo)";
                                        break;

                                default:
					CurrentFilter = null;
                                        break;
                        }

                        this.RefreshList();
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void Fill(Lfx.Data.SqlSelectBuilder sqlCommand)
                {
                        this.DataView.DataBase.Execute("UPDATE cat_articulos SET cache_stock_actual=(SELECT SUM(stock_actual) FROM articulos WHERE articulos.id_cat_articulo=cat_articulos.id_cat_articulo)");
                        base.Fill(sqlCommand);

                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items) {
                                if (Lfx.Types.Parsing.ParseStock(itm.SubItems[3].Text) < Lfx.Types.Parsing.ParseStock(itm.SubItems[2].Text))
                                        itm.ForeColor = System.Drawing.Color.Red;
                        }
                }
        }
}