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

namespace Lbl.Comprobantes
{
        public class Cobro : ElementoDeDatos
        {
                public FormasDePago FormaDePago;
                private double m_Importe = 0;
                public Cuentas.CuentaRegular CuentaDestino;
                public Tarjetas.Cupon Cupon;
                public Bancos.Cheque Cheque;
                public Cuentas.Concepto Concepto;
                public string ConceptoTexto;

                //Heredar constructor
                public Cobro(Lws.Data.DataView dataView) : base(dataView) { }

                public Cobro(Lws.Data.DataView dataView, FormasDePago formaDePago)
                        : this(dataView)
                {
                        this.FormaDePago = formaDePago;
                }

                public Cobro(Lws.Data.DataView dataView, FormasDePago formaDePago, double importe)
                        : this(dataView, formaDePago)
                {
                        this.Importe = importe;
                }

                public Cobro(Bancos.Cheque cheque)
                        : this(cheque.DataView, FormasDePago.Cheque)
                {
                        this.Cheque = cheque;
                }

                public Cobro(Tarjetas.Cupon cupon)
                        : this(cupon.DataView, FormasDePago.Tarjeta)
                {
                        this.Cupon = cupon;
                }

                public double Importe
                {
                        get
                        {
                                switch (FormaDePago) {
                                        case FormasDePago.Cheque:
                                                if (Cheque == null)
                                                        return 0;
                                                else
                                                        return Cheque.Importe;
                                        case FormasDePago.Tarjeta:
                                        case FormasDePago.TarjetaDeDebito:
                                                if (Cupon == null)
                                                        return 0;
                                                else
                                                        return Cupon.Importe;
                                        default:
                                                return this.m_Importe;
                                }
                        }
                        set
                        {
                                switch (FormaDePago) {
                                        case FormasDePago.Cheque:
                                                Cheque.Importe = value;
                                                break;
                                        case FormasDePago.Tarjeta:
                                        case FormasDePago.TarjetaDeDebito:
                                                Cupon.Importe = value;
                                                break;
                                        default:
                                                this.m_Importe = value;
                                                break;
                                }
                        }
                }

                public override string ToString()
                {
                        switch (FormaDePago) {
                                case FormasDePago.Efectivo:
                                        return "Efectivo";
                                case FormasDePago.CuentaCorriente:
                                        return "Cuenta Corriente";
                                case FormasDePago.Cheque:
                                        if (Cheque == null)
                                                return "Cheque";
                                        else
                                                return Cheque.ToString();
                                case FormasDePago.CuentaRegular:
                                        if (CuentaDestino == null)
                                                return "Acreditación en cuenta";
                                        else
                                                return "Acreditación en " + CuentaDestino.ToString();
                                case FormasDePago.Tarjeta:
                                case FormasDePago.TarjetaDeDebito:
                                        return Cupon.ToString();
                                default:
                                        return "No especificado";
                        }
                }
        }

        public class ColeccionDeCobros : System.Collections.CollectionBase
        {
                public void Add(Cobro pago)
                {
                        List.Add(pago);
                }

                public new void RemoveAt(int index)
                {
                        if ((index > (Count - 1)) || (index < 0))
                                throw new Exception("Índice fuera de rango en " + this.GetType().ToString());
                        List.RemoveAt(index);
                }

                public virtual Cobro this[int index]
                {
                        get
                        {
                                return (Cobro)this.List[index];
                        }
                }

                public double ImporteTotal()
                {
                        double Res = 0;
                        foreach (Lbl.Comprobantes.Cobro Pg in this.List) {
                                Res += Pg.Importe;
                        }
                        return Res;
                }
        }
}