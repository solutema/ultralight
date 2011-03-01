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
using System.Text;

namespace Lfx.FileFormats.Compression
{
        public enum ArchiveTypes
        {
                Unknown = 0,
                Zip,
                SevenZip,
                BZip2
        }

	public class Archive
	{
                private static System.Reflection.Assembly m_SharpZipLib = null;
		public string ArchiveFileName = null;
		public ArchiveTypes ArchiveType = ArchiveTypes.Unknown;

		public Archive(string archiveFileName, ArchiveTypes archiveType)
		{
			this.ArchiveFileName = archiveFileName;
			this.ArchiveType = archiveType;
		}

		public Archive(string archiveFileName)
		{
			this.ArchiveFileName = archiveFileName;
			switch(System.IO.Path.GetExtension(archiveFileName).ToUpperInvariant())
			{
                                case ".BZ2":
                                case ".BZIP2":
                                        this.ArchiveType = ArchiveTypes.BZip2;
                                        break;
				case ".7Z":
					this.ArchiveType = ArchiveTypes.SevenZip;
					break;
				case ".ZIP":
					this.ArchiveType = ArchiveTypes.Zip;
					break;
			}
		}

                private System.Reflection.Assembly SharpZipLib
                {
                        get
                        {
                                if (m_SharpZipLib == null)
                                        m_SharpZipLib = System.Reflection.Assembly.LoadFrom(Lfx.Environment.Folders.ApplicationFolder + "ICSharpCode.SharpZipLib.dll");
                                return m_SharpZipLib;
                        }
                }

		public bool ExtractAll(string outputFolder)
		{
			return this.Extract("*.*", outputFolder);
		}

		public bool Extract(string fileName, string outputFolder)
		{
			switch(this.ArchiveType)
			{
                                case ArchiveTypes.BZip2:
                                        string ArchivoSalida = outputFolder + System.IO.Path.DirectorySeparatorChar + fileName;
                                        object[] Args = new object[] { System.IO.File.OpenRead(this.ArchiveFileName), System.IO.File.Create(ArchivoSalida), true };
                                        System.Reflection.MethodInfo DecompMethod = this.SharpZipLib.GetType("ICSharpCode.SharpZipLib.BZip2.BZip2").GetMethod("Decompress");
                                        DecompMethod.Invoke(null, Args);
                                        break;
                                case ArchiveTypes.SevenZip:
					Lfx.Environment.Shell.Execute(Get7ZipExeName(), @"e -y -r -t7z -o""" + outputFolder + @""" """ + this.ArchiveFileName + @""" """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Hidden, true);
					break;
				default:
					Lfx.Environment.Shell.Execute(Get7ZipExeName(), @"e -y -r -o""" + outputFolder + @""" """ + this.ArchiveFileName + @""" """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Hidden, true);
					break;
			}
			return true;
		}

		public bool Add(string fileName)
		{
			switch(this.ArchiveType) {
				case ArchiveTypes.SevenZip:
					Lfx.Environment.Shell.Execute(Get7ZipExeName(), @" a -y -r -t7z """ + this.ArchiveFileName + @""" """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Hidden, true);
					break;
				default:
					Lfx.Environment.Shell.Execute(Get7ZipExeName(), @" a -y -r """ + this.ArchiveFileName + @""" """ + fileName + @"""", System.Diagnostics.ProcessWindowStyle.Hidden, true);
					break;
			}
			return true;
		}

		private static string Get7ZipExeName()
		{
			switch(Lfx.Environment.SystemInformation.Platform)
			{
				case Lfx.Environment.SystemInformation.Platforms.Windows:
					return @"""" + Lfx.Environment.Folders.ApplicationFolder + @"7za.exe""";
				default:
					return @"7za";
			}
		}
	}
}
