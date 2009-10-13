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
	public class ComprobanteConArticulos : Comprobante
	{
                private ColeccionDetalleArticulos m_Articulos = null, m_ArticulosOriginales = null;
                private ColeccionRecibos m_Recibos = null;
                
                //Heredar constructor
                public ComprobanteConArticulos(Lws.Data.DataView dataView) : base(dataView) { }

		public ComprobanteConArticulos(Lws.Data.DataView dataView, int idComprobante)
			: this(dataView)
		{
			m_ItemId = idComprobante;
                        this.Cargar();
		}

		public override string TablaDatos
		{
			get
			{
				return "facturas";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_factura";
			}
		}

                public override Lfx.Types.OperationResult Crear()
                {
                        return this.Crear("B");
                }

                public bool Anulado
                {
                        get
                        {
                                return System.Convert.ToBoolean(this.FieldInt("anulada"));
                        }
                }

                public Lfx.Types.OperationResult Crear(string tipo, bool compra)
                {
                        Lfx.Types.OperationResult Res = this.Crear(tipo);
                        if (Res.Success && compra) {
                                this.SituacionDestino = new Lbl.Articulos.Situacion(this.DataView, this.Workspace.CurrentConfig.Products.DepositoPredeterminado);
                                this.SituacionOrigen = new Lbl.Articulos.Situacion(this.DataView, 998); //Proveedor
                                this.Fecha = DateTime.Now;
                        }
                        return Res;
                }

                public Lfx.Types.OperationResult Crear(string tipo)
                {
                        Lfx.Types.OperationResult Res = base.Crear();
                        if (Res.Success) {
                                this.Vendedor = new Lbl.Personas.Persona(this.DataView, this.Workspace.CurrentUser.Id);

                                this.Tipo = new Tipo(this.DataView, tipo);
                                this.Tipo.Cargar();
                                if (this.SituacionOrigen == null)
                                        this.SituacionOrigen = Tipo.SituacionOrigen;
                                if (this.SituacionDestino == null)
                                        this.SituacionDestino = Tipo.SituacionDestino;

                                this.PV = this.DataView.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos." + Tipo.Nomenclatura + ".PV", 0);
                                if (this.PV /* still */ == 0) {
                                        if(Tipo.EsFactura)
                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.ABC.PV", 0);
                                        else if (Tipo.EsNotaCredito)
                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.NC.PV", 0);
                                        else if (Tipo.EsNotaDebito)
                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.ND.PV", 0);
                                }
                                if (this.PV /* still */ == 0)
                                        this.PV = this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.PV", 1);
                        }
                        return Res;
                }

                public void Anular()
                {
                        this.Anular(true);
                }

                public void Anular(bool anularPagos)
                {
                        if (this.Anulado)
                                return;

                        if (this.Tipo.EsNotaDebito) {
                                Lbl.Cuentas.CuentaCorriente CtaCteDeb = new Lbl.Cuentas.CuentaCorriente(DataView, this.Cliente.Id);
                                CtaCteDeb.Movimiento(true, 11000, "Anulación Comprob. " + this.ToString(), -this.Total, "", this.Id, 0, true);
                        } else if (this.Tipo.EsNotaCredito) {
                                Lbl.Cuentas.CuentaCorriente CtaCteCred = new Lbl.Cuentas.CuentaCorriente(DataView, this.Cliente.Id);
                                CtaCteCred.Movimiento(true, 11000, "Anulación Comprob. " + this.ToString(), this.Total, "", this.Id, 0, true);
                        } else if (this.Tipo.EsFactura) {
                                Lbl.Articulos.Stock.MoverStockFactura(this, false);
                                if (anularPagos) {
                                        switch (this.FormaDePago) {
                                                case Lbl.Comprobantes.FormasDePago.Efectivo:
                                                        // Hago un egreso de caja
                                                        Lbl.Cuentas.CuentaRegular Caja = new Lbl.Cuentas.CuentaRegular(DataView, this.Workspace.CurrentConfig.Company.CajaDiaria);
                                                        Caja.Movimiento(true, 11000, "Anulación Comprob. " + this.ToString(), this.Cliente.Id, -this.ImporteCancelado, "", this.Id, 0, "");
                                                        break;

                                                case Lbl.Comprobantes.FormasDePago.Cheque:
                                                        Lbl.Bancos.Cheque Cheque = new Lbl.Bancos.Cheque(DataView, this);
                                                        if (Cheque != null && Cheque.Existe)
                                                                Cheque.Anular();
                                                        break;

                                                case Lbl.Comprobantes.FormasDePago.CuentaCorriente:
                                                        // Anulo los recibos que se le hayan hecho
                                                        if (this.Recibos != null && this.Recibos.Count > 0) {
                                                                foreach (Recibo Rec in this.Recibos) {
                                                                        Rec.Anular();
                                                                }
                                                        }
                                                        
                                                        if (this.ImporteCancelado < this.Total) {
                                                                // Y quedaba algo por cancelar, anulo ese saldo en la cuenta corriente
                                                                Lbl.Cuentas.CuentaCorriente CtaCteFac = new Lbl.Cuentas.CuentaCorriente(DataView, this.Cliente.Id);
                                                                CtaCteFac.Movimiento(true, new Lbl.Cuentas.Concepto(this.DataView, 11000), "Anulación Comprob. " + this.ToString(), -(this.Total - this.ImporteCancelado), "", this, null, false);
                                                        }
                                                        break;

                                                case Lbl.Comprobantes.FormasDePago.Tarjeta:
                                                case Lbl.Comprobantes.FormasDePago.TarjetaDeDebito:
                                                        Lbl.Tarjetas.Cupon Cupon = new Lbl.Tarjetas.Cupon(DataView, this);
                                                        if (Cupon != null && Cupon.Existe)
                                                                Cupon.Anular();
                                                        break;

                                                case FormasDePago.CuentaRegular:
                                                        // FIXME: deshacer el movimiento?
                                                        break;
                                        }
                                }
                        }

                        // Marco la factura como anulada
                        Lfx.Data.SqlUpdateBuilder Act = new Lfx.Data.SqlUpdateBuilder(this.TablaDatos);
                        Act.Fields.AddWithValue("anulada", 1);
                        Act.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                        this.DataView.Execute(Act);
                }

		public double SubTotal
		{
			get
			{
                                double Res = 0;
                                foreach (DetalleArticulo Art in this.Articulos) {
                                        Res += Art.ImporteFinal;
                                }
				return Res;
			}
		}

		public double Descuento
		{
			get
			{
				return System.Convert.ToDouble(Registro["descuento"]);
			}
                        set
                        {
                                Registro["descuento"] = value;
                        }
		}

		public double Recargo
		{
			get
			{
				return System.Convert.ToDouble(Registro["interes"]);
			}
                        set
                        {
                                Registro["interes"] = value;
                        }
		}

		public double ImporteCancelado
		{
			get
			{
				return System.Convert.ToDouble(Registro["cancelado"]);
			}
			set
			{
				Registro["cancelado"] = value;
			}
		}

                public double GastosDeEnvio
                {
                        get
                        {
                                return System.Convert.ToDouble(Registro["gastosenvio"]);
                        }
                        set
                        {
                                Registro["gastosenvio"] = value;
                        }
                }

                public double OtrosGastos
                {
                        get
                        {
                                return System.Convert.ToDouble(Registro["otrosgastos"]);
                        }
                        set
                        {
                                Registro["otrosgastos"] = value;
                        }
                }

                public Lfx.Types.LDateTime Fecha
		{
			get
			{
                                if (Registro["fecha"] == null || Registro["fecha"] is DBNull)
                                        return null;
                                else
                                        return new Lfx.Types.LDateTime(System.Convert.ToDateTime(Registro["fecha"]));
			}
                        set
                        {
                                if (value != null)
                                        Registro["fecha"] = value.Value;
                                else
                                        Registro["fecha"] = null;
                        }
		}

		public bool Impreso
		{
			get
			{
				return System.Convert.ToBoolean(Registro["impresa"]);
			}
                        set
                        {
                                Registro["impresa"] = value ? 1 : 0;
                        }
		}

		public bool Compra
		{
			get
			{
				return System.Convert.ToBoolean(Registro["compra"]);
			}
                        set
                        {
                                Registro["compra"] = value ? 1 : 0;
                        }
		}

		public int PV
		{
			get
			{
				return System.Convert.ToInt32(Registro["pv"]);
			}
			set
			{
				//this.DataView.DataBase.Execute("UPDATE facturas SET pv=" + value + " WHERE id_factura=" + this.Id.ToString());
				Registro["pv"] = value;
			}
		}

                public int Cuotas
                {
                        get
                        {
                                return System.Convert.ToInt32(Registro["cuotas"]);
                        }
                        set
                        {
                                Registro["cuotas"] = value;
                        }
                }

                public double ImporteImpago
                {
                        get
                        {
                                return this.Total - this.ImporteCancelado;
                        }
                }

                public double Total
                {
                        get
                        {
                                double Redondeo = this.Workspace.CurrentConfig.Currency.Rounding;
                                if (Redondeo == 0)
                                        return Lfx.Types.Currency.Truncate(this.TotalReal, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                else
                                        return Lfx.Types.Currency.Truncate(Math.Floor(this.TotalReal / Redondeo) * Redondeo, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        }
                }

                public double TotalReal
                {
                        get
                        {
                                double Res = 0;
                                foreach (Lbl.Comprobantes.DetalleArticulo Art in Articulos) {
                                        Res += Art.ImporteFinal;
                                }
                                return Res * (1 + (Recargo - Descuento) / 100) + this.GastosDeEnvio + this.OtrosGastos;
                        }
                }

		internal void Numerar()
		{
                        if (this.Numero == 0) {
                                int NumeroNuevo = Numerador.Numerar(this.DataView, this);
                                Registro["numero"] = NumeroNuevo;
                                Registro["fecha"] = System.DateTime.Now;
                        }
		}

		public FormasDePago FormaDePago
		{
			get
			{
                                if (this.FieldInt("id_formapago") == 0)
                                        return FormasDePago.Ninguna;
                                else
                                        return (FormasDePago)(this.FieldInt("id_formapago"));
			}
			set
			{
				this.Registro["id_formapago"] = (int)value;
			}
		}

		public int NumeroRemito
		{
			get
			{
				return this.FieldInt("remito");
			}
                        set
                        {
                                this.Registro["remito"] = value;
                        }
		}


		public bool HayStock()
		{
			//Verifica si hay suficiente stock para el comprobante
			if (this.Articulos != null)
			{
				foreach (Comprobantes.DetalleArticulo Det in this.Articulos)
				{
					if(Det.Id > 0 && Det.Articulo != null && Det.Articulo.ControlaStock && Det.Articulo.StockActual() < Det.Cantidad)
						return false;
				}
			}
			return true;
		}

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                Vendedor = new Personas.Persona(this.DataView, System.Convert.ToInt32(m_Registro["id_vendedor"]));
                                if (this.FieldInt("id_cliente") > 0)
                                        Cliente = new Personas.Persona(this.DataView, this.FieldInt("id_cliente"));
                                if (m_Registro["situacionorigen"] != null)
                                        SituacionOrigen = new Articulos.Situacion(this.DataView, System.Convert.ToInt32(m_Registro["situacionorigen"]));
                                if (m_Registro["situaciondestino"] != null)
                                        SituacionDestino = new Articulos.Situacion(this.DataView, System.Convert.ToInt32(m_Registro["situaciondestino"]));
                                this.m_ArticulosOriginales = this.Articulos.Clone();
                        }
                        base.OnLoad();
                }

                public ColeccionDetalleArticulos Articulos
		{
			get
			{
				if (m_Articulos == null)
				{
                                        m_Articulos = new ColeccionDetalleArticulos();
                                        if (this.Existe) {
                                                System.Data.DataTable Arts = this.DataView.DataBase.Select("SELECT id_factura_detalle, id_articulo, orden, cantidad, precio, costo, nombre, descripcion FROM facturas_detalle WHERE id_factura=" + this.Id.ToString());
                                                foreach (System.Data.DataRow Art in Arts.Rows) {
                                                        Comprobantes.DetalleArticulo DetArt = new DetalleArticulo(this.DataView, System.Convert.ToInt32(Art["id_factura_detalle"]));
                                                        DetArt.IdArticulo = Lfx.Data.DataBase.ConvertDBNullToZero(Art["id_articulo"]);
                                                        DetArt.Orden = System.Convert.ToInt32(Art["orden"]);
                                                        DetArt.Cantidad = System.Convert.ToDouble(Art["cantidad"]);
                                                        DetArt.Unitario = System.Convert.ToDouble(Art["precio"]);
                                                        DetArt.Costo = System.Convert.ToDouble(Art["costo"]);
                                                        DetArt.Nombre = Art["nombre"].ToString();
                                                        DetArt.Descripcion = Art["descripcion"].ToString();
                                                        m_Articulos.Add(DetArt);
                                                }
                                        }
				}
				return m_Articulos;
			}
		}

                public ColeccionRecibos Recibos
                {
                        get
                        {
                                if (m_Recibos == null || m_Recibos.Count == 0) {
                                        m_Recibos = new ColeccionRecibos();
                                        if (this.Existe) {
                                                System.Data.DataTable Recs = this.DataView.DataBase.Select("SELECT id_recibo FROM recibos_facturas WHERE id_factura=" + this.Id.ToString());
                                                foreach (System.Data.DataRow Rec in Recs.Rows) {
                                                        m_Recibos.Add(new Recibo(DataView, System.Convert.ToInt32(Rec["id_recibo"])));
                                                }
                                        }
                                }
                                return m_Recibos;
                        }
                }

		public Lfx.Types.OperationResult CancelarImporte(double importe)
		{
			if(this.ImporteCancelado + importe > this.Total)
				throw new InvalidOperationException("ComprobanteConArticulos.CancelarImporte: El importe a cancelar no puede ser mayor que el saldo impago");
			this.ImporteCancelado += importe;
			Lfx.Data.SqlUpdateBuilder Actualizar = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, "facturas", "id_factura=" + this.Id.ToString());
			Actualizar.Fields.AddWithValue("cancelado", this.ImporteCancelado);
			this.DataView.Execute(Actualizar);
			return new Lfx.Types.SuccessOperationResult();
		}

		public override Lfx.Types.OperationResult Imprimir(string impresoraPreferida)
		{
			if (this.Impreso && this.Numero > 0 && this.Tipo.PermiteImprimirVariasVeces == false)
				return new Lfx.Types.FailureOperationResult("El comprobante ya fue impreso.");

                        if (this.Tipo.MueveStock && this.Compra == false) {
                                // Comprobantes de venta mueven stock al imprimir
                                Lfx.Types.OperationResult Res = this.VerificarSeries();
                                if (Res.Success == false)
                                        return Res;
                        }

			// Busco el punto de venta para este tipo de comprobante en particular
			if (this.PV == 0)
                                this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos." + this.Tipo + ".PV", 0);

                        if (this.PV == 0) {
                                // No hay nada definido. Busco el PV para el tipo de comprobante más general
                                if (this.Tipo.EsNotaCredito) {
                                        this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.NC.PV", 0);
                                } else if (this.Tipo.EsNotaDebito) {
                                        this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.ND.PV", 0);
                                } else if (this.Tipo.EsFactura) {
                                        this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.ABC.PV", 0);
                                } else if (this.Tipo.EsRemito) {
                                        this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.ABC.PV", 0);
                                } else {
                                        this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos." + this.Tipo.Nomenclatura + ".PV", 0);
                                }

                                if (this.PV == 0) {
                                        // No hay nada definido. Busco el PV predeterminado para cualquier tipo de comprobante
                                        this.PV = Workspace.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.PV", 1);
                                }
                        }

			this.Guardar();

			// Busco el modo de impresión para ese PV (normal o fiscal)
			int ModoImpresion = this.DataView.DataBase.FieldInt("SELECT tipo FROM pvs WHERE id_pv=" + this.PV.ToString());

			// Resumen: De manera predeterminada, se imprime todo en el PV 1, con impresión "normal"
			switch (ModoImpresion)
			{
				case 2:
					// Impresión mediante controlador fiscal
					Workspace.DefaultScheduler.AddTask("IMPRIMIR " + this.Id.ToString(), "fiscal" + this.PV.ToString(), "*");
					break;

				default:
					// Impresión "normal" o manual
				        Impresion.ImpresorComprobanteConArticulos Impresor = new Impresion.ImpresorComprobanteConArticulos(this);
				        return Impresor.Imprimir(impresoraPreferida);
			}

			return new Lfx.Types.SuccessOperationResult();
		}

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success) {
                                if (Registro["situacionorigen"] == null)
                                        SituacionOrigen = null;
                                else
                                        SituacionOrigen = new Lbl.Articulos.Situacion(this.DataView, System.Convert.ToInt32(Registro["situacionorigen"]));

                                if (Registro["situaciondestino"] == null)
                                        SituacionDestino = null;
                                else
                                        SituacionDestino = new Lbl.Articulos.Situacion(this.DataView, System.Convert.ToInt32(Registro["situaciondestino"]));
                        }

                        return Res;
                }

                public override Lfx.Types.OperationResult Guardar()
                {
			Lfx.Data.SqlTableCommandBuilder Comando;

			if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                        } else {
                                Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                        }

                        if (this.Existe == false && this.Numero == 0 && this.Tipo.NumerarAlGuardar) {
                                this.Numerar();
                        }

                        if (this.Fecha == null) {
                                Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                        } else {
                                Comando.Fields.AddWithValue("fecha", this.Fecha);
                        }

                        Comando.Fields.AddWithValue("id_formapago", Lfx.Data.DataBase.ConvertZeroToDBNull(System.Convert.ToInt32(this.FormaDePago)));
                        if (this.Vendedor == null)
                                Comando.Fields.AddWithValue("id_vendedor", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_vendedor", this.Vendedor.Id);
                        if (this.Sucursal == null)
                                Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Company.CurrentBranch);
                        else
                                Comando.Fields.AddWithValue("id_sucursal", this.Sucursal.Id);
                        Comando.Fields.AddWithValue("pv", this.PV);
                        Comando.Fields.AddWithValue("numero", this.Numero);
                        Comando.Fields.AddWithValue("id_cliente", Lfx.Data.DataBase.ConvertZeroToDBNull(this.Cliente.Id));
                        if (this.SituacionOrigen == null)
                                Comando.Fields.AddWithValue("situacionorigen", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("situacionorigen", this.SituacionOrigen.Id);
                        if (this.SituacionDestino == null)
                                Comando.Fields.AddWithValue("situaciondestino", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("situaciondestino", this.SituacionDestino.Id);
                        Comando.Fields.AddWithValue("tipo_fac", this.Tipo.Nomenclatura);
                        Comando.Fields.AddWithValue("subtotal", this.SubTotal);
                        Comando.Fields.AddWithValue("descuento", this.Descuento);
                        Comando.Fields.AddWithValue("interes", this.Recargo);
                        Comando.Fields.AddWithValue("cuotas", this.Cuotas);
                        Comando.Fields.AddWithValue("total", this.Total);
                        Comando.Fields.AddWithValue("totalreal", this.TotalReal);
                        Comando.Fields.AddWithValue("gastosenvio", this.GastosDeEnvio);
                        Comando.Fields.AddWithValue("otrosgastos", this.OtrosGastos);
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        Comando.Fields.AddWithValue("impresa", this.Impreso ? 1 : 0);
                        Comando.Fields.AddWithValue("compra", this.Compra ? 1 : 0);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        Comando.Fields.AddWithValue("series", this.Articulos.Series);

			this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        if (this.Existe == false)
                                this.m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(id_factura) AS id_factura FROM facturas WHERE tipo_fac='" + this.Tipo.Nomenclatura + "'");

                        this.GuardarDetalle();

                        if (this.Compra) {
                                if (this.Tipo.MueveStock) {
                                        // Comprobantes de compra mueven stock al guardar
                                        Lfx.Types.OperationResult Res = VerificarSeries();
                                        if (Res.Success == false)
                                                return Res;
                                }

                                if (this.Tipo.EsFactura && this.FormaDePago == FormasDePago.CuentaCorriente) {
                                        double DiferenciaMonto;
                                        if (this.m_RegistroOriginal == null)
                                                DiferenciaMonto = -this.Total;
                                        else
                                                DiferenciaMonto = System.Convert.ToDouble(this.m_RegistroOriginal["total"]) - this.Total;
                                        this.Cliente.CuentaCorriente.Movimiento(true, 21000, this.ToString(), DiferenciaMonto);

                                }

                                if (this.Tipo.EsFactura || this.Tipo.EsRemito) {
                                        ColeccionDetalleArticulos Diferencia = this.m_Articulos.Diferencia(this.m_ArticulosOriginales);
                                        foreach (DetalleArticulo Det in Diferencia) {
                                                if (Det.Articulo != null) {
                                                        if (Det.Cantidad > 0)
                                                                Det.Articulo.MoverStock(Det.Cantidad, "Movimiento s/Compr. Proveed. " + this.ToString() + " de " + this.Cliente.Nombre, new Lbl.Articulos.Situacion(DataView, 998), this.SituacionDestino, Det.Series);
                                                        else
                                                                //Cantidad negativa. Hago el movimiento con cantidad positiva, pero en sentido inverso
                                                                Det.Articulo.MoverStock(-Det.Cantidad, "Movimiento s/Compr. Proveed. " + this.ToString() + " de " + this.Cliente.Nombre, this.SituacionDestino, new Lbl.Articulos.Situacion(DataView, 998), Det.Series);
                                                }
                                        }
                                }

                                System.Collections.Generic.List<int> ArticulosAfectados = new System.Collections.Generic.List<int>();
                                foreach (DetalleArticulo Det in m_Articulos) {
                                        if (Det.IdArticulo != 0 && ArticulosAfectados.Contains(Det.IdArticulo) == false)
                                                ArticulosAfectados.Add(Det.IdArticulo);
                                }

                                if (m_ArticulosOriginales != null) {
                                        foreach (DetalleArticulo Det in m_ArticulosOriginales) {
                                                if (Det.IdArticulo > 0 && ArticulosAfectados.Contains(Det.IdArticulo) == false)
                                                        ArticulosAfectados.Add(Det.IdArticulo);
                                        }
                                }

                                if (ArticulosAfectados.Count > 0) {
                                        //Convierto List<int> a (string)"1,2,3,..."
                                        System.Collections.Generic.List<string> ArtString = ArticulosAfectados.ConvertAll<string>(delegate(int i) { return i.ToString(); });
                                        string ArtCsv = string.Join(",", ArtString.ToArray());
                                        //Actualizo cantidades pedidas y a pedir
                                        DataView.DataBase.Execute(@"UPDATE articulos SET apedir=(
							SELECT SUM(cantidad)
							FROM facturas, facturas_detalle
							WHERE facturas.id_factura=facturas_detalle.id_factura
							AND facturas.compra=1
							AND tipo_fac='NP' AND estado=50 AND facturas_detalle.id_articulo=articulos.id_articulo)
						WHERE control_stock=1 AND id_articulo IN (" + ArtCsv + " )");
                                        DataView.DataBase.Execute(@"UPDATE articulos SET pedido=(
							SELECT SUM(cantidad)
							FROM facturas, facturas_detalle
							WHERE facturas.id_factura=facturas_detalle.id_factura
							AND facturas.compra=1
							AND tipo_fac='PD' AND estado=50 AND facturas_detalle.id_articulo=articulos.id_articulo)
						WHERE control_stock=1 AND id_articulo IN (" + ArtCsv + " )");
                                }
                        }

                        return base.Guardar();
                }

                public Lfx.Types.OperationResult VerificarSeries()
                {
                        foreach (Lbl.Comprobantes.DetalleArticulo Art in this.Articulos) {
                                if (Art.Articulo != null && Art.Articulo.RequiereNS != Lbl.Articulos.RequiereNS.Nunca)
                                        if (Art.Series == null) {
                                                return new Lfx.Types.FailureOperationResult("Debe ingresar el número de serie del artículo '" + Art.Nombre + "' para poder realizar movimientos de stock.");
                                        } else {
                                                string[] Series = Art.Series.Split(new string[] { Lfx.Types.ControlChars.CrLf }, StringSplitOptions.RemoveEmptyEntries);
                                                if (Series.Length < Art.Cantidad)
                                                        return new Lfx.Types.FailureOperationResult("Debe ingresar el número de serie de todos los artículos '" + Art.Nombre + "' para poder realizar movimientos de stock.");
                                        }
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }

                private void GuardarDetalle()
                {
                        this.DataView.DataBase.Execute("DELETE FROM facturas_detalle WHERE id_factura=" + this.Id.ToString());

                        int i = 1;
                        foreach (Lbl.Comprobantes.DetalleArticulo Art in m_Articulos) {
                                Lfx.Data.SqlTableCommandBuilder Comando; Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, "facturas_detalle");
                                Comando.Fields.AddWithValue("numero_factura", this.Numero);
                                Comando.Fields.AddWithValue("id_factura", this.Id);
                                Comando.Fields.AddWithValue("orden", i);

                                if (Art.Articulo == null) {
                                        Comando.Fields.AddWithValue("id_articulo", DBNull.Value);
                                        Comando.Fields.AddWithValue("nombre", Art.Nombre);
                                        Comando.Fields.AddWithValue("descripcion", "");
                                } else {
                                        Comando.Fields.AddWithValue("id_articulo", Art.Articulo.Id);
                                        Comando.Fields.AddWithValue("nombre", Art.Nombre);
                                        Comando.Fields.AddWithValue("descripcion", Art.Articulo.Descripcion);
                                }

                                Comando.Fields.AddWithValue("cantidad", Art.Cantidad);
                                Comando.Fields.AddWithValue("precio", Art.Unitario);
                                if(Art.Costo == 0 && Art.Articulo != null)
                                        Comando.Fields.AddWithValue("costo", Art.Articulo.Costo);
                                else
                                        Comando.Fields.AddWithValue("costo", Art.Costo);
                                Comando.Fields.AddWithValue("importe", Art.ImporteFinal);
                                Comando.Fields.AddWithValue("series", Art.Series);

                                this.AgregarTags(Comando, Art.Registro, "facturas_detalle");

                                this.DataView.Execute(Comando);
                                i++;
                        }
                }
	}
}