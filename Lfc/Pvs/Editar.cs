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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Pvs
{
	public partial class Editar : Lui.Forms.EditForm
	{
		public Editar()
		{
			InitializeComponent();

                        System.Collections.Generic.List<string> ListaTipos = new System.Collections.Generic.List<string>();
                        ListaTipos.Add("Facutras|F");
                        ListaTipos.Add("Notas de Débito|ND");
                        ListaTipos.Add("Notas de Crédito|NC");
                        ListaTipos.Add("Facutras, Notas de Débito|F,ND");
                        ListaTipos.Add("Facutras, Notas de Crédito y Débito|F,NC,ND");
                        System.Data.DataTable DocumentosTipos = this.DataBase.Select("SELECT letra,nombre FROM documentos_tipos ORDER BY letra");
                        foreach (System.Data.DataRow DocumentoTipo in DocumentosTipos.Rows) {
                                ListaTipos.Add(DocumentoTipo["nombre"].ToString() + "|" + DocumentoTipo["letra"].ToString());
                        }
                        EntradaTipoFac.SetData = ListaTipos.ToArray();
		}


                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Comprobantes.PuntoDeVenta Pv = row as Lbl.Comprobantes.PuntoDeVenta;

                        EntradaTipo.TextKey = ((int)(Pv.Tipo)).ToString();
                        EntradaTipoFac.TextKey = Pv.TipoFac;
                        EntradaDeTalonario.TextKey = Pv.UsaTalonario ? "1" : "0";
                        EntradaSucursal.Elemento = Pv.Sucursal;
                        EntradaEstacion.Text = Pv.Estacion;
                        EntradaCarga.TextKey = Pv.CargaManual ? "1" : "0";

                        EntradaModelo.TextKey = ((int)(Pv.ModeloImpresoraFiscal)).ToString();
                        EntradaPuerto.TextKey = Pv.Puerto.ToString();
                        EntradaBps.TextKey = Pv.Bps.ToString();

                        if (Pv.Existe)
                                this.Text = "PV: " + Pv.ToString();
                        else
                                this.Text = "PV: nuevo";
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Comprobantes.PuntoDeVenta Pv = base.ToRow() as Lbl.Comprobantes.PuntoDeVenta;

                        EntradaTipo.TextKey = ((int)(Pv.Tipo)).ToString();
                        Pv.TipoFac = EntradaTipoFac.TextKey;
                        Pv.UsaTalonario = EntradaDeTalonario.TextKey == "1";
                        Pv.Sucursal = EntradaSucursal.Elemento as Lbl.Entidades.Sucursal;
                        Pv.Estacion = EntradaEstacion.Text;
                        Pv.CargaManual = EntradaCarga.TextKey == "1";

                        Pv.ModeloImpresoraFiscal = (Lbl.Comprobantes.ModelosImpresoraFiscal)(Lfx.Types.Parsing.ParseInt(EntradaModelo.TextKey));
                        Pv.Puerto = Lfx.Types.Parsing.ParseInt(EntradaPuerto.TextKey);
                        Pv.Bps = Lfx.Types.Parsing.ParseInt(EntradaBps.TextKey);

                        return Pv;
                }


                public override Lfx.Types.OperationResult Create()
                {
                        Lbl.Comprobantes.PuntoDeVenta Pv = new Lbl.Comprobantes.PuntoDeVenta(this.DataBase);
                        Pv.Numero = this.DataBase.FieldInt("SELECT MAX(id_pv)+1 FROM pvs");
                        Pv.Crear();
                        this.FromRow(Pv);

                        return new Lfx.Types.SuccessOperationResult();
                }

		private void BotonEstacionSeleccionar_Click(object sender, System.EventArgs e)
		{
                        Lui.Forms.WorkstationSelectorForm SelEst = new Lui.Forms.WorkstationSelectorForm();
			SelEst.Estacion = EntradaEstacion.Text;
			if(SelEst.ShowDialog() == DialogResult.OK)
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

