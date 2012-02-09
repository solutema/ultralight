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
using System.Windows.Forms;

namespace Lfc.Pvs
{
	public class Inicio : Lfc.FormularioListado
	{
		public Inicio()
		{
                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Comprobantes.PuntoDeVenta),

                                TableName = "pvs",
                                KeyColumn = new Lazaro.Pres.Field("pvs.id_pv", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Joins = new qGen.JoinCollection() { new qGen.Join("sucursales", "pvs.id_sucursal=sucursales.id_sucursal") },
                                Columns = new Lazaro.Pres.FieldCollection()
			        {
				        new Lazaro.Pres.Field("pvs.id_pv", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                        new Lazaro.Pres.Field("pvs.numero", "PV", Lfx.Data.InputFieldTypes.Integer, 96),
				        new Lazaro.Pres.Field("pvs.tipo", "Tipo", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lazaro.Pres.Field("pvs.tipo_fac", "Comprobantes", Lfx.Data.InputFieldTypes.Text, 180),
				        new Lazaro.Pres.Field("sucursales.nombre", "Sucursal", Lfx.Data.InputFieldTypes.Text, 160),
				        new Lazaro.Pres.Field("pvs.estacion", "Estacion", Lfx.Data.InputFieldTypes.Text, 160),
				        new Lazaro.Pres.Field("pvs.carga", "Carga", Lfx.Data.InputFieldTypes.Text, 120),
                                        new Lazaro.Pres.Field("pvs.detalonario", "Usa Talonarios", Lfx.Data.InputFieldTypes.Bool, 120)
			        },
                                Filters = new Lazaro.Pres.Filters.FilterCollection()
                                {
                                        new Lazaro.Pres.Filters.SetFilter("Tipo", "pvs.tipo", new string[] { "Todos|*", "Inactivo|0", "Normal|1", "Fiscal|2" }, "*")
                                }
                        };

                        this.HabilitarFiltrar = false;
		}


                public override void OnFiltersChanged(Lazaro.Pres.Filters.FilterCollection filters)
                {
                        this.CustomFilters.Clear();

                        if (((Lazaro.Pres.Filters.SetFilter)(filters["pvs.tipo"])).CurrentValue != "*")
                                CustomFilters.AddWithValue("pvs.tipo", Lfx.Types.Parsing.ParseInt(filters[0].Value.ToString()));

                        base.OnFiltersChanged(filters);
                }


                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        switch (row.Fields["pvs.tipo_fac"].ValueString) {
                                case "F":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Facturas";
                                        break;
                                case "F,ND":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Facturas, Notas de Débito";
                                        break;
                                case "F,NC,ND":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Facturas, Notas de Crédito y Débito";
                                        break;
                                case "R":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Remitos";
                                        break;
                                case "RC":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Recibos de Cobro";
                                        break;
                                case "RP":
                                        item.SubItems[Listado.Columns["pvs.tipo_fac"].Index].Text = "Recibos de Pago";
                                        break;
                        }

                        int TipoPv = row.Fields["pvs.tipo"].ValueInt;
                        if (TipoPv == 0)
                                item.SubItems[Listado.Columns["pvs.tipo"].Index].Text = "Inactivo";
                        if (TipoPv == 1)
                                item.SubItems[Listado.Columns["pvs.tipo"].Index].Text = "Normal";
                        else if (TipoPv == 2)
                                item.SubItems[Listado.Columns["pvs.tipo"].Index].Text = "Fiscal";

                        if (item.SubItems[Listado.Columns["pvs.carga"].Index].Text == "0")
                                item.SubItems[Listado.Columns["pvs.carga"].Index].Text = "Automática";
                        else if (item.SubItems[Listado.Columns["pvs.carga"].Index].Text == "1")
                                item.SubItems[Listado.Columns["pvs.carga"].Index].Text = "Manual";
                }
	}
}

