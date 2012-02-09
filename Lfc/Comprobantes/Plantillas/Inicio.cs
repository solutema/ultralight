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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
	public class Inicio : Lfc.FormularioListado
	{
		public Inicio()
		{
                        this.Definicion = new Lazaro.Pres.Listings.Listing()
                        {
                                ElementoTipo = typeof(Lbl.Impresion.Plantilla),

                                TableName = "sys_plantillas",
                                KeyColumn = new Lazaro.Pres.Field("sys_plantillas.id_plantilla", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0),
                                Columns = new Lazaro.Pres.FieldCollection()
			        {
				        new Lazaro.Pres.Field("sys_plantillas.codigo", "Código", Lfx.Data.InputFieldTypes.Text, 240),
				        new Lazaro.Pres.Field("sys_plantillas.nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
                                        new Lazaro.Pres.Field("sys_plantillas.tamanopapel", "Papel", Lfx.Data.InputFieldTypes.Text, 64),
				        new Lazaro.Pres.Field("sys_plantillas.copias", "Copias", Lfx.Data.InputFieldTypes.Integer, 64)
			        },
                                OrderBy = "sys_plantillas.codigo"
                        };

			this.HabilitarFiltrar = false;
		}
	}
}

