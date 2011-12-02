#region License
// Copyright 2004-2011 Carrea Ernesto N.
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

namespace ServidorFiscal
{
	public class FormFiscalError : Lui.Forms.DialogForm
	{

		#region Código generado por el Diseñador de Windows Forms

		public FormFiscalError()
			: base()
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

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal Lui.Forms.Label Label1;
		internal Lui.Forms.Label Label2;
		internal Lui.Forms.Label Label3;
		internal Lui.Forms.Label Label5;
		internal Lui.Forms.Label Label6;
		internal Lui.Forms.Label EtiquetaError;
		internal Lui.Forms.Label EtiquetaLugar;
		internal Lui.Forms.Label EtiquetaMensaje;
		internal Lui.Forms.Label EtiquetaEstadoImpresora;
		internal Lui.Forms.Label EtiquetaEstadoFiscal;
		internal Lui.Forms.Label Label8;
		internal Lui.Forms.Label EtiquetaCampos;
		internal Lui.Forms.Label EtiquetaComando;
		internal Lui.Forms.Label Label4;
		private PictureBox pictureBox1;
		internal Lui.Forms.Label DialogCaption;
		internal Lui.Forms.Label Label7;

		private void InitializeComponent()
		{
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiscalError));
                        this.Label1 = new Lui.Forms.Label();
                        this.Label2 = new Lui.Forms.Label();
                        this.Label3 = new Lui.Forms.Label();
                        this.Label5 = new Lui.Forms.Label();
                        this.Label6 = new Lui.Forms.Label();
                        this.EtiquetaError = new Lui.Forms.Label();
                        this.EtiquetaLugar = new Lui.Forms.Label();
                        this.EtiquetaMensaje = new Lui.Forms.Label();
                        this.EtiquetaEstadoImpresora = new Lui.Forms.Label();
                        this.EtiquetaEstadoFiscal = new Lui.Forms.Label();
                        this.EtiquetaCampos = new Lui.Forms.Label();
                        this.Label8 = new Lui.Forms.Label();
                        this.EtiquetaComando = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label7 = new Lui.Forms.Label();
                        this.pictureBox1 = new System.Windows.Forms.PictureBox();
                        this.DialogCaption = new Lui.Forms.Label();
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(250, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(369, 8);
                        // 
                        // Label1
                        // 
                        this.Label1.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label1.Location = new System.Drawing.Point(68, 56);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(82, 20);
                        this.Label1.TabIndex = 51;
                        this.Label1.Text = "Error";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label1.UseMnemonic = false;
                        // 
                        // Label2
                        // 
                        this.Label2.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label2.Location = new System.Drawing.Point(68, 80);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(82, 20);
                        this.Label2.TabIndex = 52;
                        this.Label2.Text = "Lugar";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label2.UseMnemonic = false;
                        // 
                        // Label3
                        // 
                        this.Label3.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label3.Location = new System.Drawing.Point(68, 104);
                        this.Label3.Name = "Label3";
                        this.Label3.Size = new System.Drawing.Size(82, 20);
                        this.Label3.TabIndex = 53;
                        this.Label3.Text = "Mensaje";
                        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label3.UseMnemonic = false;
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label5.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label5.Location = new System.Drawing.Point(167, 162);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(139, 20);
                        this.Label5.TabIndex = 55;
                        this.Label5.Text = "Estado Impresora";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label5.UseMnemonic = false;
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label6.Location = new System.Drawing.Point(352, 162);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(110, 20);
                        this.Label6.TabIndex = 56;
                        this.Label6.Text = "Estado Fiscal";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label6.UseMnemonic = false;
                        // 
                        // EtiquetaError
                        // 
                        this.EtiquetaError.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaError.Location = new System.Drawing.Point(142, 56);
                        this.EtiquetaError.Name = "EtiquetaError";
                        this.EtiquetaError.Size = new System.Drawing.Size(178, 20);
                        this.EtiquetaError.TabIndex = 57;
                        this.EtiquetaError.Text = ".";
                        // 
                        // EtiquetaLugar
                        // 
                        this.EtiquetaLugar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaLugar.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaLugar.Location = new System.Drawing.Point(142, 80);
                        this.EtiquetaLugar.Name = "EtiquetaLugar";
                        this.EtiquetaLugar.Size = new System.Drawing.Size(402, 20);
                        this.EtiquetaLugar.TabIndex = 58;
                        this.EtiquetaLugar.Text = ".";
                        // 
                        // EtiquetaMensaje
                        // 
                        this.EtiquetaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaMensaje.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaMensaje.Location = new System.Drawing.Point(142, 104);
                        this.EtiquetaMensaje.Name = "EtiquetaMensaje";
                        this.EtiquetaMensaje.Size = new System.Drawing.Size(402, 50);
                        this.EtiquetaMensaje.TabIndex = 59;
                        this.EtiquetaMensaje.Text = ".";
                        // 
                        // EtiquetaEstadoImpresora
                        // 
                        this.EtiquetaEstadoImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaEstadoImpresora.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaEstadoImpresora.Location = new System.Drawing.Point(167, 182);
                        this.EtiquetaEstadoImpresora.Name = "EtiquetaEstadoImpresora";
                        this.EtiquetaEstadoImpresora.Size = new System.Drawing.Size(178, 128);
                        this.EtiquetaEstadoImpresora.TabIndex = 61;
                        this.EtiquetaEstadoImpresora.Text = ".";
                        // 
                        // EtiquetaEstadoFiscal
                        // 
                        this.EtiquetaEstadoFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaEstadoFiscal.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaEstadoFiscal.Location = new System.Drawing.Point(352, 182);
                        this.EtiquetaEstadoFiscal.Name = "EtiquetaEstadoFiscal";
                        this.EtiquetaEstadoFiscal.Size = new System.Drawing.Size(192, 128);
                        this.EtiquetaEstadoFiscal.TabIndex = 62;
                        this.EtiquetaEstadoFiscal.Text = ".";
                        // 
                        // EtiquetaCampos
                        // 
                        this.EtiquetaCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.EtiquetaCampos.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaCampos.Location = new System.Drawing.Point(68, 182);
                        this.EtiquetaCampos.Name = "EtiquetaCampos";
                        this.EtiquetaCampos.Size = new System.Drawing.Size(92, 128);
                        this.EtiquetaCampos.TabIndex = 64;
                        this.EtiquetaCampos.Text = ".";
                        // 
                        // Label8
                        // 
                        this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label8.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label8.Location = new System.Drawing.Point(68, 162);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(82, 20);
                        this.Label8.TabIndex = 63;
                        this.Label8.Text = "Campos";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label8.UseMnemonic = false;
                        // 
                        // EtiquetaComando
                        // 
                        this.EtiquetaComando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EtiquetaComando.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.EtiquetaComando.Location = new System.Drawing.Point(402, 56);
                        this.EtiquetaComando.Name = "EtiquetaComando";
                        this.EtiquetaComando.Size = new System.Drawing.Size(142, 20);
                        this.EtiquetaComando.TabIndex = 66;
                        this.EtiquetaComando.Text = ".";
                        // 
                        // Label4
                        // 
                        this.Label4.LabelStyle = Lui.Forms.LabelStyles.Default;
                        this.Label4.Location = new System.Drawing.Point(327, 56);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(96, 20);
                        this.Label4.TabIndex = 65;
                        this.Label4.Text = "Comando";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.Label4.UseMnemonic = false;
                        // 
                        // Label7
                        // 
                        this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label7.LabelStyle = Lui.Forms.LabelStyles.Warning;
                        this.Label7.Location = new System.Drawing.Point(68, 318);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(476, 24);
                        this.Label7.TabIndex = 67;
                        this.Label7.Text = "Se va a anular el comprobante que se estaba imprimiendo.";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // pictureBox1
                        // 
                        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                        this.pictureBox1.Location = new System.Drawing.Point(14, 16);
                        this.pictureBox1.Name = "pictureBox1";
                        this.pictureBox1.Size = new System.Drawing.Size(58, 56);
                        this.pictureBox1.TabIndex = 68;
                        this.pictureBox1.TabStop = false;
                        // 
                        // DialogCaption
                        // 
                        this.DialogCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.DialogCaption.LabelStyle = Lui.Forms.LabelStyles.Title;
                        this.DialogCaption.Location = new System.Drawing.Point(68, 16);
                        this.DialogCaption.Name = "DialogCaption";
                        this.DialogCaption.Size = new System.Drawing.Size(334, 24);
                        this.DialogCaption.TabIndex = 69;
                        this.DialogCaption.Text = "Error de impresora fiscal";
                        this.DialogCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FormFiscalError
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(559, 420);
                        this.Controls.Add(this.DialogCaption);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EtiquetaComando);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.EtiquetaCampos);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.EtiquetaEstadoFiscal);
                        this.Controls.Add(this.EtiquetaEstadoImpresora);
                        this.Controls.Add(this.EtiquetaMensaje);
                        this.Controls.Add(this.EtiquetaLugar);
                        this.Controls.Add(this.EtiquetaError);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label3);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.pictureBox1);
                        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                        this.Name = "FormFiscalError";
                        this.Text = "Error de Impresora Fiscal";
                        this.Controls.SetChildIndex(this.pictureBox1, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.Label3, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.Label6, 0);
                        this.Controls.SetChildIndex(this.EtiquetaError, 0);
                        this.Controls.SetChildIndex(this.EtiquetaLugar, 0);
                        this.Controls.SetChildIndex(this.EtiquetaMensaje, 0);
                        this.Controls.SetChildIndex(this.EtiquetaEstadoImpresora, 0);
                        this.Controls.SetChildIndex(this.EtiquetaEstadoFiscal, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.EtiquetaCampos, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.EtiquetaComando, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.DialogCaption, 0);
                        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                        this.ResumeLayout(false);

		}


		#endregion

		internal void Mostrar(Lazaro.Impresion.Comprobantes.Fiscal.Respuesta Res)
		{
			switch (Res.Error)
			{
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Ok:
					EtiquetaError.Text = "OK???";
					break;
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.ErrorBCC:
					EtiquetaError.Text = "BCC";
					break;
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.Error:
					EtiquetaError.Text = "Error Genérico";
					break;
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.ErrorFiscal:
					EtiquetaError.Text = "Error Fiscal";
					break;
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.ErrorImpresora:
					EtiquetaError.Text = "Error Impresora";
					break;
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.NAK:
					EtiquetaError.Text = "NAK";
					break;
				case Lazaro.Impresion.Comprobantes.Fiscal.ErroresFiscales.TimeOut:
					EtiquetaError.Text = "Timeout";
					break;
			}

			EtiquetaLugar.Text = Res.Lugar;
			EtiquetaMensaje.Text = Res.Mensaje;
			EtiquetaComando.Text = Res.CodigoComando.ToString();
                        if (Res.Campos != null)
                                EtiquetaCampos.Text = string.Join(Environment.NewLine, Res.Campos.ToArray());
			EtiquetaEstadoImpresora.Text = Res.ExplicarEstadoImpresora();
			EtiquetaEstadoFiscal.Text = Res.ExplicarEstadoFiscal();
			CancelCommandButton.Visible = false;
		}
	}
}
