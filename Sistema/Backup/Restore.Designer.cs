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
using System.Text;

namespace Lazaro.WinMain.Backup
{
        public partial class Restore
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
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label3;
                internal Lui.Forms.Label lblFecha;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label5;
                internal Lui.Forms.TextBox EntradaConfirmar;
                internal System.Windows.Forms.PictureBox PictureBox1;

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restore));
                        this.Label1 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.lblFecha = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.EntradaConfirmar = new Lui.Forms.TextBox();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.label2 = new Lui.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        this.Label1.Location = new System.Drawing.Point(80, 24);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(504, 32);
                        this.Label1.TabIndex = 57;
                        this.Label1.Text = "Restaurar copia de respaldo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label3
                        // 
                        this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label3.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Warning;
                        this.Label3.Location = new System.Drawing.Point(80, 112);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(512, 48);
                        this.Label3.TabIndex = 59;
                        this.Label3.Text = "Si continúa con esta acción, llevará el estado del sistema Lázaro atrás en el tie" +
    "mpo a la siguiente fecha:";
                        // 
                        // lblFecha
                        // 
                        this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblFecha.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Big;
                        this.lblFecha.Location = new System.Drawing.Point(192, 160);
                        this.lblFecha.Name = "lblFecha";
                        this.lblFecha.Size = new System.Drawing.Size(400, 28);
                        this.lblFecha.TabIndex = 60;
                        this.lblFecha.Text = "1 de enero de 2001 a las 00:00";
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Location = new System.Drawing.Point(80, 200);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(512, 76);
                        this.Label4.TabIndex = 61;
                        this.Label4.Text = resources.GetString("Label4.Text");
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label5.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Big;
                        this.Label5.Location = new System.Drawing.Point(80, 288);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(424, 32);
                        this.Label5.TabIndex = 62;
                        this.Label5.Text = "Para continuar con el proceso, escriba \"sí\" en el cuadro:";
                        // 
                        // EntradaConfirmar
                        // 
                        this.EntradaConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaConfirmar.ForceCase = Lui.Forms.TextCasing.LowerCase;
                        this.EntradaConfirmar.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Big;
                        this.EntradaConfirmar.Location = new System.Drawing.Point(504, 288);
                        this.EntradaConfirmar.Name = "EntradaConfirmar";
                        this.EntradaConfirmar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaConfirmar.PlaceholderText = "";
                        this.EntradaConfirmar.Size = new System.Drawing.Size(56, 32);
                        this.EntradaConfirmar.TabIndex = 0;
                        this.EntradaConfirmar.TextChanged += new System.EventHandler(this.EntradaConfirmar_TextChanged);
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(24, 24);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(32, 32);
                        this.PictureBox1.TabIndex = 63;
                        this.PictureBox1.TabStop = false;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Location = new System.Drawing.Point(80, 64);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(512, 48);
                        this.label2.TabIndex = 64;
                        this.label2.Text = "La restauración de una copia de respaldo es un procedimiento de emergencia y sólo" +
    " debe realizarse si sufrió la pérdida de datos.";
                        // 
                        // Restore
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(617, 401);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EntradaConfirmar);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.lblFecha);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label1);
                        this.Name = "Restore";
                        this.Text = "Restaurar copia de respaldo";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.lblFecha, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.PictureBox1, 0);
                        this.Controls.SetChildIndex(this.EntradaConfirmar, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Label label2;
        }
}
