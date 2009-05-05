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

namespace Lbl.Articulos
{
	public class Situacion : ElementoDeDatos
	{
		//Heredar constructor
		public Situacion(Lws.Data.DataView dataView) : base(dataView) { }

		public Situacion(Lws.Data.DataView dataView, int idArticulo)
			: this(dataView)
		{
			m_ItemId = idArticulo;
		}

		public override string TablaDatos
		{
			get
			{
				return "articulos_situaciones";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_situacion";
			}
		}

		public bool CuentaStock
		{
			get
			{
				return System.Convert.ToBoolean(Registro["cuenta_stock"]);
			}
		}

                public override Lfx.Types.OperationResult Guardar()
                {
                        try {
				Lfx.Data.SqlTableCommandBuilder Comando;
                                if (this.Existe) {
					Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
					Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId + "=" + this.Id.ToString());
				} else {
					Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
				}

                                Comando.Fields.AddWithValue("nombre", this.Registro["nombre"].ToString());
                                Comando.Fields.AddWithValue("cuenta_stock", this.CuentaStock ? 1 : 0);
                                Comando.Fields.AddWithValue("deposito", System.Convert.ToInt32(this.Registro["deposito"]));
                                Comando.Fields.AddWithValue("facturable", System.Convert.ToInt32(this.Registro["facturable"]));
				
				this.AgregarTags(Comando);

	                        this.DataView.DataBase.Execute(Comando);
	
	                        if (this.Existe == false)
	                                m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(" + this.CampoId + ") FROM " + this.TablaDatos);

				return new Lfx.Types.SuccessOperationResult();
                        }
                        catch (Exception ex) {
                                return new Lfx.Types.FailureOperationResult(ex.ToString());
                        }
                }
	}
}
