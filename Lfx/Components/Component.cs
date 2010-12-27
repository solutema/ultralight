#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfx.Components
{
        public class Component
        {
                public string Nombre, CifFileName;
                public Dictionary<string, FunctionInfo> Funciones = null;
                public List<MenuEntry> MenuEntries = null;
                public System.Reflection.Assembly Assembly = null;
                public bool Disabled = false;

                public Component(string cifFileName)
                {
                        this.CifFileName = cifFileName;
                        this.Nombre = System.IO.Path.GetFileNameWithoutExtension(cifFileName);

                        if (System.IO.File.Exists(this.CifFileName)) {
                                using (System.IO.TextReader ArchivoCif = new System.IO.StreamReader(this.CifFileName, true)) {
                                        System.Xml.XmlDocument DocumentoCif = new System.Xml.XmlDocument();
                                        DocumentoCif.Load(ArchivoCif);
                                        System.Xml.XmlNodeList ListaComponentes = DocumentoCif.GetElementsByTagName("Component");
                                        //Abro el/los nodo(s) de componentes
                                        foreach (System.Xml.XmlNode Componente in ListaComponentes) {
                                                if (Componente.Attributes["Disabled"] == null || Componente.Attributes["Disabled"].Value != "1") {
                                                        System.Xml.XmlNodeList NodosMenu = DocumentoCif.GetElementsByTagName("MenuItem");
                                                        foreach (System.Xml.XmlNode NodoMenu in NodosMenu) {
                                                                if (this.MenuEntries == null)
                                                                        this.MenuEntries = new List<MenuEntry>();

                                                                MenuEntry Menu = new MenuEntry();
                                                                Menu.Name = NodoMenu.Attributes["name"].Value;
                                                                if (NodoMenu.Attributes["position"] == null)
                                                                        Menu.Parent = "Componentes";
                                                                else
                                                                        Menu.Parent = NodoMenu.Attributes["position"].Value;

                                                                if (NodoMenu.Attributes["function"] != null)
                                                                        Menu.Function = NodoMenu.Attributes["function"].Value;

                                                                this.MenuEntries.Add(Menu);
                                                        }

                                                        System.Xml.XmlNodeList NodosFunciones = DocumentoCif.GetElementsByTagName("Function");
                                                        //Abro los nodos de funciones
                                                        foreach (System.Xml.XmlNode NodoFuncion in NodosFunciones) {
                                                                if (this.Funciones == null) {
                                                                        this.Funciones = new Dictionary<string, FunctionInfo>();

                                                                        // Creo la función Try, que la tienen que definir todos los componentes
                                                                        FunctionInfo TryFunc = new FunctionInfo(this);
                                                                        TryFunc.Nombre = "Try";
                                                                        this.Funciones.Add(TryFunc.Nombre, TryFunc);
                                                                }

                                                                FunctionInfo Func = new FunctionInfo(this);
                                                                Func.Nombre = NodoFuncion.Attributes["name"].Value;
                                                                if (Func.Nombre != null && Func.Nombre.Length > 0 && Func.Nombre != "-") {
                                                                        if (NodoFuncion.Attributes["autorun"] != null && NodoFuncion.Attributes["autorun"].Value == "1")
                                                                                Func.AutoRun = true;

                                                                        this.Funciones.Add(Func.Nombre, Func);
                                                                }
                                                        }
                                                } else {
                                                        this.Disabled = true;
                                                }                                                      

                                        }
                                        ArchivoCif.Close();
                                }
                        }
                }

                public Lfx.Types.OperationResult Load()
                {
                        if (this.Assembly == null) {
                                string[] WhereToLook;

                                if (Lfx.Environment.SystemInformation.DesignMode) {
                                        WhereToLook = new string[] {
                                        Lfx.Environment.Folders.ApplicationFolder + @"../../Componentes/bin/" + this.Nombre + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + @"../../Componentes/" + this.Nombre + @"/bin/" + this.Nombre + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + @"../../Componentes/" + this.Nombre + @"/bin/Debug/" + this.Nombre + ".dll",
					Lfx.Environment.Folders.ComponentsFolder + this.Nombre + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + this.Nombre + ".dll"
				};
                                } else {
                                        WhereToLook = new string[] {
					Lfx.Environment.Folders.ComponentsFolder + this.Nombre + ".dll",
					Lfx.Environment.Folders.ApplicationFolder + this.Nombre + ".dll"
				};
                                }

                                foreach (string Archivo in WhereToLook) {
                                        if (System.IO.File.Exists(Archivo)) {
                                                try {
                                                        this.Assembly = System.Reflection.Assembly.LoadFrom(Archivo);
                                                        break;
                                                } catch {
                                                        // Nada
                                                }
                                        }
                                }
                        }

                        if (this.Assembly == null)
                                return new Types.FailureOperationResult("No se puede cargar el componente " + this.Nombre);
                        else
                                return new Types.SuccessOperationResult();
                }

                public override string ToString()
                {
                        return this.Nombre + " (" + this.CifFileName + ")";
                }
        }
}
