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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
        public partial class Editar : Lui.Forms.EditForm
        {
                private Lui.Forms.ListView ListaCampos;
                private System.Windows.Forms.ColumnHeader Campo;
                private System.Windows.Forms.ColumnHeader Extra;
                private System.Windows.Forms.TabControl TabControl;
                private System.Windows.Forms.TabPage TabGeneral;
                private System.Windows.Forms.TabPage TabCampos;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox txtCopias;
                internal System.Windows.Forms.Label label6;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.TextBox EntradaCodigo;
                internal Lui.Forms.TextBox EntradaNombre;
                private System.Windows.Forms.ColumnHeader Valor;
                private System.Windows.Forms.ColumnHeader CampoX;
                private System.Windows.Forms.ColumnHeader CampoY;
                private System.Windows.Forms.ColumnHeader CampoWidth;
                private System.Windows.Forms.ColumnHeader CampoHeight;
                private System.Windows.Forms.ColumnHeader Texto;
                internal System.Windows.Forms.Label label8;
                internal Lui.Forms.ComboBox EntradaMembrete;
                internal Lui.Forms.ComboBox EntradaPapelTamano;
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Clean up any resources being used.
                /// </summary>
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Designer generated code
                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        this.ListaCampos = new Lui.Forms.ListView();
                        this.Campo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.CampoX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.CampoY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.CampoWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.CampoHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Texto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Extra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.TabControl = new System.Windows.Forms.TabControl();
                        this.TabGeneral = new System.Windows.Forms.TabPage();
                        this.EntradaLandscape = new Lui.Forms.ComboBox();
                        this.cmdCargar = new Lui.Forms.Button();
                        this.cmdGuardar = new Lui.Forms.Button();
                        this.EntradaFuenteTamano = new Lui.Forms.TextBox();
                        this.EntradaFuente = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaPapelTamano = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.EntradaCodigo = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaMembrete = new Lui.Forms.ComboBox();
                        this.txtCopias = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.TabCampos = new System.Windows.Forms.TabPage();
                        this.label2 = new System.Windows.Forms.Label();
                        this.ZoomBar = new System.Windows.Forms.TrackBar();
                        this.ImagePreview = new System.Windows.Forms.PictureBox();
                        this.BotonQuitar = new Lui.Forms.Button();
                        this.cmdAgregar = new Lui.Forms.Button();
                        this.TabControl.SuspendLayout();
                        this.TabGeneral.SuspendLayout();
                        this.TabCampos.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // ListaCampos
                        // 
                        this.ListaCampos.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaCampos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campo,
            this.Valor,
            this.CampoX,
            this.CampoY,
            this.CampoWidth,
            this.CampoHeight,
            this.Texto,
            this.Extra});
                        this.ListaCampos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ListaCampos.FullRowSelect = true;
                        this.ListaCampos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaCampos.HideSelection = false;
                        this.ListaCampos.LabelWrap = false;
                        this.ListaCampos.Location = new System.Drawing.Point(8, 8);
                        this.ListaCampos.MultiSelect = false;
                        this.ListaCampos.Name = "ListaCampos";
                        this.ListaCampos.Size = new System.Drawing.Size(140, 280);
                        this.ListaCampos.TabIndex = 0;
                        this.ListaCampos.UseCompatibleStateImageBehavior = false;
                        this.ListaCampos.View = System.Windows.Forms.View.Details;
                        this.ListaCampos.SelectedIndexChanged += new System.EventHandler(this.ListaCampos_SelectedIndexChanged);
                        this.ListaCampos.DoubleClick += new System.EventHandler(this.ListaCampos_DoubleClick);
                        // 
                        // Campo
                        // 
                        this.Campo.Text = "Hash";
                        this.Campo.Width = 0;
                        // 
                        // Valor
                        // 
                        this.Valor.Text = "Valor";
                        this.Valor.Width = 96;
                        // 
                        // CampoX
                        // 
                        this.CampoX.Text = "X";
                        this.CampoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.CampoX.Width = 32;
                        // 
                        // CampoY
                        // 
                        this.CampoY.Text = "Y";
                        this.CampoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.CampoY.Width = 32;
                        // 
                        // CampoWidth
                        // 
                        this.CampoWidth.Text = "Ancho";
                        this.CampoWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.CampoWidth.Width = 32;
                        // 
                        // CampoHeight
                        // 
                        this.CampoHeight.Text = "Alto";
                        this.CampoHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.CampoHeight.Width = 32;
                        // 
                        // Texto
                        // 
                        this.Texto.Text = "Texto";
                        this.Texto.Width = 120;
                        // 
                        // Extra
                        // 
                        this.Extra.Text = "Extra";
                        this.Extra.Width = 0;
                        // 
                        // TabControl
                        // 
                        this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.TabControl.Controls.Add(this.TabGeneral);
                        this.TabControl.Controls.Add(this.TabCampos);
                        this.TabControl.Location = new System.Drawing.Point(8, 8);
                        this.TabControl.Name = "TabControl";
                        this.TabControl.SelectedIndex = 0;
                        this.TabControl.Size = new System.Drawing.Size(854, 502);
                        this.TabControl.TabIndex = 0;
                        // 
                        // TabGeneral
                        // 
                        this.TabGeneral.Controls.Add(this.EntradaLandscape);
                        this.TabGeneral.Controls.Add(this.cmdCargar);
                        this.TabGeneral.Controls.Add(this.cmdGuardar);
                        this.TabGeneral.Controls.Add(this.EntradaFuenteTamano);
                        this.TabGeneral.Controls.Add(this.EntradaFuente);
                        this.TabGeneral.Controls.Add(this.label4);
                        this.TabGeneral.Controls.Add(this.label5);
                        this.TabGeneral.Controls.Add(this.EntradaPapelTamano);
                        this.TabGeneral.Controls.Add(this.label8);
                        this.TabGeneral.Controls.Add(this.EntradaNombre);
                        this.TabGeneral.Controls.Add(this.label7);
                        this.TabGeneral.Controls.Add(this.EntradaCodigo);
                        this.TabGeneral.Controls.Add(this.label6);
                        this.TabGeneral.Controls.Add(this.EntradaMembrete);
                        this.TabGeneral.Controls.Add(this.txtCopias);
                        this.TabGeneral.Controls.Add(this.label1);
                        this.TabGeneral.Location = new System.Drawing.Point(4, 24);
                        this.TabGeneral.Name = "TabGeneral";
                        this.TabGeneral.Size = new System.Drawing.Size(846, 474);
                        this.TabGeneral.TabIndex = 0;
                        this.TabGeneral.Text = "General";
                        // 
                        // EntradaLandscape
                        // 
                        this.EntradaLandscape.AutoHeight = false;
                        this.EntradaLandscape.AutoNav = true;
                        this.EntradaLandscape.AutoTab = true;
                        this.EntradaLandscape.DetailField = null;
                        this.EntradaLandscape.Filter = null;
                        this.EntradaLandscape.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaLandscape.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaLandscape.KeyField = null;
                        this.EntradaLandscape.Location = new System.Drawing.Point(264, 104);
                        this.EntradaLandscape.MaxLenght = 32767;
                        this.EntradaLandscape.Name = "EntradaLandscape";
                        this.EntradaLandscape.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLandscape.ReadOnly = false;
                        this.EntradaLandscape.SetData = new string[] {
        "alto|0",
        "apaisado|1"};
                        this.EntradaLandscape.Size = new System.Drawing.Size(96, 24);
                        this.EntradaLandscape.TabIndex = 6;
                        this.EntradaLandscape.Table = null;
                        this.EntradaLandscape.Text = "alto";
                        this.EntradaLandscape.TextKey = "0";
                        this.EntradaLandscape.TextRaw = "alto";
                        this.EntradaLandscape.TipWhenBlank = "";
                        this.EntradaLandscape.ToolTipText = "";
                        this.EntradaLandscape.TextChanged += new System.EventHandler(this.EntradaPapelTamano_TextChanged);
                        // 
                        // cmdCargar
                        // 
                        this.cmdCargar.AutoHeight = false;
                        this.cmdCargar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdCargar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdCargar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCargar.Image = null;
                        this.cmdCargar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdCargar.Location = new System.Drawing.Point(284, 248);
                        this.cmdCargar.Name = "cmdCargar";
                        this.cmdCargar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdCargar.ReadOnly = false;
                        this.cmdCargar.Size = new System.Drawing.Size(104, 28);
                        this.cmdCargar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdCargar.Subtext = "Tecla";
                        this.cmdCargar.TabIndex = 15;
                        this.cmdCargar.Text = "Cargar";
                        this.cmdCargar.ToolTipText = "";
                        this.cmdCargar.Click += new System.EventHandler(this.BotonCargar_Click);
                        // 
                        // cmdGuardar
                        // 
                        this.cmdGuardar.AutoHeight = false;
                        this.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdGuardar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdGuardar.Image = null;
                        this.cmdGuardar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdGuardar.Location = new System.Drawing.Point(168, 248);
                        this.cmdGuardar.Name = "cmdGuardar";
                        this.cmdGuardar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdGuardar.ReadOnly = false;
                        this.cmdGuardar.Size = new System.Drawing.Size(104, 28);
                        this.cmdGuardar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdGuardar.Subtext = "Tecla";
                        this.cmdGuardar.TabIndex = 14;
                        this.cmdGuardar.Text = "Guardar";
                        this.cmdGuardar.ToolTipText = "";
                        this.cmdGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
                        // 
                        // EntradaFuenteTamano
                        // 
                        this.EntradaFuenteTamano.AutoHeight = false;
                        this.EntradaFuenteTamano.AutoNav = true;
                        this.EntradaFuenteTamano.AutoTab = true;
                        this.EntradaFuenteTamano.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaFuenteTamano.DecimalPlaces = -1;
                        this.EntradaFuenteTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFuenteTamano.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFuenteTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFuenteTamano.Location = new System.Drawing.Point(428, 160);
                        this.EntradaFuenteTamano.MaxLenght = 32767;
                        this.EntradaFuenteTamano.MultiLine = false;
                        this.EntradaFuenteTamano.Name = "EntradaFuenteTamano";
                        this.EntradaFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteTamano.PasswordChar = '\0';
                        this.EntradaFuenteTamano.Prefijo = "";
                        this.EntradaFuenteTamano.ReadOnly = false;
                        this.EntradaFuenteTamano.SelectOnFocus = true;
                        this.EntradaFuenteTamano.Size = new System.Drawing.Size(92, 24);
                        this.EntradaFuenteTamano.Sufijo = "ptos.";
                        this.EntradaFuenteTamano.TabIndex = 11;
                        this.EntradaFuenteTamano.TextRaw = "";
                        this.EntradaFuenteTamano.TipWhenBlank = "";
                        this.EntradaFuenteTamano.ToolTipText = "";
                        this.EntradaFuenteTamano.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // EntradaFuente
                        // 
                        this.EntradaFuente.AutoHeight = false;
                        this.EntradaFuente.AutoNav = true;
                        this.EntradaFuente.AutoTab = true;
                        this.EntradaFuente.DetailField = null;
                        this.EntradaFuente.Filter = null;
                        this.EntradaFuente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFuente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFuente.KeyField = null;
                        this.EntradaFuente.Location = new System.Drawing.Point(168, 160);
                        this.EntradaFuente.MaxLenght = 32767;
                        this.EntradaFuente.Name = "EntradaFuente";
                        this.EntradaFuente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuente.ReadOnly = false;
                        this.EntradaFuente.SetData = new string[] {
        "Predeterminada|*",
        "Serif|Bitstream Vera Serif",
        "Sans Serif|Bitstream Vera Sans",
        "Monoespaciada Bitstream|Bitstream Vera Sans Mono",
        "Monoespaciada Courier|Courier New"};
                        this.EntradaFuente.Size = new System.Drawing.Size(256, 24);
                        this.EntradaFuente.TabIndex = 10;
                        this.EntradaFuente.Table = null;
                        this.EntradaFuente.Text = "Predeterminada";
                        this.EntradaFuente.TextKey = "*";
                        this.EntradaFuente.TextRaw = "Predeterminada";
                        this.EntradaFuente.TipWhenBlank = "";
                        this.EntradaFuente.ToolTipText = "";
                        this.EntradaFuente.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(12, 160);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(156, 24);
                        this.label4.TabIndex = 9;
                        this.label4.Text = "Fuente";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(12, 132);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(156, 24);
                        this.label5.TabIndex = 7;
                        this.label5.Text = "Membrete";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPapelTamano
                        // 
                        this.EntradaPapelTamano.AutoHeight = false;
                        this.EntradaPapelTamano.AutoNav = true;
                        this.EntradaPapelTamano.AutoTab = true;
                        this.EntradaPapelTamano.DetailField = null;
                        this.EntradaPapelTamano.Filter = null;
                        this.EntradaPapelTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPapelTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPapelTamano.KeyField = null;
                        this.EntradaPapelTamano.Location = new System.Drawing.Point(168, 104);
                        this.EntradaPapelTamano.MaxLenght = 32767;
                        this.EntradaPapelTamano.Name = "EntradaPapelTamano";
                        this.EntradaPapelTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPapelTamano.ReadOnly = false;
                        this.EntradaPapelTamano.SetData = new string[] {
        "Oficio|legal",
        "Carta|letter",
        "A4|a4",
        "A5|a5",
        "Continuo|cont"};
                        this.EntradaPapelTamano.Size = new System.Drawing.Size(88, 24);
                        this.EntradaPapelTamano.TabIndex = 5;
                        this.EntradaPapelTamano.Table = null;
                        this.EntradaPapelTamano.Text = "A4";
                        this.EntradaPapelTamano.TextKey = "a4";
                        this.EntradaPapelTamano.TextRaw = "A4";
                        this.EntradaPapelTamano.TipWhenBlank = "";
                        this.EntradaPapelTamano.ToolTipText = "";
                        this.EntradaPapelTamano.TextChanged += new System.EventHandler(this.EntradaPapelTamano_TextChanged);
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(12, 104);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(156, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Papel";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.AutoHeight = false;
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaNombre.Location = new System.Drawing.Point(168, 40);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = true;
                        this.EntradaNombre.SelectOnFocus = true;
                        this.EntradaNombre.Size = new System.Drawing.Size(256, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 3;
                        this.EntradaNombre.TabStop = false;
                        this.EntradaNombre.Text = "Factura A";
                        this.EntradaNombre.TextRaw = "Factura A";
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(12, 40);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(156, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Nombre";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo
                        // 
                        this.EntradaCodigo.AutoHeight = false;
                        this.EntradaCodigo.AutoNav = true;
                        this.EntradaCodigo.AutoTab = true;
                        this.EntradaCodigo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaCodigo.DecimalPlaces = -1;
                        this.EntradaCodigo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCodigo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCodigo.Location = new System.Drawing.Point(168, 12);
                        this.EntradaCodigo.MaxLenght = 32767;
                        this.EntradaCodigo.MultiLine = false;
                        this.EntradaCodigo.Name = "EntradaCodigo";
                        this.EntradaCodigo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo.PasswordChar = '\0';
                        this.EntradaCodigo.Prefijo = "";
                        this.EntradaCodigo.ReadOnly = true;
                        this.EntradaCodigo.SelectOnFocus = true;
                        this.EntradaCodigo.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCodigo.Sufijo = "";
                        this.EntradaCodigo.TabIndex = 1;
                        this.EntradaCodigo.TabStop = false;
                        this.EntradaCodigo.Text = "A";
                        this.EntradaCodigo.TextRaw = "A";
                        this.EntradaCodigo.TipWhenBlank = "";
                        this.EntradaCodigo.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(12, 12);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(156, 24);
                        this.label6.TabIndex = 0;
                        this.label6.Text = "Código";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMembrete
                        // 
                        this.EntradaMembrete.AutoHeight = false;
                        this.EntradaMembrete.AutoNav = true;
                        this.EntradaMembrete.AutoTab = true;
                        this.EntradaMembrete.DetailField = null;
                        this.EntradaMembrete.Filter = null;
                        this.EntradaMembrete.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMembrete.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMembrete.KeyField = null;
                        this.EntradaMembrete.Location = new System.Drawing.Point(168, 132);
                        this.EntradaMembrete.MaxLenght = 32767;
                        this.EntradaMembrete.Name = "EntradaMembrete";
                        this.EntradaMembrete.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMembrete.ReadOnly = false;
                        this.EntradaMembrete.SetData = new string[] {
        "Ninguno|0",
        "Encabezado|1",
        "Recuadro|2"};
                        this.EntradaMembrete.Size = new System.Drawing.Size(256, 24);
                        this.EntradaMembrete.TabIndex = 8;
                        this.EntradaMembrete.Table = null;
                        this.EntradaMembrete.Text = "Ninguno";
                        this.EntradaMembrete.TextKey = "0";
                        this.EntradaMembrete.TextRaw = "Ninguno";
                        this.EntradaMembrete.TipWhenBlank = "";
                        this.EntradaMembrete.ToolTipText = "";
                        // 
                        // txtCopias
                        // 
                        this.txtCopias.AutoHeight = false;
                        this.txtCopias.AutoNav = true;
                        this.txtCopias.AutoTab = true;
                        this.txtCopias.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCopias.DecimalPlaces = -1;
                        this.txtCopias.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCopias.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtCopias.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCopias.Location = new System.Drawing.Point(168, 196);
                        this.txtCopias.MaxLenght = 32767;
                        this.txtCopias.MultiLine = false;
                        this.txtCopias.Name = "txtCopias";
                        this.txtCopias.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCopias.PasswordChar = '\0';
                        this.txtCopias.Prefijo = "";
                        this.txtCopias.ReadOnly = true;
                        this.txtCopias.SelectOnFocus = true;
                        this.txtCopias.Size = new System.Drawing.Size(56, 24);
                        this.txtCopias.Sufijo = "";
                        this.txtCopias.TabIndex = 13;
                        this.txtCopias.TabStop = false;
                        this.txtCopias.Text = "1";
                        this.txtCopias.TextRaw = "1";
                        this.txtCopias.TipWhenBlank = "";
                        this.txtCopias.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(12, 196);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(156, 24);
                        this.label1.TabIndex = 12;
                        this.label1.Text = "Copias consecutivas";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // TabCampos
                        // 
                        this.TabCampos.Controls.Add(this.label2);
                        this.TabCampos.Controls.Add(this.ZoomBar);
                        this.TabCampos.Controls.Add(this.ImagePreview);
                        this.TabCampos.Controls.Add(this.BotonQuitar);
                        this.TabCampos.Controls.Add(this.cmdAgregar);
                        this.TabCampos.Controls.Add(this.ListaCampos);
                        this.TabCampos.Location = new System.Drawing.Point(4, 24);
                        this.TabCampos.Name = "TabCampos";
                        this.TabCampos.Size = new System.Drawing.Size(846, 474);
                        this.TabCampos.TabIndex = 1;
                        this.TabCampos.Text = "Campos";
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label2.Location = new System.Drawing.Point(8, 400);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(140, 24);
                        this.label2.TabIndex = 112;
                        this.label2.Text = "Escala";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ZoomBar
                        // 
                        this.ZoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ZoomBar.LargeChange = 10;
                        this.ZoomBar.Location = new System.Drawing.Point(8, 424);
                        this.ZoomBar.Maximum = 250;
                        this.ZoomBar.Minimum = 25;
                        this.ZoomBar.Name = "ZoomBar";
                        this.ZoomBar.Size = new System.Drawing.Size(140, 45);
                        this.ZoomBar.TabIndex = 111;
                        this.ZoomBar.Value = 100;
                        this.ZoomBar.Scroll += new System.EventHandler(this.ZoomBar_Scroll);
                        // 
                        // ImagePreview
                        // 
                        this.ImagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ImagePreview.BackColor = System.Drawing.Color.Ivory;
                        this.ImagePreview.Location = new System.Drawing.Point(156, 4);
                        this.ImagePreview.Name = "ImagePreview";
                        this.ImagePreview.Size = new System.Drawing.Size(686, 466);
                        this.ImagePreview.TabIndex = 105;
                        this.ImagePreview.TabStop = false;
                        this.ImagePreview.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagePreview_Paint);
                        this.ImagePreview.DoubleClick += new System.EventHandler(this.ImagenPreview_DoubleClick);
                        this.ImagePreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseDown);
                        this.ImagePreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseMove);
                        this.ImagePreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseUp);
                        // 
                        // BotonQuitar
                        // 
                        this.BotonQuitar.AutoHeight = false;
                        this.BotonQuitar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitar.Image = null;
                        this.BotonQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitar.Location = new System.Drawing.Point(8, 292);
                        this.BotonQuitar.Name = "BotonQuitar";
                        this.BotonQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitar.ReadOnly = false;
                        this.BotonQuitar.Size = new System.Drawing.Size(68, 28);
                        this.BotonQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitar.Subtext = "Tecla";
                        this.BotonQuitar.TabIndex = 110;
                        this.BotonQuitar.Text = "Quitar";
                        this.BotonQuitar.ToolTipText = "";
                        this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
                        // 
                        // cmdAgregar
                        // 
                        this.cmdAgregar.AutoHeight = false;
                        this.cmdAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdAgregar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdAgregar.Image = null;
                        this.cmdAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdAgregar.Location = new System.Drawing.Point(80, 292);
                        this.cmdAgregar.Name = "cmdAgregar";
                        this.cmdAgregar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdAgregar.ReadOnly = false;
                        this.cmdAgregar.Size = new System.Drawing.Size(68, 28);
                        this.cmdAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdAgregar.Subtext = "Tecla";
                        this.cmdAgregar.TabIndex = 109;
                        this.cmdAgregar.Text = "Agregar";
                        this.cmdAgregar.ToolTipText = "";
                        this.cmdAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(870, 579);
                        this.Controls.Add(this.TabControl);
                        this.Name = "Editar";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editar_KeyDown);
                        this.Controls.SetChildIndex(this.TabControl, 0);
                        this.TabControl.ResumeLayout(false);
                        this.TabGeneral.ResumeLayout(false);
                        this.TabCampos.ResumeLayout(false);
                        this.TabCampos.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
                        this.ResumeLayout(false);

                }
                #endregion

                private Lui.Forms.Button BotonQuitar;
                private Lui.Forms.Button cmdAgregar;
                internal Label label5;
                private PictureBox ImagePreview;
                internal Lui.Forms.TextBox EntradaFuenteTamano;
                internal Lui.Forms.ComboBox EntradaFuente;
                internal Label label4;
                internal Label label2;
                private TrackBar ZoomBar;
                private Lui.Forms.Button cmdCargar;
                private Lui.Forms.Button cmdGuardar;
                internal Lui.Forms.ComboBox EntradaLandscape;
        }
}
