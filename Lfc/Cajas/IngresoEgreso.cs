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
using System.ComponentModel;
using System.Data;

namespace Lfc.Cajas
{
        public partial class IngresoEgreso : Lui.Forms.DialogForm
        {
                protected internal int m_Id;
                protected internal bool m_Ingreso = true;
                protected internal decimal SaldoActual = 0;
                protected internal Lbl.Cajas.Caja m_Caja = null;

                public IngresoEgreso()
                {
                        this.InitializeComponent();

                        if (this.Connection != null)
                                this.Caja = new Lbl.Cajas.Caja(this.Connection, 999);
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lbl.Cajas.Caja Caja
                {
                        get
                        {
                                return EntradaCaja.Elemento as Lbl.Cajas.Caja;
                        }
                        set
                        {
                                m_Caja = value;
                                EntradaCaja.Elemento = value;
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

                        if (EntradaCaja.ValueInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la Caja." + Environment.NewLine;
                        }

                        if (EntradaConcepto.ValueInt == 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar el Concepto." + Environment.NewLine;
                        }

                        if (aceptarReturn.Success == true) {
                                using (IDbTransaction Trans = this.Caja.Connection.BeginTransaction()) {
                                        if (m_Ingreso)
                                                this.Caja.Movimiento(false,
                                                        EntradaConcepto.Elemento as Lbl.Cajas.Concepto,
                                                        EntradaConcepto.TextDetail,
                                                        EntradaPersona.Elemento as Lbl.Personas.Persona,
                                                        EntradaImporte.ValueDecimal,
                                                        EntradaObs.Text,
                                                        null,
                                                        null,
                                                        EntradaComprobante.Text);
                                        else
                                                this.Caja.Movimiento(false,
                                                        EntradaConcepto.Elemento as Lbl.Cajas.Concepto,
                                                        EntradaConcepto.TextDetail,
                                                        EntradaPersona.Elemento as Lbl.Personas.Persona,
                                                        -EntradaImporte.ValueDecimal,
                                                        EntradaObs.Text,
                                                        null,
                                                        null,
                                                        EntradaComprobante.Text);
                                        Trans.Commit();
                                }
                        }
                        return aceptarReturn;
                }

                protected override void OnLoad(EventArgs e)
                {
                        base.OnLoad(e);
                        if (this.Connection != null)
                                EntradaPersona.Elemento = Lbl.Sys.Config.Actual.UsuarioConectado.Persona;
                }

                private void EntradaImporte_TextChanged(object sender, EventArgs e)
                {
                        if (Ingreso)
                                EntradaNuevoSaldo.ValueDecimal = SaldoActual + EntradaImporte.ValueDecimal;
                        else
                                EntradaNuevoSaldo.ValueDecimal = SaldoActual - EntradaImporte.ValueDecimal;
                }
        }
}