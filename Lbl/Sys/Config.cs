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

namespace Lbl.Sys
{
        public partial class Config
        {
                public static Configuracion.Global Actual;

                public static Lbl.Entidades.Pais Pais = null;

                public static void Cargar()
                {
                        int IdPais = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Pais", 0);
                        if (IdPais > 0)
                                Pais = new Lbl.Entidades.Pais(Lfx.Workspace.Master.MasterConnection, IdPais);
                        else
                                Pais = null;

                        if (Pais != null)
                                Moneda.MonedaPredeterminada = Pais.Moneda;
                        else
                                Moneda.MonedaPredeterminada = new Entidades.Moneda(Lfx.Workspace.Master.MasterConnection, 3);  // Pesos argentinos

                        Moneda.Simbolo = Moneda.MonedaPredeterminada.Simbolo;

                        Moneda.Decimales = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Moneda.Decimales", 2);
                        Moneda.DecimalesCosto = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Moneda.DecimalesCosto", Moneda.Decimales);
                        Moneda.DecimalesFinal = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Moneda.DecimalesFinal", Moneda.Decimales);
                        Moneda.UnidadMonetariaMinima = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<decimal>("Sistema.Moneda.Redondeo", 0);

                        Articulos.Decimales = Lfx.Workspace.Master.CurrentConfig.ReadGlobalSetting<int>("Sistema.Stock.Decimales", 0);
                }


                /// <summary>
                /// Escribe un evento en la tabla sys_log. Se utiliza para registrar operaciones de datos (altas, bajas, ingresos, egresos, etc.)
                /// </summary>
                public static void ActionLog(Lfx.Data.Connection conn, Log.Acciones action, IElementoDeDatos elemento, string extra1)
                {
                        try {
                                qGen.Insert Comando = new qGen.Insert(conn, "sys_log");
                                Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                Comando.Fields.AddWithValue("estacion", System.Environment.MachineName.ToUpperInvariant());
                                if (Lbl.Sys.Config.Actual == null || Lbl.Sys.Config.Actual.UsuarioConectado == null)
                                        Comando.Fields.AddWithValue("usuario", null);
                                else
                                        Comando.Fields.AddWithValue("usuario", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                                Comando.Fields.AddWithValue("comando", action.ToString());
                                if (elemento == null) {
                                        Comando.Fields.AddWithValue("tabla", null);
                                        Comando.Fields.AddWithValue("item_id", null);
                                } else {
                                        Comando.Fields.AddWithValue("tabla", elemento.TablaDatos);
                                        Comando.Fields.AddWithValue("item_id", elemento.Id);
                                }
                                Comando.Fields.AddWithValue("extra1", extra1);
                                conn.Execute(Comando);
                        } catch (System.Exception ex) {
                                System.Console.WriteLine(ex.ToString());
                        }
                }
        }
}
