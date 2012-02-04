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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
        public partial class Editar
        {
                private Lui.Forms.ListView ListaCampos;
                private System.Windows.Forms.ColumnHeader ColCampo;
                private System.Windows.Forms.TabControl TabControl;
                private System.Windows.Forms.TabPage TabGeneral;
                private System.Windows.Forms.TabPage TabCampos;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaCopias;
                internal Lui.Forms.Label label6;
                internal Lui.Forms.Label label7;
                internal Lui.Forms.TextBox EntradaCodigo;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label label8;
                internal Lui.Forms.ComboBox EntradaPapelTamano;
                private System.ComponentModel.IContainer components = null;


                #region Designer generated code
                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        this.ListaCampos = new Lui.Forms.ListView();
                        this.ColCampo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.TabControl = new System.Windows.Forms.TabControl();
                        this.TabGeneral = new System.Windows.Forms.TabPage();
                        this.EntradaMargenes = new Lui.Forms.ComboBox();
                        this.EntradaMargenAbajo = new Lui.Forms.TextBox();
                        this.EntradaMargenArriba = new Lui.Forms.TextBox();
                        this.EntradaMargenDerecha = new Lui.Forms.TextBox();
                        this.EntradaMargenIzquierda = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaLandscape = new Lui.Forms.ComboBox();
                        this.EntradaFuenteTamano = new Lui.Forms.TextBox();
                        this.EntradaFuente = new Lui.Forms.ComboBox();
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaPapelTamano = new Lui.Forms.ComboBox();
                        this.label8 = new Lui.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaCodigo = new Lui.Forms.TextBox();
                        this.label6 = new Lui.Forms.Label();
                        this.EntradaCopias = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.TabCampos = new System.Windows.Forms.TabPage();
                        this.button1 = new Lui.Forms.Button();
                        this.button2 = new Lui.Forms.Button();
                        this.label2 = new Lui.Forms.Label();
                        this.ZoomBar = new System.Windows.Forms.TrackBar();
                        this.ImagePreview = new System.Windows.Forms.PictureBox();
                        this.BotonQuitar = new Lui.Forms.Button();
                        this.BotonAgregar = new Lui.Forms.Button();
                        this.TabControl.SuspendLayout();
                        this.TabGeneral.SuspendLayout();
                        this.TabCampos.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // ListaCampos
                        // 
                        this.ListaCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
                        this.ListaCampos.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaCampos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColCampo});
                        this.ListaCampos.FullRowSelect = true;
                        this.ListaCampos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaCampos.HideSelection = false;
                        this.ListaCampos.LabelWrap = false;
                        this.ListaCampos.Location = new System.Drawing.Point(8, 8);
                        this.ListaCampos.MultiSelect = false;
                        this.ListaCampos.Name = "ListaCampos";
                        this.ListaCampos.Size = new System.Drawing.Size(140, 234);
                        this.ListaCampos.Sorting = System.Windows.Forms.SortOrder.Ascending;
                        this.ListaCampos.TabIndex = 0;
                        this.ListaCampos.UseCompatibleStateImageBehavior = false;
                        this.ListaCampos.View = System.Windows.Forms.View.Details;
                        this.ListaCampos.SelectedIndexChanged += new System.EventHandler(this.ListaCampos_SelectedIndexChanged);
                        this.ListaCampos.DoubleClick += new System.EventHandler(this.ListaCampos_DoubleClick);
                        // 
                        // ColCampo
                        // 
                        this.ColCampo.Text = "Campo";
                        this.ColCampo.Width = 140;
                        // 
                        // TabControl
                        // 
                        this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.TabControl.Controls.Add(this.TabGeneral);
                        this.TabControl.Controls.Add(this.TabCampos);
                        this.TabControl.Location = new System.Drawing.Point(0, 0);
                        this.TabControl.Name = "TabControl";
                        this.TabControl.SelectedIndex = 0;
                        this.TabControl.Size = new System.Drawing.Size(870, 506);
                        this.TabControl.TabIndex = 0;
                        // 
                        // TabGeneral
                        // 
                        this.TabGeneral.Controls.Add(this.EntradaMargenes);
                        this.TabGeneral.Controls.Add(this.EntradaMargenAbajo);
                        this.TabGeneral.Controls.Add(this.EntradaMargenArriba);
                        this.TabGeneral.Controls.Add(this.EntradaMargenDerecha);
                        this.TabGeneral.Controls.Add(this.EntradaMargenIzquierda);
                        this.TabGeneral.Controls.Add(this.label3);
                        this.TabGeneral.Controls.Add(this.EntradaLandscape);
                        this.TabGeneral.Controls.Add(this.EntradaFuenteTamano);
                        this.TabGeneral.Controls.Add(this.EntradaFuente);
                        this.TabGeneral.Controls.Add(this.label4);
                        this.TabGeneral.Controls.Add(this.EntradaPapelTamano);
                        this.TabGeneral.Controls.Add(this.label8);
                        this.TabGeneral.Controls.Add(this.EntradaNombre);
                        this.TabGeneral.Controls.Add(this.label7);
                        this.TabGeneral.Controls.Add(this.EntradaCodigo);
                        this.TabGeneral.Controls.Add(this.label6);
                        this.TabGeneral.Controls.Add(this.EntradaCopias);
                        this.TabGeneral.Controls.Add(this.label1);
                        this.TabGeneral.Location = new System.Drawing.Point(4, 26);
                        this.TabGeneral.Name = "TabGeneral";
                        this.TabGeneral.Size = new System.Drawing.Size(862, 476);
                        this.TabGeneral.TabIndex = 0;
                        this.TabGeneral.Text = "General";
                        // 
                        // EntradaMargenes
                        // 
                        this.EntradaMargenes.AlwaysExpanded = true;
                        this.EntradaMargenes.AutoSize = true;
                        this.EntradaMargenes.Location = new System.Drawing.Point(172, 176);
                        this.EntradaMargenes.Name = "EntradaMargenes";
                        this.EntradaMargenes.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenes.SetData = new string[] {
        "Predeterminado|0",
        "Personalizado|1"};
                        this.EntradaMargenes.Size = new System.Drawing.Size(116, 40);
                        this.EntradaMargenes.TabIndex = 8;
                        this.EntradaMargenes.TextKey = "1";
                        this.EntradaMargenes.TextChanged += new System.EventHandler(this.EntradaMargenes_TextChanged);
                        // 
                        // EntradaMargenAbajo
                        // 
                        this.EntradaMargenAbajo.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenAbajo.Location = new System.Drawing.Point(392, 192);
                        this.EntradaMargenAbajo.Name = "EntradaMargenAbajo";
                        this.EntradaMargenAbajo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenAbajo.PlaceholderText = "auto";
                        this.EntradaMargenAbajo.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenAbajo.Sufijo = "aba.";
                        this.EntradaMargenAbajo.TabIndex = 11;
                        this.EntradaMargenAbajo.Text = "0";
                        // 
                        // EntradaMargenArriba
                        // 
                        this.EntradaMargenArriba.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenArriba.Location = new System.Drawing.Point(392, 160);
                        this.EntradaMargenArriba.Name = "EntradaMargenArriba";
                        this.EntradaMargenArriba.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenArriba.PlaceholderText = "auto";
                        this.EntradaMargenArriba.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenArriba.Sufijo = "arr.";
                        this.EntradaMargenArriba.TabIndex = 10;
                        this.EntradaMargenArriba.Text = "0";
                        // 
                        // EntradaMargenDerecha
                        // 
                        this.EntradaMargenDerecha.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenDerecha.Location = new System.Drawing.Point(492, 176);
                        this.EntradaMargenDerecha.Name = "EntradaMargenDerecha";
                        this.EntradaMargenDerecha.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenDerecha.PlaceholderText = "auto";
                        this.EntradaMargenDerecha.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenDerecha.Sufijo = "der.";
                        this.EntradaMargenDerecha.TabIndex = 12;
                        this.EntradaMargenDerecha.Text = "0";
                        // 
                        // EntradaMargenIzquierda
                        // 
                        this.EntradaMargenIzquierda.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenIzquierda.Location = new System.Drawing.Point(296, 176);
                        this.EntradaMargenIzquierda.Name = "EntradaMargenIzquierda";
                        this.EntradaMargenIzquierda.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenIzquierda.PlaceholderText = "auto";
                        this.EntradaMargenIzquierda.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenIzquierda.Sufijo = "izq.";
                        this.EntradaMargenIzquierda.TabIndex = 9;
                        this.EntradaMargenIzquierda.Text = "0";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(16, 176);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(156, 24);
                        this.label3.TabIndex = 7;
                        this.label3.Text = "Márgenes";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLandscape
                        // 
                        this.EntradaLandscape.AlwaysExpanded = true;
                        this.EntradaLandscape.AutoSize = true;
                        this.EntradaLandscape.Location = new System.Drawing.Point(268, 80);
                        this.EntradaLandscape.Name = "EntradaLandscape";
                        this.EntradaLandscape.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLandscape.SetData = new string[] {
        "alto|0",
        "apaisado|1"};
                        this.EntradaLandscape.Size = new System.Drawing.Size(96, 40);
                        this.EntradaLandscape.TabIndex = 6;
                        this.EntradaLandscape.TextKey = "0";
                        this.EntradaLandscape.TextChanged += new System.EventHandler(this.EntradaPapelTamano_TextChanged);
                        // 
                        // EntradaFuenteTamano
                        // 
                        this.EntradaFuenteTamano.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaFuenteTamano.DecimalPlaces = 2;
                        this.EntradaFuenteTamano.Location = new System.Drawing.Point(432, 224);
                        this.EntradaFuenteTamano.Name = "EntradaFuenteTamano";
                        this.EntradaFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteTamano.Size = new System.Drawing.Size(116, 24);
                        this.EntradaFuenteTamano.Sufijo = "ptos.";
                        this.EntradaFuenteTamano.TabIndex = 17;
                        this.EntradaFuenteTamano.Text = "10.00";
                        this.EntradaFuenteTamano.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // EntradaFuente
                        // 
                        this.EntradaFuente.AlwaysExpanded = true;
                        this.EntradaFuente.AutoSize = true;
                        this.EntradaFuente.Location = new System.Drawing.Point(172, 224);
                        this.EntradaFuente.Name = "EntradaFuente";
                        this.EntradaFuente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuente.SetData = new string[] {
        "Predeterminada|*",
        "Vera Serif|Bitstream Vera Serif",
        "Vera Sans Serif|Bitstream Vera Sans",
        "Vera Monoespaciada|Bitstream Vera Sans Mono",
        "Segoe UI|Segoe UI",
        "Courier|Courier New"};
                        this.EntradaFuente.Size = new System.Drawing.Size(256, 91);
                        this.EntradaFuente.TabIndex = 16;
                        this.EntradaFuente.TextKey = "*";
                        this.EntradaFuente.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(16, 224);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(156, 24);
                        this.label4.TabIndex = 15;
                        this.label4.Text = "Fuente";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPapelTamano
                        // 
                        this.EntradaPapelTamano.AlwaysExpanded = true;
                        this.EntradaPapelTamano.AutoSize = true;
                        this.EntradaPapelTamano.Location = new System.Drawing.Point(172, 80);
                        this.EntradaPapelTamano.Name = "EntradaPapelTamano";
                        this.EntradaPapelTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPapelTamano.SetData = new string[] {
        "Oficio|legal",
        "Carta|letter",
        "A4|a4",
        "A5|a5",
        "Continuo|cont"};
                        this.EntradaPapelTamano.Size = new System.Drawing.Size(88, 91);
                        this.EntradaPapelTamano.TabIndex = 5;
                        this.EntradaPapelTamano.TextKey = "a4";
                        this.EntradaPapelTamano.TextChanged += new System.EventHandler(this.EntradaPapelTamano_TextChanged);
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(16, 80);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(156, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Papel";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(172, 48);
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.Size = new System.Drawing.Size(284, 24);
                        this.EntradaNombre.TabIndex = 3;
                        this.EntradaNombre.Text = "Factura A";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(16, 48);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(156, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Nombre";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo
                        // 
                        this.EntradaCodigo.Location = new System.Drawing.Point(172, 16);
                        this.EntradaCodigo.Name = "EntradaCodigo";
                        this.EntradaCodigo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo.Size = new System.Drawing.Size(284, 24);
                        this.EntradaCodigo.TabIndex = 1;
                        this.EntradaCodigo.Text = "A";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(16, 16);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(156, 24);
                        this.label6.TabIndex = 0;
                        this.label6.Text = "Código";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCopias
                        // 
                        this.EntradaCopias.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCopias.Location = new System.Drawing.Point(172, 328);
                        this.EntradaCopias.Name = "EntradaCopias";
                        this.EntradaCopias.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCopias.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCopias.TabIndex = 19;
                        this.EntradaCopias.Text = "1";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(16, 328);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(156, 24);
                        this.label1.TabIndex = 18;
                        this.label1.Text = "Copias consecutivas";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // TabCampos
                        // 
                        this.TabCampos.Controls.Add(this.button1);
                        this.TabCampos.Controls.Add(this.button2);
                        this.TabCampos.Controls.Add(this.label2);
                        this.TabCampos.Controls.Add(this.ZoomBar);
                        this.TabCampos.Controls.Add(this.ImagePreview);
                        this.TabCampos.Controls.Add(this.BotonQuitar);
                        this.TabCampos.Controls.Add(this.BotonAgregar);
                        this.TabCampos.Controls.Add(this.ListaCampos);
                        this.TabCampos.Location = new System.Drawing.Point(4, 26);
                        this.TabCampos.Name = "TabCampos";
                        this.TabCampos.Size = new System.Drawing.Size(862, 476);
                        this.TabCampos.TabIndex = 1;
                        this.TabCampos.Text = "Campos";
                        // 
                        // button1
                        // 
                        this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.button1.Image = null;
                        this.button1.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.button1.Location = new System.Drawing.Point(8, 278);
                        this.button1.Name = "button1";
                        this.button1.Padding = new System.Windows.Forms.Padding(2);
                        this.button1.Size = new System.Drawing.Size(68, 24);
                        this.button1.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.button1.Subtext = "Tecla";
                        this.button1.TabIndex = 114;
                        this.button1.Text = "Subir";
                        // 
                        // button2
                        // 
                        this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.button2.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.button2.Image = null;
                        this.button2.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.button2.Location = new System.Drawing.Point(80, 278);
                        this.button2.Name = "button2";
                        this.button2.Padding = new System.Windows.Forms.Padding(2);
                        this.button2.Size = new System.Drawing.Size(68, 24);
                        this.button2.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.button2.Subtext = "Tecla";
                        this.button2.TabIndex = 113;
                        this.button2.Text = "Bajar";
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label2.Location = new System.Drawing.Point(8, 312);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(140, 24);
                        this.label2.TabIndex = 112;
                        this.label2.Text = "Escala";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ZoomBar
                        // 
                        this.ZoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ZoomBar.LargeChange = 25;
                        this.ZoomBar.Location = new System.Drawing.Point(8, 336);
                        this.ZoomBar.Maximum = 250;
                        this.ZoomBar.Minimum = 25;
                        this.ZoomBar.Name = "ZoomBar";
                        this.ZoomBar.Size = new System.Drawing.Size(140, 45);
                        this.ZoomBar.SmallChange = 5;
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
                        this.ImagePreview.Size = new System.Drawing.Size(702, 378);
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
                        this.BotonQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonQuitar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitar.Image = null;
                        this.BotonQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitar.Location = new System.Drawing.Point(8, 250);
                        this.BotonQuitar.Name = "BotonQuitar";
                        this.BotonQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitar.Size = new System.Drawing.Size(68, 24);
                        this.BotonQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitar.Subtext = "Tecla";
                        this.BotonQuitar.TabIndex = 110;
                        this.BotonQuitar.Text = "Quitar";
                        this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
                        // 
                        // BotonAgregar
                        // 
                        this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAgregar.Image = null;
                        this.BotonAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregar.Location = new System.Drawing.Point(80, 250);
                        this.BotonAgregar.Name = "BotonAgregar";
                        this.BotonAgregar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregar.Size = new System.Drawing.Size(68, 24);
                        this.BotonAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAgregar.Subtext = "Tecla";
                        this.BotonAgregar.TabIndex = 109;
                        this.BotonAgregar.Text = "Agregar";
                        this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.TabControl);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(868, 507);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editar_KeyDown);
                        this.TabControl.ResumeLayout(false);
                        this.TabGeneral.ResumeLayout(false);
                        this.TabGeneral.PerformLayout();
                        this.TabCampos.ResumeLayout(false);
                        this.TabCampos.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
                        this.ResumeLayout(false);

                }
                #endregion

                private Lui.Forms.Button BotonQuitar;
                private Lui.Forms.Button BotonAgregar;
                private PictureBox ImagePreview;
                internal Lui.Forms.TextBox EntradaFuenteTamano;
                internal Lui.Forms.ComboBox EntradaFuente;
                private TrackBar ZoomBar;
                internal Lui.Forms.ComboBox EntradaLandscape;
                internal Lui.Forms.TextBox EntradaMargenAbajo;
                internal Lui.Forms.TextBox EntradaMargenArriba;
                internal Lui.Forms.TextBox EntradaMargenDerecha;
                internal Lui.Forms.TextBox EntradaMargenIzquierda;
                internal Lui.Forms.ComboBox EntradaMargenes;
                private Lui.Forms.Button button1;
                private Lui.Forms.Button button2;
                internal Lui.Forms.Label label4;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.Label label3;
        }
}
