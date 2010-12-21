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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro
{
        public class Datos
        {
                /// <summary>
                /// Inicia una conexión con la base de datos y verifica si la versión de la la misma es la última disponible. En caso contrario la actualiza.
                /// </summary>
                /// <returns></returns>
                public static Lfx.Types.OperationResult Iniciar()
                {
                        Lfx.Types.OperationResult iniciarReturn = new Lfx.Types.SuccessOperationResult();

                        //Si el servidor SQL es esta misma PC, intento iniciar el servidor
                        if (Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows && Lfx.Data.DataBaseCache.DefaultCache.ServerName.ToUpperInvariant() == "LOCALHOST") {
                                switch (Lfx.Data.DataBaseCache.DefaultCache.AccessMode) {
                                        case Lfx.Data.AccessModes.MySql:
                                                Lfx.Environment.Shell.Execute("net", "start mysql", ProcessWindowStyle.Hidden, true);
                                                break;
                                        case Lfx.Data.AccessModes.Npgsql:
                                                // FIXME: detectar el nombre del servicio.
                                                Lfx.Environment.Shell.Execute("net", "start postgresql-8.4", ProcessWindowStyle.Hidden, true);
                                                break;
                                }
                        }

                        try {
                                Lfx.Workspace.Master.MasterConnection.Open();
                        } catch (Exception ex) {
                                return new Lfx.Types.FailureOperationResult(ex.Message);
                        }

                        if (Lfx.Workspace.Master.IsPrepared() == false) {
                                using (Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog(@"Aparentemente es la primera vez que conecta a este servidor. Antes de poder utilizarlo debe preparar el servidor con una carga inicial de datos.
Responda 'Si' sólamente si es la primera vez que utiliza el sistema Lázaro o está restaurando desde una copia de seguridad.", @"¿Desea preparar el servidor """ + Lfx.Workspace.Master.MasterConnection.ToString() + @"""?")) {
                                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                                Lfx.Types.OperationResult Res;
                                                using (Lfx.Data.Connection DataBase = Lfx.Workspace.Master.GetNewConnection("Preparar servidor")) {
                                                        DataBase.RequiresTransaction = false;
                                                        Res = Lfx.Workspace.Master.Prepare();
                                                }
                                                if (Res.Success == false)
                                                        return Res;
                                                else
                                                        Lui.Forms.MessageBox.Show("El servidor fue preparado con éxito. Puede comenzar a utilizar el sistema.", "Preparar Servidor");
                                        } else {
                                                return new Lfx.Types.FailureOperationResult("Debe preparar el servidor.");
                                        }
                                }
                        }

                        // Configuro el nivel de aislación predeterminado
                        Lfx.Data.DataBaseCache.DefaultCache.DefaultIsolationLevel = (Lfx.Data.IsolationLevels)(Enum.Parse(typeof(Lfx.Data.IsolationLevels), Lfx.Workspace.Master.CurrentConfig.ReadGlobalSettingString("Sistema", "Datos.Aislacion", "Serializable")));
                        
                        if (Lfx.Environment.SystemInformation.DesignMode == false) {
                                // Si es necesario, actualizo la estructura de la base de datos
                                using (Lfx.Data.Connection DataBaseVerif = Lfx.Workspace.Master.GetNewConnection("Verificar versión de la base de datos")) {
                                        Lfx.Workspace.Master.CheckAndUpdateDataBaseVersion(DataBaseVerif, false, false);
                                        DataBaseVerif.Dispose();
                                }
                        }
                        return iniciarReturn;
                }
        }
}