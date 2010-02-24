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
using System.Collections.Generic;
using System.Text;

namespace Lfc.Cajas.Corriente
{
        public partial class Ajuste
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
                        this.EntradaConcepto = new Lui.Forms.DetailBox();
                        this.txtImporte = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtObs = new Lui.Forms.TextBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtDireccion = new Lui.Forms.ComboBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaNuevoSaldo = new Lui.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
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
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoHeight = false;
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.DetailField = "nombre";
                        this.EntradaConcepto.ExtraDetailFields = null;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConcepto.FreeTextCode = "*";
                        this.EntradaConcepto.KeyField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(120, 24);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.ReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.SelectOnFocus = false;
                        this.EntradaConcepto.Size = new System.Drawing.Size(496, 24);
                        this.EntradaConcepto.TabIndex = 1;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        this.EntradaConcepto.TextInt = 0;
                        this.EntradaConcepto.TipWhenBlank = "";
                        this.EntradaConcepto.ToolTipText = "";
                        this.EntradaConcepto.Leave += new System.EventHandler(this.EntradaConcepto_Leave);
                        // 
                        // txtImporte
                        // 
                        this.txtImporte.AutoHeight = false;
                        this.txtImporte.AutoNav = true;
                        this.txtImporte.AutoTab = true;
                        this.txtImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImporte.DecimalPlaces = -1;
                        this.txtImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtImporte.Location = new System.Drawing.Point(120, 56);
                        this.txtImporte.MaxLenght = 32767;
                        this.txtImporte.MultiLine = false;
                        this.txtImporte.Name = "txtImporte";
                        this.txtImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImporte.PasswordChar = '\0';
                        this.txtImporte.Prefijo = "$";
                        this.txtImporte.ReadOnly = false;
                        this.txtImporte.SelectOnFocus = true;
                        this.txtImporte.Size = new System.Drawing.Size(128, 24);
                        this.txtImporte.Sufijo = "";
                        this.txtImporte.TabIndex = 3;
                        this.txtImporte.Text = "0.00";
                        this.txtImporte.TextRaw = "0.00";
                        this.txtImporte.TipWhenBlank = "";
                        this.txtImporte.ToolTipText = "";
                        this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(24, 56);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(96, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Importe";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(24, 24);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(96, 24);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Concepto";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtObs
                        // 
                        this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtObs.AutoHeight = false;
                        this.txtObs.AutoNav = true;
                        this.txtObs.AutoTab = true;
                        this.txtObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtObs.DecimalPlaces = -1;
                        this.txtObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtObs.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtObs.Location = new System.Drawing.Point(120, 120);
                        this.txtObs.MaxLenght = 32767;
                        this.txtObs.MultiLine = true;
                        this.txtObs.Name = "txtObs";
                        this.txtObs.Padding = new System.Windows.Forms.Padding(2);
                        this.txtObs.PasswordChar = '\0';
                        this.txtObs.Prefijo = "";
                        this.txtObs.ReadOnly = false;
                        this.txtObs.SelectOnFocus = false;
                        this.txtObs.Size = new System.Drawing.Size(496, 92);
                        this.txtObs.Sufijo = "";
                        this.txtObs.TabIndex = 7;
                        this.txtObs.TextRaw = "";
                        this.txtObs.TipWhenBlank = "";
                        this.txtObs.ToolTipText = "";
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(24, 120);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(96, 24);
                        this.Label4.TabIndex = 6;
                        this.Label4.Text = "Obs.";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtDireccion
                        // 
                        this.txtDireccion.AutoHeight = false;
                        this.txtDireccion.AutoNav = true;
                        this.txtDireccion.AutoTab = true;
                        this.txtDireccion.DetailField = null;
                        this.txtDireccion.Filter = null;
                        this.txtDireccion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtDireccion.KeyField = null;
                        this.txtDireccion.Location = new System.Drawing.Point(120, 88);
                        this.txtDireccion.MaxLenght = 32767;
                        this.txtDireccion.Name = "txtDireccion";
                        this.txtDireccion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDireccion.ReadOnly = false;
                        this.txtDireccion.SetData = new string[] {
        "Débito|1",
        "Crédito|0"};
                        this.txtDireccion.Size = new System.Drawing.Size(128, 24);
                        this.txtDireccion.TabIndex = 5;
                        this.txtDireccion.Table = null;
                        this.txtDireccion.Text = "Débito";
                        this.txtDireccion.TextKey = "1";
                        this.txtDireccion.TextRaw = "Débito";
                        this.txtDireccion.TipWhenBlank = "";
                        this.txtDireccion.ToolTipText = "";
                        this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(24, 88);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(96, 24);
                        this.label5.TabIndex = 4;
                        this.label5.Text = "Dirección";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNuevoSaldo
                        // 
                        this.EntradaNuevoSaldo.AutoHeight = false;
                        this.EntradaNuevoSaldo.AutoNav = true;
                        this.EntradaNuevoSaldo.AutoTab = true;
                        this.EntradaNuevoSaldo.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaNuevoSaldo.DecimalPlaces = -1;
                        this.EntradaNuevoSaldo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNuevoSaldo.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNuevoSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNuevoSaldo.Location = new System.Drawing.Point(376, 56);
                        this.EntradaNuevoSaldo.MaxLenght = 32767;
                        this.EntradaNuevoSaldo.MultiLine = false;
                        this.EntradaNuevoSaldo.Name = "EntradaNuevoSaldo";
                        this.EntradaNuevoSaldo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNuevoSaldo.PasswordChar = '\0';
                        this.EntradaNuevoSaldo.Prefijo = "$";
                        this.EntradaNuevoSaldo.ReadOnly = true;
                        this.EntradaNuevoSaldo.SelectOnFocus = true;
                        this.EntradaNuevoSaldo.Size = new System.Drawing.Size(128, 24);
                        this.EntradaNuevoSaldo.Sufijo = "";
                        this.EntradaNuevoSaldo.TabIndex = 52;
                        this.EntradaNuevoSaldo.TabStop = false;
                        this.EntradaNuevoSaldo.Text = "0.00";
                        this.EntradaNuevoSaldo.TextRaw = "0.00";
                        this.EntradaNuevoSaldo.TipWhenBlank = "";
                        this.EntradaNuevoSaldo.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(280, 56);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(96, 24);
                        this.label3.TabIndex = 51;
                        this.label3.Text = "Nuevo Saldo";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Ajuste
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 375);
                        this.Controls.Add(this.EntradaNuevoSaldo);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.txtDireccion);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.txtObs);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EntradaConcepto);
                        this.Controls.Add(this.txtImporte);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Name = "Ajuste";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.txtImporte, 0);
                        this.Controls.SetChildIndex(this.EntradaConcepto, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.txtObs, 0);
                        this.Controls.SetChildIndex(this.label5, 0);
                        this.Controls.SetChildIndex(this.txtDireccion, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaNuevoSaldo, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                internal Lui.Forms.DetailBox EntradaConcepto;
                internal Lui.Forms.TextBox txtImporte;
                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox txtObs;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label label5;
                internal Lui.Forms.ComboBox txtDireccion;
                internal Lui.Forms.TextBox EntradaNuevoSaldo;
                internal System.Windows.Forms.Label label3;
        }
}