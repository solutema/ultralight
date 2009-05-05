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
	public class EditarCampo : Lui.Forms.DialogForm
	{
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
                internal Lui.Forms.ComboBox txtTipo;
		internal Lui.Forms.TextBox txtTexto;
		internal Lui.Forms.TextBox txtX;
		internal Lui.Forms.TextBox txtY;
                internal Lui.Forms.ComboBox txtFuente;
		internal Lui.Forms.TextBox txtH;
		internal Lui.Forms.TextBox txtW;
		internal Lui.Forms.TextBox txtFuenteTamano;
		internal System.Windows.Forms.Label label7;
                internal Lui.Forms.ComboBox txtAlign;
                internal Lui.Forms.ComboBox txtLineAlign;
                internal Lui.Forms.TextBox txtAnchoBorde;
                internal Label label8;
                internal Button ColorFondo;
                internal Button ColorTexto;
                internal Button ColorBorde;
                internal Lui.Forms.ComboBox txtWrap;
                internal Label label9;
		private System.ComponentModel.IContainer components = null;

		public EditarCampo()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
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
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label15 = new System.Windows.Forms.Label();
                        this.txtTexto = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtX = new Lui.Forms.TextBox();
                        this.txtY = new Lui.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.txtFuente = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.txtH = new Lui.Forms.TextBox();
                        this.txtW = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.label6 = new System.Windows.Forms.Label();
                        this.txtFuenteTamano = new Lui.Forms.TextBox();
                        this.txtAlign = new Lui.Forms.ComboBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtLineAlign = new Lui.Forms.ComboBox();
                        this.txtAnchoBorde = new Lui.Forms.TextBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.ColorFondo = new System.Windows.Forms.Button();
                        this.ColorTexto = new System.Windows.Forms.Button();
                        this.ColorBorde = new System.Windows.Forms.Button();
                        this.txtWrap = new Lui.Forms.ComboBox();
                        this.label9 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(326, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(434, 8);
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Enabled = false;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTipo.Location = new System.Drawing.Point(108, 24);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
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
                        this.txtTipo.Size = new System.Drawing.Size(260, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Text = "Texto libre";
                        this.txtTipo.TextKey = "Texto";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
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
                        // txtTexto
                        // 
                        this.txtTexto.AutoNav = true;
                        this.txtTexto.AutoTab = true;
                        this.txtTexto.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtTexto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTexto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTexto.Location = new System.Drawing.Point(108, 56);
                        this.txtTexto.MaxLenght = 32767;
                        this.txtTexto.Name = "txtTexto";
                        this.txtTexto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTexto.ReadOnly = false;
                        this.txtTexto.SelectOnFocus = false;
                        this.txtTexto.Size = new System.Drawing.Size(408, 24);
                        this.txtTexto.TabIndex = 3;
                        this.txtTexto.TipWhenBlank = "";
                        this.txtTexto.ToolTipText = "";
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
                        // txtX
                        // 
                        this.txtX.AutoNav = true;
                        this.txtX.AutoTab = true;
                        this.txtX.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtX.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtX.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtX.Location = new System.Drawing.Point(108, 88);
                        this.txtX.MaxLenght = 32767;
                        this.txtX.Name = "txtX";
                        this.txtX.Padding = new System.Windows.Forms.Padding(2);
                        this.txtX.ReadOnly = false;
                        this.txtX.Size = new System.Drawing.Size(56, 24);
                        this.txtX.Sufijo = "x";
                        this.txtX.TabIndex = 5;
                        this.txtX.TipWhenBlank = "";
                        this.txtX.ToolTipText = "";
                        // 
                        // txtY
                        // 
                        this.txtY.AutoNav = true;
                        this.txtY.AutoTab = true;
                        this.txtY.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtY.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtY.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtY.Location = new System.Drawing.Point(176, 88);
                        this.txtY.MaxLenght = 32767;
                        this.txtY.Name = "txtY";
                        this.txtY.Padding = new System.Windows.Forms.Padding(2);
                        this.txtY.ReadOnly = false;
                        this.txtY.Size = new System.Drawing.Size(56, 24);
                        this.txtY.Sufijo = "y";
                        this.txtY.TabIndex = 7;
                        this.txtY.TipWhenBlank = "";
                        this.txtY.ToolTipText = "";
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
                        // txtFuente
                        // 
                        this.txtFuente.AutoNav = true;
                        this.txtFuente.AutoTab = true;
                        this.txtFuente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFuente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFuente.Location = new System.Drawing.Point(108, 120);
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
                        this.txtFuente.TabIndex = 13;
                        this.txtFuente.Text = "Predeterminada";
                        this.txtFuente.TipWhenBlank = "";
                        this.txtFuente.ToolTipText = "";
                        this.txtFuente.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
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
                        // txtH
                        // 
                        this.txtH.AutoNav = true;
                        this.txtH.AutoTab = true;
                        this.txtH.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtH.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtH.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtH.Location = new System.Drawing.Point(396, 88);
                        this.txtH.MaxLenght = 32767;
                        this.txtH.Name = "txtH";
                        this.txtH.Padding = new System.Windows.Forms.Padding(2);
                        this.txtH.ReadOnly = false;
                        this.txtH.Size = new System.Drawing.Size(56, 24);
                        this.txtH.Sufijo = "v";
                        this.txtH.TabIndex = 11;
                        this.txtH.TipWhenBlank = "";
                        this.txtH.ToolTipText = "";
                        // 
                        // txtW
                        // 
                        this.txtW.AutoNav = true;
                        this.txtW.AutoTab = true;
                        this.txtW.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtW.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtW.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtW.Location = new System.Drawing.Point(324, 88);
                        this.txtW.MaxLenght = 32767;
                        this.txtW.Name = "txtW";
                        this.txtW.Padding = new System.Windows.Forms.Padding(2);
                        this.txtW.ReadOnly = false;
                        this.txtW.Size = new System.Drawing.Size(56, 24);
                        this.txtW.Sufijo = "h";
                        this.txtW.TabIndex = 9;
                        this.txtW.TipWhenBlank = "";
                        this.txtW.ToolTipText = "";
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
                        // txtFuenteTamano
                        // 
                        this.txtFuenteTamano.AutoNav = true;
                        this.txtFuenteTamano.AutoTab = true;
                        this.txtFuenteTamano.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtFuenteTamano.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFuenteTamano.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFuenteTamano.Location = new System.Drawing.Point(372, 120);
                        this.txtFuenteTamano.MaxLenght = 32767;
                        this.txtFuenteTamano.Name = "txtFuenteTamano";
                        this.txtFuenteTamano.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFuenteTamano.ReadOnly = false;
                        this.txtFuenteTamano.Size = new System.Drawing.Size(92, 24);
                        this.txtFuenteTamano.Sufijo = "ptos.";
                        this.txtFuenteTamano.TabIndex = 14;
                        this.txtFuenteTamano.TipWhenBlank = "";
                        this.txtFuenteTamano.ToolTipText = "";
                        this.txtFuenteTamano.TextChanged += new System.EventHandler(this.txtFuente_TextChanged);
                        // 
                        // txtAlign
                        // 
                        this.txtAlign.AutoNav = true;
                        this.txtAlign.AutoTab = true;
                        this.txtAlign.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtAlign.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtAlign.Location = new System.Drawing.Point(108, 152);
                        this.txtAlign.MaxLenght = 32767;
                        this.txtAlign.Name = "txtAlign";
                        this.txtAlign.Padding = new System.Windows.Forms.Padding(2);
                        this.txtAlign.ReadOnly = false;
                        this.txtAlign.SetData = new string[] {
        "Izquierda|Near",
        "Centro|Center",
        "Derecha|Far"};
                        this.txtAlign.Size = new System.Drawing.Size(140, 24);
                        this.txtAlign.TabIndex = 16;
                        this.txtAlign.Text = "Izquierda";
                        this.txtAlign.TextKey = "Near";
                        this.txtAlign.TipWhenBlank = "";
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
                        this.txtLineAlign.AutoNav = true;
                        this.txtLineAlign.AutoTab = true;
                        this.txtLineAlign.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtLineAlign.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtLineAlign.Location = new System.Drawing.Point(256, 152);
                        this.txtLineAlign.MaxLenght = 32767;
                        this.txtLineAlign.Name = "txtLineAlign";
                        this.txtLineAlign.Padding = new System.Windows.Forms.Padding(2);
                        this.txtLineAlign.ReadOnly = false;
                        this.txtLineAlign.SetData = new string[] {
        "Arriba|Near",
        "Centro|Center",
        "Abajo|Far"};
                        this.txtLineAlign.Size = new System.Drawing.Size(140, 24);
                        this.txtLineAlign.TabIndex = 17;
                        this.txtLineAlign.Text = "Arriba";
                        this.txtLineAlign.TextKey = "Near";
                        this.txtLineAlign.TipWhenBlank = "";
                        this.txtLineAlign.ToolTipText = "";
                        // 
                        // txtAnchoBorde
                        // 
                        this.txtAnchoBorde.AutoNav = true;
                        this.txtAnchoBorde.AutoTab = true;
                        this.txtAnchoBorde.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtAnchoBorde.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtAnchoBorde.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtAnchoBorde.Location = new System.Drawing.Point(108, 216);
                        this.txtAnchoBorde.MaxLenght = 32767;
                        this.txtAnchoBorde.Name = "txtAnchoBorde";
                        this.txtAnchoBorde.Padding = new System.Windows.Forms.Padding(2);
                        this.txtAnchoBorde.ReadOnly = false;
                        this.txtAnchoBorde.Size = new System.Drawing.Size(88, 24);
                        this.txtAnchoBorde.TabIndex = 21;
                        this.txtAnchoBorde.TipWhenBlank = "";
                        this.txtAnchoBorde.ToolTipText = "";
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
                        this.txtWrap.AutoNav = true;
                        this.txtWrap.AutoTab = true;
                        this.txtWrap.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtWrap.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtWrap.Location = new System.Drawing.Point(108, 184);
                        this.txtWrap.MaxLenght = 32767;
                        this.txtWrap.Name = "txtWrap";
                        this.txtWrap.Padding = new System.Windows.Forms.Padding(2);
                        this.txtWrap.ReadOnly = false;
                        this.txtWrap.SetData = new string[] {
        "Sólo un renglon|0",
        "Fluir texto hacia abajo|1"};
                        this.txtWrap.Size = new System.Drawing.Size(288, 24);
                        this.txtWrap.TabIndex = 19;
                        this.txtWrap.Text = "Sólo un renglon";
                        this.txtWrap.TextKey = "0";
                        this.txtWrap.TipWhenBlank = "";
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
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(542, 380);
                        this.Controls.Add(this.txtWrap);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.ColorBorde);
                        this.Controls.Add(this.ColorTexto);
                        this.Controls.Add(this.ColorFondo);
                        this.Controls.Add(this.txtAnchoBorde);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.txtLineAlign);
                        this.Controls.Add(this.txtAlign);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.txtFuenteTamano);
                        this.Controls.Add(this.txtH);
                        this.Controls.Add(this.txtW);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.txtFuente);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.txtY);
                        this.Controls.Add(this.txtX);
                        this.Controls.Add(this.txtTexto);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.Label15);
                        this.Name = "EditarCampo";
                        this.Controls.SetChildIndex(this.Label15, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.txtTexto, 0);
                        this.Controls.SetChildIndex(this.txtX, 0);
                        this.Controls.SetChildIndex(this.txtY, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.txtFuente, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.txtW, 0);
                        this.Controls.SetChildIndex(this.txtH, 0);
                        this.Controls.SetChildIndex(this.txtFuenteTamano, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.txtAlign, 0);
                        this.Controls.SetChildIndex(this.txtLineAlign, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.txtAnchoBorde, 0);
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
                        txtFuenteTamano.Enabled = (txtFuente.TextKey != "*");
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

