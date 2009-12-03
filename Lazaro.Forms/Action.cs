using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms
{
        public static class DefaultActions 
        {
                public static Action AcceptAction = new Action(null, "accept", "Aceptar");
                public static Action SaveAction = new Action(null, "accept", "Guardar");
                public static Action CancelAction = new Action(null, "cancel", "Cancelar");
                public static Action PrintAction = new Action(null, "accept", "Aceptar");
        }

        public class Action
        {
                public string Name, Label;
                public Form ParentForm;
                public DetailLevels MinDetailLevel = DetailLevels.Minimum;

                public delegate void ActionHandler(object source);
                public event ActionHandler ActionClick;

                public Action(Form parentForm, string name, string label)
                {
                        this.ParentForm = parentForm;
                        this.Name = name;
                        this.Label = label;
                }

                public override string ToString()
                {
                        string Res = "Action " + this.Name + @" """ + this.Label + @"""";
                        return Res;
                }
        }
}
