#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lui.Login
{
	internal partial class FormRevalidateAccess : Lui.Forms.DialogForm
	{
		public string Explain = null;

		public FormRevalidateAccess()
		{
			InitializeComponent();

			Titulo.Font = Lfx.Config.Display.CurrentTemplate.TitleFont;
			Titulo.BackColor = Lfx.Config.Display.CurrentTemplate.TitleBackground;
			Titulo.ForeColor = Lfx.Config.Display.CurrentTemplate.TitleText;
			CancelCommandButton.Text = "Cancelar";
		}

		public bool Revalidate()
		{
			return this.ValidateAs(this.Workspace.CurrentUser.Id);
		}

		public bool ValidateAs(int userId)
		{
			if(userId == 1) {
				Titulo.Text = "Escriba la contraseña de Administrador";
				if(Explain == null)
					LabelExplain.Text = "La operación que intenta realizar requiere por motivos de seguridad que escriba la contraseña de Administrador.";
				else
					LabelExplain.Text = Explain;
			} else if(userId != this.Workspace.CurrentUser.Id) {
				this.Titulo.Text = "Para continuar, por favor escriba la contraseña del usuario.";
				if(Explain == null)
					this.LabelExplain.Text = "La operación que intenta realizar requiere por motivos de seguridad que escribir la contraseña de un usuario con permiso.";
				else
					LabelExplain.Text = Explain;
			}

			EntradaUsuario.Text = this.DataBase.Tables["personas"].FastRows[userId].Fields["nombre_visible"].ValueString;
			EntradaContrasena.Text = "";
			if(this.ShowDialog() == DialogResult.OK) {
				Lfx.Data.Row Usuario = this.DataBase.FirstRowFromSelect("SELECT id_persona, nombre, nombre_visible FROM personas WHERE id_persona=" + userId.ToString() + " AND contrasena='" + this.DataBase.EscapeString(EntradaContrasena.Text) + "'");
				if(Usuario != null && System.Convert.ToInt32(Usuario["id_persona"]) == userId) {
					return true;
				} else {
					Lui.Forms.MessageBox.Show("La contraseña proporcionada no es correcta.", "Error");
					System.Threading.Thread.Sleep(1000);
					return false;
				}
			} else {
				return false;
			}
		}
	}
}