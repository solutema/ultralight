#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lbl.Tareas
{
        [Lbl.Atributos.Datos(NombreSingular = "Estado",
                Grupo = "Tareas",
                TablaDatos = "tickets_estados",
                CampoId = "id_ticket_estado")]
        [Lbl.Atributos.Presentacion()]
        public class Estado : Lbl.ElementoDeDatos
        {
                public Estado(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Estado(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Estado(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


                public override void Crear()
                {
                        base.Crear();
                        this.Estado = 1;
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
                        Comando.Fields.AddWithValue("obs", this.Obs);
                        Comando.Fields.AddWithValue("estado", this.Estado);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }


                private static Dictionary<int, Estado> m_TodosPorNumero = null;
                public static Dictionary<int, Estado> TodosPorNumero
                {
                        get
                        {
                                if (m_TodosPorNumero == null) {
                                        m_TodosPorNumero = new Dictionary<int, Estado>();
                                        System.Data.DataTable Tabla = Lfx.Workspace.Master.MasterConnection.Select("SELECT * FROM tickets_estados");
                                        foreach (System.Data.DataRow Reg in Tabla.Rows) {
                                                m_TodosPorNumero.Add(System.Convert.ToInt32(Reg["id_ticket_estado"]), new Lbl.Tareas.Estado(Lfx.Workspace.Master.MasterConnection, (Lfx.Data.Row)Reg));
                                        }
                                }
                                return m_TodosPorNumero;
                        }
                }
        }
}
