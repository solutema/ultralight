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

                        // Compare the two items
                        switch (DataType) {
                                case Lfx.Data.InputFieldTypes.Currency:
                                case Lfx.Data.InputFieldTypes.Integer:
                                case Lfx.Data.InputFieldTypes.Numeric:
                                case Lfx.Data.InputFieldTypes.Serial:
                                        try {
                                                decimal Val1 = Convert.ToDecimal(Item1.SubItems[SortColumn].Text);
                                                decimal Val2 = Convert.ToDecimal(Item2.SubItems[SortColumn].Text);
                                                if (Val1 > Val2) {
                                                        CompareResult = 1;
                                                } else if (Val1 < Val2) {
                                                        CompareResult = -1;
                                                } else {
                                                        CompareResult = 0;
                                                }
                                        } catch {
                                                // Nada
                                        }
                                        break;
                                case Lfx.Data.InputFieldTypes.Date:
                                case Lfx.Data.InputFieldTypes.DateTime:
                                case Lfx.Data.InputFieldTypes.YearMonth:
                                        try {
                                                NullableDateTime Date1 = DateTime.ParseExact(Item1.SubItems[SortColumn].Text, DateFormats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                                                NullableDateTime Date2 = DateTime.ParseExact(Item2.SubItems[SortColumn].Text, DateFormats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                                                if(Date1 == null && Date2 == null) {
                                                        CompareResult = 0;
                                                } else if (Date2 == null && Date1 != null) {
                                                        CompareResult = 1;
                                                } else if (Date1 == null && Date2 != null) {
                                                        CompareResult = -1;
                                                } else if (Date1.Value > Date2.Value) {
                                                        CompareResult = 1;
                                                } else if (Date1.Value < Date2.Value) {
                                                        CompareResult = -1;
                                                } else {
                                                        CompareResult = 0;
                                                }
                                        } catch {
                                                CompareResult = 0;
                                        }
                                        break;
                                default:
                                        CompareResult = string.Compare(Item1.SubItems[SortColumn].Text, Item2.SubItems[SortColumn].Text, true);
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