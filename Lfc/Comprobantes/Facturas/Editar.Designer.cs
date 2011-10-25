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

namespace Lfc.Comprobantes.Facturas
{
        public partial class Editar
        {
                #region Código generado por el Diseñador de Windows Forms

                private void InitializeComponent()
                {
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaFormaPago = new Lcc.Entrada.CodigoDetalle();
                        this.Label10 = new Lui.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label11 = new Lui.Forms.Label();
                        this.BotonPago = new Lui.Forms.Button();
                        this.EntradaRemito = new Lui.Forms.TextBox();
                        this.PanelFormaPago = new System.Windows.Forms.Panel();
                        this.PanelFormaPago.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // ProductArray
                        // 
                        this.ProductArray.Size = new System.Drawing.Size(599, 207);
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
                        this.EntradaFormaPago.AutoNav = true;
                        this.EntradaFormaPago.AutoTab = true;
                        this.EntradaFormaPago.CanCreate = true;
                        this.EntradaFormaPago.DataTextField = "nombre";
                        this.EntradaFormaPago.DataValueField = "id_formapago";
                        this.EntradaFormaPago.ExtraDetailFields = null;
                        this.EntradaFormaPago.Filter = "cobros=1 AND estado=1";
                        this.EntradaFormaPago.FreeTextCode = "";
                        this.EntradaFormaPago.Location = new System.Drawing.Point(108, 0);
                        this.EntradaFormaPago.MaxLength = 200;
                        this.EntradaFormaPago.Name = "EntradaFormaPago";
                        this.EntradaFormaPago.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaFormaPago.PlaceholderText = "";
                        this.EntradaFormaPago.ReadOnly = false;
                        this.EntradaFormaPago.Required = true;
                        this.EntradaFormaPago.Size = new System.Drawing.Size(92, 24);
                        this.EntradaFormaPago.TabIndex = 1;
                        this.EntradaFormaPago.Table = "formaspago";
                        this.EntradaFormaPago.Text = "0";
                        this.EntradaFormaPago.TextDetail = "";
                        this.EntradaFormaPago.ToolTipText = "";
                        this.EntradaFormaPago.Leave += new System.EventHandler(this.EntradaFormaPago_Leave);
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(0, 72);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(72, 24);
                        this.Label10.TabIndex = 10;
                        this.Label10.Text = "Tipo";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.Location = new System.Drawing.Point(72, 72);
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.PlaceholderText = "";
                        this.EntradaTipo.ReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Factura A|FA",
        "Factura B|FB",
        "Factura C|FC",
        "Factura E|FE",
        "Factura M|FM",
        "Ticket|T"};
                        this.EntradaTipo.Size = new System.Drawing.Size(116, 25);
                        this.EntradaTipo.TabIndex = 11;
                        this.EntradaTipo.TextKey = "FA";
                        this.EntradaTipo.ToolTipText = "";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
                        // 
                        // Label11
                        // 
                        this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label11.Location = new System.Drawing.Point(400, 72);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(56, 24);
                        this.Label11.TabIndex = 14;
                        this.Label11.Text = "Remito";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // BotonPago
                        // 
                        this.BotonPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.BotonPago.DialogResult = System.Windows.Forms.DialogResult.None;
                        this.BotonPago.Image = null;
                        this.BotonPago.ImagePos = Lui.Forms.ImagePositions.Top;
                        this.BotonPago.Location = new System.Drawing.Point(452, 372);
                        this.BotonPago.Name = "BotonPago";
                        this.BotonPago.Padding = new System.Windows.Forms.Padding(2);
                        this.BotonPago.ReadOnly = false;
                        this.BotonPago.Size = new System.Drawing.Size(108, 28);
                        this.BotonPago.SubLabelPos = Lui.Forms.SubLabelPositions.Right;
                        this.BotonPago.Subtext = "F2";
                        this.BotonPago.TabIndex = 51;
                        this.BotonPago.Text = "Pago";
                        this.BotonPago.ToolTipText = "";
                        this.BotonPago.Visible = false;
                        this.BotonPago.Click += new System.EventHandler(this.BotonPago_Click);
                        // 
                        // EntradaRemito
                        // 
                        this.EntradaRemito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRemito.AutoNav = true;
                        this.EntradaRemito.AutoTab = true;
                        this.EntradaRemito.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaRemito.DecimalPlaces = -1;
                        this.EntradaRemito.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaRemito.Location = new System.Drawing.Point(456, 72);
                        this.EntradaRemito.MultiLine = false;
                        this.EntradaRemito.Name = "EntradaRemito";
                        this.EntradaRemito.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaRemito.PlaceholderText = "Ninguno";
                        this.EntradaRemito.ReadOnly = false;
                        this.EntradaRemito.SelectOnFocus = true;
                        this.EntradaRemito.Size = new System.Drawing.Size(144, 24);
                        this.EntradaRemito.TabIndex = 15;
                        this.EntradaRemito.ToolTipText = "";
                        this.EntradaRemito.TextChanged += new System.EventHandler(this.EntradaRemito_TextChanged);
                        // 
                        // PanelFormaPago
                        // 
                        this.PanelFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelFormaPago.Controls.Add(this.Label2);
                        this.PanelFormaPago.Controls.Add(this.EntradaFormaPago);
                        this.PanelFormaPago.Location = new System.Drawing.Point(192, 72);
                        this.PanelFormaPago.Name = "PanelFormaPago";
                        this.PanelFormaPago.Size = new System.Drawing.Size(200, 24);
                        this.PanelFormaPago.TabIndex = 12;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.BotonPago);
                        this.Controls.Add(this.PanelFormaPago);
                        this.Controls.Add(this.EntradaRemito);
                        this.Controls.Add(this.Label11);
                        this.Controls.Add(this.Label10);
                        this.MinimumSize = new System.Drawing.Size(600, 320);
                        this.Name = "Editar";
                        this.Controls.SetChildIndex(this.Label10, 0);
                        this.Controls.SetChildIndex(this.Label11, 0);
                        this.Controls.SetChildIndex(this.EntradaRemito, 0);
                        this.Controls.SetChildIndex(this.PanelFormaPago, 0);
                        this.Controls.SetChildIndex(this.ProductArray, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.Controls.SetChildIndex(this.BotonPago, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.PanelFormaPago.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                internal Lui.Forms.Label Label2;
                internal Lui.Forms.Label Label10;
                public Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.Label Label11;
                internal Lui.Forms.Button BotonPago;
                public Lcc.Entrada.CodigoDetalle EntradaFormaPago;
                public Lui.Forms.TextBox EntradaRemito;
                internal System.Windows.Forms.Panel PanelFormaPago;
        }
}
