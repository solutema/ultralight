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
        public partial class Seleccionar : Lui.Forms.DialogForm
        {
                public bool AceptarAnuladas = false, AceptarNoImpresas = false, AceptarCanceladas = true, DeCompra = false;
                public int FacturaId = 0;

                public Seleccionar()
                {
                        InitializeComponent();
                }


                private void EntradaVendedorClienteTipoPVNumero_TextChanged(System.Object sender, System.EventArgs e)
                {
                        qGen.Select SelFac = new qGen.Select("comprob");
                        SelFac.WhereClause = new qGen.Where();
                        SelFac.WhereClause.AddWithValue("id_formapago", qGen.ComparisonOperators.NotEqual, 0);

                        //string Sql = "SELECT * FROM comprob WHERE id_formapago>0";
                        if (EntradaVendedor.TextInt > 0)
                                //Sql += " AND id_vendedor=" + EntradaVendedor.TextInt.ToString();
                                SelFac.WhereClause.AddWithValue("id_vendedor", EntradaVendedor.TextInt);

                        if (EntradaCliente.TextInt > 0)
                                //Sql += " AND id_cliente=" + EntradaCliente.TextInt.ToString();
                                SelFac.WhereClause.AddWithValue("id_cliente", EntradaCliente.TextInt);

                        if (AceptarCanceladas == false)
                                //Sql += " AND cancelado<total";
                                SelFac.WhereClause.AddWithValue("cancelado", qGen.ComparisonOperators.LessThan, new qGen.SqlExpression("total"));

                        if (DeCompra) {
                                //Sql += " AND compra<>0";
                                SelFac.WhereClause.AddWithValue("compra", qGen.ComparisonOperators.NotEqual, 0);
                        } else {
                                //Sql += " AND compra=0";
                                SelFac.WhereClause.AddWithValue("compra", 0);
                                if (AceptarNoImpresas == false)
                                        //Sql += " AND impresa<>0";
                                        SelFac.WhereClause.AddWithValue("impresa", qGen.ComparisonOperators.NotEqual, 0);
                        }

                        if (AceptarAnuladas == false)
                                //Sql += " AND anulada=0";
                                SelFac.WhereClause.AddWithValue("anulada", 0);

                        switch (EntradaTipo.TextKey) {
                                case "A":
                                case "B":
                                case "C":
                                case "E":
                                case "M":
                                        //Sql += " AND tipo_fac IN ('FA', 'NCA', 'NDA')";
                                        SelFac.WhereClause.AddWithValue("tipo_fac", qGen.ComparisonOperators.In, new string[] { "F" + EntradaTipo.TextKey, "NC" + EntradaTipo.TextKey, "ND" + EntradaTipo.TextKey });
                                        break;
                                default:
                                        //Sql += " AND tipo_fac IN ('FA', 'NCA', 'NDA', 'FB', 'NCB', 'NDB', 'FC', 'NCC', 'NDC', 'FE', 'NCE', 'NDE', 'FM', 'NCM', 'NDM')";
                                        SelFac.WhereClause.AddWithValue("tipo_fac", qGen.ComparisonOperators.In, new string[] { "FA", "NCA", "NDA", "FB", "NCB", "NDB", "FC", "NCC", "NDC", "FE", "NCE", "NDE", "FM", "NCM", "NDM" });
                                        break;
                        }

                        if (EntradaPv.ValueInt > 0)
                                //Sql += " AND pv=" + Lfx.Types.Parsing.ParseInt(EntradaPv.Text).ToString();
                                SelFac.WhereClause.AddWithValue("pv", EntradaPv.ValueInt);

                        if (EntradaNumero.ValueInt > 0)
                                //Sql += " AND numero=" + Lfx.Types.Parsing.ParseInt(EntradaNumero.Text).ToString();
                                SelFac.WhereClause.AddWithValue("numero", EntradaNumero.ValueInt);

                        //Sql += " ORDER BY fecha DESC LIMIT 100";
                        SelFac.Order = "fecha DESC";
                        DataTable Facturas = this.Connection.Select(SelFac);

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
