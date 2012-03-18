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

using Lui.Forms;

namespace Lcc.Entrada.Articulos
{
        public partial class DetalleComprobante
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
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de componentes
                /// <summary> 
                /// Método necesario para admitir el Diseñador. No se puede modificar
                /// el contenido del método con el editor de código.
                /// </summary>

                private void InitializeComponent()
                {
                        this.LabelSerials = new Lui.Forms.Label();
                        this.LabelSerialsCruz = new Lui.Forms.Label();
                        this.EntradaDescuento = new Lui.Forms.TextBox();
                        this.EntradaImporte = new Lui.Forms.TextBox();
                        this.EntradaUnitario = new Lui.Forms.TextBox();
                        this.EntradaCantidad = new Lui.Forms.TextBox();
                        this.EntradaArticulo = new Lcc.Entrada.CodigoDetalle();
                        this.SuspendLayout();
                        // 
                        // LabelSerials
                        // 
                        this.LabelSerials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelSerials.AutoEllipsis = true;
                        this.LabelSerials.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.LabelSerials.Location = new System.Drawing.Point(16, 26);
                        this.LabelSerials.Name = "LabelSerials";
                        this.LabelSerials.Size = new System.Drawing.Size(354, 16);
                        this.LabelSerials.TabIndex = 4;
                        this.LabelSerials.Text = "Seguimiento:";
                        this.LabelSerials.UseMnemonic = false;
                        this.LabelSerials.Visible = false;
                        this.LabelSerials.VisibleChanged += new System.EventHandler(this.RecalcularAltura);
                        // 
                        // LabelSerialsCruz
                        // 
                        this.LabelSerialsCruz.Location = new System.Drawing.Point(4, 18);
                        this.LabelSerialsCruz.Name = "LabelSerialsCruz";
                        this.LabelSerialsCruz.Size = new System.Drawing.Size(14, 20);
                        this.LabelSerialsCruz.TabIndex = 7;
                        this.LabelSerialsCruz.Text = "L";
                        this.LabelSerialsCruz.Visible = false;
                        // 
                        // EntradaDescuento
                        // 
                        this.EntradaDescuento.AutoNav = false;
                        this.EntradaDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.EntradaDescuento.TextStyle = Lazaro.Pres.DisplayStyles.TextStyles.Small;
                        this.EntradaDescuento.Location = new System.Drawing.Point(376, 24);
                        this.EntradaDescuento.Name = "EntradaDescuento";
                        this.EntradaDescuento.PlaceholderText = "Escriba el descuento para este ítem";
                        this.EntradaDescuento.Prefijo = "Desc.";
                        this.EntradaDescuento.Size = new System.Drawing.Size(128, 20);
                        this.EntradaDescuento.Sufijo = "%";
                        this.EntradaDescuento.TabIndex = 6;
                        this.EntradaDescuento.TabStop = false;
                        this.EntradaDescuento.Text = "0.0000";
                        this.EntradaDescuento.Visible = false;
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaImporte.Location = new System.Drawing.Point(404, 0);
                        this.EntradaImporte.MaxLength = 20;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Prefijo = "$";
                        this.EntradaImporte.ReadOnly = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(104, 24);
                        this.EntradaImporte.TabIndex = 3;
                        this.EntradaImporte.TabStop = false;
                        this.EntradaImporte.Text = "0.00";
                        // 
                        // EntradaUnitario
                        // 
                        this.EntradaUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUnitario.DataType = Lui.Forms.DataTypes.Currency;
                        this.EntradaUnitario.Location = new System.Drawing.Point(216, 0);
                        this.EntradaUnitario.MaxLength = 20;
                        this.EntradaUnitario.Name = "EntradaUnitario";
                        this.EntradaUnitario.PlaceholderText = "Escriba el precio unitario.";
                        this.EntradaUnitario.Prefijo = "$";
                        this.EntradaUnitario.Size = new System.Drawing.Size(95, 24);
                        this.EntradaUnitario.TabIndex = 1;
                        this.EntradaUnitario.TabStop = false;
                        this.EntradaUnitario.Text = "0.00";
                        this.EntradaUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaUnitario_KeyDown);
                        this.EntradaUnitario.TextChanged += new System.EventHandler(this.EntradaPrecioCantidad_TextChanged);
                        // 
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCantidad.AutoNav = false;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaCantidad.Location = new System.Drawing.Point(312, 0);
                        this.EntradaCantidad.MaxLength = 20;
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.PlaceholderText = "Escriba la cantidad.";
                        this.EntradaCantidad.Size = new System.Drawing.Size(91, 24);
                        this.EntradaCantidad.TabIndex = 2;
                        this.EntradaCantidad.TabStop = false;
                        this.EntradaCantidad.Text = "0.00";
                        this.EntradaCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaCantidad_KeyPress);
                        this.EntradaCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaCantidad_KeyDown);
                        this.EntradaCantidad.TextChanged += new System.EventHandler(this.EntradaPrecioCantidad_TextChanged);
                        this.EntradaCantidad.Click += new System.EventHandler(this.EntradaCantidad_Click);
                        // 
                        // EntradaArticulo
                        // 
                        this.EntradaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaArticulo.AutoTab = true;
                        this.EntradaArticulo.CanCreate = true;
                        this.EntradaArticulo.DataTextField = "nombre";
                        this.EntradaArticulo.DataValueField = "id_articulo";
                        this.EntradaArticulo.ExtraDetailFields = "pvp,codigo1,codigo2,codigo3,codigo4";
                        this.EntradaArticulo.Filter = "";
                        this.EntradaArticulo.FreeTextCode = "";
                        this.EntradaArticulo.Location = new System.Drawing.Point(0, 0);
                        this.EntradaArticulo.MaxLength = 200;
                        this.EntradaArticulo.Name = "EntradaArticulo";
                        this.EntradaArticulo.PlaceholderText = null;
                        this.EntradaArticulo.Required = true;
                        this.EntradaArticulo.Size = new System.Drawing.Size(215, 24);
                        this.EntradaArticulo.TabIndex = 0;
                        this.EntradaArticulo.NombreTipo = "Lbl.Articulos.Articulo";
                        this.EntradaArticulo.Text = "0";
                        this.EntradaArticulo.TextDetail = "";
                        this.EntradaArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaArticulo_KeyDown);
                        this.EntradaArticulo.TextChanged += new System.EventHandler(this.EntradaArticulo_TextChanged);
                        // 
                        // DetalleComprobante
                        // 
                        this.Controls.Add(this.EntradaDescuento);
                        this.Controls.Add(this.EntradaImporte);
                        this.Controls.Add(this.EntradaUnitario);
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.EntradaArticulo);
                        this.Controls.Add(this.LabelSerialsCruz);
                        this.Controls.Add(this.LabelSerials);
                        this.Name = "DetalleComprobante";
                        this.Size = new System.Drawing.Size(504, 44);
                        this.Enter += new System.EventHandler(this.Product_Enter);
                        this.ResumeLayout(false);

                }
                #endregion

                internal CodigoDetalle EntradaArticulo;
                internal TextBox EntradaCantidad;
                internal TextBox EntradaUnitario;
                internal TextBox EntradaImporte;
                internal TextBox EntradaDescuento;
                internal Lui.Forms.Label LabelSerials;
                internal Lui.Forms.Label LabelSerialsCruz;
        }
}
