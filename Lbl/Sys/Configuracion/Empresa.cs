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
        public class Empresa : SeccionConfiguracion
        {
                private Lbl.Impuestos.Alicuota m_AlicuotaPredeterminada = null;
                private Lbl.Entidades.Pais m_Pais = null;
                private ColeccionGenerica<Lbl.Comprobantes.PuntoDeVenta> m_PuntosDeVenta = null;

                public Lbl.Entidades.Sucursal SucursalPredeterminada { get; set; }

                public Empresa(Lfx.Workspace workspace)
                        : base(workspace)
                {
                        this.SucursalPredeterminada = new Entidades.Sucursal(this.DataBase, this.Workspace.CurrentConfig.ReadLocalSettingInt("Company", "Branch", 1));
                }


                public int SituacionTributaria
                {
                        get
                        {
                                return this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Empresa.Situacion", 2);
                        }
                        set
                        {
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.Situacion", value);
                        }
                }


                public Lbl.Entidades.Pais Pais
                {
                        get
                        {
                                if (m_Pais == null) {
                                        int IdPais = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Pais", 0);
                                        if (IdPais > 0)
                                                m_Pais = new Lbl.Entidades.Pais(this.DataBase, IdPais);
                                        else
                                                m_Pais = new Lbl.Entidades.Pais(this.DataBase, 1);
                                }

                                return m_Pais;
                        }
                }


                public Lbl.Impuestos.Alicuota AlicuotaPredeterminada
                {
                        get
                        {
                                if (m_AlicuotaPredeterminada == null) {
                                        if(this.SituacionTributaria == 4)
                                                // Monotributistas usan alícuota del 0% por comodidad
                                                m_AlicuotaPredeterminada = new Impuestos.Alicuota(this.DataBase, 4);
                                        else
                                                // El resto usan 21%
                                                m_AlicuotaPredeterminada = new Impuestos.Alicuota(this.DataBase, 1);
                                }

                                return m_AlicuotaPredeterminada;
                        }
                }


                public string Nombre
                {
                        get
                        {
                                return this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema.Empresa.Nombre", "Empresa Sin Nombre");
                        }
                        set
                        {
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.Nombre", value);
                        }
                }


                public int Id
                {
                        get
                        {
                                return this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema.Empresa.Id", 1);
                        }
                        set
                        {
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.Id", value);
                        }
                }


                public string RazonSocial
                {
                        get
                        {
                                string Predet;
                                if (string.Compare(Nombre, "Empresa Sin Nombre") == 0)
                                        Predet = "Compañía sin Nombre";
                                else
                                        Predet = Nombre;

                                return this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema.Empresa.RazonSocial", Predet);
                        }
                        set
                        {
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.RazonSocial", value);
                        }
                }

                public IIdentificadorUnico ClaveTributaria
                {
                        get
                        {
                                string Res = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema.Empresa.CUIT", "");
                                if (Res == "" || Res == "00-00000000-0")
                                        return null;
                                else
                                        return new Personas.Claves.Cuit(Res);
                        }
                        set
                        {
                                if (value == null)
                                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.CUIT", "", 0);
                                else
                                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.CUIT", value.ToString(), 0);
                        }
                }

                public string Email
                {
                        get
                        {
                                return this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema.Empresa.Email", "");
                        }
                        set
                        {
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema.Empresa.Email", value);
                        }
                }


                public ColeccionGenerica<Lbl.Comprobantes.PuntoDeVenta> PuntosDeVenta
                {
                        get
                        {
                                if (m_PuntosDeVenta == null) {
                                        System.Data.DataTable TablaPvs = this.DataBase.Select("SELECT * FROM pvs");
                                        m_PuntosDeVenta = new Lbl.ColeccionGenerica<Lbl.Comprobantes.PuntoDeVenta>(this.DataBase, TablaPvs);
                                }
                                return m_PuntosDeVenta;
                        }
                }
        }
}