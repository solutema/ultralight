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

namespace Lazaro.WinMain.Config
{
        public partial class ConfigurarBd
        {
                private System.ComponentModel.IContainer components = null;

                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarBd));
                        this.EtiquetaEncab = new Lui.Forms.Label();
                        this.EntradaServidor = new Lui.Forms.TextBox();
                        this.EtiquetaServidor = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.BotonServidorVista = new Lui.Forms.Button();
                        this.PanelServidorAvanzado = new Lui.Forms.Panel();
                        this.EntradaSucursal = new Lui.Forms.TextBox();
                        this.label5 = new Lui.Forms.Label();
                        this.EntradaSlowLink = new Lui.Forms.YesNo();
                        this.label4 = new Lui.Forms.Label();
                        this.EntradaBD = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaConexion = new Lui.Forms.ComboBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaContrasena = new Lui.Forms.TextBox();
                        this.EntradaUsuario = new Lui.Forms.TextBox();
                        this.Label28 = new Lui.Forms.Label();
                        this.Label29 = new Lui.Forms.Label();
                        this.LowerPanel = new Lui.Forms.ButtonPanel();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.OkButton = new Lui.Forms.Button();
                        this.Label6 = new Lui.Forms.Label();
                        this.EtiquetaServidorCumple = new Lui.Forms.Label();
                        this.EtiquetaSubEncab2 = new Lui.Forms.Label();
                        this.PanelServidorNoInstalado = new Lui.Forms.Panel();
                        this.BotonGuiaInstalacion = new Lui.Forms.LinkLabel();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.label7 = new Lui.Forms.Label();
                        this.PanelServidorAvanzado.SuspendLayout();
                        this.LowerPanel.SuspendLayout();
                        this.PanelServidorNoInstalado.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // EtiquetaEncab
                        // 
                        this.EtiquetaEncab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaEncab.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        this.EtiquetaEncab.Location = new System.Drawing.Point(24, 24);
                        this.EtiquetaEncab.Name = "EtiquetaEncab";
                        this.EtiquetaEncab.Size = new System.Drawing.Size(544, 40);
                        this.EtiquetaEncab.TabIndex = 0;
                        this.EtiquetaEncab.Text = "Configuración del almacén de datos";
                        this.EtiquetaEncab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaServidor
                        // 
                        this.EntradaServidor.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaServidor.Location = new System.Drawing.Point(192, 164);
                        this.EntradaServidor.Name = "EntradaServidor";
                        this.EntradaServidor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaServidor.ReadOnly = false;
                        this.EntradaServidor.Size = new System.Drawing.Size(272, 25);
                        this.EntradaServidor.TabIndex = 4;
                        this.EntradaServidor.Leave += new System.EventHandler(this.EntradaServidor_Leave);
                        // 
                        // EtiquetaServidor
                        // 
                        this.EtiquetaServidor.Location = new System.Drawing.Point(44, 164);
                        this.EtiquetaServidor.Name = "EtiquetaServidor";
                        this.EtiquetaServidor.Size = new System.Drawing.Size(147, 25);
                        this.EtiquetaServidor.TabIndex = 3;
                        this.EtiquetaServidor.Text = "Nombre del servidor";
                        this.EtiquetaServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.Location = new System.Drawing.Point(24, 120);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(544, 48);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Si ya instaló un servidor SQL en este equipo o en otro equipo de la red, escriba " +
    "aquí los datos del mismo. Estos datos serán guardados para futuros ingresos.";
                        // 
                        // BotonServidorVista
                        // 
                        this.BotonServidorVista.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonServidorVista.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonServidorVista.Image = null;
                        this.BotonServidorVista.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonServidorVista.Location = new System.Drawing.Point(44, 200);
                        this.BotonServidorVista.Name = "BotonServidorVista";
                        this.BotonServidorVista.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonServidorVista.ReadOnly = false;
                        this.BotonServidorVista.Size = new System.Drawing.Size(156, 32);
                        this.BotonServidorVista.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonServidorVista.Subtext = "F8";
                        this.BotonServidorVista.TabIndex = 100;
                        this.BotonServidorVista.Text = "Vista Avanzada >";
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
                        this.PanelServidorAvanzado.Location = new System.Drawing.Point(212, 204);
                        this.PanelServidorAvanzado.Name = "PanelServidorAvanzado";
                        this.PanelServidorAvanzado.Size = new System.Drawing.Size(320, 169);
                        this.PanelServidorAvanzado.TabIndex = 7;
                        this.PanelServidorAvanzado.Visible = false;
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaSucursal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSucursal.Location = new System.Drawing.Point(232, 144);
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.ReadOnly = false;
                        this.EntradaSucursal.Size = new System.Drawing.Size(60, 24);
                        this.EntradaSucursal.TabIndex = 11;
                        this.EntradaSucursal.Text = "1";
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(0, 144);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(232, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "Sucursal predeterminada";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaSlowLink
                        // 
                        this.EntradaSlowLink.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaSlowLink.Location = new System.Drawing.Point(232, 112);
                        this.EntradaSlowLink.Name = "EntradaSlowLink";
                        this.EntradaSlowLink.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSlowLink.ReadOnly = false;
                        this.EntradaSlowLink.Size = new System.Drawing.Size(60, 25);
                        this.EntradaSlowLink.TabIndex = 9;
                        this.EntradaSlowLink.Value = true;
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
                        // EntradaBD
                        // 
                        this.EntradaBD.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaBD.Location = new System.Drawing.Point(124, 28);
                        this.EntradaBD.Name = "EntradaBD";
                        this.EntradaBD.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBD.ReadOnly = false;
                        this.EntradaBD.Size = new System.Drawing.Size(172, 24);
                        this.EntradaBD.TabIndex = 3;
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
                        // EntradaConexion
                        // 
                        this.EntradaConexion.AlwaysExpanded = false;
                        this.EntradaConexion.Location = new System.Drawing.Point(124, 0);
                        this.EntradaConexion.Name = "EntradaConexion";
                        this.EntradaConexion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConexion.ReadOnly = false;
                        this.EntradaConexion.SetData = new string[] {
        "ODBC|odbc",
        "SQLite|sqlite",
        "MySQL|mysql",
        "PostgreSQL|npgsql"};
                        this.EntradaConexion.Size = new System.Drawing.Size(196, 23);
                        this.EntradaConexion.TabIndex = 1;
                        this.EntradaConexion.TextKey = "mysql";
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
                        // EntradaContrasena
                        // 
                        this.EntradaContrasena.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasena.Location = new System.Drawing.Point(124, 84);
                        this.EntradaContrasena.Name = "EntradaContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.Size = new System.Drawing.Size(124, 24);
                        this.EntradaContrasena.TabIndex = 7;
                        // 
                        // EntradaUsuario
                        // 
                        this.EntradaUsuario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUsuario.Location = new System.Drawing.Point(124, 55);
                        this.EntradaUsuario.Name = "EntradaUsuario";
                        this.EntradaUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsuario.ReadOnly = false;
                        this.EntradaUsuario.Size = new System.Drawing.Size(124, 25);
                        this.EntradaUsuario.TabIndex = 5;
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
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Controls.Add(this.OkButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 392);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Padding = new System.Windows.Forms.Padding(12);
                        this.LowerPanel.Size = new System.Drawing.Size(594, 60);
                        this.LowerPanel.TabIndex = 50;
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(466, 12);
                        this.CancelCommandButton.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(104, 36);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.CancelCommandButton.Subtext = "";
                        this.CancelCommandButton.TabIndex = 51;
                        this.CancelCommandButton.Text = "Cancelar";
                        this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(356, 12);
                        this.OkButton.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(104, 36);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.OkButton.Subtext = "F8";
                        this.OkButton.TabIndex = 50;
                        this.OkButton.Text = "Aceptar";
                        this.OkButton.Click += new System.EventHandler(this.BotonAceptar_Click);
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.Location = new System.Drawing.Point(32, 60);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(520, 36);
                        this.Label6.TabIndex = 3;
                        this.Label6.Text = "Si necesita más información sobre la instalación y configuración de un servidor S" +
    "QL como almacén de datos, consulte la siguiente documentación:";
                        // 
                        // EtiquetaServidorCumple
                        // 
                        this.EtiquetaServidorCumple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaServidorCumple.Location = new System.Drawing.Point(32, 36);
                        this.EtiquetaServidorCumple.Name = "EtiquetaServidorCumple";
                        this.EtiquetaServidorCumple.Size = new System.Drawing.Size(520, 20);
                        this.EtiquetaServidorCumple.TabIndex = 2;
                        this.EtiquetaServidorCumple.Text = "Esta PC no cumple con los requisitos.";
                        // 
                        // EtiquetaSubEncab2
                        // 
                        this.EtiquetaSubEncab2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaSubEncab2.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        this.EtiquetaSubEncab2.Location = new System.Drawing.Point(8, 8);
                        this.EtiquetaSubEncab2.Name = "EtiquetaSubEncab2";
                        this.EtiquetaSubEncab2.Size = new System.Drawing.Size(544, 24);
                        this.EtiquetaSubEncab2.TabIndex = 0;
                        this.EtiquetaSubEncab2.Text = "Información sobre el servidor SQL";
                        this.EtiquetaSubEncab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelServidorNoInstalado
                        // 
                        this.PanelServidorNoInstalado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelServidorNoInstalado.Controls.Add(this.BotonGuiaInstalacion);
                        this.PanelServidorNoInstalado.Controls.Add(this.Label6);
                        this.PanelServidorNoInstalado.Controls.Add(this.EtiquetaServidorCumple);
                        this.PanelServidorNoInstalado.Controls.Add(this.EtiquetaSubEncab2);
                        this.PanelServidorNoInstalado.Location = new System.Drawing.Point(16, 244);
                        this.PanelServidorNoInstalado.Name = "PanelServidorNoInstalado";
                        this.PanelServidorNoInstalado.Size = new System.Drawing.Size(563, 132);
                        this.PanelServidorNoInstalado.TabIndex = 11;
                        // 
                        // BotonGuiaInstalacion
                        // 
                        this.BotonGuiaInstalacion.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonGuiaInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonGuiaInstalacion.AutoSize = true;
                        this.BotonGuiaInstalacion.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonGuiaInstalacion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonGuiaInstalacion.Location = new System.Drawing.Point(32, 104);
                        this.BotonGuiaInstalacion.Name = "BotonGuiaInstalacion";
                        this.BotonGuiaInstalacion.Size = new System.Drawing.Size(301, 15);
                        this.BotonGuiaInstalacion.TabIndex = 56;
                        this.BotonGuiaInstalacion.TabStop = true;
                        this.BotonGuiaInstalacion.Text = "Instalación y Mantenimiento: Instalación Inicial";
                        this.BotonGuiaInstalacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.BotonGuiaInstalacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWeb_LinkClicked);
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(24, 64);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(32, 32);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.PictureBox1.TabIndex = 101;
                        this.PictureBox1.TabStop = false;
                        // 
                        // label7
                        // 
                        this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label7.Location = new System.Drawing.Point(64, 64);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(504, 48);
                        this.label7.TabIndex = 102;
                        this.label7.Text = "Es necesario un servidor SQL donde guardar los datos. El servidor SQL puede estar" +
    " en este equipo o en otro equipo si dispone de una conexión de red.";
                        // 
                        // ConfigurarBd
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(594, 452);
                        this.Controls.Add(this.PanelServidorNoInstalado);
                        this.Controls.Add(this.PanelServidorAvanzado);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.LowerPanel);
                        this.Controls.Add(this.BotonServidorVista);
                        this.Controls.Add(this.EntradaServidor);
                        this.Controls.Add(this.EtiquetaEncab);
                        this.Controls.Add(this.EtiquetaServidor);
                        this.Controls.Add(this.Label3);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "ConfigurarBd";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Configurar Acceso a Datos";
                        this.Load += new System.EventHandler(this.ConfigBD_Load);
                        this.PanelServidorAvanzado.ResumeLayout(false);
                        this.LowerPanel.ResumeLayout(false);
                        this.PanelServidorNoInstalado.ResumeLayout(false);
                        this.PanelServidorNoInstalado.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.Label EtiquetaEncab;
                private Lui.Forms.Label Label3;
                private Lui.Forms.TextBox EntradaServidor;
                private Lui.Forms.Label EtiquetaServidor;
                private Lui.Forms.Panel PanelServidorAvanzado;
                private Lui.Forms.TextBox EntradaBD;
                private Lui.Forms.Label Label2;
                private Lui.Forms.ComboBox EntradaConexion;
                private Lui.Forms.Label Label1;
                private Lui.Forms.TextBox EntradaContrasena;
                private Lui.Forms.TextBox EntradaUsuario;
                private Lui.Forms.Label Label28;
                private Lui.Forms.Label Label29;
                private Lui.Forms.Button BotonServidorVista;
                private Lui.Forms.ButtonPanel LowerPanel;
                private Lui.Forms.Button CancelCommandButton;
                private Lui.Forms.Button OkButton;
                private Lui.Forms.Label Label6;
                private Lui.Forms.Label EtiquetaServidorCumple;
                private Lui.Forms.Label EtiquetaSubEncab2;
                private Lui.Forms.Label label4;
                private Lui.Forms.YesNo EntradaSlowLink;
                private Lui.Forms.TextBox EntradaSucursal;
                private Lui.Forms.Label label5;
                private System.Windows.Forms.PictureBox PictureBox1;
                private Lui.Forms.Label label7;
                private Lui.Forms.Panel PanelServidorNoInstalado;
                private Lui.Forms.LinkLabel BotonGuiaInstalacion;
        }
}