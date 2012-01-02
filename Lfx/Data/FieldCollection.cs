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
using System.Collections.Generic;

namespace Lfx.Data
{
        [Serializable]
	public class FieldCollection : List<Field>
	{
		public FieldCollection()
		{
		}

		public virtual Field this[string columnName]
		{
			get
			{
				foreach(Field Itm in this) {
					if(Itm.ColumnName == columnName)
						return Itm;
				}

                                foreach (Field Itm in this) {
                                        if (Itm.ColumnName != null && Lfx.Data.Connection.GetFieldName(Itm.ColumnName) == columnName)
                                                return Itm;
                                }

                                foreach (Field Itm in this) {
                                        if (Itm.ColumnName == Lfx.Data.Connection.GetFieldName(columnName))
                                                return Itm;
                                }
				//Si no existe, creo dinámicamente el campo
				Field Res = new Field(columnName);
				this.Add(Res);
				return Res;
			}
			set
			{
				bool Encontrado = false;
				for(int i = 0; i < this.Count; i++) {
					if(this[i].ColumnName == columnName) {
						((Field)(this[i])).Value = value;
						Encontrado = true;
						break;
					}
				}
				if(Encontrado == false) {
					//Si no existe, creo dinámicamente el campo
					value.ColumnName = columnName;
					this.Add(value);
				}
			}
		}

                public bool Contains(string columnName)
                {
                        foreach (Field Itm in this) {
                                if (Itm.ColumnName.ToUpperInvariant() == columnName.ToUpperInvariant())
                                        return true;
                        }
                        return false;
                }

		public override string ToString()
		{
			string Res = "FieldCollection[" + this.Count.ToString() + "] = {";
			string FlList = null;
			foreach (Field Itm in this) {
				if(FlList == null)
					FlList = "";
				else
					FlList += ", ";
				FlList += Itm.ColumnName + "=" + Itm.Value.ToString();
			}
			
			return Res + FlList + "}";
		}

                public virtual void AddWithValue(string fieldName, object fieldValue)
                {
                        this.Add(new Field(fieldName, fieldValue));
                }
	}
}
