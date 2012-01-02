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

namespace Lfc
{
	public partial class FormularioListadoTexto
	{
		#region Código generado por el Diseñador de Windows Forms

		public FormularioListadoTexto()
			:
		    base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}

			base.Dispose(disposing);
		}

		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.Panel LowerPanel;
		internal Lui.Forms.Button CancelCommandButton;
		internal Lui.Forms.Button BotonMostrar;
		internal Lui.Forms.Button PrintButton;
		internal Lui.Forms.Button BotonCopiar;

		private void InitializeComponent()
		{
			this.LowerPanel = new System.Windows.Forms.Panel();
			this.BotonCopiar = new Lui.Forms.Button();
			this.PrintButton = new Lui.Forms.Button();
			this.BotonMostrar = new Lui.Forms.Button();
			this.CancelCommandButton = new Lui.Forms.Button();
			this.LowerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LowerPanel
			// 
			this.LowerPanel.Controls.Add(this.BotonCopiar);
			this.LowerPanel.Controls.Add(this.PrintButton);
			this.LowerPanel.Controls.Add(this.BotonMostrar);
			this.LowerPanel.Controls.Add(this.CancelCommandButton);
			this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LowerPanel.Location = new System.Drawing.Point(0, 413);
			this.LowerPanel.Name = "LowerPanel";
			this.LowerPanel.Size = new System.Drawing.Size(692, 60);
			this.LowerPanel.TabIndex = 50;
			// 
			// BotonCopiar
			// 
			this.BotonCopiar.DockPadding.All = 2;
			this.BotonCopiar.Image = null;
			this.BotonCopiar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.BotonCopiar.Location = new System.Drawing.Point(8, 8);
			this.BotonCopiar.Name = "BotonCopiar";
			this.BotonCopiar.TemporaryReadOnly = false;
			this.BotonCopiar.Size = new System.Drawing.Size(104, 44);
			this.BotonCopiar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.BotonCopiar.Subtext = "F7";
			this.BotonCopiar.TabIndex = 2;
			this.BotonCopiar.Text = "Copiar";
			this.BotonCopiar.Click += new System.EventHandler(this.BotonCopiar_Click);
			// 
			// PrintButton
			// 
			this.PrintButton.DockPadding.All = 2;
			this.PrintButton.Image = null;
			this.PrintButton.ImagePos = Lui.Forms.ImagePositions.Top;
			this.PrintButton.Location = new System.Drawing.Point(116, 8);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.TemporaryReadOnly = false;
			this.PrintButton.Size = new System.Drawing.Size(104, 44);
			this.PrintButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.PrintButton.Subtext = "F8";
			this.PrintButton.TabIndex = 3;
			this.PrintButton.Text = "Imprimir";
			// 
			// BotonMostrar
			// 
			this.BotonMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BotonMostrar.DockPadding.All = 2;
			this.BotonMostrar.Image = null;
			this.BotonMostrar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.BotonMostrar.Location = new System.Drawing.Point(472, 8);
			this.BotonMostrar.Name = "BotonMostrar";
			this.BotonMostrar.TemporaryReadOnly = false;
			this.BotonMostrar.Size = new System.Drawing.Size(104, 44);
			this.BotonMostrar.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.BotonMostrar.Subtext = "F9";
			this.BotonMostrar.TabIndex = 0;
			this.BotonMostrar.Text = "Mostrar";
			this.BotonMostrar.Click += new System.EventHandler(this.BotonMostrar_Click);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Image = null;
			this.CancelCommandButton.ImagePos = Lui.Forms.ImagePositions.Top;
			this.CancelCommandButton.Location = new System.Drawing.Point(580, 8);
			this.CancelCommandButton.Name = "CancelCommandButton";
			this.CancelCommandButton.TemporaryReadOnly = false;
			this.CancelCommandButton.Size = new System.Drawing.Size(104, 44);
			this.CancelCommandButton.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
			this.CancelCommandButton.Subtext = "Esc";
			this.CancelCommandButton.TabIndex = 1;
			this.CancelCommandButton.Text = "Volver";
			this.CancelCommandButton.Click += new System.EventHandler(this.BotonCancelar_Click);
			// 
			// TextListingForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.Controls.Add(this.LowerPanel);
			this.KeyPreview = true;
			this.Name = "TextListingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Listado";
			this.LowerPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

	}
}
