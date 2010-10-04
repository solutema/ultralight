#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
        public class ColeccionGenerica<T> where T : Lbl.ElementoDeDatos
        {
                public Lfx.Data.DataBase DataBase;
                public List<T> List = new List<T>();

                public ColeccionGenerica()
                {
                }

                public ColeccionGenerica(Lfx.Data.DataBase dataBase)
                        : this()
                {
                        this.DataBase = dataBase;
                }

                public ColeccionGenerica(Lfx.Data.DataBase dataBase, System.Data.DataTable tabla)
                        : this(dataBase)
                {
                        this.List.Clear();
                        foreach (System.Data.DataRow Rw in tabla.Rows) {
                                Lfx.Data.Row Lrw = (Lfx.Data.Row)Rw;
                                this.AddFromRow(Lrw);
                        }
                }

                public ColeccionGenerica(Lfx.Data.Table tabla)
                        : this(tabla.DataBase)
                {
                        this.List.Clear();
                        tabla.FastRows.LoadAll();
                        foreach (Lfx.Data.Row Lrw in tabla.FastRows.Values) {
                                this.AddFromRow(Lrw);
                        }
                }

                private void AddFromRow(Lfx.Data.Row row)
                {
                        T Elem = Instanciador.Instanciar<T>(this.DataBase, row);
                        this.List.Add(Elem);
                }

                /// <summary>
                /// Busca un elemento por su Id.
                /// </summary>
                public bool Contains(int id)
                {
                        foreach (T El in this.List) {
                                Lbl.ElementoDeDatos El2 = El as Lbl.ElementoDeDatos;
                                if (El2 != null && El2.Id == id)
                                        return true;
                        }
                        return false;
                }

                public T this[int index]
                {
                        get
                        {
                                return this.List[index];
                        }
                }

                public int[] GetAllIds()
                {
                        int[] Res = new int[this.Count];
                        int i = 0;
                        foreach (T El in this.List) {
                                Lbl.ElementoDeDatos El2 = El as Lbl.ElementoDeDatos;
                                if (El2 != null)
                                        Res[i++] = El2.Id;
                        }
                        return Res;
                }

                public int Count
                {
                        get
                        {
                                return this.List.Count;
                        }
                }

                /// <summary>
                /// Agrega un elemento a la colección.
                /// </summary>
                public void Add(T elemento)
                {
                        this.List.Add(elemento);
                }

                /// <summary>
                /// Elimina un elemento por su Id.
                /// </summary>
                public void RemoveById(int id)
                {
                        for (int i = 0; i < this.List.Count; i++) {
                                Lbl.ElementoDeDatos El2 = this.List[i] as Lbl.ElementoDeDatos;
                                if (El2 != null && El2.Id == id) {
                                        this.List.RemoveAt(i);
                                        break;
                                }
                        }
                }

                /// <summary>
                /// Devuelve una nueva colección, conteniendo los mismos elementos.
                /// </summary>
                public ColeccionGenerica<T> Clone()
                {
                        ColeccionGenerica<T> Res = new ColeccionGenerica<T>();
                        foreach (T El in this.List) {
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
                        foreach (T El in this.List) {
                                Lbl.ElementoDeDatos El2 = El as Lbl.ElementoDeDatos;
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
                        foreach (T Elem in original.List) {
                                Lbl.ElementoDeDatos El2 = Elem as Lbl.ElementoDeDatos;
                                if (this.Contains(El2.Id) == false)
                                        Res.Add(Elem);
                        }
                        return Res;
                }
        }
}
