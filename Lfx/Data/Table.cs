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

namespace Lfx.Data
{
        public class Table
        {
                public string Name;
                public bool AlwaysCache = false, Cacheable = true;
                public Connection Connection;

                private string m_PrimaryKey = null;
		protected RowCollection m_Rows = null;

                public Table(Connection connection, string name)
                {
			this.Connection = connection;
                        this.Name = name;
                }

		public RowCollection FastRows
                {
			get
			{
				if(m_Rows == null) {
		                        m_Rows = new RowCollection(this);
				}
				return m_Rows;
			}
		}

                public string PrimaryKey
                {
                        get
                        {
                                if (m_PrimaryKey == null && Lfx.Workspace.Master.Structure.Tables.ContainsKey(this.Name) && Lfx.Workspace.Master.Structure.Tables[this.Name].PrimaryKey != null)
                                        m_PrimaryKey = Lfx.Workspace.Master.Structure.Tables[this.Name].PrimaryKey.Name;

                                return m_PrimaryKey;
                        }
                }


                public void PreLoad()
                {
                        this.FastRows.LoadAll();
                }


                public Lfx.Data.TagCollection Tags
                {
			get
			{
                                if (Lfx.Workspace.Master.Structure.TagList.ContainsKey(this.Name) == false)
                                        Lfx.Workspace.Master.Structure.TagList.Add(this.Name, new Lfx.Data.TagCollection());

                                return Lfx.Workspace.Master.Structure.TagList[this.Name];
			}
                }

                public override string ToString()
                {
                        return this.Name;
                }
        }
}
