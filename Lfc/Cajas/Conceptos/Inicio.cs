#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Cajas.Conceptos
{
	public class Inicio : Lfc.FormularioListado
	{
		public Inicio()
		{
                        this.ElementoTipo = typeof(Lbl.Cajas.Concepto);

                        this.NombreTabla = "conceptos";
                        this.KeyField = new Lfx.Data.FormField("conceptos.id_concepto", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
			this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("conceptos.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 320),
				new Lfx.Data.FormField("conceptos.es", "Tipo", Lfx.Data.InputFieldTypes.Text, 120),
				new Lfx.Data.FormField("conceptos.grupo", "Grupo", Lfx.Data.InputFieldTypes.Text, 120)
			};
		}

                public override void OnItemAdded(ListViewItem itm, Lfx.Data.Row row)
		{
			string Codigo = itm.Text;
			if(Codigo.Substring(2, 1) != "0")
                                itm.SubItems["nombre"].Text = "    " + itm.SubItems["nombre"].Text;
			if(Codigo.Substring(3, 1) != "0")
                                itm.SubItems["nombre"].Text = "    " + itm.SubItems["nombre"].Text;

			switch(row.Fields["es"].ValueInt) {
				case 1:
					itm.SubItems["es"].Text = "Entrada";
					break;
				case 2:
                                        itm.SubItems["es"].Text = "Salida";
					break;
				case 0:
                                        itm.SubItems["es"].Text = "Entrada/Salida";
					break;
				default:
                                        itm.SubItems["es"].Text = "???";
					break;
			}

			switch(row.Fields["grupo"].ValueInt) {
				case 0:
					itm.SubItems["grupo"].Text = "-";
					break;
				case 110:
                                        itm.SubItems["grupo"].Text = "Cobros";
					break;
				case 100:
                                        itm.SubItems["grupo"].Text = "Otros ingresos";
					break;
				case 230:
                                        itm.SubItems["grupo"].Text = "Gastos fijos";
					break;
				case 240:
                                        itm.SubItems["grupo"].Text = "Gastos variables";
					break;
				case 200:
                                        itm.SubItems["grupo"].Text = "Otros gastos";
					break;
				case 260:
                                        itm.SubItems["grupo"].Text = "Pérdida";
					break;
				case 250:
                                        itm.SubItems["grupo"].Text = "Reinversión";
					break;
				case 210:
                                        itm.SubItems["grupo"].Text = "Costo materiales";
					break;
				case 220:
                                        itm.SubItems["grupo"].Text = "Costo capital";
					break;
				case 231:
                                        itm.SubItems["grupo"].Text = "Sueldos y salarios";
					break;
				case 300:
                                        itm.SubItems["grupo"].Text = "Movimientos y ajustes";
					break;
				default:
                                        itm.SubItems["grupo"].Text = "???";
					break;
			}

		}
	}
}