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

namespace Lbl.Cuentas
{
        public class CuentaCorriente : Cuenta
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

                public Lfx.Types.OperationResult Movimiento(bool auto, Lbl.Cuentas.Concepto concepto, string textConcepto, double importeDebito, string obs, Lbl.Comprobantes.ComprobanteConArticulos factura, Lbl.Comprobantes.Recibo recibo, bool cancelaCosas)
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
                        Comando.Fields.AddWithValue("id_factura", Lfx.Data.DataBase.ConvertZeroToDBNull(idFactura));
                        Comando.Fields.AddWithValue("id_recibo", Lfx.Data.DataBase.ConvertZeroToDBNull(idRecibo));
                        Comando.Fields.AddWithValue("comprob", "");
                        Comando.Fields.AddWithValue("saldo", SaldoActual + importeDebito);
                        Comando.Fields.AddWithValue("obs", obs);
                        this.DataView.DataBase.Execute(Comando);

                        if (cancelaCosas && importeDebito < 0) {
                                // Débito negativo... es un crédito
                                // Cancelo saldos de facturas que haya en cta. cte. pendientes de pago
                                System.Data.DataTable FacturasConSaldo = this.DataView.DataBase.Select("SELECT * FROM facturas WHERE impresa>0 AND anulada=0 AND numero>0 AND tipo_fac IN ('A', 'B', 'C', 'NDA', 'NDB', 'NDC') AND id_formapago IN (1, 3, 99) AND cancelado<total AND id_cliente=" + m_ItemId.ToString() + " ORDER BY id_factura");

                                double ImporteRestante = importeDebito;

                                foreach (System.Data.DataRow Factura in FacturasConSaldo.Rows) {
                                        double SaldoFactura = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
                                        double ImporteASaldar = SaldoFactura;

                                        if (ImporteASaldar > Math.Abs(ImporteRestante))
                                                ImporteASaldar = Math.Abs(ImporteRestante);

                                        this.DataView.DataBase.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.Formatting.FormatCurrency(ImporteASaldar, this.DataView.Workspace.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + Factura["id_factura"].ToString());
                                        ImporteRestante += ImporteASaldar;

                                        if (ImporteRestante >= 0)
                                                break;
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }

                public Lfx.Types.OperationResult IngresarComprobante(Comprobantes.ComprobanteConArticulos factura, double valorMaximo)
                {
                        if (this.Id == 0)
                                m_ItemId = factura.Cliente.Id;
                        else if (factura.Cliente.Id != this.Id)
                                throw new Exception("La factura no que ingresa no corresponde al cliente");

                        double SaldoCtaCteAntes = this.Saldo();

                        this.Movimiento(true, new Lbl.Cuentas.Concepto(factura.DataView, 11000), factura.ToString() + " pendiente por $ " + Lfx.Types.Formatting.FormatCurrency(factura.Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces), factura.Total, null, factura, null, false);
                        double FacturaSaldo = factura.Total - factura.ImporteCancelado;
                        double SaldoCancelado = 0;

                        if (valorMaximo == 0)
                                valorMaximo = FacturaSaldo;

                        if (FacturaSaldo > 0 && factura.Tipo.EsNotaCredito == false) {
                                // Busca un saldo a favor no sólo en NC, sino directamente en la tabla ctacte
                                // ya que puede tener saldo a favor por un recibo o un ajuste
                                if (SaldoCtaCteAntes < 0) {
                                        double SaldoACancelar = -SaldoCtaCteAntes;

                                        if (SaldoACancelar > FacturaSaldo)
                                                SaldoACancelar = FacturaSaldo;

                                        // Cancelo la factura con un saldo a favor que tena en cta. cte.
                                        this.DataView.DataBase.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.Formatting.FormatCurrency(SaldoACancelar, this.Workspace.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + factura.Id.ToString());
                                        SaldoCancelado += SaldoACancelar;
                                }
                        }

                        return new Lfx.Types.SuccessOperationResult();
                }
        }
}