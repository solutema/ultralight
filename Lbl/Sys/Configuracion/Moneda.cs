#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lbl.Sys.Configuracion
{
        public class Moneda : SeccionConfiguracion
        {
                public string Simbolo { get; set; }
                public Lbl.Entidades.Moneda MonedaPredeterminada { get; set; }

                public Moneda(Lfx.Workspace workspace)
                        : base(workspace)
                {
                        MonedaPredeterminada = new Entidades.Moneda(this.DataBase, 3);  // Pesos argentinos
                        this.Simbolo = MonedaPredeterminada.Simbolo;
                }


                private int m_Decimales = -1;
                /// <summary>
                /// La cantidad de decimales para los precios de venta en general.
                /// </summary>
                public int Decimales
                {
                        get
                        {
                                if (m_Decimales == -1)
                                        m_Decimales = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Moneda.Decimales", 2);
                                return m_Decimales;
                        }
                        set
                        {
                                m_Decimales = value;
                                Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema.Moneda.Decimales", m_Decimales);
                        }
                }


                private int m_DecimalesCosto = -1;
                /// <summary>
                /// La cantidad de decimales para los precios de compra y de costo.
                /// </summary>
                public int DecimalesCosto
                {
                        get
                        {
                                if (m_DecimalesCosto == -1)
                                        m_DecimalesCosto = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Moneda.DecimalesCosto", this.Decimales);
                                return m_DecimalesCosto;
                        }
                        set
                        {
                                m_DecimalesCosto = value;
                                Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema.Moneda.DecimalesCosto", m_DecimalesCosto);
                        }
                }


                private int m_DecimalesFinal = -1;
                /// <summary>
                /// La cantidad de decimales para el importe final del comprobante.
                /// </summary>
                public int DecimalesFinal
                {
                        get
                        {
                                if (m_DecimalesFinal == -1)
                                        m_DecimalesFinal = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Moneda.DecimalesFinal", this.Decimales);
                                return m_DecimalesFinal;
                        }
                        set
                        {
                                m_DecimalesFinal = value;
                                Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema.Moneda.DecimalesFinal", m_DecimalesFinal);
                        }
                }


                private decimal m_UnidadMonetariaMinima = -1;
                /// <summary>
                /// La unidad monetaria mínima para el importe final de los comprobantes de venta.
                /// Esto puede conicidir con el valor de la divisa monetaria más pequeña en circulación, para evitar dar cambio en
                /// monedas que no existen. Por ejemplo, si la moneda más pequeña es de 5 centavos, este valor podría ser 0.05 para evitar
                /// dar cambio de 1, 2, 3 y 4 centavos, que es imposible.
                /// Ejemplos: 
                ///     UnidadMonetariaMinima = 0        El importe final no se trunca.
                ///     UnidadMonetariaMinima = 0.05     El importe final se trunca a 5 centavos, o sea algo que cuesta $ 1.18 se factura a $ 1.15.
                ///     UnidadMonetariaMinima = 1        El importe final se trunca a 1 peso, o sea se eliminan los centavos.
                /// </summary>
                public decimal UnidadMonetariaMinima
                {
                        get
                        {
                                if (m_UnidadMonetariaMinima == -1)
                                        m_UnidadMonetariaMinima = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<decimal>("Sistema.Moneda.Redondeo", 0);
                                return m_UnidadMonetariaMinima;
                        }
                        set
                        {
                                m_UnidadMonetariaMinima = value;
                                Lfx.Workspace.Master.CurrentConfig.WriteGlobalSetting("Sistema.Moneda.Redondeo", m_UnidadMonetariaMinima);
                        }
                }
        }
}
