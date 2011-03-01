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
using System.Linq;
using System.Text;

namespace Lfx.FileFormats.Office.Spreadsheet
{
        public class Row
        {
                public Sheet ParentSheet;
                public CellCollection Cells;
                public System.Drawing.Color BackColor = System.Drawing.Color.Empty;
                public System.Drawing.Color ForeColor = System.Drawing.Color.Empty;

                public Row()
                {
                        this.Cells = new CellCollection(this);
                }

                public Row(Sheet sheet)
                {
                        this.ParentSheet = sheet;
                        this.Cells = new CellCollection(this); 
                }

                public string GetFormattedGroup()
                {
                        return this.FormatCellValue(this.ParentSheet.ColumnHeaders.GroupingColumn, this.Group);
                }

                public object Group
                {
                        get
                        {
                                if (this.ParentSheet.ColumnHeaders.GroupingColumn < 0)
                                        return null;
                                else
                                        return this.Cells[this.ParentSheet.ColumnHeaders.GroupingColumn].Content;
                        }
                }

                public string FormatCellValue(int columnNumber, object cellValue)
                {
                        if (cellValue != null) {
                                string ColFormat = this.ParentSheet.ColumnHeaders[columnNumber].Format;
                                switch (cellValue.GetType().ToString()) {
                                        case "System.Single":
                                        case "System.Double":
                                                if (ColFormat != null)
                                                        return System.Convert.ToDouble(cellValue).ToString(ColFormat);
                                                else
                                                        return Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(cellValue), 2);
                                        case "System.Decimal":
                                                if (ColFormat != null)
                                                        return System.Convert.ToDecimal(cellValue).ToString(ColFormat);
                                                else
                                                        return Lfx.Types.Formatting.FormatNumber(System.Convert.ToDecimal(cellValue), 4);
                                        case "System.Integer":
                                        case "System.Int16":
                                        case "System.Int32":
                                                if (ColFormat != null)
                                                        return System.Convert.ToInt32(cellValue).ToString(ColFormat);
                                                else
                                                        return cellValue.ToString();
                                        case "System.DateTime":
                                                if (ColFormat != null) {
                                                        return System.Convert.ToDateTime(cellValue).ToString(ColFormat);
                                                } else {
                                                        switch (this.ParentSheet.ColumnHeaders[columnNumber].DataType) {
                                                                case Data.InputFieldTypes.Date:
                                                                        return System.Convert.ToDateTime(cellValue).ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);
                                                                default:
                                                                        return cellValue.ToString();
                                                        }
                                                }
                                        case "System.String":
                                                return cellValue.ToString();
                                        default:
                                                return cellValue.ToString();
                                }
                        } else {
                                return "";
                        }
                }

                public override string ToString()
                {
                        string Res = null;
                        foreach (Cell Cl in Cells) {
                                if (Res == null)
                                        Res = "Row cells: " + Cl.ToString();
                                else
                                        Res += "; " + Cl.ToString();
                        }
                        return Res;
                }
        }
}
