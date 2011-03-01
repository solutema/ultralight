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
using System.ComponentModel;

namespace Lazaro.Impresion.Comprobantes
{
	public class ImpresorComprobanteConArticulos : ImpresorComprobante
	{
		public ImpresorComprobanteConArticulos(Lbl.ElementoDeDatos elemento)
			: base(elemento)
		{
		}

                public new Lbl.Comprobantes.ComprobanteConArticulos Comprobante
                {
                        get
                        {
                                return this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;
                        }
                        set
                        {
                                this.Elemento = value;
                        }
                }

                public override Lfx.Types.OperationResult Imprimir()
                {
                        Lfx.Types.OperationResult ResultadoImprimir = this.Comprobante.VerificarSeries();

                        if (ResultadoImprimir.Success == false)
                                return ResultadoImprimir;

                        if (this.Impresora == null)
                                this.Impresora = this.ObtenerImpresora();


                        if (this.Reimpresion == false && this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.ActualizaCostoAlFacturar", 1) != 0) {
                                // Asiento los precios de costo de los artículos de la factura (con fines estadsticos)
                                foreach (Lbl.Comprobantes.DetalleArticulo Det in this.Comprobante.Articulos) {
                                        if (Det.Articulo != null) {
                                                qGen.Update Act = new qGen.Update("comprob_detalle");
                                                Act.Fields.AddWithValue("costo", Det.Articulo.Costo);
                                                Act.WhereClause = new qGen.Where("id_comprob_detalle", Det.Id);
                                                this.Connection.Execute(Act);
                                        }
                                }
                        }

                        ResultadoImprimir = base.Imprimir();

                        // Los movimientos de stock y de dinero los asienta el servidor fiscal en los comprobantes fiscales
                        if (this.Reimpresion == false && ResultadoImprimir.Success == true && this.ImprimiLocal) {
                                //Resto el stock si corresponde
                                if (this.Comprobante.Tipo.MueveStock)
                                        Lbl.Articulos.Stock.MoverStockComprobante(this.Comprobante);

                                Lbl.CuentasCorrientes.CuentaCorriente CtaCte = this.Comprobante.Cliente.CuentaCorriente;

                                //Asiento el pago (sólo efectivo y cta. cte.)
                                //El resto de los pagos los maneja el formulario desde donde se mandó a imprimir
                                switch (this.Comprobante.FormaDePago.Tipo) {
                                        case Lbl.Pagos.TiposFormasDePago.Efectivo:
                                                if (this.Comprobante.ImporteImpago > 0) {
                                                        Lbl.Cajas.Caja Caja = new Lbl.Cajas.Caja(this.Elemento.Connection, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                        Caja.Movimiento(true,
                                                                Lbl.Cajas.Concepto.IngresosPorFacturacion,
                                                                "Cobro " + this.Comprobante.ToString(),
                                                                this.Comprobante.Cliente,
                                                                this.Comprobante.ImporteImpago,
                                                                null,
                                                                this.Comprobante,
                                                                null,
                                                                null);
                                                        this.Comprobante.CancelarImporte(this.Comprobante.ImporteImpago, null);
                                                }
                                                break;
                                        case Lbl.Pagos.TiposFormasDePago.CuentaCorriente:
                                                CtaCte.IngresarComprobante(this.Comprobante);
                                                break;
                                }
                        }

                        return ResultadoImprimir;
                }

                public override string ObtenerValorCampo(string nombreCampo)
                {
                        string Res = null;
                        switch (nombreCampo.ToUpperInvariant()) {
                                case "ARTÍCULOS.CÓDIGOS":
                                case "CODIGOS":
                                case "CÓDIGOS":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                // FIXME: que imprima el código seleccionado por el usuario, no siempre el autonumérico
                                                string CodigoImprimir;
                                                if (this.Comprobante.Articulos[i].Articulo == null)
                                                        CodigoImprimir = "";
                                                else
                                                        CodigoImprimir = this.Comprobante.Articulos[i].Articulo.Id.ToString();
                                                if (Res == null)
                                                        Res = CodigoImprimir;
                                                else
                                                        Res += System.Environment.NewLine + CodigoImprimir;
                                        }
                                        return Res;
                                case "ARTÍCULOS.CANTIDADES":
                                case "CANTIDADES":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if(Res == null)
                                                        Res = Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Articulos[i].Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Articulos[i].Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                        }
                                        return Res;

                                case "ARTÍCULOS.DETALLES":
                                case "DETALLES":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                string NombreArticulo;
                                                if (this.Comprobante.Articulos[i].Articulo == null)
                                                        NombreArticulo = this.Comprobante.Articulos[i].Nombre;
                                                else
                                                        NombreArticulo = this.Comprobante.Articulos[i].Articulo.ToString();
                                                if (Res == null)
                                                        Res = NombreArticulo;
                                                else
                                                        Res += System.Environment.NewLine + NombreArticulo;
                                        }
                                        if (this.Comprobante.Descuento != 0)
                                                Res += System.Environment.NewLine + "Descuento: " + Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Descuento, 2) + "%";
                                        if (this.Comprobante.Recargo != 0)
                                                Res += System.Environment.NewLine + "Recargo: " + Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Descuento, 2) + "%";
                                        return Res;

                                case "ARTÍCULOS.UNITARIOS":
                                case "PRECIOS":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                Lbl.Comprobantes.DetalleArticulo Det = this.Comprobante.Articulos[i];
                                                string Linea = Lfx.Types.Formatting.FormatCurrencyForPrint(Det.UnitarioAFacturar, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                                if (Res == null)
                                                        Res = Linea;
                                                else
                                                        Res += System.Environment.NewLine + Linea;
                                        }
                                        return Res;

                                case "ARTÍCULOS.IMPORTES":
                                case "IMPORTES":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                Lbl.Comprobantes.DetalleArticulo Det = this.Comprobante.Articulos[i];
                                                string Linea =Lfx.Types.Formatting.FormatCurrencyForPrint(Det.UnitarioAFacturar * Det.Cantidad, this.Workspace.CurrentConfig.Moneda.DecimalesFinal); 
                                                if (Res == null)
                                                        Res = Linea;
                                                else
                                                        Res += System.Environment.NewLine + Linea;
                                        }
                                        return Res;

                                case "SUBTOTAL":
                                case "COMPROBANTE.SUBTOTAL":
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.SubTotalSinIva, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);

                                case "TOTAL":
                                case "COMPROBANTE.TOTAL":
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Total, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);

                                case "COMPROBANTE.IVADISCRIMINADO":
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.ImporteIvaDiscriminado, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);

                                case "RECARGO":
                                case "COMPROBANTE.RECARGO":
                                        return Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Recargo, 2);

                                case "FORMAPAGO":
                                case "COMPROBANTE.FORMAPAGO":
                                        return this.Comprobante.FormaDePago.ToString();

                                case "SONPESOS":
                                case "COMPROBANTE.SONPESOS":
                                        return Lfx.Types.Formatting.SpellNumber(this.Comprobante.Total);

                                case "TIPO":
                                case "COMPROBANTE.TIPO":
                                        return this.Comprobante.Tipo.Nombre;

                                default:
                                        return base.ObtenerValorCampo(nombreCampo);
                        }
                }
	}
}
