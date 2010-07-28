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

namespace Lbl.CuentasCorrientes
{
        /// <summary>
        /// Representa la cuenta corriente de una persona (cliente o proveedor).
        /// </summary>
        public class CuentaCorriente : ElementoDeDatos
        {
                //Heredar constructor
                public CuentaCorriente(Lfx.Data.DataBase dataBase, int idPersona)
                        : base(dataBase)
                {
                        m_ItemId = idPersona;
                }

                public override string TablaDatos
                {
                        get
                        {
                                return "ctacte";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_movim";
                        }
                }

                /// <summary>
                /// Calcula el saldo actual de la cuenta corriente.
                /// </summary>
                /// <returns>El monto adeudado (puede ser positivo o negativo) en la cuenta corriente.</returns>
                public double Saldo()
                {
                        return this.DataBase.FieldDouble("SELECT saldo FROM " + this.TablaDatos + " WHERE id_cliente=" + this.Id.ToString() + " ORDER BY " + this.CampoId + " DESC LIMIT 1");
                }


                /// <summary>
                /// Recalcula completamente el saldo de la cuenta corriente, para corregir errores de transporte. Principalmente de uso interno
                /// durante verificaciones de consistencia o al desduplicar cuentas.
                /// </summary>
                public void Recalcular()
                {
                        System.Data.DataTable Movims = this.DataBase.Select("SELECT id_movim, importe FROM ctacte WHERE id_cliente=" + this.Id.ToString() + " ORDER BY " + this.CampoId);
                        double Saldo = 0;
                        foreach (System.Data.DataRow Movim in Movims.Rows) {
                                Saldo += System.Convert.ToDouble(Movim["importe"]);
                                
                                qGen.Update Upd = new qGen.Update(this.TablaDatos);
                                Upd.Fields.AddWithValue("saldo", Saldo);
                                Upd.WhereClause = new qGen.Where(this.CampoId, System.Convert.ToInt32(Movim[this.CampoId]));
                                this.DataBase.Execute(Upd);
                        }
                }

                public Lfx.Types.OperationResult Movimiento(bool auto, int idConcepto, string concepto, double importeDebito)
                {
                        return Movimiento(auto, idConcepto, concepto, importeDebito, "", 0, 0, false);
                }

                public Lfx.Types.OperationResult Movimiento(bool auto, Lbl.Cajas.Concepto concepto, string textConcepto, double importeDebito, string obs, Lbl.Comprobantes.ComprobanteConArticulos comprob, Lbl.Comprobantes.Recibo recibo, bool cancelaCosas)
                {
                        return this.Movimiento(auto, concepto == null ? 0 : concepto.Id, textConcepto, importeDebito, obs, comprob == null ? 0 : comprob.Id, recibo == null ? 0 : recibo.Id, cancelaCosas);
                }

                /// <summary>
                /// Asienta un movimiento en la cuenta corriente.
                /// </summary>
                /// <param name="auto">Indica si es un movimiento automático (generado por el sistema) o manual (generado por el usuario).</param>
                /// <param name="idConcepto">El concepto bajo el cual se realiza el movimiento.</param>
                /// <param name="concepto">El texto que describe al concepto.</param>
                /// <param name="importeDebito">El importe a debitar de la cuenta. Un importe negativo indica un crédito.</param>
                /// <param name="obs">Observaciones.</param>
                /// <param name="idComprob">El comprobante asociado a este movimiento.</param>
                /// <param name="idRecibo">El recibo asociado a este movimiento.</param>
                /// <param name="cancelaCosas">Indica si el monto del movimiento se usa para cancelar comprobantes impagos.</param>
                /// <returns>El resultado de la operación</returns>
                public Lfx.Types.OperationResult Movimiento(bool auto, int idConcepto, string concepto, double importeDebito, string obs, int idComprob, int idRecibo, bool cancelaCosas)
                {
                        double SaldoActual = this.Saldo();
                        qGen.TableCommand Comando; Comando = new qGen.Insert(this.DataBase, this.TablaDatos);
				
                        Comando.Fields.AddWithValue("auto", auto ? (int)1 : (int)0);
                        Comando.Fields.AddWithValue("id_concepto", Lfx.Data.DataBase.ConvertZeroToDBNull(idConcepto));
                        Comando.Fields.AddWithValue("concepto", concepto);
                        Comando.Fields.AddWithValue("id_cliente", m_ItemId);
			Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        Comando.Fields.AddWithValue("importe", importeDebito);
                        Comando.Fields.AddWithValue("id_comprob", Lfx.Data.DataBase.ConvertZeroToDBNull(idComprob));
                        Comando.Fields.AddWithValue("id_recibo", Lfx.Data.DataBase.ConvertZeroToDBNull(idRecibo));
                        Comando.Fields.AddWithValue("comprob", "");
                        Comando.Fields.AddWithValue("saldo", SaldoActual + importeDebito);
                        Comando.Fields.AddWithValue("obs", obs);
                        this.DataBase.Execute(Comando);

                        if (cancelaCosas) {
                                string SqlWhere = "impresa>0 AND anulada=0 AND numero>0 AND id_formapago IN (1, 3, 99) AND cancelado<total AND id_cliente=" + m_ItemId.ToString();
                                if (importeDebito < 0) {
                                        // Es un crédito (débito negativo)
                                        // Cancelo saldos en facturas, notas de débito y notas de crédito de compra
                                        SqlWhere += @" AND (
                                                        (compra=0 AND tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM'))
                                                        OR
                                                        (compra=1 AND tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM'))
                                                         )";
                                } else {
                                        // Es un débito. Cancelo comprobantes de compra, o Notas de Crédito
                                        SqlWhere += @" AND (
                                                        (compra=1 AND tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM', 'NDA', 'NDB', 'NDC', 'NDE', 'NDM'))
                                                        OR
                                                        (compra=0 AND tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM'))
                                                         )";
                                }
                                System.Data.DataTable FacturasConSaldo = this.DataBase.Select("SELECT id_comprob,total,cancelado FROM comprob WHERE " + SqlWhere + " ORDER BY id_comprob");


                                double ImporteRestante = importeDebito;

                                foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                        double SaldoFactura = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
                                        double ImporteASaldar = SaldoFactura;

                                        if (ImporteASaldar > Math.Abs(ImporteRestante))
                                                ImporteASaldar = Math.Abs(ImporteRestante);

                                        qGen.Update Act = new qGen.Update("comprob");
                                        Act.Fields.AddWithValue("cancelado", System.Convert.ToDouble(Factura["cancelado"]) + ImporteASaldar);
                                        Act.WhereClause = new qGen.Where("id_comprob", System.Convert.ToInt32(Factura["id_comprob"]));
                                        this.DataBase.Execute(Act);
                                        ImporteRestante += ImporteASaldar;

                                        if (ImporteRestante >= 0)
                                                break;
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                /// <summary>
                /// Ingresa un comprobante (factura, nota de crédito o nota de débito) a la cuenta corriente, realizando el movimiento correspondiente.
                /// </summary>
                /// <param name="comprob">El comprobante a ingresar.</param>
                public Lfx.Types.OperationResult IngresarComprobante(Comprobantes.ComprobanteConArticulos comprob)
                {
                        if (this.Id == 0)
                                m_ItemId = comprob.Cliente.Id;
                        else if (comprob.Cliente.Id != this.Id)
                                throw new InvalidOperationException("La factura se que ingresa no corresponde al cliente");
                        
                        if(comprob.Compra)
                                throw new InvalidOperationException("La factura se que ingresa no corresponde al cliente");

                        double SaldoCtaCteAntes = this.Saldo();

                        this.Movimiento(true, new Lbl.Cajas.Concepto(comprob.DataBase, 11000), comprob.ToString() + " por $ " + Lfx.Types.Formatting.FormatCurrency(comprob.Total, this.Workspace.CurrentConfig.Moneda.Decimales), comprob.Tipo.EsNotaCredito ? -comprob.Total : comprob.Total, null, comprob, null, comprob.Tipo.EsFacturaNCoND);
                        double FacturaSaldo = comprob.Total - comprob.ImporteCancelado;

                        if (FacturaSaldo > 0) {
                                // Busca un saldo en cta cte para cancelar este comprobante
                                if ((comprob.Tipo.EsNotaCredito && SaldoCtaCteAntes > 0)
                                        || (comprob.Tipo.EsNotaCredito == false && SaldoCtaCteAntes < 0)) {
                                        double SaldoACancelar = comprob.Tipo.EsNotaCredito ? SaldoCtaCteAntes : -SaldoCtaCteAntes;

                                        if (SaldoACancelar > FacturaSaldo)
                                                SaldoACancelar = FacturaSaldo;

                                        // Cancelo la factura con un saldo a favor que tena en cta. cte.
                                        qGen.Update ActualizarComprob = new qGen.Update("comprob");
                                        ActualizarComprob.Fields.AddWithValue("cancelado", new qGen.SqlExpression("cancelado+" + Lfx.Types.Formatting.FormatCurrencySql(SaldoACancelar)));
                                        ActualizarComprob.WhereClause = new qGen.Where("id_comprob", comprob.Id);
                                        this.DataBase.Execute(ActualizarComprob);
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}