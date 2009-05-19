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
        public class Pago
        {
                public FormasDePago FormaDePago;
                private double m_Importe = 0;
                public Cuentas.CuentaRegular CuentaOrigen;
                public Bancos.Cheque Cheque;
                public Cuentas.Concepto Concepto;
                public string Obs, ConceptoTexto;

                public Pago()
                {
                }

                public Pago(FormasDePago formaDePago)
                        : this()
                {
                        this.FormaDePago = formaDePago;
                }

                public Pago(FormasDePago formaDePago, double importe)
                        : this(formaDePago)
                {
                        this.Importe = importe;
                }

                public Pago(Bancos.Cheque cheque)
                        : this(FormasDePago.Cheque)
                {
                        this.Cheque = cheque;
                }

                public double Importe
                {
                        get
                        {
                                switch (FormaDePago) {
                                        case FormasDePago.Cheque:
                                                return Cheque.Importe;
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
                                        if (CuentaOrigen == null)
                                                return "Débito de cuenta";
                                        else
                                                return "Débito de " + CuentaOrigen.ToString();
                                default:
                                        return "No especificado";
                        }
                }
        }

        public class ColeccionDePagos : System.Collections.CollectionBase
        {
                public void Add(Pago pago)
                {
                        List.Add(pago);
                }

                public virtual Pago this[int index]
                {
                        get
                        {
                                return (Pago)this.List[index];
                        }
                }

                public double ImporteTotal()
                {
                        double Res = 0;
                        foreach (Lbl.Comprobantes.Pago Pg in this.List) {
                                Res += Pg.Importe;
                        }
                        return Res;
                }
        }
}
