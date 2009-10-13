// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
                        double ActivosCuentas = 0;
                        double PasivosCuentas = 0;
			
			Lws.Data.DataView CuentasDataView = this.Workspace.GetDataView(false);
                        System.Data.IDataReader Cuentas = CuentasDataView.DataBase.GetReader("SELECT * FROM cuentas WHERE estado>0");
                        while(Cuentas.Read()) {
                                Lbl.Cuentas.CuentaRegular Cta = new Lbl.Cuentas.CuentaRegular(DataView, System.Convert.ToInt32(Cuentas["id_cuenta"]));
                                double Saldo = Cta.Saldo();
                                if (Saldo > 0)
                                        ActivosCuentas += Saldo;
                                else
                                        PasivosCuentas += Math.Abs(Saldo);
                        }
                        Cuentas.Close();
			CuentasDataView.Dispose();

                        txtActivosCuentas.Text = Lfx.Types.Formatting.FormatCurrency(ActivosCuentas, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtPasivosCuentas.Text = Lfx.Types.Formatting.FormatCurrency(PasivosCuentas, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double ActivosStock = DataView.DataBase.FieldDouble("SELECT SUM(costo*stock_actual) FROM articulos WHERE costo>0 AND stock_actual>0");
                        txtActivosStock.Text = Lfx.Types.Formatting.FormatCurrency(ActivosStock, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double Activos = ActivosCuentas + ActivosStock;
                        txtActivosSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Activos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double FuturosTarjetas = 0.92 * DataView.DataBase.FieldDouble("SELECT SUM(importe) FROM tarjetas_cupones WHERE estado=10 OR (estado=0 AND fecha>DATE_SUB(NOW(), INTERVAL 45 DAY))");
                                                //Tarjetas resta el 8% (estimado) de comisiones
                        double Facturas = DataView.DataBase.FieldDouble("SELECT SUM(total)-SUM(cancelado) FROM facturas WHERE tipo_fac IN ('A', 'B', 'C', 'E', 'M') AND impresa>0 AND numero>0 AND anulada=0 AND fecha >= '" + Lfx.Types.Formatting.FormatDateSql(DateTime.Now.AddYears(-2)) + "'");
                        txtCC.Text = Lfx.Types.Formatting.FormatCurrency(Facturas, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double FuturosPedidos = DataView.DataBase.FieldDouble("SELECT SUM(total-gastosenvio) FROM facturas WHERE tipo_fac='PD' AND anulada=0 AND compra>0 AND estado=50");
                        txtFuturosTarjetas.Text = Lfx.Types.Formatting.FormatCurrency(FuturosTarjetas, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtFuturosPedidos.Text = Lfx.Types.Formatting.FormatCurrency(FuturosPedidos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        
                        double Futuros = FuturosTarjetas + FuturosPedidos + Facturas;
                        txtFuturosSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Futuros, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        txtActivosActualesFuturos.Text = Lfx.Types.Formatting.FormatCurrency(Activos + Futuros, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double PasivosCheques = DataView.DataBase.FieldDouble("SELECT SUM(importe) FROM bancos_cheques WHERE emitido>0 AND estado=0");
                        txtPasivosCheques.Text = Lfx.Types.Formatting.FormatCurrency(PasivosCheques, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double PasivosStock = Math.Abs(DataView.DataBase.FieldDouble("SELECT SUM(costo*stock_actual) FROM articulos WHERE costo>0 AND stock_actual<0"));
                        txtPasivosStock.Text = Lfx.Types.Formatting.FormatCurrency(PasivosStock, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        double Pasivos = PasivosCuentas + PasivosCheques + PasivosStock;
                        txtPasivosSubtotal.Text = Lfx.Types.Formatting.FormatCurrency(Pasivos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);

                        txtPatrimonioActual.Text = Lfx.Types.Formatting.FormatCurrency(Activos - Pasivos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                        txtPatrimonioFuturo.Text = Lfx.Types.Formatting.FormatCurrency(Activos + Futuros - Pasivos, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }

                private void label14_Click(object sender, EventArgs e)
                {

                }

                private void textBox1_TextChanged(object sender, EventArgs e)
                {

                }
        }
}