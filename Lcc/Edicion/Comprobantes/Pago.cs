using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion.Comprobantes
{
        public partial class Pago : ControlEdicion
        {
                private Lbl.Comprobantes.Pago m_Pago = new Lbl.Comprobantes.Pago(Lbl.Comprobantes.FormasDePago.Efectivo);

                public Pago()
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
                                if (m_Pago == null)
                                        return Lbl.Comprobantes.FormasDePago.Ninguna;
                                else
                                        return m_Pago.FormaDePago;
                        }
                        set
                        {
                                if (m_Pago == null)
                                        m_Pago = new Lbl.Comprobantes.Pago(value);
                                else
                                        m_Pago.FormaDePago = value;
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
                                        if (EntradaBanco.TextInt <= 0) {
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar un banco.");
                                        }  else {
                                                int Numero = Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text);
                                                int IdChequera = this.Workspace.DefaultDataBase.FieldInt("SELECT id_chequera FROM chequeras WHERE estado=1 AND id_banco=" + EntradaBanco.TextInt.ToString() + " AND " + Numero.ToString() + " BETWEEN desde AND hasta AND (id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + " OR id_sucursal IS NULL)");
                                                if (IdChequera == 0)
                                                        return new Lfx.Types.FailureOperationResult("El Número de cheque no corresponde a ninguna Chequera del banco seleccionado.");
                                                
                                                int IdChequePrevio = this.Workspace.DefaultDataBase.FieldInt("SELECT id_cheque FROM bancos_cheques WHERE estado<>90 AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text).ToString() + " AND (id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + " OR id_sucursal IS NULL)");
                                                if (IdChequePrevio != 0)
                                                        return new Lfx.Types.FailureOperationResult("El Número corresponde a un cheque que ya fue emitido.");

                                        }
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

                public virtual Lbl.Comprobantes.Pago ToPago(Lws.Data.DataView dataView)
                {
                        switch (m_Pago.FormaDePago) {
                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Cheque:

                                        m_Pago.Cheque = new Lbl.Bancos.Cheque(dataView);
                                        m_Pago.Cheque.Emitido = true;
                                        m_Pago.Cheque.FechaCobro = Lfx.Types.Parsing.ParseDate(EntradaFechaCobro.Text);
                                        m_Pago.Cheque.FechaEmision = Lfx.Types.Parsing.ParseDate(EntradaFechaEmision.Text);
                                        m_Pago.Cheque.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                                        m_Pago.Cheque.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text);
                                        int IdChequera = this.Workspace.DefaultDataBase.FieldInt("SELECT id_chequera FROM chequeras WHERE estado=1 AND id_banco=" + EntradaBanco.TextInt.ToString() + " AND " + m_Pago.Cheque.Numero.ToString() + " BETWEEN desde AND hasta AND (id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + " OR id_sucursal IS NULL)");
                                        if (IdChequera == 0)
                                                m_Pago.Cheque.Chequera = null;
                                        else
                                                m_Pago.Cheque.Chequera = new Lbl.Bancos.Chequera(dataView, IdChequera);
                                        if (EntradaBanco.TextInt > 0)
                                                m_Pago.Cheque.Banco = new Lbl.Bancos.Banco(dataView, EntradaBanco.TextInt);
                                        else
                                                m_Pago.Cheque.Banco = null;
                                        m_Pago.Cheque.Obs = EntradaObs.Text;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                        if (EntradaCuenta.TextInt > 0)
                                                m_Pago.CuentaOrigen = new Lbl.Cuentas.CuentaRegular(dataView, EntradaCuenta.TextInt);
                                        else
                                                m_Pago.CuentaOrigen = null;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                        //TODO: los pagos con tarjeta no está implementados. Posiblemente no sean necesarios
                                        /*
                                        m_Pago.Cupon = new Lbl.Tarjetas.Cupon(dataView);
                                        m_Pago.Cupon.Numero = EntradaCupon.Text;
                                        m_Pago.Cupon.Autorizacion = EntradaAutorizacion.Text;

                                        if (EntradaTarjeta.TextInt > 0)
                                                m_Pago.Cupon.Tarjeta = new Lbl.Tarjetas.Tarjeta(dataView, EntradaTarjeta.TextInt);
                                        else
                                                m_Pago.Cupon.Tarjeta = null;

                                        if (EntradaPlan.TextInt > 0)
                                                m_Pago.Cupon.Plan = new Lbl.Tarjetas.Plan(dataView, EntradaPlan.TextInt);
                                        else
                                                m_Pago.Cupon.Plan = null;

                                        m_Pago.Cupon.Obs = EntradaObs.Text;
                                        */
                                        break;
                        }
                        m_Pago.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        m_Pago.Obs = EntradaObs.Text;
                        return m_Pago;
                }

                public void FromPago(Lbl.Comprobantes.Pago pago)
                {
                        m_Pago = pago;

                        this.MostrarPaneles();

                        switch (m_Pago.FormaDePago) {
                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                        if (m_Pago.FormaDePago != Lbl.Comprobantes.FormasDePago.Cheque)
                                                throw new InvalidOperationException();

                                        if (m_Pago.Cheque.Banco != null)
                                                EntradaBanco.TextInt = m_Pago.Cheque.Banco.Id;
                                        else
                                                EntradaBanco.TextInt = 0;
                                        EntradaFechaCobro.Text = Lfx.Types.Formatting.FormatDate(m_Pago.Cheque.FechaCobro);
                                        EntradaFechaEmision.Text = Lfx.Types.Formatting.FormatDate(m_Pago.Cheque.FechaEmision);
                                        EntradaNumeroCheque.Text = m_Pago.Cheque.Numero.ToString();
                                        break;
                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                        if (m_Pago.CuentaOrigen != null)
                                                EntradaCuenta.TextInt = m_Pago.CuentaOrigen.Id;
                                        else
                                                EntradaCuenta.TextInt = 0;
                                        break;
                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                        //TODO: los pagos con tarjeta no está implementados. Posiblemente no sean necesarios
                                        /*
                                        if (m_Pago.Cupon != null) {
                                                if (m_Pago.Cupon.Tarjeta != null)
                                                        EntradaTarjeta.TextInt = m_Pago.Cupon.Tarjeta.Id;
                                                else
                                                        EntradaTarjeta.TextInt = 0;

                                                if (m_Pago.Cupon.Plan != null)
                                                        EntradaPlan.TextInt = m_Pago.Cupon.Plan.Id;
                                                else
                                                        EntradaPlan.TextInt = 0;

                                                EntradaCupon.Text = m_Pago.Cupon.Numero;
                                                EntradaAutorizacion.Text = m_Pago.Cupon.Autorizacion;
                                        }
                                        */
                                        break;
                        }
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(m_Pago.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaObs.Text = m_Pago.Obs;
                }

                private void MostrarPaneles()
                {
                        PanelEfectivo.Visible = m_Pago.FormaDePago == Lbl.Comprobantes.FormasDePago.Efectivo;
                        PanelCheque.Visible = m_Pago.FormaDePago == Lbl.Comprobantes.FormasDePago.Cheque;
                        PanelCuenta.Visible = m_Pago.FormaDePago == Lbl.Comprobantes.FormasDePago.CuentaRegular;
                        PanelTarjeta.Visible = (m_Pago.FormaDePago == Lbl.Comprobantes.FormasDePago.Tarjeta) || (m_Pago.FormaDePago == Lbl.Comprobantes.FormasDePago.TarjetaDeDebito);
                        PanelCuentaCorriente.Visible = m_Pago.FormaDePago == Lbl.Comprobantes.FormasDePago.CuentaCorriente;
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
                                EntradaPlan.Required = (System.Convert.ToInt32(Tarjeta.Fields["credeb"]) == 2);
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

                private void EntradaFechaEmision_Enter(object sender, EventArgs e)
                {
                        if (EntradaFechaEmision.Text.Length == 0) {
                                EntradaFechaEmision.Text = Lfx.Types.Formatting.FormatDate(System.DateTime.Now);
                                EntradaFechaEmision.SelectionStart = 0;
                                EntradaFechaEmision.SelectionLength = EntradaFechaEmision.Text.Length;
                        }
                }
        }
}