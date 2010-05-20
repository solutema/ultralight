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
using System.Text;
using System.Windows.Forms;

namespace Lcc.Controles
{
        public class ContenedorCampos : FlowLayoutPanel
        {
                private bool m_AutoHeight = true;

                protected override void OnControlAdded(ControlEventArgs e)
                {
                        base.OnControlAdded(e);
                        this.ReloateChildren();
                }

                protected override void OnSizeChanged(EventArgs e)
                {
                        base.OnSizeChanged(e);
                        this.ReloateChildren();
                }

                private void ReloateChildren()
                {
                        int TotalHeight = 0;
                        foreach (Control Ctl in this.Controls) {
                                Ctl.Width = this.Width - (Ctl.Left * 2);
                                TotalHeight += Ctl.Height + Ctl.Margin.Top + Ctl.Margin.Bottom;
                        }
                        
                        if (m_AutoHeight && TotalHeight > 0)
                                this.Height = TotalHeight + this.Padding.Top + this.Padding.Bottom;

                        // Igualo el ancho de todos los labels de los campos contenidos.
                        int MaxWidth = 0;
                        foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                if (Ctl is Lcc.Controles.Datos.Campo)
                                        if (((Lcc.Controles.Datos.Campo)Ctl).AutoLabelWidth > MaxWidth)
                                                MaxWidth = ((Lcc.Controles.Datos.Campo)Ctl).AutoLabelWidth;
                        }

                        if (MaxWidth > 0) {
                                foreach (System.Windows.Forms.Control Ctl in this.Controls) {
                                        if (Ctl is Lcc.Controles.Datos.Campo)
                                                ((Lcc.Controles.Datos.Campo)Ctl).LabelWidth = MaxWidth;
                                }
                        }
                }

                #region Propiedades

                public virtual bool AutoHeight
                {
                        get
                        {
                                return m_AutoHeight;
                        }
                        set
                        {
                                m_AutoHeight = value;
                        }
                }

                #endregion
        }
}
