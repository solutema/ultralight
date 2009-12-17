// Copyright 2004-2010 South Bridge S.R.L.
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

namespace Lfc.Comprobantes.Compra
{
	public class Crear : Lui.Forms.DialogForm
	{
		public string TipoComprob = "";

		#region Código generado por el Diseñador de Windows Forms

		public Crear()
			:
		    base()
		{

			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			// agregar código de constructor después de llamar a InitializeComponent

		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}

			base.Dispose(disposing);
		}

		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components = null;
		internal Lui.Forms.Button cmdPedido;
		internal Lui.Forms.Button cmdRequerimiento;
		internal Lui.Forms.Button cmdRemito;
		internal Lui.Forms.Button cmdFactura;

		private void InitializeComponent()
		{
			this.cmdRemito = new Lui.Forms.Button();
			this.cmdPedido = new Lui.Forms.Button();
			this.cmdRequerimiento = new Lui.Forms.Button();
			this.cmdFactura = new Lui.Forms.Button();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(214, 8);
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.Location = new System.Drawing.Point(322, 8);
			// 
			// cmdRemito
			// 
			this.cmdRemito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRemito.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdRemito.Image = null;
			this.cmdRemito.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdRemito.Location = new System.Drawing.Point(16, 132);
			this.cmdRemito.Name = "cmdRemito";
			this.cmdRemito.Padding = new System.Windows.Forms.Padding(2);
			this.cmdRemito.ReadOnly = false;
			this.cmdRemito.Size = new System.Drawing.Size(396, 48);
			this.cmdRemito.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.cmdRemito.Subtext = "Para asentar un remito de proveedor.";
			this.cmdRemito.TabIndex = 4;
			this.cmdRemito.Text = "Remito";
			this.cmdRemito.ToolTipText = "";
			this.cmdRemito.Click += new System.EventHandler(this.cmdArribo_Click);
			// 
			// cmdPedido
			// 
			this.cmdPedido.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdPedido.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdPedido.Image = null;
			this.cmdPedido.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdPedido.Location = new System.Drawing.Point(16, 76);
			this.cmdPedido.Name = "cmdPedido";
			this.cmdPedido.Padding = new System.Windows.Forms.Padding(2);
			this.cmdPedido.ReadOnly = false;
			this.cmdPedido.Size = new System.Drawing.Size(396, 48);
			this.cmdPedido.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.cmdPedido.Subtext = "Para asentar un pedido realizado.";
			this.cmdPedido.TabIndex = 2;
			this.cmdPedido.Text = "Pedido";
			this.cmdPedido.ToolTipText = "";
			this.cmdPedido.Click += new System.EventHandler(this.cmdPedido_Click);
			// 
			// cmdRequerimiento
			// 
			this.cmdRequerimiento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRequerimiento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdRequerimiento.Image = null;
			this.cmdRequerimiento.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdRequerimiento.Location = new System.Drawing.Point(16, 20);
			this.cmdRequerimiento.Name = "cmdRequerimiento";
			this.cmdRequerimiento.Padding = new System.Windows.Forms.Padding(2);
			this.cmdRequerimiento.ReadOnly = false;
			this.cmdRequerimiento.Size = new System.Drawing.Size(396, 48);
			this.cmdRequerimiento.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.cmdRequerimiento.Subtext = "Para solicitar un pedido.";
			this.cmdRequerimiento.TabIndex = 0;
			this.cmdRequerimiento.Text = "Nota de Pedido";
			this.cmdRequerimiento.ToolTipText = "";
			this.cmdRequerimiento.Click += new System.EventHandler(this.cmdRequerimiento_Click);
			// 
			// cmdFactura
			// 
			this.cmdFactura.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdFactura.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFactura.Image = null;
			this.cmdFactura.ImagePos = Lui.Forms.ImagePositions.Top;
			this.cmdFactura.Location = new System.Drawing.Point(16, 188);
			this.cmdFactura.Name = "cmdFactura";
			this.cmdFactura.Padding = new System.Windows.Forms.Padding(2);
			this.cmdFactura.ReadOnly = false;
			this.cmdFactura.Size = new System.Drawing.Size(396, 48);
			this.cmdFactura.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
			this.cmdFactura.Subtext = "Para asentar una factura de compra.";
			this.cmdFactura.TabIndex = 6;
			this.cmdFactura.Text = "Factura";
			this.cmdFactura.ToolTipText = "";
			this.cmdFactura.Click += new System.EventHandler(this.cmdFactura_Click);
			// 
			// Crear
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(430, 335);
			this.Controls.Add(this.cmdFactura);
			this.Controls.Add(this.cmdRemito);
			this.Controls.Add(this.cmdPedido);
			this.Controls.Add(this.cmdRequerimiento);
			this.Name = "Crear";
			this.Activated += new System.EventHandler(this.FormPedidosCrear_Activated);
			this.Load += new System.EventHandler(this.Crear_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private void cmdRequerimiento_Click(object sender, System.EventArgs e)
		{
			TipoComprob = "NP";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void cmdPedido_Click(object sender, System.EventArgs e)
		{
			TipoComprob = "PD";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void cmdArribo_Click(System.Object sender, System.EventArgs e)
		{
			TipoComprob = "RP";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void cmdFactura_Click(object sender, System.EventArgs e)
		{
			TipoComprob = "FP";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void FormPedidosCrear_Activated(object sender, System.EventArgs e)
		{
			switch (TipoComprob)
			{
				case "NP":
					this.cmdRequerimiento.Focus();
					break;

				case "PD":
					this.cmdPedido.Focus();
					break;

				case "RP":
                                case "R":
					this.cmdRemito.Focus();
					break;

				case "FP":
                                case "A":
                                case "B":
                                case "C":
                                case "E":
                                case "M":
					this.cmdFactura.Focus();
					break;
			}
		}

		private void Crear_Load(object sender, EventArgs e)
		{
			OkButton.Visible = false;
		}
	}
}