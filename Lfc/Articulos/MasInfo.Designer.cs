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
using System.Collections.Generic;
using System.Text;

namespace Lfc.Articulos
{
        public partial class MasInfo  {
                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        base.Dispose(disposing);
                }

                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaFechaCreado = new Lui.Forms.TextBox();
                        this.EntradaFechaPrecio = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaCostoUltimaCompra = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaCostoUltimas5Compras = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.lvItems = new Lui.Forms.ListView();
                        this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.costo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.pvp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.Label5 = new System.Windows.Forms.Label();
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
                        this.Label1.Location = new System.Drawing.Point(12, 12);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(132, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Fecha de Creación";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFechaCreado
                        // 
                        this.EntradaFechaCreado.AutoHeight = false;
                        this.EntradaFechaCreado.AutoNav = true;
                        this.EntradaFechaCreado.AutoTab = true;
                        this.EntradaFechaCreado.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaFechaCreado.DecimalPlaces = -1;
                        this.EntradaFechaCreado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaCreado.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaCreado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaCreado.Location = new System.Drawing.Point(144, 12);
                        this.EntradaFechaCreado.MaxLenght = 32767;
                        this.EntradaFechaCreado.MultiLine = false;
                        this.EntradaFechaCreado.Name = "txtFechaCreado";
                        this.EntradaFechaCreado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaCreado.PasswordChar = '\0';
                        this.EntradaFechaCreado.Prefijo = "";
                        this.EntradaFechaCreado.ReadOnly = true;
                        this.EntradaFechaCreado.SelectOnFocus = true;
                        this.EntradaFechaCreado.Size = new System.Drawing.Size(140, 24);
                        this.EntradaFechaCreado.Sufijo = "";
                        this.EntradaFechaCreado.TabIndex = 51;
                        this.EntradaFechaCreado.TextRaw = "";
                        this.EntradaFechaCreado.TipWhenBlank = "";
                        this.EntradaFechaCreado.ToolTipText = "";
                        // 
                        // txtFechaPrecio
                        // 
                        this.EntradaFechaPrecio.AutoHeight = false;
                        this.EntradaFechaPrecio.AutoNav = true;
                        this.EntradaFechaPrecio.AutoTab = true;
                        this.EntradaFechaPrecio.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaFechaPrecio.DecimalPlaces = -1;
                        this.EntradaFechaPrecio.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaPrecio.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaPrecio.Location = new System.Drawing.Point(144, 40);
                        this.EntradaFechaPrecio.MaxLenght = 32767;
                        this.EntradaFechaPrecio.MultiLine = false;
                        this.EntradaFechaPrecio.Name = "txtFechaPrecio";
                        this.EntradaFechaPrecio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaPrecio.PasswordChar = '\0';
                        this.EntradaFechaPrecio.Prefijo = "";
                        this.EntradaFechaPrecio.ReadOnly = true;
                        this.EntradaFechaPrecio.SelectOnFocus = true;
                        this.EntradaFechaPrecio.Size = new System.Drawing.Size(140, 24);
                        this.EntradaFechaPrecio.Sufijo = "";
                        this.EntradaFechaPrecio.TabIndex = 53;
                        this.EntradaFechaPrecio.TextRaw = "";
                        this.EntradaFechaPrecio.TipWhenBlank = "";
                        this.EntradaFechaPrecio.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(12, 40);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(132, 24);
                        this.Label2.TabIndex = 52;
                        this.Label2.Text = "Fecha del Precio";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCostoUlt
                        // 
                        this.EntradaCostoUltimaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaCostoUltimaCompra.AutoHeight = false;
                        this.EntradaCostoUltimaCompra.AutoNav = true;
                        this.EntradaCostoUltimaCompra.AutoTab = true;
                        this.EntradaCostoUltimaCompra.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCostoUltimaCompra.DecimalPlaces = -1;
                        this.EntradaCostoUltimaCompra.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCostoUltimaCompra.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCostoUltimaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCostoUltimaCompra.Location = new System.Drawing.Point(368, 251);
                        this.EntradaCostoUltimaCompra.MaxLenght = 32767;
                        this.EntradaCostoUltimaCompra.MultiLine = false;
                        this.EntradaCostoUltimaCompra.Name = "txtCostoUlt";
                        this.EntradaCostoUltimaCompra.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCostoUltimaCompra.PasswordChar = '\0';
                        this.EntradaCostoUltimaCompra.Prefijo = "";
                        this.EntradaCostoUltimaCompra.ReadOnly = false;
                        this.EntradaCostoUltimaCompra.SelectOnFocus = true;
                        this.EntradaCostoUltimaCompra.Size = new System.Drawing.Size(92, 24);
                        this.EntradaCostoUltimaCompra.Sufijo = "";
                        this.EntradaCostoUltimaCompra.TabIndex = 55;
                        this.EntradaCostoUltimaCompra.Text = "0.00";
                        this.EntradaCostoUltimaCompra.TextRaw = "0.00";
                        this.EntradaCostoUltimaCompra.TipWhenBlank = "";
                        this.EntradaCostoUltimaCompra.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label3.Location = new System.Drawing.Point(12, 251);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(356, 24);
                        this.Label3.TabIndex = 54;
                        this.Label3.Text = "Costo de la última Compra";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtCostoProm
                        // 
                        this.EntradaCostoUltimas5Compras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EntradaCostoUltimas5Compras.AutoHeight = false;
                        this.EntradaCostoUltimas5Compras.AutoNav = true;
                        this.EntradaCostoUltimas5Compras.AutoTab = true;
                        this.EntradaCostoUltimas5Compras.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCostoUltimas5Compras.DecimalPlaces = -1;
                        this.EntradaCostoUltimas5Compras.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCostoUltimas5Compras.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCostoUltimas5Compras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaCostoUltimas5Compras.Location = new System.Drawing.Point(368, 279);
                        this.EntradaCostoUltimas5Compras.MaxLenght = 32767;
                        this.EntradaCostoUltimas5Compras.MultiLine = false;
                        this.EntradaCostoUltimas5Compras.Name = "txtCostoProm";
                        this.EntradaCostoUltimas5Compras.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCostoUltimas5Compras.PasswordChar = '\0';
                        this.EntradaCostoUltimas5Compras.Prefijo = "";
                        this.EntradaCostoUltimas5Compras.ReadOnly = false;
                        this.EntradaCostoUltimas5Compras.SelectOnFocus = true;
                        this.EntradaCostoUltimas5Compras.Size = new System.Drawing.Size(92, 24);
                        this.EntradaCostoUltimas5Compras.Sufijo = "";
                        this.EntradaCostoUltimas5Compras.TabIndex = 57;
                        this.EntradaCostoUltimas5Compras.Text = "0.00";
                        this.EntradaCostoUltimas5Compras.TextRaw = "0.00";
                        this.EntradaCostoUltimas5Compras.TipWhenBlank = "";
                        this.EntradaCostoUltimas5Compras.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label4.Location = new System.Drawing.Point(12, 279);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(356, 24);
                        this.Label4.TabIndex = 56;
                        this.Label4.Text = "Costo Promedio de las Últimas 5 Compras";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lvItems
                        // 
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fecha,
            this.costo,
            this.pvp,
            this.usuario});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvItems.LabelWrap = false;
                        this.lvItems.Location = new System.Drawing.Point(12, 96);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(612, 147);
                        this.lvItems.TabIndex = 59;
                        this.lvItems.TabStop = false;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        // 
                        // fecha
                        // 
                        this.fecha.Text = "Fecha";
                        this.fecha.Width = 89;
                        // 
                        // costo
                        // 
                        this.costo.Text = "Costo";
                        this.costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.costo.Width = 96;
                        // 
                        // pvp
                        // 
                        this.pvp.Text = "PVP";
                        this.pvp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.pvp.Width = 96;
                        // 
                        // usuario
                        // 
                        this.usuario.Text = "Usuario";
                        this.usuario.Width = 142;
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(12, 72);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(612, 24);
                        this.Label5.TabIndex = 60;
                        this.Label5.Text = "Historial de Precios:";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // MasInfo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 374);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.lvItems);
                        this.Controls.Add(this.EntradaCostoUltimas5Compras);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaCostoUltimaCompra);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EntradaFechaPrecio);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaFechaCreado);
                        this.Controls.Add(this.Label1);
                        this.Name = "MasInfo";
                        this.Text = "Artículo: Info";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaCreado, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaFechaPrecio, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.EntradaCostoUltimaCompra, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EntradaCostoUltimas5Compras, 0);
                        this.Controls.SetChildIndex(this.lvItems, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.ResumeLayout(false);

                }

                #endregion


                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaFechaCreado;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox EntradaFechaPrecio;
                internal Lui.Forms.TextBox EntradaCostoUltimaCompra;
                internal Lui.Forms.TextBox EntradaCostoUltimas5Compras;
                internal Lui.Forms.ListView lvItems;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.ColumnHeader fecha;
                internal System.Windows.Forms.ColumnHeader costo;
                internal System.Windows.Forms.ColumnHeader pvp;
                internal System.Windows.Forms.ColumnHeader usuario;
        }
}
