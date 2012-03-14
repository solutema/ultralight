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

namespace Lui.Printing
{
        public partial class ManualFeedDialog
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualFeedDialog));
                        this.Label1 = new Lui.Forms.Label();
                        this.txtDocumento = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.txtImpresora = new Lui.Forms.Label();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.Location = new System.Drawing.Point(160, 24);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(448, 32);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Por favor cargue el siguiente comprobante";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label1.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader;
                        // 
                        // txtDocumento
                        // 
                        this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDocumento.Location = new System.Drawing.Point(160, 56);
                        this.txtDocumento.Name = "txtDocumento";
                        this.txtDocumento.Size = new System.Drawing.Size(448, 80);
                        this.txtDocumento.TabIndex = 1;
                        this.txtDocumento.Text = "NCB 0001-00000154";
                        this.txtDocumento.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Bigger;
                        this.txtDocumento.UseMnemonic = false;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Location = new System.Drawing.Point(160, 152);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(448, 24);
                        this.Label4.TabIndex = 3;
                        this.Label4.Text = "En la impresora";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtImpresora
                        // 
                        this.txtImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtImpresora.Location = new System.Drawing.Point(160, 176);
                        this.txtImpresora.Name = "txtImpresora";
                        this.txtImpresora.Size = new System.Drawing.Size(448, 40);
                        this.txtImpresora.TabIndex = 4;
                        this.txtImpresora.Text = "Predeterminada";
                        this.txtImpresora.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Bigger;
                        this.txtImpresora.UseMnemonic = false;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(24, 23);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(116, 112);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.PictureBox1.TabIndex = 6;
                        this.PictureBox1.TabStop = false;
                        // 
                        // ManualFeedDialog
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(634, 306);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.txtImpresora);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtDocumento);
                        this.Controls.Add(this.Label1);
                        this.ForeColor = System.Drawing.Color.Black;
                        this.Name = "ManualFeedDialog";
                        this.ShowInTaskbar = false;
                        this.Text = "Carga manual de papel";
                        this.TopMost = true;
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtDocumento, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.txtImpresora, 0);
                        this.Controls.SetChildIndex(this.PictureBox1, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion

                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label txtDocumento;
                internal Lui.Forms.Label txtImpresora;
                internal System.Windows.Forms.PictureBox PictureBox1;
        }
}
