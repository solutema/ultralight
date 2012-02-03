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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.WinMain.Backup
{
        public partial class Restore
        {
                public Restore()
                {
                        InitializeComponent();
                }

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

                private System.ComponentModel.IContainer components = null;

                internal System.Windows.Forms.PictureBox pctExclamation;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label lblFecha;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaConfirmar;
                internal System.Windows.Forms.PictureBox PictureBox1;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restore));
                        this.pctExclamation = new System.Windows.Forms.PictureBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.lblFecha = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaConfirmar = new Lui.Forms.TextBox();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.pctExclamation)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(354, 8);
                        this.OkButton.Visible = false;
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(474, 8);
                        // 
                        // pctExclamation
                        // 
                        this.pctExclamation.Image = ((System.Drawing.Image)(resources.GetObject("pctExclamation.Image")));
                        this.pctExclamation.Location = new System.Drawing.Point(80, 84);
                        this.pctExclamation.Name = "pctExclamation";
                        this.pctExclamation.Size = new System.Drawing.Size(56, 56);
                        this.pctExclamation.TabIndex = 56;
                        this.pctExclamation.TabStop = false;
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        this.Label1.Location = new System.Drawing.Point(80, 20);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(496, 20);
                        this.Label1.TabIndex = 57;
                        this.Label1.Text = "Restaurar Copia de Seguridad";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(80, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(112, 20);
                        this.Label2.TabIndex = 58;
                        this.Label2.Text = "ATENCIÓN!";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(144, 88);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(436, 44);
                        this.Label3.TabIndex = 59;
                        this.Label3.Text = "Si continúa con esta acción, llevará el estado del sistema completo atrás en el t" +
    "iempo al:";
                        // 
                        // lblFecha
                        // 
                        this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblFecha.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Big;
                        this.lblFecha.Location = new System.Drawing.Point(336, 132);
                        this.lblFecha.Name = "lblFecha";
                        this.lblFecha.Size = new System.Drawing.Size(244, 28);
                        this.lblFecha.TabIndex = 60;
                        this.lblFecha.Text = "01-01-2001 a las 00:00:00";
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(80, 176);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(500, 52);
                        this.Label4.TabIndex = 61;
                        this.Label4.Text = "Lea atentamente la sección \"Restaurar Copia de Seguridad\" en el \"Manual del Admin" +
    "istrador\" y asegúrese de comprender las implicaciones de la acción que está a pu" +
    "nto de realizar.";
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label5.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(80, 240);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(500, 24);
                        this.Label5.TabIndex = 62;
                        this.Label5.Text = "Para continuar con el proceso, escriba \"si\" en el cuadro:";
                        // 
                        // EntradaConfirmar
                        // 
                        this.EntradaConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConfirmar.AutoNav = true;
                        this.EntradaConfirmar.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaConfirmar.DecimalPlaces = -1;
                        this.EntradaConfirmar.FieldName = null;
                        this.EntradaConfirmar.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaConfirmar.Location = new System.Drawing.Point(500, 264);
                        this.EntradaConfirmar.MaxLength = 32767;
                        this.EntradaConfirmar.MultiLine = false;
                        this.EntradaConfirmar.Name = "EntradaConfirmar";
                        this.EntradaConfirmar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConfirmar.PasswordChar = '\0';
                        this.EntradaConfirmar.PlaceholderText = "Escriba el texto de confirmación para poder continuar";
                        this.EntradaConfirmar.Prefijo = "";
                        this.EntradaConfirmar.ReadOnly = false;
                        this.EntradaConfirmar.SelectOnFocus = true;
                        this.EntradaConfirmar.Size = new System.Drawing.Size(80, 24);
                        this.EntradaConfirmar.Sufijo = "";
                        this.EntradaConfirmar.TabIndex = 0;
                        this.EntradaConfirmar.TextChanged += new System.EventHandler(this.EntradaConfirmar_TextChanged);
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(16, 16);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(48, 68);
                        this.PictureBox1.TabIndex = 63;
                        this.PictureBox1.TabStop = false;
                        // 
                        // Restore
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(594, 372);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.EntradaConfirmar);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.lblFecha);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.pctExclamation);
                        this.Name = "Restore";
                        this.Text = "Restaurar Copia de Seguridad";
                        this.Controls.SetChildIndex(this.pctExclamation, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.lblFecha, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.EntradaConfirmar, 0);
                        this.Controls.SetChildIndex(this.PictureBox1, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.pctExclamation)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion
        }
}
