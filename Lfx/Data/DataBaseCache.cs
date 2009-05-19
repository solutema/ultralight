// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
using System.Reflection;

namespace Lfx.Data
{
        public class DataBaseCache
        {
                public static DataBaseCache DefaultCache;

                private Lfx.Data.DataBase DataBase;

                public DataBaseCache(Lfx.Data.DataBase dataBase)
                {
                        this.DataBase = dataBase;
                }

                private System.Collections.Generic.List<string> m_TableList = null;
                private System.Collections.Generic.Dictionary<string, Lfx.Data.TagCollection> m_TagList = null; // Si... una colección de colecciones
                
                public Lfx.Data.Providers.Provider Provider = null;
                public string OdbcDriver = null;
                public string ServerName = null, DataBaseName, UserName, Password;
                public bool SlowLink = false, Mars = true;
                public Lfx.Data.AccessModes AccessMode = Lfx.Data.AccessModes.Undefined;
                public Lfx.Data.SqlModes SqlMode = Lfx.Data.SqlModes.Ansi;

                private System.Collections.Generic.Dictionary<string, Lfx.Data.ConstraintDefinition> m_Constraints = null;
                private System.Collections.Generic.Dictionary<string, Lfx.Data.TableStructure> m_TableStructures = null;

                public void Clear()
                {
                        ServerName = null;
                        DataBaseName = null;
                        UserName = null;
                        Password = null;
                        m_TableList = null;
                        m_TagList = null;
                        m_Constraints = null;
                        m_TableStructures = null;
                }

                public void CargarEstructuraDesdeXml(string nombreArchivo)
                {
                        System.IO.StreamReader Lector;
                        System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
                        if (nombreArchivo == null) {
                                string Espacio = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString();
                                System.IO.Stream RecursoXml = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(Espacio + ".Data.dbstruct.xml");
                                Lector = new System.IO.StreamReader(RecursoXml);
                                Doc.Load(Lector);
                                Lector.Close();
                                RecursoXml.Close();
                        } else {
                                Lector = new System.IO.StreamReader(nombreArchivo, System.Text.Encoding.Default);
                                Doc.Load(Lector);
                                Lector.Close();
                        }

                        m_Constraints = new System.Collections.Generic.Dictionary<string, Lfx.Data.ConstraintDefinition>();
                        System.Xml.XmlNodeList ClavesXml = Doc.SelectNodes("/Database/Constraint");
                        foreach (System.Xml.XmlNode ClaveXml in ClavesXml) {
                                Lfx.Data.ConstraintDefinition Con = new Lfx.Data.ConstraintDefinition(ClaveXml.Attributes["table"].Value);
                                Con.Name = ClaveXml.Attributes["name"].Value;
                                Con.Column = ClaveXml.Attributes["column"].Value;
                                Con.ReferenceTable = ClaveXml.Attributes["reference_table"].Value;
                                Con.ReferenceColumn = ClaveXml.Attributes["reference_column"].Value;
                                Constraints.Add(Con.Name, Con);
                        }

                        m_TableStructures = new System.Collections.Generic.Dictionary<string, Lfx.Data.TableStructure>();
                        System.Xml.XmlNodeList TablasXml = Doc.SelectNodes("/Database/Table");
                        foreach (System.Xml.XmlNode TablaXml in TablasXml) {
                                Lfx.Data.TableStructure Tabla = new Lfx.Data.TableStructure();
                                Tabla.Name = TablaXml.Attributes["name"].Value;
                                Tabla.Columns = new System.Collections.Generic.Dictionary<string, Lfx.Data.ColumnDefinition>();

                                System.Xml.XmlNodeList ColumnasXml = TablaXml.SelectNodes("Column");
                                foreach (System.Xml.XmlNode ColumnaXml in ColumnasXml) {
                                        Lfx.Data.ColumnDefinition Columna = new Lfx.Data.ColumnDefinition();
                                        Columna.Name = ColumnaXml.Attributes["name"].Value;
                                        Columna.FieldType = Lfx.Data.Types.FromSQLType(ColumnaXml.Attributes["datatype"].Value);
                                        Columna.Nullable = System.Convert.ToBoolean(Lfx.Types.Parsing.ParseInt(ColumnaXml.Attributes["nullable"].Value));
                                        Columna.PrimaryKey = System.Convert.ToBoolean(Lfx.Types.Parsing.ParseInt(ColumnaXml.Attributes["primary_key"].Value));
                                        Columna.Lenght = Lfx.Types.Parsing.ParseInt(ColumnaXml.Attributes["lenght"].Value);
                                        Columna.Precision = Lfx.Types.Parsing.ParseInt(ColumnaXml.Attributes["precision"].Value);
                                        Columna.DefaultValue = ColumnaXml.Attributes["default"].Value;
                                        Tabla.Columns.Add(Columna.Name, Columna);
                                }

                                //Agrego los campos de sys_tags
                                if (this.TagList.ContainsKey(Tabla.Name)) {
                                        foreach (Data.Tag Tg in this.TagList[Tabla.Name]) {
                                                Lfx.Data.ColumnDefinition Columna = new Lfx.Data.ColumnDefinition();
                                                Columna.Name = Tg.FieldName;
                                                Columna.FieldType = Tg.FieldType;
                                                switch (Columna.FieldType) {
                                                        case Lfx.Data.DbTypes.VarChar:
                                                                Columna.Lenght = 200;
                                                                break;
                                                        case Lfx.Data.DbTypes.Numeric:
                                                                Columna.Lenght = 14;
                                                                Columna.Precision = 4;
                                                                break;
                                                }
                                                Columna.Nullable = Tg.Nullable;
                                                Columna.PrimaryKey = false;
                                                if (Tabla.Columns.ContainsKey(Tg.FieldName))
                                                        Tabla.Columns[Columna.Name] = Columna;
                                                else
                                                        Tabla.Columns.Add(Columna.Name, Columna);
                                        }
                                }

                                Tabla.Indexes = new System.Collections.Generic.Dictionary<string, Lfx.Data.IndexDefinition>();
                                System.Xml.XmlNodeList IndicesXml = TablaXml.SelectNodes("Index");
                                foreach (System.Xml.XmlNode IndiceXml in IndicesXml) {
                                        Lfx.Data.IndexDefinition Indice = new Lfx.Data.IndexDefinition(Tabla.Name);
                                        Indice.Name = IndiceXml.Attributes["name"].Value;
                                        Indice.Unique = System.Convert.ToBoolean(Lfx.Types.Parsing.ParseInt(IndiceXml.Attributes["unique"].Value));
                                        Indice.Primary = System.Convert.ToBoolean(Lfx.Types.Parsing.ParseInt(IndiceXml.Attributes["primary"].Value));
                                        Indice.Columns = new string[] { IndiceXml.Attributes["columns"].Value };
                                        Tabla.Indexes.Add(Indice.Name, Indice);
                                }

                                this.m_TableStructures.Add(Tabla.Name, Tabla);
                        }

                }

                public System.Collections.Generic.Dictionary<string, Lfx.Data.TagCollection> TagList
                {
                        get
                        {
                                if (m_TagList == null || m_TagList.Count == 0) {
                                        m_TagList = new System.Collections.Generic.Dictionary<string, Data.TagCollection>();
                                        if (this.TableList.Contains("sys_tags")) {
                                                System.Data.IDataReader Rdr = this.DataBase.GetReader("SELECT * FROM sys_tags ORDER BY tablename");
                                                while (Rdr.Read()) {
                                                        string TableName = Rdr["tablename"].ToString();
                                                        if (m_TagList.ContainsKey(TableName) == false)
                                                                m_TagList.Add(TableName, new Data.TagCollection());

                                                        Data.TagCollection CurrentCol = m_TagList[TableName];

                                                        Data.Tag NewTag = new Data.Tag(TableName, Rdr["fieldname"].ToString(), Rdr["label"].ToString());
                                                        NewTag.FieldType = Lfx.Data.Types.FromSQLType(Rdr["fieldtype"].ToString());
                                                        NewTag.Nullable = System.Convert.ToBoolean(Rdr["fieldnullable"]);
                                                        CurrentCol.Add(NewTag);
                                                }
                                                Rdr.Close();
                                        }
                                }
                                return m_TagList;
                        }
                }

                /// <summary>
                /// Obtiene una lista de tablas actualmente presente en la base de datos (puede no coincidir con dbstruct.xml)
                /// </summary>
                public System.Collections.Generic.List<string> TableList
                {
                        get
                        {
                                if (m_TableList == null) {
                                        m_TableList = new System.Collections.Generic.List<string>();
                                        System.Data.DataTable Tablas = null;
                                        switch (SqlMode) {
                                                case Lfx.Data.SqlModes.MySql:
                                                case Lfx.Data.SqlModes.Oracle:
                                                        Tablas = this.DataBase.Select("SHOW TABLES");
                                                        break;
                                                default:
                                                        Tablas = this.DataBase.Select("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_SCHEMA='public'");
                                                        break;
                                        }

                                        if (m_TableList != null) {
                                                foreach (System.Data.DataRow Tabla in Tablas.Rows) {
                                                        if (m_TableList.Contains(Tabla[0].ToString()) == false)
                                                                m_TableList.Add(Tabla[0].ToString());
                                                }
                                        }
                                }
                                return m_TableList;
                        }
                }

                /// <summary>
                /// Obtiene las claves foráneas desde dbstruct.xml (puede no coincidir con el contenido actual de la base de datos)
                /// </summary>
                public System.Collections.Generic.Dictionary<string, Lfx.Data.ConstraintDefinition> Constraints
                {
                        get
                        {
                                if (m_Constraints == null)
                                        this.CargarEstructuraDesdeXml(null);
                                return m_Constraints;
                        }
                }


                /// <summary>
                /// Obtiene las estructuras de las tablas desde dbstruct.xml (puede no coincidir con el contenido actual de la base de datos)
                /// </summary>
                public System.Collections.Generic.Dictionary<string, Lfx.Data.TableStructure> TableStructures
                {
                        get
                        {
                                if (m_TableStructures == null)
                                        this.CargarEstructuraDesdeXml(null);
                                return m_TableStructures;
                        }
                }
        }
}