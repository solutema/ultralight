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
	public partial class CambioContrasena : Lui.Forms.Form
	{

                public CambioContrasena()
                {
                        InitializeComponent();
                }


		private void BotonAceptar_Click(object sender, System.EventArgs e)
		{
                        Lbl.Sys.Config.Actual.UsuarioConectado.Usuario.Cargar();

                        if (Lbl.Sys.Config.Actual.UsuarioConectado.Usuario.ContrasenaValida(EntradaContrasena.Text) == false) {
				System.Threading.Thread.Sleep(800);
				MessageBox.Show("La contraseña no es correcta. Por favor escriba su contraseña actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				EntradaContrasena.Focus();
                                return;
			}

                        if(EntradaContrasenaNueva1.Text.Length < 6 || EntradaContrasenaNueva1.Text.Length > 32) {
                                MessageBox.Show("La contraseña nueva no puede tener menos de 6 ni más de 32 caracteres. Por favor escriba otra contraseña.", "Error");
                                return;
                        }

                        if(EntradaContrasenaNueva1.Text != EntradaContrasenaNueva2.Text) {
                                MessageBox.Show("Debe escribir la contraseña nueva dos veces. Las dos contraseñas proporcionadas no coinciden.", "Error");
                                return;
                        }

                        // Genero una nueva sal para la contraseña
                        System.Random Rnd = new Random();
                        string Sal = "";
                        for (int i = 0; i < 100; i++) {
                                Sal += Rnd.Next(1, 9).ToString();
                        }

                        Lbl.Sys.Config.Actual.UsuarioConectado.Usuario.Contrasena = EntradaContrasenaNueva1.Text;
                        Lbl.Sys.Config.Actual.UsuarioConectado.Usuario.ContrasenaSal = Sal;
                        Lbl.Sys.Config.Actual.UsuarioConectado.Usuario.Guardar();

                        this.Hide();
                        Lfx.Workspace.Master.RunTime.Toast("Su contraseña ha sido cambiada. A partir de ahora debe utilizar siempre su nueva contraseña.", "Error");
                        this.Close();
                }


		private void BotonCancelar_Click(object sender, System.EventArgs e)
		{
                        this.Hide();
                        Lfx.Workspace.Master.RunTime.Toast("Su contraseña no ha sido cambiada.", "Aviso");
                        this.Close();
                }
	}
}