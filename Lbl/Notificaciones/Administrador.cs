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

namespace Lbl.Notificaciones
{
        /// <summary>
        /// Administrador de notificaciones.
        /// </summary>
        public class Administrador : IDisposable
        {
                public static Administrador Principal = null;

                private Lfx.Data.Connection m_DataBase = null;
                private int LastMessageId { get; set; }
                private System.Timers.Timer PollTimer;

                public void Dispose()
                {
                        if (this.PollTimer != null) {
                                this.PollTimer.Stop();
                                this.PollTimer.Dispose();
                                this.PollTimer = null;
                        }
                        if (m_DataBase != null) {
                                m_DataBase.Dispose();
                                m_DataBase = null;
                        }
                        GC.SuppressFinalize(this);
                }


                private Lfx.Data.Connection Connection
                {
                        get
                        {
                                if (m_DataBase == null) {
                                        m_DataBase = Lfx.Workspace.Master.GetNewConnection("Administrador de notificaciones");
                                        m_DataBase.RequiresTransaction = false;
                                }
                                return m_DataBase;
                        }
                }


                public void Iniciar()
                {
                        try {
                                qGen.Select SelUltimoId = new qGen.Select("sys_mensajeria");
                                SelUltimoId.Fields = "MAX(id_ultimomensaje)";
                                SelUltimoId.WhereClause = new qGen.Where();
                                SelUltimoId.WhereClause.AddWithValue("id_usuario", Lbl.Sys.Config.Actual.UsuarioConectado.Id);

                                this.LastMessageId = this.Connection.FieldInt(SelUltimoId);

                                this.PollTimer = new System.Timers.Timer();
                                this.PollTimer.Interval = Lfx.Workspace.Master.SlowLink ? 7000 : 3000;
                                this.PollTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.PollTimer_Elapsed);
                                this.PollTimer.Start();
                        } catch {
                                //if (Lfx.Environment.SystemInformation.DesignMode)
                                        //throw;
                        }
                }

                private void PollTimer_Elapsed(Object sender, System.Timers.ElapsedEventArgs e)
                {
                        this.PollTimer.Stop();
                        Poll();
                        this.PollTimer.Start();
                }


                public List<UsuarioConectado> ObtenerUsuariosConectados()
                {
                        List<UsuarioConectado> Res = new List<UsuarioConectado>();

                        qGen.Select SelUsuarios = new qGen.Select("sys_mensajeria");
                        SelUsuarios.WhereClause = new qGen.Where();
                        SelUsuarios.WhereClause.AddWithValue("fecha", qGen.ComparisonOperators.GreaterOrEqual, new qGen.SqlExpression("DATE_SUB(fecha, INTERVAL 20 SECOND)"));

                        try {
                                System.Data.DataTable TablaUsuarios = this.Connection.Select(SelUsuarios);
                                foreach (System.Data.DataRow Usuario in TablaUsuarios.Rows) {
                                        Res.Add(new UsuarioConectado((Lfx.Data.Row)(Usuario)));
                                }
                        } catch {
                        }

                        return Res;
                }


                public void Enviar(INotificacion notif)
                {
                        qGen.Insert InsertarMensaje = new qGen.Insert("sys_mensajes");
                        InsertarMensaje.Fields.AddWithValue("id_remitente", notif.Remitente.Id);
                        InsertarMensaje.Fields.AddWithValue("id_destinatario", notif.Destinatario.Id);
                        InsertarMensaje.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                        InsertarMensaje.Fields.AddWithValue("destino", notif.Destino);
                        InsertarMensaje.Fields.AddWithValue("nombre", notif.Nombre);
                        InsertarMensaje.Fields.AddWithValue("obs", notif.Obs);
                        InsertarMensaje.Fields.AddWithValue("estacion_envia", notif.EstacionOrigen);
                        InsertarMensaje.Fields.AddWithValue("estacion_recibe", notif.EstacionDestino);

                        this.Connection.Execute(InsertarMensaje);
                }


                public void Poll()
                {
                        if (this.Connection.State != System.Data.ConnectionState.Open)
                                this.Connection.Open();

                        qGen.Where WhereUsuario = new qGen.Where(qGen.AndOr.Or);
                        WhereUsuario.AddWithValue("id_destinatario", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                        WhereUsuario.AddWithValue("id_destinatario", null);
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.Persona.Grupo != null)
                                WhereUsuario.AddWithValue("id_grupo", Lbl.Sys.Config.Actual.UsuarioConectado.Persona.Grupo.Id);
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.Persona.SubGrupo != null)
                                WhereUsuario.AddWithValue("id_grupo", Lbl.Sys.Config.Actual.UsuarioConectado.Persona.SubGrupo.Id);


                        qGen.Select SelMensajesSinLeer = new qGen.Select("sys_mensajes");

                        SelMensajesSinLeer.WhereClause = new qGen.Where();
                        //SelMensajesSinLeer.WhereClause.AddWithValue("estacion_recibe", Lfx.Environment.SystemInformation.MachineName);
                        SelMensajesSinLeer.WhereClause.AddWithValue("id_mensaje", qGen.ComparisonOperators.GreaterThan, this.LastMessageId);
                        SelMensajesSinLeer.WhereClause.AddWithValue(WhereUsuario);
                        SelMensajesSinLeer.Order = "id_mensaje";

                        System.Data.DataTable TablaMensajes;
                        try {
                                TablaMensajes = this.Connection.Select(SelMensajesSinLeer);
                                foreach (System.Data.DataRow Mensaje in TablaMensajes.Rows) {
                                        INotificacion Res = new NotificacionRegistro(this.Connection, (Lfx.Data.Row)(Mensaje));
                                        this.LastMessageId = System.Convert.ToInt32(Mensaje["id_mensaje"]);
                                        string Destino = System.Convert.ToString(Mensaje["destino"]);
                                        if (Lfx.Components.Manager.ComponentesCargados.ContainsKey(Destino)) {
                                                // Lo notifico via IPC
                                                Lfx.Workspace.Master.RunTime.Notify(Destino, Res);

                                                // Se lo notifico directamente al componente
                                                if (Lfx.Components.Manager.ComponentesCargados[Destino].Funciones.ContainsKey("Notify")) {
                                                        Lfx.Components.Manager.ComponentesCargados[Destino].Funciones["Notify"].Instancia.Arguments = new object[] { Res };
                                                        Lfx.Components.Manager.ComponentesCargados[Destino].Funciones["Notify"].Run();
                                                }
                                        } else {
                                                Lfx.Workspace.Master.RunTime.Notify(Destino, Res);
                                        }
                                }

                                qGen.Insert ActualizarEstado = new qGen.Insert("sys_mensajeria");
                                ActualizarEstado.OnDuplicateKeyUpdate = true;
                                ActualizarEstado.Fields.AddWithValue("id_usuario", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                                ActualizarEstado.Fields.AddWithValue("estacion", Lfx.Environment.SystemInformation.MachineName);
                                ActualizarEstado.Fields.AddWithValue("nombre", Lbl.Sys.Config.Actual.UsuarioConectado.Nombre);
                                ActualizarEstado.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                if (this.LastMessageId > 0)
                                        ActualizarEstado.Fields.AddWithValue("id_ultimomensaje", this.LastMessageId);

                                this.Connection.Execute(ActualizarEstado);
                        } catch (Exception ex) {
                                System.Console.WriteLine(ex.Message);
                                if (Lfx.Environment.SystemInformation.DesignMode)
                                        throw;
                                else
                                        return;
                        }
                }
        }
}
