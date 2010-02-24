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

namespace Lazaro.Misc.Config
{
	public partial class Preferencias
	{
                #region Código generado por el Diseñador de Windows Forms
                internal Lui.Forms.Frame FrmGeneral;
		internal System.Windows.Forms.Label label26;
		internal Lui.Forms.DetailBox txtStockDepositoPredetSuc;
		internal System.Windows.Forms.Label label11;
		internal System.Windows.Forms.Label label12;
                internal Lui.Forms.TextBox txtPVR;
                internal Lui.Forms.ComboBox txtCambiaPrecioComprob;
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
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal Lui.Forms.Button cmdOk;
		internal Lui.Forms.Button CancelCommandButton;
                internal Lui.Forms.ListView lvImpresionComprob;
		internal System.Windows.Forms.ColumnHeader comprob;
		internal System.Windows.Forms.ColumnHeader impresora;
		internal System.Windows.Forms.ColumnHeader carga;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal Lui.Forms.TextBox txtImpresionPredetComprobante;
		internal Lui.Forms.TextBox txtImpresionPredetImpresora;
                internal Lui.Forms.ComboBox txtImpresionPredetCarga;
		internal Lui.Forms.Button txtImpresionPredetImpresoraBrowse;
		internal System.Windows.Forms.Label Label16;
		internal Lui.Forms.DetailBox txtClientePredet;
		internal System.Windows.Forms.Label Label15;
		internal Lui.Forms.DetailBox txtFormaPagoPredet;
		internal System.Windows.Forms.Label Label17;
		internal Lui.Forms.TextBox EntradaEmpresaNombre;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal Lui.Forms.TextBox EntradaEmpresaCuit;
		internal Lui.Forms.DetailBox EntradaEmpresaSituacion;
		internal System.Windows.Forms.Label Label9;
		internal Lui.Forms.TextBox txtPVND;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal Lui.Forms.TextBox txtPVNC;
		internal Lui.Forms.TextBox txtPVABC;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label20;
		internal Lui.Forms.TextBox txtPV;
                internal Lui.Forms.ComboBox txtArticulosCodigoPredet;
                internal Lui.Forms.ComboBox txtStockMultideposito;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label24;
		internal Lui.Forms.DetailBox txtStockDepositoPredet;
		internal System.Windows.Forms.Label Label25;
                internal Lui.Forms.ComboBox txtStockDecimales;
		private System.Windows.Forms.ColumnHeader nombrecomprob;
		internal Lui.Forms.Button BotonSiguiente;
		internal Lui.Forms.Frame FrmArticulos;
		internal Lui.Forms.Frame FrmComprobantes;
		internal Lui.Forms.Frame FrmImpresion;

		private void InitializeComponent()
		{
                        this.cmdOk = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.EntradaEmpresaSituacion = new Lui.Forms.DetailBox();
                        this.Label19 = new System.Windows.Forms.Label();
                        this.EntradaEmpresaCuit = new Lui.Forms.TextBox();
                        this.Label18 = new System.Windows.Forms.Label();
                        this.EntradaEmpresaNombre = new Lui.Forms.TextBox();
                        this.Label17 = new System.Windows.Forms.Label();
                        this.FrmGeneral = new Lui.Forms.Frame();
                        this.EntradaEmpresaEmail = new Lui.Forms.TextBox();
                        this.label28 = new System.Windows.Forms.Label();
                        this.EntradaModoPantalla = new Lui.Forms.ComboBox();
                        this.label27 = new System.Windows.Forms.Label();
                        this.txtBackup = new Lui.Forms.ComboBox();
                        this.label14 = new System.Windows.Forms.Label();
                        this.txtStockDecimales = new Lui.Forms.ComboBox();
                        this.Label25 = new System.Windows.Forms.Label();
                        this.Label24 = new System.Windows.Forms.Label();
                        this.txtStockDepositoPredet = new Lui.Forms.DetailBox();
                        this.txtStockMultideposito = new Lui.Forms.ComboBox();
                        this.Label23 = new System.Windows.Forms.Label();
                        this.txtArticulosCodigoPredet = new Lui.Forms.ComboBox();
                        this.Label20 = new System.Windows.Forms.Label();
                        this.txtPV = new Lui.Forms.TextBox();
                        this.Label9 = new System.Windows.Forms.Label();
                        this.txtPVND = new Lui.Forms.TextBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtPVNC = new Lui.Forms.TextBox();
                        this.txtPVABC = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.txtClientePredet = new Lui.Forms.DetailBox();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.txtFormaPagoPredet = new Lui.Forms.DetailBox();
                        this.txtImpresionPredetImpresoraBrowse = new Lui.Forms.Button();
                        this.txtImpresionPredetCarga = new Lui.Forms.ComboBox();
                        this.txtImpresionPredetImpresora = new Lui.Forms.TextBox();
                        this.txtImpresionPredetComprobante = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.lvImpresionComprob = new Lui.Forms.ListView();
                        this.comprob = new System.Windows.Forms.ColumnHeader();
                        this.nombrecomprob = new System.Windows.Forms.ColumnHeader();
                        this.impresora = new System.Windows.Forms.ColumnHeader();
                        this.carga = new System.Windows.Forms.ColumnHeader();
                        this.BotonSiguiente = new Lui.Forms.Button();
                        this.FrmArticulos = new Lui.Forms.Frame();
                        this.label26 = new System.Windows.Forms.Label();
                        this.txtStockDepositoPredetSuc = new Lui.Forms.DetailBox();
                        this.FrmComprobantes = new Lui.Forms.Frame();
                        this.txtRedondeo = new Lui.Forms.TextBox();
                        this.label22 = new System.Windows.Forms.Label();
                        this.txtLimiteCredito = new Lui.Forms.TextBox();
                        this.label21 = new System.Windows.Forms.Label();
                        this.txtCambiaPrecioComprob = new Lui.Forms.ComboBox();
                        this.label13 = new System.Windows.Forms.Label();
                        this.label11 = new System.Windows.Forms.Label();
                        this.txtPVR = new Lui.Forms.TextBox();
                        this.label12 = new System.Windows.Forms.Label();
                        this.FrmImpresion = new Lui.Forms.Frame();
                        this.FrmGeneral.SuspendLayout();
                        this.FrmArticulos.SuspendLayout();
                        this.FrmComprobantes.SuspendLayout();
                        this.FrmImpresion.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // cmdOk
                        // 
                        this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdOk.AutoHeight = false;
                        this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdOk.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdOk.Image = null;
                        this.cmdOk.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdOk.Location = new System.Drawing.Point(444, 405);
                        this.cmdOk.Name = "cmdOk";
                        this.cmdOk.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdOk.ReadOnly = false;
                        this.cmdOk.Size = new System.Drawing.Size(88, 32);
                        this.cmdOk.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdOk.Subtext = "F9";
                        this.cmdOk.TabIndex = 6;
                        this.cmdOk.Text = "Guardar";
                        this.cmdOk.ToolTipText = "";
                        this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.AutoHeight = false;
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
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
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // EntradaEmpresaSituacion
                        // 
                        this.EntradaEmpresaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmpresaSituacion.AutoHeight = false;
                        this.EntradaEmpresaSituacion.AutoTab = true;
                        this.EntradaEmpresaSituacion.CanCreate = true;
                        this.EntradaEmpresaSituacion.DetailField = "nombre";
                        this.EntradaEmpresaSituacion.ExtraDetailFields = null;
                        this.EntradaEmpresaSituacion.Filter = "";
                        this.EntradaEmpresaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEmpresaSituacion.FreeTextCode = "";
                        this.EntradaEmpresaSituacion.KeyField = "id_situacion";
                        this.EntradaEmpresaSituacion.Location = new System.Drawing.Point(180, 92);
                        this.EntradaEmpresaSituacion.MaxLength = 200;
                        this.EntradaEmpresaSituacion.Name = "EntradaEmpresaSituacion";
                        this.EntradaEmpresaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaSituacion.ReadOnly = false;
                        this.EntradaEmpresaSituacion.Required = true;
                        this.EntradaEmpresaSituacion.SelectOnFocus = true;
                        this.EntradaEmpresaSituacion.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaSituacion.TabIndex = 5;
                        this.EntradaEmpresaSituacion.Table = "situaciones";
                        this.EntradaEmpresaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaEmpresaSituacion.Text = "0";
                        this.EntradaEmpresaSituacion.TextDetail = "";
                        this.EntradaEmpresaSituacion.TextInt = 0;
                        this.EntradaEmpresaSituacion.TipWhenBlank = "";
                        this.EntradaEmpresaSituacion.ToolTipText = "";
                        // 
                        // Label19
                        // 
                        this.Label19.Location = new System.Drawing.Point(16, 92);
                        this.Label19.Name = "Label19";
                        this.Label19.Size = new System.Drawing.Size(160, 24);
                        this.Label19.TabIndex = 4;
                        this.Label19.Text = "Condición IVA";
                        this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaCuit
                        // 
                        this.EntradaEmpresaCuit.AutoHeight = false;
                        this.EntradaEmpresaCuit.AutoNav = true;
                        this.EntradaEmpresaCuit.AutoTab = true;
                        this.EntradaEmpresaCuit.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaCuit.DecimalPlaces = -1;
                        this.EntradaEmpresaCuit.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaCuit.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmpresaCuit.Location = new System.Drawing.Point(180, 64);
                        this.EntradaEmpresaCuit.MaxLenght = 32767;
                        this.EntradaEmpresaCuit.MultiLine = false;
                        this.EntradaEmpresaCuit.Name = "EntradaEmpresaCuit";
                        this.EntradaEmpresaCuit.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaCuit.PasswordChar = '\0';
                        this.EntradaEmpresaCuit.Prefijo = "";
                        this.EntradaEmpresaCuit.ReadOnly = false;
                        this.EntradaEmpresaCuit.SelectOnFocus = true;
                        this.EntradaEmpresaCuit.Size = new System.Drawing.Size(112, 24);
                        this.EntradaEmpresaCuit.Sufijo = "";
                        this.EntradaEmpresaCuit.TabIndex = 3;
                        this.EntradaEmpresaCuit.TextRaw = "";
                        this.EntradaEmpresaCuit.TipWhenBlank = "";
                        this.EntradaEmpresaCuit.ToolTipText = "";
                        // 
                        // Label18
                        // 
                        this.Label18.Location = new System.Drawing.Point(16, 64);
                        this.Label18.Name = "Label18";
                        this.Label18.Size = new System.Drawing.Size(160, 24);
                        this.Label18.TabIndex = 2;
                        this.Label18.Text = "CUIT";
                        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaNombre
                        // 
                        this.EntradaEmpresaNombre.AutoHeight = false;
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
                        this.EntradaEmpresaNombre.ReadOnly = false;
                        this.EntradaEmpresaNombre.SelectOnFocus = true;
                        this.EntradaEmpresaNombre.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaNombre.Sufijo = "";
                        this.EntradaEmpresaNombre.TabIndex = 1;
                        this.EntradaEmpresaNombre.TextRaw = "";
                        this.EntradaEmpresaNombre.TipWhenBlank = "";
                        this.EntradaEmpresaNombre.ToolTipText = "";
                        // 
                        // Label17
                        // 
                        this.Label17.Location = new System.Drawing.Point(16, 36);
                        this.Label17.Name = "Label17";
                        this.Label17.Size = new System.Drawing.Size(160, 24);
                        this.Label17.TabIndex = 0;
                        this.Label17.Text = "Nombre o Razón Social";
                        this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FrmGeneral
                        // 
                        this.FrmGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmGeneral.AutoHeight = false;
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaEmail);
                        this.FrmGeneral.Controls.Add(this.label28);
                        this.FrmGeneral.Controls.Add(this.EntradaModoPantalla);
                        this.FrmGeneral.Controls.Add(this.label27);
                        this.FrmGeneral.Controls.Add(this.txtBackup);
                        this.FrmGeneral.Controls.Add(this.label14);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaSituacion);
                        this.FrmGeneral.Controls.Add(this.Label19);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaCuit);
                        this.FrmGeneral.Controls.Add(this.Label18);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaNombre);
                        this.FrmGeneral.Controls.Add(this.Label17);
                        this.FrmGeneral.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmGeneral.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmGeneral.Location = new System.Drawing.Point(8, 8);
                        this.FrmGeneral.Name = "FrmGeneral";
                        this.FrmGeneral.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmGeneral.ReadOnly = false;
                        this.FrmGeneral.Size = new System.Drawing.Size(620, 385);
                        this.FrmGeneral.TabIndex = 0;
                        this.FrmGeneral.Text = "Generalidades";
                        this.FrmGeneral.ToolTipText = "";
                        // 
                        // EntradaEmpresaEmail
                        // 
                        this.EntradaEmpresaEmail.AutoHeight = false;
                        this.EntradaEmpresaEmail.AutoNav = true;
                        this.EntradaEmpresaEmail.AutoTab = true;
                        this.EntradaEmpresaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaEmail.DecimalPlaces = -1;
                        this.EntradaEmpresaEmail.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEmpresaEmail.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEmpresaEmail.Location = new System.Drawing.Point(180, 120);
                        this.EntradaEmpresaEmail.MaxLenght = 32767;
                        this.EntradaEmpresaEmail.MultiLine = false;
                        this.EntradaEmpresaEmail.Name = "EntradaEmpresaEmail";
                        this.EntradaEmpresaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaEmail.PasswordChar = '\0';
                        this.EntradaEmpresaEmail.Prefijo = "";
                        this.EntradaEmpresaEmail.ReadOnly = false;
                        this.EntradaEmpresaEmail.SelectOnFocus = true;
                        this.EntradaEmpresaEmail.Size = new System.Drawing.Size(388, 24);
                        this.EntradaEmpresaEmail.Sufijo = "";
                        this.EntradaEmpresaEmail.TabIndex = 7;
                        this.EntradaEmpresaEmail.TextRaw = "";
                        this.EntradaEmpresaEmail.TipWhenBlank = "";
                        this.EntradaEmpresaEmail.ToolTipText = "";
                        // 
                        // label28
                        // 
                        this.label28.Location = new System.Drawing.Point(16, 120);
                        this.label28.Name = "label28";
                        this.label28.Size = new System.Drawing.Size(160, 24);
                        this.label28.TabIndex = 6;
                        this.label28.Text = "Correo Electrónico";
                        this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaModoPantalla
                        // 
                        this.EntradaModoPantalla.AutoHeight = false;
                        this.EntradaModoPantalla.AutoNav = true;
                        this.EntradaModoPantalla.AutoTab = true;
                        this.EntradaModoPantalla.DetailField = null;
                        this.EntradaModoPantalla.Filter = null;
                        this.EntradaModoPantalla.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaModoPantalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaModoPantalla.KeyField = null;
                        this.EntradaModoPantalla.Location = new System.Drawing.Point(336, 304);
                        this.EntradaModoPantalla.MaxLenght = 32767;
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
                        this.EntradaModoPantalla.TabIndex = 9;
                        this.EntradaModoPantalla.Table = null;
                        this.EntradaModoPantalla.Text = "Ventana Maximizada";
                        this.EntradaModoPantalla.TextKey = "maximizado";
                        this.EntradaModoPantalla.TextRaw = "Ventana Maximizada";
                        this.EntradaModoPantalla.TipWhenBlank = "";
                        this.EntradaModoPantalla.ToolTipText = "";
                        // 
                        // label27
                        // 
                        this.label27.Location = new System.Drawing.Point(16, 304);
                        this.label27.Name = "label27";
                        this.label27.Size = new System.Drawing.Size(324, 24);
                        this.label27.TabIndex = 8;
                        this.label27.Text = "Modo de uso de la pantalla";
                        this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtBackup
                        // 
                        this.txtBackup.AutoHeight = false;
                        this.txtBackup.AutoNav = true;
                        this.txtBackup.AutoTab = true;
                        this.txtBackup.DetailField = null;
                        this.txtBackup.Filter = null;
                        this.txtBackup.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtBackup.KeyField = null;
                        this.txtBackup.Location = new System.Drawing.Point(336, 272);
                        this.txtBackup.MaxLenght = 32767;
                        this.txtBackup.Name = "txtBackup";
                        this.txtBackup.Padding = new System.Windows.Forms.Padding(2);
                        this.txtBackup.ReadOnly = false;
                        this.txtBackup.SetData = new string[] {
        "Nunca|0",
        "Cuando se solicita|1",
        "Automáticamente|2"};
                        this.txtBackup.Size = new System.Drawing.Size(196, 24);
                        this.txtBackup.TabIndex = 7;
                        this.txtBackup.Table = null;
                        this.txtBackup.Text = "Nunca";
                        this.txtBackup.TextKey = "0";
                        this.txtBackup.TextRaw = "Nunca";
                        this.txtBackup.TipWhenBlank = "";
                        this.txtBackup.ToolTipText = "";
                        // 
                        // label14
                        // 
                        this.label14.Location = new System.Drawing.Point(16, 272);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(324, 24);
                        this.label14.TabIndex = 6;
                        this.label14.Text = "En esta estación se realizan copias de respaldo";
                        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtStockDecimales
                        // 
                        this.txtStockDecimales.AutoHeight = false;
                        this.txtStockDecimales.AutoNav = true;
                        this.txtStockDecimales.AutoTab = true;
                        this.txtStockDecimales.DetailField = null;
                        this.txtStockDecimales.Filter = null;
                        this.txtStockDecimales.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockDecimales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtStockDecimales.KeyField = null;
                        this.txtStockDecimales.Location = new System.Drawing.Point(192, 92);
                        this.txtStockDecimales.MaxLenght = 32767;
                        this.txtStockDecimales.Name = "txtStockDecimales";
                        this.txtStockDecimales.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockDecimales.ReadOnly = false;
                        this.txtStockDecimales.SetData = new string[] {
        "Sin decimales|0",
        "Un decimal|1",
        "Dos decimales|2",
        "Tres decimales|3",
        "Cuatro decimales|4"};
                        this.txtStockDecimales.Size = new System.Drawing.Size(160, 24);
                        this.txtStockDecimales.TabIndex = 5;
                        this.txtStockDecimales.Table = null;
                        this.txtStockDecimales.Text = "Sin decimales";
                        this.txtStockDecimales.TextKey = "0";
                        this.txtStockDecimales.TextRaw = "Sin decimales";
                        this.txtStockDecimales.TipWhenBlank = "";
                        this.txtStockDecimales.ToolTipText = "";
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
                        // txtStockDepositoPredet
                        // 
                        this.txtStockDepositoPredet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtStockDepositoPredet.AutoHeight = false;
                        this.txtStockDepositoPredet.AutoTab = true;
                        this.txtStockDepositoPredet.CanCreate = true;
                        this.txtStockDepositoPredet.DetailField = "nombre";
                        this.txtStockDepositoPredet.ExtraDetailFields = null;
                        this.txtStockDepositoPredet.Filter = "";
                        this.txtStockDepositoPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockDepositoPredet.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtStockDepositoPredet.FreeTextCode = "";
                        this.txtStockDepositoPredet.KeyField = "id_situacion";
                        this.txtStockDepositoPredet.Location = new System.Drawing.Point(192, 120);
                        this.txtStockDepositoPredet.MaxLength = 200;
                        this.txtStockDepositoPredet.Name = "txtStockDepositoPredet";
                        this.txtStockDepositoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockDepositoPredet.ReadOnly = false;
                        this.txtStockDepositoPredet.Required = false;
                        this.txtStockDepositoPredet.SelectOnFocus = true;
                        this.txtStockDepositoPredet.Size = new System.Drawing.Size(416, 24);
                        this.txtStockDepositoPredet.TabIndex = 7;
                        this.txtStockDepositoPredet.Table = "articulos_situaciones";
                        this.txtStockDepositoPredet.TeclaDespuesDeEnter = "{tab}";
                        this.txtStockDepositoPredet.Text = "0";
                        this.txtStockDepositoPredet.TextDetail = "";
                        this.txtStockDepositoPredet.TextInt = 0;
                        this.txtStockDepositoPredet.TipWhenBlank = "";
                        this.txtStockDepositoPredet.ToolTipText = "";
                        // 
                        // txtStockMultideposito
                        // 
                        this.txtStockMultideposito.AutoHeight = false;
                        this.txtStockMultideposito.AutoNav = true;
                        this.txtStockMultideposito.AutoTab = true;
                        this.txtStockMultideposito.DetailField = null;
                        this.txtStockMultideposito.Filter = null;
                        this.txtStockMultideposito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockMultideposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtStockMultideposito.KeyField = null;
                        this.txtStockMultideposito.Location = new System.Drawing.Point(192, 64);
                        this.txtStockMultideposito.MaxLenght = 32767;
                        this.txtStockMultideposito.Name = "txtStockMultideposito";
                        this.txtStockMultideposito.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockMultideposito.ReadOnly = false;
                        this.txtStockMultideposito.SetData = new string[] {
        "Estándar|0",
        "Multidepósito|1"};
                        this.txtStockMultideposito.Size = new System.Drawing.Size(224, 24);
                        this.txtStockMultideposito.TabIndex = 3;
                        this.txtStockMultideposito.Table = null;
                        this.txtStockMultideposito.Text = "Estándar";
                        this.txtStockMultideposito.TextKey = "0";
                        this.txtStockMultideposito.TextRaw = "Estándar";
                        this.txtStockMultideposito.TipWhenBlank = "";
                        this.txtStockMultideposito.ToolTipText = "";
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
                        // txtArticulosCodigoPredet
                        // 
                        this.txtArticulosCodigoPredet.AutoHeight = false;
                        this.txtArticulosCodigoPredet.AutoNav = true;
                        this.txtArticulosCodigoPredet.AutoTab = true;
                        this.txtArticulosCodigoPredet.DetailField = null;
                        this.txtArticulosCodigoPredet.Filter = null;
                        this.txtArticulosCodigoPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtArticulosCodigoPredet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtArticulosCodigoPredet.KeyField = null;
                        this.txtArticulosCodigoPredet.Location = new System.Drawing.Point(192, 36);
                        this.txtArticulosCodigoPredet.MaxLenght = 32767;
                        this.txtArticulosCodigoPredet.Name = "txtArticulosCodigoPredet";
                        this.txtArticulosCodigoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.txtArticulosCodigoPredet.ReadOnly = false;
                        this.txtArticulosCodigoPredet.SetData = new string[] {
        "Autonumérico incorporado|0",
        "Cód. 1|1",
        "Cód. 2|2",
        "Cód. 3|3",
        "Cód. 4|4"};
                        this.txtArticulosCodigoPredet.Size = new System.Drawing.Size(224, 24);
                        this.txtArticulosCodigoPredet.TabIndex = 1;
                        this.txtArticulosCodigoPredet.Table = null;
                        this.txtArticulosCodigoPredet.Text = "Autonumérico incorporado";
                        this.txtArticulosCodigoPredet.TextKey = "0";
                        this.txtArticulosCodigoPredet.TextRaw = "Autonumérico incorporado";
                        this.txtArticulosCodigoPredet.TipWhenBlank = "";
                        this.txtArticulosCodigoPredet.ToolTipText = "";
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
                        // txtPV
                        // 
                        this.txtPV.AutoHeight = false;
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPV.DecimalPlaces = -1;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPV.Location = new System.Drawing.Point(248, 100);
                        this.txtPV.MaxLenght = 32767;
                        this.txtPV.MultiLine = false;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPV.PasswordChar = '\0';
                        this.txtPV.Prefijo = "";
                        this.txtPV.ReadOnly = false;
                        this.txtPV.SelectOnFocus = true;
                        this.txtPV.Size = new System.Drawing.Size(56, 24);
                        this.txtPV.Sufijo = "";
                        this.txtPV.TabIndex = 5;
                        this.txtPV.Text = "0";
                        this.txtPV.TextRaw = "0";
                        this.txtPV.TipWhenBlank = "";
                        this.txtPV.ToolTipText = "";
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
                        // txtPVND
                        // 
                        this.txtPVND.AutoHeight = false;
                        this.txtPVND.AutoNav = true;
                        this.txtPVND.AutoTab = true;
                        this.txtPVND.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPVND.DecimalPlaces = -1;
                        this.txtPVND.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPVND.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPVND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPVND.Location = new System.Drawing.Point(248, 184);
                        this.txtPVND.MaxLenght = 32767;
                        this.txtPVND.MultiLine = false;
                        this.txtPVND.Name = "txtPVND";
                        this.txtPVND.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPVND.PasswordChar = '\0';
                        this.txtPVND.Prefijo = "";
                        this.txtPVND.ReadOnly = false;
                        this.txtPVND.SelectOnFocus = true;
                        this.txtPVND.Size = new System.Drawing.Size(56, 24);
                        this.txtPVND.Sufijo = "";
                        this.txtPVND.TabIndex = 13;
                        this.txtPVND.Text = "0";
                        this.txtPVND.TextRaw = "0";
                        this.txtPVND.TipWhenBlank = "";
                        this.txtPVND.ToolTipText = "";
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
                        // txtPVNC
                        // 
                        this.txtPVNC.AutoHeight = false;
                        this.txtPVNC.AutoNav = true;
                        this.txtPVNC.AutoTab = true;
                        this.txtPVNC.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPVNC.DecimalPlaces = -1;
                        this.txtPVNC.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPVNC.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPVNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPVNC.Location = new System.Drawing.Point(248, 156);
                        this.txtPVNC.MaxLenght = 32767;
                        this.txtPVNC.MultiLine = false;
                        this.txtPVNC.Name = "txtPVNC";
                        this.txtPVNC.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPVNC.PasswordChar = '\0';
                        this.txtPVNC.Prefijo = "";
                        this.txtPVNC.ReadOnly = false;
                        this.txtPVNC.SelectOnFocus = true;
                        this.txtPVNC.Size = new System.Drawing.Size(56, 24);
                        this.txtPVNC.Sufijo = "";
                        this.txtPVNC.TabIndex = 10;
                        this.txtPVNC.Text = "0";
                        this.txtPVNC.TextRaw = "0";
                        this.txtPVNC.TipWhenBlank = "";
                        this.txtPVNC.ToolTipText = "";
                        // 
                        // txtPVABC
                        // 
                        this.txtPVABC.AutoHeight = false;
                        this.txtPVABC.AutoNav = true;
                        this.txtPVABC.AutoTab = true;
                        this.txtPVABC.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPVABC.DecimalPlaces = -1;
                        this.txtPVABC.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPVABC.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPVABC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPVABC.Location = new System.Drawing.Point(248, 128);
                        this.txtPVABC.MaxLenght = 32767;
                        this.txtPVABC.MultiLine = false;
                        this.txtPVABC.Name = "txtPVABC";
                        this.txtPVABC.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPVABC.PasswordChar = '\0';
                        this.txtPVABC.Prefijo = "";
                        this.txtPVABC.ReadOnly = false;
                        this.txtPVABC.SelectOnFocus = true;
                        this.txtPVABC.Size = new System.Drawing.Size(56, 24);
                        this.txtPVABC.Sufijo = "";
                        this.txtPVABC.TabIndex = 7;
                        this.txtPVABC.Text = "0";
                        this.txtPVABC.TextRaw = "0";
                        this.txtPVABC.TipWhenBlank = "";
                        this.txtPVABC.ToolTipText = "";
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
                        // txtClientePredet
                        // 
                        this.txtClientePredet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtClientePredet.AutoHeight = false;
                        this.txtClientePredet.AutoTab = true;
                        this.txtClientePredet.CanCreate = true;
                        this.txtClientePredet.DetailField = "nombre_visible";
                        this.txtClientePredet.ExtraDetailFields = null;
                        this.txtClientePredet.Filter = "";
                        this.txtClientePredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtClientePredet.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtClientePredet.FreeTextCode = "";
                        this.txtClientePredet.KeyField = "id_persona";
                        this.txtClientePredet.Location = new System.Drawing.Point(184, 36);
                        this.txtClientePredet.MaxLength = 200;
                        this.txtClientePredet.Name = "txtClientePredet";
                        this.txtClientePredet.Padding = new System.Windows.Forms.Padding(2);
                        this.txtClientePredet.ReadOnly = false;
                        this.txtClientePredet.Required = false;
                        this.txtClientePredet.SelectOnFocus = true;
                        this.txtClientePredet.Size = new System.Drawing.Size(428, 24);
                        this.txtClientePredet.TabIndex = 1;
                        this.txtClientePredet.Table = "personas";
                        this.txtClientePredet.TeclaDespuesDeEnter = "{tab}";
                        this.txtClientePredet.Text = "0";
                        this.txtClientePredet.TextDetail = "";
                        this.txtClientePredet.TextInt = 0;
                        this.txtClientePredet.TipWhenBlank = "";
                        this.txtClientePredet.ToolTipText = "";
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
                        // txtFormaPagoPredet
                        // 
                        this.txtFormaPagoPredet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtFormaPagoPredet.AutoHeight = false;
                        this.txtFormaPagoPredet.AutoTab = true;
                        this.txtFormaPagoPredet.CanCreate = true;
                        this.txtFormaPagoPredet.DetailField = "nombre";
                        this.txtFormaPagoPredet.ExtraDetailFields = null;
                        this.txtFormaPagoPredet.Filter = "estado=1";
                        this.txtFormaPagoPredet.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFormaPagoPredet.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFormaPagoPredet.FreeTextCode = "";
                        this.txtFormaPagoPredet.KeyField = "id_formapago";
                        this.txtFormaPagoPredet.Location = new System.Drawing.Point(184, 64);
                        this.txtFormaPagoPredet.MaxLength = 200;
                        this.txtFormaPagoPredet.Name = "txtFormaPagoPredet";
                        this.txtFormaPagoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFormaPagoPredet.ReadOnly = false;
                        this.txtFormaPagoPredet.Required = false;
                        this.txtFormaPagoPredet.SelectOnFocus = true;
                        this.txtFormaPagoPredet.Size = new System.Drawing.Size(280, 24);
                        this.txtFormaPagoPredet.TabIndex = 3;
                        this.txtFormaPagoPredet.Table = "formaspago";
                        this.txtFormaPagoPredet.TeclaDespuesDeEnter = "{tab}";
                        this.txtFormaPagoPredet.Text = "0";
                        this.txtFormaPagoPredet.TextDetail = "";
                        this.txtFormaPagoPredet.TextInt = 0;
                        this.txtFormaPagoPredet.TipWhenBlank = "";
                        this.txtFormaPagoPredet.ToolTipText = "";
                        // 
                        // txtImpresionPredetImpresoraBrowse
                        // 
                        this.txtImpresionPredetImpresoraBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtImpresionPredetImpresoraBrowse.AutoHeight = false;
                        this.txtImpresionPredetImpresoraBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.txtImpresionPredetImpresoraBrowse.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpresionPredetImpresoraBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtImpresionPredetImpresoraBrowse.Image = null;
                        this.txtImpresionPredetImpresoraBrowse.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.txtImpresionPredetImpresoraBrowse.Location = new System.Drawing.Point(500, 319);
                        this.txtImpresionPredetImpresoraBrowse.Name = "txtImpresionPredetImpresoraBrowse";
                        this.txtImpresionPredetImpresoraBrowse.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImpresionPredetImpresoraBrowse.ReadOnly = false;
                        this.txtImpresionPredetImpresoraBrowse.Size = new System.Drawing.Size(108, 24);
                        this.txtImpresionPredetImpresoraBrowse.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.txtImpresionPredetImpresoraBrowse.Subtext = "Tecla";
                        this.txtImpresionPredetImpresoraBrowse.TabIndex = 5;
                        this.txtImpresionPredetImpresoraBrowse.Text = "Seleccionar";
                        this.txtImpresionPredetImpresoraBrowse.ToolTipText = "";
                        this.txtImpresionPredetImpresoraBrowse.Click += new System.EventHandler(this.cmdImpresionPredetImpresoraBrowse_Click);
                        // 
                        // txtImpresionPredetCarga
                        // 
                        this.txtImpresionPredetCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtImpresionPredetCarga.AutoHeight = false;
                        this.txtImpresionPredetCarga.AutoNav = true;
                        this.txtImpresionPredetCarga.AutoTab = true;
                        this.txtImpresionPredetCarga.DetailField = null;
                        this.txtImpresionPredetCarga.Filter = null;
                        this.txtImpresionPredetCarga.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpresionPredetCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImpresionPredetCarga.KeyField = null;
                        this.txtImpresionPredetCarga.Location = new System.Drawing.Point(204, 348);
                        this.txtImpresionPredetCarga.MaxLenght = 32767;
                        this.txtImpresionPredetCarga.Name = "txtImpresionPredetCarga";
                        this.txtImpresionPredetCarga.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImpresionPredetCarga.ReadOnly = false;
                        this.txtImpresionPredetCarga.SetData = new string[] {
        "Automática|auto",
        "Manual|manual",
        "(Sin especificar)|(Sin especificar)"};
                        this.txtImpresionPredetCarga.Size = new System.Drawing.Size(204, 24);
                        this.txtImpresionPredetCarga.TabIndex = 7;
                        this.txtImpresionPredetCarga.Table = null;
                        this.txtImpresionPredetCarga.Text = "Automática";
                        this.txtImpresionPredetCarga.TextKey = "auto";
                        this.txtImpresionPredetCarga.TextRaw = "Automática";
                        this.txtImpresionPredetCarga.TipWhenBlank = "";
                        this.txtImpresionPredetCarga.ToolTipText = "";
                        this.txtImpresionPredetCarga.TextChanged += new System.EventHandler(this.txtImpresionPredetCarga_TextChanged);
                        // 
                        // txtImpresionPredetImpresora
                        // 
                        this.txtImpresionPredetImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtImpresionPredetImpresora.AutoHeight = false;
                        this.txtImpresionPredetImpresora.AutoNav = true;
                        this.txtImpresionPredetImpresora.AutoTab = true;
                        this.txtImpresionPredetImpresora.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtImpresionPredetImpresora.DecimalPlaces = -1;
                        this.txtImpresionPredetImpresora.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpresionPredetImpresora.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtImpresionPredetImpresora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImpresionPredetImpresora.Location = new System.Drawing.Point(204, 320);
                        this.txtImpresionPredetImpresora.MaxLenght = 32767;
                        this.txtImpresionPredetImpresora.MultiLine = false;
                        this.txtImpresionPredetImpresora.Name = "txtImpresionPredetImpresora";
                        this.txtImpresionPredetImpresora.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImpresionPredetImpresora.PasswordChar = '\0';
                        this.txtImpresionPredetImpresora.Prefijo = "";
                        this.txtImpresionPredetImpresora.ReadOnly = false;
                        this.txtImpresionPredetImpresora.SelectOnFocus = true;
                        this.txtImpresionPredetImpresora.Size = new System.Drawing.Size(292, 24);
                        this.txtImpresionPredetImpresora.Sufijo = "";
                        this.txtImpresionPredetImpresora.TabIndex = 4;
                        this.txtImpresionPredetImpresora.TabStop = false;
                        this.txtImpresionPredetImpresora.TextRaw = "";
                        this.txtImpresionPredetImpresora.TipWhenBlank = "";
                        this.txtImpresionPredetImpresora.ToolTipText = "";
                        this.txtImpresionPredetImpresora.TextChanged += new System.EventHandler(this.txtImpresionPredetImpresora_TextChanged);
                        // 
                        // txtImpresionPredetComprobante
                        // 
                        this.txtImpresionPredetComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtImpresionPredetComprobante.AutoHeight = false;
                        this.txtImpresionPredetComprobante.AutoNav = true;
                        this.txtImpresionPredetComprobante.AutoTab = true;
                        this.txtImpresionPredetComprobante.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtImpresionPredetComprobante.DecimalPlaces = -1;
                        this.txtImpresionPredetComprobante.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpresionPredetComprobante.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtImpresionPredetComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImpresionPredetComprobante.Location = new System.Drawing.Point(204, 292);
                        this.txtImpresionPredetComprobante.MaxLenght = 32767;
                        this.txtImpresionPredetComprobante.MultiLine = false;
                        this.txtImpresionPredetComprobante.Name = "txtImpresionPredetComprobante";
                        this.txtImpresionPredetComprobante.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImpresionPredetComprobante.PasswordChar = '\0';
                        this.txtImpresionPredetComprobante.Prefijo = "";
                        this.txtImpresionPredetComprobante.ReadOnly = true;
                        this.txtImpresionPredetComprobante.SelectOnFocus = true;
                        this.txtImpresionPredetComprobante.Size = new System.Drawing.Size(404, 24);
                        this.txtImpresionPredetComprobante.Sufijo = "";
                        this.txtImpresionPredetComprobante.TabIndex = 2;
                        this.txtImpresionPredetComprobante.TabStop = false;
                        this.txtImpresionPredetComprobante.TextRaw = "";
                        this.txtImpresionPredetComprobante.TipWhenBlank = "";
                        this.txtImpresionPredetComprobante.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label3.Location = new System.Drawing.Point(16, 348);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(188, 24);
                        this.Label3.TabIndex = 6;
                        this.Label3.Text = "Carga de Papel";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label2.Location = new System.Drawing.Point(16, 320);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(188, 24);
                        this.Label2.TabIndex = 3;
                        this.Label2.Text = "Impresora Predeterminada";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label1.Location = new System.Drawing.Point(16, 292);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(188, 24);
                        this.Label1.TabIndex = 1;
                        this.Label1.Text = "Comprobante";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lvImpresionComprob
                        // 
                        this.lvImpresionComprob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvImpresionComprob.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvImpresionComprob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.comprob,
            this.nombrecomprob,
            this.impresora,
            this.carga});
                        this.lvImpresionComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lvImpresionComprob.FullRowSelect = true;
                        this.lvImpresionComprob.GridLines = true;
                        this.lvImpresionComprob.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvImpresionComprob.HideSelection = false;
                        this.lvImpresionComprob.Location = new System.Drawing.Point(12, 36);
                        this.lvImpresionComprob.MultiSelect = false;
                        this.lvImpresionComprob.Name = "lvImpresionComprob";
                        this.lvImpresionComprob.Size = new System.Drawing.Size(596, 244);
                        this.lvImpresionComprob.TabIndex = 0;
                        this.lvImpresionComprob.UseCompatibleStateImageBehavior = false;
                        this.lvImpresionComprob.View = System.Windows.Forms.View.Details;
                        this.lvImpresionComprob.SelectedIndexChanged += new System.EventHandler(this.lvImpresionComprob_SelectedIndexChanged);
                        this.lvImpresionComprob.DoubleClick += new System.EventHandler(this.lvImpresionComprob_DoubleClick);
                        // 
                        // comprob
                        // 
                        this.comprob.Text = "TipoComprobante";
                        this.comprob.Width = 0;
                        // 
                        // nombrecomprob
                        // 
                        this.nombrecomprob.Text = "Comprobante";
                        this.nombrecomprob.Width = 180;
                        // 
                        // impresora
                        // 
                        this.impresora.Text = "Impresora";
                        this.impresora.Width = 250;
                        // 
                        // carga
                        // 
                        this.carga.Text = "Carga";
                        this.carga.Width = 160;
                        // 
                        // BotonSiguiente
                        // 
                        this.BotonSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonSiguiente.AutoHeight = false;
                        this.BotonSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSiguiente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
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
                        this.BotonSiguiente.ToolTipText = "";
                        this.BotonSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
                        // 
                        // FrmArticulos
                        // 
                        this.FrmArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmArticulos.AutoHeight = false;
                        this.FrmArticulos.Controls.Add(this.label26);
                        this.FrmArticulos.Controls.Add(this.txtStockDepositoPredetSuc);
                        this.FrmArticulos.Controls.Add(this.txtStockDecimales);
                        this.FrmArticulos.Controls.Add(this.Label25);
                        this.FrmArticulos.Controls.Add(this.Label24);
                        this.FrmArticulos.Controls.Add(this.txtStockDepositoPredet);
                        this.FrmArticulos.Controls.Add(this.txtStockMultideposito);
                        this.FrmArticulos.Controls.Add(this.Label23);
                        this.FrmArticulos.Controls.Add(this.txtArticulosCodigoPredet);
                        this.FrmArticulos.Controls.Add(this.Label20);
                        this.FrmArticulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmArticulos.Location = new System.Drawing.Point(8, 8);
                        this.FrmArticulos.Name = "FrmArticulos";
                        this.FrmArticulos.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmArticulos.ReadOnly = false;
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
                        // txtStockDepositoPredetSuc
                        // 
                        this.txtStockDepositoPredetSuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtStockDepositoPredetSuc.AutoHeight = false;
                        this.txtStockDepositoPredetSuc.AutoTab = true;
                        this.txtStockDepositoPredetSuc.CanCreate = true;
                        this.txtStockDepositoPredetSuc.DetailField = "nombre";
                        this.txtStockDepositoPredetSuc.ExtraDetailFields = null;
                        this.txtStockDepositoPredetSuc.Filter = "";
                        this.txtStockDepositoPredetSuc.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockDepositoPredetSuc.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtStockDepositoPredetSuc.FreeTextCode = "";
                        this.txtStockDepositoPredetSuc.KeyField = "id_situacion";
                        this.txtStockDepositoPredetSuc.Location = new System.Drawing.Point(192, 148);
                        this.txtStockDepositoPredetSuc.MaxLength = 200;
                        this.txtStockDepositoPredetSuc.Name = "txtStockDepositoPredetSuc";
                        this.txtStockDepositoPredetSuc.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockDepositoPredetSuc.ReadOnly = false;
                        this.txtStockDepositoPredetSuc.Required = false;
                        this.txtStockDepositoPredetSuc.SelectOnFocus = true;
                        this.txtStockDepositoPredetSuc.Size = new System.Drawing.Size(416, 24);
                        this.txtStockDepositoPredetSuc.TabIndex = 9;
                        this.txtStockDepositoPredetSuc.Table = "articulos_situaciones";
                        this.txtStockDepositoPredetSuc.TeclaDespuesDeEnter = "{tab}";
                        this.txtStockDepositoPredetSuc.Text = "0";
                        this.txtStockDepositoPredetSuc.TextDetail = "";
                        this.txtStockDepositoPredetSuc.TextInt = 0;
                        this.txtStockDepositoPredetSuc.TipWhenBlank = "";
                        this.txtStockDepositoPredetSuc.ToolTipText = "";
                        // 
                        // FrmComprobantes
                        // 
                        this.FrmComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmComprobantes.AutoHeight = false;
                        this.FrmComprobantes.Controls.Add(this.txtRedondeo);
                        this.FrmComprobantes.Controls.Add(this.label22);
                        this.FrmComprobantes.Controls.Add(this.txtLimiteCredito);
                        this.FrmComprobantes.Controls.Add(this.label21);
                        this.FrmComprobantes.Controls.Add(this.txtCambiaPrecioComprob);
                        this.FrmComprobantes.Controls.Add(this.label13);
                        this.FrmComprobantes.Controls.Add(this.label11);
                        this.FrmComprobantes.Controls.Add(this.txtPVR);
                        this.FrmComprobantes.Controls.Add(this.label12);
                        this.FrmComprobantes.Controls.Add(this.txtPV);
                        this.FrmComprobantes.Controls.Add(this.Label9);
                        this.FrmComprobantes.Controls.Add(this.txtPVND);
                        this.FrmComprobantes.Controls.Add(this.Label10);
                        this.FrmComprobantes.Controls.Add(this.Label8);
                        this.FrmComprobantes.Controls.Add(this.Label7);
                        this.FrmComprobantes.Controls.Add(this.txtPVNC);
                        this.FrmComprobantes.Controls.Add(this.txtPVABC);
                        this.FrmComprobantes.Controls.Add(this.Label6);
                        this.FrmComprobantes.Controls.Add(this.Label5);
                        this.FrmComprobantes.Controls.Add(this.Label4);
                        this.FrmComprobantes.Controls.Add(this.Label16);
                        this.FrmComprobantes.Controls.Add(this.txtClientePredet);
                        this.FrmComprobantes.Controls.Add(this.Label15);
                        this.FrmComprobantes.Controls.Add(this.txtFormaPagoPredet);
                        this.FrmComprobantes.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmComprobantes.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmComprobantes.Location = new System.Drawing.Point(8, 8);
                        this.FrmComprobantes.Name = "FrmComprobantes";
                        this.FrmComprobantes.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmComprobantes.ReadOnly = false;
                        this.FrmComprobantes.Size = new System.Drawing.Size(620, 385);
                        this.FrmComprobantes.TabIndex = 0;
                        this.FrmComprobantes.TabStop = false;
                        this.FrmComprobantes.Text = "Comprobantes";
                        this.FrmComprobantes.ToolTipText = "";
                        this.FrmComprobantes.Visible = false;
                        // 
                        // txtRedondeo
                        // 
                        this.txtRedondeo.AutoHeight = false;
                        this.txtRedondeo.AutoNav = true;
                        this.txtRedondeo.AutoTab = true;
                        this.txtRedondeo.DataType = Lui.Forms.DataTypes.Money;
                        this.txtRedondeo.DecimalPlaces = -1;
                        this.txtRedondeo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtRedondeo.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtRedondeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtRedondeo.Location = new System.Drawing.Point(248, 316);
                        this.txtRedondeo.MaxLenght = 32767;
                        this.txtRedondeo.MultiLine = false;
                        this.txtRedondeo.Name = "txtRedondeo";
                        this.txtRedondeo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtRedondeo.PasswordChar = '\0';
                        this.txtRedondeo.Prefijo = "$";
                        this.txtRedondeo.ReadOnly = false;
                        this.txtRedondeo.SelectOnFocus = true;
                        this.txtRedondeo.Size = new System.Drawing.Size(92, 24);
                        this.txtRedondeo.Sufijo = "";
                        this.txtRedondeo.TabIndex = 23;
                        this.txtRedondeo.Text = "0.00";
                        this.txtRedondeo.TextRaw = "0.00";
                        this.txtRedondeo.TipWhenBlank = "";
                        this.txtRedondeo.ToolTipText = "";
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
                        // txtLimiteCredito
                        // 
                        this.txtLimiteCredito.AutoHeight = false;
                        this.txtLimiteCredito.AutoNav = true;
                        this.txtLimiteCredito.AutoTab = true;
                        this.txtLimiteCredito.DataType = Lui.Forms.DataTypes.Money;
                        this.txtLimiteCredito.DecimalPlaces = -1;
                        this.txtLimiteCredito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtLimiteCredito.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtLimiteCredito.Location = new System.Drawing.Point(248, 284);
                        this.txtLimiteCredito.MaxLenght = 32767;
                        this.txtLimiteCredito.MultiLine = false;
                        this.txtLimiteCredito.Name = "txtLimiteCredito";
                        this.txtLimiteCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.txtLimiteCredito.PasswordChar = '\0';
                        this.txtLimiteCredito.Prefijo = "$";
                        this.txtLimiteCredito.ReadOnly = false;
                        this.txtLimiteCredito.SelectOnFocus = true;
                        this.txtLimiteCredito.Size = new System.Drawing.Size(124, 24);
                        this.txtLimiteCredito.Sufijo = "";
                        this.txtLimiteCredito.TabIndex = 21;
                        this.txtLimiteCredito.Text = "0.00";
                        this.txtLimiteCredito.TextRaw = "0.00";
                        this.txtLimiteCredito.TipWhenBlank = "";
                        this.txtLimiteCredito.ToolTipText = "";
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
                        // txtCambiaPrecioComprob
                        // 
                        this.txtCambiaPrecioComprob.AutoHeight = false;
                        this.txtCambiaPrecioComprob.AutoNav = true;
                        this.txtCambiaPrecioComprob.AutoTab = true;
                        this.txtCambiaPrecioComprob.DetailField = null;
                        this.txtCambiaPrecioComprob.Filter = null;
                        this.txtCambiaPrecioComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCambiaPrecioComprob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCambiaPrecioComprob.KeyField = null;
                        this.txtCambiaPrecioComprob.Location = new System.Drawing.Point(420, 248);
                        this.txtCambiaPrecioComprob.MaxLenght = 32767;
                        this.txtCambiaPrecioComprob.Name = "txtCambiaPrecioComprob";
                        this.txtCambiaPrecioComprob.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCambiaPrecioComprob.ReadOnly = false;
                        this.txtCambiaPrecioComprob.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.txtCambiaPrecioComprob.Size = new System.Drawing.Size(64, 24);
                        this.txtCambiaPrecioComprob.TabIndex = 19;
                        this.txtCambiaPrecioComprob.Table = null;
                        this.txtCambiaPrecioComprob.Text = "Si";
                        this.txtCambiaPrecioComprob.TextKey = "1";
                        this.txtCambiaPrecioComprob.TextRaw = "Si";
                        this.txtCambiaPrecioComprob.TipWhenBlank = "";
                        this.txtCambiaPrecioComprob.ToolTipText = "";
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
                        // txtPVR
                        // 
                        this.txtPVR.AutoHeight = false;
                        this.txtPVR.AutoNav = true;
                        this.txtPVR.AutoTab = true;
                        this.txtPVR.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtPVR.DecimalPlaces = -1;
                        this.txtPVR.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPVR.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtPVR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPVR.Location = new System.Drawing.Point(248, 212);
                        this.txtPVR.MaxLenght = 32767;
                        this.txtPVR.MultiLine = false;
                        this.txtPVR.Name = "txtPVR";
                        this.txtPVR.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPVR.PasswordChar = '\0';
                        this.txtPVR.Prefijo = "";
                        this.txtPVR.ReadOnly = false;
                        this.txtPVR.SelectOnFocus = true;
                        this.txtPVR.Size = new System.Drawing.Size(56, 24);
                        this.txtPVR.Sufijo = "";
                        this.txtPVR.TabIndex = 16;
                        this.txtPVR.Text = "0";
                        this.txtPVR.TextRaw = "0";
                        this.txtPVR.TipWhenBlank = "";
                        this.txtPVR.ToolTipText = "";
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
                        // FrmImpresion
                        // 
                        this.FrmImpresion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmImpresion.AutoHeight = false;
                        this.FrmImpresion.Controls.Add(this.lvImpresionComprob);
                        this.FrmImpresion.Controls.Add(this.txtImpresionPredetCarga);
                        this.FrmImpresion.Controls.Add(this.txtImpresionPredetImpresoraBrowse);
                        this.FrmImpresion.Controls.Add(this.txtImpresionPredetComprobante);
                        this.FrmImpresion.Controls.Add(this.txtImpresionPredetImpresora);
                        this.FrmImpresion.Controls.Add(this.Label3);
                        this.FrmImpresion.Controls.Add(this.Label2);
                        this.FrmImpresion.Controls.Add(this.Label1);
                        this.FrmImpresion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FrmImpresion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FrmImpresion.Location = new System.Drawing.Point(8, 8);
                        this.FrmImpresion.Name = "FrmImpresion";
                        this.FrmImpresion.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmImpresion.ReadOnly = false;
                        this.FrmImpresion.Size = new System.Drawing.Size(620, 385);
                        this.FrmImpresion.TabIndex = 0;
                        this.FrmImpresion.TabStop = false;
                        this.FrmImpresion.Text = "Impresión";
                        this.FrmImpresion.ToolTipText = "";
                        this.FrmImpresion.Visible = false;
                        // 
                        // Preferencias
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 448);
                        this.Controls.Add(this.BotonSiguiente);
                        this.Controls.Add(this.CancelCommandButton);
                        this.Controls.Add(this.cmdOk);
                        this.Controls.Add(this.FrmGeneral);
                        this.Controls.Add(this.FrmImpresion);
                        this.Controls.Add(this.FrmComprobantes);
                        this.Controls.Add(this.FrmArticulos);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "Preferencias";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Preferencias";
                        this.WorkspaceChanged += new System.EventHandler(this.FormConfig_WorkspaceChanged);
                        this.FrmGeneral.ResumeLayout(false);
                        this.FrmGeneral.PerformLayout();
                        this.FrmArticulos.ResumeLayout(false);
                        this.FrmArticulos.PerformLayout();
                        this.FrmComprobantes.ResumeLayout(false);
                        this.FrmComprobantes.PerformLayout();
                        this.FrmImpresion.ResumeLayout(false);
                        this.FrmImpresion.PerformLayout();
                        this.ResumeLayout(false);

		}
		#endregion

                internal Lui.Forms.ComboBox txtBackup;
                internal System.Windows.Forms.Label label14;
                internal Lui.Forms.TextBox txtLimiteCredito;
                internal System.Windows.Forms.Label label21;
                internal Lui.Forms.TextBox txtRedondeo;
                internal System.Windows.Forms.Label label22;
                internal Lui.Forms.ComboBox EntradaModoPantalla;
                internal System.Windows.Forms.Label label27;
                internal Lui.Forms.TextBox EntradaEmpresaEmail;
                internal System.Windows.Forms.Label label28;
	}
}