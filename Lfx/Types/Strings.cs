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
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lfx.Types
{
	public static class Strings
	{
		public static IList<string> SplitDelimitedString(string text)
		{
			return SplitDelimitedString(text, ",", "\"");
		}

                public static IList<string> SplitDelimitedString(string text, string delimiter)
		{
                        return SplitDelimitedString(text, delimiter, "\"");
		}

                public static IList<string> SplitDelimitedString(string text, string delimiter, string qualifier)
		{
                        string Statement = String.Format("{0}(?=(?:[^{1}]*{1}[^{1}]*{1})*(?![^{1}]*{1}))", Regex.Escape(delimiter), Regex.Escape(qualifier));

                        RegexOptions Options = RegexOptions.Compiled | RegexOptions.Multiline;
                        Regex Expression = new Regex(Statement, Options);
                        return Expression.Split(text);
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
