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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion.Comprobantes
{
        public partial class Cobro : ControlEdicion
        {
                public Cobro()
                {
                        InitializeComponent();
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DefaultValue(""),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lbl.Pagos.FormaDePago FormaDePago
                {
                        get
                        {
                                if (this.ElementoCobro == null)
                                        return null;
                                else
                                        return this.ElementoCobro.FormaDePago;
                        }
                        set
                        {
                                if (value == null) {
                                        this.ElementoCobro = null;
                                } else {
                                        if (this.ElementoCobro == null)
                                                this.ElementoCobro = new Lbl.Comprobantes.Cobro(this.Connection, value);
                                        else
                                                this.ElementoCobro.FormaDePago = value;
                                        if (EntradaFormaDePago.TextInt != value.Id)
                                                EntradaFormaDePago.TextInt = value.Id;
                                }
                                this.MostrarPaneles();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DefaultValue(""),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public decimal Importe
                {
                        get
                        {
                                return Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        }
                        set
                        {
                                EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(value, this.Workspace.CurrentConfig.Moneda.Decimales);
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DefaultValue(""),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public string Obs
                {
                        get
                        {
                                return EntradaObs.Text;
                        }
                        set
                        {
                                EntradaObs.Text = value;
                        }
                }

                private Lbl.Comprobantes.Cobro ElementoCobro
                {
                        get
                        {
                                return this.Elemento as Lbl.Comprobantes.Cobro;
                        }
                        set
                        {
                                this.Elemento = value;
                        }
                }

                public Lfx.Types.OperationResult ValidateData()
                {
                        if (Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text) <= 0)
                                return new Lfx.Types.FailureOperationResult("Debe especificar el importe correctamente.");

                        if (this.FormaDePago == null || this.FormaDePago.Existe == false)
                                return new Lfx.Types.FailureOperationResult("Debe seleccionar la forma de pago.");

                        switch (this.FormaDePago.Tipo) {
                                case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                case Lbl.Pagos.TiposFormasDePago.CuentaCorriente:
                                        //Nada que verificar
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                        if (EntradaBanco.TextInt <= 0)
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar un banco.");
                                        if (EntradaFechaEmision.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar la fecha de emisión.");
                                        if (EntradaFechaCobro.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar la fecha de cobro. Si lo desea puede especificar la misma fecha que de emisión.");
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                        if (EntradaCupon.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar el número de cupón.");
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.Caja:
                                        if (EntradaCaja.TextInt <= 0)
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar la cuenta bancaria.");
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.OtroValor:
                                        if (EntradaValorNumero.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar el número de " + this.FormaDePago.ToString() + ".");
                                        break;
                                default:
                                        return new Lfx.Types.FailureOperationResult("Debe seleccionar un modo de pago válido.");
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                public virtual Lbl.Comprobantes.Cobro ToCobro(Lfx.Data.Connection dataBase)
                {
                        switch (this.ElementoCobro.FormaDePago.Tipo) {
                                case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                case Lbl.Pagos.TiposFormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                        this.ElementoCobro.Cheque = new Lbl.Bancos.Cheque(dataBase);
                                        this.ElementoCobro.Cheque.Emisor = EntradaEmisor.Text;
                                        this.ElementoCobro.Cheque.FechaCobro = Lfx.Types.Parsing.ParseDate(EntradaFechaCobro.Text);
                                        this.ElementoCobro.Cheque.FechaEmision = Lfx.Types.Parsing.ParseDate(EntradaFechaEmision.Text);
                                        this.ElementoCobro.Cheque.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                                        this.ElementoCobro.Cheque.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text);
                                        if (EntradaBanco.TextInt > 0)
                                                this.ElementoCobro.Cheque.Banco = new Lbl.Bancos.Banco(dataBase, EntradaBanco.TextInt);
                                        else
                                                this.ElementoCobro.Cheque.Banco = null;
                                        this.ElementoCobro.Cheque.Obs = EntradaObs.Text;
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.Caja:
                                        if (EntradaCaja.TextInt > 0)
                                                this.ElementoCobro.CajaDestino = new Lbl.Cajas.Caja(dataBase, EntradaCaja.TextInt);
                                        else
                                                this.ElementoCobro.CajaDestino = null;
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                        this.ElementoCobro.Cupon = new Lbl.Pagos.Cupon(dataBase);
                                        this.ElementoCobro.Cupon.Numero = EntradaCupon.Text;
                                        this.ElementoCobro.Cupon.FormaDePago = new Lbl.Pagos.FormaDePago(dataBase, this.FormaDePago.Id);

                                        if (EntradaPlan.TextInt > 0)
                                                this.ElementoCobro.Cupon.Plan = new Lbl.Pagos.Plan(dataBase, EntradaPlan.TextInt);
                                        else
                                                this.ElementoCobro.Cupon.Plan = null;

                                        this.ElementoCobro.Cupon.Obs = EntradaObs.Text;
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.OtroValor:
                                        this.ElementoCobro.Valor = new Lbl.Pagos.Valor(dataBase);
                                        this.ElementoCobro.FormaDePago = this.FormaDePago;
                                        this.ElementoCobro.Valor.FormaDePago = this.FormaDePago;
                                        this.ElementoCobro.Valor.Numero = EntradaValorNumero.Text;
                                        this.ElementoCobro.Valor.Obs = EntradaObs.Text;
                                        break;
                        }
                        this.ElementoCobro.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        this.ElementoCobro.Obs = EntradaObs.Text;
                        return this.ElementoCobro;
                }

                public void FromCobro(Lbl.Comprobantes.Cobro cobro)
                {
                        this.ElementoCobro = cobro;
                        if (cobro.FormaDePago != null)
                                this.EntradaFormaDePago.TextInt = cobro.FormaDePago.Id;

                        this.MostrarPaneles();

                        switch (this.ElementoCobro.FormaDePago.Tipo) {
                                case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                case Lbl.Pagos.TiposFormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                        if (this.ElementoCobro.FormaDePago.Tipo != Lbl.Pagos.TiposFormasDePago.ChequeTerceros)
                                                throw new InvalidOperationException();

                                        if (this.ElementoCobro.Cheque != null) {
                                                if (this.ElementoCobro.Cheque.Banco != null)
                                                        EntradaBanco.TextInt = this.ElementoCobro.Cheque.Banco.Id;
                                                else
                                                        EntradaBanco.TextInt = 0;
                                                EntradaFechaCobro.Text = Lfx.Types.Formatting.FormatDate(this.ElementoCobro.Cheque.FechaCobro);
                                                EntradaFechaEmision.Text = Lfx.Types.Formatting.FormatDate(this.ElementoCobro.Cheque.FechaEmision);
                                                EntradaNumeroCheque.Text = this.ElementoCobro.Cheque.Numero.ToString();
                                        }
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.Caja:
                                        if (this.ElementoCobro.CajaDestino != null)
                                                EntradaCaja.TextInt = this.ElementoCobro.CajaDestino.Id;
                                        else
                                                EntradaCaja.TextInt = 0;
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                        if (this.ElementoCobro.Cupon != null) {
                                                if (this.ElementoCobro.Cupon.Plan != null)
                                                        EntradaPlan.TextInt = this.ElementoCobro.Cupon.Plan.Id;
                                                else
                                                        EntradaPlan.TextInt = 0;

                                                EntradaCupon.Text = this.ElementoCobro.Cupon.Numero;
                                        }
                                        break;
                                case Lbl.Pagos.TiposFormasDePago.OtroValor:
                                        if (this.ElementoCobro.Valor != null) {
                                                EntradaValorNumero.Text = this.ElementoCobro.Valor.Numero;
                                        }
                                        break;
                        }
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(this.ElementoCobro.Importe, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaObs.Text = this.ElementoCobro.Obs;
                }

                private void MostrarPaneles()
                {
                        if (this.ElementoCobro == null || this.ElementoCobro.FormaDePago == null) {
                                PanelEfectivo.Visible = false;
                                PanelChequeTerceros.Visible = false;
                                PanelCaja.Visible = false;
                                PanelTarjeta.Visible = false;
                                PanelCuentaCorriente.Visible = false;
                                PanelValor.Visible = false;
                        } else {
                                PanelEfectivo.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.Efectivo;
                                PanelChequeTerceros.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.ChequeTerceros;
                                PanelCaja.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.Caja;
                                PanelTarjeta.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.Tarjeta;
                                PanelCuentaCorriente.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente;
                                PanelValor.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.OtroValor;


                                if (this.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.Caja) {
                                        if (this.FormaDePago.Caja == null) {
                                                EntradaCaja.Enabled = true;
                                        } else {
                                                EntradaCaja.Enabled = false;
                                                EntradaCaja.TextInt = this.FormaDePago.Caja.Id;
                                        }
                                }
                        }

                        this.Height = PanelSeparadorInferior.Bottom + 1;
                }

                public bool ImporteVisible
                {
                        get
                        {
                                return PanelImporte.Visible;
                        }
                        set
                        {
                                PanelImporte.Visible = value;
                        }
                }

                public bool FormaDePagoVisible
                {
                        get
                        {
                                return PanelFormaDePago.Visible;
                        }
                        set
                        {
                                PanelFormaDePago.Visible = value;
                        }
                }

                public bool ObsVisible
                {
                        get
                        {
                                return PanelObs.Visible;
                        }
                        set
                        {
                                PanelObs.Visible = value;
                        }
                }

                public bool ImporteEditable
                {
                        get
                        {
                                return !EntradaImporte.TemporaryReadOnly;
                        }
                        set
                        {
                                EntradaImporte.TemporaryReadOnly = !value;
                                EntradaImporte.TabStop = value;
                        }
                }

                public bool ObsEditable
                {
                        get
                        {
                                return !EntradaObs.TemporaryReadOnly;
                        }
                        set
                        {
                                EntradaObs.TemporaryReadOnly = !value;
                                EntradaObs.TabStop = value;
                        }
                }

                public bool FormaDePagoEditable
                {
                        get
                        {
                                return !EntradaFormaDePago.TemporaryReadOnly;
                        }
                        set
                        {
                                EntradaFormaDePago.TemporaryReadOnly = !value;
                                EntradaFormaDePago.TabStop = value;
                        }
                }

                public bool TituloVisible
                {
                        get
                        {
                                return PanelTitulo.Visible;
                        }
                        set
                        {
                                PanelTitulo.Visible = value;
                        }
                }

                public override string Text
                {
                        get
                        {
                                return FrameTitulo.Text;
                        }
                        set
                        {
                                FrameTitulo.Text = value;
                        }
                }

                private void EntradaPlan_TextChanged(object sender, EventArgs e)
                {
                        Lfx.Data.Row Plan = this.Connection.Tables["tarjetas_planes"].FastRows[EntradaPlan.TextInt];

                        if (Plan != null) {
                                EntradaCuotas.Text = Plan["cuotas"].ToString();
                                EntradaInteres.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Plan["interes"]));
                        } else {
                                EntradaCuotas.Text = "";
                                EntradaInteres.Text = "";
                        }
                }

                private void EntradaFechaCobro_Enter(object sender, EventArgs e)
                {
                        if (EntradaFechaCobro.Text.Length == 0) {
                                EntradaFechaCobro.Text = EntradaFechaEmision.Text;
                                EntradaFechaCobro.SelectionStart = 0;
                                EntradaFechaCobro.SelectionLength = EntradaFechaCobro.Text.Length;
                        }
                }

                private void FormaDePago_SizeChanged(object sender, EventArgs e)
                {
                        AyudaFormaDePago.Top = EntradaFormaDePago.Height + 2;
                        PanelFormaDePago.Height = EntradaFormaDePago.Height + (AyudaFormaDePago.Visible ? AyudaFormaDePago.Height : 0) + 4;
                }

                private void EntradaFormaDePago_TextChanged(object sender, EventArgs e)
                {
                        if (this.FormaDePago == null || this.FormaDePago.Id != EntradaFormaDePago.TextInt)
                                this.FormaDePago = EntradaFormaDePago.Elemento as Lbl.Pagos.FormaDePago;
                }
        }
}