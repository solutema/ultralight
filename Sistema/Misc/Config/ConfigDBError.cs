#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc.Config
{
	public class ConfigDBError : Lui.Forms.Form
	{

		#region Código generado por el Diseñador de Windows Forms

		public ConfigDBError()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			LowerPanel.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
			lblHeader1.BackColor = Lfx.Config.Templates.Template.CambiarBrillo(Lfx.Config.Display.CurrentTemplate.WindowBackground, -10);
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		internal Lui.Forms.Button BotonConfigurar;
		internal Lui.Forms.Button BotonReintentar;
		internal Lui.Forms.Button BotonSalir;
		internal System.Windows.Forms.Label lblHeader1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Label Label1;
		private Lui.Forms.Note NotaError;
		internal System.Windows.Forms.Panel LowerPanel;

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigDBError));
			this.lblHeader1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.BotonConfigurar = new Lui.Forms.Button();
			this.Label12 = new System.Windows.Forms.Label();
			this.BotonReintentar = new Lui.Forms.Button();
			this.BotonSalir = new Lui.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.LowerPanel = new System.Windows.Forms.Panel();
			this.NotaError = new Lui.Forms.Note();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
			this.LowerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHeader1
			// 
			this.lblHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblHeader1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader1.Location = new System.Drawing.Point(56, 44);
			this.lblHeader1.Name = "lblHeader1";
			this.lblHeader1.Size = new System.Drawing.Size(552, 32);
			this.lblHeader1.TabIndex = 0;
			this.lblHeader1.Text = "No se puede establecer conexión con el servidor SQL. Esto puede deberse a una o m" +
			    "ás de las siguientes causas:";
			// 
			// Label2
			// 
			this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(100, 84);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(468, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "El servidor no está funcionando en este momento.";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label3
			// 
			this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(100, 108);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(468, 20);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "El servidor todavía no ha sido instalado o no está configurado correctamente.";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label4
			// 
			this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(100, 156);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(468, 20);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Su computadora está desconectada de la red.";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label5
			// 
			this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label5.Location = new System.Drawing.Point(100, 132);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(468, 20);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "Un cortafuegos (firewall) en esta PC o en el servidor está impidiendo la conexión" +
			    ".";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label6
			// 
			this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label6.Location = new System.Drawing.Point(80, 84);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(20, 20);
			this.Label6.TabIndex = 1;
			this.Label6.Text = "a)";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label7
			// 
			this.Label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label7.Location = new System.Drawing.Point(80, 108);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(20, 20);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "b)";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label8
			// 
			this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label8.Location = new System.Drawing.Point(80, 132);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(20, 20);
			this.Label8.TabIndex = 5;
			this.Label8.Text = "c)";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label9
			// 
			this.Label9.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label9.Location = new System.Drawing.Point(80, 156);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(20, 20);
			this.Label9.TabIndex = 7;
			this.Label9.Text = "d)";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label10
			// 
			this.Label10.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label10.Location = new System.Drawing.Point(80, 180);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(20, 20);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "e)";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label11
			// 
			this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label11.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label11.Location = new System.Drawing.Point(100, 180);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(468, 20);
			this.Label11.TabIndex = 10;
			this.Label11.Text = "Su computadora no está configurada correctamente.";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BotonConfigurar
			// 
			this.BotonConfigurar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonConfigurar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BotonConfigurar.Image = null;
			this.BotonConfigurar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.BotonConfigurar.Location = new System.Drawing.Point(148, 8);
			this.BotonConfigurar.Name = "BotonConfigurar";
			this.BotonConfigurar.Padding = new System.Windows.Forms.Padding(2);
			this.BotonConfigurar.ReadOnly = false;
			this.BotonConfigurar.Size = new System.Drawing.Size(116, 32);
			this.BotonConfigurar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.BotonConfigurar.Subtext = "F8";
			this.BotonConfigurar.TabIndex = 13;
			this.BotonConfigurar.Text = "Configurar BD";
			this.BotonConfigurar.ToolTipText = "";
			this.BotonConfigurar.Click += new System.EventHandler(this.BotonConfigurar_Click);
			// 
			// Label12
			// 
			this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label12.Location = new System.Drawing.Point(12, 208);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(598, 20);
			this.Label12.TabIndex = 11;
			this.Label12.Text = "Si fuera \"b\" o \"e\", haga clic en el botón \"Configurar BD\".";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BotonReintentar
			// 
			this.BotonReintentar.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonReintentar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BotonReintentar.Image = null;
			this.BotonReintentar.ImagePos = Lui.Forms.ImagePositions.Top;
			this.BotonReintentar.Location = new System.Drawing.Point(8, 8);
			this.BotonReintentar.Name = "BotonReintentar";
			this.BotonReintentar.Padding = new System.Windows.Forms.Padding(2);
			this.BotonReintentar.ReadOnly = false;
			this.BotonReintentar.Size = new System.Drawing.Size(132, 32);
			this.BotonReintentar.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.BotonReintentar.Subtext = "F8";
			this.BotonReintentar.TabIndex = 12;
			this.BotonReintentar.Text = "Volver a Intentar";
			this.BotonReintentar.ToolTipText = "";
			this.BotonReintentar.Click += new System.EventHandler(this.BotonReintentar_Click);
			// 
			// BotonSalir
			// 
			this.BotonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BotonSalir.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonSalir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BotonSalir.Image = null;
			this.BotonSalir.ImagePos = Lui.Forms.ImagePositions.Top;
			this.BotonSalir.Location = new System.Drawing.Point(528, 8);
			this.BotonSalir.Name = "BotonSalir";
			this.BotonSalir.Padding = new System.Windows.Forms.Padding(2);
			this.BotonSalir.ReadOnly = false;
			this.BotonSalir.Size = new System.Drawing.Size(88, 32);
			this.BotonSalir.SubLabelPos = Lui.Forms.SubLabelPositions.None;
			this.BotonSalir.Subtext = "F8";
			this.BotonSalir.TabIndex = 14;
			this.BotonSalir.Text = "Salir";
			this.BotonSalir.ToolTipText = "";
			this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(24, 244);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(24, 24);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 17;
			this.PictureBox1.TabStop = false;
			// 
			// PictureBox2
			// 
			this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
			this.PictureBox2.Location = new System.Drawing.Point(8, 8);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(28, 28);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox2.TabIndex = 18;
			this.PictureBox2.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(40, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(568, 24);
			this.Label1.TabIndex = 19;
			this.Label1.Text = "Lázaro";
			// 
			// LowerPanel
			// 
			this.LowerPanel.Controls.Add(this.BotonReintentar);
			this.LowerPanel.Controls.Add(this.BotonConfigurar);
			this.LowerPanel.Controls.Add(this.BotonSalir);
			this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LowerPanel.Location = new System.Drawing.Point(0, 359);
			this.LowerPanel.Name = "LowerPanel";
			this.LowerPanel.Size = new System.Drawing.Size(622, 48);
			this.LowerPanel.TabIndex = 20;
			// 
			// NotaError
			// 
			this.NotaError.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.NotaError.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NotaError.Location = new System.Drawing.Point(56, 240);
			this.NotaError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.NotaError.Name = "NotaError";
			this.NotaError.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NotaError.ReadOnly = false;
			this.NotaError.Size = new System.Drawing.Size(556, 112);
			this.NotaError.TabIndex = 21;
			this.NotaError.Text = "No hay más información sobre el error.";
			this.NotaError.Title = "El mensaje de error es";
			this.NotaError.ToolTipText = "";
			// 
			// FormConfigDBError
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(622, 407);
			this.Controls.Add(this.NotaError);
			this.Controls.Add(this.LowerPanel);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lblHeader1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormConfigDBError";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lázaro";
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
			this.LowerPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		#endregion

		private void BotonSalir_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}


		private void BotonReintentar_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Retry;
		}


		private void BotonConfigurar_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
		}

		public string ErrorText
		{
                        get
                        {
                                return NotaError.Text;
                        }
			set
			{
				NotaError.Text = value;
			}
		}
	}
}