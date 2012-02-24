#region License
// Copyright 2004-2012 Ernesto N. Carrea
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

namespace Lui.Forms
{
        public partial class TextBoxBase : EditableControl
        {
                protected string m_PlaceholderText = null;
                protected bool Grayed { get; set; }

                new public event KeyPressEventHandler KeyPress;
                new public event System.Windows.Forms.KeyEventHandler KeyDown;
                new public event System.EventHandler GotFocus;
                new public event System.EventHandler LostFocus;
                protected internal int IgnoreEvents;

                public TextBoxBase()
                {
                        InitializeComponent();

                        this.GotFocus += new System.EventHandler(this.TextBoxBase_GotFocus);
                        this.FontChanged += new System.EventHandler(this.TextBoxBase_FontChanged);
                        this.ForeColorChanged += new System.EventHandler(this.TextBoxBase_ForeColorChanged);
                        this.Enter += new System.EventHandler(this.TextBoxBase_Enter);
                        this.SizeChanged += new System.EventHandler(this.TextBoxBase_SizeChanged);
                        this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
                        this.TextBox1.GotFocus += new System.EventHandler(this.TextBox1_GotFocus);
                        this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
                        this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
                        this.TextBox1.LostFocus += new System.EventHandler(this.TextBox1_LostFocus);
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Color BackColor
                {
                        get
                        {
                                return base.BackColor;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Padding Padding
                {
                        get
                        {
                                return base.Padding;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Padding Margin
                {
                        get
                        {
                                return base.Margin;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Always),
                        System.ComponentModel.Browsable(true),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
                        RefreshProperties(RefreshProperties.Repaint)]
                public override System.String Text
                {
                        get
                        {
                                return this.TextRaw;
                        }
                        set
                        {
                                this.TextRaw = value;
                                this.Changed = false;
                        }
                }

                [DefaultValue(null)]
                public string PlaceholderText
                {
                        get
                        {
                                return m_PlaceholderText;
                        }
                        set
                        {
                                if (TextBox1.Text == m_PlaceholderText && this.Grayed) {
                                        IgnoreEvents++;
                                        TextBox1.Text = "";
                                        this.SetTipIfBlank();
                                        IgnoreEvents--;
                                }

                                m_PlaceholderText = value;

                                if (ActiveControl != TextBox1) {
                                        IgnoreEvents++;
                                        this.SetTipIfBlank();
                                        IgnoreEvents--;
                                }
                        }
                }

                private void TextBox1_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        if (e.KeyChar == Lfx.Types.ControlChars.Cr && TextBox1.Multiline) {
                                //Es multilinea.
                                if (m_AutoNav && (this.TextRaw.Length == 0 || (this.TextRaw.Length >= System.Environment.NewLine.Length && this.TextRaw.Substring(this.TextRaw.Length - System.Environment.NewLine.Length) == System.Environment.NewLine))) {
                                        // Es AutoNav y estoy intentando dar Enter a un campo vacío o estoy intentando dar dos Enter seguidos
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        e.Handled = true;
                                }
                        } else if (e.KeyChar == Lfx.Types.ControlChars.Cr && m_AutoNav) {
                                // Es autonav. Paso un tab
                                e.Handled = true;
                                System.Windows.Forms.SendKeys.Send("{tab}");
                        } else {
                                if (KeyPress != null)
                                        KeyPress(this, e);
                        }
                }


                internal void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (m_AutoNav) {
                                switch (e.KeyCode) {
                                        case Keys.Down:
                                                if (e.Alt) {
                                                        m_AutoNav = false;
                                                        System.Windows.Forms.SendKeys.SendWait("{down}");
                                                        m_AutoNav = true;
                                                        e.Handled = true;
                                                } else if (e.Shift == false && e.Control == false) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                                }
                                                break;
                                        case Keys.Up:
                                                if (e.Alt) {
                                                        m_AutoNav = false;
                                                        System.Windows.Forms.SendKeys.SendWait("{up}");
                                                        m_AutoNav = true;
                                                        e.Handled = true;
                                                } else if (e.Shift == false && e.Control == false) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                }
                                                break;
                                        case Keys.Left:
                                                if (e.Alt) {
                                                        m_AutoNav = false;
                                                        System.Windows.Forms.SendKeys.SendWait("{left}");
                                                        m_AutoNav = true;
                                                        e.Handled = true;
                                                }
                                                break;
                                        case Keys.Right:
                                                if (e.Alt) {
                                                        m_AutoNav = false;
                                                        System.Windows.Forms.SendKeys.SendWait("{right}");
                                                        m_AutoNav = true;
                                                        e.Handled = true;
                                                }
                                                break;
                                }
                                if (e.Handled == false && this.KeyDown != null)
                                        this.KeyDown(this, e);
                        } else {
                                if (KeyDown  != null)
                                        KeyDown(this, e);
                        }
                }


                private void TextBox1_TextChanged(object sender, System.EventArgs e)
                {
                        if (IgnoreChanges == 0) {
                                IgnoreChanges++;
                                this.Changed = true;
                                IgnoreChanges--;
                        }
                        this.OnTextChanged(EventArgs.Empty);
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public string TextRaw
                {
                        get
                        {
                                if (this.Grayed)
                                        return "";
                                else
                                        return TextBox1.Text;
                        }
                        set
                        {
                                TextBox1.Text = value;
                                if (ActiveControl != TextBox1)
                                        this.SetTipIfBlank();
                        }
                }


                private void TextBoxBase_GotFocus(object sender, System.EventArgs e)
                {
                        TextBox1.Focus();
                }


                private void TextBoxBase_Enter(object sender, System.EventArgs e)
                {
                        TextBox1.Focus();
                }


                private void TextBox1_LostFocus(object sender, System.EventArgs e)
                {
                        if (IgnoreEvents == 0) {
                                IgnoreEvents++;
                                TextBox1.BackColor = this.DisplayStyle.DataAreaColor;
                                if (this.LostFocus != null)
                                        this.LostFocus(this, e);

                                this.SetTipIfBlank();
                                IgnoreEvents--;
                        }
                }

                private void SetTipIfBlank()
                {
                        if (TextBox1.Text == "" && this.PlaceholderText != null && this.PlaceholderText.Length > 0) {
                                this.Grayed = true;
                                this.ApplyStyle();
                                IgnoreChanges++;
                                TextBox1.Text = this.PlaceholderText;
                                IgnoreChanges--;
                                TextBox1.SelectionStart = 0;
                                TextBox1.SelectionLength = 0;
                        } else {
                                this.Grayed = false;
                                this.ApplyStyle();
                        }
                }

                private void TextBox1_GotFocus(object sender, System.EventArgs e)
                {
                        if (IgnoreEvents == 0) {
                                IgnoreEvents++;
                                if (m_TemporaryReadOnly == false && m_ReadOnly == false) {
                                        if (this.Grayed) {
                                                IgnoreChanges++;
                                                this.TextBox1.Text = "";
                                                IgnoreChanges--;
                                                this.Grayed = false;
                                                this.ApplyStyle();
                                        }
                                }

                                TextBox1.Select();
                                IgnoreEvents--;

                                if (null != GotFocus)
                                        GotFocus(this, e);
                        }
                }

                private void TextBoxBase_FontChanged(object sender, System.EventArgs e)
                {
                        TextBox1.Font = this.Font;
                }

                private void TextBoxBase_ForeColorChanged(object sender, System.EventArgs e)
                {
                        TextBox1.ForeColor = this.ForeColor;
                }

                private void TextBoxBase_SizeChanged(object sender, System.EventArgs e)
                {
                        TextBox1.Width = this.Width - (TextBox1.Left * 2);
                        TextBox1.Height = this.Height - (TextBox1.Top * 2);
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Font Font
                {
                        get
                        {
                                return base.Font;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Font CustomFont
                {
                        get
                        {
                                return this.Font;
                        }
                        set
                        {
                                base.Font = value;
                        }
                }


                public override void ApplyStyle()
                {
                        base.ApplyStyle();
                        ((System.Windows.Forms.Control)(this)).BackColor = this.DisplayStyle.DataAreaColor;
                        TextBox1.BackColor = this.BackColor;
                        if (this.Grayed)
                                TextBox1.ForeColor = this.DisplayStyle.DataAreaGrayTextColor;
                        else
                                TextBox1.ForeColor = this.DisplayStyle.DataAreaTextColor;
                }

                private void TextBox1_Click(object sender, EventArgs e)
                {
                        this.RaiseClick(e);
                }
        }
}
