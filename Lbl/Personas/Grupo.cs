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

namespace Lbl.Personas
{
        [Lbl.Atributos.Datos(NombreSingular = "Grupo",
                Grupo = "Personas",
                TablaDatos = "personas_grupos",
                CampoId = "id_grupo")]
        [Lbl.Atributos.Presentacion()]
	public class Grupo : ElementoDeDatos
	{
                private Grupo m_Parent = null;

		public Grupo(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

		public Grupo(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Grupo(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override void OnLoad()
                {
                        m_Parent = null;

                        base.OnLoad();
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;
                        if (this.Existe == false) {
                                Comando = new qGen.Insert(Connection, "personas_grupos");
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(Connection, "personas_grupos");
                                Comando.WhereClause = new qGen.Where("id_grupo", this.Id);
                        }

                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("descuento", this.Descuento);
                        Comando.Fields.AddWithValue("predet", this.Predeterminado ? 1 : 0);
                        if (this.Parent != null)
                                Comando.Fields.AddWithValue("parent", this.Parent.Id);
                        else
                                Comando.Fields.AddWithValue("parent", null);

                        Connection.Execute(Comando);
                        
                        return base.Guardar();
                }

                public decimal Descuento
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("descuento");
                        }
                        set
                        {
                                this.Registro["descuento"] = value;
                        }
                }

                public bool Predeterminado
                {
                        get
                        {
                                return this.GetFieldValue<int>("predet") == 1;
                        }
                        set
                        {
                                this.Registro["predet"] = value ? 1 : 0;
                        }
                }

                public Grupo Parent
                {
                        get
                        {
                                if(m_Parent == null && this.GetFieldValue<int>("parent") != 0)
                                        m_Parent = new Grupo(this.Connection, this.GetFieldValue<int>("parent"));

                                return m_Parent;
                        }
                        set
                        {
                                m_Parent = value;
                                if (value != null)
                                        this.Registro["parent"] = value.Id;
                        }
                }
	}
}
