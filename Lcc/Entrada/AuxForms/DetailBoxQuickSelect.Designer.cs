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

namespace Lcc.Entrada.AuxForms
{
	partial class DetailBoxQuickSelect
	{

		// Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

		private System.ComponentModel.IContainer components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal Lui.Forms.ListView ListaItem;
		internal System.Windows.Forms.ColumnHeader id;
		internal System.Windows.Forms.ColumnHeader nombre;
		internal Lui.Forms.TextBox EntradaBuscar;
		internal System.Windows.Forms.ColumnHeader extra1;
		internal Lui.Forms.Button BotonNuevo;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.ColumnHeader extra2;
		internal System.Windows.Forms.ColumnHeader extra3;
		internal System.Windows.Forms.ColumnHeader extra4;

		private void InitializeComponent()
		{
                        this.components = new System.ComponentModel.Container();
                        this.ListaItem = new Lui.Forms.ListView();
                        this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EntradaBuscar = new Lui.Forms.TextBox();
                        this.BotonNuevo = new Lui.Forms.Button();
                        this.Timer1 = new System.Windows.Forms.Timer(this.components);
                        this.SuspendLayout();
                        // 
                        // ListaItem
                        // 
                        this.ListaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nombre,
            this.extra1,
            this.extra2,
            this.extra3,
            this.extra4});
                        this.ListaItem.FullRowSelect = true;
                        this.ListaItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                        this.ListaItem.HideSelection = false;
                        this.ListaItem.LabelWrap = false;
                        this.ListaItem.Location = new System.Drawing.Point(0, 0);
                        this.ListaItem.MultiSelect = false;
                        this.ListaItem.Name = "ListaItem";
                        this.ListaItem.Size = new System.Drawing.Size(633, 336);
                        this.ListaItem.TabIndex = 2;
                        this.ListaItem.UseCompatibleStateImageBehavior = false;
                        this.ListaItem.View = System.Windows.Forms.View.Details;
                        this.ListaItem.SelectedIndexChanged += new System.EventHandler(this.ListaItem_SelectedIndexChanged);
                        this.ListaItem.DoubleClick += new System.EventHandler(this.ListaItem_DoubleClick);
                        this.ListaItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListaItem_KeyPress);
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
                        // EntradaBuscar
                        // 
                        this.EntradaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaBuscar.AutoNav = false;
                        this.EntradaBuscar.AutoTab = false;
                        this.EntradaBuscar.Cursor = System.Windows.Forms.Cursors.Default;
                        this.EntradaBuscar.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaBuscar.DecimalPlaces = -1;
                        this.EntradaBuscar.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaBuscar.Location = new System.Drawing.Point(4, 344);
                        this.EntradaBuscar.MultiLine = false;
                        this.EntradaBuscar.Name = "EntradaBuscar";
                        this.EntradaBuscar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBuscar.SelectOnFocus = false;
                        this.EntradaBuscar.Size = new System.Drawing.Size(524, 24);
                        this.EntradaBuscar.TabIndex = 0;
                        this.EntradaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaBuscar_KeyPress);
                        this.EntradaBuscar.TextChanged += new System.EventHandler(this.EntradaBuscar_TextChanged);
                        this.EntradaBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaBuscar_KeyDown);
                        // 
                        // BotonNuevo
                        // 
                        this.BotonNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonNuevo.Image = null;
                        this.BotonNuevo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonNuevo.Location = new System.Drawing.Point(532, 340);
                        this.BotonNuevo.Name = "BotonNuevo";
                        this.BotonNuevo.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonNuevo.Size = new System.Drawing.Size(96, 30);
                        this.BotonNuevo.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonNuevo.Subtext = "F6";
                        this.BotonNuevo.TabIndex = 1;
                        this.BotonNuevo.Text = "Crear";
                        this.BotonNuevo.Click += new System.EventHandler(this.BotonNuevo_Click);
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
                        this.Controls.Add(this.BotonNuevo);
                        this.Controls.Add(this.EntradaBuscar);
                        this.Controls.Add(this.ListaItem);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        this.KeyPreview = true;
                        this.Name = "DetailBoxQuickSelect";
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Seleccione de la Lista";
                        this.TopMost = true;
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DetailBoxQuickSelect_KeyDown);
                        this.ResumeLayout(false);

		}
	}
}
