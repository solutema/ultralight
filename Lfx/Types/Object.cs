// Copyright 2004-2010 South Bridge S.R.L.
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lfx.Types
{
        public class Object
        {
                /// <summary>
                /// Intenta comparar dos objetos para ver si son iguales en cuanto a su valor.
                /// </summary>
                public static bool ObjectsEqualByValue(object val1, object val2)
                {

                        object a = val1, b = val2;

                        //Convierto booleanos a enteros para poder comparar False == 0
                        //Convierto enums a enteros, por la misma razón

                        if (val1 == null)
                                return val2 == null;

                        if (val2 == null)
                                return val1 == null;

                        if (val1 is bool)
                                a = (bool)val1 ? 1 : 0;
                        else if (val1.GetType().IsEnum)
                                a = (int)val1;
                        else if (val1 is LDateTime)
                                a = ((LDateTime)(val1)).Value;

                        if (val2 is bool)
                                b = (bool)val2 ? 1 : 0;
                        else if (val2.GetType().IsEnum)
                                b = (int)val2;
                        else if (val2 is LDateTime)
                                b = ((LDateTime)(val2)).Value;

                        if (a == null && b is int && (int)b == 0) {
                                // Por la forma en la que trabaja FieldCollection[columName], digo que NULL==0 es true
                                return true;
                        } else if ((a is short || a is int || a is long)
                           && (b is short || b is int || b is long)) {
                                return System.Convert.ToInt64(a) == System.Convert.ToInt64(b);
                        } else if (b is double && a is double) {
                                return Math.Abs(System.Convert.ToDouble(a) - System.Convert.ToDouble(b)) < 0.01;
                        } else if (b is decimal && a is decimal) {
                                return Math.Abs(System.Convert.ToDecimal(a) - System.Convert.ToDecimal(b)) < 0.01m;
                        } else if ((b is decimal && a is double) || (b is double && a is decimal)) {
                                return Math.Abs(System.Convert.ToDecimal(a) - System.Convert.ToDecimal(b)) < 0.01m;
                        } else if (a is DateTime && b is DateTime) {
                                return System.Convert.ToDateTime(a) == System.Convert.ToDateTime(b);
                        } else if (a is string && b is string) {
                                return string.Equals(a as string, b as string, StringComparison.CurrentCulture);
                        } else {
                                return System.Convert.ToString(a) == System.Convert.ToString(b);
                        }
                }
        }
}
