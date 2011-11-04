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
                Header2
        }

        public class Label : System.Windows.Forms.Label, IControl
        {
                private LabelStyles m_LabelStyle = LabelStyles.Default;

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
                                                break;
                                        case LabelStyles.Small:
                                                base.Font = Lfx.Config.Display.SmallFont;
                                                break;
                                        case LabelStyles.Default:
                                                base.Font = Lfx.Config.Display.DefaultFont;
                                                break;
                                        case LabelStyles.Big:
                                                base.Font = Lfx.Config.Display.BigFont;
                                                break;
                                        case LabelStyles.Bigger:
                                                base.Font = Lfx.Config.Display.BiggerFont;
                                                break;
                                        case LabelStyles.Header1:
                                                base.Font = Lfx.Config.Display.HeaderFont;
                                                break;
                                        case LabelStyles.Header2:
                                                base.Font = Lfx.Config.Display.Header2Font;
                                                break;
                                }
                        }
                }
        }
}
