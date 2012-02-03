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

namespace Lfc.Comprobantes.Facturas
{
	public partial class Reimprimir : Lui.Forms.ChildDialogForm
	{
		Dictionary<int, int> ProximosNumeros = new Dictionary<int,int>();

                public Reimprimir()
                {
                        if (Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(typeof(Lbl.Comprobantes.Factura), Lbl.Sys.Permisos.Operaciones.Imprimir) == false) {
                                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                                this.Close();
                                return;
                        }

                        InitializeComponent();

                        OkButton.Text = "Reimprimir";
                        OkButton.Visible = false;
                }

                private void EntradaDesdeTipoPV_TextChanged(object sender, System.EventArgs e)
                {
                        int PV = EntradaPV.ValueInt;
                        int Desde = EntradaDesde.ValueInt;

                        if ((EntradaHasta.ValueInt == 0 || EntradaHasta.ValueInt < Desde) && this.ActiveControl != EntradaHasta)
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

                        if (Desde > ProximosNumeros[PV] || Hasta > ProximosNumeros[PV]) {
                                EtiquetaAviso.Text = "No se puede reimprimir el rango seleccionado porque todavía no se utilizaron los comprobantes desde el " + ProximosNumeros[PV].ToString() + " al " + (Desde - 1).ToString();
                                ComprobanteVistaPrevia.Visible = false;
                                ListadoFacturas.Visible = false;
                                OkButton.Visible = false;
                                return;
                        }

                        ComprobanteVistaPrevia.Visible = Cantidad == 1;
                        ListadoFacturas.Visible = Cantidad > 1;

                        if (Cantidad == 1) {
                                int IdFactura = this.Connection.FieldInt("SELECT id_comprob FROM comprob WHERE impresa=1 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero=" + Desde.ToString());

                                Lbl.Comprobantes.ComprobanteFacturable FacturaInicial = null;
                                if (IdFactura > 0)
                                        FacturaInicial = new Lbl.Comprobantes.ComprobanteFacturable(this.Connection, IdFactura);

                                if (FacturaInicial != null && FacturaInicial.Existe) {
                                        ComprobanteVistaPrevia.Elemento = FacturaInicial;
                                        ComprobanteVistaPrevia.ActualizarControl();
                                        ComprobanteVistaPrevia.TemporaryReadOnly = true;
                                        ComprobanteVistaPrevia.Visible = true;

                                        if (FacturaInicial.Anulado) {
                                                EtiquetaAviso.Text = "El comprobante fue anulado y no puede reimprimirse.";
                                                OkButton.Visible = false;
                                        } else {
                                                EtiquetaAviso.Text = "";
                                                OkButton.Visible = true;
                                        }
                                } else {
                                        ComprobanteVistaPrevia.Visible = false;

                                        EtiquetaAviso.Text = "El comprobante " + EntradaTipo.TextKey + " " + PV.ToString("0000") + "-" + Lfx.Types.Parsing.ParseInt(EntradaDesde.Text).ToString("00000000") + " aun no fue impreso y no puede reimprimirse.";
                                        EntradaOrden.TextKey = "0";
                                        OkButton.Visible = false;
                                }
                        } else if (Cantidad > 1) {
                                System.Data.DataTable TablaFacturas = this.Connection.Select("SELECT * FROM comprob WHERE impresa=1 AND anulada=0 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + PV.ToString() + " AND numero BETWEEN " + Desde.ToString() + " AND " + Hasta.ToString());
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
                                EtiquetaAviso.Text = "Se van a reimprimir " + Cantidad.ToString() + " comprobantes, incluyendo los que se detallan a continuación.";
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

                        int DesdeReal, HastaReal;
                        if (EntradaOrden.TextKey == "1") {
                                DesdeReal = Hasta;
                                HastaReal = Desde - 1;
                        } else {
                                DesdeReal = Desde;
                                HastaReal = Hasta + 1;
                        }

                        Lui.Forms.YesNoDialog Pregunta = new Lui.Forms.YesNoDialog("Por favor verifique que impresora tenga " + Cantidad.ToString() + " comprobantes, iniciando con el Nº " + PV.ToString("0000") + "-" + DesdeReal.ToString("00000000"), "¿Está seguro de que desea reimprimir " + Cantidad.ToString() + " comprobantes?");
                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;

                        if (Pregunta.ShowDialog() == DialogResult.OK) {
                                System.Threading.ThreadStart ThreadFiltro = delegate { ProcesarReimpresion(EntradaTipo.TextKey, PV, DesdeReal, HastaReal); ; };
                                System.Threading.Thread Thr = new System.Threading.Thread(ThreadFiltro);
                                Thr.IsBackground = true;
                                Thr.Start();

                                ProximosNumeros.Clear();

                                EntradaDesde.Text = "0";
                                EntradaHasta.Text = "0";
                                EntradaDesde.Focus();

                                return new Lfx.Types.CancelOperationResult();
                        } else {
                                return new Lfx.Types.FailureOperationResult("La operación fue cancelada.");
                        }
                }


                private void ProcesarReimpresion(string tipo, int pv, int desde, int hasta)
                {
                        using (Lfx.Data.Connection Conn = Lfx.Workspace.Master.GetNewConnection("Reimpresión de comprobantes")) {

                                int Cantidad = Math.Abs(hasta - desde);
                                Lfx.Types.OperationProgress Progreso = new Lfx.Types.OperationProgress("Reimprimiendo...", "Se están reimprimiendo " + Cantidad.ToString() + " comprobantes.");
                                Progreso.Cancelable = true;
                                Progreso.Max = Cantidad;
                                Progreso.Modal = true;
                                Progreso.Advertise = true;
                                Progreso.Begin();

                                string IncluyeTipos = "";

                                switch (tipo) {
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

                                int Paso = desde < hasta ? 1 : -1;
                                for (int Numero = desde; Numero != hasta; Numero += Paso) {
                                        int IdFactura = Connection.FieldInt("SELECT id_comprob FROM comprob WHERE impresa=1 AND anulada=0 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + pv.ToString() + " AND numero=" + Numero.ToString());

                                        if (IdFactura == 0) {
                                                // No existe, supongo que está anulado, lo salteo
                                        } else {
                                                Lbl.Comprobantes.ComprobanteConArticulos Fac = new Lbl.Comprobantes.ComprobanteConArticulos(Conn, IdFactura);
                                                Progreso.ChangeStatus("Imprimiendo " + Fac.ToString());
                                                Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos Impr = new Lazaro.Impresion.Comprobantes.ImpresorComprobanteConArticulos(Fac, null);
                                                Impr.Reimpresion = true;
                                                Impr.Imprimir();
                                        }
                                        Progreso.Advance(1);

                                        if (Progreso.Cancelar)
                                                break;
                                }

                                Progreso.End();
                        }
                }


                private void EntradaHasta_Enter(object sender, EventArgs e)
                {
                        if (EntradaHasta.ValueInt == 0 && EntradaDesde.ValueInt > 0)
                                EntradaHasta.ValueInt = EntradaDesde.ValueInt;
                }
	}
}