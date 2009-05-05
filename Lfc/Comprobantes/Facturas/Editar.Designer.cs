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

namespace Lfc.Comprobantes.Facturas
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtFormaPago = new Lui.Forms.DetailBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.cmdPago = new Lui.Forms.Button();
                        this.txtRemito = new Lui.Forms.TextBox();
                        this.PnlFormaPago = new System.Windows.Forms.Panel();
                        this.PnlFormaPago.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(0, 0);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(108, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Forma de Pago";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFormaPago
                        // 
                        this.txtFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtFormaPago.AutoTab = true;
                        this.txtFormaPago.CanCreate = true;
                        this.txtFormaPago.DetailField = "nombre";
                        this.txtFormaPago.ExtraDetailFields = null;
                        this.txtFormaPago.Filter = "estado=1";
                        this.txtFormaPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFormaPago.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFormaPago.FreeTextCode = "";
                        this.txtFormaPago.KeyField = "id_formapago";
                        this.txtFormaPago.Location = new System.Drawing.Point(112, 0);
                        this.txtFormaPago.MaxLength = 200;
                        this.txtFormaPago.Name = "txtFormaPago";
                        this.txtFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFormaPago.ReadOnly = false;
                        this.txtFormaPago.Required = true;
                        this.txtFormaPago.Size = new System.Drawing.Size(216, 24);
                        this.txtFormaPago.TabIndex = 1;
                        this.txtFormaPago.Table = "formaspago";
                        this.txtFormaPago.TeclaDespuesDeEnter = "{tab}";
                        this.txtFormaPago.Text = "0";
                        this.txtFormaPago.TextDetail = "";
                        this.txtFormaPago.TextInt = 0;
                        this.txtFormaPago.TipWhenBlank = "";
                        this.txtFormaPago.ToolTipText = "";
                        this.txtFormaPago.Leave += new System.EventHandler(this.txtFormaPago_Leave);
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(8, 80);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(72, 24);
                        this.Label10.TabIndex = 10;
                        this.Label10.Text = "Tipo";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTipo.Location = new System.Drawing.Point(80, 80);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Ticket|T"};
                        this.txtTipo.Size = new System.Drawing.Size(116, 24);
                        this.txtTipo.TabIndex = 11;
                        this.txtTipo.Text = "Factura A";
                        this.txtTipo.TextKey = "A";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
                        // 
                        // Label11
                        // 
                        this.Label11.Location = new System.Drawing.Point(536, 80);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(56, 24);
                        this.Label11.TabIndex = 14;
                        this.Label11.Text = "Remito";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // cmdPago
                        // 
                        this.cmdPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.cmdPago.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.cmdPago.Image = null;
                        this.cmdPago.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.cmdPago.Location = new System.Drawing.Point(408, 420);
                        this.cmdPago.Name = "cmdPago";
                        this.cmdPago.Padding = new System.Windows.Forms.Padding(2);
                        this.cmdPago.ReadOnly = false;
                        this.cmdPago.Size = new System.Drawing.Size(96, 44);
                        this.cmdPago.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.cmdPago.Subtext = "F2";
                        this.cmdPago.TabIndex = 51;
                        this.cmdPago.Text = "Pago";
                        this.cmdPago.ToolTipText = "";
                        this.cmdPago.Visible = false;
                        this.cmdPago.Click += new System.EventHandler(this.cmdPago_Click);
                        // 
                        // txtRemito
                        // 
                        this.txtRemito.AutoNav = true;
                        this.txtRemito.AutoTab = true;
                        this.txtRemito.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtRemito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtRemito.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtRemito.Location = new System.Drawing.Point(592, 80);
                        this.txtRemito.MaxLenght = 32767;
                        this.txtRemito.Name = "txtRemito";
                        this.txtRemito.Padding = new System.Windows.Forms.Padding(2);
                        this.txtRemito.ReadOnly = false;
                        this.txtRemito.Size = new System.Drawing.Size(92, 24);
                        this.txtRemito.TabIndex = 15;
                        this.txtRemito.TipWhenBlank = "";
                        this.txtRemito.ToolTipText = "";
                        this.txtRemito.TextChanged += new System.EventHandler(this.txtRemito_TextChanged);
                        // 
                        // PnlFormaPago
                        // 
                        this.PnlFormaPago.Controls.Add(this.Label2);
                        this.PnlFormaPago.Controls.Add(this.txtFormaPago);
                        this.PnlFormaPago.Location = new System.Drawing.Point(200, 80);
                        this.PnlFormaPago.Name = "PnlFormaPago";
                        this.PnlFormaPago.Size = new System.Drawing.Size(328, 24);
                        this.PnlFormaPago.TabIndex = 12;
                        // 
                        // Editar
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.PnlFormaPago);
                        this.Controls.Add(this.txtRemito);
                        this.Controls.Add(this.cmdPago);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label10);
                        this.Name = "Editar";
                        this.Text = "Factura";
                        this.Activated += new System.EventHandler(this.Editar_Activated);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFacturaEditar_KeyDown);
                        this.Controls.SetChildIndex(this.Label10, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.cmdPago, 0);
                        this.Controls.SetChildIndex(this.txtRemito, 0);
                        this.Controls.SetChildIndex(this.PnlFormaPago, 0);
                        this.PnlFormaPago.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label10;
                public Lui.Forms.ComboBox txtTipo;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.Button cmdPago;
                public Lui.Forms.DetailBox txtFormaPago;
                public Lui.Forms.TextBox txtRemito;
                internal System.Windows.Forms.Panel PnlFormaPago;
        }
}