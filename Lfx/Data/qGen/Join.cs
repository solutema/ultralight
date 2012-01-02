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

namespace qGen
{
        [Serializable]
        public class Join
        {
                public string Table {get;set;}
                public string Alias { get; set; }
                public string On { get; set; }
                public JoinTypes JoinType = JoinTypes.LeftJoin;

                public Join(string table, string on)
                {
                        if (table.IndexOf(' ') >= 0) {
                                string[] Partes = table.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                                this.Table = Partes[0];
                                this.Alias = Partes[1];
                        } else {
                                this.Table = table;
                        }
                        this.On = on;
                }


                public Join(string table, string on, JoinTypes joinType)
                        : this(table, on)
                {
                        this.JoinType = joinType;
                }


                public Join(Lfx.Data.Relation relation)
                        : this(relation.ReferenceTable, relation.Column + "=" + relation.ReferenceTable + "." + relation.ReferenceColumn)
                {
                }


                public string TableAndAlias
                {
                        get
                        {
                                if(this.Alias != null && this.Alias.Length > 0) {
                                        return this.Table + " " + this.Alias;
                                } else {
                                        return this.Table;
                                }
                        }
                }

                public override string ToString()
                {
                        System.Text.StringBuilder Res = new System.Text.StringBuilder();
                        switch (this.JoinType) {
                                case JoinTypes.ImplicitJoin:
                                        Res.Append("," + this.TableAndAlias);
                                        break;
                                case JoinTypes.LeftJoin:
                                        Res.Append(" LEFT JOIN " + this.TableAndAlias);
                                        break;
                                case JoinTypes.CrossJoin:
                                        Res.Append(" CROSS JOIN " + this.TableAndAlias);
                                        break;
                                case JoinTypes.FullOuterJoin:
                                        Res.Append(" FULL OUTER JOIN " + this.TableAndAlias);
                                        break;
                                case JoinTypes.InnerJoin:
                                        Res.Append(" INNER JOIN " + this.TableAndAlias);
                                        break;
                                case JoinTypes.LeftOuterJoin:
                                        Res.Append(" LEFT OUTER JOIN " + this.TableAndAlias);
                                        break;
                                case JoinTypes.NaturalJoin:
                                        Res.Append(" NATURAL JOIN " + this.TableAndAlias);
                                        break;
                                case JoinTypes.RightOuterJoin:
                                        Res.Append(" RIGHT OUTER JOIN " + this.TableAndAlias);
                                        break;
                        }

                        if (On != null && On.Length > 0)
                                Res.Append(" ON " + On);

                        return Res.ToString();
                }
        }
}