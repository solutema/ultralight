// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lfc.Comprobantes.Plantillas
{
        public partial class Editar : Lui.Forms.EditForm
        {
                private Lui.Forms.ListView lvCampos;
                private System.Windows.Forms.ColumnHeader Campo;
                private System.Windows.Forms.ColumnHeader Extra;
                private System.Windows.Forms.TabControl TabControl;
                private System.Windows.Forms.TabPage TabGeneral;
                private System.Windows.Forms.TabPage TabCampos;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox txtCopias;
                internal System.Windows.Forms.Label label6;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.TextBox txtCodigo;
                internal Lui.Forms.TextBox txtNombre;
                private System.Windows.Forms.ColumnHeader Valor;
                private System.Windows.Forms.ColumnHeader CampoX;
                private System.Windows.Forms.ColumnHeader CampoY;
                private System.Windows.Forms.ColumnHeader CampoWidth;
                private System.Windows.Forms.ColumnHeader CampoHeight;
                private System.Windows.Forms.ColumnHeader Texto;
                internal System.Windows.Forms.Label label8;
                internal Lui.Forms.ComboBox txtMembrete;
                internal Lui.Forms.ComboBox txtPapelTamano;
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
                        this.lvCampos = new Lui.Forms.ListView();
                        this.Campo = new System.Windows.Forms.ColumnHeader();
                        this.Valor = new System.Windows.Forms.ColumnHeader();
                        this.CampoX = new System.Windows.Forms.ColumnHeader();
                        this.CampoY = new System.Windows.Forms.ColumnHeader();
                        this.CampoWidth = new System.Windows.Forms.ColumnHeader();
                        this.CampoHeight = new System.Windows.Forms.ColumnHeader();
                        this.Texto = new System.Windows.Forms.ColumnHeader();
                        this.Extra = new System.Windows.Forms.ColumnHeader();
                        this.TabControl = new System.Windows.Forms.TabControl();
                        this.TabGeneral = new System.Windows.Forms.TabPage();
                        this.txtLandscape = new Lui.Forms.ComboBox();
                        this.cmdCargar = new Lui.Forms.Button();
                        this.cmdGuardar = new Lui.Forms.Button();
                        this.txtFuenteTamano = new Lui.Forms.TextBox();
                        this.txtFuente = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtPapelTamano = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.txtNombre = new Lui.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtCodigo = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.txtMembrete = new Lui.Forms.ComboBox();
                        this.txtCopias = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.TabCampos = new System.Windows.Forms.TabPage();
                        this.label2 = new System.Windows.Forms.Label();
                        this.ZoomBar = new System.Windows.Forms.TrackBar();
                        this.pctPreview = new System.Windows.Forms.PictureBox();
                        this.cmdQuitar = new Lui.Forms.Button();
                        this.cmdAgregar = new Lui.Forms.Button();
                        this.TabControl.SuspendLayout();
                        this.TabGeneral.SuspendLayout();
                        this.TabCampos.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(654, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(762, 8);
                        // 
                        // lvCampos
                        // 
                        this.lvCampos.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvCampos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Campo,
            this.Valor,
            this.CampoX,
            this.CampoY,
            this.CampoWidth,
            this.CampoHeight,
            this.Texto,
            this.Extra});
                        this.lvCampos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lvCampos.FullRowSelect = true;
                        this.lvCampos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvCampos.HideSelection = false;
                        this.lvCampos.LabelWrap = false;
                        this.lvCampos.Location = new System.Drawing.Point(8, 8);
                        this.lvCampos.MultiSelect = false;
                        this.lvCampos.Name = "lvCampos";
                        this.lvCampos.Size = new System.Drawing.Size(140, 280);
                        this.lvCampos.TabIndex = 0;
                        this.lvCampos.UseCompatibleStateImageBehavior = false;
                        this.lvCampos.View = System.Windows.Forms.View.Details;
                        this.lvCampos.DoubleClick += new System.EventHandler(this.lvCampos_DoubleClick);
                        this.lvCampos.SelectedIndexChanged += new System.EventHandler(this.lvCampos_SelectedIndexChanged);
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
                        this.TabGeneral.Controls.Add(this.txtLandscape);
                        this.TabGeneral.Controls.Add(this.cmdCargar);
                        this.TabGeneral.Controls.Add(this.cmdGuardar);
                        this.TabGeneral.Controls.Add(this.txtFuenteTamano);
                        this.TabGeneral.Controls.Add(this.txtFuente);
                        this.TabGeneral.Controls.Add(this.label4);
                        this.TabGeneral.Controls.Add(this.label5);
                        this.TabGeneral.Controls.Add(this.txtPapelTamano);
                        this.TabGeneral.Controls.Add(this.label8);
                        this.TabGeneral.Controls.Add(this.txtNombre);
                        this.TabGeneral.Controls.Add(this.label7);
                        this.TabGeneral.Controls.Add(this.txtCodigo);
                        this.TabGeneral.Controls.Add(this.label6);
                        this.TabGeneral.Controls.Add(this.txtMembrete);
                        this.TabGeneral.Controls.Add(this.txtCopias);
                        this.TabGeneral.Controls.Add(this.label1);
                        this.TabGeneral.Location = new System.Drawing.Point(4, 24);
                        this.TabGeneral.Name = "TabGeneral";
                        this.TabGeneral.Size = new System.Drawing.Size(846, 474);
                        this.TabGeneral.TabIndex = 0;
                        this.TabGeneral.Text = "General";
                        // 
                        // txtLandscape
                        // 
                        this.txtLandscape.AutoNav = true;
                        this.txtLandscape.AutoTab = true;
                        this.txtLandscape.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtLandscape.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtLandscape.Location = new System.Drawing.Point(264, 104);
                        this.txtLandscape.MaxLenght = 32767;
                        this.txtLandscape.Name = "txtLandscape";
                        this.txtLandscape.Padding = new System.Windows.Forms.Padding(2);
                        this.txtLandscape.ReadOnly = false;
                        this.txtLandscape.SetData = new string[] {
        "alto|0",
        "apaisado|1"};
                        this.txtLandscape.Size = new System.Drawing.Size(96, 24);
                        this.txtLandscape.TabIndex = 6;
                        this.txtLandscape.Text = "alto";
                        this.txtLandscape.TextKey = "0";
                        this.txtLandscape.TipWhenBlank = "";
                        this.txtLandscape.ToolTipText = "";
                        this.txtLandscape.TextChanged += new System.EventHandler(this.txtPapelTamano_TextChanged);
                        // 
                        // cmdCargar
                        // 
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
                        this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
                        // 
                        // cmdGuardar
                        // 
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
                        this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
                        // 
                        // txtFuenteTamano
                        // 
                        this.txtFuenteTamano.AutoNav = true;
                        this.txtFuenteTamano.AutoTab = true;
                        this.txtFuenteTamano.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtFuenteTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFuenteTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFuenteTamano.Location = new System.Drawing.Point(428, 160);
                        this.txtFuenteTamano.MaxLenght = 32767;
                        this.txtFuenteTamano.Name = "txtFuenteTamano";
                        this.txtFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFuenteTamano.ReadOnly = false;
                        this.txtFuenteTamano.Size = new System.Drawing.Size(92, 24);
                        this.txtFuenteTamano.Sufijo = "ptos.";
                        this.txtFuenteTamano.TabIndex = 11;
                        this.txtFuenteTamano.TipWhenBlank = "";
                        this.txtFuenteTamano.ToolTipText = "";
                        this.txtFuenteTamano.TextChanged += new System.EventHandler(this.txtFuenteFuenteTamano_TextChanged);
                        // 
                        // txtFuente
                        // 
                        this.txtFuente.AutoNav = true;
                        this.txtFuente.AutoTab = true;
                        this.txtFuente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFuente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFuente.Location = new System.Drawing.Point(168, 160);
                        this.txtFuente.MaxLenght = 32767;
                        this.txtFuente.Name = "txtFuente";
                        this.txtFuente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFuente.ReadOnly = false;
                        this.txtFuente.SetData = new string[] {
        "Predeterminada|*",
        "Serif|Bitstream Vera Serif",
        "Sans Serif|Bitstream Vera Sans",
        "Monoespaciada Bitstream|Bitstream Vera Sans Mono",
        "Monoespaciada Courier|Courier New"};
                        this.txtFuente.Size = new System.Drawing.Size(256, 24);
                        this.txtFuente.TabIndex = 10;
                        this.txtFuente.Text = "Predeterminada";
                        this.txtFuente.TipWhenBlank = "";
                        this.txtFuente.ToolTipText = "";
                        this.txtFuente.TextChanged += new System.EventHandler(this.txtFuenteFuenteTamano_TextChanged);
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
                        // txtPapelTamano
                        // 
                        this.txtPapelTamano.AutoNav = true;
                        this.txtPapelTamano.AutoTab = true;
                        this.txtPapelTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPapelTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPapelTamano.Location = new System.Drawing.Point(168, 104);
                        this.txtPapelTamano.MaxLenght = 32767;
                        this.txtPapelTamano.Name = "txtPapelTamano";
                        this.txtPapelTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPapelTamano.ReadOnly = false;
                        this.txtPapelTamano.SetData = new string[] {
        "Oficio|legal",
        "Carta|letter",
        "A4|a4",
        "A5|a5",
        "Continuo|cont"};
                        this.txtPapelTamano.Size = new System.Drawing.Size(88, 24);
                        this.txtPapelTamano.TabIndex = 5;
                        this.txtPapelTamano.Text = "A4";
                        this.txtPapelTamano.TextKey = "a4";
                        this.txtPapelTamano.TipWhenBlank = "";
                        this.txtPapelTamano.ToolTipText = "";
                        this.txtPapelTamano.TextChanged += new System.EventHandler(this.txtPapelTamano_TextChanged);
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
                        // txtNombre
                        // 
                        this.txtNombre.AutoNav = true;
                        this.txtNombre.AutoTab = true;
                        this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtNombre.Location = new System.Drawing.Point(168, 40);
                        this.txtNombre.MaxLenght = 32767;
                        this.txtNombre.Name = "txtNombre";
                        this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNombre.ReadOnly = true;
                        this.txtNombre.Size = new System.Drawing.Size(256, 24);
                        this.txtNombre.TabIndex = 3;
                        this.txtNombre.TabStop = false;
                        this.txtNombre.Text = "Factura A";
                        this.txtNombre.TipWhenBlank = "";
                        this.txtNombre.ToolTipText = "";
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
                        // txtCodigo
                        // 
                        this.txtCodigo.AutoNav = true;
                        this.txtCodigo.AutoTab = true;
                        this.txtCodigo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtCodigo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCodigo.Location = new System.Drawing.Point(168, 12);
                        this.txtCodigo.MaxLenght = 32767;
                        this.txtCodigo.Name = "txtCodigo";
                        this.txtCodigo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCodigo.ReadOnly = true;
                        this.txtCodigo.Size = new System.Drawing.Size(56, 24);
                        this.txtCodigo.TabIndex = 1;
                        this.txtCodigo.TabStop = false;
                        this.txtCodigo.Text = "A";
                        this.txtCodigo.TipWhenBlank = "";
                        this.txtCodigo.ToolTipText = "";
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
                        // txtMembrete
                        // 
                        this.txtMembrete.AutoNav = true;
                        this.txtMembrete.AutoTab = true;
                        this.txtMembrete.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtMembrete.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtMembrete.Location = new System.Drawing.Point(168, 132);
                        this.txtMembrete.MaxLenght = 32767;
                        this.txtMembrete.Name = "txtMembrete";
                        this.txtMembrete.Padding = new System.Windows.Forms.Padding(2);
                        this.txtMembrete.ReadOnly = false;
                        this.txtMembrete.SetData = new string[] {
        "Ninguno|0",
        "Encabezado|1",
        "Recuadro|2"};
                        this.txtMembrete.Size = new System.Drawing.Size(256, 24);
                        this.txtMembrete.TabIndex = 8;
                        this.txtMembrete.Text = "Ninguno";
                        this.txtMembrete.TextKey = "0";
                        this.txtMembrete.TipWhenBlank = "";
                        this.txtMembrete.ToolTipText = "";
                        // 
                        // txtCopias
                        // 
                        this.txtCopias.AutoNav = true;
                        this.txtCopias.AutoTab = true;
                        this.txtCopias.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtCopias.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCopias.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCopias.Location = new System.Drawing.Point(168, 196);
                        this.txtCopias.MaxLenght = 32767;
                        this.txtCopias.Name = "txtCopias";
                        this.txtCopias.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCopias.ReadOnly = true;
                        this.txtCopias.Size = new System.Drawing.Size(56, 24);
                        this.txtCopias.TabIndex = 13;
                        this.txtCopias.TabStop = false;
                        this.txtCopias.Text = "1";
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
                        this.TabCampos.Controls.Add(this.pctPreview);
                        this.TabCampos.Controls.Add(this.cmdQuitar);
                        this.TabCampos.Controls.Add(this.cmdAgregar);
                        this.TabCampos.Controls.Add(this.lvCampos);
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
                        this.ZoomBar.Size = new System.Drawing.Size(140, 42);
                        this.ZoomBar.TabIndex = 111;
                        this.ZoomBar.Value = 100;
                        this.ZoomBar.Scroll += new System.EventHandler(this.ZoomBar_Scroll);
                        // 
                        // pctPreview
                        // 
                        this.pctPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.pctPreview.BackColor = System.Drawing.Color.Ivory;
                        this.pctPreview.Location = new System.Drawing.Point(156, 4);
                        this.pctPreview.Name = "pctPreview";
                        this.pctPreview.Size = new System.Drawing.Size(686, 466);
                        this.pctPreview.TabIndex = 105;
                        this.pctPreview.TabStop = false;
                        this.pctPreview.DoubleClick += new System.EventHandler(this.pctPreview_DoubleClick);
                        this.pctPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctPreview_MouseDown);
                        this.pctPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctPreview_MouseMove);
                        this.pctPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pctPreview_Paint);
                        this.pctPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctPreview_MouseUp);
                        // 
                        // cmdQuitar
                        // 
                        this.cmdQuitar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdQuitar.Image = null;
                        this.cmdQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdQuitar.Location = new System.Drawing.Point(8, 292);
                        this.cmdQuitar.Name = "cmdQuitar";
                        this.cmdQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdQuitar.ReadOnly = false;
                        this.cmdQuitar.Size = new System.Drawing.Size(68, 28);
                        this.cmdQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdQuitar.Subtext = "Tecla";
                        this.cmdQuitar.TabIndex = 110;
                        this.cmdQuitar.Text = "Quitar";
                        this.cmdQuitar.ToolTipText = "";
                        this.cmdQuitar.Click += new System.EventHandler(this.cmdQuitar_Click);
                        // 
                        // cmdAgregar
                        // 
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
                        this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
                        // 
                        // Editar
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(870, 579);
                        this.Controls.Add(this.TabControl);
                        this.Name = "Editar";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editar_KeyDown);
                        this.TabControl.ResumeLayout(false);
                        this.TabGeneral.ResumeLayout(false);
                        this.TabCampos.ResumeLayout(false);
                        this.TabCampos.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctPreview)).EndInit();
                        this.ResumeLayout(false);

                }
                #endregion

                private Lui.Forms.Button cmdQuitar;
                private Lui.Forms.Button cmdAgregar;
                internal Label label5;
                private PictureBox pctPreview;
                internal Lui.Forms.TextBox txtFuenteTamano;
                internal Lui.Forms.ComboBox txtFuente;
                internal Label label4;
                internal Label label2;
                private TrackBar ZoomBar;
                private Lui.Forms.Button cmdCargar;
                private Lui.Forms.Button cmdGuardar;
                internal Lui.Forms.ComboBox txtLandscape;
        }
}
