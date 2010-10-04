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
        public class Tipo : ElementoDeDatos
        {
                public Articulos.Situacion SituacionOrigen, SituacionDestino;

                //Heredar constructor
		public Tipo(Lfx.Data.DataBase dataBase)
                        : base(dataBase) { }

                public Tipo(Lfx.Data.DataBase dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Tipo(Lfx.Data.DataBase dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public Tipo(Lfx.Data.DataBase dataBase, string letraTipo)
                        : this(dataBase)
                {
                        m_ItemId = dataBase.FieldInt("SELECT id_tipo FROM documentos_tipos WHERE letra='" + letraTipo + "'");
                        if (m_ItemId == 0)
                                throw new InvalidOperationException("No existe el tipo de documento " + letraTipo);
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
                                        SituacionOrigen = new Lbl.Articulos.Situacion(this.DataBase, System.Convert.ToInt32(Registro["situacionorigen"]));

                                if (Registro["situaciondestino"] == null)
                                        SituacionDestino = null;
                                else
                                        SituacionDestino = new Lbl.Articulos.Situacion(this.DataBase, System.Convert.ToInt32(Registro["situaciondestino"]));
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
                                switch(this.Nomenclatura) {
                                        case "FA":
                                        case "NCA":
                                        case "NDA":
                                                return "A";
                                        case "FB":
                                        case "NCB":
                                        case "NDB":
                                                return "B";
                                        case "FC":
                                        case "NCC":
                                        case "NDC":
                                                return "C";
                                        case "FE":
                                        case "NCE":
                                        case "NDE":
                                                return "E";
                                        case "FM":
                                        case "NCM":
                                        case "NDM":
                                                return "M";
                                        default:
                                                return "";

                                }
                        }
                }

                /// <summary>
                /// Devuelve sólamente el tipo (F, NC, ND, sin letra A, B, etc.)
                /// </summary>
                public string TipoBase
                {
                        get
                        {
                                if (this.EsFactura)
                                        return "F";
                                else if (this.EsNotaCredito)
                                        return "NC";
                                else if (this.EsNotaDebito)
                                        return "ND";
                                else
                                        return this.Nomenclatura;
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
                                        case "FA":
                                        case "FB":
                                        case "FC":
                                        case "FE":
                                        case "FM":
                                        case "FP":
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

                public bool EsPedido
                {
                        get
                        {
                                return this.Nomenclatura.ToUpperInvariant() == "PD";
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
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.DataBase, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.DataBase, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
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

                        this.DataBase.Execute(Comando);

                        return base.Guardar();
                }
        }
}
