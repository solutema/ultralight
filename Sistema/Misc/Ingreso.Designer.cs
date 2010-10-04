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
                        this.EntradaContrasena = new Lui.Forms.TextBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Titulo = new System.Windows.Forms.Label();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.OkButton = new Lui.Forms.Button();
                        this.EntradaUsuario = new Lcc.Entrada.CodigoDetalle();
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
                        this.EntradaContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaContrasena.AutoNav = true;
                        this.EntradaContrasena.AutoTab = true;
                        this.EntradaContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasena.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaContrasena.Location = new System.Drawing.Point(148, 169);
                        this.EntradaContrasena.MaxLenght = 32767;
                        this.EntradaContrasena.Name = "txtContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.Size = new System.Drawing.Size(198, 24);
                        this.EntradaContrasena.TabIndex = 6;
                        this.EntradaContrasena.TipWhenBlank = "";
                        this.EntradaContrasena.ToolTipText = "";
                        this.EntradaContrasena.TextChanged += new System.EventHandler(this.CambioDatos);
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
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
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
                        this.OkButton.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // txtUsuario
                        // 
                        this.EntradaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUsuario.AutoTab = true;
                        this.EntradaUsuario.CanCreate = false;
                        this.EntradaUsuario.DetailField = "nombre_visible";
                        this.EntradaUsuario.ExtraDetailFields = null;
                        this.EntradaUsuario.Filter = "(tipo&4)=4 AND contrasena<>\'\'";
                        this.EntradaUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaUsuario.FreeTextCode = "";
                        this.EntradaUsuario.KeyField = "id_persona";
                        this.EntradaUsuario.Location = new System.Drawing.Point(148, 137);
                        this.EntradaUsuario.MaxLength = 200;
                        this.EntradaUsuario.Name = "txtUsuario";
                        this.EntradaUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsuario.ReadOnly = false;
                        this.EntradaUsuario.Required = true;
                        this.EntradaUsuario.Size = new System.Drawing.Size(306, 24);
                        this.EntradaUsuario.TabIndex = 4;
                        this.EntradaUsuario.Table = "personas";
                        this.EntradaUsuario.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaUsuario.Text = "0";
                        this.EntradaUsuario.TextDetail = "";
                        this.EntradaUsuario.TextInt = 0;
                        this.EntradaUsuario.TipWhenBlank = "";
                        this.EntradaUsuario.ToolTipText = "";
                        this.EntradaUsuario.TextChanged += new System.EventHandler(this.CambioDatos);
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
                        this.Controls.Add(this.EntradaUsuario);
                        this.Controls.Add(this.EntradaContrasena);
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
                internal Lui.Forms.TextBox EntradaContrasena;
                internal Lcc.Entrada.CodigoDetalle EntradaUsuario;
                internal Lui.Forms.Button CancelCommandButton;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal System.Windows.Forms.PictureBox PictureBox2;
                private System.Windows.Forms.Panel UpperPanel;
                internal System.Windows.Forms.Label Titulo;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.Panel LowerPanel;
        }
}
