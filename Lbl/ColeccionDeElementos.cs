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
using System.Collections.Generic;
using System.Text;

namespace Lbl
{
        /// <summary>
        /// Una colección de ElementosDeDatos.
        /// </summary>
        public class ColeccionDeElementos : System.Collections.CollectionBase
        {
                /// <summary>
                /// Busca un elemento por su Id.
                /// </summary>
                public bool Contains(int id)
                {
                        foreach (Lbl.ElementoDeDatos El in this.List) {
                                if (El.Id == id)
                                        return true;
                        }
                        return false;
                }

                public string[] Ids()
                {
                        string[] Res = new string[this.Count];
                        int i = 0;
                        foreach (Lbl.ElementoDeDatos El in this.List) {
                                Res[i++] = El.Id.ToString();
                        }
                        return Res;
                }

                /// <summary>
                /// Agrega un elemento a la colección.
                /// </summary>
                public void Add(ElementoDeDatos elemento)
                {
                        this.List.Add(elemento);
                }

                /// <summary>
                /// Elimina un elemento por su Id.
                /// </summary>
                public void RemoveById(int id)
                {
                        for (int i = 0; i < this.List.Count; i++) {
                                if (((Lbl.ElementoDeDatos)(this.List[i])).Id == id) {
                                        this.List.RemoveAt(i);
                                        break;
                                }
                        }
                }

                /// <summary>
                /// Devuelve una nueva colección, conteniendo los mismos elementos.
                /// </summary>
                public ColeccionDeElementos Clone()
                {
                        ColeccionDeElementos Res = new ColeccionDeElementos();
                        foreach (ElementoDeDatos El in this) {
                                Res.Add(El);
                        }
                        return Res;
                }

                /// <summary>
                /// Devuelve una colección de elementos nuevos, en comparación con una colección original.
                /// </summary>
                /// <param name="original">La colección original.</param>
                /// <returns>La colección de los elementos presentes en esta colección, pero no en la original.</returns>
                public ColeccionDeElementos Agregados(ColeccionDeElementos original)
                {
                        ColeccionDeElementos Res = new ColeccionDeElementos();
                        foreach (ElementoDeDatos El in this) {
                                if(original.Contains(El.Id) == false)
                                        Res.Add(El);
                        }
                        return Res;
                }

                /// <summary>
                /// Devuelve una colección de elementos faltantes, en comparación con una colección original.
                /// </summary>
                /// <param name="original">La colección original.</param>
                /// <returns>La colección de los elementos no presentes en esta colección, pero si en la original.</returns>
                public ColeccionDeElementos Quitados(ColeccionDeElementos original)
                {
                        ColeccionDeElementos Res = new ColeccionDeElementos();
                        foreach (ElementoDeDatos El in original) {
                                if (this.Contains(El.Id) == false)
                                        Res.Add(El);
                        }
                        return Res;
                }
        }
}
