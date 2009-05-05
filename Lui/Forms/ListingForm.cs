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
	public partial class ListingForm : Lui.Forms.ChildForm
	{
		//Miembros privados
		private int m_Limit = 5000;
		private Lfx.Data.FormField m_Agrupar = null;
		private Lfx.Data.FormField[] m_FormFields, m_ExtraSearchFields = null;
		private string m_DataTableName;
		private Lfx.Data.FormField m_KeyField;
		private string m_OrderBy = null;
		private string m_ExtraDataTableNames;
		private string m_Relations = "";
		private string m_SearchText = "";
		private object m_CurrentFilter;

                public ListingForm()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        PanelBotonera.BackColor = Lws.Config.Display.CurrentTemplate.FooterBackground;
                        Listado.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        Listado.BackColor = Lws.Config.Display.CurrentTemplate.ControlDataarea;
                        Listado.ForeColor = Lws.Config.Display.CurrentTemplate.ControlText;
                }

		public Lfx.Data.FormField[] FormFields
		{
			get
			{
				return m_FormFields;
			}
			set
			{
				m_FormFields = value;
				if(m_FormFields != null) {
					int i = 1;
					foreach(Lfx.Data.FormField CurField in m_FormFields) {
                                                if (Listado.Columns.Count <= i)
                                                        Listado.Columns.Add(new ColumnHeader());
						Listado.Columns[i].Width = CurField.Width;
						Listado.Columns[i].Text = CurField.Label;
						switch(CurField.DataType) {
							case Lfx.Data.InputFieldTypes.Integer:
                                                        case Lfx.Data.InputFieldTypes.Serial:
                                                        case Lfx.Data.InputFieldTypes.Numeric:
                                                        case Lfx.Data.InputFieldTypes.Currency:
								Listado.Columns[i].TextAlign = HorizontalAlignment.Right;
								break;
							default:
								Listado.Columns[i].TextAlign = HorizontalAlignment.Left;
								break;
						}
						i++;
					}
				}
			}
		}

		public Lfx.Data.FormField[] ExtraSearchFields
		{
			get
			{
				return m_ExtraSearchFields;
			}
			set
			{
				m_ExtraSearchFields = value;
			}
		}

		public int Limit
		{
			get
			{
				return m_Limit;
			}
			set
			{
				m_Limit = value;
			}
		}


		public string DataTableName
		{
			get
			{
				return m_DataTableName;
			}
			set
			{
				m_DataTableName = value;
			}
		}

		public void Search(string text)
		{
			this.SearchText = text;
			this.RefreshList();
		}

		public string SearchText
		{
			get
			{
				return m_SearchText;
			}
			set
			{
				m_SearchText = value;
			}
		}

		public object CurrentFilter
		{
			get
			{
				return m_CurrentFilter;
			}
			set
			{
				m_CurrentFilter = value;
			}
		}

		public string ExtraDataTableNames
		{
			get
			{
				return m_ExtraDataTableNames;
			}
			set
			{
				m_ExtraDataTableNames = value;
			}
		}

		public string Relations
		{
			get
			{
				return m_Relations;
			}
			set
			{
				m_Relations = value;
			}
		}

		public string OrderBy
		{
			get
			{
				return m_OrderBy;
			}
			set
			{
				m_OrderBy = value;
			}
		}

		public Lfx.Data.FormField KeyField
		{
			get
			{
				return m_KeyField;
			}
			set
			{
				m_KeyField = value;
				if(m_KeyField != null) {
					Listado.Columns[0].Width = m_KeyField.Width;
					Listado.Columns[0].Text = m_KeyField.Label;
				}
			}
		}

		public Lfx.Data.FormField GroupBy
		{
			get
			{
				return m_Agrupar;
			}
			set
			{
				m_Agrupar = value;
			}
		}

		public virtual Lfx.Types.OperationResult OnFilter()
		{
			return new Lfx.Types.SuccessOperationResult();
		}

                public virtual Lfx.Types.OperationResult OnDelete(int[] itemIds)
                {
                        return new Lfx.Types.CancelOperationResult();
                }

		public virtual Lfx.Types.OperationResult OnPrint(bool selectPrinter)
		{
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Lfx.Types.OperationResult OnEdit(int itemId)
		{
			this.Workspace.RunTime.Execute("EDIT", new string[] { m_DataTableName, itemId.ToString() });
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual Lfx.Types.OperationResult OnCreate()
		{
			this.Workspace.RunTime.Execute("CREATE", new string[] { this.m_DataTableName });
			return new Lfx.Types.SuccessOperationResult();
		}

		public virtual void RefreshList()
		{
                        this.LoadColumns();
                        this.BeginRefreshList();
			this.Fill(this.SelectCommand());
                        this.EndRefreshList();
		}

		private static string NombreCampo(string sCampo)
		{
			int r = sCampo.IndexOf("(") + 1;
			if (r > 0)
			{
				// Si hay un paréntesis asumo que hay una función y no hago nada
				return sCampo;
			}
			r = sCampo.IndexOf(".") + 1;
			if (r > 0)
				return sCampo.Substring(r, sCampo.Length - r);
			else
				return sCampo;
		}

		private Lfx.Data.SqlSelectBuilder SelectCommand()
		{
			if (m_DataTableName != null)
			{
				// Genero la lista de tablas, con JOIN y todo
				string ListaTablas = null;
				ListaTablas = m_DataTableName;

				if (m_ExtraDataTableNames != null)
				{
					ListaTablas += " LEFT JOIN " + m_ExtraDataTableNames;

					if (m_Relations != null && m_Relations.Length > 0)
						ListaTablas += " ON " + m_Relations;
				}

				// Genero la lista de campos
				string ListaCampos = m_KeyField.ColumnName;
				foreach(Lfx.Data.FormField CurField in m_FormFields)
					ListaCampos  += "," + CurField.ColumnName;

				// Genero las condiciones del WHERE
				Lfx.Data.SqlWhereBuilder WhereBuscarTexto = new Lfx.Data.SqlWhereBuilder();
				WhereBuscarTexto.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandOr;

				if (m_SearchText != null && m_SearchText.Length > 0)
				{
					if (Lfx.Types.Strings.IsNumericInt(m_SearchText))
						WhereBuscarTexto.Conditions.Add(new Lfx.Data.SqlCondition(m_KeyField.ColumnName, Lfx.Data.SqlCommandBuilder.SqlOperands.Equals, Lfx.Types.Parsing.ParseInt(m_SearchText).ToString()));

					if (m_FormFields != null)
					{
						foreach(Lfx.Data.FormField CurField in m_FormFields)
						{
							if(CurField.ColumnName.IndexOf(" AS ") == -1 && CurField.ColumnName.IndexOf("(") == -1)
								WhereBuscarTexto.Conditions.Add(new Lfx.Data.SqlCondition(CurField.ColumnName, Lfx.Data.SqlCommandBuilder.SqlOperands.InsensitiveLike, "'%" + m_SearchText + "%'"));
						}
					}
					if (m_ExtraSearchFields != null)
					{
						foreach(Lfx.Data.FormField CurField in m_ExtraSearchFields)
						{
							WhereBuscarTexto.Conditions.Add(new Lfx.Data.SqlCondition(CurField.ColumnName, Lfx.Data.SqlCommandBuilder.SqlOperands.InsensitiveLike, "'%" + m_SearchText + "%'"));
						}
					}
				}

				Lfx.Data.SqlWhereBuilder WhereCompleto = new Lfx.Data.SqlWhereBuilder();
				WhereCompleto.AndOr = Lfx.Data.SqlWhereBuilder.OperandsAndOr.OperandAnd;

				if (WhereBuscarTexto.Conditions.Count > 0)
					WhereCompleto.Conditions.Add(WhereBuscarTexto);

				if(m_CurrentFilter != null)
				{
					if(m_CurrentFilter is string)
					{
						if(System.Convert.ToString(m_CurrentFilter).Length > 0)
							WhereCompleto.Conditions.Add(m_CurrentFilter);
					}
					else
					{
						WhereCompleto.Conditions.Add(m_CurrentFilter);
					}
				}

				Lfx.Data.SqlSelectBuilder ComandoSelect = new Lfx.Data.SqlSelectBuilder(this.DataView.DataBase.SqlMode);
				ComandoSelect.Tables = ListaTablas;
				ComandoSelect.Fields = ListaCampos;
				ComandoSelect.WhereClause = WhereCompleto;
				if(m_Agrupar != null)
					ComandoSelect.Group = m_Agrupar.ColumnName;

				ComandoSelect.Order = m_OrderBy;
				return ComandoSelect;
			}
			else
			{
				return null;
			}
		}

		public virtual void Fill(Lfx.Data.SqlSelectBuilder command)
		{
        		if (this.Workspace == null || command == null)
				return;

			if (this.Workspace.SlowLink)
				command.Limit = 1000 > m_Limit ? 1000 : m_Limit;
			else
				command.Limit = m_Limit;

			System.Data.DataTable Tabla = this.DataView.DataBase.Select(command);

			ListViewItem CurItem = null;

			if (Listado.SelectedItems.Count > 0)
				CurItem = (ListViewItem)Listado.SelectedItems[0].Clone();
			else
				CurItem = null;

			Lui.Forms.ProgressForm Progreso = null;

			this.SuspendLayout();
			Listado.BeginUpdate();
			Listado.Items.Clear();

			if (Tabla != null && Tabla.Rows.Count > 0)
			{
				int CurrencyDecimalPlaces = this.Workspace.CurrentConfig.Currency.DecimalPlaces;
				string NombreCampoId = NombreCampo(m_KeyField.ColumnName);
				foreach(System.Data.DataRow Registro in Tabla.Rows)
				{
					int ii;
					ListViewItem Itm = Listado.Items.Add(System.Convert.ToInt32(Registro[NombreCampoId]).ToString("000000"));

					for (int i = 0; i < m_FormFields.Length; i++)
					{
						ii = i + 1;

						switch(m_FormFields[i].DataType)
						{
							case Lfx.Data.InputFieldTypes.Integer:
                                                        case Lfx.Data.InputFieldTypes.Serial:
                                                                if (Registro[ii] == null || Registro[ii] is DBNull)
                                                                        Itm.SubItems.Add("");
                                                                else if (m_FormFields[i].Format != null)
                                                                        Itm.SubItems.Add(System.Convert.ToInt32(Registro[ii]).ToString(m_FormFields[i].Format));
                                                                else
                                                                        Itm.SubItems.Add(System.Convert.ToInt32(Registro[ii]).ToString());
								break;

                                                        case Lfx.Data.InputFieldTypes.Text:
                                                        case Lfx.Data.InputFieldTypes.Memo:
								Itm.SubItems.Add(Registro[ii].ToString());
								break;

                                                        case Lfx.Data.InputFieldTypes.Currency:
								double ValorCur = (Registro[ii] == null || Registro[ii] is DBNull) ? 0 : System.Convert.ToDouble(Registro[ii]);
								if(ValorCur == 0)
									Itm.SubItems.Add("-");
								else
									Itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(ValorCur, CurrencyDecimalPlaces));
								break;

                                                        case Lfx.Data.InputFieldTypes.Numeric:
								Itm.SubItems.Add(Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Registro[ii])));
								break;

                                                        case Lfx.Data.InputFieldTypes.Date:
								Itm.SubItems.Add(Lfx.Types.Formatting.FormatDate(Registro[ii]));
								break;

                                                        case Lfx.Data.InputFieldTypes.DateTime:
                                                                Itm.SubItems.Add(Lfx.Types.Formatting.FormatDateAndTime(Registro[ii]));
                                                                break;

                                                        case Lfx.Data.InputFieldTypes.Bool:
                                                                if (System.Convert.ToBoolean(Registro[ii]))
                                                                        Itm.SubItems.Add("Si");
                                                                else
                                                                        Itm.SubItems.Add("No");
                                                                break;

                                                        default:
								switch (Registro[ii].GetType().ToString())
								{
									case "System.Single":
									case "System.Decimal":
									case "System.Double":
										if (System.Convert.ToDouble(Registro[ii]) == 0)
											Itm.SubItems.Add("-");
										else
											Itm.SubItems.Add(Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Registro[ii])));
										break;

									case "System.Integer":
									case "System.Int16":
									case "System.Int32":
									case "System.Int64":
										if (System.Convert.ToInt32(Registro[ii]) == 0)
											Itm.SubItems.Add("-");
										else
											Itm.SubItems.Add(Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(Registro[ii]), 0));
										break;

									case "System.DateTime":
										Itm.SubItems.Add(Lfx.Types.Formatting.FormatDate(Registro[ii]));
										break;

									case "System.String":
										Itm.SubItems.Add(System.Convert.ToString(Registro[ii]));
										break;

									case "System.Byte[]":
										Itm.SubItems.Add(System.Text.Encoding.Default.GetString((byte[])Registro[ii]));
										break;

									case "System.DBNull":
										Itm.SubItems.Add("");
										break;

									default:
										Itm.SubItems.Add(Registro[ii].ToString());
										break;
								}
								break;
						}
					}

					ItemAdded(Itm);

					if (CurItem != null && Itm.Text == CurItem.Text)
						CurItem = Itm;
				}
			}

			if (Progreso != null)
				Progreso.Dispose();

			Listado.EndUpdate();

                        if (Listado.Items.Count > 0 && Listado.SelectedItems.Count == 0) {
                                Listado.Items[0].Focused = true;
                                Listado.Items[0].Selected = true;
                        }

			if(Listado.Items.Count == m_Limit)
				EtiquetaCantidad.Text = "";
			else
				EtiquetaCantidad.Text = Listado.Items.Count.ToString() + " ítem";

			this.ResumeLayout();

			if (CurItem != null)
			{
				CurItem.Selected = true;
				CurItem.Focused = true;
				CurItem.EnsureVisible();
			}
		}

		public virtual void ItemAdded(ListViewItem item) { }
		public virtual void EndRefreshList() { }
		public virtual void BeginRefreshList() { }

		private void EntradaBuscar_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == Lfx.Types.ControlChars.Cr) {
				e.Handled = true;
				this.Search(EntradaBuscar.Text);
			}
		}

		private void BotonCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ListingForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false && e.Control == false)
			{
				switch (e.KeyCode)
				{
					case Keys.F2:
						e.Handled = true;
						if (BotonFiltrar.Enabled && BotonFiltrar.Visible)
							BotonFiltrar_Click(sender, e);
						break;

					case Keys.F3:
						e.Handled = true;
						if (EntradaBuscar.Enabled)
							EntradaBuscar.Focus();
						break;

					case Keys.F6:
						e.Handled = true;
						if (BotonCrear.Enabled && BotonCrear.Visible)
							BotonCrear_Click(sender, e);
						break;

					case Keys.F8:
						e.Handled = true;
                                                if (BotonImprimir.Enabled && BotonImprimir.Visible) {
                                                        if (e.Shift == true && e.Control == false && e.Alt == false)
                                                                this.OnPrint(true);
                                                        else
                                                                this.OnPrint(false);
                                                }
						break;
				}
			}
			else if (e.Control == true && e.Alt == false)
			{
				// Teclas con Ctrl
				switch (e.KeyCode)
				{
					case Keys.R:
						if (e.Control == true && e.Shift == false && e.Alt == false)
						{
							e.Handled = true;
							ListingFormExport Exportar = new ListingFormExport();
							Exportar.Workspace = this.Workspace;
							Exportar.SelectCommand = this.SelectCommand();
							Exportar.KeyField = this.KeyField;
							Exportar.FormFields = this.FormFields;
							Exportar.Nombre = this.Text.Replace(":", "");
							Exportar.ShowDialog();
						}
						break;
				}
			}
		}

		private void BotonCrear_Click(object sender, System.EventArgs e)
		{
			Lfx.Types.OperationResult Res = this.OnCreate();
			if (Res.Success == false)
				Lui.Forms.MessageBox.Show(Res.Message, "Error");
		}

		private void Listado_DoubleClick(object sender, System.EventArgs e)
		{
			int cod = this.CodigoSeleccionado;
			Lfx.Types.OperationResult Res = this.OnEdit(cod);
			if (Res.Success == false)
				Lui.Forms.MessageBox.Show(Res.Message, "Error");
		}

		private void Listado_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == Lfx.Types.ControlChars.Cr)
			{
                                int Codigo = this.CodigoSeleccionado;
                                if (Codigo > 0) {
                                        e.Handled = true;
                                        Lfx.Types.OperationResult Res = this.OnEdit(Codigo);
                                        if (Res.Success == false)
                                                Lui.Forms.MessageBox.Show(Res.Message, "Error");
                                }
			}
		}

		private void ListingForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)System.Windows.Forms.Keys.Escape)
			{
				e.Handled = true;
				BotonCancelar_Click(sender, e);
			}
		}

                public int[] CodigosSeleccionados
                {
                        get
                        {
                                if (Listado.CheckBoxes && Listado.CheckedItems.Count > 0) {
                                        int[] Res = new int[Listado.CheckedItems.Count];
                                        int i = 0;
                                        foreach (ListViewItem itm in Listado.CheckedItems) {
                                                Res[i++] = Lfx.Types.Parsing.ParseInt(itm.Text);
                                        }
                                        return Res;
                                } else if (Listado.SelectedItems.Count > 0) {
                                        int[] Res = new int[Listado.SelectedItems.Count];
                                        int i = 0;
                                        foreach (ListViewItem itm in Listado.SelectedItems) {
                                                Res[i++] = Lfx.Types.Parsing.ParseInt(itm.Text);
                                        }
                                        return Res;
                                } else {
                                        return null;
                                }
                        }
                }

                public int CodigoSeleccionado
                {
                        get
                        {
                                if (Listado.SelectedItems.Count > 0)
                                        return Lfx.Types.Parsing.ParseInt(Listado.SelectedItems[0].Text);
                                else
                                        return 0;
                        }
                }

		private void BotonFiltrar_Click(object sender, System.EventArgs e)
		{
			OnFilter();
		}

		private void BotonImprimir_Click(object sender, System.EventArgs e)
		{
			OnPrint(false);
		}

		private void Listado_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (Listado.SelectedItems.Count > 0)
				this.Workspace.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", m_DataTableName, Listado.SelectedItems[0].Text });
		}

		private void Listado_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false && e.Control == false) {
				switch (e.KeyCode)
				{
					case Keys.Up:
						if (Listado.Items.Count == 0) {
							e.Handled = true;
							System.Windows.Forms.SendKeys.Send("+{tab}");
						} else if (Listado.SelectedItems.Count > 0 && Listado.SelectedItems[0].Index == 0) {
							e.Handled = true;
							System.Windows.Forms.SendKeys.Send("+{tab}");
						}
						break;

					case Keys.Down:
						if (Listado.Items.Count == 0) {
							e.Handled = true;
							System.Windows.Forms.SendKeys.Send("{tab}");
						} else if (Listado.SelectedItems.Count > 0 && Listado.SelectedItems[0].Index == Listado.Items.Count - 1) {
							e.Handled = true;
							System.Windows.Forms.SendKeys.Send("{tab}");
						}
						break;
                                        case Keys.Delete:
                                                e.Handled = true;
                                                int[] Codigos = this.CodigosSeleccionados;
                                                if (Codigos != null)
                                                        this.OnDelete(Codigos);
                                                break;
				}
			}
		}

		private void Listado_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			string NuevoOrden = null;

                        if (e.Column == 0)
                                NuevoOrden = this.m_KeyField.ColumnName;
                        else if ((e.Column - 1) < m_FormFields.Length)
                                NuevoOrden = m_FormFields[e.Column - 1].ColumnName;

                        if (NuevoOrden != null) {
                                if (this.m_OrderBy == NuevoOrden)
                                        this.m_OrderBy = NuevoOrden + " DESC";
                                else if (this.m_OrderBy == NuevoOrden + " DESC")
                                        this.m_OrderBy = null;
                                else
                                        this.m_OrderBy = NuevoOrden;

                                this.RefreshList();
                        }
		}

                private void SaveColumns()
                {
                        try {
                                foreach (ColumnHeader Ch in Listado.Columns) {
                                        this.Workspace.CurrentConfig.WriteLocalSetting(this.GetType().ToString(), "Column" + Ch.Index.ToString() + ".Width", Ch.Width);
                                }
                        }
                        catch { }
                }

                private bool ColumnsLoaded = false;
                private void LoadColumns()
                {
                        if (ColumnsLoaded == false) {
                                try {
                                        foreach (ColumnHeader Ch in Listado.Columns) {
                                                Ch.Width = this.Workspace.CurrentConfig.ReadLocalSettingInt(this.GetType().ToString(), "Column" + Ch.Index.ToString() + ".Width", Ch.Width);
                                        }
                                        ColumnsLoaded = true;
                                }
                                catch { }
                        }
                }

                protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
                {
                        this.SaveColumns();
                        base.OnClosing(e);
                }

                private void ListingForm_Shown(object sender, EventArgs e)
                {
                        this.RefreshList();
                }

                private void ListingForm_Activated(object sender, EventArgs e)
                {
                        //Sólo refresco en conexiones rápidas o cuando son menos de 200 elementos
                        if (this.Visible && (this.Workspace.SlowLink == false || this.Listado.Items.Count < 200))
                                this.RefreshList();
                }
	}
}