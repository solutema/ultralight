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

using System;
using System.Collections.Generic;
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
                private System.ComponentModel.IContainer components = null;

                // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
                // Puede modificarse utilizando el Diseñador de Windows Forms. 
                // No lo modifique con el editor de código.
                internal Lui.Forms.Label lblAviso;
                internal Lui.Forms.TextBox EntradaNumero;
                internal Lui.Forms.Label Label2;
                internal Lui.Forms.ComboBox EntradaTipo;
                internal Lui.Forms.Label Label1;
                internal Lui.Forms.Label Label7;
                internal Lui.Forms.Label Label4;
                internal Lui.Forms.Label Label8;
                internal Lcc.Entrada.CodigoDetalle EntradaVendedor;
                internal Lui.Forms.ListView Listado;
                internal System.Windows.Forms.ColumnHeader ColFecha;
                internal System.Windows.Forms.ColumnHeader ColumnHeader1;
                internal System.Windows.Forms.ColumnHeader ColumnHeader2;
                internal System.Windows.Forms.ColumnHeader ColumnHeader3;
                internal System.Windows.Forms.ColumnHeader ColumnHeader4;
                internal Lui.Forms.TextBox EntradaPv;
                internal Lcc.Entrada.CodigoDetalle EntradaCliente;
                internal System.Windows.Forms.ColumnHeader ColumnHeader5;
                internal System.Windows.Forms.ColumnHeader ColumnHeader6;

                private void InitializeComponent()
                {
                        this.lblAviso = new Lui.Forms.Label();
                        this.EntradaNumero = new Lui.Forms.TextBox();
                        this.Label2 = new Lui.Forms.Label();
                        this.EntradaTipo = new Lui.Forms.ComboBox();
                        this.Label1 = new Lui.Forms.Label();
                        this.EntradaPv = new Lui.Forms.TextBox();
                        this.Label7 = new Lui.Forms.Label();
                        this.Label4 = new Lui.Forms.Label();
                        this.Label8 = new Lui.Forms.Label();
                        this.EntradaVendedor = new Lcc.Entrada.CodigoDetalle();
                        this.Listado = new Lui.Forms.ListView();
                        this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
                        this.EntradaCliente = new Lcc.Entrada.CodigoDetalle();
                        this.SuspendLayout();
                        // 
                        // OkButton
                        // 
                        this.OkButton.Location = new System.Drawing.Point(454, 8);
                        // 
                        // CancelCommandButton
                        // 
                        this.CancelCommandButton.Location = new System.Drawing.Point(574, 8);
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
                        // EntradaNumero
                        // 
                        this.EntradaNumero.AutoSize = false;
                        this.EntradaNumero.AutoNav = true;
                        this.EntradaNumero.AutoTab = true;
                        this.EntradaNumero.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaNumero.DecimalPlaces = -1;
                        this.EntradaNumero.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaNumero.Location = new System.Drawing.Point(348, 68);
                        this.EntradaNumero.MultiLine = false;
                        this.EntradaNumero.Name = "EntradaNumero";
                        this.EntradaNumero.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaNumero.TemporaryReadOnly = false;
                        this.EntradaNumero.SelectOnFocus = true;
                        this.EntradaNumero.Size = new System.Drawing.Size(96, 24);
                        this.EntradaNumero.TabIndex = 9;
                        this.EntradaNumero.TextChanged += new System.EventHandler(this.EntradaVendedorClienteTipoPVNumero_TextChanged);
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
                        this.EntradaTipo.AutoSize = false;
                        this.EntradaTipo.AutoNav = true;
                        this.EntradaTipo.AutoTab = true;
                        this.EntradaTipo.Location = new System.Drawing.Point(84, 68);
                        this.EntradaTipo.Name = "EntradaTipo";
                        this.EntradaTipo.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaTipo.TemporaryReadOnly = false;
                        this.EntradaTipo.SetData = new string[] {
        "Factura A|A",
        "Factura B|B",
        "Factura C|C",
        "Factura E|E",
        "Factura M|M",
        "Todas|*"};
                        this.EntradaTipo.Size = new System.Drawing.Size(124, 24);
                        this.EntradaTipo.TabIndex = 5;
                        this.EntradaTipo.TextKey = "*";
                        this.EntradaTipo.TextChanged += new System.EventHandler(this.EntradaVendedorClienteTipoPVNumero_TextChanged);
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
                        // EntradaPv
                        // 
                        this.EntradaPv.AutoSize = false;
                        this.EntradaPv.AutoNav = true;
                        this.EntradaPv.AutoTab = true;
                        this.EntradaPv.DataType = Lui.Forms.DataTypes.FreeText;
                        this.EntradaPv.DecimalPlaces = -1;
                        this.EntradaPv.ForceCase = Lui.Forms.TextCasing.None;
                        this.EntradaPv.Location = new System.Drawing.Point(288, 68);
                        this.EntradaPv.MultiLine = false;
                        this.EntradaPv.Name = "EntradaPv";
                        this.EntradaPv.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaPv.TemporaryReadOnly = false;
                        this.EntradaPv.SelectOnFocus = true;
                        this.EntradaPv.Size = new System.Drawing.Size(48, 24);
                        this.EntradaPv.TabIndex = 7;
                        this.EntradaPv.TextChanged += new System.EventHandler(this.EntradaVendedorClienteTipoPVNumero_TextChanged);
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
                        this.EntradaVendedor.AutoSize = false;
                        this.EntradaVendedor.AutoTab = true;
                        this.EntradaVendedor.CanCreate = true;
                        this.EntradaVendedor.DataTextField = "nombre_visible";
                        this.EntradaVendedor.Filter = "(tipo&4)=4";
                        this.EntradaVendedor.FreeTextCode = "";
                        this.EntradaVendedor.DataValueField = "id_persona";
                        this.EntradaVendedor.Location = new System.Drawing.Point(84, 40);
                        this.EntradaVendedor.MaxLength = 200;
                        this.EntradaVendedor.Name = "EntradaVendedor";
                        this.EntradaVendedor.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaVendedor.TemporaryReadOnly = false;
                        this.EntradaVendedor.Required = false;
                        this.EntradaVendedor.Size = new System.Drawing.Size(360, 24);
                        this.EntradaVendedor.TabIndex = 3;
                        this.EntradaVendedor.Table = "personas";
                        this.EntradaVendedor.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaVendedor.Text = "0";
                        this.EntradaVendedor.TextDetail = "";
                        this.EntradaVendedor.TextChanged += new System.EventHandler(this.EntradaVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // lvItems
                        // 
                        this.Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.Listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader6,
            this.ColFecha,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
                        this.Listado.FullRowSelect = true;
                        this.Listado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        this.Listado.HideSelection = false;
                        this.Listado.LabelWrap = false;
                        this.Listado.Location = new System.Drawing.Point(8, 100);
                        this.Listado.MultiSelect = false;
                        this.Listado.Name = "lvItems";
                        this.Listado.Size = new System.Drawing.Size(680, 280);
                        this.Listado.TabIndex = 10;
                        this.Listado.UseCompatibleStateImageBehavior = false;
                        this.Listado.View = System.Windows.Forms.View.Details;
                        this.Listado.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
                        this.Listado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItems_KeyDown);
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
                        this.EntradaCliente.AutoSize = false;
                        this.EntradaCliente.AutoTab = true;
                        this.EntradaCliente.CanCreate = true;
                        this.EntradaCliente.DataTextField = "nombre_visible";
                        this.EntradaCliente.Filter = "";
                        this.EntradaCliente.FreeTextCode = "";
                        this.EntradaCliente.DataValueField = "id_persona";
                        this.EntradaCliente.Location = new System.Drawing.Point(84, 12);
                        this.EntradaCliente.MaxLength = 200;
                        this.EntradaCliente.Name = "EntradaCliente";
                        this.EntradaCliente.Padding = new System.Windows.Forms.Padding(2);
                        this.EntradaCliente.TemporaryReadOnly = false;
                        this.EntradaCliente.Required = false;
                        this.EntradaCliente.Size = new System.Drawing.Size(360, 24);
                        this.EntradaCliente.TabIndex = 1;
                        this.EntradaCliente.Table = "personas";
                        this.EntradaCliente.TeclaDespuesDeEnter = "{tab}";
                        this.EntradaCliente.Text = "0";
                        this.EntradaCliente.TextDetail = "";
                        this.EntradaCliente.TextChanged += new System.EventHandler(this.EntradaVendedorClienteTipoPVNumero_TextChanged);
                        // 
                        // FormSeleccionarFactura
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.ClientSize = new System.Drawing.Size(694, 475);
                        this.Controls.Add(this.EntradaCliente);
                        this.Controls.Add(this.Listado);
                        this.Controls.Add(this.Label4);
                        this.Controls.Add(this.Label8);
                        this.Controls.Add(this.EntradaVendedor);
                        this.Controls.Add(this.Label7);
                        this.Controls.Add(this.EntradaPv);
                        this.Controls.Add(this.lblAviso);
                        this.Controls.Add(this.EntradaNumero);
                        this.Controls.Add(this.Label2);
                        this.Controls.Add(this.EntradaTipo);
                        this.Controls.Add(this.Label1);
                        this.Name = "FormSeleccionarFactura";
                        this.Text = "Seleccionar Factura";
                        this.Controls.SetChildIndex(this.Label1, 0);
                        this.Controls.SetChildIndex(this.EntradaTipo, 0);
                        this.Controls.SetChildIndex(this.Label2, 0);
                        this.Controls.SetChildIndex(this.EntradaNumero, 0);
                        this.Controls.SetChildIndex(this.lblAviso, 0);
                        this.Controls.SetChildIndex(this.EntradaPv, 0);
                        this.Controls.SetChildIndex(this.Label7, 0);
                        this.Controls.SetChildIndex(this.EntradaVendedor, 0);
                        this.Controls.SetChildIndex(this.Label8, 0);
                        this.Controls.SetChildIndex(this.Label4, 0);
                        this.Controls.SetChildIndex(this.Listado, 0);
                        this.Controls.SetChildIndex(this.EntradaCliente, 0);
                        this.ResumeLayout(false);

                }


                #endregion

                private void EntradaVendedorClienteTipoPVNumero_TextChanged(System.Object sender, System.EventArgs e)
                {
                        string Sql = "SELECT * FROM comprob WHERE id_formapago>0";
                        if (EntradaVendedor.TextInt > 0)
                                Sql += " AND id_vendedor=" + EntradaVendedor.TextInt.ToString();

                        if (EntradaCliente.TextInt > 0)
                                Sql += " AND id_cliente=" + EntradaCliente.TextInt.ToString();

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

                        switch (EntradaTipo.TextKey) {
                                case "A":
                                        Sql += " AND tipo_fac IN ('FA', 'NCA', 'NDA')";
                                        break;
                                case "B":
                                        Sql += " AND tipo_fac IN ('FB', 'NCB', 'NDB')";
                                        break;
                                case "C":
                                        Sql += " AND tipo_fac IN ('FC', 'NCC', 'NDC')";
                                        break;
                                case "E":
                                        Sql += " AND tipo_fac IN ('FE', 'NCE', 'NDE')";
                                        break;
                                case "M":
                                        Sql += " AND tipo_fac IN ('FM', 'NCM', 'NDM')";
                                        break;
                                default:
                                        Sql += " AND tipo_fac IN ('FA', 'NCA', 'NDA', 'FB', 'NCB', 'NDB', 'FC', 'NCC', 'NDC', 'FE', 'NCE', 'NDE', 'FM', 'NCM', 'NDM')";
                                        break;
                        }

                        if (EntradaPv.Text.IsNumericInt())
                                Sql += " AND pv=" + Lfx.Types.Parsing.ParseInt(EntradaPv.Text).ToString();

                        if (EntradaNumero.Text.IsNumericInt())
                                Sql += " AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString();

                        Sql += " ORDER BY fecha DESC LIMIT 100";
                        DataTable Facturas = this.Connection.Select(Sql);

                        Listado.BeginUpdate();
                        Listado.Items.Clear();
                        foreach (System.Data.DataRow Factura in Facturas.Rows) {
                                ListViewItem Itm = Listado.Items.Add(System.Convert.ToString(Factura["id_comprob"]));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatDate(Factura["fecha"])));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, System.Convert.ToString(Factura["tipo_fac"])));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, System.Convert.ToInt32(Factura["pv"]).ToString("0000") + "-" + System.Convert.ToInt32(Factura["numero"]).ToString("00000000")));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, this.Connection.FieldString("SELECT nombre_visible FROM personas WHERE id_persona=" + Factura["id_cliente"].ToString())));
                                Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDecimal(Factura["total"]), this.Workspace.CurrentConfig.Moneda.Decimales)));
                                if (System.Convert.ToDouble(Factura["cancelado"]) >= System.Convert.ToDouble(Factura["total"]))
                                        Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, "Si"));
                                else
                                        Itm.SubItems.Add(new ListViewItem.ListViewSubItem(Itm, Lfx.Types.Formatting.FormatCurrency(System.Convert.ToDecimal(Factura["cancelado"]), this.Workspace.CurrentConfig.Moneda.Decimales)));
                        }
                        if (Listado.Items.Count > 0) {
                                Listado.Items[0].Selected = true;
                                Listado.Items[0].Focused = true;
                        }
                        Listado.EndUpdate();
                }


                private void lvItems_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        Lfx.Data.Row Factura = null;
                        ListViewItem Itm = null;
                        if (Listado.SelectedItems.Count > 0) {
                                Itm = Listado.SelectedItems[0];
                                Factura = this.Connection.Row("comprob", "id_comprob", Lfx.Types.Parsing.ParseInt(Itm.Text));
                        }

                        if (Factura != null) {
                                FacturaId = System.Convert.ToInt32(Factura["id_comprob"]);
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
                                        if (Listado.Items.Count == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        } else if (Listado.SelectedItems[0].Index == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        }
                                        break;
                                case Keys.Down:
                                        if (Listado.Items.Count == 0) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        } else if (Listado.SelectedItems.Count > 0 && Listado.SelectedItems[0].Index == Listado.Items.Count - 1) {
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
