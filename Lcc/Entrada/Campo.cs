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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lcc.Entrada
{
        public enum DbTypes
        {
                Text,
                Integer,
                Numeric,
                Currency,
                Date,
                DateTime,
                Set
        }

        public partial class Campo : ControlEntrada
        {
                private DbTypes m_FieldType = DbTypes.Text;
                private string m_Name;
                //private bool m_SelectOnFocus = true;

                public Campo()
                {
                        InitializeComponent();
                }


                public DbTypes FieldType
                {
                        get
                        {
                                return m_FieldType;
                        }
                        set
                        {
                                m_FieldType = value;
                        }
                }

                public override string Text
                {
                        get
                        {
                                return FieldLabel.Text;
                        }
                        set
                        {
                                FieldLabel.Text = value;
                        }
                }

                public object FieldValue
                {
                        get
                        {
                                switch (m_FieldType) {
                                        case DbTypes.Text:
                                                return FieldData.Text;
                                        case DbTypes.Integer:
                                                return Lfx.Types.Parsing.ParseInt(FieldData.Text);
                                        case DbTypes.Numeric:
                                                return Lfx.Types.Parsing.ParseDouble(FieldData.Text);
                                        case DbTypes.Currency:
                                                return Lfx.Types.Parsing.ParseCurrency(FieldData.Text);
                                        case DbTypes.Date:
                                                return Lfx.Types.Parsing.ParseDate(FieldData.Text);
                                        case DbTypes.DateTime:
                                                return Lfx.Types.Parsing.ParseDate(FieldData.Text);
                                        default:
                                                return FieldData.Text;
                                }
                        }
                        set
                        {
                                if (value == null || value is DBNull)
                                        FieldData.Text = "";
                                else
                                        FieldData.Text = value.ToString();
                        }
                }

                public string FieldName
                {
                        get
                        {
                                return m_Name;
                        }
                        set
                        {
                                m_Name = value;
                        }
                }


                [EditorBrowsable(EditorBrowsableState.Never), System.ComponentModel.Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                public int AutoLabelWidth
                {
                        get
                        {
                                return FieldLabel.Width;
                        }
                }

                public int LabelWidth
                {
                        get
                        {
                                return FieldData.Left - 8;
                        }
                        set
                        {
                                FieldData.Left = value + 8;
                                FieldData.Width = this.Width - FieldData.Left;
                        }
                }

                /* protected override bool IsInputKey(Keys keyData)
                {
                        switch (keyData) {
                                case Keys.Up:
                                case Keys.Down:
                                case Keys.Left:
                                case Keys.Right:
                                        return true;
                                default:
                                        return base.IsInputKey(keyData);
                        }
                }

                private void FieldData_KeyDown(object sender, KeyEventArgs e)
                {
                        switch (e.KeyCode) {
                                case Keys.Down:
                                        if (e.Alt == false && e.Shift == false && e.Control == false) {
                                                System.Windows.Forms.SendKeys.Send("{tab}");
                                                e.Handled = true;
                                        }
                                        break;
                                case Keys.Up:
                                        if (e.Alt == false && e.Shift == false && e.Control == false) {
                                                System.Windows.Forms.SendKeys.Send("+{tab}");
                                                e.Handled = true;
                                        }
                                        break;
                        }
                }

                private void FieldData_KeyPress(object sender, KeyPressEventArgs e)
                {
                        if (e.KeyChar == Lfx.Types.ControlChars.Cr && FieldData.Multiline == false) {
                                System.Windows.Forms.SendKeys.Send("{tab}");
                                e.Handled = true;
                        }
                }

                private void FieldData_Enter(object sender, EventArgs e)
                {
                        if (m_SelectOnFocus)
                                FieldData.SelectAll();
                } */
        }
}
