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
using System.Text;

namespace Lcc.Vista.Comprobantes
{
        public partial class ComprobanteConArticulos : ControlVista
        {
                public ComprobanteConArticulos()
                {
                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        base.ActualizarControl();

                        Lbl.Comprobantes.ComprobanteConArticulos Comprob = this.Elemento as Lbl.Comprobantes.ComprobanteConArticulos;

                        if(Comprob != null) {
                                EtiquetaNombreEmpresa.Text = this.Workspace.CurrentConfig.Empresa.Nombre;
                                EtiquetaCuit.Text = this.Workspace.CurrentConfig.Empresa.Cuit;

                                EtiquetaNumero.Text = Comprob.PV.ToString("0000") + "-" + Comprob.Numero.ToString("00000000");
                                EtiquetaTipo.Text = Comprob.Tipo.LetraSola;
                                if (Comprob.Tipo.EsNotaCredito)
                                        EtiquetaTipoLeyenda.Text = "Nota de Crédito".ToUpperInvariant();
                                else if (Comprob.Tipo.EsNotaDebito)
                                        EtiquetaTipoLeyenda.Text = "Nota de Débito".ToUpperInvariant();
                                else
                                        EtiquetaTipoLeyenda.Text = "";

                                EtiquetaFecha.Text = Comprob.Fecha.Value.ToString(Lfx.Types.Formatting.DateTime.DefaultDateFormat);

                                EtiquetaClienteNombre.Text = "Cliente: " + Comprob.Cliente.Nombre;
                                EtiquetaClienteDomicilio.Text = "Domicilio: " + Comprob.Cliente.Domicilio;
                                EtiquetaClienteSituacion.Text = "IVA: " + Comprob.Cliente.SituacionTributaria.Nombre;
                                EtiquetaClienteCuit.Text = "CUIT: " + Comprob.Cliente.Cuit;

                                EtiquetaSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Comprob.SubTotal, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);
                                EtiquetaDescuento.Text = Lfx.Types.Formatting.FormatNumber(Comprob.Descuento, 2);
                                EtiquetaTotal.Text = Lfx.Types.Formatting.FormatCurrency(Comprob.Total, this.Workspace.CurrentConfig.Moneda.DecimalesFinal);

                                EtiquetaAnulado.Visible = Comprob.Anulado;
                        }
                }
        }
}
