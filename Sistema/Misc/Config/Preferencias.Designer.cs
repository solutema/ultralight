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

namespace Lazaro.WinMain.Misc.Config
{
	public partial class Preferencias
	{
                #region Código generado por el Diseñador de Windows Forms
                internal Lui.Forms.Frame FrmGeneral;
		internal Lui.Forms.Label label26;
		internal Lcc.Entrada.CodigoDetalle EntradaStockDepositoPredetSuc;
		internal Lui.Forms.Label label11;
		internal Lui.Forms.Label label12;
                internal Lui.Forms.TextBox EntradaPVR;
                internal Lui.Forms.ComboBox EntradaCambiaPrecioComprob;
                internal Lui.Forms.Label label13;

		// Limpiar los recursos que se están utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal Lui.Forms.Button BotonAceptar;
                internal Lui.Forms.Button CancelCommandButton;
		internal Lui.Forms.Label Label16;
		internal Lcc.Entrada.CodigoDetalle EntradaClientePredet;
		internal Lui.Forms.Label Label15;
		internal Lcc.Entrada.CodigoDetalle EntradaFormaPagoPredet;
		internal Lui.Forms.Label Label17;
		internal Lui.Forms.TextBox EntradaEmpresaNombre;
		internal Lui.Forms.Label Label18;
		internal Lui.Forms.Label Label19;
		internal Lui.Forms.TextBox EntradaEmpresaCuit;
		internal Lcc.Entrada.CodigoDetalle EntradaEmpresaSituacion;
		internal Lui.Forms.Label Label9;
		internal Lui.Forms.TextBox EntradaPVND;
		internal Lui.Forms.Label Label10;
		internal Lui.Forms.Label Label8;
		internal Lui.Forms.Label Label7;
		internal Lui.Forms.TextBox EntradaPVNC;
		internal Lui.Forms.TextBox EntradaPVABC;
		internal Lui.Forms.Label Label6;
		internal Lui.Forms.Label Label5;
		internal Lui.Forms.Label Label4;
		internal Lui.Forms.Label Label20;
		internal Lui.Forms.TextBox EntradaPV;
                internal Lui.Forms.ComboBox EntradaArticulosCodigoPredet;
                internal Lui.Forms.ComboBox EntradaStockMultideposito;
		internal Lui.Forms.Label Label23;
		internal Lui.Forms.Label Label24;
		internal Lcc.Entrada.CodigoDetalle EntradaStockDepositoPredet;
		internal Lui.Forms.Label Label25;
                internal Lui.Forms.ComboBox EntradaStockDecimales;
		internal Lui.Forms.Button BotonSiguiente;
		internal Lui.Forms.Frame FrmArticulos;
                internal Lui.Forms.Frame FrmComprobantes;

		private void InitializeComponent()
		{
                        this.BotonAceptar = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.EntradaEmpresaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label19 = new Lui.Forms.Label();
                        this.EntradaEmpresaCuit = new Lui.Forms.TextBox();
                        this.Label18 = new Lui.Forms.Label();
                        this.EntradaEmpresaNombre = new Lui.Forms.TextBox();
                        this.Label17 = new Lui.Forms.Label();
                        this.FrmGeneral = new Lui.Forms.Frame();
                        this.EntradaEmpresaId = new Lui.Forms.TextBox();
                        this.EntradaEmpresaRazonSocial = new Lui.Forms.TextBox();
                        this.EntradaEmpresaEmail = new Lui.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaActualizaciones = new Lui.Forms.ComboBox();
                        this.label30 = new Lui.Forms.Label();
                        this.EntradaAislacion = new Lui.Forms.ComboBox();
                        this.EntradaModoPantalla = new Lui.Forms.ComboBox();
                        this.EntradaBackup = new Lui.Forms.ComboBox();
                        this.label29 = new Lui.Forms.Label();
                        this.label27 = new Lui.Forms.Label();
                        this.label28 = new Lui.Forms.Label();
                        this.label14 = new Lui.Forms.Label();
                        this.EntradaStockDecimales = new Lui.Forms.ComboBox();
                        this.Label25 = new Lui.Forms.Label();
                        this.Label24 = new Lui.Forms.Label();
                        this.EntradaStockDepositoPredet = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaStockMultideposito = new Lui.Forms.ComboBox();
                        this.Label23 = new Lui.Forms.Label();
                        this.EntradaArticulosCodigoPredet = new Lui.Forms.ComboBox();
                        this.Label20 = new Lui.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.Label9 = new Lui.Forms.Label();
                        this.EntradaPVND = new Lui.Forms.TextBox();
                        this.Label10 = new Lui.Forms.Label();
                        this.Label8 = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.EntradaPVNC = new Lui.Forms.TextBox();
                        this.EntradaPVABC = new Lui.Forms.TextBox();
                        this.Label6 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label16 = new Lui.Forms.Label();
                        this.EntradaClientePredet = new Lcc.Entrada.CodigoDetalle();
                        this.Label15 = new Lui.Forms.Label();
                        this.EntradaFormaPagoPredet = new Lcc.Entrada.CodigoDetalle();
                        this.BotonSiguiente = new Lui.Forms.Button();
                        this.FrmArticulos = new Lui.Forms.Frame();
                        this.label26 = new Lui.Forms.Label();
                        this.EntradaStockDepositoPredetSuc = new Lcc.Entrada.CodigoDetalle();
                        this.FrmComprobantes = new Lui.Forms.Frame();
                        this.EntradaPVRC = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
                        this.label11 = new Lui.Forms.Label();
                        this.EntradaRedondeo = new Lui.Forms.TextBox();
                        this.label22 = new Lui.Forms.Label();
                        this.EntradaLimiteCredito = new Lui.Forms.TextBox();
                        this.label21 = new Lui.Forms.Label();
                        this.EntradaCambiaPrecioComprob = new Lui.Forms.ComboBox();
                        this.label13 = new Lui.Forms.Label();
                        this.EntradaPVR = new Lui.Forms.TextBox();
                        this.label12 = new Lui.Forms.Label();
                        this.FrmGeneral.SuspendLayout();
                        this.FrmArticulos.SuspendLayout();
                        this.FrmComprobantes.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // BotonAceptar
                        // 
                        this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAceptar.Image = null;
                        this.BotonAceptar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAceptar.Location = new System.Drawing.Point(444, 405);
                        this.BotonAceptar.Name = "BotonAceptar";
                        this.BotonAceptar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAceptar.ReadOnly = false;
                        this.BotonAceptar.Size = new System.Drawing.Size(88, 32);
                        this.BotonAceptar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAceptar.Subtext = "F9";
                        this.BotonAceptar.TabIndex = 6;
                        this.BotonAceptar.Text = "Guardar";
                        this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(536, 405);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(88, 32);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 7;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // EntradaEmpresaSituacion
                        // 
                        this.EntradaEmpresaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmpresaSituacion.AutoNav = true;
                        this.EntradaEmpresaSituacion.AutoTab = true;
                        this.EntradaEmpresaSituacion.CanCreate = true;
                        this.EntradaEmpresaSituacion.DataTextField = "nombre";
                        this.EntradaEmpresaSituacion.DataValueField = "id_situacion";
                        this.EntradaEmpresaSituacion.Filter = "";
                        this.EntradaEmpresaSituacion.FreeTextCode = "";
                        this.EntradaEmpresaSituacion.Location = new System.Drawing.Point(176, 120);
                        this.EntradaEmpresaSituacion.MaxLength = 200;
                        this.EntradaEmpresaSituacion.Name = "EntradaEmpresaSituacion";
                        this.EntradaEmpresaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaSituacion.ReadOnly = false;
                        this.EntradaEmpresaSituacion.Required = true;
                        this.EntradaEmpresaSituacion.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaSituacion.TabIndex = 7;
                        this.EntradaEmpresaSituacion.Table = "situaciones";
                        this.EntradaEmpresaSituacion.Text = "0";
                        this.EntradaEmpresaSituacion.TextDetail = "";
                        // 
                        // Label19
                        // 
                        this.Label19.Location = new System.Drawing.Point(16, 120);
                        this.Label19.Name = "Label19";
                        this.Label19.Size = new System.Drawing.Size(160, 24);
                        this.Label19.TabIndex = 6;
                        this.Label19.Text = "Condición IVA";
                        this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaCuit
                        // 
                        this.EntradaEmpresaCuit.AutoNav = true;
                        this.EntradaEmpresaCuit.AutoTab = true;
                        this.EntradaEmpresaCuit.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaCuit.DecimalPlaces = -1;
                        this.EntradaEmpresaCuit.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaCuit.Location = new System.Drawing.Point(176, 92);
                        this.EntradaEmpresaCuit.MaxLength = 13;
                        this.EntradaEmpresaCuit.MultiLine = false;
                        this.EntradaEmpresaCuit.Name = "EntradaEmpresaCuit";
                        this.EntradaEmpresaCuit.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaCuit.ReadOnly = false;
                        this.EntradaEmpresaCuit.SelectOnFocus = false;
                        this.EntradaEmpresaCuit.Size = new System.Drawing.Size(112, 24);
                        this.EntradaEmpresaCuit.TabIndex = 5;
                        // 
                        // Label18
                        // 
                        this.Label18.Location = new System.Drawing.Point(16, 92);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(160, 24);
                        this.Label18.TabIndex = 4;
                        this.Label18.Text = "CUIT";
                        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaNombre
                        // 
                        this.EntradaEmpresaNombre.AutoNav = true;
                        this.EntradaEmpresaNombre.AutoTab = true;
                        this.EntradaEmpresaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaNombre.DecimalPlaces = -1;
                        this.EntradaEmpresaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaNombre.Location = new System.Drawing.Point(176, 36);
                        this.EntradaEmpresaNombre.MaxLength = 200;
                        this.EntradaEmpresaNombre.MultiLine = false;
                        this.EntradaEmpresaNombre.Name = "EntradaEmpresaNombre";
                        this.EntradaEmpresaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaNombre.ReadOnly = false;
                        this.EntradaEmpresaNombre.SelectOnFocus = false;
                        this.EntradaEmpresaNombre.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaNombre.TabIndex = 1;
                        // 
                        // Label17
                        // 
                        this.Label17.Location = new System.Drawing.Point(16, 36);
                        this.Label17.Name = "Label17";
                        this.Label17.Size = new System.Drawing.Size(160, 24);
                        this.Label17.TabIndex = 0;
                        this.Label17.Text = "Nombre";
                        this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FrmGeneral
                        // 
                        this.FrmGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaId);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaRazonSocial);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaEmail);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaCuit);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaSituacion);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaNombre);
                        this.FrmGeneral.Controls.Add(this.label2);
                        this.FrmGeneral.Controls.Add(this.label1);
                        this.FrmGeneral.Controls.Add(this.EntradaActualizaciones);
                        this.FrmGeneral.Controls.Add(this.label30);
                        this.FrmGeneral.Controls.Add(this.EntradaAislacion);
                        this.FrmGeneral.Controls.Add(this.EntradaModoPantalla);
                        this.FrmGeneral.Controls.Add(this.EntradaBackup);
                        this.FrmGeneral.Controls.Add(this.label29);
                        this.FrmGeneral.Controls.Add(this.label27);
                        this.FrmGeneral.Controls.Add(this.label28);
                        this.FrmGeneral.Controls.Add(this.label14);
                        this.FrmGeneral.Controls.Add(this.Label19);
                        this.FrmGeneral.Controls.Add(this.Label18);
                        this.FrmGeneral.Controls.Add(this.Label17);
                        this.FrmGeneral.Location = new System.Drawing.Point(8, 8);
                        this.FrmGeneral.Name = "FrmGeneral";
                        this.FrmGeneral.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmGeneral.ReadOnly = false;
                        this.FrmGeneral.Size = new System.Drawing.Size(620, 385);
                        this.FrmGeneral.TabIndex = 0;
                        this.FrmGeneral.Text = "Generalidades";
                        // 
                        // EntradaEmpresaId
                        // 
                        this.EntradaEmpresaId.AutoNav = true;
                        this.EntradaEmpresaId.AutoTab = true;
                        this.EntradaEmpresaId.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaEmpresaId.DecimalPlaces = -1;
                        this.EntradaEmpresaId.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaId.Location = new System.Drawing.Point(176, 176);
                        this.EntradaEmpresaId.MaxLength = 3;
                        this.EntradaEmpresaId.MultiLine = false;
                        this.EntradaEmpresaId.Name = "EntradaEmpresaId";
                        this.EntradaEmpresaId.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaId.ReadOnly = false;
                        this.EntradaEmpresaId.SelectOnFocus = false;
                        this.EntradaEmpresaId.Size = new System.Drawing.Size(48, 24);
                        this.EntradaEmpresaId.TabIndex = 11;
                        this.EntradaEmpresaId.Text = "0";
                        // 
                        // EntradaEmpresaRazonSocial
                        // 
                        this.EntradaEmpresaRazonSocial.AutoNav = true;
                        this.EntradaEmpresaRazonSocial.AutoTab = true;
                        this.EntradaEmpresaRazonSocial.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaRazonSocial.DecimalPlaces = -1;
                        this.EntradaEmpresaRazonSocial.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaRazonSocial.Location = new System.Drawing.Point(176, 64);
                        this.EntradaEmpresaRazonSocial.MaxLength = 200;
                        this.EntradaEmpresaRazonSocial.MultiLine = false;
                        this.EntradaEmpresaRazonSocial.Name = "EntradaEmpresaRazonSocial";
                        this.EntradaEmpresaRazonSocial.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaRazonSocial.ReadOnly = false;
                        this.EntradaEmpresaRazonSocial.SelectOnFocus = false;
                        this.EntradaEmpresaRazonSocial.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaRazonSocial.TabIndex = 3;
                        // 
                        // EntradaEmpresaEmail
                        // 
                        this.EntradaEmpresaEmail.AutoNav = true;
                        this.EntradaEmpresaEmail.AutoTab = true;
                        this.EntradaEmpresaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaEmail.DecimalPlaces = -1;
                        this.EntradaEmpresaEmail.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaEmail.Location = new System.Drawing.Point(176, 148);
                        this.EntradaEmpresaEmail.MaxLength = 200;
                        this.EntradaEmpresaEmail.MultiLine = false;
                        this.EntradaEmpresaEmail.Name = "EntradaEmpresaEmail";
                        this.EntradaEmpresaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaEmail.ReadOnly = false;
                        this.EntradaEmpresaEmail.SelectOnFocus = false;
                        this.EntradaEmpresaEmail.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaEmail.TabIndex = 9;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(16, 176);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(160, 24);
                        this.label2.TabIndex = 10;
                        this.label2.Text = "Id de empresa";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(16, 64);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(160, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Razón social";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaActualizaciones
                        // 
                        this.EntradaActualizaciones.AlwaysExpanded = false;
                        this.EntradaActualizaciones.AutoNav = true;
                        this.EntradaActualizaciones.AutoTab = true;
                        this.EntradaActualizaciones.Location = new System.Drawing.Point(248, 332);
                        this.EntradaActualizaciones.Name = "EntradaActualizaciones";
                        this.EntradaActualizaciones.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaActualizaciones.ReadOnly = false;
                        this.EntradaActualizaciones.SetData = new string[] {
        "Estables|stable",
        "Preliminares|gama",
        "En prueba|beta"};
                        this.EntradaActualizaciones.Size = new System.Drawing.Size(132, 24);
                        this.EntradaActualizaciones.TabIndex = 19;
                        this.EntradaActualizaciones.TextKey = "stable";
                        // 
                        // label30
                        // 
                        this.label30.Location = new System.Drawing.Point(16, 332);
                        this.label30.Name = "label30";
                        this.label30.Size = new System.Drawing.Size(232, 24);
                        this.label30.TabIndex = 18;
                        this.label30.Text = "Recibir actualizaciones";
                        this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAislacion
                        // 
                        this.EntradaAislacion.AlwaysExpanded = false;
                        this.EntradaAislacion.AutoNav = true;
                        this.EntradaAislacion.AutoTab = true;
                        this.EntradaAislacion.Location = new System.Drawing.Point(248, 300);
                        this.EntradaAislacion.Name = "EntradaAislacion";
                        this.EntradaAislacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAislacion.ReadOnly = false;
                        this.EntradaAislacion.SetData = new string[] {
        "Mejor concurrencia|RepeatableRead",
        "Mejor consitencia|Serializable"};
                        this.EntradaAislacion.Size = new System.Drawing.Size(196, 24);
                        this.EntradaAislacion.TabIndex = 17;
                        this.EntradaAislacion.TextKey = "Serializable";
                        // 
                        // EntradaModoPantalla
                        // 
                        this.EntradaModoPantalla.AlwaysExpanded = false;
                        this.EntradaModoPantalla.AutoNav = true;
                        this.EntradaModoPantalla.AutoTab = true;
                        this.EntradaModoPantalla.Location = new System.Drawing.Point(248, 268);
                        this.EntradaModoPantalla.Name = "EntradaModoPantalla";
                        this.EntradaModoPantalla.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModoPantalla.ReadOnly = false;
                        this.EntradaModoPantalla.SetData = new string[] {
        "Predeterminado|*",
        "Ventana Normal|normal",
        "Ventana Maximizada|maximizado",
        "Pantalla Completa|completo",
        "Ventanas Flotantes|flotante"};
                        this.EntradaModoPantalla.Size = new System.Drawing.Size(196, 24);
                        this.EntradaModoPantalla.TabIndex = 15;
                        this.EntradaModoPantalla.TextKey = "maximizado";
                        // 
                        // EntradaBackup
                        // 
                        this.EntradaBackup.AlwaysExpanded = false;
                        this.EntradaBackup.AutoNav = true;
                        this.EntradaBackup.AutoTab = true;
                        this.EntradaBackup.Location = new System.Drawing.Point(248, 236);
                        this.EntradaBackup.Name = "EntradaBackup";
                        this.EntradaBackup.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBackup.ReadOnly = false;
                        this.EntradaBackup.SetData = new string[] {
        "Nunca|0",
        "Cuando se solicita|1",
        "Automáticamente|2"};
                        this.EntradaBackup.Size = new System.Drawing.Size(196, 24);
                        this.EntradaBackup.TabIndex = 13;
                        this.EntradaBackup.TextKey = "0";
                        // 
                        // label29
                        // 
                        this.label29.Location = new System.Drawing.Point(16, 300);
                        this.label29.Name = "label29";
                        this.label29.Size = new System.Drawing.Size(232, 24);
                        this.label29.TabIndex = 16;
                        this.label29.Text = "Nivel de aislamiento de clientes";
                        this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label27
                        // 
                        this.label27.Location = new System.Drawing.Point(16, 268);
                        this.label27.Name = "label27";
                        this.label27.Size = new System.Drawing.Size(232, 24);
                        this.label27.TabIndex = 14;
                        this.label27.Text = "Modo de uso de la pantalla";
                        this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label28
                        // 
                        this.label28.Location = new System.Drawing.Point(16, 148);
                        this.label28.Name = "label28";
                        this.label28.Size = new System.Drawing.Size(160, 24);
                        this.label28.TabIndex = 8;
                        this.label28.Text = "Correo electrónico";
                        this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label14
                        // 
                        this.label14.Location = new System.Drawing.Point(16, 236);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(232, 24);
                        this.label14.TabIndex = 12;
                        this.label14.Text = "Realizar copias de respaldo";
                        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockDecimales
                        // 
                        this.EntradaStockDecimales.AlwaysExpanded = false;
                        this.EntradaStockDecimales.AutoNav = true;
                        this.EntradaStockDecimales.AutoTab = true;
                        this.EntradaStockDecimales.Location = new System.Drawing.Point(192, 92);
                        this.EntradaStockDecimales.Name = "EntradaStockDecimales";
                        this.EntradaStockDecimales.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDecimales.ReadOnly = false;
                        this.EntradaStockDecimales.SetData = new string[] {
        "Sin decimales|0",
        "Un decimal|1",
        "Dos decimales|2",
        "Tres decimales|3",
        "Cuatro decimales|4"};
                        this.EntradaStockDecimales.Size = new System.Drawing.Size(160, 24);
                        this.EntradaStockDecimales.TabIndex = 5;
                        this.EntradaStockDecimales.TextKey = "0";
                        // 
                        // Label25
                        // 
                        this.Label25.Location = new System.Drawing.Point(16, 92);
                        this.Label25.Name = "Label25";
                        this.Label25.Size = new System.Drawing.Size(176, 24);
                        this.Label25.TabIndex = 4;
                        this.Label25.Text = "Precisión del Stock";
                        this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label24
                        // 
                        this.Label24.Location = new System.Drawing.Point(16, 120);
                        this.Label24.Name = "Label24";
                        this.Label24.Size = new System.Drawing.Size(176, 24);
                        this.Label24.TabIndex = 6;
                        this.Label24.Text = "Deposito Predeterminado";
                        this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockDepositoPredet
                        // 
                        this.EntradaStockDepositoPredet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaStockDepositoPredet.AutoNav = true;
                        this.EntradaStockDepositoPredet.AutoTab = true;
                        this.EntradaStockDepositoPredet.CanCreate = true;
                        this.EntradaStockDepositoPredet.DataTextField = "nombre";
                        this.EntradaStockDepositoPredet.DataValueField = "id_situacion";
                        this.EntradaStockDepositoPredet.Filter = "";
                        this.EntradaStockDepositoPredet.FreeTextCode = "";
                        this.EntradaStockDepositoPredet.Location = new System.Drawing.Point(192, 120);
                        this.EntradaStockDepositoPredet.MaxLength = 200;
                        this.EntradaStockDepositoPredet.Name = "EntradaStockDepositoPredet";
                        this.EntradaStockDepositoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDepositoPredet.ReadOnly = false;
                        this.EntradaStockDepositoPredet.Required = false;
                        this.EntradaStockDepositoPredet.Size = new System.Drawing.Size(416, 24);
                        this.EntradaStockDepositoPredet.TabIndex = 7;
                        this.EntradaStockDepositoPredet.Table = "articulos_situaciones";
                        this.EntradaStockDepositoPredet.Text = "0";
                        this.EntradaStockDepositoPredet.TextDetail = "";
                        // 
                        // EntradaStockMultideposito
                        // 
                        this.EntradaStockMultideposito.AlwaysExpanded = false;
                        this.EntradaStockMultideposito.AutoNav = true;
                        this.EntradaStockMultideposito.AutoTab = true;
                        this.EntradaStockMultideposito.Location = new System.Drawing.Point(192, 64);
                        this.EntradaStockMultideposito.Name = "EntradaStockMultideposito";
                        this.EntradaStockMultideposito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMultideposito.ReadOnly = false;
                        this.EntradaStockMultideposito.SetData = new string[] {
        "Estándar|0",
        "Multidepósito|1"};
                        this.EntradaStockMultideposito.Size = new System.Drawing.Size(224, 24);
                        this.EntradaStockMultideposito.TabIndex = 3;
                        this.EntradaStockMultideposito.TextKey = "0";
                        // 
                        // Label23
                        // 
                        this.Label23.Location = new System.Drawing.Point(16, 64);
                        this.Label23.Name = "Label23";
                        this.Label23.Size = new System.Drawing.Size(176, 24);
                        this.Label23.TabIndex = 2;
                        this.Label23.Text = "Control de Existencias";
                        this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaArticulosCodigoPredet
                        // 
                        this.EntradaArticulosCodigoPredet.AlwaysExpanded = false;
                        this.EntradaArticulosCodigoPredet.AutoNav = true;
                        this.EntradaArticulosCodigoPredet.AutoTab = true;
                        this.EntradaArticulosCodigoPredet.Location = new System.Drawing.Point(192, 36);
                        this.EntradaArticulosCodigoPredet.Name = "EntradaArticulosCodigoPredet";
                        this.EntradaArticulosCodigoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaArticulosCodigoPredet.ReadOnly = false;
                        this.EntradaArticulosCodigoPredet.SetData = new string[] {
        "Autonumérico incorporado|0",
        "Cód. 1|1",
        "Cód. 2|2",
        "Cód. 3|3",
        "Cód. 4|4"};
                        this.EntradaArticulosCodigoPredet.Size = new System.Drawing.Size(224, 24);
                        this.EntradaArticulosCodigoPredet.TabIndex = 1;
                        this.EntradaArticulosCodigoPredet.TextKey = "0";
                        // 
                        // Label20
                        // 
                        this.Label20.Location = new System.Drawing.Point(16, 36);
                        this.Label20.Name = "Label20";
                        this.Label20.Size = new System.Drawing.Size(176, 24);
                        this.Label20.TabIndex = 0;
                        this.Label20.Text = "Código Predeterminado";
                        this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.Location = new System.Drawing.Point(248, 100);
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPV.TabIndex = 5;
                        this.EntradaPV.Text = "0";
                        // 
                        // Label9
                        // 
                        this.Label9.Location = new System.Drawing.Point(308, 184);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(264, 24);
                        this.Label9.TabIndex = 14;
                        this.Label9.Text = "(0 para utilizar el mismo que para facturas)";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVND
                        // 
                        this.EntradaPVND.AutoNav = true;
                        this.EntradaPVND.AutoTab = true;
                        this.EntradaPVND.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVND.DecimalPlaces = -1;
                        this.EntradaPVND.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVND.Location = new System.Drawing.Point(248, 184);
                        this.EntradaPVND.MultiLine = false;
                        this.EntradaPVND.Name = "EntradaPVND";
                        this.EntradaPVND.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVND.ReadOnly = false;
                        this.EntradaPVND.SelectOnFocus = true;
                        this.EntradaPVND.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVND.TabIndex = 13;
                        this.EntradaPVND.Text = "0";
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(12, 184);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(236, 24);
                        this.Label10.TabIndex = 12;
                        this.Label10.Text = "PV para Notas de Débito A, B y C";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(308, 156);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(264, 24);
                        this.Label8.TabIndex = 11;
                        this.Label8.Text = "(0 para utilizar el mismo que para facturas)";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(308, 128);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(264, 24);
                        this.Label7.TabIndex = 8;
                        this.Label7.Text = "(0 para utilizar el predeterminado)";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVNC
                        // 
                        this.EntradaPVNC.AutoNav = true;
                        this.EntradaPVNC.AutoTab = true;
                        this.EntradaPVNC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVNC.DecimalPlaces = -1;
                        this.EntradaPVNC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVNC.Location = new System.Drawing.Point(248, 156);
                        this.EntradaPVNC.MultiLine = false;
                        this.EntradaPVNC.Name = "EntradaPVNC";
                        this.EntradaPVNC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVNC.ReadOnly = false;
                        this.EntradaPVNC.SelectOnFocus = true;
                        this.EntradaPVNC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVNC.TabIndex = 10;
                        this.EntradaPVNC.Text = "0";
                        // 
                        // EntradaPVABC
                        // 
                        this.EntradaPVABC.AutoNav = true;
                        this.EntradaPVABC.AutoTab = true;
                        this.EntradaPVABC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVABC.DecimalPlaces = -1;
                        this.EntradaPVABC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVABC.Location = new System.Drawing.Point(248, 128);
                        this.EntradaPVABC.MultiLine = false;
                        this.EntradaPVABC.Name = "EntradaPVABC";
                        this.EntradaPVABC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVABC.ReadOnly = false;
                        this.EntradaPVABC.SelectOnFocus = true;
                        this.EntradaPVABC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVABC.TabIndex = 7;
                        this.EntradaPVABC.Text = "0";
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(12, 156);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(236, 24);
                        this.Label6.TabIndex = 9;
                        this.Label6.Text = "PV para Notas de Crédito A, B y C";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 128);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(236, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "PV para Facturas A, B y C";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(12, 100);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(236, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "PV Predeterminado";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(12, 36);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(172, 24);
                        this.Label16.TabIndex = 0;
                        this.Label16.Text = "Cliente Predeterminado";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaClientePredet
                        // 
                        this.EntradaClientePredet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaClientePredet.AutoNav = true;
                        this.EntradaClientePredet.AutoTab = true;
                        this.EntradaClientePredet.CanCreate = true;
                        this.EntradaClientePredet.DataTextField = "nombre_visible";
                        this.EntradaClientePredet.DataValueField = "id_persona";
                        this.EntradaClientePredet.Filter = "";
                        this.EntradaClientePredet.FreeTextCode = "";
                        this.EntradaClientePredet.Location = new System.Drawing.Point(184, 36);
                        this.EntradaClientePredet.MaxLength = 200;
                        this.EntradaClientePredet.Name = "EntradaClientePredet";
                        this.EntradaClientePredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaClientePredet.PlaceholderText = "Ninguno";
                        this.EntradaClientePredet.ReadOnly = false;
                        this.EntradaClientePredet.Required = false;
                        this.EntradaClientePredet.Size = new System.Drawing.Size(428, 24);
                        this.EntradaClientePredet.TabIndex = 1;
                        this.EntradaClientePredet.Table = "personas";
                        this.EntradaClientePredet.Text = "0";
                        this.EntradaClientePredet.TextDetail = "";
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(12, 64);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(172, 24);
                        this.Label15.TabIndex = 2;
                        this.Label15.Text = "Forma de Pago Predet.";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFormaPagoPredet
                        // 
                        this.EntradaFormaPagoPredet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFormaPagoPredet.AutoNav = true;
                        this.EntradaFormaPagoPredet.AutoTab = true;
                        this.EntradaFormaPagoPredet.CanCreate = true;
                        this.EntradaFormaPagoPredet.DataTextField = "nombre";
                        this.EntradaFormaPagoPredet.DataValueField = "id_formapago";
                        this.EntradaFormaPagoPredet.Filter = "estado=1";
                        this.EntradaFormaPagoPredet.FreeTextCode = "";
                        this.EntradaFormaPagoPredet.Location = new System.Drawing.Point(184, 64);
                        this.EntradaFormaPagoPredet.MaxLength = 200;
                        this.EntradaFormaPagoPredet.Name = "EntradaFormaPagoPredet";
                        this.EntradaFormaPagoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPagoPredet.PlaceholderText = "Ninguna";
                        this.EntradaFormaPagoPredet.ReadOnly = false;
                        this.EntradaFormaPagoPredet.Required = false;
                        this.EntradaFormaPagoPredet.Size = new System.Drawing.Size(280, 24);
                        this.EntradaFormaPagoPredet.TabIndex = 3;
                        this.EntradaFormaPagoPredet.Table = "formaspago";
                        this.EntradaFormaPagoPredet.Text = "0";
                        this.EntradaFormaPagoPredet.TextDetail = "";
                        // 
                        // BotonSiguiente
                        // 
                        this.BotonSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSiguiente.Image = null;
                        this.BotonSiguiente.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSiguiente.Location = new System.Drawing.Point(8, 405);
                        this.BotonSiguiente.Name = "BotonSiguiente";
                        this.BotonSiguiente.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSiguiente.ReadOnly = false;
                        this.BotonSiguiente.Size = new System.Drawing.Size(96, 32);
                        this.BotonSiguiente.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSiguiente.Subtext = "F9";
                        this.BotonSiguiente.TabIndex = 5;
                        this.BotonSiguiente.Text = "Más...";
                        this.BotonSiguiente.Click += new System.EventHandler(this.BotonSiguiente_Click);
                        // 
                        // FrmArticulos
                        // 
                        this.FrmArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmArticulos.Controls.Add(this.label26);
                        this.FrmArticulos.Controls.Add(this.EntradaStockDepositoPredetSuc);
                        this.FrmArticulos.Controls.Add(this.EntradaStockDecimales);
                        this.FrmArticulos.Controls.Add(this.Label25);
                        this.FrmArticulos.Controls.Add(this.Label24);
                        this.FrmArticulos.Controls.Add(this.EntradaStockDepositoPredet);
                        this.FrmArticulos.Controls.Add(this.EntradaStockMultideposito);
                        this.FrmArticulos.Controls.Add(this.Label23);
                        this.FrmArticulos.Controls.Add(this.EntradaArticulosCodigoPredet);
                        this.FrmArticulos.Controls.Add(this.Label20);
                        this.FrmArticulos.Location = new System.Drawing.Point(8, 8);
                        this.FrmArticulos.Name = "FrmArticulos";
                        this.FrmArticulos.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmArticulos.ReadOnly = false;
                        this.FrmArticulos.Size = new System.Drawing.Size(620, 385);
                        this.FrmArticulos.TabIndex = 0;
                        this.FrmArticulos.TabStop = false;
                        this.FrmArticulos.Text = "Artículos";
                        this.FrmArticulos.Visible = false;
                        // 
                        // label26
                        // 
                        this.label26.Location = new System.Drawing.Point(16, 148);
                        this.label26.Name = "label26";
                        this.label26.Size = new System.Drawing.Size(176, 24);
                        this.label26.TabIndex = 8;
                        this.label26.Text = "Deposito Sucursal";
                        this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockDepositoPredetSuc
                        // 
                        this.EntradaStockDepositoPredetSuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaStockDepositoPredetSuc.AutoNav = true;
                        this.EntradaStockDepositoPredetSuc.AutoTab = true;
                        this.EntradaStockDepositoPredetSuc.CanCreate = true;
                        this.EntradaStockDepositoPredetSuc.DataTextField = "nombre";
                        this.EntradaStockDepositoPredetSuc.DataValueField = "id_situacion";
                        this.EntradaStockDepositoPredetSuc.Filter = "";
                        this.EntradaStockDepositoPredetSuc.FreeTextCode = "";
                        this.EntradaStockDepositoPredetSuc.Location = new System.Drawing.Point(192, 148);
                        this.EntradaStockDepositoPredetSuc.MaxLength = 200;
                        this.EntradaStockDepositoPredetSuc.Name = "EntradaStockDepositoPredetSuc";
                        this.EntradaStockDepositoPredetSuc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDepositoPredetSuc.ReadOnly = false;
                        this.EntradaStockDepositoPredetSuc.Required = false;
                        this.EntradaStockDepositoPredetSuc.Size = new System.Drawing.Size(416, 24);
                        this.EntradaStockDepositoPredetSuc.TabIndex = 9;
                        this.EntradaStockDepositoPredetSuc.Table = "articulos_situaciones";
                        this.EntradaStockDepositoPredetSuc.Text = "0";
                        this.EntradaStockDepositoPredetSuc.TextDetail = "";
                        // 
                        // FrmComprobantes
                        // 
                        this.FrmComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmComprobantes.Controls.Add(this.EntradaPVRC);
                        this.FrmComprobantes.Controls.Add(this.label3);
                        this.FrmComprobantes.Controls.Add(this.label11);
                        this.FrmComprobantes.Controls.Add(this.EntradaRedondeo);
                        this.FrmComprobantes.Controls.Add(this.label22);
                        this.FrmComprobantes.Controls.Add(this.EntradaLimiteCredito);
                        this.FrmComprobantes.Controls.Add(this.label21);
                        this.FrmComprobantes.Controls.Add(this.EntradaCambiaPrecioComprob);
                        this.FrmComprobantes.Controls.Add(this.label13);
                        this.FrmComprobantes.Controls.Add(this.EntradaPVR);
                        this.FrmComprobantes.Controls.Add(this.label12);
                        this.FrmComprobantes.Controls.Add(this.EntradaPV);
                        this.FrmComprobantes.Controls.Add(this.Label9);
                        this.FrmComprobantes.Controls.Add(this.EntradaPVND);
                        this.FrmComprobantes.Controls.Add(this.Label10);
                        this.FrmComprobantes.Controls.Add(this.Label8);
                        this.FrmComprobantes.Controls.Add(this.Label7);
                        this.FrmComprobantes.Controls.Add(this.EntradaPVNC);
                        this.FrmComprobantes.Controls.Add(this.EntradaPVABC);
                        this.FrmComprobantes.Controls.Add(this.Label6);
                        this.FrmComprobantes.Controls.Add(this.Label5);
                        this.FrmComprobantes.Controls.Add(this.Label4);
                        this.FrmComprobantes.Controls.Add(this.Label16);
                        this.FrmComprobantes.Controls.Add(this.EntradaClientePredet);
                        this.FrmComprobantes.Controls.Add(this.Label15);
                        this.FrmComprobantes.Controls.Add(this.EntradaFormaPagoPredet);
                        this.FrmComprobantes.Location = new System.Drawing.Point(8, 8);
                        this.FrmComprobantes.Name = "FrmComprobantes";
                        this.FrmComprobantes.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmComprobantes.ReadOnly = false;
                        this.FrmComprobantes.Size = new System.Drawing.Size(620, 385);
                        this.FrmComprobantes.TabIndex = 0;
                        this.FrmComprobantes.TabStop = false;
                        this.FrmComprobantes.Text = "Comprobantes";
                        this.FrmComprobantes.Visible = false;
                        // 
                        // EntradaPVRC
                        // 
                        this.EntradaPVRC.AutoNav = true;
                        this.EntradaPVRC.AutoTab = true;
                        this.EntradaPVRC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVRC.DecimalPlaces = -1;
                        this.EntradaPVRC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVRC.Location = new System.Drawing.Point(248, 240);
                        this.EntradaPVRC.MultiLine = false;
                        this.EntradaPVRC.Name = "EntradaPVRC";
                        this.EntradaPVRC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVRC.ReadOnly = false;
                        this.EntradaPVRC.SelectOnFocus = true;
                        this.EntradaPVRC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVRC.TabIndex = 19;
                        this.EntradaPVRC.Text = "0";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(12, 240);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(236, 24);
                        this.label3.TabIndex = 18;
                        this.label3.Text = "PV para Recibos";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label11
                        // 
                        this.label11.Location = new System.Drawing.Point(308, 212);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(264, 24);
                        this.label11.TabIndex = 17;
                        this.label11.Text = "(0 para utilizar el mismo que para facturas)";
                        this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaRedondeo
                        // 
                        this.EntradaRedondeo.AutoNav = true;
                        this.EntradaRedondeo.AutoTab = true;
                        this.EntradaRedondeo.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaRedondeo.DecimalPlaces = -1;
                        this.EntradaRedondeo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaRedondeo.Location = new System.Drawing.Point(248, 348);
                        this.EntradaRedondeo.MultiLine = false;
                        this.EntradaRedondeo.Name = "EntradaRedondeo";
                        this.EntradaRedondeo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRedondeo.Prefijo = "$";
                        this.EntradaRedondeo.ReadOnly = false;
                        this.EntradaRedondeo.SelectOnFocus = true;
                        this.EntradaRedondeo.Size = new System.Drawing.Size(92, 24);
                        this.EntradaRedondeo.TabIndex = 25;
                        this.EntradaRedondeo.Text = "0.00";
                        // 
                        // label22
                        // 
                        this.label22.Location = new System.Drawing.Point(12, 348);
                        this.label22.Name = "label22";
                        this.label22.Size = new System.Drawing.Size(236, 24);
                        this.label22.TabIndex = 24;
                        this.label22.Text = "Redondeo en comprobantes";
                        this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.AutoNav = true;
                        this.EntradaLimiteCredito.AutoTab = true;
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaLimiteCredito.DecimalPlaces = -1;
                        this.EntradaLimiteCredito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaLimiteCredito.Location = new System.Drawing.Point(248, 316);
                        this.EntradaLimiteCredito.MultiLine = false;
                        this.EntradaLimiteCredito.Name = "EntradaLimiteCredito";
                        this.EntradaLimiteCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLimiteCredito.Prefijo = "$";
                        this.EntradaLimiteCredito.ReadOnly = false;
                        this.EntradaLimiteCredito.SelectOnFocus = true;
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(124, 24);
                        this.EntradaLimiteCredito.TabIndex = 23;
                        this.EntradaLimiteCredito.Text = "0.00";
                        // 
                        // label21
                        // 
                        this.label21.Location = new System.Drawing.Point(12, 316);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(236, 24);
                        this.label21.TabIndex = 22;
                        this.label21.Text = "Límite de crédito predeterminado";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCambiaPrecioComprob
                        // 
                        this.EntradaCambiaPrecioComprob.AlwaysExpanded = false;
                        this.EntradaCambiaPrecioComprob.AutoNav = true;
                        this.EntradaCambiaPrecioComprob.AutoTab = true;
                        this.EntradaCambiaPrecioComprob.Location = new System.Drawing.Point(420, 280);
                        this.EntradaCambiaPrecioComprob.Name = "EntradaCambiaPrecioComprob";
                        this.EntradaCambiaPrecioComprob.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCambiaPrecioComprob.ReadOnly = false;
                        this.EntradaCambiaPrecioComprob.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaCambiaPrecioComprob.Size = new System.Drawing.Size(64, 24);
                        this.EntradaCambiaPrecioComprob.TabIndex = 21;
                        this.EntradaCambiaPrecioComprob.TextKey = "1";
                        // 
                        // label13
                        // 
                        this.label13.Location = new System.Drawing.Point(12, 280);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(408, 24);
                        this.label13.TabIndex = 20;
                        this.label13.Text = "Permite cambiar precio del artículo durante la facturación";
                        this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVR
                        // 
                        this.EntradaPVR.AutoNav = true;
                        this.EntradaPVR.AutoTab = true;
                        this.EntradaPVR.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVR.DecimalPlaces = -1;
                        this.EntradaPVR.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVR.Location = new System.Drawing.Point(248, 212);
                        this.EntradaPVR.MultiLine = false;
                        this.EntradaPVR.Name = "EntradaPVR";
                        this.EntradaPVR.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVR.ReadOnly = false;
                        this.EntradaPVR.SelectOnFocus = true;
                        this.EntradaPVR.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVR.TabIndex = 16;
                        this.EntradaPVR.Text = "0";
                        // 
                        // label12
                        // 
                        this.label12.Location = new System.Drawing.Point(12, 212);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(236, 24);
                        this.label12.TabIndex = 15;
                        this.label12.Text = "PV para Remitos";
                        this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Preferencias
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 448);
                        this.Controls.Add(this.BotonSiguiente);
                        this.Controls.Add(this.CancelCommandButton);
                        this.Controls.Add(this.BotonAceptar);
                        this.Controls.Add(this.FrmGeneral);
                        this.Controls.Add(this.FrmComprobantes);
                        this.Controls.Add(this.FrmArticulos);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "Preferencias";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Preferencias";
                        this.FrmGeneral.ResumeLayout(false);
                        this.FrmGeneral.PerformLayout();
                        this.FrmArticulos.ResumeLayout(false);
                        this.FrmArticulos.PerformLayout();
                        this.FrmComprobantes.ResumeLayout(false);
                        this.FrmComprobantes.PerformLayout();
                        this.ResumeLayout(false);

		}
		#endregion

                internal Lui.Forms.ComboBox EntradaBackup;
                internal Lui.Forms.Label label14;
                internal Lui.Forms.TextBox EntradaLimiteCredito;
                internal Lui.Forms.Label label21;
                internal Lui.Forms.TextBox EntradaRedondeo;
                internal Lui.Forms.Label label22;
                internal Lui.Forms.ComboBox EntradaModoPantalla;
                internal Lui.Forms.Label label27;
                internal Lui.Forms.TextBox EntradaEmpresaEmail;
                internal Lui.Forms.Label label28;
                internal Lui.Forms.ComboBox EntradaAislacion;
                internal Lui.Forms.Label label29;
                internal Lui.Forms.ComboBox EntradaActualizaciones;
                internal Lui.Forms.Label label30;
                internal Lui.Forms.TextBox EntradaEmpresaRazonSocial;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaPVRC;
                internal Lui.Forms.Label label3;
                internal Lui.Forms.TextBox EntradaEmpresaId;
                internal Lui.Forms.Label label2;
	}
}
