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
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lazaro.Misc
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

                private System.ComponentModel.IContainer components;

                private void InitializeComponent()
                {
                        this.components = new System.ComponentModel.Container();
                        this.cmdCierreZ = new Lui.Forms.Button();
                        this.Timer1 = new System.Windows.Forms.Timer(this.components);
                        this.lblCierreZ = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.txtPV = new Lui.Forms.ComboBox();
                        this.cmdReiniciar = new Lui.Forms.Button();
                        this.label2 = new System.Windows.Forms.Label();
                        this.lblEstadoServidor = new System.Windows.Forms.Label();
                        this.lblUltimoCierreZ = new System.Windows.Forms.Label();
                        this.cmdIniciarDetener = new Lui.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.DockPadding.All = 2;
                        this.OkButton.Location = new System.Drawing.Point(318, 8);
                        this.OkButton.Name = "OkButton";
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.DockPadding.All = 2;
                        this.CancelCommandButton.Location = new System.Drawing.Point(426, 8);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        // 
                        // cmdCierreZ
                        // 
                        this.cmdCierreZ.DockPadding.All = 2;
                        this.cmdCierreZ.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.cmdCierreZ.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdCierreZ.Image = null;
                        this.cmdCierreZ.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdCierreZ.Location = new System.Drawing.Point(196, 88);
                        this.cmdCierreZ.Name = "cmdCierreZ";
                        this.cmdCierreZ.ReadOnly = false;
                        this.cmdCierreZ.Size = new System.Drawing.Size(100, 28);
                        this.cmdCierreZ.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdCierreZ.Subtext = "Ctrl-Z";
                        this.cmdCierreZ.TabIndex = 8;
                        this.cmdCierreZ.Text = "Cierre Z";
                        this.cmdCierreZ.ToolTipText = "";
                        this.cmdCierreZ.Click += new System.EventHandler(this.cmdCierreZ_Click);
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
                        this.lblCierreZ.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.lblCierreZ.Location = new System.Drawing.Point(32, 60);
                        this.lblCierreZ.Name = "lblCierreZ";
                        this.lblCierreZ.Size = new System.Drawing.Size(164, 20);
                        this.lblCierreZ.TabIndex = 3;
                        this.lblCierreZ.Text = "Último Cierre Z";
                        this.lblCierreZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(16, 16);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(120, 24);
                        this.label1.TabIndex = 51;
                        this.label1.Text = "Punto de Venta";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPV
                        // 
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DockPadding.All = 2;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtPV.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtPV.Location = new System.Drawing.Point(136, 16);
                        this.txtPV.MaxLenght = 32767;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.ReadOnly = false;
                        this.txtPV.SetData = new string[] {
												  "N/A|0"};
                        this.txtPV.Size = new System.Drawing.Size(192, 24);
                        this.txtPV.TabIndex = 52;
                        this.txtPV.Text = "N/A";
                        this.txtPV.TextKey = "0";
                        this.txtPV.ToolTipText = "";
                        this.txtPV.TextChanged += new System.EventHandler(this.txtPV_TextChanged);
                        // 
                        // cmdReiniciar
                        // 
                        this.cmdReiniciar.DockPadding.All = 2;
                        this.cmdReiniciar.Enabled = false;
                        this.cmdReiniciar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.cmdReiniciar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdReiniciar.Image = null;
                        this.cmdReiniciar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdReiniciar.Location = new System.Drawing.Point(304, 180);
                        this.cmdReiniciar.Name = "cmdReiniciar";
                        this.cmdReiniciar.ReadOnly = false;
                        this.cmdReiniciar.Size = new System.Drawing.Size(100, 28);
                        this.cmdReiniciar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdReiniciar.Subtext = "Ctrl-Z";
                        this.cmdReiniciar.TabIndex = 53;
                        this.cmdReiniciar.Text = "Reiniciar";
                        this.cmdReiniciar.ToolTipText = "";
                        this.cmdReiniciar.Click += new System.EventHandler(this.cmdReiniciar_Click);
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.label2.Location = new System.Drawing.Point(32, 152);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(160, 20);
                        this.label2.TabIndex = 54;
                        this.label2.Text = "Estado del Servidor";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblEstadoServidor
                        // 
                        this.lblEstadoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblEstadoServidor.Location = new System.Drawing.Point(192, 152);
                        this.lblEstadoServidor.Name = "lblEstadoServidor";
                        this.lblEstadoServidor.Size = new System.Drawing.Size(232, 20);
                        this.lblEstadoServidor.TabIndex = 56;
                        this.lblEstadoServidor.Text = "Desconocido";
                        this.lblEstadoServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.lblEstadoServidor.TextChanged += new System.EventHandler(this.lblEstadoServidor_TextChanged);
                        // 
                        // lblUltimoCierreZ
                        // 
                        this.lblUltimoCierreZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblUltimoCierreZ.Location = new System.Drawing.Point(196, 60);
                        this.lblUltimoCierreZ.Name = "lblUltimoCierreZ";
                        this.lblUltimoCierreZ.Size = new System.Drawing.Size(228, 20);
                        this.lblUltimoCierreZ.TabIndex = 55;
                        this.lblUltimoCierreZ.Text = "Desconocido";
                        this.lblUltimoCierreZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdIniciarDetener
                        // 
                        this.cmdIniciarDetener.DockPadding.All = 2;
                        this.cmdIniciarDetener.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.cmdIniciarDetener.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdIniciarDetener.Image = null;
                        this.cmdIniciarDetener.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdIniciarDetener.Location = new System.Drawing.Point(196, 180);
                        this.cmdIniciarDetener.Name = "cmdIniciarDetener";
                        this.cmdIniciarDetener.ReadOnly = false;
                        this.cmdIniciarDetener.Size = new System.Drawing.Size(100, 28);
                        this.cmdIniciarDetener.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.cmdIniciarDetener.Subtext = "Ctrl-Z";
                        this.cmdIniciarDetener.TabIndex = 57;
                        this.cmdIniciarDetener.Text = "Iniciar";
                        this.cmdIniciarDetener.ToolTipText = "";
                        this.cmdIniciarDetener.Click += new System.EventHandler(this.cmdIniciarDetener_Click);
                        // 
                        // Fiscal
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(534, 279);
                        this.Controls.Add(this.cmdIniciarDetener);
                        this.Controls.Add(this.lblEstadoServidor);
                        this.Controls.Add(this.lblUltimoCierreZ);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.cmdReiniciar);
                        this.Controls.Add(this.txtPV);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.cmdCierreZ);
                        this.Controls.Add(this.lblCierreZ);
                        this.Name = "Fiscal";
                        this.Text = "Impresora Fiscal: Panel de Control";
                        this.Load += new System.EventHandler(this.Fiscal_Load);
                        this.WorkspaceChanged += new System.EventHandler(this.Fiscal_WorkspaceChanged);
                        this.ResumeLayout(false);

                }
                #endregion

                internal Lui.Forms.Button cmdCierreZ;
                internal System.Windows.Forms.Timer Timer1;
                private System.Windows.Forms.Label label1;
                internal Lui.Forms.ComboBox txtPV;
                internal System.Windows.Forms.Label label2;
                internal Lui.Forms.Button cmdReiniciar;
                internal Lui.Forms.Button cmdIniciarDetener;
                internal System.Windows.Forms.Label lblEstadoServidor;
                internal System.Windows.Forms.Label lblUltimoCierreZ;
                internal System.Windows.Forms.Label lblCierreZ;

        }
}
