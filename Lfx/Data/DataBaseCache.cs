#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
                
                public qGen.Providers.Provider Provider = null;
                public string OdbcDriver = null;
                public string ServerName = null, DataBaseName, UserName, Password;
                public bool SlowLink = false, Mars = true;
                public Lfx.Data.AccessModes AccessMode = Lfx.Data.AccessModes.Undefined;
                public qGen.SqlModes SqlMode = qGen.SqlModes.Ansi;
                public Lfx.Data.IsolationLevels DefaultIsolationLevel = IsolationLevels.Serializable;

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
                                        m_Tables = new Lfx.Data.TableCollection(Lfx.Workspace.Master.MasterConnection);
                                        foreach (string TblName in Lfx.Data.DataBaseCache.DefaultCache.GetTableNames()) {
                                                Lfx.Data.Table NewTable = new Lfx.Data.Table(Lfx.Workspace.Master.MasterConnection, TblName);
                                                switch (TblName) {
                                                        case "alicuotas":
                                                        case "articulos_codigos":
                                                        case "articulos_situaciones":
                                                        case "bancos":
                                                        case "cajas":
                                                        case "conceptos":
                                                        case "ciudades":
                                                        case "documentos_tipos":
                                                        case "formaspago":
                                                        case "impresoras":
                                                        case "lared_convenios":
                                                        case "margenes":
                                                        case "monedas":
                                                        case "personas_tipos":
                                                        case "pvs":
                                                        case "situaciones":
                                                        case "sucursales":
                                                        case "sys_permisos_objetos":
                                                        case "sys_plantillas":
                                                        case "sys_tags":
                                                        case "tickets_estados":
                                                        case "tipo_doc":
                                                                NewTable.AlwaysCache = true;
                                                                break;

                                                        case "sys_asl":
                                                        case "sys_log":
                                                        case "sys_programador":
                                                        case "sys_quickpaste":
                                                                NewTable.Cacheable = false;
                                                                break;
                                                }
                                                m_Tables.Add(NewTable);
                                        }
                                }
                                return m_Tables;
                        }
                }


                /// <summary>
                /// Obtiene una lista de tablas actualmente presente en la base de datos (puede no coincidir con dbstruct.xml)
                /// </summary>
                public System.Collections.Generic.List<string> GetTableNames()
                {
                        System.Collections.Generic.List<string> m_TableList = new List<string>();

                        if (m_TableList == null || m_TableList.Count == 0) {
                                if (m_TableList == null)
                                        m_TableList = new System.Collections.Generic.List<string>();
                                System.Data.DataTable Tablas = null;
                                switch (SqlMode) {
                                        case qGen.SqlModes.MySql:
                                        case qGen.SqlModes.Oracle:
                                                Tablas = this.Connection.Select("SHOW TABLES");
                                                break;
                                        default:
                                                Tablas = this.Connection.Select("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_SCHEMA='public'");
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
}