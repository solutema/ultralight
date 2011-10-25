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

namespace Lui.Forms
{
        public class EditableControl : Control, IEditableControl
        {
                /// <summary>
                /// IDataControl
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool Changed
                {
                        get
                        {
                                if (this.GetControlsChanged(this.Controls, false))
                                        return true;
                                else
                                        return m_Changed;
                        }
                        set
                        {
                                m_Changed = value;
                                this.SetControlsChanged(this.Controls, value);
                                Invalidate();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                public override string Text
                {
                        get
                        {
                                return base.Text;
                        }
                        set
                        {
                                base.Text = value;
                                this.Changed = false;
                        }
                }

                protected void SetControlsChanged(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        if (controles == null)
                                return;

                        // Pongo los Changed en newValue
                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is IEditableControl) {
                                        ((IEditableControl)ctl).Changed = newValue;
                                } else if (ctl.Controls.Count > 0) {
                                        SetControlsChanged(ctl.Controls, newValue);
                                }
                        }
                }

                protected bool GetControlsChanged(System.Windows.Forms.Control.ControlCollection controls, bool showChanges)
                {
                        bool Result = false;
                        // Ver si algo cambió
                        foreach (System.Windows.Forms.Control ctl in controls) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is IEditableControl) {
                                        if (((IEditableControl)ctl).Changed)
                                                Result = true;
                                } else if (ctl.Controls.Count > 0) {
                                        if (GetControlsChanged(ctl.Controls, showChanges)) {
                                                //this.Changed = true;
                                                Result = true;
                                        }
                                }
                        }
                        return Result;
                }
        }
}
