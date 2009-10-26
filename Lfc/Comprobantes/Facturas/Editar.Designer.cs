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

namespace Lfc.Comprobantes.Facturas
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Label2 = new System.Windows.Forms.Label();
                        this.EntradaFormaPago = new Lui.Forms.DetailBox();
                        this.Label10 = new System.Windows.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label11 = new System.Windows.Forms.Label();
                        this.BotonPago = new Lui.Forms.Button();
                        this.EntradaRemito = new Lui.Forms.TextBox();
                        this.PnlFormaPago = new System.Windows.Forms.Panel();
                        this.cmdPago = new Lui.Forms.Button();
                        this.PnlFormaPago.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // ProductArray
                        // 
                        this.ProductArray.AutoAgregar = true;
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
                        // EntradaFormaPago
                        // 
                        this.EntradaFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFormaPago.AutoHeight = false;
                        this.EntradaFormaPago.AutoTab = true;
                        this.EntradaFormaPago.CanCreate = true;
                        this.EntradaFormaPago.DetailField = "nombre";
                        this.EntradaFormaPago.ExtraDetailFields = null;
                        this.EntradaFormaPago.Filter = "estado=1";
                        this.EntradaFormaPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaFormaPago.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaFormaPago.FreeTextCode = "";
                        this.EntradaFormaPago.KeyField = "id_formapago";
                        this.EntradaFormaPago.Location = new System.Drawing.Point(112, 0);
                        this.EntradaFormaPago.MaxLength = 200;
                        this.EntradaFormaPago.Name = "EntradaFormaPago";
                        this.EntradaFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPago.ReadOnly = false;
                        this.EntradaFormaPago.Required = true;
                        this.EntradaFormaPago.SelectOnFocus = true;
                        this.EntradaFormaPago.Size = new System.Drawing.Size(216, 24);
                        this.EntradaFormaPago.TabIndex = 1;
                        this.EntradaFormaPago.Table = "formaspago";
                        this.EntradaFormaPago.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaFormaPago.Text = "0";
                        this.EntradaFormaPago.TextDetail = "";
                        this.EntradaFormaPago.TextInt = 0;
                        this.EntradaFormaPago.TipWhenBlank = "";
                        this.EntradaFormaPago.ToolTipText = "";
                        this.EntradaFormaPago.Leave += new System.EventHandler(this.EntradaFormaPago_Leave);
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
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AutoHeight = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.DetailField = null;
                        this.EntradaTipo.Filter = null;
                        this.EntradaTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaTipo.KeyField = null;
                        this.EntradaTipo.Location = new System.Drawing.Point(80, 80);
                        this.EntradaTipo.MaxLenght = 32767;
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Ticket|T"};
                        this.EntradaTipo.Size = new System.Drawing.Size(116, 24);
                        this.EntradaTipo.TabIndex = 11;
                        this.EntradaTipo.Table = null;
                        this.EntradaTipo.Text = "Factura A";
                        this.EntradaTipo.TextKey = "A";
                        this.EntradaTipo.TextRaw = "Factura A";
                        this.EntradaTipo.TipWhenBlank = "";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
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
                        // BotonPago
                        // 
                        this.BotonPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.BotonPago.AutoHeight = false;
                        this.BotonPago.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonPago.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonPago.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.BotonPago.Image = null;
                        this.BotonPago.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonPago.Location = new System.Drawing.Point(408, 420);
                        this.BotonPago.Name = "BotonPago";
                        this.BotonPago.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonPago.ReadOnly = false;
                        this.BotonPago.Size = new System.Drawing.Size(96, 44);
                        this.BotonPago.SubLabelPos = Lui.Forms.SubLabelPositions.Bottom;
                        this.BotonPago.Subtext = "F2";
                        this.BotonPago.TabIndex = 51;
                        this.BotonPago.Text = "Pago";
                        this.BotonPago.ToolTipText = "";
                        this.BotonPago.Visible = false;
                        this.BotonPago.Click += new System.EventHandler(this.BotonPago_Click);
                        // 
                        // EntradaRemito
                        // 
                        this.EntradaRemito.AutoHeight = false;
                        this.EntradaRemito.AutoNav = true;
                        this.EntradaRemito.AutoTab = true;
                        this.EntradaRemito.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaRemito.DecimalPlaces = -1;
                        this.EntradaRemito.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaRemito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaRemito.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaRemito.Location = new System.Drawing.Point(592, 80);
                        this.EntradaRemito.MaxLenght = 32767;
                        this.EntradaRemito.MultiLine = false;
                        this.EntradaRemito.Name = "EntradaRemito";
                        this.EntradaRemito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRemito.PasswordChar = '\0';
                        this.EntradaRemito.Prefijo = "";
                        this.EntradaRemito.ReadOnly = false;
                        this.EntradaRemito.SelectOnFocus = true;
                        this.EntradaRemito.Size = new System.Drawing.Size(92, 24);
                        this.EntradaRemito.Sufijo = "";
                        this.EntradaRemito.TabIndex = 15;
                        this.EntradaRemito.TextRaw = "";
                        this.EntradaRemito.TipWhenBlank = "";
                        this.EntradaRemito.ToolTipText = "";
                        this.EntradaRemito.TextChanged += new System.EventHandler(this.EntradaRemito_TextChanged);
                        // 
                        // PnlFormaPago
                        // 
                        this.PnlFormaPago.Controls.Add(this.Label2);
                        this.PnlFormaPago.Controls.Add(this.EntradaFormaPago);
                        this.PnlFormaPago.Location = new System.Drawing.Point(200, 80);
                        this.PnlFormaPago.Name = "PnlFormaPago";
                        this.PnlFormaPago.Size = new System.Drawing.Size(328, 24);
                        this.PnlFormaPago.TabIndex = 12;
                        // 
                        // cmdPago
                        // 
                        this.cmdPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.cmdPago.AutoHeight = false;
                        this.cmdPago.DialogResult = System.Windows.Forms.DialogResult.None;
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
                        this.cmdPago.Click += new System.EventHandler(this.BotonPago_Click);
                        // 
                        // Editar
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(692, 473);
                        this.Controls.Add(this.BotonPago);
                        this.Controls.Add(this.PnlFormaPago);
                        this.Controls.Add(this.EntradaRemito);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label10);
                        this.Name = "Editar";
                        this.Text = "Factura";
                        this.Activated += new System.EventHandler(this.Editar_Activated);
                        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFacturaEditar_KeyDown);
                        this.Controls.SetChildIndex(this.Label10, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.EntradaRemito, 0);
                        this.Controls.SetChildIndex(this.PnlFormaPago, 0);
                        this.Controls.SetChildIndex(this.ProductArray, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.BotonPago, 0);
                        this.PnlFormaPago.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal System.Windows.Forms.Label Label2;
                internal System.Windows.Forms.Label Label10;
                public Lui.Forms.ComboBox EntradaTipo;
                internal System.Windows.Forms.Label Label11;
                internal Lui.Forms.Button BotonPago;
                public Lui.Forms.DetailBox EntradaFormaPago;
                public Lui.Forms.TextBox EntradaRemito;
                internal System.Windows.Forms.Panel PnlFormaPago;
                internal Lui.Forms.Button cmdPago;
        }
}