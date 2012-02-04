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

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
        public class Label : System.Windows.Forms.Label, IControl, IDisplayStyleControl
        {
                protected Lazaro.Pres.DisplayStyles.TextStyles m_LabelStyle = Lazaro.Pres.DisplayStyles.TextStyles.Default;

                public Label()
                {
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
                new public Color ForeColor
                {
                        get
                        {
                                return base.ForeColor;
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


                [DefaultValue(Lazaro.Pres.DisplayStyles.TextStyles.Default)]
                public Lazaro.Pres.DisplayStyles.TextStyles TextStyle
                {
                        get
                        {
                                return m_LabelStyle;
                        }
                        set
                        {
                                m_LabelStyle = value;
                                this.ApplyStyle();
                        }
                }


                protected override void OnParentChanged(System.EventArgs e)
                {
                        base.OnParentChanged(e);
                        this.ApplyStyle();
                }


                protected override void OnParentBackColorChanged(System.EventArgs e)
                {
                        base.OnParentBackColorChanged(e);
                        this.ApplyStyle();
                }


                public void ApplyStyle()
                {
                        switch (m_LabelStyle) {
                                case Lazaro.Pres.DisplayStyles.TextStyles.MainHeader:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.MainHeaderFont;
                                        base.Padding = new Padding(0);
                                        if (this.Parent != null)
                                                base.BackColor = this.Parent.BackColor;
                                        base.ForeColor = Color.MidnightBlue;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.GroupHeaderFont;
                                        base.Padding = new Padding(0, 2, 0, 2);
                                        if (this.Parent != null)
                                                base.BackColor = this.Parent.BackColor;
                                        base.ForeColor = Color.MidnightBlue;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.GroupHeader2:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.GroupHeader2Font;
                                        base.Padding = new Padding(0, 2, 0, 2);
                                        if (this.Parent != null)
                                                base.BackColor = this.Parent.BackColor;
                                        base.ForeColor = Color.MidnightBlue;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.Small:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.SmallFont;
                                        base.Padding = new Padding(0, 0, 0, 0);
                                        if (this.Parent != null)
                                                base.BackColor = this.Parent.BackColor;
                                        base.ForeColor = this.DisplayStyle.TextColor;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.Default:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                                        base.Padding = new Padding(0, 4, 0, 0);
                                        if (this.Parent != null)
                                                base.BackColor = this.Parent.BackColor;
                                        base.ForeColor = this.DisplayStyle.TextColor;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.Big:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.BigFont;
                                        base.Padding = new Padding(3);
                                        base.BackColor = Color.Transparent;
                                        base.ForeColor = this.DisplayStyle.TextColor;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.Bigger:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.BiggerFont;
                                        base.Padding = new Padding(3);
                                        if (this.Parent != null)
                                                base.BackColor = this.Parent.BackColor;
                                        base.ForeColor = this.DisplayStyle.TextColor;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.Warning:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                                        base.Padding = new Padding(0, 4, 0, 4);
                                        base.BackColor = System.Drawing.Color.Tomato;
                                        base.ForeColor = System.Drawing.Color.White;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.SmallWarning:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.SmallFont;
                                        base.Padding = new Padding(0, 2, 0, 2);
                                        base.BackColor = System.Drawing.Color.Tomato;
                                        base.ForeColor = System.Drawing.Color.White;
                                        break;
                                case Lazaro.Pres.DisplayStyles.TextStyles.Info:
                                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                                        base.Padding = new Padding(0, 4, 0, 4);
                                        base.BackColor = System.Drawing.SystemColors.Info;
                                        base.ForeColor = System.Drawing.SystemColors.InfoText;
                                        break;
                        }
                }
                

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public virtual Lazaro.Pres.DisplayStyles.IDisplayStyle DisplayStyle
                {
                        get
                        {
                                if (this.Parent is IForm)
                                        return ((IForm)(this.Parent)).DisplayStyle;
                                else if (this.Parent is IDisplayStyleControl)
                                        return ((IDisplayStyleControl)(this.Parent)).DisplayStyle;
                                else
                                        return Lazaro.Pres.DisplayStyles.Template.Current.Default;
                        }
                }
        }
}
