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

namespace Lfc.Comprobantes.Compra
{
	public class Crear : Lui.Forms.DialogForm
	{
		public string TipoComprob = "FP";

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
		private System.ComponentModel.IContainer components = null;
		internal Lui.Forms.Button BotonPedido;
		internal Lui.Forms.Button BotonRequerimiento;
		internal Lui.Forms.Button BotonRemito;
		internal Lui.Forms.Button BotonFactura;

		private void InitializeComponent()
		{
                        this.BotonRemito = new Lui.Forms.Button();
                        this.BotonPedido = new Lui.Forms.Button();
                        this.BotonRequerimiento = new Lui.Forms.Button();
                        this.BotonFactura = new Lui.Forms.Button();
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
                        // BotonRemito
                        // 
                        this.BotonRemito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonRemito.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonRemito.Image = null;
                        this.BotonRemito.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonRemito.Location = new System.Drawing.Point(32, 160);
                        this.BotonRemito.Name = "BotonRemito";
                        this.BotonRemito.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonRemito.ReadOnly = false;
                        this.BotonRemito.Size = new System.Drawing.Size(412, 52);
                        this.BotonRemito.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonRemito.Subtext = "Para asentar un remito de proveedor.";
                        this.BotonRemito.TabIndex = 4;
                        this.BotonRemito.Text = "Remito";
                        this.BotonRemito.Click += new System.EventHandler(this.BotonArribo_Click);
                        // 
                        // BotonPedido
                        // 
                        this.BotonPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonPedido.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonPedido.Image = null;
                        this.BotonPedido.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonPedido.Location = new System.Drawing.Point(32, 96);
                        this.BotonPedido.Name = "BotonPedido";
                        this.BotonPedido.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonPedido.ReadOnly = false;
                        this.BotonPedido.Size = new System.Drawing.Size(412, 52);
                        this.BotonPedido.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonPedido.Subtext = "Para asentar un pedido realizado.";
                        this.BotonPedido.TabIndex = 2;
                        this.BotonPedido.Text = "Pedido";
                        this.BotonPedido.Click += new System.EventHandler(this.BotonPedido_Click);
                        // 
                        // BotonRequerimiento
                        // 
                        this.BotonRequerimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonRequerimiento.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonRequerimiento.Image = null;
                        this.BotonRequerimiento.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonRequerimiento.Location = new System.Drawing.Point(32, 32);
                        this.BotonRequerimiento.Name = "BotonRequerimiento";
                        this.BotonRequerimiento.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonRequerimiento.ReadOnly = false;
                        this.BotonRequerimiento.Size = new System.Drawing.Size(412, 52);
                        this.BotonRequerimiento.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonRequerimiento.Subtext = "Para solicitar un pedido.";
                        this.BotonRequerimiento.TabIndex = 0;
                        this.BotonRequerimiento.Text = "Nota de Pedido";
                        this.BotonRequerimiento.Click += new System.EventHandler(this.BotonRequerimiento_Click);
                        // 
                        // BotonFactura
                        // 
                        this.BotonFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonFactura.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonFactura.Image = null;
                        this.BotonFactura.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonFactura.Location = new System.Drawing.Point(32, 224);
                        this.BotonFactura.Name = "BotonFactura";
                        this.BotonFactura.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonFactura.ReadOnly = false;
                        this.BotonFactura.Size = new System.Drawing.Size(412, 52);
                        this.BotonFactura.SubLabelPos = Lui.Forms.SubLabelPositions.LongBottom;
                        this.BotonFactura.Subtext = "Para asentar una factura de compra.";
                        this.BotonFactura.TabIndex = 6;
                        this.BotonFactura.Text = "Factura";
                        this.BotonFactura.Click += new System.EventHandler(this.BotonFactura_Click);
                        // 
                        // Crear
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(474, 372);
                        this.Controls.Add(this.BotonRequerimiento);
                        this.Controls.Add(this.BotonPedido);
                        this.Controls.Add(this.BotonRemito);
                        this.Controls.Add(this.BotonFactura);
                        this.Name = "Crear";
                        this.Text = "Crear Comprobante de Compra";
                        this.Activated += new System.EventHandler(this.FormPedidosCrear_Activated);
                        this.Load += new System.EventHandler(this.Crear_Load);
                        this.Controls.SetChildIndex(this.BotonFactura, 0);
                        this.Controls.SetChildIndex(this.BotonRemito, 0);
                        this.Controls.SetChildIndex(this.BotonPedido, 0);
                        this.Controls.SetChildIndex(this.BotonRequerimiento, 0);
                        this.ResumeLayout(false);

		}

		#endregion

		private void BotonRequerimiento_Click(object sender, System.EventArgs e)
		{
			TipoComprob = "NP";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void BotonPedido_Click(object sender, System.EventArgs e)
		{
                        TipoComprob = "PD";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void BotonArribo_Click(System.Object sender, System.EventArgs e)
		{
                        TipoComprob = "PD";
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void BotonFactura_Click(object sender, System.EventArgs e)
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
					this.BotonRequerimiento.Focus();
					break;

				case "PD":
					this.BotonPedido.Focus();
					break;

				case "RP":
                                case "R":
					this.BotonRemito.Focus();
					break;

				case "FP":
                                case "A":
                                case "B":
                                case "C":
                                case "E":
                                case "M":
                                case "FA":
                                case "FB":
                                case "FC":
                                case "FE":
                                case "FM":
					this.BotonFactura.Focus();
					break;
			}
		}

		private void Crear_Load(object sender, EventArgs e)
		{
			OkButton.Visible = false;
		}
	}
}
