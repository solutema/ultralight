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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.WinMain.Misc
{
	public partial class Ingreso : Lui.Forms.Form
	{

                public Ingreso()
                {
                        InitializeComponent();
                }


		private void FormIngreso_Load(object sender, System.EventArgs e)
		{
                        int UltimoUsuario = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Ingreso.UltimoUsuario", 0);
                        if (UltimoUsuario == 0 && Lfx.Data.DataBaseCache.DefaultCache.ServerName.ToUpperInvariant() == "LOCALHOST")
                                // Si estoy en localhost, el usuario predeterminado es Administrador
                                UltimoUsuario = 1;

                        EntradaUsuario.TextInt = UltimoUsuario;
		}


		private void BotonAceptar_Click(object sender, System.EventArgs e)
		{
                        if (EntradaUsuario.TextInt == 0) {
                                MessageBox.Show("Por favor ingrese su número de usuario y su contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                return;
                        }

                        if (EntradaUsuario.TextInt == 1 && Lfx.Workspace.Master.DebugMode == false) {
                                string[] EstacionesAdministrador = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<string>("Sistema.Ingreso.Administrador.Estaciones", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                bool Puede = false;
                                if (EstacionesAdministrador.Length == 0) {
                                        Puede = true;
                                } else {
                                        foreach (string Estacion in EstacionesAdministrador) {
                                                if (Estacion.ToUpperInvariant() == System.Environment.MachineName.ToUpperInvariant()) {
                                                        Puede = true;
                                                        break;
                                                }
                                        }
                                }

                                if (Puede == false) {
                                        System.Threading.Thread.Sleep(800);
                                        Lbl.Sys.Config.ActionLog(Lfx.Workspace.Master.MasterConnection, Lbl.Sys.Log.Acciones.LogOnFail, EntradaUsuario.Elemento, "Estación no permitida.");
                                        MessageBox.Show("No se permite el acceso como Administrador desde este equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                }
                        }

                        Lbl.Personas.Usuario Usu = new Lbl.Personas.Usuario(Lfx.Workspace.Master.MasterConnection, EntradaUsuario.TextInt);
                        if(Usu.ContrasenaValida(EntradaContrasena.Text) == false) {
				System.Threading.Thread.Sleep(800);
                                Lbl.Sys.Config.ActionLog(Lfx.Workspace.Master.MasterConnection, Lbl.Sys.Log.Acciones.LogOnFail, EntradaUsuario.Elemento, "Usuario o contraseña incorrecto.");
				MessageBox.Show("El nombre de usuario o la contraseña son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				EntradaContrasena.Focus();
			} else {
				OkButton.Text = "Ingresando...";
				OkButton.Refresh();
                                Lbl.Personas.Persona Usuario = new Lbl.Personas.Persona(Lfx.Workspace.Master.MasterConnection, Usu.Id);
                                Lbl.Sys.Config.Actual.UsuarioConectado = new Lbl.Sys.Configuracion.UsuarioConectado(Lfx.Workspace.Master, Usu);
                                Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema.Ingreso.UltimoUsuario", Lbl.Sys.Config.Actual.UsuarioConectado.Id.ToString(), System.Environment.MachineName.ToUpperInvariant());
				Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema.Ingreso.UltimoIngreso", Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now), System.Environment.MachineName.ToUpperInvariant());
                                Lbl.Sys.Config.ActionLog(Lfx.Workspace.Master.MasterConnection, Lbl.Sys.Log.Acciones.LogOn, Usu, null);
				this.Close();
			}
		}


		private void BotonCancelar_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("¿Está seguro de que desea abandonar el programa?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				System.Environment.Exit(0);
			}
		}


		private void CambioDatos(object sender, System.EventArgs e)
		{
			OkButton.Enabled = EntradaUsuario.Text.Length > 0;
		}

                private void BotonWebAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                        if (EntradaUsuario.TextInt == 1)
                                Lui.Forms.MessageBox.Show("Si es la primera vez que utiliza el sistema, escriba la contraseña 'admin' (sin las comillas)", "Información");
                        else
                                Lui.Forms.MessageBox.Show("Si no dispone de una contraseña, por favor póngase en contacto con el administrador.", "Información");
                }
	}
}