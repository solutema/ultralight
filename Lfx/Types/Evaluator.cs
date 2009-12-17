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
using System.Globalization;

namespace Lfx.Types
{
	public static class Evaluator
	{
		public static double EvaluateDouble(string evalString)
		{
			try
			{
				return double.Parse(Evaluate(evalString), System.Globalization.CultureInfo.InvariantCulture);
			}
			catch
			{
				return 0;
			}
		}

		public static string Evaluate(string evalString)
		{
			string Expresion = evalString.Replace(" ", "").Replace(new string((char)13, 1), "").Replace(new string((char)10, 1), "").Replace(new string((char)9, 1), "").Replace(",", "");

			if (Expresion.Replace("(", "").Length != Expresion.Replace(")", "").Length)
				return "Falta abrir o cerrar paréntesis";

			do
			{
				int AbreParentesis = Expresion.IndexOf("(");

				if (AbreParentesis >= 0)
				{
					// Tiene paréntesis. La descompongo
					int ParentesisAbiertos = 1;

					for (int i = AbreParentesis + 1; i <= Expresion.Length - 1; i++)
					{
						switch (Expresion[i])
						{
							case '(':
								ParentesisAbiertos++;
								break;

							case ')':
								ParentesisAbiertos--;
								break;
						}

						if (ParentesisAbiertos == 0)
						{
							string SubExpresion = Expresion.Substring(AbreParentesis + 1, i - AbreParentesis - 1);
							Expresion = Expresion.Substring(0, AbreParentesis) + Evaluate(SubExpresion) + Expresion.Substring(i + 1, Expresion.Length - i - 1);
							break;
						}
					}
				}
				else
				{
					// No tiene parntesis. La evaluo
					int PosOperador = Expresion.IndexOf('+');

					if (PosOperador < 0)
					{
						PosOperador = Expresion.IndexOf('-');

						while (PosOperador >= 0)
						{
							// Detecto el - unario
							if (PosOperador == 0)
							{
								// Es unario, porque es el primer caracter de la expresin
								PosOperador = Expresion.IndexOf('-', PosOperador + 1);
							}
							else if (char.IsNumber(Expresion[PosOperador - 1]) == false)
							{
								// Es unario, porque el caracter antes no es un dgito 
								PosOperador = Expresion.IndexOf('-', PosOperador + 1);
							}
							else
							{
								// No es unario. Dejo de lupear
								break;
							}
						}
					}

					if (PosOperador < 0)
						PosOperador = Expresion.IndexOf('*');

					if (PosOperador < 0)
						PosOperador = Expresion.IndexOf('/');

					if (PosOperador < 0)
					{
						// Es un número
						return double.Parse(Expresion, NumberStyles.Float, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
					}
					else
					{
						// Es una expresin simple
						string Parte1 = Expresion.Substring(0, PosOperador);
						string Parte2 = Expresion.Substring(PosOperador + 1, Expresion.Length - PosOperador - 1);

						switch (Expresion[PosOperador])
						{
							case '+':
								return (double.Parse(Evaluate(Parte1), NumberStyles.Float, CultureInfo.InvariantCulture) + double.Parse(Evaluate(Parte2), NumberStyles.Float, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
							case '-':
								return (double.Parse(Evaluate(Parte1), NumberStyles.Float, CultureInfo.InvariantCulture) - double.Parse(Evaluate(Parte2), NumberStyles.Float, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
							case '*':
								return (double.Parse(Evaluate(Parte1), NumberStyles.Float, CultureInfo.InvariantCulture) * double.Parse(Evaluate(Parte2), NumberStyles.Float, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
							case '/':
								return (double.Parse(Evaluate(Parte1), NumberStyles.Float, CultureInfo.InvariantCulture) / double.Parse(Evaluate(Parte2), NumberStyles.Float, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
						}
					}
				}
			} while (true);
		}
	}
}