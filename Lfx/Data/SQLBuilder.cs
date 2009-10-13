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
using System.Collections;
using System.Data;

namespace Lfx.Data
{
        public enum SqlModes
        {
                Ansi = 0,
                MySql,
                PostgreSql,
                MSSql,
                Oracle,
        }

        public enum ValueTypes
        {
                String,
                Undefined,
                Int,
                Double,
                Currency,
                TimeStamp,
                Blob
        }

        /// <summary>
        /// Esta clase y sus derivadas se utilizan para evitar escribir los comandos SQL como literales de texto.
        /// Permite la creación de un objeto y asignación de propiedades que luego puede convertirse para su ejecución
        /// en texto SQL (mediante el método ToString()) o en un OdbcCommand (mediante el método ToOdbcCommand()).
        /// Se utilizan principalmente con dos objetivos:
        ///   1.- Solucionar problemas de léxico SQL.
        ///   2.- Agregar extensibilidad al acceso a datos. Así como hoy se implementa ToOdbcCommand() para acceso mediante ODBC, luego se
        ///       pueden implementar otros métodos para acceso mediante otros adaptadores (p. ej. MySQL Connector/Net).
        /// </summary>
        public class SqlCommandBuilder
        {
                public enum SqlOperands
                {
                        NullSafeEquals,
                        Equals,
                        NotEquals,
                        LessThan,
                        GreaterThan,
                        LessOrEqual,
                        GreaterOrEqual,
                        SensitiveLike,
                        InsensitiveLike,
                        SensitiveNotLike,
                        InsensitiveNotLike,
                        SoundsLike,
                }

                internal SqlModes m_Mode = SqlModes.Ansi;

                public SqlFieldCollection Fields = new SqlFieldCollection();
                public SqlWhereBuilder WhereClause = null;
                public Lfx.Data.DataBase DataView = null;

                protected SqlCommandBuilder()
                {
                        // Nada
                }

                protected SqlCommandBuilder(Lfx.Data.DataBase dataBase)
                        : this()
                {
                        this.DataView = dataBase;
                        this.SqlMode = dataBase.SqlMode;
                }

                protected SqlCommandBuilder(SqlModes SqlMode)
                        : this()
                {
                        m_Mode = SqlMode;
                }

                public SqlModes SqlMode
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

                public virtual void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        throw new NotImplementedException();
                }
        }

        // Comandos que operan sobre una o más tablas (SELECT, UPDATE, INSERT, DELETE, TRUNCATE, etc.)
        public abstract class SqlTableCommandBuilder :
            SqlCommandBuilder
        {
                public string Tables = "";

                protected SqlTableCommandBuilder()
                        : base() { }

                protected SqlTableCommandBuilder(SqlModes sqlMode)
                        : base(sqlMode) { }

                protected SqlTableCommandBuilder(Lfx.Data.DataBase dataBase, string tables)
                        : base(dataBase)
                {
                        this.Tables = tables;
                }

                protected SqlTableCommandBuilder(string tables)
                        : this()
                {
                        this.Tables = tables;
                }

                public SqlTableCommandBuilder(Lfx.Data.DataBase dataBase, string tables, SqlWhereBuilder whereClause)
                        : this(dataBase, tables)
                {
                        this.WhereClause = whereClause;
                }

                public SqlTableCommandBuilder(Lfx.Data.DataBase dataBase, string tables, string whereClause)
                        : this(dataBase, tables, new SqlWhereBuilder(whereClause)) { }

        }

        public enum JoinTypes
        {
                ImplicitJoin,
                InnerJoin,
                NaturalJoin,
                CrossJoin,
                LeftJoin,
                LeftOuterJoin,
                RightOuterJoin,
                FullOuterJoin
        }

        public class Join
        {
                public string Table;
                public string On;
                public JoinTypes JoinType = JoinTypes.LeftJoin;

                public Join(string table, string on)
                {
                        this.Table = table;
                        this.On = on;
                }

                public Join(string table, string on, JoinTypes joinType)
                {
                        this.Table = table;
                        this.On = on;
                        this.JoinType = joinType;
                }

                public override string ToString()
                {
                        System.Text.StringBuilder Res = new System.Text.StringBuilder();
                        switch (this.JoinType) {
                                case JoinTypes.ImplicitJoin:
                                        Res.Append("," + this.Table);
                                        break;
                                case JoinTypes.LeftJoin:
                                        Res.Append(" LEFT JOIN " + this.Table);
                                        break;
                                case JoinTypes.CrossJoin:
                                        Res.Append(" CROSS JOIN " + this.Table);
                                        break;
                                case JoinTypes.FullOuterJoin:
                                        Res.Append(" FULL OUTER JOIN " + this.Table);
                                        break;
                                case JoinTypes.InnerJoin:
                                        Res.Append(" INNER JOIN " + this.Table);
                                        break;
                                case JoinTypes.LeftOuterJoin:
                                        Res.Append(" LEFT OUTER JOIN " + this.Table);
                                        break;
                                case JoinTypes.NaturalJoin:
                                        Res.Append(" NATURAL JOIN " + this.Table);
                                        break;
                                case JoinTypes.RightOuterJoin:
                                        Res.Append(" RIGHT OUTER JOIN " + this.Table);
                                        break;
                        }

                        if (On != null && On.Length > 0)
                                Res.Append(" ON " + On);

                        return Res.ToString();
                }
        }

        // Comando SELECT
        public class SqlSelectBuilder
            : SqlTableCommandBuilder
        {
                public new string Fields = "*";
                public int Limit;
                public int Offset;
                public string Order = null;
                public string Group = "";
                public System.Collections.Generic.List<Join> Joins = new System.Collections.Generic.List<Join>();

                public SqlWhereBuilder HavingClause = null;

                public SqlSelectBuilder()
                        : base() { }

                public SqlSelectBuilder(SqlModes SqlMode)
                        : base(SqlMode) { }

                public SqlSelectBuilder(string Tables)
                        : base(Tables) { }

                public override string ToString()
                {
                        System.Text.StringBuilder Command = new System.Text.StringBuilder();

                        Command.Append("SELECT ");

                        if (Limit > 0 && this.SqlMode == Lfx.Data.SqlModes.MSSql)
                                Command.Append(" TOP " + Limit.ToString(System.Globalization.CultureInfo.InvariantCulture));

                        Command.Append(Fields);

                        if (Tables != null && Tables.Length > 0) {
                                string[] TableList = Tables.Split(',');

                                if (TableList.Length == 1) {
                                        //Single table
                                        Command.Append(" FROM " + Tables);
                                } else {
                                        Command.Append(" FROM " + TableList[0]);
                                }
                                foreach (Join Jo in Joins) {
                                        Command.Append(Jo.ToString());
                                }
                        }

                        if (WhereClause != null) {
                                string WhereString = WhereClause.ToString(m_Mode);

                                if (WhereString.Length > 0)
                                        Command.Append(" WHERE " + WhereString);
                        }

                        if (Group != null && Group.Length > 0)
                                Command.Append(" GROUP BY " + Group);

                        if (HavingClause != null) {
                                string HavingString = HavingClause.ToString(m_Mode);

                                if (HavingString.Length > 0)
                                        Command.Append(" HAVING " + HavingString);
                        }

                        if (Order != null && Order.Length > 0)
                                Command.Append(" ORDER BY " + Order);

                        if ((Limit > 0 || Offset > 0) && (this.SqlMode == SqlModes.MySql || this.SqlMode == SqlModes.PostgreSql)) {
                                if (Limit > 0)
                                        Command.Append(" LIMIT " + Limit.ToString(System.Globalization.CultureInfo.InvariantCulture));

                                if (Offset > 0)
                                        Command.Append(" OFFSET " + Limit.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        }

                        return Command.ToString();
                }
        }

        public class SqlUpdateBuilder :
                SqlTableCommandBuilder
        {
                public SqlUpdateBuilder()
                        : base() { }

                public SqlUpdateBuilder(string tables)
                        : base(tables) { }

                public SqlUpdateBuilder(Lfx.Data.DataBase dataBase, string tables)
                        : base(dataBase, tables) { }

                public SqlUpdateBuilder(Lfx.Data.DataBase dataBase, string tables, SqlWhereBuilder whereClause)
                        : base(dataBase, tables, whereClause) { }

                public SqlUpdateBuilder(Lfx.Data.DataBase dataBase, string tables, string whereClause)
                        : base(dataBase, tables, whereClause) { }

                public SqlUpdateBuilder(SqlModes SqlMode)
                        : base(SqlMode) { }

                public override void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        baseCommand.Parameters.Clear();
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        foreach (SqlField ThisField in this.Fields) {
                                string FieldParam;

                                if (ThisField.FieldValue is Lfx.Data.SqlFunctions) {
                                        switch (((Lfx.Data.SqlFunctions)(ThisField.FieldValue))) {
                                                case SqlFunctions.Now:
                                                        FieldParam = "NOW()";
                                                        break;
                                                default:
                                                        throw new NotImplementedException();
                                        }
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
                                        if (ThisField.FieldValue is Lfx.Types.LDateTime)
                                                Param.Value = ((Lfx.Types.LDateTime)(ThisField.FieldValue)).Value;
                                        else
                                                Param.Value = ThisField.FieldValue;
                                        if (ThisField.FieldType == ValueTypes.Blob)
                                                Param.DbType = DbType.Binary;
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider is Lfx.Data.Providers.Odbc && ThisField.FieldType == ValueTypes.Blob)
                                                ((System.Data.Odbc.OdbcParameter)Param).OdbcType = System.Data.Odbc.OdbcType.VarBinary;
                                        baseCommand.Parameters.Add(Param);
                                }
                        }
                        baseCommand.CommandText = @"UPDATE """ + this.Tables + @""" SET " + FieldList.ToString() + " WHERE " + WhereClause.ToString();
                }

                public string SqlText(Data.SqlModes sqlMode)
                {
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        foreach (SqlField ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                                string ParamValue = "";
                                if (ThisField.FieldValue == null || ThisField.FieldValue == DBNull.Value) {
                                        ParamValue = "NULL";
                                } else {
                                        switch (ThisField.FieldValue.GetType().Name) {
                                                case "Lfx.Data.SqlFunctions":
                                                        switch (((Lfx.Data.SqlFunctions)(ThisField.FieldValue))) {
                                                                case SqlFunctions.Now:
                                                                        ParamValue = "NOW()";
                                                                        break;
                                                                default:
                                                                        throw new NotImplementedException();
                                                        }
                                                        break;
                                                case "System.Single":
                                                case "System.Decimal":
                                                case "System.Double":
                                                        ParamValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(ThisField.FieldValue));
                                                        break;
                                                case "System.Integer":
                                                case "System.Int16":
                                                case "System.Int32":
                                                case "System.Int64":
                                                        ParamValue = System.Convert.ToInt32(ThisField.FieldValue).ToString();
                                                        break;
                                                default:
                                                        ParamValue = "'" + Data.DataBase.EscapeString(ThisField.FieldValue.ToString(), sqlMode) + "'";
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

        public enum InsertTypes
        {
                Insert,
                InsertOrReplace
        }

        public class SqlBuilkInsertBuilder : System.Collections.CollectionBase
        {
                public SqlBuilkInsertBuilder()
                {
                }

                public virtual int Add(SqlInsertBuilder cmd)
                {
                        return this.List.Add(cmd);
                }

                public virtual SqlInsertBuilder this[int index]
                {
                        get
                        {
                                return (SqlInsertBuilder)this.List[index];
                        }
                        set
                        {
                                this[index] = value;
                        }
                }

                public override string ToString()
                {
                        System.Text.StringBuilder Res = null;
                        foreach (SqlInsertBuilder cmd in this.List) {
                                if (Res == null) {
                                        Res = new System.Text.StringBuilder();
                                        Res.AppendLine(cmd.ToString());
                                } else {
                                        Res.Append(", ");
                                        Res.AppendLine(cmd.ToString(true));
                                }
                        }
                        if (Res == null)
                                return "";
                        else
                                return Res.ToString();
                }
        }

        public class SqlInsertBuilder :
                SqlTableCommandBuilder
        {
                public SqlInsertBuilder()
                        : base() { }

                public SqlInsertBuilder(string Tables)
                        : base(Tables) { }

                public SqlInsertBuilder(Lfx.Data.DataBase dataBase, string tables)
                        : base(dataBase, tables) { }

                public SqlInsertBuilder(SqlModes SqlMode)
                        : base(SqlMode) { }


                public override void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        System.Text.StringBuilder ParamList = new System.Text.StringBuilder();
                        foreach (SqlField ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                                string FieldParam;

                                if (ThisField.FieldValue is Lfx.Data.SqlFunctions) {
                                        switch (((Lfx.Data.SqlFunctions)(ThisField.FieldValue))) {
                                                case SqlFunctions.Now:
                                                        FieldParam = "NOW()";
                                                        break;
                                                default:
                                                        throw new NotImplementedException();
                                        }
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
                                        if (ThisField.FieldValue is Lfx.Types.LDateTime)
                                                Param.Value = ((Lfx.Types.LDateTime)(ThisField.FieldValue)).Value;
                                        else
                                                Param.Value = ThisField.FieldValue;
                                        if (ThisField.FieldType == ValueTypes.Blob)
                                                Param.DbType = DbType.Binary;
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider is Lfx.Data.Providers.Odbc && ThisField.FieldType == ValueTypes.Blob)
                                                ((System.Data.Odbc.OdbcParameter)Param).OdbcType = System.Data.Odbc.OdbcType.VarBinary;

                                        baseCommand.Parameters.Add(Param);
                                }

                        }
                        baseCommand.CommandText += @"INSERT INTO """ + this.Tables + @""" (" + FieldList.ToString() + ") VALUES (" + ParamList.ToString() + ")";
                }

                private string SqlText(Data.SqlModes sqlMode)
                {
                        return this.SqlText(sqlMode, false);
                }

                private string SqlText(Data.SqlModes sqlMode, bool valuesOnly)
                {
                        System.Text.StringBuilder FieldList = new System.Text.StringBuilder();
                        System.Text.StringBuilder ParamList = new System.Text.StringBuilder();
                        foreach (SqlField ThisField in this.Fields) {
                                if (FieldList.Length == 0)
                                        FieldList.Append(@"""" + ThisField.ColumnName + @"""");
                                else
                                        FieldList.Append(@", """ + ThisField.ColumnName + @"""");

                                string ParamValue = "";
                                if (ThisField.FieldValue == null || ThisField.FieldValue == DBNull.Value) {
                                        ParamValue = "NULL";
                                } else {
                                        string Tipo = ThisField.FieldValue.GetType().Name.Replace("System.", "");
                                        switch (Tipo) {
                                                case "Lfx.Data.SqlFunctions":
                                                        switch (((Lfx.Data.SqlFunctions)(ThisField.FieldValue))) {
                                                                case SqlFunctions.Now:
                                                                        ParamValue = "NOW()";
                                                                        break;
                                                                default:
                                                                        throw new NotImplementedException();
                                                        }
                                                        break;
                                                case "Lfx.Data.LDateTime":
                                                        ParamValue = "'" + ((Lfx.Types.LDateTime)(ThisField.FieldValue)).Value.ToString(Lfx.Types.Formatting.DateTime.SqlDateTimeFormat) + "'";
                                                        break;
                                                case "DateTime":
                                                        ParamValue = "'" + System.Convert.ToDateTime(ThisField.FieldValue).ToString(Lfx.Types.Formatting.DateTime.SqlDateTimeFormat) + "'";
                                                        break;
                                                case "Single":
                                                case "Decimal":
                                                case "Double":
                                                        ParamValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(ThisField.FieldValue));
                                                        break;
                                                case "Integer":
                                                case "Int16":
                                                case "Int32":
                                                case "Int64":
                                                        ParamValue = System.Convert.ToInt32(ThisField.FieldValue).ToString();
                                                        break;
                                                default:
                                                        ParamValue = "'" + Data.DataBase.EscapeString(ThisField.FieldValue.ToString(), sqlMode) + "'";
                                                        break;
                                        }
                                }

                                if (ParamList.Length == 0)
                                        ParamList.Append(ParamValue);
                                else
                                        ParamList.Append(", " + ParamValue);
                        }

                        if (valuesOnly)
                                return "(" + ParamList.ToString() + ")";
                        else
                                return @"INSERT INTO """ + this.Tables + @""" (" + FieldList.ToString() + ") VALUES (" + ParamList.ToString() + ")";
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

        public class SqlDeleteBuilder :
            SqlTableCommandBuilder
        {
                public bool Truncate = false;

                public SqlDeleteBuilder()
                        : base() { }

                public SqlDeleteBuilder(string Tables)
                        : base(Tables) { }

                public SqlDeleteBuilder(Lfx.Data.DataBase dataBase, string tables)
                        : base(dataBase, tables) { }

                public SqlDeleteBuilder(Lfx.Data.DataBase dataBase, string tables, SqlWhereBuilder whereClause)
                        : base(dataBase, tables, whereClause) { }

                public SqlDeleteBuilder(Lfx.Data.DataBase dataBase, string tables, string whereClause)
                        : base(dataBase, tables, whereClause) { }

                public override string ToString()
                {
                        string Command = null;

                        Command = "DELETE FROM " + Tables;

                        if (WhereClause != null) {
                                Command += " WHERE " + WhereClause.ToString();
                        } else if (Truncate == false) {
                                throw new InvalidOperationException("SqlDeleteBuilder necesita una cláusula Where o Truncate = true.");
                        }

                        return Command;
                }

                public override void SetupDbCommand(ref System.Data.IDbCommand baseCommand)
                {
                        baseCommand.CommandText = this.ToString();
                }
        }

        public class SqlWhereBuilder :
            SqlCommandBuilder
        {
                public enum WhereHaving
                {
                        Where,
                        Having,
                }

                public enum OperandsAndOr
                {
                        OperandAnd,
                        OperandOr,
                }

                public OperandsAndOr AndOr = OperandsAndOr.OperandAnd;
                public System.Collections.ArrayList Conditions;

                public SqlWhereBuilder()
                        : base()
                {
                        this.Conditions = new System.Collections.ArrayList();
                }

                public SqlWhereBuilder(string Condition)
                        : this()
                {
                        this.Conditions.Add(Condition);
                }

                public SqlWhereBuilder(SqlCondition Condition)
                        : this()
                {
                        this.Conditions.Add(Condition);
                }

                public SqlWhereBuilder(string columnName, object equalsValue)
                        : this(new SqlCondition(columnName, equalsValue))
                {
                }

                public SqlWhereBuilder(System.Collections.ArrayList Conditions)
                        : this()
                {
                        this.Conditions = Conditions;
                }

                public string ToString(SqlModes Mode)
                {
                        m_Mode = Mode;
                        return this.ToString();
                }

                public override string ToString()
                {
                        if (Conditions != null && Conditions.Count > 0) {
                                System.Text.StringBuilder Command = new System.Text.StringBuilder();

                                foreach (object Condition in Conditions) {
                                        if (Condition != null) {
                                                if (Condition is SqlCondition) {
                                                        ((SqlCondition)(Condition)).Mode = m_Mode;
                                                        if (AndOr == OperandsAndOr.OperandAnd)
                                                                Command.Append(" AND ");
                                                        else
                                                                Command.Append(" OR ");

                                                        Command.Append(((SqlCondition)(Condition)).ToString(m_Mode));
                                                } else if (Condition is SqlWhereBuilder) {
                                                        if (((SqlWhereBuilder)(Condition)).Conditions.Count > 0) {
                                                                if (AndOr == OperandsAndOr.OperandAnd)
                                                                        Command.Append(" AND ");
                                                                else
                                                                        Command.Append(" OR ");

                                                                Command.Append(((SqlWhereBuilder)(Condition)).ToString(m_Mode));
                                                        }
                                                } else if (System.Convert.ToString(Condition).Length > 0) {
                                                        if (AndOr == OperandsAndOr.OperandAnd)
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
                                        // Me deshago de cosas invalidas como operandos sin condicion ("AND"),
                                        // operandos de más (AND cond AND cond), etc.
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
                                return "";
                        }
                }
        }

        public enum SqlFunctions
        {
                Now
        }

        public class SqlExpression
        {
                public string Value = null;

                public SqlExpression(string expr)
                {
                        this.Value = expr;
                }

                public override string ToString()
                {
                        return this.Value;
                }
        }

        public class SqlField
        {
                protected Lfx.Data.SqlModes m_Mode = Lfx.Data.SqlModes.Ansi;
                private string m_Name;
                private ValueTypes m_Type;
                private object m_Value;

                public SqlField(string columnName, object fieldValue)
                {
                        m_Name = columnName;
                        m_Value = fieldValue;

                        if (fieldValue is int || fieldValue is long) {
                                this.m_Type = ValueTypes.Int;
                        } else if (fieldValue is string) {
                                this.m_Type = ValueTypes.String;
                        } else if (fieldValue is DateTime || fieldValue is Nullable<DateTime> || fieldValue is Lfx.Types.LDateTime) {
                                this.m_Type = ValueTypes.TimeStamp;
                        } else if (fieldValue is float || fieldValue is decimal || fieldValue is double) {
                                this.m_Type = ValueTypes.Double;
                        } else if (fieldValue is byte[] || fieldValue is System.Drawing.Image) {
                                this.m_Type = ValueTypes.Blob;
                        } else {
                                this.m_Type = ValueTypes.Undefined;
                        }
                }

                public SqlField(string columnName, ValueTypes fieldType, object fieldValue)
                {
                        m_Name = columnName;
                        m_Type = fieldType;
                        m_Value = fieldValue;
                }

                public string ColumnName
                {
                        get
                        {
                                return m_Name;
                        }
                        set
                        {
                                m_Name = value;
                        }
                }

                public ValueTypes FieldType
                {
                        get
                        {
                                return m_Type;
                        }
                }

                public System.Data.Odbc.OdbcType FieldOdbcType
                {
                        get
                        {
                                switch (m_Type) {
                                        case ValueTypes.String:
                                                return System.Data.Odbc.OdbcType.VarChar;
                                        case ValueTypes.Double:
                                        case ValueTypes.Currency:
                                                return System.Data.Odbc.OdbcType.Numeric;
                                        case ValueTypes.Int:
                                                return System.Data.Odbc.OdbcType.Int;
                                        case ValueTypes.Blob:
                                                return System.Data.Odbc.OdbcType.VarBinary;
                                        default:
                                                return System.Data.Odbc.OdbcType.VarChar;
                                }
                        }
                }

                public object FieldValue
                {
                        get
                        {
                                if (m_Value == null)
                                        return DBNull.Value;
                                else
                                        return m_Value;
                        }
                        set
                        {
                                m_Value = value;
                        }
                }
        }

        public class SqlFieldCollection : System.Collections.CollectionBase
        {
                public SqlFieldCollection()
                {
                }

                public virtual int Add(SqlField field)
                {
                        return this.List.Add(field);
                }

                public virtual int AddWithValue(string fieldName, object fieldValue)
                {
                        return this.List.Add(new SqlField(fieldName, fieldValue));
                }

                public virtual SqlField this[string columnName]
                {
                        get
                        {
                                foreach (SqlField Itm in this) {
                                        if (Itm.ColumnName == columnName)
                                                return Itm;
                                }
                                //Si no existe, creo dinámicamente el campo
                                SqlField Res = new SqlField(columnName, ValueTypes.String, "");
                                this.List.Add(Res);
                                return Res;
                        }
                        set
                        {
                                bool Encontrado = false;
                                for (int i = 0; i < this.Count; i++) {
                                        if (this[i].ColumnName == columnName) {
                                                ((SqlField)(this[i])).FieldValue = value;
                                                Encontrado = true;
                                                break;
                                        }
                                }
                                if (Encontrado == false) {
                                        //Si no existe, creo dinámicamente el campo
                                        value.ColumnName = columnName;
                                        this.List.Add(value);
                                }
                        }
                }

                public virtual SqlField this[int index]
                {
                        get
                        {
                                return (SqlField)this.List[index];
                        }
                        set
                        {
                                this[index] = value;
                        }
                }

                public bool Contains(string columnName)
                {
                        foreach (SqlField Itm in this) {
                                if (Itm.ColumnName.ToUpperInvariant() == columnName.ToUpperInvariant())
                                        return true;
                        }
                        return false;
                }
        }

        public class SqlCondition
        {
                protected Lfx.Data.SqlModes m_Mode = Lfx.Data.SqlModes.Ansi;
                protected string LeftValue = "";
                protected object m_RightValue = "";
                public SqlCommandBuilder.SqlOperands Operand = SqlCommandBuilder.SqlOperands.Equals;

                public SqlCondition()
                {
                        // 
                }

                public SqlCondition(Lfx.Data.SqlModes Mode)
                        : this()
                {
                        m_Mode = Mode;
                }

                public SqlCondition(string LeftValue, object RightValue)
                        : this(LeftValue, SqlCommandBuilder.SqlOperands.Equals, RightValue)
                {
                }

                public SqlCondition(string LeftValue, SqlCommandBuilder.SqlOperands Operand, object RightValue)
                        : this()
                {
                        this.LeftValue = LeftValue;
                        this.Operand = Operand;
                        this.m_RightValue = RightValue;
                }

                public SqlCondition(Lfx.Data.SqlModes Mode, string LeftValue, SqlCommandBuilder.SqlOperands Operand, object RightValue)
                        : this(LeftValue, Operand, RightValue)
                {
                        m_Mode = Mode;
                }

                public Lfx.Data.SqlModes Mode
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

                public string RightValue
                {
                        get
                        {
                                if (m_RightValue == null || m_RightValue is DBNull) {
                                        return "NULL";
                                } else if (m_RightValue is double || m_RightValue is decimal) {
                                        return Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(m_RightValue));
                                } else if (m_RightValue is Lfx.Types.LDateTime) {
                                        return Lfx.Types.Formatting.FormatDateTimeSql(((Lfx.Types.LDateTime)(m_RightValue)).Value);
                                } else if (m_RightValue is DateTime) {
                                        return Lfx.Types.Formatting.FormatDateTimeSql((DateTime)m_RightValue);
                                } else if (m_RightValue is int || m_RightValue is long) {
                                        return m_RightValue.ToString();
                                } else if (m_RightValue is SqlExpression) {
                                        return m_RightValue.ToString();
                                } else {
                                        return "'" + Lfx.Data.DataBase.EscapeString(m_RightValue.ToString(), m_Mode) + "'";
                                }
                        }
                }

                public string ToString(Lfx.Data.SqlModes Mode)
                {
                        m_Mode = Mode;
                        return this.ToString();
                }

                public override string ToString()
                {
                        string Result = null;

                        switch (Operand) {
                                case SqlCommandBuilder.SqlOperands.NullSafeEquals:
                                        Result = LeftValue + "<=>" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.Equals:
                                        if (m_RightValue == null)
                                                Result = LeftValue + " IS NULL";
                                        else
                                                Result = LeftValue + "=" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.GreaterOrEqual:
                                        Result = LeftValue + ">=" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.GreaterThan:
                                        Result = LeftValue + ">" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.InsensitiveLike:
                                        switch (m_Mode) {
                                                case Lfx.Data.SqlModes.PostgreSql:
                                                        Result = LeftValue + " ILIKE " + RightValue;
                                                        break;
                                                default:
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                        }
                                        break;

                                case SqlCommandBuilder.SqlOperands.LessOrEqual:
                                        Result = LeftValue + "<=" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.LessThan:
                                        Result = LeftValue + "<" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.NotEquals:
                                        if (m_RightValue == null)
                                                Result = LeftValue + " IS NOT NULL";
                                        else
                                                Result = LeftValue + "<>" + RightValue;
                                        break;

                                case SqlCommandBuilder.SqlOperands.SensitiveLike:
                                        switch (m_Mode) {
                                                case Lfx.Data.SqlModes.MySql:
                                                        Result = "BINARY " + LeftValue + " LIKE BINARY " + RightValue;
                                                        break;
                                                default:
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                        }
                                        break;

                                case SqlCommandBuilder.SqlOperands.SoundsLike:
                                        switch (m_Mode) {
                                                case Lfx.Data.SqlModes.MySql:
                                                        // FIXME: Parece que el SOUNDS LIKE no funciona bien en MySql
                                                        // Result = LeftValue.Replace("%", "") & " SOUNDS LIKE " & RightValue.Replace("%", "")
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                                case Lfx.Data.SqlModes.PostgreSql:
                                                        Result = LeftValue + " ILIKE " + RightValue;
                                                        break;
                                                default:
                                                        Result = LeftValue + " LIKE " + RightValue;
                                                        break;
                                        }
                                        break;
                        }

                        return Result;
                }
        }
}