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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc.Comprobantes
{
        public partial class EditSerials : Lui.Forms.DialogForm
        {
                public Lbl.Articulos.Situacion Situacion;
                public Lbl.Articulos.Articulo Articulo;
                public int Cantidad;
                private string m_Series = null;
                private bool TextoLibre = false;

                public EditSerials()
                {
                        InitializeComponent();
                }

                public string Series
                {
                        get
                        {
                                if (TextoLibre) {
                                        return EntradaSeries.Text;
                                } else {
                                        if (Cantidad > 1) {
                                                if (ListaSeries.CheckedItems == null || ListaSeries.CheckedItems.Count == 0)
                                                        return "";
                                                string Series = null;
                                                foreach (ListViewItem Itm in ListaSeries.CheckedItems) {
                                                        if (Series == null)
                                                                Series = Itm.Text;
                                                        else
                                                                Series += Lfx.Types.ControlChars.CrLf + Itm.Text;
                                                }
                                                return Series;
                                        } else {
                                                if (ListaSeries.SelectedItems == null || ListaSeries.SelectedItems.Count != 1)
                                                        return "";
                                                else
                                                        return ListaSeries.SelectedItems[0].Text;
                                        }
                                }
                        }
                        set
                        {
                                m_Series = value;
                                this.RefreshList();
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        int CantidadSelect = 0;

                        if (TextoLibre) {
                                string[] SeriesSelect = EntradaSeries.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                CantidadSelect = SeriesSelect.Length;
                        } else {
                                if (Cantidad == 1)
                                        CantidadSelect = ListaSeries.SelectedItems.Count;
                                else
                                        CantidadSelect = ListaSeries.CheckedItems.Count;
                        }

                        if (CantidadSelect != Cantidad) {
                                if (Cantidad == 1)
                                        return new Lfx.Types.FailureOperationResult("Debe seleccionar un número de serie.");
                                else
                                        return new Lfx.Types.FailureOperationResult("Debe seleccionar " + Cantidad.ToString() + " números de serie.");
                        }
                        return base.Ok();
                }

                private void RefreshList()
                {
                        if (Situacion != null && Situacion.CuentaStock) {
                                System.Collections.Generic.List<string> SelectedSeries = new List<string>();
                                if (m_Series != null && m_Series.Length > 0)
                                        SelectedSeries.AddRange(m_Series.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));

                                if (Cantidad > 1)
                                        ListaSeries.CheckBoxes = true;
                                else
                                        ListaSeries.CheckBoxes = false;

                                ListaSeries.BeginUpdate();
                                ListaSeries.Items.Clear();

                                System.Data.DataTable TablaListaItem = this.DataBase.Select("SELECT serie FROM articulos_series WHERE id_articulo=" + this.Articulo.Id.ToString() + " AND id_situacion=" + this.Situacion.Id.ToString());
                                foreach (System.Data.DataRow RowItem in TablaListaItem.Rows) {
                                        string Ser = RowItem["serie"].ToString();
                                        ListViewItem Itm = ListaSeries.Items.Add(Ser);
                                        Itm.SubItems[0].Text = Ser;
                                        if (Cantidad == 1) {
                                                if (Ser == m_Series)
                                                        Itm.Selected = true;
                                        } else {
                                                Itm.Checked = SelectedSeries.Contains(Ser);
                                        }
                                }
                                ListaSeries.EndUpdate();
                                ListaSeries.Visible = true;
                                EntradaSeries.Visible = false;
                                TextoLibre = false;
                        } else {
                                ListaSeries.Visible = false;
                                EntradaSeries.Visible = true;
                                TextoLibre = true;
                                EntradaSeries.Text = m_Series;
                        }
                }

                private void EditSerials_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.S && e.Control == true && e.Alt == false && e.Shift == false) {
                                ListaSeries.Visible = false;
                                EntradaSeries.Visible = true;
                                TextoLibre = true;
                        }
                }

                private void ListaSeries_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Return && e.Control == false && e.Alt == false && e.Shift == false) {
                                OkButton.PerformClick();
                        }
                }
        }
}
