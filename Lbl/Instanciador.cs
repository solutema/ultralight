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

namespace Lbl
{
        /// <summary>
        /// Permite crear instancias de un objeto Lbl.ElementoDeDatos, o de una clase derivada, a partir de un registro o un id de registro.
        /// </summary>
        public static class Instanciador
        {
                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos a partir de un registro de base de datos.
                /// </summary>
                public static ElementoDeDatos Instanciar(Type tipo, Lfx.Data.DataBase dataBase, Lfx.Data.Row row)
                {
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.DataBase), typeof(Lfx.Data.Row) });
                        return (Lbl.ElementoDeDatos)(TConstr.Invoke(new object[] { dataBase, row }));
                }

                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos a partir de un id de registro.
                /// </summary>
                public static ElementoDeDatos Instanciar(Type tipo, Lfx.Data.DataBase dataBase, int id)
                {
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.DataBase), typeof(int) });
                        return (Lbl.ElementoDeDatos)(TConstr.Invoke(new object[] { dataBase, id }));
                }

                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos a partir de un registro de base de datos.
                /// </summary>
                public static T Instanciar<T>(Lfx.Data.DataBase dataBase, Lfx.Data.Row row) where T : Lbl.ElementoDeDatos
                {
                        Type tipo = typeof(T);
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.DataBase), typeof(Lfx.Data.Row) });
                        return (T)(TConstr.Invoke(new object[] { dataBase, row }));
                }

                /// <summary>
                /// Infiere el tipo (derivado de Lbl.ElementoDeDatos) a partir del nombre de la tabla.
                /// </summary>
                public static Type InferirTipo(string tabla)
                {
                        switch(tabla) {
                                case "alicuotas":
                                        return typeof(Lbl.Impuestos.Alicuota);
                                case "articulos":
                                        return typeof(Lbl.Articulos.Articulo);
                                case "articulos_categorias":
                                        return typeof(Lbl.Articulos.Categoria);
                                case "articulos_rubros":
                                        return typeof(Lbl.Articulos.Rubro);
                                case "articulos_situaciones":
                                        return typeof(Lbl.Articulos.Situacion);
                                case "bancos":
                                        return typeof(Lbl.Bancos.Banco);
                                case "bancos_cheques":
                                        return typeof(Lbl.Bancos.Cheque);
                                case "cajas":
                                        return typeof(Lbl.Cajas.Caja);
                                case "chequeras":
                                        return typeof(Lbl.Bancos.Chequera);
                                case "ciudades":
                                        return typeof(Lbl.Entidades.Localidad);
                                case "comprob":
                                        return typeof(Lbl.Comprobantes.ColeccionComprobanteConArticulos);
                                case "comprob_detalle":
                                        return typeof(Lbl.Comprobantes.DetalleArticulo);
                                case "conceptos":
                                        return typeof(Lbl.Cajas.Concepto);
                                case "documentos_tipos":
                                        return typeof(Lbl.Comprobantes.Tipo);
                                case "formaspago":
                                        return typeof(Lbl.Pagos.FormaDePago);
                                case "marcas":
                                        return typeof(Lbl.Articulos.Marca);
                                case "margenes":
                                        return typeof(Lbl.Articulos.Margen);
                                //case "moneda":
                                //        return typeof(Lbl);
                                case "personas":
                                        return typeof(Lbl.Personas.Persona);
                                case "personas_grupos":
                                        return typeof(Lbl.Personas.Grupo);
                                case "pvs":
                                        return typeof(Lbl.Comprobantes.PuntoDeVenta);
                                case "recibos":
                                        return typeof(Lbl.Comprobantes.Recibo);
                                case "situaciones":
                                        return typeof(Lbl.Impuestos.SituacionTributaria);
                                case "sucursales":
                                        return typeof(Lbl.Entidades.Sucursal);
                                case "sys_log":
                                        return typeof(Lbl.Sys.Log.Entry);
                                case "sys_plantillas":
                                        return typeof(Lbl.Comprobantes.Impresion.Plantilla);
                                case "tickets":
                                        return typeof(Lbl.Tareas.Tarea);
                                case "tickets_tipos":
                                        return typeof(Lbl.Tareas.Tipo);
                                //case "tipo_doc":
                                //        return typeof(Lbl);
                                case "ventas_cuotas":
                                        return typeof(Lbl.Cuotas.Cuota);
                                case "ventas_resumens":
                                        return typeof(Lbl.Cuotas.Resumen);
                                
                                default:
                                        throw new NotImplementedException("Lbl.Instanciador.TipoDesdeTabla(): No se reconoce la tabla " + tabla);
                        }
                }
        }
}