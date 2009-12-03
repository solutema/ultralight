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
