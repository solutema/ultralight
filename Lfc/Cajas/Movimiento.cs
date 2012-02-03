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
using System.Data;

namespace Lfc.Cajas
{
        public partial class Movimiento : Lui.Forms.DialogForm
        {
                public Movimiento()
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Cajas.Caja), Lbl.Sys.Permisos.Operaciones.Mover) == false) {
                                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                                this.Close();
                                return;
                        }

                        InitializeComponent();
                }


                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();

                        int iOrigen = EntradaOrigen.TextInt;
                        int iDestino = EntradaDestino.TextInt;

                        if (iOrigen == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Caja de Origen." + Environment.NewLine;
                        }
                        if (iDestino == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Caja de Destino." + Environment.NewLine;
                        }
                        if (Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text) <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el importe." + Environment.NewLine;
                        }
                        if (EntradaConcepto.TextInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el Concepto." + Environment.NewLine;
                        }

                        if (aceptarReturn.Success == true) {
                                decimal Importe = EntradaImporte.ValueDecimal;
                                IDbTransaction Trans = Connection.BeginTransaction(IsolationLevel.Serializable);
                                Lbl.Cajas.Caja CajaOrigen = new Lbl.Cajas.Caja(Connection, iOrigen);
                                CajaOrigen.Movimiento(false, EntradaConcepto.Elemento as Lbl.Cajas.Concepto, 
                                        EntradaConcepto.TextDetail,
                                        Lbl.Sys.Config.Actual.UsuarioConectado.Persona,
                                        -Importe, 
                                        EntradaObs.Text, null, null, EntradaComprob.Text);
                                if (EntradaImporteDestino.Visible)
                                        Importe = EntradaImporteDestino.ValueDecimal;
                                Lbl.Cajas.Caja CajaaDestino = new Lbl.Cajas.Caja(Connection, iDestino);
                                CajaaDestino.Movimiento(false,
                                        EntradaConcepto.Elemento as Lbl.Cajas.Concepto,
                                        EntradaConcepto.TextDetail,
                                        Lbl.Sys.Config.Actual.UsuarioConectado.Persona,
                                        Importe,
                                        EntradaObs.Text, null, null, EntradaComprob.Text);
                                Trans.Commit();
                        }
                        return aceptarReturn;
                }


                private void EntradaObs_Enter(object sender, System.EventArgs e)
                {
                        int iOrigen = EntradaOrigen.TextInt;
                        int iDestino = EntradaDestino.TextInt;
                        if (EntradaObs.Text.Length == 0 && iOrigen != 0 && iDestino != 0) {
                                EntradaObs.Text = "Movimiento entre " + this.Connection.FieldString("SELECT nombre FROM cajas WHERE id_caja=" + iOrigen.ToString()) + " y " + this.Connection.FieldString("SELECT nombre FROM cajas WHERE id_caja=" + iDestino.ToString());
                        }
                }


                private void EntradaOrigenDestino_TextChanged(object sender, System.EventArgs e)
                {
                        iMonedaOrigen = this.Connection.FieldInt("SELECT id_moneda FROM cajas WHERE id_caja=" + EntradaOrigen.TextInt);
                        iMonedaDestino = this.Connection.FieldInt("SELECT id_moneda FROM cajas WHERE id_caja=" + EntradaDestino.TextInt);
                        MonedaOrigen = this.Connection.Row("monedas", "id_moneda", iMonedaOrigen);
                        MonedaDestino = this.Connection.Row("monedas", "id_moneda", iMonedaDestino);
                        if (MonedaOrigen != null && MonedaDestino != null) {
                                EntradaImporte.Prefijo = System.Convert.ToString(MonedaOrigen["signo"]);
                                EntradaImporteDestino.Prefijo = System.Convert.ToString(MonedaDestino["signo"]);
                                if (System.Convert.ToInt32(MonedaOrigen["id_moneda"]) != System.Convert.ToInt32(MonedaDestino["id_moneda"])) {
                                        EntradaImporteDestino.Text = Lfx.Types.Formatting.FormatCurrency(EntradaImporte.ValueDecimal * System.Convert.ToDecimal(MonedaDestino["cotizacion"]) / System.Convert.ToDecimal(MonedaOrigen["cotizacion"]), Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales);
                                        EntradaImporteDestino.Visible = true;
                                        lblImporteDestino.Visible = true;
                                        // TODO: EntradaImporteDestino.ShowBalloon("Se realiza una conversión de moneda según la cotización " + System.Convert.ToString(MonedaOrigen["signo"]) + " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDecimal(MonedaOrigen["cotizacion"]), Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales) + " = " + System.Convert.ToString(MonedaDestino["signo"]) + " " + Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDecimal(MonedaDestino["cotizacion"]), Lfx.Workspace.Master.CurrentConfig.Moneda.Decimales));
                                } else {
                                        EntradaImporteDestino.Visible = false;
                                        lblImporteDestino.Visible = false;
                                }
                        } else {
                                EntradaImporteDestino.Visible = false;
                                lblImporteDestino.Visible = false;
                        }
                }


                private void EntradaImporte_TextChanged(object sender, System.EventArgs e)
                {
                        if (MonedaOrigen != null && MonedaDestino != null) {
                                if (System.Convert.ToInt32(MonedaOrigen["id_moneda"]) != System.Convert.ToInt32(MonedaDestino["id_moneda"]))
                                        EntradaImporteDestino.ValueDecimal = EntradaImporte.ValueDecimal * System.Convert.ToDecimal(MonedaDestino["cotizacion"]) / System.Convert.ToDecimal(MonedaOrigen["cotizacion"]);
                        }
                }

        }
}
