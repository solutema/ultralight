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
using System.Text;

namespace Lazaro.Pres.Spreadsheet
{
        public class Cell : System.IComparable<Cell>
        {
                public object Content = null;
                public object Formula = null;
                public Row ParentRow = null;
                public int ColumnNumber = 0;

                public Cell()
                {
                }

                public Cell(Row parent)
                {
                        this.ParentRow = parent;
                }

                public Cell(object content)
                        : this()
                {
                        this.Content = content;
                }

                public Cell(Formula formula)
                        : this()
                {
                        this.Formula = formula;
                }

                public Cell(Formula formula, object altContent)
                        : this()
                {
                        this.Formula = formula;
                        this.Content = altContent;
                }

                public override string ToString()
                {
                        if (this.Formula != null) {
                                return this.Formula.ToString();
                        } else {
                                return this.ParentRow.FormatCellValue(this.ColumnNumber, this.Content);
                        }
                }

                public int CompareTo(Cell other)
                {
                        if (this.Content == null || other.Content == null)
                                return 0;
                        else if (this.Content is double && other.Content is double)
                                return ((double)(this.Content)).CompareTo(other.Content);
                        else if (this.Content is decimal && other.Content is decimal)
                                return ((decimal)(this.Content)).CompareTo(other.Content);
                        else if (this.Content is int && other.Content is int)
                                return ((int)(this.Content)).CompareTo(other.Content);
                        else if (this.Content is string && other.Content is string)
                                return ((string)(this.Content)).CompareTo(other.Content);
                        else
                                return 0;
                }
        }
}
