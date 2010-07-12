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
using System.Text;

namespace Lui.Forms
{
        /// <summary>
        /// Provee un ListView mejorado que permite que se pase al siguiente control cuando se llega hasta el último ítem con la tecla cursor-abajo.
        /// </summary>
        public class ListView : System.Windows.Forms.ListView
        {
                /* private Lui.Forms.ColumnHeaderCollection columnHeadersEx = null;

                /// <summary>
                /// Gets the collection of all column headers 
                /// that appear in the control.
                /// </summary>
                public new Lui.Forms.ColumnHeaderCollection Columns
                {
                        get
                        {
                                return columnHeadersEx;
                        }
                }

                /// <summary>
                /// Constructor
                /// </summary>
                public ListView()
                {
                        // Create a new collection to hold the columns
                        columnHeadersEx = new Lui.Forms.ColumnHeaderCollection(this);
                        // Create the context menu.
                        base.ContextMenu = new System.Windows.Forms.ContextMenu();
                        base.ContextMenu.MenuItems.Add(columnHeadersEx.ContextMenu);
                        base.ContextMenu.Popup += new EventHandler(ContextMenuPopup);

                        base.View = System.Windows.Forms.View.Details;

                }

                private void ContextMenuPopup(object sender, EventArgs e)
                {
                }
                */

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

        }

        /* 
        /// <summary>
        /// This class Represents the collection of 
        /// ColumnHeaderEx in a ListViewEx control.
        /// This class stores the column headers
        /// that are displayed in the ListViewEx control when the View 
        /// property is set to View.Details. 
        /// This class stores ColumnHeaderEx objects that define the text
        /// to display for a column as well as how the column header is 
        /// displayed in the ListViewEx control when displaying columns.
        /// When a ListViewEx displays columns, the items and their subitems 
        /// are displayed in their own columns. 
        /// </summary>
        public class ColumnHeaderCollection : System.Windows.Forms.ListView.ColumnHeaderCollection
        {

                /// <summary>
                /// This is to maintain the list of columns added
                /// to the ListViewEx control, this will contain both
                /// visible and hidden columns.
                /// </summary>
                private System.Collections.Generic.SortedList<int, Lui.Forms.ColumnHeader> columnList = new SortedList<int, ColumnHeader>();
                /// <summary>
                /// MenuItem which contains all columns menuitem as
                /// Subitems. This menuitem can be used to add to the 
                /// context menu, which inturn can be used to
                /// Hide/Show the columns.
                /// </summary>
                private System.Windows.Forms.MenuItem contextMenu = null;

                /// <summary>
                /// Indexer to get columns by index
                /// </summary>
                public new Lui.Forms.ColumnHeader this[int index]
                {
                        get
                        {
                                return columnList.Values[index];
                        }
                }

                /// MenuItem which contains all columns menuitem as
                /// Subitems. This menuitem can be used to add to the 
                /// context menu, which inturn can be used to
                /// Hide/Show the columns.
                public System.Windows.Forms.MenuItem ContextMenu
                {
                        get
                        {
                                return contextMenu;
                        }
                }


                /// <summary>
                /// Constructor.
                /// You cannot create an instance of this class 
                /// without associating it with a ListView control.
                /// </summary>
                /// <param name="owner"></param>
                public ColumnHeaderCollection(Lui.Forms.ListView owner)
                        : base(owner)
                {
                        // Create a menu item to add submenus for each column added
                        contextMenu = new System.Windows.Forms.MenuItem("Mostrar");
                }


                /// <summary>
                /// Method adds a single column header to the collection.
                /// </summary>
                /// <param name="str">Text to display</param>
                /// <param name="width">Width of column</param>
                /// <param name="textAlign">Alignment</param>
                /// <returns>new ColumnHeaderEx added</returns>
                public override System.Windows.Forms.ColumnHeader Add(string str, int width, System.Windows.Forms.HorizontalAlignment textAlign)
                {
                        Lui.Forms.ColumnHeader column = new Lui.Forms.ColumnHeader(str, width, textAlign);
                        this.Add(column);
                        return column;
                }

                /// <summary>
                /// Method adds a single column header to the collection.
                /// </summary>
                /// <param name="column"></param>
                /// <returns>The zero-based index into the collection 
                /// where the item was added.</returns>
                public override int Add(System.Windows.Forms.ColumnHeader column)
                {
                        return this.Add(new Lui.Forms.ColumnHeader(column));
                }

                /// <summary>
                /// Adds an array of column headers to the collection.
                /// </summary>
                /// <param name="values">An array of ColumnHeader 
                /// objects to add to the collection. </param>
                public override void AddRange(System.Windows.Forms.ColumnHeader[] values)
                {
                        // Add range of column headers
                        for (int index = 0; index < values.Length; index++) {
                                this.Add(new Lui.Forms.ColumnHeader(values[index]));
                        }
                }

                /// <summary>
                /// Adds an existing ColumnHeader to the collection.
                /// </summary>
                /// <param name="column">The ColumnHeader to 
                /// add to the collection. </param>
                /// <returns>The zero-based index into the collection 
                /// where the item was added.</returns>
                public int Add(ColumnHeader column)
                {
                        // Add the column to the base
                        int retValue = base.Add(column);
                        // Keep a refrence in columnList
                        columnList.Add(column.ColumnID, column);
                        // Add the its menu to main menu
                        ContextMenu.MenuItems.Add(column.ColumnMenuItem);
                        // Subscribe to the visiblity change event of the column
                        column.VisibleChanged += new EventHandler(ColumnVisibleChanged);
                        return retValue;
                }

                /// <summary>
                /// Removes the specified column header from the collection.
                /// </summary>
                /// <param name="column">A ColumnHeader representing the 
                /// column header to remove from the collection.</param>
                public new void Remove(System.Windows.Forms.ColumnHeader column)
                {
                        // Remove from base
                        base.Remove(column);
                        // Remove the reference in columnList
                        columnList.Remove(((Lui.Forms.ColumnHeader)column).ColumnID);
                        // remove the menu item associated with it
                        ContextMenu.MenuItems.Remove(((Lui.Forms.ColumnHeader)column).ColumnMenuItem);
                }

                /// <summary>
                /// Removes the column header at the specified index within the collection.
                /// </summary>
                /// <param name="index">The zero-based index of the 
                /// column header to remove</param>
                public new void RemoveAt(int index)
                {
                        System.Windows.Forms.ColumnHeader column = this[index];
                        this.Remove(column);
                }

                /// <summary>
                /// Removes all column headers from the collection.
                /// </summary>
                public new void Clear()
                {
                        // Clear all columns in base
                        base.Clear();
                        // Remove all references
                        columnList.Clear();
                        // Clear all menu items
                        ContextMenu.MenuItems.Clear();
                }

                /// <summary>
                /// This method is used to find the first visible column
                /// which is present in front of the column specified
                /// </summary>
                /// <param name="column">refrence columns for search</param>
                /// <returns>null if no visible colums are in front of
                /// the column specified, else previous columns returned</returns>
                private Lui.Forms.ColumnHeader FindPreviousVisibleColumn(Lui.Forms.ColumnHeader column)
                {
                        // Get the position of the search column
                        int index = columnList.IndexOfKey(column.ColumnID);
                        if (index > 0) {
                                // Start a recursive search for a visible column
                                Lui.Forms.ColumnHeader prevColumn = (Lui.Forms.ColumnHeader)columnList.Values[index - 1];
                                if ((prevColumn != null) && (prevColumn.Visible == false)) {
                                        prevColumn = FindPreviousVisibleColumn(prevColumn);
                                }
                                return prevColumn;
                        }
                        // No visible columns found in font of specified column
                        return null;
                }

                /// <summary>
                /// Handler to handel the visiblity change of columns
                /// </summary>
                /// <param name="sender">ColumnHeaderEx</param>
                /// <param name="e"></param>
                private void ColumnVisibleChanged(object sender, EventArgs e)
                {
                        Lui.Forms.ColumnHeader column = (Lui.Forms.ColumnHeader)sender;

                        if (column.Visible == true) {
                                // Show the hidden column
                                // Get the position where the hidden column has to be shown
                                Lui.Forms.ColumnHeader prevHeader = FindPreviousVisibleColumn(column);
                                if (prevHeader == null) {
                                        // This is the first column, so add it at 0 location
                                        base.Insert(0, column);
                                } else {
                                        // Got the location, place it their.
                                        base.Insert(prevHeader.Index + 1, column);
                                }
                        } else {
                                // Hide the column.
                                // Remove it from the base, dont worry we have the 
                                // refrence in columnList to get it back
                                base.Remove(column);
                        }
                }
        }

        /// <summary>
        /// This class object represents a single column header in a ListViewEx control.
        /// This class is extended from ColumnHeader, inorder to support column hiding.
        /// </summary>
        public class ColumnHeader : System.Windows.Forms.ColumnHeader
        {

                private System.Windows.Forms.MenuItem menuItem = null;
                private bool columnVisible = true;
                private int columnID = 0;
                private static int autoColumnID = 0;

                /// <summary>
                /// This event is raised when the visibility of column
                /// is changed.
                /// </summary>
                public event EventHandler VisibleChanged;


                /// <summary>
                /// A unique identifier for a Column
                /// </summary>
                public int ColumnID
                {
                        get
                        {
                                return columnID;
                        }
                }

                /// <summary>
                /// Property to change the visibility of the column
                /// </summary>
                public bool Visible
                {
                        get
                        {
                                return columnVisible;
                        }
                        set
                        {
                                ShowColumn(value);
                        }
                }

                /// <summary>
                /// Menu item which represents the column.
                /// This menuitem can be used to add to the 
                /// context menu, which can inturn used to
                /// Hide/Show the column
                /// </summary>
                public System.Windows.Forms.MenuItem ColumnMenuItem
                {
                        get
                        {
                                return menuItem;
                        }
                }

                /// <summary>
                /// Column Text to be displayed
                /// </summary>
                public new string Text
                {
                        get
                        {
                                return base.Text;
                        }
                        set
                        {
                                base.Text = value;
                                // Ensure that menu name is same as column name
                                menuItem.Text = value;
                        }
                }

                /// <summary>
                /// Gets the ListViewEx control the 
                /// ColumnHeader is located in.
                /// </summary>
                public new Lui.Forms.ListView ListView
                {
                        get
                        {
                                return (Lui.Forms.ListView)base.ListView;
                        }
                }


                /// <summary>
                /// Constructor
                /// </summary>
                public ColumnHeader()
                {
                        Initialize("", 0, System.Windows.Forms.HorizontalAlignment.Left);
                }

                /// <summary>
                /// Constructor
                /// </summary>
                /// <param name="str">Text to display</param>
                /// <param name="width">Width of column</param>
                /// <param name="textAlign">Alignment</param>
                public ColumnHeader(string str, int width, System.Windows.Forms.HorizontalAlignment textAlign)
                {
                        Initialize(str, width, textAlign);
                }

                /// <summary>
                /// Constructor
                /// </summary>
                /// <param name="column"></param>
                public ColumnHeader(System.Windows.Forms.ColumnHeader column)
                {
                        Initialize(column.Text, column.Width, column.TextAlign);
                }


                /// <summary>
                /// Column Initialization
                /// </summary>
                /// <param name="str">Text to display</param>
                /// <param name="width">Width of column</param>
                /// <param name="textAlign">Alignment</param>
                private void Initialize(string str, int width, System.Windows.Forms.HorizontalAlignment textAlign)
                {
                        base.Text = str;
                        base.Width = width;
                        base.TextAlign = textAlign;
                        columnID = autoColumnID++;

                        // Create the menu item associated with this column
                        menuItem = new System.Windows.Forms.MenuItem(Text, new System.EventHandler(this.MenuItemClick));
                        menuItem.Checked = true;
                }

                /// <summary>
                /// Method to show/hide column
                /// </summary>
                /// <param name="visible">visibility</param>
                private void ShowColumn(bool visible)
                {
                        if (columnVisible != visible) {
                                columnVisible = visible;
                                menuItem.Checked = visible;
                                if (VisibleChanged != null) {
                                        VisibleChanged(this, EventArgs.Empty);
                                }
                        }
                }

                /// <summary>
                /// Handler to handel toggel of menu item.
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void MenuItemClick(Object sender, System.EventArgs e)
                {
                        System.Windows.Forms.MenuItem menuItem = (System.Windows.Forms.MenuItem)sender;
                        // Ensure Column is hidden/shown accordingly
                        ShowColumn(!menuItem.Checked);
                }
        }
        */
}