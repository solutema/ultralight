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
using System.Text;
using Lazaro.Pres.Spreadsheet;

namespace Lbl.Reportes
{
        public class Reporte2
        {
                public Lfx.Data.Connection DataBase;
                public string Titulo = "Reporte";

                public qGen.Select SelectCommand;
                public Lfx.Data.Grouping Grouping = null;
                public System.Collections.Generic.List<Lfx.Data.Aggregate> Aggregates = new List<Lfx.Data.Aggregate>();
                public Lazaro.Pres.FieldCollection Fields = new Lazaro.Pres.FieldCollection();
                public bool ExpandGroups = true;

                public Reporte2(Lfx.Data.Connection dataBase, qGen.Select selectCommand)
                {
                        this.DataBase = dataBase;
                        this.SelectCommand = selectCommand;
                }

                public Lazaro.Pres.Spreadsheet.Sheet ToWorkbookSheet()
                {
                        Lazaro.Pres.Spreadsheet.Sheet Res = new Lazaro.Pres.Spreadsheet.Sheet(Titulo);

                        foreach (Lfx.Data.Aggregate Agru in this.Aggregates) {
                                Agru.Reset();
                        }

                        foreach (Lazaro.Pres.Field Field in this.Fields) {
                                Res.ColumnHeaders.Add(new ColumnHeader(Field.Label, Field.Width, Field.Alignment));
                        }

                        if (this.Grouping != null)
                                this.Grouping.Reset();

                        qGen.Select Sel = this.SelectCommand.Clone();
                        if (this.Grouping != null) {
                                if (Sel.Order == null || Sel.Order.Length == 0)
                                        Sel.Order = this.Grouping.FieldName;
                                else
                                        Sel.Order = this.Grouping.FieldName + "," + Sel.Order;
                        }

                        System.Data.DataTable Tabla = DataBase.Select(Sel);
                        foreach (System.Data.DataRow Registro in Tabla.Rows) {
                                if (this.Grouping != null && Lfx.Types.Object.CompareByValue(this.Grouping.LastValue, Registro[Lfx.Data.Field.GetNameOnly(this.Grouping.FieldName)]) != 0) {
                                        // Agrego un renglón de subtotales
                                        if (this.Grouping.LastValue != null) {
                                                Lazaro.Pres.Spreadsheet.Row SubTotales;
                                                if (this.ExpandGroups)
                                                        SubTotales = new Lazaro.Pres.Spreadsheet.AggregationRow(Res);
                                                else
                                                        SubTotales = new Lazaro.Pres.Spreadsheet.Row(Res);
                                                for (int i = 0; i < this.Fields.Count; i++) {
                                                        Lazaro.Pres.Spreadsheet.Cell FuncCell = null;
                                                        if (this.Grouping != null && this.Fields[i].Name == this.Grouping.FieldName && this.ExpandGroups == false) {
                                                                FuncCell = new Cell(this.Grouping.LastValue);
                                                        } else {
                                                                foreach (Lfx.Data.Aggregate SubtAgru in this.Aggregates) {
                                                                        if (SubtAgru.FieldName == this.Fields[i].Name) {
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
                                        this.Grouping.LastValue = Registro[Lfx.Data.Field.GetNameOnly(this.Grouping.FieldName)];

                                        // Agrego un encabezado
                                        if (ExpandGroups)
                                                Res.Rows.Add(new Lazaro.Pres.Spreadsheet.HeaderRow(Registro[Lfx.Data.Field.GetNameOnly(this.Grouping.FieldName)].ToString()));
                                }

                                if (Aggregates != null) {
                                        // Calculo las funciones de agregación
                                        foreach (Lfx.Data.Aggregate Agru in this.Aggregates) {
                                                switch (Agru.Function) {
                                                        case Lfx.Data.AggregationFunctions.Count:
                                                                Agru.Count++;
                                                                break;
                                                        case Lfx.Data.AggregationFunctions.Sum:
                                                                Agru.Sum += System.Convert.ToDecimal(Registro[Lfx.Data.Field.GetNameOnly(Agru.FieldName)]);
                                                                break;
                                                }
                                        }
                                }
                                if (ExpandGroups) {
                                        Lazaro.Pres.Spreadsheet.Row Renglon = new Lazaro.Pres.Spreadsheet.Row();
                                        foreach (Lazaro.Pres.Field Field in this.Fields) {
                                                Lazaro.Pres.Spreadsheet.Cell Celda = new Cell(Registro[Lfx.Data.Field.GetNameOnly(Field.Name)]);
                                                Renglon.Cells.Add(Celda);
                                        }
                                        Res.Rows.Add(Renglon);
                                }
                        }

                        return Res;
                }
        }
}
