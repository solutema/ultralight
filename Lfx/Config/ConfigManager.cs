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
using System.Drawing;
using System.Collections.Generic;

namespace Lfx.Config
{
	/// <summary>
	/// Maneja los parámetros de configuración
	/// </summary>
	public class ConfigManager : IDisposable
	{
		private string m_ConfigFileName;
		private System.Xml.XmlDocument ConfigDocument;
		private Workspace m_Workspace;
                private Lfx.Data.Connection m_DataBase;

                public Lfx.Config.ProductsConfig Productos;
                public Lfx.Config.CurrencyConfig Moneda;
                public Lfx.Config.CompanyConfig Empresa;

                private Dictionary<string, string> SysConfigCache = null;
                private System.DateTime SysConfigCacheLastRefresh;

                public ConfigManager(Workspace workspace)
		{
			m_Workspace = workspace;
			ConfigFileName = m_Workspace.Name + ".lwf";

                        Productos = new Lfx.Config.ProductsConfig(this);
                        Moneda = new Lfx.Config.CurrencyConfig(this);
                        Empresa = new Lfx.Config.CompanyConfig(this);
		}

                public Lfx.Workspace Workspace
                {
                        get
                        {
                                return m_Workspace;
                        }
                }

                public void Dispose()
                {
                        if (m_DataBase != null)
                                m_DataBase.Dispose();
                        GC.SuppressFinalize(this);
                }

		public string ConfigFileName
		{
			get
			{
				return m_ConfigFileName;
			}
			set
			{
				m_ConfigFileName = value;

                                if (!System.IO.Path.IsPathRooted(m_ConfigFileName)) {
                                        // Si no tiene ruta, busco en la carpeta de datos
                                        // o junto al ejecutable (para aplicaciones portables)
                                        if (System.IO.File.Exists(Lfx.Environment.Folders.ApplicationFolder + m_ConfigFileName)) {
                                                m_ConfigFileName = Lfx.Environment.Folders.ApplicationFolder + m_ConfigFileName;
                                        } else {
                                                m_ConfigFileName = Lfx.Environment.Folders.ApplicationDataFolder + m_ConfigFileName;
                                        }
                                }
			}
		}

                public Lfx.Data.Connection DataBase
                {
                        get
                        {
                                if (m_DataBase == null) {
                                        m_DataBase = m_Workspace.GetNewConnection("Administrador de configuración");
                                        m_DataBase.RequiresTransaction = false;
                                }
                                return m_DataBase;
                        }
                }

                public void ClearCache()
                {
                        SysConfigCache = null;
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
                                if (ConfigDocument == null) {
                                        ConfigDocument = new System.Xml.XmlDocument();
                                        try {
                                                ConfigDocument.Load(ConfigFileName);
                                        } catch {
                                                // El archivo de configuración está vacío o dañado
                                                return null;
                                        }
                                }

                                System.Xml.XmlNode SettingNode = ConfigDocument.SelectSingleNode("/LocalConfig/Section[@name='" + sectionName + "']/Setting[@name='" + settingName + "']");
                                if (SettingNode != null) {
                                        System.Xml.XmlAttribute SettingAttribute = SettingNode.Attributes["value"];
                                        if (SettingAttribute != null)
                                                Result = SettingAttribute.Value;
                                }

			}
			return Result;
		}


                public T ReadGlobalSetting<T>(string sectionName, string settingName, T defaultValue)
                {
                        return this.ReadGlobalSetting<T>(sectionName, settingName, defaultValue, null, 0);
                }


                public T ReadGlobalSetting<T>(string sectionName, string settingName, T defaultValue, string terminalName, int sucursal)
                {
                        string Val = ReadGlobalSettingString(sectionName, settingName, null, terminalName, sucursal);
                        if (Val == null)
                                return defaultValue;

                        object Res;
                        if (typeof(T) == typeof(string))
                                Res = Val;
                        else if (typeof(T) == typeof(int))
                                Res = Lfx.Types.Parsing.ParseInt(Val);
                        else if (typeof(T) == typeof(decimal))
                                Res = Lfx.Types.Parsing.ParseDecimal(Val);
                        else if (typeof(T) == typeof(DateTime))
                                Res = Lfx.Types.Parsing.ParseSqlDateTime(Val);
                        else
                                Res = null;

                        return (T)Res;
                }

                private string ReadGlobalSettingString(string sectionName, string settingName, string defaultValue, string terminalName, int sucursal)
		{
			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
			
			//Si el caché es muy viejo, lo vacío
			if(SysConfigCache != null && System.DateTime.Now > SysConfigCacheLastRefresh.AddMinutes(10)) {
                                this.ClearCache();
			}

                        if (SysConfigCache == null) {
                                SysConfigCache = new Dictionary<string, string>();

                                qGen.Select SelectConfig = new qGen.Select("sys_config");
                                SelectConfig.Fields = "nombre, valor, estacion, id_sucursal";
                                System.Data.DataTable TablaSysConfig = this.DataBase.Select(SelectConfig);
                                foreach(System.Data.DataRow CfgRow in TablaSysConfig.Rows) {
                                        string Sucu;
                                        if (CfgRow["id_sucursal"] == null)
                                                Sucu = "0";
                                        else
                                                Sucu = CfgRow["id_sucursal"].ToString();
                                        string VarName = CfgRow["estacion"].ToString() + "/" + Sucu + "/" + CfgRow["nombre"].ToString();
                                        SysConfigCache.Add(VarName, CfgRow["valor"].ToString());
                                }
                                SysConfigCacheLastRefresh = System.DateTime.Now;
			}

			string Busco;

			//Busco una variable para la estación
                        Busco = (terminalName == null ? System.Environment.MachineName.ToUpperInvariant() : terminalName) + "/0/" + CompleteSettingName;
			if(sucursal == 0 && SysConfigCache.ContainsKey(Busco)) {
                                string Res = (string)SysConfigCache[Busco];
                                if (Res.Length > 0)
                                        return Res;
			}

			//Busco una variable para la sucursal
                        Busco = "*/" + m_Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString() + "/" + DataBase.EscapeString(CompleteSettingName);
                        if (terminalName == null && SysConfigCache.ContainsKey(Busco)) {
                                string Res = (string)SysConfigCache[Busco];
                                if (Res.Length > 0)
                                        return Res;
			}

			if(sucursal == 0 && terminalName == null)
			{
				//Busco una variable global
                                Busco = "*/0/" + DataBase.EscapeString(CompleteSettingName);
                                if (SysConfigCache.ContainsKey(Busco)) {
                                        string Res = (string)SysConfigCache[Busco];
                                                return Res;
                                }
			}

			return defaultValue;
		}

		public bool DeleteGlobalSetting(string sectionName, string settingName, int branch)
		{
			if(branch == 0)
				branch = m_Workspace.CurrentConfig.Empresa.SucursalPredeterminada;

			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
                        qGen.Delete DeleteCommand = new qGen.Delete("sys_config");
                        DeleteCommand.WhereClause = new qGen.Where(qGen.AndOr.And);
                        DeleteCommand.WhereClause.Add(new qGen.ComparisonCondition("nombre", CompleteSettingName));
                        DeleteCommand.WhereClause.Add(new qGen.ComparisonCondition("id_sucursal", branch));
			DataBase.Delete(DeleteCommand);

                        CompleteSettingName = "*/" + branch.ToString() + "/" + CompleteSettingName;

                        if (this.SysConfigCache.ContainsKey(CompleteSettingName))
                                this.SysConfigCache.Remove(CompleteSettingName);
			return true;
		}

		public bool DeleteGlobalSetting(string sectionName, string settingName, string terminalName)
		{
			if(terminalName == null || terminalName.Length == 0)
                                terminalName = System.Environment.MachineName.ToUpperInvariant();

			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
                        qGen.Delete DeleteCommand = new qGen.Delete("sys_config");
                        DeleteCommand.WhereClause = new qGen.Where();
                        DeleteCommand.WhereClause.Operator = qGen.AndOr.And;
                        DeleteCommand.WhereClause.Add(new qGen.ComparisonCondition("nombre", CompleteSettingName));
                        DeleteCommand.WhereClause.Add(new qGen.ComparisonCondition("estacion", terminalName));
			DataBase.Delete(DeleteCommand);

                        CompleteSettingName = terminalName + "/0/" + CompleteSettingName;

                        if (this.SysConfigCache.ContainsKey(CompleteSettingName))
                                this.SysConfigCache.Remove(CompleteSettingName);
			return true;
		}

		public bool WriteGlobalSetting(string sectionName, string settingName, string stringValue)
		{
			return WriteGlobalSetting(sectionName, settingName, stringValue, "*");
		}

		public bool WriteGlobalSetting(string sectionName, string settingName, string stringValue, int branch)
		{
			string CurrentValue = ReadGlobalSetting<string>(sectionName, settingName, null, null, branch);
			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
			if(CurrentValue == null) 
			{
				//Crear el valor
                                qGen.Insert InsertCommand = new qGen.Insert("sys_config");
                                InsertCommand.Fields.Add(new Lfx.Data.Field("id_sucursal", Lfx.Data.DbTypes.Integer, branch));
                                InsertCommand.Fields.Add(new Lfx.Data.Field("estacion", Lfx.Data.DbTypes.VarChar, "*"));
                                InsertCommand.Fields.Add(new Lfx.Data.Field("nombre", Lfx.Data.DbTypes.VarChar, CompleteSettingName));
                                InsertCommand.Fields.Add(new Lfx.Data.Field("valor", Lfx.Data.DbTypes.VarChar, stringValue));
				DataBase.Insert(InsertCommand);
			}
			else
			{
				//Actualizar el valor
				qGen.Update UpdateCommand = new qGen.Update("sys_config");
                                UpdateCommand.Fields.Add(new Lfx.Data.Field("valor", Lfx.Data.DbTypes.VarChar, stringValue));
				UpdateCommand.WhereClause = new qGen.Where();
				UpdateCommand.WhereClause.Operator = qGen.AndOr.And;
                                UpdateCommand.WhereClause.Add(new qGen.ComparisonCondition("nombre", CompleteSettingName));
                                UpdateCommand.WhereClause.Add(new qGen.ComparisonCondition("id_sucursal", branch));
				DataBase.Update(UpdateCommand);
			}

                        CompleteSettingName = "*/" + branch.ToString() + "/" + CompleteSettingName;

                        if (this.SysConfigCache.ContainsKey(CompleteSettingName))
                                this.SysConfigCache[CompleteSettingName] = stringValue;
                        else
                                this.SysConfigCache.Add(CompleteSettingName, stringValue);

			return true;
		}

		public bool WriteGlobalSetting(string sectionName, string settingName, string stringValue, string terminalName)
		{
			if(terminalName == null || terminalName.Length == 0)
                                terminalName = System.Environment.MachineName.ToUpperInvariant();

                        string CurrentValue = ReadGlobalSetting<string>(sectionName, settingName, null, terminalName, 0);
			string CompleteSettingName = (sectionName==null||sectionName.Length==0?"":(sectionName+@".")) + settingName;
			if(CurrentValue == null) 
			{
				//Crear el valor
                                qGen.Insert InsertCommand = new qGen.Insert("sys_config");
                                InsertCommand.Fields.Add(new Lfx.Data.Field("estacion", Lfx.Data.DbTypes.VarChar, terminalName));
                                InsertCommand.Fields.Add(new Lfx.Data.Field("nombre", Lfx.Data.DbTypes.VarChar, CompleteSettingName));
                                InsertCommand.Fields.Add(new Lfx.Data.Field("valor", Lfx.Data.DbTypes.VarChar, stringValue));
				DataBase.Insert(InsertCommand);
			}
			else
			{
				//Actualizar el valor
                                qGen.Update UpdateCommand = new qGen.Update("sys_config");
                                UpdateCommand.Fields.Add(new Lfx.Data.Field("valor", Lfx.Data.DbTypes.VarChar, stringValue));
                                UpdateCommand.WhereClause = new qGen.Where();
                                UpdateCommand.WhereClause.Operator = qGen.AndOr.And;
                                UpdateCommand.WhereClause.Add(new qGen.ComparisonCondition("nombre", CompleteSettingName));
                                UpdateCommand.WhereClause.Add(new qGen.ComparisonCondition("estacion", terminalName));
				DataBase.Update(UpdateCommand);
			}

                        CompleteSettingName = terminalName + "/0/" + CompleteSettingName;

                        if (this.SysConfigCache.ContainsKey(CompleteSettingName))
                                this.SysConfigCache[CompleteSettingName] = stringValue;
                        else
                                this.SysConfigCache.Add(CompleteSettingName, stringValue);

			return true;
		}

		public void InvalidateConfigCache()
		{
			SysConfigCache = null;
		}

	}
}
