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

namespace Lfc.Comprobantes.Facturas
{
        public class FormSeleccionarFactura : Lui.Forms.DialogForm
        {
                public bool AceptarAnuladas = false, AceptarNoImpresas = false, AceptarCanceladas = true, DeCompra = false;
                public int FacturaId = 0;

                #region Código generado por el Diseñador de Windows Forms

                public FormSeleccionarFactura()
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
                internal System.Windows.Forms.Label lblAviso;
                internal Lui.Forms.TextBox txtNumero;
                internal System.Windows.Forms.Label Label2;
                internal Lui.Forms.ComboBox txtTipo;
                internal System.Windows.Forms.Label Label1;
                internal System.Windows.Forms.Label Label7;
                internal System.Windows.Forms.Label Label4;
                internal System.Windows.Forms.Label Label8;
                internal Lui.Forms.DetailBox txtVendedor;
                internal Lui.Forms.ListView lvItems;
                internal System.Windows.Forms.ColumnHeader ColFecha;
                internal System.Windows.Forms.ColumnHeader ColumnHeader1;
                internal System.Windows.Forms.ColumnHeader ColumnHeader2;
                internal System.Windows.Forms.ColumnHeader ColumnHeader3;
                internal System.Windows.Forms.ColumnHeader ColumnHeader4;
                internal Lui.Forms.TextBox txtPV;
                internal Lui.Forms.DetailBox txtCliente;
                internal System.Windows.Forms.ColumnHeader ColumnHeader5;
                internal System.Windows.Forms.ColumnHeader ColumnHeader6;

                private void InitializeComponent()
                {
                        this.lblAviso = new System.Windows.Forms.Label();
                        this.txtNumero = new Lui.Forms.TextBox();
                        this.Label2 = new System.Windows.Forms.Label();
                        this.txtTipo = new Lui.Forms.ComboBox();
                        this.Label1 = new System.Windows.Forms.Label();
                        this.txtPV = new Lui.Forms.TextBox();
                        this.Label7 = new System.Windows.Forms.Label();
                        this.Label4 = new System.Windows.Forms.Label();
                        this.Label8 = new System.Windows.Forms.Label();
                        this.txtVendedor = new Lui.Forms.DetailBox();
                        this.lvItems = new Lui.Forms.ListView();
                        this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
                        this.ColFecha = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
                        this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
                        this.txtCliente = new Lui.Forms.DetailBox();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(478, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(586, 8);
                        // 
                        // lblAviso
                        // 
                        this.lblAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lblAviso.Location = new System.Drawing.Point(8, 384);
                        this.lblAviso.Name = "lblAviso";
                        this.lblAviso.Size = new System.Drawing.Size(680, 24);
                        this.lblAviso.TabIndex = 11;
                        this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // txtNumero
                        // 
                        this.txtNumero.AutoNav = true;
                        this.txtNumero.AutoTab = true;
                        this.txtNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtNumero.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtNumero.Location = new System.Drawing.Point(348, 68);
                        this.txtNumero.MaxLenght = 32767;
                        this.txtNumero.Name = "txtNumero";
                        this.txtNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.txtNumero.ReadOnly = false;
                        this.txtNumero.Size = new System.Drawing.Size(96, 24);
                        this.txtNumero.TabIndex = 9;
                        this.txtNumero.TipWhenBlank = "";
                        this.txtNumero.ToolTipText = "";
                        this.txtNumero.TextChanged += new System.EventHandler(this.txtVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // Label2
                        // 
                        this.Label2.Location = new System.Drawing.Point(216, 68);
                        this.Label2.Name = "Label2";
                        this.Label2.Size = new System.Drawing.Size(72, 24);
                        this.Label2.TabIndex = 6;
                        this.Label2.Text = "Número";
                        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaTipo
                        // 
                        this.txtTipo.AutoNav = true;
                        this.txtTipo.AutoTab = true;
                        this.txtTipo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtTipo.Location = new System.Drawing.Point(84, 68);
                        this.txtTipo.MaxLenght = 32767;
                        this.txtTipo.Name = "EntradaTipo";
                        this.txtTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.txtTipo.ReadOnly = false;
                        this.txtTipo.SetData = new string[] {
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Factura M|M",
        "Todas|*"};
                        this.txtTipo.Size = new System.Drawing.Size(124, 24);
                        this.txtTipo.TabIndex = 5;
                        this.txtTipo.Text = "Todas";
                        this.txtTipo.TextKey = "*";
                        this.txtTipo.TipWhenBlank = "";
                        this.txtTipo.ToolTipText = "";
                        this.txtTipo.TextChanged += new System.EventHandler(this.txtVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // Label1
                        // 
                        this.Label1.Location = new System.Drawing.Point(12, 68);
                        this.Label1.Name = "Label1";
                        this.Label1.Size = new System.Drawing.Size(72, 24);
                        this.Label1.TabIndex = 4;
                        this.Label1.Text = "Tipo";
                        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // txtPV
                        // 
                        this.txtPV.AutoNav = true;
                        this.txtPV.AutoTab = true;
                        this.txtPV.DataType = Lui.Forms.DataTypes.FreeText;
                        this.txtPV.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(25)))));
                        this.txtPV.Location = new System.Drawing.Point(288, 68);
                        this.txtPV.MaxLenght = 32767;
                        this.txtPV.Name = "txtPV";
                        this.txtPV.Padding = new System.Windows.Forms.Padding(2);
                        this.txtPV.ReadOnly = false;
                        this.txtPV.Size = new System.Drawing.Size(48, 24);
                        this.txtPV.TabIndex = 7;
                        this.txtPV.TipWhenBlank = "";
                        this.txtPV.ToolTipText = "";
                        this.txtPV.TextChanged += new System.EventHandler(this.txtVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // Label7
                        // 
                        this.Label7.Location = new System.Drawing.Point(336, 68);
                        this.Label7.Name = "Label7";
                        this.Label7.Size = new System.Drawing.Size(12, 24);
                        this.Label7.TabIndex = 8;
                        this.Label7.Text = "-";
                        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // Label4
                        // 
                        this.Label4.Location = new System.Drawing.Point(12, 12);
                        this.Label4.Name = "Label4";
                        this.Label4.Size = new System.Drawing.Size(72, 24);
                        this.Label4.TabIndex = 0;
                        this.Label4.Text = "Cliente";
                        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // Label8
                        // 
                        this.Label8.Location = new System.Drawing.Point(12, 40);
                        this.Label8.Name = "Label8";
                        this.Label8.Size = new System.Drawing.Size(72, 24);
                        this.Label8.TabIndex = 2;
                        this.Label8.Text = "Vendedor";
                        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // EntradaVendedor
                        // 
                        this.txtVendedor.AutoTab = true;
                        this.txtVendedor.CanCreate = true;
                        this.txtVendedor.DetailField = "nombre_visible";
                        this.txtVendedor.ExtraDetailFields = null;
                        this.txtVendedor.Filter = "(tipo&4)=4";
                        this.txtVendedor.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtVendedor.FreeTextCode = "";
                        this.txtVendedor.KeyField = "id_persona";
                        this.txtVendedor.Location = new System.Drawing.Point(84, 40);
                        this.txtVendedor.MaxLength = 200;
                        this.txtVendedor.Name = "EntradaVendedor";
                        this.txtVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.txtVendedor.ReadOnly = false;
                        this.txtVendedor.Required = false;
                        this.txtVendedor.Size = new System.Drawing.Size(360, 24);
                        this.txtVendedor.TabIndex = 3;
                        this.txtVendedor.Table = "personas";
                        this.txtVendedor.TeclaDespuesDeEnter = "{tab}";
                        this.txtVendedor.Text = "0";
                        this.txtVendedor.TextDetail = "";
                        this.txtVendedor.TextInt = 0;
                        this.txtVendedor.TipWhenBlank = "";
                        this.txtVendedor.ToolTipText = "";
                        this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // lvItems
                        // 
                        this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader6,
            this.ColFecha,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
                        this.lvItems.FullRowSelect = true;
                        this.lvItems.GridLines = true;
                        this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.lvItems.HideSelection = false;
                        this.lvItems.LabelWrap = false;
                        this.lvItems.Location = new System.Drawing.Point(8, 100);
                        this.lvItems.MultiSelect = false;
                        this.lvItems.Name = "lvItems";
                        this.lvItems.Size = new System.Drawing.Size(680, 280);
                        this.lvItems.TabIndex = 10;
                        this.lvItems.UseCompatibleStateImageBehavior = false;
                        this.lvItems.View = System.Windows.Forms.View.Details;
                        this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
                        this.lvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItems_KeyDown);
                        // 
                        // ColumnHeader6
                        // 
                        this.ColumnHeader6.Text = "Id";
                        this.ColumnHeader6.Width = 0;
                        // 
                        // ColFecha
                        // 
                        this.ColFecha.Text = "Fecha";
                        this.ColFecha.Width = 86;
                        // 
                        // ColumnHeader1
                        // 
                        this.ColumnHeader1.Text = "Tipo";
                        this.ColumnHeader1.Width = 42;
                        // 
                        // ColumnHeader2
                        // 
                        this.ColumnHeader2.Text = "Número";
                        this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader2.Width = 116;
                        // 
                        // ColumnHeader3
                        // 
                        this.ColumnHeader3.Text = "Cliente";
                        this.ColumnHeader3.Width = 196;
                        // 
                        // ColumnHeader4
                        // 
                        this.ColumnHeader4.Text = "Importe";
                        this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader4.Width = 86;
                        // 
                        // ColumnHeader5
                        // 
                        this.ColumnHeader5.Text = "Cancelada";
                        this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        this.ColumnHeader5.Width = 86;
                        // 
                        // EntradaCliente
                        // 
                        this.txtCliente.AutoTab = true;
                        this.txtCliente.CanCreate = true;
                        this.txtCliente.DetailField = "nombre_visible";
                        this.txtCliente.ExtraDetailFields = null;
                        this.txtCliente.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText;
                        this.txtCliente.FreeTextCode = "";
                        this.txtCliente.KeyField = "id_persona";
                        this.txtCliente.Location = new System.Drawing.Point(84, 12);
                        this.txtCliente.MaxLength = 200;
                        this.txtCliente.Name = "EntradaCliente";
                        this.txtCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.txtCliente.ReadOnly = false;
                        this.txtCliente.Required = false;
                        this.txtCliente.Size = new System.Drawing.Size(360, 24);
                        this.txtCliente.TabIndex = 1;
                        this.txtCliente.Table = "personas";
                        this.txtCliente.TeclaDespuesDeEnter = "{tab}";
                        this.txtCliente.Text = "0";
                        this.txtCliente.TextDetail = "";
                        this.txtCliente.TextInt = 0;
                        this.txtCliente.TipWhenBlank = "";
                        this.txtCliente.ToolTipText = "";
                        this.txtCliente.TextChanged += new System.EventHandler(this.txtVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // FormSeleccionarFactura
                        // 
                        this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
                        this.ClientSize = new System.Drawing.Size(694, 475);
                        this.Controls.Add(this.txtCliente);
                        this.Controls.Add(this.lvItems);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.txtVendedor);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.txtPV);
                        this.Controls.Add(this.lblAviso);
                        this.Controls.Add(this.txtNumero);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.txtTipo);
                        this.Controls.Add(this.Label1);
                        this.Name = "FormSeleccionarFactura";
                        this.Text = "Seleccionar Factura";
                        this.ResumeLayout(false);

                }


                #endregion

                private void txtVendedorClienteTipoPVNumero_TextChanged(System.Object sender, System.EventArgs e)
                {
                        string Sql = "SELECT * FROM facturas WHERE id_formapago>0";
                        if (txtVendedor.TextInt > 0)
                                Sql += " AND id_vendedor=" + txtVendedor.TextInt.ToString();

                        if (txtCliente.TextInt > 0)
                                Sql += " AND id_cliente=" + txtCliente.TextInt.ToString();

                        if (AceptarCanceladas == false)
                                Sql += " AND cancelado<total";

                        if (DeCompra) {
                                Sql += " AND compra<>0";
                        } else {
                                Sql += " AND compra=0";
                                if (AceptarNoImpresas == false)
                                        Sql += " AND impresa<>0";
                        }

                        if (AceptarAnuladas == false)
                                Sql += " AND anulada=0";

                        switch (txtTipo.TextKey) {
                                case "A":
                                        Sql += " AND tipo_fac IN ('A', 'NCA', 'NDA')";
                                        break;
                                case "B":
                                        Sql += " AND tipo_fac IN ('B', 'NCB', 'NDB')";
                                        break;
                                case "C":
                                        Sql += " AND tipo_fac IN ('C', 'NCC', 'NDC')";
                                        break;
                                case "E":
                                        Sql += " AND tipo_fac IN ('E', 'NCE', 'NDE')";
                                        break;
                                case "M":
                                        Sql += " AND tipo_fac IN ('M', 'NCM', 'NDM')";
                                        break;
                                default:
                                        Sql += " AND tipo_fac IN ('A', 'NCA', 'NDA', 'B', 'NCB', 'NDB', 'C', 'NCC', 'NDC', 'E', 'NCE', 'NDE', 'M', 'NCM', 'NDM')";
                                        break;
                        }

                        if (Lfx.Types.Strings.IsNumericInt(txtPV.Text))
                                Sql += " AND pv=" + Lfx.Types.Parsing.ParseInt(txtPV.Text).ToString();

                        if (Lfx.Types.Strings.IsNumericInt(txtNumero.Text))
                                Sql += " AND numero=" + Lfx.Types.Parsing.ParseInt(txtNumero.Text).ToString();

                        Sql += " ORDER BY fecha DESC LIMIT 100";
                        DataTable Facturas = this.Workspace.DefaultDataBase.Select(Sql);

                        lvItems.BeginUpdate();
                        lvItems.Items.Clear();
                        foreach (System.Data.DataRow Factura in Facturas.Rows) {
                                ListViewItem Itm = lvItems.Items.Add(System.Convert.ToString(Factura["id_factura"]));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatDate(Factura["fecha"])));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, System.Convert.ToString(Factura["tipo_fac"])));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, System.Convert.ToInt32(Factura["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(Factura["numero"]).ToString("00000000")));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, this.Workspace.DefaultDataBase.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Factura["id_cliente"].ToString())));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Factura["total"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                                if (System.Convert.ToDouble(Factura["cancelado"]) >= System.Convert.ToDouble(Factura["total"]))
                                        Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, "Si"));
                                else
                                        Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDouble(Factura["cancelado"]), this.Workspace.CurrentConfig.Currency.DecimalPlaces)));
                        }
                        if (lvItems.Items.Count > 0) {
                                lvItems.Items[0].Selected = true;
                                lvItems.Items[0].Focused = true;
                        }
                        lvItems.EndUpdate();
                }


                private void lvItems_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        Lfx.Data.Row Factura = null;
                        ListViewItem Itm = null;
                        if (lvItems.SelectedItems.Count > 0) {
                                Itm = lvItems.SelectedItems[0];
                                Factura = this.Workspace.DefaultDataBase.Row("facturas", "id_factura", Lfx.Types.Parsing.ParseInt(Itm.Text));
                        }

                        if (Factura != null) {
                                FacturaId = System.Convert.ToInt32(Factura["id_factura"]);
                                if (System.Convert.ToInt32(Factura["anulada"]) != 0 && AceptarAnuladas == false) {
                                        lblAviso.Text = "Esta factura fue anulada.";
                                        OkButton.Visible = false;
                                } else if (Itm.SubItems[6].Text == "Si" && AceptarCanceladas == false) {
                                        lblAviso.Text = "Esta factura ya fue pagada.";
                                        OkButton.Visible = false;
                                } else if (Lfx.Types.Parsing.ParseCurrency(Itm.SubItems[6].Text) > 0) {
                                        lblAviso.Text = "Esta factura fue pagada parcialmente.";
                                        OkButton.Visible = true;
                                } else {
                                        lblAviso.Text = "";
                                        OkButton.Visible = true;
                                }
                        } else {
                                lblAviso.Text = "";
                                OkButton.Visible = false;
                        }
                }


                private void lvItems_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Up:
                                        if (lvItems.Items.Count == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        } else if (lvItems.SelectedItems[0].Index == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        }
                                        break;
                                case Keys.Down:
                                        if (lvItems.Items.Count == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        } else if (lvItems.SelectedItems.Count > 0 && lvItems.SelectedItems[0].Index == lvItems.Items.Count - 1) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        }
                                        break;
                                case Keys.Return:
                                        e.Handled = true;
                                        if (OkButton.Visible && OkButton.Enabled)
                                                OkButton.PerformClick();
                                        break;
                        }
                }
        }
}