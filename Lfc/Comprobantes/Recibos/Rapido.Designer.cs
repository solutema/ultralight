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
            this.EntradaCaja = new Lcc.Entrada.CodigoDetalle();
            this.Label3 = new Lui.Forms.Label();
            this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
            this.Label5 = new Lui.Forms.Label();
            this.EntradaImporte = new Lui.Forms.TextBox();
            this.lblFecha1 = new Lui.Forms.Label();
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
            // EntradaCaja
            // 
            this.EntradaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EntradaCaja.AutoTab = true;
            this.EntradaCaja.CanCreate = false;
            this.EntradaCaja.DataTextField = "nombre";
            this.EntradaCaja.ExtraDetailFields = null;
            this.EntradaCaja.FreeTextCode = "";
            this.EntradaCaja.DataValueField = "id_caja";
            this.EntradaCaja.Location = new System.Drawing.Point(104, 160);
            this.EntradaCaja.MaxLength = 200;
            this.EntradaCaja.Name = "EntradaCaja";
            this.EntradaCaja.Padding = new System.Windows.Forms.Padding(2);
            this.EntradaCaja.TemporaryReadOnly = false;
            this.EntradaCaja.Required = true;
            this.EntradaCaja.Size = new System.Drawing.Size(404, 24);
            this.EntradaCaja.TabIndex = 5;
            this.EntradaCaja.Table = "cajas";
            this.EntradaCaja.TeclaDespuesDeEnter = "{tab}";
            this.EntradaCaja.Text = "0";
            this.EntradaCaja.TextDetail = "";
            this.EntradaCaja.PlaceholderText = "";
            this.EntradaCaja.ToolTipText = "";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(20, 160);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 24);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Caja";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntradaCliente
            // 
            this.EntradaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EntradaCliente.AutoTab = true;
            this.EntradaCliente.CanCreate = false;
            this.EntradaCliente.DataTextField = "nombre_visible";
            this.EntradaCliente.ExtraDetailFields = null;
            this.EntradaCliente.FreeTextCode = "";
            this.EntradaCliente.DataValueField = "id_persona";
            this.EntradaCliente.Location = new System.Drawing.Point(104, 20);
            this.EntradaCliente.MaxLength = 200;
            this.EntradaCliente.Name = "EntradaCliente";
            this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
            this.EntradaCliente.TemporaryReadOnly = false;
            this.EntradaCliente.Required = true;
            this.EntradaCliente.Size = new System.Drawing.Size(404, 24);
            this.EntradaCliente.TabIndex = 1;
            this.EntradaCliente.Table = "personas";
            this.EntradaCliente.TeclaDespuesDeEnter = "{tab}";
            this.EntradaCliente.Text = "0";
            this.EntradaCliente.TextDetail = "";
            this.EntradaCliente.PlaceholderText = "";
            this.EntradaCliente.ToolTipText = "";
            this.EntradaCliente.TextChanged += new System.EventHandler(this.EntradaCliente_TextChanged);
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
            // EntradaImporte
            // 
            this.EntradaImporte.AutoNav = true;
            this.EntradaImporte.AutoTab = true;
            this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
            this.EntradaImporte.Location = new System.Drawing.Point(104, 52);
            this.EntradaImporte.Name = "EntradaImporte";
            this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
            this.EntradaImporte.Prefijo = "$";
            this.EntradaImporte.TemporaryReadOnly = false;
            this.EntradaImporte.Size = new System.Drawing.Size(104, 24);
            this.EntradaImporte.TabIndex = 3;
            this.EntradaImporte.Text = "0.00";
            this.EntradaImporte.PlaceholderText = "";
            this.EntradaImporte.ToolTipText = "";
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
            this.Controls.Add(this.EntradaImporte);
            this.Controls.Add(this.lblFecha1);
            this.Controls.Add(this.EntradaCaja);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.EntradaCliente);
            this.Controls.Add(this.Label5);
            this.Name = "Rapido";
            this.Text = "Recibo rápido";
            this.ResumeLayout(false);

        }

        #endregion

        internal Lcc.Entrada.CodigoDetalle EntradaCaja;
        internal Lui.Forms.Label Label3;
        internal Lcc.Entrada.CodigoDetalle EntradaCliente;
        internal Lui.Forms.Label Label5;
        internal Lui.Forms.TextBox EntradaImporte;
        internal Lui.Forms.Label lblFecha1;
    }
}
