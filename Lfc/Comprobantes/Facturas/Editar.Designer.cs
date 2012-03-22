#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
                        this.EntradaRemito = new Lui.Forms.TextBox();
                        this.PanelFormaPago = new Lui.Forms.Panel();
                        this.PanelFormaPago.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(0, 0);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(108, 24);
                        this.Label2.TabIndex = 0;
                        this.Label2.Text = "Forma de pago";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaFormaPago
                        // 
                        this.EntradaFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaFormaPago.AutoTab = true;
                        this.EntradaFormaPago.CanCreate = true;
                        this.EntradaFormaPago.Filter = "cobros=1 AND estado=1";
                        this.EntradaFormaPago.Location = new System.Drawing.Point(112, 0);
                        this.EntradaFormaPago.MaximumSize = new System.Drawing.Size(480, 32);
                        this.EntradaFormaPago.MaxLength = 200;
                        this.EntradaFormaPago.Name = "EntradaFormaPago";
                        this.EntradaFormaPago.NombreTipo = "Lbl.Pagos.FormaDePago";
                        this.EntradaFormaPago.Required = true;
                        this.EntradaFormaPago.Size = new System.Drawing.Size(88, 24);
                        this.EntradaFormaPago.TabIndex = 1;
                        this.EntradaFormaPago.Text = "0";
                        this.EntradaFormaPago.Leave += new System.EventHandler(this.EntradaFormaPago_Leave);
                        // 
                        // Label10
                        // 
                        this.Label10.Location = new System.Drawing.Point(0, 32);
                        this.Label10.Name = "Label10";
                        this.Label10.Size = new System.Drawing.Size(72, 24);
                        this.Label10.TabIndex = 10;
                        this.Label10.Text = "Tipo";
                        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.EntradaTipo.AlwaysExpanded = false;
                        this.EntradaTipo.AutoSize = true;
                        this.EntradaTipo.Location = new System.Drawing.Point(72, 32);
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.SetData = new string[] {
        "Factura A|FA"};
                        this.EntradaTipo.Size = new System.Drawing.Size(116, 25);
                        this.EntradaTipo.TabIndex = 11;
                        this.EntradaTipo.TextKey = "FA";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaTipo_TextChanged);
                        // 
                        // Label11
                        // 
                        this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label11.Location = new System.Drawing.Point(408, 32);
                        this.Label11.Name = "Label11";
                        this.Label11.Size = new System.Drawing.Size(56, 24);
                        this.Label11.TabIndex = 14;
                        this.Label11.Text = "Remito";
                        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaRemito
                        // 
                        this.EntradaRemito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaRemito.Location = new System.Drawing.Point(464, 32);
                        this.EntradaRemito.Name = "EntradaRemito";
                        this.EntradaRemito.PlaceholderText = "Ninguno";
                        this.EntradaRemito.Size = new System.Drawing.Size(144, 24);
                        this.EntradaRemito.TabIndex = 15;
                        this.EntradaRemito.TextChanged += new System.EventHandler(this.EntradaRemito_TextChanged);
                        // 
                        // PanelFormaPago
                        // 
                        this.PanelFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelFormaPago.Controls.Add(this.Label2);
                        this.PanelFormaPago.Controls.Add(this.EntradaFormaPago);
                        this.PanelFormaPago.Location = new System.Drawing.Point(200, 32);
                        this.PanelFormaPago.Name = "PanelFormaPago";
                        this.PanelFormaPago.Size = new System.Drawing.Size(200, 24);
                        this.PanelFormaPago.TabIndex = 12;
                        // 
                        // Editar
                        // 
                        this.Controls.Add(this.EntradaTipo);
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
                public Lcc.Entrada.CodigoDetalle EntradaFormaPago;
                public Lui.Forms.TextBox EntradaRemito;
                internal Lui.Forms.Panel PanelFormaPago;
        }
}
