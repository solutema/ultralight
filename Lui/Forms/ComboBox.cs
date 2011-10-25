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
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lui.Forms
{
        [System.ComponentModel.DefaultEvent("TextChanged")]
        public partial class ComboBox : TextBoxBase
        {
                private string[] m_SetData = new string[] { "" };
                private string[] m_SetDataText = { "" };
                private string[] m_SetDataKey = { "" };
                private int m_SetIndex; private string m_TextKey;
                //private string m_Table = null, m_KeyField = null, m_DetailField = null, m_Filter = null;
                private bool m_AlwaysExpanded = false;

                public ComboBox()
                {
                        InitializeComponent();

                        this.BorderStyle = BorderStyles.TextBox;
                        this.BackColor = TextBox1.BackColor;
                        TextBox1.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        TextBox1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                        this.TextBox1.DoubleClick += new System.EventHandler(this.TextBox1_DoubleClick);
                        this.TextBox1.LostFocus += new System.EventHandler(this.TextBox1_LostFocus);
                        this.TextBox1.GotFocus += new System.EventHandler(this.TextBox1_GotFocus);
                        TextBox1.Multiline = false;                        
                }

                [System.ComponentModel.Category("Comportamiento")]
                public string[] SetData
                {
                        get
                        {
                                return m_SetData;
                        }
                        set
                        {
                                m_SetData = value;

                                if (m_SetData == null) {
                                        m_SetIndex = -1;
                                } else {
                                        int TamanoSet = m_SetData.Length;
                                        m_SetDataText = new string[TamanoSet];
                                        m_SetDataKey = new string[TamanoSet];

                                        for (int i = 0; i < TamanoSet; i++) {
                                                string sItem = m_SetData[i];
                                                m_SetDataText[i] = Lfx.Types.Strings.GetNextToken(ref sItem, "|");
                                                m_SetDataKey[i] = sItem;
                                        }

                                        if (this.TextRaw.Length == 0 && m_SetData.Length >= 1)
                                                this.TextRaw = m_SetData[0];

                                        DetectarSetIndex();
                                }
                        }
                }

                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return base.TemporaryReadOnly;
                        }
                        set
                        {
                                base.TemporaryReadOnly = value;
                                TextBox1.ReadOnly = true;
                                ItemList.Enabled = !(value || this.ReadOnly);
                        }
                }

                public override bool ReadOnly
                {
                        get
                        {
                                return base.ReadOnly;
                        }
                        set
                        {
                                base.ReadOnly = value;
                                TextBox1.ReadOnly = true;
                                ItemList.Enabled = !(value || this.TemporaryReadOnly);
                        }
                }

                public bool AlwaysExpanded
                {
                        get
                        {
                                return m_AlwaysExpanded;
                        }
                        set
                        {
                                m_AlwaysExpanded = value;
                                if (this.AutoSize) {
                                        if (m_AlwaysExpanded)
                                                this.ItemList.Visible = true;
                                        else if (this.ContainsFocus == false)
                                                this.ItemList.Visible = false;
                                }
                        }
                }

                new public bool AutoSize
                {
                        get
                        {
                                return base.AutoSize;
                        }
                        set
                        {
                                base.AutoSize = value;
                                if (this.AutoSize) {
                                        if (m_AlwaysExpanded)
                                                this.ItemList.Visible = true;
                                        else if (this.ContainsFocus == false)
                                                this.ItemList.Visible = false;
                                }
                        }
                }

                [System.ComponentModel.Category("Apariencia"), RefreshProperties(RefreshProperties.Repaint)]
                public string TextKey
                {
                        get
                        {
                                if (m_SetIndex >= 0 && m_SetDataKey.Length >= (m_SetIndex + 1))
                                        return m_SetDataKey[m_SetIndex];
                                else
                                        return "";
                        }
                        set
                        {
                                bool EraIgual = m_TextKey == value;
                                m_TextKey = value;
                                DetectarSetIndex();
                                if (EraIgual == false)
                                        this.OnTextChanged(EventArgs.Empty);
                        }
                }

                private void DetectarSetIndex()
                {
                        // Detecta el SetIndex que le corresponde al TextKey actual
                        if (m_SetData != null && m_SetDataKey.GetLength(0) > 0) {
                                m_SetIndex = -1;
                                for (int i = 0; i <= m_SetDataKey.GetUpperBound(0); i++) {
                                        if (m_SetDataKey[i] == m_TextKey) {
                                                m_SetIndex = i;
                                                m_IgnoreChanges++;
                                                this.TextRaw = m_SetDataText[m_SetIndex];
                                                m_IgnoreChanges--;
                                                break;
                                        }
                                }

                                for (int i = m_SetDataText.GetLowerBound(0); i <= m_SetDataText.GetUpperBound(0); i++) {
                                        if (m_SetData[i] == this.Text) {
                                                if (ItemList.Items.Count >= (i + 1))
                                                        ItemList.SelectedIndex = i;
                                        }
                                }
                        }
                }


                private void ImagenMasMenos_Click(object sender, System.EventArgs e)
                {
                        if (this.TemporaryReadOnly == false && this.ReadOnly == false)
                                SetNextValueInSet();
                        if (this.Focused == false)
                                TextBox1.Focus();
                }


                private void ImagenMasMenos_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.TemporaryReadOnly == false && this.ReadOnly == false)
                                SetNextValueInSet();
                        if (this.Focused == false)
                                TextBox1.Focus();
                }

                public void SetNextValueInSet()
                {
                        if (m_SetData != null && m_SetData.Length > 0) {
                                if (m_SetIndex == -1)
                                        m_SetIndex = 0;

                                this.TextRaw = NextValueInSet();
                                this.TextKey = m_SetDataKey[m_SetIndex];

                                if (ItemList.Visible)
                                        ItemList.SelectedItem = this.TextRaw;

                                if (PopUps.ODataSetHelp != null) {
                                        if (this.TextKey.Length == 0)
                                                PopUps.ODataSetHelp.TextKey = this.Text;
                                        else
                                                PopUps.ODataSetHelp.TextKey = this.TextKey;
                                }
                        }
                }

                private string NextValueInSet()
                {
                        string nextValueInSetReturn = null;
                        if (m_SetIndex >= m_SetData.Length - 1)
                                m_SetIndex = 0;
                        else
                                m_SetIndex++;
                        nextValueInSetReturn = m_SetDataText[m_SetIndex];
                        return nextValueInSetReturn;
                }


                public void SetPrevValueInSet()
                {
                        if (m_SetData != null && m_SetData.Length > 0) {
                                if (m_SetIndex == -1)
                                        m_SetIndex = m_SetDataKey.GetUpperBound(0);

                                this.TextRaw = PrevValueInSet();
                                this.TextKey = m_SetDataKey[m_SetIndex];

                                if (ItemList.Visible)
                                        ItemList.SelectedItem = this.TextRaw;

                                if (PopUps.ODataSetHelp != null) {
                                        if (this.TextKey.Length == 0)
                                                PopUps.ODataSetHelp.TextKey = this.Text;
                                        else
                                                PopUps.ODataSetHelp.TextKey = this.TextKey;
                                }
                        }
                }

                private string PrevValueInSet()
                {
                        string prevValueInSetReturn = null;
                        if (m_SetIndex <= 0)
                                m_SetIndex = m_SetData.Length;
                        else
                                m_SetIndex--;
                        prevValueInSetReturn = m_SetDataText[m_SetIndex];
                        return prevValueInSetReturn;
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public override System.String Text
                {
                        get
                        {
                                return base.Text;
                        }
                        set
                        {
                                base.Text = value;
                                for (int i = 0; i <= m_SetDataText.GetUpperBound(0); i++) {
                                        if (this.TextRaw == m_SetDataText[i]) {
                                                if (this.TextKey != m_SetDataKey[i])
                                                        this.TextKey = m_SetDataKey[i];
                                                break;
                                        }
                                }
                        }
                }

                private void TextBox1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.TemporaryReadOnly == false && this.ReadOnly == false)
                                SetNextValueInSet();
                }

                private void TextBox1_LostFocus(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos == 0) {
                                if (PopUps.ODataSetHelp != null)
                                        PopUps.ODataSetHelp.Ocultar();
                        }
                }

                private void TextBox1_GotFocus(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos == 0 && this.TemporaryReadOnly == false && this.ReadOnly == false) {
                                IgnorarEventos++;
                                if (this.AutoSize == false && this.AlwaysExpanded == false) {
                                        if (PopUps.ODataSetHelp == null && Lfx.Environment.SystemInformation.RunTime == Lfx.Environment.SystemInformation.RunTimes.DotNet)
                                                PopUps.ODataSetHelp = new DataSetHelp();
                                        if (PopUps.ODataSetHelp != null && this.TemporaryReadOnly == false && this.ReadOnly == false) {
                                                string[] Aja = new string[this.SetData.Length];
                                                this.SetData.CopyTo(Aja, 0);
                                                PopUps.ODataSetHelp.SetData = Aja;
                                                PopUps.ODataSetHelp.TextKey = this.TextKey;
                                                PopUps.ODataSetHelp.Mostrar(this);
                                                this.TextBox1.Focus();
                                        }
                                }
                                IgnorarEventos--;
                        }
                }


                private void ComboBox_Enter(object sender, EventArgs e)
                {
                        if (this.AutoSize || this.AlwaysExpanded)
                                ItemList.Visible = true;

                        if (ItemList.Visible && this.ActiveControl != ItemList) {
                                ItemList.Select();
                        } else if (TextBox1.Visible && this.ActiveControl != TextBox1) {
                                TextBox1.Select();
                        }
                }

                private void ComboBox_Leave(object sender, EventArgs e)
                {
                        if (ItemList.Visible && m_AlwaysExpanded == false && this.AutoSize == true)
                                ItemList.Visible = false;
                }

                private void ComboBox_SizeChanged(object sender, EventArgs e)
                {
                        TextBox1.Location = new System.Drawing.Point(4, 4);
                        TextBox1.Width = this.Width - TextBox1.Left * 2 - ImagenMasMenos.Width;
                        TextBox1.Height = this.Height - TextBox1.Top * 2;
                        ImagenMasMenos.Height = TextBox1.Height;
                        ItemList.Width = this.Width - ItemList.Left * 2;
                }

                private void ItemList_VisibleChanged(object sender, EventArgs e)
                {
                        TextBox1.Visible = !ItemList.Visible;
                        ImagenMasMenos.Visible = TextBox1.Visible;
                        if (ItemList.Visible) {
                                if (m_SetDataText != null && ItemList.Items.Count != m_SetDataText.Length) {
                                        ItemList.Items.Clear();
                                        for (int i = m_SetDataText.GetLowerBound(0); i <= m_SetDataText.GetUpperBound(0); i++) {
                                                if (m_SetDataText[i] != null)
                                                        ItemList.Items.Add(m_SetDataText[i]);
                                                if (m_SetDataText[i] == this.Text)
                                                        ItemList.SelectedIndex = ItemList.Items.Count - 1;
                                        }
                                }

                                ItemList.Location = new System.Drawing.Point(3, 3);
                                if (this.AutoSize) {
                                        // Manejo el tamaño del control de acuerdo a la lista
                                        if (m_SetDataText.Length > 5)
                                                ItemList.Height = ItemList.ItemHeight * 5;
                                        else
                                                ItemList.Height = ItemList.ItemHeight * m_SetDataText.Length;
                                        this.Height = ItemList.Top + ItemList.Height + ItemList.Margin.Top + ItemList.Margin.Bottom;
                                } else {
                                        // Manejo el tamaño de la lista de acuerdo al control
                                        ItemList.Height = this.ClientRectangle.Height - ItemList.Top - ItemList.Margin.Top + ItemList.Margin.Bottom;
                                }
                                if (this.ActiveControl != ItemList)
                                        ItemList.Select();

                                if (ItemList.SelectedIndex < ItemList.TopIndex)
                                        ItemList.TopIndex = ItemList.SelectedIndex;
                                else if (ItemList.SelectedIndex >= ItemList.TopIndex + (ItemList.Height / ItemList.ItemHeight))
                                        ItemList.TopIndex = ItemList.SelectedIndex;
                        } else {
                                this.Height = TextBox1.Top + TextBox1.Height + TextBox1.Margin.Top + TextBox1.Margin.Bottom;
                        }
                }

                protected override void OnSizeChanged(EventArgs e)
                {
                        if (ItemList != null && this.AutoSize == false) {
                                ItemList.Height = this.ClientRectangle.Height - ItemList.Top - ItemList.Margin.Top + ItemList.Margin.Bottom;
                        }
                        base.OnSizeChanged(e);
                }

                protected override void OnKeyDown(KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Up:
                                        if (e.Shift == false && e.Alt == false && e.Control == false) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                        }
                                        break;
                                case Keys.Down:
                                        if (e.Shift == false && e.Alt == false && e.Control == false) {
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        }
                                        break;
                        }

                        base.OnKeyDown(e);
                }

                private void ItemList_KeyDown(object sender, KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Subtract:
                                        e.Handled = true;
                                        if (this.TemporaryReadOnly == false && this.ReadOnly == false) {
                                                this.SetPrevValueInSet();
                                        }
                                        break;
                                case Keys.Add:
                                case Keys.Space:
                                        e.Handled = true;
                                        if (this.TemporaryReadOnly == false && this.ReadOnly == false) {
                                                this.SetNextValueInSet();
                                        }
                                        break;
                                case Keys.Return:
                                        e.Handled = true;
                                        if (m_AutoNav & ItemList.Visible && e.Shift == false && e.Alt == false && e.Control == false) {
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                        }
                                        break;
                                default:
                                        if (sender == ItemList)
                                                base.TextBox1_KeyDown(sender, e);
                                        break;
                        }
                }

                private void ItemList_SelectedValueChanged(object sender, EventArgs e)
                {
                        if (ItemList.SelectedItem != null) {
                                string Buscar = ItemList.SelectedItem.ToString();
                                for(int i = 0; i < m_SetDataText.Length; i++) {
                                        if(m_SetDataText[i] == Buscar) {
                                                this.TextKey = m_SetDataKey[i];
                                        }
                                }

                                if (ItemList.SelectedIndex < ItemList.TopIndex)
                                        ItemList.TopIndex = ItemList.SelectedIndex;
                                else if (ItemList.SelectedIndex >= ItemList.TopIndex + (ItemList.Height / ItemList.ItemHeight))
                                        ItemList.TopIndex = ItemList.SelectedIndex;
                        }
                }
        }
}
