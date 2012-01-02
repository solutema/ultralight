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

namespace Lfx.Data
{
        [Serializable]
        public class ColumnDefinition
        {
                public string Name;
                public DbTypes FieldType;
                public int Lenght, Precision;
                public bool Nullable, PrimaryKey, Unsigned;
                public string DefaultValue = null;

                // Propiedades que tienen que ver con la representación
                public string Label, Section;
                private InputFieldTypes m_InputFieldType;
                public bool Required = false;
                public Lfx.Data.Relation Relation;

                public ColumnDefinition()
                {
                }

                public ColumnDefinition(string name, DbTypes fieldType)
                {
                        this.Name = name;
                        this.FieldType = fieldType;
                }

                public override string ToString()
                {
                        return this.Name + " " + this.SqlDefinition();
                }

                public string SqlType()
                {
                        string Def = "";
                        switch (FieldType) {
                                case DbTypes.Serial:
                                        return "$SERIAL$";
                                case DbTypes.Relation:
                                        Def = "MEDIUMINT";
                                        break;
                                case DbTypes.DateTime:
                                        Def = "$DATETIME$";
                                        break;
                                case DbTypes.VarChar:
                                        Def = "VARCHAR";
                                        break;
                                case DbTypes.Integer:
                                        Def = "INTEGER";
                                        break;
                                case DbTypes.MediumInt:
                                        Def = "$MEDIUMINT$";
                                        break;
                                case DbTypes.SmallInt:
                                        Def = "$SMALLINT$";
                                        break;
                                case DbTypes.TinyInt:
                                        Def = "$TINYINT$";
                                        break;
				case DbTypes.Currency:
                                case DbTypes.Numeric:
                                        Def = "NUMERIC";
                                        break;
                                case DbTypes.Blob:
                                        Def = "$BLOB$";
                                        break;
                                case DbTypes.Text:
                                        Def = "TEXT";
                                        break;
                        }

                        if (this.Lenght > 0) {
                                Def += "(" + this.Lenght.ToString();
                                if (this.Precision > 0)
                                        Def += "," + this.Precision.ToString();
                                Def += ")";
                        }
                        return Def;
                }

                public InputFieldTypes InputFieldType
                {
                        get
                        {
                                return m_InputFieldType;
                        }
                        set
                        {
                                this.m_InputFieldType = value;
                                switch (this.m_InputFieldType) {
                                        case InputFieldTypes.AlphanumericSet:
                                                this.FieldType = DbTypes.VarChar;
                                                break;
                                        case InputFieldTypes.Binary:
                                                this.FieldType = DbTypes.Blob;
                                                break;
                                        case InputFieldTypes.Bool:
                                                this.FieldType = DbTypes.SmallInt;
                                                break;
                                        case InputFieldTypes.Currency:
                                                this.FieldType = DbTypes.Currency;
                                                break;
                                        case InputFieldTypes.Date:
                                        case InputFieldTypes.DateTime:
                                                this.FieldType = DbTypes.DateTime;
                                                break;
                                        case InputFieldTypes.Image:
                                                this.FieldType = DbTypes.Blob;
                                                break;
                                        case InputFieldTypes.Integer:
                                                this.FieldType = DbTypes.Integer;
                                                break;
                                        case InputFieldTypes.Memo:
                                                this.FieldType = DbTypes.Text;
                                                break;
                                        case InputFieldTypes.Numeric:
                                                this.FieldType = DbTypes.Numeric;
                                                break;
                                        case InputFieldTypes.NumericSet:
                                                this.FieldType = DbTypes.SmallInt;
                                                break;
                                        case InputFieldTypes.Relation:
                                                this.FieldType = DbTypes.MediumInt;
                                                break;
                                        case InputFieldTypes.Serial:
                                                this.FieldType = DbTypes.Serial;
                                                break;
                                        case InputFieldTypes.Text:
                                                this.FieldType = DbTypes.VarChar;
                                                break;
                                        default:
                                                throw new NotImplementedException("Lfx.Data.ColumnDefinition.InputFieldType: Falta implementar " + this.m_InputFieldType.ToString());
                                }
                        }
                }


                public string SqlDefinition()
                {
                        string Def = this.SqlType();

                        if (this.FieldType != DbTypes.Serial) {
                                if (this.Unsigned)
                                        Def += " UNSIGNED";

                                if (this.Nullable == false)
                                        Def += " NOT NULL";

                                switch (FieldType) {
                                        case DbTypes.Text:
                                        case DbTypes.Blob:
                                                // No pueden tener default
                                                break;
                                        case DbTypes.VarChar:
                                                if (this.DefaultValue == null)
                                                        Def += " DEFAULT ''";	//Default to empty string
                                                else if (this.DefaultValue == "NULL")
                                                        Def += " DEFAULT NULL";
                                                else
                                                        Def += " DEFAULT '" + this.DefaultValue + "'";
                                                break;
                                        case DbTypes.Currency:
                                        case DbTypes.Integer:
                                        case DbTypes.Numeric:
                                        case DbTypes.SmallInt:
                                        case DbTypes.MediumInt:
                                        case DbTypes.TinyInt:
                                                if (this.DefaultValue == null) {
                                                        if(this.Nullable)
                                                                Def += " DEFAULT NULL";	// Nullable columns default to null
                                                        else
                                                                Def += " DEFAULT 0";	// Otherwise, default to zero
                                                } else if (this.DefaultValue == "NULL") {
                                                        Def += " DEFAULT NULL";
                                                } else {
                                                        Def += " DEFAULT '" + this.DefaultValue + "'";
                                                }
                                                break;  
                                        default:
                                                if (this.DefaultValue != null && this.DefaultValue.Length > 0)
                                                        Def += " DEFAULT " + this.DefaultValue;
                                                break;
                                }
                        }

                        if (this.PrimaryKey)
                                Def += " PRIMARY KEY";
                        return Def;
                }

                public System.Xml.XmlNode ToXml(System.Xml.XmlNode node)
                {
                        System.Xml.XmlDocument document;
                        if (node is System.Xml.XmlDocument)
                                document = (System.Xml.XmlDocument)node;
                        else
                                document = node.OwnerDocument;

                        System.Xml.XmlNode Res = document.CreateElement("Column");

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("name"));
                        Res.Attributes["name"].Value = this.Name;

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("datatype"));
                        Res.Attributes["datatype"].Value = this.FieldType.ToString();

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("nullable"));
                        Res.Attributes["nullable"].Value = this.Nullable ? "1" : "0";

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("primary_key"));
                        Res.Attributes["primary_key"].Value = this.PrimaryKey ? "1" : "0";

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("lenght"));
                        Res.Attributes["lenght"].Value = this.Lenght.ToString();

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("precision"));
                        Res.Attributes["precision"].Value = this.Precision.ToString();

                        Res.Attributes.Append(node.OwnerDocument.CreateAttribute("default"));
                        Res.Attributes["default"].Value = this.DefaultValue;

                        node.AppendChild(Res);

                        return Res;
                }

                public static bool operator ==(ColumnDefinition f1, ColumnDefinition f2)
                {
                        if (object.ReferenceEquals(f1, null) && object.ReferenceEquals(f2, null))
                                return true;
                        if (object.ReferenceEquals(f1, null) || object.ReferenceEquals(f2, null))
                                return false;

                        string s1 = f1.ToString(), s2 = f2.ToString();

                        return f1.PrimaryKey == f2.PrimaryKey
                                && f1.Unsigned == f2.Unsigned
                                && f1.Nullable == f2.Nullable
                                && s1 == s2;
                }

                public static bool operator !=(ColumnDefinition f1, ColumnDefinition f2)
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

        }
}
