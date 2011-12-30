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
using System.Collections.Generic;
using System.Text;

namespace Lfx.Config
{
        public class CurrencyConfig
        {
                private ConfigManager ConfigManager;

                public CurrencyConfig(ConfigManager configManager)
                {
                        this.ConfigManager = configManager;
                }

                // La cantidad de decimales para el stock
                private static int m_Decimales = -1;
                public int Decimales
                {
                        get
                        {
                                if (m_Decimales == -1)
                                        m_Decimales = ConfigManager.ReadGlobalSetting<int>("Sistema.Moneda.Decimales", 2);
                                return m_Decimales;
                        }
                }

                private static int m_DecimalesCosto = -1;
                public int DecimalesCosto
                {
                        get
                        {
                                if (m_DecimalesCosto == -1)
                                        m_DecimalesCosto = ConfigManager.ReadGlobalSetting<int>("Sistema.Moneda.DecimalesCosto", this.Decimales);
                                return m_DecimalesCosto;
                        }
                }

                private static int m_DecimalesFinal = -1;
                public int DecimalesFinal
                {
                        get
                        {
                                if (m_DecimalesFinal == -1)
                                        m_DecimalesFinal = ConfigManager.ReadGlobalSetting<int>("Sistema.Moneda.DecimalesFinal", this.Decimales);
                                return m_DecimalesFinal;
                        }
                }
        }
}
