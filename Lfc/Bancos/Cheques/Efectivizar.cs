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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
        public partial class Efectivizar : Lui.Forms.DialogForm
        {
                public Lbl.Bancos.Cheque m_Cheque;

                public Efectivizar()
                {
                        InitializeComponent();
                }

                public Lbl.Bancos.Cheque Cheque
                {
                        get
                        {
                                return m_Cheque;
                        }
                        set
                        {
                                m_Cheque = value;
                                this.Connection = m_Cheque.Connection;
                                this.EntradaTotal.ValueDecimal = m_Cheque.Importe;
                                this.EntradaGestionDeCobro.Text = "0";
                                this.EntradaImpuestos.Text = "0";
                                this.OkButton.Enabled = m_Cheque.Estado <= 5;
                        }
                }

                private void EntradaImportes_TextChanged(object sender, System.EventArgs e)
                {
                        EntradaTotal.ValueDecimal = (EntradaSubTotal.ValueDecimal - EntradaGestionDeCobro.ValueDecimal - EntradaImpuestos.ValueDecimal);
                }


                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();
                        if (EntradaCajaDestino.TextInt <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "Debe especificar la cuenta de destino." + Environment.NewLine;
                        }
                        if (EntradaTotal.ValueDecimal <= 0) {
                                aceptarReturn.Success = false;
                                aceptarReturn.Message += "El importe total debe ser mayor o igual a cero." + Environment.NewLine;
                        }
                        if (aceptarReturn.Success == true) {
                                decimal GestionDeCobro = Lfx.Types.Parsing.ParseCurrency(EntradaGestionDeCobro.Text);
                                decimal Impuestos = Lfx.Types.Parsing.ParseCurrency(EntradaImpuestos.Text);

                                IDbTransaction Trans = this.Connection.BeginTransaction(IsolationLevel.Serializable);

                                Lbl.Cajas.Caja CajaDestino = EntradaCajaDestino.Elemento as Lbl.Cajas.Caja;
                                this.Cheque.Efectivizar(CajaDestino, GestionDeCobro, Impuestos);

                                Trans.Commit();
                        }
                        return aceptarReturn;
                }

        }
}