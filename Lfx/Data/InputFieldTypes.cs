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

using System;
using System.Collections.Generic;

namespace Lfx.Data
{
        public enum InputFieldTypes
        {
                /// <summary>
                /// Número entero de 32 bits que indica un identificador de registro autonumérico.
                /// </summary>
                Serial,
                /// <summary>
                /// Número entero de 32 bits que indica un identificador de registro relacionado con otra tabla.
                /// </summary>
                Relation,
                /// <summary>
                /// Numero entero de 32 bits.
                /// </summary>
                Integer,
                /// <summary>
                /// Numero de doble precisión.
                /// </summary>
                Numeric,
                /// <summary>
                /// Numero que indica un valor monetario.
                /// </summary>
                Currency,
                /// <summary>
                /// Texto de largo variable de hasta 200 caracteres.
                /// </summary>
                Text,
                /// <summary>
                /// Número entero dentro de una serie
                /// </summary>
                Set,
                /// <summary>
                /// Texto de largo variable de largo extendido.
                /// </summary>
                Memo,
                /// <summary>
                /// Año y mes.
                /// </summary>
                YearMonth,
                /// <summary>
                /// Fecha.
                /// </summary>
                Date,
                /// <summary>
                /// Fecha y hora.
                /// </summary>
                DateTime,
                /// <summary>
                /// Imagen (normalmente JPEG).
                /// </summary>
                Image,
                /// <summary>
                /// Datos binarios.
                /// </summary>
                Binary,
                /// <summary>
                /// Valor booleano que indica si/no (normalmente se traduce a un entero pequeño 1/0).
                /// </summary>
                Bool,
                /// <summary>
                /// Número entero comprendido dentro un conjunto determinado, cada uno asociado con una etiqueta.
                /// </summary>
                NumericSet,
                /// <summary>
                /// Valor alfanumérico comprendido dentro un conjunto determinado, cada uno asociado con una etiqueta.
                /// </summary>
                AlphanumericSet
        }
}
