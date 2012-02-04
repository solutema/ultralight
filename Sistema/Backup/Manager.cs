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
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.WinMain.Backup
{
        public partial class Manager : Lui.Forms.ChildDialogForm
        {
                Lfx.Backups.Manager BackupManager = new Lfx.Backups.Manager();

                public Manager()
                {
                        InitializeComponent();

                        OkButton.Visible = false;
                        MostrarListaBackups();
                }


                protected override void OnActivated(EventArgs e)
                {
                        base.OnActivated(e);
                        MostrarListaBackups();
                }

                public void MostrarListaBackups()
                {
                        List<Lfx.Backups.BackupInfo> Backups = this.BackupManager.GetBackups();
                        string BackupMasNuevo = this.BackupManager.GetNewestBackupName();

                        Listado.BeginUpdate();
                        Listado.Items.Clear();
                        int i = 1;
                        foreach (Lfx.Backups.BackupInfo Backup in Backups) {
                                ListViewItem Itm = new ListViewItem(i.ToString("0000"));
                                Itm = Listado.Items.Add(Backup.Name);
                                if (BackupMasNuevo == Backup.Name) {
                                        Itm.Font = new Font(Itm.Font, FontStyle.Bold);
                                }
                                Itm.SubItems.Add(i.ToString("00"));
                                Itm.SubItems.Add(Lfx.Types.Formatting.FormatSmartDateAndTime(Backup.BackupDate));
                                Itm.SubItems.Add(Backup.UserName);
                                i++;
                        }
                        //Listado.Sorting = SortOrder.Descending;
                        //Listado.Sort();
                        Listado.EndUpdate();
                }


                private void BotonBackup_Click(System.Object sender, System.EventArgs e)
                {
                        BotonBackup.Enabled = false;
                        Ejecutor.Exec("BACKUP NOW");
                }


                private void BotonEliminar_Click(object sender, System.EventArgs e)
                {
                        if (Listado.SelectedItems.Count > 0 && Listado.SelectedItems[0] != null) {
                                string NombreCarpeta = Listado.SelectedItems[0].Text;
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Puede eliminar una copia de respaldo antigua o que ya no sea de utilidad. Al eliminar una copia de respaldo no se modifican los datos actualmente almacenados en el sistema, ni tampoco se impide que el sistema haga nuevas copias de respaldo.", "¿Desea eliminar la copia de respaldo seleccionada?");
                                Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                if (Pregunta.ShowDialog() == DialogResult.OK) {
                                        this.BackupManager.Delete(NombreCarpeta);
                                        MostrarListaBackups();
                                }
                        }
                }


                private void BotonRestaurar_Click(object sender, System.EventArgs e)
                {
                        if (Listado.SelectedItems.Count > 0 && Listado.SelectedItems[0] != null) {
                                string NombreCarpeta = Listado.SelectedItems[0].Text;
                                string FechaYHora = Listado.SelectedItems[0].SubItems[2].Text;

                                WinMain.Backup.Restore OPregunta = new WinMain.Backup.Restore();
                                OPregunta.lblFecha.Text = FechaYHora;
                                if (OPregunta.ShowDialog() == DialogResult.OK) {
                                        this.BackupManager.Restore(NombreCarpeta);
                                        this.Close();
                                }
                        }
                }

                private void BotonCopiar_Click(object sender, EventArgs e)
                {
                        Lfx.Environment.Shell.Execute(Lfx.Environment.Folders.ApplicationDataFolder + @"Backup\", "", ProcessWindowStyle.Normal, false);
                }
        }
}