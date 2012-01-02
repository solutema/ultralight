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

namespace Lbl.Bancos
{
        [Lbl.Atributos.Datos(NombreSingular = "Cheque",
                TablaDatos = "bancos_cheques",
                CampoId = "id_cheque")]
        [Lbl.Atributos.Presentacion()]
	public class Cheque : ElementoDeDatos
	{
                public Bancos.Banco Banco;
                public Lbl.Comprobantes.Recibo m_Recibo, m_ReciboPago;
                public Lbl.Cajas.Concepto Concepto;
                public Lbl.Personas.Persona Cliente;
                public Lbl.Bancos.Chequera Chequera;
                public Lbl.Comprobantes.ComprobanteConArticulos Factura;
                
                //Heredar constructor
		public Cheque(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Cheque(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Cheque(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public Cheque(Lfx.Data.Connection dataBase, Lbl.Comprobantes.ComprobanteConArticulos factura)
                        : this(dataBase)
                {
                        m_ItemId = this.Connection.FieldInt("SELECT MAX(id_cheque) FROM bancos_cheques WHERE id_comprob=" + factura.Id.ToString());
                        this.Cargar();
                }

                public Cheque(Lfx.Data.Connection dataBase, decimal importe, int numero, string emisor, NullableDateTime fechaEmision, NullableDateTime fechaCobro, Bancos.Banco banco)
			: this(dataBase)
		{
			this.Importe = importe;
                        this.Numero = numero;
                        this.Emisor = emisor;
                        this.FechaEmision = fechaEmision;
                        this.FechaCobro = fechaCobro;
                        this.Banco = banco;
		}


                public override void OnLoad()
                {
                        if (this.Registro != null) {
                                if (this.GetFieldValue<int>("id_banco") > 0)
                                        this.Banco = new Bancos.Banco(this.Connection, this.GetFieldValue<int>("id_banco"));
                                else
                                        this.Banco = null;

                                if (this.GetFieldValue<int>("id_concepto") > 0)
                                        this.Concepto = new Cajas.Concepto(this.Connection, this.GetFieldValue<int>("id_concepto"));
                                else
                                        this.Concepto = null;

                                if (this.GetFieldValue<int>("id_chequera") > 0)
                                        this.Chequera = new Bancos.Chequera(this.Connection, this.GetFieldValue<int>("id_chequera"));
                                else
                                        this.Chequera = null;

                                if (this.GetFieldValue<int>("id_cliente") > 0)
                                        this.Cliente = new Personas.Persona(this.Connection, this.GetFieldValue<int>("id_cliente"));
                                else
                                        this.Cliente = null;

                                if (this.GetFieldValue<int>("id_comprob") > 0)
                                        this.Factura = new Comprobantes.ComprobanteConArticulos(this.Connection, this.GetFieldValue<int>("id_comprob"));
                                else
                                        this.Factura = null;
                        }
                        base.OnLoad();
                }


                public Lbl.Comprobantes.Recibo ReciboCobro
                {
                        get
                        {
                                if (m_Recibo == null && this.GetFieldValue<int>("id_recibo") > 0)
                                        this.m_Recibo = new Comprobantes.ReciboDeCobro(this.Connection, this.GetFieldValue<int>("id_recibo"));
                                return m_Recibo;
                        }
                        set
                        {
                                m_Recibo = value;
                        }
                }


                public Lbl.Comprobantes.Recibo ReciboPago
                {
                        get
                        {
                                if (m_ReciboPago == null && this.GetFieldValue<int>("id_recibo_pago") > 0)
                                        this.m_ReciboPago = new Comprobantes.ReciboDeCobro(this.Connection, this.GetFieldValue<int>("id_recibo_pago"));
                                return m_ReciboPago;
                        }
                        set
                        {
                                m_ReciboPago = value;
                        }
                }


		public override string ToString()
		{
			String Res = "Cheque Nº " + Numero;
                        string Emitido = this.Emitido ? " a nombre de " : " emitido por "; 
			if(Banco != null)
				Res += " del " + Banco.ToString();
			if(Emisor != null)
				Res += ", " + Emitido + " " + Emisor;
                        else if (Cliente != null)
                                Res += ", " + Emitido + " " + Cliente.Nombre;

			return Res;
		}

                public bool Emitido
                {
                        get
                        {
                                return this.GetFieldValue<int>("emitido") != 0;
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
                                return this.GetFieldValue<string>("emitidopor");
                        }
                        set
                        {
                                this.Registro["emitidopor"] = value;
                        }
                }

                public void Pagar(Lbl.Cajas.Caja cajaOrigen)
                {
                        cajaOrigen.Movimiento(true, this.Concepto,
                                                this.Concepto.Nombre,
                                                this.Cliente, -this.Importe,
                                                "Pago de " + this.ToString(),
                                                null,
                                                this.ReciboCobro != null ? this.ReciboCobro : this.ReciboPago,
                                                null);

                        qGen.Update ActualizarEstado = new qGen.Update(this.TablaDatos);
                        ActualizarEstado.Fields.AddWithValue("estado", 10);
                        ActualizarEstado.WhereClause =new qGen.Where(this.CampoId, this.Id);
                        this.Connection.Execute(ActualizarEstado);
                }

                public int Numero
                {
                        get
                        {
                                return this.GetFieldValue<int>("numero");
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
                                return this.GetFieldValue<string>("concepto");
                        }
                        set
                        {
                                this.Registro["concepto"] = value;
                        }
                }

                public decimal Importe
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("importe");
                        }
                        set
                        {
                                this.Registro["importe"] = value;
                        }
                }

                public NullableDateTime FechaEmision
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

                public NullableDateTime FechaCobro
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
			qGen.TableCommand Comando;
                        if (this.Existe) {
				Comando = new qGen.Update(this.Connection, this.TablaDatos);
				Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
			} else {
				Comando = new qGen.Insert(this.Connection, this.TablaDatos);
			}

			Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
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
			Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);

                        if (this.ReciboCobro == null)
                                Comando.Fields.AddWithValue("id_recibo", null);
                        else
                                Comando.Fields.AddWithValue("id_recibo", this.ReciboCobro.Id);

                        if (this.ReciboPago == null)
                                Comando.Fields.AddWithValue("id_recibo_pago", null);
                        else
                                Comando.Fields.AddWithValue("id_recibo_pago", this.ReciboPago.Id);

                        if (this.Cliente == null && this.ReciboCobro != null)
                                this.Cliente = this.ReciboCobro.Cliente;
                        if (this.Cliente == null && this.ReciboPago != null)
                                this.Cliente = this.ReciboPago.Cliente;

                        if (this.Cliente == null)
                                Comando.Fields.AddWithValue("id_cliente", null);
                        else
                                Comando.Fields.AddWithValue("id_cliente", this.Cliente.Id);
                        
                        if (this.Factura == null)
                                Comando.Fields.AddWithValue("id_comprob", null);
                        else
                                Comando.Fields.AddWithValue("id_comprob", this.Factura.Id);

                        if (this.Emitido)
                                Comando.Fields.AddWithValue("nombre", "Nº " + this.Numero + " por $ " + Lfx.Types.Formatting.FormatCurrency(this.Importe, 2));
                        else
                                Comando.Fields.AddWithValue("nombre", "Nº " + this.Numero + " por $ " + Lfx.Types.Formatting.FormatCurrency(this.Importe, 2) + " emitido por " + this.Emisor);
			Comando.Fields.AddWithValue("importe", this.Importe);
			Comando.Fields.AddWithValue("fechaemision", this.FechaEmision);
			Comando.Fields.AddWithValue("emitidopor", this.Emisor);
                        Comando.Fields.AddWithValue("emitido", this.Emitido ? 1 : 0);
                        Comando.Fields.AddWithValue("estado", this.Estado);
			Comando.Fields.AddWithValue("fechacobro", this.FechaCobro);
			Comando.Fields.AddWithValue("obs", this.Obs);

			this.AgregarTags(Comando);

			this.Connection.Execute(Comando);

                        if (this.Chequera != null) {
                                qGen.Update ActualizarChequeras = new qGen.Update("chequeras");
                                ActualizarChequeras.Fields.AddWithValue("cheques_emitidos", new qGen.SqlExpression("cheques_emitidos+1"));
                                ActualizarChequeras.WhereClause = new qGen.Where("id_chequera", this.Chequera.Id);
                                this.Connection.Execute(ActualizarChequeras);
                        }

                        if (this.Emitido == false) {
                                //Asiento en la cuenta cheques, sólo para cheques de cobro
                                Cajas.Caja CajaCheques = new Lbl.Cajas.Caja(this.Connection, this.Workspace.CurrentConfig.Empresa.CajaCheques);
                                Lbl.Personas.Persona UsarCliente = this.Cliente;
                                if (UsarCliente == null && this.Factura != null)
                                        UsarCliente = this.Factura.Cliente;
                                if (UsarCliente == null && this.ReciboCobro != null)
                                        UsarCliente = this.ReciboCobro.Cliente;
                                if (UsarCliente == null && this.ReciboPago != null)
                                        UsarCliente = this.ReciboPago.Cliente;
                                CajaCheques.Movimiento(true, this.Concepto, this.ConceptoTexto, UsarCliente, this.Importe, this.ToString(), this.Factura, this.ReciboCobro != null ? this.ReciboCobro : this.ReciboPago, "");
                        }

                        return base.Guardar();
		}

                public void Anular()
                {
                        if (this.Existe && this.Anulado == false) {
                                // Marco el cheque como anulado
                                this.Estado = 90;
                                this.Guardar();

                                if (this.Emitido == false) {
                                        //Asiento en la cuenta cheques, sólo para cheques de cobro
                                        Cajas.Caja CajaCheques = new Lbl.Cajas.Caja(this.Connection, this.Workspace.CurrentConfig.Empresa.CajaCheques);
                                        Lbl.Personas.Persona UsarCliente = this.Cliente;
                                        if (UsarCliente == null && this.Factura != null)
                                                UsarCliente = this.Factura.Cliente;
                                        if (UsarCliente == null && this.ReciboCobro != null)
                                                UsarCliente = this.ReciboCobro.Cliente;
                                        if (UsarCliente == null && this.ReciboPago != null)
                                                UsarCliente = this.ReciboPago.Cliente;
                                        CajaCheques.Movimiento(true, this.Concepto, "Anulación " + this.ToString(), UsarCliente, this.Importe, null, this.Factura, this.ReciboCobro != null ? this.ReciboCobro : this.ReciboPago, "");
                                }

                                Lbl.Sys.Config.ActionLog(this.Connection, Sys.Log.Acciones.Delete, this, null);
                        }
                }

                public void Efectivizar(Lbl.Cajas.Caja destino, decimal GestionDeCobro, decimal Impuestos)
                {
                        Lbl.Cajas.Caja CajaCheques = new Lbl.Cajas.Caja(Connection, this.Workspace.CurrentConfig.Empresa.CajaCheques);

                        CajaCheques.Movimiento(true, Lbl.Cajas.Concepto.AjustesYMovimientos, "Efectivización de Cheques",
                                                null, -this.Importe, this.ToString(), null, null, null);

                        destino.Movimiento(true, Lbl.Cajas.Concepto.AjustesYMovimientos,
                                "Efectivización de Cheques", null, this.Importe - GestionDeCobro - Impuestos,
                                this.ToString(), null, null, null);

                        if (GestionDeCobro != 0)
                                destino.Movimiento(true, new Lbl.Cajas.Concepto(this.Connection, 24010), "Gestion de Cobro Cheques", null, -GestionDeCobro, this.ToString(), null, null, null);
                        if (Impuestos != 0)
                                destino.Movimiento(true, new Lbl.Cajas.Concepto(this.Connection, 23030), "Impuestos Cheques", null, -Impuestos, this.ToString(), null, null, null);

                        this.Estado = 10;
                        qGen.Update ActualizarEstado = new qGen.Update(this.TablaDatos);
                        ActualizarEstado.Fields.AddWithValue("estado", this.Estado);
                        ActualizarEstado.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        this.Connection.Execute(ActualizarEstado);
                }
	}
}
