#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfx.Config
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
                                        m_Sucursal = ConfigManager.DataBase.Tables["sucursales"].FastRows[this.SucursalPredeterminada];
                                return m_Sucursal;
                        }
                }

                public int SucursalPredeterminada
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

                public string NombreLocalidad
                {
                        get
                        {
                                return ConfigManager.DataBase.FieldString("SELECT nombre FROM ciudades WHERE id_ciudad=(SELECT id_ciudad FROM sucursales WHERE id_sucursal=" + this.SucursalPredeterminada.ToString() + ")");
                        }
                }

                public int IdLocalidad
                {
                        get
                        {
                                int City = ConfigManager.DataBase.FieldInt("SELECT id_ciudad FROM sucursales WHERE id_sucursal=" + ConfigManager.Empresa.SucursalPredeterminada.ToString());
                                if (City > 0)
                                        return City;
                                else
                                        return 1;
                        }
                }

                public int SituacionOrigenPredeterminada
                {
                        get
                        {
                                int SituacionOrigen = ConfigManager.DataBase.FieldInt("SELECT situacionorigen FROM sucursales WHERE id_sucursal=" + ConfigManager.Empresa.SucursalPredeterminada.ToString());
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
                                int IdCajaDiaria = ConfigManager.DataBase.FieldInt("SELECT id_caja_diaria FROM sucursales WHERE id_sucursal=" + ConfigManager.Empresa.SucursalPredeterminada.ToString());
                                if (IdCajaDiaria > 0)
                                        return IdCajaDiaria;
                                else
                                        return 999;
                        }
                }

                public int CajaCheques
                {
                        get
                        {
                                int IdCajaCheques = ConfigManager.DataBase.FieldInt("SELECT id_caja_cheques FROM sucursales WHERE id_sucursal=" + ConfigManager.Empresa.SucursalPredeterminada.ToString());
                                if (IdCajaCheques > 0)
                                        return IdCajaCheques;
                                else
                                        return this.CajaDiaria;
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
        }
}
