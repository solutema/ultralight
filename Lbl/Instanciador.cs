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
using System.Reflection;

namespace Lbl
{
        /// <summary>
        /// Permite crear instancias de un objeto Lbl.ElementoDeDatos, o de una clase derivada, a partir de un registro o un id de registro.
        /// </summary>
        public static class Instanciador
        {
                internal static Assembly Ensamblado;

                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos nuevo.
                /// </summary>
                public static IElementoDeDatos Instanciar(Type tipo, Lfx.Data.Connection dataBase)
                {
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.Connection) });
                        Lbl.IElementoDeDatos Res = (Lbl.IElementoDeDatos)(TConstr.Invoke(new object[] { dataBase }));
                        return Res;
                }

                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos a partir de un registro de base de datos.
                /// </summary>
                public static IElementoDeDatos Instanciar(Type tipo, Lfx.Data.Connection dataBase, Lfx.Data.Row row)
                {
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.Connection), typeof(Lfx.Data.Row) });
                        Lbl.IElementoDeDatos Res = (Lbl.IElementoDeDatos)(TConstr.Invoke(new object[] { dataBase, row }));
                        return Res;
                }

                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos a partir de un id de registro.
                /// </summary>
                public static IElementoDeDatos Instanciar(Type tipo, Lfx.Data.Connection dataBase, int id)
                {
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.Connection), typeof(int) });
                        Lbl.IElementoDeDatos Res = (Lbl.IElementoDeDatos)(TConstr.Invoke(new object[] { dataBase, id }));
                        return Res;
                }

                /// <summary>
                /// Crea una instancia de un Lbl.ElementoDeDatos a partir de un registro de base de datos.
                /// </summary>
                public static T Instanciar<T>(Lfx.Data.Connection dataBase, Lfx.Data.Row row) where T : Lbl.ElementoDeDatos
                {
                        Type tipo = typeof(T);
                        System.Reflection.ConstructorInfo TConstr = tipo.GetConstructor(new Type[] { typeof(Lfx.Data.Connection), typeof(Lfx.Data.Row) });
                        return (T)(TConstr.Invoke(new object[] { dataBase, row }));
                }

                /// <summary>
                /// Infiere el tipo (derivado de Lbl.ElementoDeDatos) a partir del nombre de la tabla o el nombre del tipo.
                /// </summary>
                public static Type InferirTipo(string tablaOTipo)
                {
                        // Primero busco en los tipos registrados por los componentes
                        foreach (Lfx.Components.IRegisteredType tipo in Lfx.Components.Manager.RegisteredTypes) {
                                if (tipo.LblType.ToString() == tablaOTipo)
                                        return tipo.LblType;
                        }

                        switch(tablaOTipo) {
                                case "alicuotas":
                                case "Lbl.Impuestos.ObtenerAlicuota":
                                        return typeof(Lbl.Impuestos.Alicuota);
                                case "articulos":
                                case "Lbl.Articulos.Articulo":
                                        return typeof(Lbl.Articulos.Articulo);
                                case "articulos_categorias":
                                case "Lbl.Articulos.Categoria":
                                        return typeof(Lbl.Articulos.Categoria);
                                case "articulos_rubros":
                                case "Lbl.Articulos.Rubro":
                                        return typeof(Lbl.Articulos.Rubro);
                                case "articulos_situaciones":
                                case "Lbl.Articulos.Situacion":
                                        return typeof(Lbl.Articulos.Situacion);
                                case "bancos":
                                case "Lbl.Bancos.Banco":
                                        return typeof(Lbl.Bancos.Banco);
                                case "bancos_cheques":
                                case "Lbl.Bancos.Cheque":
                                        return typeof(Lbl.Bancos.Cheque);
                                case "cajas":
                                case "Lbl.Cajas.Caja":
                                        return typeof(Lbl.Cajas.Caja);
                                case "chequeras":
                                case "Lbl.Bancos.Chequera":
                                        return typeof(Lbl.Bancos.Chequera);
                                case "ciudades":
                                case "Lbl.Entidades.Localidad":
                                        return typeof(Lbl.Entidades.Localidad);
                                case "comprob":
                                case "comprobante":
                                case "Lbl.Comprobantes.ComprobanteConArticulos":
                                        return typeof(Lbl.Comprobantes.ComprobanteConArticulos);
                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                        return typeof(Lbl.Comprobantes.ComprobanteFacturable);
                                case "Lbl.Comprobantes.Factura":
                                case "FA":
                                case "FB":
                                case "FC":
                                case "FE":
                                case "FM":
                                case "FNCND":
                                        return typeof(Lbl.Comprobantes.Factura);
                                case "Lbl.Comprobantes.Ticket":
                                case "T":
                                        return typeof(Lbl.Comprobantes.Ticket);
                                case "Lbl.Comprobantes.ComprobanteDeCompra":
                                case "NP":
                                case "PD":
                                case "RP":
                                case "FP":
                                        return typeof(Lbl.Comprobantes.ComprobanteDeCompra);
                                case "Lbl.Comprobantes.NotaDeCredito":
                                case "NC":
                                case "NCA":
                                case "NCB":
                                case "NCC":
                                case "NCE":
                                case "NCM":
                                        return typeof(Lbl.Comprobantes.NotaDeCredito);
                                case "Lbl.Comprobantes.NotaDeDebito":
                                case "ND":
                                case "NDA":
                                case "NDB":
                                case "NDC":
                                case "NDE":
                                case "NDM":
                                        return typeof(Lbl.Comprobantes.NotaDeDebito);
                                case "Lbl.Comprobantes.Presupuesto":
                                case "PS":
                                        return typeof(Lbl.Comprobantes.Presupuesto);
                                case "Lbl.Comprobantes.Remito":
                                case "R":
                                        return typeof(Lbl.Comprobantes.Remito);
                                case "comprob_detalle":
                                case "Lbl.Comprobantes.DetalleArticulo":
                                        return typeof(Lbl.Comprobantes.DetalleArticulo);
                                case "conceptos":
                                case "Lbl.Cajas.Concepto":
                                        return typeof(Lbl.Cajas.Concepto);
                                case "documentos_tipos":
                                case "Lbl.Comprobantes.Tipo":
                                        return typeof(Lbl.Comprobantes.Tipo);
                                case "impresoras":
                                case "Lbl.Impresion.Impresora":
                                        return typeof(Lbl.Impresion.Impresora);
                                case "formaspago":
                                case "Lbl.Pagos.FormaDePago":
                                        return typeof(Lbl.Pagos.FormaDePago);
                                case "marcas":
                                case "Lbl.Articulos.Marca":
                                        return typeof(Lbl.Articulos.Marca);
                                case "margenes":
                                case "Lbl.Articulos.Margen":
                                        return typeof(Lbl.Articulos.Margen);
                                case "monedas":
                                case "Lbl.Entidades.Moneda":
                                        return typeof(Lbl.Entidades.Moneda);
                                case "personas":
                                case "Lbl.Personas.Persona":
                                        return typeof(Lbl.Personas.Persona);
                                case "Lbl.Personas.Usuario":
                                case "acceso":
                                        return typeof(Lbl.Personas.Usuario);
                                case "Lbl.Personas.Proveedor":
                                        return typeof(Lbl.Personas.Proveedor);
                                case "paises":
                                case "Lbl.Entidades.Pais":
                                        return typeof(Lbl.Entidades.Pais);
                                case "personas_grupos":
                                case "Lbl.Personas.Grupo":
                                        return typeof(Lbl.Personas.Grupo);
                                case "pvs":
                                case "Lbl.Comprobantes.PuntoDeVenta":
                                        return typeof(Lbl.Comprobantes.PuntoDeVenta);
                                case "recibos":
                                case "Lbl.Comprobantes.Recibo":
                                        return typeof(Lbl.Comprobantes.Recibo);
                                case "Lbl.Comprobantes.ReciboDeCobro":
                                case "RC":
                                        return typeof(Lbl.Comprobantes.ReciboDeCobro);
                                case "Lbl.Comprobantes.ReciboDePago":
                                case "RCP":
                                        return typeof(Lbl.Comprobantes.ReciboDePago);
                                case "situaciones":
                                case "Lbl.Impuestos.SituacionTributaria":
                                        return typeof(Lbl.Impuestos.SituacionTributaria);
                                case "sucursales":
                                case "Lbl.Entidades.Sucursal":
                                        return typeof(Lbl.Entidades.Sucursal);
                                case "sys_log":
                                case "Lbl.Sys.Log.Entry":
                                        return typeof(Lbl.Sys.Log.Entrada);
                                case "sys_permisos_objetos":
                                case "Lbl.Sys.Permisos.Objeto":
                                        return typeof(Lbl.Sys.Permisos.Objeto);
                                case "sys_permisos":
                                case "Lbl.Sys.Permisos.Permiso":
                                        return typeof(Lbl.Sys.Permisos.Permiso);
                                case "sys_plantillas":
                                case "Lbl.Impresion.Plantilla":
                                        return typeof(Lbl.Impresion.Plantilla);
                                case "tickets":
                                case "Lbl.Tareas.Tarea":
                                        return typeof(Lbl.Tareas.Tarea);
                                case "tickets_tipos":
                                case "Lbl.Tareas.Tipo":
                                        return typeof(Lbl.Tareas.Tipo);
                                case "tipo_doc":
                                case "Lbl.Entidades.ClaveUnica":
                                        return typeof(Lbl.Entidades.ClaveUnica);
                                default:
                                        // Intento cargarlo mediante reflexión
                                        if (Ensamblado == null)
                                                Ensamblado = System.Reflection.Assembly.LoadFrom("Lbl.dll");

                                        Type Tipo = Ensamblado.GetType(tablaOTipo);
                                        if (Tipo != null)
                                                return Tipo;

                                        throw new NotImplementedException("Lbl.Instanciador.InferirTipo(): No se reconoce la tabla o tipo " + tablaOTipo);
                        }
                }
        }
}