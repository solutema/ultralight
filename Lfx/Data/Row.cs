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

namespace Lfx.Data
{
	public class Row
	{
		public bool IsNew = true, IsModified = false;
		public FieldCollection Fields = null;
		public System.Data.DataTable DataTable;
                public Lfx.Data.Table Table;

		public Row()
		{
                        if (Fields == null)
                                Fields = new FieldCollection();
		}

                public static explicit operator Lfx.Data.Row(System.Data.DataRow row)
		{
			Row Res = new Row();
			if (row != null)
			{
				Res.DataTable = row.Table;
				foreach (System.Data.DataColumn Col in row.Table.Columns)
				{
					Res[Col.ColumnName] = row[Col];
				}
				Res.IsNew = false;
				Res.IsModified = false;
			}
			return Res;
		}

		public object this[string fieldName]
		{
			get
			{
                                if (Fields == null)
                                        return null;
                                else if (Fields[fieldName].Value is DBNull)
                                        return null;
                                else
					return Fields[fieldName].Value;
			}
			set
			{
				if(Fields == null)
					Fields = new FieldCollection();
				Fields[fieldName].Value = value;
			}
		}

		public object this[int index]
		{
			get
			{
				if(Fields == null)
					return null;
                                if (Fields[index].Value is DBNull)
                                        return null;
                                else
                                        return Fields[index].Value;
			}
		}

                public virtual Row Clone()
                {
                        Lfx.Data.Row Res = new Lfx.Data.Row();
                        Res.DataTable = this.DataTable;
                        foreach (Lfx.Data.Field Fld in this.Fields) {
                                Res.Fields.Add(Fld.Clone());
                        }
                        Res.IsModified = this.IsModified;
                        Res.IsNew = this.IsNew;
                        return Res;
                }
	}
}
