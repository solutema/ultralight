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

namespace qGen
{
        [Serializable]
        public class Update : TableCommand
        {
                public Update()
                        : base() { }

                public Update(string tables)
                        : base(tables) { }

                public Update(Lfx.Data.Connection dataBase, string tables)
                        : base(dataBase, tables) { }

                public Update(string tables, Where whereClause)
                        : base(tables, whereClause) { }

                public Update(SqlModes SqlMode)
                        : base(SqlMode) { }

                public override void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        baseCommand.Parameters.Clear();
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        foreach (Lfx.Data.Field ThisField in this.Fields) {
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

                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""=" + FieldParam);
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""=" + FieldParam);

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
                        baseCommand.CommandText = @"UPDATE """ + this.Tables + @""" SET " + FieldList.ToString() + " WHERE " + WhereClause.ToString();
                }

                public string SqlText(SqlModes sqlMode)
                {
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        foreach (Lfx.Data.Field ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                                string ParamValue = "";
                                if (ThisField.Value == null || ThisField.Value == DBNull.Value) {
                                        ParamValue = "NULL";
                                } else {
                                        switch (ThisField.Value.GetType().Name) {
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
                                                case "System.Single":
                                                case "System.Double":
                                                case "System.Decimal":
                                                        ParamValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDecimal(ThisField.Value), 8);
                                                        break;
                                                case "System.Integer":
                                                case "System.Int16":
                                                case "System.Int32":
                                                case "System.Int64":
                                                        ParamValue = System.Convert.ToInt32(ThisField.Value).ToString();
                                                        break;
                                                default:
                                                        ParamValue = "'" + Lfx.Data.Connection.EscapeString(ThisField.Value.ToString(), sqlMode) + "'";
                                                        break;
                                        }
                                }

                                FieldList.Append("=" + ParamValue);

                        }

                        return @"UPDATE """ + this.Tables + @""" SET " + FieldList.ToString() + " WHERE " + this.WhereClause.ToString();
                }

                public override string ToString()
                {
                        return this.SqlText(this.SqlMode);
                }
        }
}
