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

namespace Lfc.Importar
{
        partial class ImportarArticulos
        {
                /// <summary>
                /// Required designer variable.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Clean up any resources being used.
                /// </summary>
                /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Windows Form Designer generated code

                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        this.label1 = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.BotonExaminar = new Lui.Forms.Button();
                        this.label3 = new Lui.Forms.Label();
                        this.label4 = new Lui.Forms.Label();
                        this.ListaColumnas = new Lui.Forms.ListView();
                        this.SuspendLayout();
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(24, 24);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(167, 24);
                        this.label1.TabIndex = 51;
                        this.label1.Text = "1. Seleccione un archivo";
                        this.label1.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(48, 48);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(515, 20);
                        this.label2.TabIndex = 52;
                        this.label2.Text = "Puede ser un archivo de Microsoft Excel, LibreOffice Calc o texto separado por co" +
    "mas.";
                        // 
                        // BotonExaminar
                        // 
                        this.BotonExaminar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonExaminar.ForeColor = System.Drawing.Color.Black;
                        this.BotonExaminar.Image = null;
                        this.BotonExaminar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonExaminar.Location = new System.Drawing.Point(592, 40);
                        this.BotonExaminar.Name = "BotonExaminar";
                        this.BotonExaminar.Size = new System.Drawing.Size(88, 32);
                        this.BotonExaminar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                        this.BotonExaminar.Subtext = "Tecla";
                        this.BotonExaminar.TabIndex = 53;
                        this.BotonExaminar.Text = "&Examinar";
                        this.BotonExaminar.Click += new System.EventHandler(this.BotonExaminar_Click);
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(48, 104);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(248, 20);
                        this.label3.TabIndex = 55;
                        this.label3.Text = "Seleccione qué datos incorporar y cómo.";
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(24, 80);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(431, 24);
                        this.label4.TabIndex = 54;
                        this.label4.Text = "2. Relacione las columnas del archivo con los campos de Lázaro";
                        this.label4.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2;
                        // 
                        // ListaColumnas
                        // 
                        this.ListaColumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaColumnas.FieldName = null;
                        this.ListaColumnas.Location = new System.Drawing.Point(48, 136);
                        this.ListaColumnas.Name = "ListaColumnas";
                        this.ListaColumnas.ReadOnly = false;
                        this.ListaColumnas.Size = new System.Drawing.Size(712, 64);
                        this.ListaColumnas.TabIndex = 56;
                        this.ListaColumnas.UseCompatibleStateImageBehavior = false;
                        this.ListaColumnas.View = System.Windows.Forms.View.Details;
                        // 
                        // ImportarArticulos
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(784, 449);
                        this.Controls.Add(this.ListaColumnas);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label4);
                        this.Controls.Add(this.BotonExaminar);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "ImportarArticulos";
                        this.Text = "Importar artículos";
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.BotonExaminar, 0);
                        this.Controls.SetChildIndex(this.label4, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.ListaColumnas, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private Lui.Forms.Label label1;
                private Lui.Forms.Label label2;
                private Lui.Forms.Button BotonExaminar;
                private Lui.Forms.Label label3;
                private Lui.Forms.Label label4;
                private Lui.Forms.ListView ListaColumnas;
        }
}