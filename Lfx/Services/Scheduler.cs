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

namespace Lfx.Services
{
        /// <summary>
        /// Programador de tareas
        /// </summary>
        public class Scheduler
        {
                private Lfx.Workspace Workspace;
                //private Lfx.Data.DataBase m_DataBase = null;
                private DateTime m_LastGetTask = DateTime.MinValue;

                public Scheduler(Workspace workspace)
                {
                        Workspace = workspace;
                }

                public bool AddTask(string commandString)
                {
                        return AddTask(commandString, "lazaro", System.Environment.MachineName.ToUpperInvariant());
                }

                public bool AddTask(string commandString, string component)
                {
                        return AddTask(commandString, component, System.Environment.MachineName.ToUpperInvariant());
                }

                public DateTime LastGetTask
                {
                        get
                        {
                                return m_LastGetTask;
                        }
                }

                private Lfx.Data.DataBase DataBase
                {
                        get
                        {
                                //if (m_DataBase == null)
                                //        m_DataBase = m_Workspace.GetDataBase("Programador de tareas");
                                //return m_DataBase;
                                return this.Workspace.DefaultDataBase;
                        }
                }

                public bool AddTask(string commandString, string component, string terminalName)
                {
                        if (terminalName.Length == 0)
                                terminalName = System.Environment.MachineName.ToUpperInvariant();

                        qGen.Insert Comando = new qGen.Insert(this.DataBase, "sys_programador");
                        Comando.Fields.AddWithValue("crea_estacion", System.Environment.MachineName.ToUpperInvariant());
                        Comando.Fields.AddWithValue("crea_usuario", Workspace.CurrentUser.CompleteName);
                        Comando.Fields.AddWithValue("estacion", terminalName);
                        Comando.Fields.AddWithValue("comando", commandString);
                        Comando.Fields.AddWithValue("componente", component);
                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);

                        try {
                                this.DataBase.Execute(Comando);
                        }
                        catch {
                                return true;
                        }

                        return false;
                }

                public Task GetNextTask(string component)
                {
                        if (Workspace == null)
                                return null;

                        if (this.DataBase.ConectionState == System.Data.ConnectionState.Open) {
                                m_LastGetTask = DateTime.Now;
                                string Sql = "SELECT * FROM sys_programador WHERE estado=0";

                                Sql += " AND componente IN ('" + component + "', NULL)";
                                Sql += " AND estacion IN ('*', '" + this.DataBase.EscapeString(System.Environment.MachineName.ToUpperInvariant()) + "')";

                                Lfx.Data.Row TaskRow = this.DataBase.FirstRowFromSelect(Sql);

                                if (TaskRow != null) {
                                        Task Result = new Task();

                                        Result.Id = System.Convert.ToInt32(TaskRow["id_evento"]);
                                        Result.Command = TaskRow["comando"].ToString();
                                        Result.Component = TaskRow["componente"].ToString();
                                        Result.Creator = TaskRow["crea_usuario"].ToString();
                                        Result.CreatorComputerName = TaskRow["crea_estacion"].ToString();
                                        Result.ComputerName = TaskRow["estacion"].ToString();
                                        Result.Schedule = System.Convert.ToDateTime(TaskRow["fecha"]);
                                        Result.Status = System.Convert.ToInt32(TaskRow["estado"]);

                                        //Elimino tareas viejas
                                        qGen.Update Actualizar = new qGen.Update("sys_programador", new qGen.Where("id_evento", Result.Id));
                                        Actualizar.Fields.AddWithValue("estado", 1);
                                        this.DataBase.Execute(Actualizar);
                                        this.DataBase.Execute(new qGen.Delete("sys_programador", new qGen.Where("fecha", qGen.ComparisonOperators.LessThan, System.DateTime.Now.AddDays(-7))));

                                        return Result;
                                } else
                                        return null;
                        } else {
                                return null;
                        }
                }
        }
}
