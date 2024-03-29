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

namespace Lazaro.Pres.Filters
{
        [Serializable]
        public class SetFilter : Filter
        {
                [NonSerialized]
                public string[] SetData = null;

                public SetFilter(string label, string columnName)
                        : base(label, columnName)
                {
                }


                public SetFilter(string label, string columnName, string[] setData, string initialValue)
                        : this(label, columnName)
                {
                        this.SetData = setData;
                        this.CurrentValue = initialValue;
                }


                public SetFilter(string label, string columnName, IDictionary<int, string> setValues, int initialValue)
                        : this(label, columnName)
                {
                        this.SetData = new string[setValues.Count];
                        int i = 0;
                        foreach (KeyValuePair<int, string> Val in setValues) {
                                this.SetData[i++] = Val.Value + "|" + Val.Key.ToString();
                        }
                        this.CurrentValue = initialValue.ToString();
                }


                public string CurrentValue
                {
                        get
                        {
                                return System.Convert.ToString(this.Value);
                        }
                        set
                        {
                                this.Value = value;
                        }
                }


                override public bool IsEmpty()
                {
                        return this.Value == null;
                }
        }
}
