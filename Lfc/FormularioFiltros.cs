#region License
// Copyright 2004-2011 Carrea Ernesto N., Martínez Miguel A.
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

using System.Collections.Generic;
using System.Windows.Forms;

namespace Lfc
{
        public partial class FormularioFiltros : Lui.Forms.DialogForm
        {
                private List<Lfx.Data.IFilter> Filtros;

                public FormularioFiltros()
                {
                        InitializeComponent();
                }

                public void FromFilters(List<Lfx.Data.IFilter> filters)
                {
                        this.Filtros = filters;
                        this.TablaFiltros.RowCount = filters.Count;

                        int i = 0;
                        foreach (Lfx.Data.IFilter Filtro in this.Filtros) {
                                Label Etiqueta = new Label();
                                Etiqueta.Name = "etiqueta" + i.ToString();
                                Etiqueta.Text = Filtro.Label;
                                Etiqueta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                                Etiqueta.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
                                Etiqueta.Dock = DockStyle.Fill;
                                this.TablaFiltros.Controls.Add(Etiqueta, 0, i);

                                Control Entrada;
                                if (Filtro is Lfx.Data.NumericRangeFilter) {
                                        Lcc.Entrada.RangoNumerico EntradaRangoNumerico = new Lcc.Entrada.RangoNumerico();
                                        Lfx.Data.NumericRangeFilter FiltroNumerico = Filtro as Lfx.Data.NumericRangeFilter;
                                        EntradaRangoNumerico.DecimalPlaces = FiltroNumerico.DecimalPlaces;
                                        EntradaRangoNumerico.Valule1 = FiltroNumerico.Min;
                                        EntradaRangoNumerico.Valule2 = FiltroNumerico.Max;
                                        EntradaRangoNumerico.Dock = DockStyle.Top;
                                        Entrada = EntradaRangoNumerico;
                                } else if (Filtro is Lfx.Data.SetFilter) {
                                        Lfx.Data.SetFilter FiltroSet = Filtro as Lfx.Data.SetFilter;
                                        Lui.Forms.ComboBox EntradaSet = new Lui.Forms.ComboBox();
                                        EntradaSet.SetData = FiltroSet.SetData;
                                        EntradaSet.TextKey = FiltroSet.CurrentValue;
                                        EntradaSet.AlwaysExpanded = EntradaSet.SetData != null && EntradaSet.SetData.Length <= 3;
                                        EntradaSet.AutoSize = true;
                                        Entrada = EntradaSet;
                                } else if (Filtro is Lfx.Data.DateRangeFilter) {
                                        Lfx.Data.DateRangeFilter FiltroFechas = Filtro as Lfx.Data.DateRangeFilter;
                                        Lcc.Entrada.RangoFechas EntradaRangoFechas = new Lcc.Entrada.RangoFechas();
                                        EntradaRangoFechas.Rango = FiltroFechas.DateRange;
                                        EntradaRangoFechas.AutoSize = true;
                                        Entrada = EntradaRangoFechas;
                                } else if (Filtro is Lfx.Data.RelationFilter) {
                                        Lfx.Data.RelationFilter FiltroRelacion = Filtro as Lfx.Data.RelationFilter;
                                        Lcc.Entrada.CodigoDetalle EntradaRelacion = new Lcc.Entrada.CodigoDetalle();
                                        EntradaRelacion.Relation = FiltroRelacion.Relation;
                                        EntradaRelacion.TextInt = FiltroRelacion.CurrentValue;
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


                public override Lfx.Types.OperationResult Ok()
                {
                        foreach (Lfx.Data.IFilter Filtro in this.Filtros) {
                                if (Filtro is Lfx.Data.NumericRangeFilter) {
                                        Lcc.Entrada.RangoNumerico EntradaRangoNumerico = Filtro.Control as Lcc.Entrada.RangoNumerico;
                                        Lfx.Data.NumericRangeFilter FiltroNumerico = Filtro as Lfx.Data.NumericRangeFilter;

                                        FiltroNumerico.Min = EntradaRangoNumerico.Valule1;
                                        FiltroNumerico.Max = EntradaRangoNumerico.Valule2;
                                } else if (Filtro is Lfx.Data.SetFilter) {
                                        Lfx.Data.SetFilter FiltroSet = Filtro as Lfx.Data.SetFilter;
                                        Lui.Forms.ComboBox EntradaSet = Filtro.Control as Lui.Forms.ComboBox;

                                        FiltroSet.CurrentValue = EntradaSet.TextKey;
                                } else if (Filtro is Lfx.Data.DateRangeFilter) {
                                        Lfx.Data.DateRangeFilter FiltroFechas = Filtro as Lfx.Data.DateRangeFilter;
                                        Lcc.Entrada.RangoFechas EntradaRangoFechas = Filtro.Control as Lcc.Entrada.RangoFechas;

                                        FiltroFechas.DateRange = EntradaRangoFechas.Rango;
                                } else if (Filtro is Lfx.Data.RelationFilter) {
                                        Lfx.Data.RelationFilter FiltroRelacion = Filtro as Lfx.Data.RelationFilter;
                                        Lcc.Entrada.CodigoDetalle EntradaRelacion = Filtro.Control as Lcc.Entrada.CodigoDetalle;

                                        FiltroRelacion.CurrentValue = EntradaRelacion.TextInt;
                                } else {
                                        // Tipo de filtro de reconocidgo
                                }
                        }
                        
                        return base.Ok();
                }
        }
}