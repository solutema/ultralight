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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc
{
	public partial class AcercaDe : Lui.Forms.Form
	{

                public AcercaDe()
                {
                        InitializeComponent();
                }

		private void FormAcercaDe_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				OkButton.PerformClick();
			}
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
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                ListaComponentes.Items.Add(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                        }

                        EtiquetaFramework.Text = Lfx.Environment.SystemInformation.RuntimeName;
                }


		private void BotonActualizar_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
                        this.Close();
			Actualizador.Estado OFormActualizador = new Actualizador.Estado();
			OFormActualizador.TopMost = true;
			OFormActualizador.Show();
                        Lfx.Services.Updater.Master.UpdateFromWeb();
			OFormActualizador.Close();
			OFormActualizador = null;
                        if (Lfx.Services.Updater.Master.HasError()) {
                                Lui.Forms.MessageBox.Show(Lfx.Services.Updater.Master.ErrorMessage, "Error");
                        } else if (Lfx.Services.Updater.Master.UpdatedFiles == 0) {
                                Lui.Forms.MessageBox.Show("Ya está utilizando la versión más nueva disponible.", "Actualizar");
                        } else {
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
	}
}