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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
        /// <summary>
        /// Control calendario.
        /// </summary>
        public partial class Calendar : EditableControl
        {

                private DateTime m_CurrentDate = System.DateTime.Now;
                private List<DateTime> m_SelectedDates = new List<DateTime>();
                private bool m_ShowFocusRect = true;
                private bool m_MultiSelect = false;
                private string m_DateFormat = "dd/MM/yyyy";
                private List<Label> Dias = new List<Label>();

                public event System.EventHandler SelectedDatesChanged;
                public event System.EventHandler CurrentDateChanged;
                new public event System.EventHandler DoubleClick;

                public Calendar()
                {
                        InitializeComponent();

                        for (int s = 1; s <= 6; s++) {
                                for (int d = 1; d <= 7; d++) {
                                        Label lblDia = new Label();
                                        lblDia.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                                        lblDia.Text = "";
                                        lblDia.Size = new Size(28, 20);
                                        lblDia.TextAlign = ContentAlignment.MiddleCenter;
                                        lblDia.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                        lblDia.BringToFront();
                                        this.Controls.Add(lblDia);
                                        Dias.Add(lblDia);
                                        lblDia.MouseDown += new System.Windows.Forms.MouseEventHandler(lblDia_Click);
                                        lblDia.DoubleClick += new System.EventHandler(lblDia_DoubleClick);
                                }
                        }
                        lblMes.BackColor = Lfx.Config.Display.CurrentTemplate.ControlBackground;
                        ReubicarDias();
                        MostrarCalendario();

                }

                

                public string DateFormat
                {
                        get
                        {
                                return m_DateFormat;
                        }
                        set
                        {
                                m_DateFormat = value;
                        }
                }

                public bool MultiSelect
                {
                        get
                        {
                                return m_MultiSelect;
                        }
                        set
                        {
                                m_MultiSelect = value;
                                if (m_MultiSelect == false && m_SelectedDates.Count > 0)
                                        m_SelectedDates = new List<DateTime>();
                        }
                }

                public bool ShowFocusRect
                {
                        get
                        {
                                return m_ShowFocusRect;
                        }
                        set
                        {
                                m_ShowFocusRect = value;
                                MostrarCalendario();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public List<DateTime> SelectedDates
                {
                        get
                        {
                                return m_SelectedDates;
                        }
                        set
                        {
                                m_SelectedDates = value;

                                this.MostrarCalendario();

                                if (SelectedDatesChanged != null)
                                        SelectedDatesChanged(this, null);
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public DateTime CurrentDate
                {
                        get
                        {
                                return m_CurrentDate;
                        }
                        set
                        {
                                m_CurrentDate = new DateTime(value.Year, value.Month, value.Day);
                                
                                if (m_MultiSelect == false)
                                        this.SelectedDates = new List<DateTime>() { m_CurrentDate };

                                MostrarCalendario();

                                if (this.CurrentDateChanged != null)
                                        this.CurrentDateChanged(this, null);
                        }
                }

                private void Calendar_GotFocus(object sender, System.EventArgs e)
                {
                        pctFondo.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;
                }


                private void Calendar_LostFocus(object sender, System.EventArgs e)
                {
                        pctFondo.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                }


                private void MostrarCalendario()
                {
                        Label lblDia = null;
                        int DiasDelMes = DateTime.DaysInMonth(m_CurrentDate.Year, m_CurrentDate.Month);

                        this.SuspendLayout();

                        lblMes.Text = m_CurrentDate.ToString(@"MMMM ""de"" yyyy");

                        int PrimerDia = System.Convert.ToInt32(DateTime.ParseExact(m_CurrentDate.ToString("MM/01/yyyy", System.Globalization.CultureInfo.InvariantCulture), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture).DayOfWeek);

                        for (int i = 0; i <= PrimerDia - 1; i++) {
                                lblDia = ((Label)(Dias[i]));
                                lblDia.Enabled = false;
                                lblDia.Visible = false;
                                lblDia.Text = "?";
                                lblDia.Tag = 0;
                        }

                        for (int i = 1; i <= DiasDelMes; i++) {
                                lblDia = ((Label)(Dias[PrimerDia + i - 1]));
                                lblDia.Text = i.ToString();

                                if (IsSelected(new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, i))) {
                                        lblDia.BackColor = Lfx.Config.Display.CurrentTemplate.Selection;
                                        lblDia.ForeColor = Lfx.Config.Display.CurrentTemplate.SelectionText;
                                } else {
                                        lblDia.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                                        lblDia.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                }

                                if (m_ShowFocusRect && i == m_CurrentDate.Day)
                                        lblDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                else
                                        lblDia.BorderStyle = System.Windows.Forms.BorderStyle.None;

                                lblDia.Visible = true;
                                lblDia.Enabled = true;
                                lblDia.Tag = i;
                        }

                        for (int i = 0; i <= 42 - DiasDelMes - PrimerDia - 1; i++) {
                                lblDia = ((Label)(Dias[DiasDelMes + PrimerDia + i]));
                                lblDia.Enabled = false;
                                lblDia.Visible = false;
                                lblDia.Text = "!";
                                lblDia.Tag = 0;
                        }

                        this.ResumeLayout();
                }


                private void Calendar_Resize(object sender, System.EventArgs e)
                {
                        ReubicarDias();
                }


                private void ReubicarDias()
                {
                        if (Dias.Count > 0) {
                                this.SuspendLayout();
                                Label lblDia = null;
                                for (int s = 1; s <= 6; s++) {
                                        for (int d = 1; d <= 7; d++) {
                                                lblDia = ((Label)(Dias[(s - 1) * 7 + d - 1]));
                                                lblDia.Location = new Point(lblDia1.Left + (d - 1) * 32, lblDia1.Top + s * 24);
                                                lblDia.BringToFront();
                                        }
                                }
                                pctFondo.SendToBack();
                                this.ResumeLayout();
                        }
                }

                private void lblDia_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.DoubleClick != null)
                                this.DoubleClick(this, null);
                }

                private void lblDia_Click(object sender, System.Windows.Forms.MouseEventArgs e)
                {
                        if (this.Focused == false)
                                this.Focus();
                        int Dia = (int)((Label)sender).Tag;
                        if (Dia > 0) {
                                this.CurrentDate = new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, Dia);
                                if (m_MultiSelect)
                                        InvertSelectedState(m_CurrentDate);
                                else
                                        this.SelectedDates = new List<DateTime>() { this.CurrentDate };
                                MostrarCalendario();
                        }
                }

                private void Calendar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Up:
                                        this.CurrentDate = m_CurrentDate.AddDays(-7);
                                        break;
                                case Keys.Down:
                                        this.CurrentDate = m_CurrentDate.AddDays(7);
                                        break;
                                case Keys.Left:
                                        this.CurrentDate = m_CurrentDate.AddDays(-1);
                                        break;
                                case Keys.Right:
                                        this.CurrentDate = m_CurrentDate.AddDays(1);
                                        break;
                                case Keys.PageUp:
                                        this.CurrentDate = m_CurrentDate.AddMonths(-1);
                                        break;
                                case Keys.PageDown:
                                        this.CurrentDate = m_CurrentDate.AddMonths(1);
                                        break;
                                case Keys.Space:
                                        if (m_MultiSelect)
                                                InvertSelectedState(m_CurrentDate);
                                        MostrarCalendario();
                                        break;
                                case Keys.Return:
                                        e.Handled = true;
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        break;
                        }
                }

                public void InvertSelectedState(DateTime fecha)
                {
                        // Invierte la marca de un da determinado
                        if (IsSelected(fecha))
                                SelectionRem(fecha);
                        else
                                SelectionAdd(fecha);

                        if (SelectedDatesChanged != null)
                                SelectedDatesChanged(this, null);
                }


                public void SetSelectedState(DateTime Fecha, bool Selected)
                {
                        // Marca a desmarca un da (independientemente de su estado actual, a diferencia de InvertSelectedState)
                        if (Selected == false && IsSelected(Fecha))
                                SelectionRem(Fecha);
                        else if (Selected && IsSelected(Fecha) == false)
                                SelectionAdd(Fecha);

                        if (null != SelectedDatesChanged)
                                SelectedDatesChanged(this, null);
                }


                private void SelectionAdd(System.DateTime fecha)
                {
                        if (m_SelectedDates == null)
                                m_SelectedDates = new List<DateTime>();
                        m_SelectedDates.Add(fecha);
                }

                private void SelectionRem(System.DateTime fecha)
                {
                        foreach (DateTime FechaSeleccionada in m_SelectedDates) {
                                if (FechaSeleccionada == fecha) {
                                        m_SelectedDates.Remove(FechaSeleccionada);
                                        break;
                                }
                        }
                }


                public bool IsSelected(System.DateTime fechaABuscar)
                {
                        if (m_SelectedDates == null)
                                return false;

                        foreach (System.DateTime Fecha in m_SelectedDates) {
                                if (Fecha == fechaABuscar)
                                        return true;
                        }
                        return false;
                }


                public void InvertSelectedRow()
                {
                        // Marca o desmarca la semana completa
                        DateTime PrimerDiaSemana = m_CurrentDate.AddDays(System.Convert.ToInt32(-System.Convert.ToInt64(m_CurrentDate.DayOfWeek)) + 1);
                        bool bNuevoEstado = false;

                        // Me baso en el primer da de la semana para saber si marcar o desmarcar toda la semana
                        bNuevoEstado = !IsSelected(PrimerDiaSemana);

                        int i = 0;
                        for (i = 1; i <= 7; i++) {
                                SetSelectedState(PrimerDiaSemana.AddDays(i - 1), bNuevoEstado);
                        }

                        MostrarCalendario();
                }

                public void InvertSelectedMonth()
                {
                        int iDiasDelMes = DateTime.DaysInMonth(m_CurrentDate.Year, m_CurrentDate.Month);
                        bool bNuevoEstado = !IsSelected(new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, 1));

                        for (int i = 1; i <= iDiasDelMes; i++) {
                                SetSelectedState(new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, i), bNuevoEstado);
                        }
                        MostrarCalendario();
                }

        }
}
