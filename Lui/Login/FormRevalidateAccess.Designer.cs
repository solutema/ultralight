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

namespace Lui.Login
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
			this.Titulo = new System.Windows.Forms.Label();
			this.txtContrasena = new Lui.Forms.TextBox();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new Lui.Forms.DetailBox();
			this.label3 = new System.Windows.Forms.Label();
			this.LabelExplain = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(261, 8);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(369, 8);
			// 
			// Titulo
			// 
			this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Titulo.Location = new System.Drawing.Point(16, 20);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(445, 24);
			this.Titulo.TabIndex = 0;
			this.Titulo.Text = "Para continuar, por favor escriba su contraseña.";
			this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtContrasena
			// 
			this.txtContrasena.AutoNav = true;
			this.txtContrasena.AutoTab = true;
			this.txtContrasena.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtContrasena.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtContrasena.Location = new System.Drawing.Point(160, 148);
			this.txtContrasena.MaxLenght = 32767;
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Padding = new System.Windows.Forms.Padding(2);
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.ReadOnly = false;
			this.txtContrasena.Size = new System.Drawing.Size(180, 24);
			this.txtContrasena.TabIndex = 4;
			this.txtContrasena.TipWhenBlank = "";
			this.txtContrasena.ToolTipText = "";
			// 
			// PictureBox2
			// 
			this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
			this.PictureBox2.Location = new System.Drawing.Point(32, 116);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(32, 32);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox2.TabIndex = 54;
			this.PictureBox2.TabStop = false;
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(72, 148);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 24);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Contraseña";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUsuario
			// 
			this.txtUsuario.AutoTab = true;
			this.txtUsuario.CanCreate = false;
			this.txtUsuario.DetailField = "nombre_visible";
			this.txtUsuario.Enabled = false;
			this.txtUsuario.ExtraDetailFields = null;
			this.txtUsuario.Filter = "(tipo&4)=4 AND contrasena<>\'\'";
			this.txtUsuario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUsuario.FreeTextCode = "";
			this.txtUsuario.KeyField = "id_persona";
			this.txtUsuario.Location = new System.Drawing.Point(160, 116);
			this.txtUsuario.MaxLength = 200;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Padding = new System.Windows.Forms.Padding(2);
			this.txtUsuario.ReadOnly = false;
			this.txtUsuario.Required = true;
			this.txtUsuario.Size = new System.Drawing.Size(288, 24);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Table = "personas";
			this.txtUsuario.TeclaDespuesDeEnter = "{tab}";
			this.txtUsuario.Text = "0";
			this.txtUsuario.TextDetail = "";
			this.txtUsuario.TextInt = 0;
			this.txtUsuario.TipWhenBlank = "";
			this.txtUsuario.ToolTipText = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(72, 116);
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
			this.LabelExplain.Location = new System.Drawing.Point(20, 52);
			this.LabelExplain.Name = "Explain";
			this.LabelExplain.Size = new System.Drawing.Size(445, 40);
			this.LabelExplain.TabIndex = 55;
			this.LabelExplain.Text = "La operación que intenta realizar requiere por motivos de seguridad que vuelva a " +
			    "escribir su contraseña.";
			this.LabelExplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormRevalidateAccess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 267);
			this.Controls.Add(this.LabelExplain);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Titulo);
			this.Name = "FormRevalidateAccess";
			this.Text = "Revalidar autorización";
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Titulo;
		internal Lui.Forms.TextBox txtContrasena;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Label Label2;
		internal Lui.Forms.DetailBox txtUsuario;
		internal System.Windows.Forms.Label label3;
		protected internal System.Windows.Forms.Label LabelExplain;
	}
}
