using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms
{
        public class FormSection
        {
                public string Name;
                public Form Parent;
                public System.Collections.Generic.List<Controls.Control> Controls = new List<Controls.Control>();

                public FormSection(string name)
                {
                        this.Name = name;
                }

                public void AddControl(Controls.Control control)
                {
                        control.Parent = this;
                        this.Controls.Add(control);
                }

                public override string ToString()
                {
                        if (this.Parent == null)
                                return this.Name;
                        else
                                return this.Name + " en " + this.Parent.ToString();
                }
        }

        public class FormSectionCollection : System.Collections.CollectionBase
        {
                private Form Parent = null;

                public FormSectionCollection(Form parent)
                {
                        this.Parent = parent;
                }

                public void Add(FormSection section)
                {
                        section.Parent = this.Parent;
                        this.List.Add(section);
                }

                public bool Contains(string name)
                {
                        foreach(FormSection sect in this.List) {
                                if (sect.Name == name)
                                        return true;
                        }
                        return false;
                }

                public FormSection this[string name]
                {
                        get
                        {
                                foreach (FormSection sect in this.List) {
                                        if (sect.Name == name)
                                                return sect;
                                }
                                return null;
                        }
                }
        }
}
