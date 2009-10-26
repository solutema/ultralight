// Copyright 2004-2009 South Bridge S.R.L.
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

namespace Lfc.Comprobantes.Recibos
{
    partial class Rapido
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCuenta = new Lui.Forms.DetailBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCliente = new Lui.Forms.DetailBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtImporte = new Lui.Forms.TextBox();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(313, 8);
            // 
            // CancelCommandButton
            // 
            this.CancelCommandButton.Location = new System.Drawing.Point(421, 8);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuenta.AutoTab = true;
            this.txtCuenta.CanCreate = false;
            this.txtCuenta.DetailField = "nombre";
            this.txtCuenta.ExtraDetailFields = null;
            this.txtCuenta.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCuenta.FreeTextCode = "";
            this.txtCuenta.KeyField = "id_cuenta";
            this.txtCuenta.Location = new System.Drawing.Point(104, 160);
            this.txtCuenta.MaxLength = 200;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Padding = new System.Windows.Forms.Padding(2);
            this.txtCuenta.ReadOnly = false;
            this.txtCuenta.Required = true;
            this.txtCuenta.SelectOnFocus = false;
            this.txtCuenta.Size = new System.Drawing.Size(404, 24);
            this.txtCuenta.TabIndex = 5;
            this.txtCuenta.Table = "cuentas";
            this.txtCuenta.TeclaDespuesDeEnter = "{tab}";
            this.txtCuenta.Text = "0";
            this.txtCuenta.TextDetail = "";
            this.txtCuenta.TextInt = 0;
            this.txtCuenta.TipWhenBlank = "";
            this.txtCuenta.ToolTipText = "";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(20, 160);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 24);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Cuenta";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntradaCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.AutoTab = true;
            this.txtCliente.CanCreate = false;
            this.txtCliente.DetailField = "nombre_visible";
            this.txtCliente.ExtraDetailFields = null;
            this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCliente.FreeTextCode = "";
            this.txtCliente.KeyField = "id_persona";
            this.txtCliente.Location = new System.Drawing.Point(104, 20);
            this.txtCliente.MaxLength = 200;
            this.txtCliente.Name = "EntradaCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
            this.txtCliente.ReadOnly = false;
            this.txtCliente.Required = true;
            this.txtCliente.SelectOnFocus = false;
            this.txtCliente.Size = new System.Drawing.Size(404, 24);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Table = "personas";
            this.txtCliente.TeclaDespuesDeEnter = "{tab}";
            this.txtCliente.Text = "0";
            this.txtCliente.TextDetail = "";
            this.txtCliente.TextInt = 0;
            this.txtCliente.TipWhenBlank = "";
            this.txtCliente.ToolTipText = "";
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(20, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 24);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Cliente";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImporte
            // 
            this.txtImporte.AutoNav = true;
            this.txtImporte.AutoTab = true;
            this.txtImporte.DataType = Lui.Forms.DataTypes.Money;
            this.txtImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImporte.Location = new System.Drawing.Point(104, 52);
            this.txtImporte.MaxLenght = 32767;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Padding = new System.Windows.Forms.Padding(2);
            this.txtImporte.Prefijo = "$";
            this.txtImporte.ReadOnly = false;
            this.txtImporte.Size = new System.Drawing.Size(104, 24);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.Text = "0.00";
            this.txtImporte.TipWhenBlank = "";
            this.txtImporte.ToolTipText = "";
            // 
            // lblFecha1
            // 
            this.lblFecha1.Location = new System.Drawing.Point(20, 52);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(84, 24);
            this.lblFecha1.TabIndex = 2;
            this.lblFecha1.Text = "Importe";
            this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 293);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.Label5);
            this.Name = "Rapido";
            this.Text = "Recibo rápido";
            this.ResumeLayout(false);

        }

        #endregion

        internal Lui.Forms.DetailBox txtCuenta;
        internal System.Windows.Forms.Label Label3;
        internal Lui.Forms.DetailBox txtCliente;
        internal System.Windows.Forms.Label Label5;
        internal Lui.Forms.TextBox txtImporte;
        internal System.Windows.Forms.Label lblFecha1;
    }
}