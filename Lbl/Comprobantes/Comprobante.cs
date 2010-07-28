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

namespace Lbl.Comprobantes
{
	public abstract class Comprobante : ElementoDeDatos
	{
		//Heredar constructor
		protected Comprobante(Lfx.Data.DataBase dataBase) : base(dataBase) { }

		public Personas.Persona Vendedor, Cliente;
		public Entidades.Sucursal Sucursal;
                private Comprobante m_ComprobanteOriginal;
                public Articulos.Situacion SituacionOrigen, SituacionDestino;
                private Tipo m_Tipo;

		#region Propiedades

		public virtual Tipo Tipo
		{
			get
			{
                                if(m_Tipo == null && this.FieldString("tipo_fac") != null)
                                        Tipo = new Tipo(this.DataBase, this.FieldString("tipo_fac"));
                                return m_Tipo;
			}
                        set
                        {
                                m_Tipo = value;
                        }
		}

                public int Numero
                {
                        get
                        {
                                return System.Convert.ToInt32(Registro["numero"]);
                        }
                        set
                        {
                                Registro["numero"] = value;
                        }
                }

		#endregion

		public override string ToString()
		{
                        string Res = this.FieldString("tipo_fac") + " " + this.FieldInt("pv").ToString("0000") + "-" + this.FieldInt("numero").ToString("00000000");
                        if (this.Cliente != null)
                                Res += " de " + this.Cliente.ToString();
                        return Res;
		}

                public override Lfx.Types.OperationResult Cargar()
                {
                        m_ComprobanteOriginal = null;
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success) {
                                if (this.Registro["situacionorigen"] == null) {
                                        if(Tipo != null)
                                                SituacionOrigen = Tipo.SituacionOrigen;
                                } else {
                                        SituacionOrigen = new Lbl.Articulos.Situacion(this.DataBase, System.Convert.ToInt32(Registro["situacionorigen"]));
                                }

                                if (this.Registro["situaciondestino"] == null) {
                                        if (Tipo != null)
                                                SituacionDestino = Tipo.SituacionDestino;
                                } else {
                                        SituacionDestino = new Lbl.Articulos.Situacion(this.DataBase, System.Convert.ToInt32(Registro["situaciondestino"]));
                                }
                        }

                        return Res;
                }

		public static string FacturasDeUnRecibo(Lfx.Data.DataBase dataBase, int ReciboId)
		{
			System.Text.StringBuilder Facturas = new System.Text.StringBuilder();
			System.Data.DataTable TablaFacturas = dataBase.Select("SELECT id_comprob FROM recibos_comprob WHERE id_recibo=" + ReciboId.ToString());

			foreach (System.Data.DataRow Factura in TablaFacturas.Rows)
			{
				if (Facturas.Length == 0)
					Facturas.Append(Lbl.Comprobantes.Comprobante.NumeroCompleto(dataBase, Lfx.Data.DataBase.ConvertDBNullToZero(Factura["id_comprob"])));
				else
					Facturas.Append(", " + Lbl.Comprobantes.Comprobante.NumeroCompleto(dataBase, Lfx.Data.DataBase.ConvertDBNullToZero(Factura["id_comprob"])));
			}

			return Facturas.ToString();
		}

		public static string NombreTipo(string tipoComprob)
		{
			// Devuelve el nombre de un tipo de comprobante
			// Por ejemplo, para el parmetro "NCA", devuelve "Nota de Crédito A"
			switch (tipoComprob)
			{
				case "F":
					return "Factura";

				case "T":
					return "Ticket";

				case "FA":
					return "Factura A";

				case "FB":
					return "Factura B";

				case "FC":
					return "Factura C";

                                case "FE":
                                        return "Factura E";

				case "FM":
					return "Factura M";

				case "R":
					return "Remito";

				case "RC":
					return "Recibo";
				
				case "RCP":
					return "Recibo de Pago";

				case "NC":
					return "Nota de Crédito";

				case "ND":
					return "Nota de Débito";

				case "NCA":
					return "Nota de Crédito A";

				case "NDA":
					return "Nota de Débito A";

				case "NCB":
					return "Nota de Crédito B";

				case "NDB":
					return "Nota de Débito B";

				case "NCD":
					return "Nota de Crédito C";

				case "NDD":
					return "Nota de Débito C";

				case "PS":
					return "Presupuesto";

				case "OE":
					return "Orden de Entrega";

				// Sección Pedidos
				case "NP":
					return "Nota de Pedido";

				case "PD":
					return "Pedido";

				case "NV":
					return "Nota de Venta";

				default:
					return tipoComprob;
			}
		}
		
		public virtual Lfx.Types.OperationResult Imprimir() {
			return this.Imprimir(null);
		}
		
		public virtual Lfx.Types.OperationResult Imprimir(string nombreImpresora)
		{
			// Determino la impresora que le corresponde
			if (nombreImpresora != null && nombreImpresora.Length == 0)
                                nombreImpresora = this.Workspace.CurrentConfig.Impresion.PreferredPrinter(this.Tipo.Nomenclatura);

			// Si es de carga manual, presento el formulario correspondiente
                        if (this.Workspace.CurrentConfig.Impresion.PrinterFeed(this.Tipo.Nomenclatura, "manual") == "manual")
			{
                                if (Lbl.Impresion.Services.ShowManualFeedDialog(nombreImpresora, this.ToString()).Success == false)
					return new Lfx.Types.FailureOperationResult("Operación cancelada");
			}
			
			Impresion.ImpresorComprobante Impresor = new Impresion.ImpresorComprobante(this);
			return Impresor.Imprimir(nombreImpresora);
		}

		public static string NumeroCompleto(Lfx.Data.DataBase dataBase, int iId)
		{
			// Toma el Id de factura y devuelve el tipo y número (por ejemplo: B 0001-00000135)
                        Lfx.Data.Row TmpFactura = dataBase.Tables["comprob"].FastRows[iId]; //dataBase.Row("comprob", "tipo_fac, pv, numero", "id_comprob", iId);

			if (TmpFactura == null)
				return "";
			else
				return (string)TmpFactura["tipo_fac"].ToString() + " " + System.Convert.ToInt32(TmpFactura["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(TmpFactura["numero"]).ToString("00000000");
		}

		public static string NombreCompletoRecibo(Lfx.Data.DataBase dataBase, int iId)
		{
			// Toma el Id del recibo y devuelve el tipo y número (por ejemplo: "Recibo #003" o "Comprobante de Pago #256")
			Lfx.Data.Row TmpRecibo = dataBase.Row("recibos", "id_recibo", iId);

			if (TmpRecibo == null)
				return "";
			else if (System.Convert.ToInt32(TmpRecibo["numero"]) > 0)
				return "Recibo Nº " + System.Convert.ToInt32(TmpRecibo["numero"]).ToString("00000000");
			else
				return "Recibo S/N";
		}

                public Lbl.Comprobantes.Comprobante ComprobanteOriginal
                {
                        get
                        {
                                if (m_ComprobanteOriginal == null) {
                                        if (Registro["id_comprob_orig"] == null)
                                                m_ComprobanteOriginal = null;
                                        else
                                                m_ComprobanteOriginal = new ComprobanteConArticulos(this.DataBase, System.Convert.ToInt32(Registro["id_comprob_orig"]));
                                }
                                return m_ComprobanteOriginal;
                        }
                        set
                        {
                                m_ComprobanteOriginal = value;
                        }
                }
	}
}
