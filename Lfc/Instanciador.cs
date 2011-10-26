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

namespace Lfc
{
        public static class Instanciador
        {
                /// <summary>
                /// Crea un formulario de edición para el ElementoDeDatos proporcionado.
                /// </summary>
                /// <param name="elemento">El ElementoDeDatos que se quiere editar.</param>
                /// <returns>Un formulario derivado de Lfc.FormularioEdicion.</returns>
                public static Lfc.FormularioEdicion InstanciarFormularioEdicion(Lbl.IElementoDeDatos elemento)
                {
                        Lfc.FormularioEdicion Res = new Lfc.FormularioEdicion();
                        Type TipoControlEdicion = InferirControlEdicion(elemento.GetType());
                        Res.ControlUnico = InstanciarControlEdicion(TipoControlEdicion);
                        Res.FromRow(elemento);

                        return Res;
                }

                private static Lfc.FormularioEdicion InstanciarFormularioEdicion(string nombreTablaOTipo)
                {
                        Lfc.FormularioEdicion Res = new Lfc.FormularioEdicion();
                        Type TipoControlEdicion = InferirControlEdicion(nombreTablaOTipo);
                        Res.ControlUnico = InstanciarControlEdicion(TipoControlEdicion);

                        return Res;
                }


                public static Type InferirFormularioListado(Type tipo)
                {
                        Type Res = Lfx.Components.Manager.RegisteredTypes.GetHandler(tipo, "list");

                        if (Res != null)
                                return Res;
                        else
                                return InferirFormularioListado(tipo.ToString());
                }

                public static Type InferirFormularioListado(string tipoOTabla)
                {
                        switch (tipoOTabla) {
                                case "COMPROBANTE":
                                case "COMPROBANTES":
                                case "Lbl.Comprobantes.ComprobanteConArticulos":
                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                case "Lbl.Comprobantes.Factura":
                                case "Lbl.Comprobantes.Presupuesto":
                                case "Lbl.Comprobantes.NotaDeCredito":
                                case "Lbl.Comprobantes.NotaDeDebito":
                                        return typeof(Lfc.Comprobantes.Inicio);

                                case "Lbl.Comprobantes.ComprobanteDeCompra":
                                        return typeof(Lfc.Comprobantes.Compra.Inicio);

                                case "RECIBOS":
                                case "Lbl.Comprobantes.Recibo":
                                case "Lbl.Comprobantes.ReciboDeCobro":
                                        return typeof(Lfc.Comprobantes.Recibos.Inicio);

                                case "Lbl.Comprobantes.ReciboDePago":
                                        return typeof(Lfc.Comprobantes.Recibos.Inicio);

                                case "Lbl.Comprobantes.Tipo":
                                        return typeof(Lfc.Comprobantes.Tipo.Inicio);

                                case "Lbl.Impresion.Impresora":
                                        return typeof(Lfc.Comprobantes.Impresoras.Inicio);

                                case "MARCAS":
                                case "Lbl.Articulos.Marca":
                                        return typeof(Lfc.Articulos.Marcas.Inicio);

                                case "PD":
                                case "NP":
                                case "FP":
                                case "RP":
                                case "PEDIDOS":
                                        return typeof(Lfc.Comprobantes.Compra.Inicio);

                                case "CONCEPTO":
                                case "CONCEPTOS":
                                case "CAJAS_CONCEPTOS":
                                case "Lbl.Cajas.Concepto":
                                        return typeof(Lfc.Cajas.Conceptos.Inicio);

                                case "CIUDAD":
                                case "CIUDADES":
                                case "Lbl.Entidades.Localidad":
                                        return typeof(Lfc.Ciudades.Inicio);

                                case "TICKET":
                                case "TICKETS":
                                case "Lbl.Tareas.Tarea":
                                        return typeof(Lfc.Tareas.Inicio);

                                case "TICKETS_ESTADOS":
                                case "Lbl.Tareas.Estado":
                                        return typeof(Lfc.Tareas.Estados.Inicio);

                                case "TICKETS_TIPOS":
                                case "Lbl.Tareas.Tipos":
                                        return typeof(Lfc.Tareas.Tipos.Inicio);

                                case "VENCIMIENTO":
                                case "VENCIMIENTOS":
                                case "Lbl.Cajas.Vencimiento":
                                        return typeof(Lfc.Cajas.Vencimientos.Inicio);

                                case "Lbl.Pagos.Cupon":
                                        return typeof(Lfc.Tarjetas.Cupones.Editar);
                                
                                default:
                                        throw new NotImplementedException("Lfc.InferirFormularioListado: no se reconoce el tipo o tabla " + tipoOTabla);
                        }
                }

                public static Lfc.FormularioListado InstanciarFormularioListado(Type tipo)
                {
                        object Res = Activator.CreateInstance(tipo, null);
                        return Res as Lfc.FormularioListado;
                }

                private static Lcc.Edicion.ControlEdicion InstanciarControlEdicion(Type tipo)
                {
                        object Res = Activator.CreateInstance(tipo, null);
                        return Res as Lcc.Edicion.ControlEdicion;
                }


                private static Type InferirControlEdicion(Type tipo)
                {
                        Type Res = Lfx.Components.Manager.RegisteredTypes.GetHandler(tipo, "edit");

                        if (Res != null)
                                return Res;
                        else
                                return InferirControlEdicion(tipo.ToString());
                }

                /// <summary>
                /// Infiere el tipo de control de edición a partir del nombre de la tabla o del tipo.
                /// </summary>
                private static Type InferirControlEdicion(string nombreTablaOTipo)
                {
                        switch (nombreTablaOTipo) {
                                case "alicuotas":
                                case "Lbl.Impuestos.ObtenerAlicuota":
                                        return typeof(Lfc.Alicuotas.Editar);
                                case "articulos_categorias":
                                case "articulo_categ":
                                case "Lbl.Articulos.Categoria":
                                        return typeof(Lfc.Articulos.Categorias.Editar);
                                case "articulos_rubros":
                                case "Lbl.Articulos.Rubro":
                                        return typeof(Lfc.Articulos.Rubros.Editar);
                                //case "articulos_situaciones":
                                //        return typeof(Lfc.s);
                                //case "bancos":
                                //        return typeof(Lfc.Bancos.Banco);
                                case "bancos_cheques":
                                case "Lbl.Bancos.Cheque":
                                        return typeof(Lfc.Bancos.Cheques.Editar);
                                case "chequeras":
                                case "Lbl.Bancos.Chequera":
                                        return typeof(Lfc.Bancos.Chequeras.Editar);
                                case "ciudades":
                                case "ciudad":
                                case "Lbl.Entidades.Localidad":
                                        return typeof(Lfc.Ciudades.Editar);
                                case "comprob":
                                case "Lbl.Comprobantes.ComprobanteConArticulos":
                                        return typeof(Lfc.Comprobantes.Editar);
                                case "Lbl.Comprobantes.Presupuesto":
                                        return typeof(Lfc.Comprobantes.Presupuestos.Editar);
                                case "Lbl.Comprobantes.Factura":
                                case "Lbl.Comprobantes.NotaDeCredito":
                                case "Lbl.Comprobantes.NotaDeDebito":
                                case "Lbl.Comprobantes.Ticket":
                                case "Lbl.Comprobantes.ComprobanteFacturable":
                                        return typeof(Lfc.Comprobantes.Facturas.Editar);
                                case "Lbl.Comprobantes.ComprobanteDeCompra":
                                        return typeof(Lfc.Comprobantes.Compra.Editar);
                                case "Lbl.Comprobantes.Remito":
                                        return typeof(Lfc.Comprobantes.Editar);
                                case "Lbl.Comprobantes.Tipo":
                                        return typeof(Lfc.Comprobantes.Tipo.Editar);
                                case "impresoras":
                                case "Lbl.Impresion.Impresora":
                                        return typeof(Lfc.Comprobantes.Impresoras.Editar);
                                case "conceptos":
                                case "Lbl.Cajas.Concepto":
                                        return typeof(Lfc.Cajas.Conceptos.Editar);
                                //case "documentos_tipos":
                                //        return typeof(Lfc.);
                                case "formaspago":
                                case "Lbl.Pagos.FormaDePago":
                                        return typeof(Lbl.Pagos.FormaDePago);
                                case "marcas":
                                case "Lbl.Articulos.Marca":
                                        return typeof(Lfc.Articulos.Marcas.Editar);
                                //case "margenes":
                                //        return typeof(Lfc.Articulos.Margenes.Editar);
                                //case "moneda":
                                //        return typeof(Lbl);
                                case "tarjetas_cupon":
                                case "Lbl.Pagos.Cupon":
                                        return typeof(Lfc.Tarjetas.Cupones.Editar);
                                case "pvs":
                                case "Lbl.Comprobantes.PuntoDeVenta":
                                        return typeof(Lfc.Pvs.Editar);
                                case "recibos":
                                case "Lbl.Comprobantes.Recibo":
                                case "Lbl.Comprobantes.ReciboDeCobro":
                                case "Lbl.Comprobantes.ReciboDePago":
                                        return typeof(Lfc.Comprobantes.Recibos.Editar);
                                //case "situaciones":
                                //        return typeof(Lfc.Impuestos.Situaciones.Editar);
                                case "sucursales":
                                case "Lbl.Entidades.Sucursal":
                                        return typeof(Lfc.Sucursales.Editar);
                                case "sys_plantillas":
                                case "Lbl.Impresion.Plantilla":
                                        return typeof(Lfc.Comprobantes.Plantillas.Editar);
                                default:
                                        throw new NotImplementedException("Lfc.Instanciador.InferirControlEdicion(): No se reconoce la tabla o el tipo " + nombreTablaOTipo);
                        }
                }
        }
}
