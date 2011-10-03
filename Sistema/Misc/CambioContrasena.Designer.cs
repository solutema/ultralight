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
using System.Text;

namespace Lazaro.Misc
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
                        this.Label2 = new System.Windows.Forms.Label();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.OkButton = new Lui.Forms.Button();
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.EntradaContrasenaNueva1 = new Lui.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.EntradaContrasenaNueva2 = new Lui.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.Titulo = new Lui.Forms.LabelH1();
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
                        this.EntradaContrasena.AutoTab = true;
                        this.EntradaContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasena.DecimalPlaces = -1;
                        this.EntradaContrasena.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContrasena.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContrasena.Location = new System.Drawing.Point(312, 136);
                        this.EntradaContrasena.MaxLenght = 32767;
                        this.EntradaContrasena.MultiLine = false;
                        this.EntradaContrasena.Name = "EntradaContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.PlaceholderText = "";
                        this.EntradaContrasena.Prefijo = "";
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.SelectOnFocus = true;
                        this.EntradaContrasena.Size = new System.Drawing.Size(176, 24);
                        this.EntradaContrasena.Sufijo = "";
                        this.EntradaContrasena.TabIndex = 1;
                        this.EntradaContrasena.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Label2.Location = new System.Drawing.Point(152, 136);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(164, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Contraseña actual";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(424, 16);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(108, 32);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "";
                        this.CancelCommandButton.TabIndex = 8;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Enabled = true;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(304, 16);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(108, 32);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "";
                        this.OkButton.TabIndex = 7;
                        this.OkButton.Text = "Cambiar";
                        this.OkButton.ToolTipText = "";
                        this.OkButton.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.OkButton);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 248);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(546, 64);
                        this.LowerPanel.TabIndex = 12;
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
                        this.label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label3.Location = new System.Drawing.Point(136, 72);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(380, 56);
                        this.label3.TabIndex = 54;
                        this.label3.Text = "Por favor escriba su Contraseña actual y a continuación escriba la Contraseña nue" +
    "va. Por su seguridad, debe escribir la contraseña nueva dos veces.";
                        // 
                        // EntradaContrasenaNueva1
                        // 
                        this.EntradaContrasenaNueva1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContrasenaNueva1.AutoNav = true;
                        this.EntradaContrasenaNueva1.AutoTab = true;
                        this.EntradaContrasenaNueva1.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasenaNueva1.DecimalPlaces = -1;
                        this.EntradaContrasenaNueva1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContrasenaNueva1.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasenaNueva1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContrasenaNueva1.Location = new System.Drawing.Point(312, 167);
                        this.EntradaContrasenaNueva1.MaxLenght = 32767;
                        this.EntradaContrasenaNueva1.MultiLine = false;
                        this.EntradaContrasenaNueva1.Name = "EntradaContrasenaNueva1";
                        this.EntradaContrasenaNueva1.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasenaNueva1.PasswordChar = '*';
                        this.EntradaContrasenaNueva1.PlaceholderText = "";
                        this.EntradaContrasenaNueva1.Prefijo = "";
                        this.EntradaContrasenaNueva1.ReadOnly = false;
                        this.EntradaContrasenaNueva1.SelectOnFocus = true;
                        this.EntradaContrasenaNueva1.Size = new System.Drawing.Size(176, 24);
                        this.EntradaContrasenaNueva1.Sufijo = "";
                        this.EntradaContrasenaNueva1.TabIndex = 3;
                        this.EntradaContrasenaNueva1.ToolTipText = "";
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.label1.Location = new System.Drawing.Point(152, 167);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(164, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Contraseña nueva";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaContrasenaNueva2
                        // 
                        this.EntradaContrasenaNueva2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContrasenaNueva2.AutoNav = true;
                        this.EntradaContrasenaNueva2.AutoTab = true;
                        this.EntradaContrasenaNueva2.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasenaNueva2.DecimalPlaces = -1;
                        this.EntradaContrasenaNueva2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContrasenaNueva2.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasenaNueva2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContrasenaNueva2.Location = new System.Drawing.Point(312, 196);
                        this.EntradaContrasenaNueva2.MaxLenght = 32767;
                        this.EntradaContrasenaNueva2.MultiLine = false;
                        this.EntradaContrasenaNueva2.Name = "EntradaContrasenaNueva2";
                        this.EntradaContrasenaNueva2.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasenaNueva2.PasswordChar = '*';
                        this.EntradaContrasenaNueva2.PlaceholderText = "";
                        this.EntradaContrasenaNueva2.Prefijo = "";
                        this.EntradaContrasenaNueva2.ReadOnly = false;
                        this.EntradaContrasenaNueva2.SelectOnFocus = true;
                        this.EntradaContrasenaNueva2.Size = new System.Drawing.Size(176, 24);
                        this.EntradaContrasenaNueva2.Sufijo = "";
                        this.EntradaContrasenaNueva2.TabIndex = 5;
                        this.EntradaContrasenaNueva2.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.label4.Location = new System.Drawing.Point(152, 196);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(164, 24);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "Repita Contraseña ";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Titulo
                        // 
                        this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(202)))), ((int)(((byte)(174)))));
                        this.Titulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 11F, System.Drawing.FontStyle.Bold);
                        this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.Titulo.Location = new System.Drawing.Point(136, 32);
                        this.Titulo.Name = "Titulo";
                        this.Titulo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
                        this.Titulo.Size = new System.Drawing.Size(380, 24);
                        this.Titulo.TabIndex = 59;
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
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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

                private System.Windows.Forms.Label Label2;
                private Lui.Forms.Button OkButton;
                private Lui.Forms.TextBox EntradaContrasena;
                private Lui.Forms.Button CancelCommandButton;
                private System.Windows.Forms.Panel LowerPanel;
                private System.Windows.Forms.Panel panel1;
                private System.Windows.Forms.PictureBox PictureBox1;
                private System.Windows.Forms.Label label3;
                private Lui.Forms.TextBox EntradaContrasenaNueva1;
                private System.Windows.Forms.Label label1;
                private Lui.Forms.TextBox EntradaContrasenaNueva2;
                private System.Windows.Forms.Label label4;
                private Lui.Forms.LabelH1 Titulo;
        }
}