#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace Lfc.Bancos.Cheques
{
        public partial class Filtros
        {

                #region Código generado por el diseñador
                /// <summary>
                /// Limpiar los recursos que se están utilizando.
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

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.LabelCaja = new Lui.Forms.Label();
                        this.EntradaPersona = new Lcc.Entrada.CodigoDetalle();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaBanco = new Lcc.Entrada.CodigoDetalle();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaFechas = new Lcc.Entrada.RangoFechas();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaSucursal = new Lcc.Entrada.CodigoDetalle();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(278, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(386, 8);
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Location = new System.Drawing.Point(108, 20);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.TemporaryReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Todos|-1",
        "A pagar|0",
        "Depositado|5",
        "Pagado|10",
        "Anulado|90"};
                        this.EntradaEstado.Size = new System.Drawing.Size(204, 24);
                        this.EntradaEstado.TabIndex = 1;
                        this.EntradaEstado.Text = "Todos";
                        this.EntradaEstado.TextKey = "-1";
                        this.EntradaEstado.PlaceholderText = "Estado para esta chequera.";
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(20, 20);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(88, 24);
                        this.Label7.TabIndex = 0;
                        this.Label7.Text = "Estado";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelCaja
                        // 
                        this.LabelCaja.Location = new System.Drawing.Point(20, 116);
                        this.LabelCaja.Name = "LabelCaja";
                        this.LabelCaja.Size = new System.Drawing.Size(88, 24);
                        this.LabelCaja.TabIndex = 6;
                        this.LabelCaja.Text = "Persona";
                        this.LabelCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPersona
                        // 
                        this.EntradaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPersona.AutoTab = true;
                        this.EntradaPersona.CanCreate = true;
                        this.EntradaPersona.DataTextField = "nombre_visible";
                        this.EntradaPersona.FreeTextCode = "";
                        this.EntradaPersona.DataValueField = "id_persona";
                        this.EntradaPersona.Location = new System.Drawing.Point(108, 116);
                        this.EntradaPersona.MaxLength = 200;
                        this.EntradaPersona.Name = "EntradaPersona";
                        this.EntradaPersona.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPersona.TemporaryReadOnly = false;
                        this.EntradaPersona.Required = false;
                        this.EntradaPersona.Size = new System.Drawing.Size(366, 24);
                        this.EntradaPersona.TabIndex = 7;
                        this.EntradaPersona.Table = "personas";
                        this.EntradaPersona.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaPersona.Text = "0";
                        this.EntradaPersona.TextDetail = "";
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 84);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 4;
                        this.Label1.Text = "Banco";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaBanco
                        // 
                        this.EntradaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBanco.AutoTab = true;
                        this.EntradaBanco.CanCreate = true;
                        this.EntradaBanco.DataTextField = "nombre";
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.DataValueField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(108, 84);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.TemporaryReadOnly = false;
                        this.EntradaBanco.Required = false;
                        this.EntradaBanco.Size = new System.Drawing.Size(366, 24);
                        this.EntradaBanco.TabIndex = 5;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(20, 148);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(88, 24);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "Fecha";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechas
                        // 
                        this.EntradaFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFechas.Location = new System.Drawing.Point(108, 148);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.TemporaryReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(366, 68);
                        this.EntradaFechas.TabIndex = 9;
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(20, 52);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(88, 24);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "Sucursal";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.CanCreate = true;
                        this.EntradaSucursal.DataTextField = "nombre";
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.DataValueField = "id_sucursal";
                        this.EntradaSucursal.Location = new System.Drawing.Point(108, 52);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.TemporaryReadOnly = false;
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(366, 24);
                        this.EntradaSucursal.TabIndex = 3;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(494, 375);
                        this.Controls.Add(this.EntradaSucursal);
                        this.Controls.Add(this.EntradaFechas);
                        this.Controls.Add(this.EntradaPersona);
                        this.Controls.Add(this.EntradaBanco);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.LabelCaja);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label7);
                        this.Name = "Filtros";
                        this.Text = "Filtros";
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.ComboBox EntradaEstado;
                private Lui.Forms.Label Label7;
                private Lui.Forms.Label LabelCaja;
                internal Lcc.Entrada.CodigoDetalle EntradaPersona;
                private Lui.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaBanco;
                private System.ComponentModel.IContainer components = null;
                private Lui.Forms.Label label2;
                internal Lcc.Entrada.RangoFechas EntradaFechas;
                private Lui.Forms.Label label3;
                internal Lcc.Entrada.CodigoDetalle EntradaSucursal;
        }
}
