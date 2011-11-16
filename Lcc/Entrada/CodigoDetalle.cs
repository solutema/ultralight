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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lcc.Entrada
{
        public partial class CodigoDetalle : ControlSeleccionElemento
        {
                private bool m_SelectOnFocus = true;
                private bool m_AutoTab = true;
                private bool m_AutoUpdate = true;
                private bool m_Required = true;
                private string m_FreeTextCode = "";
                private string m_LastText1;
                private string m_TeclaDespuesDeEnter = "{tab}";
                private string m_ExtraDetailFields = "";
                private string m_Filter = "";
                private bool m_CanCreate = true;

                [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
                new public event System.Windows.Forms.KeyEventHandler KeyDown;

                public CodigoDetalle()
                {
                        InitializeComponent();

                        Label1.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        Label1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                        EntradaCodigo.BackColor = Label1.BackColor;
                        EntradaCodigo.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlGrayText;
                        EntradaFreeText.BackColor = Label1.BackColor;
                        EntradaFreeText.ForeColor = Label1.ForeColor;
                        this.BorderStyle = Lui.Forms.Control.BorderStyles.TextBox;
                }


                public string PlaceholderText { get; set; }


                [EditorBrowsable(EditorBrowsableState.Never), 
                        System.ComponentModel.Browsable(false), 
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

                
                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

                public override bool IsEmpty
                {
                        get
                        {
                                return this.Text != this.FreeTextCode && (this.Text.Length == 0 || this.Text == "0");
                        }
                }

                public override bool TemporaryReadOnly
                {
                        get
                        {
                                return EntradaCodigo.ReadOnly;
                        }
                        set
                        {
                                base.TemporaryReadOnly = value;
                                EntradaCodigo.ReadOnly = value;
                                if (Label1.Text == "???")
                                        ProgramarActualizacionDetalle(false);
                        }
                }

                [System.ComponentModel.Category("Datos")]
                override public string Table
                {
                        get
                        {
                                return base.Table;
                        }
                        set
                        {
                                base.Table = value;
                                if (this.Relation.ReferenceTable == "articulos")
                                        EntradaCodigo.Width = 96;
                                else
                                        EntradaCodigo.Width = 50;
                                ReubicarDetalle();
                                ProgramarActualizacionDetalle(false);
                        }
                }

                [System.ComponentModel.Category("Datos")]
                override public string DataValueField
                {
                        get
                        {
                                return base.DataValueField;
                        }
                        set
                        {
                                base.DataValueField = value;
                        }
                }

                [System.ComponentModel.Category("Datos")]
                override public string DataTextField
                {
                        get
                        {
                                return base.DataTextField;
                        }
                        set
                        {
                                base.DataTextField = value;
                                ProgramarActualizacionDetalle(false);
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
                                ProgramarActualizacionDetalle(false);
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
                                ProgramarActualizacionDetalle(false);
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
                                if (m_FreeTextCode.Length > 0 && this.EntradaCodigo.Text == m_FreeTextCode)
                                        return this.EntradaCodigo.Text;
                                else if (Label1.Text == "???")
                                        return "";
                                else
                                        return m_ItemId.ToString();
                        }
                        set
                        {
                                if (value == "0") {
                                        m_ItemId = 0;
                                        this.EntradaCodigo.Text = "";
                                } else {
                                        this.EntradaCodigo.Text = value;
                                        m_ItemId = Lfx.Types.Parsing.ParseInt(value);
                                }

                                this.DispararTextChanged = true;
                                this.ActualizarDetalle();

                                this.Changed = false;
                        }
                }

                [System.ComponentModel.Category("Apariencia")]
                public System.String TextDetail
                {
                        get
                        {
                                if (m_FreeTextCode.Length > 0 && this.EntradaCodigo.Text == m_FreeTextCode)
                                        return EntradaFreeText.Text;
                                else if (Label1.Text == "???" || Label1.Text == this.PlaceholderText)
                                        return "";
                                else
                                        return Label1.Text;
                        }
                        set
                        {
                                if (m_FreeTextCode.Length > 0 && this.EntradaCodigo.Text == m_FreeTextCode)
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
                        } else if (@"ABCDEFGHIJKLMNOPQRSTUVWXYZ """.IndexOf(char.ToUpper(e.KeyChar)) != -1 && !EntradaCodigo.ReadOnly) {
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
                        using (Statics.DetailBoxQuickSelect = new AuxForms.DetailBoxQuickSelect()) {
                                Statics.DetailBoxQuickSelect.Owner = this.ParentForm;
                                Statics.DetailBoxQuickSelect.ElementoTipo = this.ElementoTipo;
                                Statics.DetailBoxQuickSelect.Table = this.Relation.ReferenceTable;
                                Statics.DetailBoxQuickSelect.CanCreate = this.CanCreate;
                                Statics.DetailBoxQuickSelect.DetailField = this.Relation.DetailColumn;
                                Statics.DetailBoxQuickSelect.KeyField = this.Relation.ReferenceColumn;
                                Statics.DetailBoxQuickSelect.Filter = m_Filter;
                                Statics.DetailBoxQuickSelect.ExtraDetailFields = m_ExtraDetailFields;
                                Statics.DetailBoxQuickSelect.ControlDestino = this;
                                Statics.DetailBoxQuickSelect.Top = System.Convert.ToInt32((this.DisplayRectangle.Top + this.DisplayRectangle.Height / 2) - (Statics.DetailBoxQuickSelect.Height / 2));
                                Statics.DetailBoxQuickSelect.Left = System.Convert.ToInt32((this.DisplayRectangle.Left + this.DisplayRectangle.Width / 2) - (Statics.DetailBoxQuickSelect.Width / 2));
                                if (Statics.DetailBoxQuickSelect.Buscar(valorIncial) != DialogResult.Retry) {
                                        if (EntradaCodigo.Text.Length > 0) {
                                                System.Windows.Forms.SendKeys.Send(m_TeclaDespuesDeEnter);
                                        }
                                }

                                Statics.DetailBoxQuickSelect.Dispose();
                                Statics.DetailBoxQuickSelect = null;
                        }
                }


                private void TextBox1_GotFocus(System.Object sender, System.EventArgs e)
                {
                        if (m_TemporaryReadOnly == false) {
                                EntradaCodigo.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;
                                EntradaCodigo.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                        }
                        if (m_SelectOnFocus)
                                EntradaCodigo.SelectAll();
                }

                private void EntradaFreeText_GotFocus(object sender, System.EventArgs e)
                {
                        if (m_TemporaryReadOnly == false)
                                EntradaFreeText.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;
                        EntradaFreeText.SelectionStart = 1024;
                }

                private void TextBox1_LostFocus(System.Object sender, System.EventArgs e)
                {
                        EntradaCodigo.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        EntradaCodigo.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlGrayText;
                }

                private void EntradaFreeText_LostFocus(object sender, System.EventArgs e)
                {
                        EntradaFreeText.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                }


                private void TextBox1_TextChanged(object sender, System.EventArgs e)
                {
                        if (EntradaCodigo.Text.Length > 13) {
                                if (EntradaCodigo.Font.Size > 7) {
                                        EntradaCodigo.Font = new Font(this.Font.Name, 7);
                                        if (EntradaCodigo.Width < 128)
                                                EntradaCodigo.Width = 128;
                                        ReubicarDetalle();
                                }
                        } else {
                                if (EntradaCodigo.Width > 96) {
                                        EntradaCodigo.Width = 96;
                                        ReubicarDetalle();
                                }

                                if (EntradaCodigo.Text.Length > 11) {
                                        if (EntradaCodigo.Font.Size > 8)
                                                EntradaCodigo.Font = new Font(this.Font.Name, 8);

                                } else {
                                        if (EntradaCodigo.Font.Size < 10)
                                                EntradaCodigo.Font = this.Font;
                                }
                        }

                        ProgramarActualizacionDetalle(true);

                        if (Label1.Text == "???" && EntradaCodigo.Text.Length > 6)
                                MostrarBuscador(EntradaCodigo.Text);

                        this.Changed = true;
                }

                private bool DispararTextChanged = false;
                private void ProgramarActualizacionDetalle(bool textChanged)
                {
                        TimerActualizar.Stop();

                        if (m_FreeTextCode.Length > 0 && EntradaCodigo.Text == m_FreeTextCode) {
                                m_ItemId = 0;
                                this.CurrentRow = null;
                                m_LastText1 = "";
                                EntradaFreeText.Visible = true;
                                EntradaFreeText.Focus();

                                if (textChanged)
                                        this.OnTextChanged(EventArgs.Empty);
                        } else if (this.Relation.IsEmpty() == false && EntradaCodigo.Text.Length > 0 && EntradaCodigo.Text != "0") {
                                Label1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                if (this.AutoUpdate) {
                                        if (this.HasWorkspace == false || this.Workspace.SlowLink)
                                                TimerActualizar.Interval = 500;
                                        else
                                                TimerActualizar.Interval = 200;

                                        if (textChanged)
                                                DispararTextChanged = true;

                                        TimerActualizar.Start();
                                } else {
                                        if (textChanged)
                                                this.OnTextChanged(EventArgs.Empty);
                                }
                        } else {
                                m_ItemId = 0;
                                this.CurrentRow = null;
                                m_LastText1 = "";
                                Label1.Text = this.PlaceholderText;
                                Label1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlGrayText;

                                if (textChanged)
                                        this.OnTextChanged(EventArgs.Empty);
                        }
                }


                private void ActualizarDetalle()
                {
                        if (this.HasWorkspace && this.Connection != null) {
                                if (m_FreeTextCode.Length > 0 && EntradaCodigo.Text == m_FreeTextCode) {
                                        // *** Esta escribiendo texto libre
                                        m_ItemId = 0;
                                        this.CurrentRow = null;
                                        m_LastText1 = "";
                                        EntradaFreeText.Visible = true;
                                } else if (this.Relation.IsEmpty() == false && EntradaCodigo.Text.Length > 0 && EntradaCodigo.Text != "0") {
                                        // *** Ingresó un código que parece válido
                                        string KeyFieldAlt = this.Relation.ReferenceColumn; // KeyField Alternativo
                                        if (this.Relation.ReferenceTable == "articulos" && KeyFieldAlt == "id_articulo")
                                                KeyFieldAlt = this.Workspace.CurrentConfig.Productos.CodigoPredeterminado();

                                        if (EntradaCodigo.Text != m_LastText1) {
                                                EntradaFreeText.Visible = false;
                                                string TextoSql = "", Campos = "*";

                                                TextoSql = "SELECT " + Campos + " FROM " + this.Relation.ReferenceTable + " WHERE " + KeyFieldAlt + "='" + this.Connection.EscapeString(EntradaCodigo.Text) + "'";
                                                if (m_Filter != null && m_Filter.Length > 0 && this.TemporaryReadOnly == false)
                                                        TextoSql += " AND (" + m_Filter + ")";

                                                CurrentRow = this.Connection.FirstRowFromSelect(TextoSql);
                                                if (CurrentRow == null && this.Relation.ReferenceColumn != KeyFieldAlt) {
                                                        TextoSql = "SELECT " + Campos + " FROM " + this.Relation.ReferenceTable + " WHERE " + this.Relation.ReferenceColumn + "='" + this.Connection.EscapeString(EntradaCodigo.Text) + "'";
                                                        if (m_Filter != null && m_Filter.Length > 0 && this.TemporaryReadOnly == false)
                                                                TextoSql += " AND (" + m_Filter + ")";
                                                        CurrentRow = this.Connection.FirstRowFromSelect(TextoSql);
                                                }
                                                if (CurrentRow == null) {
                                                        m_ItemId = 0;
                                                        m_LastText1 = "";
                                                        Label1.Text = "???";
                                                        Label1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlGrayText;
                                                } else {
                                                        m_ItemId = System.Convert.ToInt32(CurrentRow[this.Relation.ReferenceColumn]);
                                                        m_LastText1 = EntradaCodigo.Text;
                                                        Label1.Text = System.Convert.ToString(CurrentRow[this.Relation.DetailColumn]);
                                                        Label1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                                }
                                        }

                                        if (DispararTextChanged) 
                                                this.DispararTextChangedAhora();
                                } else {
                                        // El campo está en blanco o con algo que no parece un código válido
                                        m_ItemId = 0;
                                        this.CurrentRow = null;
                                        m_LastText1 = "";
                                        Label1.Text = this.PlaceholderText;
                                        Label1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlGrayText;
                                }
                        } else {
                                m_ItemId = 0;
                                this.CurrentRow = null;
                                m_LastText1 = "";
                                Label1.Text = "";
                        }

                        if (this.TextInt > 0 && this.Visible)
                                this.Workspace.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", this.Relation.ReferenceTable, this.Text });
                }


                private void DispararTextChangedAhora()
                {
                        DispararTextChanged = false;
                        this.OnTextChanged(EventArgs.Empty);
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
                                        if (m_Required && this.TextInt == 0 && !EntradaCodigo.ReadOnly) {
                                                e.Handled = true;
                                                MostrarBuscador(EntradaCodigo.Text);
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
                        EntradaCodigo.Focus();
                }


                private void DetailBox_Enter(object sender, System.EventArgs e)
                {
                        EntradaCodigo.ScrollToCaret();
                        ProgramarActualizacionDetalle(false);
                        this.Refresh();
                }


                private void EntradaFreeText_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Left:
                                        if (EntradaFreeText.SelectionStart == 0) {
                                                e.Handled = true;
                                                EntradaCodigo.Focus();
                                        }
                                        break;
                                case Keys.Right:
                                        if (EntradaFreeText.SelectionStart >= EntradaFreeText.Text.Length) {
                                                e.Handled = true;
                                                if (null != KeyDown)
                                                        KeyDown(sender, e);
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
                                                if (null != KeyDown) 
                                                        KeyDown(sender, e);
                                        } else {
                                                if (null != KeyDown) 
                                                        KeyDown(sender, e);
                                        }
                                        break;
                                default:
                                        if (null != KeyDown) KeyDown(sender, e);
                                        break;
                        }

                }


                private void DetailBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        if (@"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ* """.IndexOf(char.ToUpper(e.KeyChar)) != -1 && !EntradaCodigo.ReadOnly) {
                                MostrarBuscador(e.KeyChar.ToString());
                                e.Handled = true;
                        }
                }


                private void ReubicarDetalle()
                {
                        // Reubico los campos EntradaFreeText y Label1
                        // Llamar a esta función después de haber cambiado el Width de TextBox1
                        this.SuspendLayout();
                        EntradaFreeText.Left = EntradaCodigo.Width + 4;
                        EntradaFreeText.Width = this.Width - EntradaFreeText.Left - 4;
                        Label1.Location = EntradaFreeText.Location;
                        Label1.Size = EntradaFreeText.Size;
                        this.ResumeLayout();
                }


                public object Edit()
                {
                        if (this.TextInt > 0)
                                return this.Workspace.RunTime.Execute("EDIT", new string[] { this.Relation.ReferenceTable, this.TextInt.ToString() });
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
                        MenuItemEditar.Enabled = (EntradaCodigo.ReadOnly == false && m_CanCreate && this.TextInt > 0);
                        if (MenuItemEditar.Enabled)
                                MenuItemEditar.Text = @"Editar """ + this.TextDetail + @"""";
                        else
                                MenuItemEditar.Text = "Editar";

                        MenuItemCopiarCodigo.Enabled = this.Text.Length > 0;
                        MenuItemCopiarNombre.Enabled = this.TextDetail.Length > 0;
                        string DatosPortapapeles = System.Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text, true));
                        if (DatosPortapapeles == null || EntradaCodigo.ReadOnly == true) {
                                MenuItemPegar.Enabled = false;
                        } else {
                                MenuItemPegar.Enabled = true;
                                if (DatosPortapapeles.Length > 32)
                                        DatosPortapapeles = DatosPortapapeles.Substring(0, 32) + "...";
                                MenuItemPegar.Text = @"Pegar """ + DatosPortapapeles + @"""";
                        }
                        MenuItemBuscadorRapido.Enabled = (EntradaCodigo.ReadOnly == false);
                }


                private void MenuItemBuscadorRapido_Click(System.Object sender, System.EventArgs e)
                {
                        if (EntradaCodigo.ReadOnly == false)
                                MostrarBuscador("");
                }


                private void Label1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (EntradaCodigo.ReadOnly == false)
                                this.MostrarBuscador("");
                }


                private void TextBox1_DoubleClick(object sender, System.EventArgs e)
                {
                        if (EntradaCodigo.ReadOnly == false)
                                this.MostrarBuscador("");
                }


                private void TimerActualizar_Tick(object sender, EventArgs e)
                {
                        TimerActualizar.Stop();
                        ActualizarDetalle();
                }

                new public Color ForeColor
                {
                        get
                        {
                                return EntradaCodigo.ForeColor;
                        }
                        set
                        {
                                Label1.ForeColor = this.ForeColor;
                                EntradaFreeText.ForeColor = this.ForeColor;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Font Font
                {
                        get
                        {
                                return base.Font;
                        }
                }
        }
}
