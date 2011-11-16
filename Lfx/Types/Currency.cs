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
	public static class Currency
	{
		// La moneda utilizada de manera predeterminada en el sistema
		// Es un id_moneda de la tabla "monedas" (3 = pesos)
                public static decimal Truncate(decimal number, int decimals)
		{
			long Expo = System.Convert.ToInt64(Math.Pow(10, decimals));
			return Math.Truncate(number * Expo) / Expo;
		}


                public static decimal QuitarIva(decimal importe, decimal alicuota)
                {
                        decimal ImporteOriginal = importe / (1 + alicuota / 100);
                        decimal Iva = Math.Round(importe - ImporteOriginal, 4);

                        ImporteOriginal = Math.Round(importe - Iva, 4);

                        return ImporteOriginal;
                }
	}
}
