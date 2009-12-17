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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Cuentas.Vencimientos
{
        public partial class Editar : Lui.Forms.EditForm
        {
                public Editar()
                {
                        InitializeComponent();
                }

                public override Lfx.Types.OperationResult Create()
                {
                        if (!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "vencimientos.create"))
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Cuentas.Vencimiento Res = new Lbl.Cuentas.Vencimiento(this.DataView);
                        Res.Crear();

                        this.FromRow(Res);
                        return new Lfx.Types.SuccessOperationResult();
                }

                public override Lfx.Types.OperationResult Edit(int lId)
                {
                        if (Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "vencimientos.read") == false)
                                return new Lfx.Types.NoAccessOperationResult();

                        Lbl.Cuentas.Vencimiento Res = new Lbl.Cuentas.Vencimiento(this.DataView, lId);

                        if (Res.Cargar().Success == false) {
                                return new Lfx.Types.FailureOperationResult("Error al cargar el registro");
                        } else {
                                this.FromRow(Res);
                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override void FromRow(Lbl.ElementoDeDatos row)
                {
                        base.FromRow(row);

                        Lbl.Cuentas.Vencimiento Res = row as Lbl.Cuentas.Vencimiento;

                        if (Res.Concepto == null)
                                EntradaConcepto.TextInt = 0;
                        else
                                EntradaConcepto.TextInt = Res.Concepto.Id;
                        
                        EntradaFechaFin.Text = Lfx.Types.Formatting.FormatDate(Res.FechaFin);
                        EntradaFechaInicio.Text = Lfx.Types.Formatting.FormatDate(Res.FechaInicio);
                        EntradaFrecuencia.TextKey = ((int)(Res.Frecuencia)).ToString();
                        EntradaImporte.Text = Lfx.Types.Formatting.FormatCurrency(Res.Importe, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        EntradaNombre.Text = Res.Nombre;
                        EntradaObs.Text = Res.Obs;
                        EntradaRepetir.Text = Res.Repetir.ToString();
                        EntradaEstado.TextKey = Res.Estado.ToString();
                                
                        SaveButton.Visible = Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "vencimientos.write");

                        if (this.CachedRow.Existe)
                                this.Text = "Vencimiento: " + Res.Nombre;
                        else
                                this.Text = "Vencimiento: Nuevo"; ;
                }

                public override Lbl.ElementoDeDatos ToRow()
                {
                        Lbl.Cuentas.Vencimiento Res = this.CachedRow as Lbl.Cuentas.Vencimiento;

                        if (EntradaConcepto.TextInt == 0)
                                Res.Concepto = null;
                        else
                                Res.Concepto = new Lbl.Cuentas.Concepto(Res.DataView, EntradaConcepto.TextInt);

                        Res.Estado = Lfx.Types.Parsing.ParseInt(EntradaEstado.TextKey);
                        Res.FechaFin = Lfx.Types.Parsing.ParseDate(EntradaFechaFin.Text);
                        Res.FechaInicio = Lfx.Types.Parsing.ParseDate(EntradaFechaInicio.Text);
                        switch(EntradaFrecuencia.TextKey){
                                case "unica":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Unica;
                                        break;
                                case "diaria":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Diaria;
                                        break;
                                case "semanal":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Semanal;
                                        break;
                                case "mensual":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Mensual;
                                        break;
                                case "bimestral":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Bimestral;
                                        break;
                                case "trimestral":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Trimestral;
                                        break;
                                case "cuatrimestral":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Cuatrimestral;
                                        break;
                                case "semestral":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Semestral;
                                        break;
                                case "anual":
                                        Res.Frecuencia = Lbl.Cuentas.Vencimiento.Frecuencias.Anual;
                                        break;
                        }

                        Res.Importe = Lfx.Types.Parsing.ParseCurrency(EntradaImporte.Text);
                        Res.Nombre = EntradaNombre.Text;
                        Res.Obs = EntradaObs.Text;
                        Res.Repetir = Lfx.Types.Parsing.ParseInt(EntradaRepetir.Text);

                        return base.ToRow();
                }
        }
}