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

using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lfc.Comprobantes.Recibos
{
        public class Filtros : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Filtros()
                        :
                        base()
                {

                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        // agregar código de constructor después de llamar a InitializeComponent

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
                internal Lui.Forms.DetailBox txtCliente;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox txtFecha2;
                internal System.Windows.Forms.Label lblFecha2;
                internal Lui.Forms.TextBox txtFecha1;
                internal System.Windows.Forms.Label lblFecha1;
                internal System.Windows.Forms.Label Label1;
                internal Lui.Forms.ComboBox txtFecha;
                internal Lui.Forms.DetailBox txtVendedor;
                internal System.Windows.Forms.Label Label5;
                internal System.Windows.Forms.Label label7;
                internal Lui.Forms.ComboBox txtTipo;
                internal Label label3;
                internal Lui.Forms.DetailBox txtSucursal;

                private void InitializeComponent()
                {
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtFecha2 = new Lui.Forms.TextBox();
                        this.lblFecha2 = new System.Windows.Forms.Label();
                        this.txtFecha1 = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.txtFecha = new Lui.Forms.ComboBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtVendedor = new Lui.Forms.DetailBox();
                        this.Label5 = new System.Windows.Forms.Label();
                        this.txtSucursal = new Lui.Forms.DetailBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(222, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(330, 8);
                        // 
                        // txtCliente
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
                        this.txtCliente.Location = new System.Drawing.Point(96, 84);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "txtCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = false;
                        this.txtCliente.Size = new System.Drawing.Size(324, 24);
                        this.txtCliente.TabIndex = 5;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(16, 84);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(80, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Cliente";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFecha2
                        // 
                        this.txtFecha2.AutoNav = true;
                        this.txtFecha2.AutoTab = true;
                        this.txtFecha2.DataType = Lui.Forms.DataTypes.Date;
                        this.txtFecha2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFecha2.Location = new System.Drawing.Point(276, 180);
                        this.txtFecha2.MaxLenght = 32767;
                        this.txtFecha2.Name = "txtFecha2";
                        this.txtFecha2.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha2.ReadOnly = false;
                        this.txtFecha2.Size = new System.Drawing.Size(108, 24);
                        this.txtFecha2.TabIndex = 13;
                        this.txtFecha2.TipWhenBlank = "";
                        this.txtFecha2.ToolTipText = "";
                        // 
                        // lblFecha2
                        // 
                        this.lblFecha2.Location = new System.Drawing.Point(224, 180);
                        this.lblFecha2.Name = "lblFecha2";
                        this.lblFecha2.Size = new System.Drawing.Size(52, 24);
                        this.lblFecha2.TabIndex = 12;
                        this.lblFecha2.Text = "Hasta";
                        this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFecha1
                        // 
                        this.txtFecha1.AutoNav = true;
                        this.txtFecha1.AutoTab = true;
                        this.txtFecha1.DataType = Lui.Forms.DataTypes.Date;
                        this.txtFecha1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFecha1.Location = new System.Drawing.Point(96, 180);
                        this.txtFecha1.MaxLenght = 32767;
                        this.txtFecha1.Name = "txtFecha1";
                        this.txtFecha1.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha1.ReadOnly = false;
                        this.txtFecha1.Size = new System.Drawing.Size(108, 24);
                        this.txtFecha1.TabIndex = 11;
                        this.txtFecha1.TipWhenBlank = "";
                        this.txtFecha1.ToolTipText = "";
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(16, 180);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(80, 24);
                        this.lblFecha1.TabIndex = 10;
                        this.lblFecha1.Text = "Desde";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFecha
                        // 
                        this.txtFecha.AutoNav = true;
                        this.txtFecha.AutoTab = true;
                        this.txtFecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtFecha.Location = new System.Drawing.Point(96, 148);
                        this.txtFecha.MaxLenght = 32767;
                        this.txtFecha.Name = "txtFecha";
                        this.txtFecha.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha.ReadOnly = false;
                        this.txtFecha.SetData = new string[] {
        "Todas|todo",
        "El Mes en Curso|mesactual",
        "El Mes Pasado|mespasado",
        "Por Fecha|fecha"};
                        this.txtFecha.Size = new System.Drawing.Size(248, 24);
                        this.txtFecha.TabIndex = 9;
                        this.txtFecha.Text = "Todas";
                        this.txtFecha.TextKey = "todo";
                        this.txtFecha.TipWhenBlank = "";
                        this.txtFecha.ToolTipText = "";
                        this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(16, 148);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(80, 24);
                        this.Label1.TabIndex = 8;
                        this.Label1.Text = "Fecha";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtVendedor
                        // 
                        this.txtVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtVendedor.AutoTab = true;
                        this.txtVendedor.CanCreate = false;
                        this.txtVendedor.DetailField = "nombre_visible";
                        this.txtVendedor.ExtraDetailFields = null;
                        this.txtVendedor.Filter = "(tipo&4)=4";
                        this.txtVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtVendedor.FreeTextCode = "";
                        this.txtVendedor.KeyField = "id_persona";
                        this.txtVendedor.Location = new System.Drawing.Point(96, 116);
                        this.txtVendedor.MaxLength = 200;
                        this.txtVendedor.Name = "txtVendedor";
                        this.txtVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtVendedor.ReadOnly = false;
                        this.txtVendedor.Required = false;
                        this.txtVendedor.Size = new System.Drawing.Size(324, 24);
                        this.txtVendedor.TabIndex = 7;
                        this.txtVendedor.Table = "personas";
                        this.txtVendedor.TeclaDespuesDeEnter = "{tab}";
                        this.txtVendedor.Text = "0";
                        this.txtVendedor.TextDetail = "";
                        this.txtVendedor.TextInt = 0;
                        this.txtVendedor.TipWhenBlank = "";
                        this.txtVendedor.ToolTipText = "";
                        // 
                        // Label5
                        // 
                        this.Label5.Location = new System.Drawing.Point(16, 116);
                        this.Label5.Name = "Label5";
                        this.Label5.Size = new System.Drawing.Size(80, 24);
                        this.Label5.TabIndex = 6;
                        this.Label5.Text = "Vendedor";
                        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtSucursal
                        // 
                        this.txtSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtSucursal.AutoTab = true;
                        this.txtSucursal.CanCreate = false;
                        this.txtSucursal.DetailField = "nombre";
                        this.txtSucursal.ExtraDetailFields = null;
                        this.txtSucursal.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtSucursal.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtSucursal.FreeTextCode = "";
                        this.txtSucursal.KeyField = "id_sucursal";
                        this.txtSucursal.Location = new System.Drawing.Point(96, 52);
                        this.txtSucursal.MaxLength = 200;
                        this.txtSucursal.Name = "txtSucursal";
                        this.txtSucursal.Padding = new System.Windows.Forms.Padding(2);
                        this.txtSucursal.ReadOnly = false;
                        this.txtSucursal.Required = false;
                        this.txtSucursal.Size = new System.Drawing.Size(324, 24);
                        this.txtSucursal.TabIndex = 3;
                        this.txtSucursal.Table = "sucursales";
                        this.txtSucursal.TeclaDespuesDeEnter = "{tab}";
                        this.txtSucursal.Text = "0";
                        this.txtSucursal.TextDetail = "";
                        this.txtSucursal.TextInt = 0;
                        this.txtSucursal.TipWhenBlank = "";
                        this.txtSucursal.ToolTipText = "";
                        // 
                        // label7
                        // 
                        this.label7.Location = new System.Drawing.Point(16, 52);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(80, 24);
                        this.label7.TabIndex = 2;
                        this.label7.Text = "Sucursal";
                        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.Location = new System.Drawing.Point(96, 20);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "De cobro|0",
        "De pago|1"};
                        this.txtTipo.Size = new System.Drawing.Size(168, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Text = "De cobro";
                        this.txtTipo.TextKey = "0";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(16, 20);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(80, 24);
                        this.label3.TabIndex = 0;
                        this.label3.Text = "Tipo";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Filtros
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(438, 375);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.txtSucursal);
                        this.Controls.Add(this.label7);
                        this.Controls.Add(this.txtVendedor);
                        this.Controls.Add(this.Label5);
                        this.Controls.Add(this.txtCliente);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtFecha2);
                        this.Controls.Add(this.lblFecha2);
                        this.Controls.Add(this.txtFecha1);
                        this.Controls.Add(this.lblFecha1);
                        this.Controls.Add(this.txtFecha);
                        this.Controls.Add(this.Label1);
                        this.Name = "Filtros";
                        this.Activated += new System.EventHandler(this.FormFacturaFiltros_Activated);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtFecha, 0);
                        this.Controls.SetChildIndex(this.lblFecha1, 0);
                        this.Controls.SetChildIndex(this.txtFecha1, 0);
                        this.Controls.SetChildIndex(this.lblFecha2, 0);
                        this.Controls.SetChildIndex(this.txtFecha2, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.txtCliente, 0);
                        this.Controls.SetChildIndex(this.Label5, 0);
                        this.Controls.SetChildIndex(this.txtVendedor, 0);
                        this.Controls.SetChildIndex(this.label7, 0);
                        this.Controls.SetChildIndex(this.txtSucursal, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.ResumeLayout(false);

                }

                #endregion

                private void txtFecha_TextChanged(System.Object sender, System.EventArgs e)
                {
                        if (txtFecha2.Text.Length == 0) {
                                txtFecha2.Text = txtFecha1.Text;
                        }

                        lblFecha1.Visible = (txtFecha.TextKey == "fecha");
                        lblFecha2.Visible = lblFecha1.Visible;
                        txtFecha1.Visible = lblFecha1.Visible;
                        txtFecha2.Visible = lblFecha2.Visible;
                }

                private void FormFacturaFiltros_Activated(object sender, System.EventArgs e)
                {
                        txtFecha_TextChanged(sender, e);
                }
        }
}