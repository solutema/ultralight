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

namespace Lbl.Articulos
{
	public class Categoria : ElementoDeDatos
	{
		public Categoria(Lws.Data.DataView dataView) : base(dataView) { }

		public Categoria(Lws.Data.DataView dataView, int itemId)
			: this(dataView)
		{
			m_ItemId = itemId;
		}

		public override string TablaDatos
		{
			get
			{
				return "articulos_categorias";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_categoria";
			}
		}

		public virtual string NombreSingular
		{
			get
			{
				return this.Registro["nombresing"].ToString();
			}
			set
			{
				this.Registro["nombresing"] = value;
			}
		}

		public double StockMinimo
		{
			get
			{
				return ((double)(this.Registro["stock_minimo"]));
			}
			set
			{
				this.Registro["stock_minimo"] = value;
			}
		}

                public int Garantia
                {
                        get
                        {
                                return this.FieldInt("garantia");
                        }
                        set
                        {
                                Registro["garantia"] = value;
                        }
                }

		public int PublicacionWeb
		{
			get
			{
				return System.Convert.ToInt32(this.Registro["web"]);
			}
			set
			{
				this.Registro["web"] = value;
			}
		}

                public bool RequiereNS
                {
                        get
                        {
                                return this.FieldInt("requierens") != 0;
                        }
                        set
                        {
                                this.Registro["requierens"] = value ? 1 : 0;
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

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("nombresing", this.NombreSingular);
                        Comando.Fields.AddWithValue("stock_minimo", this.StockMinimo);
                        Comando.Fields.AddWithValue("web", this.PublicacionWeb);
                        Comando.Fields.AddWithValue("requierens", this.RequiereNS ? 1 : 0);
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        Comando.Fields.AddWithValue("garantia", this.Garantia);

			this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

			return base.Guardar();
		}

	}
}
