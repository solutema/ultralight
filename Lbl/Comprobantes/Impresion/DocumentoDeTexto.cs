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

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lbl.Comprobantes.Impresion
{
	public class DocumentoDeTexto
	{
		private string m_Tipo;

		public enum mpAlineacion
		{
			mpIzq = 0,
			mpDer = 1,
		}

		public DocumentoDeTexto(string sTipo)
		{
			m_Tipo = sTipo;
		}

		public Lfx.Types.OperationResult ImprimirComprobante(Lws.Data.DataView dataView, int lCodigo, string Impresora)
		{
			Lfx.Types.OperationResult imprimirComprobanteReturn = new Lfx.Types.SuccessOperationResult();

			// Este vector contiene una "imagen" (matriz de caracteres) que representa al comprobante
			string[] Factura = null;

			// Obtengo el formato del comprobante de la base de datos
			string sDefinicion = dataView.DataBase.FieldString("SELECT definicion FROM sys_plantillas WHERE codigo='" + m_Tipo + "'");
			if (sDefinicion == null)
				sDefinicion = dataView.DataBase.FieldString("SELECT definicion FROM sys_plantillas WHERE codigo='*'");

			Factura = new string[Lfx.Types.Ini.ReadInt(sDefinicion, "General", "PaginaAlto")];

			for (int n = Factura.GetLowerBound(0); n <= Factura.GetUpperBound(0); n++)
				Factura[n] = System.String.Empty.PadLeft(256);

			// Cargo el registro correspondiente a la factura y al cliente
			Lfx.Data.Row RegistroFactura = dataView.DataBase.Row("comprob", "id_comprob", lCodigo);
			Lfx.Data.Row RegistroCliente = dataView.DataBase.Row("personas", "id_persona", System.Convert.ToInt32(RegistroFactura["id_cliente"]));

			// Calculo el total real, tomando en cuenta el redondeo y los decimales
			double Total = System.Convert.ToDouble(RegistroFactura["total"]);
			double TotalReal = System.Convert.ToDouble(RegistroFactura["totalreal"]);

			// Determino la impresora que prefiere o le corresponde
			if (Impresora != null && Impresora.Length == 0)
				Impresora = dataView.Workspace.CurrentConfig.Printing.PreferredPrinter(System.Convert.ToString(RegistroFactura["tipo_fac"]));

			string strCodigos = null;
			string strDescrips = null;
			string strCants = null;
			string strPrecios = null;
			string strImportes = null;

			System.Data.DataTable TablaArticulos = dataView.DataBase.Select("SELECT id_articulo, nombre, cantidad, precio, importe FROM comprob_detalle WHERE id_comprob=" + lCodigo.ToString() + " ORDER BY orden");

			if (TablaArticulos.Rows.Count > 0)
			{
				foreach (System.Data.DataRow Articulo in TablaArticulos.Rows)
				{
					if (Lfx.Data.DataBase.ConvertDBNullToZero(Articulo["id_articulo"]) > 0)
					{
						if (Lbl.Articulos.Stock.CodigoPredet(dataView.Workspace) == "id_articulo")
							strCodigos = strCodigos + System.Convert.ToInt32(Articulo["id_articulo"]).ToString("00000000000") + System.Environment.NewLine;
						else
							strCodigos = strCodigos + Lbl.Articulos.Stock.CodigoPredet(dataView.Workspace, dataView.DataBase.Row("articulos", "id_articulo", System.Convert.ToInt32(Articulo["id_articulo"]))) + System.Environment.NewLine;
					}
					else
					{
						strCodigos = strCodigos + System.Environment.NewLine;
					}

					strDescrips = strDescrips + System.Convert.ToString(Articulo["nombre"]) + System.Environment.NewLine;
					strCants = strCants + Lfx.Types.Formatting.FormatStock(System.Convert.ToDouble(Articulo["cantidad"]), dataView.Workspace.CurrentConfig.Products.StockDecimalPlaces) + System.Environment.NewLine;
					strPrecios = strPrecios + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(Articulo["precio"]), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
					strImportes = strImportes + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(Articulo["importe"]), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
				}
			}

			if (System.Convert.ToDouble(RegistroFactura["descuento"]) > 0 && System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
			{
				strCodigos = strCodigos + System.Environment.NewLine;
				strDescrips = strDescrips + "Descuento " + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(RegistroFactura["descuento"]), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + "%" + System.Environment.NewLine;
				strCants = strCants + System.Environment.NewLine;
				strPrecios = strPrecios + Lfx.Types.Currency.CurrencySymbol + " -" + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(RegistroFactura["subtotal"]) * (System.Convert.ToDouble(RegistroFactura["descuento"]) / 100), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
				strImportes = strImportes + Lfx.Types.Currency.CurrencySymbol + " -" + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(RegistroFactura["subtotal"]) * (System.Convert.ToDouble(RegistroFactura["descuento"]) / 100), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
			}

			if (System.Convert.ToDouble(RegistroFactura["interes"]) > 0 && System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
			{
				strCodigos = strCodigos + System.Environment.NewLine;
				strDescrips = strDescrips + "Recargo " + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(RegistroFactura["interes"]), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + "%" + System.Environment.NewLine;
				strCants = strCants + System.Environment.NewLine;
				strPrecios = strPrecios + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(RegistroFactura["subtotal"]) * (System.Convert.ToDouble(RegistroFactura["interes"]) / 100), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
				strImportes = strImportes + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrencyForPrint(System.Convert.ToDouble(RegistroFactura["subtotal"]) * (System.Convert.ToDouble(RegistroFactura["interes"]) / 100), dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
			}

			if (TotalReal != Total && System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
			{
				strCodigos = strCodigos + System.Environment.NewLine;
				strDescrips = strDescrips + "Ajustes por Redondeo" + System.Environment.NewLine;
				strCants = strCants + System.Environment.NewLine;
				strPrecios = strPrecios + System.Environment.NewLine;
				strImportes = strImportes + Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrencyForPrint(Total - TotalReal, dataView.Workspace.CurrentConfig.Currency.DecimalPlacesCosto) + System.Environment.NewLine;
			}

			long lPasada = 0;
			long lPasadas = 0;
			string sNombrePasada = null;
			Rectangle cPasadaXY = new System.Drawing.Rectangle();
			Rectangle cFechaXY = new System.Drawing.Rectangle();
			Rectangle cClienteXY = new System.Drawing.Rectangle();
			Rectangle cDomicilioXY = new System.Drawing.Rectangle();
			Rectangle cCUITXY = new System.Drawing.Rectangle();
			Rectangle cIVAXY = new System.Drawing.Rectangle();
			Rectangle cTotalXY = new System.Drawing.Rectangle();
			Rectangle cNumeroXY = new System.Drawing.Rectangle();
			Rectangle cFormaPagoXY = new System.Drawing.Rectangle();
			Rectangle cCodigosXY = new System.Drawing.Rectangle();
			Rectangle cDetallesXY = new System.Drawing.Rectangle();
			Rectangle cCantidadesXY = new System.Drawing.Rectangle();
			Rectangle cPreciosXY = new System.Drawing.Rectangle();
			Rectangle cImportesXY = new System.Drawing.Rectangle();
			Rectangle cSonPesosXY = new System.Drawing.Rectangle();
			Rectangle cOrigenXY = new System.Drawing.Rectangle();
			Rectangle cDestinoXY = new System.Drawing.Rectangle();
			int iTextos = 0;
			string sTextos = null;
			Rectangle cTextosXY = new System.Drawing.Rectangle();

			lPasadas = Lfx.Types.Ini.ReadInt(sDefinicion, "General", "Pasadas");

			for (lPasada = 1; lPasada <= lPasadas; lPasada++)
			{
				sNombrePasada = "Pasada" + lPasada.ToString();
				cPasadaXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "XY", cPasadaXY);

				cFechaXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "FechaXY", cFechaXY);
				cNumeroXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "NumeroXY", cNumeroXY);
				cClienteXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "ClienteXY", cClienteXY);
				cDomicilioXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "DomicilioXY", cDomicilioXY);
				cCUITXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "CUITXY", cCUITXY);
				cIVAXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "IVAXY", cIVAXY);
				cFormaPagoXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "FormaPagoXY", cFormaPagoXY);
				cOrigenXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "OrigenXY", cOrigenXY);
				cDestinoXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "DestinoXY", cDestinoXY);

				cCodigosXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "CodigosXY", cCodigosXY);
				cDetallesXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "DetallesXY", cDetallesXY);
				cCantidadesXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "CantidadesXY", cCantidadesXY);
				cPreciosXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "PreciosXY", cPreciosXY);
				cImportesXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "ImportesXY", cImportesXY);

				cSonPesosXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "SonPesosXY", cSonPesosXY);

				cTotalXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "TotalXY", cTotalXY);

				MPrint(ref Factura, cFechaXY, cPasadaXY, System.Convert.ToDateTime(RegistroFactura["fecha"]).ToString("dd-MM-yyyy"));
				MPrint(ref Factura, cNumeroXY, cPasadaXY, Lbl.Comprobantes.Comprobante.NumeroCompleto(dataView, lCodigo));
				MPrint(ref Factura, cClienteXY, cPasadaXY, "(" + System.Convert.ToInt32(RegistroFactura["id_cliente"]).ToString() + ") " + System.Convert.ToString(RegistroCliente["nombre_visible"]));
				MPrint(ref Factura, cDomicilioXY, cPasadaXY, System.Convert.ToString(RegistroCliente["domicilio"]));

				if (System.Convert.ToString(RegistroCliente["cuit"]).Length > 0)
					MPrint(ref Factura, cCUITXY, cPasadaXY, System.Convert.ToString(RegistroCliente["cuit"]));
				else
					MPrint(ref Factura, cCUITXY, cPasadaXY, System.Convert.ToString(RegistroCliente["num_doc"]));

				MPrint(ref Factura, cOrigenXY, cPasadaXY, dataView.DataBase.FieldString("SELECT nombre FROM articulos_situaciones WHERE id_situacion=" + RegistroFactura["situacionorigen"].ToString()));
				MPrint(ref Factura, cDestinoXY, cPasadaXY, dataView.DataBase.FieldString("SELECT nombre FROM articulos_situaciones WHERE id_situacion=" + RegistroFactura["situaciondestino"].ToString()));
				MPrint(ref Factura, cIVAXY, cPasadaXY, dataView.DataBase.FieldString("SELECT nombre FROM situaciones WHERE id_situacion=" + Lfx.Data.DataBase.ConvertDBNullToZero(RegistroCliente["id_situacion"]).ToString()));

				if (System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
					MPrint(ref Factura, cFormaPagoXY, cPasadaXY, dataView.DataBase.FieldString("SELECT nombre FROM formaspago WHERE id_formapago=" + Lfx.Data.DataBase.ConvertDBNullToZero(RegistroFactura["id_formapago"]).ToString()));

				MPrint(ref Factura, cCodigosXY, cPasadaXY, (strCodigos), mpAlineacion.mpDer);
				MPrint(ref Factura, cDetallesXY, cPasadaXY, (strDescrips));
				MPrint(ref Factura, cCantidadesXY, cPasadaXY, (strCants), mpAlineacion.mpDer);

				if (System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
					MPrint(ref Factura, cPreciosXY, cPasadaXY, (strPrecios), mpAlineacion.mpDer);

				if (System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
					MPrint(ref Factura, cImportesXY, cPasadaXY, (strImportes), mpAlineacion.mpDer);

				if (System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
					MPrint(ref Factura, cSonPesosXY, cPasadaXY, "Son pesos: " + Lfx.Types.Formatting.SpellNumber(Total));

				if (System.Convert.ToString(RegistroFactura["tipo_fac"]) != "R")
				{
					MPrint(ref Factura,
					       cTotalXY,
					       cPasadaXY,
					       Lfx.Types.Currency.CurrencySymbol + " " + Lfx.Types.Formatting.FormatCurrencyForPrint(Total, dataView.Workspace.CurrentConfig.Currency.DecimalPlacesFinal),
					       mpAlineacion.mpDer);
				}

				// Imprimo las observaciones en el lugar que queda debajo de los detalles, cantidades, etc.
				if (System.Convert.ToString(RegistroFactura["obs"]).Length > 0)
				{
					//Busco todo el lugar disponible para obs.
					Rectangle cObsXY = new Rectangle();

					cObsXY.X = cCodigosXY.X;

					if (cCodigosXY.X > cDetallesXY.X) cCodigosXY.X = cDetallesXY.X;
					if (cCodigosXY.X > cCantidadesXY.X) cCodigosXY.X = cCantidadesXY.X;
					if (cCodigosXY.X > cPreciosXY.X) cCodigosXY.X = cPreciosXY.X;
					if (cCodigosXY.X > cImportesXY.X) cCodigosXY.X = cImportesXY.X;

					cObsXY.Y = cCodigosXY.Y;

					if (cObsXY.Y > cDetallesXY.Y) cObsXY.Y = cDetallesXY.Y;
					if (cObsXY.Y > cCantidadesXY.Y) cObsXY.Y = cCantidadesXY.Y;
					if (cObsXY.Y > cPreciosXY.Y) cObsXY.Y = cPreciosXY.Y;
					if (cObsXY.Y > cImportesXY.Y) cObsXY.Y = cImportesXY.Y;
					cObsXY.Y += TablaArticulos.Rows.Count + 1;

					if (System.Convert.ToDouble(RegistroFactura["descuento"]) > 0)
						cObsXY.Y++;

					if (System.Convert.ToDouble(RegistroFactura["interes"]) > 0)
						cObsXY.Y++;

					cObsXY.Width = cCodigosXY.Right;

					if (cObsXY.Width < cDetallesXY.Right) cObsXY.Width = cDetallesXY.Right;
					if (cObsXY.Width < cCantidadesXY.Right) cObsXY.Width = cCantidadesXY.Right;
					if (cObsXY.Width < cPreciosXY.Right) cObsXY.Width = cPreciosXY.Right;

					cObsXY.Width = cObsXY.Width - cCodigosXY.X - 1;

					cObsXY.Height = cCodigosXY.Bottom;

					if (cObsXY.Height < cDetallesXY.Bottom)
						cObsXY.Height = cDetallesXY.Bottom;

					if (cObsXY.Height < cCantidadesXY.Bottom)
						cObsXY.Height = cCantidadesXY.Bottom;

					if (cObsXY.Height < cPreciosXY.Bottom)
						cObsXY.Height = cPreciosXY.Bottom;

					cObsXY.Height = cObsXY.Height - cCodigosXY.Y - 1;

					// Si queda lugar para poner alguna observación...
					if (cObsXY.Height >= 1)
					{
						// Primero, corto la obs en renglones del ancho correcto
						string sObs = "Obs: " + System.Convert.ToString(RegistroFactura["obs"]);
						string sObs2 = "";

						while (sObs.Length > cObsXY.Width)
						{
							// Intento cortar en los espacios.
							int r = cObsXY.Width;

							for (int BuscoEspacio = r - 1; BuscoEspacio >= r - 13; BuscoEspacio--)
							{
								if (sObs.Substring(BuscoEspacio, 1) == " ")
								{
									r = BuscoEspacio;
									break;
								}
							}

							sObs2 += sObs.Substring(0, r).Trim() + System.Environment.NewLine;
							sObs = sObs.Substring(r, sObs.Length - r).Trim();
						}

						sObs = sObs2 + sObs;
						//Imprimo obs
						MPrint(ref Factura, cObsXY, cPasadaXY, sObs);
					}
				}

				iTextos = Lfx.Types.Ini.ReadInt(sDefinicion, sNombrePasada, "Textos", 0);

				if (iTextos == 0)
					iTextos = Lfx.Types.Ini.ReadInt(sDefinicion, "Pasada1", "Textos", 0);

				for (int i = 1; i <= iTextos; i++)
				{
					sTextos = Lfx.Types.Ini.ReadString(sDefinicion, sNombrePasada, "Texto" + i.ToString(), "");

					if (sTextos.Length == 0)
						sTextos = Lfx.Types.Ini.ReadString(sDefinicion, "Pasada1", "Texto" + i.ToString(), "");

					cTextosXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "Texto" + i.ToString() + "XY", new Rectangle(0, 0, 0, 0));

					if (cTextosXY.X == 0 && cTextosXY.Y == 0)
						cTextosXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, "Pasada1", "Texto" + i.ToString() + "XY", cTextosXY);

					MPrint(ref Factura, cTextosXY, cPasadaXY, sTextos);
				}
			}

			//Quito los espacios al final de cada línea
			for (int i = 0; i < Factura.Length; i++)
			{
				Factura[i] = Factura[i].TrimEnd();
				if (Factura[i].Length == 0)
					Factura[i] = " ";
			}

			// Creo el nuevo documento (utilizando la clase para imprimir texto)
                        Lfx.Printing.TextPrint Documento = new Lfx.Printing.TextPrint(String.Join(" " + System.Environment.NewLine, Factura));
			Documento.DocumentName = "Comprobante " + Lbl.Comprobantes.Comprobante.NumeroCompleto(dataView, lCodigo);

			// Si prefiere una impresora, la selecciono
			if (Impresora != null && Impresora.Length > 0)
			{
                                // FIXME: Esta comprobación debera hacerla mucho antes
				foreach (string sNombreImpresora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
				{
					if (sNombreImpresora == Impresora)
					{
						Documento.PrinterSettings.PrinterName = sNombreImpresora;
						break;
					}
				}

				if (string.Compare(Documento.PrinterSettings.PrinterName, Impresora, true) != 0)
				{
					foreach (string sNombreImpresora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
					{
						if (string.Compare(sNombreImpresora, Impresora, true) == 0)
						{
							Documento.PrinterSettings.PrinterName = sNombreImpresora;
							break;
						}
					}
				}

				if (string.Compare(Documento.PrinterSettings.PrinterName, Impresora, true) != 0)
				{
					imprimirComprobanteReturn.Success = false;
					imprimirComprobanteReturn.Message = @"No se puede encontrar la impresora """ + Impresora + @""".";
				}
			}

			string sFuente = Lfx.Types.Ini.ReadString(sDefinicion, "General", "Fuente", "Courier New");
			int iFuenteTamano = Lfx.Types.Ini.ReadInt(sDefinicion, "General", "FuenteTamano", 10);

			// Esto elimina esa odiosa ventana de estado que permite cancelar la impresión
			Documento.PrintController = new System.Drawing.Printing.StandardPrintController();

			Documento.DefaultPageSettings.Margins.Left = 0;
			Documento.DefaultPageSettings.Margins.Top = 0;
			Documento.DefaultPageSettings.Margins.Right = 0;
			Documento.DefaultPageSettings.Margins.Bottom = 0;
			if (sFuente == null || sFuente.Length == 0)
				Documento.Font = new Font("Courier New", 9, FontStyle.Bold);
			else
				Documento.Font = new Font(sFuente, iFuenteTamano, FontStyle.Bold);

			try
			{
				Documento.Print();
			}
			catch (Exception ex)
			{
				imprimirComprobanteReturn.Success = false;
				imprimirComprobanteReturn.Message = ex.ToString();
			}

			return imprimirComprobanteReturn;
		}

                private static void MPrint(ref string[] Matriz, Rectangle lXY, Rectangle lDespl, string sCadena)
		{
			MPrint(ref Matriz, lXY, lDespl, sCadena, mpAlineacion.mpIzq);
		}

		private static void MPrint(ref string[] Matriz, Rectangle lXY, Rectangle lDespl, string sCadena, mpAlineacion lAlineacion)
		{
			// Imprime un texto en una matriz de cadenas.
			// Creo que se utiliza exclusivamente en la ClaseComprobante
			if (sCadena == null)
				return;

			string sRenglon = "";

			if (lXY.Height == 0)
				lXY.Height = 1;

			for (int n = 1; n <= lXY.Height; n++)
			{
				if (lXY.X + lDespl.X > 0 && lXY.Y + lDespl.Y > 0 && lXY.Y + lDespl.Y + n - 1 <= Matriz.GetUpperBound(0))
				{
					sRenglon = Lfx.Types.Strings.GetNextToken(ref sCadena, System.Environment.NewLine);

					if (lXY.Width > 0)
					{
						if (lAlineacion == mpAlineacion.mpDer)
						{
							if (sRenglon.Length > lXY.Width)
								sRenglon = sRenglon.Substring(sRenglon.Length - lXY.Width, lXY.Width);
							sRenglon = sRenglon.PadLeft(lXY.Width);
						}
						else
						{
							if (sRenglon.Length > lXY.Width)
								sRenglon = sRenglon.Substring(0, lXY.Width);
						}
					}

					if (lXY.X + lDespl.X < 1)
						lXY.X = 1;

					string ElementoTemp = Matriz[lXY.Y + lDespl.Y + n - 1];
					ElementoTemp = ElementoTemp.Substring(0, lXY.X + lDespl.X - 1) + sRenglon + ElementoTemp.Substring(lXY.X + lDespl.X - 1 + sRenglon.Length);
					Matriz[lXY.Y + lDespl.Y + n - 1] = ElementoTemp;
				}
			}
		}
	}
}
