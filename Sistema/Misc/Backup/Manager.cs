#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc.Backup
{
	public partial class Manager : Lui.Forms.DialogForm
	{
                public Manager()
                {
                        InitializeComponent();

                        OkButton.Visible = false;
                        MostrarListaBackups();
                }

		public void MostrarListaBackups()
		{
                        List<string> Backups = Misc.Backup.Services.ListaBackups();
			string BackupMasNuevo = Misc.Backup.Services.BackupMasNuevo();

			lvItems.BeginUpdate();
			lvItems.Items.Clear();
			int i = 1;
			foreach (string NombreCarpeta in Backups)
			{
				string ArchivoIni = Lfx.Types.Strings.ReadTextFile(Misc.Backup.Services.BackupPath + NombreCarpeta + System.IO.Path.DirectorySeparatorChar + "info.txt");
				ListViewItem Itm = new ListViewItem();
				Itm = lvItems.Items.Add(NombreCarpeta);
				if (BackupMasNuevo == NombreCarpeta)
				{
					Itm.Font = new Font(Itm.Font, FontStyle.Bold);
					Itm.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;
				}
				Itm.SubItems.Add(System.Convert.ToString(i));
				Itm.SubItems.Add(Lfx.Types.Ini.ReadString(ArchivoIni, "", "FechaYHora"));
				Itm.SubItems.Add(Lfx.Types.Ini.ReadString(ArchivoIni, "", "Usuario"));
				i++;
			}
			lvItems.Sorting = SortOrder.Descending;
			lvItems.Sort();
			lvItems.EndUpdate();
		}


		private void BotonBackup_Click(System.Object sender, System.EventArgs e)
		{
			BotonBackup.Enabled = false;
			Aplicacion.Exec("BACKUP NOW");
			MostrarListaBackups();
		}


		private void BotonEliminar_Click(object sender, System.EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0] != null)
			{
				string NombreCarpeta = lvItems.SelectedItems[0].Text;
				Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Puede eliminar una copia de respaldo antigua o que ya no sea de utilidad. Al eliminar una copia de respaldo no se modifican los datos actualmente almacenados en el sistema, ni tampoco se impide que el sistema haga nuevas copias de respaldo.", "¿Desea eliminar la copia de respaldo seleccionada?");
				Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
				if (Pregunta.ShowDialog() == DialogResult.OK)
				{
					Misc.Backup.Services.DeleteBackup(NombreCarpeta);
					MostrarListaBackups();
				}
			}
		}


		private void BotonRestaurar_Click(object sender, System.EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0] != null)
			{
				string NombreCarpeta = lvItems.SelectedItems[0].Text;
				string FechaYHora = lvItems.SelectedItems[0].SubItems[2].Text;

				Misc.Backup.Restore OPregunta = new Misc.Backup.Restore();
				OPregunta.lblFecha.Text = FechaYHora;
				if (OPregunta.ShowDialog() == DialogResult.OK)
				{
					Misc.Backup.Services.Restore(NombreCarpeta);
				}
			}
		}

		private void BotonCopiar_Click(object sender, EventArgs e)
		{
			Lfx.Environment.Shell.Execute(Lfx.Environment.Folders.ApplicationDataFolder + @"Backup\", "", ProcessWindowStyle.Normal, false);
		}
	}
}
