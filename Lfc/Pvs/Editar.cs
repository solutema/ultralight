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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Pvs
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Comprobantes.PuntoDeVenta);

                        InitializeComponent();

                }

                protected override void OnLoad(EventArgs e)
                {
                        base.OnLoad(e);
                        if (this.Connection != null) {
                                System.Collections.Generic.List<string> ListaTipos = new System.Collections.Generic.List<string>();
                                ListaTipos.Add("Cualquiera|*");
                                ListaTipos.Add("Facutras|F");
                                ListaTipos.Add("Notas de débito|ND");
                                ListaTipos.Add("Notas de crédito|NC");
                                ListaTipos.Add("Facutras, notas de débito|F,ND");
                                ListaTipos.Add("Facutras, notas de crédito y débito|F,NC,ND");

                                System.Data.DataTable DocumentosTipos = this.Connection.Select("SELECT letra,nombre FROM documentos_tipos ORDER BY letra");
                                foreach (System.Data.DataRow DocumentoTipo in DocumentosTipos.Rows) {
                                        ListaTipos.Add(DocumentoTipo["nombre"].ToString() + "|" + DocumentoTipo["letra"].ToString());
                                }
                                EntradaTipoFac.SetData = ListaTipos.ToArray();
                        }
                }


                public override void ActualizarControl()
                {
                        Lbl.Comprobantes.PuntoDeVenta Pv = this.Elemento as Lbl.Comprobantes.PuntoDeVenta;

                        EntradaPrefijo.ValueInt = Pv.Prefijo;
                        EntradaNumero.ValueInt = Pv.Numero;
                        if (string.IsNullOrEmpty(Pv.TipoFac))
                                EntradaTipoFac.TextKey = "*";
                        else
                                EntradaTipoFac.TextKey = Pv.TipoFac;
                        EntradaSucursal.Elemento = Pv.Sucursal;
                        EntradaImpresora.Elemento = Pv.Impresora;

                        EntradaTipo.ValueInt = (int)(Pv.Tipo);

                        EntradaDeTalonario.ValueInt = Pv.UsaTalonario ? 1 : 0;
                        EntradaEstacion.Text = Pv.Estacion;
                        EntradaCarga.ValueInt = Pv.CargaManual ? 1 : 0;

                        EntradaModelo.ValueInt = ((int)(Pv.ModeloImpresoraFiscal));
                        EntradaPuerto.ValueInt = Pv.Puerto;
                        EntradaBps.ValueInt = Pv.Bps;

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Comprobantes.PuntoDeVenta Pv = this.Elemento as Lbl.Comprobantes.PuntoDeVenta;

                        Pv.Prefijo = EntradaPrefijo.ValueInt;
                        Pv.Numero = EntradaNumero.ValueInt;
                        if (EntradaTipoFac.TextKey == "*")
                                Pv.TipoFac = "";
                        else
                                Pv.TipoFac = EntradaTipoFac.TextKey;
                        Pv.Sucursal = EntradaSucursal.Elemento as Lbl.Entidades.Sucursal;
                        Pv.Impresora = EntradaImpresora.Elemento as Lbl.Impresion.Impresora;

                        Pv.Tipo = (Lbl.Comprobantes.TipoPv)(EntradaTipo.ValueInt);

                        Pv.UsaTalonario = EntradaDeTalonario.ValueInt == 1;
                        Pv.Estacion = EntradaEstacion.Text;
                        Pv.CargaManual = EntradaCarga.ValueInt == 1;

                        Pv.ModeloImpresoraFiscal = (Lbl.Impresion.ModelosFiscales)(EntradaModelo.ValueInt);
                        Pv.Puerto = EntradaPuerto.ValueInt;
                        Pv.Bps = EntradaBps.ValueInt;

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

                                if (EntradaEstacion.Text.Length == 0)
                                        EntradaEstacion.Text = Lfx.Environment.SystemInformation.MachineName;
                        } else {
                                EntradaModelo.Enabled = false;
                                EntradaPuerto.Enabled = false;
                                EntradaBps.Enabled = false;
                                EntradaCarga.Enabled = true;
                        }
                }


                public override Lfx.Types.OperationResult ValidarControl()
                {
                        if (EntradaSucursal.Elemento == null)
                                return new Lfx.Types.FailureOperationResult("Por favor seleccione una sucursal.");

                        if (EntradaNumero.ValueInt <= 0)
                                return new Lfx.Types.FailureOperationResult("Por favor escriba el número para este punto de venta.");

                        if (EntradaTipo.ValueInt == 2) {
                                if (EntradaEstacion.Text.Length == 0)
                                        return new Lfx.Types.FailureOperationResult("Por favor seleccione el equipo a la cual está conectada la impresora fiscal.");
                        }

                        return base.ValidarControl();
                }

                public override void AfterSave(System.Data.IDbTransaction transaction)
                {
                        Lbl.Comprobantes.PuntoDeVenta.TodosPorNumero.Clear();

                        base.AfterSave(transaction);
                }
        }
}