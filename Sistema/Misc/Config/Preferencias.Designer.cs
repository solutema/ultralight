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

namespace Lazaro.Misc.Config
{
	public partial class Preferencias
	{
                #region Código generado por el Diseñador de Windows Forms
                internal Lui.Forms.Frame FrmGeneral;
		internal System.Windows.Forms.Label label26;
		internal Lcc.Entrada.CodigoDetalle EntradaStockDepositoPredetSuc;
		internal System.Windows.Forms.Label label11;
		internal System.Windows.Forms.Label label12;
                internal Lui.Forms.TextBox EntradaPVR;
                internal Lui.Forms.ComboBox EntradaCambiaPrecioComprob;
                internal System.Windows.Forms.Label label13;

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
		internal System.Windows.Forms.Label Label16;
		internal Lcc.Entrada.CodigoDetalle EntradaClientePredet;
		internal System.Windows.Forms.Label Label15;
		internal Lcc.Entrada.CodigoDetalle EntradaFormaPagoPredet;
		internal System.Windows.Forms.Label Label17;
		internal Lui.Forms.TextBox EntradaEmpresaNombre;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal Lui.Forms.TextBox EntradaEmpresaCuit;
		internal Lcc.Entrada.CodigoDetalle EntradaEmpresaSituacion;
		internal System.Windows.Forms.Label Label9;
		internal Lui.Forms.TextBox EntradaPVND;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal Lui.Forms.TextBox EntradaPVNC;
		internal Lui.Forms.TextBox EntradaPVABC;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label20;
		internal Lui.Forms.TextBox EntradaPV;
                internal Lui.Forms.ComboBox EntradaArticulosCodigoPredet;
                internal Lui.Forms.ComboBox EntradaStockMultideposito;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label24;
		internal Lcc.Entrada.CodigoDetalle EntradaStockDepositoPredet;
		internal System.Windows.Forms.Label Label25;
                internal Lui.Forms.ComboBox EntradaStockDecimales;
		internal Lui.Forms.Button BotonSiguiente;
		internal Lui.Forms.Frame FrmArticulos;
                internal Lui.Forms.Frame FrmComprobantes;

		private void InitializeComponent()
		{
                        this.BotonAceptar = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.EntradaEmpresaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label19 = new System.Windows.Forms.Label();
                        this.EntradaEmpresaCuit = new Lui.Forms.TextBox();
                        this.Label18 = new System.Windows.Forms.Label();
                        this.EntradaEmpresaNombre = new Lui.Forms.TextBox();
                        this.Label17 = new System.Windows.Forms.Label();
                        this.FrmGeneral = new Lui.Forms.Frame();
                        this.EntradaActualizaciones = new Lui.Forms.ComboBox();
                        this.label30 = new System.Windows.Forms.Label();
                        this.EntradaAislacion = new Lui.Forms.ComboBox();
                        this.EntradaModoPantalla = new Lui.Forms.ComboBox();
                        this.EntradaBackup = new Lui.Forms.ComboBox();
                        this.label29 = new System.Windows.Forms.Label();
                        this.EntradaEmpresaEmail = new Lui.Forms.TextBox();
                        this.label28 = new System.Windows.Forms.Label();
                        this.label27 = new System.Windows.Forms.Label();
                        this.label14 = new System.Windows.Forms.Label();
                        this.EntradaStockDecimales = new Lui.Forms.ComboBox();
                        this.Label25 = new System.Windows.Forms.Label();
                        this.Label24 = new System.Windows.Forms.Label();
                        this.EntradaStockDepositoPredet = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaStockMultideposito = new Lui.Forms.ComboBox();
                        this.Label23 = new System.Windows.Forms.Label();
                        this.EntradaArticulosCodigoPredet = new Lui.Forms.ComboBox();
                        this.Label20 = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.EntradaPVND = new Lui.Forms.TextBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaPVNC = new Lui.Forms.TextBox();
                        this.EntradaPVABC = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.EntradaClientePredet = new Lcc.Entrada.CodigoDetalle();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.EntradaFormaPagoPredet = new Lcc.Entrada.CodigoDetalle();
                        this.BotonSiguiente = new Lui.Forms.Button();
                        this.FrmArticulos = new Lui.Forms.Frame();
                        this.label26 = new System.Windows.Forms.Label();
                        this.EntradaStockDepositoPredetSuc = new Lcc.Entrada.CodigoDetalle();
                        this.FrmComprobantes = new Lui.Forms.Frame();
                        this.EntradaRedondeo = new Lui.Forms.TextBox();
                        this.label22 = new System.Windows.Forms.Label();
                        this.EntradaLimiteCredito = new Lui.Forms.TextBox();
                        this.label21 = new System.Windows.Forms.Label();
                        this.EntradaCambiaPrecioComprob = new Lui.Forms.ComboBox();
                        this.label13 = new System.Windows.Forms.Label();
                        this.label11 = new System.Windows.Forms.Label();
                        this.EntradaPVR = new Lui.Forms.TextBox();
                        this.label12 = new System.Windows.Forms.Label();
                        this.EntradaEmpresaRazonSocial = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.FrmGeneral.SuspendLayout();
                        this.FrmArticulos.SuspendLayout();
                        this.FrmComprobantes.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // BotonAceptar
                        // 
                        this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAceptar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAceptar.Image = null;
                        this.BotonAceptar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAceptar.Location = new System.Drawing.Point(444, 405);
                        this.BotonAceptar.Name = "BotonAceptar";
                        this.BotonAceptar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAceptar.Size = new System.Drawing.Size(88, 32);
                        this.BotonAceptar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAceptar.Subtext = "F9";
                        this.BotonAceptar.TabIndex = 6;
                        this.BotonAceptar.Text = "Guardar";
                        this.BotonAceptar.ToolTipText = "";
                        this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(536, 405);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.Size = new System.Drawing.Size(88, 32);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 7;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.ToolTipText = "";
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
                        this.EntradaEmpresaSituacion.ExtraDetailFields = null;
                        this.EntradaEmpresaSituacion.Filter = "";
                        this.EntradaEmpresaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEmpresaSituacion.FreeTextCode = "";
                        this.EntradaEmpresaSituacion.Location = new System.Drawing.Point(180, 120);
                        this.EntradaEmpresaSituacion.MaxLength = 200;
                        this.EntradaEmpresaSituacion.Name = "EntradaEmpresaSituacion";
                        this.EntradaEmpresaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaSituacion.Required = true;
                        this.EntradaEmpresaSituacion.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaSituacion.TabIndex = 6;
                        this.EntradaEmpresaSituacion.Table = "situaciones";
                        this.EntradaEmpresaSituacion.Text = "0";
                        this.EntradaEmpresaSituacion.TextDetail = "";
                        this.EntradaEmpresaSituacion.TipWhenBlank = "";
                        this.EntradaEmpresaSituacion.ToolTipText = "";
                        // 
                        // Label19
                        // 
                        this.Label19.Location = new System.Drawing.Point(16, 120);
                        this.Label19.Name = "Label19";
                        this.Label19.Size = new System.Drawing.Size(160, 24);
                        this.Label19.TabIndex = 5;
                        this.Label19.Text = "Condición IVA";
                        this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaCuit
                        // 
                        this.EntradaEmpresaCuit.AutoNav = true;
                        this.EntradaEmpresaCuit.AutoTab = true;
                        this.EntradaEmpresaCuit.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaCuit.DecimalPlaces = -1;
                        this.EntradaEmpresaCuit.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaCuit.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmpresaCuit.Location = new System.Drawing.Point(180, 92);
                        this.EntradaEmpresaCuit.MaxLenght = 32767;
                        this.EntradaEmpresaCuit.MultiLine = false;
                        this.EntradaEmpresaCuit.Name = "EntradaEmpresaCuit";
                        this.EntradaEmpresaCuit.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaCuit.PasswordChar = '\0';
                        this.EntradaEmpresaCuit.Prefijo = "";
                        this.EntradaEmpresaCuit.SelectOnFocus = true;
                        this.EntradaEmpresaCuit.Size = new System.Drawing.Size(112, 24);
                        this.EntradaEmpresaCuit.Sufijo = "";
                        this.EntradaEmpresaCuit.TabIndex = 4;
                        this.EntradaEmpresaCuit.TipWhenBlank = "";
                        this.EntradaEmpresaCuit.ToolTipText = "";
                        // 
                        // Label18
                        // 
                        this.Label18.Location = new System.Drawing.Point(16, 92);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(160, 24);
                        this.Label18.TabIndex = 3;
                        this.Label18.Text = "CUIT";
                        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaNombre
                        // 
                        this.EntradaEmpresaNombre.AutoNav = true;
                        this.EntradaEmpresaNombre.AutoTab = true;
                        this.EntradaEmpresaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaNombre.DecimalPlaces = -1;
                        this.EntradaEmpresaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmpresaNombre.Location = new System.Drawing.Point(180, 36);
                        this.EntradaEmpresaNombre.MaxLenght = 32767;
                        this.EntradaEmpresaNombre.MultiLine = false;
                        this.EntradaEmpresaNombre.Name = "EntradaEmpresaNombre";
                        this.EntradaEmpresaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaNombre.PasswordChar = '\0';
                        this.EntradaEmpresaNombre.Prefijo = "";
                        this.EntradaEmpresaNombre.SelectOnFocus = true;
                        this.EntradaEmpresaNombre.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaNombre.Sufijo = "";
                        this.EntradaEmpresaNombre.TabIndex = 1;
                        this.EntradaEmpresaNombre.TipWhenBlank = "";
                        this.EntradaEmpresaNombre.ToolTipText = "";
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
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaRazonSocial);
                        this.FrmGeneral.Controls.Add(this.label1);
                        this.FrmGeneral.Controls.Add(this.EntradaActualizaciones);
                        this.FrmGeneral.Controls.Add(this.label30);
                        this.FrmGeneral.Controls.Add(this.EntradaAislacion);
                        this.FrmGeneral.Controls.Add(this.EntradaModoPantalla);
                        this.FrmGeneral.Controls.Add(this.EntradaBackup);
                        this.FrmGeneral.Controls.Add(this.label29);
                        this.FrmGeneral.Controls.Add(this.label27);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaEmail);
                        this.FrmGeneral.Controls.Add(this.label28);
                        this.FrmGeneral.Controls.Add(this.label14);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaCuit);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaSituacion);
                        this.FrmGeneral.Controls.Add(this.Label19);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaNombre);
                        this.FrmGeneral.Controls.Add(this.Label18);
                        this.FrmGeneral.Controls.Add(this.Label17);
                        this.FrmGeneral.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmGeneral.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmGeneral.Location = new System.Drawing.Point(8, 8);
                        this.FrmGeneral.Name = "FrmGeneral";
                        this.FrmGeneral.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmGeneral.Size = new System.Drawing.Size(620, 385);
                        this.FrmGeneral.TabIndex = 0;
                        this.FrmGeneral.Text = "Generalidades";
                        this.FrmGeneral.ToolTipText = "";
                        // 
                        // EntradaActualizaciones
                        // 
                        this.EntradaActualizaciones.AlwaysExpanded = false;
                        this.EntradaActualizaciones.AutoNav = true;
                        this.EntradaActualizaciones.AutoTab = true;
                        this.EntradaActualizaciones.DetailField = null;
                        this.EntradaActualizaciones.Filter = null;
                        this.EntradaActualizaciones.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaActualizaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaActualizaciones.KeyField = null;
                        this.EntradaActualizaciones.Location = new System.Drawing.Point(248, 332);
                        this.EntradaActualizaciones.MaxLenght = 32767;
                        this.EntradaActualizaciones.Name = "EntradaActualizaciones";
                        this.EntradaActualizaciones.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaActualizaciones.SetData = new string[] {
        "Estables|stable",
        "Preliminares|gama",
        "En prueba|beta"};
                        this.EntradaActualizaciones.Size = new System.Drawing.Size(132, 24);
                        this.EntradaActualizaciones.TabIndex = 16;
                        this.EntradaActualizaciones.Table = null;
                        this.EntradaActualizaciones.TextKey = "stable";
                        this.EntradaActualizaciones.TipWhenBlank = "";
                        this.EntradaActualizaciones.ToolTipText = "";
                        // 
                        // label30
                        // 
                        this.label30.Location = new System.Drawing.Point(16, 332);
                        this.label30.Name = "label30";
                        this.label30.Size = new System.Drawing.Size(232, 24);
                        this.label30.TabIndex = 15;
                        this.label30.Text = "Recibir actualizaciones";
                        this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAislacion
                        // 
                        this.EntradaAislacion.AlwaysExpanded = false;
                        this.EntradaAislacion.AutoNav = true;
                        this.EntradaAislacion.AutoTab = true;
                        this.EntradaAislacion.DetailField = null;
                        this.EntradaAislacion.Filter = null;
                        this.EntradaAislacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaAislacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaAislacion.KeyField = null;
                        this.EntradaAislacion.Location = new System.Drawing.Point(248, 300);
                        this.EntradaAislacion.MaxLenght = 32767;
                        this.EntradaAislacion.Name = "EntradaAislacion";
                        this.EntradaAislacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAislacion.SetData = new string[] {
        "Mejor concurrencia|RepeatableRead",
        "Mejor consitencia|Serializable"};
                        this.EntradaAislacion.Size = new System.Drawing.Size(196, 24);
                        this.EntradaAislacion.TabIndex = 14;
                        this.EntradaAislacion.Table = null;
                        this.EntradaAislacion.TextKey = "Serializable";
                        this.EntradaAislacion.TipWhenBlank = "";
                        this.EntradaAislacion.ToolTipText = "";
                        // 
                        // EntradaModoPantalla
                        // 
                        this.EntradaModoPantalla.AlwaysExpanded = false;
                        this.EntradaModoPantalla.AutoNav = true;
                        this.EntradaModoPantalla.AutoTab = true;
                        this.EntradaModoPantalla.DetailField = null;
                        this.EntradaModoPantalla.Filter = null;
                        this.EntradaModoPantalla.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaModoPantalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaModoPantalla.KeyField = null;
                        this.EntradaModoPantalla.Location = new System.Drawing.Point(248, 268);
                        this.EntradaModoPantalla.MaxLenght = 32767;
                        this.EntradaModoPantalla.Name = "EntradaModoPantalla";
                        this.EntradaModoPantalla.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModoPantalla.SetData = new string[] {
        "Predeterminado|*",
        "Ventana Normal|normal",
        "Ventana Maximizada|maximizado",
        "Pantalla Completa|completo",
        "Ventanas Flotantes|flotante"};
                        this.EntradaModoPantalla.Size = new System.Drawing.Size(196, 24);
                        this.EntradaModoPantalla.TabIndex = 12;
                        this.EntradaModoPantalla.Table = null;
                        this.EntradaModoPantalla.TextKey = "maximizado";
                        this.EntradaModoPantalla.TipWhenBlank = "";
                        this.EntradaModoPantalla.ToolTipText = "";
                        // 
                        // EntradaBackup
                        // 
                        this.EntradaBackup.AlwaysExpanded = false;
                        this.EntradaBackup.AutoNav = true;
                        this.EntradaBackup.AutoTab = true;
                        this.EntradaBackup.DetailField = null;
                        this.EntradaBackup.Filter = null;
                        this.EntradaBackup.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaBackup.KeyField = null;
                        this.EntradaBackup.Location = new System.Drawing.Point(248, 236);
                        this.EntradaBackup.MaxLenght = 32767;
                        this.EntradaBackup.Name = "EntradaBackup";
                        this.EntradaBackup.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBackup.SetData = new string[] {
        "Nunca|0",
        "Cuando se solicita|1",
        "Automáticamente|2"};
                        this.EntradaBackup.Size = new System.Drawing.Size(196, 24);
                        this.EntradaBackup.TabIndex = 10;
                        this.EntradaBackup.Table = null;
                        this.EntradaBackup.TextKey = "0";
                        this.EntradaBackup.TipWhenBlank = "";
                        this.EntradaBackup.ToolTipText = "";
                        // 
                        // label29
                        // 
                        this.label29.Location = new System.Drawing.Point(16, 300);
                        this.label29.Name = "label29";
                        this.label29.Size = new System.Drawing.Size(232, 24);
                        this.label29.TabIndex = 13;
                        this.label29.Text = "Nivel de aislamiento de clientes";
                        this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaEmail
                        // 
                        this.EntradaEmpresaEmail.AutoNav = true;
                        this.EntradaEmpresaEmail.AutoTab = true;
                        this.EntradaEmpresaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaEmail.DecimalPlaces = -1;
                        this.EntradaEmpresaEmail.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaEmail.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmpresaEmail.Location = new System.Drawing.Point(180, 148);
                        this.EntradaEmpresaEmail.MaxLenght = 32767;
                        this.EntradaEmpresaEmail.MultiLine = false;
                        this.EntradaEmpresaEmail.Name = "EntradaEmpresaEmail";
                        this.EntradaEmpresaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaEmail.PasswordChar = '\0';
                        this.EntradaEmpresaEmail.Prefijo = "";
                        this.EntradaEmpresaEmail.SelectOnFocus = true;
                        this.EntradaEmpresaEmail.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaEmail.Sufijo = "";
                        this.EntradaEmpresaEmail.TabIndex = 8;
                        this.EntradaEmpresaEmail.TipWhenBlank = "";
                        this.EntradaEmpresaEmail.ToolTipText = "";
                        // 
                        // label28
                        // 
                        this.label28.Location = new System.Drawing.Point(16, 148);
                        this.label28.Name = "label28";
                        this.label28.Size = new System.Drawing.Size(160, 24);
                        this.label28.TabIndex = 7;
                        this.label28.Text = "Correo Electrónico";
                        this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label27
                        // 
                        this.label27.Location = new System.Drawing.Point(16, 268);
                        this.label27.Name = "label27";
                        this.label27.Size = new System.Drawing.Size(232, 24);
                        this.label27.TabIndex = 11;
                        this.label27.Text = "Modo de uso de la pantalla";
                        this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label14
                        // 
                        this.label14.Location = new System.Drawing.Point(16, 236);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(232, 24);
                        this.label14.TabIndex = 9;
                        this.label14.Text = "Realizar copias de respaldo";
                        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockDecimales
                        // 
                        this.EntradaStockDecimales.AlwaysExpanded = false;
                        this.EntradaStockDecimales.AutoNav = true;
                        this.EntradaStockDecimales.AutoTab = true;
                        this.EntradaStockDecimales.DetailField = null;
                        this.EntradaStockDecimales.Filter = null;
                        this.EntradaStockDecimales.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockDecimales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockDecimales.KeyField = null;
                        this.EntradaStockDecimales.Location = new System.Drawing.Point(192, 92);
                        this.EntradaStockDecimales.MaxLenght = 32767;
                        this.EntradaStockDecimales.Name = "EntradaStockDecimales";
                        this.EntradaStockDecimales.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDecimales.SetData = new string[] {
        "Sin decimales|0",
        "Un decimal|1",
        "Dos decimales|2",
        "Tres decimales|3",
        "Cuatro decimales|4"};
                        this.EntradaStockDecimales.Size = new System.Drawing.Size(160, 24);
                        this.EntradaStockDecimales.TabIndex = 5;
                        this.EntradaStockDecimales.Table = null;
                        this.EntradaStockDecimales.TextKey = "0";
                        this.EntradaStockDecimales.TipWhenBlank = "";
                        this.EntradaStockDecimales.ToolTipText = "";
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
                        this.EntradaStockDepositoPredet.ExtraDetailFields = null;
                        this.EntradaStockDepositoPredet.Filter = "";
                        this.EntradaStockDepositoPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockDepositoPredet.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaStockDepositoPredet.FreeTextCode = "";
                        this.EntradaStockDepositoPredet.Location = new System.Drawing.Point(192, 120);
                        this.EntradaStockDepositoPredet.MaxLength = 200;
                        this.EntradaStockDepositoPredet.Name = "EntradaStockDepositoPredet";
                        this.EntradaStockDepositoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDepositoPredet.Required = false;
                        this.EntradaStockDepositoPredet.Size = new System.Drawing.Size(416, 24);
                        this.EntradaStockDepositoPredet.TabIndex = 7;
                        this.EntradaStockDepositoPredet.Table = "articulos_situaciones";
                        this.EntradaStockDepositoPredet.Text = "0";
                        this.EntradaStockDepositoPredet.TextDetail = "";
                        this.EntradaStockDepositoPredet.TipWhenBlank = "";
                        this.EntradaStockDepositoPredet.ToolTipText = "";
                        // 
                        // EntradaStockMultideposito
                        // 
                        this.EntradaStockMultideposito.AlwaysExpanded = false;
                        this.EntradaStockMultideposito.AutoNav = true;
                        this.EntradaStockMultideposito.AutoTab = true;
                        this.EntradaStockMultideposito.DetailField = null;
                        this.EntradaStockMultideposito.Filter = null;
                        this.EntradaStockMultideposito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockMultideposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaStockMultideposito.KeyField = null;
                        this.EntradaStockMultideposito.Location = new System.Drawing.Point(192, 64);
                        this.EntradaStockMultideposito.MaxLenght = 32767;
                        this.EntradaStockMultideposito.Name = "EntradaStockMultideposito";
                        this.EntradaStockMultideposito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMultideposito.SetData = new string[] {
        "Estándar|0",
        "Multidepósito|1"};
                        this.EntradaStockMultideposito.Size = new System.Drawing.Size(224, 24);
                        this.EntradaStockMultideposito.TabIndex = 3;
                        this.EntradaStockMultideposito.Table = null;
                        this.EntradaStockMultideposito.TextKey = "0";
                        this.EntradaStockMultideposito.TipWhenBlank = "";
                        this.EntradaStockMultideposito.ToolTipText = "";
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
                        this.EntradaArticulosCodigoPredet.DetailField = null;
                        this.EntradaArticulosCodigoPredet.Filter = null;
                        this.EntradaArticulosCodigoPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaArticulosCodigoPredet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaArticulosCodigoPredet.KeyField = null;
                        this.EntradaArticulosCodigoPredet.Location = new System.Drawing.Point(192, 36);
                        this.EntradaArticulosCodigoPredet.MaxLenght = 32767;
                        this.EntradaArticulosCodigoPredet.Name = "EntradaArticulosCodigoPredet";
                        this.EntradaArticulosCodigoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaArticulosCodigoPredet.SetData = new string[] {
        "Autonumérico incorporado|0",
        "Cód. 1|1",
        "Cód. 2|2",
        "Cód. 3|3",
        "Cód. 4|4"};
                        this.EntradaArticulosCodigoPredet.Size = new System.Drawing.Size(224, 24);
                        this.EntradaArticulosCodigoPredet.TabIndex = 1;
                        this.EntradaArticulosCodigoPredet.Table = null;
                        this.EntradaArticulosCodigoPredet.TextKey = "0";
                        this.EntradaArticulosCodigoPredet.TipWhenBlank = "";
                        this.EntradaArticulosCodigoPredet.ToolTipText = "";
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
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(248, 100);
                        this.EntradaPV.MaxLenght = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 5;
                        this.EntradaPV.Text = "0";
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        // 
                        // Label9
                        // 
                        this.Label9.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label9.Location = new System.Drawing.Point(308, 184);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(264, 24);
                        this.Label9.TabIndex = 14;
                        this.Label9.Text = "(0 para utilizar el mismo que para comprob)";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVND
                        // 
                        this.EntradaPVND.AutoNav = true;
                        this.EntradaPVND.AutoTab = true;
                        this.EntradaPVND.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVND.DecimalPlaces = -1;
                        this.EntradaPVND.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPVND.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPVND.Location = new System.Drawing.Point(248, 184);
                        this.EntradaPVND.MaxLenght = 32767;
                        this.EntradaPVND.MultiLine = false;
                        this.EntradaPVND.Name = "EntradaPVND";
                        this.EntradaPVND.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVND.PasswordChar = '\0';
                        this.EntradaPVND.Prefijo = "";
                        this.EntradaPVND.SelectOnFocus = true;
                        this.EntradaPVND.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVND.Sufijo = "";
                        this.EntradaPVND.TabIndex = 13;
                        this.EntradaPVND.Text = "0";
                        this.EntradaPVND.TipWhenBlank = "";
                        this.EntradaPVND.ToolTipText = "";
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
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(308, 156);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(264, 24);
                        this.Label8.TabIndex = 11;
                        this.Label8.Text = "(0 para utilizar el mismo que para comprob)";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                        this.EntradaPVNC.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPVNC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPVNC.Location = new System.Drawing.Point(248, 156);
                        this.EntradaPVNC.MaxLenght = 32767;
                        this.EntradaPVNC.MultiLine = false;
                        this.EntradaPVNC.Name = "EntradaPVNC";
                        this.EntradaPVNC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVNC.PasswordChar = '\0';
                        this.EntradaPVNC.Prefijo = "";
                        this.EntradaPVNC.SelectOnFocus = true;
                        this.EntradaPVNC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVNC.Sufijo = "";
                        this.EntradaPVNC.TabIndex = 10;
                        this.EntradaPVNC.Text = "0";
                        this.EntradaPVNC.TipWhenBlank = "";
                        this.EntradaPVNC.ToolTipText = "";
                        // 
                        // EntradaPVABC
                        // 
                        this.EntradaPVABC.AutoNav = true;
                        this.EntradaPVABC.AutoTab = true;
                        this.EntradaPVABC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVABC.DecimalPlaces = -1;
                        this.EntradaPVABC.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPVABC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVABC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPVABC.Location = new System.Drawing.Point(248, 128);
                        this.EntradaPVABC.MaxLenght = 32767;
                        this.EntradaPVABC.MultiLine = false;
                        this.EntradaPVABC.Name = "EntradaPVABC";
                        this.EntradaPVABC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVABC.PasswordChar = '\0';
                        this.EntradaPVABC.Prefijo = "";
                        this.EntradaPVABC.SelectOnFocus = true;
                        this.EntradaPVABC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVABC.Sufijo = "";
                        this.EntradaPVABC.TabIndex = 7;
                        this.EntradaPVABC.Text = "0";
                        this.EntradaPVABC.TipWhenBlank = "";
                        this.EntradaPVABC.ToolTipText = "";
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
                        this.EntradaClientePredet.ExtraDetailFields = null;
                        this.EntradaClientePredet.Filter = "";
                        this.EntradaClientePredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaClientePredet.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaClientePredet.FreeTextCode = "";
                        this.EntradaClientePredet.Location = new System.Drawing.Point(184, 36);
                        this.EntradaClientePredet.MaxLength = 200;
                        this.EntradaClientePredet.Name = "EntradaClientePredet";
                        this.EntradaClientePredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaClientePredet.Required = false;
                        this.EntradaClientePredet.Size = new System.Drawing.Size(428, 24);
                        this.EntradaClientePredet.TabIndex = 0;
                        this.EntradaClientePredet.Table = "personas";
                        this.EntradaClientePredet.Text = "0";
                        this.EntradaClientePredet.TextDetail = "";
                        this.EntradaClientePredet.TipWhenBlank = "Ninguno";
                        this.EntradaClientePredet.ToolTipText = "";
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
                        this.EntradaFormaPagoPredet.ExtraDetailFields = null;
                        this.EntradaFormaPagoPredet.Filter = "estado=1";
                        this.EntradaFormaPagoPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFormaPagoPredet.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFormaPagoPredet.FreeTextCode = "";
                        this.EntradaFormaPagoPredet.Location = new System.Drawing.Point(184, 64);
                        this.EntradaFormaPagoPredet.MaxLength = 200;
                        this.EntradaFormaPagoPredet.Name = "EntradaFormaPagoPredet";
                        this.EntradaFormaPagoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPagoPredet.Required = false;
                        this.EntradaFormaPagoPredet.Size = new System.Drawing.Size(280, 24);
                        this.EntradaFormaPagoPredet.TabIndex = 3;
                        this.EntradaFormaPagoPredet.Table = "formaspago";
                        this.EntradaFormaPagoPredet.Text = "0";
                        this.EntradaFormaPagoPredet.TextDetail = "";
                        this.EntradaFormaPagoPredet.TipWhenBlank = "Ninguna";
                        this.EntradaFormaPagoPredet.ToolTipText = "";
                        // 
                        // BotonSiguiente
                        // 
                        this.BotonSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSiguiente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonSiguiente.Image = null;
                        this.BotonSiguiente.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSiguiente.Location = new System.Drawing.Point(8, 405);
                        this.BotonSiguiente.Name = "BotonSiguiente";
                        this.BotonSiguiente.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSiguiente.Size = new System.Drawing.Size(96, 32);
                        this.BotonSiguiente.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSiguiente.Subtext = "F9";
                        this.BotonSiguiente.TabIndex = 5;
                        this.BotonSiguiente.Text = "Más...";
                        this.BotonSiguiente.ToolTipText = "";
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
                        this.FrmArticulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmArticulos.Location = new System.Drawing.Point(8, 8);
                        this.FrmArticulos.Name = "FrmArticulos";
                        this.FrmArticulos.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmArticulos.Size = new System.Drawing.Size(620, 385);
                        this.FrmArticulos.TabIndex = 0;
                        this.FrmArticulos.TabStop = false;
                        this.FrmArticulos.Text = "Artículos";
                        this.FrmArticulos.ToolTipText = "";
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
                        this.EntradaStockDepositoPredetSuc.ExtraDetailFields = null;
                        this.EntradaStockDepositoPredetSuc.Filter = "";
                        this.EntradaStockDepositoPredetSuc.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaStockDepositoPredetSuc.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaStockDepositoPredetSuc.FreeTextCode = "";
                        this.EntradaStockDepositoPredetSuc.Location = new System.Drawing.Point(192, 148);
                        this.EntradaStockDepositoPredetSuc.MaxLength = 200;
                        this.EntradaStockDepositoPredetSuc.Name = "EntradaStockDepositoPredetSuc";
                        this.EntradaStockDepositoPredetSuc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDepositoPredetSuc.Required = false;
                        this.EntradaStockDepositoPredetSuc.Size = new System.Drawing.Size(416, 24);
                        this.EntradaStockDepositoPredetSuc.TabIndex = 9;
                        this.EntradaStockDepositoPredetSuc.Table = "articulos_situaciones";
                        this.EntradaStockDepositoPredetSuc.Text = "0";
                        this.EntradaStockDepositoPredetSuc.TextDetail = "";
                        this.EntradaStockDepositoPredetSuc.TipWhenBlank = "";
                        this.EntradaStockDepositoPredetSuc.ToolTipText = "";
                        // 
                        // FrmComprobantes
                        // 
                        this.FrmComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmComprobantes.Controls.Add(this.EntradaRedondeo);
                        this.FrmComprobantes.Controls.Add(this.label22);
                        this.FrmComprobantes.Controls.Add(this.EntradaLimiteCredito);
                        this.FrmComprobantes.Controls.Add(this.label21);
                        this.FrmComprobantes.Controls.Add(this.EntradaCambiaPrecioComprob);
                        this.FrmComprobantes.Controls.Add(this.label13);
                        this.FrmComprobantes.Controls.Add(this.label11);
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
                        this.FrmComprobantes.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmComprobantes.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmComprobantes.Location = new System.Drawing.Point(8, 8);
                        this.FrmComprobantes.Name = "FrmComprobantes";
                        this.FrmComprobantes.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmComprobantes.Size = new System.Drawing.Size(620, 385);
                        this.FrmComprobantes.TabIndex = 0;
                        this.FrmComprobantes.TabStop = false;
                        this.FrmComprobantes.Text = "Comprobantes";
                        this.FrmComprobantes.ToolTipText = "";
                        this.FrmComprobantes.Visible = false;
                        // 
                        // EntradaRedondeo
                        // 
                        this.EntradaRedondeo.AutoNav = true;
                        this.EntradaRedondeo.AutoTab = true;
                        this.EntradaRedondeo.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaRedondeo.DecimalPlaces = -1;
                        this.EntradaRedondeo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaRedondeo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaRedondeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaRedondeo.Location = new System.Drawing.Point(248, 316);
                        this.EntradaRedondeo.MaxLenght = 32767;
                        this.EntradaRedondeo.MultiLine = false;
                        this.EntradaRedondeo.Name = "EntradaRedondeo";
                        this.EntradaRedondeo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRedondeo.PasswordChar = '\0';
                        this.EntradaRedondeo.Prefijo = "$";
                        this.EntradaRedondeo.SelectOnFocus = true;
                        this.EntradaRedondeo.Size = new System.Drawing.Size(92, 24);
                        this.EntradaRedondeo.Sufijo = "";
                        this.EntradaRedondeo.TabIndex = 23;
                        this.EntradaRedondeo.Text = "0.00";
                        this.EntradaRedondeo.TipWhenBlank = "";
                        this.EntradaRedondeo.ToolTipText = "";
                        // 
                        // label22
                        // 
                        this.label22.Location = new System.Drawing.Point(12, 316);
                        this.label22.Name = "label22";
                        this.label22.Size = new System.Drawing.Size(236, 24);
                        this.label22.TabIndex = 22;
                        this.label22.Text = "Redondeo en comprobantes";
                        this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.AutoNav = true;
                        this.EntradaLimiteCredito.AutoTab = true;
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaLimiteCredito.DecimalPlaces = -1;
                        this.EntradaLimiteCredito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaLimiteCredito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaLimiteCredito.Location = new System.Drawing.Point(248, 284);
                        this.EntradaLimiteCredito.MaxLenght = 32767;
                        this.EntradaLimiteCredito.MultiLine = false;
                        this.EntradaLimiteCredito.Name = "EntradaLimiteCredito";
                        this.EntradaLimiteCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLimiteCredito.PasswordChar = '\0';
                        this.EntradaLimiteCredito.Prefijo = "$";
                        this.EntradaLimiteCredito.SelectOnFocus = true;
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(124, 24);
                        this.EntradaLimiteCredito.Sufijo = "";
                        this.EntradaLimiteCredito.TabIndex = 21;
                        this.EntradaLimiteCredito.Text = "0.00";
                        this.EntradaLimiteCredito.TipWhenBlank = "";
                        this.EntradaLimiteCredito.ToolTipText = "";
                        // 
                        // label21
                        // 
                        this.label21.Location = new System.Drawing.Point(12, 284);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(236, 24);
                        this.label21.TabIndex = 20;
                        this.label21.Text = "Límite de crédito predeterminado";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCambiaPrecioComprob
                        // 
                        this.EntradaCambiaPrecioComprob.AlwaysExpanded = false;
                        this.EntradaCambiaPrecioComprob.AutoNav = true;
                        this.EntradaCambiaPrecioComprob.AutoTab = true;
                        this.EntradaCambiaPrecioComprob.DetailField = null;
                        this.EntradaCambiaPrecioComprob.Filter = null;
                        this.EntradaCambiaPrecioComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCambiaPrecioComprob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCambiaPrecioComprob.KeyField = null;
                        this.EntradaCambiaPrecioComprob.Location = new System.Drawing.Point(420, 248);
                        this.EntradaCambiaPrecioComprob.MaxLenght = 32767;
                        this.EntradaCambiaPrecioComprob.Name = "EntradaCambiaPrecioComprob";
                        this.EntradaCambiaPrecioComprob.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCambiaPrecioComprob.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaCambiaPrecioComprob.Size = new System.Drawing.Size(64, 24);
                        this.EntradaCambiaPrecioComprob.TabIndex = 19;
                        this.EntradaCambiaPrecioComprob.Table = null;
                        this.EntradaCambiaPrecioComprob.TextKey = "1";
                        this.EntradaCambiaPrecioComprob.TipWhenBlank = "";
                        this.EntradaCambiaPrecioComprob.ToolTipText = "";
                        // 
                        // label13
                        // 
                        this.label13.Location = new System.Drawing.Point(12, 248);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(408, 24);
                        this.label13.TabIndex = 18;
                        this.label13.Text = "Permite cambiar precio del artículo durante la facturación";
                        this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label11
                        // 
                        this.label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label11.Location = new System.Drawing.Point(308, 212);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(264, 24);
                        this.label11.TabIndex = 17;
                        this.label11.Text = "(0 para utilizar el mismo que para comprob)";
                        this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVR
                        // 
                        this.EntradaPVR.AutoNav = true;
                        this.EntradaPVR.AutoTab = true;
                        this.EntradaPVR.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVR.DecimalPlaces = -1;
                        this.EntradaPVR.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPVR.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPVR.Location = new System.Drawing.Point(248, 212);
                        this.EntradaPVR.MaxLenght = 32767;
                        this.EntradaPVR.MultiLine = false;
                        this.EntradaPVR.Name = "EntradaPVR";
                        this.EntradaPVR.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVR.PasswordChar = '\0';
                        this.EntradaPVR.Prefijo = "";
                        this.EntradaPVR.SelectOnFocus = true;
                        this.EntradaPVR.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVR.Sufijo = "";
                        this.EntradaPVR.TabIndex = 16;
                        this.EntradaPVR.Text = "0";
                        this.EntradaPVR.TipWhenBlank = "";
                        this.EntradaPVR.ToolTipText = "";
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
                        // EntradaEmpresaRazonSocial
                        // 
                        this.EntradaEmpresaRazonSocial.AutoNav = true;
                        this.EntradaEmpresaRazonSocial.AutoTab = true;
                        this.EntradaEmpresaRazonSocial.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaRazonSocial.DecimalPlaces = -1;
                        this.EntradaEmpresaRazonSocial.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaRazonSocial.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmpresaRazonSocial.Location = new System.Drawing.Point(180, 64);
                        this.EntradaEmpresaRazonSocial.MaxLenght = 32767;
                        this.EntradaEmpresaRazonSocial.MultiLine = false;
                        this.EntradaEmpresaRazonSocial.Name = "EntradaEmpresaRazonSocial";
                        this.EntradaEmpresaRazonSocial.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaRazonSocial.PasswordChar = '\0';
                        this.EntradaEmpresaRazonSocial.Prefijo = "";
                        this.EntradaEmpresaRazonSocial.SelectOnFocus = true;
                        this.EntradaEmpresaRazonSocial.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaRazonSocial.Sufijo = "";
                        this.EntradaEmpresaRazonSocial.TabIndex = 2;
                        this.EntradaEmpresaRazonSocial.TipWhenBlank = "";
                        this.EntradaEmpresaRazonSocial.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(16, 64);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(160, 24);
                        this.label1.TabIndex = 1;
                        this.label1.Text = "Razón Social";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
                internal System.Windows.Forms.Label label14;
                internal Lui.Forms.TextBox EntradaLimiteCredito;
                internal System.Windows.Forms.Label label21;
                internal Lui.Forms.TextBox EntradaRedondeo;
                internal System.Windows.Forms.Label label22;
                internal Lui.Forms.ComboBox EntradaModoPantalla;
                internal System.Windows.Forms.Label label27;
                internal Lui.Forms.TextBox EntradaEmpresaEmail;
                internal System.Windows.Forms.Label label28;
                internal Lui.Forms.ComboBox EntradaAislacion;
                internal System.Windows.Forms.Label label29;
                internal Lui.Forms.ComboBox EntradaActualizaciones;
                internal System.Windows.Forms.Label label30;
                internal Lui.Forms.TextBox EntradaEmpresaRazonSocial;
                internal System.Windows.Forms.Label label1;
	}
}