#region License
// Copyright 2004-2011 Carrea Ernesto N.
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
	/// <summary>
	/// Clase base que define a un control.
	/// </summary>
	[Designer("System.Windows.Forms.Design.ControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner)),
                DefaultEvent("Click"),
                DefaultProperty("Text")]
        public partial class Control : System.Windows.Forms.UserControl, IControl
	{
		protected bool m_Highlighted;
                protected Lui.Forms.Control.BorderStyles m_BorderStyle = Lui.Forms.Control.BorderStyles.Control;
                protected bool m_Changed, m_ReadOnly = false, m_TemporaryReadOnly = false, m_ShowChanged, m_AutoHeight = false;
                protected int IgnoreChanges { get; set; }
		protected string m_Error = "";

                [EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
                new public event System.EventHandler TextChanged;

                // IDataControl
                protected Lfx.Data.Connection m_DataBase = null;

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

                        base.BackColor = Lfx.Config.Display.CurrentTemplate.WindowBackground;
                }

		[EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
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
				Invalidate();
			}
		}


		[EditorBrowsable(EditorBrowsableState.Always),
                        Browsable(true),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		new protected System.Drawing.Color BackColor
		{
			get
			{
				return Lfx.Config.Display.CurrentTemplate.WindowBackground;
			}
		}

                /// <summary>
                /// Devuelve o establece si el control está temporalmente (o permanentemente) inhabilitado para realizar cambios.
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Never), 
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool TemporaryReadOnly
		{
			get
			{
				return m_TemporaryReadOnly || m_ReadOnly;
			}
			set
			{
				m_TemporaryReadOnly = value;
                                this.SetControlsTemporaryReadOnly(this.Controls, value);
				Invalidate();
			}
		}


                /// <summary>
                /// Devuelve o establece si se trata de un control sólo de lectura.
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Always),
                        System.ComponentModel.Browsable(true),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                public virtual bool ReadOnly
                {
                        get
                        {
                                return m_ReadOnly;
                        }
                        set
                        {
                                m_ReadOnly = value;
                                Invalidate();
                        }
                }


                /// <summary>
                /// Pongo la propiedad TemporaryReadOnly de los controles hijos en cascada.
                /// </summary>
                internal void SetControlsTemporaryReadOnly(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        if (controles == null)
                                return;

                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is Lui.Forms.Control) {
                                        ((Lui.Forms.Control)ctl).TemporaryReadOnly = newValue;
                                } else if (ctl.Controls != null && ctl.Controls.Count > 0) {
                                        SetControlsTemporaryReadOnly(ctl.Controls, newValue);
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


		private void Control_Enter(object sender, System.EventArgs e)
		{
			this.Highlighted = true;
		}


		private void Control_Leave(object sender, System.EventArgs e)
		{
			this.Highlighted = false;
		}


		private void Control_TabStopChanged(object sender, System.EventArgs e)
		{
			Invalidate();
		}


		[EditorBrowsable(EditorBrowsableState.Never),
                        Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		virtual public bool ShowChanged
		{
			set
			{
				m_ShowChanged = value;
                                this.ShowControlsChanged(this.Controls, value);
				Invalidate();
			}
		}


                private void ShowControlsChanged(System.Windows.Forms.Control.ControlCollection controles, bool newValue)
                {
                        if (controles == null)
                                return;

                        // Pongo los Changed en newValue
                        foreach (System.Windows.Forms.Control ctl in controles) {
                                if (ctl == null) {
                                        //Nada
                                } else if (ctl is IEditableControl) {
                                        ((IEditableControl)ctl).ShowChanged = newValue;
                                } else if (ctl.Controls.Count > 0) {
                                        ShowControlsChanged(ctl.Controls, newValue);
                                }
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

                        switch (m_BorderStyle) {
                                case BorderStyles.None:
                                        if (m_Highlighted) {
                                                e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(0, 0, this.Width - 1, this.Height - 1));
                                                e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
                                        }
                                        break;
                                case BorderStyles.TextBox:
                                        e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.ControlBorder), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
                                        if (m_ShowChanged && m_Changed) {
                                                e.Graphics.DrawRectangle(new System.Drawing.Pen(Color.Red), new System.Drawing.Rectangle(3, this.Height - 2, this.Width - 6, 1));
                                        } else if (m_Highlighted) {
                                                if (m_ReadOnly || m_TemporaryReadOnly) {
                                                        e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.SelectionDisabled), new System.Drawing.Rectangle(0, 0, this.Width - 1, this.Height - 1));
                                                        e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.SelectionDisabled), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
                                                } else {
                                                        e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(0, 0, this.Width - 1, this.Height - 1));
                                                        e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
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


                protected override void OnTextChanged(EventArgs e)
                {
                        EventHandler Tceh = this.TextChanged;
                        if (Tceh != null)
                                Tceh(this, e);

                        base.OnTextChanged(e);
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new protected Font Font
                {
                        get
                        {
                                return base.Font;
                        }
                        set
                        {
                                base.Font = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                new public Color ForeColor
                {
                        get
                        {
                                return base.ForeColor;
                        }
                }
	}
}