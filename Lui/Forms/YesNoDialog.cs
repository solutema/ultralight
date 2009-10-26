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

namespace Lui.Forms
{
	public partial class YesNoDialog : DialogForm
	{
		public enum DialogButtons : int
		{
			YesNo = 0,
			AcceptCancel = 1,
			OkOnly = 2,
		}

		public enum DialogIcons : int
		{
			Question = 0,
			Information = 1,
			Exclamation = 2,
		}

		protected internal DialogButtons m_Respuestas = DialogButtons.YesNo;
		internal System.Windows.Forms.Label DialogCaption;
		private System.Windows.Forms.RichTextBox DialogText;
		protected internal DialogIcons m_Icono = DialogIcons.Question;

                public YesNoDialog(string messageText, string messageCaption)
                {
                        InitializeComponent();

                        this.MessageText = messageText;
                        this.MessageCaption = messageCaption;
                }

		public DialogIcons DialogIcon
		{
			get
			{
				return m_Icono;
			}
			set
			{
				m_Icono = value;
				pctInformation.Visible = m_Icono == DialogIcons.Information;
				pctExclamation.Visible = m_Icono == DialogIcons.Exclamation;
				pctQuestion.Visible = m_Icono == DialogIcons.Question;
			}
		}

		public DialogButtons DialogButton
		{
			get
			{
				return m_Respuestas;
			}
			set
			{
				m_Respuestas = value;

				switch (m_Respuestas)
				{
					case DialogButtons.YesNo:
						OkButton.Text = "Si";
						CancelCommandButton.Text = "No";
						CancelCommandButton.Visible = true;
						this.DialogIcon = DialogIcons.Question;
						break;

					case DialogButtons.AcceptCancel:
						OkButton.Text = "Aceptar";
						CancelCommandButton.Text = "Cancelar";
						CancelCommandButton.Visible = true;
						this.DialogIcon = DialogIcons.Question;
						break;

					case DialogButtons.OkOnly:
						OkButton.Text = "Aceptar";
						OkButton.Left = CancelCommandButton.Left;
						CancelCommandButton.Visible = false;
						OkButton.Left = CancelCommandButton.Left;
						this.DialogIcon = DialogIcons.Information;
						break;
				}
			}
		}

		public string MessageCaption
		{
			get
			{
				return DialogCaption.Text;
			}
			set
			{
				DialogCaption.Text = value;
			}
		}

		public string MessageText
		{
			get
			{
				return DialogText.Text;
			}
			set
			{
				if (value != null && value.Length > 5 && value.Substring(0, 5) == @"{\rtf")
				{
					//Es RTF
					DialogText.Rtf = value;
				}
				else
				{
					//Es texto plano
					DialogText.Text = value;
				}
			}
		}

		private void YesNoDialogForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control == true && e.Alt == false && e.Shift == false && e.KeyCode == Keys.C)
				Clipboard.SetDataObject(DialogText.Text);
		}

		private void YesNoDialog_Load(object sender, System.EventArgs e)
		{
			this.Size = new Size(480, 320);
			this.CenterToParent();
		}

		private void YesNoDialog_BackColorChanged(object sender, System.EventArgs e)
		{
			DialogText.BackColor = this.BackColor;
		}
	}
}