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

namespace Lfc.Comprobantes.Compra
{
        public class Filtros : Lui.Forms.DialogForm
        {

                #region Código generado por el Diseñador de Windows Forms

                public Filtros()
                        : base()
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
                internal Lui.Forms.ComboBox txtTipo;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.TextBox txtFecha2;
                internal System.Windows.Forms.Label lblFecha2;
                internal Lui.Forms.TextBox txtFecha1;
                internal System.Windows.Forms.Label lblFecha1;
                internal Lui.Forms.ComboBox txtFecha;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label label3;
                internal Lui.Forms.ComboBox txtEstado;
                internal Lui.Forms.DetailBox txtProveedor;

                private void InitializeComponent()
                {
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.txtProveedor = new Lui.Forms.DetailBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtFecha2 = new Lui.Forms.TextBox();
                        this.lblFecha2 = new System.Windows.Forms.Label();
                        this.txtFecha1 = new Lui.Forms.TextBox();
                        this.lblFecha1 = new System.Windows.Forms.Label();
                        this.txtFecha = new Lui.Forms.ComboBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtEstado = new Lui.Forms.ComboBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(278, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(386, 8);
                        // 
                        // txtTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtTipo.Location = new System.Drawing.Point(100, 20);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "txtTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Notas de Pedido|NP",
        "Pedidos|PD",
        "Remitos|R",
        "Facturas A|A",
                                "Facturas B|B",
                                "Facturas C|C",
                                "Facturas E|E",
                                "Facturas M|M",
                                "Facturas (todas)|FP",
        "Todo|*"};
                        this.txtTipo.Size = new System.Drawing.Size(276, 24);
                        this.txtTipo.TabIndex = 1;
                        this.txtTipo.Text = "Pedidos";
                        this.txtTipo.TextKey = "PD";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(20, 20);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(80, 24);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Tipo";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtProveedor
                        // 
                        this.txtProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.txtProveedor.AutoTab = true;
                        this.txtProveedor.CanCreate = false;
                        this.txtProveedor.DetailField = "nombre_visible";
                        this.txtProveedor.ExtraDetailFields = null;
                        this.txtProveedor.Filter = "(tipo&2)=2";
                        this.txtProveedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtProveedor.FreeTextCode = "";
                        this.txtProveedor.KeyField = "id_persona";
                        this.txtProveedor.Location = new System.Drawing.Point(100, 84);
                        this.txtProveedor.MaxLength = 200;
                        this.txtProveedor.Name = "txtProveedor";
                        this.txtProveedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtProveedor.ReadOnly = false;
                        this.txtProveedor.Required = false;
                        this.txtProveedor.Size = new System.Drawing.Size(376, 24);
                        this.txtProveedor.TabIndex = 5;
                        this.txtProveedor.Table = "personas";
                        this.txtProveedor.TeclaDespuesDeEnter = "{tab}";
                        this.txtProveedor.Text = "0";
                        this.txtProveedor.TextDetail = "";
                        this.txtProveedor.TextInt = 0;
                        this.txtProveedor.TipWhenBlank = "";
                        this.txtProveedor.ToolTipText = "";
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(20, 84);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(80, 24);
                        this.Label2.TabIndex = 4;
                        this.Label2.Text = "Proveedor";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtFecha2
                        // 
                        this.txtFecha2.AutoNav = true;
                        this.txtFecha2.AutoTab = true;
                        this.txtFecha2.DataType = Lui.Forms.DataTypes.Date;
                        this.txtFecha2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha2.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFecha2.Location = new System.Drawing.Point(268, 148);
                        this.txtFecha2.MaxLenght = 32767;
                        this.txtFecha2.Name = "txtFecha2";
                        this.txtFecha2.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha2.ReadOnly = false;
                        this.txtFecha2.Size = new System.Drawing.Size(108, 24);
                        this.txtFecha2.TabIndex = 11;
                        this.txtFecha2.TipWhenBlank = "";
                        this.txtFecha2.ToolTipText = "";
                        this.txtFecha2.Visible = false;
                        // 
                        // lblFecha2
                        // 
                        this.lblFecha2.Location = new System.Drawing.Point(216, 148);
                        this.lblFecha2.Name = "lblFecha2";
                        this.lblFecha2.Size = new System.Drawing.Size(52, 24);
                        this.lblFecha2.TabIndex = 10;
                        this.lblFecha2.Text = "Hasta";
                        this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.lblFecha2.Visible = false;
                        // 
                        // txtFecha1
                        // 
                        this.txtFecha1.AutoNav = true;
                        this.txtFecha1.AutoTab = true;
                        this.txtFecha1.DataType = Lui.Forms.DataTypes.Date;
                        this.txtFecha1.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha1.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFecha1.Location = new System.Drawing.Point(100, 148);
                        this.txtFecha1.MaxLenght = 32767;
                        this.txtFecha1.Name = "txtFecha1";
                        this.txtFecha1.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha1.ReadOnly = false;
                        this.txtFecha1.Size = new System.Drawing.Size(108, 24);
                        this.txtFecha1.TabIndex = 9;
                        this.txtFecha1.TipWhenBlank = "";
                        this.txtFecha1.ToolTipText = "";
                        this.txtFecha1.Visible = false;
                        // 
                        // lblFecha1
                        // 
                        this.lblFecha1.Location = new System.Drawing.Point(20, 148);
                        this.lblFecha1.Name = "lblFecha1";
                        this.lblFecha1.Size = new System.Drawing.Size(80, 24);
                        this.lblFecha1.TabIndex = 8;
                        this.lblFecha1.Text = "Desde";
                        this.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.lblFecha1.Visible = false;
                        // 
                        // txtFecha
                        // 
                        this.txtFecha.AutoNav = true;
                        this.txtFecha.AutoTab = true;
                        this.txtFecha.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtFecha.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtFecha.Location = new System.Drawing.Point(100, 116);
                        this.txtFecha.MaxLenght = 32767;
                        this.txtFecha.Name = "txtFecha";
                        this.txtFecha.Padding = new System.Windows.Forms.Padding(2);
                        this.txtFecha.ReadOnly = false;
                        this.txtFecha.SetData = new string[] {
        "Todas|todo",
        "Los Últimos 30 Días|ultimos30",
        "El Mes en Curso|mesactual",
        "El Mes Pasado|mespasado",
        "Por Fecha|fecha"};
                        this.txtFecha.Size = new System.Drawing.Size(276, 24);
                        this.txtFecha.TabIndex = 7;
                        this.txtFecha.Text = "Todas";
                        this.txtFecha.TextKey = "todo";
                        this.txtFecha.TipWhenBlank = "";
                        this.txtFecha.ToolTipText = "";
                        this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(20, 116);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(80, 24);
                        this.Label1.TabIndex = 6;
                        this.Label1.Text = "Fecha";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtEstado
                        // 
                        this.txtEstado.AutoNav = true;
                        this.txtEstado.AutoTab = true;
                        this.txtEstado.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtEstado.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtEstado.Location = new System.Drawing.Point(100, 52);
                        this.txtEstado.MaxLenght = 32767;
                        this.txtEstado.Name = "txtEstado";
                        this.txtEstado.Padding = new System.Windows.Forms.Padding(2);
                        this.txtEstado.ReadOnly = false;
                        this.txtEstado.SetData = new string[] {
        "N/A|0"};
                        this.txtEstado.Size = new System.Drawing.Size(276, 24);
                        this.txtEstado.TabIndex = 3;
                        this.txtEstado.Text = "N/A";
                        this.txtEstado.TextKey = "0";
                        this.txtEstado.TipWhenBlank = "";
                        this.txtEstado.ToolTipText = "";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(20, 52);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(80, 24);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "Estado";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FormPedidosFiltros
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(494, 359);
                        this.Controls.Add(this.txtEstado);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.txtFecha2);
                        this.Controls.Add(this.lblFecha2);
                        this.Controls.Add(this.txtFecha1);
                        this.Controls.Add(this.lblFecha1);
                        this.Controls.Add(this.txtFecha);
                        this.Controls.Add(this.Label1);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.txtProveedor);
                        this.Controls.Add(this.Label2);
                        this.Name = "FormPedidosFiltros";
                        this.WorkspaceChanged += new System.EventHandler(this.FormPedidosFiltros_WorkspaceChanged);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.txtProveedor, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.txtTipo, 0);
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.txtFecha, 0);
                        this.Controls.SetChildIndex(this.lblFecha1, 0);
                        this.Controls.SetChildIndex(this.txtFecha1, 0);
                        this.Controls.SetChildIndex(this.lblFecha2, 0);
                        this.Controls.SetChildIndex(this.txtFecha2, 0);
                        this.Controls.SetChildIndex(this.label3, 0);
                        this.Controls.SetChildIndex(this.txtEstado, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                private void txtFecha_TextChanged(object sender, System.EventArgs e)
                {
                        lblFecha1.Visible = (txtFecha.TextKey == "fecha");
                        txtFecha1.Visible = lblFecha1.Visible;
                        lblFecha2.Visible = lblFecha1.Visible;
                        txtFecha2.Visible = lblFecha1.Visible;
                }

                private void txtTipo_TextChanged(object sender, System.EventArgs e)
                {
                        switch (txtTipo.TextKey) {
                                case "NP":
                                        txtEstado.SetData = new string[] {
                                                "Todos|-2",
                                                "No pedidos|-1",
						"Pedidos|100",
                                                "Cancelados|200"
					};
                                        txtEstado.Enabled = true;
                                        break;
                                case "PD":
                                        txtEstado.SetData = new string[] {
                                                "Todos|-2",
						"Sin especificar|0",
						"No recibidos|-1",
						"Recibidos|100"
					};
                                        txtEstado.Enabled = true;
                                        break;
                                default:
                                        txtEstado.SetData = new string[] { "N/A|-1" };
                                        txtEstado.Enabled = false;
                                        break;
                        }

                }

                private void FormPedidosFiltros_WorkspaceChanged(object sender, System.EventArgs e)
                {
                        txtTipo_TextChanged(sender, e);
                        txtFecha_TextChanged(sender, e);
                }

        }
}