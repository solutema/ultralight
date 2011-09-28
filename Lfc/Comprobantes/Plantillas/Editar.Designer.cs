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
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaCopias;
                internal System.Windows.Forms.Label label6;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.TextBox EntradaCodigo;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label label8;
                internal Lui.Forms.ComboBox EntradaMembrete;
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
                        this.label3 = new System.Windows.Forms.Label();
                        this.EntradaLandscape = new Lui.Forms.ComboBox();
                        this.BotonCargarDesdeArchivo = new Lui.Forms.Button();
                        this.BotonGuardarEnArchivo = new Lui.Forms.Button();
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
                        this.EntradaCopias = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.TabCampos = new System.Windows.Forms.TabPage();
                        this.button1 = new Lui.Forms.Button();
                        this.button2 = new Lui.Forms.Button();
                        this.label2 = new System.Windows.Forms.Label();
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
                        this.ListaCampos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ListaCampos.FullRowSelect = true;
                        this.ListaCampos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.ListaCampos.HideSelection = false;
                        this.ListaCampos.LabelWrap = false;
                        this.ListaCampos.Location = new System.Drawing.Point(8, 8);
                        this.ListaCampos.MultiSelect = false;
                        this.ListaCampos.Name = "ListaCampos";
                        this.ListaCampos.Size = new System.Drawing.Size(140, 240);
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
                        this.TabControl.Size = new System.Drawing.Size(870, 420);
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
                        this.TabGeneral.Controls.Add(this.BotonCargarDesdeArchivo);
                        this.TabGeneral.Controls.Add(this.BotonGuardarEnArchivo);
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
                        this.TabGeneral.Controls.Add(this.EntradaCopias);
                        this.TabGeneral.Controls.Add(this.label1);
                        this.TabGeneral.Location = new System.Drawing.Point(4, 24);
                        this.TabGeneral.Name = "TabGeneral";
                        this.TabGeneral.Size = new System.Drawing.Size(862, 392);
                        this.TabGeneral.TabIndex = 0;
                        this.TabGeneral.Text = "General";
                        // 
                        // EntradaMargenes
                        // 
                        this.EntradaMargenes.AlwaysExpanded = true;
                        this.EntradaMargenes.AutoNav = true;
                        this.EntradaMargenes.AutoSize = true;
                        this.EntradaMargenes.AutoTab = true;
                        this.EntradaMargenes.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMargenes.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMargenes.Location = new System.Drawing.Point(168, 156);
                        this.EntradaMargenes.MaxLenght = 32767;
                        this.EntradaMargenes.Name = "EntradaMargenes";
                        this.EntradaMargenes.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenes.SetData = new string[] {
        "Predeterminado|0",
        "Personalizado|1"};
                        this.EntradaMargenes.Size = new System.Drawing.Size(116, 36);
                        this.EntradaMargenes.TabIndex = 8;
                        this.EntradaMargenes.TextKey = "1";
                        this.EntradaMargenes.PlaceholderText = "";
                        this.EntradaMargenes.ToolTipText = "";
                        this.EntradaMargenes.TextChanged += new System.EventHandler(this.EntradaMargenes_TextChanged);
                        // 
                        // EntradaMargenAbajo
                        // 
                        this.EntradaMargenAbajo.AutoNav = true;
                        this.EntradaMargenAbajo.AutoTab = true;
                        this.EntradaMargenAbajo.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenAbajo.DecimalPlaces = -1;
                        this.EntradaMargenAbajo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMargenAbajo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMargenAbajo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMargenAbajo.Location = new System.Drawing.Point(388, 172);
                        this.EntradaMargenAbajo.MaxLenght = 32767;
                        this.EntradaMargenAbajo.MultiLine = false;
                        this.EntradaMargenAbajo.Name = "EntradaMargenAbajo";
                        this.EntradaMargenAbajo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenAbajo.PasswordChar = '\0';
                        this.EntradaMargenAbajo.Prefijo = "";
                        this.EntradaMargenAbajo.SelectOnFocus = true;
                        this.EntradaMargenAbajo.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenAbajo.Sufijo = "aba.";
                        this.EntradaMargenAbajo.TabIndex = 11;
                        this.EntradaMargenAbajo.Text = "0";
                        this.EntradaMargenAbajo.PlaceholderText = "auto";
                        this.EntradaMargenAbajo.ToolTipText = "";
                        // 
                        // EntradaMargenArriba
                        // 
                        this.EntradaMargenArriba.AutoNav = true;
                        this.EntradaMargenArriba.AutoTab = true;
                        this.EntradaMargenArriba.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenArriba.DecimalPlaces = -1;
                        this.EntradaMargenArriba.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMargenArriba.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMargenArriba.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMargenArriba.Location = new System.Drawing.Point(388, 140);
                        this.EntradaMargenArriba.MaxLenght = 32767;
                        this.EntradaMargenArriba.MultiLine = false;
                        this.EntradaMargenArriba.Name = "EntradaMargenArriba";
                        this.EntradaMargenArriba.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenArriba.PasswordChar = '\0';
                        this.EntradaMargenArriba.Prefijo = "";
                        this.EntradaMargenArriba.SelectOnFocus = true;
                        this.EntradaMargenArriba.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenArriba.Sufijo = "arr.";
                        this.EntradaMargenArriba.TabIndex = 10;
                        this.EntradaMargenArriba.Text = "0";
                        this.EntradaMargenArriba.PlaceholderText = "auto";
                        this.EntradaMargenArriba.ToolTipText = "";
                        // 
                        // EntradaMargenDerecha
                        // 
                        this.EntradaMargenDerecha.AutoNav = true;
                        this.EntradaMargenDerecha.AutoTab = true;
                        this.EntradaMargenDerecha.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenDerecha.DecimalPlaces = -1;
                        this.EntradaMargenDerecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMargenDerecha.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMargenDerecha.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMargenDerecha.Location = new System.Drawing.Point(488, 156);
                        this.EntradaMargenDerecha.MaxLenght = 32767;
                        this.EntradaMargenDerecha.MultiLine = false;
                        this.EntradaMargenDerecha.Name = "EntradaMargenDerecha";
                        this.EntradaMargenDerecha.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenDerecha.PasswordChar = '\0';
                        this.EntradaMargenDerecha.Prefijo = "";
                        this.EntradaMargenDerecha.SelectOnFocus = true;
                        this.EntradaMargenDerecha.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenDerecha.Sufijo = "der.";
                        this.EntradaMargenDerecha.TabIndex = 12;
                        this.EntradaMargenDerecha.Text = "0";
                        this.EntradaMargenDerecha.PlaceholderText = "auto";
                        this.EntradaMargenDerecha.ToolTipText = "";
                        // 
                        // EntradaMargenIzquierda
                        // 
                        this.EntradaMargenIzquierda.AutoNav = true;
                        this.EntradaMargenIzquierda.AutoTab = true;
                        this.EntradaMargenIzquierda.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaMargenIzquierda.DecimalPlaces = -1;
                        this.EntradaMargenIzquierda.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMargenIzquierda.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaMargenIzquierda.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMargenIzquierda.Location = new System.Drawing.Point(292, 156);
                        this.EntradaMargenIzquierda.MaxLenght = 32767;
                        this.EntradaMargenIzquierda.MultiLine = false;
                        this.EntradaMargenIzquierda.Name = "EntradaMargenIzquierda";
                        this.EntradaMargenIzquierda.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMargenIzquierda.PasswordChar = '\0';
                        this.EntradaMargenIzquierda.Prefijo = "";
                        this.EntradaMargenIzquierda.SelectOnFocus = true;
                        this.EntradaMargenIzquierda.Size = new System.Drawing.Size(84, 24);
                        this.EntradaMargenIzquierda.Sufijo = "izq.";
                        this.EntradaMargenIzquierda.TabIndex = 9;
                        this.EntradaMargenIzquierda.Text = "0";
                        this.EntradaMargenIzquierda.PlaceholderText = "auto";
                        this.EntradaMargenIzquierda.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(12, 156);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(156, 24);
                        this.label3.TabIndex = 7;
                        this.label3.Text = "Márgenes";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLandscape
                        // 
                        this.EntradaLandscape.AlwaysExpanded = true;
                        this.EntradaLandscape.AutoNav = true;
                        this.EntradaLandscape.AutoSize = true;
                        this.EntradaLandscape.AutoTab = true;
                        this.EntradaLandscape.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaLandscape.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaLandscape.Location = new System.Drawing.Point(264, 68);
                        this.EntradaLandscape.MaxLenght = 32767;
                        this.EntradaLandscape.Name = "EntradaLandscape";
                        this.EntradaLandscape.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLandscape.SetData = new string[] {
        "alto|0",
        "apaisado|1"};
                        this.EntradaLandscape.Size = new System.Drawing.Size(96, 36);
                        this.EntradaLandscape.TabIndex = 6;
                        this.EntradaLandscape.TextKey = "0";
                        this.EntradaLandscape.PlaceholderText = "";
                        this.EntradaLandscape.ToolTipText = "";
                        this.EntradaLandscape.TextChanged += new System.EventHandler(this.EntradaPapelTamano_TextChanged);
                        // 
                        // BotonCargarDesdeArchivo
                        // 
                        this.BotonCargarDesdeArchivo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCargarDesdeArchivo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonCargarDesdeArchivo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCargarDesdeArchivo.Image = null;
                        this.BotonCargarDesdeArchivo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCargarDesdeArchivo.Location = new System.Drawing.Point(488, 76);
                        this.BotonCargarDesdeArchivo.Name = "BotonCargarDesdeArchivo";
                        this.BotonCargarDesdeArchivo.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCargarDesdeArchivo.Size = new System.Drawing.Size(104, 32);
                        this.BotonCargarDesdeArchivo.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonCargarDesdeArchivo.Subtext = "Tecla";
                        this.BotonCargarDesdeArchivo.TabIndex = 15;
                        this.BotonCargarDesdeArchivo.Text = "Cargar";
                        this.BotonCargarDesdeArchivo.ToolTipText = "";
                        this.BotonCargarDesdeArchivo.Click += new System.EventHandler(this.BotonCargar_Click);
                        // 
                        // BotonGuardarEnArchivo
                        // 
                        this.BotonGuardarEnArchivo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonGuardarEnArchivo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonGuardarEnArchivo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonGuardarEnArchivo.Image = null;
                        this.BotonGuardarEnArchivo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonGuardarEnArchivo.Location = new System.Drawing.Point(488, 40);
                        this.BotonGuardarEnArchivo.Name = "BotonGuardarEnArchivo";
                        this.BotonGuardarEnArchivo.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonGuardarEnArchivo.Size = new System.Drawing.Size(104, 32);
                        this.BotonGuardarEnArchivo.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonGuardarEnArchivo.Subtext = "Tecla";
                        this.BotonGuardarEnArchivo.TabIndex = 14;
                        this.BotonGuardarEnArchivo.Text = "Guardar";
                        this.BotonGuardarEnArchivo.ToolTipText = "";
                        this.BotonGuardarEnArchivo.Click += new System.EventHandler(this.BotonGuardar_Click);
                        // 
                        // EntradaFuenteTamano
                        // 
                        this.EntradaFuenteTamano.AutoNav = true;
                        this.EntradaFuenteTamano.AutoTab = true;
                        this.EntradaFuenteTamano.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaFuenteTamano.DecimalPlaces = -1;
                        this.EntradaFuenteTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFuenteTamano.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFuenteTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFuenteTamano.Location = new System.Drawing.Point(428, 268);
                        this.EntradaFuenteTamano.MaxLenght = 32767;
                        this.EntradaFuenteTamano.MultiLine = false;
                        this.EntradaFuenteTamano.Name = "EntradaFuenteTamano";
                        this.EntradaFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteTamano.PasswordChar = '\0';
                        this.EntradaFuenteTamano.Prefijo = "";
                        this.EntradaFuenteTamano.SelectOnFocus = true;
                        this.EntradaFuenteTamano.Size = new System.Drawing.Size(92, 24);
                        this.EntradaFuenteTamano.Sufijo = "ptos.";
                        this.EntradaFuenteTamano.TabIndex = 17;
                        this.EntradaFuenteTamano.Text = "10";
                        this.EntradaFuenteTamano.PlaceholderText = "";
                        this.EntradaFuenteTamano.ToolTipText = "";
                        this.EntradaFuenteTamano.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // EntradaFuente
                        // 
                        this.EntradaFuente.AlwaysExpanded = true;
                        this.EntradaFuente.AutoNav = true;
                        this.EntradaFuente.AutoSize = true;
                        this.EntradaFuente.AutoTab = true;
                        this.EntradaFuente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFuente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFuente.Location = new System.Drawing.Point(168, 268);
                        this.EntradaFuente.MaxLenght = 32767;
                        this.EntradaFuente.Name = "EntradaFuente";
                        this.EntradaFuente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuente.SetData = new string[] {
        "Predeterminada|*",
        "Serif|Bitstream Vera Serif",
        "Sans Serif|Bitstream Vera Sans",
        "Monoespaciada Bitstream|Bitstream Vera Sans Mono",
        "Monoespaciada Courier|Courier New"};
                        this.EntradaFuente.Size = new System.Drawing.Size(256, 81);
                        this.EntradaFuente.TabIndex = 16;
                        this.EntradaFuente.TextKey = "*";
                        this.EntradaFuente.PlaceholderText = "";
                        this.EntradaFuente.ToolTipText = "";
                        this.EntradaFuente.TextChanged += new System.EventHandler(this.EntradaFuenteFuenteTamano_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(12, 268);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(156, 24);
                        this.label4.TabIndex = 15;
                        this.label4.Text = "Fuente";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(12, 208);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(156, 24);
                        this.label5.TabIndex = 13;
                        this.label5.Text = "Membrete";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPapelTamano
                        // 
                        this.EntradaPapelTamano.AlwaysExpanded = true;
                        this.EntradaPapelTamano.AutoNav = true;
                        this.EntradaPapelTamano.AutoSize = true;
                        this.EntradaPapelTamano.AutoTab = true;
                        this.EntradaPapelTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPapelTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPapelTamano.Location = new System.Drawing.Point(168, 68);
                        this.EntradaPapelTamano.MaxLenght = 32767;
                        this.EntradaPapelTamano.Name = "EntradaPapelTamano";
                        this.EntradaPapelTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPapelTamano.SetData = new string[] {
        "Oficio|legal",
        "Carta|letter",
        "A4|a4",
        "A5|a5",
        "Continuo|cont"};
                        this.EntradaPapelTamano.Size = new System.Drawing.Size(88, 81);
                        this.EntradaPapelTamano.TabIndex = 5;
                        this.EntradaPapelTamano.TextKey = "a4";
                        this.EntradaPapelTamano.PlaceholderText = "";
                        this.EntradaPapelTamano.ToolTipText = "";
                        this.EntradaPapelTamano.TextChanged += new System.EventHandler(this.EntradaPapelTamano_TextChanged);
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(12, 68);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(156, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Papel";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
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
                        this.EntradaNombre.SelectOnFocus = true;
                        this.EntradaNombre.Size = new System.Drawing.Size(284, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 3;
                        this.EntradaNombre.Text = "Factura A";
                        this.EntradaNombre.PlaceholderText = "";
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
                        this.EntradaCodigo.SelectOnFocus = true;
                        this.EntradaCodigo.Size = new System.Drawing.Size(284, 24);
                        this.EntradaCodigo.Sufijo = "";
                        this.EntradaCodigo.TabIndex = 1;
                        this.EntradaCodigo.Text = "A";
                        this.EntradaCodigo.PlaceholderText = "";
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
                        this.EntradaMembrete.AlwaysExpanded = true;
                        this.EntradaMembrete.AutoNav = true;
                        this.EntradaMembrete.AutoSize = true;
                        this.EntradaMembrete.AutoTab = true;
                        this.EntradaMembrete.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaMembrete.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaMembrete.Location = new System.Drawing.Point(168, 208);
                        this.EntradaMembrete.MaxLenght = 32767;
                        this.EntradaMembrete.Name = "EntradaMembrete";
                        this.EntradaMembrete.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMembrete.SetData = new string[] {
        "Ninguno|0",
        "Encabezado|1",
        "Recuadro|2"};
                        this.EntradaMembrete.Size = new System.Drawing.Size(256, 51);
                        this.EntradaMembrete.TabIndex = 14;
                        this.EntradaMembrete.TextKey = "0";
                        this.EntradaMembrete.PlaceholderText = "";
                        this.EntradaMembrete.ToolTipText = "";
                        // 
                        // EntradaCopias
                        // 
                        this.EntradaCopias.AutoNav = true;
                        this.EntradaCopias.AutoTab = true;
                        this.EntradaCopias.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaCopias.DecimalPlaces = -1;
                        this.EntradaCopias.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCopias.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCopias.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCopias.Location = new System.Drawing.Point(168, 356);
                        this.EntradaCopias.MaxLenght = 32767;
                        this.EntradaCopias.MultiLine = false;
                        this.EntradaCopias.Name = "EntradaCopias";
                        this.EntradaCopias.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCopias.PasswordChar = '\0';
                        this.EntradaCopias.Prefijo = "";
                        this.EntradaCopias.SelectOnFocus = true;
                        this.EntradaCopias.Size = new System.Drawing.Size(56, 24);
                        this.EntradaCopias.Sufijo = "";
                        this.EntradaCopias.TabIndex = 19;
                        this.EntradaCopias.Text = "1";
                        this.EntradaCopias.PlaceholderText = "";
                        this.EntradaCopias.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(12, 356);
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
                        this.TabCampos.Location = new System.Drawing.Point(4, 24);
                        this.TabCampos.Name = "TabCampos";
                        this.TabCampos.Size = new System.Drawing.Size(862, 392);
                        this.TabCampos.TabIndex = 1;
                        this.TabCampos.Text = "Campos";
                        // 
                        // button1
                        // 
                        this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.button1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.button1.Image = null;
                        this.button1.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.button1.Location = new System.Drawing.Point(8, 284);
                        this.button1.Name = "button1";
                        this.button1.Padding = new System.Windows.Forms.Padding(2);
                        this.button1.Size = new System.Drawing.Size(68, 24);
                        this.button1.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.button1.Subtext = "Tecla";
                        this.button1.TabIndex = 114;
                        this.button1.Text = "Subir";
                        this.button1.ToolTipText = "";
                        // 
                        // button2
                        // 
                        this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.button2.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.button2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.button2.Image = null;
                        this.button2.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.button2.Location = new System.Drawing.Point(80, 284);
                        this.button2.Name = "button2";
                        this.button2.Padding = new System.Windows.Forms.Padding(2);
                        this.button2.Size = new System.Drawing.Size(68, 24);
                        this.button2.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.button2.Subtext = "Tecla";
                        this.button2.TabIndex = 113;
                        this.button2.Text = "Bajar";
                        this.button2.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label2.Location = new System.Drawing.Point(8, 318);
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
                        this.ZoomBar.Location = new System.Drawing.Point(8, 342);
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
                        this.ImagePreview.Size = new System.Drawing.Size(702, 384);
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
                        this.BotonQuitar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitar.Image = null;
                        this.BotonQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitar.Location = new System.Drawing.Point(8, 256);
                        this.BotonQuitar.Name = "BotonQuitar";
                        this.BotonQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitar.Size = new System.Drawing.Size(68, 24);
                        this.BotonQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitar.Subtext = "Tecla";
                        this.BotonQuitar.TabIndex = 110;
                        this.BotonQuitar.Text = "Quitar";
                        this.BotonQuitar.ToolTipText = "";
                        this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
                        // 
                        // BotonAgregar
                        // 
                        this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAgregar.Image = null;
                        this.BotonAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregar.Location = new System.Drawing.Point(80, 256);
                        this.BotonAgregar.Name = "BotonAgregar";
                        this.BotonAgregar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregar.Size = new System.Drawing.Size(68, 24);
                        this.BotonAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonAgregar.Subtext = "Tecla";
                        this.BotonAgregar.TabIndex = 109;
                        this.BotonAgregar.Text = "Agregar";
                        this.BotonAgregar.ToolTipText = "";
                        this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // Editar
                        // 
                        this.AutoSize = true;
                        this.Controls.Add(this.TabControl);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(868, 421);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editar_KeyDown);
                        this.Controls.SetChildIndex(this.TabControl, 0);
                        this.TabControl.ResumeLayout(false);
                        this.TabGeneral.ResumeLayout(false);
                        this.TabGeneral.PerformLayout();
                        this.TabCampos.ResumeLayout(false);
                        this.TabCampos.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                private Lui.Forms.Button BotonQuitar;
                private Lui.Forms.Button BotonAgregar;
                internal Label label5;
                private PictureBox ImagePreview;
                internal Lui.Forms.TextBox EntradaFuenteTamano;
                internal Lui.Forms.ComboBox EntradaFuente;
                internal Label label4;
                internal Label label2;
                private TrackBar ZoomBar;
                private Lui.Forms.Button BotonCargarDesdeArchivo;
                private Lui.Forms.Button BotonGuardarEnArchivo;
                internal Lui.Forms.ComboBox EntradaLandscape;
                internal Lui.Forms.TextBox EntradaMargenAbajo;
                internal Lui.Forms.TextBox EntradaMargenArriba;
                internal Lui.Forms.TextBox EntradaMargenDerecha;
                internal Lui.Forms.TextBox EntradaMargenIzquierda;
                internal Label label3;
                internal Lui.Forms.ComboBox EntradaMargenes;
                private Lui.Forms.Button button1;
                private Lui.Forms.Button button2;
        }
}
