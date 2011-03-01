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

namespace Lbl.Sys.Permisos
{
        public class ListaDePermisos : Lbl.ColeccionGenerica<Permiso>
        {
                public Lbl.Personas.Usuario Usuario = null;

                public ListaDePermisos(Lbl.Personas.Usuario usuario)
                        : base(usuario.Connection) { }

                public ListaDePermisos(Lbl.Personas.Usuario usuario, System.Data.DataTable tabla)
                        : base(usuario.Connection, tabla)
                {
                        this.Usuario = usuario;
                        foreach (Permiso Perm in this) {
                                Perm.Usuario = usuario;
                        }
                }

                public bool TieneAccesoGlobal()
                {
                        foreach (Permiso Acc in this) {
                                if (Acc.Objeto.Tipo == "Global" && (Acc.Operaciones & Operaciones.Total) == Operaciones.Total) {
                                        return true;
                                }
                        }
                        return false;
                }

                public bool TienePermiso(string tipo, Operaciones operacion)
                {
                        if (this.TieneAccesoGlobal())
                                return true;

                        foreach (Permiso Perm in this) {
                                if (Perm.Objeto.Tipo == tipo &&
                                        ((Perm.Operaciones & operacion) == operacion || (Perm.Operaciones & Operaciones.Total) == Operaciones.Total)) {
                                                return true;
                                }
                        }

                        return false;
                }

                public bool TienePermiso(IElementoDeDatos elemento, Operaciones operacion)
                {
                        if (this.TieneAccesoGlobal())
                                return true;

                        string TipoElemento = elemento.GetType().ToString();
                        foreach (Permiso Perm in this) {
                                if (Perm.Objeto.Tipo == TipoElemento &&
                                        ((Perm.Operaciones & operacion) == operacion || (Perm.Operaciones & Operaciones.Total) == Operaciones.Total)) {
                                                return true;
                                }
                        }

                        return TienePermiso(elemento.GetType().BaseType, operacion);
                }

                public bool TienePermiso(Type tipo, Operaciones operacion)
                {
                        if (this.TieneAccesoGlobal())
                                return true;

                        string TipoElemento = tipo.ToString();
                        foreach (Permiso Perm in this) {
                                if (Perm.Objeto.Tipo == TipoElemento &&
                                        ((Perm.Operaciones & operacion) == operacion || (Perm.Operaciones & Operaciones.Total) == Operaciones.Total)) {
                                                return true;
                                }
                        }

                        if (tipo != typeof(Lbl.ElementoDeDatos) && tipo != typeof(System.Object))
                                return TienePermiso(tipo.BaseType, operacion);
                        else
                                return false;
                }
        }
}
