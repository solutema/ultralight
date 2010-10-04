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

namespace Lfc.Articulos.Categorias
{
        public partial class Editar : Lui.Forms.EditForm
        {
                public Editar()
                {
                        InitializeComponent();

                        this.ElementType = typeof(Lbl.Articulos.Categoria);
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "products.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Articulos.Categoria Cat = new Lbl.Articulos.Categoria(this.DataBase);
                        Cat.Crear();
                        EntradaImagen.Elemento = Cat;

                        this.FromRow(Cat);
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Articulos.Categoria Cat = row as Lbl.Articulos.Categoria;

                        EntradaNombre.Text = Cat.Nombre;
                        EntradaNombreSing.Text = Cat.NombreSingular;
                        EntradaStockMinimo.Text = Lfx.Types.Formatting.FormatStock(Cat.StockMinimo);
                        EntradaWeb.TextKey = Cat.PublicacionWeb.ToString();
                        EntradaSeguimiento.TextKey = ((int)(Cat.Seguimiento)).ToString();
                        EntradaItem.Text = Lfx.Types.Formatting.FormatStock(this.DataBase.FieldDouble("SELECT COUNT(id_articulo) FROM articulos WHERE id_categoria=" + Cat.Id.ToString()));
                        EntradaItemStock.Text = Lfx.Types.Formatting.FormatStock(this.DataBase.FieldDouble("SELECT COUNT(id_articulo) FROM articulos WHERE stock_actual>0 AND id_categoria=" + Cat.Id.ToString()));
                        EntradaStockActual.Text = Lfx.Types.Formatting.FormatStock(this.DataBase.FieldDouble("SELECT SUM(stock_actual) FROM articulos WHERE id_categoria=" + Cat.Id.ToString()));
                        EntradaCosto.Text = Lfx.Types.Formatting.FormatStock(this.DataBase.FieldDouble("SELECT SUM(costo) FROM articulos WHERE id_categoria=" + Cat.Id.ToString()));
                        EntradaGarantia.Text = Cat.Garantia.ToString();
                        EntradaRubro.Elemento = Cat.Rubro;
                        EntradaImagen.Elemento = Cat;

                        this.ReadOnly = !Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "products.write");

                        if (this.CachedRow.Existe)
                                this.Text = "Categoría: " + Cat.Nombre;
                        else
                                this.Text = "Categoría: Nueva";

                        this.Changed = false;
                        
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Articulos.Categoria Cat = this.CachedRow as Lbl.Articulos.Categoria;

                        Cat.Nombre = EntradaNombre.Text;
                        Cat.NombreSingular = EntradaNombreSing.Text;
                        Cat.StockMinimo = Lfx.Types.Parsing.ParseStock(EntradaStockMinimo.Text);
                        Cat.PublicacionWeb = Lfx.Types.Parsing.ParseInt(EntradaWeb.TextKey);
                        Cat.Seguimiento = ((Lbl.Articulos.Seguimientos)(Lfx.Types.Parsing.ParseInt(EntradaSeguimiento.TextKey)));
                        Cat.Garantia = Lfx.Types.Parsing.ParseInt(EntradaGarantia.Text);
                        Cat.Rubro = EntradaRubro.Elemento as Lbl.Articulos.Rubro;

                        EntradaImagen.ActualizarElemento();

                        return base.ToRow();
                }
        }
}
