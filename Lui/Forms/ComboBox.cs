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
                private string[] m_SetData = { "" };
                private string[] m_SetDataText = { "" };
                private string[] m_SetDataKey = { "" };
                private int m_SetIndex; private string m_TextKey;
                private string m_Table = null, m_KeyField = null, m_DetailField = null, m_Filter = null;

                [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
                new public event System.EventHandler TextChanged;

                public ComboBox()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
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

                                        if (TextBox1.Text.Length == 0 && m_SetData.Length >= 1)
                                                TextBox1.Text = m_SetData[0];

                                        DetectarSetIndex();
                                }
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
                                ItemList.Enabled = !value;
                        }
                }

                [System.ComponentModel.Category("Apariencia"), RefreshProperties(RefreshProperties.Repaint)]
                public string TextKey
                {
                        get
                        {
                                if (m_SetIndex >= 0)
                                        return m_SetDataKey[m_SetIndex];
                                else
                                        return "";
                        }
                        set
                        {
                                bool EraIgual = m_TextKey == value;
                                m_TextKey = value;
                                DetectarSetIndex();
                                if (EraIgual == false && this.TextChanged != null)
                                        this.TextChanged(this, null);
                        }
                }

                private void DetectarSetIndex()
                {
                        // Detecta el SetIndex que le corresponde al TextKey actual
                        if (m_SetDataKey.GetLength(0) > 0) {
                                m_SetIndex = -1;
                                for (int i = 0; i <= m_SetDataKey.GetUpperBound(0); i++) {
                                        if (m_SetDataKey[i] == m_TextKey) {
                                                m_SetIndex = i;
                                                m_IgnoreChanges++;
                                                TextBox1.Text = m_SetDataText[m_SetIndex];
                                                m_IgnoreChanges--;
                                                break;
                                        }
                                }
                        }
                }

                private void ImagenMasMenos_Click(object sender, System.EventArgs e)
                {
                        if (this.ReadOnly == false)
                                SetNextValueInSet();
                        if (this.Focused == false)
                                TextBox1.Focus();
                }


                private void ImagenMasMenos_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.ReadOnly == false)
                                SetNextValueInSet();
                        if (this.Focused == false)
                                TextBox1.Focus();
                }

                public void SetNextValueInSet()
                {
                        if (m_SetData != null) {
                                if (m_SetIndex == -1)
                                        m_SetIndex = 0;

                                TextBox1.Text = NextValueInSet();
                                this.TextKey = m_SetDataKey[m_SetIndex];

                                if (ItemList.Visible)
                                        ItemList.SelectedItem = TextBox1.Text;

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
                        if (m_SetIndex >= m_SetData.GetUpperBound(0))
                                m_SetIndex = 0;
                        else
                                m_SetIndex++;
                        nextValueInSetReturn = m_SetDataText[m_SetIndex];
                        return nextValueInSetReturn;
                }


                public void SetPrevValueInSet()
                {
                        if (m_SetData != null) {
                                if (m_SetIndex == -1)
                                        m_SetIndex = m_SetDataKey.GetUpperBound(0);

                                TextBox1.Text = PrevValueInSet();
                                this.TextKey = m_SetDataKey[m_SetIndex];

                                if (ItemList.Visible)
                                        ItemList.SelectedItem = TextBox1.Text;

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
                                m_SetIndex = m_SetData.GetUpperBound(0);
                        else
                                m_SetIndex--;
                        prevValueInSetReturn = m_SetDataText[m_SetIndex];
                        return prevValueInSetReturn;
                }

                /* private void ComboBox_LocationChanged(object sender, System.EventArgs e)
                {
                        if (PopUps.ODataSetHelp != null)
                                PopUps.ODataSetHelp.Ocultar();
                } */

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
                                                this.TextKey = m_SetDataKey[i];
                                                break;
                                        }
                                }
                        }
                }

                private void TextBox1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (this.ReadOnly == false)
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
                        if (IgnorarEventos == 0 && this.ReadOnly == false) {
                                IgnorarEventos++;
                                if (this.AutoHeight == false) {
                                        if (PopUps.ODataSetHelp == null && Lfx.Environment.SystemInformation.RunTime == Lfx.Environment.SystemInformation.RunTimes.DotNet)
                                                PopUps.ODataSetHelp = new DataSetHelp();
                                        if (PopUps.ODataSetHelp != null && this.ReadOnly == false) {
                                                PopUps.ODataSetHelp.SetData = this.SetData;
                                                PopUps.ODataSetHelp.TextKey = this.TextKey;
                                                PopUps.ODataSetHelp.Mostrar(this);
                                                this.TextBox1.Focus();
                                        }
                                }
                                IgnorarEventos--;
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string Table
                {
                        get
                        {
                                return m_Table;
                        }
                        set
                        {
                                m_Table = value;
                                UpdateDetail();
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string KeyField
                {
                        get
                        {
                                return m_KeyField;
                        }
                        set
                        {
                                m_KeyField = value;
                                UpdateDetail();
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string DetailField
                {
                        get
                        {
                                return m_DetailField;
                        }
                        set
                        {
                                m_DetailField = value;
                                UpdateDetail();
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string Filter
                {
                        get
                        {
                                return m_Filter;
                        }
                        set
                        {
                                m_Filter = value;
                                UpdateDetail();
                        }
                }


                private void UpdateDetail()
                {
                        if (m_Table != null && m_Table.Length > 0 && m_KeyField != null && m_KeyField.Length > 0 && m_DetailField != null && m_DetailField.Length > 0 && this.Workspace != null && this.DataBase != null) {
                                if (this.DataBase.IsOpen()) {
                                        string TextoSql = null;
                                        if (m_Table.Length >= 7 && m_Table.Substring(0, 7) == "SELECT ") {
                                                TextoSql = m_Table;
                                        } else {
                                                TextoSql = "SELECT " + m_KeyField + "," + m_DetailField + " FROM " + m_Table;
                                                if (m_Filter != null && m_Filter.Length > 0)
                                                        TextoSql += " WHERE " + m_Filter;
                                        }
                                        System.Data.DataTable m_DataTable = this.DataBase.Select(TextoSql);
                                        if (m_DataTable != null) {
                                                string[] Resultado = new string[m_DataTable.Rows.Count];
                                                int i = 0;
                                                foreach (System.Data.DataRow tmpRow in m_DataTable.Rows) {
                                                        try {
                                                                Resultado[i] = System.Convert.ToString(tmpRow[1]) + "|" + System.Convert.ToString(tmpRow[0]);
                                                        }
                                                        catch {
                                                                System.Windows.Forms.MessageBox.Show("Error DetailBox.UpdateDetail " + tmpRow[1].GetType().ToString() + " / " + tmpRow[0].GetType().ToString() + "	- " + m_Table + "/" + m_KeyField + "/" + m_DetailField);
                                                        }
                                                        i++;
                                                }
                                                this.SetData = Resultado;
                                        }
                                } else {
                                        TextBox1.Text = "(this.DataBase is closed)";
                                }
                        }
                }

                private void ComboBox_Enter(object sender, EventArgs e)
                {
                        if (this.AutoHeight)
                                ItemList.Visible = true;
                        else if (this.ActiveControl != TextBox1)
                                TextBox1.Select();
                }

                private void ComboBox_Leave(object sender, EventArgs e)
                {
                        if (ItemList.Visible)
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

                private int Previous_Height;
                private void ItemList_VisibleChanged(object sender, EventArgs e)
                {
                        TextBox1.Visible = !ItemList.Visible;
                        ImagenMasMenos.Visible = TextBox1.Visible;
                        if (ItemList.Visible) {
                                ItemList.Items.Clear();
                                for (int i = m_SetDataText.GetLowerBound(0); i <= m_SetDataText.GetUpperBound(0); i++) {
                                        if (m_SetDataText[i] != null)
                                                ItemList.Items.Add(m_SetDataText[i]);
                                        if (m_SetDataText[i] == this.Text)
                                                ItemList.SelectedIndex = ItemList.Items.Count - 1;
                                }

                                Previous_Height = this.Height;
                                ItemList.Location = new System.Drawing.Point(3, 3);
                                if (m_SetDataText.Length > 5)
                                        ItemList.Height = ItemList.ItemHeight * 5;
                                else
                                        ItemList.Height = ItemList.ItemHeight * m_SetDataText.Length;
                                this.Height = ItemList.Height + ItemList.Top * 2;
                                ItemList.Select();

                                if (ItemList.SelectedIndex < ItemList.TopIndex)
                                        ItemList.TopIndex = ItemList.SelectedIndex;
                                else if (ItemList.SelectedIndex >= ItemList.TopIndex + (ItemList.Height / ItemList.ItemHeight))
                                        ItemList.TopIndex = ItemList.SelectedIndex;
                        } else {
                                this.Height = Previous_Height;
                        }
                }

                private void ItemList_KeyDown(object sender, KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Subtract:
                                        if (this.ReadOnly == false) {
                                                e.Handled = true;
                                                this.SetPrevValueInSet();
                                        }
                                        break;
                                case Keys.Add:
                                case Keys.Space:
                                        if (this.ReadOnly == false) {
                                                e.Handled = true;
                                                this.SetNextValueInSet();
                                        }
                                        break;
                                case Keys.Return:
                                        if (m_AutoNav & ItemList.Visible && e.Shift == false && e.Alt == false && e.Control == false) {
                                                e.Handled = true;
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
