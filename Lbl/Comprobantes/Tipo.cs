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

namespace Lbl.Comprobantes
{
        public class Tipo : ElementoDeDatos
        {
                public Articulos.Situacion SituacionOrigen, SituacionDestino;

                //Heredar constructor
		public Tipo(Lws.Data.DataView dataView) : base(dataView) { }

                public Tipo(Lws.Data.DataView dataView, int idTipo)
			: this(dataView)
		{
                        m_ItemId = idTipo;
		}

                public Tipo(Lws.Data.DataView dataView, string letraTipo)
                        : this(dataView)
                {
                        m_ItemId = dataView.DataBase.FieldInt("SELECT id_tipo FROM documentos_tipos WHERE letra='" + letraTipo + "'");
                }

		public override string TablaDatos
		{
			get
			{
				return "documentos_tipos";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_tipo";
			}
		}

                public override Lfx.Types.OperationResult Cargar()
                {
                        Lfx.Types.OperationResult Res = base.Cargar();
                        if (Res.Success) {
                                if (Registro["situacionorigen"] == null)
                                        SituacionOrigen = null;
                                else
                                        SituacionOrigen = new Lbl.Articulos.Situacion(this.DataView, System.Convert.ToInt32(Registro["situacionorigen"]));

                                if (Registro["situaciondestino"] == null)
                                        SituacionDestino = null;
                                else
                                        SituacionDestino = new Lbl.Articulos.Situacion(this.DataView, System.Convert.ToInt32(Registro["situaciondestino"]));
                        }

                        return Res;
                }

                public bool NumerarAlImprimir
                {
                        get
                        {
                                return System.Convert.ToBoolean(Registro["numerar_imprimir"]);
                        }
                }

                public bool NumerarAlGuardar
                {
                        get
                        {
                                return System.Convert.ToBoolean(Registro["numerar_guardar"]);
                        }
                        set
                        {
                                Registro["numerar_guardar"] = value ? 1 : 0;
                        }
                }

                public bool ImprimirAlGuardar
                {
                        get
                        {
                                return System.Convert.ToBoolean(Registro["imprimir_guardar"]);
                        }
                        set
                        {
                                Registro["imprimir_guardar"] = value ? 1 : 0;
                        }
                }

                public bool MueveStock
                {
                        get
                        {
                                return System.Convert.ToBoolean(Registro["mueve_stock"]);
                        }
                }

                /// <summary>
                /// Devuelve sólamente la letra (A, B, C, E o M, independientemente de que sea NCA, NDE, etc.)
                /// </summary>
                public string LetraSola
                {
                        get
                        {
                                return this.Nomenclatura.Replace("ND", "").Replace("NC", "");
                        }
                }


                /// <summary>
                /// La nomenclatura del tipo de comprobante (A, B, NCA, NDE, etc.)
                /// </summary>
                public string Nomenclatura
                {
                        get
                        {
                                return Registro["letra"].ToString();
                        }
                }

                public bool EsNotaCredito
                {
                        get
                        {
                                return this.Nomenclatura.Length > 2 && this.Nomenclatura.Substring(0, 2).ToUpperInvariant() == "NC";
                        }
                }

                public bool EsNotaDebito
                {
                        get
                        {
                                return this.Nomenclatura.Length > 2 && this.Nomenclatura.Substring(0, 2).ToUpperInvariant() == "ND";
                        }
                }

                public bool EsFactura
                {
                        get
                        {
                                switch (this.Nomenclatura.ToUpperInvariant())
                                {
                                        case "A":
                                        case "B":
                                        case "C":
                                        case "E":
                                        case "M":
                                                return true;
                                        default:
                                                return false;
                                }
                        }
                }

                public bool EsFacturaNCoND
                {
                        get
                        {
                                return this.EsFactura || this.EsNotaCredito || this.EsNotaDebito;
                        }
                }

                public bool EsRemito
                {
                        get
                        {
                                return this.Nomenclatura.ToUpperInvariant() == "R";
                        }
                }

                public bool EsTicket
                {
                        get
                        {
                                return this.Nomenclatura.ToUpperInvariant() == "T";
                        }
                }

                public bool EsPresupuesto
                {
                        get
                        {
                                return this.Nomenclatura.ToUpperInvariant() == "PS";
                        }
                }

                public bool PermiteImprimirVariasVeces
                {
                        get
                        {
                                return System.Convert.ToBoolean(this.Registro["imprimir_repetir"]);
                        }
                }

                public bool PermiteModificarImpresos
                {
                        get
                        {
                                return System.Convert.ToBoolean(this.Registro["imprimir_modificar"]);
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        Lfx.Data.SqlTableCommandBuilder Comando;

                        if (this.Existe == false) {
                                Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
                        } else {
                                Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("letra", this.Nomenclatura);
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("mueve_stock", this.MueveStock ? 1 : 0);
                        Comando.Fields.AddWithValue("numerar_guardar", this.NumerarAlGuardar ? 1 : 0);
                        Comando.Fields.AddWithValue("numerar_imprimir", this.NumerarAlImprimir ? 1 : 0);
                        Comando.Fields.AddWithValue("imprimir_guardar", this.ImprimirAlGuardar ? 1 : 0);
                        Comando.Fields.AddWithValue("imprimir_repetir", this.PermiteImprimirVariasVeces ? 1 : 0);
                        Comando.Fields.AddWithValue("imprimir_modificar", this.PermiteModificarImpresos ? 1 : 0);

                        if (this.SituacionOrigen == null)
                                Comando.Fields.AddWithValue("situacionorigen", null);
                        else
                                Comando.Fields.AddWithValue("situacionorigen", this.SituacionOrigen.Id);

                        if (this.SituacionDestino == null)
                                Comando.Fields.AddWithValue("situaciondestino", null);
                        else
                                Comando.Fields.AddWithValue("situaciondestino", this.SituacionDestino.Id);

                        this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        if (this.Existe == false)
                                m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(" + this.CampoId + ") FROM " + this.TablaDatos);

                        return base.Guardar();
                }
        }
}
