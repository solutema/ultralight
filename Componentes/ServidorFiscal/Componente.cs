#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.Net.Mail;
using System.Windows.Forms;

namespace ServidorFiscal
{
        /// <summary>
        /// Servidor de Impresora Fiscal
        /// </summary>
        public class ServidorFiscal : Lfx.Components.Function
        {
                public Lazaro.Impresion.Comprobantes.Fiscal.Impresora Impresora;
                private int m_PV;
                private System.Timers.Timer Programador;
                private System.Timers.Timer Watchdog;
                private System.DateTime Watchdog_LastOp = System.DateTime.Now;
                private FiscalStatus FormEstado = null;
                public Lazaro.Impresion.Comprobantes.Fiscal.ImpresoraEventArgs UltimoEvento;

                public ServidorFiscal()
                {
                        this.FunctionType = Lfx.Components.FunctionTypes.Loadable;
                }

                public override object Create(bool wait)
                {
                        Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ThreadExceptionHandler);
                        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
                        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                        Lbl.Sys.Config.Actual.UsuarioConectado = new Lbl.Sys.Configuracion.UsuarioConectado(this.Workspace, new Lbl.Personas.Usuario(this.Workspace.MasterConnection, 1));
                        FormEstado = new FiscalStatus();
                        FormEstado.ServidorAsociado = this;
                        this.FormEstado.lblVersion.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;

                        try {
                                System.Diagnostics.Process Yo = System.Diagnostics.Process.GetCurrentProcess();
                                Yo.PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
                        } catch (Exception Ex) {
                                System.Console.WriteLine("ServidorFiscal: Imposible elevar la prioridad del proceso (" + Ex.ToString() + "). Continuando de todos modos.");
                                //Seguramente no me permitió cambiar la prioridad por ser un usuario sin privilegios.
                                //No es crítico, así que continúo sin problema
                        }

                        Impresora = new Lazaro.Impresion.Comprobantes.Fiscal.Impresora(this.Workspace);

                        this.Workspace.RunTime.IpcEvent += new Lfx.RunTimeServices.IpcEventHandler(Workspace_IpcEvent);
                        Impresora.Notificacion += new Lazaro.Impresion.Comprobantes.Fiscal.NotificacionEventHandler(ConFiscal_EventoConexion);

                        Programador = new System.Timers.Timer(1000);
                        Programador.Elapsed += new System.Timers.ElapsedEventHandler(EventoProgramador);
                        Programador.Start();

                        Watchdog = new System.Timers.Timer(60000);
                        Watchdog.Elapsed += new System.Timers.ElapsedEventHandler(EventoWatchdog);
                        Watchdog.Start();

                        if (wait) {
                                while (Impresora.EstadoServidor != Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Apagando
                                        && Impresora.EstadoServidor != Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando) {
                                        System.Threading.Thread.Sleep(100);
                                        System.Windows.Forms.Application.DoEvents();
                                }

                                if (Impresora.EstadoServidor == Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando)
                                        this.End(true);
                                else if (Impresora.EstadoServidor == Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Apagando)
                                        this.End(false);
                        }

                        return null;
                }

                public void ConFiscal_EventoConexion(object sender, Lazaro.Impresion.Comprobantes.Fiscal.ImpresoraEventArgs e)
                {
                        UltimoEvento = e;
                        switch (e.EventType) {
                                case Lazaro.Impresion.Comprobantes.Fiscal.ImpresoraEventArgs.EventTypes.Inicializada:
                                        FormEstado.lblPV.Text = this.PV.ToString();
                                        FormEstado.lblImpresora.Text = Impresora.NombreModelo;
                                        FormEstado.lblConexion.Text = Impresora.PortName + " a " + Impresora.BaudRate.ToString() + " bps";
                                        FormEstado.lblImpresora.Text = Impresora.NombreModelo;
                                        break;
                                case Lazaro.Impresion.Comprobantes.Fiscal.ImpresoraEventArgs.EventTypes.Estado:
                                        FormEstado.lblEstado.Text = e.MensajeEstado;
                                        break;
                                case Lazaro.Impresion.Comprobantes.Fiscal.ImpresoraEventArgs.EventTypes.InicioImpresion:
                                        FormEstado.NotifyIcon1.ShowBalloonTip(1000, "Servidor Fiscal", "Se inició el proceso de impresión", System.Windows.Forms.ToolTipIcon.Info);
                                        break;
                                case Lazaro.Impresion.Comprobantes.Fiscal.ImpresoraEventArgs.EventTypes.FinImpresion:
                                        FormEstado.NotifyIcon1.ShowBalloonTip(1000, "Servidor Fiscal", "Finalizó el proceso de impresión", System.Windows.Forms.ToolTipIcon.Info);
                                        break;
                        }
                }

                public void Workspace_IpcEvent(object sender, ref Lfx.RunTimeServices.IpcEventArgs e)
                {
                        if (e.Destination == "servidorfiscal") {
                                switch (e.Verb) {
                                        case "END":
                                                Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Apagando;
                                                break;

                                        case "REBOOT":
                                                Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando;
                                                break;
                                }
                        }
                }


                private void EventoWatchdog(object source, System.Timers.ElapsedEventArgs e)
                {
                        //Hace un minuto que no se dispara un evento. Reinicio el servidor fiscal.
                        if (System.DateTime.Now > Watchdog_LastOp.AddMinutes(5)) {
                                System.IO.BinaryWriter wr = new System.IO.BinaryWriter(new System.IO.FileStream(Lfx.Environment.Folders.ApplicationDataFolder + "watchdog.log", System.IO.FileMode.Append));
                                wr.Write("ServidorFiscal: REBOOT " + System.DateTime.Now.ToString() + System.Environment.NewLine);
                                wr.Close();

                                Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando;
                        }
                }

                private int PV
                {
                        get
                        {
                                if (m_PV == 0) {
                                        m_PV = this.Impresora.DataBase.FieldInt("SELECT id_pv FROM pvs WHERE UPPER(estacion)='" + System.Environment.MachineName.ToUpperInvariant().ToUpperInvariant() + "' AND tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString());
                                        this.Impresora.PV = m_PV;
                                        this.FormEstado.lblPV.Text = m_PV.ToString();

                                        if (m_PV == 0)
                                                FormEstado.NotifyIcon1.Text = "No hay definido un Punto de Venta para esta estación.";
                                        else
                                                FormEstado.NotifyIcon1.Text = "Utilizando el Punto de Venta " + m_PV.ToString();
                                }
                                return m_PV;
                        }
                }

                private void EventoProgramador(object source, System.Timers.ElapsedEventArgs e)
                {
                        Programador.Stop();
                        Watchdog_LastOp = System.DateTime.Now;

                        //Busco un PV que corresponda a esta terminal
                        if (this.PV == 0) {
                                Programador.Start();
                                return;
                        }

                        Watchdog.Stop();
                        this.Impresora.DataBase.BeginTransaction();
                        qGen.Update Actualizar = new qGen.Update("pvs", new qGen.Where("id_pv", this.PV));
                        Actualizar.Fields.AddWithValue("lsa", qGen.SqlFunctions.Now);
                        this.Impresora.DataBase.Execute(Actualizar);
                        this.Impresora.DataBase.Commit();
                        Lfx.Services.Task ProximaTarea = this.Workspace.DefaultScheduler.GetNextTask("fiscal" + this.PV.ToString());
                        if (ProximaTarea != null) {
                                string Comando = ProximaTarea.Command;
                                string SubComando = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();

                                Lazaro.Impresion.Comprobantes.Fiscal.Respuesta Res;
                                switch (SubComando) {
                                        case "REBOOT":
                                                Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Reiniciando;
                                                //this.End(true);
                                                break;

                                        case "END":
                                                Impresora.EstadoServidor = Lazaro.Impresion.Comprobantes.Fiscal.EstadoServidorFiscal.Apagando;
                                                //this.End(false);
                                                break;

                                        case "CIERRE":
                                                Res = Impresora.ObtenerEstadoImpresora();
                                                if (Res.EstadoFiscal.DocumentoFiscalAbierto) {
                                                        Res = Impresora.CancelarDocumentoFiscal();
                                                        System.Threading.Thread.Sleep(500);
                                                } else if (Res.Error == Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Ok) {
                                                        string SubComandoCierre = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                                        Lazaro.Impresion.Comprobantes.Fiscal.Respuesta ResultadoCierre = Impresora.Cierre(SubComandoCierre, true);
                                                        if (SubComandoCierre == "Z" && ResultadoCierre.Error == Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Ok) {
                                                                //Si hizo un cierre Z correctamente, actualizo la variable LCZ
                                                                Actualizar = new qGen.Update("pvs", new qGen.Where("id_pv", this.PV));
                                                                Actualizar.Fields.AddWithValue("ultimoz", qGen.SqlFunctions.Now);
                                                                this.Impresora.DataBase.Execute(Actualizar);
                                                        }
                                                        if (ResultadoCierre.Error != Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Ok) {
                                                                MostrarErrorFiscal(ResultadoCierre);
                                                        }
                                                        System.Threading.Thread.Sleep(100);
                                                }
                                                break;

                                        case "CANCELAR":
                                                string ItemCancelar = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
                                                switch (ItemCancelar) {
                                                        case "FISCAL":
                                                                Impresora.CancelarDocumentoFiscal();
                                                                System.Threading.Thread.Sleep(500);
                                                                break;
                                                }
                                                break;

                                        case "IMPRIMIR":
                                                int IdFactura = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim());
                                                Res = Impresora.ObtenerEstadoImpresora();

                                                if (Res.EstadoFiscal.DocumentoFiscalAbierto) {
                                                        Res = Impresora.CancelarDocumentoFiscal();
                                                        System.Threading.Thread.Sleep(500);
                                                }

                                                if (Res.HacerCierreZ) {
                                                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Hacer Cierre Z", "Es obligatorio hacer un Cierre Z antes de continuar. ¿Desea hacer el cierre ahora?");
                                                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;

                                                        if (Pregunta.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                                                // Hago el cierre, y Res es el resultado del cierre
                                                                Res = Impresora.Cierre("Z", true);
                                                                System.Threading.Thread.Sleep(500);
                                                        } else {
                                                                // No quiso hacer el cierre. Devuelvo un error
                                                                Programador.Start();
                                                                Watchdog.Start();
                                                                return;
                                                        }
                                                }

                                                if (Res.Error == Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Ok)
                                                        Res = Impresora.ImprimirComprobante(IdFactura);

                                                if (Res.Error != Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Ok) {
                                                        MostrarErrorFiscal(Res);
                                                        if (Res.EstadoFiscal.DocumentoFiscalAbierto)
                                                                Res = Impresora.CancelarDocumentoFiscal();
                                                        Programador.Start();
                                                        Watchdog.Start();
                                                        return;
                                                }
                                                break;
                                }
                        }
                        Programador.Start();
                        Watchdog.Start();
                }

                private void MostrarErrorFiscal(Lazaro.Impresion.Comprobantes.Fiscal.Respuesta Res)
                {
                        FormFiscalError OFormFiscalError = new FormFiscalError();
                        OFormFiscalError.Mostrar(Res);
                        OFormFiscalError.ShowDialog();
                }

                public void End(bool reboot)
                {
                        Programador.Stop();

                        if (this.PV != 0) {
                                qGen.Update Actualizar = new qGen.Update("pvs", new qGen.Where("id_pv", this.PV));
                                Actualizar.Fields.AddWithValue("lsa", null);
                                this.Impresora.DataBase.Execute(Actualizar);
                        }

                        Impresora.Terminar();
                        FormEstado.Close();

                        if (reboot) {
                                string[] ParametrosAPasar = this.CommandLineArgs;
                                ParametrosAPasar[0] = "";
                                string Params = string.Join(" ", ParametrosAPasar).Trim();

                                Lfx.Environment.Shell.Execute(this.ExecutableName, Params, System.Diagnostics.ProcessWindowStyle.Minimized, false);
                        }
                        System.Windows.Forms.Application.Exit();
                }

                public static void ThreadExceptionHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
                {
                        UnknownExceptionHandler(e.Exception);
                }

                private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
                {
                        UnknownExceptionHandler(args.ExceptionObject as Exception);
                        Application.Exit();
                }

                /// <summary>
                /// Manejador de excepciones desconocidas. Presenta una ventana con el error y envía un informe por correo electrónico.
                /// </summary>
                /// <param name="ex">La excepción a reportar.</param>
                public static void UnknownExceptionHandler(Exception ex)
                {
                        try {
                                System.Text.StringBuilder Texto = new System.Text.StringBuilder();
                                Texto.AppendLine("Lugar   : " + ex.Source);
                                try {
                                        System.Diagnostics.StackTrace Traza = new System.Diagnostics.StackTrace(ex, true);
                                        Texto.AppendLine("Línea   : " + Traza.GetFrame(0).GetFileLineNumber());
                                        Texto.AppendLine("Columna : " + Traza.GetFrame(0).GetFileColumnNumber());
                                } catch {
                                        //Nada
                                }
                                Texto.AppendLine("Equipo  : " + System.Environment.MachineName.ToUpperInvariant());
                                Texto.AppendLine("Plataf. : " + Lfx.Environment.SystemInformation.PlatformName);
                                Texto.AppendLine("RunTime : " + Lfx.Environment.SystemInformation.RuntimeName);
                                Texto.AppendLine("Excepción no controlada: " + ex.ToString());
                                Texto.AppendLine("");

                                Texto.AppendLine("Lazaro versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").ProductVersion + " del " + new System.IO.FileInfo(Lfx.Environment.Folders.ApplicationFolder + "Lazaro.exe").LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                                System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ApplicationFolder);
                                foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                        Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                                }

                                Dir = new System.IO.DirectoryInfo(Lfx.Environment.Folders.ComponentsFolder);
                                foreach (System.IO.FileInfo DirItem in Dir.GetFiles("*.dll")) {
                                        Texto.AppendLine(DirItem.Name + " versión " + System.Diagnostics.FileVersionInfo.GetVersionInfo(DirItem.FullName).ProductVersion + " del " + new System.IO.FileInfo(DirItem.FullName).LastWriteTime.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern));
                                }

                                Texto.AppendLine("Traza:");
                                Texto.AppendLine(ex.StackTrace);

                                MailMessage Mensaje = new MailMessage();
                                Mensaje.To.Add(new MailAddress("error@sistemalazaro.com.ar"));
                                Mensaje.From = new MailAddress(Lbl.Sys.Config.Actual.Empresa.Email, Lbl.Sys.Config.Actual.UsuarioConectado.Nombre + " en " + Lbl.Sys.Config.Actual.Empresa.Nombre);
                                try {
                                        //No sé por qué, pero una vez dió un error al poner el asunto
                                        Mensaje.Subject = ex.Message;
                                } catch {
                                        Mensaje.Subject = "Excepción no controlada";
                                        Texto.Insert(0, ex.Message + System.Environment.NewLine);
                                }

                                Mensaje.Body = Texto.ToString();

                                SmtpClient Cliente = new SmtpClient("mail.sistemalazaro.com.ar");
                                Cliente.Send(Mensaje);
                        } catch () {
                                // No pude enviar el reporte. No importa.
                        }
                }
        }
}