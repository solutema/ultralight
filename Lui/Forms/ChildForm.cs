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
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	public partial class ChildForm : Lui.Forms.Form
	{
                public int Uid;
                private ToolStrip m_ParentToolStrip = null;
                private ToolStripButton m_MyToolStripButton = null;

		public ChildForm()
		{
			InitializeComponent();

                        this.Uid = new Random().Next();
		}

                protected override void Dispose(bool disposing)
                {
                        if (disposing) {
                                if (components != null) {
                                        components.Dispose();
                                }
                        }

                        if (m_MyToolStripButton != null) {
                                m_MyToolStripButton.Dispose();
                                m_MyToolStripButton = null;
                        }

                        base.Dispose(disposing);
                }


                protected ToolStripButton MyToolStripButton
                {
                        get
                        {
                                return m_MyToolStripButton;
                        }
                }


                private ToolStrip ParentToolStrip
                {
                        get
                        {
                                if (m_ParentToolStrip == null && this.MdiParent != null) {
                                        foreach (System.Windows.Forms.Control TmpCtl in this.MdiParent.Controls) {
                                                if (TmpCtl is System.Windows.Forms.ToolStrip && TmpCtl.Name == "BarraTareas")
                                                        m_ParentToolStrip = (ToolStrip)TmpCtl;
                                        }
                                }
                                return m_ParentToolStrip;
                        }
                }


                private void ChildForm_Load(object sender, System.EventArgs e)
                {
                        m_MyToolStripButton = new ToolStripButton(this.Text);
                        m_MyToolStripButton.Margin = new System.Windows.Forms.Padding(2);
                        m_MyToolStripButton.Padding = new System.Windows.Forms.Padding(2);
                        m_MyToolStripButton.Tag = this.Uid;
                        m_MyToolStripButton.Checked = true;
                        if (m_MyToolStripButton.Image != null)
                                m_MyToolStripButton.Image.Dispose();
                        m_MyToolStripButton.Image = this.Icon.ToBitmap();
                        if (this.ParentToolStrip != null)
                                this.ParentToolStrip.Items.Add(m_MyToolStripButton);

                        if (this.MdiParent != null)
                                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                }


                protected override void OnActivated(EventArgs e)
                {
                        try {
                                if (this.ParentToolStrip != null && this.ParentToolStrip.Items != null) {
                                        foreach (System.Windows.Forms.ToolStripButton Btn in this.ParentToolStrip.Items) {
                                                Btn.Checked = ((int)Btn.Tag) == this.Uid;
                                        }
                                }
                        } catch {
                                // Nada
                        }
                        base.OnActivated(e);
                }


                protected override void OnTextChanged(System.EventArgs e)
		{
                        if (this.MyToolStripButton != null) {
                                this.MyToolStripButton.Text = this.Text;
                                this.MyToolStripButton.Image = this.Icon.ToBitmap();
                        }

                        base.OnTextChanged(e);
		}


                protected override void OnFormClosing(FormClosingEventArgs e)
                {
                        if (e.Cancel == false) {
                                if (this.ParentToolStrip != null && this.ParentToolStrip.Items != null && this.MyToolStripButton != null)
                                        this.ParentToolStrip.Items.Remove(this.MyToolStripButton);
                        }
                        base.OnFormClosing(e);
		}

                public override string StockImage
                {
                        get
                        {
                                return base.StockImage;
                        }
                        set
                        {
                                base.StockImage = value;
                                if (value != null && this.MyToolStripButton != null) {
                                        this.MyToolStripButton.Image = (Image)(global::Lui.Properties.Resources.ResourceManager.GetObject(value));
                                }
                        }
                }
	}
}