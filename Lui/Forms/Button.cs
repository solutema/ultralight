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

using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	/// <summary>
	/// Control botón estándar.
	/// </summary>
	public class Button : Control, IButtonControl
	{
		private SubLabelPositions m_SubLabelPos = SubLabelPositions.None;
		private ImagePositions m_ImagePos = ImagePositions.Top;
                private System.Windows.Forms.DialogResult m_DialogResult = DialogResult.None;

		new public event System.EventHandler Click;
		new public event System.Windows.Forms.KeyEventHandler KeyDown;

		#region Código generado por el Diseñador de Windows Forms

		public Button()
			: base()
		{
			// Necesario para admitir el Diseñador de Windows Forms
			InitializeComponent();

			MainText.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonFace;
			MainText.ForeColor = Lfx.Config.Display.CurrentTemplate.ButtonText;
			SubText.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonSubBackground;
			SubText.ForeColor = Lfx.Config.Display.CurrentTemplate.ButtonSubText;
			this.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonBackground;
			this.BorderStyle = BorderStyles.Button;
		}

		// Limpiar los recursos que se estén utilizando.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


		// Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.Label MainText;
		internal System.Windows.Forms.Label SubText;
		private System.Windows.Forms.PictureBox IconPicture;

		private void InitializeComponent()
		{
			this.MainText = new System.Windows.Forms.Label();
			this.SubText = new System.Windows.Forms.Label();
			this.IconPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// MainText
			// 
			this.MainText.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(231)), ((System.Byte)(226)), ((System.Byte)(222)));
			this.MainText.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F);
			this.MainText.ForeColor = System.Drawing.Color.Black;
			this.MainText.Location = new System.Drawing.Point(4, 4);
			this.MainText.Name = "MainText";
			this.MainText.Size = new System.Drawing.Size(312, 60);
			this.MainText.TabIndex = 1;
			this.MainText.Text = "Command asdasd";
			this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MainText.Click += new System.EventHandler(this.MainText_Click);
			this.MainText.DoubleClick += new System.EventHandler(this.MainText_DoubleClick);
			this.MainText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainText_MouseDown);
			// 
			// SubText
			// 
			this.SubText.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(198)), ((System.Byte)(190)), ((System.Byte)(176)));
			this.SubText.Font = new System.Drawing.Font("Bitstream Vera Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.SubText.Location = new System.Drawing.Point(4, 68);
			this.SubText.Name = "SubText";
			this.SubText.Size = new System.Drawing.Size(312, 8);
			this.SubText.TabIndex = 2;
			this.SubText.Text = "Tecla";
			this.SubText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.SubText.Visible = false;
			this.SubText.Click += new System.EventHandler(this.SubText_Click);
			this.SubText.DoubleClick += new System.EventHandler(this.SubText_DoubleClick);
			// 
			// IconPicture
			// 
			this.IconPicture.BackColor = System.Drawing.Color.Transparent;
			this.IconPicture.Location = new System.Drawing.Point(4, 4);
			this.IconPicture.Name = "IconPicture";
			this.IconPicture.Size = new System.Drawing.Size(44, 40);
			this.IconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.IconPicture.TabIndex = 3;
			this.IconPicture.TabStop = false;
			this.IconPicture.Visible = false;
			// 
			// Button
			// 
			this.Controls.Add(this.IconPicture);
			this.Controls.Add(this.SubText);
			this.Controls.Add(this.MainText);
			this.DockPadding.All = 2;
			this.Name = "Button";
			this.Size = new System.Drawing.Size(320, 80);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button_KeyPress);
			//base, no this!
			base.Click += new System.EventHandler(this.Button_Click);
			this.LostFocus += new System.EventHandler(this.Button_LostFocus);
			this.GotFocus += new System.EventHandler(this.Button_GotFocus);
			this.SizeChanged += new System.EventHandler(this.Button_SizeChanged);
			//base, no this!
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_KeyDown);
			this.DoubleClick += new System.EventHandler(this.Button_DoubleClick);
			this.ResumeLayout(false);

		}


		#endregion

		[EditorBrowsable(EditorBrowsableState.Always), System.ComponentModel.Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override string Text
		{
			get
			{
				return MainText.Text;
			}
			set
			{
				MainText.Text = value;
				base.Text = "";
			}
		}

		public System.Drawing.Image Image
		{
			get
			{
				return IconPicture.Image;
			}
			set
			{
				IconPicture.Image = value;
				IconPicture.Visible = (value != null);
				this.ReubicarTodo();
			}
		}


		public ImagePositions ImagePos
		{
			get
			{
				return m_ImagePos;
			}
			set
			{
				m_ImagePos = value;
				this.ReubicarTodo();
			}
		}

		public SubLabelPositions SubLabelPos
		{
			get
			{
				return m_SubLabelPos;
			}
			set
			{
				m_SubLabelPos = value;
				this.ReubicarTodo();
			}
		}

		private void ReubicarTodo()
		{
			const int SmallSubTextHeight = 12;
			const int SmallSubTextWidth = 12;
			int HorizontalMargin = 4;
			int VerticalMargin = 4;

			if (m_SubLabelPos == SubLabelPositions.LongBottom)
			{
				HorizontalMargin = 6;
				VerticalMargin = 6;
			}

			this.SuspendLayout();
			if (this.IconPicture.Visible)
			{
				//Si hay imagen, el texto principal a la derecha de la imagen
				IconPicture.Left = HorizontalMargin;
				if (m_ImagePos == ImagePositions.Middle)
					IconPicture.Top = (this.Height - IconPicture.Height) / 2;
				else
					IconPicture.Top = VerticalMargin;
				MainText.Left = IconPicture.Width + IconPicture.Left + HorizontalMargin;
			}
			else
			{
				//Si no hay imagen, el texto principal contra el margen derecho
				MainText.Left = HorizontalMargin;
			}

			switch (m_SubLabelPos)
			{
				case SubLabelPositions.None:
					//No hay subtexto, el texto ocupa todo
					MainText.Width = this.Width - MainText.Left - HorizontalMargin;
					MainText.Height = this.Height - (VerticalMargin * 2);
					MainText.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;

					SubText.Visible = false;
					break;
				case SubLabelPositions.Bottom:
					//Subtexto pequeño abajo, texto ocupando el resto
					MainText.Width = this.Width - MainText.Left - HorizontalMargin;
					MainText.Height = this.Height - SmallSubTextHeight - (VerticalMargin * 2);
					MainText.TextAlign = ContentAlignment.MiddleCenter;
					MainText.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;

					SubText.Left = MainText.Left;
					SubText.Width = MainText.Width;
					SubText.Height = SmallSubTextHeight;
					SubText.Top = MainText.Top + MainText.Height;
					SubText.TextAlign = ContentAlignment.MiddleCenter;
					SubText.Font = Lfx.Config.Display.CurrentTemplate.SmallerFont;

					SubText.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonSubBackground;
					SubText.ForeColor = Lfx.Config.Display.CurrentTemplate.ButtonSubText;
					SubText.Visible = true;
					break;
				case SubLabelPositions.Right:
					//Subtexto pequeño a la derecha, texto ocupando el resto
					MainText.Width = this.Width - MainText.Left - HorizontalMargin - SmallSubTextWidth;
					MainText.Height = this.Height - VerticalMargin * 2;
					MainText.TextAlign = ContentAlignment.MiddleCenter;
					MainText.Font = Lfx.Config.Display.CurrentTemplate.DefaultFont;

					SubText.Size = new Size(SmallSubTextWidth, this.Height - VerticalMargin * 2);
					SubText.Location = new Point(this.Width - SubText.Width - HorizontalMargin, MainText.Top);
					SubText.TextAlign = ContentAlignment.MiddleCenter;
					SubText.Font = Lfx.Config.Display.CurrentTemplate.SmallerFont;

					SubText.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonSubBackground;
					SubText.ForeColor = Lfx.Config.Display.CurrentTemplate.ButtonSubText;
					SubText.Visible = true;
					break;
				case SubLabelPositions.LongBottom:
					//Subtexto pequeño abajo, texto ocupando el resto
					MainText.Width = this.Width - MainText.Left - HorizontalMargin;
					if (IconPicture.Visible && m_ImagePos == ImagePositions.Top)
						MainText.Height = IconPicture.Height + (VerticalMargin * 2);
					else
						MainText.Height = 22;
					MainText.TextAlign = ContentAlignment.MiddleLeft;
					MainText.Font = Lfx.Config.Display.CurrentTemplate.TitleFont;

					SubText.Left = MainText.Left;
					SubText.Width = MainText.Width;
					SubText.Top = MainText.Top + MainText.Height;
					SubText.Height = this.Height - SubText.Top - VerticalMargin;
					SubText.TextAlign = ContentAlignment.TopLeft;
					SubText.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonFace;
					SubText.ForeColor = Lfx.Config.Display.CurrentTemplate.ButtonText;
					SubText.Font = Lfx.Config.Display.CurrentTemplate.SmallFont;

					SubText.Visible = true;
					break;
			}
			this.ResumeLayout();
		}

		public string Subtext
		{
			get
			{
				return SubText.Text;
			}
			set
			{
				SubText.Text = value;
			}
		}

		private void Button_GotFocus(object sender, System.EventArgs e)
		{
			//MainText.BackColor = Lfx.Config.Display.CurrentTemplate.Selection;
			//MainText.ForeColor = Lfx.Config.Display.CurrentTemplate.SelectionText;
			this.Highlighted = true;
		}


		private void Button_LostFocus(object sender, System.EventArgs e)
		{
			//MainText.BackColor = Lfx.Config.Display.CurrentTemplate.ButtonBackground;
			//MainText.ForeColor = Lfx.Config.Display.CurrentTemplate.ButtonText;
			this.Highlighted = false;
		}


		private void MainText_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Focus();
		}

		private void Button_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case Lfx.Types.ControlChars.Cr:
				case Lfx.Types.ControlChars.Space:
					if (this.Enabled)
					{
						e.Handled = true;
						if (null != Click) Click(sender, e);
					}
					break;
			}
		}

		private void MainText_Click(System.Object sender, System.EventArgs e)
		{
			this.Focus();
			if (this.Enabled && this.Click != null)
			{
				Click(sender, e);
			}
		}

		private void MainText_DoubleClick(object sender, System.EventArgs e)
		{
			this.Focus();
			if (this.Enabled && this.Click != null)
			{
				Click(sender, e);
			}
		}


		private void SubText_Click(System.Object sender, System.EventArgs e)
		{
			this.Focus();
			if (this.Enabled)
				if (null != Click) Click(sender, e);
		}


		private void SubText_DoubleClick(object sender, System.EventArgs e)
		{
			this.Focus();
			if (this.Enabled)
				if (null != Click) Click(sender, e);
		}


		private void Button_Click(object sender, System.EventArgs e)
		{
			this.Focus();
			if (this.Enabled)
				if (Click != null) Click(sender, e);
		}

		private void Button_DoubleClick(object sender, System.EventArgs e)
		{
			this.Focus();
			if (this.Enabled)
				if (null != Click) Click(sender, e);
		}

		private void Button_SizeChanged(object sender, System.EventArgs e)
		{
			this.ReubicarTodo();
		}

		private void Button_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down) {
				e.Handled = true;
				System.Windows.Forms.SendKeys.Send("{tab}");
			} else if (e.KeyCode == Keys.Up) {
				e.Handled = true;
				System.Windows.Forms.SendKeys.Send("+{tab}");
			} else {
				if (null != KeyDown)
					KeyDown(sender, e);
			}
		}

                //IButtonControl
                public void NotifyDefault(bool value)
                {
                        //TODO: implementar
                        return;
                }

                public void PerformClick()
                {
                        if (this.Enabled && this.Visible)
                                this.OnClick(EventArgs.Empty);
                }

                public System.Windows.Forms.DialogResult DialogResult
                {
                        get
                        {
                                return this.m_DialogResult;
                        }

                        set
                        {
                                if (Enum.IsDefined(typeof(System.Windows.Forms.DialogResult), value)) {
                                        this.m_DialogResult = value;
                                }
                        }
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                        base.OnPaint(e);

                        if (m_Highlighted) {
                                e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(1, 0, this.Width - 3, this.Height - 1));
                                e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.Selection), new System.Drawing.Rectangle(0, 1, this.Width - 1, this.Height - 3));
                        } else {
                                e.Graphics.DrawRectangle(new System.Drawing.Pen(Lfx.Config.Display.CurrentTemplate.ButtonBorder), new System.Drawing.Rectangle(1, 1, this.Width - 3, this.Height - 3));
                        }
                }
		
		protected override bool ProcessMnemonic (char charCode)
		{
			if (this.Enabled && this.Visible && IsMnemonic(charCode, this.Text)) {
				this.Focus();
				this.PerformClick();
				return true;
			} else {
				return base.ProcessMnemonic (charCode);
			}
		}

	}
}