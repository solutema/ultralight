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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Cajas.Vencimientos
{
        public partial class Editar : Lcc.Edicion.ControlEdicion
        {
                public Editar()
                {
                        ElementoTipo = typeof(Lbl.Cajas.Vencimiento);

                        InitializeComponent();
                }

                public override void ActualizarControl()
                {
                        Lbl.Cajas.Vencimiento Res = this.Elemento as Lbl.Cajas.Vencimiento;

                        EntradaConcepto.Elemento = Res.Concepto;
                        EntradaFechaFin.Text = Lfx.Types.Formatting.FormatDate(Res.FechaFin);
                        EntradaFechaInicio.Text = Lfx.Types.Formatting.FormatDate(Res.FechaInicio);
                        EntradaFrecuencia.TextKey = Res.Frecuencia.ToString();
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(Res.Importe, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaNombre.Text = Res.Nombre;
                        EntradaObs.Text = Res.Obs;
                        EntradaRepetir.Text = Res.Repetir.ToString();
                        EntradaEstado.TextKey = Res.Estado.ToString();

                        base.ActualizarControl();
                }

                public override void ActualizarElemento()
                {
                        Lbl.Cajas.Vencimiento Res = this.Elemento as Lbl.Cajas.Vencimiento;

                        Res.Concepto = EntradaConcepto.Elemento as Lbl.Cajas.Concepto;
                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);
                        Res.FechaFin = Lfx.Types.Parsing.ParseDate(EntradaFechaFin.Text);
                        Res.FechaInicio = Lfx.Types.Parsing.ParseDate(EntradaFechaInicio.Text);
                        switch (EntradaFrecuencia.TextKey) {
                                case "Unica":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Unica;
                                        break;
                                case "Diaria":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Diaria;
                                        break;
                                case "Semanal":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Semanal;
                                        break;
                                case "Mensual":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Mensual;
                                        break;
                                case "Bimestral":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Bimestral;
                                        break;
                                case "Trimestral":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Trimestral;
                                        break;
                                case "Cuatrimestral":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Cuatrimestral;
                                        break;
                                case "Semestral":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Semestral;
                                        break;
                                case "Anual":
                                        Res.Frecuencia = Lbl.Cajas.Frecuencias.Anual;
                                        break;
                        }

                        Res.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        Res.Nombre = EntradaNombre.Text;
                        Res.Obs = EntradaObs.Text;
                        Res.Repetir = Lfx.Types.Parsing.ParseInt(EntradaRepetir.Text);

                        base.ActualizarElemento();
                }
        }
}