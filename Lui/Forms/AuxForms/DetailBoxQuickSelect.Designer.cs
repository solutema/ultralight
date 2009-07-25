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

namespace Lui.Forms.AuxForms
{
	partial class DetailBoxQuickSelect
	{
		#region Código generado por el Diseñador de Windows Forms

		public DetailBoxQuickSelect()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();
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

		private System.ComponentModel.IContainer components;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.ListView lvItems;
		internal System.Windows.Forms.ColumnHeader id;
		internal System.Windows.Forms.ColumnHeader nombre;
		internal Lui.Forms.TextBox txtBuscar;
		internal System.Windows.Forms.ColumnHeader extra1;
		internal Lui.Forms.Button cmdNuevo;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.ColumnHeader extra2;
		internal System.Windows.Forms.ColumnHeader extra3;
		internal System.Windows.Forms.ColumnHeader extra4;

		private void InitializeComponent()
		{
                        this.components = new System.ComponentModel.Container();
                        this.lvItems = new System.Windows.Forms.ListView();
                        this.id = new System.Windows.Forms.ColumnHeader();
                        this.nombre = new System.Windows.Forms.ColumnHeader();
                        this.extra1 = new System.Windows.Forms.ColumnHeader();
                        this.extra2 = new System.Windows.Forms.ColumnHeader();
                        this.extra3 = new System.Windows.Forms.ColumnHeader();
                        this.extra4 = new System.Windows.Forms.ColumnHeader();
                        this.txtBuscar = new Lui.Forms.TextBox();
                        this.cmdNuevo = new Lui.Forms.Button();
                        this.Timer1 = new System.Windows.Forms.Timer(this.components);
                        this.SuspendLayout();
                        // 
                        // lvItems
                        // 
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nombre,
            this.extra1,
            this.extra2,
            this.extra3,
            this.extra4});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.lvItems.HideSelection = false;
                        this.lvItems.LabelWrap = false;
                        this.lvItems.Location = new System.Drawing.Point(0, 0);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(633, 336);
                        this.lvItems.TabIndex = 2;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
                        this.lvItems.DoubleClick += new System.EventHandler(this.lvItems_DoubleClick);
                        this.lvItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvItems_KeyPress);
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        // 
                        // nombre
                        // 
                        this.nombre.Text = "Detalle";
                        this.nombre.Width = 300;
                        // 
                        // extra1
                        // 
                        this.extra1.Text = "";
                        this.extra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.extra1.Width = 100;
                        // 
                        // extra2
                        // 
                        this.extra2.Text = "";
                        this.extra2.Width = 100;
                        // 
                        // extra3
                        // 
                        this.extra3.Text = "";
                        this.extra3.Width = 80;
                        // 
                        // extra4
                        // 
                        this.extra4.Text = "";
                        this.extra4.Width = 80;
                        // 
                        // txtBuscar
                        // 
                        this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtBuscar.AutoHeight = false;
                        this.txtBuscar.AutoNav = false;
                        this.txtBuscar.AutoTab = false;
                        this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Default;
                        this.txtBuscar.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtBuscar.DecimalPlaces = -1;
                        this.txtBuscar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.txtBuscar.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtBuscar.Location = new System.Drawing.Point(4, 344);
                        this.txtBuscar.MaxLenght = 32767;
                        this.txtBuscar.MultiLine = false;
                        this.txtBuscar.Name = "txtBuscar";
                        this.txtBuscar.Padding = new System.Windows.Forms.Padding(2);
                        this.txtBuscar.PasswordChar = '\0';
                        this.txtBuscar.Prefijo = "";
                        this.txtBuscar.ReadOnly = false;
                        this.txtBuscar.SelectOnFocus = false;
                        this.txtBuscar.Size = new System.Drawing.Size(524, 24);
                        this.txtBuscar.Sufijo = "";
                        this.txtBuscar.TabIndex = 0;
                        this.txtBuscar.TextRaw = "";
                        this.txtBuscar.TipWhenBlank = "";
                        this.txtBuscar.ToolTipText = "";
                        this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
                        this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
                        this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
                        // 
                        // cmdNuevo
                        // 
                        this.cmdNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.cmdNuevo.AutoHeight = false;
                        this.cmdNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.cmdNuevo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.cmdNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdNuevo.Image = null;
                        this.cmdNuevo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdNuevo.Location = new System.Drawing.Point(532, 340);
                        this.cmdNuevo.Name = "cmdNuevo";
                        this.cmdNuevo.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdNuevo.ReadOnly = false;
                        this.cmdNuevo.Size = new System.Drawing.Size(96, 30);
                        this.cmdNuevo.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.cmdNuevo.Subtext = "F6";
                        this.cmdNuevo.TabIndex = 1;
                        this.cmdNuevo.Text = "Crear";
                        this.cmdNuevo.ToolTipText = "";
                        this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
                        // 
                        // Timer1
                        // 
                        this.Timer1.Interval = 1000;
                        this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
                        // 
                        // DetailBoxQuickSelect
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(634, 376);
                        this.Controls.Add(this.cmdNuevo);
                        this.Controls.Add(this.txtBuscar);
                        this.Controls.Add(this.lvItems);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        this.KeyPreview = true;
                        this.Name = "DetailBoxQuickSelect";
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Seleccione de la Lista";
                        this.TopMost = true;
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscadorRapido_KeyDown);
                        this.ResumeLayout(false);

		}


		#endregion
	}
}
