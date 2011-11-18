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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos
{
        public partial class Movimiento : Lui.Forms.ChildDialogForm
        {
                public Movimiento()
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Articulos.Articulo), Lbl.Sys.Permisos.Operaciones.Mover) == false) {
                                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                                this.Close();
                                return;
                        }

                        InitializeComponent();

                        EntradaMovimiento_TextChanged(this, null);
                }


                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();

                        if (EntradaArticulo.TextInt <= 0) {
                                aceptarReturn.Message += "Debe especificar el artículo." + Environment.NewLine;
                                aceptarReturn.Success = false;
                        }

                        if (EntradaDesdeSituacion.TextInt != EntradaDesdeSituacion.TextInt) {
                                aceptarReturn.Message += @"Debe indicar ""Desde"" y ""Hacia""." + Environment.NewLine;
                                aceptarReturn.Success = false;
                        }

                        if (Lfx.Types.Parsing.ParseStock(EntradaCantidad.Text) <= 0) {
                                aceptarReturn.Message += "Debe especificar la cantidad." + Environment.NewLine;
                                aceptarReturn.Success = false;
                        }

                        Lbl.Articulos.Articulo Art = null;
                        if (aceptarReturn.Success) {
                                Art = EntradaArticulo.Elemento as Lbl.Articulos.Articulo;
                                if (Art != null && Art.ObtenerSeguimiento() != Lbl.Articulos.Seguimientos.Ninguno) {
                                        if (EntradaArticulo.DatosSeguimiento == null || EntradaArticulo.DatosSeguimiento.Count == 0) {
                                                return new Lfx.Types.FailureOperationResult("Debe ingresar los datos de seguimiento (Ctrl-S) del artículo '" + Art.Nombre + "' para poder realizar movimientos de stock.");
                                        } else {
                                                if (EntradaArticulo.DatosSeguimiento.CantidadTotal < EntradaArticulo.Cantidad)
                                                        return new Lfx.Types.FailureOperationResult("Debe ingresar los datos de seguimiento (Ctrl-S) de todos los artículos '" + Art.Nombre + "' para poder realizar movimientos de stock.");
                                        }
                                }
                        }

                        if (aceptarReturn.Success) {
                                IDbTransaction Trans = this.Connection.BeginTransaction(IsolationLevel.Serializable);
                                decimal Cantidad = EntradaCantidad.ValueDecimal;
                                Lbl.Articulos.Situacion Origen, Destino;
                                Origen = EntradaDesdeSituacion.Elemento as Lbl.Articulos.Situacion;
                                Destino = EntradaHaciaSituacion.Elemento as Lbl.Articulos.Situacion;
                                Art.MoverStock(Cantidad, EntradaObs.Text, Origen, Destino, EntradaArticulo.DatosSeguimiento);
                                Trans.Commit();
                        }

                        return aceptarReturn;
                }

                private void EntradaArticulo_TextChanged(System.Object sender, System.EventArgs e)
                {
                        MostrarStock();
                }

                private void EntradaMovimiento_TextChanged(object sender, System.EventArgs e)
                {
                        switch (EntradaMovimiento.TextKey) {
                                case "e":
                                        EntradaDesdeSituacion.TextInt = 998;
                                        EntradaHaciaSituacion.TextInt = 1;
                                        break;

                                case "s":
                                        EntradaDesdeSituacion.TextInt = 1;
                                        EntradaHaciaSituacion.TextInt = 999;
                                        break;
                        }

                        MostrarStock();
                }

                private void EntradaDesdeHaciaSituacion_TextChanged(object sender, System.EventArgs e)
                {
                        MostrarStock();
                        lblDesdeSituacion.Text = EntradaDesdeSituacion.TextDetail;
                        lblHaciaSituacion.Text = EntradaHaciaSituacion.TextDetail;

                        if (EntradaDesdeSituacion.TextInt == 1 && EntradaHaciaSituacion.TextInt == 999) {
                                if (EntradaMovimiento.TextKey != "s")
                                        EntradaMovimiento.TextKey = "s";
                        } else if (EntradaDesdeSituacion.TextInt == 998 && EntradaHaciaSituacion.TextInt == 1) {
                                if (EntradaMovimiento.TextKey != "e")
                                        EntradaMovimiento.TextKey = "e";
                        } else {
                                EntradaMovimiento.TextKey = " ";
                        }

                        EntradaStockActual.Visible = EntradaDesdeSituacion.TextInt > 0;
                        lblStockFlecha.Visible = EntradaDesdeSituacion.TextInt > 0;
                        EntradaStockResult.Visible = EntradaDesdeSituacion.TextInt > 0;

                        EntradaStockActual2.Visible = EntradaHaciaSituacion.TextInt > 0;
                        lblStockFlecha2.Visible = EntradaHaciaSituacion.TextInt > 0;
                        EntradaStockResult2.Visible = EntradaHaciaSituacion.TextInt > 0;

                        EntradaArticulo.DatosSeguimiento = null;
                }

                private void MostrarStock()
                {
                        Lbl.Articulos.Articulo Articulo = EntradaArticulo.Elemento as Lbl.Articulos.Articulo;

                        if (Articulo != null && (EntradaDesdeSituacion.TextInt != EntradaHaciaSituacion.TextInt)) {
                                decimal Cantidad = EntradaCantidad.ValueDecimal;
                                decimal DesdeCantidad = this.Connection.FieldDecimal("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + Articulo.Id.ToString() + " AND id_situacion=" + EntradaDesdeSituacion.TextInt.ToString());
                                decimal HaciaCantidad = this.Connection.FieldDecimal("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + Articulo.Id.ToString() + " AND id_situacion=" + EntradaHaciaSituacion.TextInt.ToString());

                                if (EntradaDesdeSituacion.TextInt < 998 || EntradaDesdeSituacion.TextInt > 999) {
                                        EntradaStockActual.Text = Lfx.Types.Formatting.FormatNumber(DesdeCantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                        EntradaStockResult.Text = Lfx.Types.Formatting.FormatNumber(DesdeCantidad - Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                } else {
                                        EntradaStockActual.Text = "N/A";
                                        EntradaStockResult.Text = "N/A";
                                }

                                if (EntradaHaciaSituacion.TextInt < 998 || EntradaHaciaSituacion.TextInt > 999) {
                                        EntradaStockActual2.Text = Lfx.Types.Formatting.FormatNumber(HaciaCantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                        EntradaStockResult2.Text = Lfx.Types.Formatting.FormatNumber(HaciaCantidad + Cantidad, this.Workspace.CurrentConfig.Productos.DecimalesStock);
                                } else {
                                        EntradaStockActual2.Text = "N/A";
                                        EntradaStockResult2.Text = "N/A";
                                }
                        } else {
                                EntradaStockActual.Text = "";
                                EntradaStockResult.Text = "";
                                EntradaStockActual2.Text = "";
                                EntradaStockResult2.Text = "";
                        }
                }

                private void FormArticulosMovim_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        EntradaDesdeSituacion.Visible = this.Workspace.CurrentConfig.Productos.StockMultideposito;
                        EntradaHaciaSituacion.Visible = this.Workspace.CurrentConfig.Productos.StockMultideposito;
                        Label7.Visible = this.Workspace.CurrentConfig.Productos.StockMultideposito;
                        Label8.Visible = this.Workspace.CurrentConfig.Productos.StockMultideposito;
                }

                private void EntradaArticulo_ObtenerDatosSeguimiento(object sender, EventArgs e)
                {
                        Lbl.Articulos.Articulo Articulo = EntradaArticulo.Elemento as Lbl.Articulos.Articulo;
                        decimal Cant = EntradaArticulo.Cantidad;

                        if (Cant != 0) {
                                Lfc.Articulos.EditarSeguimiento Editar = new Lfc.Articulos.EditarSeguimiento();
                                Editar.Articulo = Articulo;
                                Editar.Cantidad = Math.Abs(System.Convert.ToInt32(Cant));
                                Editar.SituacionOrigen = this.EntradaDesdeSituacion.Elemento as Lbl.Articulos.Situacion;
                                Editar.DatosSeguimiento = EntradaArticulo.DatosSeguimiento;
                                if (Editar.ShowDialog() == DialogResult.OK) {
                                        EntradaArticulo.DatosSeguimiento = Editar.DatosSeguimiento;
                                }
                        }
                }

                private void EntradaArticulo_PrecioCantidadChanged(object sender, EventArgs e)
                {
                        EntradaCantidad.ValueDecimal = EntradaArticulo.Cantidad;
                }

        }
}