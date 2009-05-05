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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.Misc
{
	public class Calculadora : Lui.Forms.Form
	{

		#region Código generado por el Diseñador de Windows Forms

		public Calculadora()
			: base()
		{


			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent
			txtHistorial.BackColor = Lws.Config.Display.CurrentTemplate.WindowBackground;

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
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.TextBox txtHistorial;
		internal Lui.Forms.TextBox txtFormula;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label lblResultado;

		private void InitializeComponent()
		{
			this.txtHistorial = new System.Windows.Forms.TextBox();
			this.txtFormula = new Lui.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.lblResultado = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtHistorial
			// 
			this.txtHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHistorial.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtHistorial.Location = new System.Drawing.Point(11, 54);
			this.txtHistorial.Multiline = true;
			this.txtHistorial.Name = "txtHistorial";
			this.txtHistorial.Size = new System.Drawing.Size(199, 182);
			this.txtHistorial.TabIndex = 0;
			this.txtHistorial.TabStop = false;
			this.txtHistorial.Text = "";
			this.txtHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtHistorial.WordWrap = false;
			// 
			// txtFormula
			// 
			this.txtFormula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFormula.AutoNav = false;
			this.txtFormula.AutoTab = false;
			this.txtFormula.BackColor = System.Drawing.Color.White;
			//WAS: BorderStyle
			this.txtFormula.Changed = false;
			this.txtFormula.DataType = Lui.Forms.DataTypes.FreeText;
			this.txtFormula.DockPadding.All = 2;
			this.txtFormula.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtFormula.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFormula.Text = "";

			this.txtFormula.Location = new System.Drawing.Point(6, 239);
			this.txtFormula.Name = "txtFormula";
			this.txtFormula.PasswordChar = (char)0;
			this.txtFormula.SelectionLength = 0;
			this.txtFormula.SelectionStart = 0;
			this.txtFormula.Size = new System.Drawing.Size(223, 29);
			this.txtFormula.ReadOnly = false;
			this.txtFormula.TabIndex = 1;
			this.txtFormula.ToolTipText = "";
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.lblResultado);
			this.Panel1.Location = new System.Drawing.Point(11, 10);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(210, 39);
			this.Panel1.TabIndex = 3;
			// 
			// lblResultado
			// 
			this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResultado.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblResultado.Location = new System.Drawing.Point(-59, 2);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(258, 32);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "0.00 ";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormCalculadora
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(232, 272);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.txtFormula);
			this.Controls.Add(this.txtHistorial);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormCalculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora";
			this.TopMost = true;
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

			txtFormula.KeyDown += new System.Windows.Forms.KeyEventHandler(txtFormula_KeyDown);
			base.Load += new System.EventHandler(FormCalculadora_Load);
			base.Resize += new System.EventHandler(FormCalculadora_Resize);
			base.Enter += new System.EventHandler(FormCalculadora_Enter); base.Activated += new System.EventHandler(FormCalculadora_Enter);
			base.Leave += new System.EventHandler(FormCalculadora_Leave); base.Deactivate += new System.EventHandler(FormCalculadora_Leave);
		}


		#endregion

		public void Imprimir(string Texto)
		{
			string Temp = txtHistorial.Text + Environment.NewLine + Texto;
			if(Temp.Length > 32000) {
				txtHistorial.Text = Temp.Substring(0, 32000);
			} else {
				txtHistorial.Text = Temp;
			}
			txtHistorial.SelectionStart = txtHistorial.Text.Length;
			txtHistorial.SelectionLength = 0;
			txtHistorial.ScrollToCaret();
		}


		private void txtFormula_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch(e.KeyCode) {
				case Keys.Return:
					e.Handled = true;
					Calcular();
					break;
				case Keys.V:
					if(e.Control == true) {
						e.Handled = true;
						Calcular();
						Clipboard.SetDataObject(txtFormula.Text);
						this.Hide();
						System.Windows.Forms.SendKeys.Send("^V");
						this.Dispose();
					}
					break;
				case Keys.Escape:
					e.Handled = true;
					this.Dispose();
					break;
			}

		}


		private void Calcular()
		{
			string Texto = txtFormula.Text.Trim();
			string sResultado = "";
			string sResultado2 = "";

			try {
				double dResultado = double.Parse(Lfx.Types.Evaluator.Evaluate(Texto), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
				sResultado = dResultado.ToString(System.Globalization.CultureInfo.InvariantCulture);
				sResultado2 = sResultado;
			}
			catch(Exception ex) {
				sResultado = ex.Message;
				sResultado2 = Texto;
			}

			txtFormula.Text = "";
			Imprimir(Texto + " =");
			txtFormula.Text = sResultado;
			lblResultado.Text = sResultado2;
			Imprimir(sResultado2);

			txtFormula.SelectionStart = txtFormula.Text.Length;
			txtFormula.SelectionLength = 0;
		}


		private void FormCalculadora_Load(object sender, System.EventArgs e)
		{
			for(int i = 1; i <= 20; i++) {
				Imprimir("");
			}
		}


		private void FormCalculadora_Resize(object sender, System.EventArgs e)
		{
			txtHistorial.ScrollToCaret();
		}


		private void FormCalculadora_Enter(object sender, System.EventArgs e)
		{
			this.Opacity = 1;
		}


		private void FormCalculadora_Leave(object sender, System.EventArgs e)
		{
			this.Opacity = 0.5;
		}
	}
}