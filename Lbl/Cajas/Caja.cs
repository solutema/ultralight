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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Cajas
{
	public class Caja : ElementoDeDatos
	{
		//Heredar constructor
		public Caja(Lws.Data.DataView dataView, int idCaja)
			: base(dataView)
		{
			m_ItemId = idCaja;
		}

		public override string TablaDatos
		{
			get
			{
				return "cajas";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_caja";
			}
		}

		public virtual double Saldo()
		{
			return this.DataView.DataBase.FieldDouble("SELECT saldo FROM cajas_movim WHERE id_caja=" + m_ItemId.ToString() + " ORDER BY id_movim DESC");
		}

                
                public Lfx.Types.OperationResult Movimiento(bool auto, Lbl.Cajas.Concepto concepto, string textoConcepto, Lbl.Personas.Persona cliente, double importe, string obs, Lbl.Comprobantes.ComprobanteConArticulos factura, Lbl.Comprobantes.Recibo recibo, string comprobantes)
                {
                        return this.Movimiento(auto, concepto == null ? 0 : concepto.Id, textoConcepto, cliente == null ? 0 : cliente.Id, importe, obs, factura == null ? 0 : factura.Id, recibo == null ? 0 : recibo.Id, comprobantes);
                }

                public Lfx.Types.OperationResult Movimiento(bool auto, int idConcepto, string concepto, int idCliente, double importe, string obs, int idFactura, int idRecibo, string comprobantes)
		{
			double SaldoActual = this.Saldo();

                        Lfx.Data.SqlTableCommandBuilder Comando; Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, "cajas_movim");
			Comando.Fields.AddWithValue("id_caja", m_ItemId);
			Comando.Fields.AddWithValue("auto", auto ? (int)1 : (int)0);
			Comando.Fields.AddWithValue("id_concepto", Lfx.Data.DataBase.ConvertZeroToDBNull(idConcepto));
			Comando.Fields.AddWithValue("concepto", concepto);
                        Comando.Fields.AddWithValue("id_persona", this.Workspace.CurrentUser.Id);
			Comando.Fields.AddWithValue("id_cliente", Lfx.Data.DataBase.ConvertZeroToDBNull(idCliente));
			Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
			Comando.Fields.AddWithValue("importe", importe);
			Comando.Fields.AddWithValue("id_comprob", Lfx.Data.DataBase.ConvertZeroToDBNull(idFactura));
			Comando.Fields.AddWithValue("id_recibo", Lfx.Data.DataBase.ConvertZeroToDBNull(idRecibo));
			Comando.Fields.AddWithValue("comprob", comprobantes);
			Comando.Fields.AddWithValue("saldo", SaldoActual + importe);
			Comando.Fields.AddWithValue("obs", obs);
			this.DataView.Execute(Comando);

			return new Lfx.Types.SuccessOperationResult();
		}
	}

        /* public class Movimiento
        {
                bool auto;
                int idConcepto;
                string concepto;
                int idCliente;
                double importe;
                string obs;
                int idFactura;
                int idRecibo;
                string comprobantes;

                public Movimiento(Lbl.Cajas.Concepto concepto, Lbl.Personas.Persona persona, Lbl)
                {

                }
        } */
}
