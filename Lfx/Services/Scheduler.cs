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

namespace Lfx.Services
{


	/// <summary>
	/// Programador de tareas
	/// </summary>
	public class Scheduler
	{
		private Lfx.Workspace m_Workspace;
                private DateTime m_LastGetTask = DateTime.MinValue;

		public Scheduler(Workspace workspace)
		{
			m_Workspace = workspace;
		}

		public  bool AddTask(string commandString)
		{
			return AddTask(commandString, "lazaro", Lfx.Environment.SystemInformation.ComputerName);
		}

		public  bool AddTask(string commandString, string component)
		{
			return AddTask(commandString, component, Lfx.Environment.SystemInformation.ComputerName);
		}

                public DateTime LastGetTask
                {
                        get
                        {
                                return m_LastGetTask;
                        }
                }

		public bool AddTask(string commandString, string component, string terminalName)
		{
			if(terminalName.Length == 0)
				terminalName = Lfx.Environment.SystemInformation.ComputerName;

			Lfx.Data.SqlInsertBuilder Comando = new Lfx.Data.SqlInsertBuilder(m_Workspace.DefaultDataView, "sys_programador");
			Comando.Fields.AddWithValue("crea_estacion", Lfx.Environment.SystemInformation.ComputerName);
			Comando.Fields.AddWithValue("crea_usuario", m_Workspace.CurrentUser.UserCompleteName);
			Comando.Fields.AddWithValue("estacion", terminalName);
			Comando.Fields.AddWithValue("comando", commandString);
			Comando.Fields.AddWithValue("componente", component);
			Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);

			try
			{
				m_Workspace.DefaultDataView.DataBase.Execute(Comando);
			}
			catch
			{
				return true;
			}

			return false;
		}

		public Task GetNextTask(string component)
		{
			if(m_Workspace == null)
				return null;

			if(m_Workspace.DefaultDataView.DataBase.ConectionState == System.Data.ConnectionState.Open)
			{
                                m_LastGetTask = DateTime.Now;
				string Sql = "SELECT * FROM sys_programador WHERE estado=0";

				Sql += " AND (componente='" + component + "' OR componente IS NULL)";
				Sql += " AND (estacion='*' OR estacion='" + m_Workspace.DefaultDataView.DataBase.EscapeString(Lfx.Environment.SystemInformation.ComputerName) + "')";

                                Lfx.Data.Row TaskRow = m_Workspace.DefaultDataView.DataBase.FirstRowFromSelect(Sql);

				if(TaskRow != null) {
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
					//DataView.DataBase.Execute("UPDATE sys_programador SET estado=1 WHERE id_evento=" + Result.Id.ToString());
					Lfx.Data.SqlUpdateBuilder Actualizar = new Lfx.Data.SqlUpdateBuilder(m_Workspace.DefaultDataView, "sys_programador", "id_evento=" + Result.Id.ToString());
					Actualizar.Fields.AddWithValue("estado", 1);
					m_Workspace.DefaultDataView.DataBase.Execute(Actualizar);
					//DataView.DataBase.Execute("DELETE FROM sys_programador WHERE fecha<'" + Lfx.Types.Formatting.FormatDateSql(System.DateTime.Now.AddDays(-7)) + "'");
					m_Workspace.DefaultDataView.DataBase.Execute(new Lfx.Data.SqlDeleteBuilder(m_Workspace.DefaultDataView, "sys_programador", "fecha<'" + Lfx.Types.Formatting.FormatDateSql(System.DateTime.Now.AddDays(-7)) + "'"));

					return Result;
				}
				else
					return null;
			}
			else
			{
				return null;
			}
		}
	}
}
