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

namespace Lfx.Data
{
        public class TableStructure
        {
                public string Name;
                public System.Collections.Generic.Dictionary<string, ColumnDefinition> Columns;
                public System.Collections.Generic.Dictionary<string, IndexDefinition> Indexes;
                public System.Collections.Generic.Dictionary<string, ConstraintDefinition> Constraints;
                protected string CodePage;

                public TableStructure()
                {
                        Columns = new System.Collections.Generic.Dictionary<string, ColumnDefinition>();
                }

                public ColumnDefinition PrimaryKey
                {
                        get
                        {
                                foreach (ColumnDefinition Def in this.Columns.Values) {
                                        if (Def.PrimaryKey)
                                                return Def;
                                }
                                return null;
                        }
                }

                public override string ToString()
                {
                        if (Columns == null || Columns.Count == 0)
                                return "";

                        string FieldsSql = "", PrimaryKeys = "";
                        foreach (ColumnDefinition Col in Columns.Values) {
                                if (FieldsSql.Length == 0)
                                        FieldsSql = "  " + Col.Name + " " + Col.SqlDefinition();
                                else
                                        FieldsSql += "," + System.Environment.NewLine + "  " + Col.Name + " " + Col.SqlDefinition();

                                if (Col.PrimaryKey) {
                                        if (PrimaryKeys.Length == 0)
                                                PrimaryKeys = Col.Name;
                                        else
                                                PrimaryKeys += "," + Col.Name;
                                }
                        }

                        string TableSql = @"CREATE TABLE """ + this.Name + @""" (" + System.Environment.NewLine;
                        TableSql += FieldsSql;
                        if (PrimaryKeys.Length > 0)
                                TableSql += "," + System.Environment.NewLine + "  PRIMARY KEY (" + PrimaryKeys + ")";
                        TableSql += System.Environment.NewLine + ") $/CREATETABLE$;" + System.Environment.NewLine + System.Environment.NewLine;

                        return TableSql;
                }

                public System.Xml.XmlNode ToXml(System.Xml.XmlNode node)
                {
                        System.Xml.XmlDocument document;
                        if (node is System.Xml.XmlDocument)
                                document = (System.Xml.XmlDocument)node;
                        else
                                document = node.OwnerDocument;

                        System.Xml.XmlNode Res = document.CreateElement("Table");
                        node.AppendChild(Res);

                        Res.Attributes.Append(document.CreateAttribute("name"));
                        Res.Attributes["name"].Value = this.Name;

                        foreach (ColumnDefinition Col in Columns.Values) {
                                Res.AppendChild(Col.ToXml(Res));
                        }

                        if (Indexes != null) {
                                foreach (IndexDefinition Index in Indexes.Values) {
                                        Res.AppendChild(Index.ToXml(Res));
                                }
                        }

                        return Res;
                }

                public static bool operator ==(TableStructure t1, TableStructure t2)
                {
                        if (object.ReferenceEquals(t1, null) || object.ReferenceEquals(t2, null))
                                return false;

                        return t1.ToString() == t2.ToString();
                }
                public static bool operator !=(TableStructure t1, TableStructure t2)
                {
                        return !(t1.ToString() == t2.ToString());
                }

                public override int GetHashCode()
                {
                        return this.ToString().GetHashCode();
                }

                public override bool Equals(object obj)
                {
                        return base.Equals(obj);
                }

        }
}
