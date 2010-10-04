using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lui.Forms
{
        public class ButtonGroup : FlowLayoutPanel
        {
                ButtonCollection Buttons;

                public ButtonGroup()
                {
                        this.Buttons = new ButtonCollection(this);
                }
        }
}
