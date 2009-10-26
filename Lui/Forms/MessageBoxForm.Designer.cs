// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lui.Forms
{
    partial class MessageBoxForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
                this.label1 = new System.Windows.Forms.Label();
                this.OkButton = new Lui.Forms.Button();
                this.LowerPanel = new System.Windows.Forms.Panel();
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                this.LowerPanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.label1.Location = new System.Drawing.Point(84, 20);
                this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(381, 181);
                this.label1.TabIndex = 2;
                this.label1.Text = "label1";
                this.label1.UseMnemonic = false;
                // 
                // OkButton
                // 
                this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                this.OkButton.Image = null;
                this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                this.OkButton.Location = new System.Drawing.Point(359, 8);
                this.OkButton.Name = "OkButton";
                this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                this.OkButton.ReadOnly = false;
                this.OkButton.Size = new System.Drawing.Size(104, 44);
                this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.None;
                this.OkButton.Subtext = "F9";
                this.OkButton.TabIndex = 3;
                this.OkButton.Text = "Aceptar";
                this.OkButton.ToolTipText = "";
                this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                // 
                // LowerPanel
                // 
                this.LowerPanel.Controls.Add(this.OkButton);
                this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.LowerPanel.Location = new System.Drawing.Point(0, 213);
                this.LowerPanel.Name = "LowerPanel";
                this.LowerPanel.Size = new System.Drawing.Size(474, 61);
                this.LowerPanel.TabIndex = 4;
                // 
                // pictureBox1
                // 
                this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                this.pictureBox1.Location = new System.Drawing.Point(16, 20);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(52, 52);
                this.pictureBox1.TabIndex = 5;
                this.pictureBox1.TabStop = false;
                // 
                // MessageBoxForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(474, 274);
                this.Controls.Add(this.pictureBox1);
                this.Controls.Add(this.LowerPanel);
                this.Controls.Add(this.label1);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.KeyPreview = true;
                this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                this.Name = "MessageBoxForm";
                this.ShowIcon = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "Mensaje";
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBoxForm_KeyDown);
                this.LowerPanel.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public Lui.Forms.Button OkButton;
	    private System.Windows.Forms.Panel LowerPanel;
	    private System.Windows.Forms.PictureBox pictureBox1;
    }
}
