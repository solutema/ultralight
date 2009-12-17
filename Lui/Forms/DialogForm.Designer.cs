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

namespace Lui.Forms
{
	partial class DialogForm
	{

		#region Código generado por el Diseñador de Windows Forms

		public DialogForm()
			:
		    base()
		{

			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			LowerPanel.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
		}

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.Panel LowerPanel;
		public Lui.Forms.Button OkButton;
		public Lui.Forms.Button CancelCommandButton;

		private void InitializeComponent()
		{
                        this.LowerPanel = new System.Windows.Forms.Panel();
                        this.OkButton = new Lui.Forms.Button();
                        this.CancelCommandButton = new Lui.Forms.Button();
                        this.LowerPanel.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // LowerPanel
                        // 
                        this.LowerPanel.Controls.Add(this.OkButton);
                        this.LowerPanel.Controls.Add(this.CancelCommandButton);
                        this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.LowerPanel.Location = new System.Drawing.Point(0, 234);
                        this.LowerPanel.Name = "LowerPanel";
                        this.LowerPanel.Size = new System.Drawing.Size(474, 60);
                        this.LowerPanel.TabIndex = 50;
                        // 
                        // OkButton
                        // 
                        this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.OkButton.AutoHeight = false;
                        this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.OkButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.OkButton.Image = null;
                        this.OkButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.OkButton.Location = new System.Drawing.Point(220, 8);
                        this.OkButton.Name = "OkButton";
                        this.OkButton.Padding = new System.Windows.Forms.Padding(2);
                        this.OkButton.ReadOnly = false;
                        this.OkButton.Size = new System.Drawing.Size(116, 44);
                        this.OkButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.OkButton.Subtext = "F9";
                        this.OkButton.TabIndex = 0;
                        this.OkButton.Text = "Aceptar";
                        this.OkButton.ToolTipText = "";
                        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.CancelCommandButton.AutoHeight = false;
                        this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.CancelCommandButton.Image = null;
                        this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.CancelCommandButton.Location = new System.Drawing.Point(348, 8);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        this.CancelCommandButton.Padding = new System.Windows.Forms.Padding(2);
                        this.CancelCommandButton.ReadOnly = false;
                        this.CancelCommandButton.Size = new System.Drawing.Size(116, 44);
                        this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.CancelCommandButton.Subtext = "Esc";
                        this.CancelCommandButton.TabIndex = 1;
                        this.CancelCommandButton.Text = "Volver";
                        this.CancelCommandButton.ToolTipText = "";
                        this.CancelCommandButton.Click += new System.EventHandler(this.CancelCommandButton_Click);
                        // 
                        // DialogForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 294);
                        this.ControlBox = false;
                        this.Controls.Add(this.LowerPanel);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.KeyPreview = true;
                        this.Name = "DialogForm";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Diálogo";
                        this.SizeChanged += new System.EventHandler(this.DialogForm_SizeChanged);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DialogForm_KeyDown);
                        this.LowerPanel.ResumeLayout(false);
                        this.ResumeLayout(false);

		}

		#endregion
	}
}