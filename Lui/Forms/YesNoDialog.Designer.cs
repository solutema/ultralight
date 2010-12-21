#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

namespace Lui.Forms
{
	partial class YesNoDialog
	{
		#region Código generado por el Diseñador de Windows Forms

		internal System.Windows.Forms.PictureBox pctQuestion;
		internal System.Windows.Forms.PictureBox pctExclamation;
		internal System.Windows.Forms.PictureBox pctInformation;

		private void InitializeComponent()
		{
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoDialog));
                        this.DialogCaption = new System.Windows.Forms.Label();
                        this.pctQuestion = new System.Windows.Forms.PictureBox();
                        this.pctExclamation = new System.Windows.Forms.PictureBox();
                        this.pctInformation = new System.Windows.Forms.PictureBox();
                        this.DialogText = new System.Windows.Forms.RichTextBox();
                        ((System.ComponentModel.ISupportInitialize)(this.pctQuestion)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctExclamation)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctInformation)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // DialogCaption
                        // 
                        this.DialogCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.DialogCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.DialogCaption.Location = new System.Drawing.Point(12, 8);
                        this.DialogCaption.Name = "DialogCaption";
                        this.DialogCaption.Size = new System.Drawing.Size(452, 28);
                        this.DialogCaption.TabIndex = 0;
                        this.DialogCaption.Text = "Pregunta";
                        this.DialogCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // pctQuestion
                        // 
                        this.pctQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pctQuestion.Image")));
                        this.pctQuestion.Location = new System.Drawing.Point(24, 44);
                        this.pctQuestion.Name = "pctQuestion";
                        this.pctQuestion.Size = new System.Drawing.Size(52, 52);
                        this.pctQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                        this.pctQuestion.TabIndex = 52;
                        this.pctQuestion.TabStop = false;
                        // 
                        // pctExclamation
                        // 
                        this.pctExclamation.Image = ((System.Drawing.Image)(resources.GetObject("pctExclamation.Image")));
                        this.pctExclamation.Location = new System.Drawing.Point(24, 44);
                        this.pctExclamation.Name = "pctExclamation";
                        this.pctExclamation.Size = new System.Drawing.Size(52, 52);
                        this.pctExclamation.TabIndex = 55;
                        this.pctExclamation.TabStop = false;
                        this.pctExclamation.Visible = false;
                        // 
                        // pctInformation
                        // 
                        this.pctInformation.Image = ((System.Drawing.Image)(resources.GetObject("pctInformation.Image")));
                        this.pctInformation.Location = new System.Drawing.Point(24, 44);
                        this.pctInformation.Name = "pctInformation";
                        this.pctInformation.Size = new System.Drawing.Size(52, 52);
                        this.pctInformation.TabIndex = 56;
                        this.pctInformation.TabStop = false;
                        this.pctInformation.Visible = false;
                        // 
                        // DialogText
                        // 
                        this.DialogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.DialogText.BackColor = System.Drawing.SystemColors.Control;
                        this.DialogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.DialogText.BulletIndent = 8;
                        this.DialogText.Cursor = System.Windows.Forms.Cursors.Default;
                        this.DialogText.DetectUrls = false;
                        this.DialogText.Font = new System.Drawing.Font("Bitstream Vera Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.DialogText.Location = new System.Drawing.Point(84, 42);
                        this.DialogText.Name = "DialogText";
                        this.DialogText.ReadOnly = true;
                        this.DialogText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
                        this.DialogText.Size = new System.Drawing.Size(380, 182);
                        this.DialogText.TabIndex = 1;
                        this.DialogText.TabStop = false;
                        this.DialogText.Text = "Texto explicativo.";
                        // 
                        // YesNoDialog
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 294);
                        this.Controls.Add(this.DialogText);
                        this.Controls.Add(this.DialogCaption);
                        this.Controls.Add(this.pctQuestion);
                        this.Controls.Add(this.pctInformation);
                        this.Controls.Add(this.pctExclamation);
                        this.Name = "YesNoDialog";
                        this.Load += new System.EventHandler(this.YesNoDialog_Load);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YesNoDialogForm_KeyDown);
                        this.BackColorChanged += new System.EventHandler(this.YesNoDialog_BackColorChanged);
                        ((System.ComponentModel.ISupportInitialize)(this.pctQuestion)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctExclamation)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.pctInformation)).EndInit();
                        this.ResumeLayout(false);

		}

		#endregion
	}
}