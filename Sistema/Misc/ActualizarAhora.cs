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
        public partial class ActualizarAhora : Lui.Forms.Form
        {
                private bool YaBusqueActualizaciones = false;

                public ActualizarAhora()
                {
                        InitializeComponent();
                }

                private void BotonInstalar_Click(object sender, EventArgs e)
                {
                        switch (BotonInstalar.Text) {
                                case "Continuar":
                                        this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
                                        break;
                                case "Instalar":
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        Lfx.Environment.Shell.Reboot();
                                        break;
                                case "Cancelar":
                                default:
                                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                                        break;
                        }
                        this.Close();
                }

                private void TimerProgreso_Tick(object sender, EventArgs e)
                {
                        TimerProgreso.Stop();

                        if (Lfx.Updates.Updater.Master == null)
                                return;

                        if (YaBusqueActualizaciones == false) {
                                YaBusqueActualizaciones = true;
                                Lfx.Updates.Updater.Master.ForceCheckNow();
                        }

                        if (Lfx.Updates.Updater.Master.Progress.IsRunning) {
                                BotonInstalar.Text = "Cancelar";
                                EtiquetaEstado.Text = "Descargando...";
                                BarraProgreso.Maximum = Lfx.Updates.Updater.Master.Progress.Max;
                                BarraProgreso.Value = Lfx.Updates.Updater.Master.Progress.Value;
                                EtiquetaProgreso.Text = Lfx.Updates.Updater.Master.Progress.PercentDone.ToString() + "%";
                                EtiquetaAyuda.Text = @"Si no desea instalar la actualización ahora, haga clic en el botón 'Cancelar'. La descarga continuará en segundo plano y se instalará en otro momento.";
                        } else {
                                if (Lfx.Updates.Updater.Master.UpdatesPending()) {
                                        BotonInstalar.Text = "Instalar";
                                        EtiquetaEstado.Text = "Finalizado";
                                        EtiquetaProgreso.Text = "100%";
                                        BarraProgreso.Value = BarraProgreso.Maximum;
                                        EtiquetaAyuda.Text = @"Se descargaron las actualizaciones y están listas para ser instaladas. Haga clic en el botón 'Instalar'.";
                                        return;
                                } else {
                                        BotonInstalar.Text = "Continuar";
                                        EtiquetaEstado.Text = "Finalizado";
                                        EtiquetaAyuda.Text = @"No se encontraron actualizaciones o hubo un problema al descargarlas. La descarga se va a realizar en otro momento. Puede continuar.";
                                        return;
                                }
                        }

                        TimerProgreso.Start();
                }
        }
}
