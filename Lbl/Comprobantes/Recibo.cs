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
using System.Text;

namespace Lbl.Comprobantes
{
        public class Recibo : Comprobante
        {
                //Heredar constructor
                public Recibo(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Recibo(Lfx.Data.Connection dataBase, Personas.Persona cliente)
                        : this(dataBase)
                {
                        this.Crear();
                        this.Cliente = cliente;
                }

                public Recibo(Lfx.Data.Connection dataBase, int idRecibo)
                        : base(dataBase, idRecibo) { }

                public Recibo(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "recibos";
                        }
                }

                public override string TablaImagenes
                {
                        get
                        {
                                return "recibos_imagenes";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_recibo";
                        }
                }

                public ColeccionComprobanteConArticulos Facturas;
                public Cajas.Concepto Concepto;
                public ColeccionDeCobros Cobros = new ColeccionDeCobros();
                public ColeccionDePagos Pagos = new ColeccionDePagos();
                public bool CancelaCosas = true;

                public override void Crear()
                {
                        base.Crear();
                        
                        this.Fecha = this.Connection.ServerDateTime;

                        Facturas = new ColeccionComprobanteConArticulos(this.Connection);
                        
                        if (this.Tipo == null)
                                this.Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra["RC"];
                        
                        this.PV = this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos." + this.Tipo.Nomenclatura + ".PV", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);
                        this.Vendedor = new Personas.Persona(this.Connection, Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                }

                public bool DePago
                {
                        get
                        {
                                return this.Tipo != null && this.Tipo.Nomenclatura == "RCP";
                        }
                }

                public string ConceptoTexto
                {
                        get
                        {
                                return this.GetFieldValue<string>("concepto");
                        }
                        set
                        {
                                this.Registro["concepto"] = value;
                        }
                }


                public bool Anulado
                {
                        get
                        {
                                return this.Estado == 90;
                        }
                }


                public override string ToString()
                {
                        string Res = this.Tipo.Nombre;
                        if (Numero > 0)
                                Res += " Nº " + this.PV.ToString("0000") + "-" + this.Numero.ToString("00000000");
                        else
                                Res += " S/N";

                        return Res;
                }

                public string ToString(bool incluyeCliente)
                {
                        string Res = this.ToString();

                        if (incluyeCliente && Cliente != null)
                                Res += " de " + Cliente.ToString();

                        return Res;
                }

                public decimal Total
                {
                        get
                        {
                                decimal Res = 0;
                                if (DePago) {
                                        foreach (Pago Pg in Pagos) {
                                                Res += Pg.Importe;
                                        }
                                } else {
                                        foreach (Cobro Pg in Cobros) {
                                                Res += Pg.Importe;
                                        }
                                }
                                return Res;
                        }
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                this.Numero = System.Convert.ToInt32(m_Registro["numero"]);
                                this.PV = System.Convert.ToInt32(m_Registro["pv"]);

                                if (m_Registro["id_concepto"] != null)
                                        this.Concepto = new Lbl.Cajas.Concepto(this.Connection, this.GetFieldValue<int>("id_concepto"));
                                else
                                        this.Concepto = null;

                                if (m_Registro["concepto"] != null)
                                        this.ConceptoTexto = m_Registro["concepto"].ToString();
                                else
                                        this.ConceptoTexto = string.Empty;

                                this.Facturas = new ColeccionComprobanteConArticulos(this.Connection);
                                this.Cobros = new ColeccionDeCobros();
                                this.Pagos = new ColeccionDePagos();

                                //Cargo comprob asociadas al recibo
                                using (System.Data.DataTable TablaFacturas = Connection.Select("SELECT * FROM recibos_comprob WHERE id_recibo=" + this.Id.ToString())) {
                                        foreach (System.Data.DataRow Factura in TablaFacturas.Rows) {
                                                Facturas.Add(new ComprobanteConArticulos(this.Connection, System.Convert.ToInt32(Factura["id_comprob"])));
                                        }
                                }

                                // Cargo pagos asociados al registro
                                // Pagos en efectivo
                                using (System.Data.DataTable TablaPagos = Connection.Select("SELECT * FROM cajas_movim WHERE id_caja=" + this.Workspace.CurrentConfig.Empresa.CajaDiaria.ToString() + " AND id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                decimal ImporteCaja = System.Convert.ToDecimal(Pago["importe"]);
                                                if (this.DePago && ImporteCaja < 0) {
                                                        Pago Pg = new Pago(this.Connection, Lbl.Pagos.TiposFormasDePago.Efectivo, ImporteCaja);
                                                        Pg.Recibo = this;
                                                        Pagos.Add(Pg);
                                                } else if (this.DePago == false && ImporteCaja > 0) {
                                                        Cobro Cb = new Cobro(this.Connection, Lbl.Pagos.TiposFormasDePago.Efectivo, ImporteCaja);
                                                        Cb.Recibo = this;
                                                        Cobros.Add(Cb);
                                                }
                                        }
                                }

                                // Pagos con cheque
                                using (System.Data.DataTable TablaPagos = this.Connection.Select("SELECT * FROM bancos_cheques WHERE id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                Bancos.Cheque Ch = new Lbl.Bancos.Cheque(Connection, (Lfx.Data.Row)Pago);
                                                Ch.Recibo = this;
                                                if (this.DePago)
                                                        Pagos.Add(new Pago(Ch));
                                                else 
                                                        Cobros.Add(new Cobro(Ch));
                                        }
                                }

                                // Pagos con Tarjetas de Crédito y Débito
                                using (System.Data.DataTable TablaPagos = this.Connection.Select("SELECT id_cupon FROM tarjetas_cupones WHERE id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                Pagos.Cupon Cp = new Pagos.Cupon(Connection, System.Convert.ToInt32(Pago["id_cupon"]));
                                                Cobros.Add(new Cobro(Cp));
                                        }
                                }

                                // Acreditaciones en cuenta regular (excepto caja diaria)
                                using (System.Data.DataTable TablaPagos = this.Connection.Select("SELECT * FROM cajas_movim WHERE auto=1 AND id_caja<>" + this.Workspace.CurrentConfig.Empresa.CajaDiaria.ToString() + " AND id_caja<>" + this.Workspace.CurrentConfig.Empresa.CajaCheques.ToString() + " AND id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                if (this.DePago) {
                                                        Pago Pg = new Pago(this.Connection, Lbl.Pagos.TiposFormasDePago.Caja, Math.Abs(System.Convert.ToDecimal(Pago["importe"])));
                                                        Pg.Recibo = this;
                                                        Pg.CajaOrigen = new Cajas.Caja(Connection, System.Convert.ToInt32(Pago["id_caja"]));
                                                        Pagos.Add(Pg);
                                                } else {
                                                        Cobro Cb = new Cobro(this.Connection, Lbl.Pagos.TiposFormasDePago.Caja, System.Convert.ToDecimal(Pago["importe"]));
                                                        Cb.Recibo = this;
                                                        Cb.CajaDestino = new Cajas.Caja(Connection, System.Convert.ToInt32(Pago["id_caja"]));
                                                        Cobros.Add(Cb);
                                                }
                                        }
                                }

                                // Otros valores
                                using (System.Data.DataTable TablaPagos = this.Connection.Select("SELECT id_valor FROM pagos_valores WHERE id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                Lbl.Pagos.Valor Vl = new Lbl.Pagos.Valor(Connection, System.Convert.ToInt32(Pago["id_valor"]));
                                                Vl.Recibo = this;
                                                if (this.DePago)
                                                        Pagos.Add(new Pago(Vl));
                                                else
                                                        Cobros.Add(new Cobro(Vl));
                                        }
                                }
                        }
                        base.OnLoad();
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        if (this.Concepto == null) {
                                //Concepto predeterminado para recibos
                                if (this.DePago)
                                        //Compra de mercadería
                                        this.Concepto = new Lbl.Cajas.Concepto(this.Connection, 21000);
                                else
                                        //Ingresos por facturación
                                        this.Concepto = Lbl.Cajas.Concepto.IngresosPorFacturacion;
                        } else {
                                this.Concepto.Connection = this.Connection;
                        }
                        if (this.Tipo.NumerarAlGuardar)
                                this.Numerar(false);

                        // Asiento el recibo
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                throw new InvalidOperationException("Lbl: No se puede cambiar un recibo impreso");
                        }

                        if (this.Concepto != null)
                                Comando.Fields.AddWithValue("id_concepto", this.Concepto.Id);
                        else
                                Comando.Fields.AddWithValue("id_concepto", null);

                        Comando.Fields.AddWithValue("concepto", this.ConceptoTexto);
                        Comando.Fields.AddWithValue("tipo_fac", this.Tipo.Nomenclatura);
                        Comando.Fields.AddWithValue("pv", this.PV);
                        Comando.Fields.AddWithValue("numero", this.Numero);
                        Comando.Fields.AddWithValue("id_vendedor", Lfx.Data.Connection.ConvertZeroToDBNull(this.Vendedor.Id));
                        Comando.Fields.AddWithValue("id_cliente", Lfx.Data.Connection.ConvertZeroToDBNull(this.Cliente.Id));
                        Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);
                        Comando.Fields.AddWithValue("total", this.Total);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        // Tomo el id del recibo que acabo de crear
                        m_ItemId = this.Connection.FieldInt("SELECT LAST_INSERT_ID()");

                        string ObsPago = string.Empty;
                        if (this.Obs != null && this.Obs.Length > 0)
                                ObsPago += this.Obs + " ///";
                        else if (this.DePago)
                                ObsPago = "Pago";
                        else
                                ObsPago = "Cobro";

                        ObsPago += " s/" + this.ToString(true);

                        if (ConceptoTexto == null || ConceptoTexto.Length == 0)
                                ConceptoTexto = ObsPago;

                        // Asiento los valores
                        foreach (Cobro Pg in this.Cobros) {
                                Pg.Concepto = this.Concepto;
                                Pg.ConceptoTexto = this.ConceptoTexto;
                                switch (Pg.FormaDePago.Tipo) {
                                        case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                Cajas.Caja CajaDiaria = new Cajas.Caja(this.Connection, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                CajaDiaria.Movimiento(true, this.Concepto, this.ConceptoTexto, Cliente, Pg.Importe, ObsPago, null, this, string.Empty);
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.ChequePropio:
                                        case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                                Pg.Cheque.Connection = this.Connection;
                                                Pg.Cheque.Obs = ObsPago;
                                                Pg.Cheque.Concepto = Pg.Concepto;
                                                Pg.Cheque.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cheque.Recibo = this;
                                                Pg.Cheque.Cliente = this.Cliente;
                                                Pg.Cheque.Emitido = Pg.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.ChequePropio;
                                                Lfx.Types.OperationResult ResultadoCheque = Pg.Cheque.Guardar();
                                                if (ResultadoCheque.Success == false)
                                                        return ResultadoCheque;
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                                Pg.Cupon.Connection = this.Connection;
                                                Pg.Cupon.Obs = ObsPago;
                                                Pg.Cupon.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cupon.Recibo = this;
                                                Pg.Cupon.Cliente = this.Cliente;
                                                Lfx.Types.OperationResult ResultadoCupon = Pg.Cupon.Guardar();
                                                if (ResultadoCupon.Success == false)
                                                        return ResultadoCupon;
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.Caja:
                                                Pg.CajaDestino.Connection = this.Connection;
                                                Pg.CajaDestino.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, Pg.Importe, ObsPago, null, this, string.Empty);
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.OtroValor:
                                                Pg.Valor.Connection = this.Connection;
                                                Pg.Valor.Obs = ObsPago;
                                                Pg.Valor.Recibo = this;
                                                Lfx.Types.OperationResult ResultadoValor = Pg.Valor.Guardar();
                                                if (ResultadoValor.Success == false)
                                                        return ResultadoValor;
                                                break;
                                }
                        }

                        foreach (Pago Pg in this.Pagos) {
                                Pg.Concepto = this.Concepto;
                                Pg.ConceptoTexto = this.ConceptoTexto;
                                switch (Pg.FormaDePago.Tipo) {
                                        case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                Cajas.Caja CajaDiaria = new Cajas.Caja(this.Connection, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                CajaDiaria.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, -Pg.Importe, ObsPago, null, this, string.Empty);
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.ChequePropio:
                                                Pg.Cheque.Connection = this.Connection;
                                                Pg.Cheque.Concepto = Pg.Concepto;
                                                Pg.Cheque.Cliente = this.Cliente;
                                                Pg.Cheque.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cheque.Obs = ObsPago;
                                                Pg.Cheque.Emitido = true;
                                                Pg.Cheque.Recibo = this;
                                                Lfx.Types.OperationResult ResultadoCheque = Pg.Cheque.Guardar();
                                                if (ResultadoCheque.Success == false)
                                                        return ResultadoCheque;
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.Caja:
                                                Pg.CajaOrigen.Connection = this.Connection;
                                                Pg.CajaOrigen.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, -Pg.Importe, ObsPago, null, this, string.Empty);
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                                Pg.Cheque.Connection = this.Connection;
                                                Pg.Cheque.Estado = 11;
                                                if (Pg.Cheque.Obs.Length > 0)
                                                        Pg.Cheque.Obs += " /// ";
                                                Pg.Cheque.Obs += "Entregado s/" + this.ToString();
                                                Pg.Cheque.Recibo = this;
                                                Pg.Cheque.Guardar();
                                                Lfx.Types.OperationResult ResultadoChequeTerceros = Pg.Cheque.Guardar();
                                                if (ResultadoChequeTerceros.Success == false)
                                                        return ResultadoChequeTerceros;
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.OtroValor:
                                                Pg.Valor.Connection = this.Connection;
                                                Pg.Valor.Estado = 11;
                                                if (Pg.Valor.Obs.Length > 0)
                                                        Pg.Valor.Obs += " /// ";
                                                Pg.Valor.Obs += "Entregado s/" + this.ToString();
                                                Pg.Valor.Recibo = this;
                                                Pg.Valor.Guardar();
                                                Lfx.Types.OperationResult ResultadoValor = Pg.Valor.Guardar();
                                                if (ResultadoValor.Success == false)
                                                        return ResultadoValor;
                                                break;
                                }
                        }

                        // Doy las comprob por canceladas
                        decimal TotalACancelar = this.Total;

                        if (this.Facturas != null && this.Facturas.Count > 0) {
                                // Si hay una lista de facturas, las cancelo
                                foreach (Comprobantes.ComprobanteConArticulos Fact in this.Facturas) {
                                        // Calculo cuanto queda por cancelar en esta factura
                                        decimal ImportePendiente = Fact.Total - Fact.ImporteCancelado;

                                        // Intento cancelar todo
                                        decimal Cancelando = ImportePendiente;

                                        // Si se acab la plata, hago un pago parcial
                                        if (Cancelando > TotalACancelar)
                                                Cancelando = TotalACancelar;

                                        // Si alcanzo a cancelar algo, lo asiento
                                        if (Cancelando > 0) {
                                                Fact.CancelarImporte(Cancelando, this);

                                                if (Fact.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente)
                                                        this.Cliente.CuentaCorriente.Movimiento(true, Lbl.Cajas.Concepto.AjustesYMovimientos, "Cancelación s/" + this.ToString(), this.DePago ? Cancelando : -Cancelando, this.Obs, Fact, this, null, false);
                                        }

                                        TotalACancelar = TotalACancelar - Cancelando;
                                        if (TotalACancelar == 0)
                                                break;
                                }
                        }

                        if (TotalACancelar > 0) {
                                // Si queda más saldo, sigo buscando facturas a cancelar
                                using (System.Data.DataTable FacturasConSaldo = this.Connection.Select("SELECT * FROM comprob WHERE impresa>0 AND anulada=0 AND numero>0 AND tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM') AND id_formapago IN (1, 3, 99) AND cancelado<total AND id_cliente=" + this.Cliente.Id.ToString() + " ORDER BY id_comprob")) {

                                        decimal ImporteRestante = this.Total;

                                        foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                                Lbl.Comprobantes.ComprobanteConArticulos Fact = new ComprobanteConArticulos(this.Connection, (Lfx.Data.Row)Factura);

                                                decimal SaldoFactura = Fact.Total - Fact.ImporteCancelado;
                                                decimal ImporteASaldar = SaldoFactura;

                                                if (ImporteASaldar > Math.Abs(ImporteRestante))
                                                        ImporteASaldar = Math.Abs(ImporteRestante);

                                                this.Facturas.Add(Fact);
                                                Fact.CancelarImporte(ImporteASaldar, this);

                                                ImporteRestante += ImporteASaldar;

                                                if (ImporteRestante >= 0)
                                                        break;
                                        }
                                }
                        }

                        if (TotalACancelar > 0) {
                                Cliente.CuentaCorriente.Movimiento(true, this.Concepto, "Saldo s/" + this.ToString(), this.DePago ? TotalACancelar : -TotalACancelar, this.Obs, null, this, null, this.CancelaCosas);
                                TotalACancelar = 0;
                        }

                        base.Guardar();

                        return new Lfx.Types.SuccessOperationResult();
                }

                public void Anular()
                {
                        if (this.Existe && this.Anulado == false) {
                                // Marco el recibo como anulado
                                qGen.Update Act = new qGen.Update(this.TablaDatos);
                                Act.Fields.AddWithValue("estado", 90);
                                Act.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                this.Connection.Execute(Act);

                                Lbl.Sys.Config.ActionLog(this.Connection, Lbl.Sys.Log.Acciones.Delete, this, null);

                                if (this.DePago) {
                                        foreach (Pago Pg in this.Pagos) {
                                                Pg.Anular();
                                        }
                                } else {
                                        foreach (Cobro Cb in this.Cobros) {
                                                Cb.Anular();
                                        }
                                }

                                // Doy las comprob por canceladas
                                decimal TotalACancelar = this.Total;

                                //"Descancelo" comprob
                                if (this.Facturas != null && this.Facturas.Count > 0) {
                                        // Si hay una lista de comprob, las descancelo
                                        foreach (Comprobantes.ComprobanteConArticulos Fact in this.Facturas) {
                                                // Calculo cuanto queda por cancelar en esta factura
                                                decimal ImportePendiente = Fact.ImporteCancelado;

                                                // Intento cancelar todo
                                                decimal Cancelando = ImportePendiente;

                                                // Si se acab la plata, hago un pago parcial
                                                if (Cancelando > TotalACancelar)
                                                        Cancelando = TotalACancelar;

                                                // Si alcanzo a cancelar algo, lo asiento
                                                if (Cancelando > 0) {
                                                        if (Fact.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente)
                                                                this.Cliente.CuentaCorriente.Movimiento(true, Lbl.Cajas.Concepto.AjustesYMovimientos, "Anulación de " + this.ToString(), this.DePago ? -Cancelando : Cancelando, this.Obs, Fact, this, null, false);

                                                        qGen.Update ActualizarCancelado = new qGen.Update("comprob");
                                                        ActualizarCancelado.Fields.AddWithValue("cancelado", new qGen.SqlExpression("cancelado-" + Lfx.Types.Formatting.FormatCurrencySql(Cancelando)));
                                                        ActualizarCancelado.WhereClause = new qGen.Where("id_comprob", Fact.Id);
                                                        this.Connection.Execute(ActualizarCancelado);
                                                }

                                                TotalACancelar = TotalACancelar - Cancelando;
                                                if (TotalACancelar == 0)
                                                        break;
                                        }
                                }

                                if (TotalACancelar > 0) {
                                        this.Cliente.CuentaCorriente.Movimiento(true, this.Concepto, "Anulación de " + this.ToString(), this.DePago ? -TotalACancelar : TotalACancelar, string.Empty, null, this, null, false);
                                        TotalACancelar = 0;
                                }
                        }
                }
        }
}
