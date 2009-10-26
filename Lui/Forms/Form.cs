// Copyright 2004-2009 South Bridge S.R.L.
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
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lui.Forms
{
	public partial class Form : System.Windows.Forms.Form
	{
		private Lws.Workspace m_Workspace;
                private Lws.Data.DataView m_DataView = null;
		public event System.EventHandler WorkspaceChanged;

		public Form()
                        : base()
		{
			InitializeComponent();
		}

		private void SetControlsFont(System.Windows.Forms.Control.ControlCollection controles)
		{
			this.Font = Lws.Config.Display.CurrentTemplate.DefaultFont;
			//Cambio la fuente de todos los controles en el formulario
			foreach (System.Windows.Forms.Control ctl in controles)
			{
				if (ctl == null)
				{
					//Nada
				} else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel) {
                                        SetControlsFont(ctl.Controls);
                                } else {
                                        //Cambiar fuente
                                        ctl.Font = Lws.Config.Display.CurrentTemplate.DefaultFont;
                                }
			}
		}

		private void Form_Load(object sender, System.EventArgs e)
		{
			if(this.BackColor == SystemColors.Control)
				this.BackColor = Lws.Config.Display.CurrentTemplate.WindowBackground;
			this.Font = Lws.Config.Display.CurrentTemplate.DefaultFont;
		}	

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Lws.Workspace Workspace
		{
			get
			{
				if (m_Workspace == null)
				{
					if (this.Owner is Lui.Forms.Form)
						m_Workspace = ((Lui.Forms.Form)this.Owner).Workspace;
				}
				return m_Workspace;
			}
			set
			{
				m_Workspace = value;
				if (WorkspaceChanged != null)
					this.WorkspaceChanged(this, null);
			}
		}

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lws.Data.DataView DataView
                {
                        get
                        {
                                if (m_DataView == null)
                                        m_DataView = this.Workspace.GetDataView(true);
                                return m_DataView;
                        }
                }
	}
}