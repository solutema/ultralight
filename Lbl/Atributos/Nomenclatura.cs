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

namespace Lbl.Atributos
{
        public class Nomenclatura : System.Attribute
        {
                public string NombreSingular { get; set; }
                public string Grupo { get; set; }

                /// <summary>
                /// Obtiene o establece un valor que indica si al mostrar el nombre del elemento debe prefijarse con el tipo.
                /// Por ejemplo "Artículo Manzana" (prefijado) vs. "Manzana" (no prefijado), o "Proveedor Juan Perez" vs. "Juan Perez".
                /// </summary>
                public bool PrefijarNombreConTipo { get; set; }

                public Nomenclatura()
                {
                }

                public Nomenclatura(string nombreSingular, string grupo)
                        : this(nombreSingular, grupo, false)
                {
                }

                public Nomenclatura(string nombreSingular, string grupo, bool prefijarNombreConTipo)
                {
                        this.NombreSingular = nombreSingular;
                        this.Grupo = Grupo;
                        this.PrefijarNombreConTipo = prefijarNombreConTipo;
                }

                public string NombrePlural
                {
                        get
                        {
                                string Res = "";
                                string[] Palabras = this.NombreSingular.Split(new char[] { ' ', '-' });
                                foreach (string Palabra in Palabras) {
                                        if (Palabra == "de" || Palabra == "con")
                                                Res += Palabra + " ";
                                        else if (Palabra == "del")
                                                Res += "de los ";
                                        else if (Palabra.EndsWith("s"))
                                                Res += Palabra + " ";
                                        else if ("aeiouáéíóúü".IndexOf(Palabra.Substring(Palabra.Length - 1, 1).ToLowerInvariant()) >= 0)
                                                Res += Palabra + "s ";
                                        else
                                                Res += Palabra + "es ";
                                }
                                return Res.Trim();
                        }
                }
        }
}
