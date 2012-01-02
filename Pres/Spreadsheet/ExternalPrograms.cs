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
using Microsoft.Win32;

namespace Lazaro.Pres.Spreadsheet
{
        internal static class ExternalPrograms
        {
                internal static class OpenOffice
                {
                        internal static string GetPath()
                        {
                                // FIXME: versión Linux
                                string Res = null;
                                RegistryKey ProgKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OpenOffice.org\OpenOffice.org", false);
                                if (ProgKey != null) {

                                        foreach (string Version in ProgKey.GetSubKeyNames()) {
                                                RegistryKey ProgVersionKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OpenOffice.org\OpenOffice.org\" + Version, false);
                                                if (ProgVersionKey != null && ProgVersionKey.GetValue("Path") != null) {
                                                        Res = System.IO.Path.GetDirectoryName(ProgVersionKey.GetValue("Path").ToString());
                                                        ProgVersionKey.Close();
                                                        break;
                                                }
                                                ProgVersionKey.Close();
                                        }
                                        ProgKey.Close();
                                        if (Res != null && Res.Substring(Res.Length - 1, 1) != System.IO.Path.DirectorySeparatorChar.ToString())
                                                Res += System.IO.Path.DirectorySeparatorChar;
                                }
                                return Res;
                        }

                        internal static bool IsCalcInstalled()
                        {
                                string SofficePath = GetPath();
                                if (SofficePath != null)
                                        return System.IO.File.Exists(SofficePath + "scalc.exe");
                                else
                                        return false;
                        }

                        internal static void PrintWithCalc(string fileName)
                        {
                                string SofficePath = GetPath();
                                if (SofficePath != null) {
                                        Lfx.Environment.Shell.Execute(SofficePath + "scalc.exe", @"-pt """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Normal, false);
                                }
                        }
                }

                internal static class MsOffice
                {
                        internal static string GetPath()
                        {
                                if (Lfx.Environment.SystemInformation.Platform != Lfx.Environment.SystemInformation.Platforms.Windows)
                                        return null;

                                string Res = null;
                                RegistryKey ProgKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Office", false);
                                if (ProgKey != null) {

                                        foreach (string Version in ProgKey.GetSubKeyNames()) {
                                                RegistryKey ProgVersionKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Office\" + Version + @"\Excel\InstallRoot", false);
                                                if (ProgVersionKey != null) {
                                                        if (ProgVersionKey.GetValue("Path") != null) {
                                                                Res = System.IO.Path.GetDirectoryName(ProgVersionKey.GetValue("Path").ToString());
                                                                ProgVersionKey.Close();
                                                                break;
                                                        }
                                                        ProgVersionKey.Close();
                                                }
                                        }
                                        ProgKey.Close();
                                        if (Res != null && Res.Substring(Res.Length - 1, 1) != System.IO.Path.DirectorySeparatorChar.ToString())
                                                Res += System.IO.Path.DirectorySeparatorChar;
                                }
                                return Res;
                        }

                        internal static bool IsExcelInstalled()
                        {
                                string OfficePath = GetPath();
                                if (OfficePath != null)
                                        return System.IO.File.Exists(OfficePath + "excel.exe");
                                else
                                        return false;
                        }

                        internal static void PrintWithExcel(string fileName)
                        {
                                string OfficePath = GetPath();
                                if (OfficePath != null) {
                                        Lfx.Environment.Shell.Execute(OfficePath + "excel.exe", @"/e """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Normal, false);
                                }
                        }
                }
        }
}
