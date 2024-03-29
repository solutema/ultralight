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

namespace Lfx.Data
{
        [Serializable]
        public class Relation
        {
                /// <summary>
                /// Obtiene o establece el nombre de la columna en la en la tabla de origen.
                /// </summary>
                public string Column { get; set; }

                /// <summary>
                /// Obtiene o establece el nombre de la tabla de destino (de la cual se obtienen los detalles).
                /// </summary>
                public string ReferenceTable { get; set; }

                /// <summary>
                /// Obtiene o establece el nombre de la columna de clave mediante la cual obtener el detalle en la tabla de destino.
                /// </summary>
                public string ReferenceColumn { get; set; }

                /// <summary>
                /// Obtiene o establece el nombre de la columna que contiene los detalles en la tabla de destino.
                /// </summary>
                public string DetailColumn { get; set; }

                public Relation()
                {
                }

                public Relation(string column, string referenceTable, string referenceColumn)
                        : this(column, referenceTable, referenceColumn, null)
                {
                }

                public Relation(string column, string referenceTable, string referenceColumn, string detailColumn)
                {
                        this.Column = column;
                        this.ReferenceTable = referenceTable;
                        this.ReferenceColumn = referenceColumn;

                        if (detailColumn == null)
                                this.DetailColumn = "nombre";
                        else
                                this.DetailColumn = detailColumn;
                }

                public bool IsEmpty()
                {
                        return this.ReferenceColumn == null
                                || this.ReferenceColumn.Length == 0
                                || this.ReferenceTable == null
                                || this.ReferenceTable.Length == 0
                                || this.DetailColumn == null
                                || this.DetailColumn.Length == 0;
                }
        }
}
