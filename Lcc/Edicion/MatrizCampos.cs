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
                public List<Campo> Campos;

                public MatrizCampos()
                {
                        this.Campos = new List<Campo>();

                        InitializeComponent();

                        this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
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


                public void AgregarCampo(string label, Lui.Forms.EditableControl control)
                {
                        Lui.Forms.Label Lbl = new Lui.Forms.Label();
                        Lbl.AutoSize = true;
                        Lbl.Text = label;
                        Lbl.Tag = control;
                        Lbl.UseMnemonic = false;
                        
                        this.FieldContainer.Controls.Add(Lbl);
                        this.FieldContainer.Controls.Add(control);

                        Lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                        control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

                        this.Campos.Add(new Campo(control, Lbl));

                        this.ReLayout();
                }


                public void EliminarCampos()
                {
                        this.FieldContainer.Controls.Clear();
                        this.Campos.Clear();
                }


                private void ReLayout()
                {
                        if (this.Campos == null)
                                return;

                        int MaxLabelWidth = 0;
                        foreach (Campo Cmp in this.Campos) {
                                if (Cmp.Etiqueta.Width > MaxLabelWidth)
                                        MaxLabelWidth = Cmp.Etiqueta.Width;
                        }

                        int Y = 0;
                        foreach (Campo Cmp in this.Campos) {
                                Cmp.Etiqueta.Location = new Point(0, Y);
                                Cmp.ControlEntrada.Location = new Point(MaxLabelWidth + 4, Y);
                                Cmp.ControlEntrada.Width = this.ClientRectangle.Width - Cmp.ControlEntrada.Left;

                                Y += Cmp.ControlEntrada.Height + 4;
                        }
                        this.FieldContainer.Height = Y;
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
