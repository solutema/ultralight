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

namespace Lbl.Articulos
{
        [Lbl.Atributos.Datos(NombreSingular = "Situación",
                Grupo = "Artículos",
                TablaDatos = "articulos_situaciones",
                CampoId = "id_situacion")]
        [Lbl.Atributos.Presentacion()]
	public class Situacion : ElementoDeDatos
	{
		//Heredar constructor
		public Situacion(Lfx.Data.Connection dataBase) : base(dataBase) { }

		public Situacion(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Situacion(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                /// <summary>
                /// Indica si los artículos en esta situación suman al stock.
                /// </summary>
		public bool CuentaStock
		{
			get
			{
				return this.GetFieldValue<bool>("cuenta_stock");
			}
                        set
                        {
                                this.SetFieldValue("cuenta_stock", value ? 1 : 0);
                        }
		}


                /// <summary>
                /// Indica si los artículos en esta situación pueden ser facturados.
                /// </summary>
                public bool Facturable
                {
                        get
                        {
                                return this.GetFieldValue<bool>("facturable");
                        }
                        set
                        {
                                this.SetFieldValue("facturable", value ? 1 : 0);
                        }
                }


                /// <summary>
                /// Indica -si esta situación es un depósito- el número de depósito. Si es 0, no es un depósito.
                /// </summary>
                public int Deposito
                {
                        get
                        {
                                return this.GetFieldValue<int>("deposito");
                        }
                        set
                        {
                                this.SetFieldValue("deposito", value);
                        }
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        try {
				qGen.TableCommand Comando;
                                if (this.Existe) {
					Comando = new qGen.Update(this.Connection, this.TablaDatos);
					Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
				} else {
					Comando = new qGen.Insert(this.Connection, this.TablaDatos);
                                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                }

                                Comando.Fields.AddWithValue("nombre", this.Registro["nombre"].ToString());
                                Comando.Fields.AddWithValue("cuenta_stock", this.CuentaStock ? 1 : 0);
                                Comando.Fields.AddWithValue("deposito", this.Deposito);
                                Comando.Fields.AddWithValue("facturable", this.Facturable ? 1 : 0);
                                Comando.Fields.AddWithValue("estado", this.Estado);
                                Comando.Fields.AddWithValue("obs", this.Obs);
				
				this.AgregarTags(Comando);

	                        this.Connection.Execute(Comando);

				return new Lfx.Types.SuccessOperationResult();
                        }
                        catch (Exception ex) {
                                return new Lfx.Types.FailureOperationResult(ex.ToString());
                        }
                }
	}
}
