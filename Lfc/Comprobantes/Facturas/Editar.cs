#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.ComponentModel;

namespace Lfc.Comprobantes.Facturas
{
        public partial class Editar : Lfc.Comprobantes.Editar
        {
                public Control ControlDestino = null;

                public Editar()
                {
                        this.ElementoTipo = typeof(Lbl.Comprobantes.ComprobanteConArticulos);

                        InitializeComponent();
                }

                public Editar(string tipo)
                        : this()
                {
                        switch (tipo) {
                                case "F":
                                        TipoPredet = "FB";
                                        break;
                                case "NC":
                                        TipoPredet = "NCB";
                                        break;
                                case "ND":
                                        TipoPredet = "NDB";
                                        break;
                                default:
                                        TipoPredet = tipo;
                                        break;
                        }
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        Lfx.Types.OperationResult validarReturn = base.ValidarControl();

                        if (validarReturn.Success == true) {
                                Lbl.Comprobantes.ComprobanteConArticulos Registro = this.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;
                                Registro.Cliente.Cargar();

                                if (Registro.NumeroRemito > 0) {
                                        Lfx.Data.Row Remito = this.Connection.FirstRowFromSelect("SELECT * FROM comprob WHERE tipo_fac='R' AND numero=" + Registro.NumeroRemito.ToString() + " AND impresa>0 AND anulada=0");
                                        if (Remito == null) {
                                                validarReturn.Success = false;
                                                validarReturn.Message += "El número de Remito no es válido." + Environment.NewLine;
                                        }
                                }
                                if (Registro.FormaDePago == null && Registro.Tipo.EsFactura) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Debe especificar la Forma de Pago." + Environment.NewLine;
                                }
                                if (Registro.Cliente.Id == 999 && Registro.FormaDePago != null && Registro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente && Registro.Cliente != null) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += @"""Consumidor Final"" no puede realizar pagos en Cuenta Corriente." + Environment.NewLine;
                                }


                                if (Registro.Cliente.SituacionTributaria != null && (Registro.Cliente.SituacionTributaria.Id == 2 || Registro.Cliente.SituacionTributaria.Id == 3)) {
                                        if (Registro.Cliente.Cuit == null || Registro.Cliente.Cuit.EsValido() == false) {
                                                validarReturn.Success = false;
                                                validarReturn.Message += "El cliente debe tener una CUIT válida." + Environment.NewLine;
                                        }
                                }
                        }
                        return validarReturn;
                }

                public override void ActualizarControl()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Res = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (this.Tipo.EsFactura || this.Tipo.EsTicket) {
                                EntradaTipo.SetData = new string[] {
                                        "Factura A|FA",
                                        "Factura B|FB",
                                        "Factura C|FC",
                                        "Factura M|FM",
                                        "Factura E|FE",
                                        "Ticket|T"
                                };
                                EntradaFormaPago.Elemento = Res.FormaDePago;
                                EntradaFormaPago.Visible = true;
                        } else if (this.Tipo.EsNotaCredito || this.Tipo.EsNotaDebito) {
                                EntradaTipo.SetData = new string[] {
                                        "Nota Créd. A|NCA",
                                        "Nota Créd. B|NCB",
                                        "Nota Créd. C|NCC",
                                        "Nota Créd. E|NCE",
                                        "Nota Créd. M|NCM",
                                        "Nota Déb. A|NDA",
                                        "Nota Déb. B|NDB",
                                        "Nota Déb. C|NDC",
                                        "Nota Déb. E|NDE",
                                        "Nota Déb. M|NDM"

                                };
                                EntradaFormaPago.TextInt = 3;
                                EntradaFormaPago.Visible = false;
                        }

                        EntradaTipo.TextKey = Res.Tipo.Nomenclatura;
                        EntradaRemito.Text = Res.NumeroRemito.ToString();
                        BotonPago.Visible = EsCancelable();

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Res = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        //Agrego campos propios de esta instancia
                        if (EntradaFormaPago.TextInt > 0)
                                Res.FormaDePago = new Lbl.Pagos.FormaDePago(Res.Connection, EntradaFormaPago.TextInt);
                        else
                                Res.FormaDePago = null;
                        Res.NumeroRemito = Lfx.Types.Parsing.ParseInt(EntradaRemito.Text);

                        base.ActualizarElemento();
                }


                public override Lfx.Types.OperationResult BeforePrint()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Comprob.Articulos.Count >= 1 && (Comprob.Articulos[0].Cantidad < 0 || Comprob.Articulos[0].Unitario < 0))
                                return new Lfx.Types.OperationResult(false, "El primer ítem de la factura no puede ser negativo. Utilice los ítem negativos en último lugar.");

                        Comprob.Cliente.Cargar();

                        if (Comprob.Cliente == null)
                                return new Lfx.Types.FailureOperationResult("Debe proporcionar un Cliente válido.");

                        else if (Comprob.Cliente.SituacionTributaria == null)
                                return new Lfx.Types.FailureOperationResult("El Cliente no tiene una Situación Tributaria definida.");

                        if (Comprob.Tipo.EsFacturaNCoND && Comprob.Tipo.LetraSola != Comprob.Cliente.LetraPredeterminada()) {
                                Lui.Forms.YesNoDialog OPregunta = new Lui.Forms.YesNoDialog(@"La situación tributaria del cliente y el tipo de comprobante no se corresponden.
Un cliente " + Comprob.Cliente.SituacionTributaria.ToString() + @" debería llevar un comprobante tipo " + Comprob.Cliente.LetraPredeterminada() + @". No debería continuar con la impresión. 
¿Desea continuar de todos modos?", "Tipo de comprobante incorrecto");
                                OPregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                if (OPregunta.ShowDialog() == DialogResult.Cancel)
                                        return new Lfx.Types.FailureOperationResult("Corrija la Situación Tributaria del Cliente o el Tipo de Comprobante.");
                        }

                        if (Comprob.Tipo.LetraSola.ToUpperInvariant() == "A") {
                                if (Comprob.Cliente.Cuit.EsValido() == false)
                                        return new Lfx.Types.FailureOperationResult("Debe proporcionar el número de CUIT del cliente.");
                        } else if (Comprob.Tipo.LetraSola == "B") {
                                //Si es factura B de más de $ 1000, debe llevar el Nº de DNI
                                if (Comprob.Total >= 1000 && Comprob.Cliente.NumeroDocumento.Length < 5 &&
                                        (Comprob.Cliente.Cuit == null || Comprob.Cliente.Cuit.EsValido() == false))
                                        return new Lfx.Types.FailureOperationResult("Para Facturas B de $ 1.000 o más, debe proporcionar el número de DNI/CUIT del cliente.");
                                //Si es factura B de más de $ 1000, debe llevar domicilio
                                if (Comprob.Total >= 1000 && Comprob.Cliente.Domicilio.Length < 1)
                                        return new Lfx.Types.FailureOperationResult("Para Facturas B de $ 1.000 o más, debe proporcionar el domicilio del cliente.");
                        }

                        if (ProductArray.ShowStock && this.Tipo.MueveStock && Comprob.HayStock() == false) {
                                Lui.Forms.YesNoDialog OPregunta = new Lui.Forms.YesNoDialog("Las existencias actuales no son suficientes para cubrir la operación que intenta realizar.\n¿Desea continuar de todos modos?", "No hay existencias suficientes");
                                OPregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                if (OPregunta.ShowDialog() == DialogResult.Cancel)
                                        return new Lfx.Types.FailureOperationResult("No se imprimir el comprobante por falta de existencias.");
                        }

                        if (Comprob.Cliente.Id != 999 && (Comprob.Tipo.EsFactura || Comprob.Tipo.EsNotaDebito)) {
                                decimal SaldoCtaCte = Comprob.Cliente.CuentaCorriente.Saldo(false);

                                if (Comprob.FormaDePago != null && Comprob.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente) {
                                        decimal LimiteCredito = Comprob.Cliente.LimiteCredito;

                                        if (LimiteCredito == 0)
                                                LimiteCredito = Lfx.Types.Parsing.ParseCurrency(this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Cuentas.LimiteCreditoPredet", "0"));

                                        if (LimiteCredito != 0 && (Comprob.Total + SaldoCtaCte) > LimiteCredito)
                                                return new Lfx.Types.FailureOperationResult("El valor de la factura y/o el saldo en cuenta corriente supera el Límite de Crédito de este cliente.");
                                } else {
                                        if (SaldoCtaCte < 0) {
                                                SaldoEnCuentaCorriente FormularioError = new SaldoEnCuentaCorriente();

                                                switch (FormularioError.ShowDialog()) {
                                                        case DialogResult.Yes:
                                                                //Corregir el problema
                                                                this.EntradaFormaPago.TextInt = 3;
                                                                Comprob.FormaDePago.Tipo = Lbl.Pagos.TiposFormasDePago.CuentaCorriente;
                                                                break;
                                                        case DialogResult.No:
                                                                //Continuar. No corregir el problema.
                                                                break;
                                                        default:
                                                                //Cancelar y volver a la edición.
                                                                return new Lfx.Types.OperationResult(false);
                                                }
                                        }
                                }
                        }

                        if (Comprob.PV < 1)
                                return new Lfx.Types.FailureOperationResult("Debe especificar el Punto de Venta.");

                        Lbl.Comprobantes.PuntoDeVenta Pv = Lbl.Comprobantes.PuntoDeVenta.TodosPorNumero[Comprob.PV];
                        Lbl.Impresion.Impresora Impresora = Comprob.ObtenerImpresora();

                        if (Pv.CargaManual && (Impresora == null || Impresora.CargaPapel == Lbl.Impresion.CargasPapel.Automatica)) {
                                Lui.Printing.ManualFeedDialog FormularioCargaManual = new Lui.Printing.ManualFeedDialog();
                                FormularioCargaManual.DocumentName = Comprob.Tipo.ToString() + " " + Comprob.PV.ToString("0000") + "-" + Lbl.Comprobantes.Numerador.ProximoNumero(Comprob).ToString("00000000");
                                // Muestro el nombre de la impresora
                                if (Impresora != null) {
                                        FormularioCargaManual.PrinterName = Impresora.Nombre;
                                } else {
                                        System.Drawing.Printing.PrinterSettings objPrint = new System.Drawing.Printing.PrinterSettings();
                                        FormularioCargaManual.PrinterName = objPrint.PrinterName;
                                }
                                if (FormularioCargaManual.ShowDialog() == DialogResult.Cancel)
                                        return new Lfx.Types.CancelOperationResult();
                        }

                        return base.BeforePrint();
                }

                public override void AfterPrint()
                {
                        BotonPago.Visible = this.EsCancelable();

                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (Comprob.Impreso && this.EsCancelable()) {
                                switch (Comprob.FormaDePago.Tipo) {
                                        case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                //El pago lo asentó la rutina de impresión
                                                //Yo sólo muestro la ventanita de calcular el cambio
                                                Comprobantes.PagoVuelto FormularioVuelto = new Comprobantes.PagoVuelto();
                                                FormularioVuelto.Total = Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text);
                                                FormularioVuelto.ShowDialog();
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.ChequePropio:
                                        case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                        case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                        case Lbl.Pagos.TiposFormasDePago.OtroValor:
                                        case Lbl.Pagos.TiposFormasDePago.Caja:
                                                EditarPago(false);
                                                break;
                                }
                        }
                }

                private void EntradaTipo_TextChanged(object sender, System.EventArgs e)
                {
                        this.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra[EntradaTipo.TextKey];
                }

                private void BotonPago_Click(object sender, System.EventArgs e)
                {
                        EditarPago(false);
                }


                private Lfx.Types.OperationResult EditarPago(bool PasarACtaCte)
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Factura = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (Factura.ImporteCancelado >= Factura.Total)
                                return new Lfx.Types.FailureOperationResult("Este comprobante ya fue cancelado en su totalidad.");

                        if (Factura.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente) {
                                CrearReciboParaEstaFactura();
                        } else {
                                Comprobantes.Recibos.EditarCobro FormularioEditarPago = new Comprobantes.Recibos.EditarCobro();
                                FormularioEditarPago.Cobro.FromCobro(new Lbl.Comprobantes.Cobro(this.Connection, Factura.FormaDePago));
                                FormularioEditarPago.Cobro.FormaDePagoEditable = true;
                                FormularioEditarPago.Cobro.Importe = Factura.Total;
                                FormularioEditarPago.Cobro.ImporteVisible = true;
                                FormularioEditarPago.Cobro.ImporteEditable = false;
                                if (FormularioEditarPago.ShowDialog() == DialogResult.OK) {
                                        Lbl.Comprobantes.Cobro MiCobro = FormularioEditarPago.Cobro.ToCobro(Factura.Connection);
                                        if (MiCobro.FormaDePago.Id != Factura.FormaDePago.Id) {
                                                // Tengo que actualizar la forma de pago
                                                Factura.Connection.BeginTransaction();
                                                Factura.FormaDePago = MiCobro.FormaDePago;
                                                EntradaFormaPago.Elemento = MiCobro;
                                                Factura.Connection.FieldInt("UPDATE comprob SET id_formapago=" + MiCobro.FormaDePago.Id.ToString() + " WHERE id_comprob=" + Factura.Id.ToString());
                                                if (MiCobro.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente) {
                                                        // Si la nueva forma de pago es cta. cte., asiento el saldo
                                                        // Y uso saldo a favor, si lo hay
                                                        decimal Saldo = Factura.Cliente.CuentaCorriente.Saldo(true);
                                                        Factura.Cliente.CuentaCorriente.Movimiento(true,
                                                                Lbl.Cajas.Concepto.IngresosPorFacturacion,
                                                                "Saldo a Cta. Cte. s/" + Factura.ToString(),
                                                                Factura.ImporteImpago,
                                                                null,
                                                                Factura,
                                                                null,
                                                                null,
                                                                false);
                                                        if (Saldo < 0) {
                                                                Saldo = Math.Abs(Saldo);
                                                                if (Saldo > Factura.Total)
                                                                        Factura.CancelarImporte(Factura.Total, null);
                                                                else
                                                                        Factura.CancelarImporte(Saldo, null);
                                                        }
                                                }
                                                Factura.Connection.Commit();
                                        }
                                        switch (Factura.FormaDePago.Tipo) {
                                                case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                        Factura.Connection.BeginTransaction();
                                                        Lbl.Cajas.Caja CajaDiaria = new Lbl.Cajas.Caja(Factura.Connection, Lfx.Workspace.Master.CurrentConfig.Empresa.CajaDiaria);
                                                        CajaDiaria.Movimiento(true, Lbl.Cajas.Concepto.IngresosPorFacturacion, Factura.ToString(), Factura.Cliente, Factura.ImporteImpago, Factura.Obs, Factura, null, null);
                                                        Factura.CancelarImporte(Factura.Total, null);
                                                        Factura.Connection.Commit();
                                                        break;
                                                case Lbl.Pagos.TiposFormasDePago.CuentaCorriente:
                                                        CrearReciboParaEstaFactura();
                                                        break;
                                                case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                                        Factura.Connection.BeginTransaction();
                                                        Lbl.Bancos.Cheque Cheque = MiCobro.Cheque;
                                                        Cheque.Concepto = Lbl.Cajas.Concepto.IngresosPorFacturacion;
                                                        Cheque.ConceptoTexto = "Cobro s/" + this.Elemento.ToString();
                                                        Cheque.Factura = Factura;
                                                        Cheque.Guardar();
                                                        Factura.CancelarImporte(Factura.Total, null);
                                                        Factura.Connection.Commit();
                                                        BotonPago.Visible = false;
                                                        break;
                                                case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                                        Factura.Connection.BeginTransaction();
                                                        Lbl.Pagos.Cupon CuponCredito = MiCobro.Cupon;
                                                        CuponCredito.Concepto = Lbl.Cajas.Concepto.IngresosPorFacturacion;
                                                        CuponCredito.ConceptoTexto = "Cobro s/" + Factura.ToString();

                                                        if (EntradaVendedor.TextInt > 0)
                                                                CuponCredito.Vendedor = new Lbl.Personas.Persona(Factura.Connection, EntradaVendedor.TextInt);

                                                        CuponCredito.Factura = Factura;
                                                        CuponCredito.Guardar();

                                                        Factura.CancelarImporte(Factura.Total, null);
                                                        Factura.Connection.Commit();
                                                        BotonPago.Visible = false;
                                                        break;
                                                case Lbl.Pagos.TiposFormasDePago.Caja:
                                                        Factura.Connection.BeginTransaction();
                                                        Lbl.Cajas.Caja CajaDeposito = MiCobro.CajaDestino;
                                                        CajaDeposito.Movimiento(true, Lbl.Cajas.Concepto.IngresosPorFacturacion, "Cobro s/" + Factura.ToString(), Factura.Cliente, MiCobro.Importe, MiCobro.Obs, Factura, null, null);
                                                        Factura.CancelarImporte(Factura.Total, null);
                                                        Factura.Connection.Commit();
                                                        BotonPago.Visible = false;
                                                        break;
                                                default:
                                                        throw new NotImplementedException("No se reconoce la forma de pago " + Factura.FormaDePago.Tipo.ToString());
                                        }

                                } else {
                                        return new Lfx.Types.SuccessOperationResult();
                                }
                                FormularioEditarPago = null;
                                BotonPago.Visible = false;
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                private void CrearReciboParaEstaFactura()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Factura = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        Lbl.Comprobantes.ReciboDeCobro Recibo = new Lbl.Comprobantes.ReciboDeCobro(this.Workspace.GetNewConnection("Nuevo recibo para " + Factura.ToString()));
                        Recibo.Crear();
                        Recibo.Facturas.Add(Factura);
                        Recibo.Cliente = Factura.Cliente;

                        Recibo.Concepto = Lbl.Cajas.Concepto.IngresosPorFacturacion;
                        Recibo.ConceptoTexto = "Cancelación de " + Factura.ToString();

                        Lfc.FormularioEdicion NuevoRecibo = Lfc.Instanciador.InstanciarFormularioEdicion(Recibo);
                        NuevoRecibo.MdiParent = this.ParentForm.MdiParent;
                        NuevoRecibo.Show();
                }

                internal bool EsCancelable()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro == null || Registro.ImporteImpago == 0) {
                                return false;
                        } else {
                                return (Registro.Impreso && Registro.Existe && (Registro.FormaDePago.Tipo != Lbl.Pagos.TiposFormasDePago.Efectivo));
                        }
                }


                private void EntradaRemito_TextChanged(object sender, System.EventArgs e)
                {
                        int RemitoId = Lfx.Types.Parsing.ParseInt(EntradaRemito.Text);
                        if (RemitoId > 0) {
                                Lfx.Data.Row Remito = this.Connection.FirstRowFromSelect("SELECT * FROM comprob WHERE tipo_fac='R' AND numero=" + RemitoId.ToString() + " AND impresa>0 AND anulada=0");
                                if (Remito == null)
                                        ProductArray.ShowStock = true;
                                else
                                        ProductArray.ShowStock = false;
                        } else {
                                ProductArray.ShowStock = true;
                        }
                }


                private void EntradaFormaPago_Leave(object sender, System.EventArgs e)
                {
                        if (EntradaFormaPago.TextInt == 99)
                                EntradaFormaPago.TextInt = 3;
                        if (EntradaFormaPago.TextInt == 5)
                                EntradaFormaPago.TextInt = 4;
                }


                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public override Lbl.Comprobantes.Tipo Tipo
                {
                        get
                        {
                                return base.Tipo;
                        }
                        set
                        {
                                base.Tipo = value;
                                PanelFormaPago.Visible = value.EsFactura || value.EsTicket;
                                if (EntradaTipo.TextKey != value.Nomenclatura)
                                        EntradaTipo.TextKey = value.Nomenclatura;
                        }
                }
        }
}