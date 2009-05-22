// Copyright 2004-2009 Carrea Ernesto N., Martínez Miguel A.
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
	internal partial class DetailBoxQuickSelect : System.Windows.Forms.Form
	{

		private string m_Table = "";
		private string m_KeyField = "";
		private string m_DetailField = "";
		private string m_ExtraDetailFields = "";
		private string m_Filter = "";
		private bool f_IgnoreEvents;
		private Lws.Workspace m_Workspace;
		public System.Windows.Forms.Control ControlDestino;

		internal bool CanCreate
		{
			set
			{
				cmdNuevo.Visible = value;
				if (value)
					txtBuscar.Width = cmdNuevo.Left - (txtBuscar.Left * 2);
				else
					txtBuscar.Width = this.ClientSize.Width - (txtBuscar.Left * 2);
			}
		}

		[System.ComponentModel.Category("Datos")]
		internal string Table
		{
			get
			{
				return m_Table;
			}
			set
			{
				m_Table = value;
				UpdateDetail();
			}
		}

		[System.ComponentModel.Category("Datos")]
		internal string KeyField
		{
			set
			{
				m_KeyField = value;
				UpdateDetail();
			}
		}

		[System.ComponentModel.Category("Datos")]
		internal string DetailField
		{
			set
			{
				m_DetailField = value;
				UpdateDetail();
			}
		}

		[System.ComponentModel.Category("Datos")]
		internal string ExtraDetailFields
		{
			set
			{
				m_ExtraDetailFields = value;
				UpdateDetail();
			}
		}

		[System.ComponentModel.Category("Datos")]
		internal string Filter
		{
			set
			{
				m_Filter = value;
				UpdateDetail();
			}
		}

		private void UpdateDetail()
		{
			int CamposExtra = 0;

			if (m_Table == "articulos" && (m_ExtraDetailFields == null || m_ExtraDetailFields.Length == 0))
				m_ExtraDetailFields = "codigo1,codigo2,codigo3,codigo4";

			if (m_Table == "personas" && (m_ExtraDetailFields == null || m_ExtraDetailFields.Length == 0))
				m_ExtraDetailFields = "num_doc,cuit,extra1";

			if (m_ExtraDetailFields != null)
				CamposExtra = m_ExtraDetailFields.Length - m_ExtraDetailFields.Replace(",", "").Length;

			if (CamposExtra > 4)
				CamposExtra = 4;

			this.Width = 480 + (80 * CamposExtra);
                        if (lvItems.Columns.Count > 0)
                                lvItems.Columns[1].Width = lvItems.Width - lvItems.Columns[0].Width - (80 * CamposExtra) - 20;

			if (CamposExtra >= 1)
				extra1.Width = 80;
			else
				extra1.Width = 0;

			if (CamposExtra >= 2)
				extra1.Width = 80;
			else
				extra2.Width = 0;

			if (CamposExtra >= 3)
				extra1.Width = 80;
			else
				extra3.Width = 0;

			if (CamposExtra >= 4)
				extra1.Width = 80;
			else
				extra4.Width = 0;
		}


                internal void Buscar(string valorInicial)
                {
                        Refrescar();
                        f_IgnoreEvents = true;
                        txtBuscar.Text = valorInicial.Trim();
                        f_IgnoreEvents = false;
                        txtBuscar.SelectionLength = 0;
                        txtBuscar.SelectionStart = txtBuscar.Text.Length;
                        this.Refrescar();
                        if (!this.Visible)
                                this.ShowDialog();
                }

		internal void Refrescar()
		{
			lvItems.Items.Clear();
			if (this.Workspace != null)
			{
				if (m_Table.Length > 0 && m_KeyField.Length > 0 && m_DetailField.Length > 0)
				{
					string TextoSql = null;
					string sBuscar = txtBuscar.Text;

                                        sBuscar = this.Workspace.DefaultDataView.DataBase.EscapeString(sBuscar.Replace("  ", " ").Trim());

					if (m_Table.Length >= 7 && m_Table.Substring(0, 7) == "SELECT ")
					{
						TextoSql = m_Table;
					}
					else
					{
						TextoSql = "SELECT " + m_KeyField + ", " + m_DetailField;
						if (m_ExtraDetailFields != null && m_ExtraDetailFields.Length > 0)
							TextoSql += ", " + m_ExtraDetailFields;

						// Si es la tabla de artículos, muestro algunas cosas más
						if (m_Table == "articulos")
							TextoSql += ", control_stock, stock_actual, pedido, destacado";

						TextoSql += " FROM " + m_Table;
						if (sBuscar != null && sBuscar.Length > 1)
							TextoSql += " WHERE (" + m_DetailField + " LIKE '%" + sBuscar.Replace(" ", "%' AND " + m_DetailField + " LIKE '%") + "%'";
						else if (sBuscar != null && sBuscar.Length > 0)
                                                        TextoSql += " WHERE (" + m_DetailField + " LIKE '" + this.Workspace.DefaultDataView.DataBase.EscapeString(sBuscar) + "%'";

						if (m_ExtraDetailFields != null && m_ExtraDetailFields.Length > 0 && sBuscar != null && sBuscar.Length > 1)
						{
							string TempExtraDetailFields = m_ExtraDetailFields;
							string TempWhere = "";
							string ExtraField = Lfx.Types.Strings.GetNextToken(ref TempExtraDetailFields, ",");
							while (ExtraField.Length > 0)
							{
								if (TempWhere.Length == 0)
									TempWhere += ExtraField + " LIKE '%" + sBuscar + "%'";
								else
									TempWhere += " OR " + ExtraField + " LIKE '%" + sBuscar + "%'";
								ExtraField = Lfx.Types.Strings.GetNextToken(ref TempExtraDetailFields, ",");
							}
							TextoSql += " OR (" + TempWhere + ")";
						}
						if (TextoSql.IndexOf(" WHERE ") != -1)
							TextoSql += ") ";

						if (m_Filter != null && m_Filter.Length > 0)
						{
							if (TextoSql.IndexOf(" WHERE ") != -1)
								TextoSql += " AND (" + m_Filter + ")";
							else
								TextoSql += " WHERE " + m_Filter;
						}

						if (m_Table == "articulos")
							TextoSql += " ORDER BY destacado DESC, " + m_DetailField;
						else
							TextoSql += " ORDER BY " + m_DetailField;

						// TODO: Código dependiente de MySql/PostgreSql. Pasar a Lfx.Data.SqlCommandBuilder
						if (this.Workspace.SlowLink)
							TextoSql += " LIMIT 40";
						else
							TextoSql += " LIMIT 100";
					}

                                        System.Data.DataTable dt = this.Workspace.DefaultDataView.DataBase.Select(TextoSql);
					lvItems.SuspendLayout();
					lvItems.BeginUpdate();
					foreach (System.Data.DataRow row in dt.Rows)
					{
						ListViewItem itm = lvItems.Items.Add(System.Convert.ToInt32(row[m_KeyField]).ToString("00000"));
						itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(row[m_DetailField])));
						if (m_ExtraDetailFields != null && m_ExtraDetailFields.Length > 0)
						{
							string TempExtraDetailFields = m_ExtraDetailFields;
							string Campo = Lfx.Types.Strings.GetNextToken(ref TempExtraDetailFields, ",").Trim();
							while (Campo.Length > 0)
							{
								switch (row[Campo].GetType().ToString())
								{
									case "System.Single":
									case "System.Decimal":
									case "System.Double":
										itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(row[Campo]))));
										break;
									default:
										itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(row[Campo])));
										break;
								}


								Campo = Lfx.Types.Strings.GetNextToken(ref TempExtraDetailFields, ",").Trim();
							}
						}
						// TODO: que tome m_ExtraDetailFields esto en cuenta
						if (m_Table == "articulos")
						{
							if (System.Convert.ToInt32(row["control_stock"]) != 0 && System.Convert.ToDouble(row["stock_actual"]) <= 0)
							{
								// No hay stock.
								if (System.Convert.ToDouble(row["pedido"]) + System.Convert.ToDouble(row["stock_actual"]) > 0)
								{
									// Pero hay pedido suficiente para cubrir un stock negativo y sobra
									itm.ForeColor = System.Drawing.Color.OrangeRed;
									itm.Font = new Font(itm.Font, FontStyle.Regular);
								}
								else
								{
									itm.ForeColor = System.Drawing.Color.Red;
									itm.Font = new Font(itm.Font, FontStyle.Strikeout);
								}
							}
							else if (System.Convert.ToInt32(row["destacado"]) != 0)
							{
								itm.ForeColor = System.Drawing.Color.DarkGreen;
								itm.Font = new Font(itm.Font, FontStyle.Regular);
							}
						}
					}
					lvItems.EndUpdate();
					lvItems.ResumeLayout();

					if (lvItems.Items.Count > 0)
						lvItems.Items[0].Selected = true;
				}
			}
		}


                private void txtBuscar_TextChanged(object sender, System.EventArgs e)
                {
                        if (f_IgnoreEvents == false && this.Workspace != null) {
                                if (this.Workspace.SlowLink) {
                                        Timer1.Enabled = false;
                                        Timer1.Enabled = true;
                                } else {
                                        Refrescar();
                                }
                        }
                }


		private void txtBuscar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			byte Tecla = System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0];
			if (Tecla == System.Convert.ToByte(Keys.Escape))
			{
				e.Handled = true;
				this.Close();
			}
			else if (Tecla == System.Convert.ToByte(Keys.Return))
			{
				e.Handled = true;
				this.DarleEnter();
			}
		}


		private void txtBuscar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (lvItems.Items.Count > 0)
			{
				switch (e.KeyCode)
				{
					case Keys.Up:
						if (lvItems.SelectedItems.Count == 0)
							lvItems.SelectedItems[0].Selected = true;
						else if (lvItems.SelectedItems[0].Index > 0)
							lvItems.Items[lvItems.SelectedItems[0].Index - 1].Selected = true;
						e.Handled = true;
						break;
					case Keys.Down:
						if (lvItems.SelectedItems.Count == 0)
							lvItems.SelectedItems[0].Selected = true;
						else if (lvItems.SelectedItems[0].Index < lvItems.Items.Count - 1)
							lvItems.Items[lvItems.SelectedItems[0].Index + 1].Selected = true;
						e.Handled = true;
						break;
					case Keys.PageUp:
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
						break;
					case Keys.PageDown:
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						this.txtBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
						break;
				}
			}
		}


		private void lvItems_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			byte Tecla = System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0];
			if (Tecla == System.Convert.ToByte(Keys.Return))
			{
				e.Handled = true;
				this.DarleEnter();
			}
			else if (Tecla == System.Convert.ToByte(Keys.Escape))
			{
				e.Handled = true;
				this.Close();
			}
			else if (Tecla == System.Convert.ToByte(Keys.Back))
			{
				if (txtBuscar.Text.Length > 0)
				{
					e.Handled = true;
					txtBuscar.Text = txtBuscar.Text.Substring(0, txtBuscar.Text.Length - 1);
				}
				e.Handled = true;
			}
			else if ((@"ABCDEFGHIJKLMNOPQRSTUVWXYZ* """).IndexOf(char.ToUpper(e.KeyChar)) != -1)
			{
				e.Handled = true;
				txtBuscar.Text += System.Convert.ToString(e.KeyChar);
			}
		}


		internal void DarleEnter()
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				if (m_Table == "articulos")
				{
                                        string Codigo = this.Workspace.DefaultDataView.DataBase.FieldString("SELECT " + this.Workspace.CurrentConfig.Products.DefaultCode() + " FROM articulos WHERE id_articulo=" + int.Parse(lvItems.SelectedItems[0].Text).ToString());
					if (Codigo.Length == 0)
						Codigo = int.Parse(lvItems.SelectedItems[0].Text).ToString();
					ControlDestino.Text = Codigo;
				}
				else
				{
					ControlDestino.Text = int.Parse(lvItems.SelectedItems[0].Text).ToString();
				}
				this.Close();
			}
		}


		private void cmdNuevo_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			object Resultado = this.Workspace.RunTime.Execute("CREATE", new string[] { m_Table });
			if (Resultado == null)
			{
				// No se puede crear
				this.Show();
			}
			else if (Resultado is Lui.Forms.EditForm)
			{
				((Lui.Forms.EditForm)Resultado).ControlDestino = this.ControlDestino;
				this.DialogResult = DialogResult.Retry;
				this.Tag = Resultado;
				this.Close();
			}
			else if (Resultado is Form)
			{
				this.DialogResult = DialogResult.Retry;
				this.Close();
			}
			else if (Resultado is Lfx.Types.OperationResult)
			{
				Lui.Forms.MessageBox.Show(((Lfx.Types.OperationResult)(Resultado)).Message, "Mensaje");
			}
			else
			{
				// Devolvió algo raro.
			}
		}


		private void FormBuscadorRapido_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F6:
					e.Handled = true;
					if (cmdNuevo.Enabled && cmdNuevo.Visible)
						cmdNuevo_Click(sender, e);
					break;
			}
		}


		public void VerDetalles()
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				int ItemId = int.Parse(lvItems.SelectedItems[0].Text);
				if (ItemId > 0)
					this.Workspace.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", this.Table, ItemId.ToString() });
			}
		}


		private void lvItems_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lvItems.SelectedItems.Count > 0)
			{
				lvItems.Items[lvItems.SelectedItems[0].Index].Focused = true;
				lvItems.Items[lvItems.SelectedItems[0].Index].EnsureVisible();
			}
			VerDetalles();
		}


		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			this.Refrescar();
			Timer1.Enabled = false;
		}

		private void lvItems_DoubleClick(object sender, System.EventArgs e)
		{
			DarleEnter();
		}

		public Lws.Workspace Workspace
		{
			get
			{
				//Busco un Workspace en mi parent
				if (m_Workspace == null)
					m_Workspace = FindMyWorkspace(this.Owner);
				return m_Workspace;
			}
		}

		private Lws.Workspace FindMyWorkspace(System.Windows.Forms.Control whereToFind)
		{
			if (whereToFind is Lui.Forms.Form)
				return ((Lui.Forms.Form)whereToFind).Workspace;
			else if (whereToFind is System.Windows.Forms.Form && ((Form)whereToFind).Owner != null)
				return FindMyWorkspace(((Form)whereToFind).Owner);
			else if (whereToFind != null && whereToFind.Parent != null)
				return FindMyWorkspace(whereToFind.Parent);
			else
				return null;
		}
	}
}