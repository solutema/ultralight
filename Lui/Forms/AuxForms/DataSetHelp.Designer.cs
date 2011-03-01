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

namespace Lui.Forms
{
	partial class DataSetHelp
	{
		#region Código generado por el Diseñador de Windows Forms

		public DataSetHelp()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			this.BackColor = Lfx.Config.Display.CurrentTemplate.Selection;
			Panel1.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;
			lstItems.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;
			lstItems.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
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

		private System.ComponentModel.IContainer components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.ListBox lstItems;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Panel Panel1;

		private void InitializeComponent()
		{
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSetHelp));
                        this.lstItems = new System.Windows.Forms.ListBox();
                        this.Timer1 = new System.Windows.Forms.Timer(this.components);
                        this.Panel1 = new System.Windows.Forms.Panel();
                        this.SuspendLayout();
                        // 
                        // lstItems
                        // 
                        this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lstItems.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lstItems.ForeColor = System.Drawing.SystemColors.InfoText;
                        this.lstItems.IntegralHeight = false;
                        this.lstItems.Location = new System.Drawing.Point(4, 4);
                        this.lstItems.Name = "lstItems";
                        this.lstItems.Size = new System.Drawing.Size(206, 110);
                        this.lstItems.TabIndex = 0;
                        this.lstItems.TabStop = false;
                        this.lstItems.DoubleClick += new System.EventHandler(this.lstItems_DoubleClick);
                        this.lstItems.Click += new System.EventHandler(this.lstItems_Click);
                        // 
                        // Timer1
                        // 
                        this.Timer1.Interval = 5000;
                        this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
                        // 
                        // Panel1
                        // 
                        this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Panel1.Location = new System.Drawing.Point(2, 2);
                        this.Panel1.Name = "Panel1";
                        this.Panel1.Size = new System.Drawing.Size(210, 114);
                        this.Panel1.TabIndex = 1;
                        // 
                        // DataSetHelp
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
                        this.ClientSize = new System.Drawing.Size(214, 118);
                        this.ControlBox = false;
                        this.Controls.Add(this.lstItems);
                        this.Controls.Add(this.Panel1);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.MaximizeBox = false;
                        this.MinimizeBox = false;
                        this.MinimumSize = new System.Drawing.Size(64, 24);
                        this.Name = "DataSetHelp";
                        this.ShowIcon = false;
                        this.ShowInTaskbar = false;
                        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                        this.TopMost = true;
                        this.VisibleChanged += new System.EventHandler(this.FormAyudaDataSet_VisibleChanged);
                        this.ResumeLayout(false);

		}


		#endregion
	}
}
