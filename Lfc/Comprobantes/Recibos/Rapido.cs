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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
	public partial class Rapido : Lui.Forms.DialogForm
	{
		public Rapido()
		{
			InitializeComponent();
		}

		public override Lfx.Types.OperationResult Ok()
		{
			if(txtCuenta.TextInt <= 0)
				return new Lfx.Types.FailureOperationResult("Debe especificar la cuenta de destino");

			if(Lfx.Types.Parsing.ParseCurrency(txtImporte.Text) <= 0)
				return new Lfx.Types.FailureOperationResult("Debe especificar el importe");

			this.DataView.BeginTransaction();

			Lbl.Personas.Persona Cliente = new Lbl.Personas.Persona(DataView, txtCliente.TextInt);
			Lbl.Comprobantes.ReciboDeCobro Rec = new Lbl.Comprobantes.ReciboDeCobro(DataView, Cliente);
			Rec.Crear();
			Rec.Cobros.Add(new Lbl.Comprobantes.Cobro(DataView, Lbl.Comprobantes.FormasDePago.CuentaRegular, Lfx.Types.Parsing.ParseCurrency(txtImporte.Text)));
			Rec.Cobros[0].CuentaDestino = new Lbl.Cuentas.CuentaRegular(DataView, txtCuenta.TextInt);
			Rec.Vendedor = new Lbl.Personas.Persona(DataView, this.Workspace.CurrentUser.Id);
			Lfx.Types.OperationResult Res = Rec.Guardar();
                        if (Res.Success) {
                                this.DataView.Commit();
                                string Nombrecliente = txtCliente.TextDetail;
                                txtCliente.TextInt = 0;
                                txtCliente.Focus();
                                return new Lfx.Types.FailureOperationResult("Se creo el recibo para el cliente " + Nombrecliente);
                        } else {
                                this.DataView.RollBack();
                                return Res;
                        }
        	}

		private void txtCliente_TextChanged(object sender, EventArgs e)
		{
			if(txtCliente.TextInt > 0)
                                txtImporte.Text = Lfx.Types.Formatting.FormatCurrency(new Lbl.Cuentas.CuentaCorriente(this.Workspace.DefaultDataView, txtCliente.TextInt).Saldo(), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
			else
				txtImporte.Text = "0";
		}
	}
}