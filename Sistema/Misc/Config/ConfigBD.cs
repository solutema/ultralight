#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
                        LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
                        lblHeader1.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        lblHeader1.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;
                        lblHeader4.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                        lblHeader4.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;

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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal System.Windows.Forms.Label Label27;
                internal System.Windows.Forms.Label Label3;
                internal System.Windows.Forms.Label lblHeader1;
                internal Lui.Forms.TextBox EntradaServidor;
                internal System.Windows.Forms.Label EtiquetaServidor;
                internal System.Windows.Forms.Panel PanelServidorAvanzado;
                internal Lui.Forms.TextBox EntradaBD;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox EntradaConexion;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.TextBox EntradaContrasena;
                internal Lui.Forms.TextBox EntradaUsuario;
                internal System.Windows.Forms.Label Label28;
                internal System.Windows.Forms.Label Label29;
                internal Lui.Forms.Button BotonServidorVista;
                internal Lui.Forms.Button GCommand1;
                internal System.Windows.Forms.Panel LowerPanel;
                internal Lui.Forms.Button CancelCommandButton;
                internal Lui.Forms.Button OkButton;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label EtiquetaServidorCumple;
                internal System.Windows.Forms.Label lblHeader4;
                internal System.Windows.Forms.Label label4;
                internal Lui.Forms.ComboBox EntradaSlowLink;
                internal Lui.Forms.TextBox EntradaSucursal;
                internal System.Windows.Forms.Label label5;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal System.Windows.Forms.Label label7;
                internal System.Windows.Forms.Panel PanelServidorNoInstalado;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBD));
                        this.Label27 = new System.Windows.Forms.Label();
                        this.EntradaServidor = new Lui.Forms.TextBox();
                        this.EtiquetaServidor = new System.Windows.Forms.Label();
                        this.lblHeader1 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.BotonServidorVista = new Lui.Forms.Button();
                        this.PanelServidorAvanzado = new System.Windows.Forms.Panel();
                        this.EntradaSucursal = new Lui.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.EntradaSlowLink = new Lui.Forms.ComboBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.EntradaBD = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaConexion = new Lui.Forms.ComboBox();
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
                        this.EtiquetaServidorCumple = new System.Windows.Forms.Label();
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
                        this.EntradaServidor.AutoSize = false;
                        this.EntradaServidor.AutoNav = true;
                        this.EntradaServidor.AutoTab = true;
                        this.EntradaServidor.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaServidor.DecimalPlaces = -1;
                        this.EntradaServidor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaServidor.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaServidor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaServidor.Location = new System.Drawing.Point(172, 151);
                        this.EntradaServidor.MaxLenght = 32767;
                        this.EntradaServidor.MultiLine = false;
                        this.EntradaServidor.Name = "txtServidor";
                        this.EntradaServidor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaServidor.PasswordChar = '\0';
                        this.EntradaServidor.Prefijo = "";
                        this.EntradaServidor.ReadOnly = false;
                        this.EntradaServidor.SelectOnFocus = false;
                        this.EntradaServidor.Size = new System.Drawing.Size(260, 25);
                        this.EntradaServidor.Sufijo = "";
                        this.EntradaServidor.TabIndex = 4;
                        this.EntradaServidor.TipWhenBlank = "";
                        this.EntradaServidor.ToolTipText = "";
                        this.EntradaServidor.Leave += new System.EventHandler(this.EntradaServidor_Leave);
                        // 
                        // lblServidor
                        // 
                        this.EtiquetaServidor.Location = new System.Drawing.Point(24, 151);
                        this.EtiquetaServidor.Name = "lblServidor";
                        this.EtiquetaServidor.Size = new System.Drawing.Size(147, 25);
                        this.EtiquetaServidor.TabIndex = 3;
                        this.EtiquetaServidor.Text = "Nombre del servidor";
                        this.EtiquetaServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
                        // BotonServidorVista
                        // 
                        this.BotonServidorVista.AutoSize = false;
                        this.BotonServidorVista.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonServidorVista.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonServidorVista.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonServidorVista.Image = null;
                        this.BotonServidorVista.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonServidorVista.Location = new System.Drawing.Point(24, 180);
                        this.BotonServidorVista.Name = "BotonServidorVista";
                        this.BotonServidorVista.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonServidorVista.ReadOnly = false;
                        this.BotonServidorVista.Size = new System.Drawing.Size(132, 28);
                        this.BotonServidorVista.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonServidorVista.Subtext = "F8";
                        this.BotonServidorVista.TabIndex = 100;
                        this.BotonServidorVista.Text = "Vista Avanzada >";
                        this.BotonServidorVista.ToolTipText = "";
                        this.BotonServidorVista.Click += new System.EventHandler(this.BotonServidorVista_Click);
                        // 
                        // PanelServidorAvanzado
                        // 
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaSucursal);
                        this.PanelServidorAvanzado.Controls.Add(this.label5);
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaSlowLink);
                        this.PanelServidorAvanzado.Controls.Add(this.label4);
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaBD);
                        this.PanelServidorAvanzado.Controls.Add(this.Label2);
                        this.PanelServidorAvanzado.Controls.Add(this.EntradaConexion);
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
                        this.EntradaSucursal.AutoSize = false;
                        this.EntradaSucursal.AutoNav = true;
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaSucursal.DecimalPlaces = -1;
                        this.EntradaSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaSucursal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSucursal.Location = new System.Drawing.Point(232, 140);
                        this.EntradaSucursal.MaxLenght = 32767;
                        this.EntradaSucursal.MultiLine = false;
                        this.EntradaSucursal.Name = "txtBranch";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.PasswordChar = '\0';
                        this.EntradaSucursal.Prefijo = "";
                        this.EntradaSucursal.ReadOnly = false;
                        this.EntradaSucursal.SelectOnFocus = true;
                        this.EntradaSucursal.Size = new System.Drawing.Size(60, 24);
                        this.EntradaSucursal.Sufijo = "";
                        this.EntradaSucursal.TabIndex = 11;
                        this.EntradaSucursal.Text = "1";
                        this.EntradaSucursal.TipWhenBlank = "";
                        this.EntradaSucursal.ToolTipText = "";
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
                        this.EntradaSlowLink.AutoSize = false;
                        this.EntradaSlowLink.AutoNav = true;
                        this.EntradaSlowLink.AutoTab = true;
                        this.EntradaSlowLink.DetailField = null;
                        this.EntradaSlowLink.Filter = null;
                        this.EntradaSlowLink.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaSlowLink.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSlowLink.KeyField = null;
                        this.EntradaSlowLink.Location = new System.Drawing.Point(232, 112);
                        this.EntradaSlowLink.MaxLenght = 32767;
                        this.EntradaSlowLink.Name = "txtSlowLink";
                        this.EntradaSlowLink.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSlowLink.ReadOnly = false;
                        this.EntradaSlowLink.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaSlowLink.Size = new System.Drawing.Size(60, 25);
                        this.EntradaSlowLink.TabIndex = 9;
                        this.EntradaSlowLink.Table = null;
                        this.EntradaSlowLink.Text = "No";
                        this.EntradaSlowLink.TextKey = "0";
                        this.EntradaSlowLink.TipWhenBlank = "";
                        this.EntradaSlowLink.ToolTipText = "";
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
                        this.EntradaBD.AutoSize = false;
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
                        this.EntradaConexion.AutoSize = false;
                        this.EntradaConexion.AutoNav = true;
                        this.EntradaConexion.AutoTab = true;
                        this.EntradaConexion.DetailField = null;
                        this.EntradaConexion.Filter = null;
                        this.EntradaConexion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaConexion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConexion.KeyField = null;
                        this.EntradaConexion.Location = new System.Drawing.Point(124, 0);
                        this.EntradaConexion.MaxLenght = 32767;
                        this.EntradaConexion.Name = "txtConexion";
                        this.EntradaConexion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConexion.ReadOnly = false;
                        this.EntradaConexion.SetData = new string[] {
        "ODBC|odbc",
        "MySQL Nativo|mysql",
        "PostgreSQL|npgsql"};
                        this.EntradaConexion.Size = new System.Drawing.Size(196, 23);
                        this.EntradaConexion.TabIndex = 1;
                        this.EntradaConexion.Table = null;
                        this.EntradaConexion.Text = "MySQL Nativo";
                        this.EntradaConexion.TextKey = "mysql";
                        this.EntradaConexion.TipWhenBlank = "";
                        this.EntradaConexion.ToolTipText = "";
                        this.EntradaConexion.TextChanged += new System.EventHandler(this.EntradaConexion_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(0, 0);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(124, 23);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Tipo de Conexión";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtContrasena
                        // 
                        this.EntradaContrasena.AutoSize = false;
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
                        this.EntradaContrasena.TipWhenBlank = "";
                        this.EntradaContrasena.ToolTipText = "";
                        // 
                        // txtUsuario
                        // 
                        this.EntradaUsuario.AutoSize = false;
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
                        this.GCommand1.AutoSize = false;
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
                        this.OkButton.AutoSize = false;
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
                        this.OkButton.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.AutoSize = false;
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
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
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
                        this.EtiquetaServidorCumple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaServidorCumple.Location = new System.Drawing.Point(12, 36);
                        this.EtiquetaServidorCumple.Name = "lblServidorCumple";
                        this.EtiquetaServidorCumple.Size = new System.Drawing.Size(500, 20);
                        this.EtiquetaServidorCumple.TabIndex = 2;
                        this.EtiquetaServidorCumple.Text = "Esta PC no cumple con los requisitos.";
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
                        this.PanelServidorNoInstalado.Controls.Add(this.EtiquetaServidorCumple);
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
                        this.Controls.Add(this.BotonServidorVista);
                        this.Controls.Add(this.EntradaServidor);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.lblHeader1);
                        this.Controls.Add(this.Label27);
                        this.Controls.Add(this.EtiquetaServidor);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "ConfigBD";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Configurar Acceso a Datos";
                        this.Load += new System.EventHandler(this.ConfigBD_Load);
                        this.PanelServidorAvanzado.ResumeLayout(false);
                        this.LowerPanel.ResumeLayout(false);
                        this.PanelServidorNoInstalado.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }


                #endregion

                private void ConfigBD_Load(object sender, System.EventArgs e)
                {
                        string Servidor = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DataSource", null);
                        string Conexion = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "ConnectionType", null);
                        string BD = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "DatabaseName", null);
                        string Usuario = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "User", null);
                        string Contrasena = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "Password", null);
                        string SlowLink = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Data", "SlowLink", null);
                        string Branch = Lfx.Workspace.Master.CurrentConfig.ReadLocalSettingString("Company", "Branch", null);

                        if (Servidor == null)
                                EntradaServidor.Text = "localhost";
                        else
                                EntradaServidor.Text = Servidor;

                        if (Conexion == null)
                                EntradaConexion.TextKey = "mysql";
                        else
                                EntradaConexion.TextKey = Conexion;

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
                                EntradaSlowLink.TextKey = "1";
                        else
                                EntradaSlowLink.TextKey = SlowLink;

                        if (Branch == null)
                                EntradaSucursal.Text = "1";
                        else
                                EntradaSucursal.Text = Branch;

                        EtiquetaServidorCumple.Text = "Puede instalar un servidor SQL en este equipo, si aun no lo ha hecho.";
                }


                private void EntradaConexion_TextChanged(System.Object sender, System.EventArgs e)
                {
                        switch (EntradaConexion.TextKey) {
                                case "odbc":
                                        EtiquetaServidor.Text = "DSN";
                                        break;
                                default:
                                        EtiquetaServidor.Text = "Servidor";
                                        break;
                        }
                }


                private void BotonServidorVista_Click(System.Object sender, System.EventArgs e)
                {
                        if (PanelServidorAvanzado.Visible) {
                                PanelServidorAvanzado.Visible = false;
                                PanelServidorNoInstalado.Top = BotonServidorVista.Top + BotonServidorVista.Height + 4;
                                BotonServidorVista.Text = "Vista Avanzada >";
                        } else {
                                PanelServidorAvanzado.Visible = true;
                                PanelServidorNoInstalado.Top = PanelServidorAvanzado.Top + PanelServidorAvanzado.Height + 4;
                                BotonServidorVista.Text = "Vista Normal <";
                        }
                }


                private void BotonAceptar_Click(System.Object sender, System.EventArgs e)
                {
                        if (EntradaServidor.Text.Length == 0) {
                                Lui.Forms.MessageBox.Show("Por favor escriba el nombre del Servidor.", "Error");
                                return;
                        }
                        if (EntradaConexion.TextKey != "odbc" && EntradaUsuario.Text.Length == 0) {
                                Lui.Forms.MessageBox.Show("Por favor escriba el nombre del Usuario.", "Error");
                                return;
                        }

                        this.Hide();

                        Lfx.Data.DataBaseCache.DefaultCache.ServerName = EntradaServidor.Text;
                        switch (EntradaConexion.TextKey) {
                                case "odbc":
                                        Lfx.Data.DataBaseCache.DefaultCache.AccessMode = Lfx.Data.AccessModes.Odbc;
                                        break;
                                case "myodbc":
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

                        Lfx.Data.DataBaseCache.DefaultCache.SlowLink = Lfx.Types.Parsing.ParseInt(EntradaSlowLink.TextKey) != 0;
                        Lfx.Data.DataBaseCache.DefaultCache.DataBaseName = EntradaBD.Text;
                        Lfx.Data.DataBaseCache.DefaultCache.UserName = EntradaUsuario.Text;
                        Lfx.Data.DataBaseCache.DefaultCache.Password = EntradaContrasena.Text;

                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DataSource", Lfx.Data.DataBaseCache.DefaultCache.ServerName);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "ConnectionType", EntradaConexion.TextKey);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "DatabaseName", EntradaBD.Text);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "User", EntradaUsuario.Text);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "Password", EntradaContrasena.Text);
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Data", "SlowLink", Lfx.Data.DataBaseCache.DefaultCache.SlowLink ? "1" : "0");
                        Lfx.Workspace.Master.CurrentConfig.WriteLocalSetting("Company", "Branch", EntradaSucursal.Text);

                        Datos.Iniciar();
                        this.DialogResult = DialogResult.Retry;
                }


                private void BotonCancelar_Click(System.Object sender, System.EventArgs e)
                {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                }

                private void EntradaServidor_Leave(object sender, EventArgs e)
                {
                        Regex IpLocal1 = new Regex(@"^192\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
                        Regex IpLocal2 = new Regex(@"^10\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
                        if (EntradaServidor.Text.Contains(".") == false || IpLocal1.IsMatch(EntradaServidor.Text) || IpLocal2.IsMatch(EntradaServidor.Text)) {
                                EntradaSlowLink.TextKey = "0";
                        }
                        else {
                                EntradaSlowLink.TextKey = "1";
                        }
                }

        }
}