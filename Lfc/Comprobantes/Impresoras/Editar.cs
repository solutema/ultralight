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

namespace Lfc.Comprobantes.Impresoras
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
	{
		public Editar()
		{
                        ElementoTipo = typeof(Lbl.Impresion.Impresora);

                        InitializeComponent();
		}

                public override void ActualizarControl()
                {
                        Lbl.Impresion.Impresora Impresora = this.Elemento as Lbl.Impresion.Impresora;

                        EntradaNombre.Text = Impresora.Nombre;
                        EntradaTipo.TextKey = ((int)(Impresora.Clase)).ToString();
                        EntradaEstacion.Text = Impresora.Estacion;
                        EntradaUbicacion.Text = Impresora.Ubicacion;
                        
                        switch(Impresora.Clase)
                        {
                                case Lbl.Impresion.ClasesImpresora.Comun:
                                        EntradaDispositivo.Text = Impresora.Dispositivo;
                                        EntradaCarga.TextKey = ((int)(Impresora.CargaPapel)).ToString();
                                        EntradaTalonario.TextKey = Impresora.UsaTalonario ? "1": "0";
                                        break;
                                case Lbl.Impresion.ClasesImpresora.Fiscal:
                                        EntradaFiscalPuerto.TextKey = Impresora.Dispositivo;
                                        EntradaFiscalModelo.TextKey = ((int)(Impresora.FiscalModelo)).ToString();
                                        EntradaFiscalBps.Text = Impresora.FiscalBps.ToString();
                                        break;
                        }

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Impresion.Impresora Impresora = this.Elemento as Lbl.Impresion.Impresora;

                        Impresora.Nombre = EntradaNombre.Text;
                        Impresora.Clase = (Lbl.Impresion.ClasesImpresora)Lfx.Types.Parsing.ParseInt(EntradaTipo.TextKey);
                        Impresora.Estacion = EntradaEstacion.Text;
                        Impresora.Ubicacion = EntradaUbicacion.Text;

                        switch (Impresora.Clase) {
                                case Lbl.Impresion.ClasesImpresora.Comun:
                                        Impresora.Dispositivo = EntradaDispositivo.Text;
                                        Impresora.CargaPapel = (Lbl.Impresion.CargasPapel)Lfx.Types.Parsing.ParseInt(EntradaCarga.TextKey);
                                        Impresora.UsaTalonario = EntradaTalonario.TextKey == "1";
                                        break;
                                case Lbl.Impresion.ClasesImpresora.Fiscal:
                                        Impresora.Dispositivo = EntradaFiscalPuerto.TextKey;
                                        Impresora.FiscalModelo = (Lbl.Impresion.ModelosFiscales)Lfx.Types.Parsing.ParseInt(EntradaFiscalModelo.TextKey);
                                        Impresora.FiscalBps = Lfx.Types.Parsing.ParseInt(EntradaFiscalBps.Text);
                                        break;
                        }

                        base.ActualizarElemento();
                }

                private void EntradaTipo_TextChanged(object sender, EventArgs e)
                {
                        EntradaTalonario.Enabled = EntradaTipo.TextKey == "1";
                        EntradaCarga.Enabled = EntradaTipo.TextKey == "1";
                        EntradaDispositivo.Enabled = EntradaTipo.TextKey == "1";

                        EntradaFiscalBps.Enabled = EntradaTipo.TextKey == "2";
                        EntradaFiscalModelo.Enabled = EntradaTipo.TextKey == "2";
                        EntradaFiscalPuerto.Enabled = EntradaTipo.TextKey == "2";
                }

                private void BotonSeleccionarEstacion_Click(object sender, EventArgs e)
                {
                        Lui.Forms.WorkstationSelectorForm SelEst = new Lui.Forms.WorkstationSelectorForm();
                        SelEst.Estacion = EntradaEstacion.Text;
                        if (SelEst.ShowDialog() == DialogResult.OK)
                                EntradaEstacion.Text = SelEst.Estacion;
                }

                private void BotonSeleccionarDispositivo_Click(object sender, EventArgs e)
                {
                        using (Lui.Printing.PrinterSelectionDialog FormularioSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog()) {
                                FormularioSeleccionarImpresora.MuestraImpresorasLazaro = false;
                                if (FormularioSeleccionarImpresora.ShowDialog() == DialogResult.OK) {
                                        Lbl.Impresion.Impresora Impr = FormularioSeleccionarImpresora.SelectedPrinter;
                                        if (Impr != null)
                                                EntradaDispositivo.Text = Impr.Dispositivo;
                                } else {
                                        return;
                                }
                        }
                }

                private void EntradaEstacion_TextChanged(object sender, EventArgs e)
                {
                        BotonSeleccionarDispositivo.Visible = EntradaEstacion.Text.ToUpperInvariant() == System.Environment.MachineName.ToUpperInvariant();
                }
	}
}

