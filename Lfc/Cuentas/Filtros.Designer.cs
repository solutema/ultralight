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

namespace Lfc.Cuentas
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

                private System.ComponentModel.Container components = null;

                private void InitializeComponent()
                {
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtPersona = new Lui.Forms.DetailBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtConcepto = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtCuenta = new Lui.Forms.DetailBox();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.txtDireccion = new Lui.Forms.ComboBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtTipoConcepto = new Lui.Forms.ComboBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.Fechas = new Lcc.Controles.RangoFechas();
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
                        // txtPersona
                        // 
                        this.txtPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtPersona.AutoHeight = true;
                        this.txtPersona.AutoTab = true;
                        this.txtPersona.CanCreate = false;
                        this.txtPersona.DetailField = "nombre_visible";
                        this.txtPersona.ExtraDetailFields = null;
                        this.txtPersona.Filter = "";
                        this.txtPersona.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPersona.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPersona.FreeTextCode = "";
                        this.txtPersona.KeyField = "id_persona";
                        this.txtPersona.Location = new System.Drawing.Point(93, 33);
                        this.txtPersona.MaxLength = 200;
                        this.txtPersona.Name = "txtPersona";
                        this.txtPersona.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPersona.ReadOnly = false;
                        this.txtPersona.Required = false;
                        this.txtPersona.SelectOnFocus = false;
                        this.txtPersona.Size = new System.Drawing.Size(495, 24);
                        this.txtPersona.TabIndex = 3;
                        this.txtPersona.Table = "personas";
                        this.txtPersona.TeclaDespuesDeEnter = "{tab}";
                        this.txtPersona.Text = "0";
                        this.txtPersona.TextDetail = "";
                        this.txtPersona.TextInt = 0;
                        this.txtPersona.TipWhenBlank = "";
                        this.txtPersona.ToolTipText = "";
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
                        // txtConcepto
                        // 
                        this.txtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtConcepto.AutoHeight = true;
                        this.txtConcepto.AutoTab = true;
                        this.txtConcepto.CanCreate = false;
                        this.txtConcepto.DetailField = "nombre";
                        this.txtConcepto.ExtraDetailFields = null;
                        this.txtConcepto.Filter = "";
                        this.txtConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtConcepto.FreeTextCode = "*";
                        this.txtConcepto.KeyField = "id_concepto";
                        this.txtConcepto.Location = new System.Drawing.Point(93, 63);
                        this.txtConcepto.MaxLength = 200;
                        this.txtConcepto.Name = "txtConcepto";
                        this.txtConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtConcepto.ReadOnly = false;
                        this.txtConcepto.Required = false;
                        this.txtConcepto.SelectOnFocus = false;
                        this.txtConcepto.Size = new System.Drawing.Size(495, 24);
                        this.txtConcepto.TabIndex = 5;
                        this.txtConcepto.Table = "cuentas_conceptos";
                        this.txtConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.txtConcepto.Text = "0";
                        this.txtConcepto.TextDetail = "";
                        this.txtConcepto.TextInt = 0;
                        this.txtConcepto.TipWhenBlank = "";
                        this.txtConcepto.ToolTipText = "";
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
                        // txtCuenta
                        // 
                        this.txtCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCuenta.AutoHeight = true;
                        this.txtCuenta.AutoTab = true;
                        this.txtCuenta.CanCreate = false;
                        this.txtCuenta.DetailField = "nombre";
                        this.txtCuenta.ExtraDetailFields = null;
                        this.txtCuenta.Filter = "";
                        this.txtCuenta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCuenta.FreeTextCode = "";
                        this.txtCuenta.KeyField = "id_cuenta";
                        this.txtCuenta.Location = new System.Drawing.Point(93, 3);
                        this.txtCuenta.MaxLength = 200;
                        this.txtCuenta.Name = "txtCuenta";
                        this.txtCuenta.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCuenta.ReadOnly = false;
                        this.txtCuenta.Required = false;
                        this.txtCuenta.SelectOnFocus = false;
                        this.txtCuenta.Size = new System.Drawing.Size(495, 24);
                        this.txtCuenta.TabIndex = 1;
                        this.txtCuenta.Table = "cuentas";
                        this.txtCuenta.TeclaDespuesDeEnter = "{tab}";
                        this.txtCuenta.Text = "0";
                        this.txtCuenta.TextDetail = "";
                        this.txtCuenta.TextInt = 0;
                        this.txtCuenta.TipWhenBlank = "";
                        this.txtCuenta.ToolTipText = "";
                        // 
                        // Label3
                        // 
                        this.Label3.Location = new System.Drawing.Point(3, 0);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(84, 24);
                        this.Label3.TabIndex = 0;
                        this.Label3.Text = "Cuenta";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtDireccion
                        // 
                        this.txtDireccion.AutoHeight = true;
                        this.txtDireccion.AutoNav = true;
                        this.txtDireccion.AutoTab = true;
                        this.txtDireccion.DetailField = null;
                        this.txtDireccion.Filter = null;
                        this.txtDireccion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDireccion.KeyField = null;
                        this.txtDireccion.Location = new System.Drawing.Point(93, 123);
                        this.txtDireccion.MaxLenght = 32767;
                        this.txtDireccion.Name = "txtDireccion";
                        this.txtDireccion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDireccion.ReadOnly = false;
                        this.txtDireccion.SetData = new string[] {
        "Ingresos|1",
        "Egresos|2",
        "Ingresos y Egresos|0"};
                        this.txtDireccion.Size = new System.Drawing.Size(188, 24);
                        this.txtDireccion.TabIndex = 9;
                        this.txtDireccion.Table = null;
                        this.txtDireccion.Text = "Ingresos y Egresos";
                        this.txtDireccion.TextKey = "0";
                        this.txtDireccion.TextRaw = "Ingresos y Egresos";
                        this.txtDireccion.TipWhenBlank = "";
                        this.txtDireccion.ToolTipText = "";
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
                        // txtTipoConcepto
                        // 
                        this.txtTipoConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTipoConcepto.AutoHeight = true;
                        this.txtTipoConcepto.AutoNav = true;
                        this.txtTipoConcepto.AutoTab = true;
                        this.txtTipoConcepto.DetailField = null;
                        this.txtTipoConcepto.Filter = null;
                        this.txtTipoConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipoConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipoConcepto.KeyField = null;
                        this.txtTipoConcepto.Location = new System.Drawing.Point(93, 93);
                        this.txtTipoConcepto.MaxLenght = 32767;
                        this.txtTipoConcepto.Name = "txtTipoConcepto";
                        this.txtTipoConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipoConcepto.ReadOnly = false;
                        this.txtTipoConcepto.SetData = new string[] {
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
                        this.txtTipoConcepto.Size = new System.Drawing.Size(495, 24);
                        this.txtTipoConcepto.TabIndex = 7;
                        this.txtTipoConcepto.Table = null;
                        this.txtTipoConcepto.Text = "Todos";
                        this.txtTipoConcepto.TextKey = "0";
                        this.txtTipoConcepto.TextRaw = "Todos";
                        this.txtTipoConcepto.TipWhenBlank = "";
                        this.txtTipoConcepto.ToolTipText = "";
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
                        this.Fechas.AutoHeight = true;
                        this.Fechas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Fechas.Location = new System.Drawing.Point(93, 153);
                        this.Fechas.MuestraFuturos = false;
                        this.Fechas.Name = "Fechas";
                        this.Fechas.Padding = new System.Windows.Forms.Padding(2);
                        this.Fechas.ReadOnly = false;
                        this.Fechas.Size = new System.Drawing.Size(495, 30);
                        this.Fechas.TabIndex = 11;
                        this.Fechas.Text = "rangoFechas1";
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
                        this.tableLayoutPanel1.Controls.Add(this.txtDireccion, 1, 4);
                        this.tableLayoutPanel1.Controls.Add(this.txtTipoConcepto, 1, 3);
                        this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
                        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
                        this.tableLayoutPanel1.Controls.Add(this.txtConcepto, 1, 2);
                        this.tableLayoutPanel1.Controls.Add(this.txtCuenta, 1, 0);
                        this.tableLayoutPanel1.Controls.Add(this.txtPersona, 1, 1);
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
                        this.Text = "Cuenta: Filtros";
                        this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.DetailBox txtPersona;
                internal System.Windows.Forms.Label Label5;
                internal Lui.Forms.DetailBox txtConcepto;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label3;
                internal Lui.Forms.DetailBox txtCuenta;
                internal Lui.Forms.ComboBox txtDireccion;
                internal Lui.Forms.ComboBox txtTipoConcepto;
                internal System.Windows.Forms.Label label6;
                internal Lcc.Controles.RangoFechas Fechas;
                internal System.Windows.Forms.Label Label4;
                private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        }
}
