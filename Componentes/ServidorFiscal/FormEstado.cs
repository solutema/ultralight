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

namespace ServidorFiscal
{
	public class FiscalStatus : Lui.Forms.Form
	{
		public ServidorFiscal ServidorAsociado;

		#region Código generado por el Diseñador de Windows Forms

		public FiscalStatus()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();
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
				this.QuitarIcono();
			}
			base.Dispose(disposing);
		}

		private System.ComponentModel.IContainer components;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		public System.Windows.Forms.NotifyIcon NotifyIcon1;
		internal System.Windows.Forms.ContextMenu MenuContextual;
		internal System.Windows.Forms.MenuItem MenuCerrar;
		internal System.Windows.Forms.MenuItem MenuOcultar;
		internal System.Windows.Forms.MenuItem MenuItem1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label lblEstado;
		public System.Windows.Forms.Label lblImpresora;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label lblConexion;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label lblEstadoFiscal;
		public System.Windows.Forms.Label lblPV;
		private System.Windows.Forms.Label label7;
		public Label lblVersion;
		private Label label8;
		internal System.Windows.Forms.MenuItem MenuReiniciar;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiscalStatus));
			this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.MenuContextual = new System.Windows.Forms.ContextMenu();
			this.MenuOcultar = new System.Windows.Forms.MenuItem();
			this.MenuItem1 = new System.Windows.Forms.MenuItem();
			this.MenuCerrar = new System.Windows.Forms.MenuItem();
			this.MenuReiniciar = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblImpresora = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblConexion = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEstadoFiscal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblPV = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NotifyIcon1
			// 
			this.NotifyIcon1.ContextMenu = this.MenuContextual;
			this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
			this.NotifyIcon1.Text = "Servidor Fiscal del sistema Lázaro";
			this.NotifyIcon1.Visible = true;
			this.NotifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
			// 
			// MenuContextual
			// 
			this.MenuContextual.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuOcultar,
            this.MenuItem1,
            this.MenuCerrar,
            this.MenuReiniciar});
			// 
			// MenuOcultar
			// 
			this.MenuOcultar.Index = 0;
			this.MenuOcultar.Text = "&Mostrar";
			this.MenuOcultar.Visible = false;
			this.MenuOcultar.Click += new System.EventHandler(this.MenuOcultar_Click);
			// 
			// MenuItem1
			// 
			this.MenuItem1.Index = 1;
			this.MenuItem1.Text = "-";
			this.MenuItem1.Visible = false;
			// 
			// MenuCerrar
			// 
			this.MenuCerrar.Index = 2;
			this.MenuCerrar.Text = "&Cerrar";
			this.MenuCerrar.Click += new System.EventHandler(this.MenuCerrar_Click);
			// 
			// MenuReiniciar
			// 
			this.MenuReiniciar.Index = 3;
			this.MenuReiniciar.Text = "&Reiniciar";
			this.MenuReiniciar.Click += new System.EventHandler(this.MenuReiniciar_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Operación";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEstado
			// 
			this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEstado.Location = new System.Drawing.Point(104, 68);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(259, 16);
			this.lblEstado.TabIndex = 4;
			this.lblEstado.Text = "Listo para recibir órdenes.";
			this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblImpresora
			// 
			this.lblImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblImpresora.Location = new System.Drawing.Point(104, 88);
			this.lblImpresora.Name = "lblImpresora";
			this.lblImpresora.Size = new System.Drawing.Size(259, 16);
			this.lblImpresora.TabIndex = 6;
			this.lblImpresora.Text = "Genérico";
			this.lblImpresora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Impresora";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblConexion
			// 
			this.lblConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblConexion.Location = new System.Drawing.Point(104, 108);
			this.lblConexion.Name = "lblConexion";
			this.lblConexion.Size = new System.Drawing.Size(259, 16);
			this.lblConexion.TabIndex = 8;
			this.lblConexion.Text = "COM1 a 9600 bps";
			this.lblConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 108);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "Conexión";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(343, 32);
			this.label2.TabIndex = 9;
			this.label2.Text = "Este es el componente encargado de realizar la conexión con la impresora fiscal.";
			// 
			// lblEstadoFiscal
			// 
			this.lblEstadoFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEstadoFiscal.Location = new System.Drawing.Point(104, 128);
			this.lblEstadoFiscal.Name = "lblEstadoFiscal";
			this.lblEstadoFiscal.Size = new System.Drawing.Size(259, 16);
			this.lblEstadoFiscal.TabIndex = 11;
			this.lblEstadoFiscal.Text = "0000 / 0000";
			this.lblEstadoFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Estado";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPV
			// 
			this.lblPV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPV.Location = new System.Drawing.Point(103, 148);
			this.lblPV.Name = "lblPV";
			this.lblPV.Size = new System.Drawing.Size(260, 16);
			this.lblPV.TabIndex = 13;
			this.lblPV.Text = "No está definido";
			this.lblPV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "PV";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				    | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.Location = new System.Drawing.Point(104, 168);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(260, 16);
			this.lblVersion.TabIndex = 15;
			this.lblVersion.Text = "-";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(20, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Versión";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FiscalStatus
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(380, 201);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblPV);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblEstadoFiscal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblConexion);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblImpresora);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FiscalStatus";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Servidor de Impresora Fiscal";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiscalStatus_FormClosing);
			this.Load += new System.EventHandler(this.FormFiscalEstado_Load);
			this.ResumeLayout(false);

		}


		#endregion

		private void FormFiscalEstado_Load(object sender, System.EventArgs e)
		{
			this.Listo();
		}

		internal void Estado(string Texto)
		{
			if (Texto == null || Texto.Length == 0)
				lblEstado.Text = "Preparado";
			else
				lblEstado.Text = Texto;
			this.Refresh();
		}

		internal void Listo()
		{
			Estado("");
		}


		private void NotifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.Show();
		}


		private void MenuOcultar_Click(object sender, System.EventArgs e)
		{
			if (this.Visible == false)
			{
				MenuOcultar.Text = "&Ocultar";
				this.Show();
			}
			else
			{
				MenuOcultar.Text = "&Mostrar";
				this.Hide();
			}
		}


		private void MenuReiniciar_Click(System.Object sender, System.EventArgs e)
		{
			ServidorAsociado.ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Reiniciando;
		}

		private void MenuCerrar_Click(System.Object sender, System.EventArgs e)
		{
			ServidorAsociado.ConFiscal.EstadoServidor = Lbl.Comprobantes.Impresion.Fiscal.EstadoServidorFiscal.Apagando;
		}

		public void QuitarIcono()
		{
			try
			{
				this.NotifyIcon1.Visible = false;
				this.NotifyIcon1.Dispose();
			}
			catch
			{
				//Nada
			}
		}

		private void FiscalStatus_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}
	}
}