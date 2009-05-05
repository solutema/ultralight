// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
	public static class Strings
	{
		public static System.Collections.ArrayList SplitDelimitedString(string CurrentLine)
		{
			return SplitDelimitedString(CurrentLine, ',', Lfx.Types.ControlChars.Quote);
		}

		public static System.Collections.ArrayList SplitDelimitedString(string CurrentLine, char Delimiter)
		{
			return SplitDelimitedString(CurrentLine, Delimiter, Lfx.Types.ControlChars.Quote);
		}

		public static System.Collections.ArrayList SplitDelimitedString(string CurrentLine, char Delimiter, char Qualifier)
		{
			System.Collections.ArrayList splitDelimitedStringReturn = null;
			System.Collections.ArrayList SplitString = new System.Collections.ArrayList();
			bool CountDelimiter = true;
			int Total = 0;
			System.Text.StringBuilder Section = new System.Text.StringBuilder();

			for(int i = 1; i <= CurrentLine.Length; i++) {
				char Ch = CurrentLine[i - 1];

				if(Ch == Qualifier) {
					CountDelimiter = !CountDelimiter;
				} else if(Ch == Delimiter) {
					if(CountDelimiter) {
						//Add current section to collection
						SplitString.Add(Section.ToString());
						Section = new System.Text.StringBuilder();
						Total = Total + 1;
					}
				} else {
					Section.Append(Ch);
				}
			}

			//  Get the last field - as most files will not have an ending delimiter
			if(CountDelimiter) {
				//  Add current section to collection
				SplitString.Add(Section.ToString());
			}

			splitDelimitedStringReturn = SplitString;
			return splitDelimitedStringReturn;
		}

		public static string GetNextToken(ref string stringValue)
		{
			return GetNextToken(ref stringValue, ",");
		}

		public static string GetNextToken(ref string stringValue, string stringSeparator)
		{
			if(stringValue == null)
				return null;
			string getNextTokenReturn = null;
			int r = 0;
			r = stringValue.IndexOf(stringSeparator) + 1;

			if(r > 0) {
				getNextTokenReturn = stringValue.Substring(0, r - 1);
				int LongResto = stringValue.Length - r - (stringSeparator.Length - 1);
				stringValue = stringValue.Substring(stringValue.Length - LongResto, LongResto);
			} else {
				getNextTokenReturn = stringValue;
				stringValue = "";
			}

			return getNextTokenReturn;
		}


		public static bool ValueInCSV(string sCSV, string sValue, string sComa)
		{
			bool valueInCSVReturn = false;
			// Devuelve Verdadero si el valor sValue se encuentra dentro de la lista sCSV
			valueInCSVReturn = (sComa + sCSV + sComa).Replace(" ", "").IndexOf(sComa + sValue + sComa) != -1;
			return valueInCSVReturn;
		}

                /// <summary>
                /// Convierte una matriz de cadenas en una cadena conteniendo todos los elementos separados por comas (u otro separador)
                /// </summary>
		public static string Collection2CSV(System.Collections.ArrayList coleccion, string separador)
		{
			if(coleccion == null || coleccion.Count == 0) {
				return "";
			} else {
				System.Text.StringBuilder Res = new System.Text.StringBuilder();

				foreach(string Valor in coleccion) {
					if(Res.Length > 0)
						Res.Append(separador + Valor.TrimEnd());
					else
						Res.Append(Valor);
				}

				return Res.ToString();
			}
		}

                /// <summary>
                /// Convierte una matriz de enteros en una cadena conteniendo todos los elementos separados por comas (u otro separador)
                /// </summary>
                public static string Ints2CSV(int[] ints, string separador)
                {
                        if (ints == null || ints.Length == 0) {
                                return "";
                        } else {
                                System.Text.StringBuilder Res = new System.Text.StringBuilder();

                                foreach (int Valor in ints) {
                                        if (Res.Length > 0)
                                                Res.Append(separador + Valor.ToString());
                                        else
                                                Res.Append(Valor);
                                }

                                return Res.ToString();
                        }
                }


                /// <summary>
                /// Invierte una cadena, caracter por caracter
                /// </summary>
		public static string StrReverse(string cadena)
		{
			System.Text.StringBuilder Resultado = new System.Text.StringBuilder();

			for(int i = cadena.Length - 1; i >= 0; i--) {
				Resultado.Append(cadena[i]);
			}
			return Resultado.ToString();
		}

        	public static bool IsDate(string Fecha)
		{
			try {
				Lfx.Types.Parsing.ParseDate(Fecha);
				return true;
			}
			catch {
				return false;
			}
		}

		public static string GetMD5HashFromFile(string fileName)
		{
			System.IO.FileStream file = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
			System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
			byte[] retVal = md5.ComputeHash(file);
			file.Close();
			return System.Text.Encoding.Default.GetString(retVal);
		}

		public static string ULCase(string pCadena)
		{
			string sTemp = " " + pCadena.ToLower() + " ";

			char[] CaracteresSeparadores =
				{
					' ',
					'.',
                                        '(',
                                        '"',
					'-'
				};

			int r = 0;

			do {
				r = sTemp.IndexOfAny(CaracteresSeparadores, r) + 1;

				if(r > 0 && r < sTemp.Length) {
					sTemp = sTemp.Substring(0,
						r) + sTemp.Substring(r,
						1).ToUpper() + sTemp.Substring(r + 1,
						sTemp.Length - r - 1);
				}
			} while(r > 0);

			sTemp = sTemp.Replace(" De ", " de ");
			sTemp = sTemp.Replace(" Del ", " del ");
			sTemp = sTemp.Replace(" El ", " el ");
			sTemp = sTemp.Replace(" La ", " la ");
			sTemp = sTemp.Replace(" Pc ", " PC ");
			sTemp = sTemp.Replace(" En ", " en ");
			sTemp = sTemp.Replace(" Y ", " y ");
			sTemp = sTemp.Replace(" Srl ", " SRL ");
			sTemp = sTemp.Replace(" Sa ", " SA ");

			sTemp = sTemp.Substring(1, sTemp.Length - 2);
			if(sTemp.Length > 0)
				sTemp = sTemp.Substring(0, 1).ToUpper() + sTemp.Remove(0, 1);

			return sTemp;
		}

		public static bool IsNumericInt(string cadena)
		{
			double transTemp1 = 0;
			if(double.TryParse(cadena,
				System.Globalization.NumberStyles.Integer,
				System.Globalization.CultureInfo.InvariantCulture,
				out transTemp1)) {
				if(transTemp1 <= int.MaxValue && transTemp1 >= int.MinValue)
					return true;
				else
					return false;
			} else {
				return false;
			}
		}

		public static bool IsNumericFloat(string cadena)
		{
			double transTemp0 = 0;
			return double.TryParse(cadena,
				System.Globalization.NumberStyles.Float,
				System.Globalization.CultureInfo.InvariantCulture,
				out transTemp0);
		}

                public static bool ValidCBU(string Cbu)
                {
                        string MiCopia = Cbu.Replace("-", "").Replace(" ", "").Replace(".", "").Replace("/", "");
                        if (MiCopia.Length != 22)
                                return false;

                        int[] Ponderador = { 3, 9, 7, 1 };
                        int Verificador;

                        Verificador = 0;
                        string Bloque1 = MiCopia.Substring(0, 8);
                        for (int i = 0; i < 7; i++) {
                                Verificador += Lfx.Types.Parsing.ParseInt(Bloque1.Substring(i, 1)) * Ponderador[i % 4];
                        }
                        Verificador = (Verificador % 10) % 10;
                        if (Lfx.Types.Parsing.ParseInt(Bloque1.Substring(7, 1)) != Verificador)
                                return false;

                        Verificador = 0;
                        string Bloque2 = MiCopia.Substring(8, 14);
                        for (int i = 0; i < 13; i++) {
                                Verificador += Lfx.Types.Parsing.ParseInt(Bloque2.Substring(i, 1)) * Ponderador[i % 4];
                        }
                        Verificador = (10 - (Verificador % 10)) % 10;
                        if (Lfx.Types.Parsing.ParseInt(Bloque2.Substring(13, 1)) != Verificador)
                                return false;

                        return true;
                }

                public static bool ValidCUIT(string Cuit)
		{
			// Utiliza el digito verificador para determinar la validez de una CUIT
			// Devuelve Verdadero si la CUIT es válida
			// Espera la CUIT en formato XX-XXXXXXXX-X
			if(System.Text.RegularExpressions.Regex.IsMatch(Cuit, @"^\d{2}-\d{8}-\d{1}$")
				|| System.Text.RegularExpressions.Regex.IsMatch(Cuit, @"^\d{11}$")) {
				string sCUITPlana = Cuit.Replace("-", "");
				int Suma = 0;
				Suma += int.Parse(sCUITPlana.Substring(0, 1)) * 5;
				Suma += int.Parse(sCUITPlana.Substring(1, 1)) * 4;
				Suma += int.Parse(sCUITPlana.Substring(2, 1)) * 3;
				Suma += int.Parse(sCUITPlana.Substring(3, 1)) * 2;
				Suma += int.Parse(sCUITPlana.Substring(4, 1)) * 7;
				Suma += int.Parse(sCUITPlana.Substring(5, 1)) * 6;
				Suma += int.Parse(sCUITPlana.Substring(6, 1)) * 5;
				Suma += int.Parse(sCUITPlana.Substring(7, 1)) * 4;
				Suma += int.Parse(sCUITPlana.Substring(8, 1)) * 3;
				Suma += int.Parse(sCUITPlana.Substring(9, 1)) * 2;
				// El digito verificador es 11 menos el mdulo de la suma y 11
				int Verificador = 11 - (Suma % 11);

				switch(Verificador) {
					case 11:
						Verificador = 0;
						break;
					case 10:
						Verificador = 9;
						break;
				}
				return int.Parse(sCUITPlana.Substring(10, 1)) == Verificador;
			} else {
				return false;
			}
		}

		public static void WriteTextFile(string fileName, string content)
		{
			System.IO.BinaryWriter wr = new System.IO.BinaryWriter(new System.IO.FileStream(fileName, System.IO.FileMode.OpenOrCreate));
			wr.Write(System.Text.Encoding.Default.GetBytes(content));
			wr.Close();
		}

		public static string ReadTextFile(string sFileName)
		{
			string readTextFileReturn = null;
			System.IO.FileStream Archivo = new System.IO.FileStream(sFileName, System.IO.FileMode.OpenOrCreate);
			System.IO.StreamReader Lector = new System.IO.StreamReader(Archivo, System.Text.Encoding.Default);
			readTextFileReturn = Lector.ReadToEnd();
			Lector.Close();
			Archivo.Close();
			return readTextFileReturn;
		}

		public static string SimplifyText(string sTexto)
		{
			//Quita acentos y otros caracteres raros
			string res = sTexto;
			res = res.Replace("&", "");
			res = res.Replace("á", "a");
			res = res.Replace("é", "e");
			res = res.Replace("í", "i");
			res = res.Replace("ó", "o");
			res = res.Replace("ú", "u");
			res = res.Replace("ü", "u");
			res = res.Replace("ñ", "n");
			res = res.Replace("Á", "A");
			res = res.Replace("É", "E");
			res = res.Replace("Í", "I");
			res = res.Replace("Ó", "O");
			res = res.Replace("Ú", "U");
			res = res.Replace("Ü", "U");
			res = res.Replace("Ñ", "n");
			res = res.Replace(" ", "_");
			return res;
		}
	}
}
