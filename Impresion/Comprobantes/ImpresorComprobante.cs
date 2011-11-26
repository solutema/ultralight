#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Lazaro.Impresion.Comprobantes
{
        public class ImpresorComprobante : ImpresorElemento
	{
                // Indica si el comprobante fue impreso por esta misma instancia del sistema
                // Para saber si tengo que asentar movimientos. Si lo imprimo yo, asiento los movimientos
                // Si lo imprime otro (sea un ServidorFiscal o un Lázaro en otro equipo), no asiento los 
                // movimientos ya que los asienta quien lo imprime
                public bool ImprimiLocal { get; set; }

                // Indica si es una reimpresión. Si es reimpresión, no hay que asentar movimientos.
                public bool Reimpresion { get; set; }

                public ImpresorComprobante(Lbl.ElementoDeDatos elemento, IDbTransaction transaction)
                        : base(elemento, transaction) { }

                public Lbl.Comprobantes.Comprobante Comprobante
                {
                        get
                        {
                                return this.Elemento as Lbl.Comprobantes.Comprobante;
                        }
                        set
                        {
                                this.Elemento = value;
                        }
                }

                protected override Lbl.Impresion.Plantilla ObtenerPlantilla()
		{
                        Lbl.Impresion.Plantilla Res = new Lbl.Impresion.Plantilla(this.Connection, this.Comprobante.Tipo.Nomenclatura);
                        if (Res == null)
                                Res = base.ObtenerPlantilla();

                        return Res;
		}

                protected override Lbl.Impresion.Impresora ObtenerImpresora()
                {
                        // Primero busco una una impresora específica para este comprobante
                        Lbl.Impresion.Impresora Res = this.Comprobante.ObtenerImpresora();

                        // Si no hay, devuelvo la impresora para este tipo de elemento
                        if (Res == null)
                                return base.ObtenerImpresora();
                        else
                                return Res;
                }

                public override Lbl.Comprobantes.Tipo ObtenerTipo()
                {
                        return Comprobante.Tipo;
                }

                public override Lfx.Types.OperationResult Imprimir()
                {
                        if (this.Reimpresion == false && this.Comprobante.Impreso && this.Comprobante.Tipo.PermiteImprimirVariasVeces == false)
                                return new Lfx.Types.FailureOperationResult("Este comprobante ya fue impreso y no puede volver a imprimirse");

                        if (this.Impresora == null)
                                this.Impresora = this.ObtenerImpresora();

                        Lbl.Impresion.ClasesImpresora ClaseImpr = Lbl.Impresion.ClasesImpresora.Comun;
                        if (this.Impresora != null) {
                                ClaseImpr = this.Impresora.Clase;

                                if (this.Comprobante.Tipo.EsFacturaNCoND && this.Impresora.EsVistaPrevia)
                                        return new Lfx.Types.FailureOperationResult("Este tipo de comprobante no puede ser previsualizado");
                        }

                        switch (ClaseImpr) {
                                case Lbl.Impresion.ClasesImpresora.Fiscal:
                                        if (this.Reimpresion)
                                                throw new InvalidOperationException("No se permiten reimpresiones fiscales.");

                                        // Primero hago un COMMIT, porque si no el otro proceso no va a poder hacer movimientos
                                        if (this.Transaction != null) {
                                                this.Transaction.Commit();
                                                this.Transaction.Dispose();
                                                this.Transaction = null;
                                        }
                                        ImprimiLocal = false;

                                        // Lo mando a imprimir al servidor fiscal
                                        this.Workspace.DefaultScheduler.AddTask("IMPRIMIR " + this.Elemento.Id.ToString(), "fiscal" + this.Comprobante.PV.ToString(), Impresora.Estacion);

                                        //Espero hasta que la factura está impresa o hasta que pasen X segundos
                                        System.DateTime FinEsperaFiscal = System.DateTime.Now.AddSeconds(90);
                                        int NumeroFiscal = 0;
                                        while (System.DateTime.Now < FinEsperaFiscal && NumeroFiscal == 0) {
                                                System.Threading.Thread.Sleep(1000);
                                                NumeroFiscal = this.Connection.FieldInt("SELECT numero FROM comprob WHERE impresa<>0 AND id_comprob=" + this.Elemento.Id.ToString());
                                        }
                                        if (NumeroFiscal == 0) {
                                                // Llegó el fin del tiempo de espera y no imprimió
                                                return new Lfx.Types.FailureOperationResult("Se superó el tiempo de espera para recibir respuesta del Servidor Fiscal.");
                                        } else {
                                                this.Elemento.Cargar();
                                                // Tengo número de factura. Imprimió Ok
                                                return new Lfx.Types.SuccessOperationResult();
                                        }
                                        
                                case Lbl.Impresion.ClasesImpresora.Nula:
                                        if (this.Reimpresion == false && this.Comprobante.Tipo.NumerarAlImprimir)
                                                this.Comprobante.Numerar(true);
                                        
                                        ImprimiLocal = true;

                                        return new Lfx.Types.SuccessOperationResult();

                                case Lbl.Impresion.ClasesImpresora.Comun:
                                        if (this.Impresora == null || this.Impresora.EsLocal) {
                                                if (this.Reimpresion == false == this.Comprobante.Tipo.NumerarAlImprimir)
                                                        this.Comprobante.Numerar(true);

                                                this.Plantilla = this.ObtenerPlantilla();
                                                if (this.Plantilla != null) {
                                                        this.DefaultPageSettings.Landscape = Plantilla.Landscape;
                                                        this.PrinterSettings.Copies = ((short)this.Plantilla.Copias);
                                                }

                                                //Elimina la ventana de "Imprimiendo página 1 de x"
                                                this.PrintController = new System.Drawing.Printing.StandardPrintController();

                                                ImprimiLocal = true;
                                                return base.Imprimir();
                                        } else {
                                                if (this.Reimpresion)
                                                        throw new InvalidOperationException("No se permiten reimpresiones remotas.");

                                                // Primero hago un COMMIT, porque si no el otro proceso no va a poder hacer movimientos
                                                if (this.Transaction != null) {
                                                        this.Transaction.Commit();
                                                        this.Transaction.Dispose();
                                                        this.Transaction = null;
                                                }
                                                ImprimiLocal = false;

                                                // Lo mando a imprimir a la estación remota
                                                this.Workspace.DefaultScheduler.AddTask("IMPRIMIR " + this.Elemento.GetType().ToString() + " " + this.Elemento.Id.ToString() + " EN " + this.Impresora.Dispositivo, "lazaro", Impresora.Estacion);

                                                if (Comprobante.Impreso == false) {
                                                        //Espero hasta que la factura está impresa o hasta que pasen X segundos
                                                        System.DateTime FinEspera = System.DateTime.Now.AddSeconds(90);
                                                        int Impreso = 0;
                                                        while (System.DateTime.Now < FinEspera && Impreso == 0) {
                                                                System.Threading.Thread.Sleep(1000);
                                                                Impreso = this.Connection.FieldInt("SELECT impresa FROM comprob WHERE impresa<>0 AND id_comprob=" + this.Elemento.Id.ToString());
                                                        }
                                                        if (Impreso == 0) {
                                                                // Llegó el fin del tiempo de espera y no imprimió
                                                                return new Lfx.Types.FailureOperationResult("Se superó el tiempo de espera para recibir respuesta del sistema remoto.");
                                                        } else {
                                                                this.Elemento.Cargar();
                                                                // Tengo número de factura. Imprimió Ok
                                                                return new Lfx.Types.SuccessOperationResult();
                                                        }
                                                }

                                                return new Lfx.Types.SuccessOperationResult();
                                        }

                                default:
                                        throw new NotImplementedException("No se reconoce el tipo de impresora " + ClaseImpr.ToString());
                        }
                }



                public override string ObtenerValorCampo(string nombreCampo, string formato)
                {
                        switch (nombreCampo.ToUpperInvariant()) {
                                case "TOTAL.ENLETRAS":
                                        return Lfx.Types.Formatting.SpellNumber(this.Comprobante.Total);

                                case "TIPO":
                                case "COMPROB.TIPO":
                                        return this.Comprobante.Tipo.ToString();

                                case "NUMERO":
                                case "COMPROB.NUMERO":
                                        return this.Comprobante.Numero.ToString();

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
                                        if (this.Comprobante.Cliente.ClaveTributaria != null)
                                                return this.Comprobante.Cliente.ClaveTributaria.ToString();
                                        else
                                                return this.Comprobante.Cliente.NumeroDocumento;
                                case "CUIT":
                                case "CLIENTE.CUIT":
                                        if (this.Comprobante.Cliente.ClaveTributaria != null)
                                                return this.Comprobante.Cliente.ClaveTributaria.ToString();
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

                                default:
                                        return base.ObtenerValorCampo(nombreCampo, formato);
                        }
                }
	}
}
