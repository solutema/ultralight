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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos
{
        public class Movimiento : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Movimiento()
                        : base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }

                        base.Dispose(disposing);
                }

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.ComboBox txtMovimiento;
                internal Lui.Forms.TextBox txtCantidad;
                internal Lui.Forms.TextBox txtObs;
                internal Lui.Forms.TextBox txtStockActual;
                internal Lui.Forms.TextBox txtStockResult;
                internal Lui.Forms.DetailBox txtDesdeSituacion;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.DetailBox txtHaciaSituacion;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.TextBox txtStockResult2;
                internal Lui.Forms.TextBox txtStockActual2;
                internal System.Windows.Forms.Label lblDesdeSituacion;
                internal System.Windows.Forms.Label lblHaciaSituacion;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label6;
                public Lui.Forms.Product EntradaArticulo;
                internal System.Windows.Forms.Label lblStockFlecha2;
                internal System.Windows.Forms.Label lblStockFlecha;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtMovimiento = new Lui.Forms.ComboBox();
                        this.txtCantidad = new Lui.Forms.TextBox();
                        this.txtObs = new Lui.Forms.TextBox();
                        this.lblDesdeSituacion = new System.Windows.Forms.Label();
                        this.lblHaciaSituacion = new System.Windows.Forms.Label();
                        this.txtStockActual = new Lui.Forms.TextBox();
                        this.txtStockResult = new Lui.Forms.TextBox();
                        this.txtDesdeSituacion = new Lui.Forms.DetailBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.txtHaciaSituacion = new Lui.Forms.DetailBox();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.txtStockResult2 = new Lui.Forms.TextBox();
                        this.txtStockActual2 = new Lui.Forms.TextBox();
                        this.lblStockFlecha = new System.Windows.Forms.Label();
                        this.lblStockFlecha2 = new System.Windows.Forms.Label();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EntradaArticulo = new Lui.Forms.Product();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(16, 16);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(108, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Artículo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(16, 48);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(108, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Cantidad";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(16, 272);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(108, 24);
                        this.Label3.TabIndex = 20;
                        this.Label3.Text = "Obs.";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(16, 84);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(108, 24);
                        this.Label4.TabIndex = 4;
                        this.Label4.Text = "Movimiento";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtMovimiento
                        // 
                        this.txtMovimiento.AutoNav = true;
                        this.txtMovimiento.AutoTab = true;
                        this.txtMovimiento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtMovimiento.Location = new System.Drawing.Point(124, 84);
                        this.txtMovimiento.MaxLenght = 32767;
                        this.txtMovimiento.Name = "txtMovimiento";
                        this.txtMovimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.txtMovimiento.ReadOnly = false;
                        this.txtMovimiento.SetData = new string[] {
        " |*",
        "Entrada|e",
        "Salida|s"};
                        this.txtMovimiento.Size = new System.Drawing.Size(192, 24);
                        this.txtMovimiento.TabIndex = 5;
                        this.txtMovimiento.Text = " ";
                        this.txtMovimiento.TextKey = "*";
                        this.txtMovimiento.TipWhenBlank = "";
                        this.txtMovimiento.ToolTipText = "";
                        this.txtMovimiento.TextChanged += new System.EventHandler(this.txtMovimiento_TextChanged);
                        // 
                        // txtCantidad
                        // 
                        this.txtCantidad.AutoNav = true;
                        this.txtCantidad.AutoTab = true;
                        this.txtCantidad.DataType = Lui.Forms.DataTypes.Float;
                        this.txtCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtCantidad.Location = new System.Drawing.Point(124, 48);
                        this.txtCantidad.MaxLenght = 32767;
                        this.txtCantidad.Name = "txtCantidad";
                        this.txtCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCantidad.ReadOnly = false;
                        this.txtCantidad.Size = new System.Drawing.Size(96, 24);
                        this.txtCantidad.TabIndex = 3;
                        this.txtCantidad.Text = "0.00";
                        this.txtCantidad.TipWhenBlank = "";
                        this.txtCantidad.ToolTipText = "";
                        this.txtCantidad.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
                        // 
                        // txtObs
                        // 
                        this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtObs.AutoNav = true;
                        this.txtObs.AutoTab = true;
                        this.txtObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtObs.Location = new System.Drawing.Point(124, 272);
                        this.txtObs.MaxLenght = 32767;
                        this.txtObs.Name = "txtObs";
                        this.txtObs.Padding = new System.Windows.Forms.Padding(2);
                        this.txtObs.ReadOnly = false;
                        this.txtObs.Size = new System.Drawing.Size(496, 24);
                        this.txtObs.TabIndex = 21;
                        this.txtObs.TipWhenBlank = "";
                        this.txtObs.ToolTipText = "";
                        // 
                        // lblDesdeSituacion
                        // 
                        this.lblDesdeSituacion.Location = new System.Drawing.Point(40, 204);
                        this.lblDesdeSituacion.Name = "lblDesdeSituacion";
                        this.lblDesdeSituacion.Size = new System.Drawing.Size(168, 24);
                        this.lblDesdeSituacion.TabIndex = 12;
                        this.lblDesdeSituacion.Text = "Situación 1";
                        this.lblDesdeSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHaciaSituacion
                        // 
                        this.lblHaciaSituacion.Location = new System.Drawing.Point(40, 236);
                        this.lblHaciaSituacion.Name = "lblHaciaSituacion";
                        this.lblHaciaSituacion.Size = new System.Drawing.Size(168, 24);
                        this.lblHaciaSituacion.TabIndex = 16;
                        this.lblHaciaSituacion.Text = "Situación 2";
                        this.lblHaciaSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtStockActual
                        // 
                        this.txtStockActual.AutoNav = true;
                        this.txtStockActual.AutoTab = true;
                        this.txtStockActual.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtStockActual.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtStockActual.Location = new System.Drawing.Point(208, 204);
                        this.txtStockActual.MaxLenght = 32767;
                        this.txtStockActual.Name = "txtStockActual";
                        this.txtStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockActual.ReadOnly = true;
                        this.txtStockActual.Size = new System.Drawing.Size(96, 24);
                        this.txtStockActual.TabIndex = 13;
                        this.txtStockActual.TabStop = false;
                        this.txtStockActual.TipWhenBlank = "";
                        this.txtStockActual.ToolTipText = "";
                        // 
                        // txtStockResult
                        // 
                        this.txtStockResult.AutoNav = true;
                        this.txtStockResult.AutoTab = true;
                        this.txtStockResult.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtStockResult.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtStockResult.Location = new System.Drawing.Point(328, 204);
                        this.txtStockResult.MaxLenght = 32767;
                        this.txtStockResult.Name = "txtStockResult";
                        this.txtStockResult.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockResult.ReadOnly = true;
                        this.txtStockResult.Size = new System.Drawing.Size(96, 24);
                        this.txtStockResult.TabIndex = 15;
                        this.txtStockResult.TabStop = false;
                        this.txtStockResult.TipWhenBlank = "";
                        this.txtStockResult.ToolTipText = "";
                        // 
                        // txtDesdeSituacion
                        // 
                        this.txtDesdeSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDesdeSituacion.AutoTab = true;
                        this.txtDesdeSituacion.CanCreate = false;
                        this.txtDesdeSituacion.DetailField = "nombre";
                        this.txtDesdeSituacion.ExtraDetailFields = "";
                        this.txtDesdeSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDesdeSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDesdeSituacion.FreeTextCode = "";
                        this.txtDesdeSituacion.KeyField = "id_situacion";
                        this.txtDesdeSituacion.Location = new System.Drawing.Point(124, 116);
                        this.txtDesdeSituacion.MaxLength = 200;
                        this.txtDesdeSituacion.Name = "txtDesdeSituacion";
                        this.txtDesdeSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDesdeSituacion.ReadOnly = false;
                        this.txtDesdeSituacion.Required = true;
                        this.txtDesdeSituacion.Size = new System.Drawing.Size(496, 24);
                        this.txtDesdeSituacion.TabIndex = 7;
                        this.txtDesdeSituacion.Table = "articulos_situaciones";
                        this.txtDesdeSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.txtDesdeSituacion.Text = "0";
                        this.txtDesdeSituacion.TextDetail = "";
                        this.txtDesdeSituacion.TextInt = 0;
                        this.txtDesdeSituacion.TipWhenBlank = "";
                        this.txtDesdeSituacion.ToolTipText = "";
                        this.txtDesdeSituacion.TextChanged += new System.EventHandler(this.txtDesdeHaciaSituacion_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(16, 116);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(108, 24);
                        this.Label7.TabIndex = 6;
                        this.Label7.Text = "Origen";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtHaciaSituacion
                        // 
                        this.txtHaciaSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtHaciaSituacion.AutoTab = true;
                        this.txtHaciaSituacion.CanCreate = false;
                        this.txtHaciaSituacion.DetailField = "nombre";
                        this.txtHaciaSituacion.ExtraDetailFields = "";
                        this.txtHaciaSituacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtHaciaSituacion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtHaciaSituacion.FreeTextCode = "";
                        this.txtHaciaSituacion.KeyField = "id_situacion";
                        this.txtHaciaSituacion.Location = new System.Drawing.Point(124, 148);
                        this.txtHaciaSituacion.MaxLength = 200;
                        this.txtHaciaSituacion.Name = "txtHaciaSituacion";
                        this.txtHaciaSituacion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtHaciaSituacion.ReadOnly = false;
                        this.txtHaciaSituacion.Required = true;
                        this.txtHaciaSituacion.Size = new System.Drawing.Size(496, 24);
                        this.txtHaciaSituacion.TabIndex = 9;
                        this.txtHaciaSituacion.Table = "articulos_situaciones";
                        this.txtHaciaSituacion.TeclaDespuesDeEnter = "{tab}";
                        this.txtHaciaSituacion.Text = "0";
                        this.txtHaciaSituacion.TextDetail = "";
                        this.txtHaciaSituacion.TextInt = 0;
                        this.txtHaciaSituacion.TipWhenBlank = "";
                        this.txtHaciaSituacion.ToolTipText = "";
                        this.txtHaciaSituacion.TextChanged += new System.EventHandler(this.txtDesdeHaciaSituacion_TextChanged);
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(16, 148);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(108, 24);
                        this.Label8.TabIndex = 8;
                        this.Label8.Text = "Destino";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtStockResult2
                        // 
                        this.txtStockResult2.AutoNav = true;
                        this.txtStockResult2.AutoTab = true;
                        this.txtStockResult2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtStockResult2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockResult2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtStockResult2.Location = new System.Drawing.Point(328, 236);
                        this.txtStockResult2.MaxLenght = 32767;
                        this.txtStockResult2.Name = "txtStockResult2";
                        this.txtStockResult2.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockResult2.ReadOnly = true;
                        this.txtStockResult2.Size = new System.Drawing.Size(96, 24);
                        this.txtStockResult2.TabIndex = 19;
                        this.txtStockResult2.TabStop = false;
                        this.txtStockResult2.TipWhenBlank = "";
                        this.txtStockResult2.ToolTipText = "";
                        // 
                        // txtStockActual2
                        // 
                        this.txtStockActual2.AutoNav = true;
                        this.txtStockActual2.AutoTab = true;
                        this.txtStockActual2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtStockActual2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockActual2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtStockActual2.Location = new System.Drawing.Point(208, 236);
                        this.txtStockActual2.MaxLenght = 32767;
                        this.txtStockActual2.Name = "txtStockActual2";
                        this.txtStockActual2.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockActual2.ReadOnly = true;
                        this.txtStockActual2.Size = new System.Drawing.Size(96, 24);
                        this.txtStockActual2.TabIndex = 17;
                        this.txtStockActual2.TabStop = false;
                        this.txtStockActual2.TipWhenBlank = "";
                        this.txtStockActual2.ToolTipText = "";
                        // 
                        // lblStockFlecha
                        // 
                        this.lblStockFlecha.Location = new System.Drawing.Point(304, 204);
                        this.lblStockFlecha.Name = "lblStockFlecha";
                        this.lblStockFlecha.Size = new System.Drawing.Size(24, 24);
                        this.lblStockFlecha.TabIndex = 14;
                        this.lblStockFlecha.Text = "->";
                        this.lblStockFlecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblStockFlecha2
                        // 
                        this.lblStockFlecha2.Location = new System.Drawing.Point(304, 236);
                        this.lblStockFlecha2.Name = "lblStockFlecha2";
                        this.lblStockFlecha2.Size = new System.Drawing.Size(24, 24);
                        this.lblStockFlecha2.TabIndex = 18;
                        this.lblStockFlecha2.Text = "->";
                        this.lblStockFlecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label5
                        // 
                        this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label5.Location = new System.Drawing.Point(208, 188);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(96, 16);
                        this.Label5.TabIndex = 10;
                        this.Label5.Text = "Antes";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        // 
                        // Label6
                        // 
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(328, 188);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(96, 16);
                        this.Label6.TabIndex = 11;
                        this.Label6.Text = "Después";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        // 
                        // EntradaArticulo
                        // 
                        this.EntradaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaArticulo.CanCreate = false;
                        this.EntradaArticulo.Changed = false;
                        this.EntradaArticulo.ControlStock = Lui.Forms.Product.ControlesSock.Ambos;
                        this.EntradaArticulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaArticulo.FreeTextCode = "";
                        this.EntradaArticulo.Location = new System.Drawing.Point(124, 16);
                        this.EntradaArticulo.LockPrice = false;
                        this.EntradaArticulo.LockQuantity = false;
                        this.EntradaArticulo.LockText = false;
                        this.EntradaArticulo.MaxLength = 200;
                        this.EntradaArticulo.Name = "EntradaArticulo";
                        this.EntradaArticulo.Precio = Lui.Forms.Product.Precios.PVP;
                        this.EntradaArticulo.Required = true;
                        this.EntradaArticulo.Series = "";
                        this.EntradaArticulo.ShowPrice = false;
                        this.EntradaArticulo.ShowStock = false;
                        this.EntradaArticulo.Size = new System.Drawing.Size(496, 24);
                        this.EntradaArticulo.TabIndex = 1;
                        this.EntradaArticulo.TextDetail = "";
                        this.EntradaArticulo.TextInt = 0;
                        // 
                        // Movimiento
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.EntradaArticulo);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.lblStockFlecha2);
                        this.Controls.Add(this.lblStockFlecha);
                        this.Controls.Add(this.txtStockResult2);
                        this.Controls.Add(this.txtStockActual2);
                        this.Controls.Add(this.txtHaciaSituacion);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.txtDesdeSituacion);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.txtStockResult);
                        this.Controls.Add(this.txtStockActual);
                        this.Controls.Add(this.lblHaciaSituacion);
                        this.Controls.Add(this.lblDesdeSituacion);
                        this.Controls.Add(this.txtObs);
                        this.Controls.Add(this.txtCantidad);
                        this.Controls.Add(this.txtMovimiento);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Name = "Movimiento";
                        this.Text = "Artículos: Entrada y Salida";
                        this.WorkspaceChanged += new System.EventHandler(this.FormArticulosMovim_WorkspaceChanged);
                        this.ResumeLayout(false);

                }

                #endregion

                public override Lfx.Types.OperationResult Ok()
                {
                        Lfx.Types.OperationResult aceptarReturn = new Lfx.Types.SuccessOperationResult();

                        if (EntradaArticulo.TextInt <= 0) {
                                aceptarReturn.Message += "Debe especificar el artículo." + Environment.NewLine;
                                aceptarReturn.Success = false;
                        }

                        if (txtDesdeSituacion.TextInt != txtDesdeSituacion.TextInt) {
                                aceptarReturn.Message += @"Debe ""Desde"" y ""Hacia""." + Environment.NewLine;
                                aceptarReturn.Success = false;
                        }

                        if (Lfx.Types.Parsing.ParseStock(txtCantidad.Text) <= 0) {
                                aceptarReturn.Message += "Debe especificar la cantidad." + Environment.NewLine;
                                aceptarReturn.Success = false;
                        }


                        Lbl.Articulos.Articulo Art = new Lbl.Articulos.Articulo(this.DataBase, EntradaArticulo.TextInt);
                        Art.Cargar();
                        if (Art.RequiereNS) {
                                if (this.Workspace.CurrentUser.AccessList.HasGlobalAcccess()) {
                                        Lui.Forms.YesNoDialog Preg = new Lui.Forms.YesNoDialog("Es un artículo trazable. ¿Desea realizar un movimiento manual de todos modos?", "Advertencia");
                                        if (Preg.ShowDialog() != DialogResult.OK) {
                                                aceptarReturn.Message += "Debe confeccionar un Remito o una Factura." + Environment.NewLine;
                                                aceptarReturn.Success = false;
                                        }
                                } else {
                                        aceptarReturn.Message += "No se pueden realizar movimientos manuales de artículos trazables. Debe confeccionar un Remito o una Factura." + Environment.NewLine;
                                        aceptarReturn.Success = false;
                                }
                        }

                        if (aceptarReturn.Success == true) {
                                DataBase.BeginTransaction(true);
                                double Cantidad = Lfx.Types.Parsing.ParseDouble(txtCantidad.Text);
                                Lbl.Articulos.Situacion Origen, Destino;
                                if (txtDesdeSituacion.TextInt > 0)
                                        Origen = new Lbl.Articulos.Situacion(DataBase, txtDesdeSituacion.TextInt);
                                else
                                        Origen = null;
                                if (txtHaciaSituacion.TextInt > 0)
                                        Destino = new Lbl.Articulos.Situacion(DataBase, txtHaciaSituacion.TextInt);
                                else
                                        Destino = null;
                                Art.MoverStock(Cantidad, txtObs.Text, Origen, Destino, null);
                                DataBase.Commit();
                        }

                        return aceptarReturn;
                }

                private void txtArticulo_TextChanged(System.Object sender, System.EventArgs e)
                {
                        MostrarStock();
                }

                private void txtMovimiento_TextChanged(object sender, System.EventArgs e)
                {
                        switch (txtMovimiento.TextKey) {
                                case "e":
                                        txtDesdeSituacion.TextInt = 998;
                                        txtHaciaSituacion.TextInt = 1;
                                        break;

                                case "s":
                                        txtDesdeSituacion.TextInt = 1;
                                        txtHaciaSituacion.TextInt = 999;
                                        break;
                        }

                        MostrarStock();
                }

                private void txtDesdeHaciaSituacion_TextChanged(object sender, System.EventArgs e)
                {
                        MostrarStock();
                        lblDesdeSituacion.Text = txtDesdeSituacion.TextDetail;
                        lblHaciaSituacion.Text = txtHaciaSituacion.TextDetail;

                        if (txtDesdeSituacion.TextInt == 1 && txtHaciaSituacion.TextInt == 999) {
                                if (txtMovimiento.TextKey != "s")
                                        txtMovimiento.TextKey = "s";
                        } else if (txtDesdeSituacion.TextInt == 998 && txtHaciaSituacion.TextInt == 1) {
                                if (txtMovimiento.TextKey != "e")
                                        txtMovimiento.TextKey = "e";
                        } else {
                                txtMovimiento.TextKey = " ";
                        }

                        txtStockActual.Visible = txtDesdeSituacion.TextInt > 0;
                        lblStockFlecha.Visible = txtDesdeSituacion.TextInt > 0;
                        txtStockResult.Visible = txtDesdeSituacion.TextInt > 0;

                        txtStockActual2.Visible = txtHaciaSituacion.TextInt > 0;
                        lblStockFlecha2.Visible = txtHaciaSituacion.TextInt > 0;
                        txtStockResult2.Visible = txtHaciaSituacion.TextInt > 0;
                }

                private void MostrarStock()
                {
                        int ArticuloId = EntradaArticulo.TextInt;

                        if (ArticuloId > 0 && (txtDesdeSituacion.TextInt != txtHaciaSituacion.TextInt)) {
                                double Cantidad = Lfx.Types.Parsing.ParseStock(txtCantidad.Text);
                                double DesdeCantidad = this.DataBase.FieldDouble("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + ArticuloId.ToString() + " AND id_situacion=" + txtDesdeSituacion.TextInt.ToString());
                                double HaciaCantidad = this.DataBase.FieldDouble("SELECT cantidad FROM articulos_stock WHERE id_articulo=" + ArticuloId.ToString() + " AND id_situacion=" + txtHaciaSituacion.TextInt.ToString());

                                if (txtDesdeSituacion.TextInt < 998 || txtDesdeSituacion.TextInt > 999) {
                                        txtStockActual.Text = Lfx.Types.Formatting.FormatNumber(DesdeCantidad, this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                                        txtStockResult.Text = Lfx.Types.Formatting.FormatNumber(DesdeCantidad - Cantidad, this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                                } else {
                                        txtStockActual.Text = "N/A";
                                        txtStockResult.Text = "N/A";
                                }

                                if (txtHaciaSituacion.TextInt < 998 || txtHaciaSituacion.TextInt > 999) {
                                        txtStockActual2.Text = Lfx.Types.Formatting.FormatNumber(HaciaCantidad, this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                                        txtStockResult2.Text = Lfx.Types.Formatting.FormatNumber(HaciaCantidad + Cantidad, this.Workspace.CurrentConfig.Products.StockDecimalPlaces);
                                } else {
                                        txtStockActual2.Text = "N/A";
                                        txtStockResult2.Text = "N/A";
                                }
                        } else {
                                txtStockActual.Text = "";
                                txtStockResult.Text = "";
                                txtStockActual2.Text = "";
                                txtStockResult2.Text = "";
                        }
                }

                private void FormArticulosMovim_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        txtDesdeSituacion.Visible = this.Workspace.CurrentConfig.Products.StockMultideposito;
                        txtHaciaSituacion.Visible = this.Workspace.CurrentConfig.Products.StockMultideposito;
                        Label7.Visible = this.Workspace.CurrentConfig.Products.StockMultideposito;
                        Label8.Visible = this.Workspace.CurrentConfig.Products.StockMultideposito;
                }

        }
}