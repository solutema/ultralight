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

namespace Lfx.Environment
{
	public class Threading
	{
		public static void Sleep(int millisecondsTimeout)
		{
			Sleep(millisecondsTimeout, false);
		}

		public static void Sleep(int millisecondsTimeout, bool doingEvents)
		{
			if(doingEvents)
			{
				System.DateTime Meta = System.DateTime.Now.AddMilliseconds(millisecondsTimeout);

				while(System.DateTime.Now < Meta)
				{
					System.Windows.Forms.Application.DoEvents();
					//Hago un thread.sleep para no atorar la CPU
					System.Threading.Thread.Sleep(10);
				}
			}
			else
			{
				System.Threading.Thread.Sleep(millisecondsTimeout);
			}
		}
	}

	/// <summary>
	/// Provee información sobre el sistema
	/// </summary>
	public class SystemInformation
	{
		public enum Platforms
		{
			Windows,
			Unix,
			Other
		}

                public static string PlatformName
                {
                        get
                        {
                                return System.Environment.OSVersion.ToString();
                        }
                }

		public static Platforms Platform
		{
			get
			{
				if (System.Environment.OSVersion.Platform == PlatformID.Win32NT || System.Environment.OSVersion.Platform == PlatformID.Win32Windows)
					return Platforms.Windows;
				else if ((int)System.Environment.OSVersion.Platform == 4 || (int)System.Environment.OSVersion.Platform == 128)
					return Platforms.Unix;
				else
					return Platforms.Other;
			}
		}

		public enum RunTimes
		{
			DotNet,
			Mono
		}

                public static string RuntimeName
                {
                        get
                        {
                                //Versión del Framework
                                switch (Lfx.Environment.SystemInformation.RunTime) {
                                        case Lfx.Environment.SystemInformation.RunTimes.DotNet:
                                                bool TieneDotNet3 = false;
                                                try {
                                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0", false);
                                                        object Installed = LocalMachine.GetValue("Install");
                                                        if (System.Convert.ToInt32(Installed) == 1)
                                                                TieneDotNet3 = true;
                                                } catch (Exception ex) {
                                                        System.Console.WriteLine(ex.Message);
                                                        TieneDotNet3 = false;
                                                }


                                                bool TieneDotNet35 = false;
                                                try {
                                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.5", false);
                                                        object Installed = LocalMachine.GetValue("Install");
                                                        if (System.Convert.ToInt32(Installed) == 1)
                                                                TieneDotNet35 = true;
                                                } catch (Exception ex) {
                                                        System.Console.WriteLine(ex.Message);
                                                        TieneDotNet35 = false;
                                                }

                                                bool TieneDotNet4 = false;
                                                try {
                                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Client", false);
                                                        object Installed = LocalMachine.GetValue("Install");
                                                        if (System.Convert.ToInt32(Installed) == 1)
                                                                TieneDotNet4 = true;
                                                } catch (Exception ex) {
                                                        System.Console.WriteLine(ex.Message);
                                                        TieneDotNet4 = false;
                                                }

                                                string VersionesDotNet = "Microsoft .NET 2.0";
                                                if (TieneDotNet3)
                                                        VersionesDotNet += ", 3.0";
                                                if (TieneDotNet35)
                                                        VersionesDotNet += ", 3.5";
                                                if (TieneDotNet4)
                                                        VersionesDotNet += ", 4";

                                                return VersionesDotNet;
                                        case Lfx.Environment.SystemInformation.RunTimes.Mono:
                                                return "Novell Mono";
                                        default:
                                                return "Desconocido";
                                }
                        }
                }

		public static RunTimes RunTime
		{
			get
			{
				if(Type.GetType("Mono.Runtime") != null)
					return Lfx.Environment.SystemInformation.RunTimes.Mono;
				else
					return Lfx.Environment.SystemInformation.RunTimes.DotNet;
			}
		}

		public static bool DesignMode
		{
			get
			{
                                System.Diagnostics.Process Yo = System.Diagnostics.Process.GetCurrentProcess();
				if(Yo.ProcessName.IndexOf(".vshost") >= 0)
					return true;
				else if(Lfx.Environment.Folders.ApplicationFolder.IndexOf("/Sistema/bin/".Replace('/', System.IO.Path.DirectorySeparatorChar)) >= 0)
					return true;
				else
					return false;
			}
		}

                public static bool IsUacActive
                {
                        get
                        {
                                if (Lfx.Environment.SystemInformation.Platform == Platforms.Windows) {
                                        // Es Windows
                                        if (System.Environment.OSVersion.Version.Major >= 6) {
                                                // Es Windows Vista o superior
                                                int Uac = System.Convert.ToInt32(Microsoft.Win32.Registry.GetValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", 0));
                                                return Uac != 0;
                                        } else {
                                                return false;
                                        }
                                } else {
                                        return false;
                                }
                        }
                }
	}
}
