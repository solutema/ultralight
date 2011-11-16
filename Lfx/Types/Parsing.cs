#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lfx.Types
{
        public static class Parsing
        {
                /// <summary>
                /// Interpreta un valor de fecha en varios formatos diferentes.
                /// </summary>
                public static DateTime ParseSqlDateTime(string fecha)
                {
                        // Toma una fecha YYYY-MM-DD HH:MM:SS y devuelve un DateTime
                        string FechaTemp = fecha.Replace("  ", " ").Replace("/", "-").Trim();
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

                /// <summary>
                /// Interpreta un valor de fecha en varios formatos diferentes. Devuelve null para cadenas vacías o fechas inválidas.
                /// </summary>
                public static NullableDateTime ParseDate(string fecha)
                {
                        // Toma una fecha DD-MM-YYYY y devuelve un Date
                        string FechaTemp = fecha.Replace(" ", "").Replace("/", "-").Trim();

                        string[] Partes = FechaTemp.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        if (Partes.Length >= 1 && Partes[0].Length == 1)
                                Partes[0] = "0" + Partes[0];
                        if (Partes.Length >= 2 && Partes[1].Length == 1)
                                Partes[1] = "0" + Partes[1];
                        if (Partes.Length >= 3 && Partes[2].Length == 1)
                                Partes[2] = "0" + Partes[2];
                        
                        FechaTemp = string.Join("-", Partes);

                        string[] FormatosAceptados =
				{
                                        "yyyy-MM-dd",
					"dd-MM-yyyy",
					"d-M-yyyy",
					"dd-MM-yy",
					"d-M-yy",
                                        "ddMMyyyy",
                                        "ddMMyy",
                                        "ddMM",
                                        "yyyy-MM-dd HH:mm:ss",
                                        "yyyy-MM-dd HH:mm",
                                        "dd-MM-yyyy HH:mm:ss",
                                        "dd-MM-yyyy HH:mm",
                                        "dd-MM-yy HH:mm:ss",
                                        "dd-MM-yy HH:mm"
				};

                        try {
                                return new NullableDateTime(DateTime.ParseExact(FechaTemp, FormatosAceptados, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AllowWhiteSpaces));
                        } catch {
                                return null;
                        }
                }

                /// <summary>
                /// Devuelve true si la cadena tiene formato numérico.
                /// </summary>
                public static bool IsNumeric(string valor)
                {
                        try {
                                if (valor == null || valor == string.Empty)
                                        return false;

                                valor = valor.Replace("$", "").Trim();

                                string ValidChars = "-0123456789.,";
                                for (int i = 0; i < valor.Length; i++) {
                                        string CurChar = valor.Substring(i, 1);
                                        if (!ValidChars.Contains(CurChar))
                                                return false;
                                }
                                return true;
                        } catch {
                                return false;
                        }
                }

                /*
                /// <summary>
                /// Interpreta un valor de punto flotante. Devuelve cero para cualquier valor desconocido.
                /// </summary>
                public static double ParseDouble(string valor)
                {
                        string ValorMejorado = valor.Replace("$", "").Trim();

                        if (IsNumeric(ValorMejorado)) {
                                double Resultado = 0;
                                double.TryParse(ValorMejorado, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out Resultado);
                                return Resultado;
                        } else {
                                return 0;
                        }
                } */

                /// <summary>
                /// Interpreta un valor de punto flotante. Devuelve cero para cualquier valor desconocido.
                /// </summary>
                public static decimal ParseDecimal(string valor)
                {
                        if (valor == null || valor.Length == 0)
                                return 0;

                        string ValorMejorado = valor.Replace("$", "").Trim();

                        if (IsNumeric(ValorMejorado)) {
                                decimal Resultado = 0;
                                decimal.TryParse(ValorMejorado, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out Resultado);
                                return Resultado;
                        } else {
                                return 0;
                        }
                }


                /// <summary>
                /// Interpreta una cantidad de stock (actualmente un decimal). Devuelve cero para cualquier valor desconocido.
                /// </summary>
                public static decimal ParseStock(string valor)
                {
                        return ParseDecimal(valor);
                }

                /// <summary>
                /// Interpreta un valor monetario (actualemente un decimal). Devuelve cero para cualquier valor desconocido.
                /// </summary>
                public static decimal ParseCurrency(string valor)
                {
                        return ParseDecimal(valor);
                }
                

                /// <summary>
                /// Interpreta un valor booleano. Devuelve falso para cualquier valor desconocido.
                /// </summary>
                public static bool ParseBool(string valor)
                {
                        if (valor == null)
                                return false;

                        string ValorMayus = valor.ToUpperInvariant();
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
                                        return ParseInt(valor) != 0;
                        }
                }

                /// <summary>
                /// Interpreta un valor entero. Devuelve cero para cualquier valor desconocido.
                /// </summary>
                public static int ParseInt(string valor)
                {
                        if (valor == null || valor.Length == 0)
                                return 0;

                        double Resultado = 0;
                        double.TryParse(valor, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out Resultado);
                        if (Resultado > int.MaxValue)
                                return 0;
                        else
                                return System.Convert.ToInt32(Resultado);
                }
        }
}