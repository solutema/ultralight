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
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lui.Forms
{
        /// <summary>
        /// Este comparador tiene funciones especiales para ordenar una ListView por columna, haciendo caso a tipos de datos especiales como fechas y números.
        /// Además, tiene la particularidad de que pone los datos en blanco al final de la lista y no al prinipio.
        /// Es decir que en números, los campos vacíos van después del 9 y no antes del 0 como corresponde,
        /// en nombres, los campos vacíos van después de la > y no antes de la A como corresponde, etc.
        /// Eso es para que sea más útil para ordenar listados.
        /// </summary>
        public class ListViewColumnSorter : System.Collections.IComparer
        {
                private string[] DateFormats = { Lfx.Types.Formatting.DateTime.ShortDatePattern, Lfx.Types.Formatting.DateTime.FullDateTimePattern, Lfx.Types.Formatting.DateTime.ShortMonthAndYearPattern };

                public Lfx.Data.InputFieldTypes DataType { get; set; }
                public int SortColumn { get; set; }
                public SortOrder SortOrder { get; set; }

                public ListViewColumnSorter()
                {
                        this.DataType = Lfx.Data.InputFieldTypes.Text;
                        this.SortColumn = 0;
                        this.SortOrder = SortOrder.None;
                }


                public int Compare(object i1, object i2)
                {
                        int CompareResult = 0;
                        ListViewItem Item1 = (ListViewItem)i1, Item2 = (ListViewItem)i2;
                        string Text1 = Item1.SubItems[SortColumn].Text;
                        string Text2 = Item2.SubItems[SortColumn].Text;

                        // Compare the two items
                        switch (DataType) {
                                case Lfx.Data.InputFieldTypes.Currency:
                                case Lfx.Data.InputFieldTypes.Integer:
                                case Lfx.Data.InputFieldTypes.Numeric:
                                case Lfx.Data.InputFieldTypes.Serial:
                                        decimal Val1 = 0, Val2 = 0;
                                        decimal.TryParse(Text1, out Val1);
                                        decimal.TryParse(Text2, out Val2);
                                        if (Text1 == string.Empty)
                                                // Los valores vacíos van siempre al final de la lista
                                                CompareResult = 1;
                                        else if (Text2 == string.Empty)
                                                CompareResult = -1;
                                        else if (Val1 > Val2)
                                                CompareResult = 1;
                                        else if (Val1 < Val2)
                                                CompareResult = -1;
                                        else
                                                CompareResult = 0;
                                        break;
                                case Lfx.Data.InputFieldTypes.Date:
                                case Lfx.Data.InputFieldTypes.DateTime:
                                case Lfx.Data.InputFieldTypes.YearMonth:
                                        DateTime Date1 = DateTime.MinValue;
                                        DateTime Date2 = DateTime.MinValue;
                                        DateTime.TryParseExact(Text1, DateFormats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces, out Date1);
                                        DateTime.TryParseExact(Text2, DateFormats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces, out Date2);

                                        if (Text1 == string.Empty)
                                                // Los valores vacíos van siempre al final de la lista
                                                CompareResult = 1;
                                        else if (Text2 == string.Empty)
                                                CompareResult = -1;
                                        else if (Date1 > Date2)
                                                CompareResult = 1;
                                        else if (Date1 < Date2)
                                                CompareResult = -1;
                                        else
                                                CompareResult = 0;
                                        break;
                                default:
                                        if (Text1 == string.Empty)
                                                // Los valores vacíos van siempre al final de la lista
                                                CompareResult = 1;
                                        else if (Text2 == string.Empty)
                                                CompareResult = -1;
                                        else
                                                CompareResult = string.Compare(Text1, Text2, true);
                                        break;
                        }

                        if (SortOrder == SortOrder.Ascending) {
                                return CompareResult;
                        } else if (SortOrder == SortOrder.Descending) {
                                return -CompareResult;
                        } else {
                                return 0;
                        }
                }
        }
}