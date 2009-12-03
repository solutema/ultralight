using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms
{
        public class ActionForm : Form
        {
                public ActionCollection Actions;

                public ActionForm()
                {
                        Actions = new ActionCollection(this);
                }
        }
}
