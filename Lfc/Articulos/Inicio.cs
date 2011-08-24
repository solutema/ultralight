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

namespace Lfc.Articulos
{
        public partial class Inicio : Lfc.FormularioListado
        {
                protected internal decimal m_PvpDesde = 0, m_PvpHasta = 0;
                protected internal int m_Proveedor = 0, m_Marca = 0, m_Categoria = 0, m_Rubro = 0, m_Situacion = 0;
                public string m_Stock = "*";

                public Inicio()
                {
                        string Cod1 = "Código 1", Cod2 = "Código 2", Cod3 = "Código 3", Cod4 = "Código 4";
                        if (this.HasWorkspace) {
                                Lfx.Data.Row CodRow = this.Connection.Tables["articulos_codigos"].FastRows[1];
                                if (CodRow != null)
                                        Cod1 = CodRow["nombre"].ToString();
                                CodRow = this.Connection.Tables["articulos_codigos"].FastRows[2];
                                if (CodRow != null)
                                        Cod2 = CodRow["nombre"].ToString();
                                CodRow = this.Connection.Tables["articulos_codigos"].FastRows[3];
                                if (CodRow != null)
                                        Cod3 = CodRow["nombre"].ToString();
                                CodRow = this.Connection.Tables["articulos_codigos"].FastRows[4];
                                if (CodRow != null)
                                        Cod4 = CodRow["nombre"].ToString();

                                // Cargo la tabla en memoria
                                this.Connection.Tables["articulos_codigos"].PreLoad();
                        }

                        this.Definicion = new Lbl.Listados.Listado()
                        {
                                ElementoTipo = typeof(Lbl.Articulos.Articulo),

                                NombreTabla = "articulos",
                                KeyField = new Lfx.Data.FormField("articulos.id_articulo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80),
                                DetailColumnName = "nombre",
                                Joins = this.FixedJoins(),
                                OrderBy = "articulos.nombre",
                                FormFields = new Lfx.Data.FormFieldCollection()
                                {
				        new Lfx.Data.FormField("articulos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
                                        new Lfx.Data.FormField("articulos.costo", "Costo", Lfx.Data.InputFieldTypes.Currency, 96),
				        new Lfx.Data.FormField("articulos.pvp", "PVP", Lfx.Data.InputFieldTypes.Currency, 96),
				        new Lfx.Data.FormField("articulos.stock_actual", "Stock Act", Lfx.Data.InputFieldTypes.Numeric, 96),
				        new Lfx.Data.FormField("articulos.stock_minimo", "Stock Mín", Lfx.Data.InputFieldTypes.Numeric, 96),
				        new Lfx.Data.FormField("articulos.pedido", "Pedidos", Lfx.Data.InputFieldTypes.Numeric, 96),
				        new Lfx.Data.FormField("articulos.apedir", "A Pedir", Lfx.Data.InputFieldTypes.Numeric, 96),
				        new Lfx.Data.FormField("articulos.destacado", "Destacado", Lfx.Data.InputFieldTypes.Bool, 0),
				        new Lfx.Data.FormField("articulos.codigo1", Cod1, Lfx.Data.InputFieldTypes.Text, 120),
				        new Lfx.Data.FormField("articulos.codigo2", Cod2, Lfx.Data.InputFieldTypes.Text, 120),
				        new Lfx.Data.FormField("articulos.codigo3", Cod3, Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lfx.Data.FormField("articulos_categorias.nombre AS categorias_nombre", "Categoría", Lfx.Data.InputFieldTypes.Text, 120)
			        },

                                ExtraSearchFields = new Lfx.Data.FormFieldCollection()
			        {
				        new Lfx.Data.FormField("articulos.codigo1", Cod1, Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("articulos.codigo2", Cod2, Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("articulos.codigo3", Cod3, Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("articulos.codigo4", Cod4, Lfx.Data.InputFieldTypes.Text, 0),
				        new Lfx.Data.FormField("articulos.descripcion", "Descripción", Lfx.Data.InputFieldTypes.Memo, 0),
				        new Lfx.Data.FormField("articulos.descripcion2", "Descripción Extendida", Lfx.Data.InputFieldTypes.Memo, 0),
				        new Lfx.Data.FormField("articulos.obs", "Observaciones", Lfx.Data.InputFieldTypes.Memo, 0)
			        }
                        };

                        this.Contadores.Add(new Contador("Costo", Lui.Forms.DataTypes.Currency, "$", null));
                        this.Contadores.Add(new Contador("PVP", Lui.Forms.DataTypes.Currency, "$", null));

                        this.Definicion.FormFields["pedido"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;
                        this.Definicion.FormFields["apedir"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;
                        this.Definicion.FormFields["articulos.stock_actual"].TotalFunction = Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum;
                        
                        this.HabilitarFiltrar = true;
                }

                private qGen.JoinCollection FixedJoins()
                {
                        return new qGen.JoinCollection() { 
                                new qGen.Join("articulos_categorias", "articulos_categorias.id_categoria=articulos.id_categoria")
                        };
                }

                protected override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        if (row.Fields["destacado"].ValueInt != 0)
                                itm.Font = new Font(itm.Font, FontStyle.Bold);

                        if (itm.SubItems.ContainsKey("stock_actual")) {
                                if (row.Fields["stock_actual"].ValueDouble < row.Fields["stock_minimo"].ValueDouble) {
                                        //Faltante
                                        itm.UseItemStyleForSubItems = false;
                                        itm.SubItems["stock_actual"].BackColor = System.Drawing.Color.Pink;
                                        itm.SubItems["stock_actual"].BackColor = System.Drawing.Color.Pink;
                                }
                        }

                        if (itm.SubItems.ContainsKey("apedir")) {
                                if (row.Fields["apedir"].ValueDouble > 0)
                                        itm.SubItems["apedir"].Text = "-";
                                else
                                        itm.SubItems["apedir"].BackColor = System.Drawing.Color.LightPink;
                        }
                }

                protected override void OnBeginRefreshList()
                {
                        this.CustomFilters.Clear();

                        if (m_Proveedor > 0)
                                this.CustomFilters.Add(new qGen.ComparisonCondition("id_proveedor", m_Proveedor));

                        if (m_Marca > 0)
                                this.CustomFilters.Add(new qGen.ComparisonCondition("id_marca", m_Marca));

                        if (m_Categoria > 0)
                                this.CustomFilters.Add(new qGen.ComparisonCondition("articulos.id_categoria", m_Categoria));
                        
                        if (m_Rubro > 0)
                                this.CustomFilters.Add(new qGen.ComparisonCondition("articulos.id_categoria", qGen.ComparisonOperators.In, new qGen.SqlExpression("SELECT id_categoria FROM articulos_categorias WHERE id_rubro=" + m_Rubro.ToString())));

                        if (m_PvpDesde != 0)
                                this.CustomFilters.Add(new qGen.ComparisonCondition("pvp", qGen.ComparisonOperators.GreaterOrEqual, m_PvpDesde));
                        if (m_PvpHasta != 0)
                                this.CustomFilters.Add(new qGen.ComparisonCondition("pvp", qGen.ComparisonOperators.LessOrEqual, m_PvpHasta));

                        if (m_Situacion > 0) {
                                this.CustomFilters.Add(new qGen.ComparisonCondition("articulos_stock.id_situacion", m_Situacion));
                                this.CustomFilters.Add(new qGen.ComparisonCondition("articulos_stock.cantidad", qGen.ComparisonOperators.NotEquals, 0));
                                this.Definicion.Joins = this.FixedJoins();
                                this.Definicion.Joins.Add(new qGen.Join("articulos_stock", "articulos.id_articulo=articulos_stock.id_articulo"));
                                this.Definicion.FormFields[3].ColumnName = "articulos_stock.cantidad";
                        } else {
                                this.Definicion.Joins = this.FixedJoins();
                                this.Definicion.FormFields[3].ColumnName = "articulos.stock_actual";
                        }

                        switch (m_Stock) {
                                case "cs":
                                        this.CustomFilters.Add(new qGen.ComparisonCondition("stock_actual", qGen.ComparisonOperators.GreaterThan, 0));
                                        break;

                                case "ss":
                                        this.CustomFilters.Add(new qGen.ComparisonCondition("stock_actual", qGen.ComparisonOperators.LessOrEqual, 0));
                                        break;

                                case "faltante":
                                        this.CustomFilters.AddWithValue("stock_actual", qGen.ComparisonOperators.LessThan, new qGen.SqlExpression("stock_minimo"));
                                        break;

                                case "faltanteip":
                                        this.CustomFilters.Add(new qGen.ComparisonCondition("stock_actual+pedido", qGen.ComparisonOperators.LessThan, new qGen.SqlExpression("stock_minimo")));
                                        break;

                                case "apedir":
                                        this.CustomFilters.Add(new qGen.ComparisonCondition("apedir", qGen.ComparisonOperators.GreaterThan, 0));
                                        break;

                                case "pedido":
                                        this.CustomFilters.Add(new qGen.ComparisonCondition("pedido", qGen.ComparisonOperators.GreaterThan, 0));
                                        break;
                        }
                }

                protected override void OnEndRefreshList()
                {
                        string SelectValorizacion = "SELECT SUM(costo*stock_actual) FROM articulos";
                        if (this.Definicion.Joins != null && this.Definicion.Joins.Count > 0) {
                                foreach (qGen.Join Jo in this.Definicion.Joins) {
                                        SelectValorizacion += Jo.ToString();
                                }
                        }
                        if (this.CustomFilters.Count > 0)
                                SelectValorizacion += " WHERE " + this.CustomFilters.ToString();
                        this.Contadores[0].Total = this.Connection.FieldDecimal(SelectValorizacion);

                        SelectValorizacion = "SELECT SUM(pvp*stock_actual) FROM articulos";
                        if (this.Definicion.Joins != null && this.Definicion.Joins.Count > 0) {
                                foreach (qGen.Join Jo in this.Definicion.Joins) {
                                        SelectValorizacion += Jo.ToString();
                                }
                        }
                        if (this.CustomFilters.Count > 0)
                                SelectValorizacion += " WHERE " + this.CustomFilters.ToString();
                        this.Contadores[1].Total = this.Connection.FieldDecimal(SelectValorizacion);

                        base.OnEndRefreshList();
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        using (Articulos.Filtros FormFiltros = new Articulos.Filtros()) {
                                FormFiltros.Connection = this.Connection;
                                FormFiltros.EntradaRubro.TextInt = m_Rubro;
                                FormFiltros.EntradaCategoria.TextInt = m_Categoria;
                                FormFiltros.EntradaProveedor.TextInt = m_Proveedor;
                                FormFiltros.EntradaMarca.TextInt = m_Marca;
                                FormFiltros.EntradaStock.TextKey = m_Stock;
                                FormFiltros.EntradaSituacion.TextInt = m_Situacion;
                                FormFiltros.EntradaPvpDesde.Text = Lfx.Types.Formatting.FormatCurrency(m_PvpDesde, this.Workspace.CurrentConfig.Moneda.Decimales);
                                FormFiltros.EntradaPvpHasta.Text = Lfx.Types.Formatting.FormatCurrency(m_PvpHasta, this.Workspace.CurrentConfig.Moneda.Decimales);
                                FormFiltros.EntradaAgrupar.TextKey = this.GroupingColumnName;

                                if (FormFiltros.ShowDialog() == DialogResult.OK) {
                                        m_Rubro = FormFiltros.EntradaRubro.TextInt;
                                        m_Categoria = FormFiltros.EntradaCategoria.TextInt;
                                        m_Marca = FormFiltros.EntradaMarca.TextInt;
                                        m_Proveedor = FormFiltros.EntradaProveedor.TextInt;
                                        m_Stock = FormFiltros.EntradaStock.TextKey;
                                        m_Situacion = FormFiltros.EntradaSituacion.TextInt;
                                        m_PvpDesde = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaPvpDesde.Text);
                                        m_PvpHasta = Lfx.Types.Parsing.ParseCurrency(FormFiltros.EntradaPvpHasta.Text);
                                        this.GroupingColumnName = FormFiltros.EntradaAgrupar.TextKey;
                                        this.RefreshList();
                                        return new Lfx.Types.SuccessOperationResult();
                                } else {
                                        return new Lfx.Types.OperationResult(false);
                                }
                        }
                }
        }
}