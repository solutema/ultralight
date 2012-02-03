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

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lazaro.WinMain.Misc
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
			EntradaHistorial.BackColor = this.DisplayStyle.BackgroundColor;

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
		internal System.Windows.Forms.TextBox EntradaHistorial;
		internal Lui.Forms.TextBox EntradaFormula;
		internal Lui.Forms.Panel Panel1;
                internal System.Windows.Forms.Label EtiquetaResultado;

		private void InitializeComponent()
		{
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
                        this.EntradaHistorial = new System.Windows.Forms.TextBox();
                        this.EntradaFormula = new Lui.Forms.TextBox();
                        this.Panel1 = new Lui.Forms.Panel();
                        this.EtiquetaResultado = new Lui.Forms.Label();
                        this.Panel1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // txtHistorial
                        // 
                        this.EntradaHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.EntradaHistorial.Font = Lazaro.Pres.DisplayStyles.Template.Current.MonospacedFont;
                        this.EntradaHistorial.Location = new System.Drawing.Point(11, 54);
                        this.EntradaHistorial.Multiline = true;
                        this.EntradaHistorial.Name = "txtHistorial";
                        this.EntradaHistorial.Size = new System.Drawing.Size(199, 182);
                        this.EntradaHistorial.TabIndex = 0;
                        this.EntradaHistorial.TabStop = false;
                        this.EntradaHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.EntradaHistorial.WordWrap = false;
                        // 
                        // EntradaFormula
                        // 
                        this.EntradaFormula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFormula.AutoNav = false;
                        this.EntradaFormula.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaFormula.Location = new System.Drawing.Point(6, 239);
                        this.EntradaFormula.Name = "EntradaFormula";
                        this.EntradaFormula.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormula.Size = new System.Drawing.Size(223, 29);
                        this.EntradaFormula.TabIndex = 1;
                        this.EntradaFormula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormula_KeyDown);
                        // 
                        // Panel1
                        // 
                        this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        this.Panel1.Controls.Add(this.EtiquetaResultado);
                        this.Panel1.Location = new System.Drawing.Point(11, 10);
                        this.Panel1.Name = "Panel1";
                        this.Panel1.Size = new System.Drawing.Size(210, 39);
                        this.Panel1.TabIndex = 3;
                        // 
                        // lblResultado
                        // 
                        this.EtiquetaResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaResultado.Font = Lazaro.Pres.DisplayStyles.Template.Current.MonospacedFont;
                        this.EtiquetaResultado.Location = new System.Drawing.Point(-59, 2);
                        this.EtiquetaResultado.Name = "lblResultado";
                        this.EtiquetaResultado.Size = new System.Drawing.Size(258, 32);
                        this.EtiquetaResultado.TabIndex = 3;
                        this.EtiquetaResultado.Text = "0.00 ";
                        this.EtiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // Calculadora
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(232, 272);
                        this.Controls.Add(this.Panel1);
                        this.Controls.Add(this.EntradaFormula);
                        this.Controls.Add(this.EntradaHistorial);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "Calculadora";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Calculadora";
                        this.TopMost = true;
                        this.Activated += new System.EventHandler(this.FormCalculadora_Enter);
                        this.Deactivate += new System.EventHandler(this.FormCalculadora_Leave);
                        this.Load += new System.EventHandler(this.FormCalculadora_Load);
                        this.Enter += new System.EventHandler(this.FormCalculadora_Enter);
                        this.Leave += new System.EventHandler(this.FormCalculadora_Leave);
                        this.Panel1.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

		}


		#endregion

		public void Imprimir(string Texto)
		{
			string Temp = EntradaHistorial.Text + Environment.NewLine + Texto;
			if(Temp.Length > 32000) {
				EntradaHistorial.Text = Temp.Substring(0, 32000);
			} else {
				EntradaHistorial.Text = Temp;
			}
			EntradaHistorial.SelectionStart = EntradaHistorial.Text.Length;
			EntradaHistorial.SelectionLength = 0;
			EntradaHistorial.ScrollToCaret();
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
                                                try {
                                                        Clipboard.SetDataObject(EntradaFormula.Text);
                                                } catch {
                                                        // Error de portapapeles
                                                }
						this.Hide();
						System.Windows.Forms.SendKeys.Send("^V");
						this.Close();
					}
					break;
				case Keys.Escape:
					e.Handled = true;
					this.Close();
					break;
			}

		}


		private void Calcular()
		{
			string Texto = EntradaFormula.Text.Trim();
			string sResultado = "";
			string sResultado2 = "";

			try {
				decimal dResultado = decimal.Parse(Lfx.Types.Evaluator.Evaluate(Texto), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
				sResultado = dResultado.ToString(System.Globalization.CultureInfo.InvariantCulture);
				sResultado2 = sResultado;
			}
			catch(Exception ex) {
				sResultado = ex.Message;
				sResultado2 = Texto;
			}

			EntradaFormula.Text = "";
			Imprimir(Texto + " =");
			EntradaFormula.Text = sResultado;
			EtiquetaResultado.Text = sResultado2;
			Imprimir(sResultado2);

			EntradaFormula.SelectionStart = EntradaFormula.Text.Length;
			EntradaFormula.SelectionLength = 0;
		}


		private void FormCalculadora_Load(object sender, System.EventArgs e)
		{
			for(int i = 1; i <= 20; i++) {
				Imprimir("");
			}
		}


                protected override void OnResizeEnd(EventArgs e)
                {
                        base.OnResizeEnd(e);
                        EntradaHistorial.ScrollToCaret();
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
