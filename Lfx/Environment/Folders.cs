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
using System.IO;

namespace Lfx.Environment
{
        /// <summary>
        /// Summary description for Folders.
        /// </summary>
        public static class Folders
        {
                public static bool PortableMode = false;

                public static void EnsurePathExists(string path)
                {
                        if (!System.IO.Directory.Exists(path))
                                System.IO.Directory.CreateDirectory(path);
                }


                public static void DeleteWithWildcards(string path, string wildcards)
                {
                        string[] Files = System.IO.Directory.GetFiles(path, wildcards);
                        foreach (string File in Files) {
                                System.IO.File.Delete(File);
                        }
                }

                public static string TemporaryFolder
                {
                        get
                        {
                                return System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Lazaro") + System.IO.Path.DirectorySeparatorChar;
                        }
                }

                public static string CacheFolder
                {
                        get
                        {
                                string CompletePath = ApplicationDataFolder + "Cache" + System.IO.Path.DirectorySeparatorChar;
                                if (!System.IO.Directory.Exists(CompletePath))
                                        Environment.Folders.EnsurePathExists(CompletePath);
                                return CompletePath;
                        }
                }

                public static string ComponentsFolder
                {
                        get
                        {
                                if (!System.IO.Directory.Exists(ApplicationFolder + @"Components" + System.IO.Path.DirectorySeparatorChar))
                                        System.IO.Directory.CreateDirectory(ApplicationFolder + "Components");
                                return ApplicationFolder + @"Components" + System.IO.Path.DirectorySeparatorChar;
                        }
                }

                private static string m_ApplicationFolder = null;
                public static string ApplicationFolder
                {
                        get
                        {
                                if (m_ApplicationFolder == null) {
                                        m_ApplicationFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                                        if (m_ApplicationFolder[m_ApplicationFolder.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                                                m_ApplicationFolder += System.IO.Path.DirectorySeparatorChar;
                                }
                                return m_ApplicationFolder;
                        }
                        set
                        {
                                m_ApplicationFolder = value;
                        }
                }

                public static string m_ApplicationDataFolder = null;
                public static string ApplicationDataFolder
                {
                        get
                        {
                                if (PortableMode) {
                                        return ApplicationFolder;
                                } else if (m_ApplicationDataFolder == null) {
                                        m_ApplicationDataFolder = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Lazaro") + System.IO.Path.DirectorySeparatorChar;
                                        if (!System.IO.Directory.Exists(m_ApplicationDataFolder))
                                                Environment.Folders.EnsurePathExists(m_ApplicationDataFolder);
                                        return m_ApplicationDataFolder;
                                }
                                return m_ApplicationDataFolder;
                        }
                        set
                        {
                                m_ApplicationDataFolder = value;
                        }
                }


                public static string m_UserFolder = null;
                public static string UserFolder
                {
                        get
                        {
                                if (PortableMode) {
                                        return ApplicationFolder;
                                } else if (m_UserFolder == null) {
                                        m_UserFolder = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Lázaro") + System.IO.Path.DirectorySeparatorChar;
                                        if (!System.IO.Directory.Exists(m_UserFolder)) {
                                                Environment.Folders.EnsurePathExists(m_UserFolder);
                                                Environment.Folders.EnsurePathExists(System.IO.Path.Combine(m_UserFolder, "Plantillas"));
                                        }
                                        return m_UserFolder;
                                }
                                return m_UserFolder;
                        }
                        set
                        {
                                m_UserFolder = value;
                        }
                }


                public static string UpdatesFolder
                {
                        get
                        {
                                return System.IO.Path.Combine(ApplicationDataFolder, "Updates") + System.IO.Path.DirectorySeparatorChar;
                        }
                }

                public static string WindowsSystemFolder
                {
                        get
                        {
                                return System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + System.IO.Path.DirectorySeparatorChar;
                        }
                }

                public static string WindowsFontsFolder
                {
                        get
                        {
                                string Res = System.Environment.GetFolderPath(((System.Environment.SpecialFolder)20)) + System.IO.Path.DirectorySeparatorChar;
                                return Res;
                        }
                }


                public static void MoveDirectory(string sourceDir, string destDir)
                {
                        if (Directory.Exists(sourceDir)) {
                                if (Directory.GetDirectoryRoot(sourceDir) == Directory.GetDirectoryRoot(destDir)) {
                                        Directory.Move(sourceDir, destDir);
                                } else {
                                        try {
                                                CopyDirectory(new DirectoryInfo(sourceDir), new DirectoryInfo(destDir));
                                                Directory.Delete(sourceDir, true);
                                        } catch (Exception subEx) {
                                                throw subEx;
                                        }
                                }
                        }
                }

                private static void CopyDirectory(DirectoryInfo sourceDir, DirectoryInfo destDir)
                {
                        if (!destDir.Exists)
                                destDir.Create();
                        FileInfo[] SrcFiles = sourceDir.GetFiles();
                        foreach (FileInfo SrcFile in SrcFiles) {
                                SrcFile.CopyTo(Path.Combine(destDir.FullName, SrcFile.Name));
                        }
                        DirectoryInfo[] SrcDirectories = sourceDir.GetDirectories();
                        foreach (DirectoryInfo SrcDirectory in SrcDirectories) {
                                CopyDirectory(SrcDirectory, new DirectoryInfo(Path.Combine(destDir.FullName, SrcDirectory.Name)));
                        }
                }
        }
}