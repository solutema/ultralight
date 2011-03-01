#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtDocumento = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtImpresora = new System.Windows.Forms.Label();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.PictureBox1 = new System.Windows.Forms.PictureBox();
                        this.lblBorde = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // Label1
                        // 
                        this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label1.Location = new System.Drawing.Point(10, 13);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(517, 16);
                        this.Label1.TabIndex = 0;
                        this.Label1.Text = "Por favor cargue el siguiente documento:";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // txtDocumento
                        // 
                        this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtDocumento.Font = new System.Drawing.Font("Bitstream Vera Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDocumento.Location = new System.Drawing.Point(10, 37);
                        this.txtDocumento.Name = "txtDocumento";
                        this.txtDocumento.Size = new System.Drawing.Size(517, 116);
                        this.txtDocumento.TabIndex = 1;
                        this.txtDocumento.Text = "NCB 0001-00000154";
                        this.txtDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Location = new System.Drawing.Point(49, 168);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(478, 16);
                        this.Label4.TabIndex = 3;
                        this.Label4.Text = "En la impresora";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtImpresora
                        // 
                        this.txtImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtImpresora.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImpresora.Location = new System.Drawing.Point(49, 184);
                        this.txtImpresora.Name = "txtImpresora";
                        this.txtImpresora.Size = new System.Drawing.Size(478, 22);
                        this.txtImpresora.TabIndex = 4;
                        this.txtImpresora.Text = "Predeterminada";
                        this.txtImpresora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Label6.Location = new System.Drawing.Point(49, 218);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(478, 18);
                        this.Label6.TabIndex = 5;
                        this.Label6.Text = "Pulse la barra espaciadora cuando esté listo.";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PictureBox1
                        // 
                        this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
                        this.PictureBox1.Location = new System.Drawing.Point(19, 168);
                        this.PictureBox1.Name = "PictureBox1";
                        this.PictureBox1.Size = new System.Drawing.Size(26, 31);
                        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.PictureBox1.TabIndex = 6;
                        this.PictureBox1.TabStop = false;
                        // 
                        // lblBorde
                        // 
                        this.lblBorde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblBorde.BackColor = System.Drawing.SystemColors.ControlDark;
                        this.lblBorde.Location = new System.Drawing.Point(10, 36);
                        this.lblBorde.Name = "lblBorde";
                        this.lblBorde.Size = new System.Drawing.Size(517, 118);
                        this.lblBorde.TabIndex = 7;
                        this.lblBorde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.label2.Location = new System.Drawing.Point(51, 236);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(476, 14);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "O pulse la tecla Esc para cancelar.";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ManualFeedDialog
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(537, 269);
                        this.ControlBox = false;
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.PictureBox1);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtImpresora);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtDocumento);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.lblBorde);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.KeyPreview = true;
                        this.Name = "ManualFeedDialog";
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Comprobante: Carga Manual";
                        this.TopMost = true;
                        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManualFeedForm_KeyPress);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
                        this.ResumeLayout(false);
                }

                #endregion

                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label6;
                internal System.Windows.Forms.Label txtDocumento;
                internal System.Windows.Forms.Label txtImpresora;
                internal System.Windows.Forms.PictureBox PictureBox1;
                internal System.Windows.Forms.Label label2;
                internal System.Windows.Forms.Label lblBorde;
        }
}
