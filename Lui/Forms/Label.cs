#region License
// Copyright 2004-2011 Ernesto N. Carrea
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
        public enum LabelStyles
        {
                Small,
                Default,
                Big,
                Bigger,
                Title,
                Header1,
                Header2,
                Warning,
                SmallWarning,
                Info
        }

        public class Label : System.Windows.Forms.Label, IControl
        {
                private LabelStyles m_LabelStyle = LabelStyles.Default;

                public Label()
                {
                        base.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        base.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
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

                public LabelStyles LabelStyle
                {
                        get
                        {
                                return m_LabelStyle;
                        }
                        set
                        {
                                m_LabelStyle = value;
                                switch(m_LabelStyle) {
                                        case LabelStyles.Title:
                                                base.Font = Lfx.Config.Display.TitleFont;
                                                base.Padding = new Padding(0, 2, 0, 2);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.TitleBackground;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.TitleText;
                                                break;
                                        case LabelStyles.Small:
                                                base.Font = Lfx.Config.Display.SmallFont;
                                                base.Padding = new Padding(0, 0, 0, 0);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                                break;
                                        case LabelStyles.Default:
                                                base.Font = Lfx.Config.Display.DefaultFont;
                                                base.Padding = new Padding(0, 4, 0, 4);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                                break;
                                        case LabelStyles.Big:
                                                base.Font = Lfx.Config.Display.BigFont;
                                                base.Padding = new Padding(4);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                                break;
                                        case LabelStyles.Bigger:
                                                base.Font = Lfx.Config.Display.BiggerFont;
                                                base.Padding = new Padding(4);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                                                break;
                                        case LabelStyles.Header1:
                                                base.Font = Lfx.Config.Display.HeaderFont;
                                                base.Padding = new Padding(8);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.HeaderBackground;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.HeaderText;
                                                break;
                                        case LabelStyles.Header2:
                                                base.Font = Lfx.Config.Display.Header2Font;
                                                base.Padding = new Padding(2);
                                                base.BackColor = Lfx.Config.Display.CurrentTemplate.Header2Background;
                                                base.ForeColor = Lfx.Config.Display.CurrentTemplate.Header2Text;
                                                break;
                                        case LabelStyles.Warning:
                                                base.Font = Lfx.Config.Display.DefaultFont;
                                                base.Padding = new Padding(0, 4, 0, 4);
                                                base.BackColor = System.Drawing.Color.Tomato;
                                                base.ForeColor = System.Drawing.Color.White;
                                                break;
                                        case LabelStyles.SmallWarning:
                                                base.Font = Lfx.Config.Display.SmallFont;
                                                base.Padding = new Padding(0, 2, 0, 2);
                                                base.BackColor = System.Drawing.Color.Tomato;
                                                base.ForeColor = System.Drawing.Color.White;
                                                break;
                                        case LabelStyles.Info:
                                                base.Font = Lfx.Config.Display.DefaultFont;
                                                base.Padding = new Padding(0, 4, 0, 4);
                                                base.BackColor = System.Drawing.SystemColors.Info;
                                                base.ForeColor = System.Drawing.SystemColors.InfoText;
                                                break;
                                }
                        }
                }
        }
}
