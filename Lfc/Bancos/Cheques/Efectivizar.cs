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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
        public partial class Efectivizar : Lui.Forms.DialogForm
	{
		internal string ListaCheques = "";
		internal string ListaChequesId = "";

                public Efectivizar()
                {
                        InitializeComponent();
                }

		private void txtImportes_TextChanged(object sender, System.EventArgs e)
		{
			txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) - Lfx.Types.Parsing.ParseCurrency(txtGestionDeCobro.Text) - Lfx.Types.Parsing.ParseCurrency(txtImpuestos.Text), this.Workspace.CurrentConfig.Moneda.Decimales);
		}


		public override Lfx.Types.OperationResult Ok()
		{
			Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();
			if (EntradaCajaDestino.TextInt <= 0)
			{
				aceptarReturn.Success = false;
				aceptarReturn.Message += "Debe especificar la cuenta de destino." + Environment.NewLine;
			}
			if (Lfx.Types.Parsing.ParseCurrency(txtTotal.Text) <= 0)
			{
				aceptarReturn.Success = false;
				aceptarReturn.Message += "El importe total debe ser mayor o igual a cero." + Environment.NewLine;
			}
			if (aceptarReturn.Success == true)
			{
				double ImporteOrigen = Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text);
				double ImporteDestino = Lfx.Types.Parsing.ParseCurrency(txtTotal.Text);
				double GestionDeCobro = Lfx.Types.Parsing.ParseCurrency(txtGestionDeCobro.Text);
				double Impuestos = Lfx.Types.Parsing.ParseCurrency(txtImpuestos.Text);

				DataBase.BeginTransaction(true);

				Lbl.Cajas.Caja CajaCheques = new Lbl.Cajas.Caja(DataBase, this.Workspace.CurrentConfig.Empresa.CajaCheques);
				CajaCheques.Movimiento(true, 30000, "Efectivización de Cheques", 0, -ImporteOrigen, "Cheques Nº " + ListaCheques, 0, 0, "");

				Lbl.Cajas.Caja CajaDestino = new Lbl.Cajas.Caja(DataBase, EntradaCajaDestino.TextInt);
				CajaDestino.Movimiento(true, 30000, "Efectivización de Cheques", 0, ImporteDestino, "Cheques Nº " + ListaCheques, 0, 0, "");

				if (GestionDeCobro != 0)
					CajaDestino.Movimiento(true, 24010, "Gestion de Cobro Cheques", 0, -GestionDeCobro, "Cheques Nº " + ListaCheques, 0, 0, "");
				if (Impuestos != 0)
					CajaDestino.Movimiento(true, 23030, "Impuestos Cheques", 0, -Impuestos, "Cheques Nº " + ListaCheques, 0, 0, "");

				string sCheque = Lfx.Types.Strings.GetNextToken(ref ListaChequesId, ",");
				do
				{
					DataBase.Execute("UPDATE bancos_cheques SET estado=10 WHERE id_cheque=" + Lfx.Types.Parsing.ParseInt(sCheque).ToString());
					sCheque = Lfx.Types.Strings.GetNextToken(ref ListaChequesId, ",");
				}
				while (sCheque.Length > 0);
				DataBase.Commit();
			}
			return aceptarReturn;
		}

	}
}