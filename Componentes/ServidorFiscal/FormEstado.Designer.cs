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

using System;
using System.Collections.Generic;

namespace ServidorFiscal
{
        public partial class FormEstado
        {
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                                this.QuitarIcono();
                        }
                        base.Dispose(disposing);
                }

                private System.ComponentModel.IContainer components = null;

                #region Código generado por el Diseñador de Windows Forms

                internal System.Windows.Forms.NotifyIcon IconoBandeja;
                internal System.Windows.Forms.ContextMenu MenuContextual;
                internal System.Windows.Forms.MenuItem MenuCerrar;
                internal System.Windows.Forms.MenuItem MenuOcultar;
                internal System.Windows.Forms.MenuItem MenuItem1;
                internal Lui.Forms.Label label1;
                internal Lui.Forms.Label EtiquetaEstado;
                internal Lui.Forms.Label EtiquetaModeloImpresora;
                internal Lui.Forms.Label label4;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.Label label5;
                internal Lui.Forms.Label lblEstadoFiscal;
                internal Lui.Forms.Label EtiquetaPV;
                internal Lui.Forms.Label label7;
                internal Lui.Forms.Label EtiquetaVersion;
                internal Lui.Forms.Label label8;
                internal System.Windows.Forms.MenuItem MenuReiniciar;

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstado));
                        this.IconoBandeja = new System.Windows.Forms.NotifyIcon(this.components);
                        this.MenuContextual = new System.Windows.Forms.ContextMenu();
                        this.MenuOcultar = new System.Windows.Forms.MenuItem();
                        this.MenuItem1 = new System.Windows.Forms.MenuItem();
                        this.MenuCerrar = new System.Windows.Forms.MenuItem();
                        this.MenuReiniciar = new System.Windows.Forms.MenuItem();
                        this.label1 = new Lui.Forms.Label();
                        this.EtiquetaEstado = new Lui.Forms.Label();
                        this.EtiquetaModeloImpresora = new Lui.Forms.Label();
                        this.label4 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.lblEstadoFiscal = new Lui.Forms.Label();
                        this.label5 = new Lui.Forms.Label();
                        this.EtiquetaPV = new Lui.Forms.Label();
                        this.label7 = new Lui.Forms.Label();
                        this.EtiquetaVersion = new Lui.Forms.Label();
                        this.label8 = new Lui.Forms.Label();
                        this.label3 = new Lui.Forms.Label();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        this.BotonCerrar = new Lui.Forms.Button();
                        this.BotonReiniciar = new Lui.Forms.Button();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // IconoBandeja
                        // 
                        this.IconoBandeja.ContextMenu = this.MenuContextual;
                        this.IconoBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("IconoBandeja.Icon")));
                        this.IconoBandeja.Text = "Servidor Fiscal Lázaro";
                        this.IconoBandeja.Visible = true;
                        this.IconoBandeja.DoubleClick += new System.EventHandler(this.IconoBandeja_DoubleClick);
                        // 
                        // MenuContextual
                        // 
                        this.MenuContextual.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuOcultar,
            this.MenuItem1,
            this.MenuCerrar,
            this.MenuReiniciar});
                        // 
                        // MenuOcultar
                        // 
                        this.MenuOcultar.Index = 0;
                        this.MenuOcultar.Text = "&Mostrar";
                        this.MenuOcultar.Visible = false;
                        this.MenuOcultar.Click += new System.EventHandler(this.MenuOcultar_Click);
                        // 
                        // MenuItem1
                        // 
                        this.MenuItem1.Index = 1;
                        this.MenuItem1.Text = "-";
                        this.MenuItem1.Visible = false;
                        // 
                        // MenuCerrar
                        // 
                        this.MenuCerrar.Index = 2;
                        this.MenuCerrar.Text = "&Apagar";
                        this.MenuCerrar.Click += new System.EventHandler(this.MenuCerrar_Click);
                        // 
                        // MenuReiniciar
                        // 
                        this.MenuReiniciar.Index = 3;
                        this.MenuReiniciar.Text = "&Reiniciar";
                        this.MenuReiniciar.Click += new System.EventHandler(this.MenuReiniciar_Click);
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(72, 144);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(104, 24);
                        this.label1.TabIndex = 3;
                        this.label1.Text = "Estado";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaEstado
                        // 
                        this.EtiquetaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaEstado.Location = new System.Drawing.Point(184, 144);
                        this.EtiquetaEstado.Name = "EtiquetaEstado";
                        this.EtiquetaEstado.Size = new System.Drawing.Size(320, 24);
                        this.EtiquetaEstado.TabIndex = 4;
                        this.EtiquetaEstado.Text = "Esperando órdenes.";
                        this.EtiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EtiquetaModeloImpresora
                        // 
                        this.EtiquetaModeloImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaModeloImpresora.Location = new System.Drawing.Point(184, 176);
                        this.EtiquetaModeloImpresora.Name = "EtiquetaModeloImpresora";
                        this.EtiquetaModeloImpresora.Size = new System.Drawing.Size(320, 24);
                        this.EtiquetaModeloImpresora.TabIndex = 6;
                        this.EtiquetaModeloImpresora.Text = "Genérico";
                        this.EtiquetaModeloImpresora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label4
                        // 
                        this.label4.Location = new System.Drawing.Point(72, 176);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(104, 24);
                        this.label4.TabIndex = 5;
                        this.label4.Text = "Impresora";
                        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Location = new System.Drawing.Point(72, 56);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(432, 48);
                        this.label2.TabIndex = 9;
                        this.label2.Text = "Este componente se encarga de comunicarse con la impresora fiscal para hacer la i" +
    "mpresión de comprobantes y cierre Z.";
                        // 
                        // lblEstadoFiscal
                        // 
                        this.lblEstadoFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblEstadoFiscal.Location = new System.Drawing.Point(184, 208);
                        this.lblEstadoFiscal.Name = "lblEstadoFiscal";
                        this.lblEstadoFiscal.Size = new System.Drawing.Size(320, 24);
                        this.lblEstadoFiscal.TabIndex = 11;
                        this.lblEstadoFiscal.Text = "0000 / 0000";
                        this.lblEstadoFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label5
                        // 
                        this.label5.Location = new System.Drawing.Point(72, 208);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(104, 24);
                        this.label5.TabIndex = 10;
                        this.label5.Text = "Estado";
                        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaPV
                        // 
                        this.EtiquetaPV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaPV.Location = new System.Drawing.Point(184, 112);
                        this.EtiquetaPV.Name = "EtiquetaPV";
                        this.EtiquetaPV.Size = new System.Drawing.Size(320, 24);
                        this.EtiquetaPV.TabIndex = 13;
                        this.EtiquetaPV.Text = "No está definido";
                        this.EtiquetaPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(72, 112);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(104, 24);
                        this.label7.TabIndex = 12;
                        this.label7.Text = "Punto de venta";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EtiquetaVersion
                        // 
                        this.EtiquetaVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaVersion.Location = new System.Drawing.Point(184, 240);
                        this.EtiquetaVersion.Name = "EtiquetaVersion";
                        this.EtiquetaVersion.Size = new System.Drawing.Size(320, 24);
                        this.EtiquetaVersion.TabIndex = 15;
                        this.EtiquetaVersion.Text = "-";
                        this.EtiquetaVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label8
                        // 
                        this.label8.Location = new System.Drawing.Point(72, 240);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(104, 24);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "Versión";
                        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(72, 24);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(248, 30);
                        this.label3.TabIndex = 16;
                        this.label3.Text = "Servidor fiscal de Lázaro";
                        this.label3.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                        this.pictureBox1.Location = new System.Drawing.Point(24, 24);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(32, 32);
                        this.pictureBox1.TabIndex = 17;
                        this.pictureBox1.TabStop = false;
                        // 
                        // BotonCerrar
                        // 
                        this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCerrar.Image = null;
                        this.BotonCerrar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCerrar.Location = new System.Drawing.Point(406, 280);
                        this.BotonCerrar.Name = "BotonCerrar";
                        this.BotonCerrar.Size = new System.Drawing.Size(96, 32);
                        this.BotonCerrar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonCerrar.Subtext = "Tecla";
                        this.BotonCerrar.TabIndex = 18;
                        this.BotonCerrar.Text = "Apagar";
                        this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
                        // 
                        // BotonReiniciar
                        // 
                        this.BotonReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonReiniciar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonReiniciar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonReiniciar.Image = null;
                        this.BotonReiniciar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonReiniciar.Location = new System.Drawing.Point(294, 280);
                        this.BotonReiniciar.Name = "BotonReiniciar";
                        this.BotonReiniciar.Size = new System.Drawing.Size(96, 32);
                        this.BotonReiniciar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonReiniciar.Subtext = "Tecla";
                        this.BotonReiniciar.TabIndex = 19;
                        this.BotonReiniciar.Text = "Reiniciar";
                        this.BotonReiniciar.Click += new System.EventHandler(this.BotonReiniciar_Click);
                        // 
                        // FormEstado
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(527, 332);
                        this.Controls.Add(this.BotonReiniciar);
                        this.Controls.Add(this.BotonCerrar);
                        this.Controls.Add(this.pictureBox1);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EtiquetaVersion);
                        this.Controls.Add(this.EtiquetaPV);
                        this.Controls.Add(this.lblEstadoFiscal);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EtiquetaModeloImpresora);
                        this.Controls.Add(this.EtiquetaEstado);
                        this.Controls.Add(this.label8);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.label1);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "FormEstado";
                        this.ShowIcon = false;
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Servidor fiscal";
                        this.TopMost = true;
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstado_FormClosing);
                        this.Load += new System.EventHandler(this.FormEstado_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.Label label3;
                private System.Windows.Forms.PictureBox pictureBox1;
                private Lui.Forms.Button BotonCerrar;
                private Lui.Forms.Button BotonReiniciar;
        }
}
