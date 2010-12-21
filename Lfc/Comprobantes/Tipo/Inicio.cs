﻿#region License
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Tipo
{
	public partial class Inicio : Lfc.FormularioListado
	{
		public Inicio()
		{
                        this.ElementoTipo = typeof(Lbl.Comprobantes.Tipo);

			this.NombreTabla = "documentos_tipos";
                        this.OrderBy = "nombre";
                        this.KeyField = new Lfx.Data.FormField("id_tipo", "Cód.", Lfx.Data.InputFieldTypes.Serial, 0);
                        this.FormFields = new Lfx.Data.FormFieldCollection()
			{
				new Lfx.Data.FormField("nombre", "Nombre", Lfx.Data.InputFieldTypes.Text, 240),
				new Lfx.Data.FormField("letra", "Letra", Lfx.Data.InputFieldTypes.Text, 60),
				new Lfx.Data.FormField("mueve_stock", "Mueve Stock", Lfx.Data.InputFieldTypes.Bool, 120)
			};
		}
	}
}

