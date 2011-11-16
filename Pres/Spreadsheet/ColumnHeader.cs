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

namespace Lazaro.Pres.Spreadsheet
{
        public class ColumnHeader
        {
                public string Text = null, Name = null, Format = null;
                public int Width = 0;
                public bool Printable = true;
                public Lfx.Types.StringAlignment TextAlignment = Lfx.Types.StringAlignment.Near;
                public Lfx.Data.InputFieldTypes DataType = Lfx.Data.InputFieldTypes.Text;
                public object TotalFunction = null;

                public ColumnHeader(string text)
                {
                        this.Text = text;
                }


                public ColumnHeader(string text, int width)
                        : this(text)
                {
                        this.Width = width;
                }

                public ColumnHeader(string text, int width, Lfx.Types.StringAlignment textAlignment)
                        : this(text, width)
                {
                        this.TextAlignment = textAlignment;
                }

                public override string ToString()
                {
                        return this.Name;
                }
        }
}
