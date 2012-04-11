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

namespace Lfc
{
        public class Contador
        {
                public string Etiqueta = "Contador", Prefijo = null, Sufijo = null;
                public Lui.Forms.DataTypes DataType = Lui.Forms.DataTypes.Float;
                public decimal Total = 0, Min = 0, Max = 0;
                public int CantidadValores = 0;

                public Contador(string etiqueta, Lui.Forms.DataTypes dataType)
                {
                        this.Etiqueta = etiqueta;
                        this.DataType = dataType;
                }

                public Contador(string etiqueta, Lui.Forms.DataTypes dataType, string prefijo, string sufijo)
                        : this(etiqueta, dataType)
                {
                        this.Prefijo = prefijo;
                        this.Sufijo = sufijo;
                }

                public void Reset()
                {
                        this.CantidadValores = 0;
                        this.Total = 0;
                        this.Min = 0;
                        this.Max = 0;
                }

                public void AddValue(decimal val)
                {
                        this.CantidadValores++;
                        this.Total += val;
                        if (val < this.Min)
                                this.Min = val;
                        if (val > this.Max)
                                this.Max = val;
                }


                public void SetValue(decimal val)
                {
                        this.CantidadValores = 1;
                        this.Total = val;
                        if (val < this.Min)
                                this.Min = val;
                        if (val > this.Max)
                                this.Max = val;
                }


                public override string ToString()
                {
                        return this.Etiqueta + "(" + this.CantidadValores.ToString() + "): " + this.Total.ToString(); 
                }
        }
}
