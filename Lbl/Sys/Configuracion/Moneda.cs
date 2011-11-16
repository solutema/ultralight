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

namespace Lbl.Sys.Configuracion
{
        public class Moneda : SeccionConfiguracion
        {
                public string Simbolo;
                public Lbl.Entidades.Moneda MonedaPredeterminada;

                public Moneda(Lfx.Workspace workspace)
                        : base(workspace)
                {
                        MonedaPredeterminada = new Entidades.Moneda(this.DataBase, 3);  // Pesos argentinos
                        this.Simbolo = MonedaPredeterminada.Simbolo;
                }

                // La cantidad de decimales para el stock
                private int m_Decimales = -1;
                public int Decimales
                {
                        get
                        {
                                if (m_Decimales == -1)
                                        m_Decimales = this.DataBase.Workspace.CurrentConfig.ReadGlobalSetting<int>(null, "Sistema.Moneda.Decimales", 2);
                                return m_Decimales;
                        }
                }

                private int m_DecimalesCosto = -1;
                public int DecimalesCosto
                {
                        get
                        {
                                if (m_DecimalesCosto == -1)
                                        m_DecimalesCosto = this.DataBase.Workspace.CurrentConfig.ReadGlobalSetting<int>(null, "Sistema.Moneda.DecimalesCosto", this.Decimales);
                                return m_DecimalesCosto;
                        }
                }

                private int m_DecimalesFinal = -1;
                public int DecimalesFinal
                {
                        get
                        {
                                if (m_DecimalesFinal == -1)
                                        m_DecimalesFinal = this.DataBase.Workspace.CurrentConfig.ReadGlobalSetting<int>(null, "Sistema.Moneda.DecimalesFinal", this.Decimales);
                                return m_DecimalesFinal;
                        }
                }

                private decimal m_Redodeo = -1;
                public decimal Redondeo
                {
                        get
                        {
                                if (m_Redodeo == -1)
                                        m_Redodeo = Lfx.Types.Parsing.ParseDecimal(this.DataBase.Workspace.CurrentConfig.ReadGlobalSetting<string>("", "Sistema.Moneda.Redondeo", "0"));
                                return m_Redodeo;
                        }
                }
        }
}
