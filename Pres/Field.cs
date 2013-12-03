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

namespace Lazaro.Pres
{
        public class Field
        {
                public string Label { get; set; }

                /// <summary>
                /// Nombre de la propiedad o campo asociado con este control de entrada de datos.
                /// </summary>
                public string Name { get; set; }
                public Type LblType { get; set; }

                public Lfx.Data.InputFieldTypes DataType { get; set; }
                public string Format { get; set; }
                public object Control { get; set; }

                public int Width { get; set; }
                public object TotalFunction { get; set; }

                public IDictionary<int, string> SetValues { get; set; }
                public Lfx.Data.Relation Relation { get; set; }

                public bool Visible { get; set; }
                public bool ReadOnly { get; set; }
                public bool Printable { get; set; }

                public Field()
                {
                        this.Width = 120;
                        this.DataType = Lfx.Data.InputFieldTypes.Text;
                        this.Visible = true;
                        this.Printable = true;
                }

                public Field(string name, string label)
                        : this()
		{
			this.Name = name;
			this.Label = label;
		}


                public Field(string name, string label, Lfx.Data.InputFieldTypes dataType)
                        : this(name, label)
                {
                        this.DataType = dataType;
                        if (this.Width < 28) {
                                this.Visible = false;
                                this.Printable = false;
                        }
                }


                public Field(string name, string label, Lfx.Data.InputFieldTypes dataType, int width)
                        : this(name, label, dataType)
                {
                        this.Width = width;
                        if (this.Width < 28) {
                                this.Visible = false;
                                this.Printable = false;
                        }
                }


                public Field(string name, string label, IDictionary<int, string> setValues)
                        : this(name, label, Lfx.Data.InputFieldTypes.Set)
                {
                        this.SetValues = setValues;
                }


                public Field(string name, string label, int width, Lfx.Data.Relation relation)
                        : this(name, label, Lfx.Data.InputFieldTypes.Relation, width)
                {
                        this.Relation = relation;
                }


                public Field(string name, string label, int width, IDictionary<int, string> setValues)
                        : this(name, label, Lfx.Data.InputFieldTypes.Set, width)
                {
                        this.SetValues = setValues;
                }

                public Field(string name, string label, Lfx.Data.InputFieldTypes dataType, int width, string format)
                        : this(name, label, dataType, width)
                {
                        this.Format = format;
                }


                public override string ToString()
                {
                        return this.Name;
                }


                public Lfx.Types.StringAlignment Alignment
                {
                        get
                        {
                                switch (this.DataType) {
                                        case Lfx.Data.InputFieldTypes.Currency:
                                        case Lfx.Data.InputFieldTypes.Numeric:
                                        case Lfx.Data.InputFieldTypes.Serial:
                                        case Lfx.Data.InputFieldTypes.Integer:
                                        case Lfx.Data.InputFieldTypes.Date:
                                        case Lfx.Data.InputFieldTypes.DateTime:
                                                return Lfx.Types.StringAlignment.Far;
                                        default:
                                                return Lfx.Types.StringAlignment.Near;
                                }
                        }
                }


                public Field Clone()
                {
                        Field Res = new Field();

                        Res.Name = this.Name;
                        Res.Label = this.Label;
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
