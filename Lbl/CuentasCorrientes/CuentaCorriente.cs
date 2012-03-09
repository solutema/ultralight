#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lbl.CuentasCorrientes
{
        /// <summary>
        /// Representa la cuenta corriente de una persona (cliente o proveedor).
        /// No es realmente un ElementoDeDatos.
        /// </summary>
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Cuenta corriente", Grupo = "Cuentas")]
        [Lbl.Atributos.Datos(TablaDatos = "ctacte", CampoId = "id_movim")]
        [Lbl.Atributos.Presentacion()]
        public class CuentaCorriente : ICuenta
        {
                Lbl.Personas.Persona Persona;

                public CuentaCorriente(Lbl.Personas.Persona persona)
                {
                        this.Persona = persona;
                }

                public string TablaDatos
                {
                        get
                        {
                                return "ctacte";
                        }
                }

                public string CampoId
                {
                        get
                        {
                                return "id_movim";
                        }
                }

                public Lfx.Data.Connection Connection
                {
                        get
                        {
                                return this.Persona.Connection;
                        }
                }

                /// <summary>
                /// Calcula el saldo actual de la cuenta corriente.
                /// </summary>
                /// <returns>El monto adeudado (puede ser positivo o negativo) en la cuenta corriente.</returns>
                public decimal ObtenerSaldo(bool forUpdate)
                {
                        qGen.Select SelSaldo = new qGen.Select(this.TablaDatos, forUpdate);
                        SelSaldo.Fields = "saldo";
                        SelSaldo.WhereClause = new qGen.Where("id_cliente", this.Persona.Id);
                        SelSaldo.Order = this.CampoId + " DESC";
                        SelSaldo.Window = new qGen.Window(1);

                        return this.Connection.FieldDecimal(SelSaldo);
                }


                public decimal ObtenerSaldoAFecha(DateTime date)
                {
                        qGen.Select SelSaldo = new qGen.Select(this.TablaDatos, false);
                        SelSaldo.Fields = "saldo";
                        SelSaldo.WhereClause = new qGen.Where("id_cliente", this.Persona.Id);
                        SelSaldo.WhereClause.AddWithValue("fecha", qGen.ComparisonOperators.LessOrEqual, date);
                        SelSaldo.Order = this.CampoId + " DESC";
                        SelSaldo.Window = new qGen.Window(1);

                        return this.Connection.FieldDecimal(SelSaldo);
                }


                /// <summary>
                /// Recalcula completamente el saldo de la cuenta corriente, para corregir errores de transporte. Principalmente de uso interno
                /// durante verificaciones de consistencia o al desduplicar cuentas.
                /// </summary>
                public void Recalcular()
                {
                        Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Recalculando", "Se va a recalcular el saldo de la cuenta corriente de " + this.Persona.ToString());
                        Progreso.Modal = false;
                        Progreso.Begin();

                        System.Data.DataTable Movims = this.Connection.Select("SELECT id_movim, importe FROM ctacte WHERE id_cliente=" + this.Persona.Id.ToString() + " ORDER BY " + this.CampoId);
                        decimal Saldo = 0;
                        Progreso.Max = Movims.Rows.Count;
                        foreach (System.Data.DataRow Movim in Movims.Rows) {
                                Saldo += System.Convert.ToDecimal(Movim["importe"]);
                                
                                qGen.Update Upd = new qGen.Update(this.TablaDatos);
                                Upd.Fields.AddWithValue("saldo", Saldo);
                                Upd.WhereClause = new qGen.Where(this.CampoId, System.Convert.ToInt32(Movim[this.CampoId]));
                                this.Connection.Execute(Upd);

                                Progreso.Advance(1);
                        }
                        Progreso.End();
                }

                public void Movimiento(bool auto,
                        Lbl.Cajas.Concepto concepto,
                        string textoConcepto,
                        decimal importeDebito,
                        string obs,
                        Dictionary<string, object> extras)
                {
                        this.Movimiento(auto, concepto, textoConcepto, importeDebito, obs, null, null, null, extras);
                }

                public void Movimiento(bool auto,
                        Lbl.Cajas.Concepto concepto,
                        string textoConcepto,
                        decimal importeDebito,
                        string obs,
                        Lbl.Comprobantes.ComprobanteConArticulos comprob,
                        Lbl.Comprobantes.Recibo recibo,
                        string textoComprob)
                {
                        this.Movimiento(auto, concepto, textoConcepto, importeDebito, obs, comprob, recibo, textoComprob, null);
                }

                /// <summary>
                /// Asienta un movimiento en la cuenta corriente, y cancela comprobantes asociados.
                /// </summary>
                /// <param name="auto">Indica si es un movimiento automático (generado por el sistema) o manual (generado por el usuario).</param>
                /// <param name="concepto">El concepto bajo el cual se realiza el movimiento.</param>
                /// <param name="textoConcepto">El texto que describe al concepto.</param>
                /// <param name="importeDebito">El importe a debitar de la cuenta. Un importe negativo indica un crédito.</param>
                /// <param name="obs">Observaciones.</param>
                /// <param name="comprob">El comprobante asociado a este movimiento.</param>
                /// <param name="recibo">El recibo asociado a este movimiento.</param>
                /// <param name="textoComprob">Un texto sobre los comprobantes asociados al sistema.</param>
                /// <param name="extras">Colección de campos adicionales para el registro.</param>
                public void Movimiento(bool auto, 
                        Lbl.Cajas.Concepto concepto,
                        string textoConcepto,
                        decimal importeDebito,
                        string obs,
                        Lbl.Comprobantes.ComprobanteConArticulos comprob,
                        Lbl.Comprobantes.Recibo recibo,
                        string textoComprob,
                        Dictionary<string, object> extras)
                {
                        decimal SaldoActual = this.ObtenerSaldo(true);
                        qGen.Insert Comando= new qGen.Insert(this.Connection, this.TablaDatos);
				
                        Comando.Fields.AddWithValue("auto", auto ? (int)1 : (int)0);
                        if (concepto == null)
                                Comando.Fields.AddWithValue("id_concepto", null);
                        else
                                Comando.Fields.AddWithValue("id_concepto", concepto.Id);
                        Comando.Fields.AddWithValue("concepto", textoConcepto);
                        Comando.Fields.AddWithValue("id_cliente", this.Persona.Id);
			Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        Comando.Fields.AddWithValue("importe", importeDebito);
                        if (comprob == null)
                                Comando.Fields.AddWithValue("id_comprob", null);
                        else
                                Comando.Fields.AddWithValue("id_comprob", comprob.Id);
                        if (recibo == null)
                                Comando.Fields.AddWithValue("id_recibo", null);
                        else
                                Comando.Fields.AddWithValue("id_recibo", recibo.Id);
                        Comando.Fields.AddWithValue("comprob", textoComprob);
                        Comando.Fields.AddWithValue("saldo", SaldoActual + importeDebito);
                        Comando.Fields.AddWithValue("obs", obs);

                        if (extras != null && extras.Count > 0) {
                                foreach (KeyValuePair<string, object> extra in extras) {
                                        Comando.Fields.AddWithValue(extra.Key, extra.Value);
                                }
                        }
                        this.Connection.Execute(Comando);
                }


                /// <summary>
                /// Da por pagado (direccion = 1) o despagado (retrotrae el pago) de uno o más comprobantes con saldo.
                /// </summary>
                /// <param name="importeDebito">El importe a cancelar de los comprobantes. Un importe negativo expresa descancelar comprobantes.</param>
                /// <param name="cancelarPrimero">Indica si debo cancelar primero y luego descancelar (operación normal) o hacerlo en el ordne inverso (anulación de operación normal).</param>
                public void CancelarComprobantesConSaldo(decimal importeDebito, bool cancelarPrimero)
                {
                        decimal ImporteCancelado;

                        if(cancelarPrimero) {
                                ImporteCancelado = CancelarComprobantes(importeDebito);
                                if (importeDebito > 0)
                                        importeDebito -= ImporteCancelado;
                                else
                                        importeDebito += ImporteCancelado;

                                // Si todavía queda más saldo...
                                if (importeDebito != 0)
                                        DesCancelarComprobantes(importeDebito);
                        } else {
                                ImporteCancelado = DesCancelarComprobantes(importeDebito);
                                if (importeDebito > 0)
                                        importeDebito -= ImporteCancelado;
                                else
                                        importeDebito += ImporteCancelado;

                                // Si todavía queda más saldo...
                                if (importeDebito != 0)
                                        CancelarComprobantes(-importeDebito);
                        }
                }


                /// <summary>
                /// Descancela comprobantes hasta el importe solicitado.
                /// </summary>
                /// <param name="importe">El importe a descancelar.</param>
                private decimal DesCancelarComprobantes(decimal importe)
                {
                        return 0;
                }


                /// <summary>
                /// Cancela saldos en comprobantes hasta el importe solicitado.
                /// </summary>
                /// <param name="importe">El importe a cancelar.</param>
                /// <returns>El importe cancelado. Puede ser igual o menor al importe solicitado.</returns>
                private decimal CancelarComprobantes(decimal importe)
                {
                        qGen.Where WhereConSaldo = new qGen.Where();
                        WhereConSaldo.AddWithValue("impresa", qGen.ComparisonOperators.NotEqual, 0);
                        WhereConSaldo.AddWithValue("anulada", 0);
                        WhereConSaldo.AddWithValue("numero", qGen.ComparisonOperators.NotEqual, 0);
                        WhereConSaldo.AddWithValue("id_formapago", qGen.ComparisonOperators.In, new int[] { 1, 3, 99 });
                        WhereConSaldo.AddWithValue("id_cliente", this.Persona.Id);
                        WhereConSaldo.AddWithValue("cancelado", qGen.ComparisonOperators.LessThan, new qGen.SqlExpression("total"));
                        // impresa>0 AND anulada=0 AND numero>0 AND id_formapago IN (1, 3, 99) AND cancelado<total AND id_cliente=this.Persona.Id

                        if (importe > 0) {
                                // Es un crédito, cancelo Facturas y Notas de Débito de venta y Notas de Crédito de compra
                                qGen.Where WhereTipoCredVenta = new qGen.Where();
                                WhereTipoCredVenta.AddWithValue("compra", 0);
                                WhereTipoCredVenta.AddWithValue("tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FE", "FM", "NDA", "NDB", "NDC", "NDE", "NDM", "T" });

                                qGen.Where WhereTipoCredCompra = new qGen.Where();
                                WhereTipoCredCompra.AddWithValue("compra", 1);
                                WhereTipoCredCompra.AddWithValue("tipo_fac", qGen.ComparisonOperators.In, new string[] { "NCA", "NCB", "NCC", "NCE", "NCM" });

                                qGen.Where WhereTipoCred = new qGen.Where(qGen.AndOr.Or);
                                WhereTipoCred.AddWithValue(WhereTipoCredVenta);
                                WhereTipoCred.AddWithValue(WhereTipoCredCompra);

                                WhereConSaldo.AddWithValue(WhereTipoCred);

                                /*  AND (compra=0 AND tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')
                                    OR (compra=1 AND tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM') */

                        } else {
                                // Es un débito. Cancelo Notas de Crédito de venta y Facturas y Notas de Débito de compra
                                qGen.Where WhereTipoCredVenta = new qGen.Where();
                                WhereTipoCredVenta.AddWithValue("compra", 1);
                                WhereTipoCredVenta.AddWithValue("tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "FB", "FC", "FE", "FM", "NDA", "NDB", "NDC", "NDE", "NDM", "T" });

                                qGen.Where WhereTipoCredCompra = new qGen.Where();
                                WhereTipoCredCompra.AddWithValue("compra", 0);
                                WhereTipoCredCompra.AddWithValue("tipo_fac", qGen.ComparisonOperators.In, new string[] { "NCA", "NCB", "NCC", "NCE", "NCM" });

                                qGen.Where WhereTipoCred = new qGen.Where(qGen.AndOr.Or);
                                WhereTipoCred.AddWithValue(WhereTipoCredVenta);
                                WhereTipoCred.AddWithValue(WhereTipoCredCompra);

                                WhereConSaldo.AddWithValue(WhereTipoCred);

                                /*  AND (compra=1 AND tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM')
                                    OR (compra=0 AND tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM') */
                        }

                        qGen.Select SelFacturasConSaldo = new qGen.Select("comprob", true);
                        SelFacturasConSaldo.Fields = "id_comprob,total,cancelado";
                        SelFacturasConSaldo.WhereClause = WhereConSaldo;
                        SelFacturasConSaldo.Order = "id_comprob";
                        System.Data.DataTable FacturasConSaldo = this.Connection.Select(SelFacturasConSaldo);

                        decimal ImporteCancelar = Math.Abs(importe);
                        decimal ImporteCancelado = 0;

                        foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                decimal SaldoComprob = System.Convert.ToDecimal(Factura["total"]) - System.Convert.ToDecimal(Factura["cancelado"]);
                                decimal ImporteCancelarComprob = SaldoComprob;

                                if (ImporteCancelarComprob > ImporteCancelar)
                                        ImporteCancelarComprob = ImporteCancelar;

                                qGen.Update ActCancelarComprob = new qGen.Update("comprob");
                                ActCancelarComprob.Fields.AddWithValue("cancelado", System.Convert.ToDecimal(Factura["cancelado"]) + ImporteCancelarComprob);
                                ActCancelarComprob.WhereClause = new qGen.Where("id_comprob", System.Convert.ToInt32(Factura["id_comprob"]));
                                this.Connection.Execute(ActCancelarComprob);
                                ImporteCancelar -= ImporteCancelarComprob;
                                ImporteCancelado += ImporteCancelarComprob;

                                if (ImporteCancelar <= 0)
                                        break;
                        }

                        return ImporteCancelado;
                }
        }
}