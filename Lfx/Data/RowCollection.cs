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

namespace Lfx.Data
{
        [Serializable]
        public class RowCollection : Dictionary<int, Lfx.Data.Row>
        {
                private System.DateTime LastCacheRefresh;
                protected Table Table;

                public RowCollection(Table table)
                {
                        this.Table = table;
                        LastCacheRefresh = System.DateTime.Now;
                }

                private bool LoadAll_Loaded = false;
                public void LoadAll()
                {
                        if (this.Table.Cacheable && LoadAll_Loaded)
                                return;

                        System.Data.DataTable Todo = this.Table.Connection.Select("SELECT * FROM " + this.Table.Name);
                        foreach(System.Data.DataRow Rw in Todo.Rows) {
                                Lfx.Data.Row NewRow = (Lfx.Data.Row)Rw;
                                NewRow.Table = this.Table;
                                int id = System.Convert.ToInt32(NewRow.Fields[this.Table.PrimaryKey].Value);
                                if (this.ContainsKey(id))
                                        this[id] = NewRow;
                                else
                                        this.Add(System.Convert.ToInt32(NewRow[this.Table.PrimaryKey]), NewRow);
                        }
                        LoadAll_Loaded = true;
                        LastCacheRefresh = System.DateTime.Now;
                }

                new public System.Collections.IEnumerator GetEnumerator()
                {
                        //GetEnumerator es llamado antes de un foreach. En ese caso, se cargan todos los registros en memoria.
                        this.LoadAll();
                        return base.GetEnumerator();
                }

                new public Lfx.Data.Row this[int id]
                {
                        get
                        {
                                if (System.DateTime.Now > LastCacheRefresh.AddMinutes(60)) {
                                        System.Console.WriteLine(DateTime.Now.ToShortTimeString() + " vaciando la caché de " + this.Table.Name);
                                        this.ClearCache();
                                        LastCacheRefresh = DateTime.Now;
                                }

                                if (Table.Cacheable == false || (Table.Connection.InTransaction && Table.AlwaysCache == false)) {
					// No uso el caché si hay una transacción activa o se esta tabla no es cacheable
                                        Lfx.Data.Row NewRow = this.Table.Connection.Row(this.Table.Name, this.Table.PrimaryKey, id) as Lfx.Data.Row;
					if (NewRow != null)
                                        	NewRow.Table = this.Table;
                                        return NewRow;
                                } else if (this.ContainsKey(id) == false) {
                                        Lfx.Data.Row NewRow = this.Table.Connection.Row(this.Table.Name, this.Table.PrimaryKey, id);
                                        if (NewRow != null) {
                                                NewRow.Table = this.Table;
                                                this.Add(id, NewRow);
                                        }
                                        return NewRow;
                                } else {
                                        return ((Lfx.Data.Row)(base[id]));
                                }
                        }
                        set
                        {
                                this.RemoveFromCache(id);
                                this.Add(id, value);
                        }
                }

                public Lfx.Data.Row Select(string fieldName, object value)
                {
                        if(fieldName == this.Table.PrimaryKey)
                                return this[(int)value];
                        
                        foreach(Lfx.Data.Row Rw in this.Values) {
                                if (Rw[fieldName] == value)
                                        return Rw;
                        }
                        return null;
                }

		public void ClearCache()
		{
			this.Clear();
                        LoadAll_Loaded = false;
		}

                public void RemoveFromCache(int id)
                {
                        if (this.ContainsKey(id))
                                this.Remove(id);
                }
        }
}
