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
using System.Text;

namespace Lfx
{
        /// <summary>
        /// Agrega la licencia GPL como encabezado a todos los archivos de código fuente.
        /// </summary>
        public static class Lic
        {
                public static void Limpiar()
                {
                        int Cambios = 0;
                        string[] Archivos = System.IO.Directory.GetFiles(@"C:\Projects\Lazaro\", "*.cs", System.IO.SearchOption.AllDirectories);
                        foreach (string Archivo in Archivos) {
                                StringBuilder Salida = new StringBuilder();
                                bool Encontre = false;
                                using (System.IO.StreamReader Lector = System.IO.File.OpenText(Archivo)) {
                                        while (Lector.EndOfStream == false) {
                                                string Contenido = Lector.ReadLine();
                                                if (Contenido.IndexOf("." + @"Text = ""0.00"";") >= 0) {
                                                        Cambios++;
                                                        Encontre = true;
                                                } else {
                                                        Salida.AppendLine(Contenido);
                                                }
                                        }
                                        Lector.Close();
                                }

                                if (Encontre) {
                                        using (System.IO.StreamWriter Escritor = System.IO.File.CreateText(Archivo)) {
                                                Escritor.Write(Salida.ToString());
                                                Escritor.Close();
                                        }
                                }
                                System.Console.WriteLine("Se realizaron {0} cambios", Cambios);
                        }
                }

                public static void Licenciar(string path)
                {
                        string[] Archivos = System.IO.Directory.GetFiles(path, "*.cs", System.IO.SearchOption.AllDirectories);
                        foreach (string Archivo in Archivos) {
                                System.IO.StreamReader Lector = System.IO.File.OpenText(Archivo);
                                string Contenido = Lector.ReadToEnd();

                                int Pos = Contenido.IndexOf("Copyright", StringComparison.OrdinalIgnoreCase);
                                Lector.Close();

                                if (Pos == -1) {
                                        //No tiene mensaje de Copyright. Agrego
                                        Contenido = @"#region License
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

" + Contenido;
                                        System.IO.StreamWriter Escritor = System.IO.File.CreateText(Archivo);
                                        Escritor.Write(Contenido);
                                        Escritor.Close();
                                }
                        }
                }
        }
}
