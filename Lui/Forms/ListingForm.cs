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
using System.Windows.Forms;

namespace Lui.Forms
{
	public partial class ListingForm : Lui.Forms.ChildForm
	{
		//Miembros privados
		private int m_Limit = 5000;
		private List<Lfx.Data.FormField> m_FormFields = null, m_ExtraSearchFields = null;
                private Lfx.Data.FormField m_GroupBy = null;
		private string m_DataTableName;
		private Lfx.Data.FormField m_KeyField;
		private string m_OrderBy = null;
                private System.Collections.Generic.List<qGen.Join> m_Joins = new System.Collections.Generic.List<qGen.Join>();
		private string m_SearchText = null;
		private qGen.Where m_CustomFilters = new qGen.Where();
                private bool Virtual = false;
                private ListViewItem[] VirtualModeCache = null;
                protected Dictionary<string, int> FormFieldToSubItem;

                // Grouping
                private string m_GroupingColumnName = null;
                private static string LastGroupingValue = null;
                private static ListViewGroup LastGroup = null;
                private static System.Collections.Generic.Dictionary<string, int> GroupItemCount = new Dictionary<string, int>();

                // Labels
                private int[] m_Labels = null;
                private string m_LabelField = null;

                public ListingForm()
                {
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

                public string GroupingColumnName
                {
                        get
                        {
                                return m_GroupingColumnName;
                        }
                        set
                        {
                                if (value == null || value.Length == 0)
                                        m_GroupingColumnName = null;
                                else
                                        m_GroupingColumnName = value;
                        }
                }

		public List<Lfx.Data.FormField> FormFields
		{
			get
			{
				return m_FormFields;
			}
			set
			{
				m_FormFields = value;
                                this.UpdateFormFields();
			}
		}

                private void UpdateFormFields()
                {
                        if (this.Workspace != null && this.DataBase != null && m_FormFields != null) {
                                FormFieldToSubItem = new Dictionary<string, int>();

                                int ColNum = 1;
                                for (int i = 0; i < m_FormFields.Count; i++) {
                                        if (Listado.Columns.Count <= ColNum)
                                                Listado.Columns.Add(new ColumnHeader());

                                        Listado.Columns[ColNum].Name = Lfx.Data.DataBase.GetFieldName(m_FormFields[i].ColumnName);
                                        Listado.Columns[ColNum].Width = m_FormFields[i].Width;
                                        Listado.Columns[ColNum].Text = m_FormFields[i].Label;

                                        if (FormFieldToSubItem.ContainsKey(Listado.Columns[ColNum].Name) == false)
                                                FormFieldToSubItem.Add(Listado.Columns[ColNum].Name, ColNum);
                                        if (FormFieldToSubItem.ContainsKey(m_FormFields[i].ColumnName) == false)
                                                FormFieldToSubItem.Add(m_FormFields[i].ColumnName, ColNum);

                                        switch (m_FormFields[i].DataType) {
                                                case Lfx.Data.InputFieldTypes.Integer:
                                                case Lfx.Data.InputFieldTypes.Serial:
                                                case Lfx.Data.InputFieldTypes.Numeric:
                                                case Lfx.Data.InputFieldTypes.Currency:
                                                        Listado.Columns[ColNum].TextAlign = HorizontalAlignment.Right;
                                                        break;
                                                default:
                                                        Listado.Columns[ColNum].TextAlign = HorizontalAlignment.Left;
                                                        break;
                                        }

                                        ColNum++;
                                }
                        }
                }

                public List<Lfx.Data.FormField> ExtraSearchFields
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

		public virtual string SearchText
		{
			get
			{
				return m_SearchText;
			}
			set
			{
                                if (value == "")
                                        m_SearchText = null;
                                else
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
				return m_GroupBy;
			}
			set
			{
                                m_GroupBy = value;
			}
		}

		public virtual Lfx.Types.OperationResult OnFilter()
		{
			return new Lfx.Types.SuccessOperationResult();
		}

                public virtual Lfx.Types.OperationResult OnDelete(int[] itemIds)
                {
                        foreach (int itemId in itemIds) {
                                this.DataBase.Tables[this.DataTableName].FastRows.RemoveFromCache(itemId);
                        }
                        return new Lfx.Types.SuccessOperationResult();
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

		public void RefreshList()
		{
                        if (this.Workspace == null || this.DataBase == null)
                                return;

                        GroupItemCount.Clear();
                        LastGroup = null;

                        this.UpdateFormFields();
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

                        // Muestro los totales de grupo
                        if (m_GroupingColumnName != null) {
                                foreach (ListViewGroup Grp in Listado.Groups) {
                                        if (GroupItemCount.ContainsKey(Grp.Name))
                                                Grp.Header = Grp.Name + " (" + GroupItemCount[Grp.Name].ToString() + ")";
                                }
                        }

                        this.EndRefreshList();
		}


                private qGen.Select SelectCommand(bool forCount)
                {
                        if (this.Workspace != null && this.DataBase != null && m_DataTableName != null) {
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

                                if (this.SearchText != null) {
                                        if (Lfx.Types.Strings.IsNumericInt(this.SearchText))
                                                WhereBuscarTexto.AddWithValue(m_KeyField.ColumnName, Lfx.Types.Parsing.ParseInt(this.SearchText).ToString());

                                        if (m_FormFields != null) {
                                                foreach (Lfx.Data.FormField CurField in m_FormFields) {
                                                        if (CurField.ColumnName.IndexOf(" AS ") == -1 && CurField.ColumnName.IndexOf("(") == -1)
                                                                WhereBuscarTexto.AddWithValue(CurField.ColumnName, qGen.ComparisonOperators.InsensitiveLike, "%" + this.SearchText + "%");
                                                }
                                        }
                                        if (m_ExtraSearchFields != null) {
                                                foreach (Lfx.Data.FormField CurField in m_ExtraSearchFields) {
                                                        WhereBuscarTexto.AddWithValue(CurField.ColumnName, qGen.ComparisonOperators.InsensitiveLike, "%" + this.SearchText + "%");
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
                                if (m_GroupBy != null)
                                        ComandoSelect.Group = m_GroupBy.ColumnName;
                                ComandoSelect.Order = m_OrderBy;
                                return ComandoSelect;
                        } else {
                                return null;
                        }
                }

                public void Fill(qGen.Select command)
                {
                        this.Fill(command, 0);
                }

		public void Fill(qGen.Select command, int virtualModeOffset)
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

                        if (Tabla != null && Tabla.Rows.Count > 0) {
                                foreach (System.Data.DataRow DtRow in Tabla.Rows) {
                                        Lfx.Data.Row Registro = (Lfx.Data.Row)DtRow;

                                        string NombreCampoId = Lfx.Data.DataBase.GetFieldName(m_KeyField.ColumnName);
                                        int ItemId = Registro.Fields[NombreCampoId].ValueInt;

                                        ListViewItem Itm = this.FormatDataRow(ItemId, Registro);

                                        if (CheckedItems != null && CheckedItems.Contains(ItemId))
                                                Itm.Checked = true;

                                        if (this.Virtual) {
                                                if (Itm.SubItems.Count < Listado.Columns.Count) {
                                                        for (int i = Itm.SubItems.Count; i < Listado.Columns.Count; i++) {
                                                                Itm.SubItems.Add("");
                                                        }
                                                }
                                                VirtualModeCache[virtualModeOffset++] = Itm;
                                        } else {
                                                Listado.Items.Add(Itm);
                                                // Agrego el item a un grupo, si hay agrupación activa
                                                if (m_GroupingColumnName != null) {
                                                        if (LastGroupingValue != Registro.Fields[m_GroupingColumnName].ValueString) {
                                                                LastGroupingValue = Registro.Fields[m_GroupingColumnName].ValueString;
                                                                if (Listado.Groups[LastGroupingValue] != null)
                                                                        LastGroup = Listado.Groups[LastGroupingValue];
                                                                else
                                                                        LastGroup = Listado.Groups.Add(LastGroupingValue, LastGroupingValue);
                                                        }

                                                        if (GroupItemCount.ContainsKey(LastGroupingValue))
                                                                GroupItemCount[LastGroupingValue]++;
                                                        else
                                                                GroupItemCount[LastGroupingValue] = 1;
                                                }
                                                Itm.Group = LastGroup;

                                                ItemAdded(Itm, Registro);
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

                private ListViewItem FormatDataRow(int itemId, Lfx.Data.Row row)
                {
                        ListViewItem Itm = new ListViewItem(itemId.ToString("000000"));

                        for (int ColNum = 1; ColNum < Listado.Columns.Count; ColNum++) {
                                string FieldName = Listado.Columns[ColNum].Name;

                                int FieldNum = -1;
                                for (int fi = 0; fi < FormFields.Count; fi++) {
                                        if (Lfx.Data.DataBase.GetFieldName(FormFields[fi].ColumnName) == FieldName) {
                                                FieldNum = fi;
                                                break;
                                        }
                                }

                                if (FieldNum >= 0) {
                                        int RowField = FieldNum + 1;
                                        ListViewItem.ListViewSubItem SubItm = Itm.SubItems.Add("");
                                        SubItm.Name = FieldName;

                                        switch (m_FormFields[FieldNum].DataType) {
                                                case Lfx.Data.InputFieldTypes.Integer:
                                                case Lfx.Data.InputFieldTypes.Serial:
                                                case Lfx.Data.InputFieldTypes.Relation:
                                                        if (row[RowField] == null || row[RowField] is DBNull)
                                                                SubItm.Text = "";
                                                        else if (m_FormFields[FieldNum].Format != null)
                                                                SubItm.Text = System.Convert.ToInt32(row[RowField]).ToString(m_FormFields[FieldNum].Format);
                                                        else
                                                                SubItm.Text = System.Convert.ToInt32(row[RowField]).ToString();
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Text:
                                                case Lfx.Data.InputFieldTypes.Memo:
                                                        if (row[RowField] == null)
                                                                SubItm.Text = "";
                                                        else if (row[RowField] is System.Byte[])
                                                                SubItm.Text = System.Text.Encoding.Default.GetString(((System.Byte[])(row[RowField])));
                                                        else
                                                                SubItm.Text = row[RowField].ToString();
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Currency:
                                                        double ValorCur = (row[RowField] == null || row[RowField] is DBNull) ? 0 : System.Convert.ToDouble(row[RowField]);
                                                        if (ValorCur == 0)
                                                                SubItm.Text = "-";
                                                        else
                                                                SubItm.Text = Lfx.Types.Formatting.FormatCurrency(ValorCur, this.Workspace.CurrentConfig.Moneda.Decimales);
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Numeric:
                                                        if (row[RowField] == null || row[RowField] is DBNull)
                                                                SubItm.Text = "";
                                                        else
                                                                SubItm.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(row[RowField]));
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Date:
                                                        if (row.Fields[RowField].Value != null)
                                                                SubItm.Text = Lfx.Types.Formatting.FormatDate(row.Fields[RowField].ValueDateTime);
                                                        break;

                                                case Lfx.Data.InputFieldTypes.DateTime:
                                                        SubItm.Text = Lfx.Types.Formatting.FormatDateAndTime(row[RowField]);
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Bool:
                                                        if (System.Convert.ToBoolean(row[RowField]))
                                                                SubItm.Text = "Si";
                                                        else
                                                                SubItm.Text = "No";
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Set:
                                                        int SetValue = System.Convert.ToInt32(row[RowField]);
                                                        if (m_FormFields[FieldNum] != null && m_FormFields[FieldNum] .SetValues != null & m_FormFields[FieldNum].SetValues.ContainsKey(SetValue))
                                                                SubItm.Text = m_FormFields[FieldNum].SetValues[SetValue];
                                                        else
                                                                SubItm.Text = "???";
                                                        break;

                                                default:
                                                        switch (row[RowField].GetType().ToString()) {
                                                                case "System.Single":
                                                                case "System.Decimal":
                                                                case "System.Double":
                                                                        if (System.Convert.ToDouble(row[RowField]) == 0)
                                                                                SubItm.Text = "-";
                                                                        else
                                                                                SubItm.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(row[RowField]));
                                                                        break;

                                                                case "System.Integer":
                                                                case "System.Int16":
                                                                case "System.Int32":
                                                                case "System.Int64":
                                                                        if (System.Convert.ToInt32(row[RowField]) == 0)
                                                                                SubItm.Text = "-";
                                                                        else
                                                                                SubItm.Text = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(row[RowField]), 0);
                                                                        break;

                                                                case "System.DateTime":
                                                                        SubItm.Text = Lfx.Types.Formatting.FormatDate(row[RowField]);
                                                                        break;

                                                                case "System.String":
                                                                        SubItm.Text = System.Convert.ToString(row[RowField]);
                                                                        break;

                                                                case "System.Byte[]":
                                                                        SubItm.Text = System.Text.Encoding.Default.GetString((byte[])row[RowField]);
                                                                        break;

                                                                case "System.DBNull":
                                                                        SubItm.Text = "";
                                                                        break;

                                                                default:
                                                                        SubItm.Text = row[RowField].ToString();
                                                                        break;
                                                        }
                                                        break;
                                        }
                                }
                        }
                        return Itm;
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
                                                if (Codigos != null && Codigos.Length > 0) {
                                                        string EstaSeguro = "¿Está seguro de que desea eliminar ";
                                                        if (Codigos.Length == 1)
                                                                EstaSeguro += "el elemento seleccionado?";
                                                        else
                                                                EstaSeguro += "los " + Codigos.Length.ToString() + " elementos seleccionado?";
                                                        Lui.Forms.YesNoDialog Pregunta = new YesNoDialog(EstaSeguro, "Eliminar");
                                                        Pregunta.DialogButtons = Lui.Forms.DialogButtons.YesNo;
                                                        if (Pregunta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                                                this.OnDelete(Codigos);
                                                }
                                                break;
				}
                        } else if (e.Control == true) {
                                switch(e.KeyCode) {
                                        case Keys.U:
                                                foreach (ColumnHeader Ch in Listado.Columns) {
                                                        if (Ch.Index < this.FormFields.Count)
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
                        else if ((e.Column - 1) < m_FormFields.Count)
                                NuevoOrden = m_FormFields[e.Column - 1].ColumnName;

                        NuevoOrden = Lfx.Data.DataBase.GetFieldName(NuevoOrden);

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