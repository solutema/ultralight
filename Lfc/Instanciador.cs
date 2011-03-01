#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
                        Lfc.FormularioEdicion Res = InstanciarFormularioEdicion(elemento.GetType().ToString());
                        Res.Connection = elemento.Connection;
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


                private static Type InferirFormularioListado(Type tipo)
                {
                        // Primero busco en los tipos registrados por los componentes
                        if (Lfx.Components.Manager.TiposRegistrados.ContainsKey(tipo)) {
                                Lfx.Components.FunctionInfo Func = Lfx.Components.Manager.TiposRegistrados[tipo];
                                return Func.Instancia.FormularioListado;
                        }

                        return InferirFormularioListado(tipo.ToString());
                }

                private static Type InferirFormularioListado(string tipoOTabla)
                {
                        switch (tipoOTabla) {
                                case "ALICUOTAS":
                                case "Lbl.Impuestos.ObtenerAlicuota":
                                        return typeof(Lfc.Alicuotas.Inicio);

                                case "CHEQUERAS":
                                case "Lbl.Bancos.Chequera":
                                        return typeof(Lfc.Bancos.Chequeras.Inicio);

                                case "CHEQUES":
                                case "Lbl.Bancos.Cheque":
                                        return typeof(Lfc.Bancos.Cheques.Inicio);

                                case "CAJA":
                                case "CAJAS":
                                case "Lbl.Cajas.Caja":
                                        return typeof(Lfc.Cajas.Admin.Inicio);

                                case "CLIENTE":
                                case "CLIENTES":
                                case "Lbl.Personas.Persona":
                                case "Lbl.Personas.Usuario":
                                        return typeof(Lfc.Personas.Inicio);

                                case "personas_grupos":
                                case "PERSONAS_GRUPOS":
                                case "Lbl.Personas.Grupo":
                                        return typeof(Lfc.Personas.Grupos.Inicio);

                                case "SUCURSAL":
                                case "SUCURSALES":
                                case "sucursales":
                                case "Lbl.Entidades.Sucursal":
                                        return typeof(Lfc.Sucursales.Inicio);

                                case "PLANTILLA":
                                case "PLANTILLAS":
                                case "sys_plantillas":
                                case "Lbl.Impresion.Plantilla":
                                        return typeof(Lfc.Comprobantes.Plantillas.Inicio);

                                case "PROVEEDOR":
                                case "PROVEEDORES":
                                case "Lbl.Personas.Proveedor":
                                        return typeof(Lfc.Personas.Inicio);

                                case "PV":
                                case "PVS":
                                case "pvs":
                                case "Lbl.Comprobantes.PuntoDeVenta":
                                        return typeof(Lfc.Pvs.Inicio);

                                case "ARTICULO":
                                case "ARTICULOS":
                                case "Lbl.Articulos.Articulo":
                                        return typeof(Lfc.Articulos.Inicio);

                                case "ARTICULO_CATEG":
                                case "ARTICULOS_CATEG":
                                case "Lbl.Articulos.Categoria":
                                        return typeof(Lfc.Articulos.Categorias.Inicio);

                                case "ARTICULO_RUBRO":
                                case "ARTICULO_RUBROS":
                                case "ARTICULOS_RUBRO":
                                case "ARTICULOS_RUBROS":
                                case "Lbl.Articulos.Rubro":
                                        return typeof(Lfc.Articulos.Rubros.Inicio);

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

                                case "VENCIMIENTO":
                                case "VENCIMIENTOS":
                                case "Lbl.Cajas.Vencimiento":
                                        return typeof(Lfc.Cajas.Vencimientos.Inicio);

                                default:
                                        throw new NotImplementedException();
                        }
                }

                public static Lfc.FormularioListado InstanciarFormularioListado(Type tipo)
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(tipo, Lbl.Sys.Permisos.Operaciones.Listar)) {
                                return Activator.CreateInstance(tipo, null) as Lfc.FormularioListado;
                        } else {
                                return null;
                        }
                }

                private static Lcc.Edicion.ControlEdicion InstanciarControlEdicion(Type tipo)
                {
                        return Activator.CreateInstance(tipo, null) as Lcc.Edicion.ControlEdicion;
                }

                /// <summary>
                /// Infiere el tipo de control de edición a partir del nombre de la tabla o del tipo.
                /// </summary>
                private static Type InferirControlEdicion(string nombreTablaOTipo)
                {
                        // Primero busco en los tipos registrados por los componentes
                        foreach (Type tipo in Lfx.Components.Manager.TiposRegistrados.Keys) {
                                if (tipo.ToString() == nombreTablaOTipo)
                                        return Lfx.Components.Manager.TiposRegistrados[tipo].Instancia.ControlEdicion;
                        }

                        switch (nombreTablaOTipo) {
                                case "alicuotas":
                                case "Lbl.Impuestos.ObtenerAlicuota":
                                        return typeof(Lfc.Alicuotas.Editar);
                                case "articulos":
                                case "Lbl.Articulos.Articulo":
                                        return typeof(Lfc.Articulos.Editar);
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
                                case "cajas":
                                case "Lbl.Cajas.Caja":
                                        return typeof(Lfc.Cajas.Admin.Editar);
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
                                case "personas":
                                case "Lbl.Personas.Persona":
                                case "Lbl.Personas.Proveedor":
                                        return typeof(Lfc.Personas.Editar);
                                case "Lbl.Personas.Usuario":
                                        return typeof(Lfc.Personas.Usuario);
                                case "personas_grupos":
                                case "Lbl.Personas.Grupo":
                                        return typeof(Lfc.Personas.Grupos.Editar);
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
                                //case "sys_log":
                                //        return typeof(Lbl.Sys.Log.Entry);
                                case "sys_plantillas":
                                case "Lbl.Impresion.Plantilla":
                                        return typeof(Lfc.Comprobantes.Plantillas.Editar);
                                case "tickets":
                                case "Lbl.Tareas.Tarea":
                                        return typeof(Lfc.Tareas.Editar);
                                //case "tickets_tipos":
                                //        return typeof(Lfc.Tareas.Tipos.Editar);
                                //case "tipo_doc":
                                //        return typeof(Lbl);
                                default:
                                        throw new NotImplementedException("Lfc.Instanciador.InferirControlEdicion(): No se reconoce la tabla o el tipo " + nombreTablaOTipo);
                        }
                }
        }
}
