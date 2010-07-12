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

namespace Lui.Forms
{
        public partial class Product
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
                        this.txtImporte = new Lui.Forms.TextBox();
                        this.txtUnitario = new Lui.Forms.TextBox();
                        this.txtCantidad = new Lui.Forms.TextBox();
                        this.txtArticulo = new Lui.Forms.DetailBox();
                        this.SuspendLayout();
                        // 
                        // LabelSerials
                        // 
                        this.LabelSerials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelSerials.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.LabelSerials.Location = new System.Drawing.Point(16, 26);
                        this.LabelSerials.Name = "LabelSerials";
                        this.LabelSerials.Size = new System.Drawing.Size(260, 12);
                        this.LabelSerials.TabIndex = 4;
                        this.LabelSerials.Text = "Números de serie:";
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
                        this.txtDescuento.AutoNav = false;
                        this.txtDescuento.AutoTab = true;
                        this.txtDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.txtDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDescuento.Location = new System.Drawing.Point(376, 24);
                        this.txtDescuento.MaxLenght = 32767;
                        this.txtDescuento.Name = "txtDescuento";
                        this.txtDescuento.Padding = new System.Windows.Forms.Padding(2);
                        this.txtDescuento.Prefijo = "Desc.";
                        this.txtDescuento.ReadOnly = false;
                        this.txtDescuento.Size = new System.Drawing.Size(128, 20);
                        this.txtDescuento.Sufijo = "%";
                        this.txtDescuento.TabIndex = 6;
                        this.txtDescuento.TabStop = false;
                        this.txtDescuento.Text = "0.00";
                        this.txtDescuento.TipWhenBlank = "";
                        this.txtDescuento.ToolTipText = "Escriba el descuento para este ítem";
                        this.txtDescuento.Visible = false;
                        // 
                        // txtImporte
                        // 
                        this.txtImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtImporte.AutoNav = true;
                        this.txtImporte.AutoTab = true;
                        this.txtImporte.DataType = Lui.Forms.DataTypes.Money;
                        this.txtImporte.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtImporte.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtImporte.Location = new System.Drawing.Point(412, 0);
                        this.txtImporte.MaxLenght = 32767;
                        this.txtImporte.Name = "txtImporte";
                        this.txtImporte.Padding = new System.Windows.Forms.Padding(2);
                        this.txtImporte.ReadOnly = true;
                        this.txtImporte.Size = new System.Drawing.Size(92, 24);
                        this.txtImporte.TabIndex = 3;
                        this.txtImporte.TabStop = false;
                        this.txtImporte.Text = "0.00";
                        this.txtImporte.TipWhenBlank = "";
                        this.txtImporte.ToolTipText = "";
                        // 
                        // txtUnitario
                        // 
                        this.txtUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtUnitario.AutoNav = false;
                        this.txtUnitario.AutoTab = false;
                        this.txtUnitario.DataType = Lui.Forms.DataTypes.Money;
                        this.txtUnitario.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtUnitario.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtUnitario.Location = new System.Drawing.Point(240, 0);
                        this.txtUnitario.MaxLenght = 32767;
                        this.txtUnitario.Name = "txtUnitario";
                        this.txtUnitario.Padding = new System.Windows.Forms.Padding(2);
                        this.txtUnitario.ReadOnly = false;
                        this.txtUnitario.Size = new System.Drawing.Size(80, 24);
                        this.txtUnitario.TabIndex = 1;
                        this.txtUnitario.TabStop = false;
                        this.txtUnitario.Text = "0.00";
                        this.txtUnitario.TipWhenBlank = "";
                        this.txtUnitario.ToolTipText = "Escriba el precio unitario.";
                        this.txtUnitario.TextChanged += new System.EventHandler(this.CambioPrecioCantidad);
                        this.txtUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitario_KeyDown);
                        // 
                        // txtCantidad
                        // 
                        this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtCantidad.AutoNav = false;
                        this.txtCantidad.AutoTab = true;
                        this.txtCantidad.DataType = Lui.Forms.DataTypes.Float;
                        this.txtCantidad.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCantidad.Location = new System.Drawing.Point(320, 0);
                        this.txtCantidad.MaxLenght = 32767;
                        this.txtCantidad.Name = "txtCantidad";
                        this.txtCantidad.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCantidad.ReadOnly = false;
                        this.txtCantidad.Size = new System.Drawing.Size(92, 24);
                        this.txtCantidad.TabIndex = 2;
                        this.txtCantidad.TabStop = false;
                        this.txtCantidad.Text = "0.00";
                        this.txtCantidad.TipWhenBlank = "";
                        this.txtCantidad.ToolTipText = "Escriba la cantidad.";
                        this.txtCantidad.TextChanged += new System.EventHandler(this.CambioPrecioCantidad);
                        this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
                        this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
                        // 
                        // txtArticulo
                        // 
                        this.txtArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtArticulo.AutoTab = true;
                        this.txtArticulo.CanCreate = true;
                        this.txtArticulo.DetailField = "nombre";
                        this.txtArticulo.ExtraDetailFields = "pvp,codigo1,codigo2,codigo3,codigo4";
                        this.txtArticulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtArticulo.FreeTextCode = "";
                        this.txtArticulo.KeyField = "id_articulo";
                        this.txtArticulo.Location = new System.Drawing.Point(0, 0);
                        this.txtArticulo.MaxLength = 200;
                        this.txtArticulo.Name = "txtArticulo";
                        this.txtArticulo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtArticulo.ReadOnly = false;
                        this.txtArticulo.Required = false;
                        this.txtArticulo.Size = new System.Drawing.Size(240, 24);
                        this.txtArticulo.TabIndex = 0;
                        this.txtArticulo.Table = "articulos";
                        this.txtArticulo.TeclaDespuesDeEnter = "{right}";
                        this.txtArticulo.Text = "0";
                        this.txtArticulo.TextDetail = "";
                        this.txtArticulo.TextInt = 0;
                        this.txtArticulo.TipWhenBlank = "";
                        this.txtArticulo.ToolTipText = "";
                        this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
                        this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
                        // 
                        // Product
                        // 
                        this.Controls.Add(this.txtDescuento);
                        this.Controls.Add(this.txtImporte);
                        this.Controls.Add(this.txtUnitario);
                        this.Controls.Add(this.txtCantidad);
                        this.Controls.Add(this.txtArticulo);
                        this.Controls.Add(this.LabelSerials);
                        this.Controls.Add(this.LabelSerialsCruz);
                        this.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.Name = "Product";
                        this.Size = new System.Drawing.Size(504, 44);
                        this.FontChanged += new System.EventHandler(this.Product_FontChanged);
                        this.Enter += new System.EventHandler(this.Product_Enter);
                        this.ResumeLayout(false);
                }
                #endregion

                internal DetailBox txtArticulo;
                internal TextBox txtCantidad;
                internal TextBox txtUnitario;
                internal TextBox txtImporte;
                internal TextBox txtDescuento;
                internal System.Windows.Forms.Label LabelSerials;
                internal System.Windows.Forms.Label LabelSerialsCruz;
        }
}