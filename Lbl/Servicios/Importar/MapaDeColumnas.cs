#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
        public enum ConversionDeColumna
        {
                Ninguna,
                ConvertirAMayusculasYMinusculas,
                ConvertirAMinusculas,
                InterpretarNombreYApellido,
                InterpretarSql
        }

        /// <summary>
        /// Especifica cómo se "mapea" una columna de una tabla externa a una columna de una tabla de Lázaro.
        /// </summary>
        public class MapaDeColumna
        {
                public string ColumnaExterna, ColumnaLazaro;
                public object ValorPredeterminado = null;
                public ConversionDeColumna Conversion = ConversionDeColumna.Ninguna;
                public object ParametroConversion = null;
                public System.Collections.Generic.Dictionary<string, object> Reemplazos = new Dictionary<string, object>();

                public MapaDeColumna(string columnaExterna, string columnaLazaro)
                {
                        this.ColumnaExterna = columnaExterna;
                        this.ColumnaLazaro = columnaLazaro;
                }

                public MapaDeColumna(string columnaExterna, string columnaLazaro, object valorPredeterminado)
                        : this(columnaExterna, columnaLazaro)
                {
                        this.ValorPredeterminado = valorPredeterminado;
                }

                public MapaDeColumna(string columnaExterna, string columnaLazaro, ConversionDeColumna conversion)
                        : this(columnaExterna, columnaLazaro)
                {
                        this.Conversion = conversion;
                }
        }

        /// <summary>
        /// Contiene una lista de columnas a mapear en una tabla.
        /// </summary>
        public class MapaDeColumnas : System.Collections.Generic.List<MapaDeColumna>
        {
                public void AddWithValues(string columnaExterna, string columnaInterna)
                {
                        this.Add(new MapaDeColumna(columnaExterna, columnaInterna));
                }

                public void AddWithValues(string columnaExterna, string columnaInterna, object valorPredeterminado)
                {
                        this.Add(new MapaDeColumna(columnaExterna, columnaInterna, valorPredeterminado));
                }

                public void AddWithValues(string columnaExterna, string columnaInterna, ConversionDeColumna conversion)
                {
                        this.Add(new MapaDeColumna(columnaExterna, columnaInterna, conversion));
                }

                public MapaDeColumna this[string nombreColumnaExterna]
                {
                        get
                        {
                                foreach (MapaDeColumna Col in this) {
                                        if (Col.ColumnaExterna == nombreColumnaExterna)
                                                return Col;
                                }
                                return null;
                        }
                }
        }
}
