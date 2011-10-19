#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Entrada
{
        public partial class Filtros : UserControl
        {
                public event System.EventHandler Apply;

                private IList<Lfx.Data.Filters.IFilter> ColFiltros;

                public Filtros()
                {
                        InitializeComponent();
                }


                public void FromFilters(IList<Lfx.Data.Filters.IFilter> filters)
                {
                        this.ColFiltros = filters;
                        this.TablaFiltros.RowCount = filters.Count;

                        int i = 0;
                        foreach (Lfx.Data.Filters.IFilter Filtro in this.ColFiltros) {
                                Label Etiqueta = new Label();
                                Etiqueta.Name = "etiqueta" + i.ToString();
                                Etiqueta.Text = Filtro.Label;
                                Etiqueta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                                Etiqueta.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
                                Etiqueta.Dock = DockStyle.Fill;
                                this.TablaFiltros.Controls.Add(Etiqueta, 0, i);

                                Control Entrada;
                                if (Filtro is Lfx.Data.Filters.NumericRangeFilter) {
                                        Lcc.Entrada.RangoNumerico EntradaRangoNumerico = new Lcc.Entrada.RangoNumerico();
                                        Lfx.Data.Filters.NumericRangeFilter FiltroNumerico = Filtro as Lfx.Data.Filters.NumericRangeFilter;
                                        EntradaRangoNumerico.DecimalPlaces = FiltroNumerico.DecimalPlaces;
                                        EntradaRangoNumerico.Valule1 = System.Convert.ToDecimal(FiltroNumerico.Value);
                                        EntradaRangoNumerico.Valule2 = System.Convert.ToDecimal(FiltroNumerico.Value2);
                                        EntradaRangoNumerico.Dock = DockStyle.Top;
                                        Entrada = EntradaRangoNumerico;
                                } else if (Filtro is Lfx.Data.Filters.SetFilter) {
                                        Lfx.Data.Filters.SetFilter FiltroSet = Filtro as Lfx.Data.Filters.SetFilter;
                                        Lui.Forms.ComboBox EntradaSet = new Lui.Forms.ComboBox();
                                        EntradaSet.SetData = FiltroSet.SetData;
                                        EntradaSet.TextKey = FiltroSet.CurrentValue;
                                        EntradaSet.AlwaysExpanded = false; // EntradaSet.SetData != null && EntradaSet.SetData.Length <= 4;
                                        EntradaSet.AutoSize = !EntradaSet.AlwaysExpanded;
                                        Entrada = EntradaSet;
                                } else if (Filtro is Lfx.Data.Filters.DateRangeFilter) {
                                        Lfx.Data.Filters.DateRangeFilter FiltroFechas = Filtro as Lfx.Data.Filters.DateRangeFilter;
                                        Lcc.Entrada.RangoFechas EntradaRangoFechas = new Lcc.Entrada.RangoFechas();
                                        EntradaRangoFechas.Rango = FiltroFechas.DateRange;
                                        EntradaRangoFechas.AutoSize = true;
                                        Entrada = EntradaRangoFechas;
                                } else if (Filtro is Lfx.Data.Filters.RelationFilter) {
                                        Lfx.Data.Filters.RelationFilter FiltroRelacion = Filtro as Lfx.Data.Filters.RelationFilter;
                                        Lcc.Entrada.CodigoDetalle EntradaRelacion = new Lcc.Entrada.CodigoDetalle();
                                        EntradaRelacion.Size = new System.Drawing.Size(160, 24);
                                        EntradaRelacion.Relation = FiltroRelacion.Relation;
                                        EntradaRelacion.Elemento = (Lbl.IElementoDeDatos)FiltroRelacion.Elemento;
                                        EntradaRelacion.Dock = DockStyle.Top;
                                        Entrada = EntradaRelacion;
                                } else {
                                        Entrada = new Label();
                                        Entrada.Text = Filtro.GetType().ToString();
                                        Etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                                }

                                Entrada.Name = "entrada" + i.ToString();
                                Entrada.Dock = DockStyle.Fill;
                                Filtro.Control = Entrada;

                                this.TablaFiltros.Controls.Add(Entrada, 1, i);

                                this.TablaFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());

                                i++;
                        }
                }


                /// <summary>
                /// Actualiza la variable ColFiltros según los controles en pantalla.
                /// </summary>
                public void ActualizarFiltros()
                {
                        foreach (Lfx.Data.Filters.IFilter Filtro in this.ColFiltros) {
                                if (Filtro is Lfx.Data.Filters.NumericRangeFilter) {
                                        Lcc.Entrada.RangoNumerico EntradaRangoNumerico = Filtro.Control as Lcc.Entrada.RangoNumerico;
                                        Lfx.Data.Filters.NumericRangeFilter FiltroNumerico = Filtro as Lfx.Data.Filters.NumericRangeFilter;

                                        FiltroNumerico.Value = EntradaRangoNumerico.Valule1;
                                        FiltroNumerico.Value2 = EntradaRangoNumerico.Valule2;
                                } else if (Filtro is Lfx.Data.Filters.SetFilter) {
                                        Lfx.Data.Filters.SetFilter FiltroSet = Filtro as Lfx.Data.Filters.SetFilter;
                                        Lui.Forms.ComboBox EntradaSet = Filtro.Control as Lui.Forms.ComboBox;

                                        FiltroSet.CurrentValue = EntradaSet.TextKey;
                                } else if (Filtro is Lfx.Data.Filters.DateRangeFilter) {
                                        Lfx.Data.Filters.DateRangeFilter FiltroFechas = Filtro as Lfx.Data.Filters.DateRangeFilter;
                                        Lcc.Entrada.RangoFechas EntradaRangoFechas = Filtro.Control as Lcc.Entrada.RangoFechas;

                                        FiltroFechas.DateRange = EntradaRangoFechas.Rango;
                                } else if (Filtro is Lfx.Data.Filters.RelationFilter) {
                                        Lfx.Data.Filters.RelationFilter FiltroRelacion = Filtro as Lfx.Data.Filters.RelationFilter;
                                        Lcc.Entrada.CodigoDetalle EntradaRelacion = Filtro.Control as Lcc.Entrada.CodigoDetalle;

                                        FiltroRelacion.Elemento = EntradaRelacion.Elemento;
                                } else {
                                        // Tipo de filtro de reconocidgo
                                }
                        }
                }


                private void BotonAplicar_Click(object sender, EventArgs e)
                {
                        this.ActualizarFiltros();

                        EventHandler Appl = this.Apply;
                        if (Appl != null)
                                Appl(this, new EventArgs());
                }


                /// <summary>
                /// Establece si se muestra o no un botón de aplicar filtros.
                /// </summary>
                public bool ShowApplyButton
                {
                        get
                        {
                                return this.BotonAplicar.Visible;
                        }
                        set
                        {
                                this.BotonAplicar.Visible = value;
                        }
                }
        }
}
