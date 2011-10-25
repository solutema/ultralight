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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class TextBoxBase : EditableControl
        {
                protected internal bool m_AutoTab = true;
                protected internal bool m_AutoNav = true;
                private string m_PlaceholderText = "";

                new public event KeyPressEventHandler KeyPress;
                new public event System.Windows.Forms.KeyEventHandler KeyDown;
                new public event System.EventHandler GotFocus;
                new public event System.EventHandler LostFocus;
                protected internal int IgnorarEventos;

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
                public bool AutoNav
                {
                        get
                        {
                                return m_AutoNav;
                        }
                        set
                        {
                                m_AutoNav = value;
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

                public string PlaceholderText
                {
                        get
                        {
                                return m_PlaceholderText;
                        }
                        set
                        {
                                m_PlaceholderText = value;

                                if (ActiveControl != TextBox1) {
                                        IgnorarEventos++;
                                        this.SetTipIfBlank();
                                        IgnorarEventos--;
                                }
                        }
                }

                private void TextBox1_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        if (e.KeyChar == Lfx.Types.ControlChars.Cr && TextBox1.Multiline) {
                                //Es multilinea.
                                if (m_AutoTab && (this.TextRaw.Length == 0 ||
                                        (this.TextRaw.Length >= System.Environment.NewLine.Length
                                        && this.TextRaw.Substring(this.TextRaw.Length - System.Environment.NewLine.Length) == System.Environment.NewLine))) {
                                        // Es AutoTab y estoy intentando dar Enter a un campo vacío o estoy intentando dar dos Enter seguidos
                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                        e.Handled = true;
                                }
                        } else if (e.KeyChar == Lfx.Types.ControlChars.Cr && m_AutoTab) {
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
                                        case Keys.E:
                                                if (e.Control)
                                                        TextBox1.SelectionLength = 0;
                                                break;
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
                                        default:
                                                if (this.KeyDown != null)
                                                        this.KeyDown(this, e);
                                                break;
                                }
                        } else {
                                if (null != KeyDown)
                                        KeyDown(this, e);
                        }
                }


                private void TextBox1_TextChanged(object sender, System.EventArgs e)
                {
                        if (m_IgnoreChanges == 0) {
                                m_IgnoreChanges++;
                                this.Changed = true;
                                m_IgnoreChanges--;
                        }
                        this.OnTextChanged(EventArgs.Empty);
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
                                TextBox1.ReadOnly = value || this.ReadOnly;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public string TextRaw
                {
                        get
                        {
                                if (TextBox1.ForeColor == Lfx.Config.Display.CurrentTemplate.ControlGrayText)
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

                public int MaxLength
                {
                        get
                        {
                                return TextBox1.MaxLength;
                        }
                        set
                        {
                                TextBox1.MaxLength = value;
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
                        if (IgnorarEventos == 0) {
                                IgnorarEventos++;
                                TextBox1.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                                if (this.LostFocus != null)
                                        this.LostFocus(this, e);

                                this.SetTipIfBlank();
                                IgnorarEventos--;
                        }
                }

                private void SetTipIfBlank()
                {
                        if (TextBox1.Text == "" && this.PlaceholderText != null && this.PlaceholderText.Length > 0) {
                                TextBox1.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlGrayText;
                                TextBox1.Text = m_PlaceholderText;
                                TextBox1.SelectionStart = 0;
                                TextBox1.SelectionLength = 0;
                        } else {
                                TextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
                        }
                }

                private void TextBox1_GotFocus(object sender, System.EventArgs e)
                {
                        if (IgnorarEventos == 0) {
                                IgnorarEventos++;
                                if (m_TemporaryReadOnly == false && m_ReadOnly == false) {
                                        TextBox1.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataareaActive;

                                        if (TextBox1.ForeColor == Lfx.Config.Display.CurrentTemplate.ControlGrayText) {
                                                this.TextBox1.Text = "";
                                                TextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
                                        }
                                }

                                TextBox1.Focus();
                                IgnorarEventos--;

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


                new public Color ForeColor
                {
                        get
                        {
                                return TextBox1.ForeColor;
                        }
                        set
                        {
                                TextBox1.ForeColor = value;
                        }
                }
        }
}
