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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Cajas
{
        public class CuentaCorriente : ElementoDeDatos
        {
                //Heredar constructor
                public CuentaCorriente(Lws.Data.DataView dataView, int idCliente)
                        : base(dataView)
                {
                        m_ItemId = idCliente;
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

                public double Saldo()
                {
                        return this.DataView.DataBase.FieldDouble("SELECT saldo FROM " + this.TablaDatos + " WHERE id_cliente=" + m_ItemId.ToString() + " ORDER BY " + this.CampoId + " DESC LIMIT 1");
                }

                public Lfx.Types.OperationResult Movimiento(bool auto, int idConcepto, string concepto, double importeDebito)
                {
                        return Movimiento(auto, idConcepto, concepto, importeDebito, "", 0, 0, false);
                }

                public Lfx.Types.OperationResult Movimiento(bool auto, Lbl.Cajas.Concepto concepto, string textConcepto, double importeDebito, string obs, Lbl.Comprobantes.ComprobanteConArticulos factura, Lbl.Comprobantes.Recibo recibo, bool cancelaCosas)
                {
                        return this.Movimiento(auto, concepto == null ? 0 : concepto.Id, textConcepto, importeDebito, obs, factura == null ? 0 : factura.Id, recibo == null ? 0 : recibo.Id, cancelaCosas);
                }

                public Lfx.Types.OperationResult Movimiento(bool auto, int idConcepto, string concepto, double importeDebito, string obs, int idFactura, int idRecibo, bool cancelaCosas)
                {
                        double SaldoActual = this.Saldo();
                        Lfx.Data.SqlTableCommandBuilder Comando; Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
				
                        Comando.Fields.AddWithValue("auto", auto ? (int)1 : (int)0);
                        Comando.Fields.AddWithValue("id_concepto", Lfx.Data.DataBase.ConvertZeroToDBNull(idConcepto));
                        Comando.Fields.AddWithValue("concepto", concepto);
                        Comando.Fields.AddWithValue("id_cliente", m_ItemId);
			Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                        Comando.Fields.AddWithValue("importe", importeDebito);
                        Comando.Fields.AddWithValue("id_comprob", Lfx.Data.DataBase.ConvertZeroToDBNull(idFactura));
                        Comando.Fields.AddWithValue("id_recibo", Lfx.Data.DataBase.ConvertZeroToDBNull(idRecibo));
                        Comando.Fields.AddWithValue("comprob", "");
                        Comando.Fields.AddWithValue("saldo", SaldoActual + importeDebito);
                        Comando.Fields.AddWithValue("obs", obs);
                        this.DataView.Execute(Comando);

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
                                System.Data.DataTable FacturasConSaldo = this.DataView.DataBase.Select("SELECT id_comprob,total,cancelado FROM comprob WHERE " + SqlWhere + " ORDER BY id_comprob");


                                double ImporteRestante = importeDebito;

                                foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                        double SaldoFactura = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
                                        double ImporteASaldar = SaldoFactura;

                                        if (ImporteASaldar > Math.Abs(ImporteRestante))
                                                ImporteASaldar = Math.Abs(ImporteRestante);

                                        Lfx.Data.SqlUpdateBuilder Act = new Lfx.Data.SqlUpdateBuilder("comprob");
                                        Act.Fields.AddWithValue("cancelado", System.Convert.ToDouble(Factura["cancelado"]) + ImporteASaldar);
                                        Act.WhereClause = new Lfx.Data.SqlWhereBuilder("id_comprob", System.Convert.ToInt32(Factura["id_comprob"]));
                                        this.DataView.Execute(Act);
                                        ImporteRestante += ImporteASaldar;

                                        if (ImporteRestante >= 0)
                                                break;
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                public Lfx.Types.OperationResult IngresarComprobante(Comprobantes.ComprobanteConArticulos factura)
                {
                        if (this.Id == 0)
                                m_ItemId = factura.Cliente.Id;
                        else if (factura.Cliente.Id != this.Id)
                                throw new Exception("La factura se que ingresa no corresponde al cliente");
                        
                        if(factura.Compra)
                                throw new Exception("La factura se que ingresa no corresponde al cliente");

                        double SaldoCtaCteAntes = this.Saldo();

                        this.Movimiento(true, new Lbl.Cajas.Concepto(factura.DataView, 11000), factura.ToString() + " por $ " + Lfx.Types.Formatting.FormatCurrency(factura.Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces), factura.Tipo.EsNotaCredito ? -factura.Total : factura.Total, null, factura, null, factura.Tipo.EsFacturaNCoND);
                        double FacturaSaldo = factura.Total - factura.ImporteCancelado;

                        if (FacturaSaldo > 0) {
                                // Busca un saldo en cta cte para cancelar este comprobante
                                if ((factura.Tipo.EsNotaCredito && SaldoCtaCteAntes > 0)
                                        || (factura.Tipo.EsNotaCredito == false && SaldoCtaCteAntes < 0)) {
                                        double SaldoACancelar = factura.Tipo.EsNotaCredito ? SaldoCtaCteAntes : -SaldoCtaCteAntes;

                                        if (SaldoACancelar > FacturaSaldo)
                                                SaldoACancelar = FacturaSaldo;

                                        // Cancelo la factura con un saldo a favor que tena en cta. cte.
                                        this.DataView.DataBase.Execute("UPDATE comprob SET cancelado=cancelado+" + Lfx.Types.Formatting.FormatCurrency(SaldoACancelar, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_comprob=" + factura.Id.ToString());
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}