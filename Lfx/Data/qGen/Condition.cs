#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace qGen
{
        public class Condition
        {
                protected qGen.SqlModes m_Mode = qGen.SqlModes.Ansi;

                public Condition()
                {
                }

                public qGen.SqlModes Mode
                {
                        get
                        {
                                return m_Mode;
                        }
                        set
                        {
                                m_Mode = value;
                        }
                }

                public string ToString(qGen.SqlModes mode)
                {
                        m_Mode = mode;
                        return this.ToString();
                }
        }

        public class NestedCondition : Condition
        {
                public qGen.Where Where;

                public NestedCondition(Where where)
                {
                        this.Where = where;
                }

                public override string ToString()
                {
                        this.Where.m_Mode = this.m_Mode;
                        return "(" + this.Where.ToString() + ")";
                }
        }

        internal class SqlCondition : Condition
        {
                protected string Text = "";

                public SqlCondition()
                        : base()
                {
                }

                public SqlCondition(string text)
                        : this()
                {
                        this.Text = text;
                }

                public override string ToString()
                {
                        return this.Text;
                }
        }

        public class ComparisonCondition : Condition
        {
                protected string LeftValue = "";
                protected object m_RightValue = "", m_RightValue2 = "";
                public qGen.ComparisonOperators Operator = qGen.ComparisonOperators.Equals;

                public ComparisonCondition()
                        : base()
                {
                }

                public ComparisonCondition(string LeftValue, object RightValue)
                        : this(LeftValue, qGen.ComparisonOperators.Equals, RightValue)
                {
                }

                public ComparisonCondition(string leftValue, qGen.ComparisonOperators compOperator, object rightValue)
                        : this()
                {
                        this.LeftValue = leftValue;
                        this.Operator = compOperator;
                        this.m_RightValue = rightValue;
                }

                public ComparisonCondition(string leftValue, object minValue, object maxValue)
                        : this()
                {
                        this.LeftValue = leftValue;
                        this.Operator = ComparisonOperators.Between;
                        this.m_RightValue = minValue;
                        this.m_RightValue2 = maxValue;
                }

                public ComparisonCondition(qGen.SqlModes Mode, string LeftValue, qGen.ComparisonOperators compOperator, object RightValue)
                        : this(LeftValue, compOperator, RightValue)
                {
                        m_Mode = Mode;
                }

                public string RightValue
                {
                        get
                        {
                                if (m_RightValue == null || m_RightValue is DBNull) {
                                        return "NULL";
                                } else if (m_RightValue is double || m_RightValue is decimal) {
                                        return Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(m_RightValue));
                                } else if (m_RightValue is Lfx.Types.LDateTime) {
                                        return "'" + Lfx.Types.Formatting.FormatDateTimeSql(((Lfx.Types.LDateTime)(m_RightValue)).Value) + "'";
                                } else if (m_RightValue is DateTime) {
                                        return "'" + Lfx.Types.Formatting.FormatDateTimeSql((DateTime)m_RightValue) + "'";
                                } else if (m_RightValue is int || m_RightValue is long) {
                                        return m_RightValue.ToString();
                                } else if (m_RightValue is SqlExpression) {
                                        return m_RightValue.ToString();
                                } else if (m_RightValue is int[]) {
                                        string[] RightValStr = Array.ConvertAll<int, string>((int[])m_RightValue, new Converter<int, string>(Convert.ToString));
                                        return string.Join(",", RightValStr);
                                } else if (m_RightValue is string[]) {
                                        return "'" + string.Join("','", (string[])m_RightValue) + "'";
                                } else {
                                        return "'" + Lfx.Data.DataBase.EscapeString(m_RightValue.ToString(), m_Mode) + "'";
                                }
                        }
                        set
                        {
                                this.m_RightValue = value;
                        }
                }

                public string RightValue2
                {
                        get
                        {
                                if (m_RightValue2 == null || m_RightValue2 is DBNull) {
                                        return "NULL";
                                } else if (m_RightValue2 is double || m_RightValue2 is decimal) {
                                        return Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(m_RightValue2));
                                } else if (m_RightValue2 is Lfx.Types.LDateTime) {
                                        return "'" + Lfx.Types.Formatting.FormatDateTimeSql(((Lfx.Types.LDateTime)(m_RightValue2)).Value) + "'";
                                } else if (m_RightValue2 is DateTime) {
                                        return "'" + Lfx.Types.Formatting.FormatDateTimeSql((DateTime)m_RightValue2) + "'";
                                } else if (m_RightValue2 is int || m_RightValue2 is long) {
                                        return m_RightValue2.ToString();
                                } else if (m_RightValue2 is SqlExpression) {
                                        return m_RightValue2.ToString();
                                } else {
                                        return "'" + Lfx.Data.DataBase.EscapeString(m_RightValue2.ToString(), m_Mode) + "'";
                                }
                        }
                        set
                        {
                                this.m_RightValue2 = value;
                        }
                }

                public override string ToString()
                {
                        string Result = null;

                        switch (Operator) {
                                case qGen.ComparisonOperators.NullSafeEquals:
                                        Result = LeftValue + "<=>" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.Equals:
                                        if (m_RightValue == null)
                                                Result = LeftValue + " IS NULL";
                                        else
                                                Result = LeftValue + "=" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.GreaterOrEqual:
                                        Result = LeftValue + ">=" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.GreaterThan:
                                        Result = LeftValue + ">" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.InsensitiveLike:
                                        switch (m_Mode) {
                                                case qGen.SqlModes.PostgreSql:
                                                        Result = LeftValue + " ILIKE " + RightValue;
                                                        break;
                                                default:
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                        }
                                        break;

                                case qGen.ComparisonOperators.LessOrEqual:
                                        Result = LeftValue + "<=" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.LessThan:
                                        Result = LeftValue + "<" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.NotEquals:
                                        if (m_RightValue == null)
                                                Result = LeftValue + " IS NOT NULL";
                                        else
                                                Result = LeftValue + "<>" + RightValue;
                                        break;

                                case qGen.ComparisonOperators.SensitiveLike:
                                        switch (m_Mode) {
                                                case qGen.SqlModes.MySql:
                                                        Result = "BINARY " + LeftValue + " LIKE BINARY " + RightValue;
                                                        break;
                                                default:
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                        }
                                        break;

                                case qGen.ComparisonOperators.SoundsLike:
                                        switch (m_Mode) {
                                                case qGen.SqlModes.MySql:
                                                        // FIXME: Parece que el SOUNDS LIKE no funciona bien en MySql
                                                        // Result = LeftValue.Replace("%", "") & " SOUNDS LIKE " & RightValue.Replace("%", "")
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                                case qGen.SqlModes.PostgreSql:
                                                        Result = LeftValue + " ILIKE " + RightValue;
                                                        break;
                                                default:
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                        }
                                        break;

                                case qGen.ComparisonOperators.In:
                                        Result = LeftValue + " IN (" + RightValue + ")";
                                        break;

                                case qGen.ComparisonOperators.NotIn:
                                        Result = LeftValue + " NOT IN (" + RightValue + ")";
                                        break;

                                case ComparisonOperators.Between:
                                        Result = LeftValue + " BETWEEN " + this.RightValue + " AND " + this.RightValue2;
                                        break;
                        }

                        return Result;
                }
        }
}
