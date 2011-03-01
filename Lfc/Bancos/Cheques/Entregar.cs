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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lfc.Bancos.Cheques
{
	public class Entregar : Lui.Forms.DialogForm
	{
		internal System.Windows.Forms.Label label3;
		internal Lcc.Entrada.CodigoDetalle EntradaConcepto;
		internal Lui.Forms.TextBox EntradaObs;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label label5;
		internal Lui.Forms.TextBox EntradaSubTotal;
		internal System.Windows.Forms.Label Label1;
		internal Lui.Forms.TextBox EntradaCantidad;
		internal System.Windows.Forms.Label lblLabel1;
		internal System.Windows.Forms.Label label2;
		internal Lcc.Entrada.CodigoDetalle gDetailBox1;
		private System.ComponentModel.IContainer components = null;

		public Entregar()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.EntradaConcepto = new Lcc.Entrada.CodigoDetalle();
			this.EntradaObs = new Lui.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.EntradaSubTotal = new Lui.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.EntradaCantidad = new Lui.Forms.TextBox();
			this.lblLabel1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gDetailBox1 = new Lcc.Entrada.CodigoDetalle();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.DockPadding.All = 2;
			this.OkButton.Location = new System.Drawing.Point(338, 8);
			this.OkButton.Name = "OkButton";
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Location = new System.Drawing.Point(446, 8);
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "En concepto de";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EntradaConcepto
			// 
			this.EntradaConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.EntradaConcepto.AutoTab = true;
			this.EntradaConcepto.CanCreate = true;
			this.EntradaConcepto.DataTextField = "nombre";
			this.EntradaConcepto.DockPadding.All = 2;
			this.EntradaConcepto.ExtraDetailFields = null;
			this.EntradaConcepto.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaConcepto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaConcepto.FreeTextCode = "";
			this.EntradaConcepto.DataValueField = "id_concepto";
			this.EntradaConcepto.Location = new System.Drawing.Point(128, 136);
			this.EntradaConcepto.MaxLength = 200;
			this.EntradaConcepto.Name = "EntradaConcepto";
			this.EntradaConcepto.ReadOnly = false;
			this.EntradaConcepto.Required = false;
			this.EntradaConcepto.Size = new System.Drawing.Size(404, 24);
			this.EntradaConcepto.TabIndex = 8;
			this.EntradaConcepto.Table = "conceptos";
			this.EntradaConcepto.TeclaDespuesDeEnter = "{tab}";
			this.EntradaConcepto.Text = "0";
			this.EntradaConcepto.TextDetail = "";
			this.EntradaConcepto.ToolTipText = "";
			// 
			// EntradaObs
			// 
			this.EntradaObs.AutoNav = true;
			this.EntradaObs.AutoTab = true;
			this.EntradaObs.DataType = Lui.Forms.DataTypes.FreeText;
			this.EntradaObs.DockPadding.All = 2;
			this.EntradaObs.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaObs.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaObs.Location = new System.Drawing.Point(128, 172);
			this.EntradaObs.MaxLenght = 32767;
			this.EntradaObs.MultiLine = true;
			this.EntradaObs.Name = "EntradaObs";
			this.EntradaObs.ReadOnly = false;
			this.EntradaObs.SelectOnFocus = false;
			this.EntradaObs.Size = new System.Drawing.Size(404, 92);
			this.EntradaObs.TabIndex = 10;
			this.EntradaObs.ToolTipText = "";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(16, 172);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(112, 24);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Obs.";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(508, 32);
			this.label5.TabIndex = 0;
			this.label5.Text = "Va a realizar un egreso del cheque sin efectivizar (por ejemplo, al realizar un p" +
				"ago con cheques de terceros).";
			// 
			// EntradaSubTotal
			// 
			this.EntradaSubTotal.AutoNav = true;
			this.EntradaSubTotal.AutoTab = true;
			this.EntradaSubTotal.DataType = Lui.Forms.DataTypes.Currency;
			this.EntradaSubTotal.DockPadding.All = 2;
			this.EntradaSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaSubTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaSubTotal.Location = new System.Drawing.Point(368, 68);
			this.EntradaSubTotal.MaxLenght = 32767;
			this.EntradaSubTotal.Name = "EntradaSubTotal";
			this.EntradaSubTotal.Prefijo = "$";
			this.EntradaSubTotal.ReadOnly = true;
			this.EntradaSubTotal.Size = new System.Drawing.Size(108, 24);
			this.EntradaSubTotal.TabIndex = 4;
			this.EntradaSubTotal.TabStop = false;
			this.EntradaSubTotal.Text = "0.00";
			this.EntradaSubTotal.ToolTipText = "";
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(192, 68);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(176, 24);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "cheque(s) por un total de";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EntradaCantidad
			// 
			this.EntradaCantidad.AutoNav = true;
			this.EntradaCantidad.AutoTab = true;
			this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Integer;
			this.EntradaCantidad.DockPadding.All = 2;
			this.EntradaCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EntradaCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EntradaCantidad.Location = new System.Drawing.Point(128, 68);
			this.EntradaCantidad.MaxLenght = 32767;
			this.EntradaCantidad.Name = "EntradaCantidad";
			this.EntradaCantidad.ReadOnly = true;
			this.EntradaCantidad.Size = new System.Drawing.Size(56, 24);
			this.EntradaCantidad.TabIndex = 2;
			this.EntradaCantidad.TabStop = false;
			this.EntradaCantidad.Text = "0";
			this.EntradaCantidad.ToolTipText = "";
			// 
			// lblLabel1
			// 
			this.lblLabel1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLabel1.Location = new System.Drawing.Point(16, 68);
			this.lblLabel1.Name = "lblLabel1";
			this.lblLabel1.Size = new System.Drawing.Size(112, 24);
			this.lblLabel1.TabIndex = 1;
			this.lblLabel1.Text = "Entrega de";
			this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "A";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gDetailBox1
			// 
			this.gDetailBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gDetailBox1.AutoTab = true;
			this.gDetailBox1.CanCreate = true;
			this.gDetailBox1.DataTextField = "nombre_visible";
			this.gDetailBox1.DockPadding.All = 2;
			this.gDetailBox1.ExtraDetailFields = null;
			this.gDetailBox1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gDetailBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gDetailBox1.FreeTextCode = "";
			this.gDetailBox1.DataValueField = "id_persona";
			this.gDetailBox1.Location = new System.Drawing.Point(128, 104);
			this.gDetailBox1.MaxLength = 200;
			this.gDetailBox1.Name = "gDetailBox1";
			this.gDetailBox1.ReadOnly = false;
			this.gDetailBox1.Required = false;
			this.gDetailBox1.Size = new System.Drawing.Size(404, 24);
			this.gDetailBox1.TabIndex = 6;
			this.gDetailBox1.Table = "personas";
			this.gDetailBox1.TeclaDespuesDeEnter = "{tab}";
			this.gDetailBox1.Text = "0";
			this.gDetailBox1.TextDetail = "";
			this.gDetailBox1.ToolTipText = "";
			// 
			// Entregar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(554, 347);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gDetailBox1);
			this.Controls.Add(this.EntradaSubTotal);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.EntradaCantidad);
			this.Controls.Add(this.lblLabel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.EntradaObs);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.EntradaConcepto);
			this.Name = "Entregar";
			this.Text = "Entrega de cheque(s)";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

