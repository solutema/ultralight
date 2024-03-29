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
        public class Insert : TableCommand
        {
                public bool OnDuplicateKeyUpdate { get; set; }

                public Insert()
                        : base() { }

                public Insert(string Tables)
                        : base(Tables) { }

                public Insert(Lfx.Data.Connection dataBase, string tables)
                        : base(dataBase, tables) { }

                public Insert(SqlModes SqlMode)
                        : base(SqlMode) { }


                public override void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        System.Text.StringBuilder ParamList = new System.Text.StringBuilder();
                        foreach (Lfx.Data.Field ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                                string FieldParam;

                                if (ThisField.Value is qGen.SqlFunctions) {
                                        switch (((qGen.SqlFunctions)(ThisField.Value))) {
                                                case SqlFunctions.Now:
                                                        FieldParam = "NOW()";
                                                        break;
                                                default:
                                                        throw new NotImplementedException();
                                        }
                                } else if (ThisField.Value is qGen.SqlExpression) {
                                        FieldParam = ThisField.Value.ToString();
                                } else {
                                        if (baseCommand.Connection is System.Data.Odbc.OdbcConnection)
                                                FieldParam = "?";
                                        else
                                                FieldParam = "@" + ThisField.ColumnName;
                                }

                                if (ParamList.Length == 0)
                                        ParamList.Append(FieldParam);
                                else
                                        ParamList.Append(", " + FieldParam);

                                if (FieldParam == "?" || FieldParam.Substring(0, 1) == "@") {
                                        System.Data.IDbDataParameter Param = Lfx.Data.DataBaseCache.DefaultCache.Provider.GetParameter();
                                        Param.ParameterName = "@" + ThisField.ColumnName;
                                        if (ThisField.Value is NullableDateTime && ThisField.Value != null)
                                                Param.Value = ((NullableDateTime)(ThisField.Value)).Value;
                                        else
                                                Param.Value = ThisField.Value;
                                        if (ThisField.DataType == Lfx.Data.DbTypes.Blob)
                                                Param.DbType = System.Data.DbType.Binary;
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider is qGen.Providers.Odbc && ThisField.DataType == Lfx.Data.DbTypes.Blob)
                                                ((System.Data.Odbc.OdbcParameter)Param).OdbcType = System.Data.Odbc.OdbcType.VarBinary;

                                        baseCommand.Parameters.Add(Param);
                                }

                        }
                        baseCommand.CommandText += @"INSERT INTO """ + this.Tables + @""" (" + FieldList.ToString() + ") VALUES (" + ParamList.ToString() + ")";

                        if (this.OnDuplicateKeyUpdate) {
                                string UpdateClause = null;
                                foreach (Lfx.Data.Field ThisField in this.Fields) {
                                        if (UpdateClause == null)
                                                UpdateClause = @" ON DUPLICATE KEY UPDATE """ + ThisField.ColumnName + @"""=VALUES(""" + ThisField.ColumnName + @""")";
                                        else
                                                UpdateClause += @", """ + ThisField.ColumnName + @"""=VALUES(""" + ThisField.ColumnName + @""")";
                                }

                                baseCommand.CommandText += UpdateClause;
                        }
                }

                private string SqlText(SqlModes sqlMode)
                {
                        return this.SqlText(sqlMode, false);
                }

                private string SqlText(SqlModes sqlMode, bool valuesOnly)
                {
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        System.Text.StringBuilder ParamList = new System.Text.StringBuilder();
                        foreach (Lfx.Data.Field ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                                string ParamValue = "";
                                if (ThisField.Value == null || ThisField.Value == DBNull.Value) {
                                        ParamValue = "NULL";
                                } else {
                                        string Tipo = ThisField.Value.GetType().Name.Replace("System.", "");
                                        switch (Tipo) {
                                                case "qGen.SqlFunctions":
                                                        switch (((qGen.SqlFunctions)(ThisField.Value))) {
                                                                case SqlFunctions.Now:
                                                                        ParamValue = "NOW()";
                                                                        break;
                                                                default:
                                                                        throw new NotImplementedException();
                                                        }
                                                        break;
                                                case "Lfx.Data.SqlLiteral":
                                                        ParamValue = ThisField.Value.ToString();
                                                        break;
                                                case "Lfx.Data.LDateTime":
                                                        ParamValue = "'" + ((NullableDateTime)(ThisField.Value)).Value.ToString(Lfx.Types.Formatting.DateTime.SqlDateTimeFormat) + "'";
                                                        break;
                                                case "DateTime":
                                                        ParamValue = "'" + System.Convert.ToDateTime(ThisField.Value).ToString(Lfx.Types.Formatting.DateTime.SqlDateTimeFormat) + "'";
                                                        break;
                                                case "Single":
                                                case "Double":
                                                case "Decimal":
                                                        ParamValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDecimal(ThisField.Value), 8);
                                                        break;
                                                case "Integer":
                                                case "Int16":
                                                case "Int32":
                                                case "Int64":
                                                        ParamValue = System.Convert.ToInt32(ThisField.Value).ToString();
                                                        break;
                                                default:
                                                        ParamValue = "'" + Lfx.Data.Connection.EscapeString(ThisField.Value.ToString(), sqlMode) + "'";
                                                        break;
                                        }
                                }

                                if (ParamList.Length == 0)
                                        ParamList.Append(ParamValue);
                                else
                                        ParamList.Append(", " + ParamValue);
                        }

                        if (valuesOnly) {
                                return "(" + ParamList.ToString() + ")";
                        } else {
                                string Res = @"INSERT INTO """ + this.Tables + @""" (" + FieldList.ToString() + ") VALUES (" + ParamList.ToString() + ")";

                                if (this.OnDuplicateKeyUpdate) {
                                        string UpdateClause = null;
                                        foreach (Lfx.Data.Field ThisField in this.Fields) {
                                                if (UpdateClause == null)
                                                        UpdateClause = @" ON DUPLICATE KEY UPDATE """ + ThisField.ColumnName + @"""=VALUES(""" + ThisField.ColumnName + @""")";
                                                else
                                                        UpdateClause += @", """ + ThisField.ColumnName + @"""=VALUES(""" + ThisField.ColumnName + @""")";
                                        }

                                        Res += UpdateClause;
                                }

                                return Res;
                        }
                }

                public override string ToString()
                {
                        return this.SqlText(this.SqlMode);
                }

                protected internal string ToString(bool valuesOnly)
                {
                        return this.SqlText(this.SqlMode, valuesOnly);
                }
        }
}
