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

using System.Drawing;
using System.Drawing.Printing;

namespace Lazaro.Impresion.Comprobantes
{
	public class ImpresorRecibo : ImpresorComprobante
	{
                public ImpresorRecibo(Lbl.ElementoDeDatos elemento)
                        : base(elemento) { }

                public Lbl.Comprobantes.Recibo Recibo
                {
                        get
                        {
                                return this.Elemento as Lbl.Comprobantes.Recibo;
                        }
                }

                public override string ObtenerValorCampo(string nombreCampo)
                {
                        switch (nombreCampo.ToUpperInvariant()) {
                                case "CLIENTE":
                                case "CLIENTE.NOMBRE":
                                        return this.Comprobante.Cliente.ToString();

                                case "LOCALIDAD":
                                case "LOCALIDAD.NOMBRE":
                                case "CLIENTE.LOCALIDAD":
                                case "CLIENTE.LOCALIDAD.NOMBRE":
                                        if (this.Comprobante.Cliente.Localidad == null)
                                                return "";
                                        else
                                                return this.Comprobante.Cliente.Localidad.ToString();

                                case "DOMICILIO":
                                case "CLIENTE.DOMICILIO":
                                        if (this.Comprobante.Cliente.Domicilio != null && this.Comprobante.Cliente.Domicilio.Length > 0)
                                                return this.Comprobante.Cliente.Domicilio;
                                        else
                                                return this.Comprobante.Cliente.DomicilioLaboral;

                                case "CLIENTE.DOCUMENTO":
                                        if (this.Comprobante.Cliente.Cuit != null)
                                                return this.Comprobante.Cliente.Cuit.ToString();
                                        else
                                                return this.Comprobante.Cliente.NumeroDocumento;
                                case "CUIT":
                                case "CLIENTE.CUIT":
                                        if (this.Comprobante.Cliente.Cuit != null)
                                                return this.Comprobante.Cliente.Cuit.ToString();
                                        else
                                                return "";

                                case "IVA":
                                case "CLIENTE.IVA":
                                        return this.Comprobante.Cliente.SituacionTributaria.ToString();

                                case "CLIENTE.ID":
                                        return this.Comprobante.Cliente.Id.ToString();

                                case "VENDEDOR":
                                case "VENDEDOR.NOMBRE":
                                        return this.Comprobante.Vendedor.ToString();

                                case "TOTAL":
                                case "COMPROBANTE.TOTAL":
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Recibo.Total, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);

				case "SONPESOS":
                                        return Lfx.Types.Formatting.SpellNumber(this.Recibo.Total);

				case "FACTURAS":
                                        if (Recibo.Facturas.Count > 0) {
                                                string Res = null;
                                                foreach (Lbl.Comprobantes.ComprobanteConArticulos fac in Recibo.Facturas) {
                                                        if (Res == null)
                                                                Res = fac.ToString();
                                                        else
                                                                Res += ", " + fac.ToString();
                                                }
                                                return Res;
                                        } else {
                                                return "";
                                        }

                                case "VALORES":
                                        System.Text.StringBuilder Valores = new System.Text.StringBuilder();
                                        foreach (Lbl.Comprobantes.Cobro Pg in Recibo.Cobros) {
                                                switch (Pg.FormaDePago.Tipo) {
                                                        case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                                Valores.AppendLine("Efectivo                 : " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Moneda.Decimales));
                                                                break;
                                                        case Lbl.Pagos.TiposFormasDePago.ChequeTerceros:
                                                        case Lbl.Pagos.TiposFormasDePago.ChequePropio:
                                                                Valores.AppendLine("Cheque                   : " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Moneda.Decimales));
                                                                Valores.AppendLine("                           Nº " + Pg.Cheque.Numero + " del banco " + Pg.Cheque.Banco.ToString());
                                                                Valores.AppendLine("                           emitido por " + Pg.Cheque.Emisor);
                                                                Valores.AppendLine("                           el día " + Lfx.Types.Formatting.FormatDate(Pg.Cheque.FechaEmision));
                                                                Valores.AppendLine("                           pagadero el " + Lfx.Types.Formatting.FormatDate(Pg.Cheque.FechaCobro));
                                                                break;
                                                        case Lbl.Pagos.TiposFormasDePago.Tarjeta:
                                                                Valores.AppendLine("Pago con Tarjeta         : " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Moneda.Decimales));
                                                                Valores.AppendLine("                           cupón " + Pg.Cupon.ToString());
                                                                break;
                                                        case Lbl.Pagos.TiposFormasDePago.Caja:
                                                                Valores.AppendLine("Depósito en Cuenta       : " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Moneda.Decimales));
                                                                Valores.AppendLine("                           cuenta " + Pg.CajaDestino.ToString());
                                                                break;
                                                        default:
                                                                Valores.AppendLine("Otro Pago                : " + Lbl.Sys.Config.Actual.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(Pg.Importe, this.Workspace.CurrentConfig.Moneda.Decimales));
                                                                Valores.AppendLine("                           " + Pg.ToString());
                                                                break;
                                                }
                                        }
                                        return Valores.ToString();
                                default:
                                        return base.ObtenerValorCampo(nombreCampo);
                        }
                }
	}
}
