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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc
{
	public partial class AcercaDe : Lui.Forms.Form
	{

                public AcercaDe()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                }

		private void FormAcercaDe_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				OkButton_Click(sender, null);
			}
		}


		private void FormAcercaDe_Load(object sender, System.EventArgs e)
		{
			ListaComponentes.BackColor = this.BackColor;

                        EtiquetaUsuario.Text = Lws.Workspace.Master.CurrentUser.UserId.ToString() + " (" + Lws.Workspace.Master.CurrentUser.UserCompleteName + ") / " + Lfx.Environment.SystemInformation.ComputerName;

                        ListaComponentes.Items.Add("Lazaro versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").ProductVersion + " del " + new System.IO.FileInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationFolder);
                        foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                ListaComponentes.Items.Add(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
                        }

			Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
			foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll"))
			{
                                ListaComponentes.Items.Add(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.DefaultDateTimeFormat));
			}

                        //Versión de MyODBC, sólo en Windows
                        if(Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows)
                        {
				if(System.IO.File.Exists(Lfx.Environment.Folders.WindowsSystemFolder + "myodbc3.dll"))
					ListaComponentes.Items.Add("MySQL ODBC versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.WindowsSystemFolder + "myodbc3.dll").ProductVersion);
                                if(System.IO.File.Exists(Lfx.Environment.Folders.WindowsSystemFolder + "myodbc5.dll"))
                                        ListaComponentes.Items.Add("MySQL ODBC versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.WindowsSystemFolder + "myodbc5.dll").ProductVersion);
                        }

                        //Versión del Framework
                        switch (Lfx.Environment.SystemInformation.RunTime) {
                                case Lfx.Environment.SystemInformation.RunTimes.DotNet:
                                        bool TieneDotNet3 = false;
                                        try {
                                                Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0", false);
                                                object Installed = LocalMachine.GetValue("Install");
                                                if (System.Convert.ToInt32(Installed) == 1)
                                                        TieneDotNet3 = true;
                                        }
                                        catch (Exception ex) {
                                                System.Console.WriteLine(ex.Message);
                                                TieneDotNet3 = false;
                                        }


                                        bool TieneDotNet35 = false;
                                        try {
                                                Microsoft.Win32.RegistryKey LocalMachine = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.5", false);
                                                object Installed = LocalMachine.GetValue("Install");
                                                if (System.Convert.ToInt32(Installed) == 1)
                                                        TieneDotNet35 = true;
                                        }
                                        catch (Exception ex) {
                                                System.Console.WriteLine(ex.Message);
                                                TieneDotNet35 = false;
                                        }

                                        string VersionesDotNet = "Microsoft .NET 2.0";
                                        if (TieneDotNet3)
                                                VersionesDotNet += ", 3.0";
                                        if (TieneDotNet35)
                                                VersionesDotNet += ", 3.5";

                                        EtiquetaFramework.Text = VersionesDotNet;
                                        break;
                                case Lfx.Environment.SystemInformation.RunTimes.Mono:
                                        EtiquetaFramework.Text = "Novell Mono";
                                        break;
                                default:
                                        EtiquetaFramework.Text = "Desconocido";
                                        break;
                        }
		}


		private void lblActualizar_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Actualizador.Estado OFormActualizador = new Actualizador.Estado();
			OFormActualizador.TopMost = true;
			OFormActualizador.Show();
			Actualizador.Actualizador.ActualizarAplicacionDesdeWeb(true, OFormActualizador);
			OFormActualizador.Close();
			OFormActualizador = null;
			if (Actualizador.Actualizador.HuboError())
				Lui.Forms.MessageBox.Show(Actualizador.Actualizador.MensajeError, "Error");
			else if (Actualizador.Actualizador.ArchivosActualizados == 0)
				Lui.Forms.MessageBox.Show("Ya está utilizando la versión más nueva disponible.", "Actualizar");
		}

		private void OkButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}