#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.Linq;
using System.Text;

namespace Lbl.Impresion
{
        /// <summary>
        /// Representa la relación entre un tipo de comprobante y una impresora.
        /// </summary>
        [Lbl.Atributos.NombreItem("Tipo de Comprobante-Impresora")]
        public class TipoImpresora : ElementoDeDatos
        {
                public Lbl.Comprobantes.Tipo Tipo = null;
                public Lbl.Impresion.Impresora Impresora = null;
                public Lbl.Entidades.Sucursal Sucursal = null;
                public Lbl.Comprobantes.PuntoDeVenta PuntoDeVenta = null;

                //Heredar constructor
		public TipoImpresora(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public TipoImpresora(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public TipoImpresora(Lfx.Data.Connection dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "comprob_tipo_impresoras";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_tipo_impresora";
                        }
                }

                public override string Nombre
                {
                        get
                        {
                                string NombreStr = this.Tipo.ToString() + " en " + this.Impresora.ToString();
                                if (this.Sucursal != null)
                                        NombreStr += " para Suc. " + this.Sucursal.ToString();

                                if (this.Estacion != null)
                                        NombreStr += " en " + this.Estacion;

                                if (this.PuntoDeVenta != null)
                                        NombreStr += " en PV " + this.PuntoDeVenta.Numero.ToString();
                                return NombreStr;
                        }
                        set
                        {
                                base.Nombre = value;
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

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("estacion", this.Estacion);
                        Comando.Fields.AddWithValue("id_impresora", this.Tipo.Id);
                        Comando.Fields.AddWithValue("id_tipo", this.Impresora.Id);
                        if (this.Sucursal == null)
                                Comando.Fields.AddWithValue("id_sucursal", null);
                        else
                                Comando.Fields.AddWithValue("id_sucursal", this.Sucursal.Id);
                        if (this.PuntoDeVenta == null)
                                Comando.Fields.AddWithValue("id_pv", null);
                        else
                                Comando.Fields.AddWithValue("id_pv", this.PuntoDeVenta.Id);

                        this.AgregarTags(Comando);

                        Connection.Execute(Comando);

                        return base.Guardar();
                }

                public override void OnLoad()
                {
                        if (this.GetFieldValue<int>("id_tipo") == 0)
                                this.Tipo = null;
                        else
                                this.Tipo = new Lbl.Comprobantes.Tipo(this.Connection, this.GetFieldValue<int>("id_tipo"));

                        if (this.GetFieldValue<int>("id_impresora") == 0)
                                this.Impresora = null;
                        else
                                this.Impresora = new Impresion.Impresora(this.Connection, this.GetFieldValue<int>("id_impresora"));

                        if (this.GetFieldValue<int>("id_pv") == 0)
                                this.PuntoDeVenta = null;
                        else
                                this.PuntoDeVenta = new Comprobantes.PuntoDeVenta(this.Connection, this.GetFieldValue<int>("id_pv"));

                        if (this.GetFieldValue<int>("id_sucursal") == 0)
                                this.Sucursal = null;
                        else
                                this.Sucursal = new Entidades.Sucursal(this.Connection, this.GetFieldValue<int>("id_sucursal"));

                        base.OnLoad();
                }

                public string Estacion
                {
                        get
                        {
                                return this.GetFieldValue<string>("estacion");
                        }
                        set
                        {
                                this.Registro["estacion"] = value;
                        }
                }
        }
}
