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

namespace Lfc.Articulos
{
        public partial class Inicio : Lui.Forms.ListingForm
        {
                protected internal double m_PVPDesde = 0, m_PVPHasta = 0;
                protected internal int m_Proveedor, m_Marca, m_Categoria, m_Situacion;
                private string m_Agrupar = "*";
                public string m_Stock = "*";

                public Inicio()
                {
                        InitializeComponent();

                        DataTableName = "articulos";
                        KeyField = new Lfx.Data.FormField("articulos.id_articulo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80);
                        OrderBy = "articulos.nombre";
                        BotonFiltrar.Visible = true;
                }

                public override void ItemAdded(ListViewItem itm)
                {
                        if (Lfx.Types.Parsing.ParseInt(itm.SubItems[8].Text) > 0)
                                itm.Font = new Font(itm.Font, FontStyle.Bold);
                        else
                                itm.SubItems[8].Text = "";

                        if (Lfx.Types.Parsing.ParseStock(itm.SubItems[5].Text) > 0 && Lfx.Types.Parsing.ParseStock(itm.SubItems[4].Text) <= Lfx.Types.Parsing.ParseStock(itm.SubItems[5].Text)) {
                                //Faltante
                                itm.UseItemStyleForSubItems = false;
                                itm.SubItems[4].BackColor = System.Drawing.Color.Pink;
                                itm.SubItems[5].BackColor = System.Drawing.Color.Pink;
                        }

                        if (Lfx.Types.Parsing.ParseStock(itm.SubItems[7].Text) <= 0)
                                itm.SubItems[7].Text = "-";
                        else
                                itm.SubItems[7].BackColor = System.Drawing.Color.LightPink;
                }

                public override void RefreshList()
                {
                        Lfx.Data.SqlWhereBuilder FiltroWhere = new Lfx.Data.SqlWhereBuilder();

                        if (m_Proveedor > 0)
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("id_proveedor", Lfx.Data.SqlCommandBuilder.SqlOperands.Equals, m_Proveedor.ToString()));

                        if (m_Marca > 0)
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("id_marca", Lfx.Data.SqlCommandBuilder.SqlOperands.Equals, m_Marca.ToString()));

                        if (m_Categoria > 0)
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("id_cat_articulo", Lfx.Data.SqlCommandBuilder.SqlOperands.Equals, m_Categoria.ToString()));

                        if (m_PVPDesde != 0)
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("pvp", Lfx.Data.SqlCommandBuilder.SqlOperands.GreaterOrEqual, Lfx.Types.Formatting.FormatCurrencySql(m_PVPDesde)));
                        if (m_PVPHasta != 0)
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("pvp", Lfx.Data.SqlCommandBuilder.SqlOperands.LessOrEqual, Lfx.Types.Formatting.FormatCurrencySql(m_PVPHasta)));

                        if (m_Situacion > 0) {
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("articulos_stock.id_situacion", Lfx.Data.SqlCommandBuilder.SqlOperands.Equals, m_Situacion.ToString()));
                                FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("articulos_stock.cantidad", Lfx.Data.SqlCommandBuilder.SqlOperands.NotEquals, "0"));
                                ExtraDataTableNames = "articulos_stock";
                                Relations = "articulos.id_articulo=articulos_stock.id_articulo";
                                this.FormFields[3] = new Lfx.Data.FormField("articulos_stock.cantidad", "Stock", Lfx.Data.InputFieldTypes.Numeric, 120);
                        } else {
                                ExtraDataTableNames = null;
                                Relations = null;
                                this.FormFields[3] = new Lfx.Data.FormField("articulos.stock_actual", "Stock", Lfx.Data.InputFieldTypes.Numeric, 120);
                        }

                        switch (m_Stock) {
                                case "cs":
                                        FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("stock_actual", Lfx.Data.SqlCommandBuilder.SqlOperands.GreaterThan, "0"));
                                        break;

                                case "ss":
                                        FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("stock_actual", Lfx.Data.SqlCommandBuilder.SqlOperands.LessOrEqual, "0"));
                                        break;

                                case "faltante":
                                        FiltroWhere.Conditions.Add("((stock_actual<stock_minimo AND stock_minimo>0) OR stock_actual<0)");
                                        break;

                                case "faltanteip":
                                        FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("stock_minimo", Lfx.Data.SqlCommandBuilder.SqlOperands.GreaterThan, "0"));
                                        FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("stock_actual+pedido", Lfx.Data.SqlCommandBuilder.SqlOperands.LessThan, "stock_minimo"));
                                        break;

                                case "apedir":
                                        FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("apedir", Lfx.Data.SqlCommandBuilder.SqlOperands.GreaterThan, "0"));
                                        break;

                                case "pedido":
                                        FiltroWhere.Conditions.Add(new Lfx.Data.SqlCondition("pedido", Lfx.Data.SqlCommandBuilder.SqlOperands.GreaterThan, "0"));
                                        break;
                        }
                        this.CurrentFilter = FiltroWhere;
                        base.RefreshList();

                        string SelectValorizacion = "SELECT SUM(costo*stock_actual) FROM articulos";
                        if (ExtraDataTableNames != null && Relations != null)
                                SelectValorizacion += " LEFT JOIN " + ExtraDataTableNames + " ON " + Relations;
                        if (FiltroWhere.Conditions.Count > 0)
                                SelectValorizacion += " WHERE " + FiltroWhere.ToString();
                        double Valorizacion = this.Workspace.DefaultDataBase.FieldDouble(SelectValorizacion);
                        txtValorCosto.Text = Lfx.Types.Formatting.FormatCurrency(Valorizacion, this.Workspace.CurrentConfig.Currency.DecimalPlacesCosto);

                        SelectValorizacion = "SELECT SUM(pvp*stock_actual) FROM articulos";
                        if (ExtraDataTableNames != null && Relations != null)
                                SelectValorizacion += " LEFT JOIN " + ExtraDataTableNames + " ON " + Relations;
                        if (FiltroWhere.Conditions.Count > 0)
                                SelectValorizacion += " WHERE " + FiltroWhere.ToString();
                        Valorizacion = this.Workspace.DefaultDataBase.FieldDouble(SelectValorizacion);
                        txtValorPVP.Text = Lfx.Types.Formatting.FormatCurrency(Valorizacion, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }

                public override Lfx.Types.OperationResult OnFilter()
                {
                        Articulos.Filtros OFormArticulosFiltros = new Articulos.Filtros();
                        OFormArticulosFiltros.Workspace = this.Workspace;
                        OFormArticulosFiltros.EntradaProveedor.TextInt = m_Proveedor;
                        OFormArticulosFiltros.EntradaMarca.TextInt = m_Marca;
                        OFormArticulosFiltros.EntradaCategoria.TextInt = m_Categoria;
                        OFormArticulosFiltros.EntradaStock.TextKey = m_Stock;
                        OFormArticulosFiltros.EntradaSituacion.TextInt = m_Situacion;
                        OFormArticulosFiltros.EntradaPvpDesde.Text = Lfx.Types.Formatting.FormatCurrency(m_PVPDesde, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        OFormArticulosFiltros.EntradaPvpHasta.Text = Lfx.Types.Formatting.FormatCurrency(m_PVPHasta, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        OFormArticulosFiltros.EntradaAgrupar.TextKey = m_Agrupar;

                        if (OFormArticulosFiltros.ShowDialog() == DialogResult.OK) {
                                m_Marca = OFormArticulosFiltros.EntradaMarca.TextInt;
                                m_Proveedor = OFormArticulosFiltros.EntradaProveedor.TextInt;
                                m_Categoria = OFormArticulosFiltros.EntradaCategoria.TextInt;
                                m_Stock = OFormArticulosFiltros.EntradaStock.TextKey;
                                m_Situacion = OFormArticulosFiltros.EntradaSituacion.TextInt;
                                m_PVPDesde = Lfx.Types.Parsing.ParseCurrency(OFormArticulosFiltros.EntradaPvpDesde.Text);
                                m_PVPHasta = Lfx.Types.Parsing.ParseCurrency(OFormArticulosFiltros.EntradaPvpHasta.Text);
                                m_Agrupar = OFormArticulosFiltros.EntradaAgrupar.TextKey;
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

                private void cmdMovim_Click(object sender, System.EventArgs e)
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
                                                if (cmdMovim.Visible && cmdMovim.Enabled)
                                                        cmdMovim_Click(sender, e);
                                                break;
                                }
                        }
                }

                private void Inicio_WorkspaceChanged(object sender, EventArgs e)
                {
                        Lfx.Data.Row CodRow = this.DataView.Tables["articulos_codigos"].FastRows[1];
                        string Cod1 = CodRow == null ? "Código 1" : CodRow["nombre"].ToString();
                        CodRow = this.DataView.Tables["articulos_codigos"].FastRows[2];
                        string Cod2 = CodRow == null ? "Código 2" : CodRow["nombre"].ToString();
                        CodRow = this.DataView.Tables["articulos_codigos"].FastRows[3];
                        string Cod3 = CodRow == null ? "Código 3" : CodRow["nombre"].ToString();
                        CodRow = this.DataView.Tables["articulos_codigos"].FastRows[4];
                        string Cod4 = CodRow == null ? "Código 4" : CodRow["nombre"].ToString();

                        FormFields = new Lfx.Data.FormField[]
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
				new Lfx.Data.FormField("articulos.codigo3", Cod3, Lfx.Data.InputFieldTypes.Text, 120)
			};
                        ExtraSearchFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("articulos.codigo1", Cod1, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.codigo2", Cod2, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.codigo3", Cod3, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.codigo4", Cod4, Lfx.Data.InputFieldTypes.Text, 0),
				new Lfx.Data.FormField("articulos.descripcion", "Descripción", Lfx.Data.InputFieldTypes.Memo, 0),
				new Lfx.Data.FormField("articulos.descripcion2", "Descripción Extendida", Lfx.Data.InputFieldTypes.Memo, 0),
				new Lfx.Data.FormField("articulos.obs", "Observaciones", Lfx.Data.InputFieldTypes.Memo, 0)
			};
                }
        }
}