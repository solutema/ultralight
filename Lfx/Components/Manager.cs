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

namespace Lfx.Components
{
	/// <summary>
	/// Infraestructura para el manejo de componentes.
	/// </summary>
	public static class Manager
	{
                public static Dictionary<string, Lfx.Components.Component> ComponentesCargados = new Dictionary<string, Component>();
                public static Dictionary<Type, FunctionInfo> TiposRegistrados = new Dictionary<Type, FunctionInfo>();


                public static void LoadAll()
                {
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.cif")) {
                                Lfx.Components.Component CompInfo = new Lfx.Components.Component(DirItem.FullName);
                                if (CompInfo.Disabled == false) {
                                        if (Lfx.Environment.SystemInformation.DesignMode) {
                                                RegisterComponent(CompInfo);
                                        } else {
                                                try {
                                                        RegisterComponent(CompInfo);
                                                } catch {
                                                        if (Lfx.Workspace.Master != null)
                                                                Lfx.Workspace.Master.RunTime.Message("No se puede registrar el componente " + CompInfo.Nombre);
                                                }
                                        }
                                }
                        }
                }

                public static Lfx.Types.OperationResult RegisterComponent(Component componentInfo)
                {
                        // Simplemente lo cargo... eso ya registra los tipos
                        if (ComponentesCargados.ContainsKey(componentInfo.Nombre) == false) {
                                Lfx.Types.OperationResult Res = componentInfo.Load();
                                if (Res.Success == false)
                                        return Res;

                                // Primero ejecuto la función Try, para decidir si cargo el componenten o no
                                Lfx.Types.OperationResult TryResult = componentInfo.Funciones["Try"].Run() as Lfx.Types.OperationResult;

                                if (TryResult != null && TryResult.Success) {
                                        ComponentesCargados.Add(componentInfo.Nombre, componentInfo);
                                        if (componentInfo.Funciones != null) {
                                                foreach (FunctionInfo Func in componentInfo.Funciones.Values) {
                                                        Func.Load();
                                                        if (Func.TipoRegistrado != null)
                                                                TiposRegistrados.Add(Func.TipoRegistrado, Func);
                                                }
                                        }

                                        // Cargo las estructuras de datos adicionales que el componente necesita
                                        using (System.IO.Stream DbStructXml = componentInfo.Assembly.GetManifestResourceStream(componentInfo.Nombre + ".Data.Struct.dbstruct.xml")) {
                                                if (DbStructXml != null) {
                                                        using (System.IO.StreamReader Lector = new System.IO.StreamReader(DbStructXml)) {
                                                                System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
                                                                Doc.Load(Lector);
                                                                Lector.Close();
                                                                DbStructXml.Close();
                                                                Lfx.Workspace.Master.Structure.AddToBuiltIn(Doc);
                                                        }
                                                }
                                        }
                                } else {
                                        return TryResult;
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                public static object Run(System.Windows.Forms.Form parentForm, string componentName, string functionName)
                {
                        if (ComponentesCargados.ContainsKey(componentName)) {
                                //Ya fue cargado
                                Lfx.Components.Component Componente = ComponentesCargados[componentName];

                                if (Componente.Funciones.ContainsKey(functionName)) {
                                        Lfx.Components.FunctionInfo Func = Componente.Funciones[functionName];

                                        object Result = Func.Run();

                                        if (Result != null && Result is System.Windows.Forms.Form) {
                                                System.Windows.Forms.Form ResultForm = Result as System.Windows.Forms.Form;
                                                if (Func.Instancia.FunctionType == Lfx.Components.FunctionTypes.MdiChildren) {
                                                        ResultForm.MdiParent = parentForm;
                                                        ResultForm.Show();
                                                } else if (Func.Instancia.FunctionType == Lfx.Components.FunctionTypes.NormalWindow) {
                                                        ResultForm.Show();
                                                }
                                        }

                                        return Result;
                                } else {
                                        return new Types.FailureOperationResult("El componente " + componentName + " no tiene la función " + functionName);
                                }
                        } else {
                                return new Types.FailureOperationResult("El componente " + componentName + " no está cargado.");
                        }
                }

                public static Lfx.Components.Function LoadComponent(string componentName)
		{
			return LoadComponent(componentName, componentName);
		}

                public static Lfx.Components.Function LoadComponent(string componentName, string functionName)
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
			
                        Lfx.Components.Function Res = (Lfx.Components.Function)ComponentAssembly.CreateInstance(componentName + "." + functionName);
                        return Res;
		}
	}
}
