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

namespace Lui.Printing
{
	public class PrintPreviewForm : Lui.Forms.ChildForm
	{

		#region Código generado por el Diseñador de Windows Forms

		public PrintPreviewForm()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			PrintPreview.BackColor = Lws.Config.Display.CurrentTemplate.WindowBackground;
			LowerPanel.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
			CancelCommandButton.Text = "Volver";
			SaveButton.Visible = false;
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		public System.Windows.Forms.PrintPreviewControl PrintPreview;
		internal Lui.Forms.Button CancelCommandButton;
		internal Lui.Forms.Button SaveButton;
		internal System.Windows.Forms.Panel LowerPanel;
		internal Lui.Forms.Button cmdZoom;

		private void InitializeComponent()
		{
			this.PrintPreview = new System.Windows.Forms.PrintPreviewControl();
			this.CancelCommandButton = new Lui.Forms.Button();
			this.SaveButton = new Lui.Forms.Button();
			this.LowerPanel = new System.Windows.Forms.Panel();
			this.cmdZoom = new Lui.Forms.Button();
			this.LowerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// PrintPreview
			// 
			this.PrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.PrintPreview.Location = new System.Drawing.Point(0, 0);
			this.PrintPreview.Name = "PrintPreview";
			this.PrintPreview.Size = new System.Drawing.Size(616, 344);
			this.PrintPreview.TabIndex = 500;
			this.PrintPreview.UseAntiAlias = true;
			this.PrintPreview.Zoom = 1;
			this.PrintPreview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintPreview_KeyDown);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CancelCommandButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CancelCommandButton.Image = null;
			this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
			this.CancelCommandButton.Location = new System.Drawing.Point(524, 6);
			this.CancelCommandButton.Name = "CancelCommandButton";
			this.CancelCommandButton.ReadOnly = false;
			this.CancelCommandButton.Size = new System.Drawing.Size(84, 40);
			this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.CancelCommandButton.Subtext = "Esc";
			this.CancelCommandButton.TabIndex = 111;
			this.CancelCommandButton.Text = "Cancelar";
			this.CancelCommandButton.ToolTipText = "";
			this.CancelCommandButton.Click += new System.EventHandler(this.cmdCancelar_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.DockPadding.All = 2;
			this.SaveButton.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SaveButton.Image = null;
			this.SaveButton.ImagePos = Lui.Forms.ImagePositions.Top;
			this.SaveButton.Location = new System.Drawing.Point(432, 6);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.ReadOnly = false;
			this.SaveButton.Size = new System.Drawing.Size(84, 40);
			this.SaveButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.SaveButton.Subtext = "F8";
			this.SaveButton.TabIndex = 110;
			this.SaveButton.Text = "Imprimir";
			this.SaveButton.ToolTipText = "";
			// 
			// LowerPanel
			// 
			this.LowerPanel.Controls.Add(this.cmdZoom);
			this.LowerPanel.Controls.Add(this.SaveButton);
			this.LowerPanel.Controls.Add(this.CancelCommandButton);
			this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LowerPanel.Location = new System.Drawing.Point(0, 353);
			this.LowerPanel.Name = "LowerPanel";
			this.LowerPanel.Size = new System.Drawing.Size(616, 52);
			this.LowerPanel.TabIndex = 106;
			// 
			// cmdZoom
			// 
			this.cmdZoom.DockPadding.All = 2;
			this.cmdZoom.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdZoom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdZoom.Image = null;
			this.cmdZoom.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdZoom.Location = new System.Drawing.Point(8, 6);
			this.cmdZoom.Name = "cmdZoom";
			this.cmdZoom.ReadOnly = false;
			this.cmdZoom.Size = new System.Drawing.Size(84, 40);
			this.cmdZoom.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.cmdZoom.Subtext = "F2";
			this.cmdZoom.TabIndex = 101;
			this.cmdZoom.Text = "Zoom";
			this.cmdZoom.ToolTipText = "";
			this.cmdZoom.Click += new System.EventHandler(this.cmdZoom_Click);
			// 
			// PrintPreviewForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(616, 405);
			this.Controls.Add(this.LowerPanel);
			this.Controls.Add(this.PrintPreview);
			this.KeyPreview = true;
			this.Name = "PrintPreviewForm";
			this.Text = "Vista Previa";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVistaPrevia_KeyDown);
			this.LowerPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		#endregion

		private void cmdCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void PrintPreview_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			FormVistaPrevia_KeyDown(sender, e);
		}


		private void FormVistaPrevia_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Control == false && e.Shift == false) {
				switch(e.KeyCode) {
					case Keys.Escape:
						e.Handled = true;
						if(CancelCommandButton.Enabled && CancelCommandButton.Visible)
							CancelCommandButton.PerformClick();
						break;
					case Keys.F2:
					case Keys.Space:
						e.Handled = true;
						cmdZoom.PerformClick();
						break;
					case Keys.PageDown:
						e.Handled = true;
						PrintPreview.Focus();
						SendKeys.Send("{PGDN}");
						break;
					case Keys.PageUp:
						e.Handled = true;
						PrintPreview.Focus();
						SendKeys.Send("{PGUP}");
						break;
				}
			}
		}


		private void cmdZoom_Click(object sender, System.EventArgs e)
		{
			PrintPreview.AutoZoom = !PrintPreview.AutoZoom;
			if(PrintPreview.AutoZoom == false)
				PrintPreview.Zoom = 1;
		}

	}
}