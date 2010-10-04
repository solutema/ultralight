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

namespace Lfx
{
	/// <summary>
	/// Proporciona un espacio de trabajo que incluye acceso a los datos y a la configuración.
	/// </summary>
        public class Workspace : System.MarshalByRefObject
	{
                public static Lfx.Workspace Master = null;
                public static Lfx.Data.TableCollection m_MasterTableCollection = null;

		private string m_Name;
                private Lfx.Data.DataBase m_DataBase = null;

		public Lfx.Config.ConfigManager CurrentConfig;
		public Services.Scheduler DefaultScheduler;
		public RunTimeServices RunTime;
		public Access.LoginData CurrentUser;
		public int DataBaseCount = 0;
		public bool DebugMode = false;
                public List<Data.DataBase> DataBases = new List<Data.DataBase>();

		public Workspace()
			: this("default")
		{
		}

                public Workspace(string workspaceName)
                        : this(workspaceName, true)
                {
                }

		public Workspace(string workspaceName, bool openDataBase)
		{
			m_Name = workspaceName;

			this.CurrentConfig = new Lfx.Config.ConfigManager(this);
                        this.CurrentConfig.ConfigFileName = m_Name + ".lwf";
                        this.CurrentUser = new Lfx.Access.LoginData(this);
                        this.DefaultScheduler = new Lfx.Services.Scheduler(this);
                        this.RunTime = new Workspace.RunTimeServices();

                        m_DataBase = new Lfx.Data.DataBase(this, "Conexion maestra");

                        if (Lfx.Data.DataBaseCache.DefaultCache == null)
                                Lfx.Data.DataBaseCache.DefaultCache = new Lfx.Data.DataBaseCache(m_DataBase);

                        if (Lfx.Services.Updater.Master == null)
                                Lfx.Services.Updater.Master = new Services.Updater();

                        if (this.DefaultDataBase.AccessMode == Lfx.Data.AccessModes.Undefined) {
                                switch (this.CurrentConfig.ReadLocalSettingString("Data", "ConnectionType", "mysql")) {
                                        case "odbc":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.ODBC;
                                                break;

                                        case "mysql":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MySql;
                                                break;

                                        case "myodbc":
                                                // FIXME: eliminar esto que se usa momentáneamente para migrar a todos de MyODBC a MySQL Connector/NET.
                                                this.CurrentConfig.WriteLocalSetting("Data", "ConnectionType", "mysql");
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MyOdbc;
                                                break;

                                        case "npgsql":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.Npgsql;
                                                break;

                                        case "mssql":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MSSql;
                                                break;
                                }
                        }

                        if (Lfx.Data.DataBaseCache.DefaultCache.ServerName == null) {
                                Lfx.Data.DataBaseCache.DefaultCache.ServerName = this.CurrentConfig.ReadLocalSettingString("Data", "DataSource", "localhost");
                                Lfx.Data.DataBaseCache.DefaultCache.SlowLink = (this.CurrentConfig.ReadLocalSettingInt("Data", "SlowLink", 0) == 1);
                                Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = this.CurrentConfig.ReadLocalSettingString("Data", "DatabaseName", "lazaro");
                                Lfx.Data.DataBaseCache.DefaultCache.UserName = this.CurrentConfig.ReadLocalSettingString("Data", "User", "lazaro");
                                Lfx.Data.DataBaseCache.DefaultCache.Password = this.CurrentConfig.ReadLocalSettingString("Data", "Password", string.Empty);
                        }

                        if (openDataBase)
                                m_DataBase.Open();
		}

		public string Name
		{
			get
			{
				return m_Name;
			}
		}

		public override string ToString()
		{
			if(this.Name == "default")
				return this.DefaultDataBase.DataBaseName;
			else
				return this.Name;
		}

                public Lfx.Data.DataBase DefaultDataBase
		{
			get
			{
				return m_DataBase;
			}
		}

                public Lfx.Data.DataBase GetDataBase(string ownerName)
		{
                        Lfx.Data.DataBase Res = new Lfx.Data.DataBase(this, ownerName);
                        //Res.Open();
                        return Res;
		}

		/// <summary>
		/// Log de comandos SQL (normalmente a la consola). Sólo para depuración.
		/// </summary>
		public void DebugLog(int handle, string command)
		{
			if(this.DebugMode && command.IndexOf("FROM sys_programador") < 0 && command != "SELECT 1")
				System.Console.WriteLine(handle.ToString() + ": " + command);
		}

		/// <summary>
		/// Escribe un evento en la tabla sys_log. Se utiliza para registrar operaciones de datos (altas, bajas, ingresos, egresos, etc.)
		/// </summary>
		public void ActionLog(string command, string extra1)
		{
			this.ActionLog(command, null, 0, extra1);
		}

		public void ActionLog(string command, string table, int item_id, string extra1)
		{
			try
			{
				qGen.Insert Comando = new qGen.Insert(this.DefaultDataBase, "sys_log");
				Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
				Comando.Fields.AddWithValue("estacion", System.Environment.MachineName.ToUpperInvariant());
				Comando.Fields.AddWithValue("usuario", this.CurrentUser.Id);
				Comando.Fields.AddWithValue("comando", command);
				Comando.Fields.AddWithValue("tabla", table);
				Comando.Fields.AddWithValue("item_id", Lfx.Data.DataBase.ConvertZeroToDBNull(item_id));
				Comando.Fields.AddWithValue("extra1", extra1);
				this.DefaultDataBase.Execute(Comando);
			}
			catch (System.Exception ex)
			{
                                System.Console.WriteLine(ex.ToString());
			}
		}

                public Lfx.Data.TableCollection Tables
                {
                        get
                        {
                                if (m_MasterTableCollection == null) {
                                        m_MasterTableCollection = new Lfx.Data.TableCollection(Lfx.Workspace.Master.DefaultDataBase);
                                        foreach (string TblName in Lfx.Data.DataBaseCache.DefaultCache.TableList) {
                                                Lfx.Data.Table NewTable = new Lfx.Data.Table(Lfx.Workspace.Master.DefaultDataBase, TblName);
                                                switch (TblName) {
                                                        case "sys_asl":
                                                        case "sys_log":
                                                        case "sys_programador":
                                                        case "sys_quickpaste":
                                                                NewTable.Cacheable = false;
                                                                break;
                                                }
                                                if (Lfx.Data.DataBaseCache.DefaultCache.TableStructures.ContainsKey(TblName) && Lfx.Data.DataBaseCache.DefaultCache.TableStructures[TblName].PrimaryKey != null)
                                                        NewTable.PrimaryKey = Lfx.Data.DataBaseCache.DefaultCache.TableStructures[TblName].PrimaryKey.Name;
                                                Lfx.Workspace.m_MasterTableCollection.Add(NewTable);
                                        }
                                }
                                return m_MasterTableCollection;
                        }
                }

		public bool SlowLink
		{
			get
			{
				return this.DefaultDataBase.SlowLink;
			}
		}


		/// <summary>
		/// Notifica sobre un cambio de una tabla de datos
		/// </summary>
                public void NotifyTableChange(string table, int id)
                {
                        //TODO: podría directamente modificar el caché en memoria, si quien notifica el cambio me pasara una copia del nuevo registro
                        //(p. ej. Lbl.ElementoDeDatos puede hacerlo). Por el momento voy a lo seguro y elimino del caché.
                        this.DefaultDataBase.Tables[table].FastRows.RemoveFromCache(id);
                }


		/// <summary>
		/// Proporciona servicios de comunicación inter-proceso (entre el Lfx, la aplicación principal y los componentes)
		/// </summary>
		public class RunTimeServices
		{
			public class IpcEventArgs : System.EventArgs
			{
				public enum EventTypes
				{
					Undefined,
					Information,
					ActionRequest
				}

				public EventTypes EventType = EventTypes.Undefined;
				public string Source;
				public string Destination;
				public string Verb;
				public object[] Arguments;
				public object ReturnValue;

				public IpcEventArgs() { }
				public IpcEventArgs(EventTypes eventType)
				{
					this.EventType = eventType;
				}
			}
			public delegate void IpcEventHandler(object sender, ref IpcEventArgs e);
			public event IpcEventHandler IpcEvent;

                        public object Execute(string verb)
                        {
                                return this.Execute("lazaro", verb, null);
                        }

			public object Execute(string verb, object[] arguments)
			{
				return this.Execute("lazaro", verb, arguments);
			}

			public object Execute(string destination, string verb, object[] arguments)
			{
				if (IpcEvent != null)
				{
					IpcEventArgs e = new IpcEventArgs();
					e.EventType = IpcEventArgs.EventTypes.ActionRequest;
					e.Destination = destination;
					e.Verb = verb;
					e.Arguments = arguments;
					this.IpcEvent(this, ref e);
					return e.ReturnValue;
				}
				return null;
			}

			public void Info(string verb, string infoText)
			{
				this.Info("lazaro", verb, new object[] { infoText });
			}
			public void Info(string verb, object[] arguments)
			{
				this.Info("lazaro", verb, arguments);
			}

			public void Info(string destination, string verb, string infoText)
			{
				this.Info(destination, verb, new object[] { infoText });
			}
			public void Info(string destination, string verb, object[] arguments)
			{
				if (IpcEvent != null)
				{
					IpcEventArgs e = new IpcEventArgs();
					e.EventType = IpcEventArgs.EventTypes.Information;
					e.Destination = destination;
					e.Verb = verb;
					e.Arguments = arguments;
					this.IpcEvent(this, ref e);
				}
			}
		}
	}
}