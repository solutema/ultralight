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
using System.Collections.Generic;

namespace qGen
{
        [Serializable]
        public class BuilkInsert : TableCommand
        {
                System.Collections.Generic.List<Insert> InsertCommands = new List<Insert>();

                public void Clear()
                {
                        this.InsertCommands.Clear();
                }

                public void Add(Insert insertCommand)
                {
                        if (this.InsertCommands.Count > 0) {
                                if (this.Tables != insertCommand.Tables)
                                        throw new ArgumentException("qGen: BulkInsert requiere que todas las inserciones sean en la misma tabla y con los mismos campos");
                        } else {
                                this.Tables = insertCommand.Tables;
                                this.Fields = insertCommand.Fields;
                                this.DataBase = insertCommand.DataBase;
                                this.WhereClause = insertCommand.WhereClause;
                                this.m_Mode = insertCommand.m_Mode;
                        }
                        this.InsertCommands.Add(insertCommand);
                }

                public int Count
                {
                        get
                        {
                                return this.InsertCommands.Count;
                        }
                }

                public override string ToString()
                {
                        System.Text.StringBuilder Res = null;
                        foreach (Insert Cmd in this.InsertCommands) {
                                if (Res == null) {
                                        Res = new System.Text.StringBuilder();
                                        Res.AppendLine(Cmd.ToString());
                                } else {
                                        Res.Append(", ");
                                        Res.AppendLine(Cmd.ToString(true));
                                }
                        }
                        if (Res == null)
                                return "";
                        else
                                return Res.ToString();
                }


                public override void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        if (this.InsertCommands.Count == 0)
                                return;

                        System.Text.StringBuilder CmdText = new System.Text.StringBuilder(baseCommand.CommandText);

                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        foreach (Lfx.Data.Field ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                        }

                        CmdText.Append(@"INSERT INTO """ + this.Tables + @""" (" + FieldList.ToString() + ") VALUES ");
                        int CmdNum = 1;
                        foreach (Insert Cmd in this.InsertCommands) {
                                System.Text.StringBuilder ParamList = new System.Text.StringBuilder();
                                foreach (Lfx.Data.Field ThisField in Cmd.Fields) {
                                        string FieldParam;

                                        string ParamName = "@" + ThisField.ColumnName + "_" + CmdNum.ToString();
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
                                                        FieldParam = ParamName;
                                        }

                                        if (ParamList.Length == 0)
                                                ParamList.Append(FieldParam);
                                        else
                                                ParamList.Append(", " + FieldParam);

                                        if (FieldParam == "?" || FieldParam.Substring(0, 1) == "@") {
                                                System.Data.IDbDataParameter Param = Lfx.Data.DataBaseCache.DefaultCache.Provider.GetParameter();
                                                Param.ParameterName = ParamName;
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
                                if (CmdNum > 1)
                                        CmdText.AppendLine(",");
                                CmdText.Append(@"(" + ParamList.ToString() + ")");
                                CmdNum++;
                        }
                        
                        baseCommand.CommandText = CmdText.ToString();
                }
        }
}
