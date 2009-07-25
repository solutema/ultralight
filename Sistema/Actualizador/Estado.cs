// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lazaro.Actualizador
{
        public class Estado : System.Windows.Forms.Form
        {
                public Estado()
                {
                        InitializeComponent();
                }

                #region Código generado por el Diseñador de Windows Forms

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }


                private System.ComponentModel.Container components = null;

                internal System.Windows.Forms.PictureBox PictureBox1;
                public Label LabelEstado;
                internal Lui.Forms.ProgressBar GProgressBar1;
                internal System.Windows.Forms.Label lblOperacion;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estado));
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.lblOperacion = new System.Windows.Forms.Label();
                        this.LabelEstado = new System.Windows.Forms.Label();
                        this.GProgressBar1 = new Lui.Forms.ProgressBar();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(20, 20);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(48, 48);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                        this.PictureBox1.TabIndex = 1;
                        this.PictureBox1.TabStop = false;
                        // 
                        // lblOperacion
                        // 
                        this.lblOperacion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblOperacion.Location = new System.Drawing.Point(88, 64);
                        this.lblOperacion.Name = "lblOperacion";
                        this.lblOperacion.Size = new System.Drawing.Size(364, 20);
                        this.lblOperacion.TabIndex = 2;
                        this.lblOperacion.Text = "Puede demorar varios minutos.";
                        this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelEstado
                        // 
                        this.LabelEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.LabelEstado.Location = new System.Drawing.Point(88, 20);
                        this.LabelEstado.Name = "LabelEstado";
                        this.LabelEstado.Size = new System.Drawing.Size(364, 32);
                        this.LabelEstado.TabIndex = 3;
                        this.LabelEstado.Text = "Por favor aguarde mientras se verifica si existe una nueva versión del sistema.";
                        // 
                        // GProgressBar1
                        // 
                        this.GProgressBar1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.GProgressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.GProgressBar1.Location = new System.Drawing.Point(20, 104);
                        this.GProgressBar1.Name = "GProgressBar1";
                        this.GProgressBar1.Size = new System.Drawing.Size(432, 20);
                        this.GProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                        this.GProgressBar1.TabIndex = 4;
                        this.GProgressBar1.Value = 33;
                        // 
                        // Estado
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(474, 138);
                        this.ControlBox = false;
                        this.Controls.Add(this.GProgressBar1);
                        this.Controls.Add(this.LabelEstado);
                        this.Controls.Add(this.lblOperacion);
                        this.Controls.Add(this.PictureBox1);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "Estado";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Lázaro";
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

        }
}