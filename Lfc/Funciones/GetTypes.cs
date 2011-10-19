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

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Impuestos.Alicuota),
                                typeof(Lfc.Alicuotas.Inicio),
                                typeof(Lfc.Alicuotas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Articulos.Articulo),
                                typeof(Lfc.Articulos.Inicio),
                                typeof(Lfc.Articulos.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Articulos.Categoria),
                                typeof(Lfc.Articulos.Categorias.Inicio),
                                typeof(Lfc.Articulos.Categorias.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Articulos.Marca),
                                typeof(Lfc.Articulos.Marcas.Inicio),
                                typeof(Lfc.Articulos.Marcas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Articulos.Margen),
                                typeof(Lfc.Articulos.Margenes.Inicio),
                                typeof(Lfc.Articulos.Margenes.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Articulos.Rubro),
                                typeof(Lfc.Articulos.Rubros.Inicio),
                                typeof(Lfc.Articulos.Rubros.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Articulos.Situacion),
                                typeof(Lfc.Articulos.Situaciones.Inicio),
                                typeof(Lfc.Articulos.Situaciones.Editar)));
                        
                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Bancos.Cheque),
                                typeof(Lfc.Bancos.Cheques.Inicio),
                                typeof(Lfc.Bancos.Cheques.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Bancos.Chequera),
                                typeof(Lfc.Bancos.Chequeras.Inicio),
                                typeof(Lfc.Bancos.Chequeras.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Cajas.Caja),
                                typeof(Lfc.Cajas.Inicio),
                                typeof(Lfc.Cajas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Comprobantes.Comprobante),
                                typeof(Lfc.Comprobantes.Inicio),
                                typeof(Lfc.Comprobantes.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Comprobantes.Factura),
                                typeof(Lfc.Comprobantes.Inicio),
                                typeof(Lfc.Comprobantes.Facturas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Comprobantes.Presupuesto),
                                typeof(Lfc.Comprobantes.Inicio),
                                typeof(Lfc.Comprobantes.Presupuestos.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Comprobantes.Recibo),
                                typeof(Lfc.Comprobantes.Recibos.Inicio),
                                typeof(Lfc.Comprobantes.Recibos.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Comprobantes.PuntoDeVenta),
                                typeof(Lfc.Pvs.Inicio),
                                typeof(Lfc.Pvs.Editar)));

                       Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Impresion.Plantilla),
                                typeof(Lfc.Comprobantes.Plantillas.Inicio),
                                typeof(Lfc.Comprobantes.Plantillas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Personas.Persona),
                                typeof(Lfc.Personas.Inicio),
                                typeof(Lfc.Personas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Personas.Proveedor),
                                typeof(Lfc.Personas.Inicio),
                                typeof(Lfc.Personas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Personas.Usuario),
                                typeof(Lfc.Personas.Inicio),
                                typeof(Lfc.Personas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Personas.Grupo),
                                typeof(Lfc.Personas.Grupos.Inicio),
                                typeof(Lfc.Personas.Grupos.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Entidades.Sucursal),
                                typeof(Lfc.Sucursales.Inicio),
                                typeof(Lfc.Sucursales.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Tareas.Tarea),
                                typeof(Lfc.Tareas.Inicio),
                                typeof(Lfc.Tareas.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Tareas.Estado),
                                typeof(Lfc.Tareas.Estados.Inicio),
                                typeof(Lfc.Tareas.Estados.Editar)));

                        Res.Add(new Lfc.TipoRegistrado(
                                typeof(Lbl.Tareas.Tipo),
                                typeof(Lfc.Tareas.Tipos.Inicio),
                                typeof(Lfc.Tareas.Tipos.Editar)));

                        return Res;
                }
        }
}
