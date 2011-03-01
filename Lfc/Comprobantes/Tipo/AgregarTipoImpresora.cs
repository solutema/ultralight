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

namespace Lfc.Comprobantes.Tipo
{
        public partial class AgregarTipoImpresora : Lui.Forms.DialogForm
        {
                public Lbl.Comprobantes.Tipo Tipo;

                public AgregarTipoImpresora()
                {
                        InitializeComponent();
                }

                public Lbl.Impresion.TipoImpresora TipoImpresora
                {
                        get
                        {
                                Lbl.Impresion.TipoImpresora Res = new Lbl.Impresion.TipoImpresora(this.Tipo.Connection);
                                Res.Tipo = Tipo;
                                Res.Impresora = EntradaImpresora.Elemento as Lbl.Impresion.Impresora;
                                Res.Sucursal = EntradaSucursal.Elemento as Lbl.Entidades.Sucursal;
                                if (EntradaEstacion.Text.Length > 0)
                                        Res.Estacion = EntradaEstacion.Text;
                                else
                                        Res.Estacion = null;

                                int Pv = Lfx.Types.Parsing.ParseInt(EntradaPuntoDeVenta.Text);
                                if (Pv > 0) {
                                        int IdPv = this.Connection.FieldInt("SELECT id_pv FROM pvs WHERE numero=" + Pv.ToString());
                                        if (IdPv == 0)
                                                Res.PuntoDeVenta = null;
                                        else
                                                Res.PuntoDeVenta = new Lbl.Comprobantes.PuntoDeVenta(this.Connection, IdPv);
                                } else {
                                        Res.PuntoDeVenta = null;
                                }

                                return Res;
                        }
                }

                private void BotonEstacionSeleccionar_Click(object sender, EventArgs e)
                {
                        Lui.Forms.WorkstationSelectorForm SelEst = new Lui.Forms.WorkstationSelectorForm();
                        SelEst.Estacion = EntradaEstacion.Text;
                        if (SelEst.ShowDialog() == DialogResult.OK)
                                EntradaEstacion.Text = SelEst.Estacion;
                }
        }
}
