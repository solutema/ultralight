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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Facturas
{
        public partial class Anular
        {
                #region Código generado por el Diseñador de Windows Forms

                // Limpiar los recursos que se estén utilizando.
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
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.EtiquetaAviso = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaAnularPagos = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.ComprobanteVistaPrevia = new Lcc.Vista.Comprobantes.ComprobanteConArticulos();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(554, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(674, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 20);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(112, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Comprobante";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AutoHeight = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(128, 20);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "A|A",
        "B|B",
        "C|C",
        "E|E",
        "M|M"};
                        this.EntradaTipo.Size = new System.Drawing.Size(40, 24);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.Text = "B";
                        this.EntradaTipo.TextKey = "B";
                        this.EntradaTipo.TextRaw = "B";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaNumeroTipoPV_TextChanged);
                        // 
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoHeight = false;
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNumero.Location = new System.Drawing.Point(252, 20);
                        this.EntradaNumero.MaxLenght = 32767;
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.PasswordChar = '\0';
                        this.EntradaNumero.Prefijo = "";
                        this.EntradaNumero.ReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(100, 24);
                        this.EntradaNumero.Sufijo = "";
                        this.EntradaNumero.TabIndex = 4;
                        this.EntradaNumero.Text = "0";
                        this.EntradaNumero.TextRaw = "0";
                        this.EntradaNumero.TipWhenBlank = "";
                        this.EntradaNumero.ToolTipText = "";
                        this.EntradaNumero.TextChanged += new System.EventHandler(this.EntradaNumeroTipoPV_TextChanged);
                        // 
                        // EtiquetaAviso
                        // 
                        this.EtiquetaAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaAviso.Location = new System.Drawing.Point(20, 52);
                        this.EtiquetaAviso.Name = "EtiquetaAviso";
                        this.EtiquetaAviso.Size = new System.Drawing.Size(756, 36);
                        this.EtiquetaAviso.TabIndex = 7;
                        this.EtiquetaAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoHeight = false;
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(176, 20);
                        this.EntradaPV.MaxLenght = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.ReadOnly = false;
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(60, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 2;
                        this.EntradaPV.Text = "1";
                        this.EntradaPV.TextRaw = "1";
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        this.EntradaPV.TextChanged += new System.EventHandler(this.EntradaNumeroTipoPV_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(236, 20);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(16, 24);
                        this.Label7.TabIndex = 3;
                        this.Label7.Text = "-";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaAnularPagos
                        // 
                        this.EntradaAnularPagos.AutoHeight = false;
                        this.EntradaAnularPagos.AutoNav = true;
                        this.EntradaAnularPagos.AutoTab = true;
                        this.EntradaAnularPagos.DetailField = null;
                        this.EntradaAnularPagos.Filter = null;
                        this.EntradaAnularPagos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaAnularPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaAnularPagos.KeyField = null;
                        this.EntradaAnularPagos.Location = new System.Drawing.Point(508, 20);
                        this.EntradaAnularPagos.MaxLenght = 32767;
                        this.EntradaAnularPagos.Name = "EntradaAnularPagos";
                        this.EntradaAnularPagos.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaAnularPagos.ReadOnly = false;
                        this.EntradaAnularPagos.SetData = new string[] {
        "Anular todos los pagos asociados|1",
        "No anular los pagos asociados|0"};
                        this.EntradaAnularPagos.Size = new System.Drawing.Size(268, 24);
                        this.EntradaAnularPagos.TabIndex = 6;
                        this.EntradaAnularPagos.Table = null;
                        this.EntradaAnularPagos.Text = "No anular los pagos asociados";
                        this.EntradaAnularPagos.TextKey = "0";
                        this.EntradaAnularPagos.TextRaw = "No anular los pagos asociados";
                        this.EntradaAnularPagos.TipWhenBlank = "";
                        this.EntradaAnularPagos.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(424, 20);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(84, 24);
                        this.label3.TabIndex = 5;
                        this.label3.Text = "Pagos";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ComprobanteVistaPrevia
                        // 
                        this.ComprobanteVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ComprobanteVistaPrevia.AutoHeight = true;
                        this.ComprobanteVistaPrevia.AutoNav = true;
                        this.ComprobanteVistaPrevia.BackColor = System.Drawing.Color.White;
                        this.ComprobanteVistaPrevia.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ComprobanteVistaPrevia.Location = new System.Drawing.Point(20, 96);
                        this.ComprobanteVistaPrevia.Name = "ComprobanteVistaPrevia";
                        this.ComprobanteVistaPrevia.ReadOnly = false;
                        this.ComprobanteVistaPrevia.Size = new System.Drawing.Size(756, 300);
                        this.ComprobanteVistaPrevia.TabIndex = 51;
                        this.ComprobanteVistaPrevia.TabStop = false;
                        this.ComprobanteVistaPrevia.Visible = false;
                        // 
                        // Anular
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(794, 472);
                        this.Controls.Add(this.ComprobanteVistaPrevia);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.EntradaAnularPagos);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EtiquetaAviso);
                        this.Name = "Anular";
                        this.Text = "Anular Comprobante";
                        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                        this.Controls.SetChildIndex(this.EtiquetaAviso, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaAnularPagos, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.EntradaPV, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.ComprobanteVistaPrevia, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label1;
                public Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.TextBox EntradaNumero;
                internal System.Windows.Forms.Label EtiquetaAviso;
                internal Lui.Forms.TextBox EntradaPV;
                internal System.Windows.Forms.Label Label7;
                public Lui.Forms.ComboBox EntradaAnularPagos;
                internal Label label3;
                private Lcc.Vista.Comprobantes.ComprobanteConArticulos ComprobanteVistaPrevia;
        }
}
