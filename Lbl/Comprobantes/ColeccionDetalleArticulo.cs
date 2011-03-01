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

using System.Collections.Generic;
using System.Text;

namespace Lbl.Comprobantes
{
        public class ColeccionDetalleArticulos : Lbl.ColeccionGenerica<DetalleArticulo>
        {
                public Lbl.Comprobantes.ComprobanteConArticulos Comprobante = null;

                public ColeccionDetalleArticulos(Lfx.Data.Connection dataBase)
                        : base(dataBase) { }

                public ColeccionDetalleArticulos(Lbl.Comprobantes.ComprobanteConArticulos comprobante)
                        : base(comprobante.Connection)
                {
                        this.Comprobante = comprobante;
                }

                public void AddWithValue(Lbl.Articulos.Articulo articulo, decimal cantidad, decimal unitario, string obs)
                {
                        DetalleArticulo Det = new DetalleArticulo(this.Comprobante);
                        Det.Articulo = articulo;
                        Det.Cantidad = cantidad;
                        Det.Unitario = unitario;
                        Det.Obs = obs;
                }

                public ColeccionDetalleArticulos Clone(ComprobanteConArticulos comprobante)
                {
                        ColeccionDetalleArticulos Res = new ColeccionDetalleArticulos(comprobante);
                        foreach (DetalleArticulo Det in this) {
                                // FIXME: debería clonar también Det
                                Res.Add(Det);
                        }
                        return Res;
                }

                new public ColeccionDetalleArticulos Clone()
                {
                        return this.Clone(this.Comprobante);
                }


                /// <summary>
                /// Unifica la lista de articulos. Cuando un artículo aparece 2 o más veces, que una sola instancia
                /// con la sumatoria de las cantidades (Si la lista consta de "2 manzanas, 3 naranjas y 1 manzana",
                /// esta función devuelve "3 manzanas y 3 naranjas").
                /// </summary>
                public ColeccionDetalleArticulos Unificar()
                {
                        ColeccionDetalleArticulos Res = new ColeccionDetalleArticulos(this.Comprobante);
                        foreach (DetalleArticulo Det in this) {
                                bool Encontre = false;
                                foreach (DetalleArticulo Det2 in Res) {
                                        if (Det2.IdArticulo == Det.IdArticulo
                                                && Det2.Unitario == Det.Unitario
                                                && Det2.Obs == Det.Obs
                                                && Det2.Nombre == Det.Nombre) {
                                                //Si ya existe, sumo la cantidad
                                                Encontre = true;
                                                Det2.Cantidad += Det.Cantidad;
                                        }
                                }

                                //Si no existe, lo agrego
                                if (Encontre == false)
                                        Res.Add(Det);
                        }
                        return Res;
                }


                /// <summary>
                /// Hace una lista de movimientos necesarios para convertir "original" en "this".
                /// </summary>
                public ColeccionDetalleArticulos Diferencia(ColeccionDetalleArticulos original)
                {
                        ColeccionDetalleArticulos Desde;
                        if (original == null)
                                Desde = new ColeccionDetalleArticulos(this.Comprobante);
                        else
                                Desde = original.Unificar();
                        ColeccionDetalleArticulos Hacia = this.Unificar();

                        ColeccionDetalleArticulos Res = new ColeccionDetalleArticulos(this.Comprobante);

                        foreach (DetalleArticulo DetHacia in Hacia) {
                                bool Encontre = false;
                                if (DetHacia.IdArticulo > 0) {
                                        foreach (DetalleArticulo DetDesde in Desde) {
                                                if (DetDesde.IdArticulo == DetHacia.IdArticulo) {
                                                        //Si existe lo modifico
                                                        DetalleArticulo Nuevo = DetDesde.Clone();
                                                        Nuevo.Cantidad = DetHacia.Cantidad - DetDesde.Cantidad;
                                                        if (Nuevo.Cantidad != 0)
                                                                Res.Add(Nuevo);
                                                        Encontre = true;
                                                        break;
                                                }
                                        }
                                }


                                //Si no existe (o no tiene código de artículo) lo agrego
                                if (Encontre == false)
                                        Res.Add(DetHacia.Clone());
                        }

                        //Ahora quito los que ya no están
                        foreach (DetalleArticulo DetDesde in Desde) {
                                bool Encontre = false;
                                foreach (DetalleArticulo DetHacia in Hacia) {
                                        if (DetHacia.IdArticulo == DetDesde.IdArticulo) {
                                                Encontre = true;
                                                break;
                                        }
                                }
                                if (Encontre == false) {
                                        //La cantidad negativa para quitar
                                        DetalleArticulo Nuevo = DetDesde.Clone();
                                        Nuevo.Cantidad = -DetDesde.Cantidad;
                                        Res.Add(Nuevo);
                                }                                        
                        }

                        return Res;
                }

                public Lbl.Articulos.ColeccionDatosSeguimiento DatosSeguimiento
                {
                        get
                        {
                                Lbl.Articulos.ColeccionDatosSeguimiento Res = new Lbl.Articulos.ColeccionDatosSeguimiento();
                                foreach (Lbl.Comprobantes.DetalleArticulo Art in this) {
                                        if (Art.DatosSeguimiento != null)
                                                Res.AddRange(Art.DatosSeguimiento);
                                }
                                return Res;
                        }
                }

                public override string ToString()
                {
                        string Res = null;
                        foreach (DetalleArticulo Det in this) {
                                if (Res == null)
                                        Res = Det.ToString();
                                else
                                        Res += System.Environment.NewLine + Det.ToString();
                        }
                        return Res;
                }
        }
}
