using System;
using System.Collections;
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
		private System.ComponentModel.Container components = null;

		// NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
		// Puede modificarse utilizando el Diseñador de Windows Forms. 
		// No lo modifique con el editor de código.
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label lblError;
		internal System.Windows.Forms.Label lblLugar;
		internal System.Windows.Forms.Label lblMensaje;
		internal System.Windows.Forms.Label lblEstadoImpresora;
		internal System.Windows.Forms.Label lblEstadoFiscal;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label lblCampos;
		internal System.Windows.Forms.Label lblComando;
		internal System.Windows.Forms.Label Label4;
		private PictureBox pictureBox1;
		internal Label DialogCaption;
		internal System.Windows.Forms.Label Label7;

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiscalError));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblEstadoImpresora = new System.Windows.Forms.Label();
            this.lblEstadoFiscal = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblComando = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DialogCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(413, 8);
            // 
            // CancelCommandButton
            // 
            this.CancelCommandButton.Location = new System.Drawing.Point(521, 8);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(76, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 20);
            this.Label1.TabIndex = 51;
            this.Label1.Text = "Error";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label1.UseMnemonic = false;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(76, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 20);
            this.Label2.TabIndex = 52;
            this.Label2.Text = "Lugar";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label2.UseMnemonic = false;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(76, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(92, 20);
            this.Label3.TabIndex = 53;
            this.Label3.Text = "Mensaje";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label3.UseMnemonic = false;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(188, 132);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(156, 20);
            this.Label5.TabIndex = 55;
            this.Label5.Text = "Estado Impresora";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label5.UseMnemonic = false;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(396, 132);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(124, 20);
            this.Label6.TabIndex = 56;
            this.Label6.Text = "Estado Fiscal";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label6.UseMnemonic = false;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.Window;
            this.lblError.Location = new System.Drawing.Point(160, 56);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(200, 20);
            this.lblError.TabIndex = 57;
            this.lblError.Text = ".";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLugar
            // 
            this.lblLugar.BackColor = System.Drawing.SystemColors.Window;
            this.lblLugar.Location = new System.Drawing.Point(160, 80);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(452, 20);
            this.lblLugar.TabIndex = 58;
            this.lblLugar.Text = ".";
            this.lblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.Window;
            this.lblMensaje.Location = new System.Drawing.Point(160, 104);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(452, 20);
            this.lblMensaje.TabIndex = 59;
            this.lblMensaje.Text = ".";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstadoImpresora
            // 
            this.lblEstadoImpresora.BackColor = System.Drawing.SystemColors.Window;
            this.lblEstadoImpresora.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoImpresora.Location = new System.Drawing.Point(188, 152);
            this.lblEstadoImpresora.Name = "lblEstadoImpresora";
            this.lblEstadoImpresora.Size = new System.Drawing.Size(200, 128);
            this.lblEstadoImpresora.TabIndex = 61;
            this.lblEstadoImpresora.Text = ".";
            // 
            // lblEstadoFiscal
            // 
            this.lblEstadoFiscal.BackColor = System.Drawing.SystemColors.Window;
            this.lblEstadoFiscal.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFiscal.Location = new System.Drawing.Point(396, 152);
            this.lblEstadoFiscal.Name = "lblEstadoFiscal";
            this.lblEstadoFiscal.Size = new System.Drawing.Size(216, 128);
            this.lblEstadoFiscal.TabIndex = 62;
            this.lblEstadoFiscal.Text = ".";
            // 
            // lblCampos
            // 
            this.lblCampos.BackColor = System.Drawing.SystemColors.Window;
            this.lblCampos.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampos.Location = new System.Drawing.Point(76, 152);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(104, 128);
            this.lblCampos.TabIndex = 64;
            this.lblCampos.Text = ".";
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(76, 132);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(92, 20);
            this.Label8.TabIndex = 63;
            this.Label8.Text = "Campos";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label8.UseMnemonic = false;
            // 
            // lblComando
            // 
            this.lblComando.BackColor = System.Drawing.SystemColors.Window;
            this.lblComando.Location = new System.Drawing.Point(452, 56);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(160, 20);
            this.lblComando.TabIndex = 66;
            this.lblComando.Text = ".";
            this.lblComando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(368, 56);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(108, 20);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "Comando";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label4.UseMnemonic = false;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.DarkRed;
            this.Label7.Location = new System.Drawing.Point(76, 288);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(536, 24);
            this.Label7.TabIndex = 67;
            this.Label7.Text = "Se va a anular el comprobante que se estaba imprimiendo.";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // DialogCaption
            // 
            this.DialogCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogCaption.Location = new System.Drawing.Point(76, 16);
            this.DialogCaption.Name = "DialogCaption";
            this.DialogCaption.Size = new System.Drawing.Size(376, 24);
            this.DialogCaption.TabIndex = 69;
            this.DialogCaption.Text = "Error de impresora fiscal";
            // 
            // FormFiscalError
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 16);
            this.ClientSize = new System.Drawing.Size(629, 390);
            this.Controls.Add(this.DialogCaption);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.lblEstadoFiscal);
            this.Controls.Add(this.lblEstadoImpresora);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFiscalError";
            this.Text = "Error de Impresora Fiscal";
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.Label2, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.Label6, 0);
            this.Controls.SetChildIndex(this.lblError, 0);
            this.Controls.SetChildIndex(this.lblLugar, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.lblEstadoImpresora, 0);
            this.Controls.SetChildIndex(this.lblEstadoFiscal, 0);
            this.Controls.SetChildIndex(this.Label8, 0);
            this.Controls.SetChildIndex(this.lblCampos, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.lblComando, 0);
            this.Controls.SetChildIndex(this.Label7, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.DialogCaption, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}


		#endregion

		internal void Mostrar(Lbl.Comprobantes.Impresion.Fiscal.RespuestaFiscal Res)
		{
			switch (Res.Error)
			{
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Ok:
					lblError.Text = "OK???";
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.ErrorBCC:
					lblError.Text = "BCC";
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.Error:
					lblError.Text = "Error Genérico";
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.ErrorFiscal:
					lblError.Text = "Error Fiscal";
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.ErrorImpresora:
					lblError.Text = "Error Impresora";
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.NAK:
					lblError.Text = "NAK";
					break;
				case Lbl.Comprobantes.Impresion.Fiscal.ErroresFiscales.TimeOut:
					lblError.Text = "Timeout";
					break;
			}

			lblLugar.Text = Res.Lugar;
			lblMensaje.Text = Res.Mensaje;
			lblComando.Text = Res.CodigoComando.ToString();
			lblCampos.Text = Lfx.Types.Strings.Collection2CSV(Res.Campos, Environment.NewLine);
			lblEstadoImpresora.Text = Res.ExplicarEstadoImpresora();
			lblEstadoFiscal.Text = Res.ExplicarEstadoFiscal();
			CancelCommandButton.Visible = false;
		}
	}
}