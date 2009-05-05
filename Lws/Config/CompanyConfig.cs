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
using System.Collections.Generic;
using System.Text;

namespace Lws.Config
{
        public class CompanyConfig
        {
                private ConfigManager ConfigManager;
                private Lfx.Data.Row m_Sucursal;

                public CompanyConfig(ConfigManager configManager)
                {
                        this.ConfigManager = configManager;
                }

                private Lfx.Data.Row Sucursal
                {
                        get
                        {
                                if (m_Sucursal == null)
                                        m_Sucursal = ConfigManager.Workspace.DefaultDataView.Tables["sucursales"].FastRows[this.CurrentBranch];
                                return m_Sucursal;
                        }
                }

                public int CurrentBranch
                {
                        get
                        {
                                return ConfigManager.ReadLocalSettingInt("Company", "Branch", 1);
                        }
                        set
                        {
                                ConfigManager.WriteLocalSetting("Company", "Branch", value);
                        }
                }

                public string Telefono
                {
                        get
                        {
                                return this.Sucursal["telefono"].ToString();
                        }
                }

                public string Domicilio
                {
                        get
                        {
                                return this.Sucursal["direccion"].ToString();
                        }
                }

                public string NombreCiudad
                {
                        get
                        {
                                return ConfigManager.Workspace.DefaultDataBase.FieldString("SELECT nombre FROM ciudades WHERE id_ciudad=(SELECT id_ciudad FROM sucursales WHERE id_sucursal=" + this.CurrentBranch.ToString() + ")");
                        }
                }

                public int idCiudad
                {
                        get
                        {
                                int City = ConfigManager.Workspace.DefaultDataBase.FieldInt("SELECT id_ciudad FROM sucursales WHERE id_sucursal=" + ConfigManager.Company.CurrentBranch.ToString());
                                if (City > 0)
                                        return City;
                                else
                                        return 1;
                        }
                }

                public int DefaultSituacionOrigen
                {
                        get
                        {
                                int SituacionOrigen = ConfigManager.Workspace.DefaultDataBase.FieldInt("SELECT situacionorigen FROM sucursales WHERE id_sucursal=" + ConfigManager.Company.CurrentBranch.ToString());
                                if (SituacionOrigen > 0)
                                        return SituacionOrigen;
                                else
                                        return 1;
                        }
                }

                public int CajaDiaria
                {
                        get
                        {
                                int CuentaCaja = ConfigManager.Workspace.DefaultDataBase.FieldInt("SELECT id_cuenta_caja FROM sucursales WHERE id_sucursal=" + ConfigManager.Company.CurrentBranch.ToString());
                                if (CuentaCaja > 0)
                                        return CuentaCaja;
                                else
                                        return 999;
                        }
                }

                public int CuentaCheques
                {
                        get
                        {
                                int CuentaCheques = ConfigManager.Workspace.DefaultDataBase.FieldInt("SELECT id_cuenta_cheques FROM sucursales WHERE id_sucursal=" + ConfigManager.Company.CurrentBranch.ToString());
                                if (CuentaCheques > 0)
                                        return CuentaCheques;
                                else
                                        return this.CajaDiaria;
                        }
                }

                public string Name
                {
                        get
                        {
                                return ConfigManager.ReadGlobalSettingString("Sistema", "Empresa.Nombre", "Empresa Sin Nombre");
                        }
                        set
                        {
                                ConfigManager.WriteGlobalSetting("Sistema", "Empresa.Nombre", value, "*");
                        }
                }

                public int SituacionTributaria
                {
                        get
                        {
                                return ConfigManager.ReadGlobalSettingInt("Sistema", "Empresa.Situacion", 2);
                        }
                        set
                        {
                                ConfigManager.WriteGlobalSetting("Sistema", "Empresa.Situacion", value.ToString(), "*");
                        }
                }

                public string CUIT
                {
                        get
                        {
                                return ConfigManager.ReadGlobalSettingString("Sistema", "Empresa.CUIT", "00-00000000-0");
                        }
                        set
                        {
                                ConfigManager.WriteGlobalSetting("Sistema", "Empresa.CUIT", value, 0);
                        }
                }
        }
}
