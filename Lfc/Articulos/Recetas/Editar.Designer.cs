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

namespace Lfc.Articulos.Recetas
{
	partial class Editar
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNombre = new Lui.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtDescripcion = new Lui.Forms.TextBox();
                        this.txtUnidad = new Lui.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.Articulos = new Lui.Forms.ProductArray();
			this.txtCategoria = new Lui.Forms.DetailBox();
			this.Label2 = new System.Windows.Forms.Label();
                        this.txtDestacado = new Lui.Forms.ComboBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtPVP = new Lui.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.AutoNav = true;
			this.txtNombre.AutoTab = true;
			this.txtNombre.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtNombre.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNombre.Location = new System.Drawing.Point(91, 55);
			this.txtNombre.MaxLenght = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Padding = new System.Windows.Forms.Padding(2);
			this.txtNombre.ReadOnly = false;
			this.txtNombre.SelectOnFocus = false;
			this.txtNombre.Size = new System.Drawing.Size(585, 24);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.TipWhenBlank = "";
			this.txtNombre.ToolTipText = "Nombre completo del artículo";
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(15, 55);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(76, 24);
			this.Label5.TabIndex = 2;
			this.Label5.Text = "Nombre";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label13
			// 
			this.Label13.Location = new System.Drawing.Point(15, 85);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(76, 24);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "Descrip.";
			this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescripcion.AutoNav = true;
			this.txtDescripcion.AutoTab = true;
			this.txtDescripcion.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtDescripcion.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtDescripcion.Location = new System.Drawing.Point(91, 85);
			this.txtDescripcion.MaxLenght = 32767;
			this.txtDescripcion.MultiLine = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Padding = new System.Windows.Forms.Padding(2);
			this.txtDescripcion.ReadOnly = false;
			this.txtDescripcion.SelectOnFocus = false;
			this.txtDescripcion.Size = new System.Drawing.Size(585, 55);
			this.txtDescripcion.TabIndex = 5;
			this.txtDescripcion.TipWhenBlank = "";
			this.txtDescripcion.ToolTipText = "Descripción larga";
			// 
			// txtUnidad
			// 
			this.txtUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUnidad.AutoNav = true;
			this.txtUnidad.AutoTab = true;
			this.txtUnidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUnidad.Location = new System.Drawing.Point(92, 145);
			this.txtUnidad.MaxLenght = 32767;
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Padding = new System.Windows.Forms.Padding(2);
			this.txtUnidad.ReadOnly = false;
			this.txtUnidad.SetData = new string[] {
        "N/A|",
        "Unidades|u",
        "Bolsas|bolsa",
        "Baldes|balde",
        "Rollos|rollo",
        "Cajas|caja",
        "Fajos|fajo",
        "Metros|m",
        "Metros²|m²",
        "Metros³|m³",
        "Centímetros|cm",
        "Centímetros³|cm³",
        "Litros|l",
        "Kg|kg"};
			this.txtUnidad.Size = new System.Drawing.Size(113, 24);
			this.txtUnidad.TabIndex = 7;
			this.txtUnidad.Text = "Unidades";
			this.txtUnidad.TextKey = "u";
			this.txtUnidad.TipWhenBlank = "";
			this.txtUnidad.ToolTipText = "¿El artículo usa control de stock?";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(16, 145);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(76, 24);
			this.label19.TabIndex = 6;
			this.label19.Text = "Unidad";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Articulos
			// 
			this.Articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				    | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Articulos.AutoAgregar = false;
			this.Articulos.AutoScrollMargin = new System.Drawing.Size(4, 4);
			this.Articulos.BackColor = System.Drawing.SystemColors.Control;
			this.Articulos.Changed = false;
			this.Articulos.Count = 0;
			this.Articulos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Articulos.FreeTextCode = "";
			this.Articulos.Location = new System.Drawing.Point(15, 185);
			this.Articulos.LockPrice = false;
			this.Articulos.LockQuantity = false;
			this.Articulos.LockText = false;
			this.Articulos.MaxLength = 200;
			this.Articulos.Name = "Articulos";
			this.Articulos.Precio = Lui.Forms.Product.Precios.PVP;
			this.Articulos.ShowStock = false;
			this.Articulos.Size = new System.Drawing.Size(660, 215);
			this.Articulos.TabIndex = 12;
			this.Articulos.Visible = false;
			this.Articulos.Workspace = null;
			// 
			// txtCategoria
			// 
			this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCategoria.AutoTab = true;
			this.txtCategoria.CanCreate = true;
			this.txtCategoria.DetailField = "nombre";
			this.txtCategoria.ExtraDetailFields = null;
			this.txtCategoria.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCategoria.FreeTextCode = "";
			this.txtCategoria.KeyField = "id_cat_articulo";
			this.txtCategoria.Location = new System.Drawing.Point(90, 25);
			this.txtCategoria.MaxLength = 200;
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Padding = new System.Windows.Forms.Padding(2);
			this.txtCategoria.ReadOnly = false;
			this.txtCategoria.Required = true;
			this.txtCategoria.SelectOnFocus = false;
			this.txtCategoria.Size = new System.Drawing.Size(349, 24);
			this.txtCategoria.TabIndex = 1;
			this.txtCategoria.Table = "cat_articulos";
			this.txtCategoria.TeclaDespuesDeEnter = "{tab}";
			this.txtCategoria.Text = "0";
			this.txtCategoria.TextDetail = "";
			this.txtCategoria.TextInt = 0;
			this.txtCategoria.TipWhenBlank = "";
			this.txtCategoria.ToolTipText = "Rubro o categoría";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(14, 25);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(76, 24);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "Categoría";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDestacado
			// 
			this.txtDestacado.AutoNav = true;
			this.txtDestacado.AutoTab = true;
			this.txtDestacado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestacado.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtDestacado.Location = new System.Drawing.Point(301, 145);
			this.txtDestacado.MaxLenght = 32767;
			this.txtDestacado.Name = "txtDestacado";
			this.txtDestacado.Padding = new System.Windows.Forms.Padding(2);
			this.txtDestacado.ReadOnly = false;
			this.txtDestacado.SetData = new string[] {
        "Si|1",
        "No|0"};
			this.txtDestacado.Size = new System.Drawing.Size(64, 24);
			this.txtDestacado.TabIndex = 9;
			this.txtDestacado.Text = "No";
			this.txtDestacado.TextKey = "0";
			this.txtDestacado.TipWhenBlank = "";
			this.txtDestacado.ToolTipText = "";
			// 
			// Label15
			// 
			this.Label15.Location = new System.Drawing.Point(225, 145);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(76, 24);
			this.Label15.TabIndex = 8;
			this.Label15.Text = "Destacado";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPVP
			// 
			this.txtPVP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPVP.AutoNav = true;
			this.txtPVP.AutoTab = true;
			this.txtPVP.DataType = Lui.Forms.DataTypes.Money;
			this.txtPVP.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPVP.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPVP.Location = new System.Drawing.Point(425, 145);
			this.txtPVP.MaxLenght = 32767;
			this.txtPVP.Name = "txtPVP";
			this.txtPVP.Padding = new System.Windows.Forms.Padding(2);
			this.txtPVP.ReadOnly = false;
			this.txtPVP.Size = new System.Drawing.Size(108, 24);
			this.txtPVP.TabIndex = 11;
			this.txtPVP.Text = "0.00";
			this.txtPVP.TipWhenBlank = "";
			this.txtPVP.ToolTipText = "Precio de venta al público. Puede dejar el PVP en blanco y utilizar un márgen pre" +
			    "definido a continuación";
			// 
			// Label10
			// 
			this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Label10.Location = new System.Drawing.Point(393, 145);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(32, 24);
			this.Label10.TabIndex = 10;
			this.Label10.Text = "PVP";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Editar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 473);
			this.Controls.Add(this.txtPVP);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.txtDestacado);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Articulos);
			this.Controls.Add(this.txtUnidad);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Label5);
			this.Name = "Editar";
			this.Text = "Artículo compuesto";
			this.Controls.SetChildIndex(this.Label5, 0);
			this.Controls.SetChildIndex(this.txtNombre, 0);
			this.Controls.SetChildIndex(this.txtDescripcion, 0);
			this.Controls.SetChildIndex(this.Label13, 0);
			this.Controls.SetChildIndex(this.label19, 0);
			this.Controls.SetChildIndex(this.txtUnidad, 0);
			this.Controls.SetChildIndex(this.Articulos, 0);
			this.Controls.SetChildIndex(this.Label2, 0);
			this.Controls.SetChildIndex(this.txtCategoria, 0);
			this.Controls.SetChildIndex(this.Label15, 0);
			this.Controls.SetChildIndex(this.txtDestacado, 0);
			this.Controls.SetChildIndex(this.Label10, 0);
			this.Controls.SetChildIndex(this.txtPVP, 0);
			this.ResumeLayout(false);

		}

		#endregion

		internal Lui.Forms.TextBox txtNombre;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label13;
		internal Lui.Forms.TextBox txtDescripcion;
                internal Lui.Forms.ComboBox txtUnidad;
		internal System.Windows.Forms.Label label19;
		private Lui.Forms.ProductArray Articulos;
		internal Lui.Forms.DetailBox txtCategoria;
		internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtDestacado;
		internal System.Windows.Forms.Label Label15;
		public Lui.Forms.TextBox txtPVP;
		internal System.Windows.Forms.Label Label10;
	}
}
