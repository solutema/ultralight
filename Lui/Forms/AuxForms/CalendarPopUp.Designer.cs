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
	partial class CalendarPopUp
	{
		private Lui.Forms.Calendar Calendar1;
		private System.ComponentModel.IContainer components = null;

		public CalendarPopUp()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
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

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Calendar1 = new Lui.Forms.Calendar();
			this.SuspendLayout();
			// 
			// Calendar1
			// 
			this.Calendar1.CurrentDate = new System.DateTime(2006, 7, 22, 0, 0, 0, 0);
			this.Calendar1.DateFormat = "dd/MM/yyyy";
			this.Calendar1.DockPadding.All = 2;
			this.Calendar1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.Calendar1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Calendar1.Location = new System.Drawing.Point(8, 4);
			this.Calendar1.MultiSelect = false;
			this.Calendar1.Name = "Calendar1";
			this.Calendar1.ReadOnly = false;
			this.Calendar1.ShowFocusRect = true;
			this.Calendar1.Size = new System.Drawing.Size(304, 212);
			this.Calendar1.TabIndex = 0;
			this.Calendar1.ToolTipText = "";
			this.Calendar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calendar1_KeyPress);
			this.Calendar1.DoubleClick += new System.EventHandler(this.Calendar1_DoubleClick);
			// 
			// CalendarPopUp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(318, 222);
			this.Controls.Add(this.Calendar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CalendarPopUp";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Calendario";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion
	}
}