// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

using System;

namespace Lfx.Environment
{
	/// <summary>
	/// Summary description for Folders.
	/// </summary>
	public class Folders
	{
                public static void EnsurePathExists(string path)
                {
                        if (!System.IO.Directory.Exists(path))
                                System.IO.Directory.CreateDirectory(path);
                }

		public static string TemporaryFolder
		{
			get
			{
				string CompletePath = ApplicationDataFolder + "Temp" + System.IO.Path.DirectorySeparatorChar;
				if(!System.IO.Directory.Exists(CompletePath))
					System.IO.Directory.CreateDirectory(CompletePath);
				return CompletePath;
			}
		}

		public static string CacheFolder
		{
			get
			{
				string CompletePath = ApplicationDataFolder + "Cache" + System.IO.Path.DirectorySeparatorChar;
				if(!System.IO.Directory.Exists(CompletePath))
					System.IO.Directory.CreateDirectory(CompletePath);
				return CompletePath;
			}
		}

		public static string ComponentsFolder
		{
			get
			{
				if(!System.IO.Directory.Exists(ApplicationFolder + @"Components" + System.IO.Path.DirectorySeparatorChar))
					System.IO.Directory.CreateDirectory(ApplicationFolder + "Components");
				return ApplicationFolder + @"Components" + System.IO.Path.DirectorySeparatorChar;
			}
		}

		public static string ApplicationFolder
		{
			get
			{
				string Result = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
				if(Result[Result.Length - 1] != System.IO.Path.DirectorySeparatorChar)
					Result += System.IO.Path.DirectorySeparatorChar;
				return Result;
			}
		}

		public static string ApplicationDataFolder
		{
			get
			{
				string CompletePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData)
					+ System.IO.Path.DirectorySeparatorChar + "Lazaro" + System.IO.Path.DirectorySeparatorChar;
				if(!System.IO.Directory.Exists(CompletePath))
					System.IO.Directory.CreateDirectory(CompletePath);
				return CompletePath;
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
	}
}