#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lazaro.WinMain.Misc.Config
{
	public partial class Preferencias : Lui.Forms.Form
	{
                private bool m_PrimeraVez = false;
		private int CurrentTab = 1;
                private const int TabCount = 4;

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

                
                /// <summary>
                /// Indica si se está mostrando las preferencias en el primer inicio
                /// </summary>
                public bool PrimeraVez
                {
                        get{
                                return m_PrimeraVez;
                        }
                        set{
                                m_PrimeraVez = value;
                                BotonSiguiente.Visible = value;
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
                        if (Lbl.Sys.Config.Actual.Empresa.ClaveTributaria == null)
                                EntradaEmpresaClaveTributaria.Text = "";
                        else
                                EntradaEmpresaClaveTributaria.Text = Lbl.Sys.Config.Actual.Empresa.ClaveTributaria.ToString();
                        EntradaEmpresaSituacion.TextInt = Lbl.Sys.Config.Actual.Empresa.SituacionTributaria;
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

			EntradaCambiaPrecioComprob.Value = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Documentos.CambiaPrecioItemFactura", "1") == "1";

                        EntradaLimiteCredito.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Cuentas.LimiteCreditoPredet", "0");
                        EntradaRedondeo.Text = this.Workspace.CurrentConfig.ReadGlobalSetting<string>("Sistema", "Moneda.Redondeo", "0.05");

                        EntradaPais.TextInt = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema", "Pais", 0);
                        if (EntradaPais.TextInt > 0)
                                EntradaPais.ReadOnly = true;
                        EntradaProvincia.TextInt = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema", "Provincia", 0);
                        EntradaLocalidad.TextInt = this.Workspace.CurrentConfig.ReadGlobalSetting<int>("Sistema", "Localidad", 0);
		}


		private bool GuardarConfig()
		{
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
                        if (EntradaEmpresaClaveTributaria.Text.Length > 0)
                                Lbl.Sys.Config.Actual.Empresa.ClaveTributaria = new Lbl.Personas.Claves.Cuit(EntradaEmpresaClaveTributaria.Text);
                        else
                                Lbl.Sys.Config.Actual.Empresa.ClaveTributaria = null;
                        Lbl.Sys.Config.Actual.Empresa.SituacionTributaria = EntradaEmpresaSituacion.TextInt;
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

			this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Documentos.CambiaPrecioItemFactura", EntradaCambiaPrecioComprob.Value ? "1" : "0", "*");

                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Cuentas.LimiteCreditoPredet", EntradaLimiteCredito.Text, "*");
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Moneda.Redondeo", EntradaRedondeo.Text, "*");

                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Pais", EntradaPais.TextInt.ToString(), 0);
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Provincia", EntradaProvincia.TextInt.ToString(), 0);
                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Localidad", EntradaLocalidad.TextInt.ToString(), 0);

                        this.Workspace.CurrentConfig.WriteGlobalSetting("Sistema", "Configurado", "1", 0);

                        if (this.PrimeraVez) {
                                // Hago cambios referentes al país donde está configurado el sistema

                                // Cambio la sucursal 1 y el cliente consumidor final a la localidad proporcionada
                                Lbl.Entidades.Localidad Loc = EntradaLocalidad.Elemento as Lbl.Entidades.Localidad;
                                if (Loc != null) {
                                        System.Data.IDbTransaction Trans = this.Connection.BeginTransaction();
                                        Lbl.Entidades.Sucursal Suc1 = new Lbl.Entidades.Sucursal(this.Connection, 1);
                                        Suc1.Localidad = Loc;
                                        Suc1.Guardar();

                                        Lbl.Personas.Persona ConsFinal = new Lbl.Personas.Persona(this.Connection, 999);
                                        ConsFinal.Localidad = Loc;
                                        ConsFinal.Guardar();

                                        Trans.Commit();
                                }
                        }

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
                        FrmAvanzado.Visible = CurrentTab == 4;
		}

                private void EntradaProvincia_TextChanged(object sender, System.EventArgs e)
                {
                        if (EntradaProvincia.TextInt != 0)
                                EntradaLocalidad.Filter = "id_provincia=" + EntradaProvincia.TextInt.ToString();
                        else
                                EntradaLocalidad.Filter = "";
                }

                private void EntradaPais_TextChanged(object sender, System.EventArgs e)
                {
                        Lbl.Entidades.Pais Pais = EntradaPais.Elemento as Lbl.Entidades.Pais;
                        if (Pais != null) {
                                if (Pais.ClavePersonasJuridicas != null)
                                        EtiquetaClaveTributaria.Text = Pais.ClavePersonasJuridicas.ToString();
                                else
                                        EtiquetaClaveTributaria.Text = "Clave Tributaria";
                                EntradaProvincia.Filter = "id_provincia IS NULL AND id_pais=" + Pais.Id.ToString();
                        } else {
                                EtiquetaClaveTributaria.Text = "Clave Tributaria";
                                EntradaProvincia.Filter = "id_provincia IS NULL";
                        }
                }
	}
}