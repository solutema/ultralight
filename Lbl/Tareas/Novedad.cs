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
        /// <summary>
        /// Representa una novedad de una tarea.
        /// </summary>
        [Lbl.Atributos.NombreItem("Novedad"), Lbl.Atributos.MuestraMensajeAlCrear(false)]
        public class Novedad : ElementoDeDatos
        {
                private Tarea m_Tarea = null;
                private Lbl.Personas.Persona m_Persona = null;

                public Novedad(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public Novedad(Lfx.Data.Connection dataBase, int itemId)
                        : base(dataBase, itemId) { }

                public Novedad(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }

                public override string TablaDatos
                {
                        get
                        {
                                return "tickets_eventos";
                        }
                }

                public override string CampoId
                {
                        get
                        {
                                return "id_evento";
                        }
                }

                public string Descripcion
                {
                        get
                        {
                                return this.GetFieldValue<string>("descripcion");
                        }
                        set
                        {
                                this.Registro["descripcion"] = value;
                        }
                }

                public Tarea Tarea
                {
                        get
                        {
                                return m_Tarea;
                        }
                        set
                        {
                                m_Tarea = value;
                                if (value != null)
                                        this.Registro["id_ticket"] = value.Id;
                                else
                                        this.Registro["id_ticket"] = null;
                        }
                }

                public Lbl.Personas.Persona Persona
                {
                        get
                        {
                                return m_Persona;
                        }
                        set
                        {
                                m_Persona = value;
                                if (value != null)
                                        this.Registro["id_tecnico"] = value.Id;
                                else
                                        this.Registro["id_tecnico"] = null;
                        }
                }

                public int Minutos
                {
                        get
                        {
                                return this.GetFieldValue<int>("minutos_tecnico");
                        }
                        set
                        {
                                this.Registro["minutos_tecnico"] = value;
                        }
                }

                public bool Privado
                {
                        get
                        {
                                return this.GetFieldValue<int>("privado") != 0;
                        }
                        set
                        {
                                this.Registro["privado"] = value ? 1 : 0;
                        }
                }


                public override void OnLoad()
                {
                        if (m_Registro != null) {
                                if (this.GetFieldValue<int>("id_ticket") != 0)
                                        m_Tarea = new Tarea(this.Connection, System.Convert.ToInt32(this.Registro["id_ticket"]));
                                else
                                        m_Tarea = null;
                        }
                        base.OnLoad();
                }

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
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        } else {
                                Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("id_ticket", this.Tarea.Id);
                        if (this.Persona == null)
                                Comando.Fields.AddWithValue("id_tecnico", this.Persona.Id);
                        else
                                Comando.Fields.AddWithValue("id_tecnico", null);
                        Comando.Fields.AddWithValue("descripcion", this.Descripcion);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        Comando.Fields.AddWithValue("minutos_tecnico", this.Minutos);
                        Comando.Fields.AddWithValue("privado", this.Privado ? 1 : 0);

                        this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        return base.Guardar();
                }
        }
}
