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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lazaro.Misc.Config
{
        public class ConfigBD : Lui.Forms.Form
        {

                #region Código generado por el Diseñador de Windows Forms

                public ConfigBD()
                        : base()
                {


                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        LowerPanel.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
                        lblHeader1.BackColor = Lws.Config.Display.CurrentTemplate.HeaderBackground;
                        lblHeader1.ForeColor = Lws.Config.Display.CurrentTemplate.HeaderText;
                        lblHeader4.BackColor = Lws.Config.Display.CurrentTemplate.HeaderBackground;
                        lblHeader4.ForeColor = Lws.Config.Display.CurrentTemplate.HeaderText;

                }

                // Limpiar los recursos que se están utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }


                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label27;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label lblHeader1;
                internal Lui.Forms.TextBox txtServidor;
                internal System.Windows.Forms.Label lblServidor;
                internal System.Windows.Forms.Panel PanelServidorAvanzado;
                internal Lui.Forms.TextBox EntradaBD;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtConexion;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaContrasena;
                internal Lui.Forms.TextBox EntradaUsuario;
                internal System.Windows.Forms.Label Label28;
                internal System.Windows.Forms.Label Label29;
                internal Lui.Forms.Button cmdServidorVista;
                internal Lui.Forms.Button GCommand1;
                internal System.Windows.Forms.Panel LowerPanel;
                internal Lui.Forms.Button CancelCommandButton;
                internal Lui.Forms.Button OkButton;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label lblServidorCumple;
                internal System.Windows.Forms.Label lblHeader4;
                internal System.Windows.Forms.Label label4;
                internal Lui.Forms.ComboBox txtSlowLink;
                internal Lui.Forms.TextBox txtBranch;
                internal System.Windows.Forms.Label label5;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal System.Windows.Forms.Label label7;
                internal System.Windows.Forms.Panel PanelServidorNoInstalado;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBD));
                        this.Label27 = new System.Windows.Forms.Label();
                        this.txtServidor = new Lui.Forms.TextBox();
                        this.lblServidor = new System.Windows.Forms.Label();
                        this.lblHeader1 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.cmdServidorVista = new Lui.Forms.Button();
                        this.PanelServidorAvanzado = new System.Windows.Forms.Panel();
                        this.txtBranch = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtSlowLink = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaBD = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtConexion = new Lui.Forms.ComboBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.EntradaContrasena = new Lui.Forms.TextBox();
                        this.EntradaUsuario = new Lui.Forms.TextBox();
                        this.Label28 = new System.Windows.Forms.Label();
                        this.Label29 = new System.Windows.Forms.Label();
                        this.GCommand1 = new Lui.Forms.Button();
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.OkButton = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.lblServidorCumple = new System.Windows.Forms.Label();
                        this.lblHeader4 = new System.Windows.Forms.Label();
                        this.PanelServidorNoInstalado = new System.Windows.Forms.Panel();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.PanelServidorAvanzado.SuspendLayout();
                        this.LowerPanel.SuspendLayout();
                        this.PanelServidorNoInstalado.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Label27
                        // 
                        this.Label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label27.Location = new System.Drawing.Point(76, 9);
                        this.Label27.Name = "Label27";
                        this.Label27.Size = new System.Drawing.Size(447, 32);
                        this.Label27.TabIndex = 0;
                        this.Label27.Text = "El sistema Lázaro necesita un servidor SQL para operar";
                        this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtServidor
                        // 
                        this.txtServidor.AutoHeight = false;
                        this.txtServidor.AutoNav = true;
                        this.txtServidor.AutoTab = true;
                        this.txtServidor.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtServidor.DecimalPlaces = -1;
                        this.txtServidor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtServidor.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtServidor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtServidor.Location = new System.Drawing.Point(172, 151);
                        this.txtServidor.MaxLenght = 32767;
                        this.txtServidor.MultiLine = false;
                        this.txtServidor.Name = "txtServidor";
                        this.txtServidor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtServidor.PasswordChar = '\0';
                        this.txtServidor.Prefijo = "";
                        this.txtServidor.ReadOnly = false;
                        this.txtServidor.SelectOnFocus = false;
                        this.txtServidor.Size = new System.Drawing.Size(260, 25);
                        this.txtServidor.Sufijo = "";
                        this.txtServidor.TabIndex = 4;
                        this.txtServidor.TextRaw = "";
                        this.txtServidor.TipWhenBlank = "";
                        this.txtServidor.ToolTipText = "";
                        this.txtServidor.Leave += new System.EventHandler(this.txtServidor_Leave);
                        // 
                        // lblServidor
                        // 
                        this.lblServidor.Location = new System.Drawing.Point(24, 151);
                        this.lblServidor.Name = "lblServidor";
                        this.lblServidor.Size = new System.Drawing.Size(147, 25);
                        this.lblServidor.TabIndex = 3;
                        this.lblServidor.Text = "Nombre del servidor";
                        this.lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblHeader1
                        // 
                        this.lblHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblHeader1.BackColor = System.Drawing.SystemColors.ControlDark;
                        this.lblHeader1.Location = new System.Drawing.Point(12, 84);
                        this.lblHeader1.Name = "lblHeader1";
                        this.lblHeader1.Size = new System.Drawing.Size(511, 24);
                        this.lblHeader1.TabIndex = 1;
                        this.lblHeader1.Text = " Si ya dispone de un servidor";
                        this.lblHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.Location = new System.Drawing.Point(20, 116);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(503, 28);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Si ya configuró un servidor SQL en este equipo o en otro equipo de la red, escrib" +
                            "a aquí los datos del mismo. Estos datos serán guardados para futuros ingresos.";
                        // 
                        // cmdServidorVista
                        // 
                        this.cmdServidorVista.AutoHeight = false;
                        this.cmdServidorVista.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdServidorVista.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdServidorVista.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdServidorVista.Image = null;
                        this.cmdServidorVista.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdServidorVista.Location = new System.Drawing.Point(24, 180);
                        this.cmdServidorVista.Name = "cmdServidorVista";
                        this.cmdServidorVista.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdServidorVista.ReadOnly = false;
                        this.cmdServidorVista.Size = new System.Drawing.Size(132, 28);
                        this.cmdServidorVista.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdServidorVista.Subtext = "F8";
                        this.cmdServidorVista.TabIndex = 100;
                        this.cmdServidorVista.Text = "Vista Avanzada >";
                        this.cmdServidorVista.ToolTipText = "";
                        this.cmdServidorVista.Click += new System.EventHandler(this.cmdServidorVista_Click);
                        // 
                        // PanelServidorAvanzado
                        // 
                        this.PanelServidorAvanzado.Controls.Add(this.txtBranch);
                        this.PanelServidorAvanzado.Controls.Add(this.label5);
                        this.PanelServidorAvanzado.Controls.Add(this.txtSlowLink);
                        this.PanelServidorAvanzado.Controls.Add(this.label4);
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaBD);
                        this.PanelServidorAvanzado.Controls.Add(this.Label2);
                        this.PanelServidorAvanzado.Controls.Add(this.txtConexion);
                        this.PanelServidorAvanzado.Controls.Add(this.Label1);
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaContrasena);
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaUsuario);
                        this.PanelServidorAvanzado.Controls.Add(this.Label28);
                        this.PanelServidorAvanzado.Controls.Add(this.Label29);
                        this.PanelServidorAvanzado.Location = new System.Drawing.Point(168, 183);
                        this.PanelServidorAvanzado.Name = "PanelServidorAvanzado";
                        this.PanelServidorAvanzado.Size = new System.Drawing.Size(320, 165);
                        this.PanelServidorAvanzado.TabIndex = 7;
                        this.PanelServidorAvanzado.Visible = false;
                        // 
                        // txtBranch
                        // 
                        this.txtBranch.AutoHeight = false;
                        this.txtBranch.AutoNav = true;
                        this.txtBranch.AutoTab = true;
                        this.txtBranch.DataType = Lui.Forms.DataTypes.Integer;
                        this.txtBranch.DecimalPlaces = -1;
                        this.txtBranch.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtBranch.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtBranch.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtBranch.Location = new System.Drawing.Point(232, 140);
                        this.txtBranch.MaxLenght = 32767;
                        this.txtBranch.MultiLine = false;
                        this.txtBranch.Name = "txtBranch";
                        this.txtBranch.Padding = new System.Windows.Forms.Padding(2);
                        this.txtBranch.PasswordChar = '\0';
                        this.txtBranch.Prefijo = "";
                        this.txtBranch.ReadOnly = false;
                        this.txtBranch.SelectOnFocus = true;
                        this.txtBranch.Size = new System.Drawing.Size(60, 24);
                        this.txtBranch.Sufijo = "";
                        this.txtBranch.TabIndex = 11;
                        this.txtBranch.Text = "1";
                        this.txtBranch.TextRaw = "1";
                        this.txtBranch.TipWhenBlank = "";
                        this.txtBranch.ToolTipText = "";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 140);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(232, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "Sucursal predeterminada";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSlowLink
                        // 
                        this.txtSlowLink.AutoHeight = false;
                        this.txtSlowLink.AutoNav = true;
                        this.txtSlowLink.AutoTab = true;
                        this.txtSlowLink.DetailField = null;
                        this.txtSlowLink.Filter = null;
                        this.txtSlowLink.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtSlowLink.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSlowLink.KeyField = null;
                        this.txtSlowLink.Location = new System.Drawing.Point(232, 112);
                        this.txtSlowLink.MaxLenght = 32767;
                        this.txtSlowLink.Name = "txtSlowLink";
                        this.txtSlowLink.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSlowLink.ReadOnly = false;
                        this.txtSlowLink.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.txtSlowLink.Size = new System.Drawing.Size(60, 25);
                        this.txtSlowLink.TabIndex = 9;
                        this.txtSlowLink.Table = null;
                        this.txtSlowLink.Text = "No";
                        this.txtSlowLink.TextKey = "0";
                        this.txtSlowLink.TextRaw = "No";
                        this.txtSlowLink.TipWhenBlank = "";
                        this.txtSlowLink.ToolTipText = "";
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(0, 112);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(240, 25);
                        this.label4.TabIndex = 8;
                        this.label4.Text = "Optimizar para una conexión lenta";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtBD
                        // 
                        this.EntradaBD.AutoHeight = false;
                        this.EntradaBD.AutoNav = true;
                        this.EntradaBD.AutoTab = true;
                        this.EntradaBD.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaBD.DecimalPlaces = -1;
                        this.EntradaBD.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaBD.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaBD.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaBD.Location = new System.Drawing.Point(124, 28);
                        this.EntradaBD.MaxLenght = 32767;
                        this.EntradaBD.MultiLine = false;
                        this.EntradaBD.Name = "txtBD";
                        this.EntradaBD.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBD.PasswordChar = '\0';
                        this.EntradaBD.Prefijo = "";
                        this.EntradaBD.ReadOnly = false;
                        this.EntradaBD.SelectOnFocus = true;
                        this.EntradaBD.Size = new System.Drawing.Size(172, 24);
                        this.EntradaBD.Sufijo = "";
                        this.EntradaBD.TabIndex = 3;
                        this.EntradaBD.TextRaw = "";
                        this.EntradaBD.TipWhenBlank = "";
                        this.EntradaBD.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(0, 28);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(124, 24);
                        this.Label2.TabIndex = 2;
                        this.Label2.Text = "Base de datos";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtConexion
                        // 
                        this.txtConexion.AutoHeight = false;
                        this.txtConexion.AutoNav = true;
                        this.txtConexion.AutoTab = true;
                        this.txtConexion.DetailField = null;
                        this.txtConexion.Filter = null;
                        this.txtConexion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtConexion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtConexion.KeyField = null;
                        this.txtConexion.Location = new System.Drawing.Point(124, 0);
                        this.txtConexion.MaxLenght = 32767;
                        this.txtConexion.Name = "txtConexion";
                        this.txtConexion.Padding = new System.Windows.Forms.Padding(2);
                        this.txtConexion.ReadOnly = false;
                        this.txtConexion.SetData = new string[] {
        "ODBC|odbc",
        "MySQL Nativo|mysql",
        "MySQL via ODBC|myodbc",
        "PostgreSQL|npgsql"};
                        this.txtConexion.Size = new System.Drawing.Size(196, 23);
                        this.txtConexion.TabIndex = 1;
                        this.txtConexion.Table = null;
                        this.txtConexion.Text = "MySQL Nativo";
                        this.txtConexion.TextKey = "mysql";
                        this.txtConexion.TextRaw = "MySQL Nativo";
                        this.txtConexion.TipWhenBlank = "";
                        this.txtConexion.ToolTipText = "";
                        this.txtConexion.TextChanged += new System.EventHandler(this.txtConexion_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 0);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(124, 23);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Tipo de conexión";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtContrasena
                        // 
                        this.EntradaContrasena.AutoHeight = false;
                        this.EntradaContrasena.AutoNav = true;
                        this.EntradaContrasena.AutoTab = true;
                        this.EntradaContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasena.DecimalPlaces = -1;
                        this.EntradaContrasena.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaContrasena.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaContrasena.Location = new System.Drawing.Point(124, 84);
                        this.EntradaContrasena.MaxLenght = 32767;
                        this.EntradaContrasena.MultiLine = false;
                        this.EntradaContrasena.Name = "txtContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.Prefijo = "";
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.SelectOnFocus = true;
                        this.EntradaContrasena.Size = new System.Drawing.Size(124, 24);
                        this.EntradaContrasena.Sufijo = "";
                        this.EntradaContrasena.TabIndex = 7;
                        this.EntradaContrasena.TextRaw = "";
                        this.EntradaContrasena.TipWhenBlank = "";
                        this.EntradaContrasena.ToolTipText = "";
                        // 
                        // txtUsuario
                        // 
                        this.EntradaUsuario.AutoHeight = false;
                        this.EntradaUsuario.AutoNav = true;
                        this.EntradaUsuario.AutoTab = true;
                        this.EntradaUsuario.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaUsuario.DecimalPlaces = -1;
                        this.EntradaUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaUsuario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaUsuario.Location = new System.Drawing.Point(124, 55);
                        this.EntradaUsuario.MaxLenght = 32767;
                        this.EntradaUsuario.MultiLine = false;
                        this.EntradaUsuario.Name = "txtUsuario";
                        this.EntradaUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsuario.PasswordChar = '\0';
                        this.EntradaUsuario.Prefijo = "";
                        this.EntradaUsuario.ReadOnly = false;
                        this.EntradaUsuario.SelectOnFocus = true;
                        this.EntradaUsuario.Size = new System.Drawing.Size(124, 25);
                        this.EntradaUsuario.Sufijo = "";
                        this.EntradaUsuario.TabIndex = 5;
                        this.EntradaUsuario.TextRaw = "";
                        this.EntradaUsuario.TipWhenBlank = "";
                        this.EntradaUsuario.ToolTipText = "";
                        // 
                        // Label28
                        // 
                        this.Label28.Location = new System.Drawing.Point(0, 84);
                        this.Label28.Name = "Label28";
                        this.Label28.Size = new System.Drawing.Size(124, 24);
                        this.Label28.TabIndex = 6;
                        this.Label28.Text = "Contraseña";
                        this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label29
                        // 
                        this.Label29.Location = new System.Drawing.Point(0, 55);
                        this.Label29.Name = "Label29";
                        this.Label29.Size = new System.Drawing.Size(124, 25);
                        this.Label29.TabIndex = 4;
                        this.Label29.Text = "Usuario";
                        this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // GCommand1
                        // 
                        this.GCommand1.AutoHeight = false;
                        this.GCommand1.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.GCommand1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.GCommand1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.GCommand1.Image = null;
                        this.GCommand1.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.GCommand1.Location = new System.Drawing.Point(440, 151);
                        this.GCommand1.Name = "GCommand1";
                        this.GCommand1.Padding = new System.Windows.Forms.Padding(2);
                        this.GCommand1.ReadOnly = false;
                        this.GCommand1.Size = new System.Drawing.Size(80, 25);
                        this.GCommand1.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.GCommand1.Subtext = "F8";
                        this.GCommand1.TabIndex = 5;
                        this.GCommand1.Text = "buscar...";
                        this.GCommand1.ToolTipText = "";
                        this.GCommand1.Visible = false;
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.OkButton);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 435);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(534, 52);
                        this.LowerPanel.TabIndex = 50;
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.AutoHeight = false;
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(308, 8);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(104, 36);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "F8";
                        this.OkButton.TabIndex = 50;
                        this.OkButton.Text = "Aceptar";
                        this.OkButton.ToolTipText = "";
                        this.OkButton.Click += new System.EventHandler(this.cmdAceptar_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.AutoHeight = false;
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(420, 8);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(104, 36);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "";
                        this.CancelCommandButton.TabIndex = 51;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(12, 56);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(500, 29);
                        this.Label6.TabIndex = 3;
                        this.Label6.Text = "Si necesita más información sobre el servidor SQL consulte el Manual del Administ" +
                            "rador del sistema Lázaro.";
                        // 
                        // lblServidorCumple
                        // 
                        this.lblServidorCumple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblServidorCumple.Location = new System.Drawing.Point(12, 36);
                        this.lblServidorCumple.Name = "lblServidorCumple";
                        this.lblServidorCumple.Size = new System.Drawing.Size(500, 20);
                        this.lblServidorCumple.TabIndex = 2;
                        this.lblServidorCumple.Text = "Esta PC no cumple con los requisitos.";
                        // 
                        // lblHeader4
                        // 
                        this.lblHeader4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblHeader4.BackColor = System.Drawing.SystemColors.ControlDark;
                        this.lblHeader4.Location = new System.Drawing.Point(3, 6);
                        this.lblHeader4.Name = "lblHeader4";
                        this.lblHeader4.Size = new System.Drawing.Size(512, 24);
                        this.lblHeader4.TabIndex = 0;
                        this.lblHeader4.Text = " Información sobre el servidor SQL";
                        this.lblHeader4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelServidorNoInstalado
                        // 
                        this.PanelServidorNoInstalado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelServidorNoInstalado.Controls.Add(this.Label6);
                        this.PanelServidorNoInstalado.Controls.Add(this.lblServidorCumple);
                        this.PanelServidorNoInstalado.Controls.Add(this.lblHeader4);
                        this.PanelServidorNoInstalado.Location = new System.Drawing.Point(8, 215);
                        this.PanelServidorNoInstalado.Name = "PanelServidorNoInstalado";
                        this.PanelServidorNoInstalado.Size = new System.Drawing.Size(520, 85);
                        this.PanelServidorNoInstalado.TabIndex = 11;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(16, 12);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(47, 64);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.PictureBox1.TabIndex = 101;
                        this.PictureBox1.TabStop = false;
                        // 
                        // label7
                        // 
                        this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label7.Location = new System.Drawing.Point(76, 41);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(447, 32);
                        this.label7.TabIndex = 102;
                        this.label7.Text = "Es necesario un servidor SQL donde guardar los datos. El servidor SQL puede estar" +
                            " en este equipo o en otro equipo si dispone de una red.";
                        // 
                        // ConfigBD
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(534, 487);
                        this.Controls.Add(this.PanelServidorNoInstalado);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.LowerPanel);
                        this.Controls.Add(this.PanelServidorAvanzado);
                        this.Controls.Add(this.GCommand1);
                        this.Controls.Add(this.cmdServidorVista);
                        this.Controls.Add(this.txtServidor);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.lblHeader1);
                        this.Controls.Add(this.Label27);
                        this.Controls.Add(this.lblServidor);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "ConfigBD";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Configurar Acceso a Datos";
                        this.Load += new System.EventHandler(this.FormConfigBD_Load);
                        this.PanelServidorAvanzado.ResumeLayout(false);
                        this.LowerPanel.ResumeLayout(false);
                        this.PanelServidorNoInstalado.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }


                #endregion

                private void FormConfigBD_Load(object sender, System.EventArgs e)
                {
                        string Servidor = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DataSource", null);
                        string Conexion = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "ConnectionType", null);
                        string BD = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DatabaseName", null);
                        string Usuario = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "User", null);
                        string Contrasena = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "Password", null);
                        string SlowLink = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "SlowLink", null);
                        string Branch = Lws.Workspace.Master.CurrentConfig.ReadLocalSettingString("Company", "Branch", null);

                        if (Servidor == null)
                                txtServidor.Text = "localhost";
                        else
                                txtServidor.Text = Servidor;

                        if (Conexion == null)
                                txtConexion.TextKey = "mysql";
                        else
                                txtConexion.TextKey = Conexion;

                        if (BD == null)
                                EntradaBD.Text = "lazaro";
                        else
                                EntradaBD.Text = BD;

                        if (Usuario == null)
                                EntradaUsuario.Text = "lazaro";
                        else
                                EntradaUsuario.Text = Usuario;

                        if (Contrasena == null)
                                EntradaContrasena.Text = "";
                        else
                                EntradaContrasena.Text = Contrasena;

                        if (SlowLink == null)
                                txtSlowLink.TextKey = "1";
                        else
                                txtSlowLink.TextKey = SlowLink;

                        if (Branch == null)
                                txtBranch.Text = "1";
                        else
                                txtBranch.Text = Branch;

                        lblServidorCumple.Text = "Puede instalar un servidor SQL en este equipo, si aun no lo ha hecho.";
                }


                private void txtConexion_TextChanged(System.Object sender, System.EventArgs e)
                {
                        switch (txtConexion.TextKey) {
                                case "odbc":
                                        lblServidor.Text = "DSN";
                                        break;
                                default:
                                        lblServidor.Text = "Servidor";
                                        break;
                        }

                }


                private void cmdServidorVista_Click(System.Object sender, System.EventArgs e)
                {
                        if (PanelServidorAvanzado.Visible) {
                                PanelServidorAvanzado.Visible = false;
                                PanelServidorNoInstalado.Top = cmdServidorVista.Top + cmdServidorVista.Height + 4;
                                cmdServidorVista.Text = "Vista Avanzada >";
                        }
                        else {
                                PanelServidorAvanzado.Visible = true;
                                PanelServidorNoInstalado.Top = PanelServidorAvanzado.Top + PanelServidorAvanzado.Height + 4;
                                cmdServidorVista.Text = "Vista Normal <";
                        }
                }


                private void cmdAceptar_Click(System.Object sender, System.EventArgs e)
                {
                        if (txtServidor.Text.Length == 0) {
                                Lui.Forms.MessageBox.Show("Por favor escriba el nombre del Servidor.", "Error");
                                return;
                        }
                        if (txtConexion.TextKey != "odbc" && EntradaUsuario.Text.Length == 0) {
                                Lui.Forms.MessageBox.Show("Por favor escriba el nombre del Usuario.", "Error");
                                return;
                        }

                        this.Hide();

                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = txtServidor.Text;
                        switch (txtConexion.TextKey) {
                                        case "odbc":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.ODBC;
                                                break;
                                        case "myodbc":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MyOdbc;
                                                break;
                                        case "mysql":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MySql;
                                                break;
                                        case "npgsql":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.Npgsql;
                                                break;
                                        case "mssql":
                                                Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.MSSql;
                                                break;
                                }
                        
                        Lfx.Data.DataBaseCache.DefaultCache.SlowLink = Lfx.Types.Parsing.ParseInt(txtSlowLink.TextKey) != 0;
                        Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = EntradaBD.Text;
                        Lfx.Data.DataBaseCache.DefaultCache.UserName = EntradaUsuario.Text;
                        Lfx.Data.DataBaseCache.DefaultCache.Password = EntradaContrasena.Text;

                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DataSource", Lfx.Data.DataBaseCache.DefaultCache.ServerName);
                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "ConnectionType", txtConexion.TextKey);
                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DatabaseName", EntradaBD.Text);
                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "User", EntradaUsuario.Text);
                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "Password", EntradaContrasena.Text);
                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "SlowLink", Lfx.Data.DataBaseCache.DefaultCache.SlowLink ? "1" : "0");
                        Lws.Workspace.Master.CurrentConfig.WriteLocalSetting("Company", "Branch", txtBranch.Text);

                        Datos.Iniciar();
                        this.DialogResult = DialogResult.Retry;
                }


                private void cmdCancelar_Click(System.Object sender, System.EventArgs e)
                {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                }

                private void txtServidor_Leave(object sender, EventArgs e)
                {
                        Regex IpLocal1 = new Regex(@"^192\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
                        Regex IpLocal2 = new Regex(@"^10\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
                        if (txtServidor.Text.Contains(".") == false || IpLocal1.IsMatch(txtServidor.Text) || IpLocal2.IsMatch(txtServidor.Text)) {
                                txtSlowLink.TextKey = "0";
                        }
                        else {
                                txtSlowLink.TextKey = "1";
                        }
                }

        }
}