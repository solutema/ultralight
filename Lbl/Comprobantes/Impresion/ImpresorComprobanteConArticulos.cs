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

namespace Lbl.Comprobantes.Impresion
{
	public class ImpresorComprobanteConArticulos : ImpresorComprobante
	{
                private Lbl.Comprobantes.ComprobanteConArticulos ComprobConArt;

		public ImpresorComprobanteConArticulos(Comprobante comprobante)
			: base(comprobante)
		{
		}
		
		public override Lfx.Types.OperationResult Imprimir(string nombreImpresora)
		{
			Lfx.Types.OperationResult ResultadoImprimir = new Lfx.Types.SuccessOperationResult();
			ComprobConArt = this.Comprobante as Lbl.Comprobantes.ComprobanteConArticulos;

                        if (this.Workspace.CurrentConfig.ReadGlobalSettingInt("Sistema", "Documentos.ActualizaCostoAlFacturar", 1) != 0) {
                                // Asiento los precios de costo de los artículos de la factura (con fines estadsticos)
                                System.Data.DataTable Detalle = this.DataBase.Select("SELECT comprob_detalle.id_comprob_detalle, comprob_detalle.id_articulo, articulos.costo FROM comprob_detalle, articulos WHERE comprob_detalle.id_articulo=articulos.id_articulo AND id_comprob=" + this.Comprobante.Id.ToString());

                                foreach (System.Data.DataRow Art in Detalle.Rows) {
                                        if (Lfx.Data.DataBase.ConvertDBNullToZero(Art["id_articulo"]) > 0) {
                                                qGen.Update Act = new qGen.Update("comprob_detalle");
                                                Act.Fields.AddWithValue("costo", System.Convert.ToDouble(Art["costo"]));
                                                Act.WhereClause = new qGen.Where("id_comprob_detalle", System.Convert.ToInt32(Art["id_comprob_detalle"]));
                                                this.DataBase.Execute(Act);
                                        }
                                }
                        }

			// Determino la impresora que le corresponde
			if (nombreImpresora == null || nombreImpresora.Length == 0)
                                nombreImpresora = this.Workspace.CurrentConfig.Impresion.PreferredPrinter(ComprobConArt.Tipo.Nomenclatura);

			// Si es de carga manual, presento el formulario correspondiente
                        if (this.Workspace.CurrentConfig.Impresion.PrinterFeed(ComprobConArt.Tipo.Nomenclatura, "manual") == "manual")
			{
                                string NombreComprob = ComprobConArt.Tipo.ToString() + " " + ComprobConArt.PV.ToString("0000") + "-" + Numerador.ProximoNumero(ComprobConArt.DataBase, ComprobConArt).ToString("00000000");
                                if (Lbl.Impresion.Services.ShowManualFeedDialog(nombreImpresora, NombreComprob).Success == false)
					return new Lfx.Types.FailureOperationResult("Operación cancelada");
			}

                        if (ComprobConArt.Numero == 0 && ComprobConArt.Tipo.NumerarAlImprimir)
                                ComprobConArt.Numerar();
                        
                        ResultadoImprimir = base.Imprimir(nombreImpresora);

                        if (ResultadoImprimir.Success == true) {
                                ComprobConArt.Impreso = true;
                                ComprobConArt.Estado = 1;
                                ComprobConArt.Fecha = System.DateTime.Now;

                                //Marco la factura como impresa y actualizo la fecha
                                qGen.Update Act = new qGen.Update("comprob");
                                Act.Fields.AddWithValue("impresa", ComprobConArt.Impreso ? 1 : 0);
                                Act.Fields.AddWithValue("estado", ComprobConArt.Estado);
                                Act.Fields.AddWithValue("fecha", ComprobConArt.Fecha);
                                Act.WhereClause = new qGen.Where("id_comprob", ComprobConArt.Id);
                                this.DataBase.Execute(Act);

                                ComprobConArt.Guardar();

                                //Resto el stock si corresponde
                                if (ComprobConArt.Tipo.MueveStock)
                                        Lbl.Articulos.Stock.MoverStockComprobante(ComprobConArt);

                                Lbl.CuentasCorrientes.CuentaCorriente CtaCte = ComprobConArt.Cliente.CuentaCorriente;

                                //Asiento el pago (sólo efectivo y cta. cte.)
                                //El resto de los pagos los maneja el formulario desde donde se mandó a imprimir
                                switch (ComprobConArt.FormaDePago.Tipo) {
                                        case Lbl.Pagos.TipoFormasDePago.Efectivo:
                                                if (ComprobConArt.ImporteImpago > 0) {
                                                        Lbl.Cajas.Caja Caja = new Lbl.Cajas.Caja(this.DataBase, this.Workspace.CurrentConfig.Empresa.CajaDiaria);
                                                        Caja.Movimiento(true,
                                                                11000,
                                                                "Cobro Factura " + ComprobConArt.ToString(),
                                                                ComprobConArt.Cliente.Id,
                                                                ComprobConArt.ImporteImpago,
                                                                "",
                                                                ComprobConArt.Id,
                                                                0,
                                                                "");
							ComprobConArt.CancelarImporte(ComprobConArt.ImporteImpago, null);
                                                }
                                                break;
                                        case Lbl.Pagos.TipoFormasDePago.CuentaCorriente:
                                                CtaCte.IngresarComprobante(ComprobConArt);
                                                break;
                                }
                        }

			return ResultadoImprimir;
		}

                public override string ObtenerValorCampo(string nombreCampo)
                {
                        string Res = null;
                        switch (nombreCampo.ToUpperInvariant()) {
                                case "CODIGOS":
                                case "CÓDIGOS":
                                        Res = null;
                                        for (int i = 0; i < ComprobConArt.Articulos.Count; i++) {
                                                // FIXME: que imprima el código seleccionado por el usuario, no siempre el autonumérico
                                                if (Res == null)
                                                        Res = ComprobConArt.Articulos[i].IdArticulo.ToString();
                                                else
                                                        Res += System.Environment.NewLine + ComprobConArt.Articulos[i].IdArticulo.ToString();
                                        }
                                        return Res;
                                case "CANTIDADES":
                                        Res = null;
                                        for (int i = 0; i < ComprobConArt.Articulos.Count; i++) {
                                                if(Res == null)
                                                        Res = Lfx.Types.Formatting.FormatNumberForPrint(ComprobConArt.Articulos[i].Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatNumberForPrint(ComprobConArt.Articulos[i].Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                        }
                                        return Res;
                                case "DETALLES":
                                        Res = null;
                                        for (int i = 0; i < ComprobConArt.Articulos.Count; i++) {
                                                string NombreArticulo;
                                                if (ComprobConArt.Articulos[i].Articulo == null)
                                                        NombreArticulo = ComprobConArt.Articulos[i].Nombre;
                                                else
                                                        NombreArticulo = ComprobConArt.Articulos[i].Articulo.ToString();
                                                if (Res == null)
                                                        Res = NombreArticulo;
                                                else
                                                        Res += System.Environment.NewLine + NombreArticulo;
                                        }
                                        if(this.ComprobConArt.Descuento != 0)
                                                Res += System.Environment.NewLine + "Descuento: " + Lfx.Types.Formatting.FormatNumberForPrint(this.ComprobConArt.Descuento, 2) + "%";
                                        if (this.ComprobConArt.Recargo != 0)
                                                Res += System.Environment.NewLine + "Recargo: " + Lfx.Types.Formatting.FormatNumberForPrint(this.ComprobConArt.Descuento, 2) + "%";
                                        return Res;
                                case "PRECIOS":
                                        Res = null;
                                        for (int i = 0; i < ComprobConArt.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = Lfx.Types.Formatting.FormatCurrencyForPrint(ComprobConArt.Articulos[i].Unitario, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatCurrencyForPrint(ComprobConArt.Articulos[i].Unitario, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                        }
                                        return Res;
                                case "TOTAL":
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(ComprobConArt.Total, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                case "IMPORTES":
                                        Res = null;
                                        for (int i = 0; i < ComprobConArt.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = Lfx.Types.Formatting.FormatCurrencyForPrint(ComprobConArt.Articulos[i].Unitario * ComprobConArt.Articulos[i].Cantidad, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatCurrencyForPrint(ComprobConArt.Articulos[i].Unitario * ComprobConArt.Articulos[i].Cantidad, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                        }
                                        return Res;
                                case "RECARGO":
                                        return Lfx.Types.Formatting.FormatNumberForPrint(this.ComprobConArt.Recargo, 2);
                                case "FORMAPAGO":
                                        return this.ComprobConArt.FormaDePago.ToString();
                                case "SONPESOS":
                                        return Lfx.Types.Formatting.SpellNumber(this.ComprobConArt.Total);
                                case "TIPO":
                                        return this.ComprobConArt.Tipo.Nombre;
                                default:
                                        return base.ObtenerValorCampo(nombreCampo);
                        }
                }
	}
}
