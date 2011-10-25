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
	public class EditarCampo : Lui.Forms.DialogForm
	{
		internal Lui.Forms.Label Label15;
		internal Lui.Forms.Label label1;
		internal Lui.Forms.Label label2;
		internal Lui.Forms.Label label3;
		internal Lui.Forms.Label label4;
		internal Lui.Forms.Label label5;
		internal Lui.Forms.Label label6;
                internal Lui.Forms.ComboBox EntradaTipo;
		internal Lui.Forms.TextBox EntradaTexto;
		internal Lui.Forms.TextBox EntradaX;
		internal Lui.Forms.TextBox EntradaY;
                internal Lui.Forms.ComboBox EntradaFuenteNombre;
		internal Lui.Forms.TextBox EntradaAlto;
		internal Lui.Forms.TextBox EntradaAncho;
		internal Lui.Forms.TextBox EntradaFuenteTamano;
		internal Lui.Forms.Label label7;
                internal Lui.Forms.ComboBox txtAlign;
                internal Lui.Forms.ComboBox txtLineAlign;
                internal Lui.Forms.TextBox EntradaAnchoBorde;
                internal Label label8;
                internal Button ColorFondo;
                internal Button ColorTexto;
                internal Button ColorBorde;
                internal Lui.Forms.ComboBox txtWrap;
                internal Label label9;
		private System.ComponentModel.IContainer components = null;

		public EditarCampo()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
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

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
                        this.EntradaTipo = new Lui.Forms.ComboBox();
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
                        this.txtAlign = new Lui.Forms.ComboBox();
                        this.label7 = new Lui.Forms.Label();
                        this.txtLineAlign = new Lui.Forms.ComboBox();
                        this.EntradaAnchoBorde = new Lui.Forms.TextBox();
                        this.label8 = new Lui.Forms.Label();
                        this.ColorFondo = new System.Windows.Forms.Button();
                        this.ColorTexto = new System.Windows.Forms.Button();
                        this.ColorBorde = new System.Windows.Forms.Button();
                        this.txtWrap = new Lui.Forms.ComboBox();
                        this.label9 = new Lui.Forms.Label();
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
                        // txtTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.Enabled = false;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.SetData = new string[] {
        "Fecha del documentos|Fecha",
        "Nombre del cliente|ClienteNombre",
        "Domicilio del cliente|ClienteDomicilio",
        "Situación IVA del cliente|ClienteIVA",
        "CUIT del cliente|ClienteCUIT",
        "Forma de pago|FormaPago",
        "Importe total|Total",
        "Importe total en letras|SonPesos",
        "Artículos: códigos|ArticulosCodigos",
        "Artículos: detalles|ArticulosDetalles",
        "Artículos: cantidades|ArticulosCantidades",
        "Artículos: precios unitarios|ArticulosUnitarios",
        "Artículos: importes|ArticulosImportes",
        "Texto libre|Texto"};
                        this.EntradaTipo.Size = new System.Drawing.Size(260, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.TextKey = "Texto";
                        this.EntradaTipo.PlaceholderText = "";
                        this.EntradaTipo.ToolTipText = "";
                        // 
                        // Label15
                        // 
                        this.Label15.Location = new System.Drawing.Point(24, 24);
                        this.Label15.Name = "Label15";
                        this.Label15.Size = new System.Drawing.Size(80, 24);
                        this.Label15.TabIndex = 0;
                        this.Label15.Text = "Tipo";
                        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTexto
                        // 
                        this.EntradaTexto.AutoNav = true;
                        this.EntradaTexto.AutoTab = true;
                        this.EntradaTexto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTexto.DecimalPlaces = -1;
                        this.EntradaTexto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTexto.Location = new System.Drawing.Point(108, 56);
                        this.EntradaTexto.MultiLine = false;
                        this.EntradaTexto.Name = "EntradaTexto";
                        this.EntradaTexto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTexto.SelectOnFocus = false;
                        this.EntradaTexto.Size = new System.Drawing.Size(408, 24);
                        this.EntradaTexto.TabIndex = 3;
                        this.EntradaTexto.PlaceholderText = "";
                        this.EntradaTexto.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(24, 56);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(80, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Texto";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
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
                        this.EntradaX.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaX.Location = new System.Drawing.Point(108, 88);
                        this.EntradaX.MultiLine = false;
                        this.EntradaX.Name = "EntradaX";
                        this.EntradaX.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaX.SelectOnFocus = true;
                        this.EntradaX.Size = new System.Drawing.Size(56, 24);
                        this.EntradaX.Sufijo = "x";
                        this.EntradaX.TabIndex = 5;
                        this.EntradaX.PlaceholderText = "";
                        this.EntradaX.ToolTipText = "";
                        // 
                        // EntradaY
                        // 
                        this.EntradaY.AutoNav = true;
                        this.EntradaY.AutoTab = true;
                        this.EntradaY.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaY.DecimalPlaces = -1;
                        this.EntradaY.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaY.Location = new System.Drawing.Point(176, 88);
                        this.EntradaY.MultiLine = false;
                        this.EntradaY.Name = "EntradaY";
                        this.EntradaY.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaY.SelectOnFocus = true;
                        this.EntradaY.Size = new System.Drawing.Size(56, 24);
                        this.EntradaY.Sufijo = "y";
                        this.EntradaY.TabIndex = 7;
                        this.EntradaY.PlaceholderText = "";
                        this.EntradaY.ToolTipText = "";
                        // 
                        // label3
                        // 
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
                        this.EntradaFuenteNombre.Location = new System.Drawing.Point(108, 120);
                        this.EntradaFuenteNombre.Name = "EntradaFuenteNombre";
                        this.EntradaFuenteNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteNombre.SetData = new string[] {
        "Predeterminada|*",
        "Serif|Bitstream Vera Serif",
        "Sans Serif|Bitstream Vera Sans",
        "Monoespaciada Bitstream|Bitstream Vera Sans Mono",
        "Monoespaciada Courier|Courier New"};
                        this.EntradaFuenteNombre.Size = new System.Drawing.Size(256, 24);
                        this.EntradaFuenteNombre.TabIndex = 13;
                        this.EntradaFuenteNombre.TextKey = "*";
                        this.EntradaFuenteNombre.PlaceholderText = "";
                        this.EntradaFuenteNombre.ToolTipText = "";
                        this.EntradaFuenteNombre.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
                        // 
                        // label4
                        // 
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
                        this.EntradaAlto.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAlto.Location = new System.Drawing.Point(396, 88);
                        this.EntradaAlto.MultiLine = false;
                        this.EntradaAlto.Name = "EntradaAlto";
                        this.EntradaAlto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAlto.SelectOnFocus = true;
                        this.EntradaAlto.Size = new System.Drawing.Size(56, 24);
                        this.EntradaAlto.Sufijo = "v";
                        this.EntradaAlto.TabIndex = 11;
                        this.EntradaAlto.PlaceholderText = "";
                        this.EntradaAlto.ToolTipText = "";
                        // 
                        // EntradaAncho
                        // 
                        this.EntradaAncho.AutoNav = true;
                        this.EntradaAncho.AutoTab = true;
                        this.EntradaAncho.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAncho.DecimalPlaces = -1;
                        this.EntradaAncho.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaAncho.Location = new System.Drawing.Point(324, 88);
                        this.EntradaAncho.MultiLine = false;
                        this.EntradaAncho.Name = "EntradaAncho";
                        this.EntradaAncho.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAncho.SelectOnFocus = true;
                        this.EntradaAncho.Size = new System.Drawing.Size(56, 24);
                        this.EntradaAncho.Sufijo = "h";
                        this.EntradaAncho.TabIndex = 9;
                        this.EntradaAncho.PlaceholderText = "";
                        this.EntradaAncho.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(380, 88);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(16, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "x";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label6
                        // 
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
                        this.EntradaFuenteTamano.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFuenteTamano.Location = new System.Drawing.Point(372, 120);
                        this.EntradaFuenteTamano.MultiLine = false;
                        this.EntradaFuenteTamano.Name = "EntradaFuenteTamano";
                        this.EntradaFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFuenteTamano.SelectOnFocus = true;
                        this.EntradaFuenteTamano.Size = new System.Drawing.Size(92, 24);
                        this.EntradaFuenteTamano.Sufijo = "ptos.";
                        this.EntradaFuenteTamano.TabIndex = 14;
                        this.EntradaFuenteTamano.Text = "10";
                        this.EntradaFuenteTamano.PlaceholderText = "";
                        this.EntradaFuenteTamano.ToolTipText = "";
                        this.EntradaFuenteTamano.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
                        // 
                        // txtAlign
                        // 
                        this.txtAlign.AlwaysExpanded = false;
                        this.txtAlign.AutoNav = true;
                        this.txtAlign.AutoTab = true;
                        this.txtAlign.Location = new System.Drawing.Point(108, 152);
                        this.txtAlign.Name = "txtAlign";
                        this.txtAlign.Padding = new System.Windows.Forms.Padding(2);
                        this.txtAlign.SetData = new string[] {
        "Izquierda|Near",
        "Centro|Center",
        "Derecha|Far"};
                        this.txtAlign.Size = new System.Drawing.Size(140, 24);
                        this.txtAlign.TabIndex = 16;
                        this.txtAlign.TextKey = "Near";
                        this.txtAlign.PlaceholderText = "";
                        this.txtAlign.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(24, 152);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(80, 24);
                        this.label7.TabIndex = 15;
                        this.label7.Text = "Alineación";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtLineAlign
                        // 
                        this.txtLineAlign.AlwaysExpanded = false;
                        this.txtLineAlign.AutoNav = true;
                        this.txtLineAlign.AutoTab = true;
                        this.txtLineAlign.Location = new System.Drawing.Point(256, 152);
                        this.txtLineAlign.Name = "txtLineAlign";
                        this.txtLineAlign.Padding = new System.Windows.Forms.Padding(2);
                        this.txtLineAlign.SetData = new string[] {
        "Arriba|Near",
        "Centro|Center",
        "Abajo|Far"};
                        this.txtLineAlign.Size = new System.Drawing.Size(140, 24);
                        this.txtLineAlign.TabIndex = 17;
                        this.txtLineAlign.TextKey = "Near";
                        this.txtLineAlign.PlaceholderText = "";
                        this.txtLineAlign.ToolTipText = "";
                        // 
                        // EntradaAnchoBorde
                        // 
                        this.EntradaAnchoBorde.AutoNav = true;
                        this.EntradaAnchoBorde.AutoTab = true;
                        this.EntradaAnchoBorde.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaAnchoBorde.DecimalPlaces = -1;
                        this.EntradaAnchoBorde.Location = new System.Drawing.Point(108, 216);
                        this.EntradaAnchoBorde.MultiLine = false;
                        this.EntradaAnchoBorde.Name = "EntradaAnchoBorde";
                        this.EntradaAnchoBorde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAnchoBorde.SelectOnFocus = true;
                        this.EntradaAnchoBorde.Size = new System.Drawing.Size(88, 24);
                        this.EntradaAnchoBorde.TabIndex = 21;
                        this.EntradaAnchoBorde.PlaceholderText = "";
                        this.EntradaAnchoBorde.ToolTipText = "";
                        // 
                        // label8
                        // 
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
                        // txtWrap
                        // 
                        this.txtWrap.AlwaysExpanded = false;
                        this.txtWrap.AutoNav = true;
                        this.txtWrap.AutoTab = true;
                        this.txtWrap.Location = new System.Drawing.Point(108, 184);
                        this.txtWrap.Name = "txtWrap";
                        this.txtWrap.Padding = new System.Windows.Forms.Padding(2);
                        this.txtWrap.SetData = new string[] {
        "Sólo un renglon|0",
        "Fluir texto hacia abajo|1"};
                        this.txtWrap.Size = new System.Drawing.Size(288, 24);
                        this.txtWrap.TabIndex = 19;
                        this.txtWrap.TextKey = "0";
                        this.txtWrap.PlaceholderText = "";
                        this.txtWrap.ToolTipText = "";
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(24, 184);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(80, 24);
                        this.label9.TabIndex = 18;
                        this.label9.Text = "Ajuste";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EditarCampo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(542, 380);
                        this.Controls.Add(this.txtWrap);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.ColorBorde);
                        this.Controls.Add(this.ColorTexto);
                        this.Controls.Add(this.ColorFondo);
                        this.Controls.Add(this.EntradaAnchoBorde);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.txtLineAlign);
                        this.Controls.Add(this.txtAlign);
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
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.Label15);
                        this.Name = "EditarCampo";
                        this.Controls.SetChildIndex(this.Label15, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
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
                        this.Controls.SetChildIndex(this.txtAlign, 0);
                        this.Controls.SetChildIndex(this.txtLineAlign, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaAnchoBorde, 0);
                        this.Controls.SetChildIndex(this.ColorFondo, 0);
                        this.Controls.SetChildIndex(this.ColorTexto, 0);
                        this.Controls.SetChildIndex(this.ColorBorde, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.txtWrap, 0);
                        this.ResumeLayout(false);

		}
		#endregion

                private void txtFuente_TextChanged(object sender, EventArgs e)
                {
                        EntradaFuenteTamano.Enabled = (EntradaFuenteNombre.TextKey != "*");
                }

                private void ColorFondo_Click(object sender, EventArgs e)
                {
                        ColorDialog ColDlg = new ColorDialog();
                        ColDlg.Color = ColorFondo.BackColor;
                        if (ColDlg.ShowDialog() == DialogResult.OK)
                                ColorFondo.BackColor = ColDlg.Color;
                }

                private void ColorTexto_Click(object sender, EventArgs e)
                {
                        ColorDialog ColDlg = new ColorDialog();
                        ColDlg.Color = ColorTexto.BackColor;
                        if (ColDlg.ShowDialog() == DialogResult.OK)
                                ColorTexto.BackColor = ColDlg.Color;
                }

                private void ColorBorde_Click(object sender, EventArgs e)
                {
                        ColorDialog ColDlg = new ColorDialog();
                        ColDlg.Color = ColorBorde.BackColor;
                        if (ColDlg.ShowDialog() == DialogResult.OK)
                                ColorBorde.BackColor = ColDlg.Color;
                }
	}
}

