using System;
using System.Collections;
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.Label3 = new System.Windows.Forms.Label();
                        this.lblActualizar = new System.Windows.Forms.LinkLabel();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.EtiquetaUsuario = new System.Windows.Forms.Label();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.OkButton = new Lui.Forms.Button();
                        this.label11 = new System.Windows.Forms.Label();
                        this.ListaComponentes = new System.Windows.Forms.ListBox();
                        this.EtiquetaFramework = new System.Windows.Forms.Label();
                        this.Label7 = new System.Windows.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(16, 20);
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
                        this.Label1.Location = new System.Drawing.Point(88, 44);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(534, 16);
                        this.Label1.TabIndex = 2;
                        this.Label1.Text = "Lázaro Copyright  2004-2007 Carrea Martínez S.D.H.";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label2
                        // 
                        this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label2.Location = new System.Drawing.Point(88, 60);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(534, 16);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Todos los derechos reservados.";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label3.Location = new System.Drawing.Point(88, 20);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(92, 24);
                        this.Label3.TabIndex = 6;
                        this.Label3.Text = "Lázaro";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblActualizar
                        // 
                        this.lblActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.lblActualizar.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblActualizar.Location = new System.Drawing.Point(16, 364);
                        this.lblActualizar.Name = "lblActualizar";
                        this.lblActualizar.Size = new System.Drawing.Size(212, 16);
                        this.lblActualizar.TabIndex = 8;
                        this.lblActualizar.TabStop = true;
                        this.lblActualizar.Text = "Buscar actualizaciones ahora";
                        this.lblActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.lblActualizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblActualizar_LinkClicked);
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label5.Location = new System.Drawing.Point(16, 92);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(605, 32);
                        this.Label5.TabIndex = 9;
                        this.Label5.Text = "Incluye fuentes \"Bitstream Vera\" Copyright  2003 by Bitstream, Inc. All Rights Re" +
                            "served. Bitstream Vera is a trademark of Bitstream, Inc.";
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.Location = new System.Drawing.Point(16, 184);
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
                        this.EtiquetaUsuario.Location = new System.Drawing.Point(100, 184);
                        this.EtiquetaUsuario.Name = "EtiquetaUsuario";
                        this.EtiquetaUsuario.Size = new System.Drawing.Size(360, 16);
                        this.EtiquetaUsuario.TabIndex = 12;
                        this.EtiquetaUsuario.Text = "...";
                        this.EtiquetaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.EtiquetaUsuario.UseMnemonic = false;
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label8.Location = new System.Drawing.Point(16, 128);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(605, 16);
                        this.Label8.TabIndex = 14;
                        this.Label8.Text = "Incluye SharpZipLib, Copyright ©2000-2009 IC#Code.";
                        // 
                        // Label10
                        // 
                        this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label10.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label10.Location = new System.Drawing.Point(16, 216);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(84, 16);
                        this.Label10.TabIndex = 15;
                        this.Label10.Text = "ID Instalación";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label9
                        // 
                        this.label9.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label9.Location = new System.Drawing.Point(176, 26);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(60, 16);
                        this.label9.TabIndex = 17;
                        this.label9.Text = "NLWC";
                        this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.AutoHeight = false;
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
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
                        // label11
                        // 
                        this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label11.Location = new System.Drawing.Point(16, 148);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(605, 32);
                        this.label11.TabIndex = 21;
                        this.label11.Text = "Incluye gráficos del Tango Desktop Project. Más información en tango.freedesktop." +
                            "org.";
                        // 
                        // ListaComponentes
                        // 
                        this.ListaComponentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.ListaComponentes.BackColor = System.Drawing.SystemColors.Control;
                        this.ListaComponentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaComponentes.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.ListaComponentes.FormattingEnabled = true;
                        this.ListaComponentes.IntegralHeight = false;
                        this.ListaComponentes.Location = new System.Drawing.Point(16, 236);
                        this.ListaComponentes.Name = "ListaComponentes";
                        this.ListaComponentes.Size = new System.Drawing.Size(444, 120);
                        this.ListaComponentes.TabIndex = 22;
                        this.ListaComponentes.TabStop = false;
                        // 
                        // EtiquetaFramework
                        // 
                        this.EtiquetaFramework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaFramework.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EtiquetaFramework.Location = new System.Drawing.Point(100, 200);
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
                        this.Label7.Location = new System.Drawing.Point(16, 200);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(84, 16);
                        this.Label7.TabIndex = 11;
                        this.Label7.Text = "Framework";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // AcercaDe
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 394);
                        this.ControlBox = false;
                        this.Controls.Add(this.ListaComponentes);
                        this.Controls.Add(this.label11);
                        this.Controls.Add(this.label9);
                        this.Controls.Add(this.Label10);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.EtiquetaFramework);
                        this.Controls.Add(this.EtiquetaUsuario);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.lblActualizar);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.OkButton);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.KeyPreview = true;
                        this.Name = "AcercaDe";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "";
                        this.Load += new System.EventHandler(this.FormAcercaDe_Load);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAcercaDe_KeyDown);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion



                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;
                private System.Windows.Forms.PictureBox PictureBox1;
                private System.Windows.Forms.Label Label1;
                private System.Windows.Forms.Label Label2;
                private System.Windows.Forms.Label Label3;
                private System.Windows.Forms.LinkLabel lblActualizar;
                private System.Windows.Forms.Label Label5;
                private System.Windows.Forms.Label Label6;
                private System.Windows.Forms.Label EtiquetaUsuario;
                private System.Windows.Forms.Label Label8;
                private System.Windows.Forms.Label label9;
                private Lui.Forms.Button OkButton;
                private Label label11;
                private ListBox ListaComponentes;
                private System.Windows.Forms.Label Label10;
                private Label EtiquetaFramework;
                private Label Label7;

        }
}
