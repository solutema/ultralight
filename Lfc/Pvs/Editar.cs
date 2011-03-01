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
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Pvs
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                public Editar()
                {
                        this.ElementoTipo = typeof(Lbl.Comprobantes.PuntoDeVenta);

                        InitializeComponent();

                }

                public override void OnWorkspaceChanged()
                {
                        if (this.HasWorkspace) {
                                System.Collections.Generic.List<string> ListaTipos = new System.Collections.Generic.List<string>();
                                ListaTipos.Add("Facutras|F");
                                ListaTipos.Add("Notas de Débito|ND");
                                ListaTipos.Add("Notas de Crédito|NC");
                                ListaTipos.Add("Facutras, Notas de Débito|F,ND");
                                ListaTipos.Add("Facutras, Notas de Crédito y Débito|F,NC,ND");

                                System.Data.DataTable DocumentosTipos = this.Connection.Select("SELECT letra,nombre FROM documentos_tipos ORDER BY letra");
                                foreach (System.Data.DataRow DocumentoTipo in DocumentosTipos.Rows) {
                                        ListaTipos.Add(DocumentoTipo["nombre"].ToString() + "|" + DocumentoTipo["letra"].ToString());
                                }
                                EntradaTipoFac.SetData = ListaTipos.ToArray();
                        }

                        base.OnWorkspaceChanged();
                }


                public override void ActualizarControl()
                {
                        Lbl.Comprobantes.PuntoDeVenta Pv = this.Elemento as Lbl.Comprobantes.PuntoDeVenta;

                        EntradaNumero.Text = Pv.Numero.ToString();
                        EntradaTipoFac.TextKey = Pv.TipoFac;
                        EntradaSucursal.Elemento = Pv.Sucursal;
                        EntradaImpresora.Elemento = Pv.Impresora;

                        EntradaTipo.TextKey = ((int)(Pv.Tipo)).ToString();

                        EntradaDeTalonario.TextKey = Pv.UsaTalonario ? "1" : "0";
                        EntradaEstacion.Text = Pv.Estacion;
                        EntradaCarga.TextKey = Pv.CargaManual ? "1" : "0";

                        EntradaModelo.TextKey = ((int)(Pv.ModeloImpresoraFiscal)).ToString();
                        EntradaPuerto.TextKey = Pv.Puerto.ToString();
                        EntradaBps.TextKey = Pv.Bps.ToString();

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Comprobantes.PuntoDeVenta Pv = this.Elemento as Lbl.Comprobantes.PuntoDeVenta;

                        Pv.Numero = Lfx.Types.Parsing.ParseInt(EntradaNumero.Text);
                        Pv.TipoFac = EntradaTipoFac.TextKey;
                        Pv.Sucursal = EntradaSucursal.Elemento as Lbl.Entidades.Sucursal;
                        Pv.Impresora = EntradaImpresora.Elemento as Lbl.Impresion.Impresora;

                        Pv.Tipo = (Lbl.Comprobantes.TipoPv)Lfx.Types.Parsing.ParseInt(EntradaTipo.TextKey);

                        Pv.UsaTalonario = EntradaDeTalonario.TextKey == "1";
                        Pv.Estacion = EntradaEstacion.Text;
                        Pv.CargaManual = EntradaCarga.TextKey == "1";

                        Pv.ModeloImpresoraFiscal = (Lbl.Impresion.ModelosFiscales)(Lfx.Types.Parsing.ParseInt(EntradaModelo.TextKey));
                        Pv.Puerto = Lfx.Types.Parsing.ParseInt(EntradaPuerto.TextKey);
                        Pv.Bps = Lfx.Types.Parsing.ParseInt(EntradaBps.TextKey);

                        base.ActualizarElemento();
                }

                private void BotonEstacionSeleccionar_Click(object sender, System.EventArgs e)
                {
                        Lui.Forms.WorkstationSelectorForm SelEst = new Lui.Forms.WorkstationSelectorForm();
                        SelEst.Estacion = EntradaEstacion.Text;
                        if (SelEst.ShowDialog() == DialogResult.OK)
                                EntradaEstacion.Text = SelEst.Estacion;
                }

                private void EntradaTipo_TextChanged(object sender, System.EventArgs e)
                {
                        if (EntradaTipo.TextKey == "2") {
                                EntradaModelo.Enabled = true;
                                EntradaPuerto.Enabled = true;
                                EntradaBps.Enabled = true;
                                EntradaCarga.Enabled = false;
                        } else {
                                EntradaModelo.Enabled = false;
                                EntradaPuerto.Enabled = false;
                                EntradaBps.Enabled = false;
                                EntradaCarga.Enabled = true;
                        }
                }
        }
}