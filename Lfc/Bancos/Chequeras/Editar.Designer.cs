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

namespace Lfc.Bancos.Chequeras
{
        public partial class Editar
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
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaDesde = new Lui.Forms.TextBox();
                        this.Label3 = new Lui.Forms.Label();
                        this.EntradaHasta = new Lui.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.LabelCaja = new Lui.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.label5 = new Lui.Forms.Label();
                        this.EntradaTitular = new Lui.Forms.TextBox();
                        this.label4 = new Lui.Forms.Label();
                        this.label8 = new Lui.Forms.Label();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.label6 = new Lui.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 32);
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
                        this.EntradaBanco.AutoNav = true;
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DataTextField = "nombre";
                        this.EntradaBanco.DataValueField = "id_banco";
                        this.EntradaBanco.Filter = "";
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.Location = new System.Drawing.Point(120, 32);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.Required = true;
                        this.EntradaBanco.Size = new System.Drawing.Size(539, 24);
                        this.EntradaBanco.TabIndex = 3;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        // 
                        // EntradaDesde
                        // 
                        this.EntradaDesde.AutoNav = true;
                        this.EntradaDesde.AutoTab = true;
                        this.EntradaDesde.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaDesde.DecimalPlaces = -1;
                        this.EntradaDesde.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDesde.Location = new System.Drawing.Point(172, 64);
                        this.EntradaDesde.MultiLine = false;
                        this.EntradaDesde.Name = "EntradaDesde";
                        this.EntradaDesde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesde.SelectOnFocus = true;
                        this.EntradaDesde.Size = new System.Drawing.Size(112, 24);
                        this.EntradaDesde.TabIndex = 8;
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(0, 64);
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
                        this.EntradaHasta.DecimalPlaces = -1;
                        this.EntradaHasta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaHasta.Location = new System.Drawing.Point(344, 64);
                        this.EntradaHasta.MultiLine = false;
                        this.EntradaHasta.Name = "EntradaHasta";
                        this.EntradaHasta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHasta.SelectOnFocus = true;
                        this.EntradaHasta.Size = new System.Drawing.Size(112, 24);
                        this.EntradaHasta.TabIndex = 10;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(292, 64);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(52, 24);
                        this.label2.TabIndex = 9;
                        this.label2.Text = "hasta";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelCaja
                        // 
                        this.LabelCaja.Location = new System.Drawing.Point(0, 128);
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
                        this.EntradaCaja.AutoNav = true;
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = true;
                        this.EntradaCaja.DataTextField = "nombre";
                        this.EntradaCaja.DataValueField = "id_caja";
                        this.EntradaCaja.Filter = "";
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.Location = new System.Drawing.Point(120, 128);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(539, 24);
                        this.EntradaCaja.TabIndex = 14;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.PlaceholderText = "Ninguna";
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = false;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Location = new System.Drawing.Point(120, 160);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.SetData = new string[] {
        "Fuera de uso|0",
        "Activa|1"};
                        this.EntradaEstado.Size = new System.Drawing.Size(172, 24);
                        this.EntradaEstado.TabIndex = 16;
                        this.EntradaEstado.TextKey = "1";
                        this.EntradaEstado.PlaceholderText = "Estado para esta chequera.";
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(0, 160);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(120, 24);
                        this.Label7.TabIndex = 15;
                        this.Label7.Text = "Estado";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 0);
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
                        this.EntradaTitular.DecimalPlaces = -1;
                        this.EntradaTitular.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaTitular.Location = new System.Drawing.Point(120, 0);
                        this.EntradaTitular.MultiLine = false;
                        this.EntradaTitular.Name = "EntradaTitular";
                        this.EntradaTitular.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTitular.SelectOnFocus = true;
                        this.EntradaTitular.Size = new System.Drawing.Size(539, 24);
                        this.EntradaTitular.TabIndex = 1;
                        this.EntradaTitular.PlaceholderText = "Estado para esta chequera.";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(120, 64);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(52, 24);
                        this.label4.TabIndex = 7;
                        this.label4.Text = "desde";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(0, 96);
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
                        this.EntradaSucursal.AutoNav = true;
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.CanCreate = true;
                        this.EntradaSucursal.DataTextField = "nombre";
                        this.EntradaSucursal.DataValueField = "id_sucursal";
                        this.EntradaSucursal.Filter = "";
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.Location = new System.Drawing.Point(120, 96);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(539, 24);
                        this.EntradaSucursal.TabIndex = 12;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        this.EntradaSucursal.PlaceholderText = "Todas";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(460, 64);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(96, 24);
                        this.label6.TabIndex = 5;
                        this.label6.Text = "(inclusive)";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.EntradaSucursal);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.EntradaTitular);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.EntradaCaja);
                        this.Controls.Add(this.EntradaHasta);
                        this.Controls.Add(this.EntradaDesde);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.LabelCaja);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.label2);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(659, 189);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.LabelCaja, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaBanco, 0);
                        this.Controls.SetChildIndex(this.EntradaDesde, 0);
                        this.Controls.SetChildIndex(this.EntradaHasta, 0);
                        this.Controls.SetChildIndex(this.EntradaCaja, 0);
                        this.Controls.SetChildIndex(this.EntradaEstado, 0);
                        this.Controls.SetChildIndex(this.EntradaTitular, 0);
                        this.Controls.SetChildIndex(this.label6, 0);
                        this.Controls.SetChildIndex(this.EntradaSucursal, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                internal Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaBanco;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.TextBox EntradaDesde;
                internal Lui.Forms.TextBox EntradaHasta;
                internal Lcc.Entrada.CodigoDetalle EntradaCaja;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal Lui.Forms.Label label5;
                internal Lui.Forms.Label LabelCaja;
                internal Lui.Forms.TextBox EntradaTitular;
                internal Label label4;
                internal Label label8;
                internal Lcc.Entrada.CodigoDetalle EntradaSucursal;
                private System.ComponentModel.IContainer components = null;
                internal Label label6;
        }
}
