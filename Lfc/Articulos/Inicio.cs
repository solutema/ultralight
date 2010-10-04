#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                protected internal double m_PvpDesde = 0, m_PvpHasta = 0;
                protected internal int m_Proveedor = 0, m_Marca = 0, m_Categoria = 0, m_Rubro = 0, m_Situacion = 0;
                public string m_Stock = "*";

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "articulos";
                        KeyField = new Lfx.Data.FormField("articulos.id_articulo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80);
                        this.Joins = this.DefaultJoins();
                        OrderBy = "articulos.nombre";

                        Lfx.Data.Row CodRow = this.DataBase.Tables["articulos_codigos"].FastRows[1];
                        string Cod1 = CodRow == null ? "Código 1" : CodRow["nombre"].ToString();
                        CodRow = this.DataBase.Tables["articulos_codigos"].FastRows[2];
                        string Cod2 = CodRow == null ? "Código 2" : CodRow["nombre"].ToString();
                        CodRow = this.DataBase.Tables["articulos_codigos"].FastRows[3];
                        string Cod3 = CodRow == null ? "Código 3" : CodRow["nombre"].ToString();
                        CodRow = this.DataBase.Tables["articulos_codigos"].FastRows[4];
                        string Cod4 = CodRow == null ? "Código 4" : CodRow["nombre"].ToString();

                        FormFields = new List<Lfx.Data.FormField>()
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
			};
                        ExtraSearchFields = new List<Lfx.Data.FormField>()
			{
				new Lfx.Data.FormField("articulos.codigo1", Cod1, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.codigo2", Cod2, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.codigo3", Cod3, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.codigo4", Cod4, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.descripcion", "Descripción", Lfx.Data.InputFieldTypes.Memo, 0),
				new Lfx.Data.FormField("articulos.descripcion2", "Descripción Extendida", Lfx.Data.InputFieldTypes.Memo, 0),
				new Lfx.Data.FormField("articulos.obs", "Observaciones", Lfx.Data.InputFieldTypes.Memo, 0)
			};

                        // Cargo la tabla en memoria
                        this.DataBase.Tables["articulos_codigos"].PreLoad();

                        BotonFiltrar.Visible = true;
                }

                private List<qGen.Join> DefaultJoins()
                {
                        return new List<qGen.Join>() { 
                                new qGen.Join("articulos_categorias", "articulos_categorias.id_categoria=articulos.id_categoria")
                        };
                }

                public override void ItemAdded(ListViewItem itm, Lfx.Data.Row row)
                {
                        if (row.Fields["destacado"].ValueInt != 0)
                                itm.Font = new Font(itm.Font, FontStyle.Bold);

                        if (row.Fields["stock_actual"].ValueDouble < row.Fields["stock_minimo"].ValueDouble) {
                                //Faltante
                                itm.UseItemStyleForSubItems = false;
                                itm.SubItems["stock_actual"].BackColor = System.Drawing.Color.Pink;
                                itm.SubItems["stock_actual"].BackColor = System.Drawing.Color.Pink;
                        }

                        if (row.Fields["apedir"].ValueDouble > 0)
                                itm.SubItems["apedir"].Text = "-";
                        else
                                itm.SubItems["apedir"].BackColor = System.Drawing.Color.LightPink;
                }

                public override void BeginRefreshList()
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
                                this.Joins = this.DefaultJoins();
                                this.Joins.Add(new qGen.Join("articulos_stock", "articulos.id_articulo=articulos_stock.id_articulo"));
                                this.FormFields[3] = new Lfx.Data.FormField("articulos_stock.cantidad", "Stock", Lfx.Data.InputFieldTypes.Numeric, 120);
                        } else {
                                this.Joins = this.DefaultJoins();
                                this.FormFields[3] = new Lfx.Data.FormField("articulos.stock_actual", "Stock", Lfx.Data.InputFieldTypes.Numeric, 120);
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

                public override void EndRefreshList()
                {
                        string SelectValorizacion = "SELECT SUM(costo*stock_actual) FROM articulos";
                        if (this.Joins != null && this.Joins.Count > 0) {
                                foreach (qGen.Join Jo in this.Joins) {
                                        SelectValorizacion += Jo.ToString();
                                }
                        }
                        if (this.CustomFilters.Count > 0)
                                SelectValorizacion += " WHERE " + this.CustomFilters.ToString();
                        double Valorizacion = this.DataBase.FieldDouble(SelectValorizacion);
                        EntradaValorizacionCosto.Text = Lfx.Types.Formatting.FormatCurrency(Valorizacion, this.Workspace.CurrentConfig.Moneda.DecimalesCosto);

                        SelectValorizacion = "SELECT SUM(pvp*stock_actual) FROM articulos";
                        if (this.Joins != null && this.Joins.Count > 0) {
                                foreach (qGen.Join Jo in this.Joins) {
                                        SelectValorizacion += Jo.ToString();
                                }
                        }
                        if (this.CustomFilters.Count > 0)
                                SelectValorizacion += " WHERE " + this.CustomFilters.ToString();
                        Valorizacion = this.DataBase.FieldDouble(SelectValorizacion);
                        EntradatValorizacionPvp.Text = Lfx.Types.Formatting.FormatCurrency(Valorizacion, this.Workspace.CurrentConfig.Moneda.Decimales);
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Articulos.Filtros OFormArticulosFiltros = new Articulos.Filtros();
                        OFormArticulosFiltros.EntradaRubro.TextInt = m_Rubro;
                        OFormArticulosFiltros.EntradaCategoria.TextInt = m_Categoria;
                        OFormArticulosFiltros.EntradaProveedor.TextInt = m_Proveedor;
                        OFormArticulosFiltros.EntradaMarca.TextInt = m_Marca;
                        OFormArticulosFiltros.EntradaStock.TextKey = m_Stock;
                        OFormArticulosFiltros.EntradaSituacion.TextInt = m_Situacion;
                        OFormArticulosFiltros.EntradaPvpDesde.Text = Lfx.Types.Formatting.FormatCurrency(m_PvpDesde, this.Workspace.CurrentConfig.Moneda.Decimales);
                        OFormArticulosFiltros.EntradaPvpHasta.Text = Lfx.Types.Formatting.FormatCurrency(m_PvpHasta, this.Workspace.CurrentConfig.Moneda.Decimales);
                        OFormArticulosFiltros.EntradaAgrupar.TextKey = this.GroupingColumnName;

                        if (OFormArticulosFiltros.ShowDialog() == DialogResult.OK) {
                                m_Rubro = OFormArticulosFiltros.EntradaRubro.TextInt;
                                m_Categoria = OFormArticulosFiltros.EntradaCategoria.TextInt;
                                m_Marca = OFormArticulosFiltros.EntradaMarca.TextInt;
                                m_Proveedor = OFormArticulosFiltros.EntradaProveedor.TextInt;
                                m_Stock = OFormArticulosFiltros.EntradaStock.TextKey;
                                m_Situacion = OFormArticulosFiltros.EntradaSituacion.TextInt;
                                m_PvpDesde = Lfx.Types.Parsing.ParseCurrency(OFormArticulosFiltros.EntradaPvpDesde.Text);
                                m_PvpHasta = Lfx.Types.Parsing.ParseCurrency(OFormArticulosFiltros.EntradaPvpHasta.Text);
                                this.GroupingColumnName = OFormArticulosFiltros.EntradaAgrupar.TextKey;
                                OFormArticulosFiltros = null;
                                this.RefreshList();
                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.OperationResult(false);
                        }
                }

                public override Lfx.Types.OperationResult OnCreate()
                {
                        this.Workspace.RunTime.Execute("CREAR ARTICULO");
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult OnEdit(int lCodigo)
                {
                        this.Workspace.RunTime.Execute("EDITAR ARTICULO " + lCodigo.ToString());
                        return new Lfx.Types.SuccessOperationResult();
                }

                private void BotonMovim_Click(object sender, System.EventArgs e)
                {
                        if (Listado.SelectedItems != null) {
                                int lCodigo = Lfx.Types.Parsing.ParseInt(Listado.SelectedItems[0].Text);
                                this.Workspace.RunTime.Execute("MOVIM ARTICULOS " + lCodigo.ToString());
                        } else {
                                this.Workspace.RunTime.Execute("MOVIM ARTICULOS");
                        }
                }

                private void FormArticulosInicio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.F5:
                                                if (BotonMovim.Visible && BotonMovim.Enabled)
                                                        BotonMovim.PerformClick();
                                                break;
                                }
                        }
                }
        }
}