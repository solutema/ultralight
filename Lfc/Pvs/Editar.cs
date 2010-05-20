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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Pvs
{
	public class Editar : Lui.Forms.EditForm
	{
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal Lui.Forms.TextBox EntradaNumero;
                internal Lui.Forms.ComboBox EntradaTipo;
		internal Lui.Forms.TextBox EntradaEstacion;
		internal Lui.Forms.ComboBox txtCarga;
		internal Lui.Forms.Button cmdEstacionSeleccionar;
		internal Lui.Forms.DetailBox EntradaSucursal;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label7;
                internal Lui.Forms.ComboBox txtModelo;
                internal Lui.Forms.ComboBox txtPuerto;
		internal Lui.Forms.ComboBox txtBps;
		private Lui.Forms.Note note1;
                internal Lui.Forms.ComboBox EntradaTipoFac;
                internal Label label8;
                internal Lui.Forms.ComboBox EntradaDeTalonario;
                internal Label label9;
		private System.ComponentModel.IContainer components = null;

		public Editar()
		{
			InitializeComponent();

                        System.Collections.Generic.List<string> ListaTipos = new System.Collections.Generic.List<string>();
                        ListaTipos.Add("Facutras|F");
                        ListaTipos.Add("Notas de Débito|ND");
                        ListaTipos.Add("Notas de Crédito|NC");
                        ListaTipos.Add("Facutras, Notas de Débito|F,ND");
                        ListaTipos.Add("Facutras, Notas de Crédito y Débito|F,NC,ND");
                        System.Data.DataTable DocumentosTipos = this.Workspace.DefaultDataBase.Select("SELECT letra,nombre FROM documentos_tipos ORDER BY letra");
                        foreach (System.Data.DataRow DocumentoTipo in DocumentosTipos.Rows) {
                                ListaTipos.Add(DocumentoTipo["nombre"].ToString() + "|" + DocumentoTipo["letra"].ToString());
                        }
                        EntradaTipoFac.SetData = ListaTipos.ToArray();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label16 = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaEstacion = new Lui.Forms.TextBox();
                        this.txtCarga = new Lui.Forms.ComboBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.cmdEstacionSeleccionar = new Lui.Forms.Button();
                        this.EntradaSucursal = new Lui.Forms.DetailBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.label6 = new System.Windows.Forms.Label();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtModelo = new Lui.Forms.ComboBox();
                        this.txtPuerto = new Lui.Forms.ComboBox();
                        this.txtBps = new Lui.Forms.ComboBox();
                        this.note1 = new Lui.Forms.Note();
                        this.EntradaTipoFac = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.EntradaDeTalonario = new Lui.Forms.ComboBox();
                        this.label9 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(409, 7);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(517, 7);
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 20);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(140, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Punto de Venta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoHeight = false;
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNumero.Location = new System.Drawing.Point(160, 20);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(72, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 1;
                        this.EntradaNumero.Text = "0";
                        this.EntradaNumero.TextRaw = "0";
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AutoHeight = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(160, 104);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Inactivo|0",
        "Impresora Normal|1",
        "Impresora Fiscal|2"};
                        this.EntradaTipo.Size = new System.Drawing.Size(208, 24);
                        this.EntradaTipo.TabIndex = 7;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.Text = "Impresora Normal";
                        this.EntradaTipo.TextKey = "1";
                        this.EntradaTipo.TextRaw = "Impresora Normal";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
                        // 
                        // Label16
                        // 
                        this.Label16.Location = new System.Drawing.Point(20, 104);
                        this.Label16.Name = "Label16";
                        this.Label16.Size = new System.Drawing.Size(140, 24);
                        this.Label16.TabIndex = 6;
                        this.Label16.Text = "Tipo";
                        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(20, 160);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(140, 24);
                        this.label1.TabIndex = 10;
                        this.label1.Text = "Estación";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstacion
                        // 
                        this.EntradaEstacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaEstacion.AutoHeight = false;
                        this.EntradaEstacion.AutoNav = true;
                        this.EntradaEstacion.AutoTab = true;
                        this.EntradaEstacion.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaEstacion.DecimalPlaces = -1;
                        this.EntradaEstacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstacion.ForceCase = Lui.Forms.TextCasing.UpperCase;
                        this.EntradaEstacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaEstacion.Location = new System.Drawing.Point(160, 160);
                        this.EntradaEstacion.MaxLenght = 32767;
                        this.EntradaEstacion.MultiLine = false;
                        this.EntradaEstacion.Name = "EntradaEstacion";
                        this.EntradaEstacion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstacion.PasswordChar = '\0';
                        this.EntradaEstacion.Prefijo = "";
                        this.EntradaEstacion.ReadOnly = false;
                        this.EntradaEstacion.SelectOnFocus = true;
                        this.EntradaEstacion.Size = new System.Drawing.Size(336, 24);
                        this.EntradaEstacion.Sufijo = "";
                        this.EntradaEstacion.TabIndex = 11;
                        this.EntradaEstacion.TextRaw = "";
                        this.EntradaEstacion.TipWhenBlank = "";
                        this.EntradaEstacion.ToolTipText = "";
                        // 
                        // txtCarga
                        // 
                        this.txtCarga.AutoHeight = false;
                        this.txtCarga.AutoNav = true;
                        this.txtCarga.AutoTab = true;
                        this.txtCarga.DetailField = null;
                        this.txtCarga.Filter = null;
                        this.txtCarga.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCarga.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCarga.KeyField = null;
                        this.txtCarga.Location = new System.Drawing.Point(188, 280);
                        this.txtCarga.MaxLenght = 32767;
                        this.txtCarga.Name = "txtCarga";
                        this.txtCarga.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCarga.ReadOnly = false;
                        this.txtCarga.SetData = new string[] {
        "Automática|0",
        "Manual|1"};
                        this.txtCarga.Size = new System.Drawing.Size(208, 24);
                        this.txtCarga.TabIndex = 20;
                        this.txtCarga.Table = null;
                        this.txtCarga.Text = "Automática";
                        this.txtCarga.TextKey = "0";
                        this.txtCarga.TextRaw = "Automática";
                        this.txtCarga.TipWhenBlank = "";
                        this.txtCarga.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(48, 280);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(140, 24);
                        this.label2.TabIndex = 19;
                        this.label2.Text = "Carga de Papel";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdEstacionSeleccionar
                        // 
                        this.cmdEstacionSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdEstacionSeleccionar.AutoHeight = false;
                        this.cmdEstacionSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdEstacionSeleccionar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdEstacionSeleccionar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdEstacionSeleccionar.Image = null;
                        this.cmdEstacionSeleccionar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdEstacionSeleccionar.Location = new System.Drawing.Point(500, 160);
                        this.cmdEstacionSeleccionar.Name = "cmdEstacionSeleccionar";
                        this.cmdEstacionSeleccionar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdEstacionSeleccionar.ReadOnly = false;
                        this.cmdEstacionSeleccionar.Size = new System.Drawing.Size(28, 24);
                        this.cmdEstacionSeleccionar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdEstacionSeleccionar.Subtext = "";
                        this.cmdEstacionSeleccionar.TabIndex = 12;
                        this.cmdEstacionSeleccionar.Text = "...";
                        this.cmdEstacionSeleccionar.ToolTipText = "Ver historial de movimientos de stock";
                        this.cmdEstacionSeleccionar.Click += new System.EventHandler(this.cmdEstacionSeleccionar_Click);
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSucursal.AutoHeight = false;
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.CanCreate = true;
                        this.EntradaSucursal.DetailField = "nombre";
                        this.EntradaSucursal.ExtraDetailFields = null;
                        this.EntradaSucursal.Filter = "";
                        this.EntradaSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.KeyField = "id_sucursal";
                        this.EntradaSucursal.Location = new System.Drawing.Point(160, 48);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.ReadOnly = false;
                        this.EntradaSucursal.Required = true;
                        this.EntradaSucursal.SelectOnFocus = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(409, 24);
                        this.EntradaSucursal.TabIndex = 3;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        this.EntradaSucursal.TextInt = 0;
                        this.EntradaSucursal.TipWhenBlank = "";
                        this.EntradaSucursal.ToolTipText = "Rubro o categoría";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(20, 48);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(140, 24);
                        this.label4.TabIndex = 2;
                        this.label4.Text = "Sucursal";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(48, 192);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(140, 24);
                        this.label5.TabIndex = 13;
                        this.label5.Text = "Modelo";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(48, 220);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(140, 24);
                        this.label6.TabIndex = 16;
                        this.label6.Text = "Puerto";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(48, 248);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(140, 24);
                        this.label7.TabIndex = 17;
                        this.label7.Text = "Velocidad";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtModelo
                        // 
                        this.txtModelo.AutoHeight = false;
                        this.txtModelo.AutoNav = true;
                        this.txtModelo.AutoTab = true;
                        this.txtModelo.DetailField = null;
                        this.txtModelo.Enabled = false;
                        this.txtModelo.Filter = null;
                        this.txtModelo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtModelo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtModelo.KeyField = null;
                        this.txtModelo.Location = new System.Drawing.Point(188, 192);
                        this.txtModelo.MaxLenght = 32767;
                        this.txtModelo.Name = "txtModelo";
                        this.txtModelo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtModelo.ReadOnly = false;
                        this.txtModelo.SetData = new string[] {
        "Hasar|100",
        "Epson|300",
        "Emulación|1"};
                        this.txtModelo.Size = new System.Drawing.Size(136, 24);
                        this.txtModelo.TabIndex = 14;
                        this.txtModelo.Table = null;
                        this.txtModelo.Text = "Epson";
                        this.txtModelo.TextKey = "300";
                        this.txtModelo.TextRaw = "Epson";
                        this.txtModelo.TipWhenBlank = "";
                        this.txtModelo.ToolTipText = "";
                        // 
                        // txtPuerto
                        // 
                        this.txtPuerto.AutoHeight = false;
                        this.txtPuerto.AutoNav = true;
                        this.txtPuerto.AutoTab = true;
                        this.txtPuerto.DetailField = null;
                        this.txtPuerto.Enabled = false;
                        this.txtPuerto.Filter = null;
                        this.txtPuerto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPuerto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPuerto.KeyField = null;
                        this.txtPuerto.Location = new System.Drawing.Point(188, 220);
                        this.txtPuerto.MaxLenght = 32767;
                        this.txtPuerto.Name = "txtPuerto";
                        this.txtPuerto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPuerto.ReadOnly = false;
                        this.txtPuerto.SetData = new string[] {
        "COM1|1",
        "COM2|2"};
                        this.txtPuerto.Size = new System.Drawing.Size(136, 24);
                        this.txtPuerto.TabIndex = 15;
                        this.txtPuerto.Table = null;
                        this.txtPuerto.Text = "COM1";
                        this.txtPuerto.TextKey = "1";
                        this.txtPuerto.TextRaw = "COM1";
                        this.txtPuerto.TipWhenBlank = "";
                        this.txtPuerto.ToolTipText = "";
                        // 
                        // txtBps
                        // 
                        this.txtBps.AutoHeight = false;
                        this.txtBps.AutoNav = true;
                        this.txtBps.AutoTab = true;
                        this.txtBps.DetailField = null;
                        this.txtBps.Enabled = false;
                        this.txtBps.Filter = null;
                        this.txtBps.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtBps.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtBps.KeyField = null;
                        this.txtBps.Location = new System.Drawing.Point(188, 248);
                        this.txtBps.MaxLenght = 32767;
                        this.txtBps.Name = "txtBps";
                        this.txtBps.Padding = new System.Windows.Forms.Padding(2);
                        this.txtBps.ReadOnly = false;
                        this.txtBps.SetData = new string[] {
        "9600 bps|9600",
        "19200 bps|19200"};
                        this.txtBps.Size = new System.Drawing.Size(136, 24);
                        this.txtBps.TabIndex = 18;
                        this.txtBps.Table = null;
                        this.txtBps.Text = "9600 bps";
                        this.txtBps.TextKey = "9600";
                        this.txtBps.TextRaw = "9600 bps";
                        this.txtBps.TipWhenBlank = "";
                        this.txtBps.ToolTipText = "";
                        // 
                        // note1
                        // 
                        this.note1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.note1.AutoHeight = false;
                        this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.note1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.note1.Location = new System.Drawing.Point(12, 324);
                        this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.note1.Name = "note1";
                        this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.note1.ReadOnly = false;
                        this.note1.Size = new System.Drawing.Size(600, 72);
                        this.note1.TabIndex = 21;
                        this.note1.Text = "Si desea cambiar el punto de venta predeterminado para las facturas u otros docum" +
                            "entos, utilice la opción Preferencias del menú Sistema.";
                        this.note1.Title = "Información";
                        this.note1.ToolTipText = "";
                        // 
                        // EntradaTipoFac
                        // 
                        this.EntradaTipoFac.AutoHeight = false;
                        this.EntradaTipoFac.AutoNav = true;
                        this.EntradaTipoFac.AutoTab = true;
                        this.EntradaTipoFac.DetailField = null;
                        this.EntradaTipoFac.Filter = null;
                        this.EntradaTipoFac.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipoFac.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipoFac.KeyField = null;
                        this.EntradaTipoFac.Location = new System.Drawing.Point(160, 76);
                        this.EntradaTipoFac.MaxLenght = 32767;
                        this.EntradaTipoFac.Name = "EntradaTipoFac";
                        this.EntradaTipoFac.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoFac.ReadOnly = false;
                        this.EntradaTipoFac.SetData = new string[] {
        "Facturas|F",
        "Facturas, Notas de Débito|F,ND",
        "Facturas, Notas de Crédito y Débito|F,NC,ND",
        "Remitos|R",
        "Recibos de Cobro|RC"};
                        this.EntradaTipoFac.Size = new System.Drawing.Size(336, 24);
                        this.EntradaTipoFac.TabIndex = 5;
                        this.EntradaTipoFac.Table = null;
                        this.EntradaTipoFac.Text = "Facturas, Notas de Crédito y Débito";
                        this.EntradaTipoFac.TextKey = "F,NC,ND";
                        this.EntradaTipoFac.TextRaw = "Facturas, Notas de Crédito y Débito";
                        this.EntradaTipoFac.TipWhenBlank = "";
                        this.EntradaTipoFac.ToolTipText = "";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(20, 76);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(140, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Documentos";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDeTalonario
                        // 
                        this.EntradaDeTalonario.AutoHeight = false;
                        this.EntradaDeTalonario.AutoNav = true;
                        this.EntradaDeTalonario.AutoTab = true;
                        this.EntradaDeTalonario.DetailField = null;
                        this.EntradaDeTalonario.Filter = null;
                        this.EntradaDeTalonario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDeTalonario.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaDeTalonario.KeyField = null;
                        this.EntradaDeTalonario.Location = new System.Drawing.Point(160, 132);
                        this.EntradaDeTalonario.MaxLenght = 32767;
                        this.EntradaDeTalonario.Name = "EntradaDeTalonario";
                        this.EntradaDeTalonario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDeTalonario.ReadOnly = false;
                        this.EntradaDeTalonario.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaDeTalonario.Size = new System.Drawing.Size(116, 24);
                        this.EntradaDeTalonario.TabIndex = 9;
                        this.EntradaDeTalonario.Table = null;
                        this.EntradaDeTalonario.Text = "No";
                        this.EntradaDeTalonario.TextKey = "0";
                        this.EntradaDeTalonario.TextRaw = "No";
                        this.EntradaDeTalonario.TipWhenBlank = "";
                        this.EntradaDeTalonario.ToolTipText = "";
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(20, 132);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(140, 24);
                        this.label9.TabIndex = 8;
                        this.label9.Text = "Usa Talonarios";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(625, 467);
                        this.Controls.Add(this.EntradaDeTalonario);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EntradaTipoFac);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.note1);
                        this.Controls.Add(this.EntradaSucursal);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.txtBps);
                        this.Controls.Add(this.txtPuerto);
                        this.Controls.Add(this.txtModelo);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.cmdEstacionSeleccionar);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.txtCarga);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaEstacion);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label16);
                        this.Name = "Editar";
                        this.Controls.SetChildIndex(this.Label16, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.EntradaEstacion, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.txtCarga, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.cmdEstacionSeleccionar, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.txtModelo, 0);
                        this.Controls.SetChildIndex(this.txtPuerto, 0);
                        this.Controls.SetChildIndex(this.txtBps, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaSucursal, 0);
                        this.Controls.SetChildIndex(this.note1, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaTipoFac, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.EntradaDeTalonario, 0);
                        this.ResumeLayout(false);

		}
		#endregion

		public override Lfx.Types.OperationResult Edit(int lId)
		{
			if(!Lui.Login.LoginData.Access(this.Workspace.CurrentUser, "global.admin"))
				return new Lfx.Types.NoAccessOperationResult();

			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("pvs", "id_pv", lId);

			if(Registro == null)
			{
				return new Lfx.Types.FailureOperationResult("El registro no existe");
			}
			else
			{
				m_Nuevo = false;

				EntradaNumero.Text = System.Convert.ToString(Registro["id_pv"]);
				m_Id = System.Convert.ToInt32(Registro["id_pv"]);

				EntradaTipo.TextKey = System.Convert.ToString(Registro["tipo"]);
                                EntradaTipoFac.TextKey = System.Convert.ToString(Registro["tipo_fac"]);
                                EntradaDeTalonario.TextKey = System.Convert.ToString(Registro["detalonario"]);
				EntradaSucursal.TextInt = System.Convert.ToInt32(Registro["id_sucursal"]);
				EntradaEstacion.Text = System.Convert.ToString(Registro["estacion"]);
				txtCarga.TextKey = System.Convert.ToString(Registro["carga"]);

				txtModelo.TextKey = System.Convert.ToString(Registro["modelo"]);
				txtPuerto.TextKey = System.Convert.ToString(Registro["puerto"]);
				txtBps.TextKey = System.Convert.ToString(Registro["bps"]);

				this.Text = "Punto de Venta " + EntradaNumero.Text;
				return new Lfx.Types.SuccessOperationResult();
			}
		}

		public override Lfx.Types.OperationResult Create()
		{
			EntradaNumero.Text = this.Workspace.DefaultDataBase.FieldInt("SELECT MAX(id_pv)+1 FROM pvs").ToString();
			return new Lfx.Types.SuccessOperationResult();
		}

		public override Lfx.Types.OperationResult Save()
		{
			Lfx.Types.OperationResult ResultadoGuardar = new Lfx.Types.SuccessOperationResult();

			ResultadoGuardar = ValidateData();

			if(ResultadoGuardar.Success == true)
			{
                                DataView.BeginTransaction();

                                Lfx.Data.SqlTableCommandBuilder Comando;
                                if (m_Nuevo) {
                                        Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "pvs");
                                        Comando.Fields.AddWithValue("fecha", Lfx.Data.SqlFunctions.Now);
                                } else {
                                        Comando = new Lfx.Data.SqlUpdateBuilder(DataView.DataBase, "pvs");
                                        Comando.WhereClause = new Lfx.Data.SqlWhereBuilder("id_pv", m_Id);
                                }

				Comando.Fields.AddWithValue("numero", Lfx.Types.Parsing.ParseInt(EntradaNumero.Text));
				Comando.Fields.AddWithValue("id_sucursal", Lfx.Data.DataBase.ConvertZeroToDBNull(EntradaSucursal.TextInt));
				Comando.Fields.AddWithValue("tipo", Lfx.Types.Parsing.ParseInt(EntradaTipo.TextKey));
                                Comando.Fields.AddWithValue("tipo_fac", EntradaTipoFac.TextKey);
                                Comando.Fields.AddWithValue("detalonario", Lfx.Types.Parsing.ParseInt(EntradaDeTalonario.TextKey));
				Comando.Fields.AddWithValue("estacion", EntradaEstacion.Text);
				Comando.Fields.AddWithValue("carga", Lfx.Types.Parsing.ParseInt(txtCarga.TextKey));
				Comando.Fields.AddWithValue("modelo", Lfx.Types.Parsing.ParseInt(txtModelo.TextKey));
				Comando.Fields.AddWithValue("puerto", Lfx.Types.Parsing.ParseInt(txtPuerto.TextKey));
				Comando.Fields.AddWithValue("bps", Lfx.Types.Parsing.ParseInt(txtBps.TextKey));

				try
				{
                                        DataView.Execute(Comando);
				}
				catch(Exception ex)
				{
					return new Lfx.Types.FailureOperationResult(ex.ToString());
				}

				if(m_Nuevo)
                                        m_Id = DataView.DataBase.FieldInt("SELECT LAST_INSERT_ID()");

                                DataView.DataBase.Commit();

                                if (m_Nuevo && ControlDestino != null) {
                                        ControlDestino.Text = m_Id.ToString();
                                        ControlDestino.Focus();
                                }

				m_Nuevo = false;
				ResultadoGuardar = base.Save();
			}
			
			return ResultadoGuardar;
		}

		private void cmdEstacionSeleccionar_Click(object sender, System.EventArgs e)
		{
                        Lui.Forms.WorkstationSelectorForm SelEst = new Lui.Forms.WorkstationSelectorForm();
			SelEst.Estacion = EntradaEstacion.Text;
			if(SelEst.ShowDialog() == DialogResult.OK)
				EntradaEstacion.Text = SelEst.Estacion;
		}

		private void txtTipo_TextChanged(object sender, System.EventArgs e)
		{
                        if (EntradaTipo.TextKey == "2") {
                                txtModelo.Enabled = true;
                                txtPuerto.Enabled = true;
                                txtBps.Enabled = true;
                                txtCarga.Enabled = false;
                        } else {
                                txtModelo.Enabled = false;
                                txtPuerto.Enabled = false;
                                txtBps.Enabled = false;
                                txtCarga.Enabled = true;
                        }
		}
	}
}

