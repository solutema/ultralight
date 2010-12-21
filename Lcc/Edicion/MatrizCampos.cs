#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Edicion
{
        public partial class MatrizCampos : ControlEdicion
        {
                public MatrizCampos()
                {
                        InitializeComponent();

                        this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                        this.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;
                        GroupLabel.BackColor = Lfx.Config.Display.CurrentTemplate.Header2Background;
                        GroupLabel.ForeColor = Lfx.Config.Display.CurrentTemplate.Header2Text;
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
                                base.Text = value;
                        }
                }


                public int AutoLabelWidth
                {
                        get
                        {
                                int MaxWidth = 0;
                                foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                        if (Ctl is Entrada.Campo) {
                                                if (((Entrada.Campo)Ctl).AutoLabelWidth > MaxWidth)
                                                        MaxWidth = ((Entrada.Campo)Ctl).AutoLabelWidth;
                                        }
                                }
                                return MaxWidth;
                        }
                }


                private void FieldContainer_ControlAdded(object sender, ControlEventArgs e)
                {
                        int Y = 0;
                        e.Control.Width = FieldContainer.ClientSize.Width - FieldContainer.Margin.Left - FieldContainer.Margin.Right;
                        //Pongo los anchos de las etiquetas para todos los fields iguales (busco el mayor)
                        int MaxHeight = 0;
                        foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                if (Ctl is Entrada.Campo) {
                                        Ctl.Top = Y;
                                        ((Entrada.Campo)Ctl).LabelWidth = this.AutoLabelWidth;
                                        Y += Ctl.Height + 4;
                                }
                                if (Ctl.Top + Ctl.Height > MaxHeight)
                                        MaxHeight = Ctl.Top + Ctl.Height;
                        }
                        FieldContainer.Height = MaxHeight;

                        this.Height = FieldContainer.Top + FieldContainer.Height;
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
                                        if (Ctl is Entrada.Campo && ((Entrada.Campo)Ctl).FieldName == fieldName) {
                                                return ((Entrada.Campo)Ctl).FieldValue;
                                        }
                                }
                                return null;
                        }
                        set
                        {
                                foreach (System.Windows.Forms.Control Ctl in FieldContainer.Controls) {
                                        if (Ctl is Entrada.Campo && ((Entrada.Campo)Ctl).FieldName == fieldName) {
                                                ((Entrada.Campo)Ctl).FieldValue = value;
                                        }
                                }
                        }
                }
        }
}
