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
using System.Text;

namespace Lfc.Comprobantes.Tipo
{
        public partial class Editar
        {
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label label1;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaLetra;
                private System.ComponentModel.IContainer components = null;

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

                private void InitializeComponent()
                {
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaLetra = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaMueveStock = new Lui.Forms.ComboBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.EntradaSituacionOrigen = new Lcc.Entrada.CodigoDetalle();
                        this.label3 = new System.Windows.Forms.Label();
                        this.EntradaSituacionDestino = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaNumerarAl = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaImprimirRepetir = new Lui.Forms.ComboBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaImprimirModificar = new Lui.Forms.ComboBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.EntradaImprimirGuardar = new Lui.Forms.ComboBox();
                        this.label9 = new System.Windows.Forms.Label();
                        this.GroupLabel = new System.Windows.Forms.Label();
                        this.Listado = new Lui.Forms.ListView();
                        this.ColCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColSucursal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColEstacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColPv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColImpresora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.BotonQuitar = new Lui.Forms.Button();
                        this.BotonAgregar = new Lui.Forms.Button();
                        this.SuspendLayout();
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
                        this.EntradaNombre.Location = new System.Drawing.Point(120, 0);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(320, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.PlaceholderText = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(0, 0);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(116, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaLetra
                        // 
                        this.EntradaLetra.AutoNav = true;
                        this.EntradaLetra.AutoTab = true;
                        this.EntradaLetra.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaLetra.DecimalPlaces = -1;
                        this.EntradaLetra.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaLetra.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaLetra.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaLetra.Location = new System.Drawing.Point(120, 32);
                        this.EntradaLetra.MaxLenght = 32767;
                        this.EntradaLetra.MultiLine = false;
                        this.EntradaLetra.Name = "EntradaLetra";
                        this.EntradaLetra.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaLetra.PasswordChar = '\0';
                        this.EntradaLetra.Prefijo = "";
                        this.EntradaLetra.SelectOnFocus = true;
                        this.EntradaLetra.Size = new System.Drawing.Size(320, 24);
                        this.EntradaLetra.Sufijo = "";
                        this.EntradaLetra.TabIndex = 3;
                        this.EntradaLetra.PlaceholderText = "";
                        this.EntradaLetra.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(0, 32);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(116, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Tipo";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(0, 64);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(116, 24);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Mueve Stock";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaMueveStock
                        // 
                        this.EntradaMueveStock.AutoNav = true;
                        this.EntradaMueveStock.AutoTab = true;
                        this.EntradaMueveStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaMueveStock.Location = new System.Drawing.Point(120, 64);
                        this.EntradaMueveStock.MaxLenght = 32767;
                        this.EntradaMueveStock.Name = "EntradaMueveStock";
                        this.EntradaMueveStock.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaMueveStock.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaMueveStock.Size = new System.Drawing.Size(100, 24);
                        this.EntradaMueveStock.TabIndex = 5;
                        this.EntradaMueveStock.TextKey = "1";
                        this.EntradaMueveStock.PlaceholderText = "";
                        this.EntradaMueveStock.ToolTipText = "";
                        this.EntradaMueveStock.TextChanged += new System.EventHandler(this.EntradaMueveStock_TextChanged);
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(64, 100);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(76, 24);
                        this.label7.TabIndex = 6;
                        this.label7.Text = "Desde";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSituacionOrigen
                        // 
                        this.EntradaSituacionOrigen.AutoNav = true;
                        this.EntradaSituacionOrigen.AutoTab = true;
                        this.EntradaSituacionOrigen.CanCreate = true;
                        this.EntradaSituacionOrigen.DataTextField = "nombre";
                        this.EntradaSituacionOrigen.ExtraDetailFields = null;
                        this.EntradaSituacionOrigen.Filter = "";
                        this.EntradaSituacionOrigen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSituacionOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSituacionOrigen.FreeTextCode = "";
                        this.EntradaSituacionOrigen.DataValueField = "id_situacion";
                        this.EntradaSituacionOrigen.Location = new System.Drawing.Point(140, 100);
                        this.EntradaSituacionOrigen.MaxLength = 200;
                        this.EntradaSituacionOrigen.Name = "EntradaSituacionOrigen";
                        this.EntradaSituacionOrigen.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacionOrigen.Required = true;
                        this.EntradaSituacionOrigen.Size = new System.Drawing.Size(240, 24);
                        this.EntradaSituacionOrigen.TabIndex = 7;
                        this.EntradaSituacionOrigen.Table = "articulos_situaciones";
                        this.EntradaSituacionOrigen.Text = "0";
                        this.EntradaSituacionOrigen.TextDetail = "";
                        this.EntradaSituacionOrigen.PlaceholderText = "Sin especificar";
                        this.EntradaSituacionOrigen.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(64, 128);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(76, 24);
                        this.label3.TabIndex = 8;
                        this.label3.Text = "Hacia";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSituacionDestino
                        // 
                        this.EntradaSituacionDestino.AutoNav = true;
                        this.EntradaSituacionDestino.AutoTab = true;
                        this.EntradaSituacionDestino.CanCreate = true;
                        this.EntradaSituacionDestino.DataTextField = "nombre";
                        this.EntradaSituacionDestino.ExtraDetailFields = null;
                        this.EntradaSituacionDestino.Filter = "";
                        this.EntradaSituacionDestino.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSituacionDestino.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSituacionDestino.FreeTextCode = "";
                        this.EntradaSituacionDestino.DataValueField = "id_situacion";
                        this.EntradaSituacionDestino.Location = new System.Drawing.Point(140, 128);
                        this.EntradaSituacionDestino.MaxLength = 200;
                        this.EntradaSituacionDestino.Name = "EntradaSituacionDestino";
                        this.EntradaSituacionDestino.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSituacionDestino.Required = true;
                        this.EntradaSituacionDestino.Size = new System.Drawing.Size(240, 24);
                        this.EntradaSituacionDestino.TabIndex = 9;
                        this.EntradaSituacionDestino.Table = "articulos_situaciones";
                        this.EntradaSituacionDestino.Text = "0";
                        this.EntradaSituacionDestino.TextDetail = "";
                        this.EntradaSituacionDestino.PlaceholderText = "Sin especificar";
                        this.EntradaSituacionDestino.ToolTipText = "";
                        // 
                        // EntradaNumerarAl
                        // 
                        this.EntradaNumerarAl.AutoNav = true;
                        this.EntradaNumerarAl.AutoTab = true;
                        this.EntradaNumerarAl.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaNumerarAl.Location = new System.Drawing.Point(120, 164);
                        this.EntradaNumerarAl.MaxLenght = 32767;
                        this.EntradaNumerarAl.Name = "EntradaNumerarAl";
                        this.EntradaNumerarAl.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumerarAl.SetData = new string[] {
        "Manualmente|0",
        "Cuando se crea el comprobante|1",
        "Cuando se imprime el comprobante|2"};
                        this.EntradaNumerarAl.Size = new System.Drawing.Size(248, 24);
                        this.EntradaNumerarAl.TabIndex = 11;
                        this.EntradaNumerarAl.Text = "Cuando se crea el comprobante";
                        this.EntradaNumerarAl.TextKey = "1";
                        this.EntradaNumerarAl.PlaceholderText = "";
                        this.EntradaNumerarAl.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 164);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(116, 24);
                        this.label4.TabIndex = 10;
                        this.label4.Text = "Numerar";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImprimirRepetir
                        // 
                        this.EntradaImprimirRepetir.AutoNav = true;
                        this.EntradaImprimirRepetir.AutoTab = true;
                        this.EntradaImprimirRepetir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaImprimirRepetir.Location = new System.Drawing.Point(380, 244);
                        this.EntradaImprimirRepetir.MaxLenght = 32767;
                        this.EntradaImprimirRepetir.Name = "EntradaImprimirRepetir";
                        this.EntradaImprimirRepetir.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImprimirRepetir.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaImprimirRepetir.Size = new System.Drawing.Size(52, 24);
                        this.EntradaImprimirRepetir.TabIndex = 13;
                        this.EntradaImprimirRepetir.Text = "Si";
                        this.EntradaImprimirRepetir.TextKey = "1";
                        this.EntradaImprimirRepetir.PlaceholderText = "";
                        this.EntradaImprimirRepetir.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(0, 244);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(376, 24);
                        this.label6.TabIndex = 12;
                        this.label6.Text = "Permite imprimir varias veces el mismo comprobante";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImprimirModificar
                        // 
                        this.EntradaImprimirModificar.AutoNav = true;
                        this.EntradaImprimirModificar.AutoTab = true;
                        this.EntradaImprimirModificar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaImprimirModificar.Location = new System.Drawing.Point(380, 276);
                        this.EntradaImprimirModificar.MaxLenght = 32767;
                        this.EntradaImprimirModificar.Name = "EntradaImprimirModificar";
                        this.EntradaImprimirModificar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImprimirModificar.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaImprimirModificar.Size = new System.Drawing.Size(52, 24);
                        this.EntradaImprimirModificar.TabIndex = 15;
                        this.EntradaImprimirModificar.Text = "Si";
                        this.EntradaImprimirModificar.TextKey = "1";
                        this.EntradaImprimirModificar.PlaceholderText = "";
                        this.EntradaImprimirModificar.ToolTipText = "";
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 276);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(376, 24);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "Permite modificar comprobantes impresos";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImprimirGuardar
                        // 
                        this.EntradaImprimirGuardar.AutoNav = true;
                        this.EntradaImprimirGuardar.AutoTab = true;
                        this.EntradaImprimirGuardar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaImprimirGuardar.Location = new System.Drawing.Point(380, 308);
                        this.EntradaImprimirGuardar.MaxLenght = 32767;
                        this.EntradaImprimirGuardar.Name = "EntradaImprimirGuardar";
                        this.EntradaImprimirGuardar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImprimirGuardar.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaImprimirGuardar.Size = new System.Drawing.Size(52, 24);
                        this.EntradaImprimirGuardar.TabIndex = 17;
                        this.EntradaImprimirGuardar.Text = "Si";
                        this.EntradaImprimirGuardar.TextKey = "1";
                        this.EntradaImprimirGuardar.PlaceholderText = "";
                        this.EntradaImprimirGuardar.ToolTipText = "";
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(0, 308);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(376, 24);
                        this.label9.TabIndex = 16;
                        this.label9.Text = "Imprimir automáticamente al guardar el comprobante";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // GroupLabel
                        // 
                        this.GroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.GroupLabel.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.GroupLabel.Location = new System.Drawing.Point(468, 0);
                        this.GroupLabel.Name = "GroupLabel";
                        this.GroupLabel.Size = new System.Drawing.Size(368, 24);
                        this.GroupLabel.TabIndex = 18;
                        this.GroupLabel.Text = "Dónde se imprime";
                        this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.GroupLabel.UseMnemonic = false;
                        // 
                        // Listado
                        // 
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColCod,
            this.ColSucursal,
            this.ColEstacion,
            this.ColPv,
            this.ColImpresora});
                        this.Listado.FullRowSelect = true;
                        this.Listado.GridLines = true;
                        this.Listado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.Listado.LabelWrap = false;
                        this.Listado.Location = new System.Drawing.Point(468, 32);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "Listado";
                        this.Listado.Size = new System.Drawing.Size(368, 268);
                        this.Listado.TabIndex = 19;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        // 
                        // ColCod
                        // 
                        this.ColCod.Text = "Cod";
                        this.ColCod.Width = 0;
                        // 
                        // ColSucursal
                        // 
                        this.ColSucursal.Text = "Sucursal";
                        this.ColSucursal.Width = 160;
                        // 
                        // ColEstacion
                        // 
                        this.ColEstacion.Text = "Estacion";
                        this.ColEstacion.Width = 160;
                        // 
                        // ColPv
                        // 
                        this.ColPv.Text = "PV";
                        this.ColPv.Width = 96;
                        // 
                        // ColImpresora
                        // 
                        this.ColImpresora.Text = "Se imprime en";
                        this.ColImpresora.Width = 160;
                        // 
                        // BotonQuitar
                        // 
                        this.BotonQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonQuitar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonQuitar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonQuitar.Image = null;
                        this.BotonQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonQuitar.Location = new System.Drawing.Point(620, 308);
                        this.BotonQuitar.Name = "BotonQuitar";
                        this.BotonQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonQuitar.Size = new System.Drawing.Size(104, 28);
                        this.BotonQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonQuitar.Subtext = "";
                        this.BotonQuitar.TabIndex = 20;
                        this.BotonQuitar.Text = "Quitar";
                        this.BotonQuitar.ToolTipText = "";
                        this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
                        // 
                        // BotonAgregar
                        // 
                        this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonAgregar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonAgregar.Image = null;
                        this.BotonAgregar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonAgregar.Location = new System.Drawing.Point(732, 308);
                        this.BotonAgregar.Name = "BotonAgregar";
                        this.BotonAgregar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonAgregar.Size = new System.Drawing.Size(104, 28);
                        this.BotonAgregar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonAgregar.Subtext = "F6";
                        this.BotonAgregar.TabIndex = 21;
                        this.BotonAgregar.Text = "Agregar";
                        this.BotonAgregar.ToolTipText = "";
                        this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
                        // 
                        // Editar
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.Controls.Add(this.BotonQuitar);
                        this.Controls.Add(this.BotonAgregar);
                        this.Controls.Add(this.Listado);
                        this.Controls.Add(this.GroupLabel);
                        this.Controls.Add(this.EntradaImprimirGuardar);
                        this.Controls.Add(this.EntradaImprimirModificar);
                        this.Controls.Add(this.EntradaImprimirRepetir);
                        this.Controls.Add(this.EntradaNumerarAl);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EntradaSituacionDestino);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaSituacionOrigen);
                        this.Controls.Add(this.EntradaMueveStock);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaLetra);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label6);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(838, 337);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.label9, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.EntradaLetra, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.EntradaMueveStock, 0);
                        this.Controls.SetChildIndex(this.EntradaSituacionOrigen, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.EntradaSituacionDestino, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.EntradaNumerarAl, 0);
                        this.Controls.SetChildIndex(this.EntradaImprimirRepetir, 0);
                        this.Controls.SetChildIndex(this.EntradaImprimirModificar, 0);
                        this.Controls.SetChildIndex(this.EntradaImprimirGuardar, 0);
                        this.Controls.SetChildIndex(this.GroupLabel, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.BotonAgregar, 0);
                        this.Controls.SetChildIndex(this.BotonQuitar, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                private Lui.Forms.ComboBox EntradaMueveStock;
                internal System.Windows.Forms.Label label7;
                internal Lcc.Entrada.CodigoDetalle EntradaSituacionOrigen;
                internal System.Windows.Forms.Label label3;
                internal Lcc.Entrada.CodigoDetalle EntradaSituacionDestino;
                private Lui.Forms.ComboBox EntradaNumerarAl;
                internal System.Windows.Forms.Label label4;
                private Lui.Forms.ComboBox EntradaImprimirRepetir;
                internal System.Windows.Forms.Label label6;
                private Lui.Forms.ComboBox EntradaImprimirModificar;
                internal System.Windows.Forms.Label label8;
                private Lui.Forms.ComboBox EntradaImprimirGuardar;
                internal System.Windows.Forms.Label label9;
                private System.Windows.Forms.Label GroupLabel;
                private Lui.Forms.ListView Listado;
                private System.Windows.Forms.ColumnHeader ColCod;
                private System.Windows.Forms.ColumnHeader ColSucursal;
                private System.Windows.Forms.ColumnHeader ColEstacion;
                private System.Windows.Forms.ColumnHeader ColPv;
                internal Lui.Forms.Button BotonQuitar;
                internal Lui.Forms.Button BotonAgregar;
                private System.Windows.Forms.ColumnHeader ColImpresora;
        }
}
