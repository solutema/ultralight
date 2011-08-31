#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lfx.Data
{
        public enum FilterType
        {
                Set,
                Relation,
                Date,
                DateRange,
                NumericRange
        }


        public interface IFilter
        {
                string Label { get; set;  }
                string ColumnName { get; set; }

                object Value { get; set; }
                object Value2 { get; set; }

                object Control { get; set; }

                FilterType Type { get; }

                bool IsEmpty();
        }

        [Serializable]
        public class Filter : IFilter
        {
                public string Label { get; set; }
                public string ColumnName { get; set; }

                /// <summary>
                /// Obtiene o establece el valor actual del filtro.
                /// </summary>
                public object Value { get; set; }

                /// <summary>
                /// Obtiene o establece el segundo valor del filtro, para el caso de los filtros de rango que tienen 2 valores (por ejemplo mínimo/máximo o desde/hasta).
                /// </summary>
                public object Value2 { get; set; }

                // El control asociado a este filtro, cuando se lo presenta en un formulario
                public object Control { get; set; }

                protected FilterType m_Type;

                public Filter(string label, string columnName)
                {
                        this.Label = label;
                        this.ColumnName = columnName;
                }


                public FilterType Type
                {
                        get
                        {
                                return m_Type;
                        }
                }


                virtual public bool IsEmpty()
                {
                        return true;
                }
        }


        [Serializable]
        public class NumericRangeFilter : Filter
        {
                public decimal Min { get; set; }
                public decimal Max { get; set; }
        
                public int DecimalPlaces = 2;

                public NumericRangeFilter(string label, string columnName)
                        : base(label, columnName)
                {
                        this.m_Type = FilterType.NumericRange;
                }

                
                public NumericRangeFilter(string label, string columnName, int decimalPlaces)
                        : this(label, columnName)
                {
                        this.DecimalPlaces = decimalPlaces;
                        this.Value = 0m;
                        this.Value2 = 0m;
                }


                public decimal From
                {
                        get
                        {
                                return System.Convert.ToDecimal(this.Value);
                        }
                        set
                        {
                                this.Value = value;
                        }
                }


                public decimal To
                {
                        get
                        {
                                return System.Convert.ToDecimal(this.Value2);
                        }
                        set
                        {
                                this.Value2 = value;
                        }
                }


                override public bool IsEmpty()
                {
                        return this.From == 0 && this.To == 0;
                }
        }


        [Serializable]
        public class DateRangeFilter : Filter
        {
                public Lfx.Types.DateRange DateRange { get; set; }

                public DateRangeFilter(string label, string columnName)
                        : base(label, columnName)
                {
                        this.m_Type = FilterType.DateRange;
                }

                public DateRangeFilter(string label, string columnName, Lfx.Types.DateRange dateRange)
                        : this(label, columnName)
                {
                        this.DateRange = dateRange;
                }

                override public bool IsEmpty()
                {
                        return this.DateRange == null;
                }
        }


        [Serializable]
        public class SetFilter : Filter
        {
                [NonSerialized]
                public string[] SetData = null;

                public SetFilter(string label, string columnName)
                        : base(label, columnName)
                {
                        this.m_Type = FilterType.Set;
                }


                public SetFilter(string label, string columnName, string[] setData, string initialValue)
                        : this(label, columnName)
                {
                        this.SetData = setData;
                        this.CurrentValue = initialValue;
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


        [Serializable]
        public class RelationFilter : Filter
        {
                public Lfx.Data.Relation Relation { get; set; }

                public int ElementId { get; set; }

                public RelationFilter(string label, string columnName)
                        : base(label, columnName)
                {
                        this.m_Type = FilterType.Relation;
                }

                public RelationFilter(string label, Lfx.Data.Relation relation)
                        : this(label, relation.Column)
                {
                        this.Relation = relation;
                }


                override public bool IsEmpty()
                {
                        return this.Relation == null || this.ElementId == 0;
                }
        }
}
