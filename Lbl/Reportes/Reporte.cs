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
using System.Text;
using Lfx.FileFormats.Office.Spreadsheet;

namespace Lbl.Reportes
{
        public class Reporte
        {
                public Lfx.Data.Connection DataBase;
                public string Titulo = "Reporte";

                public qGen.Select SelectCommand;
                public Lfx.Data.Grouping Grouping = null;
                public System.Collections.Generic.List<Lfx.Data.Aggregate> Aggregates = new List<Lfx.Data.Aggregate>();
                public System.Collections.Generic.List<Lfx.Data.FormField> Fields = new List<Lfx.Data.FormField>();
                public bool ExpandGroups = true;

                public Reporte(Lfx.Data.Connection dataBase, qGen.Select selectCommand)
                {
                        this.DataBase = dataBase;
                        this.SelectCommand = selectCommand;
                }

                public Lfx.FileFormats.Office.Spreadsheet.Sheet ToWorkbookSheet()
                {
                        Lfx.FileFormats.Office.Spreadsheet.Sheet Res = new Lfx.FileFormats.Office.Spreadsheet.Sheet(Titulo);

                        foreach (Lfx.Data.Aggregate Agru in this.Aggregates) {
                                Agru.Reset();
                        }

                        foreach (Lfx.Data.FormField Field in this.Fields) {
                                Res.ColumnHeaders.Add(new ColumnHeader(Field.Label, Field.Width, Field.Alignment));
                        }

                        if (this.Grouping != null)
                                this.Grouping.Reset();

                        qGen.Select Sel = this.SelectCommand.Clone();
                        if (this.Grouping != null) {
                                if (Sel.Order == null || Sel.Order.Length == 0)
                                        Sel.Order = this.Grouping.Field.ColumnName;
                                else
                                        Sel.Order = this.Grouping.Field.ColumnName + "," + Sel.Order;
                        }

                        System.Data.DataTable Tabla = DataBase.Select(Sel);
                        foreach (System.Data.DataRow Registro in Tabla.Rows) {
                                if (this.Grouping != null && Lfx.Types.Object.CompareByValue(this.Grouping.LastValue, Registro[Lfx.Data.Connection.GetFieldName(this.Grouping.Field.ColumnName)]) != 0) {
                                        // Agrego un renglón de subtotales
                                        if (this.Grouping.LastValue != null) {
                                                Lfx.FileFormats.Office.Spreadsheet.Row SubTotales;
                                                if (this.ExpandGroups)
                                                        SubTotales = new Lfx.FileFormats.Office.Spreadsheet.AggregationRow(Res);
                                                else
                                                        SubTotales = new Lfx.FileFormats.Office.Spreadsheet.Row(Res);
                                                for (int i = 0; i < this.Fields.Count; i++) {
                                                        Lfx.FileFormats.Office.Spreadsheet.Cell FuncCell = null;
                                                        if (this.Grouping != null && this.Fields[i].ColumnName == this.Grouping.Field.ColumnName && this.ExpandGroups == false) {
                                                                FuncCell = new Cell(this.Grouping.LastValue);
                                                        } else {
                                                                foreach (Lfx.Data.Aggregate SubtAgru in this.Aggregates) {
                                                                        if (SubtAgru.Field.ColumnName == this.Fields[i].ColumnName) {
                                                                                switch (SubtAgru.Function) {
                                                                                        case Lfx.Data.AggregationFunctions.Count:
                                                                                                FuncCell = new Cell(SubtAgru.Count);
                                                                                                SubtAgru.ResetCounters();
                                                                                                break;
                                                                                        case Lfx.Data.AggregationFunctions.Sum:
                                                                                                FuncCell = new Cell(SubtAgru.Sum);
                                                                                                SubtAgru.ResetCounters();
                                                                                                break;
                                                                                        default:
                                                                                                FuncCell = new Cell("#undef#");
                                                                                                SubtAgru.ResetCounters();
                                                                                                break;
                                                                                }
                                                                        }
                                                                }
                                                        }
                                                        if (FuncCell != null)
                                                                SubTotales.Cells.Add(FuncCell);
                                                        else
                                                                SubTotales.Cells.Add(new Cell(""));
                                                }
                                                Res.Rows.Add(SubTotales);
                                        }
                                        this.Grouping.LastValue = Registro[Lfx.Data.Connection.GetFieldName(this.Grouping.Field.ColumnName)];

                                        // Agrego un encabezado
                                        if (ExpandGroups)
                                                Res.Rows.Add(new Lfx.FileFormats.Office.Spreadsheet.HeaderRow(Registro[Lfx.Data.Connection.GetFieldName(this.Grouping.Field.ColumnName)].ToString()));
                                }

                                if (Aggregates != null) {
                                        // Calculo las funciones de agregación
                                        foreach (Lfx.Data.Aggregate Agru in this.Aggregates) {
                                                string ColName = Lfx.Data.Connection.GetFieldName(Agru.Field.ColumnName);
                                                switch (Agru.Function) {
                                                        case Lfx.Data.AggregationFunctions.Count:
                                                                Agru.Count++;
                                                                break;
                                                        case Lfx.Data.AggregationFunctions.Sum:
                                                                Agru.Sum += System.Convert.ToDecimal(Registro[Lfx.Data.Connection.GetFieldName(Agru.Field.ColumnName)]);
                                                                break;
                                                }
                                        }
                                }
                                if (ExpandGroups) {
                                        Lfx.FileFormats.Office.Spreadsheet.Row Renglon = new Lfx.FileFormats.Office.Spreadsheet.Row();
                                        foreach (Lfx.Data.FormField Field in this.Fields) {
                                                Lfx.FileFormats.Office.Spreadsheet.Cell Celda = new Cell(Registro[Lfx.Data.Connection.GetFieldName(Field.ColumnName)]);
                                                Renglon.Cells.Add(Celda);
                                        }
                                        Res.Rows.Add(Renglon);
                                }
                        }

                        return Res;
                }
        }
}
