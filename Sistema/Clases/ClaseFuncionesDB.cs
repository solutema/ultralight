// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace LazaroBak
{
    public class Articulos
    {
        public static void MoverStockFactura(Lfx.Data.DataBase Conexion, DataRow Factura, bool Saliente)
        {
            // Resta lo facturado del stock
            System.Data.DataTable tblStock = Conexion.Select("SELECT id_articulo, cantidad FROM facturas_detalle WHERE id_factura=" + Factura["id_factura"].ToString());
            string Comprob = Comprobantes.NumeroCompleto(Conexion, Lfx.Data.DataBase.ConvertNullToZero(Factura["id_factura"]));
            string NombreMovim = null;

            if(Saliente)
                NombreMovim = "Salida";
            else
                NombreMovim = "Ingreso";

            if(tblStock.Rows.Count > 0)
            {
                foreach(System.Data.DataRow rowDetalle in tblStock.Rows)
                {
                    if(Lfx.Data.DataBase.ConvertNullToZero(rowDetalle["id_articulo"]) > 0)
                    {
                        if(Saliente)
                        {
                            MoverStock(Conexion,
                                       Lfx.Data.DataBase.ConvertNullToZero(rowDetalle["id_articulo"]),
                                       System.Convert.ToDouble(rowDetalle["cantidad"]),
                                       NombreMovim + " s/comprob. " + Comprob,
                                       Lfx.Data.DataBase.ConvertNullToZero(Factura["situacionorigen"]),
                                       Lfx.Data.DataBase.ConvertNullToZero(Factura["situaciondestino"]));
                        }
                        else
                        {
                            MoverStock(Conexion,
                                       Lfx.Data.DataBase.ConvertNullToZero(rowDetalle["id_articulo"]),
                                       System.Convert.ToDouble(rowDetalle["cantidad"]),
                                       NombreMovim + " s/comprob. " + Comprob,
                                       Lfx.Data.DataBase.ConvertNullToZero(Factura["situaciondestino"]),
                                       Lfx.Data.DataBase.ConvertNullToZero(Factura["situacionorigen"]));
                        }
                    }
                }
            }

            //return 0;
        }

        public static void MoverStockYAsentarPago(Lfx.Data.DataBase Conexion, int m_Id)
        {
            System.Data.DataRow
                Factura = Conexion.Row("SELECT * FROM facturas WHERE id_factura=" + m_Id.ToString());

            if(Factura != null)
            {
                if(System.Convert.ToString(
                       Factura["tipo_fac"]) == "A" || System.Convert.ToString(
                                                          Factura["tipo_fac"]) == "B" || System.Convert.ToString(
                                                                                             Factura["tipo_fac"]) == "C"
                       || System.Convert.ToString(Factura["tipo_fac"]) == "M")
                {
                    switch(Lfx.Data.DataBase.ConvertNullToZero(Factura["id_formapago"]))
                    {
                        case 1:
                            Cuentas.Movimiento(Conexion,
                                               999,
                                               1,
                                               1,
                                               "Cobro Factura " + Comprobantes.NumeroCompleto(Conexion,Lfx.Data.DataBase.ConvertNullToZero(Factura["id_factura"])),
                                               Lfx.Data.DataBase.ConvertNullToZero(Factura["id_cliente"]),
                                               System.Convert.ToDouble(Factura["total"]),
                                               "",
                                               Lfx.Data.DataBase.ConvertNullToZero(Factura["id_factura"]),
                                               0,
                                               "");

                            Conexion.Execute("UPDATE facturas SET cancelado=" + Lfx.Types.FormatCurrency(System.Convert.ToDouble(Factura["total"]), Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + Factura["id_factura"].ToString());
                            break;

                        case 2:
                            // Quien mand imprimir la factura debera manejar esto
                            break;

                        case 3:
                            // Uso saldos a favor en Cta. Cte. para cancelar esta factura
                            Cuentas.IngresarFacturaONDACuentaCorriente(Conexion, Factura, 0);

                            break;

                        case 4:
                            // Quien mand imprimir la factura debera manejar esto
                            break;

                        case 5:
                            // Quien mand imprimir la factura debera manejar esto
                            break;

                        case 99:
                            // Quien mand imprimir la factura debera manejar esto
                            break;
                    }
                }

                if(System.Convert.ToString(
                       Factura["tipo_fac"]).Length >= 2 && System.Convert.ToString(
                                                               Factura["tipo_fac"]).Substring(0, 2) == "ND")
                {
                    Cuentas.IngresarFacturaONDACuentaCorriente(Conexion, Factura, 0);
                }

                if(System.Convert.ToString(Factura["tipo_fac"]) == "R")
                {
                    // Es un Remito. Descuento el Stock
                    MoverStockFactura(Conexion, Factura, true);
                }
                else if(System.Convert.ToString(
                            Factura["tipo_fac"]) == "NCA" || System.Convert.ToString(
                                                                 Factura[
                                                                     "tipo_fac"]) == "NCB" || System.Convert.ToString(
                                                                                                  Factura["tipo_fac"])
                                                                                                  == "NCC"
                            || System.Convert.ToString(Factura["tipo_fac"]) == "NCM")
                {
                    // Es una Nota de Crédito. Vuelvo a poner el stock
                    MoverStockFactura(Conexion, Factura, false);
                }
                else
                {
                    // Es una factura. Descuento el Stock, sólo si no hay remito asociado
                    if(System.Convert.ToInt32(Factura["remito"]) == 0)
                    {
                        MoverStockFactura(Conexion, Factura, true);
                    }
                }
            }
        }

        public static void MoverStock(Lfx.Data.DataBase Conexion, int Articulo, double Cantidad)
        {
            MoverStock(Conexion, Articulo, Cantidad, "", 1, 999);
        }

        public static void MoverStock(Lfx.Data.DataBase Conexion, int Articulo, double Cantidad,
                                      string Obs, int DesdeSituacion, int HaciaSituacion)
        {
            double CantidadMovida = 0;

            DataRow rDesdeSituacion = Conexion.Row("SELECT * FROM articulos_situaciones WHERE id_situacion=" + DesdeSituacion.ToString());
            DataRow rHaciaSituacion = Conexion.Row("SELECT * FROM articulos_situaciones WHERE id_situacion=" + HaciaSituacion.ToString());

            if(rDesdeSituacion != null)
            {
                DataRow StockActual = Conexion.Row("SELECT * FROM articulos_stock WHERE id_articulo=" + Articulo.ToString() + " AND id_situacion=" + DesdeSituacion.ToString());

                if(StockActual == null)
                {
                    Conexion.Execute("INSERT INTO articulos_stock SET cantidad=" + Lfx.Types.FormatNumberSQL(-Cantidad, Aplicacion.EspacioTrabajo.CurrentConfig.Products.StockDecimalPlaces) + ", id_articulo=" + Articulo.ToString() + ", id_situacion=" + DesdeSituacion.ToString());
                }
                else
                {
                    Conexion.Execute("UPDATE articulos_stock SET cantidad=cantidad-(" + Lfx.Types.FormatNumberSQL(Cantidad, Aplicacion.EspacioTrabajo.CurrentConfig.Products.StockDecimalPlaces) + ") WHERE id_articulo=" + Articulo.ToString() + " AND id_situacion=" + DesdeSituacion.ToString());
                }

                if(System.Convert.ToInt32(rDesdeSituacion["cuenta_stock"]) != 0)
                {
                    CantidadMovida -= Cantidad;
                }
            }

            if(rHaciaSituacion != null)
            {
                DataRow StockActual = Conexion.Row("SELECT * FROM articulos_stock WHERE id_articulo=" + Articulo.ToString() + " AND id_situacion=" + HaciaSituacion.ToString());

                if(StockActual == null)
                {
                    Conexion.Execute("INSERT INTO articulos_stock SET cantidad=" + Lfx.Types.FormatNumberSQL(Cantidad, Aplicacion.EspacioTrabajo.CurrentConfig.Products.StockDecimalPlaces) + ", id_articulo=" + Articulo.ToString() + ", id_situacion=" + HaciaSituacion.ToString());
                }
                else
                {
                    Conexion.Execute("UPDATE articulos_stock SET cantidad=cantidad+(" + Lfx.Types.FormatNumberSQL(Cantidad, Aplicacion.EspacioTrabajo.CurrentConfig.Products.StockDecimalPlaces) + ") WHERE id_articulo=" + Articulo.ToString() + " AND id_situacion=" + HaciaSituacion.ToString());
                }

                if(System.Convert.ToInt32(rHaciaSituacion["cuenta_stock"]) != 0)
                {
                    CantidadMovida += Cantidad;
                }
            }

            if(CantidadMovida != 0)
            {
                Conexion.Execute("UPDATE articulos SET stock_actual=stock_actual+(" + Lfx.Types.FormatNumberSQL(CantidadMovida, Aplicacion.EspacioTrabajo.CurrentConfig.Products.StockDecimalPlaces) + ") WHERE id_articulo=" + Articulo.ToString() + " AND control_stock>0");
            }

            double Saldo = Conexion.FieldDouble("SELECT stock_actual FROM articulos WHERE id_articulo=" + Articulo.ToString());

            System.Data.Odbc.OdbcCommand Cmd = new System.Data.Odbc.OdbcCommand("");
            Cmd.CommandText = "INSERT INTO articulos_movim (id_articulo, fecha, cantidad, desdesituacion, haciasituacion, saldo, obs) VALUES (?, NOW(), ?, ?, ?, ?, ?)";
            Cmd.Parameters.Add("id_articulo", Articulo);
            Cmd.Parameters.Add("cantidad", Cantidad);
            Cmd.Parameters.Add("desdesituacion", Lfx.Data.DataBase.ConvertZeroToNull(DesdeSituacion));
            Cmd.Parameters.Add("haciasituacion", Lfx.Data.DataBase.ConvertZeroToNull(HaciaSituacion));
            Cmd.Parameters.Add("saldo", Saldo);
            Cmd.Parameters.Add("obs", Obs);
            Conexion.Execute(Cmd);
        }

        public static bool HayStock(Lfx.Data.DataBase Conexion, int FacturaId)
        {
            bool hayStockReturn = false;
            // Resta lo facturado del stock
            System.Data.DataTable tblStock = Conexion.Select("SELECT id_articulo, cantidad FROM facturas_detalle WHERE id_factura=" + FacturaId.ToString());

            hayStockReturn = true;

            if(tblStock.Rows.Count > 0)
            {
                foreach(System.Data.DataRow rowDetalle in tblStock.Rows)
                {
                    if(Lfx.Data.DataBase.ConvertNullToZero(rowDetalle["id_articulo"]) > 0)
                    {
                        DataRow Articulo = Conexion.Row("SELECT control_stock,stock_actual,stock_trabado FROM articulos WHERE id_articulo=" + rowDetalle["id_articulo"].ToString());

                        if((System.Convert.ToInt32(Articulo["control_stock"]) != 0) && (System.Convert.ToDouble(Articulo["stock_actual"]) - System.Convert.ToDouble(Articulo["stock_trabado"]) < System.Convert.ToDouble(rowDetalle["cantidad"])))
                        {
                            hayStockReturn = false;
                            break;
                        }
                    }
                }
            }

            return hayStockReturn;
        }

        public static Image Imagen(int iArticulo)
        {
            DataRow
                ImgArticulo = Aplicacion.EspacioTrabajo.DefaultDataBase.Row("SELECT imagen FROM articulos_imagenes WHERE id_articulo=" + iArticulo.ToString());

            if(ImgArticulo != null && ImgArticulo["imagen"] != DBNull.Value && ((byte[])(ImgArticulo["imagen"])).Length > 5)
            {
                byte[] ByteArr = ((byte[])(ImgArticulo["imagen"]));
                System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
                return Image.FromStream(loStream);
            }
            else
            {
                int CategoriaArticulo = Aplicacion.EspacioTrabajo.DefaultDataBase.FieldInt("SELECT id_cat_articulo FROM articulos WHERE id_articulo=" + iArticulo.ToString());

                if(CategoriaArticulo > 0)
                {
                    DataRow ImgCategoria = Aplicacion.EspacioTrabajo.DefaultDataBase.Row("SELECT imagen FROM cat_articulos WHERE id_cat_articulo=" + CategoriaArticulo.ToString());

                    if(ImgCategoria == null)
                    {
                        return null;
                    }
                    else if(ImgCategoria["imagen"] != DBNull.Value && ((byte[])(ImgCategoria["imagen"])).Length > 5)
                    {
                        byte[] ByteArr = ((byte[])(ImgCategoria["imagen"]));
                        System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
                        return Image.FromStream(loStream);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public static string CodigoPredet()
        {
            return CodigoPredet(null);
        }

        public static string CodigoPredet(DataRow Articulo)
        {
            // Devuelve el código predeterminado de un artículo
            // Si se pasa un registro artículo como parmetro, devuelve el valor del
            // De lo contrario, devuelve el nombre del campo
            // Espero que no se preste a confusin
            string CodPredet = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Stock.CodigoPredet", "0");

            switch(CodPredet)
            {
                case "0":
                case "":
                    // Usar el código autonumérico integrado
                    CodPredet = "id_articulo";

                    break;

                default:
                    // Usar un código en particular
                    CodPredet = "codigo" + CodPredet;

                    break;
            }

            if(Articulo == null)
            {
                return CodPredet;
            }
            else
            {
                return System.Convert.ToString(Articulo[CodPredet]);
            }
        }
    }

    public class Cuentas
    {
        public static Lfx.Types.Operation IngresarFacturaONDACuentaCorriente(Lfx.Data.DataBase Conexion, System.Data.DataRow Factura, double ValorMaximo)
        {
            double SaldoCtaCteAntes = Cuentas.SaldoCuentaCorriente(Conexion, System.Convert.ToInt32(Factura["id_cliente"]));
            Cuentas.MovimientoCuentaCorriente(Conexion, 1, 111, Comprobantes.NombreTipo(System.Convert.ToString(Factura["tipo_fac"])) + " Pendiente por $ " + Lfx.Types.FormatCurrency(System.Convert.ToDouble(Factura["total"]), Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces), Lfx.Data.DataBase.ConvertNullToZero(Factura["id_cliente"]), System.Convert.ToDouble(Factura["total"]), "", Lfx.Data.DataBase.ConvertNullToZero(Factura["id_factura"]), 0, true);
            double FacturaSaldo = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
            double SaldoCancelado = 0;

            if(ValorMaximo == 0)
            {
                ValorMaximo = FacturaSaldo;
            }

            // Busco saldos a favor en Cta. Cte para cancelar este comprobante

            DataTable Saldos = Conexion.Select("SELECT * FROM facturas WHERE id_cliente=" + Factura["id_cliente"].ToString() + " AND tipo_fac IN ('NCA', 'NCB', 'NCC') AND impresa>0 AND anulada=0 AND numero>0 AND cancelado<total");

            foreach(System.Data.DataRow Saldo in Saldos.Rows)
            {
                double ComprobSaldo = System.Convert.ToDouble(Saldo["total"]) - System.Convert.ToDouble(Saldo["cancelado"]);
                double SaldoACancelar = FacturaSaldo;

                if(SaldoACancelar > ValorMaximo)
                {
                    SaldoACancelar = ValorMaximo;
                }

                if(SaldoACancelar > ComprobSaldo)
                {
                    SaldoACancelar = ComprobSaldo;
                }

                // Agrego a la factura
                Conexion.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.FormatCurrency(SaldoACancelar, Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + Factura["id_factura"].ToString());
                // Descuento de la NC
                Conexion.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.FormatCurrency(SaldoACancelar, Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + Saldo["id_factura"].ToString());

                SaldoCancelado += SaldoACancelar;
                FacturaSaldo -= SaldoACancelar;

                if(SaldoCancelado >= ValorMaximo || FacturaSaldo <= 0)
                {
                    break;
                }
            }

            if(FacturaSaldo > 0)
            {
                // Busca un saldo a favor no sólo en NC, sino directamente en la tabla ctacte
                // ya que puede tener saldo a favor por un recibo o un ajuste
                if(SaldoCtaCteAntes < 0)
                {
                    double SaldoACancelar = -SaldoCtaCteAntes;

                    if(SaldoACancelar > FacturaSaldo)
                    {
                        SaldoACancelar = FacturaSaldo;
                    }

                    // Cancelo la factura con un saldo a favor que tena en cta. cte.
                    Conexion.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.FormatCurrency(SaldoACancelar, Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + Factura["id_factura"].ToString());
                    SaldoCancelado += SaldoACancelar;
                }
            }

            return new Lfx.Types.Operation(true);
        }

        public static Lfx.Types.Operation MovimientoCuentaCorriente(Lfx.Data.DataBase Conexion, int iAuto, int iConcepto, string sConcepto, int iCliente, double dImporte, string sObs, int iFactura, int iRecibo, bool CancelaCosas)
        {
            try
            {
                double sSaldoActual = Conexion.FieldDouble("SELECT saldo FROM ctacte WHERE id_cliente=" + iCliente.ToString() + " ORDER BY fecha DESC, id_movim DESC LIMIT 1");
                System.Data.Odbc.OdbcCommand cmd = null;

                cmd = new System.Data.Odbc.OdbcCommand("");
                cmd.CommandText = "INSERT INTO ctacte (auto, id_concepto, concepto, id_cliente, fecha, importe, id_factura, id_recibo, comprob, saldo, obs) VALUES (?, ?, ?, ?, NOW(), ?, ?, ?, ?, ?, ?)";
                cmd.Parameters.Add("auto", iAuto);
                cmd.Parameters.Add("id_concepto", Lfx.Data.DataBase.ConvertZeroToNull(iConcepto));
                cmd.Parameters.Add("concepto", sConcepto);
                cmd.Parameters.Add("id_cliente", Lfx.Data.DataBase.ConvertZeroToNull(iCliente));
                cmd.Parameters.Add("importe", dImporte);
                cmd.Parameters.Add("id_factura", Lfx.Data.DataBase.ConvertZeroToNull(iFactura));
                cmd.Parameters.Add("id_recibo", Lfx.Data.DataBase.ConvertZeroToNull(iRecibo));
                cmd.Parameters.Add("comprob", "");
                cmd.Parameters.Add("saldo", sSaldoActual + dImporte);
                cmd.Parameters.Add("obs", sObs);
                Conexion.Execute(cmd);

                if(CancelaCosas && dImporte < 0)
                {
                    // Cancelo saldos de facturas que haya en cta. cte. pendientes de pago
                    System.Data.DataTable FacturasConSaldo = Conexion.Select("SELECT * FROM facturas WHERE impresa>0 AND anulada=0 AND numero>0 AND tipo_fac IN ('A', 'B', 'C', 'NDA', 'NDB', 'NDC') AND id_formapago=3 AND cancelado<total AND id_cliente=" + iCliente.ToString() + " ORDER BY id_factura");

                    double ImporteRestante = dImporte;

                    foreach(System.Data.DataRow Factura in FacturasConSaldo.Rows)
                    {
                        double SaldoFactura = System.Convert.ToDouble(Factura["total"]) - System.Convert.ToDouble(Factura["cancelado"]);
                        double ImporteASaldar = SaldoFactura;

                        if(ImporteASaldar > Math.Abs(ImporteRestante))
                        {
                            ImporteASaldar = Math.Abs(ImporteRestante);
                        }

                        Conexion.Execute("UPDATE facturas SET cancelado=cancelado+" + Lfx.Types.FormatCurrency(ImporteASaldar, Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlaces) + " WHERE id_factura=" + Factura["id_factura"].ToString());
                        ImporteRestante += ImporteASaldar;

                        if(ImporteRestante >= 0)
                        {
                            break;
                        }
                    }
                }

                return new Lfx.Types.Operation(true);
            }
            catch(Exception ex)
            {
                return new Lfx.Types.Operation(false, ex.ToString());
            }
        }

        public static double SaldoCuentaCorriente(Lfx.Data.DataBase Conexion, int ClienteId)
        {
            return Conexion.FieldDouble("SELECT saldo FROM ctacte WHERE id_cliente=" + ClienteId.ToString() + " ORDER BY id_movim DESC LIMIT 1");
        }

        public static Lfx.Types.Operation Movimiento(Lfx.Data.DataBase Conexion, int iCuenta, int iAuto, int iConcepto, string sConcepto, int iCliente, double dImporte, string sObs, int iFactura, int iRecibo, string sComprob)
        {
            // TODO: Que esto sea seguro si dos clientes lo hacen simultneamente
            // Para lo cual hace falta analizar el nivel de aislamiento de la transaccin
            // y asegurarse de que esto suceda dentro de una transaccin
            // O bien bloquear la tabla duante durante este proceso
            // NOTA: si esto se hace dentro de una transaccin SERIALIZABLE, debera ser seguro
            try
            {
                double sSaldoActual = Conexion.FieldDouble("SELECT saldo FROM cuentas_movim WHERE id_cuenta=" + iCuenta.ToString() + " ORDER BY fecha DESC, id_movim DESC");
                System.Data.Odbc.OdbcCommand Cmd = null;

                Cmd = new System.Data.Odbc.OdbcCommand("");
                Cmd.CommandText = "INSERT INTO cuentas_movim (id_cuenta, auto, id_concepto, concepto, id_cliente, fecha, importe, id_factura, id_recibo, comprob, saldo, obs) VALUES (?, ?, ?, ?, ?, NOW(), ?, ?, ?, ?, ?, ?)";
                Cmd.Parameters.Add("id_cuenta", iCuenta);
                Cmd.Parameters.Add("auto", iAuto);
                Cmd.Parameters.Add("id_concepto", Lfx.Data.DataBase.ConvertZeroToNull(iConcepto));
                Cmd.Parameters.Add("concepto", sConcepto);
                Cmd.Parameters.Add("id_cliente", Lfx.Data.DataBase.ConvertZeroToNull(iCliente));
                Cmd.Parameters.Add("importe", dImporte);
                Cmd.Parameters.Add("id_factura", Lfx.Data.DataBase.ConvertZeroToNull(iFactura));
                Cmd.Parameters.Add("id_recibio", Lfx.Data.DataBase.ConvertZeroToNull(iRecibo));
                Cmd.Parameters.Add("comprob", sComprob);
                Cmd.Parameters.Add("saldo", sSaldoActual + dImporte);
                Cmd.Parameters.Add("obs", sObs);
                Conexion.Execute(Cmd);

                return new Lfx.Types.Operation(true);
            }
            catch(Exception ex)
            {
                return new Lfx.Types.Operation(false, ex.ToString());
            }
        }
    }

    public class Comprobantes
    {
        public static string FacturasDeUnRecibo(Lfx.Data.DataBase Conexion, int ReciboId)
        {
            System.Text.StringBuilder Facturas = new System.Text.StringBuilder();
            DataTable TablaFacturas = Aplicacion.EspacioTrabajo.DefaultDataBase.Select("SELECT id_factura FROM recibos_facturas WHERE id_recibo=" + ReciboId.ToString());

            foreach(System.Data.DataRow Factura in TablaFacturas.Rows)
            {
                if(Facturas.Length == 0)
                {
                    Facturas.Append(Comprobantes.NumeroCompleto(Conexion, Lfx.Data.DataBase.ConvertNullToZero(Factura["id_factura"])));
                }
                else
                {
                    Facturas.Append(", " + Comprobantes.NumeroCompleto(Conexion, Lfx.Data.DataBase.ConvertNullToZero(Factura["id_factura"])));
                }
            }

            return Facturas.ToString();
        }

        public static int AnchoDetalle(string sTipoComprob)
        {
            // Devuelve el ancho de la columna "Detalle" para una factura u otro comprobante

            // Obtengo el formato del comprobante de la base de datos
            string sDefinicion = Aplicacion.EspacioTrabajo.DefaultDataBase.FieldString("SELECT definicion FROM sys_plantillas WHERE codigo='" + sTipoComprob + "'");

            // Supongo que tiene al menos 1 pasada
            string sNombrePasada = "Pasada1";

            // Obtengo las coordenadas de la columna "Detalle"
            Rectangle cDetallesXY = new Rectangle(0, 0, 0, 0);
            cDetallesXY = Lfx.Types.Ini.ReadRectangle(sDefinicion, sNombrePasada, "DetallesXY", cDetallesXY);

            // Devuelvo el ancho
            return cDetallesXY.Width;
        }

        public static Lfx.Types.Operation ImprimirFacturaORemito(Lfx.Data.DataBase Conexion, int m_Id)
        {
            return ImprimirFacturaORemito(Conexion, m_Id, true, "");
        }

        public static Lfx.Types.Operation ImprimirFacturaORemito(Lfx.Data.DataBase Conexion, int m_Id, bool Progreso, string Impresora)
        {
            System.Data.DataRow Factura = Conexion.Row("SELECT * FROM facturas WHERE id_factura=" + m_Id.ToString());

            if(System.Convert.ToInt32(Factura["impresa"]) != 0 && System.Convert.ToInt32(Factura["numero"]) > 0)
                return new Lfx.Types.Operation(false, "El comprobante ya fue impreso.");

            // Busco el punto de venta para este tipo de comprobante en particular
            int PV = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos." + System.Convert.ToString(Factura["tipo_fac"]) + ".PV", 0);

            if(PV == 0)
            {
                // No hay nada definido. Busco el PV para el tipo de comprobante más general
                switch(System.Convert.ToString(Factura["tipo_fac"]))
                {
                    case "NCA":
                    case "NCB":
                    case "NCC":
                        PV = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.NC.PV", 0);
                        break;

                    case "NDA":
                    case "NDB":
                    case "NDC":
                        PV = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.ND.PV", 0);
                        break;

                    case "A":
                    case "B":
                    case "C":
                        PV = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.ABC.PV", 0);
                        break;

                    case "R":
                        PV = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.ABC.PV", 0);
                        break;
                }

                if(PV == 0)
                {
                    // No hay nada definido. Busco el PV predeterminado para cualquier tipo de comprobante
                    PV = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingInt("", "Sistema.Documentos.PV", 1);
                }
            }

            // Busco el modo de impresin para ese PV (normal o fiscal)
            string ModoImpresion = Aplicacion.EspacioTrabajo.CurrentConfig.ReadGlobalSettingString(null, "Sistema.Documentos.PV" + PV.ToString() + ".Modo", "normal");

            // Resumen: De manera predeterminada, se imprime todo en el PV 1, con impresin "normal"
            switch(ModoImpresion)
            {
                case "fiscal":
					// Impresión mediante controlador fiscal
					Aplicacion.EspacioTrabajo.DefaultScheduler.AddTask("IMPRIMIR " + m_Id.ToString(), "fiscal" + PV.ToString(), "*");
                    break;

                default:
                    // Impresión "normal" o manual
                    return ImprimirFacturaORemitoManual(Conexion, m_Id, PV, Impresora);
            }

            return new Lfx.Types.Operation(true);
        }

        public static Lfx.Types.Operation ImprimirFacturaORemitoManual(Lfx.Data.DataBase Conexion, int m_Id, int PV, string Impresora)
        {
            Lfx.Types.Operation imprimirFacturaORemitoManualReturn = new Lfx.Types.Operation(true);

            Lfx.Forms.ProgressForm TmpProgreso = new Lfx.Forms.ProgressForm();
            TmpProgreso.Titulo = "Imprimiendo...";
            TmpProgreso.Progreso = 10;
            System.Threading.Thread.Sleep(200);

            System.Data.DataRow Factura = Conexion.Row("SELECT * FROM facturas WHERE id_factura=" + m_Id.ToString());
            string sTipoComprob = System.Convert.ToString(Factura["tipo_fac"]);
            int Numero = System.Convert.ToInt32(Factura["numero"]);
            Lfx.Printing.TextDocument fComprobante = new Lfx.Printing.TextDocument(sTipoComprob);

            // Asiento los precios de costo de los artículos de la factura (con fines estadsticos)
            DataTable Detalle = Conexion.Select("SELECT facturas_detalle.id_factura_detalle, facturas_detalle.id_articulo, articulos.costo FROM facturas_detalle, articulos WHERE facturas_detalle.id_articulo=articulos.id_articulo AND id_factura=" + m_Id.ToString());

            foreach(System.Data.DataRow Art in Detalle.Rows)
            {
                if(Lfx.Data.DataBase.ConvertNullToZero(Art["id_articulo"]) > 0)
                    Conexion.Execute("UPDATE facturas_detalle SET costo=" + Lfx.Types.FormatCurrency(System.Convert.ToDouble(Art["costo"]), Aplicacion.EspacioTrabajo.CurrentConfig.Currency.DecimalPlacesCosto).ToString() + " WHERE id_factura_detalle=" + Art["id_factura_detalle"].ToString());
            }

            if(Numero == 0)
                Numero = Comprobantes.Numerar(Conexion, m_Id, PV);

            // Determino la impresora que le corresponde
            if(Impresora.Length == 0)
                Impresora = Aplicacion.EspacioTrabajo.CurrentConfig.Printing.PreferredPrinter(sTipoComprob);

            // Si es de carga manual, presento el formulario correspondiente
            if(Aplicacion.EspacioTrabajo.CurrentConfig.Printing.PrinterFeed(sTipoComprob, "manual") == "manual")
            {
                TmpProgreso.Visible = false;
            