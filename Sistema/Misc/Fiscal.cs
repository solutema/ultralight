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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc
{
        public partial class Fiscal : Lui.Forms.DialogForm
        {
                private int PV = 0;

                public Fiscal() : base()
                {
                        InitializeComponent();
                }

                private void Fiscal_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        //Lleno la tabla de PVs
                        System.Data.DataTable PVs = this.DataBase.Select("SELECT * FROM pvs WHERE tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString());
                        string[] PVDataSet = new string[PVs.Rows.Count];
                        int i = 0;
                        foreach (System.Data.DataRow PV in PVs.Rows) {
                                PVDataSet[i++] = PV["id_pv"].ToString() + " en " + PV["estacion"].ToString() + "|" + PV["id_pv"].ToString();
                        }
                        txtPV.SetData = PVDataSet;

                        if (txtPV.SetData.Length > 0) {

                                //Busco el PV para esta estación, en esta sucursal
                                this.PV = DataBase.FieldInt("SELECT id_pv FROM pvs WHERE tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString() + " AND estacion='" + System.Environment.MachineName.ToUpperInvariant() + "'");

                                if (this.PV == 0)
                                        //Busco el PV para alguna estación, en esta sucursal
                                        this.PV = DataBase.FieldInt("SELECT id_pv FROM pvs WHERE tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString());

                                if (this.PV != 0)
                                        txtPV.TextKey = this.PV.ToString();
                        }

                        MostrarDatos();
                }

                private void MostrarDatos()
                {
                        if (this.PV != 0) {
                                string LSAString = DataBase.FieldString("SELECT lsa FROM pvs WHERE id_pv=" + this.PV.ToString());

                                if (LSAString != null && LSAString.Length > 0) {
                                        System.DateTime LSA = DateTime.ParseExact(LSAString,
                                                @"yyyy\-MM\-dd HH\:mm\:ss",
                                                System.Globalization.DateTimeFormatInfo.InvariantInfo,
                                                System.Globalization.DateTimeStyles.AllowWhiteSpaces);

                                        if (LSA < System.DateTime.Now.AddMinutes(-10))
                                                lblEstadoServidor.Text = "Inactivo";
                                        else
                                                lblEstadoServidor.Text = "Activo";

                                } else {
                                        lblEstadoServidor.Text = "Desconocido";
                                }

                                string LCZString = DataBase.FieldString("SELECT ultimoz FROM pvs WHERE id_pv=" + this.PV.ToString());
                                if (LCZString != null && LCZString.Length > 0) {
                                        System.DateTime LCZ = DateTime.ParseExact(LCZString,
                                                @"yyyy\-MM\-dd HH\:mm\:ss",
                                                System.Globalization.DateTimeFormatInfo.InvariantInfo,
                                                System.Globalization.DateTimeStyles.AllowWhiteSpaces);

                                        lblUltimoCierreZ.Text = Lfx.Types.Formatting.FormatDateAndTime(LCZ);
                                } else {
                                        lblUltimoCierreZ.Text = "Desconocido";
                                }
                        }
                }

                private void Timer1_Tick(object sender, System.EventArgs e)
                {
                        MostrarDatos();
                }

                private void txtPV_TextChanged(object sender, System.EventArgs e)
                {
                        this.PV = Lfx.Types.Parsing.ParseInt(txtPV.TextKey);
                        MostrarDatos();
                }

                private void lblEstadoServidor_TextChanged(object sender, System.EventArgs e)
                {
                        if (lblEstadoServidor.Text == "Activo") {
                                cmdCierreZ.Enabled = true;
                                cmdReiniciar.Enabled = true;
                                cmdIniciarDetener.Text = "Detener";
                        } else if (lblEstadoServidor.Text == "Inactivo") {
                                cmdCierreZ.Enabled = false;
                                cmdReiniciar.Enabled = false;
                                cmdIniciarDetener.Text = "Iniciar";
                        }
                        cmdIniciarDetener.Enabled = true;
                }

                private void cmdCierreZ_Click(object sender, System.EventArgs e)
                {
                        this.Workspace.DefaultScheduler.AddTask("CIERRE Z", "fiscal" + this.PV.ToString(), "*");
                        Lui.Forms.MessageBox.Show("Se envió un comando de Cierre Z al punto de venta seleccionado.", "Cierre Z");
                        cmdCierreZ.Enabled = false;
                }

                private void cmdReiniciar_Click(object sender, System.EventArgs e)
                {
                        Lui.Forms.MessageBox.Show("Se envió un comando de Reiniciar al punto de venta seleccionado.", "Reiniciar");
                        this.Workspace.DefaultScheduler.AddTask("REBOOT", "fiscal" + this.PV.ToString(), "*");
                }

                private void cmdIniciarDetener_Click(object sender, System.EventArgs e)
                {
                        if (cmdIniciarDetener.Text == "Iniciar") {
                                string EstacionFiscal = DataBase.FieldString("SELECT estacion FROM pvs WHERE id_pv=" + this.PV.ToString());
                                this.Workspace.DefaultScheduler.AddTask("FISCAL INICIAR", "lazaro", EstacionFiscal);
                                Lui.Forms.MessageBox.Show("Se envió una orden de Iniciar el servidor fiscal. Puede demorar varios segundos.", "Iniciar");
                        } else {
                                this.Workspace.DefaultScheduler.AddTask("END", "fiscal" + this.PV.ToString(), "*");
                                Lui.Forms.MessageBox.Show("Se envió una orden de Detener el servidor fiscal. Puede demorar hasta 40 segundos y mientras tanto seguir apareciendo como Activo.", "Detener");
                        }
                }

                private void Fiscal_Load(object sender, System.EventArgs e)
                {
                        OkButton.Visible = false;
                        CancelCommandButton.Text = "Cerrar";
                }
        }
}