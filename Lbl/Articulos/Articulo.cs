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
        [Lbl.Atributos.Nomenclatura(NombreSingular = "Artículo", Grupo = "Artículos")]
        [Lbl.Atributos.Datos(TablaDatos = "articulos", CampoId = "id_articulo", TablaImagenes = "articulos_imagenes")]
        [Lbl.Atributos.Presentacion()]
	public class Articulo : ElementoDeDatos, IElementoConImagen
	{
                private Lbl.Articulos.Categoria m_Categoria = null;
                private Lbl.Personas.Persona m_Proveedor = null;
                private Lbl.Articulos.Margen m_Margen = null;
                private Lbl.Articulos.Marca m_Marca = null;
                private Lbl.Cajas.Caja m_Caja = null;
                private ColeccionItem m_ListaItem = null;
                private Receta m_Receta = null;
                public decimal ExistenciasInicial { get; set; }

		//Heredar constructor
		public Articulo(Lfx.Data.Connection dataBase) 
                        : base(dataBase) { }

		public Articulo(Lfx.Data.Connection dataBase, int itemId)
			: base(dataBase, itemId) { }

                public Articulo(Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                        : base(dataBase, row) { }


		public string Codigo1
		{
			get
			{
				return this.GetFieldValue<string>("codigo1");
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
				return this.GetFieldValue<string>("codigo2");
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
				return this.GetFieldValue<string>("codigo3");
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
				return this.GetFieldValue<string>("codigo4");
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
				return this.GetFieldValue<string>("modelo");
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
				return this.GetFieldValue<string>("serie");
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
				return this.GetFieldValue<string>("unidad_stock");
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
				return this.GetFieldValue<string>("unidad_rend");
			}
			set
			{
				Registro["unidad_rend"] = value;
			}
		}

                public decimal Rendimiento
		{
			get
			{
				return this.GetFieldValue<decimal>("rendimiento");
			}
			set
			{
				Registro["rendimiento"] = value;
			}
		}

                public decimal PuntoDeReposicion
		{
			get
			{
				return this.GetFieldValue<decimal>("stock_minimo");
			}
			set
			{
				Registro["stock_minimo"] = value;
			}
		}

                public decimal Pvp
		{
			get
			{
				return this.GetFieldValue<decimal>("pvp");
			}
			set
			{
				Registro["pvp"] = value;
			}
		}

                public NullableDateTime FechaPrecio
                {
                        get
                        {
                                return this.FieldDateTime("fecha_precio");
                        }
                }

                public NullableDateTime FechaAlta
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
				return this.GetFieldValue<string>("url");
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
				return this.GetFieldValue<string>("descripcion");
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
				return this.GetFieldValue<string>("descripcion2");
			}
			set
			{
				Registro["descripcion2"] = value;
			}
		}

		public Publicacion Publicacion
		{
			get
			{
				return (Publicacion)this.GetFieldValue<int>("web");
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

                public TiposDeArticulo TipoDeArticulo
		{
			get
			{
				return (TiposDeArticulo)(Registro.Fields["control_stock"].ValueInt);
			}
			set
			{
				Registro["control_stock"] = (int)value;
			}
		}


                /// <summary>
                /// Para los servicios: cómo o cada cuanto se facturan (por horas, por minutos, una vez al mes, etc.)
                /// </summary>
                public Periodicidad Periodicidad
                {
                        get
                        {
                                return (Periodicidad)(Registro.Fields["periodicidad"].ValueInt);
                        }
                        set
                        {
                                Registro["periodicidad"] = (int)value;
                        }
                }


                public int Garantia
                {
                        get
                        {
                                return this.GetFieldValue<int>("garantia");
                        }
                        set
                        {
                                Registro["garantia"] = value;
                        }
                }


                /// <summary>
                /// Para la trazabilidad por números de serie, o seguimiento por variaciones (como talles y colores).
                /// </summary>
                public Seguimientos Seguimiento
                {
                        get
                        {
                                return ((Seguimientos)(this.GetFieldValue<int>("seguimiento")));
                        }
                        set
                        {
                                this.Registro["seguimiento"] = (int)value;
                        }
                }


                /// <summary>
                /// Devuelve el modo de seguimiento para este artículo, o para la categoría si no se especificó un modo de seguimiento.
                /// Este método nunca devuelve "Predeterminado".
                /// </summary>
                /// <returns>El modo de seguimiento para este artículo.</returns>
                public Seguimientos ObtenerSeguimiento()
                {
                        if (this.Seguimiento == Seguimientos.Predeterminado)
                                return this.Categoria == null ? Seguimientos.Ninguno : this.Categoria.ObtenerSeguimiento();
                        else
                                return this.Seguimiento;
                }


                public Lbl.Impuestos.Alicuota ObtenerAlicuota()
                {
                        if (Lbl.Sys.Config.Empresa.SucursalActual.Localidad.Iva == Impuestos.SituacionIva.Exento)
                                return Lbl.Sys.Config.Empresa.AlicuotaPredeterminada;

                        if (this.Categoria != null) {
                                if (this.Categoria.Alicuota != null)
                                        return this.Categoria.Alicuota;
                                else if (this.Categoria.Rubro != null && this.Categoria.Rubro.Alicuota != null)
                                        return this.Categoria.Rubro.Alicuota;
                                else
                                        return Lbl.Sys.Config.Empresa.AlicuotaPredeterminada;
                        } else {
                                return Lbl.Sys.Config.Empresa.AlicuotaPredeterminada;
                        }
                }

                public ColeccionItem ListaItem
                {
                        get
                        {
                                if (m_ListaItem == null) {
                                        m_ListaItem = new ColeccionItem();
                                        using (System.Data.DataTable TablaListaItem = this.Connection.Select("SELECT id_situacion, serie FROM articulos_series WHERE id_articulo=" + this.Id.ToString())) {
                                                foreach (System.Data.DataRow RowItem in TablaListaItem.Rows) {
                                                        m_ListaItem.Add(new Item(RowItem["serie"].ToString(), new Situacion(this.Connection, System.Convert.ToInt32(RowItem["id_situacion"]))));
                                                }
                                        }
                                }
                                return m_ListaItem;
                        }
                }


                /// <summary>
                /// Las existencias actuales.
                /// </summary>
                public decimal Existencias
		{
                        get
                        {
                                if (this.Connection.SlowLink)
                                        return this.GetFieldValue<decimal>("stock_actual");
                                else
                                        return this.ObtenerExistencias();
                        }
		}


                /// <summary>
                /// La cantidad pedida, pendiente de arribo.
                /// </summary>
                public decimal Pedido
                {
                        get
                        {
                                return this.GetFieldValue<decimal>("pedido");
                        }
                }

                public decimal ObtenerCosto()
                {
                        if (this.TipoDeArticulo == Articulos.TiposDeArticulo.ProductoCompuesto && this.Receta != null) {
                                return Receta.Costo;
                        } else {
                                return this.Costo;
                        }
                }

                public decimal ObtenerExistencias()
                {
                        switch(this.TipoDeArticulo) {
                                case Articulos.TiposDeArticulo.Servicio:
                                        return 0;
                                case Articulos.TiposDeArticulo.ProductoSimple:
                                        return this.Connection.FieldDecimal(@"SELECT cantidad FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion IN (SELECT id_situacion FROM articulos_situaciones WHERE cuenta_stock<>0)");
                                case Articulos.TiposDeArticulo.ProductoCompuesto:
                                        // Calculo el stock según el elemento de la receta que se acabe primero
                                        return this.Connection.FieldDecimal(@"SELECT MIN(articulos.stock_actual / articulos_recetas.cantidad) FROM articulos_recetas, articulos WHERE articulos_recetas.id_item=articulos.id_articulo AND articulos_recetas.id_articulo=" + this.Id.ToString());
                                default:
                                        throw new Lfx.Types.DomainException("ObtenerExistencias(): No se pueden calcular las existencias para " + this.TipoDeArticulo.ToString());
                        }
                }

                public decimal ObtenerExistencias(Situacion situacion)
		{
                        switch (this.TipoDeArticulo) {
                                case Articulos.TiposDeArticulo.Servicio:
                                        return 0;
                                case Articulos.TiposDeArticulo.ProductoSimple:
                                        return this.Connection.FieldDecimal("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacion.Id.ToString());
                                case Articulos.TiposDeArticulo.ProductoCompuesto:
                                        // Calculo el stock según el elemento de la receta que se acabe primero
                                        decimal CantMin = decimal.MaxValue;
                                        foreach (ItemReceta Itm in this.Receta) {
                                                decimal Cant = Itm.Articulo.ObtenerExistencias(situacion) / Itm.Cantidad;
                                                if (Cant < CantMin)
                                                        CantMin = Cant;
                                        }
                                        if (CantMin == decimal.MaxValue)
                                                return 0;
                                        else
                                                return CantMin;
                                default:
                                        throw new Lfx.Types.DomainException("ObtenerExistencias(Situacion): No se pueden calcular las existencias para " + this.TipoDeArticulo.ToString());
                        }
		}


                public void MoverExistencias(Lbl.Comprobantes.ComprobanteConArticulos comprob, decimal cantidad, string obs, Situacion situacionOrigen, Situacion situacionDestino, Lbl.Articulos.ColeccionDatosSeguimiento seguimiento)
		{
                        decimal Saldo;

                        if (this.TipoDeArticulo != Articulos.TiposDeArticulo.Servicio) {
                                decimal CantidadEntranteOSaliente = 0;

                                // stock saliente (situación de origen)
                                if (situacionOrigen != null && situacionOrigen.CuentaExistencias) {
                                        int Existe = this.Connection.FieldInt("SELECT COUNT(id_articulo) FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionOrigen.Id.ToString());
                                        if (Existe == 0) {
                                                // No existen datos de stock para esta situación... la creo
                                                qGen.Insert InsertarCantidadSituacion = new qGen.Insert("articulos_stock");
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_situacion", situacionOrigen.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("cantidad", -cantidad);
                                                this.Connection.Execute(InsertarCantidadSituacion);
                                        } else {
                                                // Actualizo el stock en la nueva situación
                                                qGen.Update ActualizarCantidadSituacion = new qGen.Update("articulos_stock");
                                                ActualizarCantidadSituacion.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""-" + Lfx.Types.Formatting.FormatStockSql(cantidad)));
                                                ActualizarCantidadSituacion.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionOrigen.Id));
                                                this.Connection.Execute(ActualizarCantidadSituacion);
                                        }

                                        if (seguimiento != null) {
                                                // Resto las cantidades de la situación de origen
                                                foreach (Lbl.Articulos.DatosSeguimiento Dat in seguimiento) {
                                                        qGen.Update ActualizarSeries = new qGen.Update("articulos_series");
                                                        if (Dat.Cantidad > 0)
                                                                ActualizarSeries.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""-" + Lfx.Types.Formatting.FormatStockSql(Dat.Cantidad)));
                                                        else
                                                                ActualizarSeries.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""+" + Lfx.Types.Formatting.FormatStockSql(Dat.Cantidad)));
                                                        ActualizarSeries.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                        ActualizarSeries.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                        ActualizarSeries.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionOrigen.Id));
                                                        ActualizarSeries.WhereClause.Add(new qGen.ComparisonCondition("serie", Dat.Variacion));
                                                        this.Connection.Execute(ActualizarSeries);
                                                }
                                        }

                                        CantidadEntranteOSaliente -= cantidad;
                                }

                                // stock entrante (situación de destino)
                                if (situacionDestino != null && situacionDestino.CuentaExistencias) {
                                        int ExisteSituacion = this.Connection.FieldInt("SELECT COUNT(id_articulo) FROM articulos_stock WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionDestino.Id.ToString());
                                        if (ExisteSituacion == 0) {
                                                // No existen datos de stock para esta situación... la creo
                                                qGen.Insert InsertarCantidadSituacion = new qGen.Insert("articulos_stock");
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_articulo", this.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("id_situacion", situacionDestino.Id);
                                                InsertarCantidadSituacion.Fields.AddWithValue("cantidad", cantidad);
                                                this.Connection.Execute(InsertarCantidadSituacion);
                                        } else {
                                                // Actualizo el stock en la nueva situación
                                                qGen.Update ActualizarCantidadSituacion = new qGen.Update("articulos_stock");
                                                ActualizarCantidadSituacion.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""+" + Lfx.Types.Formatting.FormatStockSql(cantidad)));
                                                ActualizarCantidadSituacion.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                ActualizarCantidadSituacion.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionDestino.Id));
                                                this.Connection.Execute(ActualizarCantidadSituacion);
                                        }

                                        if (seguimiento != null) {
                                                // Agrego las cantidades en la situación de destino
                                                foreach (Lbl.Articulos.DatosSeguimiento Dat in seguimiento) {
                                                        int ExisteVariacion = this.Connection.FieldInt("SELECT COUNT(id_articulo) FROM articulos_series WHERE id_articulo=" + this.Id.ToString() + " AND id_situacion=" + situacionDestino.Id.ToString() + " AND serie='" + Dat.Variacion + "'");
                                                        if (ExisteVariacion > 0) {
                                                                qGen.Update ActualizarSeries = new qGen.Update("articulos_series");
                                                                if (Dat.Cantidad > 0)
                                                                        ActualizarSeries.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""+" + Lfx.Types.Formatting.FormatStockSql(Dat.Cantidad)));
                                                                else
                                                                        ActualizarSeries.Fields.AddWithValue("cantidad", new qGen.SqlExpression(@"""cantidad""+" + Lfx.Types.Formatting.FormatStockSql(Dat.Cantidad)));
                                                                ActualizarSeries.WhereClause = new qGen.Where(qGen.AndOr.And);
                                                                ActualizarSeries.WhereClause.Add(new qGen.ComparisonCondition("id_articulo", this.Id));
                                                                ActualizarSeries.WhereClause.Add(new qGen.ComparisonCondition("id_situacion", situacionDestino.Id));
                                                                ActualizarSeries.WhereClause.Add(new qGen.ComparisonCondition("serie", Dat.Variacion));
                                                                this.Connection.Execute(ActualizarSeries);
                                                        } else {
                                                                qGen.Insert InsertarSerie = new qGen.Insert("articulos_series");
                                                                InsertarSerie.Fields.AddWithValue("id_articulo", this.Id);
                                                                InsertarSerie.Fields.AddWithValue("id_situacion", situacionDestino.Id);
                                                                InsertarSerie.Fields.AddWithValue("serie", Dat.Variacion);
                                                                InsertarSerie.Fields.AddWithValue("cantidad", Dat.Cantidad);
                                                                this.Connection.Execute(InsertarSerie);
                                                        }
                                                }
                                        }

                                        CantidadEntranteOSaliente += cantidad;
                                }

                                // Actualizo el stock actual
                                if (CantidadEntranteOSaliente != 0) {
                                        qGen.Update ActualizarCantidad = new qGen.Update("articulos");
                                        ActualizarCantidad.Fields.AddWithValue("stock_actual", new qGen.SqlExpression(@"""stock_actual""+" + Lfx.Types.Formatting.FormatStockSql(CantidadEntranteOSaliente)));
                                        ActualizarCantidad.WhereClause = new qGen.Where("id_articulo", this.Id);
                                        this.Connection.Execute(ActualizarCantidad);

                                        // Si ees un artículo compuesto
                                        // Propagar los cambios de stock hacia abajo.
                                        // Es decir, hacer movimientos de stock de los ingredientes (sub artículos)
                                        if (this.TipoDeArticulo == Articulos.TiposDeArticulo.ProductoCompuesto) {
                                                string ObsSubItems = "Movim. s/salida de " + this.ToString();
                                                foreach (ItemReceta Itm in this.Receta) {
                                                        Itm.Articulo.MoverExistencias(comprob, Itm.Cantidad * cantidad, ObsSubItems, situacionOrigen, situacionDestino, seguimiento);
                                                }
                                        }

                                        // Propagar los cambios de stock hacia arriba.
                                        // Es decir, si este artículo es ingrediente en la receta de otros artículos, actualizar los artículos padre para que reflejen el cambio de stock de este ingrediente.
                                        ColeccionGenerica<Articulo> SuperArts = this.SuperArticulos();
                                        if (SuperArts != null) {
                                                foreach (Articulo SuperArt in SuperArts) {
                                                        qGen.Update UpdateSuperArt = new qGen.Update("articulos");
                                                        UpdateSuperArt.Fields.AddWithValue("stock_actual", SuperArt.ObtenerExistencias());
                                                        UpdateSuperArt.WhereClause = new qGen.Where("id_articulo", SuperArt.Id);
                                                        this.Connection.Execute(UpdateSuperArt);
                                                }
                                        }
                                }


                                if (this.Caja != null && this.Caja.Existe)
                                        this.Caja.Movimiento(true, Lbl.Cajas.Concepto.AjustesYMovimientos,
                                                "Movimiento de stock de artículo " + this.ToString(),
                                                new Lbl.Personas.Persona(this.Connection, Lbl.Sys.Config.Actual.UsuarioConectado.Id), this.Pvp * cantidad, Obs, null, null, null);

                                Saldo = this.Connection.FieldDecimal("SELECT stock_actual FROM articulos WHERE id_articulo=" + this.Id.ToString());
                        } else {
                                // No controla stock
                                Saldo = 0;
                        }

                        qGen.TableCommand Comando; Comando = new qGen.Insert(this.Connection, "articulos_movim");
                        Comando.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
			Comando.Fields.AddWithValue("id_articulo", this.Id);
			Comando.Fields.AddWithValue("cantidad", cantidad);
			if(situacionOrigen == null)
				Comando.Fields.AddWithValue("desdesituacion", null);
			else
				Comando.Fields.AddWithValue("desdesituacion", situacionOrigen.Id);
			if(situacionDestino == null)
                                Comando.Fields.AddWithValue("haciasituacion", null);
			else
				Comando.Fields.AddWithValue("haciasituacion", situacionDestino.Id);
			Comando.Fields.AddWithValue("saldo", Saldo);
			Comando.Fields.AddWithValue("obs", obs);
                        Comando.Fields.AddWithValue("series", seguimiento);
                        if (comprob == null)
                                Comando.Fields.AddWithValue("id_comprob", null);
                        else
                                Comando.Fields.AddWithValue("id_comprob", comprob.Id);
			
			this.Connection.Execute(Comando);
		}

                /// <summary>
                /// Devuelve una colección de artículos de los cuales este es un ingrediente.
                /// </summary>
                public ColeccionGenerica<Articulo> SuperArticulos()
                {
                        System.Data.DataTable SuperArticulos = this.Connection.Select("SELECT DISTINCT id_articulo FROM articulos_recetas WHERE id_item=" + this.Id.ToString());
                        if (SuperArticulos == null || SuperArticulos.Rows.Count == 0)
                                return null;
                        ColeccionGenerica<Articulo> Res = new ColeccionGenerica<Articulo>(this.Connection, SuperArticulos);
                        return Res;
                }


                /// <summary>
                /// El precio de costo o de compra.
                /// </summary>
                public decimal Costo
		{
			get
			{
				return this.GetFieldValue<decimal>("costo");
			}
			set
			{
				Registro["costo"] = value;
			}
		}


                /// <summary>
                /// La composición, sólo válida para productos compuestos.
                /// </summary>
                public Receta Receta
                {
                        get
                        {
                                if (m_Receta == null) {
                                        m_Receta = new Receta();
                                        if (this.Existe) {
                                                System.Data.DataTable Arts = this.Connection.Select("SELECT id_item, cantidad FROM articulos_recetas WHERE id_articulo=" + this.Id.ToString());
                                                foreach (System.Data.DataRow Art in Arts.Rows) {
                                                        ItemReceta Itm = new ItemReceta(new Articulo(this.Connection, System.Convert.ToInt32(Art["id_item"])), System.Convert.ToDecimal(Art["cantidad"]));
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

                public override void Crear()
                {
                        base.Crear();

                        this.Categoria = null;
                        this.Marca = null;
                        this.Caja = null;
                        this.Margen = null;
                        this.Proveedor = null;
                        this.Unidad = "u";
                        this.TipoDeArticulo = Articulos.TiposDeArticulo.ProductoSimple;
                        int MargenPredet = this.Connection.FieldInt("SELECT id_margen FROM margenes WHERE predet=1 AND estado<50");
                        if (MargenPredet > 0)
                                this.Margen = new Margen(this.Connection, MargenPredet);
                }

                public Categoria Categoria
                {
                        get
                        {
                                if (m_Categoria == null && this.GetFieldValue<int>("id_categoria") != 0)
                                        m_Categoria = new Categoria(this.Connection, this.GetFieldValue<int>("id_categoria"));
                                return m_Categoria;
                        }
                        set
                        {
                                m_Categoria = value;
                                this.SetFieldValue("id_caja_diaria", value);
                        }
                }

                public Marca Marca
                {
                        get
                        {
                                if (m_Marca == null && this.GetFieldValue<int>("id_marca") != 0)
                                        m_Marca = new Marca(this.Connection, this.GetFieldValue<int>("id_marca"));
                                return m_Marca;
                        }
                        set
                        {
                                m_Marca = value;
                                this.SetFieldValue("id_marca", value);
                        }
                }

                public Lbl.Cajas.Caja Caja
                {
                        get
                        {
                                if (m_Caja == null && this.GetFieldValue<int>("id_caja") != 0)
                                        m_Caja = this.GetFieldValue<Lbl.Cajas.Caja>("id_caja");
                                return m_Caja;
                        }
                        set
                        {
                                m_Caja = value;
                                this.SetFieldValue("id_caja", value);
                        }
                }

                public Margen Margen
                {
                        get
                        {
                                if (m_Margen == null && this.GetFieldValue<int>("id_margen") != 0)
                                        m_Margen = new Margen(this.Connection, this.GetFieldValue<int>("id_margen"));
                                return m_Margen;
                        }
                        set
                        {
                                m_Margen = value;
                                this.SetFieldValue("id_margen", value);
                        }
                }

                public Lbl.Personas.Persona Proveedor
                {
                        get
                        {
                                if (m_Proveedor == null && this.GetFieldValue<int>("id_proveedor") != 0)
                                        m_Proveedor = this.GetFieldValue<Lbl.Personas.Persona>("id_proveedor");
                                return m_Proveedor;
                        }
                        set
                        {
                                m_Proveedor = value;
                                this.SetFieldValue("id_proveedor", value);
                        }
                }


                public override Lfx.Types.OperationResult Guardar()
                {
                        decimal PvpOriginal = 0, CostoOriginal = 0;

                        if (this.Existe) {
                                PvpOriginal = System.Convert.ToDecimal(this.RegistroOriginal["pvp"]);
                                CostoOriginal = System.Convert.ToDecimal(this.RegistroOriginal["costo"]);
                        }

			qGen.TableCommand Comando;

                        if (this.Existe == false) {
				Comando = new qGen.Insert(this.Connection, this.TablaDatos);
				Comando.Fields.AddWithValue("fecha_creado", qGen.SqlFunctions.Now);
				Comando.Fields.AddWithValue("fecha_precio", qGen.SqlFunctions.Now);
			} else {
				Comando = new qGen.Update(this.Connection, this.TablaDatos);
                                Comando.WhereClause = new qGen.Where(this.CampoId, this.Id);
			}

                        Comando.Fields.AddWithValue("codigo1", this.Codigo1);
                        Comando.Fields.AddWithValue("codigo2", this.Codigo2);
                        Comando.Fields.AddWithValue("codigo3", this.Codigo3);
                        Comando.Fields.AddWithValue("codigo4", this.Codigo4);

                        if (this.Categoria == null)
                                Comando.Fields.AddWithValue("id_categoria", null);
                        else
                                Comando.Fields.AddWithValue("id_categoria", this.Categoria.Id);

                        if (this.Marca == null)
                                Comando.Fields.AddWithValue("id_marca", null);
                        else
                                Comando.Fields.AddWithValue("id_marca", this.Marca.Id);

                        if (this.Caja == null)
                                Comando.Fields.AddWithValue("id_caja", null);
                        else
                                Comando.Fields.AddWithValue("id_caja", this.Caja.Id);

                        Comando.Fields.AddWithValue("modelo", this.Modelo);
                        Comando.Fields.AddWithValue("serie", this.Serie);
                        Comando.Fields.AddWithValue("nombre", this.Nombre);
                        Comando.Fields.AddWithValue("url", this.Url);

                        if (this.Proveedor == null)
                                Comando.Fields.AddWithValue("id_proveedor", null);
                        else
                                Comando.Fields.AddWithValue("id_proveedor", this.Proveedor.Id);

                        Comando.Fields.AddWithValue("descripcion", this.Descripcion);
                        Comando.Fields.AddWithValue("descripcion2", this.Descripcion2);
                        Comando.Fields.AddWithValue("destacado", this.Destacado);
                        Comando.Fields.AddWithValue("costo", this.Costo);

                        if (this.Margen == null)
                                Comando.Fields.AddWithValue("id_margen", null);
                        else
                                Comando.Fields.AddWithValue("id_margen", this.Margen.Id);
                        
                        Comando.Fields.AddWithValue("pvp", this.Pvp);
                        Comando.Fields.AddWithValue("control_stock", (int)(this.TipoDeArticulo));
                        Comando.Fields.AddWithValue("seguimiento", (int)(this.Seguimiento));
                        Comando.Fields.AddWithValue("periodicidad", (int)(this.Periodicidad));
                        Comando.Fields.AddWithValue("stock_minimo", this.PuntoDeReposicion);
                        if (this.Existe)
                                Comando.Fields.AddWithValue("stock_actual", this.ObtenerExistencias());
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
                                case Publicacion.SoloSiHayExistenciasOPedidos:
                                        Comando.Fields.AddWithValue("web", 1);
                                        break;
                                case Publicacion.Siempre:
                                default:
                                        Comando.Fields.AddWithValue("web", 2);
                                        break;
                        }

			this.AgregarTags(Comando);

                        this.Connection.Execute(Comando);

                        if (this.Existe == false) {
                                this.ActualizarId();

                                if (this.ExistenciasInicial != 0)
                                        // Hago el movimiento de stock inicial
                                        this.MoverExistencias(null, this.ExistenciasInicial, "Creación del artículo - Existencias iniciales", null, new Situacion(this.Connection, 1), null);
                        } else {
                                if (CostoOriginal != this.Costo) {
                                        // Cambió el costo
                                        this.RecalcularCostoSuperArticulos();
                                }
                                if (PvpOriginal != this.Pvp) {
                                        // Cambió el PVP
                                        // Actualizo la fecha del precio
                                        qGen.Update ActualizarPrecio = new qGen.Update(this.TablaDatos);
                                        ActualizarPrecio.Fields.AddWithValue("pvp", this.Pvp);
                                        ActualizarPrecio.Fields.AddWithValue("fecha_precio", qGen.SqlFunctions.Now);
                                        ActualizarPrecio.WhereClause = new qGen.Where(this.CampoId, this.Id);
                                        this.Connection.Execute(ActualizarPrecio);

                                        // Y creo un evento en el historial de precios
					qGen.Insert AgregarAlHistorialDePrecios = new qGen.Insert(this.Connection, "articulos_precios");
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("id_articulo", this.Id);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("costo", this.Costo);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                        if (this.Margen == null)
                                                AgregarAlHistorialDePrecios.Fields.AddWithValue("id_margen", null);
                                        else
                                                AgregarAlHistorialDePrecios.Fields.AddWithValue("id_margen", this.Margen.Id);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("pvp", this.Pvp);
                                        AgregarAlHistorialDePrecios.Fields.AddWithValue("id_persona", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                                        this.Connection.Execute(AgregarAlHistorialDePrecios);
                                }
                        }

                        // Si hay una receta guardada, la elimino
                        qGen.Delete EliminarReceta = new qGen.Delete("articulos_recetas");
                        EliminarReceta.WhereClause = new qGen.Where("id_articulo", this.Id);
                        this.Connection.Execute(EliminarReceta);

                        // Guardar la receta del artículo, si corresponde
                        if (this.TipoDeArticulo == Articulos.TiposDeArticulo.ProductoCompuesto && this.Receta != null) {
                                foreach (ItemReceta Itm in this.Receta) {
                                        qGen.Insert InsertarItemReceta = new qGen.Insert(this.Connection, "articulos_recetas");
                                        InsertarItemReceta.Fields.AddWithValue("id_articulo", this.Id);
                                        InsertarItemReceta.Fields.AddWithValue("id_item", Itm.Articulo.Id);
                                        InsertarItemReceta.Fields.AddWithValue("cantidad", Itm.Cantidad);
                                        this.Connection.Execute(InsertarItemReceta);
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
                                foreach (Articulo SuperArt in SuperArts) {
                                        SuperArt.Cargar();
                                        qGen.Update UpdateSuperArt = new qGen.Update("articulos");
                                        UpdateSuperArt.Fields.AddWithValue("costo", SuperArt.ObtenerCosto());
                                        UpdateSuperArt.WhereClause = new qGen.Where("id_articulo", SuperArt.Id);
                                        this.Connection.Execute(UpdateSuperArt);
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