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
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lui.Forms
{
        public class ButtonPanel : System.Windows.Forms.FlowLayoutPanel, IControl, IDisplayStyleControl
        {
                public ButtonPanel()
                {
                        this.AdoctrinarHijos();
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


                protected override void OnControlAdded(ControlEventArgs e)
                {
                        base.OnControlAdded(e);
                        this.AdoctrinarControl(e.Control);
                }


                private void AdoctrinarHijos()
                {
                        if (this.Created == false)
                                return;

                        foreach (Control Ctl in this.Controls) {
                                AdoctrinarControl(Ctl);
                        }
                }


                private void AdoctrinarControl(System.Windows.Forms.Control control)
                {
                        if (control.Created == false)
                                return;

                        control.MinimumSize = new Size(96, 32);

                        switch(this.FlowDirection)
                        {
                                case System.Windows.Forms.FlowDirection.BottomUp:
                                        control.Margin = new Padding(0, this.Padding.Bottom / 2, 0, 0);
                                        break;
                                case System.Windows.Forms.FlowDirection.LeftToRight:
                                        control.Margin = new Padding(0, 0, this.Padding.Left / 2, 0);
                                        break;
                                case System.Windows.Forms.FlowDirection.RightToLeft:
                                        control.Margin = new Padding(this.Padding.Right / 2, 0, 0, 0);
                                        break;
                                case System.Windows.Forms.FlowDirection.TopDown:
                                        control.Margin = new Padding(0, 0, 0, this.Padding.Top / 2);
                                        break;
                        }

                        switch (this.FlowDirection) {
                                case System.Windows.Forms.FlowDirection.LeftToRight:
                                case System.Windows.Forms.FlowDirection.RightToLeft:
                                        control.Height = this.ClientRectangle.Height - this.Padding.Vertical;
                                        break;
                                case System.Windows.Forms.FlowDirection.BottomUp:
                                case System.Windows.Forms.FlowDirection.TopDown:
                                        control.Width = this.ClientRectangle.Width - this.Padding.Horizontal;
                                        break;
                        }
                }


                protected override void OnPaddingChanged(EventArgs e)
                {
                        base.OnPaddingChanged(e);
                        AdoctrinarHijos();
                }

                protected override void OnSizeChanged(EventArgs e)
                {
                        base.OnSizeChanged(e);
                        AdoctrinarHijos();
                }


                protected override void OnLayout(LayoutEventArgs levent)
                {
                        base.OnLayout(levent);
                        this.AdoctrinarHijos();
                }


                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Color BackColor
                {
                        get
                        {
                                return this.DisplayStyle.BackgroundColor;
                        }
                }


                protected override void OnParentChanged(EventArgs e)
                {
                        base.OnParentChanged(e);
                        this.ApplyStyle();
                }


                protected override void OnParentBackColorChanged(EventArgs e)
                {
                        base.OnParentBackColorChanged(e);
                        this.ApplyStyle();
                }


                private void ApplyStyle()
                {
                        base.BackColor = this.DisplayStyle.DarkColor;
                }
        }
}
