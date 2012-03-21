#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
                        this.EtiquetaElemento1 = new Lui.Forms.Label();
                        this.EntradaElementoDuplicado = new Lcc.Entrada.CodigoDetalle();
                        this.EtiquetaElemento2 = new Lui.Forms.Label();
                        this.EntradaElementoOriginal = new Lcc.Entrada.CodigoDetalle();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.label3 = new Lui.Forms.Label();
                        this.note1 = new Lui.Forms.Note();
                        this.PanelPersona = new Lui.Forms.Panel();
                        this.EntradaCtaCteFinal = new Lui.Forms.TextBox();
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaCtaCte2 = new Lui.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaCtaCte1 = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
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
                        this.EtiquetaElemento1.Location = new System.Drawing.Point(28, 56);
                        this.EtiquetaElemento1.Name = "EtiquetaElemento1";
                        this.EtiquetaElemento1.Size = new System.Drawing.Size(124, 24);
                        this.EtiquetaElemento1.TabIndex = 2;
                        this.EtiquetaElemento1.Text = "Registro 1";
                        this.EtiquetaElemento1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaElementoDuplicado
                        // 
                        this.EntradaElementoDuplicado.CanCreate = true;
                        this.EntradaElementoDuplicado.Filter = "";
                        this.EntradaElementoDuplicado.Location = new System.Drawing.Point(152, 88);
                        this.EntradaElementoDuplicado.MaxLength = 200;
                        this.EntradaElementoDuplicado.Name = "EntradaElementoDuplicado";
                        this.EntradaElementoDuplicado.ReadOnly = false;
                        this.EntradaElementoDuplicado.Required = true;
                        this.EntradaElementoDuplicado.Size = new System.Drawing.Size(456, 24);
                        this.EntradaElementoDuplicado.TabIndex = 5;
                        this.EntradaElementoDuplicado.NombreTipo = "Lbl.Personas.Persona";
                        this.EntradaElementoDuplicado.Text = "0";
                        this.EntradaElementoDuplicado.TextChanged += new System.EventHandler(this.EntradaElementoDuplicado_TextChanged);
                        // 
                        // EtiquetaElemento2
                        // 
                        this.EtiquetaElemento2.Location = new System.Drawing.Point(28, 88);
                        this.EtiquetaElemento2.Name = "EtiquetaElemento2";
                        this.EtiquetaElemento2.Size = new System.Drawing.Size(124, 24);
                        this.EtiquetaElemento2.TabIndex = 4;
                        this.EtiquetaElemento2.Text = "Registro 2";
                        this.EtiquetaElemento2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaElementoOriginal
                        // 
                        this.EntradaElementoOriginal.CanCreate = true;
                        this.EntradaElementoOriginal.Filter = "";
                        this.EntradaElementoOriginal.Location = new System.Drawing.Point(152, 56);
                        this.EntradaElementoOriginal.MaxLength = 200;
                        this.EntradaElementoOriginal.Name = "EntradaElementoOriginal";
                        this.EntradaElementoOriginal.ReadOnly = false;
                        this.EntradaElementoOriginal.Required = true;
                        this.EntradaElementoOriginal.Size = new System.Drawing.Size(456, 24);
                        this.EntradaElementoOriginal.TabIndex = 3;
                        this.EntradaElementoOriginal.NombreTipo = "Lbl.Personas.Persona";
                        this.EntradaElementoOriginal.Text = "0";
                        this.EntradaElementoOriginal.TextChanged += new System.EventHandler(this.EntradaElementoOriginal_TextChanged);
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AlwaysExpanded = true;
                        this.txtTipo.AutoSize = true;
                        this.txtTipo.Location = new System.Drawing.Point(152, 24);
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Persona|personas"};
                        this.txtTipo.Size = new System.Drawing.Size(140, 21);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.TextKey = "personas";
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
                        this.note1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.note1.Location = new System.Drawing.Point(16, 232);
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
                        this.EntradaCtaCteFinal.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCtaCteFinal.Location = new System.Drawing.Point(276, 72);
                        this.EntradaCtaCteFinal.Name = "EntradaCtaCteFinal";
                        this.EntradaCtaCteFinal.Prefijo = "$";
                        this.EntradaCtaCteFinal.ReadOnly = false;
                        this.EntradaCtaCteFinal.Size = new System.Drawing.Size(120, 24);
                        this.EntradaCtaCteFinal.TabIndex = 5;
                        this.EntradaCtaCteFinal.TabStop = false;
                        this.EntradaCtaCteFinal.Text = "0.00";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(124, 72);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(156, 24);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "Saldo resultante";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCtaCte2
                        // 
                        this.EntradaCtaCte2.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCtaCte2.Location = new System.Drawing.Point(276, 36);
                        this.EntradaCtaCte2.Name = "EntradaCtaCte2";
                        this.EntradaCtaCte2.Prefijo = "$";
                        this.EntradaCtaCte2.ReadOnly = false;
                        this.EntradaCtaCte2.Size = new System.Drawing.Size(120, 24);
                        this.EntradaCtaCte2.TabIndex = 3;
                        this.EntradaCtaCte2.TabStop = false;
                        this.EntradaCtaCte2.Text = "0.00";
                        this.EntradaCtaCte2.TextChanged += new System.EventHandler(this.EntradaCtaCte1CtaCte2_TextChanged);
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(124, 36);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(152, 24);
                        this.label2.TabIndex = 2;
                        this.label2.Text = "Saldo registro 2";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaCtaCte1
                        // 
                        this.EntradaCtaCte1.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaCtaCte1.Location = new System.Drawing.Point(276, 8);
                        this.EntradaCtaCte1.Name = "EntradaCtaCte1";
                        this.EntradaCtaCte1.Prefijo = "$";
                        this.EntradaCtaCte1.ReadOnly = false;
                        this.EntradaCtaCte1.Size = new System.Drawing.Size(120, 24);
                        this.EntradaCtaCte1.TabIndex = 1;
                        this.EntradaCtaCte1.TabStop = false;
                        this.EntradaCtaCte1.Text = "0.00";
                        this.EntradaCtaCte1.TextChanged += new System.EventHandler(this.EntradaCtaCte1CtaCte2_TextChanged);
                        // 
                        // label1
                        // 
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
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label EtiquetaElemento1;
                internal Lcc.Entrada.CodigoDetalle EntradaElementoDuplicado;
                internal Lui.Forms.Label EtiquetaElemento2;
                internal Lcc.Entrada.CodigoDetalle EntradaElementoOriginal;
                internal Lui.Forms.ComboBox txtTipo;
                internal Lui.Forms.Label label3;
                private Lui.Forms.Note note1;
                private Lui.Forms.Panel PanelPersona;
                internal Lui.Forms.Label label1;
                private Lui.Forms.TextBox EntradaCtaCte2;
                internal Lui.Forms.Label label2;
                private Lui.Forms.TextBox EntradaCtaCte1;
                private Lui.Forms.TextBox EntradaCtaCteFinal;
                internal Lui.Forms.Label label4;
        }
}
