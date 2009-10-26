// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lazaro
{

	public class Config
	{

                /// <summary>
                /// Carga una configuración rápida de cosas mínimas que hacen falta antes de conectar al servidor.
                ///  ATENCIÓN: No incorporar aquí comandos que necesiten de una conexión al servidor o del formulario Principal porque todavía no existen.
                ///  Mantener esta función pequeña y sencilla.
                /// </summary>
		public static void PreIniciar()
		{
			
		}

		/// <summary>
                /// Aquí se carga el resto de la configuración.
                /// A diferencia de PreIniciar(), este procedimiento espera que haya una conexión activa al servidor de base de datos.
		/// </summary>
		public static Lfx.Types.OperationResult Iniciar()
		{
			Lfx.Types.OperationResult iniciarReturn = new Lfx.Types.SuccessOperationResult();

			Aplicacion.CUIT = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Empresa.CUIT", "");
			Lfx.Types.Currency.CurrencySymbol = Lws.Workspace.Master.DefaultDataBase.FieldString("SELECT signo FROM monedas WHERE id_moneda=" + Lfx.Types.Currency.DefaultCurrency.ToString());

			return iniciarReturn;
		}

		public static void Terminar()
		{
			
		}
	}
}