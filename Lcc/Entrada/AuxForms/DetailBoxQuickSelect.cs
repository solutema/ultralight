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
using System.Drawing;
using System.Windows.Forms;

namespace Lcc.Entrada.AuxForms
{
        public partial class DetailBoxQuickSelect : System.Windows.Forms.Form, Lui.Forms.IDataForm
        {
                private string m_Table = "";
                private string m_KeyField = "";
                private string m_DetailField = "";
                private string m_ExtraDetailFields = "";
                private string m_Filter = "";
                private bool m_Changed = false;
                private bool f_IgnoreEvents;
                public System.Windows.Forms.Control ControlDestino;

                public bool CanCreate
                {
                        set
                        {
                                BotonNuevo.Visible = value;
                                if (value)
                                        EntradaBuscar.Width = BotonNuevo.Left - (EntradaBuscar.Left * 2);
                                else
                                        EntradaBuscar.Width = this.ClientSize.Width - (EntradaBuscar.Left * 2);
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string Table
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
                public string KeyField
                {
                        set
                        {
                                m_KeyField = value;
                                UpdateDetail();
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string DetailField
                {
                        set
                        {
                                m_DetailField = value;
                                UpdateDetail();
                        }
                }

                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public bool Changed
                {
                        get
                        {
                                return m_Changed;
                        }
                        set
                        {
                                m_Changed = value;
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string ExtraDetailFields
                {
                        set
                        {
                                m_ExtraDetailFields = value;
                                UpdateDetail();
                        }
                }

                [System.ComponentModel.Category("Datos")]
                public string Filter
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

                        if (m_Table == "ciudades" && (m_ExtraDetailFields == null || m_ExtraDetailFields.Length == 0))
                                m_ExtraDetailFields = "cp";

                        if (m_ExtraDetailFields != null)
                                CamposExtra = m_ExtraDetailFields.Length - m_ExtraDetailFields.Replace(",", "").Length + 1;

                        if (CamposExtra > 4)
                                CamposExtra = 4;

                        this.Width = 480 + (80 * CamposExtra);
                        if (ListaItem.Columns.Count > 0)
                                ListaItem.Columns[1].Width = ListaItem.Width - ListaItem.Columns[0].Width - (80 * CamposExtra) - 20;

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


                public void Buscar(string valorInicial)
                {
                        Refrescar();
                        f_IgnoreEvents = true;
                        EntradaBuscar.Text = valorInicial.Trim();
                        f_IgnoreEvents = false;
                        EntradaBuscar.SelectionLength = 0;
                        EntradaBuscar.SelectionStart = EntradaBuscar.Text.Length;
                        this.Refrescar();
                        if (!this.Visible)
                                this.ShowDialog();
                }

                internal void Refrescar()
                {
                        ListaItem.Items.Clear();
                        if (this.Workspace != null && this.DataBase != null) {
                                if (m_Table.Length > 0 && m_KeyField.Length > 0 && m_DetailField.Length > 0) {
                                        string TextoSql = null;
                                        string sBuscar = EntradaBuscar.Text;

                                        sBuscar = this.DataBase.EscapeString(sBuscar.Replace("  ", " ").Trim());

                                        if (m_Table.Length >= 7 && m_Table.Substring(0, 7) == "SELECT ") {
                                                TextoSql = m_Table;
                                        } else {
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
                                                        TextoSql += " WHERE (" + m_DetailField + " LIKE '" + this.DataBase.EscapeString(sBuscar) + "%'";

                                                if (m_ExtraDetailFields != null && m_ExtraDetailFields.Length > 0 && sBuscar != null && sBuscar.Length > 1) {
                                                        string TempExtraDetailFields = m_ExtraDetailFields;
                                                        string TempWhere = "";
                                                        string ExtraField = Lfx.Types.Strings.GetNextToken(ref TempExtraDetailFields, ",");
                                                        while (ExtraField.Length > 0) {
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

                                                if (m_Filter != null && m_Filter.Length > 0) {
                                                        if (TextoSql.IndexOf(" WHERE ") != -1)
                                                                TextoSql += " AND (" + m_Filter + ")";
                                                        else
                                                                TextoSql += " WHERE " + m_Filter;
                                                }

                                                if (m_Table == "articulos")
                                                        TextoSql += " ORDER BY IF(stock_actual+pedido>0,0,1), " + m_DetailField;
                                                else
                                                        TextoSql += " ORDER BY " + m_DetailField;

                                                // TODO: Código dependiente de MySql/PostgreSql. Pasar a qGen.SqlCommandBuilder
                                                if (this.Workspace.SlowLink)
                                                        TextoSql += " LIMIT 40";
                                                else
                                                        TextoSql += " LIMIT 100";
                                        }

                                        System.Data.DataTable dt = this.DataBase.Select(TextoSql);
                                        ListaItem.SuspendLayout();
                                        ListaItem.BeginUpdate();
                                        foreach (System.Data.DataRow row in dt.Rows) {
                                                ListViewItem itm = ListaItem.Items.Add(System.Convert.ToInt32(row[m_KeyField]).ToString("00000"));
                                                itm.SubItems.Add(new ListViewItem.ListViewSubItem(itm, System.Convert.ToString(row[m_DetailField])));
                                                if (m_ExtraDetailFields != null && m_ExtraDetailFields.Length > 0) {
                                                        string TempExtraDetailFields = m_ExtraDetailFields;
                                                        string Campo = Lfx.Types.Strings.GetNextToken(ref TempExtraDetailFields, ",").Trim();
                                                        while (Campo.Length > 0) {
                                                                switch (row[Campo].GetType().ToString()) {
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
                                                if (m_Table == "articulos") {
                                                        if (System.Convert.ToInt32(row["control_stock"]) != 0 && System.Convert.ToDouble(row["stock_actual"]) <= 0) {
                                                                // No hay stock.
                                                                if (System.Convert.ToDouble(row["pedido"]) + System.Convert.ToDouble(row["stock_actual"]) > 0) {
                                                                        // Pero hay pedido suficiente para cubrir un stock negativo y sobra
                                                                        itm.ForeColor = System.Drawing.Color.OrangeRed;
                                                                        itm.Font = new Font(itm.Font, FontStyle.Regular);
                                                                } else {
                                                                        itm.ForeColor = System.Drawing.Color.Red;
                                                                        itm.Font = new Font(itm.Font, FontStyle.Strikeout);
                                                                }
                                                        } else if (System.Convert.ToInt32(row["destacado"]) != 0) {
                                                                itm.ForeColor = System.Drawing.Color.DarkGreen;
                                                                itm.Font = new Font(itm.Font, FontStyle.Regular);
                                                        }
                                                }
                                        }
                                        ListaItem.EndUpdate();
                                        ListaItem.ResumeLayout();

                                        if (ListaItem.Items.Count > 0)
                                                ListaItem.Items[0].Selected = true;
                                }
                        }
                }


                private void EntradaBuscar_TextChanged(object sender, System.EventArgs e)
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


                private void EntradaBuscar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        byte Tecla = System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0];
                        if (Tecla == System.Convert.ToByte(Keys.Escape)) {
                                e.Handled = true;
                                this.Close();
                        } else if (Tecla == System.Convert.ToByte(Keys.Return)) {
                                e.Handled = true;
                                this.DarleEnter();
                        }
                }


                private void EntradaBuscar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        if (ListaItem.Items.Count > 0) {
                                switch (e.KeyCode) {
                                        case Keys.Up:
                                                if (ListaItem.SelectedItems.Count == 0)
                                                        ListaItem.SelectedItems[0].Selected = true;
                                                else if (ListaItem.SelectedItems[0].Index > 0)
                                                        ListaItem.Items[ListaItem.SelectedItems[0].Index - 1].Selected = true;
                                                e.Handled = true;
                                                break;
                                        case Keys.Down:
                                                if (ListaItem.SelectedItems.Count == 0)
                                                        ListaItem.SelectedItems[0].Selected = true;
                                                else if (ListaItem.SelectedItems[0].Index < ListaItem.Items.Count - 1)
                                                        ListaItem.Items[ListaItem.SelectedItems[0].Index + 1].Selected = true;
                                                e.Handled = true;
                                                break;
                                        case Keys.PageUp:
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Up));
                                                break;
                                        case Keys.PageDown:
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                this.EntradaBuscar_KeyDown(sender, new System.Windows.Forms.KeyEventArgs(Keys.Down));
                                                break;
                                }
                        }
                }


                private void ListaItem_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
                {
                        byte Tecla = System.Text.Encoding.ASCII.GetBytes(System.Convert.ToString(e.KeyChar))[0];
                        if (Tecla == System.Convert.ToByte(Keys.Return)) {
                                e.Handled = true;
                                this.DarleEnter();
                        } else if (Tecla == System.Convert.ToByte(Keys.Escape)) {
                                e.Handled = true;
                                this.Close();
                        } else if (Tecla == System.Convert.ToByte(Keys.Back)) {
                                if (EntradaBuscar.Text.Length > 0) {
                                        e.Handled = true;
                                        EntradaBuscar.Text = EntradaBuscar.Text.Substring(0, EntradaBuscar.Text.Length - 1);
                                }
                                e.Handled = true;
                        } else if ((@"ABCDEFGHIJKLMNOPQRSTUVWXYZ* """).IndexOf(char.ToUpper(e.KeyChar)) != -1) {
                                e.Handled = true;
                                EntradaBuscar.Text += System.Convert.ToString(e.KeyChar);
                        }
                }


                internal void DarleEnter()
                {
                        if (ListaItem.SelectedItems.Count > 0) {
                                if (m_Table == "articulos") {
                                        string Codigo = this.DataBase.FieldString("SELECT " + this.Workspace.CurrentConfig.Productos.CodigoPredeterminado() + " FROM articulos WHERE id_articulo=" + int.Parse(ListaItem.SelectedItems[0].Text).ToString());
                                        if (Codigo.Length == 0)
                                                Codigo = int.Parse(ListaItem.SelectedItems[0].Text).ToString();
                                        ControlDestino.Text = Codigo;
                                } else {
                                        ControlDestino.Text = int.Parse(ListaItem.SelectedItems[0].Text).ToString();
                                }
                                this.Close();
                        }
                }


                private void BotonNuevo_Click(object sender, System.EventArgs e)
                {
                        this.Hide();
                        object Resultado = this.Workspace.RunTime.Execute("CREATE", new string[] { m_Table });
                        if (Resultado == null) {
                                // No se puede crear
                                this.Show();
                        } else if (Resultado is Lui.Forms.EditForm) {
                                ((Lui.Forms.EditForm)Resultado).ControlDestino = this.ControlDestino;
                                this.DialogResult = DialogResult.Retry;
                                this.Tag = Resultado;
                                this.Close();
                        } else if (Resultado is Form) {
                                this.DialogResult = DialogResult.Retry;
                                this.Close();
                        } else if (Resultado is Lfx.Types.OperationResult) {
                                Lui.Forms.MessageBox.Show(((Lfx.Types.OperationResult)(Resultado)).Message, "Mensaje");
                        } else {
                                // Devolvió algo raro.
                        }
                }


                private void DetailBoxQuickSelect_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.F6:
                                        e.Handled = true;
                                        if (BotonNuevo.Enabled && BotonNuevo.Visible)
                                                BotonNuevo.PerformClick();
                                        break;
                        }
                }


                public void VerDetalles()
                {
                        if (ListaItem.SelectedItems.Count > 0) {
                                int ItemId = int.Parse(ListaItem.SelectedItems[0].Text);
                                if (ItemId > 0)
                                        this.Workspace.RunTime.Info("ITEMFOCUS", new string[] { "TABLE", this.Table, ItemId.ToString() });
                        }
                }


                private void ListaItem_SelectedIndexChanged(object sender, System.EventArgs e)
                {
                        if (ListaItem.SelectedItems.Count > 0) {
                                ListaItem.Items[ListaItem.SelectedItems[0].Index].Focused = true;
                                ListaItem.Items[ListaItem.SelectedItems[0].Index].EnsureVisible();
                        }
                        VerDetalles();
                }


                private void Timer1_Tick(System.Object sender, System.EventArgs e)
                {
                        this.Refrescar();
                        Timer1.Enabled = false;
                }

                private void ListaItem_DoubleClick(object sender, System.EventArgs e)
                {
                        DarleEnter();
                }

                /// <summary>
                /// IDataControl
                /// </summary>
                [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public Lfx.Workspace Workspace
                {
                        get
                        {
                                return Lfx.Workspace.Master;
                        }
                }

                /// <summary>
                /// IDataControl
                /// </summary>
                public Lfx.Data.DataBase DataBase
                {
                        get
                        {
                                if (this.Parent is Lui.Forms.IDataControl) {
                                        return ((Lui.Forms.IDataControl)(this.Parent)).DataBase;
                                } else {
                                        return this.Workspace.DefaultDataBase;
                                }
                        }
                }
        }
}