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

namespace Lazaro.WinMain.Misc
{
        public partial class CambioContrasena
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

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioContrasena));
                        this.EntradaContrasena = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.OkButton = new Lui.Forms.Button();
                        this.LowerPanel = new Lui.Forms.ButtonPanel();
                        this.panel1 = new Lui.Forms.Panel();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.label3 = new Lui.Forms.Label();
                        this.EntradaContrasenaNueva1 = new Lui.Forms.TextBox();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaContrasenaNueva2 = new Lui.Forms.TextBox();
                        this.label4 = new Lui.Forms.Label();
                        this.Titulo = new Lui.Forms.Label();
                        this.LowerPanel.SuspendLayout();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // EntradaContrasena
                        // 
                        this.EntradaContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContrasena.AutoNav = true;
                        this.EntradaContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasena.DecimalPlaces = -1;
                        this.EntradaContrasena.FieldName = null;
                        this.EntradaContrasena.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasena.Location = new System.Drawing.Point(312, 136);
                        this.EntradaContrasena.MultiLine = false;
                        this.EntradaContrasena.Name = "EntradaContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.PlaceholderText = null;
                        this.EntradaContrasena.Prefijo = "";
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.SelectOnFocus = true;
                        this.EntradaContrasena.Size = new System.Drawing.Size(176, 24);
                        this.EntradaContrasena.Sufijo = "";
                        this.EntradaContrasena.TabIndex = 3;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label2.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(152, 136);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(164, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Contraseña actual";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.CancelCommandButton.AutoNav = true;
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(414, 12);
                        this.CancelCommandButton.Margin = new System.Windows.Forms.Padding(0);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(108, 40);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "";
                        this.CancelCommandButton.TabIndex = 1;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
                        this.OkButton.AutoNav = true;
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(300, 12);
                        this.OkButton.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(108, 40);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "";
                        this.OkButton.TabIndex = 0;
                        this.OkButton.Text = "Cambiar";
                        this.OkButton.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Controls.Add(this.OkButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 248);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Padding = new System.Windows.Forms.Padding(12);
                        this.LowerPanel.Size = new System.Drawing.Size(546, 64);
                        this.LowerPanel.TabIndex = 8;
                        // 
                        // panel1
                        // 
                        this.panel1.BackColor = System.Drawing.Color.White;
                        this.panel1.Controls.Add(this.PictureBox1);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
                        this.panel1.Location = new System.Drawing.Point(0, 0);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(100, 248);
                        this.panel1.TabIndex = 53;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(20, 108);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(37, 120);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.PictureBox1.TabIndex = 51;
                        this.PictureBox1.TabStop = false;
                        // 
                        // label3
                        // 
                        this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label3.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label3.Location = new System.Drawing.Point(136, 68);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(380, 56);
                        this.label3.TabIndex = 1;
                        this.label3.Text = "Por favor escriba su Contraseña actual y a continuación escriba la Contraseña nue" +
    "va. Por su seguridad, debe escribir la contraseña nueva dos veces.";
                        // 
                        // EntradaContrasenaNueva1
                        // 
                        this.EntradaContrasenaNueva1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContrasenaNueva1.AutoNav = true;
                        this.EntradaContrasenaNueva1.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasenaNueva1.DecimalPlaces = -1;
                        this.EntradaContrasenaNueva1.FieldName = null;
                        this.EntradaContrasenaNueva1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasenaNueva1.Location = new System.Drawing.Point(312, 167);
                        this.EntradaContrasenaNueva1.MultiLine = false;
                        this.EntradaContrasenaNueva1.Name = "EntradaContrasenaNueva1";
                        this.EntradaContrasenaNueva1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasenaNueva1.PasswordChar = '*';
                        this.EntradaContrasenaNueva1.PlaceholderText = null;
                        this.EntradaContrasenaNueva1.Prefijo = "";
                        this.EntradaContrasenaNueva1.ReadOnly = false;
                        this.EntradaContrasenaNueva1.SelectOnFocus = true;
                        this.EntradaContrasenaNueva1.Size = new System.Drawing.Size(176, 24);
                        this.EntradaContrasenaNueva1.Sufijo = "";
                        this.EntradaContrasenaNueva1.TabIndex = 5;
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label1.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label1.Location = new System.Drawing.Point(152, 167);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(164, 24);
                        this.label1.TabIndex = 4;
                        this.label1.Text = "Contraseña nueva";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaContrasenaNueva2
                        // 
                        this.EntradaContrasenaNueva2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContrasenaNueva2.AutoNav = true;
                        this.EntradaContrasenaNueva2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasenaNueva2.DecimalPlaces = -1;
                        this.EntradaContrasenaNueva2.FieldName = null;
                        this.EntradaContrasenaNueva2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasenaNueva2.Location = new System.Drawing.Point(312, 196);
                        this.EntradaContrasenaNueva2.MultiLine = false;
                        this.EntradaContrasenaNueva2.Name = "EntradaContrasenaNueva2";
                        this.EntradaContrasenaNueva2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasenaNueva2.PasswordChar = '*';
                        this.EntradaContrasenaNueva2.PlaceholderText = null;
                        this.EntradaContrasenaNueva2.Prefijo = "";
                        this.EntradaContrasenaNueva2.ReadOnly = false;
                        this.EntradaContrasenaNueva2.SelectOnFocus = true;
                        this.EntradaContrasenaNueva2.Size = new System.Drawing.Size(176, 24);
                        this.EntradaContrasenaNueva2.Sufijo = "";
                        this.EntradaContrasenaNueva2.TabIndex = 7;
                        // 
                        // label4
                        // 
                        this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label4.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;
                        this.label4.Location = new System.Drawing.Point(152, 196);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(164, 24);
                        this.label4.TabIndex = 6;
                        this.label4.Text = "Repita contraseña ";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Titulo
                        // 
                        this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Titulo.LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        this.Titulo.Location = new System.Drawing.Point(136, 32);
                        this.Titulo.Name = "Titulo";
                        this.Titulo.Size = new System.Drawing.Size(380, 24);
                        this.Titulo.TabIndex = 0;
                        this.Titulo.Text = "Cambio de Contraseña";
                        this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // CambioContrasena
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(546, 312);
                        this.ControlBox = false;
                        this.Controls.Add(this.Titulo);
                        this.Controls.Add(this.EntradaContrasenaNueva2);
                        this.Controls.Add(this.EntradaContrasenaNueva1);
                        this.Controls.Add(this.EntradaContrasena);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.LowerPanel);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "CambioContrasena";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Cambio de Contraseña";
                        this.TopMost = true;
                        this.LowerPanel.ResumeLayout(false);
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                private Lui.Forms.Label Label2;
                private Lui.Forms.Button OkButton;
                private Lui.Forms.TextBox EntradaContrasena;
                private Lui.Forms.Button CancelCommandButton;
                private Lui.Forms.ButtonPanel LowerPanel;
                private Lui.Forms.Panel panel1;
                private System.Windows.Forms.PictureBox PictureBox1;
                private Lui.Forms.Label label3;
                private Lui.Forms.TextBox EntradaContrasenaNueva1;
                private Lui.Forms.Label label1;
                private Lui.Forms.TextBox EntradaContrasenaNueva2;
                private Lui.Forms.Label label4;
                private Lui.Forms.Label Titulo;
        }
}
