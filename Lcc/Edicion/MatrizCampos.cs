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
using System.Drawing;
using System.Windows.Forms;

namespace Lcc.Edicion
{
        public partial class MatrizCampos : ControlEdicion
        {
                public List<Campo> Campos;

                public MatrizCampos()
                {
                        this.Campos = new List<Campo>();

                        InitializeComponent();
                }


                public override string Text
                {
                        get
                        {
                                return GroupLabel.Text;
                        }
                        set
                        {
                                GroupLabel.Text = value;
                                base.Text = value;
                        }
                }


                public void AgregarCampo(string label, Lui.Forms.EditableControl control)
                {
                        Lui.Forms.Label Lbl = new Lui.Forms.Label();
                        Lbl.AutoSize = false;
                        Lbl.Text = label;
                        Lbl.Tag = control;
                        Lbl.UseMnemonic = false;
                        Lbl.Height = control.Height;
                        Lbl.TextAlign = ContentAlignment.TopLeft;
                        Lbl.AutoEllipsis = true;
                        Lbl.LabelStyle = Lui.Forms.LabelStyles.Default;
                        
                        this.FieldContainer.Controls.Add(Lbl);
                        this.FieldContainer.Controls.Add(control);

                        Lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                        control.Anchor = AnchorStyles.Left | AnchorStyles.Top;

                        this.Campos.Add(new Campo(control, Lbl));

                        this.ReLayout();
                }


                private void ReLayout()
                {
                        if (this.Campos == null)
                                return;

                        int LabelsWidth = 0;
                        /* foreach (Campo Cmp in this.Campos) {
                                if (Cmp.Etiqueta.Width > LabelsWidth)
                                        LabelsWidth = Cmp.Etiqueta.Width;
                        } */

                        LabelsWidth = System.Convert.ToInt32(this.ClientRectangle.Width * .3);

                        int Y = 0;
                        foreach (Campo Cmp in this.Campos) {
                                Cmp.Etiqueta.Location = new Point(0, Y);
                                Cmp.Etiqueta.Width = LabelsWidth;
                                Cmp.ControlEntrada.Location = new Point(LabelsWidth + 4, Y);
                                Cmp.ControlEntrada.Width = this.ClientRectangle.Width - Cmp.ControlEntrada.Left;

                                Y += Cmp.ControlEntrada.Height + 4;
                        }
                        this.FieldContainer.Height = Y;
                }


                public void EliminarCampos()
                {
                        this.FieldContainer.Controls.Clear();
                        this.Campos.Clear();
                }


                public void FromSection(Lazaro.Pres.Forms.Section section)
                {
                        this.EliminarCampos();
                        this.Text = section.Label;
                        foreach (Lazaro.Pres.Field Fld in section.Fields) {
                                Lui.Forms.EditableControl Ctrl;
                                switch (Fld.DataType) {
                                        case Lfx.Data.InputFieldTypes.Bool:
                                                Lui.Forms.YesNo BoolField = new Lui.Forms.YesNo();
                                                //BoolField.SetData = new string[] { "Si|1", "No|0" };
                                                //BoolField.AlwaysExpanded = false;
                                                //BoolField.AutoSize = false;
                                                BoolField.Value = m_Elemento.GetFieldValue<bool>(Fld.MemberName);
                                                Ctrl = BoolField;
                                                break;
                                        case Lfx.Data.InputFieldTypes.Set:
                                                Lui.Forms.ComboBox SetField = new Lui.Forms.ComboBox();
                                                SetField.FromDictionary(Fld.SetValues);
                                                SetField.TextKey = m_Elemento.GetFieldValue<string>(Fld.MemberName);
                                                SetField.AlwaysExpanded = true;
                                                SetField.AutoSize = true;
                                                Ctrl = SetField;
                                                break;
                                        case Lfx.Data.InputFieldTypes.Relation:
                                                Entrada.CodigoDetalle RelationField = new Entrada.CodigoDetalle();
                                                RelationField.Relation = Fld.Relation;
                                                RelationField.TextInt = m_Elemento.GetFieldValue<int>(Fld.MemberName);
                                                RelationField.PlaceholderText = Fld.Label;
                                                RelationField.Required = false;
                                                Ctrl = RelationField;
                                                break;
                                        default:
                                                Lui.Forms.TextBox TextField = new Lui.Forms.TextBox();
                                                switch (Fld.DataType) {
                                                        case Lfx.Data.InputFieldTypes.Currency:
                                                                TextField.DataType = Lui.Forms.DataTypes.Currency;
                                                                TextField.ValueDecimal = m_Elemento.GetFieldValue<decimal>(Fld.MemberName);
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.Date:
                                                                TextField.DataType = Lui.Forms.DataTypes.Date;
                                                                TextField.Text = m_Elemento.GetFieldValue<DateTime>(Fld.MemberName).ToString(Lfx.Types.Formatting.DateTime.ShortDatePattern);
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.DateTime:
                                                                TextField.DataType = Lui.Forms.DataTypes.DateTime;
                                                                TextField.Text = m_Elemento.GetFieldValue<DateTime>(Fld.MemberName).ToString(Lfx.Types.Formatting.DateTime.FullDateTimePattern);
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.Numeric:
                                                                TextField.DataType = Lui.Forms.DataTypes.Float;
                                                                TextField.ValueDecimal = m_Elemento.GetFieldValue<decimal>(Fld.MemberName);
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.Integer:
                                                                TextField.DataType = Lui.Forms.DataTypes.Integer;
                                                                TextField.ValueInt = m_Elemento.GetFieldValue<int>(Fld.MemberName);
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.Text:
                                                                TextField.DataType = Lui.Forms.DataTypes.FreeText;
                                                                TextField.Text = m_Elemento.GetFieldValue<string>(Fld.MemberName);
                                                                break;
                                                        case Lfx.Data.InputFieldTypes.Memo:
                                                                TextField.DataType = Lui.Forms.DataTypes.FreeText;
                                                                TextField.MultiLine = true;
                                                                TextField.Size = new Size(this.FieldContainer.ClientSize.Width, 72);
                                                                TextField.Text = m_Elemento.GetFieldValue<string>(Fld.MemberName);
                                                                break;
                                                }
                                                TextField.PlaceholderText = Fld.Label;
                                                Ctrl = TextField;
                                                break;
                                }

                                if (Ctrl.Size == System.Drawing.Size.Empty)
                                        Ctrl.Size = new Size(this.FieldContainer.ClientSize.Width, 24);
                                Ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Top;
                                Ctrl.FieldName = Fld.MemberName;
                                this.AgregarCampo(Fld.Label, Ctrl);
                        }
                }

                protected override void OnResize(EventArgs e)
                {
                        this.ReLayout();
                        base.OnResize(e);
                }

                protected override void OnGotFocus(EventArgs e)
                {
                        SendKeys.Send("{tab}");
                        base.OnGotFocus(e);
                }
        }
}
