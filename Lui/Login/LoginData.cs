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
using System.Collections.Generic;
using System.Text;

namespace Lui.Login
{
	public static class LoginData
	{
		public static bool ValidateAccess(Lws.LoginData loginData, string accessName)
		{
			return ValidateAccess(loginData,accessName, null);
		}

		public static bool ValidateAccess(Lws.LoginData loginData, string accessName, string itemId)
		{
			bool Tiene = Access(loginData,accessName, itemId);
			if(Tiene == false)
				System.Windows.Forms.MessageBox.Show("No tiene permiso para realizar la operación solicitada.", "Error");
			return Tiene;
		}

		public static bool Access(Lws.LoginData loginData, string accessName)
		{
			return Access(loginData,accessName, null);
		}

		public static bool Access(Lws.LoginData loginData, string accessName, int itemId)
		{
			return Access(loginData,accessName, itemId.ToString());
		}

		public static bool Access(Lws.LoginData loginData, string accessName, string itemId)
		{
			string Sql = "SELECT id_acceso FROM sys_accesslist WHERE id_persona=" + loginData.Id.ToString() + " AND id_acceso LIKE '" + accessName.Replace('*', '%') + "'";
			if(itemId != null && itemId.Length > 0)
				Sql += " AND (item='" + itemId + "' OR item='*')";

			System.Data.DataTable Accesos = loginData.Workspace.DefaultDataView.DataBase.Select(Sql);
			if(Accesos.Rows.Count > 0) {
				return true;
			} else {
                                Accesos = loginData.Workspace.DefaultDataView.DataBase.Select("SELECT id_acceso FROM sys_accesslist WHERE id_persona=" + loginData.Id.ToString() + " AND id_acceso='global.total' AND item='*'");
				if(Accesos.Rows.Count > 0)
					return true;
				else
					return false;
			}
		}

		public static bool RevalidateAccess(Lws.LoginData loginData)
		{
			Lui.Login.FormRevalidateAccess Reval = new Lui.Login.FormRevalidateAccess();
			Reval.Workspace = loginData.Workspace;
			bool Res = Reval.Revalidate();
                        Reval.Close();
                        Reval.Dispose();
                        Reval = null;
                        return Res;
		}


		public static bool ValidateAsAdmin(Lws.LoginData loginData)
		{
			return ValidateAsAdmin(loginData, null);
		}

		public static bool ValidateAsAdmin(Lws.LoginData loginData, string Explain)
		{
			Lui.Login.FormRevalidateAccess Reval = new Lui.Login.FormRevalidateAccess();
			if(Explain != null)
				Reval.Explain = Explain;
			Reval.Workspace = loginData.Workspace;
			return Reval.ValidateAs(1);
		}
	}
}