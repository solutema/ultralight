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
using System.Text;

namespace Lfx.Types
{
        public class LDateTime
        {
                public DateTime Value;

                public LDateTime(DateTime dateTimeValue)
                {
                        this.Value = dateTimeValue;
                }

                public static implicit operator DateTime(LDateTime lDateTimeValue)
                {
                        return lDateTimeValue.Value;
                }

                public static implicit operator LDateTime(DateTime dateTimeValue)
                {
                        return new LDateTime(dateTimeValue);
                }

                public override string ToString()
                {
                        return this.Value.ToString();
                }

                public string ToString(string format)
                {
                        return this.Value.ToString(format);
                }

                public override bool Equals(object obj)
                {
			LDateTime LDat = obj as LDateTime;
			
                        if (object.ReferenceEquals(obj, null))
                                return false;
                        else
                                return (this.Value == LDat.Value);
                }

                public override int GetHashCode()
                {
                        return this.Value.GetHashCode();
                }

                public static bool operator ==(LDateTime v1, LDateTime v2)
                {
                        if (object.ReferenceEquals(v1, null) && object.ReferenceEquals(v2, null))
                                return true;
                        else if (object.ReferenceEquals(v1, null))
                                return false;
                        else if (object.ReferenceEquals(v2, null))
                                return false;
                        else
                                return (v1.Value == v2.Value);
                }

                public static bool operator !=(LDateTime v1, LDateTime v2)
                {
                        if (object.ReferenceEquals(v1, null) && object.ReferenceEquals(v2, null))
                                return false;
                        else if (object.ReferenceEquals(v1, null))
                                return true;
                        else if (object.ReferenceEquals(v2, null))
                                return true;
                        else
                                return (v1.Value != v2.Value);
                }
        }
}
