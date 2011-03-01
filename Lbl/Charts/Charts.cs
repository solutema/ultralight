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

namespace Lbl.Charts
{
        public class Serie
        {
                public Element[] Elements = null;
                public string Name = null;
                public System.Drawing.Color Color = System.Drawing.Color.Black;

                public Serie(string name, Element[] elements)
                {
                        this.Name = name;
                        this.Elements = elements;
                        System.Random r = new System.Random();
                        this.Color = System.Drawing.Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                }

                public Serie(string name, Element[] elements, System.Drawing.Color color)
                {
                        this.Name = name;
                        this.Elements = elements;
                        this.Color = color;
                }

                public Serie(string name)
                {
                        this.Name = name;
                        System.Random r = new System.Random();
                        this.Color = System.Drawing.Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                }

                public decimal GetSum()
                {
                        decimal Sum = 0;
                        foreach (Element El in this.Elements) {
                                if (El != null)
                                        Sum += El.Value;
                        }
                        return Sum;
                }
        }

        public class Element
        {
                public decimal Value = 0;
                public string Label = null;

                public Element()
                {
                }

                public Element(decimal value, string label)
                {
                        this.Value = value;
                        this.Label = label;
                }
        }
}
