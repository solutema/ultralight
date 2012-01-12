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
        public class Datos : System.Attribute
        {
                public string NombreSingular { get; set; }
                public string Grupo { get; set; }
                public string TablaDatos { get; set; }
                public string CampoId { get; set; }
                public string CampoNombre { get; set; }
                public string CampoImagen { get; set; }
                public string TablaImagenes { get; set; }

                public Datos()
                {
                        this.CampoNombre = "nombre";
                        this.CampoImagen = "imagen";
                }

                public Datos(string nombreSingular, string tablaDatos, string campoId, string campoNombre = "nombre", string campoImagen = null, string tablaImagenes = null)
                {
                        this.NombreSingular = nombreSingular;
                        this.TablaDatos = tablaDatos;
                        this.CampoId = campoId;
                        this.CampoNombre = campoNombre;
                        this.CampoImagen = CampoImagen;
                        this.TablaImagenes = tablaImagenes;
                }


                public string NombrePlural
                {
                        get
                        {
                                string Res = "";
                                string[] Palabras = this.NombreSingular.Split(new char[] { ' ', '-' });
                                foreach (string Palabra in Palabras) {
                                        if (Palabra == "de")
                                                Res += "de ";
                                        else if (Palabra == "del")
                                                Res += "de los ";
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
