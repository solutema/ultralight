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

                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.ColeccionComprobanteConArticulos), Lbl.Sys.Permisos.Operaciones.Eliminar) == false)
                                this.Close();
                }

                public void Cargar(int idRecibo)
                {
                        Lbl.Comprobantes.Recibo Rec = null;

                        if (idRecibo != 0)
                                Rec = new Lbl.Comprobantes.Recibo(this.Connection, idRecibo);

                        if (Rec != null && Rec.Existe) {
                                EntradaFecha.Text = Lfx.Types.Formatting.FormatDate(Rec.Fecha);

                                EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(Rec.Total, this.Workspace.CurrentConfig.Moneda.Decimales);
                                EntradaCliente.Text = Rec.Cliente.ToString();

                                EntradaPV.Text = Rec.PV.ToString();
                                EntradaNumero.Text = Rec.Numero.ToString();
                                EntradaTipo.TextKey = Rec.Tipo.Nomenclatura;

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

                private void EntradaNumeroTipoPV(object sender, EventArgs e)
                {

                        int Numero = EntradaNumero.ValueInt; ;
                        int PV = EntradaPV.ValueInt;

                        int IdRecibo = 0;
                        if (Numero > 0)
                                IdRecibo = this.Connection.FieldInt("SELECT id_recibo FROM recibos WHERE tipo_fac='" + EntradaTipo.TextKey + "' AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString() + " ORDER BY id_recibo DESC");

                        this.Cargar(IdRecibo);
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        if (Lui.LogOn.LogOnData.ValidateAccess(typeof(Lbl.Comprobantes.Recibo), Lbl.Sys.Permisos.Operaciones.Eliminar) == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Una vez anulado, el comprobante deberá ser archivado en todas sus copias y no podrá ser rehabilitado ni reutilizado.", "¿Está seguro de que desea anular el comprobante?");
                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;

                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                int Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                                int PV = Lfx.Types.Parsing.ParseInt(EntradaPV.Text);
                                Lbl.Comprobantes.Recibo Rec = null;

                                int IdRecibo = 0;
                                if (Numero > 0)
                                        IdRecibo = this.Connection.FieldInt("SELECT id_recibo FROM recibos WHERE tipo_fac='" + EntradaTipo.TextKey + "' AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString());
                                if (IdRecibo != 0)
                                        Rec = new Lbl.Comprobantes.Recibo(this.Connection, IdRecibo);

                                if (Rec != null && Rec.Existe) {
                                        IDbTransaction Trans = Rec.Connection.BeginTransaction(IsolationLevel.Serializable);
                                        Rec.Anular();
                                        Trans.Commit();
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
