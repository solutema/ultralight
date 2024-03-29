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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Bancos.Chequeras
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Bancos.Chequera);

                        InitializeComponent();
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        int Desde = EntradaDesde.ValueInt;
                        int Hasta = EntradaHasta.ValueInt;

                        if ((Desde >= Hasta) || (Hasta <= 0) || (Hasta - Desde > 10000))
                                return new Lfx.Types.FailureOperationResult("Debe escribir la numeración de la chequera (desde y hasta)");

                        if(EntradaBanco.Elemento == null)
                                return new Lfx.Types.FailureOperationResult("Debe escribir el banco al que pertenece la chequera.");

                        return base.ValidarControl();
                }


                public override void ActualizarControl()
                {
                        Lbl.Bancos.Chequera Res = this.Elemento as Lbl.Bancos.Chequera;

                        EntradaBanco.Elemento = Res.Banco;
                        EntradaDesde.Text = Res.Desde.ToString();
                        EntradaHasta.Text = Res.Hasta.ToString();
                        EntradaCaja.Elemento = Res.Caja;
                        EntradaTitular.Text = Res.Titular;
                        EntradaEstado.TextKey = Res.Estado.ToString();
                        EntradaSucursal.Elemento = Res.Sucursal;

                        if (Res.Existe)
                                EntradaCaja.Filter = null;
                        else
                                EntradaCaja.Filter = "estado=1";

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Bancos.Chequera Res = this.Elemento as Lbl.Bancos.Chequera;

                        Res.Banco = EntradaBanco.Elemento as Lbl.Bancos.Banco;
                        Res.Caja = EntradaCaja.Elemento as Lbl.Cajas.Caja;
                        Res.Sucursal = EntradaSucursal.Elemento as Lbl.Entidades.Sucursal;
                        Res.Desde = Lfx.Types.Parsing.ParseInt(EntradaDesde.Text);
                        Res.Hasta = Lfx.Types.Parsing.ParseInt(EntradaHasta.Text);
                        Res.Titular = EntradaTitular.Text;
                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);

                        base.ActualizarElemento();
                }
        }
}
