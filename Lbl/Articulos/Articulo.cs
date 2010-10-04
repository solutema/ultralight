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
using System.Collections.Generic;
using System.Text;

namespace Lbl.Articulos
{
	public class Articulo : ElementoDeDatos
	{
                public Lbl.Articulos.Categoria Categoria = null;
                public Lbl.Personas.Persona Proveedor = null;
                public Lbl.Articulos.Margen Margen = null;
                public Lbl.Articulos.Marca Marca = null;
                public Lbl.Cajas.Caja Caja = null;
                private ColeccionItem m_ListaItem = null;
                private Receta m_Receta = null;

		//Heredar constructor
		public Articulo(Lfx.Data.DataBase dataBase) : base(dataBase) { }

		public Articulo(Lfx.Data.DataBase dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Articulo(Lfx.Data.DataBase dataBase, Lfx.Data.Row fromRow)
                        : base(dataBase, fromRow) { }

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

		public double Pvp
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

                public Lfx.Types.LDateTime FechaPrecio
                {
                        get
                        {
                                return this.FieldDateTime("fecha_precio");
                        }
                }

                public Lfx.Types.LDateTime FechaAlta
                {
                        get
                        {
                                return this.FieldDateTime("fecha_creado");
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

                public ControlStock ControlStock
		{
			get
			{
				return (ControlStock)(Registro.Fields["control_stock"].ValueInt);
			}
			set
			{
				Registro["control_stock"] = (int)value;
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

                public Seguimientos Seguimiento
                {
                        get
                        {
                                return this.Categoria == null ? Seguimientos.Ninguno : this.Categoria.Seguimiento;
                        }
                }

                public ColeccionItem ListaItem
                {
                        get
                        {
                                if (m_ListaItem == null) {
                                        m_ListaItem = new ColeccionItem();
                                        using (System.Data.DataTable TablaListaItem = this.DataBase.Select("SELECT id_situacion, serie FROM articulos_series WHERE id_articulo=" + this.Id.ToString())) {
                                                foreach (System.Data.DataRow RowItem in TablaListaItem.Rows) {
                                                        m_ListaItem.Add(new Item(RowItem["serie"].ToString(), new Situacion(this.DataBase, System.Convert.ToInt32(RowItem["id_situacion"]))));
                                                }
                                        }
                                }
                                return m_ListaItem;
                        }
                }

		public double StockActual
		{
                        get
                        {
                                if (this.DataBase.SlowLink)
                                        return this.FieldDouble("stock_actual");
                                else
                                        return this.ObtenerStockActual();
                        }
		}

                public double Pedido
                {
                        get
                        {
                                return this.FieldDouble("pedido");
                        }
                }

                public double ObtenerCosto()
                {
                        if (this.ControlStock == Articulos.ControlStock.Compuesto && this.Receta != null) {
                                return Receta.Costo;
                        } else {
                                return this.Costo;
                        }
                }

                public double ObtenerStockActual()
                {
                        switch(this.ControlStock) {
                                case Articulos.ControlStock.No:
                                        return 0;
                                case Articulos.ControlStock.Normal:
                                        return this.DataBase.FieldDouble(@"SELECT cantidad FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion IN (SELECT id_situacion FROM articulos_situaciones WHERE cuenta_stock<>0)");
                                case Articulos.ControlStock.Compuesto:
                                        // Calculo el stock según el elemento de la receta que se acabe primero
                                        return this.DataBase.FieldDouble(@"SELECT MIN(articulos.stock_actual / articulos_recetas.cantidad) FROM articulos_recetas, articulos WHERE articulos_recetas.id_item=articulos.id_articulo AND articulos_recetas.id_articulo=" + this.Id.ToString());
                                        /* double CantMin = double.MaxValue;
                                        foreach (ItemReceta Itm in this.Receta) {
                                                double Cant = Itm.Articulo.ObtenerStockActual() / Itm.Cantidad;
                                                if (Cant < CantMin)
                                                        CantMin = Cant;
                                        }
                                        if (CantMin == double.MaxValue)
                                                return 0;
                                        else
                                                return CantMin; */
                                default:
                                        throw new NotImplementedException("ObtenerStockActual(): No se puede calcular el stock para " + this.ControlStock.ToString());
                        }
                }

		public double ObtenerStockActual(Situacion situacion)
		{
                        switch (this.ControlStock) {
                                case Articulos.ControlStock.No:
                                        return 0;
                                case Articulos.ControlStock.Normal:
                                        return this.DataBase.FieldDouble("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacion.Id.ToString());
                                case Articulos.ControlStock.Compuesto:
                                        // Calculo el stock según el elemento de la receta que se acabe primero
                                        double CantMin = double.MaxValue;
                                        foreach (ItemReceta Itm in this.Receta) {
                                                double Cant = Itm.Articulo.ObtenerStockActual(situacion) / Itm.Cantidad;
                                                if (Cant < CantMin)
                                                        CantMin = Cant;
                                        }
                                        if (CantMin == double.MaxValue)
                                                return 0;
                                        else
                                                return CantMin;
                                default:
                                        throw new NotImplementedException("ObtenerStockActual(Situacion): No se puede calcular el stock para " + this.ControlStock.ToString());
                        }
		}

		
		public void MoverStock(double cantidad, string obs, Situacion situacionOrigen, Situacion situacionDestino, string series)
		{
                        if (this.ControlStock != Articulos.ControlStock.No) {
                                double CantidadEntranteOSalienteDeStock = 0;

                                string[] ListaSeries;
                                if (series != null) {
                                        series = series.Replace('\r', '\n');
                                        ListaSeries = series.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                } else {
                                        ListaSeries = new string[0];
                                }

                                // stock saliente (situación de origen)
                                if (situacionOrigen != null && situacionOrigen.CuentaStock) {
                                        int Existe = this.DataBase.FieldInt("SELECT COUNT(id_articulo) FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionOrigen.Id.ToString());
                                        if (Existe == 0) {
                                                // No existen datos de stock para esta situación... la creo
                                                qGen.Insert InsertarCantidadSituacion = new qGen.Insert("articulos_stock");
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_situacion", situacionOrigen.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("cantidad", cantidad);
                                                this.DataBase.Execute(InsertarCantidadSituacion);
                                        } else {
                                                // Actualizo el stock en la nueva situación
                                                qGen.Update ActualizarCantidadSituacion = new qGen.Update("articulos_stock");
                                                ActualizarCantidadSituacion.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""-" + Lfx.Types.Formatting.FormatStockSql(cantidad)));
                                                ActualizarCantidadSituacion.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionOrigen.Id));
                                                this.DataBase.Execute(ActualizarCantidadSituacion);
                                        }

                                        if (series != null && series.Length > 0) {
                                                // Quito los series de la situación
                                                qGen.Delete QuitarSeries = new qGen.Delete("articulos_series");
                                                QuitarSeries.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                QuitarSeries.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                QuitarSeries.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionOrigen.Id));
                                                QuitarSeries.WhereClause.Add(new qGen.ComparisonCondition("serie", qGen.ComparisonOperators.In, ListaSeries));
                                                this.DataBase.Execute(QuitarSeries);
                                        }

                                        CantidadEntranteOSalienteDeStock -= cantidad;
                                }

                                // stock entrante (situación de destino)
                                if (situacionDestino != null && situacionDestino.CuentaStock) {
                                        int Existe = this.DataBase.FieldInt("SELECT COUNT(id_articulo) FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionDestino.Id.ToString());
                                        if (Existe == 0) {
                                                // No existen datos de stock para esta situación... la creo
                                                qGen.Insert InsertarCantidadSituacion = new qGen.Insert("articulos_stock");
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_situacion", situacionDestino.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("cantidad", cantidad);
                                                this.DataBase.Execute(InsertarCantidadSituacion);
                                        } else {
                                                // Actualizo el stock en la nueva situación
                                                qGen.Update ActualizarCantidadSituacion = new qGen.Update("articulos_stock");
                                                ActualizarCantidadSituacion.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""+" + Lfx.Types.Formatting.FormatStockSql(cantidad)));
                                                ActualizarCantidadSituacion.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionDestino.Id));
                                                this.DataBase.Execute(ActualizarCantidadSituacion);
                                        }

                                        // Inserto los series en la situación
                                        foreach (string Ser in ListaSeries) {
                                                qGen.Insert InsertarSerie = new qGen.Insert("articulos_series");
                                                InsertarSerie.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarSerie.Fields.AddWithValue("id_situacion", situacionDestino.Id);
                                                InsertarSerie.Fields.AddWithValue("serie", Ser);
                                                this.DataBase.Execute(InsertarSerie);        
                                        }

                                        CantidadEntranteOSalienteDeStock += cantidad;
                                }

                                // Actualizo el stock actual
                                if (CantidadEntranteOSalienteDeStock != 0) {
                                        qGen.Update ActualizarCantidad = new qGen.Update("articulos");
                                        ActualizarCantidad.Fields.AddWithValue("stock_actual", new qGen.SqlExpression(@"""stock_actual""+" + Lfx.Types.Formatting.FormatStockSql(CantidadEntranteOSalienteDeStock)));
                                        ActualizarCantidad.WhereClause = new qGen.Where("id_articulo", this.Id);
                                        this.DataBase.Execute(ActualizarCantidad);

                                        // Si ees un artículo compuesto
                                        // Propagar los cambios de stock hacia abajo.
                                        // Es decir, hacer movimientos de stock de los ingredientes (sub-artículos)
                                        if (this.ControlStock == Articulos.ControlStock.Compuesto) {
                                                string ObsSubItems = "Movim. s/salida de " + this.ToString();
                                                foreach (ItemReceta Itm in this.Receta) {
                                                        Itm.Articulo.MoverStock(Itm.Cantidad * cantidad, ObsSubItems, situacionOrigen, situacionDestino, series);
                                                }
                                        }

                                        // Propagar los cambios de stock hacia arriba.
                                        // Es decir, si este artículo es ingrediente en la receta de otros artículos, actualizar los artículos padre para que reflejen el cambio de stock de este ingrediente.
                                        ColeccionGenerica<Articulo> SuperArts = this.SuperArticulos();
                                        if (SuperArts != null) {
                                                foreach (Articulo SuperArt in SuperArts.List) {
                                                        qGen.Update UpdateSuperArt = new qGen.Update("articulos");
                                                        UpdateSuperArt.Fields.AddWithValue("stock_actual", SuperArt.ObtenerStockActual());
                                                        UpdateSuperArt.WhereClause = new qGen.Where("id_articulo", SuperArt.Id);
                                                        this.DataBase.Execute(UpdateSuperArt);
                                                }
                                        }
                                }


                                if (this.Caja != null && this.Caja.Existe)
                                        this.Caja.Movimiento(true, 30000, "Movimiento de stock de artículo " + this.ToString(), this.Workspace.CurrentUser.Id, this.Pvp * cantidad, Obs, 0, 0, string.Empty);
                        }

			double Saldo = this.DataBase.FieldDouble("SELECT stock_actual FROM articulos WHERE id_articulo=" + this.Id.ToString());

                        qGen.TableCommand Comando; Comando = new qGen.Insert(this.DataBase, "articulos_movim");
                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
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
			
			this.DataBase.Execute(Comando);
		}

                /// <summary>
                /// Devuelve una colección de artículos de los cuales este es un ingrediente.
                /// </summary>
                public ColeccionGenerica<Articulo> SuperArticulos()
                {
                        System.Data.DataTable SuperArticulos = this.DataBase.Select("SELECT DISTINCT id_articulo FROM articulos_recetas WHERE id_item=" + this.Id.ToString());
                        if (SuperArticulos == null || SuperArticulos.Rows.Count == 0)
                                return null;
                        ColeccionGenerica<Articulo> Res = new ColeccionGenerica<Articulo>(this.DataBase, SuperArticulos);
                        return Res;
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

                public Receta Receta
                {
                        get
                        {
                                if (m_Receta == null) {
                                        m_Receta = new Receta();
                                        if (this.Existe) {
                                                System.Data.DataTable Arts = this.DataBase.Select("SELECT id_item, cantidad FROM articulos_recetas WHERE id_articulo=" + this.Id.ToString());
                                                foreach (System.Data.DataRow Art in Arts.Rows) {
                                                        ItemReceta Itm = new ItemReceta(new Articulo(this.DataBase, System.Convert.ToInt32(Art["id_item"])), System.Convert.ToDouble(Art["cantidad"]));
                                                        m_Receta.Add(Itm);
                                                }
                                        }
                                }
                                return m_Receta;
                        }
                        set
                        {
                                m_Receta = value;
                        }
                }

                public override Lfx.Types.OperationResult Crear()
                {
                        Lfx.Types.OperationResult Res = base.Crear();
                        this.Categoria = null;
                        this.Marca = null;
                        this.Caja = null;
                        this.Margen = null;
                        this.Proveedor = null;
                        this.Unidad = "u";
                        this.ControlStock = Articulos.ControlStock.Normal;
                        int MargenPredet = this.DataBase.FieldInt("SELECT id_margen FROM margenes WHERE predet=1 AND estado<50");
                        if (MargenPredet > 0)
                                this.Margen = new Margen(this.DataBase, MargenPredet);
                        return Res;
                }

                public override void OnLoad()
                {
                        base.OnLoad();

                        if (Registro["id_categoria"] == null)
                                this.Categoria = null;
                        else
                                this.Categoria = new Categoria(this.DataBase, this.FieldInt("id_categoria"));

                        if (Registro["id_marca"] == null)
                                this.Marca = null;
                        else
                                this.Marca = new Marca(this.DataBase, this.FieldInt("id_marca"));

                        if (Registro["id_caja"] == null)
                                this.Caja = null;
                        else
                                this.Caja = new Lbl.Cajas.Caja(this.DataBase, this.FieldInt("id_caja"));

                        if (Registro["id_margen"] == null)
                                this.Margen = null;
                        else
                                this.Margen = new Margen(this.DataBase, this.FieldInt("id_margen"));

                        if (Registro["id_proveedor"] == null)
                                this.Proveedor = null;
                        else
                                this.Proveedor = new Lbl.Personas.Persona(this.DataBase, this.FieldInt("id_proveedor"));
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        double PvpOriginal = 0, CostoOriginal = 0;

                        if (this.Existe) {
                                PvpOriginal = System.Convert.ToDouble(this.RegistroOriginal["pvp"]);
                                CostoOriginal = System.Convert.ToDouble(this.RegistroOriginal["costo"]);
                        }

			qGen.TableCommand Comando;

                        if (this.Existe == false) {
				Comando = new qGen.Insert(this.DataBase, this.TablaDatos);
				Comando.Fields.AddWithValue("fecha_creado", qGen.SqlFunctions.Now);
				Comando.Fields.AddWithValue("fecha_precio", qGen.SqlFunctions.Now);
			} else {
				Comando = new qGen.Update(this.DataBase, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
			}

                        Comando.Fields.AddWithValue("codigo1", this.Codigo1);
                        Comando.Fields.AddWithValue("codigo2", this.Codigo2);
                        Comando.Fields.AddWithValue("codigo3", this.Codigo3);
                        Comando.Fields.AddWithValue("codigo4", this.Codigo4);

                        if (this.Categoria == null)
                                Comando.Fields.AddWithValue("id_categoria", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_categoria", this.Categoria.Id);

                        if (this.Marca == null)
                                Comando.Fields.AddWithValue("id_marca", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_marca", this.Marca.Id);

                        if (this.Caja == null)
                                Comando.Fields.AddWithValue("id_caja", DBNull.Value);
                        else
                                Comando.Fields.AddWithValue("id_caja", this.Caja.Id);

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
                        
                        Comando.Fields.AddWithValue("pvp", this.Pvp);
                        //control_stock, stock_minimo, unidad_stock, rendimiento, unidad_rend, estado, web, fecha_creado, fecha_precio
                        Comando.Fields.AddWithValue("control_stock", (int)(this.ControlStock));
                        Comando.Fields.AddWithValue("stock_minimo", this.StockMinimo);
                        if (this.Existe)
                                Comando.Fields.AddWithValue("stock_actual", this.ObtenerStockActual());
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

                        this.DataBase.Execute(Comando);

                        if (this.Existe == false) {
                                m_ItemId = this.DataBase.FieldInt("SELECT LAST_INSERT_ID()");
                        } else {
                                if (CostoOriginal != System.Convert.ToDouble(this.Registro["costo"])) {
                                        // Cambió el costo
                                        this.RecalcularCostoSuperArticulos();
                                }
                                if (PvpOriginal != System.Convert.ToDouble(this.Registro["pvp"])) {
                                        // Cambió el PVP
                                        // Actualizo la fecha del precio
                                        qGen.Update ActualizarPrecio = new qGen.Update(this.TablaDatos);
                                        ActualizarPrecio.Fields.AddWithValue("pvp", this.Pvp);
                                        ActualizarPrecio.Fields.AddWithValue("fecha_precio", qGen.SqlFunctions.Now);
                                        ActualizarPrecio.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                        this.DataBase.Execute(ActualizarPrecio);

                                        // Y creo un evento en el historial de precios
					qGen.Insert AgregarAlHistorialDePrecios = new qGen.Insert(this.DataBase, "articulos_precios");
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("id_articulo", this.Id);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("costo", this.Costo);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                        if (this.Margen == null)
                                                AgregarAlHistorialDePrecios.Fields.AddWithValue("id_margen", null);
                                        else
                                                AgregarAlHistorialDePrecios.Fields.AddWithValue("id_margen", this.Margen.Id);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("pvp", this.Pvp);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("id_persona", this.Workspace.CurrentUser.Id);
                                        this.DataBase.Execute(AgregarAlHistorialDePrecios);
                                }
                        }

                        // Si hay una receta guardada, la elimino
                        qGen.Delete EliminarReceta = new qGen.Delete("articulos_recetas");
                        EliminarReceta.WhereClause = new qGen.Where("id_articulo", this.Id);
                        this.DataBase.Execute(EliminarReceta);

                        // Guardar la receta del artículo, si corresponde
                        if (this.ControlStock == Articulos.ControlStock.Compuesto && this.Receta != null) {
                                foreach (ItemReceta Itm in this.Receta) {
                                        qGen.Insert InsertarItemReceta = new qGen.Insert(this.DataBase, "articulos_recetas");
                                        InsertarItemReceta.Fields.AddWithValue("id_articulo", this.Id);
                                        InsertarItemReceta.Fields.AddWithValue("id_item", Itm.Articulo.Id);
                                        InsertarItemReceta.Fields.AddWithValue("cantidad", Itm.Cantidad);
                                        this.DataBase.Execute(InsertarItemReceta);
                                }
                        }

                        return base.Guardar();
                }

                /// <summary>
                /// Propaga los cambios de costo hacia arriba.
                /// Es decir, si este artículo es ingrediente en la receta de otros artículos, actualizar los artículos padre para que reflejen el cambio de costo de este ingrediente.
                /// </summary>
                public void RecalcularCostoSuperArticulos()
                {
                        ColeccionGenerica<Articulo> SuperArts = this.SuperArticulos();
                        if (SuperArts != null) {
                                foreach (Articulo SuperArt in SuperArts.List) {
                                        SuperArt.Cargar();
                                        qGen.Update UpdateSuperArt = new qGen.Update("articulos");
                                        UpdateSuperArt.Fields.AddWithValue("costo", SuperArt.ObtenerCosto());
                                        UpdateSuperArt.WhereClause = new qGen.Where("id_articulo", SuperArt.Id);
                                        this.DataBase.Execute(UpdateSuperArt);
                                        SuperArt.RecalcularCostoSuperArticulos();
                                }
                        }
                }

                public override string ToString()
                {
                        return this.Nombre;
                }
	}
}