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

namespace ServidorFiscal
{
	/// <summary>
	/// Servidor de Impresora Fiscal
	/// </summary>
	public class ServidorFiscal : Lws.Components.Component
	{
		public Lbl.Comprobantes.Impresion.Fiscal.ConexionImpresora ConFiscal;
		private int m_PV;
		private System.Timers.Timer Programador;
		private System.Timers.Timer Watchdog;
		private System.DateTime Watchdog_LastOp = System.DateTime.Now;
		private FiscalStatus FormEstado = null;
		public Lbl.Comprobantes.Impresion.Fiscal.ConexionEventArgs UltimoEvento;

		public override object Create(bool wait)
		{
                        this.Workspace.CurrentUser.UserId = 1;
			FormEstado = new FiscalStatus();
			FormEstado.Workspace = this.Workspace;
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

			ConFiscal = new Lbl.Comprobantes.Impresion.Fiscal.ConexionImpresora(this.Workspace);

			this.Workspace.RunTime.IpcEvent += new Lws.Workspace.RunTimeServices.IpcEventHandler(Workspace_IpcEvent);
			ConFiscal.EventoConexion += new Lbl.Comprobantes.Impresion.Fiscal.ConexionImpresora.ManejadorEventoConexion(ConFiscal_EventoConexion);

			Programador = new System.Timers.Timer(1000);
			Programador.Elapsed += new System.Timers.ElapsedEventHandler(EventoProgramador);
			Programador.Start();

			Watchdog = new System.Timers.Timer(60000);
			Watchdog.Elapsed += new System.Timers.ElapsedEventHandler(EventoWatchdog);
			Watchdog.Start();

			if (wait)
			{
				while (ConFiscal.EstadoServidor != Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Apagando
					&& ConFiscal.EstadoServidor != Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Reiniciando)
				{
					System.Threading.Thread.Sleep(100);
					System.Windows.Forms.Application.DoEvents();
				}

				if (ConFiscal.EstadoServidor == Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Reiniciando)
					this.End(true);
				else if (ConFiscal.EstadoServidor == Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Apagando)
					this.End(false);
			}

			return null;
		}

		public void ConFiscal_EventoConexion(object sender, Lbl.Comprobantes.Impresion.Fiscal.ConexionEventArgs e)
		{
			UltimoEvento = e;
			switch (e.EventType)
			{
				case Lbl.Comprobantes.Impresion.Fiscal.ConexionEventArgs.EventTypes.Inicializada:
					FormEstado.lblPV.Text = this.PV.ToString();
					FormEstado.lblImpresora.Text = ConFiscal.ModelName;
					FormEstado.lblConexion.Text = ConFiscal.PortName + " a " + ConFiscal.BaudRate.ToString() + " bps";
					FormEstado.lblImpresora.Text = ConFiscal.ModelName;
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ConexionEventArgs.EventTypes.Estado:
					FormEstado.lblEstado.Text = e.MensajeEstado;
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ConexionEventArgs.EventTypes.InicioImpresion:
					FormEstado.NotifyIcon1.ShowBalloonTip(1000, "Servidor Fiscal", "Se inició el proceso de impresión", System.Windows.Forms.ToolTipIcon.Info);
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ConexionEventArgs.EventTypes.FinImpresion:
					FormEstado.NotifyIcon1.ShowBalloonTip(1000, "Servidor Fiscal", "Finalizó el proceso de impresión", System.Windows.Forms.ToolTipIcon.Info);
					break;
			}
		}

		public void Workspace_IpcEvent(object sender, ref Lws.Workspace.RunTimeServices.IpcEventArgs e)
		{
			if (e.Destination == "servidorfiscal" && e.Verb == "END")
				ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Apagando;
			else if (e.Destination == "servidorfiscal" && e.Verb == "REBOOT")
				ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Reiniciando;
		}

		public override Lws.Components.ComponentTypes ComponentType
		{
			get
			{
				return Lws.Components.ComponentTypes.Loadable;
			}
		}

		private void EventoWatchdog(object source, System.Timers.ElapsedEventArgs e)
		{
			//Hace un minuto que no se dispara un evento. Reinicio el servidor fiscal.
			if (System.DateTime.Now > Watchdog_LastOp.AddMinutes(5))
			{
				System.IO.BinaryWriter wr = new System.IO.BinaryWriter(new System.IO.FileStream(Lfx.Environment.Folders.ApplicationDataFolder + "watchdog.log", System.IO.FileMode.Append));
				wr.Write("ServidorFiscal: REBOOT " + System.DateTime.Now.ToString() + System.Environment.NewLine);
				wr.Close();

				ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Reiniciando;
			}
		}

		private int PV
		{
			get
			{
				if (m_PV == 0)
				{
					m_PV = this.Workspace.DefaultDataBase.FieldInt("SELECT id_pv FROM pvs WHERE UPPER(estacion)='" + System.Environment.MachineName.ToUpperInvariant().ToUpperInvariant() + "' AND tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Company.CurrentBranch.ToString());
					this.ConFiscal.PV = m_PV;
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
			if (this.PV == 0)
			{
				Programador.Start();
				return;
			}

			Watchdog.Stop();
                        Lfx.Data.SqlUpdateBuilder Actualizar = new Lfx.Data.SqlUpdateBuilder(m_Workspace.DefaultDataBase, "pvs", new Lfx.Data.SqlWhereBuilder("id_pv", this.PV));
                        Actualizar.Fields.AddWithValue("lsa", Lfx.Data.SqlFunctions.Now);
                        m_Workspace.DefaultDataView.Execute(Actualizar);
			Lws.Services.Task ProximaTarea = m_Workspace.DefaultScheduler.GetNextTask("fiscal" + this.PV.ToString());
			if (ProximaTarea != null)
			{
				string Comando = ProximaTarea.Command;
				string SubComando = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();

				Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res;
				switch (SubComando)
				{
					case "REBOOT":
						ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Reiniciando;
						//this.End(true);
						break;

					case "END":
						ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Apagando;
						//this.End(false);
						break;

					case "CIERRE":
						Res = ConFiscal.ObtenerEstadoImpresora();
						if (Res.EstadoFiscal.DocumentoFiscalAbierto)
						{
							Res = ConFiscal.CancelarDocumentoFiscal();
							System.Threading.Thread.Sleep(500);
						}
						else if (Res.Error == Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Ok)
						{
							string SubComandoCierre = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
							Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal ResultadoCierre = ConFiscal.Cierre(SubComandoCierre, true);
							if (SubComandoCierre == "Z" && ResultadoCierre.Error == Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Ok)
							{
								//Si hizo un cierre Z correctamente, actualizo la variable LCZ
                                                                Actualizar = new Lfx.Data.SqlUpdateBuilder(m_Workspace.DefaultDataBase, "pvs", new Lfx.Data.SqlWhereBuilder("id_pv", this.PV));
                                                                Actualizar.Fields.AddWithValue("ultimoz", Lfx.Data.SqlFunctions.Now);
                                                                m_Workspace.DefaultDataView.Execute(Actualizar);
							}
							if (ResultadoCierre.Error != Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Ok)
							{
								MostrarErrorFiscal(ResultadoCierre);
							}
							System.Threading.Thread.Sleep(100);
						}
						break;

					case "CANCELAR":
						string ItemCancelar = Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim().ToUpper();
						switch (ItemCancelar)
						{
							case "FISCAL":
								ConFiscal.CancelarDocumentoFiscal();
								System.Threading.Thread.Sleep(500);
								break;
						}
						break;

					case "IMPRIMIR":
						int IdFactura = Lfx.Types.Parsing.ParseInt(Lfx.Types.Strings.GetNextToken(ref Comando, " ").Trim());
						Res = ConFiscal.ObtenerEstadoImpresora();

						if (Res.EstadoFiscal.DocumentoFiscalAbierto)
						{
							Res = ConFiscal.CancelarDocumentoFiscal();
							System.Threading.Thread.Sleep(500);
						}

						if (Res.HacerCierreZ)
						{
							Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Hacer Cierre Z", "Es obligatorio hacer un Cierre Z antes de continuar. ¿Desea hacer el cierre ahora?");
							Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;

							if (Pregunta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
							{
								// Hago el cierre, y Res es el resultado del cierre
								Res = ConFiscal.Cierre("Z", true);
								System.Threading.Thread.Sleep(500);
							}
							else
							{
								// No quiso hacer el cierre. Devuelvo un error
								Programador.Start();
								Watchdog.Start();
								return;
							}
						}

						if (Res.Error == Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Ok)
							Res = ConFiscal.ImprimirComprobante(IdFactura);

						if (Res.Error != Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Ok)
						{
							MostrarErrorFiscal(Res);
							if (Res.EstadoFiscal.DocumentoFiscalAbierto)
								Res = ConFiscal.CancelarDocumentoFiscal();
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

		private void MostrarErrorFiscal(Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res)
		{
			FormFiscalError OFormFiscalError = new FormFiscalError();
			OFormFiscalError.Mostrar(Res);
			OFormFiscalError.ShowDialog();
		}

		public void End(bool reboot)
		{
			Programador.Stop();
                        if (this.PV != 0) {
                                Lfx.Data.SqlUpdateBuilder Actualizar = new Lfx.Data.SqlUpdateBuilder(m_Workspace.DefaultDataBase, "pvs", new Lfx.Data.SqlWhereBuilder("id_pv", this.PV));
                                Actualizar.Fields.AddWithValue("lsa", null);
                                m_Workspace.DefaultDataView.Execute(Actualizar);
                        }

			ConFiscal.Terminar();
			FormEstado.Close();

			if (reboot)
			{
				string[] ParametrosAPasar = this.CommandLineArgs;
				ParametrosAPasar[0] = "";
				string Params = string.Join(" ", ParametrosAPasar).Trim();

				Lfx.Environment.Shell.Execute(this.ExecutableName, Params, System.Diagnostics.ProcessWindowStyle.Minimized, false);
			}
			System.Windows.Forms.Application.Exit();
		}
	}
}