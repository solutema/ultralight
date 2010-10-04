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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Bancos.Chequeras
{
        public partial class Editar : Lui.Forms.EditForm
        {
                #region Código generado por el diseñador
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaDesde = new Lui.Forms.TextBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaHasta = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.LabelCaja = new System.Windows.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaTitular = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaPrefijo = new Lui.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.label8 = new System.Windows.Forms.Label();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 52);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(120, 24);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DetailField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.KeyField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(140, 52);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.ReadOnly = false;
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.Size = new System.Drawing.Size(532, 24);
                        this.EntradaBanco.TabIndex = 3;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
                        // 
                        // EntradaDesde
                        // 
                        this.EntradaDesde.AutoNav = true;
                        this.EntradaDesde.AutoTab = true;
                        this.EntradaDesde.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDesde.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDesde.Location = new System.Drawing.Point(316, 84);
                        this.EntradaDesde.MaxLenght = 32767;
                        this.EntradaDesde.Name = "EntradaDesde";
                        this.EntradaDesde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesde.ReadOnly = false;
                        this.EntradaDesde.Size = new System.Drawing.Size(112, 24);
                        this.EntradaDesde.TabIndex = 8;
                        this.EntradaDesde.TipWhenBlank = "";
                        this.EntradaDesde.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(20, 84);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(120, 24);
                        this.Label3.TabIndex = 4;
                        this.Label3.Text = "Numeración";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaHasta
                        // 
                        this.EntradaHasta.AutoNav = true;
                        this.EntradaHasta.AutoTab = true;
                        this.EntradaHasta.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaHasta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaHasta.Location = new System.Drawing.Point(488, 84);
                        this.EntradaHasta.MaxLenght = 32767;
                        this.EntradaHasta.Name = "EntradaHasta";
                        this.EntradaHasta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHasta.ReadOnly = false;
                        this.EntradaHasta.Size = new System.Drawing.Size(112, 24);
                        this.EntradaHasta.TabIndex = 10;
                        this.EntradaHasta.TipWhenBlank = "";
                        this.EntradaHasta.ToolTipText = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(436, 84);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(48, 24);
                        this.label2.TabIndex = 9;
                        this.label2.Text = "hasta";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelCaja
                        // 
                        this.LabelCaja.Location = new System.Drawing.Point(20, 148);
                        this.LabelCaja.Name = "LabelCaja";
                        this.LabelCaja.Size = new System.Drawing.Size(120, 24);
                        this.LabelCaja.TabIndex = 13;
                        this.LabelCaja.Text = "Se debita de";
                        this.LabelCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCaja
                        // 
                        this.EntradaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DetailField = "nombre";
                        this.EntradaCaja.ExtraDetailFields = null;
                        this.EntradaCaja.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCaja.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.KeyField = "id_caja";
                        this.EntradaCaja.Location = new System.Drawing.Point(140, 148);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.ReadOnly = false;
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(532, 24);
                        this.EntradaCaja.TabIndex = 14;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.TipWhenBlank = "Ninguna";
                        this.EntradaCaja.ToolTipText = "";
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.Location = new System.Drawing.Point(140, 180);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Fuera de uso|0",
        "Activa|1"};
                        this.EntradaEstado.Size = new System.Drawing.Size(172, 24);
                        this.EntradaEstado.TabIndex = 16;
                        this.EntradaEstado.Text = "Activa";
                        this.EntradaEstado.TextKey = "1";
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "Estado para esta chequera.";
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(20, 180);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(120, 24);
                        this.Label7.TabIndex = 15;
                        this.Label7.Text = "Estado";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(20, 20);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(120, 24);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Titular";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTitular
                        // 
                        this.EntradaTitular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTitular.AutoNav = true;
                        this.EntradaTitular.AutoTab = true;
                        this.EntradaTitular.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaTitular.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTitular.Location = new System.Drawing.Point(140, 20);
                        this.EntradaTitular.MaxLenght = 32767;
                        this.EntradaTitular.Name = "EntradaTitular";
                        this.EntradaTitular.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTitular.ReadOnly = false;
                        this.EntradaTitular.Size = new System.Drawing.Size(532, 24);
                        this.EntradaTitular.TabIndex = 1;
                        this.EntradaTitular.TipWhenBlank = "";
                        this.EntradaTitular.ToolTipText = "Estado para esta chequera.";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(264, 84);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(48, 24);
                        this.label4.TabIndex = 7;
                        this.label4.Text = "desde";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPrefijo
                        // 
                        this.EntradaPrefijo.AutoNav = true;
                        this.EntradaPrefijo.AutoTab = true;
                        this.EntradaPrefijo.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaPrefijo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPrefijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPrefijo.Location = new System.Drawing.Point(196, 84);
                        this.EntradaPrefijo.MaxLenght = 32767;
                        this.EntradaPrefijo.Name = "EntradaPrefijo";
                        this.EntradaPrefijo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPrefijo.ReadOnly = false;
                        this.EntradaPrefijo.Size = new System.Drawing.Size(64, 24);
                        this.EntradaPrefijo.TabIndex = 6;
                        this.EntradaPrefijo.TipWhenBlank = "";
                        this.EntradaPrefijo.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(140, 84);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(48, 24);
                        this.label6.TabIndex = 5;
                        this.label6.Text = "prefijo";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(20, 116);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(120, 24);
                        this.label8.TabIndex = 11;
                        this.label8.Text = "Sucursal";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.CanCreate = true;
                        this.EntradaSucursal.DetailField = "nombre";
                        this.EntradaSucursal.ExtraDetailFields = null;
                        this.EntradaSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.KeyField = "id_sucursal";
                        this.EntradaSucursal.Location = new System.Drawing.Point(140, 116);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.ReadOnly = false;
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(532, 24);
                        this.EntradaSucursal.TabIndex = 12;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        this.EntradaSucursal.TipWhenBlank = "Todas";
                        this.EntradaSucursal.ToolTipText = "";
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.EntradaSucursal);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.EntradaPrefijo);
                        this.Controls.Add(this.EntradaTitular);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.EntradaCaja);
                        this.Controls.Add(this.EntradaHasta);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaDesde);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.LabelCaja);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Name = "Editar";
                        this.Text = "Chequera";
                        this.ResumeLayout(false);

                }
                #endregion

                internal System.Windows.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaBanco;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label label2;
                internal System.Windows.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaDesde;
                internal Lui.Forms.TextBox EntradaHasta;
                internal Lcc.Entrada.CodigoDetalle EntradaCaja;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal System.Windows.Forms.Label label5;
                internal System.Windows.Forms.Label LabelCaja;
                internal Lui.Forms.TextBox EntradaTitular;
                internal Label label4;
                internal Lui.Forms.TextBox EntradaPrefijo;
                internal Label label6;
                internal Label label8;
                internal Lcc.Entrada.CodigoDetalle EntradaSucursal;
                private System.ComponentModel.IContainer components = null;
        }
}
