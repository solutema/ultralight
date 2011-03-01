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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
        public partial class Form : System.Windows.Forms.Form, IDataForm
	{
                [DefaultValue(true)]
                public bool DisposeConnection { get; set; }
                private Lfx.Data.Connection m_Connection = null;
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

                protected override void OnTextChanged(EventArgs e)
                {
                        if (m_Connection != null && this.Text != "Form")
                                m_Connection.Name = this.Text;

                        base.OnTextChanged(e);
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
                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool HasWorkspace
                {
                        get
                        {
                                return this.Workspace != null;
                        }
                }

                /// <summary>
                /// IDataControl
                /// </summary>
                public Lfx.Data.Connection Connection
                {
                        get
                        {
                                if (m_Connection == null && this.HasWorkspace) {
                                        m_Connection = this.Workspace.GetNewConnection(this.Text);

                                        // Marco para deshechar la conexión que estoy creando
                                        DisposeConnection = true;
                                }

                                return m_Connection;
                        }
                        set
                        {
                                if (m_Connection != value) {
                                        if (m_Connection != null && DisposeConnection)
                                                // Deshecho la conexión vieja
                                                m_Connection.Dispose();

                                        m_Connection = value;

                                        // Marco para no deshechar conexiones que fueron creadas por este formulario
                                        DisposeConnection = false;
                                }
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

                protected void SetControlsChanged(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        // Pongo los Changed en newValue
                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Control) {
                                        ((Lui.Forms.Control)ctl).Changed = newValue;
                                } else if (ctl is IDataControl) {
                                        ((IDataControl)ctl).Changed = newValue;
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
                                } else if (ctl is Lui.Forms.Control) {
                                        if (((Lui.Forms.Control)ctl).Changed) {
                                                Result = true;
                                                ((Lui.Forms.Control)ctl).ShowChanged = showChanges;
                                        }
                                } else if (ctl is IDataControl) {
                                        if (((IDataControl)ctl).Changed)
                                                Result = true;
                                } else if (ctl.Controls.Count > 0) {
                                        if (GetControlsChanged(ctl.Controls, showChanges))
                                                Result = true;
                                }
                        }
                        return Result;
                }


                protected override void OnKeyDown(KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.F1:
                                                if (ClicarBoton(this.Controls, "F1"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F2:
                                                if (ClicarBoton(this.Controls, "F2"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F3:
                                                if (ClicarBoton(this.Controls, "F3"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F4:
                                                if (ClicarBoton(this.Controls, "F4"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F5:
                                                if (ClicarBoton(this.Controls, "F5"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F6:
                                                if (ClicarBoton(this.Controls, "F6"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F7:
                                                if (ClicarBoton(this.Controls, "F7"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F8:
                                                if (ClicarBoton(this.Controls, "F8"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F9:
                                                if (ClicarBoton(this.Controls, "F9"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F10:
                                                if (ClicarBoton(this.Controls, "F10"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F11:
                                                if (ClicarBoton(this.Controls, "F11"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.F12:
                                                if (ClicarBoton(this.Controls, "F12"))
                                                        e.Handled = true;
                                                break;
                                        case Keys.Escape:
                                                if (ClicarBoton(this.Controls, "Esc"))
                                                        e.Handled = true;
                                                break;
                                }
                        }

                        if (e.Handled == false)
                                base.OnKeyDown(e);
                }

                private bool ClicarBoton(Control.ControlCollection controls, string keyName)
                {
                        foreach (System.Windows.Forms.Control ctl in controls) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Button) {
                                        Lui.Forms.Button Btn = ctl as Lui.Forms.Button;
                                        if (Btn.Subtext == keyName && Btn.Visible && Btn.Enabled) {
                                                Btn.PerformClick();
                                                return true;
                                        }
                                } else if (ctl.Controls != null) {
                                        if (ClicarBoton(ctl.Controls, keyName))
                                                return true;
                                }
                        }
                        return false;
                }
	}
}