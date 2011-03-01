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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc
{
        public partial class Fiscal : Lui.Forms.DialogForm
        {
                private int Pv = 0;

                public Fiscal() : base()
                {
                        InitializeComponent();

                        if (this.HasWorkspace) {
                                //Lleno la tabla de PVs
                                System.Data.DataTable PVs = this.Connection.Select("SELECT * FROM pvs WHERE tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString());
                                string[] PVDataSet = new string[PVs.Rows.Count];
                                int i = 0;
                                foreach (System.Data.DataRow PV in PVs.Rows) {
                                        PVDataSet[i++] = PV["id_pv"].ToString() + " en " + PV["estacion"].ToString() + "|" + PV["id_pv"].ToString();
                                }
                                EntradaPv.SetData = PVDataSet;

                                if (EntradaPv.SetData.Length > 0) {

                                        //Busco el PV para esta estación, en esta sucursal
                                        this.Pv = Connection.FieldInt("SELECT id_pv FROM pvs WHERE tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString() + " AND estacion='" + System.Environment.MachineName.ToUpperInvariant() + "'");

                                        if (this.Pv == 0)
                                                //Busco el PV para alguna estación, en esta sucursal
                                                this.Pv = Connection.FieldInt("SELECT id_pv FROM pvs WHERE tipo=2 AND id_sucursal=" + this.Workspace.CurrentConfig.Empresa.SucursalPredeterminada.ToString());

                                        if (this.Pv != 0)
                                                EntradaPv.TextKey = this.Pv.ToString();
                                }

                                MostrarDatos();
                        }
                }


                private void MostrarDatos()
                {
                        if (this.Pv != 0) {
                                string LSAString = Connection.FieldString("SELECT lsa FROM pvs WHERE id_pv=" + this.Pv.ToString());

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

                                string UltimoZ = Connection.FieldString("SELECT ultimoz FROM pvs WHERE id_pv=" + this.Pv.ToString());
                                if (UltimoZ != null && UltimoZ.Length > 0) {
                                        System.DateTime FechaUltimoCierreZ = DateTime.ParseExact(UltimoZ,
                                                @"yyyy\-MM\-dd HH\:mm\:ss",
                                                System.Globalization.DateTimeFormatInfo.InvariantInfo,
                                                System.Globalization.DateTimeStyles.AllowWhiteSpaces);

                                        lblUltimoCierreZ.Text = Lfx.Types.Formatting.FormatSmartDateAndTime(FechaUltimoCierreZ);
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
                        this.Pv = Lfx.Types.Parsing.ParseInt(EntradaPv.TextKey);
                        MostrarDatos();
                }

                private void lblEstadoServidor_TextChanged(object sender, System.EventArgs e)
                {
                        if (lblEstadoServidor.Text == "Activo") {
                                BotonCierreZ.Enabled = true;
                                BotonReiniciar.Enabled = true;
                                BotonIniciarDetener.Text = "Detener";
                        } else if (lblEstadoServidor.Text == "Inactivo") {
                                BotonCierreZ.Enabled = false;
                                BotonReiniciar.Enabled = false;
                                BotonIniciarDetener.Text = "Iniciar";
                        }
                        BotonIniciarDetener.Enabled = true;
                }

                private void BotonCierreZ_Click(object sender, System.EventArgs e)
                {
                        this.Workspace.DefaultScheduler.AddTask("CIERRE Z", "fiscal" + this.Pv.ToString(), "*");
                        Lui.Forms.MessageBox.Show("Se envió un comando de Cierre Z al punto de venta seleccionado.", "Cierre Z");
                        BotonCierreZ.Enabled = false;
                }

                private void BotonReiniciar_Click(object sender, System.EventArgs e)
                {
                        Lui.Forms.MessageBox.Show("Se envió un comando de Reiniciar al punto de venta seleccionado.", "Reiniciar");
                        this.Workspace.DefaultScheduler.AddTask("REBOOT", "fiscal" + this.Pv.ToString(), "*");
                }

                private void BotonIniciarDetener_Click(object sender, System.EventArgs e)
                {
                        if (BotonIniciarDetener.Text == "Iniciar") {
                                string EstacionFiscal = Connection.FieldString("SELECT estacion FROM pvs WHERE id_pv=" + this.Pv.ToString());
                                this.Workspace.DefaultScheduler.AddTask("FISCAL INICIAR", "lazaro", EstacionFiscal);
                                Lui.Forms.MessageBox.Show("Se envió una orden de Iniciar el servidor fiscal. Puede demorar varios segundos.", "Iniciar");
                        } else {
                                this.Workspace.DefaultScheduler.AddTask("END", "fiscal" + this.Pv.ToString(), "*");
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