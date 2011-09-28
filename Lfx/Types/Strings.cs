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

namespace Lfx.Types
{
	public static class Strings
	{
		public static IList<string> SplitDelimitedString(string CurrentLine)
		{
			return SplitDelimitedString(CurrentLine, ',', Lfx.Types.ControlChars.Quote);
		}

                public static IList<string> SplitDelimitedString(string CurrentLine, char Delimiter)
		{
			return SplitDelimitedString(CurrentLine, Delimiter, Lfx.Types.ControlChars.Quote);
		}

                public static IList<string> SplitDelimitedString(string CurrentLine, char Delimiter, char Qualifier)
		{
                        IList<string> Result = new List<string>();

                        if (CurrentLine == null)
                                return Result;

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
						Result.Add(Section.ToString());
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
				Result.Add(Section.ToString());
			}

                        return Result;
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


		public static bool ValueInCsv(string csv, string strVal, string separador)
		{
			bool valueInCSVReturn = false;
			// Devuelve Verdadero si el valor sValue se encuentra dentro de la lista sCSV
			valueInCSVReturn = (separador + csv + separador).Replace(" ", "").IndexOf(separador + strVal + separador) != -1;
			return valueInCSVReturn;
		}

		public static string SHA256(string text)
		{
			System.Security.Cryptography.SHA256 Proveedor = new System.Security.Cryptography.SHA256Managed();
			byte[] HashBinario = Proveedor.ComputeHash(System.Text.Encoding.Default.GetBytes(text));
                        System.Text.StringBuilder HashTexto = new System.Text.StringBuilder();
                        foreach (byte b in HashBinario) {
                                HashTexto.Append(b.ToString("x2").ToLower());
                        }
			return HashTexto.ToString();
		}


                public static bool EsCbuValida(string cbu)
                {
                        string MiCopia = cbu.Replace("-", "").Replace(" ", "").Replace(".", "").Replace("/", "");
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

                public static bool EsCuitValido(string Cuit)
		{
			// Utiliza el digito verificador para determinar la validez de una CUIT
			// Devuelve Verdadero si la CUIT es válida
			// Espera la CUIT en formato XX-XXXXXXXX-X
			if(System.Text.RegularExpressions.Regex.IsMatch(Cuit, @"^\d{2}-\d{8}-\d{1}$")
				|| System.Text.RegularExpressions.Regex.IsMatch(Cuit, @"^\d{11}$")) {
				string CuitPlana = Cuit.Replace("-", "");
				int Suma = 0;
				Suma += int.Parse(CuitPlana.Substring(0, 1)) * 5;
				Suma += int.Parse(CuitPlana.Substring(1, 1)) * 4;
				Suma += int.Parse(CuitPlana.Substring(2, 1)) * 3;
				Suma += int.Parse(CuitPlana.Substring(3, 1)) * 2;
				Suma += int.Parse(CuitPlana.Substring(4, 1)) * 7;
				Suma += int.Parse(CuitPlana.Substring(5, 1)) * 6;
				Suma += int.Parse(CuitPlana.Substring(6, 1)) * 5;
				Suma += int.Parse(CuitPlana.Substring(7, 1)) * 4;
				Suma += int.Parse(CuitPlana.Substring(8, 1)) * 3;
				Suma += int.Parse(CuitPlana.Substring(9, 1)) * 2;
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
				return int.Parse(CuitPlana.Substring(10, 1)) == Verificador;
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

                public static bool Like(string text, string patterns)
                {
                        if (patterns == null)
                                return false;

                        string[] Patterns = patterns.Split(new string[] { ";", System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string Pattern in Patterns) {
                                string RegExSafePattern = System.Text.RegularExpressions.Regex.Escape(Pattern);
                                string FinalRegExPattern = RegExSafePattern.Replace(@"\*", ".+").Replace(@"\?", ".");
                                System.Text.RegularExpressions.Regex RegExPattern = new System.Text.RegularExpressions.Regex("^" + FinalRegExPattern + "$");
                                if (RegExPattern.IsMatch(text))
                                        return true;
                        }
                        return false;
                }
	}
}
