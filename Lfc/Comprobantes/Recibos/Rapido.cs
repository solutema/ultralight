#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
			if(EntradaCaja.TextInt <= 0)
				return new Lfx.Types.FailureOperationResult("Debe especificar la Caja de destino");

			if(Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text) <= 0)
				return new Lfx.Types.FailureOperationResult("Debe especificar el importe");

			this.Connection.BeginTransaction(true);

			Lbl.Personas.Persona Cliente = new Lbl.Personas.Persona(Connection, EntradaCliente.TextInt);
			Lbl.Comprobantes.ReciboDeCobro Rec = new Lbl.Comprobantes.ReciboDeCobro(this.Connection);
			Rec.Crear();
                        Rec.Cliente = Cliente;
			Rec.Cobros.Add(new Lbl.Comprobantes.Cobro(Connection, Lbl.Pagos.TiposFormasDePago.Caja, Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text)));
			Rec.Cobros[0].CajaDestino = new Lbl.Cajas.Caja(Connection, EntradaCaja.TextInt);
                        Rec.Vendedor = Lbl.Sys.Config.Actual.UsuarioConectado.Persona;
			Lfx.Types.OperationResult Res = Rec.Guardar();

                        if (Res.Success) {
                                this.Connection.Commit();

                                if (Rec.Tipo.ImprimirAlGuardar) {
                                        Lazaro.Impresion.Comprobantes.ImpresorRecibo Impresor = new Lazaro.Impresion.Comprobantes.ImpresorRecibo(Rec);
                                        Rec.Connection.BeginTransaction();
                                        Lfx.Types.OperationResult ResImprimir = Impresor.Imprimir();
                                        if (ResImprimir.Success) {
                                                Rec.Connection.Commit();
                                        } else {
                                                Rec.Connection.RollBack();
                                                if (ResImprimir.Message != null)
                                                        Lui.Forms.MessageBox.Show(ResImprimir.Message, "Error");
                                                else
                                                        Lui.Forms.MessageBox.Show("Se creó el recibo, pero no se imprimió correctamente.", "Error");
                                        }
                                }

                                string Nombrecliente = EntradaCliente.TextDetail;
                                EntradaCliente.TextInt = 0;
                                EntradaCliente.Focus();
                                return new Lfx.Types.FailureOperationResult("Se creo el recibo para el cliente " + Nombrecliente);
                        } else {
                                this.Connection.RollBack();
                                return Res;
                        }
        	}

		private void EntradaCliente_TextChanged(object sender, EventArgs e)
		{
                        if (EntradaCliente.TextInt > 0) {
                                Lbl.Personas.Persona Pers = EntradaCliente.Elemento as Lbl.Personas.Persona;
                                EntradaImporte.ValueDecimal = Pers.CuentaCorriente.Saldo(false);
                        } else {
                                EntradaImporte.ValueDecimal = 0;
                        }
		}
	}
}