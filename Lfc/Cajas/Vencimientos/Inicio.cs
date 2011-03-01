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
using System.Windows.Forms;

namespace Lfc.Cajas.Vencimientos
{
        public partial class Inicio : Lfc.FormularioListado
        {
                public Inicio()
                {
                        this.ElementoTipo = typeof(Lbl.Cajas.Vencimiento);

                        this.NombreTabla = "vencimientos";
                        this.KeyField = new Lfx.Data.FormField("vencimientos.id_vencimiento", "Cód.", Lfx.Data.InputFieldTypes.Serial, 20);
                        this.OrderBy = "vencimientos.fecha_proxima DESC";
                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("vencimientos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("vencimientos.importe", "Importe", Lfx.Data.InputFieldTypes.Currency, 96),
				new Lfx.Data.FormField("vencimientos.frecuencia", "Frecuencia", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("vencimientos.fecha_proxima", "Próxima Ocurrencia", Lfx.Data.InputFieldTypes.Date, 96),
				new Lfx.Data.FormField("vencimientos.id_concepto", "Concepto", Lfx.Data.InputFieldTypes.Text, 160),
				new Lfx.Data.FormField("vencimientos.estado", "Estado", Lfx.Data.InputFieldTypes.Text, 96),
                                new Lfx.Data.FormField("vencimientos.obs", "Obs", Lfx.Data.InputFieldTypes.Memo, 320)
			};
                        Listado.CheckBoxes = true;
                        this.HabilitarFiltrar = true;
                }

                protected override void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                        switch (row.Fields["estado"].ValueInt) {
                                case 1:
                                        item.SubItems["estado"].Text = "Activo";
                                        Lfx.Types.LDateTime Vencimiento = row.Fields["fecha_proxima"].ValueDateTime;
                                        if (Vencimiento != null && Vencimiento <= DateTime.Now)
                                                item.ForeColor = System.Drawing.Color.Red;
                                        else if (Vencimiento != null && Vencimiento <= DateTime.Now.AddDays(5))
                                                item.ForeColor = System.Drawing.Color.Orange;
                                        break;
                                case 2:
                                        item.SubItems["estado"].Text = "Inactivo";
                                        break;
                                case 100:
                                        item.SubItems["estado"].Text = "Terminado";
                                        break;
                        }

                        Lfx.Data.Row Concepto = this.Connection.Tables["conceptos"].FastRows[row.Fields["id_concepto"].ValueInt];
                        if (Concepto != null)
                                item.SubItems["id_concepto"].Text = Concepto.Fields["nombre"].ToString();

                        
                }
        }
}