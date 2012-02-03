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
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
        [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]

        public partial class Frame : ContainerControl
        {
                public Frame()
                {
                        InitializeComponent();
                }


                /* protected override void OnEnter(EventArgs e)
                {
                        base.OnEnter(e);
                        this.Highlighted = true;
                }


                protected override void OnLeave(EventArgs e)
                {
                        base.OnLeave(e);
                        this.Highlighted = false;
                } */

                /* [Category("Appearance")]
                [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
                public Panel ContainerPanel
                {
                        get
                        {
                                return PanelContenedor;
                        }
                } */

                protected override void OnPaint(PaintEventArgs e)
                {
                        base.OnPaint(e);

                        int y = 0;
                        if (EtiquetaTitulo.Visible)
                                y += EtiquetaTitulo.Top + EtiquetaTitulo.Height;
                        e.Graphics.DrawLine(new System.Drawing.Pen(this.DisplayStyle.DarkColor), 0, y, this.Width - 1, y);
                }

                public override void ApplyStyle()
                {
                        this.EtiquetaTitulo.ApplyStyle();
                }


                [EditorBrowsable(EditorBrowsableState.Always),
                        Browsable(true),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                public override string Text
                {
                        get
                        {
                                return base.Text;
                        }
                        set
                        {
                                base.Text = value;
                                EtiquetaTitulo.Text = value;
                                EtiquetaTitulo.Visible = (value.Length > 0);
                                this.Refresh();
                        }
                }
        }


        /* public class FrameDesigner : System.Windows.Forms.Design.ParentControlDesigner
        {
                public override void Initialize(System.ComponentModel.IComponent component)
                {
                        base.Initialize(component);

                        if (this.Control is Lui.Forms.Frame) {
                                this.EnableDesignMode(((Lui.Forms.Frame)this.Control).ContainerPanel, "ContainerPanel");
                        }
                }
        } */
}