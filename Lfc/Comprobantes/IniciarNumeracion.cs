#region License
// Copyright 2004-2010 Ernesto N. Carrea
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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public partial class IniciarNumeracion : Lui.Forms.ChildDialogForm
        {
                public IniciarNumeracion()
                {
                        InitializeComponent();

                        EntradaTipoPvDesde_TextChanged(null, null);
                }

                private void EntradaTipoPvDesde_TextChanged(object sender, EventArgs e)
                {
                        if(EntradaPv.ValueInt < 0 || EntradaPv.ValueInt > 999) {
                                LabelAyuda.Text = "Seleccione el Tipo de Comprobante y un Punto de Venta apropiado.";
                                OkButton.Enabled = false;
                        }

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

                        int ProxNum = this.Connection.FieldInt("SELECT MAX(numero) FROM comprob WHERE compra=0 AND impresa=1 AND anulada=0 AND tipo_fac IN (" + IncluyeTipos + ") AND pv=" + EntradaPv.ValueInt.ToString());
                        if (ProxNum == 0) {
                                if (EntradaDesde.ValueInt < 2) {
                                        LabelAyuda.Text = "Seleccione el Próximo Número a utilizar en el talonario " + EntradaTipo.TextKey + " " + EntradaPv.ValueInt.ToString("0000") + ". El Próximo Número debe ser 2 o más (para comenzar el talonario en el número 1 no es necesario iniciar el Talonario).";
                                        OkButton.Enabled = false;
                                } else {
                                        LabelAyuda.Text = "El talonario " + EntradaTipo.TextKey + " " + EntradaPv.ValueInt.ToString("0000") + " comenzará (o continuará) la impresión en el número " + EntradaDesde.ValueInt.ToString("00000000") + ".";
                                        OkButton.Enabled = true;
                                }
                        } else {
                                LabelAyuda.Text = "No se puede iniciar la numeración en el talonario " + EntradaTipo.TextKey + " " + EntradaPv.ValueInt.ToString("0000") + " porque el talonario ya está en uso, y el próximo comprobante que se imprima tendrá el número " + ProxNum.ToString("00000000")+ ". Si lo que necesita es anular el resto del Talonario, puede utilizar la función de Anular Comprobante.";
                                OkButton.Enabled = false;
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        if (EntradaPv.ValueInt < 0 || EntradaPv.ValueInt > 999) {
                                LabelAyuda.Text = "Seleccione el Tipo de Comprobante y un Punto de Venta apropiado.";
                                OkButton.Enabled = false;
                        }

                        this.Connection.BeginTransaction();
                        qGen.Insert InsertarComprob = new qGen.Insert("comprob");
                        InsertarComprob.Fields.AddWithValue("tipo_fac", "F" + EntradaTipo.TextKey);
                        InsertarComprob.Fields.AddWithValue("id_formapago", 3);
                        InsertarComprob.Fields.AddWithValue("id_sucursal", this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada);
                        InsertarComprob.Fields.AddWithValue("pv", EntradaPv.ValueInt);
                        InsertarComprob.Fields.AddWithValue("numero", EntradaDesde.ValueInt - 1);
                        InsertarComprob.Fields.AddWithValue("fecha", new DateTime(1900, 1, 1, 0, 0, 0));
                        InsertarComprob.Fields.AddWithValue("id_vendedor", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                        InsertarComprob.Fields.AddWithValue("id_cliente", Lbl.Sys.Config.Actual.UsuarioConectado.Id);
                        InsertarComprob.Fields.AddWithValue("obs", "Marcador de inicio de numeración.");
                        InsertarComprob.Fields.AddWithValue("impresa", 1);
                        InsertarComprob.Fields.AddWithValue("anulada", 1);
                        this.Connection.Execute(InsertarComprob);
                        this.Connection.Commit();

                        return base.Ok();
                }
        }
}
