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

namespace Lbl.Articulos
{
	public class Stock
	{
                public enum DownloadImage
                {
                        Always,
                        Never,
                        OnlyIfNotInCache,
                        PreferCacheOnSlowLinks
                }


		public static System.Drawing.Image ProductImage(Lfx.Data.Connection dataBase, int productId)
		{
			return ProductImage(dataBase, productId, DownloadImage.PreferCacheOnSlowLinks);
		}

		public static System.Drawing.Image ProductImage(Lfx.Data.Connection dataBase, int productId, DownloadImage downloadImage)
		{
			string CachePath = Lfx.Environment.Folders.CacheFolder;
			string ImageFileName = "product_" + productId.ToString() + ".jpg";
			bool ImageInCache = System.IO.File.Exists(CachePath + ImageFileName);

			if(downloadImage == DownloadImage.Always
				|| (downloadImage == DownloadImage.OnlyIfNotInCache && ImageInCache == false)
				|| ((downloadImage == DownloadImage.PreferCacheOnSlowLinks && ImageInCache == false) || Lfx.Workspace.Master.SlowLink == false))
			{
				//Download image and save to cache
				Lfx.Data.Row ImagenDB = dataBase.Row("articulos_imagenes", "imagen", "id_articulo", productId);

                                if (ImagenDB != null && ImagenDB.Fields["imagen"].Value != null && ((byte[])(ImagenDB.Fields["imagen"].Value)).Length > 5)
				{
					//Guardar imagen en cache
					System.IO.BinaryWriter wr = new System.IO.BinaryWriter(System.IO.File.OpenWrite(CachePath + ImageFileName), System.Text.Encoding.Default);
                                        wr.Write(((byte[])(ImagenDB.Fields["imagen"].Value)));
					wr.Close();

                                        byte[] ByteArr = ((byte[])(ImagenDB.Fields["imagen"].Value));
                                        System.Drawing.Image Img;

                                        using (System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr)) {
                                                Img = System.Drawing.Image.FromStream(loStream);
                                        }
                                        return Img;
				}
				else
				{
					//Devuelve la imagen de la categoría, en lugar de la del artículo
					int CategoriaArticulo = dataBase.FieldInt("SELECT id_categoria FROM articulos WHERE id_articulo=" + productId.ToString());
					return CategoryImage(dataBase, CategoriaArticulo, downloadImage);
				}
			}

			//Serve only from cache
			if(ImageInCache)
			{
				return System.Drawing.Image.FromFile(CachePath + ImageFileName);
			}
			
			return null;
		}

		public static System.Drawing.Image CategoryImage(Lfx.Data.Connection dataBase, int categoryId, DownloadImage downloadImage)
		{
			string CachePath = Lfx.Environment.Folders.CacheFolder;
			string ImageFileName = "product_category_" + categoryId.ToString() + ".jpg";
			bool ImageInCache = System.IO.File.Exists(CachePath + ImageFileName);

                        if (downloadImage == DownloadImage.Always
                                || (downloadImage == DownloadImage.OnlyIfNotInCache && ImageInCache == false)
                                || ((downloadImage == DownloadImage.PreferCacheOnSlowLinks && ImageInCache == false) || Lfx.Workspace.Master.SlowLink == false))
			{
				//Download image and save to cache
				Lfx.Data.Row ImagenDB = dataBase.Row("articulos_categorias", "imagen", "id_categoria", categoryId);

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

		public static string CodigoPredet(Lfx.Workspace workspace)
		{
			return CodigoPredet(workspace, null);
		}

		public static string CodigoPredet(Lfx.Workspace workspace, Lfx.Data.Row Articulo)
		{
			// Devuelve el código predeterminado de un artículo
			// Si se pasa un registro artículo como parmetro, devuelve el valor del
			// De lo contrario, devuelve el nombre del campo
			// Espero que no se preste a confusin
			string CodPredet = workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema.Stock.CodigoPredet", "0");

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
