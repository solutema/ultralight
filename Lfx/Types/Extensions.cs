#region License
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
#endregion

using System;
using System.Runtime.CompilerServices;

namespace Lfx.Types
{
        /// <summary>
        /// Métodos de extension para el tipo Int.
        /// </summary>
        public static class Extensions
        {
                public static int SafeParseInt(this string s)
                {
                        if (s == null || s.Length == 0)
                                return 0;
                        double Resultado = 0;
                        double.TryParse(s, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out Resultado);
                        if (Resultado > int.MaxValue)
                                return 0;
                        else
                                return System.Convert.ToInt32(Resultado);
                }

                public static double SafeParseDouble(this string s)
                {
                        double Resultado = 0;
                        double.TryParse(s, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out Resultado);
                        return Resultado;
                }

                public static bool SafeParseBool(this string s)
                {
                        if (s == null)
                                return false;

                        string ValorMayus = s.ToUpperInvariant();
                        switch (ValorMayus) {
                                case "SI":
                                case "YES":
                                case "VERDADERO":
                                case "TRUE":
                                        return true;
                                case "NO":
                                case "FALSO":
                                case "FALSE":
                                        return false;
                                default:
                                        return Lfx.Types.Parsing.ParseInt(s) != 0;
                        }
                }

                public static LDateTime SafeParseDateTime(this string s)
                {
                        // Toma una fecha DD-MM-YYYY y devuelve un Date
                        string FechaTemp = s.Replace("  ", " ").Replace("/", "-").Trim();
                        string[] FormatosAceptados =
				{
                                        "yyyy-MM-dd",
					"dd-MM-yyyy",
					"d-M-yyyy",
					"dd-MM-yy",
					"d-M-yy",
                                        "yyyyMMdd",
                                        "yyMMdd",
				};

                        try {
                                return new LDateTime(DateTime.ParseExact(FechaTemp, FormatosAceptados, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces));
                        } catch {
                                return null;
                        }
                }

                /// <summary>
                /// Toma una fecha YYYY-MM-DD HH:MM:SS y devuelve un DateTime
                /// </summary>
                public static DateTime SafeParseSqlDateTime(this string s)
                {
                        string FechaTemp = s.Replace("  ", " ").Replace("/", "-").Trim();
                        string[] FormatosAceptados =
				{
					@"yyyy\-MM\-dd HH\:mm\:ss",
					@"yy\-MM\-dd HH\:mm\:ss",
					@"yyyy\-MM\-dd HH\:mm",
					@"yyyy\-MM\-dd",
					"yyyyMMddHHmmss",
					"yyyyMMdd HHmmss"
				};

                        return DateTime.ParseExact(FechaTemp,
                            FormatosAceptados,
                            System.Globalization.DateTimeFormatInfo.InvariantInfo,
                            System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                }
        }
}
