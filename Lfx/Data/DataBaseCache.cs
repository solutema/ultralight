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
using System.Text;
using System.Reflection;

namespace Lfx.Data
{
        public class DataBaseCache
        {
                public static DataBaseCache DefaultCache;

                private Lfx.Data.Connection Connection;

                public DataBaseCache(Lfx.Data.Connection connection)
                {
                        this.Connection = connection;
                }
                
                public qGen.Providers.IProvider Provider = null;
                public string OdbcDriver = null;
                public string ServerName = null, DataBaseName, UserName, Password;
                public bool SlowLink = false, Mars = true;
                public Lfx.Data.AccessModes AccessMode = Lfx.Data.AccessModes.Undefined;
                public qGen.SqlModes SqlMode = qGen.SqlModes.Ansi;
                public System.Data.IsolationLevel DefaultIsolationLevel = System.Data.IsolationLevel.Serializable;

                public void Clear()
                {
                        ServerName = null;
                        DataBaseName = null;
                        UserName = null;
                        Password = null;
                }


                public Lfx.Data.TableCollection m_Tables = null;

                /// <summary>
                /// Devuelve una colección con las tablas de datos.
                /// </summary>
                public Lfx.Data.TableCollection Tables
                {
                        get
                        {
                                if (m_Tables == null || m_Tables.Count == 0) {
                                        m_Tables = this.Connection.GetTables();
                                }
                                return m_Tables;
                        }
                }


                /// <summary>
                /// Obtiene una lista de tablas actualmente presente en la base de datos (puede no coincidir con dbstruct.xml)
                /// </summary>
                public IList<string> GetTableNames()
                {
                        IList<string> m_TableList = new List<string>();

                        System.Data.DataTable Tablas = null;
                        switch (SqlMode) {
                                case qGen.SqlModes.MySql:
                                case qGen.SqlModes.Oracle:
                                        Tablas = this.Connection.Select("SHOW TABLES");
                                        break;
                                case qGen.SqlModes.SQLite:
                                        Tablas = this.Connection.Select("SELECT name FROM sqlite_master WHERE type='table'");
                                        break;
                                default:
                                        Tablas = this.Connection.Select("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_SCHEMA='public'");
                                        break;
                        }

                        foreach (System.Data.DataRow Tabla in Tablas.Rows) {
                                if (m_TableList.Contains(Tabla[0].ToString()) == false)
                                        m_TableList.Add(Tabla[0].ToString());
                        }

                        return m_TableList;
                }
        }
}