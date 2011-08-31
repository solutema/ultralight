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

namespace Lbl
{
        /// <summary>
        /// Una colección Generica para ElementosDeDatos.
        /// </summary>
        public class ColeccionGenerica<T> : List<T>, IEnumerable<T> where T : ElementoDeDatos
        {
                public bool HayAgregados = false, HayQuitados = false;

                public Lfx.Data.Connection DataBase;
                // public List<T> List = new List<T>();

                public ColeccionGenerica()
                {
                }

                public ColeccionGenerica(Lfx.Data.Connection dataBase)
                        : this()
                {
                        this.DataBase = dataBase;
                }

                public ColeccionGenerica(Lfx.Data.Connection dataBase, System.Data.DataTable tabla)
                        : this(dataBase)
                {
                        this.DesdeDataTable(tabla);
                }

                public void DesdeDataTable(System.Data.DataTable tabla)
                {
                        this.Clear();
                        if (tabla != null) {
                                foreach (System.Data.DataRow Rw in tabla.Rows) {
                                        Lfx.Data.Row Lrw = (Lfx.Data.Row)Rw;
                                        this.AddFromRow(Lrw);
                                }
                        }
                        this.HayCambios = false;
                }

                new public void AddRange(IEnumerable<T> collection)
                {
                        foreach (T elem in collection) {
                                elem.Connection = this.DataBase;
                        }
                        base.AddRange(collection);
                        this.HayAgregados = true;
                }

                public void DesdeTable(Lfx.Data.Table tabla)
                {
                        this.Clear();
                        tabla.FastRows.LoadAll();
                        foreach (Lfx.Data.Row Lrw in tabla.FastRows.Values) {
                                this.AddFromRow(Lrw);
                        }
                        this.HayCambios = false;
                }

                public ColeccionGenerica(Lfx.Data.Table tabla)
                        : this(tabla.Connection)
                {
                        this.DesdeTable(tabla);
                }

                private void AddFromRow(Lfx.Data.Row row)
                {
                        T Elem = Instanciador.Instanciar<T>(this.DataBase, row);
                        this.Add(Elem);
                        this.HayAgregados = true;
                }

                /// <summary>
                /// Busca un elemento por su Id.
                /// </summary>
                public bool Contains(int id)
                {
                        foreach (T El in this) {
                                if (El != null && El.Id == id)
                                        return true;
                        }
                        return false;
                }

                /// <summary>
                /// Obtiene un Elemento por su Id.
                /// </summary>
                public T GetById(int id)
                {
                        foreach (T El in this) {
                                if (El != null && El.Id == id)
                                        return El;
                        }
                        return null;
                }

                public int[] GetAllIds()
                {
                        int[] Res = new int[this.Count];
                        int i = 0;
                        foreach (T El in this) {
                                Lbl.IElementoDeDatos El2 = El as Lbl.IElementoDeDatos;
                                if (El2 != null)
                                        Res[i++] = El2.Id;
                        }
                        return Res;
                }

                /// <summary>
                /// Agrega un elemento a la colección.
                /// </summary>
                new public void Add(T elemento)
                {
                        elemento.Connection = this.DataBase;
                        base.Add(elemento);
                        this.HayAgregados = true;
                }

                /// <summary>
                /// Elimina un elemento por su Id.
                /// </summary>
                public void RemoveById(int id)
                {
                        for (int i = 0; i < this.Count; i++) {
                                Lbl.IElementoDeDatos El2 = this[i] as Lbl.IElementoDeDatos;
                                if (El2 != null && El2.Id == id) {
                                        base.RemoveAt(i);
                                        this.HayQuitados = true;
                                        break;
                                }
                        }
                }

                public bool HayCambios
                {
                        get
                        {
                                return this.HayAgregados || this.HayQuitados;
                        }
                        set
                        {
                                this.HayQuitados = value;
                                this.HayAgregados = value;
                        }
                }

                /// <summary>
                /// Elimina un elemento de la lista.
                /// </summary>
                /// <param name="elemento">El elemento a eliminar.</param>
                new public void Remove(T elemento)
                {
                        base.Remove(elemento);
                        this.HayQuitados = true;
                }

                /// <summary>
                /// Devuelve una nueva colección, conteniendo los mismos elementos.
                /// </summary>
                public ColeccionGenerica<T> Clone()
                {
                        ColeccionGenerica<T> Res = new ColeccionGenerica<T>(this.DataBase);
                        foreach (T El in this) {
                                Res.Add(El);
                        }
                        return Res;
                }

                /// <summary>
                /// Devuelve una colección de elementos nuevos, en comparación con una colección original.
                /// </summary>
                /// <param name="original">La colección original.</param>
                /// <returns>La colección de los elementos presentes en esta colección, pero no en la original.</returns>
                public ColeccionGenerica<T> Agregados(ColeccionGenerica<T> original)
                {
                        ColeccionGenerica<T> Res = new ColeccionGenerica<T>();
                        foreach (T El in this) {
                                Lbl.IElementoDeDatos El2 = El as Lbl.IElementoDeDatos;
                                if(original.Contains(El2.Id) == false)
                                        Res.Add(El);
                        }
                        return Res;
                }

                /// <summary>
                /// Devuelve una colección de elementos faltantes, en comparación con una colección original.
                /// </summary>
                /// <param name="original">La colección original.</param>
                /// <returns>La colección de los elementos no presentes en esta colección, pero si en la original.</returns>
                public ColeccionGenerica<T> Quitados(ColeccionGenerica<T> original)
                {
                        ColeccionGenerica<T> Res = new ColeccionGenerica<T>();
                        foreach (T Elem in original) {
                                Lbl.IElementoDeDatos El2 = Elem as Lbl.IElementoDeDatos;
                                if (this.Contains(El2.Id) == false)
                                        Res.Add(Elem);
                        }
                        return Res;
                }

                public override string ToString()
                {
                        return this.ToString(", ");
                }

                public string ToString(string separator)
                {
                        System.Text.StringBuilder Res = new StringBuilder();

                        foreach (ElementoDeDatos Elem in this) {
                                if (Res.Length == 0)
                                        Res.Append(Elem.ToString());
                                else
                                        Res.Append(separator + Elem.ToString());
                        }

                        return Res.ToString();
                }
        }
}
