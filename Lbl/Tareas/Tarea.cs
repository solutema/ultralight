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

namespace Lbl.Tareas
{
        public class Tarea : ElementoDeDatos
        {
                public Lbl.Personas.Persona Cliente, Encargado;
                public Lbl.Tareas.Tipo Tipo;

                public Tarea(Lfx.Data.DataBase dataBase) : base(dataBase) { }

                public Tarea(Lfx.Data.DataBase dataBase, int idTarea)
			: this(dataBase)
		{
			m_ItemId = idTarea;
		}

		public override string TablaDatos
		{
			get
			{
				return "tickets";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_ticket";
			}
		}

                public string Descripcion
                {
                        get
                        {
                                return this.FieldString("descripcion");
                        }
                        set
                        {
                                this.Registro["descripcion"] = value;
                        }
                }

                public int Prioridad
                {
                        get
                        {
                                return this.FieldInt("prioridad");
                        }
                        set
                        {
                                this.Registro["prioridad"] = value;
                        }
                }

                public double Presupuesto
                {
                        get
                        {
                                return this.FieldDouble("presupuesto");
                        }
                        set
                        {
                                this.Registro["presupuesto"] = value;
                        }
                }

                public Lfx.Types.LDateTime Fecha
                {
                        get
                        {
                                return this.FieldDateTime("fecha_ingreso");
                        }
                        set
                        {
                                this.Registro["fecha_ingreso"] = value;
                        }
                }

                public Lfx.Types.LDateTime FechaEstimada
                {
                        get
                        {
                                return this.FieldDateTime("entrega_estimada");
                        }
                        set
                        {
                                this.Registro["entrega_estimada"] = value;
                        }
                }

                public Lfx.Types.LDateTime FechaLimite
                {
                        get
                        {
                                return this.FieldDateTime("entrega_limite");
                        }
                        set
                        {
                                this.Registro["entrega_limite"] = value;
                        }
                }

                public override void OnLoad()
                {
                        if (m_Registro != null) {
                                if (this.FieldInt("id_tipo_ticket") != 0)
                                        this.Tipo = new Tipo(this.DataBase, System.Convert.ToInt32(this.Registro["id_tipo_ticket"]));
                                else
                                        this.Tipo = null;

                                if (this.FieldInt("id_persona") != 0)
                                        this.Cliente = new Personas.Persona(this.DataBase, this.FieldInt("id_persona"));
                                else
                                        this.Cliente = null;

                                if (this.FieldInt("id_tecnico_recibe") != 0)
                                        this.Encargado = new Personas.Persona(this.DataBase, this.FieldInt("id_tecnico_recibe"));
                                else
                                        this.Encargado = null;
                        }
                        base.OnLoad();
                }

                public override Lfx.Types.OperationResult Crear()
                {
                        Lfx.Types.OperationResult Res = base.Crear();
                        this.Encargado = new Lbl.Personas.Persona(this.DataBase, this.Workspace.CurrentUser.Id);
                        return Res;
                }

                public override Lfx.Types.OperationResult Guardar()
                {
                        qGen.TableCommand Comando;

                        if (this.Existe == false) {
                                Comando = new qGen.Insert(this.DataBase, this.TablaDatos);
                                Comando.Fields.AddWithValue("fecha_ingreso", qGen.SqlFunctions.Now);
                                Comando.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Company.CurrentBranch);
                        } else {
                                Comando = new qGen.Update(this.DataBase, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
                        }

                        Comando.Fields.AddWithValue("id_persona", this.Cliente.Id);
                        Comando.Fields.AddWithValue("id_tipo_ticket", this.Tipo.Id);
                        Comando.Fields.AddWithValue("id_tecnico_recibe", this.Encargado.Id);
                        Comando.Fields.AddWithValue("prioridad", this.Prioridad);
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("descripcion", this.Descripcion);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        Comando.Fields.AddWithValue("entrega_estimada", this.FechaEstimada);
                        Comando.Fields.AddWithValue("entrega_limite", this.FechaLimite);
                        Comando.Fields.AddWithValue("presupuesto", this.Presupuesto);
                        Comando.Fields.AddWithValue("obs", this.Obs);

                        this.AgregarTags(Comando);

                        this.DataBase.Execute(Comando);

                        return base.Guardar();
                }
        }
}
