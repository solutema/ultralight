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

using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Misc
{
        public partial class Ingreso
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
                        this.txtContrasena = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Titulo = new System.Windows.Forms.Label();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.OkButton = new Lui.Forms.Button();
                        this.txtUsuario = new Lui.Forms.DetailBox();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.PictureBox2 = new System.Windows.Forms.PictureBox();
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.UpperPanel = new System.Windows.Forms.Panel();
                        this.label3 = new System.Windows.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
                        this.LowerPanel.SuspendLayout();
                        this.UpperPanel.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // txtContrasena
                        // 
                        this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtContrasena.AutoNav = true;
                        this.txtContrasena.AutoTab = true;
                        this.txtContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtContrasena.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtContrasena.Location = new System.Drawing.Point(148, 169);
                        this.txtContrasena.MaxLenght = 32767;
                        this.txtContrasena.Name = "txtContrasena";
                        this.txtContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.txtContrasena.PasswordChar = '*';
                        this.txtContrasena.ReadOnly = false;
                        this.txtContrasena.Size = new System.Drawing.Size(198, 24);
                        this.txtContrasena.TabIndex = 6;
                        this.txtContrasena.TipWhenBlank = "";
                        this.txtContrasena.ToolTipText = "";
                        this.txtContrasena.TextChanged += new System.EventHandler(this.CambioDatos);
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Label1.Location = new System.Drawing.Point(60, 137);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(88, 24);
                        this.Label1.TabIndex = 3;
                        this.Label1.Text = "Usuario";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Label2.Location = new System.Drawing.Point(60, 169);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(88, 24);
                        this.Label2.TabIndex = 5;
                        this.Label2.Text = "Contraseña";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Titulo
                        // 
                        this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Titulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Titulo.ForeColor = System.Drawing.Color.White;
                        this.Titulo.Location = new System.Drawing.Point(16, 104);
                        this.Titulo.Name = "Titulo";
                        this.Titulo.Size = new System.Drawing.Size(444, 24);
                        this.Titulo.TabIndex = 0;
                        this.Titulo.Text = "Escriba su número de usuario y su contraseña";
                        this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(354, 12);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(108, 36);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "";
                        this.CancelCommandButton.TabIndex = 8;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Enabled = false;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(234, 12);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(108, 36);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "";
                        this.OkButton.TabIndex = 7;
                        this.OkButton.Text = "Aceptar";
                        this.OkButton.ToolTipText = "";
                        this.OkButton.Click += new System.EventHandler(this.cmdAceptar_Click);
                        // 
                        // txtUsuario
                        // 
                        this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtUsuario.AutoTab = true;
                        this.txtUsuario.CanCreate = false;
                        this.txtUsuario.DetailField = "nombre_visible";
                        this.txtUsuario.ExtraDetailFields = null;
                        this.txtUsuario.Filter = "(tipo&4)=4 AND contrasena<>\'\'";
                        this.txtUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtUsuario.FreeTextCode = "";
                        this.txtUsuario.KeyField = "id_persona";
                        this.txtUsuario.Location = new System.Drawing.Point(148, 137);
                        this.txtUsuario.MaxLength = 200;
                        this.txtUsuario.Name = "txtUsuario";
                        this.txtUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.txtUsuario.ReadOnly = false;
                        this.txtUsuario.Required = true;
                        this.txtUsuario.Size = new System.Drawing.Size(306, 24);
                        this.txtUsuario.TabIndex = 4;
                        this.txtUsuario.Table = "personas";
                        this.txtUsuario.TeclaDespuesDeEnter = "{tab}";
                        this.txtUsuario.Text = "0";
                        this.txtUsuario.TextDetail = "";
                        this.txtUsuario.TextInt = 0;
                        this.txtUsuario.TipWhenBlank = "";
                        this.txtUsuario.ToolTipText = "";
                        this.txtUsuario.TextChanged += new System.EventHandler(this.CambioDatos);
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(24, 16);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(56, 56);
                        this.PictureBox1.TabIndex = 9;
                        this.PictureBox1.TabStop = false;
                        // 
                        // PictureBox2
                        // 
                        this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
                        this.PictureBox2.Location = new System.Drawing.Point(20, 137);
                        this.PictureBox2.Name = "PictureBox2";
                        this.PictureBox2.Size = new System.Drawing.Size(32, 32);
                        this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.PictureBox2.TabIndex = 10;
                        this.PictureBox2.TabStop = false;
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.OkButton);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 214);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(474, 60);
                        this.LowerPanel.TabIndex = 12;
                        // 
                        // UpperPanel
                        // 
                        this.UpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        this.UpperPanel.Controls.Add(this.label3);
                        this.UpperPanel.Controls.Add(this.PictureBox1);
                        this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
                        this.UpperPanel.Location = new System.Drawing.Point(0, 0);
                        this.UpperPanel.Name = "UpperPanel";
                        this.UpperPanel.Size = new System.Drawing.Size(474, 92);
                        this.UpperPanel.TabIndex = 13;
                        // 
                        // label3
                        // 
                        this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label3.Location = new System.Drawing.Point(100, 20);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(348, 48);
                        this.label3.TabIndex = 10;
                        this.label3.Text = "Lázaro";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Ingreso
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 274);
                        this.ControlBox = false;
                        this.Controls.Add(this.txtUsuario);
                        this.Controls.Add(this.txtContrasena);
                        this.Controls.Add(this.UpperPanel);
                        this.Controls.Add(this.PictureBox2);
                        this.Controls.Add(this.Titulo);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.LowerPanel);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "Ingreso";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Ingreso al Sistema";
                        this.TopMost = true;
                        this.Load += new System.EventHandler(this.FormIngreso_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
                        this.LowerPanel.ResumeLayout(false);
                        this.UpperPanel.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.Button OkButton;
                internal Lui.Forms.TextBox txtContrasena;
                internal Lui.Forms.DetailBox txtUsuario;
                internal Lui.Forms.Button CancelCommandButton;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal System.Windows.Forms.PictureBox PictureBox2;
                private System.Windows.Forms.Panel UpperPanel;
                internal System.Windows.Forms.Label Titulo;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.Panel LowerPanel;
        }
}
