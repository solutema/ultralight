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

namespace Lbl.Tarjetas
{
        public enum Estado
        {
                SinPresentar = 0,
                Anulado = 1,
                Rechazaro = 2,
                Presentado = 10,
                Acreditado = 20
        }

	public class Cupon : ElementoDeDatos
	{
		//Heredar constructor
		public Cupon(Lws.Data.DataView dataView) : base(dataView) { }

		public Tarjetas.Tarjeta Tarjeta;
		public Tarjetas.Plan Plan;
                public Lbl.Comprobantes.Recibo Recibo;
                public Lbl.Comprobantes.ComprobanteConArticulos Factura; 
                public Cuentas.Concepto Concepto;
                public Personas.Persona Cliente, Vendedor;

		public Cupon(Lws.Data.DataView dataView, int idCupon)
			: this(dataView)
		{
			m_ItemId = idCupon;
                        this.Cargar();
		}

		public Cupon(Lws.Data.DataView dataView, double importe, Tarjetas.Tarjeta tarjeta, Tarjetas.Plan plan, string numero, string autorizacion)
			: this(dataView)
		{
			Importe = importe;
			Tarjeta = tarjeta;
			Plan = plan;
			Numero = numero;
			Autorizacion = autorizacion;
		}

		public override string TablaDatos
		{
			get
			{
				return "tarjetas_cupones";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_cupon";
			}
		}

                public string Numero
                {
                        get
                        {
                                return this.FieldString("numero");
                        }
                        set
                        {
                                this.Registro["numero"] = value;
                        }
                }

                public string ConceptoTexto
                {
                        get
                        {
                                return this.FieldString("concepto");
                        }
                        set
                        {
                                this.Registro["concepto"] = value;
                        }
                }

                public string Autorizacion
                {
                        get
                        {
                                return this.FieldString("autorizacion");
                        }
                        set
                        {
                                this.Registro["autorizacion"] = value;
                        }
                }

                public DateTime? FechaPresentacion
                {
                        get
                        {
                                return this.FieldDateTime("fecha_pres");
                        }
                        set
                        {
                                this.Registro["fecha_pres"] = value;
                        }
                }

                public DateTime? FechaAcreditacion
                {
                        get
                        {
                                return this.FieldDateTime("fecha_acred");
                        }
                        set
                        {
                                this.Registro["fecha_acred"] = value;
                        }
                }

                public double Importe
                {
                        get
                        {
                                return this.FieldDouble("importe");
                        }
                        set
                        {
                                this.Registro["importe"] = value;
                        }
                }

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_tarjeta"]) > 0)
                                        this.Tarjeta = new Tarjeta(this.DataView, System.Convert.ToInt32(Registro["id_tarjeta"]));
                                else
                                        this.Tarjeta = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_plan"]) > 0)
                                        this.Plan = new Plan(this.DataView, Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_plan"]));
                                else
                                        this.Plan = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_recibo"]) > 0)
                                        this.Recibo = new Comprobantes.ReciboDeCobro(this.DataView, System.Convert.ToInt32(Registro["id_recibos"]));
                                else
                                        this.Recibo = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_factura"]) > 0)
                                        this.Factura = new Comprobantes.Factura(this.DataView, System.Convert.ToInt32(Registro["id_factura"]));
                                else
                                        this.Factura = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_concepto"]) > 0)
                                        this.Concepto = new Cuentas.Concepto(this.DataView, System.Convert.ToInt32(Registro["id_concepto"]));
                                else
                                        this.Concepto = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_cliente"]) > 0)
                                        this.Cliente = new Personas.Persona(this.DataView, System.Convert.ToInt32(Registro["id_cliente"]));
                                else
                                        this.Cliente = null;

                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Registro["id_vendedor"]) > 0)
                                        this.Vendedor = new Personas.Persona(this.DataView, System.Convert.ToInt32(Registro["id_vendedor"]));
                                else
                                        this.Vendedor = null;
                        }
                        base.OnLoad();
                }

		public override string ToString()
		{
			string Res = this.Registro["numero"].ToString();
			if(Tarjeta != null)
				Res += " de " + Tarjeta.ToString();

			return Res;
		}

		public override Lfx.Types.OperationResult Guardar()
		{
                        bool Existia = this.Existe;

                        if (this.Existe == false) {
                                if (this.Tarjeta != null && this.Tarjeta.AutoPresentacion) {
                                        this.Estado = 10;
                                        this.FechaPresentacion = System.DateTime.Now;
                                }
                        }

			Lfx.Data.SqlTableCommandBuilder Comando;

                        if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                        } else {
                                Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId + "=" + this.Id.ToString());
                        }

			Comando.Fields.AddWithValue("numero", this.Numero);
                        
                        if (this.Concepto == null)
                                Comando.Fields.AddWithValue("id_concepto", null);
                        else
                                Comando.Fields.AddWithValue("id_concepto", this.Concepto.Id);

                        if (this.ConceptoTexto == null || this.ConceptoTexto.Length == 0) {
				if (this.Concepto == null)
					Comando.Fields.AddWithValue("concepto", "");
				else
                                	Comando.Fields.AddWithValue("concepto", this.Concepto.Nombre);
			} else {
                                Comando.Fields.AddWithValue("concepto", this.ConceptoTexto);
			}

			Comando.Fields.AddWithValue("autorizacion", this.Autorizacion);
                        
                        if (this.Tarjeta != null)
                                Comando.Fields.AddWithValue("id_tarjeta", this.Tarjeta.Id);
                        else
                                Comando.Fields.AddWithValue("id_tarjeta", null);

			if(this.Plan != null)
				Comando.Fields.AddWithValue("id_plan", this.Plan.Id);
			else
				Comando.Fields.AddWithValue("id_plan", null);

                        if(this.Cliente != null)
                                Comando.Fields.AddWithValue("id_cliente", this.Cliente.Id);
                        else if (this.Recibo != null && this.Recibo.Cliente != null)
                                Comando.Fields.AddWithValue("id_cliente", this.Recibo.Cliente.Id);
                        else
                                Comando.Fields.AddWithValue("id_cliente", null);

                        if (this.Vendedor != null)
                                Comando.Fields.AddWithValue("id_vendedor", this.Vendedor.Id);
                        else if (this.Recibo != null && this.Recibo.Vendedor != null)
                                Comando.Fields.AddWithValue("id_vendedor", this.Recibo.Vendedor.Id);
                        else
                                Comando.Fields.AddWithValue("id_vendedor", null);

                        if (this.Recibo != null)
                                Comando.Fields.AddWithValue("id_recibo", this.Recibo.Id);
                        else
                                Comando.Fields.AddWithValue("id_recibo", null);

                        if (this.Factura == null)
                                Comando.Fields.AddWithValue("id_factura", null);
                        else
                                Comando.Fields.AddWithValue("id_factura", this.Factura.Id);

			Comando.Fields.AddWithValue("importe", this.Importe);
			Comando.Fields.AddWithValue("obs", this.Obs);

                        if (this.FechaAcreditacion.HasValue)
                                Comando.Fields.AddWithValue("fecha_acred", this.FechaAcreditacion.Value);
                        else
                                Comando.Fields.AddWithValue("fecha_acred", null);

                        if (this.FechaPresentacion.HasValue)
                                Comando.Fields.AddWithValue("fecha_pres", this.FechaPresentacion.Value);
                        else
                                Comando.Fields.AddWithValue("fecha_pres", null);

                        Comando.Fields.AddWithValue("estado", this.Estado);

			this.AgregarTags(Comando);

			this.DataView.DataBase.Execute(Comando);

			return new Lfx.Types.SuccessOperationResult();
		}
	}
}
