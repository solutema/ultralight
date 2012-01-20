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

namespace Lbl.Comprobantes
{
        [Lbl.Atributos.Datos(NombreSingular = "Comprobante",
                TablaDatos = "comprob",
                CampoId = "id_comprbo",
                TablaImagenes = "comprob_imagenes")]
        [Lbl.Atributos.Presentacion(PanelExtendido = false)]
        public abstract class Comprobante : ElementoDeDatos, IElementoConImagen, ICamposBaseEstandar
	{
                private Personas.Persona m_Vendedor, m_Cliente;
                private Entidades.Sucursal m_Sucursal;
                private ComprobanteConArticulos m_ComprobanteOriginal;
                private Tipo m_Tipo;

		//Heredar constructor
		protected Comprobante(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                protected Comprobante(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
			: base(dataBase, row) { }

                protected Comprobante(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }


		public virtual Tipo Tipo
		{
			get
			{
                                if(m_Tipo == null && this.GetFieldValue<string>("tipo_fac") != null)
                                        m_Tipo = Lbl.Comprobantes.Tipo.TodosPorLetra[this.GetFieldValue<string>("tipo_fac")];
                                return m_Tipo;
			}
                        set
                        {
                                m_Tipo = value;

                                if (value == null) {
                                        this.Registro["tipo_fac"] = null;
                                } else {
                                        this.Registro["tipo_fac"] = value.Nomenclatura;

                                        if (this.PV == 0) {
                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Documentos." + Tipo.Nomenclatura + ".PV", 0);
                                                if (this.PV /* still */ == 0) {
                                                        if (Tipo.EsFactura)
                                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Documentos.ABC.PV", 0);
                                                        else if (Tipo.EsNotaCredito)
                                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Documentos.NC.PV", 0);
                                                        else if (Tipo.EsNotaDebito)
                                                                this.PV = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Documentos.ND.PV", 0);
                                                }

                                                if (this.PV /* still */ == 0)
                                                        this.PV = this.Connection.FieldInt("SELECT MIN(numero) FROM pvs WHERE CONCAT(',', tipo_fac, ',') LIKE '%," + this.Tipo.Nomenclatura + ",%' AND tipo>0");
                                                if (this.PV /* still */ == 0)
                                                        this.PV = this.Connection.FieldInt("SELECT MIN(numero) FROM pvs WHERE CONCAT(',', tipo_fac, ',') LIKE '%," + this.Tipo.TipoBase + ",%' AND tipo>0");
                                                if (this.PV /* still */ == 0)
                                                        this.PV = this.Connection.FieldInt("SELECT MIN(numero) FROM pvs WHERE CONCAT(',', tipo_fac, ',') LIKE '%," + this.Tipo.Letra + ",%' AND tipo>0");

                                                if (this.PV /* still */ == 0)
                                                        this.PV = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Documentos.PV", 1);
                                        }
                                }
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

                /// <summary>
                /// Numera el comprobante (usando el número especificado), guardando automáticamente los cambios.
                /// </summary>
                /// <param name="numero">El número que se asignó a este comprobante.</param>
                /// <param name="yMarcarComoImpreso">Si es Verdadero, el comprobante se marca como impreso y se actualiza la fecha.</param>
                public void Numerar(int numero, bool yMarcarComoImpreso)
                {
                        qGen.Update ActualizarComprob = new qGen.Update(this.TablaDatos);

                        // Modifico Registro para no volver a cargar el comprobante desde la BD
                        Registro["numero"] = numero;
                        ActualizarComprob.Fields.AddWithValue("numero", numero);

                        string Nombre = this.PV.ToString("0000") + "-" + numero.ToString("00000000");
                        Registro["nombre"] = Nombre;
                        ActualizarComprob.Fields.AddWithValue("nombre", Nombre);

                        if (yMarcarComoImpreso) {
                                Registro["estado"] = 1;

                                Registro["fecha"] = this.Connection.ServerDateTime;

                                if (this.TablaDatos == "recibos") {
                                        ActualizarComprob.Fields.AddWithValue("impreso", 1);
                                        Registro["impreso"] = 1;
                                } else {
                                        ActualizarComprob.Fields.AddWithValue("impresa", 1);
                                        Registro["impresa"] = 1;
                                }
                                ActualizarComprob.Fields.AddWithValue("estado", 1);
                                ActualizarComprob.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        }
                        ActualizarComprob.WhereClause = new qGen.Where(this.CampoId, this.Id);

                        this.Connection.Execute(ActualizarComprob);
                }
                
                /// <summary>
                /// Numera el comprobante (usando el próximo número en el talonario), guardando automáticamente los cambios.
                /// </summary>
                /// <param name="yMarcarComoImpreso">Si es Verdadero, el comprobante se marca como impreso y se actualiza la fecha.</param>
                public void Numerar(bool yMarcarComoImpreso)
                {
                        if (this.Numero == 0) {
                                int NumeroNuevo = Numerador.ProximoNumero(this);
                                this.Numerar(NumeroNuevo, yMarcarComoImpreso);
                        }
                }


                public int PV
                {
                        get
                        {
                                return System.Convert.ToInt32(Registro["pv"]);
                        }
                        set
                        {
                                Registro["pv"] = value;
                        }
                }


                public new DateTime Fecha
                {
                        get
                        {
                                return this.GetFieldValue<DateTime>("fecha");
                        }
                        set
                        {
                                Registro["fecha"] = value;
                        }
                }


                public override void Crear()
                {
                        base.Crear();
                        this.Estado = 0;
                }

		public override string ToString()
		{
                        string Res = this.Tipo.ToString() + " " + this.PV.ToString("0000") + "-" + this.Numero.ToString("00000000");
                        if (this.Cliente != null)
                                Res += " de " + this.Cliente.ToString();
                        return Res;
		}


                public Lbl.Personas.Persona Cliente
                {
                        get
                        {
                                if (m_Cliente == null && this.GetFieldValue<int>("id_cliente") > 0)
                                        m_Cliente = new Personas.Persona(this.Connection, this.GetFieldValue<int>("id_cliente"));
                                return m_Cliente;
                        }
                        set
                        {
                                m_Cliente = value;
                                this.SetFieldValue("id_cliente", value);
                        }
                }

                public Lbl.Personas.Persona Vendedor
                {
                        get
                        {
                                if (m_Vendedor == null && this.GetFieldValue<int>("id_vendedor") > 0)
                                        m_Vendedor = new Personas.Persona(this.Connection, this.GetFieldValue<int>("id_vendedor"));
                                return m_Vendedor;
                        }
                        set
                        {
                                m_Vendedor = value;
                                this.SetFieldValue("id_vendedor", value);
                        }
                }

                public Lbl.Entidades.Sucursal Sucursal
                {
                        get
                        {
                                if (m_Sucursal == null && this.GetFieldValue<int>("id_sucursal") > 0)
                                        m_Sucursal = new Lbl.Entidades.Sucursal(this.Connection, this.GetFieldValue<int>("id_sucursal"));
                                return m_Sucursal;
                        }
                        set
                        {
                                m_Sucursal = value;
                                this.SetFieldValue("id_sucursal", value);
                        }
                }


                public virtual Lbl.Impresion.Impresora ObtenerImpresora()
                {
                        if (this.Tipo == null || this.Tipo.Impresoras == null || this.Tipo.Impresoras.Count == 0)
                                return null;

                        // Intento obtener una impresora para esta susursal, para esta estación
                        foreach (Lbl.Impresion.TipoImpresora Impr in Tipo.Impresoras) {
                                if (Impr.Estacion != null && Impr.Estacion.Equals(System.Environment.MachineName, StringComparison.InvariantCultureIgnoreCase)
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.Id)
                                        return Impr.Impresora;
                        }

                        // Intento obtener una impresora para esta estación, cualquier sucursal
                        foreach (Lbl.Impresion.TipoImpresora Impr in Tipo.Impresoras) {
                                if (Impr.Estacion != null && Impr.Estacion.Equals(System.Environment.MachineName, StringComparison.InvariantCultureIgnoreCase)
                                        && Impr.Sucursal == null)
                                        return Impr.Impresora;
                        }

                        // Intento obtener una impresora para esta sucursal, cualquier estacion
                        foreach (Lbl.Impresion.TipoImpresora Impr in Tipo.Impresoras) {
                                if (Impr.Estacion == null
                                        && Impr.Sucursal != null && Impr.Sucursal.Id == Lbl.Sys.Config.Actual.Empresa.SucursalPredeterminada.Id)
                                        return Impr.Impresora;
                        }

                        // Intento obtener una impresora para cual sucursal, cualquier estacion
                        foreach (Lbl.Impresion.TipoImpresora Impr in Tipo.Impresoras) {
                                if (Impr.Estacion == null && Impr.Sucursal == null)
                                        return Impr.Impresora;
                        }

                        return null;
                }

                public bool Impreso
                {
                        get
                        {
                                return System.Convert.ToBoolean(Registro["impresa"]);
                        }
                        set
                        {
                                Registro["impresa"] = value ? 1 : 0;
                        }
                }


		public static string FacturasDeUnRecibo(Lfx.Data.Connection dataBase, int ReciboId)
		{
			System.Text.StringBuilder Facturas = new System.Text.StringBuilder();
			System.Data.DataTable TablaFacturas = dataBase.Select("SELECT id_comprob FROM recibos_comprob WHERE id_recibo=" + ReciboId.ToString());

			foreach (System.Data.DataRow Factura in TablaFacturas.Rows)
			{
				if (Facturas.Length == 0)
					Facturas.Append(Lbl.Comprobantes.Comprobante.TipoYNumeroCompleto(dataBase, Lfx.Data.Connection.ConvertDBNullToZero(Factura["id_comprob"])));
				else
					Facturas.Append(", " + Lbl.Comprobantes.Comprobante.TipoYNumeroCompleto(dataBase, Lfx.Data.Connection.ConvertDBNullToZero(Factura["id_comprob"])));
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

                /* public virtual Lfx.Types.OperationResult Imprimir() {
                        return this.Imprimir(null);
                }
		
                public virtual Lfx.Types.OperationResult Imprimir(Lbl.Impresion.Impresora impresora)
                {
                        // Determino la impresora que le corresponde
                        if (impresora == null)
                                impresora = this.ObtenerImpresora();

                        // Si es de carga manual, presento el formulario correspondiente
                        if (impresora.CargaPapel == Lbl.Impresion.CargasPapel.Manual)
                        {
                                if (Lbl.Impresion.Services.ShowManualFeedDialog(impresora, this).Success == false)
                                        return new Lfx.Types.FailureOperationResult("Operación cancelada");
                        }
			
                        Impresion.ImpresorComprobante Impresor = new Impresion.ImpresorComprobante(this);
                        Impresor.Impresora = impresora;
                        return Impresor.Imprimir();
                } */


                /// <summary>
                /// Devuelve el tipo y número de un comprobante (por ejemplo: B 0001-00000135).
                /// </summary>
		public static string TipoYNumeroCompleto(Lfx.Data.Connection connection, int itemId)
		{
                        Lfx.Data.Row Comp = connection.Tables["comprob"].FastRows[itemId];

			if (Comp == null)
				return "";
			else
				return (string)Comp["tipo_fac"].ToString() + " " + System.Convert.ToInt32(Comp["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(Comp["numero"]).ToString("00000000");
		}

                /// <summary>
                /// Devuelve el número de un comprobante (por ejemplo: 0001-00000135).
                /// </summary>
                public static string NumeroCompleto(Lfx.Data.Connection connection, int itemId)
                {
                        Lfx.Data.Row Comp = connection.Tables["comprob"].FastRows[itemId];

                        if (Comp == null)
                                return "";
                        else
                                return System.Convert.ToInt32(Comp["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(Comp["numero"]).ToString("00000000");
                }

		public static string NombreCompletoRecibo(Lfx.Data.Connection dataBase, int iId)
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


                public Lbl.Comprobantes.ComprobanteConArticulos ComprobanteOriginal
                {
                        get
                        {
                                if (m_ComprobanteOriginal == null) {
                                        if (Registro["id_comprob_orig"] == null)
                                                m_ComprobanteOriginal = null;
                                        else
                                                m_ComprobanteOriginal = new ComprobanteConArticulos(this.Connection, System.Convert.ToInt32(Registro["id_comprob_orig"]));
                                }
                                return m_ComprobanteOriginal;
                        }
                        set
                        {
                                m_ComprobanteOriginal = value;
                        }
                }


                public virtual decimal Total
                {
                        get
                        {
                                return 0;
                        }
                }
	}
}
