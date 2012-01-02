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
using System.Windows.Forms;

namespace Lfc.Comprobantes.Plantillas
{
        public partial class EditarCampo
        {
                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
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

                #region Código generado por el diseñador
                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.Label15 = new Lui.Forms.Label();
                        this.EntradaTexto = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaX = new Lui.Forms.TextBox();
                        this.EntradaY = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaFuenteNombre = new Lui.Forms.ComboBox();
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaAlto = new Lui.Forms.TextBox();
                        this.EntradaAncho = new Lui.Forms.TextBox();
                        this.label5 = new Lui.Forms.Label();
                        this.label6 = new Lui.Forms.Label();
                        this.EntradaFuenteTamano = new Lui.Forms.TextBox();
                        this.EntradaAlienacionHorizontal = new Lui.Forms.ComboBox();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaAlienacionVertical = new Lui.Forms.ComboBox();
                        this.EntradaAnchoBorde = new Lui.Forms.TextBox();
                        this.label8 = new Lui.Forms.Label();
                        this.ColorFondo = new System.Windows.Forms.Button();
                        this.ColorTexto = new System.Windows.Forms.Button();
                        this.ColorBorde = new System.Windows.Forms.Button();
                        this.EntradaAjusteTexto = new Lui.Forms.ComboBox();
                        this.label9 = new Lui.Forms.Label();
                        this.EntradaFormato = new Lui.Forms.ComboBox();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(302, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(422, 8);
                        // 
                        // Label15
                        // 
                        this.Label15.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label15.Location = new System.Drawing.Point(24, 56);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(80, 24);
                        this.Label15.TabIndex = 2;
                        this.Label15.Text = "Formato";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTexto
                        // 
                        this.EntradaTexto.AutoNav = true;
                        this.EntradaTexto.AutoTab = true;
                        this.EntradaTexto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTexto.DecimalPlaces = -1;
                        this.EntradaTexto.FieldName = null;
                        this.EntradaTexto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTexto.Location = new System.Drawing.Point(108, 24);
                        this.EntradaTexto.MaxLength = 32767;
                        this.EntradaTexto.MultiLine = false;
                        this.EntradaTexto.Name = "EntradaTexto";
                        this.EntradaTexto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTexto.PasswordChar = '\0';
                        this.EntradaTexto.PlaceholderText = null;
                        this.EntradaTexto.Prefijo = "";
                        this.EntradaTexto.ReadOnly = false;
                        this.EntradaTexto.SelectOnFocus = false;
                        this.EntradaTexto.Size = new System.Drawing.Size(408, 24);
                        this.EntradaTexto.Sufijo = "";
                        this.EntradaTexto.TabIndex = 1;
                        this.EntradaTexto.TextChanged += new System.EventHandler(this.EntradaTexto_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label1.Location = new System.Drawing.Point(24, 24);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(80, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Texto";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label2.Location = new System.Drawing.Point(24, 88);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(80, 24);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Posición";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaX
                        // 
                        this.EntradaX.AutoNav = true;
                        this.EntradaX.AutoTab = true;
                        this.EntradaX.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaX.DecimalPlaces = -1;
                        this.EntradaX.FieldName = null;
                        this.EntradaX.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaX.Location = new System.Drawing.Point(108, 88);
                        this.EntradaX.MaxLength = 32767;
                        this.EntradaX.MultiLine = false;
                        this.EntradaX.Name = "EntradaX";
                        this.EntradaX.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaX.PasswordChar = '\0';
                        this.EntradaX.PlaceholderText = null;
                        this.EntradaX.Prefijo = "";
                        this.EntradaX.ReadOnly = false;
                        this.EntradaX.SelectOnFocus = true;
                        this.EntradaX.Size = new System.Drawing.Size(56, 24);
                        this.EntradaX.Sufijo = "x";
                        this.EntradaX.TabIndex = 5;
                        // 
                        // EntradaY
                        // 
                        this.EntradaY.AutoNav = true;
                        this.EntradaY.AutoTab = true;
                        this.EntradaY.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaY.DecimalPlaces = -1;
                        this.EntradaY.FieldName = null;
                        this.EntradaY.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaY.Location = new System.Drawing.Point(176, 88);
                        this.EntradaY.MaxLength = 32767;
                        this.EntradaY.MultiLine = false;
                        this.EntradaY.Name = "EntradaY";
                        this.EntradaY.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaY.PasswordChar = '\0';
                        this.EntradaY.PlaceholderText = null;
                        this.EntradaY.Prefijo = "";
                        this.EntradaY.ReadOnly = false;
                        this.EntradaY.SelectOnFocus = true;
                        this.EntradaY.Size = new System.Drawing.Size(56, 24);
                        this.EntradaY.Sufijo = "y";
                        this.EntradaY.TabIndex = 7;
                        // 
                        // label3
                        // 
                        this.label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label3.Location = new System.Drawing.Point(164, 88);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(20, 24);
                        this.label3.TabIndex = 6;
                        this.label3.Text = ",";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFuenteNombre
                        // 
                        this.EntradaFuenteNombre.AlwaysExpanded = false;
                        this.EntradaFuenteNombre.AutoNav = true;
                        this.EntradaFuenteNombre.AutoTab = true;
                        this.EntradaFuenteNombre.FieldName = null;
                        this.EntradaFuenteNombre.Location = new System.Drawing.Point(108, 120);
                        this.EntradaFuenteNombre.MaxLength = 32767;
                        this.EntradaFuenteNombre.Name = "EntradaFuenteNombre";
                        this.EntradaFuenteNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteNombre.PlaceholderText = null;
                        this.EntradaFuenteNombre.ReadOnly = false;
                        this.EntradaFuenteNombre.SetData = new string[] {
        "Predeterminada|*",
        "Serif|Bitstream Vera Serif",
        "Sans Serif|Bitstream Vera Sans",
        "Monoespaciada Bitstream|Bitstream Vera Sans Mono",
        "Monoespaciada Courier|Courier New"};
                        this.EntradaFuenteNombre.Size = new System.Drawing.Size(256, 24);
                        this.EntradaFuenteNombre.TabIndex = 13;
                        this.EntradaFuenteNombre.TextKey = "*";
                        this.EntradaFuenteNombre.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label4.Location = new System.Drawing.Point(24, 120);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(80, 24);
                        this.label4.TabIndex = 12;
                        this.label4.Text = "Fuente";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAlto
                        // 
                        this.EntradaAlto.AutoNav = true;
                        this.EntradaAlto.AutoTab = true;
                        this.EntradaAlto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAlto.DecimalPlaces = -1;
                        this.EntradaAlto.FieldName = null;
                        this.EntradaAlto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAlto.Location = new System.Drawing.Point(396, 88);
                        this.EntradaAlto.MaxLength = 32767;
                        this.EntradaAlto.MultiLine = false;
                        this.EntradaAlto.Name = "EntradaAlto";
                        this.EntradaAlto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlto.PasswordChar = '\0';
                        this.EntradaAlto.PlaceholderText = null;
                        this.EntradaAlto.Prefijo = "";
                        this.EntradaAlto.ReadOnly = false;
                        this.EntradaAlto.SelectOnFocus = true;
                        this.EntradaAlto.Size = new System.Drawing.Size(56, 24);
                        this.EntradaAlto.Sufijo = "v";
                        this.EntradaAlto.TabIndex = 11;
                        // 
                        // EntradaAncho
                        // 
                        this.EntradaAncho.AutoNav = true;
                        this.EntradaAncho.AutoTab = true;
                        this.EntradaAncho.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAncho.DecimalPlaces = -1;
                        this.EntradaAncho.FieldName = null;
                        this.EntradaAncho.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAncho.Location = new System.Drawing.Point(324, 88);
                        this.EntradaAncho.MaxLength = 32767;
                        this.EntradaAncho.MultiLine = false;
                        this.EntradaAncho.Name = "EntradaAncho";
                        this.EntradaAncho.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAncho.PasswordChar = '\0';
                        this.EntradaAncho.PlaceholderText = null;
                        this.EntradaAncho.Prefijo = "";
                        this.EntradaAncho.ReadOnly = false;
                        this.EntradaAncho.SelectOnFocus = true;
                        this.EntradaAncho.Size = new System.Drawing.Size(56, 24);
                        this.EntradaAncho.Sufijo = "h";
                        this.EntradaAncho.TabIndex = 9;
                        // 
                        // label5
                        // 
                        this.label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label5.Location = new System.Drawing.Point(380, 88);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(16, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "x";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label6
                        // 
                        this.label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label6.Location = new System.Drawing.Point(264, 88);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(64, 24);
                        this.label6.TabIndex = 8;
                        this.label6.Text = "Tamaño";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFuenteTamano
                        // 
                        this.EntradaFuenteTamano.AutoNav = true;
                        this.EntradaFuenteTamano.AutoTab = true;
                        this.EntradaFuenteTamano.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaFuenteTamano.DecimalPlaces = -1;
                        this.EntradaFuenteTamano.FieldName = null;
                        this.EntradaFuenteTamano.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFuenteTamano.Location = new System.Drawing.Point(372, 120);
                        this.EntradaFuenteTamano.MaxLength = 32767;
                        this.EntradaFuenteTamano.MultiLine = false;
                        this.EntradaFuenteTamano.Name = "EntradaFuenteTamano";
                        this.EntradaFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteTamano.PasswordChar = '\0';
                        this.EntradaFuenteTamano.PlaceholderText = null;
                        this.EntradaFuenteTamano.Prefijo = "";
                        this.EntradaFuenteTamano.ReadOnly = false;
                        this.EntradaFuenteTamano.SelectOnFocus = true;
                        this.EntradaFuenteTamano.Size = new System.Drawing.Size(92, 24);
                        this.EntradaFuenteTamano.Sufijo = "ptos.";
                        this.EntradaFuenteTamano.TabIndex = 14;
                        this.EntradaFuenteTamano.Text = "10";
                        this.EntradaFuenteTamano.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
                        // 
                        // EntradaAlienacionHorizontal
                        // 
                        this.EntradaAlienacionHorizontal.AlwaysExpanded = false;
                        this.EntradaAlienacionHorizontal.AutoNav = true;
                        this.EntradaAlienacionHorizontal.AutoTab = true;
                        this.EntradaAlienacionHorizontal.FieldName = null;
                        this.EntradaAlienacionHorizontal.Location = new System.Drawing.Point(108, 152);
                        this.EntradaAlienacionHorizontal.MaxLength = 32767;
                        this.EntradaAlienacionHorizontal.Name = "EntradaAlienacionHorizontal";
                        this.EntradaAlienacionHorizontal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlienacionHorizontal.PlaceholderText = null;
                        this.EntradaAlienacionHorizontal.ReadOnly = false;
                        this.EntradaAlienacionHorizontal.SetData = new string[] {
        "Izquierda|Near",
        "Centro|Center",
        "Derecha|Far"};
                        this.EntradaAlienacionHorizontal.Size = new System.Drawing.Size(140, 24);
                        this.EntradaAlienacionHorizontal.TabIndex = 16;
                        this.EntradaAlienacionHorizontal.TextKey = "Near";
                        // 
                        // label7
                        // 
                        this.label7.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label7.Location = new System.Drawing.Point(24, 152);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(80, 24);
                        this.label7.TabIndex = 15;
                        this.label7.Text = "Alineación";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAlienacionVertical
                        // 
                        this.EntradaAlienacionVertical.AlwaysExpanded = false;
                        this.EntradaAlienacionVertical.AutoNav = true;
                        this.EntradaAlienacionVertical.AutoTab = true;
                        this.EntradaAlienacionVertical.FieldName = null;
                        this.EntradaAlienacionVertical.Location = new System.Drawing.Point(256, 152);
                        this.EntradaAlienacionVertical.MaxLength = 32767;
                        this.EntradaAlienacionVertical.Name = "EntradaAlienacionVertical";
                        this.EntradaAlienacionVertical.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlienacionVertical.PlaceholderText = null;
                        this.EntradaAlienacionVertical.ReadOnly = false;
                        this.EntradaAlienacionVertical.SetData = new string[] {
        "Arriba|Near",
        "Centro|Center",
        "Abajo|Far"};
                        this.EntradaAlienacionVertical.Size = new System.Drawing.Size(140, 24);
                        this.EntradaAlienacionVertical.TabIndex = 17;
                        this.EntradaAlienacionVertical.TextKey = "Near";
                        // 
                        // EntradaAnchoBorde
                        // 
                        this.EntradaAnchoBorde.AutoNav = true;
                        this.EntradaAnchoBorde.AutoTab = true;
                        this.EntradaAnchoBorde.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAnchoBorde.DecimalPlaces = -1;
                        this.EntradaAnchoBorde.FieldName = null;
                        this.EntradaAnchoBorde.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAnchoBorde.Location = new System.Drawing.Point(108, 216);
                        this.EntradaAnchoBorde.MaxLength = 32767;
                        this.EntradaAnchoBorde.MultiLine = false;
                        this.EntradaAnchoBorde.Name = "EntradaAnchoBorde";
                        this.EntradaAnchoBorde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAnchoBorde.PasswordChar = '\0';
                        this.EntradaAnchoBorde.PlaceholderText = null;
                        this.EntradaAnchoBorde.Prefijo = "";
                        this.EntradaAnchoBorde.ReadOnly = false;
                        this.EntradaAnchoBorde.SelectOnFocus = true;
                        this.EntradaAnchoBorde.Size = new System.Drawing.Size(88, 24);
                        this.EntradaAnchoBorde.Sufijo = "ptos.";
                        this.EntradaAnchoBorde.TabIndex = 21;
                        // 
                        // label8
                        // 
                        this.label8.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label8.Location = new System.Drawing.Point(24, 216);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(80, 24);
                        this.label8.TabIndex = 20;
                        this.label8.Text = "Borde";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ColorFondo
                        // 
                        this.ColorFondo.Location = new System.Drawing.Point(108, 252);
                        this.ColorFondo.Name = "ColorFondo";
                        this.ColorFondo.Size = new System.Drawing.Size(72, 24);
                        this.ColorFondo.TabIndex = 22;
                        this.ColorFondo.Text = "Fondo";
                        this.ColorFondo.UseVisualStyleBackColor = true;
                        this.ColorFondo.Click += new System.EventHandler(this.ColorFondo_Click);
                        // 
                        // ColorTexto
                        // 
                        this.ColorTexto.Location = new System.Drawing.Point(192, 252);
                        this.ColorTexto.Name = "ColorTexto";
                        this.ColorTexto.Size = new System.Drawing.Size(72, 24);
                        this.ColorTexto.TabIndex = 23;
                        this.ColorTexto.Text = "Texto";
                        this.ColorTexto.UseVisualStyleBackColor = true;
                        this.ColorTexto.Click += new System.EventHandler(this.ColorTexto_Click);
                        // 
                        // ColorBorde
                        // 
                        this.ColorBorde.Location = new System.Drawing.Point(276, 252);
                        this.ColorBorde.Name = "ColorBorde";
                        this.ColorBorde.Size = new System.Drawing.Size(72, 24);
                        this.ColorBorde.TabIndex = 24;
                        this.ColorBorde.Text = "Borde";
                        this.ColorBorde.UseVisualStyleBackColor = true;
                        this.ColorBorde.Click += new System.EventHandler(this.ColorBorde_Click);
                        // 
                        // EntradaAjusteTexto
                        // 
                        this.EntradaAjusteTexto.AlwaysExpanded = false;
                        this.EntradaAjusteTexto.AutoNav = true;
                        this.EntradaAjusteTexto.AutoTab = true;
                        this.EntradaAjusteTexto.FieldName = null;
                        this.EntradaAjusteTexto.Location = new System.Drawing.Point(108, 184);
                        this.EntradaAjusteTexto.MaxLength = 32767;
                        this.EntradaAjusteTexto.Name = "EntradaAjusteTexto";
                        this.EntradaAjusteTexto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAjusteTexto.PlaceholderText = null;
                        this.EntradaAjusteTexto.ReadOnly = false;
                        this.EntradaAjusteTexto.SetData = new string[] {
        "Sólo un renglon|0",
        "Fluir texto hacia abajo|1"};
                        this.EntradaAjusteTexto.Size = new System.Drawing.Size(288, 24);
                        this.EntradaAjusteTexto.TabIndex = 19;
                        this.EntradaAjusteTexto.TextKey = "0";
                        // 
                        // label9
                        // 
                        this.label9.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label9.Location = new System.Drawing.Point(24, 184);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(80, 24);
                        this.label9.TabIndex = 18;
                        this.label9.Text = "Ajuste";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFormato
                        // 
                        this.EntradaFormato.AlwaysExpanded = false;
                        this.EntradaFormato.AutoNav = true;
                        this.EntradaFormato.AutoTab = true;
                        this.EntradaFormato.Enabled = false;
                        this.EntradaFormato.FieldName = null;
                        this.EntradaFormato.Location = new System.Drawing.Point(108, 56);
                        this.EntradaFormato.MaxLength = 32767;
                        this.EntradaFormato.Name = "EntradaFormato";
                        this.EntradaFormato.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormato.PlaceholderText = null;
                        this.EntradaFormato.ReadOnly = false;
                        this.EntradaFormato.SetData = new string[] {
        "Predeterminado|*",
        "Fecha corta (01/01/2001)|dd/MM/yyyy",
        "Fecha larga (lunes, 1 de enero de 2001)|dddd, d \"de\" MMMM \"de\" yyyy",
        "Fecha y hora (01/01/2001 12:00)|dd/MM/yyyy HH:mm",
        "Numérico con 2 decimales|#.00",
        "Numérico con 4 decimales|#.0000"};
                        this.EntradaFormato.Size = new System.Drawing.Size(408, 24);
                        this.EntradaFormato.TabIndex = 3;
                        this.EntradaFormato.TextKey = "*";
                        // 
                        // EditarCampo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(542, 380);
                        this.Controls.Add(this.EntradaAjusteTexto);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.ColorBorde);
                        this.Controls.Add(this.ColorTexto);
                        this.Controls.Add(this.ColorFondo);
                        this.Controls.Add(this.EntradaAnchoBorde);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.EntradaAlienacionVertical);
                        this.Controls.Add(this.EntradaAlienacionHorizontal);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaFuenteTamano);
                        this.Controls.Add(this.EntradaAlto);
                        this.Controls.Add(this.EntradaAncho);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EntradaFuenteNombre);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaY);
                        this.Controls.Add(this.EntradaX);
                        this.Controls.Add(this.EntradaTexto);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaFormato);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.Label15);
                        this.Name = "EditarCampo";
                        this.Controls.SetChildIndex(this.Label15, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaFormato, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaTexto, 0);
                        this.Controls.SetChildIndex(this.EntradaX, 0);
                        this.Controls.SetChildIndex(this.EntradaY, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaFuenteNombre, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.EntradaAncho, 0);
                        this.Controls.SetChildIndex(this.EntradaAlto, 0);
                        this.Controls.SetChildIndex(this.EntradaFuenteTamano, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.EntradaAlienacionHorizontal, 0);
                        this.Controls.SetChildIndex(this.EntradaAlienacionVertical, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaAnchoBorde, 0);
                        this.Controls.SetChildIndex(this.ColorFondo, 0);
                        this.Controls.SetChildIndex(this.ColorTexto, 0);
                        this.Controls.SetChildIndex(this.ColorBorde, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.EntradaAjusteTexto, 0);
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.Label Label15;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.Label label3;
                internal Lui.Forms.Label label4;
                internal Lui.Forms.Label label5;
                internal Lui.Forms.Label label6;
                internal Lui.Forms.TextBox EntradaTexto;
                internal Lui.Forms.TextBox EntradaX;
                internal Lui.Forms.TextBox EntradaY;
                internal Lui.Forms.ComboBox EntradaFuenteNombre;
                internal Lui.Forms.TextBox EntradaAlto;
                internal Lui.Forms.TextBox EntradaAncho;
                internal Lui.Forms.TextBox EntradaFuenteTamano;
                internal Lui.Forms.Label label7;
                internal Lui.Forms.ComboBox EntradaAlienacionHorizontal;
                internal Lui.Forms.ComboBox EntradaAlienacionVertical;
                internal Lui.Forms.TextBox EntradaAnchoBorde;
                internal Lui.Forms.Label label8;
                internal Button ColorFondo;
                internal Button ColorTexto;
                internal Button ColorBorde;
                internal Lui.Forms.ComboBox EntradaAjusteTexto;
                internal Lui.Forms.Label label9;
                internal Lui.Forms.ComboBox EntradaFormato;
                private System.ComponentModel.IContainer components = null;
        }
}
