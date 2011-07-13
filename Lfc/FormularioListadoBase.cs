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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lfc
{
        public partial class FormularioListadoBase : Lui.Forms.ChildForm
        {
                protected Type m_ElementoTipo = null;

                //Miembros privados
                protected string m_SearchText = null;

                protected string m_NombreTabla;
                protected Lfx.Data.FormFieldCollection m_FormFields = null, m_ExtraSearchFields = null;
                protected Dictionary<string, int> FormFieldToSubItem = new Dictionary<string, int>();
                protected Dictionary<string, int> SubItemToFormField = new Dictionary<string, int>();
                protected int m_Limit = 5000;
                protected Lfx.Data.FormField m_GroupBy = null;
                protected Lfx.Data.FormField m_KeyField;
                protected string m_DetailColumnName = null;
                protected string m_OrderBy = null;
                protected qGen.JoinCollection m_Joins = new qGen.JoinCollection();
                protected qGen.Where m_CustomFilters = new qGen.Where();
                protected qGen.Where m_Having = null;

                // Grouping
                protected string m_GroupingColumnName = null;
                protected string LastGroupingValue = null;
                protected ListViewGroup LastGroup = null;

                // Labels
                protected int[] m_Labels = null;
                protected string m_LabelField = null;

                public List<Contador> Contadores = new List<Contador>();

                public FormularioListadoBase()
                {
                        InitializeComponent();

                        RefreshTimer.Start();
                }


                public string NombreTabla
                {
                        get
                        {
                                return m_NombreTabla;
                        }
                        set
                        {
                                m_NombreTabla = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Type ElementoTipo
                {
                        get
                        {
                                return m_ElementoTipo;
                        }
                        set
                        {
                                m_ElementoTipo = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool HabilitarFiltrar
                {
                        get
                        {
                                return BotonFiltrar.Visible;
                        }
                        set
                        {
                                BotonFiltrar.Visible = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool HabilitarImprimir
                {
                        get
                        {
                                return BotonImprimir.Visible;
                        }
                        set
                        {
                                BotonImprimir.Visible = value;
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Data.FormFieldCollection FormFields
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

                [EditorBrowsable(EditorBrowsableState.Never),
                        System.ComponentModel.Browsable(false),
                        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

                public qGen.JoinCollection Joins
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
                                if (m_KeyField != null) {
                                        Listado.Columns[0].Width = m_KeyField.Width;
                                        Listado.Columns[0].Text = m_KeyField.Label;
                                }
                        }
                }


                /// <summary>
                /// Obtiene o establece el nombre de la columna que se muestra como detalle del registro (normalmente el campo "nombre").
                /// </summary>
                public string DetailColumnName
                {
                        get
                        {
                                return m_DetailColumnName;
                        }
                        set
                        {
                                m_DetailColumnName = value;
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


                public qGen.Where Having
                {
                        get
                        {
                                return m_Having;
                        }
                        set
                        {
                                m_Having = value;
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


                public Lfx.Data.FormFieldCollection ExtraSearchFields
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


                public void Search(string text)
                {
                        this.SearchText = text;
                        this.RefreshList();
                }


                public virtual Lfx.Types.OperationResult OnPrint(bool selectPrinter)
                {
                        Lfx.FileFormats.Office.Spreadsheet.Workbook Workbook = this.ToWorkbook();
                        Lazaro.Impresion.ImpresorListado Impresor = new Lazaro.Impresion.ImpresorListado(Workbook.Sheets[0]);

                        if (selectPrinter) {
                                using (Lui.Printing.PrinterSelectionDialog SeleccionarImpresroa = new Lui.Printing.PrinterSelectionDialog()) {
                                        if (SeleccionarImpresroa.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                                Impresor.Impresora = SeleccionarImpresroa.SelectedPrinter;
                                        } else {
                                                return new Lfx.Types.CancelOperationResult();
                                        }
                                }
                                using (PageSetupDialog PreferenciasDeImpresion = new PageSetupDialog()) {
                                        //PreferenciasDeImpresion.PrinterSettings = Impresor.PrinterSettings;
                                        PreferenciasDeImpresion.Document = Impresor;
                                        PreferenciasDeImpresion.AllowPrinter = true;
                                        PreferenciasDeImpresion.AllowPaper = true;
                                        if (PreferenciasDeImpresion.ShowDialog(this) == DialogResult.OK) {
                                                return Impresor.Imprimir();
                                        } else {
                                                return new Lfx.Types.CancelOperationResult();
                                        }
                                }
                        } else {
                                // Sin diálogo de selección de impresora
                                return Impresor.Imprimir();
                        }
                }


                public virtual Lfx.Types.OperationResult OnFilter()
                {
                        return new Lfx.Types.SuccessOperationResult();
                }


                private void FormularioListadoBase_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.Control == true & e.Alt == false & e.Shift == false) {
                                switch (e.KeyCode) {
                                        case Keys.U:
                                                e.Handled = true;
                                                foreach (Lfx.Data.FormField Fld in this.FormFields) {
                                                        if (FormFieldToSubItem.ContainsKey(Lfx.Data.Connection.GetFieldName(Fld.ColumnName)))
                                                                Listado.Columns[FormFieldToSubItem[Lfx.Data.Connection.GetFieldName(Fld.ColumnName)]].Width = Fld.Width;
                                                }
                                                break;
                                }
                        }
                }


                protected void SaveColumns()
                {
                        try {
                                foreach (ColumnHeader Ch in Listado.Columns) {
                                        this.Workspace.CurrentConfig.WriteLocalSetting(this.GetType().ToString(), "Columns." + Ch.Name + ".Width", Ch.Width);
                                }
                        } catch {
                        }
                }


                protected bool ColumnsLoaded = false;
                protected void LoadColumns()
                {
                        if (ColumnsLoaded == false) {
                                try {
                                        foreach (ColumnHeader Ch in Listado.Columns) {
                                                Ch.Width = this.Workspace.CurrentConfig.ReadLocalSettingInt(this.GetType().ToString(), "Columns." + Ch.Name + ".Width", Ch.Width);
                                        }
                                        ColumnsLoaded = true;
                                } catch {
                                }
                        }
                }


                private void BotonFiltrar_Click(object sender, EventArgs e)
                {
                        this.OnFilter();
                }


                private void BotonImprimir_Click(object sender, EventArgs e)
                {
                        if ((System.Windows.Forms.Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                                this.ShowExportDialog();
                        else
                                this.OnPrint(false);
                }


                private void BotonCancelar_Click(object sender, EventArgs e)
                {
                        this.Close();
                }


                protected virtual void OnItemAdded(ListViewItem item, Lfx.Data.Row row)
                {
                }


                protected virtual void OnBeginRefreshList()
                {
                        this.LastGroupingValue = null;
                        this.LastGroup = null;

                        foreach (Contador Cont in Contadores) {
                                Cont.Reset();
                        }
                }


                public Lbl.ListaIds CodigosSeleccionados
                {
                        get
                        {
                                if (Listado.CheckBoxes && Listado.CheckedItems.Count > 0) {
                                        Lbl.ListaIds Res = new Lbl.ListaIds();
                                        foreach (ListViewItem itm in Listado.CheckedItems) {
                                                Res.Add(Lfx.Types.Parsing.ParseInt(itm.Text));
                                        }
                                        return Res;
                                } else if (Listado.SelectedItems.Count > 0) {
                                        Lbl.ListaIds Res = new Lbl.ListaIds();
                                        foreach (ListViewItem itm in Listado.SelectedItems) {
                                                Res.Add(Lfx.Types.Parsing.ParseInt(itm.Text));
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


                protected virtual void OnEndRefreshList()
                {
                        if (Contadores.Count == 0) {
                                PanelContadores.Visible = false;
                        } else {
                                PanelContadores.Visible = true;

                                // TODO: hacer esto con más de 4 contadores, tal vez
                                if (this.Contadores.Count >= 1) {
                                        Contador Cont1 = this.Contadores[0];
                                        EtiquetaContador1.Text = Cont1.Etiqueta;
                                        EtiquetaContador1.Visible = true;
                                        EntradaContador1.DataType = Cont1.DataType;
                                        EntradaContador1.Prefijo = Cont1.Prefijo;
                                        EntradaContador1.Sufijo = Cont1.Sufijo;
                                        EntradaContador1.ValueDecimal = Cont1.Total;
                                        EntradaContador1.Visible = true;
                                } else {
                                        EtiquetaContador1.Visible = false;
                                        EntradaContador1.Visible = false;
                                }

                                if (this.Contadores.Count >= 2) {
                                        Contador Cont2 = this.Contadores[1];
                                        EtiquetaContador2.Text = Cont2.Etiqueta;
                                        EtiquetaContador2.Visible = true;
                                        EntradaContador2.DataType = Cont2.DataType;
                                        EntradaContador2.Prefijo = Cont2.Prefijo;
                                        EntradaContador2.Sufijo = Cont2.Sufijo;
                                        EntradaContador2.ValueDecimal = Cont2.Total;
                                        EntradaContador2.Visible = true;
                                } else {
                                        EtiquetaContador2.Visible = false;
                                        EntradaContador2.Visible = false;
                                }

                                if (this.Contadores.Count >= 3) {
                                        Contador Cont3 = this.Contadores[2];
                                        EtiquetaContador3.Text = Cont3.Etiqueta;
                                        EtiquetaContador3.Visible = true;
                                        EntradaContador3.DataType = Cont3.DataType;
                                        EntradaContador3.Prefijo = Cont3.Prefijo;
                                        EntradaContador3.Sufijo = Cont3.Sufijo;
                                        EntradaContador3.ValueDecimal = Cont3.Total;
                                        EntradaContador3.Visible = true;
                                } else {
                                        EtiquetaContador3.Visible = false;
                                        EntradaContador3.Visible = false;
                                }

                                if (this.Contadores.Count >= 4) {
                                        Contador Cont4 = this.Contadores[3];
                                        EtiquetaContador4.Text = Cont4.Etiqueta;
                                        EtiquetaContador4.Visible = true;
                                        EntradaContador4.DataType = Cont4.DataType;
                                        EntradaContador4.Prefijo = Cont4.Prefijo;
                                        EntradaContador4.Sufijo = Cont4.Sufijo;
                                        EntradaContador4.ValueDecimal = Cont4.Total;
                                        EntradaContador4.Visible = true;
                                } else {
                                        EtiquetaContador4.Visible = false;
                                        EntradaContador4.Visible = false;
                                }
                        }
                }


                private void Listado_KeyDown(object sender, KeyEventArgs e)
                {
                        if (e.Shift == false && e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case Keys.Return:
                                                if (Listado.SelectedItems.Count > 0) {
                                                        e.Handled = true;
                                                        Lfx.Types.OperationResult Res = this.OnItemClick(Listado.SelectedItems[0]);
                                                        if (Res.Success == false && Res.Message != null)
                                                                Lui.Forms.MessageBox.Show(Res.Message, "Error");
                                                }
                                                break;
                                }
                        }
                }

                protected virtual Lfx.Types.OperationResult OnEdit(int itemId)
                {
                        if (itemId > 0 && this.ElementoTipo != null && Lbl.Sys.Config.Actual.UsuarioConectado.TienePermiso(this.ElementoTipo, Lbl.Sys.Permisos.Operaciones.Ver)) {
                                Lfx.Data.Connection NuevaDb = this.Workspace.GetNewConnection("Editar " + this.ElementoTipo.ToString() + " " + itemId);
                                Lbl.IElementoDeDatos Elem = Lbl.Instanciador.Instanciar(this.ElementoTipo, NuevaDb, itemId);
                                Lfc.FormularioEdicion FormNuevo = Lfc.Instanciador.InstanciarFormularioEdicion(Elem);
                                FormNuevo.DisposeConnection = true;
                                FormNuevo.MdiParent = this.MdiParent;
                                FormNuevo.Show();

                                return new Lfx.Types.SuccessOperationResult();
                        } else {
                                return new Lfx.Types.NoAccessOperationResult();
                        }
                }


                protected virtual Lfx.Types.OperationResult OnItemClick(ListViewItem itm)
                {
                        int SelectedId = Lfx.Types.Parsing.ParseInt(Listado.SelectedItems[0].Text);
                        return this.OnEdit(SelectedId);
                }


                private void Listado_DoubleClick(object sender, System.EventArgs e)
                {
                        if (Listado.SelectedItems.Count > 0)
                                this.OnItemClick(Listado.SelectedItems[0]);
                }


                private void Listado_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
                {
                        string NuevoOrden = null;

                        if (e.Column == 0)
                                NuevoOrden = this.m_KeyField.ColumnName;
                        else if ((e.Column - 1) < m_FormFields.Count)
                                NuevoOrden = Listado.Columns[e.Column].Name;

                        NuevoOrden = Lfx.Data.Connection.GetFieldName(NuevoOrden);

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


                protected void UpdateFormFields()
                {
                        if (this.HasWorkspace && this.Connection != null && m_FormFields != null) {
                                SubItemToFormField.Clear();
                                FormFieldToSubItem.Clear();

                                Listado.BeginUpdate();
                                Listado.SuspendLayout();

                                Listado.Items.Clear();
                                Listado.Groups.Clear();

                                int ColNum = 0;
                                Listado.Columns.Clear();

                                Listado.Columns.Add(new ColumnHeader());
                                Listado.Columns[ColNum].Name = Lfx.Data.Connection.GetFieldName(m_KeyField.ColumnName);
                                Listado.Columns[ColNum].Width = m_KeyField.Width;
                                Listado.Columns[ColNum].Text = m_KeyField.Label;

                                if (FormFieldToSubItem.ContainsKey(Listado.Columns[ColNum].Name) == false)
                                        FormFieldToSubItem.Add(Listado.Columns[ColNum].Name, ColNum);
                                if (FormFieldToSubItem.ContainsKey(m_KeyField.ColumnName) == false)
                                        FormFieldToSubItem.Add(m_KeyField.ColumnName, ColNum);

                                ColNum++;

                                for (int i = 0; i < m_FormFields.Count; i++) {
                                        if (m_FormFields[i].Visible) {
                                                if (Listado.Columns.Count <= ColNum)
                                                        Listado.Columns.Add(new ColumnHeader());

                                                Listado.Columns[ColNum].Name = Lfx.Data.Connection.GetFieldName(m_FormFields[i].ColumnName);
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

                                Listado.ResumeLayout();
                                Listado.EndUpdate();
                        }
                }


                public virtual void RefreshList()
                {
                        if (this.HasWorkspace == false || this.Connection == null)
                                return;

                        LastGroup = null;

                        this.UpdateFormFields();
                        this.LoadColumns();
                        this.OnBeginRefreshList();

                        this.Fill(this.SelectCommand(false));

                        this.OnEndRefreshList();
                }


                protected qGen.Select SelectCommand(bool forCount)
                {
                        if (this.HasWorkspace && this.Connection != null && m_NombreTabla != null) {
                                qGen.Select ComandoSelect = new qGen.Select(this.Connection.SqlMode);

                                // Genero la lista de tablas, con JOIN y todo
                                string ListaTablas = null;
                                ListaTablas = m_NombreTabla;

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
                                        if (this.SearchText.IsNumericInt())
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

                                if (this.GroupBy != null)
                                        ComandoSelect.Group = this.GroupBy.ColumnName;

                                if (this.Having != null)
                                        ComandoSelect.HavingClause = this.Having;

                                ComandoSelect.Order = this.OrderBy;
                                return ComandoSelect;
                        } else {
                                return null;
                        }
                }


                private bool CancelFill = false;
                protected void Fill(qGen.Select command)
                {
                        CancelFill = false;

                        if (this.HasWorkspace == false || command == null)
                                return;

                        System.Data.DataTable Tabla = this.Connection.Select(command);

                        ListViewItem CurItem = null;
                        Lbl.ListaIds CheckedItems = null;

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
                                CheckedItems = new Lbl.ListaIds();
                                foreach (ListViewItem Itm in Listado.CheckedItems) {
                                        CheckedItems.Add(Lfx.Types.Parsing.ParseInt(Itm.Text));
                                }
                        }

                        EtiquetaCantidad.Text = "Cargando...";
                        EtiquetaCantidad.Refresh();

                        Listado.SuspendLayout();
                        Listado.BeginUpdate();
                        Listado.Items.Clear();

                        if (Tabla != null && Tabla.Rows.Count > 0) {
                                foreach (System.Data.DataRow DtRow in Tabla.Rows) {
                                        Lfx.Data.Row Registro = (Lfx.Data.Row)DtRow;

                                        string NombreCampoId = Lfx.Data.Connection.GetFieldName(m_KeyField.ColumnName);
                                        int ItemId = Registro.Fields[NombreCampoId].ValueInt;

                                        ListViewItem Itm = this.FormatListViewItem(ItemId, Registro);

                                        if (CheckedItems != null && CheckedItems.Contains(ItemId))
                                                Itm.Checked = true;

                                        if (CancelFill) {
                                                Listado.EndUpdate();
                                                Listado.ResumeLayout();
                                                return;
                                        }

                                        Listado.Items.Add(Itm);
                                        // Agrego el item a un grupo, si hay agrupación activa
                                        if (m_GroupingColumnName != null) {
                                                string FormattedGroupingValue = this.FormatValue(Registro[m_GroupingColumnName], m_FormFields[m_GroupingColumnName]);
                                                if (LastGroupingValue != FormattedGroupingValue) {
                                                        LastGroupingValue = FormattedGroupingValue;
                                                        if (Listado.Groups[LastGroupingValue] != null)
                                                                LastGroup = Listado.Groups[LastGroupingValue];
                                                        else
                                                                LastGroup = Listado.Groups.Add(LastGroupingValue, LastGroupingValue);
                                                }
                                        }
                                        Itm.Group = LastGroup;
                                        Itm.Tag = Registro;

                                        OnItemAdded(Itm, Registro);
                                        if (CurItem != null && Itm.Text == CurItem.Text)
                                                CurItem = Itm;

                                        if ((Listado.Items.Count % 100) == 0) {
                                                // Cuando ya tengo algunos como para mostrar, actualizo el listview
                                                // así parece que el listado ya cargó, cuando en realidad sigue cargando
                                                EtiquetaCantidad.Text = "Cargando " + Listado.Items.Count.ToString() + " elementos";
                                                Listado.EndUpdate();
                                                System.Windows.Forms.Application.DoEvents();
                                                Listado.BeginUpdate();
                                                Listado.SuspendLayout();
                                        }
                                }
                        }

                        if (Listado.Items.Count > 0 && Listado.SelectedItems.Count == 0) {
                                Listado.Items[0].Focused = true;
                                Listado.Items[0].Selected = true;
                        }

                        if (Listado.Items.Count == m_Limit)
                                EtiquetaCantidad.Text = "";
                        else
                                EtiquetaCantidad.Text = Listado.Items.Count.ToString() + " elementos";

                        // Muestro los totales de grupo

                        if (m_GroupingColumnName != null) {
                                foreach (ListViewGroup Grp in Listado.Groups) {
                                        Grp.Header = Grp.Name + " (" + Grp.Items.Count.ToString() + ")";
                                        ListViewItem Itm = Listado.Items.Add("Subtotales");
                                        Itm.Font = new Font(Itm.Font, FontStyle.Bold);
                                        Itm.BackColor = Color.Lavender;
                                        foreach (ColumnHeader Col in Listado.Columns) {
                                                if (Col.Name != Lfx.Data.Connection.GetFieldName(this.KeyField.ColumnName)) {
                                                        Itm.Group = Grp;
                                                        object ColFunc = FormFields[Col.Name].TotalFunction;
                                                        if (ColFunc == null) {
                                                                Itm.SubItems.Add("");
                                                        } else if (ColFunc is Lfx.FileFormats.Office.Spreadsheet.QuickFunctions) {
                                                                Lfx.FileFormats.Office.Spreadsheet.QuickFunctions QuickFunc = (Lfx.FileFormats.Office.Spreadsheet.QuickFunctions)(FormFields[Col.Name].TotalFunction);
                                                                switch (QuickFunc) {
                                                                        case Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Count:
                                                                                Itm.SubItems.Add(Grp.Items.Count.ToString());
                                                                                break;
                                                                        case Lfx.FileFormats.Office.Spreadsheet.QuickFunctions.Sum:
                                                                                decimal Res = 0;
                                                                                foreach (ListViewItem SubItm in Grp.Items) {
                                                                                        Lfx.Data.Row Rw = SubItm.Tag as Lfx.Data.Row;
                                                                                        if (Rw != null)
                                                                                                Res += Rw.Fields[Col.Name].ValueDecimal;
                                                                                }
                                                                                Itm.SubItems.Add(Lfx.Types.Formatting.FormatCurrency(Res));
                                                                                break;
                                                                        default:
                                                                                Itm.SubItems.Add("");
                                                                                break;
                                                                }
                                                        } else {
                                                                Itm.SubItems.Add(ColFunc.ToString());
                                                        }
                                                }
                                        }
                                }
                        }

                        Listado.EndUpdate();
                        Listado.ResumeLayout();

                        if (CurItem != null) {
                                CurItem.Selected = true;
                                CurItem.Focused = true;
                                CurItem.EnsureVisible();
                        }

                        CancelFill = true;
                }


                protected virtual Lfx.FileFormats.Office.Spreadsheet.Row FormatRow(int itemId, Lfx.Data.Row row, Lfx.FileFormats.Office.Spreadsheet.Sheet sheet, Lfx.Data.FormFieldCollection useFields)
                {
                        Lfx.FileFormats.Office.Spreadsheet.Row Reng = new Lfx.FileFormats.Office.Spreadsheet.Row(sheet);

                        if (m_KeyField != null) {
                                Lfx.FileFormats.Office.Spreadsheet.Cell KeyCell = Reng.Cells.Add();
                                KeyCell.Content = itemId;
                        }

                        for (int FieldNum = 0; FieldNum < useFields.Count; FieldNum++) {
                                string FieldName = Lfx.Data.Connection.GetFieldName(useFields[FieldNum].ColumnName);

                                if (FieldNum >= 0) {
                                        Lfx.FileFormats.Office.Spreadsheet.Cell NewCell = Reng.Cells.Add();

                                        switch (useFields[FieldNum].DataType) {
                                                case Lfx.Data.InputFieldTypes.Integer:
                                                case Lfx.Data.InputFieldTypes.Serial:
                                                case Lfx.Data.InputFieldTypes.Relation:
                                                        if (row[FieldName] == null || row[FieldName] is DBNull)
                                                                NewCell.Content = null;
                                                        else if (useFields[FieldNum].Format != null)
                                                                NewCell.Content = System.Convert.ToInt32(row[FieldName]).ToString(useFields[FieldNum].Format);
                                                        else
                                                                NewCell.Content = System.Convert.ToInt32(row[FieldName]).ToString();
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Text:
                                                case Lfx.Data.InputFieldTypes.Memo:
                                                        if (row[FieldName] == null)
                                                                NewCell.Content = null;
                                                        else if (row[FieldName] is System.Byte[])
                                                                NewCell.Content = System.Text.Encoding.Default.GetString(((System.Byte[])(row[FieldName])));
                                                        else
                                                                NewCell.Content = row.Fields[FieldName].Value.ToString();
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Currency:
                                                        double ValorCur = (row[FieldName] == null || row[FieldName] is DBNull) ? 0 : System.Convert.ToDouble(row[FieldName]);
                                                        NewCell.Content = ValorCur;
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Numeric:
                                                        if (row[FieldName] == null || row[FieldName] is DBNull)
                                                                NewCell.Content = null;
                                                        else
                                                                NewCell.Content = System.Convert.ToDouble(row[FieldName]);
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Date:
                                                        if (row.Fields[FieldName].Value != null)
                                                                NewCell.Content = row.Fields[FieldName].ValueDateTime;
                                                        break;

                                                case Lfx.Data.InputFieldTypes.DateTime:
                                                        NewCell.Content = row[FieldName];
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Bool:
                                                        if (System.Convert.ToBoolean(row[FieldName]))
                                                                NewCell.Content = "Si";
                                                        else
                                                                NewCell.Content = "No";
                                                        break;

                                                case Lfx.Data.InputFieldTypes.Set:
                                                        int SetValue = System.Convert.ToInt32(row[FieldName]);
                                                        if (useFields[FieldNum] != null && useFields[FieldNum].SetValues != null & useFields[FieldNum].SetValues.ContainsKey(SetValue))
                                                                NewCell.Content = useFields[FieldNum].SetValues[SetValue];
                                                        else
                                                                NewCell.Content = "???";
                                                        break;

                                                default:
                                                        NewCell.Content = row[FieldName];
                                                        break;
                                        }
                                }
                        }

                        return Reng;
                }


                private ListViewItem FormatListViewItem(int itemId, Lfx.Data.Row row)
                {
                        ListViewItem Itm = new ListViewItem(itemId.ToString("000000"));

                        for (int ColNum = 1; ColNum < Listado.Columns.Count; ColNum++) {
                                string FieldName = Listado.Columns[ColNum].Name;

                                string FieldValueAsText;
                                int FieldNum = -1;
                                if (SubItemToFormField.ContainsKey(FieldName) == false) {
                                        for (int fi = 0; fi < FormFields.Count; fi++) {
                                                if (Lfx.Data.Connection.GetFieldName(FormFields[fi].ColumnName) == FieldName) {
                                                        FieldNum = fi;
                                                        SubItemToFormField.Add(FieldName, FieldNum);
                                                        break;
                                                }
                                        }
                                } else {
                                        FieldNum = SubItemToFormField[FieldName];
                                }
                                int RowField = FieldNum + 1;

                                FieldValueAsText = this.FormatValue(row[RowField], m_FormFields[FieldNum]);

                                if (FieldNum == -1) {
                                        Itm.Text = FieldValueAsText;
                                } else {
                                        ListViewItem.ListViewSubItem SubItm = Itm.SubItems.Add(FieldValueAsText);
                                        SubItm.Name = FieldName;
                                }
                        }
                        return Itm;
                }


                private string FormatValue(object cellValue, Lfx.Data.FormField formField)
                {
                        string FieldValueAsText;

                        if (cellValue == null)
                                return "";

                        if (formField == null)
                                return cellValue.ToString();

                        switch (formField.DataType) {
                                case Lfx.Data.InputFieldTypes.Integer:
                                case Lfx.Data.InputFieldTypes.Serial:
                                case Lfx.Data.InputFieldTypes.Relation:
                                        if (cellValue == null || cellValue is DBNull)
                                                FieldValueAsText = "";
                                        else if (formField.Format != null)
                                                FieldValueAsText = System.Convert.ToInt32(cellValue).ToString(formField.Format);
                                        else
                                                FieldValueAsText = System.Convert.ToInt32(cellValue).ToString();
                                        break;

                                case Lfx.Data.InputFieldTypes.Text:
                                case Lfx.Data.InputFieldTypes.Memo:
                                        if (cellValue == null)
                                                FieldValueAsText = "";
                                        else if (cellValue is System.Byte[])
                                                FieldValueAsText = System.Text.Encoding.Default.GetString(((System.Byte[])(cellValue)));
                                        else
                                                FieldValueAsText = cellValue.ToString();
                                        break;

                                case Lfx.Data.InputFieldTypes.Currency:
                                        decimal ValorCur = (cellValue == null || cellValue is DBNull) ? 0 : System.Convert.ToDecimal(cellValue);
                                        if (ValorCur == 0)
                                                FieldValueAsText = "-";
                                        else
                                                FieldValueAsText = Lfx.Types.Formatting.FormatCurrency(ValorCur, this.Workspace.CurrentConfig.Moneda.Decimales);
                                        break;

                                case Lfx.Data.InputFieldTypes.Numeric:
                                        if (cellValue == null || cellValue is DBNull)
                                                FieldValueAsText = "";
                                        else
                                                FieldValueAsText = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(cellValue));
                                        break;

                                case Lfx.Data.InputFieldTypes.Date:
                                        if (cellValue != null) {
                                                if (formField.Format != null)
                                                        FieldValueAsText = System.Convert.ToDateTime(cellValue).ToString(formField.Format).ToTitleCase();
                                                else
                                                        FieldValueAsText = System.Convert.ToDateTime(cellValue).ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);
                                        } else {
                                                FieldValueAsText = "";
                                        }
                                        break;

                                case Lfx.Data.InputFieldTypes.DateTime:
                                        if (cellValue != null) {
                                                if (formField.Format != null)
                                                        FieldValueAsText = System.Convert.ToDateTime(cellValue).ToString(formField.Format).ToTitleCase();
                                                else
                                                        FieldValueAsText = System.Convert.ToDateTime(cellValue).ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern);
                                        } else {
                                                FieldValueAsText = "";
                                        }
                                        break;

                                case Lfx.Data.InputFieldTypes.Bool:
                                        if (System.Convert.ToBoolean(cellValue))
                                                FieldValueAsText = "Si";
                                        else
                                                FieldValueAsText = "No";
                                        break;

                                case Lfx.Data.InputFieldTypes.Set:
                                        int SetValue = System.Convert.ToInt32(cellValue);
                                        if (formField != null && formField.SetValues != null & formField.SetValues.ContainsKey(SetValue))
                                                FieldValueAsText = formField.SetValues[SetValue];
                                        else
                                                FieldValueAsText = "???";
                                        break;

                                default:
                                        switch (cellValue.GetType().ToString()) {
                                                case "System.Single":
                                                case "System.Double":
                                                        if (System.Convert.ToDouble(cellValue) == 0)
                                                                FieldValueAsText = "-";
                                                        else
                                                                FieldValueAsText = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(cellValue));
                                                        break;

                                                case "System.Decimal":
                                                        if (System.Convert.ToDecimal(cellValue) == 0)
                                                                FieldValueAsText = "-";
                                                        else
                                                                FieldValueAsText = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDecimal(cellValue), 4);
                                                        break;

                                                case "System.Integer":
                                                case "System.Int16":
                                                case "System.Int32":
                                                case "System.Int64":
                                                        if (System.Convert.ToInt32(cellValue) == 0)
                                                                FieldValueAsText = "-";
                                                        else
                                                                FieldValueAsText = Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(cellValue), 0);
                                                        break;

                                                case "System.DateTime":
                                                        FieldValueAsText = Lfx.Types.Formatting.FormatDate(cellValue);
                                                        break;

                                                case "System.String":
                                                        FieldValueAsText = System.Convert.ToString(cellValue);
                                                        break;

                                                case "System.Byte[]":
                                                        FieldValueAsText = System.Text.Encoding.Default.GetString((byte[])cellValue);
                                                        break;

                                                case "System.DBNull":
                                                        FieldValueAsText = "";
                                                        break;

                                                default:
                                                        FieldValueAsText = cellValue.ToString();
                                                        break;
                                        }
                                        break;
                        }
                        return FieldValueAsText;
                }

                protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
                {
                        this.SaveColumns();

                        base.OnClosing(e);
                }

                protected override void OnActivated(EventArgs e)
                {
                        if (this.Text == "Listado" && this.ElementoTipo != null) {
                                Lbl.Atributos.NombreItem Attr = this.ElementoTipo.GetAttribute<Lbl.Atributos.NombreItem>();
                                if (Attr != null)
                                        this.Text = "Listado de " + Attr.Nombre;
                        }

                        // Sólo refresco si no hay filtros y cuando son pocos elementos
                        // if (this.Visible && this.Listado.Items.Count < 500 && (this.Connection.SlowLink == false || this.Listado.Items.Count == 0))
                        //        RefreshTimer.Start();

                        base.OnActivated(e);
                }


                protected virtual void ShowExportDialog()
                {
                        using (Lfc.FormularioListadoExportar FormExportar = new Lfc.FormularioListadoExportar()) {
                                if (FormExportar.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                                        FormatoExportar Formato = FormExportar.SaveFormat;
                                        if (Formato == FormatoExportar.Imprimir) {
                                                this.OnPrint(true);
                                        } else {
                                                SaveFileDialog DialogoGuardar = new SaveFileDialog();
                                                DialogoGuardar.OverwritePrompt = true;
                                                DialogoGuardar.ValidateNames = true;
                                                DialogoGuardar.CheckPathExists = true;
                                                switch (Formato) {
                                                        case FormatoExportar.Html:
                                                                DialogoGuardar.DefaultExt = ".html";
                                                                DialogoGuardar.Filter = "Formato HTML|*.htm;*.html";
                                                                break;
                                                        case FormatoExportar.Excel:
                                                                DialogoGuardar.DefaultExt = ".xls";
                                                                DialogoGuardar.Filter = "Formato XML de Microsoft Excel|*.xls";
                                                                break;
                                                        case FormatoExportar.ExcelXml:
                                                                DialogoGuardar.DefaultExt = ".xls";
                                                                DialogoGuardar.Filter = "Formato de Microsoft Excel|*.xls";
                                                                break;
                                                }

                                                DialogoGuardar.FileName = this.Text.Replace(":", "");
                                                if (DialogoGuardar.ShowDialog() == DialogResult.OK) {
                                                        Lfx.FileFormats.Office.Spreadsheet.Workbook Workbook = this.ToWorkbook();
                                                        string FileName = DialogoGuardar.FileName;
                                                        switch (Formato) {
                                                                case FormatoExportar.Html:
                                                                        Workbook.SaveTo(FileName, Lfx.FileFormats.Office.Spreadsheet.SaveFormats.Html);
                                                                        break;
                                                                case FormatoExportar.Excel:
                                                                        Workbook.SaveTo(FileName, Lfx.FileFormats.Office.Spreadsheet.SaveFormats.Excel);
                                                                        break;
                                                                case FormatoExportar.ExcelXml:
                                                                        Workbook.SaveTo(FileName, Lfx.FileFormats.Office.Spreadsheet.SaveFormats.ExcelXml);
                                                                        break;
                                                        }
                                                }
                                        }
                                }
                        }
                }

                public virtual Lfx.FileFormats.Office.Spreadsheet.Workbook ToWorkbook()
                {
                        return ToWorkbook(this.FormFields);
                }

                public virtual Lfx.FileFormats.Office.Spreadsheet.Workbook ToWorkbook(Lfx.Data.FormFieldCollection useFields)
                {
                        Lfx.FileFormats.Office.Spreadsheet.Workbook Res = new Lfx.FileFormats.Office.Spreadsheet.Workbook();
                        Lfx.FileFormats.Office.Spreadsheet.Sheet Sheet = new Lfx.FileFormats.Office.Spreadsheet.Sheet(this.Text);
                        Res.Sheets.Add(Sheet);

                        // Exporto los encabezados de columna
                        Sheet.ColumnHeaders.Add(new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader(KeyField.Label, KeyField.Width));
                        Sheet.ColumnHeaders[0].DataType = KeyField.DataType;
                        Sheet.ColumnHeaders[0].Format = KeyField.Format;
                        Sheet.ColumnHeaders[0].Printable = KeyField.Printable;

                        int OrderColumn = -1;
                        if (useFields != null) {
                                for (int i = 0; i <= useFields.Count - 1; i++) {
                                        Lfx.FileFormats.Office.Spreadsheet.ColumnHeader ColHead = new Lfx.FileFormats.Office.Spreadsheet.ColumnHeader(useFields[i].Label, useFields[i].Width);
                                        ColHead.Name = Lfx.Data.Connection.GetFieldName(useFields[i].ColumnName);
                                        ColHead.TextAlignment = useFields[i].Alignment;
                                        ColHead.DataType = useFields[i].DataType;
                                        ColHead.Format = useFields[i].Format;
                                        ColHead.TotalFunction = useFields[i].TotalFunction;
                                        ColHead.Printable = useFields[i].Printable;
                                        Sheet.ColumnHeaders.Add(ColHead);

                                        if (ColHead.Name == this.OrderBy)
                                                OrderColumn = Sheet.ColumnHeaders.Count - 1;

                                        if (ColHead.Name == this.GroupingColumnName)
                                                Sheet.ColumnHeaders.GroupingColumn = Sheet.ColumnHeaders.Count - 1;
                                }
                        }

                        // Exporto los renglones
                        System.Data.DataTable Tabla = this.Connection.Select(this.SelectCommand(false));
                        foreach (System.Data.DataRow DtRow in Tabla.Rows) {
                                Lfx.Data.Row Registro = (Lfx.Data.Row)DtRow;

                                string NombreCampoId = Lfx.Data.Connection.GetFieldName(m_KeyField.ColumnName);
                                int ItemId = Registro.Fields[NombreCampoId].ValueInt;

                                Lfx.FileFormats.Office.Spreadsheet.Row Reng = this.FormatRow(ItemId, Registro, Sheet, useFields);

                                Sheet.Rows.Add(Reng);
                        }

                        if (OrderColumn >= 0) {
                                if (m_GroupingColumnName != null) {
                                        Sheet.SortByGroupAndColumn(OrderColumn, true);
                                } else {
                                        if (OrderColumn >= 0)
                                                Sheet.Sort(OrderColumn, true);
                                }
                        }

                        return Res;
                }

                private void RefreshTimer_Tick(object sender, EventArgs e)
                {
                        RefreshTimer.Stop();
                        System.Windows.Forms.Application.DoEvents();
                        this.RefreshList();
                }

                private void FormularioListadoBase_FormClosing(object sender, FormClosingEventArgs e)
                {
                        CancelFill = true;
                }
        }
}