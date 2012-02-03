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

namespace Lfc.Cajas.Vencimientos
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
                        this.Label11 = new Lui.Forms.Label();
                        this.EntradaNombre = new Lui.Forms.TextBox();
                        this.lblLabel1 = new Lui.Forms.Label();
                        this.frame1 = new Lui.Forms.Frame();
                        this.label1 = new Lui.Forms.Label();
                        this.label4 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaFechaInicio = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaFechaFin = new Lui.Forms.TextBox();
                        this.EntradaRepetir = new Lui.Forms.TextBox();
                        this.label5 = new Lui.Forms.Label();
                        this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
                        this.frame2 = new Lui.Forms.Frame();
                        this.label6 = new Lui.Forms.Label();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.label7 = new Lui.Forms.Label();
                        this.EntradaEstado = new Lui.Forms.ComboBox();
                        this.EntradaObs = new Lui.Forms.TextBox();
                        this.label8 = new Lui.Forms.Label();
                        this.frame1.SuspendLayout();
                        this.frame2.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaFrecuencia
                        // 
                        this.EntradaFrecuencia.AlwaysExpanded = true;
                        this.EntradaFrecuencia.AutoNav = true;
                        this.EntradaFrecuencia.FieldName = null;
                        this.EntradaFrecuencia.Location = new System.Drawing.Point(96, 76);
                        this.EntradaFrecuencia.Name = "EntradaFrecuencia";
                        this.EntradaFrecuencia.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFrecuencia.PlaceholderText = null;
                        this.EntradaFrecuencia.ReadOnly = false;
                        this.EntradaFrecuencia.SetData = new string[] {
        "Única|Unica",
        "Diaria|Diaria",
        "Semanal|Semanal",
        "Mensual|Mensual",
        "Bimestral|Bimestral",
        "Trimestral|Trimestral",
        "Cuatrimestral|Cuatrimestral",
        "Semestral|Semestral",
        "Anual|Anual"};
                        this.EntradaFrecuencia.Size = new System.Drawing.Size(176, 112);
                        this.EntradaFrecuencia.TabIndex = 3;
                        this.EntradaFrecuencia.TextKey = "";
                        // 
                        // Label11
                        // 
                        this.Label11.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label11.Location = new System.Drawing.Point(8, 76);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(88, 24);
                        this.Label11.TabIndex = 2;
                        this.Label11.Text = "Frecuencia";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaNombre
                        // 
                        this.EntradaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaNombre.AutoNav = true;
                        this.EntradaNombre.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNombre.DecimalPlaces = -1;
                        this.EntradaNombre.FieldName = null;
                        this.EntradaNombre.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaNombre.Location = new System.Drawing.Point(96, 0);
                        this.EntradaNombre.MultiLine = false;
                        this.EntradaNombre.Name = "EntradaNombre";
                        this.EntradaNombre.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNombre.PasswordChar = '\0';
                        this.EntradaNombre.PlaceholderText = null;
                        this.EntradaNombre.Prefijo = "";
                        this.EntradaNombre.ReadOnly = false;
                        this.EntradaNombre.SelectOnFocus = false;
                        this.EntradaNombre.Size = new System.Drawing.Size(540, 24);
                        this.EntradaNombre.Sufijo = "";
                        this.EntradaNombre.TabIndex = 1;
                        // 
                        // lblLabel1
                        // 
                        this.lblLabel1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.lblLabel1.Location = new System.Drawing.Point(0, 0);
                        this.lblLabel1.Name = "lblLabel1";
                        this.lblLabel1.Size = new System.Drawing.Size(96, 24);
                        this.lblLabel1.TabIndex = 0;
                        this.lblLabel1.Text = "Nombre";
                        this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // frame1
                        // 
                        this.frame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame1.Controls.Add(this.label4);
                        this.frame1.Controls.Add(this.label1);
                        this.frame1.Controls.Add(this.label2);
                        this.frame1.Controls.Add(this.EntradaFrecuencia);
                        this.frame1.Controls.Add(this.EntradaFechaInicio);
                        this.frame1.Controls.Add(this.Label11);
                        this.frame1.Controls.Add(this.label3);
                        this.frame1.Controls.Add(this.EntradaFechaFin);
                        this.frame1.Controls.Add(this.EntradaRepetir);
                        this.frame1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame1.Location = new System.Drawing.Point(0, 244);
                        this.frame1.Name = "frame1";
                        this.frame1.Padding = new System.Windows.Forms.Padding(2);
                        this.frame1.Size = new System.Drawing.Size(640, 196);
                        this.frame1.TabIndex = 7;
                        this.frame1.Text = "Periodicidad";
                        // 
                        // label1
                        // 
                        this.label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label1.Location = new System.Drawing.Point(8, 40);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(88, 24);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "Inicio";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label4
                        // 
                        this.label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label4.Location = new System.Drawing.Point(476, 68);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(72, 24);
                        this.label4.TabIndex = 8;
                        this.label4.Text = "veces";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label2
                        // 
                        this.label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label2.Location = new System.Drawing.Point(312, 40);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(96, 24);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "Fin";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaInicio
                        // 
                        this.EntradaFechaInicio.AutoNav = true;
                        this.EntradaFechaInicio.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaInicio.DecimalPlaces = -1;
                        this.EntradaFechaInicio.FieldName = null;
                        this.EntradaFechaInicio.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaInicio.Location = new System.Drawing.Point(96, 40);
                        this.EntradaFechaInicio.MultiLine = false;
                        this.EntradaFechaInicio.Name = "EntradaFechaInicio";
                        this.EntradaFechaInicio.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaInicio.PasswordChar = '\0';
                        this.EntradaFechaInicio.PlaceholderText = null;
                        this.EntradaFechaInicio.Prefijo = "";
                        this.EntradaFechaInicio.ReadOnly = false;
                        this.EntradaFechaInicio.SelectOnFocus = true;
                        this.EntradaFechaInicio.Size = new System.Drawing.Size(100, 24);
                        this.EntradaFechaInicio.Sufijo = "";
                        this.EntradaFechaInicio.TabIndex = 1;
                        // 
                        // label3
                        // 
                        this.label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label3.Location = new System.Drawing.Point(312, 68);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(96, 24);
                        this.label3.TabIndex = 6;
                        this.label3.Text = "O repetir";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFechaFin
                        // 
                        this.EntradaFechaFin.AutoNav = true;
                        this.EntradaFechaFin.DataType = Lui.Forms.DataTypes.Date;
                        this.EntradaFechaFin.DecimalPlaces = -1;
                        this.EntradaFechaFin.FieldName = null;
                        this.EntradaFechaFin.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFechaFin.Location = new System.Drawing.Point(408, 40);
                        this.EntradaFechaFin.MultiLine = false;
                        this.EntradaFechaFin.Name = "EntradaFechaFin";
                        this.EntradaFechaFin.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFechaFin.PasswordChar = '\0';
                        this.EntradaFechaFin.PlaceholderText = null;
                        this.EntradaFechaFin.Prefijo = "";
                        this.EntradaFechaFin.ReadOnly = false;
                        this.EntradaFechaFin.SelectOnFocus = true;
                        this.EntradaFechaFin.Size = new System.Drawing.Size(104, 24);
                        this.EntradaFechaFin.Sufijo = "";
                        this.EntradaFechaFin.TabIndex = 5;
                        // 
                        // EntradaRepetir
                        // 
                        this.EntradaRepetir.AutoNav = true;
                        this.EntradaRepetir.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaRepetir.DecimalPlaces = -1;
                        this.EntradaRepetir.FieldName = null;
                        this.EntradaRepetir.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaRepetir.Location = new System.Drawing.Point(408, 68);
                        this.EntradaRepetir.MultiLine = false;
                        this.EntradaRepetir.Name = "EntradaRepetir";
                        this.EntradaRepetir.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRepetir.PasswordChar = '\0';
                        this.EntradaRepetir.PlaceholderText = null;
                        this.EntradaRepetir.Prefijo = "";
                        this.EntradaRepetir.ReadOnly = false;
                        this.EntradaRepetir.SelectOnFocus = true;
                        this.EntradaRepetir.Size = new System.Drawing.Size(68, 24);
                        this.EntradaRepetir.Sufijo = "";
                        this.EntradaRepetir.TabIndex = 7;
                        this.EntradaRepetir.Text = "0";
                        // 
                        // label5
                        // 
                        this.label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label5.Location = new System.Drawing.Point(8, 36);
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
                        this.EntradaConcepto.AutoNav = true;
                        this.EntradaConcepto.AutoTab = true;
                        this.EntradaConcepto.CanCreate = true;
                        this.EntradaConcepto.DataTextField = "nombre";
                        this.EntradaConcepto.DataValueField = "id_concepto";
                        this.EntradaConcepto.ExtraDetailFields = "";
                        this.EntradaConcepto.FieldName = null;
                        this.EntradaConcepto.Filter = "";
                        this.EntradaConcepto.FreeTextCode = "";
                        this.EntradaConcepto.Location = new System.Drawing.Point(96, 36);
                        this.EntradaConcepto.MaxLength = 200;
                        this.EntradaConcepto.Name = "EntradaConcepto";
                        this.EntradaConcepto.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConcepto.PlaceholderText = null;
                        this.EntradaConcepto.ReadOnly = false;
                        this.EntradaConcepto.Required = true;
                        this.EntradaConcepto.Size = new System.Drawing.Size(536, 24);
                        this.EntradaConcepto.TabIndex = 1;
                        this.EntradaConcepto.Table = "conceptos";
                        this.EntradaConcepto.Text = "0";
                        this.EntradaConcepto.TextDetail = "";
                        // 
                        // frame2
                        // 
                        this.frame2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.frame2.Controls.Add(this.label5);
                        this.frame2.Controls.Add(this.EntradaConcepto);
                        this.frame2.Controls.Add(this.label6);
                        this.frame2.Controls.Add(this.EntradaImporte);
                        this.frame2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.frame2.Location = new System.Drawing.Point(0, 132);
                        this.frame2.Name = "frame2";
                        this.frame2.Padding = new System.Windows.Forms.Padding(2);
                        this.frame2.Size = new System.Drawing.Size(640, 96);
                        this.frame2.TabIndex = 6;
                        this.frame2.Text = "Pago";
                        // 
                        // label6
                        // 
                        this.label6.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label6.Location = new System.Drawing.Point(8, 68);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(84, 24);
                        this.label6.TabIndex = 2;
                        this.label6.Text = "Importe";
                        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.FieldName = null;
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.Location = new System.Drawing.Point(96, 68);
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.PasswordChar = '\0';
                        this.EntradaImporte.PlaceholderText = null;
                        this.EntradaImporte.Prefijo = "";
                        this.EntradaImporte.ReadOnly = false;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(100, 24);
                        this.EntradaImporte.Sufijo = "";
                        this.EntradaImporte.TabIndex = 3;
                        this.EntradaImporte.Text = "0.00";
                        // 
                        // label7
                        // 
                        this.label7.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label7.Location = new System.Drawing.Point(0, 32);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(96, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Estado";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaEstado
                        // 
                        this.EntradaEstado.AlwaysExpanded = false;
                        this.EntradaEstado.AutoNav = true;
                        this.EntradaEstado.FieldName = null;
                        this.EntradaEstado.Location = new System.Drawing.Point(96, 32);
                        this.EntradaEstado.Name = "EntradaEstado";
                        this.EntradaEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaEstado.PlaceholderText = null;
                        this.EntradaEstado.ReadOnly = false;
                        this.EntradaEstado.SetData = new string[] {
        "Inactivo|0",
        "Activo|1",
        "Terminado|100"};
                        this.EntradaEstado.Size = new System.Drawing.Size(168, 24);
                        this.EntradaEstado.TabIndex = 3;
                        this.EntradaEstado.TextKey = "1";
                        // 
                        // EntradaObs
                        // 
                        this.EntradaObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaObs.AutoNav = true;
                        this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaObs.DecimalPlaces = -1;
                        this.EntradaObs.FieldName = null;
                        this.EntradaObs.ForceCase = Lui.Forms.TextCasing.Automatic;
                        this.EntradaObs.Location = new System.Drawing.Point(96, 64);
                        this.EntradaObs.MultiLine = true;
                        this.EntradaObs.Name = "EntradaObs";
                        this.EntradaObs.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaObs.PasswordChar = '\0';
                        this.EntradaObs.PlaceholderText = null;
                        this.EntradaObs.Prefijo = "";
                        this.EntradaObs.ReadOnly = false;
                        this.EntradaObs.SelectOnFocus = false;
                        this.EntradaObs.Size = new System.Drawing.Size(540, 56);
                        this.EntradaObs.Sufijo = "";
                        this.EntradaObs.TabIndex = 5;
                        // 
                        // label8
                        // 
                        this.label8.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label8.Location = new System.Drawing.Point(0, 64);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(96, 24);
                        this.label8.TabIndex = 4;
                        this.label8.Text = "Obs.";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.EntradaObs);
                        this.Controls.Add(this.EntradaEstado);
                        this.Controls.Add(this.frame2);
                        this.Controls.Add(this.frame1);
                        this.Controls.Add(this.EntradaNombre);
                        this.Controls.Add(this.lblLabel1);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label7);
                        this.Name = "Editar";
                        this.Size = new System.Drawing.Size(640, 447);
                        this.frame1.ResumeLayout(false);
                        this.frame1.PerformLayout();
                        this.frame2.ResumeLayout(false);
                        this.frame2.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.ComboBox EntradaFrecuencia;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.TextBox EntradaNombre;
                internal Lui.Forms.Label lblLabel1;
                private Lui.Forms.Frame frame1;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.TextBox EntradaFechaInicio;
                internal Lui.Forms.Label label3;
                internal Lui.Forms.TextBox EntradaRepetir;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.TextBox EntradaFechaFin;
                private Lui.Forms.Label label5;
                internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
                private Lui.Forms.Frame frame2;
                internal Lui.Forms.Label label6;
                internal Lui.Forms.TextBox EntradaImporte;
                internal Lui.Forms.Label label7;
                internal Lui.Forms.ComboBox EntradaEstado;
                internal Lui.Forms.TextBox EntradaObs;
                internal Lui.Forms.Label label8;
                internal Lui.Forms.Label label4;
        }
}
