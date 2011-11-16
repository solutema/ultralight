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
        [Lbl.Atributos.NombreItem("Rubro")]
	public class Rubro : ElementoDeDatos
	{
                public Lbl.Impuestos.Alicuota Alicuota = null;

		public Rubro(Lfx.Data.Connection dataBase) : base(dataBase) { }

		public Rubro(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Rubro(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

		public override string TablaDatos
		{
			get
			{
				return "articulos_rubros";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_rubro";
			}
		}

                public override void OnLoad()
                {
                        base.OnLoad();

                        if (this.GetFieldValue<int>("id_alicuota") != 0)
                                this.Alicuota = new Impuestos.Alicuota(this.Connection, this.GetFieldValue<int>("id_alicuota"));
                        else
                                this.Alicuota = null;
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

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        if (this.Alicuota == null)
                                Comando.Fields.AddWithValue("id_alicuota", null);
                        else
                                Comando.Fields.AddWithValue("id_alicuota", this.Alicuota.Id);

			this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

			return base.Guardar();
		}

	}
}
