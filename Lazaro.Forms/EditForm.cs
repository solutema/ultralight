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

namespace Lazaro.Forms
{
        public class EditForm : ActionForm
        {
                public Lbl.ElementoDeDatos Element;

                public EditForm()
                {
                        this.Actions.AcceptAction = DefaultActions.SaveAction;
                        this.Actions.CancelAction = DefaultActions.CancelAction;
                }

                public EditForm(Lbl.ElementoDeDatos element)
                        : this()
                {
                        this.LoadFromElement(element);
                }

                public EditForm(Lfx.Data.TableStructure fromTable)
                        : this()
                {
                        this.CreateFromTableStructure(fromTable);       
                }

                public void CreateFromTableStructure(Lfx.Data.TableStructure fromTable)
                {
                        foreach (Lfx.Data.ColumnDefinition col in fromTable.Columns.Values) {
                                Lazaro.Forms.FormSection Sect;
                                if (col.Section == null) {
                                        if (this.Sections == null || this.Sections.Count == 0)
                                                this.Sections.Add(new Lazaro.Forms.FormSection("General"));
                                        Sect = this.Sections["General"];
                                } else {
                                        if (this.Sections == null || this.Sections.Contains(col.Section) == false)
                                                this.Sections.Add(new Lazaro.Forms.FormSection(col.Section));
                                        Sect = this.Sections[col.Section];
                                }
                                // Agregar controles
                                Lazaro.Forms.Controls.Control Ctl = null;
                                switch(col.InputFieldType) {
                                        case Lfx.Data.InputFieldTypes.Serial:
                                                // No se muestran en el formulario de edición
                                                break;
                                        case Lfx.Data.InputFieldTypes.Text:
                                                Ctl = new Lazaro.Forms.Controls.SimpleTextBox(col.Label, col.Name);
                                                break;
                                        case Lfx.Data.InputFieldTypes.Relation:
                                                Lazaro.Forms.Controls.MasterDetail MasCtl = new Lazaro.Forms.Controls.MasterDetail(col.Label, col.Name);
                                                MasCtl.Relation = col.Relation;
                                                Ctl = MasCtl;
                                                break;
                                }

                                if (Ctl != null)
                                        Sect.Controls.Add(Ctl);
                        }
                }

                public void LoadFromElement(Lbl.ElementoDeDatos element)
                {
                        // El formulario no tiene un formato definido. Lo defino analizando la estructura de la tabla.
                        if (this.Sections == null || this.Sections.Count == 0)
                                this.CreateFromTableStructure(Lfx.Data.DataBaseCache.DefaultCache.TableStructures[element.TablaDatos]);

                        this.Element = element;
                        foreach (FormSection Sec in this.Sections) {
                                foreach (Controls.Control Ctl in Sec.Controls) {
                                        if (Ctl is Controls.EntryControl) {
                                                Controls.EntryControl EntryCtl = Ctl as Controls.EntryControl;
                                                EntryCtl.Value = element.Registro[EntryCtl.ColumnName];
                                        }
                                }
                        }
                }

                public string Caption
                {
                        get
                        {
                                if (this.Element != null && this.Element.Existe)
                                        return this.Element.ToString();
                                else
                                        return "Formulario de alta";
                        }
                }
        }
}
