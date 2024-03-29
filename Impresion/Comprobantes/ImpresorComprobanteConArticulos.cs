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
using System.Data;

namespace Lazaro.Impresion.Comprobantes
{
	public class ImpresorComprobanteConArticulos : ImpresorComprobante
	{
                public ImpresorComprobanteConArticulos(Lbl.ElementoDeDatos elemento, IDbTransaction transaction)
			: base(elemento, transaction)
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
                        if (this.Comprobante.Impreso && this.Reimpresion == false)
                                this.Reimpresion = true;

                        Lfx.Types.OperationResult ResultadoImprimir = this.Comprobante.VerificarSeries();

                        if (ResultadoImprimir.Success == false)
                                return ResultadoImprimir;

                        if (this.Comprobante.Tipo.EsFactura && this.Comprobante.FormaDePago == null)
                                throw new InvalidOperationException("La factura no tiene forma de pago.");

                        if (this.Impresora == null)
                                this.Impresora = this.ObtenerImpresora();

                        if (this.Reimpresion == false && Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Documentos.ActualizaCostoAlFacturar", 1) != 0) {
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
                                this.Comprobante.MoverExistencias(false);

                                // Asentar pagos si corresponde
                                this.Comprobante.AsentarPago(false);
                        }

                        return ResultadoImprimir;
                }

                public override string ObtenerValorCampo(string nombreCampo, string formato)
                {
                        string Res = null;
                        switch (nombreCampo.ToUpperInvariant()) {
                                case "ARTICULOS.CODIGOS":
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

                                case "ARTICULOS.CANTIDADES":
                                case "ARTÍCULOS.CANTIDADES":
                                case "CANTIDADES":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if(Res == null)
                                                        Res = Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Articulos[i].Cantidad, Lbl.Sys.Config.Articulos.Decimales);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Articulos[i].Cantidad, Lbl.Sys.Config.Articulos.Decimales);
                                        }
                                        return Res;

                                case "ARTICULOS.IVA":
                                case "ARTÍCULOS.IVA":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = this.Comprobante.Articulos[i].ObtenerAlicuota().ToString();
                                                else
                                                        Res += System.Environment.NewLine + this.Comprobante.Articulos[i].ObtenerAlicuota().Porcentaje.ToString("0.0") + "%";
                                        }
                                        return Res;

                                case "ARTICULOS.IVADISCRIMINADO":
                                case "ARTÍCULOS.IVADISCRIMINADO":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].ImporteIvaDiscriminado, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].ImporteIvaDiscriminado, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                        }
                                        return Res;

                                case "ARTÍCULOS.IMPORTESCONIVA":
                                case "ARTICULOS.IMPORTESCONIVA":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].ImporteConIva, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].ImporteConIva, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                        }
                                        return Res;

                                case "ARTÍCULOS.UNITARIOSCONIVA":
                                case "ARTICULOS.UNITARIOSCONIVA":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].UnitarioConIva, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].UnitarioConIva, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                        }
                                        return Res;

                                case "ARTÍCULOS.IMPORTESCONIVA1":
                                case "ARTÍCULOS.IMPORTESCONIVA2":
                                case "ARTÍCULOS.IMPORTESCONIVA3":
                                case "ARTÍCULOS.IMPORTESCONIVA4":
                                case "ARTÍCULOS.IMPORTESCONIVA5":
                                case "ARTÍCULOS.IMPORTESCONIVA6":
                                case "ARTÍCULOS.IMPORTESCONIVA7":
                                case "ARTÍCULOS.IMPORTESCONIVA8":
                                case "ARTÍCULOS.IMPORTESCONIVA9":
                                case "ARTICULOS.IMPORTESCONIVA1":
                                case "ARTICULOS.IMPORTESCONIVA2":
                                case "ARTICULOS.IMPORTESCONIVA3":
                                case "ARTICULOS.IMPORTESCONIVA4":
                                case "ARTICULOS.IMPORTESCONIVA5":
                                case "ARTICULOS.IMPORTESCONIVA6":
                                case "ARTICULOS.IMPORTESCONIVA7":
                                case "ARTICULOS.IMPORTESCONIVA8":
                                case "ARTICULOS.IMPORTESCONIVA9":
                                        int NumeroIvaArt = Lfx.Types.Parsing.ParseInt(nombreCampo.Substring(nombreCampo.Length - 1));
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                if (Res == null)
                                                        Res = Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].ImporteConIvaAlicuota(NumeroIvaArt), Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                                else
                                                        Res += System.Environment.NewLine + Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Articulos[i].ImporteConIvaAlicuota(NumeroIvaArt), Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                        }
                                        return Res;


                                case "ARTICULOS.DETALLES":
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

                                case "ARTICULOS.UNITARIOS":
                                case "ARTÍCULOS.UNITARIOS":
                                case "PRECIOS":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                Lbl.Comprobantes.DetalleArticulo Det = this.Comprobante.Articulos[i];
                                                string Linea = Lfx.Types.Formatting.FormatCurrencyForPrint(Det.UnitarioAImprimir, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                                if (Res == null)
                                                        Res = Linea;
                                                else
                                                        Res += System.Environment.NewLine + Linea;
                                        }
                                        return Res;

                                case "ARTICULOS.DESCUENTOS":
                                case "ARTÍCULOS.DESCUENTOS":
                                case "DESCUENTOS":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                Lbl.Comprobantes.DetalleArticulo Det = this.Comprobante.Articulos[i];
                                                string Linea;
                                                if (Det.Descuento == 0)
                                                        Linea = "--";
                                                else
                                                        Linea = Lfx.Types.Formatting.FormatNumberForPrint(Det.Descuento, 2) + "%";
                                                if (Res == null)
                                                        Res = Linea;
                                                else
                                                        Res += System.Environment.NewLine + Linea;
                                        }
                                        return Res;

                                case "ARTICULOS.IMPORTES":
                                case "ARTÍCULOS.IMPORTES":
                                case "IMPORTES":
                                        Res = null;
                                        for (int i = 0; i < this.Comprobante.Articulos.Count; i++) {
                                                Lbl.Comprobantes.DetalleArticulo Det = this.Comprobante.Articulos[i];
                                                string Linea =Lfx.Types.Formatting.FormatCurrencyForPrint(Det.ImporteAImprimir, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal); 
                                                if (Res == null)
                                                        Res = Linea;
                                                else
                                                        Res += System.Environment.NewLine + Linea;
                                        }
                                        return Res;

                                case "SUBTOTAL":
                                case "COMPROBANTE.SUBTOTAL":
                                        if (Comprobante.DiscriminaIva)
                                                return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.SubTotalSinIva, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                        else
                                                return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.SubTotal, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);

                                case "TOTAL":
                                case "COMPROBANTE.TOTAL":
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.Total, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);

                                case "IVADISCRIMINADO":
                                case "COMPROBANTE.IVADISCRIMINADO":
                                        if (Comprobante.DiscriminaIva)
                                                return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.ImporteIvaDiscriminado, Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                        else
                                                return "N/A";

                                case "COMPROBANTE.TOTALIVA1":
                                case "COMPROBANTE.TOTALIVA2":
                                case "COMPROBANTE.TOTALIVA3":
                                case "COMPROBANTE.TOTALIVA4":
                                case "COMPROBANTE.TOTALIVA5":
                                case "COMPROBANTE.TOTALIVA6":
                                case "COMPROBANTE.TOTALIVA7":
                                case "COMPROBANTE.TOTALIVA8":
                                case "COMPROBANTE.TOTALIVA9":
                                case "TOTALIVA1":
                                case "TOTALIVA2":
                                case "TOTALIVA3":
                                case "TOTALIVA4":
                                case "TOTALIVA5":
                                case "TOTALIVA6":
                                case "TOTALIVA7":
                                case "TOTALIVA8":
                                case "TOTALVA9":
                                        int NumeroIvaComprob = Lfx.Types.Parsing.ParseInt(nombreCampo.Substring(nombreCampo.Length - 1));
                                        return Lfx.Types.Formatting.FormatCurrencyForPrint(this.Comprobante.IvaAlicuota(NumeroIvaComprob), Lfx.Workspace.Master.CurrentConfig.Moneda.DecimalesFinal);
                                
                                case "RECARGO":
                                case "COMPROBANTE.RECARGO":
                                        return Lfx.Types.Formatting.FormatNumberForPrint(this.Comprobante.Recargo, 2);

                                case "FORMAPAGO":
                                case "COMPROBANTE.FORMAPAGO":
                                        if (this.Comprobante.FormaDePago == null)
                                                return "";
                                        else
                                                return this.Comprobante.FormaDePago.ToString();

                                case "SONPESOS":
                                case "COMPROBANTE.SONPESOS":
                                        return Lfx.Types.Formatting.SpellNumber(this.Comprobante.Total);

                                case "TIPO":
                                case "COMPROBANTE.TIPO":
                                        return this.Comprobante.Tipo.Nombre;

                                default:
                                        return base.ObtenerValorCampo(nombreCampo, formato);
                        }
                }
	}
}
