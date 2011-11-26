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
using System.Collections.Generic;
using System.Text;

namespace Lbl.Comprobantes
{
        [Lbl.Atributos.NombreItem("Tipo de Comprobante")]
        public class Tipo : ElementoDeDatos
        {
                private Articulos.Situacion m_SituacionOrigen, m_SituacionDestino;
                public ColeccionGenerica<Lbl.Impresion.TipoImpresora> m_Impresoras = null;

                //Heredar constructor
		public Tipo(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Tipo(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Tipo(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public Tipo(Lfx.Data.Connection dataBase, string nomenclatura)
                        : base(dataBase)
                {
                        Lfx.Data.Row Rw = this.Connection.FirstRowFromSelect("SELECT * FROM documentos_tipos WHERE letra='" + nomenclatura + "'");
                        this.FromRow(Rw);
                }

                public override void Crear()
                {
                        m_Impresoras = new ColeccionGenerica<Lbl.Impresion.TipoImpresora>(this.Connection);

                        base.Crear();
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


                public Lbl.Articulos.Situacion SituacionOrigen
                {
                        get
                        {
                                if (m_SituacionOrigen == null && this.GetFieldValue<int>("situacionorigen") > 0)
                                        m_SituacionOrigen = new Lbl.Articulos.Situacion(this.Connection, System.Convert.ToInt32(Registro["situacionorigen"]));
                                return m_SituacionOrigen;
                        }
                        set
                        {
                                m_SituacionOrigen = value;
                        }
                }

                public Lbl.Articulos.Situacion SituacionDestino
                {
                        get
                        {
                                if (m_SituacionDestino == null && this.GetFieldValue<int>("situaciondestino") > 0)
                                        m_SituacionDestino = new Lbl.Articulos.Situacion(this.Connection, System.Convert.ToInt32(Registro["situaciondestino"]));
                                return m_SituacionDestino;
                        }
                        set
                        {
                                m_SituacionDestino = value;
                        }
                }

                public bool NumerarAlImprimir
                {
                        get
                        {
                                return this.GetFieldValue<int>("numerar_imprimir") != 0;
                        }
                        set
                        {
                                this.Registro["numerar_imprimir"] = value ? 1 : 0;
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
                                return this.GetFieldValue<int>("mueve_stock") != 0;
                        }
                        set
                        {
                                this.Registro["mueve_stock"] = value ? 1 : 0;
                        }
                }

                /// <summary>
                /// Devuelve sólamente la letra (A, B, C, E o M, independientemente de que sea NCA, NDE, etc.)
                /// </summary>
                public string Letra
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

                public ColeccionGenerica<Lbl.Impresion.TipoImpresora> Impresoras
                {
                        get
                        {
                                if (m_Impresoras == null && this.Existe) {
                                        System.Data.DataTable Impr = this.Connection.Select("SELECT * FROM comprob_tipo_impresoras WHERE id_tipo=" + this.Id);
                                        m_Impresoras = new ColeccionGenerica<Lbl.Impresion.TipoImpresora>(this.Connection, Impr);
                                }
                                return m_Impresoras;
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
                                return this.GetFieldValue<string>("letra");
                        }
                        set
                        {
                                this.Registro["letra"] = value;
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
                                return this.GetFieldValue<int>("imprimir_repetir") != 0;
                        }
                        set
                        {
                                this.Registro["imprimir_repetir"] = value ? 1 : 0;
                        }
                }

                public bool PermiteModificarImpresos
                {
                        get
                        {
                                return this.GetFieldValue<int>("imprimir_modificar") != 0;
                        }
                        set
                        {
                                this.Registro["imprimir_modificar"] = value ? 1 : 0;
                        }
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
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

                        this.Connection.Execute(Comando);

                        if (this.Impresoras != null && this.Impresoras.HayCambios) {
                                // Eliminar todas las impresoras asociadas con el tipo
                                qGen.Delete EliminarImpresorasActuales = new qGen.Delete("comprob_tipo_impresoras");
                                EliminarImpresorasActuales.WhereClause = new qGen.Where("id_tipo", this.Id);
                                this.Connection.Execute(EliminarImpresorasActuales);

                                // Guardar la nueva lista de permisos del usuario
                                foreach (Lbl.Impresion.TipoImpresora Impr in this.Impresoras) {
                                        qGen.Insert InsertarImpresora = new qGen.Insert("comprob_tipo_impresoras");
                                        InsertarImpresora.Fields.AddWithValue("id_tipo", this.Id);
                                        InsertarImpresora.Fields.AddWithValue("id_impresora", Impr.Impresora.Id);
                                        if (Impr.Sucursal == null)
                                                InsertarImpresora.Fields.AddWithValue("id_sucursal", null);
                                        else
                                                InsertarImpresora.Fields.AddWithValue("id_sucursal", Impr.Sucursal.Id);
                                        if (Impr.PuntoDeVenta == null)
                                                InsertarImpresora.Fields.AddWithValue("id_pv", null);
                                        else
                                                InsertarImpresora.Fields.AddWithValue("id_pv", Impr.PuntoDeVenta.Id);
                                        InsertarImpresora.Fields.AddWithValue("estacion", Impr.Estacion);
                                        InsertarImpresora.Fields.AddWithValue("nombre", Impr.Nombre);

                                        this.Connection.Execute(InsertarImpresora);
                                }
                        }

                        return base.Guardar();
                }

                private static Dictionary<string, Tipo> m_TodosPorLetra = null;
                public static Dictionary<string, Tipo> TodosPorLetra
                {
                        get
                        {
                                if (m_TodosPorLetra == null) {
                                        m_TodosPorLetra = new Dictionary<string,Tipo>();
                                        System.Data.DataTable TablaTipos = Lfx.Workspace.Master.MasterConnection.Select("SELECT * FROM documentos_tipos");
                                        foreach (System.Data.DataRow RegTipo in TablaTipos.Rows) {
                                                m_TodosPorLetra.Add(RegTipo["letra"].ToString(), new Lbl.Comprobantes.Tipo(Lfx.Workspace.Master.MasterConnection, (Lfx.Data.Row)RegTipo));
                                        }
                                }
                                return m_TodosPorLetra;
                        }
                }
        }
}
