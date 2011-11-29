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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lui.Forms
{
	internal partial class DataSetHelp : System.Windows.Forms.Form
	{

		private string[] m_SetData = new string[1];
                private string[] m_SetDataText = new string[1];
                private string[] m_SetDataKey = new string[1];
		private int m_SetIndex;
                private string m_TextKey;
		private int IdealHeight = 118, LineHeight = 0;

                [System.ComponentModel.Browsable(false),
                        System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
                public Lui.Forms.ComboBox ControlDestino { get; set; }

		[System.ComponentModel.Category("Comportamiento")]
		public string[] SetData
		{
			get
			{
				return m_SetData;
			}
			set
			{
				m_SetData = value;

				if (m_SetData == null)
				{
					m_SetIndex = -1;
				}
				else
				{
					int TamanoSet = m_SetData.GetUpperBound(0);
					m_SetDataText = new string[TamanoSet + 1];
					m_SetDataKey = new string[TamanoSet + 1];

					for (int i = 0; i <= TamanoSet; i++)
					{
						string sItem = m_SetData[i];
						m_SetDataText[i] = Lfx.Types.Strings.GetNextToken(ref sItem, "|");
						m_SetDataKey[i] = sItem;
					}

					Listado.Items.Clear();
					for (int i = m_SetDataText.GetLowerBound(0); i <= m_SetDataText.GetUpperBound(0); i++)
					{
                                                if (m_SetDataText[i] == null)
                                                        Listado.Items.Add("");
                                                else
                                                        Listado.Items.Add(m_SetDataText[i]);
					}

					if(LineHeight == 0) {
						Graphics a = this.CreateGraphics();
						LineHeight = System.Convert.ToInt32(a.MeasureString("Hj", Listado.Font).Height);
						a.Dispose();
						a = null;
					}
					this.IdealHeight = LineHeight * (m_SetDataText.GetUpperBound(0) + 1) + (Listado.Top * 2);
					if (IdealHeight > 240)
						IdealHeight = 240;

					DetectarSetIndex();
				}
			}
		}

		[System.ComponentModel.Category("Apariencia")]
		public string TextKey
		{
			get
			{
				if (m_SetIndex >= 0)
				{
					return m_SetDataKey[m_SetIndex];
				}
				else
				{
					return "";
				}
			}
			set
			{
				m_TextKey = value;
				DetectarSetIndex();
				Timer1.Enabled = false;
				Timer1.Enabled = true;
                                this.Mostrar();
			}
		}

		private void DetectarSetIndex()
		{
			// Detecta el SetIndex que le corresponde al TextKey actual
			if (m_SetDataKey.GetLength(0) > 0)
			{
				bool Found = false;
				for (int i = 0; i <= m_SetDataKey.GetUpperBound(0); i++)
				{
					if (m_SetDataKey[i] == m_TextKey)
					{
						m_SetIndex = i;
						Listado.SelectedIndex = i;
						Found = true;
						break;
					}
				}
				if (!Found)
				{
					for (int i = 0; i <= m_SetDataKey.GetUpperBound(0); i++)
					{
                                                if (m_SetData != null && m_SetData[i] == m_TextKey)
						{
							m_SetIndex = i;
							Listado.SelectedIndex = i;
							break;
						}
					}
				}
			}
		}


		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			Timer1.Enabled = false;
			for (int n = 99; n >= 1; n -= 5)
			{
				this.Opacity = (double)(n / 100F);
				this.Refresh();
				System.Threading.Thread.Sleep(10);
			}
			this.Ocultar();
		}


		private void FormAyudaDataSet_VisibleChanged(object sender, System.EventArgs e)
		{
                        if (this.Visible)
                                Timer1.Enabled = true;
		}


		public void Ocultar()
		{
                        // Permito procesar un clic
                        System.Windows.Forms.Application.DoEvents();
                        System.Threading.Thread.Sleep(1);

			Timer1.Enabled = false;
			//this.Visible = false;
			this.Size = new Size(0, 0);
			this.Location = new Point(30000, 30000);
			//Para que no se muestre en Alt-Tab
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		}


                public void Mostrar()
		{
			this.FormBorderStyle = FormBorderStyle.None;
                        this.Ubicar();
			if (this.Visible == false)
				this.Visible = true;
		}


                public void Mostrar(Lui.Forms.ComboBox parentControl)
                {
                        this.ControlDestino = parentControl;
                        this.Size = new Size(parentControl.Width, IdealHeight);
                        this.Mostrar();
                }


                // Ubica la ventana con respecto al ControlDestino
                public void Ubicar()
                {
                        if (ControlDestino != null)
                                this.Location = ControlDestino.PointToScreen(new Point(0, ControlDestino.Height - 2));
                }


		private void Listado_Click(object sender, System.EventArgs e)
		{
                        if (Listado.SelectedIndex >= 0 && Listado.SelectedIndex < m_SetDataKey.Length) {
                                string Key = this.m_SetDataKey[Listado.SelectedIndex];
                                if (Key != null && Key.Length > 0 && this.ControlDestino != null)
                                        this.ControlDestino.TextKey = Key;
                        }
                        if (this.ControlDestino != null)
                                this.ControlDestino.Focus();
		}


                private void Listado_MouseEnter(object sender, EventArgs e)
                {
                        this.Timer1.Stop();
                }


                private void Listado_MouseLeave(object sender, EventArgs e)
                {
                        if (this.Visible)
                                this.Timer1.Start();
                }
	}
}