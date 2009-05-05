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
        public class Inicio : Lui.Forms.ListingForm
        {
                internal string m_Stock = "*";

                #region Código generado por el Diseñador de Windows Forms

                public Inicio()
                        :
                    base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
			DataTableName = "cat_articulos";
                        KeyField = new Lfx.Data.FormField("cat_articulos.id_cat_articulo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        OrderBy = "cat_articulos.nombre";
			FormFields = new Lfx.Data.FormField[]
			{
				new Lfx.Data.FormField("cat_articulos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("cat_articulos.stock_minimo", "Stock Mín", Lfx.Data.InputFieldTypes.Numeric, 96),
				new Lfx.Data.FormField("0", "Stock Act", Lfx.Data.InputFieldTypes.Numeric, 96),
				new Lfx.Data.FormField("0", "Pedidos", Lfx.Data.InputFieldTypes.Numeric, 96),
				new Lfx.Data.FormField("0", "Faltante", Lfx.Data.InputFieldTypes.Numeric, 96),
			};
                        BotonFiltrar.Visible = true;
                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing)
                        {
                                if (components != null)
                                {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.

                private void InitializeComponent()
                {
                        this.SuspendLayout();
                        // 
                        // lvItems
                        // 
                        this.Listado.Name = "lvItems";
                        this.Listado.Size = new System.Drawing.Size(546, 466);
                        // 
                        // CreateButton
                        // 
                        this.BotonCrear.DockPadding.All = 2;
                        this.BotonCrear.Name = "CreateButton";
                        // 
                        // FiltersButton
                        // 
                        this.BotonFiltrar.DockPadding.All = 2;
                        this.BotonFiltrar.Name = "FiltersButton";
                        // 
                        // PrintButton
                        // 
                        this.BotonImprimir.DockPadding.All = 2;
                        this.BotonImprimir.Name = "PrintButton";
                        // 
                        // Inicio
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Name = "Inicio";
                        this.Text = "Artículos: Categorías";
                        this.ResumeLayout(false);

                }

                #endregion

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
                        base.Fill(sqlCommand);

                        foreach (System.Windows.Forms.ListViewItem itm in Listado.Items)
                        {
                                if (this.Workspace.SlowLink == false)
                                {
                                        itm.SubItems[3].Text = this.Workspace.DefaultDataBase.FieldInt("SELECT SUM(articulos.stock_actual) AS stock_actual FROM articulos, cat_articulos WHERE articulos.id_cat_articulo=cat_articulos.id_cat_articulo AND articulos.id_cat_articulo=" + itm.Text).ToString();
                                        itm.SubItems[4].Text = this.Workspace.DefaultDataBase.FieldInt("SELECT SUM(articulos.pedido) AS pedidos FROM articulos, cat_articulos WHERE articulos.id_cat_articulo=cat_articulos.id_cat_articulo AND articulos.id_cat_articulo=" + itm.Text).ToString();
                                }

                                if (Lfx.Types.Parsing.ParseStock(itm.SubItems[3].Text) + Lfx.Types.Parsing.ParseStock(itm.SubItems[4].Text) < Lfx.Types.Parsing.ParseStock(itm.SubItems[2].Text))
                                {
                                        itm.ForeColor = System.Drawing.Color.Red;
                                        itm.SubItems[5].Text = Lfx.Types.Formatting.FormatNumber(Lfx.Types.Parsing.ParseDouble(itm.SubItems[2].Text) - (Lfx.Types.Parsing.ParseDouble(itm.SubItems[3].Text) + Lfx.Types.Parsing.ParseDouble(itm.SubItems[4].Text)), this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                                }
                                else if (Lfx.Types.Parsing.ParseStock(itm.SubItems[3].Text) < Lfx.Types.Parsing.ParseStock(itm.SubItems[2].Text))
                                {
                                        itm.ForeColor = System.Drawing.Color.DarkGreen;
                                }
                                this.Refresh();
                        }
                }
        }
}