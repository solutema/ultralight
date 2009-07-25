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
using System.Drawing;

namespace Lws.Config
{
	/// <summary>
	/// Maneja los parámetros de configuración
	/// </summary>
	public class ConfigManager
	{
		private string CONFIGFILENAME;
		private System.Xml.XmlDocument ConfigDocument;
		private Workspace m_Workspace;

                public Lws.Config.ProductsConfig Products;
                public Lws.Config.CurrencyConfig Currency;
                public Lws.Config.PrintersConfig Printing;
                public Lws.Config.CompanyConfig Company;

		//TODO: que se vacíe cada tanto
		private Lfx.Data.DataBase ConfigDB;
                private System.Collections.Hashtable SysConfigCache = null;
                private System.DateTime SysConfigCacheLastRefresh;

                public ConfigManager(Workspace workspace)
		{
			m_Workspace = workspace;
			ConfigFileName = m_Workspace.Name + ".lwf";

                        Products = new Lws.Config.ProductsConfig(this);
                        Currency = new Lws.Config.CurrencyConfig(this);
                        Printing = new Lws.Config.PrintersConfig(this);
                        Company = new Lws.Config.CompanyConfig(this);
		}

                public Lws.Workspace Workspace
                {
                        get
                        {
                                return m_Workspace;
                        }
                }

		public string ConfigFileName
		{
			get
			{
				return CONFIGFILENAME;
			}
			set
			{
				CONFIGFILENAME = value;
				//Si no tiene ruta, asumo la carpeta de la aplicación
				if(!System.IO.Path.IsPathRooted(CONFIGFILENAME)) 
					CONFIGFILENAME = Lfx.Environment.Folders.ApplicationDataFolder + CONFIGFILENAME;
			}
		}

		public void WriteLocalSetting(string sectionName, string settingName, int settingValue)
		{
			WriteLocalSetting(sectionName, settingName, settingValue.ToString());
		}

		public void WriteLocalSetting(string sectionName, string settingName, string settingValue)
		{
			if(ConfigDocument == null)
			{
				ConfigDocument = new System.Xml.XmlDocument();
				if(System.IO.File.Exists(ConfigFileName))
					ConfigDocument.Load(ConfigFileName);
				else
					ConfigDocument.AppendChild(ConfigDocument.CreateElement("LocalConfig"));
			}

			System.Xml.XmlAttribute Attribute;
			System.Xml.XmlNode SectionNode = ConfigDocument.SelectSingleNode("/LocalConfig/Section[@name='" + sectionName + "']");
			if(SectionNode == null) 
			{
				//Crear la sección
				SectionNode = ConfigDocument.CreateElement("Section");
				Attribute = ConfigDocument.CreateAttribute("name");
				Attribute.Value = sectionName;
				SectionNode.Attributes.Append(Attribute);
				ConfigDocument.DocumentElement.AppendChild(SectionNode);
			}
			System.Xml.XmlNode SettingNode = ConfigDocument.SelectSingleNode("/LocalConfig/Section[@name='" + sectionName + "']/Setting[@name='" + settingName + "']");
			if(SettingNode == null) 
			{
				//Agregar el nodo
				SettingNode = ConfigDocument.CreateElement("Setting");
				Attribute = ConfigDocument.CreateAttribute("name");
				Attribute.Value = settingName;
				SettingNode.Attributes.Append(Attribute);
				Attribute = ConfigDocument.CreateAttribute("value");
				Attribute.Value = settingValue;
				SettingNode.Attributes.Append(Attribute);
				SectionNode.AppendChild(SettingNode);
			}
			System.Xml.XmlAttribute SettingAttribute = SettingNode.Attributes["value"];
			if(SettingAttribute != null) 
			{
				SettingAttribute.Value = settingValue;
			}
			ConfigDocument.Save(ConfigFileName);
		}

		public int ReadLocalSettingInt(string sectionName, string settingName, int defaultValue)
		{
			return Lfx.Types.Parsing.ParseInt(ReadLocalSettingString(sectionName, settingName, defaultValue.ToString()));
		}

		public string ReadLocalSettingString(string sectionName, string settingName, string defaultValue)
		{
			string Result = defaultValue;
			if(System.IO.File.Exists(ConfigFileName)) 
			{
				//Intento obtener el valor del archivo de configuración Xml
				if(ConfigDocument == null)
				{
					ConfigDocument = new System.Xml.XmlDocument();
					ConfigDocument.Load(ConfigFileName);
				}
				System.Xml.XmlNode SettingNode = ConfigDocument.SelectSingleNode("/LocalConfig/Section[@name='" + sectionName + "']/Setting[@name='" + settingName + "']");
				if(SettingNode != null) 
				{
					System.Xml.XmlAttribute SettingAttribute = SettingNode.Attributes["value"];
					if(SettingAttribute != null) 
						Result = SettingAttribute.Value;
				}
			}
			if(Result /* still */ == null && Lfx.Environment.SystemInformation.Platform == Lfx.Environment.SystemInformation.Platforms.Windows ) 
			{
				//No hay archivo de configuración Xml o el archivo no contiene el valor
				//Intento obtener el valor del registro del sistema
				Microsoft.Win32.RegistryKey LazaroKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Lazaro", false);
				if(LazaroKey != null)
				{
					if(sectionName == null)
					{
						Result = LazaroKey.GetValue(settingName, defaultValue).ToString();
					}
					else
					{
						Microsoft.Win32.RegistryKey SectionKey = LazaroKey.OpenSubKey(sectionName, false);
						if(SectionKey != null) 
							Result = SectionKey.GetValue(settingName, defaultValue).ToString();
					}
				}
			}
			return Result;
		}

		public int ReadGlobalSettingInt(string sectionName, string settingName, int defaultValue)
		{
			return ReadGlobalSettingInt(sectionName, settingName, defaultValue, 0);
		}

		public int ReadGlobalSettingInt(string sectionName, string settingName, int defaultValue, int sucursal)
		{
			string Val = ReadGlobalSettingString(sectionName, settingName, defaultValue.ToString(), null, sucursal);
			try
			{
				return int.Parse(Val);
			}
			catch
			{
				System.Console.WriteLine("ReadGlobalSettingInt: Can't parse " + Val + " as int (" + settingName + ")");
				return 0;
			}
		}

		public string ReadGlobalSettingString(string sectionName, string settingName, string defaultValue)
		{
			return ReadGlobalSettingString(sectionName, settingName, defaultValue, null, 0);
		}

                public string ReadGlobalSettingString(string sectionName, string settingName, string defaultValue, string terminalName, int sucursal)
		{
			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
			
			//Si el caché es muy viejo, lo vacío
			if(SysConfigCache != null && System.DateTime.Now > SysConfigCacheLastRefresh.AddMinutes(10)) {
                                System.Console.WriteLine(DateTime.Now.ToShortTimeString() + " vaciando la caché de sys_config");
				SysConfigCache = null;
			}

                        if (SysConfigCache == null) {
                                SysConfigCache = new System.Collections.Hashtable();

                                if (ConfigDB == null)
                                        ConfigDB = m_Workspace.GetDataBase();

                                System.Data.IDataReader TablaSysConfig = ConfigDB.GetReader("SELECT nombre, valor, estacion, id_sucursal FROM sys_config");
                                while (TablaSysConfig.Read()) {
                                        string Sucu;
                                        if (TablaSysConfig["id_sucursal"] == null || System.Convert.ToInt32(TablaSysConfig["id_sucursal"]) == 0)
                                                Sucu = "";
                                        else
                                                Sucu = TablaSysConfig["id_sucursal"].ToString();
                                        string VarName = TablaSysConfig["estacion"].ToString() + "/" + Sucu + "/" + TablaSysConfig["nombre"].ToString();
                                        SysConfigCache.Add(VarName, TablaSysConfig["valor"].ToString());
                                }
                                TablaSysConfig.Close();
                                SysConfigCacheLastRefresh = System.DateTime.Now;
			}

			string Busco;

			//Busco una variable para la estación
                        Busco = (terminalName == null ? System.Environment.MachineName.ToUpperInvariant() : terminalName) + "//" + CompleteSettingName;
			if(sucursal == 0 && SysConfigCache.Contains(Busco)) {
                                string Res = (string)SysConfigCache[Busco];
                                if (Res.Length > 0)
                                        return Res;
			}

			//Busco una variable para la sucursal
                        Busco = "*/" + m_Workspace.CurrentConfig.Company.CurrentBranch.ToString() + "/" + ConfigDB.EscapeString(CompleteSettingName);
                        if (terminalName == null && SysConfigCache.Contains(Busco)) {
                                string Res = (string)SysConfigCache[Busco];
                                if (Res.Length > 0)
                                        return Res;
			}

			if(sucursal == 0 && terminalName == null)
			{
				//Busco una variable global
                                Busco = "*//" + ConfigDB.EscapeString(CompleteSettingName);
                                if (SysConfigCache.Contains(Busco)) {
                                        string Res = (string)SysConfigCache[Busco];
                                        if (Res.Length > 0)
                                                return Res;
                                }
			}

			return defaultValue;
		}

		public bool DeleteGlobalSetting(string sectionName, string settingName, int branch)
		{
			if(ConfigDB == null)
				ConfigDB = m_Workspace.GetDataBase();

			if(branch == 0)
				branch = m_Workspace.CurrentConfig.Company.CurrentBranch;

			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
                        Lfx.Data.SqlDeleteBuilder DeleteCommand = new Lfx.Data.SqlDeleteBuilder("sys_config");
                        DeleteCommand.WhereClause = new Lfx.Data.SqlWhereBuilder();
                        DeleteCommand.WhereClause.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd;
                        DeleteCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("nombre", CompleteSettingName));
                        DeleteCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_sucursal", branch));
			ConfigDB.Delete(DeleteCommand);

			this.InvalidateConfigCache();
			return true;
		}

		public bool DeleteGlobalSetting(string sectionName, string settingName, string terminalName)
		{
			if(ConfigDB == null)
				ConfigDB = m_Workspace.GetDataBase();

			if(terminalName == null || terminalName.Length == 0)
                                terminalName = System.Environment.MachineName.ToUpperInvariant();

			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
                        Lfx.Data.SqlDeleteBuilder DeleteCommand = new Lfx.Data.SqlDeleteBuilder("sys_config");
                        DeleteCommand.WhereClause = new Lfx.Data.SqlWhereBuilder();
                        DeleteCommand.WhereClause.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd;
                        DeleteCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("nombre", CompleteSettingName));
                        DeleteCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("estacion", terminalName));
			ConfigDB.Delete(DeleteCommand);

			this.InvalidateConfigCache();
			return true;
		}

		public bool WriteGlobalSetting(string sectionName, string settingName, string stringValue)
		{
			return WriteGlobalSetting(sectionName, settingName, stringValue, "*");
		}

		public bool WriteGlobalSetting(string sectionName, string settingName, string stringValue, int branch)
		{
                        if (ConfigDB == null)
                                ConfigDB = m_Workspace.DefaultDataBase;

			string CurrentValue = ReadGlobalSettingString(sectionName, settingName, null, null, branch);
			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
			if(CurrentValue == null) 
			{
				//Crear el valor
                                Lfx.Data.SqlInsertBuilder InsertCommand = new Lfx.Data.SqlInsertBuilder("sys_config");
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("id_sucursal", Lfx.Data.ValueTypes.String, branch));
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("estacion", Lfx.Data.ValueTypes.String, "*"));
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("nombre", Lfx.Data.ValueTypes.String, CompleteSettingName));
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("valor", Lfx.Data.ValueTypes.String, stringValue));
				ConfigDB.Insert(InsertCommand);
			}
			else
			{
				//Actualizar el valor
				Lfx.Data.SqlUpdateBuilder UpdateCommand = new Lfx.Data.SqlUpdateBuilder("sys_config");
                                UpdateCommand.Fields.Add(new Lfx.Data.SqlField("valor", Lfx.Data.ValueTypes.String, stringValue));
				UpdateCommand.WhereClause = new Lfx.Data.SqlWhereBuilder();
				UpdateCommand.WhereClause.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd;
				UpdateCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("nombre", CompleteSettingName));
				UpdateCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_sucursal", branch));
				ConfigDB.Update(UpdateCommand);
			}

			this.InvalidateConfigCache();
			return true;
		}

		public bool WriteGlobalSetting(string sectionName, string settingName, string stringValue, string terminalName)
		{
			if(ConfigDB == null)
				ConfigDB = m_Workspace.GetDataBase();

			if(terminalName == null || terminalName.Length == 0)
                                terminalName = System.Environment.MachineName.ToUpperInvariant();

                        string CurrentValue = ReadGlobalSettingString(sectionName, settingName, null, terminalName, 0);
			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
			if(CurrentValue == null) 
			{
				//Crear el valor
                                Lfx.Data.SqlInsertBuilder InsertCommand = new Lfx.Data.SqlInsertBuilder("sys_config");
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("estacion", Lfx.Data.ValueTypes.String, terminalName));
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("nombre", Lfx.Data.ValueTypes.String, CompleteSettingName));
                                InsertCommand.Fields.Add(new Lfx.Data.SqlField("valor", Lfx.Data.ValueTypes.String, stringValue));
				ConfigDB.Insert(InsertCommand);
			}
			else
			{
				//Actualizar el valor
                                Lfx.Data.SqlUpdateBuilder UpdateCommand = new Lfx.Data.SqlUpdateBuilder("sys_config");
                                UpdateCommand.Fields.Add(new Lfx.Data.SqlField("valor", Lfx.Data.ValueTypes.String, stringValue));
                                UpdateCommand.WhereClause = new Lfx.Data.SqlWhereBuilder();
                                UpdateCommand.WhereClause.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd;
                                UpdateCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("nombre", CompleteSettingName));
                                UpdateCommand.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("estacion", terminalName));
				ConfigDB.Update(UpdateCommand);
			}

			this.InvalidateConfigCache();
			return true;
		}

		public void InvalidateConfigCache()
		{
			SysConfigCache = null;
		}

	}
}
