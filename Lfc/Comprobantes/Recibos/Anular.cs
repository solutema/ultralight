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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
        public partial class Anular : Lui.Forms.DialogForm
        {
                public Anular()
                {
                        InitializeComponent();
                        if (Lui.Login.LoginData.ValidateAccess(Lws.Workspace.Master.CurrentUser, "documents.delete") == false)
                                this.Close();
                }

                private void EntradaNumeroTipoPV(object sender, EventArgs e)
                {
                        
                        int Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        int PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                        Lbl.Comprobantes.Recibo Rec = null;

                        int IdRecibo = 0;
                        if (Numero > 0)
                                IdRecibo = this.DataView.DataBase.FieldInt("SELECT id_recibo FROM recibos WHERE tipo_fac='" + EntradaTipo.TextKey + "' AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString());
                        if (IdRecibo != 0)
                                Rec = new Lbl.Comprobantes.Recibo(this.DataView, IdRecibo);

                        if (Rec != null && Rec.Existe) {
                                EntradaFecha.Text = Lfx.Types.Formatting.FormatDate(Rec.Fecha);

                                EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(Rec.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                                EntradaCliente.Text = Rec.Cliente.ToString();

                                if (Rec.Anulado) {
                                        EtiquetaAviso.Text = "El comprobante ya fue anulado y no puede anularse nuevamente.";
                                        OkButton.Visible = false;
                                } else {
                                        EtiquetaAviso.Text = "Recuerde que necesitar archivar todas las copias del comprobante anulado.";
                                        OkButton.Visible = true;
                                }
                        } else {
                                EtiquetaAviso.Text = "";
                                EntradaFecha.Text = "";
                                EntradaImporte.Text = "";
                                EntradaCliente.Text = "";
                                OkButton.Visible = false;
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Una vez anulado, el comprobante deberá ser archivado en todas sus copias y no podrá ser rehabilitado ni reutilizado.", "¿Está seguro de que desea anular el comprobante?");
                        Pregunta.DialogButton = Lui.Forms.YesNoDialog.DialogButtons.YesNo;

                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                int Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                                int PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                                Lbl.Comprobantes.Recibo Rec = null;

                                int IdRecibo = 0;
                                if (Numero > 0)
                                        IdRecibo = this.DataView.DataBase.FieldInt("SELECT id_recibo FROM recibos WHERE tipo_fac='" + EntradaTipo.TextKey + "' AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString());
                                if (IdRecibo != 0)
                                        Rec = new Lbl.Comprobantes.Recibo(this.DataView, IdRecibo);

                                if (Rec != null && Rec.Existe) {
                                        Rec.DataView.BeginTransaction();
                                        Rec.Anular();
                                        Rec.DataView.Commit();
                                }

                                EntradaNumero.Text = "";
                                EntradaNumero.Focus();

                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.CancelOperationResult();
                        }
                }
        }
}
