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
                        this.Label7 = new System.Windows.Forms.Label();
                        this.lblCuenta = new System.Windows.Forms.Label();
                        this.EntradaPersona = new Lui.Forms.DetailBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaBanco = new Lui.Forms.DetailBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaFechas = new Lcc.Controles.RangoFechas();
                        this.label3 = new System.Windows.Forms.Label();
                        this.EntradaSucursal = new Lui.Forms.DetailBox();
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
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.Location = new System.Drawing.Point(108, 20);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.ReadOnly = false;
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
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "Estado para esta chequera.";
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
                        // lblCuenta
                        // 
                        this.lblCuenta.Location = new System.Drawing.Point(20, 116);
                        this.lblCuenta.Name = "lblCuenta";
                        this.lblCuenta.Size = new System.Drawing.Size(88, 24);
                        this.lblCuenta.TabIndex = 6;
                        this.lblCuenta.Text = "Persona";
                        this.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPersona
                        // 
                        this.EntradaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPersona.AutoTab = true;
                        this.EntradaPersona.CanCreate = true;
                        this.EntradaPersona.DetailField = "nombre_visible";
                        this.EntradaPersona.ExtraDetailFields = null;
                        this.EntradaPersona.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPersona.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPersona.FreeTextCode = "";
                        this.EntradaPersona.KeyField = "id_persona";
                        this.EntradaPersona.Location = new System.Drawing.Point(108, 116);
                        this.EntradaPersona.MaxLength = 200;
                        this.EntradaPersona.Name = "EntradaPersona";
                        this.EntradaPersona.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPersona.ReadOnly = false;
                        this.EntradaPersona.Required = false;
                        this.EntradaPersona.SelectOnFocus = false;
                        this.EntradaPersona.Size = new System.Drawing.Size(366, 24);
                        this.EntradaPersona.TabIndex = 7;
                        this.EntradaPersona.Table = "personas";
                        this.EntradaPersona.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaPersona.Text = "0";
                        this.EntradaPersona.TextDetail = "";
                        this.EntradaPersona.TextInt = 0;
                        this.EntradaPersona.TipWhenBlank = "";
                        this.EntradaPersona.ToolTipText = "";
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
                        this.EntradaBanco.DetailField = "nombre";
                        this.EntradaBanco.ExtraDetailFields = null;
                        this.EntradaBanco.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBanco.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBanco.FreeTextCode = "";
                        this.EntradaBanco.KeyField = "id_banco";
                        this.EntradaBanco.Location = new System.Drawing.Point(108, 84);
                        this.EntradaBanco.MaxLength = 200;
                        this.EntradaBanco.Name = "EntradaBanco";
                        this.EntradaBanco.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBanco.ReadOnly = false;
                        this.EntradaBanco.Required = false;
                        this.EntradaBanco.SelectOnFocus = false;
                        this.EntradaBanco.Size = new System.Drawing.Size(366, 24);
                        this.EntradaBanco.TabIndex = 5;
                        this.EntradaBanco.Table = "bancos";
                        this.EntradaBanco.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaBanco.Text = "0";
                        this.EntradaBanco.TextDetail = "";
                        this.EntradaBanco.TextInt = 0;
                        this.EntradaBanco.TipWhenBlank = "";
                        this.EntradaBanco.ToolTipText = "";
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
                        this.EntradaFechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaFechas.Location = new System.Drawing.Point(108, 148);
                        this.EntradaFechas.MuestraFuturos = false;
                        this.EntradaFechas.Name = "EntradaFechas";
                        this.EntradaFechas.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechas.ReadOnly = false;
                        this.EntradaFechas.Size = new System.Drawing.Size(366, 68);
                        this.EntradaFechas.TabIndex = 9;
                        this.EntradaFechas.ToolTipText = "";
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
                        this.EntradaSucursal.DetailField = "nombre";
                        this.EntradaSucursal.ExtraDetailFields = null;
                        this.EntradaSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSucursal.FreeTextCode = "";
                        this.EntradaSucursal.KeyField = "id_sucursal";
                        this.EntradaSucursal.Location = new System.Drawing.Point(108, 52);
                        this.EntradaSucursal.MaxLength = 200;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.ReadOnly = false;
                        this.EntradaSucursal.Required = false;
                        this.EntradaSucursal.SelectOnFocus = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(366, 24);
                        this.EntradaSucursal.TabIndex = 3;
                        this.EntradaSucursal.Table = "sucursales";
                        this.EntradaSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaSucursal.Text = "0";
                        this.EntradaSucursal.TextDetail = "";
                        this.EntradaSucursal.TextInt = 0;
                        this.EntradaSucursal.TipWhenBlank = "";
                        this.EntradaSucursal.ToolTipText = "";
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
                        this.Controls.Add(this.lblCuenta);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.Label7);
                        this.Name = "Filtros";
                        this.Text = "Filtros";
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.lblCuenta, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaEstado, 0);
                        this.Controls.SetChildIndex(this.EntradaBanco, 0);
                        this.Controls.SetChildIndex(this.EntradaPersona, 0);
                        this.Controls.SetChildIndex(this.EntradaFechas, 0);
                        this.Controls.SetChildIndex(this.EntradaSucursal, 0);
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.ComboBox EntradaEstado;
                private System.Windows.Forms.Label Label7;
                private System.Windows.Forms.Label lblCuenta;
                internal Lui.Forms.DetailBox EntradaPersona;
                private System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox EntradaBanco;
                private System.ComponentModel.IContainer components = null;
                private System.Windows.Forms.Label label2;
                internal Lcc.Controles.RangoFechas EntradaFechas;
                private System.Windows.Forms.Label label3;
                internal Lui.Forms.DetailBox EntradaSucursal;
        }
}