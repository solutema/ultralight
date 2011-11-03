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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cajas
{
	public partial class Editar : Lcc.Edicion.ControlEdicion
	{
		private bool CustomName;

                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Cajas.Caja);

                        InitializeComponent();
                }

		public override Lfx.Types.OperationResult ValidarControl()
		{
			Lfx.Types.OperationResult validarReturn = new Lfx.Types.SuccessOperationResult();

			if (EntradaMoneda.TextInt == 0)
			{
				validarReturn.Success = false;
				validarReturn.Message += "Seleccione la Currency." + Environment.NewLine;
			}
			if (EntradaNombre.Text.Length < 2)
			{
				validarReturn.Success = false;
				validarReturn.Message += "Seleccione el Nombre de la cuenta." + Environment.NewLine;
			}
                        if (EntradaCbu.Text.Length > 0 && Lfx.Types.Strings.EsCbuValida(EntradaCbu.Text) == false) {
                                validarReturn.Success = false;
                                validarReturn.Message += "La CBU es incorrecta." + Environment.NewLine;
                        }

			return validarReturn;
		}


                public override void ActualizarControl()
                {
                        Lbl.Cajas.Caja Caja = this.Elemento as Lbl.Cajas.Caja;

                        EntradaTitular.Text = Caja.Titular;
                        EntradaTipo.TextKey = ((int)(Caja.Tipo)).ToString();
                        EntradaNumero.Text = Caja.Numero;
                        EntradaBanco.Elemento = Caja.Banco;
                        EntradaMoneda.Elemento = Caja.Moneda;
                        EntradaNombre.Text = Caja.Nombre;
                        EntradaCbu.Text = Caja.Cbu;
                        EntradaEstado.TextKey = Caja.Estado.ToString();

                        base.ActualizarControl();
                }


                public override void ActualizarElemento()
                {
                        Lbl.Cajas.Caja Caja = this.Elemento as Lbl.Cajas.Caja;

                        Caja.Nombre = EntradaNombre.Text;
                        Caja.Numero = EntradaNumero.Text;
                        Caja.Titular = EntradaTitular.Text;
                        Caja.Banco = EntradaBanco.Elemento as Lbl.Bancos.Banco;
                        Caja.Moneda = EntradaMoneda.Elemento as Lbl.Entidades.Moneda;
                        Caja.Tipo = (Lbl.Cajas.TiposDeCaja)(Lfx.Types.Parsing.ParseInt(EntradaTipo.TextKey));
                        Caja.Cbu = EntradaCbu.Text;
                        Caja.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);

                        base.ActualizarElemento();
                }


		private void EntradaNombre_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			CustomName = true;
		}


		private void NumeroBanco_TextChanged(object sender, System.EventArgs e)
		{
			if (CustomName == false)
			{
				EntradaNombre.Text = EntradaNumero.Text;
				if (EntradaBanco.TextDetail.Length > 0)
				{
					if (EntradaNumero.Text.Length > 0)
						EntradaNombre.Text += " de ";

					EntradaNombre.Text += EntradaBanco.TextDetail;
				}
			}
		}


		private void EntradaTipo_TextChanged(object sender, System.EventArgs e)
		{
			EntradaBanco.Enabled = Lfx.Types.Parsing.ParseInt(EntradaTipo.TextKey) > 0;
			EntradaNumero.Enabled = Lfx.Types.Parsing.ParseInt(EntradaTipo.TextKey) > 0;
		}
	}
}