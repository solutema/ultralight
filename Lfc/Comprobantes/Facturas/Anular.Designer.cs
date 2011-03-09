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
                        this.EntradaDesde = new Lui.Forms.TextBox();
                        this.EtiquetaAviso = new System.Windows.Forms.Label();
                        this.EntradaPV = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.EntradaAnularPagos = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.ComprobanteVistaPrevia = new Lfc.Comprobantes.Facturas.Editar();
                        this.EntradaHasta = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.ListadoFacturas = new Lui.Forms.ListView();
                        this.ColTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.label4 = new System.Windows.Forms.Label();
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
                        this.Label1.Size = new System.Drawing.Size(128, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Comprobante";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(148, 20);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.SetData = new string[] {
        "A|A",
        "B|B",
        "C|C",
        "E|E",
        "M|M"};
                        this.EntradaTipo.Size = new System.Drawing.Size(40, 26);
                        this.EntradaTipo.TabIndex = 1;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.TextKey = "B";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaDesdeTipoPV_TextChanged);
                        // 
                        // EntradaDesde
                        // 
                        this.EntradaDesde.AutoNav = true;
                        this.EntradaDesde.AutoTab = true;
                        this.EntradaDesde.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaDesde.DecimalPlaces = -1;
                        this.EntradaDesde.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaDesde.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaDesde.Location = new System.Drawing.Point(292, 20);
                        this.EntradaDesde.MaxLenght = 32767;
                        this.EntradaDesde.MultiLine = false;
                        this.EntradaDesde.Name = "EntradaDesde";
                        this.EntradaDesde.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaDesde.PasswordChar = '\0';
                        this.EntradaDesde.Prefijo = "";
                        this.EntradaDesde.SelectOnFocus = true;
                        this.EntradaDesde.Size = new System.Drawing.Size(100, 24);
                        this.EntradaDesde.Sufijo = "";
                        this.EntradaDesde.TabIndex = 5;
                        this.EntradaDesde.Text = "0";
                        this.EntradaDesde.TipWhenBlank = "";
                        this.EntradaDesde.ToolTipText = "";
                        this.EntradaDesde.TextChanged += new System.EventHandler(this.EntradaDesdeTipoPV_TextChanged);
                        // 
                        // EtiquetaAviso
                        // 
                        this.EtiquetaAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaAviso.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaAviso.ForeColor = System.Drawing.Color.Tomato;
                        this.EtiquetaAviso.Location = new System.Drawing.Point(20, 80);
                        this.EtiquetaAviso.Name = "EtiquetaAviso";
                        this.EtiquetaAviso.Size = new System.Drawing.Size(756, 28);
                        this.EtiquetaAviso.TabIndex = 10;
                        this.EtiquetaAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaPV
                        // 
                        this.EntradaPV.AutoNav = true;
                        this.EntradaPV.AutoTab = true;
                        this.EntradaPV.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaPV.DecimalPlaces = -1;
                        this.EntradaPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaPV.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaPV.Location = new System.Drawing.Point(148, 48);
                        this.EntradaPV.MaxLenght = 32767;
                        this.EntradaPV.MultiLine = false;
                        this.EntradaPV.Name = "EntradaPV";
                        this.EntradaPV.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPV.PasswordChar = '\0';
                        this.EntradaPV.Prefijo = "";
                        this.EntradaPV.SelectOnFocus = true;
                        this.EntradaPV.Size = new System.Drawing.Size(52, 24);
                        this.EntradaPV.Sufijo = "";
                        this.EntradaPV.TabIndex = 3;
                        this.EntradaPV.Text = "1";
                        this.EntradaPV.TipWhenBlank = "";
                        this.EntradaPV.ToolTipText = "";
                        this.EntradaPV.TextChanged += new System.EventHandler(this.EntradaDesdeTipoPV_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(228, 20);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(64, 24);
                        this.Label7.TabIndex = 4;
                        this.Label7.Text = "Desde";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaAnularPagos
                        // 
                        this.EntradaAnularPagos.AlwaysExpanded = true;
                        this.EntradaAnularPagos.AutoNav = true;
                        this.EntradaAnularPagos.AutoSize = true;
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
                        this.EntradaAnularPagos.SetData = new string[] {
        "Anular todos los pagos asociados|1",
        "No anular los pagos asociados|0"};
                        this.EntradaAnularPagos.Size = new System.Drawing.Size(268, 36);
                        this.EntradaAnularPagos.TabIndex = 9;
                        this.EntradaAnularPagos.Table = null;
                        this.EntradaAnularPagos.TextKey = "0";
                        this.EntradaAnularPagos.TipWhenBlank = "";
                        this.EntradaAnularPagos.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(436, 20);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(72, 24);
                        this.label3.TabIndex = 8;
                        this.label3.Text = "Pagos";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ComprobanteVistaPrevia
                        // 
                        this.ComprobanteVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ComprobanteVistaPrevia.AutoNav = true;
                        this.ComprobanteVistaPrevia.AutoSize = true;
                        this.ComprobanteVistaPrevia.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.ComprobanteVistaPrevia.Location = new System.Drawing.Point(20, 112);
                        this.ComprobanteVistaPrevia.MinimumSize = new System.Drawing.Size(600, 320);
                        this.ComprobanteVistaPrevia.Name = "ComprobanteVistaPrevia";
                        this.ComprobanteVistaPrevia.Padding = new System.Windows.Forms.Padding(2);
                        this.ComprobanteVistaPrevia.Size = new System.Drawing.Size(756, 320);
                        this.ComprobanteVistaPrevia.TabIndex = 12;
                        this.ComprobanteVistaPrevia.TabStop = false;
                        this.ComprobanteVistaPrevia.ToolTipText = "";
                        this.ComprobanteVistaPrevia.Visible = false;
                        // 
                        // EntradaHasta
                        // 
                        this.EntradaHasta.AutoNav = true;
                        this.EntradaHasta.AutoTab = true;
                        this.EntradaHasta.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaHasta.DecimalPlaces = -1;
                        this.EntradaHasta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaHasta.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaHasta.Location = new System.Drawing.Point(292, 48);
                        this.EntradaHasta.MaxLenght = 32767;
                        this.EntradaHasta.MultiLine = false;
                        this.EntradaHasta.Name = "EntradaHasta";
                        this.EntradaHasta.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaHasta.PasswordChar = '\0';
                        this.EntradaHasta.Prefijo = "";
                        this.EntradaHasta.SelectOnFocus = true;
                        this.EntradaHasta.Size = new System.Drawing.Size(100, 24);
                        this.EntradaHasta.Sufijo = "";
                        this.EntradaHasta.TabIndex = 7;
                        this.EntradaHasta.Text = "0";
                        this.EntradaHasta.TipWhenBlank = "";
                        this.EntradaHasta.ToolTipText = "";
                        this.EntradaHasta.TextChanged += new System.EventHandler(this.EntradaDesdeTipoPV_TextChanged);
                        this.EntradaHasta.Enter += new System.EventHandler(this.EntradaHasta_Enter);
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(228, 48);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(64, 24);
                        this.label2.TabIndex = 6;
                        this.label2.Text = "Hasta";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ListadoFacturas
                        // 
                        this.ListadoFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListadoFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListadoFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColTipo,
            this.ColNumero,
            this.ColFecha,
            this.ColCliente,
            this.ColImporte});
                        this.ListadoFacturas.FullRowSelect = true;
                        this.ListadoFacturas.GridLines = true;
                        this.ListadoFacturas.LabelWrap = false;
                        this.ListadoFacturas.Location = new System.Drawing.Point(20, 112);
                        this.ListadoFacturas.MultiSelect = false;
                        this.ListadoFacturas.Name = "ListadoFacturas";
                        this.ListadoFacturas.Size = new System.Drawing.Size(756, 284);
                        this.ListadoFacturas.TabIndex = 11;
                        this.ListadoFacturas.UseCompatibleStateImageBehavior = false;
                        this.ListadoFacturas.View = System.Windows.Forms.View.Details;
                        // 
                        // ColTipo
                        // 
                        this.ColTipo.Text = "Tipo";
                        this.ColTipo.Width = 120;
                        // 
                        // ColNumero
                        // 
                        this.ColNumero.Text = "Número";
                        this.ColNumero.Width = 120;
                        // 
                        // ColFecha
                        // 
                        this.ColFecha.Text = "Fecha";
                        this.ColFecha.Width = 96;
                        // 
                        // ColCliente
                        // 
                        this.ColCliente.Text = "Cliente";
                        this.ColCliente.Width = 320;
                        // 
                        // ColImporte
                        // 
                        this.ColImporte.Text = "Importe";
                        this.ColImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColImporte.Width = 96;
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(20, 48);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(128, 24);
                        this.label4.TabIndex = 2;
                        this.label4.Text = "Punto de Venta";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Anular
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(794, 472);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.ListadoFacturas);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaHasta);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.EntradaAnularPagos);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaPV);
                        this.Controls.Add(this.EntradaDesde);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.EtiquetaAviso);
                        this.Controls.Add(this.ComprobanteVistaPrevia);
                        this.Name = "Anular";
                        this.Text = "Anular Comprobante";
                        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                        this.Controls.SetChildIndex(this.ComprobanteVistaPrevia, 0);
                        this.Controls.SetChildIndex(this.EtiquetaAviso, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaDesde, 0);
                        this.Controls.SetChildIndex(this.EntradaPV, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaAnularPagos, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.EntradaHasta, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.ListadoFacturas, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.ComponentModel.IContainer components = null;

                internal System.Windows.Forms.Label Label1;
                public Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.TextBox EntradaDesde;
                internal System.Windows.Forms.Label EtiquetaAviso;
                internal Lui.Forms.TextBox EntradaPV;
                internal System.Windows.Forms.Label Label7;
                public Lui.Forms.ComboBox EntradaAnularPagos;
                private Label label3;
                private Lfc.Comprobantes.Facturas.Editar ComprobanteVistaPrevia;
                internal Lui.Forms.TextBox EntradaHasta;
                internal Label label2;
                private Lui.Forms.ListView ListadoFacturas;
                internal Label label4;
                private ColumnHeader ColTipo;
                private ColumnHeader ColNumero;
                private ColumnHeader ColFecha;
                private ColumnHeader ColCliente;
                private ColumnHeader ColImporte;
        }
}
