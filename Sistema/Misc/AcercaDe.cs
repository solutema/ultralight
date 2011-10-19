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
using System.Windows.Forms;

namespace Lazaro.Misc
{
	public partial class AcercaDe : Lui.Forms.Form
	{
                private bool YaBusqueActualizaciones = false;

                public AcercaDe()
                {
                        InitializeComponent();

                        EtiquetaActualizar.Visible = Lfx.Updates.Updater.Master != null;
                }


                private void FormAcercaDe_Load(object sender, System.EventArgs e)
                {
                        ListaComponentes.BackColor = this.BackColor;

                        EtiquetaUsuario.Text = Lbl.Sys.Config.Actual.UsuarioConectado.Id.ToString() + " (" + Lbl.Sys.Config.Actual.UsuarioConectado.Persona.Nombre + ") / " + System.Environment.MachineName;

                        ListaComponentes.Items.Add("Lazaro versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").ProductVersion + " del " + new System.IO.FileInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                ListaComponentes.Items.Add(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        }

                        Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll", System.IO.SearchOption.AllDirectories)) {
                                ListaComponentes.Items.Add(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        }

                        EtiquetaFramework.Text = Lfx.Environment.SystemInformation.RuntimeName;
                        if (System.Runtime.InteropServices.Marshal.SizeOf(typeof(System.IntPtr)) == 8)
                                EtiquetaFramework.Text += " (64 bits)";
                }


		private void BotonActualizar_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
                        this.Close();
                        if (Lfx.Updates.Updater.Master != null && Lfx.Updates.Updater.Master.UpdatesPending()) {
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Se descargó una nueva versión de Lázaro. Debe reiniciar la aplicación para instalar la actualización.", "¿Desea reiniciar ahora?");
                                Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                DialogResult Respuesta = Pregunta.ShowDialog();
                                if (Respuesta == DialogResult.OK)
                                        Aplicacion.Exec("REBOOT");
                        }
		}

		private void OkButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

                private void BotonWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        Help.ShowHelp(this, "http://www.sistemalazaro.com.ar");
                }

                private void TimerBuscarActualizaciones_Tick(object sender, EventArgs e)
                {
                        TimerBuscarActualizaciones.Stop();

                        if (Lfx.Updates.Updater.Master == null) {
                                if (Lfx.Workspace.Master.DebugMode)
                                        EtiquetaActualizar.Text = "Modo de depuración activado.";
                                return;
                        }

                        if (YaBusqueActualizaciones == false) {
                                YaBusqueActualizaciones = true;
                                Lfx.Updates.Updater.Master.ForceCheckNow();
                        }

                        if (Lfx.Updates.Updater.Master.Progress.IsRunning) {
                                EtiquetaActualizar.Text = "Descargando " + Lfx.Updates.Updater.Master.Progress.PercentDone.ToString() + "%";
                                EtiquetaActualizar.LinkArea = new LinkArea(0, 0);
                        } else {
                                if (Lfx.Updates.Updater.Master.UpdatesPending()) {
                                        EtiquetaActualizar.Text = "Hay una actualización lista para aplicarse";
                                        EtiquetaActualizar.LinkArea = new LinkArea(0, EtiquetaActualizar.Text.Length);
                                } else {
                                        EtiquetaActualizar.Text = "Lázaro está actualizado";
                                        EtiquetaActualizar.LinkArea = new LinkArea(0, 0);
                                }
                        }

                        TimerBuscarActualizaciones.Start();
                }
	}
}