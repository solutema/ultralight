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
                        this.label19 = new Lui.Forms.Label();
                        this.label1 = new Lui.Forms.Label();
                        this.EntradaRendimiento = new Lui.Forms.TextBox();
                        this.label2 = new Lui.Forms.Label();
                        this.EntradaUnidad = new Lui.Forms.ComboBox();
                        this.EntradaUnidadRend = new Lui.Forms.ComboBox();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(135, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(255, 8);
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
                        this.label1.Location = new System.Drawing.Point(68, 120);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(30, 24);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "de";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaRendimiento
                        // 
                        this.EntradaRendimiento.AutoNav = true;
                        this.EntradaRendimiento.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaRendimiento.DecimalPlaces = -1;
                        this.EntradaRendimiento.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaRendimiento.Location = new System.Drawing.Point(100, 120);
                        this.EntradaRendimiento.MultiLine = false;
                        this.EntradaRendimiento.Name = "EntradaRendimiento";
                        this.EntradaRendimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRendimiento.ReadOnly = false;
                        this.EntradaRendimiento.SelectOnFocus = true;
                        this.EntradaRendimiento.Size = new System.Drawing.Size(96, 24);
                        this.EntradaRendimiento.TabIndex = 3;
                        this.EntradaRendimiento.Text = "0.00";
                        this.EntradaRendimiento.PlaceholderText = "Precio de costo o de compra.";
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(316, 120);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(40, 24);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "c/u.";
                        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaUnidad
                        // 
                        this.EntradaUnidad.AlwaysExpanded = true;
                        this.EntradaUnidad.AutoNav = true;
                        this.EntradaUnidad.AutoSize = true;
                        this.EntradaUnidad.Location = new System.Drawing.Point(200, 24);
                        this.EntradaUnidad.Name = "EntradaUnidad";
                        this.EntradaUnidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUnidad.ReadOnly = false;
                        this.EntradaUnidad.SetData = new string[] {
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
                        this.EntradaUnidad.Size = new System.Drawing.Size(112, 81);
                        this.EntradaUnidad.TabIndex = 1;
                        this.EntradaUnidad.TextKey = "u";
                        this.EntradaUnidad.PlaceholderText = "¿El artículo usa control de stock?";
                        // 
                        // EntradaUnidadRend
                        // 
                        this.EntradaUnidadRend.AlwaysExpanded = true;
                        this.EntradaUnidadRend.AutoNav = true;
                        this.EntradaUnidadRend.AutoSize = true;
                        this.EntradaUnidadRend.Location = new System.Drawing.Point(200, 120);
                        this.EntradaUnidadRend.Name = "EntradaUnidadRend";
                        this.EntradaUnidadRend.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUnidadRend.ReadOnly = false;
                        this.EntradaUnidadRend.SetData = new string[] {
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
                        this.EntradaUnidadRend.Size = new System.Drawing.Size(112, 81);
                        this.EntradaUnidadRend.TabIndex = 4;
                        this.EntradaUnidadRend.TextKey = "";
                        this.EntradaUnidadRend.PlaceholderText = "¿El artículo usa control de stock?";
                        // 
                        // Rendimiento
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(375, 319);
                        this.Controls.Add(this.EntradaUnidad);
                        this.Controls.Add(this.EntradaUnidadRend);
                        this.Controls.Add(this.label19);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.EntradaRendimiento);
                        this.Name = "Rendimiento";
                        this.Text = "Rendimiento";
                        this.Controls.SetChildIndex(this.EntradaRendimiento, 0);
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.label19, 0);
                        this.Controls.SetChildIndex(this.EntradaUnidadRend, 0);
                        this.Controls.SetChildIndex(this.EntradaUnidad, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

		}

		#endregion

		internal Lui.Forms.Label label19;
		internal Lui.Forms.Label label1;
		internal Lui.Forms.TextBox EntradaRendimiento;
		internal Lui.Forms.Label label2;
                internal Lui.Forms.ComboBox EntradaUnidad;
                internal Lui.Forms.ComboBox EntradaUnidadRend;
	}
}
