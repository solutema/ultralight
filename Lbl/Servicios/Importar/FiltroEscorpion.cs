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

namespace Lbl.Servicios.Importar
{
        /// <summary>
        /// Describe un filtro de importación desde archivos DBF del sistema de Escorpión Sistemas.
        /// </summary>
        public class FiltroEscorpion : FiltroDbf
        {
                public FiltroEscorpion(Lfx.Data.DataBase dataBase)
                        : base(dataBase)
                {
                        this.FilterName = "Filtro de importación de Escorpión Sistemas";

                        this.Reemplazos.Add(new Reemplazo("NO POSEE", ""));

                        this.MapaDeTablas = new MapaDeTablas();

                        this.MapaDeTablas.AddWithValue("clientes.dbf", "personas", "CODIGO");
                        this.MapaDeTablas["clientes.dbf"].Where = "CODIGO>1";   // 1 es consumidor final y lo ignoramos
                        this.MapaDeTablas["clientes.dbf"].TipoElemento = typeof(Lbl.Personas.Persona);
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues(null, "tipo", 1);
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues(null, "id_situacion", 2);
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues("NOMBRE", "nombre_visible", ConversionDeColumna.InterpretarNombreYApellido);
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues("DOMICILIO", "domicilio", ConversionDeColumna.ConvertirAMayusculasYMinusculas);
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues("COD_POS", "id_ciudad", ConversionDeColumna.InterpretarSql);
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas["COD_POS"].ParametroConversion = "SELECT id_ciudad FROM ciudades WHERE cp='$VALOR$'";
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues("TELEFONO", "telefono");
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues("CUIT", "cuit");
                        this.MapaDeTablas["clientes.dbf"].MapaDeColumnas.AddWithValues("OBSERVAC", "obs", ConversionDeColumna.ConvertirAMayusculasYMinusculas);

                        this.MapaDeTablas.AddWithValue("proveedo.dbf", "personas", "CODIGO");
                        this.MapaDeTablas["proveedo.dbf"].TipoElemento = typeof(Lbl.Personas.Persona);
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues(null, "tipo", 2);
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues("NOMBRE", "nombre_visible", ConversionDeColumna.InterpretarNombreYApellido);
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues("DOMICILIO", "domicilio", ConversionDeColumna.ConvertirAMayusculasYMinusculas);
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues("COD_POS", "id_ciudad", ConversionDeColumna.InterpretarSql);
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas["COD_POS"].ParametroConversion = "SELECT id_ciudad FROM ciudades WHERE cp='$VALOR$'";
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues("TELEFONO", "telefono");
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues("CUIT", "cuit");
                        this.MapaDeTablas["proveedo.dbf"].MapaDeColumnas.AddWithValues("OBSERVAC", "obs", ConversionDeColumna.ConvertirAMayusculasYMinusculas);

                        this.MapaDeTablas.AddWithValue("catalogo.dbf", "articulos_categorias", "CODIGO");
                        this.MapaDeTablas["catalogo.dbf"].TipoElemento = typeof(Lbl.Articulos.Categoria);
                        this.MapaDeTablas["catalogo.dbf"].MapaDeColumnas.AddWithValues(null, "estado", 1);
                        this.MapaDeTablas["catalogo.dbf"].MapaDeColumnas.AddWithValues("DESCRIP", "nombre", ConversionDeColumna.ConvertirAMayusculasYMinusculas);

                        this.MapaDeTablas.AddWithValue("listapre.dbf", "articulos", "CODIGO");
                        this.MapaDeTablas["listapre.dbf"].TipoElemento = typeof(Lbl.Articulos.Articulo);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues(null, "estado", 1);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues(null, "control_stock", 1);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("CODIGO", "codigo1");
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("U_MEDIDA", "unidad_stock", ConversionDeColumna.ConvertirAMinusculas);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("DESCRIP", "nombre", ConversionDeColumna.ConvertirAMayusculasYMinusculas);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("STOCK", "stock_actual");
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("COSTO", "costo");
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("VALOR1", "pvp");
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("PROVEEDOR", "id_proveedor", ConversionDeColumna.InterpretarSql);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas["PROVEEDOR"].ParametroConversion = "SELECT id_persona FROM personas WHERE import_id='$VALOR$'";
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas.AddWithValues("CATALOGO", "id_categoria", ConversionDeColumna.InterpretarSql);
                        this.MapaDeTablas["listapre.dbf"].MapaDeColumnas["CATALOGO"].ParametroConversion = "SELECT id_categoria FROM articulos_categorias WHERE import_id='$VALOR$'";

                        // Movimientos de stock (a.k.a. facturas)
                        /*
                        this.MapaDeTablas.AddWithValue("movimien.dbf", "comprob_detalle");
                        this.MapaDeTablas["movimien.dbf"].TipoElemento = typeof(Lbl.Comprobantes.DetalleArticulo);
                        this.Reemplazos.Add(new Reemplazo(1, 999, "movimien.dbf:CLIENTE"));      // En el sistema de Escorpión, Consumidor Final es el cliente 1, en Lázaro es 999
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("CODIGO", "id_articulo", ConversionDeColumna.InterpretarSql);
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas["CODIGO"].ParametroConversion = "SELECT id_articulo FROM articulos WHERE import_id='$VALOR$'";
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("CANTIDAD", "cantidad");
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("COSTO", "costo");
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("PRECIO", "precio");
                        
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("NROCOM", "NROCOM");
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("FECHA", "FECHA");
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("CLIENTE", "CLIENTE");
                        this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("TIPO", "TIPO");
                         * */

                        // Cuentas corrientes
                        /* this.MapaDeTablas.AddWithValue("ctasctes.dbf", "catcte");
                        this.Reemplazos.Add(new Reemplazo(1, 999, "ctascte.dbf:CLIENTE"));      // En el sistema de Escorpión, Consumidor Final es el cliente 1 (y puede tener cuenta corriente!), en Lázaro es 999
                        this.MapaDeTablas.AddWithValue("ctascte.dbf", "ctacte", "TIPO,NROCOM");
                        this.MapaDeTablas["ctascte.dbf"].TipoElemento = typeof(Lbl.CuentaCorriente.Movimiento);
                        this.MapaDeTablas["ctascte.dbf"].MapaDeColumnas.AddWithValues(null, "estado", 1);
                        this.MapaDeTablas["ctascte.dbf"].MapaDeColumnas.AddWithValues("DESCRIP", "nombre", ConversionDeColumna.ConvertirAMayusculasYMinusculas);
                        */
                }

                public override Lfx.Data.Row ProcesarRegistro(MapaDeTabla mapa, System.Data.DataRow row)
                {
                        Lfx.Data.Row Lrw = base.ProcesarRegistro(mapa, row);

                        switch(mapa.TablaLazaro) {
                                case "comprob_detalle":
                                        // Busco una factura a la cual adosar este detalle
                                        break;
                        }

                        return Lrw;
                }
        }
}
