#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
using System.Net;

namespace Lfx.Updates
{
        public class Package
        {
                public Updater Updater { get; set; }

                public string Name { get; set; }

                /// <summary>
                /// Ruta de destino relativa a la ruta del actualizador.
                /// </summary>
                public string RelativePath { get; set; }
                public string Url { get; set; }

                public FileCollection Files;

                internal void DownloadUpdatesInformation()
                {
                        this.Updater.Progress.ChangeStatus("Descargando información de versiones de " + this.Name);
                        this.Files = new FileCollection();

                        try {
                                using (WebClient Cliente = new WebClient()) {
                                        Cliente.Encoding = System.Text.Encoding.UTF8;
                                        string VerFileUrl = this.GetFullUrl() + this.Name + ".ver";
                                        byte[] VersionInfo = Cliente.DownloadData(VerFileUrl + "?dm=" + new Random().Next().ToString());

                                        System.Xml.XmlDocument ArchivoVer = new System.Xml.XmlDocument();
                                        System.IO.MemoryStream ms = new System.IO.MemoryStream(VersionInfo);
                                        ArchivoVer.Load(ms);

                                        System.Xml.XmlNodeList PackageList = ArchivoVer.GetElementsByTagName("Package");
                                        foreach (System.Xml.XmlNode Pkg in PackageList) {
                                                string PkgName = Pkg.Attributes["name"].Value;
                                                System.Xml.XmlNode Comp = ArchivoVer.SelectSingleNode("/VersionInfo/Package[@name='" + PkgName + "']");
                                                foreach (System.Xml.XmlNode FileVers in Comp.ChildNodes) {
                                                        if (FileVers.Name == "File") {
                                                                if (FileVers.Attributes["name"] != null && FileVers.Attributes["name"].Value != null) {
                                                                        File FileVersionInfo = new File(this);
                                                                        FileVersionInfo.Name = FileVers.Attributes["name"].Value;
                                                                        DateTime Fecha;
                                                                        try {
                                                                                DateTime.TryParseExact(FileVers.Attributes["version"].Value, Lfx.Types.Formatting.DateTime.SqlDateTimeFormat, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeUniversal | System.Globalization.DateTimeStyles.AllowWhiteSpaces, out Fecha);
                                                                                
                                                                        } catch {
                                                                                Fecha = DateTime.MinValue;
                                                                        }
                                                                        FileVersionInfo.NewVersion = Fecha;
                                                                        
                                                                        if (FileVers.Attributes["compression"] != null && FileVers.Attributes["compression"].Value != null) {
                                                                                switch(FileVers.Attributes["compression"].Value) {
                                                                                        case "none":
                                                                                        case "":
                                                                                                FileVersionInfo.Compression = CompressionFormats.None;
                                                                                                break;
                                                                                        case "bz2":
                                                                                                FileVersionInfo.Compression = CompressionFormats.Bz2;
                                                                                                break;
                                                                                        default:
                                                                                                FileVersionInfo.Compression = CompressionFormats.OtherUnsupported;
                                                                                                break;
                                                                                }
                                                                        }
                                                                        if (FileVers.Attributes["size"] != null && FileVers.Attributes["size"].Value != null)
                                                                                FileVersionInfo.NewSize = int.Parse(FileVers.Attributes["size"].Value);
                                                                        if (FileVers.Attributes["compsize"] != null && FileVers.Attributes["compsize"].Value != null)
                                                                                FileVersionInfo.NewCompSize = int.Parse(FileVers.Attributes["compsize"].Value);
                                                                        this.Files.Add(FileVersionInfo);
                                                                }
                                                        }
                                                }
                                        }
                                }
                        } catch (Exception ex) {
                                // No pude descargar
                                System.Console.WriteLine("Updater: " + ex.Message);
                        }
                }


                public string GetFullUrl()
                {
                        return string.Format(this.Url, this.Updater.Channel);
                }


                public string GetFullPath()
                {
                        return System.IO.Path.Combine(this.Updater.Path, this.RelativePath);
                }

                public string GetFullTempPath()
                {
                        return System.IO.Path.Combine(this.Updater.TempPath, this.RelativePath);
                }


                public int GetNewFileCount()
                {
                        if (this.Files == null)
                                return 0;

                        int Res = 0;
                        foreach (File Fil in this.Files) {
                                if (Fil.HasNewVersion())
                                        Res++;
                        }

                        return Res;
                }


                public int GetDownloadedFileCount()
                {
                        if (this.Files == null)
                                return 0;

                        int Res = 0;
                        foreach (File Fil in this.Files) {
                                if (Fil.HasNewVersion() && Fil.IsDownloaded)
                                        Res++;
                        }

                        return Res;
                }


                public void DownloadNewFiles()
                {
                        this.Updater.Progress.ChangeStatus("Descargando archivos nuevos de " + this.Name);
                        if (this.Files == null)
                                return;

                        foreach (File Fil in this.Files) {
                                if (Fil.HasNewVersion() && Fil.IsDownloaded == false)
                                        Fil.Download();
                                this.Updater.Progress.Value = this.GetDownloadedSize();
                        }
                }


                public bool UpdatesReady()
                {
                        return this.GetNewFileCount() > 0 && this.GetDownloadedFileCount() == this.GetNewFileCount();
                }


                public bool UpdatesPending()
                {
                        if (this.Files == null)
                                return false;

                        foreach (File Fil in this.Files) {
                                if (Fil.UpdatePending)
                                        return true;
                        }

                        return false;
                }



                public void ApplyUpdates()
                {
                        this.Updater.Progress.ChangeStatus("Aplicando actualizaciones de " + this.Name);

                        if (this.Files == null)
                                return;

                        foreach (File Fil in this.Files) {
                                if (Fil.HasNewVersion() && Fil.IsDownloaded)
                                        Fil.ApplyUpdates();
                        }
                }


                public int GetDownloadSize()
                {
                        if (this.Files == null)
                                return 0;

                        int Res = 0;
                        foreach (File Fil in this.Files) {
                                Res += Fil.NewCompSize;
                        }

                        return Res;
                }


                public int GetDownloadedSize()
                {
                        if (this.Files == null)
                                return 0;

                        int Res = 0;
                        foreach (File Fil in this.Files) {
                                if (Fil.IsDownloaded)
                                        Res += Fil.NewCompSize;
                        }

                        return Res;
                }


                public override string ToString()
                {
                        return this.Name;
                }
        }
}
