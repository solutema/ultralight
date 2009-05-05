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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Controles.Edicion.Comprobantes
{
        public partial class Cobro : Lui.Forms.Control
        {
                private Lbl.Comprobantes.Cobro m_Cobro = new Lbl.Comprobantes.Cobro(Lbl.Comprobantes.FormasDePago.Efectivo);

                public Cobro()
                {
                        InitializeComponent();
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DefaultValue(""),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lbl.Comprobantes.FormasDePago FormaDePago
                {
                        get
                        {
                                if (m_Cobro == null)
                                        return Lbl.Comprobantes.FormasDePago.Ninguna;
                                else
                                        return m_Cobro.FormaDePago;
                        }
                        set
                        {
                                if (m_Cobro == null)
                                        m_Cobro = new Lbl.Comprobantes.Cobro(value);
                                else
                                        m_Cobro.FormaDePago = value;
                                switch(value) {
                                        case Lbl.Comprobantes.FormasDePago.Efectivo:
                                                EntradaFormaDePago.TextKey = "1";
                                                break;
                                        case Lbl.Comprobantes.FormasDePago.Cheque:
                                                EntradaFormaDePago.TextKey = "2";
                                                break;
                                        case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                                EntradaFormaDePago.TextKey = "3";
                                                break;
                                        case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                        case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                                EntradaFormaDePago.TextKey = "4";
                                                break;
                                        case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                                EntradaFormaDePago.TextKey = "6";
                                                break;
                                }
                                

                                this.MostrarPaneles();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DefaultValue(""),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public double Importe
                {
                        get
                        {
                                return Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        }
                        set
                        {
                                EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(value, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
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

                public Lfx.Types.OperationResult ValidateData()
                {
                        if (Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text) <= 0)
                                return new Lfx.Types.FailureOperationResult("Debe especificar el importe correctamente.");

                        switch (this.FormaDePago) {
                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                        //Nada que verificar
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                        if (EntradaBanco.TextInt <= 0)
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar un banco.");
                                        if (EntradaFechaEmision.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar la fecha de emisión.");
                                        if (EntradaFechaCobro.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar la fecha de cobro. Si lo desea puede especificar la misma fecha que de emisión.");
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                        if (EntradaTarjeta.TextInt <= 0)
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar la tarjeta de crédito.");
                                        if (EntradaCupon.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar el número de cupón.");
                                        break;
                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                        if (EntradaCuenta.TextInt <= 0)
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar la cuenta bancaria.");
                                        break;
                                default:
                                        return new Lfx.Types.FailureOperationResult("Debe seleccionar un modo de pago válido.");
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                public virtual Lbl.Comprobantes.Cobro ToCobro(Lws.Data.DataView dataView)
                {
                        switch (m_Cobro.FormaDePago) {
                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                        m_Cobro.Cheque = new Lbl.Bancos.Cheque(dataView);
                                        m_Cobro.Cheque.Emisor = EntradaEmisor.Text;
                                        m_Cobro.Cheque.FechaCobro = Lfx.Types.Parsing.ParseDate(EntradaFechaCobro.Text);
                                        m_Cobro.Cheque.FechaEmision = Lfx.Types.Parsing.ParseDate(EntradaFechaEmision.Text);
                                        m_Cobro.Cheque.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                                        m_Cobro.Cheque.Numero = EntradaNumeroCheque.Text;
                                        if (EntradaBanco.TextInt > 0)
                                                m_Cobro.Cheque.Banco = new Lbl.Bancos.Banco(dataView, EntradaBanco.TextInt);
                                        else
                                                m_Cobro.Cheque.Banco = null;
                                        m_Cobro.Cheque.Obs = EntradaObs.Text;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                        if (EntradaCuenta.TextInt > 0)
                                                m_Cobro.CuentaDestino = new Lbl.Cuentas.CuentaRegular(dataView, EntradaCuenta.TextInt);
                                        else
                                                m_Cobro.CuentaDestino = null;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                        m_Cobro.Cupon = new Lbl.Tarjetas.Cupon(dataView);
                                        m_Cobro.Cupon.Numero = EntradaCupon.Text;
                                        m_Cobro.Cupon.Autorizacion = EntradaAutorizacion.Text;

                                        if (EntradaTarjeta.TextInt > 0)
                                                m_Cobro.Cupon.Tarjeta = new Lbl.Tarjetas.Tarjeta(dataView, EntradaTarjeta.TextInt);
                                        else
                                                m_Cobro.Cupon.Tarjeta = null;

                                        if (EntradaPlan.TextInt > 0)
                                                m_Cobro.Cupon.Plan = new Lbl.Tarjetas.Plan(dataView, EntradaPlan.TextInt);
                                        else
                                                m_Cobro.Cupon.Plan = null;

                                        m_Cobro.Cupon.Obs = EntradaObs.Text;
                                        break;
                        }
                        m_Cobro.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        m_Cobro.Obs = EntradaObs.Text;
                        return m_Cobro;
                }

                public void FromCobro(Lbl.Comprobantes.Cobro cobro)
                {
                        m_Cobro = cobro;

                        this.MostrarPaneles();

                        switch (m_Cobro.FormaDePago) {
                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                        if (m_Cobro.FormaDePago != Lbl.Comprobantes.FormasDePago.Cheque)
                                                throw new InvalidOperationException();

                                        if (m_Cobro.Cheque.Banco != null)
                                                EntradaBanco.TextInt = m_Cobro.Cheque.Banco.Id;
                                        else
                                                EntradaBanco.TextInt = 0;
                                        EntradaFechaCobro.Text = Lfx.Types.Formatting.FormatDate(m_Cobro.Cheque.FechaCobro);
                                        EntradaFechaEmision.Text = Lfx.Types.Formatting.FormatDate(m_Cobro.Cheque.FechaEmision);
                                        EntradaNumeroCheque.Text = m_Cobro.Cheque.Numero;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                        if (m_Cobro.CuentaDestino != null)
                                                EntradaCuenta.TextInt = m_Cobro.CuentaDestino.Id;
                                        else
                                                EntradaCuenta.TextInt = 0;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                        if (m_Cobro.Cupon != null) {
                                                if (m_Cobro.Cupon.Tarjeta != null)
                                                        EntradaTarjeta.TextInt = m_Cobro.Cupon.Tarjeta.Id;
                                                else
                                                        EntradaTarjeta.TextInt = 0;

                                                if (m_Cobro.Cupon.Plan != null)
                                                        EntradaPlan.TextInt = m_Cobro.Cupon.Plan.Id;
                                                else
                                                        EntradaPlan.TextInt = 0;

                                                EntradaCupon.Text = m_Cobro.Cupon.Numero;
                                                EntradaAutorizacion.Text = m_Cobro.Cupon.Autorizacion;
                                        }
                                        break;
                        }
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(m_Cobro.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaObs.Text = m_Cobro.Obs;
                }

                private void MostrarPaneles()
                {
                        PanelEfectivo.Visible = m_Cobro.FormaDePago == Lbl.Comprobantes.FormasDePago.Efectivo;
                        PanelCheque.Visible = m_Cobro.FormaDePago == Lbl.Comprobantes.FormasDePago.Cheque;
                        PanelCuenta.Visible = m_Cobro.FormaDePago == Lbl.Comprobantes.FormasDePago.CuentaRegular;
                        PanelTarjeta.Visible = (m_Cobro.FormaDePago == Lbl.Comprobantes.FormasDePago.Tarjeta) || (m_Cobro.FormaDePago == Lbl.Comprobantes.FormasDePago.TarjetaDeDebito);
                        PanelCuentaCorriente.Visible = m_Cobro.FormaDePago == Lbl.Comprobantes.FormasDePago.CuentaCorriente;
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
                                return !EntradaImporte.ReadOnly;
                        }
                        set
                        {
                                EntradaImporte.ReadOnly = !value;
                                EntradaImporte.TabStop = value;
                        }
                }

                public bool ObsEditable
                {
                        get
                        {
                                return !EntradaObs.ReadOnly;
                        }
                        set
                        {
                                EntradaObs.ReadOnly = !value;
                                EntradaObs.TabStop = value;
                        }
                }

                public bool FormaDePagoEditable
                {
                        get
                        {
                                return !EntradaFormaDePago.ReadOnly;
                        }
                        set
                        {
                                EntradaFormaDePago.ReadOnly = !value;
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
                                return base.Text;
                        }
                        set
                        {
                                base.Text = value;
                                FrameTitulo.Text = value;
                        }
                }

                private void EntradaTarjeta_TextChanged(object sender, EventArgs e)
                {
                        Lfx.Data.Row Tarjeta = this.Workspace.DefaultDataView.Tables["tarjetas"].FastRows[EntradaTarjeta.TextInt];
                        if (Tarjeta != null) {
                                EntradaPlan.Required = (System.Convert.ToInt32(Tarjeta.Fields["credeb"].Value) == 1);
                                EntradaPlan.Filter = "id_tarjeta=" + EntradaTarjeta.TextInt.ToString() + " OR id_tarjeta IS NULL";
                        } else {
                                EntradaPlan.Filter = null;
                        }
                }

                private void EntradaPlan_TextChanged(object sender, EventArgs e)
                {
                        Lfx.Data.Row Plan = this.Workspace.DefaultDataView.Tables["tarjetas_planes"].FastRows[EntradaPlan.TextInt];

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

                private void EntradaFormaDePago_Enter(object sender, EventArgs e)
                {
                        PanelFormaDePago.Height = 60;
                }

                private void EntradaFormaDePago_Leave(object sender, EventArgs e)
                {
                        PanelFormaDePago.Height = 32;
                }

                private void EntradaFormaDePago_TextChanged(object sender, EventArgs e)
                {
                        this.FormaDePago = ((Lbl.Comprobantes.FormasDePago)(Lfx.Types.Parsing.ParseInt(EntradaFormaDePago.TextKey)));
                }

                private void EntradaFormaDePago_KeyPress(object sender, KeyPressEventArgs e)
                {
                        switch(e.KeyChar){
                                case '1':
                                case '2':
                                case '3':
                                case '4':
                                case '6':
                                        this.EntradaFormaDePago.TextKey = e.KeyChar.ToString();
                                        break;
                                case '5':
                                        this.EntradaFormaDePago.TextKey = "4";
                                        break;
                        }
                }
        }
}