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

namespace Lfx.Environment
{
        /// <summary>
        /// Provee acceso al shell.
        /// </summary>
        public class Shell
        {
                public static void Execute(string command, string paramsIdent, System.Diagnostics.ProcessWindowStyle windowStyle, bool wait)
                {
                        System.Diagnostics.Process NuevoProceso = new System.Diagnostics.Process();
                        NuevoProceso.StartInfo = new System.Diagnostics.ProcessStartInfo(command, paramsIdent);
                        NuevoProceso.StartInfo.WindowStyle = windowStyle;
                        if (command.IndexOf(".exe", StringComparison.OrdinalIgnoreCase) < 0)
                                NuevoProceso.StartInfo.UseShellExecute = true;
                        else
                                NuevoProceso.StartInfo.UseShellExecute = false;
			NuevoProceso.Start();

                        if (wait)
                                NuevoProceso.WaitForExit();
                }
		
		public static string[] ExecuteAndGet(string command, string paramsIdent, System.Diagnostics.ProcessWindowStyle windowStyle)
                {
                        System.Diagnostics.Process NuevoProceso = new System.Diagnostics.Process();
                        NuevoProceso.StartInfo = new System.Diagnostics.ProcessStartInfo(command, paramsIdent);
                        NuevoProceso.StartInfo.WindowStyle = windowStyle;
                        NuevoProceso.StartInfo.RedirectStandardOutput = true;
			NuevoProceso.StartInfo.UseShellExecute = false;
			NuevoProceso.Start();

                        NuevoProceso.WaitForExit();
			string Res = NuevoProceso.StandardOutput.ReadToEnd();
			return Res.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
                }

                public static void Reboot()
                {
                        string[] ParametrosAPasar = System.Environment.GetCommandLineArgs();
                        ParametrosAPasar[0] = "";
                        string Params = string.Join(" ", ParametrosAPasar).Trim();

                        string ExeName;
                        if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + "Cargador.exe"))
                                ExeName = Lfx.Environment.Folders.ApplicationFolder + "Cargador.exe";
                        else
                                ExeName = Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe";

                        System.Diagnostics.Process NuevoProceso = new System.Diagnostics.Process();
                        if (Lfx.Environment.SystemInformation.RunTime == Lfx.Environment.SystemInformation.RunTimes.DotNet) {
                                NuevoProceso.StartInfo = new System.Diagnostics.ProcessStartInfo(ExeName, Params);
                        } else {
                                string MonoName = Lfx.Environment.SystemInformation.Platform == SystemInformation.Platforms.Windows ? "mono.exe" : "/usr/bin/mono";
                                NuevoProceso.StartInfo = new System.Diagnostics.ProcessStartInfo(MonoName, @"""" + ExeName + @""" " + Params);
                        }

                        NuevoProceso.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                        NuevoProceso.StartInfo.UseShellExecute = false;
                        NuevoProceso.Start();

                        if (Lfx.Workspace.Master != null) {
                                Lfx.Workspace.Master.Disposing = true;
                                Lfx.Workspace.Master.Dispose();
                        }

                        System.Environment.Exit(0);
                }
        }
}
