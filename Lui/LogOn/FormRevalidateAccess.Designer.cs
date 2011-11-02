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

namespace Lui.LogOn
{
	partial class FormRevalidateAccess
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
			if(disposing && (components != null)) {
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRevalidateAccess));
                        this.Titulo = new Lui.Forms.Label();
                        this.EntradaContrasena = new Lui.Forms.TextBox();
                        this.PictureBox2 = new System.Windows.Forms.PictureBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaUsuario = new Lui.Forms.TextBox();
                        this.label3 = new Lui.Forms.Label();
                        this.LabelExplain = new Lui.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(234, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(354, 8);
                        // 
                        // Titulo
                        // 
                        this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Titulo.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.Titulo.Location = new System.Drawing.Point(36, 36);
                        this.Titulo.Name = "Titulo";
                        this.Titulo.Size = new System.Drawing.Size(400, 24);
                        this.Titulo.TabIndex = 0;
                        this.Titulo.Text = "Para continuar, por favor escriba su contraseña";
                        this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // EntradaContrasena
                        // 
                        this.EntradaContrasena.AutoNav = true;
                        this.EntradaContrasena.AutoTab = true;
                        this.EntradaContrasena.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaContrasena.DecimalPlaces = -1;
                        this.EntradaContrasena.FieldName = null;
                        this.EntradaContrasena.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaContrasena.Location = new System.Drawing.Point(164, 156);
                        this.EntradaContrasena.MaxLength = 32767;
                        this.EntradaContrasena.MultiLine = false;
                        this.EntradaContrasena.Name = "EntradaContrasena";
                        this.EntradaContrasena.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaContrasena.PasswordChar = '*';
                        this.EntradaContrasena.PlaceholderText = null;
                        this.EntradaContrasena.Prefijo = "";
                        this.EntradaContrasena.ReadOnly = false;
                        this.EntradaContrasena.SelectOnFocus = true;
                        this.EntradaContrasena.Size = new System.Drawing.Size(180, 24);
                        this.EntradaContrasena.Sufijo = "";
                        this.EntradaContrasena.TabIndex = 4;
                        // 
                        // PictureBox2
                        // 
                        this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
                        this.PictureBox2.Location = new System.Drawing.Point(36, 124);
                        this.PictureBox2.Name = "PictureBox2";
                        this.PictureBox2.Size = new System.Drawing.Size(32, 32);
                        this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.PictureBox2.TabIndex = 54;
                        this.PictureBox2.TabStop = false;
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(76, 156);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(88, 24);
                        this.Label2.TabIndex = 3;
                        this.Label2.Text = "Contraseña";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaUsuario
                        // 
                        this.EntradaUsuario.AutoNav = true;
                        this.EntradaUsuario.AutoTab = true;
                        this.EntradaUsuario.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaUsuario.DecimalPlaces = -1;
                        this.EntradaUsuario.Enabled = false;
                        this.EntradaUsuario.FieldName = null;
                        this.EntradaUsuario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUsuario.Location = new System.Drawing.Point(164, 124);
                        this.EntradaUsuario.MaxLength = 32767;
                        this.EntradaUsuario.MultiLine = false;
                        this.EntradaUsuario.Name = "EntradaUsuario";
                        this.EntradaUsuario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUsuario.PasswordChar = '\0';
                        this.EntradaUsuario.PlaceholderText = null;
                        this.EntradaUsuario.Prefijo = "";
                        this.EntradaUsuario.ReadOnly = false;
                        this.EntradaUsuario.SelectOnFocus = true;
                        this.EntradaUsuario.Size = new System.Drawing.Size(272, 24);
                        this.EntradaUsuario.Sufijo = "";
                        this.EntradaUsuario.TabIndex = 2;
                        this.EntradaUsuario.Text = "0";
                        // 
                        // label3
                        // 
                        this.label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.label3.Location = new System.Drawing.Point(76, 124);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(88, 24);
                        this.label3.TabIndex = 1;
                        this.label3.Text = "Usuario";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // LabelExplain
                        // 
                        this.LabelExplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelExplain.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.LabelExplain.Location = new System.Drawing.Point(36, 68);
                        this.LabelExplain.Name = "LabelExplain";
                        this.LabelExplain.Size = new System.Drawing.Size(400, 40);
                        this.LabelExplain.TabIndex = 55;
                        this.LabelExplain.Text = "La operación que intenta realizar requiere por motivos de seguridad que vuelva a " +
    "escribir su contraseña.";
                        this.LabelExplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // FormRevalidateAccess
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(474, 292);
                        this.Controls.Add(this.LabelExplain);
                        this.Controls.Add(this.EntradaUsuario);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.EntradaContrasena);
                        this.Controls.Add(this.PictureBox2);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Titulo);
                        this.Name = "FormRevalidateAccess";
                        this.Text = "Revalidar autorización";
                        this.Controls.SetChildIndex(this.Titulo, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.PictureBox2, 0);
                        this.Controls.SetChildIndex(this.EntradaContrasena, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.EntradaUsuario, 0);
                        this.Controls.SetChildIndex(this.LabelExplain, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
                        this.ResumeLayout(false);

		}

		#endregion

		private Lui.Forms.Label Titulo;
		internal Lui.Forms.TextBox EntradaContrasena;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal Lui.Forms.Label Label2;
		internal Lui.Forms.TextBox EntradaUsuario;
		internal Lui.Forms.Label label3;
		protected internal Lui.Forms.Label LabelExplain;
	}
}
