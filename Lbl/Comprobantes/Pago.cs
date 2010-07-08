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
using System.Collections.Generic;
using System.Text;

namespace Lbl.Comprobantes
{
        public class Pago : ElementoDeDatos
        {
                public Lbl.Comprobantes.FormaDePago FormaDePago;
                private double m_Importe = 0;
                public Cajas.Caja CajaOrigen;
                public Bancos.Cheque Cheque;
                public Cajas.Concepto Concepto;
                public Pagos.Valor Valor;
                public string ConceptoTexto;
                public Comprobantes.Recibo Recibo;

                //Heredar constructor
                public Pago(Lfx.Data.DataBase dataBase) : base(dataBase) { }

                public Pago(Lfx.Data.DataBase dataBase, Lbl.Comprobantes.FormaDePago formaDePago)
                        : this(dataBase)
                {
                        this.FormaDePago = formaDePago;
                }

                public Pago(Lfx.Data.DataBase dataBase, Lbl.Comprobantes.TipoFormasDePago tipoFormaDePago)
                        : this(dataBase)
                {
                        FormaDePago = new FormaDePago(dataBase, tipoFormaDePago);
                        FormaDePago.Cargar();
                }

                public Pago(Lfx.Data.DataBase dataBase, Lbl.Comprobantes.TipoFormasDePago formaDePago, double importe)
                        : this(dataBase, formaDePago)
                {
                        this.Importe = importe;
                }

                public Pago(Bancos.Cheque cheque)
                        : this(cheque.DataBase, cheque.Emitido ? TipoFormasDePago.ChequePropio : TipoFormasDePago.ChequeTerceros)
                {
                        this.Cheque = cheque;
                }

                public Pago(Pagos.Valor valor)
                        : this(valor.DataBase, valor.FormaDePago.Tipo)
                {
                        this.Valor = valor;
                }

                public double Importe
                {
                        get
                        {
                                switch (FormaDePago.Tipo) {
                                        case TipoFormasDePago.ChequePropio:
                                        case TipoFormasDePago.ChequeTerceros:
                                                if (Cheque == null)
                                                        return 0;
                                                else
                                                        return Cheque.Importe;
                                        case TipoFormasDePago.OtroValor:
                                                if (Valor == null)
                                                        return 0;
                                                else
                                                        return Valor.Importe;
                                        default:
                                                return this.m_Importe;
                                }
                        }
                        set
                        {
                                switch (FormaDePago.Tipo) {
                                        case TipoFormasDePago.ChequePropio:
                                        case TipoFormasDePago.ChequeTerceros:
                                                Cheque.Importe = value;
                                                break;
                                        case TipoFormasDePago.OtroValor:
                                                Valor.Importe = value;
                                                break;
                                        default:
                                                this.m_Importe = value;
                                                break;
                                }
                        }
                }

                public void Anular()
                {
                        string DescripConcepto = "Anulación";
                        if (Recibo != null)
                                DescripConcepto = "Anulación " + Recibo.ToString();

                        Personas.Persona Cliente = null;
                        Comprobantes.ComprobanteConArticulos Factura = null;
                        if (this.Recibo != null) {
                                if (Recibo.Cliente != null)
                                        Cliente = Recibo.Cliente;
                                if (Recibo.Facturas != null && Recibo.Facturas.Count > 0)
                                        Factura = Recibo.Facturas[0];
                        }

                        switch (this.FormaDePago.Tipo) {
                                case TipoFormasDePago.Efectivo:
                                        Lbl.Cajas.Caja Caja = new Lbl.Cajas.Caja(DataBase, this.Workspace.CurrentConfig.Company.CajaDiaria);
                                        Caja.Movimiento(true, this.Concepto, DescripConcepto, Cliente, this.Importe, null, Factura, this.Recibo, null);
                                        break;
                                case TipoFormasDePago.ChequePropio:
                                        if (this.Cheque != null)
                                                this.Cheque.Anular();
                                        break;
                                case TipoFormasDePago.OtroValor:
                                        if (this.Valor != null)
                                                this.Valor.Anular();
                                        break;
                                case TipoFormasDePago.Caja:
                                        this.CajaOrigen.Movimiento(true, this.Concepto, DescripConcepto, Cliente, this.Importe, null, Factura, this.Recibo, null);
                                        break;
                        }
                }

                public override string ToString()
                {
                        switch (FormaDePago.Tipo) {
                                case TipoFormasDePago.Efectivo:
                                        return "Efectivo";
                                case TipoFormasDePago.CuentaCorriente:
                                        return "Cuenta Corriente";
                                case TipoFormasDePago.ChequePropio:
                                case TipoFormasDePago.ChequeTerceros:
                                        if (Cheque == null)
                                                return "Cheque";
                                        else
                                                return Cheque.ToString();
                                case TipoFormasDePago.Caja:
                                        if (CajaOrigen == null)
                                                return "Débito de cuenta";
                                        else
                                                return "Débito de " + CajaOrigen.ToString();
                                case TipoFormasDePago.OtroValor:
                                        if (Valor == null)
                                                return FormaDePago.ToString();
                                        else
                                                return Valor.ToString();
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
