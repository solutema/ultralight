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

namespace Lbl.Sys
{
        public partial class Config
        {
                public class Moneda : Configuracion.SeccionConfiguracion
                {
                        public static Lbl.Entidades.Moneda MonedaPredeterminada { get; set; }

                        public static string Simbolo = "$";

                        /// <summary>
                        /// La cantidad de decimales para los precios de venta en general.
                        /// </summary>
                        public static int Decimales = 2;

                        /// <summary>
                        /// La cantidad de decimales para los precios de compra y de costo.
                        /// </summary>
                        public static int DecimalesCosto = 2;

                        /// <summary>
                        /// La cantidad de decimales para el importe final del comprobante.
                        /// </summary>
                        public static int DecimalesFinal = 2;

                        /// <summary>
                        /// La unidad monetaria mínima para el importe final de los comprobantes de venta.
                        /// Esto puede conicidir con el valor de la divisa monetaria más pequeña en circulación, para evitar dar cambio en
                        /// monedas que no existen. Por ejemplo, si la moneda más pequeña es de 5 centavos, este valor podría ser 0.05 para evitar
                        /// dar cambio de 1, 2, 3 y 4 centavos, que es imposible.
                        /// Ejemplos: 
                        ///     UnidadMonetariaMinima = 0        El importe final no se trunca.
                        ///     UnidadMonetariaMinima = 0.05     El importe final se trunca a 5 centavos, o sea algo que cuesta $ 1.18 se factura a $ 1.15.
                        ///     UnidadMonetariaMinima = 1        El importe final se trunca a 1 peso, o sea se eliminan los centavos.
                        /// </summary>
                        public static decimal UnidadMonetariaMinima = 0;
                }
        }
}
