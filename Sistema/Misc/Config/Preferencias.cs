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

using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Lazaro.Misc.Config
{
	public partial class Preferencias : Lui.Forms.Form
	{
		int CurrentTab = 1;
		const int TabCount = 3;

                public Preferencias()
                {
                        InitializeComponent();

                        if(this.HasWorkspace)
                                CargarConfig();
                }

		private void BotonCancelar_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}


                private void BotonAceptar_Click(object sender, System.EventArgs e)
                {
                        if (GuardarConfig() == false) {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                        }
                }


		private void CargarConfig()
		{
			string[] ListaCodigos = new string[5];
			ListaCodigos[0] = "Código Autonumérico Incorporado|0";
			DataTable Codigos = this.Connection.Select("SELECT * FROM articulos_codigos");
			foreach (System.Data.DataRow Codigo in Codigos.Rows)
			{
				ListaCodigos[System.Convert.ToInt32(Codigo["id_codigo"])] += System.Convert.ToString(Codigo["nombre"]) + "|" + System.Convert.ToString(Codigo["id_codigo"]);
			}
			EntradaArticulosCodigoPredet.SetData = ListaCodigos;
			EntradaArticulosCodigoPredet.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Stock.CodigoPredet", "*");

			EntradaStockMultideposito.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Stock.Multideposito", "0");
			EntradaStockDepositoPredet.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Stock.DepositoPredet", "0");
			EntradaStockDepositoPredetSuc.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Stock.DepositoPredet", "0");
			EntradaStockDecimales.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Stock.Decimales", "0");

                        EntradaEmpresaNombre.Text = Lbl.Sys.Config.Actual.Empresa.Nombre;
                        EntradaEmpresaRazonSocial.Text = Lbl.Sys.Config.Actual.Empresa.RazonSocial;
                        if (Lbl.Sys.Config.Actual.Empresa.Cuit == null)
                                EntradaEmpresaCuit.Text = "";
                        else
                                EntradaEmpresaCuit.Text = Lbl.Sys.Config.Actual.Empresa.Cuit.ToString();
			EntradaEmpresaSituacion.TextInt = this.Workspace.CurrentConfig.Empresa.SituacionTributaria;
                        EntradaEmpresaEmail.Text = Lbl.Sys.Config.Actual.Empresa.Email;
                        EntradaEmpresaId.ValueInt = Lbl.Sys.Config.Actual.Empresa.Id;

                        EntradaBackup.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Backup.Tipo", "0");
                        EntradaModoPantalla.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Apariencia.ModoPantalla", "maximizado");
                        EntradaAislacion.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Datos.Aislacion", "Serializable");
                        EntradaActualizaciones.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Actualizaciones.Nivel", "stable");

			EntradaPV.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.PV", "1");
			EntradaPVABC.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.ABC.PV", "0");
			EntradaPVNC.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.NC.PV", "0");
			EntradaPVND.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.ND.PV", "0");
			EntradaPVR.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.R.PV", "0");
                        EntradaPVRC.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.RC.PV", "0");

			EntradaClientePredet.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.ClientePredet", "");
			EntradaFormaPagoPredet.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.FormaPagoPredet", "");

			EntradaCambiaPrecioComprob.TextKey = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.CambiaPrecioItemFactura", "1");

                        EntradaLimiteCredito.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Cuentas.LimiteCreditoPredet", "0");
                        EntradaRedondeo.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Moneda.Redondeo", "0.05");
		}


		private bool GuardarConfig()
		{
			if (EntradaEmpresaCuit.Text.Length == 11)
				EntradaEmpresaCuit.Text = EntradaEmpresaCuit.Text.Substring(0, 2) + "-" + EntradaEmpresaCuit.Text.Substring(2, 8) + "-" + EntradaEmpresaCuit.Text.Substring(10, 1);

                        if (EntradaEmpresaCuit.Text != "00-00000000-0" && Lfx.Types.Strings.EsCuitValido(EntradaEmpresaCuit.Text) == false) {
                                Lui.Forms.MessageBox.Show("Por favor ingrese una CUIT válida.\nSi todavía no disponde de una CUIT, puede utilizar provisoriamente la clave 00-00000000-0.", "La CUIT no es válida");
                                return true;
                        }

                        if (EntradaEmpresaEmail.Text.Length <= 5 || EntradaEmpresaEmail.Text.IndexOf('@') <= 0 || EntradaEmpresaEmail.Text.IndexOf('.') <= 0) {
                                Lui.Forms.MessageBox.Show("Debe escribir una dirección de Correo Electrónico (e-mail) válida.", "Validación");
                                return true;
                        }

			int Sucursal = this.Workspace.CurrentConfig.ReadLocalSettingInt("Estacion", "Sucursal", 1);

			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Stock.CodigoPredet", EntradaArticulosCodigoPredet.TextKey, 0);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Stock.Multideposito", EntradaStockMultideposito.TextKey, 0);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Stock.Decimales", EntradaStockDecimales.TextKey, 0);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Stock.DepositoPredet", EntradaStockDepositoPredet.Text, 0); ;
			if (EntradaStockDepositoPredetSuc.TextInt > 0)
				this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Stock.DepositoPredet", EntradaStockDepositoPredetSuc.Text, Sucursal);
			else
				this.Workspace.CurrentConfig.DeleteGlobalSetting("Sistema", "Stock.DepositoPredet", Sucursal);

                        Lbl.Sys.Config.Actual.Empresa.Nombre = EntradaEmpresaNombre.Text;
                        Lbl.Sys.Config.Actual.Empresa.RazonSocial = EntradaEmpresaRazonSocial.Text;
                        if (EntradaEmpresaCuit.Text.Length > 0)
                                Lbl.Sys.Config.Actual.Empresa.Cuit = new Lbl.Personas.Cuit(EntradaEmpresaCuit.Text);
                        else
                                Lbl.Sys.Config.Actual.Empresa.Cuit = null;
			this.Workspace.CurrentConfig.Empresa.SituacionTributaria = EntradaEmpresaSituacion.TextInt;
                        Lbl.Sys.Config.Actual.Empresa.Email = EntradaEmpresaEmail.Text;
                        Lbl.Sys.Config.Actual.Empresa.Id = EntradaEmpresaId.ValueInt;

                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Backup.Tipo", EntradaBackup.TextKey, System.Environment.MachineName.ToUpperInvariant());
                        if (EntradaModoPantalla.TextKey == "*")
                                this.Workspace.CurrentConfig.DeleteGlobalSetting("Sistema", "Apariencia.ModoPantalla", System.Environment.MachineName.ToUpperInvariant());
                        else
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Apariencia.ModoPantalla", EntradaModoPantalla.TextKey, System.Environment.MachineName.ToUpperInvariant());
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Datos.Aislacion", EntradaAislacion.TextKey);
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Actualizaciones.Nivel", EntradaActualizaciones.TextKey);

			//Guardo información sobre los PV
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.PV", EntradaPV.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.ABC.PV", EntradaPVABC.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.NC.PV", EntradaPVNC.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.ND.PV", EntradaPVND.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.R.PV", EntradaPVR.Text, Sucursal);
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.RC.PV", EntradaPVRC.Text, System.Environment.MachineName);

			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.ClientePredet", EntradaClientePredet.Text, "*");
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.FormaPagoPredet", EntradaFormaPagoPredet.Text, "*");

			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.CambiaPrecioItemFactura", EntradaCambiaPrecioComprob.TextKey.ToString(), "*");

                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Cuentas.LimiteCreditoPredet", EntradaLimiteCredito.Text, "*");
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Moneda.Redondeo", EntradaRedondeo.Text, "*");

			return false;
		}


		private void BotonSiguiente_Click(object sender, System.EventArgs e)
		{
			CurrentTab += 1;
			if (CurrentTab > TabCount)
				CurrentTab = 1;
			FrmGeneral.Visible = CurrentTab == 1;
			FrmArticulos.Visible = CurrentTab == 2;
			FrmComprobantes.Visible = CurrentTab == 3;
		}
	}
}