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
        public class ProductsConfig
        {
                private ConfigManager ConfigManager;

                public ProductsConfig(ConfigManager configManager)
                {
                        this.ConfigManager = configManager;
                }

                // La cantidad de decimales para el stock
                public int DecimalesStock
                {
                        get
                        {
                                return ConfigManager.ReadGlobalSetting<int>("Sistema.Stock.Decimales", 0);
                        }
                }

                public int DepositoPredeterminado
                {
                        get
                        {
                                return ConfigManager.ReadGlobalSetting<int>("Sistema.Stock.DepositoPredet", 1);
                        }
                }

                // Si usa situaciones de stock
                public bool StockMultideposito
                {
                        get
                        {
                                return ConfigManager.ReadGlobalSetting<int>("Sistema.Stock.Multideposito", 0) != 0;
                        }
                }

                private static string ps_DefaultCode = null;
                public string CodigoPredeterminado()
                {
                        if (ps_DefaultCode != null)
                                return ps_DefaultCode;

                        // Devuelve el código predeterminado de un artículo
                        int CodPredet = ConfigManager.ReadGlobalSetting<int>("Sistema.Stock.CodigoPredet", 0);

                        switch (CodPredet) {
                                case 0:
                                        // Usar el código autonumérico integrado
                                        ps_DefaultCode = "id_articulo";
                                        break;
                                default:
                                        // Usar un código en particular
                                        ps_DefaultCode = "codigo" + CodPredet.ToString();
                                        break;
                        }
                        return ps_DefaultCode;
                }
        }
}
