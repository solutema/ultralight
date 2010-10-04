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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lazaro.Reportes
{
        public partial class Patrimonio : Lui.Forms.ChildForm
        {
                public Patrimonio()
                {
                        InitializeComponent();
                }

                private void Patrimonio_WorkspaceChanged(object sender, EventArgs e)
                {
                        double ActivosCajas = 0;
                        double PasivosCajas = 0;
			
                        System.Data.DataTable Cajas = this.DataBase.Select("SELECT * FROM cajas WHERE estado>0");
                        foreach(System.Data.DataRow Rw in Cajas.Rows) {
                                Lbl.Cajas.Caja Cta = new Lbl.Cajas.Caja(this.DataBase, (Lfx.Data.Row)Rw);
                                double Saldo = Cta.Saldo();
                                if (Saldo > 0)
                                        ActivosCajas += Saldo;
                                else
                                        PasivosCajas += Math.Abs(Saldo);
                        }

                        EntradaActivosCajas.Text = Lfx.Types.Formatting.FormatCurrency(ActivosCajas, this.Workspace.CurrentConfig.Moneda.Decimales);
                        EntradaPasivosCajas.Text = Lfx.Types.Formatting.FormatCurrency(PasivosCajas, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double ActivosStock = DataBase.FieldDouble("SELECT SUM(costo*stock_actual) FROM articulos WHERE costo>0 AND stock_actual>0");
                        txtActivosStock.Text = Lfx.Types.Formatting.FormatCurrency(ActivosStock, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double Activos = ActivosCajas + ActivosStock;
                        txtActivosSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Activos, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double FuturosTarjetas = 0.92 * DataBase.FieldDouble("SELECT SUM(importe) FROM tarjetas_cupones WHERE estado=10 OR (estado=0 AND fecha>DATE_SUB(NOW(), INTERVAL 45 DAY))");
                                                //Tarjetas resta el 8% (estimado) de comisiones
                        double Facturas = DataBase.FieldDouble("SELECT SUM(total)-SUM(cancelado) FROM comprob WHERE tipo_fac IN ('FA', 'FB', 'FC', 'FE', 'FM') AND impresa>0 AND numero>0 AND anulada=0 AND fecha >= '" + Lfx.Types.Formatting.FormatDateSql(DateTime.Now.AddYears(-2)) + "'");
                        EntradaCC.Text = Lfx.Types.Formatting.FormatCurrency(Facturas, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double FuturosPedidos = DataBase.FieldDouble("SELECT SUM(total-gastosenvio) FROM comprob WHERE tipo_fac='PD' AND anulada=0 AND compra>0 AND estado=50");
                        txtFuturosTarjetas.Text = Lfx.Types.Formatting.FormatCurrency(FuturosTarjetas, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtFuturosPedidos.Text = Lfx.Types.Formatting.FormatCurrency(FuturosPedidos, this.Workspace.CurrentConfig.Moneda.Decimales);
                        
                        double Futuros = FuturosTarjetas + FuturosPedidos + Facturas;
                        txtFuturosSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Futuros, this.Workspace.CurrentConfig.Moneda.Decimales);

                        txtActivosActualesFuturos.Text = Lfx.Types.Formatting.FormatCurrency(Activos + Futuros, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double PasivosCheques = DataBase.FieldDouble("SELECT SUM(importe) FROM bancos_cheques WHERE emitido>0 AND estado=0");
                        txtPasivosCheques.Text = Lfx.Types.Formatting.FormatCurrency(PasivosCheques, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double PasivosStock = Math.Abs(DataBase.FieldDouble("SELECT SUM(costo*stock_actual) FROM articulos WHERE costo>0 AND stock_actual<0"));
                        txtPasivosStock.Text = Lfx.Types.Formatting.FormatCurrency(PasivosStock, this.Workspace.CurrentConfig.Moneda.Decimales);

                        double Pasivos = PasivosCajas + PasivosCheques + PasivosStock;
                        txtPasivosSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Pasivos, this.Workspace.CurrentConfig.Moneda.Decimales);

                        txtPatrimonioActual.Text = Lfx.Types.Formatting.FormatCurrency(Activos - Pasivos, this.Workspace.CurrentConfig.Moneda.Decimales);
                        txtPatrimonioFuturo.Text = Lfx.Types.Formatting.FormatCurrency(Activos + Futuros - Pasivos, this.Workspace.CurrentConfig.Moneda.Decimales);
                }
        }
}