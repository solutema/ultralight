#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lbl.Servicios.Importar
{
        /// <summary>
        /// Describe un filtro de importación.
        /// </summary>
        public class Filtro
        {
                public Opciones Opciones { get; set; }

                protected Lfx.Types.OperationProgress Progreso;
                public Lfx.Data.Connection Connection { get; set; }
                public ColeccionMapaDeTablas MapaDeTablas;
                public string Name = "Filtro de importación genérico";

                public IList<Reemplazo> Reemplazos = new List<Reemplazo>();

                protected IDictionary<string, IDictionary<string, object>> CacheConversiones = new Dictionary<string, IDictionary<string, object>>();

                public Filtro(Lfx.Data.Connection dataBase, Opciones opciones)
                {
                        this.Connection = dataBase;
                        this.Opciones = opciones;
                }


                public void Importar()
                {
                        this.Progreso = new Lfx.Types.OperationProgress("Importando datos de " + this.Name, "Se están importando los datos del filtro " + this.Name);
                        this.Progreso.Blocking = false;
                        this.Progreso.Begin();

                        this.PrepararTablasLazaro();
                        this.PreImportar();
                        this.CargarTodo();
                        this.FusionarTodo();
                        this.PostImportar();

                        this.Progreso.End();
                }


                public virtual void PreImportar()
                {
                }


                public virtual void PostImportar()
                {
                }

                /// <summary>
                /// Carga en memoria los datos a importar.
                /// </summary>
                public void CargarTodo()
                {
                        foreach (MapaDeTabla Map in MapaDeTablas) {
                                Map.ImportedRows = CargarTabla(Map);
                        }
                }


                public virtual IList<Lfx.Data.Row> CargarTabla(MapaDeTabla mapa)
                {
                        throw new NotImplementedException("El filtro " + this.Name + " debe implementar CargarTabla()");
                }


                /// <summary>
                /// Incorpora en la base de datos los datos cargados en memoria.
                /// </summary>
                public virtual void FusionarTodo()
                {
                        foreach (MapaDeTabla Mapa in this.MapaDeTablas) {
                                this.FusionarTabla(Mapa);
                        }
                }

                /// <summary>
                /// Incorpora en la base de datos los datos cargados en memoria para la tabla seleccionada.
                /// </summary>
                public virtual void FusionarTabla(MapaDeTabla mapa)
                {
                        Progreso.ChangeStatus("Incorporando " + mapa.ToString());
                        Progreso.Max = mapa.ImportedRows.Count;
                        foreach (Lfx.Data.Row ImportedRow in mapa.ImportedRows) {
                                object ImportIdValue = ImportedRow.Fields[mapa.ColumnaIdLazaro].Value;
                                string ImportIdSqlValue;
                                if(ImportIdValue is string) {
                                        ImportIdSqlValue = "'" + ImportIdValue.ToString() + "'";
                                } else if (ImportIdValue is decimal || ImportIdValue is double) {
                                        ImportIdSqlValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDecimal(ImportIdValue));
                                } else if (ImportIdValue is DateTime) {
                                        ImportIdSqlValue = "'" + Lfx.Types.Formatting.FormatDateTimeSql(System.Convert.ToDateTime(ImportIdValue)) + "'";
                                } else {
                                        ImportIdSqlValue = ImportIdValue.ToString();
                                }

                                Lfx.Data.Row CurrentRow = this.Connection.FirstRowFromSelect("SELECT * FROM " + mapa.TablaLazaro + " WHERE " + mapa.ColumnaIdLazaro + "=" + ImportIdSqlValue);
                                Lbl.IElementoDeDatos Elem = ConvertirRegistroEnElemento(mapa, ImportedRow, CurrentRow);

                                if (Elem != null) {
                                        this.GuardarElemento(mapa, Elem);

                                        if (this.Opciones.ImportarStock && Elem is Lbl.Articulos.Articulo && ImportedRow.Fields.Contains("stock_actual")) {
                                                // Actualizo el stock
                                                Lbl.Articulos.Articulo Art = Elem as Lbl.Articulos.Articulo;

                                                decimal StockActual = Art.ObtenerStockActual();
                                                decimal NuevoStock = System.Convert.ToDecimal(ImportedRow["stock_actual"]);
                                                decimal Diferencia = NuevoStock - StockActual;

                                                if (Diferencia != 0)
                                                        Art.MoverStock(Diferencia, "Stock importado desde " + this.Name, null, new Articulos.Situacion(this.Connection, this.Connection.Workspace.CurrentConfig.Productos.DepositoPredeterminado), null);
                                        }
                                }
                                Progreso.Advance(1);
                        }
                }


                /// <summary>
                /// Convierte un registro en un elemento de datos.
                /// </summary>
                /// <param name="mapa">El mapa del cual proviene el registro.</param>
                /// <param name="externalRow">El registro externo (importado).</param>
                /// <param name="internalRow">El registro interno (de Lázaro) o null si se está importando un elemento nuevo.</param>
                /// <returns>Un elemento de datos</returns>
                public virtual Lbl.IElementoDeDatos ConvertirRegistroEnElemento(MapaDeTabla mapa, Lfx.Data.Row externalRow, Lfx.Data.Row internalRow)
                {
                        Lbl.IElementoDeDatos Elem;

                        object ImportIdValue = externalRow.Fields[mapa.ColumnaIdLazaro].Value;
                        if (internalRow == null) {
                                Elem = this.CrearElemento(mapa, externalRow);
                                Elem.Registro[mapa.ColumnaIdLazaro] = ImportIdValue;
                        } else if (this.Opciones.ActualizarRegistros && mapa.ActualizaRegistros) {
                                Elem = this.CargarElemento(mapa, internalRow);
                                foreach (MapaDeColumna mapaCol in mapa.MapaDeColumnas) {
                                        Elem.Registro[mapaCol.ColumnaLazaro] = externalRow.Fields[mapaCol.ColumnaLazaro].Value;
                                }
                        } else {
                                Elem = null;
                        }

                        return Elem;
                }


                /// <summary>
                /// Procesa un registro según el mapa de columnas correspondiente a la tabla y devuelve un Lfx.Data.Row
                /// </summary>
                public Lfx.Data.Row ProcesarRegistro(MapaDeTabla mapa, System.Data.DataRow externalRow)
                {
                        Lfx.Data.Row internalRow = new Lfx.Data.Row();
                        internalRow.IsNew = true;
                        internalRow.Table = this.Connection.Tables[mapa.TablaLazaro];

                        foreach (MapaDeColumna Col in mapa.MapaDeColumnas) {
                                object FieldValue = null;
                                switch (Col.Conversion) {
                                        case ConversionDeColumna.ConvertirAMinusculas:
                                                FieldValue = externalRow[Col.ColumnaExterna].ToString().ToLowerInvariant();
                                                break;
                                        case ConversionDeColumna.ConvertirAMayusculasYMinusculas:
                                                FieldValue = externalRow[Col.ColumnaExterna].ToString().ToTitleCase();
                                                break;
                                        case ConversionDeColumna.InterpretarNombreYApellido:
                                                FieldValue = externalRow[Col.ColumnaExterna].ToString().ToTitleCase();
                                                string Nombre = FieldValue.ToString();
                                                string Apellido = Lfx.Types.Strings.GetNextToken(ref Nombre, " ");
                                                internalRow["nombre"] = Nombre.Trim();
                                                internalRow["apellido"] = Apellido.Trim();
                                                if (Nombre.Length > 0 && Apellido.Length > 0)
                                                        FieldValue = Apellido + ", " + Nombre;
                                                break;
                                        case ConversionDeColumna.InterpretarSql:
                                                string Sql = Col.ParametroConversion.ToString();
                                                string ClaveBuscada = externalRow[Col.ColumnaExterna].ToString();

                                                if (this.CacheConversiones.ContainsKey(Sql) && this.CacheConversiones[Sql].ContainsKey(ClaveBuscada)){
                                                        FieldValue = this.CacheConversiones[Sql][ClaveBuscada];
                                                } else {
                                                        Lfx.Data.Row Result = this.Connection.FirstRowFromSelect(Sql.Replace("$VALOR$", ClaveBuscada));
                                                        if (Result == null || Result[0] == null)
                                                                FieldValue = null;
                                                        else
                                                                FieldValue = Result[0];

                                                        if (this.CacheConversiones.ContainsKey(Sql) == false)
                                                                // Agrego esta conversión a la cache
                                                                this.CacheConversiones.Add(Sql, new Dictionary<string, object>());
                                                        this.CacheConversiones[Sql].Add(ClaveBuscada, FieldValue);
                                                }
                                                
                                                break;
                                        case ConversionDeColumna.Ninguna:
                                                if (Col.ColumnaExterna != null) {
                                                        FieldValue = externalRow[Col.ColumnaExterna];
                                                } else {
                                                        FieldValue = Col.ValorPredeterminado;
                                                }
                                                break;
                                        default:
                                                throw new NotImplementedException("Lbl.Servicios.Importar.Filtro: no implementa ConversionDeColumna." + Col.Conversion.ToString());
                                }
                                Lfx.Data.Field Fld = new Lfx.Data.Field(Col.ColumnaLazaro, FieldValue);
                                internalRow.Fields.Add(Fld);
                        }

                        // El id de seguimiento de importación
                        internalRow[mapa.ColumnaIdLazaro] = externalRow[mapa.ColumnaIdExterna];
                        
                        this.ProcesarRemplazos(mapa, ref internalRow);

                        return internalRow;
                }

                /// <summary>
                /// Prepara las tablas internas para recibir los datos importados.
                /// </summary>
                public void PrepararTablasLazaro()
                {
                        System.Collections.Generic.List<string> TablasModificadas = new List<string>();
                        System.Console.WriteLine("Lbl.Servicios.Importar.Filtro: Preparando tablas internas...");
                        foreach (MapaDeTabla Map in this.MapaDeTablas) {
                                if (Map.ColumnaIdExterna != null) {
                                        Lfx.Data.TableStructure Tabla = Lfx.Workspace.Master.Structure.Tables[Map.TablaLazaro];
                                        if (Tabla.Columns.ContainsKey(Map.ColumnaIdLazaro) == false) {
                                                // Si la columna Id no existe, agrego un tag
                                                Lfx.Data.Tag ImportTag = new Lfx.Data.Tag(Map.TablaLazaro, Map.ColumnaIdLazaro, "ImportId");
                                                ImportTag.DataBase = this.Connection;
                                                ImportTag.FieldType = Lfx.Data.DbTypes.VarChar;
                                                ImportTag.Nullable = true;
                                                this.Connection.Tables[Map.TablaLazaro].Tags.Add(ImportTag);
                                                ImportTag.Save();
                                                TablasModificadas.Add(Map.TablaLazaro);
                                                Lfx.Workspace.Master.Structure.LoadBuiltIn();
                                        }
                                }
                        }

                        // Me aseguro de que los tags se incorporen a las estructuras de la base de datos
                        if (TablasModificadas.Count > 0) {
                                foreach (string NombreTabla in TablasModificadas) {
                                        Lfx.Data.TableStructure Tabla = Lfx.Workspace.Master.Structure.Tables[NombreTabla];
                                        this.Connection.SetTableStructure(Tabla);
                                }
                        }
                }

                /// <summary>
                /// Realiza los reemplazos de la lista de reemplazos definidos para este filtro.
                /// </summary>
                public void ProcesarRemplazos(MapaDeTabla mapa, ref Lfx.Data.Row row)
                {
                        foreach (Lfx.Data.Field Fld in row.Fields) {
                                foreach (Reemplazo Rmp in this.Reemplazos) {
                                        if (Fld.DataType == Rmp.Tipo 
                                                && (Rmp.NombreCampo == null || Rmp.NombreCampo == Fld.ColumnName
                                                        || Rmp.NombreCampo == mapa.Archivo + ":" + Fld.ColumnName))
                                                Fld.Value = Rmp.Reemplazar(Fld.Value);
                                }
                        }
                }

                /// <summary>
                /// Crea un derivado de ElementoDeDatos del tipo correspondiente para el mapa de tabla actual a partir de un Lfx.Data.Row.
                /// </summary>
                /// <param name="mapa">El mapa de la tabla a la cual corresponde el registro.</param>
                /// <param name="row">El registro a partir del cual crear un ElementoDeDatos.</param>
                /// <returns>Un objeto de alguna clase derivada de ElementoDeDatos.</returns>
                protected Lbl.IElementoDeDatos CrearElemento(MapaDeTabla mapa, Lfx.Data.Row row)
                {
                        return Lbl.Instanciador.Instanciar(mapa.TipoElemento, this.Connection, row);
                }

                /// <summary>
                /// Carga un elemento existente desde la base de datos.
                /// </summary>
                /// <param name="mapa"></param>
                /// <param name="row"></param>
                /// <returns></returns>
                protected Lbl.IElementoDeDatos CargarElemento(MapaDeTabla mapa, Lfx.Data.Row row)
                {
                        return Lbl.Instanciador.Instanciar(mapa.TipoElemento, this.Connection, row.Fields[this.Connection.Tables[mapa.TablaLazaro].PrimaryKey].ValueInt);
                }


                /// <summary>
                /// Guarda un elemento.
                /// </summary>
                /// <param name="mapa"></param>
                /// <param name="elemento"></param>
                protected virtual void GuardarElemento(MapaDeTabla mapa, Lbl.IElementoDeDatos elemento)
                {
                        elemento.Guardar();
                }


                public override string ToString()
                {
                        return this.Name;
                }
        }
}
