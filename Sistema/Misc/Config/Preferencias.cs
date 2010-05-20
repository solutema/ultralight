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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc.Config
{
	public partial class Preferencias : Lui.Forms.Form
	{
		int CurrentTab = 1;
		const int TabCount = 4;

                public Preferencias()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                }

		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void lvImpresionComprob_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (lvImpresionComprob.SelectedItems != null && lvImpresionComprob.SelectedItems.Count >= 1)
			{
				ListViewItem SelItem = lvImpresionComprob.SelectedItems[0];
				txtImpresionPredetComprobante.Text = Lbl.Comprobantes.Comprobante.NombreTipo(SelItem.Text);
				txtImpresionPredetImpresora.Text = SelItem.SubItems[2].Text;
				txtImpresionPredetCarga.Text = SelItem.SubItems[3].Text;
			}
		}


		private void cmdImpresionPredetImpresoraBrowse_Click(object sender, System.EventArgs e)
		{
			Lui.Printing.PrinterSelectionDialog OFormSeleccionarImpresora = new Lui.Printing.PrinterSelectionDialog();

			string ListaPuntosDeVenta = "";
			System.Data.DataTable PuntosDeVenta = this.Workspace.DefaultDataBase.Select("SELECT estacion, id_pv FROM pvs WHERE estacion IS NOT NULL AND tipo=2");
			foreach (System.Data.DataRow Servidor in PuntosDeVenta.Rows)
			{
				if (ListaPuntosDeVenta.Length > 0)
					ListaPuntosDeVenta += ",";
				ListaPuntosDeVenta += "fiscal:" + Servidor["id_pv"] + @"|Punto de Venta " + Servidor["id_pv"].ToString() + " en " + Lfx.Types.Strings.ULCase(Servidor["estacion"].ToString()) + " (controlador fiscal)";

			}

			PuntosDeVenta = this.Workspace.DefaultDataBase.Select("SELECT estacion, id_pv FROM pvs WHERE estacion IS NOT NULL AND tipo=1");
			foreach (System.Data.DataRow Servidor in PuntosDeVenta.Rows)
			{
				if (ListaPuntosDeVenta.Length > 0)
					ListaPuntosDeVenta += ",";
				ListaPuntosDeVenta += Servidor["estacion"] + @"|Punto de Venta " + Servidor["id_pv"].ToString() + " en " + Lfx.Types.Strings.ULCase(Servidor["estacion"].ToString()) + " (impresora)";
			}

			if (ListaPuntosDeVenta.Length > 0)
				ListaPuntosDeVenta += ",";
                        ListaPuntosDeVenta += "(Predeterminada)";

			OFormSeleccionarImpresora.ExtraItems = ListaPuntosDeVenta;
			OFormSeleccionarImpresora.SelectedPrinter = txtImpresionPredetImpresora.Text;
			if (OFormSeleccionarImpresora.ShowDialog() == DialogResult.OK)
			{
				txtImpresionPredetImpresora.Text = OFormSeleccionarImpresora.SelectedPrinter;
				if (txtImpresionPredetImpresora.Text.IndexOf(System.IO.Path.DirectorySeparatorChar.ToString() + System.IO.Path.DirectorySeparatorChar.ToString()) == -1
							&& (txtImpresionPredetImpresora.Text.Length < 7 || txtImpresionPredetImpresora.Text.Substring(0, 7) != "fiscal:")
                                                        && txtImpresionPredetImpresora.Text != "(Predeterminada)")
                                        txtImpresionPredetImpresora.Text = System.IO.Path.DirectorySeparatorChar.ToString() + System.IO.Path.DirectorySeparatorChar.ToString() + System.Environment.MachineName.ToUpperInvariant() + System.IO.Path.DirectorySeparatorChar.ToString() + txtImpresionPredetImpresora.Text;
			}
		}


		private void txtImpresionPredetImpresora_TextChanged(object sender, System.EventArgs e)
		{
			if (lvImpresionComprob.SelectedItems != null && lvImpresionComprob.SelectedItems.Count >= 1)
			{
				ListViewItem SelItem = lvImpresionComprob.SelectedItems[0];
				SelItem.SubItems[2].Text = txtImpresionPredetImpresora.Text;
			}
		}


		private void txtImpresionPredetCarga_TextChanged(object sender, System.EventArgs e)
		{
			if (lvImpresionComprob.SelectedItems != null && lvImpresionComprob.SelectedItems.Count >= 1)
			{
				ListViewItem SelItem = lvImpresionComprob.SelectedItems[0];
				SelItem.SubItems[3].Text = txtImpresionPredetCarga.Text;
			}
		}


		private void lvImpresionComprob_DoubleClick(object sender, System.EventArgs e)
		{
			txtImpresionPredetImpresoraBrowse.PerformClick();
		}


		private void CargarImpresorasPredet()
		{
			System.Collections.ArrayList Comprobs = new System.Collections.ArrayList();
			Comprobs.Add("F");
			Comprobs.Add("FA");
			Comprobs.Add("FB");
			Comprobs.Add("NC");
			Comprobs.Add("NCA");
			Comprobs.Add("NCB");
			Comprobs.Add("ND");
			Comprobs.Add("NDA");
			Comprobs.Add("NDB");
			Comprobs.Add("R");
			Comprobs.Add("RC");
			Comprobs.Add("PS");
			Comprobs.Add("Listados");

			lvImpresionComprob.Items.Clear();
			foreach (string Comprob in Comprobs)
			{
				ListViewItem Itm = lvImpresionComprob.Items.Add(Comprob);
				Itm.SubItems.Add(Lbl.Comprobantes.Comprobante.NombreTipo(Comprob));
				string ImpresoraPreferida = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos." + Comprob + ".Impresora", "");

				if (ImpresoraPreferida == "*")
					ImpresoraPreferida = "Predeterminada de Windows";
				else if (ImpresoraPreferida != null && ImpresoraPreferida.Length == 0)
					ImpresoraPreferida = "(Predeterminada)";

				Itm.SubItems.Add(ImpresoraPreferida);

				string ImpresoraCarga = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos." + Comprob + ".Carga", "");

				switch (ImpresoraCarga)
				{
					case "auto":
						Itm.SubItems.Add("Automática");
						break;
					case "manual":
						Itm.SubItems.Add("Manual");
						break;
					default:
						Itm.SubItems.Add("(Predeterminada)");
						break;
				}
			}
		}


		private void GuardarImpresorasPredet()
		{
			foreach (System.Windows.Forms.ListViewItem Itm in lvImpresionComprob.Items)
			{
				string Comprob = Itm.Text;
				string ImpresoraPreferida = Itm.SubItems[2].Text;
                                if (ImpresoraPreferida == "(Predeterminada)")
					ImpresoraPreferida = "";

				string ImpresoraCarga = Itm.SubItems[3].Text;
				switch (ImpresoraCarga)
				{
					case "Automática":
						ImpresoraCarga = "auto";
						break;
					case "Manual":
						ImpresoraCarga = "manual";
						break;
					default:
						ImpresoraCarga = "";
						break;
				}

				if (ImpresoraPreferida.Length == 0)
					this.Workspace.CurrentConfig.DeleteGlobalSetting("Sistema", "Documentos." + Comprob + ".Impresora", 0);
				else
					this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos." + Comprob + ".Impresora", ImpresoraPreferida, 0);
				if (ImpresoraCarga.Length == 0)
					this.Workspace.CurrentConfig.DeleteGlobalSetting("Sistema", "Documentos." + Comprob + ".Carga", 0);
				else
					this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos." + Comprob + ".Carga", ImpresoraCarga, 0);
			}
		}

                private void cmdOk_Click(object sender, System.EventArgs e)
                {
                        if (BotonSiguiente.Visible == false) {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                        }

                        if (GuardarConfig() == false) {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                        }
                }


		private void CargarConfig()
		{
			string[] ListaCodigos = new string[5];
			ListaCodigos[0] = "Código Autonumérico Incorporado|0";
			DataTable Codigos = this.Workspace.DefaultDataBase.Select("SELECT * FROM articulos_codigos");
			foreach (System.Data.DataRow Codigo in Codigos.Rows)
			{
				ListaCodigos[System.Convert.ToInt32(Codigo["id_codigo"])] += System.Convert.ToString(Codigo["nombre"]) + "|" + System.Convert.ToString(Codigo["id_codigo"]);
			}
			EntradaArticulosCodigoPredet.SetData = ListaCodigos;
			EntradaArticulosCodigoPredet.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Stock.CodigoPredet", "*");

			EntradaStockMultideposito.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Stock.Multideposito", "0");
			EntradaStockDepositoPredet.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Stock.DepositoPredet", "0");
			EntradaStockDepositoPredetSuc.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Stock.DepositoPredet", "0");
			EntradaStockDecimales.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Stock.Decimales", "0");

			EntradaEmpresaNombre.Text = this.Workspace.CurrentConfig.Company.Name;
			EntradaEmpresaCuit.Text = this.Workspace.CurrentConfig.Company.Cuit;
			EntradaEmpresaSituacion.TextInt = this.Workspace.CurrentConfig.Company.SituacionTributaria;
                        EntradaEmpresaEmail.Text = this.Workspace.CurrentConfig.Company.Email;

                        EntradaBackup.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Backup.Tipo", "0");
                        EntradaModoPantalla.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Apariencia.ModoPantalla", "maximizado");
                        EntradaAislacion.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Datos.Aislacion", "Serializable");

			CargarImpresorasPredet();

			EntradaPV.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.PV", "1");
			EntradaPVABC.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.ABC.PV", "0");
			EntradaPVNC.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.NC.PV", "0");
			EntradaPVND.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.ND.PV", "0");
			EntradaPVR.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.R.PV", "0");

			EntradaClientePredet.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.ClientePredet", "");
			EntradaFormaPagoPredet.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.FormaPagoPredet", "");

			EntradaCambiaPrecioComprob.TextKey = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Documentos.CambiaPrecioItemFactura", "1");

                        EntradaLimiteCredito.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Cuentas.LimiteCreditoPredet", "0");
                        EntradaRedondeo.Text = this.Workspace.CurrentConfig.ReadGlobalSettingString("Sistema", "Moneda.Redondeo", "0.05");
		}


		private bool GuardarConfig()
		{
			if (EntradaEmpresaCuit.Text.Length == 11)
				EntradaEmpresaCuit.Text = EntradaEmpresaCuit.Text.Substring(0, 2) + "-" + EntradaEmpresaCuit.Text.Substring(2, 8) + "-" + EntradaEmpresaCuit.Text.Substring(10, 1);

                        if (EntradaEmpresaCuit.Text != "00-00000000-0" && Lfx.Types.Strings.ValidCUIT(EntradaEmpresaCuit.Text) == false) {
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

			this.Workspace.CurrentConfig.Company.Name = EntradaEmpresaNombre.Text;
			this.Workspace.CurrentConfig.Company.Cuit = EntradaEmpresaCuit.Text;
			this.Workspace.CurrentConfig.Company.SituacionTributaria = EntradaEmpresaSituacion.TextInt;
                        this.Workspace.CurrentConfig.Company.Email = EntradaEmpresaEmail.Text;
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Backup.Tipo", EntradaBackup.TextKey, System.Environment.MachineName.ToUpperInvariant());
                        if (EntradaModoPantalla.TextKey == "*")
                                this.Workspace.CurrentConfig.DeleteGlobalSetting("Sistema", "Apariencia.ModoPantalla", System.Environment.MachineName.ToUpperInvariant());
                        else
                                this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Apariencia.ModoPantalla", EntradaModoPantalla.TextKey, System.Environment.MachineName.ToUpperInvariant());
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Datos.Aislacion", EntradaAislacion.TextKey);

			GuardarImpresorasPredet();

			//Guardo información sobre los PV
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.PV", EntradaPV.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.ABC.PV", EntradaPVABC.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.NC.PV", EntradaPVNC.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.ND.PV", EntradaPVND.Text, Sucursal);
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.R.PV", EntradaPVR.Text, Sucursal);

			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.ClientePredet", EntradaClientePredet.Text, "*");
			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.FormaPagoPredet", EntradaFormaPagoPredet.Text, "*");

			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.CambiaPrecioItemFactura", EntradaCambiaPrecioComprob.TextKey.ToString(), "*");

                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Cuentas.LimiteCreditoPredet", EntradaLimiteCredito.Text, "*");
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Moneda.Redondeo", EntradaRedondeo.Text, "*");

			return false;
		}


		private void FormConfig_WorkspaceChanged(object sender, System.EventArgs e)
		{
			CargarConfig();
		}

		private void cmdSiguiente_Click(object sender, System.EventArgs e)
		{
			CurrentTab += 1;
			if (CurrentTab > TabCount)
				CurrentTab = 1;
			FrmGeneral.Visible = CurrentTab == 1;
			FrmArticulos.Visible = CurrentTab == 2;
			FrmComprobantes.Visible = CurrentTab == 3;
			FrmImpresion.Visible = CurrentTab == 4;
		}
	}
}