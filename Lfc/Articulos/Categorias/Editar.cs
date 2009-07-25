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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Articulos.Categorias
{
        public class Editar :
            Lui.Forms.EditForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Editar()
                        :
                    base()
                {

                        //
                        // Necesario para admitir el Diseñador de Windows Forms
                        //
                        InitializeComponent();

                        //
                        // agregar código de constructor después de llamar a InitializeComponent
                        //

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing)
                        {
                                if (components != null)
                                {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.TextBox txtNombre;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox txtStockMinimo;
                internal System.Windows.Forms.Label Label11;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.Frame Frame1;
                internal Lui.Forms.Frame Frame2;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox txtNombreSing;
                internal Lui.Forms.TextBox txtItem;
                internal Lui.Forms.TextBox txtStockActual;
                internal Lui.Forms.TextBox txtCosto;
                internal Lui.Forms.TextBox txtItemStock;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.Button cmdImagenQuitar;
                internal Lui.Forms.Button cmdImagen;
                internal System.Windows.Forms.PictureBox pctImagen;
                internal Lui.Forms.Frame Frame3;
                internal Lui.Forms.ComboBox txtWeb;
                internal System.Windows.Forms.Label Label7;
                private Lui.Forms.DetailBox txtRubro;
                internal System.Windows.Forms.Label label9;
                internal System.Windows.Forms.Label Label8;

                private void InitializeComponent()
                {
                        this.txtNombre = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtNombreSing = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtStockMinimo = new Lui.Forms.TextBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.txtItem = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Frame1 = new Lui.Forms.Frame();
                        this.label9 = new System.Windows.Forms.Label();
                        this.txtRubro = new Lui.Forms.DetailBox();
                        this.txtWeb = new Lui.Forms.ComboBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.Frame2 = new Lui.Forms.Frame();
                        this.txtStockActual = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtCosto = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtItemStock = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.cmdImagenQuitar = new Lui.Forms.Button();
                        this.cmdImagen = new Lui.Forms.Button();
                        this.pctImagen = new System.Windows.Forms.PictureBox();
                        this.Frame3 = new Lui.Forms.Frame();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Frame1.SuspendLayout();
                        this.Frame2.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
                        this.Frame3.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(476, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(584, 8);
                        // 
                        // txtNombre
                        // 
                        this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtNombre.AutoNav = true;
                        this.txtNombre.AutoTab = true;
                        this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtNombre.Location = new System.Drawing.Point(116, 40);
                        this.txtNombre.MaxLenght = 32767;
                        this.txtNombre.Name = "txtNombre";
                        this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNombre.ReadOnly = false;
                        this.txtNombre.SelectOnFocus = false;
                        this.txtNombre.Size = new System.Drawing.Size(548, 24);
                        this.txtNombre.TabIndex = 1;
                        this.txtNombre.TipWhenBlank = "";
                        this.txtNombre.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 40);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(104, 24);
                        this.Label5.TabIndex = 0;
                        this.Label5.Text = "Nombre";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtNombreSing
                        // 
                        this.txtNombreSing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtNombreSing.AutoNav = true;
                        this.txtNombreSing.AutoTab = true;
                        this.txtNombreSing.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNombreSing.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNombreSing.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtNombreSing.Location = new System.Drawing.Point(116, 68);
                        this.txtNombreSing.MaxLenght = 32767;
                        this.txtNombreSing.Name = "txtNombreSing";
                        this.txtNombreSing.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNombreSing.ReadOnly = false;
                        this.txtNombreSing.SelectOnFocus = false;
                        this.txtNombreSing.Size = new System.Drawing.Size(548, 24);
                        this.txtNombreSing.TabIndex = 3;
                        this.txtNombreSing.TipWhenBlank = "";
                        this.txtNombreSing.ToolTipText = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(12, 68);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(104, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Nombre ítem";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtStockMinimo
                        // 
                        this.txtStockMinimo.AutoNav = true;
                        this.txtStockMinimo.AutoTab = true;
                        this.txtStockMinimo.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtStockMinimo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockMinimo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtStockMinimo.Location = new System.Drawing.Point(116, 100);
                        this.txtStockMinimo.MaxLenght = 32767;
                        this.txtStockMinimo.Name = "txtStockMinimo";
                        this.txtStockMinimo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockMinimo.ReadOnly = false;
                        this.txtStockMinimo.Size = new System.Drawing.Size(108, 24);
                        this.txtStockMinimo.TabIndex = 5;
                        this.txtStockMinimo.Text = "0";
                        this.txtStockMinimo.TipWhenBlank = "";
                        this.txtStockMinimo.ToolTipText = "";
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(12, 100);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(104, 24);
                        this.Label11.TabIndex = 4;
                        this.Label11.Text = "Stock Mínimo";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtItem
                        // 
                        this.txtItem.AutoNav = true;
                        this.txtItem.AutoTab = true;
                        this.txtItem.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtItem.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtItem.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtItem.Location = new System.Drawing.Point(120, 36);
                        this.txtItem.MaxLenght = 32767;
                        this.txtItem.Name = "txtItem";
                        this.txtItem.Padding = new System.Windows.Forms.Padding(2);
                        this.txtItem.ReadOnly = false;
                        this.txtItem.Size = new System.Drawing.Size(108, 24);
                        this.txtItem.TabIndex = 1;
                        this.txtItem.TabStop = false;
                        this.txtItem.Text = "0";
                        this.txtItem.TipWhenBlank = "";
                        this.txtItem.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(12, 36);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(108, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Ítem";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame1
                        // 
                        this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Frame1.Controls.Add(this.label9);
                        this.Frame1.Controls.Add(this.txtRubro);
                        this.Frame1.Controls.Add(this.txtWeb);
                        this.Frame1.Controls.Add(this.txtNombre);
                        this.Frame1.Controls.Add(this.Label5);
                        this.Frame1.Controls.Add(this.txtNombreSing);
                        this.Frame1.Controls.Add(this.Label1);
                        this.Frame1.Controls.Add(this.txtStockMinimo);
                        this.Frame1.Controls.Add(this.Label11);
                        this.Frame1.Controls.Add(this.Label7);
                        this.Frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame1.Location = new System.Drawing.Point(8, 8);
                        this.Frame1.Name = "Frame1";
                        this.Frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame1.ReadOnly = false;
                        this.Frame1.Size = new System.Drawing.Size(676, 168);
                        this.Frame1.TabIndex = 0;
                        this.Frame1.Text = "Detalles";
                        this.Frame1.ToolTipText = "";
                        // 
                        // label9
                        // 
                        this.label9.Location = new System.Drawing.Point(12, 132);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(104, 24);
                        this.label9.TabIndex = 8;
                        this.label9.Text = "Rubro";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtRubro
                        // 
                        this.txtRubro.AutoTab = true;
                        this.txtRubro.CanCreate = true;
                        this.txtRubro.DetailField = "nombre";
                        this.txtRubro.ExtraDetailFields = "";
                        this.txtRubro.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtRubro.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtRubro.FreeTextCode = "";
                        this.txtRubro.KeyField = "id_rubro";
                        this.txtRubro.Location = new System.Drawing.Point(116, 132);
                        this.txtRubro.MaxLength = 200;
                        this.txtRubro.Name = "txtRubro";
                        this.txtRubro.Padding = new System.Windows.Forms.Padding(2);
                        this.txtRubro.ReadOnly = false;
                        this.txtRubro.Required = true;
                        this.txtRubro.SelectOnFocus = false;
                        this.txtRubro.Size = new System.Drawing.Size(428, 24);
                        this.txtRubro.TabIndex = 9;
                        this.txtRubro.Table = "articulos_rubros";
                        this.txtRubro.TeclaDespuesDeEnter = "{tab}";
                        this.txtRubro.Text = "0";
                        this.txtRubro.TextDetail = "";
                        this.txtRubro.TextInt = 0;
                        this.txtRubro.TipWhenBlank = "Sin especificar";
                        this.txtRubro.ToolTipText = "";
                        // 
                        // txtWeb
                        // 
                        this.txtWeb.AutoNav = true;
                        this.txtWeb.AutoTab = true;
                        this.txtWeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtWeb.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtWeb.Location = new System.Drawing.Point(388, 100);
                        this.txtWeb.MaxLenght = 32767;
                        this.txtWeb.Name = "txtWeb";
                        this.txtWeb.Padding = new System.Windows.Forms.Padding(2);
                        this.txtWeb.ReadOnly = false;
                        this.txtWeb.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.txtWeb.Size = new System.Drawing.Size(108, 24);
                        this.txtWeb.TabIndex = 7;
                        this.txtWeb.Text = "No";
                        this.txtWeb.TextKey = "0";
                        this.txtWeb.TipWhenBlank = "";
                        this.txtWeb.ToolTipText = "";
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(248, 100);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(140, 24);
                        this.Label7.TabIndex = 6;
                        this.Label7.Text = "Publicar en la Web*";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Frame2
                        // 
                        this.Frame2.Controls.Add(this.txtStockActual);
                        this.Frame2.Controls.Add(this.Label3);
                        this.Frame2.Controls.Add(this.txtCosto);
                        this.Frame2.Controls.Add(this.Label4);
                        this.Frame2.Controls.Add(this.txtItemStock);
                        this.Frame2.Controls.Add(this.txtItem);
                        this.Frame2.Controls.Add(this.Label2);
                        this.Frame2.Controls.Add(this.Label6);
                        this.Frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame2.Location = new System.Drawing.Point(8, 188);
                        this.Frame2.Name = "Frame2";
                        this.Frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame2.ReadOnly = false;
                        this.Frame2.Size = new System.Drawing.Size(244, 168);
                        this.Frame2.TabIndex = 1;
                        this.Frame2.TabStop = false;
                        this.Frame2.Text = "Estadsticas";
                        this.Frame2.ToolTipText = "";
                        // 
                        // txtStockActual
                        // 
                        this.txtStockActual.AutoNav = true;
                        this.txtStockActual.AutoTab = true;
                        this.txtStockActual.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtStockActual.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtStockActual.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtStockActual.Location = new System.Drawing.Point(120, 68);
                        this.txtStockActual.MaxLenght = 32767;
                        this.txtStockActual.Name = "txtStockActual";
                        this.txtStockActual.Padding = new System.Windows.Forms.Padding(2);
                        this.txtStockActual.ReadOnly = false;
                        this.txtStockActual.Size = new System.Drawing.Size(108, 24);
                        this.txtStockActual.TabIndex = 13;
                        this.txtStockActual.TabStop = false;
                        this.txtStockActual.Text = "0";
                        this.txtStockActual.TipWhenBlank = "";
                        this.txtStockActual.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(12, 68);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(108, 24);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Stock Actual";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCosto
                        // 
                        this.txtCosto.AutoNav = true;
                        this.txtCosto.AutoTab = true;
                        this.txtCosto.DataType = Lui.Forms.DataTypes.Money;
                        this.txtCosto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCosto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCosto.Location = new System.Drawing.Point(120, 100);
                        this.txtCosto.MaxLenght = 32767;
                        this.txtCosto.Name = "txtCosto";
                        this.txtCosto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCosto.Prefijo = "$";
                        this.txtCosto.ReadOnly = false;
                        this.txtCosto.Size = new System.Drawing.Size(108, 24);
                        this.txtCosto.TabIndex = 15;
                        this.txtCosto.TabStop = false;
                        this.txtCosto.Text = "0.00";
                        this.txtCosto.TipWhenBlank = "";
                        this.txtCosto.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(12, 100);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(108, 24);
                        this.Label4.TabIndex = 3;
                        this.Label4.Text = "Costo Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtItemStock
                        // 
                        this.txtItemStock.AutoNav = true;
                        this.txtItemStock.AutoTab = true;
                        this.txtItemStock.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtItemStock.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtItemStock.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtItemStock.Location = new System.Drawing.Point(120, 132);
                        this.txtItemStock.MaxLenght = 32767;
                        this.txtItemStock.Name = "txtItemStock";
                        this.txtItemStock.Padding = new System.Windows.Forms.Padding(2);
                        this.txtItemStock.ReadOnly = false;
                        this.txtItemStock.Size = new System.Drawing.Size(108, 24);
                        this.txtItemStock.TabIndex = 5;
                        this.txtItemStock.TabStop = false;
                        this.txtItemStock.Text = "0";
                        this.txtItemStock.TipWhenBlank = "";
                        this.txtItemStock.ToolTipText = "";
                        // 
                        // Label6
                        // 
                        this.Label6.Location = new System.Drawing.Point(12, 132);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(108, 24);
                        this.Label6.TabIndex = 4;
                        this.Label6.Text = "Ítem con Stock";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdImagenQuitar
                        // 
                        this.cmdImagenQuitar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdImagenQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdImagenQuitar.Image = null;
                        this.cmdImagenQuitar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdImagenQuitar.Location = new System.Drawing.Point(184, 124);
                        this.cmdImagenQuitar.Name = "cmdImagenQuitar";
                        this.cmdImagenQuitar.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdImagenQuitar.ReadOnly = false;
                        this.cmdImagenQuitar.Size = new System.Drawing.Size(108, 32);
                        this.cmdImagenQuitar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdImagenQuitar.Subtext = "F5";
                        this.cmdImagenQuitar.TabIndex = 1;
                        this.cmdImagenQuitar.Text = "Quitar";
                        this.cmdImagenQuitar.ToolTipText = "";
                        this.cmdImagenQuitar.Click += new System.EventHandler(this.cmdImagenQuitar_Click);
                        // 
                        // cmdImagen
                        // 
                        this.cmdImagen.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdImagen.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdImagen.Image = null;
                        this.cmdImagen.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdImagen.Location = new System.Drawing.Point(184, 88);
                        this.cmdImagen.Name = "cmdImagen";
                        this.cmdImagen.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdImagen.ReadOnly = false;
                        this.cmdImagen.Size = new System.Drawing.Size(108, 32);
                        this.cmdImagen.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdImagen.Subtext = "F4";
                        this.cmdImagen.TabIndex = 0;
                        this.cmdImagen.Text = "Seleccionar";
                        this.cmdImagen.ToolTipText = "";
                        this.cmdImagen.Click += new System.EventHandler(this.cmdImagen_Click);
                        // 
                        // pctImagen
                        // 
                        this.pctImagen.Location = new System.Drawing.Point(12, 36);
                        this.pctImagen.Name = "pctImagen";
                        this.pctImagen.Size = new System.Drawing.Size(160, 120);
                        this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.pctImagen.TabIndex = 56;
                        this.pctImagen.TabStop = false;
                        // 
                        // Frame3
                        // 
                        this.Frame3.Controls.Add(this.cmdImagen);
                        this.Frame3.Controls.Add(this.cmdImagenQuitar);
                        this.Frame3.Controls.Add(this.pctImagen);
                        this.Frame3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Frame3.Location = new System.Drawing.Point(264, 188);
                        this.Frame3.Name = "Frame3";
                        this.Frame3.Padding = new System.Windows.Forms.Padding(2);
                        this.Frame3.ReadOnly = false;
                        this.Frame3.Size = new System.Drawing.Size(300, 168);
                        this.Frame3.TabIndex = 2;
                        this.Frame3.Text = "Imagen";
                        this.Frame3.ToolTipText = "";
                        // 
                        // Label8
                        // 
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(8, 364);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(176, 16);
                        this.Label8.TabIndex = 0;
                        this.Label8.Text = "* Requiere software externo.";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.Frame3);
                        this.Controls.Add(this.Frame1);
                        this.Controls.Add(this.Frame2);
                        this.Name = "Editar";
                        this.Text = "Artículos: Categoría: Editar";
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArticulosCategEditar_KeyDown);
                        this.Frame1.ResumeLayout(false);
                        this.Frame1.PerformLayout();
                        this.Frame2.ResumeLayout(false);
                        this.Frame2.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
                        this.Frame3.ResumeLayout(false);
                        this.Frame3.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                public override Lfx.Types.OperationResult Edit(int lId)
                {
			Lfx.Data.Row Registro = this.Workspace.DefaultDataBase.Row("cat_articulos", "id_cat_articulo", lId);

                        if (Registro == null)
                        {
                                return new Lfx.Types.FailureOperationResult("El registro no existe.");
                        }
                        else
                        {
                                txtNombre.Text = System.Convert.ToString(Registro["nombre"]);
                                txtNombreSing.Text = System.Convert.ToString(Registro["nombresing"]);
                                txtStockMinimo.Text = Lfx.Types.Formatting.FormatStock(System.Convert.ToDouble(Registro["stock_minimo"]));
                                txtWeb.TextKey = System.Convert.ToInt32(Registro["web"]).ToString();
                                txtItem.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT COUNT(id_articulo) FROM articulos WHERE id_cat_articulo=" + lId.ToString()));
                                txtItemStock.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT COUNT(id_articulo) FROM articulos WHERE stock_actual>0 AND id_cat_articulo=" + lId.ToString()));
                                txtStockActual.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(stock_actual) FROM articulos WHERE id_cat_articulo=" + lId.ToString()));
                                txtCosto.Text = Lfx.Types.Formatting.FormatStock(this.Workspace.DefaultDataBase.FieldDouble("SELECT SUM(costo) FROM articulos WHERE id_cat_articulo=" + lId.ToString()));

                                if (Registro["imagen"] != null && ((byte[])(Registro["imagen"])).Length > 5)
                                {
                                        byte[] ByteArr = ((byte[])(Registro["imagen"]));
                                        System.IO.MemoryStream loStream = new System.IO.MemoryStream(ByteArr);
                                        pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                        pctImagen.Image = Image.FromStream(loStream);
                                        pctImagen.Tag = "*";
                                }

                                m_Id = lId;
                                m_Nuevo = false;

                                return new Lfx.Types.SuccessOperationResult();
                        }
                }

                public override Lfx.Types.OperationResult Save()
                {
                        Lfx.Types.OperationResult ResultadoGuardar = ValidateData();

                        if (ResultadoGuardar.Success == true)
                        {
                                this.DataView.DataBase.BeginTransaction();

				Lbl.Articulos.Categoria Cat = new Lbl.Articulos.Categoria(DataView, m_Id);
				Cat.Nombre = txtNombre.Text;
	                        Cat.NombreSingular = txtNombreSing.Text;
	                        Cat.StockMinimo = Lfx.Types.Parsing.ParseStock(txtStockMinimo.Text);
	                        Cat.PublicacionWeb = Lfx.Types.Parsing.ParseInt(txtWeb.TextKey);
				Cat.Guardar();
				m_Id = Cat.Id;
				
                                switch (System.Convert.ToString(pctImagen.Tag))
                                {
                                        case "*":
                                                // Queda la que está
                                                break;

                                        case "":
                                                // Quitar imagen actual
                                                DataView.DataBase.Execute("UPDATE cat_articulos SET imagen=NULL WHERE id_cat_articulo=" + m_Id.ToString());
                                                break;

                                        default:
                                                // Guardar imagen nueva
                                                Lfx.Data.SqlInsertBuilder InsertarImagen = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "cat_articulos");
                                                InsertarImagen.Fields.AddWithValue("id_cat_articulo", m_Id);
                                                InsertarImagen.Fields.AddWithValue("imagen", pctImagen.Image);
                                                DataView.Execute(InsertarImagen);
                                                break;
                                }

                                this.DataView.DataBase.Commit();

                                if (m_Nuevo && ControlDestino != null) {
                                        ControlDestino.Text = m_Id.ToString();
                                        ControlDestino.Focus();
                                }

                                m_Nuevo = false;

                                ResultadoGuardar = base.Save();
                        }

                        return ResultadoGuardar;
                }

                private void FormArticulosCategEditar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode)
                        {
                                case Keys.F4:
                                        e.Handled = true;
                                        if (cmdImagen.Enabled && cmdImagen.Visible)
                                                cmdImagen.PerformClick();
                                        break;

                                case Keys.F5:
                                        e.Handled = true;
                                        if (cmdImagenQuitar.Enabled && cmdImagenQuitar.Visible)
                                                cmdImagenQuitar.PerformClick();
                                        break;
                        }
                }

                private void cmdImagenQuitar_Click(object sender, System.EventArgs e)
                {
                        pctImagen.Image = null;
                        pctImagen.Tag = string.Empty;
                }

                private void cmdImagen_Click(object sender, System.EventArgs e)
                {
                        OpenFileDialog Abrir = new OpenFileDialog();
                        Abrir.Filter = "Archivos JPEG|*.jpg";
                        Abrir.Multiselect = false;
                        Abrir.ValidateNames = true;

                        if (Abrir.ShowDialog() == DialogResult.OK)
                        {
                                pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                pctImagen.Image = Image.FromFile(Abrir.FileName);
                                pctImagen.Tag = Abrir.FileName;
                        }
                }
        }
}
