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

namespace Lbl.Servicios.Importar
{
        /// <summary>
        /// Describe un filtro de importación desde archivos DBF del sistema de Escorpión Sistemas.
        /// </summary>
        public class FiltroEscorpion : FiltroDbf
        {
                public FiltroEscorpion(Lfx.Data.Connection dataBase, Opciones opciones)
                        : base(dataBase, opciones)
                {
                        this.FilterName = "Escorpión Sistemas";

                        this.Reemplazos.Add(new Reemplazo("NO POSEE", ""));

                        this.MapaDeTablas = new MapaDeTablas();

                        if (this.Opciones.ImportarClientes) {
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
                        }


                        if (this.Opciones.ImportarArticulos) {
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
                        }

                        if (this.Opciones.ImportarFacturas) {
                                // Movimientos de stock (a.k.a. facturas)
                                this.MapaDeTablas.AddWithValue("movimien.dbf", "comprob_detalle", "dbf_recno");
                                this.MapaDeTablas["movimien.dbf"].TipoElemento = typeof(Lbl.Comprobantes.DetalleArticulo);
                                this.MapaDeTablas["movimien.dbf"].ActualizaRegistros = false;
                                this.MapaDeTablas["movimien.dbf"].Where = "TIPO IN ('FCA', 'FCB')";   // Sólo facturas
                                this.Reemplazos.Add(new Reemplazo(1, 999, "movimien.dbf:CLIENTE"));   // En el sistema de Escorpión, Consumidor Final es el cliente 1, en Lázaro es 999
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("CODIGO", "id_articulo", ConversionDeColumna.InterpretarSql);
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas["CODIGO"].ParametroConversion = "SELECT id_articulo FROM articulos WHERE import_id='$VALOR$'";
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("CANTIDAD", "cantidad");
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("COSTO", "costo");
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("PRECIO", "precio");
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("PRECIO", "importe");
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues(null, "id_comprob", null);

                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("NROCOM", "NROCOM");
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("FECHA", "FECHA");
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("CLIENTE", "CLIENTE", ConversionDeColumna.InterpretarSql);
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas["CLIENTE"].ParametroConversion = "SELECT id_persona FROM personas WHERE import_id='$VALOR$'";
                                this.MapaDeTablas["movimien.dbf"].MapaDeColumnas.AddWithValues("TIPO", "TIPO");
                        }

                        if (this.Opciones.ImportarCtasCtes) {
                                // Cuentas corrientes
                                /* this.MapaDeTablas.AddWithValue("ctasctes.dbf", "catcte");
                                this.Reemplazos.Add(new Reemplazo(1, 999, "ctascte.dbf:CLIENTE"));      // En el sistema de Escorpión, Consumidor Final es el cliente 1 (y puede tener cuenta corriente!), en Lázaro es 999
                                this.MapaDeTablas.AddWithValue("ctascte.dbf", "ctacte", "TIPO,NROCOM");
                                this.MapaDeTablas["ctascte.dbf"].TipoElemento = typeof(Lbl.CuentaCorriente.Movimiento);
                                this.MapaDeTablas["ctascte.dbf"].MapaDeColumnas.AddWithValues(null, "estado", 1);
                                this.MapaDeTablas["ctascte.dbf"].MapaDeColumnas.AddWithValues("DESCRIP", "nombre", ConversionDeColumna.ConvertirAMayusculasYMinusculas);
                                */
                        }
                }


                public override void Pre()
                {
                        base.Pre();

                        this.Connection.ExecuteSql("UPDATE personas SET import_id=1 WHERE id_persona=999");
                }


                public override void Post()
                {
                        base.Post();

                        this.Connection.ExecuteSql("UPDATE comprob a SET total=(SELECT SUM(importe) FROM comprob_detalle b WHERE a.id_comprob=b.id_comprob)");
                        this.Connection.ExecuteSql("UPDATE comprob SET totalreal=total, subtotal=total, cancelado=total");
                }

                public override Lfx.Data.Row ProcesarRegistro(MapaDeTabla mapa, System.Data.DataRow row)
                {
                        Lfx.Data.Row Lrw = base.ProcesarRegistro(mapa, row);

                        switch(mapa.TablaLazaro) {
                                case "comprob_detalle":
                                        // Busco una factura a la cual adosar este detalle
                                        string Tipo = row["TIPO"].ToString();
                                        int Numero = Lfx.Types.Parsing.ParseInt(row["NROCOM"].ToString());
                                        if (Tipo == "FCA")
                                                Tipo = "FA";
                                        else if (Tipo == "FCB")
                                                Tipo = "FB";

                                        if (Numero > 0 && (Tipo == "FA" || Tipo == "FB")) {
                                                // Es una factura válida
                                                Lbl.Comprobantes.Factura Fac;

                                                qGen.Select SelFac = new qGen.Select("comprob");
                                                SelFac.WhereClause = new qGen.Where();
                                                SelFac.WhereClause.AddWithValue("tipo_fac", Tipo);
                                                SelFac.WhereClause.AddWithValue("numero", Numero);
                                                Lfx.Data.Row FacRow = this.Connection.FirstRowFromSelect(SelFac);

                                                if (FacRow == null) {
                                                        qGen.Select SelCliente = new qGen.Select("personas");
                                                        SelCliente.WhereClause = new qGen.Where();
                                                        SelCliente.WhereClause.AddWithValue("import_id", System.Convert.ToInt32(row["CLIENTE"]));
                                                        int Cliente = this.Connection.FieldInt(SelCliente);
                                                        if(Cliente <= 0)
                                                                Cliente = 999;
                                                        qGen.Insert NewFac = new qGen.Insert("comprob");
                                                        NewFac.Fields.AddWithValue("id_formapago", 3);
                                                        NewFac.Fields.AddWithValue("tipo_fac", Tipo);
                                                        NewFac.Fields.AddWithValue("pv", 1);
                                                        NewFac.Fields.AddWithValue("numero", Numero);
                                                        NewFac.Fields.AddWithValue("situacionorigen", 1);
                                                        NewFac.Fields.AddWithValue("situaciondestino", 999);
                                                        NewFac.Fields.AddWithValue("fecha", System.Convert.ToDateTime(row["FECHA"]));
                                                        NewFac.Fields.AddWithValue("id_vendedor", 1);
                                                        NewFac.Fields.AddWithValue("id_cliente", Cliente);
                                                        NewFac.Fields.AddWithValue("impresa", 1);
                                                        NewFac.Fields.AddWithValue("id_sucursal", 1);
                                                        NewFac.Fields.AddWithValue("estado", 1);
                                                        this.Connection.Execute(NewFac);

                                                        FacRow = this.Connection.FirstRowFromSelect(SelFac);
                                                }

                                                Fac = new Comprobantes.Factura(this.Connection, FacRow);
                                                Lrw.Fields["importe"].Value = Lrw.Fields["precio"].ValueDecimal * Lrw.Fields["cantidad"].ValueDecimal;
                                                Lrw.Fields.AddWithValue("id_comprob", Fac.Id);
                                        }
                                        break;
                        }

                        return Lrw;
                }
        }
}

