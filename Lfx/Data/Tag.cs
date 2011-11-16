#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
        public class Tag
        {
                public int Id;
                public string TableName, FieldName, Label, Extra;
                public bool Nullable = false;
                public Lfx.Data.DbTypes FieldType = Lfx.Data.DbTypes.VarChar;
                public Lfx.Data.InputFieldTypes InputFieldType = InputFieldTypes.Text;
                public object Value = null, DefaultValue = null;
                public Connection DataBase;
                public Lfx.Data.Relation Relation = null;

                public Tag(Connection dataBase, string tableName, Lfx.Data.Row fromRow)
                {
                        this.DataBase = dataBase;
                        this.TableName = tableName;
                        this.Id = System.Convert.ToInt32(fromRow["id_tag"]);
                        this.FieldName = fromRow["fieldname"].ToString();
                        this.Label = fromRow["label"].ToString();
                        if (fromRow["extra"] != null)
                                this.Extra = fromRow["extra"].ToString();
                        string FldType = fromRow["fieldtype"].ToString();
                        switch(FldType) {
                                case "relation":
                                        this.FieldType = DbTypes.Integer;
                                        string[] RelationFields = this.Extra.Split(new char[] { ',' });
                                        string ReferenceTable = RelationFields[0], ReferenceColumn, DetailColumn;
                                        
                                        if(RelationFields.Length >= 2)
                                                ReferenceColumn = RelationFields[1];
                                        else
                                                ReferenceColumn = dataBase.Tables[ReferenceTable].PrimaryKey;

                                        if(RelationFields.Length >= 3)
                                                DetailColumn = RelationFields[2];
                                        else
                                                DetailColumn = "nombre";

                                        this.Relation = new Relation(this.FieldName, ReferenceTable, ReferenceColumn, DetailColumn);
                                        break;
                                default:
                                        this.FieldType = Lfx.Data.Types.FromSqlType(FldType);
                                        break;
                        }

                        if (fromRow["inputtype"] != null && fromRow["inputtype"].ToString() != string.Empty)
                                this.InputFieldType = (Lfx.Data.InputFieldTypes)(Enum.Parse(typeof(Lfx.Data.InputFieldTypes), fromRow["inputtype"].ToString()));
                                                
                        this.Nullable = System.Convert.ToBoolean(fromRow["fieldnullable"]);
                        this.DefaultValue = fromRow["fielddefault"];
                        if (this.DefaultValue is DBNull)
                                this.DefaultValue = null;

                }

                public Tag(string tableName, string fieldName, string label)
                {
                        this.TableName = tableName;
                        this.FieldName = fieldName;
                        this.Label = label;
                }

                public void Save()
                {
                        qGen.TableCommand InsertOrUpdate;
                        if (this.Id == 0) {
                                InsertOrUpdate = new qGen.Insert("sys_tags");
                        } else {
                                InsertOrUpdate = new qGen.Update("sys_tags");
                                InsertOrUpdate.WhereClause = new qGen.Where("id_tag", this.Id);
                        }

                        InsertOrUpdate.Fields.AddWithValue("tablename", this.TableName);
                        InsertOrUpdate.Fields.AddWithValue("fieldname", this.FieldName);
                        InsertOrUpdate.Fields.AddWithValue("label", this.Label);
                        switch(this.FieldType) {
                                case DbTypes.VarChar:
                                        InsertOrUpdate.Fields.AddWithValue("fieldtype", "varchar");
                                        break;
                                case DbTypes.Integer:
                                        InsertOrUpdate.Fields.AddWithValue("fieldtype", "integer");
                                        break;
                                case DbTypes.Text:
                                        InsertOrUpdate.Fields.AddWithValue("fieldtype", "text");
                                        break;
                        }
                        InsertOrUpdate.Fields.AddWithValue("fieldnullable", this.Nullable ? 1 : 0);
                        InsertOrUpdate.Fields.AddWithValue("fielddefault", this.DefaultValue);

                        this.DataBase.Execute(InsertOrUpdate);
                }
        }
}
