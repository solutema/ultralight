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
                public Pago()
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
                                if (this.ElementoPago == null)
                                        return null;
                                else
                                        return this.ElementoPago.FormaDePago;
                        }
                        set
                        {
                                if (this.ElementoPago == null)
                                        this.ElementoPago = new Lbl.Comprobantes.Pago(this.DataView, value);
                                else
                                        this.ElementoPago.FormaDePago = value;
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

                private Lbl.Comprobantes.Pago ElementoPago
                {
                        get
                        {
                                return this.Elemento as Lbl.Comprobantes.Pago;
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

                        if(this.FormaDePago == null || this.FormaDePago.Existe == false)
                                return new Lfx.Types.FailureOperationResult("Debe seleccionar la forma de pago.");

                        if (this.FormaDePago.Pagos == false)
                                return new Lfx.Types.FailureOperationResult("La forma seleccionada no es válida para realizar pagos, sólo para realizar cobros.");

                        switch (this.FormaDePago.Tipo) {
                                case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente:
                                        //Nada que verificar
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Cheque:
                                        if (EntradaBanco.TextInt <= 0) {
                                                return new Lfx.Types.FailureOperationResult("Debe seleccionar un banco.");
                                        }  else {
                                                int Numero = Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text);
                                                int IdChequera = this.DataView.DataBase.FieldInt("SELECT id_chequera FROM chequeras WHERE estado=1 AND id_banco=" + EntradaBanco.TextInt.ToString() + " AND " + Numero.ToString() + " BETWEEN desde AND hasta AND (id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + " OR id_sucursal IS NULL)");
                                                if (IdChequera == 0)
                                                        return new Lfx.Types.FailureOperationResult("El Número de cheque no corresponde a ninguna Chequera del banco seleccionado.");

                                                int IdChequePrevio = this.DataView.DataBase.FieldInt("SELECT id_cheque FROM bancos_cheques WHERE estado<>90 AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text).ToString() + " AND (id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + " OR id_sucursal IS NULL)");
                                                if (IdChequePrevio != 0)
                                                        return new Lfx.Types.FailureOperationResult("El Número corresponde a un cheque que ya fue emitido.");

                                        }
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

                public virtual Lbl.Comprobantes.Pago ToPago(Lws.Data.DataView dataView)
                {
                        switch (this.ElementoPago.FormaDePago.Tipo) {
                                case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Cheque:

                                        this.ElementoPago.Cheque = new Lbl.Bancos.Cheque(dataView);
                                        this.ElementoPago.Cheque.Emitido = true;
                                        this.ElementoPago.Cheque.FechaCobro = Lfx.Types.Parsing.ParseDate(EntradaFechaCobro.Text);
                                        this.ElementoPago.Cheque.FechaEmision = Lfx.Types.Parsing.ParseDate(EntradaFechaEmision.Text);
                                        this.ElementoPago.Cheque.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                                        this.ElementoPago.Cheque.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumeroCheque.Text);
                                        int IdChequera = this.DataView.DataBase.FieldInt("SELECT id_chequera FROM chequeras WHERE estado=1 AND id_banco=" + EntradaBanco.TextInt.ToString() + " AND " + this.ElementoPago.Cheque.Numero.ToString() + " BETWEEN desde AND hasta AND (id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString() + " OR id_sucursal IS NULL)");
                                        if (IdChequera == 0)
                                                this.ElementoPago.Cheque.Chequera = null;
                                        else
                                                this.ElementoPago.Cheque.Chequera = new Lbl.Bancos.Chequera(dataView, IdChequera);
                                        if (EntradaBanco.TextInt > 0)
                                                this.ElementoPago.Cheque.Banco = new Lbl.Bancos.Banco(dataView, EntradaBanco.TextInt);
                                        else
                                                this.ElementoPago.Cheque.Banco = null;
                                        this.ElementoPago.Cheque.Obs = EntradaObs.Text;
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaRegular:
                                        if (EntradaCuenta.TextInt > 0)
                                                this.ElementoPago.CuentaOrigen = new Lbl.Cuentas.CuentaRegular(dataView, EntradaCuenta.TextInt);
                                        else
                                                this.ElementoPago.CuentaOrigen = null;
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Tarjeta:
                                        //TODO: los pagos con tarjeta no está implementados. Posiblemente no sean necesarios
                                        /*
                                        this.ElementoPago.Cupon = new Lbl.Tarjetas.Cupon(dataView);
                                        this.ElementoPago.Cupon.Numero = EntradaCupon.Text;
                                        this.ElementoPago.Cupon.Autorizacion = EntradaAutorizacion.Text;

                                        if (EntradaTarjeta.TextInt > 0)
                                                this.ElementoPago.Cupon.Tarjeta = new Lbl.Tarjetas.Tarjeta(dataView, EntradaTarjeta.TextInt);
                                        else
                                                this.ElementoPago.Cupon.Tarjeta = null;

                                        if (EntradaPlan.TextInt > 0)
                                                this.ElementoPago.Cupon.Plan = new Lbl.Tarjetas.Plan(dataView, EntradaPlan.TextInt);
                                        else
                                                this.ElementoPago.Cupon.Plan = null;

                                        this.ElementoPago.Cupon.Obs = EntradaObs.Text;
                                        */
                                        break;
                        }
                        this.ElementoPago.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        this.ElementoPago.Obs = EntradaObs.Text;
                        return this.ElementoPago;
                }

                public void FromPago(Lbl.Comprobantes.Pago pago)
                {
                        this.ElementoPago = pago;
                        this.EntradaFormaDePago.TextInt = pago.FormaDePago.Id;
                        this.MostrarPaneles();

                        switch (this.ElementoPago.FormaDePago.Tipo) {
                                case Lbl.Comprobantes.TipoFormasDePago.Efectivo:
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente:
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Cheque:
                                        if (this.ElementoPago.FormaDePago.Tipo != Lbl.Comprobantes.TipoFormasDePago.Cheque)
                                                throw new InvalidOperationException();

                                        if (this.ElementoPago.Cheque != null) {
                                                if (this.ElementoPago.Cheque.Banco != null)
                                                        EntradaBanco.TextInt = this.ElementoPago.Cheque.Banco.Id;
                                                else
                                                        EntradaBanco.TextInt = 0;
                                                EntradaFechaCobro.Text = Lfx.Types.Formatting.FormatDate(this.ElementoPago.Cheque.FechaCobro);
                                                EntradaFechaEmision.Text = Lfx.Types.Formatting.FormatDate(this.ElementoPago.Cheque.FechaEmision);
                                                EntradaNumeroCheque.Text = this.ElementoPago.Cheque.Numero.ToString();
                                        } else {
                                                EntradaBanco.TextInt = 0;
                                                EntradaFechaCobro.Text = "";
                                                EntradaFechaEmision.Text = "";
                                                EntradaNumeroCheque.Text = "";
                                        }
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.CuentaRegular:
                                        if (this.ElementoPago.CuentaOrigen != null)
                                                EntradaCuenta.TextInt = this.ElementoPago.CuentaOrigen.Id;
                                        else
                                                EntradaCuenta.TextInt = 0;
                                        break;
                                case Lbl.Comprobantes.TipoFormasDePago.Tarjeta:
                                        //TODO: los pagos con tarjeta no está implementados. Posiblemente no sean necesarios
                                        /*
                                        if (this.ElementoPago.Cupon != null) {
                                                if (this.ElementoPago.Cupon.Tarjeta != null)
                                                        EntradaTarjeta.TextInt = this.ElementoPago.Cupon.Tarjeta.Id;
                                                else
                                                        EntradaTarjeta.TextInt = 0;

                                                if (this.ElementoPago.Cupon.Plan != null)
                                                        EntradaPlan.TextInt = this.ElementoPago.Cupon.Plan.Id;
                                                else
                                                        EntradaPlan.TextInt = 0;

                                                EntradaCupon.Text = this.ElementoPago.Cupon.Numero;
                                                EntradaAutorizacion.Text = this.ElementoPago.Cupon.Autorizacion;
                                        }
                                        */
                                        break;
                        }
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(this.ElementoPago.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaObs.Text = this.ElementoPago.Obs;
                }

                private void MostrarPaneles()
                {
                        PanelEfectivo.Visible = this.ElementoPago.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.Efectivo;
                        PanelCheque.Visible = this.ElementoPago.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.Cheque;
                        PanelCuenta.Visible = this.ElementoPago.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.CuentaRegular;
                        PanelTarjeta.Visible = this.ElementoPago.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.Tarjeta;
                        PanelCuentaCorriente.Visible = this.ElementoPago.FormaDePago.Tipo == Lbl.Comprobantes.TipoFormasDePago.CuentaCorriente;
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
                        Lfx.Data.Row Tarjeta = this.Workspace.DefaultDataView.Tables["tarjetas"].FastRows[this.FormaDePago.Id];
                        if (Tarjeta != null) {
                                EntradaPlan.Required = (System.Convert.ToInt32(Tarjeta.Fields["credeb"]) == 2);
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

                private void EntradaFormaDePago_TextChanged(object sender, EventArgs e)
                {
                        if (this.FormaDePago == null || this.FormaDePago.Id != EntradaFormaDePago.TextInt)
                                this.FormaDePago = new Lbl.Comprobantes.FormaDePago(this.DataView, EntradaFormaDePago.TextInt);
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