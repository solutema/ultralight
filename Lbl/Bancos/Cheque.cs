// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lbl.Bancos
{
	public class Cheque : ElementoDeDatos
	{
                public Bancos.Banco Banco;
                public Lbl.Comprobantes.Recibo Recibo;
                public Lbl.Cuentas.Concepto Concepto;
                public Lbl.Personas.Persona Cliente;
                public Lbl.Bancos.Chequera Chequera;
                public Lbl.Comprobantes.ComprobanteConArticulos Factura;
                
                //Heredar constructor
		public Cheque(Lws.Data.DataView dataView) : base(dataView) { }

		public Cheque(Lws.Data.DataView dataView, int idCheque)
			: this(dataView)
		{
			m_ItemId = idCheque;
                        this.Cargar();
		}

                public Cheque(Lws.Data.DataView dataView, Lbl.Comprobantes.ComprobanteConArticulos factura)
                        : this(dataView)
                {
                        m_ItemId = dataView.DataBase.FieldInt("SELECT MAX(id_cheque) FROM bancos_cheques WHERE id_factura=" + factura.Id.ToString());
                        this.Cargar();
                }

                public Cheque(Lws.Data.DataView dataView, double importe, int numero, string emisor, Lfx.Types.LDateTime fechaEmision, Lfx.Types.LDateTime fechaCobro, Bancos.Banco banco)
			: this(dataView)
		{
			this.Importe = importe;
                        this.Numero = numero;
                        this.Emisor = emisor;
                        this.FechaEmision = fechaEmision;
                        this.FechaCobro = fechaCobro;
                        this.Banco = banco;
		}

		public override string TablaDatos
		{
			get
			{
				return "bancos_cheques";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_cheque";
			}
		}

                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.FieldInt("id_banco") > 0)
                                        this.Banco = new Bancos.Banco(this.DataView, this.FieldInt("id_banco"));
                                else
                                        this.Banco = null;

                                if (this.FieldInt("id_concepto") > 0)
                                        this.Concepto = new Cuentas.Concepto(this.DataView, this.FieldInt("id_concepto"));
                                else
                                        this.Concepto = null;

                                if (this.FieldInt("id_recibo") > 0)
                                        this.Recibo = new Comprobantes.ReciboDeCobro(this.DataView, this.FieldInt("id_recibos"));
                                else
                                        this.Recibo = null;

                                if (this.FieldInt("id_chequera") > 0)
                                        this.Chequera = new Bancos.Chequera(this.DataView, this.FieldInt("id_chequera"));
                                else
                                        this.Chequera = null;

                                if (this.FieldInt("id_cliente") > 0)
                                        this.Cliente = new Personas.Persona(this.DataView, this.FieldInt("id_cliente"));
                                else
                                        this.Cliente = null;

                                if (this.FieldInt("id_factura") > 0)
                                        this.Factura = new Comprobantes.Factura(this.DataView, this.FieldInt("id_factura"));
                                else
                                        this.Factura = null;
                        }
                        base.OnLoad();
                }

		public override string ToString()
		{
			String Res = "Cheque Nº " + Numero;
			if(Banco != null)
				Res += " del " + Banco.ToString();
			if(Emisor != null)
				Res += ", emitido por " + Emisor;
                        else if (Cliente != null)
                                Res += ", emitido por " + Cliente.Nombre;

			return Res;
		}

                public bool Emitido
                {
                        get
                        {
                                return this.FieldInt("emitido") != 0;
                        }
                        set
                        {
                                this.Registro["emitido"] = value ? 1 : 0;
                        }
                }

                public string Emisor
                {
                        get
                        {
                                return this.FieldString("emitidopor");
                        }
                        set
                        {
                                this.Registro["emitidopor"] = value;
                        }
                }

                public int Numero
                {
                        get
                        {
                                return this.FieldInt("numero");
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

                public Lfx.Types.LDateTime FechaEmision
                {
                        get
                        {
                                return this.FieldDateTime("fechaemision");
                        }
                        set
                        {
                                this.Registro["fechaemision"] = value;
                        }
                }

                public Lfx.Types.LDateTime FechaCobro
                {
                        get
                        {
                                return this.FieldDateTime("fechacobro");
                        }
                        set
                        {
                                this.Registro["fechacobro"] = value;
                        }
                }

                public bool Anulado
                {
                        get
                        {
                                return this.Estado == 90;
                        }
                }

		public override Lfx.Types.OperationResult Guardar()
		{
			Lfx.Data.SqlTableCommandBuilder Comando;
                        if (this.Existe) {
				Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
				Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
			} else {
				Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
			}

			Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
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

                        if (this.Banco == null)
                                Comando.Fields.AddWithValue("id_banco", null);
                        else
                                Comando.Fields.AddWithValue("id_banco", this.Banco.Id);

                        if (this.Chequera == null)
                                Comando.Fields.AddWithValue("id_chequera", null);
                        else
                                Comando.Fields.AddWithValue("id_chequera", this.Chequera.Id);

			Comando.Fields.AddWithValue("numero", this.Numero);
			Comando.Fields.AddWithValue("id_sucursal", this.DataView.Workspace.CurrentConfig.Company.CurrentBranch);

                        if (this.Recibo == null)
                                Comando.Fields.AddWithValue("id_recibo", null);
                        else
                                Comando.Fields.AddWithValue("id_recibo", this.Recibo.Id);

                        if (this.Cliente == null && this.Recibo != null)
                                this.Cliente = this.Recibo.Cliente;

                        if (this.Cliente == null)
                                Comando.Fields.AddWithValue("id_cliente", null);
                        else
                                Comando.Fields.AddWithValue("id_cliente", this.Cliente.Id);
                        
                        if (this.Factura == null)
                                Comando.Fields.AddWithValue("id_factura", null);
                        else
                                Comando.Fields.AddWithValue("id_factura", this.Factura.Id);

			Comando.Fields.AddWithValue("importe", this.Importe);
			Comando.Fields.AddWithValue("fechaemision", this.FechaEmision);
			Comando.Fields.AddWithValue("emitidopor", this.Emisor);
                        Comando.Fields.AddWithValue("emitido", this.Emitido ? 1 : 0);
			Comando.Fields.AddWithValue("fechacobro", this.FechaCobro);
			Comando.Fields.AddWithValue("obs", this.Obs);

			this.AgregarTags(Comando);

			this.DataView.Execute(Comando);

                        if (this.Emitido == false) {
                                //Asiento en la cuenta cheques, sólo para cheques de cobro
                                Cuentas.CuentaRegular CuentaCheques = new Lbl.Cuentas.CuentaRegular(this.DataView, this.DataView.Workspace.CurrentConfig.Company.CuentaCheques);
                                Lbl.Personas.Persona UsarCliente = this.Cliente;
                                if (UsarCliente == null && this.Factura != null)
                                        UsarCliente = this.Factura.Cliente;
                                if (UsarCliente == null && this.Recibo != null)
                                        UsarCliente = this.Recibo.Cliente;
                                Lfx.Types.OperationResult Res = CuentaCheques.Movimiento(true, this.Concepto, this.ConceptoTexto, UsarCliente, this.Importe, this.ToString(), this.Factura, this.Recibo, "");
                        }

                        return base.Guardar();
		}

                public void Anular()
                {
                        if (this.Anulado == false) {
                                // Marco el cheque como anulado
                                Lfx.Data.SqlUpdateBuilder Act = new Lfx.Data.SqlUpdateBuilder(this.TablaDatos);
                                Act.Fields.AddWithValue("estado", 90);
                                Act.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                                this.DataView.Execute(Act);

                                if (this.Emitido == false) {
                                        //Asiento en la cuenta cheques, sólo para cheques de cobro
                                        Cuentas.CuentaRegular CuentaCheques = new Lbl.Cuentas.CuentaRegular(this.DataView, this.DataView.Workspace.CurrentConfig.Company.CuentaCheques);
                                        Lbl.Personas.Persona UsarCliente = this.Cliente;
                                        if (UsarCliente == null && this.Factura != null)
                                                UsarCliente = this.Factura.Cliente;
                                        if (UsarCliente == null && this.Recibo != null)
                                                UsarCliente = this.Recibo.Cliente;
                                        Lfx.Types.OperationResult Res = CuentaCheques.Movimiento(true, this.Concepto, "Anulación " + this.ToString(), UsarCliente, this.Importe, null, this.Factura, this.Recibo, "");
                                }
                        }
                }
	}
}
