#region License
// Copyright 2004-2010 Carrea Ernesto N., Martínez Miguel A.
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
using System.Linq;
using System.Text;

namespace Lbl
{
        public class ListaIds : List<int>
        {
                public ListaIds()
                {
                }

                public ListaIds(string fromCsv)
                {
                        this.FromCsv(fromCsv);
                }

                public ListaIds(System.Data.DataTable dataTable)
                {
                        this.FromDataTable(dataTable);
                }

                public void FromCsv(string fromCsv)
                {
                        this.Clear();
                        string[] Valores = fromCsv.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string Val in Valores) {
                                this.Add(Lfx.Types.Parsing.ParseInt(Val));
                        }
                }

                public void FromDataTable(System.Data.DataTable dataTable)
                {
                        this.Clear();
                        foreach (System.Data.DataRow Row in dataTable.Rows) {
                                this.Add(System.Convert.ToInt32(Row[0]));
                        }
                }

                /// <summary>
                /// Convierte la lista a una cadena, en la forma de una lista de valores separados por comas.
                /// </summary>
                /// <returns>Una lista de valores separados por comas.</returns>
                public override string ToString()
                {
                        StringBuilder Res = new StringBuilder();

                        foreach (int i in this) {
                                if (Res.Length != 0)
                                        Res.Append(",");
                                Res.Append(i);
                        }

                        return Res.ToString();
                }
        }
}