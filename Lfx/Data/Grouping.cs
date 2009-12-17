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
using System.Collections.Generic;
using System.Text;

namespace Lfx.Data
{
        public enum AggregationFunctions
        {
                Distinct,
                Sum,
                Count
        }

        public class Aggregate
        {
                public Lfx.Data.FormField Field;
                public AggregationFunctions Function = AggregationFunctions.Distinct;

                public double Sum;
                public int Count;

                public Aggregate(AggregationFunctions groupingType, string fieldName)
                {
                        this.Function = groupingType;
                        this.Field = new FormField(fieldName, fieldName);
                }

                public void Reset()
                {
                        this.ResetCounters();
                }

                public void ResetCounters()
                {
                        
                        this.Count = 0;
                        this.Sum = 0;
                }

                public override string ToString()
                {
                        return this.Function.ToString() + " on " + this.Field.ToString();
                }
        }

        public class Grouping
        {
                public Lfx.Data.FormField Field;
                public object LastValue = null;

                public Grouping(string fieldName)
                {
                        this.Field = new FormField(fieldName, fieldName);
                }

                public void Reset()
                {
                        this.LastValue = null;
                }
        }
}
