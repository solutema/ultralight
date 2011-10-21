using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc
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
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.EtiquetaActualizar = new System.Windows.Forms.LinkLabel();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EtiquetaUsuario = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.OkButton = new Lui.Forms.Button();
                        this.ListaComponentes = new System.Windows.Forms.ListBox();
                        this.EtiquetaFramework = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.pictureBox2 = new System.Windows.Forms.PictureBox();
                        this.BotonWeb = new System.Windows.Forms.LinkLabel();
                        this.TimerBuscarActualizaciones = new System.Windows.Forms.Timer(this.components);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(112, 20);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(64, 64);
                        this.PictureBox1.TabIndex = 1;
                        this.PictureBox1.TabStop = false;
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label1.Location = new System.Drawing.Point(184, 48);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(436, 16);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Copyright 2004-2011 Ernesto N. Carrea. Todos los derechos reservados.";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(184, 24);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(92, 24);
                        this.Label3.TabIndex = 6;
                        this.Label3.Text = "Lázaro";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaActualizar
                        // 
                        this.EtiquetaActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaActualizar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaActualizar.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
                        this.EtiquetaActualizar.Location = new System.Drawing.Point(112, 364);
                        this.EtiquetaActualizar.Name = "EtiquetaActualizar";
                        this.EtiquetaActualizar.Size = new System.Drawing.Size(384, 16);
                        this.EtiquetaActualizar.TabIndex = 8;
                        this.EtiquetaActualizar.Text = "Buscar actualizaciones ahora";
                        this.EtiquetaActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaActualizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BotonActualizar_LinkClicked);
                        this.EtiquetaActualizar.Click += new System.EventHandler(this.EtiquetaActualizar_Click);
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label5.Location = new System.Drawing.Point(112, 104);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(520, 96);
                        this.Label5.TabIndex = 9;
                        this.Label5.Text = resources.GetString("Label5.Text");
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(112, 212);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(84, 16);
                        this.Label6.TabIndex = 10;
                        this.Label6.Text = "Usuario / Est.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaUsuario
                        // 
                        this.EtiquetaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaUsuario.Location = new System.Drawing.Point(196, 212);
                        this.EtiquetaUsuario.Name = "EtiquetaUsuario";
                        this.EtiquetaUsuario.Size = new System.Drawing.Size(360, 16);
                        this.EtiquetaUsuario.TabIndex = 12;
                        this.EtiquetaUsuario.Text = "...";
                        this.EtiquetaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaUsuario.UseMnemonic = false;
                        // 
                        // label9
                        // 
                        this.label9.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label9.Location = new System.Drawing.Point(272, 30);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(60, 16);
                        this.label9.TabIndex = 17;
                        this.label9.Text = "2011";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(508, 336);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(110, 44);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.OkButton.Subtext = "Esc";
                        this.OkButton.TabIndex = 0;
                        this.OkButton.Text = "Volver";
                        this.OkButton.ToolTipText = "";
                        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                        // 
                        // ListaComponentes
                        // 
                        this.ListaComponentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ListaComponentes.BackColor = System.Drawing.SystemColors.Control;
                        this.ListaComponentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaComponentes.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ListaComponentes.FormattingEnabled = true;
                        this.ListaComponentes.IntegralHeight = false;
                        this.ListaComponentes.Location = new System.Drawing.Point(112, 252);
                        this.ListaComponentes.Name = "ListaComponentes";
                        this.ListaComponentes.Size = new System.Drawing.Size(384, 104);
                        this.ListaComponentes.TabIndex = 22;
                        this.ListaComponentes.TabStop = false;
                        // 
                        // EtiquetaFramework
                        // 
                        this.EtiquetaFramework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaFramework.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaFramework.Location = new System.Drawing.Point(196, 228);
                        this.EtiquetaFramework.Name = "EtiquetaFramework";
                        this.EtiquetaFramework.Size = new System.Drawing.Size(360, 16);
                        this.EtiquetaFramework.TabIndex = 13;
                        this.EtiquetaFramework.Text = "...";
                        this.EtiquetaFramework.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaFramework.UseMnemonic = false;
                        // 
                        // Label7
                        // 
                        this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label7.Location = new System.Drawing.Point(112, 228);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(84, 16);
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
                        this.panel1.Size = new System.Drawing.Size(100, 394);
                        this.panel1.TabIndex = 54;
                        // 
                        // pictureBox2
                        // 
                        this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
                        this.pictureBox2.Location = new System.Drawing.Point(20, 254);
                        this.pictureBox2.Name = "pictureBox2";
                        this.pictureBox2.Size = new System.Drawing.Size(37, 120);
                        this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.pictureBox2.TabIndex = 51;
                        this.pictureBox2.TabStop = false;
                        // 
                        // BotonWeb
                        // 
                        this.BotonWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonWeb.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonWeb.Location = new System.Drawing.Point(184, 64);
                        this.BotonWeb.Name = "BotonWeb";
                        this.BotonWeb.Size = new System.Drawing.Size(192, 16);
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
                        // AcercaDe
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.CancelButton = this.OkButton;
                        this.ClientSize = new System.Drawing.Size(634, 394);
                        this.Controls.Add(this.BotonWeb);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.ListaComponentes);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.EtiquetaFramework);
                        this.Controls.Add(this.EtiquetaUsuario);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.EtiquetaActualizar);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.OkButton);
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
                        this.ResumeLayout(false);

                }

                #endregion



                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.IContainer components = null;
                private System.Windows.Forms.PictureBox PictureBox1;
                private System.Windows.Forms.Label Label1;
                private System.Windows.Forms.Label Label3;
                private System.Windows.Forms.LinkLabel EtiquetaActualizar;
                private System.Windows.Forms.Label Label5;
                private System.Windows.Forms.Label Label6;
                private System.Windows.Forms.Label EtiquetaUsuario;
                private System.Windows.Forms.Label label9;
                private Lui.Forms.Button OkButton;
                private ListBox ListaComponentes;
                private Label EtiquetaFramework;
                private Label Label7;
                private Panel panel1;
                internal PictureBox pictureBox2;
                private LinkLabel BotonWeb;
                private Timer TimerBuscarActualizaciones;

        }
}
