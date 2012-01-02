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

namespace Lfc.Comprobantes.Facturas
{
        partial class SaldoEnCuentaCorriente
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
                        this.label2 = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.BotonCancelar = new Lui.Forms.Button();
                        this.BotonContinuar = new Lui.Forms.Button();
                        this.BotonCorregir = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(20, 52);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(592, 40);
                        this.label2.TabIndex = 1;
                        this.label2.Text = "El cliente registra un saldo a favor en su cuenta corriente, suficiente para cubr" +
                            "ir el total de la factura que va a imprimir. ¿Desea imprimir esta factura en cue" +
                            "nta corriente?";
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(20, 24);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(592, 28);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Posible Error en la Forma de Pago";
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCancelar.AutoSize = false;
                        this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCancelar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCancelar.Location = new System.Drawing.Point(20, 288);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCancelar.TemporaryReadOnly = false;
                        this.BotonCancelar.Size = new System.Drawing.Size(592, 68);
                        this.BotonCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonCancelar.Subtext = "No imprime la factura. Sólo vuelve al formulario anterior para continuar con lo q" +
                            "ue estaba haciendo.";
                        this.BotonCancelar.TabIndex = 4;
                        this.BotonCancelar.Text = "Volver al formulario anterior";
                        this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // BotonContinuar
                        // 
                        this.BotonContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonContinuar.AutoSize = false;
                        this.BotonContinuar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonContinuar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonContinuar.Location = new System.Drawing.Point(20, 212);
                        this.BotonContinuar.Name = "BotonContinuar";
                        this.BotonContinuar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonContinuar.TemporaryReadOnly = false;
                        this.BotonContinuar.Size = new System.Drawing.Size(592, 68);
                        this.BotonContinuar.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonContinuar.Subtext = "Los pagos ingresados con anterioridad no corresponden a esta factura. El saldo en" +
                            " la cuenta corriente del clienteno se modifica, y deberá informar un pago para e" +
                            "sta factura.";
                        this.BotonContinuar.TabIndex = 3;
                        this.BotonContinuar.Text = "Imprimir la Factura con un pago separado";
                        this.BotonContinuar.Click += new System.EventHandler(this.BotonContinuar_Click);
                        // 
                        // BotonCorregir
                        // 
                        this.BotonCorregir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCorregir.AutoSize = false;
                        this.BotonCorregir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCorregir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCorregir.Location = new System.Drawing.Point(20, 136);
                        this.BotonCorregir.Name = "BotonCorregir";
                        this.BotonCorregir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCorregir.TemporaryReadOnly = false;
                        this.BotonCorregir.Size = new System.Drawing.Size(592, 68);
                        this.BotonCorregir.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonCorregir.Subtext = "Seleccione esta opción si los pagos ingresados con anterioridad corresponden a es" +
                            "ta factura. No será necesario informar más pagos para esta factura.";
                        this.BotonCorregir.TabIndex = 2;
                        this.BotonCorregir.Text = "Imprimir la Factura en Cuenta Corriente";
                        this.BotonCorregir.Click += new System.EventHandler(this.BotonCorregir_Click);
                        // 
                        // SaldoEnCuentaCorriente
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(634, 376);
                        this.Controls.Add(this.BotonCancelar);
                        this.Controls.Add(this.BotonContinuar);
                        this.Controls.Add(this.BotonCorregir);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        this.Name = "SaldoEnCuentaCorriente";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Cliente con Saldo a Favor en Cuenta Corriente";
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.Label label2;
                private Lui.Forms.Label label1;
                private Lui.Forms.Button BotonCancelar;
                private Lui.Forms.Button BotonContinuar;
                private Lui.Forms.Button BotonCorregir;
        }
}
