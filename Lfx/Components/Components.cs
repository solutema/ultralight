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

namespace Lfx.Components
{
        /// <summary>
        /// Enumera los tipos de componentes.
        /// </summary>
	public enum ComponentTypes
	{
		Executable,
		Loadable,
		NormalWindow,
		MdiChildren
	}

	/// <summary>
	/// Infraestructura para el manejo de componentes.
	/// </summary>
	public static class ComponentManager
	{
                public static System.Collections.Hashtable ComponentesCargados = new System.Collections.Hashtable();

                public static Lfx.Types.OperationResult Run(Lfx.Workspace workspace, System.Windows.Forms.Form parentForm, string componentName, string functionName)
                {
                        Lfx.Components.Component ComponentObject;

                        if (ComponentesCargados.ContainsKey(componentName + "." + functionName)) {
                                //Ya fue cargado
                                ComponentObject = (Lfx.Components.Component)ComponentesCargados[componentName + "." + functionName];
                        } else {
                                //Creo una nueva instancia
                                ComponentObject = Lfx.Components.ComponentManager.LoadComponent(componentName, functionName);
                                if (ComponentObject != null)
                                        ComponentesCargados.Add(componentName + "." + functionName, ComponentObject);
                        }

                        if (ComponentObject != null) {
                                ComponentObject.Workspace = workspace;
                                string Error = "";
                                if (ComponentObject.Try(out Error) == false)
                                        return new Lfx.Types.FailureOperationResult("Error al cargar componente " + componentName + ", función " + functionName);

                                object Result = ComponentObject.Create();

                                if (Result != null && Result is System.Windows.Forms.Form) {
                                        System.Windows.Forms.Form ResultForm = Result as System.Windows.Forms.Form;
                                        if (ComponentObject.ComponentType == Lfx.Components.ComponentTypes.MdiChildren) {
                                                ResultForm.MdiParent = parentForm;
                                                ResultForm.Show();
                                        } else if (ComponentObject.ComponentType == Lfx.Components.ComponentTypes.NormalWindow) {
                                                ResultForm.Show();
                                        }
                                }

                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.FailureOperationResult(@"No se puede cargar la función """ + functionName + @""" del componente """ + componentName + @""".");
                        }
                }

                public static Lfx.Components.Component LoadComponent(string componentName)
		{
			return LoadComponent(componentName, componentName);
		}

                public static Lfx.Components.Component LoadComponent(string componentName, string functionName)
		{
			string[] WhereToLook;
			if(Lfx.Environment.SystemInformation.DesignMode) {
				WhereToLook = new string[] {
                                        Lfx.Environment.Folders.ApplicationFolder + @"../../Componentes/bin/" + componentName + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + @"../../Componentes/" + componentName + @"/bin/" + componentName + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + @"../../Componentes/" + componentName + @"/bin/Debug/" + componentName + ".dll",
					Lfx.Environment.Folders.ComponentsFolder + componentName + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + componentName + ".dll"
				};
			} else {
				WhereToLook = new string[] {
					Lfx.Environment.Folders.ComponentsFolder + componentName + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + componentName + ".dll"
				};
			}

			System.Reflection.Assembly ComponentAssembly = null;
			foreach(string Archivo in WhereToLook) {
				if(System.IO.File.Exists(Archivo)) {
					try {
						ComponentAssembly = System.Reflection.Assembly.LoadFrom(Archivo);
						break;
					}
					catch {
						//Nada
					}
				}
			}
		
			if(ComponentAssembly == null)
				return null;
			else
                                return (Lfx.Components.Component)ComponentAssembly.CreateInstance(componentName + "." + functionName);
		}
	}
}
