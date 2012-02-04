using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.WinMain.Misc
{
        public partial class AcercaDe : Lui.Forms.Form
        {
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

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.EtiquetaCopyright = new Lui.Forms.Label();
                        this.EtiquetaNombreAplicacion = new System.Windows.Forms.Label();
                        this.EtiquetaActualizar = new Lui.Forms.LinkLabel();
                        this.EtiquetaCreditos = new Lui.Forms.Label();
                        this.Label6 = new Lui.Forms.Label();
                        this.EtiquetaUsuario = new Lui.Forms.Label();
                        this.OkButton = new Lui.Forms.Button();
                        this.ListaComponentes = new System.Windows.Forms.ListBox();
                        this.EtiquetaFramework = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.panel1 = new Lui.Forms.Panel();
                        this.pictureBox2 = new System.Windows.Forms.PictureBox();
                        this.BotonWeb = new Lui.Forms.LinkLabel();
                        this.TimerBuscarActualizaciones = new System.Windows.Forms.Timer(this.components);
                        this.PicEsperar = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PicEsperar)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(112, 20);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(64, 63);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.PictureBox1.TabIndex = 1;
                        this.PictureBox1.TabStop = false;
                        // 
                        // EtiquetaCopyright
                        // 
                        this.EtiquetaCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaCopyright.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.EtiquetaCopyright.Location = new System.Drawing.Point(184, 48);
                        this.EtiquetaCopyright.Name = "EtiquetaCopyright";
                        this.EtiquetaCopyright.Size = new System.Drawing.Size(431, 16);
                        this.EtiquetaCopyright.TabIndex = 2;
                        this.EtiquetaCopyright.Text = "Copyright 2004-2012 Ernesto N. Carrea. Todos los derechos reservados.";
                        this.EtiquetaCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaNombreAplicacion
                        // 
                        this.EtiquetaNombreAplicacion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaNombreAplicacion.Location = new System.Drawing.Point(184, 20);
                        this.EtiquetaNombreAplicacion.Name = "EtiquetaNombreAplicacion";
                        this.EtiquetaNombreAplicacion.Size = new System.Drawing.Size(156, 28);
                        this.EtiquetaNombreAplicacion.TabIndex = 6;
                        this.EtiquetaNombreAplicacion.Text = "Lázaro";
                        this.EtiquetaNombreAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaActualizar
                        // 
                        this.EtiquetaActualizar.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.EtiquetaActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaActualizar.AutoSize = true;
                        this.EtiquetaActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.EtiquetaActualizar.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
                        this.EtiquetaActualizar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.EtiquetaActualizar.Location = new System.Drawing.Point(132, 344);
                        this.EtiquetaActualizar.Name = "EtiquetaActualizar";
                        this.EtiquetaActualizar.Size = new System.Drawing.Size(82, 15);
                        this.EtiquetaActualizar.TabIndex = 8;
                        this.EtiquetaActualizar.Text = "Buscando...";
                        this.EtiquetaActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaActualizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonActualizar_LinkClicked);
                        this.EtiquetaActualizar.Click += new System.EventHandler(this.EtiquetaActualizar_Click);
                        // 
                        // EtiquetaCreditos
                        // 
                        this.EtiquetaCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaCreditos.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.EtiquetaCreditos.Location = new System.Drawing.Point(112, 92);
                        this.EtiquetaCreditos.Name = "EtiquetaCreditos";
                        this.EtiquetaCreditos.Size = new System.Drawing.Size(503, 92);
                        this.EtiquetaCreditos.TabIndex = 9;
                        this.EtiquetaCreditos.Text = resources.GetString("EtiquetaCreditos.Text");
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.Label6.Location = new System.Drawing.Point(112, 191);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(123, 16);
                        this.Label6.TabIndex = 10;
                        this.Label6.Text = "Usuario / Est.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaUsuario
                        // 
                        this.EtiquetaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaUsuario.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.EtiquetaUsuario.Location = new System.Drawing.Point(235, 191);
                        this.EtiquetaUsuario.Name = "EtiquetaUsuario";
                        this.EtiquetaUsuario.Size = new System.Drawing.Size(381, 16);
                        this.EtiquetaUsuario.TabIndex = 12;
                        this.EtiquetaUsuario.Text = "...";
                        this.EtiquetaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaUsuario.UseMnemonic = false;
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(504, 304);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(109, 44);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.OkButton.Subtext = "Esc";
                        this.OkButton.TabIndex = 0;
                        this.OkButton.Text = "Volver";
                        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                        // 
                        // ListaComponentes
                        // 
                        this.ListaComponentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ListaComponentes.BackColor = System.Drawing.SystemColors.Window;
                        this.ListaComponentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaComponentes.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.ListaComponentes.FormattingEnabled = true;
                        this.ListaComponentes.IntegralHeight = false;
                        this.ListaComponentes.ItemHeight = 14;
                        this.ListaComponentes.Location = new System.Drawing.Point(112, 230);
                        this.ListaComponentes.Name = "ListaComponentes";
                        this.ListaComponentes.Size = new System.Drawing.Size(376, 104);
                        this.ListaComponentes.TabIndex = 22;
                        this.ListaComponentes.TabStop = false;
                        // 
                        // EtiquetaFramework
                        // 
                        this.EtiquetaFramework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaFramework.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.EtiquetaFramework.Location = new System.Drawing.Point(235, 207);
                        this.EtiquetaFramework.Name = "EtiquetaFramework";
                        this.EtiquetaFramework.Size = new System.Drawing.Size(381, 16);
                        this.EtiquetaFramework.TabIndex = 13;
                        this.EtiquetaFramework.Text = "...";
                        this.EtiquetaFramework.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaFramework.UseMnemonic = false;
                        // 
                        // Label7
                        // 
                        this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label7.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.Label7.Location = new System.Drawing.Point(112, 207);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(123, 16);
                        this.Label7.TabIndex = 11;
                        this.Label7.Text = "Framework";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // panel1
                        // 
                        this.panel1.BackColor = System.Drawing.Color.White;
                        this.panel1.Controls.Add(this.pictureBox2);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
                        this.panel1.Location = new System.Drawing.Point(0, 0);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(100, 372);
                        this.panel1.TabIndex = 54;
                        // 
                        // pictureBox2
                        // 
                        this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
                        this.pictureBox2.Location = new System.Drawing.Point(21, 214);
                        this.pictureBox2.Name = "pictureBox2";
                        this.pictureBox2.Size = new System.Drawing.Size(37, 120);
                        this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.pictureBox2.TabIndex = 51;
                        this.pictureBox2.TabStop = false;
                        // 
                        // BotonWeb
                        // 
                        this.BotonWeb.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
                        this.BotonWeb.AutoSize = true;
                        this.BotonWeb.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        this.BotonWeb.Location = new System.Drawing.Point(184, 64);
                        this.BotonWeb.Name = "BotonWeb";
                        this.BotonWeb.Size = new System.Drawing.Size(177, 15);
                        this.BotonWeb.TabIndex = 55;
                        this.BotonWeb.TabStop = true;
                        this.BotonWeb.Text = "www.sistemalazaro.com.ar";
                        this.BotonWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.BotonWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonWeb_LinkClicked);
                        // 
                        // TimerBuscarActualizaciones
                        // 
                        this.TimerBuscarActualizaciones.Enabled = true;
                        this.TimerBuscarActualizaciones.Interval = 1000;
                        this.TimerBuscarActualizaciones.Tick += new System.EventHandler(this.TimerBuscarActualizaciones_Tick);
                        // 
                        // PicEsperar
                        // 
                        this.PicEsperar.Image = ((System.Drawing.Image)(resources.GetObject("PicEsperar.Image")));
                        this.PicEsperar.Location = new System.Drawing.Point(112, 344);
                        this.PicEsperar.Name = "PicEsperar";
                        this.PicEsperar.Size = new System.Drawing.Size(16, 16);
                        this.PicEsperar.TabIndex = 69;
                        this.PicEsperar.TabStop = false;
                        // 
                        // AcercaDe
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.CancelButton = this.OkButton;
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.PicEsperar);
                        this.Controls.Add(this.BotonWeb);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.ListaComponentes);
                        this.Controls.Add(this.EtiquetaFramework);
                        this.Controls.Add(this.EtiquetaUsuario);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.EtiquetaCreditos);
                        this.Controls.Add(this.EtiquetaActualizar);
                        this.Controls.Add(this.EtiquetaNombreAplicacion);
                        this.Controls.Add(this.EtiquetaCopyright);
                        this.Controls.Add(this.OkButton);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "AcercaDe";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Acerca de Lázaro";
                        this.Load += new System.EventHandler(this.FormAcercaDe_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.PicEsperar)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Label EtiquetaNombreAplicacion;
                private System.ComponentModel.IContainer components = null;
                private System.Windows.Forms.PictureBox PictureBox1;
                private Lui.Forms.Label EtiquetaCopyright;
                private Lui.Forms.LinkLabel EtiquetaActualizar;
                private Lui.Forms.Label EtiquetaCreditos;
                private Lui.Forms.Label Label6;
                private Lui.Forms.Label EtiquetaUsuario;
                private Lui.Forms.Button OkButton;
                private ListBox ListaComponentes;
                private Panel panel1;
                private PictureBox pictureBox2;
                private Timer TimerBuscarActualizaciones;
                private Lui.Forms.Label EtiquetaFramework;
                private Lui.Forms.Label Label7;
                private Lui.Forms.LinkLabel BotonWeb;
                private PictureBox PicEsperar;

        }
}
