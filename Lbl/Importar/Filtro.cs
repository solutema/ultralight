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

namespace Lbl.Importar
{
        /// <summary>
        /// Describe un filtro de importación.
        /// </summary>
        public class Filtro
        {
                public Lws.Data.DataView DataView;
                public MapaDeTablas MapaDeTablas;

                // Tomar los siguientes valores como vacíos
                public System.Collections.Generic.List<Reemplazo> Reemplazos = new List<Reemplazo>();

                public Filtro(Lws.Data.DataView dataView)
                {
                        this.DataView = dataView;
                }

                /// <summary>
                /// Carga en memoria los datos a importar.
                /// </summary>
                public void Cargar()
                {
                        this.PrepararTablasLazaro();
                        this.CargarDatos();
                }

                /// <summary>
                /// Carga los datos desde el origen.
                /// </summary>
                public virtual void CargarDatos()
                {
                        throw new NotImplementedException("Los filtros deben implementar el método CargarDatos");
                }


                /// <summary>
                /// Incorpora en la base de datos los datos cargados en memoria.
                /// </summary>
                public virtual void Fusionar()
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
                        System.Console.WriteLine("Lbl.Importar.Filtro: Fusionando tabla " + mapa.TablaLazaro);
                        foreach (Lfx.Data.Row ImportedRow in mapa.ImportedRows) {
                                object ImportIdValue = ImportedRow.Fields[mapa.ColumnaIdLazaro].Value;
                                string ImportIdSqlValue;
                                if(ImportIdValue is string) {
                                        ImportIdSqlValue = "'" + ImportIdValue.ToString() + "'";
                                } else if (ImportIdValue is double || ImportIdValue is decimal) {
                                        ImportIdSqlValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(ImportIdValue));
                                } else if (ImportIdValue is double) {
                                        ImportIdSqlValue = Lfx.Types.Formatting.FormatNumberSql(System.Convert.ToDouble(ImportIdValue));
                                } else if (ImportIdValue is DateTime) {
                                        ImportIdSqlValue = "'" + Lfx.Types.Formatting.FormatDateTimeSql(System.Convert.ToDateTime(ImportIdValue)) + "'";
                                } else {
                                        ImportIdSqlValue = ImportIdValue.ToString();
                                }

                                Lbl.ElementoDeDatos Elem;
                                Lfx.Data.Row CurrentRow = this.DataView.DataBase.FirstRowFromSelect("SELECT * FROM " + mapa.TablaLazaro + " WHERE " + mapa.ColumnaIdLazaro + "=" + ImportIdSqlValue);
                                if (CurrentRow == null) {
                                        Elem = this.CrearElemento(mapa, ImportedRow);
                                        Elem.Registro[mapa.ColumnaIdLazaro] = ImportIdValue;
                                } else {
                                        Elem = this.CargarElemento(mapa, CurrentRow);
                                        foreach (MapaDeColumna mapaCol in mapa.MapaDeColumnas) {
                                                Elem.Registro[mapaCol.ColumnaLazaro] = ImportedRow.Fields[mapaCol.ColumnaLazaro].Value;
                                        }
                                }
                                
                                Elem.Guardar();
                        }
                }

                /// <summary>
                /// Procesa un registro según el mapa de columnas correspondiente a la tabla y devuelve un Lfx.Data.Row
                /// </summary>
                public virtual Lfx.Data.Row ProcesarRegistro(MapaDeTabla mapa, System.Data.DataRow row)
                {
                        Lfx.Data.Row Lrw = new Lfx.Data.Row();
                        Lrw.IsNew = true;
                        Lrw.Table = this.DataView.Tables[mapa.TablaLazaro];

                        foreach (MapaDeColumna Col in mapa.MapaDeColumnas) {
                                object FieldValue = null;
                                switch (Col.Conversion) {
                                        case ConversionDeColumna.ConvertirAMinusculas:
                                                FieldValue = row[Col.ColumnaExterna].ToString().ToLowerInvariant();
                                                break;
                                        case ConversionDeColumna.ConvertirAMayusculasYMinusculas:
                                                FieldValue = Lfx.Types.Strings.ULCase(row[Col.ColumnaExterna].ToString());
                                                break;
                                        case ConversionDeColumna.InterpretarNombreYApellido:
                                                FieldValue = Lfx.Types.Strings.ULCase(row[Col.ColumnaExterna].ToString());
                                                string Nombre = FieldValue.ToString();
                                                string Apellido = Lfx.Types.Strings.GetNextToken(ref Nombre, " ");
                                                Lrw["nombre"] = Nombre.Trim();
                                                Lrw["apellido"] = Apellido.Trim();
                                                if (Nombre.Length > 0 && Apellido.Length > 0)
                                                        FieldValue = Apellido + ", " + Nombre;
                                                break;
                                        case ConversionDeColumna.InterpretarSql:
                                                string Sql = Col.ParametroConversion.ToString();
                                                Sql = Sql.Replace("$VALOR$", row[Col.ColumnaExterna].ToString());
                                                Lfx.Data.Row Result = this.DataView.DataBase.FirstRowFromSelect(Sql);
                                                if (Result == null || Result[0] == null)
                                                        FieldValue = null;
                                                else
                                                        FieldValue = Result[0];
                                                break;
                                        case ConversionDeColumna.Ninguna:
                                                if (Col.ColumnaExterna != null) {
                                                        FieldValue = row[Col.ColumnaExterna];
                                                } else {
                                                        FieldValue = Col.ValorPredeterminado;
                                                }
                                                break;
                                        default:
                                                throw new NotImplementedException("Lbl.Importar.Filtro: no implementa ConversionDeColumna." + Col.Conversion.ToString());
                                }
                                Lfx.Data.Field Fld = new Lfx.Data.Field(Col.ColumnaLazaro, FieldValue);
                                Lrw.Fields.Add(Fld);
                        }

                        // El id de seguimiento de importación
                        Lrw[mapa.ColumnaIdLazaro] = row[mapa.ColumnaIdExterna];
                        
                        this.ProcesarRemplazos(mapa, ref Lrw);

                        return Lrw;
                }

                /// <summary>
                /// Prepara las tablas internas para recibir los datos importados.
                /// </summary>
                public void PrepararTablasLazaro()
                {
                        System.Collections.Generic.List<string> TablasModificadas = new List<string>();
                        System.Console.WriteLine("Lbl.Importar.Filtro: Preparando tablas internas...");
                        foreach (MapaDeTabla Map in this.MapaDeTablas) {
                                if (Map.ColumnaIdExterna != null) {
                                        Lfx.Data.TableStructure Tabla = Lfx.Data.DataBaseCache.DefaultCache.TableStructures[Map.TablaLazaro];
                                        if (Tabla.Columns.ContainsKey(Map.ColumnaIdLazaro) == false) {
                                                // Si la columna Id no existe, agrego un tag
                                                Lfx.Data.Tag ImportTag = new Lfx.Data.Tag(Map.TablaLazaro, Map.ColumnaIdLazaro, "ImportId");
                                                ImportTag.DataBase = this.DataView.DataBase;
                                                ImportTag.FieldType = Lfx.Data.DbTypes.VarChar;
                                                ImportTag.Nullable = true;
                                                this.DataView.Tables[Map.TablaLazaro].Tags.Add(ImportTag);
                                                ImportTag.Save();
                                                TablasModificadas.Add(Map.TablaLazaro);
                                                Lfx.Data.DataBaseCache.DefaultCache.CargarEstructuraDesdeXml(null);
                                        }
                                }
                        }

                        // Me aseguro de que los tags se incorporen a las estructuras de la base de datos
                        if (TablasModificadas.Count > 0) {
                                foreach (string NombreTabla in TablasModificadas) {
                                        Lfx.Data.TableStructure Tabla = Lfx.Data.DataBaseCache.DefaultCache.TableStructures[NombreTabla];
                                        this.DataView.DataBase.SetTableStructure(Tabla);
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
                public Lbl.ElementoDeDatos CrearElemento(MapaDeTabla mapa, Lfx.Data.Row row)
                {
                        System.Reflection.ConstructorInfo TConstr = mapa.TipoElemento.GetConstructor(new Type[] { typeof(Lws.Data.DataView), typeof(Lfx.Data.Row) });
                        object Elem = TConstr.Invoke(new object[] { this.DataView, row });
                        return (Lbl.ElementoDeDatos)Elem;
                }

                /// <summary>
                /// Carga un elemento existente desde la base de datos.
                /// </summary>
                /// <param name="mapa"></param>
                /// <param name="row"></param>
                /// <returns></returns>
                public Lbl.ElementoDeDatos CargarElemento(MapaDeTabla mapa, Lfx.Data.Row row)
                {
                        System.Reflection.ConstructorInfo TConstr = mapa.TipoElemento.GetConstructor(new Type[] { typeof(Lws.Data.DataView), typeof(int) });
                        object Elem = TConstr.Invoke(new object[] { this.DataView, row.Fields[this.DataView.Tables[mapa.TablaLazaro].PrimaryKey].ValueInt });
                        return (Lbl.ElementoDeDatos)Elem;
                }
        }
}
