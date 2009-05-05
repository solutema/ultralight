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

namespace Lazaro
{

	public class Config
	{
		public enum Versiones
		{
			Gratuita = 0,
			Completa = 1,
		}

		public static Versiones Version = Versiones.Gratuita;

		// Sub: ModuloConfig_PreIniciar
		// Descripción:
		//    Carga una configuración rápida de cosas mínimas que hacen falta
		//    antes de conectar al servidor
		//    ATENCIÓN: No incorporar aquí comandos que necesiten de una conexión al servidor
		//    o de FormPrincipal porque todava no existen!!!
		//    Mantener esta función pequeña y sencilla
		public static void PreIniciar()
		{
			
		}

		// Función: ModuloConfig_Iniciar
		// Descripción:
		//    Aquí se carga el resto de la configuración
		//    A diferencia de ModuloConfig_PreIniciar(), este procedimiento
		//    espera que haya una conexión activa al servidor de base de datos
		public static Lfx.Types.OperationResult Iniciar()
		{
			Lfx.Types.OperationResult iniciarReturn = new Lfx.Types.SuccessOperationResult();

			Aplicacion.CUIT = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Empresa.CUIT", "");
			string Activacion = Lws.Workspace.Master.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Activacion", "");

			if (Activacion == CodigoActivacion(Aplicacion.CUIT))
				Config.Version = Versiones.Completa;

			Lfx.Types.Currency.CurrencySymbol = Lws.Workspace.Master.DefaultDataBase.FieldString("SELECT signo FROM monedas WHERE id_moneda=" + Lfx.Types.Currency.DefaultCurrency.ToString());

			return iniciarReturn;
		}

		public static void Terminar()
		{
			//Nada
		}

		private static string Dec2Any(long Number, short Base)
		{
			int digitValue = 0;
			System.Text.StringBuilder res = new System.Text.StringBuilder();

			const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			//  check base and value
			if (Number < 0)
			{
				throw new ArgumentException("The value to be converted must be positive");
			}
			else if (Base < 2 || Base > 36)
			{
				throw new ArgumentException("Base must be in range 2-36");
			}

			//  convert to the other base
			while (Number != 0)
			{
				digitValue = System.Convert.ToInt32(Number % Base);
				Number = Number / Base;
				//  append this digit in front of current result
				res.Insert(0, System.Convert.ToString(Digits[digitValue]));
			}

			return res.ToString();
		}


		public static string CodigoActivacion(string CUIT)
		{
			string ClaveCodificacion = "sesv1" + ".0psl" + "gcsv";
			string CodigoInstalacion = CUIT.Replace("-", "");
			System.Text.StringBuilder CodigoActivacionHex = new System.Text.StringBuilder();
			for (int i = 0; i <= CodigoInstalacion.Length - 1; i++)
			{
				int CodigoCar = System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(CodigoInstalacion[i]))[0];
				int CodigoNuevo = CodigoCar ^ System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(ClaveCodificacion[i]))[0];
				CodigoActivacionHex.Append(System.Convert.ToString(CodigoNuevo, 16).ToUpper().PadLeft(2, '0'));
			}
			string CodigoActivacionHexString = CodigoActivacionHex.ToString().PadRight(24, '0');
			string CodigoActivacionB36 = null;
			CodigoActivacionB36 = Dec2Any(long.Parse(CodigoActivacionHexString.Substring(0, 8), System.Globalization.NumberStyles.AllowHexSpecifier), 36).PadLeft(6, '0');
			CodigoActivacionB36 += "-" + Dec2Any(long.Parse(CodigoActivacionHexString.Substring(8, 8), System.Globalization.NumberStyles.AllowHexSpecifier), 36).PadLeft(6, '0');
			CodigoActivacionB36 += "-" + Dec2Any(long.Parse(CodigoActivacionHexString.Substring(16, 8), System.Globalization.NumberStyles.AllowHexSpecifier), 36).PadLeft(6, '0');
			return CodigoActivacionB36;
		}

	}
}