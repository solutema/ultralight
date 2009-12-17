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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class FieldGroup : LuiControl
        {
                public FieldGroup()
                {
                        InitializeComponent();

                        this.BackColor = Lws.Config.Display.CurrentTemplate.WindowBackground;
                        this.Font = Lws.Config.Display.CurrentTemplate.DefaultFont;
                }

                public override string Text
                {
                        get
                        {
                                return GroupLabel.Text;
                        }
                        set
                        {
                                GroupLabel.Text = value;
                        }
                }

                public int AutoLabelWidth
                {
                        get
                        {
                                int MaxWidth = 0;
                                foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                        if (Ctl is Field) {
                                                if (((Field)Ctl).AutoLabelWidth > MaxWidth)
                                                        MaxWidth = ((Field)Ctl).AutoLabelWidth;
                                        }
                                }
                                return MaxWidth;
                        }
                }

                private void FieldContainer_ControlAdded(object sender, ControlEventArgs e)
                {
                        e.Control.Width = FieldContainer.ClientSize.Width - FieldContainer.Margin.Left - FieldContainer.Margin.Right;
                        //Pongo los anchos de las etiquetas para todos los fields iguales (busco el mayor)
                        foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                if (Ctl is Field) {
                                        ((Field)Ctl).LabelWidth = this.AutoLabelWidth;
                                }
                        }
                }

                private void FieldContainer_ClientSizeChanged(object sender, EventArgs e)
                {
                        foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                Ctl.Width = this.FieldContainer.ClientRectangle.Width - FieldContainer.Margin.Left - FieldContainer.Margin.Right;
                        }
                }

                public object this[string fieldName]
                {
                        get
                        {
                                foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                        if (Ctl is Field && ((Field)Ctl).FieldName == fieldName) {
                                                return ((Field)Ctl).FieldValue;
                                        }
                                }
                                return null;
                        }
                        set
                        {
                                foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                        if (Ctl is Field && ((Field)Ctl).FieldName == fieldName) {
                                                ((Field)Ctl).FieldValue = value;
                                        }
                                }
                        }
                }
        }
}
