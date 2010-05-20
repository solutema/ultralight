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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Tareas
{
        public class Articulos : Lui.Forms.EditForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Articulos()
                        : base()
                {


                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent
                        lblTitulo.BackColor = Lws.Config.Display.CurrentTemplate.HeaderBackground;
                        lblTitulo.ForeColor = Lws.Config.Display.CurrentTemplate.HeaderText;

                }

                // Limpiar los recursos que se estén utilizando.
                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
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
                internal Lui.Forms.ProductArray ProductArray;
                internal System.Windows.Forms.Label lblTitulo;
                internal System.Windows.Forms.Label Label4;
                internal Lui.Forms.TextBox txtTotal;
                internal Lui.Forms.TextBox txtDescuento;
                internal System.Windows.Forms.Label Label6;
                internal Lui.Forms.TextBox txtSubTotal;
                internal System.Windows.Forms.Label Label5;

                private void InitializeComponent()
                {
                        this.ProductArray = new Lui.Forms.ProductArray();
                        this.lblTitulo = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtTotal = new Lui.Forms.TextBox();
                        this.txtDescuento = new Lui.Forms.TextBox();
                        this.Label6 = new System.Windows.Forms.Label();
                        this.txtSubTotal = new Lui.Forms.TextBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // SaveButton
                        // 
                        this.SaveButton.DockPadding.All = 2;
                        this.SaveButton.Location = new System.Drawing.Point(376, 10);
                        this.SaveButton.Name = "SaveButton";
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.DockPadding.All = 2;
                        this.CancelCommandButton.Location = new System.Drawing.Point(484, 10);
                        this.CancelCommandButton.Name = "CancelCommandButton";
                        // 
                        // ProductArray
                        // 
                        this.ProductArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                        this.ProductArray.AutoAgregar = false;
                        this.ProductArray.AutoScroll = true;
                        this.ProductArray.AutoScrollMargin = new System.Drawing.Size(4, 4);
                        this.ProductArray.BackColor = System.Drawing.SystemColors.Control;
                        this.ProductArray.Changed = false;
                        this.ProductArray.Count = 0;
                        this.ProductArray.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.ProductArray.FreeTextCode = "*";
                        this.ProductArray.Location = new System.Drawing.Point(8, 56);
                        this.ProductArray.LockPrice = false;
                        this.ProductArray.LockQuantity = false;
                        this.ProductArray.LockText = false;
                        this.ProductArray.MaxLength = 200;
                        this.ProductArray.Name = "ProductArray";
                        this.ProductArray.Precio = Lui.Forms.Product.Precios.PVP;
                        this.ProductArray.ShowStock = true;
                        this.ProductArray.Size = new System.Drawing.Size(576, 220);
                        this.ProductArray.TabIndex = 1;
                        this.ProductArray.TotalChanged += new System.EventHandler(this.ProductArray_TotalChanged);
                        // 
                        // lblTitulo
                        // 
                        this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblTitulo.Font = new System.Drawing.Font("Bitstream Vera Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.lblTitulo.ForeColor = System.Drawing.Color.White;
                        this.lblTitulo.Location = new System.Drawing.Point(8, 8);
                        this.lblTitulo.Name = "lblTitulo";
                        this.lblTitulo.Size = new System.Drawing.Size(576, 40);
                        this.lblTitulo.TabIndex = 0;
                        this.lblTitulo.Text = "Artículos";
                        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label4
                        // 
                        this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.Label4.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.Label4.Location = new System.Drawing.Point(364, 280);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(76, 32);
                        this.Label4.TabIndex = 53;
                        this.Label4.Text = "Total";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // EntradaTotal
                        // 
                        this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtTotal.AutoNav = true;
                        this.txtTotal.AutoTab = true;
                        this.txtTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtTotal.DockPadding.All = 2;
                        this.txtTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTotal.Location = new System.Drawing.Point(440, 280);
                        this.txtTotal.MaxLenght = 32767;
                        this.txtTotal.Name = "EntradaTotal";
                        this.txtTotal.Prefijo = "$";
                        this.txtTotal.ReadOnly = true;
                        this.txtTotal.Size = new System.Drawing.Size(144, 32);
                        this.txtTotal.TabIndex = 54;
                        this.txtTotal.TabStop = false;
                        this.txtTotal.Text = "0.00";
                        this.txtTotal.ToolTipText = "";
                        // 
                        // txtDescuento
                        // 
                        this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtDescuento.AutoNav = true;
                        this.txtDescuento.AutoTab = true;
                        this.txtDescuento.DataType = Lui.Forms.DataTypes.Float;
                        this.txtDescuento.DockPadding.All = 2;
                        this.txtDescuento.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtDescuento.Location = new System.Drawing.Point(244, 280);
                        this.txtDescuento.MaxLenght = 32767;
                        this.txtDescuento.Name = "txtDescuento";
                        this.txtDescuento.ReadOnly = false;
                        this.txtDescuento.Size = new System.Drawing.Size(76, 24);
                        this.txtDescuento.Sufijo = "%";
                        this.txtDescuento.TabIndex = 58;
                        this.txtDescuento.Text = "0.00";
                        this.txtDescuento.ToolTipText = "";
                        this.txtDescuento.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
                        // 
                        // Label6
                        // 
                        this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label6.Location = new System.Drawing.Point(168, 280);
                        this.Label6.Name = "Label6";
                        this.Label6.Size = new System.Drawing.Size(76, 24);
                        this.Label6.TabIndex = 57;
                        this.Label6.Text = "Descuento";
                        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSubTotal
                        // 
                        this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.txtSubTotal.AutoNav = true;
                        this.txtSubTotal.AutoTab = true;
                        this.txtSubTotal.DataType = Lui.Forms.DataTypes.Money;
                        this.txtSubTotal.DockPadding.All = 2;
                        this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                        this.txtSubTotal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSubTotal.Location = new System.Drawing.Point(72, 280);
                        this.txtSubTotal.MaxLenght = 32767;
                        this.txtSubTotal.Name = "txtSubTotal";
                        this.txtSubTotal.Prefijo = "$";
                        this.txtSubTotal.ReadOnly = true;
                        this.txtSubTotal.Size = new System.Drawing.Size(84, 24);
                        this.txtSubTotal.TabIndex = 56;
                        this.txtSubTotal.TabStop = false;
                        this.txtSubTotal.Text = "0.00";
                        this.txtSubTotal.ToolTipText = "";
                        this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
                        // 
                        // Label5
                        // 
                        this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                        this.Label5.Location = new System.Drawing.Point(8, 280);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(64, 24);
                        this.Label5.TabIndex = 55;
                        this.Label5.Text = "Subtotal";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Articulos
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(592, 373);
                        this.Controls.Add(this.txtDescuento);
                        this.Controls.Add(this.Label6);
                        this.Controls.Add(this.txtSubTotal);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtTotal);
                        this.Controls.Add(this.lblTitulo);
                        this.Controls.Add(this.ProductArray);
                        this.Name = "Articulos";
                        this.ResumeLayout(false);

                }


                #endregion

                public override Lfx.Types.OperationResult Edit(int Ticket)
                {
                        lblTitulo.Text = "Artículos del Ticket Nº " + Ticket.ToString();
                        this.Text = lblTitulo.Text;
                        m_Id = Ticket;
                        System.Data.DataTable Articulos = this.Workspace.DefaultDataBase.Select("SELECT * FROM tickets_articulos WHERE id_ticket=" + Ticket.ToString() + " ORDER BY orden");
                        ProductArray.Count = Articulos.Rows.Count;
                        for (int i = 0; i <= Articulos.Rows.Count - 1; i++) {
                                if (Lfx.Data.DataBase.ConvertDBNullToZero(Articulos.Rows[i]["id_articulo"]) == 0)
                                        ProductArray.ChildControls[i].Text = ProductArray.FreeTextCode;
                                else
                                        ProductArray.ChildControls[i].TextInt = System.Convert.ToInt32(Articulos.Rows[i]["id_articulo"]);

                                ProductArray.ChildControls[i].TextDetail = System.Convert.ToString(Articulos.Rows[i]["nombre"]);
                                ProductArray.ChildControls[i].Cantidad = System.Convert.ToDouble(Articulos.Rows[i]["cantidad"]);
                                ProductArray.ChildControls[i].Unitario = System.Convert.ToDouble(Articulos.Rows[i]["precio"]);
                        }
                        txtDescuento.Text = Lfx.Types.Formatting.FormatNumber(this.Workspace.DefaultDataBase.FieldDouble("SELECT articulos_descuento FROM tickets WHERE id_ticket=" + m_Id.ToString()));
                        ProductArray.AutoAgregar = true;
                        return new Lfx.Types.SuccessOperationResult();
                }


                public override Lfx.Types.OperationResult Save()
                {
                        DataView.BeginTransaction();
                        DataView.DataBase.Execute("DELETE FROM tickets_articulos WHERE id_ticket=" + m_Id.ToString());
                        for (int i = 0; i <= ProductArray.Count - 1; i++) {
                                if (ProductArray.ChildControls[i].TextInt != 0) {
                                        Lfx.Data.SqlInsertBuilder Comando = new Lfx.Data.SqlInsertBuilder(DataView.DataBase, "tickets_articulos");
                                        Comando.Fields.AddWithValue("id_ticket", m_Id);
                                        Comando.Fields.AddWithValue("id_articulo", Lfx.Data.DataBase.ConvertZeroToDBNull(ProductArray.ChildControls[i].TextInt));
                                        Comando.Fields.AddWithValue("nombre", ProductArray.ChildControls[i].TextDetail);
                                        Comando.Fields.AddWithValue("orden", i + 1);
                                        Comando.Fields.AddWithValue("cantidad", ProductArray.ChildControls[i].Cantidad);
                                        Comando.Fields.AddWithValue("precio", ProductArray.ChildControls[i].Unitario);
                                        DataView.Execute(Comando);
                                }
                        }
                        DataView.DataBase.Execute("UPDATE tickets SET articulos_descuento=" + Lfx.Types.Formatting.FormatNumber(Lfx.Types.Parsing.ParseDouble(txtDescuento.Text)) + " WHERE id_ticket=" + m_Id.ToString());
                        DataView.Commit();
                        return base.Save();
                }


                private void ProductArray_TotalChanged(System.Object sender, System.EventArgs e)
                {
                        txtSubTotal.Text = Lfx.Types.Formatting.FormatCurrency(ProductArray.Total, this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }


                private void txtSubTotal_TextChanged(object sender, System.EventArgs e)
                {
                        txtTotal.Text = Lfx.Types.Formatting.FormatCurrency(Lfx.Types.Parsing.ParseCurrency(txtSubTotal.Text) * (1 - Lfx.Types.Parsing.ParseDouble(txtDescuento.Text) / 100), this.Workspace.CurrentConfig.Currency.DecimalPlaces);
                }
        }
}