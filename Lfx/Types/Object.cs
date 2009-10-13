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

                        if ((a is short || a is int || a is long)
                           && (b is short || b is int || b is long)) {
                                return System.Convert.ToInt64(a) == System.Convert.ToInt64(b);
                        } else if (b is double && a is double) {
                                return System.Convert.ToDouble(a) == System.Convert.ToDouble(b);
                        } else if (b is decimal && a is decimal) {
                                return System.Convert.ToDecimal(a) == System.Convert.ToDecimal(b);
                        } else if ((b is decimal && a is double) || (b is double && a is decimal)) {
                                return System.Convert.ToDecimal(a) == System.Convert.ToDecimal(b);
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
