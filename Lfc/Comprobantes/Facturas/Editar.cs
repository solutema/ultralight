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
                public Editar(string tipo) : this()
                {
                        TipoPredet = tipo;
                }

		public Editar() : base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
		}

		public override Lfx.Types.OperationResult ValidateData()
		{
			Lfx.Types.OperationResult validarReturn = base.ValidateData();

			if(validarReturn.Success == true) {
                                Lbl.Comprobantes.ComprobanteConArticulos Registro = this.ToRow() as Lbl.Comprobantes.ComprobanteConArticulos;

				if(Registro.NumeroRemito > 0) {
                                        Lfx.Data.Row Remito = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT * FROM facturas WHERE tipo_fac='R' AND numero=" + Registro.NumeroRemito.ToString() + " AND impresa>0 AND anulada=0");
					if(Remito == null) {
						validarReturn.Success = false;
						validarReturn.Message += "El número de Remito no es válido." + Environment.NewLine;
					}
				}

                                if (Registro.FormaDePago == Lbl.Comprobantes.FormasDePago.CuentaCorriente && Registro.Cliente != null && Registro.Cliente.Id == 999) {
					validarReturn.Success = false;
					validarReturn.Message += @"""Consumidor Final"" no puede realizar Pagos Compuestos ni en Cuenta Corriente." + Environment.NewLine;
				}

				if(Registro.FormaDePago == Lbl.Comprobantes.FormasDePago.Ninguna && Registro.Tipo.EsFactura) {
					validarReturn.Success = false;
					validarReturn.Message += "Debe especificar la Forma de Pago." + Environment.NewLine;
				}

                                if (Registro.Cliente.SituacionTributaria != null && (Registro.Cliente.SituacionTributaria.Id == 2 || Registro.Cliente.SituacionTributaria.Id == 3)) {
                                        if (Lfx.Types.Strings.ValidCUIT(Registro.Cliente.CUIT) == false) {
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
                                        "Factura A|A",
                                        "Factura B|B",
                                        "Factura C|C",
                                        "Factura M|M",
                                        "Factura E|E",
                                        "Ticket|T"
                                };
                                EntradaFormaPago.TextInt = ((int)(Res.FormaDePago));
                                EntradaFormaPago.Visible = true;
                        }
                        else if (this.Tipo.EsNotaCredito || this.Tipo.EsNotaDebito)
                        {
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
                                Res.FormaDePago = (Lbl.Comprobantes.FormasDePago)EntradaFormaPago.TextInt;
                        else
                                Res.FormaDePago = Lbl.Comprobantes.FormasDePago.Ninguna;
                        Res.NumeroRemito = Lfx.Types.Parsing.ParseInt(EntradaRemito.Text);

                        return Res;
                }

		public override bool ReadOnly
		{
			get
			{
                                return base.ReadOnly;
			}
			set
			{
                                base.ReadOnly = value;
			}
		}

		public override Lfx.Types.OperationResult Edit(int iId)
		{
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "documents.write") == false)
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
                        Registro.FormaDePago = (Lbl.Comprobantes.FormasDePago)(this.Workspace.CurrentConfig.ReadGlobalSettingInt(null, "Sistema.Documentos.FormaPagoPredet", 0));
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

                                if (Registro.Tipo.EsFacturaNCoND && Registro.Tipo.LetraSola != Registro.Cliente.TipoComprobantePredeterminado()) {
                                        Lui.Forms.YesNoDialog OPregunta = new Lui.Forms.YesNoDialog(@"La situación tributaria del cliente y el tipo de comprobante no se corresponden.
Un cliente " + Registro.Cliente.SituacionTributaria.ToString() + @" debería llevar un comprobante tipo " + Registro.Cliente.TipoComprobantePredeterminado() + @". No debería continuar con la impresión. 
¿Desea continuar de todos modos?", "Tipo de comprobante incorrecto");
                                        OPregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                        if (OPregunta.ShowDialog() == DialogResult.Cancel)
                                                return new Lfx.Types.OperationResult(false, "Corrija la Situación Tributaria del Cliente o el Tipo de Comprobante.");
                                }

                                if (Registro.Tipo.LetraSola.ToUpperInvariant() == "A") {
                                        if (Registro.Cliente.CUIT.Length < 5)
                                                return new Lfx.Types.OperationResult(false, @"Debe proporcionar el número de CUIT del cliente.");
                                } else if (Registro.Tipo.LetraSola.ToUpperInvariant() == "B") {
                                        //Si es factura B de más de $ 1000, debe llevar el Nº de DNI
                                        if (Registro.Total >= 1000 && Registro.Cliente.NumeroDocumento.Length < 5 && Registro.Cliente.CUIT.Length < 5)
                                                return new Lfx.Types.OperationResult(false, @"Para facturas tipo ""B"" de $ 1.000 o más, debe proporcionar el número de DNI del cliente.");
                                }

                                if (ProductArray.ShowStock && this.Tipo.MueveStock && Registro.HayStock() == false) {
                                        Lui.Forms.YesNoDialog OPregunta = new Lui.Forms.YesNoDialog("Las existencias actuales no son suficientes para cubrir la operación que intenta realizar.\n¿Desea continuar de todos modos?", "No hay existencias suficientes");
                                        OPregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;
                                        if (OPregunta.ShowDialog() == DialogResult.Cancel)
                                                return new Lfx.Types.OperationResult(false, "No se imprimir el comprobante por falta de existencias.");
                                }

                                if (Registro.Cliente.Id != 999 && Registro.FormaDePago == Lbl.Comprobantes.FormasDePago.CuentaCorriente && (Registro.Tipo.EsFactura || Registro.Tipo.EsNotaDebito)) {
                                        double LimiteCredito = Registro.Cliente.LimiteCredito;
                                        Lbl.Cuentas.CuentaCorriente CtaCte = new Lbl.Cuentas.CuentaCorriente(Registro.DataView, Registro.Cliente.Id);

                                        if (LimiteCredito == 0)
                                                LimiteCredito = Lfx.Types.Parsing.ParseCurrency(this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Cuentas.LimiteCreditoPredet", "0"));

                                        double Saldo = CtaCte.Saldo();
                                        if ((Registro.Total + Saldo) > LimiteCredito)
                                                return new Lfx.Types.OperationResult(false, "El valor de la factura y/o el saldo en cuenta corriente supera el Límite de Crédito de este cliente.");
                                }

                                this.Save();
                                Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                                Lfx.Types.OperationResult Res = base.Print(selectPrinter);

                                if (Res.Success) {
                                        if (Registro.FormaDePago != Lbl.Comprobantes.FormasDePago.Efectivo && Registro.FormaDePago != Lbl.Comprobantes.FormasDePago.CuentaCorriente) {
                                                //Muestro una ventana de progreso de impresión (salvo para pagos en efectivo y cta. cte, en cuyo caso no necesito esperar que finalice la impresión)
                                                Lui.Forms.ProgressForm Progreso = new Lui.Forms.ProgressForm();
                                                Progreso.Titulo = "Imprimiendo...";
                                                Progreso.Operacion = "Aguarde mientras se imprime el comprobante.";
                                                Progreso.ProgressBar.Style = ProgressBarStyle.Marquee;
                                                Progreso.Show();
                                                while (true) {
                                                        System.DateTime FinEspera = System.DateTime.Now.AddSeconds(90);

                                                        //Espero hasta que la factura está impresa o hasta que pasen X segundos
                                                        while (System.DateTime.Now < FinEspera && Registro.DataView.DataBase.FieldInt("SELECT numero FROM facturas WHERE id_factura=" + this.CachedRow.Id.ToString()) == 0) {
                                                                Lfx.Environment.Threading.Sleep(1000, true);
                                                        }
                                                        int Numero = Registro.DataView.DataBase.FieldInt("SELECT numero FROM facturas WHERE impresa<>0 AND id_factura=" + this.CachedRow.Id);
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
                                        switch (Registro.FormaDePago) {
                                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                                        //El pago lo asentó la rutina de impresión
                                                        //EditarPago();
                                                        //Yo sólo muestro la ventanita de calcular el cambio
                                                        BotonPago.Visible = EsCancelable();
                                                        Comprobantes.PagoVuelto OFormVuelto = new Comprobantes.PagoVuelto();
                                                        OFormVuelto.Workspace = this.Workspace;
                                                        OFormVuelto.Total = Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text);
                                                        OFormVuelto.ShowDialog();
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                                        EditarPago(false);
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                                        //El pago lo asentó la rutina de impresión
                                                        //EditarPago();
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                                        EditarPago(false);
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                                        EditarPago(false);
                                                        break;
                                                case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                                        EditarPago(false);
                                                        break;
                                        }
                                }
                                return Res;
                        }
                }

		private void EntradaTipo_TextChanged(object sender, System.EventArgs e)
		{
                        this.Tipo = new Lbl.Comprobantes.Tipo(this.CachedRow.DataView, EntradaTipo.TextKey);
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

                        if (PasarACtaCte && this.CachedRow.Existe && Factura.ImporteCancelado < Factura.Total && Factura.FormaDePago != Lbl.Comprobantes.FormasDePago.CuentaCorriente) {
                                Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("¿Desea pasar el saldo impago de esta factura a Cuenta Corriente?", "Pasar a cuenta corriente");
                                if (Pregunta.ShowDialog() == DialogResult.OK) {
                                        Factura.DataView.BeginTransaction();
                                        Factura.FormaDePago = Lbl.Comprobantes.FormasDePago.CuentaCorriente;
                                        EntradaFormaPago.TextInt = 3;
                                        Factura.DataView.DataBase.FieldInt("UPDATE facturas SET id_formapago=3 WHERE id_factura=" + this.CachedRow.Id.ToString());
                                        Lbl.Cuentas.CuentaCorriente Cta = Factura.Cliente.CuentaCorriente;
                                        Cta.Movimiento(true, 11000, "Saldo a Cta. Cte. s/" + Factura.ToString(), Factura.ImporteImpago, "", Factura.Id, 0, false);
                                        Factura.DataView.Commit();
                                        return new Lfx.Types.SuccessOperationResult();
                                } else {
                                        return new Lfx.Types.CancelOperationResult();
                                }
                        }
                        
			switch(EntradaFormaPago.TextInt) {
				case 1:
				case 3:
				case 99:
					Lui.Forms.MessageBox.Show("Se va a crear un recibo para asentar el pago de esta factura.", "Aviso");
					Comprobantes.Recibos.Editar ReciboNuevo = new Comprobantes.Recibos.Editar();
					ReciboNuevo.Workspace = this.Workspace;
                                        ReciboNuevo.MdiParent = this.MdiParent;
                                        ReciboNuevo.Create();
                                        ReciboNuevo.AgregarFactura(this.CachedRow.Id);
                                        ReciboNuevo.EntradaConceptoTexto.Text = "Cancelación de " + Factura.ToString();
                                        ReciboNuevo.EntradaConceptoTexto.ReadOnly = true;
                                        ReciboNuevo.EntradaConceptoTexto.TabStop = false;
                                        ReciboNuevo.Show();
					break;
				case 2:
				case 4:
				case 5:
				case 6:
                                        Lbl.Comprobantes.FormasDePago FormaPago = ((Lbl.Comprobantes.FormasDePago)(Lfx.Types.Parsing.ParseInt(EntradaFormaPago.Text)));

					Comprobantes.Recibos.EditarCobro FormularioEditarPago = new Comprobantes.Recibos.EditarCobro();
					FormularioEditarPago.Workspace = this.Workspace;
					FormularioEditarPago.Cobro.FromCobro(new Lbl.Comprobantes.Cobro(this.DataView, FormaPago));
                                        FormularioEditarPago.Cobro.FormaDePagoEditable = false;
                                        FormularioEditarPago.Cobro.Importe = Factura.Total;
                                        FormularioEditarPago.Cobro.ImporteVisible = true;
                                        FormularioEditarPago.Cobro.ImporteEditable = false;
        				if(FormularioEditarPago.ShowDialog() == DialogResult.OK) {
                                                Lbl.Comprobantes.Cobro MiCobro = FormularioEditarPago.Cobro.ToCobro(Factura.DataView);
                                                switch (MiCobro.FormaDePago) {
							case Lbl.Comprobantes.FormasDePago.Cheque:
                                                                Factura.DataView.BeginTransaction();
                                                                Lbl.Bancos.Cheque Cheque = MiCobro.Cheque;
                                                                Cheque.Concepto = new Lbl.Cuentas.Concepto(Factura.DataView, 11000);
                                                                Cheque.ConceptoTexto = "Cobro s/" + this.CachedRow.ToString();
                                                                Cheque.Factura = Factura;
                                                                Cheque.Guardar();

                                                                //Esto ahora lo hace Cheque.Guardar()
                                                                //Lbl.Cuentas.CuentaRegular CuentaCheques = new Lbl.Cuentas.CuentaRegular(Factura.DataView, this.Workspace.CurrentConfig.Company.CuentaCheques);
                                                                //CuentaCheques.Movimiento(true, 11000, "Cobro s/" + this.CachedRow.ToString(), 0, Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text), "Cheque Nº " + MiCobro.Cheque.Numero, this.CachedRow.Id, 0, "");
                                                                Factura.DataView.DataBase.Execute("UPDATE facturas SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text)) + " WHERE id_factura=" + this.CachedRow.Id.ToString());
                                                                Factura.DataView.Commit();
								BotonPago.Visible = false;
								break;
							case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                                        case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                                                Factura.DataView.BeginTransaction();
                                                                Lbl.Tarjetas.Cupon CuponCredito = MiCobro.Cupon;
                                                                CuponCredito.Concepto = new Lbl.Cuentas.Concepto(Factura.DataView, 11000);
                                                                CuponCredito.ConceptoTexto = "Cobro s/" + this.CachedRow.ToString();
                                                                
                                                                if (EntradaVendedor.TextInt > 0)
                                                                        CuponCredito.Vendedor = new Lbl.Personas.Persona(Factura.DataView, EntradaVendedor.TextInt);

                                                                CuponCredito.Factura = Factura;
                                                                CuponCredito.Guardar();

                                                                Factura.DataView.DataBase.Execute("UPDATE facturas SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text)) + " WHERE id_factura=" + this.CachedRow.Id.ToString());
                                                                Factura.DataView.Commit();
								BotonPago.Visible = false;
								break;
							case Lbl.Comprobantes.FormasDePago.CuentaRegular:
                                                                Factura.DataView.BeginTransaction();
                                                                Lbl.Cuentas.CuentaRegular CuentaDeposito = MiCobro.CuentaDestino;
                                                                CuentaDeposito.Movimiento(true, 11000, "Cobro s/" + this.CachedRow.ToString(), EntradaCliente.TextInt, MiCobro.Importe, MiCobro.Obs, this.CachedRow.Id, 0, "");
                                                                Factura.DataView.DataBase.Execute("UPDATE facturas SET cancelado=" + Lfx.Types.Formatting.FormatCurrencySql(Lfx.Types.Parsing.ParseCurrency(EntradaTotal.Text)) + " WHERE id_factura=" + this.CachedRow.Id.ToString());
                                                                Factura.DataView.Commit();
								BotonPago.Visible = false;
								break;
						}

					} else {
						return new Lfx.Types.SuccessOperationResult();
					}
					FormularioEditarPago = null;
					BotonPago.Visible = false;
					break;
				default:
					Lui.Forms.MessageBox.Show("Este tipo de pago no se puede editar.", "Error");
					break;
			}

			return new Lfx.Types.SuccessOperationResult();
		}


		internal bool EsCancelable()
		{
                        Lbl.Comprobantes.ComprobanteConArticulos Registro = this.CachedRow as Lbl.Comprobantes.ComprobanteConArticulos;
                        if (Registro == null || Registro.ImporteImpago == 0) {
                                return false;
                        } else {
                                return (Registro.Impreso && Registro.Existe && (Registro.FormaDePago != Lbl.Comprobantes.FormasDePago.Efectivo));
                        }
		}


		private void EntradaRemito_TextChanged(object sender, System.EventArgs e)
		{
			int RemitoId = Lfx.Types.Parsing.ParseInt(EntradaRemito.Text);
			if(RemitoId > 0) {
				Lfx.Data.Row Remito = this.Workspace.DefaultDataBase.FirstRowFromSelect("SELECT * FROM facturas WHERE tipo_fac='R' AND numero=" + RemitoId.ToString() + " AND impresa>0 AND anulada=0");
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