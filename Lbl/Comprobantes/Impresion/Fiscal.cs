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

namespace Lbl.Comprobantes.Impresion.Fiscal
{
	/// <summary>
	/// Impresión mediante controlador fiscal.
	/// </summary>
	/// 
	public enum Modelos
	{
		Desconocido = 0,
		Emulacion = 1,
		HasarGenerico = 100,
		EpsonGenerico = 300
	}

	static class CaracteresDeControl
	{
		public const char PROTO_STX = (char)0x02;
                public const char PROTO_FS = (char)0x1C;
                public const char PROTO_ETX = (char)0x03;
                public const char PROTO_DC2 = (char)0x12;
                public const char PROTO_DC4 = (char)0x14;
                public const char PROTO_ACK = (char)0x06;
                public const char PROTO_NAK = (char)0x15;
	}

	public enum EstadoServidorFiscal
	{
		Esperando = 0,
		Imprimiendo = 1,
		Apagando = 3,
		Reiniciando = 4,
		Error = 5
	}

	public enum ErroresFiscales
	{
		Ok = 0,
		Error = 1,
		ErrorImpresora = 2,
		ErrorFiscal = 3,
		TimeOut = 10,
		NAK = 11,
		ErrorBCC = 12,
		ErrorComunicacion,
	}

	public enum CodigosComandosFiscales
	{
		Ninguno = 0,
		Escape = 0X1B,

		/* Comandos EPSON */
		EpsonNada = 0,
		EpsonSolicitudEstado = 0X2A,
		EpsonCierreJornada = 0X39,

		EpsonReporteMemoriaPorFecha = 0X3A,
		EpsonReporteMemoriaPorCierre = 0X3B,
		EpsonReporteTransporte = 0X5C,

		EpsonDocumentoNoFiscalPonerPreferencias = 0X5A,
		EpsonDocumentoNoFiscalLeerPreferencias = 0X5B,
		EpsonDocumentoNoFiscalAbrir = 0X48,
		EpsonDocumentoNoFiscalImprimir = 0X49,
		EpsonDocumentoNoFiscalCerrar = 0X4A,
		EpsonAvanzarHoja = 0X53,
		EpsonExpulsarHoja = 0X4B,

		EpsonPonerFechaYHora = 0X58,
		EpsonLeerFechaYHora = 0X59,

		EpsonPonerDatosFijos = 0X5D,
		EpsonLeerDatosFijos = 0X5E,
		EpsonPonerZonasDeImpresion = 0X5A,
		EpsonPonerZonasDeImpresionOffset = 0X5C,
		EpsonLeerZonasDeImpresion = 0X5B,

		EpsonBorrarZonasDeImpresion = 0X5C,
		EpsonBorrarPreferencias = 0X5C,

		EpsonDocumentoFiscalAbrir = 0X60,
		EpsonDocumentoFiscalItem = 0X62,
		EpsonDocumentoFiscalSubtotal = 0X63,
		EpsonDocumentoFiscalPagosYDescuentos = 0X64,
		EpsonDocumentoFiscalCerrar = 0X65,

		/* Comandos HASAR */
		HasarSolicitudEstado = 0X2A,
		HasarCierreJornada = 0X39,

		HasarDocumentoFiscalAbrir = 0X40,
		HasarDocumentoSetDatosCliente = 0X62,
		HasarDocumentoFiscalItem = 0X42,
		HasarDocumentoFiscalDescuentoGeneral = 0X54,
		HasarDocumentoFiscalDevolucionesYRecargos = 0X6D,
		HasarDocumentoFiscalPago = 0X44,
		HasarDocumentoFiscalCerrar = 0X45,
		HasarDocumentoFiscalCancelar = 0X98,
	}

	public class ComandoFiscal
	{
		public CodigosComandosFiscales CodigoComando;
		public int Secuencia;
		public string[] Campos;
		private System.Text.Encoding DefaultEncoding = System.Text.Encoding.GetEncoding(1252);

		public ComandoFiscal(CodigosComandosFiscales codigoComando, params string[] campos)
		{
			CodigoComando = codigoComando;
			Campos = campos;
		}

		public string ProtocoloBinario()
		{
			System.Text.StringBuilder Comando = new System.Text.StringBuilder();
			Comando.Append(CaracteresDeControl.PROTO_STX);      // STX Start of Frame

			Comando.Append((char)Secuencia); // SN Sequence Number


			byte[] cmd = new byte[1] { (byte)CodigoComando };
			Comando.Append(DefaultEncoding.GetChars(cmd)); // Comando

			if (Campos != null && Campos.Length > 0)
			{
				// Params
				foreach (string Param in Campos)
				{
					Comando.Append(CaracteresDeControl.PROTO_FS); // FS Field Separator
					Comando.Append(Param);
				}
			}

			Comando.Append(CaracteresDeControl.PROTO_ETX);	// ETX End of Frame

			//Calculo el BCC
			long BCC = 0;
			byte[] ComandoBytes = DefaultEncoding.GetBytes(Comando.ToString());
			for (int n = 0; n < ComandoBytes.Length; n++)
			{
				BCC += ComandoBytes[n];
			}
			Comando.Append(System.Convert.ToString(BCC, 16).ToUpper().PadLeft(4, '0'));

			return Comando.ToString();
		}

		public override string ToString()
		{
			string Res = "<Enviar" + System.Environment.NewLine;
			Res += "  comando=" + this.CodigoComando.ToString() + System.Environment.NewLine;
			Res += "  secuencia=" + this.Secuencia.ToString() + System.Environment.NewLine;
			for (int i = 0; i < Campos.Length; i++)
			{
				Res += "  campo_" + i.ToString() + "=" + this.Campos[i].ToString() + System.Environment.NewLine;
			}
			Res += "/>" + System.Environment.NewLine;
			return Res;
		}
	}

	public class RespuestaFiscal
	{
		public Modelos ModeloImpresora;
		public ErroresFiscales Error;
		public string Lugar;
		public bool HacerCierreZ;
		public string Mensaje;
		public CodigosComandosFiscales CodigoComando;
		public int Secuencia;
		public string ProtocoloBinario;

		public class EstadosAuxiliares
		{
			public long CodigoEstado;
		}

		public class EstadosImpresora
		{
			public long CodigoEstado;

			public bool Bit(int bitNumber)
			{
				return (CodigoEstado & (long)Math.Pow(2, bitNumber)) != 0;
			}
			public bool BanderaDeError
			{
				get
				{
					return this.Bit(15);
				}
			}
		}
		public EstadosImpresora EstadoImpresora = new EstadosImpresora();

		public class EstadosFiscales
		{
			public long CodigoEstado;

			public bool Bit(int bitNumber)
			{
				return (CodigoEstado & (long)Math.Pow(2, bitNumber)) != 0;
			}
			public bool DocumentoFiscalAbierto
			{
				get
				{
					return this.Bit(12);
				}
			}
			public bool HacerCierreZ
			{
				get
				{
					return this.Bit(15);
				}
			}
		}
		public EstadosFiscales EstadoFiscal = new EstadosFiscales();

		public System.Collections.ArrayList Campos;

		public RespuestaFiscal()
			: this(ErroresFiscales.Ok)
		{
		}
		public RespuestaFiscal(ErroresFiscales codigoError)
		{
			this.Error = codigoError;
			this.Campos = null;
			this.CodigoComando = CodigosComandosFiscales.Ninguno;
			this.EstadoFiscal.CodigoEstado = 0;
			this.EstadoImpresora.CodigoEstado = 0;
			this.HacerCierreZ = false;
			this.Lugar = "";
			this.Mensaje = "";
			this.Secuencia = 0;
		}

		public int NumeroComprobante
		{
			get
			{
				if (Campos.Count >= 3)
					return System.Convert.ToInt32(Campos[2]);
				else
					return 0;
			}
		}

		public override string ToString()
		{
			string Res = "<Respuesta" + System.Environment.NewLine;
			Res += "  comando=" + this.CodigoComando.ToString() + System.Environment.NewLine;
			Res += "  secuencia=" + this.Secuencia.ToString() + System.Environment.NewLine;
			for (int i = 0; i < Campos.Count; i++)
			{
				Res += "  campo_" + i.ToString() + "=" + this.Campos[i].ToString() + System.Environment.NewLine;
			}
			Res += "  estado_fiscal=" + this.ExplicarEstadoFiscal() + System.Environment.NewLine;
			Res += "  estado_impresora=" + this.ExplicarEstadoImpresora() + System.Environment.NewLine;
			Res += "/>" + System.Environment.NewLine;
			return Res;
		}

		public string ExplicarEstadoImpresora()
		{
			string Estado = "0x" + System.Convert.ToString(EstadoImpresora.CodigoEstado, 16).PadLeft(4, '0') + ":";

			if (Bit(EstadoImpresora.CodigoEstado, 0))
				Estado += "Bit 0;";

			if (Bit(EstadoImpresora.CodigoEstado, 1))
				Estado += "Bit 1;";

			if (Bit(EstadoImpresora.CodigoEstado, 2))
				Estado += "Bit 2: Falla en la impresora;";

			if (Bit(EstadoImpresora.CodigoEstado, 3))
				Estado += "Bit 3: Fuera de línea;";

			if (Bit(EstadoImpresora.CodigoEstado, 4))
				Estado += "Bit 4;";

			if (Bit(EstadoImpresora.CodigoEstado, 5))
				Estado += "Bit 5;";

			if (Bit(EstadoImpresora.CodigoEstado, 6))
				Estado += "Bit 6: Búfer lleno;";

			if (Bit(EstadoImpresora.CodigoEstado, 7))
				Estado += "Bit 7: Búfer vacío;";

			if (Bit(EstadoImpresora.CodigoEstado, 8))
				Estado += "Bit 8: Entrada frontal de papel preparada;";

			if (Bit(EstadoImpresora.CodigoEstado, 9))
				Estado += "Bit 9: Hoja suelta frontal separada;";

			if (Bit(EstadoImpresora.CodigoEstado, 10))
				Estado += "Bit 10;";

			if (Bit(EstadoImpresora.CodigoEstado, 11))
				Estado += "Bit 11;";

			if (Bit(EstadoImpresora.CodigoEstado, 12))
				Estado += "Bit 12;";

			if (Bit(EstadoImpresora.CodigoEstado, 13))
				Estado += "Bit 13;";

			switch (ModeloImpresora)
			{
				case Modelos.EpsonGenerico:
				case Modelos.Emulacion:
					if (Bit(EstadoImpresora.CodigoEstado, 14))
						Estado += "Bit 14: Sin papel;";
					break;
				case Modelos.HasarGenerico:
					if (Bit(EstadoImpresora.CodigoEstado, 14))
						Estado += "Bit 14: Cajón de dinero cerrado o ausente;";
					break;
			}

			if (Bit(EstadoImpresora.CodigoEstado, 15))
				Estado += "Bit 15: Bandera de error;";

			return Estado;
		}

		public string ExplicarEstadoFiscal()
		{
			string Estado = "0x" + System.Convert.ToString(EstadoFiscal.CodigoEstado, 16).PadLeft(4, '0') + ":";
			if (Bit(EstadoFiscal.CodigoEstado, 0))
				Estado += "Bit 0: Error de memoria fiscal;";

			if (Bit(EstadoFiscal.CodigoEstado, 1))
				Estado += "Bit 1: Error de memoria de trabajo;";

			if (Bit(EstadoFiscal.CodigoEstado, 2))
				Estado += "Bit 2: Batería baja;";

			if (Bit(EstadoFiscal.CodigoEstado, 3))
				Estado += "Bit 3: Comando no reconocido;";

			if (Bit(EstadoFiscal.CodigoEstado, 4))
				Estado += "Bit 4: Campo de datos no válido;";

			if (Bit(EstadoFiscal.CodigoEstado, 5))
				Estado += "Bit 5: Comando no válido en este estado;";

			if (Bit(EstadoFiscal.CodigoEstado, 6) & Bit(EstadoFiscal.CodigoEstado, 11))
				Estado += "Bits 6 y 11: Es necesario hacer un transporte de hoja;";
			else if (Bit(EstadoFiscal.CodigoEstado, 6))
				Estado += "Bit 6: Desbordamiento;";

			if (Bit(EstadoFiscal.CodigoEstado, 7))
				Estado += "Bit 7: Memoria fiscal llena;";

			if (Bit(EstadoFiscal.CodigoEstado, 8))
				Estado += "Bit 8: Memoria fiscal casi llena;";

			if (Bit(EstadoFiscal.CodigoEstado, 9) & Bit(EstadoFiscal.CodigoEstado, 10))
				Estado += "Bits 9 y 10: Controlador fiscalizado;";
			else if (Bit(EstadoFiscal.CodigoEstado, 9) & Bit(EstadoFiscal.CodigoEstado, 10) == false)
				Estado += "Bit 9: Impresor fiscal certificado;";
			else if (Bit(EstadoFiscal.CodigoEstado, 9) == false & Bit(EstadoFiscal.CodigoEstado, 10))
				Estado += "Bit 10: Impresora desfiscalizada por software;";

			if (Bit(EstadoFiscal.CodigoEstado, 11))
				Estado += "Bit 11: Es necesario un cierre de jornada;";

			if (Bit(EstadoFiscal.CodigoEstado, 12))
				Estado += "Bit 12: Documento fiscal abierto;";

			if (Bit(EstadoFiscal.CodigoEstado, 13))
				Estado += "Bit 13: Documento fiscal abierto por rollo de papel;";

			if (Bit(EstadoFiscal.CodigoEstado, 14))
				Estado += "Bit 14: Factura o impresión en hoja suelta inicializada;";

			if (Bit(EstadoFiscal.CodigoEstado, 15))
				Estado += "Bit 15;";

			return Estado;
		}

		private static bool Bit(long numero, int fiscalBit)
		{
			long ValorBit = System.Convert.ToInt64(Math.Pow(2, fiscalBit));
			return (numero & ValorBit) == ValorBit;
		}

	}

	//Sistema de eventos
	public class ConexionEventArgs : System.EventArgs
	{
		public enum EventTypes
		{
			Inicializada,
			InicioImpresion,
			FinImpresion,
			Estado,
			Error
		}

		public EventTypes EventType = EventTypes.Estado;
		public EstadoServidorFiscal Estado;
		public string MensajeEstado;
		public ErroresFiscales ErrorFiscal;

		public ConexionEventArgs() { }
		public ConexionEventArgs(EventTypes eventType)
		{
			EventType = eventType;
		}
		public ConexionEventArgs(string mensajeEstado)
		{
			this.EventType = EventTypes.Estado;
			MensajeEstado = mensajeEstado;
		}
		public ConexionEventArgs(ErroresFiscales errorFiscal)
		{
			this.EventType = EventTypes.Error;
			ErrorFiscal = errorFiscal;
		}
	}

	public class ConexionImpresora
	{
		public Lbl.Comprobantes.Impresion.Fiscal.Modelos ModeloImpresora = Lbl.Comprobantes.Impresion.Fiscal.Modelos.Desconocido;
		private int m_PV = 0;
		private System.Text.Encoding DefaultEncoding = System.Text.Encoding.GetEncoding(1252);

		private const int FIRST_SEQ = 0x20;
		private int SeqNum;
		private System.IO.Ports.SerialPort Impresora = new System.IO.Ports.SerialPort();
		private Lws.Workspace m_Workspace;
		private EstadoServidorFiscal m_EstadoServidor = EstadoServidorFiscal.Esperando;
		private System.Text.StringBuilder m_TextEmulacion;
		private Lws.Data.DataView DataView;

		public delegate void ManejadorEventoConexion(object sender, ConexionEventArgs e);
		public event ManejadorEventoConexion EventoConexion;

		public ConexionImpresora(Lws.Workspace workspace)
		{
			this.Workspace = workspace;
			this.DataView = workspace.GetDataView(true);
			m_EstadoServidor = EstadoServidorFiscal.Esperando;
		}

		~ConexionImpresora()
		{
			this.Terminar();
		}

		public int PV
		{
			get
			{
				return this.m_PV;
			}
			set
			{
				this.m_PV = value;
				if (this.m_PV > 0)
				{
					Lfx.Data.Row PVrow = this.DataView.DataBase.Row("pvs", "id_pv", this.m_PV);
					if (this.Impresora.IsOpen)
					{
						this.Impresora.Close();
						System.Threading.Thread.Sleep(100);
					}

					this.ModeloImpresora = (Lbl.Comprobantes.Impresion.Fiscal.Modelos)System.Convert.ToInt32(PVrow["modelo"]);
					this.Impresora.PortName = "COM" + System.Convert.ToString(PVrow["puerto"]);
					this.Impresora.BaudRate = System.Convert.ToInt32(PVrow["bps"]);
				}
			}
		}

		public string ModelName
		{
			get
			{
				switch (this.ModeloImpresora)
				{
					case Modelos.EpsonGenerico:
						return "Epson Genérico";
					case Modelos.HasarGenerico:
						return "Hasar Genérico";
					case Modelos.Emulacion:
						return "Emulación";
					default:
						return "Desconocido";
				}
			}
		}

		public void Terminar()
		{
			this.Cerrar();
		}

		public void Cerrar()
		{
			switch (ModeloImpresora)
			{
				case Modelos.Emulacion:
					m_TextEmulacion = null;
					break;
				default:
					if (Impresora != null && Impresora.IsOpen)
						Impresora.Close();
					break;
			}
		}

		public Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Inicializar()
		{
			switch (ModeloImpresora)
			{
				case Modelos.Emulacion:
					if (m_TextEmulacion == null)
					{
						m_TextEmulacion = new System.Text.StringBuilder("Emulación iniciada" + System.Environment.NewLine);
						if (EventoConexion != null)
							EventoConexion(this, new ConexionEventArgs(ConexionEventArgs.EventTypes.Inicializada));
					}
					break;
				default:
					if (Impresora.IsOpen == false)
					{
						Impresora.ReadTimeout = 8000;
						Impresora.WriteTimeout = 5000;
						Impresora.DataBits = 8;
						Impresora.StopBits = System.IO.Ports.StopBits.One;
						Impresora.Parity = System.IO.Ports.Parity.None;
						Impresora.Encoding = DefaultEncoding;
						SeqNum = FIRST_SEQ;

                                                if (ModeloImpresora != Modelos.HasarGenerico) {
                                                        Impresora.Handshake = System.IO.Ports.Handshake.XOnXOff;
                                                        Impresora.RtsEnable = true;
                                                }

						try
						{
							Impresora.Open();
						}
						catch (Exception ex)
						{
							RespuestaFiscal Res = new RespuestaFiscal(ErroresFiscales.Error);
							Res.Lugar = "Fiscal.ConexionImpresora.Inicializar()";
							Res.Mensaje = ex.ToString();
							return Res;
						}

						Impresora.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(Impresora_PinChanged);
						Impresora.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(Impresora_ErrorReceived);

						if (ModeloImpresora == Modelos.HasarGenerico)
						{
							System.Threading.Thread.Sleep(100);
							//Configuración inicial Hasar
							Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res = ObtenerEstadoImpresora();

							if (Res.EstadoFiscal.DocumentoFiscalAbierto)
								Res = CancelarDocumentoFiscal();
						}

						if (EventoConexion != null)
							EventoConexion(this, new ConexionEventArgs(ConexionEventArgs.EventTypes.Inicializada));
					}
					break;
			}

			return new RespuestaFiscal(ErroresFiscales.Ok);
		}

		void Impresora_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
		{
			System.Threading.Thread.Sleep(40);
		}

		void Impresora_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
		{
			System.Threading.Thread.Sleep(40);
		}

		public EstadoServidorFiscal EstadoServidor
		{
			get
			{
				return m_EstadoServidor;
			}
			set
			{
				m_EstadoServidor = value;
			}
		}

		public string PortName
		{
			get
			{
				return Impresora.PortName;
			}
		}

		public int BaudRate
		{
			get
			{
				return Impresora.BaudRate;
			}
		}

		public Lws.Workspace Workspace
		{
			get
			{
				return m_Workspace;
			}
			set
			{
				m_Workspace = value;
			}
		}

		public Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Cierre(string Tipo, bool Imprimir)
		{
			switch (ModeloImpresora)
			{
				case Modelos.EpsonGenerico:
				case Modelos.Emulacion:
					string ParametroImprimir = "N";

					if (Imprimir)
						ParametroImprimir = "P";

					return Enviar(new ComandoFiscal(CodigosComandosFiscales.EpsonCierreJornada, Tipo, ParametroImprimir));
				case Modelos.HasarGenerico:
					return Enviar(new ComandoFiscal(CodigosComandosFiscales.HasarCierreJornada, Tipo));
			}

			return new Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal(ErroresFiscales.Error);
		}

		public Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal CancelarDocumentoFiscal()
		{
			switch (ModeloImpresora)
			{
				case Modelos.EpsonGenerico:
				case Modelos.Emulacion:
					return Enviar(new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos, "Cancelando", "000010000", "C"));
				case Modelos.HasarGenerico:
					return Enviar(new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalCancelar));
			}

			return new Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal();
		}

                public Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal ImprimirComprobante(int idFactura)
                {
                        System.Diagnostics.Process Yo = System.Diagnostics.Process.GetCurrentProcess();
                        Yo.PriorityClass = System.Diagnostics.ProcessPriorityClass.AboveNormal;

                        // *** Inicializar la impresora fiscal
                        Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res = this.Inicializar();

                        if (Res.Error != ErroresFiscales.Ok)
                                return Res;

                        if (EventoConexion != null)
                                EventoConexion(this, new ConexionEventArgs(ConexionEventArgs.EventTypes.InicioImpresion));

                        Lws.Data.DataView DataView = new Lws.Data.DataView(m_Workspace);
                        // *** Obtener datos previos
                        Comprobantes.Factura Fac = new Comprobantes.Factura(DataView, idFactura);

                        if (Fac.Impreso)
                                return new RespuestaFiscal(ErroresFiscales.Ok);

                        // Asiento los precios de costo de los artículos de la factura (con fines estadsticos)
                        System.Data.DataTable ArticulosDetalle = DataView.DataBase.Select("SELECT facturas_detalle.id_factura_detalle, facturas_detalle.id_articulo, articulos.costo FROM facturas_detalle, articulos WHERE facturas_detalle.id_articulo=articulos.id_articulo AND id_factura=" + Fac.Id.ToString());

                        foreach (System.Data.DataRow Art in ArticulosDetalle.Rows) {
                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Art["id_articulo"]) > 0) {
                                        Lfx.Data.SqlUpdateBuilder Act = new Lfx.Data.SqlUpdateBuilder("facturas_detalle");
                                        Act.Fields.AddWithValue("costo", System.Convert.ToDouble(Art["costo"]));
                                        Act.WhereClause = new Lfx.Data.SqlWhereBuilder("id_factura_detalle", System.Convert.ToInt32(Art["id_factura_detalle"]));
                                        this.DataView.Execute(Act);
                                        //this.DataView.DataBase.Execute("UPDATE facturas_detalle SET costo=" + Lfx.Types.Formatting.FormatCurrencySql(System.Convert.ToDouble(Art["costo"])).ToString() + " WHERE id_factura_detalle=" + Art["id_factura_detalle"].ToString());
                                }
                        }

                        ArticulosDetalle = null;

                        string TipoDocumento = null;
                        string Letra = null;


                        if (Fac.Tipo.EsNotaDebito) {
                                TipoDocumento = "D";
                        } else if (Fac.Tipo.EsNotaCredito) {
                                TipoDocumento = "C";
                        } else if (Fac.Tipo.EsTicket) {
                                TipoDocumento = "T";
                        } else {
                                TipoDocumento = "F";
                        }

                        switch (Fac.Tipo.Nomenclatura) {
                                case "M":
                                case "NDM":
                                case "NCM":
                                        // FIXME: va como A?
                                case "A":
                                case "NDA":
                                case "NCA":
                                        Letra = "A";
                                        break;

                                case "B":
                                case "NDB":
                                case "NCB":
                                        Letra = "B";
                                        break;

                                case "C":
                                case "NDC":
                                case "NCC":
                                        Letra = "C";
                                        break;

                                case "E":
                                case "NDE":
                                case "NCE":
                                        Letra = "E";
                                        break;
                        }

                        string ClienteTipoDoc = "DNI";
                        string ClienteNumDoc = Fac.Cliente.NumeroDocumento.Replace("-", "");

                        switch (Fac.Cliente.TipoDocumento) {
                                case 1:
                                        ClienteTipoDoc = "DNI";
                                        break;
                                case 2:
                                        ClienteTipoDoc = "LE";
                                        break;
                                case 3:
                                        ClienteTipoDoc = "LC";
                                        break;
                                case 4:
                                        ClienteTipoDoc = "CI";
                                        break;
                                case 5:
                                        if (ClienteNumDoc.Length > 0)
                                                ClienteTipoDoc = "CUIL";
                                        break;
                                case 6:
                                        if (ClienteNumDoc.Length > 0)
                                                ClienteTipoDoc = "CUIT";
                                        break;
                                default:
                                        ClienteTipoDoc = "DNI";
                                        break;
                        }

                        switch (Fac.Cliente.SituacionTributaria.Id) {
                                case 1:
                                        ClienteNumDoc = Fac.Cliente.NumeroDocumento.Replace("-", "");
                                        ClienteTipoDoc = "DNI";
                                        break;
                                case 2:
                                        ClienteTipoDoc = "CUIT";
                                        ClienteNumDoc = Fac.Cliente.CUIT.Replace("-", "");
                                        break;
                                case 3:
                                        ClienteTipoDoc = "CUIT";
                                        ClienteNumDoc = Fac.Cliente.CUIT.Replace("-", "");
                                        break;
                                case 4:
                                        ClienteTipoDoc = "CUIT";
                                        ClienteNumDoc = Fac.Cliente.CUIT.Replace("-", "");
                                        break;
                                case 5:
                                        ClienteTipoDoc = "CUIT";
                                        ClienteNumDoc = Fac.Cliente.CUIT.Replace("-", "");
                                        break;
                        }

                        ComandoFiscal ComandoAEnviar;

                        string TextoRemitoLinea1 = "";
                        string TextoRemitoLinea2 = "";

                        if (Fac.NumeroRemito == 0) {
                                if (Fac.Obs == null) {
                                        TextoRemitoLinea1 = "";
                                } else if (Fac.Obs.Length > 43) {
                                        TextoRemitoLinea1 = Fac.Obs.Substring(0, 43);
                                        int RestoObs = Fac.Obs.Length - 43;
                                        if (RestoObs > 43)
                                                RestoObs = 43;
                                        TextoRemitoLinea2 = Fac.Obs.Substring(43, RestoObs);
                                } else {
                                        TextoRemitoLinea1 = Fac.Obs;
                                }
                        } else {
                                TextoRemitoLinea1 = "Remito(s) " + Fac.NumeroRemito.ToString();
                        }

                        string Domicilio = Fac.Cliente.Domicilio;
                        string ClienteCiudad = "";
                        if (Fac.Cliente.Ciudad != null)
                                ClienteCiudad = Fac.Cliente.Ciudad.ToString();

                        // *** Abrir Documento
                        if (EventoConexion != null)
                                EventoConexion(this, new ConexionEventArgs("Abrir documento fiscal"));

                        switch (ModeloImpresora) {
                                case Modelos.EpsonGenerico:
                                case Modelos.Emulacion:
                                        string ClienteLinea1 = "";
                                        string ClienteLinea2 = "";

                                        if (Fac.Cliente.ToString().Length > 43) {
                                                ClienteLinea1 = Fac.Cliente.ToString().Substring(0, 43);
                                                ClienteLinea2 = Fac.Cliente.ToString().Substring(43, Fac.Cliente.ToString().Length - 43);
                                        } else {
                                                ClienteLinea1 = Fac.Cliente.ToString();
                                                ClienteLinea2 = "";
                                        }

                                        if (Domicilio.Length > 43)
                                                Domicilio = Domicilio.Substring(0, 43);

                                        if (ClienteCiudad.Length > 43)
                                                ClienteCiudad = ClienteCiudad.Substring(0, 43);

                                        string ClienteSituacionEpson = "";
                                        switch (Fac.Cliente.SituacionTributaria.Id) {
                                                case 1:
                                                        ClienteSituacionEpson = "F";
                                                        break;
                                                case 2:
                                                        ClienteSituacionEpson = "I";
                                                        break;
                                                case 3:
                                                        ClienteSituacionEpson = "R";
                                                        break;
                                                case 4:
                                                        ClienteSituacionEpson = "M";
                                                        break;
                                                case 5:
                                                        ClienteSituacionEpson = "E";
                                                        break;
                                                default:
                                                        ClienteSituacionEpson = "S";
                                                        break;
                                        }

                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalAbrir,
                                                TipoDocumento,
                                                "C",
                                                Letra,
                                                "1",
                                                "F",
                                                "12",
                                                "I",
                                                FiscalizarTexto(ClienteSituacionEpson),
                                                FiscalizarTexto(ClienteLinea1),
                                                FiscalizarTexto(ClienteLinea2),
                                                FiscalizarTexto(ClienteTipoDoc),
                                                FiscalizarTexto(ClienteNumDoc),
                                                "N",
                                                FiscalizarTexto(Domicilio),
                                                FiscalizarTexto(ClienteCiudad),
                                                "",
                                                FiscalizarTexto(TextoRemitoLinea1),
                                                FiscalizarTexto(TextoRemitoLinea2),
                                                "C");
                                        Res = Enviar(ComandoAEnviar);
                                        break;

                                case Modelos.HasarGenerico:
                                        if (Fac.Cliente.Id > 0 && Fac.Cliente.Id != 999) {
                                                //Sólo envío comando SetCustomerData (HasarDocumentoSetDatosCliente)
                                                //si el cliente NO es consumidor final
                                                string ClienteSituacionHasar = "";
                                                switch (Fac.Cliente.SituacionTributaria.Id) {
                                                        case 1:
                                                                ClienteSituacionHasar = "C";
                                                                break;
                                                        case 2:
                                                                ClienteSituacionHasar = "I";
                                                                break;
                                                        case 3:
                                                                ClienteSituacionHasar = "N";
                                                                break;
                                                        case 4:
                                                                ClienteSituacionHasar = "M";
                                                                break;
                                                        case 5:
                                                                ClienteSituacionHasar = "E";
                                                                break;
                                                        case 6:
                                                                ClienteSituacionHasar = "A";
                                                                break;
                                                        case 7:
                                                                ClienteSituacionHasar = "T";
                                                                break;
                                                }

                                                string TipoDocumentoClienteHasar = " ";
                                                switch (ClienteTipoDoc) {
                                                        case "CUIT":
                                                                TipoDocumentoClienteHasar = "C";
                                                                break;
                                                        case "CUIL":
                                                                TipoDocumentoClienteHasar = "L";
                                                                break;
                                                        case "LE":
                                                                TipoDocumentoClienteHasar = "0";
                                                                break;
                                                        case "LC":
                                                                TipoDocumentoClienteHasar = "1";
                                                                break;
                                                        case "DNI":
                                                                TipoDocumentoClienteHasar = "2";
                                                                break;
                                                        case "PP":
                                                                TipoDocumentoClienteHasar = "3";
                                                                break;
                                                        case "CI":
                                                                TipoDocumentoClienteHasar = "4";
                                                                break;
                                                }

                                                string NombreClienteHasar = Fac.Cliente.ToString();

                                                if (Domicilio.Length > 40)
                                                        Domicilio = Domicilio.Substring(0, 40);

                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoSetDatosCliente,
                                                        FiscalizarTexto(NombreClienteHasar, 30),
                                                        ClienteNumDoc,
                                                        ClienteSituacionHasar,
                                                        TipoDocumentoClienteHasar,
                                                        FiscalizarTexto(Domicilio, 40));
                                                Res = Enviar(ComandoAEnviar);
                                        }

                                        //Abrir documento
                                        string TipoDocumentoHasar = "B";
                                        if (TipoDocumento == "D" && Letra == "A")
                                                TipoDocumentoHasar = "E";	//ND A
                                        else if (TipoDocumento == "D")
                                                TipoDocumentoHasar = "E";	//ND B Y C
                                        else if (TipoDocumento == "F" && Letra == "A")
                                                TipoDocumentoHasar = "A";	//Fac A
                                        else if (TipoDocumento == "F")
                                                TipoDocumentoHasar = "B";	//Fac B y C
                                        else if (TipoDocumento == "T")
                                                TipoDocumentoHasar = "T";	//Ticket

                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalAbrir,
                                                TipoDocumentoHasar,
                                                "T");
                                        Res = Enviar(ComandoAEnviar);
                                        break;
                        }

                        if (Res.Error != ErroresFiscales.Ok) {
                                Res.Lugar = "DocumentoFiscalAbrir";
                                return Res;
                        }

                        // *** Imprimir Detalles
                        System.Data.DataTable
                                Detalles = this.DataView.DataBase.Select("SELECT * FROM facturas_detalle WHERE id_factura=" + Fac.Id.ToString());

                        foreach (System.Data.DataRow Detalle in Detalles.Rows) {
                                string StrCodigo = m_Workspace.CurrentConfig.Products.DefaultCode();

                                if (StrCodigo == "id_articulo")
                                        StrCodigo = Lfx.Data.DataBase.ConvertDBNullToZero(Detalle["id_articulo"]).ToString();
                                else
                                        StrCodigo = this.DataView.DataBase.FieldString("SELECT " + StrCodigo + " FROM articulos WHERE id_articulo=" + Lfx.Data.DataBase.ConvertDBNullToZero(Detalle["id_articulo"]).ToString());

                                if (StrCodigo.Length > 0)
                                        StrCodigo = "(" + StrCodigo + ") ";

                                //string ItemNombre = StrCodigo + System.Convert.ToString(Detalle["nombre"]);
                                string ItemNombre = System.Convert.ToString(Detalle["nombre"]);

                                switch (ModeloImpresora) {
                                        case Modelos.EpsonGenerico:
                                        case Modelos.Emulacion:
                                                string ParametroSumaResta = "M";

                                                double EpsonCantidad = System.Convert.ToDouble(Detalle["cantidad"]);
                                                double EpsonPrecio = System.Convert.ToDouble(Detalle["precio"]);

                                                //Si es cantidad negativa, pongo precio negativo y cantidad positiva
                                                if (EpsonCantidad < 0) {
                                                        EpsonCantidad = -EpsonCantidad;
                                                        EpsonPrecio = -EpsonPrecio;
                                                }

                                                if (EpsonPrecio < 0)
                                                        ParametroSumaResta = "R";

                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalItem,
                                                        FiscalizarTexto(ItemNombre).PadRight(54).Substring(0, 54),
                                                        FormatearNumeroEpson(EpsonCantidad, 3).PadLeft(8, '0'),
                                                        FormatearNumeroEpson(Math.Abs(EpsonPrecio), 2).PadLeft(9, '0'),
                                                        "0000",
                                                        ParametroSumaResta,
                                                        "00001",
                                                        "00000000",
                                                        "",
                                                        "",
                                                        "",
                                                        "0000",
                                                        "000000000000000");
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                        case Modelos.HasarGenerico:
                                                string ParametroSumaRestaHasar = "M";

                                                if (System.Convert.ToDouble(Detalle["precio"]) < 0)
                                                        ParametroSumaRestaHasar = "m";

                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalItem,
                                                        FiscalizarTexto(ItemNombre, 50),
                                                        FormatearNumeroHasar(System.Convert.ToDouble(Detalle["cantidad"]), 3),
                                                        FormatearNumeroHasar(Math.Abs(System.Convert.ToDouble(Detalle["precio"])), 2),
                                                        "0.0", /* IVA */
                                                        ParametroSumaRestaHasar,
                                                        "0.0", /* Impuestos Internos */
                                                        "0", /* Campo Display */
                                                        "B" /* Precio total o base */
                                                        );
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                }

                                if (Res.Error != ErroresFiscales.Ok) {
                                        Res.Lugar = "DocumentoFiscalItem";
                                        return Res;
                                }
                        }

                        // Calculo el total real, tomando en cuenta el redondeo y los decimales
                        if (Fac.Descuento > 0) {
                                double MontoDescuento = Fac.SubTotal * (Fac.Descuento / 100);

                                switch (ModeloImpresora) {
                                        case Modelos.EpsonGenerico:
                                        case Modelos.Emulacion:
                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos,
                                                        "Descuento " + Lfx.Types.Formatting.FormatCurrencyForPrint(Fac.Descuento, 2) + "%",
                                                        FormatearNumeroEpson(MontoDescuento, 2).PadLeft(12, '0'),
                                                        "D");
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                        case Modelos.HasarGenerico:
                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalDescuentoGeneral,
                                                        "Descuento " + Lfx.Types.Formatting.FormatCurrencyForPrint(Fac.Descuento, 2) + "%",
                                                        FormatearNumeroHasar(MontoDescuento, 2),
                                                        "m",
                                                        "0",
                                                        "T");
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                }

                                if (Res.Error != ErroresFiscales.Ok) {
                                        Res.Lugar = "DocumentoFiscalPagosYDescuentos:Descuento";
                                        return Res;
                                }
                        }

                        if (Math.Abs(Fac.TotalReal - Fac.Total) >= 0.01) {
                                switch (ModeloImpresora) {
                                        case Modelos.EpsonGenerico:
                                        case Modelos.Emulacion:
                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos,
                                                        "Ajustes por Redondeo",
                                                        FormatearNumeroEpson((Fac.Total - Fac.TotalReal), 2).PadLeft(12, '0'),
                                                        "D");
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                        case Modelos.HasarGenerico:
                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalDescuentoGeneral,
                                                        "Ajustes por Redondeo",
                                                        FormatearNumeroHasar((Fac.Total - Fac.TotalReal), 2),
                                                        "m",
                                                        "0",
                                                        "T");
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                }

                                if (Res.Error != ErroresFiscales.Ok) {
                                        // Error, pero contino
                                        // Res.Lugar = "DocumentoFiscalPagosYDescuentos:Redondeo"
                                        // If Not (OFormFiscalEstado Is Nothing) Then OFormFiscalEstado.Listo()
                                        // Return Res
                                }
                        }

                        //Recargos
                        if (Fac.Recargo > 0) {
                                switch (ModeloImpresora) {
                                        case Modelos.EpsonGenerico:
                                        case Modelos.Emulacion:
                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos,
                                                        "Recargo " + Lfx.Types.Formatting.FormatCurrencyForPrint(Fac.Recargo, m_Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + "%",
                                                        FormatearNumeroEpson(Fac.SubTotal * (Fac.Recargo / 100), 2).PadLeft(12, '0'),
                                                        "R");
                                                Res = Enviar(ComandoAEnviar);
                                                break;
                                        case Modelos.HasarGenerico:
                                                ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalDevolucionesYRecargos,
                                                        "Recargo " + Lfx.Types.Formatting.FormatCurrencyForPrint(Fac.Recargo, m_Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + "%",
                                                        FormatearNumeroHasar(Fac.SubTotal * (Fac.Recargo / 100), 2).PadLeft(10, '0'),
                                                        "M",
                                                        "00000000000",
                                                        "0",
                                                        "T",
                                                        "B");
                                                Res = Enviar(ComandoAEnviar);
                                                break;

                                }

                                if (Res.Error != ErroresFiscales.Ok) {
                                        Res.Lugar = "DocumentoFiscalPagosYDescuentos:Interes";
                                        return Res;
                                }
                        }

                        // Pago
                        switch (Fac.FormaDePago) {
                                case FormasDePago.Efectivo:
                                        switch (ModeloImpresora) {
                                                case Modelos.EpsonGenerico:
                                                case Modelos.Emulacion:
                                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos,
                                                                "Efectivo",
                                                                FormatearNumeroEpson(Fac.Total, 2).PadLeft(12, '0'),
                                                                "T");
                                                        Res = Enviar(ComandoAEnviar);
                                                        break;
                                                case Modelos.HasarGenerico:
                                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalPago,
                                                                "Efectivo",
                                                                FormatearNumeroHasar(Fac.Total, 2),
                                                                "T",
                                                                "1");
                                                        Res = Enviar(ComandoAEnviar);
                                                        break;
                                        }
                                        break;

                                case FormasDePago.Cheque:
                                        switch (ModeloImpresora) {
                                                case Modelos.EpsonGenerico:
                                                case Modelos.Emulacion:
                                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos,
                                                                "Cheque",
                                                                FormatearNumeroEpson(Fac.Total, 2).PadLeft(12, '0'),
                                                                "T");
                                                        Res = Enviar(ComandoAEnviar);
                                                        break;
                                                case Modelos.HasarGenerico:
                                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalPago,
                                                                "Cheuqe",
                                                                FormatearNumeroHasar(Fac.Total, 2),
                                                                "T",
                                                                "0");
                                                        Res = Enviar(ComandoAEnviar);
                                                        break;
                                        }

                                        break;

                                case FormasDePago.CuentaCorriente:
                                        switch (ModeloImpresora) {
                                                case Modelos.EpsonGenerico:
                                                case Modelos.Emulacion:
                                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalPagosYDescuentos,
                                                                "CUENTA CORRIENTE",
                                                                FormatearNumeroEpson(Fac.Total, 2).PadLeft(12, '0'),
                                                                "T");
                                                        Res = Enviar(ComandoAEnviar);
                                                        break;
                                                case Modelos.HasarGenerico:
                                                        ComandoAEnviar = new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalPago,
                                                                "Cuenta Corriente",
                                                                FormatearNumeroHasar(Fac.Total, 2),
                                                                "T",
                                                                "0");
                                                        Res = Enviar(ComandoAEnviar);
                                                        break;
                                        }
                                        break;
                        }

                        if (Res.Error != ErroresFiscales.Ok) {
                                Res.Lugar = "DocumentoFiscalPagosYDescuentos:Pago";
                                return Res;
                        }

                        // *** Cerrar Documento
                        switch (ModeloImpresora) {
                                case Modelos.EpsonGenerico:
                                case Modelos.Emulacion:
                                        Res = Enviar(new ComandoFiscal(CodigosComandosFiscales.EpsonDocumentoFiscalCerrar, "F", Letra, "Final"));
                                        break;
                                case Modelos.HasarGenerico:
                                        Res = Enviar(new ComandoFiscal(CodigosComandosFiscales.HasarDocumentoFiscalCerrar));
                                        break;

                        }

                        if (Res.Error != ErroresFiscales.Ok) {
                                Res.Lugar = "DocumentoFiscalCerrar";
                                return Res;
                        } else {
                                if (EventoConexion != null)
                                        EventoConexion(this, new ConexionEventArgs("Asentando el movimiento"));

                                try {
                                        DataView.BeginTransaction();

                                        //Marco la factura como impresa
                                        DataView.DataBase.Execute("UPDATE facturas SET impresa=1, estado=1, numero=" + Res.NumeroComprobante.ToString() + " WHERE id_factura=" + Fac.Id.ToString());
                                        Fac.Cargar();

                                        //Resto el stock si corresponde
                                        Lbl.Articulos.Stock.MoverStockComprobante(Fac);

                                        //Asiento el pago (sólo efectivo y cta. cte.)
                                        //El resto de los pagos los maneja el formulario desde donde se mandó a imprimir
                                        switch (Fac.FormaDePago) {
                                                case FormasDePago.Efectivo:
                                                        if (Fac.ImporteImpago > 0) {
                                                                Cuentas.CuentaRegular CajaDiaria = new Lbl.Cuentas.CuentaRegular(DataView, this.Workspace.CurrentConfig.Company.CajaDiaria);
                                                                CajaDiaria.Movimiento(true,
                                                                        11000,
                                                                        "Cobro " + Fac.ToString(),
                                                                        Lfx.Data.DataBase.ConvertDBNullToZero(Fac.Cliente.Id),
                                                                        Fac.ImporteImpago,
                                                                        "",
                                                                        Fac.Id,
                                                                        0,
                                                                        "");
								Fac.CancelarImporte(Fac.ImporteImpago);
                                                        }
                                                        break;
                                                case FormasDePago.CuentaCorriente:
                                                        Cuentas.CuentaCorriente CtaCte = new Lbl.Cuentas.CuentaCorriente(DataView, Fac.Cliente.Id);
                                                        CtaCte.IngresarComprobante(Fac, 0);
                                                        break;
                                        }

                                        DataView.Commit();
                                } catch (Exception ex) {
                                        Res = new RespuestaFiscal(ErroresFiscales.Error);
                                        Res.Mensaje = ex.ToString();
                                        // Nada
                                }

                                if (EventoConexion != null)
                                        EventoConexion(this, new ConexionEventArgs("Se imprimió el comprobante"));
                                return Res;
                        }
                }

		private void SendToPrinter(byte[] command)
		{
			Impresora.Write(command, 0, command.Length);
			Lfx.Environment.Threading.Sleep(150, true);
			if(ModeloImpresora == Modelos.EpsonGenerico)
				Impresora.DtrEnable = true;
		}

		private void SendToPrinter(string command)
		{
			SendToPrinter(DefaultEncoding.GetBytes(command));
		}

		private Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal EnviarAEmulacion(ComandoFiscal comando)
		{
			RespuestaFiscal Res = new RespuestaFiscal(ErroresFiscales.Ok);

			Res.CodigoComando = comando.CodigoComando;
			Res.Secuencia = comando.Secuencia;

			Res.Campos = new System.Collections.ArrayList();
			Res.Campos.Add("0080");		//Estado Impresora
			Res.Campos.Add("0600");		//Estado Fiscal

			m_TextEmulacion.AppendLine("CMD " + comando.CodigoComando.ToString() + System.Environment.NewLine);

			switch (comando.CodigoComando)
			{
				case CodigosComandosFiscales.EpsonDocumentoFiscalCerrar:
					int LastComprob = m_Workspace.CurrentConfig.ReadGlobalSettingInt("ServidorFiscal", "UltimoComprobEmulacionPV" + this.PV.ToString(), 0) + 1;
					Res.Campos.Add(LastComprob.ToString("00000000"));
					m_Workspace.CurrentConfig.WriteGlobalSetting("ServidorFiscal", "UltimoComprobEmulacionPV" + this.PV.ToString(), LastComprob.ToString());
					System.Console.WriteLine(m_TextEmulacion.ToString());
					m_TextEmulacion = new System.Text.StringBuilder();
					break;
			}

			Log(Res);
			return Res;
		}

		private Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Enviar(ComandoFiscal comando)
		{
			Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res = Inicializar();

			if (Res.Error != ErroresFiscales.Ok)
				return Res;

			comando.Secuencia = SeqNum;
			SeqNum += 2;
			if (SeqNum > 0X7F)
				SeqNum = FIRST_SEQ;

			if (EventoConexion != null)
				EventoConexion(this, new ConexionEventArgs("Enviando datos"));

			Log(comando);

			if (ModeloImpresora == Modelos.Emulacion)
				return EnviarAEmulacion(comando);

			int IntentosEnviar = 0, IntentosRecibir = 0;

			byte[] BytesCadena = DefaultEncoding.GetBytes(comando.ProtocoloBinario());

			SendToPrinter(BytesCadena);
			IntentosEnviar++;

			if (EventoConexion != null)
				EventoConexion(this, new ConexionEventArgs("Esperando respuesta"));

			DateTime TActual = System.DateTime.Now.AddTicks(System.Convert.ToInt64(TimeSpan.TicksPerSecond * 300));
			string CaracteresRecibidos = "";
			bool TengoSTX = false, TengoETX = false;

			do
			{
				try
				{
					if (ModeloImpresora != Modelos.HasarGenerico)
					{
						Impresora.DtrEnable = true;
						System.Threading.Thread.Sleep(20);
					}
					string CaracteresLeidos = ((char)Impresora.ReadChar()).ToString();
					foreach (char CaracterRecibido in CaracteresLeidos)
					{
						if (CaracterRecibido == CaracteresDeControl.PROTO_ACK)
						{
							// ACK. Todo bien
						}
						else if (CaracterRecibido == CaracteresDeControl.PROTO_NAK)
						{
							// NAK. Reenviar
							if (IntentosEnviar < 4)
							{
								if (EventoConexion != null)
									EventoConexion(this, new ConexionEventArgs("Reenviando"));

								Lfx.Environment.Threading.Sleep(250, true);
								SendToPrinter(BytesCadena);
								IntentosEnviar++;
								CaracteresRecibidos = "";
							}
							else
							{
								break;
							}
						}
						else if (CaracterRecibido == CaracteresDeControl.PROTO_DC2 || CaracterRecibido == CaracteresDeControl.PROTO_DC4)
						{
							// DC2 o DC4, esperar otros 800 ms
							if (EventoConexion != null)
								EventoConexion(this, new ConexionEventArgs("Imprimiendo"));

							TActual = System.DateTime.Now.AddTicks(System.Convert.ToInt64(TimeSpan.TicksPerSecond * 80));
							//CaracteresRecibidos = CaracteresRecibidos.Substring(0, CaracteresRecibidos.Length - 1);
						}
						else if (CaracterRecibido == CaracteresDeControl.PROTO_ETX)
						{
							// En of frame. Leo el BCC y me voy
							CaracteresRecibidos += CaracterRecibido;
							byte[] ReadBytes = new byte[4];
							Impresora.Read(ReadBytes, 0, 4);
							string BCC = DefaultEncoding.GetString(ReadBytes);
							CaracteresRecibidos += BCC;
							TengoETX = true;
							Impresora.DtrEnable = false;
						}
						else
						{
							if (CaracterRecibido == CaracteresDeControl.PROTO_STX)
								TengoSTX = true;

							// Cualquier otro caracter, lo guardo en el buffer
							// (sólo si ya recibí un STX)
							if (TengoSTX)
								CaracteresRecibidos += CaracterRecibido;
						}
					}
				}
				catch //(Exception ex)
				{
					// DEBUG: Esto no siempre es un Timeout (pero siempre es un error de comunicación)
					CaracteresRecibidos = "TIMEOUT";
					break;
				}

				if (System.DateTime.Now > TActual)
					break;

				if (TengoETX)
				{
					//Impresora.DiscardInBuffer();
					//Impresora.DiscardOutBuffer();
					//string Dummy = Impresora.ReadExisting();
					// Analizo la respuesta
					Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Respuesta = AnalizarRespuesta(CaracteresRecibidos);
					Log(Respuesta);
					if (Respuesta.CodigoComando != comando.CodigoComando || Respuesta.Secuencia != comando.Secuencia)
					{
						//La respuesta no corresponde al comando enviado
						//(posiblemente es una respuesta a un comando viejo)
						//En caso de que el comando sea solicitud de estado, ignoro el problema
						//en las impresoras Hasar, ya que todas las respuestas a cualquier comando
						//contienen los códigos de estado y la tiqueadora Hasar 715F suele
						//colgarse respondiendo a un comando viejo
						if (IntentosRecibir++ < 5)
						{
							//Respuesta recibida
							Lfx.Environment.Threading.Sleep(100, true);

							//No es respuesta a este comando o a este número de secuencia
							//Envío un NAK

							string Nak = "" + (char)CaracteresDeControl.PROTO_ACK;
							SendToPrinter(Nak);

							//Pongo nuevamente en espera
							TActual = System.DateTime.Now.AddTicks(System.Convert.ToInt64(TimeSpan.TicksPerSecond * 300));
							CaracteresRecibidos = "";
							TengoSTX = false;
							TengoETX = false;
						}
						else
						{
							return new RespuestaFiscal(ErroresFiscales.Error);
						}
					}
					else
					{
						//Es respuesta correcta a este comando
						switch (ModeloImpresora)
						{
							//Las fiscales Hasar esperan un ACK a la respuesta
							case Modelos.HasarGenerico:
								string Ack = "" + (char)CaracteresDeControl.PROTO_ACK;
								SendToPrinter(Ack);
								break;
						}
						return Respuesta;
					}
				}
			} while (true);

			return AnalizarRespuesta(CaracteresRecibidos);
		}

		protected Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal AnalizarRespuesta(string respuesta)
		{
			Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res = new Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal();
			Res.ProtocoloBinario = respuesta;
			Res.ModeloImpresora = ModeloImpresora;

			if (respuesta == null)
			{
				//Nada
			}
			else if (respuesta == new string((char)0x15, 1))
			{
				Res.Error = ErroresFiscales.NAK;
			}
			else if (respuesta == "TIMEOUT")
			{
				Res.Error = ErroresFiscales.TimeOut;
			}
			else if (respuesta.Length > 5)
			{
				Res.Error = ErroresFiscales.Ok;

				if (respuesta.Length > 1)
					Res.Secuencia = DefaultEncoding.GetBytes(System.Convert.ToString(respuesta[1]))[0];

				if (respuesta.Length > 2)
					Res.CodigoComando = (Fiscal.CodigosComandosFiscales)DefaultEncoding.GetBytes(System.Convert.ToString(respuesta[2]))[0];

				string Carga = "";

				if (respuesta.Length > 5)
					Carga = respuesta.Substring(4, respuesta.Length - 9);

				Res.Campos = new System.Collections.ArrayList();

				while (Carga.Length > 0)
				{
					Res.Campos.Add(Lfx.Types.Strings.GetNextToken(ref Carga, new string((char)0x1C, 1)));
				}

				switch (ModeloImpresora)
				{
					case Modelos.EpsonGenerico:
					case Modelos.Emulacion:
					case Modelos.HasarGenerico:
						if (Res.Campos.Count >= 1)
							Res.EstadoImpresora.CodigoEstado = int.Parse(System.Convert.ToString(Res.Campos[0]), System.Globalization.NumberStyles.AllowHexSpecifier);
						else
							Res.EstadoImpresora.CodigoEstado = 0;

						if (Res.Campos.Count >= 2)
							Res.EstadoFiscal.CodigoEstado = int.Parse(System.Convert.ToString(Res.Campos[1]), System.Globalization.NumberStyles.AllowHexSpecifier);
						else
							Res.EstadoFiscal.CodigoEstado = 0;

						//FormEstado.lblEstadoFiscal.Text = "I: " + Res.EstadoImpresora.CodigoEstado.ToString("X4") + " / F: " + Res.EstadoFiscal.CodigoEstado.ToString("X4");

						if (ModeloImpresora == Modelos.HasarGenerico)
						{
							//Hasar enciende el bit 15 (error) en caso de que no haya cajón
							//de dinero. Es un error que vamos a ignorar
							if (Res.EstadoImpresora.Bit(14))
							{
								//Apago 14 y 15
								Res.EstadoImpresora.CodigoEstado = Res.EstadoImpresora.CodigoEstado & 0x1FFF;
								//Enciendo 15 si hay otro error además del cajón
								if ((Res.EstadoImpresora.CodigoEstado & 0x13E) != 0)
									Res.EstadoImpresora.CodigoEstado = Res.EstadoImpresora.CodigoEstado | (long)Math.Pow(2, 15);
							}
						}

						switch (ModeloImpresora)
						{
							case Modelos.EpsonGenerico:
							case Modelos.Emulacion:
							case Modelos.HasarGenerico:
								if ((Res.EstadoImpresora.CodigoEstado & 0X8000) != 0)
									Res.Error = ErroresFiscales.ErrorImpresora;
								else if ((Res.EstadoFiscal.CodigoEstado & 0X80FF) != 0)
									Res.Error = ErroresFiscales.ErrorFiscal;

								if (this.ModeloImpresora == Modelos.EpsonGenerico && Res.EstadoFiscal.HacerCierreZ)
								{
									//Sólo para Epson, bit 11 indica que es necesario hacer un cierre Z
									Res.HacerCierreZ = true;
								}
								break;
						}
						break;
				}
			}
			else
			{
				Res.Error = ErroresFiscales.Error;
				Res.Mensaje = "Sin datos";
			}

			return Res;
		}

                private static string FormatearNumeroEpson(double Numero, int Decimales)
		{
			return Math.Round(Math.Abs(Numero) * (Math.Pow(10, Decimales))).ToString(System.Globalization.CultureInfo.InvariantCulture);
		}

                private static string FormatearNumeroHasar(double Numero, int Decimales)
		{
			string Formato = "0." + "".PadRight(Decimales, '0');
			return Math.Abs(Numero).ToString(Formato, System.Globalization.CultureInfo.InvariantCulture);
		}

		private void Log(RespuestaFiscal respuesta)
		{
			Log(respuesta.ToString());
		}
		private void Log(ComandoFiscal comando)
		{
			Log(comando.ToString());
		}
		private void Log(string texto)
		{
			System.IO.StreamWriter wr = new System.IO.StreamWriter(new System.IO.FileStream(Lfx.Environment.Folders.ApplicationDataFolder + "fiscal.log", System.IO.FileMode.Append), DefaultEncoding);
			wr.Write(texto);
			wr.Close();
		}

                private static string FiscalizarTexto(string cadena)
		{
			return FiscalizarTexto(cadena, 0);
		}

                private static string FiscalizarTexto(string cadena, int longitudMax)
		{
			string sRes = null;
			sRes = cadena.Replace("á", "a");
			sRes = sRes.Replace("é", "e");
			sRes = sRes.Replace("í", "i");
			sRes = sRes.Replace("ó", "o");
			sRes = sRes.Replace("ú", "u");
			sRes = sRes.Replace("ü", "u");
			sRes = sRes.Replace("ñ", "n");

			sRes = sRes.Replace("Á", "A");
			sRes = sRes.Replace("É", "E");
			sRes = sRes.Replace("Í", "I");
			sRes = sRes.Replace("Ó", "O");
			sRes = sRes.Replace("Ú", "U");
			sRes = sRes.Replace("Ü", "U");
			sRes = sRes.Replace("Ñ", "N");

			for (int i = 0; i <= 31; i++)
			{
				sRes = sRes.Replace((char)i, '#');
			}

			for (int i = 127; i <= 255; i++)
			{
				sRes = sRes.Replace((char)i, '#');
			}

			if (longitudMax > 0 && sRes.Length > longitudMax)
				sRes = sRes.Substring(0, longitudMax);

			return sRes;
		}

		public Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal ObtenerEstadoImpresora()
		{
			switch (ModeloImpresora)
			{
				case Modelos.EpsonGenerico:
				case Modelos.Emulacion:
					return Enviar(new ComandoFiscal(CodigosComandosFiscales.EpsonSolicitudEstado, "N"));
				case Modelos.HasarGenerico:
					return Enviar(new ComandoFiscal(CodigosComandosFiscales.HasarSolicitudEstado));
				default:
					return new RespuestaFiscal(ErroresFiscales.Error);
			}
		}
	}
}
