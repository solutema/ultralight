#region License
// Copyright 2004-2012 Ernesto N. Carrea
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
using System.Windows.Forms;

namespace Lui.Forms
{
        /// <summary>
        /// Provee un ListView mejorado que permite que se pase al siguiente control cuando se llega hasta el último ítem con la tecla cursor-abajo.
        /// </summary>
        public class ListView : System.Windows.Forms.ListView
        {
                private ListViewItem ItemUnderMouse = null;

                protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
                {
                        if (e.Alt == false && e.Control == false) {
                                switch (e.KeyCode) {
                                        case System.Windows.Forms.Keys.Up:
                                                if (this.Items.Count == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                } else if (this.SelectedItems.Count > 0 && this.SelectedItems[0].Index == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("+{tab}");
                                                }
                                                break;

                                        case System.Windows.Forms.Keys.Down:
                                                if (this.Items.Count == 0) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                                } else if (this.SelectedItems.Count > 0 && this.SelectedItems[0].Index == this.Items.Count - 1) {
                                                        e.Handled = true;
                                                        System.Windows.Forms.SendKeys.Send("{tab}");
                                                }
                                                break;
                                }
                        }
                        base.OnKeyDown(e);
                }

                protected override void OnMouseHover(System.EventArgs e)
                {
                        System.Drawing.Point localPoint = this.PointToClient(Cursor.Position);
                        ListViewItem NewItem = this.GetItemAt(localPoint.X, localPoint.Y);

                        if (NewItem != this.ItemUnderMouse) {
                                if (this.ItemUnderMouse != null)
                                        this.ItemUnderMouse.BackColor = this.BackColor;

                                this.ItemUnderMouse = NewItem;
                                if (this.ItemUnderMouse != null) {
                                        this.ItemUnderMouse.BackColor = System.Drawing.Color.LemonChiffon;
                                }
                        }
                        base.OnMouseHover(e);
                }


                protected override void OnMouseLeave(System.EventArgs e)
                {
                        if (this.ItemUnderMouse != null) {
                                this.ItemUnderMouse.BackColor = this.BackColor;
                                this.ItemUnderMouse = null;
                        }

                        base.OnMouseLeave(e);
                }


                public ListView()
                {
                        this.DoubleBuffered = true;

                        // Enable the OnNotifyMessage event so we get a chance to filter out 
                        // Windows messages before they get to the form's WndProc
                        this.SetStyle(ControlStyles.EnableNotifyMessage, true);
                }

                /* protected override void OnNotifyMessage(Message m)
                {
                        //Filter out the WM_ERASEBKGND message
                        if (m.Msg != 0x14) {
                                base.OnNotifyMessage(m);
                        }
                } */


                public static Lui.Forms.ListView NewListViewFromSheet(Lazaro.Pres.Spreadsheet.Sheet sheet)
                {
                        Lui.Forms.ListView Result = new Lui.Forms.ListView();
                        Result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
                        Result.LabelEdit = false;
                        Result.LabelWrap = false;
                        Result.FromSheet(sheet);

                        return Result;
                }

                public void FromSheet(Lazaro.Pres.Spreadsheet.Sheet sheet)
                {
                        this.SuspendLayout();
                        this.BeginUpdate();

                        this.Items.Clear();
                        this.View = System.Windows.Forms.View.Details;
                        this.FullRowSelect = true;
                        this.GridLines = true;
                        this.Groups.Clear();

                        if (sheet.BackColor != System.Drawing.Color.Empty)
                                this.BackColor = sheet.BackColor;
                        if (sheet.ForeColor != System.Drawing.Color.Empty)
                                this.ForeColor = sheet.ForeColor;

                        if (sheet.ColumnHeaders != null) {
                                this.Columns.Clear();
                                foreach (Lazaro.Pres.Spreadsheet.ColumnHeader ch in sheet.ColumnHeaders) {
                                        System.Windows.Forms.ColumnHeader Col = this.Columns.Add(ch.Text, ch.Width);
                                        switch (ch.TextAlignment) {
                                                case Lfx.Types.StringAlignment.Near:
                                                        Col.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                                                        break;
                                                case Lfx.Types.StringAlignment.Far:
                                                        Col.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                                                        break;
                                        }
                                }
                        }

                        System.Windows.Forms.ListViewGroup LastGroup = null;

                        foreach (Lazaro.Pres.Spreadsheet.Row rw in sheet.Rows) {
                                if (rw is Lazaro.Pres.Spreadsheet.HeaderRow) {
                                        LastGroup = new System.Windows.Forms.ListViewGroup(rw.Cells[0].Content.ToString());
                                        this.Groups.Add(LastGroup);
                                } else {
                                        System.Windows.Forms.ListViewItem Itm = new System.Windows.Forms.ListViewItem();

                                        if (rw is Lazaro.Pres.Spreadsheet.AggregationRow) {
                                                //Itm.BackColor = System.Drawing.Color.LightGray;
                                                Itm.Font = new System.Drawing.Font(Itm.Font, System.Drawing.FontStyle.Bold);
                                        }

                                        if (LastGroup != null) {
                                                Itm.Group = LastGroup;
                                        }

                                        if (rw.BackColor != System.Drawing.Color.Empty)
                                                Itm.BackColor = rw.BackColor;
                                        if (rw.ForeColor != System.Drawing.Color.Empty)
                                                Itm.ForeColor = rw.ForeColor;

                                        int i = 0;
                                        foreach (Lazaro.Pres.Spreadsheet.Cell cl in rw.Cells) {
                                                string CellString = "";
                                                if (cl.Content != null) {
                                                        switch (cl.Content.GetType().ToString()) {
                                                                case "System.Single":
                                                                case "System.Double":
                                                                        CellString += Lfx.Types.Formatting.FormatNumber(System.Convert.ToDouble(cl.Content), 2);
                                                                        break;
                                                                case "System.Decimal":
                                                                        CellString += Lfx.Types.Formatting.FormatNumber(System.Convert.ToDecimal(cl.Content), 4);
                                                                        break;
                                                                case "System.Integer":
                                                                case "System.Int16":
                                                                case "System.Int32":
                                                                case "System.Int64":
                                                                        CellString += cl.Content.ToString();
                                                                        break;
                                                                case "System.DateTime":
                                                                        DateTime clContent = (DateTime)cl.Content;
                                                                        if (clContent.Hour == 0 && clContent.Minute == 0 && clContent.Second == 0)
                                                                                CellString += clContent.ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);
                                                                        else
                                                                                CellString += clContent.ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern);
                                                                        break;
                                                                case "System.String":
                                                                        CellString += cl.Content.ToString();
                                                                        break;
                                                        }
                                                }
                                                if (i == 0)
                                                        Itm.Text = CellString;
                                                else
                                                        Itm.SubItems.Add(CellString);
                                                i++;
                                        }
                                        this.Items.Add(Itm);
                                }
                        }
                        this.EndUpdate();
                        this.ResumeLayout();
                }
        }
}