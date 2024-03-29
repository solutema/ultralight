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

namespace Lazaro.Pres.Forms
{
        public class FormActionCollection : List<FormAction>
        {
                public bool ContainsKey(string name)
                {
                        foreach (FormAction act in this) {
                                if (act.Name == name)
                                        return true;
                        }
                        return false;
                }

                public FormAction this[string name]
                {
                        get{
                                foreach (FormAction act in this) {
                                        if (act.Name == name)
                                                return act;
                                }
                                return null;
                        }
                        set
                        {
                                if (this.ContainsKey(name))
                                        this.Remove(this[name]);
                                this.Add(value);
                        }
                }

                public void AddAndUpdate(Lazaro.Pres.Forms.FormActionCollection actions)
                {
                        foreach (Lazaro.Pres.Forms.FormAction act in actions) {
                                if (this.ContainsKey(act.Name))
                                        this[act.Name] = act;
                                else
                                        this.Add(act);
                        }
                }

                /// <summary>
                /// Hace una copia superficial de la colección.
                /// Clona la colección, pero no clona cada uno de sus elementos, los cuales se pasan como referencias al original.
                /// </summary>
                /// <returns>Una copia superficial de la colección.</returns>
                public FormActionCollection ShallowClone()
                {
                        FormActionCollection Res = new FormActionCollection();

                        foreach (FormAction Act in this) {
                                Res.Add(Act);
                        }

                        return Res;
                }
        }
}
