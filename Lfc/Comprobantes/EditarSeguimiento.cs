#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
        public partial class EditarSeguimiento : Lui.Forms.DialogForm
        {
                public Lbl.Articulos.Situacion SituacionOrigen;
                private Lbl.Articulos.Articulo m_Articulo;
                private int m_Cantidad = 1;
                private Lbl.Articulos.ColeccionDatosSeguimiento m_DatosSeguimiento = null;
                private bool TextoLibre = false;

                public EditarSeguimiento()
                {
                        InitializeComponent();
                }


                public Lbl.Articulos.Articulo Articulo
                {
                        get
                        {
                                return m_Articulo;
                        }
                        set
                        {
                                m_Articulo = value;
                                this.Actualizar();
                        }
                }


                public int Cantidad
                {
                        get
                        {
                                return m_Cantidad;
                        }
                        set
                        {
                                m_Cantidad = value;
                                this.Actualizar();
                        }
                }


                private void Actualizar()
                {
                        string Ayuda;
                        if (m_Articulo != null) {
                                if (TextoLibre)
                                        Ayuda = "Proporcione los datos de ";
                                else
                                        Ayuda = "Seleccione ";
                                Ayuda += m_Cantidad.ToString() + " " + Articulo.ToString();
                                switch (m_Articulo.Seguimiento) {
                                        case Lbl.Articulos.Seguimientos.NumerosDeSerie:
                                                VariacionesCantidades.EsNumeroDeSerie = true;
                                                break;
                                        case Lbl.Articulos.Seguimientos.TallesYColores:
                                                VariacionesCantidades.EsNumeroDeSerie = false;
                                                break;
                                }
                        } else {
                                Ayuda = "";
                        }
                        EtiquetaArticulo.Text = Ayuda;
                }


                public Lbl.Articulos.ColeccionDatosSeguimiento DatosSeguimiento
                {
                        get
                        {
                                if (TextoLibre) {
                                        return VariacionesCantidades.DatosSeguimiento;
                                } else {
                                        Lbl.Articulos.ColeccionDatosSeguimiento Res = new Lbl.Articulos.ColeccionDatosSeguimiento();
                                        if (m_Cantidad == 1) {
                                                if (ListaDatosSeguimiento.SelectedItems.Count == 1)
                                                        Res.AddWithValue(ListaDatosSeguimiento.SelectedItems[0].Text, 1);
                                        } else {
                                                if (ListaDatosSeguimiento.CheckedItems == null || ListaDatosSeguimiento.CheckedItems.Count == 0)
                                                        return null;
                                                foreach (ListViewItem Itm in ListaDatosSeguimiento.CheckedItems) {
                                                        if (Res.ContainsVariacion(Itm.Text))
                                                                Res[Itm.Text].Cantidad++;
                                                        else
                                                                Res.AddWithValue(Itm.Text, 1);
                                                }
                                        }
                                        return Res;
                                }
                        }
                        set
                        {
                                m_DatosSeguimiento = value;
                                this.RefreshList();
                        }
                }

                public override Lfx.Types.OperationResult Ok()
                {
                        decimal CantidadSelect = 0;

                        if (TextoLibre) {
                                CantidadSelect = VariacionesCantidades.DatosSeguimiento.CantidadTotal;
                        } else {
                                if (m_Cantidad == 1)
                                        CantidadSelect = ListaDatosSeguimiento.SelectedItems.Count;
                                else
                                        CantidadSelect = ListaDatosSeguimiento.CheckedItems.Count;
                        }

                        if (CantidadSelect != m_Cantidad) {
                                if (m_Cantidad == 1)
                                        return new Lfx.Types.FailureOperationResult("Debe seleccionar un elemento.");
                                else
                                        return new Lfx.Types.FailureOperationResult("Debe seleccionar " + m_Cantidad.ToString() + " elementos.");
                        }
                        return base.Ok();
                }

                private void RefreshList()
                {
                        if (SituacionOrigen != null && SituacionOrigen.CuentaStock) {
                                Lbl.Articulos.ColeccionDatosSeguimiento SelectedSeries = new Lbl.Articulos.ColeccionDatosSeguimiento();
                                if (m_DatosSeguimiento != null && m_DatosSeguimiento.Count > 0)
                                        SelectedSeries.AddRange(m_DatosSeguimiento);

                                ListaDatosSeguimiento.BeginUpdate();
                                ListaDatosSeguimiento.Items.Clear();

                                System.Data.DataTable TablaListaItem = this.Connection.Select("SELECT serie, cantidad FROM articulos_series WHERE id_articulo=" + this.Articulo.Id.ToString() + " AND cantidad>0 AND id_situacion=" + this.SituacionOrigen.Id.ToString());
                                foreach (System.Data.DataRow RowItem in TablaListaItem.Rows) {
                                        string Variacion = RowItem["serie"].ToString();
                                        decimal StockVariacion = System.Convert.ToDecimal(RowItem["cantidad"]);

                                        for (int i = 0; i < StockVariacion && i < StockVariacion; i++) {
                                                ListViewItem Itm = ListaDatosSeguimiento.Items.Add(Variacion);
                                                Itm.SubItems[0].Text = Variacion;
                                                Itm.SubItems.Add("1");
                                                if (SelectedSeries.ContainsVariacion(Variacion)) {
                                                        if (SelectedSeries[Variacion].Cantidad-- > 0)
                                                                Itm.Checked = SelectedSeries.ContainsVariacion(Variacion);
                                                }
                                        }
                                }

                                if(m_Cantidad == 1)
                                        ListaDatosSeguimiento.CheckBoxes = false;
                                else
                                        ListaDatosSeguimiento.CheckBoxes = true;

                                ListaDatosSeguimiento.EndUpdate();
                                ListaDatosSeguimiento.Visible = true;
                                VariacionesCantidades.Visible = false;
                                TextoLibre = false;
                        } else {
                                ListaDatosSeguimiento.Visible = false;
                                VariacionesCantidades.Visible = true;
                                TextoLibre = true;
                                VariacionesCantidades.DatosSeguimiento = m_DatosSeguimiento;
                        }
                }

                private void EditarSeries_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.S && e.Control == true && e.Alt == false && e.Shift == false) {
                                ListaDatosSeguimiento.Visible = false;
                                VariacionesCantidades.Visible = true;
                                TextoLibre = true;
                        }
                }

                private void ListaSeries_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.KeyCode == Keys.Return && e.Control == false && e.Alt == false && e.Shift == false)
                                OkButton.PerformClick();
                }
        }
}
