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

namespace Lfc.Comprobantes
{
	public class PagoVuelto: Lui.Forms.DialogForm
	{

        #region Código generado por el Diseñador de Windows Forms

        public PagoVuelto()
            :
            base()
        {

            // Necesario para admitir el Diseñador de Windows Forms
            InitializeComponent();

            // agregar código de constructor después de llamar a InitializeComponent
            OkButton.Visible = false;
        }

        // Limpiar los recursos que se estén utilizando.
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(components != null)
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
        internal Lui.Forms.TextBox txtTotal;
        internal Lui.Forms.TextBox txtPago;
        internal System.Windows.Forms.Label Label2;
        internal Lui.Forms.TextBox txtCambio;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;

        private void InitializeComponent()
        {
			this.Label1 = new System.Windows.Forms.Label();
			this.txtTotal = new Lui.Forms.TextBox();
			this.txtPago = new Lui.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtCambio = new Lui.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.DockPadding.All = 2;
			this.OkButton.Location = new System.Drawing.Point(316, 8);
			this.OkButton.Name = "OkButton";
			// 
			// CancelCommandButton
			// 
			this.CancelCommandButton.DockPadding.All = 2;
			this.CancelCommandButton.Location = new System.Drawing.Point(318, 8);
			this.CancelCommandButton.Name = "CancelCommandButton";
			// 
			// Label1
			// 
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(48, 92);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(164, 32);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Importe a Cobrar";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EntradaTotal
			// 
			this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTotal.AutoNav = true;
			this.txtTotal.AutoTab = true;
			this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
			this.txtTotal.DockPadding.All = 2;
			this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTotal.Location = new System.Drawing.Point(212, 92);
			this.txtTotal.MaxLenght = 32767;
			this.txtTotal.Name = "EntradaTotal";
			this.txtTotal.Prefijo = "$";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(152, 32);
			this.txtTotal.TabIndex = 1;
			this.txtTotal.TabStop = false;
			this.txtTotal.Text = "0.00";
			this.txtTotal.ToolTipText = "";
			this.txtTotal.Workspace = null;
			// 
			// txtPago
			// 
			this.txtPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtPago.AutoNav = true;
			this.txtPago.AutoTab = true;
			this.txtPago.DataType = Lui.Forms.DataTypes.Money;
			this.txtPago.DockPadding.All = 2;
			this.txtPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPago.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPago.Location = new System.Drawing.Point(212, 140);
			this.txtPago.MaxLenght = 32767;
			this.txtPago.Name = "txtPago";
			this.txtPago.Prefijo = "$";
			this.txtPago.ReadOnly = false;
			this.txtPago.Size = new System.Drawing.Size(152, 32);
			this.txtPago.TabIndex = 3;
			this.txtPago.Text = "0.00";
			this.txtPago.ToolTipText = "";
			this.txtPago.Workspace = null;
			this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
			// 
			// Label2
			// 
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(48, 140);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(164, 32);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Pago del Cliente";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCambio
			// 
			this.txtCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCambio.AutoNav = true;
			this.txtCambio.AutoTab = true;
			this.txtCambio.DataType = Lui.Forms.DataTypes.Money;
			this.txtCambio.DockPadding.All = 2;
			this.txtCambio.Font = new System.Drawing.Font("Bitstream Vera Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCambio.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCambio.Location = new System.Drawing.Point(212, 216);
			this.txtCambio.MaxLenght = 32767;
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Prefijo = "$";
			this.txtCambio.ReadOnly = true;
			this.txtCambio.Size = new System.Drawing.Size(152, 32);
			this.txtCambio.TabIndex = 6;
			this.txtCambio.TabStop = false;
			this.txtCambio.Text = "0.00";
			this.txtCambio.ToolTipText = "";
			this.txtCambio.Visible = false;
			this.txtCambio.Workspace = null;
			// 
			// Label3
			// 
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Label3.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(48, 216);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(164, 32);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Cambio";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PictureBox1
			// 
			this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PictureBox1.Location = new System.Drawing.Point(36, 192);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(344, 4);
			this.PictureBox1.TabIndex = 51;
			this.PictureBox1.TabStop = false;
			// 
			// Label4
			// 
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Label4.Location = new System.Drawing.Point(24, 28);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(372, 20);
			this.Label4.TabIndex = 52;
			this.Label4.Text = "Escriba el importe recibido para calcular el cambio.";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label5
			// 
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Label5.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label5.Location = new System.Drawing.Point(24, 48);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(372, 20);
			this.Label5.TabIndex = 53;
			this.Label5.Text = "O pulse la tecla <Esc> para cancelar.";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PagoVuelto
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(418, 355);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txtPago);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.Label1);
			this.Name = "PagoVuelto";
			this.Text = "Pago: Cambio";
			this.ResumeLayout(false);

		}

        #endregion

        public double Total
        {
            get
            {
                return Lfx.Types.Parsing.ParseCurrency(txtTotal.Text);
            }
            set
            {
                txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(value, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
            }
        }

        private void txtPago_TextChanged(object sender, System.EventArgs e)
        {
            txtCambio.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtPago.Text) - Lfx.Types.Parsing.ParseCurrency(txtTotal.Text), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
            txtCambio.Visible = Lfx.Types.Parsing.ParseCurrency(txtCambio.Text) >= 0;
        }
    }
}
