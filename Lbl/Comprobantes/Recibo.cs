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
        public class Recibo : Comprobante
        {
                //Heredar constructor
                public Recibo(Lws.Data.DataView dataView)
                        : base(dataView)
                {
                        this.Crear();
                        this.Vendedor = new Personas.Persona(dataView, dataView.Workspace.CurrentUser.UserId);
                }

                public Recibo(Lws.Data.DataView dataView, Personas.Persona cliente)
                        : this(dataView)
                {
                        this.Crear();
                        this.Cliente = cliente;
                }

                public Recibo(Lws.Data.DataView dataView, int idRecibo)
                        : this(dataView)
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

                public override string CampoId
                {
                        get
                        {
                                return "id_recibo";
                        }
                }

                public ColeccionComprobanteConArticulos Facturas = new ColeccionComprobanteConArticulos();
                public Cuentas.Concepto Concepto;
                public int PV;
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
                                this.Numero = this.DataView.DataBase.FieldInt("SELECT MAX(numero) FROM recibos WHERE pv=" + this.PV.ToString() + " AND tipo_fac='" + this.Tipo.Nomenclatura + "'") + 1;
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                this.Cliente = new Lbl.Personas.Persona(this.DataView, System.Convert.ToInt32(m_Registro["id_cliente"]));
                                this.Vendedor = new Lbl.Personas.Persona(this.DataView, System.Convert.ToInt32(m_Registro["id_vendedor"]));
                                this.Numero = System.Convert.ToInt32(m_Registro["numero"]);
                                this.PV = System.Convert.ToInt32(m_Registro["pv"]);
                                this.Tipo = new Tipo(this.DataView, m_Registro["tipo_fac"].ToString());

                                if (m_Registro["id_concepto"] != null)
                                        this.Concepto = new Lbl.Cuentas.Concepto(this.DataView, this.FieldInt("id_concepto"));
                                else
                                        this.Concepto = null;

                                if (m_Registro["concepto"] != null)
                                        this.ConceptoTexto = m_Registro["concepto"].ToString();
                                else
                                        this.ConceptoTexto = string.Empty;

                                this.Facturas.Clear();
                                this.Cobros.Clear();
                                this.Pagos.Clear();

                                //Cargo facturas asociadas al recibo
                                System.Data.DataTable TablaFacturas = DataView.DataBase.Select("SELECT * FROM recibos_facturas WHERE id_recibo=" + this.Id.ToString());
                                foreach (System.Data.DataRow Factura in TablaFacturas.Rows) {
                                        Facturas.Add(new Factura(this.DataView, System.Convert.ToInt32(Factura["id_factura"])));
                                }

                                //Cargo pagos asociados al registro
                                // Pagos en efectivo
                                System.Data.DataTable TablaPagos = DataView.DataBase.Select("SELECT * FROM cuentas_movim WHERE id_cuenta=" + this.Workspace.CurrentConfig.Company.CajaDiaria.ToString() + " AND id_recibo=" + Id.ToString());
                                foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                        if (this.DePago) {
                                                Pago Pg = new Pago(this.DataView, FormasDePago.Efectivo, Math.Abs(System.Convert.ToDouble(Pago["importe"])));
                                                Pg.Recibo = this;
                                                Pagos.Add(Pg);
                                        } else {
                                                Cobro Cb = new Cobro(this.DataView, FormasDePago.Efectivo, Math.Abs(System.Convert.ToDouble(Pago["importe"])));
                                                Cb.Recibo = this;
                                                Cobros.Add(Cb);
                                        }
                                }

                                // Pagos con cheque
                                TablaPagos = this.DataView.DataBase.Select("SELECT id_cheque FROM bancos_cheques WHERE id_recibo=" + Id.ToString());
                                foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                        Bancos.Cheque Ch = new Lbl.Bancos.Cheque(DataView, System.Convert.ToInt32(Pago["id_cheque"]));
                                        Ch.Recibo = this;
                                        if (this.DePago)
                                                Pagos.Add(new Pago(Ch));
                                        else
                                                Cobros.Add(new Cobro(Ch));
                                }

                                // Pagos con Tarjetas de Crédito y Débito
                                TablaPagos = this.DataView.DataBase.Select("SELECT id_cupon FROM tarjetas_cupones WHERE id_recibo=" + Id.ToString());
                                foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                        Tarjetas.Cupon Cp = new Lbl.Tarjetas.Cupon(DataView, System.Convert.ToInt32(Pago["id_cupon"]));
                                        Cp.Recibo = this;
                                        Cobros.Add(new Cobro(Cp));
                                }

                                // Acreditaciones en cuenta regular (excepto caja diaria)
                                TablaPagos = this.DataView.DataBase.Select("SELECT * FROM cuentas_movim WHERE auto=1 AND id_cuenta<>" + this.Workspace.CurrentConfig.Company.CajaDiaria.ToString() + " AND id_cuenta<>" + this.Workspace.CurrentConfig.Company.CuentaCheques.ToString() + " AND id_recibo=" + Id.ToString());
                                foreach (System.Data.DataRow Pago in TablaPagos.Rows) {
                                        if (this.DePago) {
                                                Pago Pg = new Pago(this.DataView, FormasDePago.CuentaRegular, Math.Abs(System.Convert.ToDouble(Pago["importe"])));
                                                Pg.Recibo = this;
                                                Pg.CuentaOrigen = new Cuentas.CuentaRegular(DataView, System.Convert.ToInt32(Pago["id_cuenta"]));
                                                Pagos.Add(Pg);
                                        } else {
                                                Cobro Cb = new Cobro(this.DataView, FormasDePago.CuentaRegular, System.Convert.ToDouble(Pago["importe"]));
                                                Cb.Recibo = this;
                                                Cb.CuentaDestino = new Cuentas.CuentaRegular(DataView, System.Convert.ToInt32(Pago["id_cuenta"]));
                                                Cobros.Add(Cb);
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
                                        this.Concepto = new Lbl.Cuentas.Concepto(this.DataView, 21000);
                                else
                                        //Ingresos por facturación
                                        this.Concepto = new Lbl.Cuentas.Concepto(this.DataView, 11000);
                        }
                        if (this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos." + this.Tipo.Nomenclatura + ".NumerarAlGuardar", 1) == 1)
                                this.Numerar();

                        // Asiento el recibo
                        Lfx.Data.SqlTableCommandBuilder Comando;

                        if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                        } else {
                                throw new Exception("Lbl: No se puede cambiar un recibo impreso");
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
                        Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Company.CurrentBranch);
                        Comando.Fields.AddWithValue("total", this.Importe);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        // Tomo el id del recibo que acabo de crear
                        m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(id_recibo) AS id_recibo FROM recibos WHERE numero=" + this.Numero.ToString() + " AND pv=" + this.PV.ToString() + " AND tipo_fac='" + this.Tipo.Nomenclatura + "'");

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
                                switch (Pg.FormaDePago) {
                                        case FormasDePago.Efectivo:
                                                Cuentas.CuentaRegular CuentaCaja = new Cuentas.CuentaRegular(this.DataView, this.Workspace.CurrentConfig.Company.CajaDiaria);
                                                Lfx.Types.OperationResult ResultadoEfect = CuentaCaja.Movimiento(true, this.Concepto, this.ConceptoTexto, Cliente, Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoEfect.Success == false)
                                                        return ResultadoEfect;
                                                break;
                                        case FormasDePago.Cheque:
                                                Pg.Cheque.DataView = this.DataView;
                                                Pg.Cheque.Obs = ObsPago;
                                                Pg.Cheque.Concepto = Pg.Concepto;
                                                Pg.Cheque.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cheque.Recibo = this;
                                                Pg.Cheque.Cliente = this.Cliente;
                                                Lfx.Types.OperationResult ResultadoCheque = Pg.Cheque.Guardar();
                                                if (ResultadoCheque.Success == false)
                                                        return ResultadoCheque;
                                                break;
                                        case FormasDePago.Tarjeta:
                                        case FormasDePago.TarjetaDeDebito:
                                                Pg.Cupon.DataView = this.DataView;
                                                Pg.Cupon.Obs = ObsPago;
                                                Pg.Cupon.ConceptoTexto = Pg.ConceptoTexto;
                                                Pg.Cupon.Recibo = this;
                                                Pg.Cupon.Cliente = this.Cliente;
                                                Lfx.Types.OperationResult ResultadoCupon = Pg.Cupon.Guardar();
                                                if (ResultadoCupon.Success == false)
                                                        return ResultadoCupon;
                                                break;
                                        case FormasDePago.CuentaRegular:
                                                Pg.CuentaDestino.DataView = this.DataView;
                                                Lfx.Types.OperationResult ResultadoDeposito = Pg.CuentaDestino.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoDeposito.Success != true)
                                                        return ResultadoDeposito;
                                                break;
                                }
                        }

                        foreach (Pago Pg in this.Pagos) {
                                Pg.Concepto = this.Concepto;
                                Pg.ConceptoTexto = this.ConceptoTexto;
                                switch (Pg.FormaDePago) {
                                        case FormasDePago.Efectivo:
                                                Cuentas.CuentaRegular CuentaCaja = new Cuentas.CuentaRegular(this.DataView, this.Workspace.CurrentConfig.Company.CajaDiaria);
                                                Lfx.Types.OperationResult ResultadoEfect = CuentaCaja.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, -Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoEfect.Success == false)
                                                        return ResultadoEfect;
                                                break;
                                        case FormasDePago.Cheque:
                                                Pg.Cheque.DataView = this.DataView;
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
                                        case FormasDePago.CuentaRegular:
                                                Pg.CuentaOrigen.DataView = this.DataView;
                                                Lfx.Types.OperationResult ResultadoDeposito = Pg.CuentaOrigen.Movimiento(true, Pg.Concepto, Pg.ConceptoTexto, this.Cliente, -Pg.Importe, ObsPago, null, this, string.Empty);
                                                if (ResultadoDeposito.Success != true)
                                                        return ResultadoDeposito;
                                                break;
                                }
                        }

                        // Doy las facturas por canceladas
                        double TotalACancelar = this.Importe;

                        if (this.Facturas == null || this.Facturas.Count == 0) {
                                // No se especificaron facturas. Busco facturas a cancelar.
                                System.Data.DataTable FacturasConSaldo = this.DataView.DataBase.Select("SELECT id_factura,total,cancelado FROM facturas WHERE impresa>0 AND anulada=0 AND numero>0 AND tipo_fac IN ('A', 'B', 'C', 'E', 'M', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM') AND id_formapago IN (1, 3, 99) AND cancelado<total AND id_cliente=" + this.Cliente.Id.ToString() + " ORDER BY id_factura");

                                double ImporteRestante = this.Importe;

                                foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                        double SaldoFactura = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
                                        double ImporteASaldar = SaldoFactura;

                                        if (ImporteASaldar > Math.Abs(ImporteRestante))
                                                ImporteASaldar = Math.Abs(ImporteRestante);

                                        this.Facturas.Add(new ComprobanteConArticulos(DataView, System.Convert.ToInt32(Factura["id_factura"])));
                                        ImporteRestante += ImporteASaldar;

                                        if (ImporteRestante >= 0)
                                                break;
                                }
                        }

                        if (this.Facturas != null && this.Facturas.Count > 0) {
                                // Si hay una lista de facturas, las cancelo
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
                                                this.DataView.DataBase.Execute("INSERT INTO recibos_facturas (id_recibo, id_factura, importe) VALUES (" + this.Id.ToString() + ", " + Fact.Id.ToString() + ", " + Lfx.Types.Formatting.FormatCurrencySql(Cancelando) + ")");
                                                if (Fact.FormaDePago == FormasDePago.CuentaCorriente) {
                                                        Cuentas.CuentaCorriente CtaCte = new Lbl.Cuentas.CuentaCorriente(this.DataView, this.Cliente.Id);
                                                        CtaCte.Movimiento(true, 30000, "Cancelación s/" + this.ToString(), this.DePago ? Cancelando : -Cancelando, this.Obs, Fact.Id, this.Id, false);
                                                }
                                                this.DataView.DataBase.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.Formatting.FormatCurrencySql(Cancelando) + " WHERE id_factura=" + Fact.Id.ToString());
                                        }

                                        TotalACancelar = TotalACancelar - Cancelando;
                                        if (TotalACancelar == 0)
                                                break;
                                }
                        }

                        if (TotalACancelar > 0) {
                                Cuentas.CuentaCorriente CtaCte = new Lbl.Cuentas.CuentaCorriente(this.DataView, Cliente.Id);
                                Lfx.Types.OperationResult ResultadoCtaCte = CtaCte.Movimiento(true, this.Concepto, "Saldo a favor s/" + this.ToString(), this.DePago ? TotalACancelar : -TotalACancelar, string.Empty, null, this, this.CancelaCosas);
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
                        if (Res.Success)
                                this.DataView.DataBase.Execute("UPDATE recibos SET impreso=1 WHERE id_recibo=" + this.Id.ToString());
                        return Res;
                }

                public void Anular()
                {
                        if (this.Existe && this.Anulado == false) {
                                // Marco el recibo como anulado
                                Lfx.Data.SqlUpdateBuilder Act = new Lfx.Data.SqlUpdateBuilder(this.TablaDatos);
                                Act.Fields.AddWithValue("estado", 90);
                                Act.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                                this.DataView.Execute(Act);

                                if (this.DePago) {
                                        foreach (Cobro Cb in this.Cobros) {
                                                Cb.Anular();
                                        }
                                } else {
                                        foreach (Pago Pg in this.Pagos) {
                                                Pg.Anular();
                                        }
                                }
                        }
                }
        }
}
