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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.WinMain.Misc
{
        public partial class Fiscal
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

                private System.ComponentModel.IContainer components = null;

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.BotonCierreZ = new Lui.Forms.Button();
                        this.Timer1 = new System.Windows.Forms.Timer(this.components);
                        this.lblCierreZ = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaPv = new Lui.Forms.ComboBox();
                        this.BotonReiniciar = new Lui.Forms.Button();
                        this.label2 = new Lui.Forms.Label();
                        this.lblEstadoServidor = new Lui.Forms.Label();
                        this.lblUltimoCierreZ = new Lui.Forms.Label();
                        this.BotonIniciarDetener = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(394, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(514, 8);
                        // 
                        // BotonCierreZ
                        // 
                        this.BotonCierreZ.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCierreZ.Image = null;
                        this.BotonCierreZ.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCierreZ.Location = new System.Drawing.Point(188, 176);
                        this.BotonCierreZ.Name = "BotonCierreZ";
                        this.BotonCierreZ.ReadOnly = false;
                        this.BotonCierreZ.Size = new System.Drawing.Size(100, 28);
                        this.BotonCierreZ.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonCierreZ.Subtext = "Ctrl-Z";
                        this.BotonCierreZ.TabIndex = 8;
                        this.BotonCierreZ.Text = "Cierre Z";
                        this.BotonCierreZ.Click += new System.EventHandler(this.BotonCierreZ_Click);
                        // 
                        // Timer1
                        // 
                        this.Timer1.Enabled = true;
                        this.Timer1.Interval = 2000;
                        this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
                        // 
                        // lblCierreZ
                        // 
                        this.lblCierreZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblCierreZ.Location = new System.Drawing.Point(24, 144);
                        this.lblCierreZ.Name = "lblCierreZ";
                        this.lblCierreZ.Size = new System.Drawing.Size(164, 24);
                        this.lblCierreZ.TabIndex = 3;
                        this.lblCierreZ.Text = "Último Cierre Z";
                        this.lblCierreZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(24, 24);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(164, 24);
                        this.label1.TabIndex = 51;
                        this.label1.Text = "Punto de Venta";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaPv
                        // 
                        this.EntradaPv.AlwaysExpanded = true;
                        this.EntradaPv.AutoSize = true;
                        this.EntradaPv.Location = new System.Drawing.Point(188, 24);
                        this.EntradaPv.Name = "EntradaPv";
                        this.EntradaPv.ReadOnly = false;
                        this.EntradaPv.SetData = null;
                        this.EntradaPv.Size = new System.Drawing.Size(192, 21);
                        this.EntradaPv.TabIndex = 52;
                        this.EntradaPv.TextKey = "";
                        this.EntradaPv.TextChanged += new System.EventHandler(this.txtPV_TextChanged);
                        // 
                        // BotonReiniciar
                        // 
                        this.BotonReiniciar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonReiniciar.Enabled = false;
                        this.BotonReiniciar.Image = null;
                        this.BotonReiniciar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonReiniciar.Location = new System.Drawing.Point(296, 260);
                        this.BotonReiniciar.Name = "BotonReiniciar";
                        this.BotonReiniciar.ReadOnly = false;
                        this.BotonReiniciar.Size = new System.Drawing.Size(100, 28);
                        this.BotonReiniciar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonReiniciar.Subtext = "Ctrl-Z";
                        this.BotonReiniciar.TabIndex = 53;
                        this.BotonReiniciar.Text = "Reiniciar";
                        this.BotonReiniciar.Click += new System.EventHandler(this.BotonReiniciar_Click);
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Location = new System.Drawing.Point(24, 228);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(164, 24);
                        this.label2.TabIndex = 54;
                        this.label2.Text = "Estado del Servidor";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblEstadoServidor
                        // 
                        this.lblEstadoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblEstadoServidor.Location = new System.Drawing.Point(184, 228);
                        this.lblEstadoServidor.Name = "lblEstadoServidor";
                        this.lblEstadoServidor.Size = new System.Drawing.Size(416, 24);
                        this.lblEstadoServidor.TabIndex = 56;
                        this.lblEstadoServidor.Text = "Desconocido";
                        this.lblEstadoServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.lblEstadoServidor.TextChanged += new System.EventHandler(this.lblEstadoServidor_TextChanged);
                        // 
                        // lblUltimoCierreZ
                        // 
                        this.lblUltimoCierreZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblUltimoCierreZ.Location = new System.Drawing.Point(188, 144);
                        this.lblUltimoCierreZ.Name = "lblUltimoCierreZ";
                        this.lblUltimoCierreZ.Size = new System.Drawing.Size(412, 24);
                        this.lblUltimoCierreZ.TabIndex = 55;
                        this.lblUltimoCierreZ.Text = "Desconocido";
                        this.lblUltimoCierreZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonIniciarDetener
                        // 
                        this.BotonIniciarDetener.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonIniciarDetener.Image = null;
                        this.BotonIniciarDetener.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonIniciarDetener.Location = new System.Drawing.Point(188, 260);
                        this.BotonIniciarDetener.Name = "BotonIniciarDetener";
                        this.BotonIniciarDetener.ReadOnly = false;
                        this.BotonIniciarDetener.Size = new System.Drawing.Size(100, 28);
                        this.BotonIniciarDetener.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonIniciarDetener.Subtext = "Ctrl-Z";
                        this.BotonIniciarDetener.TabIndex = 57;
                        this.BotonIniciarDetener.Text = "Iniciar";
                        this.BotonIniciarDetener.Click += new System.EventHandler(this.BotonIniciarDetener_Click);
                        // 
                        // Fiscal
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 372);
                        this.Controls.Add(this.EntradaPv);
                        this.Controls.Add(this.BotonIniciarDetener);
                        this.Controls.Add(this.lblEstadoServidor);
                        this.Controls.Add(this.lblUltimoCierreZ);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.BotonReiniciar);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.lblCierreZ);
                        this.Controls.Add(this.BotonCierreZ);
                        this.Name = "Fiscal";
                        this.Text = "Impresora Fiscal: Panel de Control";
                        this.Load += new System.EventHandler(this.Fiscal_Load);
                        this.Controls.SetChildIndex(this.BotonCierreZ, 0);
                        this.Controls.SetChildIndex(this.lblCierreZ, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.BotonReiniciar, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.lblUltimoCierreZ, 0);
                        this.Controls.SetChildIndex(this.lblEstadoServidor, 0);
                        this.Controls.SetChildIndex(this.BotonIniciarDetener, 0);
                        this.Controls.SetChildIndex(this.EntradaPv, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                internal Lui.Forms.Button BotonCierreZ;
                internal System.Windows.Forms.Timer Timer1;
                private Lui.Forms.Label label1;
                internal Lui.Forms.ComboBox EntradaPv;
                internal Lui.Forms.Label label2;
                internal Lui.Forms.Button BotonReiniciar;
                internal Lui.Forms.Button BotonIniciarDetener;
                internal Lui.Forms.Label lblEstadoServidor;
                internal Lui.Forms.Label lblUltimoCierreZ;
                internal Lui.Forms.Label lblCierreZ;

        }
}
