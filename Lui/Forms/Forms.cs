// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lui.Forms
{
	public enum TextCasing
	{
		None = 0,
		UpperCase = 1,
		LowerCase = 2,
		Caption = 3,
	}

	public enum DataTypes
	{
		FreeText = 0,
		Integer,
		Float,
		Money,
		Date,
		DateTime,
		Set,
	}

	public enum ImagePositions
	{
		Top = 0,
		Middle = 1
	}
	public enum SubLabelPositions
	{
		None = 0,
		Bottom = 1,
		Right = 2,
		LongBottom = 3
	}
	
	/// <summary>
	/// Miembros estáticos necesarios para el funcionamiento de los controles.
	/// </summary>
	internal static class PopUps
	{
		internal static DataSetHelp ODataSetHelp;
	}
}
