#region License
// Copyright 2004-2010 South Bridge S.R.L.
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
                private System.ComponentModel.Container components = null;

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
                        this.LabelSerials = new System.Windows.Forms.Label();
                        this.LabelSerialsCruz = new System.Windows.Forms.Label();
                        this.txtDescuento = new Lui.Forms.TextBox();
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
                        this.LabelSerials.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.LabelSerials.Location = new System.Drawing.Point(16, 26);
                        this.LabelSerials.Name = "LabelSerials";
                        this.LabelSerials.Size = new System.Drawing.Size(354, 12);
                        this.LabelSerials.TabIndex = 4;
                        this.LabelSerials.Text = "Seguimiento:";
                        this.LabelSerials.UseMnemonic = false;
                        this.LabelSerials.Visible = false;
                        this.LabelSerials.VisibleChanged += new System.EventHandler(this.RecalcularAltura);
                        // 
                        // LabelSerialsCruz
                        // 
                        this.LabelSerialsCruz.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.LabelSerialsCruz.Location = new System.Drawing.Point(4, 22);
                        this.LabelSerialsCruz.Name = "LabelSerialsCruz";
                        this.LabelSerialsCruz.Size = new System.Drawing.Size(12, 16);
                        this.LabelSerialsCruz.TabIndex = 7;
                        this.LabelSerialsCruz.Text = "L";
                        this.LabelSerialsCruz.Visible = false;
                        // 
                        // txtDescuento
                        // 
                        this.txtDescuento.AutoHeight = false;
                        this.txtDescuento.AutoNav = false;
                        this.txtDescuento.AutoTab = true;
                        this.txtDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.txtDescuento.DecimalPlaces = -1;
                        this.txtDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDescuento.ForceCase = Lui.Forms.TextCasing.None;
                        this.txtDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDescuento.Location = new System.Drawing.Point(376, 24);
                        this.txtDescuento.MaxLenght = 32767;
                        this.txtDescuento.MultiLine = false;
                        this.txtDescuento.Name = "txtDescuento";
                        this.txtDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescuento.PasswordChar = '\0';
                        this.txtDescuento.Prefijo = "Desc.";
                        this.txtDescuento.ReadOnly = false;
                        this.txtDescuento.SelectOnFocus = true;
                        this.txtDescuento.Size = new System.Drawing.Size(128, 20);
                        this.txtDescuento.Sufijo = "%";
                        this.txtDescuento.TabIndex = 6;
                        this.txtDescuento.TabStop = false;
                        this.txtDescuento.Text = "0.0000";
                        this.txtDescuento.TextRaw = "0.0000";
                        this.txtDescuento.TipWhenBlank = "";
                        this.txtDescuento.ToolTipText = "Escriba el descuento para este ítem";
                        this.txtDescuento.Visible = false;
                        // 
                        // EntradaImporte
                        // 
                        this.EntradaImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaImporte.AutoHeight = false;
                        this.EntradaImporte.AutoNav = true;
                        this.EntradaImporte.AutoTab = true;
                        this.EntradaImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaImporte.DecimalPlaces = -1;
                        this.EntradaImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaImporte.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaImporte.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaImporte.Location = new System.Drawing.Point(412, 0);
                        this.EntradaImporte.MaxLenght = 32767;
                        this.EntradaImporte.MultiLine = false;
                        this.EntradaImporte.Name = "EntradaImporte";
                        this.EntradaImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaImporte.PasswordChar = '\0';
                        this.EntradaImporte.Prefijo = "";
                        this.EntradaImporte.ReadOnly = true;
                        this.EntradaImporte.SelectOnFocus = true;
                        this.EntradaImporte.Size = new System.Drawing.Size(92, 24);
                        this.EntradaImporte.Sufijo = "";
                        this.EntradaImporte.TabIndex = 3;
                        this.EntradaImporte.TabStop = false;
                        this.EntradaImporte.Text = "0.00";
                        this.EntradaImporte.TextRaw = "0.00";
                        this.EntradaImporte.TipWhenBlank = "";
                        this.EntradaImporte.ToolTipText = "";
                        // 
                        // EntradaUnitario
                        // 
                        this.EntradaUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaUnitario.AutoHeight = false;
                        this.EntradaUnitario.AutoNav = false;
                        this.EntradaUnitario.AutoTab = false;
                        this.EntradaUnitario.DataType = Lui.Forms.DataTypes.Money;
                        this.EntradaUnitario.DecimalPlaces = -1;
                        this.EntradaUnitario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaUnitario.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaUnitario.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaUnitario.Location = new System.Drawing.Point(240, 0);
                        this.EntradaUnitario.MaxLenght = 32767;
                        this.EntradaUnitario.MultiLine = false;
                        this.EntradaUnitario.Name = "EntradaUnitario";
                        this.EntradaUnitario.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaUnitario.PasswordChar = '\0';
                        this.EntradaUnitario.Prefijo = "";
                        this.EntradaUnitario.ReadOnly = false;
                        this.EntradaUnitario.SelectOnFocus = true;
                        this.EntradaUnitario.Size = new System.Drawing.Size(80, 24);
                        this.EntradaUnitario.Sufijo = "";
                        this.EntradaUnitario.TabIndex = 1;
                        this.EntradaUnitario.TabStop = false;
                        this.EntradaUnitario.Text = "0.00";
                        this.EntradaUnitario.TextRaw = "0.00";
                        this.EntradaUnitario.TipWhenBlank = "";
                        this.EntradaUnitario.ToolTipText = "Escriba el precio unitario.";
                        this.EntradaUnitario.TextChanged += new System.EventHandler(this.EntradaPrecioCantidad_TextChanged);
                        this.EntradaUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaUnitario_KeyDown);
                        // 
                        // EntradaCantidad
                        // 
                        this.EntradaCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaCantidad.AutoHeight = false;
                        this.EntradaCantidad.AutoNav = false;
                        this.EntradaCantidad.AutoTab = true;
                        this.EntradaCantidad.DataType = Lui.Forms.DataTypes.Stock;
                        this.EntradaCantidad.DecimalPlaces = -1;
                        this.EntradaCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaCantidad.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaCantidad.Location = new System.Drawing.Point(320, 0);
                        this.EntradaCantidad.MaxLenght = 32767;
                        this.EntradaCantidad.MultiLine = false;
                        this.EntradaCantidad.Name = "EntradaCantidad";
                        this.EntradaCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCantidad.PasswordChar = '\0';
                        this.EntradaCantidad.Prefijo = "";
                        this.EntradaCantidad.ReadOnly = false;
                        this.EntradaCantidad.SelectOnFocus = true;
                        this.EntradaCantidad.Size = new System.Drawing.Size(92, 24);
                        this.EntradaCantidad.Sufijo = "";
                        this.EntradaCantidad.TabIndex = 2;
                        this.EntradaCantidad.TabStop = false;
                        this.EntradaCantidad.Text = "0.00";
                        this.EntradaCantidad.TextRaw = "0.00";
                        this.EntradaCantidad.TipWhenBlank = "";
                        this.EntradaCantidad.ToolTipText = "Escriba la cantidad.";
                        this.EntradaCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaCantidad_KeyPress);
                        this.EntradaCantidad.TextChanged += new System.EventHandler(this.EntradaPrecioCantidad_TextChanged);
                        this.EntradaCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaCantidad_KeyDown);
                        // 
                        // EntradaArticulo
                        // 
                        this.EntradaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.EntradaArticulo.AutoHeight = false;
                        this.EntradaArticulo.AutoNav = true;
                        this.EntradaArticulo.AutoTab = true;
                        this.EntradaArticulo.CanCreate = true;
                        this.EntradaArticulo.DetailField = "nombre";
                        this.EntradaArticulo.ExtraDetailFields = "pvp,codigo1,codigo2,codigo3,codigo4";
                        this.EntradaArticulo.Filter = "";
                        this.EntradaArticulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.EntradaArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.EntradaArticulo.FreeTextCode = "";
                        this.EntradaArticulo.KeyField = "id_articulo";
                        this.EntradaArticulo.Location = new System.Drawing.Point(0, 0);
                        this.EntradaArticulo.MaxLength = 200;
                        this.EntradaArticulo.Name = "EntradaArticulo";
                        this.EntradaArticulo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaArticulo.ReadOnly = false;
                        this.EntradaArticulo.Required = false;
                        this.EntradaArticulo.Size = new System.Drawing.Size(240, 24);
                        this.EntradaArticulo.TabIndex = 0;
                        this.EntradaArticulo.Table = "articulos";
                        this.EntradaArticulo.Text = "0";
                        this.EntradaArticulo.TextDetail = "";
                        this.EntradaArticulo.TipWhenBlank = "";
                        this.EntradaArticulo.ToolTipText = "";
                        this.EntradaArticulo.TextChanged += new System.EventHandler(this.EntradaArticulo_TextChanged);
                        this.EntradaArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaArticulo_KeyDown);
                        // 
                        // DetalleComprobante
                        // 
                        this.Controls.Add(this.txtDescuento);
                        this.Controls.Add(this.EntradaImporte);
                        this.Controls.Add(this.EntradaUnitario);
                        this.Controls.Add(this.EntradaCantidad);
                        this.Controls.Add(this.EntradaArticulo);
                        this.Controls.Add(this.LabelSerials);
                        this.Controls.Add(this.LabelSerialsCruz);
                        this.Name = "DetalleComprobante";
                        this.Size = new System.Drawing.Size(504, 44);
                        this.FontChanged += new System.EventHandler(this.Product_FontChanged);
                        this.Enter += new System.EventHandler(this.Product_Enter);
                        this.Controls.SetChildIndex(this.LabelSerialsCruz, 0);
                        this.Controls.SetChildIndex(this.LabelSerials, 0);
                        this.Controls.SetChildIndex(this.EntradaArticulo, 0);
                        this.Controls.SetChildIndex(this.EntradaCantidad, 0);
                        this.Controls.SetChildIndex(this.EntradaUnitario, 0);
                        this.Controls.SetChildIndex(this.EntradaImporte, 0);
                        this.Controls.SetChildIndex(this.txtDescuento, 0);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
                #endregion

                internal CodigoDetalle EntradaArticulo;
                internal TextBox EntradaCantidad;
                internal TextBox EntradaUnitario;
                internal TextBox EntradaImporte;
                internal TextBox txtDescuento;
                internal System.Windows.Forms.Label LabelSerials;
                internal System.Windows.Forms.Label LabelSerialsCruz;
        }
}