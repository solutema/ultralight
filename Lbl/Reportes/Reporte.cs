// Copyright 2004-2009 South Bridge S.R.L.
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

using System;
using System.Collections.Generic;
using System.Text;
using Lfx.FileFormats.Office.Spreadsheet;

namespace Lbl.Reportes
{
        public class Reporte
        {
                public Lws.Data.DataView DataView;
                public string Titulo = "Reporte";

                public Lfx.Data.SqlSelectBuilder SelectCommand;
                public System.Collections.Generic.List<Lfx.Data.Grouping> Grupings = new List<Lfx.Data.Grouping>();
                public System.Collections.Generic.List<Lfx.Data.FormField> Fields = new List<Lfx.Data.FormField>();

                public Reporte(Lws.Data.DataView dataView, Lfx.Data.SqlSelectBuilder selectCommand)
                {
                        this.DataView = dataView;
                        this.SelectCommand = selectCommand;
                }

                public Lfx.FileFormats.Office.Spreadsheet.Sheet ToWorkbookSheet()
                {
                        Lfx.FileFormats.Office.Spreadsheet.Sheet Res = new Lfx.FileFormats.Office.Spreadsheet.Sheet(Titulo);

                        foreach (Lfx.Data.Grouping Agru in this.Grupings) {
                                Agru.Reset();
                        }

                        foreach (Lfx.Data.FormField Field in this.Fields) {
                                Res.ColumnHeaders.Add(new ColumnHeader(Field.Label, Field.Width, Field.Alignment));
                        }
                        
                        System.Data.DataTable Tabla = DataView.DataBase.Select(this.SelectCommand);
                        foreach (System.Data.DataRow Registro in Tabla.Rows) {
                                Lfx.FileFormats.Office.Spreadsheet.Row Renglon = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                if (Grupings != null) {
                                        foreach (Lfx.Data.Grouping Agru in this.Grupings) {
                                                string ColName = Lfx.Data.DataBase.GetFieldName(Agru.Field.ColumnName);
                                                switch (Agru.Type) {
                                                        case Lfx.Data.GroupingTypes.Distinct:
                                                                if (Lfx.Types.Object.ObjectsEqualByValue(Agru.LastValue, Registro[ColName]) == false) {
                                                                        // Agrego un renglón de subtotales
                                                                        if (Agru.LastValue != null) {
                                                                                Lfx.FileFormats.Office.Spreadsheet.Row SubTotales = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                                                                for (int i = 0; i < Tabla.Columns.Count; i++) {
                                                                                        foreach (Lfx.Data.Grouping SubtAgru in this.Grupings) {
                                                                                                if (Lfx.Data.DataBase.GetFieldName(SubtAgru.Field.ColumnName) == Tabla.Columns[i].ColumnName) {
                                                                                                        switch (SubtAgru.Type) {
                                                                                                                case Lfx.Data.GroupingTypes.Count:
                                                                                                                        SubTotales.Cells.Add(new Cell(SubtAgru.Count));
                                                                                                                        break;
                                                                                                                case Lfx.Data.GroupingTypes.Sum:
                                                                                                                        SubTotales.Cells.Add(new Cell(SubtAgru.Sum));
                                                                                                                        break;
                                                                                                                default:
                                                                                                                        SubTotales.Cells.Add(new Cell(""));
                                                                                                                        break;
                                                                                                        }
                                                                                                } else {
                                                                                                        SubTotales.Cells.Add(new Cell(""));
                                                                                                }
                                                                                        }
                                                                                }
                                                                                SubTotales.BackColor = System.Drawing.Color.LightBlue;
                                                                                Res.Rows.Add(SubTotales);
                                                                        }
                                                                        Agru.LastValue = Registro[ColName];
                                                                        Agru.ResetCounters();
                                                                }
                                                                break;
                                                        case Lfx.Data.GroupingTypes.Count:
                                                                Agru.Count++;
                                                                break;
                                                        case Lfx.Data.GroupingTypes.Sum:
                                                                Agru.Sum += System.Convert.ToDouble(Registro[Lfx.Data.DataBase.GetFieldName(Agru.Field.ColumnName)]);
                                                                break;
                                                } 
                                        }
                                }

                                foreach (Lfx.Data.FormField Field in this.Fields) {
                                        Lfx.FileFormats.Office.Spreadsheet.Cell Celda = new Cell(Registro[Lfx.Data.DataBase.GetFieldName(Field.ColumnName)]);
                                        Renglon.Cells.Add(Celda);
                                }
                                Res.Rows.Add(Renglon);
                        }

                        return Res;
                }
        }
}
