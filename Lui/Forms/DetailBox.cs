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
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class DetailBox : Lui.Forms.Control
        {
                private bool m_SelectOnFocus = true;
                private bool m_AutoTab = true;
                private bool m_AutoUpdate = true;
                private bool m_Required = true;
                private string m_TipWhenBlank = "";
                private int m_ItemId;
                private string m_FreeTextCode = "";
                private string m_LastText1;
                private string m_TeclaDespuesDeEnter = "{tab}";
                private string m_Table = "";
                private string m_KeyField = "";
                private string m_DetailField = "";
                private string m_ExtraDetailFields = "";
                private string m_Filter = "";
                private bool m_CanCreate = true;
                private int RowMisses = 0;

                private Lfx.Data.Row CurrentRow = null;

                [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
                public new event System.EventHandler TextChanged;
                public new event System.Windows.Forms.KeyEventHandler KeyDown;

                public DetailBox()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        Label1.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        TextBox1.BackColor = Label1.BackColor;
                        EntradaFreeText.BackColor = Label1.BackColor;
                        Label1.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                        TextBox1.ForeColor = Label1.ForeColor;
                        EntradaFreeText.ForeColor = Label1.ForeColor;
                        this.BorderStyle = BorderStyles.TextBox;

                        UpdateDetail();
                }

                public int TextInt
                {
                        get
                        {
                                return m_ItemId;
                        }
                        set
                        {
                                this.Text = value.ToString();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool AutoUpdate
                {
                        get
                        {
                                return m_AutoUpdate;
                        }
                        set
                        {
                                m_AutoUpdate = value;
                        }
                }

                public string TipWhenBlank
                {
                        get
                        {
                                return m_TipWhenBlank;
                        }
                        set
                        {
                                m_TipWhenBlank = value;
                        }
                }

                public string TeclaDespuesDeEnter
                {
                        get
                        {
                                return m_TeclaDespuesDeEnter;
                        }
                        set
                        {
                                m_TeclaDespuesDeEnter = value;
                        }
                }

                public int MaxLength
                {
                        get
                        {
                                return EntradaFreeText.MaxLength;
                        }
                        set
                        {
                                EntradaFreeText.MaxLength = value;
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string FreeTextCode
                {
                        get
                        {
                                return m_FreeTextCode;
                        }
                        set
                        {
                                m_FreeTextCode = value;
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public bool CanCreate
                {
                        get
                        {
                                return m_CanCreate;
                        }
                        set
                        {
                                m_CanCreate = value;
                        }
                }

                public override bool ReadOnly
                {
                        get
                        {
                                return TextBox1.ReadOnly;
                        }
                        set
                        {
                                base.ReadOnly = value;
                                TextBox1.ReadOnly = value;
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
                                if (m_Table == "articulos")
                                        TextBox1.Width = 96;
                                else
                                        TextBox1.Width = 50;
                                ReubicarDetalle();
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
                public string ExtraDetailFields
                {
                        get
                        {
                                return m_ExtraDetailFields;
                        }
                        set
                        {
                                m_ExtraDetailFields = value;
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

                [System.ComponentModel.Category("Comportamiento")]
                public bool SelectOnFocus
                {
                        get
                        {
                                return m_SelectOnFocus;
                        }
                        set
                        {
                                m_SelectOnFocus = value;
                        }
                }

                [System.ComponentModel.Category("Comportamiento")]
                public bool AutoTab
                {
                        get
                        {
                                return m_AutoTab;
                        }
                        set
                        {
                                m_AutoTab = value;
                        }
                }

                [System.ComponentModel.Category("Comportamiento")]
                public bool Required
                {
                        get
                        {
                                return m_Required;
                        }
                        set
                        {
                                m_Required = value;
                        }
                }

                [System.ComponentModel.Category("Apariencia")]
                public override System.String Text
                {
                        get
                        {
                                if (m_FreeTextCode.Length > 0 && TextBox1.Text == m_FreeTextCode)
                                        return TextBox1.Text;
                                else if (Label1.Text == "???")
                                        return "";
                                else
                                        return m_ItemId.ToString();
                        }
                        set
                        {
                                if (value == "0")
                                        TextBox1.Text = "";
                                else
                                        TextBox1.Text = value;

                                if (m_AutoUpdate)
                                        this.UpdateDetail();

                                this.Changed = false;
                        }
                }

                [System.ComponentModel.Category("Apariencia")]
                public System.String TextDetail
                {
                        get
                        {
                                if (TextBox1.Text == m_FreeTextCode)
                                        return EntradaFreeText.Text;
                                else if (Label1.Text == "???")
                                        return "";
                                else
                                        return Label1.Text;
                        }
                        set
                        {
                                if (TextBox1.Text == m_FreeTextCode)
                                        EntradaFreeText.Text = value;
                                else
                                        Label1.Text = value;
                                this.Changed = false;
                        }
                }

                private void TextBox1_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        if (e == null) {
                                // Nada
                        } else if (@"ABCDEFGHIJKLMNOPQRSTUVWXYZ """.IndexOf(char.ToUpper(e.KeyChar)) != -1 && !TextBox1.ReadOnly) {
                                MostrarBuscador(e.KeyChar.ToString());
                                e.Handled = true;
                        } else if (System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0] == System.Convert.ToByte(Keys.Return)) {
                                e.Handled = true;
                        } else if (("0123456789-" + m_FreeTextCode + (char)Keys.Back).IndexOf(e.KeyChar) == -1) {
                                e.Handled = true;
                        }
                }


                private void MostrarBuscador(string valorIncial)
                {
                        RowMisses = 0;
                        if (Lui.Forms.Statics.DetailBoxQuickSelect == null)
                                Lui.Forms.Statics.DetailBoxQuickSelect = new Lui.Forms.AuxForms.DetailBoxQuickSelect();

                        Lui.Forms.Statics.DetailBoxQuickSelect.Owner = this.ParentForm;
                        Lui.Forms.Statics.DetailBoxQuickSelect.Table = m_Table;
                        Lui.Forms.Statics.DetailBoxQuickSelect.CanCreate = m_CanCreate;
                        Lui.Forms.Statics.DetailBoxQuickSelect.DetailField = m_DetailField;
                        Lui.Forms.Statics.DetailBoxQuickSelect.KeyField = m_KeyField;
                        Lui.Forms.Statics.DetailBoxQuickSelect.Filter = m_Filter;
                        Lui.Forms.Statics.DetailBoxQuickSelect.ExtraDetailFields = m_ExtraDetailFields;
                        Lui.Forms.Statics.DetailBoxQuickSelect.ControlDestino = TextBox1;
                        Lui.Forms.Statics.DetailBoxQuickSelect.Top = System.Convert.ToInt32((this.DisplayRectangle.Top + this.DisplayRectangle.Height / 2) - (Lui.Forms.Statics.DetailBoxQuickSelect.Height / 2));
                        Lui.Forms.Statics.DetailBoxQuickSelect.Left = System.Convert.ToInt32((this.DisplayRectangle.Left + this.DisplayRectangle.Width / 2) - (Lui.Forms.Statics.DetailBoxQuickSelect.Width / 2));
                        Lui.Forms.Statics.DetailBoxQuickSelect.Buscar(valorIncial);
                        if (Lui.Forms.Statics.DetailBoxQuickSelect.DialogResult != DialogResult.Retry) {
                                if (TextBox1.Text.Length > 0)
                                        System.Windows.Forms.SendKeys.Send(m_TeclaDespuesDeEnter);
                        }
                        Lui.Forms.Statics.DetailBoxQuickSelect = null;
                }


                private void TextBox1_GotFocus(System.Object sender, System.EventArgs e)
                {
                        RowMisses = 0;

                        if (m_ReadOnly == false)
                                TextBox1.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataareaActive;
                        if (m_SelectOnFocus)
                                TextBox1.SelectAll();
                }

                private void txtFreeText_GotFocus(object sender, System.EventArgs e)
                {
                        if (m_ReadOnly == false)
                                EntradaFreeText.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataareaActive;
                        EntradaFreeText.SelectionStart = 1024;
                }

                private void TextBox1_LostFocus(System.Object sender, System.EventArgs e)
                {
                        TextBox1.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                }

                private void txtFreeText_LostFocus(object sender, System.EventArgs e)
                {
                        EntradaFreeText.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                }


                private void TextBox1_TextChanged(object sender, System.EventArgs e)
                {
                        if (TextBox1.Text.Length > 13) {
                                if (TextBox1.Font.Size > 7) {
                                        TextBox1.Font = new Font(TextBox1.Font.Name, 7);
                                        if (TextBox1.Width < 128)
                                                TextBox1.Width = 128; ReubicarDetalle();
                                }
                        } else {
                                if (TextBox1.Width > 96) {
                                        TextBox1.Width = 96;
                                        ReubicarDetalle();
                                }

                                if (TextBox1.Text.Length > 11) {
                                        if (TextBox1.Font.Size > 8)
                                                TextBox1.Font = new Font(TextBox1.Font.Name, 8);

                                } else {
                                        if (TextBox1.Font.Size < 10)
                                                TextBox1.Font = new Font(TextBox1.Font.Name, 10);

                                }
                        }
                        UpdateDetail();

                        if (RowMisses > 5)
                                MostrarBuscador(TextBox1.Text);

                        this.Changed = true;
                        if (null != TextChanged) TextChanged(sender, e);
                }


                private void UpdateDetail()
                {
                        if (this.Workspace != null && this.Workspace.DefaultDataView.DataBase != null && this.Workspace.DefaultDataView.DataBase.ConectionState == System.Data.ConnectionState.Open) {
                                //Actualizo sólo si cambió el código
                                string KeyFieldAlt = m_KeyField; // KeyField Alternativo
                                if (m_Table == "articulos" && KeyFieldAlt == "id_articulo")
                                        KeyFieldAlt = this.Workspace.CurrentConfig.Products.DefaultCode();

                                if (TextBox1.Text == m_FreeTextCode && FreeTextCode.Length > 0) {
                                        m_ItemId = 0;
                                        m_LastText1 = "";
                                        EntradaFreeText.Visible = true;
                                        EntradaFreeText.Focus();
                                } else if (m_Table.Length > 0 && KeyFieldAlt.Length > 0 && m_DetailField.Length > 0 && TextBox1.Text.Length > 0 && TextBox1.Text != "0") {
                                        if (TextBox1.Text != m_LastText1) {
                                                EntradaFreeText.Visible = false;
                                                string TextoSql = "", Campos = "";
                                                Campos = KeyFieldAlt + ", " + m_DetailField;
                                                if (m_KeyField != KeyFieldAlt)
                                                        Campos += ", " + m_KeyField;

                                                TextoSql = "SELECT " + Campos + " FROM " + m_Table + " WHERE " + KeyFieldAlt + "='" + this.Workspace.DefaultDataView.DataBase.EscapeString(TextBox1.Text) + "'";
                                                if (m_Filter != null && m_Filter.Length > 0)
                                                        TextoSql += " AND (" + m_Filter + ")";

                                                CurrentRow = this.Workspace.DefaultDataView.DataBase.FirstRowFromSelect(TextoSql);
                                                if (CurrentRow == null && m_KeyField != KeyFieldAlt) {
                                                        TextoSql = "SELECT " + Campos + " FROM " + m_Table + " WHERE " + m_KeyField + "='" + this.Workspace.DefaultDataView.DataBase.EscapeString(TextBox1.Text) + "'";
                                                        if (m_Filter != null && m_Filter.Length > 0)
                                                                TextoSql += " AND (" + m_Filter + ")";
                                                        CurrentRow = this.Workspace.DefaultDataView.DataBase.FirstRowFromSelect(TextoSql);
                                                }
                                                if (CurrentRow == null) {
                                                        m_ItemId = 0;
                                                        m_LastText1 = "";
                                                        Label1.Text = "???";
                                                        Label1.ForeColor = System.Drawing.SystemColors.GrayText;
                                                        RowMisses++;
                                                } else {
                                                        RowMisses = 0;
                                                        m_ItemId = System.Convert.ToInt32(CurrentRow[m_KeyField]);
                                                        m_LastText1 = TextBox1.Text;
                                                        Label1.Text = System.Convert.ToString(CurrentRow[m_DetailField]);
                                                        Label1.ForeColor = System.Drawing.SystemColors.ControlText;
                                                }
                                        }
                                } else {
                                        m_ItemId = 0;
                                        m_LastText1 = "";
                                        Label1.Text = this.TipWhenBlank;
                                        Label1.ForeColor = System.Drawing.SystemColors.GrayText;
                                }
                        } else {
                                m_ItemId = 0;
                                m_LastText1 = "";
                                Label1.Text = "";
                        }
                        if (this.TextInt > 0 && this.Visible)
                                this.Workspace.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", m_Table, this.Text });
                }


                private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.E:
                                        if (this.TextInt > 0 && e.Control && e.Alt == false && e.Shift == false) {
                                                e.Handled = true;
                                                this.Edit();
                                        }
                                        break;
                                case Keys.Down:
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        e.Handled = true;
                                        break;
                                case Keys.Up:
                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                        e.Handled = true;
                                        break;
                                case Keys.Right:
                                        if (EntradaFreeText.Visible) {
                                                e.Handled = true;
                                                EntradaFreeText.Focus();
                                                EntradaFreeText.SelectionStart = 0;
                                        } else {
                                                if (null != KeyDown) KeyDown(sender, e);
                                        }
                                        break;
                                case Keys.Return:
                                        if (m_Required && this.TextInt == 0 && !TextBox1.ReadOnly) {
                                                e.Handled = true;
                                                MostrarBuscador(TextBox1.Text);
                                        } else {
                                                if (m_AutoTab) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send(m_TeclaDespuesDeEnter);
                                                } else {
                                                        e.Handled = true;
                                                }
                                        }
                                        break;
                                default:
                                        if (null != KeyDown) KeyDown(sender, e);
                                        break;
                        }

                }


                private void Label1_Click(System.Object sender, System.EventArgs e)
                {
                        TextBox1.Focus();
                }


                private void DetailBox_Enter(object sender, System.EventArgs e)
                {
                        //TextBox1.BringToFront();
                        //TextBox1.Focus();
                        TextBox1.ScrollToCaret();
                        if (m_AutoUpdate)
                                UpdateDetail();
                        this.Refresh();
                }


                private void txtFreeText_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Left:
                                        if (EntradaFreeText.SelectionStart == 0) {
                                                e.Handled = true;
                                                TextBox1.Focus();
                                                // RaiseEvent KeyDown(sender, e)
                                        }
                                        break;
                                case Keys.Right:
                                        if (EntradaFreeText.SelectionStart >= EntradaFreeText.Text.Length) {
                                                e.Handled = true;
                                                if (null != KeyDown) KeyDown(sender, e);
                                                // Lui.Forms.SendKeys.Send("{enter}")
                                        }
                                        break;
                                case Keys.Down:
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        e.Handled = true;
                                        break;
                                case Keys.Up:
                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                        e.Handled = true;
                                        break;
                                case Keys.Return:
                                        if (EntradaFreeText.Text.Length > 0 || m_Required == false) {
                                                e.Handled = true;
                                                if (null != KeyDown) KeyDown(sender, e);
                                        } else {
                                                if (null != KeyDown) KeyDown(sender, e);
                                        }
                                        break;
                                default:
                                        if (null != KeyDown) KeyDown(sender, e);
                                        break;
                        }

                }


                private void DetailBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        if (@"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ* """.IndexOf(char.ToUpper(e.KeyChar)) != -1 && !TextBox1.ReadOnly) {
                                MostrarBuscador(e.KeyChar.ToString());
                                e.Handled = true;
                        }
                }


                private void ReubicarDetalle()
                {
                        // Reubico los campos txtFreeText y Label1
                        // Llamar a esta función despus de haber cambiado el Width de TextBox1
                        this.SuspendLayout();
                        EntradaFreeText.Left = TextBox1.Width + 4;
                        EntradaFreeText.Width = this.Width - EntradaFreeText.Left - 4;
                        Label1.Location = EntradaFreeText.Location;
                        Label1.Size = EntradaFreeText.Size;
                        this.ResumeLayout();
                }


                public object Edit()
                {
                        if (this.TextInt > 0)
                                return this.Workspace.RunTime.Execute("EDIT", new string[] { m_Table, this.TextInt.ToString() });
                        else
                                return null;
                }


                private void MenuItemCopiarCodigo_Click(object sender, System.EventArgs e)
                {
                        Clipboard.SetDataObject(this.Text, true);
                }


                private void MenuItemCopiarNombre_Click(object sender, System.EventArgs e)
                {
                        Clipboard.SetDataObject(this.TextDetail, true);
                }


                private void MenuItemPegar_Click(object sender, System.EventArgs e)
                {
                        string DatosPortapapeles = System.Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, true));
                        if (DatosPortapapeles != null)
                                this.Text = DatosPortapapeles;
                }


                private void MenuItemEditar_Click(object sender, System.EventArgs e)
                {
                        this.Edit();
                }


                private void ContextMenu_Popup(System.Object sender, System.EventArgs e)
                {
                        this.Focus();
                        MenuItemEditar.Enabled = (TextBox1.ReadOnly == false && m_CanCreate && this.TextInt > 0);
                        if (MenuItemEditar.Enabled)
                                MenuItemEditar.Text = @"Editar """ + this.TextDetail + @"""";
                        else
                                MenuItemEditar.Text = "Editar";

                        MenuItemCopiarCodigo.Enabled = this.Text.Length > 0;
                        MenuItemCopiarNombre.Enabled = this.TextDetail.Length > 0;
                        string DatosPortapapeles = System.Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, true));
                        if (DatosPortapapeles == null || TextBox1.ReadOnly == true) {
                                MenuItemPegar.Enabled = false;
                        } else {
                                MenuItemPegar.Enabled = true;
                                if (DatosPortapapeles.Length > 32)
                                        DatosPortapapeles = DatosPortapapeles.Substring(0, 32) + "...";
                                MenuItemPegar.Text = @"Pegar """ + DatosPortapapeles + @"""";
                        }
                        MenuItemBuscadorRapido.Enabled = (TextBox1.ReadOnly == false);
                }


                private void MenuItemBuscadorRapido_Click(System.Object sender, System.EventArgs e)
                {
                        if (TextBox1.ReadOnly == false)
                                MostrarBuscador("");
                }


                private void Label1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (TextBox1.ReadOnly == false)
                                this.MostrarBuscador("");
                }


                private void TextBox1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (TextBox1.ReadOnly == false)
                                this.MostrarBuscador("");
                }

                private void DetailBox_FontChanged(object sender, System.EventArgs e)
                {
                        Label1.Font = this.Font;
                        EntradaFreeText.Font = this.Font;
                }

                private void DetailBox_ForeColorChanged(object sender, System.EventArgs e)
                {
                        Label1.ForeColor = this.ForeColor;
                        EntradaFreeText.ForeColor = this.ForeColor;
                }
        }
}