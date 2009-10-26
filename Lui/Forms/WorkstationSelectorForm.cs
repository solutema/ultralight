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

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
	public class WorkstationSelectorForm : Lui.Forms.DialogForm
	{
		private System.Windows.Forms.ColumnHeader NombreEstacion;
		private System.Windows.Forms.ColumnHeader Nombre;
                private Lui.Forms.ListView lvItems;
		private System.ComponentModel.IContainer components = null;
		public string Estacion;

                public WorkstationSelectorForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
                        this.lvItems = new Lui.Forms.ListView();
                        this.NombreEstacion = new System.Windows.Forms.ColumnHeader();
                        this.Nombre = new System.Windows.Forms.ColumnHeader();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(234, 8);
                        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(354, 8);
                        this.CancelCommandButton.Click += new System.EventHandler(this.CancelCommandButton_Click);
                        // 
                        // lvItems
                        // 
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreEstacion,
            this.Nombre});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.lvItems.HideSelection = false;
                        this.lvItems.LabelWrap = false;
                        this.lvItems.Location = new System.Drawing.Point(8, 8);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(460, 196);
                        this.lvItems.TabIndex = 0;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        // 
                        // NombreEstacion
                        // 
                        this.NombreEstacion.Text = "Estación";
                        this.NombreEstacion.Width = 0;
                        // 
                        // Nombre
                        // 
                        this.Nombre.Text = "Estación";
                        this.Nombre.Width = 320;
                        // 
                        // SeleccionarEstacion
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 274);
                        this.Controls.Add(this.lvItems);
                        this.Name = "SeleccionarEstacion";
                        this.WorkspaceChanged += new System.EventHandler(this.SeleccionarEstacion_WorkspaceChanged);
                        this.ResumeLayout(false);

		}
		#endregion

                new protected void OkButton_Click(object sender, System.EventArgs e)
		{
			if(lvItems.SelectedItems != null)
				this.Estacion = lvItems.SelectedItems[0].Text;
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

                internal new void CancelCommandButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}

		private void SeleccionarEstacion_WorkspaceChanged(object sender, System.EventArgs e)
		{
			lvItems.Items.Clear();
			ListViewItem itm = lvItems.Items.Add(new ListViewItem (new string[] {System.Environment.MachineName.ToUpperInvariant(), "Este equipo"}));
			itm.Selected = (this.Estacion == System.Environment.MachineName.ToUpperInvariant());

			System.Data.DataTable Estaciones = this.Workspace.DefaultDataBase.Select("SELECT DISTINCT estacion FROM sys_config ORDER BY estacion");
			foreach(System.Data.DataRow RowEstacion in Estaciones.Rows)
			{
				if((string)RowEstacion["estacion"] != "*" && (string)RowEstacion["estacion"] != System.Environment.MachineName.ToUpperInvariant())
				{
					itm = lvItems.Items.Add(new ListViewItem (new string[] {(string)RowEstacion["estacion"], (string)RowEstacion["estacion"]}));
					itm.Selected = (this.Estacion == (string)RowEstacion["estacion"]);
				}
			}		
		}
	}
}

