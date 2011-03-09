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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Facturas
{
	public partial class Anular : Lui.Forms.ChildDialogForm
	{
		Dictionary<int, int> ProximosNumeros = new Dictionary<int,int>();

                public Anular()
                {
                        InitializeComponent();

                        OkButton.Text = "Anular";
                        OkButton.Visible = false;
                }

                private void EntradaDesdeTipoPV_TextChanged(object sender, System.EventArgs e)
                {
                        int PV = EntradaPV.ValueInt;
                        int Desde = EntradaDesde.ValueInt;

                        if (EntradaHasta.ValueInt == 0 && this.ActiveControl != EntradaHasta)
                                EntradaHasta.ValueInt = Desde;

                        int Hasta = EntradaHasta.ValueInt;
                        int Cantidad = Hasta - Desde + 1;

                        string IncluyeTipos = "";

                        switch (EntradaTipo.TextKey) {
                                case "A":
                                        IncluyeTipos = "'FA', 'NCA', 'NDA'";
                                        break;

                                case "B":
                                        IncluyeTipos = "'FB', 'NCB', 'NDB'";
                                        break;

                                case "C":
                                        IncluyeTipos = "'FC', 'NCC', 'NDC'";
                                        break;

                                case "E":
                                        IncluyeTipos = "'FE', 'NCE', 'NDE'";
                                        break;

                                case "M":
                                        IncluyeTipos = "'FM', 'NCM', 'NDM'";
                                        break;
                        }

                        if (ProximosNumeros.ContainsKey(PV) == false)
                                ProximosNumeros[PV] = this.Connection.FieldInt("SELECT MAX(numero) FROM comprob WHERE impresa=1 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString()) + 1;

                        if (PV <= 0 || Desde <= 0 || Cantidad <= 0) {
                                EtiquetaAviso.Text = "El rango seleccionado no es válido.";
                                ComprobanteVistaPrevia.Visible = false;
                                ListadoFacturas.Visible = false;
                                OkButton.Visible = false;
                                return;
                        }

                        if (Desde > ProximosNumeros[PV]) {
                                EtiquetaAviso.Text = "No se puede anular el rango seleccionado porque todavía no se utilizaron los comprobantes desde el " + ProximosNumeros[PV].ToString() + " al " + (Desde - 1).ToString();
                                ComprobanteVistaPrevia.Visible = false;
                                ListadoFacturas.Visible = false;
                                OkButton.Visible = false;
                                return;
                        }

                        ComprobanteVistaPrevia.Visible = Cantidad == 1;
                        ListadoFacturas.Visible = Cantidad > 1;

                        if (Cantidad == 1) {
                                int IdFactura = this.Connection.FieldInt("SELECT id_comprob FROM comprob WHERE impresa=1 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero=" + Desde.ToString());

                                Lbl.Comprobantes.ComprobanteConArticulos FacturaInicial = null;
                                if (IdFactura > 0)
                                        FacturaInicial = new Lbl.Comprobantes.ComprobanteConArticulos(this.Connection, IdFactura);

                                if (FacturaInicial != null && FacturaInicial.Existe) {
                                        ComprobanteVistaPrevia.Elemento = FacturaInicial;
                                        ComprobanteVistaPrevia.ActualizarControl();
                                        ComprobanteVistaPrevia.ReadOnly = true;
                                        ComprobanteVistaPrevia.Visible = true;

                                        if (FacturaInicial.Anulado) {
                                                EtiquetaAviso.Text = "El comprobante ya fue anulado y no puede anularse nuevamente.";
                                                OkButton.Visible = false;
                                        } else {
                                                EtiquetaAviso.Text = "Recuerde que necesitar archivar todas las copias del comprobante anulado.";
                                                OkButton.Visible = true;
                                                if (FacturaInicial.FormaDePago.Tipo == Lbl.Pagos.TiposFormasDePago.CuentaCorriente) {
                                                        EntradaAnularPagos.TextKey = "1";
                                                } else {
                                                        EntradaAnularPagos.TextKey = "0";
                                                }
                                        }
                                } else {
                                        ComprobanteVistaPrevia.Visible = false;

                                        if (Desde == ProximosNumeros[PV]) {
                                                EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Desde.ToString("00000000") + " aun no fue impreso, pero es el próximo en el talonario. Si lo anula, el sistema salteará dicho comprobante.";
                                                EntradaAnularPagos.TextKey = "0";
                                                OkButton.Visible = true;
                                        } else {
                                                EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Lfx.Types.Parsing.ParseInt(EntradaDesde.Text).ToString("00000000") + " aun no fue impreso y no puede anularse.";
                                                EntradaAnularPagos.TextKey = "0";
                                                OkButton.Visible = false;
                                        }
                                }
                        } else if (Cantidad > 1) {
                                EntradaAnularPagos.TextKey = "1";
                                System.Data.DataTable TablaFacturas = this.Connection.Select("SELECT * FROM comprob WHERE impresa=1 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero BETWEEN " + Desde.ToString() + " AND " + Hasta.ToString());
                                Lbl.Comprobantes.ColeccionComprobanteConArticulos Facturas = new Lbl.Comprobantes.ColeccionComprobanteConArticulos(this.Connection, TablaFacturas);
                                ListadoFacturas.BeginUpdate();
                                ListadoFacturas.Items.Clear();
                                foreach (Lbl.Comprobantes.ComprobanteConArticulos Fac in Facturas) {
                                        ListViewItem Itm = ListadoFacturas.Items.Add(Fac.Tipo.ToString());
                                        Itm.SubItems.Add(Fac.PV.ToString("0000") + "-" + Fac.Numero.ToString("00000000"));
                                        Itm.SubItems.Add(Fac.Fecha.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern));
                                        Itm.SubItems.Add(Fac.Cliente.ToString());
                                        Itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Fac.Total));
                                }
                                ListadoFacturas.EndUpdate();
                                EtiquetaAviso.Text = "Se van a anular " + Cantidad.ToString() + " comprobantes, incluyendo los que se detallan a continuación.";
                                this.OkButton.Visible = true;
                        } else {
                                EtiquetaAviso.Text = "Debe seleccionar un rango que inlcuya al menos 1 comprobante.";
                                ListadoFacturas.Items.Clear();
                                this.OkButton.Visible = false;
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        int PV = EntradaPV.ValueInt;
                        int Desde = EntradaDesde.ValueInt;
                        int Hasta = EntradaHasta.ValueInt;
                        int Cantidad = Hasta - Desde + 1;

                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Una vez anulados, los comprobantes deberán ser archivados en todas sus copias y no podrán ser rehabilitados ni reutilizados.", "¿Está seguro de que desea anular " + Cantidad.ToString() + " comprobantes?");
                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;

                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                bool AnularPagos = Lfx.Types.Parsing.ParseInt(EntradaAnularPagos.TextKey) != 0;

                                this.Connection.BeginTransaction(true);
                                int m_Id = 0;
                                string IncluyeTipos = "";

                                switch (EntradaTipo.TextKey) {
                                        case "A":
                                                IncluyeTipos = "'FA', 'NCA', 'NDA'";
                                                break;

                                        case "B":
                                                IncluyeTipos = "'FB', 'NCB', 'NDB'";
                                                break;

                                        case "C":
                                                IncluyeTipos = "'FC', 'NCC', 'NDC'";
                                                break;

                                        case "E":
                                                IncluyeTipos = "'FE', 'NCE', 'NDE'";
                                                break;

                                        case "M":
                                                IncluyeTipos = "'FM', 'NCM', 'NDM'";
                                                break;
                                }

                                for (int Numero = Desde; Numero <= Hasta; Numero++) {
                                        int IdFactura = Connection.FieldInt("SELECT id_comprob FROM comprob WHERE impresa=1 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero=" + Numero.ToString());

                                        if (IdFactura == 0) {
                                                // Es una factura que todava no existe
                                                // Tengo que crear la factura y anularla
                                                qGen.Insert InsertarComprob = new qGen.Insert("comprob");
                                                InsertarComprob.Fields.AddWithValue("tipo_fac", "F" + EntradaTipo.TextKey);
                                                InsertarComprob.Fields.AddWithValue("id_formapago", 3);
                                                InsertarComprob.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);
                                                InsertarComprob.Fields.AddWithValue("pv", Lfx.Types.Parsing.ParseInt(EntradaPV.Text));
                                                InsertarComprob.Fields.AddWithValue("fecha", qGen.SqlFunctions.Now);
                                                InsertarComprob.Fields.AddWithValue("id_vendedor", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                                                InsertarComprob.Fields.AddWithValue("id_cliente", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                                                InsertarComprob.Fields.AddWithValue("obs", "Comprobante anulado antes de ser impreso.");
                                                InsertarComprob.Fields.AddWithValue("impresa", 1);
                                                InsertarComprob.Fields.AddWithValue("anulada", 1);
                                                Connection.Execute(InsertarComprob);
                                                m_Id = Connection.FieldInt("SELECT LAST_INSERT_ID()");
                                                Lbl.Comprobantes.ComprobanteConArticulos NuevoComprob = new Lbl.Comprobantes.ComprobanteConArticulos(this.Connection, m_Id);
                                                NuevoComprob.Numerar(true);
                                        } else {
                                                Lbl.Comprobantes.ComprobanteConArticulos Fac = new Lbl.Comprobantes.ComprobanteConArticulos(Connection, IdFactura);
                                                if (Fac.Anulado == false)
                                                        Fac.Anular(AnularPagos);
                                        }
                                }

                                ProximosNumeros.Clear();

                                this.Connection.Commit();

                                Lui.Forms.MessageBox.Show("Se anularon los comprobantes seleccionados. Recuerde archivar ambas copias.", "Aviso");

                                EntradaDesde.Text = "0";
                                EntradaHasta.Text = "0";
                                EntradaDesde.Focus();

                                return base.Ok(); 
                        } else {
                                return new Lfx.Types.FailureOperationResult("La operación fue cancelada.");
                        }
                }

                private void EntradaHasta_Enter(object sender, EventArgs e)
                {
                        if (EntradaHasta.ValueInt == 0 && EntradaDesde.ValueInt > 0)
                                EntradaHasta.ValueInt = EntradaDesde.ValueInt;
                }
	}
}