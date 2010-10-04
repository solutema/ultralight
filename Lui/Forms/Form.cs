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
using System.ComponentModel;

namespace Lui.Forms
{
        public partial class Form : System.Windows.Forms.Form, IDataForm
	{
                private Lfx.Data.DataBase m_DataBase = null;
		public event System.EventHandler WorkspaceChanged;

		public Form()
		{
			InitializeComponent();
		}

		private void SetControlsFont(System.Windows.Forms.Control.ControlCollection controles)
		{
			this.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;
			//Cambio la fuente de todos los controles en el formulario
                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel) {
                                        SetControlsFont(ctl.Controls);
                                } else {
                                        //Cambiar fuente
                                        ctl.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;
                                }
                        }
		}

		private void Form_Load(object sender, System.EventArgs e)
		{
			if(this.BackColor == SystemColors.Control)
				this.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
			this.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;

                        EventHandler WorkspaceChangedHandler = this.WorkspaceChanged;
                        if (WorkspaceChangedHandler != null)
                                WorkspaceChangedHandler(this, null);
		}	

                private void Form_TextChanged(object sender, EventArgs e)
                {
                        if (m_DataBase != null)
                                m_DataBase.Name = this.Text;
                }

                /// <summary>
                /// IDataControl
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Workspace Workspace
                {
                        get
                        {
                                return Lfx.Workspace.Master;
                        }
                }

                /// <summary>
                /// IDataControl
                /// </summary>
                public Lfx.Data.DataBase DataBase
                {
                        get
                        {
                                if (m_DataBase == null && this.Workspace != null)
                                        m_DataBase = this.Workspace.GetDataBase(this.Text);

                                return m_DataBase;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool Changed
                {
                        get
                        {
                                return GetControlsChanged(this.Controls, false);
                        }
                        set
                        {
                                SetControlsChanged(this.Controls, value);
                        }
                }

                internal void SetControlsChanged(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        // Pongo los Changed en newValue
                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel) {
                                        SetControlsChanged(ctl.Controls, newValue);
                                } else if (ctl is Lui.Forms.Control) {
                                        ((Lui.Forms.Control)ctl).Changed = newValue;
                                } else if (ctl is IDataControl) {
                                        ((IDataControl)ctl).Changed = newValue;
                                }
                        }
                }

                internal bool GetControlsChanged(System.Windows.Forms.Control.ControlCollection controls, bool showChanges)
                {
                        bool Result = false;
                        // Ver si algo cambió
                        foreach (System.Windows.Forms.Control ctl in controls) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Frame || ctl is System.Windows.Forms.Panel) {
                                        // Es un conteneder. Uso recursión
                                        if (this.GetControlsChanged(ctl.Controls, showChanges))
                                                Result = true;
                                } else if (ctl is Lui.Forms.Control) {
                                        if (((Lui.Forms.Control)ctl).Changed) {
                                                Result = true;
                                                ((Lui.Forms.Control)ctl).ShowChanged = showChanges;
                                        }
                                } else if (ctl is IDataControl) {
                                        if (((IDataControl)ctl).Changed) {
                                                Result = true;
                                        }
                                }
                        }
                        return Result;
                }
	}
}