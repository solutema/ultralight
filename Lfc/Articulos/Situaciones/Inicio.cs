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

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Articulos.Situaciones
{
        public partial class Inicio : Lfc.FormularioListado
        {
                public Inicio()
                {
                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Articulos.Situacion),

                                TableName = "articulos_situaciones",
                                KeyColumn = new Lazaro.Pres.Field("articulos_situaciones.id_situacion", "Cód.", Lfx.Data.InputFieldTypes.Serial, 80),
                                DetailColumnName = "nombre",
                                OrderBy = "articulos_situaciones.nombre",
                                Columns = new Lazaro.Pres.FieldCollection()
                                {
				        new Lazaro.Pres.Field("articulos_situaciones.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
                                        new Lazaro.Pres.Field("articulos_situaciones.cuenta_stock", "Suma Stock", 96, new Dictionary<int, string> { {0, "No" }, { 1, "Si" } } ),
				        new Lazaro.Pres.Field("articulos_situaciones.facturable", "Facturable", 96, new Dictionary<int, string> { {0, "No" }, { 1, "Si" } } ),
				        new Lazaro.Pres.Field("articulos_situaciones.deposito", "Depósito", Lfx.Data.InputFieldTypes.Integer, 96),
			        },
                        };

                        this.HabilitarFiltrar = false;
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        if(row.Fields["articulos_situaciones.deposito"].ValueInt == 0)
                                item.SubItems["articulos_situaciones.deposito"].Text = "No";
                        base.OnItemAdded(item, row);
                }
        }
}