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
using System.Reflection;

namespace Lfx.Data
{
        /// <summary>
        /// Proporciona una conexión a la base de datos y acceso de bajo nivel (sin abstracción) a los datos. Se utiliza normalmente para ejecutar consultas.
        /// Vea Lfx.Data.DataBase para acceso de medio nivel a los datos o Lbl.* para para acceso de alto nivel a los datos.
        /// </summary>
        public class Connection : IDisposable
        {
                public bool EnableRecover = false, RequiresTransaction = false;
                public Lfx.Workspace Workspace;
                public int KeepAlive = 600;             // 10 minutos
                private string m_Name = null;

                public readonly int Handle = 0;
                private static int LastHandle = 0;
                private System.Timers.Timer KeepAliveTimer = null;
                private System.Diagnostics.Stopwatch PerfCounter = new System.Diagnostics.Stopwatch();
                private System.Data.IDbConnection DbConnection;
                private bool m_InTransaction = false, m_Closing = false;

                public Connection(Lfx.Workspace workspace, string ownerName)
                {
                        this.RequiresTransaction = Lfx.Environment.SystemInformation.DesignMode;
                        this.Workspace = workspace;
                        this.Workspace.ActiveConnections.Add(this);
                        this.Handle = LastHandle++;
                        this.Name = ownerName;
                        if (Lfx.Data.DataBaseCache.DefaultCache == null)
                                Lfx.Data.DataBaseCache.DefaultCache = new DataBaseCache(this);
                }

                public bool Open()
                {
                        EnableRecover = false;

                        if (DbConnection != null && DbConnection.State != System.Data.ConnectionState.Closed && DbConnection.State != System.Data.ConnectionState.Broken)
                                return false;

                        this.Workspace.DebugLog(this.Handle, "Abriendo " + this.Name, null);

                        System.Text.StringBuilder ConnectionString = new System.Text.StringBuilder();

                        switch (Lfx.Data.DataBaseCache.DefaultCache.AccessMode) {
                                case AccessModes.Odbc:
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider == null)
                                                Lfx.Data.DataBaseCache.DefaultCache.Provider = new Lfx.Data.Providers.Odbc();
                                        ConnectionString.Append("DSN=" + Lfx.Data.DataBaseCache.DefaultCache.ServerName + ";");
                                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = "(ODBC)";
                                        break;
                                case AccessModes.MySql:
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider == null)
                                                Lfx.Data.DataBaseCache.DefaultCache.Provider = new Lfx.Data.Providers.MySqlProvider();
                                        ConnectionString.Append("Convert Zero Datetime=true;");
                                        ConnectionString.Append("Connection Timeout=30;");
                                        ConnectionString.Append("Default Command Timeout=600;");
                                        ConnectionString.Append("Allow User Variables=True;");
                                        // ConnectionString.Append("KeepAlive=20;");     // No sirve, uso KeepAlive propio
                                        ConnectionString.Append("Pooling=false;");      // Si habilitamos el Pooling, en conector mantiene muchas conexiones abiertas
                                                                                        // El pool crece, pero nunca se achica
                                        switch (System.Text.Encoding.Default.BodyName) {
                                                case "utf-8":
                                                        ConnectionString.Append("charset=utf8;");
                                                        break;
                                                case "iso-8859-1":
                                                        ConnectionString.Append("charset=latin1;");
                                                        break;
                                        }
                                        if (Lfx.Data.DataBaseCache.DefaultCache.SlowLink) {
                                                ConnectionString.Append("Compress=true;");
                                                ConnectionString.Append("Use Compression=true;");
                                        }
                                        Lfx.Data.DataBaseCache.DefaultCache.OdbcDriver = null;
                                        Lfx.Data.DataBaseCache.DefaultCache.Mars = false;
                                        Lfx.Data.DataBaseCache.DefaultCache.SqlMode = qGen.SqlModes.MySql;
                                        break;
                                case AccessModes.Npgsql:
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider == null)
                                                Lfx.Data.DataBaseCache.DefaultCache.Provider = new Lfx.Data.Providers.Npgsql();
                                        ConnectionString.Append("CommandTimeout=900;");
                                        Lfx.Data.DataBaseCache.DefaultCache.SqlMode = qGen.SqlModes.PostgreSql;
                                        break;
                                case AccessModes.MSSql:
                                        if (Lfx.Data.DataBaseCache.DefaultCache.Provider == null)
                                                Lfx.Data.DataBaseCache.DefaultCache.Provider = new Lfx.Data.Providers.Odbc();
                                        Lfx.Data.DataBaseCache.DefaultCache.OdbcDriver = "SQL Server";
                                        Lfx.Data.DataBaseCache.DefaultCache.SqlMode = qGen.SqlModes.TransactSql;
                                        break;
                        }

                        if (Lfx.Data.DataBaseCache.DefaultCache.OdbcDriver != null)
                                ConnectionString.Append("DRIVER={" + Lfx.Data.DataBaseCache.DefaultCache.OdbcDriver + "};");
                        ConnectionString.Append("SERVER=" + Lfx.Data.DataBaseCache.DefaultCache.ServerName + ";");
                        ConnectionString.Append("DATABASE=" + Lfx.Data.DataBaseCache.DefaultCache.DataBaseName + ";");
                        ConnectionString.Append("UID=" + Lfx.Data.DataBaseCache.DefaultCache.UserName + ";");
                        ConnectionString.Append("PWD=" + Lfx.Data.DataBaseCache.DefaultCache.Password + ";");

                        DbConnection = Lfx.Data.DataBaseCache.DefaultCache.Provider.GetConnection();
                        DbConnection.ConnectionString = ConnectionString.ToString();
                        try {
                                DbConnection.Open();
                        } catch {
                                throw;
                        }

                        this.SetupConnection(this.DbConnection);
                        EnableRecover = true;

                        if (KeepAlive > 0 && KeepAliveTimer == null) {
                                KeepAliveTimer = new System.Timers.Timer(this.KeepAlive * 1000);
                                KeepAliveTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.KeepAliveTimer_Elapsed);
                                KeepAliveTimer.Start();
                        }

                        if (DbConnection is System.Data.Odbc.OdbcConnection) {
                                System.Data.Odbc.OdbcConnection OdbcConnection = DbConnection as System.Data.Odbc.OdbcConnection;
                                try {
                                        OdbcConnection.StateChange -= new System.Data.StateChangeEventHandler(this.Connection_StateChange);
                                }
                                catch {
                                        // Nada
                                }
                                OdbcConnection.StateChange += new System.Data.StateChangeEventHandler(this.Connection_StateChange);
                        }

                        return false;
                }

                private void KeepAliveTimer_Elapsed(object source, System.Timers.ElapsedEventArgs e)
                {
                        try {
                                this.Execute("SELECT 1");
                        } catch {
                                // Nada
                        }
                }

                private void ResetKeepAliveTimer()
                {
                        if (this.KeepAliveTimer != null) {
                                this.KeepAliveTimer.Stop();
                                this.KeepAliveTimer.Start();
                        }
                }

                public string ServerName
                {
                        get
                        {
                                return Lfx.Data.DataBaseCache.DefaultCache.ServerName;
                        }
                }

                public TableCollection Tables
                {
                        get
                        {
                                return Lfx.Data.DataBaseCache.DefaultCache.Tables;
                        }
                }

                public string Name
                {
                        get
                        {
                                return m_Name;
                        }
                        set
                        {
                                if (value == "Editar")
                                        System.Console.WriteLine(this.Handle.ToString() + ": ahora se llama " + value);
                                m_Name = value;
                        }
                }

                public DateTime ServerDateTime
                {
                        get
                        {
                                return this.FieldDateTime("SELECT NOW()", DateTime.Now);
                        }
                }

                private void SetTransactionIsolationLevel(IsolationLevels level)
                {
                        string SqlCommand;
                        switch (this.SqlMode) {
                                case qGen.SqlModes.MySql:
                                        SqlCommand = "SESSION TRANSACTION ISOLATION LEVEL";
                                        break;
                                case qGen.SqlModes.PostgreSql:
                                        SqlCommand = "TRANSACTION ISOLATION LEVEL";
                                        break;
                                default:
                                        SqlCommand = "TRANSACTION ISOLATION LEVEL";
                                        break;
                        }

                        string SqlLevel;
                        switch (level) {
                                case IsolationLevels.ReadUncommitted:
                                        SqlLevel = "READ UNCOMMITTED";
                                        break;
                                case IsolationLevels.ReadCommited:
                                        SqlLevel = "READ COMMITTED";
                                        break;
                                case IsolationLevels.RepeatableRead:
                                        SqlLevel = "REPEATABLE READ";
                                        break;
                                case IsolationLevels.Serializable:
                                        SqlLevel = "SERIALIZABLE";
                                        break;
                                default:
                                        throw new ArgumentException("No se reconoce el nivel de aislamiento");
                        }

                        this.Execute(new qGen.SetCommand(SqlCommand + " " + SqlLevel));
                }


                private void SetupConnection(System.Data.IDbConnection setupConnection)
                {
                        if (this.AccessMode == AccessModes.Odbc) {
                                //Detecto el tipo de servidor y asigno directamente a la variable porque la propiedad es sólo lectura
                                System.Data.Odbc.OdbcConnection OdbcConnection = setupConnection as System.Data.Odbc.OdbcConnection;
                                if (OdbcConnection.ServerVersion.IndexOf("PostgreSql", StringComparison.InvariantCultureIgnoreCase) >= 0)
                                        Lfx.Data.DataBaseCache.DefaultCache.SqlMode = qGen.SqlModes.PostgreSql;
                                else if (OdbcConnection.Driver.IndexOf("myodbc", StringComparison.InvariantCultureIgnoreCase) >= 0)
                                        Lfx.Data.DataBaseCache.DefaultCache.SqlMode = qGen.SqlModes.MySql;
                                else if (OdbcConnection.Driver.IndexOf("SqlSRV", StringComparison.InvariantCultureIgnoreCase) >= 0)
                                        Lfx.Data.DataBaseCache.DefaultCache.SqlMode = qGen.SqlModes.TransactSql;
                        }

                        switch (this.SqlMode) {
                                case qGen.SqlModes.MySql:
                                        // Pongo a MySql en modo ANSI
                                        this.Execute(new qGen.SetCommand("sql_mode='ANSI'"));
                                        switch (System.Text.Encoding.Default.BodyName) {
                                                case "utf-8":
                                                        this.Execute(new qGen.SetCommand("CHARACTER SET UTF8"));
                                                        break;
                                                case "iso-8859-1":
                                                        this.Execute(new qGen.SetCommand("CHARACTER SET LATIN1"));
                                                        break;
                                        }
                                        break;
                                case qGen.SqlModes.PostgreSql:
                                        switch (System.Text.Encoding.Default.BodyName) {
                                                case "utf-8":
                                                        this.Execute(new qGen.SetCommand("CLIENT_ENCODING TO 'UTF8'"));
                                                        break;
                                                case "iso-8859-1":
                                                        this.Execute(new qGen.SetCommand("CLIENT_ENCODING TO 'LATIN1'"));
                                                        break;
                                        }
                                        break;
                        }
                }

                public void SetTableStructure(Data.TableStructure newTableDef)
                {
                        Data.TableStructure CurrentTableDef = this.GetTableStructure(newTableDef.Name, false);
                        bool TablaCreada = false;
                        if (CurrentTableDef.Columns.Count == 0) {
                                //Crear la tabla
                                this.Execute(this.CustomizeSql(newTableDef.ToString()));
                                TablaCreada = true;
                        } else {
                                //Modificar tabla existente
                                foreach (Data.ColumnDefinition NewFieldDef in newTableDef.Columns.Values) {
                                        string Sql = null;
                                        if (CurrentTableDef.Columns.ContainsKey(NewFieldDef.Name) == false) {
                                                //Agregar campo a una tabla existente
                                                Sql = "ALTER TABLE \"" + newTableDef.Name + "\" ADD \"" + NewFieldDef.Name + "\" " + NewFieldDef.SqlDefinition();
                                        } else {
                                                Data.ColumnDefinition CurrentFieldDef = CurrentTableDef.Columns[NewFieldDef.Name];
                                                if (CurrentFieldDef != NewFieldDef) {
                                                        //Existe el campo, pero no es igual... hay que modificarlo
                                                        if (this.AccessMode == AccessModes.Npgsql) {
                                                                Sql = string.Empty;
                                                                if (CurrentFieldDef.FieldType != NewFieldDef.FieldType || CurrentFieldDef.Lenght != NewFieldDef.Lenght || CurrentFieldDef.Precision != NewFieldDef.Precision)
                                                                        Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" TYPE " + NewFieldDef.SqlType();
                                                                if (CurrentFieldDef.Nullable != NewFieldDef.Nullable) {
                                                                        if (NewFieldDef.Nullable)
                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" SET NOT NULL";
                                                                        else
                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" DROP NOT NULL";
                                                                }
                                                                if (CurrentFieldDef.DefaultValue != NewFieldDef.DefaultValue && NewFieldDef.FieldType != DbTypes.Serial) {
                                                                        //Cambio de default value (salvo en Serial, que en PostgreSQL es siempre 0)
                                                                        switch (NewFieldDef.FieldType) {
                                                                                case DbTypes.VarChar:
                                                                                case DbTypes.Text:
                                                                                        if (NewFieldDef.DefaultValue == null)
                                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" SET DEFAULT ''";
                                                                                        else if (NewFieldDef.DefaultValue == "NULL")
                                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" SET DEFAULT NULL";
                                                                                        else
                                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" SET DEFAULT '" + NewFieldDef.DefaultValue + "'";
                                                                                        break;
                                                                                default:
                                                                                        if (NewFieldDef.DefaultValue != null && NewFieldDef.DefaultValue.Length > 0)
                                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" SET DEFAULT " + NewFieldDef.DefaultValue;
                                                                                        else
                                                                                                Sql += ", ALTER COLUMN \"" + NewFieldDef.Name + "\" DROP DEFAULT";
                                                                                        break;
                                                                        }
                                                                }
                                                                if (Sql.Length > 0)
                                                                        Sql = "ALTER TABLE \"" + newTableDef.Name + "\"" + Sql.Substring(1, Sql.Length - 1);
                                                                else
                                                                        Sql = null;
                                                        } else {
                                                                Sql = "ALTER TABLE \"" + newTableDef.Name + "\" CHANGE \"" + NewFieldDef.Name + "\" \"" + NewFieldDef.Name + "\" " + NewFieldDef.SqlDefinition();
                                                        }
                                                }
                                        }

                                        if (Sql != null)
                                                this.Execute(this.CustomizeSql(Sql));
                                }

                                /*
                                 * NO DROPEAR COLUMNAS DESCONOCIDAS
                                foreach (Data.ColumnDefinition FieldDef in CurrentTableDef.Columns.Values) {
                                        if (newTableDef.Columns.ContainsKey(FieldDef.Name) == false) {
                                                string Sql = "ALTER TABLE \"" + newTableDef.Name + "\" DROP \"" + FieldDef.Name + "\"";
                                                this.Execute(this.CustomizeSql(Sql));
                                        }
                                }
                                */
                        }

                        //Índices
                        //Crear y modificar
                        if (newTableDef.Indexes != null) {
                                foreach (Data.IndexDefinition NewIndex in newTableDef.Indexes.Values) {
                                        if (NewIndex.Primary && this.AccessMode == AccessModes.Npgsql)
                                                NewIndex.Name = NewIndex.TableName + "_pkey";

                                        bool Create = false;
                                        if (CurrentTableDef.Indexes == null || CurrentTableDef.Indexes.ContainsKey(NewIndex.Name) == false) {
                                                //No existe, lo creo
                                                Create = true;
                                        } else {
                                                //Existe
                                                Data.IndexDefinition CurrentIndex = CurrentTableDef.Indexes[NewIndex.Name];
                                                if (CurrentIndex != NewIndex) {
                                                        //Es diferente, lo modifico (lo elimino y lo creo nuevamente)
                                                        this.DropIndex(CurrentIndex);
                                                        Create = true;
                                                }
                                        }

                                        //Al crear la tabla, se crea la clave primaria y no necesito crearla aquí
                                        if (Create && (TablaCreada == false || NewIndex.Primary == false)) {
                                                this.CreateIndex(NewIndex);
                                        }
                                }
                        }
                        //Eliminar
                        if (CurrentTableDef.Indexes != null) {
                                foreach (Data.IndexDefinition CurrentIndex in CurrentTableDef.Indexes.Values) {
                                        if (CurrentIndex.Primary && CurrentIndex.Name != "PRIMARY")
                                                CurrentIndex.Name = "PRIMARY";
                                        // FIXME: eliminar indices innecesarios
                                        //if (newTableDef.Indexes.ContainsKey(CurrentIndex.Name) == false)
                                                //this.DropIndex(CurrentIndex);
                                }
                        }
                }

                public void CreateIndex(Data.IndexDefinition index)
                {
                        string Sql = null;
                        switch (this.AccessMode) {
                                case AccessModes.Npgsql:
                                        if (index.Primary)
                                                Sql = "ALTER TABLE \"" + index.TableName + "\" ADD PRIMARY KEY (\"" + String.Join(",", index.Columns).Replace(",", "\",\"") + "\"); ";
                                        else {
                                                Sql = "CREATE ";
                                                if (index.Unique)
                                                        Sql += " UNIQUE";
                                                Sql += " INDEX \"" + index.Name + "\" ON \"" + index.TableName + "\" (\"" + String.Join(",", index.Columns).Replace(",", "\",\"") + "\")";
                                        }
                                        break;
                                default:
                                        Sql = "ALTER TABLE \"" + index.TableName + "\" ADD " + index.SqlDefinition();
                                        break;
                        }
                        this.Execute(Sql);
                }

                public void DropIndex(Data.IndexDefinition index)
                {
                        string Sql;
                        switch (this.AccessMode) {
                                case AccessModes.Npgsql:
                                        if (index.Primary)
                                                Sql = "ALTER TABLE \"" + index.TableName + "\" DROP CONSTRAINT \"" + index.TableName + "_pkey\"";
                                        else
                                                Sql = "DROP INDEX \"" + index.Name + "\"";
                                        break;
                                default:
                                        if (index.Primary)
                                                Sql = "ALTER TABLE \"" + index.TableName + "\" DROP PRIMARY KEY";
                                        else
                                                Sql = "ALTER TABLE \"" + index.TableName + "\" DROP INDEX \"" + index.Name + "\"";
                                        break;
                        }
                        this.Execute(Sql);
                }

                public Data.TableStructure GetTableStructure(string tableName, bool withConstraints)
                {
                        Data.TableStructure TableDef = new Data.TableStructure();
                        TableDef.Name = tableName;

                        //requiere INFORMATION_SCHEMA. No compatible con MySql < 5 ni PostgreSQL < 7.4
                        string Sql;
                        if (this.AccessMode == AccessModes.Npgsql)
                                Sql = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='public' AND TABLE_CATALOG='" + this.DbConnection.Database + "' AND TABLE_NAME='" + tableName + "' ORDER BY ORDINAL_POSITION";
                        else
                                Sql = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='" + this.DbConnection.Database + "' AND TABLE_NAME='" + tableName + "' ORDER BY ORDINAL_POSITION";
                        System.Data.DataTable Columnas = this.Select(Sql);

                        if (Columnas.Rows.Count == 0)
                                return TableDef;

                        foreach (System.Data.DataRow Columna in Columnas.Rows) {
                                Data.ColumnDefinition FieldDef = new Data.ColumnDefinition();
                                FieldDef.Name = Columna["COLUMN_NAME"].ToString();
                                FieldDef.FieldType = Lfx.Data.Types.FromSQLType(Columna["DATA_TYPE"].ToString());
                                switch (FieldDef.FieldType) {
                                        case Lfx.Data.DbTypes.VarChar:
                                                FieldDef.Lenght = System.Convert.ToInt32(Columna["CHARACTER_MAXIMUM_LENGTH"]);
                                                break;
                                        case Lfx.Data.DbTypes.Numeric:
                                                FieldDef.Lenght = System.Convert.ToInt32(Columna["NUMERIC_PRECISION"]);
                                                if (FieldDef.Lenght == 0)
                                                        FieldDef.Lenght = 14;
                                                FieldDef.Precision = System.Convert.ToInt32(Columna["NUMERIC_SCALE"]);
                                                if (FieldDef.Precision == 0)
                                                        FieldDef.Precision = 4;
                                                break;
                                }
                                string COLUMN_TYPE = (this.AccessMode == AccessModes.Npgsql) ? "DATA_TYPE" : "COLUMN_TYPE";
                                if (Columna[COLUMN_TYPE].ToString().ToLower().IndexOf("unsigned") >= 0)
                                        FieldDef.Unsigned = true;

                                if (Columna["IS_NULLABLE"].ToString() == "NO")
                                        FieldDef.Nullable = false;
                                else
                                        FieldDef.Nullable = true;

                                if (!(Columna["COLUMN_DEFAULT"] == null || Columna["COLUMN_DEFAULT"] is DBNull)) {
                                        FieldDef.DefaultValue = Columna["COLUMN_DEFAULT"].ToString();

                                        switch (FieldDef.FieldType) {
                                                case DbTypes.Integer:
                                                case DbTypes.SmallInt:
                                                case DbTypes.Numeric:
                                                        if (Lfx.Types.Parsing.ParseDouble(FieldDef.DefaultValue) == 0)
                                                                FieldDef.DefaultValue = "0";
                                                        break;
                                                case DbTypes.DateTime:
                                                        if (FieldDef.DefaultValue == "0000-00-00 00:00:00")
                                                                FieldDef.DefaultValue = null;
                                                        break;
                                        }

                                        //Quito castings de PostgreSQL
                                        if (FieldDef.DefaultValue != null) {
                                                if (FieldDef.DefaultValue.EndsWith("::character varying"))
                                                        FieldDef.DefaultValue = FieldDef.DefaultValue.Substring(0, FieldDef.DefaultValue.Length - 19);
                                                else if (FieldDef.DefaultValue.EndsWith("::text"))
                                                        FieldDef.DefaultValue = FieldDef.DefaultValue.Substring(0, FieldDef.DefaultValue.Length - 6);

                                                if (FieldDef.DefaultValue.StartsWith("'") && FieldDef.DefaultValue.EndsWith("'"))
                                                        FieldDef.DefaultValue = FieldDef.DefaultValue.Substring(1, FieldDef.DefaultValue.Length - 2);	//Quito comillas
                                        }
                                } else {
                                        if (FieldDef.Nullable == false) {
                                                // null es sin default value, "NULL" es default to NULL
                                                FieldDef.DefaultValue = null;
                                        } else {
                                                switch (FieldDef.FieldType) {
                                                        case DbTypes.Text:
                                                        case DbTypes.Blob:
                                                        case DbTypes.DateTime:
                                                                // No pueden tener default value
                                                                FieldDef.DefaultValue = null;
                                                                break;
                                                        default:
                                                                FieldDef.DefaultValue = "NULL";
                                                                break;
                                                }
                                        }
                                }

                                //Es la clave autonumérica?
                                if (this.SqlMode == qGen.SqlModes.MySql && Columna["EXTRA"].ToString() == "auto_increment") {
                                        FieldDef.FieldType = DbTypes.Serial;
                                } else if (this.AccessMode == AccessModes.Npgsql && Columna["COLUMN_DEFAULT"].ToString().IndexOf("nextval(") >= 0) {
                                        FieldDef.FieldType = DbTypes.Serial;
                                }

                                if (this.SqlMode == qGen.SqlModes.MySql) {
                                        //Particularidades de MySQL
                                        if (Columna["COLUMN_KEY"].ToString() == "PRI")
                                                FieldDef.PrimaryKey = true;
                                }

                                TableDef.Columns.Add(FieldDef.Name, FieldDef);
                        }

                        //Indices
                        if (this.AccessMode == AccessModes.Npgsql) {
                                /*
                                Sql = @"SELECT a.table_catalog, a.table_schema, a.table_name, a.constraint_name AS INDEX_NAME, a.constraint_type, array_to_string(array(SELECT column_name::varchar FROM information_schema.key_column_usage WHERE constraint_name = a.constraint_name ORDER BY ordinal_position), ', ') as column_list, c.table_name, c.column_name
					FROM information_schema.table_constraints a 
					INNER JOIN information_schema.key_column_usage b
					ON a.constraint_name = b.constraint_name
					LEFT JOIN information_schema.constraint_column_usage c 
					ON a.constraint_name = c.constraint_name AND 
					   a.constraint_type = 'FOREIGN KEY'
					WHERE a.table_catalog='" + this.DbConnection.Database + @"' AND a.table_schema='public' AND a.table_name='" + tableName + @"'
					GROUP BY a.table_catalog, a.table_schema, a.table_name, 
						 a.constraint_name, a.constraint_type, 
						 c.table_name, c.column_name
					ORDER BY a.table_catalog, a.table_schema, a.table_name, 
						 a.constraint_name"; */
                                Sql = @"SELECT pg_attribute.attname AS COLUMN_NAME, pg_attribute.attnum,
	pg_class.relname AS TABLE_NAME,
	(CASE pg_index.indisunique WHEN 't' THEN 0 ELSE 1 END) AS NON_UNIQUE,
	(CASE pg_index.indisprimary WHEN 't' THEN 'PRIMARY KEY' ELSE '' END) AS CONSTRAINT_TYPE,
	(SELECT relname FROM pg_class WHERE pg_class.oid=pg_index.indexrelid) AS INDEX_NAME,
	pg_index.indexrelid,pg_class.relfilenode
     FROM pg_index
LEFT JOIN pg_class
       ON pg_index.indrelid  = pg_class.oid
LEFT JOIN pg_attribute
       ON pg_attribute.attrelid = pg_class.oid
      AND pg_attribute.attnum = ANY(indkey)
    WHERE pg_class.relname = '" + tableName + @"'";
                        } else {
                                Sql = @"SELECT NON_UNIQUE, INDEX_NAME, seq_in_index, COLUMN_NAME, collation, cardinality, sub_part, packed, nullable, index_type, comment
					FROM information_schema.STATISTICS
					WHERE table_schema = '" + this.DbConnection.Database + @"'
					AND table_name = '" + tableName + @"'
					ORDER BY index_name, seq_in_index";
                        }

                        System.Data.DataTable Indexes = this.Select(Sql);

                        if (Indexes.Rows.Count > 0) {
                                TableDef.Indexes = new System.Collections.Generic.Dictionary<string, IndexDefinition>();
                                foreach (System.Data.DataRow Index in Indexes.Rows) {
                                        string IndexName = Index["INDEX_NAME"].ToString();

                                        if (TableDef.Indexes.ContainsKey(IndexName)) {
                                                //Es un índice existente... agrego el campo
                                                string ColName = Index["COLUMN_NAME"].ToString();
                                                System.Array.Resize(ref TableDef.Indexes[IndexName].Columns, TableDef.Indexes[IndexName].Columns.Length + 1);
                                                TableDef.Indexes[IndexName].Columns[TableDef.Indexes[IndexName].Columns.Length - 1] = ColName;
                                                // Y marco la columna como primaria en la definición de la tabla
                                                switch (this.AccessMode) {
                                                        case AccessModes.MySql:
                                                                if (IndexName.ToUpperInvariant() == "PRIMARY")
                                                                        TableDef.Columns[ColName].PrimaryKey = true;
                                                                break;
                                                        case AccessModes.Npgsql:
                                                                if (Index["CONSTRAINT_TYPE"].ToString() == "PRIMARY KEY")
                                                                        TableDef.Columns[ColName].PrimaryKey = true;
                                                                break;
                                                }
                                        } else {
                                                //Es un índice nuevo
                                                Data.IndexDefinition NewIndex = new IndexDefinition(tableName);
                                                NewIndex.Name = Index["INDEX_NAME"].ToString();
                                                NewIndex.Columns = Index["COLUMN_NAME"].ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                                                NewIndex.Unique = System.Convert.ToInt32(Index["NON_UNIQUE"]) == 0;
                                                switch (this.AccessMode) {
                                                        case AccessModes.MySql:
                                                                if (IndexName.ToUpperInvariant() == "PRIMARY")
                                                                        NewIndex.Primary = true;
                                                                break;
                                                        case AccessModes.Npgsql:
                                                                if (Index["CONSTRAINT_TYPE"].ToString() == "PRIMARY KEY")
                                                                        NewIndex.Primary = true;
                                                                break;
                                                }
                                                TableDef.Indexes.Add(NewIndex.Name, NewIndex);
                                                if (NewIndex.Primary) {
                                                        // Pongo las columnas como primarias en la definición de la tabla
                                                        for (int i = 0; i < NewIndex.Columns.Length; i++) {
                                                                TableDef.Columns[NewIndex.Columns[i]].PrimaryKey = true;
                                                        }
                                                }
                                        }
                                }
                        }

                        if (withConstraints) {
                                //Claves foráneas
                                TableDef.Constraints = new System.Collections.Generic.Dictionary<string, ConstraintDefinition>();
                                System.Data.DataTable Constraints = this.Select(@"SELECT INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_TYPE,
					INFORMATION_SCHEMA.KEY_COLUMN_USAGE.COLUMN_NAME, INFORMATION_SCHEMA.KEY_COLUMN_USAGE.REFERENCED_TABLE_NAME, INFORMATION_SCHEMA.KEY_COLUMN_USAGE.REFERENCED_COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS, INFORMATION_SCHEMA.KEY_COLUMN_USAGE
					WHERE INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME=INFORMATION_SCHEMA.KEY_COLUMN_USAGE.CONSTRAINT_NAME
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_SCHEMA=INFORMATION_SCHEMA.KEY_COLUMN_USAGE.CONSTRAINT_SCHEMA
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_SCHEMA='" + this.DbConnection.Database + @"' AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME='" + tableName + @"'
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_TYPE='FOREIGN KEY'
						ORDER BY INFORMATION_SCHEMA.KEY_COLUMN_USAGE.ORDINAL_POSITION");
                                foreach (System.Data.DataRow Constraint in Constraints.Rows) {
                                        switch (Constraint["CONSTRAINT_TYPE"].ToString().ToUpper()) {
                                                case "FOREIGN KEY":
                                                        Data.ConstraintDefinition NewKey = new ConstraintDefinition(tableName);
                                                        NewKey.Name = Constraint["CONSTRAINT_NAME"].ToString();
                                                        NewKey.Column = Constraint["COLUMN_NAME"].ToString();
                                                        NewKey.ReferenceTable = Constraint["REFERENCED_TABLE_NAME"].ToString();
                                                        NewKey.ReferenceColumn = Constraint["REFERENCED_COLUMN_NAME"].ToString();
                                                        TableDef.Constraints.Add(NewKey.Name, NewKey);
                                                        break;
                                        }
                                }
                        }

                        return TableDef;
                }

                public void EmptyConstraints()
                {
                        //Borra todas las claves foráneas
                        System.Collections.Generic.Dictionary<string, ConstraintDefinition> CurrentConstraints = this.GetConstraints();
                        foreach (Data.ConstraintDefinition Con in CurrentConstraints.Values) {
                                string Sql = "ALTER TABLE \"" + Con.TableName + "\" DROP FOREIGN KEY \"" + Con.Name + "\"";
                                this.Execute(this.CustomizeSql(Sql));
                        }
                }

                public void SetConstraints(System.Collections.Generic.Dictionary<string, ConstraintDefinition> newConstraints, bool deleteOnly)
                {
                        // FIXME: "DROP FOREIGN KEY" puede ser léxico MySQL. MySQL puede soportar en un futuro la sintáxis "DROP CONSTRAINT" que es más estándar

                        System.Collections.Generic.Dictionary<string, ConstraintDefinition> CurrentConstraints = this.GetConstraints();
                        string Sql = null;
                        if (deleteOnly == false) {
                                foreach (Data.ConstraintDefinition NewCon in newConstraints.Values) {
                                        //Data.ConstraintDefinition CurrentCon;
                                        if (CurrentConstraints.ContainsKey(NewCon.Name) == false) {
                                                //Agregar
                                                Sql = "ALTER TABLE \"" + NewCon.TableName + "\" ADD CONSTRAINT \"" + NewCon.Name + "\" FOREIGN KEY (\"" + NewCon.Column + "\") REFERENCES \"" + NewCon.ReferenceTable + "\" (\"" + NewCon.ReferenceColumn + "\") $DEFERRABLE$";
                                                this.Execute(this.CustomizeSql(Sql));
                                        } else if (CurrentConstraints[NewCon.Name] != NewCon) {
                                                //No es igual... hay que modificarlo
                                                if (this.AccessMode == AccessModes.Npgsql)
                                                        Sql = "ALTER TABLE \"" + NewCon.TableName + "\" DROP CONSTRAINT \"" + NewCon.Name + "\"";
                                                else
                                                        Sql = "ALTER TABLE \"" + NewCon.TableName + "\" DROP FOREIGN KEY \"" + NewCon.Name + "\"";
                                                this.Execute(this.CustomizeSql(Sql));
                                                Sql = "ALTER TABLE \"" + NewCon.TableName + "\" ADD CONSTRAINT \"" + NewCon.Name + "\" FOREIGN KEY (\"" + NewCon.Column + "\") REFERENCES \"" + NewCon.ReferenceTable + "\" (\"" + NewCon.ReferenceColumn + "\") $DEFERRABLE$";
                                                this.Execute(this.CustomizeSql(Sql));
                                        }
                                }
                        } //deleteOnly

                        //Eliminar constraints obsoletas
                        foreach (Data.ConstraintDefinition CurCon in CurrentConstraints.Values) {
                                if (newConstraints.ContainsKey(CurCon.Name) == false) {
                                        Sql = "ALTER TABLE \"" + CurCon.TableName + "\" DROP FOREIGN KEY \"" + CurCon.Name + "\"";
                                        this.Execute(this.CustomizeSql(Sql));
                                }
                        }
                }

                public System.Collections.Generic.Dictionary<string, ConstraintDefinition> GetConstraints()
                {
                        System.Collections.Generic.Dictionary<string, ConstraintDefinition> Res = new System.Collections.Generic.Dictionary<string, ConstraintDefinition>();
                        //Claves foráneas
                        string SQL;
                        if (this.AccessMode == AccessModes.Npgsql) {
                                SQL = @"SELECT INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_TYPE,
					INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.COLUMN_NAME, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.table_name AS REFERENCED_TABLE_NAME, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.column_name AS REFERENCED_COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
					ON INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME=INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_CATALOG=INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_CATALOG
						WHERE INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_CATALOG='" + this.DbConnection.Database + @"'
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_TYPE='FOREIGN KEY'
						ORDER BY INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME";
                        } else {
                                SQL = @"SELECT INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME, INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_TYPE,
					INFORMATION_SCHEMA.KEY_COLUMN_USAGE.COLUMN_NAME, INFORMATION_SCHEMA.KEY_COLUMN_USAGE.REFERENCED_TABLE_NAME, INFORMATION_SCHEMA.KEY_COLUMN_USAGE.REFERENCED_COLUMN_NAME
					FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS, INFORMATION_SCHEMA.KEY_COLUMN_USAGE
					WHERE INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_NAME=INFORMATION_SCHEMA.KEY_COLUMN_USAGE.CONSTRAINT_NAME
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_SCHEMA=INFORMATION_SCHEMA.KEY_COLUMN_USAGE.CONSTRAINT_SCHEMA
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_SCHEMA='" + this.DbConnection.Database + @"'
						AND INFORMATION_SCHEMA.TABLE_CONSTRAINTS.CONSTRAINT_TYPE='FOREIGN KEY'
						ORDER BY INFORMATION_SCHEMA.TABLE_CONSTRAINTS.TABLE_NAME, INFORMATION_SCHEMA.KEY_COLUMN_USAGE.ORDINAL_POSITION";
                        }

                        System.Data.DataTable Constraints = this.Select(SQL);
                        foreach (System.Data.DataRow Constraint in Constraints.Rows) {
                                switch (Constraint["CONSTRAINT_TYPE"].ToString().ToUpper()) {
                                        case "FOREIGN KEY":
                                                Data.ConstraintDefinition NewKey = new ConstraintDefinition(Constraint["TABLE_NAME"].ToString());
                                                NewKey.Name = Constraint["CONSTRAINT_NAME"].ToString();
                                                NewKey.Column = Constraint["COLUMN_NAME"].ToString();
                                                NewKey.ReferenceTable = Constraint["REFERENCED_TABLE_NAME"].ToString();
                                                NewKey.ReferenceColumn = Constraint["REFERENCED_COLUMN_NAME"].ToString();
                                                Res.Add(NewKey.Name, NewKey);
                                                break;
                                }
                        }
                        return Res;
                }

                private void Connection_StateChange(Object sender, System.Data.StateChangeEventArgs e)
                {
                        if (m_Closing)
                                return;

                        if (e.OriginalState == System.Data.ConnectionState.Open &&
                                (e.CurrentState == System.Data.ConnectionState.Closed ||
                                e.CurrentState == System.Data.ConnectionState.Broken ||
                                e.CurrentState == System.Data.ConnectionState.Connecting)) {
                                //Estaba OK y ahora está mal
                                while (true) {
                                        int intentos = 10;
                                        while (this.DbConnection.State != System.Data.ConnectionState.Open && intentos-- > 0) {
                                                try {
                                                        this.Open();
                                                } catch {
                                                        System.Threading.Thread.Sleep(1000);
                                                }
                                        }
                                        if (this.DbConnection.State == System.Data.ConnectionState.Open)
                                                break;
                                        else if (--intentos == 0)
                                                break;
                                }
                        }
                }

                private bool TryToRecover(Exception ex)
                {
                        // Intento recuperar algunos errores de MySQL desconectando y volviendo a conectar
                        // Pero sólo puedo hacer esto si no estoy en una transacción
                        if (EnableRecover == true && m_InTransaction == false && ex.Source == "MySql.Data" &&
                                (ex.Message.IndexOf("server has gone away", StringComparison.InvariantCultureIgnoreCase) >= 0
                                || ex.Message.IndexOf("se ha desactivado la conexión", StringComparison.InvariantCultureIgnoreCase) >= 0
                                || ex.Message.IndexOf("Referencia a objeto no establecida como instancia de un objeto", StringComparison.InvariantCultureIgnoreCase) >= 0
                                || ex.Message.IndexOf("Object reference not set to an instance of an object", StringComparison.InvariantCultureIgnoreCase) >= 0
                                || ex.Message.IndexOf("Fatal error encountered during command execution", StringComparison.InvariantCultureIgnoreCase) >= 0
                                || ex.Message.IndexOf("Connection must be valid and open", StringComparison.InvariantCultureIgnoreCase) >= 0
                                || ex.Message.IndexOf("el estado actual de la conexión es cerrada", StringComparison.InvariantCultureIgnoreCase) >= 0
                                )) {

                                if (this.IsOpen())
                                        return false;

                                EnableRecover = false;

                                if (DbConnection != null && DbConnection.State != System.Data.ConnectionState.Closed)
                                        this.Close();

                                System.Threading.Thread.Sleep(500);

                                int intentos = 3;
                                while ((DbConnection == null || DbConnection.State != System.Data.ConnectionState.Open) && intentos-- > 0) {
                                        try {
                                                this.Open();
                                        }
                                        catch (Exception ex2) {
                                                System.Threading.Thread.Sleep(1000);
                                        }
                                }
                                EnableRecover = true;
                                return false;
                        } else {
                                return true;
                        }
                }
		
		public void Dispose()
		{
                        if (this.Handle == 0 && this.Workspace.Disposing == false) {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw new InvalidOperationException("No se puede deshechar el espacio de trabajo maestro");
                                return;
                        } else {
                                this.Workspace.ActiveConnections.Remove(this);
                                this.Workspace.DebugLog(this.Handle, "Deshechando " + this.Name, null);
                                this.Close();

                                if (KeepAliveTimer != null) {
                                        KeepAliveTimer.Dispose();
                                        KeepAliveTimer = null;
                                }

                                if (DbConnection != null) {
                                        DbConnection.Dispose();
                                        DbConnection = null;
                                }
                        }
		}


                public bool Close()
                {
                        if (this.DbConnection != null) {
                                m_Closing = true;
                                try {
                                        KeepAliveTimer.Stop();
                                        
                                        if (DbConnection.State == System.Data.ConnectionState.Open)
                                                DbConnection.Close();
                                } catch {
                                        if (Lfx.Environment.SystemInformation.DesignMode)
                                                throw;
                                }
                                m_Closing = false;
                        }

                        return false;
                }

                public System.Data.IDbCommand GetCommand(string commandText)
                {
                        System.Data.IDbCommand TempCommand = Lfx.Data.DataBaseCache.DefaultCache.Provider.GetCommand();
                        TempCommand.Connection = this.DbConnection;
                        TempCommand.CommandText = commandText;

                        return TempCommand;
                }

                public System.Data.IDbCommand GetCommand(qGen.Command command)
                {
                        System.Data.IDbCommand TempCommand = Lfx.Data.DataBaseCache.DefaultCache.Provider.GetCommand();
                        TempCommand.Connection = this.DbConnection;
                        command.SetupDbCommand(ref TempCommand);

                        return TempCommand;
                }

                public int Update(qGen.Update updateCommand)
                {
                        updateCommand.SqlMode = this.SqlMode;

                        if (this.IsOpen() == false)
                                this.Open();

                        System.Data.IDbCommand TempCommand = this.GetCommand(updateCommand);
                        while (true) {
                                try {
                                        TempCommand.Connection = this.DbConnection;
                                        this.ResetKeepAliveTimer();
                                        int Res = TempCommand.ExecuteNonQuery();
                                        TempCommand.Dispose();
                                        return Res;
                                }
                                catch (Exception ex) {
                                        if (this.TryToRecover(ex))
                                                throw;
                                }
                        }
                }

                public int Delete(qGen.Delete deleteCommand)
                {
                        deleteCommand.SqlMode = this.SqlMode;

                        if (this.IsOpen() == false)
                                this.Open();

                        return this.Execute(deleteCommand.ToString());
                }

                public int Insert(qGen.Insert insertCommand)
                {
                        insertCommand.SqlMode = this.SqlMode;

                        if (this.IsOpen() == false)
                                this.Open();

                        System.Data.IDbCommand TempCommand = this.GetCommand(insertCommand);
                        try {
                                return TempCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex) {
                                this.LogError("----------------------------------------------------------------------------");
                                this.LogError(ex.Message);
                                this.LogError(TempCommand.CommandText);
                                return 0;
                        }
                }


                // FIXME: Debería ser private o no existir
                public int Execute(string sqlCommand)
                {
                        // TODO: esto debería hacerlo no sólo en DesignMode
                        if (this.RequiresTransaction && this.InTransaction == false && Lfx.Environment.SystemInformation.DesignMode)
                                throw new InvalidOperationException("No se permite la ejecución de comandos fuera de una transacción en la conexión " + this.Name);

                        sqlCommand = sqlCommand.Trim(new char[] { ' ', (char)13, (char)10, (char)9 });
                        if (sqlCommand.Length == 0)
                                return 0;

                        return this.ExecuteNonQuery(this.GetCommand(sqlCommand));
                }

                public int Execute(qGen.Command sqlCommand)
                {
                        if (sqlCommand is qGen.Update || sqlCommand is qGen.Insert || sqlCommand is qGen.Delete) {
                                // TODO: esto debería hacerlo no sólo en DesignMode
                                if (this.RequiresTransaction && this.InTransaction == false && Lfx.Environment.SystemInformation.DesignMode)
                                        throw new InvalidOperationException("No se permite la ejecución de comandos fuera de una transacción en la conexión " + this.Name);
                        }
                        sqlCommand.SqlMode = this.SqlMode;
                        using (System.Data.IDbCommand Cmd = this.GetCommand(sqlCommand)) {
                                return this.ExecuteNonQuery(Cmd);
                        }
                }

                private int ExecuteNonQuery(System.Data.IDbCommand command)
                {
                        if (this.IsOpen() == false)
                                this.Open();

                        int Intentos = 3;
                        while (true) {
                                try {
                                        if (command.Connection == null)
                                                command.Connection = this.DbConnection;

                                        this.ResetKeepAliveTimer();
                                        PerfCounter.Reset();
                                        PerfCounter.Start();
                                        int Res = command.ExecuteNonQuery();
                                        PerfCounter.Stop();
                                        this.Workspace.DebugLog(this.Handle, command.CommandText, PerfCounter);
                                        return Res;
                                } catch (Exception ex)  {
                                        if (this.TryToRecover(ex) || Intentos-- <= 0) {
                                                LogError("----------------------------------------------------------------------------");
                                                LogError(ex.Message);
                                                LogError(command.CommandText);
                                                throw;
                                        }
                                }
                        }
                }

                public string FieldString(qGen.Select selectCommand)
                {
                        selectCommand.SqlMode = this.SqlMode;
                        object Res = this.ConnExecuteScalar(selectCommand.ToString());
                        if (Res == null || Res is DBNull)
                                return null;
                        else
                                return Res.ToString();
                }

                public string FieldString(string selectCommand)
                {
                        object Res = this.ConnExecuteScalar(selectCommand);
                        if (Res == null || Res is DBNull)
                                return null;
                        else
                                return Res.ToString();
                }

                public string FieldIntCSV(string selectCommand)
                {
                        System.Data.DataTable TmpTable = this.Select(selectCommand);
                        if (TmpTable == null || TmpTable.Rows.Count == 0) {
                                return string.Empty;
                        } else {
                                System.Text.StringBuilder Result = new System.Text.StringBuilder();
                                foreach (System.Data.DataRow Registro in TmpTable.Rows) {
                                        if (Result.Length == 0)
                                                Result.Append(Registro[0].ToString());
                                        else
                                                Result.Append("," + Registro[0].ToString());
                                }
                                return Result.ToString();
                        }
                }


                private object ConnExecuteScalar(string selectCommand)
                {
                        if (this.IsOpen() == false)
                                this.Open();

                        System.Data.IDbCommand Cmd = this.GetCommand(selectCommand);
                        int Intentos = 3;
                        while (true) {
                                try {
                                        PerfCounter.Reset();
                                        PerfCounter.Start();
                                        object Res = Cmd.ExecuteScalar();
                                        PerfCounter.Stop();
                                        this.Workspace.DebugLog(this.Handle, selectCommand, PerfCounter);
                                        return Res;
                                }
                                catch (Exception ex) {
                                        if (this.TryToRecover(ex) || Intentos-- <= 0) {
                                                LogError("----------------------------------------------------------------------------");
                                                LogError(ex.Message);
                                                LogError(selectCommand);
                                                throw;
                                        }
                                }
                        }
                }

                public int FieldInt(string selectCommand)
                {
                        object Res = this.ConnExecuteScalar(selectCommand);
                        if (Res == null || Res is DBNull)
                                return 0;
                        else
                                return System.Convert.ToInt32(Res);
                }

                public int FieldInt(qGen.Select selectCommand)
                {
                        selectCommand.SqlMode = this.SqlMode;
                        object Res = this.ConnExecuteScalar(selectCommand.ToString());
                        if (Res == null || Res is DBNull)
                                return 0;
                        else
                                return System.Convert.ToInt32(Res);
                }

                public DateTime FieldDateTime(string selectCommand, DateTime defaultValue)
                {
                        object Res = this.ConnExecuteScalar(selectCommand);
                        if (Res == null || Res is DBNull)
                                return defaultValue;
                        else
                                return System.Convert.ToDateTime(Res);
                }

                public double FieldDouble(qGen.Select selectCommand)
                {
                        selectCommand.SqlMode = this.SqlMode;
                        object Res = this.ConnExecuteScalar(selectCommand.ToString());
                        if (Res == null || Res is DBNull)
                                return 0;
                        else
                                return System.Convert.ToDouble(Res);
                }

                public double FieldDouble(string selectCommand)
                {
                        object Res = this.ConnExecuteScalar(selectCommand);
                        if (Res == null || Res is DBNull)
                                return 0;
                        else
                                return System.Convert.ToDouble(Res);
                }

                public decimal FieldDecimal(string selectCommand)
                {
                        object Res = this.ConnExecuteScalar(selectCommand);
                        if (Res == null || Res is DBNull)
                                return 0;
                        else
                                return System.Convert.ToDecimal(Res);
                }

                public decimal FieldDecimal(qGen.Select selectCommand)
                {
                        selectCommand.SqlMode = this.SqlMode;
                        object Res = this.ConnExecuteScalar(selectCommand.ToString());
                        if (Res == null || Res is DBNull)
                                return 0;
                        else
                                return System.Convert.ToDecimal(Res);
                }

                public Lfx.Data.Row Row(string tableName, string fieldList, string idField, int id)
                {
                        return this.FirstRowFromSelect("SELECT " + fieldList + " FROM " + tableName + " WHERE " + idField + "=" + id.ToString());
                }

                public Lfx.Data.Row Row(string tableName, string idField, int id)
                {
                        return this.Row(tableName, "*", idField, id);
                }

                public Lfx.Data.Row FirstRowFromSelect(string selectCommand)
                {
                        /* System.Data.DataTable SelTbl = this.Select(selectCommand);
                        if (SelTbl.Rows.Count == 0)
                                return null;

                        Lfx.Data.Row Res = ((Lfx.Data.Row)(SelTbl.Rows[0]));
                        Res.IsNew = false;
                        return Res; */

                        using (System.Data.IDataReader Rdr = this.GetReader(selectCommand)) {
                                if (Rdr != null) {
                                        Lfx.Data.Row Res = null;
                                        if (Rdr.Read()) {
                                                Res = new Lfx.Data.Row();
                                                Res.IsNew = false;
                                                for (int i = 0; i < Rdr.FieldCount; i++) {
                                                        object Val = Rdr[i];
                                                        if (Val is DateTime && (DateTime)Val == DateTime.MinValue)
                                                                Res[Rdr.GetName(i)] = null;
                                                        else if (Val == DBNull.Value)
                                                                Res[Rdr.GetName(i)] = null;
                                                        else
                                                                Res[Rdr.GetName(i)] = Rdr[i];
                                                }
                                        }
                                        Rdr.Close();
                                        return Res;
                                } else {
                                        return null;
                                }
                        }
                }

                public Lfx.Data.Row FirstRowFromSelect(qGen.Select selectCommand)
                {
                        selectCommand.SqlMode = this.SqlMode;
                        return this.FirstRowFromSelect(selectCommand.ToString());
                }

                public bool IsOpen()
                {
                        return (this.ConectionState == System.Data.ConnectionState.Open) || (this.ConectionState == System.Data.ConnectionState.Executing) || (this.ConectionState == System.Data.ConnectionState.Fetching);
                }

                public System.Data.IDataReader GetReader(qGen.Select comando)
                {
                        comando.SqlMode = this.SqlMode;
                        return this.GetReader(comando.ToString());
                }

                protected System.Data.IDataReader GetReader(string selectCommand)
                {
                        if (this.IsOpen() == false)
                                this.Open();

                        System.Data.IDbCommand Cmd = this.GetCommand(selectCommand);
                        while (true) {
                                try {
                                        Cmd.Connection = this.DbConnection;
                                        this.ResetKeepAliveTimer();
                                        PerfCounter.Reset();
                                        PerfCounter.Start();
                                        System.Data.IDataReader Rdr = Cmd.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                                        PerfCounter.Stop();
                                        this.Workspace.DebugLog(this.Handle, selectCommand, PerfCounter);
                                        return Rdr;
                                }
                                catch (Exception ex) {
                                        if (this.TryToRecover(ex)) {
                                                LogError("----------------------------------------------------------------------------");
                                                LogError(ex.Message);
                                                LogError(selectCommand);
                                                throw;
                                        }
                                }
                        }
                }

                public System.Data.DataTable Select(qGen.Select selectCommand)
                {
                        selectCommand.SqlMode = this.SqlMode;
                        return Select(selectCommand.ToString());
                }

                public System.Data.DataTable Select(string selectCommand)
                {
                        if (this.IsOpen() == false)
                                this.Open();

                        // FIXME: se puede eliminar el uso de DataAdapter, con el siguiente código
                        /*
                        System.Data.DataTable Res = new System.Data.DataTable();
                        System.Data.IDataReader Lector = this.GetReader(selectCommand);
                        while (Lector.Read()) {
                                if(Res.Columns.Count == 0) {
                                        for (int i = 0; i < Lector.FieldCount; i++) {
                                                Type Tipo;
                                                if (Lector.IsDBNull(i))
                                                        Tipo = (new Object()).GetType();
                                                else
                                                        Tipo = Lector.GetValue(i).GetType();
                                                Res.Columns.Add(new System.Data.DataColumn(Lector.GetName(i), Tipo));
                                        }
                                }
                                
                                System.Data.DataRow Rw = Res.NewRow();
                                for (int i = 0; i < Lector.FieldCount; i++) {
                                        Rw[i] = Lector[i];
                                }
                                Res.Rows.Add(Rw);
                        }
                        Lector.Close();
                        return Res; */

                        // Esto detecta SELECT con WHERE que no encuentren índices apropiados
                        /* if (Lfx.Environment.SystemInformation.DesignMode && selectCommand.Length > 7 && selectCommand.Substring(0, 7) == "SELECT " && selectCommand.IndexOf(" WHERE ") >= 0) {
                                System.Data.DataTable Explain = Select("EXPLAIN " + selectCommand);
                                foreach (System.Data.DataRow Rw in Explain.Rows) {
                                        if (Rw["key"] is DBNull || Rw["extra"].ToString() != "Using where")
                                                System.Console.WriteLine(selectCommand);
                                }
                        } */

                        PerfCounter.Reset();
                        PerfCounter.Start();
                        System.Data.IDbDataAdapter Adaptador = Lfx.Data.DataBaseCache.DefaultCache.Provider.GetAdapter(selectCommand, this.DbConnection);
                        using (System.Data.DataSet Lector = new System.Data.DataSet()) {
                                while (true) {
                                        try {
                                                this.ResetKeepAliveTimer();
                                                Adaptador.Fill(Lector);
                                                PerfCounter.Stop();
                                                this.Workspace.DebugLog(this.Handle, selectCommand, PerfCounter);
                                                break;
                                        } catch (Exception ex) {
                                                if (this.TryToRecover(ex)) {
                                                        LogError("----------------------------------------------------------------------------");
                                                        LogError(ex.Message);
                                                        LogError(selectCommand);
                                                        throw;
                                                }
                                        }
                                }
                                return Lector.Tables[0];
                        }
                }

                private void LogError(string texto)
                {
                        System.IO.StreamWriter wr = new System.IO.StreamWriter(new System.IO.FileStream(Lfx.Environment.Folders.ApplicationDataFolder + this.DataBaseName + ".log", System.IO.FileMode.Append));
                        wr.Write(System.DateTime.Now.ToString("yyyyMMddhhmmss") + "  " + texto + System.Environment.NewLine);
                        wr.Close();
                }


                private bool m_ConstraintsEnabled = true;
                public bool ConstraintsEnabled
                {
                        get
                        {
                                return m_ConstraintsEnabled;
                        }
                }

                public void EnableConstraints(bool enable)
                {
                        switch (this.SqlMode) {
                                case qGen.SqlModes.MySql:
                                        if (enable)
                                                this.Execute(new qGen.SetCommand("FOREIGN_KEY_CHECKS=1"));
                                        else
                                                this.Execute(new qGen.SetCommand("FOREIGN_KEY_CHECKS=0"));
                                        break;
                                case qGen.SqlModes.PostgreSql:
                                        if (enable)
                                                this.Execute(new qGen.SetCommand("CONSTRAINTS ALL IMMEDIATE"));
                                        else
                                                this.Execute(new qGen.SetCommand("CONSTRAINTS ALL DEFERRED"));
                                        break;
                        }
                        m_ConstraintsEnabled = enable;
                }

                public bool InTransaction
                {
                        get
                        {
                                return m_InTransaction;
                        }
                }


                public void BeginTransaction()
                {
                        if (this.Handle == 0 && Lfx.Environment.SystemInformation.DesignMode)
                                throw new InvalidOperationException("No se pueden realizar transacciones en el espacio de trabajo maestro");
                        this.BeginTransaction(true);
                }

                public void BeginTransaction(bool serializable)
                {
                        if (this.IsOpen() == false)
                                this.Open();

                        if (serializable)
                                this.SetTransactionIsolationLevel(Lfx.Data.IsolationLevels.Serializable);
                        else
                                this.SetTransactionIsolationLevel(Lfx.Data.DataBaseCache.DefaultCache.DefaultIsolationLevel);

                        if (m_InTransaction && Lfx.Environment.SystemInformation.DesignMode)
                                throw new InvalidOperationException("Ya se inició una transacción");

                        if (m_InTransaction == false) {
                                m_InTransaction = true;
                                this.Execute(new qGen.BeginTransactionCommand(this));
                        }
                }

                public void Commit()
                {
                        if (m_InTransaction == true) {
                                m_InTransaction = false;
                                try {
                                        this.Execute(new qGen.CommitCommand(this));
                                }
                                catch {
                                        this.Execute(new qGen.RollBackCommand(this));
                                        throw;
                                }
                        } else {
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw new InvalidOperationException("Commit(): sin BeginTransaction()");
                                else
                                        System.Console.WriteLine("Commit(): sin BeginTransaction()");
                        }
                }

                public void RollBack()
                {
                        this.Execute(new qGen.RollBackCommand(this));
                        m_InTransaction = false;
                }

                //Función: CustomizeSql
                //	Convierte un Sql "genérico" en Sql para un servidor en particular
                public string CustomizeSql(string sqlOrigen)
                {
                        switch (this.SqlMode) {
                                case qGen.SqlModes.MySql:
                                        sqlOrigen = sqlOrigen.Replace("$SERIAL$", "INTEGER AUTO_INCREMENT NOT NULL");
                                        sqlOrigen = sqlOrigen.Replace("$BLOB$", "LONGBLOB");
                                        sqlOrigen = sqlOrigen.Replace("$TIMESTAMP$", "DATETIME");
                                        sqlOrigen = sqlOrigen.Replace("$DATETIME$", "DATETIME");
                                        sqlOrigen = sqlOrigen.Replace("$/CREATETABLE$", " ENGINE=InnoDB CHARACTER SET=utf8");
                                        sqlOrigen = sqlOrigen.Replace("$DEFERRABLE$", string.Empty);
                                        break;
                                case qGen.SqlModes.PostgreSql:
                                        sqlOrigen = sqlOrigen.Replace("$SERIAL$", "SERIAL");
                                        sqlOrigen = sqlOrigen.Replace("$BLOB$", "BYTEA");
                                        sqlOrigen = sqlOrigen.Replace("$TIMESTAMP$", "TIMESTAMP");
                                        sqlOrigen = sqlOrigen.Replace("$DATETIME$", "TIMESTAMP");
                                        sqlOrigen = sqlOrigen.Replace("$/CREATETABLE$", string.Empty);
                                        sqlOrigen = sqlOrigen.Replace("$DEFERRABLE$", "DEFERRABLE");
                                        break;
                                case qGen.SqlModes.TransactSql:
                                        sqlOrigen = sqlOrigen.Replace("$SERIAL$", "INTEGER IDENTITY");
                                        sqlOrigen = sqlOrigen.Replace("BLOB", "VARBINARY");
                                        sqlOrigen = sqlOrigen.Replace("$TIMESTAMP$", "DATETIME");
                                        sqlOrigen = sqlOrigen.Replace("$DATETIME$", "DATETIME");
                                        sqlOrigen = sqlOrigen.Replace("$/CREATETABLE$", string.Empty);
                                        sqlOrigen = sqlOrigen.Replace("$DEFERRABLE$", string.Empty);
                                        break;
                                default:
                                        // Para servidores desconocidos, trato de utilizar ANSI
                                        sqlOrigen = sqlOrigen.Replace("$SERIAL$", "INTEGER GENERATED BY DEFAULT AS IDENTITY");
                                        sqlOrigen = sqlOrigen.Replace("BLOB", "VARBINARY");
                                        sqlOrigen = sqlOrigen.Replace("$TIMESTAMP$", "TIMESTAMP");
                                        sqlOrigen = sqlOrigen.Replace("$DATETIME$", "TIMESTAMP");
                                        sqlOrigen = sqlOrigen.Replace("$/CREATETABLE$", string.Empty);
                                        sqlOrigen = sqlOrigen.Replace("$DEFERRABLE$", string.Empty);
                                        break;
                        }
                        return sqlOrigen;
                }


                /// <summary>
                /// Toma "tabla.campo" y devulve "campo"
                /// </summary>
                public static string GetFieldName(string fieldName)
                {
                        int r = fieldName.IndexOf(" AS ");
                        if (r >= 0) {
                                // Si tiene una cláusula AS, ese es el nombre de la columna
                                return fieldName.Substring(r + 4, fieldName.Length - r - 4).Trim();
                        }

                        r = fieldName.IndexOf("(") + 1;
                        if (r > 0) {
                                // Si hay un parntesis asumo que es una función sin cláusula AS y por lo tanto lo devuelvo como viene
                                return fieldName;
                        }

                        r = fieldName.IndexOf(".") + 1;
                        if (r > 0) {
                                return fieldName.Substring(r, fieldName.Length - r).Trim();
                        } else {
                                return fieldName.Trim();
                        }
                }

                public string EscapeString(string stringValue)
                {
                        switch (this.SqlMode) {
                                case qGen.SqlModes.PostgreSql:
                                        return stringValue.Replace("'", "''");
                                case qGen.SqlModes.MySql:
                                default:
                                        return stringValue.Replace("'", "''").Replace(@"\", @"\\");
                        }
                }

                public static string EscapeString(string stringValue, qGen.SqlModes sqlMode)
                {
                        switch (sqlMode) {
                                case qGen.SqlModes.PostgreSql:
                                        return stringValue.Replace("'", "''");
                                case qGen.SqlModes.MySql:
                                default:
                                        return stringValue.Replace("'", "''").Replace(@"\", @"\\");
                        }
                }

                public override string ToString()
                {
                        return this.Name;
                }

                public static int ConvertDBNullToZero(object valor)
                {
                        if (valor == null || valor == DBNull.Value || valor == null)
                                return 0;
                        else
                                return System.Convert.ToInt32(valor);
                }

                public static object ConvertZeroToDBNull(int valor)
                {
                        if (valor == 0)
                                return DBNull.Value;
                        else
                                return valor;
                }


                public qGen.SqlModes SqlMode
                {
                        get
                        {
                                return Lfx.Data.DataBaseCache.DefaultCache.SqlMode;
                        }
                }

                public System.Data.ConnectionState ConectionState
                {
                        get
                        {
                                if (this.DbConnection != null) {
                                        System.Data.ConnectionState TempCS = this.DbConnection.State;
                                        return TempCS;
                                } else {
                                        return System.Data.ConnectionState.Closed;
                                }
                        }
                }

                public bool SlowLink
                {
                        get
                        {
                                return Lfx.Data.DataBaseCache.DefaultCache.SlowLink;
                        }
                }

                public string DataBaseName
                {
                        get
                        {
                                return Lfx.Data.DataBaseCache.DefaultCache.DataBaseName;
                        }
                }

                public AccessModes AccessMode
                {
                        get
                        {
                                return Lfx.Data.DataBaseCache.DefaultCache.AccessMode;
                        }
                }

                /// <summary>
                /// Obtiene el primer comando SQL en una lista separada por punto y coma. Elimina el comando de la lista.
                /// </summary>
                /// <param name="Comandos">La lista de comandos.</param>
                /// <returns>El primer comando de la lista.</returns>
                public static string GetNextCommand(ref string Comandos)
                {
                        if (Comandos != null && Comandos.Length == 0)
                                return "";

                        if (Comandos.Substring(Comandos.Length - 1, 1) != ";")
                                Comandos += ";";

                        char[] Caracteres = { '\'', Lfx.Types.ControlChars.Quote, ';', '\\' };
                        char Comilla = ' ';
                        int r = 0;
                        do {
                                r = Comandos.IndexOfAny(Caracteres, r);
                                switch (Comandos[r]) {
                                        case '\\':
                                                r++;
                                                break;
                                        case ';':
                                                if (Comilla == ' ') {
                                                        string Resultado = Comandos.Substring(0, r);
                                                        Comandos = Comandos.Substring(r + 1, Comandos.Length - (r + 1));
                                                        return Resultado;
                                                }
                                                break;
                                        case '\'':
                                                if (Comilla == Lfx.Types.ControlChars.Quote) {
                                                        // Nada
                                                } else if (Comandos.Length > r && Comandos[r + 1] == '\'') {
                                                        // Comilla escapeada. Ignoro
                                                        r++;
                                                } else if (Comilla == '\'') {
                                                        Comilla = ' ';
                                                } else {
                                                        Comilla = '\'';
                                                }
                                                break;
                                        case Lfx.Types.ControlChars.Quote:
                                                if (Comilla == '\'') {
                                                        // Nada
                                                } else if (Comilla == Lfx.Types.ControlChars.Quote) {
                                                        Comilla = ' ';
                                                } else {
                                                        Comilla = Lfx.Types.ControlChars.Quote;
                                                }
                                                break;
                                }

                                r++;
                        }
                        while (true);
                }
        }
}