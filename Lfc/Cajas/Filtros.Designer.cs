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

namespace Lfc.Cajas
{
        public partial class Filtros
        {
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

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaPersona = new Lcc.Entrada.CodigoDetalle();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EntradaDireccion = new Lui.Forms.ComboBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.EntradaTipoConcepto = new Lui.Forms.ComboBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.Fechas = new Lcc.Entrada.RangoFechas();
                        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                        this.tableLayoutPanel1.SuspendLayout();
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
                        this.Label1.Location = new System.Drawing.Point(3, 150);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(84, 24);
                        this.Label1.TabIndex = 10;
                        this.Label1.Text = "Fecha";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPersona
                        // 
                        this.EntradaPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaPersona.AutoSize = true;
                        this.EntradaPersona.AutoTab = true;
                        this.EntradaPersona.CanCreate = false;
                        this.EntradaPersona.DataTextField = "nombre_visible";
                        this.EntradaPersona.ExtraDetailFields = null;
                        this.EntradaPersona.Filter = "";
                        this.EntradaPersona.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPersona.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaPersona.FreeTextCode = "";
                        this.EntradaPersona.DataValueField = "id_persona";
                        this.EntradaPersona.Location = new System.Drawing.Point(93, 33);
                        this.EntradaPersona.MaxLength = 200;
                        this.EntradaPersona.Name = "EntradaPersona";
                        this.EntradaPersona.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPersona.TemporaryReadOnly = false;
                        this.EntradaPersona.Required = false;
                        this.EntradaPersona.Size = new System.Drawing.Size(495, 24);
                        this.EntradaPersona.TabIndex = 3;
                        this.EntradaPersona.Table = "personas";
                        this.EntradaPersona.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaPersona.Text = "0";
                        this.EntradaPersona.TextDetail = "";
                        this.EntradaPersona.PlaceholderText = "";
                        this.EntradaPersona.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(3, 30);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(84, 24);
                        this.Label5.TabIndex = 2;
                        this.Label5.Text = "Persona";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoSize = true;
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = false;
                        this.EntradaConcepto.DataTextField = "nombre";
                        this.EntradaConcepto.ExtraDetailFields = null;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConcepto.FreeTextCode = "*";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(93, 63);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.TemporaryReadOnly = false;
                        this.EntradaConcepto.Required = false;
                        this.EntradaConcepto.Size = new System.Drawing.Size(495, 24);
                        this.EntradaConcepto.TabIndex = 5;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        this.EntradaConcepto.PlaceholderText = "";
                        this.EntradaConcepto.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(3, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(84, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Concepto";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCaja
                        // 
                        this.EntradaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCaja.AutoSize = true;
                        this.EntradaCaja.AutoTab = true;
                        this.EntradaCaja.CanCreate = false;
                        this.EntradaCaja.DataTextField = "nombre";
                        this.EntradaCaja.ExtraDetailFields = null;
                        this.EntradaCaja.Filter = "";
                        this.EntradaCaja.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCaja.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCaja.FreeTextCode = "";
                        this.EntradaCaja.DataValueField = "id_caja";
                        this.EntradaCaja.Location = new System.Drawing.Point(93, 3);
                        this.EntradaCaja.MaxLength = 200;
                        this.EntradaCaja.Name = "EntradaCaja";
                        this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCaja.TemporaryReadOnly = false;
                        this.EntradaCaja.Required = false;
                        this.EntradaCaja.Size = new System.Drawing.Size(495, 24);
                        this.EntradaCaja.TabIndex = 1;
                        this.EntradaCaja.Table = "cajas";
                        this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCaja.Text = "0";
                        this.EntradaCaja.TextDetail = "";
                        this.EntradaCaja.PlaceholderText = "";
                        this.EntradaCaja.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(3, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(84, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Caja";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaDireccion
                        // 
                        this.EntradaDireccion.AutoSize = true;
                        this.EntradaDireccion.AutoNav = true;
                        this.EntradaDireccion.AutoTab = true;
                        this.EntradaDireccion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDireccion.Location = new System.Drawing.Point(93, 123);
                        this.EntradaDireccion.MaxLenght = 32767;
                        this.EntradaDireccion.Name = "EntradaDireccion";
                        this.EntradaDireccion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDireccion.TemporaryReadOnly = false;
                        this.EntradaDireccion.SetData = new string[] {
        "Ingresos|1",
        "Egresos|2",
        "Ingresos y Egresos|0"};
                        this.EntradaDireccion.Size = new System.Drawing.Size(188, 24);
                        this.EntradaDireccion.TabIndex = 9;
                        this.EntradaDireccion.Text = "Ingresos y Egresos";
                        this.EntradaDireccion.TextKey = "0";
                        this.EntradaDireccion.PlaceholderText = "";
                        this.EntradaDireccion.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(3, 120);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(84, 24);
                        this.Label4.TabIndex = 8;
                        this.Label4.Text = "Vista";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipoConcepto
                        // 
                        this.EntradaTipoConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaTipoConcepto.AutoSize = true;
                        this.EntradaTipoConcepto.AutoNav = true;
                        this.EntradaTipoConcepto.AutoTab = true;
                        this.EntradaTipoConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipoConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipoConcepto.Location = new System.Drawing.Point(93, 93);
                        this.EntradaTipoConcepto.MaxLenght = 32767;
                        this.EntradaTipoConcepto.Name = "EntradaTipoConcepto";
                        this.EntradaTipoConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipoConcepto.TemporaryReadOnly = false;
                        this.EntradaTipoConcepto.SetData = new string[] {
        "Todos|0",
        "Gastos fijos|1",
        "Gastos variables|2",
        "Pérdida|3",
        "Reinversión|10",
        "Publicidad|11",
        "Movimientos y Ajustes|50",
        "Costo Materiales|60",
        "Costo Capital|70",
        "Sueldos y Salarios|80",
        "Cobros|100"};
                        this.EntradaTipoConcepto.Size = new System.Drawing.Size(495, 24);
                        this.EntradaTipoConcepto.TabIndex = 7;
                        this.EntradaTipoConcepto.Text = "Todos";
                        this.EntradaTipoConcepto.TextKey = "0";
                        this.EntradaTipoConcepto.PlaceholderText = "";
                        this.EntradaTipoConcepto.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Location = new System.Drawing.Point(3, 90);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(84, 24);
                        this.label6.TabIndex = 6;
                        this.label6.Text = "Tipo";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Fechas
                        // 
                        this.Fechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Fechas.AutoSize = true;
                        this.Fechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Fechas.Location = new System.Drawing.Point(93, 153);
                        this.Fechas.MuestraFuturos = false;
                        this.Fechas.Name = "Fechas";
                        this.Fechas.Padding = new System.Windows.Forms.Padding(2);
                        this.Fechas.TemporaryReadOnly = false;
                        this.Fechas.Size = new System.Drawing.Size(495, 30);
                        this.Fechas.TabIndex = 11;
                        this.Fechas.ToolTipText = "";
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.tableLayoutPanel1.ColumnCount = 2;
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                        this.tableLayoutPanel1.Controls.Add(this.Label3, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.Fechas, 1, 5);
                        this.tableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaDireccion, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaTipoConcepto, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaConcepto, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaCaja, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.EntradaPersona, 1, 1);
                        this.tableLayoutPanel1.Controls.Add(this.Label4, 0, 4);
                        this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 5);
                        this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 24);
                        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                        this.tableLayoutPanel1.RowCount = 6;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 288);
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 375);
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Filtros";
                        this.Text = "Caja: Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label Label1;
                internal Lcc.Entrada.CodigoDetalle EntradaPersona;
                internal System.Windows.Forms.Label Label5;
                internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label3;
                internal Lcc.Entrada.CodigoDetalle EntradaCaja;
                internal Lui.Forms.ComboBox EntradaDireccion;
                internal Lui.Forms.ComboBox EntradaTipoConcepto;
                internal System.Windows.Forms.Label label6;
                internal Lcc.Entrada.RangoFechas Fechas;
                internal System.Windows.Forms.Label Label4;
                private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        }
}
