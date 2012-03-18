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

namespace Lcc.Entrada.AuxForms
{
        partial class BusquedaRapida
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
		internal System.Windows.Forms.Timer TimerRefrescar;
		internal System.Windows.Forms.ColumnHeader extra2;
		internal System.Windows.Forms.ColumnHeader extra3;
		internal System.Windows.Forms.ColumnHeader extra4;

		private void InitializeComponent()
		{
                        this.components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaRapida));
                        this.ListaItem = new Lui.Forms.ListView();
                        this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.extra4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EntradaBuscar = new Lui.Forms.TextBox();
                        this.BotonNuevo = new Lui.Forms.Button();
                        this.TimerRefrescar = new System.Windows.Forms.Timer(this.components);
                        this.EtiquetaTitulo = new Lui.Forms.Label();
                        this.EtiquetaResultados = new Lui.Forms.Label();
                        this.label2 = new Lui.Forms.Label();
                        this.EtiquetaListadoVacio = new Lui.Forms.Label();
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
                        this.ListaItem.Location = new System.Drawing.Point(32, 128);
                        this.ListaItem.MultiSelect = false;
                        this.ListaItem.Name = "ListaItem";
                        this.ListaItem.Size = new System.Drawing.Size(656, 264);
                        this.ListaItem.TabIndex = 3;
                        this.ListaItem.UseCompatibleStateImageBehavior = false;
                        this.ListaItem.View = System.Windows.Forms.View.Details;
                        this.ListaItem.SelectedIndexChanged += new System.EventHandler(this.Listado_SelectedIndexChanged);
                        this.ListaItem.DoubleClick += new System.EventHandler(this.Listado_DoubleClick);
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
                        this.EntradaBuscar.Cursor = System.Windows.Forms.Cursors.Default;
                        this.EntradaBuscar.Location = new System.Drawing.Point(32, 64);
                        this.EntradaBuscar.Name = "EntradaBuscar";
                        this.EntradaBuscar.PlaceholderText = "¿Qué está busando?";
                        this.EntradaBuscar.Size = new System.Drawing.Size(312, 24);
                        this.EntradaBuscar.TabIndex = 1;
                        this.EntradaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaBuscar_KeyPress);
                        this.EntradaBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaBuscar_KeyDown);
                        this.EntradaBuscar.TextChanged += new System.EventHandler(this.EntradaBuscar_TextChanged);
                        this.EntradaBuscar.Enter += new System.EventHandler(this.EntradaBuscar_Enter);
                        this.EntradaBuscar.Leave += new System.EventHandler(this.EntradaBuscar_Leave);
                        // 
                        // BotonNuevo
                        // 
                        this.BotonNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonNuevo.Image = null;
                        this.BotonNuevo.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonNuevo.Location = new System.Drawing.Point(592, 48);
                        this.BotonNuevo.Name = "BotonNuevo";
                        this.BotonNuevo.Size = new System.Drawing.Size(96, 40);
                        this.BotonNuevo.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonNuevo.Subtext = "F6";
                        this.BotonNuevo.TabIndex = 4;
                        this.BotonNuevo.Text = "Crear";
                        this.BotonNuevo.Click += new System.EventHandler(this.BotonNuevo_Click);
                        // 
                        // TimerRefrescar
                        // 
                        this.TimerRefrescar.Interval = 1000;
                        this.TimerRefrescar.Tick += new System.EventHandler(this.TimerRefrescar_Tick);
                        // 
                        // EtiquetaTitulo
                        // 
                        this.EtiquetaTitulo.AutoSize = true;
                        this.EtiquetaTitulo.Location = new System.Drawing.Point(24, 24);
                        this.EtiquetaTitulo.Name = "EtiquetaTitulo";
                        this.EtiquetaTitulo.Size = new System.Drawing.Size(175, 30);
                        this.EtiquetaTitulo.TabIndex = 0;
                        this.EtiquetaTitulo.Text = "Búsqueda rápida";
                        this.EtiquetaTitulo.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.MainHeader;
                        this.EtiquetaTitulo.UseMnemonic = false;
                        // 
                        // EtiquetaResultados
                        // 
                        this.EtiquetaResultados.Location = new System.Drawing.Point(32, 104);
                        this.EtiquetaResultados.Name = "EtiquetaResultados";
                        this.EtiquetaResultados.Size = new System.Drawing.Size(656, 24);
                        this.EtiquetaResultados.TabIndex = 2;
                        this.EtiquetaResultados.Text = "Seleccione de la lista o utilice el cuadro de búsqueda.";
                        // 
                        // label2
                        // 
                        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label2.Location = new System.Drawing.Point(32, 400);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(656, 32);
                        this.label2.TabIndex = 6;
                        this.label2.Text = resources.GetString("label2.Text");
                        this.label2.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        // 
                        // EtiquetaListadoVacio
                        // 
                        this.EtiquetaListadoVacio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaListadoVacio.Location = new System.Drawing.Point(32, 104);
                        this.EtiquetaListadoVacio.Name = "EtiquetaListadoVacio";
                        this.EtiquetaListadoVacio.Size = new System.Drawing.Size(656, 72);
                        this.EtiquetaListadoVacio.TabIndex = 7;
                        this.EtiquetaListadoVacio.Text = "No hay elementos para mostrar.";
                        this.EtiquetaListadoVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        this.EtiquetaListadoVacio.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Info;
                        this.EtiquetaListadoVacio.Visible = false;
                        // 
                        // BusquedaRapida
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(714, 451);
                        this.Controls.Add(this.EtiquetaListadoVacio);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.EtiquetaResultados);
                        this.Controls.Add(this.EtiquetaTitulo);
                        this.Controls.Add(this.BotonNuevo);
                        this.Controls.Add(this.EntradaBuscar);
                        this.Controls.Add(this.ListaItem);
                        this.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                        this.Name = "BusquedaRapida";
                        this.ShowInTaskbar = false;
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        this.Text = "Búsqueda rápida";
                        this.TopMost = true;
                        this.ResumeLayout(false);
                        this.PerformLayout();

		}

                private Lui.Forms.Label EtiquetaTitulo;
                private Lui.Forms.Label EtiquetaResultados;
                private Lui.Forms.Label label2;
                private Lui.Forms.Label EtiquetaListadoVacio;
	}
}
