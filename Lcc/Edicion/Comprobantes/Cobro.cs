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
                public Lbl.Comprobantes.FormaDePago FormaDePago
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
                                if (this.ElementoCobro == null)
                                        this.ElementoCobro = new Lbl.Comprobantes.Cobro(this.DataView, value);
                                else
                                        this.ElementoCobro.FormaDePago = value;
                                if (EntradaFormaDePago.TextInt != value.Id)
                                        EntradaFormaDePago.TextInt = value.Id;
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
                                case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente:
                                        //Nada que verificar
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Cheque:
                                        if (EntradaBanco.TextInt <= 0)
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar un banco.");
                                        if (EntradaFechaEmision.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar la fecha de emisión.");
                                        if (EntradaFechaCobro.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar la fecha de cobro. Si lo desea puede especificar la misma fecha que de emisión.");
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Tarjeta:
                                        if (EntradaCupon.Text.Length == 0)
                                                return new Lfx.Types.FailureOperationResult("Debe especificar el número de cupón.");
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaRegular:
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
                        switch (this.ElementoCobro.FormaDePago.Tipo) {
                                case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Cheque:
                                        this.ElementoCobro.Cheque = new Lbl.Bancos.Cheque(dataView);
                                        this.ElementoCobro.Cheque.Emisor = EntradaEmisor.Text;
                                        this.ElementoCobro.Cheque.FechaCobro = Lfx.Types.Parsing.ParseDate(EntradaFechaCobro.Text);
                                        this.ElementoCobro.Cheque.FechaEmision = Lfx.Types.Parsing.ParseDate(EntradaFechaEmision.Text);
                                        this.ElementoCobro.Cheque.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                                        this.ElementoCobro.Cheque.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text);
                                        if (EntradaBanco.TextInt > 0)
                                                this.ElementoCobro.Cheque.Banco = new Lbl.Bancos.Banco(dataView, EntradaBanco.TextInt);
                                        else
                                                this.ElementoCobro.Cheque.Banco = null;
                                        this.ElementoCobro.Cheque.Obs = EntradaObs.Text;
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaRegular:
                                        if (EntradaCuenta.TextInt > 0)
                                                this.ElementoCobro.CuentaDestino = new Lbl.Cuentas.CuentaRegular(dataView, EntradaCuenta.TextInt);
                                        else
                                                this.ElementoCobro.CuentaDestino = null;
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Tarjeta:
                                        this.ElementoCobro.Cupon = new Lbl.Tarjetas.Cupon(dataView);
                                        this.ElementoCobro.Cupon.Numero = EntradaCupon.Text;
                                        this.ElementoCobro.Cupon.Autorizacion = EntradaAutorizacion.Text;
                                        this.ElementoCobro.Cupon.Tarjeta = new Lbl.Tarjetas.Tarjeta(dataView, this.FormaDePago.Id);

                                        if (EntradaPlan.TextInt > 0)
                                                this.ElementoCobro.Cupon.Plan = new Lbl.Tarjetas.Plan(dataView, EntradaPlan.TextInt);
                                        else
                                                this.ElementoCobro.Cupon.Plan = null;

                                        this.ElementoCobro.Cupon.Obs = EntradaObs.Text;
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
                                case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Cheque:
                                        if (this.ElementoCobro.FormaDePago.Tipo != Lbl.Comprobantes.TipoFormasDePago.Cheque)
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
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaRegular:
                                        if (this.ElementoCobro.CuentaDestino != null)
                                                EntradaCuenta.TextInt = this.ElementoCobro.CuentaDestino.Id;
                                        else
                                                EntradaCuenta.TextInt = 0;
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Tarjeta:
                                        if (this.ElementoCobro.Cupon != null) {
                                                if (this.ElementoCobro.Cupon.Plan != null)
                                                        EntradaPlan.TextInt = this.ElementoCobro.Cupon.Plan.Id;
                                                else
                                                        EntradaPlan.TextInt = 0;

                                                EntradaCupon.Text = this.ElementoCobro.Cupon.Numero;
                                                EntradaAutorizacion.Text = this.ElementoCobro.Cupon.Autorizacion;
                                        }
                                        break;
                        }
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(this.ElementoCobro.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaObs.Text = this.ElementoCobro.Obs;
                }

                private void MostrarPaneles()
                {
                        PanelEfectivo.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.Efectivo;
                        PanelCheque.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.Cheque;
                        PanelCuenta.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.CuentaRegular;
                        PanelTarjeta.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.Tarjeta;
                        PanelCuentaCorriente.Visible = this.ElementoCobro.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente;
                        this.Height = PanelSeparadorInferior.Bottom + 1;

                        if (this.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.CuentaRegular) {
                                if (this.FormaDePago.Cuenta == null) {
                                        EntradaCuenta.Enabled = true;
                                } else {
                                        EntradaCuenta.Enabled = false;
                                        EntradaCuenta.TextInt = this.FormaDePago.Cuenta.Id;
                                }
                        }
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
                        Lfx.Data.Row Tarjeta = this.Workspace.DefaultDataView.Tables["tarjetas"].FastRows[this.FormaDePago.Id];
                        if (Tarjeta != null) {
                                EntradaPlan.Required = (System.Convert.ToInt32(Tarjeta.Fields["credeb"].Value) == 1);
                                EntradaPlan.Filter = "id_tarjeta=" + this.FormaDePago.Id.ToString() + " OR id_tarjeta IS NULL";
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

                private void FormaDePago_SizeChanged(object sender, EventArgs e)
                {
                        AyudaFormaDePago.Top = EntradaFormaDePago.Height + 2;
                        PanelFormaDePago.Height = EntradaFormaDePago.Height + (AyudaFormaDePago.Visible ? AyudaFormaDePago.Height : 0) + 4;
                }

                private void EntradaFormaDePago_TextChanged(object sender, EventArgs e)
                {
                        this.FormaDePago = new Lbl.Comprobantes.FormaDePago(this.DataView, EntradaFormaDePago.TextInt);
                }
        }
}