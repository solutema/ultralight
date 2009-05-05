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

namespace Lws.Data
{
        /// <summary>
        /// Proporciona una vista de datos de nivel medio (abstracción baja). Permite acceder a los registros y operar con los datos sin escribir directamente en SQL.
        /// Vea Lfx.Data.DataBase para acceso de bajo nivel a los datos o Lbl.* para para acceso de alto nivel a los datos.
        /// </summary>
        public class DataView : IDisposable
        {
                public int Handle = 0;
                public static int LastHandle = 0;
                public Lws.Workspace Workspace;
                protected TableCollection m_Tables = null;
                public Lfx.Data.DataBase m_DataBase = null;

                public DataView()
                {
                        this.Handle = ++LastHandle;
                }

                public DataView(Lws.Workspace workspace)
                        :this()
                {
                        this.Workspace = workspace;
                }

		public void Dispose()
		{
			if(m_DataBase != null)
				m_DataBase.Dispose();
		}
		
		public TableCollection Tables
		{
			get
			{
				if(m_Tables == null) {
					this.m_Tables = new TableCollection(this);
                                        foreach (string TblName in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
						Table NewTable = new Table(this, TblName);
						switch(TblName) {
							case "sys_asl":
							case "sys_log":
							case "sys_programador":
							case "sys_quickpaste":
								NewTable.Cacheable = false;
								break;
						}
                                                if (Lfx.Data.DataBaseCache.DefaultCache.TableStructures.ContainsKey(TblName) && Lfx.Data.DataBaseCache.DefaultCache.TableStructures[TblName].PrimaryKey != null)
                                                        NewTable.PrimaryKey = Lfx.Data.DataBaseCache.DefaultCache.TableStructures[TblName].PrimaryKey.Name;
	                                	this.m_Tables.Add(NewTable);
					}
				}
				return m_Tables;
			}
		}

                //TODO: esto algún día debería ser protected
                public Lfx.Data.DataBase DataBase
                {
                        get
                        {
                                if (m_DataBase == null)
                                        m_DataBase = this.Workspace.GetDataBase();
                                return m_DataBase;
                        }
                        set
                        {
                                m_DataBase = value;
                        }
                }

		public void BeginTransaction()
		{
			this.DataBase.BeginTransaction();
		}

		public void Commit()
		{
			this.DataBase.Commit();
		}

		public void RollBack()
		{
			this.DataBase.RollBack();
		}

                public override string ToString()
                {
                        return "DataView " + Handle.ToString();
                }
        }
}
