// Copyright 2004-2009 South Bridge S.R.L.
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
        public class IndexDefinition
        {
                public string TableName;
                public string Name;
                public string[] Columns;
                public bool Unique, Primary;

                public IndexDefinition(string tableName)
                {
                        TableName = tableName;
                }

                public System.Xml.XmlNode ToXml(System.Xml.XmlNode node)
                {
                        System.Xml.XmlDocument document;
                        if (node is System.Xml.XmlDocument)
                                document = (System.Xml.XmlDocument)node;
                        else
                                document = node.OwnerDocument;

                        System.Xml.XmlNode Res = document.CreateElement("Index");

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("table"));
                        Res.Attributes["table"].Value = this.TableName;

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("name"));
                        Res.Attributes["name"].Value = this.Name;

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("columns"));
                        Res.Attributes["columns"].Value = string.Join(",", this.Columns);

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("unique"));
                        Res.Attributes["unique"].Value = this.Unique ? "1" : "0";

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("primary"));
                        Res.Attributes["primary"].Value = this.Primary ? "1" : "0";

                        node.AppendChild(Res);

                        return Res;
                }

                public string CommaSeparatedColumns()
                {
                        return "\"" + String.Join(",", this.Columns).Replace(",", "\",\"") + "\"";
                }

                public string SqlDefinition()
                {
                        if (this.Primary) {
                                return "PRIMARY KEY (" + this.CommaSeparatedColumns() + ")";
                        } else {
                                string Res = "INDEX \"" + this.Name + "\" (" + this.CommaSeparatedColumns() + ")"; ;
                                if (this.Unique)
                                        Res = "UNIQUE " + Res;
                                return Res;
                        }
                }

                public static bool operator ==(IndexDefinition f1, IndexDefinition f2)
                {
                        if (object.ReferenceEquals(f1, null) && object.ReferenceEquals(f2, null))
                                return true;
                        if (object.ReferenceEquals(f1, null) || object.ReferenceEquals(f2, null))
                                return false;

                        return f1.TableName == f2.TableName
                                && f1.ToString() == f2.ToString();
                }

                public static bool operator !=(IndexDefinition f1, IndexDefinition f2)
                {
                        return !(f1 == f2);
                }

                public override int GetHashCode()
                {
                        return base.GetHashCode();
                }

                public override bool Equals(object obj)
                {
                        return base.Equals(obj);
                }

                public override string ToString()
                {
                        string Res = this.Name + ": " + this.TableName + " (" + string.Join(",", this.Columns) + ")";
                        if (this.Primary)
                                Res += " primary";
                        if (this.Primary)
                                Res += " unique";
                        return Res;
                }
        }
}
