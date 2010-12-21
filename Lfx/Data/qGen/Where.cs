#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
        public class Where : System.Collections.Generic.List<qGen.Condition>
        {
                public SqlModes SqlMode = SqlModes.Ansi;
                public AndOr Operator = AndOr.And;

                public Where()
                        : base()
                {
                }

                public Where(AndOr operand)
                        : this()
                {
                        this.Operator = operand;
                }


                public Where(qGen.Condition Condition)
                        : this()
                {
                        this.Add(Condition);
                }

                public Where(string columnName, object equalsValue)
                        : this(new ComparisonCondition(columnName, equalsValue))
                {
                }

                public Where(string columnName, ComparisonOperators compOperator, object equalsValue)
                        : this(new ComparisonCondition(columnName, compOperator, equalsValue))
                {
                }

                public void AddWithValue(string text)
                {
                        this.Add(new SqlCondition(text));
                }

                public void AddWithValue(Where where)
                {
                        this.Add(new NestedCondition(where));
                }

                public void AddWithValue(string leftValue, object rightValue)
                {
                        this.Add(new ComparisonCondition(leftValue, rightValue));
                }

                public void AddWithValue(string leftValue, qGen.ComparisonOperators compOperator, object rightValue)
                {
                        this.Add(new ComparisonCondition(leftValue, compOperator, rightValue));
                }

                public void AddWithValue(string leftValue, object minValue, object maxValue)
                {
                        this.Add(new ComparisonCondition(leftValue, minValue, maxValue));
                }

                public string ToString(SqlModes mode)
                {
                        this.SqlMode = mode;
                        return this.ToString();
                }

                public override string ToString()
                {
                        if (this.Count > 0) {
                                System.Text.StringBuilder Command = new System.Text.StringBuilder();

                                foreach (object Condition in this) {
                                        if (Condition != null) {
                                                if (Condition is Condition) {
                                                        ((Condition)(Condition)).Mode = this.SqlMode;
                                                        if (Operator == AndOr.And)
                                                                Command.Append(" AND ");
                                                        else
                                                                Command.Append(" OR ");

                                                        Command.Append(((Condition)(Condition)).ToString(this.SqlMode));
                                                } else if (Condition is NestedCondition) {
                                                        ((NestedCondition)(Condition)).Mode = this.SqlMode;
                                                        if (((NestedCondition)(Condition)).Where.Count > 0) {
                                                                if (Operator == AndOr.And)
                                                                        Command.Append(" AND ");
                                                                else
                                                                        Command.Append(" OR ");

                                                                Command.Append(((NestedCondition)(Condition)).ToString(this.SqlMode));
                                                        }
                                                } else if (System.Convert.ToString(Condition).Length > 0) {
                                                        if (Operator == AndOr.And)
                                                                Command.Append(" AND ");
                                                        else
                                                                Command.Append(" OR ");

                                                        Command.Append(System.Convert.ToString(Condition));
                                                }
                                        }
                                }

                                string CommandString = Command.ToString().TrimStart();

                                if (CommandString.Length > 0) {
                                        // Debería quedar slamente "condición", "cond AND cond", "cond AND cond AND cond", etc.
                                        // Me deshago de cosas invalidas como operadores sin condicion ("AND"),
                                        // operadores de más (AND cond AND cond), etc.
                                        if (CommandString == "AND" || CommandString == "OR") {
                                                return "";
                                        } else if (CommandString.Length >= 4 && CommandString.Substring(0, 4) == "AND ") {
                                                CommandString = CommandString.Substring(4, CommandString.Length - 4);
                                        } else if (CommandString.Length >= 3 && CommandString.Substring(0, 3) == "OR ") {
                                                CommandString = CommandString.Substring(3, CommandString.Length - 3);
                                        }
                                }

                                if (CommandString.Length > 0) {
                                        return "(" + CommandString + ")";
                                } else {
                                        return "";
                                }
                        } else {
                                return "TRUE";
                        }
                }

                public Where Clone()
                {
                        Where Res = new Where(this.Operator);
                        Res.SqlMode = this.SqlMode;
                        if (this.Count > 0)
                                Res.AddRange(this);
                        return Res;
                }
        }
}
