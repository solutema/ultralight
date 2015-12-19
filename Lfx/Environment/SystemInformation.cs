using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Lfx.Environment
{
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


                public static string ProcessorName
                {
                        get
                        {
                                try {
                                        object Res = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", "");
                                        if (Res == null)
                                                return string.Empty;
                                        else
                                                return Res.ToString();
                                } catch {
                                        return string.Empty;
                                }
                        }
                }


                private static string m_MachineName = null;
                /// <summary>
                /// Devuelve el nombre del equipo, pero siempre en mayúsculas.
                /// </summary>
                public static string MachineName
                {
                        get
                        {
                                if (m_MachineName == null)
                                        m_MachineName = System.Environment.MachineName;
                                return m_MachineName;
                        }
                }


                public static string RuntimeName
                {
                        get
                        {
                                //Versión del Framework
                                switch (Lfx.Environment.SystemInformation.RunTime) {
                                        case Lfx.Environment.SystemInformation.RunTimes.DotNet:
                                                System.Collections.Generic.List<string> VersionesInstaladas = new System.Collections.Generic.List<string>();

                                                try {
                                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0", false);
                                                        object Installed = LocalMachine.GetValue("Install");
                                                        if (System.Convert.ToInt32(Installed) == 1)
                                                                VersionesInstaladas.Add("3");
                                                } catch (Exception ex) {
                                                        System.Console.WriteLine(ex.Message);
                                                }


                                                try {
                                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.5", false);
                                                        object Installed = LocalMachine.GetValue("Install");
                                                        if (System.Convert.ToInt32(Installed) == 1)
                                                                VersionesInstaladas.Add("3.5");
                                                } catch (Exception ex) {
                                                        System.Console.WriteLine(ex.Message);
                                                }

                                                try {
                                                        Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Client", false);
                                                        object Installed = LocalMachine.GetValue("Install");
                                                        if (System.Convert.ToInt32(Installed) == 1)
                                                                VersionesInstaladas.Add("4");
                                                } catch (Exception ex) {
                                                        System.Console.WriteLine(ex.Message);
                                                }

                                                string VersionesDotNet = "Microsoft .NET " + string.Join(", ", VersionesInstaladas);
                                                return VersionesDotNet;
                                        case Lfx.Environment.SystemInformation.RunTimes.Mono:
                                                return "Mono";
                                        default:
                                                return "Desconocido";
                                }
                        }
                }

                public static RunTimes RunTime
                {
                        get
                        {
                                if (Type.GetType("Mono.Runtime") != null)
                                        return Lfx.Environment.SystemInformation.RunTimes.Mono;
                                else
                                        return Lfx.Environment.SystemInformation.RunTimes.DotNet;
                        }
                }


                public static bool DesignMode
                {
                        get
                        {
                                if (System.Diagnostics.Debugger.IsAttached)
                                        return true;

                                using (System.Diagnostics.Process Yo = System.Diagnostics.Process.GetCurrentProcess()) {
                                        if (Yo.ProcessName.IndexOf(".vshost") >= 0 || Yo.ProcessName.IndexOf("devenv") >= 0)
                                                return true;
                                        else if (Lfx.Environment.Folders.ApplicationFolder.IndexOf("Lazaro/Sistema/bin".Replace('/', System.IO.Path.DirectorySeparatorChar), StringComparison.InvariantCultureIgnoreCase) >= 0)
                                                return true;
                                        else
                                                return false;
                                }
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
                                                int Uac = System.Convert.ToInt32(Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLUA", 0));
                                                return Uac != 0;
                                        } else {
                                                return false;
                                        }
                                } else {
                                        return false;
                                }
                        }
                }

                public static bool CanWriteToAppFolder
                {
                        get
                        {
                                try {
                                        using (System.IO.FileStream Wr = System.IO.File.Create(Lfx.Environment.Folders.ApplicationFolder + "test.dat")) {
                                                Wr.Close();
                                        }
                                        System.IO.File.Delete(Lfx.Environment.Folders.ApplicationFolder + "test.dat");
                                } catch {
                                        return false;
                                }
                                return true;
                        }
                }
        }
}