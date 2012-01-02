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

namespace Lazaro.Pres.Listings
{
        /// <summary>
        /// Define los datos para emitir un listado.
        /// </summary>
        [Serializable]
        public class Listing
        {
                public Type ElementoTipo { get; set; }

                public string TableName { get; set; }
                public Lazaro.Pres.Field KeyColumnName { get; set; }
                public string DetailColumnName { get; set; }
                public Lazaro.Pres.FieldCollection Columns { get; set; }
                public Lazaro.Pres.FieldCollection ExtraSearchColumns { get; set; }
                public Lazaro.Pres.FieldCollection SortColumns { get; set; }
                public Filters.FilterCollection Filters { get; set; }

                public Lazaro.Pres.Field GroupBy { get; set; }
                public string OrderBy { get; set; }
                public qGen.JoinCollection Joins = new qGen.JoinCollection();

                public qGen.Where Having { get; set; }
                public qGen.Where Where { get; set; }
        }
}
