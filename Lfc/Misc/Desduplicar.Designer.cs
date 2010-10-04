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

namespace Lfc.Misc
{
        partial class Desduplicar
        {
                /// <summary>
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de Windows Forms

                /// <summary>
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        this.EtiquetaElemento1 = new System.Windows.Forms.Label();
                        this.EntradaElementoDuplicado = new Lcc.Entrada.CodigoDetalle();
                        this.EtiquetaElemento2 = new System.Windows.Forms.Label();
                        this.EntradaElementoOriginal = new Lcc.Entrada.CodigoDetalle();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.note1 = new Lui.Forms.Note();
                        this.PanelPersona = new System.Windows.Forms.Panel();
                        this.EntradaCtaCteFinal = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaCtaCte2 = new Lui.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.EntradaCtaCte1 = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.PanelPersona.SuspendLayout();
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
                        // EtiquetaElemento1
                        // 
                        this.EtiquetaElemento1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaElemento1.Location = new System.Drawing.Point(28, 56);
                        this.EtiquetaElemento1.Name = "EtiquetaElemento1";
                        this.EtiquetaElemento1.Size = new System.Drawing.Size(124, 24);
                        this.EtiquetaElemento1.TabIndex = 2;
                        this.EtiquetaElemento1.Text = "Registro 1";
                        this.EtiquetaElemento1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaElementoDuplicado
                        // 
                        this.EntradaElementoDuplicado.AutoHeight = false;
                        this.EntradaElementoDuplicado.AutoTab = true;
                        this.EntradaElementoDuplicado.CanCreate = true;
                        this.EntradaElementoDuplicado.DetailField = "nombre_visible";
                        this.EntradaElementoDuplicado.ExtraDetailFields = null;
                        this.EntradaElementoDuplicado.Filter = "";
                        this.EntradaElementoDuplicado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaElementoDuplicado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaElementoDuplicado.FreeTextCode = "";
                        this.EntradaElementoDuplicado.KeyField = "id_persona";
                        this.EntradaElementoDuplicado.Location = new System.Drawing.Point(152, 88);
                        this.EntradaElementoDuplicado.MaxLength = 200;
                        this.EntradaElementoDuplicado.Name = "EntradaElementoDuplicado";
                        this.EntradaElementoDuplicado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaElementoDuplicado.ReadOnly = false;
                        this.EntradaElementoDuplicado.Required = true;
                        this.EntradaElementoDuplicado.Size = new System.Drawing.Size(456, 24);
                        this.EntradaElementoDuplicado.TabIndex = 5;
                        this.EntradaElementoDuplicado.Table = "personas";
                        this.EntradaElementoDuplicado.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaElementoDuplicado.Text = "0";
                        this.EntradaElementoDuplicado.TextDetail = "";
                        this.EntradaElementoDuplicado.TipWhenBlank = "";
                        this.EntradaElementoDuplicado.ToolTipText = "";
                        this.EntradaElementoDuplicado.TextChanged += new System.EventHandler(this.EntradaElementoDuplicado_TextChanged);
                        // 
                        // EtiquetaElemento2
                        // 
                        this.EtiquetaElemento2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaElemento2.Location = new System.Drawing.Point(28, 88);
                        this.EtiquetaElemento2.Name = "EtiquetaElemento2";
                        this.EtiquetaElemento2.Size = new System.Drawing.Size(124, 24);
                        this.EtiquetaElemento2.TabIndex = 4;
                        this.EtiquetaElemento2.Text = "Registro 2";
                        this.EtiquetaElemento2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaElementoOriginal
                        // 
                        this.EntradaElementoOriginal.AutoHeight = false;
                        this.EntradaElementoOriginal.AutoTab = true;
                        this.EntradaElementoOriginal.CanCreate = true;
                        this.EntradaElementoOriginal.DetailField = "nombre_visible";
                        this.EntradaElementoOriginal.ExtraDetailFields = null;
                        this.EntradaElementoOriginal.Filter = "";
                        this.EntradaElementoOriginal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaElementoOriginal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaElementoOriginal.FreeTextCode = "";
                        this.EntradaElementoOriginal.KeyField = "id_persona";
                        this.EntradaElementoOriginal.Location = new System.Drawing.Point(152, 56);
                        this.EntradaElementoOriginal.MaxLength = 200;
                        this.EntradaElementoOriginal.Name = "EntradaElementoOriginal";
                        this.EntradaElementoOriginal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaElementoOriginal.ReadOnly = false;
                        this.EntradaElementoOriginal.Required = true;
                        this.EntradaElementoOriginal.Size = new System.Drawing.Size(456, 24);
                        this.EntradaElementoOriginal.TabIndex = 3;
                        this.EntradaElementoOriginal.Table = "personas";
                        this.EntradaElementoOriginal.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaElementoOriginal.Text = "0";
                        this.EntradaElementoOriginal.TextDetail = "";
                        this.EntradaElementoOriginal.TipWhenBlank = "";
                        this.EntradaElementoOriginal.ToolTipText = "";
                        this.EntradaElementoOriginal.TextChanged += new System.EventHandler(this.EntradaElementoOriginal_TextChanged);
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoHeight = false;
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.DetailField = null;
                        this.txtTipo.Filter = null;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.KeyField = null;
                        this.txtTipo.Location = new System.Drawing.Point(152, 24);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Persona|personas"};
                        this.txtTipo.Size = new System.Drawing.Size(140, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Table = null;
                        this.txtTipo.Text = "Persona";
                        this.txtTipo.TextKey = "personas";
                        this.txtTipo.TextRaw = "Persona";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(28, 24);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(124, 24);
                        this.label3.TabIndex = 0;
                        this.label3.Text = "Tipo de registro";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // note1
                        // 
                        this.note1.AutoHeight = false;
                        this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.note1.Location = new System.Drawing.Point(16, 232);
                        this.note1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.note1.Name = "note1";
                        this.note1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.note1.ReadOnly = false;
                        this.note1.Size = new System.Drawing.Size(604, 68);
                        this.note1.TabIndex = 7;
                        this.note1.TabStop = false;
                        this.note1.Text = "Todos los datos relacionados al registro 2, como su cuenta corriente, comprobante" +
                            "s y movimientos de caja o stock, pasarán al registro 1. El registro 2 será enton" +
                            "ces eliminado.";
                        this.note1.Title = "Nota";
                        this.note1.ToolTipText = "";
                        // 
                        // PanelPersona
                        // 
                        this.PanelPersona.Controls.Add(this.EntradaCtaCteFinal);
                        this.PanelPersona.Controls.Add(this.label4);
                        this.PanelPersona.Controls.Add(this.EntradaCtaCte2);
                        this.PanelPersona.Controls.Add(this.label2);
                        this.PanelPersona.Controls.Add(this.EntradaCtaCte1);
                        this.PanelPersona.Controls.Add(this.label1);
                        this.PanelPersona.Location = new System.Drawing.Point(28, 120);
                        this.PanelPersona.Name = "PanelPersona";
                        this.PanelPersona.Size = new System.Drawing.Size(576, 104);
                        this.PanelPersona.TabIndex = 6;
                        // 
                        // EntradaCtaCteFinal
                        // 
                        this.EntradaCtaCteFinal.AutoHeight = false;
                        this.EntradaCtaCteFinal.AutoNav = true;
                        this.EntradaCtaCteFinal.AutoTab = true;
                        this.EntradaCtaCteFinal.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCtaCteFinal.DecimalPlaces = -1;
                        this.EntradaCtaCteFinal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCtaCteFinal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCtaCteFinal.Location = new System.Drawing.Point(276, 72);
                        this.EntradaCtaCteFinal.MaxLenght = 32767;
                        this.EntradaCtaCteFinal.MultiLine = false;
                        this.EntradaCtaCteFinal.Name = "EntradaCtaCteFinal";
                        this.EntradaCtaCteFinal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCtaCteFinal.PasswordChar = '\0';
                        this.EntradaCtaCteFinal.Prefijo = "$";
                        this.EntradaCtaCteFinal.ReadOnly = true;
                        this.EntradaCtaCteFinal.SelectOnFocus = true;
                        this.EntradaCtaCteFinal.Size = new System.Drawing.Size(120, 24);
                        this.EntradaCtaCteFinal.Sufijo = "";
                        this.EntradaCtaCteFinal.TabIndex = 5;
                        this.EntradaCtaCteFinal.TabStop = false;
                        this.EntradaCtaCteFinal.Text = "0.00";
                        this.EntradaCtaCteFinal.TextRaw = "0.00";
                        this.EntradaCtaCteFinal.TipWhenBlank = "";
                        this.EntradaCtaCteFinal.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label4.Location = new System.Drawing.Point(124, 72);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(156, 24);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "Saldo resultante";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCtaCte2
                        // 
                        this.EntradaCtaCte2.AutoHeight = false;
                        this.EntradaCtaCte2.AutoNav = true;
                        this.EntradaCtaCte2.AutoTab = true;
                        this.EntradaCtaCte2.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCtaCte2.DecimalPlaces = -1;
                        this.EntradaCtaCte2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCtaCte2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCtaCte2.Location = new System.Drawing.Point(276, 36);
                        this.EntradaCtaCte2.MaxLenght = 32767;
                        this.EntradaCtaCte2.MultiLine = false;
                        this.EntradaCtaCte2.Name = "EntradaCtaCte2";
                        this.EntradaCtaCte2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCtaCte2.PasswordChar = '\0';
                        this.EntradaCtaCte2.Prefijo = "$";
                        this.EntradaCtaCte2.ReadOnly = true;
                        this.EntradaCtaCte2.SelectOnFocus = true;
                        this.EntradaCtaCte2.Size = new System.Drawing.Size(120, 24);
                        this.EntradaCtaCte2.Sufijo = "";
                        this.EntradaCtaCte2.TabIndex = 3;
                        this.EntradaCtaCte2.TabStop = false;
                        this.EntradaCtaCte2.Text = "0.00";
                        this.EntradaCtaCte2.TextRaw = "0.00";
                        this.EntradaCtaCte2.TipWhenBlank = "";
                        this.EntradaCtaCte2.ToolTipText = "";
                        this.EntradaCtaCte2.TextChanged += new System.EventHandler(this.EntradaCtaCte1CtaCte2_TextChanged);
                        // 
                        // label2
                        // 
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(124, 36);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(152, 24);
                        this.label2.TabIndex = 2;
                        this.label2.Text = "Saldo registro 2";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCtaCte1
                        // 
                        this.EntradaCtaCte1.AutoHeight = false;
                        this.EntradaCtaCte1.AutoNav = true;
                        this.EntradaCtaCte1.AutoTab = true;
                        this.EntradaCtaCte1.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaCtaCte1.DecimalPlaces = -1;
                        this.EntradaCtaCte1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaCtaCte1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCtaCte1.Location = new System.Drawing.Point(276, 8);
                        this.EntradaCtaCte1.MaxLenght = 32767;
                        this.EntradaCtaCte1.MultiLine = false;
                        this.EntradaCtaCte1.Name = "EntradaCtaCte1";
                        this.EntradaCtaCte1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCtaCte1.PasswordChar = '\0';
                        this.EntradaCtaCte1.Prefijo = "$";
                        this.EntradaCtaCte1.ReadOnly = true;
                        this.EntradaCtaCte1.SelectOnFocus = true;
                        this.EntradaCtaCte1.Size = new System.Drawing.Size(120, 24);
                        this.EntradaCtaCte1.Sufijo = "";
                        this.EntradaCtaCte1.TabIndex = 1;
                        this.EntradaCtaCte1.TabStop = false;
                        this.EntradaCtaCte1.Text = "0.00";
                        this.EntradaCtaCte1.TextRaw = "0.00";
                        this.EntradaCtaCte1.TipWhenBlank = "";
                        this.EntradaCtaCte1.ToolTipText = "";
                        this.EntradaCtaCte1.TextChanged += new System.EventHandler(this.EntradaCtaCte1CtaCte2_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(124, 8);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(152, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Saldo registro 1";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Desduplicar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.PanelPersona);
                        this.Controls.Add(this.note1);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EntradaElementoOriginal);
                        this.Controls.Add(this.EntradaElementoDuplicado);
                        this.Controls.Add(this.EtiquetaElemento2);
                        this.Controls.Add(this.EtiquetaElemento1);
                        this.Name = "Desduplicar";
                        this.Text = "Desduplicar";
                        this.Controls.SetChildIndex(this.EtiquetaElemento1, 0);
                        this.Controls.SetChildIndex(this.EtiquetaElemento2, 0);
                        this.Controls.SetChildIndex(this.EntradaElementoDuplicado, 0);
                        this.Controls.SetChildIndex(this.EntradaElementoOriginal, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.note1, 0);
                        this.Controls.SetChildIndex(this.PanelPersona, 0);
                        this.PanelPersona.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label EtiquetaElemento1;
                internal Lcc.Entrada.CodigoDetalle EntradaElementoDuplicado;
                internal System.Windows.Forms.Label EtiquetaElemento2;
                internal Lcc.Entrada.CodigoDetalle EntradaElementoOriginal;
                internal Lui.Forms.ComboBox txtTipo;
                internal System.Windows.Forms.Label label3;
                private Lui.Forms.Note note1;
                private System.Windows.Forms.Panel PanelPersona;
                internal System.Windows.Forms.Label label1;
                private Lui.Forms.TextBox EntradaCtaCte2;
                internal System.Windows.Forms.Label label2;
                private Lui.Forms.TextBox EntradaCtaCte1;
                private Lui.Forms.TextBox EntradaCtaCteFinal;
                internal System.Windows.Forms.Label label4;
        }
}