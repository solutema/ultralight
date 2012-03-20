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

namespace Lfx.Updates
{
        public class Updater
        {
                public static Updater Master = null;
                public Lfx.Types.OperationProgress Progress;

                public PackageCollection Packages;
                public string Channel { get; set; }

                private bool Running { get; set; }
                private System.Threading.Thread UpdaterThread = null;
                
                /// <summary>
                /// Path to store temporary files.
                /// </summary>
                public string TempPath { get; set; }

                /// <summary>
                /// Destination path for the downloaded files.
                /// </summary>
                public string Path { get; set; }

                private bool DownloadNow { get; set; }
                private DateTime LastUpdate = DateTime.MinValue;
                
                /// <summary>
                /// Interval between checks, in minutes.
                /// </summary>
                private int Interval = 90;

                public Updater()
                        : this("stable")
                { }

                public Updater(string channel)
                {
                        this.Channel = channel;
                        this.Progress = new Types.OperationProgress("Actualizador", "Mantiene los archivos de la aplicación actualizados.");
                        this.Progress.Modal = false;
                        this.Progress.Advertise = false;
                        this.Packages = new PackageCollection(this);
                }

                public void Start()
                {
                        // Simulo la ultima actualización hace un rato, para que verifique en 2 minutos
                        this.LastUpdate = DateTime.Now.AddMinutes(-this.Interval + 2);

                        if (this.UpdaterThread == null) {
                                this.UpdaterThread = new System.Threading.Thread(new System.Threading.ThreadStart(UpdateProc));
                                this.UpdaterThread.Priority = System.Threading.ThreadPriority.BelowNormal;
                                this.UpdaterThread.IsBackground = true;
                                this.UpdaterThread.Start();
                        }
                }


                public void Stop()
                {
                        this.Running = false;
                        if (this.UpdaterThread != null)
                                this.UpdaterThread.Abort();
                }


                private void UpdateProc()
                {
                        System.Console.WriteLine("Iniciando actualizador...");
                        this.Running = true;

                        while (this.Running) {
                                if (this.DownloadNow && this.Progress.IsRunning == false) {
                                        this.DownloadNow = false;
                                        this.DownloadAndApply();
                                }

                                // Dormir 5 segundos
                                System.Threading.Thread.Sleep(5000);

                                TimeSpan Dif = DateTime.Now - LastUpdate;
                                if(Dif.TotalMinutes > this.Interval) {
                                        this.DownloadUpdatesInformation();
                                        if(this.GetNewFileCount() > 0)
                                                this.DownloadNow = true;
                                }
                        }
                }


                public void ForceCheckNow()
                {
                        if (this.Progress.IsRunning)
                                return;

                        this.Progress.Begin();
                        this.Progress.ChangeStatus("Buscando versiones nuevas...");
                        this.Progress.Value = 0;

                        this.LastUpdate = DateTime.MinValue;
                }


                private void DownloadAndApply()
                {
                        // No hay paquetes
                        if (this.Packages == null)
                                return;

                        // Ya estoy trabajando
                        if (this.Progress.IsRunning)
                                return;

                        this.Progress.Begin();
                        this.Progress.ChangeStatus("Iniciando actualización...");
                        this.Progress.Max = this.GetDownloadSize();
                        this.DownloadNewFiles();

                        if (this.UpdatesReady())
                                this.ApplyUpdates();

                        this.Progress.End();
                }


                private void DownloadUpdatesInformation()
                {
                        this.LastUpdate = DateTime.Now;

                        if (this.Packages == null)
                                return;

                        this.Progress.Begin();
                        this.Progress.ChangeStatus("Buscando versiones nuevas...");
                        this.Progress.Max = 0;
                        this.Progress.Value = 0;

                        foreach (Package Pkg in this.Packages) {
                                string DestDir = Pkg.GetFullTempPath();
                                if (System.IO.Directory.Exists(DestDir) == false)
                                        System.IO.Directory.CreateDirectory(DestDir);

                                Pkg.DownloadUpdatesInformation();
                        }

                        this.Progress.End();
                }


                private bool UpdatesReady()
                {
                        if (this.Packages == null)
                                return false;

                        foreach (Package Pkg in this.Packages) {
                                if (Pkg.UpdatesReady())
                                        return true;
                        }

                        return false;
                }


                public bool UpdatesPending()
                {
                        if (this.Packages == null)
                                return false;

                        if (this.Progress.IsRunning)
                                return false;

                        foreach (Package Pkg in this.Packages) {
                                if (Pkg.UpdatesPending())
                                        return true;
                        }

                        return false;
                }


                private int GetNewFileCount()
                {
                        if (this.Packages == null)
                                return 0;

                        int Res = 0;
                        foreach (Package Pkg in this.Packages) {
                                Res += Pkg.GetNewFileCount();
                        }

                        return Res;
                }


                private int GetDownloadSize()
                {
                        if (this.Packages == null)
                                return 0;

                        int Res = 0;
                        foreach (Package Pkg in this.Packages) {
                                Res += Pkg.GetDownloadSize();
                        }

                        return Res;
                }


                protected internal int GetDownloadedSize()
                {
                        if (this.Packages == null)
                                return 0;

                        int Res = 0;
                        foreach (Package Pkg in this.Packages) {
                                Res += Pkg.GetDownloadedSize();
                        }

                        return Res;
                }


                private void DownloadNewFiles()
                {
                        if (this.Packages == null)
                                return;

                        foreach (Package Pkg in this.Packages) {
                                Pkg.DownloadNewFiles();
                        }
                }


                private int GetDownloadedFileCount()
                {
                        if (this.Packages == null)
                                return 0;

                        int Res = 0;
                        foreach (Package Pkg in this.Packages) {
                                Res += Pkg.GetDownloadedFileCount();
                        }

                        return Res;
                }


                private void ApplyUpdates()
                {
                        this.Progress.ChangeStatus("Aplicando actualizaciones...");

                        if (this.Packages == null)
                                return;

                        foreach (Package Pkg in this.Packages) {
                                if (Pkg.UpdatesReady())
                                        Pkg.ApplyUpdates();
                        }
                }
        }
}
