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

namespace Lfc.Cajas.Vencimientos
{
        public partial class Inicio : Lfc.FormularioListado
        {
                public Inicio()
                {
                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Vencimientos.Vencimiento),

                                TableName = "vencimientos",
                                KeyColumnName = new Lazaro.Pres.Field("vencimientos.id_vencimiento", "Cód.", Lfx.Data.InputFieldTypes.Serial, 20),
                                Joins = new qGen.JoinCollection() { new qGen.Join("conceptos", "vencimientos.id_concepto=conceptos.id_concepto") },
                                OrderBy = "vencimientos.fecha_proxima DESC",
                                Columns = new Lazaro.Pres.FieldCollection()
			        {
				        new Lazaro.Pres.Field("vencimientos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 120),
				        new Lazaro.Pres.Field("vencimientos.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				        new Lazaro.Pres.Field("vencimientos.frecuencia", "Frecuencia", Lfx.Data.InputFieldTypes.Text, 120),
				        new Lazaro.Pres.Field("vencimientos.fecha_proxima", "Próxima Ocurrencia", Lfx.Data.InputFieldTypes.Date, 96),
				        new Lazaro.Pres.Field("conceptos.nombre", "Concepto", Lfx.Data.InputFieldTypes.Text, 160),
				        new Lazaro.Pres.Field("vencimientos.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
                                        new Lazaro.Pres.Field("vencimientos.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 320)
			        }
                        };

                        Listado.CheckBoxes = true;
                        this.HabilitarCrear = true;
                        this.HabilitarFiltrar = true;
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        switch (row.Fields["vencimientos.estado"].ValueInt) {
                                case 1:
                                        item.SubItems["vencimientos.estado"].Text = "Activo";
                                        NullableDateTime Vencimiento = row.Fields["vencimientos.fecha_proxima"].ValueDateTime;
                                        if (Vencimiento != null) {
                                                if (Vencimiento <= DateTime.Now)
                                                        item.ForeColor = System.Drawing.Color.Red;
                                                else if (Vencimiento <= DateTime.Now.AddDays(5))
                                                        item.ForeColor = System.Drawing.Color.Orange;
                                        }
                                        break;
                                case 2:
                                        item.SubItems["vencimientos.estado"].Text = "Inactivo";
                                        break;
                                case 100:
                                        item.SubItems["vencimientos.estado"].Text = "Terminado";
                                        break;
                        }                        
                }
        }
}