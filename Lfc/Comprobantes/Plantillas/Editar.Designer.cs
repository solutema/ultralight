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
                protected Lui.Forms.ListView ListaCampos;
                protected System.Windows.Forms.ColumnHeader ColCampo;
                protected Lui.Forms.Label label1;
                protected Lui.Forms.TextBox EntradaCopias;
                protected Lui.Forms.Label label6;
                protected Lui.Forms.Label label7;
                protected Lui.Forms.TextBox EntradaCodigo;
                protected Lui.Forms.TextBox EntradaNombre;
                protected Lui.Forms.Label label8;
                protected Lui.Forms.ComboBox EntradaPapelTamano;
                protected System.ComponentModel.IContainer components = null;


                #region Designer generated code
                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        this.ListaCampos = new Lui.Forms.ListView();
                        this.ColCampo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
                        this.label5 = new Lui.Forms.Label();
                        this.ImagePreview = new System.Windows.Forms.PictureBox();
                        this.BotonSubir = new Lui.Forms.Button();
                        this.BotonBajar = new Lui.Forms.Button();
                        this.label2 = new Lui.Forms.Label();
                        this.ZoomBar = new System.Windows.Forms.TrackBar();
                        this.PanelGeneral = new Lui.Forms.Panel();
                        this.PanelDiseno = new Lui.Forms.Panel();
                        this.BotonAgregar = new Lui.Forms.Button();
                        this.BotonQuitar = new Lui.Forms.Button();
                        this.BotonGeneral = new Lui.Forms.Button();
                        this.BotonDiseno = new Lui.Forms.Button();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
                        this.PanelGeneral.SuspendLayout();
                        this.PanelDiseno.SuspendLayout();
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
                        this.ListaCampos.Location = new System.Drawing.Point(0, 0);
                        this.ListaCampos.MultiSelect = false;
                        this.ListaCampos.Name = "ListaCampos";
                        this.ListaCampos.Size = new System.Drawing.Size(192, 246);
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
                        // EntradaMargenes
                        // 
                        this.EntradaMargenes.AlwaysExpanded = true;
                        this.EntradaMargenes.AutoSize = true;
                        this.EntradaMargenes.Location = new System.Drawing.Point(156, 184);
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
                        this.EntradaMargenAbajo.Location = new System.Drawing.Point(376, 200);
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
                        this.EntradaMargenArriba.Location = new System.Drawing.Point(376, 168);
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
                        this.EntradaMargenDerecha.Location = new System.Drawing.Point(476, 184);
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
                        this.EntradaMargenIzquierda.Location = new System.Drawing.Point(280, 184);
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
                        this.label3.Location = new System.Drawing.Point(0, 184);
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
                        this.EntradaLandscape.Location = new System.Drawing.Point(252, 64);
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
                        this.EntradaFuenteTamano.Location = new System.Drawing.Point(416, 248);
                        this.EntradaFuenteTamano.Name = "EntradaFuenteTamano";
                        this.EntradaFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteTamano.Size = new System.Drawing.Size(96, 24);
                        this.EntradaFuenteTamano.Sufijo = "ptos.";
                        this.EntradaFuenteTamano.TabIndex = 15;
                        this.EntradaFuenteTamano.Text = "10.00";
                        this.EntradaFuenteTamano.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // EntradaFuente
                        // 
                        this.EntradaFuente.AlwaysExpanded = true;
                        this.EntradaFuente.AutoSize = true;
                        this.EntradaFuente.Location = new System.Drawing.Point(156, 248);
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
                        this.EntradaFuente.TabIndex = 14;
                        this.EntradaFuente.TextKey = "*";
                        this.EntradaFuente.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 248);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(156, 24);
                        this.label4.TabIndex = 13;
                        this.label4.Text = "Fuente";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPapelTamano
                        // 
                        this.EntradaPapelTamano.AlwaysExpanded = true;
                        this.EntradaPapelTamano.AutoSize = true;
                        this.EntradaPapelTamano.Location = new System.Drawing.Point(156, 64);
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
                        this.label8.Location = new System.Drawing.Point(0, 64);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(156, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Papel";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(156, 32);
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.Size = new System.Drawing.Size(284, 24);
                        this.EntradaNombre.TabIndex = 3;
                        this.EntradaNombre.Text = "Factura A";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(0, 32);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(156, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Nombre";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCodigo
                        // 
                        this.EntradaCodigo.Location = new System.Drawing.Point(156, 0);
                        this.EntradaCodigo.Name = "EntradaCodigo";
                        this.EntradaCodigo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCodigo.Size = new System.Drawing.Size(284, 24);
                        this.EntradaCodigo.TabIndex = 1;
                        this.EntradaCodigo.Text = "A";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(0, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(156, 24);
                        this.label6.TabIndex = 0;
                        this.label6.Text = "Código";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCopias
                        // 
                        this.EntradaCopias.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCopias.Location = new System.Drawing.Point(156, 352);
                        this.EntradaCopias.Name = "EntradaCopias";
                        this.EntradaCopias.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCopias.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCopias.TabIndex = 17;
                        this.EntradaCopias.Text = "1";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(0, 352);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(156, 24);
                        this.label1.TabIndex = 16;
                        this.label1.Text = "Copias consecutivas";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label5.Location = new System.Drawing.Point(0, 419);
                        this.label5.MaximumSize = new System.Drawing.Size(192, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(192, 43);
                        this.label5.TabIndex = 7;
                        this.label5.Text = "Utilice el botón central del ratón para desplazar la imagen.";
                        this.label5.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        // 
                        // ImagePreview
                        // 
                        this.ImagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ImagePreview.BackColor = System.Drawing.Color.Ivory;
                        this.ImagePreview.Location = new System.Drawing.Point(208, 0);
                        this.ImagePreview.Name = "ImagePreview";
                        this.ImagePreview.Size = new System.Drawing.Size(504, 464);
                        this.ImagePreview.TabIndex = 105;
                        this.ImagePreview.TabStop = false;
                        this.ImagePreview.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagePreview_Paint);
                        this.ImagePreview.DoubleClick += new System.EventHandler(this.ImagePreview_DoubleClick);
                        this.ImagePreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseDown);
                        this.ImagePreview.MouseEnter += new System.EventHandler(this.ImagePreview_MouseEnter);
                        this.ImagePreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseMove);
                        this.ImagePreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseUp);
                        this.ImagePreview.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ImagePreview_MouseWheel);
                        // 
                        // BotonSubir
                        // 
                        this.BotonSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonSubir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonSubir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonSubir.Image = null;
                        this.BotonSubir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonSubir.Location = new System.Drawing.Point(104, 254);
                        this.BotonSubir.Name = "BotonSubir";
                        this.BotonSubir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonSubir.Size = new System.Drawing.Size(88, 32);
                        this.BotonSubir.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonSubir.Subtext = "Tecla";
                        this.BotonSubir.TabIndex = 3;
                        this.BotonSubir.Text = "Subir";
                        // 
                        // BotonBajar
                        // 
                        this.BotonBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonBajar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonBajar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonBajar.Image = null;
                        this.BotonBajar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonBajar.Location = new System.Drawing.Point(104, 294);
                        this.BotonBajar.Name = "BotonBajar";
                        this.BotonBajar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonBajar.Size = new System.Drawing.Size(88, 32);
                        this.BotonBajar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonBajar.Subtext = "Tecla";
                        this.BotonBajar.TabIndex = 4;
                        this.BotonBajar.Text = "Bajar";
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label2.Location = new System.Drawing.Point(0, 342);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(192, 24);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "Escala";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ZoomBar
                        // 
                        this.ZoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ZoomBar.LargeChange = 25;
                        this.ZoomBar.Location = new System.Drawing.Point(0, 371);
                        this.ZoomBar.Maximum = 250;
                        this.ZoomBar.Minimum = 25;
                        this.ZoomBar.Name = "ZoomBar";
                        this.ZoomBar.Size = new System.Drawing.Size(192, 45);
                        this.ZoomBar.SmallChange = 5;
                        this.ZoomBar.TabIndex = 6;
                        this.ZoomBar.TabStop = false;
                        this.ZoomBar.TickFrequency = 10;
                        this.ZoomBar.TickStyle = System.Windows.Forms.TickStyle.Both;
                        this.ZoomBar.Value = 100;
                        this.ZoomBar.Scroll += new System.EventHandler(this.ZoomBar_Scroll);
                        // 
                        // PanelGeneral
                        // 
                        this.PanelGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelGeneral.Controls.Add(this.EntradaMargenes);
                        this.PanelGeneral.Controls.Add(this.label6);
                        this.PanelGeneral.Controls.Add(this.EntradaMargenAbajo);
                        this.PanelGeneral.Controls.Add(this.label1);
                        this.PanelGeneral.Controls.Add(this.EntradaMargenArriba);
                        this.PanelGeneral.Controls.Add(this.EntradaCopias);
                        this.PanelGeneral.Controls.Add(this.EntradaMargenDerecha);
                        this.PanelGeneral.Controls.Add(this.EntradaCodigo);
                        this.PanelGeneral.Controls.Add(this.EntradaMargenIzquierda);
                        this.PanelGeneral.Controls.Add(this.label7);
                        this.PanelGeneral.Controls.Add(this.label3);
                        this.PanelGeneral.Controls.Add(this.EntradaNombre);
                        this.PanelGeneral.Controls.Add(this.EntradaLandscape);
                        this.PanelGeneral.Controls.Add(this.label8);
                        this.PanelGeneral.Controls.Add(this.EntradaFuenteTamano);
                        this.PanelGeneral.Controls.Add(this.EntradaPapelTamano);
                        this.PanelGeneral.Controls.Add(this.EntradaFuente);
                        this.PanelGeneral.Controls.Add(this.label4);
                        this.PanelGeneral.Location = new System.Drawing.Point(128, 0);
                        this.PanelGeneral.Name = "PanelGeneral";
                        this.PanelGeneral.Size = new System.Drawing.Size(712, 464);
                        this.PanelGeneral.TabIndex = 0;
                        // 
                        // PanelDiseno
                        // 
                        this.PanelDiseno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelDiseno.Controls.Add(this.BotonAgregar);
                        this.PanelDiseno.Controls.Add(this.BotonQuitar);
                        this.PanelDiseno.Controls.Add(this.label5);
                        this.PanelDiseno.Controls.Add(this.ListaCampos);
                        this.PanelDiseno.Controls.Add(this.ImagePreview);
                        this.PanelDiseno.Controls.Add(this.ZoomBar);
                        this.PanelDiseno.Controls.Add(this.BotonSubir);
                        this.PanelDiseno.Controls.Add(this.label2);
                        this.PanelDiseno.Controls.Add(this.BotonBajar);
                        this.PanelDiseno.Location = new System.Drawing.Point(128, 0);
                        this.PanelDiseno.Name = "PanelDiseno";
                        this.PanelDiseno.Size = new System.Drawing.Size(712, 464);
                        this.PanelDiseno.TabIndex = 0;
                        this.PanelDiseno.Visible = false;
                        // 
                        // BotonAgregar
                        // 
                        this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAgregar.Image = null;
                        this.BotonAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregar.Location = new System.Drawing.Point(0, 254);
                        this.BotonAgregar.Name = "BotonAgregar";
                        this.BotonAgregar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregar.Size = new System.Drawing.Size(88, 32);
                        this.BotonAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAgregar.Subtext = "Tecla";
                        this.BotonAgregar.TabIndex = 1;
                        this.BotonAgregar.Text = "Agregar";
                        this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // BotonQuitar
                        // 
                        this.BotonQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonQuitar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitar.Image = null;
                        this.BotonQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitar.Location = new System.Drawing.Point(0, 294);
                        this.BotonQuitar.Name = "BotonQuitar";
                        this.BotonQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitar.Size = new System.Drawing.Size(88, 32);
                        this.BotonQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitar.Subtext = "Tecla";
                        this.BotonQuitar.TabIndex = 2;
                        this.BotonQuitar.Text = "Quitar";
                        this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
                        // 
                        // BotonGeneral
                        // 
                        this.BotonGeneral.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonGeneral.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonGeneral.Image = null;
                        this.BotonGeneral.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonGeneral.Location = new System.Drawing.Point(0, 0);
                        this.BotonGeneral.Name = "BotonGeneral";
                        this.BotonGeneral.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonGeneral.Size = new System.Drawing.Size(112, 40);
                        this.BotonGeneral.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonGeneral.Subtext = "Tecla";
                        this.BotonGeneral.TabIndex = 2;
                        this.BotonGeneral.Text = "General";
                        this.BotonGeneral.Click += new System.EventHandler(this.BotonGeneral_Click);
                        // 
                        // BotonDiseno
                        // 
                        this.BotonDiseno.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonDiseno.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonDiseno.Image = null;
                        this.BotonDiseno.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonDiseno.Location = new System.Drawing.Point(0, 48);
                        this.BotonDiseno.Name = "BotonDiseno";
                        this.BotonDiseno.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonDiseno.Size = new System.Drawing.Size(112, 40);
                        this.BotonDiseno.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonDiseno.Subtext = "Tecla";
                        this.BotonDiseno.TabIndex = 3;
                        this.BotonDiseno.Text = "Diseño";
                        this.BotonDiseno.Click += new System.EventHandler(this.BotonDiseno_Click);
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.BotonDiseno);
                        this.Controls.Add(this.BotonGeneral);
                        this.Controls.Add(this.PanelDiseno);
                        this.Controls.Add(this.PanelGeneral);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(840, 464);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editar_KeyDown);
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
                        this.PanelGeneral.ResumeLayout(false);
                        this.PanelGeneral.PerformLayout();
                        this.PanelDiseno.ResumeLayout(false);
                        this.PanelDiseno.PerformLayout();
                        this.ResumeLayout(false);

                }
                #endregion

                protected Lui.Forms.TextBox EntradaFuenteTamano;
                protected Lui.Forms.ComboBox EntradaFuente;
                protected TrackBar ZoomBar;
                protected Lui.Forms.ComboBox EntradaLandscape;
                protected Lui.Forms.TextBox EntradaMargenAbajo;
                protected Lui.Forms.TextBox EntradaMargenArriba;
                protected Lui.Forms.TextBox EntradaMargenDerecha;
                protected Lui.Forms.TextBox EntradaMargenIzquierda;
                protected Lui.Forms.ComboBox EntradaMargenes;
                protected Lui.Forms.Button BotonSubir;
                protected Lui.Forms.Button BotonBajar;
                protected Lui.Forms.Label label4;
                protected Lui.Forms.Label label2;
                protected Lui.Forms.Label label3;
                protected PictureBox ImagePreview;
                private Lui.Forms.Label label5;
                private Lui.Forms.Panel PanelGeneral;
                private Lui.Forms.Panel PanelDiseno;
                private Lui.Forms.Button BotonGeneral;
                private Lui.Forms.Button BotonDiseno;
                protected Lui.Forms.Button BotonAgregar;
                protected Lui.Forms.Button BotonQuitar;
        }
}
