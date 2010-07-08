#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
                HasarDocumentoFiscalTexto = 0X41,
                HasarDocumentoFiscalItem = 0X42,
		HasarDocumentoFiscalDescuentoGeneral = 0X54,
		HasarDocumentoFiscalDevolucionesYRecargos = 0X6D,
		HasarDocumentoFiscalPago = 0X44,
		HasarDocumentoFiscalCerrar = 0X45,
		HasarDocumentoFiscalCancelar = 0X98,
	}
}
