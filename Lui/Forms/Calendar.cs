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

using System.ComponentModel;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	/// <summary>
	/// Control calendario.
	/// </summary>
    public class Calendar: Control
    {

        private DateTime m_CurrentDate = System.DateTime.Now;
        private System.Collections.ArrayList m_SelectedDates = new System.Collections.ArrayList();
        private bool m_ShowFocusRect = true;
        private bool m_MultiSelect = false;
        private string m_DateFormat = "dd/MM/yyyy";
        private System.Collections.ArrayList Dias = new System.Collections.ArrayList();

        public event System.EventHandler SelectedDatesChanged;
        public event System.EventHandler CurrentDateChanged;
		public new event System.EventHandler DoubleClick;

        #region Código generado por el Diseñador de Windows Forms

        public Calendar()
            : base()
        {


            // Necesario para admitir el Diseñador de Windows Forms
            InitializeComponent();

            for(int s = 1; s <= 6; s++)
            {
                for(int d = 1; d <= 7; d++)
                {
                    Label lblDia = new Label();
                    lblDia.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                    lblDia.Text = "";
                    lblDia.Size = new Size(28, 20);
                    lblDia.TextAlign = ContentAlignment.MiddleCenter;
                    lblDia.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                    lblDia.BringToFront();
                    this.Controls.Add(lblDia);
                    Dias.Add(lblDia);
                    lblDia.MouseDown += new System.Windows.Forms.MouseEventHandler(lblDia_Click);
					lblDia.DoubleClick += new System.EventHandler(lblDia_DoubleClick);
                }
            }
            lblMes.BackColor = Lws.Config.Display.CurrentTemplate.ControlBackground;
            ReubicarDias();
            MostrarCalendario();

        }

		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components;

        // Limpiar los recursos que se estén utilizando.
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        // NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
        // Puede modificarse utilizando el Diseñador de Windows Forms. 
        // No lo modifique con el editor de código.
        internal System.Windows.Forms.Label lblMes;
        internal System.Windows.Forms.Label lblDia7;
        internal System.Windows.Forms.Label lblDia6;
        internal System.Windows.Forms.Label lblDia5;
        internal System.Windows.Forms.Label lblDia4;
        internal System.Windows.Forms.Label lblDia3;
        internal System.Windows.Forms.Label lblDia2;
        internal System.Windows.Forms.Label lblDia1;
        internal System.Windows.Forms.PictureBox pctFondo;


        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDia7 = new System.Windows.Forms.Label();
            this.lblDia6 = new System.Windows.Forms.Label();
            this.lblDia5 = new System.Windows.Forms.Label();
            this.lblDia4 = new System.Windows.Forms.Label();
            this.lblDia3 = new System.Windows.Forms.Label();
            this.lblDia2 = new System.Windows.Forms.Label();
            this.lblDia1 = new System.Windows.Forms.Label();
            this.pctFondo = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMes.BackColor = Lws.Config.Display.CurrentTemplate.ControlBackground;
            this.lblMes.Location = new System.Drawing.Point(8, 8);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(220, 24);
            this.lblMes.TabIndex = 101;
            this.lblMes.Text = "Septiembre de 2004";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia7
            // 
            this.lblDia7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia7.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia7.Location = new System.Drawing.Point(200, 36);
            this.lblDia7.Name = "lblDia7";
            this.lblDia7.Size = new System.Drawing.Size(28, 20);
            this.lblDia7.TabIndex = 100;
            this.lblDia7.Text = "S";
            this.lblDia7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia6
            // 
            this.lblDia6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia6.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia6.Location = new System.Drawing.Point(168, 36);
            this.lblDia6.Name = "lblDia6";
            this.lblDia6.Size = new System.Drawing.Size(28, 20);
            this.lblDia6.TabIndex = 99;
            this.lblDia6.Text = "Vi";
            this.lblDia6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia5
            // 
            this.lblDia5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia5.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia5.Location = new System.Drawing.Point(136, 36);
            this.lblDia5.Name = "lblDia5";
            this.lblDia5.Size = new System.Drawing.Size(28, 20);
            this.lblDia5.TabIndex = 98;
            this.lblDia5.Text = "Ju";
            this.lblDia5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia4
            // 
            this.lblDia4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia4.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia4.Location = new System.Drawing.Point(104, 36);
            this.lblDia4.Name = "lblDia4";
            this.lblDia4.Size = new System.Drawing.Size(28, 20);
            this.lblDia4.TabIndex = 97;
            this.lblDia4.Text = "Mi";
            this.lblDia4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia3
            // 
            this.lblDia3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia3.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia3.Location = new System.Drawing.Point(72, 36);
            this.lblDia3.Name = "lblDia3";
            this.lblDia3.Size = new System.Drawing.Size(28, 20);
            this.lblDia3.TabIndex = 96;
            this.lblDia3.Text = "Ma";
            this.lblDia3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia2
            // 
            this.lblDia2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia2.Location = new System.Drawing.Point(40, 36);
            this.lblDia2.Name = "lblDia2";
            this.lblDia2.Size = new System.Drawing.Size(28, 20);
            this.lblDia2.TabIndex = 95;
            this.lblDia2.Text = "Lu";
            this.lblDia2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia1
            // 
            this.lblDia1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia1.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToByte(240), System.Convert.ToByte(236), System.Convert.ToByte(236));
            this.lblDia1.Location = new System.Drawing.Point(8, 36);
            this.lblDia1.Name = "lblDia1";
            this.lblDia1.Size = new System.Drawing.Size(28, 20);
            this.lblDia1.TabIndex = 94;
            this.lblDia1.Text = "Do";
            this.lblDia1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctFondo
            // 
            this.pctFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pctFondo.Location = new System.Drawing.Point(4, 4);
            this.pctFondo.Name = "pctFondo";
            this.pctFondo.Size = new System.Drawing.Size(228, 204);
            this.pctFondo.TabIndex = 102;
            this.pctFondo.TabStop = false;
            // 
            // Calendar
            // 
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia7);
            this.Controls.Add(this.lblDia6);
            this.Controls.Add(this.lblDia5);
            this.Controls.Add(this.lblDia4);
            this.Controls.Add(this.lblDia3);
            this.Controls.Add(this.lblDia2);
            this.Controls.Add(this.lblDia1);
            this.Controls.Add(this.pctFondo);
            this.DockPadding.All = 2;
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(236, 212);
            this.Controls.SetChildIndex(this.pctFondo, 0);
            this.Controls.SetChildIndex(this.lblDia1, 0);
            this.Controls.SetChildIndex(this.lblDia2, 0);
            this.Controls.SetChildIndex(this.lblDia3, 0);
            this.Controls.SetChildIndex(this.lblDia4, 0);
            this.Controls.SetChildIndex(this.lblDia5, 0);
            this.Controls.SetChildIndex(this.lblDia6, 0);
            this.Controls.SetChildIndex(this.lblDia7, 0);
            this.Controls.SetChildIndex(this.lblMes, 0);
            this.ResumeLayout(false);

            base.GotFocus += new System.EventHandler(Calendar_GotFocus);
            base.LostFocus += new System.EventHandler(Calendar_LostFocus);
            base.Resize += new System.EventHandler(Calendar_Resize);
            base.KeyDown += new System.Windows.Forms.KeyEventHandler(Calendar_KeyDown);
        }


        #endregion

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
                if(m_MultiSelect == false && m_SelectedDates.Count > 0)
                    m_SelectedDates = new System.Collections.ArrayList();
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

        [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedDates
        {
            get
            {
                int i = 0;

                //Convierto en array de DateTimes
                System.DateTime[] SelectedDates = new System.DateTime[m_SelectedDates.Count];
                foreach(System.DateTime Fecha in m_SelectedDates)
                {
                    SelectedDates[i++] = Fecha;
                }

                //Ordeno
                Array.Sort(SelectedDates);

                //Convierto en string
                System.Text.StringBuilder SelectedDatesString = new System.Text.StringBuilder();
                for(i = 0; i <= SelectedDates.GetUpperBound(0); i++)
                {
                    if(SelectedDatesString.Length != 0)
                        SelectedDatesString.Append(",");
                    SelectedDatesString.Append(SelectedDates[i].ToString(m_DateFormat, System.Globalization.CultureInfo.InvariantCulture));
                }

                return SelectedDatesString.ToString();
            }
            set
            {
                m_SelectedDates = new System.Collections.ArrayList();
                if(value == null || value.Length == 0)
                {
                    //Nada
                }
                else
                {
                    string[] SelectedDatesString = value.Split(',');
                    for(int i = 0; i <= SelectedDatesString.GetUpperBound(0); i++)
                    {
                        m_SelectedDates.Add(DateTime.ParseExact(SelectedDatesString[i], m_DateFormat, System.Globalization.CultureInfo.InvariantCulture));
                    }
                }

				this.MostrarCalendario();

				if(SelectedDatesChanged != null)
					SelectedDatesChanged(this, null);
            }
        }

        [System.ComponentModel.Browsable(true)]
        public DateTime CurrentDate
        {
            get
            {
                return m_CurrentDate;
            }
            set
            {
                m_CurrentDate = new DateTime(value.Year, value.Month, value.Day);
                if(m_MultiSelect == false)
                    this.SelectedDates = m_CurrentDate.ToString(m_DateFormat, System.Globalization.CultureInfo.InvariantCulture);
                if(null != CurrentDateChanged) CurrentDateChanged(this, null);
                MostrarCalendario();
            }
        }

        private void Calendar_GotFocus(object sender, System.EventArgs e)
        {
            pctFondo.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataareaActive;
        }


        private void Calendar_LostFocus(object sender, System.EventArgs e)
        {
            pctFondo.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
        }


        private void MostrarCalendario()
        {
            Label lblDia = null;
            int DiasDelMes = DateTime.DaysInMonth(m_CurrentDate.Year, m_CurrentDate.Month);

            this.SuspendLayout();

            lblMes.Text = m_CurrentDate.ToString(@"MMMM ""de"" yyyy");

            int PrimerDia = System.Convert.ToInt32(DateTime.ParseExact(m_CurrentDate.ToString("MM/01/yyyy", System.Globalization.CultureInfo.InvariantCulture), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture).DayOfWeek);

            for(int i = 0; i <= PrimerDia - 1; i++)
            {
                lblDia = ((Label)(Dias[i]));
                lblDia.Enabled = false;
                lblDia.Visible = false;
                lblDia.Text = "?";
                lblDia.Tag = 0;
            }

            for(int i = 1; i <= DiasDelMes; i++)
            {
                lblDia = ((Label)(Dias[PrimerDia + i - 1]));
                lblDia.Text = i.ToString();
                lblDia.ForeColor = System.Drawing.SystemColors.ControlText;

                if(IsSelected(new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, i)))
                {
                    lblDia.BackColor = Lws.Config.Display.CurrentTemplate.Selection;
                    lblDia.ForeColor = Lws.Config.Display.CurrentTemplate.SelectionText;
                }
                else
                {
                    lblDia.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                    lblDia.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                }

                if(m_ShowFocusRect && i == m_CurrentDate.Day)
                    lblDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                else
                    lblDia.BorderStyle = System.Windows.Forms.BorderStyle.None;

				lblDia.Visible = true;
                lblDia.Enabled = true;
                lblDia.Tag = i;
            }

            for(int i = 0; i <= 42 - DiasDelMes - PrimerDia - 1; i++)
            {
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
            if(Dias.Count > 0)
            {
                this.SuspendLayout();
                Label lblDia = null;
                for(int s = 1; s <= 6; s++)
                {
                    for(int d = 1; d <= 7; d++)
                    {
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
			if(null != DoubleClick) DoubleClick(this, null);	
		}

        private void lblDia_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
			if(this.Focused == false) 
				this.Focus();
            int Dia = (int)((Label)sender).Tag;
            if(Dia > 0)
            {
                this.CurrentDate = new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, Dia);
                if(m_MultiSelect)
                    InvertSelectedState(m_CurrentDate);
                else
                    this.SelectedDates = this.CurrentDate.ToString(m_DateFormat, System.Globalization.CultureInfo.InvariantCulture);
                MostrarCalendario();
            }
        }

        private void Calendar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
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
                    if(m_MultiSelect)
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
            if(IsSelected(fecha))
                SelectionRem(fecha);
            else
                SelectionAdd(fecha);

            if(SelectedDatesChanged != null)
				SelectedDatesChanged(this, null);
        }


        public void SetSelectedState(DateTime Fecha, bool Selected)
        {
            // Marca a desmarca un da (independientemente de su estado actual, a diferencia de InvertSelectedState)
            if(Selected == false && IsSelected(Fecha))
                SelectionRem(Fecha);
            else if(Selected && IsSelected(Fecha) == false)
                SelectionAdd(Fecha);
            
			if(null != SelectedDatesChanged)
				SelectedDatesChanged(this, null);
        }


        private void SelectionAdd(System.DateTime fecha)
        {
            m_SelectedDates.Add(fecha);
        }

        private void SelectionRem(System.DateTime fecha)
        {
            foreach(DateTime FechaSeleccionada in m_SelectedDates)
            {
                if(FechaSeleccionada == fecha)
                {
                    m_SelectedDates.Remove(FechaSeleccionada);
                    break;
                }
            }
        }


        public bool IsSelected(System.DateTime fechaABuscar)
        {
            foreach(System.DateTime Fecha in m_SelectedDates)
            {
                if(Fecha == fechaABuscar)
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
            for(i = 1; i <= 7; i++)
            {
                SetSelectedState(PrimerDiaSemana.AddDays(i - 1), bNuevoEstado);
            }

            MostrarCalendario();
        }

        public void InvertSelectedMonth()
        {
            int iDiasDelMes = DateTime.DaysInMonth(m_CurrentDate.Year, m_CurrentDate.Month);
            bool bNuevoEstado = !IsSelected(new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, 1));

            for(int i = 1; i <= iDiasDelMes; i++)
            {
                SetSelectedState(new DateTime(m_CurrentDate.Year, m_CurrentDate.Month, i), bNuevoEstado);
            }
            MostrarCalendario();
        }

    }

}
