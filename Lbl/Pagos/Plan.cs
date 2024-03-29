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
using System.Text;

namespace Lbl.Pagos
{
        /// <summary>
        /// Representa un plan de una tarjeta de crédito (p. ej.: "Plan 12 cuotas sin interés").
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Plan", Grupo = "Cobros y pagos")]
        [Lbl.Atributos.Datos(TablaDatos = "tarjetas_planes", CampoId = "id_plan")]
        [Lbl.Atributos.Presentacion()]
	public class Plan : ElementoDeDatos
	{
		//Heredar constructor
		public Plan(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Plan(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Plan(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public decimal Comision
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("comision");
                        }
                        set
                        {
                                this.Registro["comision"] = value;
                        }
                }
	}
}
