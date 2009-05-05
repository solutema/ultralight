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

namespace Lfc.Cuentas.Vencimientos
{
        partial class Editar
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
                        this.EntradaFrecuencia = new Lui.Forms.ComboBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.lblLabel1 = new System.Windows.Forms.Label();
                        this.frame1 = new Lui.Forms.Frame();
                        this.label3 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaFechaFin = new Lui.Forms.TextBox();
                        this.EntradaRepetir = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaFechaInicio = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaConcepto = new Lui.Forms.DetailBox();
                        this.frame2 = new Lui.Forms.Frame();
                        this.label6 = new System.Windows.Forms.Label();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.frame1.SuspendLayout();
                        this.frame2.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.Location = new System.Drawing.Point(568, 10);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(680, 10);
                        // 
                        // EntradaFrecuencia
                        // 
                        this.EntradaFrecuencia.AutoNav = true;
                        this.EntradaFrecuencia.AutoTab = true;
                        this.EntradaFrecuencia.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFrecuencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFrecuencia.Location = new System.Drawing.Point(96, 68);
                        this.EntradaFrecuencia.MaxLenght = 32767;
                        this.EntradaFrecuencia.Name = "EntradaFrecuencia";
                        this.EntradaFrecuencia.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFrecuencia.ReadOnly = false;
                        this.EntradaFrecuencia.SetData = new string[] {
        "Única|unica",
        "Diaria|diaria",
        "Semanal|semanal",
        "Mensual|Mensual",
        "Bimestral|bimestral",
        "Trimestral|trimestral",
        "Cuatrimestral|Cuatrimestral",
        "Semestral|semestral",
        "Anual|Anual"};
                        this.EntradaFrecuencia.Size = new System.Drawing.Size(176, 24);
                        this.EntradaFrecuencia.TabIndex = 3;
                        this.EntradaFrecuencia.Text = "Semestral";
                        this.EntradaFrecuencia.TextKey = "semestral";
                        this.EntradaFrecuencia.TipWhenBlank = "";
                        this.EntradaFrecuencia.ToolTipText = "";
                        // 
                        // Label11
                        // 
                        this.Label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label11.Location = new System.Drawing.Point(12, 68);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(80, 24);
                        this.Label11.TabIndex = 2;
                        this.Label11.Text = "Frecuencia";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.AutoTab = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaNombre.Location = new System.Drawing.Point(100, 20);
                        this.EntradaNombre.MaxLenght = 32767;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(676, 24);
                        this.EntradaNombre.TabIndex = 1;
                        this.EntradaNombre.TipWhenBlank = "";
                        this.EntradaNombre.ToolTipText = "";
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblLabel1.Location = new System.Drawing.Point(20, 20);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(76, 24);
                        this.lblLabel1.TabIndex = 0;
                        this.lblLabel1.Text = "Nombre";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // frame1
                        // 
                        this.frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame1.Controls.Add(this.label3);
                        this.frame1.Controls.Add(this.label2);
                        this.frame1.Controls.Add(this.label4);
                        this.frame1.Controls.Add(this.EntradaFechaFin);
                        this.frame1.Controls.Add(this.EntradaRepetir);
                        this.frame1.Controls.Add(this.label1);
                        this.frame1.Controls.Add(this.EntradaFechaInicio);
                        this.frame1.Controls.Add(this.Label11);
                        this.frame1.Controls.Add(this.EntradaFrecuencia);
                        this.frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame1.Location = new System.Drawing.Point(20, 264);
                        this.frame1.Name = "frame1";
                        this.frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.frame1.ReadOnly = false;
                        this.frame1.Size = new System.Drawing.Size(756, 136);
                        this.frame1.TabIndex = 7;
                        this.frame1.Text = "Periodicidad";
                        this.frame1.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label3.Location = new System.Drawing.Point(204, 100);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(68, 24);
                        this.label3.TabIndex = 6;
                        this.label3.Text = "o repetir";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(12, 100);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(80, 24);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Fin";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label4
                        // 
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label4.Location = new System.Drawing.Point(344, 100);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(72, 24);
                        this.label4.TabIndex = 8;
                        this.label4.Text = "veces";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaFin
                        // 
                        this.EntradaFechaFin.AutoNav = true;
                        this.EntradaFechaFin.AutoTab = true;
                        this.EntradaFechaFin.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaFin.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaFin.Location = new System.Drawing.Point(96, 100);
                        this.EntradaFechaFin.MaxLenght = 32767;
                        this.EntradaFechaFin.Name = "EntradaFechaFin";
                        this.EntradaFechaFin.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaFin.ReadOnly = false;
                        this.EntradaFechaFin.Size = new System.Drawing.Size(100, 24);
                        this.EntradaFechaFin.TabIndex = 5;
                        this.EntradaFechaFin.TipWhenBlank = "";
                        this.EntradaFechaFin.ToolTipText = "";
                        // 
                        // EntradaRepetir
                        // 
                        this.EntradaRepetir.AutoNav = true;
                        this.EntradaRepetir.AutoTab = true;
                        this.EntradaRepetir.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaRepetir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaRepetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaRepetir.Location = new System.Drawing.Point(276, 100);
                        this.EntradaRepetir.MaxLenght = 32767;
                        this.EntradaRepetir.Name = "EntradaRepetir";
                        this.EntradaRepetir.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRepetir.ReadOnly = false;
                        this.EntradaRepetir.Size = new System.Drawing.Size(64, 24);
                        this.EntradaRepetir.TabIndex = 7;
                        this.EntradaRepetir.Text = "0";
                        this.EntradaRepetir.TipWhenBlank = "";
                        this.EntradaRepetir.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(12, 32);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(80, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Inicio";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaInicio
                        // 
                        this.EntradaFechaInicio.AutoNav = true;
                        this.EntradaFechaInicio.AutoTab = true;
                        this.EntradaFechaInicio.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaInicio.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaFechaInicio.Location = new System.Drawing.Point(96, 32);
                        this.EntradaFechaInicio.MaxLenght = 32767;
                        this.EntradaFechaInicio.Name = "EntradaFechaInicio";
                        this.EntradaFechaInicio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaInicio.ReadOnly = false;
                        this.EntradaFechaInicio.Size = new System.Drawing.Size(100, 24);
                        this.EntradaFechaInicio.TabIndex = 1;
                        this.EntradaFechaInicio.TipWhenBlank = "";
                        this.EntradaFechaInicio.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(8, 32);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(84, 24);
                        this.label5.TabIndex = 0;
                        this.label5.Text = "Concepto";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaConcepto
                        // 
                        this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.DetailField = "nombre";
                        this.EntradaConcepto.ExtraDetailFields = null;
                        this.EntradaConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConcepto.FreeTextCode = "";
                        this.EntradaConcepto.KeyField = "id_concepto";
                        this.EntradaConcepto.Location = new System.Drawing.Point(96, 32);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.ReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.SelectOnFocus = false;
                        this.EntradaConcepto.Size = new System.Drawing.Size(652, 24);
                        this.EntradaConcepto.TabIndex = 1;
                        this.EntradaConcepto.Table = "cuentas_conceptos";
                        this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        this.EntradaConcepto.TextInt = 0;
                        this.EntradaConcepto.TipWhenBlank = "";
                        this.EntradaConcepto.ToolTipText = "";
                        // 
                        // frame2
                        // 
                        this.frame2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame2.Controls.Add(this.label5);
                        this.frame2.Controls.Add(this.label6);
                        this.frame2.Controls.Add(this.EntradaImporte);
                        this.frame2.Controls.Add(this.EntradaConcepto);
                        this.frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame2.Location = new System.Drawing.Point(20, 152);
                        this.frame2.Name = "frame2";
                        this.frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.frame2.ReadOnly = false;
                        this.frame2.Size = new System.Drawing.Size(756, 96);
                        this.frame2.TabIndex = 6;
                        this.frame2.Text = "Pago";
                        this.frame2.ToolTipText = "";
                        // 
                        // label6
                        // 
                        this.label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label6.Location = new System.Drawing.Point(8, 64);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(84, 24);
                        this.label6.TabIndex = 2;
                        this.label6.Text = "Importe";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaImporte.Location = new System.Drawing.Point(96, 64);
                        this.EntradaImporte.MaxLenght = 32767;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.ReadOnly = false;
                        this.EntradaImporte.Size = new System.Drawing.Size(100, 24);
                        this.EntradaImporte.TabIndex = 3;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TipWhenBlank = "";
                        this.EntradaImporte.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label7.Location = new System.Drawing.Point(20, 52);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(76, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Estado";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.AutoTab = true;
                        this.EntradaEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaEstado.Location = new System.Drawing.Point(100, 52);
                        this.EntradaEstado.MaxLenght = 32767;
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Inactivo|0",
        "Activo|1",
        "Terminado|100"};
                        this.EntradaEstado.Size = new System.Drawing.Size(176, 24);
                        this.EntradaEstado.TabIndex = 3;
                        this.EntradaEstado.Text = "Activo";
                        this.EntradaEstado.TextKey = "1";
                        this.EntradaEstado.TipWhenBlank = "";
                        this.EntradaEstado.ToolTipText = "";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.AutoTab = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaObs.Location = new System.Drawing.Point(100, 84);
                        this.EntradaObs.MaxLenght = 32767;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(676, 56);
                        this.EntradaObs.TabIndex = 5;
                        this.EntradaObs.TipWhenBlank = "";
                        this.EntradaObs.ToolTipText = "";
                        // 
                        // label8
                        // 
                        this.label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label8.Location = new System.Drawing.Point(20, 84);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(76, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Obs";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(792, 473);
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.frame2);
                        this.Controls.Add(this.frame1);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.lblLabel1);
                        this.Name = "Editar";
                        this.Text = "Vencimiento";
                        this.Controls.SetChildIndex(this.lblLabel1, 0);
                        this.Controls.SetChildIndex(this.EntradaNombre, 0);
                        this.Controls.SetChildIndex(this.frame1, 0);
                        this.Controls.SetChildIndex(this.frame2, 0);
                        this.Controls.SetChildIndex(this.EntradaEstado, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.label8, 0);
                        this.Controls.SetChildIndex(this.EntradaObs, 0);
                        this.frame1.ResumeLayout(false);
                        this.frame1.PerformLayout();
                        this.frame2.ResumeLayout(false);
                        this.frame2.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.ComboBox EntradaFrecuencia;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.TextBox EntradaNombre;
                internal System.Windows.Forms.Label lblLabel1;
                private Lui.Forms.Frame frame1;
                internal System.Windows.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaFechaInicio;
                internal System.Windows.Forms.Label label4;
                internal System.Windows.Forms.Label label3;
                internal Lui.Forms.TextBox EntradaRepetir;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaFin;
                private System.Windows.Forms.Label label5;
                internal Lui.Forms.DetailBox EntradaConcepto;
                private Lui.Forms.Frame frame2;
                internal System.Windows.Forms.Label label6;
                internal Lui.Forms.TextBox EntradaImporte;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal Lui.Forms.TextBox EntradaObs;
                internal System.Windows.Forms.Label label8;
        }
}