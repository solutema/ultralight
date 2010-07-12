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
                private System.Collections.Generic.List<qGen.Join> m_Joins = new System.Collections.Generic.List<qGen.Join>();
		private string m_SearchText = "";
		private qGen.Where m_CustomFilters = new qGen.Where();
                private bool Virtual = false;
                private ListViewItem[] VirtualModeCache = null;
                
                private int[] m_Labels = null;
                private string m_LabelField = null;

                public ListingForm()
                        : base()
                {
                        // Necesario para admitir el Diseñador de Windows Forms
                        InitializeComponent();

                        PanelBotonera.BackColor = Lfx.Config.Display.CurrentTemplate.FooterBackground;
                        Listado.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        Listado.BackColor = Lfx.Config.Display.CurrentTemplate.ControlDataarea;
                        Listado.ForeColor = Lfx.Config.Display.CurrentTemplate.ControlText;
                        Listado.VirtualMode = this.Virtual;
                }

                public int[] Labels
                {
                        get
                        {
                                return m_Labels;
                        }
                        set
                        {
                                m_Labels = value;
                        }
                }

                public string LabelField
                {
                        get
                        {
                                return m_LabelField;
                        }
                        set
                        {
                                m_LabelField = value;
                        }
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

		public qGen.Where CustomFilters
		{
			get
			{
				return m_CustomFilters;
			}
			set
			{
				m_CustomFilters = value;
			}
		}

                public System.Collections.Generic.List<qGen.Join> Joins
                {
                        get
                        {
                                return this.m_Joins;
                        }
                        set
                        {
                                this.m_Joins = value;
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
                        if (this.Virtual) {
                                this.Listado.VirtualMode = true;
                                this.Listado.VirtualListSize = this.DataBase.FieldInt(this.SelectCommand(true));
                                VirtualModeCache = new ListViewItem[this.Listado.VirtualListSize];
                        } else {
                                this.Listado.VirtualMode = false;
                                this.Fill(this.SelectCommand(false));
                        }
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

                private qGen.Select SelectCommand(bool forCount)
                {
                        if (m_DataTableName != null) {
                                qGen.Select ComandoSelect = new qGen.Select(this.DataBase.SqlMode);

                                // Genero la lista de tablas, con JOIN y todo
                                string ListaTablas = null;
                                ListaTablas = m_DataTableName;

                                if (m_Joins != null && m_Joins.Count > 0)
                                        ComandoSelect.Joins = m_Joins;

                                string ListaCampos;
                                if (forCount) {
                                        ListaCampos = "COUNT(" + m_KeyField.ColumnName + ") AS row_count";
                                } else {
                                        // Genero la lista de campos
                                        ListaCampos = m_KeyField.ColumnName;
                                        foreach (Lfx.Data.FormField CurField in m_FormFields)
                                                ListaCampos += "," + CurField.ColumnName;
                                }

                                // Genero las condiciones del WHERE
                                qGen.Where WhereBuscarTexto = new qGen.Where();
                                WhereBuscarTexto.Operator = qGen.AndOr.Or;

                                if (m_SearchText != null && m_SearchText.Length > 0) {
                                        if (Lfx.Types.Strings.IsNumericInt(m_SearchText))
                                                WhereBuscarTexto.AddWithValue(m_KeyField.ColumnName, Lfx.Types.Parsing.ParseInt(m_SearchText).ToString());

                                        if (m_FormFields != null) {
                                                foreach (Lfx.Data.FormField CurField in m_FormFields) {
                                                        if (CurField.ColumnName.IndexOf(" AS ") == -1 && CurField.ColumnName.IndexOf("(") == -1)
                                                                WhereBuscarTexto.AddWithValue(CurField.ColumnName, qGen.ComparisonOperators.InsensitiveLike, "%" + m_SearchText + "%");
                                                }
                                        }
                                        if (m_ExtraSearchFields != null) {
                                                foreach (Lfx.Data.FormField CurField in m_ExtraSearchFields) {
                                                        WhereBuscarTexto.AddWithValue(CurField.ColumnName, qGen.ComparisonOperators.InsensitiveLike, "%" + m_SearchText + "%");
                                                }
                                        }
                                }

                                qGen.Where WhereCompleto = new qGen.Where();
                                WhereCompleto.Operator = qGen.AndOr.And;

                                if (m_Labels != null) {
                                        if (m_LabelField == null || m_LabelField.Length == 0)
                                                m_LabelField = this.m_KeyField.ColumnName;
                                        if (m_Labels.Length == 1) {
                                                // Ids negativos sólo cuando hay una sola etiqueta
                                                if (m_Labels[0] > 0)
                                                        WhereCompleto.AddWithValue(m_LabelField, qGen.ComparisonOperators.In, new qGen.SqlExpression("(SELECT item_id FROM sys_labels_values WHERE id_label=" + m_Labels[0].ToString() + ")"));
                                                else
                                                        WhereCompleto.AddWithValue(m_LabelField, qGen.ComparisonOperators.NotIn, new qGen.SqlExpression("(SELECT item_id FROM sys_labels_values WHERE id_label=" + (-m_Labels[0]).ToString() + ")"));
                                        } else if (m_Labels.Length > 1) {
                                                string[] LabelsString = Array.ConvertAll<int, string>(m_Labels, new Converter<int, string>(Convert.ToString));
                                                WhereCompleto.AddWithValue(m_LabelField, qGen.ComparisonOperators.In, new qGen.SqlExpression("(SELECT item_id FROM sys_labels_values WHERE id_label IN (" + string.Join(",", LabelsString) + "))"));
                                        }
                                }

                                if (WhereBuscarTexto.Count > 0)
                                        WhereCompleto.AddWithValue(WhereBuscarTexto);

                                if (m_CustomFilters != null && m_CustomFilters.Count > 0)
                                        WhereCompleto.AddWithValue(m_CustomFilters);

                                ComandoSelect.Tables = ListaTablas;
                                ComandoSelect.Fields = ListaCampos;
                                ComandoSelect.WhereClause = WhereCompleto;
                                if (m_Agrupar != null)
                                        ComandoSelect.Group = m_Agrupar.ColumnName;

                                ComandoSelect.Order = m_OrderBy;
                                return ComandoSelect;
                        } else {
                                return null;
                        }
                }

                public virtual void Fill(qGen.Select command)
                {
                        this.Fill(command, 0);
                }

		public virtual void Fill(qGen.Select command, int virtualModeOffset)
		{
        		if (this.Workspace == null || command == null)
				return;

			System.Data.DataTable Tabla = this.DataBase.Select(command);

			ListViewItem CurItem = null;
                        System.Collections.Generic.List<int> CheckedItems = null;

                        if (this.Virtual == false) {
                                if (command.Window == null) {
                                        if (this.Workspace.SlowLink)
                                                command.Window = new qGen.Window(1000 > m_Limit ? 1000 : m_Limit);
                                        else if (m_Limit > 0)
                                                command.Window = new qGen.Window(m_Limit);
                                        else
                                                command.Window = null;
                                }

                                if (Listado.SelectedItems.Count > 0)
                                        CurItem = (ListViewItem)Listado.SelectedItems[0].Clone();
                                else
                                        CurItem = null;

                                if (Listado.CheckedItems != null && Listado.CheckedItems.Count > 0) {
                                        CheckedItems = new System.Collections.Generic.List<int>();
                                        foreach (ListViewItem Itm in Listado.CheckedItems) {
                                                CheckedItems.Add(Lfx.Types.Parsing.ParseInt(Itm.Text));
                                        }
                                }

                                this.SuspendLayout();
                                Listado.BeginUpdate();
                                Listado.Items.Clear();
                        }

			if (Tabla != null && Tabla.Rows.Count > 0)
			{
				int CurrencyDecimalPlaces = this.Workspace.CurrentConfig.Currency.DecimalPlaces;
				string NombreCampoId = NombreCampo(m_KeyField.ColumnName);
				foreach(System.Data.DataRow Registro in Tabla.Rows)
				{
					int ii;
                                        int ItemId = System.Convert.ToInt32(Registro[NombreCampoId]);
                                        ListViewItem Itm = new ListViewItem(ItemId.ToString("000000"));
                                        if (CheckedItems != null && CheckedItems.Contains(ItemId))
                                                Itm.Checked = true;

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
                                                                if (Registro[ii] is System.Byte[])
                                                                        Itm.SubItems.Add(System.Text.Encoding.Default.GetString(((System.Byte[])(Registro[ii]))));
                                                                else
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
                                                                if (Registro[ii] == null || Registro[ii] is DBNull)
                                                                        Itm.SubItems.Add("");
                                                                else
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

                                        if (this.Virtual) {
                                                if (Itm.SubItems.Count < Listado.Columns.Count) {
                                                        for (int i = Itm.SubItems.Count; i < Listado.Columns.Count; i++) {
                                                                Itm.SubItems.Add("");
                                                        }
                                                }
                                                VirtualModeCache[virtualModeOffset++] = Itm;
                                        } else {
                                                Listado.Items.Add(Itm);
                                                ItemAdded(Itm, (Lfx.Data.Row)Registro);
                                                if (CurItem != null && Itm.Text == CurItem.Text)
						CurItem = Itm;
                                        }
				}
			}

                        if (this.Virtual == false) {
                                Listado.EndUpdate();

                                if (Listado.Items.Count > 0 && Listado.SelectedItems.Count == 0) {
                                        Listado.Items[0].Focused = true;
                                        Listado.Items[0].Selected = true;
                                }

                                if (Listado.Items.Count == m_Limit)
                                        EtiquetaCantidad.Text = "";
                                else
                                        EtiquetaCantidad.Text = Listado.Items.Count.ToString() + " ítem";

                                this.ResumeLayout();
                        } else {
                                EtiquetaCantidad.Text = VirtualModeCache.Length.ToString() + " ítem";
                        }

			if (CurItem != null)
			{
				CurItem.Selected = true;
				CurItem.Focused = true;
				CurItem.EnsureVisible();
			}
		}

		public virtual void ItemAdded(ListViewItem item, Lfx.Data.Row row) { }
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
							BotonFiltrar.PerformClick();
						break;

					case Keys.F3:
						e.Handled = true;
						if (EntradaBuscar.Enabled)
							EntradaBuscar.Focus();
						break;

					case Keys.F6:
						e.Handled = true;
						if (BotonCrear.Enabled && BotonCrear.Visible)
							BotonCrear.PerformClick();
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
							Exportar.SelectCommand = this.SelectCommand(false);
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
			if (e.KeyChar == (char)System.Windows.Forms.Keys.Escape) {
				e.Handled = true;
				BotonCancelar.PerformClick();
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
                        if (this.Virtual) {
                                ListViewItemSelectionChangedEventArgs ee = e as ListViewItemSelectionChangedEventArgs;
                                if (ee != null && this.Visible && ee.IsSelected)
                                        this.ItemSelected(ee.Item);
                        } else if (this.Listado.SelectedItems.Count > 0) {
                                this.ItemSelected(this.Listado.SelectedItems[0]);
                        }
                }

                public virtual void ItemSelected(ListViewItem itm)
                {
                        this.Workspace.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", m_DataTableName, itm.Text });
                }

		private void Listado_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == false && e.Control == false) {
				switch (e.KeyCode)
				{
                                        case Keys.Delete:
                                                e.Handled = true;
                                                int[] Codigos = this.CodigosSeleccionados;
                                                if (Codigos != null)
                                                        this.OnDelete(Codigos);
                                                break;
				}
                        } else if (e.Control == true) {
                                switch(e.KeyCode) {
                                        case Keys.U:
                                                foreach (ColumnHeader Ch in Listado.Columns) {
                                                        if (Ch.Index < this.FormFields.Length)
                                                                Ch.Width = this.FormFields[Ch.Index].Width;
                                                }
                                                e.Handled = true;
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

                private void ListingForm_Activated(object sender, EventArgs e)
                {
                        //Sólo refresco si no hay filtros y cuando son pocos elementos
                        if (this.Visible && this.Listado.Items.Count < 200 && this.CustomFilters.Count == 0)
                                this.RefreshList();
                }

                private void Listado_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
                {
                        if (VirtualModeCache[e.ItemIndex] == null) {
                                qGen.Select Sel = this.SelectCommand(false);
                                Sel.Window = new qGen.Window(e.ItemIndex, 50);
                                this.Fill(Sel, e.ItemIndex);
                        }
                        e.Item = VirtualModeCache[e.ItemIndex];
                }

                private void Listado_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
                {
                        qGen.Select Sel = this.SelectCommand(false);
                        Sel.Window = new qGen.Window(e.StartIndex, e.EndIndex - e.StartIndex);
                        for (int i = e.StartIndex; i < e.EndIndex; i++) {
                                if(VirtualModeCache[i] == null) {
                                        this.Fill(Sel, e.StartIndex);
                                        break;
                                }

                        }
                }
	}
}