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
using System.Collections.Generic;
using System.Text;

namespace Lbl.Comprobantes
{
        public class Recibo : Comprobante
        {
                //Heredar constructor
                public Recibo(Lfx.Data.DataBase dataBase)
                        : base(dataBase)
                {
                        this.Crear();
                        this.Vendedor = new Personas.Persona(dataBase, dataBase.Workspace.CurrentUser.Id);
                }

                public Recibo(Lfx.Data.DataBase dataBase, Personas.Persona cliente)
                        : this(dataBase)
                {
                        this.Crear();
                        this.Cliente = cliente;
                }

                public Recibo(Lfx.Data.DataBase dataBase, int idRecibo)
                        : this(dataBase)
                {
                        this.m_ItemId = idRecibo;
                        this.Cargar();
                }

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

                public ColeccionComprobanteConArticulos Facturas = new ColeccionComprobanteConArticulos();
                public Cajas.Concepto Concepto;
                private int m_PV;
                public ColeccionDeCobros Cobros = new ColeccionDeCobros();
                public ColeccionDePagos Pagos = new ColeccionDePagos();
                public bool CancelaCosas = true;

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
                                return this.FieldString("concepto");
                        }
                        set
                        {
                                this.Registro["concepto"] = value;
                        }
                }

                public DateTime Fecha
                {
                        get
                        {
                                return this.FieldDateTime("fecha").Value;
                        }
                        set
                        {
                                this.Registro["fecha"] = value;
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

                public int PV
                {
                        get
                        {
                                return m_PV;
                        }
                        set
                        {
                                m_PV = value;
                        }
                }

                public double Importe
                {
                        get
                        {
                                double Res = 0;
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

                protected internal void Numerar()
                {
                        if (this.Numero == 0)
                                this.Numero = this.DataBase.FieldInt("SELECT MAX(numero) FROM recibos WHERE pv=" + this.PV.ToString() + " AND tipo_fac='" + this.Tipo.Nomenclatura + "'") + 1;
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                this.Cliente = new Lbl.Personas.Persona(this.DataBase, System.Convert.ToInt32(m_Registro["id_cliente"]));
                                this.Vendedor = new Lbl.Personas.Persona(this.DataBase, System.Convert.ToInt32(m_Registro["id_vendedor"]));
                                this.Numero = System.Convert.ToInt32(m_Registro["numero"]);
                                this.PV = System.Convert.ToInt32(m_Registro["pv"]);
                                this.Tipo = new Tipo(this.DataBase, m_Registro["tipo_fac"].ToString());

                                if (m_Registro["id_concepto"] != null)
                                        this.Concepto = new Lbl.Cajas.Concepto(this.DataBase, this.FieldInt("id_concepto"));
                                else
                                        this.Concepto = null;

                                if (m_Registro["concepto"] != null)
                                        this.ConceptoTexto = m_Registro["concepto"].ToString();
                                else
                                        this.ConceptoTexto = string.Empty;

                                this.Facturas.Clear();
                                this.Cobros.Clear();
                                this.Pagos.Clear();

                                //Cargo comprob asociadas al recibo
                                using (System.Data.DataTable TablaFacturas = DataBase.Select("SELECT * FROM recibos_comprob WHERE id_recibo=" + this.Id.ToString())) {
                                        foreach (System.Data.DataRow Factura in TablaFacturas.Rows) {
                                                Facturas.Add(new Factura(this.DataBase, System.Convert.ToInt32(Factura["id_comprob"])));
                                        }
                                }

                                // Cargo pagos asociados al registro
                                // Pagos en efectivo
                                using (System.Data.DataTable TablaPagos = DataBase.Select("SELECT * FROM cajas_movim WHERE id_caja=" + this.Workspace.CurrentConfig.Empresa.CajaDiaria.ToString() + " AND id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                double ImporteCaja = System.Convert.ToDouble(Pago["importe"]);
                                                if (this.DePago && ImporteCaja < 0) {
                                                        Pago Pg = new Pago(this.DataBase, Lbl.Pagos.TipoFormasDePago.Efectivo, ImporteCaja);
                                                        Pg.Recibo = this;
                                                        Pagos.Add(Pg);
                                                } else if (this.DePago == false && ImporteCaja > 0) {
                                                        Cobro Cb = new Cobro(this.DataBase, Lbl.Pagos.TipoFormasDePago.Efectivo, ImporteCaja);
                                                        Cb.Recibo = this;
                                                        Cobros.Add(Cb);
                                                }
                                        }
                                }

                                // Pagos con cheque
                                using (System.Data.DataTable TablaPagos = this.DataBase.Select("SELECT id_cheque FROM bancos_cheques WHERE id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                Bancos.Cheque Ch = new Lbl.Bancos.Cheque(DataBase, System.Convert.ToInt32(Pago["id_cheque"]));
                                                Ch.Recibo = this;       // Esto no debería estar aquí
                                                if (this.DePago)
                                                        Pagos.Add(new Pago(Ch));
                                                else
                                                        Cobros.Add(new Cobro(Ch));
                                        }
                                }

                                // Pagos con Tarjetas de Crédito y Débito
                                using (System.Data.DataTable TablaPagos = this.DataBase.Select("SELECT id_cupon FROM tarjetas_cupones WHERE id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                Cupones.Cupon Cp = new Lbl.Cupones.Cupon(DataBase, System.Convert.ToInt32(Pago["id_cupon"]));
                                                Cp.Recibo = this;       // Esto no debería estar aquí
                                                Cobros.Add(new Cobro(Cp));
                                        }
                                }

                                // Acreditaciones en cuenta regular (excepto caja diaria)
                                using (System.Data.DataTable TablaPagos = this.DataBase.Select("SELECT * FROM cajas_movim WHERE auto=1 AND id_caja<>" + this.Workspace.CurrentConfig.Empresa.CajaDiaria.ToString() + " AND id_caja<>" + this.Workspace.CurrentConfig.Empresa.CajaCheques.ToString() + " AND id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                if (this.DePago) {
                                                        Pago Pg = new Pago(this.DataBase, Lbl.Pagos.TipoFormasDePago.Caja, Math.Abs(System.Convert.ToDouble(Pago["importe"])));
                                                        Pg.Recibo = this;
                                                        Pg.CajaOrigen = new Cajas.Caja(DataBase, System.Convert.ToInt32(Pago["id_caja"]));
                                                        Pagos.Add(Pg);
                                                } else {
                                                        Cobro Cb = new Cobro(this.DataBase, Lbl.Pagos.TipoFormasDePago.Caja, System.Convert.ToDouble(Pago["importe"]));
                                                        Cb.Recibo = this;
                                                        Cb.CajaDestino = new Cajas.Caja(DataBase, System.Convert.ToInt32(Pago["id_caja"]));
                                                        Cobros.Add(Cb);
                                                }
                                        }
                                }

                                // Otros valores
                                using (System.Data.DataTable TablaPagos = this.DataBase.Select("SELECT id_valor FROM pagos_valores WHERE id_recibo=" + Id.ToString())) {
                                        foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                                Lbl.Pagos.Valor Vl = new Lbl.Pagos.Valor(DataBase, System.Convert.ToInt32(Pago["id_valor"]));
                                                Vl.Recibo = this;       // Esto no debería estar aquí
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
                                        this.Concepto = new Lbl.Cajas.Concepto(this.DataBase, 21000);
                                else
                                        //Ingresos por facturación
                                        this.Concepto = new Lbl.Cajas.Concepto(this.DataBase, 11000);
                        }
                        if (this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos." + this.Tipo.Nomenclatura + ".NumerarAlGuardar", 1) == 1)
                                this.Numerar();

                        // Asiento el recibo
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.DataBase, this.TablaDatos);
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
                        Comando.Fields.AddWithValue("id_vendedor", Lfx.Data.DataBase.ConvertZeroToDBNull(this.Vendedor.Id));
                        Comando.Fields.AddWithValue("id_cliente", Lfx.Data.DataBase.ConvertZeroToDBNull(this.Cliente.Id));
                        Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);
                        Comando.Fields.AddWithValue("total", this.Importe);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.DataBase.Execute(Comando);

                        // Tomo el id del recibo que acabo de crear
                        m_ItemId = this.DataBase.FieldInt("SELECT LAST_INSERT_ID()");

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
                                        case Lbl.Pagos.TipoFormasDePago.Efectivo:
                                                Cajas.Caja CajaDiaria = new Cajas.Caja(this.DataBase, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                Lfx.Types.OperationResult ResultadoEfect = CajaDiaria.Movimiento(true, this.Concepto, this.ConceptoTexto, Cliente, Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoEfect.Success == false)
                                                        return ResultadoEfect;
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.ChequePropio:
                                        case Lbl.Pagos.TipoFormasDePago.ChequeTerceros:
                                                Pg.Cheque.DataBase = this.DataBase;
                                                Pg.Cheque.Obs = ObsPago;
                                                Pg.Cheque.Concepto = Pg.Concepto;
                                                Pg.Cheque.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cheque.Recibo = this;
                                                Pg.Cheque.Cliente = this.Cliente;
                                                Pg.Cheque.Emitido = Pg.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.ChequePropio;
                                                Lfx.Types.OperationResult ResultadoCheque = Pg.Cheque.Guardar();
                                                if (ResultadoCheque.Success == false)
                                                        return ResultadoCheque;
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.Tarjeta:
                                                Pg.Cupon.DataBase = this.DataBase;
                                                Pg.Cupon.Obs = ObsPago;
                                                Pg.Cupon.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cupon.Recibo = this;
                                                Pg.Cupon.Cliente = this.Cliente;
                                                Lfx.Types.OperationResult ResultadoCupon = Pg.Cupon.Guardar();
                                                if (ResultadoCupon.Success == false)
                                                        return ResultadoCupon;
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.Caja:
                                                Pg.CajaDestino.DataBase = this.DataBase;
                                                Lfx.Types.OperationResult ResultadoDeposito = Pg.CajaDestino.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoDeposito.Success != true)
                                                        return ResultadoDeposito;
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.OtroValor:
                                                Pg.Valor.DataBase = this.DataBase;
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
                                        case Lbl.Pagos.TipoFormasDePago.Efectivo:
                                                Cajas.Caja CajaDiaria = new Cajas.Caja(this.DataBase, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                Lfx.Types.OperationResult ResultadoEfect = CajaDiaria.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, -Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoEfect.Success == false)
                                                        return ResultadoEfect;
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.ChequePropio:
                                                Pg.Cheque.DataBase = this.DataBase;
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
                                        case Lbl.Pagos.TipoFormasDePago.Caja:
                                                Pg.CajaOrigen.DataBase = this.DataBase;
                                                Lfx.Types.OperationResult ResultadoDeposito = Pg.CajaOrigen.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, -Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoDeposito.Success != true)
                                                        return ResultadoDeposito;
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.ChequeTerceros:
                                                Pg.Cheque.DataBase = this.DataBase;
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
                                        case Lbl.Pagos.TipoFormasDePago.OtroValor:
                                                Pg.Valor.DataBase = this.DataBase;
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
                        double TotalACancelar = this.Importe;

                        if (this.Facturas == null || this.Facturas.Count == 0) {
                                // No se especificaron comprob. Busco comprob a cancelar.
                                using (System.Data.DataTable FacturasConSaldo = this.DataBase.Select("SELECT id_comprob,total,cancelado FROM comprob WHERE impresa>0 AND anulada=0 AND numero>0 AND tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM') AND id_formapago IN (1, 3, 99) AND cancelado<total AND id_cliente=" + this.Cliente.Id.ToString() + " ORDER BY id_comprob")) {

                                        double ImporteRestante = this.Importe;

                                        foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                                double SaldoFactura = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
                                                double ImporteASaldar = SaldoFactura;

                                                if (ImporteASaldar > Math.Abs(ImporteRestante))
                                                        ImporteASaldar = Math.Abs(ImporteRestante);

                                                this.Facturas.Add(new ComprobanteConArticulos(DataBase, System.Convert.ToInt32(Factura["id_comprob"])));
                                                ImporteRestante += ImporteASaldar;

                                                if (ImporteRestante >= 0)
                                                        break;
                                        }
                                }
                        }

                        if (this.Facturas != null && this.Facturas.Count > 0) {
                                // Si hay una lista de comprob, las cancelo
                                foreach (Comprobantes.ComprobanteConArticulos Fact in this.Facturas) {
                                        // Calculo cuanto queda por cancelar en esta factura
                                        double ImportePendiente = Fact.Total - Fact.ImporteCancelado;

                                        // Intento cancelar todo
                                        double Cancelando = ImportePendiente;

                                        // Si se acab la plata, hago un pago parcial
                                        if (Cancelando > TotalACancelar)
                                                Cancelando = TotalACancelar;

                                        // Si alcanzo a cancelar algo, lo asiento
                                        if (Cancelando > 0) {
                                                qGen.Insert AsentarComprobantesDeEsteRecibo = new qGen.Insert("recibos_comprob");
                                                AsentarComprobantesDeEsteRecibo.Fields.AddWithValue("id_recibo", this.Id);
                                                AsentarComprobantesDeEsteRecibo.Fields.AddWithValue("id_comprob", Fact.Id);
                                                AsentarComprobantesDeEsteRecibo.Fields.AddWithValue("importe", Cancelando);
                                                this.DataBase.Execute(AsentarComprobantesDeEsteRecibo);
                                                if (Fact.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.CuentaCorriente)
                                                        this.Cliente.CuentaCorriente.Movimiento(true, 30000, "Cancelación s/" + this.ToString(), this.DePago ? Cancelando : -Cancelando, this.Obs, Fact.Id, this.Id, false);

                                                qGen.Update ActualizarCancelado = new qGen.Update("comprob");
                                                ActualizarCancelado.Fields.AddWithValue("cancelado", new qGen.SqlExpression("cancelado+" + Lfx.Types.Formatting.FormatCurrencySql(Cancelando)));
                                                ActualizarCancelado.WhereClause = new qGen.Where("id_comprob", Fact.Id);
                                                this.DataBase.Execute(ActualizarCancelado);
                                        }

                                        TotalACancelar = TotalACancelar - Cancelando;
                                        if (TotalACancelar == 0)
                                                break;
                                }
                        }

                        if (TotalACancelar > 0) {
                                Lfx.Types.OperationResult ResultadoCtaCte = Cliente.CuentaCorriente.Movimiento(true, this.Concepto, "Saldo s/" + this.ToString(), this.DePago ? TotalACancelar : -TotalACancelar, this.Obs, null, this, this.CancelaCosas);
                                if (ResultadoCtaCte.Success != true)
                                        return ResultadoCtaCte;

                                TotalACancelar = 0;
                        }

                        if (this.Tipo.ImprimirAlGuardar)
                                return this.Imprimir();
                        else
                                return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult Imprimir(string nombreImpresora)
                {
                        this.Numerar();
                        Lbl.Comprobantes.Impresion.ImpresorRecibo Impresor = new Lbl.Comprobantes.Impresion.ImpresorRecibo(this);
                        Lfx.Types.OperationResult Res = Impresor.Imprimir(nombreImpresora);
                        if (Res.Success) {
                                qGen.Update MarcarComoImpreso = new qGen.Update(this.TablaDatos);
                                MarcarComoImpreso.Fields.AddWithValue("impreso", 1);
                                MarcarComoImpreso.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                this.DataBase.Execute(MarcarComoImpreso);
                        }
                        return Res;
                }

                public void Anular()
                {
                        if (this.Existe && this.Anulado == false) {
                                // Marco el recibo como anulado
                                qGen.Update Act = new qGen.Update(this.TablaDatos);
                                Act.Fields.AddWithValue("estado", 90);
                                Act.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                this.DataBase.Execute(Act);

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
                                double TotalACancelar = this.Importe;

                                //"Descancelo" comprob
                                if (this.Facturas != null && this.Facturas.Count > 0) {
                                        // Si hay una lista de comprob, las descancelo
                                        foreach (Comprobantes.ComprobanteConArticulos Fact in this.Facturas) {
                                                // Calculo cuanto queda por cancelar en esta factura
                                                double ImportePendiente = Fact.ImporteCancelado;

                                                // Intento cancelar todo
                                                double Cancelando = ImportePendiente;

                                                // Si se acab la plata, hago un pago parcial
                                                if (Cancelando > TotalACancelar)
                                                        Cancelando = TotalACancelar;

                                                // Si alcanzo a cancelar algo, lo asiento
                                                if (Cancelando > 0) {
                                                        if (Fact.FormaDePago.Tipo == Lbl.Pagos.TipoFormasDePago.CuentaCorriente)
                                                                this.Cliente.CuentaCorriente.Movimiento(true, 30000, "Anulación de " + this.ToString(), this.DePago ? -Cancelando : Cancelando, this.Obs, Fact.Id, this.Id, false);

                                                        qGen.Update ActualizarCancelado = new qGen.Update("comprob");
                                                        ActualizarCancelado.Fields.AddWithValue("cancelado", new qGen.SqlExpression("cancelado-" + Lfx.Types.Formatting.FormatCurrencySql(Cancelando)));
                                                        ActualizarCancelado.WhereClause = new qGen.Where("id_comprob", Fact.Id);
                                                        this.DataBase.Execute(ActualizarCancelado);
                                                }

                                                TotalACancelar = TotalACancelar - Cancelando;
                                                if (TotalACancelar == 0)
                                                        break;
                                        }
                                }

                                if (TotalACancelar > 0) {
                                        this.Cliente.CuentaCorriente.Movimiento(true, this.Concepto, "Anulación de " + this.ToString(), this.DePago ? -TotalACancelar : TotalACancelar, string.Empty, null, this, false);
                                        TotalACancelar = 0;
                                }
                        }
                }
        }
}
