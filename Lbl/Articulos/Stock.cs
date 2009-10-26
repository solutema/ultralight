// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lbl.Articulos
{
	public class Stock
	{
		public static void MoverStockFactura(Lbl.Comprobantes.ComprobanteConArticulos comprobante, bool saliente)
		{
			// Resta lo facturado del stock
			string NombreMovim = null;

			if (saliente)
				NombreMovim = "Salida";
			else
				NombreMovim = "Ingreso";

			foreach (Comprobantes.DetalleArticulo Det in comprobante.Articulos)
			{

				if (Det.Articulo != null && Det.Articulo.Id > 0)
				{
                                        if (saliente) {
                                                Det.Articulo.MoverStock(Det.Cantidad,
                                                        NombreMovim + " s/comprob. " + comprobante.ToString(),
                                                        comprobante.SituacionOrigen,
                                                        comprobante.SituacionDestino,
                                                        Det.Series);
                                        } else {
                                                Det.Articulo.MoverStock(Det.Cantidad,
                                                        NombreMovim + " s/comprob. " + comprobante.ToString(),
                                                        comprobante.SituacionDestino,
                                                        comprobante.SituacionOrigen,
                                                        Det.Series);
                                        }
				}
			}
		}

		public static void MoverStockComprobante(Lbl.Comprobantes.ComprobanteConArticulos comprobante)
		{
                        if (comprobante.Tipo.MueveStock) {
                                if (comprobante.Tipo.Nomenclatura == "R") {
                                        // Es un Remito. Muevo el Stock
                                        MoverStockFactura(comprobante, true);
                                } else {
                                        // Es una factura, NC o ND. Descuento el Stock, sólo si no hay remito asociado
                                        if (comprobante.NumeroRemito == 0)
                                                MoverStockFactura(comprobante, true);
                                }
                        }
		}

                public enum DownloadImage
                {
                        Always,
                        Never,
                        OnlyIfNotInCache,
                        PreferCacheOnSlowLinks
                }

		public static System.Drawing.Image ProductImage(Lws.Data.DataView dataView, int productId)
		{
			return ProductImage(dataView, productId, DownloadImage.PreferCacheOnSlowLinks);
		}

		public static System.Drawing.Image ProductImage(Lws.Data.DataView dataView, int productId, DownloadImage downloadImage)
		{
			string CachePath = Lfx.Environment.Folders.CacheFolder;
			string ImageFileName = "product_" + productId.ToString() + ".jpg";
			bool ImageInCache = System.IO.File.Exists(CachePath + ImageFileName);

			if(downloadImage == DownloadImage.Always
				|| (downloadImage == DownloadImage.OnlyIfNotInCache && ImageInCache == false)
				|| ((downloadImage == DownloadImage.PreferCacheOnSlowLinks && ImageInCache == false) || dataView.DataBase.SlowLink == false))
			{
				//Download image and save to cache
				Lfx.Data.Row ImagenDB = dataView.DataBase.Row("articulos_imagenes", "imagen", "id_articulo", productId);

                                if (ImagenDB != null && ImagenDB.Fields["imagen"].Value != DBNull.Value && ((byte[])(ImagenDB.Fields["imagen"].Value)).Length > 5)
				{
					//Guardar imagen en cache
					System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CachePath + ImageFileName), System.Text.Encoding.Default);
                                        wr.Write(((byte[])(ImagenDB.Fields["imagen"].Value)));
					wr.Close();

                                        byte[] ByteArr = ((byte[])(ImagenDB.Fields["imagen"].Value));
					System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
					return System.Drawing.Image.FromStream(loStream);
				}
				else
				{
					//Devuelve la imagen de la categoría, en lugar de la del artículo
					int CategoriaArticulo = dataView.DataBase.FieldInt("SELECT id_cat_articulo FROM articulos WHERE id_articulo=" + productId.ToString());
					return CategoryImage(dataView, CategoriaArticulo, downloadImage);
				}
			}

			//Serve only from cache
			if(ImageInCache)
			{
				return System.Drawing.Image.FromFile(CachePath + ImageFileName);
			}
			
			return null;
		}

		public static System.Drawing.Image CategoryImage(Lws.Data.DataView dataView, int categoryId, DownloadImage downloadImage)
		{
			string CachePath = Lfx.Environment.Folders.CacheFolder;
			string ImageFileName = "product_category_" + categoryId.ToString() + ".jpg";
			bool ImageInCache = System.IO.File.Exists(CachePath + ImageFileName);

                        if (downloadImage == DownloadImage.Always
                                || (downloadImage == DownloadImage.OnlyIfNotInCache && ImageInCache == false)
                                || ((downloadImage == DownloadImage.PreferCacheOnSlowLinks && ImageInCache == false) || dataView.DataBase.SlowLink == false))
			{
				//Download image and save to cache
				Lfx.Data.Row ImagenDB = dataView.DataBase.Row("cat_articulos", "imagen", "id_cat_articulo", categoryId);

				if(ImagenDB != null && ImagenDB["imagen"] != null && ((byte[])(ImagenDB["imagen"])).Length > 5)
				{
					//Guardar imagen en cache
					System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CachePath + ImageFileName), System.Text.Encoding.Default);
					wr.Write(((byte[])(ImagenDB["imagen"])));
					wr.Close();

					byte[] ByteArr = ((byte[])(ImagenDB["imagen"]));
					System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
					return System.Drawing.Image.FromStream(loStream);
				}
				else
				{
					return null;
				}
			}

			//Serve only from cache
			if(ImageInCache)
				return System.Drawing.Image.FromFile(CachePath + ImageFileName);
			
			return null;
		}

		public static string CodigoPredet(Lws.Workspace workspace)
		{
			return CodigoPredet(workspace, null);
		}

		public static string CodigoPredet(Lws.Workspace workspace, Lfx.Data.Row Articulo)
		{
			// Devuelve el código predeterminado de un artículo
			// Si se pasa un registro artículo como parmetro, devuelve el valor del
			// De lo contrario, devuelve el nombre del campo
			// Espero que no se preste a confusin
			string CodPredet = workspace.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Stock.CodigoPredet", "0");

			switch(CodPredet)
			{
				case "0":
				case "":
					// Usar el código autonumérico integrado
					CodPredet = "id_articulo";
					break;

				default:
					// Usar un código en particular
					CodPredet = "codigo" + CodPredet;
					break;
			}

			if(Articulo == null)
				return CodPredet;
			else
				return System.Convert.ToString(Articulo[CodPredet]);
		}
	}
}
