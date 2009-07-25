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

namespace Lfc.Articulos
{
	partial class Rendimiento
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
			this.label19 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRendimiento = new Lui.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
                        this.txtUnidad = new Lui.Forms.ComboBox();
                        this.txtUnidadRend = new Lui.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(159, 8);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(267, 8);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(25, 25);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(170, 24);
			this.label19.TabIndex = 0;
			this.label19.Text = "El artículo se compra en";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "de";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRendimiento
			// 
			this.txtRendimiento.AutoNav = true;
			this.txtRendimiento.AutoTab = true;
			this.txtRendimiento.DataType = Lui.Forms.DataTypes.Money;
			this.txtRendimiento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRendimiento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtRendimiento.Location = new System.Drawing.Point(60, 60);
			this.txtRendimiento.MaxLenght = 32767;
			this.txtRendimiento.Name = "txtRendimiento";
			this.txtRendimiento.Padding = new System.Windows.Forms.Padding(2);
			this.txtRendimiento.ReadOnly = false;
			this.txtRendimiento.Size = new System.Drawing.Size(96, 24);
			this.txtRendimiento.TabIndex = 3;
			this.txtRendimiento.Text = "0.00";
			this.txtRendimiento.TipWhenBlank = "";
			this.txtRendimiento.ToolTipText = "Precio de costo o de compra.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(305, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "c/u.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUnidad
			// 
			this.txtUnidad.AutoNav = true;
			this.txtUnidad.AutoTab = true;
			this.txtUnidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUnidad.Location = new System.Drawing.Point(195, 25);
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
			this.txtUnidad.Size = new System.Drawing.Size(140, 25);
			this.txtUnidad.TabIndex = 1;
			this.txtUnidad.Text = "Unidades";
			this.txtUnidad.TextKey = "u";
			this.txtUnidad.TipWhenBlank = "";
			this.txtUnidad.ToolTipText = "¿El artículo usa control de stock?";
			// 
			// txtUnidadRend
			// 
			this.txtUnidadRend.AutoNav = true;
			this.txtUnidadRend.AutoTab = true;
			this.txtUnidadRend.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidadRend.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUnidadRend.Location = new System.Drawing.Point(160, 60);
			this.txtUnidadRend.MaxLenght = 32767;
			this.txtUnidadRend.Name = "txtUnidadRend";
			this.txtUnidadRend.Padding = new System.Windows.Forms.Padding(2);
			this.txtUnidadRend.ReadOnly = false;
			this.txtUnidadRend.SetData = new string[] {
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
			this.txtUnidadRend.Size = new System.Drawing.Size(140, 25);
			this.txtUnidadRend.TabIndex = 4;
			this.txtUnidadRend.Text = "N/A";
			this.txtUnidadRend.TipWhenBlank = "";
			this.txtUnidadRend.ToolTipText = "¿El artículo usa control de stock?";
			// 
			// Rendimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 319);
			this.Controls.Add(this.txtUnidadRend);
			this.Controls.Add(this.txtUnidad);
			this.Controls.Add(this.txtRendimiento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label19);
			this.Name = "Rendimiento";
			this.Text = "Rendimiento";
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Label label19;
		internal System.Windows.Forms.Label label1;
		internal Lui.Forms.TextBox txtRendimiento;
		internal System.Windows.Forms.Label label2;
                internal Lui.Forms.ComboBox txtUnidad;
                internal Lui.Forms.ComboBox txtUnidadRend;
	}
}
