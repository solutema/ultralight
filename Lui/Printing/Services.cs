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
using System.Text;

namespace Lui.Printing
{
	public class Services
	{
		public static Lfx.Types.OperationResult ShowManualFeedDialog(string printerName, string documentName)
		{
                        Lui.Printing.ManualFeedDialog OFormFacturaCargaManual = new Lui.Printing.ManualFeedDialog();
			OFormFacturaCargaManual.DocumentName = documentName;

			// Muestro el nombre de la impresora
                        if (printerName != null && printerName.Length > 0) {
                                OFormFacturaCargaManual.PrinterName = printerName;
                        } else {
                                System.Drawing.Printing.PrinterSettings CurrentSettings = new System.Drawing.Printing.PrinterSettings();
                                OFormFacturaCargaManual.PrinterName = CurrentSettings.PrinterName;
                        }

			if (OFormFacturaCargaManual.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				return new Lfx.Types.FailureOperationResult("Operación cancelada");
			else
				return new Lfx.Types.SuccessOperationResult();
		}
	}
}