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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Cajas
{
        public partial class IngresoEgreso : Lui.Forms.DialogForm
        {
                protected internal int m_Id;
                protected internal bool m_Ingreso = true;
                protected internal double SaldoActual = 0;
                protected internal int m_Caja = 999;

                public int Caja
                {
                        get
                        {
                                return EntradaCaja.TextInt;
                        }
                        set
                        {
                                m_Caja = value;
                                EntradaCaja.TextInt = value;
                        }
                }

                public bool Ingreso
                {
                        get
                        {
                                return m_Ingreso;
                        }
                        set
                        {
                                m_Ingreso = value;
                                if (m_Ingreso) {
                                        this.Text = "Caja: Ingreso";
                                        EntradaConcepto.Filter = "(es=1 OR es=0)";
                                } else {
                                        this.Text = "Caja: Egreso";
                                        EntradaConcepto.Filter = "(es=2 OR es=0)";
                                }
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();
                        aceptarReturn.Success = true;

                        if (Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text) <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el importe." + Environment.NewLine;
                        }

                        if (EntradaCaja.TextInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Caja." + Environment.NewLine;
                        }

                        if (EntradaConcepto.TextInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el Concepto." + Environment.NewLine;
                        }

                        if (aceptarReturn.Success == true) {
                                Lbl.Cajas.Caja Caja = new Lbl.Cajas.Caja(this.DataBase, this.Caja);
                                if (m_Ingreso)
                                        Caja.Movimiento(false, EntradaConcepto.TextInt, EntradaConcepto.TextDetail, EntradaPersona.TextInt, Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text), EntradaObs.Text, 0, 0, EntradaComprobante.Text);
                                else
                                        Caja.Movimiento(false, EntradaConcepto.TextInt, EntradaConcepto.TextDetail, EntradaPersona.TextInt, -Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text), EntradaObs.Text, 0, 0, EntradaComprobante.Text);
                        }
                        return aceptarReturn;
                }

                private void IngresoEgreso_WorkspaceChanged(object sender, EventArgs e)
                {
                        EntradaPersona.Text = this.Workspace.CurrentUser.Id.ToString();
                }

                private void EntradaImporte_TextChanged(object sender, EventArgs e)
                {
                        if (Ingreso)
                                EntradaNuevoSaldo.Text = Lfx.Types.Formatting.FormatCurrency(SaldoActual + Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        else
                                EntradaNuevoSaldo.Text = Lfx.Types.Formatting.FormatCurrency(SaldoActual - Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }
        }
}