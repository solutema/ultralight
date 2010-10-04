#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	public partial class ChildForm : Lui.Forms.Form
	{
                public int Uid;
                private ToolBar m_ParentToolBar = null;
                private ToolBarButton m_MyToolBarButton = null;

		public ChildForm()
		{
			InitializeComponent();

                        this.Uid = new Random().Next();
		}

                internal ToolBarButton MyToolBarButton
                {
                        get
                        {
                                return m_MyToolBarButton;
                        }
                }

                internal ToolBar ParentToolBar
                {
                        get
                        {
                                if (m_ParentToolBar == null && this.MdiParent != null) {
                                        foreach (System.Windows.Forms.Control TmpCtl in this.MdiParent.Controls) {
                                                if (TmpCtl is System.Windows.Forms.ToolBar && TmpCtl.Name == "BarraTareas")
                                                        m_ParentToolBar = (ToolBar)TmpCtl;
                                        }
                                }
                                return m_ParentToolBar;
                        }
                }

                private void ChildForm_Load(object sender, System.EventArgs e)
                {
                        m_MyToolBarButton = new ToolBarButton(this.Text); ;
                        m_MyToolBarButton.Tag = this.Uid;
                        m_MyToolBarButton.ImageIndex = 0;
                        m_MyToolBarButton.Pushed = true;
                        if (this.ParentToolBar != null)
                                this.ParentToolBar.Buttons.Add(m_MyToolBarButton);

                        if (this.MdiParent != null)
                                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                }

                private void ChildForm_Activated(object sender, System.EventArgs e)
                {
                        try {
                                if (this.ParentToolBar != null && this.ParentToolBar.Buttons != null) {
                                        foreach (System.Windows.Forms.ToolBarButton Btn in this.ParentToolBar.Buttons) {
                                                Btn.Pushed = ((int)Btn.Tag) == this.Uid;
                                        }
                                }
                        } catch {
                                // Nada
                        }
                }

		protected override void OnTextChanged(System.EventArgs e)
		{
                        if (this.MyToolBarButton != null)
                                this.MyToolBarButton.Text = this.Text;
		}

		private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
		{
                        if (this.ParentToolBar != null && this.MyToolBarButton != null)
                                this.ParentToolBar.Buttons.Remove(this.MyToolBarButton);
		}
	}
}