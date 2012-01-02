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

namespace Lfx.Data
{
        [Serializable]
	public class Field
	{
		public string ColumnName, m_Label;
		public object Value = null;
		public Lfx.Data.DbTypes DataType = Lfx.Data.DbTypes.VarChar;

		public Field(string columnName)
		{
			this.ColumnName = columnName;
		}

                public Field(string columnName, object value)
                        : this(columnName)
                {
                        this.Value = value;
                        if (value is double || value is decimal)
                                this.DataType = DbTypes.Numeric;
                        else if (value is int || value is long)
                                this.DataType = DbTypes.Integer;
                        else if (value is DateTime)
                                this.DataType = DbTypes.DateTime;
                        else if (value is bool)
                                this.DataType = DbTypes.SmallInt;
                        else if (value is byte[])
                                this.DataType = DbTypes.Blob;
                }

                public Field(string columnName, DbTypes fieldType, object fieldValue)
                        : this(columnName, fieldValue)
                {
                        this.DataType = fieldType;
                }

		public string Label
		{
			get
			{
				if(m_Label == null)
					return ColumnName;
				else
					return Label;
			}
			set
			{
				m_Label = value;
			}
		}

                public virtual Field Clone()
                {
                        Field Res = new Field(this.ColumnName);
                        Res.m_Label = this.m_Label;
                        Res.Value = this.Value;
                        Res.DataType = this.DataType;
                        return Res;
                }

                public override string ToString()
                {
                        return this.Value.ToString();
                }

                public double ValueDouble
                {
                        get
                        {
                                return System.Convert.ToDouble(this.Value);
                        }
                }

                public decimal ValueDecimal
                {
                        get
                        {
                                return System.Convert.ToDecimal(this.Value);
                        }
                }

                public string ValueString
                {
                        get
                        {
                                return System.Convert.ToString(this.Value);
                        }
                }

                public int ValueInt
                {
                        get
                        {
                                return System.Convert.ToInt32(this.Value);
                        }
                }

                public DateTime ValueDateTime
                {
                        get
                        {
                                return System.Convert.ToDateTime(this.Value);
                        }
                }
	}
}
