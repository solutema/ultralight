#region License
// Copyright 2004-2011 Ernesto N. Carrea
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


namespace Lazaro.Misc.Config
{
        public partial class ConfigurarBd
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

                private void InitializeComponent()
                {
                        this.EtiquetaEncab = new Lui.Forms.LabelH1();
                        this.EntradaServidor = new Lui.Forms.TextBox();
                        this.EtiquetaServidor = new System.Windows.Forms.Label();
                        this.EtiquetaSubEncab1 = new Lui.Forms.LabelH2();
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
                        this.EtiquetaSubEncab2 = new Lui.Forms.LabelH2();
                        this.PanelServidorNoInstalado = new System.Windows.Forms.Panel();
                        this.BotonGuiaInstalacion = new System.Windows.Forms.LinkLabel();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.label7 = new System.Windows.Forms.Label();
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
                        this.EtiquetaEncab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(202)))), ((int)(((byte)(174)))));
                        this.EtiquetaEncab.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaEncab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EtiquetaEncab.Location = new System.Drawing.Point(20, 21);
                        this.EtiquetaEncab.Name = "EtiquetaEncab";
                        this.EtiquetaEncab.Size = new System.Drawing.Size(555, 27);
                        this.EtiquetaEncab.TabIndex = 0;
                        this.EtiquetaEncab.Text = "Configuración del almacén de datos";
                        this.EtiquetaEncab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaServidor
                        // 
                        this.EntradaServidor.AutoNav = true;
                        this.EntradaServidor.AutoTab = true;
                        this.EntradaServidor.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaServidor.DecimalPlaces = -1;
                        this.EntradaServidor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaServidor.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaServidor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaServidor.Location = new System.Drawing.Point(192, 172);
                        this.EntradaServidor.MaxLenght = 32767;
                        this.EntradaServidor.MultiLine = false;
                        this.EntradaServidor.Name = "EntradaServidor";
                        this.EntradaServidor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaServidor.PasswordChar = '\0';
                        this.EntradaServidor.Prefijo = "";
                        this.EntradaServidor.SelectOnFocus = false;
                        this.EntradaServidor.Size = new System.Drawing.Size(196, 25);
                        this.EntradaServidor.Sufijo = "";
                        this.EntradaServidor.TabIndex = 4;
                        this.EntradaServidor.PlaceholderText = "";
                        this.EntradaServidor.ToolTipText = "";
                        this.EntradaServidor.Leave += new System.EventHandler(this.EntradaServidor_Leave);
                        // 
                        // EtiquetaServidor
                        // 
                        this.EtiquetaServidor.Location = new System.Drawing.Point(44, 172);
                        this.EtiquetaServidor.Name = "EtiquetaServidor";
                        this.EtiquetaServidor.Size = new System.Drawing.Size(147, 25);
                        this.EtiquetaServidor.TabIndex = 3;
                        this.EtiquetaServidor.Text = "Nombre del servidor";
                        this.EtiquetaServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaSubEncab1
                        // 
                        this.EtiquetaSubEncab1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaSubEncab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(206)))), ((int)(((byte)(220)))));
                        this.EtiquetaSubEncab1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaSubEncab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
                        this.EtiquetaSubEncab1.Location = new System.Drawing.Point(20, 96);
                        this.EtiquetaSubEncab1.Name = "EtiquetaSubEncab1";
                        this.EtiquetaSubEncab1.Size = new System.Drawing.Size(555, 24);
                        this.EtiquetaSubEncab1.TabIndex = 1;
                        this.EtiquetaSubEncab1.Text = "Si ya dispone de un servidor";
                        this.EtiquetaSubEncab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.Location = new System.Drawing.Point(20, 128);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(555, 36);
                        this.Label3.TabIndex = 2;
                        this.Label3.Text = "Si ya instaló un servidor SQL en este equipo o en otro equipo de la red, escriba " +
                            "aquí los datos del mismo. Estos datos serán guardados para futuros ingresos.";
                        // 
                        // BotonServidorVista
                        // 
                        this.BotonServidorVista.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonServidorVista.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.BotonServidorVista.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonServidorVista.Image = null;
                        this.BotonServidorVista.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonServidorVista.Location = new System.Drawing.Point(44, 201);
                        this.BotonServidorVista.Name = "BotonServidorVista";
                        this.BotonServidorVista.Padding = new System.Windows.Forms.Padding(2);
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
                        this.PanelServidorAvanzado.Location = new System.Drawing.Point(188, 204);
                        this.PanelServidorAvanzado.Name = "PanelServidorAvanzado";
                        this.PanelServidorAvanzado.Size = new System.Drawing.Size(320, 169);
                        this.PanelServidorAvanzado.TabIndex = 7;
                        this.PanelServidorAvanzado.Visible = false;
                        // 
                        // EntradaSucursal
                        // 
                        this.EntradaSucursal.AutoNav = true;
                        this.EntradaSucursal.AutoTab = true;
                        this.EntradaSucursal.DataType = Lui.Forms.DataTypes.Integer;
                        this.EntradaSucursal.DecimalPlaces = -1;
                        this.EntradaSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaSucursal.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSucursal.Location = new System.Drawing.Point(232, 144);
                        this.EntradaSucursal.MaxLenght = 32767;
                        this.EntradaSucursal.MultiLine = false;
                        this.EntradaSucursal.Name = "EntradaSucursal";
                        this.EntradaSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSucursal.PasswordChar = '\0';
                        this.EntradaSucursal.Prefijo = "";
                        this.EntradaSucursal.SelectOnFocus = true;
                        this.EntradaSucursal.Size = new System.Drawing.Size(60, 24);
                        this.EntradaSucursal.Sufijo = "";
                        this.EntradaSucursal.TabIndex = 11;
                        this.EntradaSucursal.Text = "1";
                        this.EntradaSucursal.PlaceholderText = "";
                        this.EntradaSucursal.ToolTipText = "";
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
                        this.EntradaSlowLink.AlwaysExpanded = false;
                        this.EntradaSlowLink.AutoNav = true;
                        this.EntradaSlowLink.AutoTab = true;
                        this.EntradaSlowLink.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaSlowLink.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaSlowLink.Location = new System.Drawing.Point(232, 112);
                        this.EntradaSlowLink.MaxLenght = 32767;
                        this.EntradaSlowLink.Name = "EntradaSlowLink";
                        this.EntradaSlowLink.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaSlowLink.SetData = new string[] {
        "Si|1",
        "No|0"};
                        this.EntradaSlowLink.Size = new System.Drawing.Size(60, 25);
                        this.EntradaSlowLink.TabIndex = 9;
                        this.EntradaSlowLink.TextKey = "0";
                        this.EntradaSlowLink.PlaceholderText = "";
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
                        // EntradaBD
                        // 
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
                        this.EntradaBD.Name = "EntradaBD";
                        this.EntradaBD.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBD.PasswordChar = '\0';
                        this.EntradaBD.Prefijo = "";
                        this.EntradaBD.SelectOnFocus = true;
                        this.EntradaBD.Size = new System.Drawing.Size(172, 24);
                        this.EntradaBD.Sufijo = "";
                        this.EntradaBD.TabIndex = 3;
                        this.EntradaBD.PlaceholderText = "";
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
                        // EntradaConexion
                        // 
                        this.EntradaConexion.AlwaysExpanded = false;
                        this.EntradaConexion.AutoNav = true;
                        this.EntradaConexion.AutoTab = true;
                        this.EntradaConexion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.EntradaConexion.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaConexion.Location = new System.Drawing.Point(124, 0);
                        this.EntradaConexion.MaxLenght = 32767;
                        this.EntradaConexion.Name = "EntradaConexion";
                        this.EntradaConexion.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConexion.SetData = new string[] {
        "ODBC|odbc",
        "MySQL|mysql",
        "PostgreSQL|npgsql"};
                        this.EntradaConexion.Size = new System.Drawing.Size(196, 23);
                        this.EntradaConexion.TabIndex = 1;
                        this.EntradaConexion.TextKey = "mysql";
                        this.EntradaConexion.PlaceholderText = "";
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
                        // EntradaContrasena
                        // 
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
                        this.EntradaContrasena.Name = "EntradaContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.Prefijo = "";
                        this.EntradaContrasena.SelectOnFocus = true;
                        this.EntradaContrasena.Size = new System.Drawing.Size(124, 24);
                        this.EntradaContrasena.Sufijo = "";
                        this.EntradaContrasena.TabIndex = 7;
                        this.EntradaContrasena.PlaceholderText = "";
                        this.EntradaContrasena.ToolTipText = "";
                        // 
                        // EntradaUsuario
                        // 
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
                        this.EntradaUsuario.Name = "EntradaUsuario";
                        this.EntradaUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsuario.PasswordChar = '\0';
                        this.EntradaUsuario.Prefijo = "";
                        this.EntradaUsuario.SelectOnFocus = true;
                        this.EntradaUsuario.Size = new System.Drawing.Size(124, 25);
                        this.EntradaUsuario.Sufijo = "";
                        this.EntradaUsuario.TabIndex = 5;
                        this.EntradaUsuario.PlaceholderText = "";
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
                        this.GCommand1.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.GCommand1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.GCommand1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.GCommand1.Image = null;
                        this.GCommand1.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.GCommand1.Location = new System.Drawing.Point(392, 173);
                        this.GCommand1.Name = "GCommand1";
                        this.GCommand1.Padding = new System.Windows.Forms.Padding(2);
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
                        this.LowerPanel.Location = new System.Drawing.Point(0, 388);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(594, 64);
                        this.LowerPanel.TabIndex = 50;
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(360, 16);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.Size = new System.Drawing.Size(104, 32);
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
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(472, 16);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.Size = new System.Drawing.Size(104, 32);
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
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(4, 60);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(555, 36);
                        this.Label6.TabIndex = 3;
                        this.Label6.Text = "Si necesita más información sobre la instalación y configuración de un servidor S" +
                            "QL como almacén de datos, consulte la siguiente documentación en la web:";
                        // 
                        // EtiquetaServidorCumple
                        // 
                        this.EtiquetaServidorCumple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaServidorCumple.Location = new System.Drawing.Point(4, 36);
                        this.EtiquetaServidorCumple.Name = "EtiquetaServidorCumple";
                        this.EtiquetaServidorCumple.Size = new System.Drawing.Size(555, 20);
                        this.EtiquetaServidorCumple.TabIndex = 2;
                        this.EtiquetaServidorCumple.Text = "Esta PC no cumple con los requisitos.";
                        // 
                        // EtiquetaSubEncab2
                        // 
                        this.EtiquetaSubEncab2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaSubEncab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(206)))), ((int)(((byte)(220)))));
                        this.EtiquetaSubEncab2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaSubEncab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
                        this.EtiquetaSubEncab2.Location = new System.Drawing.Point(3, 6);
                        this.EtiquetaSubEncab2.Name = "EtiquetaSubEncab2";
                        this.EtiquetaSubEncab2.Size = new System.Drawing.Size(555, 24);
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
                        this.PanelServidorNoInstalado.Size = new System.Drawing.Size(563, 128);
                        this.PanelServidorNoInstalado.TabIndex = 11;
                        // 
                        // BotonGuiaInstalacion
                        // 
                        this.BotonGuiaInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonGuiaInstalacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonGuiaInstalacion.Location = new System.Drawing.Point(4, 100);
                        this.BotonGuiaInstalacion.Name = "BotonGuiaInstalacion";
                        this.BotonGuiaInstalacion.Size = new System.Drawing.Size(368, 20);
                        this.BotonGuiaInstalacion.TabIndex = 56;
                        this.BotonGuiaInstalacion.TabStop = true;
                        this.BotonGuiaInstalacion.Text = "Instalación y Mantenimiento: Instalación Inicial";
                        this.BotonGuiaInstalacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.BotonGuiaInstalacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWeb_LinkClicked);
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = global::Lazaro.Properties.Resources.drive_harddisk;
                        this.PictureBox1.Location = new System.Drawing.Point(24, 56);
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
                        this.label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label7.Location = new System.Drawing.Point(64, 56);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(511, 32);
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
                        this.Controls.Add(this.GCommand1);
                        this.Controls.Add(this.BotonServidorVista);
                        this.Controls.Add(this.EntradaServidor);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.EtiquetaSubEncab1);
                        this.Controls.Add(this.EtiquetaEncab);
                        this.Controls.Add(this.EtiquetaServidor);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "ConfigurarBd";
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

                private Lui.Forms.LabelH1 EtiquetaEncab;
                private System.Windows.Forms.Label Label3;
                private Lui.Forms.LabelH2 EtiquetaSubEncab1;
                private Lui.Forms.TextBox EntradaServidor;
                private System.Windows.Forms.Label EtiquetaServidor;
                private System.Windows.Forms.Panel PanelServidorAvanzado;
                private Lui.Forms.TextBox EntradaBD;
                private System.Windows.Forms.Label Label2;
                private Lui.Forms.ComboBox EntradaConexion;
                private System.Windows.Forms.Label Label1;
                private Lui.Forms.TextBox EntradaContrasena;
                private Lui.Forms.TextBox EntradaUsuario;
                private System.Windows.Forms.Label Label28;
                private System.Windows.Forms.Label Label29;
                private Lui.Forms.Button BotonServidorVista;
                private Lui.Forms.Button GCommand1;
                private System.Windows.Forms.Panel LowerPanel;
                private Lui.Forms.Button CancelCommandButton;
                private Lui.Forms.Button OkButton;
                private System.Windows.Forms.Label Label6;
                private System.Windows.Forms.Label EtiquetaServidorCumple;
                private Lui.Forms.LabelH2 EtiquetaSubEncab2;
                private System.Windows.Forms.Label label4;
                private Lui.Forms.ComboBox EntradaSlowLink;
                private Lui.Forms.TextBox EntradaSucursal;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.PictureBox PictureBox1;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.Panel PanelServidorNoInstalado;
                private System.Windows.Forms.LinkLabel BotonGuiaInstalacion;
        }
}
