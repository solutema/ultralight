using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms.Controls
{
        public class Control
        {
                public FormSection Parent;
                public DetailLevels MinDetailLevel = DetailLevels.Minimum;
                public string Label = null;

                public Control(FormSection parent)
                {
                        this.Parent = parent;
                }

                public Control(string label)
                {
                        this.Label = label;
                }
        }

        public class ControlCollection : System.Collections.CollectionBase
        {
                private FormSection Parent = null;

                public ControlCollection(FormSection parent)
                {
                        this.Parent = parent;
                }

                public void Add(Control control)
                {
                        control.Parent = this.Parent;
                        this.List.Add(control);
                }

                public Control this[int index]
                {
                        get
                        {
                                return ((Control)(this.List[index]));
                        }
                }
        }
}
