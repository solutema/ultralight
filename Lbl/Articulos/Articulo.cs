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
	public enum Tipos
	{
		Regular = 0,
		Compuesto = 1
	}

	public enum Publicacion
	{
		Nunca = 0,
		Siempre = 1,
		SoloSiHayStockOPedidos = 2
	}

	public class Articulo : ElementoDeDatos
	{
                public Lbl.Articulos.Categoria Categoria = null;
                public Lbl.Personas.Persona Proveedor = null;
                public Lbl.Articulos.Margen Margen = null;
                public Lbl.Articulos.Marca Marca = null;
                public Lbl.Cuentas.CuentaRegular Cuenta = null;
                private ColeccionItem m_ListaItem = null;

		//Heredar constructor
		public Articulo(Lws.Data.DataView dataView) : base(dataView) { }

		public Articulo(Lws.Data.DataView dataView, int idArticulo)
			: this(dataView)
		{
			m_ItemId = idArticulo;
		}

		public override string TablaDatos
		{
			get
			{
				return "articulos";
			}
		}

		public override string CampoId
		{
			get
			{
				return "id_articulo";
			}
		}

                public override string TablaImagenes
                {
                        get
                        {
                                return "articulos_imagenes";
                        }
                }

		public string Codigo1
		{
			get
			{
				return this.FieldString("codigo1");
			}
			set
			{
				Registro["codigo1"] = value;
			}
		}

		public string Codigo2
		{
			get
			{
				return this.FieldString("codigo2");
			}
			set
			{
				Registro["codigo2"] = value;
			}
		}

		public string Codigo3
		{
			get
			{
				return this.FieldString("codigo3");
			}
			set
			{
				Registro["codigo3"] = value;
			}
		}

		public string Codigo4
		{
			get
			{
				return this.FieldString("codigo4");
			}
			set
			{
				Registro["codigo4"] = value;
			}
		}

		public string Modelo
		{
			get
			{
				return this.FieldString("modelo");
			}
			set
			{
				Registro["modelo"] = value;
			}
		}

		public string Serie
		{
			get
			{
				return this.FieldString("serie");
			}
			set
			{
				Registro["serie"] = value;
			}
		}

		public string Unidad
		{
			get
			{
				return this.FieldString("unidad_stock");
			}
			set
			{
				Registro["unidad_stock"] = value;
			}
		}

		public string UnidadRendimiento
		{
			get
			{
				return this.FieldString("unidad_rend");
			}
			set
			{
				Registro["unidad_rend"] = value;
			}
		}

		public double Rendimiento
		{
			get
			{
				return this.FieldDouble("rendimiento");
			}
			set
			{
				Registro["rendimiento"] = value;
			}
		}

		public double StockMinimo
		{
			get
			{
				return this.FieldDouble("stock_minimo");
			}
			set
			{
				Registro["stock_minimo"] = value;
			}
		}

		public double PVP
		{
			get
			{
				return this.FieldDouble("pvp");
			}
			set
			{
				Registro["pvp"] = value;
			}
		}

		public string Url
		{
			get
			{
				return this.FieldString("url");
			}
			set
			{
				Registro["url"] = value;
			}
		}

		public string Descripcion
		{
			get
			{
				return this.FieldString("descripcion");
			}
			set
			{
				Registro["descripcion"] = value;
			}
		}

		public string Descripcion2
		{
			get
			{
				return this.FieldString("descripcion2");
			}
			set
			{
				Registro["descripcion2"] = value;
			}
		}

		public Tipos Tipo
		{
			get
			{
				return (Tipos)this.FieldInt("tipo");
			}
			set
			{
				Registro["tipo"] = value;
			}
		}

		public Publicacion Publicacion
		{
			get
			{
				return (Publicacion)this.FieldInt("web");
			}
			set
			{
				Registro["web"] = value;
			}
		}

		public bool Destacado
		{
			get
			{
				return System.Convert.ToBoolean(Registro["destacado"]);
			}
			set
			{
				Registro["destacado"] = value;
			}
		}

		public bool ControlaStock
		{
			get
			{
				return System.Convert.ToBoolean(Registro["control_stock"]);
			}
			set
			{
				Registro["control_stock"] = value;
			}
		}

                public int Garantia
                {
                        get
                        {
                                return this.FieldInt("garantia");
                        }
                        set
                        {
                                Registro["garantia"] = value;
                        }
                }

                public RequiereNS RequiereNS
                {
                        get
                        {
                                return this.Categoria == null ? RequiereNS.Nunca : this.Categoria.RequiereNS;
                        }
                }

                public ColeccionItem ListaItem
                {
                        get
                        {
                                if (m_ListaItem == null) {
                                        m_ListaItem = new ColeccionItem();
                                        System.Data.DataTable TablaListaItem = this.DataView.DataBase.Select("SELECT id_situacion, serie FROM articulos_series WHERE id_articulo=" + this.Id.ToString());
                                        foreach (System.Data.DataRow RowItem in TablaListaItem.Rows) {
                                                m_ListaItem.Add(new Item(RowItem["serie"].ToString(), new Situacion(this.DataView, System.Convert.ToInt32(RowItem["id_situacion"]))));
                                        }
                                }
                                return m_ListaItem;
                        }
                }

		public double StockActual()
		{
			return this.FieldDouble("stock_actual");
		}

		public double StockActual(Situacion situacion)
		{
			return this.DataView.DataBase.FieldDouble("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacion.Id.ToString());
		}

		
		public void MoverStock(double cantidad, string obs, Situacion situacionOrigen, Situacion situacionDestino, string series)
		{
                        if (this.ControlaStock) {
                                double CantidadEntranteOSalienteDeStock = 0;

                                string[] ListaSeries;
                                string ListaSeriesSql;
                                if (series != null) {
                                        series = series.Replace('\r', '\n');
                                        ListaSeries = series.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                        ListaSeriesSql = "'" + string.Join("', '", ListaSeries) + "'";
                                } else {
                                        ListaSeries = new string[0];
                                        ListaSeriesSql = "";
                                }

                                // stock saliente (situación de origen)
                                if (situacionOrigen != null && situacionOrigen.CuentaStock) {
                                        int Existe = this.DataView.DataBase.FieldInt("SELECT COUNT(id_articulo) FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionOrigen.Id.ToString());
                                        if (Existe == 0) {
                                                // No existen datos de stock para esta situación... la creo
                                                Lfx.Data.SqlInsertBuilder InsertarCantidadSituacion = new Lfx.Data.SqlInsertBuilder("articulos_stock");
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_situacion", situacionOrigen.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("cantidad", cantidad);
                                                this.DataView.Execute(InsertarCantidadSituacion);
                                        } else {
                                                // Actualizo el stock en la nueva situación
                                                Lfx.Data.SqlUpdateBuilder ActualizarCantidadSituacion = new Lfx.Data.SqlUpdateBuilder("articulos_stock");
                                                ActualizarCantidadSituacion.Fields.AddWithValue("cantidad", new Lfx.Data.SqlExpression(@"""cantidad""-" + Lfx.Types.Formatting.FormatStockSql(cantidad)));
                                                ActualizarCantidadSituacion.WhereClause = new Lfx.Data.SqlWhereBuilder(Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd);
                                                ActualizarCantidadSituacion.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_articulo", this.Id));
                                                ActualizarCantidadSituacion.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_situacion", situacionOrigen.Id));
                                                this.DataView.Execute(ActualizarCantidadSituacion);
                                        }

                                        if (series != null && series.Length > 0) {
                                                // Quito los series de la situación
                                                Lfx.Data.SqlDeleteBuilder QuitarSeries = new Lfx.Data.SqlDeleteBuilder("articulos_series");
                                                QuitarSeries.WhereClause = new Lfx.Data.SqlWhereBuilder(Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd);
                                                QuitarSeries.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_articulo", this.Id));
                                                QuitarSeries.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_situacion", situacionOrigen.Id));
                                                QuitarSeries.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("serie", Lfx.Data.SqlCommandBuilder.SqlOperands.In, new Lfx.Data.SqlExpression(ListaSeriesSql)));
                                                this.DataView.Execute(QuitarSeries);
                                        }

                                        CantidadEntranteOSalienteDeStock -= cantidad;
                                }

                                // stock entrante (situación de destino)
                                if (situacionDestino != null && situacionDestino.CuentaStock) {
                                        int Existe = this.DataView.DataBase.FieldInt("SELECT COUNT(id_articulo) FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionDestino.Id.ToString());
                                        if (Existe == 0) {
                                                // No existen datos de stock para esta situación... la creo
                                                Lfx.Data.SqlInsertBuilder InsertarCantidadSituacion = new Lfx.Data.SqlInsertBuilder("articulos_stock");
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_situacion", situacionDestino.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("cantidad", cantidad);
                                                this.DataView.Execute(InsertarCantidadSituacion);
                                        } else {
                                                // Actualizo el stock en la nueva situación
                                                Lfx.Data.SqlUpdateBuilder ActualizarCantidadSituacion = new Lfx.Data.SqlUpdateBuilder("articulos_stock");
                                                ActualizarCantidadSituacion.Fields.AddWithValue("cantidad", new Lfx.Data.SqlExpression(@"""cantidad""+" + Lfx.Types.Formatting.FormatStockSql(cantidad)));
                                                ActualizarCantidadSituacion.WhereClause = new Lfx.Data.SqlWhereBuilder(Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd);
                                                ActualizarCantidadSituacion.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_articulo", this.Id));
                                                ActualizarCantidadSituacion.WhereClause.Conditions.Add(new Lfx.Data.SqlCondition("id_situacion", situacionDestino.Id));
                                                this.DataView.Execute(ActualizarCantidadSituacion);
                                        }

                                        // Inserto los series en la situación
                                        foreach (string Ser in ListaSeries) {
                                                Lfx.Data.SqlInsertBuilder InsertarSerie = new Lfx.Data.SqlInsertBuilder("articulos_series");
                                                InsertarSerie.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarSerie.Fields.AddWithValue("id_situacion", situacionDestino.Id);
                                                InsertarSerie.Fields.AddWithValue("serie", Ser);
                                                this.DataView.Execute(InsertarSerie);        
                                        }

                                        CantidadEntranteOSalienteDeStock += cantidad;
                                }

                                if (CantidadEntranteOSalienteDeStock != 0) {
                                        Lfx.Data.SqlUpdateBuilder ActualizarCantidad = new Lfx.Data.SqlUpdateBuilder("articulos");
                                        ActualizarCantidad.Fields.AddWithValue("stock_actual", new Lfx.Data.SqlExpression(@"""stock_actual""+" + Lfx.Types.Formatting.FormatStockSql(CantidadEntranteOSalienteDeStock)));
                                        ActualizarCantidad.WhereClause = new Lfx.Data.SqlWhereBuilder("id_articulo", this.Id);
                                        this.DataView.Execute(ActualizarCantidad);
                                        //this.DataView.DataBase.Execute("UPDATE articulos SET stock_actual=stock_actual+(" + Lfx.Types.Formatting.FormatNumberSql(CantidadMovida, this.DataView.Workspace.CurrentConfig.Products.StockDecimalPlaces) + ") WHERE id_articulo=" + this.Id.ToString());
                                }

                                if (this.Cuenta != null && this.Cuenta.Existe)
                                        this.Cuenta.Movimiento(true, 30000, "Movimiento de stock de artículo " + this.ToString(), this.Workspace.CurrentUser.Id, this.PVP * cantidad, Obs, 0, 0, string.Empty);
                        }

			double Saldo = this.DataView.DataBase.FieldDouble("SELECT stock_actual FROM articulos WHERE id_articulo=" + this.Id.ToString());

                        Lfx.Data.SqlTableCommandBuilder Comando; Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, "articulos_movim");
                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
			Comando.Fields.AddWithValue("id_articulo", this.Id);
			Comando.Fields.AddWithValue("cantidad", cantidad);
			if(situacionOrigen == null)
				Comando.Fields.AddWithValue("desdesituacion", DBNull.Value);
			else
				Comando.Fields.AddWithValue("desdesituacion", Lfx.Data.DataBase.ConvertZeroToDBNull(situacionOrigen.Id));
			if(situacionDestino == null)
				Comando.Fields.AddWithValue("haciasituacion", DBNull.Value);
			else
				Comando.Fields.AddWithValue("haciasituacion", Lfx.Data.DataBase.ConvertZeroToDBNull(situacionDestino.Id));
			Comando.Fields.AddWithValue("saldo", Saldo);
			Comando.Fields.AddWithValue("obs", obs);
                        Comando.Fields.AddWithValue("series", series);
			
			this.DataView.Execute(Comando);
		}

		public double Costo
		{
			get
			{
				return System.Convert.ToDouble(Registro["costo"]);
			}
			set
			{
				Registro["costo"] = value;
			}
		}

                public override Lfx.Types.OperationResult Crear()
                {
                        Lfx.Types.OperationResult Res = base.Crear();
                        this.Categoria = null;
                        this.Marca = null;
                        this.Cuenta = null;
                        this.Margen = null;
                        this.Proveedor = null;
                        this.ControlaStock = true;
                        int MargenPredet = this.DataView.DataBase.FieldInt("SELECT id_margen FROM margenes WHERE predet=1 AND estado<50");
                        if (MargenPredet > 0)
                                this.Margen = new Margen(this.DataView, MargenPredet);
                        return Res;
                }

                public override void OnLoad()
                {
                        base.OnLoad();

                        if (Registro["id_cat_articulo"] == null)
                                this.Categoria = null;
                        else
                                this.Categoria = new Categoria(this.DataView, System.Convert.ToInt32(Registro["id_cat_articulo"]));

                        if (Registro["id_marca"] == null)
                                this.Marca = null;
                        else
                                this.Marca = new Marca(this.DataView, System.Convert.ToInt32(Registro["id_marca"]));

                        if (Registro["id_cuenta"] == null)
                                this.Cuenta = null;
                        else
                                this.Cuenta = new Lbl.Cuentas.CuentaRegular(this.DataView, System.Convert.ToInt32(Registro["id_cuenta"]));

                        if (Registro["id_margen"] == null)
                                this.Margen = null;
                        else
                                this.Margen = new Margen(this.DataView, System.Convert.ToInt32(Registro["id_margen"]));

                        if (Registro["id_proveedor"] == null)
                                this.Proveedor = null;
                        else
                                this.Proveedor = new Lbl.Personas.Persona(this.DataView, System.Convert.ToInt32(Registro["id_proveedor"]));
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        double PrecioOriginal = 0;

                        if(this.Existe)
                                PrecioOriginal = System.Convert.ToDouble(this.RegistroOriginal["pvp"]);

			Lfx.Data.SqlTableCommandBuilder Comando;

                        if (this.Existe == false) {
				Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, this.TablaDatos);
				Comando.Fields.AddWithValue("fecha_creado", Lfx.Data.SqlFunctions.Now);
				Comando.Fields.AddWithValue("fecha_precio", Lfx.Data.SqlFunctions.Now);
			} else {
				Comando = new Lfx.Data.SqlUpdateBuilder(this.DataView.DataBase, this.TablaDatos);
                                Comando.WhereClause = new Lfx.Data.SqlWhereBuilder(this.CampoId, this.Id);
			}

                        Comando.Fields.AddWithValue("codigo1", this.Codigo1);
                        Comando.Fields.AddWithValue("codigo2", this.Codigo2);
                        Comando.Fields.AddWithValue("codigo3", this.Codigo3);
                        Comando.Fields.AddWithValue("codigo4", this.Codigo4);

                        if (this.Categoria == null)
                                Comando.Fields.AddWithValue("id_cat_articulo", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_cat_articulo", this.Categoria.Id);

                        if (this.Marca == null)
                                Comando.Fields.AddWithValue("id_marca", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_marca", this.Marca.Id);

                        if (this.Cuenta == null)
                                Comando.Fields.AddWithValue("id_cuenta", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_cuenta", this.Cuenta.Id);

                        Comando.Fields.AddWithValue("modelo", this.Modelo);
                        Comando.Fields.AddWithValue("serie", this.Serie);
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("url", this.Url);

                        if (this.Proveedor == null)
                                Comando.Fields.AddWithValue("id_proveedor", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_proveedor", this.Proveedor.Id);

                        Comando.Fields.AddWithValue("descripcion", this.Descripcion);
                        Comando.Fields.AddWithValue("descripcion2", this.Descripcion2);
                        Comando.Fields.AddWithValue("destacado", this.Destacado);
                        Comando.Fields.AddWithValue("costo", this.Costo);

                        if (this.Margen == null)
                                Comando.Fields.AddWithValue("id_margen", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_margen", this.Margen.Id);
                        
                        Comando.Fields.AddWithValue("pvp", this.PVP);
                        //control_stock, stock_minimo, unidad_stock, rendimiento, unidad_rend, estado, web, fecha_creado, fecha_precio
                        Comando.Fields.AddWithValue("control_stock", this.ControlaStock ? 1 : 0);
                        Comando.Fields.AddWithValue("stock_minimo", this.StockMinimo);
                        Comando.Fields.AddWithValue("unidad_stock", this.Unidad);
                        Comando.Fields.AddWithValue("rendimiento", this.Rendimiento);
                        Comando.Fields.AddWithValue("unidad_rend", this.UnidadRendimiento);
                        Comando.Fields.AddWithValue("garantia", this.Garantia);
                        Comando.Fields.AddWithValue("estado", this.Estado);
                        switch(this.Publicacion)
                        {
                                case Publicacion.Nunca:
                                        Comando.Fields.AddWithValue("web", 0);
                                        break;
                                case Publicacion.SoloSiHayStockOPedidos:
                                        Comando.Fields.AddWithValue("web", 1);
                                        break;
                                case Publicacion.Siempre:
                                default:
                                        Comando.Fields.AddWithValue("web", 2);
                                        break;
                        }

			this.AgregarTags(Comando);

                        this.DataView.Execute(Comando);

                        if (this.Existe == false) {
                                m_ItemId = this.DataView.DataBase.FieldInt("SELECT MAX(id_articulo) FROM articulos");
                        } else {
                                if (PrecioOriginal != System.Convert.ToDouble(this.Registro["pvp"])) {
                                        // Actualizo la fecha del precio
                                        this.DataView.DataBase.Execute("UPDATE articulos SET pvp=" + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(this.Registro["pvp"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces) + ", fecha_precio=NOW() WHERE id_articulo=" + this.Id.ToString());

                                        // Y creo un evento en el historial de precios
					Comando = new Lfx.Data.SqlInsertBuilder(this.DataView.DataBase, "articulos_precios");
                                        Comando.Fields.AddWithValue("id_articulo", this.Id);
                                        Comando.Fields.AddWithValue("costo", this.Costo);
					Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                        if (this.Margen == null)
                                                Comando.Fields.AddWithValue("id_margen", DBNull.Value);
                                        else
                                                Comando.Fields.AddWithValue("id_margen", this.Margen.Id);
                                        Comando.Fields.AddWithValue("pvp", this.PVP);
                                        Comando.Fields.AddWithValue("id_persona", this.Workspace.CurrentUser.Id);
                                        this.DataView.Execute(Comando);
                                }
                        }

                        if (this.m_ImagenCambio) {
                                if (this.Imagen == null) {
                                        this.DataView.DataBase.Execute("DELETE FROM " + this.TablaImagenes + " WHERE " + this.CampoId + "=" + this.Id.ToString());
                                } else {
                                        // Cargar imagen nueva
                                        System.IO.MemoryStream ByteStream = new System.IO.MemoryStream();
                                        this.Imagen.Save(ByteStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        byte[] ImagenBytes = ByteStream.ToArray();

                                        this.DataView.DataBase.Execute("DELETE FROM " + this.TablaImagenes + " WHERE " + this.CampoId + "=" + this.Id.ToString());

                                        Lfx.Data.SqlInsertBuilder InsertarImagen = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, this.TablaImagenes);
                                        InsertarImagen.Fields.AddWithValue("id_articulo", this.Id);
                                        InsertarImagen.Fields.AddWithValue("imagen", ImagenBytes);
                                        this.DataView.Execute(InsertarImagen);
                                }
                        }

                        return base.Guardar();
                }
	}
}