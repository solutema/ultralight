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
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc
{
	public partial class Ingreso : Lui.Forms.Form
	{

                public Ingreso()
                {
                        InitializeComponent();

                        LowerPanel.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
                        Titulo.Font = Lws.Config.Display.CurrentTemplate.TitleFont;
                        Titulo.BackColor = Lws.Config.Display.CurrentTemplate.TitleBackground;
                        Titulo.ForeColor = Lws.Config.Display.CurrentTemplate.TitleText;
                }

		private void FormIngreso_Load(object sender, System.EventArgs e)
		{
			this.Workspace = Lws.Workspace.Master;
			txtUsuario.Text = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Ingreso.UltimoUsuario", "0");
		}


		private void cmdAceptar_Click(object sender, System.EventArgs e)
		{
                        if (txtUsuario.TextInt == 1) {
                                string[] EstacionesAdministrador = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString("Sistema", "Ingreso.Administrador.Estaciones", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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
                                        this.Workspace.ActionLog("LOGON.FAIL", "", txtUsuario.TextInt, "Estación no permitida.");
                                        MessageBox.Show("No se permite el acceso como Administrador desde este equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                }
                        }
			Lfx.Data.Row row = Lws.Workspace.Master.DefaultDataBase.FirstRowFromSelect("SELECT id_persona, nombre, nombre_visible FROM personas WHERE id_persona=" + txtUsuario.TextInt.ToString() + " AND contrasena='" + Lws.Workspace.Master.DefaultDataBase.EscapeString(txtContrasena.Text) + "'");
			if(row == null) {
				System.Threading.Thread.Sleep(800);
                                this.Workspace.ActionLog("LOGON.FAIL", "", txtUsuario.TextInt, "Usuario o contraseña incorrecto.");
				MessageBox.Show("El nombre de usuario o la contraseña son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtContrasena.Focus();
			} else {
				OkButton.Text = "Ingresando...";
				OkButton.Refresh();
				this.Workspace.CurrentUser.Id = System.Convert.ToInt32(row["id_persona"]);
				this.Workspace.CurrentUser.UserName = System.Convert.ToString(row["nombre"]).ToLower();
				this.Workspace.CurrentUser.CompleteName = System.Convert.ToString(row["nombre_visible"]);
				this.Workspace.CurrentConfig.WriteGlobalSetting(null, "Sistema.Ingreso.UltimoUsuario", System.Convert.ToString(Lws.Workspace.Master.CurrentUser.Id), System.Environment.MachineName.ToUpperInvariant());
				this.Workspace.CurrentConfig.WriteGlobalSetting(null, "Sistema.Ingreso.UltimoIngreso", Lfx.Types.Formatting.FormatDateTimeSql(System.DateTime.Now), System.Environment.MachineName.ToUpperInvariant());
				this.Workspace.ActionLog("LOGON", "");
				this.Close();
			}
		}


		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("¿Está seguro de que desea abandonar el programa?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				System.Environment.Exit(0);
			}
		}


		private void CambioDatos(object sender, System.EventArgs e)
		{
			OkButton.Enabled = txtUsuario.Text.Length > 0;
		}
	}
}