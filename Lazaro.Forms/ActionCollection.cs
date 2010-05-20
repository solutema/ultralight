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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms
{
        public class ActionCollection : System.Collections.CollectionBase
        {
                public Form ParentForm;

                public ActionCollection(Form parentForm)
                {
                        this.ParentForm = parentForm;
                }

                public void Add(Action action)
                {
                        action.ParentForm = this.ParentForm;
                        this.List.Add(action);
                }

                public void Remove(string actionName)
                {
                        for (int i = 0; i < this.Count; i++) {
                                if (this[i].Name == actionName) {
                                        this.RemoveAt(i);
                                        break;
                                }
                        }
                }

                public virtual Action this[int index]
		{
			get
			{
				return (Action)this.List[index];
			}
			set
			{
                                value.ParentForm = this.ParentForm;
				this[index] = value;
			}
		}

                public Action this[string actionName]
		{
                        get
			{
				foreach(Action Act in this) {
					if(Act.Name == actionName)
						return Act;
				}
				return null;
			}
			set
			{
                                if (value == null) {
                                        this.Remove(actionName);
                                } else {
                                        bool Encontrado = false;
                                        for (int i = 0; i < this.Count; i++) {
                                                if (this[i].Name == actionName) {
                                                        this[i] = value;
                                                        Encontrado = true;
                                                        break;
                                                }
                                        }
                                        if (Encontrado == false) {
                                                //Si no existe, lo agrego
                                                this.Add(value);
                                        }
                                }
			}
                }

                public bool Contains(string actionName)
                {
                        foreach (Action Act in this) {
                                if (Act.Name == actionName)
                                        return true;
                        }
                        return false;
                }

                public override string ToString()
                {
                        string Res = "ActionCollection[" + this.Count.ToString() + "] = {";
                        string FlList = null;
                        foreach (Action Act in this) {
                                if (FlList == null)
                                        FlList = "";
                                else
                                        FlList += ", ";
                                FlList += Act.ToString();
                        }

                        return Res + FlList + "}";
                }

                public Action AcceptAction
                {
                        get
                        {
                                return this["accept"];
                        }
                        set
                        {
                                this["accept"] = value;
                        }
                }

                public Action CancelAction
                {
                        get
                        {
                                return this["cancel"];
                        }
                        set
                        {
                                this["cancel"] = value;
                        }
                }
        }
}
