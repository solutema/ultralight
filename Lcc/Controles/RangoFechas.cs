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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles
{
        public partial class RangoFechas : Lui.Forms.Control
        {
                private bool m_MuestraFuturos = false;
                private Lfx.Types.DateRange m_Rango = new Lfx.Types.DateRange("dia-0");

                public RangoFechas()
                {
                        InitializeComponent();

                        EntradaTipoDeRango_TextChanged(this, null);
                        EntradaRango_TextChanged(this, null);
                }

                public bool MuestraFuturos
                {
                        get
                        {
                                return m_MuestraFuturos;
                        }
                        set
                        {
                                m_MuestraFuturos = value;
                        }
                }

                public override bool AutoHeight
                {
                        get
                        {
                                return base.AutoHeight;
                        }
                        set
                        {
                                base.AutoHeight = value;
                                EntradaRango.AutoHeight = value;
                                EntradaTipoDeRango.AutoHeight = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public override string Text
                {
                        get
                        {
                                return "";
                        }
                        set
                        {
                                base.Text = "";
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Types.DateRangeTypes TipoDeRango
                {
                        get
                        {
                                switch (EntradaTipoDeRango.TextKey) {
                                        case "dia":
                                                return Lfx.Types.DateRangeTypes.Day;
                                        case "semana":
                                                return Lfx.Types.DateRangeTypes.Week;
                                        case "mes":
                                                return Lfx.Types.DateRangeTypes.Month;
                                        default:
                                                return Lfx.Types.DateRangeTypes.Range;
                                }
                        }
                }

                private void EntradaTipoDeRango_TextChanged(object sender, EventArgs e)
                {
                        switch (EntradaTipoDeRango.TextKey) {
                                case "dia":
                                        EntradaRango.SetData = new string[] {
                                                "Hoy|dia-0",
                                                "Ayer|dia-1",
                                                "El " + DateTime.Now.AddDays(-2).ToString("dddd d") + "|dia-2",
                                                "El " + DateTime.Now.AddDays(-3).ToString("dddd d") + "|dia-3",
                                                "El " + DateTime.Now.AddDays(-4).ToString("dddd d") + "|dia-4",
                                                "El " + DateTime.Now.AddDays(-5).ToString("dddd d") + "|dia-5",
                                                "Un día específico|dia",
                                        };
                                        EntradaRango.TextKey = "dia-0";
                                        EtiquetaDesde.Text = "día";
                                        break;
                                case "semana":
                                        EntradaRango.SetData = new string[] {
                                                "Esta semana|semana-0",
                                                "La semana pasada|semana-1",
                                                "La semana del " + DateTime.Now.AddDays(-((int)(DateTime.Now.DayOfWeek)) - 13).ToString("dddd d") + "|semana-2",
                                                "La semana del " + DateTime.Now.AddDays(-((int)(DateTime.Now.DayOfWeek)) - 20).ToString("dddd d") + "|semana-3",
                                                "La semana del|semana",
                                        };
                                        EntradaRango.TextKey = "semana-0";
                                        EtiquetaDesde.Text = "día";
                                        break;
                                case "mes":
                                        EntradaRango.SetData = new string[] {
                                                "Este mes|mes-0",
                                                "El mes pasado|mes-1",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-2).ToString("MMMM")) + "|mes-2",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-3).ToString("MMMM")) + "|mes-3",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-4).ToString("MMMM")) + "|mes-4",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-5).ToString("MMMM")) + "|mes-5",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-6).ToString("MMMM")) + "|mes-6",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-7).ToString("MMMM")) + "|mes-7",
                                                Lfx.Types.Strings.ULCase(DateTime.Now.AddMonths(-8).ToString("MMMM")) + "|mes-8",
                                        };
                                        EntradaRango.TextKey = "mes-0";
                                        break;
                                case "rango":
                                case "-":
                                        EntradaRango.SetData = null;
                                        EntradaRango.TextKey = null;
                                        EntradaRango.Text = "-";
                                        EtiquetaDesde.Text = "Desde";
                                        m_Rango.Rep = "-";
                                        break;
                                case "todas":
                                case "*":
                                        EntradaRango.SetData = null;
                                        EntradaRango.TextKey = null;
                                        EntradaRango.Text = "*";
                                        EtiquetaDesde.Text = "Desde";
                                        m_Rango.Rep = "*";
                                        break;
                        }

                        EntradaRango_TextChanged(sender, e);
                }

                private void EntradaRango_TextChanged(object sender, EventArgs e)
                {
                        if (EntradaRango.TextKey.Length > 0)
                                m_Rango.Rep = EntradaRango.TextKey;

                        bool MuestraDesde = false, MuestraHasta = false;

                        EntradaRango.Visible = m_Rango.Rep != "*" && m_Rango.Rep != "-";

                        MuestraDesde = EntradaTipoDeRango.TextKey == "rango" ||
                                EntradaRango.TextKey == "dia" ||
                                EntradaRango.TextKey == "semana";

                        MuestraHasta = EntradaTipoDeRango.TextKey == "rango";

                        EntradaRango.Visible = EntradaTipoDeRango.TextKey == "dia" ||
                                EntradaTipoDeRango.TextKey == "semana" ||
                                EntradaTipoDeRango.TextKey == "mes";

                        EtiquetaDesde.Visible = MuestraDesde;
                        EntradaDesde.Visible = MuestraDesde;
                        EntradaHasta.Visible = MuestraHasta;
                        EtiquetaHasta.Visible = MuestraHasta;

                        PanelFechas.Visible = MuestraDesde || MuestraHasta;
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Types.DateRange Rango
                {
                        get
                        {
                                Lfx.Types.LDateTime Desde = Lfx.Types.Parsing.ParseDate(EntradaDesde.Text);
                                Lfx.Types.LDateTime Hasta = Lfx.Types.Parsing.ParseDate(EntradaHasta.Text);
                                if (Desde != null)
                                        m_Rango.From = Desde.Value;
                                if (Hasta != null)
                                        m_Rango.To = Hasta.Value;
                                else if(Desde != null)
                                        m_Rango.To = Desde.Value;
                                return m_Rango;
                        }
                        set
                        {
                                switch (value.Type)
                                {
                                        case Lfx.Types.DateRangeTypes.Day:
                                                EntradaTipoDeRango.TextKey = "dia";
                                                break;
                                        case Lfx.Types.DateRangeTypes.Week:
                                                EntradaTipoDeRango.TextKey = "semana";
                                                break;
                                        case Lfx.Types.DateRangeTypes.Month:
                                                EntradaTipoDeRango.TextKey = "mes";
                                                break;
                                        case Lfx.Types.DateRangeTypes.Range:
                                                EntradaTipoDeRango.TextKey = "rango";
                                                break;
                                        case Lfx.Types.DateRangeTypes.All:
                                                EntradaTipoDeRango.TextKey = "todas";
                                                break;
                                }
                                EntradaRango.TextKey = value.Rep;
                                EntradaDesde.Text = Lfx.Types.Formatting.FormatDate(value.From);
                                EntradaHasta.Text = Lfx.Types.Formatting.FormatDate(value.To);
                                m_Rango = value;
                        }
                }

                private void EntradaDesde_TextChanged(object sender, EventArgs e)
                {
                        Lfx.Types.LDateTime Fecha = Lfx.Types.Parsing.ParseDate(EntradaDesde.Text);
                        if (Fecha != null)
                                m_Rango.From = Fecha.Value;
                }

                private void EntradaHasta_TextChanged(object sender, EventArgs e)
                {
                        Lfx.Types.LDateTime Fecha = Lfx.Types.Parsing.ParseDate(EntradaHasta.Text);
                        if (Fecha != null)
                                m_Rango.To = Fecha.Value;
                }

                private void Combos_SizeChanged(object sender, EventArgs e)
                {
                        PanelCombos.Height = (EntradaRango.Height > EntradaTipoDeRango.Height ? EntradaRango.Height : EntradaTipoDeRango.Height) + 4;
                }

                private void Paneles_SizeChanged(object sender, EventArgs e)
                {
                        if (this.AutoHeight)
                                this.Height = PanelCombos.Height + (PanelFechas.Visible ? PanelFechas.Height : 0) + 2;
                }
        }
}
