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

namespace Lfx.Data
{
        [Serializable]
	public class FormField
	{
		public string ColumnName, m_Label, Format = null;
                public Lfx.Data.InputFieldTypes DataType = Lfx.Data.InputFieldTypes.Text;
		public int Width = 120;
                private bool m_Visible = true, m_Printable = true;
                public IDictionary<int, string> SetValues = null;
                public object TotalFunction = null;

		public FormField(string columnName, string label)
		{
			this.ColumnName = columnName;
			this.Label = label;
		}

		public FormField(string columnName, string label, Lfx.Data.InputFieldTypes dataType, int width)
			:this(columnName, label)
		{
			this.DataType = dataType;
			this.Width = width;
                        if (this.Width < 28)
                                this.Visible = false;
		}

                public FormField(string columnName, string label, int width, IDictionary<int,string> setValues)
                        : this(columnName, label, InputFieldTypes.Set, width)
                {
                        this.SetValues = setValues;
                }

                public FormField(string columnName, string label, Lfx.Data.InputFieldTypes dataType, int width, string format)
			:this(columnName, label, dataType, width)
		{
			this.Format = format;
		}

                public bool Visible
                {
                        get
                        {
                                return m_Visible && this.Width > 0;
                        }
                        set
                        {
                                m_Visible = value;
                        }
                }

                public bool Printable
                {
                        get
                        {
                                return m_Printable && m_Visible && this.Width > 0;
                        }
                        set
                        {
                                m_Printable = value;
                        }
                }

		public string Label
		{
			get
			{
				if(m_Label == null)
					return ColumnName;
				else
					return m_Label;
			}
			set
			{
				m_Label = value;
			}
		}

                public Lfx.Types.StringAlignment Alignment
                {
                        get
                        {
                                switch(this.DataType) {
                                        case InputFieldTypes.Currency:
                                        case InputFieldTypes.Numeric:
                                        case InputFieldTypes.Serial:
                                        case InputFieldTypes.Integer:
                                        case InputFieldTypes.Date:
                                        case InputFieldTypes.DateTime:
                                                return Lfx.Types.StringAlignment.Far;
                                        default:
                                                return Lfx.Types.StringAlignment.Near;
                                }
                        }
                }

                public override string ToString()
                {
                        return this.ColumnName;
                }

                public FormField Clone()
                {
                        FormField Res = new FormField(this.ColumnName, this.Label);

                        Res.DataType = this.DataType;
                        Res.Format = this.Format;
                        Res.SetValues = this.SetValues;
                        Res.TotalFunction = this.TotalFunction;
                        Res.Visible = this.Visible;
                        Res.Width = this.Width;

                        return Res;
                }
	}
}
