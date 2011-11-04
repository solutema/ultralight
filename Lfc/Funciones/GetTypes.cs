#region License
// Copyright 2004-2011 Ernesto N. Carrea
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

namespace Lfc
{
        public class GetTypes : Lfx.Components.GetTypesFunction
        {
                public override object Create()
                {
                        Lfx.Components.RegisteredTypeCollection Res = new Lfx.Components.RegisteredTypeCollection();

                        // Ordenados por TipoLbl

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Impuestos.Alicuota),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Alicuotas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Alicuotas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Articulos.Articulo),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Articulos.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Articulos.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Bancos.Banco),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Bancos.Inicio))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Articulos.Categoria),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Articulos.Categorias.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Articulos.Categorias.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Articulos.Marca),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Articulos.Marcas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Articulos.Marcas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Articulos.Margen),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Articulos.Margenes.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Articulos.Margenes.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Articulos.Rubro),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Articulos.Rubros.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Articulos.Rubros.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Articulos.Situacion),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Articulos.Situaciones.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Articulos.Situaciones.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Bancos.ChequeEmitido),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Bancos.Cheques.InicioEmitidos)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Bancos.Cheques.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Bancos.ChequeRecibido),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Bancos.Cheques.InicioEmitidos)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Bancos.Cheques.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Bancos.Chequera),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Bancos.Chequeras.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Bancos.Chequeras.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Cajas.Caja),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Cajas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Cajas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Cajas.Concepto),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Cajas.Conceptos.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Cajas.Conceptos.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Comprobante),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.ComprobanteDeCompra),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Compra.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Compra.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));


                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.ComprobanteFacturable),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Facturas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Facturas.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Factura),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Facturas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Facturas.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.NotaDeCredito),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Facturas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Facturas.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.NotaDeDebito),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Facturas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Facturas.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Presupuesto),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Presupuestos.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Presupuestos.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorPresupuesto))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Recibo),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Recibos.Cobro.Inicio)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorRecibo))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.ReciboDeCobro),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Recibos.Cobro.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Recibos.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorRecibo))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.ReciboDePago),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Recibos.Pago.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Recibos.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorRecibo))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Remito),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Remitos.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Ticket),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Facturas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Facturas.Editar)),
                                        new Lfx.Components.Action("print", typeof(Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.PuntoDeVenta),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Pvs.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Pvs.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Comprobantes.Tipo),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Tipo.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Tipo.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Impresion.Impresora),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Impresoras.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Impresoras.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Entidades.Localidad),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Ciudades.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Ciudades.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Impresion.Plantilla),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Comprobantes.Plantillas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Comprobantes.Plantillas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Pagos.Cupon),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Tarjetas.Cupones.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Tarjetas.Cupones.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Pagos.FormaDePago),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Pagos.FormasDePago.Inicio))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Pagos.Plan),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Pagos.Planes.Inicio))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Personas.Grupo),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Personas.Grupos.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Personas.Grupos.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Personas.Persona),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Personas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Personas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Personas.Proveedor),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Personas.Proveedores.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Personas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Personas.Usuario),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Personas.Usuarios.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Personas.Usuarios.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Entidades.Sucursal),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Sucursales.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Sucursales.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Tareas.Tarea),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Tareas.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Tareas.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Tareas.Estado),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Tareas.Estados.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Tareas.Estados.Editar))
                                }));

                        Res.Add(new Lfx.Components.RegisteredType(
                                typeof(Lbl.Tareas.Tipo),
                                new Lfx.Components.ActionCollection() {
                                        new Lfx.Components.Action("list", typeof(Lfc.Tareas.Tipos.Inicio)),
                                        new Lfx.Components.Action("edit", typeof(Lfc.Tareas.Tipos.Editar))
                                }));

                        return Res;
                }
        }
}
