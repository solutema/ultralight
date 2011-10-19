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
        public class File
        {
                public Package Package { get; set; }

                public string Name { get; set; }
                public DateTime NewVersion { get; set; }
                public int NewSize { get; set; }
                public CompressionFormats Compression { get; set; }
                public int NewCompSize { get; set; }
                public bool UpdatePending { get; set; }

                internal DateTime DownloadedVersion { get; set; }
                internal byte[] FileContents { get; set; }

                public File(Package parent)
                {
                        this.Package = parent;
                }


                public string GetUrl()
                {
                        return this.Package.GetFullUrl() + "/" + this.Name;
                }


                public string GetCompressedUrl()
                {
                        string Res = this.GetUrl();
                        switch (this.Compression) {
                                case CompressionFormats.Bz2:
                                        Res = Res + ".bz2";
                                        break;
                        }
                        return Res;
                }


                public string GetFileName()
                {
                        return System.IO.Path.Combine(this.Package.GetFullPath(), this.Name);
                }


                public string GetTempFileName()
                {
                        return System.IO.Path.Combine(this.Package.GetFullTempPath(), this.Name) + ".new";
                }


                public string GetCompressedFileName()
                {
                        string Res = this.GetFileName();
                        switch(this.Compression)
                        {
                                case CompressionFormats.Bz2:
                                        Res = Res + ".bz2";
                                        break;
                        }
                        return Res;
                }

                public DateTime GetCurrentVersion()
                {
                        string FileName = this.GetFileName();
                        string TempFileName = this.GetTempFileName();

                        DateTime Res, TempVersion = DateTime.MinValue, CurrentVersion = DateTime.MinValue;

                        if (System.IO.File.Exists(TempFileName))
                                TempVersion = System.IO.File.GetLastWriteTime(TempFileName);
                        
                        if (System.IO.File.Exists(FileName))
                                CurrentVersion = System.IO.File.GetLastWriteTime(FileName);

                        Res = CurrentVersion;

                        if (TempVersion > Res) {
                                Res = TempVersion;
                                this.UpdatePending = true;
                        }

                        if (this.DownloadedVersion > Res) {
                                Res = this.DownloadedVersion;
                                this.UpdatePending = false;
                        }

                        return Res;
                }


                public bool HasNewVersion()
                {
                        DateTime CurrentVer = this.GetCurrentVersion();
                        return this.NewVersion > CurrentVer;
                }

                public void Download()
                {
                        this.Package.Updater.Progress.ChangeStatus("Descargando " + this.Name);

                        string FullUrl = this.Package.GetFullUrl() + this.Name;
                        switch (this.Compression) {
                                case CompressionFormats.Bz2:
                                        FullUrl = FullUrl + ".bz2";
                                        break;
                        }
                        using (WebClient Cliente = new WebClient()) {
                                try {
                                        this.FileContents = Cliente.DownloadData(FullUrl + "?dm=" + new Random().Next().ToString());
                                } catch {
                                        this.FileContents = null;
                                }
                        }
                }


                public bool IsDownloaded
                {
                        get
                        {
                                return this.FileContents != null && this.FileContents.Length == this.NewCompSize;
                        }
                }


                public void ApplyUpdates()
                {
                        this.Package.Updater.Progress.ChangeStatus("Aplicando actualización de " + this.Name);

                        string NewFileName = this.GetTempFileName();

                        switch (this.Compression) {
                                case CompressionFormats.None:
                                        using (System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(NewFileName), System.Text.Encoding.Default)) {
                                                wr.Write(this.FileContents);
                                                wr.Close();
                                        }
                                        break;
                                case CompressionFormats.Bz2:
                                        System.IO.MemoryStream InStr = new System.IO.MemoryStream(this.FileContents);
                                        Lfx.FileFormats.Compression.Archive ArchivoComprimido = new Lfx.FileFormats.Compression.Archive(InStr, Lfx.FileFormats.Compression.ArchiveTypes.BZip2);
                                        this.Package.Updater.Progress.ChangeStatus("Descomprimiendo " + this.Name);
                                        ArchivoComprimido.Extract(System.IO.File.Create(NewFileName));
                                        break;
                        }

                        System.IO.File.SetLastWriteTime(NewFileName, this.NewVersion);

                        this.FileContents = null;
                        this.DownloadedVersion = DateTime.MinValue;
                        this.UpdatePending = true;
                }

                public override string ToString()
                {
                        return this.Name;
                }
        }
}
