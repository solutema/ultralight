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
        public partial class LuiControl : UserControl
        {
                private Lws.Workspace m_Workspace;

                public LuiControl()
                {
                        InitializeComponent();
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lws.Workspace Workspace
                {
                        get
                        {
                                //Busco un Workspace en mi parent
                                if (m_Workspace == null) {
                                        m_Workspace = FindMyWorkspace(this.ParentForm);
                                        if (m_Workspace != null)
                                                this.WorkspaceChanged();
                                }
                                return m_Workspace;
                        }
                        set
                        {
                                m_Workspace = value;
                                this.WorkspaceChanged();
                        }
                }


                protected virtual void WorkspaceChanged()
                {
                        return;
                }

                private Lws.Workspace FindMyWorkspace(System.Windows.Forms.Control whereToFind)
                {
                        if (whereToFind is Lui.Forms.Form)
                                return ((Lui.Forms.Form)whereToFind).Workspace;
                        else if (whereToFind is System.Windows.Forms.Form && ((Form)whereToFind).Owner != null)
                                return FindMyWorkspace(((Form)whereToFind).Owner);
                        else if (whereToFind != null && whereToFind.Parent != null)
                                return FindMyWorkspace(whereToFind.Parent);
                        else if (whereToFind != null && ((Form)whereToFind).MdiParent != null)
                                return FindMyWorkspace(((Form)whereToFind).MdiParent);
                        else
                                return null;
                }

                [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                public override string Text
                {
                        get
                        {
                                return this.Text;
                        }
                        set
                        {
                                this.Text = value;
                        }
                }
        }
}
