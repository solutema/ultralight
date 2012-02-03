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
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lui.Forms
{
        public class LinkLabel : System.Windows.Forms.LinkLabel
        {
                public LinkLabel()
                {
                        base.Font = Lazaro.Pres.DisplayStyles.Template.Current.DefaultFont;
                        this.Cursor = Cursors.Hand;
                        this.TextAlign = ContentAlignment.MiddleCenter;
                        this.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                        base.LinkColor = Color.RoyalBlue;
                        base.ActiveLinkColor = base.LinkColor;
                        base.BackColor = Color.Transparent;
                }


                protected override void OnEnter(EventArgs e)
                {
                        base.LinkColor = Color.White;
                        base.ActiveLinkColor = base.LinkColor;
                        base.BackColor = Color.RoyalBlue;
                        base.OnEnter(e);
                }


                protected override void OnLeave(EventArgs e)
                {
                        base.LinkColor = Color.RoyalBlue;
                        base.ActiveLinkColor = base.LinkColor;
                        base.BackColor = Color.Transparent;
                        base.OnLeave(e);
                }


                protected override bool IsInputKey(Keys keyData)
                {
                        switch (keyData) {
                                case Keys.Up:
                                case Keys.Down:
                                case Keys.Left:
                                case Keys.Right:
                                        return true;
                                default:
                                        return base.IsInputKey(keyData);
                        }
                }


                protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Shift == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.Up:
                                        case Keys.Left:
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                                break;
                                        case Keys.Down:
                                        case Keys.Right:
                                                e.Handled = true;
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                                break;
                                }
                        }
                        base.OnKeyDown(e);
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
                new public Color LinkColor
                {
                        get
                        {
                                return base.LinkColor;
                        }
                }
        }
}
