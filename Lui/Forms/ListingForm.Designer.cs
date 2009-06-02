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

namespace Lui.Forms
{
        partial class ListingForm
        {
                #region Código generado por el Diseñador de Windows Forms

                // Requerido por el Diseñador de Windows Forms
                private System.ComponentModel.Container components = null;

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

                private void InitializeComponent()
                {
                        this.EntradaBuscar = new Lui.Forms.TextBox();
                        this.EtiquetaBuscar = new System.Windows.Forms.Label();
                        this.PanelBotonera = new System.Windows.Forms.Panel();
                        this.BotonImprimir = new Lui.Forms.Button();
                        this.BotonFiltrar = new Lui.Forms.Button();
                        this.BotonCrear = new Lui.Forms.Button();
                        this.BotonCancelar = new Lui.Forms.Button();
                        this.Listado = new Lui.Forms.ListView();
                        this.id = new System.Windows.Forms.ColumnHeader();
                        this.nombre = new System.Windows.Forms.ColumnHeader();
                        this.extra1 = new System.Windows.Forms.ColumnHeader();
                        this.extra2 = new System.Windows.Forms.ColumnHeader();
                        this.extra3 = new System.Windows.Forms.ColumnHeader();
                        this.extra4 = new System.Windows.Forms.ColumnHeader();
                        this.extra5 = new System.Windows.Forms.ColumnHeader();
                        this.extra6 = new System.Windows.Forms.ColumnHeader();
                        this.extra7 = new System.Windows.Forms.ColumnHeader();
                        this.extra8 = new System.Windows.Forms.ColumnHeader();
                        this.extra9 = new System.Windows.Forms.ColumnHeader();
                        this.extra10 = new System.Windows.Forms.ColumnHeader();
                        this.extra11 = new System.Windows.Forms.ColumnHeader();
                        this.EtiquetaCantidad = new System.Windows.Forms.Label();
                        this.PanelBotonera.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // EntradaBuscar
                        // 
                        this.EntradaBuscar.AutoHeight = false;
                        this.EntradaBuscar.AutoNav = true;
                        this.EntradaBuscar.AutoTab = false;
                        this.EntradaBuscar.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaBuscar.DecimalPlaces = -1;
                        this.EntradaBuscar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaBuscar.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.EntradaBuscar.Location = new System.Drawing.Point(8, 32);
                        this.EntradaBuscar.MaxLenght = 32767;
                        this.EntradaBuscar.MultiLine = false;
                        this.EntradaBuscar.Name = "EntradaBuscar";
                        this.EntradaBuscar.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaBuscar.PasswordChar = '\0';
                        this.EntradaBuscar.Prefijo = "";
                        this.EntradaBuscar.ReadOnly = false;
                        this.EntradaBuscar.SelectOnFocus = true;
                        this.EntradaBuscar.Size = new System.Drawing.Size(132, 24);
                        this.EntradaBuscar.Sufijo = "";
                        this.EntradaBuscar.TabIndex = 1;
                        this.EntradaBuscar.TextRaw = "";
                        this.EntradaBuscar.TipWhenBlank = "";
                        this.EntradaBuscar.ToolTipText = "Escriba el texto o parte del texto a buscar y pulse <Intro>";
                        this.EntradaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaBuscar_KeyPress);
                        // 
                        // EtiquetaBuscar
                        // 
                        this.EtiquetaBuscar.Location = new System.Drawing.Point(8, 12);
                        this.EtiquetaBuscar.Name = "EtiquetaBuscar";
                        this.EtiquetaBuscar.Size = new System.Drawing.Size(132, 20);
                        this.EtiquetaBuscar.TabIndex = 0;
                        this.EtiquetaBuscar.Text = "Buscar (F3)";
                        this.EtiquetaBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // PanelBotonera
                        // 
                        this.PanelBotonera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.PanelBotonera.Controls.Add(this.BotonImprimir);
                        this.PanelBotonera.Controls.Add(this.BotonFiltrar);
                        this.PanelBotonera.Controls.Add(this.BotonCrear);
                        this.PanelBotonera.Controls.Add(this.BotonCancelar);
                        this.PanelBotonera.Location = new System.Drawing.Point(0, 199);
                        this.PanelBotonera.Name = "PanelBotonera";
                        this.PanelBotonera.Size = new System.Drawing.Size(136, 273);
                        this.PanelBotonera.TabIndex = 50;
                        // 
                        // BotonImprimir
                        // 
                        this.BotonImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonImprimir.AutoHeight = false;
                        this.BotonImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonImprimir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonImprimir.Image = null;
                        this.BotonImprimir.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonImprimir.Location = new System.Drawing.Point(12, 164);
                        this.BotonImprimir.Name = "BotonImprimir";
                        this.BotonImprimir.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonImprimir.ReadOnly = false;
                        this.BotonImprimir.Size = new System.Drawing.Size(112, 32);
                        this.BotonImprimir.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonImprimir.Subtext = "F8";
                        this.BotonImprimir.TabIndex = 4;
                        this.BotonImprimir.Text = "Listado";
                        this.BotonImprimir.ToolTipText = "";
                        this.BotonImprimir.Visible = false;
                        this.BotonImprimir.Click += new System.EventHandler(this.BotonImprimir_Click);
                        // 
                        // BotonFiltrar
                        // 
                        this.BotonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonFiltrar.AutoHeight = false;
                        this.BotonFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonFiltrar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonFiltrar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonFiltrar.Image = null;
                        this.BotonFiltrar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonFiltrar.Location = new System.Drawing.Point(12, 12);
                        this.BotonFiltrar.Name = "BotonFiltrar";
                        this.BotonFiltrar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonFiltrar.ReadOnly = false;
                        this.BotonFiltrar.Size = new System.Drawing.Size(112, 32);
                        this.BotonFiltrar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonFiltrar.Subtext = "F2";
                        this.BotonFiltrar.TabIndex = 1;
                        this.BotonFiltrar.Text = "Filtrar";
                        this.BotonFiltrar.ToolTipText = "";
                        this.BotonFiltrar.Visible = false;
                        this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
                        // 
                        // BotonCrear
                        // 
                        this.BotonCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCrear.AutoHeight = false;
                        this.BotonCrear.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCrear.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCrear.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCrear.Image = null;
                        this.BotonCrear.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCrear.Location = new System.Drawing.Point(12, 124);
                        this.BotonCrear.Name = "BotonCrear";
                        this.BotonCrear.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCrear.ReadOnly = false;
                        this.BotonCrear.Size = new System.Drawing.Size(112, 32);
                        this.BotonCrear.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonCrear.Subtext = "F6";
                        this.BotonCrear.TabIndex = 3;
                        this.BotonCrear.Text = "Crear";
                        this.BotonCrear.ToolTipText = "";
                        this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
                        // 
                        // BotonCancelar
                        // 
                        this.BotonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonCancelar.AutoHeight = false;
                        this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonCancelar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonCancelar.Image = null;
                        this.BotonCancelar.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonCancelar.Location = new System.Drawing.Point(12, 224);
                        this.BotonCancelar.Name = "BotonCancelar";
                        this.BotonCancelar.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonCancelar.ReadOnly = false;
                        this.BotonCancelar.Size = new System.Drawing.Size(112, 40);
                        this.BotonCancelar.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonCancelar.Subtext = "Esc";
                        this.BotonCancelar.TabIndex = 5;
                        this.BotonCancelar.Text = "Volver";
                        this.BotonCancelar.ToolTipText = "";
                        this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
                        // 
                        // Listado
                        // 
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nombre,
            this.extra1,
            this.extra2,
            this.extra3,
            this.extra4,
            this.extra5,
            this.extra6,
            this.extra7,
            this.extra8,
            this.extra9,
            this.extra10,
            this.extra11});
                        this.Listado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Listado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.Listado.FullRowSelect = true;
                        this.Listado.GridLines = true;
                        this.Listado.Location = new System.Drawing.Point(148, 0);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "Listado";
                        this.Listado.Size = new System.Drawing.Size(620, 480);
                        this.Listado.TabIndex = 2;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        this.Listado.SelectedIndexChanged += new System.EventHandler(this.Listado_SelectedIndexChanged);
                        this.Listado.DoubleClick += new System.EventHandler(this.Listado_DoubleClick);
                        this.Listado.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Listado_ColumnClick);
                        this.Listado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Listado_KeyPress);
                        this.Listado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Listado_KeyDown);
                        // 
                        // id
                        // 
                        this.id.Text = "Cód";
                        this.id.Width = 64;
                        // 
                        // nombre
                        // 
                        this.nombre.Text = "Nombre";
                        this.nombre.Width = 220;
                        // 
                        // extra1
                        // 
                        this.extra1.Text = "";
                        this.extra1.Width = 160;
                        // 
                        // extra2
                        // 
                        this.extra2.Text = "";
                        this.extra2.Width = 160;
                        // 
                        // extra3
                        // 
                        this.extra3.Text = "";
                        // 
                        // extra4
                        // 
                        this.extra4.Text = "";
                        // 
                        // extra5
                        // 
                        this.extra5.Text = "";
                        // 
                        // extra6
                        // 
                        this.extra6.Text = "";
                        // 
                        // extra7
                        // 
                        this.extra7.Text = "";
                        // 
                        // extra8
                        // 
                        this.extra8.Text = "";
                        // 
                        // extra9
                        // 
                        this.extra9.Text = "";
                        // 
                        // extra10
                        // 
                        this.extra10.Text = "";
                        // 
                        // extra11
                        // 
                        this.extra11.Text = "";
                        // 
                        // EtiquetaCantidad
                        // 
                        this.EtiquetaCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaCantidad.Location = new System.Drawing.Point(8, 171);
                        this.EtiquetaCantidad.Name = "EtiquetaCantidad";
                        this.EtiquetaCantidad.Size = new System.Drawing.Size(128, 20);
                        this.EtiquetaCantidad.TabIndex = 51;
                        this.EtiquetaCantidad.Text = "0 ítem.";
                        this.EtiquetaCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // ListingForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(768, 480);
                        this.Controls.Add(this.EtiquetaCantidad);
                        this.Controls.Add(this.PanelBotonera);
                        this.Controls.Add(this.Listado);
                        this.Controls.Add(this.EntradaBuscar);
                        this.Controls.Add(this.EtiquetaBuscar);
                        this.KeyPreview = true;
                        this.Name = "ListingForm";
                        this.Text = "Listado";
                        this.Shown += new System.EventHandler(this.ListingForm_Shown);
                        this.Activated += new System.EventHandler(this.ListingForm_Activated);
                        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListingForm_KeyPress);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListingForm_KeyDown);
                        this.PanelBotonera.ResumeLayout(false);
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.ColumnHeader extra10;
                private System.Windows.Forms.Label EtiquetaCantidad;
                private System.Windows.Forms.ColumnHeader extra11;
                private System.Windows.Forms.Label EtiquetaBuscar;
                private Lui.Forms.TextBox EntradaBuscar;
                private System.Windows.Forms.Panel PanelBotonera;
                private Lui.Forms.Button BotonCancelar;
                public Lui.Forms.ListView Listado;
                public Lui.Forms.Button BotonCrear;
                public Lui.Forms.Button BotonFiltrar;
                public Lui.Forms.Button BotonImprimir;
                private System.Windows.Forms.ColumnHeader id;
                private System.Windows.Forms.ColumnHeader nombre;
                private System.Windows.Forms.ColumnHeader extra1;
                private System.Windows.Forms.ColumnHeader extra2;
                private System.Windows.Forms.ColumnHeader extra3;
                private System.Windows.Forms.ColumnHeader extra4;
                private System.Windows.Forms.ColumnHeader extra5;
                private System.Windows.Forms.ColumnHeader extra6;
                private System.Windows.Forms.ColumnHeader extra7;
                private System.Windows.Forms.ColumnHeader extra8;
                private System.Windows.Forms.ColumnHeader extra9;

        }
}