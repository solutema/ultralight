#region License
// Copyright 2004-2012 Ernesto N. Carrea
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


		private System.ComponentModel.IContainer components = null;

		private void InitializeComponent()
		{
                        this.BotonAceptar = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.EntradaEmpresaSituacion = new Lcc.Entrada.CodigoDetalle();
                        this.Label19 = new Lui.Forms.Label();
                        this.EntradaEmpresaClaveTributaria = new Lui.Forms.TextBox();
                        this.EtiquetaClaveTributaria = new Lui.Forms.Label();
                        this.EntradaEmpresaNombre = new Lui.Forms.TextBox();
                        this.Label17 = new Lui.Forms.Label();
                        this.FrmGeneral = new Lui.Forms.Frame();
                        this.EntradaPais = new Lcc.Entrada.CodigoDetalle();
                        this.label33 = new Lui.Forms.Label();
                        this.EntradaLocalidad = new Lcc.Entrada.CodigoDetalle();
                        this.label32 = new Lui.Forms.Label();
                        this.EntradaProvincia = new Lcc.Entrada.CodigoDetalle();
                        this.label31 = new Lui.Forms.Label();
                        this.EntradaEmpresaRazonSocial = new Lui.Forms.TextBox();
                        this.EntradaEmpresaEmail = new Lui.Forms.TextBox();
                        this.EntradaEmpresaId = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.label28 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaActualizaciones = new Lui.Forms.ComboBox();
                        this.label30 = new Lui.Forms.Label();
                        this.EntradaAislacion = new Lui.Forms.ComboBox();
                        this.EntradaModoPantalla = new Lui.Forms.ComboBox();
                        this.EntradaBackup = new Lui.Forms.ComboBox();
                        this.label29 = new Lui.Forms.Label();
                        this.label27 = new Lui.Forms.Label();
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
                        this.EntradaMonedaDecimalesCosto = new Lui.Forms.ComboBox();
                        this.label35 = new Lui.Forms.Label();
                        this.EntradaMonedaDecimalesUnitarios = new Lui.Forms.ComboBox();
                        this.label34 = new Lui.Forms.Label();
                        this.EntradaMonedaDecimalesFinal = new Lui.Forms.ComboBox();
                        this.label18 = new Lui.Forms.Label();
                        this.label26 = new Lui.Forms.Label();
                        this.EntradaStockDepositoPredetSuc = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaMonedaUnidadMonetariaMinima = new Lui.Forms.TextBox();
                        this.label22 = new Lui.Forms.Label();
                        this.FrmComprobantes = new Lui.Forms.Frame();
                        this.EntradaPVRC = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
                        this.label11 = new Lui.Forms.Label();
                        this.EntradaLimiteCredito = new Lui.Forms.TextBox();
                        this.label21 = new Lui.Forms.Label();
                        this.EntradaCambiaPrecioComprob = new Lui.Forms.YesNo();
                        this.label13 = new Lui.Forms.Label();
                        this.EntradaPVR = new Lui.Forms.TextBox();
                        this.label12 = new Lui.Forms.Label();
                        this.FrmAvanzado = new Lui.Forms.Frame();
                        this.FrmGeneral.SuspendLayout();
                        this.FrmArticulos.SuspendLayout();
                        this.FrmComprobantes.SuspendLayout();
                        this.FrmAvanzado.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // BotonAceptar
                        // 
                        this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
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
                        this.BotonAceptar.TabIndex = 50;
                        this.BotonAceptar.Text = "Guardar";
                        this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
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
                        this.CancelCommandButton.TabIndex = 51;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // EntradaEmpresaSituacion
                        // 
                        this.EntradaEmpresaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEmpresaSituacion.AutoNav = true;
                        this.EntradaEmpresaSituacion.AutoTab = true;
                        this.EntradaEmpresaSituacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmpresaSituacion.CanCreate = true;
                        this.EntradaEmpresaSituacion.DataTextField = "nombre";
                        this.EntradaEmpresaSituacion.DataValueField = "id_situacion";
                        this.EntradaEmpresaSituacion.ExtraDetailFields = "";
                        this.EntradaEmpresaSituacion.FieldName = null;
                        this.EntradaEmpresaSituacion.Filter = "";
                        this.EntradaEmpresaSituacion.FreeTextCode = "";
                        this.EntradaEmpresaSituacion.Location = new System.Drawing.Point(216, 176);
                        this.EntradaEmpresaSituacion.MaxLength = 200;
                        this.EntradaEmpresaSituacion.Name = "EntradaEmpresaSituacion";
                        this.EntradaEmpresaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaSituacion.PlaceholderText = null;
                        this.EntradaEmpresaSituacion.ReadOnly = false;
                        this.EntradaEmpresaSituacion.Required = true;
                        this.EntradaEmpresaSituacion.Size = new System.Drawing.Size(276, 24);
                        this.EntradaEmpresaSituacion.TabIndex = 9;
                        this.EntradaEmpresaSituacion.Table = "situaciones";
                        this.EntradaEmpresaSituacion.Text = "0";
                        this.EntradaEmpresaSituacion.TextDetail = "";
                        // 
                        // Label19
                        // 
                        this.Label19.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label19.Location = new System.Drawing.Point(32, 176);
                        this.Label19.Name = "Label19";
                        this.Label19.Size = new System.Drawing.Size(184, 24);
                        this.Label19.TabIndex = 8;
                        this.Label19.Text = "Condición IVA";
                        this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaClaveTributaria
                        // 
                        this.EntradaEmpresaClaveTributaria.AutoNav = true;
                        this.EntradaEmpresaClaveTributaria.AutoTab = true;
                        this.EntradaEmpresaClaveTributaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmpresaClaveTributaria.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaClaveTributaria.DecimalPlaces = -1;
                        this.EntradaEmpresaClaveTributaria.FieldName = null;
                        this.EntradaEmpresaClaveTributaria.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaClaveTributaria.Location = new System.Drawing.Point(216, 148);
                        this.EntradaEmpresaClaveTributaria.MaxLength = 50;
                        this.EntradaEmpresaClaveTributaria.MultiLine = false;
                        this.EntradaEmpresaClaveTributaria.Name = "EntradaEmpresaClaveTributaria";
                        this.EntradaEmpresaClaveTributaria.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaClaveTributaria.PasswordChar = '\0';
                        this.EntradaEmpresaClaveTributaria.PlaceholderText = null;
                        this.EntradaEmpresaClaveTributaria.Prefijo = "";
                        this.EntradaEmpresaClaveTributaria.ReadOnly = false;
                        this.EntradaEmpresaClaveTributaria.SelectOnFocus = false;
                        this.EntradaEmpresaClaveTributaria.Size = new System.Drawing.Size(172, 24);
                        this.EntradaEmpresaClaveTributaria.Sufijo = "";
                        this.EntradaEmpresaClaveTributaria.TabIndex = 7;
                        // 
                        // EtiquetaClaveTributaria
                        // 
                        this.EtiquetaClaveTributaria.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaClaveTributaria.Location = new System.Drawing.Point(32, 148);
                        this.EtiquetaClaveTributaria.Name = "EtiquetaClaveTributaria";
                        this.EtiquetaClaveTributaria.Size = new System.Drawing.Size(184, 24);
                        this.EtiquetaClaveTributaria.TabIndex = 6;
                        this.EtiquetaClaveTributaria.Text = "Clave Tributaria";
                        this.EtiquetaClaveTributaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaNombre
                        // 
                        this.EntradaEmpresaNombre.AutoNav = true;
                        this.EntradaEmpresaNombre.AutoTab = true;
                        this.EntradaEmpresaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmpresaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaNombre.DecimalPlaces = -1;
                        this.EntradaEmpresaNombre.FieldName = null;
                        this.EntradaEmpresaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaEmpresaNombre.Location = new System.Drawing.Point(216, 92);
                        this.EntradaEmpresaNombre.MaxLength = 200;
                        this.EntradaEmpresaNombre.MultiLine = false;
                        this.EntradaEmpresaNombre.Name = "EntradaEmpresaNombre";
                        this.EntradaEmpresaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaNombre.PasswordChar = '\0';
                        this.EntradaEmpresaNombre.PlaceholderText = null;
                        this.EntradaEmpresaNombre.Prefijo = "";
                        this.EntradaEmpresaNombre.ReadOnly = false;
                        this.EntradaEmpresaNombre.SelectOnFocus = false;
                        this.EntradaEmpresaNombre.Size = new System.Drawing.Size(372, 24);
                        this.EntradaEmpresaNombre.Sufijo = "";
                        this.EntradaEmpresaNombre.TabIndex = 3;
                        // 
                        // Label17
                        // 
                        this.Label17.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label17.Location = new System.Drawing.Point(32, 92);
                        this.Label17.Name = "Label17";
                        this.Label17.Size = new System.Drawing.Size(184, 24);
                        this.Label17.TabIndex = 2;
                        this.Label17.Text = "Nombre";
                        this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FrmGeneral
                        // 
                        this.FrmGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.FrmGeneral.Controls.Add(this.EntradaPais);
                        this.FrmGeneral.Controls.Add(this.label33);
                        this.FrmGeneral.Controls.Add(this.EntradaLocalidad);
                        this.FrmGeneral.Controls.Add(this.label32);
                        this.FrmGeneral.Controls.Add(this.EntradaProvincia);
                        this.FrmGeneral.Controls.Add(this.label31);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaRazonSocial);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaEmail);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaId);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaClaveTributaria);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaSituacion);
                        this.FrmGeneral.Controls.Add(this.EntradaEmpresaNombre);
                        this.FrmGeneral.Controls.Add(this.label1);
                        this.FrmGeneral.Controls.Add(this.label28);
                        this.FrmGeneral.Controls.Add(this.label2);
                        this.FrmGeneral.Controls.Add(this.Label19);
                        this.FrmGeneral.Controls.Add(this.EtiquetaClaveTributaria);
                        this.FrmGeneral.Controls.Add(this.Label17);
                        this.FrmGeneral.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FrmGeneral.Location = new System.Drawing.Point(8, 8);
                        this.FrmGeneral.Name = "FrmGeneral";
                        this.FrmGeneral.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmGeneral.ReadOnly = false;
                        this.FrmGeneral.Size = new System.Drawing.Size(620, 385);
                        this.FrmGeneral.TabIndex = 0;
                        this.FrmGeneral.Text = "Datos de la Empresa";
                        // 
                        // EntradaPais
                        // 
                        this.EntradaPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPais.AutoNav = true;
                        this.EntradaPais.AutoTab = true;
                        this.EntradaPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPais.CanCreate = false;
                        this.EntradaPais.DataTextField = "nombre";
                        this.EntradaPais.DataValueField = "id_pais";
                        this.EntradaPais.ExtraDetailFields = "";
                        this.EntradaPais.FieldName = null;
                        this.EntradaPais.Filter = "";
                        this.EntradaPais.FreeTextCode = "";
                        this.EntradaPais.Location = new System.Drawing.Point(216, 44);
                        this.EntradaPais.MaxLength = 200;
                        this.EntradaPais.Name = "EntradaPais";
                        this.EntradaPais.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPais.PlaceholderText = null;
                        this.EntradaPais.ReadOnly = false;
                        this.EntradaPais.Required = true;
                        this.EntradaPais.Size = new System.Drawing.Size(352, 24);
                        this.EntradaPais.TabIndex = 1;
                        this.EntradaPais.Table = "paises";
                        this.EntradaPais.Text = "0";
                        this.EntradaPais.TextDetail = "";
                        this.EntradaPais.TextChanged += new System.EventHandler(this.EntradaPais_TextChanged);
                        // 
                        // label33
                        // 
                        this.label33.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label33.Location = new System.Drawing.Point(32, 44);
                        this.label33.Name = "label33";
                        this.label33.Size = new System.Drawing.Size(184, 24);
                        this.label33.TabIndex = 0;
                        this.label33.Text = "País";
                        this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLocalidad
                        // 
                        this.EntradaLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaLocalidad.AutoNav = true;
                        this.EntradaLocalidad.AutoTab = true;
                        this.EntradaLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaLocalidad.CanCreate = true;
                        this.EntradaLocalidad.DataTextField = "nombre";
                        this.EntradaLocalidad.DataValueField = "id_ciudad";
                        this.EntradaLocalidad.ExtraDetailFields = "";
                        this.EntradaLocalidad.FieldName = null;
                        this.EntradaLocalidad.Filter = "id_provincia IS NOT NULL";
                        this.EntradaLocalidad.FreeTextCode = "";
                        this.EntradaLocalidad.Location = new System.Drawing.Point(216, 260);
                        this.EntradaLocalidad.MaxLength = 200;
                        this.EntradaLocalidad.Name = "EntradaLocalidad";
                        this.EntradaLocalidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLocalidad.PlaceholderText = null;
                        this.EntradaLocalidad.ReadOnly = false;
                        this.EntradaLocalidad.Required = true;
                        this.EntradaLocalidad.Size = new System.Drawing.Size(352, 24);
                        this.EntradaLocalidad.TabIndex = 15;
                        this.EntradaLocalidad.Table = "ciudades";
                        this.EntradaLocalidad.Text = "0";
                        this.EntradaLocalidad.TextDetail = "";
                        // 
                        // label32
                        // 
                        this.label32.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label32.Location = new System.Drawing.Point(32, 260);
                        this.label32.Name = "label32";
                        this.label32.Size = new System.Drawing.Size(184, 24);
                        this.label32.TabIndex = 14;
                        this.label32.Text = "Localidad o Población";
                        this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaProvincia
                        // 
                        this.EntradaProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaProvincia.AutoNav = true;
                        this.EntradaProvincia.AutoTab = true;
                        this.EntradaProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaProvincia.CanCreate = true;
                        this.EntradaProvincia.DataTextField = "nombre";
                        this.EntradaProvincia.DataValueField = "id_ciudad";
                        this.EntradaProvincia.ExtraDetailFields = "";
                        this.EntradaProvincia.FieldName = null;
                        this.EntradaProvincia.Filter = "id_provincia IS NULL";
                        this.EntradaProvincia.FreeTextCode = "";
                        this.EntradaProvincia.Location = new System.Drawing.Point(216, 232);
                        this.EntradaProvincia.MaxLength = 200;
                        this.EntradaProvincia.Name = "EntradaProvincia";
                        this.EntradaProvincia.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaProvincia.PlaceholderText = null;
                        this.EntradaProvincia.ReadOnly = false;
                        this.EntradaProvincia.Required = true;
                        this.EntradaProvincia.Size = new System.Drawing.Size(352, 24);
                        this.EntradaProvincia.TabIndex = 13;
                        this.EntradaProvincia.Table = "ciudades";
                        this.EntradaProvincia.Text = "0";
                        this.EntradaProvincia.TextDetail = "";
                        this.EntradaProvincia.TextChanged += new System.EventHandler(this.EntradaProvincia_TextChanged);
                        // 
                        // label31
                        // 
                        this.label31.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label31.Location = new System.Drawing.Point(32, 232);
                        this.label31.Name = "label31";
                        this.label31.Size = new System.Drawing.Size(184, 24);
                        this.label31.TabIndex = 12;
                        this.label31.Text = "Provincia o Estado";
                        this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEmpresaRazonSocial
                        // 
                        this.EntradaEmpresaRazonSocial.AutoNav = true;
                        this.EntradaEmpresaRazonSocial.AutoTab = true;
                        this.EntradaEmpresaRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmpresaRazonSocial.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaRazonSocial.DecimalPlaces = -1;
                        this.EntradaEmpresaRazonSocial.FieldName = null;
                        this.EntradaEmpresaRazonSocial.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaEmpresaRazonSocial.Location = new System.Drawing.Point(216, 120);
                        this.EntradaEmpresaRazonSocial.MaxLength = 200;
                        this.EntradaEmpresaRazonSocial.MultiLine = false;
                        this.EntradaEmpresaRazonSocial.Name = "EntradaEmpresaRazonSocial";
                        this.EntradaEmpresaRazonSocial.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaRazonSocial.PasswordChar = '\0';
                        this.EntradaEmpresaRazonSocial.PlaceholderText = null;
                        this.EntradaEmpresaRazonSocial.Prefijo = "";
                        this.EntradaEmpresaRazonSocial.ReadOnly = false;
                        this.EntradaEmpresaRazonSocial.SelectOnFocus = false;
                        this.EntradaEmpresaRazonSocial.Size = new System.Drawing.Size(372, 24);
                        this.EntradaEmpresaRazonSocial.Sufijo = "";
                        this.EntradaEmpresaRazonSocial.TabIndex = 5;
                        // 
                        // EntradaEmpresaEmail
                        // 
                        this.EntradaEmpresaEmail.AutoNav = true;
                        this.EntradaEmpresaEmail.AutoTab = true;
                        this.EntradaEmpresaEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmpresaEmail.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEmpresaEmail.DecimalPlaces = -1;
                        this.EntradaEmpresaEmail.FieldName = null;
                        this.EntradaEmpresaEmail.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaEmpresaEmail.Location = new System.Drawing.Point(216, 204);
                        this.EntradaEmpresaEmail.MaxLength = 200;
                        this.EntradaEmpresaEmail.MultiLine = false;
                        this.EntradaEmpresaEmail.Name = "EntradaEmpresaEmail";
                        this.EntradaEmpresaEmail.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaEmail.PasswordChar = '\0';
                        this.EntradaEmpresaEmail.PlaceholderText = null;
                        this.EntradaEmpresaEmail.Prefijo = "";
                        this.EntradaEmpresaEmail.ReadOnly = false;
                        this.EntradaEmpresaEmail.SelectOnFocus = false;
                        this.EntradaEmpresaEmail.Size = new System.Drawing.Size(372, 24);
                        this.EntradaEmpresaEmail.Sufijo = "";
                        this.EntradaEmpresaEmail.TabIndex = 11;
                        // 
                        // EntradaEmpresaId
                        // 
                        this.EntradaEmpresaId.AutoNav = true;
                        this.EntradaEmpresaId.AutoTab = true;
                        this.EntradaEmpresaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaEmpresaId.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaEmpresaId.DecimalPlaces = -1;
                        this.EntradaEmpresaId.FieldName = null;
                        this.EntradaEmpresaId.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaEmpresaId.Location = new System.Drawing.Point(216, 288);
                        this.EntradaEmpresaId.MaxLength = 3;
                        this.EntradaEmpresaId.MultiLine = false;
                        this.EntradaEmpresaId.Name = "EntradaEmpresaId";
                        this.EntradaEmpresaId.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEmpresaId.PasswordChar = '\0';
                        this.EntradaEmpresaId.PlaceholderText = null;
                        this.EntradaEmpresaId.Prefijo = "";
                        this.EntradaEmpresaId.ReadOnly = false;
                        this.EntradaEmpresaId.SelectOnFocus = false;
                        this.EntradaEmpresaId.Size = new System.Drawing.Size(48, 24);
                        this.EntradaEmpresaId.Sufijo = "";
                        this.EntradaEmpresaId.TabIndex = 17;
                        this.EntradaEmpresaId.Text = "0";
                        // 
                        // label1
                        // 
                        this.label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label1.Location = new System.Drawing.Point(32, 120);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(184, 24);
                        this.label1.TabIndex = 4;
                        this.label1.Text = "Razón social";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label28
                        // 
                        this.label28.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label28.Location = new System.Drawing.Point(32, 204);
                        this.label28.Name = "label28";
                        this.label28.Size = new System.Drawing.Size(184, 24);
                        this.label28.TabIndex = 10;
                        this.label28.Text = "Correo electrónico";
                        this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label2.Location = new System.Drawing.Point(32, 288);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(184, 24);
                        this.label2.TabIndex = 16;
                        this.label2.Text = "Id de empresa";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaActualizaciones
                        // 
                        this.EntradaActualizaciones.AlwaysExpanded = true;
                        this.EntradaActualizaciones.AutoNav = true;
                        this.EntradaActualizaciones.AutoSize = true;
                        this.EntradaActualizaciones.AutoTab = true;
                        this.EntradaActualizaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaActualizaciones.FieldName = null;
                        this.EntradaActualizaciones.Location = new System.Drawing.Point(248, 220);
                        this.EntradaActualizaciones.MaxLength = 32767;
                        this.EntradaActualizaciones.Name = "EntradaActualizaciones";
                        this.EntradaActualizaciones.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaActualizaciones.PlaceholderText = null;
                        this.EntradaActualizaciones.ReadOnly = false;
                        this.EntradaActualizaciones.SetData = new string[] {
        "Estables|stable",
        "Preliminares|gama",
        "En prueba|beta"};
                        this.EntradaActualizaciones.Size = new System.Drawing.Size(132, 51);
                        this.EntradaActualizaciones.TabIndex = 21;
                        this.EntradaActualizaciones.TextKey = "stable";
                        // 
                        // label30
                        // 
                        this.label30.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label30.Location = new System.Drawing.Point(16, 220);
                        this.label30.Name = "label30";
                        this.label30.Size = new System.Drawing.Size(232, 24);
                        this.label30.TabIndex = 20;
                        this.label30.Text = "Recibir actualizaciones";
                        this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAislacion
                        // 
                        this.EntradaAislacion.AlwaysExpanded = true;
                        this.EntradaAislacion.AutoNav = true;
                        this.EntradaAislacion.AutoSize = true;
                        this.EntradaAislacion.AutoTab = true;
                        this.EntradaAislacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaAislacion.FieldName = null;
                        this.EntradaAislacion.Location = new System.Drawing.Point(248, 176);
                        this.EntradaAislacion.MaxLength = 32767;
                        this.EntradaAislacion.Name = "EntradaAislacion";
                        this.EntradaAislacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAislacion.PlaceholderText = null;
                        this.EntradaAislacion.ReadOnly = false;
                        this.EntradaAislacion.SetData = new string[] {
        "Mejor concurrencia|RepeatableRead",
        "Mejor consitencia|Serializable"};
                        this.EntradaAislacion.Size = new System.Drawing.Size(196, 36);
                        this.EntradaAislacion.TabIndex = 19;
                        this.EntradaAislacion.TextKey = "Serializable";
                        // 
                        // EntradaModoPantalla
                        // 
                        this.EntradaModoPantalla.AlwaysExpanded = true;
                        this.EntradaModoPantalla.AutoNav = true;
                        this.EntradaModoPantalla.AutoSize = true;
                        this.EntradaModoPantalla.AutoTab = true;
                        this.EntradaModoPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaModoPantalla.FieldName = null;
                        this.EntradaModoPantalla.Location = new System.Drawing.Point(248, 88);
                        this.EntradaModoPantalla.MaxLength = 32767;
                        this.EntradaModoPantalla.Name = "EntradaModoPantalla";
                        this.EntradaModoPantalla.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaModoPantalla.PlaceholderText = null;
                        this.EntradaModoPantalla.ReadOnly = false;
                        this.EntradaModoPantalla.SetData = new string[] {
        "Predeterminado|*",
        "Ventana Normal|normal",
        "Ventana Maximizada|maximizado",
        "Pantalla Completa|completo",
        "Ventanas Flotantes|flotante"};
                        this.EntradaModoPantalla.Size = new System.Drawing.Size(196, 81);
                        this.EntradaModoPantalla.TabIndex = 17;
                        this.EntradaModoPantalla.TextKey = "*";
                        // 
                        // EntradaBackup
                        // 
                        this.EntradaBackup.AlwaysExpanded = true;
                        this.EntradaBackup.AutoNav = true;
                        this.EntradaBackup.AutoSize = true;
                        this.EntradaBackup.AutoTab = true;
                        this.EntradaBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaBackup.FieldName = null;
                        this.EntradaBackup.Location = new System.Drawing.Point(248, 32);
                        this.EntradaBackup.MaxLength = 32767;
                        this.EntradaBackup.Name = "EntradaBackup";
                        this.EntradaBackup.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBackup.PlaceholderText = null;
                        this.EntradaBackup.ReadOnly = false;
                        this.EntradaBackup.SetData = new string[] {
        "Nunca|0",
        "Cuando se solicita|1",
        "Automáticamente|2"};
                        this.EntradaBackup.Size = new System.Drawing.Size(196, 51);
                        this.EntradaBackup.TabIndex = 0;
                        this.EntradaBackup.TextKey = "0";
                        // 
                        // label29
                        // 
                        this.label29.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label29.Location = new System.Drawing.Point(16, 176);
                        this.label29.Name = "label29";
                        this.label29.Size = new System.Drawing.Size(232, 24);
                        this.label29.TabIndex = 18;
                        this.label29.Text = "Nivel de aislamiento de clientes";
                        this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label27
                        // 
                        this.label27.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label27.Location = new System.Drawing.Point(16, 88);
                        this.label27.Name = "label27";
                        this.label27.Size = new System.Drawing.Size(232, 24);
                        this.label27.TabIndex = 16;
                        this.label27.Text = "Modo de uso de la pantalla";
                        this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label14
                        // 
                        this.label14.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label14.Location = new System.Drawing.Point(16, 32);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(232, 24);
                        this.label14.TabIndex = 14;
                        this.label14.Text = "Realizar copias de respaldo";
                        this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaStockDecimales
                        // 
                        this.EntradaStockDecimales.AlwaysExpanded = false;
                        this.EntradaStockDecimales.AutoNav = true;
                        this.EntradaStockDecimales.AutoTab = true;
                        this.EntradaStockDecimales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaStockDecimales.FieldName = null;
                        this.EntradaStockDecimales.Location = new System.Drawing.Point(192, 92);
                        this.EntradaStockDecimales.MaxLength = 32767;
                        this.EntradaStockDecimales.Name = "EntradaStockDecimales";
                        this.EntradaStockDecimales.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDecimales.PlaceholderText = null;
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
                        this.Label25.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label25.Location = new System.Drawing.Point(16, 92);
                        this.Label25.Name = "Label25";
                        this.Label25.Size = new System.Drawing.Size(176, 24);
                        this.Label25.TabIndex = 4;
                        this.Label25.Text = "Precisión del Stock";
                        this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label24
                        // 
                        this.Label24.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaStockDepositoPredet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaStockDepositoPredet.CanCreate = true;
                        this.EntradaStockDepositoPredet.DataTextField = "nombre";
                        this.EntradaStockDepositoPredet.DataValueField = "id_situacion";
                        this.EntradaStockDepositoPredet.ExtraDetailFields = "";
                        this.EntradaStockDepositoPredet.FieldName = null;
                        this.EntradaStockDepositoPredet.Filter = "";
                        this.EntradaStockDepositoPredet.FreeTextCode = "";
                        this.EntradaStockDepositoPredet.Location = new System.Drawing.Point(192, 120);
                        this.EntradaStockDepositoPredet.MaxLength = 200;
                        this.EntradaStockDepositoPredet.Name = "EntradaStockDepositoPredet";
                        this.EntradaStockDepositoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDepositoPredet.PlaceholderText = null;
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
                        this.EntradaStockMultideposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaStockMultideposito.FieldName = null;
                        this.EntradaStockMultideposito.Location = new System.Drawing.Point(192, 64);
                        this.EntradaStockMultideposito.MaxLength = 32767;
                        this.EntradaStockMultideposito.Name = "EntradaStockMultideposito";
                        this.EntradaStockMultideposito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockMultideposito.PlaceholderText = null;
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
                        this.Label23.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaArticulosCodigoPredet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaArticulosCodigoPredet.FieldName = null;
                        this.EntradaArticulosCodigoPredet.Location = new System.Drawing.Point(192, 36);
                        this.EntradaArticulosCodigoPredet.MaxLength = 32767;
                        this.EntradaArticulosCodigoPredet.Name = "EntradaArticulosCodigoPredet";
                        this.EntradaArticulosCodigoPredet.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaArticulosCodigoPredet.PlaceholderText = null;
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
                        this.Label20.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaPV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.FieldName = null;
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.Location = new System.Drawing.Point(248, 100);
                        this.EntradaPV.MaxLength = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.PlaceholderText = null;
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 5;
                        this.EntradaPV.Text = "0";
                        // 
                        // Label9
                        // 
                        this.Label9.LabelStyle = Lui.Forms.LabelStyles.Small;
                        this.Label9.Location = new System.Drawing.Point(308, 184);
                        this.Label9.Name = "Label9";
                        this.Label9.Size = new System.Drawing.Size(284, 24);
                        this.Label9.TabIndex = 14;
                        this.Label9.Text = "(0 para utilizar el mismo que para facturas)";
                        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVND
                        // 
                        this.EntradaPVND.AutoNav = true;
                        this.EntradaPVND.AutoTab = true;
                        this.EntradaPVND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPVND.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVND.DecimalPlaces = -1;
                        this.EntradaPVND.FieldName = null;
                        this.EntradaPVND.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVND.Location = new System.Drawing.Point(248, 184);
                        this.EntradaPVND.MaxLength = 32767;
                        this.EntradaPVND.MultiLine = false;
                        this.EntradaPVND.Name = "EntradaPVND";
                        this.EntradaPVND.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVND.PasswordChar = '\0';
                        this.EntradaPVND.PlaceholderText = null;
                        this.EntradaPVND.Prefijo = "";
                        this.EntradaPVND.ReadOnly = false;
                        this.EntradaPVND.SelectOnFocus = true;
                        this.EntradaPVND.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVND.Sufijo = "";
                        this.EntradaPVND.TabIndex = 13;
                        this.EntradaPVND.Text = "0";
                        // 
                        // Label10
                        // 
                        this.Label10.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label10.Location = new System.Drawing.Point(12, 184);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(236, 24);
                        this.Label10.TabIndex = 12;
                        this.Label10.Text = "PV para Notas de Débito A, B y C";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.LabelStyle = Lui.Forms.LabelStyles.Small;
                        this.Label8.Location = new System.Drawing.Point(308, 156);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(284, 24);
                        this.Label8.TabIndex = 11;
                        this.Label8.Text = "(0 para utilizar el mismo que para facturas)";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label7
                        // 
                        this.Label7.LabelStyle = Lui.Forms.LabelStyles.Small;
                        this.Label7.Location = new System.Drawing.Point(308, 128);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(284, 24);
                        this.Label7.TabIndex = 8;
                        this.Label7.Text = "(0 para utilizar el predeterminado)";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPVNC
                        // 
                        this.EntradaPVNC.AutoNav = true;
                        this.EntradaPVNC.AutoTab = true;
                        this.EntradaPVNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPVNC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVNC.DecimalPlaces = -1;
                        this.EntradaPVNC.FieldName = null;
                        this.EntradaPVNC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVNC.Location = new System.Drawing.Point(248, 156);
                        this.EntradaPVNC.MaxLength = 32767;
                        this.EntradaPVNC.MultiLine = false;
                        this.EntradaPVNC.Name = "EntradaPVNC";
                        this.EntradaPVNC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVNC.PasswordChar = '\0';
                        this.EntradaPVNC.PlaceholderText = null;
                        this.EntradaPVNC.Prefijo = "";
                        this.EntradaPVNC.ReadOnly = false;
                        this.EntradaPVNC.SelectOnFocus = true;
                        this.EntradaPVNC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVNC.Sufijo = "";
                        this.EntradaPVNC.TabIndex = 10;
                        this.EntradaPVNC.Text = "0";
                        // 
                        // EntradaPVABC
                        // 
                        this.EntradaPVABC.AutoNav = true;
                        this.EntradaPVABC.AutoTab = true;
                        this.EntradaPVABC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPVABC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVABC.DecimalPlaces = -1;
                        this.EntradaPVABC.FieldName = null;
                        this.EntradaPVABC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVABC.Location = new System.Drawing.Point(248, 128);
                        this.EntradaPVABC.MaxLength = 32767;
                        this.EntradaPVABC.MultiLine = false;
                        this.EntradaPVABC.Name = "EntradaPVABC";
                        this.EntradaPVABC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVABC.PasswordChar = '\0';
                        this.EntradaPVABC.PlaceholderText = null;
                        this.EntradaPVABC.Prefijo = "";
                        this.EntradaPVABC.ReadOnly = false;
                        this.EntradaPVABC.SelectOnFocus = true;
                        this.EntradaPVABC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVABC.Sufijo = "";
                        this.EntradaPVABC.TabIndex = 7;
                        this.EntradaPVABC.Text = "0";
                        // 
                        // Label6
                        // 
                        this.Label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(12, 156);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(236, 24);
                        this.Label6.TabIndex = 9;
                        this.Label6.Text = "PV para Notas de Crédito A, B y C";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label5
                        // 
                        this.Label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(12, 128);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(236, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "PV para Facturas A, B y C";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(12, 100);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(236, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "PV Predeterminado";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label16
                        // 
                        this.Label16.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaClientePredet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaClientePredet.CanCreate = true;
                        this.EntradaClientePredet.DataTextField = "nombre_visible";
                        this.EntradaClientePredet.DataValueField = "id_persona";
                        this.EntradaClientePredet.ExtraDetailFields = "";
                        this.EntradaClientePredet.FieldName = null;
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
                        this.Label15.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaFormaPagoPredet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaFormaPagoPredet.CanCreate = true;
                        this.EntradaFormaPagoPredet.DataTextField = "nombre";
                        this.EntradaFormaPagoPredet.DataValueField = "id_formapago";
                        this.EntradaFormaPagoPredet.ExtraDetailFields = "";
                        this.EntradaFormaPagoPredet.FieldName = null;
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
                        this.BotonSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
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
                        this.BotonSiguiente.TabIndex = 52;
                        this.BotonSiguiente.Text = "Más...";
                        this.BotonSiguiente.Click += new System.EventHandler(this.BotonSiguiente_Click);
                        // 
                        // FrmArticulos
                        // 
                        this.FrmArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.FrmArticulos.Controls.Add(this.EntradaMonedaDecimalesCosto);
                        this.FrmArticulos.Controls.Add(this.label35);
                        this.FrmArticulos.Controls.Add(this.EntradaMonedaDecimalesUnitarios);
                        this.FrmArticulos.Controls.Add(this.label34);
                        this.FrmArticulos.Controls.Add(this.EntradaMonedaDecimalesFinal);
                        this.FrmArticulos.Controls.Add(this.label18);
                        this.FrmArticulos.Controls.Add(this.label26);
                        this.FrmArticulos.Controls.Add(this.EntradaStockDepositoPredetSuc);
                        this.FrmArticulos.Controls.Add(this.EntradaStockDecimales);
                        this.FrmArticulos.Controls.Add(this.Label25);
                        this.FrmArticulos.Controls.Add(this.Label24);
                        this.FrmArticulos.Controls.Add(this.EntradaMonedaUnidadMonetariaMinima);
                        this.FrmArticulos.Controls.Add(this.label22);
                        this.FrmArticulos.Controls.Add(this.EntradaStockDepositoPredet);
                        this.FrmArticulos.Controls.Add(this.EntradaStockMultideposito);
                        this.FrmArticulos.Controls.Add(this.Label23);
                        this.FrmArticulos.Controls.Add(this.EntradaArticulosCodigoPredet);
                        this.FrmArticulos.Controls.Add(this.Label20);
                        this.FrmArticulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FrmArticulos.Location = new System.Drawing.Point(8, 8);
                        this.FrmArticulos.Name = "FrmArticulos";
                        this.FrmArticulos.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmArticulos.ReadOnly = false;
                        this.FrmArticulos.Size = new System.Drawing.Size(620, 385);
                        this.FrmArticulos.TabIndex = 0;
                        this.FrmArticulos.TabStop = false;
                        this.FrmArticulos.Text = "Existencias y Precios";
                        this.FrmArticulos.Visible = false;
                        // 
                        // EntradaMonedaDecimalesCosto
                        // 
                        this.EntradaMonedaDecimalesCosto.AlwaysExpanded = false;
                        this.EntradaMonedaDecimalesCosto.AutoNav = true;
                        this.EntradaMonedaDecimalesCosto.AutoTab = true;
                        this.EntradaMonedaDecimalesCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaMonedaDecimalesCosto.FieldName = null;
                        this.EntradaMonedaDecimalesCosto.Location = new System.Drawing.Point(192, 216);
                        this.EntradaMonedaDecimalesCosto.MaxLength = 32767;
                        this.EntradaMonedaDecimalesCosto.Name = "EntradaMonedaDecimalesCosto";
                        this.EntradaMonedaDecimalesCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMonedaDecimalesCosto.PlaceholderText = null;
                        this.EntradaMonedaDecimalesCosto.ReadOnly = false;
                        this.EntradaMonedaDecimalesCosto.SetData = new string[] {
        "Sin decimales|0",
        "Un decimal|1",
        "Dos decimales|2",
        "Tres decimales|3",
        "Cuatro decimales|4"};
                        this.EntradaMonedaDecimalesCosto.Size = new System.Drawing.Size(160, 24);
                        this.EntradaMonedaDecimalesCosto.TabIndex = 11;
                        this.EntradaMonedaDecimalesCosto.TextKey = "0";
                        // 
                        // label35
                        // 
                        this.label35.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label35.Location = new System.Drawing.Point(16, 216);
                        this.label35.Name = "label35";
                        this.label35.Size = new System.Drawing.Size(176, 24);
                        this.label35.TabIndex = 10;
                        this.label35.Text = "Precios de Costo";
                        this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMonedaDecimalesUnitarios
                        // 
                        this.EntradaMonedaDecimalesUnitarios.AlwaysExpanded = false;
                        this.EntradaMonedaDecimalesUnitarios.AutoNav = true;
                        this.EntradaMonedaDecimalesUnitarios.AutoTab = true;
                        this.EntradaMonedaDecimalesUnitarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaMonedaDecimalesUnitarios.FieldName = null;
                        this.EntradaMonedaDecimalesUnitarios.Location = new System.Drawing.Point(192, 244);
                        this.EntradaMonedaDecimalesUnitarios.MaxLength = 32767;
                        this.EntradaMonedaDecimalesUnitarios.Name = "EntradaMonedaDecimalesUnitarios";
                        this.EntradaMonedaDecimalesUnitarios.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMonedaDecimalesUnitarios.PlaceholderText = null;
                        this.EntradaMonedaDecimalesUnitarios.ReadOnly = false;
                        this.EntradaMonedaDecimalesUnitarios.SetData = new string[] {
        "Sin decimales|0",
        "Un decimal|1",
        "Dos decimales|2",
        "Tres decimales|3",
        "Cuatro decimales|4"};
                        this.EntradaMonedaDecimalesUnitarios.Size = new System.Drawing.Size(160, 24);
                        this.EntradaMonedaDecimalesUnitarios.TabIndex = 13;
                        this.EntradaMonedaDecimalesUnitarios.TextKey = "0";
                        // 
                        // label34
                        // 
                        this.label34.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label34.Location = new System.Drawing.Point(16, 244);
                        this.label34.Name = "label34";
                        this.label34.Size = new System.Drawing.Size(176, 24);
                        this.label34.TabIndex = 12;
                        this.label34.Text = "Precios Unitarios";
                        this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMonedaDecimalesFinal
                        // 
                        this.EntradaMonedaDecimalesFinal.AlwaysExpanded = false;
                        this.EntradaMonedaDecimalesFinal.AutoNav = true;
                        this.EntradaMonedaDecimalesFinal.AutoTab = true;
                        this.EntradaMonedaDecimalesFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaMonedaDecimalesFinal.FieldName = null;
                        this.EntradaMonedaDecimalesFinal.Location = new System.Drawing.Point(192, 272);
                        this.EntradaMonedaDecimalesFinal.MaxLength = 32767;
                        this.EntradaMonedaDecimalesFinal.Name = "EntradaMonedaDecimalesFinal";
                        this.EntradaMonedaDecimalesFinal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMonedaDecimalesFinal.PlaceholderText = null;
                        this.EntradaMonedaDecimalesFinal.ReadOnly = false;
                        this.EntradaMonedaDecimalesFinal.SetData = new string[] {
        "Sin decimales|0",
        "Un decimal|1",
        "Dos decimales|2",
        "Tres decimales|3",
        "Cuatro decimales|4"};
                        this.EntradaMonedaDecimalesFinal.Size = new System.Drawing.Size(160, 24);
                        this.EntradaMonedaDecimalesFinal.TabIndex = 15;
                        this.EntradaMonedaDecimalesFinal.TextKey = "0";
                        // 
                        // label18
                        // 
                        this.label18.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label18.Location = new System.Drawing.Point(16, 272);
                        this.label18.Name = "label18";
                        this.label18.Size = new System.Drawing.Size(176, 24);
                        this.label18.TabIndex = 14;
                        this.label18.Text = "Total del Comprobante";
                        this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label26
                        // 
                        this.label26.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaStockDepositoPredetSuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaStockDepositoPredetSuc.CanCreate = true;
                        this.EntradaStockDepositoPredetSuc.DataTextField = "nombre";
                        this.EntradaStockDepositoPredetSuc.DataValueField = "id_situacion";
                        this.EntradaStockDepositoPredetSuc.ExtraDetailFields = "";
                        this.EntradaStockDepositoPredetSuc.FieldName = null;
                        this.EntradaStockDepositoPredetSuc.Filter = "";
                        this.EntradaStockDepositoPredetSuc.FreeTextCode = "";
                        this.EntradaStockDepositoPredetSuc.Location = new System.Drawing.Point(192, 148);
                        this.EntradaStockDepositoPredetSuc.MaxLength = 200;
                        this.EntradaStockDepositoPredetSuc.Name = "EntradaStockDepositoPredetSuc";
                        this.EntradaStockDepositoPredetSuc.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaStockDepositoPredetSuc.PlaceholderText = null;
                        this.EntradaStockDepositoPredetSuc.ReadOnly = false;
                        this.EntradaStockDepositoPredetSuc.Required = false;
                        this.EntradaStockDepositoPredetSuc.Size = new System.Drawing.Size(416, 24);
                        this.EntradaStockDepositoPredetSuc.TabIndex = 9;
                        this.EntradaStockDepositoPredetSuc.Table = "articulos_situaciones";
                        this.EntradaStockDepositoPredetSuc.Text = "0";
                        this.EntradaStockDepositoPredetSuc.TextDetail = "";
                        // 
                        // EntradaMonedaUnidadMonetariaMinima
                        // 
                        this.EntradaMonedaUnidadMonetariaMinima.AutoNav = true;
                        this.EntradaMonedaUnidadMonetariaMinima.AutoTab = true;
                        this.EntradaMonedaUnidadMonetariaMinima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaMonedaUnidadMonetariaMinima.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaMonedaUnidadMonetariaMinima.DecimalPlaces = -1;
                        this.EntradaMonedaUnidadMonetariaMinima.FieldName = null;
                        this.EntradaMonedaUnidadMonetariaMinima.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMonedaUnidadMonetariaMinima.Location = new System.Drawing.Point(252, 304);
                        this.EntradaMonedaUnidadMonetariaMinima.MaxLength = 32767;
                        this.EntradaMonedaUnidadMonetariaMinima.MultiLine = false;
                        this.EntradaMonedaUnidadMonetariaMinima.Name = "EntradaMonedaUnidadMonetariaMinima";
                        this.EntradaMonedaUnidadMonetariaMinima.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMonedaUnidadMonetariaMinima.PasswordChar = '\0';
                        this.EntradaMonedaUnidadMonetariaMinima.PlaceholderText = null;
                        this.EntradaMonedaUnidadMonetariaMinima.Prefijo = "$";
                        this.EntradaMonedaUnidadMonetariaMinima.ReadOnly = false;
                        this.EntradaMonedaUnidadMonetariaMinima.SelectOnFocus = true;
                        this.EntradaMonedaUnidadMonetariaMinima.Size = new System.Drawing.Size(92, 24);
                        this.EntradaMonedaUnidadMonetariaMinima.Sufijo = "";
                        this.EntradaMonedaUnidadMonetariaMinima.TabIndex = 17;
                        this.EntradaMonedaUnidadMonetariaMinima.Text = "0.00";
                        // 
                        // label22
                        // 
                        this.label22.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label22.Location = new System.Drawing.Point(16, 304);
                        this.label22.Name = "label22";
                        this.label22.Size = new System.Drawing.Size(236, 24);
                        this.label22.TabIndex = 16;
                        this.label22.Text = "Denominación Monetaria Mínima";
                        this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FrmComprobantes
                        // 
                        this.FrmComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.FrmComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.FrmComprobantes.Controls.Add(this.EntradaPVRC);
                        this.FrmComprobantes.Controls.Add(this.label3);
                        this.FrmComprobantes.Controls.Add(this.label11);
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
                        this.FrmComprobantes.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
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
                        this.EntradaPVRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPVRC.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVRC.DecimalPlaces = -1;
                        this.EntradaPVRC.FieldName = null;
                        this.EntradaPVRC.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVRC.Location = new System.Drawing.Point(248, 240);
                        this.EntradaPVRC.MaxLength = 32767;
                        this.EntradaPVRC.MultiLine = false;
                        this.EntradaPVRC.Name = "EntradaPVRC";
                        this.EntradaPVRC.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVRC.PasswordChar = '\0';
                        this.EntradaPVRC.PlaceholderText = null;
                        this.EntradaPVRC.Prefijo = "";
                        this.EntradaPVRC.ReadOnly = false;
                        this.EntradaPVRC.SelectOnFocus = true;
                        this.EntradaPVRC.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVRC.Sufijo = "";
                        this.EntradaPVRC.TabIndex = 19;
                        this.EntradaPVRC.Text = "0";
                        // 
                        // label3
                        // 
                        this.label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label3.Location = new System.Drawing.Point(12, 240);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(236, 24);
                        this.label3.TabIndex = 18;
                        this.label3.Text = "PV para Recibos";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label11
                        // 
                        this.label11.LabelStyle = Lui.Forms.LabelStyles.Small;
                        this.label11.Location = new System.Drawing.Point(308, 212);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(284, 24);
                        this.label11.TabIndex = 17;
                        this.label11.Text = "(0 para utilizar el mismo que para facturas)";
                        this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLimiteCredito
                        // 
                        this.EntradaLimiteCredito.AutoNav = true;
                        this.EntradaLimiteCredito.AutoTab = true;
                        this.EntradaLimiteCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaLimiteCredito.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaLimiteCredito.DecimalPlaces = -1;
                        this.EntradaLimiteCredito.FieldName = null;
                        this.EntradaLimiteCredito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaLimiteCredito.Location = new System.Drawing.Point(248, 316);
                        this.EntradaLimiteCredito.MaxLength = 32767;
                        this.EntradaLimiteCredito.MultiLine = false;
                        this.EntradaLimiteCredito.Name = "EntradaLimiteCredito";
                        this.EntradaLimiteCredito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLimiteCredito.PasswordChar = '\0';
                        this.EntradaLimiteCredito.PlaceholderText = null;
                        this.EntradaLimiteCredito.Prefijo = "$";
                        this.EntradaLimiteCredito.ReadOnly = false;
                        this.EntradaLimiteCredito.SelectOnFocus = true;
                        this.EntradaLimiteCredito.Size = new System.Drawing.Size(124, 24);
                        this.EntradaLimiteCredito.Sufijo = "";
                        this.EntradaLimiteCredito.TabIndex = 23;
                        this.EntradaLimiteCredito.Text = "0.00";
                        // 
                        // label21
                        // 
                        this.label21.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label21.Location = new System.Drawing.Point(12, 316);
                        this.label21.Name = "label21";
                        this.label21.Size = new System.Drawing.Size(236, 24);
                        this.label21.TabIndex = 22;
                        this.label21.Text = "Límite de crédito predeterminado";
                        this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCambiaPrecioComprob
                        // 
                        this.EntradaCambiaPrecioComprob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaCambiaPrecioComprob.FieldName = null;
                        this.EntradaCambiaPrecioComprob.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCambiaPrecioComprob.Location = new System.Drawing.Point(420, 280);
                        this.EntradaCambiaPrecioComprob.Name = "EntradaCambiaPrecioComprob";
                        this.EntradaCambiaPrecioComprob.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCambiaPrecioComprob.ReadOnly = false;
                        this.EntradaCambiaPrecioComprob.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCambiaPrecioComprob.TabIndex = 21;
                        this.EntradaCambiaPrecioComprob.Value = true;
                        // 
                        // label13
                        // 
                        this.label13.LabelStyle = Lui.Forms.LabelStyles.Default;
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
                        this.EntradaPVR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.EntradaPVR.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPVR.DecimalPlaces = -1;
                        this.EntradaPVR.FieldName = null;
                        this.EntradaPVR.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPVR.Location = new System.Drawing.Point(248, 212);
                        this.EntradaPVR.MaxLength = 32767;
                        this.EntradaPVR.MultiLine = false;
                        this.EntradaPVR.Name = "EntradaPVR";
                        this.EntradaPVR.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPVR.PasswordChar = '\0';
                        this.EntradaPVR.PlaceholderText = null;
                        this.EntradaPVR.Prefijo = "";
                        this.EntradaPVR.ReadOnly = false;
                        this.EntradaPVR.SelectOnFocus = true;
                        this.EntradaPVR.Size = new System.Drawing.Size(56, 24);
                        this.EntradaPVR.Sufijo = "";
                        this.EntradaPVR.TabIndex = 16;
                        this.EntradaPVR.Text = "0";
                        // 
                        // label12
                        // 
                        this.label12.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label12.Location = new System.Drawing.Point(12, 212);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(236, 24);
                        this.label12.TabIndex = 15;
                        this.label12.Text = "PV para Remitos";
                        this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FrmAvanzado
                        // 
                        this.FrmAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
                        this.FrmAvanzado.Controls.Add(this.label14);
                        this.FrmAvanzado.Controls.Add(this.label27);
                        this.FrmAvanzado.Controls.Add(this.EntradaBackup);
                        this.FrmAvanzado.Controls.Add(this.EntradaAislacion);
                        this.FrmAvanzado.Controls.Add(this.label29);
                        this.FrmAvanzado.Controls.Add(this.EntradaModoPantalla);
                        this.FrmAvanzado.Controls.Add(this.EntradaActualizaciones);
                        this.FrmAvanzado.Controls.Add(this.label30);
                        this.FrmAvanzado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FrmAvanzado.Location = new System.Drawing.Point(8, 8);
                        this.FrmAvanzado.Name = "FrmAvanzado";
                        this.FrmAvanzado.Padding = new System.Windows.Forms.Padding(2);
                        this.FrmAvanzado.ReadOnly = false;
                        this.FrmAvanzado.Size = new System.Drawing.Size(620, 385);
                        this.FrmAvanzado.TabIndex = 8;
                        this.FrmAvanzado.Text = "Avanzado";
                        this.FrmAvanzado.Visible = false;
                        // 
                        // Preferencias
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 448);
                        this.Controls.Add(this.BotonSiguiente);
                        this.Controls.Add(this.CancelCommandButton);
                        this.Controls.Add(this.BotonAceptar);
                        this.Controls.Add(this.FrmArticulos);
                        this.Controls.Add(this.FrmAvanzado);
                        this.Controls.Add(this.FrmGeneral);
                        this.Controls.Add(this.FrmComprobantes);
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
                        this.FrmAvanzado.ResumeLayout(false);
                        this.FrmAvanzado.PerformLayout();
                        this.ResumeLayout(false);

		}
		#endregion

                private Lui.Forms.Button BotonAceptar;
                private Lui.Forms.Button CancelCommandButton;
                private Lui.Forms.Label Label16;
                private Lcc.Entrada.CodigoDetalle EntradaClientePredet;
                private Lui.Forms.Label Label15;
                private Lcc.Entrada.CodigoDetalle EntradaFormaPagoPredet;
                private Lui.Forms.Label Label17;
                private Lui.Forms.TextBox EntradaEmpresaNombre;
                private Lui.Forms.Label EtiquetaClaveTributaria;
                private Lui.Forms.Label Label19;
                private Lui.Forms.TextBox EntradaEmpresaClaveTributaria;
                private Lcc.Entrada.CodigoDetalle EntradaEmpresaSituacion;
                private Lui.Forms.Label Label9;
                private Lui.Forms.TextBox EntradaPVND;
                private Lui.Forms.Label Label10;
                private Lui.Forms.Label Label8;
                private Lui.Forms.Label Label7;
                private Lui.Forms.TextBox EntradaPVNC;
                private Lui.Forms.TextBox EntradaPVABC;
                private Lui.Forms.Label Label6;
                private Lui.Forms.Label Label5;
                private Lui.Forms.Label Label4;
                private Lui.Forms.Label Label20;
                private Lui.Forms.TextBox EntradaPV;
                private Lui.Forms.ComboBox EntradaArticulosCodigoPredet;
                private Lui.Forms.ComboBox EntradaStockMultideposito;
                private Lui.Forms.Label Label23;
                private Lui.Forms.Label Label24;
                private Lcc.Entrada.CodigoDetalle EntradaStockDepositoPredet;
                private Lui.Forms.Label Label25;
                private Lui.Forms.ComboBox EntradaStockDecimales;
                private Lui.Forms.Button BotonSiguiente;
                private Lui.Forms.Frame FrmArticulos;
                private Lui.Forms.Frame FrmComprobantes;
                private Lui.Forms.ComboBox EntradaBackup;
                private Lui.Forms.Label label14;
                private Lui.Forms.TextBox EntradaLimiteCredito;
                private Lui.Forms.Label label21;
                private Lui.Forms.TextBox EntradaMonedaUnidadMonetariaMinima;
                private Lui.Forms.Label label22;
                private Lui.Forms.ComboBox EntradaModoPantalla;
                private Lui.Forms.Label label27;
                private Lui.Forms.TextBox EntradaEmpresaEmail;
                private Lui.Forms.Label label28;
                private Lui.Forms.ComboBox EntradaAislacion;
                private Lui.Forms.Label label29;
                private Lui.Forms.ComboBox EntradaActualizaciones;
                private Lui.Forms.Label label30;
                private Lui.Forms.TextBox EntradaEmpresaRazonSocial;
                private Lui.Forms.Label label1;
                private Lui.Forms.TextBox EntradaPVRC;
                private Lui.Forms.Label label3;
                private Lui.Forms.TextBox EntradaEmpresaId;
                private Lui.Forms.Label label2;
                private Lui.Forms.Frame FrmGeneral;
                private Lui.Forms.Label label26;
                private Lcc.Entrada.CodigoDetalle EntradaStockDepositoPredetSuc;
                private Lui.Forms.Label label11;
                private Lui.Forms.Label label12;
                private Lui.Forms.TextBox EntradaPVR;
                private Lui.Forms.YesNo EntradaCambiaPrecioComprob;
                private Lui.Forms.Label label13;
                private Lcc.Entrada.CodigoDetalle EntradaProvincia;
                private Lui.Forms.Label label31;
                private Lui.Forms.Frame FrmAvanzado;
                private Lcc.Entrada.CodigoDetalle EntradaLocalidad;
                private Lui.Forms.Label label32;
                private Lcc.Entrada.CodigoDetalle EntradaPais;
                private Lui.Forms.Label label33;
                private Lui.Forms.ComboBox EntradaMonedaDecimalesFinal;
                private Lui.Forms.Label label18;
                private Lui.Forms.ComboBox EntradaMonedaDecimalesUnitarios;
                private Lui.Forms.Label label34;
                private Lui.Forms.ComboBox EntradaMonedaDecimalesCosto;
                private Lui.Forms.Label label35;
	}
}
