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

namespace Lbl.Cajas
{
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Caja", Grupo = "Cajas")]
        [Lbl.Atributos.Datos(TablaDatos = "cajas", CampoId = "id_caja")]
        [Lbl.Atributos.Presentacion()]
	public class Caja : ElementoDeDatos, Lbl.ICamposBaseEstandar, Lbl.ICuenta
	{
                private Lbl.Bancos.Banco m_Banco = null;
                private Lbl.Entidades.Moneda m_Moneda = null;

		//Heredar constructores
                public Caja(Lfx.Data.Connection dataBase) 
                        : base(dataBase) { }

		public Caja(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Caja(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public virtual decimal ObtenerSaldo(bool forUpdate)
		{
                        qGen.Select SelSaldo = new qGen.Select("cajas_movim", forUpdate);
                        SelSaldo.Fields = "saldo";
                        SelSaldo.WhereClause = new qGen.Where("id_caja", this.Id);
                        SelSaldo.Order = "id_movim DESC";
                        SelSaldo.Window = new qGen.Window(1);

                        return this.Connection.FieldDecimal(SelSaldo);
		}

                public Bancos.Banco Banco
                {
                        get
                        {
                                if (m_Banco == null && this.GetFieldValue<int>("id_banco") > 0)
                                        m_Banco = new Bancos.Banco(this.Connection, this.GetFieldValue<int>("id_banco"));
                                return m_Banco;
                        }
                        set
                        {
                                m_Banco = value;
                                this.SetFieldValue("id_banco", value);
                        }
                }


                public Entidades.Moneda ObtenerMoneda()
                {
                        if (this.Moneda == null)
                                return Lbl.Sys.Config.Moneda.MonedaPredeterminada;
                        else
                                return this.Moneda;
                }


                public Entidades.Moneda Moneda
                {
                        get
                        {
                                if (m_Moneda == null && this.GetFieldValue<int>("id_moneda") > 0)
                                        m_Moneda = new Entidades.Moneda(this.Connection, this.GetFieldValue<int>("id_moneda"));
                                return m_Moneda;
                        }
                        set
                        {
                                m_Moneda = value;
                                this.SetFieldValue("id_moneda", value);
                        }
                }

                public string Titular
                {
                        get
                        {
                                return this.GetFieldValue<string>("titular");
                        }
                        set
                        {
                                this.Registro["titular"] = value;
                        }
                }

                public string Numero
                {
                        get
                        {
                                return this.GetFieldValue<string>("numero");
                        }
                        set
                        {
                                this.Registro["numero"] = value;
                        }
                }

                public string ClaveBancaria
                {
                        get
                        {
                                return this.GetFieldValue<string>("cbu");
                        }
                        set
                        {
                                this.Registro["cbu"] = value;
                        }
                }

                public TiposDeCaja Tipo
                {
                        get
                        {
                                return (TiposDeCaja)(this.GetFieldValue<int>("tipo"));
                        }
                        set
                        {
                                this.Registro["tipo"] = (int)value;
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;
                        if (this.Existe == false) {
                                Comando = new qGen.Insert(Connection, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue(this.CampoNombre, this.Nombre);
                        Comando.Fields.AddWithValue("titular", this.Titular);
                        if (Banco == null)
                                Comando.Fields.AddWithValue("id_banco", null);
                        else
                                Comando.Fields.AddWithValue("id_banco", this.Banco.Id);
                        if (this.Moneda == null)
                                Comando.Fields.AddWithValue("id_moneda", null);
                        else
                                Comando.Fields.AddWithValue("id_moneda", this.Moneda.Id);
                        Comando.Fields.AddWithValue("numero", this.Numero);
                        Comando.Fields.AddWithValue("tipo", (int)(this.Tipo));
                        Comando.Fields.AddWithValue("cbu", this.ClaveBancaria);
                        Comando.Fields.AddWithValue("estado", this.Estado);

                        Connection.Execute(Comando);

                        return base.Guardar();
                }

                public void Arqueo()
                {
                        this.Movimiento(false, null, "Arqueo de caja - Saldo: " + Lbl.Sys.Config.Moneda.Simbolo + " " + Lfx.Types.Formatting.FormatCurrency(this.ObtenerSaldo(false)), Lbl.Sys.Config.Actual.UsuarioConectado.Persona, 0, null, null, null, null);
                }

                public void Movimiento(bool auto, Lbl.Cajas.Concepto concepto, string textoConcepto,
                        Lbl.Personas.Persona cliente, decimal importe, string obs,
                        Lbl.Comprobantes.ComprobanteConArticulos factura, Lbl.Comprobantes.Recibo recibo, string comprobantes)
                {
                        decimal SaldoActual = this.ObtenerSaldo(true);

                        qGen.TableCommand Comando; Comando = new qGen.Insert(this.Connection, "cajas_movim");
			Comando.Fields.AddWithValue("id_caja", this.Id);
			Comando.Fields.AddWithValue("auto", auto ? 1 : 0);
                        if (concepto == null)
                                Comando.Fields.AddWithValue("id_concepto", null);
                        else
                                Comando.Fields.AddWithValue("id_concepto", concepto.Id);
                        Comando.Fields.AddWithValue("concepto", textoConcepto);
                        Comando.Fields.AddWithValue("id_persona", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                        if (cliente == null)
                                Comando.Fields.AddWithValue("id_cliente", null);
                        else
                                Comando.Fields.AddWithValue("id_cliente", cliente.Id);
			Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
			Comando.Fields.AddWithValue("importe", importe);
                        if (factura == null)
                                Comando.Fields.AddWithValue("id_comprob", null);
                        else
                                Comando.Fields.AddWithValue("id_comprob", factura.Id);
                        if (recibo == null)
                                Comando.Fields.AddWithValue("id_recibo", null);
                        else
                                Comando.Fields.AddWithValue("id_recibo", recibo.Id);
			Comando.Fields.AddWithValue("comprob", comprobantes);
			Comando.Fields.AddWithValue("saldo", SaldoActual + importe);
			Comando.Fields.AddWithValue("obs", obs);
			this.Connection.Execute(Comando);
		}


                /// <summary>
                /// Recalcula completamente el saldo de la caja, para corregir errores de transporte. Principalmente de uso interno.
                /// </summary>
                public void Recalcular()
                {
                        Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Recalculando", "Se va a recalcular el saldo de la caja " + this.ToString());
                        Progreso.Begin();

                        System.Data.DataTable Movims = this.Connection.Select("SELECT id_movim, importe FROM cajas_movim WHERE id_caja=" + this.Id.ToString() + " ORDER BY id_movim");
                        decimal Saldo = 0;
                        Progreso.Max = Movims.Rows.Count;
                        foreach (System.Data.DataRow Movim in Movims.Rows) {
                                Saldo += System.Convert.ToDecimal(Movim["importe"]);

                                qGen.Update Upd = new qGen.Update("cajas_movim");
                                Upd.Fields.AddWithValue("saldo", Saldo);
                                Upd.WhereClause = new qGen.Where("id_movim", System.Convert.ToInt32(Movim["id_movim"]));
                                this.Connection.Execute(Upd);

                                Progreso.Advance(1);
                        }
                        Progreso.End();
                }
	}
}
