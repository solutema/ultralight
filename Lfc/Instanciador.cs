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

namespace Lfc
{
        public static class Instanciador
        {
                /// <summary>
                /// Crea un formulario de edición para el ElementoDeDatos proporcionado.
                /// </summary>
                /// <param name="elemento">El ElementoDeDatos que se quiere editar.</param>
                /// <returns>Un formulario derivado de Lfc.FormularioEdicion.</returns>
                public static Lfc.FormularioEdicion InstanciarFormularioEdicion(Lbl.IElementoDeDatos elemento)
                {
                        Lfc.FormularioEdicion Res = new Lfc.FormularioEdicion();
                        Type TipoControlEdicion = InferirControlEdicion(elemento.GetType());
                        if (TipoControlEdicion == null)
                                return null;

                        Res.ControlUnico = InstanciarControlEdicion(TipoControlEdicion);
                        Res.FromRow(elemento);

                        return Res;
                }


                public static Type InferirFormularioListado(Type tipo)
                {
                        Type Res = Lfx.Components.Manager.RegisteredTypes.GetHandler(tipo, "list");
                        return Res;
                }


                public static Lfc.FormularioListado InstanciarFormularioListado(Type tipo, string args)
                {
                        object Res;
                        if (args == null || args == string.Empty)
                                Res = Activator.CreateInstance(tipo);
                        else
                                Res = Activator.CreateInstance(tipo, args);

                        if (Res is Lazaro.Pres.Listings.Listing) {
                                Lfc.FormularioListado NewForm = new Lfc.FormularioListado(Res as Lazaro.Pres.Listings.Listing);
                                return NewForm;
                        } else {
                                return Res as Lfc.FormularioListado;
                        }
                }

                private static Lcc.Edicion.ControlEdicion InstanciarControlEdicion(Type tipo)
                {
                        object Res = Activator.CreateInstance(tipo);
                        return Res as Lcc.Edicion.ControlEdicion;
                }


                private static Type InferirControlEdicion(Type tipo)
                {
                        Type Res = Lfx.Components.Manager.RegisteredTypes.GetHandler(tipo, "edit");
                        return Res;
                }
        }
}
