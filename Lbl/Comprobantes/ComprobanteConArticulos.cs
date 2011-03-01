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
using System.Text;

namespace Lbl.Comprobantes
{
        [Lbl.Atributos.NombreItem("Comprobante con Artículos"),
                Lbl.Atributos.MuestraMensajeAlCrear(false),
                Lbl.Atributos.MuestraPanelExtendido(false)]
	public class ComprobanteConArticulos : Comprobante
	{
                private ColeccionDetalleArticulos m_Articulos = null, m_ArticulosOriginales = null;
                private Lbl.Articulos.Situacion m_SituacionDestinoOriginal = null;
                private ColeccionRecibos m_Recibos = null;
                private Lbl.Pagos.FormaDePago m_FormaDePago = null;
                
                //Heredar constructor
                public ComprobanteConArticulos(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public ComprobanteConArticulos(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
			: base(dataBase, row) { }

		public ComprobanteConArticulos(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

		public override string TablaDatos
		{
			get
			{
				return "comprob";
			}
		}

                public override string TablaImagenes
                {
                        get
                        {
                                return "comprob_imagenes";
                        }
                }

		public override string CampoId
		{
			get
			{
				return "id_comprob";
			}
		}


                public bool Anulado
                {
                        get
                        {
                                return System.Convert.ToBoolean(this.GetFieldValue<int>("anulada"));
                        }
                }


                public override void Crear()
                {
                        base.Crear();

                        this.Vendedor = new Lbl.Personas.Persona(this.Connection, Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                }

                public void Anular(bool anularPagos)
                {
                        if (this.Anulado)
                                return;

                        if (this.Tipo.EsNotaDebito) {
                                this.Cliente.CuentaCorriente.Movimiento(true, Lbl.Cajas.Concepto.IngresosPorFacturacion, "Anulación Comprob. " + this.ToString(), -this.Total, null, this, null, null, true);
                        } else if (this.Tipo.EsNotaCredito) {
                                this.Cliente.CuentaCorriente.Movimiento(true, Lbl.Cajas.Concepto.IngresosPorFacturacion, "Anulación Comprob. " + this.ToString(), this.Total, null, this, null, null, true);
                        } else if (this.Tipo.EsFactura) {
                                Lbl.Articulos.Stock.MoverStockFactura(this, false);
                                if (anularPagos) {
                                        switch (this.FormaDePago.Tipo) {
                                                case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                        // Hago un egreso de caja
                                                        Lbl.Cajas.Caja Caja = new Lbl.Cajas.Caja(Connection, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                        Caja.Movimiento(true, Lbl.Cajas.Concepto.IngresosPorFacturacion, "Anulación Comprob. " + this.ToString(), this.Cliente, -this.ImporteCancelado, null, this, null, null);
                                                        break;

                                                case Lbl.Pagos.TiposFormasDePago.ChequePropio:
                                                        Lbl.Bancos.Cheque Cheque = new Lbl.Bancos.Cheque(Connection, this);
                                                        if (Cheque != null && Cheque.Existe)
                                                                Cheque.Anular();
                                                        break;

                                                case Lbl.Pagos.TiposFormasDePago.CuentaCorriente:
                                                        if (this.ImporteCancelado < this.Total) {
                                                                // Quito el saldo paga de la cuenta corriente
                                                                this.Cliente.CuentaCorriente.Movimiento(true, Lbl.Cajas.Concepto.IngresosPorFacturacion, "Anulación Comprob. " + this.ToString(), -this.ImporteCancelado, "", this, null, null, false);
                                                        }
                                                        break;

                                                case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                                        Lbl.Pagos.Cupon Cupon = new Lbl.Pagos.Cupon(Connection, this);
                                                        if (Cupon != null && Cupon.Existe)
                                                                Cupon.Anular();
                                                        break;
                                        }
                                }
                        }

                        // Marco la factura como anulada
                        qGen.Update Act = new qGen.Update(this.TablaDatos);
                        Act.Fields.AddWithValue("anulada", 1);
                        Act.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        this.Connection.Execute(Act);

                        Lbl.Sys.Config.ActionLog(this.Connection, Lbl.Sys.Log.Acciones.Delete, this, null);
                }


                public decimal Descuento
		{
			get
			{
                                return this.GetFieldValue<decimal>("descuento");
			}
                        set
                        {
                                Registro["descuento"] = value;
                        }
		}

                public decimal Recargo
		{
			get
			{
				return this.GetFieldValue<decimal>("interes");
			}
                        set
                        {
                                Registro["interes"] = value;
                        }
		}

                public decimal ImporteCancelado
		{
			get
			{
				return this.GetFieldValue<decimal>("cancelado");
			}
			set
			{
				Registro["cancelado"] = value;
			}
		}

                public decimal GastosDeEnvio
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("gastosenvio");
                        }
                        set
                        {
                                Registro["gastosenvio"] = value;
                        }
                }

                public decimal OtrosGastos
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("otrosgastos");
                        }
                        set
                        {
                                Registro["otrosgastos"] = value;
                        }
                }


                public bool DiscriminaIva
                {
                        get
                        {
                                return this.Tipo.LetraSola == "A";
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


                public override Lbl.Impresion.Impresora ObtenerImpresora()
                {
                        // Intento obtener una impresora para este PV, esta susursal, para esta estación
                        foreach (Lbl.Impresion.TipoImpresora Impr in Tipo.Impresoras) {
                                if (Impr.Estacion != null && Impr.Estacion.ToUpperInvariant() == System.Environment.MachineName.ToUpperInvariant()
                                        && Impr.PuntoDeVenta != null && Impr.PuntoDeVenta.Numero == this.PV
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.Id)
                                        return Impr.Impresora;
                        }

                        // Caso contrario, obtengo la impresora para este tipo de comprobante
                        Lbl.Impresion.Impresora Res = base.ObtenerImpresora();

                        if (Res != null) {
                                return Res;
                        } else if (this.PV != 0) {
                                // Si base.ObtenerImpresora() no pudo encontrar nada, busco en el punto de venta
                                PuntoDeVenta Pun = new PuntoDeVenta(this.Connection, this.Connection.FieldInt("SELECT id_pv FROM pvs WHERE numero=" + this.PV.ToString()));
                                return Pun.Impresora;
                        } else {
                                return null;
                        }
                }

                /// <summary>
                /// Devuelve el subtotal, que es el importe de los artículos del comprobante, antes de descuentos y recargos.
                /// </summary>
                public decimal SubTotal
                {
                        get
                        {
                                decimal Res = 0;
                                foreach (DetalleArticulo Art in this.Articulos) {
                                        Res += Art.Importe;
                                }
                                return Math.Round(Res, this.Workspace.CurrentConfig.Moneda.Decimales);
                        }
                }


                /// <summary>
                /// Devuelve el importe total de la factura, redondeado a la cantidad de decimales configurada para el sistema.
                /// </summary>
                public decimal Total
                {
                        get
                        {
                                return this.RedondearImporte(this.TotalSinRedondeo);
                        }
                }


                /// <summary>
                /// Devuelve el importe de la factura, sin redondeos adicionales.
                /// </summary>
                public decimal TotalSinRedondeo
                {
                        get
                        {
                                decimal Res = 0;
                                foreach (Lbl.Comprobantes.DetalleArticulo Art in Articulos) {
                                        Res += Art.Importe;
                                }
                                return Math.Round(Res * (1 + (Recargo - Descuento) / 100) + this.GastosDeEnvio + this.OtrosGastos + this.ImporteIva, 4);
                        }
                }

                /// <summary>
                /// Devuelve el importe que aun está impago.
                /// </summary>
                public decimal ImporteImpago
                {
                        get
                        {
                                return this.Total - this.ImporteCancelado;
                        }
                }

                /// <summary>
                /// Devuelve el subtotal sin IVA, pero con descuentos, recargos y redondeos.
                /// </summary>
                public decimal SubTotalSinIva
                {
                        get
                        {
                                decimal Res = this.Total - this.ImporteIva;
                                return Math.Round(Res, 4);
                        }
                }


                /// <summary>
                /// Devuelve el importe de IVA para esta factura.
                /// </summary>
                public decimal ImporteIva
                {
                        get
                        {
                                if (this.Cliente != null && this.Cliente.PagaIva == Impuestos.SituacionIva.Exento)
                                        return 0;

                                decimal Res = 0;
                                foreach (DetalleArticulo Det in this.Articulos) {
                                        Res += Det.ImporteIva;
                                }
                                return this.RedondearImporte(Math.Round(Res, 4));
                        }
                }

                /// <summary>
                /// Redondea y trunca un importe según la configuración de decimales y redondeo del sistema.
                /// </summary>
                /// <param name="importe">El importe a redondear.</param>
                /// <returns>El importe redondeado y truncado.</returns>
                public decimal RedondearImporte(decimal importe)
                {
                        decimal Redondeo = this.Workspace.CurrentConfig.Moneda.Redondeo;
                        if (this.Compra || Redondeo == 0)
                                return Lfx.Types.Currency.Truncate(importe, this.Workspace.CurrentConfig.Moneda.Decimales);
                        else
                                return Lfx.Types.Currency.Truncate(Math.Floor(importe / Redondeo) * Redondeo, this.Workspace.CurrentConfig.Moneda.Decimales);
                }

		public Lbl.Pagos.FormaDePago FormaDePago
		{
			get
			{
                                if (m_FormaDePago == null && this.GetFieldValue<int>("id_formapago") != 0)
                                        m_FormaDePago = new Lbl.Pagos.FormaDePago(this.Connection, this.GetFieldValue<int>("id_formapago"));
                                return m_FormaDePago;
			}
			set
			{
                                m_FormaDePago = value;
			}
		}

		public int NumeroRemito
		{
			get
			{
				return this.GetFieldValue<int>("remito");
			}
                        set
                        {
                                this.Registro["remito"] = value;
                        }
		}

                public decimal ImporteIvaDiscriminado
                {
                        get
                        {
                                if (this.Cliente != null && this.Cliente.PagaIva == Impuestos.SituacionIva.Exento)
                                        return 0;

                                decimal Res = 0;
                                foreach (DetalleArticulo Det in this.Articulos) {
                                        Res += Det.IvaDiscriminado;
                                }
                                return Math.Round(Res, 4);
                        }
                }

               
		public bool HayStock()
		{
			//Verifica si hay suficiente stock para el comprobante
			if (this.Articulos != null)
			{
				foreach (Comprobantes.DetalleArticulo Det in this.Articulos)
				{
					if(Det.Id > 0 && Det.Articulo != null 
                                                && Det.Articulo.ControlStock != Lbl.Articulos.ControlStock.No 
                                                && Det.Articulo.StockActual < Det.Cantidad)
						return false;
				}
			}
			return true;
		}

                public override void OnLoad()
                {
                        this.m_ArticulosOriginales = this.Articulos.Clone();
                        this.m_SituacionDestinoOriginal = this.SituacionDestino;
                        
                        base.OnLoad();
                }

                public ColeccionDetalleArticulos Articulos
                {
                        get
                        {
                                if (m_Articulos == null) {
                                        m_Articulos = new ColeccionDetalleArticulos(this);
                                        if (this.Existe) {
                                                System.Data.DataTable Dets = this.Connection.Select("SELECT * FROM comprob_detalle WHERE id_comprob=" + this.Id.ToString());
                                                foreach (System.Data.DataRow Det in Dets.Rows) {
                                                        Comprobantes.DetalleArticulo DetArt = new DetalleArticulo(this, (Lfx.Data.Row)Det);
                                                        m_Articulos.Add(DetArt);
                                                }
                                        }
                                }
                                return m_Articulos;
                        }
                        set
                        {
                                m_Articulos = value;
                        }
                }

                public ColeccionRecibos Recibos
                {
                        get
                        {
                                if (m_Recibos == null || m_Recibos.Count == 0) {
                                        m_Recibos = new ColeccionRecibos();
                                        if (this.Existe) {
                                                System.Data.DataTable Recs = this.Connection.Select("SELECT id_recibo FROM recibos_comprob WHERE id_comprob=" + this.Id.ToString());
                                                foreach (System.Data.DataRow Rec in Recs.Rows) {
                                                        m_Recibos.Add(new Recibo(Connection, System.Convert.ToInt32(Rec["id_recibo"])));
                                                }
                                        }
                                }
                                return m_Recibos;
                        }
                }

                public Lfx.Types.OperationResult CancelarImporte(decimal importe, Lbl.Comprobantes.Recibo recibo)
		{
			if(this.ImporteCancelado + importe > this.Total)
				throw new InvalidOperationException("ComprobanteConArticulos.CancelarImporte: El importe a cancelar no puede ser mayor que el saldo impago");
			this.ImporteCancelado += importe;
			qGen.Update Actualizar = new qGen.Update("comprob", new qGen.Where("id_comprob", this.Id));
			Actualizar.Fields.AddWithValue("cancelado", this.ImporteCancelado);
			this.Connection.Execute(Actualizar);

                        if (recibo != null) {
                                qGen.Insert AsentarComprobantesDeEsteRecibo = new qGen.Insert("recibos_comprob");
                                AsentarComprobantesDeEsteRecibo.Fields.AddWithValue("id_recibo", recibo.Id);
                                AsentarComprobantesDeEsteRecibo.Fields.AddWithValue("id_comprob", this.Id);
                                AsentarComprobantesDeEsteRecibo.Fields.AddWithValue("importe", importe);
                                this.Connection.Execute(AsentarComprobantesDeEsteRecibo);
                        }
			return new Lfx.Types.SuccessOperationResult();
		}


                public override Lfx.Types.OperationResult Guardar()
                {
			qGen.TableCommand Comando;

			if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        if (this.Existe == false && this.Numero == 0 && this.Tipo.NumerarAlGuardar) {
                                this.Numerar(false);
                        }

                        if (this.Fecha == null) {
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando.Fields.AddWithValue("fecha", this.Fecha);
                        }

                        if(this.FormaDePago == null)
                                Comando.Fields.AddWithValue("id_formapago", null);
                        else
                                Comando.Fields.AddWithValue("id_formapago", FormaDePago.Id);
                        if (this.Vendedor == null)
                                Comando.Fields.AddWithValue("id_vendedor", null);
                        else
                                Comando.Fields.AddWithValue("id_vendedor", this.Vendedor.Id);
                        if (this.Sucursal == null)
                                Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);
                        else
                                Comando.Fields.AddWithValue("id_sucursal", this.Sucursal.Id);
                        Comando.Fields.AddWithValue("pv", this.PV);
                        Comando.Fields.AddWithValue("numero", this.Numero);
                        Comando.Fields.AddWithValue("id_cliente", Lfx.Data.Connection.ConvertZeroToDBNull(this.Cliente.Id));
                        if (this.SituacionOrigen == null)
                                Comando.Fields.AddWithValue("situacionorigen", null);
                        else
                                Comando.Fields.AddWithValue("situacionorigen", this.SituacionOrigen.Id);
                        if (this.SituacionDestino == null)
                                Comando.Fields.AddWithValue("situaciondestino", null);
                        else
                                Comando.Fields.AddWithValue("situaciondestino", this.SituacionDestino.Id);
                        Comando.Fields.AddWithValue("tipo_fac", this.Tipo.Nomenclatura);
                        Comando.Fields.AddWithValue("subtotal", this.SubTotal);
                        Comando.Fields.AddWithValue("descuento", this.Descuento);
                        Comando.Fields.AddWithValue("interes", this.Recargo);
                        Comando.Fields.AddWithValue("cuotas", this.Cuotas);
                        Comando.Fields.AddWithValue("total", this.Total);
                        Comando.Fields.AddWithValue("totalreal", this.TotalSinRedondeo);
                        Comando.Fields.AddWithValue("gastosenvio", this.GastosDeEnvio);
                        Comando.Fields.AddWithValue("otrosgastos", this.OtrosGastos);
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        // Lo comprobantes de compra se marcan siempre como impresos
                        Comando.Fields.AddWithValue("impresa", this.Compra ? 1 : (this.Impreso ? 1 : 0));
                        Comando.Fields.AddWithValue("compra", this.Compra ? 1 : 0);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        Comando.Fields.AddWithValue("series", this.Articulos.DatosSeguimiento);

			this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        if (this.Existe == false)
                                this.m_ItemId = this.Connection.FieldInt("SELECT LAST_INSERT_ID()");

                        this.GuardarDetalle();

                        if (this.Compra) {
                                if (this.Tipo.MueveStock) {
                                        // Comprobantes de compra mueven stock al guardar
                                        Lfx.Types.OperationResult Res = VerificarSeries();
                                        if (Res.Success == false)
                                                return Res;
                                }

                                if (this.Tipo.EsFactura && this.FormaDePago != null && this.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente) {
                                        decimal DiferenciaMonto;
                                        if (this.m_RegistroOriginal == null)
                                                DiferenciaMonto = -this.Total;
                                        else
                                                DiferenciaMonto = System.Convert.ToDecimal(this.m_RegistroOriginal["total"]) - this.Total;
                                        if (DiferenciaMonto != 0)
                                                this.Cliente.CuentaCorriente.Movimiento(true, new Lbl.Cajas.Concepto(this.Connection, 21000), this.ToString(), DiferenciaMonto, null, null);

                                }

                                if (this.Tipo.EsFactura || this.Tipo.EsRemito) {
                                        ColeccionDetalleArticulos Diferencia;
                                        if (m_SituacionDestinoOriginal != null && this.SituacionDestino.Id == m_SituacionDestinoOriginal.Id)
                                                Diferencia = this.m_Articulos.Diferencia(this.m_ArticulosOriginales);
                                        else
                                                Diferencia = this.m_Articulos.Diferencia(null);

                                        foreach (DetalleArticulo Det in Diferencia) {
                                                if (Det.Articulo != null) {
                                                        Lbl.Articulos.Situacion SituacionProveedor = new Lbl.Articulos.Situacion(this.Connection, 998);
                                                        Lbl.Articulos.Situacion Desde, Hacia;
                                                        if (Det.Cantidad > 0) {
                                                                Desde = SituacionProveedor;
                                                                Hacia = this.SituacionDestino;
                                                        } else {
                                                                //Cantidad negativa. Hago el movimiento con cantidad positiva, pero en sentido inverso
                                                                Desde = this.SituacionDestino;
                                                                Hacia = SituacionProveedor;
                                                        }

                                                        decimal MoverCantidad = Math.Abs(Det.Cantidad);

                                                        if (m_SituacionDestinoOriginal != null && this.SituacionDestino.Id != m_SituacionDestinoOriginal.Id)
                                                                // Cambio de situación, primero devuelvo los artículos al proveedor
                                                                Det.Articulo.MoverStock(MoverCantidad, "Edición de Compr. Proveed. " + this.ToString(), m_SituacionDestinoOriginal, SituacionProveedor, Det.DatosSeguimiento);

                                                        Det.Articulo.MoverStock(MoverCantidad, "Movimiento s/Compr. Proveed. " + this.ToString(), Desde, Hacia, Det.DatosSeguimiento);
                                                }
                                        }
                                }

                                Lbl.ListaIds ArticulosAfectados = new Lbl.ListaIds();
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
                                        string ArtCsv = ArticulosAfectados.ToString();
                                        //Actualizo cantidades pedidas y a pedir
                                        Connection.Execute(@"UPDATE articulos SET apedir=(
							SELECT SUM(cantidad)
							FROM comprob, comprob_detalle
							WHERE comprob.id_comprob=comprob_detalle.id_comprob
							AND comprob.compra=1
							AND tipo_fac='NP' AND estado=50 AND comprob_detalle.id_articulo=articulos.id_articulo)
						WHERE control_stock=1 AND id_articulo IN (" + ArtCsv + " )");
                                        Connection.Execute(@"UPDATE articulos SET pedido=(
							SELECT SUM(cantidad)
							FROM comprob, comprob_detalle
							WHERE comprob.id_comprob=comprob_detalle.id_comprob
							AND comprob.compra=1
							AND tipo_fac='PD' AND estado=50 AND comprob_detalle.id_articulo=articulos.id_articulo)
						WHERE control_stock=1 AND id_articulo IN (" + ArtCsv + " )");
                                }
                        }

                        return base.Guardar();
                }

                public Lfx.Types.OperationResult VerificarSeries()
                {
                        foreach (Lbl.Comprobantes.DetalleArticulo Art in this.Articulos) {
                                if (Art.Articulo != null && Art.Articulo.Seguimiento != Lbl.Articulos.Seguimientos.Ninguno)
                                        if (Art.DatosSeguimiento == null  || Art.DatosSeguimiento.Count == 0) {
                                                return new Lfx.Types.FailureOperationResult("Debe ingresar los datos de seguimiento (Ctrl-S) del artículo '" + Art.Nombre + "' para poder realizar movimientos de stock.");
                                        } else {
                                                if (Art.DatosSeguimiento.CantidadTotal < Art.Cantidad)
                                                        return new Lfx.Types.FailureOperationResult("Debe ingresar los datos de seguimiento (Ctrl-S) de todos los artículos '" + Art.Nombre + "' para poder realizar movimientos de stock.");
                                        }
                        }
                        return new Lfx.Types.SuccessOperationResult();
                }

                private void GuardarDetalle()
                {
                        qGen.Delete EliminarDetallesViejos = new qGen.Delete("comprob_detalle");
                        EliminarDetallesViejos.WhereClause = new qGen.Where("id_comprob", this.Id);
                        this.Connection.Execute(EliminarDetallesViejos);

                        int i = 1;
                        for (int Pasada = 1; Pasada <= 2; Pasada++) {
                                foreach (Lbl.Comprobantes.DetalleArticulo Art in m_Articulos) {
                                        // En la primera pasada, guardo sólo importes y cantidades positivos (o cero)
                                        // en la segunda pasada, guardo sólo los negativos.
                                        // De esa manera, los negativos siempre quedan últimos
                                        // lo cual es un requerimiento de las fiscales Hasar.
                                        if ((Pasada == 1 && Art.Cantidad >= 0 && Art.Unitario >= 0)
                                                || (Pasada == 2 && (Art.Cantidad < 0 || Art.Unitario < 0))) {
                                                qGen.TableCommand Comando; Comando = new qGen.Insert(this.Connection, "comprob_detalle");
                                                Comando.Fields.AddWithValue("id_comprob", this.Id);
                                                Comando.Fields.AddWithValue("orden", i);

                                                if (Art.Articulo == null) {
                                                        Comando.Fields.AddWithValue("id_articulo", null);
                                                        Comando.Fields.AddWithValue("nombre", Art.Nombre);
                                                        Comando.Fields.AddWithValue("descripcion", "");
                                                } else {
                                                        Comando.Fields.AddWithValue("id_articulo", Art.Articulo.Id);
                                                        Comando.Fields.AddWithValue("nombre", Art.Nombre);
                                                        Comando.Fields.AddWithValue("descripcion", Art.Articulo.Descripcion);
                                                }

                                                Comando.Fields.AddWithValue("cantidad", Art.Cantidad);
                                                Comando.Fields.AddWithValue("precio", Art.Unitario);
                                                if (Art.Costo == 0 && Art.Articulo != null)
                                                        Comando.Fields.AddWithValue("costo", Art.Articulo.Costo);
                                                else
                                                        Comando.Fields.AddWithValue("costo", Art.Costo);
                                                Comando.Fields.AddWithValue("importe", Art.Importe);
                                                Comando.Fields.AddWithValue("series", Art.DatosSeguimiento);
                                                Comando.Fields.AddWithValue("obs", Art.Obs);

                                                this.AgregarTags(Comando, Art.Registro, "comprob_detalle");

                                                this.Connection.Execute(Comando);
                                                i++;
                                        }
                                }
                        }
                }

                public virtual ComprobanteConArticulos Clone()
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Nuevo = Lbl.Instanciador.Instanciar(this.GetType(), this.Connection) as Lbl.Comprobantes.ComprobanteConArticulos;

                        Nuevo.Tipo = this.Tipo;
                        Nuevo.Compra = this.Compra;
                        Nuevo.Cliente = this.Cliente;
                        Nuevo.Descuento = this.Descuento;
                        Nuevo.Cuotas = this.Cuotas;
                        Nuevo.Estado = this.Estado;
                        Nuevo.Fecha = this.Fecha;
                        Nuevo.FormaDePago = this.FormaDePago;
                        Nuevo.GastosDeEnvio = this.GastosDeEnvio;
                        //Nuevo.Imagen = this.Imagen;
                        //Nuevo.ImporteCancelado = this.ImporteCancelado;
                        //Nuevo.Impreso = this.Impreso;
                        Nuevo.Numero = this.Numero;
                        Nuevo.NumeroRemito = this.NumeroRemito;
                        Nuevo.Obs = this.Obs;
                        Nuevo.OtrosGastos = this.OtrosGastos;
                        Nuevo.PV = this.PV;
                        Nuevo.SituacionDestino = this.SituacionDestino;
                        Nuevo.SituacionOrigen = this.SituacionOrigen;
                        Nuevo.Sucursal = this.Sucursal;
                        Nuevo.Articulos = this.Articulos.Clone(Nuevo);
                        Nuevo.Vendedor = this.Vendedor;

                        return Nuevo;
                }

                public virtual ComprobanteConArticulos ConvertirEn(Tipo tipo)
                {
                        Lbl.Comprobantes.ComprobanteConArticulos Nuevo = this.Clone();
                        Nuevo.ComprobanteOriginal = this;
                        Nuevo.Tipo = tipo;
                        Nuevo.Obs = "s/" + this.ToString();
                        return Nuevo;
                }
	}
}