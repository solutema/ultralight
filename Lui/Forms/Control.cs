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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lui.Forms
{
	/// <summary>
	/// Clase base que define a un control.
	/// </summary>
	[Designer("System.Windows.Forms.Design.ControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner)),
                DefaultEvent("Click"),
                DefaultProperty("Text")]
        public partial class Control : System.Windows.Forms.UserControl, IDataControl
	{
		protected bool m_Highlighted;
                protected Lui.Forms.Control.BorderStyles m_BorderStyle = Lui.Forms.Control.BorderStyles.Control;
		protected bool m_Changed, m_ReadOnly, m_ShowChanged, m_AutoHeight = false;
		protected int m_IgnoreChanges;
		protected string m_ToolTipText = "";
		protected System.Windows.Forms.ToolTip ToolTipBalloon;
		protected string m_Error = "";

                [System.ComponentModel.EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
                new public event System.EventHandler TextChanged;

                // IDataControl
                private Lfx.Data.Connection m_DataBase = null;

		public enum BorderStyles
		{
			None = 0,
			Control,
			Frame,
			TextBox,
			Button
		}

                public Control()
                {
                        InitializeComponent();
                }

		[EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DefaultValue(""),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual string ErrorText
		{
			get
			{
				return m_Error;
			}
			set
			{
				m_Error = value;
				if (m_Error != null)
					this.ShowBalloon(m_Error);
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
				ControlCaption.Text = value;
				ControlCaption.Visible = (value.Length > 0);
				this.Refresh();
				this.Changed = false;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override System.Drawing.Color BackColor
		{
			get
			{
				return Lfx.Config.Display.CurrentTemplate.WindowBackground;
			}
		}

                [EditorBrowsable(EditorBrowsableState.Never), 
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool ReadOnly
		{
			get
			{
				return m_ReadOnly;
			}
			set
			{
				m_ReadOnly = value;
                                this.SetControlsReadOnly(this.Controls, value);
				Invalidate();
			}
		}


                /// <summary>
                /// Pongo la propiedad ReadOnly de los controles hijos en cascada.
                /// </summary>
                internal void SetControlsReadOnly(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        if (controles == null)
                                return;

                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Control) {
                                        ((Lui.Forms.Control)ctl).ReadOnly = newValue;
                                } else if (ctl.Controls != null && ctl.Controls.Count > 0) {
                                        SetControlsReadOnly(ctl.Controls, newValue);
                                }
                        }
                }


		protected override bool IsInputKey(Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Up:
				case Keys.Down:
				case Keys.Left:
				case Keys.Right:
					return true;
				default:
					return base.IsInputKey(keyData);
			}

		}


		[EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		protected new Lui.Forms.Control.BorderStyles BorderStyle
		{
			get
			{
				return m_BorderStyle;
			}
			set
			{
				m_BorderStyle = value;
				Invalidate();
			}
		}


		[EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Highlighted
		{
			get
			{
				return m_Highlighted;
			}
			set
			{
				m_Highlighted = value;
				Invalidate();
			}
		}


		public string ToolTipText
		{
			get
			{
				return m_ToolTipText;
			}
			set
			{
				m_ToolTipText = value;
			}
		}


		private void Control_Enter(object sender, System.EventArgs e)
		{
			this.Highlighted = true;
		}


		private void Control_Leave(object sender, System.EventArgs e)
		{
			this.Highlighted = false;
                        if (ToolTipBalloon != null) {
                                ToolTipBalloon.Dispose();
                                ToolTipBalloon = null;
                        }
		}


		public void ShowBalloon(string Texto)
		{
			ShowBalloon(Texto, "Información", 8);
		}


		public void ShowBalloon(string Texto, string Titulo, int Duracion)
		{
			if (this.Visible)
			{
				if (ToolTipBalloon == null)
					ToolTipBalloon = new ToolTip();
				ToolTipBalloon.ToolTipIcon = ToolTipIcon.Info;
				ToolTipBalloon.ToolTipTitle = Titulo;
				if(Duracion == 0)
					Duracion = 5;
				
				ToolTipBalloon.Show(Texto, this, new Point(0, this.Height + 2), Duracion * 1000);
			}
		}


		private void Control_TabStopChanged(object sender, System.EventArgs e)
		{
			Invalidate();
		}


		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		virtual public bool ShowChanged
		{
			set
			{
				m_ShowChanged = value;
				Invalidate();
			}
		}


		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			switch (m_BorderStyle)
			{
				case BorderStyles.Button:
					e.Graphics.Clear(Lfx.Config.Display.CurrentTemplate.ButtonFace);
					break;
				case BorderStyles.TextBox:
					e.Graphics.Clear(Lfx.Config.Display.CurrentTemplate.ControlDataarea);
					break;
				default:
					e.Graphics.Clear(Lfx.Config.Display.CurrentTemplate.WindowBackground);
					break;
			}

			switch (m_BorderStyle)
			{
				case BorderStyles.None:
					if (m_Highlighted)
						e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(0, 0, this.Width - 1, this.Height - 1));
					break;
				case BorderStyles.TextBox:
					e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.ControlBorder), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
					if (m_ShowChanged && m_Changed)
					{
						e.Graphics.DrawRectangle(new System.Drawing.Pen(Color.Red), new System.Drawing.Rectangle(3, this.Height - 2, this.Width - 6, 1));
					}
					else if (m_Highlighted)
					{
						if (m_ReadOnly)
						{
							e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.SelectionDisabled), new System.Drawing.Rectangle(0, 0, this.Width - 1, this.Height - 1));
							e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.SelectionDisabled), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
						}
						else
						{
							e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(1, 0, this.Width - 3, this.Height - 1));
							e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(0, 1, this.Width - 1, this.Height - 3));
							//e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(0, 0, this.Width - 1, this.Height - 1));
							//e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
						}
					}
					if (m_Error != null && m_Error.Length > 0 && m_ShowChanged == false)
						e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.SelectionError), new System.Drawing.Rectangle(3, this.Height - 2, this.Width - 6, 1));
					break;
			}

                        base.OnPaint(e);
		}


		private void Control_Resize(object sender, System.EventArgs e)
		{
			this.Invalidate();
		}


                /// <summary>
                /// IDataControl
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Workspace Workspace
                {
                        get
                        {
                                if (m_DataBase == null)
                                        return Lfx.Workspace.Master;
                                else
                                        return this.Connection.Workspace;
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
                                return this.Parent != null && this.Workspace != null;
                        }
                }


                /// <summary>
                /// IDataControl
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Data.Connection Connection
                {
                        get
                        {
                                if (m_DataBase == null) {
                                        System.Windows.Forms.Control MiParent = this.Parent;
                                        while (MiParent != null) {
                                                if (MiParent is Lui.Forms.IDataControl) {
                                                        m_DataBase = ((Lui.Forms.IDataControl)(MiParent)).Connection;
                                                        break;
                                                } else {
                                                        MiParent = MiParent.Parent;
                                                }
                                        }
                                }
                                return m_DataBase;
                        }
                }

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
                                        if (GetControlsChanged(ctl.Controls, showChanges)) {
                                                this.Changed = true;
                                                Result = true;
                                        }
                                }
                        }
                        return Result;
                }


                protected override void OnTextChanged(EventArgs e)
                {
                        EventHandler Tceh = this.TextChanged;
                        if (Tceh != null)
                                Tceh(this, e);

                        base.OnTextChanged(e);
                }
	}
}