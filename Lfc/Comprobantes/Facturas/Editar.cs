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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lfc.Comprobantes.Facturas
{
	public partial class Editar : Lfc.Comprobantes.Editar
	{
                public Editar(string tipo)
                        : this()
                {
                        switch(tipo)
                        {
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

		public Editar()
                        : base()
		{
			InitializeComponent();
		}

		public override Lfx.Types.OperationResult ValidateData()
		{
			Lfx.Types.OperationResult validarReturn = base.ValidateData();

			if(validarReturn.Success == true) {
                                Lbl.Comprobantes.ComprobanteConArticulos Registro = this.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;
                                Registro.Cliente.Cargar();

				if(Registro.NumeroRemito > 0) {
                                        Lfx.Data.Row Remito = this.DataBase.FirstRowFromSelect("SELECT * FROM comprob WHERE tipo_fac='R' AND numero=" + Registro.NumeroRemito.ToString() + " AND impresa>0 AND anulada=0");
					if(Remito == null) {
						validarReturn.Success = false;
						validarReturn.Message += "El número de Remito no es válido." + Environment.NewLine;
					}
				}
                                if (Registro.FormaDePago == null && Registro.Tipo.EsFactura) {
                                        validarReturn.Success = false;
                                        validarReturn.Message += "Debe especificar la Forma de Pago." + Environment.NewLine;
                                }
                                if (Registro.Cliente.Id == 999 && Registro.FormaDePago != null && Registro.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.CuentaCorriente && Registro.Cliente != null) {
					validarReturn.Success = false;
					validarReturn.Message += @"""Consumidor Final"" no puede realizar Pagos Compuestos ni en Cuenta Corriente." + Environment.NewLine;
				}


                                if (Registro.Cliente.SituacionTributaria != null && (Registro.Cliente.SituacionTributaria.Id == 2 || Registro.Cliente.SituacionTributaria.Id == 3)) {
                                        if (Lfx.Types.Strings.ValidCUIT(Registro.Cliente.Cuit) == false) {
                                                validarReturn.Success = false;
                                                validarReturn.Message += "El cliente debe tener una CUIT válida." + Environment.NewLine;
                                        }
				}
			}
			return validarReturn;
		}

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Comprobantes.ComprobanteConArticulos Res = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (this.Tipo.EsFactura || this.Tipo.EsTicket)
                        {
                                EntradaTipo.SetData = new string[] {
                                        "Factura A|FA",
                                        "Factura B|FB",
                                        "Factura C|FC",
                                        "Factura M|FM",
                                        "Factura E|FE",
                                        "Ticket|T"
                                };
                                if (Res.FormaDePago == null)
                                        EntradaFormaPago.TextInt = 0;
                                else
                                        EntradaFormaPago.TextInt = Res.FormaDePago.Id;
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
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Res = base.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;
                        //Agrego campos propios de esta instancia
                        if (EntradaFormaPago.TextInt > 0)
                                Res.FormaDePago = new Lbl.Pagos.FormaDePago(Res.DataBase, EntradaFormaPago.TextInt);
                        else
                                Res.FormaDePago = null;
                        Res.NumeroRemito = Lfx.Types.Parsing.ParseInt(EntradaRemito.Text);

                        return Res;
                }

		/* public override bool ReadOnly
		{
			get
			{
                                return base.ReadOnly;
			}
			set
			{
                                base.ReadOnly = value;
			}
		} */

		public override Lfx.Types.OperationResult Edit(int iId)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.read") == false)
                                return new Lfx.Types.NoAccessOperationResult();

			Lfx.Types.OperationResult ResultadoEditar = base.Edit(iId);
			return ResultadoEditar;
		}

		public override Lfx.Types.OperationResult Create(string letra)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.create") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        ProductArray.ShowStock = true;

                        Lfx.Types.OperationResult Res = base.Create(letra);

                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        Registro.FormaDePago = new Lbl.Pagos.FormaDePago(Registro.DataBase, this.Workspace.CurrentConfig.ReadGlobalSettingInt(null, "Sistema.Documentos.FormaPagoPredet", 0));
                        this.FromRow(Registro);
                        EntradaTipo.TextKey = this.Tipo.Nomenclatura;

                        return Res;
		}

                public override Lfx.Types.OperationResult Print(bool selectPrinter)
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro.Impreso && Registro.Tipo.PermiteImprimirVariasVeces == false) {
                                return new Lfx.Types.OperationResult(false, "Este comprobante ya fue impreso.");
                        } else {
                                if(Registro.Articulos.Count >= 1 && (Registro.Articulos[0].Cantidad < 0 || Registro.Articulos[0].Unitario < 0))
                                        return new Lfx.Types.OperationResult(false, "El primer ítem de la factura no puede ser negativo. Utilice los ítem negativos en último lugar.");

                                if (Registro.Cliente == null)
                                        return new Lfx.Types.OperationResult(false, "Debe proporcionar un Cliente válido.");
                                else if (Registro.Cliente.SituacionTributaria == null)
                                        return new Lfx.Types.OperationResult(false, "El Cliente no tiene una Situación Tributaria definida.");

                                if (Registro.Tipo.EsFacturaNCoND && Registro.Tipo.LetraSola != Registro.Cliente.LetraPredeterminada()) {
                                        Lui.Forms.YesNoDialog OPregunta = new Lui.Forms.YesNoDialog(@"La situación tributaria del cliente y el tipo de comprobante no se corresponden.
Un cliente " + Registro.Cliente.SituacionTributaria.ToString() + @" debería llevar un comprobante tipo " + Registro.Cliente.LetraPredeterminada() + @". No debería continuar con la impresión. 
¿Desea continuar de todos modos?", "Tipo de comprobante incorrecto");
                                        OPregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                        if (OPregunta.ShowDialog() == DialogResult.Cancel)
                                                return new Lfx.Types.OperationResult(false, "Corrija la Situación Tributaria del Cliente o el Tipo de Comprobante.");
                                }

                                if (Registro.Tipo.LetraSola.ToUpperInvariant() == "A") {
                                        if (Registro.Cliente.Cuit.Length < 5)
                                                return new Lfx.Types.OperationResult(false, @"Debe proporcionar el número de CUIT del cliente.");
                                } else if (Registro.Tipo.LetraSola == "B") {
                                        //Si es factura B de más de $ 1000, debe llevar el Nº de DNI
                                        if (Registro.Total >= 1000 && Registro.Cliente.NumeroDocumento.Length < 5 && Registro.Cliente.Cuit.Length < 5)
                                                return new Lfx.Types.OperationResult(false, @"Para comprob tipo ""B"" de $ 1.000 o más, debe proporcionar el número de DNI del cliente.");
                                        //Si es factura B de más de $ 1000, debe llevar domicilio
                                        if (Registro.Total >= 1000 && Registro.Cliente.Domicilio.Length < 1)
                                            return new Lfx.Types.OperationResult(false, @"Para comprob tipo ""B"" de $ 1.000 o más, debe proporcionar el domicilio del cliente.");
                                }

                                if (ProductArray.ShowStock && this.Tipo.MueveStock && Registro.HayStock() == false) {
                                        Lui.Forms.YesNoDialog OPregunta = new Lui.Forms.YesNoDialog("Las existencias actuales no son suficientes para cubrir la operación que intenta realizar.\n¿Desea continuar de todos modos?", "No hay existencias suficientes");
                                        OPregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                        if (OPregunta.ShowDialog() == DialogResult.Cancel)
                                                return new Lfx.Types.OperationResult(false, "No se imprimir el comprobante por falta de existencias.");
                                }

                                if (Registro.Cliente.Id != 999 && (Registro.Tipo.EsFactura || Registro.Tipo.EsNotaDebito)) {
                                        if (Registro.FormaDePago != null && Registro.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.CuentaCorriente) {
                                                double LimiteCredito = Registro.Cliente.LimiteCredito;

                                                if (LimiteCredito == 0)
                                                        LimiteCredito = Lfx.Types.Parsing.ParseCurrency(this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Cuentas.LimiteCreditoPredet", "0"));

                                                double Saldo = Registro.Cliente.CuentaCorriente.Saldo();
                                                if ((Registro.Total + Saldo) > LimiteCredito)
                                                        return new Lfx.Types.OperationResult(false, "El valor de la factura y/o el saldo en cuenta corriente supera el Límite de Crédito de este cliente.");
                                        } else {
                                                if (Registro.Cliente.CuentaCorriente.Saldo() < 0) {
                                                        SaldoEnCuentaCorriente FormularioError = new SaldoEnCuentaCorriente();

                                                        switch (FormularioError.ShowDialog()) {
                                                                case DialogResult.Yes:
                                                                        //Corregir el problema
                                                                        this.EntradaFormaPago.TextInt = 3;
                                                                        Registro.FormaDePago.Tipo = Lbl.Pagos.TipoFormasDePago.CuentaCorriente;
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
                                        

                                this.Save();
                                Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                                Lfx.Types.OperationResult Res = base.Print(selectPrinter);

                                if (Res.Success) {
                                        if (Registro.FormaDePago.Tipo != Lbl.Pagos.TipoFormasDePago.Efectivo && Registro.FormaDePago.Tipo != Lbl.Pagos.TipoFormasDePago.CuentaCorriente) {
                                                //Muestro una ventana de progreso de impresión (salvo para pagos en efectivo y cta. cte, en cuyo caso no necesito esperar que finalice la impresión)
                                                Lui.Forms.ProgressForm Progreso = new Lui.Forms.ProgressForm();
                                                Progreso.Titulo = "Imprimiendo...";
                                                Progreso.Operacion = "Aguarde mientras se imprime el comprobante.";
                                                Progreso.ProgressBar.Style = ProgressBarStyle.Marquee;
                                                Progreso.Show();
                                                while (true) {
                                                        System.DateTime FinEspera = System.DateTime.Now.AddSeconds(90);

                                                        //Espero hasta que la factura está impresa o hasta que pasen X segundos
                                                        while (System.DateTime.Now < FinEspera && Registro.DataBase.FieldInt("SELECT numero FROM comprob WHERE id_comprob=" + this.CachedRow.Id.ToString()) == 0) {
                                                                Lfx.Environment.Threading.Sleep(1000, true);
                                                        }
                                                        int Numero = Registro.DataBase.FieldInt("SELECT numero FROM comprob WHERE impresa<>0 AND id_comprob=" + this.CachedRow.Id);
                                                        if (Numero == 0) {
                                                                //Dió un timeout y no se imprimió.
                                                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("El servidor fiscal está demorando mucho para imprimir el comprobante. Debe asegurarse de que el servidor fiscal está cargado y configurado correctamente.", "¿Desea seguir esperando?");
                                                                Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                                                if (Pregunta.ShowDialog() == DialogResult.Cancel) {
                                                                        Progreso.Dispose();
                                                                        return new Lfx.Types.FailureOperationResult("Se terminó el tiempo de espera y el Servidor Fiscal no terminó de imprimir el comprobante. Si fuera necesario intente imprimir el comprobante nuevamente.");
                                                                }
                                                                Pregunta.Dispose();
                                                                Pregunta = null;
                                                        } else {
                                                                break;
                                                        }
                                                }
                                                Progreso.Dispose();
                                        }
                                        Registro.Cargar();
                                        PrintButton.Visible = false;
                                        BotonPago.Visible = EsCancelable();
                                        switch (Registro.FormaDePago.Tipo) {
                                                case Lbl.Pagos.TipoFormasDePago.Efectivo:
                                                        //El pago lo asentó la rutina de impresión
                                                        //EditarPago();
                                                        //Yo sólo muestro la ventanita de calcular el cambio
                                                        BotonPago.Visible = EsCancelable();
                                                        Comprobantes.PagoVuelto OFormVuelto = new Comprobantes.PagoVuelto();
                                                        OFormVuelto.Total = Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text);
                                                        OFormVuelto.ShowDialog();
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.ChequePropio:
                                                        EditarPago(false);
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.CuentaCorriente:
                                                        //El pago lo asentó la rutina de impresión
                                                        //EditarPago();
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.Tarjeta:
                                                        EditarPago(false);
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.Caja:
                                                        EditarPago(false);
                                                        break;
                                        }
                                }
                                return Res;
                        }
                }

		private void EntradaTipo_TextChanged(object sender, System.EventArgs e)
		{
                        this.Tipo = new Lbl.Comprobantes.Tipo(this.CachedRow.DataBase, EntradaTipo.TextKey);
		}

		private void BotonPago_Click(object sender, System.EventArgs e)
		{
			EditarPago(false);
		}

		private void FormFacturaEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyCode) {
				case Keys.F2:
					e.Handled = true;
                                        if (BotonPago.Visible && BotonPago.Enabled)
                                                EditarPago(e.Shift);
					break;
			}
		}

                private Lfx.Types.OperationResult EditarPago(bool PasarACtaCte)
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Factura = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (Factura.ImporteCancelado >= Factura.Total)
                                return new Lfx.Types.FailureOperationResult("Este comprobante ya fue cancelado en su totalidad.");

                        if (Factura.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.CuentaCorriente) {
                                CrearReciboParaEstaFactura();
                        } else {
                                Comprobantes.Recibos.EditarCobro FormularioEditarPago = new Comprobantes.Recibos.EditarCobro();
                                FormularioEditarPago.Cobro.FromCobro(new Lbl.Comprobantes.Cobro(this.DataBase, Factura.FormaDePago));
                                FormularioEditarPago.Cobro.FormaDePagoEditable = true;
                                FormularioEditarPago.Cobro.Importe = Factura.Total;
                                FormularioEditarPago.Cobro.ImporteVisible = true;
                                FormularioEditarPago.Cobro.ImporteEditable = false;
                                if (FormularioEditarPago.ShowDialog() == DialogResult.OK) {
                                        Lbl.Comprobantes.Cobro MiCobro = FormularioEditarPago.Cobro.ToCobro(Factura.DataBase);
                                        if (MiCobro.FormaDePago.Id != Factura.FormaDePago.Id) {
                                                // Tengo que actualizar la forma de pago
                                                Factura.DataBase.BeginTransaction();
                                                Factura.FormaDePago = MiCobro.FormaDePago;
                                                EntradaFormaPago.TextInt = MiCobro.Id;
                                                Factura.DataBase.FieldInt("UPDATE comprob SET id_formapago=" + MiCobro.FormaDePago.Id.ToString() + " WHERE id_comprob=" + Factura.Id.ToString());
                                                if (MiCobro.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.CuentaCorriente) {
                                                        // Si la nueva forma de pago es cta. cte., asiento el saldo
                                                        // Y uso saldo a favor, si lo hay
                                                        double Saldo = Factura.Cliente.CuentaCorriente.Saldo();
                                                        Factura.Cliente.CuentaCorriente.Movimiento(true, 11000, "Saldo a Cta. Cte. s/" + Factura.ToString(), Factura.ImporteImpago, "", Factura.Id, 0, false);
                                                        if (Saldo < 0) {
                                                                Saldo = Math.Abs(Saldo);
                                                                if (Saldo > Factura.Total)
                                                                        Factura.CancelarImporte(Factura.Total);
                                                                else
                                                                        Factura.CancelarImporte(Saldo);
                                                        }
                                                }
                                                Factura.DataBase.Commit();
                                        }
                                        switch (Factura.FormaDePago.Tipo) {
                                                case Lbl.Pagos.TipoFormasDePago.Efectivo:
                                                        Factura.DataBase.BeginTransaction();
                                                        Lbl.Cajas.Caja CajaDiaria = new Lbl.Cajas.Caja(Factura.DataBase, Lfx.Workspace.Master.CurrentConfig.Empresa.CajaDiaria);
                                                        CajaDiaria.Movimiento(true, new Lbl.Cajas.Concepto(Factura.DataBase, 11000), Factura.ToString(), Factura.Cliente, Factura.ImporteImpago, Factura.Obs, Factura, null, null);
                                                        Factura.DataBase.Execute("UPDATE comprob SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Factura.Total) + " WHERE id_comprob=" + Factura.Id.ToString());
                                                        Factura.DataBase.Commit();
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.CuentaCorriente:
                                                        CrearReciboParaEstaFactura();
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.ChequeTerceros:
                                                        Factura.DataBase.BeginTransaction();
                                                        Lbl.Bancos.Cheque Cheque = MiCobro.Cheque;
                                                        Cheque.Concepto = new Lbl.Cajas.Concepto(Factura.DataBase, 11000);
                                                        Cheque.ConceptoTexto = "Cobro s/" + this.CachedRow.ToString();
                                                        Cheque.Factura = Factura;
                                                        Cheque.Guardar();
                                                        Factura.DataBase.Execute("UPDATE comprob SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Factura.Total) + " WHERE id_comprob=" + Factura.Id.ToString());
                                                        Factura.DataBase.Commit();
                                                        BotonPago.Visible = false;
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.Tarjeta:
                                                        Factura.DataBase.BeginTransaction();
                                                        Lbl.Cupones.Cupon CuponCredito = MiCobro.Cupon;
                                                        CuponCredito.Concepto = new Lbl.Cajas.Concepto(Factura.DataBase, 11000);
                                                        CuponCredito.ConceptoTexto = "Cobro s/" + Factura.ToString();

                                                        if (EntradaVendedor.TextInt > 0)
                                                                CuponCredito.Vendedor = new Lbl.Personas.Persona(Factura.DataBase, EntradaVendedor.TextInt);

                                                        CuponCredito.Factura = Factura;
                                                        CuponCredito.Guardar();

                                                        Factura.DataBase.Execute("UPDATE comprob SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Factura.Total) + " WHERE id_comprob=" + Factura.Id.ToString());
                                                        Factura.DataBase.Commit();
                                                        BotonPago.Visible = false;
                                                        break;
                                                case Lbl.Pagos.TipoFormasDePago.Caja:
                                                        Factura.DataBase.BeginTransaction();
                                                        Lbl.Cajas.Caja CajaDeposito = MiCobro.CajaDestino;
                                                        CajaDeposito.Movimiento(true, new Lbl.Cajas.Concepto(Factura.DataBase, 11000), "Cobro s/" + Factura.ToString(), Factura.Cliente, MiCobro.Importe, MiCobro.Obs, Factura, null, null);
                                                        Factura.DataBase.Execute("UPDATE comprob SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Factura.Total) + " WHERE id_comprob=" + Factura.Id.ToString());
                                                        Factura.DataBase.Commit();
                                                        BotonPago.Visible = false;
                                                        break;
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
                        Lbl.Comprobantes.ComprobanteConArticulos Factura = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        Comprobantes.Recibos.Editar ReciboNuevo = new Comprobantes.Recibos.Editar();
                        ReciboNuevo.MdiParent = this.MdiParent;
                        ReciboNuevo.Create();
                        ReciboNuevo.AgregarFactura(this.CachedRow.Id);
                        ReciboNuevo.EntradaConceptoTexto.Text = "Cancelación de " + Factura.ToString();
                        ReciboNuevo.EntradaConceptoTexto.ReadOnly = true;
                        ReciboNuevo.EntradaConceptoTexto.TabStop = false;
                        ReciboNuevo.EntradaConcepto.TextInt = 11000;
                        ReciboNuevo.EntradaConcepto.ReadOnly = true;
                        ReciboNuevo.EntradaConcepto.TabStop = false;
                        ReciboNuevo.Show();
                }

		internal bool EsCancelable()
		{
                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro == null || Registro.ImporteImpago == 0) {
                                return false;
                        } else {
                                return (Registro.Impreso && Registro.Existe && (Registro.FormaDePago.Tipo != Lbl.Pagos.TipoFormasDePago.Efectivo));
                        }
		}


		private void EntradaRemito_TextChanged(object sender, System.EventArgs e)
		{
			int RemitoId = Lfx.Types.Parsing.ParseInt(EntradaRemito.Text);
			if(RemitoId > 0) {
				Lfx.Data.Row Remito = this.DataBase.FirstRowFromSelect("SELECT * FROM comprob WHERE tipo_fac='R' AND numero=" + RemitoId.ToString() + " AND impresa>0 AND anulada=0");
				if(Remito == null)
					ProductArray.ShowStock = true;
				else
					ProductArray.ShowStock = false;
			} else {
				ProductArray.ShowStock = true;
			}
		}


		private void EntradaFormaPago_Leave(object sender, System.EventArgs e)
		{
			if(EntradaFormaPago.TextInt == 99)
				EntradaFormaPago.TextInt = 3;
                        if (EntradaFormaPago.TextInt == 5)
                                EntradaFormaPago.TextInt = 4;
		}

		private void Editar_Activated(object sender, System.EventArgs e)
		{
			if(EntradaCliente.TextInt > 0 && EntradaFormaPago.TextInt > 0)
				ProductArray.Focus();
			else if(EntradaCliente.TextInt > 0)
				EntradaFormaPago.Focus();
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
                                PnlFormaPago.Visible = value.EsFactura || value.EsTicket;
                                if (EntradaTipo.TextKey != value.Nomenclatura)
                                        EntradaTipo.TextKey = value.Nomenclatura;
                        }
                }
	}
}